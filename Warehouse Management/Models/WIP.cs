using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Models
{
    public class WIP : NotifyPropertyChanged
    {
        private string _Status;

        public int ID_WIP { get; set; }

        public string WO_NUMBER { get; set; }

        public string WO_Id { get; set; }

        public int StatusId { get; set; }

        public string Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
                RaisePropertyChanged("Status");
            }
        }

        public double? CongDoan { get; set; }

        public string MaOrg { get; set; }

        public string KhoNhap { get; set; }

        public string ViTriNhap { get; set; }

        public string MaThanhPham { get; set; }

        public string TenThanhPham { get; set; }

        public string MaDonViTinh { get; set; }

        public string TenDonViTinh { get; set; }

        public DateTime? WO_DATE { get; set; }

        public double? TOLERANCE_VALUE { get; set; }

        public double? TOLERANCE_OVER { get; set; }

        public double? TOLERANCE_BELOW { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Modified { get; set; }

        public byte Type { get; set; }

        public string ModifiedBy { get; set; }

        public string UserName { get; set; }

        public string PO_NUMBER { get; set; }

        public string MaThuongHieu { get; set; }

        [JsonIgnore]
        public SortableList<WIPDetail> WIPDetails { get; set; }

        [JsonIgnore]
        public WIPDetail WIPDetailCurrent { get; set; }
    }
}
