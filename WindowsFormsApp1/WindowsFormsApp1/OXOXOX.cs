using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool turn = true; // true x; false o
        int turn_count = 0;
     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void właściwościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To gra w kółko krzyżyk", "Właściwości");
        }

        private void zakończToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
                b.Text = "X";
            else b.Text = "O";
            turn_count++;
            turn = !turn;

            b.Enabled = false;
            winner();

         
            if (turn==true) who.Text = "X";
                else who.Text = "O";


        }

        private void winner ()
        {

            bool is_winner = false;
           
            
                if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                {
                    is_winner = true;
                  
                }
                if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                {
                is_winner = true;
               
                }
                if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                {
                is_winner = true;
              
                }
                if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                {
                is_winner = true;
              
                }
                if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                {
                is_winner = true;
               
                }
                if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                {
                is_winner = true;
                
                }
                if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                {
                is_winner = true;
               
                }
                if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                {
                is_winner = true;                

                }

            string win = "";
            if (turn)
                win = "O";
            else win = "X";

            if (is_winner == true)
            {              
                MessageBox.Show(win + " wygrałeś!");
                disabled();

            } 
                else
            {
                if (turn_count == 9) MessageBox.Show("Nikt nie wygrał");
            }


        }

        private void disabled ()
        {
            A1.Enabled = false;
            A2.Enabled = false;
            A3.Enabled = false;
            B1.Enabled = false;
            B2.Enabled = false;
            B3.Enabled = false;            
            C1.Enabled = false;
            C2.Enabled = false;
            C3.Enabled = false;

        }

      
        private void nowaGraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            who.Text = "X";
            //try
            //{
            //    foreach (Control c in Controls)
            //    {
            //        Button b = (Button)c;
            //        b.Enabled = true;
            //        b.Text = "";
            //    }
            //}
            //catch { }
            A1.Enabled = true;
            A1.Text = "";
            A2.Enabled = true;
            A2.Text = "";
            A3.Enabled = true;
            A3.Text = "";
            B1.Enabled = true;
            B1.Text = "";
            B2.Enabled = true;
            B2.Text = "";
            B3.Enabled = true;
            B3.Text = "";
            C1.Enabled = true;
            C1.Text = "";
            C2.Enabled = true;
            C2.Text = "";
            C3.Enabled = true;
            C3.Text = "";

        }
    }
}
