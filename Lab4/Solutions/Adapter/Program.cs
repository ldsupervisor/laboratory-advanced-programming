// Inital list of clothes to wash
var clothes = new List<string>
     {
       "T-shirt",
       "Trousers",
       "Socks",
       "Hoodie",
     };

// Crating automatic washing machine and manual washer with adapter
var washingMachine = new WashingMachine();
var manualWasher = new ManualWasher();
var manualAdapter = new ManualWasherAdapter(manualWasher);

var manualLaundry = new LaundryService(manualAdapter);
var machineLaundry = new LaundryService(washingMachine);

Console.WriteLine("Manual washing:");
manualLaundry.WashAll(clothes);

Console.WriteLine("\nAutomatic washing:");
await Task.Run(() => machineLaundry.WashAll(clothes));


// Common interface for all washers, the goal is to wash all the clothes using LoundryService
public interface IWasher
{
    void WashAll(List<string> clothes);
}

// Automatic washing machine class implementation, it implements IWasher interface
public class WashingMachine : IWasher
{
    public void WashAll(List<string> clothes)
    {
        string start = DateTime.Now.ToString("HH:mm:ss");
        Console.WriteLine($"[{start}] Starting cycle for: {string.Join(", ", clothes)}");

        Thread.Sleep(3000); // Washich simulation

        string end = DateTime.Now.ToString("HH:mm:ss");
        Console.WriteLine($"[{end}] washing cycle finished time");
    }
}

// Class representing manual washer, it has a method to scrub clothes with a board, lack of interface IWasher implementation
public class ManualWasher
{
    public void ScrubWithBoard(string cloth)
    {
        string time = DateTime.Now.ToString("HH:mm:ss");
        Thread.Sleep(1000);
        Console.WriteLine($"Manual wash [{time}] washing: {cloth}");
    }
}

// Adapter for manual washer, it implements IWasher interface and using ManualWasher class to perform washing
public class ManualWasherAdapter : IWasher
{
    private readonly ManualWasher _manualWasher;

    public ManualWasherAdapter(ManualWasher manualWasher)
    {
        _manualWasher = manualWasher;
    }

    public void WashAll(List<string> clothes)
    {
        foreach (var cloth in clothes)
        {
            _manualWasher.ScrubWithBoard(cloth);
        }
    }
}
// Service delegating washing tasks
public class LaundryService
{
    private readonly IWasher _washer;

    public LaundryService(IWasher washer)
    {
        _washer = washer;
    }

    public void WashAll(List<string> clothes)
    {
        _washer.WashAll(clothes);
    }
}