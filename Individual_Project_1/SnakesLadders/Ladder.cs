namespace SnakesLadders;

public class Ladder : IPiece
{
    private int _startCell;
    private int _endCell;

    public Ladder(int startCell, int endCell)
    {
        this._startCell = startCell;
        this._endCell = endCell;
    }

    public int GetStartCell();
    public int GetEndCell();
    public bool isOnObject(int Cell);
}
