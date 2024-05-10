using System;
namespace Command
{
	public class CashMachine
	{
        public void ExecuteBankTransaction(IBankTransactionCommand command)
        {
            command.Execute();
        }
        public void ExecuteBankTransaction(List<IBankTransactionCommand> commands)
        {
            foreach (var command in commands)
                command.Execute();
        }
        public void UndoBankTransaction(IBankTransactionCommand command)
        {
            command.Undo();
        }
        public void UndoBankTransaction(List<IBankTransactionCommand> commands)
        {
            foreach (var command in commands)
                command.Undo();
        }
    }
}

