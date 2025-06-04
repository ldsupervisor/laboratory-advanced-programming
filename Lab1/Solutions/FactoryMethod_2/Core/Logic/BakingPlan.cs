using System.Collections;
using Bakery.Core.Interfaces;

namespace Bakery.Core.Plan
{
    public class BakingPlan
        : IEnumerable<Cake>
    {
        private readonly List<Cake> _cakes = new();

        public void AddCake(ICakeFactory factory)
        {
            var cake = factory.CreateCake();
            Console.WriteLine($"Adding cake: {cake.Name}");
            _cakes.Add(cake);
        }
        public void DisplayPlan_1()
        {
            Console.WriteLine("\n\nBaking plan below\n");

            var CakeList = GettAllCakes();

            foreach (var cake in _cakes.Where(c => c.Name.Contains("Apple")))
            {
                Console.WriteLine($"Group: {cake.Name}");
                Console.WriteLine($"Sort: {cake.Sort}");
                Console.WriteLine($"Ingredients: {string.Join(", ", cake.Ingredients)}");
                Console.WriteLine();
            }
        }

        public void DisplayPlan_2()
        {
            Console.WriteLine("Baking plan below\n");

            foreach (var cake in _cakes.Where(c => c.Name.Contains("Chocklate")))
            {
                Console.WriteLine($"Group: {cake.Name}");
                Console.WriteLine($"Sort: {cake.Sort}");
                Console.WriteLine($"Ingredients: {string.Join(", ", cake.Ingredients)}");
                Console.WriteLine();
            }
        }

        // Lets using foreach (var cake in bakingPlan)
        public IEnumerator<Cake> GetEnumerator()
        {
            return _cakes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Returns a new list containing all cakes - a copy of the data
        public List<Cake> GettAllCakes()
        {
            return new List<Cake>(_cakes);
        }

    }
}
