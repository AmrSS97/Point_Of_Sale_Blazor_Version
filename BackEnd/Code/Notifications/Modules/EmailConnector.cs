using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using Helpers;
using Models.DTO;
using Notifications.Helpers;
using RazorEngine;
using RazorEngine.Templating;


namespace Notifications
{
    public class EmailConnector:NotificationConnector
    {
        public override NotificationMessageDTO PreapareNotificationMessage(object messageObj, string templateName, List<string> receiverEmails, List<string> receiverPhones)
        {
            //get configuration
            NotificationMessageDTO notificationMessage = new NotificationMessageDTO();
            string emailBody = Engine.Razor.Run(templateName, messageObj.GetType(), messageObj);
            notificationMessage.Body = emailBody;
            notificationMessage.IsBodyHtml = true;
            notificationMessage.To = receiverEmails;
            return notificationMessage;
        }
        
        public override ConfigurationDTO GetProviderConfiguration()
        {
            ConfigurationDTO config = new ConfigurationDTO();
            config.Username = ConfigurationHelper.MailUsername;
            config.Password = ConfigurationHelper.MailPassword;
            config.Host = ConfigurationHelper.MailHost;
            config.Port = ConfigurationHelper.MailPort;
            config.LogoPath = Path.Combine(HostEnvironmentHelper.HostingEnvironment.ContentRootPath, "EmailTemplates", "logo.png");
            return config;
        }

        public override void ConnectToProvider(NotificationMessageDTO notificationMessage, ConfigurationDTO configuration)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(configuration.Username);

            foreach (string toEmail in notificationMessage.To)
            {
                mail.To.Add(toEmail);
            }

            foreach (string ccEmail in notificationMessage.CC)
            {
                mail.CC.Add(ccEmail);
            }

            foreach (string bccEmail in notificationMessage.BCC)
            {
                mail.Bcc.Add(bccEmail);
            }

            mail.Subject = notificationMessage.Subject;
            mail.Body = notificationMessage.Body;
            mail.IsBodyHtml = notificationMessage.IsBodyHtml;

            SmtpClient SmtpServer = new SmtpClient(configuration.Host);
            SmtpServer.Port = configuration.Port;
            SmtpServer.Credentials = new NetworkCredential(configuration.Username, configuration.Password);
            SmtpServer.EnableSsl = true;
            Attachment attachment = new Attachment(configuration.LogoPath)
            {
                ContentId = "logo.png"
            };

            mail.Attachments.Add(attachment);
            SmtpServer.SendMailAsync(mail);
        }
    }
}
