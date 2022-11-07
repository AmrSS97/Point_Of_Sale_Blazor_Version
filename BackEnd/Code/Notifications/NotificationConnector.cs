using System;
using System.Collections.Generic;
using Loggers;
using Models.DTO;

namespace Notifications
{
    public abstract class NotificationConnector
    {
        public abstract ConfigurationDTO GetProviderConfiguration();
        public abstract NotificationMessageDTO PreapareNotificationMessage(object messageObj, string templateName, List<string> receiverEmails, List<string> receiverPhones);
        public abstract void ConnectToProvider(NotificationMessageDTO notificationMessage, ConfigurationDTO configuration);
        public virtual void SendNotification(object messageObj, string templateName, List<string> receiverEmails, List<string> receiverPhones)
        {
            try
            {
                ConfigurationDTO  configuration = GetProviderConfiguration();
                NotificationMessageDTO notificationMessage = PreapareNotificationMessage(messageObj, templateName,receiverEmails,receiverPhones);
                ConnectToProvider(notificationMessage,configuration);
            }
            catch (Exception ex)
            {
                ILogger logger = LoggerFactory.CreateLogger();
                logger.Error(ex);
            }
        }


    }
}
