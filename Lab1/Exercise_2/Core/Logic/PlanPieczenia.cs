using System.Collections;
using Cukiernia.Core.Interfaces;

namespace Cukiernia.Core.Plan
{
    public class PlanPieczenia : IEnumerable<Ciasto>
    {
        private readonly List<Ciasto> _ciasta = new();

        public void DodajCiasto(IFabrykaCiasta fabryka)
        {
            var ciasto = fabryka.StwórzCiasto();
            Console.WriteLine($"Dodano ciasto: {ciasto.Nazwa}");
            _ciasta.Add(ciasto);
        }
        public void WyświetlPlan_1_QueryMethod()
        {
            Console.WriteLine("Plan pieczenia (query method):\n");

            var listaCiast = PobierzWszystkieCiasta();

            foreach (var ciasto in listaCiast)
            {
                Console.WriteLine($"Nazwa: {ciasto.Nazwa}");
                Console.WriteLine($"Rodzaj: {ciasto.Rodzaj}");
                Console.WriteLine("Składniki:");
                Console.WriteLine($"Składniki: {string.Join(", ", ciasto.Składniki)}");
                Console.WriteLine();
            }
        }

        public void WyswietlPlan_2_EnumeratorPattern()
        {
            Console.WriteLine("Plan pieczenia (enumerator pattern):\n");

            foreach (var ciasto in _ciasta)
            {
                Console.WriteLine($"Nazwa: {ciasto.Nazwa}");
                Console.WriteLine($"Rodzaj: {ciasto.Rodzaj}");
                Console.WriteLine("Składniki:");
                Console.WriteLine($"Składniki: {string.Join(", ", ciasto.Składniki)}");
                Console.WriteLine();
            }
        }

        // Pozwala używać foreach (var ciasto in planPieczenia)
        public IEnumerator<Ciasto> GetEnumerator()
        {
            return _ciasta.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// Zwraca nową listę zawierającą wszystkie ciasta - kopia danych

        public List<Ciasto> PobierzWszystkieCiasta()
        {
            return new List<Ciasto>(_ciasta);
        }

    }
}
