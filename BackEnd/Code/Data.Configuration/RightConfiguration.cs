using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using Models.Enums;
using Models.Enums.Extensions;
using System.Collections.Generic;

namespace Data.Configuration
{
    public class RightConfiguration : IEntityTypeConfiguration<Right>
    {

        public void Configure(EntityTypeBuilder<Right> builder)
        {
            List<Right> lstRights = new List<Right>();

            lstRights.Add(new Right
            {
                RightID = RightEnum.ManageRoles.GetEnumGuid(),
                FeatureID = FeatureEnum.Security.GetEnumGuid(),
                RightOrder = 1,
                RightCode = "roles",
                RightName = "Manage Roles",
                RightNameAr = "ادارة الادوار",
                MenuIcon = "icon-docs",
                RightURL = "#/pages/roles",
                IsVisible = true

            });
            lstRights.Add(new Right
            {
                RightID = RightEnum.ManageUsers.GetEnumGuid(),
                FeatureID = FeatureEnum.Security.GetEnumGuid(),
                RightOrder = 2,
                RightCode = "users",
                RightName = "Manage Users",
                RightNameAr = "ادارة المستخدمين",
                MenuIcon = "icon-users",
                RightURL = "#/pages/users",
                IsVisible = true
            });

            builder.HasData(lstRights.ToArray());
        }
    }
}
