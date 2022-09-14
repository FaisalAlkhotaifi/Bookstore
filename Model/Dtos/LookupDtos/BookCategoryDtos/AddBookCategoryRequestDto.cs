using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.LookupDtos.BookCategoryDtos
{
    public class AddBookCategoryRequestDto
    {
        public string Name { get; set; } = string.Empty;
    }

    public class AddBookCategoryRequestValidator : AbstractValidator<AddBookCategoryRequestDto>
    {
        public AddBookCategoryRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
