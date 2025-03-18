using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Models
{
    public class OrgResp
    {
        public List<ORGANIZATION> FromOrgs { get; set; }

        public List<ORGANIZATION> ToOrgs { get; set; }

        public List<ORGANIZATION> AllOrgs { get; set; }
    }
}
