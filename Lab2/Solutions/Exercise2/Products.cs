public class SmallPackage : IPackage
{
    public void Pack()
    {
        Console.WriteLine("Packed a small package.");
    }
}

public class LargePackage : IPackage
{
    public void Pack()
    {
        Console.WriteLine("Packed a large package.");
    }
}

public class CompanyXCourier : ICourier
{
    public void Deliver()
    {
        Console.WriteLine("Delivered by Company X courier.");
    }
}

public class CompanyYCourier : ICourier
{
    public void Deliver()
    {
        Console.WriteLine("Delivered by Company Y courier.");
    }
}
