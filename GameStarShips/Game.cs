namespace GameStarShips
{
	using GameStarShips.Data.Enums;
	using GameStarShips.EpizodeModels;
	using GameStarShips.GamePlayer.Action;
	using GameStarShips.GamePlayer.Models.EpizodeModels;
	using GameStarShips.GamePlayer.Models.PlayerModel;
	using GameStarShips.GamePlayer.Test.Contracts;
	using GameStarShips.IO.Contracts;
	using System.Collections.Generic;
	using System.Text;

	public class Game
	{
		private readonly IRead read;
		private readonly IWrite write;
		private Dictionary<int, Epizod> baseBook;
		private PlayerStatus playerStatus;

		public Game()
		{
			this.baseBook = this.SetBase()!;
		}


		public Game(IRead read, IWrite write) : this()
		{
			this.read = read;
			this.write = write;
		}

		public Game(IRead read, IWrite write, ITestData? testData = null) : this(read, write)
		{
			this.playerStatus = new PlayerStatus();

			if (testData == null)
			{
				this.StartUpNewGame();
			}
			else
			{
				var firstEpizod = GetEpizdById(testData.CurrentEpizode);
				this.playerStatus = testData.playerStatus;

				if (firstEpizod == null)
				{
					throw new Exception();
				}

				this.GameStatus = GameStatusEnum.InAction;

				this.SetCurrentEpizod(firstEpizod);
			}
		}

		public IRead Read => this.read;

		public IWrite Write => this.write;

		public EpizodeModel CurrentEpizodeModel { get; set; }
		public GameStatusEnum GameStatus { get; set; }

		public void Run()
		{
			while (this.GameStatus == GameStatusEnum.InAction)
			{
				this.GameAction();
			}
		}

		public void GameAction()
		{
			int nextEpizod = this.EpizodeCondition();

			if (nextEpizod == 0)
			{
				this.SetPreActionCondition();
				this.PrintEpisodeDescription();
				ChoisesModel choisAction = this.PrintActionChoise();
				nextEpizod = this.SetPostActionCondition(choisAction);
			}

			if (this.GameStatus == GameStatusEnum.IsSave)
			{
				this.SaveGame();
			}


			this.SetCurrentEpizod(this.GetEpizdById(nextEpizod));
		}

		private void SaveGame()
		{
			throw new NotImplementedException();
		}

		public void StartUpNewGame()
		{
			var firstEpizod = GetEpizdById(1);

			if (firstEpizod == null)
			{
				throw new Exception();
			}

			this.playerStatus.InitNewPlayerStatus();
			this.GameStatus = GameStatusEnum.InAction;

			this.SetCurrentEpizod(firstEpizod);
		}

		private Dictionary<int, Epizod>? SetBase()
		{
			var projectDir = GetProjectDirectory();

			string separator = " or ";
			string path = @"M:\C#\StarProba\StarBase\ConvertFromText\ConvertFromTextToJson\bin\Debug\net6.0\star.txt";
			//string jsonPath = @"M:\C#\StarProba\StarBase\StarBase\bin\Debug\net6.0\star.json";
			string jsonPath = projectDir + @"star.json";

			string patternEpisode = @"((Id : (?<Id>(\d+))(\nDecription : )(?<Decription>(.+\n)+)(ConditionFlags : )(?<ConditionFlags>(\d+))(\n)(ConditionValue : )(?<ConditionValue>(\d+))(\n)(ConditionValue2 : )(?<ConditionValue2>(\d+))(\n)(ConditionValue3 : )(?<ConditionValue3>(\d+))(\n)))";
			string patternTargetEpiside = @"((EpizodeId : )(?<EpizodeId>(\d+))(\n)+(ChoisEpizodeId : )(?<ChoisEpizodeId>(\d+))(\n)+(ChoisPoint : )(?<ChoisPoint>(\d+))(\n)+(Decription : )(?<Decription>(.*))(\n)*(PostActionFlags : )(?<PostActionFlags>(\d+))(\n)+(ActionValue : )(?<ActionValue>(\d+))(\n)+(PreActionFlags : )(?<PreActionFlags>(\d+))(\n)+(VisibleValue : )(?<VisibleValue>(\d+))(\n)+)";
			//BookText b = new BookText();

			Dictionary<int, Epizod> list = new Dictionary<int, Epizod>();

			Game.ImportEntities(jsonPath, ref list);

			return list;
		}

		private static void ImportEntities(string baseDir, ref Dictionary<int, Epizod> list)
		{

			DataProcessor.Deserializer.ImportEpizodes(File.ReadAllText(baseDir), ref list);
		}


		private static string GetProjectDirectory()
		{
			var currentDirectory = Directory.GetCurrentDirectory();
			var directoryName = Path.GetFileName(currentDirectory);
			var relativePath = directoryName.StartsWith("net") ? @"../../../../GameStarShips/Book/JsonFile/" : string.Empty;

			return relativePath;
		}

		private int EpizodeCondition()
		{
			//this.write.WriteLine($"EpizodeCondition CheckSums {string.Join("-", this.playerStatus.Checksums)}");

			ConditionFlagsEnum condition = this.CurrentEpizodeModel.ConditionFlags;
			while (!condition.Equals(ConditionFlagsEnum.ZeroCondition))
			{
				if (condition.HasFlag(ConditionFlagsEnum.AllChecksumsAreZero))
				{
					condition = this.AllChecksumsAreZero(condition);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.AddValueToFirstChecksum))
				{
					condition = this.AddConditionValueToChecksum(condition, this.CurrentEpizodeModel.ConditionValue, CheckSumsIndexEnum.CheckSumsIndex1, ConditionFlagsEnum.AddValueToFirstChecksum);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.AddValueToSecondChecksum))
				{
					condition = this.AddConditionValueToChecksum(condition, this.CurrentEpizodeModel.ConditionValue, CheckSumsIndexEnum.CheckSumsIndex2, ConditionFlagsEnum.AddValueToSecondChecksum);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.SecondChecksumЕqualToConditionValue))
				{
					int value = this.CurrentEpizodeModel.ConditionValue - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex2];
					condition = this.AddConditionValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex2, ConditionFlagsEnum.SecondChecksumЕqualToConditionValue);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.ThitdChecksumЕqualToConditionValue2))
				{
					int value = this.CurrentEpizodeModel.ConditionValue2 - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex3];
					condition = this.AddConditionValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex3, ConditionFlagsEnum.ThitdChecksumЕqualToConditionValue2);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.SeventhChecksumEqualToOthersEqualToZero))
				{
					this.AllChecksumsAreZero();
					int value = this.CurrentEpizodeModel.ConditionValue - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex7];
					condition = this.AddConditionValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex7, ConditionFlagsEnum.SeventhChecksumEqualToOthersEqualToZero);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.SixthChecksumEqualToConditionValue))
				{
					int value = this.CurrentEpizodeModel.ConditionValue - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex6];
					condition = this.AddConditionValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex6, ConditionFlagsEnum.SixthChecksumEqualToConditionValue);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.SeventhChecksumEqualToConditionValue3))
				{
					int value = this.CurrentEpizodeModel.ConditionValue3 - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex7];
					condition = this.AddConditionValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex7, ConditionFlagsEnum.SeventhChecksumEqualToConditionValue3);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.EighthChecksumEqualToConditionValue))
				{
					int value = this.CurrentEpizodeModel.ConditionValue - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex8];
					condition = this.AddConditionValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex8, ConditionFlagsEnum.EighthChecksumEqualToConditionValue);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.NinthChecksumEqualToConditionValue2))
				{
					int value = this.CurrentEpizodeModel.ConditionValue2 - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex9];
					condition = this.AddConditionValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex9, ConditionFlagsEnum.NinthChecksumEqualToConditionValue2);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.FirstChecksumEqualToConditionValue))
				{
					int value = this.CurrentEpizodeModel.ConditionValue - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1];
					condition = this.AddConditionValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex1, ConditionFlagsEnum.FirstChecksumEqualToConditionValue);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.FifthChecksumEqualToConditionValue2))
				{
					int value = this.CurrentEpizodeModel.ConditionValue2 - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5];
					condition = this.AddConditionValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex5, ConditionFlagsEnum.FifthChecksumEqualToConditionValue2);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.AddConditionValueToFifthChecksum))
				{
					condition = this.AddConditionValueToChecksum(condition, this.CurrentEpizodeModel.ConditionValue, CheckSumsIndexEnum.CheckSumsIndex5, ConditionFlagsEnum.AddConditionValueToFifthChecksum);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.SecondAndThirdChecksumsMinusOneFirstAndFifthChecksumsZero))
				{
					condition = this.SecondAndThirdChecksumsMinusOneFirstAndFifthChecksumsZero(condition, ConditionFlagsEnum.SecondAndThirdChecksumsMinusOneFirstAndFifthChecksumsZero);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.RestoreFirstAndFifthChecksums))
				{
					condition = this.RestoreFirstAndFifthChecksums(condition, ConditionFlagsEnum.RestoreFirstAndFifthChecksums);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.IfFirstChecksumIsEqualToConditionValueOrConditionValue2OrConditionValue3))
				{
					int value1 = this.CurrentEpizodeModel.ConditionValue;
					int value2 = this.CurrentEpizodeModel.ConditionValue2;
					int value3 = this.CurrentEpizodeModel.ConditionValue3;

					condition = this.IfFirstChecksumIsEqualToConditionValueOrConditionValue2OrConditionValue3(condition, value1, value2, value3, ConditionFlagsEnum.IfFirstChecksumIsEqualToConditionValueOrConditionValue2OrConditionValue3);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.CalculatingTheNumberOfPeople))
				{
					condition = this.CalculatingTheNumberOfPeople(condition, ConditionFlagsEnum.CalculatingTheNumberOfPeople);
				}
				else if (condition.HasFlag(ConditionFlagsEnum.InstantlySkipToNextEpisode))
				{
					//TODO
					condition = this.InstantlySkipToNextEpisode(condition);
					ActionDescription action = this.CurrentEpizodeModel.ActionsList.Take(1).ToList().First();
					return action.TargetEpizodeId;
				}
			}

			//this.Write.WriteLine($"EpizodeCondition CheckSums {string.Join("-", this.playerStatus.Checksums)}");
			//this.Read.ReadLine();
			return 0;
		}

		private void SetPreActionCondition()
		{
			foreach (var action in this.CurrentEpizodeModel.ActionsList)
			{
				PreActionFlagsEnum condition = action.PreActionFlags;

				while (!condition.Equals(PreActionFlagsEnum.Disable) && !condition.Equals(PreActionFlagsEnum.Enable))
				{
					if (condition.HasFlag(PreActionFlagsEnum.IfFifthChecksumIsGreaterOrEqualToActionValue))
					{
						action.PreActionFlags = PreActionFlagsEnum.Disable;
						if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5] >= action.ActionValue)
						{
							action.PreActionFlags = PreActionFlagsEnum.Enable;
						}

						PreActionFlagsEnum invCondition = ~(PreActionFlagsEnum.IfFifthChecksumIsGreaterOrEqualToActionValue);
						condition = condition & invCondition;
					}
					else if (condition.HasFlag(PreActionFlagsEnum.IfSixthChecksumIsGreaterThanActionValue))
					{
						action.PreActionFlags = PreActionFlagsEnum.Disable;
						if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex6] > action.ActionValue)
						{
							action.PreActionFlags = PreActionFlagsEnum.Enable;
						}

						PreActionFlagsEnum invCondition = ~(PreActionFlagsEnum.IfSixthChecksumIsGreaterThanActionValue);
						condition = condition & invCondition;
					}
					else if (condition.HasFlag(PreActionFlagsEnum.IfFourthChecksumIsEqualToActionValue))
					{
						action.PreActionFlags = PreActionFlagsEnum.Disable;
						if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex4] == action.ActionValue)
						{
							action.PreActionFlags = PreActionFlagsEnum.Enable;
						}

						PreActionFlagsEnum invCondition = ~(PreActionFlagsEnum.IfFourthChecksumIsEqualToActionValue);
						condition = condition & invCondition;
					}
					else if (condition.HasFlag(PreActionFlagsEnum.IfThirdChecksumIsGreaterOrEqualToActionValue))
					{
						action.PreActionFlags = PreActionFlagsEnum.Disable;
						if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex3] >= action.ActionValue)
						{
							action.PreActionFlags = PreActionFlagsEnum.Enable;
						}

						PreActionFlagsEnum invCondition = ~(PreActionFlagsEnum.IfThirdChecksumIsGreaterOrEqualToActionValue);
						condition = condition & invCondition;
					}
					else if (condition.HasFlag(PreActionFlagsEnum.IfTheFirstChecksumIsEqualToActionValueOrEequalToVisibleValue))
					{
						action.PreActionFlags = PreActionFlagsEnum.Disable;
						if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] == action.ActionValue ||
						   this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] == action.VisibleValue)
						{
							action.PreActionFlags = PreActionFlagsEnum.Enable;
						}

						PreActionFlagsEnum invCondition = ~(PreActionFlagsEnum.IfTheFirstChecksumIsEqualToActionValueOrEequalToVisibleValue);
						condition = condition & invCondition;
					}
					else if (condition.HasFlag(PreActionFlagsEnum.IfFirstChecksumIsDifferentFromActionValueAndDifferentFromVisibleValue))
					{
						action.PreActionFlags = PreActionFlagsEnum.Disable;
						if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] != action.ActionValue &&
						   this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] != action.VisibleValue)
						{
							action.PreActionFlags = PreActionFlagsEnum.Enable;
						}

						PreActionFlagsEnum invCondition = ~(PreActionFlagsEnum.IfFirstChecksumIsDifferentFromActionValueAndDifferentFromVisibleValue);
						condition = condition & invCondition;
					}
					else if (condition.HasFlag(PreActionFlagsEnum.IfFifthChecksumIsEqualToActionValue))
					{
						action.PreActionFlags = PreActionFlagsEnum.Disable;
						if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5] == action.ActionValue)
						{
							action.PreActionFlags = PreActionFlagsEnum.Enable;
						}

						PreActionFlagsEnum invCondition = ~(PreActionFlagsEnum.IfFifthChecksumIsEqualToActionValue);
						condition = condition & invCondition;
					}
					else if (condition.HasFlag(PreActionFlagsEnum.IfFirstChecksumIsGreaterThanActionValue))
					{
						action.PreActionFlags = PreActionFlagsEnum.Disable;
						if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] > action.ActionValue)
						{
							action.PreActionFlags = PreActionFlagsEnum.Enable;
						}

						PreActionFlagsEnum invCondition = ~(PreActionFlagsEnum.IfFirstChecksumIsGreaterThanActionValue);
						condition = condition & invCondition;
					}
					else if (condition.HasFlag(PreActionFlagsEnum.TottalResult))
					{
						action.PreActionFlags = PreActionFlagsEnum.Disable;
						if (this.playerStatus.TottalResult >= action.ActionValue && this.playerStatus.TottalResult < action.VisibleValue)
						{
							action.PreActionFlags = PreActionFlagsEnum.Enable;
						}

						PreActionFlagsEnum invCondition = ~(PreActionFlagsEnum.TottalResult);
						condition = condition & invCondition;
					}
				}
			}
		}

		private int SetPostActionCondition(ChoisesModel choisAction)
		{
			//this.Write.WriteLine($"PostActionCondition CheckSums {string.Join("-", this.playerStatus.Checksums)}");

			if (choisAction == null)
			{
				return 1;
			}

			PostActionFlagsEnum condition = choisAction.PostActionFlags;

			while (condition != PostActionFlagsEnum.Zero)
			{
				if (condition.HasFlag(PostActionFlagsEnum.Checksum6ЕqualValue))
				{
					int value = choisAction.ActionValue - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex6];
					condition = this.AddPostValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex6, PostActionFlagsEnum.Checksum6ЕqualValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.RandomSelection))
				{
					condition = this.RandomChois(condition, ref choisAction, PostActionFlagsEnum.RandomSelection);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.DoubleCheckingTheSixthChecksumWithActionValue))
				{
					condition = this.DoubleCheckingTheSixthChecksumWithActionValue(condition, choisAction, PostActionFlagsEnum.DoubleCheckingTheSixthChecksumWithActionValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.TernaryCheckOfFirstChecksumWithActionValue))
				{
					condition = this.TernaryCheckOfFirstChecksumWithActionValue(condition, choisAction, PostActionFlagsEnum.TernaryCheckOfFirstChecksumWithActionValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.FifthChecksumEqualToToActionValue))
				{
					int value = choisAction.ActionValue - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5];
					condition = this.AddPostValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex5, PostActionFlagsEnum.FifthChecksumEqualToToActionValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.FirstChecksumEqualToToActionValue))
				{
					int value = choisAction.ActionValue - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1];
					condition = this.AddPostValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex1, PostActionFlagsEnum.FirstChecksumEqualToToActionValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.DoubleCheckingTheFourthChecksumWithActionValue))
				{
					condition = this.DoubleCheckingTheFourthChecksumWithActionValue(condition, choisAction, PostActionFlagsEnum.DoubleCheckingTheFourthChecksumWithActionValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.SixthChecksumIncrease))
				{
					int value = (int)((100 - (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex2] + this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex3])) / 5);
					condition = this.AddPostValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex6, PostActionFlagsEnum.SixthChecksumIncrease);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.SixthChecksumIncreaseWithActionValue))
				{
					condition = this.AddPostValueToChecksum(condition, choisAction.ActionValue, CheckSumsIndexEnum.CheckSumsIndex6, PostActionFlagsEnum.SixthChecksumIncreaseWithActionValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.IfFifthChecksumIsGreaterOrEqualToActionValue))
				{
					condition = this.IfFifthChecksumIsGreaterOrEqualToActionValue(condition, choisAction, PostActionFlagsEnum.IfFifthChecksumIsGreaterOrEqualToActionValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.AddActionValueToFirstChecksum))
				{
					condition = this.AddPostValueToChecksum(condition, choisAction.ActionValue, CheckSumsIndexEnum.CheckSumsIndex6, PostActionFlagsEnum.AddActionValueToFirstChecksum);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.FourthChecksumEqualToChoisPoint))
				{
					int value = choisAction.ChoisPoint - this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex4];
					condition = this.AddPostValueToChecksum(condition, value, CheckSumsIndexEnum.CheckSumsIndex4, PostActionFlagsEnum.FourthChecksumEqualToChoisPoint);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.AddActionValueToFifthChecksum))
				{
					condition = this.AddPostValueToChecksum(condition, choisAction.ActionValue, CheckSumsIndexEnum.CheckSumsIndex5, PostActionFlagsEnum.AddActionValueToFifthChecksum);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.TernaryCheckOfFirstChecksumWithActionValueAndVisibleValue))
				{
					condition = this.TernaryCheckOfFirstChecksumWithActionValueAndVisibleValue(condition, choisAction, PostActionFlagsEnum.TernaryCheckOfFirstChecksumWithActionValueAndVisibleValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.IfTheSixthChecksumIsGreaterThanActionValue))
				{
					condition = this.IfTheSixthChecksumIsGreaterThanActionValue(condition, choisAction, PostActionFlagsEnum.IfTheSixthChecksumIsGreaterThanActionValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.IfTheFirstAndFifthChecksumsAreEqualToActionValue))
				{
					condition = this.IfTheFirstAndFifthChecksumsAreEqualToActionValue(condition, choisAction, PostActionFlagsEnum.IfTheFirstAndFifthChecksumsAreEqualToActionValue);
				}
				else if (condition.HasFlag(PostActionFlagsEnum.RandomSelectionDependingOnFifthChecksum))
				{
					condition = this.RandomSelectionDependingOnFifthChecksum(condition, choisAction, PostActionFlagsEnum.RandomSelectionDependingOnFifthChecksum);
				}
			}

			//this.Write.WriteLine($"PostActionCondition CheckSums {string.Join("-", this.playerStatus.Checksums)}");
			//this.Write.WriteLine($"choisAction.TargetEpizodeId {choisAction.TargetEpizodeId}");
			//this.Read.ReadLine();

			return choisAction.TargetEpizodeId;
		}

		private void PrintEpisodeDescription()
		{
			this.ClearScreen();
			this.Write.WriteLine(this.CurrentEpizodeModel.Decription);
		}

		private ChoisesModel PrintActionChoise()
		{
			List<int> choiceOrder = new List<int>();
			//TODO
			int row = 1;
			foreach (var action in this.CurrentEpizodeModel.ActionsList)
			{
				if (action.VisibleFlag)
				{
					this.Write.WriteLine($"{row}. - {action.Decription}");
					choiceOrder.Add(row);
				}

				row++;
			}

			bool isLoopExit = false;

			while (!isLoopExit)
			{
				string input = this.Read.ReadLine();

				bool corectChois = int.TryParse(input, out int chois);

				if(corectChois && chois == 0)
				{
					this.GameStatus = GameStatusEnum.IsSave;
					return null;
					//isLoopExit = true;
				}
				else if (corectChois && (choiceOrder.Contains(chois)))
				{
					ActionDescription action = this.CurrentEpizodeModel.ActionsList.Skip(chois - 1).Take(1).ToList().First();
					return new ChoisesModel(action.TargetEpizodeId, action.ChoisPoint, action.PostActionFlags, action.ActionValue, action.VisibleValue);
				}
				else
				{
					this.Write.WriteLine("Грешно избран епизод");					
				}
			}
			
			throw new InvalidOperationException("Невалиден епизод");
		}

		private void ClearScreen()
		{
			this.Write.ClearScrean();
		}

		//Condition Epizode Action
		private ConditionFlagsEnum AllChecksumsAreZero(ConditionFlagsEnum condition = ConditionFlagsEnum.ZeroCondition)
		{
			for (int i = 0; i < this.playerStatus.Checksums.Length; i++)
			{
				this.playerStatus.Checksums[i] = 0;
			}

			ConditionFlagsEnum notb = ~ConditionFlagsEnum.AllChecksumsAreZero;

			return condition & notb;
		}

		private ConditionFlagsEnum AddConditionValueToChecksum(ConditionFlagsEnum condition, int conditionValue, CheckSumsIndexEnum index, ConditionFlagsEnum flag)
		{
			this.playerStatus.Checksums[(int)index] += conditionValue;

			return condition & ~(flag);
		}

		private ConditionFlagsEnum SecondAndThirdChecksumsMinusOneFirstAndFifthChecksumsZero(ConditionFlagsEnum condition, ConditionFlagsEnum flag)
		{
			this.playerStatus.PreviousValueChecksum1 = this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1];
			this.playerStatus.PreviousValueChecksum5 = this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5];

			this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] = 0;
			this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5] = 0;

			this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex2]--;
			this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex3]--;

			return condition & ~(flag);
		}

		private ConditionFlagsEnum RestoreFirstAndFifthChecksums(ConditionFlagsEnum condition, ConditionFlagsEnum flag)
		{
			if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] == 0)
			{
				this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] = this.playerStatus.PreviousValueChecksum1;
			}

			if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5] == 0)
			{
				this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5] = this.playerStatus.PreviousValueChecksum5;
			}

			return condition & ~(flag);
		}

		private ConditionFlagsEnum IfFirstChecksumIsEqualToConditionValueOrConditionValue2OrConditionValue3(ConditionFlagsEnum condition, int value1, int value2, int value3, ConditionFlagsEnum flag)
		{
			int checkSum = this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1];
			if (checkSum == value1 || checkSum == value2 || checkSum == value3)
			{
				return this.AddConditionValueToChecksum(condition, 10, CheckSumsIndexEnum.CheckSumsIndex8, flag);
			}

			return condition & ~(flag);
		}

		private ConditionFlagsEnum CalculatingTheNumberOfPeople(ConditionFlagsEnum condition, ConditionFlagsEnum flag)
		{
			StringBuilder sb = new StringBuilder(this.CurrentEpizodeModel.Decription);

			int hunters = 100 - (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex2] + this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex3]);

			string s = $"Можеш да вземеш {hunters} ловци.{Environment.NewLine}";

			sb.Insert(0, s);
			this.CurrentEpizodeModel.Decription = sb.ToString();

			return condition & ~(flag);
		}

		private ConditionFlagsEnum InstantlySkipToNextEpisode(ConditionFlagsEnum condition)
		{
			//;KeyNotFoundException,poko,
			//TODO
			ConditionFlagsEnum notb = ~ConditionFlagsEnum.InstantlySkipToNextEpisode;

			return condition & notb;
		}

		//PostAction Functions
		private PostActionFlagsEnum AddPostValueToChecksum(PostActionFlagsEnum condition, int conditionValue, CheckSumsIndexEnum index, PostActionFlagsEnum flag)
		{
			this.playerStatus.Checksums[(int)index] += conditionValue;

			return condition & ~(flag);
		}

		private PostActionFlagsEnum RandomChois(PostActionFlagsEnum condition, ref ChoisesModel choisAction, PostActionFlagsEnum flag)
		{
			int randomEpizodIndex = this.RandomChois(choisAction.ActionValue + 1);

			ActionDescription action = this.CurrentEpizodeModel.ActionsList.Skip(randomEpizodIndex - 1).Take(1).ToList().First();
			choisAction = new ChoisesModel(action.TargetEpizodeId, action.ChoisPoint, action.PostActionFlags, action.ActionValue, action.VisibleValue);

			return condition & ~(flag);
		}

		private PostActionFlagsEnum DoubleCheckingTheSixthChecksumWithActionValue(PostActionFlagsEnum condition, ChoisesModel choisAction, PostActionFlagsEnum flag)
		{
			int epizodeMask = 0;
			if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex6] == choisAction.ActionValue)
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfLow9Bits, MaskOrder.LowOrderMask);
			}
			else
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfMiddle9Bits, MaskOrder.MediumOrderMask);
			}

			choisAction.TargetEpizodeId = epizodeMask;

			return condition & ~(flag);
		}

		private PostActionFlagsEnum TernaryCheckOfFirstChecksumWithActionValue(PostActionFlagsEnum condition, ChoisesModel choisAction, PostActionFlagsEnum flag)
		{
			int epizodeMask = 0;
			if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] < choisAction.ActionValue)
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfLow9Bits, MaskOrder.LowOrderMask);
			}
			else if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] == choisAction.ActionValue)
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfMiddle9Bits, MaskOrder.MediumOrderMask);
			}
			else
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfHight9Bits, MaskOrder.HightOrderMask);
			}

			choisAction.TargetEpizodeId = epizodeMask;

			return condition & ~(flag);
		}

		private PostActionFlagsEnum DoubleCheckingTheFourthChecksumWithActionValue(PostActionFlagsEnum condition, ChoisesModel choisAction, PostActionFlagsEnum flag)
		{
			int epizodeMask = 0;
			if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex4] >= choisAction.ActionValue)
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfLow9Bits, MaskOrder.LowOrderMask);
			}
			else
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfMiddle9Bits, MaskOrder.MediumOrderMask);
			}

			choisAction.TargetEpizodeId = epizodeMask;

			return condition & ~(flag);
		}

		private PostActionFlagsEnum IfFifthChecksumIsGreaterOrEqualToActionValue(PostActionFlagsEnum condition, ChoisesModel choisAction, PostActionFlagsEnum flag)
		{
			int epizodeMask = 0;
			if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5] >= choisAction.ActionValue)
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfLow9Bits, MaskOrder.LowOrderMask);
			}
			else
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfMiddle9Bits, MaskOrder.MediumOrderMask);
			}

			choisAction.TargetEpizodeId = epizodeMask;

			return condition & ~(flag);
		}

		private PostActionFlagsEnum TernaryCheckOfFirstChecksumWithActionValueAndVisibleValue(PostActionFlagsEnum condition, ChoisesModel choisAction, PostActionFlagsEnum flag)
		{
			int epizodeMask = 0;
			if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] < choisAction.ActionValue)
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfLow9Bits, MaskOrder.LowOrderMask);
			}
			else if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] < choisAction.VisibleValue)
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfMiddle9Bits, MaskOrder.MediumOrderMask);
			}
			else
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfHight9Bits, MaskOrder.HightOrderMask);
			}

			choisAction.TargetEpizodeId = epizodeMask;

			return condition & ~(flag);
		}

		private PostActionFlagsEnum IfTheSixthChecksumIsGreaterThanActionValue(PostActionFlagsEnum condition, ChoisesModel choisAction, PostActionFlagsEnum flag)
		{
			int epizodeMask = 0;
			if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex6] > choisAction.ActionValue)
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfLow9Bits, MaskOrder.LowOrderMask);
			}
			else
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfMiddle9Bits, MaskOrder.MediumOrderMask);
			}

			choisAction.TargetEpizodeId = epizodeMask;

			return condition & ~(flag);
		}

		private PostActionFlagsEnum IfTheFirstAndFifthChecksumsAreEqualToActionValue(PostActionFlagsEnum condition, ChoisesModel choisAction, PostActionFlagsEnum flag)
		{
			int epizodeMask = 0;
			bool check = this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex1] == choisAction.ActionValue;
			check = check && this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5] == choisAction.ActionValue;
			if (check)
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfLow9Bits, MaskOrder.LowOrderMask);
			}
			else
			{
				epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfMiddle9Bits, MaskOrder.MediumOrderMask);
			}

			choisAction.TargetEpizodeId = epizodeMask;

			return condition & ~(flag);
		}

		private PostActionFlagsEnum RandomSelectionDependingOnFifthChecksum(PostActionFlagsEnum condition, ChoisesModel choisAction, PostActionFlagsEnum flag)
		{
			int maxRange = 1;

			if (this.playerStatus.Checksums[(int)CheckSumsIndexEnum.CheckSumsIndex5] > choisAction.ActionValue)
			{
				maxRange = 3;
			}
			else
			{
				maxRange = 2;
			}

			int epizodeMask = 0;

			switch (RandomChois(maxRange + 1))
			{
				case 1:
					epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfLow9Bits, MaskOrder.LowOrderMask);
					break;
				case 2:
					epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfMiddle9Bits, MaskOrder.MediumOrderMask);
					break;
				case 3:
					epizodeMask = this.MaskChois(choisAction.ChoisPoint, MaskOrder.MaskOfHight9Bits, MaskOrder.HightOrderMask);
					break;
				default:
					break;
			}

			choisAction.TargetEpizodeId = epizodeMask;

			return condition & ~(flag);
		}



		private int MaskChois(int choisPoint, MaskOrder bitsMask, MaskOrder orderMask) => (choisPoint & (int)bitsMask) / (int)orderMask;

		private void SetCurrentEpizod(Epizod firstEpizod)
		{
			//string[] configurationArray = firstEpizod.ConditionFlags.Split(ConstantsDto.SEPARATOR_DTO);
			//ConditionFlagsEnum conditionFlags = ConditionFlagsEnum.ZeroCondition;

			//foreach (var condition in configurationArray)
			//{
			//	Enum.TryParse(typeof(ConditionFlagsEnum), condition, out object conditionFlagsObj);

			//	conditionFlags = conditionFlags | (ConditionFlagsEnum)conditionFlagsObj;
			//}

			this.CurrentEpizodeModel = new EpizodeModel(firstEpizod.Id, firstEpizod.Decription, firstEpizod.ConditionFlags, null, firstEpizod.ConditionValue, firstEpizod.ConditionValue2, firstEpizod.ConditionValue3, this.playerStatus);
			this.SetActionsList(firstEpizod);
		}

		private void SetActionsList(Epizod firstEpizod)
		{
			List<ActionDescription> targetEpisodes = new List<ActionDescription>();

			foreach (ChoiseEpisode action in firstEpizod.ChoisEpisodes)
			{
				ActionDescription newAction = new ActionDescription(action.EpizodeId, action.TargetEpizodeId, action.ChoisPoint, action.Decription, action.PostActionFlags, action.ActionValue, action.PreActionFlags, action.VisibleValue);

				targetEpisodes.Add(newAction);
			}

			this.CurrentEpizodeModel.ActionsList = targetEpisodes;
		}

		private Epizod GetEpizdById(int id) => baseBook[id];

		private int RandomChois(int maxRange)
		{
			Random rnd = new Random();
			int r = rnd.Next(1, maxRange);

			//Console.WriteLine($"r {r}");
			//Console.ReadLine();

			return r;
		}
	}

}
