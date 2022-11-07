using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;

namespace Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c => c.FullName).IsRequired().HasMaxLength(250);
            builder.Property(c => c.CustomerPhone).IsRequired().HasMaxLength(150);
            builder.Property(c => c.CustomerEmail).HasMaxLength(255);
            builder.Property(c => c.CustomerAddress).IsRequired().HasMaxLength(200);

            List<Customer> Customerlist = new List<Customer>();
            Customerlist.Add(new Customer {
                FullName = "Hassan Mohammed Ahmed",
                CustomerEmail = "hassanmohammed67@hotmail.com",
                CustomerPhone = "+201256262161",
                CustomerAddress = "205 Sorya Street,Roushdy",
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CustomerID = Guid.Parse("31a2cb54-a26e-460d-a92c-d7645bc6d2eb"),
                IsDeleted = false
            });
            Customerlist.Add(new Customer {
                FullName = "Hassan Mohammed Ahmed",
                CustomerEmail = "hassanmohammed67@hotmail.com",
                CustomerPhone = "+201256262161",
                CustomerAddress = "205 Sorya Street,Roushdy",
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CustomerID = Guid.Parse("31a2cb54-a26e-460d-a92c-d7645bc6d2ea"),
                IsDeleted = false
            });
            Customerlist.Add(new Customer {
                FullName = "Khalid Hassan Ahmed",
                CustomerEmail = "khalihassan_77@hotmail.com",
                CustomerPhone = "+201257262161",
                CustomerAddress = "208 Sorya Street,Roushdy",
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CustomerID = Guid.Parse("1e22e307-a365-4e17-9f1b-1120a2da601f"),
                IsDeleted = false
            });
            Customerlist.Add(new Customer {
                FullName = "Gehan Mohamed Khalil",
                CustomerEmail = "gehanmohammed98@gmail.com",
                CustomerPhone = "+201256263361",
                CustomerAddress = "203 Horeya Street,Sidi gaber",
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CustomerID = Guid.Parse("098b6065-11ea-4a8e-961c-247f846329b6"),
                IsDeleted = false
            });

            builder.HasData(Customerlist.ToArray());
        }
    }
}
