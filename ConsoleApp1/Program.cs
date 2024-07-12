
using MortgageCalculator;


 class Program
{


      public static void Main(string[] args){

             double loanAmount = 100000; 
            double annualInterest = 5; 
            int loanTerm = 30; 
     
        MortgageCalculator.MortgageCalculator cal = new MortgageCalculator.MortgageCalculator(loanAmount, annualInterest, loanTerm);


        Console.WriteLine("Mortgage Calculator App\n");
        Console.WriteLine(" Please Enter the loan amount: ");

       
            while (!double.TryParse(Console.ReadLine(), out loanAmount))
            {
                Console.WriteLine(" Please enter a valid loan amount.");
            }


        Console.Write("Please Enter the annual interest rate ");
     
            while (!double.TryParse(Console.ReadLine(), out annualInterest))
            {
                Console.WriteLine(" Please enter a valid annual interest rate.");
            }

          
        Console.Write("Please Enter the loan term: ");

       
            while (!int.TryParse(Console.ReadLine(), out loanTerm))
            {
                Console.WriteLine("Please enter a valid loan term in years.");
            }


double paymentMonthly= cal.CalculatePaymentMonthly();

 Console.WriteLine("Monthly Payment: " + "$" + paymentMonthly);
}
}
