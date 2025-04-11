using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            if (EOutput() == false)
            {
                string rse = (string)calculate.RSE();
                MessageBox.Show(rse);
                return;
            }
            if (Emoutput() == false)
            {
                string rsem = (string)calculate.RSEm();
                MessageBox.Show(rsem);
                return;
            }
            if (EOutput() == true && Emoutput() == true)
            {
                if (Outputs())
                {
                    string subtraction = (string)calculate.Subtraction(0, 0);
                    MessageBox.Show(subtraction);
                }
                else
                {
                    int subtraction = (int)calculate.Subtraction(0, 0);
                    MessageBox.Show("Answer"+ " " + subtraction);
                }
            }
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (EOutput() == false)
            {
                string rse = (string)calculate.RSE();
                MessageBox.Show(rse);
                return;
            }
            if (Emoutput() == false)
            {
                string rsem = (string)calculate.RSEm();
                MessageBox.Show(rsem);
                return;
            }
            if (EOutput() == true && Emoutput() == true)
            {
                if (Outputs())
                {
                    string sum = (string)calculate.Sum(0, 0);
                    MessageBox.Show(sum);
                }
                else
                {
                    int sum = (int)calculate.Sum(0, 0);
                    MessageBox.Show("Answer" + " " + sum);
                }
            }
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (EOutput() == false)
            {
                string rse = (string)calculate.RSE();
                MessageBox.Show(rse);
                return;
            }
            if (Emoutput() == false)
            {
                string rsem = (string)calculate.RSEm();
                MessageBox.Show(rsem);
                return;
            }
            if (EOutput() == true && Emoutput() == true)
            {
                if (Outputs())
                {
                    string multiplication = (string)calculate.Multiplication(0, 0);
                    MessageBox.Show(multiplication);
                }
                else
                {
                    int multiplication = (int)calculate.Multiplication(2, 2);
                    MessageBox.Show("Answer" + " " + multiplication);
                }
            }
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (EOutput() == false)
            {
                string rse = (string)calculate.RSE();
                MessageBox.Show(rse);
                return;
            }
            if (Emoutput() == false)
            {
                string rsem = (string)calculate.RSEm();
                MessageBox.Show(rsem);
                return;
            }
            if (EOutput() == true && Emoutput() == true)
            {
                if (Outputs())
                {
                    string division = (string)calculate.Division(0, 0);
                    MessageBox.Show(division);
                }
                else
                {
                    int division = (int)calculate.Division(0, 0);
                    MessageBox.Show("Answer" + " " + division);
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
                return EmIsValid = true;
            }
            catch
            {
                if (txtNum1.Text != "")
                {
                    return EmIsValid = false;
                }
            }
            try
            {
                num2 = Convert.ToInt32(txtNum2.Text);
                return EmIsValid = true;
            }
            catch
            {
                if (txtNum2.Text != "")
                {
                    return EmIsValid = false;
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
                return EIsValid = true;
            }
            catch
            {
                if (txtNum1.Text == "")
                {
                    return EIsValid = false;
                }
            }
            try
            {
                num2 = Convert.ToInt32(txtNum2.Text);
                return EIsValid;
            }
            catch
            {
                if (txtNum2.Text == "")
                {
                    return EIsValid = false;
                }
            }
            return EIsValid;
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
    }
}
