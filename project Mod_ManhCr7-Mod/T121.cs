public class T121 : T101, T62
{
	public static T60 shadowBig = T110.M1071("/mainImage/shadowBig.png");

	public int xTo;

	public int yTo;

	public bool haftBody;

	public bool change;

	public new int xSd;

	public new int ySd;

	private int wCount;

	public new bool isShadown = true;

	private int tick;

	private int frame;

	public new static T60 imgHP = T110.M1071("/mainImage/myTexture2dmobHP.png");

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

	private int ff;

	private sbyte[] cou = new sbyte[2] { -1, 1 };

	public new T13 injureBy;

	public new bool injureThenDie;

	public new T101 mobToAttack;

	public new int forceWait;

	public new bool blindEff;

	public new bool sleepEff;

	private int[][] frameArr = new int[17][]
	{
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 }
	};

	public new const sbyte stand = 0;

	public const sbyte moveFra = 1;

	public new const sbyte attack1 = 2;

	public new const sbyte attack2 = 3;

	public const sbyte attack3 = 4;

	public const sbyte attack4 = 5;

	public const sbyte attack5 = 6;

	public const sbyte attack6 = 7;

	public const sbyte attack7 = 8;

	public const sbyte attack8 = 9;

	public const sbyte attack9 = 10;

	public const sbyte attack10 = 11;

	public new const sbyte hurt = 12;

	public const sbyte die = 13;

	public const sbyte fly = 14;

	public const sbyte adddame = 15;

	public const sbyte typeEff = 16;

	public T121(int id, short px, short py, int templateID, int hp, int maxHp, int s)
	{
		mobId = id;
		x = (xFirst = px + 20);
		y = (yFirst = py);
		xTo = x;
		yTo = y;
		base.maxHp = maxHp;
		base.hp = hp;
		templateId = templateID;
		if (T101.arrMobTemplate[templateId].data == null)
		{
			T146.M1594().M1644(templateId);
		}
		status = 2;
		frameArr = null;
	}

	public void M1155(short id)
	{
		changBody = true;
		smallBody = id;
	}

	public void M1156()
	{
		changBody = false;
	}

	public static bool M1157(string id)
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

	public void M1158(int[] array)
	{
		tick++;
		if (tick > array.Length - 1)
		{
			tick = 0;
		}
		frame = array[tick];
	}

	public void M1159()
	{
		int num = 0;
		xSd = x;
		if (T174.M1958(x, y, 2))
		{
			ySd = y;
			return;
		}
		ySd = y;
		while (num < 30)
		{
			num++;
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

	private void M1160(T99 g)
	{
		int size = T174.size;
		if ((T174.mapID < 114 || T174.mapID > 120) && T174.mapID != 127 && T174.mapID != 128)
		{
			if (T174.M1958(xSd + size / 2, ySd + 1, 4))
			{
				g.M922(xSd / size * size, (ySd - 30) / size * size, size, 100);
			}
			else if (T174.M1956((xSd - size / 2) / size, (ySd + 1) / size) == 0)
			{
				g.M922(xSd / size * size, (ySd - 30) / size * size, 100, 100);
			}
			else if (T174.M1956((xSd + size / 2) / size, (ySd + 1) / size) == 0)
			{
				g.M922(xSd / size * size, (ySd - 30) / size * size, size, 100);
			}
			else if (T174.M1958(xSd - size / 2, ySd + 1, 8))
			{
				g.M922(xSd / 24 * size, (ySd - 30) / size * size, size, 100);
			}
		}
		g.M948(shadowBig, xSd, ySd - 5, 3);
		g.M922(T54.cmx, T54.cmy - T51.transY, T54.gW, T54.gH + 2 * T51.transY);
	}

	public void M1161()
	{
	}

	public override void update()
	{
		if (frameArr == null && T101.arrMobTemplate[templateId].data != null)
		{
			M1180();
		}
		if (frameArr == null || !M1172())
		{
			return;
		}
		M1159();
		switch (status)
		{
		case 0:
		case 1:
			M1162();
			break;
		case 2:
			M1166();
			break;
		case 3:
			M1169();
			break;
		case 4:
			M1163();
			break;
		case 5:
			timeStatus = 0;
			M1170();
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
			M1165();
			break;
		}
	}

	private void M1162()
	{
		tick++;
		if (tick > frameArr[13].Length - 1)
		{
			tick = frameArr[13].Length - 1;
		}
		frame = frameArr[13][tick];
		if (x != xTo || y != yTo)
		{
			x += (xTo - x) / 4;
			y += (yTo - y) / 4;
		}
	}

	private void M1163()
	{
	}

	public void M1164(T13 cFocus)
	{
		isBusyAttackSomeOne = true;
		mobToAttack = null;
		base.cFocus = cFocus;
		p1 = 0;
		p2 = 0;
		status = 3;
		tick = 0;
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

	private void M1165()
	{
	}

	private void M1166()
	{
		M1158(frameArr[0]);
		if (x != xTo || y != yTo)
		{
			x += (xTo - x) / 4;
			y += (yTo - y) / 4;
		}
	}

	public void M1167()
	{
		status = 4;
		flyUp = true;
	}

	public void M1168(T13[] cAttack, int[] dame, sbyte type, sbyte dir)
	{
		charAttack = cAttack;
		dameHP = dame;
		this.type = type;
		base.dir = dir;
		status = 3;
		if (x != xTo || y != yTo)
		{
			x += (xTo - x) / 4;
			y += (yTo - y) / 4;
		}
	}

	public void M1169()
	{
		if (tick == frameArr[type + 1].Length - 1)
		{
			status = 2;
		}
		M1158(frameArr[type + 1]);
		if (tick == frameArr[15][type - 1])
		{
			for (int i = 0; i < charAttack.Length; i++)
			{
				charAttack[i].M218(dameHP[i], 0, isCrit: false, isMob: false);
				T143.M1571(frameArr[16][type - 1], charAttack[i].cx, charAttack[i].cy, 1);
			}
		}
	}

	public void M1170()
	{
		M1158(frameArr[1]);
		sbyte speed = T101.arrMobTemplate[templateId].speed;
		int num = speed;
		if (T137.M1529(x - xTo) < speed)
		{
			num = T137.M1529(x - xTo);
		}
		x += ((x >= xTo) ? (-num) : num);
		y = yTo;
		if (x < xTo)
		{
			dir = 1;
		}
		else if (x > xTo)
		{
			dir = -1;
		}
		if (T137.M1529(x - xTo) <= 1)
		{
			x = xTo;
			status = 2;
		}
	}

	public bool M1171()
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

	public bool M1172()
	{
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public override void paint(T99 g)
	{
		if (T101.arrMobTemplate[templateId].data != null)
		{
			if (isShadown)
			{
				M1160(g);
			}
			g.M918(0, T51.transY);
			T101.arrMobTemplate[templateId].data.M401(g, frame, x, y + fy, (dir != 1) ? 1 : 0, 2);
			g.M918(0, -T51.transY);
			int num = (int)(hp * 50L / maxHp);
			if (num != 0)
			{
				int num2 = y - h - 5;
				g.M933(0);
				g.M932(x - 27, num2 - 2, 54, 8);
				g.M933(16711680);
				g.M932(x - 25, num2, num, 4);
			}
		}
	}

	public int M1173()
	{
		return 16711680;
	}

	public void M1174()
	{
		hp = 0;
		injureThenDie = true;
		hp = 0;
		status = 1;
		p1 = -3;
		p2 = -dir;
		p3 = 0;
	}

	public void M1175(T101 mobToAttack)
	{
		this.mobToAttack = mobToAttack;
		isBusyAttackSomeOne = true;
		cFocus = null;
		p1 = 0;
		p2 = 0;
		status = 3;
		tick = 0;
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
		return y;
	}

	public new int getH()
	{
		return h;
	}

	public new int getW()
	{
		return w;
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

	public void M1176()
	{
		if (holdEffID != 0)
		{
			holdEffID = 0;
		}
	}

	public void M1177()
	{
		blindEff = false;
	}

	public void M1178()
	{
		sleepEff = false;
	}

	public void M1179(short xMoveTo, short yMoveTo)
	{
		if (yMoveTo != -1)
		{
			if (T137.M1526(x, y, xTo, yTo) > 100)
			{
				x = xMoveTo;
				y = yMoveTo;
				status = 2;
			}
			else
			{
				xTo = xMoveTo;
				yTo = yMoveTo;
				status = 5;
			}
		}
		else
		{
			xTo = xMoveTo;
			status = 5;
		}
	}

	public void M1180()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		frameArr = (int[][])T23.frameHT_NEWBOSS.M1074(templateId + string.Empty);
		w = T101.arrMobTemplate[templateId].data.width;
		h = T101.arrMobTemplate[templateId].data.height;
	}

	public void M1181()
	{
		status = 0;
	}
}
