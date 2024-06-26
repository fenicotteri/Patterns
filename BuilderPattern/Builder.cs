
namespace BuilderPattern;

public class Cake
{
    private string? Korzh { get; set; }
    private string? Filling { get; set; }


    public void SetKorzh(string korzh) { Korzh = korzh; }

    public void SetFilling(string filling) {  Filling = filling; }

    public void ShowDetails()
    {
        Console.WriteLine(Filling + Korzh);
    }
}

public abstract class CakeBuilder
{
    public abstract void ChooseKorzh();
    public abstract void ChooseFilling();
    public abstract Cake GetResultCake();
}

public class CakeABuilder : CakeBuilder
{
    public Cake Cake = new Cake();

    override public void ChooseFilling()
    {
        Cake.SetFilling("banana");
    }

    override public void ChooseKorzh()
    {
        Cake.SetKorzh("Black");
    }

    override public Cake GetResultCake()
    {
        return Cake;
    }
}

public class CakeBBuilder : CakeBuilder
{
    Cake Cake = new Cake();
    override public void ChooseFilling()
    {
        Cake.SetFilling("strawberry");
    }

    override public void ChooseKorzh()
    {
        Cake.SetKorzh("white");
    }

    override public Cake GetResultCake()
    {
        return Cake;
    }
}

public class Baker
{
    private CakeBuilder builder;

    public Baker( CakeBuilder builder)
    {
        this.builder = builder;
    }

    public void SetCakeBuilder( CakeBuilder builder)
    {
        this.builder = builder;
    }

    public Cake GetCake()
    {
       return builder.GetResultCake();
    }

    public void BakeTheCake()
    {
        builder.ChooseKorzh();
        builder.ChooseFilling();
    }

}