// Visited object
var house = new House();

// Create visitors
IGuest mother = new Mother();
IGuest sibling = new Sibling();

// The level of cleanliness
Console.WriteLine($"Initial cleanliness: {house.Cleanliness}\n");

// Calling visiting objects, it could be expanded
house.Accept(sibling);
house.Accept(mother);

// Definitions of guest visitor interface
// Contract for visitors
// Can be easily expanded without modyfiyng the house
public interface IGuest
{
    void Visit(House house);
}

public class House
{
    public int Cleanliness { get; set; } = 2;

    public void Accept(IGuest guest)
    {
        guest.Visit(this);
    }
}

public class Mother : IGuest
{
    public void Visit(House house)
    {
        house.Cleanliness += 50;
        Console.WriteLine($"Mother visit. Cleanliness now: {house.Cleanliness}.");
    }
}

public class Sibling : IGuest
{
    public void Visit(House house)
    {
        house.Cleanliness += -8;
        Console.WriteLine($"Sibling visit. Cleanliness now: {house.Cleanliness}.");
    }
}
