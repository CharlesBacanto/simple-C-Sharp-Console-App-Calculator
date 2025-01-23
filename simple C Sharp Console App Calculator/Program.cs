namespace simple_C_Sharp_Console_App_Calculator { 
    class Program
    {
        static void Main(string[] args)
        {
        UserInput.getOperand();

        if(UserInput.Operand == '+')
            {
                Arithmetic.showAnswer(Arithmetic.addition(UserInput.getValueOne(), UserInput.getValueTwo()));
            }
        else if(UserInput.Operand == '-')
            {
                Arithmetic.showAnswer(Arithmetic.subtraction(UserInput.getValueOne(), UserInput.getValueTwo()));    
            }
        else if(UserInput.Operand == '*')
            {
                Arithmetic.showAnswer(Arithmetic.multiplication(UserInput.getValueOne(), UserInput.getValueTwo())); 
            }
        else if(UserInput.Operand == '/')
            {
                Arithmetic.showAnswer(Arithmetic.division(UserInput.getValueOne(), UserInput.getValueTwo()));
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}