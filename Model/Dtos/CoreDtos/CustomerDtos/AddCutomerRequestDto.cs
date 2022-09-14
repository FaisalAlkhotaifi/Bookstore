using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.CoreDtos.CustomerDtos
{
    public class AddCutomerRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public List<int>? BookstoreIds { get; set; }
    }

    public class AddCutomerRequestValidator : AbstractValidator<AddCutomerRequestDto>
    {
        public AddCutomerRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .EmailAddress().WithMessage("Email is not in the corrent format");
            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.BookstoreIds)
               .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
