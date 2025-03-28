namespace Utilities;

public class AutoPeanManager : IActionListener, IChatable
{
	public static AutoPeanManager _Instance;

	private static bool isAutoRequestPean;

	private static long lastTimeRequestedPean;

	private static bool isAutoDonatePean;

	private static bool isAutoHarvestPean;

	private static int minimumHPPercent;

	private static int minimumMPPercent;

	private static int minimumHP;

	private static int minimumMP;

	private static bool isSaveData;

	private static string[] inputHPPercent;

	private static string[] inputMPPercent;

	private static string[] inputHP;

	private static string[] inputMP;

	static AutoPeanManager()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		inputHPPercent = new string[2] { "Nhập %HP Pean", "%HP" };
		inputMPPercent = new string[2] { "Nhập %MP Pean", "%MP" };
		inputHP = new string[2] { "Nhập HP Pean", "HP" };
		inputMP = new string[2] { "Nhập MP Pean", "MP" };
		M2095();
	}

	public static AutoPeanManager M2092()
	{
		if (_Instance == null)
		{
			_Instance = new AutoPeanManager();
		}
		return _Instance;
	}

	public static void M2093()
	{
		if (isAutoRequestPean)
		{
			M2098();
		}
		if (isAutoDonatePean && GameCanvas.gameTick % 20 == 0)
		{
			M2099();
		}
		if (isAutoHarvestPean)
		{
			M2100();
		}
		if (!Char.M113().meDead)
		{
			M2101();
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (ChatTextField.M279().tfChat.M1924() != null && !ChatTextField.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (ChatTextField.M279().strChat.Equals(inputHPPercent[0]))
			{
				try
				{
					int num = int.Parse(ChatTextField.M279().tfChat.M1924());
					if (num >= 100)
					{
						num = 99;
					}
					if (num <= 0)
					{
						num = 1;
					}
					minimumHPPercent = num;
					GameScr.info1.M762("Auto pean khi HP dưới: " + num + "%", 0);
					if (isSaveData)
					{
						Rms.M1543("AutoPeanPercentHP", minimumHPPercent);
					}
				}
				catch
				{
					GameScr.info1.M762("%HP không hợp lệ, vui lòng nhập lại", 0);
				}
				M2097();
			}
			else if (ChatTextField.M279().strChat.Equals(inputMPPercent[0]))
			{
				try
				{
					int num2 = int.Parse(ChatTextField.M279().tfChat.M1924());
					if (num2 >= 100)
					{
						num2 = 99;
					}
					if (num2 <= 0)
					{
						num2 = 1;
					}
					minimumMPPercent = num2;
					GameScr.info1.M762("Auto pean khi MP dưới: " + num2 + "%", 0);
					if (isSaveData)
					{
						Rms.M1543("AutoPeanPercentMP", minimumMPPercent);
					}
				}
				catch
				{
					GameScr.info1.M762("%MP không hợp lệ, vui lòng nhập lại", 0);
				}
				M2097();
			}
			else if (ChatTextField.M279().strChat.Equals(inputHP[0]))
			{
				try
				{
					int num3 = (minimumHP = int.Parse(ChatTextField.M279().tfChat.M1924()));
					if (isSaveData)
					{
						Rms.M1538("AutoPeanHP", minimumHP.ToString());
					}
					GameScr.info1.M762("Auto pean khi HP dưới: " + NinjaUtil.M1192(num3) + "HP", 0);
				}
				catch
				{
					GameScr.info1.M762("HP không hợp lệ, vui lòng nhập lại", 0);
				}
				M2097();
			}
			else
			{
				if (!ChatTextField.M279().strChat.Equals(inputMP[0]))
				{
					return;
				}
				try
				{
					int num4 = (minimumMP = int.Parse(ChatTextField.M279().tfChat.M1924()));
					if (isSaveData)
					{
						Rms.M1538("AutoPeanMP", minimumMP.ToString());
					}
					GameScr.info1.M762("Auto pean khi MP dưới: " + NinjaUtil.M1192(num4) + "MP", 0);
				}
				catch
				{
					GameScr.info1.M762("MP không hợp lệ, vui lòng nhập lại", 0);
				}
				M2097();
			}
		}
		else
		{
			ChatTextField.M279().isShow = false;
			M2097();
		}
	}

	public void onCancelChat()
	{
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 1:
			isAutoRequestPean = !isAutoRequestPean;
			GameScr.info1.M762("Xin Đậu\n" + (isAutoRequestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isSaveData)
			{
				Rms.M1543("AutoPeanIsAutoRequestPean", isAutoRequestPean ? 1 : 0);
			}
			break;
		case 2:
			isAutoDonatePean = !isAutoDonatePean;
			GameScr.info1.M762("Cho Đậu\n" + (isAutoDonatePean ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isSaveData)
			{
				Rms.M1543("AutoPeanIsAutoSendPean", isAutoDonatePean ? 1 : 0);
			}
			break;
		case 3:
			isAutoHarvestPean = !isAutoHarvestPean;
			GameScr.info1.M762("Thu Đậu\n" + (isAutoHarvestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isSaveData)
			{
				Rms.M1543("AutoPeanIsAutoHarvestPean", isAutoHarvestPean ? 1 : 0);
			}
			break;
		case 4:
			if (minimumHP != 0)
			{
				minimumHP = 0;
				GameScr.info1.M762("Auto đậu: 0HP", 0);
				if (isSaveData)
				{
					Rms.M1538("AutoPeanHP", minimumHP.ToString());
				}
			}
			else if (minimumHP == 0)
			{
				ChatTextField.M279().strChat = inputHP[0];
				ChatTextField.M279().tfChat.name = inputHP[1];
				ChatTextField.M279().M282(M2092(), string.Empty);
			}
			break;
		case 5:
			if (minimumHPPercent != 0)
			{
				minimumHPPercent = 0;
				GameScr.info1.M762("Auto đậu: 0% HP", 0);
				if (isSaveData)
				{
					Rms.M1543("AutoPeanPercentHP", minimumHPPercent);
				}
			}
			else if (minimumHPPercent == 0)
			{
				ChatTextField.M279().strChat = inputHPPercent[0];
				ChatTextField.M279().tfChat.name = inputHPPercent[1];
				ChatTextField.M279().M282(M2092(), string.Empty);
			}
			break;
		case 6:
			if (minimumMP != 0)
			{
				minimumMP = 0;
				GameScr.info1.M762("Auto đậu: 0MP", 0);
				if (isSaveData)
				{
					Rms.M1538("AutoPeanMP", minimumMP.ToString());
				}
			}
			else if (minimumMP == 0)
			{
				ChatTextField.M279().strChat = inputMP[0];
				ChatTextField.M279().tfChat.name = inputMP[1];
				ChatTextField.M279().M282(M2092(), string.Empty);
			}
			break;
		case 7:
			if (minimumMPPercent != 0)
			{
				minimumMPPercent = 0;
				GameScr.info1.M762("Auto đậu: 0% MP", 0);
				if (isSaveData)
				{
					Rms.M1543("AutoPeanPercentMP", minimumMPPercent);
				}
			}
			else if (minimumMPPercent == 0)
			{
				ChatTextField.M279().strChat = inputMPPercent[0];
				ChatTextField.M279().tfChat.name = inputMPPercent[1];
				ChatTextField.M279().M282(M2092(), string.Empty);
			}
			break;
		case 8:
			isSaveData = !isSaveData;
			GameScr.info1.M762("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			Rms.M1543("AutoPeanIsSaveRms", isSaveData ? 1 : 0);
			if (isSaveData)
			{
				M2096();
			}
			break;
		}
	}

	public static void M2094()
	{
		M2095();
		MyVector t = new MyVector();
		t.M1111(new Command("Xin Đậu\n" + (isAutoRequestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), M2092(), 1, null));
		t.M1111(new Command("Cho Đậu\n" + (isAutoDonatePean ? "[STATUS: ON]" : "[STATUS: OFF]"), M2092(), 2, null));
		t.M1111(new Command("Thu Đậu\n" + (isAutoHarvestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), M2092(), 3, null));
		t.M1111(new Command("Ăn Đậu Khi HP Dưới: " + NinjaUtil.M1192(minimumHP) + "HP", M2092(), 4, null));
		t.M1111(new Command("Ăn Đậu Khi HP Dưới: " + minimumHPPercent + "%", M2092(), 5, null));
		t.M1111(new Command("Ăn Đậu Khi MP Dưới: " + NinjaUtil.M1192(minimumMP) + "MP", M2092(), 6, null));
		t.M1111(new Command("Ăn Đậu Khi MP Dưới: " + minimumMPPercent + "%", M2092(), 7, null));
		t.M1111(new Command("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), M2092(), 8, null));
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2095()
	{
		isSaveData = Rms.M1542("AutoPeanIsSaveRms") == 1;
		if (isSaveData)
		{
			isAutoRequestPean = Rms.M1542("AutoPeanIsAutoRequestPean") == 1;
			isAutoDonatePean = Rms.M1542("AutoPeanIsAutoSendPean") == 1;
			isAutoHarvestPean = Rms.M1542("AutoPeanIsAutoHarvestPean") == 1;
			if (Rms.M1542("AutoPeanPercentHP") == -1)
			{
				minimumHPPercent = 0;
			}
			else
			{
				minimumHPPercent = Rms.M1542("AutoPeanPercentHP");
			}
			if (Rms.M1542("AutoPeanPercentMP") == -1)
			{
				minimumMPPercent = 0;
			}
			else
			{
				minimumMPPercent = Rms.M1542("AutoPeanPercentMP");
			}
			if (Rms.M1536("AutoPeanHP") == null)
			{
				minimumHP = 0;
			}
			else
			{
				minimumHP = int.Parse(Rms.M1536("AutoPeanHP"));
			}
			if (Rms.M1536("AutoPeanMP") == null)
			{
				minimumMP = 0;
			}
			else
			{
				minimumMP = int.Parse(Rms.M1536("AutoPeanMP"));
			}
		}
	}

	private static void M2096()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Rms.M1543("AutoPeanIsAutoRequestPean", isAutoRequestPean ? 1 : 0);
		Rms.M1543("AutoPeanIsAutoSendPean", isAutoDonatePean ? 1 : 0);
		Rms.M1543("AutoPeanIsAutoHarvestPean", isAutoHarvestPean ? 1 : 0);
		Rms.M1538("AutoPeanHP", minimumHP.ToString());
		Rms.M1543("AutoPeanPercentHP", minimumHPPercent);
		Rms.M1538("AutoPeanMP", minimumMP.ToString());
		Rms.M1543("AutoPeanPercentMP", minimumMPPercent);
	}

	private static void M2097()
	{
		ChatTextField.M279().strChat = "Chat";
		ChatTextField.M279().tfChat.name = "chat";
		ChatTextField.M279().isShow = false;
	}

	private static void M2098()
	{
		if (mSystem.M1054() - lastTimeRequestedPean >= 301000L)
		{
			lastTimeRequestedPean = mSystem.M1054();
			Service.M1594().M1614(1, "", -1);
		}
	}

	private static void M2099()
	{
		for (int i = 0; i < ClanMessage.vMessage.M1113(); i++)
		{
			ClanMessage t = (ClanMessage)ClanMessage.vMessage.M1114(i);
			if (t.maxCap != 0 && t.playerName != Char.M113().cName && t.recieve != t.maxCap)
			{
				Service.M1594().M1613(t.id);
				break;
			}
		}
	}

	private static void M2100()
	{
		if (TileMap.mapID != 21 && TileMap.mapID != 22 && TileMap.mapID != 23)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < Char.M113().arrItemBox.Length; i++)
		{
			if (Char.M113().arrItemBox[i] != null && Char.M113().arrItemBox[i].template.type == 6)
			{
				num += Char.M113().arrItemBox[i].quantity;
			}
		}
		if (num < 20 && GameCanvas.gameTick % 100 == 0)
		{
			for (int j = 0; j < Char.M113().arrItemBag.Length; j++)
			{
				if (Char.M113().arrItemBag[j] != null && Char.M113().arrItemBag[j].template.type == 6)
				{
					Service.M1594().M1625(1, (sbyte)j);
					break;
				}
			}
		}
		if (GameScr.M559().magicTree.currPeas > 0 && (GameScr.hpPotion < 10 || num < 20) && GameCanvas.gameTick % 200 == 0)
		{
			Service.M1594().M1656(4);
			Service.M1594().M1657(4, 0, 0);
		}
	}

	private static void M2101()
	{
		if (GameScr.hpPotion > 0)
		{
			if (minimumHPPercent != 0 && M2104(minimumHP, minimumHPPercent) && GameCanvas.gameTick % 20 == 0)
			{
				GameScr.M559().M589();
			}
			else if (minimumMPPercent != 0 && M2105(minimumMP, minimumMPPercent) && GameCanvas.gameTick % 20 == 0)
			{
				GameScr.M559().M589();
			}
		}
	}

	private static int M2102()
	{
		return (int)(Char.M113().cHP * 100L / Char.M113().cHPFull);
	}

	private static int M2103()
	{
		return (int)(Char.M113().cMP * 100L / Char.M113().cMPFull);
	}

	private static bool M2104(int minHP, int minHPPercent)
	{
		if (Char.M113().cHP > 0)
		{
			if (M2102() > minHPPercent)
			{
				return Char.M113().cHP < minHP;
			}
			return true;
		}
		return false;
	}

	private static bool M2105(int minMP, int minMPPercent)
	{
		if (Char.M113().cHP > 0)
		{
			if (M2103() > minMPPercent)
			{
				return Char.M113().cMP < minMP;
			}
			return true;
		}
		return false;
	}
}
