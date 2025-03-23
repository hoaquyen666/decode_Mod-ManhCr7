using System;

public class T12 : T101, T62
{
	public static T60 shadowBig;

	public static T36 data;

	public int xTo;

	public int yTo;

	public bool haftBody;

	public bool change;

	private T101 mob1;

	public new int xSd;

	public new int ySd;

	private bool isOutMap;

	private int wCount;

	public new bool isShadown = true;

	private int tick;

	private int frame;

	public new static T60 imgHP = T51.M503("/mainImage/myTexture2dmobHP.png");

	private bool wy;

	private int wt;

	private int fy;

	private int ty;

	public new int typeSuperEff;

	private T13 focus;

	private int timeDead;

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
		0, 0, 0, 0, 0, 0, 1, 1, 1, 1,
		1, 1
	};

	public new int[] move = new int[15]
	{
		1, 1, 1, 1, 2, 2, 2, 2, 3, 3,
		3, 3, 2, 2, 2
	};

	public new int[] moveFast = new int[7] { 1, 1, 2, 2, 3, 3, 2 };

	public new int[] attack1 = new int[12]
	{
		0, 0, 0, 7, 7, 7, 8, 8, 8, 9,
		9, 9
	};

	public new int[] attack2 = new int[12]
	{
		0, 0, 0, 10, 10, 10, 11, 11, 11, 12,
		12, 12
	};

	public int[] attack3 = new int[24]
	{
		0, 0, 1, 1, 4, 4, 6, 6, 8, 8,
		25, 25, 26, 26, 28, 28, 30, 30, 32, 32,
		2, 2, 1, 1
	};

	public int[] fly = new int[21]
	{
		4, 4, 4, 5, 5, 5, 6, 6, 6, 6,
		6, 6, 3, 3, 3, 2, 2, 2, 1, 1,
		1
	};

	public int[] hitground = new int[12]
	{
		6, 6, 6, 3, 3, 3, 2, 2, 2, 1,
		1, 1
	};

	private bool shock;

	private sbyte[] cou = new sbyte[2] { -1, 1 };

	public new T13 injureBy;

	public new bool injureThenDie;

	public new T101 mobToAttack;

	public new int forceWait;

	public new bool blindEff;

	public new bool sleepEff;

	public T12(int id, short px, short py, int templateID, int hp, int maxHp, int s)
	{
		if (shadowBig == null)
		{
			shadowBig = T51.M503("/mainImage/shadowBig.png");
		}
		mobId = id;
		xTo = (x = px + 20);
		yTo = (y = py);
		yFirst = py;
		base.hp = hp;
		base.maxHp = maxHp;
		templateId = templateID;
		M75();
		status = 2;
	}

	public void M75()
	{
		data = null;
		data = new T36();
		string patch = "/x" + T99.zoomLevel + "/effectdata/" + 109 + "/data";
		try
		{
			data.M396(patch);
			data.img = T51.M503("/effectdata/" + 109 + "/img.png");
		}
		catch (Exception)
		{
			T146.M1594().M1644(templateId);
		}
		w = data.width;
		h = data.height;
	}

	public void M76(short id)
	{
		changBody = true;
		smallBody = id;
	}

	public void M77()
	{
		changBody = false;
	}

	public static bool M78(string id)
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

	public void M79(int[] array)
	{
		tick++;
		if (tick > array.Length - 1)
		{
			tick = 0;
		}
		frame = array[tick];
	}

	private void M80()
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

	private void M81(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M948(shadowBig, xSd, yFirst, 3);
		g.M922(T54.cmx, T54.cmy - T51.transY, T54.gW, T54.gH + 2 * T51.transY);
	}

	public void M82()
	{
	}

	public override void update()
	{
		if (!M95())
		{
			return;
		}
		M80();
		switch (status)
		{
		case 0:
		case 1:
			M83();
			break;
		case 2:
			M89();
			break;
		case 3:
			M92();
			break;
		case 4:
			timeStatus = 0;
			M84();
			break;
		case 5:
			timeStatus = 0;
			M93();
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
			M88();
			break;
		}
	}

	private void M83()
	{
		M79(stand);
		if (T51.gameTick % 5 == 0)
		{
			T143.M1571(167, T137.M1522(x - getW() / 2, x + getW() / 2), T137.M1522(getY() + getH() / 2, getY() + getH()), 1);
		}
		if (x != xTo || y != yTo)
		{
			x += (xTo - x) / 4;
			y += (yTo - y) / 4;
		}
	}

	private void M84()
	{
		if (flyUp)
		{
			dy++;
			y -= dy;
			M79(fly);
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
			M79(hitground);
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

	public void M85()
	{
	}

	public void M86(T13 cFocus)
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

	private bool M87()
	{
		if ((templateId < 58 || templateId > 65) && templateId != 67 && templateId != 68)
		{
			return false;
		}
		return true;
	}

	private void M88()
	{
	}

	private void M89()
	{
		M79(stand);
		if (x != xTo || y != yTo)
		{
			x += (xTo - x) / 4;
			y += (yTo - y) / 4;
		}
	}

	public void M90()
	{
		status = 4;
		flyUp = true;
	}

	public void M91(T13[] cAttack, int[] dame, sbyte type)
	{
		status = 3;
		charAttack = cAttack;
		dameHP = dame;
		this.type = type;
		tick = 0;
	}

	public void M92()
	{
		if (type == 0)
		{
			if (tick == attack1.Length - 1)
			{
				status = 2;
			}
			dir = ((x < charAttack[0].cx) ? 1 : (-1));
			M79(attack1);
			x += (charAttack[0].cx - x) / 4;
			y += (charAttack[0].cy - y) / 4;
			xTo = x;
			if (tick == 8)
			{
				for (int i = 0; i < charAttack.Length; i++)
				{
					charAttack[i].M218(dameHP[i], 0, isCrit: false, isMob: false);
					T143.M1571(102, charAttack[i].cx, charAttack[i].cy, 1);
				}
			}
		}
		if (type == 1)
		{
			if (tick == attack2.Length - 1)
			{
				status = 2;
			}
			dir = ((x < charAttack[0].cx) ? 1 : (-1));
			M79(attack2);
			if (tick == 8)
			{
				for (int j = 0; j < charAttack.Length; j++)
				{
					T105.M1017(x + ((dir != 1) ? (-45) : 45), y - 25, isBoss: true, dameHP[j], 0, charAttack[j], 24);
				}
			}
		}
		if (type != 2)
		{
			return;
		}
		if (tick == fly.Length - 1)
		{
			status = 2;
		}
		dir = ((x < charAttack[0].cx) ? 1 : (-1));
		M79(fly);
		x += (charAttack[0].cx - x) / 4;
		xTo = x;
		yTo = y;
		if (tick == 12)
		{
			for (int k = 0; k < charAttack.Length; k++)
			{
				charAttack[k].M218(dameHP[k], 0, isCrit: false, isMob: false);
				T143.M1571(102, charAttack[k].cx, charAttack[k].cy, 1);
			}
		}
	}

	public void M93()
	{
	}

	public bool M94()
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

	public bool M95()
	{
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public bool M96()
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
			M81(g);
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

	public int M97()
	{
		return 16711680;
	}

	public void M98()
	{
		hp = 0;
		injureThenDie = true;
		hp = 0;
		status = 1;
		p1 = -3;
		p2 = -dir;
		p3 = 0;
	}

	public void M99(T101 mobToAttack)
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
		return y - 50;
	}

	public new int getH()
	{
		return 40;
	}

	public new int getW()
	{
		return 50;
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

	public void M100()
	{
		if (holdEffID != 0)
		{
			holdEffID = 0;
		}
	}

	public void M101()
	{
		blindEff = false;
	}

	public void M102()
	{
		sleepEff = false;
	}
}
