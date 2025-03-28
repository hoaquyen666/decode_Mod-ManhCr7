public class InfoMe
{
	public static InfoMe me;

	public int[][] charId = new int[3][];

	public Info info = new Info();

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

	public Command cmdChat;

	public bool isShow;

	public InfoMe()
	{
		for (int i = 0; i < charId.Length; i++)
		{
			charId[i] = new int[3];
		}
	}

	public static InfoMe M754()
	{
		if (me == null)
		{
			me = new InfoMe();
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

	public void M756(mGraphics g)
	{
		if ((Equals(GameScr.info2) && GameScr.M559().M640()) || (Equals(GameScr.info2) && GameScr.M559().popUpYesNo != null) || !GameScr.isPaint || (GameCanvas.currentScreen != GameScr.M559() && GameCanvas.currentScreen != CrackBallScr.M332()) || ChatPopup.serverChatPopUp != null || !isUpdate || Char.ischangingMap || (GameCanvas.panel.isShow && Equals(GameScr.info2)))
		{
			return;
		}
		g.M918(-g.M920(), -g.M921());
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
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
			SmallImage.M1785(g, charId[Char.M113().cgender][f], cmx, cmy + 3 + ((GameCanvas.gameTick % 10 > 5) ? 1 : 0), (dir != 1) ? 2 : 0, StaticObj.VCENTER_HCENTER);
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
		if ((Equals(GameScr.info2) && GameScr.M559().popUpYesNo != null) || !isUpdate)
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
					GameCanvas.panel.M1266();
					GameCanvas.panel.M1285();
				}
			}
			if (GameCanvas.gameTick % 3 == 0)
			{
				if (Char.M113().cdir == 1)
				{
					cmtoX = Char.M113().cx - 20 - GameScr.cmx;
				}
				if (Char.M113().cdir == -1)
				{
					cmtoX = Char.M113().cx + 20 - GameScr.cmx;
				}
				if (cmtoX <= 24)
				{
					cmtoX += info.sayWidth / 2;
				}
				if (cmtoX >= GameCanvas.w - 24)
				{
					cmtoX -= info.sayWidth / 2;
				}
				cmtoY = Char.M113().cy - 40 - GameScr.cmy;
				if (info.says != null && cmtoY < (info.says.Length + 1) * 12 + 10)
				{
					cmtoY = (info.says.Length + 1) * 12 + 10;
				}
				if (info.info.charInfo != null)
				{
					if (GameCanvas.w - 50 > 155 + info.W)
					{
						cmtoX = GameCanvas.w - 60 - info.W / 2;
						cmtoY = info.H + 10;
					}
					else
					{
						cmtoX = GameCanvas.w - 20 - info.W / 2;
						cmtoY = 45 + info.H;
						if (GameCanvas.w > GameCanvas.h || GameCanvas.w < 220)
						{
							cmtoX = GameCanvas.w - 20 - info.W / 2;
							cmtoY = info.H + 10;
						}
					}
				}
			}
			if (cmx > Char.M113().cx - GameScr.cmx)
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
					InfoItem t = (InfoItem)info.infoWaitToShow.M1122();
					info.info = t;
					info.M743();
				}
				return;
			}
			info.info.curr = mSystem.M1054();
			if (info.info.curr - info.info.last >= 100L)
			{
				info.info.last = mSystem.M1054();
				info.info.timeCount--;
			}
			if (info.info.timeCount == 0)
			{
				info.infoWaitToShow.M1118(0);
				if (info.infoWaitToShow.M1113() != 0)
				{
					InfoItem t2 = (InfoItem)info.infoWaitToShow.M1122();
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
					cmtoX = Char.M113().cx - GameScr.cmx + ((Char.M113().cdir != 1) ? 20 : (-20));
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
				info.info.curr = mSystem.M1054();
				if (info.info.curr - info.info.last >= 100L)
				{
					info.info.last = mSystem.M1054();
					info.info.timeCount--;
				}
				if (info.info.timeCount == 0)
				{
					isDone = true;
					cmtoY = -40;
					cmtoX = Char.M113().cx - GameScr.cmx + ((Char.M113().cdir != 1) ? 20 : (-20));
					info.time = 0;
					info.infoWaitToShow.M1120();
					info.says = null;
					cmdChat = null;
				}
			}
		}
	}

	public void M761(string s, Char c, bool isChatServer)
	{
		playerID = c.charID;
		info.M744(s, 3, c, isChatServer);
		isDone = false;
	}

	public void M762(string s, int Type)
	{
		s = Res.M1518(s);
		if (info.infoWaitToShow.M1113() > 0 && s.Equals(((InfoItem)info.infoWaitToShow.M1123()).s))
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
			cmx = Char.M113().cx - GameScr.cmx + ((Char.M113().cdir != 1) ? 20 : (-20));
		}
		isDone = false;
	}
}
