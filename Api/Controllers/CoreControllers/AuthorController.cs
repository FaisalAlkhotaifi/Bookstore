using Api.Attributes;
using Api.Common;
using Contract.ApplicationContracts.CoreContracts;
using Microsoft.AspNetCore.Mvc;
using Model.Constants;
using Model.Dtos.CoreDtos.AuthorDtos;

namespace Api.Controllers.CoreControllers
{
    [AppAuthorize(Role.Admin)]
    public class AuthorController : ApiControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _authorService.GetAll();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddAuthorRequestDto model)
        {
            var response = await _authorService.Create(model);
            return Ok(response);
        }
    }
}
