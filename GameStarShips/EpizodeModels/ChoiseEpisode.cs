namespace GameStarShips.EpizodeModels
{
	using GameStarShips.Data.Enums;

	public class ChoiseEpisode
	{
        public ChoiseEpisode()
        {
            
        }
        public ChoiseEpisode(int epizodeId, int targetEpizodeId, int choisPoint, string decription, PostActionFlagsEnum postActionFlags, int actionValue, PreActionFlagsEnum preActionFlags, int visibleValue) : this()
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
	}
}
