namespace GameEngine.first
{
	public class Player
	{
		public string Name { get; set; }
		public Gold Gold { get; set; }

		public Points Health { get; set; }
		public Points Mana { get; set; }
		public Points Stamina { get; set; }

		public Attribute Strength { get; set; }
		public Attribute Dexterity { get; set; }
		public Attribute Intelligence { get; set; }

		public Damage PhysicalDamage { get; set; }
		public Damage MagicDamage { get; set; }
		public Resistance PhysicalResist { get; set; }
		public Resistance MagicResis { get; set; }

		public bool IsAlive => Health > 0;

		public void Attack(Player player)
		{
			var dmg = GetAttackDamage() - player.GetResistance();

			player.TakeDamage(dmg);
		}

		public void TakeDamage(int value)
		{
			Health.SubtractPoints(value);
		}

		public int GetAttackDamage()
		{
			return Strength;
		}

		public int GetResistance()
		{
			return PhysicalResist;
		}

		public override string ToString()
		{
			var result = string.Empty;

			result += "Basics \n";
			result += $"   Name: {Name} \n";
			result += $"   Health: {Health.CurrentValue}/{Health.MaxValue} \n";
			result += $"   Mana: {Mana.CurrentValue}/{Mana.MaxValue} \n";
			result += $"   Stamina: {Stamina.CurrentValue}/{Stamina.MaxValue} \n";

			result += "Attributes \n";
			result += $"   Strength: {Strength.Value} \n";
			result += $"   Dexterity: {Dexterity.Value} \n";
			result += $"   Intelligence: {Intelligence.Value} \n";

			result += "Damages \n";
			result += $"   Physical: {PhysicalDamage.Value} \n";
			result += $"   Magic: {MagicDamage.Value} \n";

			result += "Resists \n";
			result += $"   Physical: {PhysicalResist.Value} \n";
			result += $"   Magic: {MagicResis.Value} \n";

			result += $"\n   Gold: {Gold.Value} \n\n";

			return result;
		}
	}
}
