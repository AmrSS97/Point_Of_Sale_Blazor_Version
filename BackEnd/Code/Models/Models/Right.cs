using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Right : BaseModel
    {
        public Guid RightID { get; set; }
        public string RightCode { get; set; }
        public Guid FeatureID { get; set; }
        public int RightOrder { get; set; }
        public string RightName { get; set; }
        public string RightNameAr { get; set; }
        public string MenuIcon { get; set; }
        public string RightURL { get; set; }
        public bool IsVisible { get; set; }

        public Feature Feature { get; set; }
        public List<RoleRight> RoleRights { get; set; }

        public Right()
        {
            RoleRights = new List<RoleRight>();
            RightID = Guid.NewGuid();
        }
    }
}
