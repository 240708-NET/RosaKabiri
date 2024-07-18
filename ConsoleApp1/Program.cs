
using MortgageCalculator;


 class Program
{


      public static void Main(string[] args){

// Initialize variables
        Console.WriteLine("Mortgage Calculator App!\n");
         double loanAmount = DoubleFromUser("Please Enter the loan amount: ");
        double annualInterest = DoubleFromUser("Please Enter the annual interest rate: ");
        int loanTerm = IntFromUser("Please Enter the loan term: ");


// Create an instance of MortgageCalculator
     
        MortgageCalculator.MortgageCalculator cal = new MortgageCalculator.MortgageCalculator(loanAmount, annualInterest, loanTerm);


        Console.Write("Please Enter the annual interest rate: ");
     
                 Console.WriteLine("Please enter a valid loan term in years.");


double paymentMonthly= cal.CalculatePaymentMonthly();
paymentMonthly = Math.Round(paymentMonthly,2);

 Console.WriteLine("Monthly Payment: " + "$" + paymentMonthly);
}


 private static double DoubleFromUser(string prompt)
    {
        double value;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.WriteLine("Please enter a valid positive number.");
            Console.Write(prompt);
        }
        return value;
    }

    private static int IntFromUser(string prompt)
    {
        int value;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.WriteLine("Please enter a valid positive number.");
            Console.Write(prompt);
        }
        return value;

}
}

