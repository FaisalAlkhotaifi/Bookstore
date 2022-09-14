using Domain.Entities.Lookup;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configs.LookupConfigs
{
    public class BookCategoryConfig : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.ToTable("BS401_BookCategory");

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(o => o.Name)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
