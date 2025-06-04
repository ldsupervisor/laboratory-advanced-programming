public interface IPackage
{
    void Pack();
}

public interface ICourier
{
    void Deliver();
}

public interface ILogisticsFactory
{
    IPackage CreatePackage();
    ICourier CreateCourier();
}

