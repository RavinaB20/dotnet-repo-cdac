using EGovernance;
using Banking;
using BankingOrg;

CentralGov bjp = new CentralGov();
Account acc1 = new Account();
/*
TaxOperation itOperation = new TaxOperation(bjp.DeductServiceTax);
acc1.Balance = itOperation(acc1.Balance);
Console.WriteLine("Balance = "+acc1.Balance);
TaxOperation profOperation = new TaxOperation(bjp.DeductProfessionalTax);
acc1.Balance = profOperation(acc1.Balance);

acc1.overBalance+=itOperation;
acc1.overBalance+=profOperation;

Console.WriteLine("Enter amount to be deposited : ");
double amount = double.Parse(Console.ReadLine());
acc1.deposit(amount);
acc1.ProcessTax();

Console.WriteLine("Balance after tax = "+acc1.Balance);
*/
/* //MULTICAST DELEGATE
TaxOperation? generalOpr = null;

generalOpr = itOperation;
generalOpr += profOperation;

generalOpr(9000);
*/

BankManager mgr = new BankManager();
Account acc2 = new Account();
BankOperation blockOperation = new BankOperation(mgr.blockAccount);
blockOperation();
BankOperation smsOperation = new BankOperation(mgr.sendSms);
smsOperation();
BankOperation emailOperation = new BankOperation(mgr.sendEmail);
emailOperation();

acc2.underBalance+=blockOperation;
acc2.underBalance+=smsOperation;
acc2.underBalance+=emailOperation;

Console.WriteLine("Enter the amount to withdraw : ");
double amount = double.Parse(Console.ReadLine());
acc2.withdraw(amount);
acc2.ManageAccount();






