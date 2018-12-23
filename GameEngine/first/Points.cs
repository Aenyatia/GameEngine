using GameEngine.enumTypes;
using GameEngine.errors;
using System;

namespace GameEngine.first
{
	public sealed class Points
	{
		public PointType Type { get; }
		public int CurrentValue { get; private set; }
		public int MaxValue { get; private set; }

		public bool IsFull => CurrentValue == MaxValue;

		private Points(PointType type, int value)
		{
			Type = type;
			SetPoints(value);
		}

		public static Points Health(int value)
			=> new Points(PointType.Health, value);

		public static Points Mana(int value)
			=> new Points(PointType.Mana, value);

		public static Points Stamina(int value)
			=> new Points(PointType.Stamina, value);

		public void SetPoints(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositivePoints(value), nameof(value));

			CurrentValue = value;
			MaxValue = value;
		}

		public void AddPoints(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveArgument(value), nameof(value));

			CurrentValue = CurrentValue + value > MaxValue
				? MaxValue
				: CurrentValue += value;
		}

		public void SubtractPoints(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveArgument(value), nameof(value));

			CurrentValue = CurrentValue - value < 0
				? 0
				: CurrentValue -= value;
		}

		public void IncreaseMax(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveArgument(value), nameof(value));

			MaxValue += value;
			AddPoints(value);
		}

		public static implicit operator int(Points points)
			=> points.CurrentValue;
	}
}
