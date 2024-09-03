namespace ConsoleGames.IO
{
	using GameStarShips.IO.Contracts;
	using System.Text;

	internal class ConsoleGameWriter : IWrite
	{
		public void ClearScrean()
		{
			Console.Clear();
		}

		public void Write(string s)
		{
			Console.Write(s);
		}

		public void WriteLine(string s)
		{
			Console.WriteLine(this.FormatOutput(s));
		}

		private string FormatOutput(string s)
		{
			StringBuilder sb = new StringBuilder();

			string[] textArray = s.Split(Environment.NewLine);

			int origWidth = Console.WindowWidth;

			foreach (var text in textArray)
			{
				string[] paragraphArray = text.Split(" ");

				int currentWidth = origWidth;
				bool isFirst = true;
				StringBuilder tempSb = new StringBuilder();

				foreach (var paragraph in paragraphArray)
				{
					string tmp = paragraph;

					if (isFirst && (tmp.Length + 3) < currentWidth)
					{
						tempSb.Append("   " + tmp);
						isFirst = false;
						currentWidth -= ("   " + tmp).Length;
					}
					else if ((tmp.Length + 1) < currentWidth)
					{
						tempSb.Append(" " + tmp);
						currentWidth -= (" " + tmp).Length;
					}
					else
					{
						sb.AppendLine(tempSb.ToString());
						tempSb = new StringBuilder(tmp);
						currentWidth = origWidth - tmp.Length;
					}
				}

				sb.AppendLine(tempSb.ToString());
			}

			return sb.ToString().TrimEnd();
		}
	}
}
