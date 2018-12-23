namespace GameEngine.first
{
	public class PlayerBuilder
	{
		private readonly string _name;
		private readonly Gold _gold = Gold.Create(0);

		private readonly Points _health = Points.Health(100);
		private readonly Points _mana = Points.Mana(100);
		private readonly Points _stamina = Points.Stamina(100);

		private readonly Attribute _strength = Attribute.Strength(10);
		private readonly Attribute _dexterity = Attribute.Dexterity(10);
		private readonly Attribute _intelligence = Attribute.Intelligence(10);

		private readonly Damage _physicalDamage = Damage.PhysicalDamage(0);
		private readonly Damage _magicDamage = Damage.MagicDamage(0);
		private readonly Resistance _physicalResist = Resistance.PhysicalResist(0);
		private readonly Resistance _magicResis = Resistance.MagicResist(0);

		public PlayerBuilder(string name)
		{
			_name = name;
		}

		public static PlayerBuilder Create(string name)
		{
			return new PlayerBuilder(name);
		}

		public PlayerBuilder SetHealth(int value)
		{
			_health.SetPoints(value);
			return this;
		}

		public PlayerBuilder SetMana(int value)
		{
			_mana.SetPoints(value);
			return this;
		}

		public PlayerBuilder SetStamina(int value)
		{
			_stamina.SetPoints(value);
			return this;
		}

		public PlayerBuilder SetStrength(int value)
		{
			_strength.SetValue(value);
			return this;
		}

		public PlayerBuilder SetDexterity(int value)
		{
			_dexterity.SetValue(value);
			return this;
		}

		public PlayerBuilder SetIntelligence(int value)
		{
			_intelligence.SetValue(value);
			return this;
		}

		public PlayerBuilder SetPhysicalDamage(int value)
		{
			_physicalDamage.SetValue(value);
			return this;
		}

		public PlayerBuilder SetMagicDamage(int value)
		{
			_magicDamage.SetValue(value);
			return this;
		}

		public PlayerBuilder SetPhysicalResist(int value)
		{
			_physicalResist.SetValue(value);
			return this;
		}

		public PlayerBuilder SetMagicResist(int value)
		{
			_magicResis.SetValue(value);
			return this;
		}

		public PlayerBuilder SetGold(int value)
		{
			_gold.SetGold(value);
			return this;
		}

		public Player Build()
		{
			return new Player
			{
				Name = _name,
				Health = _health,
				Mana = _mana,
				Stamina = _stamina,
				Strength = _strength,
				Dexterity = _dexterity,
				Intelligence = _intelligence,
				PhysicalDamage = _physicalDamage,
				MagicDamage = _magicDamage,
				PhysicalResist = _physicalResist,
				MagicResis = _magicResis,
				Gold = _gold
			};
		}

		public static implicit operator Player(PlayerBuilder builder)
		{
			return builder.Build();
		}
	}
}
