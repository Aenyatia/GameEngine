using GameEngine.errors;
using System;

namespace GameEngine.first
{
	public sealed class Gold
	{
		public int Value { get; private set; }

		private Gold(int value)
		{
			SetGold(value);
		}

		public static Gold Create(int value)
			=> new Gold(value);

		public void SetGold(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveArgument(value), nameof(value));

			Value = value;
		}

		public void AddGold(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveArgument(value), nameof(value));

			Value += value;
		}

		public void SubtractGold(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveArgument(value), nameof(value));

			if (!IsEnough(value))
				throw new ArgumentException(Error.NotEnoughGold(Value, value), nameof(value));

			Value -= value;
		}

		public bool IsEnough(int gold)
		{
			return Value - gold > 0;
		}

		public static implicit operator int(Gold gold)
			=> gold.Value;
	}
}
