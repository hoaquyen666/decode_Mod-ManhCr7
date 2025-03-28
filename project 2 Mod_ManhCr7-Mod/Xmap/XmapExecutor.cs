using System.Collections.Generic;

namespace Xmap;

public class XmapExecutor : IActionListener
{
	private const int TIME_DELAY_NEXTMAP = 1000;

	private const int TIME_DELAY_RENEXTMAP = 500;

	private const int ID_ITEM_CAPSULE_VIP = 194;

	private const int ID_ITEM_CAPSULE = 193;

	private const int ID_ICON_ITEM_TDLT = 4387;

	private static readonly XmapExecutor _Instance = new XmapExecutor();

	private static int IdMapEnd;

	private static List<int> WayXmap;

	private static int IndexWay;

	private static bool IsNextMapFailed;

	private static bool IsWait;

	private static long TimeStartWait;

	private static long TimeWait;

	private static bool IsWaitNextMap;

	public static void M1988()
	{
		if (M1990() || XmapDataManager.M2008().IsLoading)
		{
			return;
		}
		if (IsWaitNextMap)
		{
			M1989(1000);
			IsWaitNextMap = false;
			return;
		}
		if (IsNextMapFailed)
		{
			XmapDataManager.M2008().MyLinkMaps = null;
			WayXmap = null;
			IsNextMapFailed = false;
			return;
		}
		if (WayXmap == null)
		{
			if (XmapDataManager.M2008().MyLinkMaps == null)
			{
				XmapDataManager.M2008().M2009();
				return;
			}
			WayXmap = XmapNavigator.M1980(TileMap.mapID, IdMapEnd);
			IndexWay = 0;
			if (WayXmap == null)
			{
				GameScr.info1.M762("Đếu tìm thấy đường đi", 0);
				M1994();
				return;
			}
		}
		if (TileMap.mapID == WayXmap[WayXmap.Count - 1] && !XmapDataManager.M2029())
		{
			GameScr.info1.M762("Mạnh Cris: Load chậm thôi cmm !", 0);
			M1994();
		}
		else if (TileMap.mapID == WayXmap[IndexWay])
		{
			if (XmapDataManager.M2029())
			{
				Service.M1594().M1672();
				IsNextMapFailed = true;
				IsWaitNextMap = true;
			}
			else if (XmapDataManager.M2030())
			{
				M1996(WayXmap[IndexWay + 1]);
				IsWaitNextMap = true;
			}
			M1989(500);
		}
		else if (TileMap.mapID == WayXmap[IndexWay + 1])
		{
			IndexWay++;
		}
		else
		{
			IsNextMapFailed = true;
		}
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
		{
			List<int> idMaps = (List<int>)p;
			M1992(idMaps);
		}
	}

	private static void M1989(int time)
	{
		IsWait = true;
		TimeStartWait = mSystem.M1054();
		TimeWait = time;
	}

	private static bool M1990()
	{
		if (IsWait && mSystem.M1054() - TimeStartWait >= TimeWait)
		{
			IsWait = false;
		}
		return IsWait;
	}

	public static void M1991()
	{
		XmapDataManager.M2008().M2011("TextData\\GroupMapsXmap.txt");
		MyVector t = new MyVector();
		foreach (XmapGroup groupMap in XmapDataManager.M2008().GroupMaps)
		{
			t.M1111(new Command(groupMap.NameGroup, _Instance, 1, groupMap.IdMaps));
		}
		GameCanvas.menu.M877(t, 3);
	}

	public static void M1992(List<int> idMaps)
	{
		XmapController.IsMapTransAsXmap = true;
		int count = idMaps.Count;
		GameCanvas.panel.mapNames = new string[count];
		GameCanvas.panel.planetNames = new string[count];
		for (int i = 0; i < count; i++)
		{
			string text = TileMap.mapNames[idMaps[i]];
			GameCanvas.panel.mapNames[i] = idMaps[i] + ": " + text;
			GameCanvas.panel.planetNames[i] = "---Mạnh Cris---";
		}
		GameCanvas.panel.M1247();
		GameCanvas.panel.M1285();
	}

	public static void M1993(int idMap)
	{
		IdMapEnd = idMap;
		XmapController.IsXmapRunning = true;
	}

	public static void M1994()
	{
		XmapController.IsXmapRunning = false;
		IsNextMapFailed = false;
		XmapDataManager.M2008().MyLinkMaps = null;
		WayXmap = null;
	}

	public static void M1995()
	{
		XmapController.IdMapCapsuleReturn = TileMap.mapID;
	}

	private static void M1996(int idMapNext)
	{
		List<XmapLink> list = XmapDataManager.M2008().M2020(TileMap.mapID);
		if (list != null)
		{
			foreach (XmapLink item in list)
			{
				if (item.MapID == idMapNext)
				{
					M1997(item);
					return;
				}
			}
		}
		GameScr.info1.M762("Lỗi tại dữ liệu", 0);
	}

	private static void M1997(XmapLink mapNext)
	{
		switch (mapNext.Type)
		{
		case XmapLinkType.AutoWaypoint:
			M1998(mapNext);
			break;
		case XmapLinkType.NpcMenu:
			M1999(mapNext);
			break;
		case XmapLinkType.NpcPanel:
			M2000(mapNext);
			break;
		case XmapLinkType.Position:
			M2001(mapNext);
			break;
		case XmapLinkType.Capsule:
			M2002(mapNext);
			break;
		}
	}

	private static void M1998(XmapLink mapNext)
	{
		Waypoint t = XmapDataManager.M2026(mapNext.MapID);
		if (t != null)
		{
			int x = XmapDataManager.M2027(t);
			int y = XmapDataManager.M2028(t);
			M2006(x, y);
			M2007(t);
		}
	}

	private static void M1999(XmapLink mapNext)
	{
		int num = mapNext.Info[0];
		Service.M1594().M1656(num);
		for (int i = 1; i < mapNext.Info.Length; i++)
		{
			int num2 = mapNext.Info[i];
			Service.M1594().M1655((short)num, (sbyte)num2);
		}
	}

	private static void M2000(XmapLink mapNext)
	{
		int num = mapNext.Info[0];
		int num2 = mapNext.Info[1];
		int selected = mapNext.Info[2];
		Service.M1594().M1656(num);
		Service.M1594().M1655((short)num, (sbyte)num2);
		Service.M1594().M1721(selected);
	}

	private static void M2001(XmapLink mapNext)
	{
		int x = mapNext.Info[0];
		int y = mapNext.Info[1];
		M2006(x, y);
		Service.M1594().M1636();
		Service.M1594().M1710();
	}

	private static void M2002(XmapLink mapNext)
	{
		M1995();
		int selected = mapNext.Info[0];
		Service.M1594().M1721(selected);
	}

	public static void M2003()
	{
		XmapController.IsShowPanelMapTrans = false;
		Service.M1594().M1615(0, 1, -1, 193);
	}

	public static void M2004()
	{
		XmapController.IsShowPanelMapTrans = false;
		Service.M1594().M1615(0, 1, -1, 194);
	}

	public static void M2005()
	{
		InfoDlg.M753();
	}

	private static void M2006(int x, int y)
	{
		Char.M113().cx = x;
		Char.M113().cy = y;
		Service.M1594().M1640();
		if (!ItemTime.M839(4387))
		{
			Char.M113().cx = x;
			Char.M113().cy = y + 1;
			Service.M1594().M1640();
			Char.M113().cx = x;
			Char.M113().cy = y;
			Service.M1594().M1640();
		}
	}

	private static void M2007(Waypoint waypoint)
	{
		if (waypoint.isOffline)
		{
			Service.M1594().M1710();
		}
		else
		{
			Service.M1594().M1636();
		}
	}
}
