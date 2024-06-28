
namespace TemplateMethodPattern;

abstract class Education
{
    // Algorithm
    public void Learn()
    {
        Enter();
        Study();
        PassExams();
        GetDocument();
    }

    // Подстановочные методы
    public abstract void Enter();
    public abstract void Study();
    public abstract void GetDocument();

    //Неизменяемый шаг (но можно и изменить)
    public virtual void PassExams()
    {
        Console.WriteLine("Сдаем выпускные экзамены");
    }
}

class School : Education
{
    //Первая реализация подстановочных методов
    public override void Enter()
    {
        Console.WriteLine("Идем в первый класс");
    }

    public override void Study()
    {
        Console.WriteLine("Посещаем уроки, делаем домашние задания");
    }

    public override void GetDocument()
    {
        Console.WriteLine("Получаем аттестат о среднем образовании");
    }
}

class University : Education
{
    public override void Enter()
    {
        Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ");
    }

    public override void Study()
    {
        Console.WriteLine("Посещаем лекции");
        Console.WriteLine("Проходим практику");
    }

    public override void PassExams()
    {
        Console.WriteLine("Сдаем экзамен по специальности");
    }

    public override void GetDocument()
    {
        Console.WriteLine("Получаем диплом о высшем образовании");
    }
}