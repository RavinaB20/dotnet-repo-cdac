using EGovernance;
using Banking;

CentralGov bjp = new CentralGov();
Account acc1 = new Account();

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

/* //MULTICAST DELEGATE
TaxOperation? generalOpr = null;

generalOpr = itOperation;
generalOpr += profOperation;

generalOpr(9000);
*/