namespace Pizza;

public class BlackDoughFill : FillDecorator
{
    public BlackDoughFill(IPizza newPizza) : base(newPizza)
    {
        System.Console.WriteLine("Black Dough");
    }
    public override string getDescription()
    {
        return tempPizza.getDescription() + ", Black dough fill";
    }

    public override double getCost()
    {
        return tempPizza.getCost() + 1.75;
    }
}
