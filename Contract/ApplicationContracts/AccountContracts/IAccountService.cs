using Model.Dtos.AccountDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.ApplicationContracts.AccountContracts
{
    public interface IAccountService
    {
        Task<int> RegisterAdmin(AdminRegistrationRequestDto model);
        Task<AuthResponseDto> LoginAdmin(AdminLoginRequestDto model);
    }
}
