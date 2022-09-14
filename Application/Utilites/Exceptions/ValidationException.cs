using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utilites.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public ValidationException(ValidationResult validationResult)
            : base($"{string.Join(",", validationResult.Errors.Select(o => o.ErrorMessage))}")
        { }

        public ValidationException(string validateError)
            : base(validateError)
        { }
    }
}