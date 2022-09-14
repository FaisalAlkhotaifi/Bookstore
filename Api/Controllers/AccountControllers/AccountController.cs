using Api.Common;
using Contract.ApplicationContracts.AccountContracts;
using Microsoft.AspNetCore.Mvc;
using Model.Dtos.AccountDtos;
using Newtonsoft.Json;

namespace Api.Controllers.AccountControllers
{
    public class AccountController : ApiControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("register-admin")]
        public async Task<IActionResult> RegisterAdmin(AdminRegistrationRequestDto model)
        {
            var response = await _accountService.RegisterAdmin(model);
            return Ok(response);
        }

        [HttpPost("login-admin")]
        public async Task<IActionResult> LoginAdmin(AdminLoginRequestDto model)
        {
            var response = await _accountService.LoginAdmin(model);
            return Ok(response);
        }
    }
}
