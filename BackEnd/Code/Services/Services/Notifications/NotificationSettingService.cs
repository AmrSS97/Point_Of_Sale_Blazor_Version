using Data.Repositories;
using Models;


namespace Services
{
    public class NotificationSettingService : INotificationSettingService
    {
        public INotificationSettingRepository _notificationSettingRepository;
        public NotificationSettingService(INotificationSettingRepository notificationSettingRepository)
        {
            _notificationSettingRepository = notificationSettingRepository;
        }
        
    }
}
