using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Models
{
    public class WIP_KIEN : NotifyPropertyChanged
    {
        private int _ID_WIP_Kien;

        private int _ID_WIPDetail;

        private int _StatusId;

        private string _Status;

        private string _MaKien;

        private double? _SoKgChuan;

        private int? _SoCuonChuan;

        private int? _SoCuonThucTe;

        private double? _SoKg_BaoBi;

        private double? _SoKg_BaoBi_Cuon;

        private double? _SoKg_ThucTe;

        private DateTime? _NgayIn;

        private DateTime _Created;

        private string _CreatedBy;

        private DateTime? _Modified;

        private string _ModifiedBy;

        private string _UserName;

        private SortableList<WIP_CUON> _WipCuons;

        private string _QRCode;

        private bool _Deleted;

        private string _SoKienSanXuat;

        private double? _SO_MET;

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

        public int ID_WIPDetail
        {
            get
            {
                return _ID_WIPDetail;
            }
            set
            {
                _ID_WIPDetail = value;
                RaisePropertyChanged("ID_WIPDetail");
            }
        }

        public int StatusId
        {
            get
            {
                return _StatusId;
            }
            set
            {
                _StatusId = value;
                RaisePropertyChanged("StatusId");
            }
        }

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

        public string MaKien
        {
            get
            {
                return _MaKien;
            }
            set
            {
                _MaKien = value;
                RaisePropertyChanged("MaKien");
            }
        }

        public double? SoKgChuan
        {
            get
            {
                return _SoKgChuan;
            }
            set
            {
                _SoKgChuan = value;
                RaisePropertyChanged("SoKgChuan");
            }
        }

        public int? SoCuonChuan
        {
            get
            {
                return _SoCuonChuan;
            }
            set
            {
                _SoCuonChuan = value;
                RaisePropertyChanged("SoCuonChuan");
            }
        }

        public int? SoCuonThucTe
        {
            get
            {
                return _SoCuonThucTe;
            }
            set
            {
                _SoCuonThucTe = value;
                RaisePropertyChanged("SoCuonThucTe");
            }
        }

        public double? SoKg_BaoBi
        {
            get
            {
                return _SoKg_BaoBi;
            }
            set
            {
                _SoKg_BaoBi = value;
                RaisePropertyChanged("SoKg_BaoBi");
            }
        }

        public double? SoKg_BaoBi_Cuon
        {
            get
            {
                return _SoKg_BaoBi_Cuon;
            }
            set
            {
                _SoKg_BaoBi_Cuon = value;
                RaisePropertyChanged("SoKg_BaoBi_Cuon");
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
                SoKgTruBaoBi = 0.0;
                RaisePropertyChanged("SoKg_ThucTe");
            }
        }

        public double SoKg { get; set; }

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

        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
                RaisePropertyChanged("UserName");
            }
        }

        public SortableList<WIP_CUON> WipCuons
        {
            get
            {
                return _WipCuons;
            }
            set
            {
                _WipCuons = value;
                RaisePropertyChanged("WipCuons");
            }
        }

        public string QRCode
        {
            get
            {
                return _QRCode;
            }
            set
            {
                _QRCode = value;
                RaisePropertyChanged("QRCode");
            }
        }

        public bool Deleted
        {
            get
            {
                return _Deleted;
            }
            set
            {
                _Deleted = value;
                RaisePropertyChanged("Deleted");
            }
        }

        public DateTime? ReturnDate { get; set; }

        public string MaThanhPham { get; set; }

        public string SoKienSanXuat
        {
            get
            {
                return _SoKienSanXuat;
            }
            set
            {
                _SoKienSanXuat = value;
                RaisePropertyChanged("SoKienSanXuat");
            }
        }

        [JsonIgnore]
        public double SoKgTruBaoBi
        {
            get
            {
                return Helper.RoundDouble(SoKg_ThucTe.GetValueOrDefault() - SoKg_BaoBi.GetValueOrDefault() - SoKg_BaoBi_Cuon.GetValueOrDefault());
            }
            private set
            {
                RaisePropertyChanged("SoKgTruBaoBi");
            }
        }

        public byte Error { get; set; }

        public int? InnerId { get; set; }

        public string InnerCode { get; set; }

        public string InnerCodeFull { get; set; }

        public int? InnerQty { get; set; }

        public double? InnerTrongLuong { get; set; }

        public int? OuterId { get; set; }

        public string OuterCode { get; set; }

        public string OuterCodeFull { get; set; }

        public int? OuterQty { get; set; }

        public double? OuterTrongLuong { get; set; }

        public double? SO_MET
        {
            get
            {
                return _SO_MET;
            }
            set
            {
                _SO_MET = value;
                RaisePropertyChanged("SO_MET");
            }
        }

        public WIP_KIEN()
        {
            WipCuons = new SortableList<WIP_CUON>();
        }

        private List<WIP_CUON> CloneCuons()
        {
            List<WIP_CUON> list = new List<WIP_CUON>();
            foreach (WIP_CUON item in WipCuons.Where((WIP_CUON s) => s.ID_WIP_Cuon == 0 || s.HasChanges).ToList())
            {
                list.Add(item.Clone());
            }
            return list;
        }

        public WIP_KIEN Clone(int index = -1)
        {
            WIP_KIEN wIP_KIEN = new WIP_KIEN
            {
                ID_WIP_Kien = ID_WIP_Kien,
                ID_WIPDetail = ID_WIPDetail,
                StatusId = StatusId,
                Status = Status,
                MaKien = MaKien,
                SoKgChuan = SoKgChuan,
                SoCuonChuan = SoCuonChuan,
                SoCuonThucTe = SoCuonThucTe,
                SoKg_BaoBi = SoKg_BaoBi,
                SoKg_BaoBi_Cuon = SoKg_BaoBi_Cuon,
                SoKg_ThucTe = SoKg_ThucTe,
                NgayIn = NgayIn,
                Created = Created,
                CreatedBy = CreatedBy,
                Modified = Modified,
                ModifiedBy = ModifiedBy,
                UserName = UserName,
                QRCode = QRCode,
                Deleted = Deleted,
                ReturnDate = ReturnDate,
                MaThanhPham = MaThanhPham
            };
            if (WipCuons != null && WipCuons.Count > 0)
            {
                if (index >= 0)
                {
                    wIP_KIEN.WipCuons.Add(WipCuons[index]);
                }
                else
                {
                    wIP_KIEN.WipCuons = new SortableList<WIP_CUON>(CloneCuons());
                }
            }
            return wIP_KIEN;
        }
    }
}
