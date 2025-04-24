using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ritard_Calculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new RCalculate();
            RandomNumber randomumber = new RandomNumber();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME");
            toolTip.SetToolTip(CheckBox, "check this square for regular calculator ");
            toolTip.InitialDelay = 500;
            toolTip.AutoPopDelay = 5000;
            toolTip.ShowAlways = true;
        }
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (CheckBox.Checked)
            {
                if (EOutput() && Emoutput())
                {
                    int Num1 = Convert.ToInt32(txtNum1.Text);
                    int Num2 = Convert.ToInt32(txtNum2.Text);
                    int SUB = (int)calculate.Subtraction((int)Num1, (int)Num2);
                    MessageBox.Show("answer :" + SUB);
                }
                else
                {
                    MessageBox.Show("please enter just number");
                }
            }
            else
            {
                if (!EOutput())
                {
                    string rse = (string)calculate.RSE();
                    MessageBox.Show(rse);
                    return;
                }
                if (!Emoutput())
                {
                    string rsem = (string)calculate.RSEm();
                    MessageBox.Show(rsem);
                    return;
                }
                if (EOutput() && Emoutput())
                {
                    if (Outputs())
                    {
                        string subtraction = (string)calculate.Subtraction();
                        MessageBox.Show(subtraction);
                    }
                    else
                    {
                        int subtraction = (int)calculate.Subtraction();
                        MessageBox.Show("Answer" + " " + subtraction);
                    }
                }
            }
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (CheckBox.Checked)
            {
                if (EOutput() && Emoutput())
                {
                    int Num1 = Convert.ToInt32(txtNum1.Text);
                    int Num2 = Convert.ToInt32(txtNum2.Text);
                    int SUM = (int)calculate.Sum((int)Num1, (int)Num2);
                    MessageBox.Show("answer :" + SUM);
                }
                else
                {
                    MessageBox.Show("please enter just number");
                }
            }
            else
            {
                if (!EOutput())
                {
                    string rse = (string)calculate.RSE();
                    MessageBox.Show(rse);
                    return;
                }
                if (!Emoutput())
                {
                    string rsem = (string)calculate.RSEm();
                    MessageBox.Show(rsem);
                    return;
                }
                if (EOutput() && Emoutput())
                {
                    if (Outputs())
                    {
                        string sum = (string)calculate.Sum();
                        MessageBox.Show(sum);
                    }
                    else
                    {
                        int sum = (int)calculate.Sum();
                        MessageBox.Show("Answer" + " " + sum);
                    }
                }
            }
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (CheckBox.Checked)
            {
                if (EOutput() && Emoutput())
                {
                    int Num1 = Convert.ToInt32(txtNum1.Text);
                    int Num2 = Convert.ToInt32(txtNum2.Text);
                    int MUL = (int)calculate.Multiplication((int)Num1, (int)Num2);
                    MessageBox.Show("answer :" + MUL);
                }
                else
                {
                    MessageBox.Show("please enter just number");
                }
            }
            else
            {
                if (!EOutput())
                {
                    string rse = (string)calculate.RSE();
                    MessageBox.Show(rse);
                    return;
                }
                if (!Emoutput())
                {
                    string rsem = (string)calculate.RSEm();
                    MessageBox.Show(rsem);
                    return;
                }
                if (EOutput() && Emoutput())
                {
                    if (Outputs())
                    {
                        string multiplication = (string)calculate.Multiplication();
                        MessageBox.Show(multiplication);
                    }
                    else
                    {
                        int multiplication = (int)calculate.Multiplication();
                        MessageBox.Show("Answer" + " " + multiplication);
                    }
                }
            }
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (CheckBox.Checked)
            {
                if (EOutput() && Emoutput())
                {
                    int Num1 = Convert.ToInt32(txtNum1.Text);
                    int Num2 = Convert.ToInt32(txtNum2.Text);
                    float DIV = (float)calculate.Division((int)Num1, (int)Num2);
                    MessageBox.Show("answer :" + DIV);
                }
                else
                {
                    MessageBox.Show("please enter just number");
                }
            }
            else
            {
                if (!EOutput())
                {
                    string rse = (string)calculate.RSE();
                    MessageBox.Show(rse);
                    return;
                }
                if (!Emoutput())
                {
                    string rsem = (string)calculate.RSEm();
                    MessageBox.Show(rsem);
                    return;
                }
                if (EOutput() && Emoutput())
                {
                    if (Outputs())
                    {
                        string division = (string)calculate.Division();
                        MessageBox.Show(division);
                    }
                    else
                    {
                        int division = (int)calculate.Division();
                        MessageBox.Show("Answer" + " " + division);
                    }
                }
            }
        }
        bool Outputs()
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            RandomNumber randomNumber = new RandomNumber();
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            switch (outputvalue)
            {
                case true:
                    return true;
                case false:
                    return false;
                default:
                    return true;
            }
        }
        int num1;
        int num2;
        bool Emoutput()
        {
            bool EmIsValid = true;
            try
            {
                num1 = Convert.ToInt32(txtNum1.Text);
            }
            catch
            {
                if (txtNum1.Text != "")
                {
                    EmIsValid = false;
                }
            }
            try
            {
                num2 = Convert.ToInt32(txtNum2.Text);
            }
            catch
            {
                if (txtNum2.Text != "")
                {
                    EmIsValid = false;
                }
            }
            return EmIsValid;
        }
        bool EOutput()
        {
            bool EIsValid = true;
            try
            {
                num1 = Convert.ToInt32(txtNum1.Text);
            }
            catch
            {
                if (txtNum1.Text == "")
                {
                    EIsValid = false;
                }
            }
            try
            {
                num2 = Convert.ToInt32(txtNum2.Text);
            }
            catch
            {
                if (txtNum2.Text == "")
                {
                    EIsValid = false;
                }
            }
            return EIsValid;
        }
        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }
        private void txtNumber1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtNumber2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lblText2_Click(object sender, EventArgs e)
        {

        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
