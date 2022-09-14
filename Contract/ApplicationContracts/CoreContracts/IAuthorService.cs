using Model.Dtos.CoreDtos.AuthorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.ApplicationContracts.CoreContracts
{
    public interface IAuthorService
    {
        Task<IReadOnlyList<GetAllAuthorResponseDto>> GetAll();
        Task<int> Create(AddAuthorRequestDto model);
    }
}
