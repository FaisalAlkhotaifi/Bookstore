using FluentValidation;
using Model.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.AccountDtos
{
    public class AdminRegistrationRequestDto
    {
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class AdminRegistrationRequestValidator : AbstractValidator<AdminRegistrationRequestDto>
    {
        public AdminRegistrationRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .EmailAddress().WithMessage("Email is not in the corrent format");
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Password)
               .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
