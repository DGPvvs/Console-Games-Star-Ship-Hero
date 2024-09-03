namespace ConsoleGames
{
	using ConsoleGames.IO;
	using GameStarShips;
	using GameStarShips.IO.Contracts;

	internal class Program
	{
		static void Main(string[] args)
		{
			IRead reader = new ConsoleGameRead();
			IWrite writer = new ConsoleGameWriter();

			Game game = new Game(reader, writer, null); 

			game.Run();

			Console.WriteLine("Hello, World!");
		}
	}
}
