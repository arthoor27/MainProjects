using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ritard_Calculator
{
    internal class RCalculate : RandomNumber, ICalculate
    {
        RandomNumber randomNumber = new RandomNumber();
        public object Division(int num1, int num2)
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            if (OutputValue())
            {
                return RandomString;
            }
            else
            {
                return RandomNumber;
            }
        }
        public object Multiplication(int num1, int num2)
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            if (OutputValue())
            {
                return RandomString;
            }
            else
            {
                return RandomNumber;
            }
        }
        public object Subtraction(int num1, int num2)
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            if (OutputValue())
            {
                return RandomString;
            }
            else
            {
                return RandomNumber;
            }
        }
        public object Sum(int num1, int num2)
        {
            string RandomString;
            int RandomNumber;
            bool outputvalue;
            randomNumber.RNumber(out RandomString, out RandomNumber, out outputvalue);
            if (OutputValue())
            {
                return RandomString;
            }
            else
            {
                return RandomNumber;
            }
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

    }
}
