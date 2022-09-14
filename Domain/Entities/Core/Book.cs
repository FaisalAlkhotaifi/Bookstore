using Domain.Common;
using Domain.Entities.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Core
{
    // Table name: BS201_Book
    public class Book : BaseEntity
    {
        public Book()
        {
            Bookstores = new HashSet<Bookstore>();
        }

        public string Title { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }

        public int BS401_BookCategory_Id { get; set; }
        public BookCategory? BookCategory { get; set; }

        public int BS202_Author_Id { get; set; }
        public Author? Author { get; set; }

        public ICollection<Bookstore> Bookstores { get; private set; }
    }
}
