using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Models
{
    public class WIP_ITEM : NotifyPropertyChanged
    {
        private double? _SoKg_ThucTe;

        public int ID_ThanhPhan { get; set; }

        public int ID_WIP { get; set; }

        public string MaThanhPhan { get; set; }

        public string TenThanhPhan { get; set; }

        public double? SoKg_KeHoach { get; set; }

        public double? SoKg_ThucTe
        {
            get
            {
                return _SoKg_ThucTe;
            }
            set
            {
                _SoKg_ThucTe = value;
                RaisePropertyChanged("SoKg_ThucTe");
            }
        }

        public double? TrongLuongBaoBi { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Modified { get; set; }

        public string ModifiedBy { get; set; }

        public string ThuongHieu { get; set; }
    }
}
