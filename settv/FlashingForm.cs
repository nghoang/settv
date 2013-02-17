using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace settv
{
    public partial class FlashingForm : Form
    {
        public IFlashing callback;

        public FlashingForm()
        {
            InitializeComponent();
        }

        private void FlashingForm_Load(object sender, EventArgs e)
        {
            timerTurnOff.Enabled = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void timerTurnOff_Tick(object sender, EventArgs e)
        {
            callback.FinishedFlashing();
            this.Close();
        }
    }
}
