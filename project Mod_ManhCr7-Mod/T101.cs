using System;
using N5.N6.N7;

public class T101 : T62
{
	public const sbyte TYPE_DUNG = 0;

	public const sbyte TYPE_DI = 1;

	public const sbyte TYPE_NHAY = 2;

	public const sbyte TYPE_LET = 3;

	public const sbyte TYPE_BAY = 4;

	public const sbyte TYPE_BAY_DAU = 5;

	public static T103[] arrMobTemplate;

	public const sbyte MA_INHELL = 0;

	public const sbyte MA_DEADFLY = 1;

	public const sbyte MA_STANDWAIT = 2;

	public const sbyte MA_ATTACK = 3;

	public const sbyte MA_STANDFLY = 4;

	public const sbyte MA_WALK = 5;

	public const sbyte MA_FALL = 6;

	public const sbyte MA_INJURE = 7;

	public bool changBody;

	public short smallBody;

	public bool isHintFocus;

	public string flystring;

	public int flyx;

	public int flyy;

	public int flyIndex;

	public bool isFreez;

	public int seconds;

	public long last;

	public long cur;

	public int holdEffID;

	public int hp;

	public int maxHp;

	public int x;

	public int y;

	public int dir = 1;

	public int dirV = 1;

	public int status;

	public int p1;

	public int p2;

	public int p3;

	public int xFirst;

	public int yFirst;

	public int vy;

	public int exp;

	public int w;

	public int h;

	public int hpInjure;

	public int charIndex;

	public int timeStatus;

	public int mobId;

	public bool isx;

	public bool isy;

	public bool isDisable;

	public bool isDontMove;

	public bool isFire;

	public bool isIce;

	public bool isWind;

	public bool isDie;

	public T117 vMobMove = new T117();

	public bool isGo;

	public string mobName;

	public int templateId;

	public short pointx;

	public short pointy;

	public T13 cFocus;

	public int dame;

	public int dameMp;

	public int sys;

	public sbyte levelBoss;

	public sbyte level;

	public bool isBoss;

	public bool isMobMe;

	public static T117 lastMob;

	public static T117 newMob;

	public int xSd;

	public int ySd;

	private bool isOutMap;

	private int wCount;

	public bool isShadown = true;

	private int tick;

	private int frame;

	public static T60 imgHP;

	private bool wy;

	private int wt;

	private int fy;

	private int ty;

	public int typeSuperEff;

	public bool isBusyAttackSomeOne = true;

	public int[] stand = new int[12]
	{
		0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
		1, 1
	};

	public int[] move = new int[15]
	{
		1, 1, 1, 1, 2, 2, 2, 2, 3, 3,
		3, 3, 2, 2, 2
	};

	public int[] moveFast = new int[7] { 1, 1, 2, 2, 3, 3, 2 };

	public int[] attack1 = new int[3] { 4, 5, 6 };

	public int[] attack2 = new int[3] { 7, 8, 9 };

	public int[] hurt = new int[1];

	private sbyte[] cou = new sbyte[2] { -1, 1 };

	public T13 injureBy;

	public bool injureThenDie;

	public T101 mobToAttack;

	public int forceWait;

	public bool blindEff;

	public bool sleepEff;

	private int[][] frameArr = new int[6][]
	{
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 }
	};

	private bool isGetFr = true;

	public long cTimeDie;

	public T101()
	{
	}//Error decoding local variables: Signature type sequence must have at least one element.


	public T101(int mobId, bool isDisable, bool isDontMove, bool isFire, bool isIce, bool isWind, int templateId, int sys, int hp, sbyte level, int maxp, short pointx, short pointy, sbyte status, sbyte levelBoss)
	{
		this.isDisable = isDisable;
		this.isDontMove = isDontMove;
		this.isFire = isFire;
		this.isIce = isIce;
		this.isWind = isWind;
		this.sys = sys;
		this.mobId = mobId;
		this.templateId = templateId;
		this.hp = hp;
		this.level = level;
		xFirst = (x = (this.pointx = pointx));
		yFirst = (y = (this.pointy = pointy));
		this.status = status;
		if (templateId != 70)
		{
			M979();
			M975();
		}
		if (!M978(templateId + string.Empty))
		{
			newMob.M1111(templateId + string.Empty);
		}
		maxHp = maxp;
		this.levelBoss = levelBoss;
		isDie = false;
		xSd = pointx;
		ySd = pointy;
		if (M993())
		{
			stand = new int[17]
			{
				0, 0, 0, 0, 0, 1, 1, 1, 1, 1,
				2, 2, 2, 2, 2, 2, 2
			};
			move = new int[17]
			{
				0, 0, 0, 0, 0, 1, 1, 1, 1, 1,
				2, 2, 2, 2, 2, 2, 2
			};
			moveFast = new int[17]
			{
				0, 0, 0, 0, 0, 1, 1, 1, 1, 1,
				2, 2, 2, 2, 2, 2, 2
			};
			attack1 = new int[12]
			{
				3, 3, 3, 3, 4, 4, 4, 4, 5, 5,
				5, 5
			};
			attack2 = new int[12]
			{
				3, 3, 3, 3, 4, 4, 4, 4, 5, 5,
				5, 5
			};
		}
		else if (M992())
		{
			stand = new int[12]
			{
				0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
				1, 1
			};
			move = new int[16]
			{
				1, 1, 1, 1, 2, 2, 2, 2, 1, 1,
				1, 1, 3, 3, 3, 3
			};
			moveFast = new int[8] { 1, 1, 2, 2, 1, 1, 3, 3 };
			attack1 = new int[11]
			{
				4, 4, 4, 5, 5, 5, 6, 6, 6, 6,
				6
			};
			attack2 = new int[11]
			{
				7, 7, 7, 8, 8, 8, 9, 9, 9, 9,
				9
			};
		}
		else if (M991())
		{
			stand = new int[12]
			{
				0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
				1, 1
			};
			move = new int[16]
			{
				2, 2, 3, 3, 2, 2, 4, 4, 2, 2,
				3, 3, 2, 2, 4, 4
			};
			moveFast = new int[8] { 2, 2, 3, 3, 2, 2, 4, 4 };
			attack1 = new int[8] { 5, 6, 7, 8, 9, 10, 11, 12 };
			attack2 = new int[4] { 5, 12, 13, 14 };
		}
		else
		{
			stand = new int[12]
			{
				0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
				1, 1
			};
			move = new int[15]
			{
				1, 1, 1, 1, 2, 2, 2, 2, 3, 3,
				3, 3, 2, 2, 2
			};
			moveFast = new int[7] { 1, 1, 2, 2, 3, 3, 2 };
			attack1 = new int[3] { 4, 5, 6 };
			attack2 = new int[3] { 7, 8, 9 };
		}
	}

	static T101()
	{
		lastMob = new T117();
		newMob = new T117();
		imgHP = T51.M503("/mainImage/myTexture2dmobHP.png");
	}

	public bool M974()
	{
		if (!(this is T7) && !(this is T12) && !(this is T202))
		{
			return this is T121;
		}
		return true;
	}

	public void M975()
	{
		if (arrMobTemplate[templateId].data == null)
		{
			arrMobTemplate[templateId].data = new T36();
			string text = "/Mob/" + templateId;
			if (T116.M1110(text) != null)
			{
				arrMobTemplate[templateId].data.M395(text + "/data");
				arrMobTemplate[templateId].data.img = T51.M503(text + "/img.png");
			}
			else
			{
				T146.M1594().M1644(templateId);
			}
			lastMob.M1111(templateId + string.Empty);
		}
		else
		{
			w = arrMobTemplate[templateId].data.width;
			h = arrMobTemplate[templateId].data.height;
		}
	}

	public void M976(short id)
	{
		changBody = true;
		smallBody = id;
	}

	public void M977()
	{
		changBody = false;
	}

	public static bool M978(string id)
	{
		for (int i = 0; i < newMob.M1113(); i++)
		{
			if (((string)newMob.M1114(i)).Equals(id))
			{
				return true;
			}
		}
		return false;
	}

	public void M979()
	{
		int num = 0;
		for (int i = 0; i < arrMobTemplate.Length; i++)
		{
			if (arrMobTemplate[i].data != null)
			{
				num++;
			}
		}
		if (num < 10)
		{
			return;
		}
		for (int j = 0; j < arrMobTemplate.Length; j++)
		{
			if (arrMobTemplate[j].data != null && num > 5)
			{
				arrMobTemplate[j].data = null;
			}
		}
	}

	public void M980(int[] array)
	{
		if (tick > array.Length - 1)
		{
			tick = 0;
		}
		frame = array[tick];
		tick++;
	}

	private void M981()
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

	private void M982(T99 g)
	{
		int size = T174.size;
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
		g.M948(T174.bong, xSd, ySd, 3);
		g.M922(T54.cmx, T54.cmy - T51.transY, T54.gW, T54.gH + 2 * T51.transY);
	}

	public void M983()
	{
		if (typeSuperEff == 0 && T51.gameTick % 25 == 0)
		{
			T143.M1573(114, this, 1);
		}
		if (typeSuperEff == 1 && T51.gameTick % 4 == 0)
		{
			T143.M1573(132, this, 1);
		}
		if (typeSuperEff == 2 && T51.gameTick % 7 == 0)
		{
			T143.M1573(131, this, 1);
		}
	}

	public virtual void update()
	{
		M1008();
		if (blindEff && T51.gameTick % 5 == 0)
		{
			T143.M1571(113, x, y, 1);
		}
		if (sleepEff && T51.gameTick % 10 == 0)
		{
			T31.M376(new T32(41, x, y, 3, 1, 1));
		}
		if (!T51.lowGraphic && status != 1 && status != 0 && !T51.lowGraphic && T51.gameTick % (15 + mobId * 2) == 0)
		{
			for (int i = 0; i < T54.vCharInMap.M1113(); i++)
			{
				T13 t = (T13)T54.vCharInMap.M1114(i);
				if (t != null && t.isFlyAndCharge && t.cf == 32)
				{
					T13 t2 = new T13();
					t2.cx = t.cx;
					t2.cy = t.cy - t.ch;
					if (t.cgender == 0)
					{
						T105.M1017(x + dir * w, y, M1001(), -100, -100, t2, 25);
					}
				}
			}
			if (T13.M113().isFlyAndCharge && T13.M113().cf == 32)
			{
				T13 t3 = new T13();
				t3.cx = T13.M113().cx;
				t3.cy = T13.M113().cy - T13.M113().ch;
				if (T13.M113().cgender == 0)
				{
					T105.M1017(x + dir * w, y, M1001(), -100, -100, t3, 25);
				}
			}
		}
		if (holdEffID != 0 && T51.gameTick % 5 == 0)
		{
			T31.M376(new T32(holdEffID, x, y + 24, 3, 5, 1));
		}
		if (isFreez)
		{
			if (T51.gameTick % 5 == 0)
			{
				T143.M1571(113, x, y, 1);
			}
			long num = T110.M1054();
			if (num - last >= 1000L)
			{
				seconds--;
				last = num;
				if (seconds < 0)
				{
					isFreez = false;
					seconds = 0;
				}
			}
			if (M1009())
			{
				frame = hurt[T51.gameTick % hurt.Length];
			}
			else if (M993())
			{
				frame = attack1[T51.gameTick % attack1.Length];
			}
			else if (M992())
			{
				if (T51.gameTick % 20 > 5)
				{
					frame = 11;
				}
				else
				{
					frame = 10;
				}
			}
			else if (M991())
			{
				if (T51.gameTick % 20 > 5)
				{
					frame = 1;
				}
				else
				{
					frame = 15;
				}
			}
			else if (T51.gameTick % 20 > 5)
			{
				frame = 11;
			}
			else
			{
				frame = 10;
			}
		}
		if (!M1000())
		{
			return;
		}
		if (isShadown)
		{
			M981();
		}
		if (vMobMove == null && arrMobTemplate[templateId].rangeMove != 0)
		{
			return;
		}
		if (status != 3 && isBusyAttackSomeOne)
		{
			if (cFocus != null)
			{
				cFocus.M218(dame, dameMp, isCrit: false, isMob: true);
			}
			else if (mobToAttack != null)
			{
				mobToAttack.M984();
			}
			isBusyAttackSomeOne = false;
		}
		if (levelBoss > 0)
		{
			M983();
		}
		switch (status)
		{
		case 1:
			isDisable = false;
			isDontMove = false;
			isFire = false;
			isIce = false;
			isWind = false;
			y += p1;
			if (T51.gameTick % 2 == 0)
			{
				if (p2 > 1)
				{
					p2--;
				}
				else if (p2 < -1)
				{
					p2++;
				}
			}
			x += p2;
			if (M1009())
			{
				frame = hurt[T51.gameTick % hurt.Length];
			}
			else if (M993())
			{
				frame = attack1[T51.gameTick % attack1.Length];
			}
			else if (M992())
			{
				frame = 11;
			}
			else if (M991())
			{
				frame = 15;
			}
			else
			{
				frame = 11;
			}
			if (isDie)
			{
				isDie = false;
				if (isMobMe)
				{
					for (int j = 0; j < T54.vMob.M1113(); j++)
					{
						if (((T101)T54.vMob.M1114(j)).mobId == mobId)
						{
							T54.vMob.M1118(j);
						}
					}
				}
				p1 = 0;
				p2 = 0;
				y = 0;
				x = 0;
				hp = M998().hp;
				status = 0;
				timeStatus = 0;
				break;
			}
			if ((T174.M1957(x, y) & 2) == 2)
			{
				p1 = ((p1 <= 4) ? (-p1) : (-4));
				if (p3 == 0)
				{
					p3 = 16;
				}
			}
			else
			{
				p1++;
			}
			if (p3 > 0)
			{
				p3--;
				if (p3 == 0)
				{
					isDie = true;
				}
			}
			break;
		case 2:
			if (holdEffID == 0 && !isFreez && !blindEff && !sleepEff)
			{
				timeStatus = 0;
				M995();
			}
			break;
		case 3:
			if (holdEffID == 0 && !blindEff && !sleepEff && !isFreez)
			{
				M996();
			}
			break;
		case 4:
			if (holdEffID == 0 && !blindEff && !sleepEff && !isFreez)
			{
				timeStatus = 0;
				p1++;
				if (p1 > 40 + mobId % 5)
				{
					y -= 2;
					status = 5;
					p1 = 0;
				}
			}
			break;
		case 5:
			if (holdEffID != 0 || blindEff || sleepEff)
			{
				break;
			}
			if (isFreez)
			{
				if (arrMobTemplate[templateId].type == 4)
				{
					ty++;
					wt++;
					fy += ((!wy) ? 1 : (-1));
					if (wt == 10)
					{
						wt = 0;
						wy = !wy;
					}
				}
			}
			else
			{
				timeStatus = 0;
				M997();
			}
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
			M994();
			break;
		}
	}

	public void M984()
	{
		if (hp > 0 && status != 3)
		{
			timeStatus = 4;
			status = 7;
			if (M998().type != 0 && T137.M1529(x - xFirst) < 30)
			{
				x -= 10 * dir;
			}
		}
	}

	public static T202 M985()
	{
		for (int i = 0; i < T54.vMob.M1113(); i++)
		{
			T101 t = (T101)T54.vMob.M1114(i);
			if (t is T202)
			{
				return (T202)t;
			}
		}
		return null;
	}

	public static T12 M986()
	{
		for (int i = 0; i < T54.vMob.M1113(); i++)
		{
			T101 t = (T101)T54.vMob.M1114(i);
			if (t is T12)
			{
				return (T12)t;
			}
		}
		return null;
	}

	public static T7 M987()
	{
		for (int i = 0; i < T54.vMob.M1113(); i++)
		{
			T101 t = (T101)T54.vMob.M1114(i);
			if (t is T7)
			{
				return (T7)t;
			}
		}
		return null;
	}

	public static T121 M988(sbyte idBoss)
	{
		T101 t = (T101)T54.vMob.M1114(idBoss);
		if (t is T121)
		{
			return (T121)t;
		}
		return null;
	}

	public static void M989()
	{
		for (int i = 0; i < T54.vMob.M1113(); i++)
		{
			T101 t = (T101)T54.vMob.M1114(i);
			if (t is T202)
			{
				T54.vMob.M1119(t);
				break;
			}
		}
	}

	public void M990(T13 cFocus)
	{
		isBusyAttackSomeOne = true;
		mobToAttack = null;
		this.cFocus = cFocus;
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

	private bool M991()
	{
		if ((templateId < 58 || templateId > 65) && templateId != 67 && templateId != 68)
		{
			return false;
		}
		return true;
	}

	private bool M992()
	{
		if (templateId >= 73 && !M993())
		{
			return true;
		}
		return false;
	}

	private bool M993()
	{
		if (templateId == 76)
		{
			return true;
		}
		return false;
	}

	private void M994()
	{
		if (!isBusyAttackSomeOne && T51.gameTick % 4 == 0)
		{
			if (M1009())
			{
				frame = hurt[T51.gameTick % hurt.Length];
			}
			else if (M993())
			{
				frame = attack1[T51.gameTick % attack1.Length];
			}
			else if (M992())
			{
				if (frame != 10)
				{
					frame = 10;
				}
				else
				{
					frame = 11;
				}
			}
			else if (M991())
			{
				if (frame != 1)
				{
					frame = 1;
				}
				else
				{
					frame = 15;
				}
			}
			else if (frame != 10)
			{
				frame = 10;
			}
			else
			{
				frame = 11;
			}
		}
		timeStatus--;
		if (timeStatus <= 0 && (M1009() || M993() || (M992() && frame == 11) || (M991() && frame == 15) || (templateId < 58 && frame == 11)))
		{
			if ((injureBy != null && injureThenDie) || hp == 0)
			{
				status = 1;
				p2 = injureBy.cdir << 1;
				p1 = -3;
				p3 = 0;
			}
			else
			{
				status = 5;
				if (injureBy != null)
				{
					dir = -injureBy.cdir;
					if (T137.M1529(x - injureBy.cx) < 24)
					{
						status = 2;
					}
				}
				p3 = 0;
				p2 = 0;
				p1 = 0;
				timeStatus = 0;
			}
			injureBy = null;
		}
		else if (arrMobTemplate[templateId].type != 0 && injureBy != null)
		{
			int num = -injureBy.cdir << 1;
			if (x > xFirst - arrMobTemplate[templateId].rangeMove && x < xFirst + arrMobTemplate[templateId].rangeMove)
			{
				x -= num;
			}
		}
	}

	private void M995()
	{
		M980(stand);
		switch (arrMobTemplate[templateId].type)
		{
		case 4:
		case 5:
			p1++;
			if (p1 > mobId % 3 && (cFocus == null || T137.M1529(cFocus.cx - x) > 80) && (mobToAttack == null || T137.M1529(mobToAttack.x - x) > 80))
			{
				status = 5;
			}
			break;
		case 0:
		case 1:
		case 2:
		case 3:
			p1++;
			if (p1 > 10 + mobId % 10 && (cFocus == null || T137.M1529(cFocus.cx - x) > 80) && (mobToAttack == null || T137.M1529(mobToAttack.x - x) > 80))
			{
				status = 5;
			}
			break;
		}
		if (cFocus != null && T51.gameTick % (10 + p1 % 20) == 0)
		{
			if (cFocus.cx > x)
			{
				dir = 1;
			}
			else
			{
				dir = -1;
			}
		}
		else if (mobToAttack != null && T51.gameTick % (10 + p1 % 20) == 0)
		{
			if (mobToAttack.x > x)
			{
				dir = 1;
			}
			else
			{
				dir = -1;
			}
		}
		if (forceWait > 0)
		{
			forceWait--;
			status = 2;
		}
	}

	public void M996()
	{
		int[] array = ((p3 != 0) ? attack2 : attack1);
		if (tick < array.Length)
		{
			M980(array);
			if (x >= T54.cmx && x <= T54.cmx + T51.w && p3 == 0 && T51.gameTick % 2 == 0)
			{
				T160.M1826().M1831(isKick: false, 0.05f);
			}
		}
		if (p1 == 0)
		{
			int num = 0;
			int num2 = 0;
			num = ((cFocus == null) ? mobToAttack.x : cFocus.cx);
			num2 = ((cFocus == null) ? mobToAttack.y : cFocus.cy);
			if (!M992())
			{
				if (x > xFirst + arrMobTemplate[templateId].rangeMove)
				{
					p1 = 1;
				}
				if (x < xFirst - arrMobTemplate[templateId].rangeMove)
				{
					p1 = 1;
				}
			}
			if ((arrMobTemplate[templateId].type == 4 || arrMobTemplate[templateId].type == 5) && !isDontMove)
			{
				y += (num2 - y) / 20;
			}
			p2++;
			if (p2 > array.Length - 1 || p1 == 1)
			{
				p1 = 1;
				if (p3 == 0)
				{
					if (cFocus != null)
					{
						cFocus.M218(dame, dameMp, isCrit: false, isMob: true);
					}
					else
					{
						mobToAttack.M984();
					}
					isBusyAttackSomeOne = false;
				}
				else
				{
					if (cFocus != null)
					{
						T105.M1017(x + dir * w, y, M1001(), dame, dameMp, cFocus, M998().dartType);
					}
					else
					{
						T13 t = new T13();
						t.cx = mobToAttack.x;
						t.cy = mobToAttack.y;
						t.charID = -100;
						T105.M1017(x + dir * w, y, M1001(), dame, dameMp, t, M998().dartType);
					}
					isBusyAttackSomeOne = false;
				}
			}
			dir = ((x < num) ? 1 : (-1));
		}
		else if (p1 == 1)
		{
			if (arrMobTemplate[templateId].type != 0 && !isDontMove && !isIce && !isWind)
			{
				x += (xFirst - x) / 4;
				y += (yFirst - y) / 4;
			}
			if (T137.M1529(xFirst - x) < 5 && T137.M1529(yFirst - y) < 5 && tick == array.Length)
			{
				status = 2;
				p1 = 0;
				p2 = 0;
				tick = 0;
			}
		}
	}

	public void M997()
	{
		int num = 0;
		try
		{
			if (injureThenDie)
			{
				status = 1;
				p2 = injureBy.cdir << 3;
				p1 = -5;
				p3 = 0;
			}
			num = 1;
			if (isIce)
			{
				return;
			}
			if (!isDontMove && !isWind)
			{
				switch (arrMobTemplate[templateId].type)
				{
				case 0:
					if (M993())
					{
						frame = stand[T51.gameTick % stand.Length];
					}
					else
					{
						frame = 0;
					}
					num = 2;
					break;
				case 1:
				case 2:
				case 3:
				{
					num = 3;
					sbyte b2 = arrMobTemplate[templateId].speed;
					if (b2 == 1)
					{
						if (T51.gameTick % 2 == 1)
						{
							break;
						}
					}
					else if (b2 > 2)
					{
						b2 += (sbyte)(mobId % 2);
					}
					else if (T51.gameTick % 2 == 1)
					{
						b2--;
					}
					x += b2 * dir;
					if (x > xFirst + arrMobTemplate[templateId].rangeMove)
					{
						dir = -1;
					}
					else if (x < xFirst - arrMobTemplate[templateId].rangeMove)
					{
						dir = 1;
					}
					if (T137.M1529(x - T13.M113().cx) < 40 && T137.M1529(x - xFirst) < arrMobTemplate[templateId].rangeMove)
					{
						dir = ((x <= T13.M113().cx) ? 1 : (-1));
						if (T137.M1529(x - T13.M113().cx) < 20)
						{
							x -= dir * 10;
						}
						status = 2;
						forceWait = 20;
					}
					M980((w <= 30) ? moveFast : move);
					break;
				}
				case 4:
				{
					num = 4;
					sbyte b3 = (sbyte)(arrMobTemplate[templateId].speed + (sbyte)(mobId % 2));
					x += b3 * dir;
					if (T51.gameTick % 10 > 2)
					{
						y += b3 * dirV;
					}
					b3 += (sbyte)((T51.gameTick + mobId) % 2);
					if (x > xFirst + arrMobTemplate[templateId].rangeMove)
					{
						dir = -1;
						status = 2;
						forceWait = T51.gameTick % 20 + 20;
						p1 = 0;
					}
					else if (x < xFirst - arrMobTemplate[templateId].rangeMove)
					{
						dir = 1;
						status = 2;
						forceWait = T51.gameTick % 20 + 20;
						p1 = 0;
					}
					if (y > yFirst + 24)
					{
						dirV = -1;
					}
					else if (y < yFirst - (20 + T51.gameTick % 10))
					{
						dirV = 1;
					}
					M980(move);
					break;
				}
				case 5:
				{
					num = 5;
					sbyte b = (sbyte)(arrMobTemplate[templateId].speed + (sbyte)(mobId % 2));
					x += b * dir;
					b += (sbyte)((T51.gameTick + mobId) % 2);
					if (T51.gameTick % 10 > 2)
					{
						y += b * dirV;
					}
					if (x > xFirst + arrMobTemplate[templateId].rangeMove)
					{
						dir = -1;
						status = 2;
						forceWait = T51.gameTick % 20 + 20;
						p1 = 0;
					}
					else if (x < xFirst - arrMobTemplate[templateId].rangeMove)
					{
						dir = 1;
						status = 2;
						forceWait = T51.gameTick % 20 + 20;
						p1 = 0;
					}
					if (y > yFirst + 24)
					{
						dirV = -1;
					}
					else if (y < yFirst - (20 + T51.gameTick % 10))
					{
						dirV = 1;
					}
					if (T174.M1958(x, y, 2))
					{
						if (T51.gameTick % 10 > 5)
						{
							y = T174.M1962(y);
							status = 4;
							p1 = 0;
							dirV = -1;
						}
						else
						{
							dirV = -1;
						}
					}
					break;
				}
				}
			}
			else
			{
				M980(stand);
			}
		}
		catch (Exception)
		{
			T24.M326("lineee: " + num);
		}
	}

	public T103 M998()
	{
		return arrMobTemplate[templateId];
	}

	public bool M999()
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
		if (arrMobTemplate[templateId] == null)
		{
			return false;
		}
		if (arrMobTemplate[templateId].data == null)
		{
			return false;
		}
		if (arrMobTemplate[templateId].data.img == null)
		{
			return false;
		}
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public bool M1000()
	{
		if (arrMobTemplate[templateId] == null)
		{
			return false;
		}
		if (arrMobTemplate[templateId].data == null)
		{
			return false;
		}
		if (status == 0)
		{
			return false;
		}
		return true;
	}

	public bool M1001()
	{
		if (!isBoss && levelBoss <= 0)
		{
			return false;
		}
		return true;
	}

	public virtual void paint(T99 g)
	{
		if (isShadown && status != 0)
		{
			M982(g);
		}
		if (!M999() || (status == 1 && p3 > 0 && T51.gameTick % 3 == 0))
		{
			return;
		}
		g.M918(0, T51.transY);
		if (!changBody)
		{
			arrMobTemplate[templateId].data.M401(g, frame, x, y + fy, (dir != 1) ? 1 : 0, 2);
		}
		else
		{
			T157.M1785(g, smallBody, x, y + fy - 14, 0, 3);
		}
		g.M918(0, -T51.transY);
		if (T13.M113().mobFocus != null && T13.M113().mobFocus.Equals(this) && status != 1)
		{
			int num = (int)(hp * 100L / maxHp) / 10 - 1;
			if (num < 0)
			{
				num = 0;
			}
			if (num > 9)
			{
				num = 9;
			}
			g.M940(imgHP, 0, 6 * (9 - num), 9, 6, 0, x, y - h - 10, 3);
		}
	}

	public int M1002()
	{
		return 16711680;
	}

	public void M1003()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		cTimeDie = T110.M1054();
		hp = 0;
		injureThenDie = true;
		hp = 0;
		status = 1;
		T137.M1513("MOB DIEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEe");
		p1 = -3;
		p2 = -dir;
		p3 = 0;
	}

	public void M1004(T101 mobToAttack)
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

	public int getX()
	{
		return x;
	}

	public int getY()
	{
		return y;
	}

	public int getH()
	{
		return h;
	}

	public int getW()
	{
		return w;
	}

	public void stopMoving()
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

	public bool isInvisible()
	{
		if (status != 0)
		{
			return status == 1;
		}
		return true;
	}

	public void M1005()
	{
		if (holdEffID != 0)
		{
			holdEffID = 0;
		}
	}

	public void M1006()
	{
		blindEff = false;
	}

	public void M1007()
	{
		sleepEff = false;
	}

	public void M1008()
	{
		if (isGetFr && M1009() && arrMobTemplate[templateId].data != null)
		{
			frameArr = (int[][])T23.frameHT_NEWBOSS.M1074(templateId + string.Empty);
			stand = frameArr[0];
			move = frameArr[1];
			moveFast = frameArr[2];
			attack1 = frameArr[3];
			attack2 = frameArr[4];
			hurt = frameArr[5];
			isGetFr = false;
		}
	}

	private bool M1009()
	{
		if (arrMobTemplate[templateId].data != null && arrMobTemplate[templateId].data.typeData == 2)
		{
			return true;
		}
		return false;
	}
}
