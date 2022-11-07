using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class RoleRight : BaseModel
    {
        public Guid RoleRightID { get; set; }
        public Guid RoleID { get; set; }
        public Guid RightID { get; set; }

        public Role Role { get; set; }
        public Right Right { get; set; }

        public RoleRight()
        {
            RoleRightID = Guid.NewGuid();
        }
    }
}
