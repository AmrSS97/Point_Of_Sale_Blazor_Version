using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using Models.Enums;
using Models.Enums.Extensions;
using System;
using System.Collections.Generic;

namespace Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder){
            
            builder.Property(u => u.FullName).IsRequired().HasMaxLength(250);
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(150);
            builder.Property(u => u.UserEmail).HasMaxLength(255);
            builder.Property(u => u.UserPassword).IsRequired().HasMaxLength(200);
       
            List<User> lstUsers = new List<User>();

            User useSeed = new User();
            useSeed.FullName = " Admin";
            useSeed.UserEmail = "admin@admin.com";
            useSeed.UserName = "admin";
            useSeed.RoleID = RoleEnum.Admin.GetEnumGuid();
            useSeed.UserPassword = "ꉟ뺾";
            useSeed.IsActive = true;
            useSeed.UserID = Guid.Parse("d1364e8b-58e2-423b-a048-03ffd7ef6253");
            lstUsers.Add(useSeed);

            builder.HasData(lstUsers.ToArray());
        }
    }
}
