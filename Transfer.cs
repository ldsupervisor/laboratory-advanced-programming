using BankingSystem.Mediator;

namespace BankingSystem.Operations
{
    public class Transfer : IFinancialOperation, IDepositable, IWithdrawable
    {
        public IMediator Mediator { get; set; }

        public Transfer(IMediator mediator)
        {
            Mediator = mediator;
        }

        public void Execute()
        {
            Withdraw();
            Deposit();
        }

        public void Withdraw()
        {
            Console.WriteLine("Transfer: withdrawing");
        }

        public void Deposit()
        {
            Console.WriteLine("Transfer: depositing");
        }
    }
}
