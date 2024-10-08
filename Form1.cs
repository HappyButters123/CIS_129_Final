using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_129_Final
{
    public partial class Form1 : Form
    {
        String Answer = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //changes text on button
            if(Answer  == radioButton2.Text) {
                button1.Text = "Right";
            }
            else {
                button1.Text = "Wrong";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Answer = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Answer = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Answer = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Answer = radioButton4.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "What color is the sky?";
        }
    }
}
