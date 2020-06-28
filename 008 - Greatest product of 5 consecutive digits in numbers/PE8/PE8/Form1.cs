using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PE8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int greatest = 0;
            int working = 0;
            char[] array = textBox1.Text.ToCharArray();
            string[] sArray = new string[textBox1.TextLength];

            for (int i = 0; i < textBox1.TextLength; i++)
            {
                sArray[i] = array[i].ToString();
            }

            int[] intArray = new int[textBox1.TextLength];
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                intArray[i] = Int32.Parse(sArray[i]);
            }

            for (int i = 0; i < textBox1.TextLength - 5; i++)
            {
                working = intArray[i] * intArray[i + 1] * intArray[i + 2] * intArray[i + 3] * intArray[i + 4];
                if (working > greatest)
                {
                    greatest = working;
                }
            }
            textBox2.Text = greatest.ToString();
        }
    }
}
