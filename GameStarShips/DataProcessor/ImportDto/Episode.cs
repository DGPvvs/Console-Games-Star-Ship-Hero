namespace GameStarShips.DataProcessor.ImportDto
{
	using GameStarShips.Data.Enums;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.ComponentModel.DataAnnotations;

	public class Episode
	{
		public Episode()
		{
			this.Targets = new List<TargetEpisode>();
		}

		[Key]
		public int? Id { get; set; }

		[Required(AllowEmptyStrings = true)]
		public string Decription { get; set; } = null!;

		[Required]
		public ConditionFlagsEnum ConditionFlags { get; set; }

		[Required]
		public int ConditionValue { get; set; }

		[Required]
		public int ConditionValue2 { get; set; }

		[Required]
		public int ConditionValue3 { get; set; }

		public virtual ICollection<TargetEpisode> Targets { get; set; }

		[ForeignKey(nameof(Target))]
		public int? TargetId { get; set; }

		public virtual Target Target { get; set; }
	}

}
