namespace Command;

class Program
{
    static void Main(string[] args)
    {
        BankAccount timoBA = new BankAccount();
        Console.WriteLine("Account was opened: " + timoBA.ToString());

        CashMachine cashMachineSC = new CashMachine();

        List<IBankTransactionCommand> commands = new();

        IBankTransactionCommand command1 = new DepositCommand(timoBA, 2000);
        commands.Add(command1);

        IBankTransactionCommand command2 = new WithdrawCommand(timoBA, 500);
        commands.Add(command2);

        IBankTransactionCommand command3 = new DepositCommand(timoBA, 1000);
        commands.Add(command3);

        cashMachineSC.ExecuteBankTransaction(commands);
        
        // cashMachineSC.ExecuteBankTransaction(command1);
        // cashMachineSC.ExecuteBankTransaction(command2);
        // cashMachineSC.ExecuteBankTransaction(command3);

        cashMachineSC.UndoBankTransaction(commands);

        // cashMachineSC.UndoBankTransaction(command3);
        // cashMachineSC.UndoBankTransaction(command1);
        // cashMachineSC.UndoBankTransaction(command2);

        Console.WriteLine(timoBA);
        Console.ReadKey();
    }
}
//Bankaccount->IbankTrans->Depo->With->Cash
