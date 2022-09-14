using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.AccountDtos
{
    public class AdminLoginRequestDto
    {
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }

    public class AdminLoginRequestValidator : AbstractValidator<AdminLoginRequestDto>
    {
        public AdminLoginRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .EmailAddress().WithMessage("Email is not in the corrent format");
            RuleFor(x => x.Password)
               .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
