using Cukiernia.Core.Models;
using Cukiernia.Core.Interfaces;

namespace Cukiernia.Infrastructure.Fabryki;

public class FabrykaCiastaJabłkowego : IFabrykaCiasta
{
    public string NazwaFabryki
    {
        get { return "Fabryka Jabłkowa"; }
    }
    /* inna dozwolona forma inicjalizacji
    public string NazwaFabryki => "Fabryka Jabłkowa";
    */

    public Ciasto StwórzCiasto()
    {
        return new Ciasto(
            "Jabłkowe",
            RodzajCiasta.Drożdzowe,
            new List<string> { "Jabłka", "Cynamon", "Mąka", "Cukier" }
        );
    }
}
