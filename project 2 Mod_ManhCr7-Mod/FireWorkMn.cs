public class FireWorkMn
{
	private int x;

	private int y;

	private int goc = 1;

	private int n = 360;

	private MyRandom rd = new MyRandom();

	private MyVector fw = new MyVector();

	private int[] color = new int[8] { 16711680, 16776960, 65280, 16777215, 255, 65535, 15790320, 12632256 };

	public FireWorkMn(int x, int y, int goc, int n)
	{
		this.x = x;
		this.y = y;
		this.goc = goc;
		this.n = n;
		for (int i = 0; i < n; i++)
		{
			fw.M1111(new FireWork(x, y, Math.M869(rd.M1083() % 8) + 3, i * goc, color[Math.M869(rd.M1083() % color.Length)]));
		}
	}

	public void M438(mGraphics g)
	{
		for (int i = 0; i < fw.M1113(); i++)
		{
			FireWork t = (FireWork)fw.M1114(i);
			if (t.y < -200)
			{
				fw.M1118(i);
			}
			t.M429(g);
		}
	}
}
