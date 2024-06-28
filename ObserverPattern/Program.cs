
using ObserverPattern;

Teacher MariaGA = new ();

Student student1 = new ();
Student student2 = new ();

MariaGA.Register(student1.Answer);
MariaGA.Register(student2.Answer);

MariaGA.Notify();