namespace Builder.Computer;

public class Computer
{
    public string GPU { get; set; }
    public int CPU { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }

    public void Print()
    {
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"Storage: {Storage}");
    }
}