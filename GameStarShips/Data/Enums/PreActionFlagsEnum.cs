namespace GameStarShips.Data.Enums
{
	[Flags]
	public enum PreActionFlagsEnum
	{
		/// <summary>
		/// Избора е достъпен
		/// </summary>
		Enable = 0x00000000,

		/// <summary>
		/// Избора не е достъпен
		/// </summary>
		Disable = 0x00000001,

		/// <summary>
		/// Ако пета контролна сума е по-голяма или равна на ActionValue, то избора е Enable
		/// </summary>
		IfFifthChecksumIsGreaterOrEqualToActionValue = 0x00000002,

		/// <summary>
		/// Ако шеста контролна сума е по-голяма от  ActionValue, то избора е Enable
		/// </summary>
		IfSixthChecksumIsGreaterThanActionValue = 0x00000004,

		/// <summary>
		/// Ако четвъртата контролна сума е равна на ActionValue, то избора е Enable
		/// </summary>
		IfFourthChecksumIsEqualToActionValue = 0x00000008,

		/// <summary>
		/// Ако третата контролна сума е по-голяма или равна на ActionValue, то избора е Enable
		/// </summary>
		IfThirdChecksumIsGreaterOrEqualToActionValue = 0x00000010,

		/// <summary>
		/// Ако първа контролна сума е равна на ActionValue или равна на VisibleValue, то избора е Enable. Иначе Disable.
		/// </summary>
		IfTheFirstChecksumIsEqualToActionValueOrEequalToVisibleValue = 0x00000020,

		/// <summary>
		/// Ако първа контролна сума е различна от ActionValue и различна от VisibleValue, то избора е Enable. Иначе Disable.
		/// </summary>
		IfFirstChecksumIsDifferentFromActionValueAndDifferentFromVisibleValue = 0x00000040,

		/// <summary>
		/// Ако пета контролна сума е равна на ActionValue, то избора е Enable
		/// </summary>
		IfFifthChecksumIsEqualToActionValue = 0x00000080,

		/// <summary>
		/// Ако EpisodeModel.TootalPoints >= ActionValue <= VisibleValue, то избора е Enable
		/// </summary>
		TottalResult = 0x00000100,

		/// <summary>
		/// Ако първа контролна сума е по-голяма от ActionValue то избора е Enable
		/// </summary>
		IfFirstChecksumIsGreaterThanActionValue = 0x00000200
	}
}
