
using FactoryPattern;

FactoryProduct factory = new FactoryProduct();

Product? product = factory.CreateProduct("A");
if (product is not null)
{
    Console.WriteLine(product.GetType().Name);
}

product = factory.CreateProduct("B");
if (product is not null)
{
    Console.WriteLine(product.GetType().Name);
}