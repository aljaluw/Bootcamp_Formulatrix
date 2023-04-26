namespace SnakesLadders;

public class Player : Dice
{
    private readonly int[] _board;

    private int _position;
    public int Position => _position + 1;

    public string NickName { get; }
    public bool Winner { get; private set; }

    public Player(string nickName, Board board)
    {
        NickName = nickName;
        _board = board.GameBoard;
    }

    public void Move()
    {
        int previousPosition = _position;
        int newPosition = DiceResult + _position;

        if (newPosition < _board.Length) // check if new position is within bounds
        {
            _position = _board[newPosition];

            if (_position == _board.Length - 1)
            {
                Winner = true;
            }

            if (_board[newPosition] != newPosition)
            {
                string jumpType = _position > previousPosition ? "Ladder" : "Snake";
                Console.WriteLine($"You have landed on a {jumpType} and moved to position {_position + 1}.");
            }
        }
        else
        {
            Console.WriteLine("You rolled too high! Try again.");
        }
    }
}
