namespace N3.N4;

public class T191 : T57, T58
{
	public static T191 _Instance;

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

	static T191()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		inputHPPercent = new string[2] { "Nhập %HP Pean", "%HP" };
		inputMPPercent = new string[2] { "Nhập %MP Pean", "%MP" };
		inputHP = new string[2] { "Nhập HP Pean", "HP" };
		inputMP = new string[2] { "Nhập MP Pean", "MP" };
		M2095();
	}

	public static T191 M2092()
	{
		if (_Instance == null)
		{
			_Instance = new T191();
		}
		return _Instance;
	}

	public static void M2093()
	{
		if (isAutoRequestPean)
		{
			M2098();
		}
		if (isAutoDonatePean && T51.gameTick % 20 == 0)
		{
			M2099();
		}
		if (isAutoHarvestPean)
		{
			M2100();
		}
		if (!T13.M113().meDead)
		{
			M2101();
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (T15.M279().tfChat.M1924() != null && !T15.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (T15.M279().strChat.Equals(inputHPPercent[0]))
			{
				try
				{
					int num = int.Parse(T15.M279().tfChat.M1924());
					if (num >= 100)
					{
						num = 99;
					}
					if (num <= 0)
					{
						num = 1;
					}
					minimumHPPercent = num;
					T54.info1.M762("Auto pean khi HP dưới: " + num + "%", 0);
					if (isSaveData)
					{
						T138.M1543("AutoPeanPercentHP", minimumHPPercent);
					}
				}
				catch
				{
					T54.info1.M762("%HP không hợp lệ, vui lòng nhập lại", 0);
				}
				M2097();
			}
			else if (T15.M279().strChat.Equals(inputMPPercent[0]))
			{
				try
				{
					int num2 = int.Parse(T15.M279().tfChat.M1924());
					if (num2 >= 100)
					{
						num2 = 99;
					}
					if (num2 <= 0)
					{
						num2 = 1;
					}
					minimumMPPercent = num2;
					T54.info1.M762("Auto pean khi MP dưới: " + num2 + "%", 0);
					if (isSaveData)
					{
						T138.M1543("AutoPeanPercentMP", minimumMPPercent);
					}
				}
				catch
				{
					T54.info1.M762("%MP không hợp lệ, vui lòng nhập lại", 0);
				}
				M2097();
			}
			else if (T15.M279().strChat.Equals(inputHP[0]))
			{
				try
				{
					int num3 = (minimumHP = int.Parse(T15.M279().tfChat.M1924()));
					if (isSaveData)
					{
						T138.M1538("AutoPeanHP", minimumHP.ToString());
					}
					T54.info1.M762("Auto pean khi HP dưới: " + T122.M1192(num3) + "HP", 0);
				}
				catch
				{
					T54.info1.M762("HP không hợp lệ, vui lòng nhập lại", 0);
				}
				M2097();
			}
			else
			{
				if (!T15.M279().strChat.Equals(inputMP[0]))
				{
					return;
				}
				try
				{
					int num4 = (minimumMP = int.Parse(T15.M279().tfChat.M1924()));
					if (isSaveData)
					{
						T138.M1538("AutoPeanMP", minimumMP.ToString());
					}
					T54.info1.M762("Auto pean khi MP dưới: " + T122.M1192(num4) + "MP", 0);
				}
				catch
				{
					T54.info1.M762("MP không hợp lệ, vui lòng nhập lại", 0);
				}
				M2097();
			}
		}
		else
		{
			T15.M279().isShow = false;
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
			T54.info1.M762("Xin Đậu\n" + (isAutoRequestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isSaveData)
			{
				T138.M1543("AutoPeanIsAutoRequestPean", isAutoRequestPean ? 1 : 0);
			}
			break;
		case 2:
			isAutoDonatePean = !isAutoDonatePean;
			T54.info1.M762("Cho Đậu\n" + (isAutoDonatePean ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isSaveData)
			{
				T138.M1543("AutoPeanIsAutoSendPean", isAutoDonatePean ? 1 : 0);
			}
			break;
		case 3:
			isAutoHarvestPean = !isAutoHarvestPean;
			T54.info1.M762("Thu Đậu\n" + (isAutoHarvestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isSaveData)
			{
				T138.M1543("AutoPeanIsAutoHarvestPean", isAutoHarvestPean ? 1 : 0);
			}
			break;
		case 4:
			if (minimumHP != 0)
			{
				minimumHP = 0;
				T54.info1.M762("Auto đậu: 0HP", 0);
				if (isSaveData)
				{
					T138.M1538("AutoPeanHP", minimumHP.ToString());
				}
			}
			else if (minimumHP == 0)
			{
				T15.M279().strChat = inputHP[0];
				T15.M279().tfChat.name = inputHP[1];
				T15.M279().M282(M2092(), string.Empty);
			}
			break;
		case 5:
			if (minimumHPPercent != 0)
			{
				minimumHPPercent = 0;
				T54.info1.M762("Auto đậu: 0% HP", 0);
				if (isSaveData)
				{
					T138.M1543("AutoPeanPercentHP", minimumHPPercent);
				}
			}
			else if (minimumHPPercent == 0)
			{
				T15.M279().strChat = inputHPPercent[0];
				T15.M279().tfChat.name = inputHPPercent[1];
				T15.M279().M282(M2092(), string.Empty);
			}
			break;
		case 6:
			if (minimumMP != 0)
			{
				minimumMP = 0;
				T54.info1.M762("Auto đậu: 0MP", 0);
				if (isSaveData)
				{
					T138.M1538("AutoPeanMP", minimumMP.ToString());
				}
			}
			else if (minimumMP == 0)
			{
				T15.M279().strChat = inputMP[0];
				T15.M279().tfChat.name = inputMP[1];
				T15.M279().M282(M2092(), string.Empty);
			}
			break;
		case 7:
			if (minimumMPPercent != 0)
			{
				minimumMPPercent = 0;
				T54.info1.M762("Auto đậu: 0% MP", 0);
				if (isSaveData)
				{
					T138.M1543("AutoPeanPercentMP", minimumMPPercent);
				}
			}
			else if (minimumMPPercent == 0)
			{
				T15.M279().strChat = inputMPPercent[0];
				T15.M279().tfChat.name = inputMPPercent[1];
				T15.M279().M282(M2092(), string.Empty);
			}
			break;
		case 8:
			isSaveData = !isSaveData;
			T54.info1.M762("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			T138.M1543("AutoPeanIsSaveRms", isSaveData ? 1 : 0);
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
		T117 t = new T117();
		t.M1111(new T22("Xin Đậu\n" + (isAutoRequestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), M2092(), 1, null));
		t.M1111(new T22("Cho Đậu\n" + (isAutoDonatePean ? "[STATUS: ON]" : "[STATUS: OFF]"), M2092(), 2, null));
		t.M1111(new T22("Thu Đậu\n" + (isAutoHarvestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), M2092(), 3, null));
		t.M1111(new T22("Ăn Đậu Khi HP Dưới: " + T122.M1192(minimumHP) + "HP", M2092(), 4, null));
		t.M1111(new T22("Ăn Đậu Khi HP Dưới: " + minimumHPPercent + "%", M2092(), 5, null));
		t.M1111(new T22("Ăn Đậu Khi MP Dưới: " + T122.M1192(minimumMP) + "MP", M2092(), 6, null));
		t.M1111(new T22("Ăn Đậu Khi MP Dưới: " + minimumMPPercent + "%", M2092(), 7, null));
		t.M1111(new T22("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), M2092(), 8, null));
		T51.menu.M877(t, 3);
	}

	private static void M2095()
	{
		isSaveData = T138.M1542("AutoPeanIsSaveRms") == 1;
		if (isSaveData)
		{
			isAutoRequestPean = T138.M1542("AutoPeanIsAutoRequestPean") == 1;
			isAutoDonatePean = T138.M1542("AutoPeanIsAutoSendPean") == 1;
			isAutoHarvestPean = T138.M1542("AutoPeanIsAutoHarvestPean") == 1;
			if (T138.M1542("AutoPeanPercentHP") == -1)
			{
				minimumHPPercent = 0;
			}
			else
			{
				minimumHPPercent = T138.M1542("AutoPeanPercentHP");
			}
			if (T138.M1542("AutoPeanPercentMP") == -1)
			{
				minimumMPPercent = 0;
			}
			else
			{
				minimumMPPercent = T138.M1542("AutoPeanPercentMP");
			}
			if (T138.M1536("AutoPeanHP") == null)
			{
				minimumHP = 0;
			}
			else
			{
				minimumHP = int.Parse(T138.M1536("AutoPeanHP"));
			}
			if (T138.M1536("AutoPeanMP") == null)
			{
				minimumMP = 0;
			}
			else
			{
				minimumMP = int.Parse(T138.M1536("AutoPeanMP"));
			}
		}
	}

	private static void M2096()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T138.M1543("AutoPeanIsAutoRequestPean", isAutoRequestPean ? 1 : 0);
		T138.M1543("AutoPeanIsAutoSendPean", isAutoDonatePean ? 1 : 0);
		T138.M1543("AutoPeanIsAutoHarvestPean", isAutoHarvestPean ? 1 : 0);
		T138.M1538("AutoPeanHP", minimumHP.ToString());
		T138.M1543("AutoPeanPercentHP", minimumHPPercent);
		T138.M1538("AutoPeanMP", minimumMP.ToString());
		T138.M1543("AutoPeanPercentMP", minimumMPPercent);
	}

	private static void M2097()
	{
		T15.M279().strChat = "Chat";
		T15.M279().tfChat.name = "chat";
		T15.M279().isShow = false;
	}

	private static void M2098()
	{
		if (T110.M1054() - lastTimeRequestedPean >= 301000L)
		{
			lastTimeRequestedPean = T110.M1054();
			T146.M1594().M1614(1, "", -1);
		}
	}

	private static void M2099()
	{
		for (int i = 0; i < T19.vMessage.M1113(); i++)
		{
			T19 t = (T19)T19.vMessage.M1114(i);
			if (t.maxCap != 0 && t.playerName != T13.M113().cName && t.recieve != t.maxCap)
			{
				T146.M1594().M1613(t.id);
				break;
			}
		}
	}

	private static void M2100()
	{
		if (T174.mapID != 21 && T174.mapID != 22 && T174.mapID != 23)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < T13.M113().arrItemBox.Length; i++)
		{
			if (T13.M113().arrItemBox[i] != null && T13.M113().arrItemBox[i].template.type == 6)
			{
				num += T13.M113().arrItemBox[i].quantity;
			}
		}
		if (num < 20 && T51.gameTick % 100 == 0)
		{
			for (int j = 0; j < T13.M113().arrItemBag.Length; j++)
			{
				if (T13.M113().arrItemBag[j] != null && T13.M113().arrItemBag[j].template.type == 6)
				{
					T146.M1594().M1625(1, (sbyte)j);
					break;
				}
			}
		}
		if (T54.M559().magicTree.currPeas > 0 && (T54.hpPotion < 10 || num < 20) && T51.gameTick % 200 == 0)
		{
			T146.M1594().M1656(4);
			T146.M1594().M1657(4, 0, 0);
		}
	}

	private static void M2101()
	{
		if (T54.hpPotion > 0)
		{
			if (minimumHPPercent != 0 && M2104(minimumHP, minimumHPPercent) && T51.gameTick % 20 == 0)
			{
				T54.M559().M589();
			}
			else if (minimumMPPercent != 0 && M2105(minimumMP, minimumMPPercent) && T51.gameTick % 20 == 0)
			{
				T54.M559().M589();
			}
		}
	}

	private static int M2102()
	{
		return (int)(T13.M113().cHP * 100L / T13.M113().cHPFull);
	}

	private static int M2103()
	{
		return (int)(T13.M113().cMP * 100L / T13.M113().cMPFull);
	}

	private static bool M2104(int minHP, int minHPPercent)
	{
		if (T13.M113().cHP > 0)
		{
			if (M2102() > minHPPercent)
			{
				return T13.M113().cHP < minHP;
			}
			return true;
		}
		return false;
	}

	private static bool M2105(int minMP, int minMPPercent)
	{
		if (T13.M113().cHP > 0)
		{
			if (M2103() > minMPPercent)
			{
				return T13.M113().cMP < minMP;
			}
			return true;
		}
		return false;
	}
}
