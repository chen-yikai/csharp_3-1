using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countNum_Click(object sender, EventArgs e)
        {
            int myNumber = 27;
            int resNum=0;
            for(int i = myNumber; i <= 71;i++)
            {
                resNum += i;
            }
            myNumPluser.Text = resNum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resNums = "";
            for(int i = 4; i <= 207; i++)
            {
                if(i % 7 == 0)
                {
                    resNums += i.ToString()+" ";
                }
            }
            canDiv.Text = resNums;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    increase1.Text += "*";
                }
                increase1.Text += "\r\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    increase2.Text += "*";
                }
                increase2.Text += "\r\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i = 5; i >= 1; i--)
            {
                for( int j = 0; j < i; j++)
                {
                    increase3.Text += "*";
                }
                increase3.Text += "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    box.Text += $"{j}*{i}={i*j}\t";
                }
                box.Text += "\r\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult question;

            do
            {
               question =  MessageBox.Show("Javascript better than Typescript?", "Simple Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(question == DialogResult.Yes)
                {
                    MessageBox.Show("Awsome!");
                    break;
                }
                else
                {
                    MessageBox.Show("Try again!");
                    continue;
                }
            } while (true);
        }
    }
}
