using Exercise1.Infrastructure.Packages.LargePackageType;
using Exercise1.Infrastructure.Packages.SmallPackageType;
using FactoryMethodLogistics.Core.Managers;

class Program
{
    static void Main()
    {
        var manager = SingletonManager.Instance;

        manager.SetFactory(new SmallPackageFactory());
        manager.CreatePackage();

        manager.SetFactory(new LargePackageFactory());
        manager.CreatePackage();

    }
}
