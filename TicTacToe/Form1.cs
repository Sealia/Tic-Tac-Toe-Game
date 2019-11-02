using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public int player = 2;
        public int turns = 0, oWins = 0, xWins = 0, draws = 0;
        Button[,] buttons;

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }
            }

            if (CheckWinner())
            {
                MessageBox.Show("The Winner is " + button.Text);
                if(button.Text=="X")
                {
                    xWins++;
                    Xwins.Text ="X wins: " + xWins;
                }
                else
                {
                    oWins++;
                    Owins.Text ="O wins: " + oWins;
                }

                for(int i=0; i<3;i++)
                {
                    for(int j=0; j<3; j++)
                    {
                        buttons[i, j].Enabled = false;
                    }
                }
                turns++;
            }

            if (IsADraw())
            {
                MessageBox.Show("Tie Game!");
                draws++;
                Draws.Text = "Draws: " + draws;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        buttons[i, j].Enabled = false;
                    }
                }
            }

        }

        public Form1()
        {
            InitializeComponent();

            buttons = new Button[3, 3] {
            { A00,A01,A02},
            { A10,A11,A12},
            { A20,A21,A22},
        };
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Xwins.Text += " " + xWins;
            Owins.Text += " " + oWins;
            Draws.Text += " " + draws;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A11.Text = A12.Text = A10.Text = A20.Text = A21.Text = A22.Text = "";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            NewGame();
            draws = xWins = oWins = 0;
        }

        private bool IsADraw()
        {
            if (turns == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckWinner()
        {
            for(int i=0;i<3;i++)
            {
                if(i==0 && buttons[i,i].Text!="")
                {
                    if (buttons[i, i].Text == buttons[i + 1, i + 1].Text && buttons[i, i].Text == buttons[i + 2, i + 2].Text)
                    {
                        return true;
                    }
                }
                if(buttons[i,0].Text==buttons[i,1].Text && buttons[i,0].Text == buttons[i,2].Text && buttons[i,0].Text !="")
                {
                    return true;
                }
                if(buttons[0,i].Text == buttons[1,i].Text && buttons[0,i].Text == buttons[2,i].Text && buttons[0,i].Text!="")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
