using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class guessForm : Form
    {
        public guessForm()
        {
            InitializeComponent();
        }


        public static Random rnd = new Random();
        int randomNumber = rnd.Next(1, 6);

        int wrongNumber;


        private void hintLabel_MouseHover(object sender, EventArgs e)
        {
            switch(wrongNumber)
            {
                case 1:
                    radioButtonOne.Text = "Wrong option";
                    break;
                case 2:
                    radioButtonTwo.Text = "Wrong option";
                    break;
                case 3:
                    radioButtonThree.Text = "Wrong option";
                    break;
                case 4:
                    radioButtonFour.Text = "Wrong option";
                    break;
                case 5:
                    radioButtonFive.Text = "Wrong option";
                    break;
            }
            
        }


        private void hintLabel_MouseLeave(object sender, EventArgs e)
        {
            switch (wrongNumber)
            {
                case 1:
                    radioButtonOne.Text = "1";
                    break;
                case 2:
                    radioButtonTwo.Text = "2";
                    break;
                case 3:
                    radioButtonThree.Text = "3";
                    break;
                case 4:
                    radioButtonFour.Text = "4";
                    break;
                case 5:
                    radioButtonFive.Text = "5";
                    break;
            }
        }

        private void radioButtonOne_CheckedChanged(object sender, EventArgs e)
        {
            if(randomNumber == 1)
            {
                infoLabel.Text = "Great guess you win!";
                radioButtonTwo.Enabled = false;
                radioButtonThree.Enabled = false;
                radioButtonFour.Enabled = false;
                radioButtonFive.Enabled = false;
            }
            else
            {
                infoLabel.Text = $"Sorry you were not correct.\nThe correct number was {randomNumber}";
                radioButtonTwo.Enabled = false;
                radioButtonThree.Enabled = false;
                radioButtonFour.Enabled = false;
                radioButtonFive.Enabled = false;
            }
        }

        

        private void radioButtonTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (randomNumber == 2)
            {
                infoLabel.Text = "Great guess you win!";
                radioButtonOne.Enabled = false;
                radioButtonThree.Enabled = false;
                radioButtonFour.Enabled = false;
                radioButtonFive.Enabled = false;
            }
            else
            {
                infoLabel.Text = $"Sorry you were not correct.\nThe correct number was {randomNumber}";
                radioButtonOne.Enabled = false;
                radioButtonThree.Enabled = false;
                radioButtonFour.Enabled = false;
                radioButtonFive.Enabled = false;
            }
        }

        private void radioButtonThree_CheckedChanged(object sender, EventArgs e)
        {
            if (randomNumber == 3)
            {
                infoLabel.Text = "Great guess you win!";
                radioButtonOne.Enabled = false;
                radioButtonTwo.Enabled = false;
                radioButtonFour.Enabled = false;
                radioButtonFive.Enabled = false;
            }
            else
            {
                infoLabel.Text = $"Sorry you were not correct.\nThe correct number was {randomNumber}";
                radioButtonOne.Enabled = false;
                radioButtonTwo.Enabled = false;
                radioButtonFour.Enabled = false;
                radioButtonFive.Enabled = false;
            }
        }

        private void radioButtonFour_CheckedChanged(object sender, EventArgs e)
        {
            if (randomNumber == 4)
            {
                infoLabel.Text = "Great guess you win!";
                radioButtonOne.Enabled = false;
                radioButtonTwo.Enabled = false;
                radioButtonThree.Enabled = false;
                radioButtonFive.Enabled = false;
            }
            else
            {
                infoLabel.Text = $"Sorry you were not correct.\nThe correct number was {randomNumber}";
                radioButtonOne.Enabled = false;
                radioButtonTwo.Enabled = false;
                radioButtonThree.Enabled = false;
                radioButtonFive.Enabled = false;
            }
        }

        private void radioButtonFive_CheckedChanged(object sender, EventArgs e)
        {
            if (randomNumber == 5)
            {
                infoLabel.Text = "Great guess you win!";
                radioButtonOne.Enabled = false;
                radioButtonTwo.Enabled = false;
                radioButtonThree.Enabled = false;
                radioButtonFour.Enabled = false;
            }
            else
            {
                infoLabel.Text = $"Sorry you were not correct.\nThe correct number was {randomNumber}";
                radioButtonOne.Enabled = false;
                radioButtonTwo.Enabled = false;
                radioButtonThree.Enabled = false;
                radioButtonFour.Enabled = false;
            }
        }

        private void guessForm_Load(object sender, EventArgs e)
        {
            wrongNumber = rnd.Next(1, 6);

            while(wrongNumber == randomNumber)
            {
                wrongNumber = rnd.Next(1, 6);
            }
        }
    }
}
