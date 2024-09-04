namespace GameStarShips.GamePlayer.Models.PlayerModel
{
	using GameStarShips.Data.Enums;

	public class PlayerStatus
	{
		public PlayerStatus()
		{
			this.InitNewPlayerStatus();
		}

		public PlayerStatus(int[] checksums, int previousValueChecksum1, int previousValueChecksum5, int currentEpizodeIndex, bool isCurrentExecut)
		{
			this.Checksums = checksums;
			this.PreviousValueChecksum1 = previousValueChecksum1;
			this.PreviousValueChecksum5 = previousValueChecksum5;
			this.CurrentEpizodeIndex = currentEpizodeIndex;
			this.IsCurrentExecut = isCurrentExecut;
		}

		public int[] Checksums { get; set; }
		public int PreviousValueChecksum1 { get; set; }
		public int PreviousValueChecksum5 { get; set; }
		public int CurrentEpizodeIndex { get; set; }
		public bool IsCurrentExecut { get; private set; }

		public int TottalResult => (this.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex2] + this.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex2]) * 3 +
									this.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex7] + this.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex8] +
									this.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex9];
		//PlayerStatus – Клас описващ текущото състояние на героя
		//Checksums – int[10], Масив показващ текущите контролни суми
		//PreviousValueChecksum1 – int, Предходна стойност на първа контролна сума
		//PreviousValueChecksum5 – int, Предходна стойност на пета контролна сума
		//CurrentEpizodeIndex – int, индекс на текущия епизод
		//IsCurrentExecut - bool, фвяг указващ дали е изпълнено условието в текущия епизод

		public void InitNewPlayerStatus()
		{
			this.Checksums = new int[]
			{ 0, 20, 10, 4, 20, 0, 0, 0, 0, 30 };
			this.PreviousValueChecksum1 = 0;
			this.PreviousValueChecksum5 = 0;
			this.CurrentEpizodeIndex = 1;
			this.IsCurrentExecut = false;
		}
	}

}
