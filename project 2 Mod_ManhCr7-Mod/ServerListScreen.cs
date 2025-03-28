using System;
using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using Utilities;
using Xmap;

public class ServerListScreen : mScreen, IActionListener
{
	public static string[] nameServer;

	public static string[] address;

	public static sbyte serverPriority;

	public static bool[] hasConnected;

	public static short[] port;

	public static int selected;

	public static bool isWait;

	public static Command cmdUpdateServer;

	public static sbyte[] language;

	private Command[] cmd;

	private Command cmdCallHotline;

	private int nCmdPlay;

	public static Command cmdDeleteRMS;

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

	public static Command cmdDownload;

	private Command cmdStart;

	public string dataSize;

	public static int p;

	public static int testConnect;

	public static bool loadScreen;

	public ServerListScreen()
	{
		int num = 4;
		if (184 >= GameCanvas.w)
		{
			num--;
		}
		M1579();
		if (!GameCanvas.isTouch)
		{
			selected = 0;
			M1583();
		}
		GameScr.M564(fullmScreen: true, -1, -1);
		GameScr.cmx = 100;
		GameScr.cmy = 200;
		if (cmdCallHotline == null)
		{
			cmdCallHotline = new Command("Gọi hotline", this, 13, null);
			cmdCallHotline.x = GameCanvas.w - 75;
			if (mSystem.clientType == 1 && !GameCanvas.isTouch)
			{
				cmdCallHotline.y = GameCanvas.h - 20;
			}
			else
			{
				cmdCallHotline.y = 8;
			}
		}
		cmdUpdateServer = new Command();
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
		M1593(mSystem.LANGUAGE);
	}

	static ServerListScreen()
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
			if (GameCanvas.serverScreen == null)
			{
				GameCanvas.serverScreen = new ServerListScreen();
			}
			cmdDeleteRMS = new Command(string.Empty, GameCanvas.serverScreen, 14, null);
			cmdDeleteRMS.x = GameCanvas.w - 78;
			cmdDeleteRMS.y = GameCanvas.h - 26;
		}
	}

	private void M1579()
	{
		nCmdPlay = 0;
		string text = Rms.M1536("acc");
		if (text == null)
		{
			if (Rms.M1535("userAo" + ipSelect) != null)
			{
				nCmdPlay = 1;
			}
		}
		else if (text.Equals(string.Empty))
		{
			if (Rms.M1535("userAo" + ipSelect) != null)
			{
				nCmdPlay = 1;
			}
		}
		else
		{
			nCmdPlay = 1;
		}
		cmd = new Command[(mGraphics.zoomLevel <= 1) ? (4 + nCmdPlay) : (3 + nCmdPlay)];
		int num = GameCanvas.hh - 15 * cmd.Length + 28;
		for (int i = 0; i < cmd.Length; i++)
		{
			switch (i)
			{
			case 0:
				cmd[0] = new Command(string.Empty, this, 3, null);
				if (text == null)
				{
					cmd[0].caption = mResources.playNew;
					if (Rms.M1535("userAo" + ipSelect) != null)
					{
						cmd[0].caption = mResources.choitiep;
					}
					break;
				}
				if (text.Equals(string.Empty))
				{
					cmd[0].caption = mResources.playNew;
					if (Rms.M1535("userAo" + ipSelect) != null)
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
					cmd[1] = new Command(string.Empty, this, 10100, null);
					cmd[1].caption = mResources.playNew;
				}
				else
				{
					cmd[1] = new Command(mResources.change_account, this, 7, null);
				}
				break;
			case 2:
				if (nCmdPlay == 1)
				{
					cmd[2] = new Command(mResources.change_account, this, 7, null);
				}
				else
				{
					cmd[2] = new Command(string.Empty, this, 17, null);
				}
				break;
			case 3:
				if (nCmdPlay == 1)
				{
					cmd[3] = new Command(string.Empty, this, 17, null);
				}
				else
				{
					cmd[3] = new Command(mResources.option, this, 8, null);
				}
				break;
			case 4:
				cmd[4] = new Command(mResources.option, this, 8, null);
				break;
			}
			cmd[i].y = num;
			cmd[i].M295();
			cmd[i].x = (GameCanvas.w - cmd[i].w) / 2;
			num += 30;
		}
	}

	public static void M1580()
	{
		if (cmdUpdateServer == null && GameCanvas.serverScreen == null)
		{
			GameCanvas.serverScreen = new ServerListScreen();
		}
		Net.M1154(linkDefault, cmdUpdateServer);
	}

	public static void M1581(string str)
	{
		lengthServer = new int[3];
		string[] array = Res.M1531(str.Trim(), ",", 0);
		Res.M1513("tem leng= " + array.Length);
		mResources.loadLanguague(sbyte.Parse(array[array.Length - 2]));
		nameServer = new string[array.Length - 2];
		address = new string[array.Length - 2];
		port = new short[array.Length - 2];
		language = new sbyte[array.Length - 2];
		hasConnected = new bool[2];
		for (int i = 0; i < array.Length - 2; i++)
		{
			string[] array2 = Res.M1531(array[i].Trim(), ":", 0);
			nameServer[i] = array2[0];
			address[i] = array2[1];
			port[i] = short.Parse(array2[2]);
			language[i] = sbyte.Parse(array2[3].Trim());
			lengthServer[language[i]]++;
		}
		serverPriority = sbyte.Parse(array[array.Length - 1]);
		M1585();
		GameCanvas.M488();
	}

	public override void paint(mGraphics g)
	{
		if (!loadScreen)
		{
			g.M933(0);
			g.M932(0, 0, GameCanvas.w, GameCanvas.h);
			if (bigOk)
			{
			}
		}
		else
		{
			GameCanvas.M466(g);
		}
		int y = 2;
		mFont.tahoma_7_white.M902(g, "v" + GameMidlet.VERSION + "(" + mGraphics.zoomLevel + ")", GameCanvas.w - 2, 17, 1, mFont.tahoma_7_grey);
		if (isGetData && !loadScreen)
		{
			mFont.tahoma_7_white.M902(g, linkweb, GameCanvas.w - 2, y, 1, mFont.tahoma_7_grey);
		}
		else if (mSystem.clientType == 1 && !GameCanvas.isTouch)
		{
			mFont.tahoma_7_white.M902(g, linkweb, GameCanvas.w - 2, GameCanvas.h - 15, 1, mFont.tahoma_7_grey);
		}
		else
		{
			mFont.tahoma_7_white.M902(g, linkweb, GameCanvas.w - 2, y, 1, mFont.tahoma_7_grey);
		}
		if (cmdDeleteRMS != null)
		{
			mFont.tahoma_7_white.M902(g, mResources.xoadulieu, GameCanvas.w - 2, GameCanvas.h - 15, 1, mFont.tahoma_7_grey);
		}
		if (GameCanvas.currentDialog == null)
		{
			if (!loadScreen)
			{
				if (!bigOk)
				{
					g.M948(GameAutomationHub.logoServerListScreen, GameCanvas.hw, GameCanvas.hh - 32, 3);
					if (!isGetData)
					{
						mFont.tahoma_7b_white.M898(g, mResources.taidulieudechoi, GameCanvas.hw, GameCanvas.hh + 24, 2);
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
						mFont.tahoma_7b_white.M898(g, mResources.downloading_data + percent + "%", GameCanvas.w / 2, GameCanvas.hh + 24, 2);
						GameScr.M533(GameScr.frBarPow20, GameScr.frBarPow21, GameScr.frBarPow22, GameCanvas.w / 2 - 50, GameCanvas.hh + 45, 100, 100f, g);
						GameScr.M533(GameScr.frBarPow0, GameScr.frBarPow1, GameScr.frBarPow2, GameCanvas.w / 2 - 50, GameCanvas.hh + 45, 100, percent, g);
					}
				}
			}
			else
			{
				int num = GameCanvas.hh - 15 * cmd.Length - 15;
				if (num < 25)
				{
					num = 25;
				}
				if (GameAutomationHub.logoServerListScreen != null)
				{
					g.M948(GameAutomationHub.logoServerListScreen, GameCanvas.hw, num, 3);
				}
				for (int i = 0; i < cmd.Length; i++)
				{
					cmd[i].M296(g);
				}
				g.M922(0, 0, GameCanvas.w, GameCanvas.h);
				if (testConnect == -1)
				{
					if (GameCanvas.gameTick % 20 > 10)
					{
						g.M940(GameScr.imgRoomStat, 0, 14, 7, 7, 0, (GameCanvas.w - mFont.tahoma_7b_dark.M909(cmd[2 + nCmdPlay].caption) >> 1) - 10, cmd[2 + nCmdPlay].y + 10, 0);
					}
				}
				else
				{
					g.M940(GameScr.imgRoomStat, 0, testConnect * 7, 7, 7, 0, (GameCanvas.w - mFont.tahoma_7b_dark.M909(cmd[2 + nCmdPlay].caption) >> 1) - 10, cmd[2 + nCmdPlay].y + 9, 0);
				}
			}
		}
		base.paint(g);
	}

	public void M1582()
	{
		flagServer = 30;
		GameCanvas.M490(mResources.PLEASEWAIT);
		if (Session_ME.M1744().isConnected())
		{
			Session_ME.M1744().close();
		}
		GameMidlet.IP = address[ipSelect];
		GameMidlet.PORT = port[ipSelect];
		if (language[ipSelect] != mResources.language)
		{
			mResources.loadLanguague(language[ipSelect]);
		}
		LoginScr.serverName = nameServer[ipSelect];
		M1579();
		GameCanvas.M449();
	}

	public override void update()
	{
		GameAutomationHub.M2218();
		if (waitToLogin)
		{
			tWaitToLogin++;
			if (tWaitToLogin == 50)
			{
				GameCanvas.serverScreen.M1582();
			}
			if (tWaitToLogin == 100)
			{
				if (GameCanvas.loginScr == null)
				{
					GameCanvas.loginScr = new LoginScr();
				}
				GameCanvas.loginScr.M861();
				Service.M1594().M1711();
				waitToLogin = false;
			}
		}
		if (flagServer > 0)
		{
			flagServer--;
			if (flagServer == 0)
			{
				GameCanvas.M488();
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
		GameScr.cmx++;
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
			center = new Command(string.Empty, this, cmd[selected].idAction, null);
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
		if (GameCanvas.isTouch)
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
			if (GameCanvas.keyPressed[8])
			{
				int num = ((mGraphics.zoomLevel <= 1) ? 4 : 2);
				GameCanvas.keyPressed[8] = false;
				selected++;
				if (selected > num)
				{
					selected = 0;
				}
				M1583();
			}
			if (GameCanvas.keyPressed[2])
			{
				int num2 = ((mGraphics.zoomLevel <= 1) ? 4 : 2);
				GameCanvas.keyPressed[2] = false;
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
		DataOutputStream t = new DataOutputStream();
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
			Rms.M1534("NRlink2", t.M371());
			t.M372();
			SplashScr.M1880();
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
		sbyte[] array = Rms.M1535("NRlink2");
		if (array == null)
		{
			M1581(linkDefault);
			return;
		}
		DataInputStream t = new DataInputStream(array);
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
			SplashScr.M1880();
		}
		catch (Exception)
		{
		}
	}

	public override void switchToMe()
	{
		GameCanvas.M449();
		GameScr.cmy = 0;
		GameScr.cmx = 0;
		M1579();
		isWait = false;
		GameCanvas.loginScr = null;
		string text = Rms.M1536("ResVersion");
		if (((text == null || !(text != string.Empty)) ? (-1) : int.Parse(text)) > 0)
		{
			loadScreen = true;
			GameCanvas.M469(0);
		}
		bigOk = true;
		cmd[2 + nCmdPlay].caption = mResources.server + ": " + nameServer[ipSelect];
		center = new Command(string.Empty, this, cmd[selected].idAction, null);
		cmd[1 + nCmdPlay].caption = mResources.change_account;
		if (cmd.Length == 4 + nCmdPlay)
		{
			cmd[3 + nCmdPlay].caption = mResources.option;
		}
		mSystem.M1038();
		base.switchToMe();
	}

	public void M1588()
	{
		GameScr.cmy = 0;
		GameScr.cmx = 0;
		M1579();
		isWait = false;
		GameCanvas.loginScr = null;
		string text = Rms.M1536("ResVersion");
		if (((text == null || !(text != string.Empty)) ? (-1) : int.Parse(text)) > 0)
		{
			loadScreen = true;
			GameCanvas.M469(0);
		}
		bigOk = true;
		cmd[2 + nCmdPlay].caption = mResources.server + ": " + nameServer[ipSelect];
		center = new Command(string.Empty, this, cmd[selected].idAction, null);
		cmd[1 + nCmdPlay].caption = mResources.change_account;
		if (cmd.Length == 4 + nCmdPlay)
		{
			cmd[3 + nCmdPlay].caption = mResources.option;
		}
		mSystem.M1038();
		base.switchToMe();
	}

	public void M1589()
	{
	}

	public void M1590()
	{
		if (GameCanvas.serverScreen == null)
		{
			GameCanvas.serverScreen = new ServerListScreen();
		}
		demPercent = 0;
		percent = 0;
		stopDownload = true;
		GameCanvas.serverScreen.M1592();
		isGetData = false;
		cmdDownload.isFocus = true;
		center = new Command(string.Empty, this, 2, null);
	}

	public void perform(int idAction, object p)
	{
		Res.M1513("perform " + idAction);
		if (idAction == 1000)
		{
			GameCanvas.M449();
		}
		if (idAction == 1 || idAction == 4)
		{
			M1590();
		}
		if (idAction == 2)
		{
			stopDownload = false;
			cmdDownload = new Command(mResources.huy, this, 4, null);
			cmdDownload.x = GameCanvas.w / 2 - mScreen.cmdW / 2;
			cmdDownload.y = GameCanvas.hh + 65;
			right = null;
			if (!GameCanvas.isTouch)
			{
				cmdDownload.x = GameCanvas.w / 2 - mScreen.cmdW / 2;
				cmdDownload.y = GameCanvas.h - mScreen.cmdH - 1;
			}
			center = new Command(string.Empty, this, 4, null);
			if (!isGetData)
			{
				Service.M1594().M1720(1, null);
				if (!GameCanvas.isTouch)
				{
					cmdDownload.isFocus = true;
					center = new Command(string.Empty, this, 4, null);
				}
				isGetData = true;
			}
		}
		if (idAction == 3)
		{
			Res.M1513("toi day");
			if (GameCanvas.loginScr == null)
			{
				GameCanvas.loginScr = new LoginScr();
			}
			GameCanvas.loginScr.switchToMe();
			bool flag = Rms.M1536("acc") != null && !Rms.M1536("acc").Equals(string.Empty);
			bool flag2 = Rms.M1536("userAo" + ipSelect) != null && !Rms.M1536("userAo" + ipSelect).Equals(string.Empty);
			if (!flag && !flag2)
			{
				GameCanvas.M449();
				string text = Rms.M1536("userAo" + ipSelect);
				if (text != null && !text.Equals(string.Empty))
				{
					GameCanvas.loginScr.isLogin2 = true;
					GameCanvas.M449();
					Service.M1594().M1630();
					Service.M1594().M1634(text, string.Empty, GameMidlet.VERSION, 1);
				}
				else
				{
					Service.M1594().M1717(string.Empty);
				}
				if (Session_ME.connected)
				{
					GameCanvas.M492();
				}
				else
				{
					GameCanvas.M489(mResources.maychutathoacmatsong);
				}
			}
			else
			{
				GameCanvas.loginScr.M861();
			}
			LoginScr.serverName = nameServer[ipSelect];
		}
		if (idAction == 10100)
		{
			if (GameCanvas.loginScr == null)
			{
				GameCanvas.loginScr = new LoginScr();
			}
			GameCanvas.loginScr.switchToMe();
			GameCanvas.M449();
			Service.M1594().M1717(string.Empty);
			Res.M1513("tao user ao");
			GameCanvas.M492();
			LoginScr.serverName = nameServer[ipSelect];
		}
		if (idAction == 5)
		{
			M1580();
			if (nameServer.Length == 1)
			{
				return;
			}
			MyVector t = new MyVector(string.Empty);
			for (int i = 0; i < nameServer.Length; i++)
			{
				t.M1111(new Command(nameServer[i], this, 6, null));
			}
			GameCanvas.menu.M877(t, 0);
			if (!GameCanvas.isTouch)
			{
				GameCanvas.menu.menuSelectedItem = ipSelect;
			}
		}
		if (idAction == 6)
		{
			ipSelect = GameCanvas.menu.menuSelectedItem;
			M1582();
		}
		if (idAction == 7)
		{
			if (GameCanvas.loginScr == null)
			{
				GameCanvas.loginScr = new LoginScr();
			}
			GameCanvas.loginScr.switchToMe();
		}
		if (idAction == 8)
		{
			bool flag3 = Rms.M1542("lowGraphic") == 1;
			MyVector t2 = new MyVector("cau hinh");
			t2.M1111(new Command(mResources.cauhinhthap, this, 9, null));
			t2.M1111(new Command(mResources.cauhinhcao, this, 10, null));
			GameCanvas.menu.M877(t2, 0);
			if (flag3)
			{
				GameCanvas.menu.menuSelectedItem = 0;
			}
			else
			{
				GameCanvas.menu.menuSelectedItem = 1;
			}
		}
		if (idAction == 9)
		{
			Rms.M1543("lowGraphic", 1);
			GameCanvas.M494(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 10)
		{
			Rms.M1543("lowGraphic", 0);
			GameCanvas.M494(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 11)
		{
			if (GameCanvas.loginScr == null)
			{
				GameCanvas.loginScr = new LoginScr();
			}
			GameCanvas.loginScr.switchToMe();
			string text2 = Rms.M1536("userAo" + ipSelect);
			if (text2 != null && !text2.Equals(string.Empty))
			{
				GameCanvas.loginScr.isLogin2 = true;
				GameCanvas.M449();
				Service.M1594().M1630();
				Service.M1594().M1634(text2, string.Empty, GameMidlet.VERSION, 1);
			}
			else
			{
				Service.M1594().M1717(string.Empty);
			}
			GameCanvas.M490(mResources.PLEASEWAIT);
			Res.M1513("tao user ao");
		}
		if (idAction == 12)
		{
			GameMidlet.instance.M520();
		}
		if (idAction == 13 && (!isGetData || loadScreen))
		{
			switch (mSystem.clientType)
			{
			case 1:
				mSystem.M1044();
				break;
			case 4:
				mSystem.M1043();
				break;
			case 3:
			case 5:
				mSystem.M1045();
				break;
			case 6:
				mSystem.M1046();
				break;
			}
		}
		if (idAction == 14)
		{
			Command cmdYes = new Command(mResources.YES, GameCanvas.serverScreen, 15, null);
			Command cmdNo = new Command(mResources.NO, GameCanvas.serverScreen, 16, null);
			GameCanvas.M496(mResources.deletaDataNote, cmdYes, cmdNo);
		}
		if (idAction == 15)
		{
			Rms.M1547();
			GameCanvas.M494(mResources.plsRestartGame, 8885, null);
		}
		if (idAction == 16)
		{
			InfoDlg.M753();
			GameCanvas.currentDialog = null;
		}
		if (idAction == 17)
		{
			if (GameCanvas.serverScr == null)
			{
				GameCanvas.serverScr = new ServerScreen();
			}
			GameCanvas.serverScr.switchToMe();
		}
	}

	public void M1591()
	{
		if (!loadScreen)
		{
			cmdDownload = new Command(mResources.taidulieu, this, 2, null);
			cmdDownload.isFocus = true;
			cmdDownload.x = GameCanvas.w / 2 - mScreen.cmdW / 2;
			cmdDownload.y = GameCanvas.hh + 45;
			if (cmdDownload.y > GameCanvas.h - 26)
			{
				cmdDownload.y = GameCanvas.h - 26;
			}
		}
		if (!GameCanvas.isTouch)
		{
			selected = 0;
			M1583();
		}
	}

	public void M1592()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		GameScr.cmx = 0;
		GameScr.cmy = 0;
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
			if (mSystem.clientType == 1)
			{
				linkDefault = javaVN;
			}
			else
			{
				linkDefault = smartPhoneVN;
			}
			break;
		case 2:
			if (mSystem.clientType == 1)
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
			if (mSystem.clientType == 1)
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
