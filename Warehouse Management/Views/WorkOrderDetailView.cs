using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management.Models;
using Warehouse_Management.Services;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Views
{
    public partial class WorkOrderDetailView : UserControl
    {
        private readonly WorkOrderService _woService;
        private bool _weighingData;

        private WIP _wip;
        private bool _isOpeningKien;
        private bool _hasChanges;
        public WorkOrderView WorkOrderView { get; set; }
        internal bool IsTam => Helper.IsTamLuoi(_wip?.TenDonViTinh);

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
        public WorkOrderDetailView()
        {
            InitializeComponent();
        }

        private void InitOrder()
        {
            if (_wip == null)
            {
                return;
            }
            byte b = WIP.Type;
            if (WIP.Type == 0)
            {
                b = (byte)(IsTam ? 3 : ((WIP.WIPDetailCurrent.SoCuonTrongKien.GetValueOrDefault() <= 1) ? 1 : 2));
            }
            panelCanCuonKien.Enabled = WIP.Type == 0;
            if (IsTam)
            {
                panelCanCuonKien.Enabled = false;
            }
            switch (b)
            {
                case 2:
                    rbtCancuon.Checked = true;
                    break;
                case 3:
                    rbtTam.Checked = true;
                    break;
                default:
                    rbtCanKien.Checked = true;
                    break;
            }
            Button buttonExt = btnOpenPackage;
            Button buttonExt2 = btnCloseOrder;
            bool flag2 = (dtpTransactionDate.Enabled = (WIP.StatusId == 1 || WIP.StatusId == 2) && (WIP.WIPDetailCurrent.StatusId == 1 || WIP.WIPDetailCurrent.StatusId == 2 || WIP.WIPDetailCurrent.StatusId == 7));
            bool enabled = (buttonExt2.Enabled = flag2);
            buttonExt.Enabled = enabled;
            SetBtnEditKien();
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
            //if (IsMet)
            //{
            //    tbUnit.Text += $" ({Helper.ConvertDouble(WIP.WIPDetailCurrent.SO_MET.GetValueOrDefault())})";
            //}
            //SetCuonChuanText("0");
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
            Button buttonExt3 = btnSavePackage;
            Button buttonExt4 = btnClosePackage;
            flag2 = (btnDeleteKien.Visible = _isOpeningKien);
            enabled = (buttonExt4.Visible = flag2);
            buttonExt3.Visible = enabled;
            btnReturnKien.Visible = WIP.WIPDetailCurrent.StatusId == 4 && WIP.WIPDetailCurrent.WipKienCurrent.StatusId == 5;
            if (!GlobalSetting.IsAdmin)
            {
                btnReturnKien.Visible = false;
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
                if (WIP.WIPDetailCurrent.WipKiens.Count > 0)
                {
                    panelCanCuonKien.Enabled = false;
                }
                else
                {
                    btnEditPackage.Enabled = false;
                }
                UpdateLabelTotalKien();
                UpdateLabelTotalCuon();
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

        private void Enable_OpeningKien(bool isOpeningKien)
        {
            dgCuon.EnterColumn = ((isOpeningKien && !GlobalSetting.WeighingStable) ? 1 : (-1));
            tbCPSoKienSX.ReadOnly = !isOpeningKien;
            dgKien.Enabled = !isOpeningKien;
            Enable_PackageCurrent(isOpeningKien);
            btnCloseOrder.Enabled = !isOpeningKien;
            btnOpenPackage.Enabled = !isOpeningKien;
            btnSavePackage.Enabled = isOpeningKien;
            btnClosePackage.Enabled = isOpeningKien;
            btnPrintKien.Enabled = !isOpeningKien;
            Button buttonExt = btnOpenPackage;
            bool visible = (btnEditPackage.Visible = !isOpeningKien);
            buttonExt.Visible = visible;
            Button buttonExt2 = btnSavePackage;
            Button buttonExt3 = btnClosePackage;
            bool flag3 = (btnDeleteKien.Visible = isOpeningKien);
            visible = (buttonExt3.Visible = flag3);
            buttonExt2.Visible = visible;
            Button buttonExt4 = btnReturnKien;
            int visible2;
            if (!isOpeningKien)
            {
                WIP wIP = WIP;
                visible2 = ((wIP != null && wIP.WIPDetailCurrent?.StatusId == 4) ? 1 : 0);
            }
            else
            {
                visible2 = 0;
            }
            buttonExt4.Visible = (byte)visible2 != 0;
            if (!GlobalSetting.IsAdmin)
            {
                btnReturnKien.Visible = false;
            }
            btnDeleteCuon.Enabled = isOpeningKien;
            if (WIP != null && WIP.WIPDetailCurrent.WipKienCurrent != null && dgKien.SelectedRows.Count > 0)
            {
                SetBtnEditKien();
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

        private void UpdateLabelTotalCuon()
        {
            WIP_KIEN wipKienCurrent = WIP.WIPDetailCurrent.WipKienCurrent;
            if (wipKienCurrent != null && wipKienCurrent.WipCuons != null)
            {
                double num = wipKienCurrent.WipCuons.Sum((WIP_CUON s) => s.SoKg_ThucTe.GetValueOrDefault());
                if (_isOpeningKien)
                {
                    wipKienCurrent.SoCuonThucTe = wipKienCurrent.WipCuons.Count;
                    wipKienCurrent.SoKg_ThucTe = Helper.RoundDouble((wipKienCurrent.SoCuonThucTe == 0 || num == 0.0) ? 0.0 : (num + wipKienCurrent.SoKg_BaoBi.GetValueOrDefault()));
                }
                lblTotalCuon.Text = wipKienCurrent.SoCuonThucTe.ToString();
                lblCuon_TotalKgThucTe.Text = Helper.ConvertDouble_Cuon(num);
                lblCuon_TotalKgBaoBi.Text = Helper.ConvertDouble(wipKienCurrent.WipCuons.Sum((WIP_CUON s) => s.SoKgBaoBi.GetValueOrDefault()));
                foreach (WIP_ITEM w in WIP.WIPDetailCurrent.WipItems)
                {
                    w.SoKg_ThucTe = Helper.RoundDouble(wipKienCurrent.WipCuons.Where((WIP_CUON s) => s.ID_ThanhPhan == w.ID_ThanhPhan).Sum((WIP_CUON s) => s.SoKg_ThucTe.GetValueOrDefault()));
                }
                if (_isOpeningKien)
                {
                    SetCuonChuanText(lblTotalCuon.Text);
                    tbCPSoKgThucTe.Text = Helper.ConvertDouble(wipKienCurrent.SoKg_ThucTe);
                }
                lblKien_TotalKgThucTe.Text = Helper.ConvertDouble(WIP.WIPDetailCurrent.WipKiens.Where((WIP_KIEN s) => !s.Deleted).Sum((WIP_KIEN s) => s.SoKgTruBaoBi));
                tbCPSoKgTruBaoBi.Text = Helper.ConvertDouble((wipKienCurrent.SoKgTruBaoBi < 0.0) ? 0.0 : wipKienCurrent.SoKgTruBaoBi);
            }
            else
            {
                lblTotalCuon.Text = "0";
                lblCuon_TotalKgThucTe.Text = Helper.ConvertDouble_Cuon(0.0);
                lblCuon_TotalKgBaoBi.Text = Helper.ConvertDouble(0.0);
            }
        }

        private void UpdateLabelTotalKien()
        {
            lblTotalKien.Text = WIP.WIPDetailCurrent.WipKiens.Count((WIP_KIEN s) => !s.Deleted).ToString();
            lblKien_TotalKgThucTe.Text = Helper.ConvertDouble(WIP.WIPDetailCurrent.WipKiens.Where((WIP_KIEN s) => !s.Deleted).Sum((WIP_KIEN s) => s.SoKgTruBaoBi));
            if (WIP.WIPDetailCurrent.WipKienCurrent == null || WIP.WIPDetailCurrent.WipKienCurrent.WipCuons == null)
            {
                return;
            }
            SetCuonChuanText(WIP.WIPDetailCurrent.WipKienCurrent.WipCuons.Count.ToString());
            tbWeighReading.Text = "";
            if (WIP.WIPDetailCurrent.WipKienCurrent.WipCuons.Count > 0)
            {
                if (_isOpeningKien)
                {
                    double num = Helper.RoundDouble(WIP.WIPDetailCurrent.WipKienCurrent.WipCuons.Sum((WIP_CUON s) => s.SoKg_ThucTe.GetValueOrDefault()));
                    tbCPSoKgThucTe.Text = Helper.ConvertDouble(num + WIP.WIPDetailCurrent.WipKienCurrent.SoKg_BaoBi.GetValueOrDefault());
                }
                else
                {
                    tbCPSoKgThucTe.Text = Helper.ConvertDouble(WIP.WIPDetailCurrent.WipKienCurrent.SoKg_ThucTe);
                }
            }
            else
            {
                tbCPSoKgThucTe.Text = Helper.ConvertDouble(0.0);
            }
        }
        private void SetCuonChuanText(string soCuon)
        {
            if (WIP == null || WIP.WIPDetailCurrent == null)
            {
                tbCPSoCuonChuan.Text = "";
            }
            else
            {
                tbCPSoCuonChuan.Text = soCuon + " / " + ((!WIP.WIPDetailCurrent.SoCuonTrongKien.HasValue) ? "0" : WIP.WIPDetailCurrent.SoCuonTrongKien.ToString());
            }
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

        private void SetBtnEditKien()
        {
            if (WIP == null || WIP.WIPDetailCurrent == null || WIP.WIPDetailCurrent.WipKienCurrent == null || WIP.WIPDetailCurrent.StatusId == 3)
            {
                btnEditPackage.Enabled = false;
            }
            else
            {
                btnEditPackage.Enabled = (GlobalSetting.IsAdmin && WIP.WIPDetailCurrent.StatusId != 4) || (!GlobalSetting.IsAdmin && WIP.WIPDetailCurrent.StatusId != 4 && WIP.WIPDetailCurrent.WipKienCurrent.StatusId == 2);
            }
        }

    }
}
