using Domain.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configs.CoreConfigs
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("BS201_Book");

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(o => o.Title)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(o => o.PublishDate)
                .IsRequired();
            builder.Property(o => o.Price)
                .IsRequired();
            builder.Property(o => o.BS401_BookCategory_Id)
                .IsRequired();
            builder.Property(o => o.BS202_Author_Id)
                .IsRequired();

            builder.HasIndex(o => o.Title);
            builder.HasIndex(o => o.PublishDate);

            builder.HasOne(o => o.BookCategory)
                .WithMany(o => o.Books)
                .HasForeignKey(o => o.BS401_BookCategory_Id);
            builder.HasOne(o => o.Author)
                .WithMany(o => o.Books)
                .HasForeignKey(o => o.BS202_Author_Id);

            builder.HasMany(x => x.Bookstores)
                .WithMany(x => x.Books)
                .UsingEntity<BookBookstore>(
                    x => x.HasOne(x => x.Bookstore)
                    .WithMany().HasForeignKey(x => x.BookstoreId),
                    x => x.HasOne(x => x.Book)
                   .WithMany().HasForeignKey(x => x.BookId)
                );
        }
    }
}
