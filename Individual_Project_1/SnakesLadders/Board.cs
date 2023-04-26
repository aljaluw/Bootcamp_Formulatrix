namespace SnakesLadders;

public class Board
{
    public int[] GameBoard { get; }

    public Board()
    {
        GameBoard = CreateBoard(100);
    }

    public Board(int x, int y,
        (int, int)[] laddersAndSnakes = null)
    {

        // Ensure non-null arrays.
        laddersAndSnakes = laddersAndSnakes ?? Array.Empty<(int, int)>();

        GameBoard = CreateBoard(x * y);
        
        CreateSnakesAndLadders(laddersAndSnakes);
    }

    private int[] CreateBoard(int size)
    {
        int[] board = new int[size];
        for (int i = 0; i < size; i++) {
            board[i] = i;
        }
        return board;
    }

    private void CreateSnakesAndLadders((int, int)[] jumps)
    {
        foreach (var (from, to) in jumps) {
            GameBoard[from - 1] = to - 1;
        }
    }
}
