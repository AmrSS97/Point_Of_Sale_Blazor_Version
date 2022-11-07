using System.Collections.Generic;
using Data.Infrastructure;
using Helpers;
using Models;
using System.Linq;

namespace Data.Repositories
{
    public class NotificationSettingRepository : BaseRepository<NotificationSetting>, INotificationSettingRepository
    {
        public NotificationSettingRepository(IDbFactory dbFactory, SecurityHelper securityHelper) : base(dbFactory, securityHelper)
        {
        }

       
    }
}
