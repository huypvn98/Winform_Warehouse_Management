using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management.Models;
using Warehouse_Management.Properties;
using Warehouse_Management.Services;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Views
{
    public partial class WorkOrderDetailEANView1 : UserControl
    {
        private readonly WorkOrderService _woService;
        private EANType _eanType;
        public WorkOrderView WorkOrderView { get; set; }
        private int _dgKienIdx = -1;


        private WIP _wip;
        private bool _isOpeningKien;
        private bool _hasChanges;
        private bool _weighingData;

        public WIP WIP
        {
            get
            {
                return _wip;
            }
            set
            {
                _wip = value;
                _isOpeningKien = (_hasChanges = false);
                InitOrder();
            }
        }
        internal bool IsTam => Helper.IsTamLuoi(_wip?.TenDonViTinh);

        public WorkOrderDetailEANView1()
        {
            InitializeComponent();
        }
        internal bool IsMet => Helper.IsMet(_wip?.TenDonViTinh);

        private void InitOrder()
        {
            if (_wip == null)
            {
                return;
            }
            Button buttonExt = btnOpenPackage;
            Button buttonExt2 = btnCloseOrder;
            bool flag2 = (dtpTransactionDate.Enabled = (WIP.StatusId == 1 || WIP.StatusId == 2) && (WIP.WIPDetailCurrent.StatusId == 1 || WIP.WIPDetailCurrent.StatusId == 2 || WIP.WIPDetailCurrent.StatusId == 7));
            bool enabled = (buttonExt2.Enabled = flag2);
            buttonExt.Enabled = enabled;
            if (dtpTransactionDate.Enabled)
            {
                dtpTransactionDate.Value = DateTime.Now;
            }
            if (WIP.WIPDetailCurrent.TransactionDate.HasValue)
            {
                dtpTransactionDate.Value = WIP.WIPDetailCurrent.TransactionDate.Value;
            }
            tbOrderCode.Text = WIP.WO_NUMBER;
            tbPONumber.Text = WIP.PO_NUMBER;
            tbMaThanhPham.Text = WIP.MaThanhPham;
            tbTenThanhPham.Text = WIP.TenThanhPham;
            tbSoKgKeHoach.Text = (IsTam ? WIP.WIPDetailCurrent.SL_KeHoach.ToString() : Helper.ConvertDouble(WIP.WIPDetailCurrent.SL_KeHoach));
            tbSoKgCanThucHien.Text = (IsTam ? WIP.WIPDetailCurrent.SL_CanThucHien.ToString() : Helper.ConvertDouble(WIP.WIPDetailCurrent.SL_CanThucHien));
            tbTolerance.Text = Helper.ConvertDouble(WIP.WIPDetailCurrent.TOLERANCE_VALUE);
            tbUnit.Text = WIP.TenDonViTinh;
            if (IsMet)
            {
                tbUnit.Text += $" ({Helper.ConvertDouble(WIP.WIPDetailCurrent.SO_MET.GetValueOrDefault())})";
            }
            SetCuonChuanText("0");
            tbCPSoKgBaoBi.Text = Helper.ConvertDouble(WIP.WIPDetailCurrent.TrongLuongBaoBi);
            double valueOrDefault = WIP.WIPDetailCurrent.TrongLuongChuanCuaKien.GetValueOrDefault();
            double num = WIP.WIPDetailCurrent.KIEN_TOLERANCE_BELOW(WIP.TOLERANCE_BELOW);
            double num2 = WIP.WIPDetailCurrent.KIEN_TOLERANCE_BELOW(WIP.TOLERANCE_OVER);
            if (valueOrDefault <= 0.0 && num <= 0.0 && num2 <= 0.0)
            {
                tbCPSoKgChuan.Text = "0";
            }
            else
            {
                string arg = Helper.ConvertDouble(valueOrDefault);
                if (num != 0.0 && num != num2)
                {
                    arg = $"{arg} [{Helper.ConvertDouble(num)} - {Helper.ConvertDouble(num2)}]";
                }
                tbCPSoKgChuan.Text = arg;
            }
            WorkOrderView.ClosedWip = false;
            _hasChanges = false;
            GetWIPItem();
            GetWIPKien();
            ChangeTitle_CuonTam();
            if (WIP.WIPDetailCurrent.QUYCACH_INNER == 0)
            {
                lblKien_NoInner_Text.Text = "Kiện chưa đóng outer:";
                Label label = lblKien_TotalInner_Text;
                enabled = (lblKien_TotalInner.Visible = false);
                label.Visible = enabled;
                Button buttonExt3 = btnInnerDelete;
                Button buttonExt4 = btnInnerClose;
                flag2 = (btnInnerPrint.Visible = false);
                enabled = (buttonExt4.Visible = flag2);
                buttonExt3.Visible = enabled;
            }
            else
            {
                lblKien_NoInner_Text.Text = "Kiện chưa đóng inner:";
                Label label2 = lblKien_TotalInner_Text;
                enabled = (lblKien_TotalInner.Visible = true);
                label2.Visible = enabled;
                Button buttonExt5 = btnInnerDelete;
                Button buttonExt6 = btnInnerClose;
                flag2 = (btnInnerPrint.Visible = true);
                enabled = (buttonExt6.Visible = flag2);
                buttonExt5.Visible = enabled;
            }
            _eanType = Helper.GetEANType(WIP.WIPDetailCurrent.MA_EAN);
        }
        private void GetWIPItem()
        {
            Cursor.Current = Cursors.WaitCursor;
            List<WIP_ITEM> wIPItem = _woService.GetWIPItem(WIP.ID_WIP);
            if (wIPItem != null)
            {
                WIP.WIPDetailCurrent.WipItems = new SortableList<WIP_ITEM>(wIPItem);
                dgWIPItem.AutoGenerateColumns = false;
                dgWIPItem.DataSource = WIP.WIPDetailCurrent.WipItems;
            }
            Cursor.Current = Cursors.Default;
        }

        private void SetCuonChuanText(string soCuon)
        {
            if (WIP == null || WIP.WIPDetailCurrent == null)
            {
                tbCPSoCuonChuan.Text = "";
                TextBox textBox = tbCP_EAN;
                TextBox textBox2 = tbCP_SpecOuter;
                string text2 = (tbCP_SpecInner.Text = "");
                string text4 = (textBox2.Text = text2);
                textBox.Text = text4;
            }
            else
            {
                tbCPSoCuonChuan.Text = soCuon + " / " + ((!WIP.WIPDetailCurrent.SoCuonTrongKien.HasValue) ? "0" : WIP.WIPDetailCurrent.SoCuonTrongKien.ToString());
                tbCP_EAN.Text = WIP.WIPDetailCurrent.MA_EAN;
                tbCP_SpecOuter.Text = Helper.ConvertInt(WIP.WIPDetailCurrent.QUYCACH_OUTER);
                tbCP_SpecInner.Text = Helper.ConvertInt(WIP.WIPDetailCurrent.QUYCACH_INNER);
            }
        }

        private void GetWIPKien()
        {
            Cursor.Current = Cursors.WaitCursor;
            List<WIP_KIEN> wIPKien = _woService.GetWIPKien(WIP.WIPDetailCurrent.ID_WIPDetail);
            if (wIPKien != null)
            {
                WIP.WIPDetailCurrent.WipKiens = new SortableList<WIP_KIEN>(wIPKien);
                dgKien.AutoGenerateColumns = false;
                dgKien.DataSource = WIP.WIPDetailCurrent.WipKiens;
                dgKien.FirstDisplayedScrollingColumnIndex = 0;
                UpdateLabelTotalKien();
                for (int i = 0; i < WIP.WIPDetailCurrent.WipKiens.Count; i++)
                {
                    if (WIP.WIPDetailCurrent.WipKiens[i].StatusId == 2)
                    {
                        dgKien.Rows[i].Selected = true;
                        _isOpeningKien = true;
                        Enable_OpeningKien(_isOpeningKien);
                        InitScanner();
                        InitWeighing();
                        FocusAfterOpenPackage();
                        break;
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
        private void FocusAfterOpenPackage()
        {
            if (string.IsNullOrEmpty(tbCPSoKienSX.Text))
            {
                tbCPSoKienSX.Focus();
            }
            else
            {
                tbWeighReading.Focus();
            }
        }

        private void InitScanner()
        {
        }
        public void InitWeighing(bool searchingPort = false)
        {
            COMPort.WeighingKien?.RemoveDataReceived(DataReceivedHandler);
            COMPort.WeighingKien?.Close();
            COMPort.WeighingKien?.Dispose();
            if (searchingPort && GlobalSetting.Weighing_AutoSearchingPort)
            {
                string[] array = null;
                try
                {
                    array = SerialPort.GetPortNames();
                }
                catch
                {
                    array = new string[5];
                    for (int i = 1; i <= 5; i++)
                    {
                        array[i - 1] = "COM" + i;
                    }
                }
                string[] array2 = array;
                foreach (string text in array2)
                {
                    _weighingData = false;
                    COMPort.WeighingKien = new EWeighing(text);
                    COMPort.WeighingKien?.Open();
                    COMPort.WeighingKien?.AddDataReceived(DataReceivedHandler_SearchingPort);
                    COMPort.WeighingKien?.RemoveDataReceived(DataReceivedHandler_SearchingPort);
                    COMPort.WeighingKien?.Close();
                    COMPort.WeighingKien?.Dispose();
                    Thread.Sleep(150);
                    if (_weighingData)
                    {
                        _weighingData = false;
                        GlobalSetting.WeighingKienPort = text;
                        try
                        {
                            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                            configuration.AppSettings.Settings["WeighingKien.Port"].Value = text;
                            configuration.Save(ConfigurationSaveMode.Modified);
                            ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
                        }
                        catch
                        {
                        }
                        break;
                    }
                }
            }
            COMPort.WeighingKien = new EWeighing();
            COMPort.WeighingKien?.Open();
            if (GlobalSetting.WeighingStable)
            {
                COMPort.WeighingKien?.AddDataReceived(DataReceivedHandler);
            }
        }
        private void DataReceivedHandler_SearchingPort(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);
            COMPort.WeighingKien?.RemoveDataReceived(DataReceivedHandler);
            if (!string.IsNullOrWhiteSpace(((SerialPort)sender).ReadExisting()))
            {
                BeginInvoke((Action)delegate
                {
                    _weighingData = true;
                });
            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (GlobalSetting.CurrentScreen != 0 || WIP == null || !_isOpeningKien)
            {
                return;
            }
            if (GlobalSetting.KindOfWeighing == 3 || GlobalSetting.KindOfWeighing == 4)
            {
                Thread.Sleep(100);
                COMPort.WeighingKien?.RemoveDataReceived(DataReceivedHandler);
                SerialPort serialPort = (SerialPort)sender;
                string indata1 = serialPort.ReadExisting();
                BeginInvoke((Action)delegate
                {
                    WeighingToData(COMPort.WeighingKien?.ReadWeight_InFactory2(indata1).ToString());
                });
                return;
            }
            SerialPort serialPort2 = (SerialPort)sender;
            string indata = serialPort2.ReadExisting();
            if (GlobalSetting.WeighingStable)
            {
                indata = COMPort.WeighingKien?.WeighingBelow30(indata);
                if (!string.IsNullOrWhiteSpace(indata))
                {
                    BeginInvoke((Action)delegate
                    {
                        WeighingToData(indata);
                    });
                }
            }
            else
            {
                if (GlobalSetting.KindOfWeighing != 2)
                {
                    return;
                }
                if (indata != Environment.NewLine)
                {
                    string text = indata.Trim();
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        COMPort.WeighingKien?.AddRawText(text);
                    }
                }
                else
                {
                    COMPort.WeighingKien?.RemoveDataReceived(DataReceivedHandler);
                    BeginInvoke((Action)delegate
                    {
                        string actualWeight = COMPort.WeighingKien?.ReadWeight_InFactory1();
                        WeighingToData(actualWeight);
                    });
                }
            }
        }
        private void WeighingToData(string actualWeight)
        {
            if (!double.TryParse(actualWeight, out var result))
            {
                return;
            }
            result = Helper.RoundDouble(result);
            if (result <= 0.0)
            {
                Helper.ShowNotifyIcon("Số kg bằng 0.");
            }
            else
            {
                if (GlobalSetting.ValidationWO && (WIP == null || !CheckKien_SoKgThucTe1(result)))
                {
                    return;
                }
                if (GlobalSetting.WeighingStable)
                {
                    if (tbWeighReading.Focused)
                    {
                        if (GlobalSetting.AutoSavePrintCuon)
                        {
                            SaveKienWithCuon_PrintCuon(result);
                        }
                        else
                        {
                            tbWeighReading.Text = Helper.ConvertDouble(result);
                        }
                    }
                }
                else if (GlobalSetting.AutoSavePrintCuon)
                {
                    SaveKienWithCuon_PrintCuon(result);
                }
                else
                {
                    tbWeighReading.Text = Helper.ConvertDouble(result);
                }
            }
        }
        private void SaveKienWithCuon_PrintCuon(double sokg)
        {
            if (!SaveKienWithCuon(-1, 2, GlobalSetting.ValidationWO, sokg))
            {
                return;
            }
            WorkOrderView.ClosedWip = true;
            if (!CreateInnerOuter())
            {
                if (!OpenPackage())
                {
                    btnClosePackage_Click(null, null);
                }
            }
            else
            {
                btnClosePackage_Click(null, null);
            }
        }
        private bool SaveKienWithCuon(int idx, int statusId, bool checkError, double sokg = 0.0)
        {
            Cursor.Current = Cursors.WaitCursor;
            WIP_KIEN wIP_KIEN = WIP.WIPDetailCurrent.WipKienCurrent.Clone(idx);
            wIP_KIEN.SoKg_ThucTe = sokg;
            wIP_KIEN.StatusId = statusId;
            bool flag = false;
            WIP_KIEN wIP_KIEN2 = SubmitWIPKien(wIP_KIEN, checkError);
            if (wIP_KIEN2 != null)
            {
                WIP.WIPDetailCurrent.WipKienCurrent.ID_WIP_Kien = wIP_KIEN2.ID_WIP_Kien;
                WIP.WIPDetailCurrent.WipKienCurrent.MaKien = wIP_KIEN2.MaKien;
                WIP.WIPDetailCurrent.WipKienCurrent.StatusId = wIP_KIEN2.StatusId;
                WIP.WIPDetailCurrent.WipKienCurrent.Status = wIP_KIEN2.Status;
                WIP.WIPDetailCurrent.WipKienCurrent.QRCode = wIP_KIEN2.QRCode;
                WIP.WIPDetailCurrent.WipKienCurrent.SoKienSanXuat = wIP_KIEN2.SoKienSanXuat;
                WIP.WIPDetailCurrent.WipKienCurrent.SoKg_ThucTe = wIP_KIEN2.SoKg_ThucTe;
                WIP.WIPDetailCurrent.WipKienCurrent.SoKg_BaoBi = wIP_KIEN2.SoKg_BaoBi;
                WIP.WIPDetailCurrent.WipKienCurrent.SO_MET = wIP_KIEN2.SO_MET;
                if (wIP_KIEN2.ID_WIP_Kien > 0)
                {
                    Button buttonExt = btnDeleteKien;
                    Button buttonExt2 = btnInnerClose;
                    Button buttonExt3 = btnInnerDelete;
                    Button buttonExt4 = btnOuterClose;
                    bool flag3 = (btnOuterDelete.Enabled = WIP.WIPDetailCurrent.StatusId != 5);
                    bool flag5 = (buttonExt4.Enabled = flag3);
                    bool flag7 = (buttonExt3.Enabled = flag5);
                    bool enabled = (buttonExt2.Enabled = flag7);
                    buttonExt.Enabled = enabled;
                    btnReturnKien.Visible = WIP.WIPDetailCurrent.StatusId == 4 && wIP_KIEN2.StatusId == 5;
                    if (!GlobalSetting.IsAdmin)
                    {
                        btnReturnKien.Visible = false;
                    }
                    _dgKienIdx = 0;
                    WIP.WIPDetailCurrent.WipKiens.Insert(0, WIP.WIPDetailCurrent.WipKienCurrent);
                    dgKien.Rows[0].Selected = true;
                    tbCPMaKien.Text = wIP_KIEN.MaKien;
                }
                UpdateLabelTotalKien();
                if (GlobalSetting.PrintAuto && wIP_KIEN2.StatusId == 5)
                {
                    DateTime now = DateTime.Now;
                    if (_woService.UpdateKienPrintDate(wIP_KIEN2.ID_WIP_Kien, now))
                    {
                        WIP.WIPDetailCurrent.WipKienCurrent.NgayIn = now;
                    }
                    PrintLabel(wIP_KIEN2, null, wIP_KIEN2.QRCode, InnerOuterType.Kien);
                }
            }
            else
            {
                flag = true;
            }
            Cursor.Current = Cursors.Default;
            return !flag;
        }
        private void PrintLabel(WIP_KIEN kien, string codeStr, string qrCodeStr, InnerOuterType type)
        {
            if (_eanType == EANType.EC)
            {
                Cursor.Current = Cursors.WaitCursor;
                Response<WIP_KIEN> resp = _woService.GetKienByMaKien(kien.MaKien);
                Cursor.Current = Cursors.Default;
                if (resp == null)
                {
                    Helper.ShowNotifyIcon(Resources.Kien_NoDataToPrint);
                }
                else if (resp.IsSuccessful)
                {
                    ORGANIZATION oRGANIZATION = GlobalSetting.Organizations?.Where((ORGANIZATION s) => s.MaOrg == WIP.MaOrg).FirstOrDefault();
                    ItemPrint itemPrint = new ItemPrint
                    {
                        WO_NUMBER = WIP.WO_NUMBER,
                        TenThanhPham = WIP.TenThanhPham,
                        TenDVT = WIP.TenDonViTinh,
                        TenDonViIn = WIP.WIPDetailCurrent.TenDonViIn,
                        MaThuongHieu = WIP.MaThuongHieu,
                        ThuongHieu = WIP.WIPDetailCurrent.ThuongHieu,
                        MaNhaMay = oRGANIZATION?.MaNhaMay,
                        TrongLuongChuanCuaKien = WIP.WIPDetailCurrent.TrongLuongChuanCuaKien.GetValueOrDefault(),
                        InnerOuterType = type,
                        QUYCACH_INNER = WIP.WIPDetailCurrent.QUYCACH_INNER.GetValueOrDefault(),
                        QUYCACH_OUTER = WIP.WIPDetailCurrent.QUYCACH_OUTER.GetValueOrDefault(),
                        QRCode = qrCodeStr,
                        InnerQty = resp.Data?.InnerQty,
                        InnerTrongLuong = resp.Data?.InnerTrongLuong,
                        OuterQty = resp.Data?.OuterQty,
                        OuterTrongLuong = resp.Data?.OuterTrongLuong
                    };
                    BeginInvoke((Action)delegate
                    {
                        if (GlobalSetting.UsePrintLabel100x60)
                        {
                            PrintHelper.Print(PDF.LabelKien100x60(resp.Data, itemPrint), isKien: true);
                        }
                        else
                        {
                            PrintHelper.Print(PDF.LabelKien110x90(resp.Data, itemPrint), isKien: true);
                        }
                    });
                }
                else
                {
                    Helper.ShowNotifyResponse(resp.Message, resp.StatusCode);
                }
            }
            else
            {
                BeginInvoke((Action)delegate
                {
                    PrintHelper.Print_InnerOuter(PDF.LabelKienInnerOuter(codeStr, qrCodeStr, type));
                });
            }
        }
        private void UpdateLabelTotalKien()
        {
            lblTotalKien.Text = WIP.WIPDetailCurrent.WipKiens.Count((WIP_KIEN s) => !s.Deleted).ToString();
            lblKien_TotalKgThucTe.Text = Helper.ConvertDouble(WIP.WIPDetailCurrent.WipKiens.Where((WIP_KIEN s) => !s.Deleted).Sum((WIP_KIEN s) => s.SoKgTruBaoBi));
            lblKien_TotalInner.Text = Helper.ConvertInt((from s in WIP.WIPDetailCurrent.WipKiens
                                                         where !s.Deleted && s.InnerId.HasValue
                                                         select s.InnerId).Distinct().Count());
            lblKien_TotalOuter.Text = Helper.ConvertInt((from s in WIP.WIPDetailCurrent.WipKiens
                                                         where !s.Deleted && s.OuterId.HasValue
                                                         select s.OuterId).Distinct().Count());
            if (WIP.WIPDetailCurrent.QUYCACH_INNER == 0)
            {
                lblKien_NoInner.Text = Helper.ConvertInt(WIP.WIPDetailCurrent.WipKiens.Count((WIP_KIEN s) => !s.Deleted && !s.OuterId.HasValue));
            }
            else
            {
                lblKien_NoInner.Text = Helper.ConvertInt(WIP.WIPDetailCurrent.WipKiens.Count((WIP_KIEN s) => !s.Deleted && !s.InnerId.HasValue));
            }
            if (WIP.WIPDetailCurrent.WipKienCurrent != null)
            {
                tbCPSoKgThucTe.Text = (_isOpeningKien ? Helper.ConvertDouble(0.0) : Helper.ConvertDouble(WIP.WIPDetailCurrent.WipKienCurrent.SoKg_ThucTe));
                tbCPSoKgTruBaoBi.Text = Helper.ConvertDouble((WIP.WIPDetailCurrent.WipKienCurrent.SoKgTruBaoBi < 0.0) ? 0.0 : WIP.WIPDetailCurrent.WipKienCurrent.SoKgTruBaoBi);
            }
        }
        private void Enable_OpeningKien(bool isOpeningKien)
        {
            tbCPSoKienSX.ReadOnly = !isOpeningKien;
            dgKien.Enabled = !isOpeningKien;
            Enable_PackageCurrent(isOpeningKien);
            btnCloseOrder.Enabled = !isOpeningKien;
            btnOpenPackage.Enabled = !isOpeningKien;
            btnClosePackage.Enabled = isOpeningKien;
            Button buttonExt = btnPrintKien;
            Button buttonExt2 = btnInnerPrint;
            bool flag2 = (btnOuterPrint.Enabled = !isOpeningKien);
            bool enabled = (buttonExt2.Enabled = flag2);
            buttonExt.Enabled = enabled;
            btnDeleteKien.Visible = !isOpeningKien;
            Button buttonExt3 = btnDeleteKien;
            Button buttonExt4 = btnInnerClose;
            Button buttonExt5 = btnInnerDelete;
            Button buttonExt6 = btnOuterClose;
            Button buttonExt7 = btnOuterDelete;
            WIP wIP = WIP;
            bool flag5 = (buttonExt7.Enabled = wIP == null || wIP.WIPDetailCurrent?.StatusId != 5);
            bool flag7 = (buttonExt6.Enabled = flag5);
            flag2 = (buttonExt5.Enabled = flag7);
            enabled = (buttonExt4.Enabled = flag2);
            buttonExt3.Enabled = enabled;
            Button buttonExt8 = btnReturnKien;
            int visible;
            if (!isOpeningKien)
            {
                WIP wIP2 = WIP;
                visible = ((wIP2 != null && wIP2.WIPDetailCurrent?.StatusId == 4) ? 1 : 0);
            }
            else
            {
                visible = 0;
            }
            buttonExt8.Visible = (byte)visible != 0;
            if (!GlobalSetting.IsAdmin)
            {
                btnReturnKien.Visible = false;
            }
        }
        private void Enable_PackageCurrent(bool isOpeningKien)
        {
            tbWeighReading.ReadOnly = !isOpeningKien;
            if (isOpeningKien)
            {
                tbWeighReading.Text = Helper.ConvertDouble(0.0);
            }
        }


    }
}
