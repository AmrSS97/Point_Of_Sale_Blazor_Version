using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.Configuration
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            List<Supplier> SupplierList = new List<Supplier>();
            SupplierList.Add(new Supplier
            {
                SupplierName = "Ali Mohammed Ahmed",
                SupplierPhone = "+201220073453",
                SupplierEmail = "alimohamed96@gmail.com",
                SupplierID = Guid.Parse("9c03f412-e4ad-40f5-9cdb-c5efab612acf"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                IsDeleted = false
            });
            SupplierList.Add(new Supplier
            {
                SupplierName = "Hassan Khalil Hemdan",
                SupplierPhone = "+201113272171",
                SupplierEmail = "hassankhalil97@gmail.com",
                SupplierID = Guid.Parse("33b3885b-bf26-43b4-a214-b54b7f682696"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                IsDeleted = false
            });
            SupplierList.Add(new Supplier { 
            SupplierName = "Ammar Mohamed Ahmed",
            SupplierPhone = "+01445676898",
            SupplierEmail = "ammar_mohamed@hotmail.com",
            SupplierID = Guid.Parse("34b3885b-bf26-43b4-a214-b54b7f682796"),
            CreationDate = DateTime.Now,
            ModificationDate = DateTime.Now,
            CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
            ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
            IsDeleted = false
            });
            SupplierList.Add(new Supplier {
                SupplierName = "Galal Sayed Ahmed",
                SupplierPhone = "+01245676878",
                SupplierEmail = "galal_sayed@hotmail.com",
                SupplierID = Guid.Parse("34b3995b-bf26-43b4-a214-b54b7f682786"),
                CreationDate = DateTime.Now,
                ModificationDate = DateTime.Now,
                CreatedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                ModifiedBy = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253"),
                IsDeleted = false
            });
            builder.HasData(SupplierList.ToArray());

        }
    }
}
