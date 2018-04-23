using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Events;
using System.ComponentModel;
using System.Collections;
using DevExpress.XtraVerticalGrid.Rows;

namespace DXApplication3
{
    public class UnboundRowsHelper
    {


        private readonly PropertyGridControl _PropertyGrid;

        private List<UnboundRow> _UnboundRows = new List<UnboundRow>();

        public UnboundRowsHelper(PropertyGridControl pg)
        {
            _PropertyGrid = pg;
            _PropertyGrid.CustomPropertyDescriptors += _PropertyGrid_CustomPropertyDescriptors;
        }

        void _PropertyGrid_CustomPropertyDescriptors(object sender, CustomPropertyDescriptorsEventArgs e)
        {
            if ((sender as PropertyGridControl).SelectedObject == e.Source)
            {
                PropertyDescriptorCollection properties = e.Properties;
                ArrayList list = new ArrayList(properties);
                list.AddRange(_UnboundRows);
                PropertyDescriptor[] result = new PropertyDescriptor[list.Count];
                list.ToArray().CopyTo(result, 0);
                e.Properties = new PropertyDescriptorCollection(result);
            }
        }

        public void AddUnboundRow(string fieldName, Type valueType)
        {
            
            UnboundRow row = new UnboundRow(fieldName, valueType);
            _UnboundRows.Add(row);
        }
    }
}
