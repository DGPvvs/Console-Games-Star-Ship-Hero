namespace GameStarShips.DataProcessor
{
	using GameStarShips.Data.Enums;
	using GameStarShips.DataProcessor.Constants;
	using GameStarShips.DataProcessor.ImportDto;
	using GameStarShips.EpizodeModels;
	using Newtonsoft.Json;
	using System.ComponentModel.DataAnnotations;
				
	public class Deserializer
	{
		public static void ImportEpizodes(string jsonString, ref Dictionary<int, Epizod> list)
		{
			EpizodeDto[] importSellersDto = JsonConvert.DeserializeObject<EpizodeDto[]>(jsonString);

			List<Epizod> sellers = new List<Epizod>();

			foreach (var epiDto in importSellersDto)
			{
				if (!IsValid(epiDto))
				{
					continue;
				}

				string[] conditionFlagsArray = epiDto.ConditionFlags.Split(ConstantsDto.SEPARATOR_DTO);

				ConditionFlagsEnum conditionFlags = ConditionFlagsEnum.ZeroCondition;

				foreach (var condition in conditionFlagsArray)
				{
					Enum.TryParse(typeof(ConditionFlagsEnum), condition, out object conditionFlagsObj);

					conditionFlags = conditionFlags | (ConditionFlagsEnum)conditionFlagsObj;
				}

				Epizod epizode = new Epizod()
				{
					Id = epiDto.Id,
					Decription = epiDto.Decription,
					ConditionFlags = (ConditionFlagsEnum)conditionFlags,
					ConditionValue = epiDto.ConditionValue,
					ConditionValue2 = epiDto.ConditionValue2,
					ConditionValue3 = epiDto.ConditionValue3
				};



				foreach (var item in epiDto.ChoisEpisodes)
				{
					if (!IsValid(epiDto))
					{
						continue;
					}

					string[] postActionFlagsArray = item.PostActionFlags.Split(ConstantsDto.SEPARATOR_DTO);
					PostActionFlagsEnum postActionFlags = PostActionFlagsEnum.Zero;

					foreach (var postAction in postActionFlagsArray)
					{
						Enum.TryParse(typeof(PostActionFlagsEnum), postAction, out object conditionFlagsObj);
						postActionFlags = postActionFlags | (PostActionFlagsEnum)conditionFlagsObj;
					}

					string[] preActionFlagsArray = item.PreActionFlags.Split(ConstantsDto.SEPARATOR_DTO);
					PreActionFlagsEnum preActionFlags = PreActionFlagsEnum.Enable;

					foreach (var preAction in preActionFlagsArray)
					{
						Enum.TryParse(typeof(PreActionFlagsEnum), preAction, out object conditionFlagsObj);
						preActionFlags = preActionFlags | (PreActionFlagsEnum)conditionFlagsObj;
					}

					ChoiseEpisode targetEpisode = new ChoiseEpisode()
					{
						EpizodeId = item.EpizodeId,
						TargetEpizodeId = item.TargetEpizodeId,
						ChoisPoint = item.ChoisPoint,
						Decription = item.Decription,
						PostActionFlags = postActionFlags,
						ActionValue = item.ActionValue,
						PreActionFlags = preActionFlags,
						VisibleValue = item.VisibleValue
					};

					epizode.ChoisEpisodes.Add(targetEpisode);
				}

				list.Add(epizode.Id, epizode);
			}
		}

		private static void SetChoisEpisode(EpizodeDto[] importSellersDto, ref List<Epizod> list)
		{
			var episodesId = list.Select(e => e)
				.Select(e => e.Id)
				.ToArray();

			List<TargetEpisode> targetEpisodes = new List<TargetEpisode>();

			foreach (var item in importSellersDto)
			{
				//var epizode = context.Episodes.FindAsync(item.Id);

				foreach (var choiseEDto in item.ChoisEpisodes)
				{
					if (episodesId.Contains(choiseEDto.TargetEpizodeId))
					{
						string[] postActionFlagsArray = choiseEDto.PostActionFlags.Split(ConstantsDto.SEPARATOR_DTO);

						int postActionFlags = (int)PostActionFlagsEnum.Zero;

						foreach (var postAction in postActionFlagsArray)
						{
							Enum.TryParse(typeof(PostActionFlagsEnum), postAction, out object conditionFlagsObj);

							postActionFlags = postActionFlags | (int)((PostActionFlagsEnum)conditionFlagsObj);
						}

						string[] preActionFlagsArray = choiseEDto.PreActionFlags.Split(ConstantsDto.SEPARATOR_DTO);

						int preActionFlags = (int)PreActionFlagsEnum.Enable;

						foreach (var preAction in preActionFlagsArray)
						{
							Enum.TryParse(typeof(PreActionFlagsEnum), preAction, out object conditionFlagsObj);

							preActionFlags = preActionFlags | (int)((PreActionFlagsEnum)conditionFlagsObj);
						}

						//TargetEpisode tE = new TargetEpisode()
						//{
						//	EpizodeId = choiseEDto.EpizodeId,
						//	TargetEpizodeId = choiseEDto.TargetEpizodeId,
						//	ChoisPoint = choiseEDto.ChoisPoint,
						//	Decription = choiseEDto.Decription,
						//	PostActionFlags = (PostActionFlagsEnum)postActionFlags,
						//	ActionValue = choiseEDto.ActionValue,
						//	PreActionFlags = (PreActionFlagsEnum)preActionFlags,
						//	VisibleValue = choiseEDto.VisibleValue
						//};

						//targetEpisodes.Add(tE);
					}

				}

			}

			//context.TargetEpizodes.AddRange(targetEpisodes);
			//context.SaveChanges();
		}

		private static bool IsValid(object dto)
		{
			var validationContext = new ValidationContext(dto);
			var validationResult = new List<ValidationResult>();

			return Validator.TryValidateObject(dto, validationContext, validationResult, true);
		}
	}
}
