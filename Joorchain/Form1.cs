using System;
using System.Windows.Forms;

namespace Joorchain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = button8.Text;
                button8.Text = "";
            }
            if (button7.Text == "")
            {
                button7.Text = button8.Text;
                button8.Text = "";
            }

            if (button9.Text == "")
            {
                button9.Text = button8.Text;
                button8.Text = "";
            }
            Vis_Btn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
            }
            if (button4.Text == "")
            {
                button4.Text = button1.Text;
                button1.Text = "";
            }
            Vis_Btn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
            }
            if (button3.Text == "")
            {
                button3.Text = button2.Text;
                button2.Text = "";
            }

            if (button5.Text == "")
            {
                button5.Text = button2.Text;
                button2.Text = "";
            }
            Vis_Btn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button3.Text;
                button3.Text = "";
            }
            Vis_Btn();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = button4.Text;
                button4.Text = "";
            }
            if (button5.Text == "")
            {
                button5.Text = button4.Text;
                button4.Text = "";
            }

            if (button7.Text == "")
            {
                button7.Text = button4.Text;
                button4.Text = "";
            }
            Vis_Btn();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = button5.Text;
                button5.Text = "";
            }
            if (button6.Text == "")
            {
                button6.Text = button5.Text;
                button5.Text = "";
            }

            if (button4.Text == "")
            {
                button4.Text = button5.Text;
                button5.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button5.Text;
                button5.Text = "";
            }
            Vis_Btn();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = button6.Text;
                button6.Text = "";
            }

            if (button5.Text == "")
            {
                button5.Text = button6.Text;
                button6.Text = "";
            }
            if (button9.Text == "")
            {
                button9.Text = button6.Text;
                button6.Text = "";
            }
            Vis_Btn();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = button7.Text;
                button7.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button7.Text;
                button7.Text = "";
            }
            Vis_Btn();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = button9.Text;
                button9.Text = "";
            }
            if (button8.Text == "")
            {
                button8.Text = button9.Text;
                button9.Text = "";
            }
            Vis_Btn();
        }

        public void Vis_Btn()
        {
            if (button1.Text == "")
            {
                button1.Visible = false;
            }
            else
            {
                button1.Visible = true;
            }

            if (button2.Text == "")
            {
                button2.Visible = false;
            }
            else
            {
                button2.Visible = true;
            }
            if (button3.Text == "")
            {
                button3.Visible = false;
            }
            else
            {
                button3.Visible = true;
            }
            if (button4.Text == "")
            {
                button4.Visible = false;
            }
            else
            {
                button4.Visible = true;
            }
            if (button5.Text == "")
            {
                button5.Visible = false;
            }
            else
            {
                button5.Visible = true;
            }
            if (button6.Text == "")
            {
                button6.Visible = false;
            }
            else
            {
                button6.Visible = true;
            }
            if (button7.Text == "")
            {
                button7.Visible = false;
            }
            else
            {
                button7.Visible = true;
            }
            if (button8.Text == "")
            {
                button8.Visible = false;
            }
            else
            {
                button8.Visible = true;
            }
            if (button9.Text == "")
            {
                button9.Visible = false;
            }
            else
            {
                button9.Visible = true;
            }

        }
    }
}
