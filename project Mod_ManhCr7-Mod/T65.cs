public class T65 : T57
{
	public T117 infoWaitToShow = new T117();

	public T67 info;

	public int p1 = 5;

	public int p2;

	public int p3;

	public int x;

	public int strWidth;

	public int limLeft = 2;

	public int hI = 20;

	public int xChar;

	public int yChar;

	public int sayWidth = 100;

	public int sayRun;

	public string[] says;

	public int cx;

	public int cy;

	public int ch;

	public bool outSide;

	public int f;

	public int tF;

	public T60 img;

	public static T60 gocnhon = T51.M503("/mainImage/myTexture2dgocnhon.png");

	public int time;

	public int timeW;

	public int type;

	public int X;

	public int Y;

	public int W;

	public int H;

	public void M740()
	{
		says = null;
		infoWaitToShow.M1120();
	}

	public void M741(T99 g, int x, int y, int dir)
	{
		if (infoWaitToShow.M1113() == 0)
		{
			return;
		}
		g.M918(x, y);
		if (says != null && says.Length != 0 && type != 1)
		{
			if (outSide)
			{
				cx -= T54.cmx;
				cy -= T54.cmy;
				cy += 35;
			}
			int num = ((T99.zoomLevel != 1) ? 10 : 0);
			if (info.charInfo == null)
			{
				T133.M1481(g, X, Y, W, H, 16777215, isButton: false);
			}
			else
			{
				T110.M1051(g, X - 23, Y - num / 2, W + 15, H + ((!T51.isTouch) ? 14 : 0) + num);
			}
			if (info.charInfo == null)
			{
				g.M940(gocnhon, 0, 0, 9, 8, (dir != 1) ? 2 : 0, cx - 3 + ((dir != 1) ? 20 : (-15)), cy - ch - 20 + sayRun + 2, T99.TOP | T99.HCENTER);
			}
			int num2 = -1;
			for (int i = 0; i < says.Length; i++)
			{
				T98 t = T98.tahoma_7;
				string text = says[i];
				int num3 = 0;
				if (says[i].StartsWith("|"))
				{
					string[] array = T137.M1531(says[i], "|", 0);
					if (array.Length == 3)
					{
						text = array[2];
					}
					if (array.Length == 4)
					{
						text = array[3];
						int.Parse(array[2]);
					}
					num3 = int.Parse(array[1]);
					num2 = num3;
				}
				else
				{
					num3 = num2;
				}
				switch (num3)
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
				}
				if (info.charInfo == null)
				{
					t.M898(g, text, cx, cy - ch - 15 + sayRun + i * 12 - says.Length * 12 - 9, 2);
					continue;
				}
				int num4 = X - 23;
				int num5 = Y - num / 2;
				int num6 = ((T110.clientType != 1) ? (W + 25) : (W + 28));
				int num7 = H + ((!T51.isTouch) ? 14 : 0) + num;
				g.M933(4465169);
				g.M932(num4, num5 + num7, num6, 2);
				int num8 = info.timeCount * num6 / info.maxTime;
				if (num8 < 0)
				{
					num8 = 0;
				}
				g.M933(43758);
				g.M932(num4, num5 + num7, num8, 2);
				if (info.timeCount == 0)
				{
					return;
				}
				info.charInfo.M197(g, X + 5, Y + H / 2, 0);
				((!info.isChatServer) ? T98.tahoma_7b_greenSmall : T98.tahoma_7b_yellowSmall2).M898(g, info.charInfo.cName, X + 12, Y + 3, 0);
				if (!T51.isTouch)
				{
					if (!T173.isQwerty)
					{
						T98.tahoma_7b_green2Small.M898(g, "Nhấn # để chat", X + W / 2 + 10, Y + H, T98.CENTER);
					}
					else
					{
						T98.tahoma_7b_green2Small.M898(g, "Nhấn Y để chat", X + W / 2 + 10, Y + H, T98.CENTER);
					}
				}
				T172.M1899(g, text, X + 14, Y + H / 2 + 2, W - 16, H, T98.tahoma_7_whiteSmall);
				T51.M451(g);
			}
		}
		g.M918(-x, -y);
	}

	public void M742()
	{
		if (infoWaitToShow.M1113() == 0 || info.timeCount != 0)
		{
			return;
		}
		time++;
		if (time >= info.speed)
		{
			time = 0;
			infoWaitToShow.M1118(0);
			if (infoWaitToShow.M1113() != 0)
			{
				info = (T67)infoWaitToShow.M1122();
				M743();
			}
		}
	}

	public void M743()
	{
		sayWidth = 100;
		if (T51.w == 128)
		{
			sayWidth = 128;
		}
		int num;
		if (info.charInfo != null)
		{
			says = new string[1] { info.s };
			num = says.Length;
		}
		else
		{
			says = T98.tahoma_7.M907(info.s, sayWidth - 10);
			num = says.Length;
		}
		sayRun = 7;
		X = cx - sayWidth / 2 - 1;
		Y = cy - ch - 15 + sayRun - num * 12 - 15;
		W = sayWidth + 2 + ((info.charInfo != null) ? 30 : 0);
		H = (num + 1) * 12 + 1 + ((info.charInfo != null) ? 5 : 0);
	}

	public void M744(string s, int Type, T13 cInfo, bool isChatServer)
	{
		type = Type;
		if (T51.w == 128)
		{
			limLeft = 1;
		}
		if (infoWaitToShow.M1113() > 10)
		{
			infoWaitToShow.M1118(0);
		}
		if (infoWaitToShow.M1113() > 0 && s.Equals(((T67)infoWaitToShow.M1123()).s))
		{
			T137.M1513("return");
			return;
		}
		T67 t = new T67(s);
		if (type == 0)
		{
			t.speed = s.Length;
		}
		if (t.speed < 70)
		{
			t.speed = 70;
		}
		if (type == 1)
		{
			t.speed = 10000000;
		}
		if (type == 3)
		{
			t.speed = 300;
			t.last = T110.M1054();
			t.timeCount = s.Length * 10 / 4;
			if (t.timeCount < 150)
			{
				t.timeCount = 150;
			}
			t.maxTime = t.timeCount;
		}
		if (cInfo != null)
		{
			t.charInfo = cInfo;
			t.isChatServer = isChatServer;
			T51.panel.M1254(t);
			if (T51.isTouch && T51.panel.isViewChatServer)
			{
				T54.info2.cmdChat = new T22(mResources.CHAT, this, 1000, t);
			}
		}
		if ((cInfo != null && T51.panel.isViewChatServer) || cInfo == null)
		{
			infoWaitToShow.M1111(t);
		}
		if (infoWaitToShow.M1113() == 1)
		{
			info = (T67)infoWaitToShow.M1122();
			M743();
		}
		if (T51.isTouch && cInfo != null && T51.panel.isViewChatServer && T51.w - 50 > 155 + W)
		{
			T54.info2.cmdChat.x = T51.w - W - 50;
			T54.info2.cmdChat.y = 35;
		}
	}

	public void M745(string s, int speed, T98 f)
	{
		if (T51.w == 128)
		{
			limLeft = 1;
		}
		if (infoWaitToShow.M1113() > 10)
		{
			infoWaitToShow.M1118(0);
		}
		infoWaitToShow.M1111(new T67(s, f, speed));
	}

	public bool M746()
	{
		if (p1 == 5)
		{
			return infoWaitToShow.M1113() == 0;
		}
		return false;
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
		{
			T15.M279().M281(T54.M559(), mResources.chat_player);
		}
	}

	public void M747()
	{
	}
}
