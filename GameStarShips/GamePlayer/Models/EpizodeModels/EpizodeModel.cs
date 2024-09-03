namespace GameStarShips.GamePlayer.Models.EpizodeModels
{
	using GameStarShips.Data.Enums;
	using GameStarShips.GamePlayer.Action;
	using GameStarShips.GamePlayer.Models.PlayerModel;

	public class EpizodeModel
	{
		public EpizodeModel()
		{
			this.ActionsList = new List<ActionDescription>();
		}

		public EpizodeModel(int id, string decription, ConditionFlagsEnum conditionFlags, ICollection<ActionDescription> actionsList, int conditionValue, int conditionValue2, int conditionValue3, PlayerStatus playerStatus)
		{
			this.Id = id;
			this.Decription = decription;
			this.ConditionFlags = conditionFlags;
			this.ActionsList = actionsList;
			this.ConditionValue = conditionValue;
			this.ConditionValue2 = conditionValue2;
			this.ConditionValue3 = conditionValue3;
			this.PlayerStatus = playerStatus;
		}

		public int Id { get; set; }
		public string Decription { get; set; }
		public ConditionFlagsEnum ConditionFlags { get; set; }
		public ICollection<ActionDescription> ActionsList { get; set; }
		public int ConditionValue { get; set; }
		public int ConditionValue2 { get; set; }
		public int ConditionValue3 { get; set; }
		public PlayerStatus PlayerStatus { get; set; }
		//EpisodeModel – Клас описващ състоянието на текущият епизод
		//Id – int, Номер на епизода
		//Decription – string, Описание на епизода
		//ConditionFlags – int, Флагове описващи действия в епизода преди да е направен избор (промяна на к.с., зареждане на състояние на конкретната възможност за избор [ActionDescription])
		//ActionsList – ICollection<ActionDescription>, списък, определящ възможностите за избор в епизода
		//ConditionValue – int, Стойност на операнд в зависимост от действието определено от ConditionFlags  
		//ConditionValue2 – int, Стойност на операнд в зависимост от действието определено от ConditionFlags.
		//ConditionValue3 – int, Стойност на операнд в зависимост от действието определено от ConditionFlags.
		//PlayerStatus – PlayerStatus
	}
}
