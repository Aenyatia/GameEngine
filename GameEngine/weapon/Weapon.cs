using GameEngine.ver;

namespace GameEngine.weapon
{
	public class Weapon
	{
		public int RawDamage { get; set; }
		public string Type { get; set; }

		public void Hit(Character character)
		{
			var dmg = new DamageService().CalculateDamage(this, character);

			character.TakeDamage(dmg);
		}
	}
}
