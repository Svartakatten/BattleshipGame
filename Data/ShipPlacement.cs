using System;

/*
Design Patterns Implemented:
1. Singleton: Used for the GameBoard class to ensure only one game board instance exists.
2. Factory Method: Used to create different types of ships.
3. Strategy: Used to implement different strategies for placing ships on the board.
*/

namespace BattleshipGame.Data
{
    // Abstract Strategy class
    public interface IPlacementStrategy
    {
        void PlaceShip(Ship ship, GameBoard board);
    }

    // Concrete Strategy class for random placement
    public class RandomPlacementStrategy : IPlacementStrategy
    {
        private Random _random = new Random();

        public void PlaceShip(Ship ship, GameBoard board)
        {
            int size = board.Board.GetLength(0);
            while (true)
            {
                int row = _random.Next(size);
                int col = _random.Next(size);

                // Ensure the ship fits and the space is available
                if (col + ship.Size <= size)
                {
                    bool spaceAvailable = true;
                    for (int i = 0; i < ship.Size; i++)
                    {
                        if (board.Board[row, col + i] != '~')
                        {
                            spaceAvailable = false;
                            break;
                        }
                    }

                    if (spaceAvailable)
                    {
                        for (int i = 0; i < ship.Size; i++)
                        {
                            board.Board[row, col + i] = ship.Name[0];
                        }
                        break;
                    }
                }
            }
        }
    }
}
