using System.Drawing;

namespace Builder.Computer;

public class ComputerBuilder
{
    private readonly Computer _computer = new Computer();

    public ComputerBuilder()
    {
        
    }

    public ComputerBuilder AddGPU(string gpu)
    {
        _computer.GPU = gpu;
        return this;
    }
    
    public ComputerBuilder AddCPU(int cpu)
    {
        _computer.CPU = cpu;
        return this;
    }
    public ComputerBuilder AddStorage(int storage)
    {
        _computer.Storage = storage;
        return this;
    }
    public ComputerBuilder AddRAM(int ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}