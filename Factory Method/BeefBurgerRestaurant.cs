

public class BeefBurgerRestaurant : Restaurant
{
    public override Burger createBurger()
    {
        return new BeefBurger();
    }
}
