namespace SnakesLadders;

public class Snake
{
    private int _startCell;
    private int _endCell;

    public Snake(int _startCell, int _endCell)
    {
        this._startCell = _startCell;
        this._endCell = _endCell;
    }

    public int GetStartCell();
    public int GetEndCell();
    public bool isOnObject(int Cell);
}
