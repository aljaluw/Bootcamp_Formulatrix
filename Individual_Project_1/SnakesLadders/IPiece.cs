namespace SnakesLadders;

public interface IPiece
{
    public int GetStartCell();
    public int GetEndCell();
    public bool isOnObject(int Cell);
}
