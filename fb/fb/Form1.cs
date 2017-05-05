using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text==">")
            {
                panel1.Hide();
                button1.Text = "<";

            }else if (button1.Text == "<")
            {
                panel1.Show();
                button1.Text = ">";
            }
        }
    }
}
