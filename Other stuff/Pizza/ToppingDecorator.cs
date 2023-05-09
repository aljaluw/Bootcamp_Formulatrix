namespace Pizza;

public abstract class ToppingDecorator : IPizza
{
    protected IPizza tempPizza;

    public ToppingDecorator(IPizza newPizza)
    {
        this.tempPizza = newPizza;
    }

    public virtual string getDescription()
    {
        return tempPizza.getDescription();
    }

    public virtual double getCost()
    {
        return tempPizza.getCost();
    }
}
