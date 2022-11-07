using System;

namespace Models
{
    public class NotificationSetting:BaseModel
    {
        public Guid NotificationSettingID { get; set; }
        public Guid NotificationActionID { get; set; }
        public Guid NotificationTypeID { get; set; }
        public string TemplateName { get; set; }
        public string Subject { get; set; }
        public NotificationType NotificationType { get; set; }
        public NotificationAction NotificationAction { get; set; }
        public NotificationSetting()
        {
            NotificationSettingID = Guid.NewGuid();
        }
    }
}
