using System;

public class ChatPopup : Effect2, IActionListener
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

	public Npc c;

	private bool outSide;

	public static long curr;

	public static long last;

	private int currentLine;

	private string[] lines;

	public Command cmdNextLine;

	public Command cmdMsg1;

	public Command cmdMsg2;

	public static ChatPopup currChatPopup;

	public static ChatPopup serverChatPopUp;

	public static string nextMultiChatPopUp;

	public static Npc nextChar;

	public bool isShopDetail;

	public sbyte starSlot;

	public sbyte maxStarSlot;

	public static Scroll scr;

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

	private Image imgStar;

	public int strY;

	private int iconID;

	public bool isClip;

	public static int cmyText;

	private int pxx;

	private int pyy;

	static ChatPopup()
	{
		numSlot = 7;
	}

	public static void M267(string strNext, Npc next)
	{
		GameScr.info1.M762(strNext, 0);
	}

	public static void M268(string chat, int howLong, Npc c)
	{
	}

	public static void M269(string chat, int howLong, Npc c)
	{
		GameScr.info1.M762(chat, 0);
	}

	public static ChatPopup M270(string chat, int howLong, Npc c, int idIcon)
	{
		performDelay = 10;
		ChatPopup t = new ChatPopup();
		t.sayWidth = GameCanvas.w - 30 - (GameCanvas.menu.showMenu ? GameCanvas.menu.menuX : 0);
		if (t.sayWidth > 320)
		{
			t.sayWidth = 320;
		}
		if (chat.Length < 10)
		{
			t.sayWidth = 64;
		}
		if (GameCanvas.w == 128)
		{
			t.sayWidth = 128;
		}
		t.says = mFont.tahoma_7_red.M907(chat, t.sayWidth - 10);
		t.delay = howLong;
		t.c = c;
		t.iconID = idIcon;
		Char.chatPopup = t;
		t.ch = 15 - t.sayRun + t.says.Length * 12 + 10;
		if (t.ch > GameCanvas.h - 80)
		{
			t.ch = GameCanvas.h - 80;
		}
		t.mH = 10;
		if (GameCanvas.menu.showMenu)
		{
			t.mH = 0;
		}
		Effect2.vEffect2.M1111(t);
		isHavePetNpc = false;
		if (c != null && c.charID == 5)
		{
			isHavePetNpc = true;
			GameScr.info1.M762(string.Empty, 1);
		}
		curr = (last = mSystem.M1054());
		t.ch += 15;
		return t;
	}

	public static ChatPopup M271(string chat, int howLong, Npc c)
	{
		performDelay = 10;
		ChatPopup t = new ChatPopup();
		t.sayWidth = GameCanvas.w - 30 - (GameCanvas.menu.showMenu ? GameCanvas.menu.menuX : 0);
		if (t.sayWidth > 320)
		{
			t.sayWidth = 320;
		}
		if (chat.Length < 10)
		{
			t.sayWidth = 64;
		}
		if (GameCanvas.w == 128)
		{
			t.sayWidth = 128;
		}
		t.says = mFont.tahoma_7_red.M907(chat, t.sayWidth - 10);
		t.delay = howLong;
		t.c = c;
		Char.chatPopup = t;
		t.ch = 15 - t.sayRun + t.says.Length * 12 + 10;
		if (t.ch > GameCanvas.h - 80)
		{
			t.ch = GameCanvas.h - 80;
		}
		t.mH = 10;
		if (GameCanvas.menu.showMenu)
		{
			t.mH = 0;
		}
		Effect2.vEffect2.M1111(t);
		isHavePetNpc = false;
		if (c != null && c.charID == 5)
		{
			isHavePetNpc = true;
			GameScr.info1.M762(string.Empty, 1);
		}
		curr = (last = mSystem.M1054());
		return t;
	}

	public override void update()
	{
		if (scr != null)
		{
			GameScr.info1.isUpdate = false;
			scr.M1565();
		}
		else
		{
			GameScr.info1.isUpdate = true;
		}
		if (GameCanvas.menu.showMenu)
		{
			strY = 0;
			cx = GameCanvas.w / 2 - sayWidth / 2 - 1;
			cy = GameCanvas.menu.menuY - ch;
		}
		else
		{
			strY = 0;
			if (GameScr.M559().right == null && GameScr.M559().left == null && GameScr.M559().center == null && cmdNextLine == null && cmdMsg1 == null)
			{
				cx = GameCanvas.w / 2 - sayWidth / 2 - 1;
				cy = GameCanvas.h - 5 - ch;
			}
			else
			{
				strY = 5;
				cx = GameCanvas.w / 2 - sayWidth / 2 - 1;
				cy = GameCanvas.h - 20 - ch;
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
		if ((c != null && Char.chatPopup != null && Char.chatPopup != this) || (c != null && Char.chatPopup == null) || delay == 0)
		{
			Effect2.vEffect2Outside.M1119(this);
			Effect2.vEffect2.M1119(this);
		}
	}

	public override void paint(mGraphics g)
	{
		if (GameScr.M559().activeRongThan && GameScr.M559().isUseFreez)
		{
			return;
		}
		GameCanvas.M451(g);
		int num = cx;
		int num2 = cy;
		int num3 = sayWidth + 2;
		int num4 = ch;
		if ((num <= 0 || num2 <= 0) && !GameCanvas.panel.isShow)
		{
			return;
		}
		PopUp.M1481(g, num, num2, num3, num4, 16777215, isButton: false);
		if (c != null)
		{
			SmallImage.M1785(g, c.avatar, cx + 14, cy, 0, StaticObj.BOTTOM_LEFT);
		}
		if (iconID != 0)
		{
			SmallImage.M1785(g, iconID, cx + num3 / 2, cy + ch - 15, 0, StaticObj.VCENTER_HCENTER);
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
			mFont t = mFont.tahoma_7;
			int num6 = 2;
			string st = says[i];
			int num7 = 0;
			if (says[i].StartsWith("|"))
			{
				string[] array = Res.M1531(says[i], "|", 0);
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
				t = mFont.tahoma_7;
				break;
			case 0:
				t = mFont.tahoma_7b_dark;
				break;
			case 1:
				t = mFont.tahoma_7b_green;
				break;
			case 2:
				t = mFont.tahoma_7b_blue;
				break;
			case 3:
				t = mFont.tahoma_7_red;
				break;
			case 4:
				t = mFont.tahoma_7_green;
				break;
			case 5:
				t = mFont.tahoma_7_blue;
				break;
			case 7:
				t = mFont.tahoma_7b_red;
				break;
			case 8:
				t = mFont.tahoma_7b_yellow;
				break;
			}
			if (says[i].StartsWith("<"))
			{
				string[] array2 = Res.M1531(Res.M1531(says[i], "<", 0)[1], ">", 1);
				if (second == 0)
				{
					second = int.Parse(array2[1]);
				}
				else
				{
					curr = mSystem.M1054();
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
			GameCanvas.M451(g);
			g.M918(tx, ty);
		}
		if (maxStarSlot > 4)
		{
			nMaxslot_tren = (maxStarSlot + 1) / 2;
			nMaxslot_duoi = maxStarSlot - nMaxslot_tren;
			for (int j = 0; j < nMaxslot_tren; j++)
			{
				g.M948(Panel.imgMaxStar, num + num3 / 2 - nMaxslot_tren * 20 / 2 + j * 20 + mGraphics.M958(Panel.imgMaxStar), num2 + num4 - 17, 3);
			}
			for (int k = 0; k < nMaxslot_duoi; k++)
			{
				g.M948(Panel.imgMaxStar, num + num3 / 2 - nMaxslot_duoi * 20 / 2 + k * 20 + mGraphics.M958(Panel.imgMaxStar), num2 + num4 - 8, 3);
			}
			if (starSlot > 0)
			{
				imgStar = Panel.imgStar;
				if (starSlot >= nMaxslot_tren)
				{
					nslot_duoi = starSlot - nMaxslot_tren;
					for (int l = 0; l < nMaxslot_tren; l++)
					{
						g.M948(imgStar, num + num3 / 2 - nMaxslot_tren * 20 / 2 + l * 20 + mGraphics.M958(imgStar), num2 + num4 - 17, 3);
					}
					for (int m = 0; m < nslot_duoi; m++)
					{
						if (m + nMaxslot_tren >= numSlot)
						{
							imgStar = Panel.imgStar8;
						}
						g.M948(imgStar, num + num3 / 2 - nMaxslot_duoi * 20 / 2 + m * 20 + mGraphics.M958(imgStar), num2 + num4 - 8, 3);
					}
				}
				else
				{
					for (int n = 0; n < starSlot; n++)
					{
						g.M948(imgStar, num + num3 / 2 - nMaxslot_tren * 20 / 2 + n * 20 + mGraphics.M958(imgStar), num2 + num4 - 17, 3);
					}
				}
			}
		}
		else
		{
			for (int num8 = 0; num8 < maxStarSlot; num8++)
			{
				g.M948(Panel.imgMaxStar, num + num3 / 2 - maxStarSlot * 20 / 2 + num8 * 20 + mGraphics.M958(Panel.imgMaxStar), num2 + num4 - 13, 3);
			}
			if (starSlot > 0)
			{
				for (int num9 = 0; num9 < starSlot; num9++)
				{
					g.M948(Panel.imgStar, num + num3 / 2 - maxStarSlot * 20 / 2 + num9 * 20 + mGraphics.M958(Panel.imgStar), num2 + num4 - 13, 3);
				}
			}
		}
		M275(g);
	}

	public void M272(mGraphics g, int cmyText)
	{
		int num = cx;
		int num2 = cy;
		int num3 = sayWidth;
		int num4 = 0;
		int num5 = 0;
		num4 = g.M920();
		num5 = g.M921();
		g.M918(0, -cmyText);
		if ((num <= 0 || num2 <= 0) && !GameCanvas.panel.isShow)
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
			mFont t = mFont.tahoma_7_white;
			int num7 = 2;
			string st = says[i];
			int num8 = 0;
			if (says[i].StartsWith("|"))
			{
				string[] array = Res.M1531(says[i], "|", 0);
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
				t = mFont.tahoma_7_white;
				break;
			case 0:
				t = mFont.tahoma_7b_white;
				break;
			case 1:
				t = mFont.tahoma_7b_green;
				break;
			case 2:
				t = mFont.tahoma_7b_red;
				break;
			}
			if (says[i].StartsWith("<"))
			{
				string[] array2 = Res.M1531(Res.M1531(says[i], "<", 0)[1], ">", 1);
				if (second == 0)
				{
					second = int.Parse(array2[1]);
				}
				else
				{
					curr = mSystem.M1054();
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
		GameCanvas.M451(g);
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
			if (GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22])
			{
				GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22] = false;
				M273(1);
			}
			if (GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21])
			{
				GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21] = false;
				M273(-1);
			}
			if (GameCanvas.M481(cx, 0, sayWidth + 2, ch))
			{
				if (GameCanvas.isPointerMove)
				{
					if (pyy == 0)
					{
						pyy = GameCanvas.py;
					}
					pxx = pyy - GameCanvas.py;
					if (pxx != 0)
					{
						cmyText += pxx;
						pyy = GameCanvas.py;
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
			if (GameCanvas.isTouch)
			{
				scr.M1561();
			}
			if (GameCanvas.keyHold[(!Main.isPC) ? 2 : 21])
			{
				scr.cmtoY -= 12;
				if (scr.cmtoY < 0)
				{
					scr.cmtoY = 0;
				}
			}
			if (GameCanvas.keyHold[(!Main.isPC) ? 8 : 22])
			{
				GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22] = false;
				scr.cmtoY += 12;
				if (scr.cmtoY > scr.cmyLim)
				{
					scr.cmtoY = scr.cmyLim;
				}
			}
		}
		if (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] || mScreen.M1034(GameCanvas.currentScreen.center))
		{
			GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
			mScreen.keyTouch = -1;
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
			if (cmdMsg1 != null && (GameCanvas.keyPressed[12] || GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] || mScreen.M1034(cmdMsg1)))
			{
				GameCanvas.keyPressed[12] = false;
				GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
				GameCanvas.isPointerClick = false;
				GameCanvas.isPointerJustRelease = false;
				cmdMsg1.M294();
				mScreen.keyTouch = -1;
			}
			if (cmdMsg2 != null && (GameCanvas.keyPressed[13] || mScreen.M1034(cmdMsg2)))
			{
				GameCanvas.keyPressed[13] = false;
				GameCanvas.isPointerClick = false;
				GameCanvas.isPointerJustRelease = false;
				cmdMsg2.M294();
				mScreen.keyTouch = -1;
			}
		}
	}

	public void M275(mGraphics g)
	{
		g.M918(-g.M920(), -g.M921());
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
		GameCanvas.paintz.M1209(g);
		if (cmdNextLine != null)
		{
			GameCanvas.paintz.M1208(g, null, cmdNextLine, null);
		}
		if (cmdMsg1 != null)
		{
			GameCanvas.paintz.M1208(g, cmdMsg1, null, cmdMsg2);
		}
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
		{
			try
			{
				GameMidlet.instance.M524((string)p);
			}
			catch (Exception)
			{
			}
			if (!Main.isPC)
			{
				GameMidlet.instance.M523();
			}
			else
			{
				idAction = 1001;
			}
			GameCanvas.M488();
		}
		if (idAction == 1001)
		{
			scr = null;
			Char.chatPopup = null;
			serverChatPopUp = null;
			GameScr.info1.isUpdate = true;
			Char.isLockKey = false;
			if (isHavePetNpc)
			{
				GameScr.info1.info.time = 0;
				GameScr.info1.info.info.speed = 10;
			}
		}
		if (idAction != 8000 || performDelay > 0)
		{
			return;
		}
		int num = currChatPopup.currentLine + 1;
		if (num >= currChatPopup.lines.Length)
		{
			Char.chatPopup = null;
			currChatPopup = null;
			GameScr.info1.isUpdate = true;
			Char.isLockKey = false;
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
				GameScr.info1.info.time = 0;
				for (int i = 0; i < GameScr.info1.info.infoWaitToShow.M1113(); i++)
				{
					if (((InfoItem)GameScr.info1.info.infoWaitToShow.M1114(i)).speed == 10000000)
					{
						((InfoItem)GameScr.info1.info.infoWaitToShow.M1114(i)).speed = 10;
					}
				}
			}
		}
		else
		{
			ChatPopup t = M271(currChatPopup.lines[num], currChatPopup.delay, currChatPopup.c);
			t.currentLine = num;
			t.lines = currChatPopup.lines;
			t.cmdNextLine = currChatPopup.cmdNextLine;
			currChatPopup = t;
		}
	}
}
