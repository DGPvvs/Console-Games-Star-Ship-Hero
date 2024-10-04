namespace TestGameStarShips.IO
{
	using GameStarShips.IO.Contracts;

	internal class Reader : IRead
	{
		private string result;

		public string Result
		{
			get => result;
			set => result = value;
		}

		public string? ReadLine() => this.Result;
	}
}
