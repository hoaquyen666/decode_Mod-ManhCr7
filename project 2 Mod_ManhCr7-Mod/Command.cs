public class Command
{
	public ActionChat actionChat;

	public string caption;

	public string[] subCaption;

	public IActionListener actionListener;

	public int idAction;

	public bool isPlaySoundButton = true;

	public Image img;

	public Image imgFocus;

	public int x;

	public int y;

	public int w = mScreen.cmdW;

	public int h = mScreen.cmdH;

	public int hw;

	private int lenCaption;

	public bool isFocus;

	public object p;

	public int type;

	public string caption2 = string.Empty;

	public static Image btn0left;

	public static Image btn0mid;

	public static Image btn0right;

	public static Image btn1left;

	public static Image btn1mid;

	public static Image btn1right;

	public bool cmdClosePanel;

	public Command(string caption, IActionListener actionListener, int action, object p, int x, int y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.caption = caption;
		idAction = action;
		this.actionListener = actionListener;
		this.p = p;
		this.x = x;
		this.y = y;
	}

	public Command()
	{
	}

	public Command(string caption, IActionListener actionListener, int action, object p)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.caption = caption;
		idAction = action;
		this.actionListener = actionListener;
		this.p = p;
	}

	public Command(string caption, int action, object p)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.caption = caption;
		idAction = action;
		this.p = p;
	}

	public Command(string caption, int action)
	{
		this.caption = caption;
		idAction = action;
	}

	public Command(string caption, int action, int x, int y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.caption = caption;
		idAction = action;
		this.x = x;
		this.y = y;
	}

	public void M293(string str)
	{
		if (actionChat != null)
		{
			actionChat(str);
		}
	}

	public void M294()
	{
		GameCanvas.M517();
		if (isPlaySoundButton && ((caption != null && !caption.Equals(string.Empty) && !caption.Equals(mResources.saying)) || img != null))
		{
			SoundMn.M1826().M1857();
		}
		if (idAction > 0)
		{
			if (actionListener != null)
			{
				actionListener.perform(idAction, p);
			}
			else
			{
				GameScr.M559().M672(idAction, p);
			}
		}
	}

	public void M295()
	{
		type = 1;
		w = 160;
		hw = 80;
	}

	public void M296(mGraphics g)
	{
		if (img != null)
		{
			g.M948(img, x, y + mGraphics.addYWhenOpenKeyBoard, 0);
			if (isFocus)
			{
				if (imgFocus == null)
				{
					if (cmdClosePanel)
					{
						g.M948(ItemMap.imageFlare, x + 8, y + mGraphics.addYWhenOpenKeyBoard + 8, 3);
					}
					else
					{
						g.M948(ItemMap.imageFlare, x - (img.Equals(GameScr.imgMenu) ? 10 : 0), y + mGraphics.addYWhenOpenKeyBoard, 0);
					}
				}
				else
				{
					g.M948(imgFocus, x, y + mGraphics.addYWhenOpenKeyBoard, 0);
				}
			}
			if (caption != "menu" && caption != null)
			{
				if (!isFocus)
				{
					mFont.tahoma_7b_dark.M898(g, caption, x + mGraphics.M958(img) / 2, y + mGraphics.M959(img) / 2 - 5, 2);
				}
				else
				{
					mFont.tahoma_7b_green2.M898(g, caption, x + mGraphics.M958(img) / 2, y + mGraphics.M959(img) / 2 - 5, 2);
				}
			}
			return;
		}
		if (caption != string.Empty)
		{
			if (type == 1)
			{
				if (!isFocus)
				{
					M297(btn0left, btn0mid, btn0right, x, y, 160, g);
				}
				else
				{
					M297(btn1left, btn1mid, btn1right, x, y, 160, g);
				}
			}
			else if (!isFocus)
			{
				M297(btn0left, btn0mid, btn0right, x, y, 76, g);
			}
			else
			{
				M297(btn1left, btn1mid, btn1right, x, y, 76, g);
			}
		}
		int num = ((type != 1) ? (x + 38) : (x + hw));
		if (!isFocus)
		{
			mFont.tahoma_7b_dark.M898(g, caption, num, y + 7, 2);
		}
		else
		{
			mFont.tahoma_7b_green2.M898(g, caption, num, y + 7, 2);
		}
	}

	public static void M297(Image img0, Image img1, Image img2, int x, int y, int size, mGraphics g)
	{
		for (int i = 10; i <= size - 20; i += 10)
		{
			g.M948(img1, x + i, y, 0);
		}
		int num = size % 10;
		if (num > 0)
		{
			g.M940(img1, 0, 0, num, 24, 0, x + size - 10 - num, y, 0);
		}
		g.M948(img0, x, y, 0);
		g.M948(img2, x + size - 10, y, 0);
	}

	public bool M298()
	{
		isFocus = false;
		if (GameCanvas.M481(x, y, w, h))
		{
			if (GameCanvas.isPointerDown)
			{
				isFocus = true;
			}
			if (GameCanvas.isPointerJustRelease && GameCanvas.isPointerClick)
			{
				return true;
			}
		}
		return false;
	}

	public bool M299(int cmx, int cmy)
	{
		isFocus = false;
		if (GameCanvas.M481(x - cmx, y - cmy, w, h))
		{
			Res.M1513("w= " + w);
			if (GameCanvas.isPointerDown)
			{
				isFocus = true;
			}
			if (GameCanvas.isPointerJustRelease && GameCanvas.isPointerClick)
			{
				return true;
			}
		}
		return false;
	}
}
