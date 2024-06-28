
using StatePattern;

Water water = new Water(new LiquidWaterState());
water.Frost();
Console.WriteLine(water.State);

water.Heat();
water.Heat();
Console.WriteLine(water.State);