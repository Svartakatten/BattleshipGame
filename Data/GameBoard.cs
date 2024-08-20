using System;

/*
Design Patterns Implemented:
1. Singleton: Used for the GameBoard class to ensure only one game board instance exists.
2. Factory Method: Used to create different types of ships.
3. Strategy: Used to implement different strategies for placing ships on the board.
*/

namespace BattleshipGame.Data
{
    // Singleton Pattern for GameBoard
    public class GameBoard
    {
        private static GameBoard _instance;
        public char[,] Board { get; private set; }
        private int _size;

        private GameBoard(int size)
        {
            _size = size;
            Board = new char[size, size];
            InitializeBoard();
        }

        public static GameBoard GetInstance(int size = 10)
        {
            if (_instance == null)
            {
                _instance = new GameBoard(size);
            }
            return _instance;
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    Board[i, j] = '~';
                }
            }
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    Console.Write(Board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
