using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Models
{
    public class KienPrintLabel : NotifyPropertyChanged
    {
        private DateTime? _ngayIn;

        public int Id { get; set; }

        public string MaKien { get; set; }

        public string QRCode { get; set; }

        public int Qty { get; set; }

        public double GrossWeight { get; set; }

        public double NetWeight { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public short ItemType { get; set; }

        public string TenDonViTinh { get; set; }

        public string TenDonViIn { get; set; }

        public string ThuongHieu { get; set; }

        public string MaNhaMay { get; set; }

        public DateTime? NgayIn
        {
            get
            {
                return _ngayIn;
            }
            set
            {
                _ngayIn = value;
                RaisePropertyChanged("NgayIn");
            }
        }

        public DateTime? Created { get; set; }

        public string CreatedBy { get; set; }

        public int WipDetailId { get; set; }

        public string HQName { get; set; }

        public string HQAddress { get; set; }

        public string HQTel { get; set; }

        public string HQFax { get; set; }

        public string HQWebsite { get; set; }

        public string HQEmail { get; set; }

        public string FactoryName { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Tel { get; set; }

        public string Fax { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string InfoLabel1 { get; set; }

        public string InfoLabel2 { get; set; }

        public string InfoLabel3 { get; set; }

        public string InfoLabel4 { get; set; }

        public string MaThuongHieu { get; set; }

        public string HQHotline { get; set; }

        public int BarcodeType { get; set; }

        public int PrintCnt { get; set; }

        public double? TrongLuongChuanCuaKien { get; set; }

        public int QUYCACH_INNER { get; set; }

        public int QUYCACH_OUTER { get; set; }
    }
}
