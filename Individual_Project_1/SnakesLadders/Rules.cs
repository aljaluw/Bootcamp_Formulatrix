namespace SnakesLadders;

public class Rules
{
    public static void CheckLaddersAndSnakes((int, int)[] laddersAndSnakes)
    {
        for (int i = 0; i < laddersAndSnakes.Length; i++)
        {
            int currentStart = laddersAndSnakes[i].Item1;
            int currentEnd = laddersAndSnakes[i].Item2;

            // Check if current pair matches any previous pair
            for (int j = 0; j < i; j++)
            {
                int previousStart = laddersAndSnakes[j].Item1;
                int previousEnd = laddersAndSnakes[j].Item2;

                if (currentStart == previousStart || currentEnd == previousEnd)
                {
                    Console.WriteLine($"Error: ({currentStart}, {currentEnd}) overlaps with ({previousStart}, {previousEnd}).");
                    throw new Exception("Error! Make sure that none of the ladders/snakes overlap with one another.");
                }
            }

            if (currentEnd > currentStart)
            {
                Console.WriteLine($"({currentStart}, {currentEnd}) is a ladder.");
            }
            else if (currentEnd < currentStart)
            {
                Console.WriteLine($"({currentStart}, {currentEnd}) is a snake.");
            }
            else
            {
                Console.WriteLine($"({currentStart}, {currentEnd}) is not a ladder or a snake.");
            }
        }
    }

}

