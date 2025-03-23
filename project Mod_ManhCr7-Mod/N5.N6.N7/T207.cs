namespace N5.N6.N7;

public class T207
{
	public short smallID;

	public T65 info = new T65();

	public int dir;

	public int f;

	public int tF;

	public int cmtoY;

	public int cmy;

	public int cmdy;

	public int cmvy;

	public int cmyLim;

	public int cmtoX;

	public int cmx;

	public int cmdx;

	public int cmvx;

	public int cmxLim;

	public int fimg = -1;

	public int wimg;

	public int himg;

	private int[] frame = new int[4] { 0, 1, 2, 1 };

	private int count;

	public T207()
	{
		f = T137.M1522(0, 3);
	}

	public void M2285(int fimg, int[] frameNew, int wimg, int himg)
	{
		if (fimg >= 1)
		{
			this.fimg = fimg;
			frame = frameNew;
			this.wimg = wimg;
			this.himg = himg;
		}
	}

	public void M2286(T99 g)
	{
		int w = 32;
		int h = 32;
		int num = ((T51.gameTick % 10 > 5) ? 1 : 0);
		if (fimg > 0)
		{
			w = wimg;
			h = himg;
			num = 0;
		}
		T157.M1786(g, smallID, f, cmx, cmy + 3 + num, w, h, (dir != 1) ? 2 : 0, T163.VCENTER_HCENTER);
	}

	public void M2287()
	{
		M2289();
		if (T51.gameTick % 3 == 0)
		{
			f = frame[count];
			count++;
		}
		if (count >= frame.Length)
		{
			count = 0;
		}
	}

	public void M2288()
	{
		T143.M1571(60, cmx, cmy + 3 + ((T51.gameTick % 10 > 5) ? 1 : 0), 1);
	}

	public void M2289()
	{
		if (cmy != cmtoY)
		{
			cmvy = cmtoY - cmy << 2;
			cmdy += cmvy;
			cmy += cmdy >> 4;
			cmdy &= 15;
		}
		if (cmx != cmtoX)
		{
			cmvx = cmtoX - cmx << 2;
			cmdx += cmvx;
			cmx += cmdx >> 4;
			cmdx &= 15;
		}
	}
}
