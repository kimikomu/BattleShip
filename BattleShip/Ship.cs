using System;

namespace BattleShip
{
	class Ship
	{
		// fields
		private int _size;
		private BoardLocation _location;

		//properties
		public int Size { get; set; }
		public BoardLocation Location { get; set; }

		// constructor
		public Ship(int size, BoardLocation location)
		{
			_size = size;
			_location = location;
		}

		// methods
	}
}
