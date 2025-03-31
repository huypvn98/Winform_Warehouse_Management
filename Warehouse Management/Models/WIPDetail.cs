using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Models
{
    public class WIPDetail
    {
        public int ID_WIPDetail { get; set; }

        public int ID_WIP { get; set; }

        public int StatusId { get; set; }

        public string Status { get; set; }

        public int WIPStatusId { get; set; }

        public double? SL_KeHoach { get; set; }

        public double? SL_Receipted { get; set; }

        public double? SoKgThucTe { get; set; }

        public double? SoCuonThucTe { get; set; }

        public double? TongSoMet { get; set; }

        public double? SO_MET { get; set; }

        public double? TrongLuongChuanCuaKien { get; set; }

        public int? SoCuonTrongKien { get; set; }

        public double? TrongLuongBaoBi { get; set; }

        public double? TrongLuongBaoBiCuon { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? Modified { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? TransactionDate { get; set; }

        public double? TOLERANCE_VALUE { get; set; }

        public string ThuongHieu { get; set; }

        public string MA_EAN { get; set; }

        public int? QUYCACH_INNER { get; set; }

        public int? QUYCACH_OUTER { get; set; }

        public bool? InProcessError { get; set; }

        public string TenDonViIn { get; set; }

        [JsonIgnore]
        public SortableList<WIP_ITEM> WipItems { get; set; }

        [JsonIgnore]
        public SortableList<WIP_KIEN> WipKiens { get; set; }

        [JsonIgnore]
        public WIP_KIEN WipKienCurrent { get; set; }

        [JsonIgnore]
        public double SL_CanThucHien => (SL_KeHoach.GetValueOrDefault() - SL_Receipted).GetValueOrDefault();

        [JsonIgnore]
        public double Tolerance => SL_CanThucHien * TOLERANCE_VALUE.GetValueOrDefault() / SL_KeHoach.GetValueOrDefault();

        public WIPDetail()
        {
            WipKiens = new SortableList<WIP_KIEN>();
        }

        private double SoKgTolerance(double? sokg, double? tolerance)
        {
            if (tolerance.HasValue)
            {
                return sokg.GetValueOrDefault() * tolerance.GetValueOrDefault() / 100.0;
            }
            return 0.0;
        }

        public double KIEN_TOLERANCE_OVER(double? toleranceOver)
        {
            return Helper.RoundDouble(TrongLuongChuanCuaKien.GetValueOrDefault() + SoKgTolerance(TrongLuongChuanCuaKien, toleranceOver));
        }

        public double KIEN_TOLERANCE_BELOW(double? toleranceBelow)
        {
            return Helper.RoundDouble(TrongLuongChuanCuaKien.GetValueOrDefault() + SoKgTolerance(TrongLuongChuanCuaKien, toleranceBelow));
        }

        public double CUON_TOLERANCE_OVER(double? toleranceOver)
        {
            if (!SoCuonTrongKien.HasValue || SoCuonTrongKien <= 0)
            {
                return 0.0;
            }
            double num = TrongLuongChuanCuaKien.GetValueOrDefault() / (double)SoCuonTrongKien.GetValueOrDefault();
            return Helper.RoundDouble_Cuon(num + SoKgTolerance(num, toleranceOver));
        }

        public double CUON_TOLERANCE_BELOW(double? toleranceBelow)
        {
            if (!SoCuonTrongKien.HasValue || SoCuonTrongKien <= 0)
            {
                return 0.0;
            }
            double num = TrongLuongChuanCuaKien.GetValueOrDefault() / (double)SoCuonTrongKien.GetValueOrDefault();
            return Helper.RoundDouble_Cuon(num + SoKgTolerance(num, toleranceBelow));
        }
    }
}
