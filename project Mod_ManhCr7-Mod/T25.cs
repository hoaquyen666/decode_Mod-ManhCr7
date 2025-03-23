using System;

public class T25 : T108
{
	public static T25 instance;

	private T9[] listBall;

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

	private static T49 fraImgKame;

	private static T49 fraImgKame_1;

	private static T49 fraImgKame_2;

	private static T60 imgX;

	private static T60 imgReplay;

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

	public T25()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		xSkill = new int[2];
		xSkill[0] = 16;
		ySkill = T51.h - 41;
		xSkill[1] = T51.w - 40;
		fraImgKame = new T49(T51.M503("/e/e_1.png"), 30, 30);
		fraImgKame_1 = new T49(T51.M503("/e/e_0.png"), 68, 65);
		fraImgKame_2 = new T49(T51.M503("/e/e_2.png"), 66, 70);
		imgReplay = T51.M503("/e/nut2.png");
		imgX = T51.M503("/e/nut3.png");
		wP = 230;
		xP = T51.hw - wP / 2;
		hP = 40;
		yP = -hP;
	}

	public static T25 M332()
	{
		if (instance == null)
		{
			instance = new T25();
		}
		return instance;
	}

	public void M333(short[] idImage, byte typePrice, int price, short idTicket)
	{
		if (idImage != null && idImage.Length != 0)
		{
			yTo = T13.M113().cy - 10;
			M334();
			listBall = new T9[idImage.Length];
			for (int i = 0; i < listBall.Length; i++)
			{
				listBall[i] = new T9();
				listBall[i].idImg = idImage[i];
				listBall[i].count = i * 25;
				listBall[i].yTo = -999;
				listBall[i].vx = T137.M1522(2, 5);
				listBall[i].dir = T137.M1522(-1, 2);
				listBall[i].M63();
			}
			isCanSkill = false;
			isKame = false;
			isSendSv = false;
			timeStart = T51.timeNow + T137.M1522(1000, 2000);
			step = 0;
			indexSelect = -1;
			indexSkillSelect = -1;
			this.typePrice = typePrice;
			this.price = price;
			cost = 0;
			T13.M113().M202(470, 408, 1);
			T13.M113().cdir = 2;
			T13.M113().statusMe = 1;
			countFr = 0;
			countKame = 0;
			frame = 0;
			vp = 0;
			yP = -hP;
			this.idTicket = idTicket;
			numTicket = 0;
			M343();
			switchToMe();
			T160.M1826().M1865();
		}
	}

	private void M334()
	{
		rO = T51.hh / 3 + 10;
		if (rO > 50)
		{
			rO = 50;
		}
		xO = 360;
		T54.cmx = T54.cmxLim / 2;
		yO = T54.cmy + T51.hh / 3 + 30;
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

	public void M336(int idAction, object p)
	{
	}

	public override void update()
	{
		try
		{
			cost = price * M342();
			M343();
			T54.M559().update();
			if (timeStart - T51.timeNow > 0L)
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
						T31.M376(new T32(19, listBall[j].x - 5, listBall[j].y + 25, 2, 1, -1));
						T160.M1826().M1853();
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
					T160.M1826().M1875();
					if (!isSendSv && timeKame - T51.timeNow < 0L)
					{
						T146.M1594().M1740(2, (byte)(M341() + M342()));
						isSendSv = true;
					}
				}
				T13.M113().cf = fr[countFr];
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
						listBall[m].xTo = T13.M113().cx;
					}
				}
				step = 5;
			}
			if (step != 5)
			{
				return;
			}
			vp++;
			if (yP < T51.hh / 3)
			{
				if (yP + vp > T51.hh / 3)
				{
					yP = T51.hh / 3;
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
		if (T66.isLock)
		{
			return;
		}
		if (T51.isTouch && !T15.M279().isShow && !T51.menu.showMenu)
		{
			M337();
		}
		for (int i = 1; i < 8; i++)
		{
			if (T51.keyPressed[i])
			{
				T51.keyPressed[i] = false;
				M338(i - 1);
			}
		}
		if (T51.keyPressed[12])
		{
			T51.keyPressed[12] = false;
			M339(0);
		}
		if (T51.keyPressed[13])
		{
			T51.keyPressed[13] = false;
			M339(1);
		}
		T51.M483();
	}

	private void M337()
	{
		if (step == 1 && T51.isPointerClick)
		{
			for (int i = 0; i < listBall.Length; i++)
			{
				if (T51.M481(listBall[i].x - 20 - T54.cmx, listBall[i].y - 10 - T54.cmy, 30, 30) && T51.isPointerClick && T51.isPointerJustRelease)
				{
					M338(i);
				}
			}
		}
		if (!T51.isPointerClick)
		{
			return;
		}
		for (int j = 0; j < xSkill.Length; j++)
		{
			if (T51.M481(xSkill[j], ySkill, 36, 36) && T51.isPointerClick && T51.isPointerJustRelease)
			{
				M339(j);
			}
		}
	}

	private void M338(int index)
	{
		if (!listBall[index].isDone)
		{
			T160.M1826().M1836();
			long num = ((typePrice != 0) ? T13.M113().M251() : T13.M113().xu);
			if (M341() >= numTicket && num < cost + price)
			{
				string s = mResources.not_enough_money_1 + " " + ((typePrice != 0) ? mResources.LUONG : mResources.XU);
				T54.info1.M762(s, 0);
			}
			else
			{
				indexSelect = index;
				listBall[indexSelect].yTo = yTo + T137.M1522(-3, 3);
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
					T160.M1826().M1835();
					T13.M113().M172(T54.sks[13], 0);
					timeKame = T51.timeNow + T137.M1522(2000, 3000);
				}
			}
			else if (yP == T51.hh / 3)
			{
				T146.M1594().M1740(typePrice, 0);
			}
		}
		else
		{
			T54.M559().isRongThanXuatHien = false;
			T54.M559().switchToMe();
		}
	}

	public override void paint(T99 g)
	{
		try
		{
			T54.M559().paint(g);
			g.M918(-T54.cmx, -T54.cmy);
			g.M918(0, T51.transY);
			for (int i = 0; i < listBall.Length; i++)
			{
				if (listBall[i].isPaint && listBall[i].y > listBall[i].yTo - 20)
				{
					g.M948(T174.bong, listBall[i].x, listBall[i].yTo + 7, T99.VCENTER | T99.HCENTER);
				}
			}
			for (int j = 0; j < listBall.Length; j++)
			{
				if (listBall[j].isPaint)
				{
					T157.M1785(g, listBall[j].idImg, listBall[j].x, listBall[j].y, 0, T99.VCENTER | T99.HCENTER);
				}
			}
			if (isKame)
			{
				if (fraImgKame != null)
				{
					int num = T13.M113().cx - fraImgKame.frameWidth - 28;
					for (int k = 0; k < T51.w / fraImgKame.frameWidth + 1; k++)
					{
						fraImgKame.M439(frame, num - k * (fraImgKame.frameWidth - 1), T13.M113().cy - fraImgKame.frameHeight / 2 - 12 + 2, 0, 0, g);
					}
				}
				if (fraImgKame_1 != null)
				{
					int cx = T13.M113().cx;
					int frameWidth = fraImgKame_1.frameWidth;
					fraImgKame_1.M439(frame, cx - frameWidth - 10 - 5, T13.M113().cy - fraImgKame_1.frameHeight / 2 - 12, 0, 0, g);
				}
			}
			T54.M631(g);
			int num2 = 240;
			int num3 = T51.w - 240;
			int num4 = 15;
			g.M933(13524492);
			g.M932(num3, 0, 240, 15);
			g.M948(T126.imgXu, num3 + 11, 8, 3);
			g.M948(T126.imgLuong, num3 + 90, 7, 3);
			T98.tahoma_7_yellow.M902(g, T13.M113().xuStr + string.Empty, num3 + 24, 2, T98.LEFT, T98.tahoma_7_grey);
			T98.tahoma_7_yellow.M902(g, T13.M113().luongStr + string.Empty, num3 + 100, 2, T98.LEFT, T98.tahoma_7_grey);
			g.M948(T126.imgLuongKhoa, num3 + 150, 8, 3);
			T98.tahoma_7_yellow.M902(g, T13.M113().luongKhoaStr + string.Empty, num3 + 160, 2, T98.LEFT, T98.tahoma_7_grey);
			g.M948(T126.imgTicket, num3 + 200, 8, 3);
			T98.tahoma_7_yellow.M902(g, numTicket + string.Empty, num3 + 210, 2, T98.LEFT, T98.tahoma_7_grey);
			if (step < 4)
			{
				int num5 = num2 / 2 + 20;
				int num6 = T51.w - num5;
				g.M933(11837316);
				g.M932(num6, num4, num5, 15);
				if (typePrice == 0)
				{
					g.M948(T126.imgXu, num6 + 21, num4 + 8, 3);
				}
				else
				{
					g.M948(T126.imgLuongKhoa, num6 + 21, num4 + 7, 3);
					g.M948(T126.imgLuong, num6 + 18, num4 + 7, 3);
				}
				T98.tahoma_7_red.M902(g, " -" + cost, num6 + 30, num4 + 2, T98.LEFT, T98.tahoma_7_grey);
				g.M948(T126.imgTicket, num6 + 80, num4 + 7, 3);
				T98.tahoma_7_red.M902(g, " -" + M341(), num6 + 90, num4 + 2, T98.LEFT, T98.tahoma_7_grey);
			}
			g.M948(T54.imgSkill, xSkill[0], ySkill, 0);
			if (indexSkillSelect == 0)
			{
				g.M948(T54.imgSkill2, xSkill[0], ySkill, 0);
			}
			if (step < 3)
			{
				T157.M1785(g, 540, xSkill[0] + 14, ySkill + 14, 0, T163.VCENTER_HCENTER);
			}
			else
			{
				g.M948(imgReplay, xSkill[0] + 14 - 10, ySkill + 14 - 10, 0);
			}
			g.M948(T54.imgSkill, xSkill[1], ySkill, 0);
			if (indexSkillSelect == 1)
			{
				g.M948(T54.imgSkill2, xSkill[1], ySkill, 0);
			}
			g.M948(imgX, xSkill[1] + 14 - 10, ySkill + 14 - 10, 0);
			if (step > 3)
			{
				T51.paintz.M1236(xP, yP, wP, hP, g);
				int num7 = T51.hw - idItem.Length * 30 / 2;
				for (int l = 0; l < idItem.Length; l++)
				{
					T157.M1785(g, idItem[l], num7 + 5 + l * 30, yP + 10, 0, 0);
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
		T54.isPaintOther = true;
		T54.M559().isRongThanXuatHien = true;
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
		for (int i = 0; i < T13.M113().arrItemBag.Length; i++)
		{
			if (T13.M113().arrItemBag[i] != null && T13.M113().arrItemBag[i].template.id == idTicket)
			{
				numTicket = T13.M113().arrItemBag[i].quantity;
				break;
			}
		}
	}
}
