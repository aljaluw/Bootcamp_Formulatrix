namespace Pizza;

public abstract class FillDecorator : IPizza
{
    protected IPizza tempPizza;

    public FillDecorator(IPizza newPizza)
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

