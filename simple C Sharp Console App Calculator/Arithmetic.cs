using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_C_Sharp_Console_App_Calculator
{
    public static class Arithmetic
    {
        private static float answer;

        public static float Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public static float addition(float num1, float num2)
        {
            Answer = num1 + num2;
            return Answer;
        }

        public static float subtraction(float num1,float num2)
        {
            Answer = num1 - num2;
            return Answer;
        }

        public static float multiplication(float num1, float num2)
        {
            Answer = num1 * num2;
            return Answer;
        }

        public static float division(float num1, float num2)
        {
            Answer = num1 / num2;
            return Answer;
        }

        public static void showAnswer(float answer)
        {
            Console.WriteLine("Is equal to: "+Answer);
        }

        
    }
}
