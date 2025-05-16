using Logistics.Core.Interfaces;

namespace Exercise1.Infrastructure.Packages.SmallPackageType
{
    public class SmallPackage : IPackage
    {

        private static int _globalCounter = 0;
        private readonly int _id;


        public SmallPackage()
        {
            _id = ++_globalCounter;
        }
        public void PreparePackage()
        {
            Console.WriteLine($"Small package number {_id} prepared.");
        }
    }
}
