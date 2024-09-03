namespace GameStarShips.DataProcessor.ImportDto
{
	using System.ComponentModel.DataAnnotations.Schema;

	public class TargetEpisode
	{
		[ForeignKey(nameof(Episode))]
		public int? EpizodeId { get; set; }

		public virtual Episode? Episode { get; set; }

		[ForeignKey(nameof(Targets))]
		public int? TargetId { get; set; }

		public virtual Target? Targets { get; set; }
	}
}
