using System;

namespace Xmap;

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
				GameScr.info1.M762("Đã huỷ Xmap", 0);
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
				GameScr.info1.M762("Đã huỷ Xmap", 0);
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
			GameScr.info1.M762("Sử dụng capsule thường Xmap: " + (IsUseCapsuleNormal ? "Bật" : "Tắt"), 0);
		}
		else
		{
			if (!(text == "csdb"))
			{
				return false;
			}
			IsUseCapsuleVip = !IsUseCapsuleVip;
			GameScr.info1.M762("Sử dụng capsule đặc biệt Xmap: " + (IsUseCapsuleVip ? "Bật" : "Tắt"), 0);
		}
		return true;
	}

	public static bool M1971()
	{
		switch (GameCanvas.keyAsciiPress)
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
		Teleport t = (Teleport)obj;
		if (t.isMe)
		{
			Char.M113().isTeleport = false;
			if (t.type == 0)
			{
				Controller.isStopReadMessage = false;
				Char.ischangingMap = true;
			}
			Teleport.vTeleport.M1119(t);
			return true;
		}
		return false;
	}

	public static void M1975(int selected)
	{
		if (IsMapTransAsXmap)
		{
			XmapExecutor.M2005();
			string mapName = GameCanvas.panel.mapNames[selected];
			int idMap = XmapDataManager.M2025(mapName);
			XmapExecutor.M1993(idMap);
		}
		else
		{
			XmapExecutor.M1995();
			Service.M1594().M1721(selected);
		}
	}

	public static void M1976()
	{
		IsMapTransAsXmap = false;
		if (IsShowPanelMapTrans)
		{
			GameCanvas.panel.M1247();
			GameCanvas.panel.M1285();
		}
		else
		{
			IsShowPanelMapTrans = true;
		}
	}

	public static void M1977()
	{
		Controller.M300().M310(0);
		Service.M1594().M1712();
		Char.isLoadingMap = false;
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
