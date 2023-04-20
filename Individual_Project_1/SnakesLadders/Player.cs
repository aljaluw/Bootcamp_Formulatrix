namespace SnakesLadders;

public class Player : Dice
{
    private static readonly Random _rnd = new Random();
    private readonly int[] _board;

    private int _position;
    public int Position => _position + 1;

    public string NickName { get; }
    public Colors colors { get; }
    public bool Winner { get; private set; }

    public Player(string nickName, Board board)
    {
        NickName = nickName;
        _board = board.GameBoard;
    }

    public void Move()
    {
        if (_position + DiceResult < _board.Length) {
            _position = _board[DiceResult + _position];
            if (_position == _board.Length - 1) {
                Winner = true;
            }
        }
    }
}
