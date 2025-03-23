public class T125
{
	public static int COLORBACKGROUND = 15787715;

	public static int COLORLIGHT = 16383818;

	public static int COLORDARK = 3937280;

	public static int COLORBORDER = 15224576;

	public static int COLORFOCUS = 16777215;

	public static T60 imgBg;

	public static T60 imgLogo;

	public static T60 imgLB;

	public static T60 imgLT;

	public static T60 imgRB;

	public static T60 imgRT;

	public static T60 imgChuong;

	public static T60 imgSelectBoard;

	public static T60 imgtoiSmall;

	public static T60 imgTayTren;

	public static T60 imgTayDuoi;

	public static T60[] imgTick = new T60[2];

	public static T60[] imgMsg = new T60[2];

	public static T60[] goc = new T60[6];

	public static int hTab = 24;

	public static int lenCaption = 0;

	public int[] color = new int[7] { 15970400, 13479911, 2250052, 16374659, 15906669, 12931125, 3108954 };

	public static T60 imgCheck = T51.M503("/mainImage/myTexture2dcheck.png");

	public static void M1200()
	{
		for (int i = 0; i < goc.Length; i++)
		{
			goc[i] = T51.M503("/mainImage/myTexture2dgoc" + (i + 1) + ".png");
		}
	}

	public void M1201(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M933(8916494);
		g.M932(0, 0, T51.w, T51.h);
		g.M948(imgBg, T51.w / 2, T51.h / 2 - hTab / 2 - 1, 3);
		g.M948(imgLT, 0, 0, 0);
		g.M948(imgRT, T51.w, 0, T99.TOP | T99.RIGHT);
		g.M948(imgLB, 0, T51.h - hTab - 2, T99.BOTTOM | T99.LEFT);
		g.M948(imgRB, T51.w, T51.h - hTab - 2, T99.BOTTOM | T99.RIGHT);
		g.M933(16774843);
		g.M931(0, 0, T51.w, 0);
		g.M931(0, T51.h - hTab - 2, T51.w, 0);
		g.M931(0, 0, 0, T51.h - hTab);
		g.M931(T51.w - 1, 0, 0, T51.h - hTab);
	}

	public void M1202(T99 g)
	{
		g.M933(205314);
		g.M932(0, 0, T51.w, T51.h);
	}

	public void M1203()
	{
	}

	public void M1204(T99 g)
	{
	}

	public void M1205(T99 g, int x, int y, int w, int h)
	{
		g.M933(8411138);
		g.M932(x, y, w, h);
		g.M933(13606712);
		g.M931(x, y, w, h);
	}

	public void M1206(T99 g, int y, int x, int width, int height)
	{
		g.M933(16776363);
		g.M932(x, y, width, height);
		g.M933(0);
		g.M931(x - 1, y - 1, width + 1, height + 1);
	}

	public void M1207(T99 g, int h)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M933(14279153);
		g.M932(8, T51.h - (h + 37), T51.w - 16, h + 4);
		g.M933(4682453);
		g.M932(10, T51.h - (h + 35), T51.w - 20, h);
	}

	public void M1208(T99 g, T22 left, T22 center, T22 right)
	{
		T98 t = ((!T51.isTouch) ? T98.tahoma_7b_dark : T98.tahoma_7b_dark);
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
					g.M948((T108.keyTouch != 0) ? T54.imgLbtn : T54.imgLbtnFocus, 1, T51.h - T108.cmdH - 1, 0);
					t.M898(g, left.caption, 35, T51.h - T108.cmdH + 3 + num, 2);
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
					g.M948((T108.keyTouch != 1) ? T54.imgLbtn : T54.imgLbtnFocus, T51.hw - 35, T51.h - T108.cmdH - 1, 0);
					t.M898(g, center.caption, T51.hw, T51.h - T108.cmdH + 3 + num, 2);
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
			g.M948((T108.keyTouch != 2) ? T54.imgLbtn : T54.imgLbtnFocus, T51.w - 71, T51.h - T108.cmdH - 1, 0);
			t.M898(g, right.caption, T51.w - 35, T51.h - T108.cmdH + 3 + num, 2);
		}
	}

	public void M1209(T99 g)
	{
	}

	public void M1210(T99 g, int x, int y, int w, int h)
	{
		g.M933(16774843);
		g.M932(x, y, w, h);
	}

	public void M1211(T99 g, int x, int y)
	{
		g.M948(imgLogo, x, y, 3);
	}

	public void M1212(T99 g, string number)
	{
	}

	public void M1213(T99 g, int x, int y, int w, int h, bool iss)
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

	public void M1214(T99 g, int x, int y, int w, int h, string title, string subTitle, string check)
	{
	}

	public void M1215(T99 g, string title, string subTitle, string check)
	{
	}

	public void M1216(T99 g, int x, int y, int index)
	{
		g.M948(imgTick[1], x, y, 3);
		if (index == 1)
		{
			g.M948(imgTick[0], x + 1, y - 3, 3);
		}
	}

	public void M1217(T99 g, int x, int y, int index)
	{
		g.M948(imgMsg[index], x, y, 0);
	}

	public void M1218(T99 g, int roomId)
	{
		M1201(g);
	}

	public void M1219(T99 g, int x, int y, bool check, bool focus)
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

	public void M1220(T99 g, int x, int y, int w, int h, string[] str)
	{
		M1235(x, y, w, h, g);
		int num = y + 20 - T98.tahoma_8b.M912();
		int num2 = 0;
		int num3 = num;
		while (num2 < str.Length)
		{
			T98.tahoma_8b.M898(g, str[num2], x + w / 2, num3, 2);
			num2++;
			num3 += T98.tahoma_8b.M912();
		}
	}

	public void M1221(T99 g, int x, int y, bool iss, bool isSe, int i, int wStr)
	{
	}

	public void M1222(T99 g, int x, int y, int xTo, int yTo)
	{
		g.M933(16774843);
		g.M928(x, y, xTo, yTo);
	}

	public void M1223(T99 g, int x, int y, int w, int h, bool iss)
	{
		if (iss)
		{
			g.M933(13132288);
			g.M932(x + 2, y + 2, w - 3, w - 3);
		}
		g.M933(3502080);
		g.M931(x, y, w, w);
	}

	public void M1224(T99 g, int x, int y, int h)
	{
		g.M933(3847752);
		g.M932(x, y, 4, h);
	}

	public int[] M1225()
	{
		return color;
	}

	public void M1226(T99 g)
	{
		g.M933(8916494);
		g.M932(0, 0, T51.w, T51.h);
		g.M948(imgLogo, T51.h >> 1, T51.w >> 1, 3);
	}

	public void M1227(T99 g, bool isRes)
	{
		int num = 0;
		if (!isRes && T51.h <= 240)
		{
			num = 15;
		}
		T98.tahoma_7b_green2.M898(g, mResources.LOGINLABELS[0], T51.hw, T51.hh + 60 - num, 2);
		T98.tahoma_7b_green2.M898(g, mResources.LOGINLABELS[1], T51.hw, T51.hh + 73 - num, 2);
	}

	public void M1228(T99 g, int x, int y, int w, int h)
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

	public void M1231(T99 g, int x, int y, int w, int h)
	{
		g.M933(16777215);
		g.M931(x, y, 40, 40);
		g.M931(x + 1, y + 1, 38, 38);
	}

	public string M1232()
	{
		return "http://wap.teamobi.com?info=checkupdate&game=3&version=" + T52.VERSION + "&provider=" + T52.PROVIDER;
	}

	public void M1233(int focus)
	{
	}

	public void M1234(int x, int y, int w, int h, T99 g)
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
		g.M948(goc[0], x - 3, y - 2, T99.TOP | T99.LEFT);
		g.M948(goc[2], x + w + 3, y - 2, T163.TOP_RIGHT);
		g.M948(goc[1], x - 3, y + h + 3, T163.BOTTOM_LEFT);
		g.M948(goc[3], x + w + 4, y + h + 2, T163.BOTTOM_RIGHT);
		g.M948(goc[4], x + w / 2, y, T163.TOP_CENTER);
		g.M948(goc[5], x + w / 2, y + h + 1, T163.BOTTOM_HCENTER);
	}

	public void M1235(int x, int y, int w, int h, T99 g)
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
		g.M948(T51.imgBorder[2], x, y, T99.TOP | T99.LEFT);
		g.M940(T51.imgBorder[2], 0, 0, 16, 16, 2, x + w + 1, y, T163.TOP_RIGHT);
		g.M940(T51.imgBorder[2], 0, 0, 16, 16, 1, x, y + h + 1, T163.BOTTOM_LEFT);
		g.M940(T51.imgBorder[2], 0, 0, 16, 16, 3, x + w + 1, y + h + 1, T163.BOTTOM_RIGHT);
	}

	public void M1236(int x, int y, int w, int h, T99 g)
	{
		g.M933(6702080);
		g.M932(x, y, w, h);
		g.M933(14338484);
		g.M932(x + 1, y + 1, w - 2, h - 2);
	}

	public void M1237(int x, int y, int w, int h, T99 g)
	{
		M1235(x, y, w, h, g);
	}

	public void M1238(int x, int y, int w, int h, T99 g)
	{
		g.M933(COLORBACKGROUND);
		g.M932(x, y, w, h);
	}

	public void M1239(int x, int y, int w, int h, T99 g)
	{
		g.M933(COLORLIGHT);
		g.M932(x, y, w, h);
	}
}
