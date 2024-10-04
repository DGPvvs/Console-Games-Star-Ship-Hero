namespace TestGameStarShips.IO
{
	using GameStarShips.IO.Contracts;
	using System.Text;

	internal class Writer : IWrite
	{
		private StringBuilder result;

        public Writer()
        {
            result = new StringBuilder();
        }

        public string Result
		{
			get => result.ToString();
			private set => result = new StringBuilder(value);
		}

		public void ClearScrean()
		{
			this.Result = string.Empty;
		}

		public void Write(string s)
		{
			this.result.Append(s);
		}

		public void WriteLine(string s)
		{
			this.Write(s);
			this.result.AppendLine();
		}
	}
}
