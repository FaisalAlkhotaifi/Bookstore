using Application.Utilites.Helper;
using AutoMapper;
using Contract.ApplicationContracts.CoreContracts;
using Contract.RepoContracts;
using Domain.Entities.Core;
using Model.Dtos.CoreDtos.AuthorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CoreServices
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepo<Author> _autherRepo;
        private readonly IMapper _mapper;

        public AuthorService(
            IRepo<Author> autherRepo,
            IMapper mapper
        )
        {
            _autherRepo = autherRepo;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<GetAllAuthorResponseDto>> GetAll()
        {
            var data = await _autherRepo.GetAllAsync();
            return _mapper.Map<IReadOnlyList<GetAllAuthorResponseDto>>(data);
        }

        public async Task<int> Create(AddAuthorRequestDto model)
        {
            await ValidateHelper
                .ValidateModel<AddAuthorRequestValidator, AddAuthorRequestDto>(model);

            var entity = new Author
            {
                FullName = model.FullName,
                BirthDate = model.BirthDate,
                Nationality = model.Nationality,
                PhoneNumber = model.PhoneNumber,
                Gender = model.Gender,
            };
            entity = await _autherRepo.AddAndSaveAsync(entity);

            return entity.Id;
        }
    }
}
