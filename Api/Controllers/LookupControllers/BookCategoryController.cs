using Api.Attributes;
using Api.Common;
using Contract.ApplicationContracts.LookupContracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Constants;
using Model.Dtos.LookupDtos.BookCategoryDtos;

namespace Api.Controllers.LookupControllers
{
    [AppAuthorize(Role.Admin)]
    public class BookCategoryController : ApiControllerBase
    {
        private readonly IBookCategoryService _bookCategoryService;

        public BookCategoryController(IBookCategoryService bookCategoryService)
        {
            _bookCategoryService = bookCategoryService;
        }

        [HttpPost("get-all-records")]
        public async Task<IActionResult> GetAll(SearchBookCategoriesRequestDto model)
        {
            var response = await _bookCategoryService.GetAll(model);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddBookCategoryRequestDto model)
        {
            var response = await _bookCategoryService.Create(model);
            return Ok(response);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Update(int id, UpdateBookCategoryRequestDto model)
        {
            await _bookCategoryService.Update(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _bookCategoryService.Delete(id);
            return Ok();
        }
    }
}
