using N3.N4;

public class T161 : T108
{
	public static int splashScrStat;

	private bool isCheckConnect;

	private bool isSwitchToLogin;

	public static int nData;

	public static int maxData;

	public static T161 instance;

	public static T60 imgLogo;

	public T161()
	{
		instance = this;
	}

	static T161()
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
			T200.M2200();
			isCheckConnect = true;
			if (T138.M1542("isPlaySound") != -1)
			{
				T51.isPlaySound = T138.M1542("isPlaySound") == 1;
			}
			if (T51.isPlaySound)
			{
				T160.M1826().M1827(T174.mapID);
			}
			T160.M1826().M1829();
			T144.M1587();
		}
		splashScrStat++;
		T144.M1584();
	}

	public static void M1880()
	{
		if (T138.M1542("svselect") == -1)
		{
			int num = 0;
			if (mResources.language > 0)
			{
				for (int i = 0; i < mResources.language; i++)
				{
					num += T144.lengthServer[i];
				}
			}
			if (T144.serverPriority == -1)
			{
				T144.ipSelect = num + T137.M1522(0, T144.lengthServer[mResources.language]);
			}
			else
			{
				T144.ipSelect = T144.serverPriority;
			}
			T138.M1543("svselect", T144.ipSelect);
			T52.IP = T144.address[T144.ipSelect];
			T52.PORT = T144.port[T144.ipSelect];
			mResources.loadLanguague(T144.language[T144.ipSelect]);
			T90.serverName = T144.nameServer[T144.ipSelect];
			T51.M449();
		}
		else
		{
			T144.ipSelect = T138.M1542("svselect");
			if (T144.ipSelect > T144.nameServer.Length - 1)
			{
				T144.ipSelect = T144.serverPriority;
				T138.M1543("svselect", T144.ipSelect);
			}
			T52.IP = T144.address[T144.ipSelect];
			T52.PORT = T144.port[T144.ipSelect];
			mResources.loadLanguague(T144.language[T144.ipSelect]);
			T90.serverName = T144.nameServer[T144.ipSelect];
			T51.M449();
		}
	}

	public override void paint(T99 g)
	{
		if (imgLogo != null && splashScrStat < 30)
		{
			g.M933(16777215);
			g.M932(0, 0, T51.w, T51.h);
			g.M948(imgLogo, T51.w / 2, T51.h / 2, 3);
		}
		if (nData != -1)
		{
			g.M933(0);
			g.M932(0, 0, T51.w, T51.h);
			g.M948(T200.logoServerListScreen, T51.w / 2, T51.h / 2 - 24, T163.BOTTOM_HCENTER);
			T51.M514(T51.hw, T51.h / 2 + 24, g);
			T98.tahoma_7b_white.M898(g, mResources.downloading_data + nData * 100 / maxData + "%", T51.w / 2, T51.h / 2, 2);
		}
		else if (splashScrStat >= 30)
		{
			g.M933(0);
			g.M932(0, 0, T51.w, T51.h);
			T51.M514(T51.hw, T51.hh, g);
			if (T144.cmdDeleteRMS != null)
			{
				T98.tahoma_7_white.M902(g, mResources.xoadulieu, T51.w - 2, T51.h - 15, 1, T98.tahoma_7_grey);
			}
		}
	}

	public static void M1881()
	{
		imgLogo = T51.M503("/gamelogo.png");
	}
}
