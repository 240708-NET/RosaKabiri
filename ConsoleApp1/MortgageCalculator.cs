

// The app will calculate the monthly mortgage.
// it needs:
//1- three variables: Loan term, Loan amount and annual interest
//2- constructor to initialize these variables.
//3- a method to perform and calculate mortgage and round the monthy payment of deciaml 2
    // loan term should be multiplied by 12, which is the number of months in a year
    // annual interest should be converted to monthly interest
//4- a formula for calculating


namespace MortgageCalculator;


public class MortgageCalculator
{
 public int LoanTerm { get; set; }
 public double AnnualInterest{ get; set; }
 public double LoanAmount{get; set; }




public MortgageCalculator(double loanAmount, double annualInterest, int loanTerm)
        {
            LoanAmount = loanAmount;
            AnnualInterest = annualInterest;
            LoanTerm = loanTerm;
        }


 public double CalculatePaymentMonthly()
        {
        int totalPayments = LoanTerm * 12;
        double monthlyInterest = (AnnualInterest / 100) / 12;
         
        double paymentMonthly = LoanAmount * monthlyInterest *
        Math.Pow(1 + monthlyInterest, totalPayments) /
        (Math.Pow(1 + monthlyInterest, totalPayments) - 1);


            return paymentMonthly;
        }


}







