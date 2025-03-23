using System;

public class T32
{
	public int effId;

	public int typeEff;

	public int indexFrom;

	public int indexTo;

	public bool isNearPlayer;

	public const int NEAR_PLAYER = 0;

	public const int LOOP_NORMAL = 1;

	public const int LOOP_TRANS = 2;

	public const int BACKGROUND = 3;

	public const int CHAR = 4;

	public const int FIRE_TD = 0;

	public const int BIRD = 1;

	public const int FIRE_NAMEK = 2;

	public const int FIRE_SAYAI = 3;

	public const int FROG = 5;

	public const int CA = 4;

	public const int ECH = 6;

	public const int TACKE = 7;

	public const int RAN = 8;

	public const int KHI = 9;

	public const int GACON = 10;

	public const int DANONG = 11;

	public const int DANBUOM = 12;

	public const int QUA = 13;

	public const int THIENTHACH = 14;

	public const int CAVOI = 15;

	public const int NAM = 16;

	public const int RONGTHAN = 17;

	public const int BUOMBAY = 26;

	public const int KHUCGO = 27;

	public const int DOIBAY = 28;

	public const int CONMEO = 29;

	public const int LUATAT = 30;

	public const int ONGCONG = 31;

	public const int KHANGIA1 = 42;

	public const int KHANGIA2 = 43;

	public const int KHANGIA3 = 44;

	public const int KHANGIA4 = 45;

	public const int KHANGIA5 = 46;

	public T13 c;

	public int t;

	public int currFrame;

	public int x;

	public int y;

	public int loop;

	public int tLoop;

	public int tLoopCount;

	private bool isPaint = true;

	public int layer;

	public int isStand;

	public static T117 vEffData = new T117();

	public int trans;

	public static T117 lastEff = new T117();

	public static T117 newEff = new T117();

	private int[] khangia1 = new int[10] { 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

	private int[] khangia2 = new int[10] { 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 };

	private int[] khangia3 = new int[10] { 4, 4, 4, 4, 4, 5, 5, 5, 5, 5 };

	private int[] khangia4 = new int[10] { 6, 6, 6, 6, 6, 7, 7, 7, 7, 7 };

	private int[] khangia5 = new int[10] { 8, 8, 8, 8, 8, 9, 9, 9, 9, 9 };

	private bool isGetTime;

	public T32()
	{
	}//Error decoding local variables: Signature type sequence must have at least one element.


	public T32(int id, T13 c, int layer, int loop, int loopCount, sbyte isStand)
	{
		this.c = c;
		effId = id;
		this.layer = layer;
		this.loop = loop;
		tLoop = loopCount;
		this.isStand = isStand;
		if (M387(id) == null)
		{
			T36 t = new T36
			{
				ID = id
			};
			if (id >= 42 && id <= 46)
			{
				id = 106;
			}
			string text = "/x" + T99.zoomLevel + "/effectdata/" + id + "/data";
			if (T116.M1110(text) != null)
			{
				if (id > 100 && id < 200)
				{
					t.M396(text);
				}
				else
				{
					t.M395(text);
				}
				t.img = T51.M503("/effectdata/" + id + "/img.png");
			}
			else
			{
				T146.M1594().M1653((short)id);
			}
			M386(t);
		}
		indexFrom = -1;
		indexTo = -1;
		trans = -1;
		typeEff = 4;
	}

	public T32(int id, int x, int y, int layer, int loop, int loopCount)
	{
		this.x = x;
		this.y = y;
		effId = id;
		this.layer = layer;
		this.loop = loop;
		tLoop = loopCount;
		if (M387(id) == null)
		{
			T36 t = new T36
			{
				ID = id
			};
			if (id >= 42 && id <= 46)
			{
				id = 106;
			}
			string text = "/x" + T99.zoomLevel + "/effectdata/" + id + "/data";
			if (T116.M1110(text) != null)
			{
				if (id > 100 && id < 200)
				{
					t.M396(text);
				}
				else
				{
					t.M395(text);
				}
				t.img = T51.M503("/effectdata/" + id + "/img.png");
			}
			else
			{
				T146.M1594().M1653((short)id);
			}
			M386(t);
			lastEff.M1111(effId + string.Empty);
		}
		indexFrom = -1;
		indexTo = -1;
		typeEff = 1;
		if (!M388(effId + string.Empty))
		{
			newEff.M1111(effId + string.Empty);
		}
	}

	public static void M385(int id)
	{
		for (int i = 0; i < vEffData.M1113(); i++)
		{
			T36 t = (T36)vEffData.M1114(i);
			if (t.ID == id)
			{
				vEffData.M1119(t);
				break;
			}
		}
	}

	public static void M386(T36 eff)
	{
		vEffData.M1111(eff);
		if (T174.mapID != 130 && vEffData.M1113() > 10)
		{
			for (int i = 0; i < 5; i++)
			{
				vEffData.M1118(0);
			}
		}
	}

	public static T36 M387(int id)
	{
		for (int i = 0; i < vEffData.M1113(); i++)
		{
			T36 t = (T36)vEffData.M1114(i);
			if (t.ID == id)
			{
				return t;
			}
		}
		return null;
	}

	public static bool M388(string id)
	{
		for (int i = 0; i < newEff.M1113(); i++)
		{
			if (((string)newEff.M1114(i)).Equals(id))
			{
				return true;
			}
		}
		return false;
	}

	public bool M389()
	{
		if (!isPaint)
		{
			return false;
		}
		return true;
	}

	public void M390(T99 g, int xLayer, int yLayer)
	{
		if (M389() && M387(effId).img != null)
		{
			M387(effId).M401(g, currFrame, x + xLayer, y + yLayer, trans, layer);
		}
	}

	public void M391()
	{
		if (effId == 42)
		{
			currFrame = khangia1[t];
		}
		if (effId == 43)
		{
			currFrame = khangia2[t];
		}
		if (effId == 44)
		{
			currFrame = khangia3[t];
		}
		if (effId == 45)
		{
			currFrame = khangia4[t];
		}
		if (effId == 46)
		{
			currFrame = khangia5[t];
		}
		t++;
		if (t > khangia1.Length - 1)
		{
			t = 0;
		}
	}

	public void M392(T99 g)
	{
		if (M389() && M387(effId) != null && M387(effId).img != null)
		{
			M387(effId).M401(g, currFrame, x, y, trans, layer);
		}
	}

	public void M393()
	{
		try
		{
			if (effId >= 42 && effId <= 46)
			{
				M391();
			}
			else
			{
				if (M387(effId) == null || M387(effId).img == null)
				{
					return;
				}
				if (M387(effId).arrFrame != null)
				{
					if (!isGetTime)
					{
						isGetTime = true;
						int num = M387(effId).arrFrame.Length - 1;
						if (num > 0 && typeEff != 1)
						{
							t = T137.M1522(0, num);
						}
						if (typeEff == 0)
						{
							t = T137.M1522(indexFrom, indexTo);
						}
					}
					switch (typeEff)
					{
					case 0:
						if (T137.M1530(x - 50, y - 50, 100, 100, T13.M113().cx, T13.M113().cy) && t > indexFrom && t < indexTo)
						{
							if (t < indexTo)
							{
								t = indexTo;
							}
							isNearPlayer = true;
						}
						if (!isNearPlayer)
						{
							t++;
							if (t == indexTo)
							{
								t = indexFrom;
							}
						}
						else if (t < M387(effId).arrFrame.Length)
						{
							t++;
						}
						break;
					case 2:
						if (t < M387(effId).arrFrame.Length)
						{
							t++;
						}
						tLoopCount++;
						if (tLoopCount == tLoop)
						{
							tLoopCount = 0;
							trans = T137.M1522(0, 2);
						}
						break;
					case 1:
					case 3:
						if (t < M387(effId).arrFrame.Length)
						{
							t++;
						}
						break;
					case 4:
						x = c.cx;
						y = c.cy;
						if (t < M387(effId).arrFrame.Length)
						{
							t++;
						}
						break;
					}
					if (t == M387(effId).arrFrame.Length / 2 && (effId == 62 || effId == 63 || effId == 64 || effId == 65))
					{
						T160.M1878(x, y, T160.FIREWORK, T160.volume);
					}
					if (t <= M387(effId).arrFrame.Length - 1)
					{
						currFrame = M387(effId).arrFrame[t];
					}
				}
				if (t >= M387(effId).arrFrame.Length - 1)
				{
					if (typeEff == 0 || typeEff == 3)
					{
						isPaint = false;
					}
					if (tLoop == -1)
					{
						T31.vEff.M1119(this);
					}
					if (typeEff == 2)
					{
						t = 0;
						return;
					}
					if (typeEff == 1 && loop == 1)
					{
						isPaint = false;
					}
					if (typeEff == 4)
					{
						if (loop == -1)
						{
							t = 0;
							return;
						}
						tLoopCount++;
						if (tLoopCount == tLoop)
						{
							tLoopCount = 0;
							loop--;
							t = 0;
							if (loop == 0)
							{
								c.M247(0, effId);
							}
						}
						return;
					}
					isNearPlayer = false;
					if (loop == -1)
					{
						tLoopCount++;
						if (tLoopCount == tLoop)
						{
							tLoopCount = 0;
							t = 0;
							if (tLoop > 1)
							{
								trans = T137.M1522(0, 2);
							}
						}
						return;
					}
					tLoopCount++;
					if (tLoopCount == tLoop)
					{
						tLoopCount = 0;
						loop--;
						t = 0;
						if (loop == 0)
						{
							T31.vEff.M1119(this);
						}
					}
				}
				else
				{
					isPaint = true;
				}
			}
		}
		catch (Exception)
		{
			T31.vEff.M1119(this);
		}
	}
}
