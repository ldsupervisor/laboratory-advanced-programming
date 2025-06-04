using Bakery.Core.Models;

public class Cake
{
    public string Name { get; }
    public CakeSort Sort { get; }
    public List<string> Ingredients { get; }

    public Cake(string name, CakeSort sort, List<string> ingredients)
    {
        Name = name;
        Sort = sort;
        Ingredients = ingredients;
    }
}

/* other way to use "record" from .NET 5.0 onwards
pubclic record Cake(string Name, CakeSort Sort, List<string> Ingredients);
*/

/*other manner of initialization
public class Cake(string Name, CakeSort Sort, List<string> Ingredients);
{
    public string Name { get; } = name;
    public CakeSort Sort { get; } = sort;
    public List<string> Ingredients { get; } = ingredients;
}
*/
