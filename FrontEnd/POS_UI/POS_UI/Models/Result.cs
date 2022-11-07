using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Result
    {
        public object Results { get; set; }
        public List<Error> Errors { get; set; }
        public List<Message> Messages { get; set; }
        public Result()
        {
            Errors = new List<Error>();
            Messages = new List<Message>();
        }
    }
}
