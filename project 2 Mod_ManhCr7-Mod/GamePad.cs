using System;

public class GamePad
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

	public GamePad()
	{
		R = 28;
		if (GameCanvas.w < 300)
		{
			isSmallGamePad = true;
			isMediumGamePad = false;
			isLargeGamePad = false;
		}
		if (GameCanvas.w >= 300 && GameCanvas.w <= 380)
		{
			isSmallGamePad = false;
			isMediumGamePad = true;
			isLargeGamePad = false;
		}
		if (GameCanvas.w > 380)
		{
			isSmallGamePad = false;
			isMediumGamePad = false;
			isLargeGamePad = true;
		}
		if (!isLargeGamePad)
		{
			xZone = 0;
			wZone = GameCanvas.hw;
			yZone = GameCanvas.hh >> 1;
			hZone = GameCanvas.h - 80;
		}
		else
		{
			xZone = 0;
			wZone = GameCanvas.hw / 4 * 3 - 20;
			yZone = GameCanvas.hh >> 1;
			hZone = GameCanvas.h;
		}
	}

	public void M525()
	{
		try
		{
			if (GameScr.isAnalog == 0)
			{
				return;
			}
			if (GameCanvas.isPointerDown && !GameCanvas.isPointerJustRelease)
			{
				xTemp = GameCanvas.pxFirst;
				yTemp = GameCanvas.pyFirst;
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
				deltaX = GameCanvas.px - xC;
				deltaY = GameCanvas.py - yC;
				delta = Math.M872(deltaX, 2) + Math.M872(deltaY, 2);
				d = Res.M1527(delta);
				if (Math.M869(deltaX) <= 4 && Math.M869(deltaY) <= 4)
				{
					return;
				}
				angle = Res.M1511(deltaX, deltaY);
				if (!GameCanvas.M481(xC - R, yC - R, 2 * R, 2 * R))
				{
					if (d != 0)
					{
						yM = deltaY * R / d;
						xM = deltaX * R / d;
						xM += xC;
						yM += yC;
						if (!Res.M1530(xC - R, yC - R, 2 * R, 2 * R, xM, yM))
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
					xM = GameCanvas.px;
					yM = GameCanvas.py;
				}
				M527();
				if (M526(2))
				{
					if ((angle <= 360 && angle >= 340) || (angle >= 0 && angle <= 20))
					{
						GameCanvas.keyHold[(!Main.isPC) ? 6 : 24] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24] = true;
					}
					else if (angle > 40 && angle < 70)
					{
						GameCanvas.keyHold[(!Main.isPC) ? 6 : 24] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24] = true;
					}
					else if (angle >= 70 && angle <= 110)
					{
						GameCanvas.keyHold[(!Main.isPC) ? 8 : 22] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22] = true;
					}
					else if (angle > 110 && angle < 120)
					{
						GameCanvas.keyHold[(!Main.isPC) ? 4 : 23] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 4 : 23] = true;
					}
					else if (angle >= 120 && angle <= 200)
					{
						GameCanvas.keyHold[(!Main.isPC) ? 4 : 23] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 4 : 23] = true;
					}
					else if (angle > 200 && angle < 250)
					{
						GameCanvas.keyHold[(!Main.isPC) ? 2 : 21] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21] = true;
						GameCanvas.keyHold[(!Main.isPC) ? 4 : 23] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 4 : 23] = true;
					}
					else if (angle >= 250 && angle <= 290)
					{
						GameCanvas.keyHold[(!Main.isPC) ? 2 : 21] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21] = true;
					}
					else if (angle > 290 && angle < 340)
					{
						GameCanvas.keyHold[(!Main.isPC) ? 2 : 21] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21] = true;
						GameCanvas.keyHold[(!Main.isPC) ? 6 : 24] = true;
						GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24] = true;
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
					yM = (yC = GameCanvas.h - 90);
				}
				else
				{
					yM = (yC = GameCanvas.h - 45);
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
		if (GameScr.isAnalog == 0)
		{
			return false;
		}
		if (Char.M113().statusMe == 3)
		{
			return true;
		}
		try
		{
			int num = 2;
			while (num > 0)
			{
				int i = GameCanvas.arrPos[num].x - GameCanvas.arrPos[num - 1].x;
				int i2 = GameCanvas.arrPos[num].y - GameCanvas.arrPos[num - 1].y;
				if (Res.M1529(i) <= distance || Res.M1529(i2) <= distance)
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
		GameCanvas.M484();
	}

	public void M528(mGraphics g)
	{
		if (GameScr.isAnalog != 0)
		{
			g.M948(GameScr.imgAnalog1, xC, yC, mGraphics.HCENTER | mGraphics.VCENTER);
			g.M948(GameScr.imgAnalog2, xM, yM, mGraphics.HCENTER | mGraphics.VCENTER);
		}
	}

	public bool M529()
	{
		if (GameScr.isAnalog == 0)
		{
			return false;
		}
		return isGamePad;
	}

	public bool M530()
	{
		try
		{
			if (GameScr.isAnalog == 0)
			{
				return false;
			}
			if ((GameCanvas.px >= xZone && GameCanvas.px <= wZone && GameCanvas.py >= yZone && GameCanvas.py <= hZone) || GameCanvas.px >= GameCanvas.w - 50)
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
