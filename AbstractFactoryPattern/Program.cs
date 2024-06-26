
using AbstractFactoryPattern;

AbstructFactory abstructFactory;

abstructFactory = new Factory_B();
abstructFactory.CreateB().Info();
abstructFactory.CreateE().Info();

abstructFactory = new Factory_M();
abstructFactory.CreateB().Info();
abstructFactory.CreateE().Info();
