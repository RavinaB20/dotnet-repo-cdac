namespace Banking;
using EGovernance;
using BankingOrg;

public class Account{
    public event TaxOperation? overBalance;
    public event BankOperation? underBalance;

    public double Balance { get; set; }

    public Account(){
        this.Balance = 9000;
    }

    public void withdraw(double amount){
        this.Balance -= amount;
    }

    public void deposit(double amount){
        this.Balance += amount;
    }

    public override string ToString(){
        return base.ToString()+ "Account Balance : "+this.Balance;
    }

    public void ProcessTax(){
        if(this.Balance >= 250000){
            overBalance(this.Balance);
            
        }
    }

    public void ManageAccount(){
        if(this.Balance < 5000){
            underBalance();
        }
    }

}