using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritard_Calculator
{
    internal class RCalculate : RandomNumber, ICalculate
    {
        RandomNumber randomNumber = new RandomNumber();
        public object Division()
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            return outputvalue ? (object)RandomString : (object)RandomNumber;
        }
        public object Multiplication()
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            return outputvalue ? (object)RandomString :(object) RandomNumber;
        }
        public object Subtraction()
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            return outputvalue ? (object)RandomString : (object)RandomNumber;
        }
        public object Sum()
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            return outputvalue ? (object)RandomString : (object)RandomNumber;
        }
        public string RSEm()
        {
            string RandomStringEm;
            string RandomStringE;
            randomNumber.RString(out RandomStringE, out RandomStringEm);
            return RandomStringEm;
        }
        public string RSE()
        {
            string RandomStringEm;
            string RandomStringE;
            randomNumber.RString(out RandomStringE, out RandomStringEm);
            return RandomStringE;
        }
        bool OutputValue()
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            return outputvalue;
            // it has a rule for str or int 
        }
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public float Division(int num1, int num2)
        {
            if (num2 == 0)
            {
                MessageBox.Show("cant divide by 0");
                return 0;
            }
            return (float) num1 / num2;
        }
    }
}
