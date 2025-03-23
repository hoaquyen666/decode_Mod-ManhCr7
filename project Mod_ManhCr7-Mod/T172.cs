public class T172
{
	public static int dx;

	public static int tx;

	public static int wStr;

	public static bool isBack;

	public static string laststring = string.Empty;

	public static void M1898()
	{
		dx = 0;
		tx = 0;
		isBack = false;
	}

	public static void M1899(T99 g, string str, int x, int y, int w, int h, T98 f)
	{
		if (wStr != f.M909(str) || !laststring.Equals(str))
		{
			laststring = str;
			dx = 0;
			wStr = f.M909(str);
			isBack = false;
			tx = 0;
		}
		g.M922(x, y, w, h);
		if (wStr > w)
		{
			f.M898(g, str, x - dx, y, 0);
		}
		else
		{
			f.M898(g, str, x + w / 2, y, 2);
		}
		T51.M451(g);
		if (wStr <= w)
		{
			return;
		}
		if (!isBack)
		{
			tx++;
			if (tx > 50)
			{
				dx++;
				if (dx >= wStr)
				{
					tx = 0;
					dx = -w + 30;
					isBack = true;
				}
			}
			return;
		}
		if (dx < 0)
		{
			dx += w + dx >> 1;
		}
		if (dx > 0)
		{
			dx = 0;
		}
		if (dx == 0)
		{
			tx++;
			if (tx == 50)
			{
				tx = 0;
				isBack = false;
			}
		}
	}
}
