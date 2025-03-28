public class Info_RadaScr
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

	public Char charInfo;

	public Mob mobInfo;

	public ItemOption[] itemOption;

	private int[] f = new int[10] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

	private int count;

	private long timeRequest;

	public ChatPopup cp;

	public MyVector eff = new MyVector(string.Empty);

	public void M766(int id, int no, int idIcon, sbyte rank, sbyte typeMonster, short templateId, string name, string info, Char charInfo, ItemOption[] itemOption)
	{
		this.id = id;
		this.no = no;
		this.idIcon = idIcon;
		this.rank = rank;
		this.typeMonster = typeMonster;
		if (templateId != -1)
		{
			mobInfo = new Mob();
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

	public static Char M770(int head, int body, int leg, int bag)
	{
		return new Char
		{
			head = head,
			body = body,
			leg = leg,
			bag = bag
		};
	}

	public static Info_RadaScr M771(MyVector vec, int id)
	{
		if (vec != null)
		{
			for (int i = 0; i < vec.M1113(); i++)
			{
				Info_RadaScr t = (Info_RadaScr)vec.M1114(i);
				if (t != null && t.id == id)
				{
					return t;
				}
			}
		}
		return null;
	}

	public void M772(mGraphics g, int x, int y)
	{
		count++;
		if (count > f.Length - 1)
		{
			count = 0;
		}
		if (typeMonster == 0)
		{
			if (Mob.arrMobTemplate[mobInfo.templateId] != null)
			{
				if (Mob.arrMobTemplate[mobInfo.templateId].data != null)
				{
					Mob.arrMobTemplate[mobInfo.templateId].data.M401(g, f[count], x, y, 0, 0);
				}
				else if (timeRequest - GameCanvas.timeNow < 0L)
				{
					timeRequest = GameCanvas.timeNow + 1500L;
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
		cp = new ChatPopup();
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

	public void M774(ChatPopup cp, string chat)
	{
		cp.sayWidth = RadarScr.wText;
		cp.cx = RadarScr.xText;
		cp.says = mFont.tahoma_7.M907(chat, cp.sayWidth - 8);
		cp.delay = 10000000;
		cp.c = null;
		cp.ch = cp.says.Length * 12;
		cp.cy = RadarScr.yText;
		cp.strY = 10;
		cp.lim = cp.ch - RadarScr.hText;
		if (cp.lim < 0)
		{
			cp.lim = 0;
		}
	}

	public void M775()
	{
		if (amount == max_amount && eff.M1113() == 0)
		{
			int num = Res.M1522(1, 5);
			for (int i = 0; i < num; i++)
			{
				Position t = new Position();
				t.x = Res.M1522(5, 25);
				t.y = Res.M1522(5, 25);
				t.v = i * Res.M1522(0, 8);
				t.w = 0;
				t.anchor = -1;
				eff.M1111(t);
			}
		}
	}

	public void M776(mGraphics g, int x, int y)
	{
		M775();
		for (int i = 0; i < eff.M1113(); i++)
		{
			Position t = (Position)eff.M1114(i);
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
				t.anchor = GameCanvas.gameTick / 3 % (RadarScr.fraEff.nFrame + 1);
				if (t.anchor >= RadarScr.fraEff.nFrame)
				{
					eff.M1118(i);
					i--;
				}
				else
				{
					RadarScr.fraEff.M439(t.anchor, x + t.x, y + t.y, 0, 3, g);
				}
			}
		}
	}
}
