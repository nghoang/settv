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
    public partial class STVLabel : Label
    {
        public STVLabel()
        {
            InitializeComponent();

            //this.ForeColor = Color.Red;
        }

        public STVLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
