using System;


namespace BattleShip
{
	class Board
	{
		// fields
		public const int boardSize = 4;
		public readonly int Width;
		public readonly int Height;

		// properties


		// constructor
		public Board(int width, int height)
		{
			Width = width;
			Height = height;
		}

		// methods
		public bool OnBoard(BoardLocation boardLocation)
		{
			// return true if the boardLocation is on the Board
			return boardLocation.X >= 0 && boardLocation.X < boardSize &&
				   boardLocation.Y >= 0 && boardLocation.Y < boardSize;		
		}

	}
}
