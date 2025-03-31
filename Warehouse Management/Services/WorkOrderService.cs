using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Models;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Services
{
    public class WorkOrderService : ServiceBase
    {
        private string _uri = "api/wip/";

        public List<WIP> GetWorkOrder(string factoryCode, DateTime fromDate, DateTime toDate, string status, string wipNumber, bool loadERP = false)
        {
            string uri = _uri + (loadERP ? "getwiperp/" : "getwipclient/");
            uri += (string.IsNullOrWhiteSpace(factoryCode) ? "null" : factoryCode);
            uri = uri + "/" + fromDate.ToString("dd-MM-yyyy") + "/" + toDate.AddDays(1.0).ToString("dd-MM-yyyy");
            uri = uri + "/" + (string.IsNullOrEmpty(status) ? "null" : status);
            uri = uri + "?wipnumber=" + (string.IsNullOrWhiteSpace(wipNumber) ? "null" : Helper.EscapeDataString(wipNumber));
            return Task.Run(async () => await Get<List<WIP>>(uri)).Result;
        }

        public bool GetWorkOrderStatusOnDemand(List<int> wipIDs)
        {
            string uri = "api/workorder/getworkorderstatusondemand/";
            return Task.Run(async () => await Post<bool, List<int>>(uri, wipIDs)).Result;
        }

        public bool UpdateIsCanKien(WIP wip)
        {
            string uri = string.Format(_uri + "updatecankien/{0}/{1}/{2}", wip.ID_WIP, wip.Type, GlobalSetting.Username);
            return Task.Run(async () => await Get<bool>(uri)).Result;
        }

        public List<WIPDetail> GetWorkOrderDetail(int woID)
        {
            string uri = _uri + "getwipdetailclient/" + woID;
            return Task.Run(async () => await Get<List<WIPDetail>>(uri)).Result;
        }

        public bool? CloseWip(int wipDetailID, DateTime transactionDate)
        {
            string uri = _uri + "closewip/" + wipDetailID + "/" + GlobalSetting.Username + "?transdate=" + transactionDate.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            return Task.Run(async () => await Get<bool?>(uri)).Result;
        }

        public List<WIP_ITEM> GetWIPItem(int wipID)
        {
            string uri = "api/wip-items/getlist/" + wipID;
            return Task.Run(async () => await Get<List<WIP_ITEM>>(uri)).Result;
        }

        public List<WIP_KIEN> GetWIPKien(int wipDetailID)
        {
            string uri = "api/wip-kien/getlist/" + wipDetailID;
            return Task.Run(async () => await Get<List<WIP_KIEN>>(uri)).Result;
        }

        public List<WIP_KIEN_SEARCH> SearchKien(string makien, string macuon, string sokiensx, string cellcode, string thanhpham, string packagecode, bool deleted)
        {
            string uri = "api/wip-kien/searchkien/";
            uri = uri + "?makien=" + (string.IsNullOrWhiteSpace(makien) ? "null" : Helper.EscapeDataString(makien));
            uri = uri + "&macuon=" + (string.IsNullOrWhiteSpace(macuon) ? "null" : Helper.EscapeDataString(macuon));
            uri = uri + "&sokiensx=" + (string.IsNullOrWhiteSpace(sokiensx) ? "null" : Helper.EscapeDataString(sokiensx));
            uri = uri + "&cellcode=" + (string.IsNullOrWhiteSpace(cellcode) ? "" : Helper.EscapeDataString(cellcode));
            uri = uri + "&thanhpham=" + (string.IsNullOrWhiteSpace(thanhpham) ? "" : Helper.EscapeDataString(thanhpham));
            uri = uri + "&packagecode=" + (string.IsNullOrWhiteSpace(packagecode) ? "" : Helper.EscapeDataString(packagecode));
            uri = uri + "&deleted=" + deleted;
            return Task.Run(async () => await Get<List<WIP_KIEN_SEARCH>>(uri)).Result;
        }

        public WIP_KIEN SubmitWIPKien(WIP_KIEN kien, bool validate)
        {
            string uri = "api/wip-kien/newsubmit/" + validate;
            return Task.Run(async () => await Post<WIP_KIEN, WIP_KIEN>(uri, kien)).Result;
        }

        public Response<bool> ReturnWIPKien(int kienID)
        {
            string uri = "api/wip-kien/returnkien/" + kienID;
            return Task.Run(async () => await GetResp<bool>(uri)).Result;
        }

        public bool DeleteWIPKien(int kienId)
        {
            string uri = "api/wip-kien/delete/" + kienId + "/" + GlobalSetting.Username;
            return Task.Run(async () => await Get<bool>(uri)).Result;
        }

        public bool UpdateKienPrintDate(int kienId, DateTime ngayin)
        {
            string uri = "api/wip-kien/updateprintdate/" + kienId + "?printdate=" + ngayin.ToString();
            return Task.Run(async () => await Get<bool>(uri)).Result;
        }

        public Response<WIP_KIEN> GetKienByMaKien(string maKien)
        {
            string uri = "api/wip-kien/GetKienByMaKien?makien=" + Helper.EscapeDataString(maKien);
            return Task.Run(async () => await GetResp<WIP_KIEN>(uri)).Result;
        }

        public List<WIP_CUON> GetWIPCuon(int wipKienID)
        {
            string uri = "api/wip-cuon/getlist/" + wipKienID;
            return Task.Run(async () => await Get<List<WIP_CUON>>(uri)).Result ?? null;
        }

        public bool DeleteWIPCuon(int cuonID)
        {
            string uri = "api/wip-cuon/delete/" + cuonID + "/" + GlobalSetting.Username;
            return Task.Run(async () => await Get<bool>(uri)).Result;
        }

        public bool UpdateCuonPrintDate(int kienId, DateTime ngayin)
        {
            string uri = "api/wip-cuon/updateprintdate/" + kienId + "?printdate=" + ngayin.ToString();
            return Task.Run(async () => await Get<bool>(uri)).Result;
        }

        public bool ExistCuon(string macuon)
        {
            string uri = "api/wip-cuon/existcuon/?macuon=" + Helper.EscapeDataString(macuon);
            return Task.Run(async () => await Get<bool>(uri)).Result;
        }

        public Response<KienPrintLabel> GetKienPrintLabel(string qrCode)
        {
            if (qrCode == null)
            {
                qrCode = "";
            }
            string uri = _uri + "GetKienPrintLabel?qrcode=" + Helper.EscapeDataString(qrCode);
            return Task.Run(async () => await GetResp<KienPrintLabel>(uri)).Result;
        }

        public Response<List<KienPrintLabel>> GetAllKienPrintLabel(string qrCode)
        {
            if (qrCode == null)
            {
                qrCode = "";
            }
            string uri = _uri + "GetAllKienPrintLabel?qrcode=" + Helper.EscapeDataString(qrCode);
            return Task.Run(async () => await GetResp<List<KienPrintLabel>>(uri)).Result;
        }

        public Response<KienCuonPrintLabel> GetKienCuonPrintLabel(string qrCode)
        {
            if (qrCode == null)
            {
                qrCode = "";
            }
            string uri = _uri + "GetKienCuonPrintLabel?qrcode=" + Helper.EscapeDataString(qrCode);
            return Task.Run(async () => await GetResp<KienCuonPrintLabel>(uri)).Result;
        }

        public Response<List<KienCuonPrintLabel>> GetAllKienCuonPrintLabel(string qrCode)
        {
            if (qrCode == null)
            {
                qrCode = "";
            }
            string uri = _uri + "GetAllKienCuonPrintLabel?qrcode=" + Helper.EscapeDataString(qrCode);
            return Task.Run(async () => await GetResp<List<KienCuonPrintLabel>>(uri)).Result;
        }

        public Response<List<WIP_KIEN>> CreateInner(PackageReq dto)
        {
            string uri = "api/wip-kien/CreateInner/";
            return Task.Run(async () => await PostResp<List<WIP_KIEN>, PackageReq>(uri, dto)).Result;
        }

        public Response<List<WIP_KIEN>> DeleteInner(int packageId, int wipDetailId)
        {
            string uri = $"api/wip-kien/DeleteInner/{packageId}/{wipDetailId}";
            return Task.Run(async () => await GetResp<List<WIP_KIEN>>(uri)).Result;
        }

        public Response<List<WIP_KIEN>> CreateOuter(PackageReq dto)
        {
            string uri = "api/wip-kien/CreateOuter/";
            return Task.Run(async () => await PostResp<List<WIP_KIEN>, PackageReq>(uri, dto)).Result;
        }

        public Response<List<WIP_KIEN>> DeleteOuter(int packageId, int wipDetailId)
        {
            string uri = $"api/wip-kien/DeleteOuter/{packageId}/{wipDetailId}";
            return Task.Run(async () => await GetResp<List<WIP_KIEN>>(uri)).Result;
        }

        public Response<bool> WipUpdateNgayIn(int WipDetailId)
        {
            string uri = _uri + "WipUpdateNgayIn/" + WipDetailId;
            return Task.Run(async () => await GetResp<bool>(uri)).Result;
        }
    }
}
