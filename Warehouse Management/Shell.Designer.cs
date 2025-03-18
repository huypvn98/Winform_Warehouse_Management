namespace Warehouse_Management
{
    partial class Shell
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.tcMainContent = new System.Windows.Forms.TabControl();
            this.ucHeader1 = new Warehouse_Management.ucHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblUpdate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVersion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDomain, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 358);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 17);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F);
            this.lblUpdate.ForeColor = System.Drawing.Color.White;
            this.lblUpdate.Location = new System.Drawing.Point(520, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Padding = new System.Windows.Forms.Padding(0, 1, 4, 0);
            this.lblUpdate.Size = new System.Drawing.Size(77, 17);
            this.lblUpdate.TabIndex = 4;
            this.lblUpdate.Text = "[Cập nhật]";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(456, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Padding = new System.Windows.Forms.Padding(0, 1, 4, 0);
            this.lblVersion.Size = new System.Drawing.Size(58, 17);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "version";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F);
            this.lblDomain.ForeColor = System.Drawing.Color.White;
            this.lblDomain.Location = new System.Drawing.Point(3, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Padding = new System.Windows.Forms.Padding(0, 1, 4, 0);
            this.lblDomain.Size = new System.Drawing.Size(58, 17);
            this.lblDomain.TabIndex = 2;
            this.lblDomain.Text = "domain";
            this.lblDomain.Visible = false;
            // 
            // tcMainContent
            // 
            this.tcMainContent.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcMainContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMainContent.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcMainContent.Enabled = false;
            this.tcMainContent.ItemSize = new System.Drawing.Size(52, 120);
            this.tcMainContent.Location = new System.Drawing.Point(0, 46);
            this.tcMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.tcMainContent.Multiline = true;
            this.tcMainContent.Name = "tcMainContent";
            this.tcMainContent.SelectedIndex = 0;
            this.tcMainContent.Size = new System.Drawing.Size(598, 302);
            this.tcMainContent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMainContent.TabIndex = 0;
            // 
            // ucHeader1
            // 
            this.ucHeader1.BackColor = System.Drawing.Color.SteelBlue;
            this.ucHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ucHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ucHeader1.Location = new System.Drawing.Point(0, 0);
            this.ucHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.ucHeader1.Name = "ucHeader1";
            this.ucHeader1.Size = new System.Drawing.Size(600, 47);
            this.ucHeader1.TabIndex = 1;
            // 
            // Shell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ucHeader1);
            this.Controls.Add(this.tcMainContent);
            this.KeyPreview = true;
            this.Name = "Shell";
            this.Text = "SIAM Brothers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shell_FormClosed);
            this.Load += new System.EventHandler(this.Shell_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ucHeader ucHeader1;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TabControl tcMainContent;
    }
}

