using GameEngine.armor;
using GameEngine.weapon;

namespace GameEngine.ver
{
	public class Character
	{
		public Information Information { get; set; }
		public Experience Experience { get; set; }

		public Health Health { get; set; }
		public Mana Mana { get; set; }

		public Attributes Attributes { get; set; }
		public Resistance Resistance { get; set; }

		public Weapon Weapon { get; set; }
		public Armor Armor { get; set; }

		public void Attack(Character character)
		{
			Weapon.Hit(character);
		}

		public void TakeDamage(int value)
		{
			Health.Current -= value;
		}
	}
}
