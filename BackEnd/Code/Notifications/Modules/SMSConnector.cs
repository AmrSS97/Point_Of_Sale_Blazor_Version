using System;
using System.Collections.Generic;
using Models.DTO;

namespace Notifications
{
    public class SMSConnector:NotificationConnector
    {
        public override NotificationMessageDTO PreapareNotificationMessage(object messageObj, string templateName, List<string> receiverEmails, List<string> receiverPhones)
        {
            throw new NotImplementedException();
        }

        public override void ConnectToProvider(NotificationMessageDTO notificationMessage, ConfigurationDTO configuration)
        {
            throw new NotImplementedException();
        }

        public override ConfigurationDTO GetProviderConfiguration()
        {
            throw new NotImplementedException();
        }
    }
}
