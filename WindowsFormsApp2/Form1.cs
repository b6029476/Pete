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
using MyDialogs;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ClickCount = -1;
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
        private void richTextBox2_TextChanged(object sender, EventArgs e)
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // https://msdn.microsoft.com/en-us/library/system.windows.forms.savefiledialog(v=vs.110).aspx
                    myStream.Close();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = "c:\\",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ////http://stackoverflow.com/questions/13900441/c-sharp-read-txt-file-into-textbox
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Multi-Press")
            {
                ClickCount++;
                int index = Convert.ToInt16(ClickCount);
                richTextBox2.AppendText(listBox1.Items[index].ToString());
                //resets the click count so it can loop again boi
                if (ClickCount == 6)
                {
                    ClickCount = -1;
                }
            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Multi-Press")
            {
                ClickCount++;
                int index = Convert.ToInt16(ClickCount);
                richTextBox2.AppendText(listBox2.Items[index].ToString());
                //resets the click count so it can loop again boi
                if (ClickCount == 6)
                {
                    ClickCount = -1;
                }
            }
            else
            {

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "Multi-Press")
                {
                    ClickCount++;
                    int index = Convert.ToInt16(ClickCount);
                    richTextBox2.AppendText(listBox3.Items[index].ToString());
                    //resets the click count so it can loop again boi
                    if (ClickCount == 6)
                    {
                        ClickCount = -1;
                    }
                }
                else
                {

                }
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "Multi-Press")
                {
                    ClickCount++;
                    int index = Convert.ToInt16(ClickCount);
                    richTextBox2.AppendText(listBox4.Items[index].ToString());
                    //resets the click count so it can loop again boi
                    if (ClickCount == 6)
                    {
                        ClickCount = -1;
                    }
                }
                else
                {

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "Multi-Press")
                {
                    ClickCount++;
                    int index = Convert.ToInt16(ClickCount);
                    richTextBox2.AppendText(listBox5.Items[index].ToString());
                    //resets the click count so it can loop again boi
                    if (ClickCount == 6)
                    {
                        ClickCount = -1;
                    }
                }
                else
                {

                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Multi-Press")
            {
                ClickCount++;
                int index = Convert.ToInt16(ClickCount);
                richTextBox2.AppendText(listBox6.Items[index].ToString());
                //resets the click count so it can loop again boi
                if (ClickCount == 6)
                {
                    ClickCount = -1;
                }
            }
            else
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Multi-Press")
            {
                ClickCount++;
                int index = Convert.ToInt16(ClickCount);
                richTextBox2.AppendText(listBox7.Items[index].ToString());
                //resets the click count so it can loop again boi
                if (ClickCount == 6)
                {
                    ClickCount = -1;
                }
            }
            else
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Multi-Press")
            {
                ClickCount++;
                int index = Convert.ToInt16(ClickCount);
                richTextBox2.AppendText(listBox8.Items[index].ToString());
                //resets the click count so it can loop again boi
                if (ClickCount == 6)
                {
                    ClickCount = -1;
                }
            }
            else
            {

            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Multi-Press")
            {
                ClickCount++;
                int index = Convert.ToInt16(ClickCount);
                richTextBox2.AppendText(listBox9.Items[index].ToString());
                //resets the click count so it can loop again boi
                if (ClickCount == 6)
                {
                    ClickCount = -1;
                }
            }
            else
            {

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Multi-Press")
            {
                ClickCount++;
                int index = Convert.ToInt16(ClickCount);
                richTextBox2.AppendText(listBox10.Items[index].ToString());
                //resets the click count so it can loop again boi
                if (ClickCount == 6)
                {
                    ClickCount = -1;
                }
            }
            else
            {

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Multi-Press")// as long as the text variable is that then this will occur
            {
                ClickCount++;
                int index = Convert.ToInt16(ClickCount);
                richTextBox2.AppendText(listBox11.Items[index].ToString());
                //resets the click count so it can loop again boi
                if (ClickCount == 6)
                {
                    ClickCount = -1;
                }
            }
            else
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = richTextBox2.Rtf;// applies the user input code to the large text box
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();// restarts the application
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My_Dialogs.InputBox("Please enter the delay value you require 1000 is equal to a 1 second delay at the present the delay is set to 500.");
        }
    }
}






