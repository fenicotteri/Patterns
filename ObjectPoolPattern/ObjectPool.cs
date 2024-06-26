
namespace ObjectPoolPattern;

public class Resource
{
    private int Value = 0;
    private bool Use = true;

    public Resource() { }
    public void Reset()
    {
        Value = 0;
        Use = false;
    }

    public int GetValue()
    { return Value; }
    public void SetValue(int number)
    { Value = number; }

    public void SetUse() { Use = true; }
}

public class ObjectPool
{ //Класс - Singleton

    private readonly Queue<Resource> resources = new();
    private static readonly ObjectPool instance = new();

    ObjectPool() { }
    public static ObjectPool Instance
    {
        get { return instance; }
    }

    /*Извлекаем из пула экземпляр ресурса. Если все
ресурсы использованы, то создаем новый экземпляр */
    public Resource GetResource()
    {
        if (resources.Count == 0)
        {
            Console.WriteLine("Создаем новый экземпляр");
            return new Resource();
        }
        else
        {
            {
                Console.WriteLine("Извлекаем экземпляр из пула");
                //Извлекаем первый элемент очереди
                Resource res = resources.Dequeue();
                res.SetUse();
                return res;
            }
        }

    }

    //Возвращаем экземпляр в пул
    public void ReturnResource(Resource obj)
    {
        Console.WriteLine("Сбрасываем настройки и помешаем экземпляр в пул");
        obj.Reset();
        //Добавляем в конец очереди
        resources.Enqueue(obj);
    }


}
