using System;

public class T14 : T33, T57
{
	public int sayWidth = 100;

	public int delay;

	public int sayRun;

	public string[] says;

	public int cx;

	public int cy;

	public int ch;

	public int cmx;

	public int cmy;

	public int lim;

	public T123 c;

	private bool outSide;

	public static long curr;

	public static long last;

	private int currentLine;

	private string[] lines;

	public T22 cmdNextLine;

	public T22 cmdMsg1;

	public T22 cmdMsg2;

	public static T14 currChatPopup;

	public static T14 serverChatPopUp;

	public static string nextMultiChatPopUp;

	public static T123 nextChar;

	public bool isShopDetail;

	public sbyte starSlot;

	public sbyte maxStarSlot;

	public static T140 scr;

	public static bool isHavePetNpc;

	public int mH;

	public static int performDelay;

	public int dx;

	public int dy;

	public int second;

	public static int numSlot;

	private int nMaxslot_duoi;

	private int nMaxslot_tren;

	private int nslot_duoi;

	private T60 imgStar;

	public int strY;

	private int iconID;

	public bool isClip;

	public static int cmyText;

	private int pxx;

	private int pyy;

	static T14()
	{
		numSlot = 7;
	}

	public static void M267(string strNext, T123 next)
	{
		T54.info1.M762(strNext, 0);
	}

	public static void M268(string chat, int howLong, T123 c)
	{
	}

	public static void M269(string chat, int howLong, T123 c)
	{
		T54.info1.M762(chat, 0);
	}

	public static T14 M270(string chat, int howLong, T123 c, int idIcon)
	{
		performDelay = 10;
		T14 t = new T14();
		t.sayWidth = T51.w - 30 - (T51.menu.showMenu ? T51.menu.menuX : 0);
		if (t.sayWidth > 320)
		{
			t.sayWidth = 320;
		}
		if (chat.Length < 10)
		{
			t.sayWidth = 64;
		}
		if (T51.w == 128)
		{
			t.sayWidth = 128;
		}
		t.says = T98.tahoma_7_red.M907(chat, t.sayWidth - 10);
		t.delay = howLong;
		t.c = c;
		t.iconID = idIcon;
		T13.chatPopup = t;
		t.ch = 15 - t.sayRun + t.says.Length * 12 + 10;
		if (t.ch > T51.h - 80)
		{
			t.ch = T51.h - 80;
		}
		t.mH = 10;
		if (T51.menu.showMenu)
		{
			t.mH = 0;
		}
		T33.vEffect2.M1111(t);
		isHavePetNpc = false;
		if (c != null && c.charID == 5)
		{
			isHavePetNpc = true;
			T54.info1.M762(string.Empty, 1);
		}
		curr = (last = T110.M1054());
		t.ch += 15;
		return t;
	}

	public static T14 M271(string chat, int howLong, T123 c)
	{
		performDelay = 10;
		T14 t = new T14();
		t.sayWidth = T51.w - 30 - (T51.menu.showMenu ? T51.menu.menuX : 0);
		if (t.sayWidth > 320)
		{
			t.sayWidth = 320;
		}
		if (chat.Length < 10)
		{
			t.sayWidth = 64;
		}
		if (T51.w == 128)
		{
			t.sayWidth = 128;
		}
		t.says = T98.tahoma_7_red.M907(chat, t.sayWidth - 10);
		t.delay = howLong;
		t.c = c;
		T13.chatPopup = t;
		t.ch = 15 - t.sayRun + t.says.Length * 12 + 10;
		if (t.ch > T51.h - 80)
		{
			t.ch = T51.h - 80;
		}
		t.mH = 10;
		if (T51.menu.showMenu)
		{
			t.mH = 0;
		}
		T33.vEffect2.M1111(t);
		isHavePetNpc = false;
		if (c != null && c.charID == 5)
		{
			isHavePetNpc = true;
			T54.info1.M762(string.Empty, 1);
		}
		curr = (last = T110.M1054());
		return t;
	}

	public override void update()
	{
		if (scr != null)
		{
			T54.info1.isUpdate = false;
			scr.M1565();
		}
		else
		{
			T54.info1.isUpdate = true;
		}
		if (T51.menu.showMenu)
		{
			strY = 0;
			cx = T51.w / 2 - sayWidth / 2 - 1;
			cy = T51.menu.menuY - ch;
		}
		else
		{
			strY = 0;
			if (T54.M559().right == null && T54.M559().left == null && T54.M559().center == null && cmdNextLine == null && cmdMsg1 == null)
			{
				cx = T51.w / 2 - sayWidth / 2 - 1;
				cy = T51.h - 5 - ch;
			}
			else
			{
				strY = 5;
				cx = T51.w / 2 - sayWidth / 2 - 1;
				cy = T51.h - 20 - ch;
			}
		}
		if (delay > 0)
		{
			delay--;
		}
		if (performDelay > 0)
		{
			performDelay--;
		}
		if (sayRun > 1)
		{
			sayRun--;
		}
		if ((c != null && T13.chatPopup != null && T13.chatPopup != this) || (c != null && T13.chatPopup == null) || delay == 0)
		{
			T33.vEffect2Outside.M1119(this);
			T33.vEffect2.M1119(this);
		}
	}

	public override void paint(T99 g)
	{
		if (T54.M559().activeRongThan && T54.M559().isUseFreez)
		{
			return;
		}
		T51.M451(g);
		int num = cx;
		int num2 = cy;
		int num3 = sayWidth + 2;
		int num4 = ch;
		if ((num <= 0 || num2 <= 0) && !T51.panel.isShow)
		{
			return;
		}
		T133.M1481(g, num, num2, num3, num4, 16777215, isButton: false);
		if (c != null)
		{
			T157.M1785(g, c.avatar, cx + 14, cy, 0, T163.BOTTOM_LEFT);
		}
		if (iconID != 0)
		{
			T157.M1785(g, iconID, cx + num3 / 2, cy + ch - 15, 0, T163.VCENTER_HCENTER);
		}
		if (scr != null)
		{
			g.M922(num, num2, num3, num4 - 16);
			g.M918(0, -scr.cmy);
		}
		int tx = 0;
		int ty = 0;
		if (isClip)
		{
			tx = g.M920();
			ty = g.M921();
			g.M922(num, num2 + 1, num3, num4 - 17);
			g.M918(0, -cmyText);
		}
		int num5 = -1;
		for (int i = 0; i < says.Length; i++)
		{
			if (says[i].StartsWith("--"))
			{
				g.M933(0);
				g.M932(num + 10, cy + sayRun + i * 12 + 6, num3 - 20, 1);
				continue;
			}
			T98 t = T98.tahoma_7;
			int num6 = 2;
			string st = says[i];
			int num7 = 0;
			if (says[i].StartsWith("|"))
			{
				string[] array = T137.M1531(says[i], "|", 0);
				if (array.Length == 3)
				{
					st = array[2];
				}
				if (array.Length == 4)
				{
					st = array[3];
					num6 = int.Parse(array[2]);
				}
				num7 = int.Parse(array[1]);
				num5 = num7;
			}
			else
			{
				num7 = num5;
			}
			switch (num7)
			{
			case -1:
				t = T98.tahoma_7;
				break;
			case 0:
				t = T98.tahoma_7b_dark;
				break;
			case 1:
				t = T98.tahoma_7b_green;
				break;
			case 2:
				t = T98.tahoma_7b_blue;
				break;
			case 3:
				t = T98.tahoma_7_red;
				break;
			case 4:
				t = T98.tahoma_7_green;
				break;
			case 5:
				t = T98.tahoma_7_blue;
				break;
			case 7:
				t = T98.tahoma_7b_red;
				break;
			case 8:
				t = T98.tahoma_7b_yellow;
				break;
			}
			if (says[i].StartsWith("<"))
			{
				string[] array2 = T137.M1531(T137.M1531(says[i], "<", 0)[1], ">", 1);
				if (second == 0)
				{
					second = int.Parse(array2[1]);
				}
				else
				{
					curr = T110.M1054();
					if (curr - last >= 1000L)
					{
						last = curr;
						second--;
					}
				}
				t.M898(g, second + " " + array2[2], cx + sayWidth / 2, cy + sayRun + i * 12 - strY + 12, num6);
			}
			else
			{
				if (num6 == 2)
				{
					t.M898(g, st, cx + sayWidth / 2, cy + sayRun + i * 12 - strY + 12, num6);
				}
				if (num6 == 1)
				{
					t.M898(g, st, cx + sayWidth - 5, cy + sayRun + i * 12 - strY + 12, num6);
				}
			}
		}
		if (isClip)
		{
			T51.M451(g);
			g.M918(tx, ty);
		}
		if (maxStarSlot > 4)
		{
			nMaxslot_tren = (maxStarSlot + 1) / 2;
			nMaxslot_duoi = maxStarSlot - nMaxslot_tren;
			for (int j = 0; j < nMaxslot_tren; j++)
			{
				g.M948(T126.imgMaxStar, num + num3 / 2 - nMaxslot_tren * 20 / 2 + j * 20 + T99.M958(T126.imgMaxStar), num2 + num4 - 17, 3);
			}
			for (int k = 0; k < nMaxslot_duoi; k++)
			{
				g.M948(T126.imgMaxStar, num + num3 / 2 - nMaxslot_duoi * 20 / 2 + k * 20 + T99.M958(T126.imgMaxStar), num2 + num4 - 8, 3);
			}
			if (starSlot > 0)
			{
				imgStar = T126.imgStar;
				if (starSlot >= nMaxslot_tren)
				{
					nslot_duoi = starSlot - nMaxslot_tren;
					for (int l = 0; l < nMaxslot_tren; l++)
					{
						g.M948(imgStar, num + num3 / 2 - nMaxslot_tren * 20 / 2 + l * 20 + T99.M958(imgStar), num2 + num4 - 17, 3);
					}
					for (int m = 0; m < nslot_duoi; m++)
					{
						if (m + nMaxslot_tren >= numSlot)
						{
							imgStar = T126.imgStar8;
						}
						g.M948(imgStar, num + num3 / 2 - nMaxslot_duoi * 20 / 2 + m * 20 + T99.M958(imgStar), num2 + num4 - 8, 3);
					}
				}
				else
				{
					for (int n = 0; n < starSlot; n++)
					{
						g.M948(imgStar, num + num3 / 2 - nMaxslot_tren * 20 / 2 + n * 20 + T99.M958(imgStar), num2 + num4 - 17, 3);
					}
				}
			}
		}
		else
		{
			for (int num8 = 0; num8 < maxStarSlot; num8++)
			{
				g.M948(T126.imgMaxStar, num + num3 / 2 - maxStarSlot * 20 / 2 + num8 * 20 + T99.M958(T126.imgMaxStar), num2 + num4 - 13, 3);
			}
			if (starSlot > 0)
			{
				for (int num9 = 0; num9 < starSlot; num9++)
				{
					g.M948(T126.imgStar, num + num3 / 2 - maxStarSlot * 20 / 2 + num9 * 20 + T99.M958(T126.imgStar), num2 + num4 - 13, 3);
				}
			}
		}
		M275(g);
	}

	public void M272(T99 g, int cmyText)
	{
		int num = cx;
		int num2 = cy;
		int num3 = sayWidth;
		int num4 = 0;
		int num5 = 0;
		num4 = g.M920();
		num5 = g.M921();
		g.M918(0, -cmyText);
		if ((num <= 0 || num2 <= 0) && !T51.panel.isShow)
		{
			return;
		}
		int num6 = -1;
		for (int i = 0; i < says.Length; i++)
		{
			if (says[i].StartsWith("--"))
			{
				g.M933(16777215);
				g.M932(num + 10, cy + sayRun + i * 12 - 6, num3 - 20, 1);
				continue;
			}
			T98 t = T98.tahoma_7_white;
			int num7 = 2;
			string st = says[i];
			int num8 = 0;
			if (says[i].StartsWith("|"))
			{
				string[] array = T137.M1531(says[i], "|", 0);
				if (array.Length == 3)
				{
					st = array[2];
				}
				if (array.Length == 4)
				{
					st = array[3];
					num7 = int.Parse(array[2]);
				}
				num8 = int.Parse(array[1]);
				num6 = num8;
			}
			else
			{
				num8 = num6;
			}
			switch (num8)
			{
			case -1:
				t = T98.tahoma_7_white;
				break;
			case 0:
				t = T98.tahoma_7b_white;
				break;
			case 1:
				t = T98.tahoma_7b_green;
				break;
			case 2:
				t = T98.tahoma_7b_red;
				break;
			}
			if (says[i].StartsWith("<"))
			{
				string[] array2 = T137.M1531(T137.M1531(says[i], "<", 0)[1], ">", 1);
				if (second == 0)
				{
					second = int.Parse(array2[1]);
				}
				else
				{
					curr = T110.M1054();
					if (curr - last >= 1000L)
					{
						last = curr;
						second--;
					}
				}
				t.M898(g, second + " " + array2[2], cx + sayWidth / 2, cy + sayRun + i * 12 - strY, num7);
			}
			else
			{
				if (num7 == 2)
				{
					t.M898(g, st, cx + sayWidth / 2, cy + sayRun + i * 12 - strY, num7);
				}
				if (num7 == 1)
				{
					t.M898(g, st, cx + sayWidth - 5, cy + sayRun + i * 12 - strY, num7);
				}
			}
		}
		T51.M451(g);
		g.M918(num4, num5);
	}

	private void M273(int type)
	{
		cmyText += 12 * type;
		if (cmyText < 0)
		{
			cmyText = 0;
		}
		if (cmyText > lim)
		{
			cmyText = lim;
		}
	}

	public void M274()
	{
		if (isClip)
		{
			if (T51.keyPressed[(!Main.isPC) ? 8 : 22])
			{
				T51.keyPressed[(!Main.isPC) ? 8 : 22] = false;
				M273(1);
			}
			if (T51.keyPressed[(!Main.isPC) ? 2 : 21])
			{
				T51.keyPressed[(!Main.isPC) ? 2 : 21] = false;
				M273(-1);
			}
			if (T51.M481(cx, 0, sayWidth + 2, ch))
			{
				if (T51.isPointerMove)
				{
					if (pyy == 0)
					{
						pyy = T51.py;
					}
					pxx = pyy - T51.py;
					if (pxx != 0)
					{
						cmyText += pxx;
						pyy = T51.py;
					}
					if (cmyText < 0)
					{
						cmyText = 0;
					}
					if (cmyText > lim)
					{
						cmyText = lim;
					}
				}
				else
				{
					pyy = 0;
					pyy = 0;
				}
			}
		}
		if (scr != null)
		{
			if (T51.isTouch)
			{
				scr.M1561();
			}
			if (T51.keyHold[(!Main.isPC) ? 2 : 21])
			{
				scr.cmtoY -= 12;
				if (scr.cmtoY < 0)
				{
					scr.cmtoY = 0;
				}
			}
			if (T51.keyHold[(!Main.isPC) ? 8 : 22])
			{
				T51.keyPressed[(!Main.isPC) ? 8 : 22] = false;
				scr.cmtoY += 12;
				if (scr.cmtoY > scr.cmyLim)
				{
					scr.cmtoY = scr.cmyLim;
				}
			}
		}
		if (T51.keyPressed[(!Main.isPC) ? 5 : 25] || T108.M1034(T51.currentScreen.center))
		{
			T51.keyPressed[(!Main.isPC) ? 5 : 25] = false;
			T108.keyTouch = -1;
			if (cmdNextLine != null)
			{
				cmdNextLine.M294();
			}
			else if (cmdMsg1 != null)
			{
				cmdMsg1.M294();
			}
			else if (cmdMsg2 != null)
			{
				cmdMsg2.M294();
			}
		}
		if (scr == null || !scr.pointerIsDowning)
		{
			if (cmdMsg1 != null && (T51.keyPressed[12] || T51.keyPressed[(!Main.isPC) ? 5 : 25] || T108.M1034(cmdMsg1)))
			{
				T51.keyPressed[12] = false;
				T51.keyPressed[(!Main.isPC) ? 5 : 25] = false;
				T51.isPointerClick = false;
				T51.isPointerJustRelease = false;
				cmdMsg1.M294();
				T108.keyTouch = -1;
			}
			if (cmdMsg2 != null && (T51.keyPressed[13] || T108.M1034(cmdMsg2)))
			{
				T51.keyPressed[13] = false;
				T51.isPointerClick = false;
				T51.isPointerJustRelease = false;
				cmdMsg2.M294();
				T108.keyTouch = -1;
			}
		}
	}

	public void M275(T99 g)
	{
		g.M918(-g.M920(), -g.M921());
		g.M922(0, 0, T51.w, T51.h);
		T51.paintz.M1209(g);
		if (cmdNextLine != null)
		{
			T51.paintz.M1208(g, null, cmdNextLine, null);
		}
		if (cmdMsg1 != null)
		{
			T51.paintz.M1208(g, cmdMsg1, null, cmdMsg2);
		}
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
		{
			try
			{
				T52.instance.M524((string)p);
			}
			catch (Exception)
			{
			}
			if (!Main.isPC)
			{
				T52.instance.M523();
			}
			else
			{
				idAction = 1001;
			}
			T51.M488();
		}
		if (idAction == 1001)
		{
			scr = null;
			T13.chatPopup = null;
			serverChatPopUp = null;
			T54.info1.isUpdate = true;
			T13.isLockKey = false;
			if (isHavePetNpc)
			{
				T54.info1.info.time = 0;
				T54.info1.info.info.speed = 10;
			}
		}
		if (idAction != 8000 || performDelay > 0)
		{
			return;
		}
		int num = currChatPopup.currentLine + 1;
		if (num >= currChatPopup.lines.Length)
		{
			T13.chatPopup = null;
			currChatPopup = null;
			T54.info1.isUpdate = true;
			T13.isLockKey = false;
			if (nextMultiChatPopUp != null)
			{
				num = 0;
				M269(nextMultiChatPopUp, 100000, nextChar);
				nextMultiChatPopUp = null;
				nextChar = null;
			}
			else
			{
				if (!isHavePetNpc)
				{
					return;
				}
				T54.info1.info.time = 0;
				for (int i = 0; i < T54.info1.info.infoWaitToShow.M1113(); i++)
				{
					if (((T67)T54.info1.info.infoWaitToShow.M1114(i)).speed == 10000000)
					{
						((T67)T54.info1.info.infoWaitToShow.M1114(i)).speed = 10;
					}
				}
			}
		}
		else
		{
			T14 t = M271(currChatPopup.lines[num], currChatPopup.delay, currChatPopup.c);
			t.currentLine = num;
			t.lines = currChatPopup.lines;
			t.cmdNextLine = currChatPopup.cmdNextLine;
			currChatPopup = t;
		}
	}
}
