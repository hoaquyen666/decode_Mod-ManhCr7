using System;
using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using Utilities;
using Xmap;

public class SmallImage
{
	public static int[][] smallImg;

	public static SmallImage instance;

	public static Image[] imgbig;

	public static Small[] imgNew;

	public static MyVector vKeys = new MyVector();

	public static Image imgEmpty = null;

	public static sbyte[] newSmallVersion;

	public static int smallCount;

	public static short maxSmall;

	public SmallImage()
	{
		M1782();
	}

	public static void M1777()
	{
		if (imgbig == null)
		{
			imgbig = new Image[5]
			{
				GameCanvas.M502("/img/Big0.png"),
				GameCanvas.M502("/img/Big1.png"),
				GameCanvas.M502("/img/Big2.png"),
				GameCanvas.M502("/img/Big3.png"),
				GameCanvas.M502("/img/Big4.png")
			};
		}
	}

	public static void M1778()
	{
		imgbig = null;
		mSystem.M1062();
	}

	public static void M1779()
	{
		imgEmpty = Image.M711(new int[1], 1, 1, bl: true);
	}

	public static void M1780()
	{
		instance = null;
		instance = new SmallImage();
	}

	public void M1781(byte[] data)
	{
	}

	public void M1782()
	{
		int num = 0;
		try
		{
			DataInputStream t = new DataInputStream(Rms.M1535("NR_image"));
			short num2 = t.M353();
			smallImg = new int[num2][];
			for (int i = 0; i < smallImg.Length; i++)
			{
				smallImg[i] = new int[5];
			}
			for (int j = 0; j < num2; j++)
			{
				num++;
				smallImg[j][0] = t.M363();
				smallImg[j][1] = t.M353();
				smallImg[j][2] = t.M353();
				smallImg[j][3] = t.M353();
				smallImg[j][4] = t.M353();
			}
		}
		catch (Exception ex)
		{
			Cout.M330("Loi readImage: " + ex.ToString() + "i= " + num);
		}
	}

	public static void M1783()
	{
	}

	public static void M1784(int id)
	{
		Res.M1513("is request =" + id + " zoom=" + mGraphics.zoomLevel);
		if (mGraphics.zoomLevel == 1)
		{
			Image t = GameCanvas.M503("/SmallImage/Small" + id + ".png");
			if (t != null)
			{
				imgNew[id] = new Small(t, id);
				return;
			}
			imgNew[id] = new Small(imgEmpty, id);
			Service.M1594().M1701(id);
			return;
		}
		Image t2 = GameCanvas.M503("/SmallImage/Small" + id + ".png");
		if (t2 != null)
		{
			imgNew[id] = new Small(t2, id);
			return;
		}
		bool flag = false;
		sbyte[] array = Rms.M1535(mGraphics.zoomLevel + "Small" + id);
		if (array != null)
		{
			if (newSmallVersion != null && array.Length % 127 != newSmallVersion[id])
			{
				flag = true;
			}
			if (!flag)
			{
				Image t3 = Image.M708(array, 0, array.Length);
				if (t3 != null)
				{
					imgNew[id] = new Small(t3, id);
				}
				else
				{
					flag = true;
				}
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			imgNew[id] = new Small(imgEmpty, id);
			Service.M1594().M1701(id);
		}
	}

	public static void M1785(mGraphics g, int id, int x, int y, int transform, int anchor)
	{
		if (imgbig == null)
		{
			Small t = imgNew[id];
			if (t == null)
			{
				M1784(id);
			}
			else
			{
				g.M972(t, 0, 0, mGraphics.M958(t.img), mGraphics.M959(t.img), transform, x, y, anchor);
			}
		}
		else if (smallImg != null)
		{
			if (id < smallImg.Length && smallImg[id][1] < 256 && smallImg[id][3] < 256 && smallImg[id][2] < 256 && smallImg[id][4] < 256)
			{
				if (imgbig[smallImg[id][0]] != null)
				{
					g.M940(imgbig[smallImg[id][0]], smallImg[id][1], smallImg[id][2], smallImg[id][3], smallImg[id][4], transform, x, y, anchor);
				}
				return;
			}
			Small t2 = imgNew[id];
			if (t2 == null)
			{
				M1784(id);
			}
			else
			{
				t2.M2313(g, transform, x, y, anchor);
			}
		}
		else if (GameCanvas.currentScreen != GameScr.M559())
		{
			Small t3 = imgNew[id];
			if (t3 == null)
			{
				M1784(id);
			}
			else
			{
				t3.M2313(g, transform, x, y, anchor);
			}
		}
	}

	public static void M1786(mGraphics g, int id, int f, int x, int y, int w, int h, int transform, int anchor)
	{
		if (imgbig == null)
		{
			Small t = imgNew[id];
			if (t == null)
			{
				M1784(id);
			}
			else
			{
				g.M940(t.img, 0, f * w, w, h, transform, x, y, anchor);
			}
		}
		else if (smallImg != null)
		{
			if (id < smallImg.Length && smallImg[id] != null && smallImg[id][1] < 256 && smallImg[id][3] < 256 && smallImg[id][2] < 256 && smallImg[id][4] < 256)
			{
				if (smallImg[id][0] != 4 && imgbig[smallImg[id][0]] != null)
				{
					g.M940(imgbig[smallImg[id][0]], 0, f * w, w, h, transform, x, y, anchor);
					return;
				}
				Small t2 = imgNew[id];
				if (t2 == null)
				{
					M1784(id);
				}
				else
				{
					t2.M2314(g, transform, f, x, y, w, h, anchor);
				}
			}
			else
			{
				Small t3 = imgNew[id];
				if (t3 == null)
				{
					M1784(id);
				}
				else
				{
					t3.M2314(g, transform, f, x, y, w, h, anchor);
				}
			}
		}
		else if (GameCanvas.currentScreen != GameScr.M559())
		{
			Small t4 = imgNew[id];
			if (t4 == null)
			{
				M1784(id);
			}
			else
			{
				t4.M2314(g, transform, f, x, y, w, h, anchor);
			}
		}
	}

	public static void M1787()
	{
		int num = 0;
		if (GameCanvas.gameTick % 1000 != 0)
		{
			return;
		}
		for (int i = 0; i < imgNew.Length; i++)
		{
			if (imgNew[i] != null)
			{
				num++;
				imgNew[i].M2316();
				smallCount++;
			}
		}
		if (num > 200 && GameCanvas.lowGraphic)
		{
			imgNew = new Small[maxSmall];
		}
	}
}
