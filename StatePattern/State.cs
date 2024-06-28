
namespace StatePattern;

public interface IWaterState
{
    void Heat(Water water);
    void Frost(Water water);
}

public class Water
{
    public IWaterState State { get; set; }
    public Water(IWaterState state)
    {
        State = state;
    }

    public void Heat()
    {
        State.Heat(this);
    }
    public void Frost()
    {
        State.Frost(this);
    }
}

class LiquidWaterState : IWaterState
{
    public void Heat(Water water)
    {
        Console.WriteLine("Превращаем жидкость в пар");
        water.State = new GasWaterState();
    }

    public void Frost(Water water)
    {
        Console.WriteLine("Превращаем жидкость в лед");
        water.State = new SolidWaterState();
    }
}

class SolidWaterState : IWaterState
{
    public void Heat(Water water)
    {
        Console.WriteLine("Превращаем лед в жидкость");
        water.State = new LiquidWaterState();
    }

    public void Frost(Water water)
    {
        Console.WriteLine("Продолжаем заморозку льда");
    }
}

class GasWaterState : IWaterState
{
    public void Heat(Water water)
    {
        Console.WriteLine("Повышаем температуру водяного пара");
    }

    public void Frost(Water water)
    {
        Console.WriteLine("Превращаем водяной пар в жидкость");
        water.State = new LiquidWaterState();
    }
}