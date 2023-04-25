using System;
using System.Collections;
using System.Collections.Generic;

namespace SnakesLadders;

public class Board
{
    public int[] GameBoard { get; }
    public Dictionary<int, int> Snakes { get; } = new Dictionary<int, int>();
    public Dictionary<int, int> Ladders { get; } = new Dictionary<int, int>();
    public Board()
    {
        GameBoard = CreateBoard(100);
    }

    public Board(int x, int y,
        (int, int)[] ladders = null, (int, int)[] snakes = null)
    {
        GameBoard = CreateBoard(x * y);

        ladders = ladders ?? Array.Empty<(int, int)>();
        snakes = snakes ?? Array.Empty<(int, int)>();
    }
    
    private int[] CreateBoard(int size)
    {
        int[] board = new int[size];
        for (int i = 0; i < size; i++) {
            board[i] = i;
        }
        return board;
    }
}