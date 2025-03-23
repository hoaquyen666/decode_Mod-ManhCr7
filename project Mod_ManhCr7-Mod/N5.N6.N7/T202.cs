using System;

namespace N5.N6.N7;

public class T202 : T101, T62
{
	public static T60 shadowBig = T51.M503("/mainImage/shadowBig.png");

	public static T36 data;

	public int xTo;

	public int yTo;

	public bool haftBody;

	public bool change;

	public new int xSd;

	public new int ySd;

	private bool isOutMap;

	private int wCount;

	public new bool isShadown = true;

	private int tick;

	private int frame;

	private bool wy;

	private int wt;

	private int fy;

	private int ty;

	public new int typeSuperEff;

	private T13 focus;

	private bool flyUp;

	private bool flyDown;

	private int dy;

	public bool changePos;

	private int tShock;

	public new bool isBusyAttackSomeOne = true;

	private int tA;

	private T13[] charAttack;

	private int[] dameHP;

	private sbyte type;

	public new int[] stand = new int[12]
	{
		0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
		1, 1
	};

	public int[] stand_1 = new int[17]
	{
		37, 37, 37, 38, 38, 38, 39, 39, 40, 40,
		40, 39, 39, 39, 38, 38, 38
	};

	public new int[] move = new int[15]
	{
		1, 1, 1, 1, 2, 2, 2, 2, 3, 3,
		3, 3, 2, 2, 2
	};

	public new int[] moveFast = new int[7] { 1, 1, 2, 2, 3, 3, 2 };

	public new int[] attack1 = new int[12]
	{
		0, 0, 34, 34, 35, 35, 36, 36, 2, 2,
		1, 1
	};

	public new int[] attack2 = new int[23]
	{
		0, 0, 0, 4, 4, 6, 6, 9, 9, 10,
		10, 13, 13, 15, 15, 17, 17, 19, 19, 21,
		21, 23, 23
	};

	public int[] attack3 = new int[24]
	{
		0, 0, 1, 1, 4, 4, 6, 6, 8, 8,
		25, 25, 26, 26, 28, 28, 30, 30, 32, 32,
		2, 2, 1, 1
	};

	public int[] attack2_1 = new int[20]
	{
		37, 37, 5, 5, 7, 7, 11, 11, 14, 14,
		16, 16, 18, 18, 20, 20, 22, 22, 24, 24
	};

	public int[] attack3_1 = new int[21]
	{
		37, 37, 37, 38, 38, 5, 5, 7, 7, 11,
		11, 27, 27, 29, 29, 31, 31, 33, 33, 38,
		38
	};

	public int[] fly = new int[8] { 8, 8, 9, 9, 10, 10, 12, 12 };

	public int[] hitground = new int[24]
	{
		0, 0, 1, 1, 4, 4, 6, 6, 8, 8,
		25, 25, 26, 26, 28, 28, 30, 30, 32, 32,
		2, 2, 1, 1
	};

	private bool shock;

	private sbyte[] cou = new sbyte[2] { -1, 1 };

	public new T13 injureBy;

	public new bool injureThenDie;

	public new T101 mobToAttack;

	public new int forceWait;

	public new bool blindEff;

	public new bool sleepEff;

	public T202(int id, short px, short py, int templateID, int hp, int maxhp, int s)
	{
		xFirst = (x = px + 20);
		yFirst = (y = py);
		mobId = id;
		base.hp = hp;
		maxHp = maxhp;
		templateId = templateID;
		if (s == 0)
		{
			M2243();
		}
		if (s == 1)
		{
			M2242();
		}
		if (s == 2)
		{
			M2242();
			haftBody = true;
		}
		status = 2;
	}

	public void M2242()
	{
		data = null;
		data = new T36();
		string patch = "/x" + T99.zoomLevel + "/effectdata/" + 100 + "/data";
		try
		{
			data.M396(patch);
			data.img = T51.M503("/effectdata/" + 100 + "/img.png");
		}
		catch (Exception)
		{
			T146.M1594().M1644(templateId);
		}
		status = 2;
		w = data.width;
		h = data.height;
	}

	public void M2243()
	{
		data = null;
		data = new T36();
		string patch = "/x" + T99.zoomLevel + "/effectdata/" + 101 + "/data";
		try
		{
			data.M396(patch);
			data.img = T51.M503("/effectdata/" + 101 + "/img.png");
			T137.M1513("read xong data");
		}
		catch (Exception)
		{
			T146.M1594().M1644(templateId);
		}
		w = data.width;
		h = data.height;
	}

	public void M2244(short id)
	{
		changBody = true;
		smallBody = id;
	}

	public void M2245()
	{
		changBody = false;
	}

	public static bool M2246(string id)
	{
		for (int i = 0; i < T101.newMob.M1113(); i++)
		{
			if (((string)T101.newMob.M1114(i)).Equals(id))
			{
				return true;
			}
		}
		return false;
	}

	public void M2247(int[] array)
	{
		tick++;
		if (tick > array.Length - 1)
		{
			tick = 0;
		}
		frame = array[tick];
	}

	private void M2248()
	{
		int size = T174.size;
		xSd = x;
		wCount = 0;
		if (ySd <= 0 || T174.M1958(xSd, ySd, 2))
		{
			return;
		}
		if (T174.M1956(xSd / size, ySd / size) == 0)
		{
			isOutMap = true;
		}
		else if (T174.M1956(xSd / size, ySd / size) != 0 && !T174.M1958(xSd, ySd, 2))
		{
			xSd = x;
			ySd = y;
			isOutMap = false;
		}
		while (isOutMap && wCount < 10)
		{
			wCount++;
			ySd += 24;
			if (T174.M1958(xSd, ySd, 2))
			{
				if (ySd % 24 != 0)
				{
					ySd -= ySd % 24;
				}
				break;
			}
		}
	}

	private void M2249(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M948(shadowBig, xSd, yFirst, 3);
		g.M922(T54.cmx, T54.cmy - T51.transY, T54.gW, T54.gH + 2 * T51.transY);
	}

	public void M2250()
	{
	}

	public override void update()
	{
		if (!M2263())
		{
			return;
		}
		M2248();
		switch (status)
		{
		case 0:
		case 1:
			M2251();
			break;
		case 2:
			M2257();
			break;
		case 3:
			M2260();
			break;
		case 4:
			timeStatus = 0;
			M2252();
			break;
		case 5:
			timeStatus = 0;
			M2261();
			break;
		case 6:
			timeStatus = 0;
			p1++;
			y += p1;
			if (y >= yFirst)
			{
				y = yFirst;
				p1 = 0;
				status = 5;
			}
			break;
		case 7:
			M2256();
			break;
		}
	}

	private void M2251()
	{
		M2247((!haftBody) ? stand : stand_1);
		if (T51.gameTick % 5 == 0)
		{
			T143.M1571(167, T137.M1522(x - getW() / 2, x + getW() / 2), T137.M1522(getY() + getH() / 2, getY() + getH()), 1);
		}
		if (x != xFirst || y != yFirst)
		{
			x += (xFirst - x) / 4;
			y += (yFirst - y) / 4;
		}
	}

	private void M2252()
	{
		if (flyUp)
		{
			dy++;
			y -= dy;
			M2247(fly);
			if (y <= -500)
			{
				flyUp = false;
				flyDown = true;
				dy = 0;
			}
		}
		if (flyDown)
		{
			x = xTo;
			dy += 2;
			y += dy;
			M2247(hitground);
			if (y > yFirst)
			{
				y = yFirst;
				flyDown = false;
				dy = 0;
				status = 2;
				T54.shock_scr = 10;
				shock = true;
			}
		}
	}

	public void M2253()
	{
	}

	public void M2254(T13 cFocus)
	{
		isBusyAttackSomeOne = true;
		mobToAttack = null;
		base.cFocus = cFocus;
		p1 = 0;
		p2 = 0;
		status = 3;
		tick = 0;
		dir = ((cFocus.cx > x) ? 1 : (-1));
		int cx = cFocus.cx;
		int cy = cFocus.cy;
		if (T137.M1529(cx - x) < w * 2 && T137.M1529(cy - y) < h * 2)
		{
			if (x < cx)
			{
				x = cx - w;
			}
			else
			{
				x = cx + w;
			}
			p3 = 0;
		}
		else
		{
			p3 = 1;
		}
	}

	private bool M2255()
	{
		if ((templateId < 58 || templateId > 65) && templateId != 67 && templateId != 68)
		{
			return false;
		}
		return true;
	}

	private void M2256()
	{
	}

	private void M2257()
	{
		M2247((!haftBody) ? stand : stand_1);
		if (x != xFirst || y != yFirst)
		{
			x += (xFirst - x) / 4;
			y += (yFirst - y) / 4;
		}
	}

	public void M2258()
	{
		status = 4;
		flyUp = true;
	}

	public void M2259(T13[] cAttack, int[] dame, sbyte type)
	{
		charAttack = cAttack;
		dameHP = dame;
		this.type = type;
		tick = 0;
		if (type < 3)
		{
			status = 3;
		}
		if (type == 3)
		{
			flyUp = true;
			status = 4;
		}
		if (type == 4)
		{
			for (int i = 0; i < charAttack.Length; i++)
			{
				charAttack[i].M218(dameHP[i], 0, isCrit: false, isMob: false);
			}
		}
		if (type == 7)
		{
			status = 3;
		}
	}

	public void M2260()
	{
		if (type == 7)
		{
			if (tick > 8)
			{
				tick = 8;
			}
			M2247(attack1);
			if (T51.gameTick % 4 == 0)
			{
				T143.M1571(70, x + ((dir != 1) ? (-15) : 15), y - 40, 1);
			}
		}
		if (type == 0)
		{
			if (tick == attack1.Length - 1)
			{
				status = 2;
			}
			dir = ((x < charAttack[0].cx) ? 1 : (-1));
			M2247(attack1);
			if (tick == 8)
			{
				for (int i = 0; i < charAttack.Length; i++)
				{
					T105.M1017(x + ((dir != 1) ? (-45) : 45), y - 30, isBoss: true, dameHP[i], 0, charAttack[i], 24);
				}
			}
		}
		if (type == 1)
		{
			if (tick == ((!haftBody) ? (attack2.Length - 1) : (attack2_1.Length - 1)))
			{
				status = 2;
			}
			dir = ((x < charAttack[0].cx) ? 1 : (-1));
			M2247((!haftBody) ? attack2 : attack2_1);
			x += (charAttack[0].cx - x) / 4;
			y += (charAttack[0].cy - y) / 4;
			if (tick == 18)
			{
				for (int j = 0; j < charAttack.Length; j++)
				{
					charAttack[j].M218(dameHP[j], 0, isCrit: false, isMob: false);
					T143.M1571(102, charAttack[j].cx, charAttack[j].cy, 1);
				}
			}
		}
		if (type != 2)
		{
			return;
		}
		if (tick == ((!haftBody) ? (attack3.Length - 1) : (attack3_1.Length - 1)))
		{
			status = 2;
		}
		dir = ((x < charAttack[0].cx) ? 1 : (-1));
		M2247((!haftBody) ? attack3 : attack3_1);
		if (tick == 13)
		{
			T54.shock_scr = 10;
			shock = true;
			for (int k = 0; k < charAttack.Length; k++)
			{
				charAttack[k].M218(dameHP[k], 0, isCrit: false, isMob: false);
			}
		}
	}

	public void M2261()
	{
	}

	public bool M2262()
	{
		if (x < T54.cmx)
		{
			return false;
		}
		if (x > T54.cmx + T54.gW)
		{
			return false;
		}
		if (y < T54.cmy)
		{
			return false;
		}
		if (y > T54.cmy + T54.gH + 30)
		{
			return false;
		}
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public bool M2263()
	{
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public bool M2264()
	{
		if (!isBoss && levelBoss <= 0)
		{
			return false;
		}
		return true;
	}

	public override void paint(T99 g)
	{
		if (data == null)
		{
			return;
		}
		if (isShadown && status != 0)
		{
			M2249(g);
		}
		g.M918(0, T51.transY);
		data.M401(g, frame, x, y + fy, (dir != 1) ? 1 : 0, 2);
		g.M918(0, -T51.transY);
		int num = (int)(hp * 50L / maxHp);
		if (num != 0)
		{
			g.M933(0);
			g.M932(x - 27, y - 112, 54, 8);
			g.M933(16711680);
			g.M922(x - 25, y - 110, num, 4);
			g.M932(x - 25, y - 110, 50, 4);
			g.M922(0, 0, 3000, 3000);
		}
		if (shock)
		{
			T137.M1513("type= " + type);
			tShock++;
			T31.M376(new T32((type != 2) ? 22 : 19, x + tShock * 50, y + 25, 2, 1, -1));
			T31.M376(new T32((type != 2) ? 22 : 19, x - tShock * 50, y + 25, 2, 1, -1));
			if (tShock == 50)
			{
				tShock = 0;
				shock = false;
			}
		}
	}

	public int M2265()
	{
		return 16711680;
	}

	public void M2266()
	{
		hp = 0;
		injureThenDie = true;
		hp = 0;
		status = 1;
		p1 = -3;
		p2 = -dir;
		p3 = 0;
	}

	public void M2267(T101 mobToAttack)
	{
		this.mobToAttack = mobToAttack;
		isBusyAttackSomeOne = true;
		cFocus = null;
		p1 = 0;
		p2 = 0;
		status = 3;
		tick = 0;
		dir = ((mobToAttack.x > x) ? 1 : (-1));
		int num = mobToAttack.x;
		int num2 = mobToAttack.y;
		if (T137.M1529(num - x) < w * 2 && T137.M1529(num2 - y) < h * 2)
		{
			if (x < num)
			{
				x = num - w;
			}
			else
			{
				x = num + w;
			}
			p3 = 0;
		}
		else
		{
			p3 = 1;
		}
	}

	public new int getX()
	{
		return x;
	}

	public new int getY()
	{
		if (haftBody)
		{
			return y - 20;
		}
		return y - 60;
	}

	public new int getH()
	{
		return 40;
	}

	public new int getW()
	{
		return 60;
	}

	public new void stopMoving()
	{
		if (status == 5)
		{
			status = 2;
			p3 = 0;
			p2 = 0;
			p1 = 0;
			forceWait = 50;
		}
	}

	public new bool isInvisible()
	{
		if (status != 0)
		{
			return status == 1;
		}
		return true;
	}

	public void M2268()
	{
		if (holdEffID != 0)
		{
			holdEffID = 0;
		}
	}

	public void M2269()
	{
		blindEff = false;
	}

	public void M2270()
	{
		sleepEff = false;
	}
}
