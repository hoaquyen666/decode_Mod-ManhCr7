public class T68
{
	public static T68 me;

	public int[][] charId = new int[3][];

	public T65 info = new T65();

	public int dir;

	public int f;

	public int tF;

	public int cmtoY;

	public int cmy;

	public int cmdy;

	public int cmvy;

	public int cmyLim;

	public int cmtoX;

	public int cmx;

	public int cmdx;

	public int cmvx;

	public int cmxLim;

	public bool isDone;

	public bool isUpdate = true;

	public int timeDelay;

	public int playerID;

	public int timeCount;

	public T22 cmdChat;

	public bool isShow;

	public T68()
	{
		for (int i = 0; i < charId.Length; i++)
		{
			charId[i] = new int[3];
		}
	}

	public static T68 M754()
	{
		if (me == null)
		{
			me = new T68();
		}
		return me;
	}

	public void M755()
	{
		for (int i = 0; i < charId.Length; i++)
		{
			charId[i] = new int[3];
		}
	}

	public void M756(T99 g)
	{
		if ((Equals(T54.info2) && T54.M559().M640()) || (Equals(T54.info2) && T54.M559().popUpYesNo != null) || !T54.isPaint || (T51.currentScreen != T54.M559() && T51.currentScreen != T25.M332()) || T14.serverChatPopUp != null || !isUpdate || T13.ischangingMap || (T51.panel.isShow && Equals(T54.info2)))
		{
			return;
		}
		g.M918(-g.M920(), -g.M921());
		g.M922(0, 0, T51.w, T51.h);
		if (info != null)
		{
			info.M741(g, cmx, cmy, dir);
			if (info.info == null || info.info.charInfo == null || cmdChat != null)
			{
			}
			if (info.info != null && info.info.charInfo != null)
			{
			}
		}
		if (info.info != null && info.info.charInfo == null && charId != null)
		{
			T157.M1785(g, charId[T13.M113().cgender][f], cmx, cmy + 3 + ((T51.gameTick % 10 > 5) ? 1 : 0), (dir != 1) ? 2 : 0, T163.VCENTER_HCENTER);
		}
		g.M918(-g.M920(), -g.M921());
	}

	public void M757()
	{
		info.M740();
	}

	public void M758()
	{
		if (cmy != cmtoY)
		{
			cmvy = cmtoY - cmy << 2;
			cmdy += cmvy;
			cmy += cmdy >> 4;
			cmdy &= 15;
		}
		if (cmx != cmtoX)
		{
			cmvx = cmtoX - cmx << 2;
			cmdx += cmvx;
			cmx += cmdx >> 4;
			cmdx &= 15;
		}
		tF++;
		if (tF == 5)
		{
			tF = 0;
			if (f == 0)
			{
				f = 1;
			}
			else
			{
				f = 0;
			}
		}
	}

	public void M759(int t)
	{
		timeDelay = t;
	}

	public void M760()
	{
		if (info != null && info.infoWaitToShow != null && info.infoWaitToShow.M1113() == 0 && cmy != -40)
		{
			info.timeW--;
			if (info.timeW <= 0)
			{
				cmy = -40;
				info.time = 0;
				info.infoWaitToShow.M1120();
				info.says = null;
				info.timeW = 200;
			}
		}
		if ((Equals(T54.info2) && T54.M559().popUpYesNo != null) || !isUpdate)
		{
			return;
		}
		M758();
		if (info == null || (info != null && info.info == null))
		{
			return;
		}
		if (!isDone)
		{
			if (timeDelay > 0)
			{
				timeDelay--;
				if (timeDelay == 0)
				{
					T51.panel.M1266();
					T51.panel.M1285();
				}
			}
			if (T51.gameTick % 3 == 0)
			{
				if (T13.M113().cdir == 1)
				{
					cmtoX = T13.M113().cx - 20 - T54.cmx;
				}
				if (T13.M113().cdir == -1)
				{
					cmtoX = T13.M113().cx + 20 - T54.cmx;
				}
				if (cmtoX <= 24)
				{
					cmtoX += info.sayWidth / 2;
				}
				if (cmtoX >= T51.w - 24)
				{
					cmtoX -= info.sayWidth / 2;
				}
				cmtoY = T13.M113().cy - 40 - T54.cmy;
				if (info.says != null && cmtoY < (info.says.Length + 1) * 12 + 10)
				{
					cmtoY = (info.says.Length + 1) * 12 + 10;
				}
				if (info.info.charInfo != null)
				{
					if (T51.w - 50 > 155 + info.W)
					{
						cmtoX = T51.w - 60 - info.W / 2;
						cmtoY = info.H + 10;
					}
					else
					{
						cmtoX = T51.w - 20 - info.W / 2;
						cmtoY = 45 + info.H;
						if (T51.w > T51.h || T51.w < 220)
						{
							cmtoX = T51.w - 20 - info.W / 2;
							cmtoY = info.H + 10;
						}
					}
				}
			}
			if (cmx > T13.M113().cx - T54.cmx)
			{
				dir = -1;
			}
			else
			{
				dir = 1;
			}
		}
		if (info.info == null)
		{
			return;
		}
		if (info.infoWaitToShow.M1113() > 1)
		{
			if (info.info.timeCount == 0)
			{
				info.time++;
				if (info.time >= info.info.speed)
				{
					info.time = 0;
					info.infoWaitToShow.M1118(0);
					T67 t = (T67)info.infoWaitToShow.M1122();
					info.info = t;
					info.M743();
				}
				return;
			}
			info.info.curr = T110.M1054();
			if (info.info.curr - info.info.last >= 100L)
			{
				info.info.last = T110.M1054();
				info.info.timeCount--;
			}
			if (info.info.timeCount == 0)
			{
				info.infoWaitToShow.M1118(0);
				if (info.infoWaitToShow.M1113() != 0)
				{
					T67 t2 = (T67)info.infoWaitToShow.M1122();
					info.info = t2;
					info.M743();
				}
			}
		}
		else
		{
			if (info.infoWaitToShow.M1113() != 1)
			{
				return;
			}
			if (info.info.timeCount == 0)
			{
				info.time++;
				if (info.time >= info.info.speed)
				{
					isDone = true;
				}
				if (info.time == info.info.speed)
				{
					cmtoY = -40;
					cmtoX = T13.M113().cx - T54.cmx + ((T13.M113().cdir != 1) ? 20 : (-20));
				}
				if (info.time >= info.info.speed + 20)
				{
					info.time = 0;
					info.infoWaitToShow.M1120();
					info.says = null;
					info.timeW = 200;
				}
			}
			else
			{
				info.info.curr = T110.M1054();
				if (info.info.curr - info.info.last >= 100L)
				{
					info.info.last = T110.M1054();
					info.info.timeCount--;
				}
				if (info.info.timeCount == 0)
				{
					isDone = true;
					cmtoY = -40;
					cmtoX = T13.M113().cx - T54.cmx + ((T13.M113().cdir != 1) ? 20 : (-20));
					info.time = 0;
					info.infoWaitToShow.M1120();
					info.says = null;
					cmdChat = null;
				}
			}
		}
	}

	public void M761(string s, T13 c, bool isChatServer)
	{
		playerID = c.charID;
		info.M744(s, 3, c, isChatServer);
		isDone = false;
	}

	public void M762(string s, int Type)
	{
		s = T137.M1518(s);
		if (info.infoWaitToShow.M1113() > 0 && s.Equals(((T67)info.infoWaitToShow.M1123()).s))
		{
			return;
		}
		if (info.infoWaitToShow.M1113() > 10)
		{
			for (int i = 0; i < 5; i++)
			{
				info.infoWaitToShow.M1118(0);
			}
		}
		info.M744(s, Type, null, isChatServer: false);
		if (info.infoWaitToShow.M1113() == 1)
		{
			cmy = 0;
			cmx = T13.M113().cx - T54.cmx + ((T13.M113().cdir != 1) ? 20 : (-20));
		}
		isDone = false;
	}
}
