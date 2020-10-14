using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //On load buttons and textboxs are disabled until the start button is clicked
            playerOneButton.Enabled = false;
            playerTwoButton.Enabled = false;
            playerOneTextBox.Enabled = false;
            playerTwoTextBox.Enabled = false;
            playerOneTextBox.Text = "0";
            playerTwoTextBox.Text = "0";

            //Clearing dice pictures
            diceRollOne.Image = null;
            diceRollTwo.Image = null;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Once the start button is clicked disable it so it cannot be clicked until game is over
            startButton.Enabled = false;

            //Enable player one button
            playerOneButton.Enabled = true;

            //Disable player two button
            playerTwoButton.Enabled = false;

            //Clearing Scores from previous game
            playerOneTextBox.Text = "0";
            playerTwoTextBox.Text = "0";
            rollValueLabel.Text = "Dice Roll Value: ";

            //Clearing dice pictures
            diceRollOne.Image = null;
            diceRollTwo.Image = null;

        }

        private void playerOneButton_Click(object sender, EventArgs e)
        {
            //After click, disable playerOneButton
            playerOneButton.Enabled = false;

            // variables for dice roll
            int DiceRoll1, DiceRoll2, Temp, Score;

            //Grabbing score from payerOneTextBox
            Score = int.Parse(playerOneTextBox.Text);

            //get two random numbers and place in diceroll variables
            Random rnd = new Random();

            DiceRoll1 = rnd.Next(6) + 1;
            DiceRoll2 = rnd.Next(6) + 1;

            //Dice roll Values into temp variable for calculation
            Temp = DiceRoll1 + DiceRoll2;

            //Getting new score after roll
            Score += Temp;

            //Displaying new score
            playerOneTextBox.Text = Score.ToString();

            //Showing roll value
            rollValueLabel.Text = "Dice Roll Value: " + Temp;

            //Displaying dice pictures - dice roll1 pic
            if (DiceRoll1 == 1) {
                diceRollOne.Image = Properties.Resources.Die1;
            }

            if (DiceRoll1 == 2)
            {
                diceRollOne.Image = Properties.Resources.Die2;
            }

            if (DiceRoll1 == 3)
            {
                diceRollOne.Image = Properties.Resources.Die3;
            }

            if (DiceRoll1 == 4)
            {
                diceRollOne.Image = Properties.Resources.Die4;
            }

            if (DiceRoll1 == 5)
            {
                diceRollOne.Image = Properties.Resources.Die5;
            }

            if (DiceRoll1 == 6)
            {
                diceRollOne.Image = Properties.Resources.Die6;
            }

            //Displaying dice pictures - dice roll2 pic
            if (DiceRoll2 == 1)
            {
                diceRollTwo.Image = Properties.Resources.Die1;
            }

            if (DiceRoll2 == 2)
            {
                diceRollTwo.Image = Properties.Resources.Die2;
            }

            if (DiceRoll2 == 3)
            {
                diceRollTwo.Image = Properties.Resources.Die3;
            }

            if (DiceRoll2 == 4)
            {
                diceRollTwo.Image = Properties.Resources.Die4;
            }

            if (DiceRoll2 == 5)
            {
                diceRollTwo.Image = Properties.Resources.Die5;
            }

            if (DiceRoll2 == 6)
            {
                diceRollTwo.Image = Properties.Resources.Die6;
            }

            //Enabling playerTwoButton
            playerTwoButton.Enabled = true;

            //if statement to find winner - and enable start button again
            if (Score >= 50) {
                MessageBox.Show("Player One Wins! Press start to play again");
                startButton.Enabled = true;
            }


        }

        private void playerTwoButton_Click(object sender, EventArgs e)
        {
            //After click, disable playerTwoButton
            playerTwoButton.Enabled = false;

            // variables for dice roll
            int DiceRoll1, DiceRoll2, Temp, Score;

            //Grabbing score from payerOneTextBox
            Score = int.Parse(playerTwoTextBox.Text);

            //get two random numbers and place in diceroll variables
            Random rnd = new Random();

            DiceRoll1 = rnd.Next(6) + 1;
            DiceRoll2 = rnd.Next(6) + 1;

            //Dice roll Values into temp variable for calculation
            Temp = DiceRoll1 + DiceRoll2;

            //Getting new score after roll
            Score += Temp;

            //Displaying new score
            playerTwoTextBox.Text = Score.ToString();

            //Showing roll value
            rollValueLabel.Text = "Dice Roll Value: " + Temp;

            //Enabling playerTwoButton
            playerOneButton.Enabled = true;

            //if statement to find winner - and enable start button again
            if (Score >= 50)
            {
                MessageBox.Show("Player Two Wins! Press start to play again");
                startButton.Enabled = true;
            }

            //Displaying dice pictures - dice roll1 pic
            if (DiceRoll1 == 1)
            {
                diceRollOne.Image = Properties.Resources.Die1;
            }

            if (DiceRoll1 == 2)
            {
                diceRollOne.Image = Properties.Resources.Die2;
            }

            if (DiceRoll1 == 3)
            {
                diceRollOne.Image = Properties.Resources.Die3;
            }

            if (DiceRoll1 == 4)
            {
                diceRollOne.Image = Properties.Resources.Die4;
            }

            if (DiceRoll1 == 5)
            {
                diceRollOne.Image = Properties.Resources.Die5;
            }

            if (DiceRoll1 == 6)
            {
                diceRollOne.Image = Properties.Resources.Die6;
            }

            //Displaying dice pictures - dice roll2 pic
            if (DiceRoll2 == 1)
            {
                diceRollTwo.Image = Properties.Resources.Die1;
            }

            if (DiceRoll2 == 2)
            {
                diceRollTwo.Image = Properties.Resources.Die2;
            }

            if (DiceRoll2 == 3)
            {
                diceRollTwo.Image = Properties.Resources.Die3;
            }

            if (DiceRoll2 == 4)
            {
                diceRollTwo.Image = Properties.Resources.Die4;
            }

            if (DiceRoll2 == 5)
            {
                diceRollTwo.Image = Properties.Resources.Die5;
            }

            if (DiceRoll2 == 6)
            {
                diceRollTwo.Image = Properties.Resources.Die6;
            }
        }
    }
}
