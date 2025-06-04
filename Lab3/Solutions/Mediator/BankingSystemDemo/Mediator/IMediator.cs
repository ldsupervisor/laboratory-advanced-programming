using BankingSystem.Operations;

namespace BankingSystem.Mediator
{
    public interface IMediator
    {
        void ExecuteOperation(IFinancialOperation operation);
    }
}