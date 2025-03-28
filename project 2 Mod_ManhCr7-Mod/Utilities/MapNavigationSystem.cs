using System.Collections.Generic;
using System.Text;

namespace Utilities;

public class MapNavigationSystem : IActionListener
{
	public class T224
	{
		public int MapID;

		public int Npc;

		public int Index;

		public T224(int mapID, int npcID, int index)
		{
			MapID = mapID;
			Npc = npcID;
			Index = index;
		}

		public void M2329()
		{
			if (Index == -1 && Npc == -1)
			{
				Waypoint t = M2330();
				if (t != null)
				{
					M2332(t);
				}
			}
			else if (Npc != -1 && Index != -1)
			{
				Service.M1594().M1656(Npc);
				Service.M1594().M1655(0, (sbyte)Index);
			}
		}

		public Waypoint M2330()
		{
			int num = 0;
			Waypoint t;
			while (true)
			{
				if (num < TileMap.vGo.M1113())
				{
					t = (Waypoint)TileMap.vGo.M1114(num);
					if (M2331().Equals(M2333(t.popup)))
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return t;
		}

		public string M2331()
		{
			return TileMap.mapNames[MapID];
		}

		public void M2332(Waypoint waypoint)
		{
			int num = ((waypoint.maxX < 60) ? 15 : ((waypoint.minX <= TileMap.pxw - 60) ? ((waypoint.minX + waypoint.maxX) / 2) : (TileMap.pxw - 15)));
			int maxY = waypoint.maxY;
			if (num == -1 || maxY == -1)
			{
				GameScr.info1.M762("Có lỗi xảy ra", 0);
				return;
			}
			M2334(num, maxY);
			if (waypoint.isOffline)
			{
				Service.M1594().M1710();
			}
			else
			{
				Service.M1594().M1636();
			}
		}

		public string M2333(PopUp popup)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < popup.says.Length; i++)
			{
				stringBuilder.Append(popup.says[i]);
				stringBuilder.Append(" ");
			}
			return stringBuilder.ToString().Trim();
		}

		public void M2334(int x, int y)
		{
			if (GameScr.canAutoPlay)
			{
				Char.M113().cx = x;
				Char.M113().cy = y;
				Service.M1594().M1640();
				return;
			}
			Char.M113().cx = x;
			Char.M113().cy = y;
			Service.M1594().M1640();
			Char.M113().cx = x;
			Char.M113().cy = y + 1;
			Service.M1594().M1640();
			Char.M113().cx = x;
			Char.M113().cy = y;
			Service.M1594().M1640();
		}
	}

	public static MapNavigationSystem _Instance;

	private static Dictionary<int, List<T224>> linkMaps;

	private static Dictionary<string, int[]> planetDictionary;

	public static bool isXmaping;

	public static int IdMapEnd;

	private static int[] wayPointMapLeft;

	private static int[] wayPointMapCenter;

	private static int[] wayPointMapRight;

	private static bool isEatChicken;

	private static bool isHarvestPean;

	private static bool isUseCapsule;

	private static bool isUsingCapsule;

	private static bool isOpeningPanel;

	private static long lastTimeOpenedPanel;

	private static bool isSaveData;

	private static long lastWaitTime;

	private static int[] idMapsNamek;

	private static int[] idMapsXayda;

	private static int[] idMapsTraiDat;

	private static int[] idMapsTuongLai;

	private static int[] idMapsCold;

	private static int[] idMapsNappa;

	static MapNavigationSystem()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		linkMaps = new Dictionary<int, List<T224>>();
		planetDictionary = new Dictionary<string, int[]>();
		isEatChicken = true;
		isUseCapsule = true;
		idMapsNamek = new int[15]
		{
			43, 22, 7, 8, 9, 11, 12, 13, 10, 31,
			32, 33, 34, 43, 25
		};
		idMapsXayda = new int[20]
		{
			44, 23, 14, 15, 16, 17, 18, 20, 19, 35,
			36, 37, 38, 52, 44, 26, 84, 113, 127, 129
		};
		idMapsTraiDat = new int[29]
		{
			42, 21, 0, 1, 2, 3, 4, 5, 6, 27,
			28, 29, 30, 47, 42, 24, 46, 45, 48, 53,
			58, 59, 60, 61, 62, 55, 56, 54, 57
		};
		idMapsTuongLai = new int[10] { 102, 92, 93, 94, 96, 97, 98, 99, 100, 103 };
		idMapsCold = new int[6] { 109, 108, 107, 110, 106, 105 };
		idMapsNappa = new int[23]
		{
			68, 69, 70, 71, 72, 64, 65, 63, 66, 67,
			73, 74, 75, 76, 77, 81, 82, 83, 79, 80,
			131, 132, 133
		};
		M2072();
		M2073();
		M2074();
		M2070();
	}

	public static MapNavigationSystem M2059()
	{
		if (_Instance == null)
		{
			_Instance = new MapNavigationSystem();
		}
		return _Instance;
	}

	public static void M2060()
	{
		if (Char.M113().meDead)
		{
			lastWaitTime = mSystem.M1054() + 1000L;
		}
		if (TileMap.mapID == IdMapEnd)
		{
			M2065();
			return;
		}
		bool flag = false;
		if (TileMap.mapID == 21 || TileMap.mapID == 22 || TileMap.mapID == 23)
		{
			if (isEatChicken)
			{
				for (int i = 0; i < GameScr.vItemMap.M1113(); i++)
				{
					ItemMap t = (ItemMap)GameScr.vItemMap.M1114(i);
					if ((t.playerId == Char.M113().charID || t.playerId == -1) && t.template.id == 74)
					{
						flag = true;
						Char.M113().itemFocus = t;
						if (mSystem.M1054() - lastWaitTime > 600L)
						{
							lastWaitTime = mSystem.M1054();
							Service.M1594().M1670(Char.M113().itemFocus.itemMapID);
							return;
						}
					}
				}
			}
			if (isXmaping && isHarvestPean && GameScr.hpPotion < 10 && GameScr.M559().magicTree.currPeas > 0 && mSystem.M1054() - lastWaitTime > 500L)
			{
				lastWaitTime = mSystem.M1054();
				Service.M1594().M1656(4);
				Service.M1594().M1657(4, 0, 0);
			}
		}
		if (!isXmaping || flag || mSystem.M1054() - lastWaitTime <= 1000L || GameCanvas.gameTick % 20 != 0)
		{
			return;
		}
		bool flag2 = true;
		if (M2088(IdMapEnd))
		{
			if (flag2 && TileMap.mapID == 27 && GameScr.M625(38) == null)
			{
				flag2 = false;
				M2066(28);
			}
			if (flag2 && TileMap.mapID == 29 && GameScr.M625(38) == null)
			{
				flag2 = false;
				M2066(28);
			}
			if (flag2 && TileMap.mapID == 28 && GameScr.M625(38) == null)
			{
				flag2 = false;
				if (Char.M113().cx < TileMap.pxw / 2)
				{
					M2066(29);
				}
				else
				{
					M2066(27);
				}
			}
		}
		if (flag2)
		{
			M2066(IdMapEnd);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 1:
			M2062();
			break;
		case 2:
			isEatChicken = !isEatChicken;
			GameScr.info1.M762("Ăn Đùi Gà\n" + (isEatChicken ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isSaveData)
			{
				Rms.M1543("AutoMapIsEatChicken", isEatChicken ? 1 : 0);
			}
			break;
		case 3:
			isHarvestPean = !isHarvestPean;
			GameScr.info1.M762("Thu Đậu\n" + (isHarvestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isSaveData)
			{
				Rms.M1543("AutoMapIsHarvestPean", isHarvestPean ? 1 : 0);
			}
			break;
		case 4:
			isUseCapsule = !isUseCapsule;
			GameScr.info1.M762("Sử Dụng Capsule\n" + (isUseCapsule ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isSaveData)
			{
				Rms.M1543("AutoMapIsUseCsb", isUseCapsule ? 1 : 0);
			}
			break;
		case 5:
			isSaveData = !isSaveData;
			GameScr.info1.M762("Lưu Cài Đặt Auto Map\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			Rms.M1543("AutoMapIsSaveRms", isSaveData ? 1 : 0);
			if (isSaveData)
			{
				M2071();
			}
			break;
		case 6:
			M2063((int[])p);
			break;
		case 7:
			isXmaping = true;
			IdMapEnd = (int)p;
			GameScr.info1.M762("Go to " + TileMap.mapNames[IdMapEnd], 0);
			break;
		}
	}

	public static void M2061()
	{
		M2070();
		MyVector t = new MyVector();
		t.M1111(new Command("Load Map", M2059(), 1, null));
		t.M1111(new Command("Ăn Đùi Gà\n" + (isEatChicken ? "[STATUS: ON]" : "[STATUS: OFF]"), M2059(), 2, null));
		t.M1111(new Command("Thu Đậu\n" + (isHarvestPean ? "[STATUS: ON]" : "[STATUS: OFF]"), M2059(), 3, null));
		t.M1111(new Command("Sử Dụng Capsule\n" + (isUseCapsule ? "[STATUS: ON]" : "[STATUS: OFF]"), M2059(), 4, null));
		t.M1111(new Command("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), M2059(), 5, null));
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2062()
	{
		MyVector t = new MyVector();
		foreach (KeyValuePair<string, int[]> item in planetDictionary)
		{
			t.M1111(new Command(item.Key, M2059(), 6, item.Value));
		}
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2063(int[] mapIDs)
	{
		MyVector t = new MyVector();
		for (int i = 0; i < mapIDs.Length; i++)
		{
			if ((Char.M113().cgender != 0 || (mapIDs[i] != 22 && mapIDs[i] != 23)) && (Char.M113().cgender != 1 || (mapIDs[i] != 21 && mapIDs[i] != 23)) && (Char.M113().cgender != 2 || (mapIDs[i] != 21 && mapIDs[i] != 22)))
			{
				t.M1111(new Command(M2082(mapIDs[i]), M2059(), 7, mapIDs[i]));
			}
		}
		GameCanvas.menu.M877(t, 3);
	}

	public static void M2064(int mapID)
	{
		isXmaping = true;
		IdMapEnd = mapID;
	}

	public static void M2065()
	{
		isXmaping = false;
		isUsingCapsule = false;
		isOpeningPanel = false;
	}

	public static void M2066(int mapID)
	{
		if (linkMaps.ContainsKey(84))
		{
			linkMaps.Remove(84);
		}
		linkMaps.Add(84, new List<T224>());
		linkMaps[84].Add(new T224(24 + Char.M113().cgender, 10, 0));
		int[] array = M2078(mapID);
		if (array == null)
		{
			GameScr.info1.M762("Đếu tìm thấy đường đi", 0);
			return;
		}
		if (isUseCapsule)
		{
			if (!isUsingCapsule && array.Length > 3)
			{
				for (int i = 0; i < Char.M113().arrItemBag.Length; i++)
				{
					Item t = Char.M113().arrItemBag[i];
					if (t != null && (t.template.id == 194 || (t.template.id == 193 && t.quantity > 10)))
					{
						isUsingCapsule = true;
						isOpeningPanel = false;
						lastTimeOpenedPanel = mSystem.M1054();
						GameCanvas.panel.mapNames = null;
						Service.M1594().M1615(0, 1, -1, t.template.id);
						return;
					}
				}
			}
			if (isUsingCapsule && !isOpeningPanel && (GameCanvas.panel.mapNames == null || mSystem.M1054() - lastTimeOpenedPanel < 500L))
			{
				return;
			}
			if (isUsingCapsule && !isOpeningPanel)
			{
				for (int num = array.Length - 1; num >= 2; num--)
				{
					for (int j = 0; j < GameCanvas.panel.mapNames.Length; j++)
					{
						if (GameCanvas.panel.mapNames[j].Contains(TileMap.mapNames[array[num]]))
						{
							isOpeningPanel = true;
							Service.M1594().M1721(j);
							return;
						}
					}
				}
				isOpeningPanel = true;
			}
		}
		if (TileMap.mapID == array[0] && !Char.ischangingMap && !Controller.isStopReadMessage)
		{
			M2077(array[1]);
		}
	}

	public static void M2067()
	{
		M2090(0);
	}

	public static void M2068()
	{
		M2090(2);
	}

	public static void M2069()
	{
		M2090(1);
	}

	private static void M2070()
	{
		isSaveData = Rms.M1542("AutoMapIsSaveRms") == 1;
		if (isSaveData)
		{
			if (Rms.M1542("AutoMapIsEatChicken") == -1)
			{
				isEatChicken = true;
			}
			else
			{
				isEatChicken = Rms.M1542("AutoMapIsEatChicken") == 1;
			}
			if (Rms.M1542("AutoMapIsUseCsb") == -1)
			{
				isUseCapsule = true;
			}
			else
			{
				isUseCapsule = Rms.M1542("AutoMapIsUseCsb") == 1;
			}
			isHarvestPean = Rms.M1542("AutoMapIsHarvestPean") == 1;
		}
	}

	private static void M2071()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Rms.M1543("AutoMapIsEatChicken", isEatChicken ? 1 : 0);
		Rms.M1543("AutoMapIsHarvestPean", isHarvestPean ? 1 : 0);
		Rms.M1543("AutoMapIsUseCsb", isUseCapsule ? 1 : 0);
	}

	private static void M2072()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M2075(0, 21);
		M2075(1, 47);
		M2075(47, 111);
		M2075(2, 24);
		M2075(5, 29);
		M2075(7, 22);
		M2075(9, 25);
		M2075(13, 33);
		M2075(14, 23);
		M2075(16, 26);
		M2075(20, 37);
		M2075(39, 21);
		M2075(40, 22);
		M2075(41, 23);
		M2075(109, 105);
		M2075(109, 106);
		M2075(106, 107);
		M2075(108, 105);
		M2075(80, 105);
		M2075(3, 27, 28, 29, 30);
		M2075(11, 31, 32, 33, 34);
		M2075(17, 35, 36, 37, 38);
		M2075(109, 108, 107, 110, 106);
		M2075(47, 46, 45, 48, 50, 154, 155, 166);
		M2075(131, 132, 133);
		M2075(42, 0, 1, 2, 3, 4, 5, 6);
		M2075(43, 7, 8, 9, 11, 12, 13, 10);
		M2075(52, 44, 14, 15, 16, 17, 18, 20, 19);
		M2075(53, 58, 59, 60, 61, 62, 55, 56, 54, 57);
		M2075(68, 69, 70, 71, 72, 64, 65, 63, 66, 67, 73, 74, 75, 76, 77, 81, 82, 83, 79, 80);
		M2075(102, 92, 93, 94, 96, 97, 98, 99, 100, 103);
	}

	private static void M2073()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M2076(19, 68, 12, 1);
		M2076(19, 109, 12, 0);
		M2076(24, 25, 10, 0);
		M2076(24, 26, 10, 1);
		M2076(24, 84, 10, 2);
		M2076(25, 24, 11, 0);
		M2076(25, 26, 11, 1);
		M2076(25, 84, 11, 2);
		M2076(26, 24, 12, 0);
		M2076(26, 25, 12, 1);
		M2076(26, 84, 12, 2);
		M2076(27, 102, 38, 1);
		M2076(27, 53, 25, 0);
		M2076(28, 102, 38, 1);
		M2076(29, 102, 38, 1);
		M2076(45, 46, 19, 3);
		M2076(52, 127, 44, 0);
		M2076(52, 129, 23, 2);
		M2076(52, 113, 23, 1);
		M2076(68, 19, 12, 0);
		M2076(80, 131, 60, 0);
		M2076(102, 27, 38, 1);
		M2076(113, 52, 22, 4);
		M2076(127, 52, 44, 2);
		M2076(129, 52, 23, 3);
		M2076(131, 80, 60, 1);
	}

	private static void M2074()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		planetDictionary.Add("Trái đất", idMapsTraiDat);
		planetDictionary.Add("Namếc", idMapsNamek);
		planetDictionary.Add("Xayda", idMapsXayda);
		planetDictionary.Add("Fide", idMapsNappa);
		planetDictionary.Add("Tương lai", idMapsTuongLai);
		planetDictionary.Add("Cold", idMapsCold);
	}

	private static void M2075(params int[] link)
	{
		for (int i = 0; i < link.Length; i++)
		{
			if (!linkMaps.ContainsKey(link[i]))
			{
				linkMaps.Add(link[i], new List<T224>());
			}
			if (i != 0)
			{
				linkMaps[link[i]].Add(new T224(link[i - 1], -1, -1));
			}
			if (i != link.Length - 1)
			{
				linkMaps[link[i]].Add(new T224(link[i + 1], -1, -1));
			}
		}
	}

	private static void M2076(int currentMapID, int nextMapID, int npcID, int select)
	{
		if (!linkMaps.ContainsKey(currentMapID))
		{
			linkMaps.Add(currentMapID, new List<T224>());
		}
		linkMaps[currentMapID].Add(new T224(nextMapID, npcID, select));
	}

	private static void M2077(int mapID)
	{
		foreach (T224 item in linkMaps[TileMap.mapID])
		{
			if (item.MapID == mapID)
			{
				item.M2329();
				return;
			}
		}
		GameScr.info1.M762("Đếu thể thực hiện", 0);
	}

	private static int[] M2078(int mapID)
	{
		return M2079(mapID, new int[1] { TileMap.mapID });
	}

	private static int[] M2079(int mapIDEnd, int[] mapIDs)
	{
		List<int[]> list = new List<int[]>();
		List<int> list2 = new List<int>();
		list2.AddRange(mapIDs);
		foreach (T224 item in linkMaps[mapIDs[mapIDs.Length - 1]])
		{
			if (mapIDEnd != item.MapID)
			{
				if (!list2.Contains(item.MapID))
				{
					int[] array = M2079(mapIDEnd, new List<int>(list2) { item.MapID }.ToArray());
					if (array != null)
					{
						list.Add(array);
					}
				}
				continue;
			}
			list2.Add(mapIDEnd);
			return list2.ToArray();
		}
		int num = 9999;
		int[] result = null;
		foreach (int[] item2 in list)
		{
			if (!M2080(item2) && (Char.M113().taskMaint.taskId > 30 || !M2081(item2)) && item2.Length < num)
			{
				num = item2.Length;
				result = item2;
			}
		}
		return result;
	}

	private static bool M2080(int[] ways)
	{
		int num = 1;
		while (true)
		{
			if (num < ways.Length - 1)
			{
				if (ways[num] == 102 && ways[num + 1] == 24 && (ways[num - 1] == 27 || ways[num - 1] == 28 || ways[num - 1] == 29))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool M2081(int[] ways)
	{
		int num = 0;
		while (true)
		{
			if (num < ways.Length)
			{
				if (ways[num] >= 105 && ways[num] <= 110)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static string M2082(int mapID)
	{
		return mapID switch
		{
			129 => TileMap.mapNames[mapID] + " 23\n[" + mapID + "]", 
			113 => string.Concat(new object[3] { "Siêu hạng\n[", mapID, "]" }), 
			_ => TileMap.mapNames[mapID] + "\n[" + mapID + "]", 
		};
	}

	private static void M2083()
	{
		M2086();
		int num = TileMap.vGo.M1113();
		if (num != 2)
		{
			for (int i = 0; i < num; i++)
			{
				Waypoint t = (Waypoint)TileMap.vGo.M1114(i);
				if (t.maxX < 60)
				{
					wayPointMapLeft[0] = t.minX + 15;
					wayPointMapLeft[1] = t.maxY;
				}
				else if (t.maxX > TileMap.pxw - 60)
				{
					wayPointMapRight[0] = t.maxX - 15;
					wayPointMapRight[1] = t.maxY;
				}
				else
				{
					wayPointMapCenter[0] = t.minX + 15;
					wayPointMapCenter[1] = t.maxY;
				}
			}
			return;
		}
		Waypoint t2 = (Waypoint)TileMap.vGo.M1114(0);
		Waypoint t3 = (Waypoint)TileMap.vGo.M1114(1);
		if ((t2.maxX < 60 && t3.maxX < 60) || (t2.minX > TileMap.pxw - 60 && t3.minX > TileMap.pxw - 60))
		{
			wayPointMapLeft[0] = t2.minX + 15;
			wayPointMapLeft[1] = t2.maxY;
			wayPointMapRight[0] = t3.maxX - 15;
			wayPointMapRight[1] = t3.maxY;
		}
		else if (t2.maxX < t3.maxX)
		{
			wayPointMapLeft[0] = t2.minX + 15;
			wayPointMapLeft[1] = t2.maxY;
			wayPointMapRight[0] = t3.maxX - 15;
			wayPointMapRight[1] = t3.maxY;
		}
		else
		{
			wayPointMapLeft[0] = t3.minX + 15;
			wayPointMapLeft[1] = t3.maxY;
			wayPointMapRight[0] = t2.maxX - 15;
			wayPointMapRight[1] = t2.maxY;
		}
	}

	private static int M2084(int x)
	{
		int num = 50;
		int num2 = 0;
		while (num2 < 30)
		{
			num2++;
			num += 24;
			if (TileMap.M1958(x, num, 2))
			{
				if (num % 24 != 0)
				{
					num -= num % 24;
				}
				break;
			}
		}
		return num;
	}

	private static void M2085(int x, int y)
	{
		if (GameScr.canAutoPlay)
		{
			Char.M113().cx = x;
			Char.M113().cy = y;
			Service.M1594().M1640();
			return;
		}
		Char.M113().cx = x;
		Char.M113().cy = y;
		Service.M1594().M1640();
		Char.M113().cx = x;
		Char.M113().cy = y + 1;
		Service.M1594().M1640();
		Char.M113().cx = x;
		Char.M113().cy = y;
		Service.M1594().M1640();
	}

	private static void M2086()
	{
		wayPointMapLeft = new int[2];
		wayPointMapCenter = new int[2];
		wayPointMapRight = new int[2];
	}

	private static bool M2087(int mapID)
	{
		if (mapID >= 85)
		{
			return mapID <= 91;
		}
		return false;
	}

	private static bool M2088(int mapID)
	{
		int num = 0;
		while (true)
		{
			if (num < idMapsTuongLai.Length)
			{
				if (idMapsTuongLai[num] == mapID)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool M2089(ItemMap mapID)
	{
		if (mapID.template.id >= 372)
		{
			return mapID.template.id <= 378;
		}
		return false;
	}

	private static void M2090(int position)
	{
		if (M2087(TileMap.mapID))
		{
			M2091(position);
			return;
		}
		M2083();
		switch (position)
		{
		case 0:
			if (wayPointMapLeft[0] != 0 && wayPointMapLeft[1] != 0)
			{
				M2085(wayPointMapLeft[0], wayPointMapLeft[1]);
			}
			else
			{
				M2085(60, M2084(60));
			}
			break;
		case 1:
			if (wayPointMapRight[0] != 0 && wayPointMapRight[1] != 0)
			{
				M2085(wayPointMapRight[0], wayPointMapRight[1]);
			}
			else
			{
				M2085(TileMap.pxw - 60, M2084(TileMap.pxw - 60));
			}
			break;
		case 2:
			if (wayPointMapCenter[0] != 0 && wayPointMapCenter[1] != 0)
			{
				M2085(wayPointMapCenter[0], wayPointMapCenter[1]);
			}
			else
			{
				M2085(TileMap.pxw / 2, M2084(TileMap.pxw / 2));
			}
			break;
		}
		if (TileMap.mapID != 7 && TileMap.mapID != 14 && TileMap.mapID != 0)
		{
			Service.M1594().M1636();
		}
		else
		{
			Service.M1594().M1710();
		}
	}

	private static void M2091(int position)
	{
		switch (position)
		{
		default:
			M2085(TileMap.pxw - 60, M2084(TileMap.pxw - 60));
			break;
		case 2:
		{
			int num = 0;
			Npc t;
			while (true)
			{
				if (num < GameScr.vNpc.M1113())
				{
					t = (Npc)GameScr.vNpc.M1114(num);
					if (t.template.npcTemplateId >= 30 && t.template.npcTemplateId <= 36)
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			Char.M113().npcFocus = t;
			M2085(t.cx, t.cy - 3);
			break;
		}
		case 0:
			M2085(60, M2084(60));
			break;
		}
	}
}
