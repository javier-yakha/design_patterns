using System;
namespace Command
{
	public class CashMachine
	{
        public void ExecuteBankTransaction(IBankTransactionCommand command)
        {
            command.Execute();
        }
    }
}

