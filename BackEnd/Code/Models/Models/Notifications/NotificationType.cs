using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class NotificationType : BaseModel
    {
        public Guid NotificationTypeID { get; set; }
        public string TypeName { get; set; }
        public NotificationType()
        {
            NotificationTypeID = Guid.NewGuid();
        }
    }
}
