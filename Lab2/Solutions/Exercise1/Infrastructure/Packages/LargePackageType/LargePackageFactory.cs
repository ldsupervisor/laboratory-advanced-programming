using Exercise1.Infrastructure.Factories;
using FactoryMethodLogistics.Core.Interfaces;
using Logistics.Core.Interfaces;

namespace Logistics.Infrastructure.Factories
{
    public class LargePackageFactory : IPackageFactory
    {
        public IPackage InstantiatePackage()
        {
            return new LargePackage();
        }
    }
}
