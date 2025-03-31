using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Models
{
    public class WIP_KIEN_SEARCH : WIP_KIEN
    {
        public string WO_NUMBER { get; set; }

        public string TenThanhPham { get; set; }

        public string TenDonViTinh { get; set; }

        public string TenDonViIn { get; set; }

        public string MaOrg { get; set; }

        public string StatusDetail { get; set; }

        public string ThuongHieu { get; set; }

        public string CellCode { get; set; }

        public string ThanhPham { get; set; }

        public string SO_NUMBER { get; set; }

        public bool IsSanXuat { get; set; }

        public string MA_EAN { get; set; }
    }
}
