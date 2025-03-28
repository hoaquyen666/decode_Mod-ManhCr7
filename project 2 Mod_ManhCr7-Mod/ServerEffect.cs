public class ServerEffect : Effect2
{
	public EffectCharPaint eff;

	private int i0;

	private int dx0;

	private int dy0;

	private int x;

	private int y;

	private Char c;

	private Mob m;

	private short loopCount;

	private long endTime;

	private int trans;

	public static void M1571(int id, int cx, int cy, int loopCount)
	{
		ServerEffect t = new ServerEffect();
		t.eff = GameScr.efs[id - 1];
		t.x = cx;
		t.y = cy;
		t.loopCount = (short)loopCount;
		Effect2.vEffect2.M1111(t);
	}

	public static void M1572(int id, int cx, int cy, int loopCount, int trans)
	{
		ServerEffect t = new ServerEffect();
		t.eff = GameScr.efs[id - 1];
		t.x = cx;
		t.y = cy;
		t.loopCount = (short)loopCount;
		t.trans = trans;
		Effect2.vEffect2.M1111(t);
	}

	public static void M1573(int id, Mob m, int loopCount)
	{
		ServerEffect t = new ServerEffect();
		t.eff = GameScr.efs[id - 1];
		t.m = m;
		t.loopCount = (short)loopCount;
		Effect2.vEffect2.M1111(t);
	}

	public static void M1574(int id, Char c, int loopCount)
	{
		ServerEffect t = new ServerEffect();
		t.eff = GameScr.efs[id - 1];
		t.c = c;
		t.loopCount = (short)loopCount;
		Effect2.vEffect2.M1111(t);
	}

	public static void M1575(int id, Char c, int loopCount, int trans)
	{
		ServerEffect t = new ServerEffect();
		t.eff = GameScr.efs[id - 1];
		t.c = c;
		t.loopCount = (short)loopCount;
		t.trans = trans;
		Effect2.vEffect2.M1111(t);
	}

	public static void M1576(int id, int cx, int cy, int timeLengthInSecond)
	{
		ServerEffect t = new ServerEffect();
		t.eff = GameScr.efs[id - 1];
		t.x = cx;
		t.y = cy;
		t.endTime = mSystem.M1054() + timeLengthInSecond * 1000;
		Effect2.vEffect2.M1111(t);
	}

	public static void M1577(int id, Char c, int timeLengthInSecond)
	{
		ServerEffect t = new ServerEffect();
		t.eff = GameScr.efs[id - 1];
		t.c = c;
		t.endTime = mSystem.M1054() + timeLengthInSecond * 1000;
		Effect2.vEffect2.M1111(t);
	}

	public override void paint(mGraphics g)
	{
		if (mGraphics.zoomLevel == 1)
		{
			GameScr.countEff++;
		}
		if (GameScr.countEff < 8)
		{
			if (c != null)
			{
				x = c.cx;
				y = c.cy + GameCanvas.transY;
			}
			if (m != null)
			{
				x = m.x;
				y = m.y + GameCanvas.transY;
			}
			int num = x + dx0 + eff.arrEfInfo[i0].dx;
			int num2 = y + dy0 + eff.arrEfInfo[i0].dy;
			if (GameCanvas.M511(num, num2))
			{
				SmallImage.M1785(g, eff.arrEfInfo[i0].idImg, num, num2, trans, mGraphics.VCENTER | mGraphics.HCENTER);
			}
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
			if (mSystem.M1054() - endTime > 0L)
			{
				Effect2.vEffect2.M1119(this);
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
					Effect2.vEffect2.M1119(this);
				}
				else
				{
					i0 = 0;
				}
			}
		}
		if (GameCanvas.gameTick % 11 == 0 && c != null && c != Char.M113() && !GameScr.vCharInMap.M1112(c))
		{
			Effect2.vEffect2.M1119(this);
		}
	}
}
