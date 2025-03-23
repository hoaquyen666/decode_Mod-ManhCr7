using System.Linq;

public class T79
{
	public const int OPT_STAR = 34;

	public const int OPT_MOON = 35;

	public const int OPT_SUN = 36;

	public const int OPT_COLORNAME = 41;

	public const int OPT_LVITEM = 72;

	public const int OPT_STARSLOT = 102;

	public const int OPT_MAXSTARSLOT = 107;

	public const int TYPE_BODY_MIN = 0;

	public const int TYPE_BODY_MAX = 6;

	public const int TYPE_AO = 0;

	public const int TYPE_QUAN = 1;

	public const int TYPE_GANGTAY = 2;

	public const int TYPE_GIAY = 3;

	public const int TYPE_RADA = 4;

	public const int TYPE_HAIR = 5;

	public const int TYPE_DAUTHAN = 6;

	public const int TYPE_NGOCRONG = 12;

	public const int TYPE_SACH = 7;

	public const int TYPE_NHIEMVU = 8;

	public const int TYPE_GOLD = 9;

	public const int TYPE_DIAMOND = 10;

	public const int TYPE_BALO = 11;

	public const int TYPE_MOUNT = 23;

	public const int TYPE_MOUNT_VIP = 24;

	public const int TYPE_DIAMOND_LOCK = 34;

	public const int TYPE_TRAINSUIT = 32;

	public const int TYPE_HAT = 35;

	public const sbyte UI_WEAPON = 2;

	public const sbyte UI_BAG = 3;

	public const sbyte UI_BOX = 4;

	public const sbyte UI_BODY = 5;

	public const sbyte UI_STACK = 6;

	public const sbyte UI_STACK_LOCK = 7;

	public const sbyte UI_GROCERY = 8;

	public const sbyte UI_GROCERY_LOCK = 9;

	public const sbyte UI_UPGRADE = 10;

	public const sbyte UI_UPPEARL = 11;

	public const sbyte UI_UPPEARL_LOCK = 12;

	public const sbyte UI_SPLIT = 13;

	public const sbyte UI_STORE = 14;

	public const sbyte UI_BOOK = 15;

	public const sbyte UI_LIEN = 16;

	public const sbyte UI_NHAN = 17;

	public const sbyte UI_NGOCBOI = 18;

	public const sbyte UI_PHU = 19;

	public const sbyte UI_NONNAM = 20;

	public const sbyte UI_NONNU = 21;

	public const sbyte UI_AONAM = 22;

	public const sbyte UI_AONU = 23;

	public const sbyte UI_GANGTAYNAM = 24;

	public const sbyte UI_GANGTAYNU = 25;

	public const sbyte UI_QUANNAM = 26;

	public const sbyte UI_QUANNU = 27;

	public const sbyte UI_GIAYNAM = 28;

	public const sbyte UI_GIAYNU = 29;

	public const sbyte UI_TRADE = 30;

	public const sbyte UI_UPGRADE_GOLD = 31;

	public const sbyte UI_FASHION = 32;

	public const sbyte UI_CONVERT = 33;

	public T82[] itemOption;

	public T84 template;

	public T117 options;

	public int itemId;

	public int playerId;

	public bool isSelect;

	public int indexUI;

	public int quantity;

	public int quantilyToBuy;

	public long powerRequire;

	public bool isLock;

	public int sys;

	public int upgrade;

	public int buyCoin;

	public int buyCoinLock;

	public int buyGold;

	public int buyGoldLock;

	public int saleCoinLock;

	public int buySpec;

	public int buyRuby;

	public short iconSpec = -1;

	public sbyte buyType = -1;

	public int typeUI;

	public bool isExpires;

	public bool isBuySpec;

	public T35 eff;

	public int indexEff;

	public T60 img;

	public string info;

	public string content;

	public string reason = string.Empty;

	public int compare;

	public sbyte isMe;

	public bool newItem;

	public int headTemp = -1;

	public int bodyTemp = -1;

	public int legTemp = -1;

	public int bagTemp = -1;

	public int wpTemp = -1;

	private int[] color = new int[18]
	{
		0, 0, 0, 0, 600841, 600841, 667658, 667658, 3346944, 3346688,
		4199680, 5052928, 3276851, 3932211, 4587571, 5046280, 6684682, 3359744
	};

	private int[][] colorBorder = new int[5][]
	{
		new int[6] { 18687, 16869, 15052, 13235, 11161, 9344 },
		new int[6] { 45824, 39168, 32768, 26112, 19712, 13056 },
		new int[6] { 16744192, 15037184, 13395456, 11753728, 10046464, 8404992 },
		new int[6] { 13500671, 12058853, 10682572, 9371827, 7995545, 6684800 },
		new int[6] { 16711705, 15007767, 13369364, 11730962, 10027023, 8388621 }
	};

	private int[] size = new int[6] { 2, 1, 1, 1, 1, 1 };

	public int M796()
	{
		int num = 0;
		while (true)
		{
			if (num < itemOption.Length)
			{
				if (itemOption[num].optionTemplate.id == 107)
				{
					break;
				}
				num++;
				continue;
			}
			return 0;
		}
		return itemOption[num].param;
	}

	public string M797()
	{
		if (itemOption != null && itemOption.Length != 0)
		{
			string[] array = itemOption.Where((T82 opt) => opt.optionTemplate.name.Contains("Sức đánh+#%") || opt.optionTemplate.name.Contains("HP+#%") || opt.optionTemplate.name.Contains("KI+#%") || opt.optionTemplate.name.Contains("Biến #% tấn công thành HP") || opt.optionTemplate.name.Contains("Biến #% tấn công thành KI") || opt.optionTemplate.name.Contains("+#% tiềm năng, sức mạnh") || opt.optionTemplate.name.Contains("Phản #% sát thương") || opt.optionTemplate.name.Contains("+#% vàng rơi")).Select(delegate(T82 opt)
			{
				string name = opt.optionTemplate.name;
				string text = opt.M830();
				string text2 = "";
				string text3 = text;
				for (int i = 0; i < text3.Length; i++)
				{
					char c = text3[i];
					if (char.IsDigit(c) || c == '.')
					{
						text2 += c;
					}
				}
				if (name.Contains("Sức đánh+#%"))
				{
					return text2 + "% SĐ";
				}
				if (name.Contains("HP+#%"))
				{
					return text2 + "% HP";
				}
				if (name.Contains("KI+#%"))
				{
					return text2 + "% KI";
				}
				if (name.Contains("Biến #% tấn công thành HP"))
				{
					return text2 + "% HM";
				}
				if (name.Contains("Biến #% tấn công thành KI"))
				{
					return text2 + "% HK";
				}
				if (name.Contains("+#% tiềm năng, sức mạnh"))
				{
					return text2 + "% TNSM";
				}
				if (name.Contains("Phản #% sát thương"))
				{
					return text2 + "% PST";
				}
				if (name.Contains("+#% vàng rơi"))
				{
					return text2 + "% COIN";
				}
				if (name.Contains("Giảm #% sát thương"))
				{
					return text2 + "% Giáp";
				}
				if (name.Contains("#% Né đòn"))
				{
					return text2 + "% Né";
				}
				return name.Contains("KI+#%/30s") ? ("+" + text2 + "% KI/30s") : text;
			}).ToArray();
			if (array.Length != 0)
			{
				return string.Join(", ", array);
			}
		}
		return "CNC";
	}

	public void M798()
	{
		compare = T51.panel.M1365(this);
	}

	public string M799()
	{
		string result = string.Empty;
		if (buyCoin <= 0 && buyGold <= 0)
		{
			return null;
		}
		if (buyCoin > 0 && buyGold <= 0)
		{
			result = buyCoin + mResources.XU;
		}
		else if (buyGold > 0 && buyCoin <= 0)
		{
			result = buyGold + mResources.LUONG;
		}
		else if (buyCoin > 0 && buyGold > 0)
		{
			result = buyCoin + mResources.XU + "/" + buyGold + mResources.LUONG;
		}
		return result;
	}

	public void M800(int x, int y, int upgrade, T99 g)
	{
		int num = T54.indexSize - 2;
		int num2 = 0;
		int num3 = ((upgrade >= 4) ? ((upgrade < 8) ? 1 : ((upgrade < 12) ? 2 : ((upgrade > 14) ? 4 : 3))) : 0);
		for (int i = num2; i < size.Length; i++)
		{
			int num4 = x - num / 2 + M802(T51.gameTick - i * 4);
			int num5 = y - num / 2 + M801(T51.gameTick - i * 4);
			g.M933(colorBorder[num3][i]);
			g.M932(num4 - size[i] / 2, num5 - size[i] / 2, size[i], size[i]);
		}
		if (upgrade == 4 || upgrade == 8)
		{
			for (int j = num2; j < size.Length; j++)
			{
				int num6 = x - num / 2 + M802(T51.gameTick - num * 2 - j * 4);
				int num7 = y - num / 2 + M801(T51.gameTick - num * 2 - j * 4);
				g.M933(colorBorder[num3 - 1][j]);
				g.M932(num6 - size[j] / 2, num7 - size[j] / 2, size[j], size[j]);
			}
		}
		if (upgrade != 1 && upgrade != 4 && upgrade != 8)
		{
			for (int k = num2; k < size.Length; k++)
			{
				int num8 = x - num / 2 + M802(T51.gameTick - num * 2 - k * 4);
				int num9 = y - num / 2 + M801(T51.gameTick - num * 2 - k * 4);
				g.M933(colorBorder[num3][k]);
				g.M932(num8 - size[k] / 2, num9 - size[k] / 2, size[k], size[k]);
			}
		}
		if (upgrade != 1 && upgrade != 4 && upgrade != 8 && upgrade != 12 && upgrade != 2 && upgrade != 5 && upgrade != 9)
		{
			for (int l = num2; l < size.Length; l++)
			{
				int num10 = x - num / 2 + M802(T51.gameTick - num - l * 4);
				int num11 = y - num / 2 + M801(T51.gameTick - num - l * 4);
				g.M933(colorBorder[num3][l]);
				g.M932(num10 - size[l] / 2, num11 - size[l] / 2, size[l], size[l]);
			}
		}
		if (upgrade != 1 && upgrade != 4 && upgrade != 8 && upgrade != 12 && upgrade != 2 && upgrade != 5 && upgrade != 9 && upgrade != 13 && upgrade != 3 && upgrade != 6 && upgrade != 10 && upgrade != 15)
		{
			for (int m = num2; m < size.Length; m++)
			{
				int num12 = x - num / 2 + M802(T51.gameTick - num * 3 - m * 4);
				int num13 = y - num / 2 + M801(T51.gameTick - num * 3 - m * 4);
				g.M933(colorBorder[num3][m]);
				g.M932(num12 - size[m] / 2, num13 - size[m] / 2, size[m], size[m]);
			}
		}
	}

	private int M801(int tick)
	{
		int num = T54.indexSize - 2;
		int num2 = tick % (4 * num);
		if (0 <= num2 && num2 < num)
		{
			return 0;
		}
		if (num <= num2 && num2 < num * 2)
		{
			return num2 % num;
		}
		if (num * 2 <= num2 && num2 < num * 3)
		{
			return num;
		}
		return num - num2 % num;
	}

	private int M802(int tick)
	{
		int num = T54.indexSize - 2;
		int num2 = tick % (4 * num);
		if (0 <= num2 && num2 < num)
		{
			return num2 % num;
		}
		if (num <= num2 && num2 < num * 2)
		{
			return num;
		}
		if (num * 2 <= num2 && num2 < num * 3)
		{
			return num - num2 % num;
		}
		return 0;
	}

	public bool M803(int id)
	{
		for (int i = 0; i < itemOption.Length; i++)
		{
			T82 t = itemOption[i];
			if (t != null && t.optionTemplate.id == id)
			{
				return true;
			}
		}
		return false;
	}

	public T79 M804()
	{
		T79 t = new T79();
		t.template = template;
		if (options != null)
		{
			t.options = new T117();
			for (int i = 0; i < options.M1113(); i++)
			{
				T82 t2 = new T82();
				t2.optionTemplate = ((T82)options.M1114(i)).optionTemplate;
				t2.param = ((T82)options.M1114(i)).param;
				t.options.M1111(t2);
			}
		}
		t.itemId = itemId;
		t.playerId = playerId;
		t.indexUI = indexUI;
		t.quantity = quantity;
		t.isLock = isLock;
		t.sys = sys;
		t.upgrade = upgrade;
		t.buyCoin = buyCoin;
		t.buyCoinLock = buyCoinLock;
		t.buyGold = buyGold;
		t.buyGoldLock = buyGoldLock;
		t.saleCoinLock = saleCoinLock;
		t.typeUI = typeUI;
		t.isExpires = isExpires;
		return t;
	}

	public bool M805()
	{
		if ((0 > template.type || template.type >= 6) && template.type != 32 && template.type != 35 && template.type != 11 && template.type != 23)
		{
			return false;
		}
		return true;
	}

	public string M806()
	{
		if (isLock)
		{
			return mResources.LOCKED;
		}
		return mResources.NOLOCK;
	}

	public string M807()
	{
		if (template.level >= 10 && template.type < 10)
		{
			if (upgrade == 0)
			{
				return mResources.NOUPGRADE;
			}
			return null;
		}
		return mResources.NOTUPGRADE;
	}

	public bool M808()
	{
		if (typeUI != 5 && typeUI != 3 && typeUI != 4)
		{
			return false;
		}
		return true;
	}

	public bool M809()
	{
		if (M810())
		{
			return true;
		}
		if (!M812() && !M813() && !M814())
		{
			return false;
		}
		return true;
	}

	public bool M810()
	{
		if (typeUI != 20 && typeUI != 21 && typeUI != 22 && typeUI != 23 && typeUI != 24 && typeUI != 25 && typeUI != 26 && typeUI != 27 && typeUI != 28 && typeUI != 29 && typeUI != 16 && typeUI != 17 && typeUI != 18 && typeUI != 19 && typeUI != 2 && typeUI != 6 && typeUI != 8)
		{
			return false;
		}
		return true;
	}

	public bool M811()
	{
		if (typeUI != 7 && typeUI != 9)
		{
			return false;
		}
		return true;
	}

	public bool M812()
	{
		if (typeUI == 14)
		{
			return true;
		}
		return false;
	}

	public bool M813()
	{
		if (typeUI == 15)
		{
			return true;
		}
		return false;
	}

	public bool M814()
	{
		if (typeUI == 32)
		{
			return true;
		}
		return false;
	}

	public bool M815()
	{
		if (M816() == upgrade)
		{
			return true;
		}
		return false;
	}

	public int M816()
	{
		if (template.level >= 1 && template.level < 20)
		{
			return 4;
		}
		if (template.level >= 20 && template.level < 40)
		{
			return 8;
		}
		if (template.level >= 40 && template.level < 50)
		{
			return 12;
		}
		if (template.level >= 50 && template.level < 60)
		{
			return 14;
		}
		return 16;
	}

	public void M817(int headTemp, int bodyTemp, int legTemp, int bagTemp)
	{
		this.headTemp = headTemp;
		this.bodyTemp = bodyTemp;
		this.legTemp = legTemp;
		this.bagTemp = bagTemp;
	}

	public void M818(T99 g, int x, int y, int index)
	{
		if (index > 7)
		{
			index = 7;
		}
		if (index < 0)
		{
			index = 0;
		}
		int[] array = new int[7] { 0, 0, 1, 1, 2, 3, 4 };
		int[] array2 = new int[8] { 0, 0, 0, 0, 600841, 3346944, 3932211, 6684682 };
		int[] array3 = new int[4] { 0, 68, 68, 0 };
		int[] array4 = new int[4] { 0, 48, 0, 48 };
		if (index >= 4)
		{
			g.M933(array2[index]);
			g.M932(x - 18, y - 12, 34, 23);
		}
		if (index < 4)
		{
			switch (index)
			{
			default:
			{
				for (int k = 0; k < 2; k++)
				{
					for (int l = 0; l < size.Length; l++)
					{
						int num3 = x - 17 + M819(T51.gameTick + array3[k] - l * 4);
						int num4 = y - 12 + M820(T51.gameTick + array4[k] - l * 4);
						g.M933(colorBorder[0][l]);
						g.M932(num3 - size[l] / 2, num4 - size[l] / 2, size[l], size[l]);
					}
				}
				for (int m = 2; m < 4; m++)
				{
					for (int n = 0; n < size.Length; n++)
					{
						int num5 = x - 17 + M819(T51.gameTick + array3[m] - n * 4);
						int num6 = y - 12 + M820(T51.gameTick + array4[m] - n * 4);
						g.M933(colorBorder[1][n]);
						g.M932(num5 - size[n] / 2, num6 - size[n] / 2, size[n], size[n]);
					}
				}
				return;
			}
			case 1:
			{
				for (int i = 0; i < 2; i++)
				{
					for (int j = 0; j < size.Length; j++)
					{
						int num = x - 17 + M819(T51.gameTick + array3[i] - j * 4);
						int num2 = y - 12 + M820(T51.gameTick + array4[i] - j * 4);
						g.M933(colorBorder[array[index - 1]][j]);
						g.M932(num - size[j] / 2, num2 - size[j] / 2, size[j], size[j]);
					}
				}
				return;
			}
			case 2:
				break;
			}
		}
		for (int num7 = 0; num7 < 4; num7++)
		{
			for (int num8 = 0; num8 < size.Length; num8++)
			{
				int num9 = x - 17 + M819(T51.gameTick + array3[num7] - num8 * 4);
				int num10 = y - 12 + M820(T51.gameTick + array4[num7] - num8 * 4);
				g.M933(colorBorder[array[index - 1]][num8]);
				g.M932(num9 - size[num8] / 2, num10 - size[num8] / 2, size[num8], size[num8]);
			}
		}
	}

	private int M819(int int_0)
	{
		int num = 32;
		int num2 = int_0 % 128;
		if (0 <= num2 && num2 < num)
		{
			return num2 % num;
		}
		if (num <= num2 && num2 < num * 2)
		{
			return num;
		}
		if (num * 2 <= num2 && num2 < num * 3)
		{
			return num - num2 % num;
		}
		return 0;
	}

	private int M820(int int_0)
	{
		int num = 22;
		int num2 = int_0 % 88;
		if (0 <= num2 && num2 < num)
		{
			return 0;
		}
		if (num <= num2 && num2 < num * 2)
		{
			return num2 % num;
		}
		if (num * 2 <= num2 && num2 < num * 3)
		{
			return num;
		}
		return num - num2 % num;
	}

	public string M821()
	{
		string text = template.name;
		if (itemOption != null)
		{
			for (int i = 0; i < itemOption.Length; i++)
			{
				if (itemOption[i].optionTemplate.id == 72)
				{
					text = text + " [+" + itemOption[i].param + "]";
					break;
				}
			}
		}
		if (itemOption != null)
		{
			for (int j = 0; j < itemOption.Length; j++)
			{
				if (itemOption[j].optionTemplate.name.StartsWith("$"))
				{
					string text2 = itemOption[j].M832();
					if (itemOption[j].param == 1)
					{
						text = text + "\n" + text2;
					}
					if (itemOption[j].param == 0)
					{
						text = text + "\n" + text2;
					}
				}
				else
				{
					string text3 = itemOption[j].M830();
					if (!text3.Equals(string.Empty) && itemOption[j].optionTemplate.id != 72)
					{
						text = text + "\n" + text3;
					}
				}
			}
		}
		if (template.strRequire > 1)
		{
			text = text + "\n" + mResources.pow_request + ": " + template.strRequire;
		}
		return text + "\n" + template.description;
	}
}
