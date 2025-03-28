using System.Collections.Generic;

namespace Xmap;

public class XmapNavigator
{
	public static List<int> M1980(int idMapStart, int idMapEnd)
	{
		List<int> wayPassed = M1983(idMapStart);
		return M1981(idMapEnd, wayPassed);
	}

	private static List<int> M1981(int idMapEnd, List<int> wayPassed)
	{
		int num = wayPassed[wayPassed.Count - 1];
		if (num == idMapEnd)
		{
			return wayPassed;
		}
		if (!XmapDataManager.M2008().M2021(num))
		{
			return null;
		}
		List<List<int>> list = new List<List<int>>();
		List<XmapLink> list2 = XmapDataManager.M2008().M2020(num);
		foreach (XmapLink item in list2)
		{
			List<int> list3 = null;
			if (!wayPassed.Contains(item.MapID))
			{
				List<int> wayPassed2 = M1984(wayPassed, item.MapID);
				list3 = M1981(idMapEnd, wayPassed2);
			}
			if (list3 != null)
			{
				list.Add(list3);
			}
		}
		return M1982(list);
	}

	private static List<int> M1982(List<List<int>> ways)
	{
		if (ways.Count == 0)
		{
			return null;
		}
		List<int> list = ways[0];
		for (int i = 1; i < ways.Count; i++)
		{
			if (M1985(ways[i], list))
			{
				list = ways[i];
			}
		}
		return list;
	}

	private static List<int> M1983(int idMapStart)
	{
		return new List<int> { idMapStart };
	}

	private static List<int> M1984(List<int> wayPassed, int idMapNext)
	{
		return new List<int>(wayPassed) { idMapNext };
	}

	private static bool M1985(List<int> way1, List<int> way2)
	{
		bool flag = M1986(way1);
		bool flag2 = M1986(way2);
		if (flag && !flag2)
		{
			return false;
		}
		if (!flag && flag2)
		{
			return true;
		}
		if (way1.Count >= way2.Count)
		{
			return false;
		}
		return true;
	}

	private static bool M1986(List<int> way)
	{
		return M1987(way);
	}

	private static bool M1987(List<int> way)
	{
		List<int> list = new List<int> { 27, 28, 29 };
		int num = 1;
		while (true)
		{
			if (num < way.Count - 1)
			{
				if (way[num] == 102 && way[num + 1] == 24 && list.Contains(way[num - 1]))
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
