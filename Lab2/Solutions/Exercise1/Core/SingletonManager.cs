using FactoryMethodLogistics.Core.Interfaces;
using Logistics.Core.Interfaces;

namespace FactoryMethodLogistics.Core.Managers
{
    // Singleton
    public class SingletonManager
    {
        // The package factory to be used
        private IPackageFactory? _packageFactory;

        // Singleton private instance
        private static SingletonManager? _instance;

        // Private constructor to restrict instantiation
        private SingletonManager() { }

        public static SingletonManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonManager();
                }
                return _instance;
            }
        }

        // Assigns a concrete package factory
        public void SetFactory(IPackageFactory factory)
        {
            _packageFactory = factory;
        }

        // Produces and prepares a package
        public void CreatePackage()
        {
            if (_packageFactory != null)
            {
                IPackage package = _packageFactory.InstantiatePackage();
                package.PreparePackage();
            }

            else
            {
                throw new InvalidOperationException("Package factory is not set.");
            }

        }
    }
}
