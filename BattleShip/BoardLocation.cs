using System;

namespace BattleShip
{
	class BoardLocation : Point
	{
		public BoardLocation(int x, int y, Board board) : base(x, y)
		{
			if (!board.OnBoard(this))
			{
				throw new OutOfBoundsException($"{x}, {y} is outside the boundary of the board.");
			}
		}

		// methods
	}
}
