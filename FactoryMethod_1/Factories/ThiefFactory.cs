public class ThiefFactory : INPCFactory
{
    public INPC CreateNPC() => new Thief();
}
