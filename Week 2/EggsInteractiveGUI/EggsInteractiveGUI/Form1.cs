/*
*
* Student Jaime Rodriguez
* Bellevue University
* CIS355
* 
*/
/* File EggsInteractiveGUI.cs */
/*
* Assignment 2.3
* Purpose: Calculate the number
* of dozens and remainder egss
* based off total given by user
*
* To compile the program:
* csc EggsInteractiveGUI.cs
*
* To execute the program:
* EggsIneractiveGUI.exe (.exe optional)
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

namespace EggsInteractiveGUI
{
    public partial class eggsInteractiveForm : Form
    {
        public eggsInteractiveForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Initialize each inidividual chick as a variable
            int chickenOne;
            int chickenTwo;
            int chickenThree;
            int chickenFour;
            int chickenFive;
            int sum;
            int dozens;
            int remainder;

            //Conver each textbox input into an integer
            chickenOne = Convert.ToInt32(eggsInputOne.Text);
            chickenTwo = Convert.ToInt32(eggsInputTwo.Text);
            chickenThree = Convert.ToInt32(eggsInputThree.Text);
            chickenFour = Convert.ToInt32(eggsInputFour.Text);
            chickenFive = Convert.ToInt32(eggsInputFive.Text);

            //Mathmatical equations to calculate number of dozens and individuals eggs
            sum = chickenOne + chickenTwo + chickenThree + chickenFour + chickenFive;
            dozens = sum / 12;
            remainder = sum % 12;

            totalEggsLabel.Text = "The chickens produced " + dozens +" dozen \nand " + remainder + " egg(s)";

        }
    }
}
