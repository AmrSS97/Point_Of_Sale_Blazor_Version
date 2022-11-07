using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using Models.Enums;
using Models.Enums.Extensions;

namespace Data.Configuration
{
    public class NotificationSettingConfiguration : IEntityTypeConfiguration<NotificationSetting>
    {
        public void Configure(EntityTypeBuilder<NotificationSetting> builder)
        {

            List<NotificationSetting> notificationSettings = new List<NotificationSetting>
            {
                new NotificationSetting()
                {
                    NotificationSettingID = Guid.Parse("46d44ee1-f477-435f-b0b2-87ae3b80b6d0"),
                    NotificationActionID = NotificationActionEnum.ForgetPassword.GetEnumGuid(),
                    NotificationTypeID = NotificationTypeEnum.Email.GetEnumGuid(),
                    TemplateName = "ForgetPassword",
                    Subject ="Change password"

                }, new NotificationSetting()
                {
                    NotificationSettingID = Guid.Parse("a1c8df0c-ccfa-4e41-889a-8851247c2fd0"),
                    NotificationActionID = NotificationActionEnum.VerifyUser.GetEnumGuid(),
                    NotificationTypeID = NotificationTypeEnum.Email.GetEnumGuid(),
                    TemplateName = "verification",
                    Subject ="Verify user"
                }, new NotificationSetting()
                {
                    NotificationSettingID = Guid.Parse("672cf768-aff5-41fd-84c4-2d0b8fa81996"),
                    NotificationActionID = NotificationActionEnum.VerifyUser.GetEnumGuid(),
                    NotificationTypeID = NotificationTypeEnum.SMS.GetEnumGuid(),
                    TemplateName = "verificationSMS",
                    Subject ="Verify user"
                }
            };
            builder.HasData(notificationSettings);
        }
    }
}
