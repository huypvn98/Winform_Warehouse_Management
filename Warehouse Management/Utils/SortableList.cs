using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Utils
{
    public class SortableList<T> : BindingList<T>
    {
        private bool isSortedValue;

        private ListSortDirection sortDirectionValue;

        private PropertyDescriptor sortPropertyValue;

        private ArrayList unsortedItems;

        protected override bool SupportsSearchingCore => true;

        protected override bool SupportsSortingCore => true;

        protected override bool IsSortedCore => isSortedValue;

        protected override PropertyDescriptor SortPropertyCore => sortPropertyValue;

        protected override ListSortDirection SortDirectionCore => sortDirectionValue;

        public SortableList()
        {
        }

        public SortableList(IList<T> list)
            : base(list)
        {
        }

        protected override int FindCore(PropertyDescriptor prop, object key)
        {
            PropertyInfo property = typeof(T).GetProperty(prop.Name);
            if (key != null)
            {
                for (int i = 0; i < base.Count; i++)
                {
                    T val = base.Items[i];
                    object value = property.GetValue(val, null);
                    if (value != null && value.Equals(key))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public int Find(string property, object key)
        {
            PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(typeof(T)).Find(property, ignoreCase: true);
            if (propertyDescriptor == null)
            {
                return -1;
            }
            return FindCore(propertyDescriptor, key);
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            sortPropertyValue = prop;
            sortDirectionValue = direction;
            unsortedItems = new ArrayList(base.Count);
            foreach (T item in base.Items)
            {
                unsortedItems.Add(item);
            }
            List<T> list = ((direction != 0) ? (from s in base.Items.ToList()
                                                orderby s.GetType().GetProperty(prop.Name).GetValue(s) descending
                                                select s).ToList() : (from s in base.Items.ToList()
                                                                      orderby s.GetType().GetProperty(prop.Name).GetValue(s)
                                                                      select s).ToList());
            for (int i = 0; i < list.Count; i++)
            {
                int num = IndexOf(list[i]);
                if (num >= 0 && num != i)
                {
                    T value = base[i];
                    base[i] = base[num];
                    base[num] = value;
                }
            }
            isSortedValue = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            if (unsortedItems == null)
            {
                return;
            }
            int num = 0;
            while (num < unsortedItems.Count)
            {
                int num2 = Find("LastName", unsortedItems[num].GetType().GetProperty("LastName").GetValue(unsortedItems[num], null));
                if (num2 > 0 && num2 != num)
                {
                    object obj = base[num];
                    base[num] = base[num2];
                    base[num2] = (T)obj;
                    num++;
                }
                else if (num2 == num)
                {
                    num++;
                }
                else
                {
                    unsortedItems.RemoveAt(num);
                }
            }
            isSortedValue = false;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public override void EndNew(int itemIndex)
        {
            if (sortPropertyValue != null && itemIndex == base.Count - 1)
            {
                ApplySortCore(sortPropertyValue, sortDirectionValue);
            }
            base.EndNew(itemIndex);
        }

        public void RemoveSort()
        {
            RemoveSortCore();
        }
    }

}
