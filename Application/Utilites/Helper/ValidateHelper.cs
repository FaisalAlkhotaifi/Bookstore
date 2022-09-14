using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utilites.Helper
{
    public static class ValidateHelper
    {
        public static async Task ValidateModel<TValidator, TModel>(TModel model)
            where TValidator : AbstractValidator<TModel>, new()
        {
            var validator = new TValidator();
            var validateResult = await validator.ValidateAsync(model);

            if (validateResult.Errors.Any())
            {
                throw new Exceptions.ValidationException(validateResult);
            }
        }
    }
}
