public class T37 : T33
{
	private int x;

	private int y;

	private int trans;

	private long endTime;

	private bool isF;

	public static T60 imgFeet1 = T51.M503("/mainImage/myTexture2dmove-1.png");

	public static T60 imgFeet3 = T51.M503("/mainImage/myTexture2dmove-3.png");

	public static void M403(int cx, int cy, int ctrans, int timeLengthInSecond, bool isCF)
	{
		T37 t = new T37();
		t.x = cx;
		t.y = cy;
		t.trans = ctrans;
		t.isF = isCF;
		t.endTime = T110.M1054() + timeLengthInSecond * 1000;
		T33.vEffectFeet.M1111(t);
	}

	public override void update()
	{
		if (T110.M1054() - endTime > 0L)
		{
			T33.vEffectFeet.M1119(this);
		}
	}

	public override void paint(T99 g)
	{
		int size = T174.size;
		if (T174.M1958(x + size / 2, y + 1, 4))
		{
			g.M922(x / size * size, (y - 30) / size * size, size, 100);
		}
		else if (T174.M1956((x - size / 2) / size, (y + 1) / size) == 0)
		{
			g.M922(x / size * size, (y - 30) / size * size, 100, 100);
		}
		else if (T174.M1956((x + size / 2) / size, (y + 1) / size) == 0)
		{
			g.M922(x / size * size, (y - 30) / size * size, size, 100);
		}
		else if (T174.M1958(x - size / 2, y + 1, 8))
		{
			g.M922(x / 24 * size, (y - 30) / size * size, size, 100);
		}
		g.M940((!isF) ? imgFeet3 : imgFeet1, 0, 0, imgFeet1.M727(), imgFeet1.M728(), trans, x, y, T99.BOTTOM | T99.HCENTER);
		g.M922(T54.cmx, T54.cmy - T51.transY, T54.gW, T54.gH + 2 * T51.transY);
	}
}
