public class T135
{
	public int x;

	public int y;

	public int anchor;

	public int g;

	public int v;

	public int w;

	public int h;

	public int color;

	public int limitY;

	public T89 layer;

	public short yTo;

	public short xTo;

	public short distant;

	public T135()
	{
		x = 0;
		y = 0;
	}

	public T135(int x, int y, int anchor)
	{
		this.x = x;
		this.y = y;
		this.anchor = anchor;
	}

	public T135(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	public void M1490(int xT, int yT)
	{
		xTo = (short)xT;
		yTo = (short)yT;
		distant = (short)T137.M1526(x, y, xTo, yTo);
	}

	public int M1491()
	{
		if (x == xTo && y == yTo)
		{
			return -1;
		}
		if (T94.M869((xTo - x) / 2) <= 1 && T94.M869((yTo - y) / 2) <= 1)
		{
			x = xTo;
			y = yTo;
			return 0;
		}
		if (x != xTo)
		{
			x += (xTo - x) / 2;
		}
		if (y != yTo)
		{
			y += (yTo - y) / 2;
		}
		if (T137.M1526(x, y, xTo, yTo) <= distant / 5)
		{
			return 2;
		}
		return 1;
	}

	public void M1492()
	{
		layer.M848();
	}

	public void M1493(T99 g)
	{
		layer.M849(g, x, y);
	}
}
