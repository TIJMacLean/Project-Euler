using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] array = textBox1.Text.ToArray();     // Array of original input
            int[] array2 = new int[400];                // Array of integers
            int a = 0;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                // Just get the integers by taking out \r and \n and ' '
                if (int.TryParse(array[i].ToString(), out a))
                {
                    string number = array[i].ToString() + array[i + 1].ToString();
                    array2[counter] = int.Parse(number);
                    counter++;
                    i++;
                }
            }

            int value = 0;
            int greatestValue = 0;

            // Horizontal products
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    value = array2[j * 20 + i] * array2[j * 20 + i + 1] * array2[j * 20 + i + 2] * array2[j * 20 + i + 3];
                    if (value > greatestValue)
                    {
                        greatestValue = value;
                    }
                }
            }

            // Vertical products
            for (int j = 0; j < 17; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    value = array2[j * 20 + i] * array2[(j + 1) * 20 + i] * array2[(j + 2) * 20 + i] * array2[(j + 3) * 20 + i];
                    if (value > greatestValue)
                    {
                        greatestValue = value;
                    }
                }
            }

            // Diagonal products : down right
            for (int j = 0; j < 17; j++)
            {
                for (int i = 0; i < 17; i++)
                {
                    value = array2[j * 20 + i] * array2[(j + 1) * 20 + (i + 1)] * array2[(j + 2) * 20 + (i + 2)] * array2[(j + 3) * 20 + (i + 3)];
                    if (value > greatestValue)
                    {
                        greatestValue = value;
                    }
                }
            }

            // Diagonal products : down left
            for (int j = 0; j < 17 ; j++)
            {
                for (int i = 3; i < 20; i++)
                {
                    value = array2[j * 20 + i] * array2[(j + 1) * 20 + (i - 1)] * array2[(j + 2) * 20 + (i - 2)] * array2[(j + 3) * 20 + (i - 3)];
                    if (value > greatestValue)
                    {
                        greatestValue = value;
                    }
                }
            }



            textBox2.Text = greatestValue.ToString();
        }
    }
}
