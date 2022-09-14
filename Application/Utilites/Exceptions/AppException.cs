using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utilites.Exceptions
{
    public class AppException : ApplicationException
    {
        public AppException(string errorMessage) : base(errorMessage)
        {}
    }
}
