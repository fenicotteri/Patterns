
namespace AdapterPattern;

public interface INetwork
{
    public void Connect220();
    public void Disconnect220();
}

class Computer : INetwork
{
    public void Connect220()
    {
        Console.WriteLine("Компьютер подключен к сети");
    }

    public void Disconnect220()
    {
        Console.WriteLine("Компьтер отсоединен от сети");
    }
}

class Laptop
{
    public void Connect24()
    {
        Console.WriteLine("Ноутбук подключен к сети ");
    }

    public void Disconnect24()
    {
        Console.WriteLine("Ноутбук отключен от сети ");
    }
}

class Adapter : INetwork
{
    private readonly Laptop laptop = new();
    public void Connect220()
    {
        laptop.Connect24();
    }

    public void Disconnect220()
    {
        laptop.Disconnect24();
    }
}
