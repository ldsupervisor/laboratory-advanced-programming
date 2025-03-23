using Cukiernia.Core.Models;

public class Ciasto
{
    public string Nazwa { get; }
    public RodzajCiasta Rodzaj { get; }
    public List<string> Składniki { get; }

    public Ciasto(string nazwa, RodzajCiasta rodzaj, List<string> skladniki)
    {
        Nazwa = nazwa;
        Rodzaj = rodzaj;
        Składniki = skladniki;
    }
}

/* inny sposób użycie "record" od wersji .NET 5.0
public record Ciasto(string Nazwa, RodzajCiasta Rodzaj, List<string> Składniki);
*/

/* inny sposób inicjalizacji
 public class Ciasto(string nazwa, RodzajCiasta rodzaj, List<string> skladniki)
{
    public string Nazwa { get; } = nazwa;
    public RodzajCiasta Rodzaj { get; } = rodzaj;
    public List<string> Składniki { get; } = skladniki;
}
*/
