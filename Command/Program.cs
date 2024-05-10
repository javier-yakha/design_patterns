namespace Command;

class Program
{
    static void Main(string[] args)
    {
        BankAccount timoBA = new BankAccount();
        Console.WriteLine("Account was opened: " + timoBA.ToString());

        CashMachine cashMachineSC = new CashMachine();

        IBankTransactionCommand command1 = new DepositCommand(timoBA, 2000);
        IBankTransactionCommand command2 = new WithdrawCommand(timoBA, 500);
        IBankTransactionCommand command3 = new DepositCommand(timoBA, 1000);

        cashMachineSC.ExecuteBankTransaction(command1);
        cashMachineSC.ExecuteBankTransaction(command2);
        cashMachineSC.ExecuteBankTransaction(command3);

        Console.ReadKey();
    }
}
//Bankaccount->IbankTrans->Depo->With->Cash
