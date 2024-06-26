using ObjectPoolPattern;

ObjectPool pool = ObjectPool.Instance;
Resource one;
Resource two;

/* Создаются 2 новых экземпляра ресурсов */
one = pool.GetResource();
one.SetValue(10);
Console.WriteLine($"one = { one.GetValue()} хеш-код: {one.GetHashCode()}");
two = pool.GetResource();
two.SetValue(20);
Console.WriteLine($"two = {two.GetValue()} хеш-код: {two.GetHashCode()}");

//Экземпляры переводятся в пул.
pool.ReturnResource(one);
pool.ReturnResource(two);

// Экземпляры будут использоваться повторно.
one = pool.GetResource();
Console.WriteLine($"one = {one.GetValue()} хеш-код: {one.GetHashCode()}");
two = pool.GetResource();
Console.WriteLine ($"two = {two.GetValue()} хеш-код: {two.GetHashCode()}");
