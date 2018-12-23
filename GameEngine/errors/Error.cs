namespace GameEngine.errors
{
	public static class Error
	{
		public static string NonPositiveAttribute(int value) => $"Attribute value must be grater or equal zero. Current value: {value}.";
		public static string NonPositiveDamage(int value) => $"Damage value must be grater or equal zero. Current value: {value}.";
		public static string NonPositiveResistance(int value) => $"Resistance value must be grater or equal zero. Current value: {value}.";
		public static string NonPositivePoints(int value) => $"Points value must be grater or equal zero. Current value: {value}.";
		public static string NonPositiveArgument(int value) => $"Argument value must be greater or equal zero. Current value: {value}.";
		public static string NotEnoughGold(int current, int value) => $"You don't have enough gold. Current value: {current}. You need: {value}";
	}
}
