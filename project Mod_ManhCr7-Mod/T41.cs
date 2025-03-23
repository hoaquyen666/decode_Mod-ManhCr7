public class T41 : T33
{
	public T35 eff;

	private int i0;

	private int dx0;

	private int dy0;

	private int x;

	private int y;

	private T13 c;

	private T101 m;

	private short loopCount;

	private long endTime;

	private int trans;

	public static void M415(int id, int cx, int cy, int loopCount)
	{
		T41 t = new T41();
		t.eff = T54.efs[id - 1];
		t.x = cx;
		t.y = cy;
		t.loopCount = (short)loopCount;
		T33.vEffect3.M1111(t);
	}

	public override void paint(T99 g)
	{
		if (T99.zoomLevel == 1)
		{
			T54.countEff++;
		}
		if (T54.countEff < 8)
		{
			if (c != null)
			{
				x = c.cx;
				y = c.cy + T51.transY;
			}
			if (m != null)
			{
				x = m.x;
				y = m.y + T51.transY;
			}
			int num = x + dx0 + eff.arrEfInfo[i0].dx;
			int num2 = y + dy0 + eff.arrEfInfo[i0].dy;
			T157.M1785(g, eff.arrEfInfo[i0].idImg, num, num2, trans, T99.VCENTER | T99.HCENTER);
		}
	}

	public override void update()
	{
		if ((ulong)endTime > 0uL)
		{
			i0++;
			if (i0 >= eff.arrEfInfo.Length)
			{
				i0 = 0;
			}
			if (T110.M1054() - endTime > 0L)
			{
				T33.vEffect3.M1119(this);
			}
		}
		else
		{
			i0++;
			if (i0 >= eff.arrEfInfo.Length)
			{
				loopCount--;
				if (loopCount <= 0)
				{
					T33.vEffect3.M1119(this);
				}
				else
				{
					i0 = 0;
				}
			}
		}
		if (T51.gameTick % 11 == 0 && c != null && c != T13.M113() && !T54.vCharInMap.M1112(c))
		{
			T33.vEffect3.M1119(this);
		}
	}
}
