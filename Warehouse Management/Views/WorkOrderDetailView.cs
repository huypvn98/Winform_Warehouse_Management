using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management.Models;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Views
{
    public partial class WorkOrderDetailView : UserControl
    {
        private WIP _wip;
        private bool _isOpeningKien;
        private bool _hasChanges;
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
            ButtonExt buttonExt = btnOpenPackage;
            ButtonExt buttonExt2 = btnCloseOrder;
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
            ButtonExt buttonExt3 = btnSavePackage;
            ButtonExt buttonExt4 = btnClosePackage;
            flag2 = (btnDeleteKien.Visible = _isOpeningKien);
            enabled = (buttonExt4.Visible = flag2);
            buttonExt3.Visible = enabled;
            btnReturnKien.Visible = WIP.WIPDetailCurrent.StatusId == 4 && WIP.WIPDetailCurrent.WipKienCurrent.StatusId == 5;
            if (!GlobalSetting.IsAdmin)
            {
                btnReturnKien.Visible = false;
            }
        }

    }
}
