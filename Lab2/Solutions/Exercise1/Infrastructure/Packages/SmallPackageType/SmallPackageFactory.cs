using Exercise1.Infrastructure.Factories;
using FactoryMethodLogistics.Core.Interfaces;
using Logistics.Core.Interfaces;

namespace Logistics.Infrastructure.Factories
{
    public class SmallPackageFactory : IPackageFactory
    {
        public IPackage InstantiatePackage()
        {
            return new SmallPackage();
        }
    }
}
