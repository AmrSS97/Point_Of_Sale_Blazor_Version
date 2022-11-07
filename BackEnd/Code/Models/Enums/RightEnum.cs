using Models.Enums.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Enums
{
    public enum RightEnum
    {
        [EnumGuid("4edc50ca-a7c0-4278-8930-707ec2e5919c")]
        ManageRoles,
        [EnumGuid("78831e46-adab-41ed-a9de-4d5229ccb15f")]
        ManageUsers,
        [EnumGuid("51e7126e-1515-44b6-8ffc-701769a8f271")]
        FailedEnum
    }
}
