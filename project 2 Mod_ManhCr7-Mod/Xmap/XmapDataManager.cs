using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Xmap;

public class XmapDataManager
{
	private const int ID_MAP_HOME_BASE = 21;

	private const int ID_MAP_TTVT_BASE = 24;

	private const int ID_ITEM_CAPSULE_VIP = 194;

	private const int ID_ITEM_CAPSULE_NORMAL = 193;

	private const int ID_MAP_TPVGT = 19;

	private const int ID_MAP_TO_COLD = 109;

	public List<XmapGroup> GroupMaps;

	public Dictionary<int, List<XmapLink>> MyLinkMaps;

	public bool IsLoading;

	private bool IsLoadingCapsule;

	private static XmapDataManager _Instance;

	private XmapDataManager()
	{
		GroupMaps = new List<XmapGroup>();
		MyLinkMaps = null;
		IsLoading = false;
		IsLoadingCapsule = false;
	}

	public static XmapDataManager M2008()
	{
		if (_Instance == null)
		{
			_Instance = new XmapDataManager();
		}
		return _Instance;
	}

	public void M2009()
	{
		IsLoading = true;
	}

	public void M2010()
	{
		if (!IsLoadingCapsule)
		{
			M2014();
			if (M2035())
			{
				XmapExecutor.M2004();
				IsLoadingCapsule = true;
			}
			else if (M2033())
			{
				XmapExecutor.M2003();
				IsLoadingCapsule = true;
			}
			else
			{
				IsLoading = false;
			}
		}
		else if (!M2024())
		{
			M2013();
			IsLoadingCapsule = false;
			IsLoading = false;
		}
	}

	public void M2011(string path)
	{
		GroupMaps.Clear();
		try
		{
			StreamReader streamReader = new StreamReader(path);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				text = text.Trim();
				if (!text.StartsWith("#") && !text.Equals(""))
				{
					string text2 = streamReader.ReadLine().Trim();
					string[] array = text2.Split(' ');
					List<int> idMaps = Array.ConvertAll(array, (string s) => int.Parse(s)).ToList();
					GroupMaps.Add(new XmapGroup(text, idMaps));
				}
			}
		}
		catch (Exception ex)
		{
			GameScr.info1.M762(ex.Message, 0);
		}
		M2012();
	}

	private void M2012()
	{
		int cgender = Char.M113().cgender;
		foreach (XmapGroup groupMap in GroupMaps)
		{
			switch (cgender)
			{
			default:
				groupMap.IdMaps.Remove(21);
				groupMap.IdMaps.Remove(22);
				break;
			case 1:
				groupMap.IdMaps.Remove(21);
				groupMap.IdMaps.Remove(23);
				break;
			case 0:
				groupMap.IdMaps.Remove(22);
				groupMap.IdMaps.Remove(23);
				break;
			}
		}
	}

	private void M2013()
	{
		M2023(TileMap.mapID);
		string[] mapNames = GameCanvas.panel.mapNames;
		for (int i = 0; i < mapNames.Length; i++)
		{
			int num = M2031(mapNames[i]);
			if (num != -1)
			{
				int[] info = new int[1] { i };
				MyLinkMaps[TileMap.mapID].Add(new XmapLink(num, XmapLinkType.Capsule, info));
			}
		}
	}

	private void M2014()
	{
		MyLinkMaps = new Dictionary<int, List<XmapLink>>();
		M2015("TextData\\LinkMapsXmap.txt");
		M2016("TextData\\AutoLinkMapsWaypoint.txt");
		M2017();
		M2018();
		M2019();
	}

	private void M2015(string path)
	{
		try
		{
			StreamReader streamReader = new StreamReader(path);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				text = text.Trim();
				if (!text.StartsWith("#") && !text.Equals(""))
				{
					string[] array = text.Split(' ');
					int[] array2 = Array.ConvertAll(array, (string s) => int.Parse(s));
					int num = array2.Length - 3;
					int[] array3 = new int[num];
					Array.Copy(array2, 3, array3, 0, num);
					M2022(array2[0], array2[1], (XmapLinkType)array2[2], array3);
				}
			}
		}
		catch (Exception ex)
		{
			GameScr.info1.M762(ex.Message, 0);
		}
	}

	private void M2016(string path)
	{
		try
		{
			StreamReader streamReader = new StreamReader(path);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				text = text.Trim();
				if (text.StartsWith("#") || text.Equals(""))
				{
					continue;
				}
				string[] array = text.Split(' ');
				int[] array2 = Array.ConvertAll(array, (string s) => int.Parse(s));
				for (int i = 0; i < array2.Length; i++)
				{
					if (i != 0)
					{
						M2022(array2[i], array2[i - 1], XmapLinkType.AutoWaypoint, null);
					}
					if (i != array2.Length - 1)
					{
						M2022(array2[i], array2[i + 1], XmapLinkType.AutoWaypoint, null);
					}
				}
			}
		}
		catch (Exception ex)
		{
			GameScr.info1.M762(ex.Message, 0);
		}
	}

	private void M2017()
	{
		int cgender = Char.M113().cgender;
		int num = 21 + cgender;
		int num2 = 7 * cgender;
		M2022(num2, num, XmapLinkType.AutoWaypoint, null);
		M2022(num, num2, XmapLinkType.AutoWaypoint, null);
	}

	private void M2018()
	{
		int cgender = Char.M113().cgender;
		int idMapNext = 24 + cgender;
		int[] info = new int[2] { 10, 0 };
		M2022(84, idMapNext, XmapLinkType.NpcMenu, info);
	}

	private void M2019()
	{
		if (Char.M113().taskMaint.taskId > 30)
		{
			int[] info = new int[2] { 12, 0 };
			M2022(19, 109, XmapLinkType.NpcMenu, info);
		}
	}

	public List<XmapLink> M2020(int idMap)
	{
		if (M2021(idMap))
		{
			return MyLinkMaps[idMap];
		}
		return null;
	}

	public bool M2021(int idMap)
	{
		return MyLinkMaps.ContainsKey(idMap);
	}

	private void M2022(int idMapStart, int idMapNext, XmapLinkType type, int[] info)
	{
		M2023(idMapStart);
        XmapLink item = new XmapLink(idMapNext, type, info);
		MyLinkMaps[idMapStart].Add(item);
	}

	private void M2023(int idMap)
	{
		if (!MyLinkMaps.ContainsKey(idMap))
		{
			MyLinkMaps.Add(idMap, new List<XmapLink>());
		}
	}

	private bool M2024()
	{
		return !XmapController.IsShowPanelMapTrans;
	}

	public static int M2025(string mapName)
	{
		return int.Parse(mapName.Split(':')[0]);
	}

	public static Waypoint M2026(int idMap)
	{
		int num = 0;
		Waypoint t;
		while (true)
		{
			if (num < TileMap.vGo.M1113())
			{
				t = (Waypoint)TileMap.vGo.M1114(num);
				string text = M2032(t.popup);
				if (text.Equals(TileMap.mapNames[idMap]))
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

	public static int M2027(Waypoint waypoint)
	{
		if (waypoint.maxX < 60)
		{
			return 15;
		}
		if (waypoint.minX > TileMap.pxw - 60)
		{
			return TileMap.pxw - 15;
		}
		return waypoint.minX + 30;
	}

	public static int M2028(Waypoint waypoint)
	{
		return waypoint.maxY;
	}

	public static bool M2029()
	{
		return Char.M113().statusMe == 14 || Char.M113().cHP <= 0;
	}

	public static bool M2030()
	{
		return !Char.isLoadingMap && !Char.ischangingMap && !Controller.isStopReadMessage;
	}

	private static int M2031(string mapName)
	{
		int cgender = Char.M113().cgender;
		if (mapName.Equals("Về nhà"))
		{
			return 21 + cgender;
		}
		if (mapName.Equals("Trạm tàu vũ trụ"))
		{
			return 24 + cgender;
		}
		if (mapName.Contains("Về chỗ cũ: "))
		{
			mapName = mapName.Replace("Về chỗ cũ: ", "");
			if (TileMap.mapNames[XmapController.IdMapCapsuleReturn].Equals(mapName))
			{
				return XmapController.IdMapCapsuleReturn;
			}
			if (mapName.Equals("Rừng đá"))
			{
				return -1;
			}
		}
		int num = 0;
		while (true)
		{
			if (num < TileMap.mapNames.Length)
			{
				if (mapName.Equals(TileMap.mapNames[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	private static string M2032(PopUp popUp)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < popUp.says.Length; i++)
		{
			stringBuilder.Append(popUp.says[i]);
			stringBuilder.Append(" ");
		}
		return stringBuilder.ToString().Trim();
	}

	private static bool M2033()
	{
		return !M2029() && XmapController.IsUseCapsuleNormal && M2034();
	}

	private static bool M2034()
	{
		Item[] arrItemBag = Char.M113().arrItemBag;
		int num = 0;
		while (true)
		{
			if (num < arrItemBag.Length)
			{
				if (arrItemBag[num] != null && arrItemBag[num].template.id == 193)
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

	private static bool M2035()
	{
		return !M2029() && XmapController.IsUseCapsuleVip && M2036();
	}

	private static bool M2036()
	{
		Item[] arrItemBag = Char.M113().arrItemBag;
		int num = 0;
		while (true)
		{
			if (num < arrItemBag.Length)
			{
				if (arrItemBag[num] != null && arrItemBag[num].template.id == 194)
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
}
