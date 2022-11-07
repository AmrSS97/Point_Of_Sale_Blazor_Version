using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using Models.Enums;
using Models.Enums.Extensions;

namespace Data.Configuration
{
    public class NotificationTypeConfiguration:IEntityTypeConfiguration<NotificationType>
    {
        public void Configure(EntityTypeBuilder<NotificationType> builder)
        {
            List<NotificationType> types = new List<NotificationType>()
            {
                new NotificationType()
                {
                    TypeName = "Email",
                    NotificationTypeID = NotificationTypeEnum.Email.GetEnumGuid()
                },
                new NotificationType()
                {
                    TypeName = "SMS",
                    NotificationTypeID = NotificationTypeEnum.SMS.GetEnumGuid()
                },
                new NotificationType()
                {
                    TypeName = "InAppNotification",
                    NotificationTypeID = NotificationTypeEnum.InAppNotification.GetEnumGuid()
                },
            };
            builder.HasData(types);
        }
    }
}
