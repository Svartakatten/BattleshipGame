using System;

/*
Design Patterns Implemented:
1. Singleton: Used for the GameBoard class to ensure only one game board instance exists.
2. Factory Method: Used to create different types of ships.
3. Strategy: Used to implement different strategies for placing ships on the board.
*/

namespace BattleshipGame.Data
{
    // Abstract Ship class
    public abstract class Ship
    {
        public int Size { get; protected set; }
        public string Name { get; protected set; }
        public abstract string GetType();
    }

    // Concrete Ship classes
    public class Battleship : Ship
    {
        public Battleship()
        {
            Size = 4;
            Name = "Battleship";
        }

        public override string GetType()
        {
            return "Battleship";
        }
    }

    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Size = 3;
            Name = "Destroyer";
        }

        public override string GetType()
        {
            return "Destroyer";
        }
    }

    // ShipFactory class in order to create ships
    public static class ShipFactory
    {
        public static Ship CreateShip(string shipType)
        {
            switch (shipType)
            {
                case "Battleship":
                    return new Battleship();
                case "Destroyer":
                    return new Destroyer();
                default:
                    throw new ArgumentException("Unknown ship type");
            }
        }
    }
}
