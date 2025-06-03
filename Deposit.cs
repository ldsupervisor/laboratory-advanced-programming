using BankingSystem.Mediator;

namespace BankingSystem.Operations
{
    public class Deposit : IFinancialOperation, IDepositable
    {
        public IMediator Mediator { get; set; }

        public Deposit(IMediator mediator)
        {
            Mediator = mediator;
        }

        public void Execute()
        {
            Deposit();
        }

        public void Deposit()
        {
            Console.WriteLine("Deposit operation executed.");
        }
    }
}
