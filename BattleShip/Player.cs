using System;

namespace BattleShip
{
	class Player
	{
		// player class keeps track of which player's turn it is? Or should that go to board or game?

		// player class chooses where to place the ship on the board <- make a method

		// fields


		// properties

		// constructor
		public Player()
		{
		}

		// methods
		public BoardLocation SetShipLocation(Ship ship, Board board)
		{
			Console.WriteLine("Enter position on the board for the ship.");
			string input = Console.ReadLine();

			char xChar = input[0];
			char yChar = input[3];

			int x = (int)Char.GetNumericValue(xChar);
			int y = (int)Char.GetNumericValue(yChar);

			return new BoardLocation(x, y, board);
		}
	}
}
