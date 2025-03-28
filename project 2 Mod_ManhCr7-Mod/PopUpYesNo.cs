public class PopUpYesNo : IActionListener
{
	public Command cmdYes;

	public Command cmdNo;

	public string[] info;

	private int X;

	private int Y;

	private int W = 120;

	private int H;

	private int dem;

	private long last;

	private long curr;

	public void M1487(string info, Command cmdYes, Command cmdNo)
	{
		this.info = new string[1] { info };
		H = 29;
		this.cmdYes = cmdYes;
		this.cmdNo = cmdNo;
		this.cmdYes.img = (this.cmdNo.img = GameScr.imgNut);
		this.cmdYes.imgFocus = (this.cmdNo.imgFocus = GameScr.imgNutF);
		this.cmdYes.w = mGraphics.M958(cmdYes.img);
		this.cmdNo.w = mGraphics.M958(cmdYes.img);
		this.cmdYes.h = mGraphics.M959(cmdYes.img);
		this.cmdNo.h = mGraphics.M959(cmdYes.img);
		last = mSystem.M1054();
		dem = this.info[0].Length / 3;
		if (dem < 15)
		{
			dem = 15;
		}
		TextInfo.M1898();
	}

	public void M1488(mGraphics g)
	{
		PopUp.M1481(g, X, Y, W, H + ((!GameCanvas.isTouch) ? 10 : 0), 16777215, isButton: false);
		if (info != null)
		{
			TextInfo.M1899(g, info[0], X + 5, Y + H / 2 - ((!GameCanvas.isTouch) ? 6 : 4), W - 10, H, mFont.tahoma_7);
			if (GameCanvas.isTouch)
			{
				cmdYes.M296(g);
				mFont.tahoma_7_yellow.M902(g, dem + string.Empty, cmdYes.x + cmdYes.w / 2, cmdYes.y + cmdYes.h + 5, 2, mFont.tahoma_7_grey);
			}
			else if (TField.isQwerty)
			{
				mFont.tahoma_7b_blue.M898(g, mResources.do_accept_qwerty + dem + ")", X + W / 2, Y + H - 6, 2);
			}
			else
			{
				mFont.tahoma_7b_blue.M898(g, mResources.do_accept + dem + ")", X + W / 2, Y + H - 6, 2);
			}
		}
	}

	public void M1489()
	{
		if (info != null)
		{
			X = GameCanvas.w - 5 - W;
			Y = 45;
			if (GameCanvas.w - 50 > 155 + W)
			{
				X = GameCanvas.w - 55 - W;
				Y = 5;
			}
			cmdYes.x = X - 35;
			cmdYes.y = Y;
			curr = mSystem.M1054();
			Res.M1513("curr - last= " + (curr - last));
			if (curr - last >= 1000L)
			{
				last = mSystem.M1054();
				dem--;
			}
			if (dem == 0)
			{
				GameScr.M559().popUpYesNo = null;
			}
		}
	}

	public void perform(int idAction, object p)
	{
	}
}
