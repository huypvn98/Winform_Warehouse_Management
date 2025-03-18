using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }

        public string WarehouseCode { get; set; }

        public int FactoryId { get; set; }

        public string Notes { get; set; }

        public short OrderNo { get; set; }

        public bool IsActive { get; set; }

        public bool IsMain { get; set; }

        public bool IsMaterial { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Modified { get; set; }

        public string ModifiedBy { get; set; }
    }
}
