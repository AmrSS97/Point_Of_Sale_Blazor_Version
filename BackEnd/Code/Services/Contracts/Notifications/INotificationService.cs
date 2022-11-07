using Models;
using System;
using System.Threading.Tasks;

namespace Services
{
    public interface INotificationService
    {
       void SendRegisterationNotification(Guid userID);
        void SendCertificateNotification();
    }
}
