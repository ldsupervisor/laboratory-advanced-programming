using Bakery.Core.Models;
using Bakery.Core.Interfaces;

namespace Bakery.Infrastructure.Factories;

public class AppleCakeFactory : ICakeFactory
{
    public string FactoryName
    {
        get { return "Apple Factory"; }
    }

    /* other options of property declaration
    public string FactoryName => "Apple Factory";
    */

    public Cake CreateCake()
    {
        return new Cake(
            "Apple",
            CakeSort.Yeast,
            new List<string> { "Apples", "Cinammon", "Flour", "Sugar" }
        );
    }
}
