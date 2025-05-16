using Logistics.Core.Interfaces;

namespace Exercise1.Infrastructure.Factories
{
    public class LargePackage : IPackage
    {
        private static int _globalCounter = 0;
        private readonly int _id;


        public LargePackage()
        {
            _id = ++_globalCounter;
        }

        public void PreparePackage()
        {
            Console.WriteLine($"Large package number {_id} prepared.");
        }
    }
}
