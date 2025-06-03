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
            MakeDeposit();
        }

        public void MakeDeposit()
        {
            Console.WriteLine("Deposit operation executed.");
        }
    }
}
