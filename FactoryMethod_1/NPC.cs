public class Warrior : INPC
{
    public void IntroduceYourself()
    {
        Console.WriteLine("I am a Warrior, I fight with a sword.");
    }
}

public class Wizard : INPC
{
    public void IntroduceYourself()
    {
        Console.WriteLine("I am a Wizard, I command elemental magic.");
    }
}

public class Thief : INPC
{
    public void IntroduceYourself()
    {
        Console.WriteLine("I am a Thief, I have no attributes.");
    }
}
