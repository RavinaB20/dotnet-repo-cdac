namespace Banking;
using EGovernance;

public class Account{
    public event TaxOperation? overBalance;

    public double Balance { get; set; }

    public Account(){
        this.Balance = 3000;
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
}