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

			string expectedDescription = "Смяташ да не рискуваш с бързо измъкване, а да си запазиш енергията на бластера за решителния момент. Следователно трябва да се прикриеш, доколкото е възможно по-добре, за да принудиш робота да се приближи.\r\nКакво ще направиш?";

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

			string expectedDescription = "Хващаш бластера с две ръце и като се прицелваш внимателно, стреляш срещу робота-снайнерист.";

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

			string expectedDescription = "Прицелваш се внимателно и с точен изстрел разбиваш прицелния автомат. Веднага роботът се спира и започва сканиране на сектор встрани от теб. Известно време наблюдаваш безсмислените му действия и като излизаш на твърда земя, бавно приготвяш гранатата. В този момент роботът спира да се движи и чуваш гласа на инструктора:\r\n— Достатъчно, лейтенант. Справихте се чудесно! Викат Ви при командващия.";

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

			string expectedDescription = "С изключени двигатели и работещи на пълна мощност защитни системи совалката прави вече втора обиколка около Ситай. При отделянето ви от крайцера е допусната грешка и сега, вместо да застанете на геостационарна орбита над комплекса, обикаляте планетата по бързо стесняваща се спирала. Ако запалите двигателите и направите корекция, рискувате да бъдете открити от следящите системи на комплекса. Ако останете да чакате, след още една обиколка ще навлезете в атмосферата и тогава отново ще се наложи да маневрирате с включени двигатели.\r\nСлед кратко обсъждане с пилотите се очертават следните възможни варианти за действие:";

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

			string expectedDescription = "Формалностите около подготовката за операцията отнемат цялото ти време и едва на борда на космическия кръстосвач успяваш да прегледаш данните. На дискетата е записан само следният текст:\r\n„Ситай — единствена планета в звездната система. Размери: 8/9 от земните. Период на въртене: 22 часа. Липсва наклон на планетната ос. Няма естествени спътници.\r\nПостоянен горещ и влажен климат. Площ на единствения континент — до 2/5 от планетата. Характеризира се с почти непрестанни валежи и наличието на тропически джунгли. Намерена е изоставена ботаническа изследователска станция. Население: около 200 000, бивши колонисти с генетични промени, породени от особености на микрофауната.\r\nТова е единственото място, където може да се синтезира наркотикът «Ситайк-дрог».\r\nОфициално планетата е извън юрисдикцията на ФЕДЕРАЦИЯТА. Формално е независима планета. Понастоящем е във владение на наркокартел.“\r\nПоради възможността за възникване на усложнения в междупланетните отношения провеждането на явна военна операция е невъзможно.\r\nЗАДАЧА: Да се направи десант от група с минимален състав и да се унищожат инсталациите за синтез. По възможност да се задържат водачите и да се запази научната документация. Местното население е неприкосновено. Разрешени са само стандартни оръжия.\r\nПРИЛОЖЕНИЕ: Карта на Ситай, съставена от автоматична сонда. Известни са координатите на производствения комплекс и приблизителното местоположение на две селища на местни жители.\r\nСнимка и фотокарта на комплекса.\r\nСЪСТАВ НА ДЕСАНТНАТА ГРУПА: Командир на десанта: лейтенант от „СТАР РЕЙНДЖЪРС“ — това си ти, читателю. Бойна група:        един сержант и девет рейнджъри.\r\nТехническа група: двама пилоти; един специалист по кибернетика и информатика; един специалист по електронно разузнаване и комуникации.\r\nТЕХНИЧЕСКА ЕКИПИРОВКА:";

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

			string expectedDescription = "— Включете всички активни устройства! — командваш решително. — Готови за директна атака!\r\nСамо за няколко секунди имате пълна информация за целия комплекс. В паметта на компютрите постъпват данни за разположението, размера и предназначението на постройките, броя на хората в района, разположението и типа на защитните системи.\r\n— ШЕСТДЕСЕТ СЕКУНДИ ПРЕДСТАРТОВА ГОТОВНОСТ — обявява компютърът. — ДВИГАТЕЛИТЕ ГОТОВИ ЗА СТАРТ. ЗАПОЧВАМ НАСОЧВАНЕ.\r\n— Спускаме се в района на космодрума им. Максимална скорост!\r\n— ПЕТДЕСЕТ СЕКУНДИ ПРЕДСТАРТОВА ГОТОВНОСТ. РАЙОНЪТ Е ЛОКАЛИЗИРАН.\r\n— Откриваме цел! Скоростна, с малки размери. Вероятно ракета. Удар след тридесет секунди!\r\n— Защитните екрани ще издържат ли?\r\n— Няма данни за типа на ракетата. Предлагам унищожаване.\r\n— ЧЕТИРИДЕСЕТ СЕКУНДИ ПРЕДСТАРТОВА ГОТОВНОСТ. НАСОЧВАНЕТО ИЗВЪРШЕНО.\r\n— Приготви бойните лазери! Максимален обхват! Огън!\r\nОслепителен блясък залива за няколко мига кораба ви. Зарядът на ракетата вероятно е бил ядрен, но защитният екран устоява.\r\n— Целта е поразена, командире! — докладва сред одобрителни възгласи кибернетикът, заел мястото на бордовия стрелец.\r\n— КРАЙ НА ПРЕДСТАРТОВАТА ГОТОВНОСТ — съобщава компютърът. — ЗАПОЧВАМ СПУСКАНЕ. СТАРТ!";

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

			string expectedDescription = "Вземаш решението моментално. Единственият приемлив вариант е да се спуснете дълбоко в джунглата и там да съставиш нов план на действие.\r\n— Насочи се към джунглата. Ъглово отклонение тридесет градуса — и като забелязваш учудения поглед на пилота, подхвърляш: — Гледай да не ни забиеш в някое блато!\r\n— ТРИДЕСЕТ СЕКУНДИ ДО СТАРТОВАТА ГОТОВНОСТ. СЕКТОРЪТ Е ЛОКАЛИЗИРАН. НАВЛИЗАМЕ В ПОЗИЦИЯ ЗА СПУСКАНЕ. ВКЛЮЧВАМ СТАРТОВА МОЩНОСТ.\r\nОтпускаш се отново и затваряш очи. Вече е късно за връщане. Дано само не ви забележат при спускането.\r\n— КРАЙ НА ПРЕДСТАРТОВАТА ГОТОВНОСТ — отбелязва компютърът. — ЗАПОЧВАМ СПУСКАНЕ. СТАРТ!\r\nСилен тласък те притиска към креслото и от ускорението пред очите ти се спуска черна пелена. Като през памук чуваш съобщенията на автомата за параметрите на полета. Всичко продължава само няколко мига, все пак совалката е с малка маса и бързо достига необходимата скорост.";

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

			string expectedDescription = "— Изключи двигателите! — решаваш веднага ти. — Започваме безмоторно спускане в района на комплекса.\r\n— ДВИГАТЕЛИТЕ НА НУЛА — откликва веднага компютърът. — ПРЕДСТАРТОВАТА ГОТОВНОСТ Е ОТМЕНЕНА. ДАЙТЕ КООРДИНАТИ ЗА НАСОЧВАНЕ!\r\n— Насочи совалката някъде в северозападния край! — посочваш на първия пилот място, което изглежда по-високо и вероятно е по-сухо.\r\n— Няма ли да ни усетят, когато прелетим над тях? — пита със съмнение в гласа кибернетикът.\r\n— В тези облаци? — отговаряш му. — Съмнявам се, а и ние ще подходим отстрани.\r\n— КООРДИНАТИТЕ ЗА СПУСКАНЕ УТОЧНЕНИ — съобщава компютърът. — ЗАПОЧВАМ НАСОЧВАНЕ. ТРИДЕСЕТ СЕКУНДИ ДО СТАРТА.\r\nОтново се облягаш назад в мекото кресло и затваряш очи. Дано не си взел погрешно решение!\r\n— КРАЙ НА НАСОЧВАНЕТО. ЗАПОЧВАМ БЕЗМОТОРНО СПУСКАНЕ.\r\nС леко свистене от носовите дюзи излитат силни струи прегрята пара. Скоростта на кораба намалява, докато гравитацията надделява над инерцията и започвате свободно спускане. С гръмък рев совалката се забива в атмосферата, серия тежки удари и вибрации преминава по корпуса и скоростта започва стремително да намалява. След няколко секунди полетът се стабилизира и безстрастният глас на автомата обявява:\r\n— УСПЕШНО НАВЛИЗАНЕ В АТМОСФЕРАТА. ВСИЧКИ СИСТЕМИ РАБОТЯТ ИЗПРАВНО. ИЗХВЪРЛЯМ ТОПЛИННИТЕ ЩИТОВЕ. ПРЕМИНАВАМ В РЕЖИМ НА БЕЗМОТОРЕН ПОЛЕТ. НЯМА ОТКЛОНЕНИЯ ОТ КУРСА.\r\n— Всички защитни и маскировъчни системи на пълна мощност! — докладва единият от пилотите.\r\n— Останете по местата си! — казваш бързо, усетил раздвижване зад гърба си. — И по-тихо! — Възможно е да има акустични детектори.\r\nТиха и невидима като призрак, совалката се плъзва почти над западната ограда на комплекса и леко ляга в меката пръст на малко възвишение, само на три километра от него.\r\nСлед около тридесет минути сте на повърхността. Совалката е стъпила стабилно на малко островче от сравнително твърда земя. Отличното спускане е подобрило настроението на цялата група и сега всички са се събрали пред екраните, показващи чуждия свят. Пейзажът навън изглежда като кошмар, създаден от болен мозък. Криви дървета и зловещи, виещи се растения са преплетени в почти непроходим гъсталак. Всичко е обвито в тежки изпарения и разкъсани парцали гъста мъгла. Под дърветата цари сив сумрак, през който се движат неясни сенки. Растенията имат странен посърнал цвят, преливащ от белезникаво зелено до мръсно сиво.\r\nИ така, първата част на задачата е изпълнена успешно. Приземил си се незабелязан и имаш цели 15 дни за провеждане на операцията.";

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

			string expectedDescription = "— ТРИДЕСЕТ СЕКУНДИ ДО СТАРТОВАТА ГОТОВНОСТ. НАСОЧВАНЕТО ИЗВЪРШЕНО. НАВЛИЗАМЕ В ПОЗИЦИЯ ЗА СПУСКАНЕ. ВКЛЮЧВАМ СТАРТОВА МОЩНОСТ — обявява компютърът.\r\n— Лейтенант, ние сме на друга орбита! Той ще ни забие право в океана! — почти крещи първият пилот.\r\n— Стоп на стартовата готовност! Прекрати процедурата! — викаш силно и удряш клавиша за авариен стоп. — Премини на ръчно управление! Отменям спускането!\r\n— ПРЕДСТАРТОВОТО БРОЕНЕ ОТМЕНЕНО — безстрастно откликва компютърът. — ИЗКЛЮЧВАМ ДВИГАТЕЛИТЕ.\r\n— Остави двигателите в стартов режим! Ще преминем на планираната орбита — и доловил движение зад гърба си, викаш: — Десантната група да остане в стартовите кресла!\r\n— Подготви параметрите за преминаване на нова орбита — нареждаш на пилотите и без да погледнеш никого, ставаш и отиваш в хангара. Сега се нуждаеш единствено от малко усамотение, за да преодолееш яда си от провала.\r\n— Лейтенантът ни е новобранец — шепнат в сектора на бойната група.\r\n— Ако и долу така се обърка, ще загазим.\r\n— Тишина там! — вика сержантът, като те вижда да се връщаш.\r\nКакво можеш да направиш? Сам си виновен за всичко. Като се правиш, че не си чул нищо, сядаш отново на мястото си и даваш заповед за преминаване на нова орбита.";

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

			string expectedDescription = "— Стреляй в лявата платформа! — казваш решително, като се надяваш да не си сгрешил.\r\nЕдновременно с думите ти от дулото на бластера със заглушаващ всичко вой излита дълъг, ослепително блестящ лъч и като се забива в турбоплатформата, я превръща в огнен облак, пръскащ навсякъде димящи отломки. Взривната вълна достига и до останалите машини и скоро огромният „ловец“ се превръща в купчина горящи парчета, разпръснати из цялото село.";

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

			string expectedDescription = "— Стреляй в дясната платформа — казваш решително, като се надяваш да не си сгрешил.\r\nЕдновременно с думите ти от дулото на бластера със заглушаващ всичко вой излита дълъг, ослепително блестящ лъч и като се забива в турбоплатформата, я превръща в огнен облак, пръскащ навсякъде димящи отломки. Взривната вълна достига и до останалите машини и скоро огромният „ловец“ се превръща в купчина горящи парчета, разпръснати из цялото село.";

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

			string expectedDescription = "Невидимият и безшумен лъч се оказва прецизно насочен и като прониква през защитния силов екран и дебелата броня, попада право в енергогенераторите на робота, от което той със страшен взрив се пръска. Веднага, без да чакат твоята команда, рейнджърите атакуват, придружени и дори изпреварени от радостно кряскащите ловци.\r\nЗашеметени и объркани, войниците от охраната отговарят вяло и един след друг хукват назад. Победата изглежда пълна и вече се готвиш да дадеш заповед за настъпление към лабораториите, когато от ниските облаци налита щурмови изтребител и като се обръща през крило, заема позиция откъм гърба ви и пикира стръмно, без обаче да стреля.\r\nДействията на пилота са доста странни, но ти нямаш време да се занимаваш с тях, а трябва да помислиш как да го свалиш.";

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

			string expectedDescription = "След малко от ниските облаци изплува огромна и тромава летяща машина. Съставена е от четири, закачени заедно, големи турбоплатформи и носеща в средата обширна клетка. Веднага щом стига над селото, от нея се посипват няколко десетки тежковъоръжени войници.\r\nОчаквали отчаяна, но слаба съпротива от жителите на селото, нападателите са силно изненадани от атакувалите ги рейнджъри. Само за десетина секунди войниците на картела са притиснати и унищожени, въпреки численото си превъзходство.\r\nСега е твой ред и ти трябва да избереш с какво ще се опиташ да свалиш „ловеца“. И трите вида тежко оръжие са подходящи, но всеки има специфични възможности.";

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "След още няколко минути на колебание дежурният наблюдател решава, че няма причина за тревога и като отваря бутилка бира, се приготвя за скуката на дежурството.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "След още няколко минути на колебание дежурният наблюдател се решава и включва цялата мощност на активната система на следене. Вашите защитни екрани работят с пълно натоварване, но сканиращият лъч ви достига и макар и замъглен и изкривен, образът на совалката се появява на екраните. По-нататък всичко се развива с главоломна скорост. Защитната система се включва автоматично и като обявява тревога, задейства програмата за отразяване на нападение.\r\n— Регистрирам следящ лъч! — докладва бързо един от пилотите. — Проникна през екраните. Край, засечени сме!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "След още няколко минути на колебание дежурният наблюдател се решава и включва за кратко време активната система на следене. Вашите защитни екрани работят с пълна мощност и резултатът е, че компютърът иска допълнителна енергия и време за следене. Това вече е достатъчно подозрително и тревогата е подадена.\r\nА в това време при вас…\r\n— Командире, засичам следящ лъч с малка мощност — обажда се единият от пилотите. — Отклони се, без да проникне през екрана.\r\n— Насочете дефлектора! — отговаряш му. — Да включим ли активните системи за наблюдение? — промърморваш си сам.\r\nНа повърхността началникът на охраната разглежда известно време записите и нарежда да се направи насочено сондиране на сектора с цялата мощност на локаторите.\r\n— Ако включим активна система, веднага ще ни засекат — разбрал колебанието ти, казва кибернетикът. — От друга страна, ако използват достатъчно мощност, могат да ни открият въпреки дефлектора.\r\nОтново се налага да вземеш решение. Възможностите са следните:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Първото нещо, изпречило се на пътя ви, е брониран патрулен робот, който съгласно заложената в него програма нарежда да се предадете. Преди още да довърши, една плазмена граната го превръща в пушеща купчина метал, но пък се задейства алармената система на комплекса. Оглушителен вой прониква навсякъде и един гръмък метален глас процепва въздуха:\r\n— НАПАДЕНИЕ СРЕЩУ СЕКТОРА НА ЕНЕРГОБЛОКА! ПРОБИТА Е ЗАЩИТНАТА СИСТЕМА! ВСИЧКИ БОЙНИ ГРУПИ И ПАТРУЛНИТЕ КОЛИ ДА СЕ НАСОЧАТ КЪМ РАЙОНА НА ПРОБИВА! ОБКРЪЖЕТЕ И ИЗОЛИРАЙТЕ СЕКТОРА! ВСИЧКИ ОБЕКТИ ОТ КЛАС „А“, „В“ И „С“ ДА БЪДАТ БЛОКИРАНИ!\r\n— Аха, попаднали сме точно на място! — отбелязваш доволен. Въпреки бързата реакция на системата за отбрана, охраната е напълно изненадана и неподготвена, което ти дава възможност да определиш обекта за атака. Но преди това…";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ДЕСАНТНА СОВАЛКА — техническа характеристика:\r\nДесантната совалка е лек кораб, предназначен за спускане на малки десантни групи на планети от земен тип. От обикновените транспортни кораби я отличава възможността да се спуска безмоторно и да излети в околопланетна орбита без ракета-носител.\r\nЗащитена е от двуслоен силов екран за цялостна защита, дефлектор за пълно прикритие и допълнителен дефлектор за секторна защита. Корпусът е оцветен с активно променяща се боя, която се слива с околната среда и прави кораба труднозабележим, дори от близко разстояние.\r\nВъоръжението е слабо, само със защитни функции. Включва комплект управляеми ракети и периферни лазерни бластери със средна мощност.\r\nСнабдена е със система за електронно и радарно разузнаване. Има товароносимост до 10 тона.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ТРАНСПОРТЬОР — техническа характеристика:\r\nЛеко бронираният транспортьор, предоставен ти за акцията, по-скоро може да бъде класифициран като лек щурмови танк. Предназначението му е да превозва и прикрива при атака бойна група до 12 човека.\r\nПроходимостта на машината е почти универсална. Шасито е окачено на шест специални, независими колела с широки „сферични“ гуми, които му позволяват да се движи еднакво добре както по мек пясък или кал, така и по силно пресечена местност.\r\nЗащитата е осигурена от 10 мм броня от кристално преструктуриран метал, енергиен щит с пълно прикритие, локални полета за колелата и секторен дефлектор с голяма мощност. Обща защитна възможност: 100.\r\nВъоръжен е с комбинирана система, включваща: плазмен бластер, термичен импулсен лазерен бластер и многоцевна големокалибрена картечница. Допълнително е снабден с комплект управляеми ракети, димни и газови бомби, както и с пълна система за електронно разузнаване.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ТУРБОПЛАТФОРМА — техническа характеристика:\r\nТурбоплатформата е машина, която се явява далечен наследник на хеликоптерите. За разлика от тях, във въздуха я поддържа не витло, а поле на енергиен генератор, подобен на защитните силови екрани. Основен проблем е бързото намаляване на полезната товароносимост при увеличаване на мощността и сравнително малката скорост на хоризонталния полет.\r\nНезависимо от всичко, турбоплатформите са широко използвано средство както за транспортни, така и за бойни цели. Много често на тяхна база се създават ефектни разузнавателни и патрулни машини.\r\nПредоставената ти за операцията платформа е чисто транспортно средство с форма на елиптично изтеглен тороид, оградена с нисък парапет и товароносимост до 500 килограма.\r\nНяма собствено въоръжение и защита.\r\nВисочина на полета: до 100 метра, с максимална скорост 65 км/час.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ОРЪЖЕЙНИ СИСТЕМИ:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "СПЕЦИАЛНО ТЕХНИЧЕСКО ОБОРУДВАНЕ.\r\nОПИСАНИЕ — Специалното техническо оборудване е предназначено за разузнаване и прикритие на бойната група и може да ти бъде много полезно както за събиране на предварителна информация, така и по време на самата акция.\r\nСпециалното техническо оборудване включва: система за електронно разузнаване, стратегически микрокомпютърен анализатор, генератор на поле за групово визуално и лъчево прикритие, детектори за активни електрони устройства, както и пълен комплект батерии за захранването им. Общото тегло на системата е 145 килограма.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ОРЪЖИЯ — ХАРАКТЕРИСТИКИ:\r\nПЛАЗМЕН ТУРБОБЛАСТЕР — Оръжие, създадено на базата на ефекта „стабилизиране на завихрена нискотемпературна плазма“. Има огромна поразяваща мощ, но е с висока енергоемкост и голямо тегло. Оръжие за близък бой.\r\nИМПУЛСЕН ЛАЗЕР — Далекобойно, изключително точно и прецизно оръжие. Поразяващите му възможности зависят от типа на лазера и мощността на захранване. Като всички лъчеви оръжия то е много енергоемко. Силно разсейване в гъсти и запрашени или влажни атмосферни среди.\r\nПУЛСАТОР ЗА ЕЛЕМЕНТАРНИ ЧАСТИЦИ — Създава широк лъч от ускорени елементарни частици. Използва се само като стационарна система за охрана. Силно разсейване и опасност от вторично излъчване.\r\nЕЛЕКТРОНЕН БЛАСТЕР — Създава собствен йонизиран канал и поразява с високоволтов разряд. Икономично, удобно, но сравнително слабо и с малка далекобойност оръжие. Позволява фино, многостепенно регулиране на мощността.\r\nОГНЕСТРЕЛНИ ОРЪЖИЯ — Усъвършенствани технологии и голямо разнообразие на боеприпасите, универсално приложение и безотказност, с голяма поразяваща и възпираща мощ. Качества, които ги изравняват с енергетичните системи. Често те са единственото приложимо средство.\r\nРАКЕТИ — Управляеми или самонасочващи се, понякога почти интелигентни, с безкрайно разнообразни заряди, размери и приложение. Те присъстват във всички битки — от завладяването на галактиката до днес.\r\nЯДРЕН МОНИТОР — Оръжие с огромна поразяваща сила. Създадено преди векове, още от имперските оръжейни специалисти, то и досега е едно от най-мощните бойни средства. Действието му се основава на изстрелването на продуктите от частичен ядрен разпад и субядрена реакция в целта. Силно радиоактивно замърсяване. Приложимо е само за далечно поразяване.\r\n \r\nОСНОВНИ ПОКАЗАТЕЛИ НА ОРЪЖИЯТА:\r\nЕФЕКТИВНА ДАЛЕКОБОЙНОСТ — Това е максималното разстояние, на което оръжието запазва 95% от поразяващата си сила.\r\nПОРАЗЯВАЩА СИЛА — Обобщена сравнителна стойност за силата на изстрела. Приравнява се условно към милиметрите дебелина на метален лист, който може да бъде пробит от разстояние, равно на ефективната далекобойност.\r\nВЪЗПИРАЩА МОЩНОСТ — Характеристика на оръжието, показваща възможността му да обезвреди противника с минимален брой изстрели. Това е важен показател и ще бъде уточнен с един пример:\r\nСрещу теб е противник, който насочва оръжие. Лазерен бластер ще го спре, само ако го порази смъртоносно, докато изстрел от огнестрелно оръжие и особено от плазмен бластер ще го повали и обезвреди, дори да не е ранен смъртоносно.\r\nТЕГЛО С БОЕКОМПЛЕКТА — Тегло на оръжието в килограми, заедно с резервните му пълнители или батерии. Приема се един войник да носи до 45 кг при поход и 15 кг по време на сражение.\r\n \r\nСРЕДСТВА ЗА ЗАЩИТА:\r\nЛЪЧЕВ ДЕФЛЕКТОР — Система за отклоняване и разсейване на лъчите на енергетичните оръжия. Ефектът му зависи от мощността на енергийния източник. Не въздейства на материални предмети.\r\nСИЛОВ ЕКРАН — Система за отклоняване и отблъскване на материални обекти. Ефективността му зависи от мощността на захранване и скоростта на проникване на обекта. Може да бъде преодоляна лесно от лазер или с малка скорост. Голямото тегло на генератора не позволява да се използва за индивидуална защита.\r\nЗАЩИТНА ЖИЛЕТКА — Направена е от кристално преструктуриран метал. Може да служи като универсално предпазно средство. За съжаление е тежка и неудобна. Може да прикрива изцяло само гърдите и гърба.\r\n \r\nОСНОВНИ ПОКАЗАТЕЛИ:\r\nЗАЩИТНА ВЪЗМОЖНОСТ — Способността да задържи изстрел с определена поразяваща сила.\r\nТЕГЛО НА СИСТЕМАТА — Тегло в килограми на защитното средство и енергийния му източник, ако го има.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— КОМАНДИРЪТ НА ДЕСАНТНАТА ГРУПА ДА СЕ ЯВИ В ЩАБА НА КРАЙЦЕРА — разнася се от комуникатора. — ПОВТАРЯМ: КОМАНДИРЪТ НА ДЕСАНТНАТА ГРУПА ДА СЕ ЯВИ В ЩАБА НА КРАЙЦЕРА.\r\n— Събери хората — едва успяваш да кажеш на сержанта, като прибираш бързо разпилените документи и карти.\r\n— КОМАНДИРЪТ НА ДЕСАНТНАТА ГРУПА ДА СЕ ЯВИ В ЩАБА НА КРАЙЦЕРА — започва отново комуникаторът. — ПОВТАРЯМ: КОМАНДИРЪТ НА ДЕСАНТНАТА ГРУПА ДА СЕ ЯВИ В ЩАБА НА КРАЙЦЕРА! ВЕДНАГА!\r\nЗа твоя изненада в командната зала на щаба е само командирът на крайцера и един от навигаторите.\r\n— Време е да потегляте, лейтенант — казва веднага щом влезеш командирът. — Ето ви и последните инструкции. След 45 минути достигаме до системата Ситай. Крайцерът ще остане извън нея и ще ви изведе на изходна, геостационарна орбита около планетата, в района на комплекса. Имате 15 дни за провеждане на операцията. Тогава трябва да сте на координати, които ще получите по-късно. Ако не се явите до определеното време, ще изпратя спасителна капсула на Ситай. Не ви се разрешават никакви връзки с крайцера. Разбирате ли? При никакви обстоятелства няма да се обадим!\r\nКато се усмихва, изведнъж командирът изоставя служебния тон и меко казва:\r\n— Пожелавам ти успех, лейтенант! Всичко ще бъде наред! Екипът ти е отличен. И не пренебрегвай мнението на сержанта! Той е стар боец и има много богат опит. Вслушвай се и в съветите на кибернетика; той е с по-голям чин, но командир на операцията си ти.\r\n— Ето ви дискетата с данните за полета — приближава се и навигаторът. — Там са всички необходими координати и команди. Ако не възникне нещо непредвидено, компютрите на совалката ще ви спуснат и върнат без проблеми.\r\n— Действайте, лейтенант! — става сериозен отново капитанът. — Имате 30 минути за подготовка.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Там вече се е разположила голяма група войници и прегражда пътя ви. Озадачени от неочакваното ви бягство, те се забавят за един миг и в следващия са вече мъртви. За разлика от тях, „СТАР РЕЙНДЖЪРС“ не губят присъствие на духа дори и в най-критични ситуации.\r\nОтдалечавате се с максимална бързина, когато на километър от комплекса върху ви се стоварва тежък тътнещ удар, който ви поваля и разпилява по земята. Ужасна горещина с няколко последователни разтърсвания те връхлита и измъченото ти съзнание се изключва.\r\nКогато светът отново става достъпен за възприятие, ти с мъка се изправяш и като се освобождаваш от посипалата те пръст, се оглеждаш наоколо. Гората е опустошена и буквално преобърната от ядрения ураган. Комплексът е направо пометен и от мястото му огромен гъбовиден облак се е забил в ниските облаци, като продължава стремително да расте.\r\n— Хайде да се махаме оттук! — казваш уморено на наобиколилите те рейнджъри. За твоя радост никой не е пострадал сериозно при експлозията. Сега ти остава само да изчакаш контролния срок и да се прибираш. Изпълнил си по-важната част от задачата си, унищожил си комплекса.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Точно срещу пробива, прикрита зад една от полуразрушените сгради, се е спотаила голяма, силно бронирана бойна машина, която ви засипва с огън веднага щом се приближавате. Тренираните рефлекси ви помагат да се отървете само с двама убити.\r\nПреградилият пътя ви робот е от военен суперклас, способен да взима самостоятелни решения, бърз, интелигентен и силно въоръжен. Със защитното му поле и дебелата броня могат да се справят само тежкият турбобластер или мощният рентгенов лазер. Ако са ти под ръка, използвай ги веднага, защото времето тече и взривяването на реактора наближава.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Вече си сигурен, че за да приключиш най-бързо с неприятностите, трябва да ги удариш пръв. Още на другия ден намирате селото и внимателно се приближавате. Колибите им се оказват малки полуземлянки, удивително напомнящи купчини пръст и освен съвършената си маскировка, не притежават нищо интересно. Интересното и дори смайващо нещо е един почти потънал в земята и обрасъл с лиани, но напълно здрав имперски транспортен кораб от лек клас.\r\nРазполагаш останалите ти след сблъсъка рейнджъри и като правиш кратко разузнаване, даваш сигнал за атака. За съжаление, идеята да се нападне селото е хрумнала не само на теб. В момента, когато със стрелба навлизате между оказалите се празни колиби, в небето се появява огромна машина, съставена от четири големи турбоплатформи, носещи по средата обширна клетка. Когато се озовава над селото, от нея се посипват десетки тежковъоръжени войници.\r\nОбичайният начин на картела да се снабдява с роби и обичайният начин на племената да се защитават, като се крият дълбоко в джунглата. Между нападащите войници и рейнджърите се развихря кратка кървава битка, в която изненаданите и не толкова опитни бойци на наркокартела скоро са избити, а голямата им тромава машина — свалена. Все пак в сражението загиват много от хората ти и последвалата атака на изчакалото в засада племе ви унищожава напълно.\r\nТака едно прибързано действие те проваля напълно и много години ще пречи на опитите на ФЕДЕРАЦИЯТА да приобщи местното население към нея.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "За да избегнеш повече сблъсъци с местните племена, решаваш да направиш широка дъга около предполагаемите райони на ловците. Така и не успяваш да решиш възникналото недоразумение. Туземците са ви взели за група, ловяща роби.\r\nДокато се опитвате да заобиколите, попадате на следващата, вече по-добре подготвена засада, която след ново кърваво сражение успява да се справи с групата ти. И „СТАР РЕЙНДЖЪРС“ могат да бъдат победени, особено ако ги води неопитен и прибързан в решенията си командир.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "По усилващите се крясъци и непрестанни взривове личи, че нападението на бараките засега има успех. Моментът за вашата акция е изключително подходящ и като подаваш тежката мина на рейнджъра, казваш:\r\n— Ето вземи, взривателят е нагласен за пет секунди! — и като го придръпваш към теб, добавяш: — Опитай да отскочиш преди взрива. Шансът е малък, но опитай!\r\n— Нека иде с него — настоява пак ловецът. — Аз примами машина, той сложи бомба!\r\nЕто и нова възможност. Ще се съгласиш ли с ловеца?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Сигурен ли си, че ще се получи нещо? — питаш със съмнение дребния ловец.\r\n— Не разбира! Какво получи? — пита той.\r\nЗвуците на битката се усилват и приближават, явно атаката засега се развива добре и моментът да действате е изключително подходящ.\r\n— Ще можеш ли наистина да го примамиш? — питаш нетърпеливо.\r\n— Може примами — отговаря той и започва да се измъква от тунела. — Вече правил това примами.\r\nСлед секунда дребната фигурка застава пред тежко бронираната машина и като размахва ръце, казва нещо. Реакцията на робота е моментална, насочва всичките си сензори и цялата си мощна батарея към ловеца и гласът му прогърмява:\r\n— ДОСТЪПЪТ ДО РАЙОНА НА ЦЕНТРАЛАТА Е ЗАБРАНЕН! ХВЪРЛЕТЕ ОРЪЖИЕТО И ИЗЧАКАЙТЕ ПАТРУЛА! ИМАТЕ ДЕСЕТ СЕКУНДИ ДА СЕ ПРЕДАДЕТЕ!\r\n— Какво прави този? — учудено пита легналият до теб кибернетик.\r\nСлед като изчаква автомата да повтори заповедта, ловецът хвърля арбалета и вдига ръце.\r\n— ОТДАЛЕЧЕТЕ СЕ ОТ РАЙОНА НА ЕНЕРГОСТАНЦИЯТА! — прогърмява отново автоматът. — ИЗЧАКАЙТЕ ПАТРУЛА ДА ВИ ПРИБЕРЕ!\r\nКато прави няколко бавни крачки назад, малкият ловец изведнъж скача настрани и хуква към редицата постройки навътре в комплекса.\r\n— СПРЕТЕ ВЕДНАГА! ИЗЧАКАЙТЕ ПАТРУЛА! — реве автоматът, но вместо да стреля, се понася след бързо отдалечаващия се беглец.\r\n— Я го виж ти него! — с уважение произнася рейнджърът и също се измъква от тунела.\r\nНаоколо няма никой и вие безпрепятствено достигате до масивната постройка на енергостанцията. Входът е затворен с тежка метална врата, която обаче се разпада от мината ви. Техническият персонал на енергоблока е така изненадан, че оказва само символична съпротива. Докато кибернетикът е зает да поврежда системата за дозиране и контрол, ти сядаш пред мониторите за външен контрол. Районът на робските бараки е покрит от гъст дим, прорязван от светкавиците на лазерните и плазмени бластери. На места като призрачни сенки се мяркат тук притичващи ловци, там стрелящи напосоки войници; за миг се появява горяща патрулна кола. От микрофоните се носи непрестанен грохот, свистене и викове.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— МАНЕВРАТА ИЗПЪЛНЕНА БЕЗУСПЕШНО — обажда се отново след секунда автоматът. — УДАР СЛЕД ТРИ СЕКУНДИ. СТАРТ НА АВАРИЙНИТЕ КАТАПУЛТИ. ВРЕМЕ ЗА ПЪЛНА ЕВАКУАЦИЯ ПЕТ СЕКУНДИ.\r\nСилен тласък, придружен със звънко гърмене, те притиска към креслото. Панелът над теб е отхвърлен и катапултът се задейства. Около теб се понасят креслата на останалите от групата, когато като насън виждаш тънко черно тяло да се забива право в останките на разрушената вече совалка.\r\n— РАКЕТА В ЦЕЛТА — чуваш в шлема гласът на бордовия компютър. — ЗАЩИТАТА Е ПРЕОДОЛЯНА…\r\nОт израненото тяло на совалката бликва мощна огнена вълна, която ви застига и разпилява като семена при бурен вятър. Ужасна горещина и жестоко разтърсване те потапят в непрогледен мрак и измъченото ти съзнание просто се изключва.\r\nСъвземаш се мъчително и дълго не можеш да си спомниш къде си и какво се е случило. Изправяш се бавно и като се мръщиш от болки по цялото тяло, тръгваш да търсиш оцелелите от хората ти.\r\nДо вечерта всички са открити, оцелели са само трима рейнджъри и кибернетикът. Сержантът и единият от пилотите са тежко пострадали и практически неподвижни. Всички останали са мъртви; обгорените им, силно изранени тела са подредени в една естествена яма и затрупани с камъни и глина. Останките на совалката са разпръснати на голяма площ, а джунглата около вас изглежда като след опустошителен огнен ураган.\r\nПод топлите струи на проливния дъжд провеждате кратко, но напрегнато съвещание. Всички сте изнервени от провала и не можете да се споразумеете как да продължите.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Насочи ракетите към изтребителя. Огън!\r\nЛеко трептене показва старта на ракетите ви. Ярките точки на двигателите им бързо се отдалечават и мощни избухвания прорязват екраните.\r\n— Ракетите в целта — докладва кибернетикът. — Пет секунди до попадение на торпедата.\r\n— Изстреляна е ракета. Вероятно с конвенционален заряд. Попадение след десет секунди.\r\nЗа защита ти остават лазерните бластери и енергийните щитове и ти трябва да решиш как да ги използваш. Можеш да унищожиш една от целите с бластерите, но за другата ще трябва да разчиташ на силовите екрани.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Ракетите, да се взриви установката! Веднага! — даваш командата решително. Можеш само да се надяваш, че не грешиш, като оставяш изтребителя да излети.\r\nЛеко трептене показва старта на ракетите ви. Ярките точки на двигателите им бързо се отдалечават и мощни избухвания прорязват екраните.\r\n— Ракетите в целта — докладва кибернетикът. — Установката е разрушена.\r\nКогато екраните ви се проясняват, виждаш, че долу е истински хаос. Явно взривената ракета е била с много мощен заряд. Почти една трета от комплекса е забулена в гъсти кълба дим, прорязвани от ярките мълнии на експлозиите. Непрекъснат кънтящ гръм нахлува дори през стените на совалката. Корабът се разтърсва като жив, но уверено се спуска към самия център на развихрилия се ад.\r\n— ГРУПА ВЪЗДУШНИ ТОРПЕДА ОТЛЯВО — безстрастният глас на компютъра те връща към действителността. — УДАР СЛЕД ПЕТ СЕКУНДИ.\r\n— Взел съм ги на прицел — веднага се обажда кибернетикът. — Мога да ги унищожа!\r\n— Къде е изтребителят? — питаш рязко.\r\n— Загубихме го при експлозията. Сигурно е някъде над нас. Три секунди, командире!\r\nКакво смяташ да правиш?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Насочи ракетите към торпедата. Огън!\r\nЛеко трептене показва старта на ракетите ви. Ярките точки на двигателите им бързо се отдалечават и мощни избухвания прорязват екраните.\r\n— Ракетите в целта — докладва кибернетикът. — Изтребителят е над нас и заема позиция за атака.\r\n— ИЗСТРЕЛЯНА Е РАКЕТА, ВЕРОЯТНО С КОНВЕНЦИОНАЛЕН ЗАРЯД. ПОПАДЕНИЕ СЛЕД ПЕТ СЕКУНДИ — обажда се пак компютърът.\r\n— Цялата мощност на защитните екрани! Маневра за отклонение! Приготви се за аварийно напускане на совалката! — задъхано изстрелваш командите и посягаш към бутона, задействащ аварийните катапулти. Много късно!\r\nОслепителен блясък ви залива и само след миг совалката е разтърсена от мощната ударна вълна. Екраните се покриват със смущения и някои от тях угасват.\r\n— РАКЕТАТА В ЦЕЛТА — отбелязва безизразният глас на компютъра. — ЗАЩИТНИЯТ ЕКРАН Е ЧАСТИЧНО ПРЕОДОЛЯН. ПРЕДЛА…\r\nСтрахотен удар заглушава гласа на автомата. Корабът сякаш е спрян от огромна ръка, която го сграбчва и хвърля на земята. Още миг през тътена на експлозиите и скърцането на раздиран метал чуваш острия писък на аварийната сирена. Стенният панел пред теб се издува и като се пръска на хиляди парчета, пропуска унищожителен пламък, който те откъсва от предпазните колани и те захвърля на разбития космодрум.\r\nТи и цялата десантна група сте унищожени. Мисията ти остава неизпълнена. Е, случва се и „СТАР РЕЙНДЖЪРС“ да се провалят, особено ако командирът е неопитен.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Стъпваш, доколкото е възможно по-стабилно, стисваш здраво гранатата и… усещаш, че започваш да потъваш все по-бързо. Червената точка на прицела те приближава неумолимо. Имаш само миг, за да решиш.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Изстрелът ти е точен и ослепеният робот започва веднага да провежда контролни изстрели и да синхронизира прицела си с този на автомата. Ярките светкавици на лазерните импулси удрят все по-близо, но ти вече си застанал на твърда земя и хвърляш силно металния цилиндър. Гранатата се удря в робота и като го залива с яркото проблясване на освободената плазма, го спира завинаги.\r\n— Браво, лейтенант, спечелихте битката! — чуваш гласа на инструктора. — Викат Ви при командващия.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Веднага щом натискаш бутона за избор на лазерен бластер, се появява надпис:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Веднага щом натиснеш бутона за избор на плазмен бластер, се появява надпис:\r\nПРИЕМЛИВ ИЗБОР. ТЕСТЪТ ПРОДЪЛЖАВА.\r\nСИТУАЦИЯ: СРЕЩУ ВАС СА ДВАМА ДУШИ, КОИТО ИЗГЛЕЖДАТ ЕДНАКВО ПОСТРАДАЛИ ОТ БУРЯТА.\r\nИЗБЕРЕТЕ НАЧИН НА ДЕЙСТВИЕ:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ПОДХОДЯЩ ИЗБОР! ТЕСТЪТ ПРОДЪЛЖАВА.\r\nСИТУАЦИЯ 1: СРЕЩУ ВАС СА ДВАМА ДУШИ, КОИТО ИЗГЛЕЖДАТ ЕДНАКВО ПОСТРАДАЛИ ОТ БУРЯТА. ИЗБЕРЕТЕ НАЧИН НА ДЕЙСТВИЕ:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Решаваш, че неочакваното нападение е по-важно от орбиталното разузнаване и без колебание включваш общия комуникатор.\r\n— Започваме спускане след тридесет минути. Нормална процедура. Бойната група — в хангара за инструктаж!\r\n— И така, рейнджъри — обръщаш се малко по-късно към наобиколилите те десантчици. — Направихме малка грешка при старта и се налага отклонение от предварителния план. Спускаме се без орбитално разузнаване. Ще действаме на място, според ситуацията. Задачата е да унищожим комплекса за синтез на „Ситайк“ и да приберем научната документация. Имате копия от картите и данните на разузнаването. Двадесет минути за стартова готовност!\r\nИзвестно време доволен наблюдаваш точните действия на рейнджърите при сложната предстартова подготовка на десанта. За теб това е първата бойна операция и си силно впечатлен; на пръв поглед всички се суетят хаотично и за момент изглежда, че на кораба има поне още толкова хора. Но ето, транспортьорът е изваден от хангара и закрепен на десантния люк. Оръжията са заредени и проверени и част от бойците са вече в антиускорителните кресла. Всичко излишно е прибрано и закрепено.\r\n— Всичко е наред, сър! — приближава се до теб сержантът.\r\n— Бойната група е готова за предстартовото броене.\r\n— Сержант, ще кацнем почти слепешком. Не знам на какво можем да налетим, така че приготви хората за аварийно напускане на совалката.\r\n— СТО И ДВАДЕСЕТ СЕКУНДИ ДО СТАРТОВАТА ГОТОВНОСТ — съобщава компютърът на кораба. — ВСИЧКИ В АНТИУСКОРИТЕЛНИТЕ КРЕСЛА… СТО И ДЕСЕТ СЕКУНДИ ДО СТАРТОВАТА ГОТОВНОСТ. ВКЛЮЧВАМ ДВИГАТЕЛИТЕ.\r\nХвърляш последен поглед наоколо; всичко изглежда наред и ти бързаш да се настаниш в креслото и да затегнеш предпазните колани.\r\n— СТО СЕКУНДИ ДО СТАРТОВАТА ГОТОВНОСТ — продължава броенето автоматът. — ДВИГАТЕЛИТЕ — В РАБОТЕН РЕЖИМ.\r\nЗатваряш очи и като се отпускаш, чакаш сътресението на старта.\r\n— СЕДЕМДЕСЕТ СЕКУНДИ ДО СТАРТОВАТА ГОТОВНОСТ. ДВИГАТЕЛИТЕ — В СТАРТОВ РЕЖИМ.\r\nЛека вибрация пронизва кораба и в кабината навлиза мощното бучене на форсираните двигатели.\r\n— Къде ще се приземим, командире? — пита първият пилот.\r\n— Дайте координатите!\r\nЕто, че веднага възниква нов проблем. Улисан в подготовката на десанта си забравил, че сте се отклонили от плана и трябва да решиш къде ще кацнете.\r\n— ШЕСТДЕСЕТ СЕКУНДИ ДО СТАРТОВАТА ГОТОВНОСТ. ДВИГАТЕЛИТЕ ГОТОВИ — монотонно съобщава компютърът. — ЗАПОЧВАМ НАСОЧВАНЕ.\r\nКакво да правиш, има само една минута до стартиране на совалката, а трябва да вземеш съдбоносно за цялата операция решение. Няма време за нови изчисления, затова трябва да се ограничиш с общо насочване и да разчиташ на опита на пилотите.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "С няколко предпазливи маневри и краткотрайни включвания на двигателите достигате до предвидената по първоначалния план позиция. Долу в джунглите, точно под вас, се намира тайният производствен комплекс на един от най-големите наркокартели. Нетърпеливо се привеждаш над екрана за визуален контрол. Дълго време не може да се получи ясен образ. Ниска и плътна облачност закрива напълно повърхността, силно наситената с електричество атмосфера смущава прецизната настройка на електронните скенери и покрива мътния образ на екрана с ярки проблясвания.\r\nВсе пак маневрите ви не са останали незабелязани. Докато ти горе се мъчиш с екраните на визуалния контрол, долу един от дежурните наблюдатели се е навел над дисплея на компютъра и се разкъсва от колебания. Преди няколко минути следящата система сигнализира, че засича енергиен източник в орбита, но не успява да го локализира и потвърди. Силно смутен, дежурният все още не може да вземе решение. Както и при вас, активните системи за следене са строго забранени. Картелът пази най-голямата си тайна с цената на известна несигурност. Дали наблюдателят ще се реши да обяви тревога или ще си замълчи?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Хващаш бластера с две ръце и като се прицелваш внимателно, стреляш срещу робота-снайнерист.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Приготви бластерите! — командваш високо. — Опитайте се да насочите дефлектора!\r\n— ИЗТРЕБИТЕЛЯТ Е НАД СОВАЛКАТА. ШЕСТДЕСЕТ ГРАДУСА ОТ ОСТА НА КУРСА. АТАКУВА. НАСОЧВАНЕТО НА ДЕФЛЕКТОРА Е НЕВЪЗМОЖНО — безстрастно обявява компютърът.\r\n— Виждам го! Виждам го! — почти шепне кибернетикът. — Хванах го! — и веднага вика: — Какво става?… Автомат, повреда в бластерите!\r\n— ЕНЕРГИЯ НА БЛАСТЕРИТЕ: НУЛА — обявява автоматът. — ПРЕПОРЪЧВАМ АВАРИЙНО НАПУСКАНЕ НА СОВАЛКАТА.\r\nТочните попадения на противниковите бластери се впиват в корпуса на совалката и започват да го рушат. Още няколко мига пилотът се опитва да овладее повредения кораб и да го приземи, когато сполучлив изстрел в енергийния генератор ви превръща в унищожителен огнен ураган, който се стоварва право върху комплекса.\r\nМощен ядрен взрив помита почти всичко. Огромен гъбовиден облак се издига високо и се забива в ниското дъждовно небе.\r\nСвидетели на страшната катастрофа са само група местни ловци, които отдалече наблюдават битката. Когато земята спира да трепти под краката им, те бързо се отправят към селото, за да занесат радостната новина.\r\nИзпълнил си задачата с цената на твоя и на екипажа живот.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Обърни! Опитай да ни приземиш в джунглата! — викаш на слисания пилот. — По-бързо!\r\n— Изтребител над нас, шестдесет градуса от оста на курса. Приближава.\r\n— Приготви се за аварийно кацане!\r\n— Командире, подмина ни! — вика радостно пилотът. — Изгубил ни е!\r\nВъздишка на облекчение преминава през кораба, когато…\r\n— РАКЕТИ ОТЗАД, ТОЧНО ПО ОСТА НА КУРСА. УДАР СЛЕД ДЕСЕТ СЕКУНДИ — отрезвява ви гласът на бордовия компютър. Изтребителят не ви е пропуснал, а просто е изстрелял ракети с ниска скорост, способни да преодолеят защитното поле.\r\n— Цялата мощност на защитните екрани! Пилот, къде сме?\r\n— Над джунглата, на около три километра от комплекса. Снижавам.\r\n— РАКЕТИ ОТЗАД, ПО ОСТА НА КУРСА. МАЛКА СКОРОСТ. УДАР СЛЕД СЕДЕМ СЕКУНДИ.\r\n— Бластерите, преграден огън! Опитай да ги взривиш!\r\n— Командире, не мога да ги спра! Енергията спада!\r\nСякаш чакал само това, компютърът веднага обявява:\r\n— ЕНЕРГИЯ НА БЛАСТЕРИТЕ НУЛА. РАКЕТИ ОТЗАД, ПО ОСТА НА КУРСА. УДАР СЛЕД ПЕТ СЕКУНДИ.\r\n— Маневра за отклонение! Внимание! Започваме аварийно напускане на совалката!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Без повече да се колебаеш, вдигаш автомата и с един кратък ред слагаш край на инцидента.\r\n— Хайде да се връщаме! — сърдито казваш на хората си. — Няма повече да се занимаваме с тези малки неблагодарници.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "С мъка сдържаш желанието си да ги избиеш и като оставяш внимателно оръжието си, казваш отчетливо:\r\n— Ние сме приятели! Идваме с мир! — и после тихо добавяш за хората си: — Свалете оръжията, но бъдете нащрек! — Надяваш се местните да разберат по-скоро жеста, а не думите ти.\r\n— Ти не приятел! Ти от злите! — с омраза произнася един от ловците. С учудване разбираш, че той говори на стария универсален език на империята. Леко скърцане и трите стреломета отново са насочени към теб. Видът на заплашващите ви със стрели дребосъци изведнъж ти се струва толкова смешен, че не издържаш и като избухваш в смях, сядаш на калната земя.\r\n— Не съм от злите — едва успяваш да кажеш ти. — Аз съм приятел! Ето виж — и като побутваш с крак оръжието, махаш на хората си да направят същото.\r\nВсичко това идва прекалено много за бедните туземци и те също пристъпват наблизо.\r\n— Кой вие? — пита вече по-дружелюбно водачът им. — Вие убили захуса и спасили нас. Защо прави?\r\n— Какво е „захуса“? — питаш, като се опитваш да спечелиш време ти.\r\n— Този е захуса — посочва мъртвия динозавър ловецът. — Защо спасили? Искаш роби? Не…? Ние не каже къде селото! — добавя твърдо той.\r\n— Не ни трябва твоето село — отговаряш му вече сериозно. — Трябва ни водач до едно място с хора като нас.\r\n— Ти ходи при злите! — скача пак туземецът. — Защо?\r\n— За да ги унищожа! — вече започваш да се ядосваш и ти. — Ако не вярваш, ела да видиш кораба ми — хрумва ти изведнъж спасителната идея.\r\n— Аз дойде на кораб — заявява след кратко колебание дребният ловец. — Вие чака тук и ходи предупреди старейшини — нарежда той на останалите.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = " — Отлично, лейтенант! — старият командващ изглежда много доволен. — Ще поемете първата си самостоятелна задача.\r\nКато ти подава една дискета, генералът те поглежда изпитателно и ненадейно започва истински изпит.\r\n— Знаете ли какво е това „Ситайк-дрог“?\r\n— Това е наркотик, от който се получава така наречената „мотивационна зависимост“. Може да се произвежда само на планетата Ситай, оттам и името му. Получен е преди приблизително три века от имперската изследователска станция на Ситай. Местонахождението на планетата е неизвестно. „Ситайк-дрог“ се среща много рядко, вероятно това са стари запаси.\r\n— Така, от известно време „Ситайк-дрог“ се появи отново. Не са стари запаси! Този е ново производство. Не толкова силен и чист като имперския, но достатъчно опасен. Заловихме няколко явни „пробни екземпляра“; разузнаването предполага, че се готви някаква голяма операция. Успяхме и да намерим системата Ситай. На дискетата са данните, с които разполагаме. Успех, лейтенанте!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Късно през нощта всичко е готово и хората ти се оттеглят за кратка почивка преди трудния преход през джунглата. Освен дежурния наблюдател само ти си все още буден. Предстои ти да вземеш още едно трудно решение — как да пътувате.\r\nТранспортьорът явно няма да може да премине, но турбоплатформата?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Въпреки всичко решаваш да рискуваш и да вземеш турбоплатформата. Натоварвате на нея цялата допълнителна екипировка, като за пилот оставяш електронния специалист, който ще се сменя от кибернетика и ако се наложи — от теб.\r\nИ така, започвате тежък и изморителен преход през джунглите на Ситай. Още през първите няколко часа се уверяваш, че няма да успеете да се придвижите за седем дни съгласно първоначалния план. Гъсто преплетени дървета и пълзящи растения, залети от вода и така замаскирани коварни блата, почти непрестанни валежи и множество опасни земноводни са само малка част от очакващите ви трудности.\r\nВсе пак опитът и тренировките ви помагат да преодолеете трудностите и в края на първия ден замръквате само на няколко километра от поставената цел. Изникнало е и друго неприятно затруднение. Оказва се, че турбоплатформата не е в състояние да се движи наравно с вас. Наистина там, където може да се промъкне човек, невинаги е достъпно за голямата тежко натоварена машина.\r\nТака че проблемът е поставен отново:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "След дълги колебания се примиряваш с мисълта да изоставиш част от екипировката на групата.\r\nВсеки от хората ти може да пренесе през джунглата 35 кг.\r\nТеглото на оръжието на един рейнджър е 12 кг, ако си избрал „ЩУРМОВИЯ КОМПЛЕКТ“, и 6 кг за „ДИВЕРСИОННИЯ КОМПЛЕКТ“.\r\nВсеки от групата ти е снабден с индивидуален „боен“ комплект, включващ шлем с радиопредавател, пакет концентрирани храни за 10 дни, лична аптечка, както и допълнителни боеприпаси и батерии — всичко с общо тегло 10 кг.\r\nДотук са личните средства, които са задължителни за оцеляването на хората ти.\r\nИ така, съществуват само две алтернативни възможности:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Просваш се с цял ръст в лепкавата кал и внимателно повдигаш глава, за да наблюдаваш робота. Червената точка на прицела те приближава неумолимо. Роботът е вече близо, стисваш здраво гранатата, напрягаш се за скок и… само пропадаш по-дълбоко в тинята. Пламнал от срам и яд, изчакваш робота да маркира попадение и да те измъкнат от погълналата те кал.\r\n— Тази битка я загубихте, лейтенант — чуваш гласа на инструктора. — Викат Ви при командващия.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Лягаш с цял ръст в калта и внимателно вдигаш глава, за да наблюдаваш робота. Веднага щом помръдваш, си заслепен от ярка червена светлина, маркираща изстрел, което значи, че си уцелен. Ядосан се изправяш и докато се измъкваш от тинята, чуваш гласа на инструктора по контролиращата уредба.\r\n— Тази битка я загубихте, лейтенант. Викат Ви при командващия.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Просваш се с цял ръст в лепкавата кал и внимателно повдигаш глава, за да наблюдаваш робота. Червената точка на прицела те приближава неумолимо. Роботът е вече близо, стисваш здраво гранатата, напрягаш се и я хвърляш от легнало положение. Металният цилиндър пада далеч от целта и избухва, без да навреди на робота. Моментално си засечен и заслепен от ярка червена светлина, маркираща изстрел, което значи, че си уцелен. Ядосан се изправяш и докато се измъкваш от тинята, чуваш гласа на инструктора по контролиращата уредба.\r\n— Тази битка я загубихте, лейтенант. Вика Ви командващият.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Включете всички активни устройства! — командваш решително. — Готови за директна атака!\r\nСамо за няколко секунди имате пълна информация за целия комплекс. В паметта на компютрите постъпват данни за разположението, размера и предназначението на постройките, броя на хората в района, разположението и типа на защитните системи.\r\n— ШЕСТДЕСЕТ СЕКУНДИ ПРЕДСТАРТОВА ГОТОВНОСТ — обявява компютърът. — ДВИГАТЕЛИТЕ ГОТОВИ ЗА СТАРТ. ЗАПОЧВАМ НАСОЧВАНЕ.\r\n— Спускаме се в района на космодрума им. Максимална скорост!\r\n— ПЕТДЕСЕТ СЕКУНДИ ПРЕДСТАРТОВА ГОТОВНОСТ. РАЙОНЪТ Е ЛОКАЛИЗИРАН.\r\n— Откриваме цел! Скоростна, с малки размери. Вероятно ракета. Удар след тридесет секунди!\r\n— Защитните екрани ще издържат ли?\r\n— Няма данни за типа на ракетата. Предлагам унищожаване.\r\n— ЧЕТИРИДЕСЕТ СЕКУНДИ ПРЕДСТАРТОВА ГОТОВНОСТ. НАСОЧВАНЕТО ИЗВЪРШЕНО.\r\n— Приготви бойните лазери! Максимален обхват! Огън!\r\nОслепителен блясък залива за няколко мига кораба ви. Зарядът на ракетата вероятно е бил ядрен, но защитният екран устоява.\r\n— Целта е поразена, командире! — докладва сред одобрителни възгласи кибернетикът, заел мястото на бордовия стрелец.\r\n— КРАЙ НА ПРЕДСТАРТОВАТА ГОТОВНОСТ — съобщава компютърът. — ЗАПОЧВАМ СПУСКАНЕ. СТАРТ!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Вземаш решението моментално. Единственият приемлив вариант е да се спуснете дълбоко в джунглата и там да съставиш нов план на действие.\r\n— Насочи се към джунглата. Ъглово отклонение тридесет градуса — и като забелязваш учудения поглед на пилота, подхвърляш: — Гледай да не ни забиеш в някое блато!\r\n— ТРИДЕСЕТ СЕКУНДИ ДО СТАРТОВАТА ГОТОВНОСТ. СЕКТОРЪТ Е ЛОКАЛИЗИРАН. НАВЛИЗАМЕ В ПОЗИЦИЯ ЗА СПУСКАНЕ. ВКЛЮЧВАМ СТАРТОВА МОЩНОСТ.\r\nОтпускаш се отново и затваряш очи. Вече е късно за връщане. Дано само не ви забележат при спускането.\r\n— КРАЙ НА ПРЕДСТАРТОВАТА ГОТОВНОСТ — отбелязва компютърът. — ЗАПОЧВАМ СПУСКАНЕ. СТАРТ!\r\nСилен тласък те притиска към креслото и от ускорението пред очите ти се спуска черна пелена. Като през памук чуваш съобщенията на автомата за параметрите на полета. Всичко продължава само няколко мига, все пак совалката е с малка маса и бързо достига необходимата скорост.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Изключи двигателите! — решаваш веднага ти. — Започваме безмоторно спускане в района на комплекса.\r\n— ДВИГАТЕЛИТЕ НА НУЛА — откликва веднага компютърът. — ПРЕДСТАРТОВАТА ГОТОВНОСТ Е ОТМЕНЕНА. ДАЙТЕ КООРДИНАТИ ЗА НАСОЧВАНЕ!\r\n— Насочи совалката някъде в северозападния край! — посочваш на първия пилот място, което изглежда по-високо и вероятно е по-сухо.\r\n— Няма ли да ни усетят, когато прелетим над тях? — пита със съмнение в гласа кибернетикът.\r\n— В тези облаци? — отговаряш му. — Съмнявам се, а и ние ще подходим отстрани.\r\n— КООРДИНАТИТЕ ЗА СПУСКАНЕ УТОЧНЕНИ — съобщава компютърът. — ЗАПОЧВАМ НАСОЧВАНЕ. ТРИДЕСЕТ СЕКУНДИ ДО СТАРТА.\r\nОтново се облягаш назад в мекото кресло и затваряш очи. Дано не си взел погрешно решение!\r\n— КРАЙ НА НАСОЧВАНЕТО. ЗАПОЧВАМ БЕЗМОТОРНО СПУСКАНЕ.\r\nС леко свистене от носовите дюзи излитат силни струи прегрята пара. Скоростта на кораба намалява, докато гравитацията надделява над инерцията и започвате свободно спускане. С гръмък рев совалката се забива в атмосферата, серия тежки удари и вибрации преминава по корпуса и скоростта започва стремително да намалява. След няколко секунди полетът се стабилизира и безстрастният глас на автомата обявява:\r\n— УСПЕШНО НАВЛИЗАНЕ В АТМОСФЕРАТА. ВСИЧКИ СИСТЕМИ РАБОТЯТ ИЗПРАВНО. ИЗХВЪРЛЯМ ТОПЛИННИТЕ ЩИТОВЕ. ПРЕМИНАВАМ В РЕЖИМ НА БЕЗМОТОРЕН ПОЛЕТ. НЯМА ОТКЛОНЕНИЯ ОТ КУРСА.\r\n— Всички защитни и маскировъчни системи на пълна мощност! — докладва единият от пилотите.\r\n— Останете по местата си! — казваш бързо, усетил раздвижване зад гърба си. — И по-тихо! — Възможно е да има акустични детектори.\r\nТиха и невидима като призрак, совалката се плъзва почти над западната ограда на комплекса и леко ляга в меката пръст на малко възвишение, само на три километра от него.\r\nСлед около тридесет минути сте на повърхността. Совалката е стъпила стабилно на малко островче от сравнително твърда земя. Отличното спускане е подобрило настроението на цялата група и сега всички са се събрали пред екраните, показващи чуждия свят. Пейзажът навън изглежда като кошмар, създаден от болен мозък. Криви дървета и зловещи, виещи се растения са преплетени в почти непроходим гъсталак. Всичко е обвито в тежки изпарения и разкъсани парцали гъста мъгла. Под дърветата цари сив сумрак, през който се движат неясни сенки. Растенията имат странен посърнал цвят, преливащ от белезникаво зелено до мръсно сиво.\r\nИ така, първата част на задачата е изпълнена успешно. Приземил си се незабелязан и имаш цели 15 дни за провеждане на операцията.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Свиваш се, доколкото може в лепкавата кал и внимателно повдигаш глава, за да наблюдаваш робота. Червената точка на прицела те приближава неумолимо. Роботът е вече близо, стисваш здраво гранатата, напрягаш се за скок и хвърляш с все сила леко проблясващия метален цилиндър.\r\nВ същия момент си заслепен от яркия лъч, маркиращ попадение на снайпериста. Гранатата се удря в робота и като го залива с яркото проблясване на освободената плазма, го спира завинаги. Ядосан от неуспеха си, прострелваш и беззащитния прицелен автомат.\r\n— Това не беше нужно, лейтенант — чуваш гласа на инструктора. — Викат Ви при командващия. Обаче бяхте на косъм от загуба на битката.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Свиваш се, доколкото може в лепкавата кал и внимателно повдигаш глава, за да наблюдаваш робота. Червената точка на прицела те приближава неумолимо. Роботът е вече близо, стисваш здраво гранатата, напрягаш се за скок и хвърляш с все сила леко проблясващия метален цилиндър. Гранатата се удря в робота и като го залива с яркото проблясване на освободената плазма, го спира завинаги. Доставяш си удоволствието да простреляш и беззащитния прицелен автомат.\r\n— Това не беше нужно, лейтенант — чуваш гласа на инструктора. — Викат Ви при командващия.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Свиваш се, доколкото може в лепкавата кал и внимателно повдигаш глава, за да наблюдаваш робота. Червената точка на прицела те приближава неумолимо. Роботът е вече близо, стисваш здраво гранатата, напрягаш се за скок и… само пропадаш по-дълбоко в тинята. Пламнал от срам и яд, изчакваш робота да маркира попадение и да те измъкнат от погълналата те кал.\r\n— Тази битка я загубихте, лейтенант — чуваш гласа на инструктора. — Викат Ви при командващия.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Насочи лазерите към торпедата! Огън! — крещиш ти.\r\nОслепителен блясък ви залива и само след миг совалката е разтърсена от мощна ударна вълна. Екраните се покриват със смущения и някои от тях угасват.\r\n— РАКЕТАТА В ЦЕЛТА — отбелязва безизразният глас на компютъра. — ЗАЩИТНИЯТ ЕКРАН Е ЧАСТИЧНО ПРЕОДОЛЯН. ПРЕДЛА…\r\nСтрахотен удар заглушава гласа на компютъра. Корабът сякаш е спрян от огромна ръка, която го сграбчва и хвърля на земята. Още миг през тътена на експлозиите и скърцането на раздиран метал чуваш острия писък на аварийната сирена. Стенният панел пред теб се издува и като се пръсва на хиляди парчета, пропуска унищожителен пламък, който те откъсва от предпазните колани и те захвърля на разбития космодрум.\r\nТи и цялата десантна група сте унищожени. Мисията ти остава неизпълнена.\r\nЕ, случва се и „СТАР РЕЙНДЖЪРС“ да се провалят, особено ако командирът е неопитен.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Лазерните бластери, огън по ракетата! — викаш, като се опитваш да запазиш спокойствие. И в същия момент…\r\n— ВЪЗДУШНИ ТОРПЕДА В ЦЕЛТА — ярки проблясвания и тътнещи експлозии, които разтърсват кораба показват, че защитните екрани са издържали.\r\n— Изгубих ракетата, командире! — отчаяно крещи първият пилот.\r\n— Веднага локализирай и стреляй без заповед! Внимание, готови за аварийно напускане на совалката! Пилот, насочи се към гората!\r\n— РАКЕТАТА Е ОТКРИТА — обажда се компютърът. — ПРИБЛИЖАВА СЕ ОТЗАД С МАЛКА СКОРОСТ. УДАР СЛЕД ДЕСЕТ СЕКУНДИ.\r\n— Подминала ни е при взрива на торпедата! Лазерите, огън!\r\n— Не става, лейтенант — казва след няколко напрегнати секунди кибернетикът. — Снабдена е с противолъчева защита. Мога само да я забавя леко.\r\n— Цялата мощност на защитните екрани! Пилот, къде сме?\r\n— Над джунглата, на около три километра от комплекса. Снижавам.\r\n— РАКЕТА ОТЗАД, ПО ОСТА НА КУРСА. МАЛКА СКОРОСТ. УДАР СЛЕД СЕДЕМ СЕКУНДИ.\r\n— Командире, не мога да я задържам повече! Енергията спада!\r\nСякаш чакал само това, компютърът веднага обявява:\r\n— ЕНЕРГИЯ НА БЛАСТЕРИТЕ: НУЛА. РАКЕТА ОТЗАД, ПО ОСТА НА КУРСА. УДАР СЛЕД ПЕТ СЕКУНДИ.\r\n— Маневра за отклонение! Внимание! Започваме аварийно напускане на совалката!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Като уточнявате за последен път координатите на срещата, той издига високо машината и се понася в прохладния въздух. За нещастие късметът днес не е на твоя страна.\r\nОще докато набира височина, от прикритието на ниските облаци се появява малък реактивен изтребител и като пикира стремително, забива в беззащитната машина серия от лазерни импулси, превръщайки я в ярко пламтящ факел. Веднага, без да чакат команда, рейнджърите обсипват с огън от всички оръжия изтребителя и той, поразен многократно, се преобръща веднъж и силна експлозия го разбива на парчета.\r\nЗа нещастие, освен кибернетика загива и един от рейнджърите. Но най-тежка е загубата на всичкото ви тежко оръжие и специалната екипировка.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Като уточнявате за последен път координатите на срещата, издигаш високо машината и се понасяш в прохладния въздух. За нещастие, късметът днес не е на твоя страна.\r\nОще докато набираш височина, от прикритието на ниските облаци се появява малък реактивен изтребител. Като пикира стремително, забива в беззащитната ти машина серия от лазерни импулси, които те превръщат в ярко пламтящ факел и бързо слагат край на мисията ти. Миг преди края виждаш ответния огън на рейнджърите, но дали успяват, така и никога няма да разбереш.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Моментално се възползваш от стъписването на туземеца и с един бърз изстрел го поваляш на земята. В отговор сте засипани от градушка стрели, които все така загадъчно се отклоняват, преди да ви достигнат.\r\n— Обкръжени сме, сър! — вика залегналият наблизо сержант. — Не се виждат, но положително са някъде наблизо.\r\n— Внимание, слушайте всички! — командваш високо и се изправяш, вече без да се криеш. — Нападнати сме без никакво предизвикателство… — Нов порой стрели те прекъсва за момент — Отменям заповедта за неприкосновеност на местните! Огън!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "С мъка сдържаш желанието си да го убиеш и като оставяш внимателно оръжието, си казваш отчетливо:\r\n— Ние сме приятели! Идваме с мир! — и после тихо добавяш за хората си: — Свалете оръжията, но бъдете нащрек! — надяваш се местните да разберат по-скоро жеста, а не думите ти.\r\n— Ти не приятел! Ти от злите! — с омраза произнася ловецът. С учудване разбираш, че той говори на стария универсален език на империята. Леко скърцане и стрелометът му отново е насочен към теб. Видът на заплашващия те със стрели дребосък изведнъж ти се струва толкова смешен, че не издържаш и като избухваш в смях, сядаш на калната земя.\r\n— Не съм от злите — едва успяваш да кажеш ти. — Аз съм приятел! Ето виж — и като побутваш с крак оръжието, махаш на хората си да направят същото.\r\nВсичко това идва прекалено много за бедните туземци и те също пристъпват по-близо. Скоро се оказвате заобиколени от доста голяма група. След дълги обяснения и спорове успяваш да накараш ловците да ти повярват и да те заведат в селото си. След няколкодневно разтакаване из джунглите най-после новите ви приятели те завеждат при тайнствения „съвет на старейшините“, който явно взема решенията в племето им.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ЛОШ ИЗБОР!\r\nКРАЙ НА ТЕСТА.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "СИТУАЦИЯ 2: ДВАМАТА СА ОБЕЗОРЪЖЕНИ. ЗАДАВАШ ВЪПРОС НА ПЪРВИЯ: „КОЙ СИ ТИ?“ СИЛНИЯТ ВОЙ НА ВЯТЪРА ТИ ПРЕЧИ ДА ЧУЕШ ОТГОВОРА. ТОГАВА ВТОРИЯТ СЕ ОБАЖДА: „ТОЙ КАЗА, ЧЕ Е ТЕРОРИСТ.“\r\nУСЛОВИЕ: ТЕРОРИСТЪТ ВИНАГИ ЛЪЖЕ, А ЗАЛОЖНИКЪТ КАЗВА ИСТИНАТА.\r\nДОСТАТЪЧНО ЛИ Е ТОВА, ЗА ДА ГИ РАЗПОЗНАЕТЕ?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "СИТУАЦИЯ 2: ЕДИНИЯТ ОТ ПЛЕННИЦИТЕ ЗАДЕЙСТВА ЗАКРЕПЕНА КЪМ ТЯЛОТО СИ БОМБА, КОЯТО ПОРАЗЯВА И ТРИМА ВИ.\r\nКРАЙ НА ТЕСТА.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Късно през нощта всичко е готово и хората ти се оттеглят за кратка почивка преди трудния преход през джунглата. Освен дежурния наблюдател само ти си все още буден. Предстои ти да вземеш още едно трудно решение — как да пътувате.\r\nТранспортьорът явно няма да може да премине, но турбоплатформата?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Тежкият няколкодневен преход през кошмарната, заливана от почти непрестанен дъжд джунгла ви дава отлична възможност взаимно да се опознаете и прецените възможностите си. Външният вид на новите ти съюзници е силно обезобразен от продължилата много поколения генетична мутация. Телата им са дребни и слаби, с тесни, сплескани странично гърди. Краката им са дълги, с много широки стъпала и свързани с ципа пръсти. Гъвкавите, сръчни пръсти на още по-дългите им ръце също са частично свързани с по-малка ципа. Най-странно изглеждат обаче главите им, продълговати и със силно изтеглен назад тил и две големи изпъкнали очи, разположени така, че могат да виждат почти на всички посоки, без да се обръщат. Устата са с тесни, стиснати устни. Носът е почти незабележим, сведен до малка издутина с две коси цепки, затварящи се с ципа. Ушите са големи, остри и много подвижни. Въобще местните приличат на странни, странично сплескани жаби, но както се оказва, идеално приспособени за условията на свят, покрит с блата и наводнени джунгли.\r\nНо, разбира се, не видът им е това, което привлича вниманието ти; галактиката е пълна и с много по-странни същества. Най-силно си поразен от оръжията им. На пръв поглед приличат на обикновени примитивни арбалети, но вместо с обичайния лък стрелите се изстрелват от полето на силен електромагнитен генератор. Самите стрели са къси и дебели, с вградена в тях мощна кондензаторна батерия. Ударната сила на оръжието е сравнително малка, но в поразяващите възможности на електрическата стрела се убеждаваш още първия ден, когато ловците повалят само с два изстрела голямо колкото слон и бронирано с дебели костни плочки животно.\r\nНай-невероятното обаче е, че дългата широка тръба, снабдена с удобна ръкохватка, се оказва стар термичен бластер от времето на империята. Загадка остава как са успели да го запазят изправен няколко века. Друго, не по-малко загадъчно обстоятелство е как успяват да намират енергия за стрелите и особено за бластера.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Разбира се, както си и предполагал, отговорът на всичко се крие в селото им. Колибите им се оказват малки полуземлянки, удивително напомнящи купчини пръст и освен съвършената си маскировка, не притежават нищо интересно. Интересното и дори смайващо нещо е един почти потънал в земята и обрасъл с лиани, но напълно здрав имперски транспортен кораб от лек клас. В неговата просторна и сравнително суха командна кабина ви посрещат петимата старейшини на племето.\r\nИсторията на племето, която научавате от тях, е разказ за дългата и безнадеждна борба на изоставените колонисти — първо срещу враждебния и опасен свят, а след това и срещу все по-силното израждане и мутиране на хората. След няколко поколения борбата е загубена и колонията загива. Оцелелите се пръскат из джунглите и се обособяват в няколко племена, живеещи на големи разстояния едно от друго. Тукашното племе се състои от потомци на групата, която последна се оттегля, след като поддържащите автомати престават да ги разпознават и да им се подчиняват и започват да консервират лабораториите, енергоцентралата и всички по-важни постройки.\r\nНякъде по това време идва и последният кораб — автоматичен транспортьор, който поради повреда пада в джунглата. Товарът се оказва истинско богатство — купища резервни части и инструменти, предназначени за някаква военна база, а работещият с бавни неутрони термоядрен енергогенератор — истински късмет.\r\nПреди няколко години на планетата пристигат сегашните й завоеватели и като разконсервират и разширяват производствения комплекс, започват лов на местни жители, които принуждават да работят като роби.\r\nИсторията е дълга и тъжна, но няма отношение към задачата ти, така че накратко, старейшините ти предлагат племето да участва в нападение срещу комплекса.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Постепенно локаторите на преследвача разширяват обхвата и в един момент на един от дисплеите проблясва кратък сигнал за открито биополе. Инфрачервеният локатор не потвърждава данните и компютърът не обявява тревога. След кратко колебание командирът на преследвачите решава да се подсигури и нарежда да се изстрелят няколко малки ракети по предполагаемата цел.\r\nПронизващо свистене разцепва въздуха и три неуправляеми ракети с малка мощност се насочват към колибата ви. Почти веднага следват три приглушени експлозии и без да усетите, от царството на сънищата сте пренесени във вечността.\r\nЗа съжаление, мисията ти остава неизпълнена.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Постепенно локаторите на преследвача разширяват обхвата и за момент на един от дисплеите проблясва кратък сигнал за открито биополе. Инфрачервеният локатор обаче не потвърждава данните и компютърът не обявява тревога. За ваш късмет, в същия момент наблюдателят е откъснал погледа си от екрана и уморено се протяга. Никой не обръща внимание на краткия сигнал и като разширяват обхвата на лъча, преследвачите ви пропускат.\r\nСамо момент невнимание ви спасява от сигурно разкриване. След като обикаля още няколко пъти, платформата се издига и се прибира в базата си.\r\nРазочарованите ловци се измъкват от локвата и като наобикалят на почетно разстояние колибата ви, отново се приготвят да чакат.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Постепенно локаторите на преследвача разширяват обхвата и в един момент на един от дисплеите проблясва кратък сигнал за открито биополе. Инфрачервеният локатор не потвърждава данните и компютърът не обявява тревога. След кратък размисъл командирът на преследвачите решава да се подсигури и нарежда да се изстрелят няколко малки ракети по предполагаемата цел.\r\nПронизващо свистене разцепва въздуха и три неуправляеми ракети с малка мощност се насочват към колибата ви. Почти веднага следват три приглушени експлозии и… Явно шансът е на твоя страна, защото и трите попадат далеч от целта. На светлината от експлозиите постройката ви се очертава ясно на фона на тъмната гора.\r\n— Какво е това? — посочва колибата ви един от войниците.\r\n— Купчина боклуци — без колебание отсича командирът.\r\n— Добре са ги натрошили тия. Жалко, така и не разбрахме кои са!\r\nСамо момент невнимание ви спасява от сигурно разкриване. След като обикаля още няколко пъти, платформата се издига и се прибира в базата си.\r\nА в това време…\r\n— Командире, събуди се! — разтърсва те един от рейнджърите. — Нещо става навън.\r\n— Нищо няма, чух само гръмотевици — сънено отвръщаш ти. — Ако не ти се спи, можеш да останеш на пост.\r\nРазочарованите ловци се измъкват от локвата и като наобикалят на почетно разстояние колибата ви, отново се приготвят да чакат.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ЛОШ ИЗБОР!\r\nКРАЙ НА ТЕСТА.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "СИТУАЦИЯ 2: ДВАМАТА СА ОБЕЗОРЪЖЕНИ. ЗАДАВАШ ВЪПРОС НА ПЪРВИЯ: „КОЙ СИ ТИ?“ СИЛНИЯТ ВОЙ НА ВЯТЪРА ТИ ПРЕЧИ ДА ЧУЕШ ОТГОВОРА. ТОГАВА ВТОРИЯТ СЕ ОБАЖДА: „ТОЙ КАЗА, ЧЕ Е ТЕРОРИСТ.“\r\nУСЛОВИЕ: ТЕРОРИСТЪТ ВИНАГИ ЛЪЖЕ, А ЗАЛОЖНИКЪТ КАЗВА ИСТИНАТА.\r\nДОСТАТЪЧНО ЛИ Е ТОВА, ЗА ДА ГИ РАЗПОЗНАЕТЕ?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "СИТУАЦИЯ 2: ЕДИНИЯТ ОТ ПЛЕННИЦИТЕ ЗАДЕЙСТВА ЗАКРЕПЕНА КЪМ ТЯЛОТО СИ БОМБА, КОЯТО ПОРАЗЯВА И ТРИМА ВИ.\r\nКРАЙ НА ТЕСТА.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Все пак решаваш да рискуваш и на другия ден кибернетикът, който днес пилотира, издига машината високо над дърветата и с максимална скорост се отдалечава напред. Идеята е да ви чака на предварително уговорено място.\r\nПреходът минава без особени премеждия и вечерта благополучно се настанявате до умело скритата в храстите турбоплатформа и като по чудо и дъждът е спрял, което допълнително подобрява настроението ти.\r\nКогато мътната светлина на утрото пробива облаците и тежката предутринна мъгла започва да се сляга отново, се налага да вземеш важно решение. През нощта електронният специалист е заболял и не е в състояние да управлява платформата.\r\nТрябва да избираш между две възможности:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "След дълги колебания се примиряваш с мисълта да изоставиш част от екипировката на групата.\r\nВсеки от хората ти може да пренесе през джунглата 35 кг.\r\nТеглото на оръжието на един рейнджър е 12 кг, ако си избрал „ЩУРМОВИЯ КОМПЛЕКТ“, и 6 кг за „ДИВЕРСИОННИЯ КОМПЛЕКТ“.\r\nВсеки от групата ти е снабден с индивидуален „боен“ комплект, включващ шлем с радиопредавател, пакет концентрирани храни за 10 дни, лична аптечка, както и допълнителни боеприпаси и батерии — всичко с общо тегло 10 кг.\r\nДотук са личните средства, които са задължителни за оцеляването на хората ти.\r\nИ така, съществуват само две алтернативни възможности:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Външният вид на туземците е, меко казано, странен — силно обезобразен от продължилата много поколения генетична мутация. Телата им са дребни и слаби, с тесни сплескани странично гърди. Краката са дълги, с много широки стъпала и свързани с ципа пръсти. Гъвкавите, сръчни пръсти на още по-дългите им ръце също са частично свързани с по-малка ципа. Най-странно изглеждат обаче главите им, продълговати и със силно изтеглен назад тил и две големи изпъкнали очи, разположени така, че могат да виждат почти на всички посоки, без да се обръщат. Устата са с тесни стиснати устни, носът е почти незабележим, сведен до малка издутина с две коси цепки, затварящи се с ципа, ушите са големи, остри и много подвижни. Въобще местните приличат на странни, странично сплескани жаби, но както се оказва, идеално приспособени за условията на свят, покрит с блата и наводнени джунгли.\r\nКогато разглеждате оръжията им, се решава и загадъчното отклоняване на стрелите. Подобни на примитивни арбалети, те се оказват хитроумно приспособление, изстрелващо със силно магнитно поле поместен в стрела кондензатор с изключително голям капацитет. Електрическият заряд се оказва толкова силен, че само едно докосване на върха може да се окаже смъртоносно. По ирония на съдбата това ви е помогнало. Статичното електрическо поле на кондензатора е толкова голямо, че позволява на дефлектора да се задейства и да отклони стрелата.\r\n— Продължаваме — казваш след няколко минути. — Трима души да минат за челен патрул. И оглеждайте внимателно за капани!\r\nДокато произнасяш това, от дълбочината на джунглата избликват три широки, светещи в червено лъчи, които се забиват право в скупчените около теб рейнджъри. Дефлекторите се справят и с новата опасност и битката пламва отново. Скоро пушекът от подпалените мокри дървета се смесва с гъстите изпарения и покрива всичко. В мъглата около вас се появяват малки пробягващи сенки и няколко болезнени викове показват успешните им нападения. Все пак и при такива условия рейнджърите ти надделяват в започналия ръкопашен бой и като оставят много убити, местните се оттеглят. Този път и ти си загубил двама от хората си.\r\nНападението със старите термични бластери, защото точно това се оказват новите оръжия, използвани срещу вас, обаче те е разтревожило силно. Не знаеш какъв ще бъде следващият удар, така че се налага да вземеш ново важно решение.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Идеята да плените ненавистния „ловец на роби“ се харесва много на племето и скоро бойният ви план е готов. Скрити в гъстите храсти и в предварително подготвените укрития, рейнджърите ти и голяма група ловци съставят основната ударна група. Целта й е да нападне и унищожи войниците на картела. Ти, заедно с една по-малка група туземци, оставате по колибите, за да създадете впечатление, че селото не подозира за нападението. Вие ще се опитате да завземете летящата машина веднага щом кацне. И накрая, останалите ловци, старейшините и част от жените на племето се разпръсват из джунглата като примамка.\r\nСлед малко от ниските облаци изплува огромна и тромава летяща машина. Съставена е от четири, закачени заедно, големи турбоплатформи и носеща в средата обширна клетка. Веднага щом стига над селото, от нея се посипват няколко десетки тежковъоръжени войници. С уплашени викове и писъци групата за примамка се разбягва из джунглата и скоро селото почти опустява. Няколко от войниците започват методично да претърсват колибите и първият, който влиза в твоята, те снабдява с униформата си, като преди да умре казва и кода за приземяване на „ловеца“.\r\nСкоро от гората започват да се появяват малки групи от маскирани рейнджъри, водещи „пленници“. Когато се събират при теб, даваш установения сигнал и „ловецът“ се спуска, за да ви прибере. Вече почти се е приземил, когато с уплашени викове от гората изскача група войници, преследвани от ловците и останалите рейнджъри. За чест на капитана може да се каже, че веднага оценява обстановката и с риск да взриви претоварените генератори, се опитва да се издигне. Тежката и тромава машина обаче не може да бъде спряна толкова лесно и ти с един скок се промъкваш през отворения люк. Няколко изстрела и ненавистният „ловец“ е пленен. Скоро и последният войник е заловен и обезвреден. Радостта на племето е огромна, но време за празненства няма.\r\nВ комплекса обезателно ще се разтревожат от липсата на машината и ще вдигнат тревога.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "След малко от ниските облаци изплува огромна и тромава летяща машина. Съставена е от четири, закачени заедно, големи турбоплатформи и носеща в средата обширна клетка. Веднага щом стига над селото, от нея се посипват няколко десетки тежковъоръжени войници.\r\nОчаквали отчаяна, но слаба съпротива от жителите на селото, нападателите са силно изненадани от атакувалите ги рейнджъри. Само за десетина секунди войниците на картела са притиснати и унищожени, въпреки численото си превъзходство.\r\nСега е твой ред и ти трябва да избереш с какво ще се опиташ да свалиш „ловеца“. И трите вида тежко оръжие са подходящи, но всеки има специфични възможности.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			this.playerStatus.Checksums[5] = -5;

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

			string expectedDescription = "За голямо разочарование на племето решаваш да действаш предпазливо и да се скриеш заедно с тях. Навътре в гората са издълбани специално за целта укрития, които побират всички ви. След няколко мъчителни часа постовите дават сигнал, че всичко се е разминало и вие отново се събирате в селото.\r\nВеднага от ниските облаци изплува огромна и тромава летяща машина. Съставена е от четири, закачени заедно, големи турбоплатформи и носеща в средата обширна клетка. Скрита досега, тя се спуска над селото и от нея се посипват няколко десетки тежковъоръжени войници.\r\nРазбира се, рейнджърите ти бързо надделяват над изненаданите от появата им войници, но огромният „ловец“ бавно започва да се издига и отдалечава. В битката си загубил един от рейнджърите.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "За голямо разочарование на племето решаваш да действаш предпазливо и да се скриеш заедно с тях. Навътре в гората са издълбани специално за целта укрития, които побират всички ви. След няколко мъчителни часа постовите дават сигнал, че всичко се е разминало и вие отново се събирате в селото.\r\nВеднага от ниските облаци изплува огромна и тромава летяща машина. Съставена е от четири, закачени заедно, големи турбоплатформи и носеща в средата обширна клетка. Скрита досега, тя се спуска над селото и от нея се посипват няколко десетки тежковъоръжени войници.\r\nРазбира се, рейнджърите ти бързо надделяват над изненаданите от появата им войници, но огромният „ловец“ бавно започва да се издига и отдалечава. В битката си загубил един от рейнджърите.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Включете всички активни устройства! — командваш решително. — Готови за директна атака!\r\nСамо за няколко секунди имате пълна информация за целия комплекс. В паметта на компютрите постъпват данни за разположението, размера и предназначението на постройките, броя на хората в района, разположението и типа на защитните системи.\r\n— ШЕСТДЕСЕТ СЕКУНДИ ПРЕДСТАРТОВА ГОТОВНОСТ — обявява компютърът. — ДВИГАТЕЛИТЕ ГОТОВИ ЗА СТАРТ. ЗАПОЧВАМ НАСОЧВАНЕ.\r\n— Спускаме се в района на космодрума им. Максимална скорост!\r\n— ПЕТДЕСЕТ СЕКУНДИ ПРЕДСТАРТОВА ГОТОВНОСТ. РАЙОНЪТ Е ЛОКАЛИЗИРАН.\r\n— Откриваме цел! Скоростна, с малки размери. Вероятно ракета. Удар след тридесет секунди!\r\n— Защитните екрани ще издържат ли?\r\n— Няма данни за типа на ракетата. Предлагам унищожаване.\r\n— ЧЕТИРИДЕСЕТ СЕКУНДИ ПРЕДСТАРТОВА ГОТОВНОСТ. НАСОЧВАНЕТО ИЗВЪРШЕНО.\r\n— Приготви бойните лазери! Максимален обхват! Огън!\r\nОслепителен блясък залива за няколко мига кораба ви. Зарядът на ракетата вероятно е бил ядрен, но защитният екран устоява.\r\n— Целта е поразена, командире! — докладва сред одобрителни възгласи кибернетикът, заел мястото на бордовия стрелец.\r\n— КРАЙ НА ПРЕДСТАРТОВАТА ГОТОВНОСТ — съобщава компютърът. — ЗАПОЧВАМ СПУСКАНЕ. СТАРТ!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "С мъка сдържаш желанието си да ги избиеш и като оставяш внимателно оръжието си, казваш отчетливо:\r\n— Ние сме приятели! Идваме с мир! — и после тихо добавяш за хората си: — Свалете оръжията, но бъдете нащрек! — Надяваш се местните да разберат по-скоро жеста, а не думите ти.\r\n— Ти не приятел! Ти от злите! — с омраза произнася един от ловците. С учудване разбираш, че той говори на стария универсален език на империята. Леко скърцане и трите стреломета отново са насочени към теб. Видът на заплашващите ви със стрели дребосъци изведнъж ти се струва толкова смешен, че не издържаш и като избухваш в смях, сядаш на калната земя.\r\n— Не съм от злите — едва успяваш да кажеш ти. — Аз съм приятел! Ето виж — и като побутваш с крак оръжието, махаш на хората си да направят същото.\r\nВсичко това идва прекалено много за бедните туземци и те също пристъпват наблизо.\r\n— Кой вие? — пита вече по-дружелюбно водачът им. — Вие убили захуса и спасили нас. Защо прави?\r\n— Какво е „захуса“? — питаш, като се опитваш да спечелиш време ти.\r\n— Този е захуса — посочва мъртвия динозавър ловецът. — Защо спасили? Искаш роби? Не…? Ние не каже къде селото! — добавя твърдо той.\r\n— Не ни трябва твоето село — отговаряш му вече сериозно. — Трябва ни водач до едно място с хора като нас.\r\n— Ти ходи при злите! — скача пак туземецът. — Защо?\r\n— За да ги унищожа! — вече започваш да се ядосваш и ти. — Ако не вярваш, ела да видиш кораба ми — хрумва ти изведнъж спасителната идея.\r\n— Аз дойде на кораб — заявява след кратко колебание дребният ловец. — Вие чака тук и ходи предупреди старейшини — нарежда той на останалите.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Недоволен от развитието на събитията и очертаващите се неприятности с туземците, се прибираш мрачен на кораба и много след падането на нощта пришпорваш хората си да довършат подготовката за похода.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Качвайте се всички на машината! — нареждаш на рейнджърите. — Стига сме се мотали! Да си свършим работата и да заминаваме!\r\nС рев и трясък на повалени дървета тежката машина си пробива път през гъстата, залята с вода и кал джунгла. На места дърветата и храсталакът са така здраво преплетени, че се налага да си пробивате път с бластерите. Колкото повече се приближавате до оградата, толкова повече се разрежда и заблатява джунглата. На около километър от защитения периметър на комплекса тежко натовареният транспортьор пропада в дълбока, пълна с рядка кал и замаскирана с воден слой, яма. Бързо потъва, като отнася всички ви и така слага край на мисията ти.\r\nСлучва се и „СТАР РЕЙНДЖЪРС“ да загубят, особено ако са водени от неопитен и прибързан командир.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Вашето разузнаване също пропада и вече е време да решиш къде ще се приземите.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Смяташ да не рискуваш с бързо измъкване, а да си запазиш енергията на бластера за решителния момент. Следователно трябва да се прикриеш, доколкото е възможно по-добре, за да принудиш робота да се приближи.\r\nКакво ще направиш?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Все пак ще трябва да проявиш повече активност и да опиташ някой от следните варианти:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Минават няколко напрегнати, изпълнени с очакване минути. Вече си готов да взривиш енергогенератора и да се примириш със загубата на научната документация, когато отново светва сигнал за повикване.\r\n— Приемаме условията ви — съкрушено произнася началникът на охраната. — Дайте нарежданията си.\r\n— Аха, вразумихте се значи! — казваш доволно. — Слушай внимателно!\r\nПърво: деактивирайте всички роботи!\r\nВторо: съберете се всички на една от пистите на космодрума! Ако имате кораб, който да ви побере, може да се махате, но не преди да ви кажа!\r\nТрето: оставям хора в енергоцентралата. Не си правете никакви хитри сметки!\r\nТова е.\r\n— Ще бъде изпълнено. Имаме транспортен кораб, с който да отлетим.\r\nСамо след три часа всичко е готово: данните от лабораториите са прибрани; корабът на останалите, живи наемници е отлетял; контролната система на реактора е минирана. Далеч от дълбочината на джунглата изчакваш взривяването и когато огромният гъбовиден облак на ядрената експлозия, унищожила комплекса, спира да расте, можеш да отбележиш успешния край на мисията си.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Минават няколко напрегнати минути, изпълнени с очакване, когато раздвижването на войниците ти показва, че командирът на охраната е решил да рискува.\r\n— Внимание! Взривявам реактора! — викаш за последен път в микрофоните на комуникаторите.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— МАНЕВРАТА ИЗПЪЛНЕНА БЕЗУСПЕШНО — обажда се отново след секунда автоматът. — УДАР СЛЕД ТРИ СЕКУНДИ. СТАРТ НА АВАРИЙНИТЕ КАТАПУЛТИ. ВРЕМЕ ЗА ПЪЛНА ЕВАКУАЦИЯ ПЕТ СЕКУНДИ.\r\nСилен тласък, придружен със звънко гърмене, те притиска към креслото. Панелът над теб е отхвърлен и катапултът се задейства. Около теб се понасят креслата на останалите от групата, когато като насън виждаш тънко черно тяло да се забива право в останките на разрушената вече совалка.\r\n— РАКЕТА В ЦЕЛТА — чуваш в шлема гласът на бордовия компютър. — ЗАЩИТАТА Е ПРЕОДОЛЯНА…\r\nОт израненото тяло на совалката бликва мощна огнена вълна, която ви застига и разпилява като семена при бурен вятър. Ужасна горещина и жестоко разтърсване те потапят в непрогледен мрак и измъченото ти съзнание просто се изключва.\r\nСъвземаш се мъчително и дълго не можеш да си спомниш къде си и какво се е случило. Изправяш се бавно и като се мръщиш от болки по цялото тяло, тръгваш да търсиш оцелелите от хората ти.\r\nДо вечерта всички са открити, оцелели са само трима рейнджъри и кибернетикът. Сержантът и единият от пилотите са тежко пострадали и практически неподвижни. Всички останали са мъртви; обгорените им, силно изранени тела са подредени в една естествена яма и затрупани с камъни и глина. Останките на совалката са разпръснати на голяма площ, а джунглата около вас изглежда като след опустошителен огнен ураган.\r\nПод топлите струи на проливния дъжд провеждате кратко, но напрегнато съвещание. Всички сте изнервени от провала и не можете да се споразумеете как да продължите.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Значи така, лейтенант, не сте напреднали особено — поклаща глава генералът. — Мислехме да ви възложим първата задача, но явно ще трябва още да тренирате. Е, това е, свободен сте!\r\nЗасрамен, излизаш и без да погледнеш никого, се прибираш в стаята си. Разбира се, за всичко е виновен последният ти неуспех.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Само толкова ли? — генералът, изглежда, е доста разочарован. — Мислех да ти възложа първата ти самостоятелна задача. Но сега, не знам. Допустимият минимум е 20, а няма друг свободен командир. Как смяташ лейтенант, ще се справиш ли?\r\nТрябва бързо да вземеш решение.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = " — Отлично, лейтенант! — старият командващ изглежда много доволен. — Ще поемете първата си самостоятелна задача.\r\nКато ти подава една дискета, генералът те поглежда изпитателно и ненадейно започва истински изпит.\r\n— Знаете ли какво е това „Ситайк-дрог“?\r\n— Това е наркотик, от който се получава така наречената „мотивационна зависимост“. Може да се произвежда само на планетата Ситай, оттам и името му. Получен е преди приблизително три века от имперската изследователска станция на Ситай. Местонахождението на планетата е неизвестно. „Ситайк-дрог“ се среща много рядко, вероятно това са стари запаси.\r\n— Така, от известно време „Ситайк-дрог“ се появи отново. Не са стари запаси! Този е ново производство. Не толкова силен и чист като имперския, но достатъчно опасен. Заловихме няколко явни „пробни екземпляра“; разузнаването предполага, че се готви някаква голяма операция. Успяхме и да намерим системата Ситай. На дискетата са данните, с които разполагаме. Успех, лейтенанте!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = " — Отлично, лейтенант! — старият командващ изглежда много доволен. — Ще поемете първата си самостоятелна задача.\r\nКато ти подава една дискета, генералът те поглежда изпитателно и ненадейно започва истински изпит.\r\n— Знаете ли какво е това „Ситайк-дрог“?\r\n— Това е наркотик, от който се получава така наречената „мотивационна зависимост“. Може да се произвежда само на планетата Ситай, оттам и името му. Получен е преди приблизително три века от имперската изследователска станция на Ситай. Местонахождението на планетата е неизвестно. „Ситайк-дрог“ се среща много рядко, вероятно това са стари запаси.\r\n— Така, от известно време „Ситайк-дрог“ се появи отново. Не са стари запаси! Този е ново производство. Не толкова силен и чист като имперския, но достатъчно опасен. Заловихме няколко явни „пробни екземпляра“; разузнаването предполага, че се готви някаква голяма операция. Успяхме и да намерим системата Ситай. На дискетата са данните, с които разполагаме. Успех, лейтенанте!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = " — Отлично, лейтенант! — старият командващ изглежда много доволен. — Ще поемете първата си самостоятелна задача.\r\nКато ти подава една дискета, генералът те поглежда изпитателно и ненадейно започва истински изпит.\r\n— Знаете ли какво е това „Ситайк-дрог“?\r\n— Това е наркотик, от който се получава така наречената „мотивационна зависимост“. Може да се произвежда само на планетата Ситай, оттам и името му. Получен е преди приблизително три века от имперската изследователска станция на Ситай. Местонахождението на планетата е неизвестно. „Ситайк-дрог“ се среща много рядко, вероятно това са стари запаси.\r\n— Така, от известно време „Ситайк-дрог“ се появи отново. Не са стари запаси! Този е ново производство. Не толкова силен и чист като имперския, но достатъчно опасен. Заловихме няколко явни „пробни екземпляра“; разузнаването предполага, че се готви някаква голяма операция. Успяхме и да намерим системата Ситай. На дискетата са данните, с които разполагаме. Успех, лейтенанте!";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Следват няколко дни на тежка борба с подгизналата от непрестанните валежи джунгла. Постепенно придобитият опит ви помага да се справяте все по-успешно с прехода. Според картите ви до комплекса остават само около пет дни път, разбира се, ако успеете да спазвате досегашното темпо, и ти вече си започнал да съставяш плана на нападението, когато изниква поредният, изискващ бързо и точно решение проблем.\r\nВ момента, когато водещият групата рейнджър разсича изпречилата се на пътя ви плетеница от тънки лиани, със силно свистене от върховете на дърветата се спуска тежка дървена решетка, снабдена със зъби от подострени колове. Разбира се, толкова примитивен капан не може да изненада боец на „СТАР РЕЙНДЖЪРС“ и войникът успява да отскочи невредим. Явно капанът е поставен от ловците на местните племена.\r\n— Внимание! Прикрийте се! — командваш бързо. — Останете по местата си и се огледайте за други клопки! — и веднага сам се снишаваш зад кривото стебло на обрасло с папратовидни храсти дърво.\r\nСамо за няколко мига гората около теб сякаш опустява. Прикрити в гъстите листа, хората ти сякаш изчезват, но ти си сигурен, че всички са нащрек. Все пак направилите засадата ловци се ориентират по-добре и по-бързо от вас в джунглата. Само на два метра от теб се появява дребна, странно обезобразена фигура и изстрелва насреща ти къса стрела. Разстоянието е малко и всичко става толкова бързо и безшумно, че не успяваш да реагираш. За твое, а и за негово учудване, насочената право в гърдите ти стрела, вместо да те удари, само нелепо се премята и пада в краката ти. И двамата сте изненадани, но ти се съвземаш по-бързо и имаш време за отговор.\r\nКакво ще направиш?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "След около тридесет минути сте на повърхността. Совалката е стъпила стабилно на малко островче от сравнително твърда земя. Отличното спускане е подобрило настроението на цялата група и сега всички са се събрали пред екраните, показващи чуждия свят. Пейзажът навън изглежда като кошмар, създаден от болен мозък. Криви дървета и зловещи, виещи се растения са преплетени в почти непроходим гъсталак. Всичко е обвито в тежки изпарения и разкъсани парцали гъста мъгла. Под дърветата цари сив сумрак, през който се движат неясни сенки. Растенията имат странен посърнал цвят, преливащ от белезникаво зелено до мръсно сиво.\r\n— Ама че местенце! — обажда се някой. Хората ти изглеждат разтревожени от вида на джунглата, но, разбира се, никой не е уплашен.\r\n— Хайде, не е по-страшно от полигоните на Джако — засмива се изведнъж сержантът и изведнъж корабът се оглася от смях и истории от тренировъчните полигони, придружени с шеги по адрес на старшия инструктор.\r\nОставяш хората да се отпуснат и като ги отпращаш по местата им, свикваш импровизирано съвещание. Решаваш да оставиш в совалката двамата пилоти и един рейнджър за охрана. Останалите ще се придвижите максимално бързо до производствения комплекс и там ще съставите план за действие.\r\n— Потегляме веднага след разсъмване! — обявяваш накрая. — Ако това има значение тук — добавяш, като оглеждаш със съмнение мрачния пейзаж около кораба.\r\n— Хайде, знаете си задълженията! Сержант, изпратете патрул да огледа наоколо!\r\nСкоро около притихналата совалка кипи напрегната работа. Преди да тръгнете е необходимо да се подсигури кораба, като се укрепи почвата около него и се прикрие със защитна мрежа.\r\n— Как е положението? — питаш кибернетика, който по малкото снимки, направени при спускането, и данните от локатора се опитва да състави карта.\r\n— Лошо. Навсякъде джунгли и блата. Комплексът е на почти седемдесет километра оттук. Въздухът поне е добър и няма да мръзнем, средната температура е около двадесет и пет градуса, със съвсем малки колебания.\r\n— Командире — прозвучава гласът на сержанта. — Патрулът докладва за някакви големи животни. Искат разрешение да ги проследят.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Ще се справя, сър — отговаряш бързо. — Днешният ми неуспех е чиста случайност.\r\n— Добре, добре, нека да опитаме — съгласява се генералът. — Все пак трябва да преминеш още един тест. Сядай на компютъра и набери код LT12.324/q.\r\nИзпълняваш заповедта и на дисплея се появява надпис:\r\nЛОГИЧЕСКИ ТЕСТ СЪС СРЕДНА СЛОЖНОСТ — ЧЕТИРИСТЕПЕНЕН.\r\nМиг след като успяваш да го прочетеш, компютърът изписва:\r\nЗАДАЧА: ДА СЕ РАЗПОЗНАЕ И ОБЕЗВРЕДИ ТЕРОРИСТ, ДЪРЖАЩ ЗАЛОЖНИК.\r\nМЕСТОПОЛОЖЕНИЕ: ПЯСЪЧНА ПУСТИНЯ.\r\nУСЛОВИЯ: ВЯТЪР СЪС СКОРОСТ 65 КМ/Ч, СИЛНА ЗАПРАШЕНОСТ.\r\nИЗБЕРЕТЕ ПОДХОДЯЩО ОРЪЖИЕ:\r\nТрябва да избереш това оръжие, което смяташ за най-подходящо.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Следват няколко дни на тежка борба с подгизналата от непрестанните валежи джунгла. Постепенно придобитият опит ви помага да се справяте все по-успешно с прехода. Според картите ви до комплекса остават само около пет дни път, разбира се, ако успеете да спазвате досегашното темпо, и ти вече си започнал да съставяш плана на нападението, когато изниква поредният, изискващ бързо и точно решение проблем.\r\nВ момента, когато водещият групата рейнджър разсича изпречилата се на пътя ви плетеница от тънки лиани, със силно свистене от върховете на дърветата се спуска тежка дървена решетка, снабдена със зъби от подострени колове. Разбира се, толкова примитивен капан не може да изненада боец на „СТАР РЕЙНДЖЪРС“ и войникът успява да отскочи невредим. Явно капанът е поставен от ловците на местните племена.\r\n— Внимание! Прикрийте се! — командваш бързо. — Останете по местата си и се огледайте за други клопки! — и веднага сам се снишаваш зад кривото стебло на обрасло с папратовидни храсти дърво.\r\nСамо за няколко мига гората около теб сякаш опустява. Прикрити в гъстите листа, хората ти сякаш изчезват, но ти си сигурен, че всички са нащрек. Все пак направилите засадата ловци се ориентират по-добре и по-бързо от вас в джунглата. Само на два метра от теб се появява дребна, странно обезобразена фигура и изстрелва насреща ти къса стрела. Разстоянието е малко и всичко става толкова бързо и безшумно, че не успяваш да реагираш. За твое, а и за негово учудване, насочената право в гърдите ти стрела, вместо да те удари, само нелепо се премята и пада в краката ти. И двамата сте изненадани, но ти се съвземаш по-бързо и имаш време за отговор.\r\nКакво ще направиш?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Тежкият няколкодневен преход през кошмарната, заливана от почти непрестанен дъжд джунгла ви дава отлична възможност взаимно да се опознаете и прецените възможностите си. Външният вид на новите ти съюзници е силно обезобразен от продължилата много поколения генетична мутация. Телата им са дребни и слаби, с тесни, сплескани странично гърди. Краката им са дълги, с много широки стъпала и свързани с ципа пръсти. Гъвкавите, сръчни пръсти на още по-дългите им ръце също са частично свързани с по-малка ципа. Най-странно изглеждат обаче главите им, продълговати и със силно изтеглен назад тил и две големи изпъкнали очи, разположени така, че могат да виждат почти на всички посоки, без да се обръщат. Устата са с тесни, стиснати устни. Носът е почти незабележим, сведен до малка издутина с две коси цепки, затварящи се с ципа. Ушите са големи, остри и много подвижни. Въобще местните приличат на странни, странично сплескани жаби, но както се оказва, идеално приспособени за условията на свят, покрит с блата и наводнени джунгли.\r\nНо, разбира се, не видът им е това, което привлича вниманието ти; галактиката е пълна и с много по-странни същества. Най-силно си поразен от оръжията им. На пръв поглед приличат на обикновени примитивни арбалети, но вместо с обичайния лък стрелите се изстрелват от полето на силен електромагнитен генератор. Самите стрели са къси и дебели, с вградена в тях мощна кондензаторна батерия. Ударната сила на оръжието е сравнително малка, но в поразяващите възможности на електрическата стрела се убеждаваш още първия ден, когато ловците повалят само с два изстрела голямо колкото слон и бронирано с дебели костни плочки животно.\r\nНай-невероятното обаче е, че дългата широка тръба, снабдена с удобна ръкохватка, се оказва стар термичен бластер от времето на империята. Загадка остава как са успели да го запазят изправен няколко века. Друго, не по-малко загадъчно обстоятелство е как успяват да намират енергия за стрелите и особено за бластера.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ВЕРЕН ИЗВОД.\r\nКОЙ ОТ ТЯХ Е ТЕРОРИСТЪТ:";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "НЕВЕРЕН ИЗВОД.\r\nКРАЙ НА ТЕСТА.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Да се махаме по-бързо! — казваш и като ставаш, поемаш носилката. — Ти върви напред! — посочваш един от рейнджърите.\r\nОтново поемате през заливаната от проливния дъжд джунгла. Независимо от непрестанния валеж, температурата на въздуха е висока и от многобройните локви се вдигат тежки изпарения, в които слабата светлина на фенерчетата потъва като в памук. Малко след като тръгне, водещият рейнджър заобикаля една по-висока от обикновено купчина рохкава пръст и веднага затъва в рядката кал на покрито с воден слой блато. Само за няколко секунди тинята го сковава и поглъща последния му отчаян зов за помощ.\r\n— Спри веднага! Върни се! — викаш на спусналия се да го спасява кибернетик. — Не можеш вече да му помогнеш.\r\nТой се опитва да те послуша, но в последния момент се спъва и се просва с цял ръст право в блатото.\r\n— Не мърдай! Сега ще те измъкнем! — спираш напразните му усилия да се изправи. — Намерете някакъв клон! Бързо!\r\n— Лейтенант, погледни! Тук, малко по-наляво! — вика уплашено някой и веднага ярките мълнии на бластер озаряват околността.\r\nЗеленикавата светлина на лазерните импулси разкрива пред вас ужасяваща гледка. От дълбините на блатото бавно изплува отвратителна пихтиеста маса и без да обръща внимание на потъващите в нея лъчи, повлича с многобройните си пипала бясно съпротивляващия се кибернетик. В теб е единствената запазила се плазмена граната. Като закриваш с ръка очите си, освобождаваш предпазителя и я хвърляш върху грамадната амебоподобна твар. Ослепителен блясък… и с приглушен тътен гранатата разхвърля наоколо парцали отвратително миришеща плът.\r\nОт близката експлозия загиват и двамата. Ранени, зашеметени и заслепени, се събирате и вече сте готови да побегнете, когато с остро свистене няколко малки ракети се забиват в земята около вас и силни експлозии унищожават теб и останките от групата ти.\r\n— Край, избихме ги — обявява командирът на открилите ви по изстрелите преследвачи. — Прибираме се в базата.\r\nИ така, мисията ти се провали напълно.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "— Прикрийте се! Веднага! — командваш бързо и като подслонявате под гъстите храсти ранените, се притаявате, доколкото ви позволяват условията.\r\nА в това време на претърсващата гората турбоплатформа се разгорява кратък спор. Биолокаторът ви е засякъл за момент, но в пълната с влажни изпарения джунгла термодатчикът не може да ви открие. Наблюдателят настоява, че е открил хора, а командирът се съмнява, че е било някакво животно. Накрая се взема компромисно, но фатално за вас решение. Към предполагаемата цел са изстреляни няколко малки ракети, които за голямо съжаление попадат право в целта и слагат край на мисията ти.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Разбира се, както си и предполагал, отговорът на всичко се крие в селото им. Колибите им се оказват малки полуземлянки, удивително напомнящи купчини пръст и освен съвършената си маскировка, не притежават нищо интересно. Интересното и дори смайващо нещо е един почти потънал в земята и обрасъл с лиани, но напълно здрав имперски транспортен кораб от лек клас. В неговата просторна и сравнително суха командна кабина ви посрещат петимата старейшини на племето.\r\nИсторията на племето, която научавате от тях, е разказ за дългата и безнадеждна борба на изоставените колонисти — първо срещу враждебния и опасен свят, а след това и срещу все по-силното израждане и мутиране на хората. След няколко поколения борбата е загубена и колонията загива. Оцелелите се пръскат из джунглите и се обособяват в няколко племена, живеещи на големи разстояния едно от друго. Тукашното племе се състои от потомци на групата, която последна се оттегля, след като поддържащите автомати престават да ги разпознават и да им се подчиняват и започват да консервират лабораториите, енергоцентралата и всички по-важни постройки.\r\nНякъде по това време идва и последният кораб — автоматичен транспортьор, който поради повреда пада в джунглата. Товарът се оказва истинско богатство — купища резервни части и инструменти, предназначени за някаква военна база, а работещият с бавни неутрони термоядрен енергогенератор — истински късмет.\r\nПреди няколко години на планетата пристигат сегашните й завоеватели и като разконсервират и разширяват производствения комплекс, започват лов на местни жители, които принуждават да работят като роби.\r\nИсторията е дълга и тъжна, но няма отношение към задачата ти, така че накратко, старейшините ти предлагат племето да участва в нападение срещу комплекса.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "Само след десетина минути, стегнат в нова униформа, заставаш пред кабинета на командващия. Приемат те веднага. В кабинета е само възрастният генерал.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "И наистина, далеч пред вас се надига силен тътнещ рев, който постепенно преминава в пронизващ до мозъка на костите писък. Достигнал до най-високата си точка, той изведнъж пресеква, но веднага е последван от поредица кънтящи експлозии и далечни викове. Над целия този шум постепенно се извисява и прониква навсякъде воят на аварийните сирени и един безстрастен механичен глас гръмко обявява:\r\n— НАПАДЕНИЕ СРЕЩУ СЕКТОРА НА РОБИТЕ! ПРОБИТА Е ЗАЩИТНАТА СИСТЕМА! ВСИЧКИ БОЙНИ ГРУПИ ДА СЕ НАСОЧАТ КЪМ РАЙОНА НА ПРОБИВА! ПАТРУЛНИТЕ КОЛИ ДА ОСТАНАТ В СЕКТОРИТЕ СИ! ВСИЧКИ ОБЕКТИ ОТ КЛАС „А“, „В“ И „С“ ДА БЪДАТ БЛОКИРАНИ!\r\n— По дяволите! — викаш ядосан. — Как ще се справим с този? — посочваш застаналия в бойна готовност патрулен робот.\r\n— НАПАДЕНИЕ СРЕЩУ СЕКТОРА НА РОБИТЕ! ПРОБИТА Е ЗАЩИТНАТА СИСТЕМА! ВСИЧКИ БОЙНИ ГРУПИ ДА СЕ НАСОЧАТ КЪМ РАЙОНА НА ПРОБИВА! ПАТРУЛНИТЕ КОЛИ ДА ОСТАНАТ В СЕКТОРИТЕ СИ! ВСИЧКИ ОБЕКТИ ОТ КЛАС „А“, „В“ И „С“ ДА БЪДАТ БЛОКИРАНИ! — продължава да крещи защитната система.\r\n— Лейтенант, нека да го взривим с мината — предлага кибернетикът. — Положително ще мога да се справя със системата на вратата.\r\n— Как ще го доближиш? — отговаряш ядосано. — Нали виждаш, че е готов да застреля всичко, което види.\r\n— Вярно, но това е патрулен робот от полицейски клас. Преди да стреля, дава десетсекундна възможност да се предадеш. Едва ли са го препрограмирали.\r\n— Значи един от нас трябва да се жертва, а и мината ще загубим — не се съгласяваш ти. — Не можем ли да го измамим някак?\r\n— Няма проблеми, командире — спокойно заявява рейнджърът. — Вие с кибернетика ще взривите централата, а аз ще се справя с робота.\r\n— Аз мога примами далеч — обажда се мълчащият досега ловец. — Отдавна тези ловили нас и ние научили бяга от машина.\r\nКое предложение да приемеш?";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "НЕВЕРЕН ИЗВОД.\r\nКРАЙ НА ТЕСТА.";

			string factDescriptions = game.CurrentEpizodeModel.Decription;

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

			string expectedDescription = "ВЕРЕН ИЗВОД.\r\nКРАЙ НА ТЕСТА.";

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