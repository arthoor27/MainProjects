using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritard_Calculator
{
    internal interface ICalculate 
    {
        object Sum();
        object Subtraction();
        object Multiplication();
        object Division();
        string RSE();
        string RSEm();
        int Sum(int num1, int num2);
        int Subtraction(int num1, int num2);
        int Multiplication(int num1, int num2);
        float Division(int num1, int num2);
    }
}
