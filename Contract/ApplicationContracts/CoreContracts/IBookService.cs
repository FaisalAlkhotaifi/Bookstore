using Model.Dtos.CoreDtos.BookDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.ApplicationContracts.CoreContracts
{
    public interface IBookService
    {
        Task<GetBookByIdRequestDto> GetById(int id);
        Task<IReadOnlyList<GetAllBooksResponseDto>> GetAll(SearchBookRequestDto model);
        Task<int> Create(AddBookRequestDto model);
        Task Update(int id, UpdateBookRequestDto model);
        Task Delete(int id);
    }
}
