public class WizardFactory : INPCFactory
{
    public INPC CreateNPC() => new Wizard();
}
