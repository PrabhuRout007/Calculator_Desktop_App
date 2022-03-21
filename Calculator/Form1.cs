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
        bool dec = false;
        //-------------- Layout  ----------------------------//
        private void Calculator_App_Load_1(object sender, EventArgs e)
        {
            this.Width = 327;
            textBox1.Width = 282;
            textBox1.Location = new Point(13, 33);
            ActiveControl = Num_Equals;
         
        }

        private void Basic_Click(object sender, EventArgs e)
        {
            this.Width = 327;
            textBox1.Width = 282;
            textBox1.Location = new Point(13,33);

        }

        private void sci_fi_Click(object sender, EventArgs e)
        {
            this.Width = 647;
            textBox1.Location = new Point(379, 85);
            textBox1.Width = 210;
        }

        private void Num_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 0.ToString();
            }
            else
            textBox1.Text = textBox1.Text + 0;
        }
        private void Num_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 1.ToString();
            }
            else
                textBox1.Text = textBox1.Text + 1; 
        }
        private void Num_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 2.ToString();
            }
            else
            textBox1.Text = textBox1.Text + 2;
        }
        private void Num_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 3.ToString();
            }
            else
            textBox1.Text = textBox1.Text + 3;
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 4.ToString();
            }
            else
            textBox1.Text = textBox1.Text + 4;
        }
        private void Num_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 5.ToString();
            }
            else
            textBox1.Text = textBox1.Text + 5;
        }
        private void Num_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 6.ToString();
            }
            else
            textBox1.Text = textBox1.Text + 6;
        }
        private void Num_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 7.ToString();
            }
            else
            textBox1.Text = textBox1.Text + 7;
        }
        private void Num_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 8.ToString();
            }
            else
            textBox1.Text = textBox1.Text + 8;
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0") == true)
            {
                textBox1.Text = 9.ToString();
            }
            else

            textBox1.Text = textBox1.Text + 9;

        }
        private void Delete_Click(object sender, EventArgs e)
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
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            history_box.Clear();
        }
        private void button_decimal_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length;
            int count=0;
            string text = textBox1.Text;
            for (int i = 0; i < length; i++)
            {
                if (text[i].ToString() == ".")
                {
                    count = 1;
                    break;
                }
                else
                {
                    count = 0;
                }
            }
             if (count == 0)
                {
                    textBox1.Text = textBox1.Text + ".";
                }
        }
        private void opening_bracket_Click(object sender, EventArgs e)
        {
            textBox1.Text = "(";
            operation = 20;
        }
        //--------------Basic Calculator Operation -------------//

        private void button_Add_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
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
            textBox2.Text = "Square";
            number = double.Parse(textBox1.Text);
            operation = 6;
        }

        private void Power_Click(object sender, EventArgs e)
        {
            number = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox2.Text = "Power";
            operation = 7;
        }

        private void Sci_Sin_Click(object sender, EventArgs e)
        {
            textBox2.Text = "SIN";
            operation = 8;
        }

        private void Sci_Cos_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cos";
            operation = 9;
        }

        private void Sci_Tan_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Tan";
            operation = 10;
        }

        private void Sci_Cosec_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cosec";
            operation = 11;
        }
        private void Sci_Sec_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Sec";
            operation = 12;
        }

        private void Sci_Cot_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cot";
            operation = 13;
        }

        private void Log_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Log";
            operation = 14;
        }

        private void Pie_Click(object sender, EventArgs e)
        {
            textBox2.Text = "PI";
            operation = 15;
        }

        private void num_e_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Exponent";
            operation = 16;
        }
        private void Cube_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cube";
            number = double.Parse(textBox1.Text);
            operation = 17;
        }
        private void Divd_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1/X";
            number = double.Parse(textBox1.Text);
           
            operation = 18;
        }
        //-------------------Equal Performation ---------------------//

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
                    textBox1.Text = result.ToString();
                    h_result = number1 + " + " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;
                    

                case 2:
                    result = number - double.Parse(textBox1.Text);
                    number1 = number.ToString();
                    number2 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = number1 + " - " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 3:
                    result = number * double.Parse(textBox1.Text);
                    number1 = number.ToString();
                    number2 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = number1 + " * " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 4:
                    result = number / double.Parse(textBox1.Text);
                    number1 = number.ToString();
                    number2 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = number1 + " / " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;


                case 5:
                    result = (number / double.Parse(textBox1.Text))*100;
                    number1 = number.ToString();
                    number2 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = number1 + " % " + number2 + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 6:
                    result = number * number;
                    textBox1.Text = result.ToString();
                    h_result = number + " ^ " + number + " = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 7:
                    result = Math.Pow(number, double.Parse(textBox1.Text));
                    number2 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = number + " ^ " + number2 + " = " + result;
                    history_box.AppendText(h_result +"\n");
                    break;

                case 8:
                    result = Math.Sin(double.Parse(textBox1.Text));
                    number1 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = "Sin(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 9:
                    result = Math.Cos(double.Parse(textBox1.Text));
                    number1 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = "Cos(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 10:
                    result = Math.Tan(double.Parse(textBox1.Text));
                    number1 = textBox1.Text;

                    textBox1.Text = result.ToString();
                    h_result = "Tan(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 11:
                    result = 1/(Math.Sin(double.Parse(textBox1.Text)));
                    number1 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = "Cosec(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 12:
                    result = 1 / (Math.Cos(double.Parse(textBox1.Text)));
                    number1 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = "Sec(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 13:
                    result = 1 / (Math.Tan(double.Parse(textBox1.Text)));
                    number1 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = "Cot(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                   break;

                case 14:
                    result = Math.Log(double.Parse(textBox1.Text));
                    number1 = textBox1.Text;
                    textBox1.Text = result.ToString();
                    h_result = "Log(" + number1 + ") = " + result;
                    history_box.AppendText(h_result + "\n");
                    break;

                case 15:
                    result = Math.PI;
                    textBox1.Text = result.ToString();
                    history_box.AppendText(textBox1.Text +"\n");
                    break;

                case 16:
                    result = Math.Exp(double.Parse(textBox1.Text));
                    textBox1.Text = result.ToString();
                     history_box.AppendText(textBox1.Text +"\n");
                    break;

                case 17:
                    result = number * number * number;
                    textBox1.Text = result.ToString();
                    h_result = "Cube(" +number + ") ="+ result;
                    history_box.AppendText(h_result+"\n");
                   break;

                case 18:
                    result = 1 / number;

                    textBox1.Text = result.ToString();
                    history_box.AppendText(textBox1.Text + "\n");
                  break;

                case 19:
                    result = number + double.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;

                case 20:
                    number = double.Parse(textBox1.Text);
                    int length = textBox1.Text.Length;
                    string text = textBox1.Text;

                    for (int i = 0; i < length; i++)
                    {
                        if (text[i].ToString() == "(")
                        { 
                          
                        }
                    }
                    break;
            }
        }
        private void closing_bracket_Click(object sender, EventArgs e)
        {

        }

        //------------------------- KeyPress Event -------------------------------------//
        private void Calculator_App_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    Num_1.PerformClick();
                    break;
                case Keys.NumPad2:
                    Num_2.PerformClick();
                    break;
                case Keys.NumPad3:
                    Num_3.PerformClick();
                    break;
                case Keys.NumPad4:
                    Num_4.PerformClick();
                    break;
                case Keys.NumPad5:
                    Num_5.PerformClick();
                    break;
                case Keys.NumPad6:
                    Num_6.PerformClick();
                    break;
                case Keys.NumPad7:
                    Num_7.PerformClick();
                    break;
                case Keys.NumPad8:
                    Num_8.PerformClick();
                    break;
                case Keys.NumPad9:
                    Num_9.PerformClick();
                    break;
                case Keys.NumPad0:
                    Num_0.PerformClick();
                    break;
                case Keys.Add:
                    button_Add.PerformClick();
                    break;
                case Keys.Subtract:
                    button_sub.PerformClick();
                    break;
                case Keys.Multiply:
                    button_mult.PerformClick();
                    break;
                case Keys.Divide:
                    button_div.PerformClick();
                    break;
                case Keys.D5:
                    percent.PerformClick();
                    break;
                case Keys.Back:
                    Delete.PerformClick();
                    break;
                case Keys.Escape:
                    Button_Clear.PerformClick();
                    break;
                case Keys.E:
                    Num_Equals.PerformClick();
                    break;
                case Keys.S:
                    sci_fi.PerformClick();
                    break;
                case Keys.B:
                    Basic.PerformClick();
                    break;
                case Keys.Decimal:
                    button_decimal.PerformClick();
                    break;
            }
        } 
    }
}
