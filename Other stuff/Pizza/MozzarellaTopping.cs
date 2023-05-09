namespace Pizza;

public class MozzarellaTopping : ToppingDecorator
{
    public MozzarellaTopping(IPizza newPizza) : base(newPizza)
    {
        System.Console.WriteLine("Adding mozarella");
    }
    public override string getDescription()
    {
        return tempPizza.getDescription() + ", Mozzarella Topping";
    }

    public override double getCost()
    {
        return tempPizza.getCost() + 3.50;
    }
}

