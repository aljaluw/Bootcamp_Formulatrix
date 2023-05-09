namespace Pizza;

public class TomatoSauceTopping : ToppingDecorator
{
    public TomatoSauceTopping(IPizza newPizza) : base(newPizza)
    {
        System.Console.WriteLine("Adding sauce");
    }
    public override string getDescription()
    {
        return tempPizza.getDescription() + ", Tomato Sauce Topping";
    }

    public override double getCost()
    {
        return tempPizza.getCost() + 2.00;
    }
}


