namespace EGovernance;
using Banking;

public delegate void TaxOperation(double amount);

public class CentralGov {
    public void DeductIncomeTax(double amount){
        Console.WriteLine("20% of income tax deducted from account");
        
    }
    public void DeductServiceTax(double amount){
        Console.WriteLine("15% of income tax deducted from account");
        Console.WriteLine("Amount = "+amount);
    }
    public void DeductProfessionalTax(double amount){
        Console.WriteLine("35% of income tax deducted from account");
    }

}