public class BackgroundEffect
{
	public static MyVector vBgEffect = new MyVector();

	private int[] x;

	private int[] y;

	private int[] vx;

	private int[] vy;

	public static int[] wP;

	private int num;

	private int xShip;

	private int yShip;

	private int way;

	private int trans;

	private int frameFire;

	private int tFire;

	private int tStart;

	private int speed;

	private bool isFly;

	public static Image imgSnow;

	public static Image imgHatMua;

	public static Image imgMua1;

	public static Image imgMua2;

	public static Image imgSao;

	private static Image imgLacay;

	private static Image imgShip;

	private static Image imgFire1;

	private static Image imgFire2;

	private int[] type;

	private int sum;

	public int typeEff;

	public int xx;

	public int waterY;

	private bool[] isRainEffect;

	private int[] frame;

	private int[] t;

	private bool[] activeEff;

	private int yWater;

	private int colorWater;

	public const int TYPE_MUA = 0;

	public const int TYPE_LATRAIDAT_1 = 1;

	public const int TYPE_LATRAIDAT_2 = 2;

	public const int TYPE_SAMSET = 3;

	public const int TYPE_SAO = 4;

	public const int TYPE_LANAMEK_1 = 5;

	public const int TYPE_LASAYAI_1 = 6;

	public const int TYPE_LANAMEK_2 = 7;

	public const int TYPE_SHIP_TRAIDAT = 8;

	public const int TYPE_HANHTINH = 9;

	public const int TYPE_WATER = 10;

	public const int TYPE_SNOW = 11;

	public const int TYPE_MUA_FRONT = 12;

	public const int TYPE_CLOUD = 13;

	public const int TYPE_FOG = 14;

	public static Image water1 = GameCanvas.M503("/mainImage/myTexture2dwater1.png");

	public static Image water2 = GameCanvas.M503("/mainImage/myTexture2dwater2.png");

	public static Image imgChamTron1;

	public static Image imgChamTron2;

	public static bool isFog;

	public static bool isPaintFar;

	public static int nCloud;

	public static Image imgCloud1;

	public static Image imgFog;

	public static int cloudw;

	public static int xfog;

	public static int yfog;

	public static int fogw;

	private int[] dem = new int[6] { 0, 1, 2, 1, 0, 0 };

	private int[] tick;

	public BackgroundEffect(int typeS)
	{
		isFog = true;
		M41();
		typeEff = typeS;
		switch (typeEff)
		{
		case 3:
			GameCanvas.isBoltEff = true;
			break;
		case 4:
		{
			sum = Res.M1522(5, 10);
			if (imgSao == null)
			{
				imgSao = GameCanvas.M502("/bg/sao.png");
			}
			x = new int[sum];
			y = new int[sum];
			frame = new int[sum];
			t = new int[sum];
			tick = new int[sum];
			for (int k = 0; k < sum; k++)
			{
				x[k] = Res.M1522(0, GameCanvas.w);
				y[k] = Res.M1522(0, 50);
				if (k % 2 == 0)
				{
					tick[k] = 0;
				}
				else if (k % 3 == 0)
				{
					tick[k] = 1;
				}
				else if (k % 4 == 0)
				{
					tick[k] = 2;
				}
				else
				{
					tick[k] = 3;
				}
				t[k] = Res.M1522(0, 10);
			}
			break;
		}
		case 8:
			tStart = Res.M1522(100, 300);
			if (imgShip == null)
			{
				imgShip = GameCanvas.M502("/bg/ship.png");
			}
			if (imgFire1 == null)
			{
				imgFire1 = GameCanvas.M502("/bg/fire1.png");
			}
			if (imgFire2 == null)
			{
				imgFire2 = GameCanvas.M502("/bg/fire2.png");
			}
			isFly = false;
			M46();
			break;
		case 9:
		{
			if (imgChamTron1 == null)
			{
				imgChamTron1 = GameCanvas.M502("/bg/cham-tron1.png");
			}
			if (imgChamTron2 == null)
			{
				imgChamTron2 = GameCanvas.M502("/bg/cham-tron2.png");
			}
			this.num = 20;
			x = new int[this.num];
			y = new int[this.num];
			wP = new int[this.num];
			vx = new int[this.num];
			for (int i = 0; i < this.num; i++)
			{
				x[i] = Res.M1529(Res.M1522(0, GameCanvas.w));
				y[i] = Res.M1529(Res.M1522(10, 80));
				wP[i] = Res.M1529(Res.M1522(1, 3));
				vx[i] = wP[i];
			}
			break;
		}
		case 10:
		{
			this.num = 30;
			x = new int[this.num];
			y = new int[this.num];
			wP = new int[this.num];
			vx = new int[this.num];
			int num = 0;
			for (int j = 0; j < this.num; j++)
			{
				x[j] = Res.M1529(Res.M1522(0, GameCanvas.w)) + GameScr.cmx;
				num++;
				if (num > this.num / 2)
				{
					y[j] = Res.M1529(Res.M1522(20, 60));
					wP[j] = 10;
				}
				else
				{
					y[j] = Res.M1529(Res.M1522(0, 20));
					wP[j] = 7;
				}
				vx[j] = wP[j] / 2 - 2;
			}
			break;
		}
		case 1:
		case 2:
		case 5:
		case 6:
		case 7:
		case 11:
		{
			if (typeEff == 1)
			{
				imgLacay = GameCanvas.M502("/bg/lacay.png");
			}
			if (typeEff == 2)
			{
				imgLacay = GameCanvas.M502("/bg/lacay2.png");
			}
			if (typeEff == 5)
			{
				imgLacay = GameCanvas.M502("/bg/lacay3.png");
			}
			if (typeEff == 6)
			{
				imgLacay = GameCanvas.M502("/bg/lacay4.png");
			}
			if (typeEff == 7)
			{
				imgLacay = GameCanvas.M502("/bg/lacay5.png");
			}
			if (typeEff == 11)
			{
				imgLacay = GameCanvas.M502("/bg/tuyet.png");
			}
			sum = Res.M1522(15, 25);
			if (typeEff == 11)
			{
				sum = 100;
			}
			x = new int[sum];
			y = new int[sum];
			vx = new int[sum];
			vy = new int[sum];
			t = new int[sum];
			frame = new int[sum];
			activeEff = new bool[sum];
			for (int m = 0; m < sum; m++)
			{
				x[m] = Res.M1522(-10, TileMap.pxw + 10);
				y[m] = Res.M1522(0, TileMap.pxh);
				frame[m] = Res.M1522(0, 1);
				t[m] = Res.M1522(0, 1);
				vx[m] = Res.M1522(-3, 3);
				vy[m] = Res.M1522(1, 4);
				if (typeEff == 11)
				{
					frame[m] = Res.M1522(0, 2);
					vx[m] = Res.M1529(Res.M1522(1, 3));
					vy[m] = Res.M1529(Res.M1522(1, 3));
				}
			}
			break;
		}
		case 0:
		case 12:
		{
			if (imgHatMua == null)
			{
				imgHatMua = GameCanvas.M502("/bg/mua.png");
			}
			if (imgMua1 == null)
			{
				imgMua1 = GameCanvas.M502("/bg/mua1.png");
			}
			if (imgMua2 == null)
			{
				imgMua2 = GameCanvas.M502("/bg/mua2.png");
			}
			sum = Res.M1522(GameCanvas.w / 3, GameCanvas.w / 2);
			x = new int[sum];
			y = new int[sum];
			vx = new int[sum];
			vy = new int[sum];
			type = new int[sum];
			t = new int[sum];
			frame = new int[sum];
			isRainEffect = new bool[sum];
			activeEff = new bool[sum];
			for (int l = 0; l < sum; l++)
			{
				y[l] = Res.M1522(-10, GameCanvas.h + 100) + GameScr.cmy;
				x[l] = Res.M1522(-10, GameCanvas.w + 300) + GameScr.cmx;
				t[l] = Res.M1522(0, 1);
				vx[l] = -12;
				vy[l] = 12;
				type[l] = Res.M1522(1, 3);
				isRainEffect[l] = false;
				if (type[l] == 2 && l % 2 == 0)
				{
					isRainEffect[l] = true;
				}
				activeEff[l] = false;
				frame[l] = Res.M1522(1, 2);
			}
			break;
		}
		case 13:
			if (Res.M1529(Res.M1522(0, 2)) == 0)
			{
				if (Res.M1529(Res.M1522(0, 2)) == 0)
				{
					isPaintFar = true;
				}
				else
				{
					isPaintFar = false;
				}
				nCloud = Res.M1529(Res.M1522(2, 5));
				M41();
			}
			break;
		case 14:
			if (Res.M1529(Res.M1522(0, 2)) == 0)
			{
				isFog = true;
				M41();
			}
			break;
		}
	}

	public static void M39()
	{
		TileMap.yWater = 0;
	}

	public static bool M40()
	{
		for (int i = 0; i < vBgEffect.M1113(); i++)
		{
			BackgroundEffect t = (BackgroundEffect)vBgEffect.M1114(i);
			if (t.typeEff == 0 || t.typeEff == 12)
			{
				return true;
			}
		}
		return false;
	}

	public static void M41()
	{
		if (mSystem.clientType == 1)
		{
			imgCloud1 = null;
			imgFog = null;
			return;
		}
		if (GameCanvas.lowGraphic)
		{
			imgCloud1 = null;
			imgFog = null;
			return;
		}
		if (nCloud > 0)
		{
			if (imgCloud1 == null)
			{
				imgCloud1 = GameCanvas.M503("/bg/fog1.png");
				cloudw = imgCloud1.M727();
			}
		}
		else
		{
			imgCloud1 = null;
		}
		if (!isFog)
		{
			imgFog = null;
			return;
		}
		if (imgFog == null)
		{
			imgFog = GameCanvas.M503("/bg/fog0.png");
		}
		fogw = 287;
	}

	public static void M42()
	{
		if (mSystem.clientType == 1 || GameCanvas.lowGraphic || nCloud <= 0)
		{
			return;
		}
		int num = ((GameCanvas.currentScreen != GameScr.M559()) ? (GameScr.cmx + GameCanvas.w) : TileMap.pxw);
		for (int i = 0; i < nCloud; i++)
		{
			GameCanvas.cloudX[i] -= i + 1;
			if (GameCanvas.cloudX[i] < -cloudw)
			{
				GameCanvas.cloudX[i] = num + 100;
			}
		}
	}

	public static void M43()
	{
		if (mSystem.clientType != 1 && !GameCanvas.lowGraphic && isFog)
		{
			xfog--;
			if (xfog < -fogw)
			{
				xfog = 0;
			}
		}
	}

	public static void M44(mGraphics g)
	{
		if (mSystem.clientType == 1 || GameCanvas.lowGraphic || nCloud == 0 || imgCloud1 == null)
		{
			return;
		}
		for (int i = 0; i < nCloud; i++)
		{
			int num = i;
			if (num > 3)
			{
				num = 3;
			}
			if (num == 0)
			{
				num = 1;
			}
			g.M948(imgCloud1, GameCanvas.cloudX[i], GameCanvas.cloudY[i], 3);
		}
	}

	public static void M45(mGraphics g)
	{
		if (mSystem.clientType == 1 || GameCanvas.lowGraphic || !isFog || imgFog == null)
		{
			return;
		}
		for (int i = xfog; i < TileMap.pxw; i += fogw)
		{
			if (i >= GameScr.cmx - fogw)
			{
				g.M949(imgFog, i, yfog, 0);
			}
		}
	}

	private void M46()
	{
		int cmx = GameScr.cmx;
		int cmy = GameScr.cmy;
		way = Res.M1522(1, 3);
		isFly = false;
		speed = Res.M1522(3, 5);
		if (way == 1)
		{
			xShip = -50;
			yShip = Res.M1522(cmy, GameCanvas.h - 100 + cmy);
			trans = 0;
		}
		else if (way == 2)
		{
			xShip = TileMap.pxw + 50;
			yShip = Res.M1522(cmy, GameCanvas.h - 100 + cmy);
			trans = 2;
		}
		else if (way == 3)
		{
			xShip = Res.M1522(50 + cmx, GameCanvas.w - 50 + cmx);
			yShip = -50;
			trans = ((Res.M1522(0, 2) != 0) ? 2 : 0);
		}
		else if (way == 4)
		{
			xShip = Res.M1522(50 + cmx, GameCanvas.w - 50 + cmx);
			yShip = TileMap.pxh + 50;
			trans = ((Res.M1522(0, 2) != 0) ? 2 : 0);
		}
	}

	public void M47(mGraphics g)
	{
		if (typeEff == 10)
		{
			g.M933(colorWater);
			for (int i = 0; i < num; i++)
			{
				g.M948((i >= num / 2) ? water1 : water2, x[i], y[i] + yWater, 0);
			}
		}
	}

	public void M48(mGraphics g)
	{
		g.M918(-g.M920(), -g.M921());
		if (typeEff == 4)
		{
			for (int i = 0; i < sum; i++)
			{
				g.M940(imgSao, 0, 16 * frame[i], 16, 16, 0, x[i], y[i], 0);
			}
		}
		if (typeEff == 9)
		{
			g.M933(16777215);
			for (int j = 0; j < num; j++)
			{
				g.M948((wP[j] != 1) ? imgChamTron2 : imgChamTron1, x[j], y[j], 3);
			}
		}
	}

	public void M49()
	{
		switch (typeEff)
		{
		case 4:
		{
			for (int m = 0; m < sum; m++)
			{
				this.t[m]++;
				if (this.t[m] > 10)
				{
					tick[m]++;
					this.t[m] = 0;
					if (tick[m] > 5)
					{
						tick[m] = 0;
					}
					frame[m] = dem[tick[m]];
				}
			}
			break;
		}
		case 8:
			tFire++;
			if (tFire == 3)
			{
				tFire = 0;
				frameFire++;
				if (frameFire > 1)
				{
					frameFire = 0;
				}
			}
			if (GameCanvas.gameTick % tStart == 0)
			{
				isFly = true;
			}
			if (!isFly)
			{
				break;
			}
			if (way == 1)
			{
				xShip += speed;
				if (xShip > TileMap.pxw + 50)
				{
					M46();
				}
			}
			else if (way == 2)
			{
				xShip -= speed;
				if (xShip < -50)
				{
					M46();
				}
			}
			else if (way == 3)
			{
				yShip += speed;
				if (yShip > TileMap.pxh + 50)
				{
					M46();
				}
			}
			else if (way == 4)
			{
				yShip -= speed;
				if (yShip < -50)
				{
					M46();
				}
			}
			break;
		case 9:
		{
			for (int j = 0; j < this.num; j++)
			{
				x[j] -= vx[j];
				if (x[j] < -vx[j])
				{
					wP[j] = Res.M1529(Res.M1522(1, 3));
					vx[j] = wP[j];
					x[j] = GameCanvas.w + vx[j];
				}
			}
			break;
		}
		case 10:
		{
			for (int n = 0; n < this.num; n++)
			{
				x[n] -= vx[n];
				if (x[n] < -vx[n] + GameScr.cmx)
				{
					x[n] = GameCanvas.w + vx[n] + GameScr.cmx;
				}
			}
			break;
		}
		case 1:
		case 2:
		case 5:
		case 6:
		case 7:
		case 11:
		{
			for (int k = 0; k < sum; k++)
			{
				if (k % 3 != 0 && TileMap.M1958(x[k], y[k] + ((TileMap.tileID == 15) ? 10 : 0), 2))
				{
					activeEff[k] = true;
				}
				if (k % 3 == 0 && y[k] > TileMap.pxh)
				{
					x[k] = Res.M1522(-10, TileMap.pxw + 50);
					y[k] = Res.M1522(-50, 0);
				}
				if (!activeEff[k])
				{
					for (int l = 0; l < Teleport.vTeleport.M1113(); l++)
					{
						Teleport t = (Teleport)Teleport.vTeleport.M1114(l);
						if (t != null && t.paintFire && x[k] < t.x + 80 && x[k] > t.x - 80 && y[k] < t.y + 80 && y[k] > t.y - 80)
						{
							x[k] += ((x[k] >= t.x) ? 10 : (-10));
						}
					}
					y[k] += vy[k];
					x[k] += vx[k];
					this.t[k]++;
					int num = ((typeEff != 11) ? 4 : 3);
					if (this.t[k] > ((typeEff == 2) ? 4 : 2))
					{
						if (typeEff != 11)
						{
							frame[k]++;
						}
						this.t[k] = 0;
						if (frame[k] > num - 1)
						{
							frame[k] = 0;
						}
					}
				}
				else
				{
					this.t[k]++;
					if (this.t[k] == 100)
					{
						this.t[k] = 0;
						x[k] = Res.M1522(-10, TileMap.pxw + 50);
						y[k] = Res.M1522(-50, 0);
						activeEff[k] = false;
					}
				}
			}
			break;
		}
		case 0:
		case 12:
		{
			for (int i = 0; i < sum; i++)
			{
				if (i % 3 != 0 && typeEff != 12 && TileMap.M1958(x[i], y[i] - GameCanvas.transY, 2))
				{
					activeEff[i] = true;
				}
				if (i % 3 == 0 && y[i] > GameCanvas.h + GameScr.cmy)
				{
					x[i] = Res.M1522(-10, GameCanvas.w + 300) + GameScr.cmx;
					y[i] = Res.M1522(-100, 0) + GameScr.cmy;
				}
				if (!activeEff[i])
				{
					y[i] += vy[i];
					x[i] += vx[i];
				}
				if (!activeEff[i])
				{
					continue;
				}
				this.t[i]++;
				if (this.t[i] > 2)
				{
					frame[i]++;
					this.t[i] = 0;
					if (frame[i] > 1)
					{
						frame[i] = 0;
						activeEff[i] = false;
						x[i] = Res.M1522(-10, GameCanvas.w + 300) + GameScr.cmx;
						y[i] = Res.M1522(-100, 0) + GameScr.cmy;
					}
				}
			}
			break;
		}
		case 13:
			M42();
			break;
		case 14:
			M43();
			break;
		case 3:
			break;
		}
	}

	public void M50(mGraphics g)
	{
		switch (typeEff)
		{
		case 1:
		case 2:
		case 5:
		case 6:
		case 7:
		case 11:
			M51(g, imgLacay);
			break;
		case 0:
		case 12:
		{
			for (int i = 0; i < sum; i++)
			{
				if (type[i] == 2 && x[i] >= GameScr.cmx && x[i] <= GameCanvas.w + GameScr.cmx && y[i] >= GameScr.cmy && y[i] <= GameCanvas.h + GameScr.cmy)
				{
					if (activeEff[i])
					{
						g.M940(imgHatMua, 0, 10 * frame[i], 13, 10, 0, x[i], y[i] - 10, 0);
					}
					else
					{
						g.M948(imgMua1, x[i], y[i], 0);
					}
				}
			}
			break;
		}
		case 13:
			if (!isPaintFar)
			{
				M44(g);
			}
			break;
		case 3:
		case 4:
		case 8:
		case 9:
		case 10:
			break;
		}
	}

	public void M51(mGraphics g, Image img)
	{
		int num = ((typeEff != 11) ? 4 : 3);
		for (int i = 0; i < sum; i++)
		{
			if (i % 3 == 0 && x[i] >= GameScr.cmx && x[i] <= GameCanvas.w + GameScr.cmx && y[i] >= GameScr.cmy && y[i] <= GameCanvas.h + GameScr.cmy)
			{
				g.M940(img, 0, mGraphics.M959(img) / num * frame[i], mGraphics.M958(img), mGraphics.M959(img) / num, 0, x[i], y[i], 0);
			}
		}
	}

	public void M52(mGraphics g, Image img)
	{
		int num = ((typeEff != 11) ? 4 : 3);
		for (int i = 0; i < sum; i++)
		{
			if (i % 3 != 0 && x[i] >= GameScr.cmx && x[i] <= GameCanvas.w + GameScr.cmx && y[i] >= GameScr.cmy && y[i] <= GameCanvas.h + GameScr.cmy)
			{
				g.M940(img, 0, mGraphics.M959(img) / num * frame[i], mGraphics.M958(img), mGraphics.M959(img) / num, 0, x[i], y[i], 0);
			}
		}
	}

	public void M53(mGraphics g)
	{
		switch (typeEff)
		{
		case 13:
			if (isPaintFar)
			{
				M44(g);
			}
			break;
		case 8:
			g.M940(imgShip, 0, 0, imgShip.M727(), imgShip.M728(), trans, xShip, yShip, 3);
			if (way != 1 && way != 2)
			{
				int num = ((trans != 0) ? (-11) : 11);
				g.M940(imgFire2, 0, frameFire * 18, 8, 18, trans, xShip + num, yShip + 22, 3);
			}
			else
			{
				int num2 = ((trans != 0) ? 25 : (-25));
				g.M940(imgFire1, 0, frameFire * 8, 20, 8, trans, xShip + num2, yShip + 5, 3);
			}
			break;
		}
	}

	public void M54(mGraphics g)
	{
		switch (typeEff)
		{
		case 0:
		{
			g.M933(10742731);
			for (int i = 0; i < sum; i++)
			{
				if (type[i] != 2 && x[i] >= GameScr.cmx && x[i] <= GameCanvas.w + GameScr.cmx && y[i] >= GameScr.cmy && y[i] <= GameCanvas.h + GameScr.cmy)
				{
					g.M948(imgMua2, x[i], y[i], 0);
				}
			}
			break;
		}
		case 1:
		case 2:
		case 5:
		case 6:
		case 7:
		case 11:
			M52(g, imgLacay);
			break;
		case 3:
		case 4:
		case 8:
		case 9:
		case 10:
			break;
		}
	}

	public static void M55(int id)
	{
		if (!GameCanvas.lowGraphic)
		{
			BackgroundEffect o = new BackgroundEffect(id);
			vBgEffect.M1111(o);
		}
	}

	public static void M56(int color, int yWater)
	{
		BackgroundEffect t = new BackgroundEffect(10);
		t.colorWater = color;
		t.yWater = yWater;
		vBgEffect.M1111(t);
	}

	public static void M57(mGraphics g)
	{
		for (int i = 0; i < vBgEffect.M1113(); i++)
		{
			((BackgroundEffect)vBgEffect.M1114(i)).M47(g);
		}
	}

	public static void M58(mGraphics g)
	{
		for (int i = 0; i < vBgEffect.M1113(); i++)
		{
			((BackgroundEffect)vBgEffect.M1114(i)).M53(g);
		}
	}

	public static void M59(mGraphics g)
	{
		for (int i = 0; i < vBgEffect.M1113(); i++)
		{
			((BackgroundEffect)vBgEffect.M1114(i)).M50(g);
		}
	}

	public static void M60(mGraphics g)
	{
		for (int i = 0; i < vBgEffect.M1113(); i++)
		{
			((BackgroundEffect)vBgEffect.M1114(i)).M48(g);
		}
	}

	public static void M61(mGraphics g)
	{
		for (int i = 0; i < vBgEffect.M1113(); i++)
		{
			((BackgroundEffect)vBgEffect.M1114(i)).M54(g);
		}
	}

	public static void M62()
	{
		for (int i = 0; i < vBgEffect.M1113(); i++)
		{
			((BackgroundEffect)vBgEffect.M1114(i)).M49();
		}
	}
}
