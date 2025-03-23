public class T80 : T62
{
	public int x;

	public int y;

	public int xEnd;

	public int yEnd;

	public int f;

	public int vx;

	public int vy;

	public int playerId;

	public int itemMapID;

	public int IdCharMove;

	public T84 template;

	public sbyte status;

	public bool isHintFocus;

	public int rO;

	public int xO;

	public int yO;

	public int angle;

	public int iAngle;

	public int iDot;

	public int[] xArg;

	public int[] yArg;

	public int[] xDot;

	public int[] yDot;

	public int count;

	public int countAura;

	public static T60 imageFlare = T51.M503("/mainImage/myTexture2dflare.png");

	public static T60 imageAuraItem1 = T51.M503("/mainImage/myTexture2ditemaura1.png");

	public static T60 imageAuraItem2 = T51.M503("/mainImage/myTexture2ditemaura2.png");

	public static T60 imageAuraItem3 = T51.M503("/mainImage/myTexture2ditemaura3.png");

	public T80(short itemMapID, short itemTemplateID, int x, int y, int xEnd, int yEnd)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.itemMapID = itemMapID;
		template = T85.M834(itemTemplateID);
		this.x = xEnd;
		this.y = y;
		this.xEnd = xEnd;
		this.yEnd = yEnd;
		vx = xEnd - x >> 2;
		vy = 5;
		T137.M1513("playerid=  " + playerId + " myid= " + T13.M113().charID);
	}

	public T80(int playerId, short itemMapID, short itemTemplateID, int x, int y, short r)
	{
		T137.M1513("item map item= " + itemMapID + " template= " + itemTemplateID + " x= " + x + " y= " + y);
		this.itemMapID = itemMapID;
		template = T85.M834(itemTemplateID);
		T137.M1513("playerid=  " + playerId + " myid= " + T13.M113().charID);
		this.x = (xEnd = x);
		this.y = (yEnd = y);
		status = 1;
		this.playerId = playerId;
		if (M825())
		{
			rO = r;
			M826();
		}
	}

	public void M822(int xEnd, int yEnd)
	{
		this.xEnd = xEnd;
		this.yEnd = yEnd;
		vx = xEnd - x >> 2;
		vy = yEnd - y >> 2;
		status = 2;
	}

	public void M823()
	{
		if (status == 2 && x == xEnd && y == yEnd)
		{
			T54.vItemMap.M1119(this);
			if (T13.M113().itemFocus != null && T13.M113().itemFocus.Equals(this))
			{
				T13.M113().itemFocus = null;
			}
			return;
		}
		if (status > 0)
		{
			if (vx == 0)
			{
				x = xEnd;
			}
			if (vy == 0)
			{
				y = yEnd;
			}
			if (x != xEnd)
			{
				x += vx;
				if ((vx > 0 && x > xEnd) || (vx < 0 && x < xEnd))
				{
					x = xEnd;
				}
			}
			if (y != yEnd)
			{
				y += vy;
				if ((vy > 0 && y > yEnd) || (vy < 0 && y < yEnd))
				{
					y = yEnd;
				}
			}
		}
		else
		{
			status -= 4;
			if (status < -12)
			{
				y -= 12;
				status = 1;
			}
		}
		if (M825())
		{
			M827();
		}
	}

	public void M824(T99 g)
	{
		if (M825())
		{
			g.M948(T174.bong, x + 3, y, T99.VCENTER | T99.HCENTER);
			if (status <= 0)
			{
				if (countAura < 10)
				{
					g.M948(imageAuraItem1, x, y + status + 3, T99.BOTTOM | T99.HCENTER);
				}
				else
				{
					g.M948(imageAuraItem2, x, y + status + 3, T99.BOTTOM | T99.HCENTER);
				}
			}
			else if (countAura < 10)
			{
				g.M948(imageAuraItem1, x, y + 3, T99.BOTTOM | T99.HCENTER);
			}
			else
			{
				g.M948(imageAuraItem2, x, y + 3, T99.BOTTOM | T99.HCENTER);
			}
		}
		else if (!M825())
		{
			if (T51.gameTick % 4 == 0)
			{
				g.M948(imageFlare, x, y + status + 13, T99.BOTTOM | T99.HCENTER);
			}
			if (status <= 0)
			{
				T157.M1785(g, template.iconID, x, y + status + 3, 0, T99.BOTTOM | T99.HCENTER);
			}
			else
			{
				T157.M1785(g, template.iconID, x, y + 3, 0, T99.BOTTOM | T99.HCENTER);
			}
			if (T13.M113().itemFocus != null && T13.M113().itemFocus.Equals(this) && status != 2)
			{
				g.M940(T101.imgHP, 0, 24, 9, 6, 0, x, y - 17, 3);
			}
		}
	}

	private bool M825()
	{
		if (template.type == 22)
		{
			return true;
		}
		return false;
	}

	private void M826()
	{
		xO = x;
		yO = y;
		iDot = 120;
		angle = 0;
		if (!T51.lowGraphic)
		{
			iAngle = 360 / iDot;
			xArg = new int[iDot];
			yArg = new int[iDot];
			xDot = new int[iDot];
			yDot = new int[iDot];
			M829();
		}
	}

	private void M827()
	{
		count++;
		countAura++;
		if (countAura >= 40)
		{
			countAura = 0;
		}
		if (count >= iDot)
		{
			count = 0;
		}
		if (count % 10 == 0 && !T51.lowGraphic)
		{
			T143.M1571(114, x - 5, y - 30, 1);
		}
	}

	public void M828(T99 g)
	{
		if (T51.lowGraphic || !M825())
		{
			return;
		}
		for (int i = 0; i < yArg.Length; i++)
		{
			if (count == i)
			{
				if (countAura <= 20)
				{
					g.M948(imageAuraItem3, xDot[i], yDot[i] + 3, T99.BOTTOM | T99.HCENTER);
				}
				else
				{
					T157.M1785(g, template.iconID, xDot[i], yDot[i] + 3, 0, T99.BOTTOM | T99.HCENTER);
				}
			}
		}
	}

	private void M829()
	{
		if (T51.lowGraphic)
		{
			return;
		}
		for (int i = 0; i < yArg.Length; i++)
		{
			yArg[i] = T137.M1529(rO * T137.M1507(angle) / 1024);
			xArg[i] = T137.M1529(rO * T137.M1508(angle) / 1024);
			if (angle < 90)
			{
				xDot[i] = xO + xArg[i];
				yDot[i] = yO - yArg[i];
			}
			else if (angle >= 90 && angle < 180)
			{
				xDot[i] = xO - xArg[i];
				yDot[i] = yO - yArg[i];
			}
			else if (angle >= 180 && angle < 270)
			{
				xDot[i] = xO - xArg[i];
				yDot[i] = yO + yArg[i];
			}
			else
			{
				xDot[i] = xO + xArg[i];
				yDot[i] = yO + yArg[i];
			}
			angle += iAngle;
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
		return 20;
	}

	public int getW()
	{
		return 20;
	}

	public void stopMoving()
	{
	}

	public bool isInvisible()
	{
		return false;
	}
}
