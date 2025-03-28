public class PopUp
{
	public static MyVector vPopups = new MyVector();

	public int sayWidth;

	public int sayRun;

	public string[] says;

	public int cx;

	public int cy;

	public int cw;

	public int ch;

	public static int f;

	public static int tF;

	public static int dir;

	public bool isWayPoint;

	public int tDelay;

	private int timeDelay;

	public Command command;

	public bool isPaint = true;

	public bool isHide;

	public static Image goc;

	public static Image imgPopUp;

	public static Image imgPopUp2;

	public Image imgFocus;

	public Image imgUnFocus;

	public PopUp(string info, int x, int y)
	{
		sayWidth = 100;
		if (info.Length < 10)
		{
			sayWidth = 60;
		}
		if (GameCanvas.w == 128)
		{
			sayWidth = 128;
		}
		says = mFont.tahoma_7b_dark.M907(info, sayWidth - 10);
		sayRun = 7;
		cx = x - sayWidth / 2 - 1;
		cy = y - 15 + sayRun - says.Length * 12 - 10;
		cw = sayWidth + 2;
		ch = (says.Length + 1) * 12 + 1;
		while (cw % 10 != 0)
		{
			cw++;
		}
		while (ch % 10 != 0)
		{
			ch++;
		}
		if (x >= 0 && x <= 24)
		{
			cx += cw / 2 + 30;
		}
		if (x <= TileMap.tmw * 24 && x >= TileMap.tmw * 24 - 24)
		{
			cx -= cw / 2 + 6;
		}
		while (cx <= 30)
		{
			cx += 2;
		}
		while (cx + cw >= TileMap.tmw * 24 - 30)
		{
			cx -= 2;
		}
	}

	public static void M1475()
	{
		if (goc == null)
		{
			goc = GameCanvas.M503("/mainImage/myTexture2dbd3.png");
		}
		if (imgPopUp == null)
		{
			imgPopUp = GameCanvas.M503("/mainImage/myTexture2dimgPopup.png");
		}
		if (imgPopUp2 == null)
		{
			imgPopUp2 = GameCanvas.M503("/mainImage/myTexture2dimgPopup2.png");
		}
	}

	public void M1476(string[] info, int x, int y)
	{
		sayWidth = 0;
		for (int i = 0; i < info.Length; i++)
		{
			if (sayWidth < mFont.tahoma_7b_dark.M909(info[i]))
			{
				sayWidth = mFont.tahoma_7b_dark.M909(info[i]);
			}
		}
		sayWidth += 20;
		says = info;
		sayRun = 7;
		cx = x - sayWidth / 2 - 1;
		cy = y - 15 + sayRun - says.Length * 12 - 10;
		cw = sayWidth + 2;
		ch = (says.Length + 1) * 12 + 1;
		while (cw % 10 != 0)
		{
			cw++;
		}
		while (ch % 10 != 0)
		{
			ch++;
		}
		if (x >= 0 && x <= 24)
		{
			cx += cw / 2 + 30;
		}
		if (x <= TileMap.tmw * 24 && x >= TileMap.tmw * 24 - 24)
		{
			cx -= cw / 2 + 6;
		}
		while (cx <= 30)
		{
			cx += 2;
		}
		while (cx + cw >= TileMap.tmw * 24 - 30)
		{
			cx -= 2;
		}
	}

	public static void M1477(int x, int y, string info)
	{
		vPopups.M1111(new PopUp(info, x, y));
	}

	public static void M1478(PopUp p)
	{
		vPopups.M1111(p);
	}

	public static void M1479(PopUp p)
	{
		vPopups.M1119(p);
	}

	public void M1480(mGraphics g, int x, int y, int w, int h, int color, bool isFocus)
	{
		if (color == 1)
		{
			g.M927(x, y, w, h, 16777215, 90);
		}
		else
		{
			g.M927(x, y, w, h, 0, 77);
		}
	}

	public static void M1481(mGraphics g, int x, int y, int w, int h, int color, bool isButton)
	{
		if (!isButton)
		{
			g.M933(0);
			g.M932(x + 6, y, w - 14 + 1, h);
			g.M932(x, y + 6, w, h - 12 + 1);
			g.M933(color);
			g.M932(x + 6, y + 1, w - 12, h - 2);
			g.M932(x + 1, y + 6, w - 2, h - 12);
			g.M940(goc, 0, 0, 7, 6, 0, x, y, 0);
			g.M940(goc, 0, 0, 7, 6, 2, x + w - 7, y, 0);
			g.M940(goc, 0, 0, 7, 6, 1, x, y + h - 6, 0);
			g.M940(goc, 0, 0, 7, 6, 3, x + w - 7, y + h - 6, 0);
			return;
		}
		Image arg = ((color != 1) ? imgPopUp : imgPopUp2);
		g.M940(arg, 0, 0, 10, 10, 0, x, y, 0);
		g.M940(arg, 0, 20, 10, 10, 0, x + w - 10, y, 0);
		g.M940(arg, 0, 50, 10, 10, 0, x, y + h - 10, 0);
		g.M940(arg, 0, 70, 10, 10, 0, x + w - 10, y + h - 10, 0);
		int num = (((w - 20) % 10 != 0) ? ((w - 20) / 10 + 1) : ((w - 20) / 10));
		int num2 = (((h - 20) % 10 != 0) ? ((h - 20) / 10 + 1) : ((h - 20) / 10));
		for (int i = 0; i < num; i++)
		{
			g.M940(arg, 0, 10, 10, 10, 0, x + 10 + i * 10, y, 0);
		}
		for (int j = 0; j < num2; j++)
		{
			g.M940(arg, 0, 30, 10, 10, 0, x, y + 10 + j * 10, 0);
		}
		for (int k = 0; k < num; k++)
		{
			g.M940(arg, 0, 60, 10, 10, 0, x + 10 + k * 10, y + h - 10, 0);
		}
		for (int l = 0; l < num2; l++)
		{
			g.M940(arg, 0, 40, 10, 10, 0, x + w - 10, y + 10 + l * 10, 0);
		}
		g.M933((color != 1) ? 16770503 : 12052656);
		g.M932(x + 10, y + 10, w - 20, h - 20);
	}

	public void M1482(mGraphics g)
	{
		if (isPaint && says != null && ChatPopup.currChatPopup == null && !isHide)
		{
			M1480(g, cx, cy - GameCanvas.transY, cw, ch, (timeDelay != 0) ? 1 : 0, isFocus: true);
			for (int i = 0; i < says.Length; i++)
			{
				((timeDelay != 0) ? mFont.tahoma_7b_green2 : mFont.tahoma_7b_white).M898(g, says[i], cx + cw / 2, cy + (ch / 2 - says.Length * 12 / 2) + i * 12 - GameCanvas.transY, 2);
			}
		}
	}

	private void M1483()
	{
		if (Char.M113().taskMaint != null && Char.M113().taskMaint.taskId == 0)
		{
			if (cx + cw >= GameScr.cmx && cx <= GameCanvas.w + GameScr.cmx && cy + ch >= GameScr.cmy && cy <= GameCanvas.h + GameScr.cmy)
			{
				isHide = false;
			}
			else
			{
				isHide = true;
			}
		}
		if (Char.M113().taskMaint == null || (Char.M113().taskMaint != null && Char.M113().taskMaint.taskId != 0))
		{
			if (cx + cw / 2 >= Char.M113().cx - 100 && cx + cw / 2 <= Char.M113().cx + 100 && cy + ch >= GameScr.cmy && cy <= GameCanvas.h + GameScr.cmy)
			{
				isHide = false;
			}
			else
			{
				isHide = true;
			}
		}
		if (timeDelay > 0)
		{
			timeDelay--;
			if (timeDelay == 0 && command != null)
			{
				command.M294();
			}
		}
		if (!isWayPoint)
		{
			return;
		}
		if (Char.M113().taskMaint != null)
		{
			if (Char.M113().taskMaint.taskId == 0)
			{
				if (Char.M113().taskMaint.index == 0)
				{
					isPaint = false;
				}
				if (Char.M113().taskMaint.index == 1)
				{
					isPaint = true;
				}
				if (Char.M113().taskMaint.index > 1 && Char.M113().taskMaint.index < 6)
				{
					isPaint = false;
				}
			}
			else if (!isPaint)
			{
				tDelay++;
				if (tDelay == 50)
				{
					isPaint = true;
				}
			}
		}
		else if (!isPaint)
		{
			Hint.isPaint = false;
			tDelay++;
			if (tDelay == 50)
			{
				isPaint = true;
				Hint.isPaint = true;
			}
		}
	}

	public void M1484(int timeDelay)
	{
		this.timeDelay = timeDelay;
	}

	public static void M1485(mGraphics g)
	{
		for (int i = 0; i < vPopups.M1113(); i++)
		{
			((PopUp)vPopups.M1114(i)).M1482(g);
		}
	}

	public static void M1486()
	{
		for (int i = 0; i < vPopups.M1113(); i++)
		{
			((PopUp)vPopups.M1114(i)).M1483();
		}
	}
}
