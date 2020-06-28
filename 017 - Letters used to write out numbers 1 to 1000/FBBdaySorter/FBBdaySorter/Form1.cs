using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FBBdaySorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (textBox1.Text.IndexOf("DTSTART:") >= 0)
            {
                int date = textBox1.Text.IndexOf("DTSTART:");
                int nameStart = textBox1.Text.IndexOf("SUMMARY:");
                int nameEnd = textBox1.Text.IndexOf("RRULE:");
                textBox2.Text += textBox1.Text.Substring(date + 14, 2) + "/";
                textBox2.Text += textBox1.Text.Substring(date + 12, 2) + "/";
                textBox2.Text += textBox1.Text.Substring(date + 8, 4);
                textBox2.Text += ", ";
                textBox2.Text += textBox1.Text.Substring(nameStart + 8, nameEnd - nameStart - 21);
                textBox2.Text += "\r\n";
                int end = textBox1.Text.IndexOf("END:VEVENT") + 10;
                textBox1.Text = textBox1.Text.Remove(0, end);
            }
        }
    }
}
