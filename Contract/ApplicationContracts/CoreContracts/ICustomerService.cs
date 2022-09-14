using Model.Dtos.CoreDtos.CustomerDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.ApplicationContracts.CoreContracts
{
    public interface ICustomerService
    {
        Task<int> Create(AddCutomerRequestDto model);
    }
}
