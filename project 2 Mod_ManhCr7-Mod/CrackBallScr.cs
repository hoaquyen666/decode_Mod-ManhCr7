using System;

public class CrackBallScr : mScreen
{
	public static CrackBallScr instance;

	private BallInfo[] listBall;

	private byte step;

	private byte typePrice;

	private int rO;

	private int xO;

	private int yO;

	private int angle;

	private int iAngle;

	private int iDot;

	private int yTo;

	private int indexSelect;

	private int indexSkillSelect;

	private int numTicket;

	private int xP;

	private int yP;

	private int wP;

	private int hP;

	private int price;

	private int cost;

	private int countFr;

	private int countKame;

	private int frame;

	private int vp;

	private int[] xArg;

	private int[] yArg;

	private int[] xDot;

	private int[] yDot;

	private short[] idItem;

	private long timeStart;

	private long timeKame;

	private bool isKame;

	private bool isCanSkill;

	private bool isSendSv;

	private short idTicket;

	private static int ySkill;

	private static int[] xSkill;

	private static FrameImage fraImgKame;

	private static FrameImage fraImgKame_1;

	private static FrameImage fraImgKame_2;

	private static Image imgX;

	private static Image imgReplay;

	private byte[] fr = new byte[21]
	{
		19, 19, 19, 19, 19, 19, 19, 19, 19, 19,
		19, 19, 19, 19, 19, 19, 19, 19, 19, 19,
		20
	};

	private byte[] nFrame = new byte[12]
	{
		0, 0, 0, 1, 1, 1, 2, 2, 2, 3,
		3, 3
	};

	public CrackBallScr()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		xSkill = new int[2];
		xSkill[0] = 16;
		ySkill = GameCanvas.h - 41;
		xSkill[1] = GameCanvas.w - 40;
		fraImgKame = new FrameImage(GameCanvas.M503("/e/e_1.png"), 30, 30);
		fraImgKame_1 = new FrameImage(GameCanvas.M503("/e/e_0.png"), 68, 65);
		fraImgKame_2 = new FrameImage(GameCanvas.M503("/e/e_2.png"), 66, 70);
		imgReplay = GameCanvas.M503("/e/nut2.png");
		imgX = GameCanvas.M503("/e/nut3.png");
		wP = 230;
		xP = GameCanvas.hw - wP / 2;
		hP = 40;
		yP = -hP;
	}

	public static CrackBallScr M332()
	{
		if (instance == null)
		{
			instance = new CrackBallScr();
		}
		return instance;
	}

	public void M333(short[] idImage, byte typePrice, int price, short idTicket)
	{
		if (idImage != null && idImage.Length != 0)
		{
			yTo = Char.M113().cy - 10;
			M334();
			listBall = new BallInfo[idImage.Length];
			for (int i = 0; i < listBall.Length; i++)
			{
				listBall[i] = new BallInfo();
				listBall[i].idImg = idImage[i];
				listBall[i].count = i * 25;
				listBall[i].yTo = -999;
				listBall[i].vx = Res.M1522(2, 5);
				listBall[i].dir = Res.M1522(-1, 2);
				listBall[i].M63();
			}
			isCanSkill = false;
			isKame = false;
			isSendSv = false;
			timeStart = GameCanvas.timeNow + Res.M1522(1000, 2000);
			step = 0;
			indexSelect = -1;
			indexSkillSelect = -1;
			this.typePrice = typePrice;
			this.price = price;
			cost = 0;
			Char.M113().M202(470, 408, 1);
			Char.M113().cdir = 2;
			Char.M113().statusMe = 1;
			countFr = 0;
			countKame = 0;
			frame = 0;
			vp = 0;
			yP = -hP;
			this.idTicket = idTicket;
			numTicket = 0;
			M343();
			switchToMe();
			SoundMn.M1826().M1865();
		}
	}

	private void M334()
	{
		rO = GameCanvas.hh / 3 + 10;
		if (rO > 50)
		{
			rO = 50;
		}
		xO = 360;
		GameScr.cmx = GameScr.cmxLim / 2;
		yO = GameScr.cmy + GameCanvas.hh / 3 + 30;
		iDot = 175;
		angle = 0;
		iAngle = 360 / iDot;
		xArg = new int[iDot];
		yArg = new int[iDot];
		xDot = new int[iDot];
		yDot = new int[iDot];
		M335();
	}

	private void M335()
	{
		if (GameCanvas.lowGraphic)
		{
			return;
		}
		for (int i = 0; i < yArg.Length; i++)
		{
			yArg[i] = Res.M1529(rO * Res.M1507(angle) / 1024);
			xArg[i] = Res.M1529(rO * Res.M1508(angle) / 1024);
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

	public void M336(int idAction, object p)
	{
	}

	public override void update()
	{
		try
		{
			cost = price * M342();
			M343();
			GameScr.M559().update();
			if (timeStart - GameCanvas.timeNow > 0L)
			{
				for (int i = 0; i < listBall.Length; i++)
				{
					listBall[i].count += 2;
					if (listBall[i].count >= iDot)
					{
						listBall[i].count = 0;
					}
					listBall[i].x = xDot[listBall[i].count];
					listBall[i].y = yDot[listBall[i].count];
				}
				return;
			}
			if (step == 0)
			{
				step = 1;
			}
			if (step == 1)
			{
				for (int j = 0; j < listBall.Length; j++)
				{
					if (listBall[j].yTo == -999 || listBall[j].isDone)
					{
						continue;
					}
					if (listBall[j].y < listBall[j].yTo)
					{
						if (listBall[j].vy < 0)
						{
							listBall[j].vy = 0;
						}
						if (listBall[j].y + listBall[j].vy > listBall[j].yTo)
						{
							listBall[j].y = listBall[j].yTo;
						}
						else
						{
							listBall[j].y += listBall[j].vy;
						}
						listBall[j].vy++;
					}
					else
					{
						if (listBall[j].vy > 0)
						{
							listBall[j].vy = 0;
						}
						listBall[j].y += listBall[j].vy;
						listBall[j].vy--;
					}
					if (listBall[j].y == listBall[j].yTo)
					{
						EffectMn.M376(new Effect(19, listBall[j].x - 5, listBall[j].y + 25, 2, 1, -1));
						SoundMn.M1826().M1853();
						listBall[j].isDone = true;
						if (!isCanSkill)
						{
							isCanSkill = true;
						}
					}
				}
			}
			if (step == 2)
			{
				for (int k = 0; k < listBall.Length; k++)
				{
					if (listBall[k].isDone)
					{
						continue;
					}
					if (listBall[k].y > -10)
					{
						if (listBall[k].vy > 0)
						{
							listBall[k].vy = 0;
						}
						listBall[k].y += listBall[k].vy;
						listBall[k].vy--;
						listBall[k].x += listBall[k].vx * listBall[k].dir;
						listBall[k].vx -= 3;
					}
					if (listBall[k].y == -10)
					{
						listBall[k].isPaint = false;
					}
				}
				countFr++;
				if (countFr > fr.Length - 1)
				{
					countFr = fr.Length - 1;
					isKame = true;
					SoundMn.M1826().M1875();
					if (!isSendSv && timeKame - GameCanvas.timeNow < 0L)
					{
						Service.M1594().M1740(2, (byte)(M341() + M342()));
						isSendSv = true;
					}
				}
				Char.M113().cf = fr[countFr];
				countKame++;
				if (countKame > 5)
				{
					countKame = 0;
				}
				frame = nFrame[countKame];
			}
			if (step == 3)
			{
				if (countKame <= 5)
				{
					countKame = 5;
				}
				countKame++;
				if (countKame > nFrame.Length - 1)
				{
					countKame = nFrame.Length - 1;
					step = 4;
					isKame = false;
					int num = 0;
					for (int l = 0; l < listBall.Length; l++)
					{
						if (listBall[l].isDone && !listBall[l].isSetImg)
						{
							listBall[l].idImg = idItem[num];
							listBall[l].isSetImg = true;
							num++;
						}
					}
				}
				frame = nFrame[countKame];
			}
			if (step == 4)
			{
				for (int m = 0; m < listBall.Length; m++)
				{
					if (listBall[m].isPaint)
					{
						listBall[m].xTo = Char.M113().cx;
					}
				}
				step = 5;
			}
			if (step != 5)
			{
				return;
			}
			vp++;
			if (yP < GameCanvas.hh / 3)
			{
				if (yP + vp > GameCanvas.hh / 3)
				{
					yP = GameCanvas.hh / 3;
				}
				else
				{
					yP += vp;
				}
			}
			for (int n = 0; n < listBall.Length; n++)
			{
				if (!listBall[n].isPaint)
				{
					continue;
				}
				if (listBall[n].x < listBall[n].xTo)
				{
					if (listBall[n].vx < 0)
					{
						listBall[n].vx = 0;
					}
					if (listBall[n].x + listBall[n].vx > listBall[n].xTo)
					{
						listBall[n].x = listBall[n].xTo;
					}
					else
					{
						listBall[n].x += listBall[n].vx;
					}
					listBall[n].vx++;
				}
				else
				{
					if (listBall[n].vx > 0)
					{
						listBall[n].vx = 0;
					}
					listBall[n].x += listBall[n].vx;
					listBall[n].vx--;
				}
				if (listBall[n].x == listBall[n].xTo)
				{
					listBall[n].isPaint = false;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public override void updateKey()
	{
		if (InfoDlg.isLock)
		{
			return;
		}
		if (GameCanvas.isTouch && !ChatTextField.M279().isShow && !GameCanvas.menu.showMenu)
		{
			M337();
		}
		for (int i = 1; i < 8; i++)
		{
			if (GameCanvas.keyPressed[i])
			{
				GameCanvas.keyPressed[i] = false;
				M338(i - 1);
			}
		}
		if (GameCanvas.keyPressed[12])
		{
			GameCanvas.keyPressed[12] = false;
			M339(0);
		}
		if (GameCanvas.keyPressed[13])
		{
			GameCanvas.keyPressed[13] = false;
			M339(1);
		}
		GameCanvas.M483();
	}

	private void M337()
	{
		if (step == 1 && GameCanvas.isPointerClick)
		{
			for (int i = 0; i < listBall.Length; i++)
			{
				if (GameCanvas.M481(listBall[i].x - 20 - GameScr.cmx, listBall[i].y - 10 - GameScr.cmy, 30, 30) && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					M338(i);
				}
			}
		}
		if (!GameCanvas.isPointerClick)
		{
			return;
		}
		for (int j = 0; j < xSkill.Length; j++)
		{
			if (GameCanvas.M481(xSkill[j], ySkill, 36, 36) && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
			{
				M339(j);
			}
		}
	}

	private void M338(int index)
	{
		if (!listBall[index].isDone)
		{
			SoundMn.M1826().M1836();
			long num = ((typePrice != 0) ? Char.M113().M251() : Char.M113().xu);
			if (M341() >= numTicket && num < cost + price)
			{
				string s = mResources.not_enough_money_1 + " " + ((typePrice != 0) ? mResources.LUONG : mResources.XU);
				GameScr.info1.M762(s, 0);
			}
			else
			{
				indexSelect = index;
				listBall[indexSelect].yTo = yTo + Res.M1522(-3, 3);
			}
		}
	}

	private void M339(int index)
	{
		if (indexSkillSelect != index)
		{
			indexSkillSelect = index;
		}
		else if (index == 0)
		{
			if (step < 2)
			{
				if (M341() + M342() > 0)
				{
					step = 2;
					SoundMn.M1826().M1835();
					Char.M113().M172(GameScr.sks[13], 0);
					timeKame = GameCanvas.timeNow + Res.M1522(2000, 3000);
				}
			}
			else if (yP == GameCanvas.hh / 3)
			{
				Service.M1594().M1740(typePrice, 0);
			}
		}
		else
		{
			GameScr.M559().isRongThanXuatHien = false;
			GameScr.M559().switchToMe();
		}
	}

	public override void paint(mGraphics g)
	{
		try
		{
			GameScr.M559().paint(g);
			g.M918(-GameScr.cmx, -GameScr.cmy);
			g.M918(0, GameCanvas.transY);
			for (int i = 0; i < listBall.Length; i++)
			{
				if (listBall[i].isPaint && listBall[i].y > listBall[i].yTo - 20)
				{
					g.M948(TileMap.bong, listBall[i].x, listBall[i].yTo + 7, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			for (int j = 0; j < listBall.Length; j++)
			{
				if (listBall[j].isPaint)
				{
					SmallImage.M1785(g, listBall[j].idImg, listBall[j].x, listBall[j].y, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			if (isKame)
			{
				if (fraImgKame != null)
				{
					int num = Char.M113().cx - fraImgKame.frameWidth - 28;
					for (int k = 0; k < GameCanvas.w / fraImgKame.frameWidth + 1; k++)
					{
						fraImgKame.M439(frame, num - k * (fraImgKame.frameWidth - 1), Char.M113().cy - fraImgKame.frameHeight / 2 - 12 + 2, 0, 0, g);
					}
				}
				if (fraImgKame_1 != null)
				{
					int cx = Char.M113().cx;
					int frameWidth = fraImgKame_1.frameWidth;
					fraImgKame_1.M439(frame, cx - frameWidth - 10 - 5, Char.M113().cy - fraImgKame_1.frameHeight / 2 - 12, 0, 0, g);
				}
			}
			GameScr.M631(g);
			int num2 = 240;
			int num3 = GameCanvas.w - 240;
			int num4 = 15;
			g.M933(13524492);
			g.M932(num3, 0, 240, 15);
			g.M948(Panel.imgXu, num3 + 11, 8, 3);
			g.M948(Panel.imgLuong, num3 + 90, 7, 3);
			mFont.tahoma_7_yellow.M902(g, Char.M113().xuStr + string.Empty, num3 + 24, 2, mFont.LEFT, mFont.tahoma_7_grey);
			mFont.tahoma_7_yellow.M902(g, Char.M113().luongStr + string.Empty, num3 + 100, 2, mFont.LEFT, mFont.tahoma_7_grey);
			g.M948(Panel.imgLuongKhoa, num3 + 150, 8, 3);
			mFont.tahoma_7_yellow.M902(g, Char.M113().luongKhoaStr + string.Empty, num3 + 160, 2, mFont.LEFT, mFont.tahoma_7_grey);
			g.M948(Panel.imgTicket, num3 + 200, 8, 3);
			mFont.tahoma_7_yellow.M902(g, numTicket + string.Empty, num3 + 210, 2, mFont.LEFT, mFont.tahoma_7_grey);
			if (step < 4)
			{
				int num5 = num2 / 2 + 20;
				int num6 = GameCanvas.w - num5;
				g.M933(11837316);
				g.M932(num6, num4, num5, 15);
				if (typePrice == 0)
				{
					g.M948(Panel.imgXu, num6 + 21, num4 + 8, 3);
				}
				else
				{
					g.M948(Panel.imgLuongKhoa, num6 + 21, num4 + 7, 3);
					g.M948(Panel.imgLuong, num6 + 18, num4 + 7, 3);
				}
				mFont.tahoma_7_red.M902(g, " -" + cost, num6 + 30, num4 + 2, mFont.LEFT, mFont.tahoma_7_grey);
				g.M948(Panel.imgTicket, num6 + 80, num4 + 7, 3);
				mFont.tahoma_7_red.M902(g, " -" + M341(), num6 + 90, num4 + 2, mFont.LEFT, mFont.tahoma_7_grey);
			}
			g.M948(GameScr.imgSkill, xSkill[0], ySkill, 0);
			if (indexSkillSelect == 0)
			{
				g.M948(GameScr.imgSkill2, xSkill[0], ySkill, 0);
			}
			if (step < 3)
			{
				SmallImage.M1785(g, 540, xSkill[0] + 14, ySkill + 14, 0, StaticObj.VCENTER_HCENTER);
			}
			else
			{
				g.M948(imgReplay, xSkill[0] + 14 - 10, ySkill + 14 - 10, 0);
			}
			g.M948(GameScr.imgSkill, xSkill[1], ySkill, 0);
			if (indexSkillSelect == 1)
			{
				g.M948(GameScr.imgSkill2, xSkill[1], ySkill, 0);
			}
			g.M948(imgX, xSkill[1] + 14 - 10, ySkill + 14 - 10, 0);
			if (step > 3)
			{
				GameCanvas.paintz.M1236(xP, yP, wP, hP, g);
				int num7 = GameCanvas.hw - idItem.Length * 30 / 2;
				for (int l = 0; l < idItem.Length; l++)
				{
					SmallImage.M1785(g, idItem[l], num7 + 5 + l * 30, yP + 10, 0, 0);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void M340(short[] idImage)
	{
		step = 3;
		idItem = idImage;
	}

	public override void switchToMe()
	{
		GameScr.isPaintOther = true;
		GameScr.M559().isRongThanXuatHien = true;
		base.switchToMe();
	}

	private byte M341()
	{
		byte b = 0;
		for (int i = 0; i < listBall.Length; i++)
		{
			if (listBall[i].isDone)
			{
				b++;
			}
		}
		if (b > numTicket)
		{
			b = (byte)numTicket;
		}
		return b;
	}

	private byte M342()
	{
		byte b = 0;
		for (int i = 0; i < listBall.Length; i++)
		{
			if (listBall[i].isDone)
			{
				b++;
			}
		}
		b -= M341();
		if (b <= 0)
		{
			b = 0;
		}
		return b;
	}

	private void M343()
	{
		for (int i = 0; i < Char.M113().arrItemBag.Length; i++)
		{
			if (Char.M113().arrItemBag[i] != null && Char.M113().arrItemBag[i].template.id == idTicket)
			{
				numTicket = Char.M113().arrItemBag[i].quantity;
				break;
			}
		}
	}
}
