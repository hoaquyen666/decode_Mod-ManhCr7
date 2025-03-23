using UnityEngine;

internal class T120
{
	public static WWW www;

	public static T22 h;

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

	public static void M1153(string link, T22 h)
	{
		if (www != null)
		{
			T24.M328("GET HTTP BUSY");
		}
		www = new WWW(link);
		T120.h = h;
	}

	public static void M1154(string link, T22 h)
	{
		T120.h = h;
		if (link != null)
		{
			h.M293(link);
		}
	}
}
