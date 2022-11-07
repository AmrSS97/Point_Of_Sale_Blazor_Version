using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Role : BaseModel
    {
        public Guid RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleNameAr { get; set; }
        public bool? IsSystemRole { get; set; }
        public List<RoleRight> RoleRights { get; set; }
        public List<User> Users { get; set; }

        public Role()
        {
            RoleRights = new List<RoleRight>();
            Users = new List<User>();
            RoleID = Guid.NewGuid();
        }
    }
}
