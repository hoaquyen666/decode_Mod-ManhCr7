public class T105 : T33
{
	public int va;

	private T27 info;

	public static T114 r = new T114();

	public int angle;

	public int vx;

	public int vy;

	public int x;

	public int y;

	public int z;

	public int xTo;

	public int yTo;

	private int life;

	public bool isSpeedUp;

	public int dame;

	public int dameMp;

	public T13 c;

	public bool isBoss;

	public T117 darts = new T117();

	private int dx;

	private int dy;

	public static int[] ARROWINDEX = new int[18]
	{
		0, 15, 37, 52, 75, 105, 127, 142, 165, 195,
		217, 232, 255, 285, 307, 322, 345, 370
	};

	public static int[] TRANSFORM = new int[16]
	{
		0, 0, 0, 7, 6, 6, 6, 2, 2, 3,
		3, 4, 5, 5, 5, 1
	};

	public static sbyte[] FRAME = new sbyte[25]
	{
		0, 1, 2, 1, 0, 1, 2, 1, 0, 1,
		2, 1, 0, 1, 2, 1, 0, 1, 2, 1,
		0, 1, 2, 1, 0
	};

	public T105(int x, int y, bool isBoss, int dame, int dameMp, T13 c, int dartType)
	{
		info = T54.darts[dartType];
		this.x = x;
		this.y = y;
		this.isBoss = isBoss;
		this.dame = dame;
		this.dameMp = dameMp;
		this.c = c;
		va = info.va;
		M1016(T137.M1511(c.cx - x, c.cy - y));
		if (x >= T54.cmx && x <= T54.cmx + T51.w)
		{
			T160.M1826().M1850(dartType);
		}
	}

	public T105(int x, int y, bool isBoss, int dame, int dameMp, int xTo, int yTo, int dartType)
	{
		info = T54.darts[dartType];
		this.x = x;
		this.y = y;
		this.isBoss = isBoss;
		this.dame = dame;
		this.dameMp = dameMp;
		this.xTo = xTo;
		this.yTo = yTo;
		va = info.va;
		M1016(T137.M1511(xTo - x, yTo - y));
		if (x >= T54.cmx && x <= T54.cmx + T51.w)
		{
			T160.M1826().M1850(dartType);
		}
		c = null;
	}

	public void M1016(int angle)
	{
		this.angle = angle;
		vx = va * T137.M1508(angle) >> 10;
		vy = va * T137.M1507(angle) >> 10;
	}

	public static void M1017(int x, int y, bool isBoss, int dame, int dameMp, T13 c, int dartType)
	{
		T33.vEffect2.M1111(new T105(x, y, isBoss, dame, dameMp, c, dartType));
	}

	public static void M1018(int x, int y, bool isBoss, int dame, int dameMp, int xTo, int yTo, int dartType)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T33.vEffect2.M1111(new T105(x, y, isBoss, dame, dameMp, xTo, yTo, dartType));
	}

	public override void update()
	{
		for (int i = 0; i < info.nUpdate; i++)
		{
			if (info.tail.Length != 0)
			{
				darts.M1111(new T156(x, y));
			}
			dx = ((c == null) ? xTo : c.cx) - x;
			dy = ((c == null) ? yTo : c.cy) - 10 - y;
			int num = 60;
			if (T174.mapID == 0)
			{
				num = 600;
			}
			life++;
			if ((c != null && (c.statusMe == 5 || c.statusMe == 14)) || c == null)
			{
				x += (((c == null) ? xTo : c.cx) - x) / 2;
				y += (((c == null) ? yTo : c.cy) - y) / 2;
			}
			if ((T137.M1529(dx) < 16 && T137.M1529(dy) < 16) || life > num)
			{
				if (c != null && c.charID >= 0 && dameMp != -1)
				{
					if (dameMp != -100)
					{
						c.M218(dame, dameMp, isCrit: false, isMob: true);
					}
					else
					{
						T143.M1574(80, c, 1);
					}
				}
				T33.vEffect2.M1119(this);
				if (dameMp != -100)
				{
					T143.M1574(81, c, 1);
					if (x >= T54.cmx && x <= T54.cmx + T51.w)
					{
						T160.M1826().M1845();
					}
				}
			}
			int num2 = T137.M1511(dx, dy);
			if (T94.M869(num2 - angle) < 90 || dx * dx + dy * dy > 4096)
			{
				if (T94.M869(num2 - angle) < 15)
				{
					angle = num2;
				}
				else if ((num2 - angle >= 0 && num2 - angle < 180) || num2 - angle < -180)
				{
					angle = T137.M1512(angle + 15);
				}
				else
				{
					angle = T137.M1512(angle - 15);
				}
			}
			if (!isSpeedUp && va < 8192)
			{
				va += 1024;
			}
			vx = va * T137.M1508(angle) >> 10;
			vy = va * T137.M1507(angle) >> 10;
			dx += vx;
			x += dx >> 10;
			dx &= 1023;
			dy += vy;
			y += dy >> 10;
			dy &= 1023;
		}
		for (int j = 0; j < darts.M1113(); j++)
		{
			T156 t = (T156)darts.M1114(j);
			t.index++;
			if (t.index >= info.tail.Length)
			{
				darts.M1118(j);
			}
		}
	}

	public static int M1019(int angle)
	{
		for (int i = 0; i < ARROWINDEX.Length - 1; i++)
		{
			if (angle >= ARROWINDEX[i] && angle <= ARROWINDEX[i + 1])
			{
				if (i >= 16)
				{
					return 0;
				}
				return i;
			}
		}
		return 0;
	}

	public override void paint(T99 g)
	{
		int num = M1019(360 - angle);
		int num2 = FRAME[num];
		int transform = TRANSFORM[num];
		for (int i = darts.M1113() / 2; i < darts.M1113(); i++)
		{
			T156 t = (T156)darts.M1114(i);
			T157.M1785(g, info.tailBorder[t.index], t.x, t.y, 0, 3);
		}
		int num3 = T51.gameTick % info.headBorder.Length;
		T157.M1785(g, info.headBorder[num3][num2], x, y, transform, 3);
		for (int j = 0; j < darts.M1113(); j++)
		{
			T156 t2 = (T156)darts.M1114(j);
			T157.M1785(g, info.tail[t2.index], t2.x, t2.y, 0, 3);
		}
		T157.M1785(g, info.head[num3][num2], x, y, transform, 3);
		for (int k = 0; k < darts.M1113(); k++)
		{
			T156 t3 = (T156)darts.M1114(k);
			if (T137.M1529(r.M1084(100)) < info.xdPercent)
			{
				T157.M1785(g, (T51.gameTick % 2 != 0) ? info.xd2[t3.index] : info.xd1[t3.index], t3.x, t3.y, 0, 3);
			}
		}
	}

	public static void M1020(int x2, int y2, bool checkIsBoss, int dame2, int dameMp2, T101 mobToAttack, sbyte dartType)
	{
		M1018(x2, y2, checkIsBoss, dame2, dameMp2, mobToAttack.x, mobToAttack.y, dartType);
	}
}
