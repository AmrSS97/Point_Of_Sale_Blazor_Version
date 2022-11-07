using System.Collections.Generic;

namespace Models.DTO
{
    public class NotificationMessageDTO
    {
        public string Body { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public List<string> To { get; set; }
        public List<string> CC { get; set; }
        public List<string> BCC { get; set; }
        public bool IsBodyHtml { get; set; }
        
        public NotificationMessageDTO()
        {
            To = new List<string>();
            CC = new List<string>();
            BCC = new List<string>();
        }
    }
}
