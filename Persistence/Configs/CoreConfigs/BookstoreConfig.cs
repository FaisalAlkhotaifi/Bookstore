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
    public class BookstoreConfig : IEntityTypeConfiguration<Bookstore>
    {
        public void Configure(EntityTypeBuilder<Bookstore> builder)
        {
            builder.ToTable("BS203_Bookstore");

            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(o => o.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(o => o.Address)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(o => o.Customer)
                .WithMany(o => o.Bookstores)
                .HasForeignKey(o => o.BS204_Customer_Id)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
