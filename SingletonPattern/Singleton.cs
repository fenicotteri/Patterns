
namespace SingletonPattern;

// для определенного класса будет создан только один объект,
// а также предоставит к этому объекту точку доступа.
// При применении паттерна синглтон в многопоточным программах мы можем столкнуться с проблемой.

public class Singleton
{
    private static Singleton? instance;
    public string Name { get; private set; }

    private Singleton(string name)
    { 
        Name = name;
    }

    public static Singleton getInstance(string name)
    {
        instance ??= new Singleton(name);

        return instance;
    }
}

