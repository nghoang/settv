using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace STVControls
{
    public partial class STVGroup : GroupBox
    {
        public STVGroup()
        {
            InitializeComponent();

            //this.ForeColor = Color.Red;

        }

        public STVGroup(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
