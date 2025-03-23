using Cukiernia.Core.Plan;
using Cukiernia.Core.Interfaces;
using Cukiernia.Infrastructure.Fabryki;

class Program
{
    static void Main()
    {
        var plan = new PlanPieczenia();

        List<IFabrykaCiasta> fabryki = new()
        {
            new FabrykaCiastaCzekoladowego(),
            new FabrykaCiastaJabłkowego()
        };

        foreach (var fabryka in fabryki)
        {
            plan.DodajCiasto(fabryka);
        }

        plan.WyświetlPlan_1_QueryMethod();
        plan.WyswietlPlan_2_EnumeratorPattern();
    }
}
