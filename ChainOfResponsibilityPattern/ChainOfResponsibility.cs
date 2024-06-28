
namespace ChainOfResponsibilityPattern;

public class Receiver
{
    public bool BankTransfer { get; set; }
   
    public bool MoneyTransfer { get; set; }

    public bool PayPalTransfer { get; set; }
    public Receiver(bool bt, bool ppt, bool mt)
    {
        BankTransfer = bt;
        MoneyTransfer = mt;
        PayPalTransfer = ppt;
    }
}

abstract class PaymentHandler
{
    protected PaymentHandler? Successor { get; set; } // next 
    public abstract void Handle(Receiver receiver);
    public void AddHandler(PaymentHandler handler)
    {
        if (Successor is not null)
        {
            Successor.AddHandler(handler);
        }
        else
        {
            Successor = handler;
        }
    }
}

class BankPaymentHandler : PaymentHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.BankTransfer == true)
            Console.WriteLine("Выполняем банковский перевод");
        else
            Successor?.Handle(receiver);
    }
}

class PayPalPaymentHandler : PaymentHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.PayPalTransfer == true)
            Console.WriteLine("Выполняем перевод через PayPal");
        else
            Successor?.Handle(receiver);
    }
}

class MoneyPaymentHandler : PaymentHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.MoneyTransfer == true)
            Console.WriteLine("Выполняем перевод через системы денежных переводов");
        else
            Successor?.Handle(receiver);
    }
}
