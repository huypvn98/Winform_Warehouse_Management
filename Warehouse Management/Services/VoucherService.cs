using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Models;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Services
{
    public class VoucherService : ServiceBase
    {
        private string _uri = "api/Voucher/";

        //public Response<List<VoucherView>> GetVoucherChuyenKho(string maorg, string maorgto, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string uri = _uri + "GetVoucherChuyenKho?maorg={0}&maorgto={1}&vouchercode={2}&isfinish={3}&fromdate={4}&todate={5}";
        //    uri = string.Format(uri, maorg, maorgto, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetResp<List<VoucherView>>(uri)).Result;
        //}

        //public Response<VoucherView> UpdateVoucherChuyenKho(Voucher voucher)
        //{
        //    if (voucher == null)
        //    {
        //        return null;
        //    }
        //    string uri = _uri + "UpdateVoucherChuyenKho";
        //    return Task.Run(async () => await PostResp<VoucherView, Voucher>(uri, voucher)).Result;
        //}

        //public Response<VoucherFinishResp> SetFinish_VoucherChuyenKho(int voucherId, bool isfinish)
        //{
        //    string uri = _uri + "SetFinish_VoucherChuyenKho/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isfinish);
        //    return Task.Run(async () => await GetResp<VoucherFinishResp>(uri)).Result;
        //}

        //public Response<VoucherView> SetFinishVou_VoucherChuyenKho(int voucherId, bool isfinish)
        //{
        //    string uri = _uri + "SetFinishVou_VoucherChuyenKho/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isfinish);
        //    return Task.Run(async () => await GetResp<VoucherView>(uri)).Result;
        //}

        //public Response<string> SetStartStop_VoucherChuyenKho(int voucherId, bool isStarted)
        //{
        //    string uri = _uri + "SetStartStop_VoucherChuyenKho/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isStarted);
        //    return Task.Run(async () => await GetResp<string>(uri)).Result;
        //}

        //public Response<Stream> ExportVoucherKienCK(int voucherId)
        //{
        //    string uri = _uri + "ExportVoucherKienCK/{0}";
        //    uri = string.Format(uri, voucherId);
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        //public Response<Stream> ExportVoucherChuyenKho(string maorg, string maorgto, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string uri = _uri + "ExportVoucherChuyenKho?maorg={0}&maorgto={1}&vouchercode={2}&isfinish={3}&fromdate={4}&todate={5}";
        //    uri = string.Format(uri, maorg, maorgto, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        //public Response<List<VoucherView>> GetVoucherChuyenViTri(int warehouseid, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string uri = _uri + "GetVoucherChuyenViTri?warehouseid={0}&vouchercode={1}&isfinish={2}&fromdate={3}&todate={4}";
        //    uri = string.Format(uri, warehouseid, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetResp<List<VoucherView>>(uri)).Result;
        //}

        //public Response<VoucherView> UpdateVoucherChuyenViTri(Voucher voucher)
        //{
        //    if (voucher == null)
        //    {
        //        return null;
        //    }
        //    string uri = _uri + "UpdateVoucherChuyenViTri";
        //    return Task.Run(async () => await PostResp<VoucherView, Voucher>(uri, voucher)).Result;
        //}

        //public Response<VoucherFinishResp> SetFinish_VoucherChuyenViTri(int voucherId, bool isfinish)
        //{
        //    string uri = _uri + "SetFinish_VoucherChuyenViTri/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isfinish);
        //    return Task.Run(async () => await GetResp<VoucherFinishResp>(uri)).Result;
        //}

        //public Response<string> SetStartStop_VoucherChuyenViTri(int voucherId, bool isStarted)
        //{
        //    string uri = _uri + "SetStartStop_VoucherChuyenViTri/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isStarted);
        //    return Task.Run(async () => await GetResp<string>(uri)).Result;
        //}

        //public Response<List<VoucherView>> GetVoucherKiemKho(int warehouseid, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string uri = _uri + "GetVoucherKiemKho?warehouseid={0}&vouchercode={1}&isfinish={2}&fromdate={3}&todate={4}";
        //    uri = string.Format(uri, warehouseid, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetResp<List<VoucherView>>(uri)).Result;
        //}

        //public Response<VoucherView> UpdateVoucherKiemKho(Voucher voucher)
        //{
        //    if (voucher == null)
        //    {
        //        return null;
        //    }
        //    string uri = _uri + "UpdateVoucherKiemKho";
        //    return Task.Run(async () => await PostResp<VoucherView, Voucher>(uri, voucher)).Result;
        //}

        //public Response<VoucherFinishResp> SetFinish_VoucherKiemKho(int voucherId, bool isfinish)
        //{
        //    string uri = _uri + "SetFinish_VoucherKiemKho/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isfinish);
        //    return Task.Run(async () => await GetResp<VoucherFinishResp>(uri)).Result;
        //}

        //public Response<string> SetStartStop_VoucherKiemKho(int voucherId, bool isStarted)
        //{
        //    string uri = _uri + "SetStartStop_VoucherKiemKho/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isStarted);
        //    return Task.Run(async () => await GetResp<string>(uri)).Result;
        //}

        //public Response<Stream> ExportBaoCaoKiemKho(int voucherId)
        //{
        //    string uri = _uri + "ExportBaoCaoKiemKho/{0}";
        //    uri = string.Format(uri, voucherId);
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        //public Response<Stream> ExportInvTransactionImport(int voucherId)
        //{
        //    string uri = _uri + "ExportInvTransactionImport/{0}";
        //    uri = string.Format(uri, voucherId);
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        //public Response<List<VoucherView>> GetVoucherNhapChuyenKho(string maorg, string maorgto, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string uri = _uri + "GetVoucherNhapChuyenKho?maorg={0}&maorgto={1}&vouchercode={2}&isfinish={3}&fromdate={4}&todate={5}";
        //    uri = string.Format(uri, maorg, maorgto, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetResp<List<VoucherView>>(uri)).Result;
        //}

        //public Response<VoucherView> UpdateVoucherNhapChuyenKho(Voucher voucher)
        //{
        //    if (voucher == null)
        //    {
        //        return null;
        //    }
        //    string uri = _uri + "UpdateVoucherNhapChuyenKho";
        //    return Task.Run(async () => await PostResp<VoucherView, Voucher>(uri, voucher)).Result;
        //}

        //public Response<VoucherFinishResp> SetFinish_VoucherNhapChuyenKho(int voucherId, bool isfinish)
        //{
        //    string uri = _uri + "SetFinish_VoucherNhapChuyenKho/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isfinish);
        //    return Task.Run(async () => await GetResp<VoucherFinishResp>(uri)).Result;
        //}

        //public Response<Stream> ExportVoucherNhapChuyenKho(string maorg, string maorgto, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string uri = _uri + "ExportVoucherNhapChuyenKho?maorg={0}&maorgto={1}&vouchercode={2}&isfinish={3}&fromdate={4}&todate={5}";
        //    uri = string.Format(uri, maorg, maorgto, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        //public Response<List<VoucherView>> GetVoucherNhapKhoHH(string maorg, int? warehouseid, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string text = warehouseid.ToString();
        //    if (!warehouseid.HasValue || warehouseid < 0)
        //    {
        //        text = "";
        //    }
        //    string uri = _uri + "GetVoucherNhapKhoTrading?maorg={0}&warehouseid={1}&vouchercode={2}&isfinish={3}&fromdate={4}&todate={5}";
        //    uri = string.Format(uri, maorg, text, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetResp<List<VoucherView>>(uri)).Result;
        //}

        //public Response<VoucherView> UpdateVoucherNhapKhoHH(Voucher voucher)
        //{
        //    if (voucher == null)
        //    {
        //        return null;
        //    }
        //    string uri = _uri + "UpdateVoucherNhapKhoTrading";
        //    return Task.Run(async () => await PostResp<VoucherView, Voucher>(uri, voucher)).Result;
        //}

        //public Response<VoucherView> UpdateVoucherNhapKhoNVL(Voucher voucher)
        //{
        //    if (voucher == null)
        //    {
        //        return null;
        //    }
        //    string uri = _uri + "UpdateVoucherNhapKhoNVL";
        //    return Task.Run(async () => await PostResp<VoucherView, Voucher>(uri, voucher)).Result;
        //}

        //public Response<VoucherFinishResp> SetFinish_VoucherNhapKhoHH(int voucherId, bool isfinish)
        //{
        //    string uri = _uri + "SetFinish_VoucherNhapKhoTrading/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isfinish);
        //    return Task.Run(async () => await GetResp<VoucherFinishResp>(uri)).Result;
        //}

        //public Response<string> SetStartStop_VoucherNhapKhoHH(int voucherId, bool isStarted)
        //{
        //    string uri = _uri + "SetStartStop_VoucherNhapKhoTrading/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isStarted);
        //    return Task.Run(async () => await GetResp<string>(uri)).Result;
        //}

        //public Response<int> AddItem_VoucherNhapKhoHH(int voucherId, int requestQty, string maThanhPham)
        //{
        //    if (maThanhPham == null)
        //    {
        //        maThanhPham = "";
        //    }
        //    string uri = _uri + "AddItem_VoucherNhapKhoTrading/{0}/{1}?maThanhPham={2}";
        //    uri = string.Format(uri, voucherId, requestQty, maThanhPham);
        //    return Task.Run(async () => await GetResp<int>(uri)).Result;
        //}

        //public Response<List<Item>> SearchItem(string maThanhPham, int voucherId)
        //{
        //    if (maThanhPham == null)
        //    {
        //        maThanhPham = "";
        //    }
        //    string uri = _uri + "SearchItem?maitem={0}&voucherId={1}";
        //    uri = string.Format(uri, maThanhPham, voucherId);
        //    return Task.Run(async () => await GetResp<List<Item>>(uri)).Result;
        //}

        //public Response<List<KienPrintLabel>> CreateBarcode_VoucherNhapKhoHH(int voucherId, int requestQty, int barcodeType, string maThanhPham)
        //{
        //    if (maThanhPham == null)
        //    {
        //        maThanhPham = "";
        //    }
        //    string uri = _uri + "CreateBarcode_VoucherNhapKhoTrading/{0}/{1}/{2}?maThanhPham={3}";
        //    uri = string.Format(uri, voucherId, requestQty, barcodeType, maThanhPham);
        //    return Task.Run(async () => await GetResp<List<KienPrintLabel>>(uri)).Result;
        //}

        //public Response<List<KienPrintLabel>> CreateBarcode_NhanGop_VoucherNhapKhoHH(int voucherId, int requestQty, int barcodeType, string maThanhPham)
        //{
        //    if (maThanhPham == null)
        //    {
        //        maThanhPham = "";
        //    }
        //    string uri = _uri + "CreateBarcode_NhanGop_VoucherNhapKhoTrading/{0}/{1}/{2}?maThanhPham={3}";
        //    uri = string.Format(uri, voucherId, requestQty, barcodeType, maThanhPham);
        //    return Task.Run(async () => await GetResp<List<KienPrintLabel>>(uri)).Result;
        //}

        //public Response<List<BarcodeCreateSession>> GetBarcodeCreateSession(int voucherId, string maThanhPham)
        //{
        //    if (maThanhPham == null)
        //    {
        //        maThanhPham = "";
        //    }
        //    string uri = _uri + "GetBarcodeCreateSession/{0}?maThanhPham={1}";
        //    uri = string.Format(uri, voucherId, maThanhPham);
        //    return Task.Run(async () => await GetResp<List<BarcodeCreateSession>>(uri)).Result;
        //}

        //public Response<List<KienPrintLabel>> GetBarcodePrint(int barcodeSessionId, bool printAll, string barcode)
        //{
        //    if (barcode == null)
        //    {
        //        barcode = "";
        //    }
        //    string uri = _uri + "GetBarcodePrint/{0}/{1}?barcode={2}";
        //    uri = string.Format(uri, barcodeSessionId, printAll, barcode);
        //    return Task.Run(async () => await GetResp<List<KienPrintLabel>>(uri)).Result;
        //}

        //public Response<bool> UpdateBarcodePrintedDate(int barcodeSessionId, string barcodeIds)
        //{
        //    string uri = _uri + "UpdateBarcodePrintedDate";
        //    uri = string.Format(uri, barcodeSessionId, barcodeIds);
        //    return Task.Run(async () => await PostResp<bool, object>(uri, new
        //    {
        //        BarcodeSessionId = barcodeSessionId,
        //        BarcodeIds = barcodeIds
        //    })).Result;
        //}

        //public Response<Stream> ExportVoucherNhapKhoHH(string maorg, int? warehouseId, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string text = warehouseId.ToString();
        //    if (!warehouseId.HasValue || warehouseId < 0)
        //    {
        //        text = "";
        //    }
        //    string uri = _uri + "ExportVoucherNhapKhoTrading?maorg={0}&warehouseId={1}&vouchercode={2}&isfinish={3}&fromdate={4}&todate={5}";
        //    uri = string.Format(uri, maorg, text, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        //public Response<Stream> ExportRCVTransactionTrading(int voucherId)
        //{
        //    string uri = _uri + "ExportRCVTransactionTrading/{0}";
        //    uri = string.Format(uri, voucherId);
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        public Response<PrintLabelTemplate> GetPrintLabelTemplate()
        {
            string uri = _uri + "GetPrintLabelTemplate";
            return Task.Run(async () => await GetResp<PrintLabelTemplate>(uri)).Result;
        }

        //public Response<List<VoucherView>> GetVoucherNhapKhoHangGoi(int? warehouseid, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string text = warehouseid.ToString();
        //    if (!warehouseid.HasValue || warehouseid < 0)
        //    {
        //        text = "";
        //    }
        //    string uri = _uri + "GetVoucherNhapKhoHangGoi?warehouseid={0}&vouchercode={1}&isfinish={2}&fromdate={3}&todate={4}";
        //    uri = string.Format(uri, text, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetResp<List<VoucherView>>(uri)).Result;
        //}

        //public Response<VoucherView> UpdateVoucherNhapKhoHangGoi(Voucher voucher)
        //{
        //    if (voucher == null)
        //    {
        //        return null;
        //    }
        //    string uri = _uri + "UpdateVoucherNhapKhoHangGoi";
        //    return Task.Run(async () => await PostResp<VoucherView, Voucher>(uri, voucher)).Result;
        //}

        //public Response<VoucherFinishResp> SetFinish_VoucherNhapKhoHangGoi(int voucherId, bool isfinish)
        //{
        //    string uri = _uri + "SetFinish_VoucherNhapKhoHangGoi/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isfinish);
        //    return Task.Run(async () => await GetResp<VoucherFinishResp>(uri)).Result;
        //}

        //public Response<string> SetStartStop_VoucherNhapKhoHangGoi(int voucherId, bool isStarted)
        //{
        //    string uri = _uri + "SetStartStop_VoucherNhapKhoHangGoi/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isStarted);
        //    return Task.Run(async () => await GetResp<string>(uri)).Result;
        //}

        //public Response<List<CustomerView>> SearchCustomer(string keyword)
        //{
        //    if (keyword == null)
        //    {
        //        keyword = "";
        //    }
        //    string uri = _uri + "SearchCustomer?keyword={0}";
        //    uri = string.Format(uri, keyword);
        //    return Task.Run(async () => await GetResp<List<CustomerView>>(uri)).Result;
        //}

        //public Response<Stream> ExportVoucherNhapKhoHangGoi(int? warehouseId, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string text = warehouseId.ToString();
        //    if (!warehouseId.HasValue || warehouseId < 0)
        //    {
        //        text = "";
        //    }
        //    string uri = _uri + "ExportVoucherNhapKhoHangGoi?warehouseId={0}&vouchercode={1}&isfinish={2}&fromdate={3}&todate={4}";
        //    uri = string.Format(uri, text, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        //public Response<List<VoucherView>> GetVoucherXuatKhoHangGoi(int? warehouseid, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string text = warehouseid.ToString();
        //    if (!warehouseid.HasValue || warehouseid < 0)
        //    {
        //        text = "";
        //    }
        //    string uri = _uri + "GetVoucherXuatKhoHangGoi?warehouseid={0}&vouchercode={1}&isfinish={2}&fromdate={3}&todate={4}";
        //    uri = string.Format(uri, text, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetResp<List<VoucherView>>(uri)).Result;
        //}

        //public Response<VoucherView> UpdateVoucherXuatKhoHangGoi(Voucher voucher)
        //{
        //    if (voucher == null)
        //    {
        //        return null;
        //    }
        //    string uri = _uri + "UpdateVoucherXuatKhoHangGoi";
        //    return Task.Run(async () => await PostResp<VoucherView, Voucher>(uri, voucher)).Result;
        //}

        //public Response<VoucherFinishResp> SetFinish_VoucherXuatKhoHangGoi(int voucherId, bool isfinish)
        //{
        //    string uri = _uri + "SetFinish_VoucherXuatKhoHangGoi/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isfinish);
        //    return Task.Run(async () => await GetResp<VoucherFinishResp>(uri)).Result;
        //}

        //public Response<string> SetStartStop_VoucherXuatKhoHangGoi(int voucherId, bool isStarted)
        //{
        //    string uri = _uri + "SetStartStop_VoucherXuatKhoHangGoi/{0}/{1}";
        //    uri = string.Format(uri, voucherId, isStarted);
        //    return Task.Run(async () => await GetResp<string>(uri)).Result;
        //}

        //public Response<Voucher> SetApproval_VoucherXuatKhoHangGoi(int voucherId, bool approve)
        //{
        //    string uri = _uri + "SetApproval_VoucherXuatKhoHangGoi/{0}/{1}";
        //    uri = string.Format(uri, voucherId, approve);
        //    return Task.Run(async () => await GetResp<Voucher>(uri)).Result;
        //}

        //public Response<int> AddItem_VoucherXuatKhoHangGoi(int voucherId, int requestQty, string maThanhPham)
        //{
        //    if (maThanhPham == null)
        //    {
        //        maThanhPham = "";
        //    }
        //    string uri = _uri + "AddItem_VoucherXuatKhoHangGoi/{0}/{1}?maThanhPham={2}";
        //    uri = string.Format(uri, voucherId, requestQty, maThanhPham);
        //    return Task.Run(async () => await GetResp<int>(uri)).Result;
        //}

        //public Response<string> RemoveItem_VoucherXuatKhoHangGoi(int voucherId, int voucherItemId)
        //{
        //    string uri = _uri + "RemoveItem_VoucherXuatKhoHangGoi/{0}/{1}";
        //    uri = string.Format(uri, voucherId, voucherItemId);
        //    return Task.Run(async () => await GetResp<string>(uri)).Result;
        //}

        //public Response<List<TonKhoNVL>> GetTonKho_VoucherXuatKhoHangGoi(int warehouseId, int voucherId, string maKien, string itemCode, string vouchercode)
        //{
        //    string uri = _uri + "GetTonKho_VoucherXuatKhoHangGoi/{0}/{1}?maKien={2}&itemCode={3}&vouchercode={4}";
        //    uri = string.Format(uri, warehouseId, voucherId, Helper.EscapeDataString(maKien), Helper.EscapeDataString(itemCode), Helper.EscapeDataString(vouchercode));
        //    return Task.Run(async () => await GetResp<List<TonKhoNVL>>(uri)).Result;
        //}

        //public Response<string> AddDetail_VoucherXuatKhoHangGoi(int voucherId, List<TonKhoNVL> data)
        //{
        //    string uri = _uri + "AddDetail_VoucherXuatKhoHangGoi/{0}";
        //    uri = string.Format(uri, voucherId);
        //    return Task.Run(async () => await PostResp<string, List<TonKhoNVL>>(uri, data)).Result;
        //}

        //public Response<string> DeleteDetail_VoucherXuatKhoHangGoi(int voucherId, string qrCode)
        //{
        //    string uri = _uri + "DeleteDetail_VoucherXuatKhoHangGoi/{0}?qrCode={1}";
        //    uri = string.Format(uri, voucherId, Helper.EscapeDataString(qrCode));
        //    return Task.Run(async () => await GetResp<string>(uri)).Result;
        //}

        //public Response<Stream> ExportVoucherXuatKhoHangGoi(int? warehouseId, string vouchercode, bool? isfinish, DateTime fromdate, DateTime todate)
        //{
        //    string text = warehouseId.ToString();
        //    if (!warehouseId.HasValue || warehouseId < 0)
        //    {
        //        text = "";
        //    }
        //    string uri = _uri + "ExportVoucherXuatKhoHangGoi?warehouseId={0}&vouchercode={1}&isfinish={2}&fromdate={3}&todate={4}";
        //    uri = string.Format(uri, text, vouchercode, isfinish, Helper.ToDateString(fromdate), Helper.ToDateString(todate));
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        //public Response<Stream> Export_VoucherXuatKhoHangGoi(int voucherId)
        //{
        //    string uri = _uri + "Export_VoucherXuatKhoHangGoi/{0}";
        //    uri = string.Format(uri, voucherId);
        //    return Task.Run(async () => await GetDownloadResp(uri)).Result;
        //}

        //public Response<VoucherItemDetail> GetVoucherItemDetail(int voucherId)
        //{
        //    string uri = _uri + "GetVoucherItemDetail/" + voucherId;
        //    return Task.Run(async () => await GetResp<VoucherItemDetail>(uri)).Result;
        //}

        //public Response<VoucherView> GetVoucher(int voucherId)
        //{
        //    string uri = _uri + voucherId;
        //    return Task.Run(async () => await GetResp<VoucherView>(uri)).Result;
        //}

        //public Response<string> DeleteVoucher(int voucherId)
        //{
        //    string uri = _uri + voucherId;
        //    return Task.Run(async () => await DeleteResp<string>(uri)).Result;
        //}

        //public Response<List<DeliveryPoint>> GetDeliveryPoint()
        //{
        //    string uri = _uri + "GetDeliveryPoint";
        //    return Task.Run(async () => await GetResp<List<DeliveryPoint>>(uri)).Result;
        //}

        //public Response<List<DeliveryPoint>> GetDeliveryPointERP()
        //{
        //    string uri = _uri + "GetDeliveryPointERP";
        //    return Task.Run(async () => await GetResp<List<DeliveryPoint>>(uri)).Result;
        //}
    }
}
