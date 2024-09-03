namespace GameStarShips.GamePlayer.Action
{
	using GameStarShips.Data.Enums;

	public class ActionDescription
	{
		public ActionDescription(int epizodeId, int targetEpizodeId, int choisPoint, string decription, PostActionFlagsEnum postActionFlags, int actionValue, PreActionFlagsEnum preActionFlags, int visibleValue)
		{
			this.EpizodeId = epizodeId;
			this.TargetEpizodeId = targetEpizodeId;
			this.ChoisPoint = choisPoint;
			this.Decription = decription;
			this.PostActionFlags = postActionFlags;
			this.ActionValue = actionValue;
			this.PreActionFlags = preActionFlags;
			this.VisibleValue = visibleValue;
		}

		public int EpizodeId { get; set; }
		public int TargetEpizodeId { get; set; }
		public int ChoisPoint { get; set; }
		public string Decription { get; set; }
		public PostActionFlagsEnum PostActionFlags { get; set; }
		public int ActionValue { get; set; }
		public PreActionFlagsEnum PreActionFlags { get; set; }
		public int VisibleValue { get; set; }
		public bool VisibleFlag => this.PreActionFlags == (int)PreActionFlagsEnum.Enable ? true : false;
		//– Клас описващ възможност за избор
		//EpizodeId – int, Номер на епизода
		//ChoisEpizodeId – int, Номер на епизода към който сочи избора
		//Decription – string, Описание на избора
		//PostActionFlags – int, Флагове описващи действия, които трябва да се извършат преди преминаване на епизода сочен от този избор
		//ActionValue – int, Стойност на параметър определящ действието
		//PreActionFlags – int, Флагове определящи дали епизода може да бъде избиран. Влияе на стойността на VisibleFlag
		//VisibleValue – int, Стойност на параметъра определяща видимостта
		//VisibleFlag – bool, Флаг сочещ дали даденият избор е видим
	}
}
