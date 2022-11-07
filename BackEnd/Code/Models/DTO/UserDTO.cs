using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class UserDTO
    {
        public Guid UserID { get; set; }
        public string FullName { get; set; }
        public string UserEmail { get; set; }
        public string RoleName { get; set; }
    }
}
