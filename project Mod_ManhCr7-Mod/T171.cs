public class T171
{
	public static T117 vTeleport = new T117();

	public int x;

	public int y;

	public int headId;

	public int type;

	public bool isMe;

	public int y2;

	public int id;

	public int dir;

	public int planet;

	public static T60[] maybay = new T60[5];

	public static T60 hole;

	public bool isUp;

	public bool isDown;

	private bool createShip;

	public bool paintFire;

	private bool painHead;

	private int tPrepare;

	private int vy = 1;

	private int tFire;

	private int tDelayHole;

	private bool tHole;

	private bool isShock;

	public T171(int x, int y, int headId, int dir, int type, bool isMe, int planet)
	{
		this.x = x;
		this.y = 5;
		y2 = y;
		this.headId = headId;
		this.type = type;
		this.isMe = isMe;
		this.dir = dir;
		this.planet = planet;
		tPrepare = 0;
		int num = 0;
		while (num < 100)
		{
			num++;
			y2 += 12;
			if (T174.M1958(x, y2, 2))
			{
				if (y2 % 24 != 0)
				{
					y2 -= y2 % 24;
				}
				break;
			}
		}
		isDown = true;
		if (this.planet > 2)
		{
			y2 += 4;
			if (maybay[3] == null)
			{
				maybay[3] = T51.M503("/mainImage/myTexture2dmaybay4a.png");
			}
			if (maybay[4] == null)
			{
				maybay[4] = T51.M503("/mainImage/myTexture2dmaybay4b.png");
			}
			if (hole == null)
			{
				hole = T51.M503("/mainImage/hole.png");
			}
		}
		else if (maybay[planet] == null)
		{
			maybay[planet] = T51.M503("/mainImage/myTexture2dmaybay" + (planet + 1) + ".png");
		}
		if (x > T54.cmx && x < T54.cmx + T51.w && y2 > 100 && !T160.M1826().M1869() && !T160.M1826().M1868())
		{
			createShip = true;
			T160.M1826().M1870();
		}
	}

	public static void M1894(T171 p)
	{
		vTeleport.M1111(p);
	}

	public void M1895(T99 g)
	{
		if (planet > 2 && tHole)
		{
			g.M948(hole, x, y2 + 20, T163.BOTTOM_HCENTER);
		}
	}

	public void M1896(T99 g)
	{
		if (T13.isLoadingMap || x < T54.cmx || x > T54.cmx + T51.w)
		{
			return;
		}
		T127 t = T54.parts[headId];
		int num = 0;
		int num2 = 0;
		if (planet == 0)
		{
			num = 15;
			num2 = 40;
		}
		if (planet == 1)
		{
			num = 7;
			num2 = 55;
		}
		if (planet == 2)
		{
			num = 18;
			num2 = 52;
		}
		if (painHead && planet < 3)
		{
			T157.M1785(g, t.pi[T13.CharInfo[0][0][0]].id, x + ((dir != 1) ? (-num) : num), y - num2, (dir != 1) ? 2 : 0, T163.TOP_CENTER);
		}
		if (planet < 3)
		{
			g.M940(maybay[planet], 0, 0, T99.M958(maybay[planet]), T99.M959(maybay[planet]), (dir == 1) ? 2 : 0, x, y, T163.BOTTOM_HCENTER);
		}
		else if (isDown)
		{
			if (tPrepare > 10)
			{
				g.M940(maybay[4], 0, 0, T99.M958(maybay[4]), T99.M959(maybay[4]), (dir == 1) ? 2 : 0, (dir != 1) ? (x + 11) : (x - 11), y + 2, T163.BOTTOM_HCENTER);
			}
			else
			{
				g.M940(maybay[3], 0, 0, T99.M958(maybay[3]), T99.M959(maybay[3]), (dir == 1) ? 2 : 0, x, y, T163.BOTTOM_HCENTER);
			}
		}
		else if (tPrepare < 20)
		{
			g.M940(maybay[4], 0, 0, T99.M958(maybay[4]), T99.M959(maybay[4]), (dir == 1) ? 2 : 0, (dir != 1) ? (x + 11) : (x - 11), y + 2, T163.BOTTOM_HCENTER);
		}
		else
		{
			g.M940(maybay[3], 0, 0, T99.M958(maybay[3]), T99.M959(maybay[3]), (dir == 1) ? 2 : 0, x, y, T163.BOTTOM_HCENTER);
		}
	}

	public void M1897()
	{
		if (isDown)
		{
			y = y2;
		}
		else if (isUp)
		{
			y = -80;
		}
		if (planet > 2 && paintFire && y != -80)
		{
			if (isDown && tPrepare == 0)
			{
				if (T51.gameTick % 3 == 0)
				{
					T143.M1572(1, x, y, 1, 0);
				}
			}
			else if (isUp && T51.gameTick % 3 == 0)
			{
				T143.M1572(1, x, y + 16, 1, 1);
			}
		}
		tFire++;
		if (tFire > 3)
		{
			tFire = 0;
		}
		if (isDown)
		{
			paintFire = true;
			painHead = ((type != 0) ? true : false);
			if (planet < 3)
			{
				int num = y2 - y >> 3;
				if (num < 1)
				{
					num = 1;
					paintFire = false;
				}
				y += num;
			}
			else
			{
				if (T51.gameTick % 2 == 0)
				{
					vy++;
				}
				if (y2 - y < vy)
				{
					y = y2;
					paintFire = false;
				}
				else
				{
					y += vy;
				}
			}
			if (isMe && type == 1 && T13.M113().isTeleport)
			{
				T13.M113().cx = x;
				T13.M113().cy = y - 30;
				T13.M113().statusMe = 4;
				T54.cmtoX = x - T54.gW2;
				T54.cmtoY = y - T54.gH23;
				T54.info1.isUpdate = false;
			}
			if (T54.M626(id) != null && !isMe && type == 1 && T54.M626(id).isTeleport)
			{
				T54.M626(id).cx = x;
				T54.M626(id).cy = y - 30;
				T54.M626(id).statusMe = 4;
			}
			if (T137.M1529(y - y2) < 50 && T174.M1958(x, y, 2))
			{
				tHole = true;
				if (planet < 3)
				{
					T160.M1826().M1871();
					if (y % 24 != 0)
					{
						y -= y % 24;
					}
					tPrepare++;
					if (tPrepare > 10)
					{
						tPrepare = 0;
						isDown = false;
						isUp = true;
						paintFire = false;
					}
					if (type == 1)
					{
						if (isMe)
						{
							T13.M113().isTeleport = false;
						}
						else if (T54.M626(id) != null)
						{
							T54.M626(id).isTeleport = false;
						}
						painHead = false;
					}
				}
				else
				{
					y = y2;
					if (!isShock)
					{
						T143.M1572(92, x + 4, y + 14, 1, 0);
						T54.shock_scr = 10;
						isShock = true;
					}
					tPrepare++;
					if (tPrepare > 30)
					{
						tPrepare = 0;
						isDown = false;
						isUp = true;
						paintFire = false;
					}
					if (type == 1)
					{
						if (isMe)
						{
							T13.M113().isTeleport = false;
						}
						else if (T54.M626(id) != null)
						{
							T54.M626(id).isTeleport = false;
						}
						painHead = false;
					}
				}
			}
		}
		else if (isUp)
		{
			tPrepare++;
			if (tPrepare > 30)
			{
				int num2 = y2 + 24 - y >> 3;
				if (num2 > 30)
				{
					num2 = 30;
				}
				y -= num2;
				paintFire = true;
			}
			else
			{
				if (tPrepare == 14 && createShip)
				{
					T160.M1826().M1872();
				}
				if (tPrepare > 0 && type == 0)
				{
					if (isMe)
					{
						T13.M113().isTeleport = false;
						if (T13.M113().statusMe != 14)
						{
							T13.M113().statusMe = 3;
						}
						T13.M113().cvy = -3;
					}
					else if (T54.M626(id) != null)
					{
						T54.M626(id).isTeleport = false;
						if (T54.M626(id).statusMe != 14)
						{
							T54.M626(id).statusMe = 3;
						}
						T54.M626(id).cvy = -3;
					}
					painHead = false;
				}
				if (tPrepare > 12 && type == 0)
				{
					if (isMe)
					{
						T13.M113().isTeleport = true;
					}
					else if (T54.M626(id) != null)
					{
						T54.M626(id).cx = x;
						T54.M626(id).cy = y;
						T54.M626(id).isTeleport = true;
					}
					painHead = true;
				}
			}
			if (isMe)
			{
				if (type == 0)
				{
					T54.cmtoX = x - T54.gW2;
					T54.cmtoY = y - T54.gH23;
				}
				if (type == 1)
				{
					T54.info1.isUpdate = true;
				}
			}
			if (y <= -80)
			{
				if (isMe && type == 0)
				{
					T23.isStopReadMessage = false;
					T13.ischangingMap = true;
				}
				if (!isMe && T54.M626(id) != null && type == 0)
				{
					T54.vCharInMap.M1119(T54.M626(id));
				}
				if (planet < 3)
				{
					vTeleport.M1119(this);
				}
				else
				{
					y = -80;
					tDelayHole++;
					if (tDelayHole > 80)
					{
						tDelayHole = 0;
						vTeleport.M1119(this);
					}
				}
			}
		}
		if (paintFire && planet < 3 && T137.M1529(y - y2) <= 50 && T51.gameTick % 5 == 0)
		{
			T31.M376(new T32(19, x, y2 + 20, 2, 1, -1));
		}
	}
}
