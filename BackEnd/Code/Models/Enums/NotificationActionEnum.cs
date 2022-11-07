using Models.Enums.Extensions;
using System;

namespace Models.Enums
{
    public enum NotificationActionEnum
    {
        [EnumGuid("0160f613-f583-4a5f-a15a-4461afaef8be")]
        ForgetPassword,
        [EnumGuid("ceb98ab9-8390-4ebb-999d-be6de77b21c6")]
        VerifyUser,
        [EnumGuid("71be311e-4c46-46d1-a6e9-00adec7f09dc")]
        Certifcate
    }
}