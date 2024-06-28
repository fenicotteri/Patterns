

using MediatorPattern;

ConcreteMediator mediator = new ();

Programmer programmer = new (mediator);
Tester tester = new (mediator);
Customer customer = new (mediator);

mediator.Customer = customer;
mediator.Programmer = programmer;
mediator.Tester = tester;

mediator.Send("Есть заказ, надо сделать программу", customer);
customer.Send("Есть заказ, надо сделать программу");
customer.Notify("hi");
