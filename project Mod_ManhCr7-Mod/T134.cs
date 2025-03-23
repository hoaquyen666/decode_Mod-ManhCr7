public class T134 : T57
{
	public T22 cmdYes;

	public T22 cmdNo;

	public string[] info;

	private int X;

	private int Y;

	private int W = 120;

	private int H;

	private int dem;

	private long last;

	private long curr;

	public void M1487(string info, T22 cmdYes, T22 cmdNo)
	{
		this.info = new string[1] { info };
		H = 29;
		this.cmdYes = cmdYes;
		this.cmdNo = cmdNo;
		this.cmdYes.img = (this.cmdNo.img = T54.imgNut);
		this.cmdYes.imgFocus = (this.cmdNo.imgFocus = T54.imgNutF);
		this.cmdYes.w = T99.M958(cmdYes.img);
		this.cmdNo.w = T99.M958(cmdYes.img);
		this.cmdYes.h = T99.M959(cmdYes.img);
		this.cmdNo.h = T99.M959(cmdYes.img);
		last = T110.M1054();
		dem = this.info[0].Length / 3;
		if (dem < 15)
		{
			dem = 15;
		}
		T172.M1898();
	}

	public void M1488(T99 g)
	{
		T133.M1481(g, X, Y, W, H + ((!T51.isTouch) ? 10 : 0), 16777215, isButton: false);
		if (info != null)
		{
			T172.M1899(g, info[0], X + 5, Y + H / 2 - ((!T51.isTouch) ? 6 : 4), W - 10, H, T98.tahoma_7);
			if (T51.isTouch)
			{
				cmdYes.M296(g);
				T98.tahoma_7_yellow.M902(g, dem + string.Empty, cmdYes.x + cmdYes.w / 2, cmdYes.y + cmdYes.h + 5, 2, T98.tahoma_7_grey);
			}
			else if (T173.isQwerty)
			{
				T98.tahoma_7b_blue.M898(g, mResources.do_accept_qwerty + dem + ")", X + W / 2, Y + H - 6, 2);
			}
			else
			{
				T98.tahoma_7b_blue.M898(g, mResources.do_accept + dem + ")", X + W / 2, Y + H - 6, 2);
			}
		}
	}

	public void M1489()
	{
		if (info != null)
		{
			X = T51.w - 5 - W;
			Y = 45;
			if (T51.w - 50 > 155 + W)
			{
				X = T51.w - 55 - W;
				Y = 5;
			}
			cmdYes.x = X - 35;
			cmdYes.y = Y;
			curr = T110.M1054();
			T137.M1513("curr - last= " + (curr - last));
			if (curr - last >= 1000L)
			{
				last = T110.M1054();
				dem--;
			}
			if (dem == 0)
			{
				T54.M559().popUpYesNo = null;
			}
		}
	}

	public void perform(int idAction, object p)
	{
	}
}
