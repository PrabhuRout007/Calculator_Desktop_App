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
    public partial class Calculator_App : Form
    {
        public Calculator_App()
        {
            InitializeComponent();
        }

        double result, number;
        int operation;
        double total_result = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        //-------------- Layout  ----------------------------//
        private void Calculator_App_Load_1(object sender, EventArgs e)
        {
            this.Width = 354;
            textBox1.Location = new Point(60, 61);
        }

        private void Basic_Click(object sender, EventArgs e)
        {
            this.Width = 351;
            textBox1.Location = new Point(60, 61);

        }

        private void sci_fi_Click(object sender, EventArgs e)
        {
            this.Width = 767;
            textBox1.Location = new Point(413, 107);
            textBox1.Width = 210; 
        }

        private void Num_0_Click(object sender, EventArgs e)
        {
          textBox1.Text = textBox1.Text + 0;
        }
        private void Num_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1; 
        }
        private void Num_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        private void Num_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }
        private void Num_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }
        private void Num_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }
        private void Num_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }
        private void Num_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;

        }

        private void point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        //--------------Basic Calculator Operation -------------//

        private void button_Add_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + "+";
            textBox1.Clear();
            operation = 1;

        }
        private void button_sub_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 2;

        }
        private void button_mult_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 3;
        }
        private void button_div_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 4;
        }

        private void percent_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 5;
        }


        //---------------- Scientific Calculator --------------------------------//

        private void Square_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 6;
        }

        private void Power_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 7;
        }

        private void Sci_Sin_Click(object sender, EventArgs e)
        {
            textBox2.Text = "SIN";
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 8;
        }

        private void Sci_Cos_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cos";
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 9;
        }

        private void Sci_Tan_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Tan";
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 10;
        }

        private void Sci_Cosec_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cosec";
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 11;
        }
        private void Sci_Sec_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Sec";
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 12;
        }

        private void Sci_Cot_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cot";
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 13;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Log";
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 14;
        }

        private void Pie_Click(object sender, EventArgs e)
        {
            textBox2.Text = "PI";
            textBox1.Clear();
            operation = 15;
        }

        private void num_e_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 14;
        }
        private void Opening_B_Click(object sender, EventArgs e)
        {
            operation = 15;
            textBox1.Text = textBox1.Text + "(";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation = 16;
            textBox1.Text = textBox1.Text + ")";
        }
        private void Num_Equals_Click(object sender, EventArgs e)
        {
            string h_result;
            string number1, number2;
            switch (operation)
            {
                case 1:
                    result = number + double.Parse(textBox1.Text);
                    number1 = number.ToString();
                    number2 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = number1 + " + " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;
                    

                case 2:
                    result = number - double.Parse(textBox1.Text);
                    number1 = number.ToString();
                    number2 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = number1 + " - " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 3:
                    result = number * double.Parse(textBox1.Text);
                    number1 = number.ToString();
                    number2 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = number1 + " * " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 4:
                    result = number / double.Parse(textBox1.Text);
                    number1 = number.ToString();
                    number2 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = number1 + " / " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;


                case 5:
                    result = (number / double.Parse(textBox1.Text))*100;
                    number1 = number.ToString();
                    number2 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = number1 + " % " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 6:
                    result = number * number; ;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = number + " ^ " + number + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 7:
                    result = Math.Pow(number, double.Parse(textBox1.Text));
                    number2 = textBox2.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = number + " ^ " + number2 + " = " + result;
                    history_box.AppendText(h_result +"\n");
                    break;

                case 8:
                    result = Math.Sin(number);
                    number1 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = "Sin(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 9:
                    result = Math.Cos(number);
                    number1 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = "Cos(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 10:
                    result = Math.Tan(number);
                    number1 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = "Tan(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 11:
                    result = 1/(Math.Sin(number));
                    number1 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = "Cosec(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 12:
                    result = 1 / (Math.Cos(number));
                    number1 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = "Sec(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 13:
                    result = 1 / (Math.Tan(number));
                    number1 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = "Cot(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 14:
                    result = Math.Log(number);
                    number1 = textBox1.Text;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    h_result = "Log(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 15:
                    result = Math.PI;
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    history_box.AppendText(textBox1.Text +"\n");
                    break;

                case 16:
                    result = Math.Exp(number);
                    textBox1.Clear();
                    textBox1.Text = result.ToString();
                    history_box.AppendText(textBox1.Text +"\n");
                    break;

                case 17:
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if (textBox1.Text == "(")
                        {
                            if (textBox1.Text == "+")
                            {
                                result = (i + 1) + (i - 1);
                            }
                        }
                    }

                    break;


            }
            

        }
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            history_box.Clear();
        }

        

        private void Num_8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad8)
            {
                textBox1.Text = "8";
            }
        } 

       
    }
}
