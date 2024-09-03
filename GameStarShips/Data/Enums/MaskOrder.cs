namespace GameStarShips.Data.Enums
{
	public enum MaskOrder
	{
		/// <summary>
		/// Маска на младши 9 бита	511	0x000001FF	b000000000000000000111111111
		/// </summary>
		MaskOfLow9Bits = 0x000001FF,

		/// <summary>
		/// Маска на средни 9 бита	261632	0x0003FE00	b000000000111111111000000000
		/// </summary>
		MaskOfMiddle9Bits = 0x0003FE00,

		/// <summary>
		/// Маска на старши 9 бита	133955584	0x07FC0000	b111111111000000000000000000
		/// </summary>
		MaskOfHight9Bits = 0x07FC0000,

		/// <summary>
		/// Маска младши порядък	1	0x00000001	b000000000000000000000000001
		/// </summary>
		LowOrderMask = 0x00000001,

		/// <summary>
		/// Маска среден порядък	512	0x00000200	b000000000000000001000000000
		/// </summary>
		MediumOrderMask = 0x00000200,

		/// <summary>
		/// Маска старши порядък	262144	0x00040000	b000000001000000000000000000
		/// </summary>
		HightOrderMask = 0x00040000
	}
}
