using Helpers;
using Models.DTO;
using Notifications.Helpers;
using RazorEngine;
using RazorEngine.Templating;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    public class SendGridConnector : NotificationConnector
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
            string apiKey = ConfigurationHelper.SendGridAPIKey;
            SendGridClient client = new SendGridClient(apiKey);
            EmailAddress from = new EmailAddress(configuration.Username, "Yasser LC");
            string subject = notificationMessage.Subject;
            List<EmailAddress> tos = new List<EmailAddress>();
            foreach (string toEmail in notificationMessage.To)
            {
                EmailAddress to = new EmailAddress();
                to.Email = toEmail;
                tos.Add(to);
            }

            string plainTextContent = "and easy to do anywhere, even with C#";
            string htmlContent = notificationMessage.Body;
            SendGridMessage msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, subject, plainTextContent, htmlContent);

            string emailIcon = Path.Combine(HostEnvironmentHelper.HostingEnvironment.ContentRootPath, "EmailTemplates", "img", "email.png");
            byte[] emailIconbyteData = System.Text.Encoding.ASCII.GetBytes(File.ReadAllText(emailIcon));
            Attachment attachment1 = new SendGrid.Helpers.Mail.Attachment
            {
                Content = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAHzSURBVHgBlVPRbdswEL2j1fwV0AAxIk9QdYLEE1ROf4oiVtMJ4g1sT5BkgghOP/pVqxu4E1SZwLLlAfQfRZd3pCzYcYAgBCiKx3t37x6PTC9GFC19+tiJDJlTIQnUxkRlTfKXHp8W6e9evuvPe+CLdcSG7/DrY5aYOQlWprCxKWDyZ9adHgQ4j4ux4BCAhQhN01/dxV7w75uQvHrExD+wzcRU/TTple5wuL4cxIVEcXFDb4xouBmp7/lwfd0yGMSbpa7z2XHPOn1bBvzBu3PUuWSSBMxCMPTn992+JgLwSqrqs9HsBLGklp8t+Mj7D/CZgtWmpQlTBJvVgUw1satnIDbxF8x8WzPAcxUMoKkysqygiwskK121dgHGcOfEsKorkm+zYwltwFl3sq1buP7nfmTRqg8MWAdmTyHPCxrHfNfMYk6d3WRtIuiDwA8GnxUxO2Dtam7u3Y6vcXHl9NAElQ1gjjy9Sp+qTsLRcDViNtdSU18duPaW9hBlIGXpSrJN5bNQKsyhFR0aaZmGOnWiDsw0tuJU3Mc+o6aNNTCcb9WmYNSeqW1Xo4PmeM9oWxnNMcFmrNS1Jw5a+aI403ci8nSb3p/cHARwTNaX0GPc0C9x8VnTPMFWFzE0SJPj7NUAu4Fwd6jXfLJPWW+qNulLVjqeAf6f6/fHXaBfAAAAAElFTkSuQmCC",//Convert.ToBase64String(emailIconbyteData),
                Filename = "email.png",
                Type = "image/png",
                Disposition = "inline",
                ContentId = "email.png",
            };

            msg.AddAttachment(attachment1);

            string envIcon = Path.Combine(HostEnvironmentHelper.HostingEnvironment.ContentRootPath, "EmailTemplates", "img", "env.png");
            byte[] envIconbyteData = System.Text.Encoding.ASCII.GetBytes(File.ReadAllText(envIcon));
            Attachment attachment2 = new SendGrid.Helpers.Mail.Attachment
            {
                Content = "iVBORw0KGgoAAAANSUhEUgAAABEAAAAMCAYAAACEJVa/AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAEsSURBVHgBnZLNTcNAEIXfrIzPKYCIpAQqwO5gYy4csEMHCRXEVOBQQSBw4OgOCBVAB07iFMAZIg8zNgkmCBTzpJVW8/PpzewSREF/mTDTEP8QAbGjlxLAmDEVT40AbE6YMHQ2AQWk06MYDWTDZUIgz3zZMiMbLvYe6TTKB0TVCkwt/kpkkiDKR381W5u1gv5qUgBj7akMiHpRzoziSpkSUMgLv6176UN3/g1wlnXIPXiU4TsMSH1RTlB3gnTajmXJl3Iti7VpCzjPPXKdZwG0uICvtZuc2bWb3h2O2ayPS5uukwXhamLlkIE4wFxz6X17Vu/5ASlBN10pfvcZfMvEluSofQH4mtutd/CLPosvsIe2EP04NlrEaCDt0ZeofixwTYSBbNprAlGAjvkBdr9xcgy2bmwAAAAASUVORK5CYII=",
                Filename = "env.png",
                Type = "image/png",
                ContentId = "env.png",
                Disposition = "inline"
            };

            msg.AddAttachment(attachment2);

            string lampIcon = Path.Combine(HostEnvironmentHelper.HostingEnvironment.ContentRootPath, "EmailTemplates", "img", "lamp.png");
            byte[] lampIconbyteData = System.Text.Encoding.ASCII.GetBytes(File.ReadAllText(lampIcon));
            Attachment attachment3 = new SendGrid.Helpers.Mail.Attachment
            {
                Content = "iVBORw0KGgoAAAANSUhEUgAAABwAAAAoCAYAAADt5povAAAACXBIWXMAABYlAAAWJQFJUiTwAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAPZSURBVHgBvVe9ThtBEJ7ZMyZdTFDqnB2cpAMUekyXLvAEQBEJnALzBOAqJVAEkFJAngAoU9npUkQKdFH4W14gMV2wuZ3M7v34Ds7nH075JOvWu3v7zd/OzAH8Z2Avm+yxpZIA6y0hlBDI5qmct9QgwGMkOFbgHMmz3Xq3sxIJCy/LK6CgojmhN0g+sHp+ur0P/RDar5ZsdKw91qYUnifCOiJJILjy3n7GczbPRfcB1alFi1Luyq6EdvHdhIChGrTNxgS0pW6H96XcbEAHAcEBNrtYg7Y1pILWnDz9dNyR8B6Zgi3lZNc7Ed0jtis5YTXXQcCKN9Vg0pkwKYalFI6o+RLywmLYFyZwUMzzsOTtkaqVnYwTpjBWXucD1gJNQ/uEv4nJ2uYgWvXJtCD54vsak2lhFqBtMhsyfycgBhdn2+vsyKq/T2Rv9iIaetLXvLn9i9PtxTittYn4oDo/TxBBJkWj0fTF8gEQzuqxIjWjr03GsKK1pmPLVV9VY8n69Kd5pTm8KIaaJR7mEFFbsI7ewZd3tSsUy9oMC2aWzWPMNAAKz8ubfhCxL0eEDudAImht+doFZFqIAcnMmagO/bFlNWeFUMJ3fMMPX3Hr2t2VSlXhAfDSnXEDO21CkMBx84cwdFdw2t8fly0GgEtoKVvErSrEnCeEhBTACV66B1uPYwmR1JF5An2FlMHXQl0ZI6IpOwYXZzub/NiElMCCu3EinGuha5k3b+tcCCnDi3hzLiqsCwUUBIsOW0gbkWtHxyIctkrQPKQMr2RpSM3lBg2BufDsyZLOq5AS7OLSArSrT9UVgKFuszpA3PKBYi8NX5qUGdLOaal6QGgSMlFQTnDo5gAeAFOIo7W16icQy9/05/f3b7nRqTybdYJ/9sjoVI7nvsAAePL09Qd+vDF/3MQfXLHIxafWcIXznRe1WBnEn67fqOIeQYd3E3+EUJuW890chPwJ/ZBpU4b8ppq0enfPvdQmf+7KsD9Nf9IjRLap656tx2G/hdGxEc4Xyz94UaekBhfOfLdKHy7kun+9PPs4E7cv0+kAIrWKbp+T000Qa3oCCSCHpoMxOB1raGKrny8u13QygD6QpJ2GSHqZE/sR9AmuBp+T1jNJiybZekbgfmfybtvuI9xmOqRk0pmJGkZAViqlK9PrRt3mc+CU4hdp3G1rUyQE3TZ2CjHq6bvWoHeTpoSeNVSK5uT5zmHcWmFsucJN0YYe84fsZdI5yRrePgqiUgjciKuTpmdBDL4HiYauk47savzItx5nf25aIxmHkKaD5MCfeV7HNzihRk8ZR5eiXztz0AX/AAIgu4mgtntZAAAAAElFTkSuQmCC",
                ContentId = "lamp.png",
                Filename = "lamp.png",
                Type = "image/png",
                Disposition = "inline",
            };

            msg.AddAttachment(attachment3);

            string numberIcon = Path.Combine(HostEnvironmentHelper.HostingEnvironment.ContentRootPath, "EmailTemplates", "img", "number.png");
            byte[] numberIconbyteData = System.Text.Encoding.ASCII.GetBytes(File.ReadAllText(numberIcon));
            Attachment attachment4 = new SendGrid.Helpers.Mail.Attachment
            {
                Content = "iVBORw0KGgoAAAANSUhEUgAAABEAAAAQCAYAAADwMZRfAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAG4SURBVHgBlZPPVcJAEMZnluBNwTtg6AA7gAoMevEg/yoAKkAqECuQB9zZDoAKiBUQTAN5HjVknFkgAk/ei3NINpvML/N9M4vwj7iv+z0C6PDSI6I5ECwg3LiYFOA8rmy8sJac6JoNhBJfs/w8V0khkE6VJYlSYWs6zlemo/w1QfTKsHJiCKLqyV/1sOgdbGf5jZcI4jz5ZQCyCaPFEZjUDRAlg4AVuvJHBNUTcw24ucqKFAa/JzeWk3BjTU1iBBUuw0bEN1knNzaQ+tGWivQkP0fAxn79J0TaebqnMukX44v6rji1j6apiKK+vIvlOA5rvFRN1n0nH0gnpJWyLwAeriYPWh++wiFepGeSMx3lijHkoe63I4Bn2A0PIa2lXCQckgClAgF8hgO8sgTAFYW3+3ZbcmHAgG8um9QVjaayuh+weW3RbYwMQ28HKFFEVT36nRfjCUn7EN09QEKP8h35OC55K8FmWS09Kegjv7a3zYJIyj4wVzwCDKo1f4YKGEABKazocWEIJ2HkmEOF1HDq64GiVIbYg/iAcXOJsKvHuQGcCWOsGaQovRQDYTsRHh+uBURKH0o8Fz+7e80o20WqgAAAAABJRU5ErkJggg==",
                ContentId = "number.png",
                Filename = "number.png",
                Type = "image/png",
                Disposition = "inline",
            };

            msg.AddAttachment(attachment4);

            string vectorIcon = Path.Combine(HostEnvironmentHelper.HostingEnvironment.ContentRootPath, "EmailTemplates", "img", "vector.png");
            byte[] vectorIconbyteData = System.Text.Encoding.ASCII.GetBytes(File.ReadAllText(vectorIcon));
            Attachment attachment5 = new SendGrid.Helpers.Mail.Attachment
            {
                Content = "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",
                ContentId = "vector.png",
                Filename = "vector.png",
                Type = "image/png",
                Disposition = "inline",
            };

            msg.AddAttachment(attachment5);
            var t = Task.Run(
    async () =>
    {
        var response = await client.SendEmailAsync(msg);
    });

        }
    }
}
