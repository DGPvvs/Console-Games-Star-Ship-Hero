namespace GameStarShips.GamePlayer.Models.EpizodeModels
{
	using GameStarShips.Data.Enums;

	public class ChoisesModel
	{
		public ChoisesModel(int targetEpizodeId, int choisPoint, PostActionFlagsEnum postActionFlags, int actionValue, int visibleValue)
		{
			this.TargetEpizodeId = targetEpizodeId;
			this.ChoisPoint = choisPoint;
			this.PostActionFlags = postActionFlags;
			this.ActionValue = actionValue;
			this.VisibleValue = visibleValue;
		}

		public int TargetEpizodeId { get; set; }
		public int ChoisPoint { get; set; }
		public PostActionFlagsEnum PostActionFlags { get; set; }
		public int ActionValue { get; set; }
		public int VisibleValue { get; set; }
	}
}
