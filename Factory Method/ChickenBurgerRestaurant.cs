

public class ChickenBurgerRestaurant : Restaurant
{
    public override Burger createBurger()
    {
        return new ChickenBurger();
    }
}
