using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Google.Protobuf;
//using Greeter;
using Grpc.Core;
using SquareRootCalculator;
using SquareRootClient;


namespace Lab2_calculator_in_C_sharp
{

    public partial class Form1 : Form
    {
        private
        bool newval;
        String previousOp;
        float RT;
        float temp;
        string nextOp;

        //initialise variables here for functionality code
        public Form1()
        {
            InitializeComponent();
            newval = true;
            previousOp = "+";
            RT = 0;
            temp = 0;
        }

        // functionality code, everything below here governs the functionality of the buttons / text box
        // eg. button10 = 0, button11 = decimal point etc.
        private void textBox1_TextChanged(object sender, EventArgs e) // text box
        {

        }

        private void button10_Click(object sender, EventArgs e) // 0
        {
            if (newval == true)
            {
                textBox1.Text = "0";
                newval = false;
            }
            else
                this.textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e) // 1
        {
            if (newval == true)
            {
                textBox1.Text = "1";
                newval = false;
            }
            else
                this.textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e) // 2
        {
            if (newval == true)
            {
                textBox1.Text = "2";
                newval = false;
            }
            else
                this.textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e) // 3
        {
            if (newval == true)
            {
                textBox1.Text = "3";
                newval = false;
            }
            else
                this.textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e) // 
        {
            if (newval == true)
            {
                textBox1.Text = "4";
                newval = false;
            }
            else
                this.textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e) // 5
        {
            if (newval == true)
            {
                textBox1.Text = "5";
                newval = false;
            }
            else
                this.textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e) // 6
        {
            if (newval == true)
            {
                textBox1.Text = "6";
                newval = false;
            }
            else
                this.textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e) // 7
        {
            if (newval == true)
            {
                textBox1.Text = "7";
                newval = false;
            }
            else
                this.textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e) // 8
        {
            if (newval == true)
            {
                textBox1.Text = "8";
                newval = false;
            }
            else
                this.textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e) // 9
        {
            if (newval == true)
            {
                textBox1.Text = "9";
                newval = false;
            }
            else
                this.textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e) // decimal point .
        {
            if (newval == true)
            {
                textBox1.Text = ".";
                newval = false;
            }
            else
            {
                this.textBox1.Text += ".";
            }
        }

        private void button12_Click(object sender, EventArgs e) // equals op =
        {
            temp = Convert.ToSingle(textBox1.Text);
            nextOp = "+";
            if (previousOp == "+")
            {
                RT += temp;


            }
            else if (previousOp == "+")
            {
                RT = RT + temp;
            }
            else if (previousOp == "-")
            {
                RT = RT - temp;
            }
            else if (previousOp == "*")
            {
                RT = RT * temp;
            }
            else if (previousOp == "/")
            {
                RT = RT / temp;
            }

            textBox1.Text = Convert.ToString(RT);
            previousOp = "+";
            RT = 0;
            newval = true;
        }

        private void button13_Click(object sender, EventArgs e) // clear op C
        {
            this.textBox1.Text = "0";
            previousOp = "+";
            RT = 0;
            newval = true;
        }

        private void button14_Click(object sender, EventArgs e) // addition op +
        {
            temp = Convert.ToSingle(textBox1.Text);
            nextOp = "+";
            if (previousOp == "+")
            {
                RT += temp;


            }
            else if (previousOp == "-")
            {
                RT = RT - temp;
            }
            else if (previousOp == "*")
            {
                RT = RT * temp;
            }
            else if (previousOp == "/")
            {
                RT = RT / temp;
            }

            textBox1.Text = Convert.ToString(RT);
            previousOp = "+";
            newval = true;
        }

        private void button15_Click(object sender, EventArgs e) // subtraction op -
        {
            temp = Convert.ToSingle(textBox1.Text);
            nextOp = "-";
            if (previousOp == "-")
            {
                RT -= temp;


            }
            else if (previousOp == "+")
            {
                RT = RT + temp;
            }
            else if (previousOp == "*")
            {
                RT = RT * temp;
            }
            else if (previousOp == "/")
            {
                RT = RT / temp;
            }

            textBox1.Text = Convert.ToString(RT);
            previousOp = "-";
            newval = true;
        }

        private void button16_Click(object sender, EventArgs e) // multiply op x
        {
            temp = Convert.ToSingle(textBox1.Text);
            nextOp = "*";
            if (previousOp == "*")
            {
                RT *= temp;


            }
            else if (previousOp == "+")
            {
                RT = RT + temp;
            }
            else if (previousOp == "/")
            {
                RT = RT / temp;
            }
            else if (previousOp == "-")
            {
                RT = RT - temp;
            }

            textBox1.Text = Convert.ToString(RT);
            previousOp = "*";
            newval = true;
        }

        private void button17_Click(object sender, EventArgs e) // divide op /
        {
            temp = Convert.ToSingle(textBox1.Text);
            nextOp = "/";
            if (previousOp == "/")
            {
                RT /= temp;


            }
            else if (previousOp == "+")
            {
                RT = RT + temp;
            }
            else if (previousOp == "*")
            {
                RT = RT * temp;
            }
            else if (previousOp == "-")
            {
                RT = RT - temp;
            }

            textBox1.Text = Convert.ToString(RT);
            previousOp = "/";
            newval = true;
        }

        private void button18_Click(object sender, EventArgs e) // void
        {

        }

        private void button19_Click(object sender, EventArgs e) // square root dll
        {
            Functions obj1 = new Functions();           // object is created
            temp = Convert.ToSingle(textBox1.Text);     // user input converted to float
            RT = obj1.squareRootFunc(temp);             // passes running total to square root function

            textBox1.Text = Convert.ToString(RT);       // returned value printed on calculator
            previousOp = "+";
            RT = 0;                                     // update total
            newval = true;
        }

        private void button18_Click_1(object sender, EventArgs e) //grpc
        {
            SquareRootProgram obj2 = new SquareRootProgram();       // client object is created
            temp = Convert.ToSingle(textBox1.Text);                 // user input converted to float
            RT = obj2.RetSquareRoot(temp);                          // passes running total to square root function

            textBox1.Text = Convert.ToString(RT);                   // returned value printed on calculator
            previousOp = "+";
            RT = 0;                                                 // update total
            newval = true;
        }

        private void button20_Click(object sender, EventArgs e) // rpc
        {

        }
       
    }
}