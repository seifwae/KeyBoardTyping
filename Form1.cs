using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardTyping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {
         
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    btn1.BackColor = Color.Green;
                    break;
                case Keys.D2:
                    btn2.BackColor = Color.Green;
                    break;
                case Keys.D3:
                    btn3.BackColor = Color.Green;
                    break;
                case Keys.D4:
                    btn4.BackColor = Color.Green;
                    break;
                case Keys.D5:
                    btn5.BackColor = Color.Green;
                    break;
                case Keys.D6:
                    btn6.BackColor = Color.Green;
                    break;
                case Keys.D7:
                    btn7.BackColor = Color.Green;
                    break;
                case Keys.D8:
                    btn8.BackColor = Color.Green;
                    break;
                case Keys.D9:
                    btn9.BackColor = Color.Green;
                    break;
                case Keys.D0:
                    btn0.BackColor = Color.Green;
                    break;
               // case Keys.D!:

                default:
                    break;
            }


            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    btn1.BackColor = Color.Transparent;
                    break;
                case Keys.D2:
                    btn2.BackColor = Color.Transparent;
                    break;
                case Keys.D3:
                    btn3.BackColor = Color.Transparent;
                    break;
                case Keys.D4:
                    btn4.BackColor = Color.Transparent;
                    break;
                case Keys.D5:
                    btn5.BackColor =  Color.Transparent;
                    break;
                case Keys.D6:
                    btn6.BackColor =  Color.Transparent;
                    break;
                case Keys.D7:
                    btn7.BackColor =  Color.Transparent;
                    break;
                case Keys.D8:
                    btn8.BackColor =  Color.Transparent;
                    break;
                case Keys.D9:
                    btn9.BackColor =  Color.Transparent;
                    break;
                default:
                    break;
            }
        }
    }
}
