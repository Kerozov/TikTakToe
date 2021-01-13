using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class TicTacToe : Form
    {
        bool turn = true;
        int turn_count = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }
        private void aboutToolScripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Zefir", "Form 1 Abaout");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Zefir", "TicTacToe Abaout");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            
                b.Text = "X";
            
            else
            
                b.Text = "O";

            turn=!turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }
        private void checkForWinner()
        {
            bool there_winner = false;
            if ((A1.Text==A2.Text)&&(A2.Text==A3.Text)&&(!A1.Enabled))
            {
                there_winner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text)&&(!C1.Enabled))
            {
                there_winner = true;
            }
           else  if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&& (!B1.Enabled))
            {
                there_winner = true;
            }

            //
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                there_winner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                there_winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                there_winner = true;
            }
            //

           else  if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                there_winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                there_winner = true;
            }
            
            //
            if (there_winner)
            {
                disableButtons();
                string winner = "";
                if (turn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }
                MessageBox.Show(winner+" Wins!","Yay!");
            }
            else
            {
                if (turn_count==9)
                {
                    MessageBox.Show("Draw!","Bunner" );
                }
            }
        }
        private void disableButtons()
        {
            try
            {
                foreach (var c in this.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (var c in this.Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }

            }
            catch { }
        }
    }
}
