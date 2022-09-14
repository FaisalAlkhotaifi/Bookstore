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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("BS204_Customer");

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(o => o.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(o => o.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(o => o.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
