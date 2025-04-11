using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritard_Calculator
{
    internal interface ICalculate 
    {
        object Sum(int num1, int num2);
        object Subtraction(int num1, int num2);
        object Multiplication(int num1, int num2);
        object Division(int num1, int num2);
        string RSE();
        string RSEm();
    }
}
