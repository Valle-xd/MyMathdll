using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathdll
{
    public class SimpleMath
    {
        /// <summary>
        /// add a and b
        /// </summary>
        public int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// add a and b and c
        /// </summary>
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// Subtract number2 from number1
        /// </summary>
        public static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }
        /// <summary>
        /// Double - multiply number1 with number2 
        /// </summary>
        public static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }
        /// <summary>
        /// subtract number1 with number2
        /// </summary>
        public static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
        /// <summary>
        /// int - multiply number1 with number2
        /// </summary>
        public static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        /// <summary>
        /// double - divide number1 with number2
        /// </summary>
        public static double Division(double number1, double number2)
        {
                return number1 / number2;
        }
        /// <summary>
        /// int - divide number1 with number2
        /// </summary>
        public static int Division(int number1, int number2)
        {     
                return number1 / number2;     
        }
    }
}
