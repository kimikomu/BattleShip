using System;

namespace BattleShip
{
	class BattleShipException : Exception
	{
		public BattleShipException()
		{

		}
		public BattleShipException(string message) : base(message)
		{

		}
	}

	class OutOfBoundsException : BattleShipException
	{
		public OutOfBoundsException()
		{

		}
		public OutOfBoundsException(string message) : base(message)
		{

		}
	}


}
