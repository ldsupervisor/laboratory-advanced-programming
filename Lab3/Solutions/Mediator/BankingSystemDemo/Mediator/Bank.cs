using BankingSystem.Operations;

namespace BankingSystem.Mediator
{
    public class Bank : IMediator
    {
        public void ExecuteOperation(IFinancialOperation operation)
        {
            operation.Execute();
        }
    }
}
