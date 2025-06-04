namespace BuilderPattern
{
    public class Computer
    {
        public readonly string CPU;
        public readonly int CPUCores;
        public readonly string RAM;
        public readonly string Cooler;
        public readonly GPUType GPU;
        public readonly string LCDDisplay;
        public readonly int StorageSizeGB;
        public readonly StorageType StorageType;
        public readonly PowerSupply PowerSupply;

        public Computer(
            string cpu,
            int cpuCores,
            string ram,
            string cooler,
            GPUType gpu,
            string lcdDisplay,
            int storageSizeGB,
            StorageType storageType,
            PowerSupply powerSupply)
        {
            CPU = cpu;
            CPUCores = cpuCores;
            RAM = ram;
            Cooler = cooler;
            GPU = gpu;
            LCDDisplay = lcdDisplay;
            StorageSizeGB = storageSizeGB;
            StorageType = storageType;
            PowerSupply = powerSupply;
        }

        public override string ToString()
        {
            return
                $"CPU: {CPU} ({CPUCores} cores)\n" +
                $"RAM: {RAM}\n" +
                $"Cooler: {Cooler}\n" +
                $"GPU: {GPU}\n" +
                $"LCD Display: {LCDDisplay}\n" +
                $"Storage: {StorageSizeGB} [GB] {StorageType}\n" +
                $"Power Supply: {(int)PowerSupply} [W]\n";
        }
    }
}


public enum GPUType
{
    unknown = 0,
    Integrated,
    Dedicated
}

public enum StorageType
{
    unknown = 0,
    HDD,
    SSD,
    NVMe
}

public enum PowerSupply
{
    unknown = 0,
    PSU550 = 550,
    PSU650 = 650,
    PSU850 = 850
}