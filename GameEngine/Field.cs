namespace GameEngine
{
	public class Field
	{
		public Position Position { get; set; }
		public FieldStatus FieldStatus { get; set; }

		public Field(int x, int y)
		{
			Position = new Position(x, y);
			FieldStatus = FieldStatus.Empty;
		}
	}
}
