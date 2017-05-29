using System;

namespace BattleShip
{
	class BoardLocation
	{
		// fields
		public readonly int X;
		public readonly int Y;

		// properties


		// constructor
		public BoardLocation(int x, int y, Board board)
		{
			X = x;
			Y = y;

			if (!board.OnBoard(this))
			{
				throw new OutOfBoundsException($"{x}, {y} is outside the boundary of the board.");
			}
		}

		// methods
	}
}
