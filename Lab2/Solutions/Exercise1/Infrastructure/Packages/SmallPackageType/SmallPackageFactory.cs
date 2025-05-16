using Exercise1.Infrastructure.Factories;
using FactoryMethodLogistics.Core.Interfaces;
using Logistics.Core.Interfaces;

namespace Exercise1.Infrastructure.Packages.SmallPackageType
{
    public class SmallPackageFactory : IPackageFactory
    {
        public IPackage InstantiatePackage()
        {
            return new SmallPackage();
        }
    }
}
