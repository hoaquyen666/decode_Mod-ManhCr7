public class T70
{
	public const sbyte TYPE_MONSTER = 0;

	public const sbyte TYPE_CHARPART = 1;

	public sbyte rank;

	public sbyte amount;

	public sbyte max_amount;

	public sbyte typeMonster;

	public int id;

	public int no;

	public int idIcon;

	public string name;

	public string info;

	public sbyte level;

	public sbyte isUse;

	public T13 charInfo;

	public T101 mobInfo;

	public T82[] itemOption;

	private int[] f = new int[10] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

	private int count;

	private long timeRequest;

	public T14 cp;

	public T117 eff = new T117(string.Empty);

	public void M766(int id, int no, int idIcon, sbyte rank, sbyte typeMonster, short templateId, string name, string info, T13 charInfo, T82[] itemOption)
	{
		this.id = id;
		this.no = no;
		this.idIcon = idIcon;
		this.rank = rank;
		this.typeMonster = typeMonster;
		if (templateId != -1)
		{
			mobInfo = new T101();
			mobInfo.templateId = templateId;
		}
		this.name = name;
		this.info = info;
		this.charInfo = charInfo;
		this.itemOption = itemOption;
		M773();
	}

	public void M767(sbyte amount, sbyte max_amount)
	{
		this.amount = amount;
		this.max_amount = max_amount;
	}

	public void M768(sbyte level)
	{
		this.level = level;
		M773();
	}

	public void M769(sbyte isUse)
	{
		this.isUse = isUse;
		M773();
	}

	public static T13 M770(int head, int body, int leg, int bag)
	{
		return new T13
		{
			head = head,
			body = body,
			leg = leg,
			bag = bag
		};
	}

	public static T70 M771(T117 vec, int id)
	{
		if (vec != null)
		{
			for (int i = 0; i < vec.M1113(); i++)
			{
				T70 t = (T70)vec.M1114(i);
				if (t != null && t.id == id)
				{
					return t;
				}
			}
		}
		return null;
	}

	public void M772(T99 g, int x, int y)
	{
		count++;
		if (count > f.Length - 1)
		{
			count = 0;
		}
		if (typeMonster == 0)
		{
			if (T101.arrMobTemplate[mobInfo.templateId] != null)
			{
				if (T101.arrMobTemplate[mobInfo.templateId].data != null)
				{
					T101.arrMobTemplate[mobInfo.templateId].data.M401(g, f[count], x, y, 0, 0);
				}
				else if (timeRequest - T51.timeNow < 0L)
				{
					timeRequest = T51.timeNow + 1500L;
					mobInfo.M975();
				}
			}
		}
		else if (charInfo != null)
		{
			charInfo.M199(g, x, y, 1, f[count], isPaintBag: true);
		}
	}

	public void M773()
	{
		cp = new T14();
		string empty = string.Empty;
		string text = string.Concat(string.Empty + "\n|6|" + info, "\n--");
		if (itemOption != null)
		{
			int num = 0;
			bool flag = true;
			while (flag)
			{
				int num2 = 0;
				for (int i = 0; i < itemOption.Length; i++)
				{
					if (!itemOption[i].M830().Equals(string.Empty) && num == itemOption[i].activeCard)
					{
						num2++;
						break;
					}
				}
				if (num2 != 0)
				{
					if (num == 0)
					{
						text = text + "\n|6|2|--" + mResources.unlock + "--";
					}
					else
					{
						string text2 = text;
						text = text2 + "\n|6|2|--" + mResources.equip + " Lv." + num + "--";
					}
					for (int j = 0; j < itemOption.Length; j++)
					{
						empty = itemOption[j].M830();
						if (empty.Equals(string.Empty) || num != itemOption[j].activeCard)
						{
							continue;
						}
						string text3 = "1";
						if (level == 0)
						{
							text3 = "2";
						}
						else if (itemOption[j].activeCard != 0)
						{
							if (isUse == 0)
							{
								text3 = "2";
							}
							else if (level < itemOption[j].activeCard)
							{
								text3 = "2";
							}
						}
						string text4 = text;
						text = text4 + "\n|" + text3 + "|1|" + empty;
					}
					if (num2 != 0)
					{
						num++;
					}
					continue;
				}
				flag = false;
				break;
			}
		}
		M774(cp, text);
	}

	public void M774(T14 cp, string chat)
	{
		cp.sayWidth = T136.wText;
		cp.cx = T136.xText;
		cp.says = T98.tahoma_7.M907(chat, cp.sayWidth - 8);
		cp.delay = 10000000;
		cp.c = null;
		cp.ch = cp.says.Length * 12;
		cp.cy = T136.yText;
		cp.strY = 10;
		cp.lim = cp.ch - T136.hText;
		if (cp.lim < 0)
		{
			cp.lim = 0;
		}
	}

	public void M775()
	{
		if (amount == max_amount && eff.M1113() == 0)
		{
			int num = T137.M1522(1, 5);
			for (int i = 0; i < num; i++)
			{
				T135 t = new T135();
				t.x = T137.M1522(5, 25);
				t.y = T137.M1522(5, 25);
				t.v = i * T137.M1522(0, 8);
				t.w = 0;
				t.anchor = -1;
				eff.M1111(t);
			}
		}
	}

	public void M776(T99 g, int x, int y)
	{
		M775();
		for (int i = 0; i < eff.M1113(); i++)
		{
			T135 t = (T135)eff.M1114(i);
			if (t == null)
			{
				continue;
			}
			if (t.w < t.v)
			{
				t.w++;
			}
			if (t.w >= t.v)
			{
				t.anchor = T51.gameTick / 3 % (T136.fraEff.nFrame + 1);
				if (t.anchor >= T136.fraEff.nFrame)
				{
					eff.M1118(i);
					i--;
				}
				else
				{
					T136.fraEff.M439(t.anchor, x + t.x, y + t.y, 0, 3, g);
				}
			}
		}
	}
}
