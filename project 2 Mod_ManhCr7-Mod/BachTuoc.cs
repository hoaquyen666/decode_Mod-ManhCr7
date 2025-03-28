using System;

public class BachTuoc : Mob, IMapObject
{
	public static Image shadowBig = GameCanvas.M503("/mainImage/shadowBig.png");

	public static EffectData data;

	public int xTo;

	public int yTo;

	public bool haftBody;

	public bool change;

	private Mob mob1;

	public new int xSd;

	public new int ySd;

	private bool isOutMap;

	private int wCount;

	public new bool isShadown = true;

	private int tick;

	private int frame;

	public new static Image imgHP = GameCanvas.M503("/mainImage/myTexture2dmobHP.png");

	private bool wy;

	private int wt;

	private int fy;

	private int ty;

	public new int typeSuperEff;

	private Char focus;

	private bool flyUp;

	private bool flyDown;

	private int dy;

	public bool changePos;

	private int tShock;

	public new bool isBusyAttackSomeOne = true;

	private int tA;

	private Char[] charAttack;

	private int[] dameHP;

	private sbyte type;

	public new int[] stand = new int[12]
	{
		0, 0, 0, 0, 0, 0, 1, 1, 1, 1,
		1, 1
	};

	public int[] movee = new int[12]
	{
		0, 0, 0, 2, 2, 2, 3, 3, 3, 4,
		4, 4
	};

	public new int[] attack1 = new int[12]
	{
		0, 0, 0, 4, 4, 4, 5, 5, 5, 6,
		6, 6
	};

	public new int[] attack2 = new int[17]
	{
		0, 0, 0, 7, 7, 7, 8, 8, 8, 9,
		9, 9, 10, 10, 10, 11, 11
	};

	public new int[] hurt = new int[4] { 1, 1, 7, 7 };

	private bool shock;

	private sbyte[] cou = new sbyte[2] { -1, 1 };

	public new Char injureBy;

	public new bool injureThenDie;

	public new Mob mobToAttack;

	public new int forceWait;

	public new bool blindEff;

	public new bool sleepEff;

	public BachTuoc(int id, short px, short py, int templateID, int hp, int maxHp, int s)
	{
		mobId = id;
		xFirst = (x = px + 20);
		yFirst = (y = py);
		xTo = x;
		yTo = y;
		base.maxHp = maxHp;
		base.hp = hp;
		templateId = templateID;
		M11();
		status = 2;
	}

	public void M11()
	{
		data = null;
		data = new EffectData();
		string patch = "/x" + mGraphics.zoomLevel + "/effectdata/" + 108 + "/data";
		try
		{
			data.M396(patch);
			data.img = GameCanvas.M503("/effectdata/" + 108 + "/img.png");
		}
		catch (Exception)
		{
			Service.M1594().M1644(templateId);
		}
		w = data.width;
		h = data.height;
	}

	public void M12(short id)
	{
		changBody = true;
		smallBody = id;
	}

	public void M13()
	{
		changBody = false;
	}

	public static bool M14(string id)
	{
		for (int i = 0; i < Mob.newMob.M1113(); i++)
		{
			if (((string)Mob.newMob.M1114(i)).Equals(id))
			{
				return true;
			}
		}
		return false;
	}

	public void M15(int[] array)
	{
		tick++;
		if (tick > array.Length - 1)
		{
			tick = 0;
		}
		frame = array[tick];
	}

	private void M16()
	{
		int size = TileMap.size;
		xSd = x;
		wCount = 0;
		if (ySd <= 0 || TileMap.M1958(xSd, ySd, 2))
		{
			return;
		}
		if (TileMap.M1956(xSd / size, ySd / size) == 0)
		{
			isOutMap = true;
		}
		else if (TileMap.M1956(xSd / size, ySd / size) != 0 && !TileMap.M1958(xSd, ySd, 2))
		{
			xSd = x;
			ySd = y;
			isOutMap = false;
		}
		while (isOutMap && wCount < 10)
		{
			wCount++;
			ySd += 24;
			if (TileMap.M1958(xSd, ySd, 2))
			{
				if (ySd % 24 != 0)
				{
					ySd -= ySd % 24;
				}
				break;
			}
		}
	}

	private void M17(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M948(shadowBig, xSd, yFirst, 3);
		g.M922(GameScr.cmx, GameScr.cmy - GameCanvas.transY, GameScr.gW, GameScr.gH + 2 * GameCanvas.transY);
	}

	public void M18()
	{
	}

	public override void update()
	{
		if (!M30())
		{
			return;
		}
		M16();
		switch (status)
		{
		case 0:
		case 1:
			M19();
			break;
		case 2:
			M24();
			break;
		case 3:
			M27();
			break;
		case 5:
			timeStatus = 0;
			M28();
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
			M23();
			break;
		case 4:
			break;
		}
	}

	private void M19()
	{
		M15(stand);
		if (GameCanvas.gameTick % 5 == 0)
		{
			ServerEffect.M1571(167, Res.M1522(x - getW() / 2, x + getW() / 2), Res.M1522(getY() + getH() / 2, getY() + getH()), 1);
		}
		if (x != xTo || y != yTo)
		{
			x += (xTo - x) / 4;
			y += (yTo - y) / 4;
		}
	}

	public void M20()
	{
	}

	public void M21(Char cFocus)
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
		if (Res.M1529(cx - x) < w * 2 && Res.M1529(cy - y) < h * 2)
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

	private bool M22()
	{
		if ((templateId < 58 || templateId > 65) && templateId != 67 && templateId != 68)
		{
			return false;
		}
		return true;
	}

	private void M23()
	{
	}

	private void M24()
	{
		M15(stand);
		if (x != xTo || y != yTo)
		{
			x += (xTo - x) / 4;
			y += (yTo - y) / 4;
		}
	}

	public void M25()
	{
		status = 4;
		flyUp = true;
	}

	public void M26(Char[] cAttack, int[] dame, sbyte type)
	{
		charAttack = cAttack;
		dameHP = dame;
		this.type = type;
		status = 3;
	}

	public void M27()
	{
		if (type == 3)
		{
			if (tick == attack1.Length - 1)
			{
				status = 2;
			}
			dir = ((x < charAttack[0].cx) ? 1 : (-1));
			M15(attack1);
			x += (charAttack[0].cx - x) / 4;
			y += (charAttack[0].cy - y) / 4;
			xTo = x;
			if (tick == 8)
			{
				for (int i = 0; i < charAttack.Length; i++)
				{
					charAttack[i].M218(dameHP[i], 0, isCrit: false, isMob: false);
					ServerEffect.M1571(102, charAttack[i].cx, charAttack[i].cy, 1);
				}
			}
		}
		if (type != 4)
		{
			return;
		}
		if (tick == attack2.Length - 1)
		{
			status = 2;
		}
		dir = ((x < charAttack[0].cx) ? 1 : (-1));
		M15(attack2);
		if (tick == 8)
		{
			for (int j = 0; j < charAttack.Length; j++)
			{
				charAttack[j].M218(dameHP[j], 0, isCrit: false, isMob: false);
				ServerEffect.M1571(102, charAttack[j].cx, charAttack[j].cy, 1);
			}
		}
	}

	public void M28()
	{
		M15(movee);
		x += ((x >= xTo) ? (-2) : 2);
		y = yTo;
		dir = ((x < xTo) ? 1 : (-1));
		if (Res.M1529(x - xTo) <= 1)
		{
			x = xTo;
			status = 2;
		}
	}

	public bool M29()
	{
		if (x < GameScr.cmx)
		{
			return false;
		}
		if (x > GameScr.cmx + GameScr.gW)
		{
			return false;
		}
		if (y < GameScr.cmy)
		{
			return false;
		}
		if (y > GameScr.cmy + GameScr.gH + 30)
		{
			return false;
		}
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public bool M30()
	{
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public bool M31()
	{
		if (!isBoss && levelBoss <= 0)
		{
			return false;
		}
		return true;
	}

	public override void paint(mGraphics g)
	{
		if (data == null)
		{
			return;
		}
		if (isShadown && status != 0)
		{
			M17(g);
		}
		g.M918(0, GameCanvas.transY);
		data.M401(g, frame, x, y + fy, (dir != 1) ? 1 : 0, 2);
		g.M918(0, -GameCanvas.transY);
		int num = (int)(hp * 50L / maxHp);
		if (num != 0)
		{
			g.M933(0);
			g.M932(x - 27, y - 82, 54, 8);
			g.M933(16711680);
			g.M922(x - 25, y - 80, num, 4);
			g.M932(x - 25, y - 80, 50, 4);
			g.M922(0, 0, 3000, 3000);
		}
		if (shock)
		{
			tShock++;
			EffectMn.M376(new Effect((type != 2) ? 22 : 19, x + tShock * 50, y + 25, 2, 1, -1));
			EffectMn.M376(new Effect((type != 2) ? 22 : 19, x - tShock * 50, y + 25, 2, 1, -1));
			if (tShock == 50)
			{
				tShock = 0;
				shock = false;
			}
		}
	}

	public int M32()
	{
		return 16711680;
	}

	public void M33()
	{
		hp = 0;
		injureThenDie = true;
		hp = 0;
		status = 1;
		p1 = -3;
		p2 = -dir;
		p3 = 0;
	}

	public void M34(Mob mobToAttack)
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
		if (Res.M1529(num - x) < w * 2 && Res.M1529(num2 - y) < h * 2)
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
		return y - 40;
	}

	public new int getH()
	{
		return 40;
	}

	public new int getW()
	{
		return 40;
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

	public void M35()
	{
		if (holdEffID != 0)
		{
			holdEffID = 0;
		}
	}

	public void M36()
	{
		blindEff = false;
	}

	public void M37()
	{
		sleepEff = false;
	}

	public void M38(short xMoveTo)
	{
		xTo = xMoveTo;
		status = 5;
	}
}
