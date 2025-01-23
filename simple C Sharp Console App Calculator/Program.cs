namespace simple_C_Sharp_Console_App_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                UserInput.getOperand(); // Get Operator

                //If Else-If Statement for Initial Computation
                if (UserInput.Operand == '+')
                {
                    Arithmetic.showAnswer(Arithmetic.addition(UserInput.getValueOne(), UserInput.getValueTwo()));
                }
                else if (UserInput.Operand == '-')
                {
                    Arithmetic.showAnswer(Arithmetic.subtraction(UserInput.getValueOne(), UserInput.getValueTwo()));
                }
                else if (UserInput.Operand == '*')
                {
                    Arithmetic.showAnswer(Arithmetic.multiplication(UserInput.getValueOne(), UserInput.getValueTwo()));
                }
                else if (UserInput.Operand == '/')
                {
                    Arithmetic.showAnswer(Arithmetic.division(UserInput.getValueOne(), UserInput.getValueTwo()));
                }
                else
                {
                    Console.WriteLine("Invalid Operator");
                }


            
            }
            catch (Exception ex) // Error Handling
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}