
namespace CommandPattern;

interface ICommand
{
    void Execute();
    void Undo();
}

// Receiver
class TV
{
    public void On()
    {
        Console.WriteLine("Телевизор включен!");
    }

    public void Off()
    {
        Console.WriteLine("Телевизор выключен...");
    }
}

class TVOnCommand : ICommand
{
    TV tv;
    public TVOnCommand(TV tvSet)
    {
        tv = tvSet;
    }

    public void Execute()
    {
        tv.On();
    }

    public void Undo()
    {
        tv.Off();
    }
}

class Pult
{
    ICommand command;

    public Pult() { }

    public void SetCommand(ICommand com)
    {
        command = com;
    }

    public void PressButton()
    {
        if (command != null)
            command.Execute();
    }
    public void PressUndo()
    {
        if (command != null)
            command.Undo();
    }
}

class Microwave
{
    public void StartCooking(int time)
    {
        Console.WriteLine("Подогреваем еду");
        // имитация работы с помощью асинхронного метода Task.Delay
        Task.Delay(time).GetAwaiter().GetResult();
    }

    public void StopCooking()
    {
        Console.WriteLine("Еда подогрета!");
    }
}
class MicrowaveCommand : ICommand
{
    Microwave microwave;
    int time;
    public MicrowaveCommand(Microwave m, int t)
    {
        microwave = m;
        time = t;
    }
    public void Execute()
    {
        microwave.StartCooking(time);
        microwave.StopCooking();
    }

    public void Undo()
    {
        microwave.StopCooking();
    }
}