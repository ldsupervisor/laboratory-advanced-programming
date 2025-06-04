List<INPCFactory> factories = new List<INPCFactory>
        {
            new WarriorFactory(),
            new WizardFactory(),
            new ThiefFactory()
        };

Random random = new Random();
int index = random.Next(factories.Count);

INPC npc = factories[index].CreateNPC();
npc.IntroduceYourself();