using System.Linq;
using Data.Infrastructure;
using Helpers;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Repositories
{
    public class NotificationActionRepository: BaseRepository<NotificationAction>, INotificationActionRepository
    {
        public NotificationActionRepository(IDbFactory dbFactory, SecurityHelper securityHelper) : base(dbFactory, securityHelper)
        {
        }

        public NotificationAction GetNotificationActionByName(string name)
        {
            NotificationAction action = DbContext.NotificationActions.Where(x => x.ActionName == name).Include(x => x.NotificationSettings)
                .ThenInclude(x => x.NotificationType).FirstOrDefault();
            return action;
        }
    }
}
