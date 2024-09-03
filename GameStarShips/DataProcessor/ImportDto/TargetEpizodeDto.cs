namespace GameStarShips.DataProcessor.ImportDto
{
	using System.ComponentModel.DataAnnotations;

	public class TargetEpizodeDto
	{
		[Required]
		public int EpizodeId { get; set; }

		[Required]
		public int TargetEpizodeId { get; set; }

		[Required]
		public int ChoisPoint { get; set; }

		[Required(AllowEmptyStrings = true)]
		public string Decription { get; set; } = null!;

		[Required]
		public string PostActionFlags { get; set; }

		[Required]
		public int ActionValue { get; set; }

		[Required]
		public string PreActionFlags { get; set; }

		[Required]
		public int VisibleValue { get; set; }
	}
}
