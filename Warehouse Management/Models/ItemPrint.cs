using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Models
{
    public class ItemPrint
    {
        public string WO_NUMBER { get; set; }

        public string TenThanhPham { get; set; }

        public string TenDVT { get; set; }

        public string TenDonViIn { get; set; }

        public string MaThuongHieu { get; set; }

        public string ThuongHieu { get; set; }

        public string MaNhaMay { get; set; }

        public double TrongLuongChuanCuaKien { get; set; }

        public string MA_EAN { get; set; }

        public int QUYCACH_INNER { get; set; }

        public int QUYCACH_OUTER { get; set; }

        public InnerOuterType? InnerOuterType { get; set; }

        public string QRCode { get; set; }

        public int? InnerQty { get; set; }

        public double? InnerTrongLuong { get; set; }

        public int? OuterQty { get; set; }

        public double? OuterTrongLuong { get; set; }
    }
}
