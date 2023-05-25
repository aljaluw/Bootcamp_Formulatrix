using System;
using System.Collections.Generic;

namespace SnakesLadders
{
    public class Controller
    {
        private Board board;
        private List<Player> players;
        private int currentPlayerIndex;

        public Controller()
        {
            (int, int)[] laddersAndSnakes = {
                (2, 38), (7, 14), (8, 31), (16, 26), (21, 42),
                (28, 84), (36, 44), (51, 68), (71, 91), (78, 98), (87, 94),
                (15, 5), (48, 10), (45, 24), (61, 18), (63, 59),
                (73, 52), (88, 67), (91, 87), (94, 74), (98, 79)
            };

            Rules.CheckLaddersAndSnakes(laddersAndSnakes);

            board = new Board(10, 10, laddersAndSnakes);
            players = new List<Player>();
        }

        public void StartGame()
        {
            int numPlayers;
            do
            {
                Console.Write("Enter the number of players: ");
                numPlayers = Convert.ToInt32(Console.ReadLine());

                if (numPlayers <= 1)
                {
                    Console.WriteLine("The total number of players needs to be 2 or more.");
                }
            } while (numPlayers <= 1);

            for (int i = 1; i <= numPlayers; i++)
            {
                Console.Write($"Enter the name for player {i}: ");
                string nickName = Console.ReadLine();

                players.Add(new Player(nickName, board));
            }

            currentPlayerIndex = 0;
            PlayGame();
        }

        private void PlayGame()
        {
            char pressed;
            do
            {
                Player currentPlayer = players[currentPlayerIndex];
                Console.WriteLine($"It's player {currentPlayer.NickName}'s turn");
                Console.WriteLine("Press R to roll the dice or A to abort the game.");
                pressed = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (pressed == 'R')
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine(" ");

                    currentPlayer.Roll();
                    Console.WriteLine($"Dice's result: {currentPlayer.DiceResult} ");

                    int previousPosition = currentPlayer.Position;
                    currentPlayer.Move();
                    Console.WriteLine($"{currentPlayer.NickName} moved from cell [{previousPosition}] ====> to cell [{currentPlayer.Position}]");

                    if (currentPlayer.DiceResult == 6)
                    {
                        Console.WriteLine("Congratulations! You rolled a 6 and get to roll again.");
                        continue;
                    }

                    if (currentPlayer.Winner)
                    {
                        Console.WriteLine($"Player {currentPlayer.NickName} won the game.");
                        break;
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("--------------------------------");

                    currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
                }
            } while (pressed != 'A');
        }
    }
}