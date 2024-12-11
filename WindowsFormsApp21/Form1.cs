using System;
using System.Windows.Forms;


namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "1000";
            Hide();
        }

        private void Hide()
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
            label3.Visible = false;
            label9.Visible = false;
            textBox2.Visible = false;
            guna2Button1.Visible = false;
            guna2Button4.Visible = false;
        }

        string Withdraw()
        {
            int topla;
            topla = Convert.ToInt32(label4.Text) - Convert.ToInt32(textBox2.Text);
            button2.Visible = true;
            return topla.ToString();
        }

        string Deposit()
        {
            int cikart;
            cikart = Convert.ToInt32(label4.Text) + Convert.ToInt32(textBox2.Text);
            button2.Visible = true;
            return cikart.ToString();
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox4.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox4.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            label7.Visible = true;
            textBox4.Visible = true;
            label3.Visible = true;
            label9.Visible = true;
            textBox2.Visible = true;
            guna2Button1.Visible = true;
            guna2Button4.Visible = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // string today = DateTime.Today.ToString("M/d/y");
            try
            {
                if (radioButton1.Checked)
                {
                    label4.Text = Deposit();
                    listBox1.Items.Add("$" + textBox2.Text + " deposited.");
                }
                if (radioButton2.Checked)
                {
                    if (Convert.ToInt32(label4.Text) < Convert.ToInt32(textBox2.Text))
                    {
                        MessageBox.Show("Your balance is not sufficient to make this transaction.");
                    }
                    else
                    {
                        label4.Text = Withdraw();
                        listBox1.Items.Add("$" + textBox2.Text + " withdrawn");
                    }
                }
                if (radioButton3.Checked)
                {
                    label4.Text = Withdraw();
                    listBox1.Items.Add("$" + textBox2.Text + " transferred to " + textBox4.Text);
                }
                if (radioButton4.Checked)
                {
                    label4.Text = Deposit();
                    listBox1.Items.Add("$" + textBox2.Text + " collected from " + textBox4.Text);
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
