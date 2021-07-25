using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string textboxtext = textBox1.Text;
            string num_before_plus = textboxtext.Substring(0, textboxtext.IndexOf("+"));
            string num_after_plus = textboxtext.Substring(textboxtext.LastIndexOf("+") + 1);
            int a = Convert.ToInt32(num_before_plus);
            int b = Convert.ToInt32(num_after_plus);
            label1.Text = Convert.ToString(a+b);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += 4;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += 6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += 7;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += 8;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "9";
        }

        private void Plusbutton_Click(object sender, EventArgs e)
        {
            string textboxtext = textBox1.Text;
            string laststr = textboxtext.Substring(textboxtext.Length - 1);
            if (textboxtext.Length > 0 && textboxtext[0] != ('.') && laststr.ToString() != "+")
            {
                textBox1.SelectedText += "+";
            }
            else if (label1.Text != "")
            {
                //textBox1.Text = label1.Text;
                // label1.Text = "";
                //textBox1.SelectedText += "+"
            }


            //int jaja = textboxtext.IndexOf("+");
            //string num_before_plus = textboxtext.Substring(0, textboxtext.IndexOf(textBox1.SelectedText));
            //var num_after_plus = textboxtext.Substring(textboxtext.LastIndexOf(textBox1.SelectedText) + 1);
            //label1.Text = num_before_plus + num_after_plus;
            //MessageBox.Show(Convert.ToString(jaja));
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            string textboxtext = textBox1.Text;
            textBox1.SelectedText += 0;
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('.'))
            {
                textBox1.SelectedText += '.';
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string textboxtext = textBox1.Text;
            if (textboxtext.Length > 1)
            {
                textboxtext = textboxtext.Substring(0, textboxtext.Length - 1);
                label1.Text = "";
            }
            else
            {
                textboxtext = "0";
            }
            textBox1.Text = textboxtext;
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
        }
    }
}
