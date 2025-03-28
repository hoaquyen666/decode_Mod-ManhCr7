public class EffectFeet : Effect2
{
	private int x;

	private int y;

	private int trans;

	private long endTime;

	private bool isF;

	public static Image imgFeet1 = GameCanvas.M503("/mainImage/myTexture2dmove-1.png");

	public static Image imgFeet3 = GameCanvas.M503("/mainImage/myTexture2dmove-3.png");

	public static void M403(int cx, int cy, int ctrans, int timeLengthInSecond, bool isCF)
	{
		EffectFeet t = new EffectFeet();
		t.x = cx;
		t.y = cy;
		t.trans = ctrans;
		t.isF = isCF;
		t.endTime = mSystem.M1054() + timeLengthInSecond * 1000;
		Effect2.vEffectFeet.M1111(t);
	}

	public override void update()
	{
		if (mSystem.M1054() - endTime > 0L)
		{
			Effect2.vEffectFeet.M1119(this);
		}
	}

	public override void paint(mGraphics g)
	{
		int size = TileMap.size;
		if (TileMap.M1958(x + size / 2, y + 1, 4))
		{
			g.M922(x / size * size, (y - 30) / size * size, size, 100);
		}
		else if (TileMap.M1956((x - size / 2) / size, (y + 1) / size) == 0)
		{
			g.M922(x / size * size, (y - 30) / size * size, 100, 100);
		}
		else if (TileMap.M1956((x + size / 2) / size, (y + 1) / size) == 0)
		{
			g.M922(x / size * size, (y - 30) / size * size, size, 100);
		}
		else if (TileMap.M1958(x - size / 2, y + 1, 8))
		{
			g.M922(x / 24 * size, (y - 30) / size * size, size, 100);
		}
		g.M940((!isF) ? imgFeet3 : imgFeet1, 0, 0, imgFeet1.M727(), imgFeet1.M728(), trans, x, y, mGraphics.BOTTOM | mGraphics.HCENTER);
		g.M922(GameScr.cmx, GameScr.cmy - GameCanvas.transY, GameScr.gW, GameScr.gH + 2 * GameCanvas.transY);
	}
}
