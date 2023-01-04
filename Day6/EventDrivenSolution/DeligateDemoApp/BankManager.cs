namespace BankingOrg;

public delegate void BankOperation();

public class BankManager{
    public void blockAccount(){
        Console.WriteLine("Acount is blocked..");
    }
    public void sendSms(){
        Console.WriteLine("Sending the sms.");
    }

    public void sendEmail(){
        Console.WriteLine("Sending the email. ");
    }

}