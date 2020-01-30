/*
*
* Student Jaime Rodriguez
* Bellevue University
* CIS355
*
*/
/* File EmployeeSalary.cs */
/*
* Assignment 2.2
* Purpose: Provide a user with their
* future salary based on their current
* salary and a 4% pay increase
*
* To compile the program:
* csc EmployeeSalary.cs
* 
* 
* To execute the program:
* EmployeeSalary.exe (.exe optional)
*
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class EmployeeSalaryForm : Form
    {
        public EmployeeSalaryForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            double userSalary;
            double payIncrease;
            double sum;
            userSalary = Convert.ToDouble(currentSalaryTextBox.Text);
            payIncrease = .04;
            sum = (userSalary * payIncrease) + userSalary;
            futureSalaryLabel.Text = String.Format("Your salary next year will be :\n{0}", sum.ToString("C"));

        }
    }
}
