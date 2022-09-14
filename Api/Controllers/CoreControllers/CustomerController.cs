using Api.Attributes;
using Api.Common;
using Contract.ApplicationContracts.CoreContracts;
using Microsoft.AspNetCore.Mvc;
using Model.Constants;
using Model.Dtos.CoreDtos.CustomerDtos;

namespace Api.Controllers.CoreControllers
{
    [AppAuthorize(Role.Admin)]
    public class CustomerController : ApiControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddCutomerRequestDto model)
        {
            var response = await _customerService.Create(model);
            return Ok(response);
        }
    }
}
