namespace GameStarShips.DataProcessor.ImportDto
{
	using System.ComponentModel.DataAnnotations;

	internal class PlayerStatusDTO
	{
		[Required]
		public int[] Checksums { get; set; }

		[Required]
		public int PreviousValueChecksum1 { get; set; }

		[Required]
		public int PreviousValueChecksum5 { get; set; }

		[Required]
		public int CurrentEpizodeIndex { get; set; }
	}
}
