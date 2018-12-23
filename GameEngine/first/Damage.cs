using GameEngine.enumTypes;
using System;
using GameEngine.errors;

namespace GameEngine.first
{
	public sealed class Damage
	{
		public AttackType Type { get; }
		public int Value { get; private set; }

		private Damage(AttackType type, int value)
		{
			Type = type;
			SetValue(value);
		}

		public static Damage PhysicalDamage(int value)
			=> new Damage(AttackType.Physical, value);

		public static Damage MagicDamage(int value)
			=> new Damage(AttackType.Magic, value);

		public void SetValue(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveDamage(value), nameof(value));

			Value = value;
		}

		public static implicit operator int(Damage damage)
			=> damage.Value;
	}
}
