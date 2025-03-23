public class T22
{
	public T0 actionChat;

	public string caption;

	public string[] subCaption;

	public T57 actionListener;

	public int idAction;

	public bool isPlaySoundButton = true;

	public T60 img;

	public T60 imgFocus;

	public int x;

	public int y;

	public int w = T108.cmdW;

	public int h = T108.cmdH;

	public int hw;

	private int lenCaption;

	public bool isFocus;

	public object p;

	public int type;

	public string caption2 = string.Empty;

	public static T60 btn0left;

	public static T60 btn0mid;

	public static T60 btn0right;

	public static T60 btn1left;

	public static T60 btn1mid;

	public static T60 btn1right;

	public bool cmdClosePanel;

	public T22(string caption, T57 actionListener, int action, object p, int x, int y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.caption = caption;
		idAction = action;
		this.actionListener = actionListener;
		this.p = p;
		this.x = x;
		this.y = y;
	}

	public T22()
	{
	}

	public T22(string caption, T57 actionListener, int action, object p)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.caption = caption;
		idAction = action;
		this.actionListener = actionListener;
		this.p = p;
	}

	public T22(string caption, int action, object p)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.caption = caption;
		idAction = action;
		this.p = p;
	}

	public T22(string caption, int action)
	{
		this.caption = caption;
		idAction = action;
	}

	public T22(string caption, int action, int x, int y)
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
		T51.M517();
		if (isPlaySoundButton && ((caption != null && !caption.Equals(string.Empty) && !caption.Equals(mResources.saying)) || img != null))
		{
			T160.M1826().M1857();
		}
		if (idAction > 0)
		{
			if (actionListener != null)
			{
				actionListener.perform(idAction, p);
			}
			else
			{
				T54.M559().M672(idAction, p);
			}
		}
	}

	public void M295()
	{
		type = 1;
		w = 160;
		hw = 80;
	}

	public void M296(T99 g)
	{
		if (img != null)
		{
			g.M948(img, x, y + T99.addYWhenOpenKeyBoard, 0);
			if (isFocus)
			{
				if (imgFocus == null)
				{
					if (cmdClosePanel)
					{
						g.M948(T80.imageFlare, x + 8, y + T99.addYWhenOpenKeyBoard + 8, 3);
					}
					else
					{
						g.M948(T80.imageFlare, x - (img.Equals(T54.imgMenu) ? 10 : 0), y + T99.addYWhenOpenKeyBoard, 0);
					}
				}
				else
				{
					g.M948(imgFocus, x, y + T99.addYWhenOpenKeyBoard, 0);
				}
			}
			if (caption != "menu" && caption != null)
			{
				if (!isFocus)
				{
					T98.tahoma_7b_dark.M898(g, caption, x + T99.M958(img) / 2, y + T99.M959(img) / 2 - 5, 2);
				}
				else
				{
					T98.tahoma_7b_green2.M898(g, caption, x + T99.M958(img) / 2, y + T99.M959(img) / 2 - 5, 2);
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
			T98.tahoma_7b_dark.M898(g, caption, num, y + 7, 2);
		}
		else
		{
			T98.tahoma_7b_green2.M898(g, caption, num, y + 7, 2);
		}
	}

	public static void M297(T60 img0, T60 img1, T60 img2, int x, int y, int size, T99 g)
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
		if (T51.M481(x, y, w, h))
		{
			if (T51.isPointerDown)
			{
				isFocus = true;
			}
			if (T51.isPointerJustRelease && T51.isPointerClick)
			{
				return true;
			}
		}
		return false;
	}

	public bool M299(int cmx, int cmy)
	{
		isFocus = false;
		if (T51.M481(x - cmx, y - cmy, w, h))
		{
			T137.M1513("w= " + w);
			if (T51.isPointerDown)
			{
				isFocus = true;
			}
			if (T51.isPointerJustRelease && T51.isPointerClick)
			{
				return true;
			}
		}
		return false;
	}
}
