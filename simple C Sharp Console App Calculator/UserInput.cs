using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_C_Sharp_Console_App_Calculator
{
    public static class UserInput
    {
        private static float valueOne;
        private static float valueTwo;

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

        public static float getValueOne()
        {
            Console.Write("Please Enter a Value: ");
            ValueOne = Convert.ToSingle(Console.ReadLine());
            return ValueOne;
        }

        public static float getValueTwo()
        {
            Console.Write("Please Enter a Value: ");
            ValueTwo = Convert.ToSingle(Console.ReadLine());
            return ValueTwo;
        }
       


    }
}
