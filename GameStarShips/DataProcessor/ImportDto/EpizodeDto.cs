namespace GameStarShips.DataProcessor.ImportDto
{
	using System.ComponentModel.DataAnnotations;

	internal class EpizodeDto
	{
		[Required]
		public int Id { get; set; }

		[Required(AllowEmptyStrings = true)]

		public string Decription { get; set; } = null!;

		[Required]
		public string ConditionFlags { get; set; }

		[Required]
		public int ConditionValue { get; set; }

		[Required]
		public int ConditionValue2 { get; set; }

		[Required]
		public int ConditionValue3 { get; set; }

		public TargetEpizodeDto[] ChoisEpisodes { get; set; } = null!;
	}
}
