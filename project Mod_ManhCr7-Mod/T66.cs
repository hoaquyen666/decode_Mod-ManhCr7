public class T66
{
	public static bool isShow;

	private static string title;

	private static string subtitke;

	public static int delay;

	public static bool isLock;

	public static void M748(string title, string subtitle, int delay)
	{
		if (title != null)
		{
			isShow = true;
			T66.title = title;
			subtitke = subtitle;
			T66.delay = delay;
		}
	}

	public static void M749()
	{
		M748(mResources.PLEASEWAIT, null, 1000);
		isLock = true;
	}

	public static void M750(string str)
	{
		M748(str, null, 700);
		isLock = true;
	}

	public static void M751(T99 g)
	{
		if (isShow && (!isLock || delay <= 4990) && !T54.isPaintAlert)
		{
			int num = 10;
			T51.paintz.M1234(T51.hw - 75, 10, 150, 55, g);
			if (isLock)
			{
				T51.M514(T51.hw - T98.tahoma_8b.M909(title) / 2 - 10, num + 28, g);
				T98.tahoma_8b.M898(g, title, T51.hw + 5, num + 21, 2);
			}
			else if (subtitke != null)
			{
				T98.tahoma_8b.M898(g, title, T51.hw, num + 13, 2);
				T98.tahoma_7_green2.M898(g, subtitke, T51.hw, num + 30, 2);
			}
			else
			{
				T98.tahoma_8b.M898(g, title, T51.hw, num + 21, 2);
			}
		}
	}

	public static void M752()
	{
		if (delay > 0)
		{
			delay--;
			if (delay == 0)
			{
				M753();
			}
		}
	}

	public static void M753()
	{
		title = string.Empty;
		subtitke = null;
		isLock = false;
		delay = 0;
		isShow = false;
	}
}
