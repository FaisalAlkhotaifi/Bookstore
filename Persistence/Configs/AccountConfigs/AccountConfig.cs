using Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configs.AccountConfigs
{
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("D001_Account");

            builder.Property(e => e.Id)
                .HasColumnName("Id");
            builder.Property(o => o.FirstName)
                .IsRequired()
                .HasMaxLength(25);
            builder.Property(o => o.LastName)
                .IsRequired()
                .HasMaxLength(25);
            builder.Property(o => o.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(o => o.PasswordSalt)
                .IsRequired();
            builder.Property(o => o.PasswordHash)
                .IsRequired();
            builder.Property(o => o.Role)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
