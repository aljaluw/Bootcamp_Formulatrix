namespace Pizza;

static class Program
{
    public static void Main()
    {
        IPizza basicPizza = new PlainPizza();
        IPizza basicPizza2 = new PlainPizza();

        basicPizza = new MozzarellaTopping(basicPizza);
        basicPizza = new TomatoSauceTopping(basicPizza);
        basicPizza = new BlackDoughFill(basicPizza);
        
        basicPizza2 = new TomatoSauceTopping(basicPizza2);
        basicPizza2 = new BlackDoughFill(basicPizza2);

        System.Console.WriteLine($"\nPizza 1 with {basicPizza.getDescription()} is ${basicPizza.getCost()}");
        System.Console.WriteLine($"\nPizza 2 with {basicPizza2.getDescription()} is ${basicPizza2.getCost()}");
    }
}