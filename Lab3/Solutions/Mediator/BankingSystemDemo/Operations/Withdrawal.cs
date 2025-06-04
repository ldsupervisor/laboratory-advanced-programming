using BankingSystem.Mediator;

namespace BankingSystem.Operations
{
    public class Withdrawal : IFinancialOperation, IWithdrawable
    {
        public IMediator Mediator { get; set; }

        public Withdrawal(IMediator mediator)
        {
            Mediator = mediator;
        }

        public void Execute()
        {
            Withdraw();
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdrawal operation executed.");
        }
    }
}
