using System.Collections.Generic;

namespace Models.DTO
{
    public class ResultDTO
    {
       public object Results { get; set; }
       public List<ErrorDTO> Errors { get; set; }
       public List<MessageDTO> Messages { get; set; }

        public ResultDTO()
        {
            Errors = new List<ErrorDTO>();
            Messages = new List<MessageDTO>();
        }
    }
}
