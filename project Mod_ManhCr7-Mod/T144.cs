using System;
using N3.N4;

public class T144 : T108, T57
{
	public static string[] nameServer;

	public static string[] address;

	public static sbyte serverPriority;

	public static bool[] hasConnected;

	public static short[] port;

	public static int selected;

	public static bool isWait;

	public static T22 cmdUpdateServer;

	public static sbyte[] language;

	private T22[] cmd;

	private T22 cmdCallHotline;

	private int nCmdPlay;

	public static T22 cmdDeleteRMS;

	private int lY;

	public static string smartPhoneVN;

	public static string javaVN;

	public static string smartPhoneIn;

	public static string javaIn;

	public static string smartPhoneE;

	public static string javaE;

	public static string linkGetHost;

	public static string linkDefault;

	public const sbyte languageVersion = 2;

	public new int keyTouch = -1;

	private int tam;

	public static bool stopDownload;

	public static string linkweb;

	public static bool waitToLogin;

	public static int tWaitToLogin;

	public static int[] lengthServer;

	public static int ipSelect;

	public static int flagServer;

	public static bool bigOk;

	public static int percent;

	public static string strWait;

	public static int nBig;

	public static int nBg;

	public static int demPercent;

	public static int maxBg;

	public static bool isGetData;

	public static T22 cmdDownload;

	private T22 cmdStart;

	public string dataSize;

	public static int p;

	public static int testConnect;

	public static bool loadScreen;

	public T144()
	{
		int num = 4;
		if (184 >= T51.w)
		{
			num--;
		}
		M1579();
		if (!T51.isTouch)
		{
			selected = 0;
			M1583();
		}
		T54.M564(fullmScreen: true, -1, -1);
		T54.cmx = 100;
		T54.cmy = 200;
		if (cmdCallHotline == null)
		{
			cmdCallHotline = new T22("Gọi hotline", this, 13, null);
			cmdCallHotline.x = T51.w - 75;
			if (T110.clientType == 1 && !T51.isTouch)
			{
				cmdCallHotline.y = T51.h - 20;
			}
			else
			{
				cmdCallHotline.y = 8;
			}
		}
		cmdUpdateServer = new T22();
		cmdUpdateServer.actionChat = delegate(string str)
		{
			string text = str;
			string text2 = str;
			if (text == null)
			{
				text = linkDefault;
			}
			else
			{
				if (text == null && text2 != null)
				{
					if (text2.Equals(string.Empty) || text2.Length < 20)
					{
						text2 = linkDefault;
					}
					M1581(text2);
				}
				if (text != null && text2 == null)
				{
					if (text.Equals(string.Empty) || text.Length < 20)
					{
						text = linkDefault;
					}
					M1581(text);
				}
				if (text != null && text2 != null)
				{
					if (text.Length > text2.Length)
					{
						M1581(text);
					}
					else
					{
						M1581(text2);
					}
				}
			}
		};
		M1593(T110.LANGUAGE);
	}

	static T144()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		smartPhoneVN = "Vũ trụ 1:dragon1.teamobi.com:14445:0,Vũ trụ 2:dragon2.teamobi.com:14445:0,Vũ trụ 3:dragon3.teamobi.com:14445:0,Vũ trụ 4:dragon4.teamobi.com:14445:0,Vũ trụ 5:dragon5.teamobi.com:14445:0,Vũ trụ 6:dragon6.teamobi.com:14445:0,Vũ trụ 7:dragon7.teamobi.com:14445:0,Võ đài liên vũ trụ:dragonwar.teamobi.com:20000:0,Universe 1:dragon.indonaga.com:14445:1,0,6";
		javaVN = "Vũ trụ 1:112.213.94.23:14445:0,Vũ trụ 2:210.211.109.199:14445:0,Vũ trụ 3:112.213.85.88:14445:0,Vũ trụ 4:27.0.12.164:14445:0,Vũ trụ 5:27.0.12.16:14445:0,Vũ trụ 6:27.0.12.173:14445:0,Vũ trụ 7:112.213.94.223:14445:0,Võ đài liên vũ trụ:27.0.12.173:20000:0,Universe 1:54.179.255.27:14445:1,0,6";
		smartPhoneIn = "Naga:dragon.indonaga.com:14446:2,2,0";
		javaIn = "Naga:54.179.255.27:14446:2,2,0";
		smartPhoneE = "Universe 1:54.179.255.27:14445:1,1,0";
		javaE = "Universe 1:54.179.255.27:14445:1,1,0";
		linkGetHost = "http://sv1.ngocrongonline.com/game/ngocrong031_t.php";
		linkDefault = javaVN;
		linkweb = "http://ngocrongonline.com";
		lengthServer = new int[3];
		isGetData = false;
		testConnect = -1;
	}

	public static void M1578()
	{
		if (cmdDeleteRMS == null)
		{
			if (T51.serverScreen == null)
			{
				T51.serverScreen = new T144();
			}
			cmdDeleteRMS = new T22(string.Empty, T51.serverScreen, 14, null);
			cmdDeleteRMS.x = T51.w - 78;
			cmdDeleteRMS.y = T51.h - 26;
		}
	}

	private void M1579()
	{
		nCmdPlay = 0;
		string text = T138.M1536("acc");
		if (text == null)
		{
			if (T138.M1535("userAo" + ipSelect) != null)
			{
				nCmdPlay = 1;
			}
		}
		else if (text.Equals(string.Empty))
		{
			if (T138.M1535("userAo" + ipSelect) != null)
			{
				nCmdPlay = 1;
			}
		}
		else
		{
			nCmdPlay = 1;
		}
		cmd = new T22[(T99.zoomLevel <= 1) ? (4 + nCmdPlay) : (3 + nCmdPlay)];
		int num = T51.hh - 15 * cmd.Length + 28;
		for (int i = 0; i < cmd.Length; i++)
		{
			switch (i)
			{
			case 0:
				cmd[0] = new T22(string.Empty, this, 3, null);
				if (text == null)
				{
					cmd[0].caption = mResources.playNew;
					if (T138.M1535("userAo" + ipSelect) != null)
					{
						cmd[0].caption = mResources.choitiep;
					}
					break;
				}
				if (text.Equals(string.Empty))
				{
					cmd[0].caption = mResources.playNew;
					if (T138.M1535("userAo" + ipSelect) != null)
					{
						cmd[0].caption = mResources.choitiep;
					}
					break;
				}
				cmd[0].caption = mResources.playAcc + ": " + text;
				if (cmd[0].caption.Length > 23)
				{
					cmd[0].caption = cmd[0].caption.Substring(0, 23);
					cmd[0].caption += "...";
				}
				break;
			case 1:
				if (nCmdPlay == 1)
				{
					cmd[1] = new T22(string.Empty, this, 10100, null);
					cmd[1].caption = mResources.playNew;
				}
				else
				{
					cmd[1] = new T22(mResources.change_account, this, 7, null);
				}
				break;
			case 2:
				if (nCmdPlay == 1)
				{
					cmd[2] = new T22(mResources.change_account, this, 7, null);
				}
				else
				{
					cmd[2] = new T22(string.Empty, this, 17, null);
				}
				break;
			case 3:
				if (nCmdPlay == 1)
				{
					cmd[3] = new T22(string.Empty, this, 17, null);
				}
				else
				{
					cmd[3] = new T22(mResources.option, this, 8, null);
				}
				break;
			case 4:
				cmd[4] = new T22(mResources.option, this, 8, null);
				break;
			}
			cmd[i].y = num;
			cmd[i].M295();
			cmd[i].x = (T51.w - cmd[i].w) / 2;
			num += 30;
		}
	}

	public static void M1580()
	{
		if (cmdUpdateServer == null && T51.serverScreen == null)
		{
			T51.serverScreen = new T144();
		}
		T120.M1154(linkDefault, cmdUpdateServer);
	}

	public static void M1581(string str)
	{
		lengthServer = new int[3];
		string[] array = T137.M1531(str.Trim(), ",", 0);
		T137.M1513("tem leng= " + array.Length);
		mResources.loadLanguague(sbyte.Parse(array[array.Length - 2]));
		nameServer = new string[array.Length - 2];
		address = new string[array.Length - 2];
		port = new short[array.Length - 2];
		language = new sbyte[array.Length - 2];
		hasConnected = new bool[2];
		for (int i = 0; i < array.Length - 2; i++)
		{
			string[] array2 = T137.M1531(array[i].Trim(), ":", 0);
			nameServer[i] = array2[0];
			address[i] = array2[1];
			port[i] = short.Parse(array2[2]);
			language[i] = sbyte.Parse(array2[3].Trim());
			lengthServer[language[i]]++;
		}
		serverPriority = sbyte.Parse(array[array.Length - 1]);
		M1585();
		T51.M488();
	}

	public override void paint(T99 g)
	{
		if (!loadScreen)
		{
			g.M933(0);
			g.M932(0, 0, T51.w, T51.h);
			if (bigOk)
			{
			}
		}
		else
		{
			T51.M466(g);
		}
		int y = 2;
		T98.tahoma_7_white.M902(g, "v" + T52.VERSION + "(" + T99.zoomLevel + ")", T51.w - 2, 17, 1, T98.tahoma_7_grey);
		if (isGetData && !loadScreen)
		{
			T98.tahoma_7_white.M902(g, linkweb, T51.w - 2, y, 1, T98.tahoma_7_grey);
		}
		else if (T110.clientType == 1 && !T51.isTouch)
		{
			T98.tahoma_7_white.M902(g, linkweb, T51.w - 2, T51.h - 15, 1, T98.tahoma_7_grey);
		}
		else
		{
			T98.tahoma_7_white.M902(g, linkweb, T51.w - 2, y, 1, T98.tahoma_7_grey);
		}
		if (cmdDeleteRMS != null)
		{
			T98.tahoma_7_white.M902(g, mResources.xoadulieu, T51.w - 2, T51.h - 15, 1, T98.tahoma_7_grey);
		}
		if (T51.currentDialog == null)
		{
			if (!loadScreen)
			{
				if (!bigOk)
				{
					g.M948(T200.logoServerListScreen, T51.hw, T51.hh - 32, 3);
					if (!isGetData)
					{
						T98.tahoma_7b_white.M898(g, mResources.taidulieudechoi, T51.hw, T51.hh + 24, 2);
						if (cmdDownload != null)
						{
							cmdDownload.M296(g);
						}
					}
					else
					{
						if (cmdDownload != null)
						{
							cmdDownload.M296(g);
						}
						T98.tahoma_7b_white.M898(g, mResources.downloading_data + percent + "%", T51.w / 2, T51.hh + 24, 2);
						T54.M533(T54.frBarPow20, T54.frBarPow21, T54.frBarPow22, T51.w / 2 - 50, T51.hh + 45, 100, 100f, g);
						T54.M533(T54.frBarPow0, T54.frBarPow1, T54.frBarPow2, T51.w / 2 - 50, T51.hh + 45, 100, percent, g);
					}
				}
			}
			else
			{
				int num = T51.hh - 15 * cmd.Length - 15;
				if (num < 25)
				{
					num = 25;
				}
				if (T200.logoServerListScreen != null)
				{
					g.M948(T200.logoServerListScreen, T51.hw, num, 3);
				}
				for (int i = 0; i < cmd.Length; i++)
				{
					cmd[i].M296(g);
				}
				g.M922(0, 0, T51.w, T51.h);
				if (testConnect == -1)
				{
					if (T51.gameTick % 20 > 10)
					{
						g.M940(T54.imgRoomStat, 0, 14, 7, 7, 0, (T51.w - T98.tahoma_7b_dark.M909(cmd[2 + nCmdPlay].caption) >> 1) - 10, cmd[2 + nCmdPlay].y + 10, 0);
					}
				}
				else
				{
					g.M940(T54.imgRoomStat, 0, testConnect * 7, 7, 7, 0, (T51.w - T98.tahoma_7b_dark.M909(cmd[2 + nCmdPlay].caption) >> 1) - 10, cmd[2 + nCmdPlay].y + 9, 0);
				}
			}
		}
		base.paint(g);
	}

	public void M1582()
	{
		flagServer = 30;
		T51.M490(mResources.PLEASEWAIT);
		if (T147.M1744().isConnected())
		{
			T147.M1744().close();
		}
		T52.IP = address[ipSelect];
		T52.PORT = port[ipSelect];
		if (language[ipSelect] != mResources.language)
		{
			mResources.loadLanguague(language[ipSelect]);
		}
		T90.serverName = nameServer[ipSelect];
		M1579();
		T51.M449();
	}

	public override void update()
	{
		T200.M2218();
		if (waitToLogin)
		{
			tWaitToLogin++;
			if (tWaitToLogin == 50)
			{
				T51.serverScreen.M1582();
			}
			if (tWaitToLogin == 100)
			{
				if (T51.loginScr == null)
				{
					T51.loginScr = new T90();
				}
				T51.loginScr.M861();
				T146.M1594().M1711();
				waitToLogin = false;
			}
		}
		if (flagServer > 0)
		{
			flagServer--;
			if (flagServer == 0)
			{
				T51.M488();
			}
		}
		for (int i = 0; i < cmd.Length; i++)
		{
			if (i == selected)
			{
				cmd[i].isFocus = true;
			}
			else
			{
				cmd[i].isFocus = false;
			}
		}
		T54.cmx++;
		if (!loadScreen && (bigOk || percent == 100))
		{
			cmdDownload = null;
		}
		base.update();
	}

	private void M1583()
	{
		if (loadScreen)
		{
			center = new T22(string.Empty, this, cmd[selected].idAction, null);
		}
		else
		{
			center = cmdDownload;
		}
	}

	public static void M1584()
	{
		if (cmdDeleteRMS != null && cmdDeleteRMS.M298())
		{
			cmdDeleteRMS.M294();
		}
	}

	public override void updateKey()
	{
		if (T51.isTouch)
		{
			M1584();
			if (cmdCallHotline != null && cmdCallHotline.M298())
			{
				cmdCallHotline.M294();
			}
			if (!loadScreen)
			{
				if (cmdDownload != null && cmdDownload.M298())
				{
					cmdDownload.M294();
				}
				base.updateKey();
				return;
			}
			for (int i = 0; i < cmd.Length; i++)
			{
				if (cmd[i] != null && cmd[i].M298())
				{
					cmd[i].M294();
				}
			}
		}
		else if (loadScreen)
		{
			if (T51.keyPressed[8])
			{
				int num = ((T99.zoomLevel <= 1) ? 4 : 2);
				T51.keyPressed[8] = false;
				selected++;
				if (selected > num)
				{
					selected = 0;
				}
				M1583();
			}
			if (T51.keyPressed[2])
			{
				int num2 = ((T99.zoomLevel <= 1) ? 4 : 2);
				T51.keyPressed[2] = false;
				selected--;
				if (selected < 0)
				{
					selected = num2;
				}
				M1583();
			}
		}
		if (!isWait)
		{
			base.updateKey();
		}
	}

	public static void M1585()
	{
		T29 t = new T29();
		try
		{
			t.M373(mResources.language);
			t.M373((sbyte)nameServer.Length);
			for (int i = 0; i < nameServer.Length; i++)
			{
				t.M374(nameServer[i]);
				t.M374(address[i]);
				t.M368(port[i]);
				t.M373(language[i]);
			}
			t.M373(serverPriority);
			T138.M1534("NRlink2", t.M371());
			t.M372();
			T161.M1880();
		}
		catch (Exception)
		{
		}
	}

	public static bool M1586()
	{
		int num = 0;
		while (true)
		{
			if (num < 2)
			{
				if (!hasConnected[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static void M1587()
	{
		sbyte[] array = T138.M1535("NRlink2");
		if (array == null)
		{
			M1581(linkDefault);
			return;
		}
		T28 t = new T28(array);
		if (t == null)
		{
			return;
		}
		try
		{
			lengthServer = new int[3];
			mResources.loadLanguague(t.M360());
			sbyte b = t.M360();
			nameServer = new string[b];
			address = new string[b];
			port = new short[b];
			language = new sbyte[b];
			for (int i = 0; i < b; i++)
			{
				nameServer[i] = t.M359();
				address[i] = t.M359();
				port[i] = t.M353();
				language[i] = t.M360();
				lengthServer[language[i]]++;
			}
			serverPriority = t.M360();
			t.M357();
			T161.M1880();
		}
		catch (Exception)
		{
		}
	}

	public override void switchToMe()
	{
		T51.M449();
		T54.cmy = 0;
		T54.cmx = 0;
		M1579();
		isWait = false;
		T51.loginScr = null;
		string text = T138.M1536("ResVersion");
		if (((text == null || !(text != string.Empty)) ? (-1) : int.Parse(text)) > 0)
		{
			loadScreen = true;
			T51.M469(0);
		}
		bigOk = true;
		cmd[2 + nCmdPlay].caption = mResources.server + ": " + nameServer[ipSelect];
		center = new T22(string.Empty, this, cmd[selected].idAction, null);
		cmd[1 + nCmdPlay].caption = mResources.change_account;
		if (cmd.Length == 4 + nCmdPlay)
		{
			cmd[3 + nCmdPlay].caption = mResources.option;
		}
		T110.M1038();
		base.switchToMe();
	}

	public void M1588()
	{
		T54.cmy = 0;
		T54.cmx = 0;
		M1579();
		isWait = false;
		T51.loginScr = null;
		string text = T138.M1536("ResVersion");
		if (((text == null || !(text != string.Empty)) ? (-1) : int.Parse(text)) > 0)
		{
			loadScreen = true;
			T51.M469(0);
		}
		bigOk = true;
		cmd[2 + nCmdPlay].caption = mResources.server + ": " + nameServer[ipSelect];
		center = new T22(string.Empty, this, cmd[selected].idAction, null);
		cmd[1 + nCmdPlay].caption = mResources.change_account;
		if (cmd.Length == 4 + nCmdPlay)
		{
			cmd[3 + nCmdPlay].caption = mResources.option;
		}
		T110.M1038();
		base.switchToMe();
	}

	public void M1589()
	{
	}

	public void M1590()
	{
		if (T51.serverScreen == null)
		{
			T51.serverScreen = new T144();
		}
		demPercent = 0;
		percent = 0;
		stopDownload = true;
		T51.serverScreen.M1592();
		isGetData = false;
		cmdDownload.isFocus = true;
		center = new T22(string.Empty, this, 2, null);
	}

	public void perform(int idAction, object p)
	{
		T137.M1513("perform " + idAction);
		if (idAction == 1000)
		{
			T51.M449();
		}
		if (idAction == 1 || idAction == 4)
		{
			M1590();
		}
		if (idAction == 2)
		{
			stopDownload = false;
			cmdDownload = new T22(mResources.huy, this, 4, null);
			cmdDownload.x = T51.w / 2 - T108.cmdW / 2;
			cmdDownload.y = T51.hh + 65;
			right = null;
			if (!T51.isTouch)
			{
				cmdDownload.x = T51.w / 2 - T108.cmdW / 2;
				cmdDownload.y = T51.h - T108.cmdH - 1;
			}
			center = new T22(string.Empty, this, 4, null);
			if (!isGetData)
			{
				T146.M1594().M1720(1, null);
				if (!T51.isTouch)
				{
					cmdDownload.isFocus = true;
					center = new T22(string.Empty, this, 4, null);
				}
				isGetData = true;
			}
		}
		if (idAction == 3)
		{
			T137.M1513("toi day");
			if (T51.loginScr == null)
			{
				T51.loginScr = new T90();
			}
			T51.loginScr.switchToMe();
			bool flag = T138.M1536("acc") != null && !T138.M1536("acc").Equals(string.Empty);
			bool flag2 = T138.M1536("userAo" + ipSelect) != null && !T138.M1536("userAo" + ipSelect).Equals(string.Empty);
			if (!flag && !flag2)
			{
				T51.M449();
				string text = T138.M1536("userAo" + ipSelect);
				if (text != null && !text.Equals(string.Empty))
				{
					T51.loginScr.isLogin2 = true;
					T51.M449();
					T146.M1594().M1630();
					T146.M1594().M1634(text, string.Empty, T52.VERSION, 1);
				}
				else
				{
					T146.M1594().M1717(string.Empty);
				}
				if (T147.connected)
				{
					T51.M492();
				}
				else
				{
					T51.M489(mResources.maychutathoacmatsong);
				}
			}
			else
			{
				T51.loginScr.M861();
			}
			T90.serverName = nameServer[ipSelect];
		}
		if (idAction == 10100)
		{
			if (T51.loginScr == null)
			{
				T51.loginScr = new T90();
			}
			T51.loginScr.switchToMe();
			T51.M449();
			T146.M1594().M1717(string.Empty);
			T137.M1513("tao user ao");
			T51.M492();
			T90.serverName = nameServer[ipSelect];
		}
		if (idAction == 5)
		{
			M1580();
			if (nameServer.Length == 1)
			{
				return;
			}
			T117 t = new T117(string.Empty);
			for (int i = 0; i < nameServer.Length; i++)
			{
				t.M1111(new T22(nameServer[i], this, 6, null));
			}
			T51.menu.M877(t, 0);
			if (!T51.isTouch)
			{
				T51.menu.menuSelectedItem = ipSelect;
			}
		}
		if (idAction == 6)
		{
			ipSelect = T51.menu.menuSelectedItem;
			M1582();
		}
		if (idAction == 7)
		{
			if (T51.loginScr == null)
			{
				T51.loginScr = new T90();
			}
			T51.loginScr.switchToMe();
		}
		if (idAction == 8)
		{
			bool flag3 = T138.M1542("lowGraphic") == 1;
			T117 t2 = new T117("cau hinh");
			t2.M1111(new T22(mResources.cauhinhthap, this, 9, null));
			t2.M1111(new T22(mResources.cauhinhcao, this, 10, null));
			T51.menu.M877(t2, 0);
			if (flag3)
			{
				T51.menu.menuSelectedItem = 0;
			}
			else
			{
				T51.menu.menuSelectedItem = 1;
			}
		}
		if (idAction == 9)
		{
			T138.M1543("lowGraphic", 1);
			T51.M494(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 10)
		{
			T138.M1543("lowGraphic", 0);
			T51.M494(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 11)
		{
			if (T51.loginScr == null)
			{
				T51.loginScr = new T90();
			}
			T51.loginScr.switchToMe();
			string text2 = T138.M1536("userAo" + ipSelect);
			if (text2 != null && !text2.Equals(string.Empty))
			{
				T51.loginScr.isLogin2 = true;
				T51.M449();
				T146.M1594().M1630();
				T146.M1594().M1634(text2, string.Empty, T52.VERSION, 1);
			}
			else
			{
				T146.M1594().M1717(string.Empty);
			}
			T51.M490(mResources.PLEASEWAIT);
			T137.M1513("tao user ao");
		}
		if (idAction == 12)
		{
			T52.instance.M520();
		}
		if (idAction == 13 && (!isGetData || loadScreen))
		{
			switch (T110.clientType)
			{
			case 1:
				T110.M1044();
				break;
			case 4:
				T110.M1043();
				break;
			case 3:
			case 5:
				T110.M1045();
				break;
			case 6:
				T110.M1046();
				break;
			}
		}
		if (idAction == 14)
		{
			T22 cmdYes = new T22(mResources.YES, T51.serverScreen, 15, null);
			T22 cmdNo = new T22(mResources.NO, T51.serverScreen, 16, null);
			T51.M496(mResources.deletaDataNote, cmdYes, cmdNo);
		}
		if (idAction == 15)
		{
			T138.M1547();
			T51.M494(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 16)
		{
			T66.M753();
			T51.currentDialog = null;
		}
		if (idAction == 17)
		{
			if (T51.serverScr == null)
			{
				T51.serverScr = new T145();
			}
			T51.serverScr.switchToMe();
		}
	}

	public void M1591()
	{
		if (!loadScreen)
		{
			cmdDownload = new T22(mResources.taidulieu, this, 2, null);
			cmdDownload.isFocus = true;
			cmdDownload.x = T51.w / 2 - T108.cmdW / 2;
			cmdDownload.y = T51.hh + 45;
			if (cmdDownload.y > T51.h - 26)
			{
				cmdDownload.y = T51.h - 26;
			}
		}
		if (!T51.isTouch)
		{
			selected = 0;
			M1583();
		}
	}

	public void M1592()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T54.cmx = 0;
		T54.cmy = 0;
		M1579();
		loadScreen = false;
		percent = 0;
		bigOk = false;
		isGetData = false;
		p = 0;
		demPercent = 0;
		strWait = mResources.PLEASEWAIT;
		M1591();
		base.switchToMe();
	}

	public void M1593(sbyte language)
	{
		switch (language)
		{
		default:
			linkDefault = javaVN;
			if (T110.clientType == 1)
			{
				linkDefault = javaVN;
			}
			else
			{
				linkDefault = smartPhoneVN;
			}
			break;
		case 2:
			if (T110.clientType == 1)
			{
				linkDefault = javaIn;
			}
			else
			{
				linkDefault = smartPhoneIn;
			}
			break;
		case 1:
			linkDefault = javaE;
			if (T110.clientType == 1)
			{
				linkDefault = javaE;
			}
			else
			{
				linkDefault = smartPhoneE;
			}
			break;
		}
	}
}
