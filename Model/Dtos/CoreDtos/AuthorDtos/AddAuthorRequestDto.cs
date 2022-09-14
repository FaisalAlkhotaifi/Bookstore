using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.CoreDtos.AuthorDtos
{
    public class AddAuthorRequestDto
    {
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
    }

    public class AddAuthorRequestValidator : AbstractValidator<AddAuthorRequestDto>
    {
        public AddAuthorRequestValidator()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.BirthDate)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Nationality)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Gender)
                .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
