using System;

public class T43
{
	public const short End_String_Lose = 0;

	public const short End_String_Win = 1;

	public const short End_String_Draw = 2;

	public const short End_FireWork = 3;

	public const sbyte Lvlpaint_All = -1;

	public const sbyte Lvlpaint_Front = 0;

	public const sbyte Lvlpaint_Mid = 1;

	public const sbyte Lvlpaint_Behind = 2;

	private T117 VecEffEnd = new T117("EffectEnd VecEffEnd");

	public byte[] nFrame = new byte[10];

	public int id = -1;

	public int typeEffect;

	public int typeSub;

	public T49 fraImgEff;

	public T49 fraImgSubEff;

	public int fRemove;

	public int fMove;

	public int x;

	public int y;

	public int dir;

	public int dir_nguoc;

	public int levelPaint;

	public int f;

	public int vx;

	public int vy;

	public int x1000;

	public int y1000;

	public int vx1000;

	public int vy1000;

	public int dy_throw;

	public long time;

	public bool isRemove;

	public bool isAddSub;

	public static short[][] arrInfoEff = new short[9][]
	{
		new short[3] { 68, 264, 4 },
		new short[3] { 30, 120, 4 },
		new short[3] { 66, 280, 4 },
		new short[3] { 0, 0, 1 },
		new short[3] { 111, 68, 2 },
		new short[3] { 90, 68, 2 },
		new short[3] { 125, 68, 2 },
		new short[3] { 47, 282, 6 },
		new short[2]
	};

	public T43(int type, int subtype, int x, int y, int levelPaint, int dir)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		f = 0;
		typeEffect = type;
		typeSub = subtype;
		this.x = x;
		this.y = y;
		this.levelPaint = levelPaint;
		this.dir = dir;
		dir_nguoc = ((dir == 0) ? 2 : 0);
		time = T110.M1054();
		isAddSub = false;
		isRemove = false;
		M418();
	}

	public static T60 M416(int id)
	{
		if (id < 0)
		{
			return null;
		}
		string path = "/e/e_" + id + ".png";
		T60 result = null;
		try
		{
			result = T110.M1071(path);
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	public static void M417(int x, int y, int typeEffect)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			T137.M1523(3);
		}
		catch (Exception)
		{
		}
	}

	public void M418()
	{
		M417(x, y, typeEffect);
		switch (typeEffect)
		{
		case 3:
			M425();
			break;
		case 0:
		case 1:
		case 2:
			M422(typeEffect);
			break;
		}
	}

	public void M419()
	{
		f++;
		switch (typeEffect)
		{
		case 3:
			M426();
			break;
		case 0:
		case 1:
		case 2:
			M423();
			break;
		}
	}

	public void M420(T99 g)
	{
		try
		{
			if (!isRemove && f >= 0)
			{
				switch (typeEffect)
				{
				case 3:
					M427(g);
					break;
				case 0:
				case 1:
				case 2:
					M424(g);
					break;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void M421()
	{
		isRemove = true;
	}

	private void M422(int typeEffect)
	{
		switch (typeEffect)
		{
		case 0:
			fraImgEff = new T49(4);
			break;
		case 1:
			fraImgEff = new T49(5);
			break;
		case 2:
			fraImgEff = new T49(6);
			break;
		}
		fRemove = 100;
		dy_throw = T51.h / 3 + 10;
		vy = 10;
		y1000 = 0;
		isAddSub = false;
	}

	private void M423()
	{
		x = T51.hw;
		y = y1000;
		if (f > fRemove)
		{
			M421();
		}
		vy++;
		if (vy > 15)
		{
			vy = 15;
		}
		if (y1000 + vy < dy_throw)
		{
			y1000 += vy;
			return;
		}
		y1000 = dy_throw;
		if (!isAddSub)
		{
			isAddSub = true;
			if (typeSub != -1)
			{
				T54.M688(typeSub, 0, x, y, levelPaint, 0);
			}
		}
	}

	private void M424(T99 g)
	{
		if (fraImgEff != null)
		{
			fraImgEff.M439(f / 5 % fraImgEff.nFrame, x, y, 0, 33, g);
		}
	}

	private void M425()
	{
		int num = 0;
		num = T137.M1522(3, 5);
		fRemove = 90;
		for (int i = 0; i < num; i++)
		{
			T132 t = new T132();
			t.x = x + T137.M1524(4);
			t.y = y + T137.M1524(5);
			if (typeSub == 0)
			{
				t.fRe = T137.M1523(10);
				int num2 = 1;
				if (i % 2 == 0)
				{
					num2 = -1;
				}
				t.x = x + T137.M1523(arrInfoEff[5][0] / 2) * num2;
				t.y = y - T137.M1523(arrInfoEff[5][1] / 2);
				t.fraImgEff = new T49(7);
			}
			VecEffEnd.M1111(t);
		}
	}

	private void M426()
	{
		for (int i = 0; i < VecEffEnd.M1113(); i++)
		{
			T132 t = (T132)VecEffEnd.M1114(i);
			t.M1471();
			if (t.f == t.fRe)
			{
				T160.M1878(t.x, t.y, T160.FIREWORK, T160.volume);
			}
			if (t.f - t.fRe <= t.fraImgEff.nFrame * 3 - 1)
			{
				continue;
			}
			t.f = 0;
			if (typeSub == 0)
			{
				t.fRe = T137.M1523(10);
				int num = 1;
				if (i % 2 == 0)
				{
					num = -1;
				}
				t.x = x + T137.M1523(arrInfoEff[5][0] / 2) * num;
				t.y = y - T137.M1523(arrInfoEff[5][1] / 2);
			}
		}
		if (f >= fRemove)
		{
			M421();
		}
	}

	private void M427(T99 g)
	{
		for (int i = 0; i < VecEffEnd.M1113(); i++)
		{
			T132 t = (T132)VecEffEnd.M1114(i);
			if (t.f - t.fRe > -1 && t.fraImgEff != null)
			{
				t.fraImgEff.M439((t.f - t.fRe) / 3 % t.fraImgEff.nFrame, t.x, t.y, 0, 3, g);
			}
		}
	}
}
