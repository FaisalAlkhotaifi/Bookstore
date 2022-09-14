using Model.Dtos.LookupDtos.BookCategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.ApplicationContracts.LookupContracts
{
    public interface IBookCategoryService
    {
        Task<IReadOnlyList<GetAllBookCategoryResponseDto>> GetAll(SearchBookCategoriesRequestDto model);
        Task<int> Create(AddBookCategoryRequestDto model);
        Task Update(int id, UpdateBookCategoryRequestDto model);
        Task Delete(int id);
    }
}
