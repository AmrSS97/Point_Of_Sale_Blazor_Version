using System;
using System.Collections.Generic;

namespace Models
{
    public class NotificationAction:BaseModel
    {
        public Guid NotificationActionID { get; set; }
        public string ActionName { get; set; }
        public string TitleEn { get; set; }
        public List<NotificationSetting> NotificationSettings { get; set; }
        public NotificationAction()
        {
            NotificationSettings = new List<NotificationSetting>();
            NotificationActionID = Guid.NewGuid();
        }
    }
}
