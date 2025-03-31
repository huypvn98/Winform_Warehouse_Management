using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Models
{
    public class WIP_CUON : NotifyPropertyChanged
    {
        private int _ID_WIP_Cuon;

        private int _ID_ThanhPhan;

        private int _ID_WIP_Kien;

        private string _MaCuon;

        private double? _SoKg_ThucTe;

        private DateTime? _NgayIn;

        private DateTime _Created;

        private string _CreatedBy;

        private DateTime? _Modified;

        private string _ModifiedBy;

        private string _MaThanhPhan;

        private string _TenThanhPhan;

        private double? _SoKg_KeHoach;

        private double? _SoKgBaoBi;

        [JsonIgnore]
        public bool HasChanges { get; set; }

        public int ID_WIP_Cuon
        {
            get
            {
                return _ID_WIP_Cuon;
            }
            set
            {
                _ID_WIP_Cuon = value;
                RaisePropertyChanged("ID_WIP_Cuon");
            }
        }

        public int ID_ThanhPhan
        {
            get
            {
                return _ID_ThanhPhan;
            }
            set
            {
                _ID_ThanhPhan = value;
                RaisePropertyChanged("ID_ThanhPhan");
            }
        }

        public int ID_WIP_Kien
        {
            get
            {
                return _ID_WIP_Kien;
            }
            set
            {
                _ID_WIP_Kien = value;
                RaisePropertyChanged("ID_WIP_Kien");
            }
        }

        public string MaCuon
        {
            get
            {
                return _MaCuon;
            }
            set
            {
                _MaCuon = value;
                RaisePropertyChanged("MaCuon");
            }
        }

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

        public DateTime? NgayIn
        {
            get
            {
                return _NgayIn;
            }
            set
            {
                _NgayIn = value;
                RaisePropertyChanged("NgayIn");
            }
        }

        public DateTime Created
        {
            get
            {
                return _Created;
            }
            set
            {
                _Created = value;
                RaisePropertyChanged("Created");
            }
        }

        public string CreatedBy
        {
            get
            {
                return _CreatedBy;
            }
            set
            {
                _CreatedBy = value;
                RaisePropertyChanged("CreatedBy");
            }
        }

        public DateTime? Modified
        {
            get
            {
                return _Modified;
            }
            set
            {
                _Modified = value;
                RaisePropertyChanged("Modified");
            }
        }

        public string ModifiedBy
        {
            get
            {
                return _ModifiedBy;
            }
            set
            {
                _ModifiedBy = value;
                RaisePropertyChanged("ModifiedBy");
            }
        }

        public string MaThanhPhan
        {
            get
            {
                return _MaThanhPhan;
            }
            set
            {
                _MaThanhPhan = value;
                RaisePropertyChanged("MaThanhPhan");
            }
        }

        public string TenThanhPhan
        {
            get
            {
                return _TenThanhPhan;
            }
            set
            {
                _TenThanhPhan = value;
                RaisePropertyChanged("TenThanhPhan");
            }
        }

        public double? SoKg_KeHoach
        {
            get
            {
                return _SoKg_KeHoach;
            }
            set
            {
                _SoKg_KeHoach = value;
                RaisePropertyChanged("SoKg_KeHoach");
            }
        }

        public double? SoKgBaoBi
        {
            get
            {
                return _SoKgBaoBi;
            }
            set
            {
                _SoKgBaoBi = value;
                RaisePropertyChanged("SoKgBaoBi");
            }
        }

        public bool Deleted { get; set; }

        public bool Invalid { get; set; }

        public WIP_CUON Clone()
        {
            return new WIP_CUON
            {
                ID_WIP_Cuon = ID_WIP_Cuon,
                ID_ThanhPhan = ID_ThanhPhan,
                ID_WIP_Kien = ID_WIP_Kien,
                MaCuon = MaCuon,
                SoKg_ThucTe = SoKg_ThucTe,
                NgayIn = NgayIn,
                Created = Created,
                CreatedBy = CreatedBy,
                Modified = Modified,
                ModifiedBy = ModifiedBy,
                MaThanhPhan = MaThanhPhan,
                TenThanhPhan = TenThanhPhan,
                SoKg_KeHoach = SoKg_KeHoach,
                SoKgBaoBi = SoKgBaoBi,
                HasChanges = HasChanges
            };
        }
    }
}
