using System;

namespace BattleShip
{
	class Game
	{
		static void Main()
		{	
			//initialize objects
			Board board = new Board(Board.boardSize, Board.boardSize);
			Ship firstShip = new Ship(1);
			Player player1 = new Player();

			try
			{
				player1.SetShipLocation(firstShip, board);

				BoardLocation location = firstShip.Location;
				Console.WriteLine("Ship is set to location " + location.X + " ," + location.Y);		// NOT WORKING


			}
			catch (OutOfBoundsException ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.Read();
			// Player player1 = new Player;
			// Player player2 = new Player;


			// player1 chooses where to place ships on p1board

			// player2 chooses where to place ships on p2board

			// start game

			// p1 chooses a boardLocation on p2board
			// if hit p2 ship takes damage

			// p2 chooses a boardLocation on p1board
			// if hit p2 ship takes damage 

		}


	}
}
