
using System.Xml.Linq;

namespace CompositePattern;

public abstract class Component
{
    protected string Name;

    public Component(string name)
    {
        Name = name;
    }

    public virtual void Add(Component component) { }
    public virtual void Remove(Component component) { }
    public virtual void Print()
    {
        Console.WriteLine(Name);
    }
}

public class Directory : Component
{
    private List<Component> components = new();
    public Directory(string name) : base(name)
    {
    }

    public override void Add(Component component)
    {
        components.Add(component);
    }

    public override void Remove(Component component)
    {
        components.Remove(component);
    }

    public override void Print()
    {
        Console.WriteLine("Узел " + Name);
        Console.WriteLine("Подузлы:");
        foreach (Component component in components)
        {
            component.Print();
        }
    }

}

public class File : Component
{
    public File(string name) : base(name)
    {
    }
}
