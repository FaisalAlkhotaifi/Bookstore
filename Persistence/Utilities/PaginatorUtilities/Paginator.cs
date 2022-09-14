using Microsoft.EntityFrameworkCore;
using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Utilities.PaginatorUtilities
{
    public class Paginator<T> : List<T> where T : class
    {
        public static async Task<PaginateObject<T>> Create(IQueryable<T> source, int pageIndex, int pageSize)
        {
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            var currentIndex = (pageIndex - 1) * pageSize;

            var count = await source.CountAsync();
            if (count < currentIndex)
            {
                return new PaginateObject<T>(new List<T>(), count, pageIndex, pageSize);
            }

            var items = await source.Skip(currentIndex).Take(pageSize).AsNoTracking().ToListAsync();

            return new PaginateObject<T>(items, count, pageIndex, pageSize);
        }
    }
}
