
namespace MediatorPattern;

abstract class Mediator
{
    public abstract void Send(string message, Object o);
}

abstract class Colleague
{
    protected Mediator mediator;
    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }

    public virtual void Send(string message) 
    {
        mediator.Send(message, this);
    }

    public abstract void Notify(string message);
}

class Customer : Colleague
{
    public Customer(Mediator mediator) : base(mediator)
    {
    }

    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение заказчику: " + message);
    }
}

class Programmer : Colleague
{
    public Programmer(Mediator mediator)
    : base(mediator)
    { }

    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение программисту: " +
         message);
    }
}

class Tester : Colleague
{
    public Tester(Mediator mediator)
    : base(mediator)
    { }

    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение тестировщику: " +
         message);
    }
}

class ConcreteMediator : Mediator
{
    public Colleague Customer { get; set; }
    public Colleague Programmer { get; set; }
    public Colleague Tester { get; set; }

    public override void Send(string message, object o)
    {
        if (Customer == o)
            Programmer.Notify(message);
        else if (Programmer == o)
            Tester.Notify(message);
        else if (Tester == o)
            Customer.Notify(message);
    }
}