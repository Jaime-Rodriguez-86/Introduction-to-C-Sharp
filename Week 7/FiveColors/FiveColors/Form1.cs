using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveColors
{
    public partial class colorForm : Form
    {
        public colorForm()
        {
            InitializeComponent();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
