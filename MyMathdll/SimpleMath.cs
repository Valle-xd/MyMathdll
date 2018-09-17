using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathdll
{
    public class SimpleMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }
        public static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
        public static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public static double Division(double number1, double number2)
        {
            if (number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                return number1;
            }
        }
        public static int Division(int number1, int number2)
        {
            if (number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                return number1;
            }
        }
    }
}
