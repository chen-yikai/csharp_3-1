using System;
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
            int resNum = 0;
            for (int i = myNumber; i <= 71; i++)
            {
                resNum += i;
            }
            myNumPluser.Text = resNum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resNums = "";
            for (int i = 4; i <= 207; i++)
            {
                if (i % 7 == 0)
                {
                    resNums += i.ToString() + " ";
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
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    increase3.Text += "*";
                }
                increase3.Text += "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    box.Text += $"{j}*{i}={i * j}\t";
                }
                box.Text += "\r\n";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult question;

            do
            {
                question = MessageBox.Show("Javascript better than Typescript?", "Simple Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    MessageBox.Show("Awsome!");
                }
                else
                {
                    MessageBox.Show("Try again!");
                }
            } while (question != DialogResult.Yes);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(bornYear.Text);
                if (input <= 113 && input >= 1)
                {
                    String res = "";
                    switch (input % 12)
                    {
                        case 1: res = "鼠"; break;
                        case 2: res = "牛"; break;
                        case 3: res = "虎"; break;
                        case 4: res = "兔"; break;
                        case 5: res = "龍"; break;
                        case 6: res = "蛇"; break;
                        case 7: res = "馬"; break;
                        case 8: res = "羊"; break;
                        case 9: res = "猴"; break;
                        case 10: res = "雞"; break;
                        case 11: res = "狗"; break;
                        case 0: res = "豬"; break;
                    }
                    MessageBox.Show($"您現在年齡是{113 - input}\n生肖屬{res}", "查詢結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Wrong input");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("錯誤的輸入", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bornYear.Text = "";
            bornYear.Focus();
        }
    }
}
