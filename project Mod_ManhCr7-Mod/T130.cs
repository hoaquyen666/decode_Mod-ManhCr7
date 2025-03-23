public class T130
{
	public T13 charBelong;

	public T27 info;

	public T117 darts = new T117();

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

	public T153 skillPaint;

	public T130(T13 charBelong, int dartType, T153 sp, int x, int y)
	{
		skillPaint = sp;
		this.charBelong = charBelong;
		info = T54.darts[dartType];
		va = info.va;
		this.x = x;
		this.y = y;
		T62 t;
		if (charBelong.mobFocus == null)
		{
			T62 charFocus = charBelong.charFocus;
			t = charFocus;
		}
		else
		{
			T62 mobFocus = charBelong.mobFocus;
			t = mobFocus;
		}
		T62 t2 = t;
		M1462(T137.M1511(t2.getX() - x, t2.getY() - y));
	}

	public void M1462(int angle)
	{
		this.angle = angle;
		vx = va * T137.M1508(angle) >> 10;
		vy = va * T137.M1507(angle) >> 10;
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
		T62 t;
		if (charBelong.mobFocus == null)
		{
			T62 charFocus = charBelong.charFocus;
			t = charFocus;
		}
		else
		{
			T62 mobFocus = charBelong.mobFocus;
			t = mobFocus;
		}
		T62 t2 = t;
		for (int i = 0; i < info.nUpdate; i++)
		{
			if (info.tail.Length != 0)
			{
				darts.M1111(new T156(x, y));
			}
			int num = ((charBelong.getX() <= t2.getX()) ? (-10) : 10);
			dx = t2.getX() + num - x;
			dy = t2.getY() - t2.getH() / 2 - y;
			life++;
			if (T137.M1529(dx) >= 20 || T137.M1529(dy) >= 20)
			{
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
			T156 t3 = (T156)darts.M1114(j);
			t3.index++;
			if (t3.index >= info.tail.Length)
			{
				darts.M1118(j);
			}
		}
	}

	private void M1464()
	{
		if (!charBelong.isUseSkillAfterCharge && x >= T54.cmx && x <= T54.cmx + T51.w)
		{
			T160.M1826().M1844();
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
			T54.M559().M590(x, y);
		}
		charBelong.dart = null;
		charBelong.isCreateDark = false;
		charBelong.skillPaint = null;
		charBelong.skillPaintRandomPaint = null;
	}

	public void M1465(T99 g)
	{
		if (!isActive)
		{
			return;
		}
		int num = T105.M1019(360 - angle);
		int num2 = T105.FRAME[num];
		int transform = T105.TRANSFORM[num];
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
			if (T137.M1529(T105.r.M1084(100)) < info.xdPercent)
			{
				T157.M1785(g, (T51.gameTick % 2 != 0) ? info.xd2[t3.index] : info.xd1[t3.index], t3.x, t3.y, 0, 3);
			}
		}
		g.M933(16711680);
	}
}
