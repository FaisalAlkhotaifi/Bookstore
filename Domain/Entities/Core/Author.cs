using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Core
{
    // Table name: BS202_Author
    public class Author : BaseEntity
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

        public ICollection<Book> Books { get; private set; }
    }
}
