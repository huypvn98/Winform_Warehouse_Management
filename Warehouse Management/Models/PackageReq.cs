using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Models
{
    public class PackageReq
    {
        public int? WarehouseId { get; set; }

        public int WipDetailId { get; set; }

        public string WipKienIds { get; set; }
    }
}
