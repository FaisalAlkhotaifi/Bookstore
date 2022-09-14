using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos.CoreDtos.BookDtos
{
    public class AddBookRequestDto
    {
        public string Title { get; set; } = string.Empty;
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }

        public int BookCategoryId { get; set; }
        public int AuthorId { get; set; }

        public List<AddBookBookstoreRequestDto>? Bookstores { get; set; }
    }

    public class AddBookRequestValidator : AbstractValidator<AddBookRequestDto>
    {
        public AddBookRequestValidator()
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
            RuleFor(x => x.Bookstores)
                .NotEmpty().WithMessage("{PropertyName} is required");

            RuleForEach(x => x.Bookstores)
                .SetValidator(new AddBookBookstoreRequestValidator())
                .When(x => x.Bookstores != null);
        }
    }

    public class AddBookBookstoreRequestDto
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }

    public class AddBookBookstoreRequestValidator : AbstractValidator<AddBookBookstoreRequestDto>
    {
        public AddBookBookstoreRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} of bookstore is required");
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("{PropertyName} of bookstore is required");
        }
    }
}
