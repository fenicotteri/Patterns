
using BuilderPattern;

CakeBuilder cakeA = new CakeABuilder();

Baker baker = new Baker(cakeA);
baker.BakeTheCake();
Cake cakeResultA = baker.GetCake();

cakeResultA.ShowDetails();

CakeBuilder cakeB = new CakeBBuilder();
baker.SetCakeBuilder(cakeB);
baker.BakeTheCake();
Cake cakeResultB = baker.GetCake();

cakeResultB.ShowDetails();
