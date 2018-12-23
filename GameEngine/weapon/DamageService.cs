using GameEngine.ver;

namespace GameEngine.weapon
{
	public class DamageService
	{
		public int CalculateDamage(Weapon weapon, Character character)
		{
			if (weapon.Type == "Physical")
				return weapon.RawDamage - character.Resistance.Physical;

			return weapon.RawDamage - character.Resistance.Magical;
		}
	}
}
