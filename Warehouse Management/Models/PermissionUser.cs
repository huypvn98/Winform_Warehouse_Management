using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Models
{
    public class PermissionUser
    {
        public int RowId { get; set; }

        public string FeatureCode { get; set; }

        public string FeatureName { get; set; }

        public bool View { get; set; }

        public bool Add { get; set; }

        public bool Edit { get; set; }

        public bool Delete { get; set; }

        public bool Approval { get; set; }
    }
}
