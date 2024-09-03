namespace GameStarShips.Data.Enums
{
	[Flags]
	public enum ConditionFlagsEnum
	{
		/// <summary>
		/// Няма действие
		/// </summary>
		ZeroCondition = 0x00000000,

		/// <summary>
		/// Всички контролни суми са равни на нула 
		/// </summary>					 
		AllChecksumsAreZero = 0x00000001,

		/// <summary>
		/// Прибави ConditionValue към първа контролна сума
		/// </summary>
		AddValueToFirstChecksum = 0x00000002,

		/// <summary>
		/// Прибави ConditionValue към втора контролна сума
		/// </summary>
		AddValueToSecondChecksum = 0x00000004,

		/// <summary>
		/// Мигновенно преминаване към следващ епизод 
		/// </summary>
		InstantlySkipToNextEpisode = 0x00000008,

		/// <summary>
		/// Зареди ConditionValue във втора кс
		/// </summary>
		SecondChecksumЕqualToConditionValue = 0x00000010,

		/// <summary>
		/// Зареди ConditionValue2 в трета кс
		/// </summary>
		ThitdChecksumЕqualToConditionValue2 = 0x00000020,

		/// <summary>
		/// Седма контролна сума равна на ConditionValue, останалите са равни на 0
		/// </summary>
		SeventhChecksumEqualToOthersEqualToZero = 0x00000040,

		/// <summary>
		/// Шеста контролна сума равна на ConditionValueШеста контролна сума равна на ConditionValue
		/// </summary>
		SixthChecksumEqualToConditionValue = 0x00000080,

		/// <summary>
		/// Запази първа контролна сума в PlayerStatus. PreviousValueChecksum1 и пета контролна сума в PlayerStatus. PreviousValueChecksum5  Втора и трета контролни суми минус 1, първа и пета контролни суми 0.
		/// </summary>
		SecondAndThirdChecksumsMinusOneFirstAndFifthChecksumsZero = 0x00000100,

		/// <summary>
		/// Ако първа контролна сума е 0 зареди първа контролна сума = PlayerStatus. PreviousValueChecksum1. Ако пета контролна сума е 0 зареди пета контролна сума = PlayerStatus. PreviousValueChecksum5
		/// </summary>
		RestoreFirstAndFifthChecksums = 0x00000200,

		/// <summary>
		/// Седма контролна сума равна на ConditionValue3
		/// </summary>
		SeventhChecksumEqualToConditionValue3 = 0x00000400,

		/// <summary>
		/// Изчисляване на броя хората. Изречението се вмъква в текста на епизода – брой войници = 2кс+3кс, брой ловци = 100 – брой войници
		/// </summary>
		CalculatingTheNumberOfPeople = 0x00000800,

		/// <summary>
		/// Осма контролна сума равна на ConditionValue
		/// </summary>
		EighthChecksumEqualToConditionValue = 0x00001000,

		/// <summary>
		/// Девета контролна сума равна на ConditionValue2
		/// </summary>
		NinthChecksumEqualToConditionValue2 = 0x00002000,

		/// <summary>
		/// Първа контролна сума равна на ConditionValue
		/// </summary>
		FirstChecksumEqualToConditionValue = 0x00004000,

		/// <summary>
		/// Пета контролна сума равна на ConditionValue2
		/// </summary>
		FifthChecksumEqualToConditionValue2 = 0x00008000,

		/// <summary>
		/// Прибави ConditionValue към пета контролна сума
		/// </summary>
		AddConditionValueToFifthChecksum = 0x00010000,

		/// <summary>
		/// Ако първа контролна сума е равна на ConditionValue или ConditionValue2 или ConditionValue3
		/// </summary>
		IfFirstChecksumIsEqualToConditionValueOrConditionValue2OrConditionValue3 = 0x00020000
	}
}
