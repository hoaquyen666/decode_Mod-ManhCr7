using System;

namespace N0.N1.N2;

public class XmapController
{
	public static bool IsXmapRunning = false;

	public static bool IsMapTransAsXmap = false;

	public static bool IsShowPanelMapTrans = true;

	public static bool IsUseCapsuleNormal = false;

	public static bool IsUseCapsuleVip = true;

	public static int IdMapCapsuleReturn = -1;

	public static bool M1970(string text)
	{
		if (text == "xmp")
		{
			if (IsXmapRunning)
			{
				XmapExecutor.M1994();
				T54.info1.M762("Đã huỷ Xmap", 0);
			}
			else
			{
				XmapExecutor.M1991();
			}
		}
		else if (M1978<int>(text, "xmp"))
		{
			if (IsXmapRunning)
			{
				XmapExecutor.M1994();
				T54.info1.M762("Đã huỷ Xmap", 0);
			}
			else
			{
				int idMap = M1979<int>(text, "xmp");
				XmapExecutor.M1993(idMap);
			}
		}
		else if (text == "csb")
		{
			IsUseCapsuleNormal = !IsUseCapsuleNormal;
			T54.info1.M762("Sử dụng capsule thường Xmap: " + (IsUseCapsuleNormal ? "Bật" : "Tắt"), 0);
		}
		else
		{
			if (!(text == "csdb"))
			{
				return false;
			}
			IsUseCapsuleVip = !IsUseCapsuleVip;
			T54.info1.M762("Sử dụng capsule đặc biệt Xmap: " + (IsUseCapsuleVip ? "Bật" : "Tắt"), 0);
		}
		return true;
	}

	public static bool M1971()
	{
		switch (T51.keyAsciiPress)
		{
		default:
			return false;
		case 96:
			M1970("xmp");
			break;
		case 47:
			M1970("csb");
			break;
		}
		return true;
	}

	public static void M1972()
	{
		if (XmapDataManager.M2008().IsLoading)
		{
			XmapDataManager.M2008().M2010();
		}
		if (IsXmapRunning)
		{
			XmapExecutor.M1988();
		}
	}

	public static void M1973(string text)
	{
		if (text.Equals("Bạn chưa thể đến khu vực này"))
		{
			XmapExecutor.M1994();
		}
	}

	public static bool M1974(object obj)
	{
		T171 t = (T171)obj;
		if (t.isMe)
		{
			T13.M113().isTeleport = false;
			if (t.type == 0)
			{
				T23.isStopReadMessage = false;
				T13.ischangingMap = true;
			}
			T171.vTeleport.M1119(t);
			return true;
		}
		return false;
	}

	public static void M1975(int selected)
	{
		if (IsMapTransAsXmap)
		{
			XmapExecutor.M2005();
			string mapName = T51.panel.mapNames[selected];
			int idMap = XmapDataManager.M2025(mapName);
			XmapExecutor.M1993(idMap);
		}
		else
		{
			XmapExecutor.M1995();
			T146.M1594().M1721(selected);
		}
	}

	public static void M1976()
	{
		IsMapTransAsXmap = false;
		if (IsShowPanelMapTrans)
		{
			T51.panel.M1247();
			T51.panel.M1285();
		}
		else
		{
			IsShowPanelMapTrans = true;
		}
	}

	public static void M1977()
	{
		T23.M300().M310(0);
		T146.M1594().M1712();
		T13.isLoadingMap = false;
	}

	private static bool M1978<T>(string text, string s)
	{
		if (!text.StartsWith(s))
		{
			return false;
		}
		try
		{
			Convert.ChangeType(text.Substring(s.Length), typeof(T));
		}
		catch
		{
			return false;
		}
		return true;
	}

	private static T M1979<T>(string text, string s)
	{
		return (T)Convert.ChangeType(text.Substring(s.Length), typeof(T));
	}
}
