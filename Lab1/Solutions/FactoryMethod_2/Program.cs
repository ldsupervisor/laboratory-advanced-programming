using Bakery.Core.Plan;
using Bakery.Core.Interfaces;
using Bakery.Infrastructure.Factories;

class Program
{
    static void Main()
    {
        var plan = new BakingPlan();

        List<ICakeFactory> factories = new()
        {
            new ChocklateCakeFactory(),
            new AppleCakeFactory()
        };

        foreach (var fabryka in factories)
        {
            plan.AddCake(fabryka);
        }

        plan.DisplayPlan_1();
        plan.DisplayPlan_2();
    }
}
