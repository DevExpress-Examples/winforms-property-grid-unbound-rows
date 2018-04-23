using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication3
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
                UnboundRowsHelper helper = new UnboundRowsHelper(propertyGridControl1);
                helper.AddUnboundRow("UnboundInt", typeof(int));
                helper.AddUnboundRow("UnboundString", typeof(string));
                helper.AddUnboundRow("UnboundDateTime", typeof(DateTime));
                propertyGridControl1.AutoGenerateRows = true;
            }
        }
}
