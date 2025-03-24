using System;
using System.Text;
using System.Windows.Forms;

namespace WarehouseManagement.Control
{
    partial class CheckedComboBox
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
        internal class Dropdown : Form
        {
            private CheckedComboBox ccbParent;
            private string oldStrValue = "";
            private bool[] checkedStateArr;
            private bool dropdownClosed = true;

            public Dropdown(CheckedComboBox ccbParent)
            {
                this.ccbParent = ccbParent;
                InitializeComponent();
                base.ShowInTaskbar = false;
                cclb.ItemCheck += cclb_ItemCheck;
            }
            private void cclb_ItemCheck(object sender, ItemCheckEventArgs e)
            {
                if (ccbParent.ItemCheck != null)
                {
                    ccbParent.ItemCheck(sender, e);
                }
            }
            public bool ValueChanged
            {
                get
                {
                    string text = ccbParent.Text;
                    if (oldStrValue.Length > 0 && text.Length > 0)
                    {
                        return oldStrValue.CompareTo(text) != 0;
                    }
                    return oldStrValue.Length != text.Length;
                }
            }
            public string GetCheckedItemsStringValue()
            {
                StringBuilder stringBuilder = new StringBuilder("");
                for (int i = 0; i < cclb.CheckedItems.Count; i++)
                {
                    stringBuilder.Append(cclb.GetItemText(cclb.CheckedItems[i])).Append(ccbParent.ValueSeparator);
                }
                if (stringBuilder.Length > 0)
                {
                    stringBuilder.Remove(stringBuilder.Length - ccbParent.ValueSeparator.Length, ccbParent.ValueSeparator.Length);
                }
                return stringBuilder.ToString();
            }
            public void CloseDropdown(bool enactChanges)
            {
                if (dropdownClosed)
                {
                    return;
                }
                if (enactChanges)
                {
                    ccbParent.SelectedIndex = -1;
                    ccbParent.Text = GetCheckedItemsStringValue();
                }
                else
                {
                    for (int i = 0; i < cclb.Items.Count; i++)
                    {
                        cclb.SetItemChecked(i, checkedStateArr[i]);
                    }
                }
                dropdownClosed = true;
                ccbParent.BeginInvoke((Action)delegate
                {
                    Hide();
                });
                ccbParent.OnDropDownClosed(new CCBoxEventArgs(null, assignValues: false));
            }

            protected override void OnActivated(EventArgs e)
            {
                base.OnActivated(e);
                dropdownClosed = false;
                oldStrValue = ccbParent.Text;
                checkedStateArr = new bool[cclb.Items.Count];
                for (int i = 0; i < cclb.Items.Count; i++)
                {
                    checkedStateArr[i] = cclb.GetItemChecked(i);
                }
            }

            protected override void OnDeactivate(EventArgs e)
            {
                base.OnDeactivate(e);
                if (e is CCBoxEventArgs cCBoxEventArgs)
                {
                    CloseDropdown(cCBoxEventArgs.AssignValues);
                }
                else
                {
                    CloseDropdown(enactChanges: true);
                }
            }

            public CustomCheckedListBox List
            {
                get
                {
                    return cclb;
                }
                set
                {
                    cclb = value;
                }
            }
            internal class CCBoxEventArgs : EventArgs
            {
                private bool assignValues;
                private EventArgs e;

                public bool AssignValues
                {
                    get
                    {
                        return assignValues;
                    }
                    set
                    {
                        assignValues = value;
                    }
                }

                public EventArgs EventArgs
                {
                    get
                    {
                        return e;
                    }
                    set
                    {
                        e = value;
                    }
                }

                public CCBoxEventArgs(EventArgs e, bool assignValues)
                {
                    this.e = e;
                    this.assignValues = assignValues;
                }
            }
            internal class CustomCheckedListBox : CheckedListBox
            {
                private int curSelIndex = -1;

                public override int ItemHeight
                {
                    get
                    {
                        return Font.Height + 3;
                    }
                    set
                    {
                        base.ItemHeight = value;
                    }
                }

                public CustomCheckedListBox()
                {
                    SelectionMode = SelectionMode.One;
                    base.HorizontalScrollbar = true;
                }

                protected override void OnKeyDown(KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Return)
                    {
                        ((Dropdown)base.Parent).OnDeactivate(new CCBoxEventArgs(null, assignValues: true));
                        e.Handled = true;
                    }
                    else if (e.KeyCode == Keys.Escape)
                    {
                        ((Dropdown)base.Parent).OnDeactivate(new CCBoxEventArgs(null, assignValues: false));
                        e.Handled = true;
                    }
                    else if (e.KeyCode == Keys.Delete)
                    {
                        for (int i = 0; i < base.Items.Count; i++)
                        {
                            SetItemChecked(i, e.Shift);
                        }
                        e.Handled = true;
                    }
                    base.OnKeyDown(e);
                }

                protected override void OnMouseMove(MouseEventArgs e)
                {
                    base.OnMouseMove(e);
                    int num = IndexFromPoint(e.Location);
                    if (num >= 0 && num != curSelIndex)
                    {
                        curSelIndex = num;
                        SetSelected(num, value: true);
                    }
                }
            }

            private void InitializeComponent()
            {
                this.cclb = new CustomCheckedListBox();
                base.SuspendLayout();
                this.cclb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.cclb.Dock = System.Windows.Forms.DockStyle.Fill;
                this.cclb.FormattingEnabled = true;
                this.cclb.Location = new System.Drawing.Point(0, 0);
                this.cclb.Name = "cclb";
                this.cclb.Size = new System.Drawing.Size(47, 15);
                this.cclb.TabIndex = 0;
                base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
                base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.SystemColors.Menu;
                base.ClientSize = new System.Drawing.Size(47, 16);
                base.ControlBox = false;
                base.Controls.Add(this.cclb);
                this.ForeColor = System.Drawing.SystemColors.ControlText;
                base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                base.MinimizeBox = false;
                base.Name = "ccbParent";
                base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                base.ResumeLayout(false);
            }
            private CustomCheckedListBox cclb;

        }
        private Dropdown dropdown;
        #endregion
    }
}
