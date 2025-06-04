using BankingSystem.Mediator;

namespace BankingSystem.Operations
{
    public interface IFinancialOperation
    {
        IMediator Mediator { get; set; }
        void Execute();
    }
}
