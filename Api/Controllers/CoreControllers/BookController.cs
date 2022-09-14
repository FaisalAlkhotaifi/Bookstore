using Api.Attributes;
using Api.Common;
using Contract.ApplicationContracts.CoreContracts;
using Microsoft.AspNetCore.Mvc;
using Model.Constants;
using Model.Dtos.CoreDtos.BookDtos;

namespace Api.Controllers.CoreControllers
{
    [AppAuthorize(Role.Admin)]
    public class BookController : ApiControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _bookService.GetById(id);
            return Ok(response);
        }

        [HttpPost("get-all-records")]
        public async Task<IActionResult> GetAll(SearchBookRequestDto model)
        {
            var response = await _bookService.GetAll(model);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddBookRequestDto model)
        {
            var response = await _bookService.Create(model);
            return Ok(response);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update(int id, UpdateBookRequestDto model)
        {
            await _bookService.Update(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bookService.Delete(id);
            return Ok();
        }
    }
}
