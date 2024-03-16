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
        char process, tempProcess;
        bool screenclear, equalsControl, numControl = false, equalsControlCounter=false,dotControl=false;
        int clickControlCounter = 0;
        double firstnumdouble, conclusion, tempFirstNumDouble;
        void screenClearMetot()
        {
            if (screenclear == true)
            {
                label2.Text = "";
                screenclear = false;
            }
        }
        void numMethod(int num)
        {
            screenClearMetot();
            label2.Text += "" + num;
            numControl = true;
            equalsControlCounter = false;
            dotControl = true;
        }
        void processButtonControl(char processSelection)
        {
            if (numControl == true)
            {
                process = processSelection;
                clickControlMethod();
                tempProcess = processSelection;
                numControl = false;
                equalsControlCounter = false;
            }
            else
            {
                process = processSelection;
                tempProcess = processSelection;
                numControl = false;
                equalsControlCounter = false;
            }
        }
        void clickControlMethod()
        {
            if (equalsControl==true)
            {

                firstnumdouble = Convert.ToDouble(label2.Text);
                equalsControl = false;
                equalsControlCounter = false;
            }
            else
            {   
                if (clickControlCounter > 0)
                {
                    double secondnumdouble = Convert.ToDouble(label2.Text);
                    switch (tempProcess)
                    {
                        case '+':
                            conclusion = firstnumdouble + secondnumdouble;
                            break;
                        case '-':
                            conclusion = firstnumdouble - secondnumdouble;
                            break;
                        case '/':
                            conclusion = firstnumdouble / secondnumdouble;
                            break;
                        case '*':
                            conclusion = firstnumdouble * secondnumdouble;
                            break;
                    }
                    label2.Text = " " + conclusion;
                    screenclear = true;
                    firstnumdouble = conclusion;
                    equalsControlCounter = false;
                }
                else
                {
                    screenclear = true;
                    firstnumdouble = Convert.ToDouble(label2.Text);
                    clickControlCounter++;
                    equalsControlCounter = false;
                }
            }                       
        }       
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
        private void label1_Click(object sender, EventArgs e)
        {}
        private void Form1_Load(object sender, EventArgs e)
        {}   
        private void button1_Click(object sender, EventArgs e)
        {}
        private void button23_Click(object sender, EventArgs e)
        {
            numMethod(0);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            numMethod(1);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            numMethod(2);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            numMethod(3);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            numMethod(4);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            numMethod(5);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            numMethod(6);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            numMethod(7);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            numMethod(8);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            numMethod(9);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (dotControl==true)
            {
                if (!label2.Text.Contains("."))
                {
                    label2.Text += ".";
                    equalsControlCounter = false;
                }
            }          
        }
        
        private void button17_Click(object sender, EventArgs e)
        {
            processButtonControl('+');
        }
        private void button13_Click(object sender, EventArgs e)
        {
            processButtonControl('-');
        }
        private void button9_Click(object sender, EventArgs e)
        {
            processButtonControl('*');
        }
        private void button5_Click(object sender, EventArgs e)
        {
            processButtonControl('/');
        }      
        private void button21_Click(object sender, EventArgs e)
        {
            if (equalsControlCounter == true)
            {                
                equalsControl = true;
                double secondnumdouble = Convert.ToDouble(label2.Text);                
                switch (tempProcess)
                {
                    case '+':
                        conclusion = tempFirstNumDouble + secondnumdouble;
                        label2.Text = " " + conclusion;
                        break;
                    case '-':
                        conclusion = tempFirstNumDouble - secondnumdouble;
                        label2.Text = " " + conclusion;
                        break;
                    case '/':
                        conclusion = tempFirstNumDouble / secondnumdouble;
                        label2.Text = " " + conclusion;
                        break;
                    case '*':
                        conclusion = tempFirstNumDouble * secondnumdouble;
                        label2.Text = " " + conclusion;
                        break;
                }
            }
            else
            {
                equalsControl = true;
                double secondnumdouble = Convert.ToDouble(label2.Text);
                tempFirstNumDouble = secondnumdouble;
                switch (tempProcess)
                {
                    case '+':
                        conclusion = firstnumdouble + secondnumdouble;
                        label2.Text = " " + conclusion;
                        break;
                    case '-':
                        conclusion = firstnumdouble - secondnumdouble;
                        label2.Text = " " + conclusion;
                        break;
                    case '/':
                        conclusion = firstnumdouble / secondnumdouble;
                        label2.Text = " " + conclusion;
                        break;
                    case '*':
                        conclusion = firstnumdouble * secondnumdouble;
                        label2.Text = " " + conclusion;
                        break;
                }
                screenclear = true;
                equalsControlCounter = true;
            }          
        } 
     
        private void label2_Click(object sender, EventArgs e)
        {}

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
            equalsControlCounter = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            clickControlCounter = 0;
            equalsControlCounter = false;
            dotControl = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            equalsControlCounter = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            firstnumdouble = Convert.ToDouble(label2.Text);
            label2.Text=" "+Math.Sqrt(firstnumdouble);
            screenclear = true;
            equalsControlCounter = false;
            dotControl = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            firstnumdouble = Convert.ToDouble(label2.Text);
            label2.Text = " " + 1 / firstnumdouble;
            screenclear = true;
            equalsControlCounter = false;
            dotControl= true; ;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            firstnumdouble = Convert.ToDouble(label2.Text);
            label2.Text = " " + (-1) * firstnumdouble;
            equalsControlCounter = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            firstnumdouble = Convert.ToDouble(label2.Text);
            label2.Text = " " + firstnumdouble * firstnumdouble;
            screenclear=true;
            equalsControlCounter = false;
            dotControl = true;
        }
    }
}
