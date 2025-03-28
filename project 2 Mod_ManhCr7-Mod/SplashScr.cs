using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using Utilities;
using Xmap;

public class SplashScr : mScreen
{
	public static int splashScrStat;

	private bool isCheckConnect;

	private bool isSwitchToLogin;

	public static int nData;

	public static int maxData;

	public static SplashScr instance;

	public static Image imgLogo;

	public SplashScr()
	{
		instance = this;
	}

	static SplashScr()
	{
		nData = -1;
		maxData = -1;
	}

	public static void M1879()
	{
		splashScrStat = 0;
	}

	public override void update()
	{
		if (splashScrStat == 30 && !isCheckConnect)
		{
			GameAutomationHub.M2200();
			isCheckConnect = true;
			if (Rms.M1542("isPlaySound") != -1)
			{
				GameCanvas.isPlaySound = Rms.M1542("isPlaySound") == 1;
			}
			if (GameCanvas.isPlaySound)
			{
				SoundMn.M1826().M1827(TileMap.mapID);
			}
			SoundMn.M1826().M1829();
			ServerListScreen.M1587();
		}
		splashScrStat++;
		ServerListScreen.M1584();
	}

	public static void M1880()
	{
		if (Rms.M1542("svselect") == -1)
		{
			int num = 0;
			if (mResources.language > 0)
			{
				for (int i = 0; i < mResources.language; i++)
				{
					num += ServerListScreen.lengthServer[i];
				}
			}
			if (ServerListScreen.serverPriority == -1)
			{
				ServerListScreen.ipSelect = num + Res.M1522(0, ServerListScreen.lengthServer[mResources.language]);
			}
			else
			{
				ServerListScreen.ipSelect = ServerListScreen.serverPriority;
			}
			Rms.M1543("svselect", ServerListScreen.ipSelect);
			GameMidlet.IP = ServerListScreen.address[ServerListScreen.ipSelect];
			GameMidlet.PORT = ServerListScreen.port[ServerListScreen.ipSelect];
			mResources.loadLanguague(ServerListScreen.language[ServerListScreen.ipSelect]);
			LoginScr.serverName = ServerListScreen.nameServer[ServerListScreen.ipSelect];
			GameCanvas.M449();
		}
		else
		{
			ServerListScreen.ipSelect = Rms.M1542("svselect");
			if (ServerListScreen.ipSelect > ServerListScreen.nameServer.Length - 1)
			{
				ServerListScreen.ipSelect = ServerListScreen.serverPriority;
				Rms.M1543("svselect", ServerListScreen.ipSelect);
			}
			GameMidlet.IP = ServerListScreen.address[ServerListScreen.ipSelect];
			GameMidlet.PORT = ServerListScreen.port[ServerListScreen.ipSelect];
			mResources.loadLanguague(ServerListScreen.language[ServerListScreen.ipSelect]);
			LoginScr.serverName = ServerListScreen.nameServer[ServerListScreen.ipSelect];
			GameCanvas.M449();
		}
	}

	public override void paint(mGraphics g)
	{
		if (imgLogo != null && splashScrStat < 30)
		{
			g.M933(16777215);
			g.M932(0, 0, GameCanvas.w, GameCanvas.h);
			g.M948(imgLogo, GameCanvas.w / 2, GameCanvas.h / 2, 3);
		}
		if (nData != -1)
		{
			g.M933(0);
			g.M932(0, 0, GameCanvas.w, GameCanvas.h);
			g.M948(GameAutomationHub.logoServerListScreen, GameCanvas.w / 2, GameCanvas.h / 2 - 24, StaticObj.BOTTOM_HCENTER);
			GameCanvas.M514(GameCanvas.hw, GameCanvas.h / 2 + 24, g);
			mFont.tahoma_7b_white.M898(g, mResources.downloading_data + nData * 100 / maxData + "%", GameCanvas.w / 2, GameCanvas.h / 2, 2);
		}
		else if (splashScrStat >= 30)
		{
			g.M933(0);
			g.M932(0, 0, GameCanvas.w, GameCanvas.h);
			GameCanvas.M514(GameCanvas.hw, GameCanvas.hh, g);
			if (ServerListScreen.cmdDeleteRMS != null)
			{
				mFont.tahoma_7_white.M902(g, mResources.xoadulieu, GameCanvas.w - 2, GameCanvas.h - 15, 1, mFont.tahoma_7_grey);
			}
		}
	}

	public static void M1881()
	{
		imgLogo = GameCanvas.M503("/gamelogo.png");
	}
}
