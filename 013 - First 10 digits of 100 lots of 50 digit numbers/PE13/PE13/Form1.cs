using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] array = textBox1.Text.ToCharArray();
            int[,] multiArray = new int[100, 50];
            int[] answer = new int[51];
            int working = 0;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    multiArray[i, j] = int.Parse(array[j + 52 * i].ToString());
                }
            }

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    working = working + multiArray[j, 49-i];
                }

                answer[i] = working % 10;
                int carry = working - (working % 10);
                working = carry/10;

            }
            answer[50] = working;

            for (int i = 50; i >= 0; i--)
            {
                textBox2.Text += answer[i].ToString();
            }

            textBox2.Text += "and the first 10 digits are " + textBox2.Text.Substring(0, 10);
        }
    }
}
