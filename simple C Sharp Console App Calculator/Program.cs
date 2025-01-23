namespace simple_C_Sharp_Console_App_Calculator { 
    class Program
    {
        static void Main(string[] args)
        {
           
          Arithmetic.showAnswer(Arithmetic.addition(UserInput.getValueOne(),UserInput.getValueTwo()));    
        }
    }
}