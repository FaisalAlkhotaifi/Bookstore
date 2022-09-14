using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Core
{
    // Table name: BS204_Customer
    public class Customer : BaseEntity
    {
        public Customer()
        {
            Bookstores = new HashSet<Bookstore>();
        }

        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public ICollection<Bookstore> Bookstores { get; private set; }
    }
}
