using BuilderPattern;

var highEndPC = new ComputerBuilder()
    .WithCPU("High efficient CPU", 16)
    .WithRAM("64 [GB] DDR5")
    .WithCooler("Water Cooler")
    .WithGPU(GPUType.Dedicated)
    .WithLCDDisplay("27-inch 4K IPS")
    .WithStorage(2000, StorageType.NVMe)
    .WithPowerSupply(PowerSupply.PSU850)
    .Build();

Console.WriteLine("Extreme PC Configuration:\n");
Console.WriteLine(highEndPC);

var officePC = new ComputerBuilder()
    .WithCPU("Low efficient CPU", 6)
    .WithRAM("16 [GB] DDR4")
    .WithCooler("Stock Cooler")
    .WithGPU(GPUType.Integrated)
    .WithLCDDisplay("24-inch FHD")
    .WithStorage(512, StorageType.SSD)
    .WithPowerSupply(PowerSupply.PSU550)
    .Build();

Console.WriteLine("Office PC Configuration:\n");
Console.WriteLine(officePC);
