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
    public class BookBookstoreConfig : IEntityTypeConfiguration<BookBookstore>
    {
        public void Configure(EntityTypeBuilder<BookBookstore> builder)
        {
            builder.ToTable("BS205_BookBookstore");

            builder.Property(e => e.Id)
                .HasColumnName("Id");
        }
    }
}
