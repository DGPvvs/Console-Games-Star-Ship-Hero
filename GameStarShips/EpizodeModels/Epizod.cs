namespace GameStarShips.EpizodeModels
{
	using GameStarShips.Data.Enums;

	public class Epizod
	{
		public Epizod()
		{
			this.ChoisEpisodes = new List<ChoiseEpisode>();
		}

		public Epizod(int id, string decription, ConditionFlagsEnum conditionFlags, int conditionValue, int conditionValue2, int conditionValue3) : this()
		{
			this.Id = id;
			this.Decription = decription;
			this.ConditionFlags = conditionFlags;
			this.ConditionValue = conditionValue;
			this.ConditionValue2 = conditionValue2;
			this.ConditionValue3 = conditionValue3;
		}

		public int Id { get; set; }
		public string Decription { get; set; } = null!;

		public ConditionFlagsEnum ConditionFlags { get; set; }
		public int ConditionValue { get; set; }
		public int ConditionValue2 { get; set; }
		public int ConditionValue3 { get; set; }

		public List<ChoiseEpisode> ChoisEpisodes { get; set; }
	}
}


