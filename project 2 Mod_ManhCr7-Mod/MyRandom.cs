using System;

public class MyRandom
{
	public Random r;

	public MyRandom()
	{
		r = new Random();
	}

	public int M1083()
	{
		return r.Next();
	}

	public int M1084(int a)
	{
		return r.Next(a);
	}

	public int M1085(int a, int b)
	{
		return r.Next(a, b);
	}
}
