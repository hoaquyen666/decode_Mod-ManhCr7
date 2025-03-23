public class T5
{
	public int life;

	public int ax;

	public int ay;

	public int axTo;

	public int ayTo;

	public int avx;

	public int avy;

	public int adx;

	public int ady;

	public T13 charBelong;

	public T6 arrp;

	public static sbyte[] FRAME = new sbyte[25]
	{
		0, 1, 2, 1, 0, 1, 2, 1, 0, 1,
		2, 1, 0, 1, 2, 1, 0, 1, 2, 1,
		0, 1, 2, 1, 0
	};

	public static int[] ARROWINDEX = new int[18]
	{
		0, 15, 37, 52, 75, 105, 127, 142, 165, 195,
		217, 232, 255, 285, 307, 322, 345, 370
	};

	public static int[] TRANSFORM = new int[16]
	{
		0, 0, 0, 7, 6, 6, 6, 2, 2, 3,
		3, 4, 5, 5, 5, 1
	};

	public T5(T13 charBelong, T6 arrp)
	{
		this.charBelong = charBelong;
		this.arrp = arrp;
	}

	public void M3()
	{
		if (charBelong.mobFocus == null && charBelong.charFocus == null)
		{
			M4();
			return;
		}
		if (charBelong.mobFocus != null)
		{
			axTo = charBelong.mobFocus.x;
			ayTo = charBelong.mobFocus.y - charBelong.mobFocus.h / 4;
		}
		else if (charBelong.charFocus != null)
		{
			axTo = charBelong.charFocus.cx;
			ayTo = charBelong.charFocus.cy - charBelong.charFocus.ch / 4;
		}
		int num = axTo - ax;
		int num2 = ayTo - ay;
		int num3 = 5;
		int num4 = 4;
		if (num + num2 < 60)
		{
			num4 = 3;
		}
		else if (num + num2 < 30)
		{
			num4 = 2;
		}
		if (ax != axTo)
		{
			if (num > 0 && num < num3)
			{
				ax = axTo;
			}
			else if (num < 0 && num > -num3)
			{
				ax = axTo;
			}
			else
			{
				avx = axTo - ax << 2;
				adx += avx;
				ax += adx >> num4;
				adx &= 15;
			}
		}
		if (ay != ayTo)
		{
			if (num2 > 0 && num2 < num3)
			{
				ay = ayTo;
			}
			else if (num2 < 0 && num2 > -num3)
			{
				ay = ayTo;
			}
			else
			{
				avy = ayTo - ay << 2;
				ady += avy;
				ay += ady >> num4;
				ady &= 15;
			}
		}
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		if (charBelong.mobFocus != null)
		{
			num5 = axTo - charBelong.mobFocus.w / 4;
			num7 = axTo + charBelong.mobFocus.w / 4;
			num6 = ayTo - charBelong.mobFocus.h / 4;
			num8 = ayTo + charBelong.mobFocus.h / 4;
		}
		else if (charBelong.charFocus != null)
		{
			num5 = axTo - charBelong.charFocus.cw / 4;
			num7 = axTo + charBelong.charFocus.cw / 4;
			num6 = ayTo - charBelong.charFocus.ch / 4;
			num8 = ayTo + charBelong.charFocus.ch / 4;
		}
		if (life > 0)
		{
			life--;
		}
		if (life == 0 || (ax >= num5 && ax <= num7 && ay >= num6 && ay <= num8))
		{
			M4();
		}
	}

	private void M4()
	{
		charBelong.arr = null;
		ady = 0;
		adx = 0;
		avy = 0;
		avx = 0;
		ayTo = 0;
		axTo = 0;
		ay = 0;
		ax = 0;
		charBelong.M179();
		if (charBelong.me)
		{
			charBelong.M131();
		}
	}

	public void M5(T99 g)
	{
		int num = M6(T137.M1511(axTo - ax, -(ayTo - ay)));
		T157.M1785(g, arrp.imgId[FRAME[num]], ax, ay, TRANSFORM[num], T99.VCENTER | T99.HCENTER);
	}

	public static int M6(int angle)
	{
		for (int i = 0; i < ARROWINDEX.Length - 1; i++)
		{
			if (angle >= ARROWINDEX[i] && angle <= ARROWINDEX[i + 1])
			{
				if (i >= 16)
				{
					return 0;
				}
				return i;
			}
		}
		return 0;
	}
}
