using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement.Control
{
    //public partial class CheckedComboBox: ComboBox
    public partial class CheckedComboBox : ComboBox
    {




        private string valueSeparator;

        public string ValueSeparator
        {
            get
            {
                return valueSeparator;
            }
            set
            {
                valueSeparator = value;
            }
        }

        public bool CheckOnClick
        {
            get
            {
                return dropdown.List.CheckOnClick;
            }
            set
            {
                dropdown.List.CheckOnClick = value;
            }
        }

        public new string DisplayMember
        {
            get
            {
                return dropdown.List.DisplayMember;
            }
            set
            {
                dropdown.List.DisplayMember = value;
            }
        }

        public new CheckedListBox.ObjectCollection Items => dropdown.List.Items;

        public CheckedListBox.CheckedItemCollection CheckedItems => dropdown.List.CheckedItems;

        public CheckedListBox.CheckedIndexCollection CheckedIndices => dropdown.List.CheckedIndices;

        public bool ValueChanged => dropdown.ValueChanged;

        public event ItemCheckEventHandler ItemCheck;

        public CheckedComboBox()
        {
            base.DrawMode = DrawMode.OwnerDrawVariable;
            valueSeparator = ", ";
            base.DropDownHeight = 1;
            base.DropDownStyle = ComboBoxStyle.DropDown;
            dropdown = new Dropdown(this);
            CheckOnClick = true;
        }


        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            dropdown.Font = Font;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.DroppedDown = false;
        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            DoDropDown();
        }

        private void DoDropDown()
        {
            if (!dropdown.Visible)
            {
                Rectangle rectangle = RectangleToScreen(base.ClientRectangle);
                dropdown.Location = new Point(rectangle.X, rectangle.Y + base.Size.Height);
                int num = dropdown.List.Items.Count;
                if (num > base.MaxDropDownItems)
                {
                    num = base.MaxDropDownItems;
                }
                else if (num == 0)
                {
                    num = 1;
                }
                dropdown.Size = new Size(base.Size.Width, dropdown.List.ItemHeight * num + 2);
                dropdown.Show(this);
            }
        }

        protected override void OnDropDownClosed(EventArgs e)
        {
            if (e is Dropdown.CCBoxEventArgs)
            {
                base.OnDropDownClosed(e);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                OnDropDown(null);
            }
            e.Handled = !e.Alt && e.KeyCode != Keys.Tab && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Home && e.KeyCode != Keys.End;
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = true;
            base.OnKeyPress(e);
        }

        public bool GetItemChecked(int index)
        {
            if (index < 0 || index > Items.Count)
            {
                throw new ArgumentOutOfRangeException("index", "value out of range");
            }
            return dropdown.List.GetItemChecked(index);
        }

        public void SetItemChecked(int index, bool isChecked)
        {
            if (index < 0 || index > Items.Count)
            {
                throw new ArgumentOutOfRangeException("index", "value out of range");
            }
            dropdown.List.SetItemChecked(index, isChecked);
            Text = dropdown.GetCheckedItemsStringValue();
        }

        public CheckState GetItemCheckState(int index)
        {
            if (index < 0 || index > Items.Count)
            {
                throw new ArgumentOutOfRangeException("index", "value out of range");
            }
            return dropdown.List.GetItemCheckState(index);
        }

        public void SetItemCheckState(int index, CheckState state)
        {
            if (index < 0 || index > Items.Count)
            {
                throw new ArgumentOutOfRangeException("index", "value out of range");
            }
            dropdown.List.SetItemCheckState(index, state);
            Text = dropdown.GetCheckedItemsStringValue();
        }
    }
}
