namespace SnakesLadders;

public class SnakeLadderCreator
{
    public static Dictionary<int, int> CreateSnakeLadder((int, int)[] jumps)
    {
        Dictionary<int, int> snakeLadderDictionary = new Dictionary<int, int>();

        foreach (var (from, to) in jumps) {
            snakeLadderDictionary[from] = to;
        }
        return snakeLadderDictionary;
    }
}
