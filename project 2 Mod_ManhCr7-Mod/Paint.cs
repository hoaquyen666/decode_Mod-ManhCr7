public class Paint
{
	public static int COLORBACKGROUND = 15787715;

	public static int COLORLIGHT = 16383818;

	public static int COLORDARK = 3937280;

	public static int COLORBORDER = 15224576;

	public static int COLORFOCUS = 16777215;

	public static Image imgBg;

	public static Image imgLogo;

	public static Image imgLB;

	public static Image imgLT;

	public static Image imgRB;

	public static Image imgRT;

	public static Image imgChuong;

	public static Image imgSelectBoard;

	public static Image imgtoiSmall;

	public static Image imgTayTren;

	public static Image imgTayDuoi;

	public static Image[] imgTick = new Image[2];

	public static Image[] imgMsg = new Image[2];

	public static Image[] goc = new Image[6];

	public static int hTab = 24;

	public static int lenCaption = 0;

	public int[] color = new int[7] { 15970400, 13479911, 2250052, 16374659, 15906669, 12931125, 3108954 };

	public static Image imgCheck = GameCanvas.M503("/mainImage/myTexture2dcheck.png");

	public static void M1200()
	{
		for (int i = 0; i < goc.Length; i++)
		{
			goc[i] = GameCanvas.M503("/mainImage/myTexture2dgoc" + (i + 1) + ".png");
		}
	}

	public void M1201(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M933(8916494);
		g.M932(0, 0, GameCanvas.w, GameCanvas.h);
		g.M948(imgBg, GameCanvas.w / 2, GameCanvas.h / 2 - hTab / 2 - 1, 3);
		g.M948(imgLT, 0, 0, 0);
		g.M948(imgRT, GameCanvas.w, 0, mGraphics.TOP | mGraphics.RIGHT);
		g.M948(imgLB, 0, GameCanvas.h - hTab - 2, mGraphics.BOTTOM | mGraphics.LEFT);
		g.M948(imgRB, GameCanvas.w, GameCanvas.h - hTab - 2, mGraphics.BOTTOM | mGraphics.RIGHT);
		g.M933(16774843);
		g.M931(0, 0, GameCanvas.w, 0);
		g.M931(0, GameCanvas.h - hTab - 2, GameCanvas.w, 0);
		g.M931(0, 0, 0, GameCanvas.h - hTab);
		g.M931(GameCanvas.w - 1, 0, 0, GameCanvas.h - hTab);
	}

	public void M1202(mGraphics g)
	{
		g.M933(205314);
		g.M932(0, 0, GameCanvas.w, GameCanvas.h);
	}

	public void M1203()
	{
	}

	public void M1204(mGraphics g)
	{
	}

	public void M1205(mGraphics g, int x, int y, int w, int h)
	{
		g.M933(8411138);
		g.M932(x, y, w, h);
		g.M933(13606712);
		g.M931(x, y, w, h);
	}

	public void M1206(mGraphics g, int y, int x, int width, int height)
	{
		g.M933(16776363);
		g.M932(x, y, width, height);
		g.M933(0);
		g.M931(x - 1, y - 1, width + 1, height + 1);
	}

	public void M1207(mGraphics g, int h)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M933(14279153);
		g.M932(8, GameCanvas.h - (h + 37), GameCanvas.w - 16, h + 4);
		g.M933(4682453);
		g.M932(10, GameCanvas.h - (h + 35), GameCanvas.w - 20, h);
	}

	public void M1208(mGraphics g, Command left, Command center, Command right)
	{
		mFont t = ((!GameCanvas.isTouch) ? mFont.tahoma_7b_dark : mFont.tahoma_7b_dark);
		int num = 3;
		if (left != null)
		{
			lenCaption = t.M909(left.caption);
			if (lenCaption > 0)
			{
				if (left.x >= 0 && left.y > 0)
				{
					left.M296(g);
				}
				else
				{
					g.M948((mScreen.keyTouch != 0) ? GameScr.imgLbtn : GameScr.imgLbtnFocus, 1, GameCanvas.h - mScreen.cmdH - 1, 0);
					t.M898(g, left.caption, 35, GameCanvas.h - mScreen.cmdH + 3 + num, 2);
				}
			}
		}
		if (center != null)
		{
			lenCaption = t.M909(center.caption);
			if (lenCaption > 0)
			{
				if (center.x > 0 && center.y > 0)
				{
					center.M296(g);
				}
				else
				{
					g.M948((mScreen.keyTouch != 1) ? GameScr.imgLbtn : GameScr.imgLbtnFocus, GameCanvas.hw - 35, GameCanvas.h - mScreen.cmdH - 1, 0);
					t.M898(g, center.caption, GameCanvas.hw, GameCanvas.h - mScreen.cmdH + 3 + num, 2);
				}
			}
		}
		if (right == null)
		{
			return;
		}
		lenCaption = t.M909(right.caption);
		if (lenCaption > 0)
		{
			if (right.x > 0 && right.y > 0)
			{
				right.M296(g);
				return;
			}
			g.M948((mScreen.keyTouch != 2) ? GameScr.imgLbtn : GameScr.imgLbtnFocus, GameCanvas.w - 71, GameCanvas.h - mScreen.cmdH - 1, 0);
			t.M898(g, right.caption, GameCanvas.w - 35, GameCanvas.h - mScreen.cmdH + 3 + num, 2);
		}
	}

	public void M1209(mGraphics g)
	{
	}

	public void M1210(mGraphics g, int x, int y, int w, int h)
	{
		g.M933(16774843);
		g.M932(x, y, w, h);
	}

	public void M1211(mGraphics g, int x, int y)
	{
		g.M948(imgLogo, x, y, 3);
	}

	public void M1212(mGraphics g, string number)
	{
	}

	public void M1213(mGraphics g, int x, int y, int w, int h, bool iss)
	{
		if (iss)
		{
			g.M933(16646144);
			g.M953(x, y, w, h, 10, 10);
			g.M933(16770612);
		}
		else
		{
			g.M933(16775097);
			g.M953(x, y, w, h, 10, 10);
			g.M933(16775097);
		}
		g.M953(x + 3, y + 3, w - 6, h - 6, 10, 10);
	}

	public void M1214(mGraphics g, int x, int y, int w, int h, string title, string subTitle, string check)
	{
	}

	public void M1215(mGraphics g, string title, string subTitle, string check)
	{
	}

	public void M1216(mGraphics g, int x, int y, int index)
	{
		g.M948(imgTick[1], x, y, 3);
		if (index == 1)
		{
			g.M948(imgTick[0], x + 1, y - 3, 3);
		}
	}

	public void M1217(mGraphics g, int x, int y, int index)
	{
		g.M948(imgMsg[index], x, y, 0);
	}

	public void M1218(mGraphics g, int roomId)
	{
		M1201(g);
	}

	public void M1219(mGraphics g, int x, int y, bool check, bool focus)
	{
		if (focus)
		{
			g.M940(imgCheck, 0, ((!check) ? 1 : 3) * 18, 20, 18, 0, x, y, 0);
		}
		else
		{
			g.M940(imgCheck, 0, (check ? 2 : 0) * 18, 20, 18, 0, x, y, 0);
		}
	}

	public void M1220(mGraphics g, int x, int y, int w, int h, string[] str)
	{
		M1235(x, y, w, h, g);
		int num = y + 20 - mFont.tahoma_8b.M912();
		int num2 = 0;
		int num3 = num;
		while (num2 < str.Length)
		{
			mFont.tahoma_8b.M898(g, str[num2], x + w / 2, num3, 2);
			num2++;
			num3 += mFont.tahoma_8b.M912();
		}
	}

	public void M1221(mGraphics g, int x, int y, bool iss, bool isSe, int i, int wStr)
	{
	}

	public void M1222(mGraphics g, int x, int y, int xTo, int yTo)
	{
		g.M933(16774843);
		g.M928(x, y, xTo, yTo);
	}

	public void M1223(mGraphics g, int x, int y, int w, int h, bool iss)
	{
		if (iss)
		{
			g.M933(13132288);
			g.M932(x + 2, y + 2, w - 3, w - 3);
		}
		g.M933(3502080);
		g.M931(x, y, w, w);
	}

	public void M1224(mGraphics g, int x, int y, int h)
	{
		g.M933(3847752);
		g.M932(x, y, 4, h);
	}

	public int[] M1225()
	{
		return color;
	}

	public void M1226(mGraphics g)
	{
		g.M933(8916494);
		g.M932(0, 0, GameCanvas.w, GameCanvas.h);
		g.M948(imgLogo, GameCanvas.h >> 1, GameCanvas.w >> 1, 3);
	}

	public void M1227(mGraphics g, bool isRes)
	{
		int num = 0;
		if (!isRes && GameCanvas.h <= 240)
		{
			num = 15;
		}
		mFont.tahoma_7b_green2.M898(g, mResources.LOGINLABELS[0], GameCanvas.hw, GameCanvas.hh + 60 - num, 2);
		mFont.tahoma_7b_green2.M898(g, mResources.LOGINLABELS[1], GameCanvas.hw, GameCanvas.hh + 73 - num, 2);
	}

	public void M1228(mGraphics g, int x, int y, int w, int h)
	{
		g.M948(imgSelectBoard, x - 7, y, 0);
	}

	public int M1229()
	{
		return 0;
	}

	public string M1230()
	{
		return "/vmg/card.on";
	}

	public void M1231(mGraphics g, int x, int y, int w, int h)
	{
		g.M933(16777215);
		g.M931(x, y, 40, 40);
		g.M931(x + 1, y + 1, 38, 38);
	}

	public string M1232()
	{
		return "http://wap.teamobi.com?info=checkupdate&game=3&version=" + GameMidlet.VERSION + "&provider=" + GameMidlet.PROVIDER;
	}

	public void M1233(int focus)
	{
	}

	public void M1234(int x, int y, int w, int h, mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M933(9340251);
		g.M931(x + 18, y, (w - 36) / 2 - 32, h);
		g.M931(x + 18 + (w - 36) / 2 + 32, y, (w - 36) / 2 - 22, h);
		g.M931(x, y + 8, w, h - 17);
		g.M933(COLORBACKGROUND);
		g.M932(x + 18, y + 3, (w - 36) / 2 - 32, h - 4);
		g.M932(x + 18 + (w - 36) / 2 + 31, y + 3, (w - 38) / 2 - 22, h - 4);
		g.M932(x + 1, y + 6, w - 1, h - 11);
		g.M933(14667919);
		g.M932(x + 18, y + 1, (w - 36) / 2 - 32, 2);
		g.M932(x + 18 + (w - 36) / 2 + 32, y + 1, (w - 36) / 2 - 12, 2);
		g.M932(x + 18, y + h - 2, (w - 36) / 2 - 31, 2);
		g.M932(x + 18 + (w - 36) / 2 + 32, y + h - 2, (w - 36) / 2 - 31, 2);
		g.M932(x + 1, y + 11, 2, h - 18);
		g.M932(x + w - 2, y + 11, 2, h - 18);
		g.M948(goc[0], x - 3, y - 2, mGraphics.TOP | mGraphics.LEFT);
		g.M948(goc[2], x + w + 3, y - 2, StaticObj.TOP_RIGHT);
		g.M948(goc[1], x - 3, y + h + 3, StaticObj.BOTTOM_LEFT);
		g.M948(goc[3], x + w + 4, y + h + 2, StaticObj.BOTTOM_RIGHT);
		g.M948(goc[4], x + w / 2, y, StaticObj.TOP_CENTER);
		g.M948(goc[5], x + w / 2, y + h + 1, StaticObj.BOTTOM_HCENTER);
	}

	public void M1235(int x, int y, int w, int h, mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M933(13524492);
		g.M931(x + 6, y, w - 12, h);
		g.M931(x, y + 6, w, h - 12);
		g.M931(x + 7, y + 1, w - 14, h - 2);
		g.M931(x + 1, y + 7, w - 2, h - 14);
		g.M933(14338484);
		g.M932(x + 8, y + 2, w - 16, h - 3);
		g.M932(x + 2, y + 8, w - 3, h - 14);
		g.M948(GameCanvas.imgBorder[2], x, y, mGraphics.TOP | mGraphics.LEFT);
		g.M940(GameCanvas.imgBorder[2], 0, 0, 16, 16, 2, x + w + 1, y, StaticObj.TOP_RIGHT);
		g.M940(GameCanvas.imgBorder[2], 0, 0, 16, 16, 1, x, y + h + 1, StaticObj.BOTTOM_LEFT);
		g.M940(GameCanvas.imgBorder[2], 0, 0, 16, 16, 3, x + w + 1, y + h + 1, StaticObj.BOTTOM_RIGHT);
	}

	public void M1236(int x, int y, int w, int h, mGraphics g)
	{
		g.M933(6702080);
		g.M932(x, y, w, h);
		g.M933(14338484);
		g.M932(x + 1, y + 1, w - 2, h - 2);
	}

	public void M1237(int x, int y, int w, int h, mGraphics g)
	{
		M1235(x, y, w, h, g);
	}

	public void M1238(int x, int y, int w, int h, mGraphics g)
	{
		g.M933(COLORBACKGROUND);
		g.M932(x, y, w, h);
	}

	public void M1239(int x, int y, int w, int h, mGraphics g)
	{
		g.M933(COLORLIGHT);
		g.M932(x, y, w, h);
	}
}
