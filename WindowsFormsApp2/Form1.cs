using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int constant = 0;

        // Timing Functionality
        bool boolFirstVisit = true;
        int intIntervalRequired = 500;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Multi-Press")
            {
                textBox1.Text = "Prediction";
            }
            else if (textBox1.Text == "Prediction")
            {
                textBox1.Text = "Multi-Press";
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
