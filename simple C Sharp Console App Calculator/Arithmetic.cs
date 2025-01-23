using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_C_Sharp_Console_App_Calculator
{
    public static class Arithmetic
        //Contains all methods related to Arithmetic Operations such as addition, multiplication, showing answer
    {
        private static float answer; // Stores the Answer Value

        public static float Answer // Getters and Setters
        {
            get { return answer; }
            set { answer = value; }
        }
        public static float addition(float num1, float num2) // Method for Addition
        {
            Answer = num1 + num2;
            return Answer;
        }

        public static float subtraction(float num1,float num2) // Method for Subtraction
        {
            Answer = num1 - num2;
            return Answer;
        }

        public static float multiplication(float num1, float num2) // Method for Multiplication
        {
            Answer = num1 * num2;
            return Answer;
        }

        public static float division(float num1, float num2) // Method for Division
        {
            Answer = num1 / num2;
            return Answer;
        }

        public static void showAnswer(float answer) // Method for Printing the Answer
        {
            Console.WriteLine("Is equal to: "+Answer);
        }

        
    }
}
