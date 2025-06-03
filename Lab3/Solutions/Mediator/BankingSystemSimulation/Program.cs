class Program
{
    static void Main()
    {
        IMediator bank = new Bank();

        IFinancialOperation deposit = new Deposit(bank);
        IFinancialOperation withdrawal = new Withdrawal(bank);
        IFinancialOperation transfer = new Transfer(bank);

        bank.ExecuteOperation(deposit);
        bank.ExecuteOperation(withdrawal);
        bank.ExecuteOperation(transfer);

        Console.ReadKey();
    }
}
