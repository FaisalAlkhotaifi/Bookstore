using Application.Utilites.Exceptions;
using Application.Utilites.Helper;
using AutoMapper;
using Contract.ApplicationContracts.LookupContracts;
using Contract.RepoContracts;
using Domain.Entities.Lookup;
using Model.Dtos.LookupDtos.BookCategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.LookupContracts
{
    public class BookCategoryService : IBookCategoryService
    {
        private readonly IRepo<BookCategory> _bookCategoryRepo;
        private readonly IMapper _mapper;

        public BookCategoryService(
            IRepo<BookCategory> bookCategoryRepo,
            IMapper mapper
        )
        {
            _bookCategoryRepo = bookCategoryRepo;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<GetAllBookCategoryResponseDto>> GetAll(SearchBookCategoriesRequestDto model)
        {
            var data = await _bookCategoryRepo
                .GetAllAsync(o => 
                    string.IsNullOrWhiteSpace(model.Name) || 
                    o.Name == model.Name);

            return _mapper.Map<IReadOnlyList<GetAllBookCategoryResponseDto>>(data);
        }

        public async Task<int> Create(AddBookCategoryRequestDto model)
        {
            await ValidateHelper
                .ValidateModel<AddBookCategoryRequestValidator, AddBookCategoryRequestDto>(model);

            var entity = new BookCategory
            {
                Name = model.Name,
            };
            entity = await _bookCategoryRepo.AddAndSaveAsync(entity);

            return entity.Id;
        }

        public async Task Update(int id, UpdateBookCategoryRequestDto model)
        {
            await ValidateHelper
                .ValidateModel<UpdateBookCategoryRequestValidator, UpdateBookCategoryRequestDto>(model);

            var entity = await GetEntity(id);

            entity.Name = model.Name;

            await _bookCategoryRepo.UpdateAndSaveAsync(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await GetEntity(id);
            await _bookCategoryRepo.DeleteAndSaveAsync(entity);
        }


        #region Private Methods

        private async Task<BookCategory> GetEntity(int id)
        {
            var entity = await _bookCategoryRepo.GetByIdAsync(id);
            if (entity == null)
            {
                throw new NotFoundException($"Book category ({id}) is not found");
            }
            return entity;
        }

        #endregion
    }
}
