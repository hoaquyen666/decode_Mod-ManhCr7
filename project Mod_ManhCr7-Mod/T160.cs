using System;

public class T160
{
	public class T220
	{
	}

	public class T221
	{
	}

	public class T222
	{
	}

	public static T160 gIz;

	public static bool isSound = true;

	public static float volume = 0.5f;

	private static int MAX_VOLUME = 10;

	public static T220[] music;

	public static T221[] sound;

	public static int[] soundID;

	public static int AIR_SHIP;

	public static int RAIN = 1;

	public static int TAITAONANGLUONG = 2;

	public static int GET_ITEM;

	public static int MOVE = 1;

	public static int LOW_PUNCH = 2;

	public static int LOW_KICK = 3;

	public static int FLY = 4;

	public static int JUMP = 5;

	public static int PANEL_OPEN = 6;

	public static int BUTTON_CLOSE = 7;

	public static int BUTTON_CLICK = 8;

	public static int MEDIUM_PUNCH = 9;

	public static int MEDIUM_KICK = 10;

	public static int PANEL_CLICK = 11;

	public static int EAT_PEAN = 12;

	public static int OPEN_DIALOG = 13;

	public static int NORMAL_KAME = 14;

	public static int NAMEK_KAME = 15;

	public static int XAYDA_KAME = 16;

	public static int EXPLODE_1 = 17;

	public static int EXPLODE_2 = 18;

	public static int TRAIDAT_KAME = 19;

	public static int HP_UP = 20;

	public static int THAIDUONGHASAN = 21;

	public static int HOISINH = 22;

	public static int GONG = 23;

	public static int KHICHAY = 24;

	public static int BIG_EXPLODE = 25;

	public static int NAMEK_LAZER = 26;

	public static int NAMEK_CHARGE = 27;

	public static int RADAR_CLICK = 28;

	public static int RADAR_ITEM = 29;

	public static int FIREWORK = 30;

	public bool freePool;

	public int poolCount;

	public static int cout = 1;

	public static void M1825(T222 ac)
	{
		T159.M1793(ac);
	}

	public static T160 M1826()
	{
		if (gIz == null)
		{
			gIz = new T160();
		}
		return gIz;
	}

	public void M1827(int mapID)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T159.M1797(new int[3] { AIR_SHIP, RAIN, TAITAONANGLUONG }, new int[31]
		{
			GET_ITEM, MOVE, LOW_PUNCH, LOW_KICK, FLY, JUMP, PANEL_OPEN, BUTTON_CLOSE, BUTTON_CLICK, MEDIUM_PUNCH,
			MEDIUM_KICK, PANEL_OPEN, EAT_PEAN, OPEN_DIALOG, NORMAL_KAME, NAMEK_KAME, XAYDA_KAME, EXPLODE_1, EXPLODE_2, TRAIDAT_KAME,
			HP_UP, THAIDUONGHASAN, HOISINH, GONG, KHICHAY, BIG_EXPLODE, NAMEK_LAZER, NAMEK_CHARGE, RADAR_CLICK, RADAR_ITEM,
			FIREWORK
		});
	}

	public void M1828()
	{
		if (T51.loginScr.isLogin2 && T13.M113().taskMaint != null && T13.M113().taskMaint.taskId >= 2)
		{
			T126.strTool = new string[10]
			{
				mResources.radaCard,
				mResources.quayso,
				mResources.gameInfo,
				mResources.change_flag,
				mResources.change_zone,
				mResources.chat_world,
				mResources.account,
				mResources.option,
				mResources.change_account,
				mResources.REGISTOPROTECT
			};
			if (T13.M113().havePet)
			{
				T126.strTool = new string[11]
				{
					mResources.radaCard,
					mResources.quayso,
					mResources.gameInfo,
					mResources.pet,
					mResources.change_flag,
					mResources.change_zone,
					mResources.chat_world,
					mResources.account,
					mResources.option,
					mResources.change_account,
					mResources.REGISTOPROTECT
				};
			}
		}
		else
		{
			T126.strTool = new string[9]
			{
				mResources.radaCard,
				mResources.quayso,
				mResources.gameInfo,
				mResources.change_flag,
				mResources.change_zone,
				mResources.chat_world,
				mResources.account,
				mResources.option,
				mResources.change_account
			};
			if (T13.M113().havePet)
			{
				T126.strTool = new string[10]
				{
					mResources.radaCard,
					mResources.quayso,
					mResources.gameInfo,
					mResources.pet,
					mResources.change_flag,
					mResources.change_zone,
					mResources.chat_world,
					mResources.account,
					mResources.option,
					mResources.change_account
				};
			}
		}
	}

	public void M1829()
	{
		if (Main.isPC)
		{
			T126.strCauhinh = new string[4]
			{
				(T13.M113().idHat == -1) ? mResources.hat_on : mResources.hat_off,
				(!T13.isPaintAura) ? mResources.aura_on : mResources.aura_off,
				(!T51.isPlaySound) ? mResources.turnOnSound : mResources.turnOffSound,
				(T99.zoomLevel <= 1) ? mResources.x2Screen : mResources.x1Screen
			};
		}
		else
		{
			T126.strCauhinh = new string[4]
			{
				(T13.M113().idHat == -1) ? mResources.hat_on : mResources.hat_off,
				(!T13.isPaintAura) ? mResources.aura_on : mResources.aura_off,
				(!T51.isPlaySound) ? mResources.turnOnSound : mResources.turnOffSound,
				(T54.isAnalog != 0) ? mResources.turnOffAnalog : mResources.turnOnAnalog
			};
		}
	}

	public void M1830()
	{
		T159.M1798(HP_UP, 0.5f);
	}

	public void M1831(bool isKick, float volumn)
	{
		if (!T13.M113().me)
		{
			volume /= 2f;
		}
		if (volumn <= 0f)
		{
			volumn = 0.01f;
		}
		int num = T137.M1522(0, 3);
		if (isKick)
		{
			T159.M1798((num != 0) ? MEDIUM_KICK : LOW_KICK, 0.1f);
		}
		else
		{
			T159.M1798((num != 0) ? MEDIUM_PUNCH : LOW_PUNCH, 0.1f);
		}
		poolCount++;
	}

	public void M1832()
	{
		T159.M1798(THAIDUONGHASAN, 0.5f);
		poolCount++;
	}

	public void M1833()
	{
		T159.M1812(RAIN, 0.3f, loop: true);
	}

	public void M1834()
	{
		T159.M1798(NAMEK_CHARGE, 0.3f);
		poolCount++;
	}

	public void M1835()
	{
		T159.M1798(GONG, 0.2f);
		poolCount++;
	}

	public void M1836()
	{
		T159.M1798(GET_ITEM, 0.3f);
		poolCount++;
	}

	public void M1837()
	{
		T51.isPlaySound = !T51.isPlaySound;
		if (T51.isPlaySound)
		{
			M1826().M1827(T174.mapID);
			T138.M1543("isPlaySound", 1);
		}
		else
		{
			M1826().M1841();
			T138.M1543("isPlaySound", 0);
		}
		M1829();
	}

	public void M1838()
	{
		if (T13.isPaintAura)
		{
			T138.M1543("isPaintAura", 0);
			T13.isPaintAura = false;
		}
		else
		{
			T138.M1543("isPaintAura", 1);
			T13.isPaintAura = true;
		}
		M1829();
	}

	public void M1839()
	{
		T146.M1594().M1742();
	}

	public void M1840()
	{
	}

	public void M1841()
	{
		T159.stopAll = true;
		M1873();
	}

	public void M1842()
	{
		if (T159.music == null)
		{
			M1827(0);
		}
		T159.stopAll = false;
	}

	public void M1843()
	{
		T159.M1798(BIG_EXPLODE, 0.5f);
		poolCount++;
	}

	public void M1844()
	{
		T159.M1798(EXPLODE_1, 0.5f);
		poolCount++;
	}

	public void M1845()
	{
		T159.M1798(EXPLODE_1, 0.5f);
		poolCount++;
	}

	public void M1846()
	{
		T159.M1798(TRAIDAT_KAME, 1f);
		poolCount++;
	}

	public void M1847()
	{
		T159.M1798(NAMEK_KAME, 0.3f);
		poolCount++;
	}

	public void M1848()
	{
		T159.M1798(NAMEK_LAZER, 0.3f);
		poolCount++;
	}

	public void M1849()
	{
		T159.M1798(XAYDA_KAME, 0.3f);
		poolCount++;
	}

	public void M1850(int type)
	{
		int id = XAYDA_KAME;
		if (type == 13)
		{
			id = NORMAL_KAME;
		}
		T159.M1798(id, 0.1f);
		poolCount++;
	}

	public void M1851(float volumn)
	{
		if (!T13.M113().me)
		{
			volume /= 2f;
			if (volumn <= 0f)
			{
				volumn = 0.01f;
			}
		}
		if (T51.gameTick % 8 == 0)
		{
			T159.M1798(MOVE, volumn);
			poolCount++;
		}
	}

	public void M1852(float volumn)
	{
		if (T51.gameTick % 8 == 0)
		{
			T159.M1798(KHICHAY, 0.2f);
			poolCount++;
		}
	}

	public void M1853()
	{
		T159.M1798(MOVE, 0.1f);
		poolCount++;
	}

	public void M1854()
	{
		T159.M1798(MOVE, 0.2f);
		poolCount++;
	}

	public void M1855()
	{
		T159.M1798(PANEL_OPEN, 0.5f);
		poolCount++;
	}

	public void M1856()
	{
		T159.M1798(BUTTON_CLOSE, 0.5f);
		poolCount++;
	}

	public void M1857()
	{
		T159.M1798(BUTTON_CLICK, 0.5f);
		poolCount++;
	}

	public void M1858()
	{
	}

	public void M1859()
	{
		T159.M1798(FLY, 0.2f);
		poolCount++;
	}

	public void M1860()
	{
	}

	public void M1861()
	{
		T159.M1798(BUTTON_CLOSE, 0.5f);
		poolCount++;
	}

	public void M1862()
	{
		T159.M1798(PANEL_CLICK, 0.5f);
		poolCount++;
	}

	public void M1863()
	{
		T159.M1798(EAT_PEAN, 0.5f);
		poolCount++;
	}

	public void M1864()
	{
		T159.M1798(OPEN_DIALOG, 0.5f);
	}

	public void M1865()
	{
		T159.M1798(HOISINH, 0.5f);
		poolCount++;
	}

	public void M1866()
	{
		T159.M1812(TAITAONANGLUONG, 0.5f, loop: true);
	}

	public void M1867()
	{
	}

	public bool M1868()
	{
		try
		{
			return T159.M1808();
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool M1869()
	{
		return false;
	}

	public void M1870()
	{
		cout++;
		if (cout % 2 == 0)
		{
			T159.M1812(AIR_SHIP, 0.3f, loop: false);
		}
	}

	public void M1871()
	{
	}

	public void M1872()
	{
	}

	public void M1873()
	{
		T159.M1801();
	}

	public void M1874()
	{
		T147.M1744().close();
		T51.panel.M1382();
		T51.loginScr.M867();
		T51.loginScr.switchToMe();
	}

	public void M1875()
	{
		poolCount++;
		if (poolCount % 15 == 0)
		{
			T159.M1798(TRAIDAT_KAME, 0.5f);
		}
	}

	public void M1876()
	{
		T159.M1798(RADAR_CLICK, 0.5f);
	}

	public void M1877()
	{
		T159.M1798(RADAR_ITEM, 0.5f);
	}

	public static void M1878(int x, int y, int id, float volume)
	{
		T159.M1798(id, volume);
	}
}
