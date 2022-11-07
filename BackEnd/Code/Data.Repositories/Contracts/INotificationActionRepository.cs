using System;
using System.Collections.Generic;
using System.Text;
using Data.Infrastructure;
using Models;

namespace Data.Repositories
{
    public interface INotificationActionRepository: IRepository<NotificationAction>
    {
        NotificationAction GetNotificationActionByName(string name);
    }
}
