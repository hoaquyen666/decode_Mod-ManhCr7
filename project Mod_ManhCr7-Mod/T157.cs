using System;
using N5.N6.N9;

public class T157
{
	public static int[][] smallImg;

	public static T157 instance;

	public static T60[] imgbig;

	public static T211[] imgNew;

	public static T117 vKeys = new T117();

	public static T60 imgEmpty = null;

	public static sbyte[] newSmallVersion;

	public static int smallCount;

	public static short maxSmall;

	public T157()
	{
		M1782();
	}

	public static void M1777()
	{
		if (imgbig == null)
		{
			imgbig = new T60[5]
			{
				T51.M502("/img/Big0.png"),
				T51.M502("/img/Big1.png"),
				T51.M502("/img/Big2.png"),
				T51.M502("/img/Big3.png"),
				T51.M502("/img/Big4.png")
			};
		}
	}

	public static void M1778()
	{
		imgbig = null;
		T110.M1062();
	}

	public static void M1779()
	{
		imgEmpty = T60.M711(new int[1], 1, 1, bl: true);
	}

	public static void M1780()
	{
		instance = null;
		instance = new T157();
	}

	public void M1781(byte[] data)
	{
	}

	public void M1782()
	{
		int num = 0;
		try
		{
			T28 t = new T28(T138.M1535("NR_image"));
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
			T24.M330("Loi readImage: " + ex.ToString() + "i= " + num);
		}
	}

	public static void M1783()
	{
	}

	public static void M1784(int id)
	{
		T137.M1513("is request =" + id + " zoom=" + T99.zoomLevel);
		if (T99.zoomLevel == 1)
		{
			T60 t = T51.M503("/SmallImage/Small" + id + ".png");
			if (t != null)
			{
				imgNew[id] = new T211(t, id);
				return;
			}
			imgNew[id] = new T211(imgEmpty, id);
			T146.M1594().M1701(id);
			return;
		}
		T60 t2 = T51.M503("/SmallImage/Small" + id + ".png");
		if (t2 != null)
		{
			imgNew[id] = new T211(t2, id);
			return;
		}
		bool flag = false;
		sbyte[] array = T138.M1535(T99.zoomLevel + "Small" + id);
		if (array != null)
		{
			if (newSmallVersion != null && array.Length % 127 != newSmallVersion[id])
			{
				flag = true;
			}
			if (!flag)
			{
				T60 t3 = T60.M708(array, 0, array.Length);
				if (t3 != null)
				{
					imgNew[id] = new T211(t3, id);
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
			imgNew[id] = new T211(imgEmpty, id);
			T146.M1594().M1701(id);
		}
	}

	public static void M1785(T99 g, int id, int x, int y, int transform, int anchor)
	{
		if (imgbig == null)
		{
			T211 t = imgNew[id];
			if (t == null)
			{
				M1784(id);
			}
			else
			{
				g.M972(t, 0, 0, T99.M958(t.img), T99.M959(t.img), transform, x, y, anchor);
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
			T211 t2 = imgNew[id];
			if (t2 == null)
			{
				M1784(id);
			}
			else
			{
				t2.M2313(g, transform, x, y, anchor);
			}
		}
		else if (T51.currentScreen != T54.M559())
		{
			T211 t3 = imgNew[id];
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

	public static void M1786(T99 g, int id, int f, int x, int y, int w, int h, int transform, int anchor)
	{
		if (imgbig == null)
		{
			T211 t = imgNew[id];
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
				T211 t2 = imgNew[id];
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
				T211 t3 = imgNew[id];
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
		else if (T51.currentScreen != T54.M559())
		{
			T211 t4 = imgNew[id];
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
		if (T51.gameTick % 1000 != 0)
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
		if (num > 200 && T51.lowGraphic)
		{
			imgNew = new T211[maxSmall];
		}
	}
}
