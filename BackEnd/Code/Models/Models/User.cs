using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class User : BaseModel
    {
        
        public Guid UserID { get; set; }
        public Guid RoleID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set;}
        public Role Role { get; set; }


        public User()
        {
            UserID = Guid.NewGuid();
        }
    }
}
