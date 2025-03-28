public class PlayerDart
{
	public Char charBelong;

	public DartInfo info;

	public MyVector darts = new MyVector();

	public int angle;

	public int vx;

	public int vy;

	public int va;

	public int x;

	public int y;

	public int z;

	private int life;

	private int dx;

	private int dy;

	public bool isActive = true;

	public bool isSpeedUp;

	public SkillPaint skillPaint;

	public PlayerDart(Char charBelong, int dartType, SkillPaint sp, int x, int y)
	{
		skillPaint = sp;
		this.charBelong = charBelong;
		info = GameScr.darts[dartType];
		va = info.va;
		this.x = x;
		this.y = y;
		IMapObject t;
		if (charBelong.mobFocus == null)
		{
			IMapObject charFocus = charBelong.charFocus;
			t = charFocus;
		}
		else
		{
			IMapObject mobFocus = charBelong.mobFocus;
			t = mobFocus;
		}
		IMapObject t2 = t;
		M1462(Res.M1511(t2.getX() - x, t2.getY() - y));
	}

	public void M1462(int angle)
	{
		this.angle = angle;
		vx = va * Res.M1508(angle) >> 10;
		vy = va * Res.M1507(angle) >> 10;
	}

	public void M1463()
	{
		if (!isActive)
		{
			return;
		}
		if (charBelong.mobFocus == null && charBelong.charFocus == null)
		{
			M1464();
			return;
		}
		IMapObject t;
		if (charBelong.mobFocus == null)
		{
			IMapObject charFocus = charBelong.charFocus;
			t = charFocus;
		}
		else
		{
			IMapObject mobFocus = charBelong.mobFocus;
			t = mobFocus;
		}
		IMapObject t2 = t;
		for (int i = 0; i < info.nUpdate; i++)
		{
			if (info.tail.Length != 0)
			{
				darts.M1111(new SmallDart(x, y));
			}
			int num = ((charBelong.getX() <= t2.getX()) ? (-10) : 10);
			dx = t2.getX() + num - x;
			dy = t2.getY() - t2.getH() / 2 - y;
			life++;
			if (Res.M1529(dx) >= 20 || Res.M1529(dy) >= 20)
			{
				int num2 = Res.M1511(dx, dy);
				if (Math.M869(num2 - angle) < 90 || dx * dx + dy * dy > 4096)
				{
					if (Math.M869(num2 - angle) < 15)
					{
						angle = num2;
					}
					else if ((num2 - angle >= 0 && num2 - angle < 180) || num2 - angle < -180)
					{
						angle = Res.M1512(angle + 15);
					}
					else
					{
						angle = Res.M1512(angle - 15);
					}
				}
				if (!isSpeedUp && va < 8192)
				{
					va += 1024;
				}
				vx = va * Res.M1508(angle) >> 10;
				vy = va * Res.M1507(angle) >> 10;
				dx += vx;
				x += dx >> 10;
				dx &= 1023;
				dy += vy;
				y += dy >> 10;
				dy &= 1023;
				continue;
			}
			if (charBelong.charFocus != null && charBelong.charFocus.me)
			{
				charBelong.charFocus.M218(charBelong.charFocus.damHP, 0, charBelong.charFocus.isCrit, charBelong.charFocus.isMob);
			}
			M1464();
			return;
		}
		for (int j = 0; j < darts.M1113(); j++)
		{
			SmallDart t3 = (SmallDart)darts.M1114(j);
			t3.index++;
			if (t3.index >= info.tail.Length)
			{
				darts.M1118(j);
			}
		}
	}

	private void M1464()
	{
		if (!charBelong.isUseSkillAfterCharge && x >= GameScr.cmx && x <= GameScr.cmx + GameCanvas.w)
		{
			SoundMn.M1826().M1844();
		}
		charBelong.M179();
		if (charBelong.me)
		{
			charBelong.M131();
		}
		if (charBelong.isUseSkillAfterCharge)
		{
			charBelong.isUseSkillAfterCharge = false;
			if (charBelong.isLockMove && charBelong.me && charBelong.statusMe != 14 && charBelong.statusMe != 5)
			{
				charBelong.isLockMove = false;
			}
			GameScr.M559().M590(x, y);
		}
		charBelong.dart = null;
		charBelong.isCreateDark = false;
		charBelong.skillPaint = null;
		charBelong.skillPaintRandomPaint = null;
	}

	public void M1465(mGraphics g)
	{
		if (!isActive)
		{
			return;
		}
		int num = MonsterDart.M1019(360 - angle);
		int num2 = MonsterDart.FRAME[num];
		int transform = MonsterDart.TRANSFORM[num];
		for (int i = darts.M1113() / 2; i < darts.M1113(); i++)
		{
			SmallDart t = (SmallDart)darts.M1114(i);
			SmallImage.M1785(g, info.tailBorder[t.index], t.x, t.y, 0, 3);
		}
		int num3 = GameCanvas.gameTick % info.headBorder.Length;
		SmallImage.M1785(g, info.headBorder[num3][num2], x, y, transform, 3);
		for (int j = 0; j < darts.M1113(); j++)
		{
			SmallDart t2 = (SmallDart)darts.M1114(j);
			SmallImage.M1785(g, info.tail[t2.index], t2.x, t2.y, 0, 3);
		}
		SmallImage.M1785(g, info.head[num3][num2], x, y, transform, 3);
		for (int k = 0; k < darts.M1113(); k++)
		{
			SmallDart t3 = (SmallDart)darts.M1114(k);
			if (Res.M1529(MonsterDart.r.M1084(100)) < info.xdPercent)
			{
				SmallImage.M1785(g, (GameCanvas.gameTick % 2 != 0) ? info.xd2[t3.index] : info.xd1[t3.index], t3.x, t3.y, 0, 3);
			}
		}
		g.M933(16711680);
	}
}
