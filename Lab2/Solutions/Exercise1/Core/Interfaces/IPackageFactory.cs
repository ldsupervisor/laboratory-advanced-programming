using Logistics.Core.Interfaces;

namespace FactoryMethodLogistics.Core.Interfaces
{
    // Factory interface need to be implemented by all concrete factories
    public interface IPackageFactory
    {
        /// Factory method - method to create a package and return it, it is an abstract method we do not know the exact package type
        IPackage InstantiatePackage();
    }
}
