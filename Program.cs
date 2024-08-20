using System;
using BattleshipGame.Data;

/*
Design Patterns Implemented:
1. Singleton: Used for the GameBoard class to ensure only one game board instance exists.
2. Factory Method: Used to create different types of ships.
3. Strategy: Used to implement different strategies for placing ships on the board.
*/

namespace BattleshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton Pattern: Creating a single instance of the game board
            GameBoard board = GameBoard.GetInstance(10);

            // Factory Method Pattern: Creating ships
            Ship battleship = ShipFactory.CreateShip("Battleship");
            Ship destroyer = ShipFactory.CreateShip("Destroyer");

            // Strategy Pattern: Placing ships using a strategy
            IPlacementStrategy placementStrategy = new RandomPlacementStrategy();
            placementStrategy.PlaceShip(battleship, board);
            placementStrategy.PlaceShip(destroyer, board);

            // Display the game board
            board.DisplayBoard();
        }
    }
}
