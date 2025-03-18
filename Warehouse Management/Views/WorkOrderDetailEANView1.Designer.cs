using System.Windows.Forms;

namespace Warehouse_Management.Views
{
    partial class WorkOrderDetailEANView1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSavePrintAuto_Cuon = new System.Windows.Forms.CheckBox();
            this.btnCloseOrder = new Button();
            this.btnCancel = new Button();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.tbOrderCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportExcel = new Button();
            this.btnReturnKien = new Button();
            this.btnDeleteKien = new Button();
            this.btnClosePackage = new Button();
            this.btnOpenPackage = new Button();
            this.btnPrintKien = new Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dgWIPItem = new System.Windows.Forms.DataGridView();
            this.colWItem_MaThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWItem_TenThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWItem_SoKg_KeHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWItem_SoKg_ThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPONumber = new System.Windows.Forms.TextBox();
            this.tbSoKgKeHoach = new System.Windows.Forms.TextBox();
            this.lblSoKgKeHoach = new System.Windows.Forms.Label();
            this.tbSoKgCanThucHien = new System.Windows.Forms.TextBox();
            this.lblSoKgCanThucHien = new System.Windows.Forms.Label();
            this.tbTolerance = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.tbMaThanhPham = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTenThanhPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKien_TotalInner = new System.Windows.Forms.Label();
            this.lblKien_TotalInner_Text = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblKien_TotalOuter = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInnerPrint = new Button();
            this.btnInnerClose = new Button();
            this.btnOuterDelete = new Button();
            this.btnOuterClose = new Button();
            this.btnInnerDelete = new Button();
            this.btnOuterPrint = new Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalKien = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblKien_NoInner_Text = new System.Windows.Forms.Label();
            this.lblKien_NoInner = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblKien_TotalKgThucTe = new System.Windows.Forms.Label();
            this.dgKien = new System.Windows.Forms.DataGridView();
            this.colCP_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCP_MaKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCP_SoKgTruBaoBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCP_SoKg_BaoBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCP_NgayIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCP_Deleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCP_InnerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCP_Outer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label23 = new System.Windows.Forms.Label();
            this.lblTitle_KienInfo = new System.Windows.Forms.Label();
            this.tlpPackageCurrent = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbWeighReading = new System.Windows.Forms.TextBox();
            this.tbCPSoKienSX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCPMaKien = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbCPSoKgBaoBi = new System.Windows.Forms.TextBox();
            this.tbCPSoKgTruBaoBi = new System.Windows.Forms.TextBox();
            this.lblKien_SoKgTinh = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbCPSoKgChuan = new System.Windows.Forms.TextBox();
            this.tbCPSoKgThucTe = new System.Windows.Forms.TextBox();
            this.lblKien_SoKgGop = new System.Windows.Forms.Label();
            this.lblWeighReading = new System.Windows.Forms.Label();
            this.tbCPSoCuonChuan = new System.Windows.Forms.TextBox();
            this.lblKien_SoCuonChuan = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbCP_SpecInner = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tbCP_EAN = new System.Windows.Forms.TextBox();
            this.tbCP_SpecOuter = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWIPItem)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKien)).BeginInit();
            this.tlpPackageCurrent.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 9;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label31, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkSavePrintAuto_Cuon, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCloseOrder, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCancel, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpTransactionDate, 4, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1582, 32);
            this.tableLayoutPanel3.TabIndex = 30;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(1151, 6);
            this.label31.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(102, 16);
            this.label31.TabIndex = 16;
            this.label31.Text = "&Ngày đóng lệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(0, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "LỆNH SẢN XUẤT - EAN";
            // 
            // chkSavePrintAuto_Cuon
            // 
            this.chkSavePrintAuto_Cuon.AutoSize = true;
            this.chkSavePrintAuto_Cuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSavePrintAuto_Cuon.Location = new System.Drawing.Point(261, 5);
            this.chkSavePrintAuto_Cuon.Margin = new System.Windows.Forms.Padding(10, 5, 3, 3);
            this.chkSavePrintAuto_Cuon.Name = "chkSavePrintAuto_Cuon";
            this.chkSavePrintAuto_Cuon.Size = new System.Drawing.Size(287, 20);
            this.chkSavePrintAuto_Cuon.TabIndex = 38;
            this.chkSavePrintAuto_Cuon.TabStop = false;
            this.chkSavePrintAuto_Cuon.Text = "Tự động lưu và in nhãn cuộn sau khi đọc cân";
            this.chkSavePrintAuto_Cuon.UseVisualStyleBackColor = true;
            this.chkSavePrintAuto_Cuon.Visible = false;
            //this.chkSavePrintAuto_Cuon.CheckedChanged += new System.EventHandler(this.chkSavePrintAuto_Cuon_CheckedChanged);
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCloseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseOrder.ForeColor = System.Drawing.Color.White;
            this.btnCloseOrder.Location = new System.Drawing.Point(1400, 3);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(88, 23);
            this.btnCloseOrder.TabIndex = 18;
            this.btnCloseOrder.Text = "Hoàn tất";
            this.btnCloseOrder.UseVisualStyleBackColor = false;
            //this.btnCloseOrder.Click += new System.EventHandler(this.btnCloseOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1494, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            //this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTransactionDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate.Location = new System.Drawing.Point(1259, 3);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(135, 22);
            this.dtpTransactionDate.TabIndex = 17;
            // 
            // tbOrderCode
            // 
            this.tbOrderCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderCode.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.SetColumnSpan(this.tbOrderCode, 3);
            this.tbOrderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrderCode.Location = new System.Drawing.Point(0, 16);
            this.tbOrderCode.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbOrderCode.Name = "tbOrderCode";
            this.tbOrderCode.ReadOnly = true;
            this.tbOrderCode.Size = new System.Drawing.Size(588, 22);
            this.tbOrderCode.TabIndex = 12;
            this.tbOrderCode.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 9;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.btnExportExcel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnReturnKien, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDeleteKien, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnClosePackage, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnOpenPackage, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPrintKien, 8, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 236);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(791, 26);
            this.tableLayoutPanel4.TabIndex = 32;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(102, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(96, 23);
            this.btnExportExcel.TabIndex = 12;
            this.btnExportExcel.Text = "Xuất excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            //this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnReturnKien
            // 
            this.btnReturnKien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturnKien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturnKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnKien.ForeColor = System.Drawing.Color.White;
            this.btnReturnKien.Location = new System.Drawing.Point(0, 3);
            this.btnReturnKien.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnReturnKien.Name = "btnReturnKien";
            this.btnReturnKien.Size = new System.Drawing.Size(96, 23);
            this.btnReturnKien.TabIndex = 11;
            this.btnReturnKien.Text = "Return kiện";
            this.btnReturnKien.UseVisualStyleBackColor = false;
            //this.btnReturnKien.Click += new System.EventHandler(this.btnReturnKien_Click);
            // 
            // btnDeleteKien
            // 
            this.btnDeleteKien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteKien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKien.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteKien.Location = new System.Drawing.Point(204, 3);
            this.btnDeleteKien.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnDeleteKien.Name = "btnDeleteKien";
            this.btnDeleteKien.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteKien.TabIndex = 10;
            this.btnDeleteKien.Text = "Xóa kiện";
            this.btnDeleteKien.UseVisualStyleBackColor = false;
            //this.btnDeleteKien.Click += new System.EventHandler(this.btnDeleteKien_Click);
            // 
            // btnClosePackage
            // 
            this.btnClosePackage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClosePackage.Enabled = false;
            this.btnClosePackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClosePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePackage.ForeColor = System.Drawing.Color.White;
            this.btnClosePackage.Location = new System.Drawing.Point(609, 3);
            this.btnClosePackage.Name = "btnClosePackage";
            this.btnClosePackage.Size = new System.Drawing.Size(88, 23);
            this.btnClosePackage.TabIndex = 6;
            this.btnClosePackage.Text = "Dừng cân";
            this.btnClosePackage.UseVisualStyleBackColor = false;
            //this.btnClosePackage.Click += new System.EventHandler(this.btnClosePackage_Click);
            // 
            // btnOpenPackage
            // 
            this.btnOpenPackage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOpenPackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPackage.ForeColor = System.Drawing.Color.White;
            this.btnOpenPackage.Location = new System.Drawing.Point(515, 3);
            this.btnOpenPackage.Name = "btnOpenPackage";
            this.btnOpenPackage.Size = new System.Drawing.Size(88, 23);
            this.btnOpenPackage.TabIndex = 5;
            this.btnOpenPackage.Text = "Mở cân";
            this.btnOpenPackage.UseVisualStyleBackColor = false;
            //this.btnOpenPackage.Click += new System.EventHandler(this.btnOpenPackage_Click);
            // 
            // btnPrintKien
            // 
            this.btnPrintKien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrintKien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrintKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintKien.ForeColor = System.Drawing.Color.White;
            this.btnPrintKien.Location = new System.Drawing.Point(703, 3);
            this.btnPrintKien.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnPrintKien.Name = "btnPrintKien";
            this.btnPrintKien.Size = new System.Drawing.Size(88, 23);
            this.btnPrintKien.TabIndex = 7;
            this.btnPrintKien.Text = "In kiện";
            this.btnPrintKien.UseVisualStyleBackColor = false;
            //this.btnPrintKien.Click += new System.EventHandler(this.btnPrintKien_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 362);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Kiện đã thực hiện";
            // 
            // dgWIPItem
            // 
            this.dgWIPItem.AllowUserToAddRows = false;
            this.dgWIPItem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgWIPItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgWIPItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWIPItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgWIPItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWIPItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWItem_MaThanhPhan,
            this.colWItem_TenThanhPhan,
            this.colWItem_SoKg_KeHoach,
            this.colWItem_SoKg_ThucTe});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWIPItem.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgWIPItem.Location = new System.Drawing.Point(797, 62);
            this.dgWIPItem.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.dgWIPItem.MultiSelect = false;
            this.dgWIPItem.Name = "dgWIPItem";
            this.dgWIPItem.ReadOnly = true;
            this.dgWIPItem.RowHeadersWidth = 25;
            this.dgWIPItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgWIPItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWIPItem.Size = new System.Drawing.Size(785, 144);
            this.dgWIPItem.TabIndex = 15;
            // 
            // colWItem_MaThanhPhan
            // 
            this.colWItem_MaThanhPhan.DataPropertyName = "MaThanhPhan";
            this.colWItem_MaThanhPhan.HeaderText = "Mã bán thành phẩm";
            this.colWItem_MaThanhPhan.Name = "colWItem_MaThanhPhan";
            this.colWItem_MaThanhPhan.ReadOnly = true;
            this.colWItem_MaThanhPhan.Width = 130;
            // 
            // colWItem_TenThanhPhan
            // 
            this.colWItem_TenThanhPhan.DataPropertyName = "TenThanhPhan";
            this.colWItem_TenThanhPhan.HeaderText = "Tên bán thành phẩm";
            this.colWItem_TenThanhPhan.Name = "colWItem_TenThanhPhan";
            this.colWItem_TenThanhPhan.ReadOnly = true;
            this.colWItem_TenThanhPhan.Width = 360;
            // 
            // colWItem_SoKg_KeHoach
            // 
            this.colWItem_SoKg_KeHoach.DataPropertyName = "SoKg_KeHoach";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colWItem_SoKg_KeHoach.DefaultCellStyle = dataGridViewCellStyle3;
            this.colWItem_SoKg_KeHoach.HeaderText = "Số kg kế hoạch";
            this.colWItem_SoKg_KeHoach.Name = "colWItem_SoKg_KeHoach";
            this.colWItem_SoKg_KeHoach.ReadOnly = true;
            this.colWItem_SoKg_KeHoach.Width = 85;
            // 
            // colWItem_SoKg_ThucTe
            // 
            this.colWItem_SoKg_ThucTe.DataPropertyName = "SoKg_ThucTe";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.colWItem_SoKg_ThucTe.DefaultCellStyle = dataGridViewCellStyle4;
            this.colWItem_SoKg_ThucTe.HeaderText = "Tổng số kg";
            this.colWItem_SoKg_ThucTe.Name = "colWItem_SoKg_ThucTe";
            this.colWItem_SoKg_ThucTe.ReadOnly = true;
            this.colWItem_SoKg_ThucTe.Width = 85;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbPONumber, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbSoKgKeHoach, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblSoKgKeHoach, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbSoKgCanThucHien, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblSoKgCanThucHien, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbTolerance, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label28, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbOrderCode, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label30, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbUnit, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbMaThanhPham, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbTenThanhPham, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Số PO";
            // 
            // tbPONumber
            // 
            this.tbPONumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPONumber.Location = new System.Drawing.Point(594, 16);
            this.tbPONumber.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.tbPONumber.Name = "tbPONumber";
            this.tbPONumber.ReadOnly = true;
            this.tbPONumber.Size = new System.Drawing.Size(194, 22);
            this.tbPONumber.TabIndex = 28;
            this.tbPONumber.TabStop = false;
            // 
            // tbSoKgKeHoach
            // 
            this.tbSoKgKeHoach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSoKgKeHoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoKgKeHoach.Location = new System.Drawing.Point(0, 108);
            this.tbSoKgKeHoach.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbSoKgKeHoach.Name = "tbSoKgKeHoach";
            this.tbSoKgKeHoach.ReadOnly = true;
            this.tbSoKgKeHoach.Size = new System.Drawing.Size(194, 22);
            this.tbSoKgKeHoach.TabIndex = 20;
            this.tbSoKgKeHoach.TabStop = false;
            // 
            // lblSoKgKeHoach
            // 
            this.lblSoKgKeHoach.AutoSize = true;
            this.lblSoKgKeHoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoKgKeHoach.Location = new System.Drawing.Point(0, 92);
            this.lblSoKgKeHoach.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblSoKgKeHoach.Name = "lblSoKgKeHoach";
            this.lblSoKgKeHoach.Size = new System.Drawing.Size(118, 16);
            this.lblSoKgKeHoach.TabIndex = 14;
            this.lblSoKgKeHoach.Text = "Số lượng kế hoạch";
            // 
            // tbSoKgCanThucHien
            // 
            this.tbSoKgCanThucHien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSoKgCanThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoKgCanThucHien.Location = new System.Drawing.Point(200, 108);
            this.tbSoKgCanThucHien.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbSoKgCanThucHien.Name = "tbSoKgCanThucHien";
            this.tbSoKgCanThucHien.ReadOnly = true;
            this.tbSoKgCanThucHien.Size = new System.Drawing.Size(191, 22);
            this.tbSoKgCanThucHien.TabIndex = 24;
            this.tbSoKgCanThucHien.TabStop = false;
            // 
            // lblSoKgCanThucHien
            // 
            this.lblSoKgCanThucHien.AutoSize = true;
            this.lblSoKgCanThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoKgCanThucHien.Location = new System.Drawing.Point(197, 92);
            this.lblSoKgCanThucHien.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblSoKgCanThucHien.Name = "lblSoKgCanThucHien";
            this.lblSoKgCanThucHien.Size = new System.Drawing.Size(140, 16);
            this.lblSoKgCanThucHien.TabIndex = 15;
            this.lblSoKgCanThucHien.Text = "Số lượng cần thực hiện";
            // 
            // tbTolerance
            // 
            this.tbTolerance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTolerance.Location = new System.Drawing.Point(397, 108);
            this.tbTolerance.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbTolerance.Name = "tbTolerance";
            this.tbTolerance.ReadOnly = true;
            this.tbTolerance.Size = new System.Drawing.Size(191, 22);
            this.tbTolerance.TabIndex = 25;
            this.tbTolerance.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(394, 92);
            this.label28.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 16);
            this.label28.TabIndex = 23;
            this.label28.Text = "Tolerance";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(591, 92);
            this.label30.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 16);
            this.label30.TabIndex = 26;
            this.label30.Text = "Đơn vị tính";
            // 
            // tbUnit
            // 
            this.tbUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnit.Location = new System.Drawing.Point(594, 108);
            this.tbUnit.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.ReadOnly = true;
            this.tbUnit.Size = new System.Drawing.Size(194, 22);
            this.tbUnit.TabIndex = 21;
            this.tbUnit.TabStop = false;
            // 
            // tbMaThanhPham
            // 
            this.tbMaThanhPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaThanhPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaThanhPham.Location = new System.Drawing.Point(0, 62);
            this.tbMaThanhPham.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbMaThanhPham.Name = "tbMaThanhPham";
            this.tbMaThanhPham.ReadOnly = true;
            this.tbMaThanhPham.Size = new System.Drawing.Size(194, 22);
            this.tbMaThanhPham.TabIndex = 19;
            this.tbMaThanhPham.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mã thành phẩm";
            // 
            // tbTenThanhPham
            // 
            this.tbTenThanhPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.tbTenThanhPham, 3);
            this.tbTenThanhPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenThanhPham.Location = new System.Drawing.Point(200, 62);
            this.tbTenThanhPham.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.tbTenThanhPham.Name = "tbTenThanhPham";
            this.tbTenThanhPham.ReadOnly = true;
            this.tbTenThanhPham.Size = new System.Drawing.Size(588, 22);
            this.tbTenThanhPham.TabIndex = 22;
            this.tbTenThanhPham.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 3);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tên thành phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Lệnh sản xuất";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(793, 214);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 5, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Thông tin inner/outer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgWIPItem, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgKien, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTitle_KienInfo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tlpPackageCurrent, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1582, 744);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 7;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.Controls.Add(this.lblKien_TotalInner, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.lblKien_TotalInner_Text, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label36, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.lblKien_TotalOuter, 4, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(794, 384);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(785, 18);
            this.tableLayoutPanel10.TabIndex = 36;
            // 
            // lblKien_TotalInner
            // 
            this.lblKien_TotalInner.AutoSize = true;
            this.lblKien_TotalInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKien_TotalInner.ForeColor = System.Drawing.Color.Red;
            this.lblKien_TotalInner.Location = new System.Drawing.Point(83, 0);
            this.lblKien_TotalInner.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblKien_TotalInner.Name = "lblKien_TotalInner";
            this.lblKien_TotalInner.Size = new System.Drawing.Size(19, 18);
            this.lblKien_TotalInner.TabIndex = 4;
            this.lblKien_TotalInner.Text = "0";
            // 
            // lblKien_TotalInner_Text
            // 
            this.lblKien_TotalInner_Text.AutoSize = true;
            this.lblKien_TotalInner_Text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKien_TotalInner_Text.Location = new System.Drawing.Point(3, 2);
            this.lblKien_TotalInner_Text.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.lblKien_TotalInner_Text.Name = "lblKien_TotalInner_Text";
            this.lblKien_TotalInner_Text.Size = new System.Drawing.Size(80, 16);
            this.lblKien_TotalInner_Text.TabIndex = 3;
            this.lblKien_TotalInner_Text.Text = "Tổng inner:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(117, 2);
            this.label36.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(80, 16);
            this.label36.TabIndex = 1;
            this.label36.Text = "Tổng outer:";
            // 
            // lblKien_TotalOuter
            // 
            this.lblKien_TotalOuter.AutoSize = true;
            this.lblKien_TotalOuter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKien_TotalOuter.ForeColor = System.Drawing.Color.Red;
            this.lblKien_TotalOuter.Location = new System.Drawing.Point(197, 0);
            this.lblKien_TotalOuter.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblKien_TotalOuter.Name = "lblKien_TotalOuter";
            this.lblKien_TotalOuter.Size = new System.Drawing.Size(19, 18);
            this.lblKien_TotalOuter.TabIndex = 2;
            this.lblKien_TotalOuter.Text = "0";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 9;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.btnInnerPrint, 5, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnInnerClose, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnOuterDelete, 6, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnOuterClose, 7, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnInnerDelete, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnOuterPrint, 8, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(791, 236);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(791, 26);
            this.tableLayoutPanel9.TabIndex = 33;
            // 
            // btnInnerPrint
            // 
            this.btnInnerPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInnerPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInnerPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInnerPrint.ForeColor = System.Drawing.Color.White;
            this.btnInnerPrint.Location = new System.Drawing.Point(424, 3);
            this.btnInnerPrint.Name = "btnInnerPrint";
            this.btnInnerPrint.Size = new System.Drawing.Size(88, 23);
            this.btnInnerPrint.TabIndex = 13;
            this.btnInnerPrint.Text = "In inner";
            this.btnInnerPrint.UseVisualStyleBackColor = false;
            //this.btnInnerPrint.Click += new System.EventHandler(this.btnInnerPrint_Click);
            // 
            // btnInnerClose
            // 
            this.btnInnerClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInnerClose.Enabled = false;
            this.btnInnerClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInnerClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInnerClose.ForeColor = System.Drawing.Color.White;
            this.btnInnerClose.Location = new System.Drawing.Point(330, 3);
            this.btnInnerClose.Name = "btnInnerClose";
            this.btnInnerClose.Size = new System.Drawing.Size(88, 23);
            this.btnInnerClose.TabIndex = 12;
            this.btnInnerClose.Text = "Đóng inner";
            this.btnInnerClose.UseVisualStyleBackColor = false;
            //this.btnInnerClose.Click += new System.EventHandler(this.btnInnerClose_Click);
            // 
            // btnOuterDelete
            // 
            this.btnOuterDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOuterDelete.Enabled = false;
            this.btnOuterDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOuterDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuterDelete.ForeColor = System.Drawing.Color.Red;
            this.btnOuterDelete.Location = new System.Drawing.Point(518, 3);
            this.btnOuterDelete.Name = "btnOuterDelete";
            this.btnOuterDelete.Size = new System.Drawing.Size(88, 23);
            this.btnOuterDelete.TabIndex = 14;
            this.btnOuterDelete.Text = "Xóa outer";
            this.btnOuterDelete.UseVisualStyleBackColor = false;
            //this.btnOuterDelete.Click += new System.EventHandler(this.btnOuterDelete_Click);
            // 
            // btnOuterClose
            // 
            this.btnOuterClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOuterClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOuterClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuterClose.ForeColor = System.Drawing.Color.White;
            this.btnOuterClose.Location = new System.Drawing.Point(612, 3);
            this.btnOuterClose.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnOuterClose.Name = "btnOuterClose";
            this.btnOuterClose.Size = new System.Drawing.Size(88, 23);
            this.btnOuterClose.TabIndex = 15;
            this.btnOuterClose.Text = "Đóng outer";
            this.btnOuterClose.UseVisualStyleBackColor = false;
            //this.btnOuterClose.Click += new System.EventHandler(this.btnOuterClose_Click);
            // 
            // btnInnerDelete
            // 
            this.btnInnerDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInnerDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInnerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInnerDelete.ForeColor = System.Drawing.Color.Red;
            this.btnInnerDelete.Location = new System.Drawing.Point(236, 3);
            this.btnInnerDelete.Name = "btnInnerDelete";
            this.btnInnerDelete.Size = new System.Drawing.Size(88, 23);
            this.btnInnerDelete.TabIndex = 11;
            this.btnInnerDelete.Text = "Xóa inner";
            this.btnInnerDelete.UseVisualStyleBackColor = false;
            //this.btnInnerDelete.Click += new System.EventHandler(this.btnInnerDelete_Click);
            // 
            // btnOuterPrint
            // 
            this.btnOuterPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOuterPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOuterPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuterPrint.ForeColor = System.Drawing.Color.White;
            this.btnOuterPrint.Location = new System.Drawing.Point(703, 3);
            this.btnOuterPrint.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnOuterPrint.Name = "btnOuterPrint";
            this.btnOuterPrint.Size = new System.Drawing.Size(88, 23);
            this.btnOuterPrint.TabIndex = 16;
            this.btnOuterPrint.Text = "In outer";
            this.btnOuterPrint.UseVisualStyleBackColor = false;
            //this.btnOuterPrint.Click += new System.EventHandler(this.btnOuterPrint_Click);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox2.Location = new System.Drawing.Point(1529, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = "20";
            this.textBox2.Visible = false;
            //this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 8;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.lblTotalKien, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label25, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblKien_NoInner_Text, 6, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblKien_NoInner, 7, 0);
            this.tableLayoutPanel8.Controls.Add(this.label37, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.lblKien_TotalKgThucTe, 4, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 384);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(785, 18);
            this.tableLayoutPanel8.TabIndex = 25;
            // 
            // lblTotalKien
            // 
            this.lblTotalKien.AutoSize = true;
            this.lblTotalKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKien.ForeColor = System.Drawing.Color.Red;
            this.lblTotalKien.Location = new System.Drawing.Point(95, 0);
            this.lblTotalKien.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblTotalKien.Name = "lblTotalKien";
            this.lblTotalKien.Size = new System.Drawing.Size(19, 18);
            this.lblTotalKien.TabIndex = 2;
            this.lblTotalKien.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 2);
            this.label25.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 16);
            this.label25.TabIndex = 1;
            this.label25.Text = "Tổng số kiện:";
            // 
            // lblKien_NoInner_Text
            // 
            this.lblKien_NoInner_Text.AutoSize = true;
            this.lblKien_NoInner_Text.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKien_NoInner_Text.Location = new System.Drawing.Point(613, 2);
            this.lblKien_NoInner_Text.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.lblKien_NoInner_Text.Name = "lblKien_NoInner_Text";
            this.lblKien_NoInner_Text.Size = new System.Drawing.Size(149, 16);
            this.lblKien_NoInner_Text.TabIndex = 4;
            this.lblKien_NoInner_Text.Text = "Kiện chưa đóng inner:";
            // 
            // lblKien_NoInner
            // 
            this.lblKien_NoInner.AutoSize = true;
            this.lblKien_NoInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKien_NoInner.ForeColor = System.Drawing.Color.Red;
            this.lblKien_NoInner.Location = new System.Drawing.Point(762, 0);
            this.lblKien_NoInner.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblKien_NoInner.Name = "lblKien_NoInner";
            this.lblKien_NoInner.Size = new System.Drawing.Size(19, 18);
            this.lblKien_NoInner.TabIndex = 5;
            this.lblKien_NoInner.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(314, 2);
            this.label37.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(80, 16);
            this.label37.TabIndex = 6;
            this.label37.Text = "Tổng số kg:";
            // 
            // lblKien_TotalKgThucTe
            // 
            this.lblKien_TotalKgThucTe.AutoSize = true;
            this.lblKien_TotalKgThucTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKien_TotalKgThucTe.ForeColor = System.Drawing.Color.Red;
            this.lblKien_TotalKgThucTe.Location = new System.Drawing.Point(394, 0);
            this.lblKien_TotalKgThucTe.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblKien_TotalKgThucTe.Name = "lblKien_TotalKgThucTe";
            this.lblKien_TotalKgThucTe.Size = new System.Drawing.Size(19, 18);
            this.lblKien_TotalKgThucTe.TabIndex = 7;
            this.lblKien_TotalKgThucTe.Text = "0";
            // 
            // dgKien
            // 
            this.dgKien.AllowUserToAddRows = false;
            this.dgKien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgKien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgKien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCP_Status,
            this.colCP_MaKien,
            this.colCP_SoKgTruBaoBi,
            this.colCP_SoKg_BaoBi,
            this.colCP_NgayIn,
            this.colCP_Deleted,
            this.colCP_InnerCode,
            this.colCP_Outer});
            this.tableLayoutPanel1.SetColumnSpan(this.dgKien, 2);
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgKien.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgKien.Location = new System.Drawing.Point(3, 405);
            this.dgKien.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dgKien.MultiSelect = false;
            this.dgKien.Name = "dgKien";
            this.dgKien.ReadOnly = true;
            this.dgKien.RowHeadersWidth = 25;
            this.dgKien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgKien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKien.Size = new System.Drawing.Size(1579, 339);
            this.dgKien.TabIndex = 10;
            //this.dgKien.SelectionChanged += new System.EventHandler(this.dgKien_SelectionChanged);
            // 
            // colCP_Status
            // 
            this.colCP_Status.DataPropertyName = "Status";
            this.colCP_Status.HeaderText = "Tình trạng";
            this.colCP_Status.Name = "colCP_Status";
            this.colCP_Status.ReadOnly = true;
            this.colCP_Status.Width = 92;
            // 
            // colCP_MaKien
            // 
            this.colCP_MaKien.DataPropertyName = "MaKien";
            this.colCP_MaKien.HeaderText = "Mã kiện";
            this.colCP_MaKien.Name = "colCP_MaKien";
            this.colCP_MaKien.ReadOnly = true;
            this.colCP_MaKien.Width = 205;
            // 
            // colCP_SoKgTruBaoBi
            // 
            this.colCP_SoKgTruBaoBi.DataPropertyName = "SoKgTruBaoBi";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.colCP_SoKgTruBaoBi.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCP_SoKgTruBaoBi.HeaderText = "Số kg";
            this.colCP_SoKgTruBaoBi.Name = "colCP_SoKgTruBaoBi";
            this.colCP_SoKgTruBaoBi.ReadOnly = true;
            this.colCP_SoKgTruBaoBi.Width = 70;
            // 
            // colCP_SoKg_BaoBi
            // 
            this.colCP_SoKg_BaoBi.DataPropertyName = "SoKg_BaoBi";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCP_SoKg_BaoBi.DefaultCellStyle = dataGridViewCellStyle9;
            this.colCP_SoKg_BaoBi.HeaderText = "Bao bì";
            this.colCP_SoKg_BaoBi.Name = "colCP_SoKg_BaoBi";
            this.colCP_SoKg_BaoBi.ReadOnly = true;
            this.colCP_SoKg_BaoBi.Width = 70;
            // 
            // colCP_NgayIn
            // 
            this.colCP_NgayIn.DataPropertyName = "NgayIn";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "dd/MM/yyyy HH:mm";
            this.colCP_NgayIn.DefaultCellStyle = dataGridViewCellStyle10;
            this.colCP_NgayIn.HeaderText = "Ngày in";
            this.colCP_NgayIn.Name = "colCP_NgayIn";
            this.colCP_NgayIn.ReadOnly = true;
            this.colCP_NgayIn.Width = 125;
            // 
            // colCP_Deleted
            // 
            this.colCP_Deleted.DataPropertyName = "Deleted";
            this.colCP_Deleted.HeaderText = "Return";
            this.colCP_Deleted.Name = "colCP_Deleted";
            this.colCP_Deleted.ReadOnly = true;
            this.colCP_Deleted.TrueValue = "";
            this.colCP_Deleted.Visible = false;
            this.colCP_Deleted.Width = 80;
            // 
            // colCP_InnerCode
            // 
            this.colCP_InnerCode.DataPropertyName = "InnerCode";
            this.colCP_InnerCode.HeaderText = "Inner";
            this.colCP_InnerCode.Name = "colCP_InnerCode";
            this.colCP_InnerCode.ReadOnly = true;
            this.colCP_InnerCode.Width = 125;
            // 
            // colCP_Outer
            // 
            this.colCP_Outer.DataPropertyName = "OuterCode";
            this.colCP_Outer.HeaderText = "Outer";
            this.colCP_Outer.Name = "colCP_Outer";
            this.colCP_Outer.ReadOnly = true;
            this.colCP_Outer.Width = 125;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(2, 38);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 3, 3, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(182, 18);
            this.label23.TabIndex = 21;
            this.label23.Text = "Thông tin lệnh sản xuất";
            // 
            // lblTitle_KienInfo
            // 
            this.lblTitle_KienInfo.AutoSize = true;
            this.lblTitle_KienInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle_KienInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_KienInfo.ForeColor = System.Drawing.Color.White;
            this.lblTitle_KienInfo.Location = new System.Drawing.Point(3, 214);
            this.lblTitle_KienInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTitle_KienInfo.Name = "lblTitle_KienInfo";
            this.lblTitle_KienInfo.Size = new System.Drawing.Size(91, 16);
            this.lblTitle_KienInfo.TabIndex = 14;
            this.lblTitle_KienInfo.Text = "Kiện hiện tại";
            // 
            // tlpPackageCurrent
            // 
            this.tlpPackageCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPackageCurrent.ColumnCount = 4;
            this.tlpPackageCurrent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPackageCurrent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPackageCurrent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPackageCurrent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPackageCurrent.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tlpPackageCurrent.Controls.Add(this.tbWeighReading, 3, 1);
            this.tlpPackageCurrent.Controls.Add(this.tbCPSoKienSX, 2, 1);
            this.tlpPackageCurrent.Controls.Add(this.label3, 0, 0);
            this.tlpPackageCurrent.Controls.Add(this.label16, 2, 0);
            this.tlpPackageCurrent.Controls.Add(this.tbCPMaKien, 0, 1);
            this.tlpPackageCurrent.Controls.Add(this.label20, 1, 2);
            this.tlpPackageCurrent.Controls.Add(this.tbCPSoKgBaoBi, 1, 3);
            this.tlpPackageCurrent.Controls.Add(this.tbCPSoKgTruBaoBi, 3, 3);
            this.tlpPackageCurrent.Controls.Add(this.lblKien_SoKgTinh, 3, 2);
            this.tlpPackageCurrent.Controls.Add(this.label19, 0, 2);
            this.tlpPackageCurrent.Controls.Add(this.tbCPSoKgChuan, 0, 3);
            this.tlpPackageCurrent.Controls.Add(this.tbCPSoKgThucTe, 2, 3);
            this.tlpPackageCurrent.Controls.Add(this.lblKien_SoKgGop, 2, 2);
            this.tlpPackageCurrent.Controls.Add(this.lblWeighReading, 3, 0);
            this.tlpPackageCurrent.Controls.Add(this.tbCPSoCuonChuan, 1, 1);
            this.tlpPackageCurrent.Controls.Add(this.lblKien_SoCuonChuan, 1, 0);
            this.tlpPackageCurrent.Location = new System.Drawing.Point(3, 273);
            this.tlpPackageCurrent.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.tlpPackageCurrent.Name = "tlpPackageCurrent";
            this.tlpPackageCurrent.RowCount = 5;
            this.tlpPackageCurrent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPackageCurrent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpPackageCurrent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPackageCurrent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPackageCurrent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPackageCurrent.Size = new System.Drawing.Size(788, 84);
            this.tlpPackageCurrent.TabIndex = 31;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox3, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBox5, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBox6, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.label9, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBox7, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBox8, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.label14, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox9, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label17, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 96);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(194, 12);
            this.tableLayoutPanel5.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(147, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(44, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "0.0";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(99, 16);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(42, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mã kiện";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số kiện SX";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(0, 16);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(45, 22);
            this.textBox4.TabIndex = 19;
            this.textBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Số kg bao bì";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(51, 58);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(42, 22);
            this.textBox5.TabIndex = 23;
            this.textBox5.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(147, 58);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(47, 22);
            this.textBox6.TabIndex = 25;
            this.textBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(144, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Số kg tịnh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Số kg chuẩn";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(0, 58);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(45, 22);
            this.textBox7.TabIndex = 20;
            this.textBox7.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Red;
            this.textBox8.Location = new System.Drawing.Point(99, 58);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(42, 22);
            this.textBox8.TabIndex = 4;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(96, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Số &kg gộp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(144, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Đọc cân";
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(51, 16);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(42, 22);
            this.textBox9.TabIndex = 21;
            this.textBox9.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "Số cuộn chuẩn";
            // 
            // tbWeighReading
            // 
            this.tbWeighReading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWeighReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeighReading.ForeColor = System.Drawing.Color.Red;
            this.tbWeighReading.Location = new System.Drawing.Point(594, 16);
            this.tbWeighReading.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.tbWeighReading.Name = "tbWeighReading";
            this.tbWeighReading.ReadOnly = true;
            this.tbWeighReading.Size = new System.Drawing.Size(194, 22);
            this.tbWeighReading.TabIndex = 30;
            this.tbWeighReading.Text = "0.0";
            //this.tbWeighReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWeighReading_KeyPress);
            //this.tbWeighReading.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbWeighReading_PreviewKeyDown);
            //this.tbWeighReading.Validating += new System.ComponentModel.CancelEventHandler(this.tbWeighReading_Validating);
            // 
            // tbCPSoKienSX
            // 
            this.tbCPSoKienSX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPSoKienSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPSoKienSX.Location = new System.Drawing.Point(397, 16);
            this.tbCPSoKienSX.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbCPSoKienSX.Name = "tbCPSoKienSX";
            this.tbCPSoKienSX.ReadOnly = true;
            this.tbCPSoKienSX.Size = new System.Drawing.Size(191, 22);
            this.tbCPSoKienSX.TabIndex = 4;
            //this.tbCPSoKienSX.TextChanged += new System.EventHandler(this.tbCPSoKienSX_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã kiện";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(394, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Số kiện SX";
            // 
            // tbCPMaKien
            // 
            this.tbCPMaKien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPMaKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPMaKien.Location = new System.Drawing.Point(0, 16);
            this.tbCPMaKien.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbCPMaKien.Name = "tbCPMaKien";
            this.tbCPMaKien.ReadOnly = true;
            this.tbCPMaKien.Size = new System.Drawing.Size(194, 22);
            this.tbCPMaKien.TabIndex = 19;
            this.tbCPMaKien.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(197, 42);
            this.label20.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 16);
            this.label20.TabIndex = 26;
            this.label20.Text = "Số kg bao bì";
            // 
            // tbCPSoKgBaoBi
            // 
            this.tbCPSoKgBaoBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPSoKgBaoBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPSoKgBaoBi.Location = new System.Drawing.Point(200, 58);
            this.tbCPSoKgBaoBi.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbCPSoKgBaoBi.Name = "tbCPSoKgBaoBi";
            this.tbCPSoKgBaoBi.ReadOnly = true;
            this.tbCPSoKgBaoBi.Size = new System.Drawing.Size(191, 22);
            this.tbCPSoKgBaoBi.TabIndex = 23;
            this.tbCPSoKgBaoBi.TabStop = false;
            // 
            // tbCPSoKgTruBaoBi
            // 
            this.tbCPSoKgTruBaoBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPSoKgTruBaoBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPSoKgTruBaoBi.Location = new System.Drawing.Point(594, 58);
            this.tbCPSoKgTruBaoBi.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.tbCPSoKgTruBaoBi.Name = "tbCPSoKgTruBaoBi";
            this.tbCPSoKgTruBaoBi.ReadOnly = true;
            this.tbCPSoKgTruBaoBi.Size = new System.Drawing.Size(194, 22);
            this.tbCPSoKgTruBaoBi.TabIndex = 25;
            this.tbCPSoKgTruBaoBi.TabStop = false;
            // 
            // lblKien_SoKgTinh
            // 
            this.lblKien_SoKgTinh.AutoSize = true;
            this.lblKien_SoKgTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKien_SoKgTinh.Location = new System.Drawing.Point(591, 42);
            this.lblKien_SoKgTinh.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblKien_SoKgTinh.Name = "lblKien_SoKgTinh";
            this.lblKien_SoKgTinh.Size = new System.Drawing.Size(65, 16);
            this.lblKien_SoKgTinh.TabIndex = 28;
            this.lblKien_SoKgTinh.Text = "Số kg tịnh";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, 42);
            this.label19.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 16);
            this.label19.TabIndex = 18;
            this.label19.Text = "Số kg chuẩn";
            // 
            // tbCPSoKgChuan
            // 
            this.tbCPSoKgChuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPSoKgChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPSoKgChuan.Location = new System.Drawing.Point(0, 58);
            this.tbCPSoKgChuan.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbCPSoKgChuan.Name = "tbCPSoKgChuan";
            this.tbCPSoKgChuan.ReadOnly = true;
            this.tbCPSoKgChuan.Size = new System.Drawing.Size(194, 22);
            this.tbCPSoKgChuan.TabIndex = 20;
            this.tbCPSoKgChuan.TabStop = false;
            // 
            // tbCPSoKgThucTe
            // 
            this.tbCPSoKgThucTe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPSoKgThucTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPSoKgThucTe.ForeColor = System.Drawing.Color.Red;
            this.tbCPSoKgThucTe.Location = new System.Drawing.Point(397, 58);
            this.tbCPSoKgThucTe.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbCPSoKgThucTe.Name = "tbCPSoKgThucTe";
            this.tbCPSoKgThucTe.ReadOnly = true;
            this.tbCPSoKgThucTe.Size = new System.Drawing.Size(191, 22);
            this.tbCPSoKgThucTe.TabIndex = 4;
            this.tbCPSoKgThucTe.TabStop = false;
            this.tbCPSoKgThucTe.Text = "0.0";
            //this.tbCPSoKgThucTe.TextChanged += new System.EventHandler(this.tbCPSoKgThucTe_TextChanged);
            //this.tbCPSoKgThucTe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCPSoKgThucTe_KeyPress);
            //this.tbCPSoKgThucTe.Validating += new System.ComponentModel.CancelEventHandler(this.tbCPSoKgThucTe_Validating);
            // 
            // lblKien_SoKgGop
            // 
            this.lblKien_SoKgGop.AutoSize = true;
            this.lblKien_SoKgGop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKien_SoKgGop.Location = new System.Drawing.Point(394, 42);
            this.lblKien_SoKgGop.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblKien_SoKgGop.Name = "lblKien_SoKgGop";
            this.lblKien_SoKgGop.Size = new System.Drawing.Size(69, 16);
            this.lblKien_SoKgGop.TabIndex = 3;
            this.lblKien_SoKgGop.Text = "Số &kg gộp";
            // 
            // lblWeighReading
            // 
            this.lblWeighReading.AutoSize = true;
            this.lblWeighReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeighReading.Location = new System.Drawing.Point(591, 0);
            this.lblWeighReading.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblWeighReading.Name = "lblWeighReading";
            this.lblWeighReading.Size = new System.Drawing.Size(56, 16);
            this.lblWeighReading.TabIndex = 15;
            this.lblWeighReading.Text = "Đọc cân";
            // 
            // tbCPSoCuonChuan
            // 
            this.tbCPSoCuonChuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCPSoCuonChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPSoCuonChuan.Location = new System.Drawing.Point(200, 16);
            this.tbCPSoCuonChuan.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbCPSoCuonChuan.Name = "tbCPSoCuonChuan";
            this.tbCPSoCuonChuan.ReadOnly = true;
            this.tbCPSoCuonChuan.Size = new System.Drawing.Size(191, 22);
            this.tbCPSoCuonChuan.TabIndex = 21;
            this.tbCPSoCuonChuan.TabStop = false;
            // 
            // lblKien_SoCuonChuan
            // 
            this.lblKien_SoCuonChuan.AutoSize = true;
            this.lblKien_SoCuonChuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKien_SoCuonChuan.Location = new System.Drawing.Point(197, 0);
            this.lblKien_SoCuonChuan.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblKien_SoCuonChuan.Name = "lblKien_SoCuonChuan";
            this.lblKien_SoCuonChuan.Size = new System.Drawing.Size(95, 16);
            this.lblKien_SoCuonChuan.TabIndex = 14;
            this.lblKien_SoCuonChuan.Text = "Số cuộn chuẩn";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.tbCP_SpecInner, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.label33, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label34, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbCP_EAN, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tbCP_SpecOuter, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label40, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(794, 273);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(788, 84);
            this.tableLayoutPanel6.TabIndex = 33;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.textBox10, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox11, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox12, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label22, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.textBox13, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.textBox14, 3, 3);
            this.tableLayoutPanel7.Controls.Add(this.label24, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.label26, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.textBox15, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.textBox16, 2, 3);
            this.tableLayoutPanel7.Controls.Add(this.label27, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.label29, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox17, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label32, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 96);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(194, 12);
            this.tableLayoutPanel7.TabIndex = 32;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Red;
            this.textBox10.Location = new System.Drawing.Point(147, 16);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(44, 22);
            this.textBox10.TabIndex = 30;
            this.textBox10.Text = "0.0";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(99, 16);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(42, 22);
            this.textBox11.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 16);
            this.label18.TabIndex = 29;
            this.label18.Text = "Mã kiện";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(96, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 16);
            this.label21.TabIndex = 14;
            this.label21.Text = "Số kiện SX";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(0, 16);
            this.textBox12.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(45, 22);
            this.textBox12.TabIndex = 19;
            this.textBox12.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(48, 42);
            this.label22.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 16);
            this.label22.TabIndex = 26;
            this.label22.Text = "Số kg bao bì";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(51, 58);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(42, 22);
            this.textBox13.TabIndex = 23;
            this.textBox13.TabStop = false;
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(147, 58);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(47, 22);
            this.textBox14.TabIndex = 25;
            this.textBox14.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(144, 42);
            this.label24.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 16);
            this.label24.TabIndex = 28;
            this.label24.Text = "Số kg tịnh";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(0, 42);
            this.label26.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 16);
            this.label26.TabIndex = 18;
            this.label26.Text = "Số kg chuẩn";
            // 
            // textBox15
            // 
            this.textBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(0, 58);
            this.textBox15.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(45, 22);
            this.textBox15.TabIndex = 20;
            this.textBox15.TabStop = false;
            // 
            // textBox16
            // 
            this.textBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.Red;
            this.textBox16.Location = new System.Drawing.Point(99, 58);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(42, 22);
            this.textBox16.TabIndex = 4;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "0.0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(96, 42);
            this.label27.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 16);
            this.label27.TabIndex = 3;
            this.label27.Text = "Số &kg gộp";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(144, 0);
            this.label29.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 16);
            this.label29.TabIndex = 15;
            this.label29.Text = "Đọc cân";
            // 
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(51, 16);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(42, 22);
            this.textBox17.TabIndex = 21;
            this.textBox17.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(48, 0);
            this.label32.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 16);
            this.label32.TabIndex = 14;
            this.label32.Text = "Số cuộn chuẩn";
            // 
            // tbCP_SpecInner
            // 
            this.tbCP_SpecInner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCP_SpecInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCP_SpecInner.Location = new System.Drawing.Point(397, 16);
            this.tbCP_SpecInner.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbCP_SpecInner.Name = "tbCP_SpecInner";
            this.tbCP_SpecInner.ReadOnly = true;
            this.tbCP_SpecInner.Size = new System.Drawing.Size(191, 22);
            this.tbCP_SpecInner.TabIndex = 4;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 16);
            this.label33.TabIndex = 29;
            this.label33.Text = "Mã EAN";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(394, 0);
            this.label34.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(95, 16);
            this.label34.TabIndex = 14;
            this.label34.Text = "Quy cách inner";
            // 
            // tbCP_EAN
            // 
            this.tbCP_EAN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCP_EAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCP_EAN.Location = new System.Drawing.Point(3, 16);
            this.tbCP_EAN.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbCP_EAN.Name = "tbCP_EAN";
            this.tbCP_EAN.ReadOnly = true;
            this.tbCP_EAN.Size = new System.Drawing.Size(191, 22);
            this.tbCP_EAN.TabIndex = 19;
            this.tbCP_EAN.TabStop = false;
            // 
            // tbCP_SpecOuter
            // 
            this.tbCP_SpecOuter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCP_SpecOuter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCP_SpecOuter.Location = new System.Drawing.Point(200, 16);
            this.tbCP_SpecOuter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tbCP_SpecOuter.Name = "tbCP_SpecOuter";
            this.tbCP_SpecOuter.ReadOnly = true;
            this.tbCP_SpecOuter.Size = new System.Drawing.Size(191, 22);
            this.tbCP_SpecOuter.TabIndex = 21;
            this.tbCP_SpecOuter.TabStop = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(197, 0);
            this.label40.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(96, 16);
            this.label40.TabIndex = 14;
            this.label40.Text = "Quy cách outer";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaThanhPhan";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã bán thành phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenThanhPhan";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên bán thành phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 360;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoKg_KeHoach";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn3.HeaderText = "Số kg kế hoạch";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoKg_ThucTe";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng số kg";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 92;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaKien";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã kiện";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 205;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SoCuonThucTe";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Goldenrod;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn7.HeaderText = "Số cuộn";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SoKgTruBaoBi";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn8.HeaderText = "Số kg";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SoKg_BaoBi";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn9.HeaderText = "Bao bì";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Deleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Return";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.TrueValue = "";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NgayIn";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "dd/MM/yyyy HH:mm";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn10.HeaderText = "Ngày in";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OuterCode";
            this.dataGridViewTextBoxColumn11.HeaderText = "Outer";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // WorkOrderDetailEANView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WorkOrderDetailEANView";
            this.Size = new System.Drawing.Size(1582, 744);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWIPItem)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKien)).EndInit();
            this.tlpPackageCurrent.ResumeLayout(false);
            this.tlpPackageCurrent.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;

        private TableLayoutPanel tableLayoutPanel1;

        private Label label13;

        private TableLayoutPanel tableLayoutPanel2;

        private Label label10;

        private TextBox tbUnit;

        private TextBox tbSoKgKeHoach;

        private TextBox tbMaThanhPham;

        private Label lblSoKgKeHoach;

        private Label lblSoKgCanThucHien;

        private Label label6;

        private TextBox tbTenThanhPham;

        private DataGridView dgWIPItem;

        private Label label15;

        private TableLayoutPanel tableLayoutPanel4;

        private Button btnOpenPackage;

        private Button btnClosePackage;

        private TextBox tbOrderCode;

        private Label label2;

        private Button btnCloseOrder;

        private Button btnCancel;

        private DataGridView dgKien;

        private Label label23;

        private TextBox tbSoKgCanThucHien;

        private Label label28;

        private Label label30;

        private TextBox tbTolerance;

        private Label label31;

        private DateTimePicker dtpTransactionDate;

        private TextBox textBox2;

        private Label label1;

        private Button btnDeleteKien;

        private Button btnPrintKien;

        private Button btnReturnKien;

        private Button btnExportExcel;

        private DataGridViewTextBoxColumn colWItem_MaThanhPhan;

        private DataGridViewTextBoxColumn colWItem_TenThanhPhan;

        private DataGridViewTextBoxColumn colWItem_SoKg_KeHoach;

        private DataGridViewTextBoxColumn colWItem_SoKg_ThucTe;

        private TextBox tbPONumber;

        private Label label4;

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

        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;

        private CheckBox chkSavePrintAuto_Cuon;

        private TableLayoutPanel tlpPackageCurrent;

        private TableLayoutPanel tableLayoutPanel5;

        private TextBox textBox1;

        private TextBox textBox3;

        private Label label5;

        private Label label7;

        private TextBox textBox4;

        private Label label8;

        private TextBox textBox5;

        private TextBox textBox6;

        private Label label9;

        private Label label11;

        private TextBox textBox7;

        private TextBox textBox8;

        private Label label12;

        private Label label14;

        private TextBox textBox9;

        private Label label17;

        private TextBox tbWeighReading;

        private TextBox tbCPSoKienSX;

        private Label label3;

        private Label label16;

        private TextBox tbCPMaKien;

        private Label label20;

        private TextBox tbCPSoKgBaoBi;

        private TextBox tbCPSoKgTruBaoBi;

        private Label lblKien_SoKgTinh;

        private Label label19;

        private TextBox tbCPSoKgChuan;

        private TextBox tbCPSoKgThucTe;

        private Label lblKien_SoKgGop;

        private Label lblWeighReading;

        private TextBox tbCPSoCuonChuan;

        private Label lblKien_SoCuonChuan;

        private TableLayoutPanel tableLayoutPanel6;

        private TableLayoutPanel tableLayoutPanel7;

        private TextBox textBox10;

        private TextBox textBox11;

        private Label label18;

        private Label label21;

        private TextBox textBox12;

        private Label label22;

        private TextBox textBox13;

        private TextBox textBox14;

        private Label label24;

        private Label label26;

        private TextBox textBox15;

        private TextBox textBox16;

        private Label label27;

        private Label label29;

        private TextBox textBox17;

        private Label label32;

        private TextBox tbCP_SpecInner;

        private Label label33;

        private Label label34;

        private TextBox tbCP_EAN;

        private TextBox tbCP_SpecOuter;

        private Label label40;

        private DataGridViewTextBoxColumn colCP_Status;

        private DataGridViewTextBoxColumn colCP_MaKien;

        private DataGridViewTextBoxColumn colCP_SoKgTruBaoBi;

        private DataGridViewTextBoxColumn colCP_SoKg_BaoBi;

        private DataGridViewTextBoxColumn colCP_NgayIn;

        private DataGridViewCheckBoxColumn colCP_Deleted;

        private DataGridViewTextBoxColumn colCP_InnerCode;

        private DataGridViewTextBoxColumn colCP_Outer;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

        private TableLayoutPanel tableLayoutPanel9;

        private Button btnInnerPrint;

        private Button btnInnerClose;

        private Button btnOuterDelete;

        private Button btnOuterClose;

        private Button btnInnerDelete;

        private Button btnOuterPrint;

        private TableLayoutPanel tableLayoutPanel8;

        private Label lblTotalKien;

        private Label label25;

        private Label lblKien_NoInner_Text;

        private Label lblKien_NoInner;

        private Label label37;

        private Label lblKien_TotalKgThucTe;

        private Label lblTitle_KienInfo;

        private TableLayoutPanel tableLayoutPanel10;

        private Label lblKien_TotalInner;

        private Label lblKien_TotalInner_Text;

        private Label label36;

        private Label lblKien_TotalOuter;
    }
}
