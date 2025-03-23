public class T167 : T57
{
	private int x;

	private int y;

	private int w;

	private int h;

	private T22 left;

	private T22 right;

	private T22 center;

	private int WIDTH = 24;

	public int nItem;

	private int disStart = 50;

	public static T140 scrMain;

	public int cmtoX;

	public int cmx;

	public int cmvx;

	public int cmdx;

	public bool isShow;

	public bool isGetName;

	public string text;

	private bool isRequest;

	private bool isUpdate;

	public T117 vItems = new T117();

	private int msgID;

	private int select;

	private int lastSelect;

	private T141 sr;

	public T167()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		left = new T22(mResources.SELECT, this, 1, null);
		right = new T22(mResources.CLOSE, this, 2, null);
	}

	public void M1885()
	{
		if (isGetName)
		{
			w = 170;
			h = 118;
			x = T51.w / 2 - w / 2;
			y = T51.h / 2 - h / 2;
		}
		else
		{
			w = 170;
			h = 170;
			x = T51.w / 2 - w / 2;
			y = T51.h / 2 - h / 2;
			if (T51.h < 240)
			{
				y -= 10;
			}
		}
		cmx = x;
		cmtoX = 0;
		if (!isRequest)
		{
			nItem = T17.vClanImage.M1113();
		}
		else
		{
			nItem = vItems.M1113();
		}
		if (T51.isTouch)
		{
			left.x = x;
			left.y = y + h + 5;
			right.x = x + w - 68;
			right.y = y + h + 5;
		}
		scrMain = new T140();
		scrMain.M1566(nItem, WIDTH, x, y + disStart, w, h - disStart, styleUPDOWN: true, 1);
	}

	public void M1886(bool isGetName)
	{
		if (T13.M113().clan != null)
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
		T157.M1783();
	}

	public void M1889(T99 g)
	{
	}

	public void M1890(T99 g)
	{
		g.M918(-cmx, 0);
		T133.M1481(g, x, y - 17, w, h + 17, -1, isButton: true);
		T98.tahoma_7b_dark.M898(g, mResources.select_clan_icon, x + w / 2, y - 7, 2);
		if (lastSelect >= 0 && lastSelect <= T17.vClanImage.M1113() - 1)
		{
			T17 t = (T17)T17.vClanImage.M1114(lastSelect);
			if (t.idImage != null)
			{
				T13.M113().M195(g, t.idImage, T51.w / 2, y + 45, 1, isPaintChar: false);
			}
		}
		T13.M113().M199(g, T51.w / 2, y + 45, 1, T13.M113().cf, isPaintBag: false);
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
				T17 t2 = (T17)T17.vClanImage.M1114(i);
				T98 t3 = T98.tahoma_7_grey;
				if (i == lastSelect)
				{
					t3 = T98.tahoma_7_blue;
				}
				if (t2.name != null)
				{
					t3.M898(g, t2.name, num + 20, num2, 0);
				}
				if (t2.xu > 0)
				{
					t3.M898(g, t2.xu + " " + mResources.XU, num + w - 20, num2, T98.RIGHT);
				}
				else if (t2.luong > 0)
				{
					t3.M898(g, t2.luong + " " + mResources.LUONG, num + w - 20, num2, T98.RIGHT);
				}
				if (t2.idImage != null)
				{
					T157.M1785(g, t2.idImage[0], num, num2, 0, 0);
				}
			}
		}
		g.M918(0, -g.M921());
		g.M922(0, 0, T51.w, T51.h);
		T51.paintz.M1208(g, left, center, right);
	}

	public void M1891(T99 g)
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
		if (T94.M869(cmtoX - cmx) < 10)
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
		if (left != null && (T51.keyPressed[12] || T108.M1034(left)))
		{
			left.M294();
		}
		if (right != null && (T51.keyPressed[13] || T108.M1034(right)))
		{
			right.M294();
		}
		if (center != null && (T51.keyPressed[(!Main.isPC) ? 5 : 25] || T108.M1034(center)))
		{
			center.M294();
		}
		if (!isGetName)
		{
			if (scrMain == null)
			{
				return;
			}
			if (T51.isTouch)
			{
				scrMain.M1561();
				select = scrMain.selectedItem;
			}
			if (T51.keyPressed[(!Main.isPC) ? 2 : 21])
			{
				T51.keyPressed[(!Main.isPC) ? 2 : 21] = false;
				select--;
				if (select < 0)
				{
					select = nItem - 1;
				}
				scrMain.M1567(select * scrMain.ITEM_SIZE);
			}
			if (T51.keyPressed[(!Main.isPC) ? 8 : 22])
			{
				T51.keyPressed[(!Main.isPC) ? 8 : 22] = false;
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
		T51.M484();
		T51.M483();
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
				if (T13.M113().clan == null)
				{
					T146.M1594().M1623(2, (sbyte)((T17)T17.vClanImage.M1114(lastSelect)).ID, text);
				}
				else
				{
					T146.M1594().M1623(4, (sbyte)((T17)T17.vClanImage.M1114(lastSelect)).ID, string.Empty);
				}
			}
		}
		else if (lastSelect >= 0)
		{
			_ = (T79)vItems.M1114(select);
		}
	}
}
