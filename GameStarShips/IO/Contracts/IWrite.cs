namespace GameStarShips.IO.Contracts
{
	public interface IWrite
	{
		public void Write(string s);
		public void WriteLine(string s);

		public void ClearScrean();
	}
}
