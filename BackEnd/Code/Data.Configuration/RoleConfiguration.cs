using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using Models.Enums;
using Models.Enums.Extensions;
using System.Collections.Generic;

namespace Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            List<Role> lstRoles = new List<Role>();
            Role AdminObj = new Role() { RoleID = RoleEnum.Admin.GetEnumGuid(), RoleName = "admin", IsSystemRole = true };

            lstRoles.Add(AdminObj);

            builder.HasData(lstRoles.ToArray());
        }
    }
}
