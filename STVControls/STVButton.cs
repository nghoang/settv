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
    public partial class STVButton : Button
    {
        public STVButton()
        {
            InitializeComponent();

            //this.BackColor = Color.Blue;
            //this.ForeColor = Color.Red;
            //this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        public STVButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
