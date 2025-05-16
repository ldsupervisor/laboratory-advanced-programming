using FactoryMethodLogistics.Core.Managers;
using Logistics.Core;
using Logistics.Core.Interfaces;
using Logistics.Infrastructure.Factories;

class Program
{
    static void Main()
    {
        var manager = SingletonManager.Instance;

        manager.SetFactory(new YourPackageFactoryType());
        manager.CreatePackage();

        manager.SetFactory(new LargePackageFactory());
        manager.CreatePackage();

    }
}
