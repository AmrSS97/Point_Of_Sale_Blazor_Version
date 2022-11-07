using System;

namespace Notifications.Helpers
{
    public static class ReflectionHelper
    {
        public static NotificationConnector LoadNotificationConnector(string connector)
        {
            Type type = Type.GetType($"Notifications.{connector}" + "," + "Notifications");
            NotificationConnector notificationConnector = (NotificationConnector)Activator.CreateInstance(type);
            return notificationConnector;

        }
    }
}
