public class TabClanIcon : IActionListener
{
	private int x;

	private int y;

	private int w;

	private int h;

	private Command left;

	private Command right;

	private Command center;

	private int WIDTH = 24;

	public int nItem;

	private int disStart = 50;

	public static Scroll scrMain;

	public int cmtoX;

	public int cmx;

	public int cmvx;

	public int cmdx;

	public bool isShow;

	public bool isGetName;

	public string text;

	private bool isRequest;

	private bool isUpdate;

	public MyVector vItems = new MyVector();

	private int msgID;

	private int select;

	private int lastSelect;

	private ScrollResult sr;

	public TabClanIcon()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		left = new Command(mResources.SELECT, this, 1, null);
		right = new Command(mResources.CLOSE, this, 2, null);
	}

	public void M1885()
	{
		if (isGetName)
		{
			w = 170;
			h = 118;
			x = GameCanvas.w / 2 - w / 2;
			y = GameCanvas.h / 2 - h / 2;
		}
		else
		{
			w = 170;
			h = 170;
			x = GameCanvas.w / 2 - w / 2;
			y = GameCanvas.h / 2 - h / 2;
			if (GameCanvas.h < 240)
			{
				y -= 10;
			}
		}
		cmx = x;
		cmtoX = 0;
		if (!isRequest)
		{
			nItem = ClanImage.vClanImage.M1113();
		}
		else
		{
			nItem = vItems.M1113();
		}
		if (GameCanvas.isTouch)
		{
			left.x = x;
			left.y = y + h + 5;
			right.x = x + w - 68;
			right.y = y + h + 5;
		}
		scrMain = new Scroll();
		scrMain.M1566(nItem, WIDTH, x, y + disStart, w, h - disStart, styleUPDOWN: true, 1);
	}

	public void M1886(bool isGetName)
	{
		if (Char.M113().clan != null)
		{
			isUpdate = true;
		}
		isShow = true;
		this.isGetName = isGetName;
		M1885();
	}

	public void M1887(int msgID)
	{
		isShow = true;
		isRequest = true;
		this.msgID = msgID;
		M1885();
	}

	public void M1888()
	{
		cmtoX = x + w;
		SmallImage.M1783();
	}

	public void M1889(mGraphics g)
	{
	}

	public void M1890(mGraphics g)
	{
		g.M918(-cmx, 0);
		PopUp.M1481(g, x, y - 17, w, h + 17, -1, isButton: true);
		mFont.tahoma_7b_dark.M898(g, mResources.select_clan_icon, x + w / 2, y - 7, 2);
		if (lastSelect >= 0 && lastSelect <= ClanImage.vClanImage.M1113() - 1)
		{
			ClanImage t = (ClanImage)ClanImage.vClanImage.M1114(lastSelect);
			if (t.idImage != null)
			{
				Char.M113().M195(g, t.idImage, GameCanvas.w / 2, y + 45, 1, isPaintChar: false);
			}
		}
		Char.M113().M199(g, GameCanvas.w / 2, y + 45, 1, Char.M113().cf, isPaintBag: false);
		g.M922(x, y + disStart, w, h - disStart - 10);
		if (scrMain != null)
		{
			g.M918(0, -scrMain.cmy);
		}
		for (int i = 0; i < nItem; i++)
		{
			int num = x + 10;
			int num2 = y + i * WIDTH + disStart;
			if (num2 + WIDTH - ((scrMain != null) ? scrMain.cmy : 0) >= y + disStart && num2 - ((scrMain != null) ? scrMain.cmy : 0) <= y + disStart + h)
			{
				ClanImage t2 = (ClanImage)ClanImage.vClanImage.M1114(i);
				mFont t3 = mFont.tahoma_7_grey;
				if (i == lastSelect)
				{
					t3 = mFont.tahoma_7_blue;
				}
				if (t2.name != null)
				{
					t3.M898(g, t2.name, num + 20, num2, 0);
				}
				if (t2.xu > 0)
				{
					t3.M898(g, t2.xu + " " + mResources.XU, num + w - 20, num2, mFont.RIGHT);
				}
				else if (t2.luong > 0)
				{
					t3.M898(g, t2.luong + " " + mResources.LUONG, num + w - 20, num2, mFont.RIGHT);
				}
				if (t2.idImage != null)
				{
					SmallImage.M1785(g, t2.idImage[0], num, num2, 0, 0);
				}
			}
		}
		g.M918(0, -g.M921());
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
		GameCanvas.paintz.M1208(g, left, center, right);
	}

	public void M1891(mGraphics g)
	{
		if (!isRequest)
		{
			M1890(g);
		}
		else
		{
			M1889(g);
		}
	}

	public void M1892()
	{
		if (scrMain != null)
		{
			scrMain.M1565();
		}
		if (cmx != cmtoX)
		{
			cmvx = cmtoX - cmx << 2;
			cmdx += cmvx;
			cmx += cmdx >> 3;
			cmdx &= 15;
		}
		if (Math.M869(cmtoX - cmx) < 10)
		{
			cmx = cmtoX;
		}
		if (cmx >= x + w - 10 && cmtoX >= x + w - 10)
		{
			isShow = false;
		}
	}

	public void M1893()
	{
		if (left != null && (GameCanvas.keyPressed[12] || mScreen.M1034(left)))
		{
			left.M294();
		}
		if (right != null && (GameCanvas.keyPressed[13] || mScreen.M1034(right)))
		{
			right.M294();
		}
		if (center != null && (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] || mScreen.M1034(center)))
		{
			center.M294();
		}
		if (!isGetName)
		{
			if (scrMain == null)
			{
				return;
			}
			if (GameCanvas.isTouch)
			{
				scrMain.M1561();
				select = scrMain.selectedItem;
			}
			if (GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21])
			{
				GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21] = false;
				select--;
				if (select < 0)
				{
					select = nItem - 1;
				}
				scrMain.M1567(select * scrMain.ITEM_SIZE);
			}
			if (GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22])
			{
				GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22] = false;
				select++;
				if (select > nItem - 1)
				{
					select = 0;
				}
				scrMain.M1567(select * scrMain.ITEM_SIZE);
			}
			if (select != -1)
			{
				lastSelect = select;
			}
		}
		GameCanvas.M484();
		GameCanvas.M483();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 2)
		{
			M1888();
		}
		if (idAction != 1 || isGetName)
		{
			return;
		}
		if (!isRequest)
		{
			if (lastSelect >= 0)
			{
				M1888();
				if (Char.M113().clan == null)
				{
					Service.M1594().M1623(2, (sbyte)((ClanImage)ClanImage.vClanImage.M1114(lastSelect)).ID, text);
				}
				else
				{
					Service.M1594().M1623(4, (sbyte)((ClanImage)ClanImage.vClanImage.M1114(lastSelect)).ID, string.Empty);
				}
			}
		}
		else if (lastSelect >= 0)
		{
			_ = (Item)vItems.M1114(select);
		}
	}
}
