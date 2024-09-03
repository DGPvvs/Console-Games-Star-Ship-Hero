namespace GameStarShips.Data.Enums
{
	[Flags]
	public enum PostActionFlagsEnum
	{
		/// <summary>
		/// Няма действие
		/// </summary>
		Zero = 0x00000000,

		/// <summary>
		/// кс6 = ActionValue
		/// </summary>
		Checksum6ЕqualValue = 0x00000001,

		/// <summary>
		/// Случаен избор. Възможните избори се определят от стойността на ActionValue
		/// </summary>
		RandomSelection = 0x00000002,

		/// <summary>
		/// Ако шестата контролна сума е равна на ActionValue избери младши 9 бита от ChoisEpizodeId иначе избери средни 9 бита от  ChoisEpizodeId
		/// </summary>
		DoubleCheckingTheSixthChecksumWithActionValue = 0x00000004,

		/// <summary>
		/// Тернарна проверка на първа контролна сума. Ако първа контролна сума е по-малка от ActionValue избери младши 9 бита от ChoisEpizodeId, ако е равна на ActionValue избери средни 9 бита от ChoisEpizodeId,  иначе избери старши 9 бита от  ChoisEpizodeId
		/// </summary>
		TernaryCheckOfFirstChecksumWithActionValue = 0x00000008,

		/// <summary>
		/// Пета кънтролна сума равна на ActionValue 
		/// </summary>
		FifthChecksumEqualToToActionValue = 0x00000010,

		/// <summary>
		/// Първа контролна сума равна на ActionValue 
		/// </summary>
		FirstChecksumEqualToToActionValue = 0x00000020,

		/// <summary>
		/// Ако четвъртата контролна сума >= ActionValue избери младши 9 бита от ChoisEpizodeId иначе избери средни 9 бита от  ChoisEpizodeId
		/// </summary>
		DoubleCheckingTheFourthChecksumWithActionValue = 0x00000040,

		/// <summary>
		/// Увеличение на шеста контролна сума с (int)((100-(2кс+3кс))/5)
		/// </summary>
		SixthChecksumIncrease = 0x00000080,

		/// <summary>
		/// Увеличение на шеста контролна сума с ActionValue
		/// </summary>
		SixthChecksumIncreaseWithActionValue = 0x00000100,

		/// <summary>
		/// Ако пета контролна сума е по-голяма или равна на ActionValue 
		/// </summary>
		IfFifthChecksumIsGreaterOrEqualToActionValue = 0x00000200,

		/// <summary>
		/// Тернарна проверка на първа контролна сума. Ако първа контролна сума е < от ActionValue избери младши 9 бита от ChoisEpizodeId, ако е <  VisibleValue избери средни 9 бита от ChoisEpizodeId,  иначе избери старши 9 бита от  ChoisEpizodeId
		/// </summary>
		TernaryCheckOfFirstChecksumWithActionValueAndVisibleValue = 0x00000400,

		/// <summary>
		/// Случаен избор в зависимост от пета контролна сума. Ако 5 кс > ActionValue то възможните избори са 3, иначе 2. Ако резултата е 1 – младши 9 бита в ChoisPoint, 2 – средни 9 бита, 3 – старши 9 бита  
		/// </summary>
		RandomSelectionDependingOnFifthChecksum = 0x00000800,

		/// <summary>
		/// Ако шеста контролна сума е по-голяма от ActionValue избери младши 9 бита, иначе избери средни 9 бита 
		/// </summary>
		IfTheSixthChecksumIsGreaterThanActionValue = 0x00001000,

		/// <summary>
		/// Прибави ActionValue към първа контролна сума 
		/// </summary>
		AddActionValueToFirstChecksum = 0x00002000,

		/// <summary>
		/// Ако първа и пета контролни суми са равни на ActionValue 
		/// </summary>
		IfTheFirstAndFifthChecksumsAreEqualToActionValue = 0x00004000,

		/// <summary>
		/// Четвърта контролна сума равна на ChoisPoint
		/// </summary>
		FourthChecksumEqualToChoisPoint = 0x00008000,

		/// <summary>
		/// Прибави ActionValue към пета контролна сума
		/// </summary>
		AddActionValueToFifthChecksum = 0x00010000
	}
}
