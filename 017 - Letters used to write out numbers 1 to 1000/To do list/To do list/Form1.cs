using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace To_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                checkedListBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
            }
            int j = checkedListBox1.CheckedItems.Count;
            for (int i = 0; i < j; i++)
            {
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    checkedListBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                }   
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.BringToFront();
        }
    }
}
