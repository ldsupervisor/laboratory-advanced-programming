using Cukiernia.Core.Models;
using Cukiernia.Core.Interfaces;

namespace Cukiernia.Infrastructure.Fabryki;

public class FabrykaCiastaCzekoladowego : IFabrykaCiasta
{
    public string NazwaFabryki
    {
        get { return "Fabryka Czekoladaowa"; }
    }
    /* inna dozwolona forma inicjalizacji
    public string NazwaFabryki => "Fabryka Czekoladowa";
    */

    public Ciasto StwórzCiasto()
    {
        return new Ciasto(
            "Czekoladowe",
            RodzajCiasta.Kruche,
            new List<string> { "Czekolada", "Mąka", "Jajka", "Masło" }
        );
    }
}
