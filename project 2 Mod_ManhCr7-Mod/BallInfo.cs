public class BallInfo
{
	public int x;

	public int y;

	public int xTo = -999;

	public int yTo = -999;

	public int count;

	public int vy;

	public int vx;

	public int dir;

	public int idImg;

	public bool isPaint = true;

	public bool isDone;

	public bool isSetImg;

	public Char cFocus;

	public void M63()
	{
		cFocus = new Char();
		cFocus.charID = Res.M1522(-999, -800);
		cFocus.head = -1;
		cFocus.body = -1;
		cFocus.leg = -1;
		cFocus.bag = -1;
		cFocus.cName = string.Empty;
		Char t = cFocus;
		cFocus.cHPFull = 20;
		t.cHP = 20;
	}

	public void M64()
	{
		cFocus.cx = x;
		cFocus.cy = y;
	}
}
