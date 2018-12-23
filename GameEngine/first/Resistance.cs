using GameEngine.enumTypes;
using GameEngine.errors;
using System;

namespace GameEngine.first
{
	public sealed class Resistance
	{
		public AttackType Type { get; }
		public int Value { get; private set; }

		private Resistance(AttackType type, int value)
		{
			Type = type;
			SetValue(value);
		}

		public static Resistance PhysicalResist(int value)
			=> new Resistance(AttackType.Physical, value);

		public static Resistance MagicResist(int value)
			=> new Resistance(AttackType.Magic, value);

		public void SetValue(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveResistance(value), nameof(value));

			Value = value;
		}

		public static implicit operator int(Resistance resistance)
			=> resistance.Value;
	}
}
