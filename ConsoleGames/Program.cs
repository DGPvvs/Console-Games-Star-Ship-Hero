namespace ConsoleGames
{
	using ConsoleGames.IO;
	using GameStarShips;
	using GameStarShips.GamePlayer.Models.PlayerModel;
	using GameStarShips.GamePlayer.Test;
	using GameStarShips.GamePlayer.Test.Contracts;
	using GameStarShips.IO.Contracts;
	using System;
	using System.Runtime.CompilerServices;

	internal class Program
	{
        static void Main(string[] args)
		{
			IRead reader = new ConsoleGameRead();
			IWrite writer = new ConsoleGameWriter();

			ITestData chois = ChoisStartUp();

			Game game = new Game(reader, writer, chois); 

			game.Run();

			writer.WriteLine("Hello, World!");

			//var r = new WhereEnumerableIterator<IList<int>>();
		}

		private static ITestData ChoisStartUp()
		{
			while (true)
			{

				Console.Clear();

				PrintStartOp();

				string input = Console.ReadLine();

				bool corectChois = int.TryParse(input, out int chois);

				if (corectChois)
				{
					if (chois == 1)
					{
						return null;
					}
					else if (chois == 2)
					{
						return new TestData(0, null, true);
					}
				}
                else
                {
					Console.WriteLine("Грешен избор!");
					Console.ReadLine();
				}
            }
		}

		private static void PrintStartOp()
		{
			string output = $"1 - Нова игра{Environment.NewLine}2 - Продължаване на записана игра";

			Console.WriteLine(output);
		}
	}
}
