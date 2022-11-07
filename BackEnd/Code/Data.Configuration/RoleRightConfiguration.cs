using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using Models.Enums;
using Models.Enums.Extensions;
using System;
using System.Collections.Generic;

namespace Data.Configuration
{
    public class RoleRightConfiguration : IEntityTypeConfiguration<RoleRight>
    {

        public void Configure(EntityTypeBuilder<RoleRight> builder)
        {
            List<RoleRight> RoleRights = new List<RoleRight>();

            RoleRights.Add(new RoleRight
            {
                RoleRightID = Guid.Parse("0de0622b-97db-4edd-acfa-a5adeb81673b"),
                RoleID = RoleEnum.Admin.GetEnumGuid(),
                RightID = RightEnum.ManageRoles.GetEnumGuid()
            });
            RoleRights.Add(new RoleRight
            {
                RoleRightID = Guid.Parse("8ac6ded6-4c93-4d95-8396-b526925d322d"),
                RoleID = RoleEnum.Admin.GetEnumGuid(),
                RightID = RightEnum.ManageUsers.GetEnumGuid()
            });

            builder.HasData(RoleRights.ToArray());
        }
    }
}
