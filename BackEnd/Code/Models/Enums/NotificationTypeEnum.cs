using Models.Enums.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Enums
{
    public enum NotificationTypeEnum
    {
        [EnumGuid("c8d58b31-3fa8-44ab-b24f-fa85ad33c954")]
        Email,
        [EnumGuid("f5702875-5374-4b55-87dd-3da62895f6fb")]
        SMS,
        [EnumGuid("c74cedbf-53bc-4020-b168-46bd6fde0ddf")]
        InAppNotification
    }
}
