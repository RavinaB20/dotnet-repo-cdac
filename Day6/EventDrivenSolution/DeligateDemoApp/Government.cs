namespace EGovernance;
using Banking;

public delegate double TaxOperation(double amount);

public class CentralGov {
    public double DeductIncomeTax(double amount){
        Console.WriteLine("20% of income tax deducted from account");
        return (amount - ((amount/100)*20));
    }
    public double DeductServiceTax(double amount){
        Console.WriteLine("15% of income tax deducted from account");
        return (amount - ((amount/100)*15));
    }
    public double DeductProfessionalTax(double amount){
        Console.WriteLine("35% of income tax deducted from account");
        return (amount - ((amount/100)*35));
    }

}