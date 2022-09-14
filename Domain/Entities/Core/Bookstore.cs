using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Core
{
    // Table name: BS203_Bookstore
    public class Bookstore : BaseEntity
    {
        public Bookstore()
        {
            Books = new HashSet<Book>();
        }

        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public int? BS204_Customer_Id { get; set; }
        public Customer? Customer { get; set; }

        public ICollection<Book> Books { get; private set; }
    }
}
