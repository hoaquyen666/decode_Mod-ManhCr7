using System;

public class Math
{
	public const double PI = System.Math.PI;

	public static int M869(int i)
	{
		if (i > 0)
		{
			return i;
		}
		return -i;
	}

	public static int M870(int x, int y)
	{
		if (x < y)
		{
			return x;
		}
		return y;
	}

	public static int M871(int x, int y)
	{
		if (x > y)
		{
			return x;
		}
		return y;
	}

	public static int M872(int data, int x)
	{
		int num = 1;
		for (int i = 0; i < x; i++)
		{
			num *= data;
		}
		return num;
	}
}
