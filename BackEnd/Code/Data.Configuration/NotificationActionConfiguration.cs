using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using Models.Enums;
using Models.Enums.Extensions;

namespace Data.Configuration
{
    public class NotificationActionConfiguration:IEntityTypeConfiguration<NotificationAction>
    {
        public void Configure(EntityTypeBuilder<NotificationAction> builder)
        {
            List<NotificationAction> actions = new List<NotificationAction>()
            {
                new NotificationAction()
                {
                    NotificationActionID = NotificationActionEnum.ForgetPassword.GetEnumGuid(),
                    ActionName = "ForgetPassword" ,
                    TitleEn = "Forget password",
                },
                new NotificationAction()
                {
                    NotificationActionID = NotificationActionEnum.VerifyUser.GetEnumGuid(),
                    ActionName = "VerifyUser",
                    TitleEn ="Verify user",
                }
            };

            builder.HasData(actions);
        }
    }
}
