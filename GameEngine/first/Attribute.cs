using GameEngine.enumTypes;
using GameEngine.errors;
using System;

namespace GameEngine.first
{
	public sealed class Attribute
	{
		public AttributeType Type { get; }
		public int Value { get; private set; }

		private Attribute(AttributeType type, int value)
		{
			Type = type;
			SetValue(value);
		}

		public static Attribute Strength(int value)
			=> new Attribute(AttributeType.Strength, value);

		public static Attribute Dexterity(int value)
			=> new Attribute(AttributeType.Dexterity, value);

		public static Attribute Intelligence(int value)
			=> new Attribute(AttributeType.Intelligence, value);

		public void SetValue(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveAttribute(value), nameof(value));

			Value = value;
		}

		public void Increase(int value)
		{
			if (value < 0)
				throw new ArgumentException(Error.NonPositiveArgument(value), nameof(value));

			Value += value;
		}

		public static implicit operator int(Attribute attribute)
			=> attribute.Value;
	}
}
