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
        public int turns = 0, oWins=0, xWins=0, draws=0;

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(button.Text == "")
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

            if(IsADraw())
            {
                MessageBox.Show("Tie Game!");
                draws++;
            }
            
        }

        public Form1()
        {
            InitializeComponent();
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

        private bool IsADraw()
        {
            if(turns == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
