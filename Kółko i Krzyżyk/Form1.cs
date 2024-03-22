using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_Krzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true;
        int ruch = 0;  
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {
            Restartuj();
            WynikO.Text = "0";
            WynikX.Text = "0";
            labelKto.Text = "O";
            gracz1 = true;
        }
        private void Restartuj()
        {
            ruch = 0;
            Button[] all = new Button[9];
            all[0] = button1; 
            all[1] = button2; 
            all[2] = button3; 
            all[3] = button4; 
            all[4] = button5; 
            all[5] = button6; 
            all[6] = button7; 
            all[7] = button8; 
            all[8] = button9; 

            for(int i = 0; i < 9 ; i++)
            {
                all[i].Enabled = true;
                all[i].Text = "";
            }
        }
        private void Sprawdz()
        {
            //Sprawdzenie 1. poziomo
            if (button1.Text != "" && button1.Text == button2.Text &&
                button2.Text == button3.Text)
            {
                Wygrana();
            }
            //Sprawdzenie 2. poziomo
            else if (button4.Text != "" && button4.Text == button5.Text &&
                button5.Text == button6.Text)
            {
                Wygrana();
            }
            //Sprawdzenie 3. poziomo
            else if (button7.Text != "" && button7.Text == button8.Text &&
                button8.Text == button9.Text)
            {
                Wygrana();
            }
            //Sprawdzenie 1. pionowo
            else if (button1.Text != "" && button1.Text == button4.Text &&
                button4.Text == button7.Text)
            {
                Wygrana();
            }
            //Sprawdzenie 2. pionowo
            else if (button2.Text != "" && button2.Text == button5.Text &&
                button5.Text == button8.Text)
            {
                Wygrana();
            }
            //Sprawdzenie 3. pionowo
            else if (button3.Text != "" && button3.Text == button6.Text &&
                button6.Text == button9.Text)
            {
                Wygrana();
            }
            //Sprawdzenie 1. po skosie 
            else if (button1.Text != "" && button1.Text == button5.Text &&
                button5.Text == button9.Text)
            {
                Wygrana();
            }
            //Sprawdzenie 2. po skosie 
            else if (button3.Text != "" && button3.Text == button5.Text &&
                button5.Text == button7.Text)
            {
                Wygrana();
            }
            //Remis
            else if (ruch == 9)
            {
                MessageBox.Show("Remis. Każdy gracz dostaje po pół punktu", "Koniec Gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WynikO.Text = ((double.Parse(WynikO.Text)) + 0.5).ToString();
                WynikX.Text = ((double.Parse(WynikX.Text)) + 0.5).ToString();
                Restartuj();
            }
            
        }
        private void Wygrana()
        {
            if (gracz1 == true)
            {
                MessageBox.Show("Wygrywa Gracz: O", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WynikO.Text = ((double.Parse(WynikO.Text)) + 1).ToString();
            }
            else if (gracz1 == false)
            {
                MessageBox.Show("Wygrywa Gracz: X", "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                WynikX.Text = ((double.Parse(WynikX.Text)) + 1).ToString();
            } 
            Restartuj();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1 == true)
                button1.Text = "O";
            else if (gracz1 == false)
                button1.Text = "X";
            button1.Enabled = false;

            if (ruch >= 5)
                Sprawdz();

            gracz1 = !gracz1;

            if (gracz1 == true)
                labelKto.Text = "O";
            else if (gracz1 == false)
                labelKto.Text = "X";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1 == true)
                button2.Text = "O";
            else if (gracz1 == false)
                button2.Text = "X";
            button2.Enabled = false;

            if (ruch >= 5)
                Sprawdz();

            gracz1 = !gracz1;

            if (gracz1 == true)
                labelKto.Text = "O";
            else if (gracz1 == false)
                labelKto.Text = "X";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1 == true)
                button3.Text = "O";
            else if (gracz1 == false)
                button3.Text = "X";
            button3.Enabled = false;

            if (ruch >= 5)
                Sprawdz();

            gracz1 = !gracz1;

            if (gracz1 == true)
                labelKto.Text = "O";
            else if (gracz1 == false)
                labelKto.Text = "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1 == true)
                button4.Text = "O";
            else if (gracz1 == false)
                button4.Text = "X";
            button4.Enabled = false;

            if (ruch >= 5)
                Sprawdz();

            gracz1 = !gracz1;

            if (gracz1 == true)
                labelKto.Text = "O";
            else if (gracz1 == false)
                labelKto.Text = "X";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1 == true)
                button5.Text = "O";
            else if (gracz1 == false)
                button5.Text = "X";
            button5.Enabled = false;

            if (ruch >= 5)
                Sprawdz();

            gracz1 = !gracz1;

            if (gracz1 == true)
                labelKto.Text = "O";
            else if (gracz1 == false)
                labelKto.Text = "X";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1 == true)
                button6.Text = "O";
            else if (gracz1 == false)
                button6.Text = "X";
            button6.Enabled = false;

            if (ruch >= 5)
                Sprawdz();

            gracz1 = !gracz1;

            if (gracz1 == true)
                labelKto.Text = "O";
            else if (gracz1 == false)
                labelKto.Text = "X";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1 == true)
                button7.Text = "O";
            else if (gracz1 == false)
                button7.Text = "X";
            button7.Enabled = false;

            if (ruch >= 5)
                Sprawdz();

            gracz1 = !gracz1;

            if (gracz1 == true)
                labelKto.Text = "O";
            else if (gracz1 == false)
                labelKto.Text = "X";
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1 == true)
                button8.Text = "O";
            else if (gracz1 == false)
                button8.Text = "X";
            button8.Enabled = false;

            if (ruch >= 5)
                Sprawdz();

            gracz1 = !gracz1;

            if (gracz1 == true)
                labelKto.Text = "O";
            else if (gracz1 == false)
                labelKto.Text = "X";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ruch++;
            if (gracz1 == true)
                button9.Text = "O";
            else if (gracz1 == false)
                button9.Text = "X";
            button9.Enabled = false;

            if (ruch >= 5)
                Sprawdz();

            gracz1 = !gracz1;

            if (gracz1 == true)
                labelKto.Text = "O";
            else if (gracz1 == false)
                labelKto.Text = "X";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
