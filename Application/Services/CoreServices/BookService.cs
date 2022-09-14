using Application.Utilites.Exceptions;
using Application.Utilites.Helper;
using AutoMapper;
using Contract.ApplicationContracts.CoreContracts;
using Contract.RepoContracts;
using Domain.Entities.Core;
using Domain.Entities.Lookup;
using Model.Dtos.CoreDtos.BookDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CoreServices
{
    public class BookService : IBookService
    {
        private readonly IRepo<Book> _bookRepo;
        private readonly IRepo<BookCategory> _bookCategoryRepo;
        private readonly IRepo<Author> _authorRepo;
        private readonly IMapper _mapper;

        public BookService(
            IRepo<Book> bookRepo,
            IMapper mapper,
            IRepo<BookCategory> bookCategoryRepo,
            IRepo<Author> authorRepo
        )
        {
            _bookRepo = bookRepo;
            _mapper = mapper;
            _bookCategoryRepo = bookCategoryRepo;
            _authorRepo = authorRepo;
        }

        public async Task<GetBookByIdRequestDto> GetById(int id)
        {
            var entity = await GetEntity(id);
            await _bookRepo.GetEntry(entity).Reference("BookCategory").LoadAsync();
            await _bookRepo.GetEntry(entity).Reference("Author").LoadAsync();
            await _bookRepo.GetEntry(entity).Collection("Bookstores").LoadAsync();

            var data = _mapper.Map<GetBookByIdRequestDto>(entity);
            data.TotalBookstores = entity.Bookstores.Count();

            return data;
        }

        public async Task<IReadOnlyList<GetAllBooksResponseDto>> GetAll(SearchBookRequestDto model)
        {
            var data = await _bookRepo.GetAllAsync(o => 
                (string.IsNullOrEmpty(model.Title) || o.Title == model.Title) &&
                (model.PublishDate == null || o.PublishDate == model.PublishDate)
            );
            return _mapper.Map<IReadOnlyList<GetAllBooksResponseDto>>(data);
        }

        public async Task<int> Create(AddBookRequestDto model)
        {
            await ValidateHelper
                .ValidateModel<AddBookRequestValidator, AddBookRequestDto>(model);

            var isValidCategoryId = await _bookCategoryRepo.IsExistAsync(o => o.Id == model.BookCategoryId);
            if (!isValidCategoryId)
            {
                throw new AppException("Invalid book category. Please provide a valid category");
            }
            var isValidAuthorId = await _authorRepo.IsExistAsync(o => o.Id == model.AuthorId);
            if (!isValidAuthorId)
            {
                throw new AppException("Invalid author. Please provide a valid author");
            }

            var entity = new Book
            {
                Title = model.Title,
                PublishDate = model.PublishDate,
                Price = model.Price,
                BS401_BookCategory_Id = model.BookCategoryId,
                BS202_Author_Id = model.AuthorId
            };

            if (model.Bookstores != null)
            {
                foreach (var bookstore in model.Bookstores)
                {
                    entity.Bookstores.Add(new Bookstore
                    {
                        Name = bookstore.Name,
                        Address = bookstore.Address
                    });
                }
            }

            entity = await _bookRepo.AddAndSaveAsync(entity);

            return entity.Id;
        }

        public async Task Update(int id, UpdateBookRequestDto model)
        {
            var entity = await GetEntity(id);

            await ValidateHelper
                .ValidateModel<UpdateBookRequestValidator, UpdateBookRequestDto>(model);
            
            await _bookRepo.GetEntry(entity).Reference("Author").LoadAsync();

            entity.Title = model.Title;
            entity.PublishDate = model.PublishDate;
            entity.Price = model.Price;
            entity.BS401_BookCategory_Id = model.BookCategoryId;
            entity.BS202_Author_Id = model.AuthorId;

            await _bookRepo.UpdateAndSaveAsync(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await GetEntity(id);
            await _bookRepo.DeleteAndSaveAsync(entity);
        }


        #region Private Methods

        private async Task<Book> GetEntity(int id)
        {
            var entity = await _bookRepo.GetByIdAsync(id);
            if (entity == null)
            {
                throw new NotFoundException($"Book ({id}) is not found");
            }
            return entity;
        }

        #endregion
    }
}
