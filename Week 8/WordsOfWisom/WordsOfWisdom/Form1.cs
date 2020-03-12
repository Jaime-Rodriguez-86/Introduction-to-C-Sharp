using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWisdom
{
    public partial class wisdomForm : Form
    {
        public wisdomForm()
        {
            InitializeComponent();
        }

        private void strengthLabel_MouseHover(object sender, EventArgs e)
        {
            strengthLabel.Text = "THAT WHICH DOES\nNOT KILL US MAKES\nUS STRONGER";
            strengthLabel.Font = new System.Drawing.Font("Sans Sarif", 14F, System.Drawing.FontStyle.Italic);
            strengthLabel.ForeColor = Color.White;
        }
        private void strengthLabel_MouseLeave(object sender, EventArgs e)
        {
            strengthLabel.ForeColor = Color.Black;
        }

        
        private void honorLabel_MouseHover(object sender, EventArgs e)
        {
            honorLabel.Text = "IT IS NOT TITLES THAT\nHONOR MEN BUT MEN\nTHAT HONOR TITLES";
            honorLabel.Font = new System.Drawing.Font("Sans Sarif", 14F, System.Drawing.FontStyle.Italic);
            honorLabel.ForeColor = Color.White;
        }

        private void honorLabel_MouseLeave(object sender, EventArgs e)
        {
            honorLabel.ForeColor = Color.Black;
        }

        private void trustLabel_MouseHover(object sender, EventArgs e)
        {
            trustLabel.Text = "LOVE ALL. TRUST FEW.\nDO WRONG TO NONE";
            trustLabel.Font = new System.Drawing.Font("Sans Sarif", 14F, System.Drawing.FontStyle.Italic);
            trustLabel.ForeColor = Color.White;
        }

        private void trustLabel_MouseLeave(object sender, EventArgs e)
        {
            trustLabel.ForeColor = Color.Black;
        }

        private void fearLabel_MouseHover(object sender, EventArgs e)
        {
            fearLabel.Text = "FEAR HAS A LARGE\nSHADOW, BUT HE\nHIMSELF IS SMALL";
            fearLabel.Font = new System.Drawing.Font("Sans Sarif", 14F, System.Drawing.FontStyle.Italic);
            fearLabel.ForeColor = Color.White;
        }

        private void fearLabel_MouseLeave(object sender, EventArgs e)
        {
            fearLabel.ForeColor = Color.Black;
        }

        
    }
}
