namespace SnakesLadders;

public class Dice
{
    private static readonly int _numberOfSides = 6;
    private static readonly Random _rnd = new Random();

    public int DiceResult { get; set; }

    public void Roll()
    {
        DiceResult =  _rnd.Next(1, _numberOfSides+1);
    }
}
