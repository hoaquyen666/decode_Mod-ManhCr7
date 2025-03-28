public class InfoDlg
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
			InfoDlg.title = title;
			subtitke = subtitle;
			InfoDlg.delay = delay;
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

	public static void M751(mGraphics g)
	{
		if (isShow && (!isLock || delay <= 4990) && !GameScr.isPaintAlert)
		{
			int num = 10;
			GameCanvas.paintz.M1234(GameCanvas.hw - 75, 10, 150, 55, g);
			if (isLock)
			{
				GameCanvas.M514(GameCanvas.hw - mFont.tahoma_8b.M909(title) / 2 - 10, num + 28, g);
				mFont.tahoma_8b.M898(g, title, GameCanvas.hw + 5, num + 21, 2);
			}
			else if (subtitke != null)
			{
				mFont.tahoma_8b.M898(g, title, GameCanvas.hw, num + 13, 2);
				mFont.tahoma_7_green2.M898(g, subtitke, GameCanvas.hw, num + 30, 2);
			}
			else
			{
				mFont.tahoma_8b.M898(g, title, GameCanvas.hw, num + 21, 2);
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
