namespace GameEngine
{
	public class Position
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Position()
		{

		}

		public Position(int x, int y)
		{
			X = x;
			Y = y;
		}

		public override bool Equals(object other)
		{
			if (other == null)
				return false;

			var position = (Position)other;

			return X == position.X && Y == position.Y;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (X * 397) ^ Y;
			}
		}

		public static bool operator ==(Position left, Position right)
		{
			if (left == null && right == null)
				return true;

			if (left == null || right == null)
				return false;

			return left.Equals(right);
		}

		public static bool operator !=(Position a, Position b)
		{
			return !(a == b);
		}
	}
}
