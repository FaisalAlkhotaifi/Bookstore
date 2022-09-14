using Application.Utilites.Exceptions;
using Application.Utilites.Helper;
using Contract.ApplicationContracts.CoreContracts;
using Contract.RepoContracts;
using Domain.Entities.Core;
using Model.Dtos.CoreDtos.CustomerDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CoreServices
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepo<Customer> _customerService;
        private readonly IRepo<Bookstore> _bookstoreService;

        public CustomerService(
            IRepo<Customer> customerService, 
            IRepo<Bookstore> bookstoreService
        )
        {
            _customerService = customerService;
            _bookstoreService = bookstoreService;
        }

        public async Task<int> Create(AddCutomerRequestDto model)
        {
            await ValidateHelper
                .ValidateModel<AddCutomerRequestValidator, AddCutomerRequestDto>(model);

            var bookStores = model.BookstoreIds != null
                ? await _bookstoreService.GetAllAsync(o => model.BookstoreIds.Contains(o.Id))
                : null;
            if (bookStores == null)
            {
                throw new AppException("Not valid bookstores. Please provide valid bookstores");
            }

            var entity = new Customer
            {
                Name = model.Name,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber
            };

            foreach (var bookstore in bookStores)
            {
                entity.Bookstores.Add(bookstore);
            }

            entity = await _customerService.AddAndSaveAsync(entity);

            return entity.Id;
        }
    }
}
