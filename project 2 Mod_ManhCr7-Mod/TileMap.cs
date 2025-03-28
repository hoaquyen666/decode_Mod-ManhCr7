using System;

public class TileMap
{
	public const int T_EMPTY = 0;

	public const int T_TOP = 2;

	public const int T_LEFT = 4;

	public const int T_RIGHT = 8;

	public const int T_TREE = 16;

	public const int T_WATERFALL = 32;

	public const int T_WATERFLOW = 64;

	public const int T_TOPFALL = 128;

	public const int T_OUTSIDE = 256;

	public const int T_DOWN1PIXEL = 512;

	public const int T_BRIDGE = 1024;

	public const int T_UNDERWATER = 2048;

	public const int T_SOLIDGROUND = 4096;

	public const int T_BOTTOM = 8192;

	public const int T_DIE = 16384;

	public const int T_HEBI = 32768;

	public const int T_BANG = 65536;

	public const int T_JUM8 = 131072;

	public const int T_NT0 = 262144;

	public const int T_NT1 = 524288;

	public const int T_CENTER = 1;

	public static int tmw;

	public static int tmh;

	public static int pxw;

	public static int pxh;

	public static int tileID;

	public static int lastTileID = -1;

	public static int[] maps;

	public static int[] types;

	public static Image[] imgTile;

	public static Image imgTileSmall;

	public static Image imgMiniMap;

	public static Image imgWaterfall;

	public static Image imgTopWaterfall;

	public static Image imgWaterflow;

	public static Image imgWaterlowN;

	public static Image imgWaterlowN2;

	public static Image imgWaterF;

	public static Image imgLeaf;

	public static sbyte size = 24;

	private static int bx;

	private static int dbx;

	private static int fx;

	private static int dfx;

	public static string[] instruction;

	public static int[] iX;

	public static int[] iY;

	public static int[] iW;

	public static int iCount;

	public static bool isMapDouble = false;

	public static string mapName = string.Empty;

	public static sbyte versionMap = 1;

	public static int mapID;

	public static int lastBgID = -1;

	public static int zoneID;

	public static int bgID;

	public static int bgType;

	public static int lastType = -1;

	public static int typeMap;

	public static sbyte planetID;

	public static sbyte lastPlanetId = -1;

	public static long timeTranMini;

	public static MyVector vGo = new MyVector();

	public static MyVector vItemBg = new MyVector();

	public static MyVector vCurrItem = new MyVector();

	public static string[] mapNames;

	public static sbyte MAP_NORMAL = 0;

	public static Image bong;

	public const int TRAIDAT_DOINUI = 0;

	public const int TRAIDAT_RUNG = 1;

	public const int TRAIDAT_DAORUA = 2;

	public const int TRAIDAT_DADO = 3;

	public const int NAMEK_THUNGLUNG = 5;

	public const int NAMEK_DOINUI = 4;

	public const int NAMEK_RUNG = 6;

	public const int NAMEK_DAO = 7;

	public const int SAYAI_DOINUI = 8;

	public const int SAYAI_RUNG = 9;

	public const int SAYAI_CITY = 10;

	public const int SAYAI_NIGHT = 11;

	public const int KAMISAMA = 12;

	public const int TIME_ROOM = 13;

	public const int HELL = 15;

	public const int BEERUS = 16;

	public static Image[] bgItem = new Image[8];

	public static MyVector vObject = new MyVector();

	public static int[] offlineId = new int[6] { 21, 22, 23, 39, 40, 41 };

	public static int[] highterId = new int[6] { 21, 22, 23, 24, 25, 26 };

	public static int[] toOfflineId = new int[3] { 0, 7, 14 };

	public static int[][] tileType;

	public static int[][][] tileIndex;

	public static Image imgLight = GameCanvas.M503("/bg/light.png");

	public static int sizeMiniMap = 2;

	public static int gssx;

	public static int gssxe;

	public static int gssy;

	public static int gssye;

	public static int countx;

	public static int county;

	private static int[] colorMini = new int[2] { 5257738, 8807192 };

	public static int yWater = 0;

	public static void M1932()
	{
		bong = GameCanvas.M503("/mainImage/myTexture2dbong.png");
		if (mGraphics.zoomLevel != 1 && !Main.isIpod && !Main.isIphone4)
		{
			imgLight = GameCanvas.M503("/bg/light.png");
		}
	}

	public static bool M1933()
	{
		if (mapID != 39 && mapID != 40 && mapID != 41)
		{
			return false;
		}
		return true;
	}

	public static bool M1934()
	{
		if (GameScr.phuban_Info != null && mapID == GameScr.phuban_Info.idmapPaint)
		{
			return true;
		}
		return false;
	}

	public static BgItem M1935(int id)
	{
		for (int i = 0; i < vItemBg.M1113(); i++)
		{
			BgItem t = (BgItem)vItemBg.M1114(i);
			if (t.id == id)
			{
				return t;
			}
		}
		return null;
	}

	public static bool M1936()
	{
		for (int i = 0; i < offlineId.Length; i++)
		{
			if (mapID == offlineId[i])
			{
				return true;
			}
		}
		return false;
	}

	public static bool M1937()
	{
		for (int i = 0; i < offlineId.Length; i++)
		{
			if (mapID == highterId[i])
			{
				return true;
			}
		}
		return false;
	}

	public static bool M1938()
	{
		for (int i = 0; i < toOfflineId.Length; i++)
		{
			if (mapID == toOfflineId[i])
			{
				return true;
			}
		}
		return false;
	}

	public static void M1939()
	{
		imgTile = null;
		mSystem.M1062();
	}

	public static void M1940()
	{
	}

	public static bool M1941(int id)
	{
		if (id != 156 && id != 330 && id != 345 && id != 334)
		{
			if (mapID != 54 && mapID != 55 && mapID != 56 && mapID != 57 && mapID != 58 && mapID != 59 && mapID != 103)
			{
				int num = 0;
				for (int i = 0; i < vCurrItem.M1113(); i++)
				{
					if (((BgItem)vCurrItem.M1114(i)).id == id)
					{
						num++;
					}
				}
				if (num > 2)
				{
					return true;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public static void M1942()
	{
		if (imgWaterfall == null)
		{
			imgWaterfall = GameCanvas.M502("/tWater/wtf.png");
		}
		if (imgTopWaterfall == null)
		{
			imgTopWaterfall = GameCanvas.M502("/tWater/twtf.png");
		}
		if (imgWaterflow == null)
		{
			imgWaterflow = GameCanvas.M502("/tWater/wts.png");
		}
		if (imgWaterlowN == null)
		{
			imgWaterlowN = GameCanvas.M502("/tWater/wtsN.png");
		}
		if (imgWaterlowN2 == null)
		{
			imgWaterlowN2 = GameCanvas.M502("/tWater/wtsN2.png");
		}
		mSystem.M1062();
	}

	public static void M1943(int index, int[] mapsArr, int type)
	{
		for (int i = 0; i < mapsArr.Length; i++)
		{
			if (maps[index] == mapsArr[i])
			{
				types[index] |= type;
				break;
			}
		}
	}

	public static void M1944(int tileId)
	{
		pxh = tmh * size;
		pxw = tmw * size;
		Res.M1513("load tile ID= " + tileID);
		int num = tileId - 1;
		try
		{
			for (int i = 0; i < tmw * tmh; i++)
			{
				for (int j = 0; j < tileType[num].Length; j++)
				{
					M1943(i, tileIndex[num][j], tileType[num][j]);
				}
			}
		}
		catch (Exception)
		{
			Cout.M326("Error Load Map");
			GameMidlet.instance.M520();
		}
	}

	public static bool M1945()
	{
		if (mapID != 45 && mapID != 46 && mapID != 48)
		{
			return false;
		}
		return true;
	}

	public static bool M1946()
	{
		if (!isMapDouble && mapID != 45 && mapID != 46 && mapID != 48 && mapID != 51 && mapID != 52 && mapID != 103 && mapID != 112 && mapID != 113 && mapID != 115 && mapID != 117 && mapID != 118 && mapID != 119 && mapID != 120 && mapID != 121 && mapID != 125 && mapID != 129 && mapID != 130)
		{
			return false;
		}
		return true;
	}

	public static void M1947()
	{
		if (Main.typeClient != 3 && Main.typeClient != 5)
		{
			if (mGraphics.zoomLevel == 1)
			{
				if (imgTile != null)
				{
					for (int i = 0; i < imgTile.Length; i++)
					{
						if (imgTile[i] != null)
						{
							imgTile[i].texture = null;
							imgTile[i] = null;
						}
					}
					mSystem.M1062();
				}
				imgTile = new Image[100];
				string empty = string.Empty;
				for (int j = 0; j < imgTile.Length; j++)
				{
					empty = ((j >= 9) ? ("/t/" + tileID + "/t_" + (j + 1)) : ("/t/" + tileID + "/t_0" + (j + 1)));
					imgTile[j] = GameCanvas.M503(empty);
				}
			}
			else if (GameCanvas.M502("/t/" + tileID + "$1.png") != null)
			{
				Rms.M1548("x" + mGraphics.zoomLevel + "t" + tileID);
				imgTile = new Image[100];
				for (int k = 0; k < imgTile.Length; k++)
				{
					imgTile[k] = GameCanvas.M502("/t/" + tileID + "$" + (k + 1) + ".png");
				}
			}
			else
			{
				Image t = GameCanvas.M502("/t/" + tileID + ".png");
				if (t != null)
				{
					Rms.M1548("$");
					imgTile = new Image[1];
					imgTile[0] = t;
				}
			}
		}
		else if (mGraphics.zoomLevel == 1)
		{
			imgTile = new Image[1];
			imgTile[0] = GameCanvas.M503("/t/" + tileID + ".png");
		}
		else
		{
			imgTile = new Image[100];
			for (int l = 0; l < imgTile.Length; l++)
			{
				imgTile[l] = GameCanvas.M503("/t/" + tileID + "/" + (l + 1) + ".png");
			}
		}
	}

	public static void M1948(mGraphics g, int frame, int indexX, int indexY)
	{
		if (imgTile != null)
		{
			if (imgTile.Length == 1)
			{
				g.M940(imgTile[0], 0, frame * size, size, size, 0, indexX * size, indexY * size, 0);
			}
			else
			{
				g.M948(imgTile[frame], indexX * size, indexY * size, 0);
			}
		}
	}

	public static void M1949(mGraphics g, int frame, int x, int y, int w, int h)
	{
		if (imgTile != null)
		{
			if (imgTile.Length == 1)
			{
				g.M940(imgTile[0], 0, frame * w, w, w, 0, x, y, 0);
			}
			else
			{
				g.M948(imgTile[frame], x, y, 0);
			}
		}
	}

	public static void M1950(mGraphics g)
	{
		for (int i = GameScr.gssx; i < GameScr.gssxe; i++)
		{
			for (int j = GameScr.gssy; j < GameScr.gssye; j++)
			{
				int num = maps[j * tmw + i] - 1;
				if (num != -1)
				{
					M1948(g, num, i, j);
				}
				if ((M1956(i, j) & 0x20) == 32)
				{
					g.M940(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
				}
				else if ((M1956(i, j) & 0x40) == 64)
				{
					if ((M1956(i, j - 1) & 0x20) == 32)
					{
						g.M940(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
					}
					else if ((M1956(i, j - 1) & 0x1000) == 4096)
					{
						M1948(g, 21, i, j);
					}
					g.M940((tileID == 5) ? imgWaterlowN : ((tileID != 8) ? imgWaterflow : imgWaterlowN2), 0, (GameCanvas.gameTick % 8 >> 2) * 24, 24, 24, 0, i * size, j * size, 0);
				}
				if ((M1956(i, j) & 0x800) == 2048)
				{
					if ((M1956(i, j - 1) & 0x20) == 32)
					{
						g.M940(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 4), 24, 24, 0, i * size, j * size, 0);
					}
					else if ((M1956(i, j - 1) & 0x1000) == 4096)
					{
						M1948(g, 21, i, j);
					}
					M1948(g, maps[j * tmw + i] - 1, i, j);
				}
			}
		}
	}

	public static void M1951(mGraphics g)
	{
		if (Char.isLoadingMap)
		{
			return;
		}
		GameScr.M559().M618(g, 1);
		for (int i = 0; i < GameScr.vItemMap.M1113(); i++)
		{
			((ItemMap)GameScr.vItemMap.M1114(i)).M828(g);
		}
		int num = GameScr.gssx;
		while (true)
		{
			if (num < GameScr.gssxe)
			{
				for (int j = GameScr.gssy; j < GameScr.gssye; j++)
				{
					if (num == 0 || num == tmw - 1)
					{
						continue;
					}
					int num2 = maps[j * tmw + num] - 1;
					if ((M1956(num, j) & 0x100) == 256)
					{
						continue;
					}
					if ((M1956(num, j) & 0x20) == 32)
					{
						g.M940(imgWaterfall, 0, 24 * (GameCanvas.gameTick % 8 >> 1), 24, 24, 0, num * size, j * size, 0);
						continue;
					}
					if ((M1956(num, j) & 0x80) == 128)
					{
						g.M940(imgTopWaterfall, 0, 24 * (GameCanvas.gameTick % 8 >> 1), 24, 24, 0, num * size, j * size, 0);
						continue;
					}
					if (tileID == 13)
					{
						if (GameCanvas.lowGraphic)
						{
							if (num2 != -1)
							{
								M1948(g, 0, num, j);
							}
							continue;
						}
						return;
					}
					if (tileID == 2 && (M1956(num, j) & 0x200) == 512 && num2 != -1)
					{
						M1949(g, num2, num * size, j * size, 24, 1);
						M1949(g, num2, num * size, j * size + 1, 24, 24);
					}
					if ((M1956(num, j) & 0x10) == 16)
					{
						bx = num * size - GameScr.cmx;
						dbx = bx - GameScr.gW2;
						dfx = (size - 2) * dbx / size;
						fx = dfx + GameScr.gW2;
						M1949(g, num2, fx + GameScr.cmx, j * size, 24, 24);
					}
					else if ((M1956(num, j) & 0x200) == 512)
					{
						if (num2 != -1)
						{
							M1949(g, num2, num * size, j * size, 24, 1);
							M1949(g, num2, num * size, j * size + 1, 24, 24);
						}
					}
					else if (num2 != -1)
					{
						M1948(g, num2, num, j);
					}
				}
				num++;
				continue;
			}
			if (GameScr.cmx < 24)
			{
				for (int k = GameScr.gssy; k < GameScr.gssye; k++)
				{
					int num3 = maps[k * tmw + 1] - 1;
					if (num3 != -1)
					{
						M1948(g, num3, 0, k);
					}
				}
			}
			if (GameScr.cmx <= GameScr.cmxLim)
			{
				break;
			}
			int num4 = tmw - 2;
			for (int l = GameScr.gssy; l < GameScr.gssye; l++)
			{
				int num5 = maps[l * tmw + num4] - 1;
				if (num5 != -1)
				{
					M1948(g, num5, num4 + 1, l);
				}
			}
			break;
		}
	}

	public static bool M1952()
	{
		if (mapID != 54 && mapID != 55 && mapID != 56 && mapID != 57 && mapID != 138)
		{
			return true;
		}
		return false;
	}

	public static void M1953(mGraphics g)
	{
		if (GameCanvas.lowGraphic)
		{
			return;
		}
		int num = 0;
		for (int i = GameScr.gssx; i < GameScr.gssxe; i++)
		{
			for (int j = GameScr.gssy; j < GameScr.gssye; j++)
			{
				num++;
				if ((M1956(i, j) & 0x40) != 64)
				{
					continue;
				}
				Image t = null;
				t = ((tileID == 5) ? imgWaterlowN : ((tileID != 8) ? imgWaterflow : imgWaterlowN2));
				if (!M1952())
				{
					g.M940(t, 0, 0, 24, 24, 0, i * size, j * size - 1, 0);
					g.M940(t, 0, 0, 24, 24, 0, i * size, j * size - 3, 0);
				}
				g.M940(t, 0, (GameCanvas.gameTick % 8 >> 2) * 24, 24, 24, 0, i * size, j * size - 12, 0);
				if (yWater == 0 && M1952())
				{
					yWater = j * size - 12;
					int color = 16777215;
					if (GameCanvas.typeBg == 2)
					{
						color = 10871287;
					}
					else if (GameCanvas.typeBg == 4)
					{
						color = 8111470;
					}
					else if (GameCanvas.typeBg == 7)
					{
						color = 5693125;
					}
					BackgroundEffect.M56(color, yWater + 15);
				}
			}
		}
		BackgroundEffect.M57(g);
	}

	public static void M1954(int mapID)
	{
		DataInputStream t = null;
		t = MyStream.M1110("/mymap/" + mapID);
		tmw = (ushort)t.M355();
		tmh = (ushort)t.M355();
		maps = new int[t.M366()];
		for (int i = 0; i < tmw * tmh; i++)
		{
			maps[i] = (ushort)t.M355();
		}
		types = new int[maps.Length];
	}

	public static int M1955(int x, int y)
	{
		try
		{
			return maps[y * tmw + x];
		}
		catch (Exception)
		{
			return 1000;
		}
	}

	public static int M1956(int x, int y)
	{
		try
		{
			return types[y * tmw + x];
		}
		catch (Exception)
		{
			return 1000;
		}
	}

	public static int M1957(int px, int py)
	{
		try
		{
			return types[py / size * tmw + px / size];
		}
		catch (Exception)
		{
			return 1000;
		}
	}

	public static bool M1958(int px, int py, int t)
	{
		try
		{
			return (types[py / size * tmw + px / size] & t) == t;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void M1959(int px, int py, int t)
	{
		types[py / size * tmw + px / size] |= t;
	}

	public static void M1960(int x, int y, int t)
	{
		types[y * tmw + x] = t;
	}

	public static void M1961(int px, int py, int t)
	{
		types[py / size * tmw + px / size] &= ~t;
	}

	public static int M1962(int py)
	{
		return py / size * size;
	}

	public static int M1963(int px)
	{
		return px / size * size;
	}

	public static void M1964()
	{
		if (lastTileID != tileID)
		{
			M1947();
			lastTileID = tileID;
		}
	}
}
