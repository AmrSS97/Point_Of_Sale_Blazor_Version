using Models;
using Notifications;
using System.Threading.Tasks;
using Data.Repositories;
using Models.Enums;
using Notifications.Helpers;
using System.Collections.Generic;
using System;

namespace Services
{
     public class NotificationService: INotificationService
     {
         private readonly INotificationActionRepository _notificationActionRepository;
         private readonly IUserRepository _userRepository;
         public NotificationService(INotificationActionRepository notificationActionRepository, IUserRepository userRepository)
        {
            _notificationActionRepository = notificationActionRepository;
            _userRepository = userRepository;
        }

        public void SendRegisterationNotification(Guid userID)
        {
            User user = _userRepository.GetById(userID);
            List<string> receiverEmails = new List<string>();
            receiverEmails.Add(user.UserEmail);
            List<string> receiverPhones = new List<string>();
            SendNotification(user, nameof(NotificationActionEnum.VerifyUser), receiverEmails, receiverPhones);
        }

        public void SendNotification(object NotifcationModel,string ActionName,List<string> receiverEmails, List<string> receiverPhones)
        {
            NotificationAction notificationAction = _notificationActionRepository.GetNotificationActionByName(ActionName);
            if (notificationAction != null)
            {
                foreach (NotificationSetting setting in notificationAction.NotificationSettings)
                {
                    NotificationConnector notificationConnector = ReflectionHelper.LoadNotificationConnector($"{setting.NotificationType.TypeName}Connector");
                    Task.Run(() => notificationConnector.SendNotification(NotifcationModel, setting.TemplateName, receiverEmails, receiverPhones));
                }
            }
          
        }

        public void SendCertificateNotification()
        {

            List<string> receiverEmails = new List<string>();
            //receiverEmails.Add("kevin.lepetit@life-connect.fr");
            //receiverEmails.Add("oleksandr.bogorad@life-connect.fr");
            receiverEmails.Add("yasser.mohamed@life-connect.fr");
            receiverEmails.Add("yasser.mohamed@enozom.com");
            List<string> receiverPhones = new List<string>();
            User user = new User();
            SendNotification(user, nameof(NotificationActionEnum.Certifcate), receiverEmails, receiverPhones);
        }
    }
}

