
using SingletonPattern;

Singleton s = Singleton.getInstance("default");
Console.WriteLine(s.Name);

s = Singleton.getInstance("new");
Console.WriteLine(s.Name);


