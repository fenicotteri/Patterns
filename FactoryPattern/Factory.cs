
namespace FactoryPattern;

public abstract class Product
{ }

class ConcreteProductA : Product
{ }

class ConcreteProductB : Product
{ }

public class FactoryProduct
{
    public Product? CreateProduct(string name)
    {
        switch(name)
        {
            case "A": return new ConcreteProductA();
            case "B": return new ConcreteProductB();
                default: return null;
        }
    }
}
