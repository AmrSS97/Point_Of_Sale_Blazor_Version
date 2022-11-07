using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Feature : BaseModel
    {
        public Guid FeatureID { get; set; }
        public string FeatureName { get; set; }
        public string FeatureNameAr { get; set; }
        public string MenuIcon { get; set; }

        public List<Right> Rights { get; set; }


        public Feature()
        {
            Rights = new List<Right>();
            FeatureID = Guid.NewGuid();
        }
    }
}
