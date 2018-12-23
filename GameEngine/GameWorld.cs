using System;
using System.Linq;

namespace GameEngine
{
	public class GameWorld
	{
		private readonly Field[] _fields = {
			new Field(-1, 1),
			new Field(0, 1),
			new Field(1, 1),
			new Field(-1, 0),
			new Field(0 , 0),
			new Field(1, 0),
			new Field(-1, -1),
			new Field(0, -1),
			new Field(1, -1)};

		public void Move(CharacterOld characterOld, MoveDirection direction)
		{
			Position newPosition;

			switch (direction)
			{
				case MoveDirection.Up:
					newPosition = new Position(characterOld.Position.X, characterOld.Position.Y + 1);
					break;
				case MoveDirection.Down:
					newPosition = new Position(characterOld.Position.X, characterOld.Position.Y - 1);
					break;
				case MoveDirection.Left:
					newPosition = new Position(characterOld.Position.X - 1, characterOld.Position.Y);
					break;
				case MoveDirection.Right:
					newPosition = new Position(characterOld.Position.X + 1, characterOld.Position.Y);
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
			}

			var field = _fields.FirstOrDefault(f => f.Position == newPosition &&
										 f.FieldStatus == FieldStatus.Empty);

			if (field != null)
			{
				characterOld.Position = newPosition;
				field.FieldStatus = FieldStatus.Busy;
			}
		}
	}
}
