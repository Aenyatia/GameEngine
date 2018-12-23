using GameEngine.first;
using System;

namespace GameEngine
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var kinga = PlayerBuilder.Create("Kinga")
				.SetGold(10000)
				.SetIntelligence(0)
				.SetStrength(20000)
				.SetHealth(200)
				.SetStamina(50)
				.Build();

			var bandit = PlayerBuilder.Create("Bandit").Build();

			Console.WriteLine(kinga);
			Console.WriteLine(bandit);

			kinga.Attack(bandit);

			Console.WriteLine(bandit);

			Console.ReadLine();
		}
	}
}
