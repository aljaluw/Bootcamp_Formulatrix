namespace Pizza;

public class PlainPizza : IPizza
{
    public string getDescription()
    {
        return "Thin dough";
    }

    public double getCost()
    {
        return 5.75;
    }
}
