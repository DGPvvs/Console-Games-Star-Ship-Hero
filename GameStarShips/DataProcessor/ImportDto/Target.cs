namespace GameStarShips.DataProcessor.ImportDto
{
	using GameStarShips.Data.Enums;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.ComponentModel.DataAnnotations;

	public class Target
	{
		public Target()
		{
			this.Episodes = new List<TargetEpisode>();
		}

		[Key]
		public int? Id { get; set; }

		[Required]
		public int ChoisPoint { get; set; }

		[Required(AllowEmptyStrings = true)]
		public string Decription { get; set; } = null!;

		[Required]
		public PostActionFlagsEnum PostActionFlags { get; set; }

		[Required]
		public int ActionValue { get; set; }

		[Required]
		public PreActionFlagsEnum PreActionFlags { get; set; }

		[Required]
		public int VisibleValue { get; set; }

		public virtual ICollection<TargetEpisode> Episodes { get; set; }

		[ForeignKey(nameof(Episode))]
		public int? EpizodeId { get; set; }

		public virtual Episode Episode { get; set; }
	}

}
