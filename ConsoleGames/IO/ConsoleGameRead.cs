namespace ConsoleGames.IO
{
	using GameStarShips.IO.Contracts;

	internal class ConsoleGameRead : IRead
	{
		public string? ReadLine() => Console.ReadLine();
	}
}
