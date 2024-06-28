
namespace ObserverPattern;

public delegate void Del(object o); // объявление делегата

class Teacher
{
    Del dels;
    public void Register(Del del)
    {
        dels += del;
    }
    public void Notify()
    {
        Console.WriteLine("Hi");
        // оповещение наблюдателей
        dels?.Invoke(this);
    }
}

class Student
{
    // реакция на событие, инициированное субъектом
    public void Answer(object o)
    {
        Console.WriteLine("Здравствуйте!");
    }

}

