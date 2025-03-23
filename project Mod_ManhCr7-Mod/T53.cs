using System;

public class T53
{
	private int xC;

	private int yC;

	private int xM;

	private int yM;

	private int xMLast;

	private int yMLast;

	private int R;

	private int r;

	private int d;

	private int xTemp;

	private int yTemp;

	private int deltaX;

	private int deltaY;

	private int delta;

	private int angle;

	public int xZone;

	public int yZone;

	public int wZone;

	public int hZone;

	private bool isGamePad;

	public bool isSmallGamePad;

	public bool isMediumGamePad;

	public bool isLargeGamePad;

	public T53()
	{
		R = 28;
		if (T51.w < 300)
		{
			isSmallGamePad = true;
			isMediumGamePad = false;
			isLargeGamePad = false;
		}
		if (T51.w >= 300 && T51.w <= 380)
		{
			isSmallGamePad = false;
			isMediumGamePad = true;
			isLargeGamePad = false;
		}
		if (T51.w > 380)
		{
			isSmallGamePad = false;
			isMediumGamePad = false;
			isLargeGamePad = true;
		}
		if (!isLargeGamePad)
		{
			xZone = 0;
			wZone = T51.hw;
			yZone = T51.hh >> 1;
			hZone = T51.h - 80;
		}
		else
		{
			xZone = 0;
			wZone = T51.hw / 4 * 3 - 20;
			yZone = T51.hh >> 1;
			hZone = T51.h;
		}
	}

	public void M525()
	{
		try
		{
			if (T54.isAnalog == 0)
			{
				return;
			}
			if (T51.isPointerDown && !T51.isPointerJustRelease)
			{
				xTemp = T51.pxFirst;
				yTemp = T51.pyFirst;
				if (xTemp < xZone || xTemp > wZone || yTemp < yZone || yTemp > hZone)
				{
					return;
				}
				if (!isGamePad)
				{
					xC = (xM = xTemp);
					yC = (yM = yTemp);
				}
				isGamePad = true;
				deltaX = T51.px - xC;
				deltaY = T51.py - yC;
				delta = T94.M872(deltaX, 2) + T94.M872(deltaY, 2);
				d = T137.M1527(delta);
				if (T94.M869(deltaX) <= 4 && T94.M869(deltaY) <= 4)
				{
					return;
				}
				angle = T137.M1511(deltaX, deltaY);
				if (!T51.M481(xC - R, yC - R, 2 * R, 2 * R))
				{
					if (d != 0)
					{
						yM = deltaY * R / d;
						xM = deltaX * R / d;
						xM += xC;
						yM += yC;
						if (!T137.M1530(xC - R, yC - R, 2 * R, 2 * R, xM, yM))
						{
							xM = xMLast;
							yM = yMLast;
						}
						else
						{
							xMLast = xM;
							yMLast = yM;
						}
					}
					else
					{
						xM = xMLast;
						yM = yMLast;
					}
				}
				else
				{
					xM = T51.px;
					yM = T51.py;
				}
				M527();
				if (M526(2))
				{
					if ((angle <= 360 && angle >= 340) || (angle >= 0 && angle <= 20))
					{
						T51.keyHold[(!Main.isPC) ? 6 : 24] = true;
						T51.keyPressed[(!Main.isPC) ? 6 : 24] = true;
					}
					else if (angle > 40 && angle < 70)
					{
						T51.keyHold[(!Main.isPC) ? 6 : 24] = true;
						T51.keyPressed[(!Main.isPC) ? 6 : 24] = true;
					}
					else if (angle >= 70 && angle <= 110)
					{
						T51.keyHold[(!Main.isPC) ? 8 : 22] = true;
						T51.keyPressed[(!Main.isPC) ? 8 : 22] = true;
					}
					else if (angle > 110 && angle < 120)
					{
						T51.keyHold[(!Main.isPC) ? 4 : 23] = true;
						T51.keyPressed[(!Main.isPC) ? 4 : 23] = true;
					}
					else if (angle >= 120 && angle <= 200)
					{
						T51.keyHold[(!Main.isPC) ? 4 : 23] = true;
						T51.keyPressed[(!Main.isPC) ? 4 : 23] = true;
					}
					else if (angle > 200 && angle < 250)
					{
						T51.keyHold[(!Main.isPC) ? 2 : 21] = true;
						T51.keyPressed[(!Main.isPC) ? 2 : 21] = true;
						T51.keyHold[(!Main.isPC) ? 4 : 23] = true;
						T51.keyPressed[(!Main.isPC) ? 4 : 23] = true;
					}
					else if (angle >= 250 && angle <= 290)
					{
						T51.keyHold[(!Main.isPC) ? 2 : 21] = true;
						T51.keyPressed[(!Main.isPC) ? 2 : 21] = true;
					}
					else if (angle > 290 && angle < 340)
					{
						T51.keyHold[(!Main.isPC) ? 2 : 21] = true;
						T51.keyPressed[(!Main.isPC) ? 2 : 21] = true;
						T51.keyHold[(!Main.isPC) ? 6 : 24] = true;
						T51.keyPressed[(!Main.isPC) ? 6 : 24] = true;
					}
				}
				else
				{
					M527();
				}
			}
			else
			{
				xC = 45;
				xM = 45;
				if (!isLargeGamePad)
				{
					yM = (yC = T51.h - 90);
				}
				else
				{
					yM = (yC = T51.h - 45);
				}
				isGamePad = false;
				M527();
			}
		}
		catch (Exception)
		{
		}
	}

	private bool M526(int distance)
	{
		if (T54.isAnalog == 0)
		{
			return false;
		}
		if (T13.M113().statusMe == 3)
		{
			return true;
		}
		try
		{
			int num = 2;
			while (num > 0)
			{
				int i = T51.arrPos[num].x - T51.arrPos[num - 1].x;
				int i2 = T51.arrPos[num].y - T51.arrPos[num - 1].y;
				if (T137.M1529(i) <= distance || T137.M1529(i2) <= distance)
				{
					num--;
					continue;
				}
				return false;
			}
		}
		catch (Exception)
		{
		}
		return true;
	}

	private void M527()
	{
		T51.M484();
	}

	public void M528(T99 g)
	{
		if (T54.isAnalog != 0)
		{
			g.M948(T54.imgAnalog1, xC, yC, T99.HCENTER | T99.VCENTER);
			g.M948(T54.imgAnalog2, xM, yM, T99.HCENTER | T99.VCENTER);
		}
	}

	public bool M529()
	{
		if (T54.isAnalog == 0)
		{
			return false;
		}
		return isGamePad;
	}

	public bool M530()
	{
		try
		{
			if (T54.isAnalog == 0)
			{
				return false;
			}
			if ((T51.px >= xZone && T51.px <= wZone && T51.py >= yZone && T51.py <= hZone) || T51.px >= T51.w - 50)
			{
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
