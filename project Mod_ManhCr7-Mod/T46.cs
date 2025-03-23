using System;

public class T46
{
	private static int w;

	private static int h;

	private static T114 r = new T114();

	private static T117 mg = new T117();

	private static int f = 17;

	private static int x;

	private static int y;

	private static int ag;

	private static int x0;

	private static int y0;

	private static int t;

	private static int v;

	private static int ymax = 269;

	private static float a;

	private static int[] mang_x = new int[3];

	private static int[] mang_y = new int[3];

	private static bool st = false;

	private static long last = 0L;

	private static long delay = 150L;

	public static void M432()
	{
		if (st)
		{
			M436();
		}
		if (t > 32 && st)
		{
			st = false;
			mg.M1120();
			mg.M1111(new T47(T137.M1522(50, T51.w - 50), T137.M1522(T51.h - 100, T51.h), 5, 72));
		}
	}

	public static void M433(T99 g)
	{
		M432();
		g.M933(0);
		g.M932(0, 0, w, h);
		g.M933(16711680);
		for (int i = 0; i < mg.M1113(); i++)
		{
			((T47)mg.M1114(i)).M438(g);
		}
		if (!st)
		{
			M434(-(T94.M869(r.M1083() % 3) + 5));
		}
	}

	public static void M434(int k)
	{
		if (k == -5 && !st)
		{
			x0 = w / 2;
			ag = 80;
			st = true;
			M435();
		}
		else if (k == -7 && !st)
		{
			ag = 60;
			x0 = 0;
			st = true;
			M435();
		}
		else if (k == -6 && !st)
		{
			ag = 120;
			x0 = w;
			st = true;
			M435();
		}
	}

	public static void M435()
	{
		y0 = 0;
		v = 16;
		t = 0;
		a = 0f;
		for (int i = 0; i < 3; i++)
		{
			mang_y[i] = 0;
			mang_x[i] = x0;
		}
		st = true;
	}

	public static void M436()
	{
		mang_y[2] = mang_y[1];
		mang_x[2] = mang_x[1];
		mang_y[1] = mang_y[0];
		mang_x[1] = mang_x[0];
		mang_y[0] = y;
		mang_x[0] = x;
		x = T137.M1508((int)((double)ag * Math.PI / 180.0)) * v * t + x0;
		y = (int)((float)(v * T137.M1507((int)((double)ag * Math.PI / 180.0)) * t) - a * (float)t * (float)t / 2f) + y0;
		if (M437() - last >= delay)
		{
			t++;
			last = M437();
		}
	}

	public static long M437()
	{
		return T110.M1054();
	}
}
