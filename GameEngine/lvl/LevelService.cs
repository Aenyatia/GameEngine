using GameEngine.ver;

namespace GameEngine.lvl
{
	public class LevelService
	{
		public void UpdateCharacte(Character character, int value)
		{
			AddExperience(character, value);

			if (character.Experience.Current >= character.Experience.NextLevel)
				LevelUp(character);
		}

		private static void AddExperience(Character character, int value)
		{
			character.Experience.Current += value;
		}

		private static void LevelUp(Character character)
		{
			character.Health.Max += 10;
			character.Health.Current += 10;

			character.Mana.Max += 10;
			character.Mana.Current += 10;

			character.Experience.Level += 1;
			character.Experience.NextLevel += 100;
		}
	}
}
