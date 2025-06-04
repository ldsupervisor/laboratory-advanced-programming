public class PackageManager
{
    private ILogisticsFactory? _logisticsFactory;
    private static PackageManager? _instance;

    public static PackageManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new PackageManager();
            return _instance;
        }
    }

    public void AcceptOrder(string location)
    {
        if (location == "Poland")
            _logisticsFactory = new PolandLogisticsFactory();
        else if (location == "USA")
            _logisticsFactory = new USALogisticsFactory();
        else
        {
            Console.WriteLine("Unsupported location.");
            return;
        }

        var package = _logisticsFactory.CreatePackage();
        var courier = _logisticsFactory.CreateCourier();

        package.Pack();
        courier.Deliver();
    }

    public Guid InstanceId { get; } = Guid.NewGuid();

    public void Process()
    {
        Console.WriteLine($"Processing package with instance ID: {InstanceId}");
    }
}
