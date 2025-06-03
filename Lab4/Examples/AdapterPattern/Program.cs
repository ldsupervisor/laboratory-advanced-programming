// definition and declaration of flowers with different watering systems
List<INewWateringSystem> flowers = new List<INewWateringSystem>
        {
            new ModernPot(),
            new OldPotAdapter(new OldPot())
        };

//water each flower using the unified watering system interface
foreach (var flower in flowers)
{
    flower.Water();
}

// Interface with new watering system
public interface INewWateringSystem
{
    void Water();
}
// Modern pot with new watering system
public class ModernPot : INewWateringSystem
{
    public void Water()
    {
        Console.WriteLine("Watering (modern pot).");
    }
}

// Old pot with an old watering system
public class OldPot
{
    public void FillWaterFromBottom()
    {
        Console.WriteLine("Filling water (old pot).");
    }
}

// Adapter class that adapts the old pot to the new watering system interface
public class OldPotAdapter : INewWateringSystem
{
    private readonly OldPot _oldPot;

    public OldPotAdapter(OldPot oldPot)
    {
        _oldPot = oldPot;
    }

    //adapts the old pot's method to the new watering system interface
    public void Water()
    {
        _oldPot.FillWaterFromBottom();
    }
}
