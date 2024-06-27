
namespace BridgePattern;

public abstract class PassExam
{
    public abstract void Pass();
}

//Реализация различных способов приема
//Класс СдатьУстно
public class PassExamTalk : PassExam
{
    public override void Pass()
    {
        Console.WriteLine("Устно\n");
    }
}

//Класс СдатьПисьменно
public class PassExamWrite : PassExam
{
    public override void Pass()
    {
        Console.WriteLine("Письменно\n");
    }
}

public abstract class Subject
{
    public PassExam wayToPass;
    public Subject(PassExam passExam)
    {
        wayToPass = passExam;
    }
    public abstract void Pass();

}

public class TPR : Subject
{
    public TPR(PassExam passExam) : base(passExam)
    {
    }

    public override void Pass()
    {
        Console.WriteLine("ТПР ");
        wayToPass.Pass();
    }
}

public class ATiSRPO : Subject
{
    public ATiSRPO(PassExam passExam) : base(passExam)
    {
    }

    public override void Pass()
    {
        Console.WriteLine("АТиСРПО ");
        wayToPass.Pass();
    }
}
