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
    public partial class STVForm : Form
    {
        public STVForm()
        {
            InitializeComponent();

            //this.BackColor = Color.Black;
        }

        public STVForm(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
