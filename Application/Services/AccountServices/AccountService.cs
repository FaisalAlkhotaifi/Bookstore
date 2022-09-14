using Application.Utilites.Exceptions;
using Application.Utilites.Helper;
using AutoMapper;
using Contract.ApplicationContracts.AccountContracts;
using Contract.RepoContracts;
using Domain.Entities.Account;
using Microsoft.AspNetCore.Identity;
using Model.Constants;
using Model.Dtos.AccountDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.AccountServices
{
    public class AccountService : IAccountService
    {
        private readonly IRepo<Account> _accountRepo;
        private readonly IMapper _mapper;

        private readonly ITokenHelper _tokenHelper;
        private readonly IPasswordHelper _passwordHelper;

        public AccountService(
            IRepo<Account> accountRepo,
            IMapper mapper,
            ITokenHelper tokenHelper,
            IPasswordHelper passwordHelper
        )
        {
            _accountRepo = accountRepo;
            _mapper = mapper;
            _tokenHelper = tokenHelper;
            _passwordHelper = passwordHelper;
        }

        public async Task<int> RegisterAdmin(AdminRegistrationRequestDto model)
        {
            await ValidateHelper
                .ValidateModel<AdminRegistrationRequestValidator, AdminRegistrationRequestDto>(model);

            var isAccountExist = await _accountRepo.IsExistAsync(o => o.Email == model.Email);
            if (isAccountExist)
            {
                throw new AppException("Account already exist");
            }

            var passwordHashResult = _passwordHelper.CreateHash(model.Password);

            var account = new Account
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PasswordSalt = passwordHashResult.Salt,
                PasswordHash = passwordHashResult.Hash,
                Role = Role.Admin
            };
            account = await _accountRepo.AddAndSaveAsync(account);

            return account.Id;
        }

        public async Task<AuthResponseDto> LoginAdmin(AdminLoginRequestDto model)
        {
            await ValidateHelper
                .ValidateModel<AdminLoginRequestValidator, AdminLoginRequestDto>(model);

            var account = await _accountRepo.GetOneAsync(o => 
                o.Email == model.Email
            );
            if (account == null)
            {
                throw new AppException("Email or password is not correnct");
            }

            var isPasswordVerified = _passwordHelper.verifyHash(new VerifyPasswordHash
            {
                Password = model.Password,
                Hash = account.PasswordHash,
                Salt = account.PasswordSalt
            });

            if (!isPasswordVerified)
            {
                throw new AppException("Email or password is not correnct");
            }

            var data = _mapper.Map<AuthResponseDto>(account);
            data.Token = _tokenHelper.GenerateJwtToken(account);

            return data;
        }
    }
}
