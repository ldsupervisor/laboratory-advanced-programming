public class WarriorFactory : INPCFactory
{
    public INPC CreateNPC() => new Warrior();
}