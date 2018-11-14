using System;
using System.Drawing;
using System.Windows.Forms;

namespace Amőba
{
    public partial class Form1 : Form
    {
        bool player = false;

        bool[] bState = new bool[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bState[0])
            {
                return;
            }
            bState[0] = true;

            if (player)
            {
                button1.BackColor = Color.Red;
            } else
            {
                button1.BackColor = Color.Blue;
            }
            player = !player;

            Check(button1, button2, button3);
            Check(button1,button4,button7);
            Check(button1,button5,button9);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bState[1])
            {
                return;
            }
            bState[1] = true;

            if (player)
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.BackColor = Color.Blue;
            }
            player = !player;

            Check(button1, button2, button3);
            Check(button5, button2, button8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bState[2])
            {
                return;
            }
            bState[2] = true;

            if (player)
            {
                button3.BackColor = Color.Red;
            }
            else
            {
                button3.BackColor = Color.Blue;
            }
            player = !player;

            Check(button1, button2, button3);
            Check(button5, button7, button3);
            Check(button9, button6, button3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bState[5])
            {
                return;
            }
            bState[5] = true;

            if (player)
            {
                button6.BackColor = Color.Red;
            }
            else
            {
                button6.BackColor = Color.Blue;
            }
            player = !player;
            Check(button9, button6, button3);
            Check(button5, button6, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bState[4])
            {
                return;
            }
            bState[4] = true;

            if (player)
            {
                button5.BackColor = Color.Red;
            }
            else
            {
                button5.BackColor = Color.Blue;
            }
            player = !player;

            Check(button4, button5, button6);
            Check(button8, button5, button2);
            Check(button7, button5, button3);
            Check(button9, button5, button1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bState[3])
            {
                return;
            }
            bState[3] = true;

            if (player)
            {
                button4.BackColor = Color.Red;
            }
            else
            {
                button4.BackColor = Color.Blue;
            }
            player = !player;

            Check(button1, button4, button7);
            Check(button6, button4, button5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bState[6])
            {
                return;
            }
            bState[6] = true;

            if (player)
            {
                button7.BackColor = Color.Red;
            }
            else
            {
                button7.BackColor = Color.Blue;
            }
            player = !player;

            Check(button7, button8, button9);
            Check(button7, button1, button4);
            Check(button7, button5, button3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bState[7])
            {
                return;
            }
            bState[7] = true;

            if (player)
            {
                button8.BackColor = Color.Red;
            }
            else
            {
                button8.BackColor = Color.Blue;
            }
            player = !player;

            Check(button7, button8, button9);
            Check(button2, button8, button5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bState[8])
            {
                return;
            }
            bState[8] = true;

            if (player)
            {
                button9.BackColor = Color.Red;
            }
            else
            {
                button9.BackColor = Color.Blue;
            }
            player = !player;

            Check(button1, button5, button9);
            Check(button3, button6, button9);
            Check(button7, button8, button9);
        }

        private void Check(Button _A, Button _B, Button _C)
        {
            if(_A.BackColor == _B.BackColor && _A.BackColor == _C.BackColor)
            {
                MessageBox.Show("The game has ended!");
                Environment.Exit(0);
            }

            int boxes = 0;

            foreach(bool _bool in bState)
            {
                if (_bool)
                {
                    boxes++;
                }
            }

            if(boxes >= 9)
            {
                MessageBox.Show("The game has ended!");
                Environment.Exit(0);
            }
        }
    }
}