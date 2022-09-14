using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.CoreDtos.BookDtos
{
    public class UpdateBookRequestDto
    {
        public string Title { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }

        public int BookCategoryId { get; set; }
        public int AuthorId { get; set; }
    }

    public class UpdateBookRequestValidator : AbstractValidator<UpdateBookRequestDto>
    {
        public UpdateBookRequestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.PublishDate)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Price)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.BookCategoryId)
                .NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.AuthorId)
                .NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
