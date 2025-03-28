using UnityEngine;

internal class Net
{
	public static WWW www;

	public static Command h;

	public static void M1152()
	{
		if (www != null && www.isDone)
		{
			string str = string.Empty;
			if (www.error == null || www.error.Equals(string.Empty))
			{
				str = www.text;
			}
			www = null;
			if (h != null)
			{
				h.M293(str);
			}
		}
	}

	public static void M1153(string link, Command h)
	{
		if (www != null)
		{
			Cout.M328("GET HTTP BUSY");
		}
		www = new WWW(link);
		Net.h = h;
	}

	public static void M1154(string link, Command h)
	{
		Net.h = h;
		if (link != null)
		{
			h.M293(link);
		}
	}
}
