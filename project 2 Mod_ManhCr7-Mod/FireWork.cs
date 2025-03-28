using System;

public class FireWork
{
	public int w;

	public int h;

	public int v;

	public int x0;

	public int x;

	public int y;

	public int y0;

	public int angle;

	public int t;

	public int cl = 16711680;

	private float a;

	private long last;

	private long delay = 150L;

	private bool act = true;

	private int[] arr_x = new int[2];

	private int[] arr_y = new int[2];

	public FireWork(int x0, int y0, int v, int angle, int cl)
	{
		this.y0 = y0;
		this.x0 = x0;
		a = 1f;
		this.v = v;
		this.angle = angle;
		w = GameCanvas.w;
		h = GameCanvas.h;
		last = M430();
		for (int i = 0; i < 2; i++)
		{
			arr_x[i] = x0;
			arr_y[i] = y0;
		}
		this.cl = cl;
	}

	public void M428()
	{
		if (M430() - last >= delay)
		{
			t++;
			last = M430();
			arr_x[1] = arr_x[0];
			arr_y[1] = arr_y[0];
			arr_x[0] = x;
			arr_y[0] = y;
            x = Res.M1508((int)((double)angle * System.Math.PI / 180.0)) * v * t + x0;
            y = (int)((float)(v * Res.M1507((int)((double)angle * System.Math.PI / 180.0)) * t) - a * (float)t * (float)t / 2f) + y0;
		}
	}

	public void M429(mGraphics g)
	{
		M431(g, w - x, h - y, cl);
		for (int i = 0; i < 2; i++)
		{
			M431(g, w - arr_x[i], h - arr_y[i], cl);
		}
		if (act)
		{
			M428();
		}
	}

	public long M430()
	{
		return mSystem.M1054();
	}

	public void M431(mGraphics g, int x, int y, int color)
	{
		g.M933(color);
		g.M932(x, y, 1, 2);
	}
}
