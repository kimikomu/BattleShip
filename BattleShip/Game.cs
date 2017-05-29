using System;

namespace BattleShip
{
	class Game
	{
		static void Main()
		{	
			//initialize objects
			Board p1board = new Board(Board.boardSize, Board.boardSize);
			Board p2board = new Board(Board.boardSize, Board.boardSize);

			// One hot mess
			int xTest1 = 0;
			int yTest1 = 0;
			int xTest2 = 0;
			int yTest2 = 0;

			Console.Write("Player 1, Enter your ship's locations: ");
			Console.Write("Test Ship X: ");
			string xInput = Console.ReadLine();
			xTest1 = Int32.Parse(xInput);
			Console.Write("Test Ship Y: ");
			string yInput = Console.ReadLine();
			yTest1 = Int32.Parse(yInput);

			BoardLocation testShipLocation = new BoardLocation(xTest1, yTest1);

			Console.Write("Player 2, Enter your ship's locations: ");
			Console.Write("Test Ship X: ");
			string xInput2 = Console.ReadLine();
			xTest2 = Int32.Parse(xInput2);
			Console.Write("Test Ship Y: ");
			string yInput2 = Console.ReadLine();
			yTest2 = Int32.Parse(yInput2);

			BoardLocation testShipLocation2 = new BoardLocation(xTest2, yTest2);



			Ship firstShipP1 = new Ship(1, testShipLocation);
			Ship firstShipP2 = new Ship(1, testShipLocation2);

			Console.WriteLine("TEST. Ship Location 1: " + testShipLocation);
			Console.WriteLine("TEST. Ship Location 2: " + testShipLocation2);

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
