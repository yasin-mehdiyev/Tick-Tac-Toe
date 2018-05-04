using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tick_Tack
{
    public partial class Form1 : Form
    {
        List<Button> Clicked = new List<Button>();
        private string step = "X";
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnAll_Click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text==string.Empty)
            {
                Clicked.Add(btn);
                btn.Text = this.step;
                if (this.step=="X")
                {
                    this.step = "O";
                    lblNovbe.Text = this.step;
                }
                else
                {
                    this.step = "X";
                    lblNovbe.Text = this.step;
                }
                Check();             
            }            
        }

        private void Check()
        {
            if (Btn1.Text!=string.Empty && Btn1.Text==Btn2.Text && Btn2.Text==Btn3.Text)
            {
                MessageBox.Show(Btn1.Text+" "+"qalib oldu");
                Score_Count();
            }
            if (Btn4.Text != string.Empty && Btn4.Text == Btn5.Text && Btn5.Text == Btn6.Text)
            {
                MessageBox.Show(Btn4.Text + " " + "qalib oldu");
                Score_Count();
            }
            if (Btn7.Text != string.Empty && Btn7.Text == Btn8.Text && Btn8.Text == Btn9.Text)
            {
                MessageBox.Show(Btn7.Text + " " + "qalib oldu");
                Score_Count();
            }
            if (Btn1.Text != string.Empty && Btn1.Text == Btn4.Text && Btn4.Text == Btn7.Text)
            {
                MessageBox.Show(Btn1.Text + " " + "qalib oldu");
                Score_Count();
            }
            if (Btn2.Text != string.Empty && Btn2.Text == Btn5.Text && Btn5.Text == Btn8.Text)
            {
                MessageBox.Show(Btn2.Text + " " + "qalib oldu");
                Score_Count();
            }
            if (Btn3.Text != string.Empty && Btn3.Text == Btn6.Text && Btn6.Text == Btn9.Text)
            {
                MessageBox.Show(Btn3.Text + " " + "qalib oldu");
                Score_Count();
            }
            if (Btn3.Text != string.Empty && Btn3.Text == Btn5.Text && Btn5.Text == Btn7.Text)
            {
                MessageBox.Show(Btn3.Text + " " + "qalib oldu");
                Score_Count();
            }
            if (Btn1.Text != string.Empty && Btn1.Text == Btn5.Text && Btn5.Text == Btn9.Text)
            {
                MessageBox.Show(Btn1.Text + " " + "qalib oldu");
                Score_Count();
            }
            else if (Btn1.Text != string.Empty && Btn2.Text != string.Empty && Btn3.Text != string.Empty && Btn4.Text != string.Empty && Btn5.Text != string.Empty && Btn6.Text != string.Empty && Btn7.Text != string.Empty && Btn8.Text != string.Empty && Btn9.Text != string.Empty)
            {
                MessageBox.Show("Beraberlik");
                Reset();
            }
        }

        private void Score_Count()
        {
            int xscore = Convert.ToInt32(lblxscore.Text);
            int oscore = Convert.ToInt32(lbloscore.Text);
            if (this.step == "O")
                {
                lblxscore.Text = (xscore + 1).ToString();
                if (xscore==2)
                {
                    MessageBox.Show("Oyunun Qalibi X");
                    lblxscore.Text = "0";
                    lbloscore.Text = "0";
                    this.step = "X";
                    lblNovbe.Text = "X";
                }
                }
              else
               {
                lbloscore.Text = (oscore + 1).ToString();
                if (oscore == 2)
                {
                    MessageBox.Show("Oyunun Qalibi O");
                    lblxscore.Text = "0";
                    lbloscore.Text = "0";
                    this.step = "O";
                    lblNovbe.Text = "O";
                }
               }
            Reset();          
        }

        private void Reset()
        {
            foreach (Button btn in Clicked)
            {
                btn.Text = string.Empty;
            }
            this.Clicked.Clear();
        }
    }
}
