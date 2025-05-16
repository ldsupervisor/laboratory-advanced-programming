using Exercise1.Infrastructure.Factories;
using FactoryMethodLogistics.Core.Interfaces;
using Logistics.Core.Interfaces;

namespace Exercise1.Infrastructure.Packages.LargePackageType
{
    public class LargePackageFactory : IPackageFactory
    {
        public IPackage InstantiatePackage()
        {
            return new LargePackage();
        }
    }
}
