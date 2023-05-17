////Factory method is a creational design pattern
////we don't need to use the 'new' keyword anymore, it is replaced by a call to factory method

//Restaurant beefRes = new BeefBurgerRestaurant();
//Restaurant chickenRes = new ChickenBurgerRestaurant();


//Console.WriteLine(beefRes.createBurger().ToString());
//Console.WriteLine(chickenRes.createBurger().ToString());


Logistics sea = new SeaLogistics();
Logistics road = new RoadLogistics();

Console.WriteLine(sea.createTransport().ToString());

Console.WriteLine(road.createTransport().ToString());
