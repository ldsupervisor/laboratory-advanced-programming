namespace BuilderPattern
{
    public class ComputerBuilder
    {
        private string _cpu = string.Empty;
        private int _cpuCores;
        private string _ram = string.Empty;
        private string _cooler = string.Empty;
        private GPUType _gpu = GPUType.unknown;
        private string _lcdDisplay = string.Empty;
        private int _storageSize = 0;
        private StorageType _storageType = StorageType.unknown;
        private PowerSupply _powerSupply = PowerSupply.unknown;

        public ComputerBuilder WithCPU(string cpu, int cores)
        {
            _cpu = cpu;
            _cpuCores = cores;
            return this;
        }

        public ComputerBuilder WithRAM(string ram)
        {
            _ram = ram;
            return this;
        }

        public ComputerBuilder WithCooler(string cooler)
        {
            _cooler = cooler;
            return this;
        }

        public ComputerBuilder WithGPU(GPUType gpu)
        {
            _gpu = gpu;
            return this;
        }

        public ComputerBuilder WithLCDDisplay(string display)
        {
            _lcdDisplay = display;
            return this;
        }

        public ComputerBuilder WithStorage(int sizeGB, StorageType type)
        {
            _storageSize = sizeGB;
            _storageType = type;
            return this;
        }

        public ComputerBuilder WithPowerSupply(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
            return this;
        }

        public Computer Build()
        {
            return new Computer(
                _cpu,
                _cpuCores,
                _ram,
                _cooler,
                _gpu,
                _lcdDisplay,
                _storageSize,
                _storageType,
                _powerSupply
            );
        }
    }
}
