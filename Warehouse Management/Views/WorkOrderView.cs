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
    public partial class WorkOrderView : UserControl
    {
        private SortableList<WIP> _wips;
        public Control FocusedControl { get; private set; }
        public WorkOrderDetailView WODetailView { get; set; }
        public WorkOrderDetailEANView1 WODetailEANView { get; set; }
        public bool ClosedWip { get; set; }


        public WorkOrderView()
        {
            InitializeComponent();
        }

        private void dgWIP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && dgWIP.SelectedRows.Count != 0)
            {
                dgWIPDetail_CellDoubleClick(null, e);
            }
        }

        private void dgWIPDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && dgWIPDetail.SelectedRows.Count != 0)
            {
                ShowWorkOrderDetailView();
            }
        }

        private void ShowWorkOrderDetailView()
        {
            if (dgWIP.SelectedRows.Count == 0)
            {
                return;
            }
            WIP wIP = _wips[dgWIP.SelectedRows[0].Index];
            if (wIP.WIPDetails != null && dgWIPDetail.SelectedRows.Count != 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                FocusedControl = Helper.FindFocusedControl(this);
                Hide();
                wIP.WIPDetailCurrent = wIP.WIPDetails[dgWIPDetail.SelectedRows[0].Index];
                if (string.IsNullOrWhiteSpace(wIP.WIPDetailCurrent.MA_EAN))
                {
                    WODetailView.WIP = wIP;
                    WODetailView.Show();
                }
                else
                {
                    WODetailEANView.WIP = wIP;
                    WODetailEANView.Show();
                }
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
