public class Res
{
	private static short[] sinz = new short[91]
	{
		0, 18, 36, 54, 71, 89, 107, 125, 143, 160,
		178, 195, 213, 230, 248, 265, 282, 299, 316, 333,
		350, 367, 384, 400, 416, 433, 449, 465, 481, 496,
		512, 527, 543, 558, 573, 587, 602, 616, 630, 644,
		658, 672, 685, 698, 711, 724, 737, 749, 761, 773,
		784, 796, 807, 818, 828, 839, 849, 859, 868, 878,
		887, 896, 904, 912, 920, 928, 935, 943, 949, 956,
		962, 968, 974, 979, 984, 989, 994, 998, 1002, 1005,
		1008, 1011, 1014, 1016, 1018, 1020, 1022, 1023, 1023, 1024,
		1024
	};

	private static short[] cosz;

	private static int[] tanz;

	public static int count;

	public static bool isIcon;

	public static bool isBig;

	public static MyVector debug = new MyVector();

	public static MyRandom r = new MyRandom();

	public static void M1506()
	{
		cosz = new short[91];
		tanz = new int[91];
		for (int i = 0; i <= 90; i++)
		{
			cosz[i] = sinz[90 - i];
			if (cosz[i] == 0)
			{
				tanz[i] = int.MaxValue;
			}
			else
			{
				tanz[i] = (sinz[i] << 10) / cosz[i];
			}
		}
	}

	public static int M1507(int a)
	{
		a = M1512(a);
		if (a >= 0 && a < 90)
		{
			return sinz[a];
		}
		if (a >= 90 && a < 180)
		{
			return sinz[180 - a];
		}
		if (a >= 180 && a < 270)
		{
			return -sinz[a - 180];
		}
		return -sinz[360 - a];
	}

	public static int M1508(int a)
	{
		a = M1512(a);
		if (a >= 0 && a < 90)
		{
			return cosz[a];
		}
		if (a >= 90 && a < 180)
		{
			return -cosz[180 - a];
		}
		if (a >= 180 && a < 270)
		{
			return -cosz[a - 180];
		}
		return cosz[360 - a];
	}

	public static int M1509(int a)
	{
		a = M1512(a);
		if (a >= 0 && a < 90)
		{
			return tanz[a];
		}
		if (a >= 90 && a < 180)
		{
			return -tanz[180 - a];
		}
		if (a >= 180 && a < 270)
		{
			return tanz[a - 180];
		}
		return -tanz[360 - a];
	}

	public static int M1510(int a)
	{
		for (int i = 0; i <= 90; i++)
		{
			if (tanz[i] >= a)
			{
				return i;
			}
		}
		return 0;
	}

	public static int M1511(int dx, int dy)
	{
		int num;
		if (dx != 0)
		{
			num = M1510(Math.M869((dy << 10) / dx));
			if (dy >= 0 && dx < 0)
			{
				num = 180 - num;
			}
			if (dy < 0 && dx < 0)
			{
				num = 180 + num;
			}
			if (dy < 0 && dx >= 0)
			{
				num = 360 - num;
			}
		}
		else
		{
			num = ((dy <= 0) ? 270 : 90);
		}
		return num;
	}

	public static int M1512(int angle)
	{
		if (angle >= 360)
		{
			angle -= 360;
		}
		if (angle < 0)
		{
			angle += 360;
		}
		return angle;
	}

	public static void M1513(string s)
	{
	}

	public static void M1514(string s)
	{
	}

	public static void M1515(string s)
	{
	}

	public static void M1516(mGraphics g)
	{
	}

	public static void M1517()
	{
	}

	public static string M1518(string str)
	{
		return str;
	}

	public static string M1519(string _text, string _searchStr, string _replacementStr)
	{
		return _text.Replace(_searchStr, _replacementStr);
	}

	public static int M1520(int goc, int d)
	{
		return M1508(M1512(goc)) * d >> 10;
	}

	public static int M1521(int goc, int d)
	{
		return M1507(M1512(goc)) * d >> 10;
	}

	public static int M1522(int a, int b)
	{
		if (a == b)
		{
			return a;
		}
		return a + r.M1084(b - a);
	}

	public static int M1523(int a)
	{
		return r.M1084(a);
	}

	public static int M1524(int a)
	{
		int num;
		for (num = 0; num == 0; num = r.M1083() % a)
		{
		}
		return num;
	}

	public static int M1525(int currentTimeMillis)
	{
		int num = 0;
		num = currentTimeMillis * 16 / 1000;
		if (currentTimeMillis * 16 % 1000 >= 5)
		{
			num++;
		}
		return num;
	}

	public static int M1526(int x1, int y1, int x2, int y2)
	{
		return M1527((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
	}

	public static int M1527(int a)
	{
		if (a <= 0)
		{
			return 0;
		}
		int num = (a + 1) / 2;
		int num2;
		do
		{
			num2 = num;
			num = num / 2 + a / (2 * num);
		}
		while (Math.M869(num2 - num) > 1);
		return num;
	}

	public static int M1528(int a)
	{
		return r.M1084(a);
	}

	public static int M1529(int i)
	{
		if (i > 0)
		{
			return i;
		}
		return -i;
	}

	public static bool M1530(int x1, int y1, int width, int height, int x2, int y2)
	{
		if (x2 >= x1 && x2 <= x1 + width && y2 >= y1)
		{
			return y2 <= y1 + height;
		}
		return false;
	}

	public static string[] M1531(string original, string separator, int count)
	{
		int num = original.IndexOf(separator);
		string[] array;
		if (num >= 0)
		{
			array = M1531(original.Substring(num + separator.Length), separator, count + 1);
		}
		else
		{
			array = new string[count + 1];
			num = original.Length;
		}
		array[count] = original.Substring(0, num);
		return array;
	}

	public static string M1532(long number)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		empty = string.Empty;
		if (number >= 1000000000L)
		{
			empty2 = mResources.billion;
			long num = number % 1000000000L / 100000000L;
			number /= 1000000000L;
			empty = number + string.Empty;
			if (num > 0L)
			{
				return empty + "," + num + empty2;
			}
			return empty + empty2;
		}
		if (number >= 1000000L)
		{
			empty2 = mResources.million;
			long num2 = number % 1000000L / 100000L;
			number /= 1000000L;
			empty = number + string.Empty;
			if (num2 > 0L)
			{
				return empty + "," + num2 + empty2;
			}
			return empty + empty2;
		}
		return number + string.Empty;
	}

	public static string M1533(long number)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		empty = string.Empty;
		if (number >= 1000000000L)
		{
			empty2 = mResources.billion;
			long num = number % 1000000000L / 10000000L;
			number /= 1000000000L;
			empty = number + string.Empty;
			if (num >= 10L)
			{
				if (num % 10L == 0L)
				{
					num /= 10L;
				}
				return empty + "," + num + empty2;
			}
			if (num > 0L)
			{
				return empty + ",0" + num + empty2;
			}
			return empty + empty2;
		}
		if (number >= 1000000L)
		{
			empty2 = mResources.million;
			long num2 = number % 1000000L / 10000L;
			number /= 1000000L;
			empty = number + string.Empty;
			if (num2 >= 10L)
			{
				if (num2 % 10L == 0L)
				{
					num2 /= 10L;
				}
				return empty + "," + num2 + empty2;
			}
			if (num2 > 0L)
			{
				return empty + ",0" + num2 + empty2;
			}
			return empty + empty2;
		}
		if (number >= 10000L)
		{
			empty2 = "k";
			long num3 = number % 1000L / 10L;
			number /= 1000L;
			empty = number + string.Empty;
			if (num3 >= 10L)
			{
				if (num3 % 10L == 0L)
				{
					num3 /= 10L;
				}
				return empty + "," + num3 + empty2;
			}
			if (num3 > 0L)
			{
				return empty + ",0" + num3 + empty2;
			}
			return empty + empty2;
		}
		return number + string.Empty;
	}
}
