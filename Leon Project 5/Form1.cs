using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leon_Project_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Computer randomly chooses between rock, paper, scissors
        private string compChoose()
        {
            Random rand = new Random();

            int randNum = rand.Next(3) + 1;

            if (randNum == 1)
            {
                return "Rock";
            }
            else if (randNum == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

        //Determines who the winner is
        private char getWinner(string playerChoice, string compChoice)
        {
            if(playerChoice == compChoice)
            {
                return 'D';
            }
            else if (playerChoice == "Rock")
            {
                if (compChoice == "Paper")
                {
                    return 'C';
                }
                else //compChoice must be Scissors
                {
                    return 'P';
                }
            }
            else if (playerChoice == "Paper")
            {
                if (compChoice == "Rock")
                {
                    return 'P';
                }
                else //compChoice must be Scissors
                {
                    return 'C';
                }
            }
            else if (playerChoice == "Scissors")
            {
                if (compChoice == "Rock")
                {
                    return 'C';
                }
                else //compChoice must be Paper
                {
                    return 'P';
                }
            }

            return 'E';
        }

        //Changes the image in the computer panel and displays the game messages
        private void display(string playChoice, string compChoice, char winner)
        {
            if (compChoice == "Rock")
            {
                compPicBox.BackgroundImage = global::Leon_Project_5.Properties.Resources.rock3;
            }
            else if (compChoice == "Paper")
            {
                compPicBox.BackgroundImage = global::Leon_Project_5.Properties.Resources.paper3;
            }
            else if (compChoice == "Scissors")
            {
                compPicBox.BackgroundImage = global::Leon_Project_5.Properties.Resources.scissors3;
            }

            if (winner == 'D')
            {
                outputLabel1.Text = "";
                outputLabel2.Text = "";
                outputLabel3.Text = "";
                outputLabel4.Text = "Draw";
            }
            else if (winner == 'P')
            {
                if (playChoice == "Rock")
                {
                    outputLabel1.Text = "Rock";
                    outputLabel2.Text = "crushes";
                    outputLabel3.Text = "Scissors";
                }
                else if (playChoice == "Paper")
                {
                    outputLabel1.Text = "Paper";
                    outputLabel2.Text = "covers";
                    outputLabel3.Text = "Rock";
                }
                else if (playChoice == "Scissors")
                {
                    outputLabel1.Text = "Scissors";
                    outputLabel2.Text = "cut";
                    outputLabel3.Text = "Paper";
                }
                outputLabel4.Text = "Player Wins";
            }
            else if (winner == 'C')
            {
                if (compChoice == "Rock")
                {
                    outputLabel1.Text = "Rock";
                    outputLabel2.Text = "crushes";
                    outputLabel3.Text = "Scissors";
                }
                else if (compChoice == "Paper")
                {
                    outputLabel1.Text = "Paper";
                    outputLabel2.Text = "covers";
                    outputLabel3.Text = "Rock";
                }
                else if (compChoice == "Scissors")
                {
                    outputLabel1.Text = "Scissors";
                    outputLabel2.Text = "cut";
                    outputLabel3.Text = "Paper";
                }
                outputLabel4.Text = "Computer Wins";
            }
        }

        //Updates the scoreboard
        private void scoreDisplay(char winner)
        {
            playerScoreLabel.ForeColor = Color.Black;
            drawScoreLabel.ForeColor = Color.Black;
            compScoreLabel.ForeColor = Color.Black;

            if (winner == 'D')
            {
                drawScoreLabel.ForeColor = Color.Red;
                drawScoreLabel.Text = (int.Parse(drawScoreLabel.Text) + 1).ToString();
            }
            else if (winner == 'P')
            {
                playerScoreLabel.ForeColor = Color.Red;
                playerScoreLabel.Text = (int.Parse(playerScoreLabel.Text) + 1).ToString();
            }
            else if (winner == 'C')
            {
                compScoreLabel.ForeColor = Color.Red;
                compScoreLabel.Text = (int.Parse(compScoreLabel.Text) + 1).ToString();
            }
        }

        //The 'main' for the game.  It is called every time the player chooses rock, paper, or scissors.
        //The player's choice is sent to this function according to which button the player clicks.
        private void game(string playerChoice)
        {
            string compChoice = compChoose();  //Computer chooses rock, paper, or scissors

            char winner = getWinner(playerChoice, compChoice);  //Determine the winner

            scoreDisplay(winner);   //Update the scoreboard

            display(playerChoice, compChoice, winner);  //Display the computer's choice and display the winner
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            this.playerPicBox.BackgroundImage = global::Leon_Project_5.Properties.Resources.rock3;
            game("Rock");
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            this.playerPicBox.BackgroundImage = global::Leon_Project_5.Properties.Resources.paper3;
            game("Paper");
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            this.playerPicBox.BackgroundImage = global::Leon_Project_5.Properties.Resources.scissors3;
            game("Scissors");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Reset the game to starting conditions
        private void resetButton_Click(object sender, EventArgs e)
        {
            drawScoreLabel.Text = "0";
            playerScoreLabel.Text = "0";
            compScoreLabel.Text = "0";
            outputLabel1.Text = "";
            outputLabel2.Text = "";
            outputLabel3.Text = "";
            outputLabel4.Text = "";

            this.playerPicBox.BackgroundImage = null;
            this.compPicBox.BackgroundImage = null;

            playerScoreLabel.ForeColor = Color.Black;
            drawScoreLabel.ForeColor = Color.Black;
            compScoreLabel.ForeColor = Color.Black;
        }
    }
}
