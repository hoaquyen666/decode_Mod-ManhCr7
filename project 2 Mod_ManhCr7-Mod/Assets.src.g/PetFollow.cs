namespace Assets.src.g;

public class PetFollow
{
	public short smallID;

	public Info info = new Info();

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

	public PetFollow()
	{
		f = Res.M1522(0, 3);
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

	public void M2286(mGraphics g)
	{
		int w = 32;
		int h = 32;
		int num = ((GameCanvas.gameTick % 10 > 5) ? 1 : 0);
		if (fimg > 0)
		{
			w = wimg;
			h = himg;
			num = 0;
		}
		SmallImage.M1786(g, smallID, f, cmx, cmy + 3 + num, w, h, (dir != 1) ? 2 : 0, StaticObj.VCENTER_HCENTER);
	}

	public void M2287()
	{
		M2289();
		if (GameCanvas.gameTick % 3 == 0)
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
		ServerEffect.M1571(60, cmx, cmy + 3 + ((GameCanvas.gameTick % 10 > 5) ? 1 : 0), 1);
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
