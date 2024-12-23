namespace TestGameStarShips
{
	using GameStarShips;
	using GameStarShips.GamePlayer.Models.PlayerModel;
	using GameStarShips.GamePlayer.Test.Contracts;
	using TestGameStarShips.IO;

	public class Tests
	{
		private Reader read;
		private Writer write;
		private PlayerStatus playerStatus;

		private PlayerStatus SetPlayerStatus()
		{
			PlayerStatus result = new PlayerStatus();
			result.Checksums[1] = 20;
			result.Checksums[2] = 10;
			result.Checksums[3] = 4;
			result.Checksums[4] = 20;
			result.Checksums[5] = 10;
			result.Checksums[6] = 10;
			result.Checksums[7] = 10;
			result.Checksums[8] = 10;
			result.Checksums[9] = 30;

			return result;
		}

		[SetUp]
		public void Setup()
		{
			this.read = new Reader();
			this.write = new Writer();

			this.playerStatus = this.SetPlayerStatus();
		}

		[Test]
		public void TestEpizode1Chois1()
		{
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(1, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = "1";
			game.GameAction();

			string expectedDescription = "������ �� �� �������� � ����� ���������, � �� �� ������� ��������� �� �������� �� ���������� ������. ������������ ������ �� �� ��������, ��������� � �������� ��-�����, �� �� �������� ������ �� �� ��������.\r\n����� �� ��������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode1Chois2()
		{
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(1, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = "2";
			game.GameAction();

			string expectedDescription = "������ �������� � ��� ���� � ���� �� ��������� ����������, ������� ����� ������-����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode1Chois3()
		{
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(1, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = "3";
			game.GameAction();

			string expectedDescription = "��������� �� ���������� � � ����� ������� �������� ��������� �������. ������� ������� �� ����� � ������� ��������� �� ������ ������� �� ���. �������� ����� ���������� ������������� �� �������� � ���� ������� �� ������ ����, ����� ��������� ���������. � ���� ������ ������� ����� �� �� ����� � ����� ����� �� �����������:\r\n� ����������, ���������. ��������� �� �������! ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode2Chois1()
		{
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(2, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = "1";
			game.GameAction();

			string expectedDescription = "� ��������� ��������� � �������� �� ����� ������� ������� ������� ��������� ����� ���� ����� �������� ����� �����. ��� ���������� �� �� �������� � ��������� ������ � ����, ������ �� ��������� �� �������������� ������ ��� ���������, ��������� ��������� �� ����� ���������� �� �������. ��� �������� ����������� � ��������� ��������, ��������� �� ������ ������� �� ��������� ������� �� ���������. ��� �������� �� ������, ���� ��� ���� �������� �� ��������� � ����������� � ������ ������ �� �� ������ �� ����������� � �������� ���������.\r\n���� ������ ��������� � �������� �� ��������� �������� �������� �������� �� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode3Chois1()
		{
			int currEpizodeId = 3;
			string currentChois = 1.ToString();
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������������� ����� ������������ �� ���������� ������� ������ �� ����� � ���� �� ����� �� ����������� ���������� ������� �� ��������� �������. �� ��������� � ������� ���� �������� �����:\r\n������ � ���������� ������� � ��������� �������. �������: 8/9 �� �������. ������ �� �������: 22 ����. ������ ������ �� ���������� ��. ���� ���������� ��������.\r\n��������� ����� � ������ ������. ���� �� ����������� ��������� � �� 2/5 �� ���������. ������������� �� � ����� ����������� ������ � ��������� �� ���������� �������. �������� � ���������� ����������� ��������������� �������. ���������: ����� 200 000, ����� ��������� � ��������� �������, �������� �� ���������� �� ������������.\r\n���� � ������������ �����, ������ ���� �� �� ��������� ���������� �������-����.\r\n��������� ��������� � ����� ������������ �� �����������. �������� � ���������� �������. ����������� � ��� �������� �� �����������.�\r\n������ ������������ �� ���������� �� ���������� � ��������������� ��������� ������������ �� ���� ������ �������� � ����������.\r\n������: �� �� ������� ������ �� ����� � ��������� ������ � �� �� �������� ������������ �� ������. �� ���������� �� �� �������� �������� � �� �� ������ �������� ������������. �������� ��������� � ��������������. ��������� �� ���� ���������� ������.\r\n����������: ����� �� �����, ��������� �� ����������� �����. �������� �� ������������ �� ��������������� �������� � ��������������� �������������� �� ��� ������ �� ������ ������.\r\n������ � ��������� �� ���������.\r\n������ �� ���������� �����: �������� �� �������: ��������� �� ����� ��������ѓ � ���� �� ��, ��������. ����� �����:        ���� ������� � ����� ���������.\r\n���������� �����: ����� ������; ���� ���������� �� ����������� � �����������; ���� ���������� �� ���������� ����������� � �����������.\r\n���������� ����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode4Chois1()
		{
			int currEpizodeId = 4;
			string currentChois = 1.ToString();
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������ ������� ����������! � ��������� ���������. � ������ �� �������� �����!\r\n���� �� ������� ������� ����� ����� ���������� �� ����� ��������. � ������� �� ���������� ��������� ����� �� ��������������, ������� � ���������������� �� �����������, ���� �� ������ � ������, �������������� � ���� �� ��������� �������.\r\n� ��������� ������� ������������ ��������� � ������� ����������. � ����������� ������ �� �����. �������� ���������.\r\n� �������� �� � ������ �� ���������� ��. ���������� �������!\r\n� �������� ������� ������������ ���������. ������� � �����������.\r\n� ��������� ���! ���������, � ����� �������. �������� ������. ���� ���� �������� �������!\r\n� ��������� ������ �� �������� ��?\r\n� ���� ����� �� ���� �� ��������. ��������� �����������.\r\n� ����������� ������� ������������ ���������. ����������� ���������.\r\n� �������� ������� ������! ���������� ������! ����!\r\n����������� ������ ������ �� ������� ���� ������ ��. ������� �� �������� �������� � ��� �����, �� ��������� ����� �������.\r\n� ����� � ��������, ���������! � �������� ���� ����������� �������� ������������, ���� ������� �� �������� �������.\r\n� ���� �� �������������� ��������� � �������� ����������. � �������� ��������. �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode4Chois2()
		{
			int currEpizodeId = 4;
			string currentChois = 2.ToString();
			PlayerStatus playerStatus = new PlayerStatus();
			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��������� ����������. ������������ �������� ������� � �� �� �������� ������� � ��������� � ��� �� �������� ��� ���� �� ��������.\r\n� ������ �� ��� ���������. ������ ���������� �������� ������� � � ���� ���������� �������� ������ �� ������, ����������: � ������ �� �� �� ������ � ����� �����!\r\n� �������� ������� �� ���������� ���������. �������� � �����������. ��������� � ������� �� ��������. �������� �������� �������.\r\n�������� �� ������ � �������� ���. ���� � ����� �� �������. ���� ���� �� �� ��������� ��� ����������.\r\n� ���� �� �������������� ��������� � ��������� ����������. � �������� ��������. �����!\r\n����� ������ �� �������� ��� �������� � �� ����������� ���� ����� �� �� ������ ����� ������. ���� ���� ����� ����� ����������� �� �������� �� ����������� �� ������. ������ ���������� ���� ������� ����, ��� ��� ��������� � � ����� ���� � ����� ������� ������������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(factResult, expectedResult);
		}

		[Test]
		public void TestEpizode4Chois3()
		{
			int currEpizodeId = 4;
			string currentChois = 3.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� �����������! � ������� ������� ��. � ��������� ���������� �������� � ������ �� ���������.\r\n� ����������� �� ���� � �������� ������� ����������. � �������������� ��������� � ��������. ����� ���������� �� ���������!\r\n� ������ ��������� ������ � �������������� ����! � �������� �� ������ ����� �����, ����� �������� ��-������ � �������� � ��-����.\r\n� ���� �� �� �� ������, ������ �������� ��� ���? � ���� ��� �������� � ����� ������������.\r\n� � ���� ������? � ��������� ��. � �������� ��, � � ��� �� �������� ��������.\r\n� ������������ �� �������� �������� � �������� ����������. � �������� ���������. �������� ������� �� ������.\r\n������ �� ������� ����� � ������ ������ � �������� ���. ���� �� �� ���� �������� �������!\r\n� ���� �� �����������. �������� ���������� ��������.\r\n� ���� �������� �� �������� ���� ������� ����� ����� �������� ����. ��������� �� ������ ��������, ������ ������������ ��������� ��� ��������� � ��������� �������� ��������. � ������ ��� ��������� �� ������ � �����������, ����� ����� ����� � �������� ��������� �� ������� � ��������� ������� ����������� �� ��������. ���� ������� ������� ������� �� ����������� � ������������� ���� �� �������� �������:\r\n� ������� ��������� � �����������. ������ ������� ������� ��������. ��������� ���������� ������. ���������� � ����� �� ���������� �����. ���� ���������� �� �����.\r\n� ������ ������� � ������������ ������� �� ����� �������! � �������� ������� �� ��������.\r\n� �������� �� ������� ��! � ������ �����, ������ ����������� ��� ����� ��. � � ��-����! � �������� � �� ��� ��������� ���������.\r\n���� � �������� ���� �������, ��������� �� ������ ����� ��� ��������� ������ �� ��������� � ���� ���� � ������ ����� �� ����� ����������, ���� �� ��� ��������� �� ����.\r\n���� ����� �������� ������ ��� �� ������������. ��������� � ������� �������� �� ����� �������� �� ����������� ������ ����. ��������� �������� � ��������� ������������ �� ������ ����� � ���� ������ �� �� ������� ���� ��������, ��������� ������ ����. �������� ����� �������� ���� ������, �������� �� ����� �����. ����� ������� � �������, ����� �� �������� �� ���������� � ����� ���������� ��������. ������ � ������ � ����� ��������� � ��������� ������� ����� �����. ��� ��������� ���� ��� ������, ���� ����� �� ������ ������ �����. ���������� ���� ������� �������� ����, �������� �� ����������� ������ �� ������ ����.\r\n� ����, ������� ���� �� �������� � ��������� �������. �������� �� �� ����������� � ���� ���� 15 ��� �� ���������� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 10;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode4Chois4()
		{
			int currEpizodeId = 4;
			string currentChois = 4.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������� �� ���������� ���������. ����������� ���������. ��������� � ������� �� ��������. �������� �������� ������� � ������� ����������.\r\n� ���������, ��� ��� �� ����� ������! ��� �� �� ����� ����� � ������! � ����� ����� ������� �����.\r\n� ���� �� ���������� ���������! �������� �����������! � ����� ����� � ����� ������� �� ������� ����. � ������� �� ����� ����������! ������� ����������!\r\n� �������������� ������ �������� � ����������� �������� ����������. � ��������� �����������.\r\n� ������ ����������� � ������� �����! �� �������� �� ����������� ������ � � ������� �������� ��� ����� ��, �����: � ���������� ����� �� ������ � ���������� ������!\r\n� �������� ����������� �� ����������� �� ���� ������ � �������� �� �������� � ��� �� ��������� ������, ������ � ������ � �������. ���� �� ������� ���������� �� ����� ����������, �� �� ���������� ��� �� �� �������.\r\n� ����������� �� � ���������� � ������ � ������� �� ������� �����.\r\n� ��� � ���� ���� �� ������, �� �������.\r\n� ������ ���! � ���� ���������, ���� �� ����� �� �� ������.\r\n����� ����� �� ��������? ��� �� ������� �� ������. ���� �� ������, �� �� �� ��� ����, ����� ������ �� ������� �� � ����� ������� �� ����������� �� ���� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode5Chois1()
		{
			int currEpizodeId = 5;
			string currentChois = 1.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� � ������ ���������! � ������ ���������, ���� �� ������� �� �� �� �������.\r\n������������ � ������ �� �� ������ �� �������� ��� ���������� ������ ��� ������ �����, ����������� ������� ��� � ���� �� ������ � ����������������, � �������� � ����� �����, ������� ��������� ������ �������. ��������� ����� ������� � �� ���������� ������ � ����� ��������� ������� �� �������� � ������� ������ �������, ����������� �� ������ ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode5Chois2()
		{
			int currEpizodeId = 5;
			string currentChois = 2.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� � ������� ��������� � ������ ���������, ���� �� ������� �� �� �� �������.\r\n������������ � ������ �� �� ������ �� �������� ��� ���������� ������ ��� ������ �����, ����������� ������� ��� � ���� �� ������ � ����������������, � �������� � ����� �����, ������� ��������� ������ �������. ��������� ����� ������� � �� ���������� ������ � ����� ��������� ������� �� �������� � ������� ������ �������, ����������� �� ������ ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode5Chois3()
		{
			int currEpizodeId = 5;
			string currentChois = 3.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� � �������� ��� �� ������ �������� ������� � ���� �������� ���� �������� ����� ����� � �������� �����, ������ ����� � ������������������ �� ������, �� ����� ��� ��� ������� ����� �� ������. �������, ��� �� ����� ������ �������, ����������� ��������, ���������� � ���� ����������� �� �������� ���������� �����.\r\n���������� � ��������, ��������� �� �������� ��������� ���� � ���� ���� ���� ������ �����. �������� �������� ����� � ���� �� ������ �� ����� ������� �� ����������� ��� �������������, ������ �� ������� ������ ������ ������� ���������� � ���� �� ������ ���� �����, ����� ������� ����� ����� �� � ������ �������, ��� ����� �� ������.\r\n���������� �� ������ �� ����� �������, �� �� ����� ����� �� �� ��������� � ���, � ������ �� �������� ��� �� �� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode5Chois4()
		{
			int currEpizodeId = 5;
			string currentChois = 4.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 0;
			playerStatus.Checksums[6] = 0;
			playerStatus.Checksums[7] = 0;
			playerStatus.Checksums[8] = 0;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������� ��� ����� ��� ������, �� ��� �� �������� ������� ������� �������������� �������.\r\n�������� �������, �� ����� ��������� �� �������� �� ������, ������������ �� ����� ���������� �� ����������� �� ���������. ���� �� �������� ������� ��������� �� ������� �� ���������� � ���������, ������� ��������� �� �������������.\r\n���� � ���� ��� � �� ������ �� ������� � ����� �� �� ������ �� ������ ��������. � ����� ���� ����� ������ �� ���������, �� ����� ��� ���������� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 20;
			expectedPlayerStatus.Checksums[2] = 10;
			expectedPlayerStatus.Checksums[3] = 4;
			expectedPlayerStatus.Checksums[4] = 20;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 30;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode6Chois1()
		{
			int currEpizodeId = 6;
			string currentChois = 1.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode7Chois1()
		{
			int currEpizodeId = 7;
			string currentChois = 1.ToString();

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1] + 20;
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);			

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode8Chois1()
		{
			int currEpizodeId = 8;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = int.Parse(currentChois);

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ��� ������� ������ �� ��������� ��������� ���������� ������, �� ���� ������� �� ������� � ���� ������ ������� ����, �� �������� �� ������� �� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode8Chois2()
		{
			int currEpizodeId = 8;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ��� ������� ������ �� ��������� ��������� ���������� �� ������ � ������� ������ ������� �� ��������� ������� �� �������. ������ ������� ������ ������� � ����� �����������, �� ����������� ��� �� ������� � ����� � �������� � ��������, ������� �� ��������� �� ������� �� ��������. ��-������� ������ �� ������� � ���������� �������. ��������� ������� �� ������� ����������� � ���� ������� �������, ��������� ���������� �� ���������� �� ���������.\r\n� ����������� ������ ���! � �������� ����� ���� �� ��������. � �������� ���� ��������. ����, �������� ���!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode8Chois3()
		{
			int currEpizodeId = 8;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ��� ������� ������ �� ��������� ��������� ���������� �� ������ � ������� �� ������ ����� ��������� ������� �� �������. ������ ������� ������ ������� � ����� ������� � ���������� �, �� ���������� ���� ������������ ������� � ����� �� �������. ���� ���� � ���������� ������������ � ��������� � ��������.\r\n� � ���� ����� ��� ���\r\n� ���������, ������� ������ ��� � ����� ������� � ������ �� ������� �� ��������. � ������� ��, ��� �� �������� ���� ������.\r\n� �������� ����������! � ��������� ��. � �� ������� �� ��������� ������� �� ����������? � ������������ �� ���.\r\n�� ������������ ���������� �� �������� ��������� �������� ����� �������� � ������� �� �� ������� �������� ��������� �� ������� � ������ ������� �� ����������.\r\n� ��� ������� ������� �������, ������� �� �� ������� � ������� ����������� ��, ����� ������������. � �� ����� ������, ��� ��������� ���������� �������, ����� �� �� ������� ������� ����������.\r\n������ �� ������ �� ������ �������. ������������� �� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode9Chois1()
		{
			int currEpizodeId = 9;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois1()
		{
			int currEpizodeId = 10;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ������� � ���������� ��������������:\r\n���������� ������� � ��� �����, ������������ �� �������� �� ����� �������� ����� �� ������� �� ����� ���. �� ������������ ����������� ������ � �������� ������������ �� �� ������ ���������� � �� ������ � ������������� ������ ��� ������-�������.\r\n�������� � �� �������� ����� ����� �� �������� ������, ��������� �� ����� ��������� � ������������ ��������� �� �������� ������. �������� � ������� � ������� ��������� �� ���, ����� �� ����� � �������� ����� � ����� ������ ���������������, ���� �� ������ ����������.\r\n������������ � �����, ���� ��� ������� �������. ������� �������� ���������� ������ � ��������� ������� �������� ��� ������ �������.\r\n�������� � ��� ������� �� ���������� � ������� �����������. ��� �������������� �� 10 ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois2()
		{
			int currEpizodeId = 10;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������������ � ���������� ��������������:\r\n���� ����������� ������������, ����������� �� �� �������, ��-����� ���� �� ���� ������������ ���� ��� ������� ����. ���������������� �� � �� �������� � �������� ��� ����� ����� ����� �� 12 ������.\r\n������������� �� �������� � ����� �����������. ������ � ������� �� ���� ���������, ���������� ������ � ������ ��������� ����, ����� �� ���������� �� �� ����� ������� ����� ����� �� ��� ����� ��� ���, ���� � �� ����� ��������� ��������.\r\n�������� � ��������� �� 10 �� ����� �� ��������� ��������������� �����, �������� ��� � ����� ���������, ������� ������ �� �������� � �������� ��������� � ������ �������. ���� ������� ����������: 100.\r\n�������� � � ����������� �������, ���������: ������� �������, �������� �������� ������� ������� � ���������� ��������������� ����������. ������������ � ������� � �������� ���������� ������, ����� � ������ �����, ����� � � ����� ������� �� ���������� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois3()
		{
			int currEpizodeId = 10;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������������� � ���������� ��������������:\r\n���������������� � ������, ����� �� ����� ������� ��������� �� �������������. �� ������� �� ���, ��� ������� � �������� �� �����, � ���� �� �������� ���������, ������� �� ��������� ������ ������. ������� ������� � ������� ���������� �� ��������� �������������� ��� ����������� �� ��������� � ����������� ������� ������� �� ������������� �����.\r\n���������� �� ������, ���������������� �� ������ ���������� �������� ����� �� �����������, ���� � �� ����� ����. ����� ����� �� ����� ���� �� �������� ������� �������������� � �������� ������.\r\n�������������� �� �� ���������� ��������� � ����� ����������� �������� � ����� �� ��������� �������� ������, �������� � ����� ������� � �������������� �� 500 ���������.\r\n���� ��������� ���������� � ������.\r\n�������� �� ������: �� 100 �����, � ���������� ������� 65 ��/���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois4()
		{
			int currEpizodeId = 10;
			string currentChois = 4.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� �������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois5()
		{
			int currEpizodeId = 10;
			string currentChois = 5.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� ���������� ����������.\r\n�������� � ����������� ���������� ���������� � ������������� �� ����������� � ��������� �� ������� ����� � ���� �� �� ���� ����� ������� ����� �� �������� �� ������������� ����������, ���� � �� ����� �� ������ �����.\r\n����������� ���������� ���������� �������: ������� �� ���������� �����������, ������������� ��������������� ����������, ��������� �� ���� �� ������� �������� � ������ ���������, ��������� �� ������� ��������� ����������, ����� � ����� �������� ������� �� ������������ ��. ������ ����� �� ��������� � 145 ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois6()
		{
			int currEpizodeId = 10;
			string currentChois = 6.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ � ��������������:\r\n������� ������������ � ������, ��������� �� ������ �� ������ �������������� �� ��������� ����������������� �������. ��� ������� ���������� ���, �� � � ������ ������������ � ������ �����. ������ �� ������ ���.\r\n�������� ����� � �����������, ������������ ����� � �������� ������. ������������ �� ����������� ������� �� ���� �� ������ � ��������� �� ����������. ���� ������ ������ ������ �� � ����� ����������. ����� ���������� � ����� � ��������� ��� ������ ���������� �����.\r\n�������� �� ����������� ������� � ������� ����� ��� �� �������� ����������� �������. �������� �� ���� ���� ����������� ������� �� ������. ����� ���������� � �������� �� �������� ���������.\r\n���������� ������� � ������� �������� ��������� ����� � �������� � ������������ ������. ����������, ������, �� ����������� ����� � � ����� ������������� ������. ��������� ����, ������������� ���������� �� ���������.\r\n����������� ������ � ��������������� ���������� � ������ ������������ �� ������������, ����������� ���������� � ������������, � ������ ���������� � ��������� ���. ��������, ����� �� ���������� � ������������� �������. ����� �� �� ������������ ��������� ��������.\r\n������ � ���������� ��� ������������� ��, �������� ����� ������������, � ��������� ������������ ������, ������� � ����������. �� ���������� ��� ������ ����� � �� ������������� �� ����������� �� ����.\r\n����� ������� � ������ � ������� ���������� ����. ��������� ����� ������, ��� �� ���������� �������� �����������, �� � ������ � ���� �� ���-������� ����� ��������. ���������� �� �� �������� �� ������������� �� ���������� �� �������� ����� ������ � ��������� ������� � �����. ����� ������������ �����������. ��������� � ���� �� ������� ����������.\r\n \r\n������� ���������� �� ��������:\r\n��������� ������������� � ���� � ������������ ����������, �� ����� �������� ������� 95% �� ������������ �� ����.\r\n���������� ���� � �������� ����������� �������� �� ������ �� ��������. ���������� �� ������� ��� ����������� �������� �� ������� ����, ����� ���� �� ���� ������ �� ����������, ����� �� ����������� �������������.\r\n��������� ������� � �������������� �� ��������, ��������� ������������ �� �� ��������� ���������� � ��������� ���� ��������. ���� � ����� ��������� � �� ���� ������� � ���� ������:\r\n����� ��� � ���������, ����� ������� ������. ������� ������� �� �� ����, ���� ��� �� ������ �����������, ������ ������� �� ����������� ������ � ������� �� ������� ������� �� �� ������ � ���������, ���� �� �� � ����� �����������.\r\n����� � ������������ � ����� �� �������� � ���������, ������ � ���������� �� ��������� ��� �������. ������ �� ���� ������ �� ���� �� 45 �� ��� ����� � 15 �� �� ����� �� ��������.\r\n \r\n�������� �� ������:\r\n����� ��������� � ������� �� ����������� � ���������� �� ������ �� ������������� ������. ������� �� ������ �� ��������� �� ���������� ��������. �� ���������� �� ���������� ��������.\r\n����� ����� � ������� �� ����������� � ����������� �� ���������� ������. ������������� �� ������ �� ��������� �� ���������� � ��������� �� ���������� �� ������. ���� �� ���� ���������� ����� �� ����� ��� � ����� �������. �������� ����� �� ���������� �� ��������� �� �� �������� �� ������������ ������.\r\n������� ������� � ��������� � �� ��������� ��������������� �����. ���� �� ����� ���� ����������� ��������� ��������. �� ��������� � ����� � ��������. ���� �� �������� ������ ���� ������� � �����.\r\n \r\n������� ����������:\r\n������� ���������� � ������������ �� ������� ������� � ���������� ���������� ����.\r\n����� �� ��������� � ����� � ��������� �� ��������� �������� � ���������� �� ��������, ��� �� ���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode10Chois7()
		{
			int currEpizodeId = 10;
			string currentChois = 7.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���������� �� ���������� ����� �� �� ��� � ���� �� �������� � ������� �� �� ������������. � ��������: ���������� �� ���������� ����� �� �� ��� � ���� �� ��������.\r\n� ������ ������ � ���� ������� �� ����� �� ��������, ���� �������� ����� ����������� ��������� � �����.\r\n� ���������� �� ���������� ����� �� �� ��� � ���� �� �������� � ������� ������ �������������. � ��������: ���������� �� ���������� ����� �� �� ��� � ���� �� ��������! �������!\r\n�� ���� �������� � ���������� ���� �� ���� � ���� ���������� �� �������� � ���� �� ������������.\r\n� ����� � �� ���������, ��������� � ����� ������� ��� ������ ����������. � ��� �� � ���������� ����������. ���� 45 ������ ��������� �� ��������� �����. ��������� �� ������ ����� ��� � �� �� ������ �� �������, �������������� ������ ����� ���������, � ������ �� ���������. ����� 15 ��� �� ���������� �� ����������. ������ ������ �� ��� �� ����������, ����� �� �������� ��-�����. ��� �� �� ����� �� ������������ �����, �� ������� ���������� ������� �� �����. �� �� �� ���������� ������� ������ � ��������. ��������� ��? ��� ������� ������������� ���� �� �� ������!\r\n���� �� �������, �������� ���������� �������� ��������� ��� � ���� �����:\r\n� ��������� �� �����, ���������! ������ �� ���� �����! ������ �� � �������. � �� ������������ �������� �� ��������! ��� � ���� ���� � ��� ����� ����� ����. �������� �� � � �������� �� �����������; ��� � � ��-����� ���, �� �������� �� ���������� �� ��.\r\n� ��� �� ��������� � ������� �� ������ � ���������� �� � �����������. � ��� �� ������ ���������� ���������� � �������. ��� �� �������� ���� ������������, ���������� �� ��������� �� �� ������� � ������ ��� ��������.\r\n� ����������, ���������! � ����� �������� ������ ���������. � ����� 30 ������ �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode11Chois1()
		{
			int currEpizodeId = 11;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ���� �� � ����������� ������ ����� ������� � ��������� ���� ��. ��������� �� ������������ �� �������, �� �� ������� �� ���� ��� � � ��������� �� ���� ������. �� ������� �� ���, ����� ��������ѓ �� ����� ���������� �� ���� ���� � � ���-�������� ��������.\r\n������������ �� � ���������� �������, ������ �� ��������� �� ��������� ����� �� �� �������� ����� ������ ����, ����� �� ������ � ��������� �� ������. ������ �������� � ������� �������������� ������������ �� �������� � ���������� �� �������� �� ��������.\r\n������ ������ ������ ����� �������� �� ����������, �� � ���� �� �������� � ���� �� ������������ �� ���������� �� �����, �� �������� �������. ������ � ���������� � �������� ����������� �� ������� ������. ���������� � ������� ������� � �� ������� �� ������� ��������� ����� �� � ����� � ������� ������, ���� ���������� ����������� �� �����.\r\n� ����� �� �� ������ �����! � ������ ������� �� ������������� �� ���������. �� ���� ������ ����� �� � ��������� �������� ��� �����������. ���� �� ������ ���� �� ������� ���������� ���� � �� �� ��������. �������� �� ��-������� ���� �� �������� ��, �������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode11Chois2()
		{
			int currEpizodeId = 11;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� ����� �������, �������� ��� ���� �� ��������������� ������, �� � �������� ������, ����� ��������� ����� ������, ����� �� ������� � ���� ������� ��� �� ������������. ����������� �������� �� ������� �� �� �������� ���� � ����� �����.\r\n������������ ���� �� ����� � �� ������ ���������, �������� �� ����� ������������� �������, ����, ������������ � ����� ��������. ��� ��������� �� ���� � �������� ����� ����� �� �� ������� ���� ������� ������������ ��� ������� ��������� �����. ��� �� �� ��� ����, ��������� �� �������, ������ ������� ���� � ������������ �� �������� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode12Chois1()
		{
			int currEpizodeId = 12;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2] - 2;
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� �� �������, �� �� �� ��������� ���-����� � ��������������, ������ �� �� ������ ����. ��� �� ������ ��� �������� ������ � ���������� �� ������������. �������� �� �� ������� ����� ������������, ���������� ��������� ������� ����� � ����� ����������� �� ����������, �� ���������� ���� ���������. ����������� � ���� �������� ���� � ���� ����� ������� � ������ � ������� � �����, �� ������� ����� �������� ����������� ����� �� ��� ����.\r\n���������� ���������� �� ���� �������� ��������� � ���� ������ ������ �����������, ����� ������ �� �����. �� ���������, ������ �� �� ������� ������ � �������� �� ���� �� ���. � �������, ������ ��� ������� ��������� ����� ��������� �� ������ ������, � ������ �� ������� ������� ������, ��������� �� ������ ������ ��������������, ������ �� ������� ������� ������. ������ �� ������� ��� ������, �� ��� �� �������� ������� �������������� �������.\r\n���������� ����� �� ������� �� �� �������� � ���� � ���������� ����� �� ��������� �� �� ���������, ���� �� ����� ������� � ���������. ����� ���������� ������� � ����������� �� �������� ������ ������� �����, � ����� ������������ � �� ������� ������ ����� �� ������������ ����� �� ������, � �������� �� ������� ������ � �������. ��� ��� � ���������� ������� ����� �� ������ �� � ������������ ����� �� ���������� � ������ ����� �� ��������� �������.\r\n���� ���� ���������� �������� �� ������� ������� � ����� ������ �� ����� �� ������� �� ����������� �� ������� �������� ��������� ��� ���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode12Chois2()
		{
			int currEpizodeId = 12;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2] - 2;
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� �� �������� ������ �������� � �������� �������, ������� �� �������� ������ ���� ����� ��������������� ������ �� �������. ���� � �� ������� �� ����� ������������ �������������. ��������� �� �� ����� �� �����, ������ ����.\r\n������ �� �������� �� �����������, �������� �� ����������, ���� ��-����� ���������� ������, ����� ���� ���� ������� �������� ������ �� �� ������ � ������� ��. � ����� ��������ѓ ����� �� ����� ��������, ������� ��� �� ���� �������� � ��������� � ��������� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode13Chois1()
		{
			int currEpizodeId = 13;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ���������� �� ������� � ����������� �������� ����, �� ����������� �� �������� ������ ��� �����. �������� �� ������ ����� � ������������ �������� � ���� ������� ������� ���� �� ���������, ������:\r\n� ��� �����, ����������� � �������� �� ��� �������! � � ���� �� ���������� ��� ���, �������: � ������ �� �������� ����� ������. ������ � �����, �� ������!\r\n� ���� ��� � ���� � �������� ��� �������. � �� ������� ������, ��� ����� �����!\r\n��� � ���� ����������. �� �� �������� �� � ������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode13Chois2()
		{
			int currEpizodeId = 13;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� �� ��, �� �� �� ������ ����? � ����� ��� �������� ������� �����.\r\n� �� �������! ����� ������? � ���� ���.\r\n������� �� ������� �� ������� � �����������, ���� ������� ������ �� ������� ����� � �������� �� ��������� � ������������ ��������.\r\n� �� ����� �� �������� �� �� ��������? � ����� �����������.\r\n� ���� ������� � �������� ��� � ������� �� �� ������� �� ������. � ���� ������ ���� �������.\r\n���� ������� �������� ������� ������� ���� ����� ����������� ������ � ���� �������� ����, ����� ����. ��������� �� ������ � ����������, ������� �������� �� ������� � ������ �� ����� ������� ��� ������ � ������ �� ����������:\r\n� �������� �� ������ �� ���������� � ��������! �������� �������� � ��������� �������! ����� ����� ������� �� �� ���������!\r\n� ����� ����� ����? � ������� ���� ��������� �� ��� ����������.\r\n���� ���� ������� �������� �� ������� ���������, ������� ������ �������� � ����� ����.\r\n� ���������� �� �� ������ �� ���������������! � ���������� ������ ���������. � ��������� ������� �� �� �������!\r\n���� ����� ������� ����� ������ �����, ������� ����� �������� ����� �������� � ����� ��� �������� ��������� ������� � ���������.\r\n� ������ �������! ��������� �������! � ���� ���������, �� ������ �� ������, �� ������ ���� ����� ������������� �� ������.\r\n� � �� ��� �� ����! � � �������� ��������� ���������� � ���� �� ������� �� ������.\r\n������� ���� ����� � ��� ��������������� ��������� �� ��������� ��������� �� ���������������. ������ � �������� � ����� ������� �����, ����� ����� �� ������� �� ������ ��. ������������ �������� �� ����������� � ���� ���������, �� ������ ���� ���������� ���������. ������ ������������ � ���� �� �������� ��������� �� �������� � �������, �� ����� ���� ���������� �� ������ �������. ������� �� �������� ������ � ������ �� ���� ���, ��������� �� ������������ �� ��������� � �������� ��������. �� ����� ���� ��������� ����� �� ������ ��� ���������� �����, ��� �������� �������� �������; �� ��� �� ������� ������ �������� ����. �� ����������� �� ���� ����������� ������, �������� � ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode14Chois1()
		{
			int currEpizodeId = 14;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��������� ���������� � ������ �� ������ ���� ������� ���������. � ���� ���� ��� �������. ����� �� ���������� ���������. ����� �� ����� ��������� ��� �������.\r\n����� ������, ��������� ��� ������ �������, �� �������� ��� ��������. ������� ��� ��� � ��������� � ���������� �� ���������. ����� ��� �� ������� �������� �� ���������� �� �������, ������ ���� ����� ������ ����� ����� ���� �� �� ������ ����� � ��������� �� ����������� ���� �������.\r\n� ������ � ����� � ����� � ����� ������ �� �������� ��������. � �������� � �����������\r\n�� ���������� ���� �� ��������� ������ ����� ������ �����, ����� �� ������� � ��������� ���� ������ ��� ����� �����. ������ �������� � ������� ����������� �� ������� � ����������� ���� � ���������� �� �������� ������ �� ��������.\r\n�������� �� ��������� � ����� �� ����� �� �� ������� ���� �� � ����� �� � �������. �������� �� ����� � ���� �� ������ �� ����� �� ������ ����, ������� �� ������ ��������� �� ������ ��.\r\n�� ������� ������ �� �������, ������� �� ���� ����� ��������� � ������������. ��������� � ������� �� �������� �� ����� ���������� � ����������� ����������. ������ �������� �� ������; ���������� ��, ����� �������� ���� �� ��������� � ���� ���������� ��� � ��������� � ������ � �����. ��������� �� ��������� �� ����������� �� ������ ����, � ��������� ����� ��� �������� ���� ���� ������������� ����� ������.\r\n��� ������� ����� �� ��������� ���� ���������� ������, �� ���������� ���������. ������ ��� ��������� �� ������� � �� ������ �� �� ������������ ��� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode15Chois1()
		{
			int currEpizodeId = 15;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ �������� ��� �����������. ����!\r\n���� �������� ������� ������ �� �������� ��. ������ ����� �� ����������� �� ����� �� ����������� � ����� ���������� ��������� ��������.\r\n� �������� � ����� � �������� ������������. � ��� ������� �� ��������� �� ���������.\r\n� ���������� � ������. �������� � �������������� �����. ��������� ���� ����� �������.\r\n�� ������ �� ������� ��������� �������� � ����������� ������ � �� ������ �� ����� ��� �� �� ���������. ����� �� �������� ���� �� ������ � ����������, �� �� ������� �� ������ �� �������� �� �������� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode15Chois2()
		{
			int currEpizodeId = 15;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������, �� �� ������ �����������! �������! � ����� ��������� ���������. ����� ���� �� �� �������, �� �� ������, ���� ������� ����������� �� ������.\r\n���� �������� ������� ������ �� �������� ��. ������ ����� �� ����������� �� ����� �� ����������� � ����� ���������� ��������� ��������.\r\n� �������� � ����� � �������� ������������. � ����������� � ���������.\r\n������ �������� �� �� ����������, ������, �� ���� � �������� ����. ���� ���������� ������ � ���� � ����� ����� �����. ����� ���� ����� �� ��������� � �������� � ����� ����� ���, ���������� �� ������ ������ �� �����������. ����������� ������ ���� ������� ���� ���� ������� �� ���������. ������� �� ��������� ���� ���, �� ������� �� ������ ��� ����� ������ �� ����������� �� ��.\r\n� ����� �������� ������� ������ � ������������� ���� �� ��������� �� ����� ��� ����������������. � ���� ���� ��� �������.\r\n� ���� ��� �� �� ������ � ������� �� ������ ������������. � ���� �� �� �������!\r\n� ���� � ������������? � ����� �����.\r\n� ��������� �� ��� �����������. ������� � ������ ��� ���. ��� �������, ���������!\r\n����� ������ �� ������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode15Chois3()
		{
			int currEpizodeId = 15;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ �������� ��� ���������. ����!\r\n���� �������� ������� ������ �� �������� ��. ������ ����� �� ����������� �� ����� �� ����������� � ����� ���������� ��������� ��������.\r\n� �������� � ����� � �������� ������������. � ������������ � ��� ��� � ����� ������� �� �����.\r\n� ���������� � ������, �������� � �������������� �����. ��������� ���� ��� ������� � ������ �� ��� ����������.\r\n� ������ ������� �� ��������� ������! ������� �� ����������! �������� �� �� �������� ��������� �� ���������! � �������� ���������� ��������� � ������� ��� ������, ���������� ���������� ���������. ����� �����!\r\n����������� ������ �� ������ � ���� ���� ��� ��������� � ���������� �� ������� ������ �����. �������� �� �������� ��� �������� � ����� �� ��� �������.\r\n� �������� � ����� � ��������� ������������ ���� �� ���������. � ��������� ����� � �������� ���������. �������\r\n��������� ���� ��������� ����� �� ��������. ������� ����� � ����� �� ������� ����, ����� �� �������� � ������ �� ������. ��� ��� ���� ������ �� ����������� � ���������� �� �������� ����� ����� ������ ����� �� ���������� ������. �������� ����� ���� ��� �� ������ � ���� �� ������ �� ������ �������, �������� ������������ ������, ����� �� ������� �� ����������� ������ � �� �������� �� �������� ���������.\r\n�� � ������ �������� ����� ��� ���������. ������� �� ������ �����������. �, ������ �� � ����� ��������ѓ �� �� ��������, ������� ��� ���������� � ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode16Chois1()
		{
			int currEpizodeId = 16;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode16Chois2()
		{
			int currEpizodeId = 16;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode16Chois3()
		{
			int currEpizodeId = 16;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������, ��������� � �������� ��-��������, ������� ������ ��������� � ������, �� �������� �� ������� ��� ��-�����. ��������� ����� �� ������� �� ���������� ���������. ���� ���� ���, �� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode17Chois1()
		{
			int currEpizodeId = 17;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus playerStatus = new PlayerStatus();
			playerStatus.Checksums[1] = 20;
			playerStatus.Checksums[2] = 10;
			playerStatus.Checksums[3] = 4;
			playerStatus.Checksums[4] = 20;
			playerStatus.Checksums[5] = 10;
			playerStatus.Checksums[6] = 10;
			playerStatus.Checksums[7] = 10;
			playerStatus.Checksums[8] = 10;
			playerStatus.Checksums[9] = 30;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� �� � ����� � ���������� ����� ������� ������� �� �������� ��������� �������� � �� ������������ ������� �� � ���� �� ��������. ������ ���������� �� ��������� ������� ����� ��� ��-�����, �� �� ���� �� �������� �� ������ ���� � ������� ����� �������� ��������. ��������� �� ���� � ������ � ���� �� ������ � ������ ����������� �� ������������ ������, �� ����� ��������.\r\n� �����, ���������, ���������� �������! � ����� ����� �� �����������. � ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode18Chois1()
		{
			int currEpizodeId = 18;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 20;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode19Chois1()
		{
			int currEpizodeId = 19;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ��� �������� ������ �� ����� �� ������� �������, �� ������� ������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode19Chois2()
		{
			int currEpizodeId = 19;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ��� �������� ������ �� ����� �� ������� �������, �� ������� ������:\r\n�������� �����. ������ ����������.\r\n��������: ����� ��� �� ����� ����, ����� ��������� ������� ���������� �� ������.\r\n�������� ����� �� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode19Chois3()
		{
			int currEpizodeId = 19;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� �����! ������ ����������.\r\n�������� 1: ����� ��� �� ����� ����, ����� ��������� ������� ���������� �� ������. �������� ����� �� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode20Chois1()
		{
			int currEpizodeId = 20;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������, �� ������������ ��������� � ��-����� �� ����������� ����������� � ��� ��������� �������� ����� �����������.\r\n� ��������� �������� ���� �������� ������. �������� ���������. ������� ����� � � ������� �� ����������!\r\n� � ����, ��������� � ������� �� ����� ��-����� ��� ������������� �� ����������. � ���������� ����� ������ ��� ������ � �� ������ ���������� �� �������������� ����. �������� �� ��� ��������� �����������. �� ��������� �� �����, ������ ����������. �������� � �� �������� ��������� �� ������ �� ������� � �� �������� �������� ������������. ����� ����� �� ������� � ������� �� �������������. �������� ������ �� �������� ���������!\r\n�������� ����� ������� ���������� ������� �������� �� ����������� ��� �������� ������������ ���������� �� �������. �� ��� ���� � ������� ����� �������� � �� ����� ���������; �� ���� ������ ������ �� ������ �������� � �� ������ ��������, �� �� ������ ��� ���� ��� ������� ����. �� ���, �������������� � ������� �� ������� � �������� �� ��������� ���. �������� �� �������� � ��������� � ���� �� ������� �� ���� � ����������������� ������. ������ ������� � �������� � ���������.\r\n� ������ � �����, ���! � ���������� �� �� ��� ���������.\r\n� ������� ����� � ������ �� �������������� ������.\r\n� �������, �� ������ ����� ���������. �� ���� �� ����� ����� �� �������, ���� �� �������� ������ �� �������� ��������� �� ���������.\r\n� ��� � �������� ������� �� ���������� ��������� � �������� ���������� �� ������. � ������ � ����������������� ������� ��� � ����� ������� �� ���������� ���������. �������� �����������.\r\n������� �������� ������ �������; ������ �������� ����� � �� ������ �� �� �������� � �������� � �� �������� ����������� ������.\r\n� ��� ������� �� ���������� ��������� � ���������� �������� ���������. � ����������� � � ������� �����.\r\n�������� ��� � ���� �� ��������, ����� ������������ �� ������.\r\n� ���������� ������� �� ���������� ���������. ����������� � � ������� �����.\r\n���� �������� �������� ������ � � �������� ������� ������� ������ �� ����������� ���������.\r\n� ���� �� �� ��������, ���������? � ���� ������� �����.\r\n� ����� ������������!\r\n���, �� ������� �������� ��� �������. ������ � ������������ �� ������� �� ��������, �� ��� �� ��������� �� ����� � ������ �� ����� ���� �� �������.\r\n� ��������� ������� �� ���������� ���������. ����������� ������ � ��������� �������� ����������. � �������� ���������.\r\n����� �� ������, ��� ���� ���� ������ �� ���������� �� ���������, � ������ �� ������ ���������� �� ������ �������� �������. ���� ����� �� ���� ����������, ������ ������ �� �� ��������� � ���� ��������� � �� �������� �� ����� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode20Chois2()
		{
			int currEpizodeId = 20;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� ����������� ������� � ������������ ���������� �� ����������� ��������� �� ������������ �� ������������� ���� �������. ���� � ���������, ����� ��� ���, �� ������ ������� ������������� �������� �� ���� �� ���-�������� ������������. ����������� �� ��������� ��� ������ �� �������� �������. ����� ����� �� ���� �� �� ������ ���� �����. ����� � ������ ��������� ������� ������� ������������, ����� ���������� � ������������� ��������� ������� ���������� ��������� �� ������������ ������� � ������� ������ ����� �� ������ � ���� ������������.\r\n��� ��� ��������� �� �� �� �������� ������������. ������ �� ���� �� ����� � �������� �� ��������� �������, ���� ���� �� ��������� ����������� �� � ����� ��� ������� �� ��������� � �� �������� �� ���������. ����� ������� ������ ��������� ������� �����������, �� ������ �������� �������� � ������, �� �� ������ �� �� ���������� � ��������. ����� ������, ��������� ��� ��� �� ���� �� ����� �������. ����� � ��� ���, ��������� ������� �� ������� �� ������ ���������. �������� ���� ���-�������� �� ����� � ������ �� �������� �����������. ���� ������������ �� �� ���� �� ����� ������� ��� �� �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode21Chois1()
		{
			int currEpizodeId = 21;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode22Chois1()
		{
			int currEpizodeId = 22;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = 5;
			//expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = 1;
			//expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode23Chois1()
		{
			int currEpizodeId = 23;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ �������� � ��� ���� � ���� �� ��������� ����������, ������� ����� ������-����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode23Chois2()
		{
			int currEpizodeId = 23;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode24Chois1()
		{
			int currEpizodeId = 24;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ����������! � ��������� ������. � �������� �� �� �������� ����������!\r\n� ������������ � ��� ���������. ��������� ������� �� ���� �� �����. �������. ����������� �� ���������� � ���������� � ����������� ������� ����������.\r\n� ������ ��! ������ ��! � ����� ����� ������������. � ������ ��! � � ������� ����: � ����� �����?� �������, ������� � ����������!\r\n� ������� �� ����������: ���� � ������� ���������. � ����������� �������� ��������� �� ���������.\r\n������� ��������� �� �������������� �������� �� ������ � ������� �� ��������� � �������� �� �� �����. ��� ������� ���� ������� �� ������ �� ������� ���������� ����� � �� �� �������, ������ ��������� ������� � ���������� ��������� �� �������� � ������������ ����� ������, ����� �� �������� ����� ����� ���������.\r\n����� ����� ����� ������ ����� ������. ������� ��������� ����� �� ������ ������ � �� ������ � ������� �������� ����.\r\n��������� �� ��������� ���������� �� ���� ����� ������ �����, ����� �������� ���������� �������. ������ ������ ����� �� ������ ��� ������� ��, �� ����� �� �������� ��� ������, �� �� ������� ���������� ������.\r\n�������� �� �������� � ������ �� ���� � �� ������� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode24Chois2()
		{
			int currEpizodeId = 24;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������! ������ �� �� �������� � ���������! � ����� �� �������� �����. � ��-�����!\r\n� ���������� ��� ���, ��������� ������� �� ���� �� �����. ����������.\r\n� �������� �� �� �������� ������!\r\n� ���������, ������� ��! � ���� �������� �������. � ������� �� �!\r\n�������� �� ���������� ��������� ���� ������, ������\r\n� ������ �����, ����� �� ���� �� �����. ���� ���� ����� ������� � ��������� �� ������ �� �������� ��������. ������������ �� �� � ���������, � ������ � ��������� ������ � ����� �������, �������� �� ���������� ��������� ����.\r\n� ������ ������� �� ��������� ������! �����, ���� ���?\r\n� ��� ���������, �� ����� ��� ��������� �� ���������. ��������.\r\n� ������ �����, �� ���� �� �����. ����� �������. ���� ���� ����� �������.\r\n� ����������, ��������� ����! ������ �� �� �������!\r\n� ���������, �� ���� �� �� ����! ��������� �����!\r\n����� ����� ���� ����, ���������� ������� �������:\r\n� ������� �� ���������� ����. ������ �����, �� ���� �� �����. ���� ���� ��� �������.\r\n� ������� �� ����������! ��������! ��������� �������� ��������� �� ���������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode25Chois1()
		{
			int currEpizodeId = 25;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ������ �� �� ��������, ������ �������� � � ���� ������ ��� ������ ���� �� ���������.\r\n� ����� �� �� �������! � ������� ������ �� ������ ��. � ���� ������ �� �� ���������� � ���� ����� ��������������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode25Chois2()
		{
			int currEpizodeId = 25;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� ������� ��������� �� �� �� ������ � ���� ������� ���������� �������� ��, ������ ���������:\r\n� ��� ��� ��������! ������ � ���! � � ����� ���� ������� �� ������ ��: � ������� ��������, �� ������ ������! � ������� �� �������� �� �������� ��-����� �����, � �� ������ ��.\r\n� �� �� �������! �� �� �����! � � ������ ��������� ���� �� �������. � �������� ��������, �� ��� ������ �� ������ ����������� ���� �� ���������. ���� �������� � ����� ���������� ������ �� �������� ��� ���. ����� �� ������������ �� ��� ������ ��������� �������� �� �� ������ ������� ������, �� �� �������� � ���� �������� � ����, ����� �� ������� ����.\r\n� �� ��� �� ����� � ���� ������� �� ����� ��. � �� ��� �������! ��� ��� � � ���� �������� � ���� ��������, ����� �� ������ �� �� �������� ������.\r\n������ ���� ���� ��������� ����� �� ������� ������� � �� ���� ���������� �������.\r\n� ��� ���? � ���� ���� ��-���������� ������� ��. � ��� ����� ������ � ������� ���. ���� �����?\r\n� ����� � ��������? � �����, ���� �� ������� �� �������� ����� ��.\r\n� ���� � ������ � ������� ������� ��������� �������. � ���� �������? ����� ����? ��? ��� �� ���� ���� ������! � ������ ������ ���.\r\n� �� �� ������ ������ ���� � ��������� �� ���� ��������. � ������ �� ����� �� ���� ����� � ���� ���� ���.\r\n� �� ���� ��� �����! � ����� ��� ���������. � ����?\r\n� �� �� �� �������! � ���� �������� �� �� ������� � ��. � ��� �� ������, ��� �� ����� ������ �� � ������ �� �������� ������������ ����.\r\n� �� ����� �� ����� � ������� ���� ������ ��������� �������� �����. � ��� ���� ��� � ���� ���������� ���������� � ������� ��� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode26Chois1()
		{
			int currEpizodeId = 26;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode27Chois1()
		{
			int currEpizodeId = 27;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode28Chois1()
		{
			int currEpizodeId = 28;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� ���� ����� ������ � ������ � ������ �� �� �������� �� ������ ������� ����� ������� ������ ���� ���������. ����� �������� ���������� ���� �� �� ��� ��� �����. �������� �� �� ������ ��� ���� ������ ������� � ��� �� ��������.\r\n�������������� ���� ���� �� ���� �� �������, �� ����������������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode29Chois1()
		{
			int currEpizodeId = 29;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������ ������� �� �������� � �� ������ ����������������. ����������� �� ��� ������ ������������ ����������, ���� �� ����� ������� ����������� ����������, ����� �� �� ����� �� ����������� � ��� �� ������ � �� ���.\r\n� ����, ��������� ����� � ����������� ������ ���� ��������� �� �����. ��� ���� ������� ������� ���� �� ��������, �� ���� �� ������� �� �� ���������� �� ����� ��� �������� ������������� ����. ����� ���������� ������� � ������� ��������, ������ �� ���� � ���� ����������� ������� �����, ����� ����������� ������ � ��������� ������ ���������� �� ���� ����� ���� �� ���������� �� ���������.\r\n��� ��� ������ � ������������ �� ������� �� ����������� ����������� � � ���� �� ������ ��� ���������� ���� �� ������� ��������� �� ����������� ���. ��������� � � ����� ��������� �����������. ������ ��, �� ���������������� �� � � ��������� �� �� ����� ������� � ���. �������� ���, ������ ���� �� �� �������� �����, �������� � �������� �� �������� ����� ���������� ������.\r\n���� �� ��������� � �������� ������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode29Chois2()
		{
			int currEpizodeId = 29;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� ��������� �� ���������� � ������� �� ��������� ���� �� ������������ �� �������.\r\n����� �� ������ �� ���� �� ������� ���� ��������� 35 ��.\r\n������� �� �������� �� ���� �������� � 12 ��, ��� �� ������ ��������� �������ғ, � 6 �� �� ������������� �������ғ.\r\n����� �� ������� �� � ������� � ������������ ����� ��������, �������� ���� � ���������������, ����� ������������� ����� �� 10 ���, ����� �������, ����� � ������������ ���������� � ������� � ������ � ���� ����� 10 ��.\r\n����� �� ������� ��������, ����� �� ������������ �� ����������� �� ������ ��.\r\n� ����, ����������� ���� ��� ������������ �����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode30Chois1()
		{
			int currEpizodeId = 30;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� � ��� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� �� ���� � ���� �������� ��-������� � ������. ������� �� ���� � ��, �������� ������ �� ������� ��������� � �� �� �������� �� ����������� �� ���.\r\n� ���� ����� � ���������, ��������� � ����� ����� �� �����������. � ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode30Chois2()
		{
			int currEpizodeId = 30;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� � ��� ���� � ����� � ���������� ������ �����, �� �� ���������� ������. ������� ��� ���������, �� �������� �� ���� ������� ��������, ��������� �������, ����� �����, �� �� ������. ������ �� �������� � ������ �� �������� �� ������, ����� ����� �� ����������� �� �������������� ������.\r\n� ���� ����� � ���������, ���������. ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode30Chois3()
		{
			int currEpizodeId = 30;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� � ��� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� � � ������� �� ������� ���������. ��������� �������� ���� ����� �� ����� � �������, ��� �� ������� �� ������. ���������� �� ������� � �������� �� ���� ������� ��������, ��������� �������, ����� �����, �� �� ������. ������ �� �������� � ������ �� �������� �� ������, ����� ����� �� ����������� �� �������������� ������.\r\n� ���� ����� � ���������, ���������. ���� �� ������������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode31Chois1()
		{
			int currEpizodeId = 31;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������ ������� ����������! � ��������� ���������. � ������ �� �������� �����!\r\n���� �� ������� ������� ����� ����� ���������� �� ����� ��������. � ������� �� ���������� ��������� ����� �� ��������������, ������� � ���������������� �� �����������, ���� �� ������ � ������, �������������� � ���� �� ��������� �������.\r\n� ��������� ������� ������������ ��������� � ������� ����������. � ����������� ������ �� �����. �������� ���������.\r\n� �������� �� � ������ �� ���������� ��. ���������� �������!\r\n� �������� ������� ������������ ���������. ������� � �����������.\r\n� ��������� ���! ���������, � ����� �������. �������� ������. ���� ���� �������� �������!\r\n� ��������� ������ �� �������� ��?\r\n� ���� ����� �� ���� �� ��������. ��������� �����������.\r\n� ����������� ������� ������������ ���������. ����������� ���������.\r\n� �������� ������� ������! ���������� ������! ����!\r\n����������� ������ ������ �� ������� ���� ������ ��. ������� �� �������� �������� � ��� �����, �� ��������� ����� �������.\r\n� ����� � ��������, ���������! � �������� ���� ����������� �������� ������������, ���� ������� �� �������� �������.\r\n� ���� �� �������������� ��������� � �������� ����������. � �������� ��������. �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode31Chois2()
		{
			int currEpizodeId = 31;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��������� ����������. ������������ �������� ������� � �� �� �������� ������� � ��������� � ��� �� �������� ��� ���� �� ��������.\r\n� ������ �� ��� ���������. ������ ���������� �������� ������� � � ���� ���������� �������� ������ �� ������, ����������: � ������ �� �� �� ������ � ����� �����!\r\n� �������� ������� �� ���������� ���������. �������� � �����������. ��������� � ������� �� ��������. �������� �������� �������.\r\n�������� �� ������ � �������� ���. ���� � ����� �� �������. ���� ���� �� �� ��������� ��� ����������.\r\n� ���� �� �������������� ��������� � ��������� ����������. � �������� ��������. �����!\r\n����� ������ �� �������� ��� �������� � �� ����������� ���� ����� �� �� ������ ����� ������. ���� ���� ����� ����� ����������� �� �������� �� ����������� �� ������. ������ ���������� ���� ������� ����, ��� ��� ��������� � � ����� ���� � ����� ������� ������������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode31Chois3()
		{
			int currEpizodeId = 31;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� �����������! � ������� ������� ��. � ��������� ���������� �������� � ������ �� ���������.\r\n� ����������� �� ���� � �������� ������� ����������. � �������������� ��������� � ��������. ����� ���������� �� ���������!\r\n� ������ ��������� ������ � �������������� ����! � �������� �� ������ ����� �����, ����� �������� ��-������ � �������� � ��-����.\r\n� ���� �� �� �� ������, ������ �������� ��� ���? � ���� ��� �������� � ����� ������������.\r\n� � ���� ������? � ��������� ��. � �������� ��, � � ��� �� �������� ��������.\r\n� ������������ �� �������� �������� � �������� ����������. � �������� ���������. �������� ������� �� ������.\r\n������ �� ������� ����� � ������ ������ � �������� ���. ���� �� �� ���� �������� �������!\r\n� ���� �� �����������. �������� ���������� ��������.\r\n� ���� �������� �� �������� ���� ������� ����� ����� �������� ����. ��������� �� ������ ��������, ������ ������������ ��������� ��� ��������� � ��������� �������� ��������. � ������ ��� ��������� �� ������ � �����������, ����� ����� ����� � �������� ��������� �� ������� � ��������� ������� ����������� �� ��������. ���� ������� ������� ������� �� ����������� � ������������� ���� �� �������� �������:\r\n� ������� ��������� � �����������. ������ ������� ������� ��������. ��������� ���������� ������. ���������� � ����� �� ���������� �����. ���� ���������� �� �����.\r\n� ������ ������� � ������������ ������� �� ����� �������! � �������� ������� �� ��������.\r\n� �������� �� ������� ��! � ������ �����, ������ ����������� ��� ����� ��. � � ��-����! � �������� � �� ��� ��������� ���������.\r\n���� � �������� ���� �������, ��������� �� ������ ����� ��� ��������� ������ �� ��������� � ���� ���� � ������ ����� �� ����� ����������, ���� �� ��� ��������� �� ����.\r\n���� ����� �������� ������ ��� �� ������������. ��������� � ������� �������� �� ����� �������� �� ����������� ������ ����. ��������� �������� � ��������� ������������ �� ������ ����� � ���� ������ �� �� ������� ���� ��������, ��������� ������ ����. �������� ����� �������� ���� ������, �������� �� ����� �����. ����� ������� � �������, ����� �� �������� �� ���������� � ����� ���������� ��������. ������ � ������ � ����� ��������� � ��������� ������� ����� �����. ��� ��������� ���� ��� ������, ���� ����� �� ������ ������ �����. ���������� ���� ������� �������� ����, �������� �� ����������� ������ �� ������ ����.\r\n� ����, ������� ���� �� �������� � ��������� �������. �������� �� �� ����������� � ���� ���� 15 ��� �� ���������� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode32Chois1()
		{
			int currEpizodeId = 32;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��, ��������� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� �� ���� � ������� � ��� ���� ���� ������������ ������� ��������.\r\n� ����� ������ �� �������� �� ����� ���, �������� ��������� �� �����������. ��������� �� ���� � ������ � ���� �� ������ � ������ ����������� �� ������������ ������, �� ����� ��������. ������ �� �������� ��, ����������� � ����������� �������� �������.\r\n� ���� �� ���� �����, ��������� � ����� ����� �� �����������. � ����� �� ��� �����������. ����� ����� �� ����� �� ������ �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode32Chois2()
		{
			int currEpizodeId = 32;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��, ��������� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� �� ���� � ������� � ��� ���� ���� ������������ ������� ��������. ��������� �� ���� � ������ � ���� �� ������ � ������ ����������� �� ������������ ������, �� ����� ��������. �������� �� ������������� �� ���������� � ����������� �������� �������.\r\n� ���� �� ���� �����, ��������� � ����� ����� �� �����������. � ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode32Chois3()
		{
			int currEpizodeId = 32;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��, ��������� ���� � ��������� ��� � ���������� �������� �����, �� �� ���������� ������. ��������� ����� �� ������� �� ���������� ���������. ������� � ���� �����, ������� ������ ���������, �������� �� �� ���� � ���� �������� ��-������� � ������. ������� �� ���� � ��, �������� ������ �� ������� ��������� � �� �� �������� �� ����������� �� ���.\r\n� ���� ����� � ���������, ��������� � ����� ����� �� �����������. � ����� �� ��� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode33Chois1()
		{
			int currEpizodeId = 33;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ �������� ��� ���������! ����! � ������ ��.\r\n����������� ������ �� ������ � ���� ���� ��� ��������� � ���������� �� ����� ������ �����. �������� �� �������� ��� �������� � ����� �� ��� �������.\r\n� �������� � ����� � ��������� ������������ ���� �� ���������. � ��������� ����� � �������� ���������. �������\r\n��������� ���� ��������� ����� �� ���������. ������� ����� � ����� �� ������� ����, ����� �� �������� � ������ �� ������. ��� ��� ���� ������ �� ����������� � ���������� �� �������� ����� ����� ������ ����� �� ���������� ������. �������� ����� ���� ��� �� ������ � ���� �� ������ �� ������ �������, �������� ������������ ������, ����� �� ������� �� ����������� ������ � �� �������� �� �������� ���������.\r\n�� � ������ �������� ����� ��� ���������. ������� �� ������ �����������.\r\n�, ������ �� � ����� ��������ѓ �� �� ��������, ������� ��� ���������� � ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode33Chois2()
		{
			int currEpizodeId = 33;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��������, ���� �� ��������! � �����, ���� �� ������� �� ������� �����������. � � ����� ������\r\n� �������� ������� � ����� � ���� ������������ � ������� ���������, ����� ���������� ������ ��������, �� ��������� ������ �� ���������.\r\n� ������� ��������, ���������! � ������� ����� ������� �����.\r\n� ������� ����������� � ������� ��� �������! ��������, ������ �� �������� ��������� �� ���������! �����, ������ �� ��� ������!\r\n� �������� � ������� � ������ �� ����������. � ���������� �� ����� � ����� �������. ���� ���� ����� �������.\r\n� ��������� �� � ��� ������ �� ���������! ��������, ����!\r\n� �� �����, ��������� � ����� ���� ������� ���������� ������� ������������. � �������� � � ������������� ������. ���� ���� �� � ������ ����.\r\n� ������ ������� �� ��������� ������! �����, ���� ���?\r\n� ��� ���������, �� ����� ��� ��������� �� ���������. ��������.\r\n� ������ �����, �� ���� �� �����. ����� �������. ���� ���� ����� �������.\r\n� ���������, �� ���� �� � �������� ������! ��������� �����!\r\n����� ����� ���� ����, ���������� ������� �������:\r\n� ������� �� ����������: ����. ������ �����, �� ���� �� �����. ���� ���� ��� �������.\r\n� ������� �� ����������! ��������! ��������� �������� ��������� �� ���������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode34Chois1()
		{
			int currEpizodeId = 34;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���������� �� �������� ��� ������������ �� �������, ��� ������ ������ �������� � �� ������ � ���������� ������. �� �������� �������� ���� �� � �� ���� ������.\r\n��� ������ ������ ��������, �� ����������� �� ������� ������ �� ������� ����� ��������� ���������� � ���� ������ �����������, ������ � ������������ ������ ����� �� ������� �������, ����������� � � ���� ������� �����. �������, ��� �� ����� �������, ����������� �������� � ���� �� ������ ������ ����������� � ���, ������� �����������, �� ��������� ������ � ����� ��������� �� ������� �� �������.\r\n�� ��������, ����� ����������� ������ � ���� �� �����������. �� ���-����� � �������� �� �������� �� ����� ������ � ����������� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode34Chois2()
		{
			int currEpizodeId = 34;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���������� �� �������� ��� ������������ �� �������, ������� ������ �������� � �� ������� � ���������� ������. �� ��������, �������� ���� �� � �� ���� ������.\r\n��� ������ ������� ��������, �� ����������� �� ������� ������ �� ������� ����� ��������� ����������. ���� ������ �����������, ������ � ������������ �� ������ ����� �� ������� �������, ����� �� ��������� � ���� ������� ����� � ����� ������ ���� �� ������� ��. ��� ����� ���� ������ �������� ���� �� �����������, �� ���� �������, ���� � ������ ���� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode35Chois1()
		{
			int currEpizodeId = 35;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode36Chois1()
		{
			int currEpizodeId = 36;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �� ���������� �� ������������ �� �������� � � ���� ���� ������� �� ������� �� ������. � ������� ��� �������� �� �������� ������, ����� ��� ���� ��������� �� ����������, ����� �� �� ���������.\r\n� ��������� ���, ���! � ���� ����������� ������� �������. � �� �� ������, �� ����������� �� ������ �������.\r\n� ��������, �������� ������! � ��������� ������ � �� ��������, ���� ��� �� �� �����. � ��������� ��� ��� ������� ����������������� � ��� ����� ������ �� �������� �� ������ � ������� ��������� �� ���������������� �� ��������! ����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode36Chois2()
		{
			int currEpizodeId = 36;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� ������� ��������� �� �� �� ����� � ���� ������� ���������� ��������, �� ������ ���������:\r\n� ��� ��� ��������! ������ � ���! � � ����� ���� ������� �� ������ ��: � ������� ��������, �� ������ ������! � ������� �� �������� �� �������� ��-����� �����, � �� ������ ��.\r\n� �� �� �������! �� �� �����! � � ������ ��������� �������. � �������� ��������, �� ��� ������ �� ������ ����������� ���� �� ���������. ���� �������� � ����������� �� ������ � ������� ��� ���. ����� �� ����������� �� ��� ������ �������� �������� �� �� ������ ������� ������, �� �� �������� � ���� �������� � ����, ����� �� ������� ����.\r\n� �� ��� �� ����� � ���� ������� �� ����� ��. � �� ��� �������! ��� ��� � � ���� �������� � ���� ��������, ����� �� ������ �� �� �������� ������.\r\n������ ���� ���� ��������� ����� �� ������� ������� � �� ���� ���������� ��-�����. ����� �� �������� ����������� �� ����� ������ �����. ���� ����� ��������� � ������� ������� �� ������� ������� �� �� �������� � �� �� ������� � ������ ��. ���� ������������� ����������� �� ��������� ���-����� ������ �� �������� �� �������� ��� ����������� ������ �� ������������, ����� ���� ����� ��������� � ������� ��.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode37Chois1()
		{
			int currEpizodeId = 37;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� �����!\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode37Chois2()
		{
			int currEpizodeId = 37;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� 2: ������� �� �����������. ������� ������ �� ������: ���� �� ��?� ������� ��� �� ������ �� ����� �� ���� ��������. ������ ������� �� ������: ���� ����, �� � ��������.�\r\n�������: ���������� ������ ����, � ���������� ����� ��������.\r\n���������� �� � ����, �� �� �� �����������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode37Chois3()
		{
			int currEpizodeId = 37;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� 2: ������� �� ���������� ��������� ��������� ��� ������ �� �����, ����� �������� � ����� ��.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode38Chois1()
		{
			int currEpizodeId = 38;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� ���� ����� ������ � ������ � ������ �� �� �������� �� ������ ������� ����� ������� ������ ���� ���������. ����� �������� ���������� ���� �� �� ��� ��� �����. �������� �� �� ������ ��� ���� ������ ������� � ��� �� ��������.\r\n�������������� ���� ���� �� ���� �� �������, �� ����������������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode39Chois1()
		{
			int currEpizodeId = 39;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������������� ������ ���� ����������, �������� �� ����� ����������� ���� ������� �� ���� ������� ���������� ������� �� �� ��������� � ��������� ������������� ��. �������� ��� �� ������ �� �������� � ����� ����������� �� ������������ ����� ��������� ��������� �������. ������ �� �� ������ � �����, � �����, ��������� ��������� �����. ������� �� �� �����, � ����� ������ ������� � �������� � ���� ������. ���������, ������ ������ �� ��� ��-������� �� ���� ���� �� �������� �������� � ��-����� ����. ���-������� ��������� ����� ������� ��, ������������ � ��� ����� �������� ����� ��� � ��� ������ ��������� ���, ����������� ����, �� ����� �� ������ ����� �� ������ ������, ��� �� �� �������. ������ �� � �����, �������� �����. ����� � ����� �����������, ������ �� ����� �������� � ��� ���� �����, ��������� �� � ����. ����� �� ������, ����� � ����� ��������. ������ �������� �������� �� �������, ��������� ��������� ����, �� ����� �� ������, ������� ������������ �� ��������� �� ����, ������ � ����� � ��������� �������.\r\n��, ������� ��, �� ����� �� � ����, ����� �������� ���������� ��; ����������� � ����� � � ����� ��-������� ��������. ���-����� �� ������� �� �������� ��. �� ���� ������ �������� �� ���������� ���������� ��������, �� ������ � ��������� ��� �������� �� ���������� �� ������ �� ����� ��������������� ���������. ������ ������ �� ���� � ������, � �������� � ��� ����� ������������� �������. �������� ���� �� �������� � ����������� �����, �� � ������������ ����������� �� �������������� ������ �� ��������� ��� ������ ���, ������ ������� ������� ���� � ��� �������� ������ ������� ���� � ��������� � ������ ������ ������ �������.\r\n���-������������ ����� �, �� ������� ������ �����, �������� � ������ ����������, �� ������ ���� �������� ������� �� ������� �� ���������. ������� ������ ��� �� ������ �� �� ������� �������� ������� ����. �����, �� ��-����� ��������� ������������� � ��� ������� �� ������� ������� �� �������� � ������� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode40Chois1()
		{
			int currEpizodeId = 40;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode41Chois1()
		{
			int currEpizodeId = 41;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode42Chois1()
		{
			int currEpizodeId = 42;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ��, ����� �� � �����������, ��������� �� ������ �� ���� � ������ ��. �������� �� �� ������� ����� ������������, ���������� ��������� ������� ����� � ����� ����������� �� ����������, �� ���������� ���� ���������. ����������� � ���� �������� ���� � ���� ����� ������� � ������ � ������� � �����, �� ������� ����� �������� ����������� ����� �� ��� ����. � �������� ��������� � ����������� ���� �������� ������ �� �������� �������� ���������� �� �������.\r\n��������� �� �������, ����� ��������� �� ���, � ������ �� ������� � ����������� ����� �� ������������ ��������� � ����� ����� ���������� � ������ ����, � ���� ���� � ����� ��� ��-������� ��������� � �������� �� ������. ���� ������� ��������� ������� � �������� � ��������� ������. ��������� �� ������� �� ��������� � �� ���������� � ������� �������, ������� �� ������ ���������� ���� �� �����. ��������� ����� �� ������ �� ������� �� �������, ����� �������� �� �������, ���� ���� ������������ �������� ��������� �� �� ����������� � �� �� �� ���������� � �������� �� ����������� �������������, ���������������� � ������ ��-����� ���������.\r\n������ �� ���� ����� ���� � ���������� ����� � ����������� ������������, ����� ������ ������� ���� � ���������. ������� �� ������ �������� ��������� � ������ �������� ����� � �����������, ������������� �� ������� ������ ����, � ���������� � ����� �������� ���������� ��������������� � �������� ������.\r\n����� ������� ������ �� ��������� ��������� ��������� � ����������� � ���� �������������� � ���������� ��������������� ��������, �������� ��� �� ������ ������, ����� ����������� �� ������� ���� ����.\r\n��������� � ����� � �����, �� ���� ��������� ��� �������� ��, ���� �� ��������, ������������ �� ��������� ������� �� ������� � ��������� ����� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode43Chois1()
		{
			int currEpizodeId = 43;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ���������� �� ����������� ���������� ������� � � ���� ������ �� ���� �� ��������� ��������� ������ ������ �� ������� �������. �������������� ������� �� ����������� ������� � ���������� �� ������� �������. ���� ������ ��������� ���������� �� ������������� ������ �� �� ��������� � ������� �� �� ��������� ������� ����� ������ �� ��������������� ���.\r\n���������� �������� �������� ������� � ��� ������������ ������ � ����� ������� �� �������� ��� �������� ��. ����� ������� ������� ��� ���������� ��������� � ��� �� �������, �� ��������� �� �������� ��� ��������� ��� ���������.\r\n�� ���������, ������� �� ������ �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode43Chois2()
		{
			int currEpizodeId = 43;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ���������� �� ����������� ���������� ������� � �� ������ �� ���� �� ��������� ��������� ������ ������ �� ������� �������. �������������� ������� ����� �� ����������� ������� � ���������� �� ������� �������. �� ��� ������, � ����� ������ ������������ � �������� ������� �� �� ������ � ������� �� �������. ����� �� ������ �������� �� ������� ������ � ���� ���������� ������� �� ����, ������������� �� ���������.\r\n���� ������ ���������� �� ������� �� ������� ����������. ���� ���� ������� ��� ������� ����, ����������� �� ������ � �� ������� � ������ ��.\r\n�������������� ����� �� �������� �� ������� � ���� ���������� �� ������� ���������� �������� ��, ������ �� ��������� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode43Chois3()
		{
			int currEpizodeId = 43;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ���������� �� ����������� ���������� ������� � � ���� ������ �� ���� �� ��������� ��������� ������ ������ �� ������� �������. �������������� ������� �� ����������� ������� � ���������� �� ������� �������. ���� ������ �������� ���������� �� ������������� ������ �� �� ��������� � ������� �� �� ��������� ������� ����� ������ �� ��������������� ���.\r\n���������� �������� �������� ������� � ��� ������������ ������ � ����� ������� �� �������� ��� �������� ��. ����� ������� ������� ��� ���������� ��������� � ���� ������ � �� ���� ������, ������ � ����� ������� ����� �� �����. �� ���������� �� ����������� ����������� �� �� �������� ���� �� ���� �� ������� ����.\r\n� ����� � ����? � ������� �������� �� ���� �� ���������.\r\n� ������� ������� � ��� ��������� ������ ����������.\r\n� ����� �� �� ��������� ���. �����, ���� � �� ��������� ��� ��!\r\n���� ������ ���������� �� ������� �� ������� ����������. ���� ���� ������� ��� ������� ����, ����������� �� ������ � �� ������� � ������ ��.\r\n� � ���� �����\r\n� ���������, ������ ��! � ��������� �� ���� �� �����������. � ���� ����� �����.\r\n� ���� ����, ��� ���� ����������� � ������ �������� ��. � ��� �� �� �� ���, ����� �� ������� �� ����.\r\n�������������� ����� �� �������� �� ������� � ���� ���������� �� ������� ���������� �������� ��, ������ �� ��������� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode44Chois1()
		{
			int currEpizodeId = 44;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode45Chois1()
		{
			int currEpizodeId = 45;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode46Chois1()
		{
			int currEpizodeId = 46;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode47Chois1()
		{
			int currEpizodeId = 47;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 20;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode48Chois1()
		{
			int currEpizodeId = 48;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� �����!\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode48Chois2()
		{
			int currEpizodeId = 48;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� 2: ������� �� �����������. ������� ������ �� ������: ���� �� ��?� ������� ��� �� ������ �� ����� �� ���� ��������. ������ ������� �� ������: ���� ����, �� � ��������.�\r\n�������: ���������� ������ ����, � ���������� ����� ��������.\r\n���������� �� � ����, �� �� �� �����������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode48Chois3()
		{
			int currEpizodeId = 48;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� 2: ������� �� ���������� ��������� ��������� ��� ������ �� �����, ����� �������� � ����� ��.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode49Chois1()
		{
			int currEpizodeId = 49;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 10;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode50Chois1()
		{
			int currEpizodeId = 50;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ��� ������� �� �������� � �� ������ ��� ������������, ����� ���� ��������, ������ �������� ������ ��� ��������� � � ���������� ������� �� ���������� ������. ������ � �� �� ���� �� ������������� ��������� �����.\r\n�������� ������ ��� ������� ��������� � ������� ������������ �� ����������� �� ����� �������� � �������� �������������� � ���� �� ���� � ������ � �����, ����� ������������ ��������� ������������ ��.\r\n������ ������� �������� �� ������ ������� �������� � ������� ����������� ����� ������� �� �� ����� ������, �� ������ �� ������ ����� �������. ���� ����� ������������ ���������� � ������� � �� � � ��������� �� ��������� �����������.\r\n������ �� ������� ����� ��� �����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode50Chois2()
		{
			int currEpizodeId = 50;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� ��������� �� ���������� � ������� �� ��������� ���� �� ������������ �� �������.\r\n����� �� ������ �� ���� �� ������� ���� ��������� 35 ��.\r\n������� �� �������� �� ���� �������� � 12 ��, ��� �� ������ ��������� �������ғ, � 6 �� �� ������������� �������ғ.\r\n����� �� ������� �� � ������� � ������������ ����� ��������, �������� ���� � ���������������, ����� ������������� ����� �� 10 ���, ����� �������, ����� � ������������ ���������� � ������� � ������ � ���� ����� 10 ��.\r\n����� �� ������� ��������, ����� �� ������������ �� ����������� �� ������ ��.\r\n� ����, ����������� ���� ��� ������������ �����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode51Chois1()
		{
			int currEpizodeId = 51;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ��� �� ��������� �, ���� ������, ������� � ����� ����������� �� ������������ ����� ��������� ��������� �������. ������ �� �� ������ � �����, � ����� ��������� ��������� �����. ������� �� �����, � ����� ������ ������� � �������� � ���� ������. ���������, ������ ������ �� ��� ��-������� �� ���� ���� �� �������� �������� � ��-����� ����. ���-������� ��������� ����� ������� ��, ������������ � ��� ����� �������� ����� ��� � ��� ������ ��������� ���, ����������� ����, �� ����� �� ������ ����� �� ������ ������, ��� �� �� �������. ������ �� � ����� �������� �����, ����� � ����� �����������, ������ �� ����� �������� � ��� ���� �����, ��������� �� � ����, ����� �� ������, ����� � ����� ��������. ������ �������� �������� �� �������, ��������� ��������� ����, �� ����� �� ������, ������� ������������ �� ��������� �� ����, ������ � ����� � ��������� �������.\r\n������ ����������� �������� ��, �� ������ � ����������� ����������� �� ��������. ������� �� ���������� ��������, �� �� ������� ��������� ��������������, ����������� ��� ����� �������� ���� �������� � ������ ����������� � ������������ ����� ���������. �������������� ����� �� ������ ������� �����, �� ���� ���� ��������� �� ����� ���� �� �� ����� �����������. �� ������ �� ������� ���� �� � ���������. ���������� ������������ ���� �� ������������ � ������� ������, �� ��������� �� ���������� �� �� ��������� � �� ������� ��������.\r\n� ������������ � ������ ���� ������� ������. � ����� ���� �� ����� �� ����� ������. � ���������� ���������� �� ������!\r\n������ ���������� ����, �� ����������� �� ��������� ��������� ��� ������, ������� � ������� ����, ����� �� ������� ����� � ���������� ����� ��� ���������. ������������ �� ������� � � ������ �������� � ������� ������ ������. ����� ������� �� ����������� ����� ������� �� ������ � ������� ��������� � ������� ������. � ������� ����� ��� �� �������� ����� ���������� ����� � ������� ��������� ������ �������� ��������� �� ���������. ��� ��� � ��� ������ ������� ����������� �� ���������� � ���������� ��������� ��� � ���� ������� ����� �����, �������� �� ��������. ���� ��� � �� �� ������� ����� �� ������ ��.\r\n����������� ��� ������� �������� ��������, ������ ����� ���� �� ������� ������ ������, ���������� ����� ���, ����� �� � ������������ �����. �� ����� ����� �� ���� ���������� ����, ���� �� �� ������ �� ������ ���� ����� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode52Chois1()
		{
			int currEpizodeId = 52;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ �� ������� ����������� ������ �� ���� �� ������� ����� �� ������� � ����� ������� �� ���� � �����. ������ � ������� ������ � � ������������� ������������ �������, ����������� �� � ������ ����� ����� �������� ��������� ������ �����. ����� � � �� ������� � ������� ��������� �� �������. ��, ������ � ���� ��-����� ����� �������, �������� �� ��������, �� �� ��������� �����������, �� ������ �� �������� �� �����������. ��� �� �� ������� �� ��������� �������� ������ ������� ��� �����. � ������, ���������� �����, ������������ � ���� �� ������ �� ������� �� ���������� �� ��������� ���� ��������.\r\n���� ����� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������� ��� ����� ��� ������, �� ��� �� �������� ������� ������� �������������� �������. � �������� ������ � ������ ������� �� �������� �� �������� �� ��������� � ����� ������ ����� ��������. ������� �� ��������� �������� ��������� �� ���������� �������� � �������, ����� ����� � ������, �� �������� � ���������� ��, ���� ����� �� ���� ����� � ���� �� ����������� �� ��������.\r\n����� �� ������ �������� �� �� �������� ����� ����� �� ��������� ���������, ������ ���������. ������ �� ������� ��� ���, ����� ����������� ������ � �������� �� ������, �� �� �� �������. ���� ����� �� � ��������, ������ � �������� ������ �� ������ ������� ����� �������, ����������� �� ������� � ���������� ���������. �� ���� �� �������� ���� �� �� ����, �� ������� ������� ������������ � � ���� �� ������ ������������� ����������, �� ������ �� �� �������. ������� � ������� ������ ����� �� ���� �� ���� ������ ������� ����� � �� � ���� ���� �� ��������� ���� ��������� ���. ������� �������� � ������������ ������� � ������. ����� � ���������� ������ � ������� � ����������. �������� �� ������� � �������, �� ����� �� ����������� ����.\r\n� ��������� ���������� �� �� ����������� �� ������� �� �������� � �� ������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode52Chois2()
		{
			int currEpizodeId = 52;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[5] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������� ��� ����� ��� ������, �� ��� �� �������� ������� ������� �������������� �������.\r\n�������� �������, �� ����� ��������� �� �������� �� ������, ������������ �� ����� ���������� �� ����������� �� ���������. ���� �� �������� ������� ��������� �� ������� �� ���������� � ���������, ������� ��������� �� �������������.\r\n���� � ���� ��� � �� ������ �� ������� � ����� �� �� ������ �� ������ ��������. � ����� ���� ����� ������ �� ���������, �� ����� ��� ���������� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode52PsevdoChois3()
		{
			int currEpizodeId = 52;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[5] = 0;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ������ ������������� �� ������� ������� �� �������� ����������� � �� �� ������ ������ � ���. ������� � ������ �� ��������� ��������� �� ����� �������, ����� ������� ������ ��. ���� ������� ��������� ���� ��������� ����� ������, �� ������ �� � ��������� � ��� ������ �� �������� � ������.\r\n������� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������ ������, �� �� ������ ��� ������ � �� ��� �� �������� ������� ������� �������������� �������.\r\n������� ��, ����������� �� ����� ���������� ��� ������������ �� ������� �� �������, �� ��������� ������� ����� ������� �� �� ������ � ����������. � ������� �� ������� ���� �� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode52Chois3()
		{
			int currEpizodeId = 52;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ������ ������������� �� ������� ������� �� �������� ����������� � �� �� ������ ������ � ���. ������� � ������ �� ��������� ��������� �� ����� �������, ����� ������� ������ ��. ���� ������� ��������� ���� ��������� ����� ������, �� ������ �� � ��������� � ��� ������ �� �������� � ������.\r\n������� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������ ������, �� �� ������ ��� ������ � �� ��� �� �������� ������� ������� �������������� �������.\r\n������� ��, ����������� �� ����� ���������� ��� ������������ �� ������� �� �������, �� ��������� ������� ����� ������� �� �� ������ � ����������. � ������� �� ������� ���� �� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode53Chois1()
		{
			int currEpizodeId = 53;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 20;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode54Chois1()
		{
			int currEpizodeId = 54;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode55Chois1()
		{
			int currEpizodeId = 55;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������ ������� ����������! � ��������� ���������. � ������ �� �������� �����!\r\n���� �� ������� ������� ����� ����� ���������� �� ����� ��������. � ������� �� ���������� ��������� ����� �� ��������������, ������� � ���������������� �� �����������, ���� �� ������ � ������, �������������� � ���� �� ��������� �������.\r\n� ��������� ������� ������������ ��������� � ������� ����������. � ����������� ������ �� �����. �������� ���������.\r\n� �������� �� � ������ �� ���������� ��. ���������� �������!\r\n� �������� ������� ������������ ���������. ������� � �����������.\r\n� ��������� ���! ���������, � ����� �������. �������� ������. ���� ���� �������� �������!\r\n� ��������� ������ �� �������� ��?\r\n� ���� ����� �� ���� �� ��������. ��������� �����������.\r\n� ����������� ������� ������������ ���������. ����������� ���������.\r\n� �������� ������� ������! ���������� ������! ����!\r\n����������� ������ ������ �� ������� ���� ������ ��. ������� �� �������� �������� � ��� �����, �� ��������� ����� �������.\r\n� ����� � ��������, ���������! � �������� ���� ����������� �������� ������������, ���� ������� �� �������� �������.\r\n� ���� �� �������������� ��������� � �������� ����������. � �������� ��������. �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode55Chois2()
		{
			int currEpizodeId = 55;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� ������� ��������� �� �� �� ������ � ���� ������� ���������� �������� ��, ������ ���������:\r\n� ��� ��� ��������! ������ � ���! � � ����� ���� ������� �� ������ ��: � ������� ��������, �� ������ ������! � ������� �� �������� �� �������� ��-����� �����, � �� ������ ��.\r\n� �� �� �������! �� �� �����! � � ������ ��������� ���� �� �������. � �������� ��������, �� ��� ������ �� ������ ����������� ���� �� ���������. ���� �������� � ����� ���������� ������ �� �������� ��� ���. ����� �� ������������ �� ��� ������ ��������� �������� �� �� ������ ������� ������, �� �� �������� � ���� �������� � ����, ����� �� ������� ����.\r\n� �� ��� �� ����� � ���� ������� �� ����� ��. � �� ��� �������! ��� ��� � � ���� �������� � ���� ��������, ����� �� ������ �� �� �������� ������.\r\n������ ���� ���� ��������� ����� �� ������� ������� � �� ���� ���������� �������.\r\n� ��� ���? � ���� ���� ��-���������� ������� ��. � ��� ����� ������ � ������� ���. ���� �����?\r\n� ����� � ��������? � �����, ���� �� ������� �� �������� ����� ��.\r\n� ���� � ������ � ������� ������� ��������� �������. � ���� �������? ����� ����? ��? ��� �� ���� ���� ������! � ������ ������ ���.\r\n� �� �� ������ ������ ���� � ��������� �� ���� ��������. � ������ �� ����� �� ���� ����� � ���� ���� ���.\r\n� �� ���� ��� �����! � ����� ��� ���������. � ����?\r\n� �� �� �� �������! � ���� �������� �� �� ������� � ��. � ��� �� ������, ��� �� ����� ������ �� � ������ �� �������� ������������ ����.\r\n� �� ����� �� ����� � ������� ���� ������ ��������� �������� �����. � ��� ���� ��� � ���� ���������� ���������� � ������� ��� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode56PsevdoChois1()
		{
			int currEpizodeId = 56;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 20;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� �� ���������� �� ��������� � ������������ �� ������������ � ���������, �� �������� ������ �� ������ � ����� ���� �������� �� ����� ���������� ������ �� �� �������� ������������ �� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode56PsevdoChois2()
		{
			int currEpizodeId = 56;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 19;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� �� ������ �� ��������! � �������� �� �����������. � ����� ��� �� ������! �� �� ������� �������� � �� ����������!\r\n� ��� � ������ �� �������� ������� ������� ������ �� ������� ��� ���� �������, ������ � ���� � ��� �������. �� ����� ��������� � ����������� �� ���� ������ ����������, �� �� ������ �� �� ��������� ��� � ����������. ������� ������ �� ������������ �� ��������, ������� ������ �� �������� � ��������� ���������. �� ����� ��������� �� ��������� ��������� �� ��������� ����� ������������ ������������ ������� � �������, ����� � ����� ��� � ����������� � ����� ����, ���. ����� ������, ���� ������ ������ �� � ���� ����� ���� �� ������� ��.\r\n������ �� � ����� ��������ѓ �� �������, ������� ��� �� ������ �� �������� � ��������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode57Chois1()
		{
			int currEpizodeId = 57;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ����������� ���� ������� � ���� � ����� �� ����� ���� �� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode58Chois1()
		{
			int currEpizodeId = 58;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ �� �� �������� � ����� ���������, � �� �� ������� ��������� �� �������� �� ���������� ������. ������������ ������ �� �� ��������, ��������� � �������� ��-�����, �� �� �������� ������ �� �� ��������.\r\n����� �� ��������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode58Chois2()
		{
			int currEpizodeId = 58;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ��� �� ������ �� ������� ������ ��������� � �� ������ ����� �� �������� ��������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode59Chois1()
		{
			int currEpizodeId = 59;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode60Chois1()
		{
			int currEpizodeId = 60;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������� ����������, ��������� � �������� ������. ���� �� ����� �� ������� ���������������� � �� �� �������� ��� �������� �� �������� ������������, ������ ������ ������ ������ �� ���������.\r\n� �������� ��������� �� � ��������� ��������� ���������� �� ��������. � ����� ������������ ��.\r\n� ���, ���������� �� �����! � ������ �������. � ������ ����������!\r\n�����: ������������� ������ ������!\r\n�����: �������� �� ������ �� ���� �� ������� �� ����������! ��� ����� �����, ����� �� �� ������, ���� �� �� ������, �� �� ����� �� �� ����!\r\n�����: ������� ���� � ����������������. �� �� ������� ������� ����� ������!\r\n���� �.\r\n� �� ���� ���������. ����� ����������� �����, � ����� �� �������.\r\n���� ���� ��� ���� ������ � ������: ������� �� ������������� �� ��������; ������� �� ����������, ���� �������� � �������; ����������� ������� �� �������� � ��������. ����� �� ����������� �� ��������� �������� ������������ � ������ ��������� ��������� ����� �� �������� ���������, ��������� ���������, ����� �� �����, ����� �� ��������� �������� ���� �� ������� ��.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode60Chois2()
		{
			int currEpizodeId = 60;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������� ���������� ������, ��������� � ��������, ������ ������������� �� ��������� �� �������, �� ���������� �� �������� � ����� �� �������.\r\n� ��������! ��������� ��������! � ����� �� �������� ��� � ����������� �� ��������������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode61Chois1()
		{
			int currEpizodeId = 61;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��������� ���������� � ������ �� ������ ���� ������� ���������. � ���� ���� ��� �������. ����� �� ���������� ���������. ����� �� ����� ��������� ��� �������.\r\n����� ������, ��������� ��� ������ �������, �� �������� ��� ��������. ������� ��� ��� � ��������� � ���������� �� ���������. ����� ��� �� ������� �������� �� ���������� �� �������, ������ ���� ����� ������ ����� ����� ���� �� �� ������ ����� � ��������� �� ����������� ���� �������.\r\n� ������ � ����� � ����� � ����� ������ �� �������� ��������. � �������� � �����������\r\n�� ���������� ���� �� ��������� ������ ����� ������ �����, ����� �� ������� � ��������� ���� ������ ��� ����� �����. ������ �������� � ������� ����������� �� ������� � ����������� ���� � ���������� �� �������� ������ �� ��������.\r\n�������� �� ��������� � ����� �� ����� �� �� ������� ���� �� � ����� �� � �������. �������� �� ����� � ���� �� ������ �� ����� �� ������ ����, ������� �� ������ ��������� �� ������ ��.\r\n�� ������� ������ �� �������, ������� �� ���� ����� ��������� � ������������. ��������� � ������� �� �������� �� ����� ���������� � ����������� ����������. ������ �������� �� ������; ���������� ��, ����� �������� ���� �� ��������� � ���� ���������� ��� � ��������� � ������ � �����. ��������� �� ��������� �� ����������� �� ������ ����, � ��������� ����� ��� �������� ���� ���� ������������� ����� ������.\r\n��� ������� ����� �� ��������� ���� ���������� ������, �� ���������� ���������. ������ ��� ��������� �� ������� � �� ������ �� �� ������������ ��� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois1()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 14;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����� ����, ���������, �� ��� ���������� ������� � ������� ����� ���������. � �������� �� �� �������� ������� ������, �� ���� �� ������ ��� �� ���������. �, ���� �, �������� ���!\r\n��������, ������� � ��� �� ��������� ������, �� �������� � ������ ��. ������� ��, �� ������ � ������� ���������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois2()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 15;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� ������� ��? � ���������, ��������, � ����� �����������. � ������ �� �� ������� ������� �� ������������� ������. �� ����, �� ����. ����������� ������� � 20, � ���� ���� �������� ��������. ��� ������ ���������, �� �� ������� ��?\r\n������ ����� �� ������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois3_1()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 16;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois3_2()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 20;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode62PsevdoChois3_3()
		{
			int currEpizodeId = 62;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 21;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode63Chois1()
		{
			int currEpizodeId = 63;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������� ��� �� ����� ����� � ������������ �� ������������� ������ �������. ���������� ����������� ���� �� ������ �� �� �������� ��� ��-������� � �������. ������ ������� �� �� ��������� ������� ���� ����� ��� ��� ���, ������� ��, ��� ������� �� �������� ����������� �����, � �� ���� �� �������� �� �������� ����� �� �����������, ������ ������� ���������, �������� ����� � ����� ������� �������.\r\n� �������, ������ �������� ������� �������� ������� ����������� �� �� ���� �� ��������� �� ����� �����, ��� ����� �������� �� ��������� �� ��������� �� ������ ����� ������� �������, �������� ��� ���� �� ���������� ������. ������� ��, ������� ���������� ����� �� ���� �� �������� ���� �� ����� ��������ѓ � �������� ������ �� ������� ��������. ���� ������� � �������� �� ������� �� �������� �������.\r\n� ��������! ��������� ��! � ��������� �����. � �������� �� ������� �� � �� ��������� �� ����� ������! � � ������� ��� �� �������� ��� ������� ������ �� ������� � ������������ ������ �����.\r\n���� �� ������� ���� ������ ����� ��� ����� ��������. �������� � ������� �����, ������ �� ����� ��������, �� �� �� �������, �� ������ �� ������. ��� ��� ����������� �������� ����� �� ���������� ��-����� � ��-����� �� ��� � ���������. ���� �� ��� ����� �� ��� �� ������� ������, ������� ������������ ������ � ��������� ������� �� ���� ������. ������������ � ����� � ������ ����� ������� ����� � ��������, �� �� ������� �� ��������. �� ����, � � �� ������ ��������, ���������� ����� � ������� �� ������, ������ �� �� �����, ���� ������ �� ������� � ���� � ������� ��. � ������� ��� ����������, �� �� �� �������� ��-����� � ���� ����� �� �������.\r\n����� �� ��������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode63Chois2()
		{
			int currEpizodeId = 63;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode64Chois1()
		{
			int currEpizodeId = 64;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �������� ������ ��� �� ������������. ��������� � ������� �������� �� ����� �������� �� ����������� ������ ����. ��������� �������� � ��������� ������������ �� ������ ����� � ���� ������ �� �� ������� ���� ��������, ��������� ������ ����. �������� ����� �������� ���� ������, �������� �� ����� �����. ����� ������� � �������, ����� �� �������� �� ���������� � ����� ���������� ��������. ������ � ������ � ����� ��������� � ��������� ������� ����� �����. ��� ��������� ���� ��� ������, ���� ����� �� ������ ������ �����. ���������� ���� ������� �������� ����, �������� �� ����������� ������ �� ������ ����.\r\n� ��� �� ��������! � ������ �� �����. ������ �� ��������� ������������ �� ���� �� ���������, ��, ������� ��, ����� �� � �������.\r\n� �����, �� � ��-������� �� ���������� �� ����� � ������� �� �������� ��������� � �������� ������� �� ������ �� ���� � ������� �� �������������� ��������, ���������� � ���� �� ����� �� ������� ����������.\r\n������� ������ �� �� �������� � ���� �� �������� �� ������� ��, ������� ������������� ���������. ������� �� ������� � ��������� ������� ������ � ���� �������� �� ������. ���������� �� �� ���������� ���������� ����� �� ��������������� �������� � ��� �� ��������� ���� �� ��������.\r\n� ��������� ������� ���� ����������! � �������� ������. � ��� ���� ��� �������� ��� � �������, ���� �������� ��� �������� ������� ������ ����� ������.\r\n� �����, ������ �� ������������! �������, ��������� ������ �� ������ �������!\r\n����� ����� ������������ ������� ���� ���������� ������. ����� �� �������� � ���������� �� �� ��������� ������, ���� �� ������ ������� ����� ���� � �� ������� ��� ������� �����.\r\n� ��� � �����������? � ����� �����������, ����� �� ������� ������, ��������� ��� ����������, � ������� �� �������� �� ������ �� ������� �����.\r\n� ����. ��������� ������� � �����. ���������� � �� ����� ���������� ��������� �����. �������� ���� � ����� � ���� �� �������, �������� ����������� � ����� �������� � ��� �������, ��� ������ ����� ���������.\r\n� ��������� � ���������� ������ �� ��������. � �������� �������� �� ������� ������ �������. ����� ���������� �� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode65Chois1()
		{
			int currEpizodeId = 65;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode65Chois2()
		{
			int currEpizodeId = 65;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �� �� ������, ��� � ��������� �����. � �������� �� ������� � ����� ����������.\r\n� �����, �����, ���� �� ������� � ��������� �� ���������. � ��� ��� ������ �� �������� ��� ���� ����. ����� �� ��������� � ������ ��� LT12.324/q.\r\n���������� ��������� � �� ������� �� ������� ������:\r\n��������� ���� ��� ������ �������� � ��������������.\r\n��� ���� ���� ������� �� �� ��������, ���������� �������:\r\n������: �� �� ��������� � ��������� ��������, ������ ��������.\r\n��������������: ������� �������.\r\n�������: ����� ��� ������� 65 ��/�, ����� �����������.\r\n�������� ��������� ������:\r\n������ �� ������� ���� ������, ����� ������ �� ���-���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode66Chois1()
		{
			int currEpizodeId = 66;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3] - 1;
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������� ��� �� ����� ����� � ������������ �� ������������� ������ �������. ���������� ����������� ���� �� ������ �� �� �������� ��� ��-������� � �������. ������ ������� �� �� ��������� ������� ���� ����� ��� ��� ���, ������� ��, ��� ������� �� �������� ����������� �����, � �� ���� �� �������� �� �������� ����� �� �����������, ������ ������� ���������, �������� ����� � ����� ������� �������.\r\n� �������, ������ �������� ������� �������� ������� ����������� �� �� ���� �� ��������� �� ����� �����, ��� ����� �������� �� ��������� �� ��������� �� ������ ����� ������� �������, �������� ��� ���� �� ���������� ������. ������� ��, ������� ���������� ����� �� ���� �� �������� ���� �� ����� ��������ѓ � �������� ������ �� ������� ��������. ���� ������� � �������� �� ������� �� �������� �������.\r\n� ��������! ��������� ��! � ��������� �����. � �������� �� ������� �� � �� ��������� �� ����� ������! � � ������� ��� �� �������� ��� ������� ������ �� ������� � ������������ ������ �����.\r\n���� �� ������� ���� ������ ����� ��� ����� ��������. �������� � ������� �����, ������ �� ����� ��������, �� �� �� �������, �� ������ �� ������. ��� ��� ����������� �������� ����� �� ���������� ��-����� � ��-����� �� ��� � ���������. ���� �� ��� ����� �� ��� �� ������� ������, ������� ������������ ������ � ��������� ������� �� ���� ������. ������������ � ����� � ������ ����� ������� ����� � ��������, �� �� ������� �� ��������. �� ����, � � �� ������ ��������, ���������� ����� � ������� �� ������, ������ �� �� �����, ���� ������ �� ������� � ���� � ������� ��. � ������� ��� ����������, �� �� �� �������� ��-����� � ���� ����� �� �������.\r\n����� �� ��������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode67Chois1()
		{
			int currEpizodeId = 67;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode68Chois1()
		{
			int currEpizodeId = 68;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������������� ������ ���� ����������, �������� �� ����� ����������� ���� ������� �� ���� ������� ���������� ������� �� �� ��������� � ��������� ������������� ��. �������� ��� �� ������ �� �������� � ����� ����������� �� ������������ ����� ��������� ��������� �������. ������ �� �� ������ � �����, � �����, ��������� ��������� �����. ������� �� �� �����, � ����� ������ ������� � �������� � ���� ������. ���������, ������ ������ �� ��� ��-������� �� ���� ���� �� �������� �������� � ��-����� ����. ���-������� ��������� ����� ������� ��, ������������ � ��� ����� �������� ����� ��� � ��� ������ ��������� ���, ����������� ����, �� ����� �� ������ ����� �� ������ ������, ��� �� �� �������. ������ �� � �����, �������� �����. ����� � ����� �����������, ������ �� ����� �������� � ��� ���� �����, ��������� �� � ����. ����� �� ������, ����� � ����� ��������. ������ �������� �������� �� �������, ��������� ��������� ����, �� ����� �� ������, ������� ������������ �� ��������� �� ����, ������ � ����� � ��������� �������.\r\n��, ������� ��, �� ����� �� � ����, ����� �������� ���������� ��; ����������� � ����� � � ����� ��-������� ��������. ���-����� �� ������� �� �������� ��. �� ���� ������ �������� �� ���������� ���������� ��������, �� ������ � ��������� ��� �������� �� ���������� �� ������ �� ����� ��������������� ���������. ������ ������ �� ���� � ������, � �������� � ��� ����� ������������� �������. �������� ���� �� �������� � ����������� �����, �� � ������������ ����������� �� �������������� ������ �� ��������� ��� ������ ���, ������ ������� ������� ���� � ��� �������� ������ ������� ���� � ��������� � ������ ������ ������ �������.\r\n���-������������ ����� �, �� ������� ������ �����, �������� � ������ ����������, �� ������ ���� �������� ������� �� ������� �� ���������. ������� ������ ��� �� ������ �� �� ������� �������� ������� ����. �����, �� ��-����� ��������� ������������� � ��� ������� �� ������� ������� �� �������� � ������� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode68Chois2()
		{
			int currEpizodeId = 68;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode69Chois1()
		{
			int currEpizodeId = 69;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode70Chois1()
		{
			int currEpizodeId = 70;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� �����.\r\n��� �� ��� � ����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode70Chois2()
		{
			int currEpizodeId = 70;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �����.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode71Chois1()
		{
			int currEpizodeId = 71;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �� �� ������ ��-�����! � ������ � ���� ������, ������ ���������. � �� ����� ������! � �������� ���� �� �����������.\r\n������ ������� ���� ���������� �� ��������� ���� �������. ���������� �� ������������ �����, ������������� �� ������� � ������ � �� ������������� ����� �� ������ ����� ���������, � ����� ������� �������� �� ����������� ������ ���� � �����. ����� ���� ���� ������, �������� �������� ��������� ���� ��-������ �� ���������� ������� ������� ����� � ������� ������ � ������� ��� �� ������� � ����� ���� �����. ���� �� ������� ������� ������ �� ������� � ������� ��������� �� ������ ��� �� �����.\r\n� ���� �������! ����� ��! � ����� �� ��������� �� �� �� ������� ����������. � �� ����� ���� �� �� ��������.\r\n��� �� ������ �� �� �������, �� � ��������� ������ �� ����� � �� ������ � ��� ���� ����� � �������.\r\n� �� ������! ���� �� �� ��������! � ������ ���������� �� ������ �� �� �������. � �������� ������� ����! �����!\r\n� ���������, ��������! ���, ����� ��-������! � ���� �������� ����� � ������� ������ ������ �� ������� �������� ����������.\r\n������������ �������� �� ��������� ������� �������� ���� ��� ��������� ������. �� ��������� �� ������� ����� ������� ������������ ��������� ���� � ��� �� ������ �������� �� ���������� � ��� ����, ������� � ������������� �� ������ ����� ��������������� �� ����������. � ��� � ������������ �������� �� �������� �������. ���� �������� � ���� ����� ��, ������������ ������������ � � ������� ����� ���������� ������������ ����. ����������� ������ � � ��������� ����� ��������� ��������� ������� ������� ������������ �������� ����.\r\n�� �������� ��������� ������� � �������. ������, ���������� � ���������, �� �������� � ���� ��� ������ �� ���������, ������ � ����� �������� ������� ����� ������ �� ������� � ������ ����� ��� � ����� ��������� ���������� ��� � ��������� �� ������� ��.\r\n� ����, ������� �� � ������� ���������� �� ��������� �� �� ���������� �����������. � ��������� �� � ������.\r\n� ����, ������� �� �� ������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode71Chois2()
		{
			int currEpizodeId = 71;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��! �������! � ��������� ����� � ���� ������������ ��� ������� ������ ��������, �� ����������, ��������� �� ���������� ���������.\r\n� � ���� ����� �� ������������� ������ �������������� �� ��������� ������ ����. ������������ �� � ������� �� ������, �� � ������� � ������ ��������� ������� ������������� �� ���� �� �� ������. ������������ ��������, �� � ������ ����, � ���������� �� �������, �� � ���� ������� �������. ������ �� ����� �����������, �� ������� �� ��� �������. ��� ��������������� ��� �� ���������� ������� ����� ������, ����� �� ������ ��������� ������� ����� � ����� � ������ ���� �� ������� ��.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode72Chois1()
		{
			int currEpizodeId = 72;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ��, ����� �� � �����������, ��������� �� ������ �� ���� � ������ ��. �������� �� �� ������� ����� ������������, ���������� ��������� ������� ����� � ����� ����������� �� ����������, �� ���������� ���� ���������. ����������� � ���� �������� ���� � ���� ����� ������� � ������ � ������� � �����, �� ������� ����� �������� ����������� ����� �� ��� ����. � �������� ��������� � ����������� ���� �������� ������ �� �������� �������� ���������� �� �������.\r\n��������� �� �������, ����� ��������� �� ���, � ������ �� ������� � ����������� ����� �� ������������ ��������� � ����� ����� ���������� � ������ ����, � ���� ���� � ����� ��� ��-������� ��������� � �������� �� ������. ���� ������� ��������� ������� � �������� � ��������� ������. ��������� �� ������� �� ��������� � �� ���������� � ������� �������, ������� �� ������ ���������� ���� �� �����. ��������� ����� �� ������ �� ������� �� �������, ����� �������� �� �������, ���� ���� ������������ �������� ��������� �� �� ����������� � �� �� �� ���������� � �������� �� ����������� �������������, ���������������� � ������ ��-����� ���������.\r\n������ �� ���� ����� ���� � ���������� ����� � ����������� ������������, ����� ������ ������� ���� � ���������. ������� �� ������ �������� ��������� � ������ �������� ����� � �����������, ������������� �� ������� ������ ����, � ���������� � ����� �������� ���������� ��������������� � �������� ������.\r\n����� ������� ������ �� ��������� ��������� ��������� � ����������� � ���� �������������� � ���������� ��������������� ��������, �������� ��� �� ������ ������, ����� ����������� �� ������� ���� ����.\r\n��������� � ����� � �����, �� ���� ��������� ��� �������� ��, ���� �� ��������, ������������ �� ��������� ������� �� ������� � ��������� ����� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode73Chois1()
		{
			int currEpizodeId = 73;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� �������� ������, ������� � ���� ��������, �������� ���� �������� �� �����������. ������� �� �������. � �������� � ���� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode74Chois1()
		{
			int currEpizodeId = 74;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������, ����� ���� ��� �� ������ ����� ������ ���, ����� ���������� ��������� � ��������� �� ������ �� ������� �����. ��������� �� ���-�������� �� �����, ��� �������� ��������, �� ������� � ��������� �� �������� ������� ��������� � ������� ������. ��� ����� ���� ��� ���������� �� �������� � �������� ��������� ���� �� ���������� ������ � ���� ����������� ��������� ���� ������ �������:\r\n� ��������� ����� ������� �� ������! ������� � ��������� �������! ������ ����� ����� �� �� ������� ��� ������ �� �������! ���������� ���� �� ������� � ��������� ��! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� �� ��������! � ����� ������. � ��� �� �� ������� � ����? � �������� ���������� � ����� ��������� �������� �����.\r\n� ��������� ����� ������� �� ������! ������� � ��������� �������! ������ ����� ����� �� �� ������� ��� ������ �� �������! ���������� ���� �� ������� � ��������� ��! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������! � ���������� �� ����� ��������� �������.\r\n� ���������, ���� �� �� ������� � ������ � �������� ������������. � ����������� �� ���� �� �� ������ ��� ��������� �� �������.\r\n� ��� �� �� ��������? � ��������� �������. � ���� ������, �� � ����� �� �������� ������, ����� ����.\r\n� �����, �� ���� � �������� ����� �� ���������� ����. ����� �� ������, ���� ������������� ���������� �� �� ��������. ���� �� �� �� ���������������.\r\n� ����� ���� �� ��� ������ �� �� ������, � � ������ �� ������� � �� �� ���������� ��. � �� ����� �� �� �� ������� �����?\r\n� ���� ��������, ��������� � �������� ������� ����������. � ��� � ����������� �� �������� ����������, � �� �� �� ������ � ������.\r\n� �� ���� ������� ����� � ������ �� ��������� ������ �����. � ������� ���� ������ ��� � ��� ������� ���� �� ������.\r\n��� ����������� �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode75Chois1()
		{
			int currEpizodeId = 75;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode76Chois1()
		{
			int currEpizodeId = 76;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �����.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode76Chois2()
		{
			int currEpizodeId = 76;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] + 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� �����.\r\n���� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode77Chois1()
		{
			int currEpizodeId = 77;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������ ������� ����������! � ��������� ���������. � ������ �� �������� �����!\r\n���� �� ������� ������� ����� ����� ���������� �� ����� ��������. � ������� �� ���������� ��������� ����� �� ��������������, ������� � ���������������� �� �����������, ���� �� ������ � ������, �������������� � ���� �� ��������� �������.\r\n� ��������� ������� ������������ ��������� � ������� ����������. � ����������� ������ �� �����. �������� ���������.\r\n� �������� �� � ������ �� ���������� ��. ���������� �������!\r\n� �������� ������� ������������ ���������. ������� � �����������.\r\n� ��������� ���! ���������, � ����� �������. �������� ������. ���� ���� �������� �������!\r\n� ��������� ������ �� �������� ��?\r\n� ���� ����� �� ���� �� ��������. ��������� �����������.\r\n� ����������� ������� ������������ ���������. ����������� ���������.\r\n� �������� ������� ������! ���������� ������! ����!\r\n����������� ������ ������ �� ������� ���� ������ ��. ������� �� �������� �������� � ��� �����, �� ��������� ����� �������.\r\n� ����� � ��������, ���������! � �������� ���� ����������� �������� ������������, ���� ������� �� �������� �������.\r\n� ���� �� �������������� ��������� � �������� ����������. � �������� ��������. �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode78Chois1()
		{
			int currEpizodeId = 78;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��-����� �� �������� �� �� ����� � ������ ���� ������ �������� � ���� �� �������� ��� ��������, �������: � ��� ���� ������ ��� �������� ���.\r\n� ��� ��� ��� ������� ������ � ������ �� ���� �� �����������. � ���� �� � ��-����.\r\n� ������ �� �� ����� �������. �, ��-����� ���� �� ������� � ��������� ��. � ��� �������, �������� �� �������� ������� ����� �� ���������! ��� �� �������� �������� � �� �������� �������. � ��-�����, ��� ����� �������� ������ �� ������!\r\n������ ������� ���������� �������� ����������� � �������� ������� �� ��������� �� ��������� � �� ������� �� ������� ���� ���� ������, ��� � ����������� ������� ������ �������� �������. �� �������� �� �������� ��������, ������, ����� ����� � ���������, �� ������ �������� � ��������� ������ � ����������� �������.\r\n���� �� ��������� � ��������������� ������; ����� � �����, ����������� � ����� ��������� � ����� ������� � ����������� ��� �� ������������ ���� �� ���������. ������������ �� ��������� ��� � ��������� ����������� ����� ��� �� ������� �� �������� ��������� �� ������. ��������, ��� �� �������� ������� ���� �����.\r\n������ ��� ����� ���������� � ������� �� ������, ��� ����� �� ����������� ����������� � ������������ ���� ��� ������� �� ���������� �� �����������.\r\n����� ��� ��������� �� ��������� �������� ������� ������ ��������������. �� ����� � ������ ������� �� �������� �� ��������� �� �� ������ ��� �������� �� ��������� ������� � ����� � ��������� ���������� ������ �� ������ � ����������� ��.\r\n���� �� ������ ����� �� ��� � ���� ����� � ���� ��� �� �� ������ �������� ������ ����� � � ��������� �������� ������ ���������� �� ��������� ���������. ������ �� � ��� �������, �� ���� �� �� �������. �� ��� ������� ���� ��������. ���������� ������ ��� ������������ �� ���� �� �� �������, �� ������������� ��� ������� ������ �� ����� � �������\r\n������ ������ ������ �� ����� ��.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode78Chois2()
		{
			int currEpizodeId = 78;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� �������� ��������� �������, �� � ��-������ �� �������� ����� �� ������� �� ������������ � ������ � ���������� ���� �� ����������� ������ �������� � �������� ��������. ����� ����� � ���������, ����� �������� ����� ��� ������. ���� ������� ������ ���� ������ ��������� � ������� � ����������� ����� ����. � ������ ���� � ������ ����� �� ��������� ��� ���� ������������ ������������. ������� ������� �������� �� ������� ��������� ���� �� ��������� �� �� ����������� � �� �� �� �������� � ���������. ������� �� ������������ ������� � ����� � ����� ��� �����. ������� ��������� ���������� ������������� ���� ����� �� ������� �� �����. ���� ���������� ������������� ������� �� ������ � ����� ������ ��� ������� �� �����. ���� ���� ���� ��� �� �������� �� ������ ������� � �� �������� ��� ������ ����� �� �������.\r\n������� ������ �� ������������ ���� �������� ������� �� �������� � ���� ����. ���������� ������������, ����� � ����� ������� � �� � �������� � �������� �� ��������, ������ ���� �� ������ ������� ���� � ���� � ������ �������� �� ������ �� ������� ����������� �� ������� ������� ��������.\r\n� ���������, ����� �� �������� � ������� �� �������� ���. � �� ����� ��������� ����� ����� ������ ������. ������� � �������� ����� �� ����������. ��� �������� �����, �� �� �������.\r\n� ���, �� ������! � �� �� ������ ���� �� ����������� � ������� ������: � �������� ���������, �� ����� �� ���� ���� ����!\r\n� ����� �� ������? �����������! � � �������� ���� �� ������� ��.\r\n��� ����� �� �����������, ������ ������ ����� �� ������������� ��. ������ �� ������, �� �� ���� �������� �� ������ �� ������ �������. ���� �� �������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode79Chois1()
		{
			int currEpizodeId = 79;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ �����, ����� �� ���� �� �����. ���� ���� ����� ������� � ��������� �� ������ �� �������� ��������. ������������ �� �� � ���������, � ������ � ��������� ������ � ����� �������, �������� �� �������� ��������� �� ����.\r\n� ������ ������� �� ��������� ������! �����, ���� ���?\r\n� ��� ���������, �� ����� ��� ��������� �� ���������. ��������.\r\n� ������ �����, �� ���� �� �����. ����� �������. ���� ���� ����� �������.\r\n� ������� �� ����������! ��������! ��������� �������� ��������� �� ���������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode80Chois1()
		{
			int currEpizodeId = 80;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ �� �� ������� �� ����� ���� � ������ � ���� ����������� ������������, ���������: � ������ ���, ����� ���� �� �� ����� ��� �������� ���. ����������, ������������� �� ����� � ���������� �� ����� �� ����������!\r\n� ������! �������� �� ������� �� � ����� ������ �� ������������! ��������� �� ��?\r\n� ��������, ���! ��������� ����������� �� �������� ������. ��� 1-3-0, ����� �������, �������� ���� ��� �������.\r\n������ ������� ���������� ����� � ���������� ���������� �������, �� ���������� � ���������, �� ����������� �������� � ���� ������. ���� ���� ��������� ���������� �� �� ���������� �� �������� �� ��������� �������. �������� ���� � ��������� �������� �� ���������� �������� �����, �� ��� ��� ������ ������, ���� �� ���������� ����������� �����. ���� �������� ������ ���� ��������� �� �� ���������; ������ ��� ��-���� �� ���� ������ ������� �� ����� ������ � ������ ����������. �������� ������� ������� � �������� ������� �� ����� �� ��� �� ��������� �� �����. ����� ��������� ��������� � ������������ ���, ������ �� ���������� ������� � ������ �� ��������� ������ ������� ��������� ������� ������� ������.\r\n� �����, ������! ������ �� �� ��������! � ����� ������ � �� ������� ��� ������� �� ����������� �����.\r\n���� ���� ������� ������� ����� ���� ����� �� �� �������� ���������� ������. �������, ����� ���������� ����� ����, ���������� �������� �� �������� �����������, �� � ���� ������������ ���� �������� � ��������� ������������� ������, � ������� � ����� ���� �� ��������� � ���� ���� �������, �� ������ �� �������� �� �������� ��� ���� �����. ����� ����� �� ��������� ������ ���� �� ��������� ������� � ����� � ���� ������ ���������� �� ���������� �������� ������ �� ������� ���������� ���������� ������. ���������� �� ��������� ���� ���� �� ��������, �� ������ ������� ������ �������� ������ �� �����, ��� �� ��������� ���� ������ �� ���� � �������� ���������. ���� ���� ������� �� �������� �����, ����������� �� ������ � �������� ����� ����� ������� ��������. ��� ��� ������ �� �������� �� ������, �� ������ �� ��������� �������.\r\n� ��������! ������, ����! � ���������, ��� ������ �� �� ��������, ��.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode80Chois2()
		{
			int currEpizodeId = 80;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� �� ���������� �� ��������� � ������������ �� ������������ � ���������, �� �������� ������ �� ������ � ����� ���� �������� �� ����� ���������� ������ �� �� �������� ������������ �� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode81Chois1IfChecksumNotZero()
		{
			int currEpizodeId = 81;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.PreviousValueChecksum1 = 100;
			this.playerStatus.PreviousValueChecksum5 = 500;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ����� ����� ����� �� �� ��������, ��������� �����, �������� ����� �� ������ � �� �� �������� �������� �� � ���-������ ���������� �� ��������� �� ������. ���������� ��������� � ���-������� �� ���������. ������, �� ���������� � ��� ����������� ���������� � ���� ����� ������ �� ������� ���� �� ��������� ����� ���� �������� �����. ������� �� ������� ������� ������ ����������, � ������� ����� � ����������� ������� �� �������������� ����������. �� ���� ����� �� �������� � ������� �������� ����� �� ���������� ����� ��������� � ����������� � ����. ������������ � ���������� �, �� ���������������� �� �������� �� ��� �� � ����������. ��������� �� � ��������� �� ������: ������ ������ �� ������ �����, �� ����� ���� ���, ��������� �������� ���� ����� � ��������� ��������� � ��������� ������� �� ����� �������� ��������������. ����� ���� �� ������������ ��������� �������� ������� �� ���������� � ������ �� ���������� ���� ����� ��������. ������ ������� �� ���� ����� ����������� ����������. �� ��������� �� ��� ������� �����, ����� �������� ��������, ����� ���� ������ ��� ������ �����������. ���� �� � ������� � � ��������� ������, ���� �� �� �������� ��-����� � ���������. �� ���������� ������� �������� ���������� �� ����������� �� ����������� ������� � ������� � ����������� ������, �� ������ ������� �������� ����� ������� �� ����������.\r\n������ ��������� ������������ �� ��������� ������, �������� �� ���������, �� ������� ���� �� ������� � ��������� ��������, �� ��� ������ �� ���������� �������� �� ���� �� �����.\r\n���� ���� ���� ������� ����� � ����������� ��������, ���� �� ������������ �� ��������, �� �������� �� ���� � ������ ������ ������, ����� � �������, � ����� �� ��������� �� ������� ����� ��������� �� ����. ������ �� �������� ������� ���� �� �� ����� � ���, �� ���������� � �� ������ �� �� �����.\r\n������ �� ������ � �������� � �� ������ �� �������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode81Chois1IfChecksumIsZero()
		{
			int currEpizodeId = 81;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.PreviousValueChecksum1 = 100;
			this.playerStatus.PreviousValueChecksum5 = 500;
			this.playerStatus.Checksums[1] = 0;
			this.playerStatus.Checksums[5] = 0;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[1] = this.playerStatus.PreviousValueChecksum1;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.PreviousValueChecksum5;
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ����� ����� ����� �� �� ��������, ��������� �����, �������� ����� �� ������ � �� �� �������� �������� �� � ���-������ ���������� �� ��������� �� ������. ���������� ��������� � ���-������� �� ���������. ������, �� ���������� � ��� ����������� ���������� � ���� ����� ������ �� ������� ���� �� ��������� ����� ���� �������� �����. ������� �� ������� ������� ������ ����������, � ������� ����� � ����������� ������� �� �������������� ����������. �� ���� ����� �� �������� � ������� �������� ����� �� ���������� ����� ��������� � ����������� � ����. ������������ � ���������� �, �� ���������������� �� �������� �� ��� �� � ����������. ��������� �� � ��������� �� ������: ������ ������ �� ������ �����, �� ����� ���� ���, ��������� �������� ���� ����� � ��������� ��������� � ��������� ������� �� ����� �������� ��������������. ����� ���� �� ������������ ��������� �������� ������� �� ���������� � ������ �� ���������� ���� ����� ��������. ������ ������� �� ���� ����� ����������� ����������. �� ��������� �� ��� ������� �����, ����� �������� ��������, ����� ���� ������ ��� ������ �����������. ���� �� � ������� � � ��������� ������, ���� �� �� �������� ��-����� � ���������. �� ���������� ������� �������� ���������� �� ����������� �� ����������� ������� � ������� � ����������� ������, �� ������ ������� �������� ����� ������� �� ����������.\r\n������ ��������� ������������ �� ��������� ������, �������� �� ���������, �� ������� ���� �� ������� � ��������� ��������, �� ��� ������ �� ���������� �������� �� ���� �� �����.\r\n���� ���� ���� ������� ����� � ����������� ��������, ���� �� ������������ �� ��������, �� �������� �� ���� � ������ ������ ������, ����� � �������, � ����� �� ��������� �� ������� ����� ��������� �� ����. ������ �� �������� ������� ���� �� �� ����� � ���, �� ���������� � �� ������ �� �� �����.\r\n������ �� ������ � �������� � �� ������ �� �������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode82Chois1()
		{
			int currEpizodeId = 82;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ����� ����� ����� �� �� ��������, ��������� �����, �������� ����� �� ������ � �� �� �������� �������� �� � ���-������ ���������� �� ��������� �� ������. ���������� ��������� � ���-������� �� ���������. ������, �� ���������� � ��� ����������� ���������� � ���� ����� ������ �� ������� ���� �� ��������� ����� ���� �������� �����. ������� �� ������� ������� ������ ����������, � ������� ����� � ����������� ������� �� �������������� ����������. �� ���� ����� �� �������� � ������� �������� ����� �� ���������� ����� ��������� � ����������� � ����. ������������ � ���������� �, �� ���������������� �� �������� �� ��� �� � ����������. ��������� �� � ��������� �� ������: ������ ������ �� ������ �����, �� ����� ���� ���, ��������� �������� ���� ����� � ��������� ��������� � ��������� ������� �� ����� �������� ��������������. ����� ���� �� ������������ ��������� �������� ������� �� ���������� � ������ �� ���������� ���� ����� ��������. ������ ������� �� ���� ����� ����������� ����������. �� ��������� �� ��� ������� �����, ����� �������� ��������, ����� ���� ������ ��� ������ �����������. ���� �� � ������� � � ��������� ������, ���� �� �� �������� ��-����� � ���������. �� ���������� ������� �������� ���������� �� ����������� �� ����������� ������� � ������� � ����������� ������, �� ������ ������� �������� ����� ������� �� ����������.\r\n������ ��������� ������������ �� ��������� ������, �������� �� ���������, �� ������� ���� �� ������� � ��������� ��������, �� ��� ������ �� ���������� �������� �� ���� �� �����.\r\n���� ���� ���� ������� ����� � ����������� ��������, ���� �� ������������ �� ��������, �� �������� �� ���� � ������ ������ ������, ����� � �������, � ����� �� ��������� �� ������� ����� ��������� �� ����. ������ �� �������� ������� ���� �� �� ����� � ���, �� ���������� � �� ������ �� �� �����.\r\n������ �� ������ � �������� � �� ������ �� �������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode83Chois1FirstChecksumLess20()
		{
			int currEpizodeId = 83;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 24;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����� ����, ���������, �� ��� ���������� ������� � ������� ����� ���������. � �������� �� �� �������� ������� ������, �� ���� �� ������ ��� �� ���������. �, ���� �, �������� ���!\r\n��������, ������� � ��� �� ��������� ������, �� �������� � ������ ��. ������� ��, �� ������ � ������� ���������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode83Chois1FirstChecksumMore20()
		{
			int currEpizodeId = 83;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 26;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode83Chois1FirstChecksumEqual20()
		{
			int currEpizodeId = 83;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 25;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode84Chois1SixChecksumEqual0()
		{
			int currEpizodeId = 84;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[6] = 0;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� �� ������ �� �� ���������� ������� ��������� ���������� ����� � ���� ����� ��������� ��������� �� � ���������. ��� ��� ��� �� ����� �� ������ � ���� �������� �� �� ������� � �� ������ ����������, ������ �������� ����� ����� �� ������� �� � ������������� ������� �� �� ������� ��� ������� �� ������������.\r\n�������� ����� ����� �� ��������� ������ �� �������� �� �� �������� � �������� �� ������������, �� ���� �� �������, ������ �� �����.\r\n����� �� ������ �� ���� �� ������� ���� ��������� 35 ��.\r\n������� �� �������� �� ���� �������� � 12 ��, ��� �� ������ ��������� �������ғ, � 6 �� �� ������������� �������ғ.\r\n����� �� ������� �� � ������� � ������������ ����� ��������, �������� ���� � ���������������, ����� ������������� ����� �� 10 ���, ����� �������, ����� � ������������ ���������� � ������� � ������ � ���� ����� 10 ��.\r\n����� �� ������� ��������, ����� �� ������������ �� ����������� �� ������ ��.\r\n� ����, ����������� ���� ��� ������������ �����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode84Chois1SixChecksumNotEqual0()
		{
			int currEpizodeId = 84;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[6] = -1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ��� �� ������ �� �������� � ����� �������� � ����������� �� ������������ ����� ��������� ��������� �������. ������ �� �� ������ � �����, � �����, ��������� ��������� �����. ������� �� �� �����, � ����� ������ ������� � �������� � ���� ������. ���������, ������ ������ �� ��� ��-������� �� ���� ���� �� �������� �������� � ��-����� ����. ���-������� ��������� ����� ������� ��, ������������ � ��� ����� �������� ����� ��� � ��� ������ ��������� ���, ����������� ����, �� ����� �� ������ ����� �� ������ ������, ��� �� �� �������. ������ �� � �����, �������� �����, ����� � ����� �����������, ������ �� ����� �������� � ��� ���� �����, ��������� �� � ����. ����� �� ������, ����� � ����� ��������. ������ �������� �������� �� �������, ��������� ��������� ����, �� ����� �� ������, ������� ������������ �� ��������� �� ����, ������ � ����� � ��������� �������.\r\n��, ������� ��, �� ����� �� � ����, ����� �������� ���������� �� � ����������� � ����� � � ����� ��-������� ��������. ���-����� �� ������� �� �������� ��. �� ���� ������ �������� �� ���������� ���������� ��������, �� ������ � ��������� ���, �������� �� ���������� �� ������ �� ����� ��������������� ���������. ������ ������ �� ���� � ������, � �������� � ��� ����� ������������� �������. �������� ���� �� �������� � ����������� �����, �� � ������������ ����������� �� �������������� ������ �� ��������� ��� ��� �������� ����� �� ���� �� ���.\r\n���� ���� �� ��������� �����������, �������� � ������� �� ��������� � �����������, ������ �� ����� ��� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode85Chois1()
		{
			int currEpizodeId = 85;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ��� �� ������ �� �������� � ����� �������� � ����������� �� ������������ ����� ��������� ��������� �������. ������ �� �� ������ � �����, � �����, ��������� ��������� �����. ������� �� �� �����, � ����� ������ ������� � �������� � ���� ������. ���������, ������ ������ �� ��� ��-������� �� ���� ���� �� �������� �������� � ��-����� ����. ���-������� ��������� ����� ������� ��, ������������ � ��� ����� �������� ����� ��� � ��� ������ ��������� ���, ����������� ����, �� ����� �� ������ ����� �� ������ ������, ��� �� �� �������. ������ �� � �����, �������� �����, ����� � ����� �����������, ������ �� ����� �������� � ��� ���� �����, ��������� �� � ����. ����� �� ������, ����� � ����� ��������. ������ �������� �������� �� �������, ��������� ��������� ����, �� ����� �� ������, ������� ������������ �� ��������� �� ����, ������ � ����� � ��������� �������.\r\n��, ������� ��, �� ����� �� � ����, ����� �������� ���������� �� � ����������� � ����� � � ����� ��-������� ��������. ���-����� �� ������� �� �������� ��. �� ���� ������ �������� �� ���������� ���������� ��������, �� ������ � ��������� ���, �������� �� ���������� �� ������ �� ����� ��������������� ���������. ������ ������ �� ���� � ������, � �������� � ��� ����� ������������� �������. �������� ���� �� �������� � ����������� �����, �� � ������������ ����������� �� �������������� ������ �� ��������� ��� ��� �������� ����� �� ���� �� ���.\r\n���� ���� �� ��������� �����������, �������� � ������� �� ��������� � �����������, ������ �� ����� ��� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode86Chois1FirstChecksumLess20()
		{
			int currEpizodeId = 86;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;
			this.playerStatus.Checksums[1] = 19;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����� ����, ���������, �� ��� ���������� ������� � ������� ����� ���������. � �������� �� �� �������� ������� ������, �� ���� �� ������ ��� �� ���������. �, ���� �, �������� ���!\r\n��������, ������� � ��� �� ��������� ������, �� �������� � ������ ��. ������� ��, �� ������ � ������� ���������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode86Chois1FirstChecksumMore20()
		{
			int currEpizodeId = 86;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;
			this.playerStatus.Checksums[1] = 21;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode86Chois1FirstChecksumEqual20()
		{
			int currEpizodeId = 86;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;
			this.playerStatus.Checksums[1] = 20;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode87Chois1()
		{
			int currEpizodeId = 87;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������ ������� ����������! � ��������� ���������. � ������ �� �������� �����!\r\n���� �� ������� ������� ����� ����� ���������� �� ����� ��������. � ������� �� ���������� ��������� ����� �� ��������������, ������� � ���������������� �� �����������, ���� �� ������ � ������, �������������� � ���� �� ��������� �������.\r\n� ��������� ������� ������������ ��������� � ������� ����������. � ����������� ������ �� �����. �������� ���������.\r\n� �������� �� � ������ �� ���������� ��. ���������� �������!\r\n� �������� ������� ������������ ���������. ������� � �����������.\r\n� ��������� ���! ���������, � ����� �������. �������� ������. ���� ���� �������� �������!\r\n� ��������� ������ �� �������� ��?\r\n� ���� ����� �� ���� �� ��������. ��������� �����������.\r\n� ����������� ������� ������������ ���������. ����������� ���������.\r\n� �������� ������� ������! ���������� ������! ����!\r\n����������� ������ ������ �� ������� ���� ������ ��. ������� �� �������� �������� � ��� �����, �� ��������� ����� �������.\r\n� ����� � ��������, ���������! � �������� ���� ����������� �������� ������������, ���� ������� �� �������� �������.\r\n� ���� �� �������������� ��������� � �������� ����������. � �������� ��������. �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode87Chois2()
		{
			int currEpizodeId = 87;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��������� ����������. ������������ �������� ������� � �� �� �������� ������� � ��������� � ��� �� �������� ��� ���� �� ��������.\r\n� ������ �� ��� ���������. ������ ���������� �������� ������� � � ���� ���������� �������� ������ �� ������, ����������: � ������ �� �� �� ������ � ����� �����!\r\n� �������� ������� �� ���������� ���������. �������� � �����������. ��������� � ������� �� ��������. �������� �������� �������.\r\n�������� �� ������ � �������� ���. ���� � ����� �� �������. ���� ���� �� �� ��������� ��� ����������.\r\n� ���� �� �������������� ��������� � ��������� ����������. � �������� ��������. �����!\r\n����� ������ �� �������� ��� �������� � �� ����������� ���� ����� �� �� ������ ����� ������. ���� ���� ����� ����� ����������� �� �������� �� ����������� �� ������. ������ ���������� ���� ������� ����, ��� ��� ��������� � � ����� ���� � ����� ������� ������������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode87Chois3()
		{
			int currEpizodeId = 87;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� �����������! � ������� ������� ��. � ��������� ���������� �������� � ������ �� ���������.\r\n� ����������� �� ���� � �������� ������� ����������. � �������������� ��������� � ��������. ����� ���������� �� ���������!\r\n� ������ ��������� ������ � �������������� ����! � �������� �� ������ ����� �����, ����� �������� ��-������ � �������� � ��-����.\r\n� ���� �� �� �� ������, ������ �������� ��� ���? � ���� ��� �������� � ����� ������������.\r\n� � ���� ������? � ��������� ��. � �������� ��, � � ��� �� �������� ��������.\r\n� ������������ �� �������� �������� � �������� ����������. � �������� ���������. �������� ������� �� ������.\r\n������ �� ������� ����� � ������ ������ � �������� ���. ���� �� �� ���� �������� �������!\r\n� ���� �� �����������. �������� ���������� ��������.\r\n� ���� �������� �� �������� ���� ������� ����� ����� �������� ����. ��������� �� ������ ��������, ������ ������������ ��������� ��� ��������� � ��������� �������� ��������. � ������ ��� ��������� �� ������ � �����������, ����� ����� ����� � �������� ��������� �� ������� � ��������� ������� ����������� �� ��������. ���� ������� ������� ������� �� ����������� � ������������� ���� �� �������� �������:\r\n� ������� ��������� � �����������. ������ ������� ������� ��������. ��������� ���������� ������. ���������� � ����� �� ���������� �����. ���� ���������� �� �����.\r\n� ������ ������� � ������������ ������� �� ����� �������! � �������� ������� �� ��������.\r\n� �������� �� ������� ��! � ������ �����, ������ ����������� ��� ����� ��. � � ��-����! � �������� � �� ��� ��������� ���������.\r\n���� � �������� ���� �������, ��������� �� ������ ����� ��� ��������� ������ �� ��������� � ���� ���� � ������ ����� �� ����� ����������, ���� �� ��� ��������� �� ����.\r\n���� ����� �������� ������ ��� �� ������������. ��������� � ������� �������� �� ����� �������� �� ����������� ������ ����. ��������� �������� � ��������� ������������ �� ������ ����� � ���� ������ �� �� ������� ���� ��������, ��������� ������ ����. �������� ����� �������� ���� ������, �������� �� ����� �����. ����� ������� � �������, ����� �� �������� �� ���������� � ����� ���������� ��������. ������ � ������ � ����� ��������� � ��������� ������� ����� �����. ��� ��������� ���� ��� ������, ���� ����� �� ������ ������ �����. ���������� ���� ������� �������� ����, �������� �� ����������� ������ �� ������ ����.\r\n� ����, ������� ���� �� �������� � ��������� �������. �������� �� �� ����������� � ���� ���� 15 ��� �� ���������� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode88Chois1()
		{
			int currEpizodeId = 88;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����� ����, ���������, �� ��� ���������� ������� � ������� ����� ���������. � �������� �� �� �������� ������� ������, �� ���� �� ������ ��� �� ���������. �, ���� �, �������� ���!\r\n��������, ������� � ��� �� ��������� ������, �� �������� � ������ ��. ������� ��, �� ������ � ������� ���������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode89Chois1()
		{
			int currEpizodeId = 89;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode90Chois1()
		{
			int currEpizodeId = 90;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode91Chois1()
		{
			int currEpizodeId = 91;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 15;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����� ����, ���������, �� ��� ���������� ������� � ������� ����� ���������. � �������� �� �� �������� ������� ������, �� ���� �� ������ ��� �� ���������. �, ���� �, �������� ���!\r\n��������, ������� � ��� �� ��������� ������, �� �������� � ������ ��. ������� ��, �� ������ � ������� ���������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode92Chois1()
		{
			int currEpizodeId = 92;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� ����������� ������� � ������������ ���������� �� ����������� ��������� �� ������������ �� ������������� ���� �������. ���� � ���������, ����� ��� ���, �� ������ ������� ������������� �������� �� ���� �� ���-�������� ������������. ����������� �� ��������� ��� ������ �� �������� �������. ����� ����� �� ���� �� �� ������ ���� �����. ����� � ������ ��������� ������� ������� ������������, ����� ���������� � ������������� ��������� ������� ���������� ��������� �� ������������ ������� � ������� ������ ����� �� ������ � ���� ������������.\r\n��� ��� ��������� �� �� �� �������� ������������. ������ �� ���� �� ����� � �������� �� ��������� �������, ���� ���� �� ��������� ����������� �� � ����� ��� ������� �� ��������� � �� �������� �� ���������. ����� ������� ������ ��������� ������� �����������, �� ������ �������� �������� � ������, �� �� ������ �� �� ���������� � ��������. ����� ������, ��������� ��� ��� �� ���� �� ����� �������. ����� � ��� ���, ��������� ������� �� ������� �� ������ ���������. �������� ���� ���-�������� �� ����� � ������ �� �������� �����������. ���� ������������ �� �� ���� �� ����� ������� ��� �� �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode93Chois1()
		{
			int currEpizodeId = 93;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������! � ����� ����� � ����� ������� ��������� � ���������� �� ����� ����� ���������. ���� ���� ����� ��������� �� ������� � ������������ �� ��������� ������� �� ��������� � ����� ����������� ������. ������� �� ������������ ������� �� �������� � ���� �� �������� �� ������ �� ����������, ������� ��������.\r\n�������� ������� �� �������� �� ������� ����� ����� � ������� �� �������� ������� �������, ������������ �������. �� ��� ���������� ����� �����.\r\n� ���������� ��� ���! � ����� ��������� ���� �� ��������. � ������ �� �!\r\n� ������� � ��������� �� ��������� �� ���������� � �������� ����������. � ������ � ��������� �� ����������. ������ �� ������� �� 30%. ������.\r\n� ����� �� ������, ���������? � ���� � �������� ���� ������������. � ���� ������ ���� �� ������ ������ � �� �� �������.\r\n�������� ����� �� ������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode93Chois2()
		{
			int currEpizodeId = 93;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��������, ���� �� �����������! � �����, ���� �� ������� �� ������� �����������. � � ����� ������\r\n� �������� ������� � ����� � ������ ������������ � ������� ���������, ����� ���������� ������, ��������, �� ��������� ������ �� ���������.\r\n� ������� ��, ���������! � ������� ����� ������� �����.\r\n� ������� ����������� � ������� ��� �������! ��������, ������ �� �������� ��������� �� ���������! �����, ������ �� ��� ������!\r\n� ������������ � ������ � ������ �� ����������. � ���������� �� ����� � ������ �������. �����߅ �� ���� �� ��������� ����������.\r\n� �������� �� � ��� ������ �� ���������! ��������, ����!\r\n� �� �����, ��������� � ����� ���� ������� ���������� ������� ������������. � ��� ����� ����� ���������. ������ �� �� ������� �� �� �������� ���.\r\n� �������, ������� ������� �� ��������� ������! � ������� ���������� �������, ����� �� ������ �����������. �������� ������� �� �������� �� ����� ����� � ������� ������� ������� ����������� ���������. �� ��� ���������� ����� �����.\r\n� ��������� �� ������� �������� � ������ �� ����������. � �������� �������� �� ����������. ���� �������.\r\n� ����� �� ������, ���? � ���� � �������� ���� ������� �� ��������. � ���� ������ ���� �� ������ ������ � ��� ��� ������, �� �� �������.\r\n� ���������� ��� ���������. ��������� ������� �� ���� �� �����. �������. ����������� � ������� � ����������� ������� ����������.\r\n� ������ ��! ������ ��! � ����� ����� ������������. � ������ ��! � � ������� ����: � ����� �����? �������, ������� � ����������!\r\n� ��������� �� ����������: ���� � ������� ����������. � ����������� �������� ��������� �� ���������.\r\n� �������� �� �� �������� ������! � ��������� �������.\r\n� ���������, ������� ��! � ���� �������� �������. � ������� �� �!\r\n�������� �� ���������� ��������� ���� ������, ������";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode94Chois1FourthChecksumEqual20()
		{
			int currEpizodeId = 94;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[4] = 20;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �������� �� ���������� ��������� �������� �� ���������� � ������� �� ������� ������� ����� �� ������� �� ������ �� ������. �������� ���� �� ������ ������� ��� ����� ���� � ��� �� ������ �������� �� ��������� ����, �� ������ ��� ���. ��� ����������� ���� �� ����� ������ ���� � �� ������ ������ ���� ������ �� ����� ��� � ���������� ������.\r\n� ���������� ���������! � ����� ����� � ������� �� ������� ��� ��������� �� ��� �����. ���� �� ��� ������ ���������, � ���� ���� ��������� �� ����� �������.\r\n� ������� ������� �� ����������� ��� ������ �� ������� �� ���������� ������� � �� �������� ��� ��� ������������ �� ����������. ������� ����������, �� ������� ������������� �� �� ��������� �������� � ������ �� �������� ����� �� ������ � ������� ������� ��� ���. ����� ����� �� ��������, ���� ������ ��������� ����������� �� � ��������� ������ ������.\r\n���� � ���� ��� �� ��������. ����� ������ �� ������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode94Chois1FourthChecksumEqual10()
		{
			int currEpizodeId = 94;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[4] = 10;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �� ����� ��������� � ���������� ������� ���������� �� ������� � ������ �� ������� ����. ������� �������� �������� �� ������� ������� ��� ������ �������� � ��� �� ������ �������� �� ��������� �� ����, ��� ������� ��� �� ������ ��� ��� � ������� �������� �� ������ ���������� ������ ��������. ���� �������� �� ������� �� ������� � ������ ���� ������ �� ����� ��� � ���������� ������. ������ ����������� ���-����� ��������, ������ �� ������� ��� ��������� �� ��� �������.\r\n� ������� ����� �� ����������� ��� ������ �� ������� �� ���������� ������� � �� �������� ��� ��� ������������ �� ����������. ������� ����������, �� ������� ������������� �� �� ��������� �������� � ������ �� �������� ����� �� ������ � ������� ������� ��� ���. ����� ����� �� ��������, ���� ������ ��������� ����������� �� � ��������� ������ ������.\r\n���� � ���� ��� �� ��������. ������� ����� �� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode95Chois1()
		{
			int currEpizodeId = 95;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��������� ���������� � ������ �� ������ ���� ������� ���������. � ���� ���� ��� �������. ����� �� ���������� ���������. ����� �� ����� ��������� ��� �������.\r\n����� ������, ��������� ��� ������ �������, �� �������� ��� ��������. ������� ��� ��� � ��������� � ���������� �� ���������. ����� ��� �� ������� �������� �� ���������� �� �������, ������ ���� ����� ������ ����� ����� ���� �� �� ������ ����� � ��������� �� ����������� ���� �������.\r\n� ������ � ����� � ����� � ����� ������ �� �������� ��������. � �������� � �����������\r\n�� ���������� ���� �� ��������� ������ ����� ������ �����, ����� �� ������� � ��������� ���� ������ ��� ����� �����. ������ �������� � ������� ����������� �� ������� � ����������� ���� � ���������� �� �������� ������ �� ��������.\r\n�������� �� ��������� � ����� �� ����� �� �� ������� ���� �� � ����� �� � �������. �������� �� ����� � ���� �� ������ �� ����� �� ������ ����, ������� �� ������ ��������� �� ������ ��.\r\n�� ������� ������ �� �������, ������� �� ���� ����� ��������� � ������������. ��������� � ������� �� �������� �� ����� ���������� � ����������� ����������. ������ �������� �� ������; ���������� ��, ����� �������� ���� �� ��������� � ���� ���������� ��� � ��������� � ������ � �����. ��������� �� ��������� �� ����������� �� ������ ����, � ��������� ����� ��� �������� ���� ���� ������������� ����� ������.\r\n��� ������� ����� �� ��������� ���� ���������� ������, �� ���������� ���������. ������ ��� ��������� �� ������� � �� ������ �� �� ������������ ��� �� ����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode96Chois1()
		{
			int currEpizodeId = 96;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode97Chois1()
		{
			int currEpizodeId = 97;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ������ ��� ������ �� ���������� ��������� ��������������, �� �� �� ���������� ����� � ����������� �� ���������, ������ �� �������� ����� ���� �� ���������� ��.\r\n������ �� �������� � ����� ��������� �� ������� �� �������� � �������. ������� ��, ����� � �� ���� �� ������������ ���� ����������� � ������ �� ������� �� ��� �����, �� ��� �������� �������� ����������� ������� ����� �� ����� ������ ������, ��������� �����. ���� �� ���������, �� ���������� �� ����������� �� ������������, �� �� ����� ����� ���������, � � �������������� �������� �� �� ��� ���� ����� ������. �� ���������, �� ����������� ������� �� ������� ��� ����� ���� �������������� ������������ �������� � ������� ����������� ��������� MAG 77, ������� ������������ �� �������� ��������. ������ � � ����������� � ����� ����� �������� �������� �� ������� � �����, �������� � � ����� �����.\r\n��� ��� ������� �� ������� � ����. �� ���������������� ����� �� ��������� �� 100 ������ ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode97Chois2()
		{
			int currEpizodeId = 97;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� �� ���������� �������� ������� ���� �������� �� ���������� � ��������� ������ ������������ ����� �� ���������. ����� �� ������� �������� �� �������� ����� �����. ������ � �� �� ����������� 300 �����, ������ ��������� � ������������ �������� � ������� ����� ������; ����� ��� � ����� ����� �������� ��������, � ������������ �� ����� ����� �� ��������. �� ���������, ����� ��������� ����������� ��������� MAG 77, �� ��������� ��� ����� ���� �������������� ������������ ��������, ����� ���� �� �� �������� � ���� �������� ��������.\r\n������� ������ ��������, �� ��������� ��������� ��� ��������. ������ ����� ����������� ��������, ����� �� ����� ������������� ���, ����� �� �� �����.\r\n� ����, ����� �� �� ������� � ����������� �� ��� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode97Chois3()
		{
			int currEpizodeId = 97;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� �� ��������, ��� �� ����� ��� ���� ������� � ����� �� ������ � �������, ����� ����� �� �� ��������� � �������. ������� ��, ����� � ������� ������ �� ������������ �� �� ���������� ����������, �� ����������?\r\n����� � �� ���� �� ������������ ���� ����������� � ������ �� ������� �� ��� �����, �� ��� �������� �������� ����������� ������� ����� �� ����� ������ ������, ��������� �����. ���� �� ���������, �� ���������� �� ����������� �� ������������, �� �� ����� ����� ���������, � � �������������� �������� �� �� ��� ���� ����� ������. �� ���������, �� ����������� ������� �� ������� ��� ����� ���� �������������� ������������ �������� � ������� ����������� ��������� MAG 77, ����� � ������ ������������ �� �������� ��������. ������ � � ����������� � ����� ����� �������� �������� �� ������� � �����, �������� � � ����� �����.\r\n��� ��� �������� ������� � ����. ����� �� ������ 300 �����, ����� ����� �� �� ���������.\r\n�� ������ �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode98Chois1FirstChecksumLess20()
		{
			int currEpizodeId = 98;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 19 + 5;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����� ����, ���������, �� ��� ���������� ������� � ������� ����� ���������. � �������� �� �� �������� ������� ������, �� ���� �� ������ ��� �� ���������. �, ���� �, �������� ���!\r\n��������, ������� � ��� �� ��������� ������, �� �������� � ������ ��. ������� ��, �� ������ � ������� ���������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode98Chois1FirstChecksumMore20()
		{
			int currEpizodeId = 98;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 21 + 5;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode98Chois1FirstChecksumEqual20()
		{
			int currEpizodeId = 98;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 20 + 5;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1] - 5;
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � �������, ���������! � ������� ��������� �������� ����� �������. � �� ������� ������� �� ������������� ������.\r\n���� �� ������ ���� �������, ��������� �� �������� ����������� � ��������� ������� �������� �����.\r\n� ������ �� ����� � ���� �������-����?\r\n� ���� � ��������, �� ����� �� �������� ���� ���������� ������������� ����������. ���� �� �� ���������� ���� �� ��������� �����, ����� � ����� ��. ������� � ����� ������������� ��� ���� �� ���������� ��������������� ������� �� �����. ����������������� �� ��������� � ����������. �������-���� �� ����� ����� �����, �������� ���� �� ����� ������.\r\n� ����, �� �������� ����� �������-���� �� ����� ������. �� �� ����� ������! ���� � ���� ������������. �� ������� ����� � ���� ���� ���������, �� ���������� ������. ��������� ������� ���� ������� �����������; ������������� ����������, �� �� ����� ������� ������ ��������. ������� � �� ������� ��������� �����. �� ��������� �� �������, � ����� �����������. �����, ����������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode99Chois1()
		{
			int currEpizodeId = 99;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������������ �� ����������� � ������������� ���� ��������� �� ������� ���� ��� ���. ����, ������ ���� ������� ���� �� ������� �� ���������� ������, � ����� �� �������� �������� �� ������ � �� ����������� ���������� ������ �� �������.\r\n� � ����, � ������ �� ���������� ����� ��� ������ �� ������� ����� � �� ����� ��� � ����� �����������.\r\n�����: ������� ������ � ��� ��� ������ � ����. ���� ���� ��������� ������� �� �������, ������� ������� ������� � �� ��� ������ ��������� ����. � �������, �� �� ���������� �� ������� ����. ����� � �� �������� �������� ���-����� �����.\r\n�����: ��������� ����� � �������� �����, ��� �������������, 47 ������������ ��������, ���� �������� �� �����. ����� �� � �� ��������� ������� ���� ������� � ��������� ������� � �� ����������� ������������� �� ��������� �����, � ���� ���� �� ��������� ������� ��� ���������������.\r\n�����: ������� ����� � 300 ����� � ����� ���������. ���� ����� � ���-����� ���������. �������� �� � �� ��������� ������� ���� ������ ������ �� ������� � �� ��������� ���������� ������ �� ��������.\r\n� ��������: ������������� ����� � ���� ��� ��, ������������ � ����� ����� �� ���������. ������� ������ � ��������� ����� � ��� �� �� ���������, ���������� ��� ��������������� � �������������.\r\n� ��� ��������� �����������, �������: ���-����� � �� �� ������ ����������������. ����, ��� ������������� �� ���� ���, ���� �� ��������� ������ �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode99Chois2()
		{
			int currEpizodeId = 99;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����, ����������� ��� �������� �������� �� �������� � ���� ����� ��� ���� ������������� �� ��������� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode100Chois1()
		{
			int currEpizodeId = 100;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ������ ������� ����������! � ��������� ���������. � ������ �� �������� �����!\r\n���� �� ������� ������� ����� ����� ���������� �� ����� ��������. � ������� �� ���������� ��������� ����� �� ��������������, ������� � ���������������� �� �����������, ���� �� ������ � ������, �������������� � ���� �� ��������� �������.\r\n� ��������� ������� ������������ ��������� � ������� ����������. � ����������� ������ �� �����. �������� ���������.\r\n� �������� �� � ������ �� ���������� ��. ���������� �������!\r\n� �������� ������� ������������ ���������. ������� � �����������.\r\n� ��������� ���! ���������, � ����� �������. �������� ������. ���� ���� �������� �������!\r\n� ��������� ������ �� �������� ��?\r\n� ���� ����� �� ���� �� ��������. ��������� �����������.\r\n� ����������� ������� ������������ ���������. ����������� ���������.\r\n� �������� ������� ������! ���������� ������! ����!\r\n����������� ������ ������ �� ������� ���� ������ ��. ������� �� �������� �������� � ��� �����, �� ��������� ����� �������.\r\n� ����� � ��������, ���������! � �������� ���� ����������� �������� ������������, ���� ������� �� �������� �������.\r\n� ���� �� �������������� ��������� � �������� ����������. � �������� ��������. �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode100Chois2()
		{
			int currEpizodeId = 100;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �� � �������� ����� ��� ����� ������ ���������� �� ���������� ���.\r\n��������� ����� � ������������ �� ������ ���������� � ��������� ������. ���� �������� � ����� ������������� �� ����������, ���������� �� �������� ���������� ��������� �������.\r\n������ ����������� ���� ������� � ���� � ����� �� ����� ���� �� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode101Chois1()
		{
			int currEpizodeId = 101;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� ������ �� �������� ��� �������� � �� ����������� ���� ����� �� ���� ������, ����� ������. ���� ���� ����� ����� ����������� �� �������� �� ����������� �� ������. ������ ���������� ���� ������� ����, ��� ��� ��������� � � ����� ���� � ����� ������� ������������ �������.\r\n� ����� �� ���� �� ���������� � ���: �������, ���������, � ����� ������� � ������� �� ����������� �� ���������. � ���� ���� ����� �������.\r\n� ����� ��������-��������! ������������� �����!\r\n� ����� � ��������������. �������� ������������� �� �������. ���������� �� ��� ����������.\r\n� ��� ��������� ���! �������� 500 �����. ������� 900 ����. �������� �� ��� ����������. ������ ���������� ������!\r\n� �������� ��������! ������� �� ��� �������!\r\n� ������� ������� ���������. ��������! � ������ �� � ������� �����. � � ������ �� �������� ���. ������� ��!\r\n� ������� ������! ���� ���� ����� ������� � �� ������ ����� � ����������.\r\n������ �� �������� ������ �������. ������� � �������� ��������� � �� ������ ����� �� ������� ����� �� ����������.\r\n�����, ������ �� ����� ���� �� ������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode102Chois1()
		{
			int currEpizodeId = 102;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode103Chois1()
		{
			int currEpizodeId = 103;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����� �� ������, ������ �� ����! � ������ ������� � ���� �������� ��������, ������� ������ ��� � ������� ����� �� ������. ���������� ����� ������� �������� ����� � ���� ������ ����� � ���������� ��������, ������� �������� �� ������� ������ �������.\r\n� ����� ����! � ������ ���� ���� � ���� �� �������, ������� � ����� �����. ����� ���������� ��������� ������ ������� � � ������ � ������. ������� ������� �� ������� ����� �������� �� ���������� ��������, � ����� ������������ �� �� ������� �����������.\r\n����� �������? ���� �� �������� �� �������� � ������� ����� ������ � �������� �� �������� ���� ��-�����, � ���� � �� �� � ��������. ��������� � ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode103Chois2()
		{
			int currEpizodeId = 103;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��! � ��������� ��������� � ������ �������� �� ������. ������ �� �� ������� ������ �� ���������� ��, �� ���� �� ������� �� ����� ���������� � ������� �� ������������� ����� ������ �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode103Chois3()
		{
			int currEpizodeId = 103;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����������� ��! �������! � ������ � ������ ���� �� �������� ��������� �� ������. � ���������� �� ��� ������!\r\n��� ������ �� �� ��������, ������ �����, ���� �� ������� �� ��������� � ����������� �� ����� �� �������� ���������. ������� �� ������� ��������� � ������� �� ���������. ���� ���� �� �����������, � ���� �� �� �������, ������ � ������� ���� ���� �� ��������� �����.\r\n�� ���������, ������� ���� �� �� � ������� ����, �� � ������� � ���������� ������� ������� � ��������� �������� ����������, � ���-������� � � ������ �����. ��� �� ������ �������� �� ����������� �� ���� �������, ��� �� ������� ������� �� ������ � ��������� ���� �� ����.\r\n� ������������ �� ����������� � ������� ������� ������� � ���� �������� ������������, ������� �� ������� ��. ������������ ������� � ������ � ��������� ���� �� �� �������, �� � ������ �� ����� ����� ��� ���������. �������� �� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode104Chois1()
		{
			int currEpizodeId = 104;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[5] = 10;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ����������� �� ���� �� �������� ��� �������� � ���������� �� ������� ��������� ������������. ������� ������ ���� � �������� ������������ ������ � ����������� �� ������ ������� ��������� �� ������� � ����� �������. ����������� �� ������������ ���� ��������, ��� �� ������� ������� �� �� ��������� �� �������, ������� �� ���� �������� � ���� �� ������ �� �� ������ ��� �������.\r\n������ ������������ ��, �� �� ������������� �� ���� �� ��������� ����, ����� ��� �� ���� �� ����. �������, ����� ������������ ����������� ����� ������� �� ����������� � ������� ����� �� ������� ����� �����. ������ ������� ������ ���� �� ���� ���������� �� ���� �� ��������, �� ���� ��� ������� � ������ �������. � ���� ����� �� �������� ����� ���-��� ������� �� ������������.\r\n����� ��������� � ������ �������. ���� �� �������?\r\n���������� ���� �� �������� � ���� � ���� �� ������� ���������. ��� �� ��������, ���������� ��� ���������� ������� � �������. ������ � 50 �� 50.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode104Chois2()
		{
			int currEpizodeId = 104;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[5] = 10;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� ������, � ���� ���������� � ����� �����, ��� ������ �������� �� ����� ����� ��������� �����. ���� �� ������� ������� ��������� ������ �� ���������, �� ��� ��� �� ��������. ��� � �������� �� ��������� ���� ������������ ����������� �� ������� ����� ����� ����� ����������������. ������� ��, ������� ���� �� ���� �� ���� ����������� �� ������ ������� ��� � �� ���� � ��������� �� �� ��������. �����, �� ���������� ��������� ������ ���� �� ���� ������� ������������ �������� � ���� ������� �� ������ ������� �� �������� ���� ������� �� ��������, � ���� �� �������.\r\n��� ��� ����� ����� �����, ���� �� �������!\r\n���������� ���� �� �������� � ���� � ���� �� ������� ���������. ��� �� ��������, ���������� ��� ���������� ������� � �������. ������ � 50 �� 50.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode104Chois3()
		{
			int currEpizodeId = 104;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[5] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ �� �������� � ������ ������� ��������� ����� ������, �� �� ������ �� �������, �� ���� �� �������� ���� �����. ������� ������� ���� �� ����������� ���� �� ���� �� �� �������� �������. ������ � �������������� ��� �� ������� ������, ��� ������ �� �� ��������, ����� �������� ������.\r\n������ ������������ � ��� ������ ����� �������� �������� ��� ������ ������. �� ��� �� �� ��������� �� ������� ���������� ��������� � ���� �� ������� �� ������� �������, �� �������� � ������� ������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode104Chois4()
		{
			int currEpizodeId = 104;
			string currentChois = 4.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[5] = 0;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 1;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� �� �������� ������� ��, �� ���������� ��� ������������ �� ������ � ��� � 300 �����. ������ �� ��������� � ������������ ����������; ����� ��� � ����� ����� �������� ��������. ������, �� ���� ����������� �������� ����� ���� �� ������ �� �����.\r\n��������� �����, ����� � ����������� ������ ���� ������� �� ���������. �� �� ������� ������������� �� ����� ������������, ���������� ����� �� �����. ������������ ������������� � ������ ���� �� ������� ������������, ���� �� ������ ��������� �� ���������, �� �������� ���� ����� ���.\r\n����� ����� ������� ����� �������, ����� ���� �������� �� ���������� ��� �� ������� ������ ����������� ������ �� ����������� ����� ������� � ����� ������. ����������� � �������� �� ����������� ��� �������� ��, ������������� �� � �������� �� ������ ��� ��-����� ���-������� �� �����������.\r\n� ����, ����� � �� ��������, ������� �� �� ������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode105Chois1()
		{
			int currEpizodeId = 105;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ���������� �� �� ����������� �� ������� �� �������� � �� ������� �������. ���� �� ����� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode106Chois1()
		{
			int currEpizodeId = 106;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ���� �� ����� ��������� ��� ������ ���������. ������ ������� ���� �� �������� �������� �� ����������� �����, ����, �� ��������� ��������� �� ������� �� �������� �� ���� ���������� �� �� �������� � �� ������� ����������. ���� ������ ����� �������� �� ���������, ���� ���� � ����������� � ���� �������� � ���������� �� ������� ����� ����� �� ������ ����������� �� �� ������ ���.\r\n� ����� �� ������, ���������? � ���� ���� ���� �� �����������.\r\n� ���������� ����������! � ����, ���� �� � ���� ������� �������! � �������� �� � �� ��������.\r\n������ ������ ���� ��� �������� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode107Chois1()
		{
			int currEpizodeId = 107;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������, ���������� ����������! � ��������� ����. � ��� ��� ��������� ������� � ������� �����. ������! ���� ��� ���!\r\n� ��������� ���� � ����� ������ ������, ������ �� ������, � ��������� � �������� ������ ����������, �� ��������� �����, ���� ����� �� ������� ���������. �������� �������� � ���������� � ���� ���������.\r\n�� �������� �� ��������� ���, ���� ������, �������, ���� ������������� ��������. ����� � ������ �� ���, � ���������������� ����� ��������, ��������� ��������� �������� �����, �� ������� �������� �������� � �������� ������� �� �������� ������. ������� �� ���, ����� ��-�����, �� ������� ����� ������� ����� ������ ������ � ���� ����� �������� ��.\r\n� ���� ������ ��� ������ ��������� ������� �� ������� ���������� ���������� � �� ���� ����� �� ������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode107Chois2()
		{
			int currEpizodeId = 107;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� ����� �� �� ��������! � �������� ���� � ��� �� �������� �� ���� ����� ���������.\r\n�������� ����� �� ���� ���� �� ��������� �������. ���� ������� �� �� � ��������� ����� ���� ����� �����, ����� ����� �������� ���� �������� �������. ����������� �� ��������� �����, ���� � ������� ��������� ����������. ����� ������ �� �������� �� ����� ���� � ������ ������ �� ������ �������.\r\n� ���� ����� �������� �� �������� ��� ��-����� � ������������ ������ �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode108Chois1()
		{
			int currEpizodeId = 108;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� �� �� �������� ������, �������� �������� � ��������� ���������� �� ����� � ������ �� ����������� �� ���������. ����������� ������ ����� ����� ����� �������, �� �������� ��� ��� ������ �� ������� ������� � ������ ����� ������ �� ������ � ���. ������� �� ������� �� ������� ���� �� ����� ����� �����������, �������� � ��������. ����� �� ���� ����� � ��������; ����� ���� ���� �������� ��������� �� ������ �� � �������� �� ���� �� ���� �������� ������� � ���� ������ ���������� ������������ ��������� �� ������. ������� � ����� ������ �����. � �� ���� ����� �� �� ��������.\r\n���� ���� ���������� �������� �� ������� ������� � ����� ������ �� ����� �� ������� �� ����������� �� ������� �������� ��������� ��� ���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode108Chois2()
		{
			int currEpizodeId = 108;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����������� ����� ��� ����� �������� �� ��-����� �������� � � ����� ����� ������ �� ������� �������. ���������� � ������� ����������, �� ������� �� �������� � ��� ������ �� ������� �������� �� ������������� ��������� �������, �� �������� �� �������� � ����� �� ������.\r\n� ��� �� ��� ��, �� ��������? � ���������� �� ����, ���� ������� ������: � ����� ���������, ���� ���������� � ������� �������! ��������� ��������, ��-����� �� �� �������� � ��������� �������.\r\n� �� �� ��������, �� ������� � ������ �� ��������� ����������� ����� ��� ����� � ���� ������� ��������, �� ����������. �������� ������ �� ��������� ����������� ���� ��� ������� ��������� ������, �� ������� ��������.\r\n����� ����� ��� �� ������� ��������� �� ������� �� ����� � �������� �� �������� �����. ���� ���� �������� �� ��������� ������� � ������������ �� ���������, �� ������ �� ������ �� ����� �� ��������� ������� � ���������. ��������� �� �������, �� �� ������ ����������� �� ����� � ���� �� �������, �� ��� ��������. �� ������� �� ������� ��������� ������ �� ������������ �� ����� � ���� �� ������� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode109Chois1()
		{
			int currEpizodeId = 109;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��! � ��������� ��������� � ������ �������� �� ������. ������ �� �� ������� ������ �� ���������� ��, �� ���� �� ������� �� ����� ���������� � ������� �� ������������� ����� ������ �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode109Chois2()
		{
			int currEpizodeId = 109;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ ���� �� �� �������� � ���� �� ��������� ������ ������ �������� � �������� � ������ ����� �������� ��������. �������� �� ������� � ��������� �� ������ �� � �� ��� �������� � ������ ������� � ��������� �������.\r\n�� ���������, ������ ����� �������� �� �������� ����� ������� �� � ���� ������� �������� ���������� �� ����� �������, ������� ����������� �������:\r\n� ������� � ���������. �������� ����.\r\n� ����������� �� �������! � ������ ��, �� ����� �����. ������������ � ������ �� ����� ��� �� �������� ������ ��� �� ���������� ������� �������, ����� �� �������� �� ������� ������� � ��������� � �������� ��������.\r\n� ������������ �� ����������� � ������� ������� ������� � ���� �������� ������������, ������� �� ������� ��. ������������ ������� � ������ � ��������� ���� �� �� ������, �� � ������ �� ����� ����� ��� ���������. �������� �� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode109Chois3()
		{
			int currEpizodeId = 109;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����������� ��! �������! � ������ � ������ ���� �� �������� ��������� �� ������. � ���������� �� ��� ������!\r\n��� ������ �� �� ��������, ������ �����, ���� �� ������� �� ��������� � ����������� �� ����� �� �������� ���������. ������� �� ������� ��������� � ������� �� ���������. ���� ���� �� �����������, � ���� �� �� �������, ������ � ������� ���� ���� �� ��������� �����.\r\n�� ���������, ������� ���� �� �� � ������� ����, �� � ������� � ���������� ������� ������� � ��������� �������� ����������, � ���-������� � � ������ �����. ��� �� ������ �������� �� ����������� �� ���� �������, ��� �� ������� ������� �� ������ � ��������� ���� �� ����.\r\n� ������������ �� ����������� � ������� ������� ������� � ���� �������� ������������, ������� �� ������� ��. ������������ ������� � ������ � ��������� ���� �� �� �������, �� � ������ �� ����� ����� ��� ���������. �������� �� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode110Chois1SixChecksumEqual20()
		{
			int currEpizodeId = 110;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[6] = 20;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� �� ���������� �� ��������� � ������������ �� ������������ � ���������, �� �������� ������ �� ������ � ����� ���� �������� �� ����� ���������� ������ �� �� �������� ������������ �� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode110Chois1SixChecksumLess20()
		{
			int currEpizodeId = 110;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[6] = 19;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� �� ������ �� ��������! � �������� �� �����������. � ����� ��� �� ������! �� �� ������� �������� � �� ����������!\r\n� ��� � ������ �� �������� ������� ������� ������ �� ������� ��� ���� �������, ������ � ���� � ��� �������. �� ����� ��������� � ����������� �� ���� ������ ����������, �� �� ������ �� �� ��������� ��� � ����������. ������� ������ �� ������������ �� ��������, ������� ������ �� �������� � ��������� ���������. �� ����� ��������� �� ��������� ��������� �� ��������� ����� ������������ ������������ ������� � �������, ����� � ����� ��� � ����������� � ����� ����, ���. ����� ������, ���� ������ ������ �� � ���� ����� ���� �� ������� ��.\r\n������ �� � ����� ��������ѓ �� �������, ������� ��� �� ������ �� �������� � ��������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode110Chois1SixChecksumMore20()
		{
			int currEpizodeId = 110;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[6] = 21;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� �� ������ �� ��������! � �������� �� �����������. � ����� ��� �� ������! �� �� ������� �������� � �� ����������!\r\n� ��� � ������ �� �������� ������� ������� ������ �� ������� ��� ���� �������, ������ � ���� � ��� �������. �� ����� ��������� � ����������� �� ���� ������ ����������, �� �� ������ �� �� ��������� ��� � ����������. ������� ������ �� ������������ �� ��������, ������� ������ �� �������� � ��������� ���������. �� ����� ��������� �� ��������� ��������� �� ��������� ����� ������������ ������������ ������� � �������, ����� � ����� ��� � ����������� � ����� ����, ���. ����� ������, ���� ������ ������ �� � ���� ����� ���� �� ������� ��.\r\n������ �� � ����� ��������ѓ �� �������, ������� ��� �� ������ �� �������� � ��������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode111Chois1()
		{
			int currEpizodeId = 111;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������, ���������! � ���������� �� ������������. � �� ��� �� ������ �� ���������?\r\n� ��� ��! � ������ � ���� �� �������� ��������, �������: � ���� �� ����� �� �� �������.\r\n���� ���� ������� ������ ��� ����� �������� � ����� �� ������������ ������� � ���������. ���� ��� �� ������ �� ���������, ������ ����� ����� ��������� ������. ����������� �� ����������� �������� ������ ��������� � �� �������� ����� ����� ���. �������� �� ������ � ��� ���������� ������� ����� � ��� ������ ������. ��������� ����� ��� � ���������� �� ������� ������, �� �� ���� ������ � ������� ��� ����. �� ������� �� ��������� ������� ��������� ����� �� � ����� � ������� �������� ���� � ���������� �� ����� �����������.\r\n� ����� �� �� ������! � ������ ������� � ������ ����� �� ��������� ��� ������.\r\n�������� �� � ��������� � ������ �� ����� ������ �� ����� � ���������� ����� �� ������� �� �������. ���� �� �� ������ ���� �����, ����� �� ������� ������������ ������� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode112Chois1()
		{
			int currEpizodeId = 112;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ������ �� ������������ ���� ����?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode113Chois1()
		{
			int currEpizodeId = 113;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������, ������ ����� �� ��������� �� �������� ������, �� ���� �� ������ �� ������� ����� � ����� ������� ��� ��� ���������� �� ����� �������. ����� ����� �� ����������� �������� � ����� ������� ���������� �� ���� �� ������ ������ ����������. � ������ ������� ���������� �� ����������� �� ���������, �� ����� ���� ��� � ������ ����� �� ������ ��.\r\n���������� ������, �� �� ���������, �� �� ������� ���� ������� ���������, �� ���� ������� ������ �� �� ����� ������� � ���. ����������� �� ������� ������ ����, ������� ������ �� � ����� ������� �� �������, ������ ���������, �� ���� � ������ �����.\r\n���� ������ �� �������� ���� �����:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode113Chois2()
		{
			int currEpizodeId = 113;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������, ������ ����� �� ��������� �� �������� ������, �� ���� �� ������ �� ������� ����� � ����� ������� ��� ��� ���������� �� ����� �������. ����� ����� �� ����������� �������� � ����� ������� ���������� �� ���� �� ������ ������ ����������. � ������ ������� ���������� �� ����������� �� ���������, �� ���� ���� ���� ������� ��������. ��� ������� ������� � �������� � ��� � �� �� ���� ��� �� ������. ���� ���������� ��� �������� ��������� �� �� �������, ���� � �� ����� �� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode113Chois3()
		{
			int currEpizodeId = 113;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� �������� ��������� �� ��������������� � ���� �� ��������, �������� ��� ����. �����, ����� �� � �����������, ����� ���� �����, �� �������� �� ������� ���� ������� ���������, �� ���� ������� ������ �� �� ����� ������� � ���. ����������� �� ������� ������ ����, ������� ������ �� � ����� ������� �� �������, ������ ���������, �� ���� � ������ �����.\r\n���� ������ �� �������� ���� �����:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode114Chois1()
		{
			int currEpizodeId = 114;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����! � ��������� �� � ��� �������� ����������� � ����� ����� �� ��������.\r\n���� ������ ����������� ������� �� ������ ������, ��������� � ����������� � ��� ���������. �� �� ������ ������� �������� ����, ����� ��� ����� ������� ����� � ������� ����� �� �����������. ������� �������� �� � ��������� �� ���� �������� �������� �������� �� ������ �������� ������ �������. ���� ����������� ��������� ���� � ���������� � �������� �������:\r\n� ������� � ��������� ������� �� �����������. ������������� �������� ������� �� ������. ���������� �� �������� ���� �������� ������. ������� ������ �� �� ���������!\r\n� ��������� ��! �������! � ����� �������� � ������ � ������ �� ������ �����.\r\n� �����, ���������� �� � ���������! � ��������, ������ �� �������� �����. � ���������� ����������! ����� ������ �� �� ������!\r\n�������� �� � ������ ���� ��� ������� � ��������, � ���";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode114Chois2()
		{
			int currEpizodeId = 114;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �� ���������! � ����� �� ���������� �������� ���������. � ������������ �� ��������! ������� ���� ���!\r\n���������� ����� ������������, �������� ������ � ��������� ��������� �� ���������������� � �� ������� ������� �� �������� � ���, ��� �� ������� ���� ���� �� ������ ��. ����� ���� ������� �� ������ ������, ����� � ����� �������� ����. ������� �� ����������� �� ��������� �� �� �������. ��������� �� ������� ����� � ��������, �� ����� ������ ����� �� ����� ���������.\r\n� �������, ��������� ����������! �� ���������� �������� �������! ������ � ���� �� ���� �������.\r\n����� �� ��������� ���� � ���� �� ������� �� �� ������������, �������� ������������� ���������� � �����. ���� ���������� ��������� �� ��������, �� � ���������� �� �� ������� ����� ������������ �� ��������.\r\n� ���������, ���������� ������ ����� ������� � ������� ����� ������! � ������ �� ���������� ���������. ������� ��� ���� ������� �� � �����, ������ ���������!\r\n� ����, ����� �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode115Chois1()
		{
			int currEpizodeId = 115;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode116Chois1()
		{
			int currEpizodeId = 116;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� ��������� � �������� ������ � ��������� � ���� ����� ������� ������ ��������, ����� �� ��������� ���� ���. �������� �� � ����� ������ �� �� ��������, �� ����� ��������� ����� ��� ��-����������� � ��� ���� �� ���� �� ���������, ������ �� ���� �� ������������� �����. �������� ������������ � ������� ������� � �������� �� ��������� �� ����� � ����������� ��. �������� � ������������ ��������, �� ��� ��� ����� �� ��������, ������� ��� �� �� ��������, ��� �� ������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode116Chois2()
		{
			int currEpizodeId = 116;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ������ �� �� ��������� ���������� � ���� ������� ������, ����� �� ����� �� ������������ �� �������, ������� ����� ��������� ������ �� ��������, ����� �� ������������ ����� �� �������. ������� �� �� �������� ������ �� ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n���� ��� �� ���������� �� ������� �� ����������, ����� �� �������� ��� ��������� ������ � ��������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode117Chois1()
		{
			int currEpizodeId = 117;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� �� � ���������! �������! � ����� ����� � ��� �������� ����������� ������ �� ������������. ������� ����� ������� �� ����������� �����������. ���� ������� �� ����������� �������� ����������� ��� �� ������������� ��������� � ��������� ���������� ������� �� ����������� � �������� �����.\r\n��� ����� �� �������� � ������, �� ��������� ������� ��� ������ � ��� ��� ������� ��������� ������ � ������ ������ �����, �������� ��������� �������� ������� � ������������ ����.\r\n�������� �� �� �����, �� �� ������ �� ����������� ������������� ������� �������. �� ���� �� �������� ��������, �� �� ������ ������� � �� ������� �� ������ �� � 300 ������ �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode117Chois2()
		{
			int currEpizodeId = 117;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������������ �� ����� � ������ �� ������, ���� ���� ���������.\r\n� ������� ���� ���������. ������� �� ��� ������������ �� �����������.\r\n� ���� �������� ������������, ��������:\r\n� ��������� zzzz, ���� zzzz� ��������� zzzz� ��� ������ ������� � ���� �������� �����������, �� ������� �� ������������ �������.\r\n��������� ����� ������ �� �����������, �� �� ������������ �������� � ������������ �� ������ � �� ��������� ����������� �� �������� ������. ����������� ��� ��������, ��� ��� ��� �� ������������ ������� �������, ��� ���� ���� �� �� ������.\r\n� � ���� ����� � ��������� ���� �� �������� �� ���� ��������� ���� ����� ��������� �� ������� � ����������������� ������. ����� �� ������, �������� �� �������� � ��� ������ ��������� �� ����������� � ���� ������� �� ����� �� �� �������� ���� �� ����������� ����� ���� ��� �������.\r\n� ������ ����� �������� �� ��������� �� ����� �������, ���������! � �����, ������ ���������� �� ��, ���������� �� ����������������� �������. � �� �� ���� �� �������� � ��������� �� ����� ���������� ���������. ���� ��������� ������� �� 30 ������. ������ �� �� ������ ����� �� �����, ��� �� ����� � ������� ��� ���� �������?\r\n� �� �� �������� �������, ��������! � ������� �������� �������� �������� �� ������� ������; ��� � �������� � ��������� ������ ������� � �� ���� �� ������ ������� �������. � ����� ���� �� ������ ���� ����� ���������, � ��� ������ �� ������� �� �� ���������.\r\n� ���� �� ��, ���� �� ����� �������������� ���? � ������ �� ���������. ��� ���� ����� ������� ����������� ��������� � ���� �� ������� �� �� ������ ����.\r\n� �������� ���� ������� � �������������. ���� ������?\r\n� �������! � � �������� ������������! � ������ �� ���������.\r\n� Zzzzz� �� �����! ��������� zzzz� �����! � ����������� �� ��������� ��. ������� � ���������� ��� zzzz� ���������!\r\n� ���� �� ����������� � ������� ������� �����������. � �������� �� ����������� �� �� �� �������. �������, ������ �� �� �� �������� �� ��������! ���� ����� �� ������. � ���, ��������, ��������� ��� �� ��������, �� ��� ��������� ������������� �� ������ �� � ������ ����� �� ��-������ �� ������ ���.\r\n������ � ��������� ������ �� ���������, ��� �������� �� �� �������� ���������.\r\n������ �� �� ����������� ������ �� ��������� ������ ������ ������ ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode118Chois1()
		{
			int currEpizodeId = 118;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� � ������ ���������! � ������ ���������, ���� �� ������� �� �� �� �������.\r\n������������ � ������ �� �� ������ �� �������� ��� ���������� ������ ��� ������ �����, ����������� ������� ��� � ���� �� ������ � ����������������, � �������� � ����� �����, ������� ��������� ������ �������. ��������� ����� ������� � �� ���������� ������ � ����� ��������� ������� �� �������� � ������� ������ �������, ����������� �� ������ ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode118Chois2()
		{
			int currEpizodeId = 118;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� � ������� ��������� � ������ ���������, ���� �� ������� �� �� �� �������.\r\n������������ � ������ �� �� ������ �� �������� ��� ���������� ������ ��� ������ �����, ����������� ������� ��� � ���� �� ������ � ����������������, � �������� � ����� �����, ������� ��������� ������ �������. ��������� ����� ������� � �� ���������� ������ � ����� ��������� ������� �� �������� � ������� ������ �������, ����������� �� ������ ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode118Chois3()
		{
			int currEpizodeId = 118;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� � ����������� �����������! � ������ �� ��������� �������� ��������.\r\n��� �� �������, � �� ������ �� �������� ��� ���������� ������ ��� ������ ����� ����������� ��� � ���� �� ��� �������� ����������� ����������� � ��������� � �������� �� ������� �������. ���������� ������� �� ������ ���������� �� ��������� � � ����������� ���� �� ��������� � ��������� ��� ��� �������. ����� �� �������� ������� ������� ���� ����������� �� ������ ���� ������ ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode118Chois4()
		{
			int currEpizodeId = 118;
			string currentChois = 4.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������� ��� ����� ��� ������, �� ��� �� �������� ������� ������� �������������� �������.\r\n�������� �������, �� ����� ��������� �� �������� �� ������, ������������ �� ����� ���������� �� ����������� �� ���������. ���� �� �������� ������� ��������� �� ������� �� ���������� � ���������, ������� ��������� �� �������������.\r\n���� � ���� ��� � �� ������ �� ������� � ����� �� �� ������ �� ������ ��������. � ����� ���� ����� ������ �� ���������, �� ����� ��� ���������� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode119Chois1()
		{
			int currEpizodeId = 119;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����� ������, ��������! � ������ ��������� � ���� �������� ������ ��������, ��� ������� �� ��������� �����. ��������� �� �������� �� ���������, �� ���� ����� �� �� ��������� �������� ������� �� ������������ ��� ����� ��������ѓ; ���� �� ������� ������� ������� �� �� ������ ������� �� ������. �� ��� � ��������� ���� ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode119Chois2()
		{
			int currEpizodeId = 119;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �� ���������������� ������� ����� ������� �������� � ���������� �������� �������. �������� �� ������� ������ ������ �� ������� � ������� ����� ��������� ���� �������� ��.\r\n� ������� �� �� �������� ��� ������! � ������� �������� �������� ��, ���� �� ����������. � ��, ���� �� �� ����! � ������� �� ����� �������� ���. � ����\r\n����� ������������ ������� �� �� ��������, ������ ����� �������� �� ���������� �� �����������. ������� ������ �� ����� ����� �� ������� ����� � ����� �� ������� ��� ��������� ������.\r\n������ �� �� ��������� ������ �� ��������� ������ ������ ������ ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode119Chois3()
		{
			int currEpizodeId = 119;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode120Chois1()
		{
			int currEpizodeId = 120;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode121Chois1()
		{
			int currEpizodeId = 121;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��� ���, ���! � ������ �� ���� �� �����������. � � �������� ����� �� �������.\r\n� �����, ����������� ������! ����� �� �����!\r\n� �� ����� � ����������� �������� ����� �� ���������. ������� � ������ �� ����� 500 ����� ���� ��������. �������� �� �� ��� ������������ ���� �� ������ � ��� ��������� ���������� �� �������. �� ������� �� �� �������� ����������, �� ������ ������� ���� �������� ������� ����, �������� ���� ����� �������� � ���������� �� �������������, ����������� � ����������. �� ����������� �������� �������.\r\n� ���� �����������, ��� � ������� ������� ������� �� ������� �����. � ��� �� ������ ����������� �� ���������. ��������� ����� ���� �� ����� �� ��������. ������ �� ������ �� �������� �������, ������� ����� ������� ��������� � ��� ������� ��������� ���� �����-�������, ��� ������������ ���� � ���� ��������������. ��������� ������� �� ����������� � ���������� �������. ��� ��������� �������� ���� �������� ������������ ������� � � ���� ���� �� ������� ������, ������: � ��� �� �� ���������� ������� ���� ����������� ��.\r\n� �� ����� �� ����������� �������� �� ������. �������� �� � ����� ������. ��� ���� ������������ ����. �������� ������ ������ �� �����������, �� ����� ������� �������� �� ���������. �������� �� ����� � ��������� � ������ ������, �������� �� ��������. �� ����������� �������� ���� � ������.\r\n� �� ����� ��������� ������� �� ��������, ����� � �������� �� ��� ����. �� ���������, ��� ��� ������� ������ ������ ���������, ���� �� � ��������� ��������� �� �� ����� ����. ��������� ���� ������ �� ����� ������� ��������� � ������� �� �����������.\r\n� �����, ������ ������ �������� ����� � ���� �� ���� ��������� � ����������������! � ������. � � ���� �� ����� �� ��� ����������� �� ��������. � ������� ��� ����� ����� ��������������� ������ ����, ������ ���� ��� ����� �� �������� ����������, ���� �� ������ �� ������� ����� �� ��������� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode122Chois1()
		{
			int currEpizodeId = 122;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������, ���! � ��������� ������������. � ������ ��! �������!\r\n�������� � ��������, ��������� �� ����������� ����� ��������� ��������������� � ���������� ������ � ���������� ��������� ������� �� �������� ������. ����� ������������� � �������� ������� ��� ��������� � ������ ���������� ��������� �� �������� ��������������. ������� ������ �� ������� ����� �� ���� ������ � ����� ������� �� �� ������ ������. ���� ��������, �� �� �� ����� � ������ � ������, ������ ��������� �������� �� ���������� ��������� ��������� ������� �� � �������� � �������� ����������. ��� ������� ���� � ��������� ����� � �����.\r\n���� ������� ������ ��������� �� ��������, �� �������� � ��� ���� ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode122Chois2()
		{
			int currEpizodeId = 122;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���������� ��� ������! � ������ � ��������� �� ������������. � ����� �� �������� ������������ �� ����������������. � �������� �� �� �� ��������!\r\n� ��������, ���! � ������ �� ������������. � ���� �����: � ������ ��!\r\n������� ���� �� �� ������ ����. �������� � ��������, ��������� ������� ��������� ��������������� �� ����������� ������� � �� ��������� ������������. �������� ������������� � ����� ������� ��������� ��� ���� �� ��� ������� ������� � �������� ��������������. �������� �������� �������� ��������� ������ ������ � ����� �� ����������� ������� � ����� ����� ����� � �������. �� ������ ���� �� ����������� ������ ��������� ������� � ������ ����� �� ��������, �� �������� � �������� ���� ������ ������� ������ ��������.\r\n� �����, ��������! � �� ����� �� �� ������� ��. � ������� ������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode123Chois1ThrowException()
		{
			int currEpizodeId = 123;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 0;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 2;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode123Chois1()
		{
			int currEpizodeId = 123;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 2;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ����������� ������������� � ��������� �� ���������, ����� �� ������ ��� ��������� ������ �� ��������� � �������� ��������� ����������� ������ ����� �� ������������ ����� �� �������. ������� �� �� �������� ������ �� ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n���� ��� �� ���������� �� ������� �� ����������, ����� �� �������� ��� ��������� ������ � ��������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode123Chois2()
		{
			int currEpizodeId = 123;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 2;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �� ������ ����, ������� �� ���� �����, ���������� ����������� ��������. �� ������ ��� ����� � ���� �������, �� ������ �� ���, ������ ��� �� ��� ���� ������� � ����������� �� ��������� ����������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode123Chois3()
		{
			int currEpizodeId = 123;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2] - 2;
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� �������� ��������� �������, �� � ��-������ �� �������� ����� �� ������� �� ���������� � �������� � ��������, ������ � ����������� ����� ���� ��������. � ������ ���� � ������ ����� �� ��������� ��� ���� ������������ ������������. ������� ������� �������� �� ������� ��������� ���� �� ��������� �� �� ����������� � �� �� �� �������� � ���������. ������� �� ������������ ������� � ����� � ����� ��� �����. ������� ��������� ���������� ������������� ���� ����� �� ������� �� �����. ���� ���� ���� ��� �� �������� �� ������ ������� � �� �������� ��� ������ ����� �� �������.\r\n������� ������ �� ������������ ���� �������� ������� �� �������� � ���� ����. ���������� ��, ����� �� ����� �������, ������� ���� �� ������� ������� ���� � ���� � ������ �������� �� ������� �� �������� ����������� �� ������� ������� ��������.\r\n� ����� �� �������� � ������� ��������� ������. � �� ����� ������� ��������� ����� ����� ������ ������. ������� � �������� ����� �� ����������. ��� �������� �����, �� �� �������.\r\n� ��� �� ������! � �� �� ������ ���� �� ����������� � ������� ������: � ��������, ���������, �� ����� �� ���� ���� ����!\r\n� ����� �� ������? �����������! � � �������� ���� �� ������� ��.\r\n��� ����� �� �����������, ������ ������ ����� �� ������������� ��. ������ �� ������, �� �� ���� �������� �� ������ �� ������ �������. ���� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode124Chois1()
		{
			int currEpizodeId = 124;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode125Chois1()
		{
			int currEpizodeId = 125;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 60;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode126Chois1()
		{
			int currEpizodeId = 126;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6] + 60;
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ����� �� ������ ������ ���� ������� �� �������� � ���� ������� �� ������� ������� ����, ����� �� ������ � ���� ���, ���� �� ���� ��� ��� ��������� �� �������������� ���� �� �������� � ���� �� ������������ �� ����� ��������� �� ���, ������ ����� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode127Chois1()
		{
			int currEpizodeId = 127;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ��������� �� ��������� � ��������� ���� ������ � ����� �����������, ������� �� ����� � ������ ���� �� �� ������� � ���������, ��������� �� ���������� �������������. ��� ������������ ��� �������� ��������� �� ����������, �� ������� ���� ����������� �������� �� ������ ������� � �������� �������� �������� �� �������. ������ � �������� ������������ �������� �� �� ������� ����� ��-�������� �� ����� ��������. ��, ������ � ���������� �������� ������ � ������� �� ��������, �� ����� ������������ �� ������. �� ������������ �� ������������ ����������� �� ������� �������� ����������� ��� �������� ���� ���� �������� ����. ���� ��������� � ������� ��������������� ���������� �� �����������, ���� � ������, � ����� �����������.\r\n����������� �� ������ � ������������ ���� ���� ������� �������� ���� � ������������. � ������� ��, ������������ � ������� ��������� ��� ��������� ����� �� ������ �� � ���������� ������� �������� ������� �������� ����. ���� ����� ��� �� �� ���� �������� �� �����, ���� �� �� � �������� ���� � ��� ������ ��� �����.\r\n������� �������� � �� ������ �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode127Chois2()
		{
			int currEpizodeId = 127;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����, ����������� ��� �������� �������� �� �������� � ���� ����� ��� ���� ������������� �� ��������� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode128Chois1()
		{
			int currEpizodeId = 128;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����������� �������� ������������ �� �����, ��� �� ������� ���������, ��������� �� ��������� ������ �� ����������������. �� ��� ������, ������ � �������� � ������ ������� ����� � ������ ������� ��� �� �������\r\n� �������� �� ������ �� ���������� � ��������! �������� �������� � ��������� �������! ����� ����� ������� �� �� ���������! � ��������� ����� ��������� ����.\r\n� ����� �����, �� ��������! � �������� ���� ���� ���� �� �����������.\r\n���� ������ ���� ���� �� �������, �� ��� ��� � ������ �������� ������. �������� ����������� �������, ����� ���� � ������� ��� ��� ����� �� ����������� �������.\r\n� �������� �� ������ �� ���������� � ��������! �������� �������� � ��������� �������! ����� ��� ������� �� �� ���������! � ���������� ������ ������ �� ������.\r\n� ����, ����������� � ����� ����������, ��� ��� ���� ����� �� ���� �������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode129Chois1FourChecksumLess10ThrowException()
		{
			int currEpizodeId = 129;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[4] = 9;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>( () => game.GameAction());			
		}

		[Test]
		public void TestEpizode129Chois1FourChecksumMore10ThrowException()
		{
			int currEpizodeId = 129;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[4] = 11;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode129Chois1()
		{
			int currEpizodeId = 129;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[4] = 10;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ���� �� ����������� ���� � ���� ������� �������, ��������� ����������. ����� ���������� ��������� ������ ������� � � ������ � ������. ������� ������� �� ������� ����� �������� �� ���������� ��������, � ����� ������������ �� �� ������� �����������.\r\n����� �������? ���� �� �������� �� �������� � ������� ����� ������ � �������� �� �������� ���� ��-�����, � ���� � �� �� � ��������. ��������� � ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode129Chois2FourChecksumLess20ThrowException()
		{
			int currEpizodeId = 129;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[4] = 19;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode129Chois2FourChecksumMore20ThrowException()
		{
			int currEpizodeId = 129;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[4] = 21;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode129Chois2()
		{
			int currEpizodeId = 129;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[4] = 20;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �������� �� ���������� ������� � ���� �������� �� ����������� �� �� ���������, ������� ���� ��� �������. �������� ����� ������� �� ������������, ���� ����� � ���� �����, �� ���� ������� ������� ���������� ��� ������� �������, ����� ��������� ������ ������� � � ������ �� ������. ������� ������� �� �������� ��� ������� �� ���� ���������� ��������. ������������ �� ������� ������� � ���������� � �������� ������ �������.\r\n����� �������? ���� �� �������� �� �������� � ������� ����� ������ � �������� �� �������� ���� ��-�����, � ���� � �� �� � ��������. ��������� � ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode129Chois3FiveChecksumLess5ThrowException()
		{
			int currEpizodeId = 129;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[5] = 4;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode129Chois3FiveChecksumEqual5ThrowException()
		{
			int currEpizodeId = 129;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[5] = 5;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode129Chois3()
		{
			int currEpizodeId = 129;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[5] = 6;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ������� ������� ������������ � �� ����� �������� �������� ���� ��� �������. ������ � ���� �� ����������� �� �� ��������� � ���� ��������� ���, �������� �������.\r\n������� ����������� � ���� ������� ��� ������ �� ������� ������ � � ���� ��������� ������ ��������� ����� � ���������� �� ����� ������ �� ����������������.\r\n���������� ����� ������������ � ��������� �� �������� �� ��������� �� ���������������� � �� ������� ������� �� �������� � ���, ��� �� ������� ���� ���� �� ������ ��. ����� ���� ������� �� ������ ������, ����� � ����� �������� ����. ������� �� ����������� �� ��������� �� �� ������� � ��������. ��������� �� ������� ����� � ��������, �� ����� ������ ����� �� ����� ���������.\r\n� �������, ��������� ����������! �� ���������� �������� �������! ������ � ���� �� ���� �������.\r\n����� �� ��������� ���� � ���� �� ������� �� �� ������������, �������� ������������� ���������� � �����. ���� ���������� ��������� �� ��������, �� � ���������� �� �� ������� ����� ������������ �� ��������.\r\n� ���������, ���������� ������ ����� ������� � ������� ����� ������! � ������ �� ���������� ���������. ������� ��� ���� ������� �� � �����, ������ ���������!\r\n� ����, ����� �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode129Chois4FiveChecksumLess100ThrowException()
		{
			int currEpizodeId = 129;
			string currentChois = 4.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[5] = 99;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode129Chois4FiveChecksumEqual100()
		{
			int currEpizodeId = 129;
			string currentChois = 4.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[5] = 100;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� � ��������� ��������� ��������� ����� ������� � �� ��� ������ �������. � ��� �� ����������� ����� ������ �����, �� � ����� ����� ����� ������ � ������� �� ������ ��� �������.\r\n������ �� ���� �����, �� ����� �� �� �������� � ����� ���������� �� ������ � � ����� �������, �������� ������ �� ������ ������� � � ����������� ������ �� �������� �����.\r\n����������, ���������� �� ����� ����� �� �������� � ���������� �� �� ������ ��������� ���� ������� �� �����������:\r\n� ������� � ��������� ������� �� �����������. ������������� �������� ������� �� ������. ���������� �� �������� ���� �������� ������. ������� ������ �� �� ���������!\r\n� �����, ���������� �� � ���������! � ��������, ������ �� �������� �����. � ���������� ����������! ����� ������ �� �� ������!\r\n�������� �� � ������ ���� ��� ������� � ��������, � ���";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode129Chois4FiveChecksumMore100()
		{
			int currEpizodeId = 129;
			string currentChois = 4.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[5] = 101;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� � ��������� ��������� ��������� ����� ������� � �� ��� ������ �������. � ��� �� ����������� ����� ������ �����, �� � ����� ����� ����� ������ � ������� �� ������ ��� �������.\r\n������ �� ���� �����, �� ����� �� �� �������� � ����� ���������� �� ������ � � ����� �������, �������� ������ �� ������ ������� � � ����������� ������ �� �������� �����.\r\n����������, ���������� �� ����� ����� �� �������� � ���������� �� �� ������ ��������� ���� ������� �� �����������:\r\n� ������� � ��������� ������� �� �����������. ������������� �������� ������� �� ������. ���������� �� �������� ���� �������� ������. ������� ������ �� �� ���������!\r\n� �����, ���������� �� � ���������! � ��������, ������ �� �������� �����. � ���������� ����������! ����� ������ �� �� ������!\r\n�������� �� � ������ ���� ��� ������� � ��������, � ���";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode129Chois5ThirdChecksumLess5ThrowException()
		{
			int currEpizodeId = 129;
			string currentChois = 5.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[3] = 4;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode129Chois5ThirdChecksumEqual5()
		{
			int currEpizodeId = 129;
			string currentChois = 5.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[3] = 5;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� �� �� �� �������� �������������� �������� �� �����������. ������, ���� �� ����������� � �����������, �������� ��� �� ����� �� ������ �������.\r\n���� ������� ������, ����������� �� ���������������� ����������, ��� �������� �� ������ � ���������� � ������� �� ������.\r\n������� ������� �� ������� ����� �������� �� ���������� ��������, ����� ������ ���������� ����������� � ��������� ����������.\r\n����� �������? ���� �� �������� �� �������� � ������� ����� ������ � �������� �� �������� ���� ��-�����, � ���� � �� �� � ��������. ��������� � ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode129Chois5ThirdChecksumMore5()
		{
			int currEpizodeId = 129;
			string currentChois = 5.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[3] = 6;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� �� �� �� �������� �������������� �������� �� �����������. ������, ���� �� ����������� � �����������, �������� ��� �� ����� �� ������ �������.\r\n���� ������� ������, ����������� �� ���������������� ����������, ��� �������� �� ������ � ���������� � ������� �� ������.\r\n������� ������� �� ������� ����� �������� �� ���������� ��������, ����� ������ ���������� ����������� � ��������� ����������.\r\n����� �������? ���� �� �������� �� �������� � ������� ����� ������ � �������� �� �������� ���� ��-�����, � ���� � �� �� � ��������. ��������� � ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode130Chois1()
		{
			int currEpizodeId = 130;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];
						
			expectedPlayerStatus.Checksums[7] = 20;
			expectedPlayerStatus.Checksums[8] = 10;
			expectedPlayerStatus.Checksums[9] = 50;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode131Chois1()
		{
			int currEpizodeId = 131;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� �� ��������� �������� �����, ������� � �� �������� ���������, �� ������� �� ������. �� ����� �� ������� ������� ��������� ������ �� ��������, ����� �� ������������ ����� �� �������. ������� �� �� �������� ������ �� ���������������, �� ��� ������ � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n���� ��� �� ���������� �� ������� �� ����������, ����� �� �������� ��� ��������� ������ � ��������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode131Chois2()
		{
			int currEpizodeId = 131;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ���������� ��������� � ����������� ���������, ���� ��� ��� �� � ��������� �� �������� ����� �������� � �������. ���� ��� � ��-����� ��������� ��� ��������� �� ������, �� ����� �� ���������, �� ��������� ���� �� �������� � ���-��������� �� ����������� ���������.\r\n���� �� ������ � ��������� ������ ��, ������ ���� �� ������������� �� ��������, �� �� ��������� �� ��� ������� ������������� � ������� ����� ����� �������. ������ �� ����� �� �����������, ����� ����������, �� ���� ������ �� ������� ���������� ������ �� ����.\r\n� ����, ������� �� ���� ���������� �� �� ��������� � �������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode132Chois1()
		{
			int currEpizodeId = 132;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ����������� ������������� � ��������� �� ���������, ����� �� ������ ��� ��������� ������ �� ��������� � �������� ��������� ����������� ������ ����� �� ������������ ����� �� �������. ������� �� �� �������� ������ �� ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n���� ��� �� ���������� �� ������� �� ����������, ����� �� �������� ��� ��������� ������ � ��������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode133Chois1()
		{
			int currEpizodeId = 133;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode134Chois1()
		{
			int currEpizodeId = 134;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode135Chois1()
		{
			int currEpizodeId = 135;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������! ����! � ��������� ��� ������� ���������. � �������� �� �� ��������! �� � ��, � �������� ����� ��������� � ��������� ���������, ���������� � ���!\r\n������ ���������� �� ���������� �� ������� ������� �������, �� �������, ����� �� ����� �������, ������ ���� �� ������. ������� ������ ��������� ���� ��� � �� ������ � ������ �� �����������. ������� ������ ���� ��� �������� � ����� �� ����� ������� � �� ���������� ������ �� ������. ����������� ��� ���� �������� �� ������ ���� ������ � ���� �������� ���������� �� ������, �����:\r\n� ���� � ������� ����������, ���������, � �� ����� � ����� �� �������, ����� ������ �� ������ � ������� �� � ������� ����� ���� �� �������� ��� ������� �� ��������, ����� �� ������ � ������.\r\n��������� �� ������� ������, � � ��� ��� ���������� ������� �� ���������.\r\n� �����, ����������� ��! � ����� � � ������ ���� �� ������ �������� ��������� �� ��������� � ����� �������� �� ��������. �� ��������� ������ � ��������, ��� ������� ��������� � ���������� ������� ������ �� ������� � ������ ���� �� ������� ��. ������ ������� ���� � ���� ����������, ������ ���� �������� ������� �������� ���� ����� �� �������� �����. � �� ���� ����� �� �� ��������� �����.\r\n���� ���� ���������� �������� �� ������� ������� � ����� ������ �� ����� �� ������� �� ����������� �� ������� �������� ��������� ��� ���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode135Chois2()
		{
			int currEpizodeId = 135;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �� ��������! ����� �� �� ������! � ��������� ���� � ���������� ���������� ��������� ����������.\r\n����������� ����� ��� ����� �������� �� ��-����� �������� � � ����� ����� ������ �� ������� �������. ���������� � ������� ����������, �� ������� �� �������� � ��� ������ �� ������� �������� �� ������������� ��������� �������, �� �������� �� �������� � ����� �� ������.\r\n� ��� �� ��� ��, �� ��������? � ���������� �� ����, ���� ������� ������: � ����� ���������, ���� ���������� � ������� �������! ��������� ��������, ��-����� �� �� �������� � ��������� �������.\r\n� �� �� ��������, �� �������! � ������ �� ��������� ����������� ����� ��� ����� � ���� ������� ��������, �� ����������. �������� ������ �� ��������� ����������� ���� ��� ������� ��������� ������, �� ������� ����������.\r\n����� ����� ��� �� ������� ��������� �� ������� �� ����� � �������� �� �������� �����. ���� ���� ������� �� ��������� ������� � ������������ �� ���������, �� ������ �� ������ �� ����� �� ��������� ������� � ���������. ��������� �� �������, �� �� ������ ����������� �� ����� � ���� �� �������, �� ��� ��������. �� ������� �� ������� ��������� ������ �� ������������ �� ����� � ���� �� ������� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode136Chois1()
		{
			int currEpizodeId = 136;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ �� �������� �� ����������� ������� ����� ���� �� �� ������ � ��������� �� ���������� ����� ���� ������ ��� ��������.\r\n� ����� � ��������� �� ������ �������� ���������� �� �������. � ��� �� �������� �������. � � ���� ���� ��������� �� �����, ������ �����: � ���������� �� �� ������� ���� ������, ��������� ������. �� �� �������, �� �� �� ��������� ���. ��� ��� ����� ���������� ���������� ����� �� ���� ������� �����. � �� ������� �� ������������ �����, ��� ������ ������������ ���� ����� � ��� �� �������� �� ��������� ����.\r\n� ��� �� ����� �� ����� ��� ������ � ������ �� � ���� �� �������. � �� ��� ��� ���� � ������?\r\n� ����� ���� �� ����� ������ ��� � ��������� �� ��. � ��� ����� ������, ����� �� �� �������� �� ��������� � �������� �� ������ � ����������. � ���� �� ������� ����� �� �������� ������ � ���� ����������.\r\n������ �� �� ���������� � ������� �����������, ����� �� ���� �� ���� �������, �� �� ��������, �� ������� �� ������ ��������� ����� ��� ������ �� � ����� �������.\r\n����� ������ � ������. �������� �� ������ �� ������� � �������� �� � �����������. ���������� �� �������� � ����� �� � ���������� � �� �� ������� �� ���������� � ���������������� � �� � ���������. ������ ������������ �� � ���� ���������� �������-�������������� �������, ����� � ����������� ����� � ����� �� ����������. ������� � ����������� ��� �� ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n����� �� �������� ����� ����, �� ������ ����� ����� ��� ��� �� �� �������� � �� �� ����� �� �� �������, ��� ������ �������� ��������������.\r\n��� ��� ������� �� ���������� ������ �� ������ ������ �� ����� ��.\r\n������ �������������� ������ ������������� �� ��:\r\n� 50% ���������� �� ������������ ����������;\r\n� 95% ���������� �� ������� ����������, ��� �� �� ������� �������������;\r\n� 70% ���������� �� ��������� �� ������������� �����, ��� �� �� ������� �������������;\r\n� 25% ���������� �� ������� ����������, ��� �� ������� �������������;\r\n� 30% ���������� �� ��������� �� ������������� �����, ��� �� ������� �������������.\r\n��� ��� �������� ������� � ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode136Chois2()
		{
			int currEpizodeId = 136;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ���������� �������� ������, �� �������� �� �� �������� � �������� �� ������������, �� ������ �� ����� ���������� ���� ������ � ��������� ��������. ���� � �� �������� �������, ���� ����� ����� ���� �� ���� ����� ����� ��������� � ������ � ���� �� ������.\r\n� �������� ���, �� ������ �� � ������ �� ���� � ������ ������. � �� ������� ����� ���� �� ������� ��� ������, �����!\r\n� ��� �� �� ����� �� �����! � ������ �� ����� ���� �� �������. � ���� ������ ���� ������ �������\r\n� ���� ��������� ��������� �������� ��, �� ������ ��� ����������:\r\n� ��� ������!!!\r\n� ��� ������!!! � ������ ��������� ������ � �� ����� ����� ������ ���� �� �������������.\r\n������ �� ���� �� ��������� ��������� ����� � �� ���������� �������� �� ����� ���� ���� ���������� � ���������.\r\n��������� �� ���� ������ ����� �� ������, �� ��� ����� ������ �� ���� �� ��������� ���������, �� � �� ����� ���������� �� ��������� � ��������� �������� ������������ �� �������������.\r\n������ �� ����������� � �������� �����.\r\n� ������� �� ������������ �� ������ �������� �� ��������� ���� �� �������������� ������� �� ���������. ���� ���� ������� ��������� � �������� �� ������� �������� ���� ������ � �������� ���������� ����� � ���������. ������������, ��������� �� ������� �����, �������� � ��������������� � � �������� �� ����������, � �� ������ � ������������� �� �������� ������������.\r\n����������� ������������� ������ ���� �������� ���������:\r\n� 50% ���������� �� ����� �� �������;\r\n� 30% ���������� �� ��������� �� ���������� �� ����;\r\n� 70% ���������� �� ����� ��� ������� ������;\r\n� 0% ���������� �� ����� ��� ��������� ������;\r\n� 50% ������ �� ����������� �����.\r\n��� ��� �������� ������� � ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode136Chois3()
		{
			int currEpizodeId = 136;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� ����� �� ������ �� �� ������������ �� ������ �� ��������. �� ����� �� ��������, �� ���� �������� �������� ����� �� ������ �� �����, �� �� ����� �� ������� � ������� ����, ����� ���� ������������ �� ���� ����� �����. ������ ������� �� ���� ������� ����������, ������� � ������� �� ��������� �� ������� �������. � ������:\r\n������� �� �������, ���������� �� ����������� �� ������ ������� �������� � ����� ��������� �� �������� �������������� �������� ����� �� �������� �� �������� �� ����. �� �� ������ �� �������� �����������, �� ����� �� �� ���������. ������ �������� �� ��������� ��������� �����������, ��, ������ � ���� ��������, ����������� � ���� �� ������� �� �����, �� �� ���������� ������������ ���� ������������� ����������� ����� � �� �������� ��������������� �� ���������. ������ ������������ �� � ���� ���������� �������-�������������� �������, ����� � ����������� ����� � ����� �� ����������. ������� � ����������� ��� �� ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ������� ��, ��������� ������ �� ������������ �� ������� � ����������� ����� �� ���������, �� ����� ������ ��������, �� �������� �� ���, � ���� �� � ������, ��� ��������.\r\n��������������� ������ �� ���������� �������:\r\n� 75% ���������� �� ������������ ���������� �� ������������� �����;\r\n� 95% ���������� �� ������� ���������� ��� ������������ ����������;\r\n� 50% ���������� �� ������� ���������� ��� �������������� ���������;\r\n� 30% ���������� �� ��������� �� ������������� ����� ���� �����������;\r\n� 90% ������ �� ����������� �����.\r\n��� ��� �������� ������� � ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode137Chois1()
		{
			int currEpizodeId = 137;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���-����� ������� �� ������, �� � ������� �� ��������� ��������. ��� ������ ��������� ��������� ���������� � ��� ������� � ���������� �� ������������� ������� � ��� ��������� � ���������� ���� �� ����������������.\r\n� ����, ������� �� ���-������ ����� �� ���������. ���������� ����������� ������� � ������� ������� ������� � ������� �� �������� ���� �� ��������. ����� ���������� ���� �� ��������, ������ ����� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode137Chois2()
		{
			int currEpizodeId = 137;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ����� �����, ������ ����� � ����������� ��� �������� �� ������ � ������� ��������� ���� ���������:\r\n� �������� �� ������ �� ���������� � ��������! �������� �������� � ��������� �������! ����� ����� ������� �� �� ���������!\r\n� ����� �����, �� ��������? � �������� ���� ���� ���� �� �����������.\r\n���� ������ ���� ���� �� �������, �� �������� �������� �������� ������ � �������� �������� ����������� �������, ����� ���� � ������� ��� ��� ����� �� ����������� �������.\r\n� �������� �� ������ �� ���������� � ��������! �������� �������� � ��������� �������! ����� ��� ������� �� �� ���������! � ���������� ������ ������ �� ������.\r\n� ����, ����������� � ����� ����������, �� ��� ��� ���� ����� �� ���� �������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode138Chois1()
		{
			int currEpizodeId = 138;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode139Chois1()
		{
			int currEpizodeId = 139;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������, ���������! � ���������� �� ������������. � �� ��� �� ������ �� ���������?\r\n� ��� ��! � ������ � ���� �� �������� ��������, �������: � ���� �� ����� �� �� �������.\r\n���� ���� ������� ������ ��� ����� �������� � ����� �� ������������ ������� � ���������. ���� ��� �� ������ �� ���������, ������ ����� ����� ��������� ������. ����������� �� ����������� �������� ������ ��������� � �� �������� ����� ����� ���. �������� �� ������ � ��� ���������� ������� ����� � ��� ������ ������. ��������� ����� ��� � ���������� �� ������� ������, �� �� ���� ������ � ������� ��� ����. �� ������� �� ��������� ������� ��������� ����� �� � ����� � ������� �������� ���� � ���������� �� ����� �����������.\r\n� ����� �� �� ������! � ������ ������� � ������ ����� �� ��������� ��� ������.\r\n�������� �� � ��������� � ������ �� ����� ������ �� ����� � ���������� ����� �� ������� �� �������. ���� �� �� ������ ���� �����, ����� �� ������� ������������ ������� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode140Chois1()
		{
			int currEpizodeId = 140;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ������ ������ ��� ���������� �� ������� ������� ������������ �� ����� ������ ������. �� ���� �������� ����� �� �����, ��� ������� �� �� �����. ������ ����������� �� ����������, �������� �� ��������� �����, �� ���������� ��������� �� ������� �� ���������.\r\n�������� �� ��������� � ������� �������������� ����� �������� ����� � ������� � ������, ������ ����� ��������� �� ��������� ������� ������ ������ � ������ �� ������� ���������. ������� ��������� ����� �� ������ ������ � �� ������ � ���������� ����.\r\n�������� �� ��������� ���������� � ���� ������� ������ �����, ����� �������� �� �� �������� ��� �������������. ������ ������ ����� �� ������ ��� ������� �� �� ����� �� �������� ��� ������, �� �� ������� ��������.\r\n�������� �� �������� � ������ �� ���� � �� ������� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode140Chois2()
		{
			int currEpizodeId = 140;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ������� ������� �� ����� � ���� ���� �� ����� �������� ����� ��� ������� ������� �� ���������, ���������� ���������� �� �������� �������. ����������� �������� �� ������ ��������. ������ �� �������� �������, ����������� � ������ ������, ��������� ����������� ��� ����������������. ���� ��� ����� �� ������� ����� ������� ������, ������� � ��� ������� ������. ������� ����������� ������� ����� �� ��������� � ����� ������ � ���������� �����, �������� �� ����� ������������� �������, ����, ������������ � ����� ��������. ��� ��������� �� ���� � �������� ����� ����� �� �� ������� ���� ������� ������������ ��� ������� ��������� �����. �� ���������� �� ��������, ����� ��-�����, �� ������ � ������� ���������� �������� ������.\r\n������� �� ����������� ����� ������ ���� �� �� ������ � ������ ��������, � �� ������ ����� ���� �����. ���� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode141Chois1()
		{
			int currEpizodeId = 141;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 7;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ���� ��������� �� ������ ������ �� ������, �� ����� ������� ����� ������� � �� �������� ��� ������� �� ��� � ����������������. ����������� �� � �����, ������� �� ��������� ����� �� ������, ����� � ������ � ��������� ������������ �� ����� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode141Chois2()
		{
			int currEpizodeId = 141;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������, �� ������� �� ���� ��-���������, ��� ��������� ������������ ���� ��� ������ (�� ������ ����� ����) � ���� �� �������� ��������. ��������� ��� ������ ������ �:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode142Chois1()
		{
			int currEpizodeId = 142;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode143Chois1()
		{
			int currEpizodeId = 143;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode144Chois1()
		{
			int currEpizodeId = 144;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ������� ���������� ��� �� ���������� � ����� ��������� ������ ���� ��������� ������� ����� ����� � ��������� � ����� ���� �� ������������ ��� �������� ����� � � ���������� ������ ���������� �� ����������� �����.\r\n���� ���� ��������� �� ���������� �� ��������� ����� � ����� �����������, ������� �� ����� � ������ ���� �� �� ������� � ���������, ��������� �� ���������� �������������. ��� ������������ ��� �������� ��������� �� ����������, ������� ���� ����������� �������� �� ������ ������� � �������� �������� �������� �� �������. ������ � �������� ������������ �������� �� �� ������� ����� ��-�������� �� ����� ��������; ��, ������ � ���������� �������� ������ � ������� �� ��������, �� ����� ������������ �� ������. �� ������������ �� ������������ ����������� �� ������� �������� ����������� ��� �������� ���� ���� �������� ����. ���� ��������� � ������� ��������������� ���������� �� �����������, ���� � ������, � ����� �����������.\r\n����� ���� ���, ���� �� �������� �����, � ������ ����������� ��������� �������� ���� � ��������� ���� ��� ����������������. ��� �� �� �����, ���������� �� ���������������� ����� � ������ ���� �� ���������, �� ������ �� �������� ���������� ���� �� ������������� �.\r\n� ������� ��, ��������� � ������ �� ��������� �������� ��� ��� ����������. � ���� � ������ ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode144Chois2()
		{
			int currEpizodeId = 144;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����, ����������� ��� �������� �������� �� �������� � ���� ����� ��� ���� ������������� �� ��������� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode145Chois1()
		{
			int currEpizodeId = 145;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� ��� ���� �� �������������� ����, �� ���������� �� ������ ���� �������� � ���-������� �������� �� ������ �������. ��� ���������� �� �� ����������� �� ������� �� �������� � �� ������� �������. ������� ��, ���� �� �����, �� � ������� ���������� ��� � �������� �� �������� � ���� ��� ����� �� ���� �� ���. �� ������� � �� ������, ���������� �� ������� ������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode146Chois1()
		{
			int currEpizodeId = 146;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode147Chois1()
		{
			int currEpizodeId = 147;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����, ����������� ��� �������� �������� �� �������� � ���� ����� ��� ���� ������������� �� ��������� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode148Chois1()
		{
			int currEpizodeId = 148;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ����! � ������� �� ��� ������ ��. � ���� ����� ��� ��������� ���� ���� �� ��������� ������� � ����� �� ���������� ������, ��� ����, �� �� ��������. ���� ���� ����� �� �� �� ������� ��� ����� � �� �� ������ �� ������� ����� �����. ������ ������ �� ����� ���������!\r\n���� ���� ������ �� ���� �� ������ �� ��������, ����� ���� �� ������ �� �� ��������. ������� ��� �� �� ������� �� ������ ��� ������ �����, �� ���������� ���������� ���� �� �������� � ���� ���������� �����. ���������� ������� ����� � ������� ����, ����� ������, �� ��� ���� ����� � ������� ������ �� ������� � ������� �����������, �������� ��� ���. ����� ��� ��� �� ���� ����, � �� �� ��������.\r\n��� ��� ���� ����� �� ���� ����� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode148Chois2()
		{
			int currEpizodeId = 148;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������, ���������� ����������! � ��������� ����. � ��� ��� ��������� ������� � ������� �����. ������! ���� ��� ���!\r\n� ��������� ���� � ����� ������ ������, ������ �� ������, � ��������� � �������� ������ ����������, �� ��������� �����, ���� ����� �� ������� ���������. �������� �������� � ���������� � ���� ���������.\r\n�� �������� �� ��������� ���, ���� ������, �������, ���� ������������� ��������. ����� � ������ �� ���, � ���������������� ����� ��������, ��������� ��������� �������� �����, �� ������� �������� �������� � �������� ������� �� �������� ������. ������� �� ���, ����� ��-�����, �� ������� ����� ������� ����� ������ ������ � ���� ����� �������� ��.\r\n� ���� ������ ��� ������ ��������� ������� �� ������� ���������� ���������� � �� ���� ����� �� ������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode149Chois1()
		{
			int currEpizodeId = 149;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ������������� ������ ���� ����������, �������� �� ����� ����������� ����, ������� �� ���� ������� ���������� ������� �� �� ��������� � ��������� ������������� ��. �������� ��� �� ������ �� �������� � ����� ����������� �� ������������ ����� ��������� ��������� �������. ������ �� �� ������ � �����, � �����, ��������� ��������� �����. ������� �� �� �����, � ����� ������ ������� � �������� � ���� ������. ���������, ������ ������ �� ��� ��-������� �� ���� ���� �� �������� �������� � ��-����� ����. ���-������� ��������� ����� ������� ��, ������������ � ��� ����� �������� ����� ��� � ��� ������ ��������� ���, ����������� ����, �� ����� �� ������ ����� �� ������ ������, ��� �� �� �������. ������ �� � �����, �������� �����, ����� � ����� �����������, ������ �� ����� �������� � ��� ���� �����, ��������� �� � ����, ����� �� ������, ����� � ����� ��������. ������ �������� �������� �� �������, ��������� ��������� ����, �� ����� �� ������, ������� ������������ �� ��������� �� ����, ������ � ����� � ��������� �������.\r\n��, ������� ��, �� ����� �� � ����, ����� �������� ���������� ��; ����������� � ����� � � ����� ��-������� ��������. ���-����� �� ������� �� �������� ��. �� ���� ������ �������� �� ���������� ���������� ��������, �� ������ � ��������� ��� �������� �� ���������� �� ������ �� ����� ��������������� ���������. ������ ������ �� ���� � ������, � �������� � ��� ����� ������������� �������. �������� ���� �� �������� � ����������� �����, �� � ������������ ����������� �� �������������� ������ �� ��������� ��� ������ ���, ������ ������� ������� ���� � ��� �������� ������ ������� ���� � ��������� � ������ ������ ������ �������.\r\n���-������������ ����� �, �� ������� ������ �����, �������� � ������ ����������, �� ������ ���� �������� ������� �� ������� �� ���������. ������� ������ ��� �� ������ �� �� ������� �������� ������� ����. �����, �� ��-����� ��������� �������������, � ��� ������� �� ������� ������� �� �������� � ������� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode150Chois1()
		{
			int currEpizodeId = 150;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ���� �� ����� ��������� ��� ������ ���������. ������ ������� ���� �� �������� �������� �� ����������� �����, ����, �� ��������� ��������� �� ������� �� �������� �� ���� ���������� �� �� �������� � �� ������� ����������. ���� ������ ����� �������� �� ���������, ���� ���� � ����������� � ���� �������� � ���������� �� ������� ����� ����� �� ������ ����������� �� �� ������ ���.\r\n� ����� �� ������, ���������? � ���� ���� ���� �� �����������.\r\n� ���������� ����������! � ����, ���� �� � ���� ������� �������! � �������� �� � �� ��������.\r\n������ ������ ���� ��� �������� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode151Chois1()
		{
			int currEpizodeId = 151;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� ��� ���� �� �������������� ����, �� ���������� �� ������ ���� �������� � ���-������� �������� �� ������ �������. ��� ���������� �� �� ����������� �� ������� �� �������� � �� ������� �������. ������� ��, ���� �� �����, �� � ������� ���������� ��� � �������� �� �������� � ���� ��� ����� �� ���� �� ���. �� ������� � �� ������, ���������� �� ������� ������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode152Chois1()
		{
			int currEpizodeId = 152;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ��� ��������, �� ������������� �� ��������� � ���-�����. ��� ������ ��������� ���������� ������ � ��� ������� � ���������� �� ���������� ������� � ��� ��������� � ���������� ���� �� ����������������.\r\n� ����, ������� �� ���-������ ����� �� ���������. ���������� ����������� ������� � ������� ������� ������� � ������� �� �������� ���� �� ��������. ����� ���������� ���� �� ��������, ������ ����� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode152Chois2()
		{
			int currEpizodeId = 152;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[1] = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ������������ �� ���� � ������������ ��������, �� ������ ������ �� �������� ������� ��.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode153Chois1()
		{
			int currEpizodeId = 153;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �� ���������� �������� �� ������� ����� ���������������� � �������. ������� ����� ������ �� � ��������� �� ��������� �� ����� ���� � ������ ������ � ������� �� ���� �����, ��� ��� ������� � ��� ��������� ����������������.\r\n�� ���������, �������� �� �������� � ����� ��������� ��� � ���������� �� �� ������ �� ����� ����� �� ���������. ����� � �������, ������ �������� ����������������, ���� ������ ������� ������ �� �������� � ������ ������.\r\n���� ���������� ��� �������� ��������� �� �� �������, ���� � ���� �� ��������. ���� � ����� �� ������� ��; �������� �� � ���������� ������ �� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode153Chois2()
		{
			int currEpizodeId = 153;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �� ���������� �������� �� ������� ����� ���������������� � �������. ������� ����� ������ �� � ��������� �� ��������� �� ����� ���� � ������ ������ � ������� �� ���� �����, ��� ��� ������� � ��� ��������� ���������������� ��� ������. ���� ���� ������� ������� �� ������� � ��� ������� ����������, ����� ������� �������� ������ � ������, ��� �� �� ������� �� ���-�����.\r\n������ �� �� ����������� ������ �� ��������� ������ ������ ������ ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode153Chois2ThrowException()
		{
			int currEpizodeId = 153;
			string currentChois = 2.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode154Chois1()
		{
			int currEpizodeId = 154;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ��������� �� ��������� � ��������� ���� ������ � ����� �����������, ������� �� ����� � ������ ���� �� �� ������� � ���������, ��������� �� ���������� �������������. ��� ������������ ��� �������� ��������� �� ����������, �� ������� ���� ����������� �������� �� ������ ������� � �������� �������� �������� �� �������. ������ � �������� ������������ �������� �� �� ������� ����� ��-�������� �� ����� ��������. ��, ������ � ���������� �������� ������ � ������� �� ��������, �� ����� ������������ �� ������. �� ������������ �� ������������ ����������� �� ������� �������� ����������� ��� �������� ���� ���� �������� ����. ���� ��������� � ������� ��������������� ���������� �� �����������, ���� � ������, � ����� �����������.\r\n����������� �� ������ � ������������ ���� ���� ������� �������� ���� � ������������. � ������� ��, ������������ � ������� ��������� ��� ��������� ����� �� ������ �� � ���������� ������� �������� ������� �������� ����. ���� ����� ��� �� �� ���� �������� �� �����, ���� �� �� � �������� ���� � ��� ������ ��� �����.\r\n������� �������� � �� ������ �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode155Chois1()
		{
			int currEpizodeId = 155;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ���������� �� �� ����������� �� ������� �� �������� � �� ������� �������. ���� �� ����� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode156Chois1()
		{
			int currEpizodeId = 156;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��-����� � �� ��������� ��� �� ���������� ������������ �� ��� �������� � ������� ������� �����������.\r\n� ��� ��� �� ����� ��������ѓ? � �������, �� �������, ���� �� �������� �� ��������.\r\n� ����� ������ ���� ��� ����� ��������ѓ? � ���������� ���� �����������. � ��� ��� ����� ��������� �� �����������.\r\n� ������ �� ����! � ������ �������� ���������. � ����� ����� ����� �� ��������� ��������� �����-�����������. �, ����� ��������, ���������?\r\n� ���� �� �� ������� � ������ �� ��������! � ������ �� ������ �����������. � ����������� �� �� �� �������� ��������, ������ �� ��������� ��������!\r\n��������� � ������ � � ������� ���� ��� �� �� �� ��������. ���� �� ��������� ���������� �� �������� ����������-���������, ����� �� ��������� �� ������� �� ������������� ��.\r\n���� ������� ������ ���������������� �� ����������� �� ����������� ������� � ����� ����������� ���� ����������:\r\n� ��������! �� ������� �� ��������� LTR � 3! ������� ���� �� ����, ��� ������! ������� �� � ���� ��� ��������! ��� ������������ �� �� ��������!\r\n� ����� �� ������ ����, ��? � ������ �� ���� �� �����������.\r\n� ���� ���! � ������� �� ������� ���������. � ���� ����������� ��, ���. ����� �������� �� ������� �� �������� MAG 77. �� �� �������� ��?\r\n���� �������� �������� �� ������� ����� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode156Chois2()
		{
			int currEpizodeId = 156;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��-����� � �� ��������� ��� �� ���������� ������������ �� ��� ��������! � ������� ������� �����������.\r\n� ��� ��� �� ����� ��������ѓ? � ������� �� ������� ���� �� �������� �� ��������.\r\n� ����� ������ ���� ��� ����� ��������ѓ? � ���������� ���� �����������. � ��� ��� ����� ��������� �� �����������.\r\n� ������ �� ����! � ������ �������� ���������. � ����� ����� ����� �� ��������� ��������� �����-�����������. �, ����� ��������, ���������?\r\n� �����, ��������, ��������! � ������� ���� ������ �������� ���. � �� ��� ������, �� �� ���� ���� ����, ������� ��!\r\n��� ������ �� ������ �������� �� ���������� ���������, ��������� �� ��������� �� ������������ � ���� ������� ������ ��������.\r\n� ���������� ��, ���! � ���� �������� ������������. � � ������ �� �����������.\r\n������ ���� �����������, ��� ��� ��������� ��� �������� � ���� ����� ��� �� ��������. � �������, ������ ������� ������ ������� ������, �� ������� ������ � ��� �� ������� ����� ����������-��������� � ������ �� ���������� �� �� ������ � ������� �� ����������������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode156Chois3()
		{
			int currEpizodeId = 156;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� �� �����������! � ������� ������� �����������. � �������� �� ����������� �� �� �������! � ���� ��� ������������ �� �� �������. � �������, ������ �� �� �� �������� �� ��������! ���� ����� �� ������ � ������� �� ���� ��.\r\n� � ���, ��������, ��������� ��� �� ��������, �� ��� ��������� ������������� �� ������ ��! � ������ ����� �� ��-������ �� ������ ���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode157Chois1()
		{
			int currEpizodeId = 157;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode157Chois2()
		{
			int currEpizodeId = 157;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ������ �� �� ��������� ���������� � ���� ������� ������, ����� �� ����� �� ������������ �� �������, ������� ����� ��������� ������ �� ��������, ����� �� ������������ ����� �� �������. ������� �� �� �������� ������ �� ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n���� ��� �� ���������� �� ������� �� ����������, ����� �� �������� ��� ��������� ������ � ��������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode157Chois3()
		{
			int currEpizodeId = 157;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������������ ����� �� ������� ��������, ��� �� �� ���������, � �� ������� ��������� � ������ ������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode158Chois1()
		{
			int currEpizodeId = 158;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode159Chois1()
		{
			int currEpizodeId = 159;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode160Chois1()
		{
			int currEpizodeId = 160;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������������� �� ����������� �� ��������� ��:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode160Chois2()
		{
			int currEpizodeId = 160;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� �� ��������, ��� �� ����� ��� ���� ������� � ����� �� ������ � �������, ����� ����� �� �� ��������� � �������. ������� ��, ����� � ������� ������ �� ������������ �� �� ���������� ����������, �� ����������?\r\n����� � �� ���� �� ������������ ���� ����������� � ������ �� ������� �� ��� �����, �� ��� �������� �������� ����������� ������� ����� �� ����� ������ ������, ��������� �����. ���� �� ���������, �� ���������� �� ����������� �� ������������, �� �� ����� ����� ���������, � � �������������� �������� �� �� ��� ���� ����� ������. �� ���������, �� ����������� ������� �� ������� ��� ����� ���� �������������� ������������ �������� � ������� ����������� ��������� MAG 77, ����� � ������ ������������ �� �������� ��������. ������ � � ����������� � ����� ����� �������� �������� �� ������� � �����, �������� � � ����� �����.\r\n��� ��� �������� ������� � ����. ����� �� ������ 300 �����, ����� ����� �� �� ���������.\r\n�� ������ �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode161Chois1()
		{
			int currEpizodeId = 161;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� ��� ���� �� �������������� ����, �� ���������� �� ������ ���� �������� � ���-������� �������� �� ������ �������. ��� ���������� �� �� ����������� �� ������� �� �������� � �� ������� �������. ������� ��, ���� �� �����, �� � ������� ���������� ��� � �������� �� �������� � ���� ��� ����� �� ���� �� ���. �� ������� � �� ������, ���������� �� ������� ������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode162Chois1()
		{
			int currEpizodeId = 162;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode163Chois1()
		{
			int currEpizodeId = 163;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ����������� ������������� � ��������� �� ���������, ����� �� ������ ��� ��������� ������ �� ��������� � �������� ��������� ����������� ������ ����� �� ������������ ����� �� �������. ������� �� �� �������� ������ �� ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n���� ��� �� ���������� �� ������� �� ����������, ����� �� �������� ��� ��������� ������ � ��������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode163Chois2()
		{
			int currEpizodeId = 163;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� � ���� �� �����������, ����� �� ���� �� �� ���� ����������� �� �� �������� �� ����� �� �������� �� ������.\r\n������ �� �� ��������� ������ �� ��������� ������ ������ ������ ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode163Chois3()
		{
			int currEpizodeId = 163;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������������ ����� �� ������� ��������, ��� �� �� ���������, � �� ������� ��������� � ������ ������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode164Chois1()
		{
			int currEpizodeId = 164;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[1] = 10;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ���� ��������� �� ������ ������ �� ������, �� ����� ������� ����� ������� � �� �������� ��� ������� �� ��� � ����������������. ����������� �� � �����, ������� �� ��������� ����� �� ������, ����� � ������ � ����������� �������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode164Chois2()
		{
			int currEpizodeId = 164;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[1] = 5;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� �������� ������� �� �� ��� ������� ����� � ��� ������� � ���� �� ���������. ��������� ����� �� ���� �� ������ �� ��������� ������� ������ �� ��������� � �� �� ��������, ������ ������� �� ��������� ����� �������� ��������.\r\n������� �� ������� � ���� �� ������ � ��� �� ��������� ��. ������������ ������� � �� � ������������ ����������� �� ��� � ���� ������ �� ��������� �����.\r\nGS1 � ����� ������� �����:\r\nGS2 � ����� ������� �����:\r\nGPR � ����� �� ���������:\r\n������� ����, ����� ������ �� ��������, ���� ���� �� ����������� ������, � �� ��������� �������� �� �����. ����� GS1 �� �������, ����������, ���-������ � ����������������. ����� GS2 ����� �� ������� ��� ���������� ��� ��� �������������. ���� ���� ������ ��� ��� �� ��� �� �� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode164Chois3()
		{
			int currEpizodeId = 164;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[1] = 15;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ������ ��������� �� ���������� �� ��������� �����, ������ �� �� ������� � ��� ���� ������� � �� ������ �� � ������������� �� ����� ����� ������ � ��� ������, ���?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode165Chois1()
		{
			int currEpizodeId = 165;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode166Chois1()
		{
			int currEpizodeId = 166;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode167Chois1()
		{
			int currEpizodeId = 167;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���� �� ������� � ���������� �� ������. � � ��������, ��� ���� ���� ����!\r\n���� ������� �������� ������� ������� ���� ����� ����������� ������ � ���� �������� ����, ����� ����. ��������� �� ������ � ����������, ������� �������� �� ������� � ������ �� ����� ������� ��� ������ � ������ �� ����������:\r\n� �������� �� ������ �� ���������� � ��������! �������� �������� � ��������� �������! ����� ����� ������� �� �� ���������! ��������!�\r\n�� ������� � ������ ���������� ������ �� ������ �� �������, ����������� �� ��� �������� ������� �� ������� � ������ � ������� �� ������ �� ������. ����� ��������� ����� ��������� ������ � ����� �� �������� �� ������ ������� �� ������ ���.\r\n� ����� ������! � ��������� �������� �����, ���� �� ����������.\r\n������� ���� ����� � ��� ��������������� ��������� �� ��������� ��������� �� ���������������. ������ � �������� � ����� ������� �����, � ����� ����� ������������ ����� �� ������. ������������ �������� �� ����������� � ���� ���������, �� ������ ���� ���������� ���������. ������ ������������ � ���� �� �������� ��������� �� �������� � �������, �� ����� ���� ���������� �� ������ �������. ������� �� �������� ������ � ������ �� ���� ���, ��������� �� ������������ �� ��������� � �������� ��������. �� ����� ���� ��������� ����� �� ������ ��� ���������� �����, ��� �������� �������� �������; �� ��� �� ������� ������ �������� ����. �� ����������� �� ���� ����������� ������, �������� � ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode167Chois2()
		{
			int currEpizodeId = 167;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������ ����� �� ������������! � ������� ���� ������ ��������. � �����, ��������!\r\n������� ��� ��� ��������� �� ������, � ������� �� ������ � ������ ���� �������� �������:\r\n� �������� � ������ �� ���������������! ������� � ����� ���������! �������� ����!\r\n��, �� �� ��������� ������ ������� �� ������. ������ ��� �� ������� ����� ��� ���, ���������� �� ������ ������ � ������ �� ��������� ������, ���� �� ����� �����. ������������ ���� �� ���������� ������� ������� �� �������� ����� ��� � ����� ���� �� ��� � ������� ��. ��� ���� ���� ����� ���������� ��������� ������� � ������. ���� ���� ���� ������� ��������. �� �� ���� �� �� �������� �������, �� �� ������ � ������� �� ����� ������ ������ �� � ����� ������ ����� �� �������. ���� ������������� �� ���� ��������� �� ������ ��-����� � ��� ������ �� �������� �������� ����� ����� ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode168Chois1()
		{
			int currEpizodeId = 168;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� �� ��������, ��� �� ����� ��� ���� ������� � ����� �� ������ � �������, ����� ����� �� �� ��������� � �������. ������� ��, ����� � ������� ������ �� ������������ �� �� ���������� ����������, �� ����������?\r\n����� � �� ���� �� ������������ ���� ����������� � ������ �� ������� �� ��� �����, �� ��� �������� �������� ����������� ������� ����� �� ����� ������ ������, ��������� �����. ���� �� ���������, �� ���������� �� ����������� �� ������������, �� �� ����� ����� ���������, � � �������������� �������� �� �� ��� ���� ����� ������. �� ���������, �� ����������� ������� �� ������� ��� ����� ���� �������������� ������������ �������� � ������� ����������� ��������� MAG 77, ����� � ������ ������������ �� �������� ��������. ������ � � ����������� � ����� ����� �������� �������� �� ������� � �����, �������� � � ����� �����.\r\n��� ��� �������� ������� � ����. ����� �� ������ 300 �����, ����� ����� �� �� ���������.\r\n�� ������ �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode169Chois1()
		{
			int currEpizodeId = 169;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ������ ��� ������ �� ���������� ��������� ��������������, �� �� �� ���������� ����� � ����������� �� ���������, ������ �� �������� ����� ���� �� ���������� ��.\r\n������ �� �������� � ����� ��������� �� ������� �� �������� � �������. ������� ��, ����� � �� ���� �� ������������ ���� ����������� � ������ �� ������� �� ��� �����, �� ��� �������� �������� ����������� ������� ����� �� ����� ������ ������, ��������� �����. ���� �� ���������, �� ���������� �� ����������� �� ������������, �� �� ����� ����� ���������, � � �������������� �������� �� �� ��� ���� ����� ������. �� ���������, �� ����������� ������� �� ������� ��� ����� ���� �������������� ������������ �������� � ������� ����������� ��������� MAG 77, ������� ������������ �� �������� ��������. ������ � � ����������� � ����� ����� �������� �������� �� ������� � �����, �������� � � ����� �����.\r\n��� ��� ������� �� ������� � ����. �� ���������������� ����� �� ��������� �� 100 ������ ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode169Chois2()
		{
			int currEpizodeId = 169;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� �� ��������, ��� �� ����� ��� ���� ������� � ����� �� ������ � �������, ����� ����� �� �� ��������� � �������. ������� ��, ����� � ������� ������ �� ������������ �� �� ���������� ����������, �� ����������?\r\n����� � �� ���� �� ������������ ���� ����������� � ������ �� ������� �� ��� �����, �� ��� �������� �������� ����������� ������� ����� �� ����� ������ ������, ��������� �����. ���� �� ���������, �� ���������� �� ����������� �� ������������, �� �� ����� ����� ���������, � � �������������� �������� �� �� ��� ���� ����� ������. �� ���������, �� ����������� ������� �� ������� ��� ����� ���� �������������� ������������ �������� � ������� ����������� ��������� MAG 77, ����� � ������ ������������ �� �������� ��������. ������ � � ����������� � ����� ����� �������� �������� �� ������� � �����, �������� � � ����� �����.\r\n��� ��� �������� ������� � ����. ����� �� ������ 300 �����, ����� ����� �� �� ���������.\r\n�� ������ �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode170Chois1()
		{
			int currEpizodeId = 170;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� ��� ���� �� �������������� ����, �� ���������� �� ������ ���� �������� � ���-������� �������� �� ������ �������. ��� ���������� �� �� ����������� �� ������� �� �������� � �� ������� �������. ������� ��, ���� �� �����, �� � ������� ���������� ��� � �������� �� �������� � ���� ��� ����� �� ���� �� ���. �� ������� � �� ������, ���������� �� ������� ������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode171Chois1()
		{
			int currEpizodeId = 171;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ��� �������� �������! � ������ ������� ��� ������ ������ ��. � ��������� � �������� ���� �� ������ ��������������! ���������� �� �� ��������� ������������. �������, ����� ����� ��������� � ������� ��� �������� �����, �� ���������! �����������, �� �� �� �������� ����� �����.\r\n� ������, ���! � ��������� ���� ����� ������������. � ������ ��! �������!\r\n�������� � ��������, ��������� �� ����������� ����� ��������� ��������������� � ���������� ������ � ���������� ��������� ������� �� �������� ������. ����� ������������� � �������� ������� ��� ��������� � ������ ���������� ��������� �� �������� ��������������. ������� ������ �� ������� ����� �� ���� ������ � ����� ������� �� �� ������ ������. ���� ��������, �� �� �� ����� � ������ � ������, ������ ��������� �������� �� ���������� ��������� ��������� ������� �� � �������� � �������� ����������. ��� ������� ���� � ��������� ����� � �����.\r\n���� ������� ������ ��������� �� ��������, �� �������� � ��� ���� ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode171Chois2()
		{
			int currEpizodeId = 171;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ��� �������� �������! � ������ ������� ��� ������ ������ ��. � ��������� � �������� ���� �� ������� ��������������! ���������� �� �� ��������� ������������! �������, ����� ����� ��������� � ������� ��� �������� �����, �� ���������! �����������, �� �� �� �������� ����� �����.\r\n� ���, � ������� ��������� ���� �����! � ������ �� ���� ����� ������������. � ������ ����� �������� ���� �������.\r\n����� ������ �� ������ ����?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode171Chois3()
		{
			int currEpizodeId = 171;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ���������� ��� ������! � ������ � ��������� �� ������������. � ����� �� �������� ������������ �� ����������������. � �������� �� �� �� ��������!\r\n� ��������, ���! � ������ �� ������������. � ���� �����: � ������ ��!\r\n������� ���� �� �� ������ ����. �������� � ��������, ��������� ������� ��������� ��������������� �� ����������� ������� � �� ��������� ������������. �������� ������������� � ����� ������� ��������� ��� ���� �� ��� ������� ������� � �������� ��������������. �������� �������� �������� ��������� ������ ������ � ����� �� ����������� ������� � ����� ����� ����� � �������. �� ������ ���� �� ����������� ������ ��������� ������� � ������ ����� �� ��������, �� �������� � �������� ���� ������ ������� ������ ��������.\r\n� �����, ��������! � �� ����� �� �� ������� ��. � ������� ������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode171Chois4()
		{
			int currEpizodeId = 171;
			string currentChois = 4.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ����� �� ������� ������ ������� ������� � ������� ������ ������. ��������� � �� ������, �������� ������, ������ �������������� � ������ � ������� ������� ������. ������� ��� ����� ��� ������, �� ��� �� �������� ������� ������� �������������� �������.\r\n�������� �������, �� ����� ��������� �� �������� �� ������, ������������ �� ����� ���������� �� ����������� �� ���������. ���� �� �������� ������� ��������� �� ������� �� ���������� � ���������, ������� ��������� �� �������������.\r\n���� � ���� ��� � �� ������ �� ������� � ����� �� �� ������ �� ������ ��������. � ����� ���� ����� ������ �� ���������, �� ����� ��� ���������� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode172Chois1()
		{
			int currEpizodeId = 172;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[7] = 20;
			this.playerStatus.Checksums[2] = 2;
			this.playerStatus.Checksums[3] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode173Chois1()
		{
			int currEpizodeId = 173;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode174Chois1()
		{
			int currEpizodeId = 174;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��������� ��� ���� �� �������������� ����, �� ���������� �� ������ ���� �������� � ���-������� �������� �� ������ �������. ��� ���������� �� �� ����������� �� ������� �� �������� � �� ������� �������. ������� ��, ���� �� �����, �� � ������� ���������� ��� � �������� �� �������� � ���� ��� ����� �� ���� �� ���. �� ������� � �� ������, ���������� �� ������� ������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode175Chois1()
		{
			int currEpizodeId = 175;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ����������� �� ���� �� �������� ��� �������� � ���������� �� ������� ��������� ������������. ������� ������ ���� � �������� ������������ ������ � ����������� �� ������ ������� ��������� �� ������� � ����� �������. ����������� �� ������������ ���� ��������, ��� �� ������� ������� �� �� ��������� �� �������, ������� �� ���� �������� � ���� �� ������ �� �� ������ ��� �������.\r\n������ ������������ ��, �� �� ������������� �� ���� �� ��������� ����, ����� ��� �� ���� �� ����. �������, ����� ������������ ����������� ����� ������� �� ����������� � ������� ����� �� ������� ����� �����. ������ ������� ������ ���� �� ���� ���������� �� ���� �� ��������, �� ���� ��� ������� � ������ �������. � ���� ����� �� �������� ����� ���-��� ������� �� ������������.\r\n����� ��������� � ������ �������. ���� �� �������?\r\n���������� ���� �� �������� � ���� � ���� �� ������� ���������. ��� �� ��������, ���������� ��� ���������� ������� � �������. ������ � 50 �� 50.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode175Chois2()
		{
			int currEpizodeId = 175;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� ������, � ���� ���������� � ����� �����, ��� ������ �������� �� ����� ����� ��������� �����. ���� �� ������� ������� ��������� ������ �� ���������, �� ��� ��� �� ��������. ��� � �������� �� ��������� ���� ������������ ����������� �� ������� ����� ����� ����� ����������������. ������� ��, ������� ���� �� ���� �� ���� ����������� �� ������ ������� ��� � �� ���� � ��������� �� �� ��������. �����, �� ���������� ��������� ������ ���� �� ���� ������� ������������ �������� � ���� ������� �� ������ ������� �� �������� ���� ������� �� ��������, � ���� �� �������.\r\n��� ��� ����� ����� �����, ���� �� �������!\r\n���������� ���� �� �������� � ���� � ���� �� ������� ���������. ��� �� ��������, ���������� ��� ���������� ������� � �������. ������ � 50 �� 50.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode175Chois3()
		{
			int currEpizodeId = 175;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ �� �������� � ������ ������� ��������� ����� ������, �� �� ������ �� �������, �� ���� �� �������� ���� �����. ������� ������� ���� �� ����������� ���� �� ���� �� �� �������� �������. ������ � �������������� ��� �� ������� ������, ��� ������ �� �� ��������, ����� �������� ������.\r\n������ ������������ � ��� ������ ����� �������� �������� ��� ������ ������. �� ��� �� �� ��������� �� ������� ���������� ��������� � ���� �� ������� �� ������� �������, �� �������� � ������� ������ �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode176Chois1()
		{
			int currEpizodeId = 176;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[1] = 5;
			this.playerStatus.Checksums[5] = 10;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �������� �� ���������� ������� � ���� �������� �� ����������� �� �� ���������, ������� ���� ��� �������. �������� ����� ������� �� ������������, ���� ����� � ���� �����, �� ���� ������� ������� ���������� ��� ������� �������, ����� ��������� ������ ������� � � ������ �� ������. ������� ������� �� �������� ��� ������� �� ���� ���������� ��������. ������������ �� ������� ������� � ���������� � �������� ������ �������.\r\n����� �������? ���� �� �������� �� �������� � ������� ����� ������ � �������� �� �������� ���� ��-�����, � ���� � �� �� � ��������. ��������� � ����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode177Chois1()
		{
			int currEpizodeId = 177;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode178Chois1()
		{
			int currEpizodeId = 178;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ������ ������ ��� ���������� �� ������� ������� ������������ �� ����� ������ ������. �� ���� �������� ����� �� �����, ��� ������� �� �� �����. ������ ����������� �� ����������, �������� �� ��������� �����, �� ���������� ��������� �� ������� �� ���������.\r\n�������� �� ��������� � ������� �������������� ����� �������� ����� � ������� � ������, ������ ����� ��������� �� ��������� ������� ������ ������ � ������ �� ������� ���������. ������� ��������� ����� �� ������ ������ � �� ������ � ���������� ����.\r\n�������� �� ��������� ���������� � ���� ������� ������ �����, ����� �������� �� �� �������� ��� �������������. ������ ������ ����� �� ������ ��� ������� �� �� ����� �� �������� ��� ������, �� �� ������� ��������.\r\n�������� �� �������� � ������ �� ���� � �� ������� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode178Chois2()
		{
			int currEpizodeId = 178;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ������� ������� �� ����� � ���� ���� �� ����� �������� ����� ��� ������� ������� �� ���������, ���������� ���������� �� �������� �������. ����������� �������� �� ������ ��������. ������ �� �������� �������, ����������� � ������ ������, ��������� ����������� ��� ����������������. ���� ��� ����� �� ������� ����� ������� ������, ������� � ��� ������� ������. ������� ����������� ������� ����� �� ��������� � ����� ������ � ���������� �����, �������� �� ����� ������������� �������, ����, ������������ � ����� ��������. ��� ��������� �� ���� � �������� ����� ����� �� �� ������� ���� ������� ������������ ��� ������� ��������� �����. �� ���������� �� ��������, ����� ��-�����, �� ������ � ������� ���������� �������� ������.\r\n������� �� ����������� ����� ������ ���� �� �� ������ � ������ ��������, � �� ������ ����� ���� �����. ���� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode179Chois1()
		{
			int currEpizodeId = 179;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� ������� �� ����� ����� ������� �� ��������� � ������ �������� ������, ������� ������� ����� �� �����. ������ ������� ������ �� ��������� � ����������� �� ������� ������� ��������, �������� ����� �� ���� ���������. ���-�������� ������, � ����� ���� �� �� �������, �� �� ����� 500 ����� � ����������, ����������� �� ��������������� �� ������. ���� � ����� ���� �� ������ �� �������� ������������.\r\n���� ���������� �� �������� �������� ��, ���� ������� ����� ����������� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode179Chois2()
		{
			int currEpizodeId = 179;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� ��� �� ����� ��������������� ���� �� �������� �������� � �� ������ �� ������� ����, �� ����� �� ������. ���� ��� �����������:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode179Chois3()
		{
			int currEpizodeId = 179;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������, �� ��� ���� ����� ����� �������� �� ���� ���� �� �������� �������� �������� �� ���, ����� � �� ���������� ����������� ��������. ����������� ����������� � ������ ���� � ������ ������� ������� ����� ������� ������, ����� ������ �� ���������.\r\n������� ����� �� ��� �� ������� ����� ��������� �����, ����� ��������� � ������������ ���. �� �������� ���� ���� �� ��������������� �� ������ � ��� ������ ����� ���� �������� ������ � �� ������ � ���������� � ������� ������. ����� ������� � �������� ��������� �������� ������ �� ����� ��. ������� ��� ��������� ������� � �������� �� ������, �������� ����� �� ������ � ������� �������������.\r\n� ����� ������ �� ������� ����� �� �������� �� ������������� ������� ������� � ����� ��������� ���� �������:\r\n� ��������� ����� ������� �� ������! ������� � ��������� �������! ������ ����� ����� �� �� ������� ��� ������ �� �������! ���������� ���� �� ������� � ��������� ��! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� �������� ��, �������! � ������� ������������ ��, �� �������� �� �� ��������� �� ������ �� �����������.\r\n� ������� �� �����������, ��� � ������ �� ���� ����� ������������ ������������.\r\n� ������, ��������! � �������� �� ����������� ��.\r\n� ���� �� ��������, ��� � ������ ���� ������� � ���������� �� ���������� ������ �� ������. � ������� ������ � ���� ����� ������. ������ � ���� ��������. �������� ������ ���� �� 250 �����. ������ � ��������. ��� ������!\r\n� ��������� ����� ������� �� ������! ������� � ��������� �������! ������ ����� ����� �� �� ������� ��� ������ �� �������! ���������� ���� �� ������� � ��������� ��! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������! � ���������� �� ������� ��������� �������.\r\n� �������� �� ����� � ����������� ����������! � ��������� �����. � ��������� �����, ���������!\r\n� ���� � ��������? � ����� ������� ��� ������ �� �������. � �� �������� MAG 77! ������ ������! ������ �� ������? � �������� � ������������� ��������� ����������� ���������.\r\n� ������� ��� ������� �������� ���� � ����� ����������. � ���������� ����, ��� � ������ �� ��� ���� ����� � �������� ���� � ���������� ������, �������� � ������ ����������.\r\n� ���, ���� � ����� � ������ �������, ���� ������ ������ ������� �������. � �����, ��� ���� ��� �������.\r\n� ����������� �������, ���! � �������� ���� �� �����������.\r\n� ��������! � �����, ���� ������� ������� �� ����������� �����. � ���� �� ������ � ��� � �������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode179Chois4()
		{
			int currEpizodeId = 179;
			string currentChois = 4.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������, �� ���-����� � �� �������� ���� ���� �� ��������, ���� ������� ����������������, � � ��� � ����� ��������. ���������� ������� �� ����� ����� �� �������� � ��� �� �� ����� ������, ����� ������ �� ������ �� �����������.\r\n������� ����� �� ��� �� ������� ����� ��������� �����, ����� ��������� � ������������ ���. �� �������� ���� ���� �� ��������������� �� ������ � ��� ������ ����� ���� �������� ������ � �� ������ � ���������� � ����� ������. ����� ������� � �������� ��������� �������� ������ �� ����� ��. ������� ��� ��������� ������� � �������� �� ������, �������� ����� �� ������ � ������� �������������.\r\n� ����� ������ �� ������� ����� �� �������� �� ������������� ������� ������� � ����� ��������� ���� �������:\r\n� ��������� � ������ �� ����������������! ������� � ��������� �������! ������ ����� ����� �� �� ������� ��� ������ �� ������� ���������� ���� �� ������� � ��������� ��! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ��������� ��� ����� �� ����� � ������ �������, ���� �������� ���� ����� �������� �� �������� �� �����. � ����� ���� ���� �� �� �������� ����.\r\n� ��������� ����� � �� �������, ���! � �������� ���� �� �����������.\r\n� ����������� �������! � ���� ����� ������ ����.\r\n� �� �������� �� ��������! ������� �� ����� � ��������� ������! � ������ �� � �������� ������� �� ����������� ����� ��� �������� �� �����������.\r\n��� �� ������ ����� ��������. ������ � �������� � ������� ������� ����� � �������� �� ���������� ��������.\r\n������ � �������� � �������� ��� �� ��������, �� ���������� ���� �� ����������� � �� ������ ����� ������� �����, ��������� �� ������� ����� � ������ �������� ������.\r\n� ������� �������, ��� � ������� ����� ���. � ������ �� �� ������. ����� � ��������, �� � � ������ �������; ������� � �� 3 ��������.\r\n� ����� ���� �� ��������! � ������ � ���� �������� �������� ���� ��� �������, ���������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode180Chois1()
		{
			int currEpizodeId = 180;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " � ����� �� �������� � ������, ���� ���� �� �������� �� �������� ���.\r\n���������� �� ��������� �� ������, ��������� ������ � ���� ���������, ���������� �� ������� �� �������� ���������. �� ����� 100 ����� �� ��� � ��������� ������ �� ���������������. ���� ������� ���� ����� � ����� ������ ��� ������ � ������� ����� �� �������� ���, ����������� ��� �������� �� ������ � ����� ��������� ���� ���������:\r\n� �������� �� ������ �� ���������� � ��������! �������� �������� � ��������� �������! ����� ����� ������� �� �� ���������!\r\n� ����� �����, �� ��������? � �������� ���� ���� ���� �� �����������.\r\n���� ������ ���� ���� �� �������, �� �������� �������� �������� ������ � �������� �������� ����������� �������, ����� ���� � ������� ��� ��� ����� �� ����������� �������.\r\n� �������� �� ������ �� ���������� � ��������! �������� �������� � ��������� �������! ����� ��� ������� �� �� ���������! � ���������� ������ ������ �� ������.\r\n� ����, ����������� � ����� ����������; ��� ��� ���� ����� �� ���� �������� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode180Chois2()
		{
			int currEpizodeId = 180;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ���������� ���� �� ����! � ������ ��. � ����������� ������� � ������� � �� ������ ���� ������� �� ���������������!\r\n���� ������� ���������� ������ �� �������� ���� ��������� ������� ����� ��� ����������� �� ��������� ������. �������, ������� ��, � ��������� � ������ �� ����� ��� �� ��������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode180Chois3()
		{
			int currEpizodeId = 180;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �� ������� �� ������ ���������� ���� � ��������� ��. � � ��� �� �� ������ ����� � ���-������� � ������������.\r\n���������� �� ���������� � ���� ��������� ��������� ������, ���� �� ��� �� ����� �� ������, ������ ���� � ����� �����. ������� �� �������� ����������� ���������� � ����� ��������� ���� �������:\r\n� ���������� ���� �������� ������, MPR/12-�! ���������� ��������� �� ��������������.\r\n� ����������� ��! �������! � ������ �������. � ��������� ��!\r\n����� �����! ����� ��������� ������� ��������� ����� � ������� �� ������ ���. ������������ ������� � ������ � ��������� ���� �� �� �������, �� � ������ �� ����� ����� ��� ���������. �������� �� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode181ThrowExceptionChois1()
		{
			int currEpizodeId = 181;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 0;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode181Chois1()
		{
			int currEpizodeId = 181;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ����������� ������������� � ��������� �� ���������, ����� �� ������ ��� ��������� ������ �� ��������� � �������� ��������� ����������� ������ ����� �� ������������ ����� �� �������. ������� �� �� �������� ������ �� ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n���� ��� �� ���������� �� ������� �� ����������, ����� �� �������� ��� ��������� ������ � ��������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode181Chois2()
		{
			int currEpizodeId = 181;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �� ������ ����, ������� �� ���� �����, ���������� ����������� ��������. �� ������ ��� ����� � ���� �������, �� ������ �� ���, ������ ��� �� ��� ���� ������� � ����������� �� ��������� ����������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode181Chois3()
		{
			int currEpizodeId = 181;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� �������� ��������� �������, �� � ��-������ �� �������� ����� �� ������� �� ���������� � �������� � ��������, ������ � ����������� ����� ���� ��������. � ������ ���� � ������ ����� �� ��������� ��� ���� ������������ ������������. ������� ������� �������� �� ������� ��������� ���� �� ��������� �� �� ����������� � �� �� �� �������� � ���������. ������� �� ������������ ������� � ����� � ����� ��� �����. ������� ��������� ���������� ������������� ���� ����� �� ������� �� �����. ���� ���� ���� ��� �� �������� �� ������ ������� � �� �������� ��� ������ ����� �� �������.\r\n������� ������ �� ������������ ���� �������� ������� �� �������� � ���� ����. ���������� ��, ����� �� ����� �������, ������� ���� �� ������� ������� ���� � ���� � ������ �������� �� ������� �� �������� ����������� �� ������� ������� ��������.\r\n� ����� �� �������� � ������� ��������� ������. � �� ����� ������� ��������� ����� ����� ������ ������. ������� � �������� ����� �� ����������. ��� �������� �����, �� �� �������.\r\n� ��� �� ������! � �� �� ������ ���� �� ����������� � ������� ������: � ��������, ���������, �� ����� �� ���� ���� ����!\r\n� ����� �� ������? �����������! � � �������� ���� �� ������� ��.\r\n��� ����� �� �����������, ������ ������ ����� �� ������������� ��. ������ �� ������, �� �� ���� �������� �� ������ �� ������ �������. ���� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode182ThrowExceptionChois1()
		{
			int currEpizodeId = 182;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 0;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode182Chois1()
		{
			int currEpizodeId = 182;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[6] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ���� ����������� ������������� � ��������� �� ���������, ����� �� ������ ��� ��������� ������ �� ��������� � �������� ��������� ����������� ������ ����� �� ������������ ����� �� �������. ������� �� �� �������� ������ �� ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n���� ��� �� ���������� �� ������� �� ����������, ����� �� �������� ��� ��������� ������ � ��������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode182Chois2()
		{
			int currEpizodeId = 182;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���������� �� ������ ����, ������� �� ���� �����, ���������� ����������� ��������. �� ������ ��� ����� � ���� �������, �� ������ �� ���, ������ ��� �� ��� ���� ������� � ����������� �� ��������� ����������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode182Chois3()
		{
			int currEpizodeId = 182;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� �������� ��������� �������, �� � ��-������ �� �������� ����� �� ������� �� ���������� � �������� � ��������, ������ � ����������� ����� ���� ��������. � ������ ���� � ������ ����� �� ��������� ��� ���� ������������ ������������. ������� ������� �������� �� ������� ��������� ���� �� ��������� �� �� ����������� � �� �� �� �������� � ���������. ������� �� ������������ ������� � ����� � ����� ��� �����. ������� ��������� ���������� ������������� ���� ����� �� ������� �� �����. ���� ���� ���� ��� �� �������� �� ������ ������� � �� �������� ��� ������ ����� �� �������.\r\n������� ������ �� ������������ ���� �������� ������� �� �������� � ���� ����. ���������� ��, ����� �� ����� �������, ������� ���� �� ������� ������� ���� � ���� � ������ �������� �� ������� �� �������� ����������� �� ������� ������� ��������.\r\n� ����� �� �������� � ������� ��������� ������. � �� ����� ������� ��������� ����� ����� ������ ������. ������� � �������� ����� �� ����������. ��� �������� �����, �� �� �������.\r\n� ��� �� ������! � �� �� ������ ���� �� ����������� � ������� ������: � ��������, ���������, �� ����� �� ���� ���� ����!\r\n� ����� �� ������? �����������! � � �������� ���� �� ������� ��.\r\n��� ����� �� �����������, ������ ������ ����� �� ������������� ��. ������ �� ������, �� �� ���� �������� �� ������ �� ������ �������. ���� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode183Chois1()
		{
			int currEpizodeId = 183;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ � ��������� ������ �� ���������, ��� �������� �� �� �������� ���������.\r\n������ �� �� ����������� ������ �� ��������� ������ ������ ������ ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode184Chois1()
		{
			int currEpizodeId = 184;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� �� �� � ������� �� ����� ������� �����?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode184Chois2()
		{
			int currEpizodeId = 184;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� �� �� � ������� �� ����� ������� �����?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode185Chois1()
		{
			int currEpizodeId = 185;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������������ �� ����� � ������ �� ������, ���� ���� ���������. � ������� ���� ���������! ������� �� ��� ������������ �� �����������!\r\n���� ��������� ����� ������ �� �����������, �� �� ������������ �������� � ������������ �� ������, �� �������� �� ��������� ����������� �� �������� ������. ����������� ��� ��������, ��� ��� ��� �� ������������ ������� �������, ��� ���� ���� �� �� ������.\r\n� � ���� ����� � ��������� ���� �� �������� �� ���� ��������� ���� ����� ��������� �� ������� � ����������������� ������. ����� �� ������, �������� �� �������� � ��� ������ ��������� �� ����������� � ���� ������� �� ����� �� �� �������� ���� �� ����������� ����� ���� ��� �������.\r\n� ������ ������ �������� �� ��������� �� ����� �������, ���������! � �����, ������ ���������� �� ��, ���������� �� ����������������� �������. � �� �� ���� �� �������� � ��������� �� ����� ���������� ���������. ���� ��������� ������� �� 30 ������. ������ �� �� ������ ����� �� �����, ��� �� ����� � ������� ��� ���� �������?\r\n� �� �� �������� �������, ��������! � ������� �������� �������� �������� �� ������� ������; ��� � �������� � ��������� ������ ������� � �� ���� �� ������ ������� �������. � ����� ���� �� ������ ���� ����� ���������, � ��� ������ �� ������� �� �� ���������.\r\n� ���� �� ��, ���� �� ����� �������������� ���? � ������ �� ���������. ��� ���� ����� ������� ����������� ��������� � ���� �� ������� �� �� ������ ����.\r\n� �������� ���� ������� � �������������.\r\n� � ����� ������������, ���� ��? � �������� ������� ���������.\r\n� ���������� ��������, ��� � �������� ��������� ����������. � ���� �� �� �������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode185Chois2()
		{
			int currEpizodeId = 185;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������������ �� ����� � ������ �� ������, ���� ���� ���������. � ������� ���� ���������! ������� �� ��� ������������ �� �����������!\r\n� ���� �������� ������������, ��������:\r\n� ��������� zzzz, ���� zzzz� ��������� zzzz� ��� ������ ������� � � ���� �������� �����������, �� ������� �� ������������ �������.\r\n��������� ����� ������ �� �����������, �� �� ������������ �������� � ������������ �� ������ � �� ��������� ����������� �� �������� ������. ����������� ��� ��������, ��� ��� ��� �� ������������ ������� �������, ��� ���� ���� �� �� ������.\r\n� � ���� ����� � ��������� ���� �� �������� �� ���� ��������� ���� ����� ��������� �� ������� � ����������������� ������. ����� �� ������, �������� �� �������� � ��� ������ ��������� �� ����������� � ���� ������� �� ����� �� �� �������� ���� �� ����������� ����� ���� ��� �������.\r\n� ������ ����� �������� �� ��������� �� ����� �������, ���������! � �����, ������ ���������� �� ��, ���������� �� ����������������� �������. � �� �� ���� �� �������� � ��������� �� ����� ���������� ���������. ���� ��������� ������� �� 30 ������. ������ �� �� ������ ����� �� �����, ��� �� ����� � ������� ��� ���� �������?\r\n� �� �� �������� �������, ��������! � ������� �������� �������� �������� �� ������� ������. ��� �������� � � ��������� ������ ������� � �� ���� �� ������ ������� �������. � ����� ���� �� ������ ���� ����� ���������, � ��� ������ �� ������� �� �� ���������.\r\n� ���� �� ��, ���� �� ����� �������������� ���? � ������ �� ���������. ��� ���� ����� ������� ����������� ��������� � ���� �� ������� �� �� ������ ����.\r\n� �������� ���� ������� � �������������. ���� ������?\r\n� �������! � � ����� ������������! � ������ �� ���������.\r\n� Zzzzz� �� �����! ��������� zzzz� �����! � ����������� �� ��������� ��. � ������� � ���������� ��� zzzz� ���������!\r\n� ���� �� �����������! � ������� ������� �����������. � �������� �� ����������� �� �� �� �������! �������, ������ �� �� �� �������� �� ��������! ���� ����� �� ������. � ���, ��������, ��������� ��� �� ��������, �� ��� ��������� ������������� �� ������ ��! � ������ ����� �� ��-������ �� ������ ���.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode186Chois1()
		{
			int currEpizodeId = 186;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode187Chois1()
		{
			int currEpizodeId = 187;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[7] = 20;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode188Chois1()
		{
			int currEpizodeId = 188;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode189Chois1()
		{
			int currEpizodeId = 189;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �� �� ������ ��-�����! � ������, ���� ������ ���������. � �� ����� ������! � �������� ���� �� �����������.\r\n������ ������� ���� ���������� �� ��������� ���� �������. ���������� �� ������������ �����, ������������� �� ������� � ������ � �� ������������� ����� �� ������ ����� ���������, � ����� ������� �������� �� ����������� ������ ���� � �����. ����� ���� ���� ��������, �������� �������� ��������� ���� ��-������ �� ���������� ������� ������� ����� � ������� ������ � ������� ��� �� ������� � ����� ���� �����. ���� �� ������� ������� ������ �� ������� � ������� ��������� �� ������ ��� �� �����.\r\n� ���� �������! ����� ��! � ����� �� ��������� �� �� �� ������� ������. � �� ����� ���� �� �� ��������.\r\n��� �� ������ �� �� �������, �� � ��������� ������ �� ����� � �� ������ � ��� ���� ����� � �������.\r\n� �� ������! ���� �� �� ��������! � ������ ���������� �� ������ �� �� �������. � �������� ������� ����! �����!\r\n� ���������, ��������! ����, ����� ��-������ � ���� �������� ����� � ������� ������ ������ �� ������� �������� ����������.\r\n��������� �������� �� ��������� ������� �������� ���� ��� ��������� ������. �� ��������� �� ������� ����� ������� ������������ ��������� ���� � ��� �� ������ �������� �� ���������� � ��� ����, ������� � ������������� �� ������ ����� ��������������� �� ��������. � ������ �� ���������� �� ������� �������� �������. ���� �������� � ���� ����� ��, ������������ ������������ � � ������� ����� ���������� ������������ ����. ����������� ������ � � ��������� ����� ��������� ��������� ������� ������� ������������ �������� ����.\r\n�� �������� ��������� �� ������ � ����� �� ������ ��. ���������� � ��������� �� �������� � ���� ��� ������ �� ���������, ������ � ����� �������� ����� ����� ������ �� ������ � ������ ����� ��� � ����� ��������� ���������� ��� � ��������� �� ������� ��.\r\n� ����, ������� ��! � ������� ���������� �� ��������� �� �� ���������� ������ ���������� �����. � �����, �� ���� � �� ��������� ��� �� ����! ��������� �� � ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode189Chois2()
		{
			int currEpizodeId = 189;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������� ��! �������! � ��������� ����� � ���� �� ������������ ��� ������� ������, �� ����������, ��������� �� ���������� ���������.\r\n� � ���� ����� �� ������������� ������ �������������� �� ��������� ������ ����. ������������ �� � ������� �� ������, �� � ������� � ������ ��������� ������� ������������� �� ���� �� �� ������. ������������ ��������, �� � ������ ����� ����, ������ ���� ������ �� ������������, � � ������ �� ���� �� ����� �� ���. ���������� �� �������, �� �� ������� �������, �� ������ �� ����� ����������� � ������� �� ��� �������. ��� ��������������� ��� �� ���������� ������� ����� ������, �����, �� ������ ���������, ������� ����� � ����� � ����� � �� �� ������� ������ ��, ������� ���������� ���������.\r\n��� ���� �� ������� �� ����� � �������, ���������� �� ������� �� ����� � ������ �� � ��������, �� �� � ������� ����. ������������ �� ����������� ���������� �� �������, � ���� �� ��������� ������� �� ������� ����� �� �������.\r\n������ �� ��������� � ���� ��� ���� ��������� �� ���������. �� �� �������� ������������, ����������� ����� �� ����� � �� ��������� ��������� ��� ���� ��������� ��������� �����. � ������ � ��������\r\n����� ����� ������� ����� �������, ����� ���� �������� �� ���������� ��� ������� ������ ����������� ������ ����������� ����� ������� � ����� ������. ����������� � �������� �� ����������� ������������� �� � �������� �� ������ ��� ��-����� ���-������� �� �����������.\r\n� ����, ����� � �� ��������, ������� �� �� ������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode190Chois1()
		{
			int currEpizodeId = 190;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ������ �� �� ��������, ����� ������� �� �������. ��������, ���� �������� � ����������� �� ����, ��������� ������� ������� ����� � ����� � ����� ������ ������� �����, ��� ���� �� �������� ����� �����. � ������������� ������������ ������ ����� � ����������, ��� �� ������� ��������, �� ����������� ��� �������� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode190Chois2()
		{
			int currEpizodeId = 190;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ������ �� �� ��������� ���������� � ���� ������� ������, ����� �� ����� �� ������������ �� �������, ������� ����� ��������� ������ �� ��������, ����� �� ������������ ����� �� �������. ������� �� �� �������� ������ �� ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n���� ��� �� ���������� �� ������� �� ����������, ����� �� �������� ��� ��������� ������ � ��������� � ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode191Chois1()
		{
			int currEpizodeId = 191;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������, ������� ��� � ����� ���������! ���������� �� ��� ������� ��� ��� ���� �� ������! ���������� � ���� �����!\r\n�������� �� �������� �� � ���������� � ���� �� �������� ������� ��������, �� � ����� ������ ��������; ������ ���� � ���������� ��, � ��������� �� ������������ � ���������� ����.\r\n�� ��������� ���� � ����� � ��, ���� �� ������������� ��� ������ ��, ����� ������� �� �������. ������� �������� �� ������� ��� ���������� �� ���������� � �������� ������� �� ����������. ���������� � ���� ������� �� �������� ������� � �� ��������� ����� �����, ���� ���� ������� �������� �� ���������. ��������� �������� ���� �����, ��� �� ������ �������� �� ����������� �� �������� �� ��������, ���������� ����� �� �� ���������� � �� ������ ��������� ��������� �� �������.\r\n�������� �� ������ �����, �� ���������� ������� ��� ��� ��������. ���� ����� ������ �� ������� ����� �� �� ������� � ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode191Chois2()
		{
			int currEpizodeId = 191;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� �� �������� ������ � � ������� �������� �������� ��-������� ��������� ������� �� ��������. ������� ����������� ��������� ���� �������:\r\n� ������� � ��������� ������� �� �����������. ������������� �������� ������� �� ������. ���������� �� �������� ���� �������� ������. ������� ������ �� �� ���������!\r\n� ��������� ��! �������! � ����� �������� � ������ � ������ �� ������ �����.\r\n� �����, ���������� �� � ���������! � ��������, ������ ������� ������ ��. ���������� ����������! ����� ������ �� �� ������!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode191Chois3()
		{
			int currEpizodeId = 191;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����������� �� �� ������� �� ������� � ����������� �� ���������, �� �� �� ����� �� �������� ������ �� ��������. ���� � ����������� �� �������� �� ����� �����������, �� ������� �� �� �������� �� ���������������� �������� � �� ����� �� �������� �����.\r\n� ������ ����� ��! � ���������� �� �� ������������ ���� �� ������� � �� ���������� ������� �� �����:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode192Chois1()
		{
			int currEpizodeId = 192;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode193Chois1()
		{
			int currEpizodeId = 193;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ � ��������� ������ �� ���������, ��� �������� �� �� �������� ���������.\r\n������ �� �� ����������� ������ �� ��������� ������ ������ ������ ���������������, �� ��� � ��������������� �� ���������. �� ������������ ���� ���������� �������-�������������� ������� �� ������� �� ���������, ����� � ����������� ����� � ����� �� ����������. ������, �� ������������ �� ��������� �� �������� � ������� �� ��������� �� ���������� ����� ���������� �����, ����� �� ������� ���������. ��� ������ ����� �����, �� ������� �� �� ��������� � ���������� ����� ������.\r\n";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode194Chois1()
		{
			int currEpizodeId = 194;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ������ �� �� ��������, ����� ������� �� �������. ��������, ���� �������� � ����������� �� ����, ��������� ������� ������� ����� � ����� � ����� ������ ������� �����, ��� ���� �� �������� ����� �����. � ������������� ������������ ������ ����� � ����������, ��� �� ������� ��������, �� ����������� ��� �������� ������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode194Chois2()
		{
			int currEpizodeId = 194;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ������ �� �� ��������, ����� ������� �� ������� � ������� ��������� �� ������ �� �������� ������ �� ����������. ��� ���� �� �������� ����� �����, ��������� �� ������� �� �������� ����������. ������� ������� �� ������� �� ������� � � ������ ����� �� ���������������, ���� �� ��������� �� ���� �� ����. ���� ���� ������ ���� ����� ��������, ������� �� ����������� �� ���������� �������. � �������� ������ �������� ������ �� �������� �������, � ����, ���������� ��� ���������� �� ����� ����� ������� �������. ���� ����������� ����� �������� �� ����� �� �� ������� ����� ������������ � �� ����� ����� �� ���.\r\n�� ���������, ������ �� ������� ������������� � �� ������ �� ������� ����. ����������� �� ������� ������ ����, ������� ������ �� � ����� ������� �� �������, ������ ���������, �� ���� � ������ �����.\r\n���� ������ �� �������� ���� �����:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode195Chois1()
		{
			int currEpizodeId = 195;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� ����, ��������� �� �� ���� ��, � �������� �������� �����, ����� �������� ���������� � ���� �������� ������� �� �� ���������. ����� ��� �� �������, ���� �������� ������� �� �������� � ������ ������� �����, �� ��� �� ��������� ���������� ������� �� ���������. ����������� ��� �������� ��������� � ���� ������ ������� ���� �������� �������:\r\n� ��������� ����� ������� �� �����������! ������� � ��������� �������! ������ ����� ����� � ���������� ���� �� �� ������� ��� ������ �� �������! ��������� � ���������� �������! ������ ������ �� ���� ���, � � �ѓ �� ����� ���������!\r\n� ���, ��������� ��� ����� �� �����! � ���������� �������. ������� ������� ������� �� ��������� �� �������, �������� � ������� ���������� � ������������, ����� �� ���� ���������� �� ��������� ������ �� �����. �� ����� �����";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode196Chois1()
		{
			int currEpizodeId = 196;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� ��! �������! � ����� ��� ����������� �� ����������� ������������� ���������.\r\n�������� ���� �� ������� ����� � ����� ������ ������������ � ���� ����� ��� ������� ��, ��������� ������� �� �����.\r\n������� ���������� � ���������� ������� ������� �� ������ ������� ��� �� ��������� ��������� ���� � ����� �� ������� �������� �� ����. ��� �� ����� �� ������ �� ��������� ��������, ������������ ������� � ������� � �� �������� ����� ����� ������ ��. �� ����� � �������� ���������� ������� � ������� ������� ��������� �� ���������.\r\n� ���� �� ���������! � ������ �� ����������� ������� �������, ������ �������� � ������ � ���� �� ������� �����. � ���� ��� ��� �� ������ �������, � ������� ���� �������������� �������?\r\n� �����, ����� �� ��� ���������� ��� ������� ��������. ������� ������ � ����! � ��������� � ���� �� �����������. � ������ �� ������, ��� �� �������� � ���������� � � �������� ������ ������, ���� ����� ��������� ��.\r\n��������� ��������� ������� �������� �� �� ���������� ��������� �� ��������. ��� �� �� ����������� �� ��������� ������� �� ��������, ������ �� ����� � ������ ������� ��� ���������������.\r\n� �������� �� ���� ������� ������! � ����� � ��������. ������� ��, ������� �� ��������� ��������� �������, �� ����� ����� �� ���������. � ������ �� ������ ������� ������. �������� �� ���� �� ������ � ������� �� �����������, �� �� �� �� ������� � ������. ����� �� �� ��������� �� ���������� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode196Chois2()
		{
			int currEpizodeId = 196;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� � �������� �������! � ������ �� ��������� ��� ��������� ������ ��������. � � ����������, �� �� �� ������� �� ������� ��! � ������� �������.\r\n��� �� �� ������, ��������� ���� ������, �� �� � ������� � ���� �������� ���� ������� ���, ����� ���������� ������. ������������ � ����� ��� ��� � ��������� �� ������ ���������� � ������� �� ����������, ������ ��������� ������� �� ��������. � ������ ������ �� �� ������ ����. ���� ���� �� ������� � ����� �� ����� �������, ������������ ������ �� ���������� � ������� �� �� ������. ��� ���� ���� � ��������� �� ����� ��������� � ��� ��� ������� ������� �� �� �������. ��������� �� ������ ������ �������� ������� ����� �� ��� � ��� �� ���������� �� ����������� ���� � ���� ���� ��������.\r\n� ���� �� ����������! � ������ �� ����������� ������� �������, ������ �������� � ������ � ���� �� �������� ��������. � ���� ��� ��� �� ������ �������, � ������� ���� �������������� �������?\r\n� �����, ����� �� ��� ���������� ��� ������� ��������. ������� ������ � ����! � ��������� � ���� �� �����������. � ������ �� ������, ��� �� �������� � ���������� � � �������� ������ ������, ���� ����� ��������� ��.\r\n��������� ��������� ������� �������� �� �� ���������� ��������� �� ��������. ��� �� �� ����������� �� ��������� ������� �� ��������, ������ �� ����� � ������ ������� ��� ���������������.\r\n� �������� �� ���� ������� ������! � ����� � ��������. ������� ��, ������� �� ��������� ��������� �������, �� ����� ����� �� ���������. � ������ �� ������ ������� ������. �������� �� ���� �� ������ � ������� �� �����������, �� �� �� �� ������� � ������. ����� �� �� ��������� �� ���������� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode196Chois3()
		{
			int currEpizodeId = 196;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ��������, ������� �� � ����! � ����� ������ � �������� ������ �� ��� �������������.\r\n��� ����� �� ������������ �� ������ ����� ���������� � ���� � ����� ��� ���, ������ ���� �� ������� ������ �� �������. �� ��� ���������� ������ � ������� �� ����� � ����������� ������, ����� ����� ������, ��� �� �� �������. ����������� �� ��� ������� ���� ���� �� ��������������� �� ��� ����� ���������� ��������. ����������� �� ����� ���������� ����� ������� ������������� �������� ����� � ���� ������� ����������� �� �� ����� ������, ������� �� �� ������ �������.\r\n��� ��������������� �� ������� ����� �����. �� ������ �� ������ �� �������� ������� ��, � ��������� ����� �� ��������� �������� ���, ������ ������ �� ����� ��� ������ �������.\r\n� �� �� ������� � ����? � ��������� ���� ����. ��������� �� ����������� �������� �� ������� � �� ��������� �� ��������, �� ����� ������ ������, � ����� �� �� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode197Chois1()
		{
			int currEpizodeId = 197;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ������ ��������� �������� ������ �������� ������������ � �������� ������� �� ����� ������� � ���� ������� ������ ������, ����������:\r\n� ������� ������ ������ �� �����! � ������ �� ������� ���������. ���������� �� ���������� ������� �� ���������, ���� �� ��� ������ ������������ � ���� � ��������� �� ����������� ��.\r\n� ������ ��� ����������������! ��� ����� �� ��������, �� � ������! ����� ������� � ����������� ��� ������� ��� �� ��������! ��������! ��� �� ������ �������, �� � ������! ����� ������� � �����������! �������!!!\r\n�������� ���������� � ������� ������, �� ������ �� �� �������� �� ������� ��. ��������� ������������ �� ������� ������ �� � ������ �� �������:\r\n� ����� �������! ������� �� �������! �������! � ��������� ���� ������.\r\n���� ���� ������� ������� ���� �� �������� �������� � ������� ���������� ���������� �� ����������������� ��������.\r\n� ��� ��� ���? � ���� �������� ���. � ����� ������?\r\n� ���, ���� � ���� ������� � ���� �������� � ������� �� ������� ��. � ����� �� �����������, ��� �� ������. ��������� �������� ��. �����\r\n� ���� �� �����! � �������� �� �����, ���� ������� ��� ����� �� ���������� �������. � ����������� �� �� �����, �� ��� ���� ������� �� ��������, ��� �������� ��������. ��������� �� �� ��������� ���������. ����������� ��, �� �� �������� �� ��������. �������� ���� �� ������ ������������ �� ����������.\r\n����� ������ �� ������?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode198Chois1()
		{
			int currEpizodeId = 198;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ������� �������� �������� ���������� ���� �� ��������. ������� �� �������� ���������� ������ � ���� ����������� ��������� ���� �������:\r\n� ������� � ��������� ������� �� ����������� ������������� �������� ������� �� ������. ���������� �� �������� ���� �������� ������. ������� ������ �� �� ���������!\r\n� ��������� ��! �������! � ����� �������� � ������ � ������ �� ������ �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode198Chois2()
		{
			int currEpizodeId = 198;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �������� ��! � ������ ���������� ��������. � ������� �� �� ������� ����� ��������� �� ������ � ������� � ���� �������� ����� ���� ��������, ������������ ����� �������� �������� ��� ���������� ����.\r\n� ����! �� �������! � ������ �� ��������� �������� ���������. � ���� ��������� ��!\r\n� ��� �������! � ���� ������� ���������� �� ����������������� ������. � �� �� ������, ���� �� �������� �������!\r\n� ����, ���� ��? � ��������� �� �������. � ��� �� ����!\r\n������ �������� � � ���� ������� ������� ������ �� ���������� �� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode198Chois3()
		{
			int currEpizodeId = 198;
			string currentChois = 3.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "���� ������ ������ ��� ���������� �� ������� ������� ������������ �� ����� ������ ������. �� ���� �������� ����� �� �����, ��� ������� �� �� �����. ������ ����������� �� ����������, �������� �� ��������� �����, �� ���������� ��������� �� ������� �� ���������.\r\n�������� �� ��������� � ������� �������������� ����� �������� ����� � ������� � ������, ������ ����� ��������� �� ��������� ������� ������ ������ � ������ �� ������� ���������. ������� ��������� ����� �� ������ ������ � �� ������ � ���������� ����.\r\n�������� �� ��������� ���������� � ���� ������� ������ �����, ����� �������� �� �� �������� ��� �������������. ������ ������ ����� �� ������ ��� ������� �� �� ����� �� �������� ��� ������, �� �� ������� ��������.\r\n�������� �� �������� � ������ �� ���� � �� ������� �����.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode199Chois1()
		{
			int currEpizodeId = 199;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3] - 1;
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� ����! � ��������� �� � ��� �������� ����������� � ����� ����� �� ��������.\r\n���� ������ ����������� ������� �� ������ ������, ��������� � ����������� � ��� ���������. �� �� ������ ������� �������� ����, ����� ��� ����� ������� ����� � ������� ����� �� �����������. ������� �������� �� � ��������� �� ���� �������� �������� �������� �� ������ �������� ������ �������. ���� ����������� ��������� ���� � ���������� � �������� �������:\r\n� ������� � ��������� ������� �� �����������. ������������� �������� ������� �� ������. ���������� �� �������� ���� �������� ������. ������� ������ �� �� ���������!\r\n� ��������� ��! �������! � ����� �������� � ������ � ������ �� ������ �����.\r\n� �����, ���������� �� � ���������! � ��������, ������ �� �������� �����. � ���������� ����������! ����� ������ �� �� ������!\r\n�������� �� � ������ ���� ��� ������� � ��������, � ���";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode199Chois2()
		{
			int currEpizodeId = 199;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3] - 1;
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "� �� ���������! � ����� �� ���������� �������� ���������. � ������������ �� ��������! ������� ���� ���!\r\n���������� ����� ������������, �������� ������ � ��������� ��������� �� ���������������� � �� ������� ������� �� �������� � ���, ��� �� ������� ���� ���� �� ������ ��. ����� ���� ������� �� ������ ������, ����� � ����� �������� ����. ������� �� ����������� �� ��������� �� �� �������. ��������� �� ������� ����� � ��������, �� ����� ������ ����� �� ����� ���������.\r\n� �������, ��������� ����������! �� ���������� �������� �������! ������ � ���� �� ���� �������.\r\n����� �� ��������� ���� � ���� �� ������� �� �� ������������, �������� ������������� ���������� � �����. ���� ���������� ��������� �� ��������, �� � ���������� �� �� ������� ����� ������������ �� ��������.\r\n� ���������, ���������� ������ ����� ������� � ������� ����� ������! � ������ �� ���������� ���������. ������� ��� ���� ������� �� � �����, ������ ���������!\r\n� ����, ����� �����!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode200Chois1()
		{
			int currEpizodeId = 200;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			this.playerStatus.Checksums[1] = 10;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�� ����������� �������, ��� �� �� � ������� �������� ��������� � ��� �������� ����� �������. ������ � �������� � ������� ������� ����� � �������� �� ���������� ��������. ��� ������� ����������� �� ������, �� �������� �����, ������ ����� ������ ������ �� ������ ���������� �� �������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode201Chois1()
		{
			int currEpizodeId = 201;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������� �� �������� ������� �� �� ��� ������� ����� � ��� ������� � ���� �� ���������. ��������� ����� �� ���� �� ������ �� ��������� ������� ������ �� ��������� � �� �� ��������, ������ ������� �� ��������� ����� �������� ��������.\r\n������� �� ������� � ���� �� ������ � ��� �� ��������� ��. ������������ ������� � �� � ������������ ����������� �� ��� � ���� ������ �� ��������� �����.\r\nGS1 � ����� ������� �����:\r\nGS2 � ����� ������� �����:\r\nGPR � ����� �� ���������:\r\n������� ����, ����� ������ �� ��������, ���� ���� �� ����������� ������, � �� ��������� �������� �� �����. ����� GS1 �� �������, ����������, ���-������ � ����������������. ����� GS2 ����� �� ������� ��� ���������� ��� ��� �������������. ���� ���� ������ ��� ��� �� ��� �� �� �����������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode201Chois2()
		{
			int currEpizodeId = 201;
			string currentChois = 2.ToString();
			bool isTest = false;
			int testrandomChois = 3;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "������ ���� ��������� �� ������ ������ �� ������, �� ����� ������� ����� ������� � �� �������� ��� ������� �� ��� � ����������������. ����������� �� � �����, ������� �� ��������� ����� �� ������, ����� � ������ � ��������� ������������ �� ����� ����������� �������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode202Chois1()
		{
			int currEpizodeId = 202;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "��� ���� �� � ����������� ������ ����� ������� � ��������� ���� ��. ��������� �� ������������ �� �������, �� �� ������� �� ���� ��� � � ��������� �� ���� ������. �� ������� �� ���, ����� ��������ѓ �� ����� ���������� �� ���� ���� � � ���-�������� ��������.\r\n������������ �� � ���������� �������, ������ �� ��������� �� ��������� ����� �� �� �������� ����� ������ ����, ����� �� ������ � ��������� �� ������. ������ �������� � ������� �������������� ������������ �� �������� � ���������� �� �������� �� ��������.\r\n������ ������ ������ ����� �������� �� ����������, �� � ���� �� �������� � ���� �� ������������ �� ���������� �� �����, �� �������� �������. ������ � ���������� � �������� ����������� �� ������� ������. ���������� � ������� ������� � �� ������� �� ������� ��������� ����� �� � ����� � ������� ������, ���� ���������� ����������� �� �����.\r\n� ����� �� �� ������ �����! � ������ ������� �� ������������� �� ���������. �� ���� ������ ����� �� � ��������� �������� ��� �����������. ���� �� ������ ���� �� ������� ���������� ���� � �� �� ��������. �������� �� ��-������� ���� �� �������� ��, �������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode202Chois2()
		{
			int currEpizodeId = 202;
			string currentChois = 1.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "����� ����� �������, �������� ��� ���� �� ��������������� ������, �� � �������� ������, ����� ��������� ����� ������, ����� �� ������� � ���� ������� ��� �� ������������. ����������� �������� �� ������� �� �� �������� ���� � ����� �����.\r\n������������ ���� �� ����� � �� ������ ���������, �������� �� ����� ������������� �������, ����, ������������ � ����� ��������. ��� ��������� �� ���� � �������� ����� ����� �� �� ������� ���� ������� ������������ ��� ������� ��������� �����. ��� �� �� ��� ����, ��������� �� �������, ������ ������� ���� � ������������ �� �������� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode202ThrowExceptionChois2()
		{
			int currEpizodeId = 202;
			string currentChois = 2.ToString();
			bool isTest = true;
			int testrandomChois = 2;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			Assert.Throws<OutOfMemoryException>(() => game.GameAction());
		}

		[Test]
		public void TestEpizode203Chois1()
		{
			int currEpizodeId = 203;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[5] = 1;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = "�������� ���� �� ����� �������������� ������ �� ��������, ������� �� �������� �����, � ������������ ������ � ��� �� ���������� � ���� ���������� ����������� ��, �� ������ ������� ������. ����� ����� � �����! ����������� ������� ��� ��� ��������, ���������� ���� ���� ������� �� ����������, �� ������� � �������� � ������������, ������ ������� ������ �����.\r\n����� �� ������������ �������� �� �������� � ��� ������ �� ����� �� ������������ �����. ������������ � ��������, �� ������� �� ���, ����� �� � ���������� � ���������� �, ����������� ���������, �� � ��������� � ������ ��, �� ������ ��� ������� � ����� �� ������� ������� ������������.\r\n� ��������� ��, ��������! � ������ �� � ���� ���������� ������ ����������, �� ������ � ������� ������ �� ��� �����������. ��� ��������� �� � �������� � ���� ����� �������. ������ � �������� � ������� ������� ����� � �������� �� ���������� ��������. ��� ������� ����������� �� ������, �� �������� �����, ������ ����� ������ ������ �� ������ ���������� �� �������� �� ���������.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}

		[Test]
		public void TestEpizode203Chois2()
		{
			int currEpizodeId = 203;
			string currentChois = 1.ToString();
			bool isTest = false;
			int testrandomChois = 2;

			this.playerStatus.Checksums[5] = 0;

			PlayerStatus expectedPlayerStatus = new PlayerStatus();
			expectedPlayerStatus.Checksums[1] = this.playerStatus.Checksums[1];
			expectedPlayerStatus.Checksums[2] = this.playerStatus.Checksums[2];
			expectedPlayerStatus.Checksums[3] = this.playerStatus.Checksums[3];
			expectedPlayerStatus.Checksums[4] = this.playerStatus.Checksums[4];
			expectedPlayerStatus.Checksums[5] = this.playerStatus.Checksums[5];
			expectedPlayerStatus.Checksums[6] = this.playerStatus.Checksums[6];
			expectedPlayerStatus.Checksums[7] = this.playerStatus.Checksums[7];
			expectedPlayerStatus.Checksums[8] = this.playerStatus.Checksums[8];
			expectedPlayerStatus.Checksums[9] = this.playerStatus.Checksums[9];

			expectedPlayerStatus.Checksums[1] = 0;
			expectedPlayerStatus.Checksums[2] = 0;
			expectedPlayerStatus.Checksums[3] = 0;
			expectedPlayerStatus.Checksums[4] = 0;
			expectedPlayerStatus.Checksums[5] = 0;
			expectedPlayerStatus.Checksums[6] = 0;
			expectedPlayerStatus.Checksums[7] = 0;
			expectedPlayerStatus.Checksums[8] = 0;
			expectedPlayerStatus.Checksums[9] = 0;

			ITestData testData = new TestGameStarShips.TestData.TestData(currEpizodeId, this.playerStatus, isTest, testrandomChois);

			Game game = new Game(this.read, this.write, testData);
			this.read.Result = currentChois;
			game.GameAction();

			string expectedDescription = " ";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

			Assert.AreEqual(expectedDescription, factDescriptions);

			string expectedPoint = string.Join("-", expectedPlayerStatus.Checksums);

			string factPoint = string.Join("-", game.PlayerStatus.Checksums);

			Assert.AreEqual(expectedPoint, factPoint);

			int expectedResult = expectedPlayerStatus.TottalResult;

			int factResult = game.PlayerStatus.TottalResult;

			Assert.AreEqual(expectedResult, factResult);
		}
	}
}