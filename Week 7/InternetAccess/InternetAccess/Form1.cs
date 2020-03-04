using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetAccess
{
    public partial class internetForm : Form
    {
        public internetForm()
        {
            InitializeComponent();
        }

        private void servicesButton_Click(object sender, EventArgs e)
        {
            DialogResult no = MessageBox.Show("Do you want \"The Best\" Internet?", "\"The Best\" Internet", MessageBoxButtons.YesNo);

            if (no == DialogResult.No)
            {
                DialogResult final = MessageBox.Show("Your total price is $0.", "\"The Best\" Internet", MessageBoxButtons.OK);
                Application.Exit();
            }

            else
            {
                DialogResult yes = MessageBox.Show("Limited Service: $10.96/month \nUnlimited Service: $19.95/month \n\nDo you want Unlimited Service?", "\"The Best\" Internet", MessageBoxButtons.YesNo);


                if (yes == DialogResult.Yes)
                {
                    DialogResult final = MessageBox.Show("UNLIMITED ACCESS \n\nGreat Choice! \nYour price is $19.95. \n\nThank you!", "\"The Best\" Internet", MessageBoxButtons.OK);
                    Application.Exit();
                }

                else
                {
                    DialogResult final = MessageBox.Show("LIMITED ACCESS \n\nGreat Choice! \nYour price is $10.95. \n\nThank you!", "\"The Best\" Internet", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
    }
}
