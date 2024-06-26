
namespace AbstractFactoryPattern;

public abstract class AbsProduct
{
    public abstract void Info();
}

public abstract class Body : AbsProduct { }

public abstract class  Engine : AbsProduct { }

public class Body_M : Body
{
    public override void Info()
    {
        Console.WriteLine("Кузов для Мercedes\n");
    }
}

public class Body_B : Body
{
    public override void Info()
    {
        Console.WriteLine("Кузов для BMW\n");
    }
}

public class Engine_M : Engine
{
    public override void Info()
    {
        Console.WriteLine("Двигатель для Mercedes\n ");
    }
}

public class Engine_B : Engine
{
    public override void Info()
    {
        Console.WriteLine("Двигатель для BMW\n ");
    }
}

public abstract class AbstructFactory
{
    public abstract Body CreateB();
    public abstract Engine CreateE();
}

public class Factory_M : AbstructFactory
{
    public override Body CreateB()
    {
        return new Body_M();
    }

    public override Engine CreateE()
    {
        return new Engine_M();
    }
}

public class Factory_B : AbstructFactory
{
    public override Body CreateB()
    {
        return new Body_B();
    }

    public override Engine CreateE()
    {
        return new Engine_B();
    }
}

