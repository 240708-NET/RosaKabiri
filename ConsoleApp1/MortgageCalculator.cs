

// The app will calculate the monthly mortgage.
// it needs:
//1- three variables: Loan term, Loan amount and annual interest
//2- constructor to initialize these variables.
//3- a method to perform and calculate mortgage and round the monthly payment Local
    // loan term should be multiplied by 12, which is the number of months in a year
    // annual interest should be converted to monthly interest 


namespace MortgageCalculator;


public class MortgageCalculator
{

 private int loanTerm;
 private double annualInterest;
 private double loanAmount;


   public int LoanTerm
        {
            get { return loanTerm; }
            set { loanTerm = value; }
        }

        public double AnnualInterest
        {
            get { return annualInterest; }
            set { annualInterest = value; }
        }

        public double LoanAmount
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }



  

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



