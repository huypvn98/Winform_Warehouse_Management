using System.Windows.Forms;
using WarehouseManagement.Control;

namespace Warehouse_Management.Views
{
    partial class WorkOrderView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFactory = new System.Windows.Forms.ComboBox();
            this.dpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dpToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWONumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgWIP = new System.Windows.Forms.DataGridView();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductionOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPONumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantityFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinishedPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colM_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colM_CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colM_Modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colM_ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgWIPDetail = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadERP = new Button();
            this.btnLoadStatus = new Button();
            this.ccbStatus = new CheckedComboBox();
            this.btnLoad = new Button();
            this.btnLoadDefault = new Button();
            this.colWOD_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWOD_CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWOD_SL_KeHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWOD_SL_Receipted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWOD_Tolerance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWOD_SoCuonThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWOD_SoKgThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWOD_SoMet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWOD_TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)this.dgWIP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgWIPDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label1.Location = new System.Drawing.Point(1, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Org";
            this.cbFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.cbFactory.FormattingEnabled = true;
            this.cbFactory.Location = new System.Drawing.Point(4, 54);
            this.cbFactory.Name = "cbFactory";
            this.cbFactory.Size = new System.Drawing.Size(236, 24);
            this.cbFactory.TabIndex = 2;
            this.dpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.dpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromDate.Location = new System.Drawing.Point(410, 54);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.Size = new System.Drawing.Size(101, 22);
            this.dpFromDate.TabIndex = 6;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label3.Location = new System.Drawing.Point(407, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Từ ngày";
            this.dpToDate.CustomFormat = "dd/MM/yyyy";
            this.dpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.dpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpToDate.Location = new System.Drawing.Point(517, 54);
            this.dpToDate.Name = "dpToDate";
            this.dpToDate.Size = new System.Drawing.Size(101, 22);
            this.dpToDate.TabIndex = 8;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label4.Location = new System.Drawing.Point(514, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tớ&i ngày";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label5.Location = new System.Drawing.Point(621, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tình trạn&g";
            this.tbWONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.tbWONumber.Location = new System.Drawing.Point(246, 54);
            this.tbWONumber.Name = "tbWONumber";
            this.tbWONumber.Size = new System.Drawing.Size(158, 22);
            this.tbWONumber.TabIndex = 4;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label6.Location = new System.Drawing.Point(243, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lệnh &sản xuất";
            this.dgWIP.AllowUserToAddRows = false;
            this.dgWIP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgWIP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgWIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWIP.Columns.AddRange(this.colStatus, this.colDate, this.colProductionOrder, this.colWarehouse, this.colPostion, this.colProductionCode, this.colProductName, this.colPONumber, this.colQuantity, this.colQuantityFinished, this.colFinishedPackage, this.colM_Created, this.colM_CreatedBy, this.colM_Modified, this.colM_ModifiedBy);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWIP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgWIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgWIP.Location = new System.Drawing.Point(0, 0);
            this.dgWIP.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.dgWIP.MultiSelect = false;
            this.dgWIP.Name = "dgWIP";
            this.dgWIP.ReadOnly = true;
            this.dgWIP.RowHeadersWidth = 25;
            this.dgWIP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgWIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWIP.Size = new System.Drawing.Size(1290, 338);
            this.dgWIP.TabIndex = 15;
            this.dgWIP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgWIP_CellDoubleClick);
            this.dgWIP.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(dgWIP_CellPainting);
            this.dgWIP.Sorted += new System.EventHandler(dgWIP_Sorted);
            this.dgWIP.KeyDown += new System.Windows.Forms.KeyEventHandler(dgWIP_KeyDown);
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Tình trạng";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatus.Width = 120;
            this.colDate.DataPropertyName = "WO_DATE";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.colDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDate.HeaderText = "Ngày";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 90;
            this.colProductionOrder.DataPropertyName = "WO_NUMBER";
            this.colProductionOrder.HeaderText = "Lệnh SX";
            this.colProductionOrder.Name = "colProductionOrder";
            this.colProductionOrder.ReadOnly = true;
            this.colProductionOrder.Width = 150;
            this.colWarehouse.DataPropertyName = "KhoNhap";
            this.colWarehouse.HeaderText = "Kho nhập";
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.ReadOnly = true;
            this.colWarehouse.Width = 90;
            this.colPostion.DataPropertyName = "ViTriNhap";
            this.colPostion.HeaderText = "Vị trí nhập";
            this.colPostion.Name = "colPostion";
            this.colPostion.ReadOnly = true;
            this.colPostion.Visible = false;
            this.colPostion.Width = 105;
            this.colProductionCode.DataPropertyName = "MaThanhPham";
            this.colProductionCode.HeaderText = "Thành phẩm";
            this.colProductionCode.Name = "colProductionCode";
            this.colProductionCode.ReadOnly = true;
            this.colProductionCode.Width = 110;
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductName.DataPropertyName = "TenThanhPham";
            this.colProductName.HeaderText = "Tên thành phẩm";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colPONumber.DataPropertyName = "PO_NUMBER";
            this.colPONumber.HeaderText = "Số PO";
            this.colPONumber.Name = "colPONumber";
            this.colPONumber.ReadOnly = true;
            this.colPONumber.Width = 105;
            this.colQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.colQuantity.HeaderText = "Số kg kế hoạch";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Visible = false;
            this.colQuantity.Width = 105;
            this.colQuantityFinished.DataPropertyName = "QuantityFinished";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQuantityFinished.DefaultCellStyle = dataGridViewCellStyle6;
            this.colQuantityFinished.HeaderText = "Số kg đã thực hiện";
            this.colQuantityFinished.Name = "colQuantityFinished";
            this.colQuantityFinished.ReadOnly = true;
            this.colQuantityFinished.Visible = false;
            this.colQuantityFinished.Width = 105;
            this.colFinishedPackage.DataPropertyName = "FinishedPackage";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colFinishedPackage.DefaultCellStyle = dataGridViewCellStyle7;
            this.colFinishedPackage.HeaderText = "Số kiện đã thực hiện";
            this.colFinishedPackage.Name = "colFinishedPackage";
            this.colFinishedPackage.ReadOnly = true;
            this.colFinishedPackage.Visible = false;
            this.colFinishedPackage.Width = 105;
            this.colM_Created.DataPropertyName = "Created";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy HH:mm";
            this.colM_Created.DefaultCellStyle = dataGridViewCellStyle8;
            this.colM_Created.HeaderText = "Ngày tạo";
            this.colM_Created.Name = "colM_Created";
            this.colM_Created.ReadOnly = true;
            this.colM_Created.Width = 130;
            this.colM_CreatedBy.DataPropertyName = "CreatedBy";
            this.colM_CreatedBy.HeaderText = "Người tạo";
            this.colM_CreatedBy.Name = "colM_CreatedBy";
            this.colM_CreatedBy.ReadOnly = true;
            this.colM_CreatedBy.Width = 95;
            this.colM_Modified.DataPropertyName = "Modified";
            dataGridViewCellStyle9.Format = "dd/MM/yyyy HH:mm";
            this.colM_Modified.DefaultCellStyle = dataGridViewCellStyle9;
            this.colM_Modified.HeaderText = "Ngày sửa";
            this.colM_Modified.Name = "colM_Modified";
            this.colM_Modified.ReadOnly = true;
            this.colM_Modified.Visible = false;
            this.colM_Modified.Width = 130;
            this.colM_ModifiedBy.DataPropertyName = "ModifiedBy";
            this.colM_ModifiedBy.HeaderText = "Người sửa";
            this.colM_ModifiedBy.Name = "colM_ModifiedBy";
            this.colM_ModifiedBy.ReadOnly = true;
            this.colM_ModifiedBy.Visible = false;
            this.colM_ModifiedBy.Width = 95;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(0, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "LỆNH SẢN XUẤT CẦN THỰC HIỆN";
            this.dgWIPDetail.AllowUserToAddRows = false;
            this.dgWIPDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgWIPDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWIPDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgWIPDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWIPDetail.Columns.AddRange(this.colWOD_Status, this.colWOD_CreatedDate, this.colWOD_SL_KeHoach, this.colWOD_SL_Receipted, this.colWOD_Tolerance, this.colWOD_SoCuonThucTe, this.colWOD_SoKgThucTe, this.colWOD_SoMet, this.colWOD_TransactionDate);
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWIPDetail.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgWIPDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgWIPDetail.Location = new System.Drawing.Point(0, 0);
            this.dgWIPDetail.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.dgWIPDetail.MultiSelect = false;
            this.dgWIPDetail.Name = "dgWIPDetail";
            this.dgWIPDetail.ReadOnly = true;
            this.dgWIPDetail.RowHeadersWidth = 25;
            this.dgWIPDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgWIPDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWIPDetail.Size = new System.Drawing.Size(1290, 318);
            this.dgWIPDetail.TabIndex = 17;
            this.dgWIPDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgWIPDetail_CellContentClick);
            this.dgWIPDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgWIPDetail_CellDoubleClick);
            this.dgWIPDetail.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(dgWIPDetail_CellMouseEnter);
            this.dgWIPDetail.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(dgWIPDetail_CellMouseLeave);
            this.dgWIPDetail.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(dgWIPDetail_CellPainting);
            this.dgWIPDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(dgWIPDetail_KeyDown);
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.splitContainer1.Location = new System.Drawing.Point(4, 82);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Panel1.Controls.Add(this.dgWIP);
            this.splitContainer1.Panel2.Controls.Add(this.dgWIPDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1290, 662);
            this.splitContainer1.SplitterDistance = 338;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 20;
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4f));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSearch, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1135, 53);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(159, 22);
            this.tableLayoutPanel1.TabIndex = 18;
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BackgroundImage = SIAM.QRCode.Factory.Properties.Resources.search_icon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(136, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(22, 22);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(btnSearch_Click);
            this.tbSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(132, 22);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tbSearch_KeyPress);
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 120;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WO_DATE";
            dataGridViewCellStyle13.Format = "dd/MM/yyyy";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WO_NUMBER";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lệnh SX";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "KhoNhap";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kho nhập";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ViTriNhap";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vị trí nhập";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 105;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaThanhPham";
            this.dataGridViewTextBoxColumn6.HeaderText = "Thành phẩm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 110;
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TenThanhPham";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tên thành phẩm";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PO_NUMBER";
            this.dataGridViewTextBoxColumn8.HeaderText = "Số PO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 105;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Quantity";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn9.HeaderText = "Số kg kế hoạch";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 105;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "QuantityFinished";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn10.HeaderText = "Số kg đã thực hiện";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 105;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FinishedPackage";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn11.HeaderText = "Số kiện đã thực hiện";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 105;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Created";
            dataGridViewCellStyle17.Format = "dd/MM/yyyy HH:mm";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn12.HeaderText = "Ngày tạo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 130;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "CreatedBy";
            this.dataGridViewTextBoxColumn13.HeaderText = "Người tạo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 95;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Modified";
            dataGridViewCellStyle18.Format = "dd/MM/yyyy HH:mm";
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn14.HeaderText = "Ngày sửa";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 130;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ModifiedBy";
            this.dataGridViewTextBoxColumn15.HeaderText = "Người sửa";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            this.dataGridViewTextBoxColumn15.Width = 95;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn16.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.Width = 120;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Created";
            dataGridViewCellStyle19.Format = "dd/MM/yyyy HH:mm";
            this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn17.HeaderText = "Ngày giờ";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 130;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "SL_KeHoach";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn18.HeaderText = "Số lượng kế hoạch";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 160;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "SL_Receipted";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn19.HeaderText = "Số lượng đã thực hiện";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 170;
            this.dataGridViewTextBoxColumn20.DataPropertyName = "TOLERANCE_VALUE";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "dd/MM/yyyy HH:mm";
            this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn20.HeaderText = "Tolerance";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 105;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "SoCuonThucTe";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn21.HeaderText = "Tổng số kiện";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 120;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "SoKgThucTe";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn22.HeaderText = "Tổng số kg";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 160;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "SoMet";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn23.HeaderText = "Tổng số mét";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 160;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "TransactionDate";
            dataGridViewCellStyle26.Format = "dd/MM/yyyy HH:mm";
            this.dataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn24.HeaderText = "Ngày đóng lệnh";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 130;
            this.btnLoadERP.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoadERP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadERP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnLoadERP.ForeColor = System.Drawing.Color.White;
            this.btnLoadERP.Location = new System.Drawing.Point(877, 53);
            this.btnLoadERP.Name = "btnLoadERP";
            this.btnLoadERP.Size = new System.Drawing.Size(85, 23);
            this.btnLoadERP.TabIndex = 12;
            this.btnLoadERP.Text = "Load ERP";
            this.btnLoadERP.UseMnemonic = false;
            this.btnLoadERP.UseVisualStyleBackColor = false;
            this.btnLoadERP.Click += new System.EventHandler(btnLoad_Click);
            this.btnLoadStatus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoadStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnLoadStatus.ForeColor = System.Drawing.Color.White;
            this.btnLoadStatus.Location = new System.Drawing.Point(966, 53);
            this.btnLoadStatus.Name = "btnLoadStatus";
            this.btnLoadStatus.Size = new System.Drawing.Size(128, 23);
            this.btnLoadStatus.TabIndex = 13;
            this.btnLoadStatus.Text = "Update tình trạng";
            this.btnLoadStatus.UseMnemonic = false;
            this.btnLoadStatus.UseVisualStyleBackColor = false;
            this.btnLoadStatus.Click += new System.EventHandler(btnLoadStatus_Click);
            this.ccbStatus.CheckOnClick = true;
            this.ccbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ccbStatus.DropDownHeight = 1;
            this.ccbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.ccbStatus.FormattingEnabled = true;
            this.ccbStatus.IntegralHeight = false;
            this.ccbStatus.ItemHeight = 16;
            this.ccbStatus.Location = new System.Drawing.Point(624, 54);
            this.ccbStatus.Name = "ccbStatus";
            this.ccbStatus.Size = new System.Drawing.Size(158, 22);
            this.ccbStatus.TabIndex = 10;
            this.ccbStatus.ValueSeparator = ", ";
            this.btnLoad.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(788, 53);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(85, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseMnemonic = false;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(btnLoad_Click);
            this.btnLoadDefault.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLoadDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.btnLoadDefault.ForeColor = System.Drawing.Color.White;
            this.btnLoadDefault.Location = new System.Drawing.Point(737, 6);
            this.btnLoadDefault.Name = "btnLoadDefault";
            this.btnLoadDefault.Size = new System.Drawing.Size(162, 22);
            this.btnLoadDefault.TabIndex = 7;
            this.btnLoadDefault.Text = "Load dữ liệu mặc định";
            this.btnLoadDefault.UseVisualStyleBackColor = false;
            this.btnLoadDefault.Visible = false;
            this.colWOD_Status.DataPropertyName = "Status";
            this.colWOD_Status.HeaderText = "Tình trạng";
            this.colWOD_Status.Name = "colWOD_Status";
            this.colWOD_Status.ReadOnly = true;
            this.colWOD_Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWOD_Status.Width = 120;
            this.colWOD_CreatedDate.DataPropertyName = "Created";
            dataGridViewCellStyle27.Format = "dd/MM/yyyy HH:mm";
            this.colWOD_CreatedDate.DefaultCellStyle = dataGridViewCellStyle27;
            this.colWOD_CreatedDate.HeaderText = "Ngày giờ";
            this.colWOD_CreatedDate.Name = "colWOD_CreatedDate";
            this.colWOD_CreatedDate.ReadOnly = true;
            this.colWOD_CreatedDate.Width = 130;
            this.colWOD_SL_KeHoach.DataPropertyName = "SL_KeHoach";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colWOD_SL_KeHoach.DefaultCellStyle = dataGridViewCellStyle28;
            this.colWOD_SL_KeHoach.HeaderText = "Số lượng kế hoạch";
            this.colWOD_SL_KeHoach.Name = "colWOD_SL_KeHoach";
            this.colWOD_SL_KeHoach.ReadOnly = true;
            this.colWOD_SL_KeHoach.Width = 160;
            this.colWOD_SL_Receipted.DataPropertyName = "SL_Receipted";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colWOD_SL_Receipted.DefaultCellStyle = dataGridViewCellStyle29;
            this.colWOD_SL_Receipted.HeaderText = "Số lượng đã thực hiện";
            this.colWOD_SL_Receipted.Name = "colWOD_SL_Receipted";
            this.colWOD_SL_Receipted.ReadOnly = true;
            this.colWOD_SL_Receipted.Width = 170;
            this.colWOD_Tolerance.DataPropertyName = "TOLERANCE_VALUE";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Format = "dd/MM/yyyy HH:mm";
            this.colWOD_Tolerance.DefaultCellStyle = dataGridViewCellStyle30;
            this.colWOD_Tolerance.HeaderText = "Tolerance";
            this.colWOD_Tolerance.Name = "colWOD_Tolerance";
            this.colWOD_Tolerance.ReadOnly = true;
            this.colWOD_Tolerance.Width = 105;
            this.colWOD_SoCuonThucTe.DataPropertyName = "SoCuonThucTe";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colWOD_SoCuonThucTe.DefaultCellStyle = dataGridViewCellStyle31;
            this.colWOD_SoCuonThucTe.HeaderText = "Tổng số kiện";
            this.colWOD_SoCuonThucTe.Name = "colWOD_SoCuonThucTe";
            this.colWOD_SoCuonThucTe.ReadOnly = true;
            this.colWOD_SoCuonThucTe.Width = 120;
            this.colWOD_SoKgThucTe.DataPropertyName = "SoKgThucTe";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colWOD_SoKgThucTe.DefaultCellStyle = dataGridViewCellStyle32;
            this.colWOD_SoKgThucTe.HeaderText = "Tổng số kg";
            this.colWOD_SoKgThucTe.Name = "colWOD_SoKgThucTe";
            this.colWOD_SoKgThucTe.ReadOnly = true;
            this.colWOD_SoKgThucTe.Width = 120;
            this.colWOD_SoMet.DataPropertyName = "TongSoMet";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colWOD_SoMet.DefaultCellStyle = dataGridViewCellStyle33;
            this.colWOD_SoMet.HeaderText = "Tổng số mét";
            this.colWOD_SoMet.Name = "colWOD_SoMet";
            this.colWOD_SoMet.ReadOnly = true;
            this.colWOD_SoMet.Width = 120;
            this.colWOD_TransactionDate.DataPropertyName = "TransactionDate";
            dataGridViewCellStyle34.Format = "dd/MM/yyyy HH:mm";
            this.colWOD_TransactionDate.DefaultCellStyle = dataGridViewCellStyle34;
            this.colWOD_TransactionDate.HeaderText = "Ngày đóng lệnh";
            this.colWOD_TransactionDate.Name = "colWOD_TransactionDate";
            this.colWOD_TransactionDate.ReadOnly = true;
            this.colWOD_TransactionDate.Width = 130;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            base.Controls.Add(this.btnLoadERP);
            base.Controls.Add(this.btnLoadStatus);
            base.Controls.Add(this.tableLayoutPanel1);
            base.Controls.Add(this.ccbStatus);
            base.Controls.Add(this.splitContainer1);
            base.Controls.Add(this.btnLoad);
            base.Controls.Add(this.btnLoadDefault);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.tbWONumber);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.dpToDate);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.dpFromDate);
            base.Controls.Add(this.cbFactory);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Name = "WorkOrderView";
            base.Size = new System.Drawing.Size(1300, 744);
            ((System.ComponentModel.ISupportInitialize)this.dgWIP).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgWIPDetail).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }
        private Label label1;

        private ComboBox cbFactory;

        private DateTimePicker dpFromDate;

        private Label label3;

        private DateTimePicker dpToDate;

        private Label label4;

        private Label label5;

        private TextBox tbWONumber;

        private Label label6;

        private Button btnLoadDefault;

        private Button btnLoad;

        private DataGridView dgWIP;

        private Label label2;

        private DataGridView dgWIPDetail;

        private SplitContainer splitContainer1;

        private CheckedComboBox ccbStatus;

        private TableLayoutPanel tableLayoutPanel1;

        private TextBox tbSearch;

        private Button btnSearch;

        private Button btnLoadStatus;

        private DataGridViewTextBoxColumn colStatus;

        private DataGridViewTextBoxColumn colDate;

        private DataGridViewTextBoxColumn colProductionOrder;

        private DataGridViewTextBoxColumn colWarehouse;

        private DataGridViewTextBoxColumn colPostion;

        private DataGridViewTextBoxColumn colProductionCode;

        private DataGridViewTextBoxColumn colProductName;

        private DataGridViewTextBoxColumn colPONumber;

        private DataGridViewTextBoxColumn colQuantity;

        private DataGridViewTextBoxColumn colQuantityFinished;

        private DataGridViewTextBoxColumn colFinishedPackage;

        private DataGridViewTextBoxColumn colM_Created;

        private DataGridViewTextBoxColumn colM_CreatedBy;

        private DataGridViewTextBoxColumn colM_Modified;

        private DataGridViewTextBoxColumn colM_ModifiedBy;

        private Button btnLoadERP;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

        private DataGridViewTextBoxColumn colWOD_Status;

        private DataGridViewTextBoxColumn colWOD_CreatedDate;

        private DataGridViewTextBoxColumn colWOD_SL_KeHoach;

        private DataGridViewTextBoxColumn colWOD_SL_Receipted;

        private DataGridViewTextBoxColumn colWOD_Tolerance;

        private DataGridViewTextBoxColumn colWOD_SoCuonThucTe;

        private DataGridViewTextBoxColumn colWOD_SoKgThucTe;

        private DataGridViewTextBoxColumn colWOD_SoMet;

        private DataGridViewTextBoxColumn colWOD_TransactionDate;
        #endregion
    }
}
