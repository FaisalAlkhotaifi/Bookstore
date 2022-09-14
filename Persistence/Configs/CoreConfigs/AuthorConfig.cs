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
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("BS202_Author");

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(o => o.FullName)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(o => o.BirthDate)
                .IsRequired();
            builder.Property(o => o.Nationality)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(o => o.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(o => o.Gender)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
