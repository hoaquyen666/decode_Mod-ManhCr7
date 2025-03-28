namespace Assets.src.g;

public class ClientInput : mScreen, IActionListener
{
	public static ClientInput instance;

	public TField[] tf;

	private int x;

	private int y;

	private int w;

	private int h;

	private string[] strPaint;

	private int focus;

	private int nTf;

	private void M2271(string t)
	{
		w = GameCanvas.w - 20;
		if (w > 320)
		{
			w = 320;
		}
		Res.M1513("title= " + t);
		strPaint = mFont.tahoma_7b_dark.M907(t, w - 20);
		x = (GameCanvas.w - w) / 2;
		tf = new TField[nTf];
		h = tf.Length * 35 + (strPaint.Length - 1) * 20 + 40;
		y = GameCanvas.h - h - 40 - (strPaint.Length - 1) * 20;
		for (int i = 0; i < tf.Length; i++)
		{
			tf[i] = new TField();
			tf[i].name = string.Empty;
			tf[i].x = x + 10;
			tf[i].y = y + 35 + (strPaint.Length - 1) * 20 + i * 35;
			tf[i].width = w - 20;
			tf[i].height = mScreen.ITEM_HEIGHT + 2;
			if (GameCanvas.isTouch)
			{
				tf[0].isFocus = false;
			}
			else
			{
				tf[0].isFocus = true;
			}
			if (!GameCanvas.isTouch)
			{
				right = tf[0].cmdClear;
			}
		}
		left = new Command(mResources.CLOSE, this, 1, null);
		center = new Command(mResources.OK, this, 2, null);
		if (GameCanvas.isTouch)
		{
			center.x = GameCanvas.w / 2 + 18;
			left.x = GameCanvas.w / 2 - 85;
			center.y = (left.y = y + h + 5);
		}
	}

	public static ClientInput M2272()
	{
		if (instance == null)
		{
			instance = new ClientInput();
		}
		return instance;
	}

	public override void switchToMe()
	{
		focus = 0;
		base.switchToMe();
	}

	public void M2273(int type, string title)
	{
		nTf = type;
		M2271(title);
		switchToMe();
	}

	public override void paint(mGraphics g)
	{
		GameScr.M559().paint(g);
		PopUp.M1481(g, x, y, w, h, -1, isButton: true);
		for (int i = 0; i < strPaint.Length; i++)
		{
			mFont.tahoma_7b_green2.M898(g, strPaint[i], GameCanvas.w / 2, y + 15 + i * 20, mFont.CENTER);
		}
		for (int j = 0; j < tf.Length; j++)
		{
			tf[j].M1916(g);
		}
		base.paint(g);
	}

	public override void update()
	{
		GameScr.M559().update();
		for (int i = 0; i < tf.Length; i++)
		{
			tf[i].M1920();
		}
	}

	public override void keyPress(int keyCode)
	{
		for (int i = 0; i < tf.Length; i++)
		{
			if (tf[i].isFocus)
			{
				tf[i].M1913(keyCode);
				break;
			}
		}
		base.keyPress(keyCode);
	}

	public override void updateKey()
	{
		if (GameCanvas.keyPressed[2])
		{
			focus--;
			if (focus < 0)
			{
				focus = tf.Length - 1;
			}
		}
		else if (GameCanvas.keyPressed[8])
		{
			focus++;
			if (focus > tf.Length - 1)
			{
				focus = 0;
			}
		}
		if (GameCanvas.keyPressed[2] || GameCanvas.keyPressed[8])
		{
			GameCanvas.M483();
			for (int i = 0; i < tf.Length; i++)
			{
				if (focus == i)
				{
					tf[i].isFocus = true;
					if (!GameCanvas.isTouch)
					{
						right = tf[i].cmdClear;
					}
				}
				else
				{
					tf[i].isFocus = false;
				}
				if (GameCanvas.isPointerJustRelease && GameCanvas.M481(tf[i].x, tf[i].y, tf[i].width, tf[i].height))
				{
					focus = i;
					break;
				}
			}
		}
		base.updateKey();
		GameCanvas.M483();
	}

	public void M2274()
	{
		instance = null;
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
		{
			GameScr.instance.switchToMe();
			M2274();
		}
		if (idAction != 2)
		{
			return;
		}
		for (int i = 0; i < tf.Length; i++)
		{
			if (tf[i].M1924() == null || tf[i].M1924().Equals(string.Empty))
			{
				GameCanvas.M489(mResources.vuilongnhapduthongtin);
				return;
			}
		}
		Service.M1594().M1602(tf);
		GameScr.instance.switchToMe();
	}
}
