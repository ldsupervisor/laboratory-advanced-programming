using Bakery.Core.Models;
using Bakery.Core.Interfaces;

namespace Bakery.Infrastructure.Factories;

public class ChocklateCakeFactory : ICakeFactory
{
    public string FactoryName
    {
        get { return "Chocklate Factory"; }
    }

/* other options of property declaration
public string FactoryName => "Chocklate Factory";
*/

    public Cake CreateCake()
    {
        return new Cake(
            "Chocklate",
            CakeSort.Shortcrust,
            new List<string> { "Chocklate", "Flour", "Eggs", "Flour" }
        );
    }
}
