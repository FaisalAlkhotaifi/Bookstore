using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.LookupDtos.BookCategoryDtos
{
    public class SearchBookCategoriesRequestDto
    {
        public string? Name { get; set; }
    }

    public class SearchBookCategoriesRequestValidator : AbstractValidator<SearchBookCategoriesRequestDto>
    {
        public SearchBookCategoriesRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
