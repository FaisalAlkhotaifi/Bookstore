using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Core
{
    // Table name: BS205_BookBookstore
    public class BookBookstore
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }

        public int BookstoreId { get; set; }
        public Bookstore? Bookstore { get; set; }
    }
}
