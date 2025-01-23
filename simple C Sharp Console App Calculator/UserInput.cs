using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace simple_C_Sharp_Console_App_Calculator
{
    public static class UserInput // Contains all the methods for getting User Prompts
    {
        private static float valueOne; // Stores the first value
        private static float valueTwo; // Stores the second value
        private static char operand; // Stores the operator character

        // Getters and Setters
        public static float ValueOne 
        {
            get { return valueOne; }
            set { valueOne = value; }
        }

        public static float ValueTwo
        {
            get { return valueTwo; }
            set { valueTwo = value; }
        }

        public static char Operand
        {
            get { return operand; }
            //Set the recognized values only to the following key's '+', '-', '/' , '*'
            set { if (value == '+' || value == '-' || value == '*' || value == '/') operand = value;
                else Console.WriteLine("Arithmetic Operators Only: '+', '-', '*' , '/'");
            }
        }

        public static float getValueOne() // Method for getting the first value
        {
            Console.Write("Please Enter a Value: ");
            ValueOne = Convert.ToSingle(Console.ReadLine());
            return ValueOne;
        }

        public static float getValueTwo() // Method for getting the second value
        {
            Console.Write("Please Enter a Value: ");
            ValueTwo = Convert.ToSingle(Console.ReadLine());
            return ValueTwo;
        }

        public static char getOperand() // Method for getting operator
        {
            Console.Write("Please Enter the Operator: ");
            Operand = Convert.ToChar(Console.ReadLine());
            return Operand;
        }
       



    }
}
