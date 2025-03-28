using System;

public class SoundMn
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

	public static SoundMn gIz;

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
		Sound.M1793(ac);
	}

	public static SoundMn M1826()
	{
		if (gIz == null)
		{
			gIz = new SoundMn();
		}
		return gIz;
	}

	public void M1827(int mapID)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Sound.M1797(new int[3] { AIR_SHIP, RAIN, TAITAONANGLUONG }, new int[31]
		{
			GET_ITEM, MOVE, LOW_PUNCH, LOW_KICK, FLY, JUMP, PANEL_OPEN, BUTTON_CLOSE, BUTTON_CLICK, MEDIUM_PUNCH,
			MEDIUM_KICK, PANEL_OPEN, EAT_PEAN, OPEN_DIALOG, NORMAL_KAME, NAMEK_KAME, XAYDA_KAME, EXPLODE_1, EXPLODE_2, TRAIDAT_KAME,
			HP_UP, THAIDUONGHASAN, HOISINH, GONG, KHICHAY, BIG_EXPLODE, NAMEK_LAZER, NAMEK_CHARGE, RADAR_CLICK, RADAR_ITEM,
			FIREWORK
		});
	}

	public void M1828()
	{
		if (GameCanvas.loginScr.isLogin2 && Char.M113().taskMaint != null && Char.M113().taskMaint.taskId >= 2)
		{
			Panel.strTool = new string[10]
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
			if (Char.M113().havePet)
			{
				Panel.strTool = new string[11]
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
			Panel.strTool = new string[9]
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
			if (Char.M113().havePet)
			{
				Panel.strTool = new string[10]
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
			Panel.strCauhinh = new string[4]
			{
				(Char.M113().idHat == -1) ? mResources.hat_on : mResources.hat_off,
				(!Char.isPaintAura) ? mResources.aura_on : mResources.aura_off,
				(!GameCanvas.isPlaySound) ? mResources.turnOnSound : mResources.turnOffSound,
				(mGraphics.zoomLevel <= 1) ? mResources.x2Screen : mResources.x1Screen
			};
		}
		else
		{
			Panel.strCauhinh = new string[4]
			{
				(Char.M113().idHat == -1) ? mResources.hat_on : mResources.hat_off,
				(!Char.isPaintAura) ? mResources.aura_on : mResources.aura_off,
				(!GameCanvas.isPlaySound) ? mResources.turnOnSound : mResources.turnOffSound,
				(GameScr.isAnalog != 0) ? mResources.turnOffAnalog : mResources.turnOnAnalog
			};
		}
	}

	public void M1830()
	{
		Sound.M1798(HP_UP, 0.5f);
	}

	public void M1831(bool isKick, float volumn)
	{
		if (!Char.M113().me)
		{
			volume /= 2f;
		}
		if (volumn <= 0f)
		{
			volumn = 0.01f;
		}
		int num = Res.M1522(0, 3);
		if (isKick)
		{
			Sound.M1798((num != 0) ? MEDIUM_KICK : LOW_KICK, 0.1f);
		}
		else
		{
			Sound.M1798((num != 0) ? MEDIUM_PUNCH : LOW_PUNCH, 0.1f);
		}
		poolCount++;
	}

	public void M1832()
	{
		Sound.M1798(THAIDUONGHASAN, 0.5f);
		poolCount++;
	}

	public void M1833()
	{
		Sound.M1812(RAIN, 0.3f, loop: true);
	}

	public void M1834()
	{
		Sound.M1798(NAMEK_CHARGE, 0.3f);
		poolCount++;
	}

	public void M1835()
	{
		Sound.M1798(GONG, 0.2f);
		poolCount++;
	}

	public void M1836()
	{
		Sound.M1798(GET_ITEM, 0.3f);
		poolCount++;
	}

	public void M1837()
	{
		GameCanvas.isPlaySound = !GameCanvas.isPlaySound;
		if (GameCanvas.isPlaySound)
		{
			M1826().M1827(TileMap.mapID);
			Rms.M1543("isPlaySound", 1);
		}
		else
		{
			M1826().M1841();
			Rms.M1543("isPlaySound", 0);
		}
		M1829();
	}

	public void M1838()
	{
		if (Char.isPaintAura)
		{
			Rms.M1543("isPaintAura", 0);
			Char.isPaintAura = false;
		}
		else
		{
			Rms.M1543("isPaintAura", 1);
			Char.isPaintAura = true;
		}
		M1829();
	}

	public void M1839()
	{
		Service.M1594().M1742();
	}

	public void M1840()
	{
	}

	public void M1841()
	{
		Sound.stopAll = true;
		M1873();
	}

	public void M1842()
	{
		if (Sound.music == null)
		{
			M1827(0);
		}
		Sound.stopAll = false;
	}

	public void M1843()
	{
		Sound.M1798(BIG_EXPLODE, 0.5f);
		poolCount++;
	}

	public void M1844()
	{
		Sound.M1798(EXPLODE_1, 0.5f);
		poolCount++;
	}

	public void M1845()
	{
		Sound.M1798(EXPLODE_1, 0.5f);
		poolCount++;
	}

	public void M1846()
	{
		Sound.M1798(TRAIDAT_KAME, 1f);
		poolCount++;
	}

	public void M1847()
	{
		Sound.M1798(NAMEK_KAME, 0.3f);
		poolCount++;
	}

	public void M1848()
	{
		Sound.M1798(NAMEK_LAZER, 0.3f);
		poolCount++;
	}

	public void M1849()
	{
		Sound.M1798(XAYDA_KAME, 0.3f);
		poolCount++;
	}

	public void M1850(int type)
	{
		int id = XAYDA_KAME;
		if (type == 13)
		{
			id = NORMAL_KAME;
		}
		Sound.M1798(id, 0.1f);
		poolCount++;
	}

	public void M1851(float volumn)
	{
		if (!Char.M113().me)
		{
			volume /= 2f;
			if (volumn <= 0f)
			{
				volumn = 0.01f;
			}
		}
		if (GameCanvas.gameTick % 8 == 0)
		{
			Sound.M1798(MOVE, volumn);
			poolCount++;
		}
	}

	public void M1852(float volumn)
	{
		if (GameCanvas.gameTick % 8 == 0)
		{
			Sound.M1798(KHICHAY, 0.2f);
			poolCount++;
		}
	}

	public void M1853()
	{
		Sound.M1798(MOVE, 0.1f);
		poolCount++;
	}

	public void M1854()
	{
		Sound.M1798(MOVE, 0.2f);
		poolCount++;
	}

	public void M1855()
	{
		Sound.M1798(PANEL_OPEN, 0.5f);
		poolCount++;
	}

	public void M1856()
	{
		Sound.M1798(BUTTON_CLOSE, 0.5f);
		poolCount++;
	}

	public void M1857()
	{
		Sound.M1798(BUTTON_CLICK, 0.5f);
		poolCount++;
	}

	public void M1858()
	{
	}

	public void M1859()
	{
		Sound.M1798(FLY, 0.2f);
		poolCount++;
	}

	public void M1860()
	{
	}

	public void M1861()
	{
		Sound.M1798(BUTTON_CLOSE, 0.5f);
		poolCount++;
	}

	public void M1862()
	{
		Sound.M1798(PANEL_CLICK, 0.5f);
		poolCount++;
	}

	public void M1863()
	{
		Sound.M1798(EAT_PEAN, 0.5f);
		poolCount++;
	}

	public void M1864()
	{
		Sound.M1798(OPEN_DIALOG, 0.5f);
	}

	public void M1865()
	{
		Sound.M1798(HOISINH, 0.5f);
		poolCount++;
	}

	public void M1866()
	{
		Sound.M1812(TAITAONANGLUONG, 0.5f, loop: true);
	}

	public void M1867()
	{
	}

	public bool M1868()
	{
		try
		{
			return Sound.M1808();
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
			Sound.M1812(AIR_SHIP, 0.3f, loop: false);
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
		Sound.M1801();
	}

	public void M1874()
	{
		Session_ME.M1744().close();
		GameCanvas.panel.M1382();
		GameCanvas.loginScr.M867();
		GameCanvas.loginScr.switchToMe();
	}

	public void M1875()
	{
		poolCount++;
		if (poolCount % 15 == 0)
		{
			Sound.M1798(TRAIDAT_KAME, 0.5f);
		}
	}

	public void M1876()
	{
		Sound.M1798(RADAR_CLICK, 0.5f);
	}

	public void M1877()
	{
		Sound.M1798(RADAR_ITEM, 0.5f);
	}

	public static void M1878(int x, int y, int id, float volume)
	{
		Sound.M1798(id, volume);
	}
}
