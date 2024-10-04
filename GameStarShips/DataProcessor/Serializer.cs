namespace GameStarShips.DataProcessor
{
	using GameStarShips.DataProcessor.ImportDto;
	using GameStarShips.GamePlayer.Models.PlayerModel;
	using Newtonsoft.Json;

	public class Serializer
	{

		public static void ImportPayerStatus(string jsonString, PlayerStatus status)
		{
			PlayerStatusDTO playerStatusDTO = new PlayerStatusDTO
			{
				Checksums = status.Checksums,
				PreviousValueChecksum1 = status.PreviousValueChecksum1,
				PreviousValueChecksum5 = status.PreviousValueChecksum5,
				CurrentEpizodeIndex = status.CurrentEpizodeIndex
			};

			var importSellersDto = JsonConvert.SerializeObject(playerStatusDTO);

			File.CreateText(jsonString).Close();
			File.AppendAllText(jsonString, importSellersDto);
		}
	}
}
