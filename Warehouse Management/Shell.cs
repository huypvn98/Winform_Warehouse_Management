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
using Warehouse_Management.Views;

namespace Warehouse_Management
{
    public partial class Shell : Form
    {

        private List<TabPage> _tabPages = new List<TabPage>();
        private WorkOrderBase _woBase;

        public Shell()
        {
            InitializeComponent();
        }

        private void Shell_Load(object sender, EventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.ShowDialog();
        }

        private void Shell_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void InitTabPages()
        {
            int i = 0;
            for (int count = tcMainContent.TabPages.Count; i < count; i++)
            {
                tcMainContent.TabPages.RemoveAt(0);
            }
            int num = 0;
            if (CanView(KindOfScreens.WO))
            {
                tcMainContent.TabPages.Add(_tabPages[0]);
                tcMainContent.TabPages[num++].Controls.Add(_woBase);
            }
            //if (CanView(KindOfScreens.XUATSANXUAT))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[1]);
            //    tcMainContent.TabPages[num++].Controls.Add(_xuatSanXuatView);
            //}
            //if (CanView(KindOfScreens.SO))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[2]);
            //    tcMainContent.TabPages[num++].Controls.Add(_soBase);
            //}
            //if (CanView(KindOfScreens.SOACTIVITY))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[3]);
            //    tcMainContent.TabPages[num++].Controls.Add(_soActivityView);
            //}
            //if (CanView(KindOfScreens.GIAOHANG))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[4]);
            //    tcMainContent.TabPages[num++].Controls.Add(_giaoHangView);
            //}
            //if (CanView(KindOfScreens.SORETURN))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[5]);
            //    tcMainContent.TabPages[num++].Controls.Add(_soReturnView);
            //}
            //if (CanView(KindOfScreens.WAREHOUSETRANSFER))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[6]);
            //    tcMainContent.TabPages[num++].Controls.Add(_chuyenKhoXuatView);
            //}
            //if (CanView(KindOfScreens.WAREHOUSEIMPORT))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[7]);
            //    tcMainContent.TabPages[num++].Controls.Add(_chuyenKhoNhapView);
            //}
            //if (CanView(KindOfScreens.WAREHOUSELOCATION))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[8]);
            //    tcMainContent.TabPages[num++].Controls.Add(_chuyenViTriView);
            //}
            //if (CanView(KindOfScreens.INVENTORY))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[9]);
            //    tcMainContent.TabPages[num++].Controls.Add(_kiemKhoView);
            //}
            //if (CanView(KindOfScreens.IMPORTGOODS))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[10]);
            //    tcMainContent.TabPages[num++].Controls.Add(_nhapKhoHHView);
            //}
            //if (CanView(KindOfScreens.NHAPKHOHANGGOI))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[11]);
            //    tcMainContent.TabPages[num++].Controls.Add(_nhapKhoHangGoiView);
            //}
            //if (CanView(KindOfScreens.XUATKHOHANGGOI))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[12]);
            //    tcMainContent.TabPages[num++].Controls.Add(_xuatKhoHangGoiView);
            //}
            //if (CanView(KindOfScreens.CHUYENKHONVL))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[13]);
            //    tcMainContent.TabPages[num++].Controls.Add(_chuyenKhoNVLView);
            //}
            //if (CanView(KindOfScreens.TIEUHAONVL))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[14]);
            //    tcMainContent.TabPages[num++].Controls.Add(_tieuHaoNVLView);
            //}
            //tcMainContent.TabPages.Add(_tabPages[15]);
            //tcMainContent.TabPages[num++].Controls.Add(_kienSearchView);
            //if (CanView(KindOfScreens.CONFIGURATION))
            //{
            //    tcMainContent.TabPages.Add(_tabPages[16]);
            //    tcMainContent.TabPages[num++].Controls.Add(_settingView);
            //}
            if (tcMainContent.TabPages.Count <= 12)
            {
                tcMainContent.ItemSize = new Size(52, 120);
            }
            else if (tcMainContent.TabPages.Count <= 15)
            {
                tcMainContent.ItemSize = new Size(42, 120);
            }
            else
            {
                tcMainContent.ItemSize = new Size(32, 120);
            }
        }

        private bool CanView(KindOfScreens screen)
        {
            if (screen == KindOfScreens.Searching)
            {
                return true;
            }
            List<PermissionUser> permissions = GlobalSetting.Permissions;
            if (permissions == null || permissions.Count == 0)
            {
                return false;
            }
            return permissions.Any((PermissionUser s) => s.FeatureCode == screen.ToString() && s.View);
        }
    }
}
