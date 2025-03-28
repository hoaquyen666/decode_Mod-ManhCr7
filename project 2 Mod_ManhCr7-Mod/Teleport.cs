public class Teleport
{
	public static MyVector vTeleport = new MyVector();

	public int x;

	public int y;

	public int headId;

	public int type;

	public bool isMe;

	public int y2;

	public int id;

	public int dir;

	public int planet;

	public static Image[] maybay = new Image[5];

	public static Image hole;

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

	public Teleport(int x, int y, int headId, int dir, int type, bool isMe, int planet)
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
			if (TileMap.M1958(x, y2, 2))
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
				maybay[3] = GameCanvas.M503("/mainImage/myTexture2dmaybay4a.png");
			}
			if (maybay[4] == null)
			{
				maybay[4] = GameCanvas.M503("/mainImage/myTexture2dmaybay4b.png");
			}
			if (hole == null)
			{
				hole = GameCanvas.M503("/mainImage/hole.png");
			}
		}
		else if (maybay[planet] == null)
		{
			maybay[planet] = GameCanvas.M503("/mainImage/myTexture2dmaybay" + (planet + 1) + ".png");
		}
		if (x > GameScr.cmx && x < GameScr.cmx + GameCanvas.w && y2 > 100 && !SoundMn.M1826().M1869() && !SoundMn.M1826().M1868())
		{
			createShip = true;
			SoundMn.M1826().M1870();
		}
	}

	public static void M1894(Teleport p)
	{
		vTeleport.M1111(p);
	}

	public void M1895(mGraphics g)
	{
		if (planet > 2 && tHole)
		{
			g.M948(hole, x, y2 + 20, StaticObj.BOTTOM_HCENTER);
		}
	}

	public void M1896(mGraphics g)
	{
		if (Char.isLoadingMap || x < GameScr.cmx || x > GameScr.cmx + GameCanvas.w)
		{
			return;
		}
		Part t = GameScr.parts[headId];
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
			SmallImage.M1785(g, t.pi[Char.CharInfo[0][0][0]].id, x + ((dir != 1) ? (-num) : num), y - num2, (dir != 1) ? 2 : 0, StaticObj.TOP_CENTER);
		}
		if (planet < 3)
		{
			g.M940(maybay[planet], 0, 0, mGraphics.M958(maybay[planet]), mGraphics.M959(maybay[planet]), (dir == 1) ? 2 : 0, x, y, StaticObj.BOTTOM_HCENTER);
		}
		else if (isDown)
		{
			if (tPrepare > 10)
			{
				g.M940(maybay[4], 0, 0, mGraphics.M958(maybay[4]), mGraphics.M959(maybay[4]), (dir == 1) ? 2 : 0, (dir != 1) ? (x + 11) : (x - 11), y + 2, StaticObj.BOTTOM_HCENTER);
			}
			else
			{
				g.M940(maybay[3], 0, 0, mGraphics.M958(maybay[3]), mGraphics.M959(maybay[3]), (dir == 1) ? 2 : 0, x, y, StaticObj.BOTTOM_HCENTER);
			}
		}
		else if (tPrepare < 20)
		{
			g.M940(maybay[4], 0, 0, mGraphics.M958(maybay[4]), mGraphics.M959(maybay[4]), (dir == 1) ? 2 : 0, (dir != 1) ? (x + 11) : (x - 11), y + 2, StaticObj.BOTTOM_HCENTER);
		}
		else
		{
			g.M940(maybay[3], 0, 0, mGraphics.M958(maybay[3]), mGraphics.M959(maybay[3]), (dir == 1) ? 2 : 0, x, y, StaticObj.BOTTOM_HCENTER);
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
				if (GameCanvas.gameTick % 3 == 0)
				{
					ServerEffect.M1572(1, x, y, 1, 0);
				}
			}
			else if (isUp && GameCanvas.gameTick % 3 == 0)
			{
				ServerEffect.M1572(1, x, y + 16, 1, 1);
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
				if (GameCanvas.gameTick % 2 == 0)
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
			if (isMe && type == 1 && Char.M113().isTeleport)
			{
				Char.M113().cx = x;
				Char.M113().cy = y - 30;
				Char.M113().statusMe = 4;
				GameScr.cmtoX = x - GameScr.gW2;
				GameScr.cmtoY = y - GameScr.gH23;
				GameScr.info1.isUpdate = false;
			}
			if (GameScr.M626(id) != null && !isMe && type == 1 && GameScr.M626(id).isTeleport)
			{
				GameScr.M626(id).cx = x;
				GameScr.M626(id).cy = y - 30;
				GameScr.M626(id).statusMe = 4;
			}
			if (Res.M1529(y - y2) < 50 && TileMap.M1958(x, y, 2))
			{
				tHole = true;
				if (planet < 3)
				{
					SoundMn.M1826().M1871();
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
							Char.M113().isTeleport = false;
						}
						else if (GameScr.M626(id) != null)
						{
							GameScr.M626(id).isTeleport = false;
						}
						painHead = false;
					}
				}
				else
				{
					y = y2;
					if (!isShock)
					{
						ServerEffect.M1572(92, x + 4, y + 14, 1, 0);
						GameScr.shock_scr = 10;
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
							Char.M113().isTeleport = false;
						}
						else if (GameScr.M626(id) != null)
						{
							GameScr.M626(id).isTeleport = false;
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
					SoundMn.M1826().M1872();
				}
				if (tPrepare > 0 && type == 0)
				{
					if (isMe)
					{
						Char.M113().isTeleport = false;
						if (Char.M113().statusMe != 14)
						{
							Char.M113().statusMe = 3;
						}
						Char.M113().cvy = -3;
					}
					else if (GameScr.M626(id) != null)
					{
						GameScr.M626(id).isTeleport = false;
						if (GameScr.M626(id).statusMe != 14)
						{
							GameScr.M626(id).statusMe = 3;
						}
						GameScr.M626(id).cvy = -3;
					}
					painHead = false;
				}
				if (tPrepare > 12 && type == 0)
				{
					if (isMe)
					{
						Char.M113().isTeleport = true;
					}
					else if (GameScr.M626(id) != null)
					{
						GameScr.M626(id).cx = x;
						GameScr.M626(id).cy = y;
						GameScr.M626(id).isTeleport = true;
					}
					painHead = true;
				}
			}
			if (isMe)
			{
				if (type == 0)
				{
					GameScr.cmtoX = x - GameScr.gW2;
					GameScr.cmtoY = y - GameScr.gH23;
				}
				if (type == 1)
				{
					GameScr.info1.isUpdate = true;
				}
			}
			if (y <= -80)
			{
				if (isMe && type == 0)
				{
					Controller.isStopReadMessage = false;
					Char.ischangingMap = true;
				}
				if (!isMe && GameScr.M626(id) != null && type == 0)
				{
					GameScr.vCharInMap.M1119(GameScr.M626(id));
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
		if (paintFire && planet < 3 && Res.M1529(y - y2) <= 50 && GameCanvas.gameTick % 5 == 0)
		{
			EffectMn.M376(new Effect(19, x, y2 + 20, 2, 1, -1));
		}
	}
}
