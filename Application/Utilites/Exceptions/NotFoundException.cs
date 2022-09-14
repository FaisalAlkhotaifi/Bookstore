using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utilites.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string errorMessage) : base(errorMessage)
        {}
    }
}
