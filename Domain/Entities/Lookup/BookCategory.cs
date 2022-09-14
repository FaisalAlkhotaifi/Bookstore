using Domain.Common;
using Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Lookup
{
    // Table name: BS401_BookCategory
    public class BookCategory : BaseEntity
    {
        public BookCategory()
        {
            Books = new HashSet<Book>();
        }

        public string Name { get; set; } = string.Empty;

        public ICollection<Book> Books { get; private set; }
    }
}
