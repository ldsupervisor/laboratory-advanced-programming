public class PolandLogisticsFactory : ILogisticsFactory
{
    public IPackage CreatePackage()
    {
        return new SmallPackage();
    }

    public ICourier CreateCourier()
    {
        return new CompanyXCourier();
    }
}

public class USALogisticsFactory : ILogisticsFactory
{
    public IPackage CreatePackage()
    {
        return new LargePackage();
    }

    public ICourier CreateCourier()
    {
        return new CompanyYCourier();
    }
}