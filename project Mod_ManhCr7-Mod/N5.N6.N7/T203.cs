namespace N5.N6.N7;

public class T203 : T108, T57
{
	public static T203 instance;

	public T173[] tf;

	private int x;

	private int y;

	private int w;

	private int h;

	private string[] strPaint;

	private int focus;

	private int nTf;

	private void M2271(string t)
	{
		w = T51.w - 20;
		if (w > 320)
		{
			w = 320;
		}
		T137.M1513("title= " + t);
		strPaint = T98.tahoma_7b_dark.M907(t, w - 20);
		x = (T51.w - w) / 2;
		tf = new T173[nTf];
		h = tf.Length * 35 + (strPaint.Length - 1) * 20 + 40;
		y = T51.h - h - 40 - (strPaint.Length - 1) * 20;
		for (int i = 0; i < tf.Length; i++)
		{
			tf[i] = new T173();
			tf[i].name = string.Empty;
			tf[i].x = x + 10;
			tf[i].y = y + 35 + (strPaint.Length - 1) * 20 + i * 35;
			tf[i].width = w - 20;
			tf[i].height = T108.ITEM_HEIGHT + 2;
			if (T51.isTouch)
			{
				tf[0].isFocus = false;
			}
			else
			{
				tf[0].isFocus = true;
			}
			if (!T51.isTouch)
			{
				right = tf[0].cmdClear;
			}
		}
		left = new T22(mResources.CLOSE, this, 1, null);
		center = new T22(mResources.OK, this, 2, null);
		if (T51.isTouch)
		{
			center.x = T51.w / 2 + 18;
			left.x = T51.w / 2 - 85;
			center.y = (left.y = y + h + 5);
		}
	}

	public static T203 M2272()
	{
		if (instance == null)
		{
			instance = new T203();
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

	public override void paint(T99 g)
	{
		T54.M559().paint(g);
		T133.M1481(g, x, y, w, h, -1, isButton: true);
		for (int i = 0; i < strPaint.Length; i++)
		{
			T98.tahoma_7b_green2.M898(g, strPaint[i], T51.w / 2, y + 15 + i * 20, T98.CENTER);
		}
		for (int j = 0; j < tf.Length; j++)
		{
			tf[j].M1916(g);
		}
		base.paint(g);
	}

	public override void update()
	{
		T54.M559().update();
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
		if (T51.keyPressed[2])
		{
			focus--;
			if (focus < 0)
			{
				focus = tf.Length - 1;
			}
		}
		else if (T51.keyPressed[8])
		{
			focus++;
			if (focus > tf.Length - 1)
			{
				focus = 0;
			}
		}
		if (T51.keyPressed[2] || T51.keyPressed[8])
		{
			T51.M483();
			for (int i = 0; i < tf.Length; i++)
			{
				if (focus == i)
				{
					tf[i].isFocus = true;
					if (!T51.isTouch)
					{
						right = tf[i].cmdClear;
					}
				}
				else
				{
					tf[i].isFocus = false;
				}
				if (T51.isPointerJustRelease && T51.M481(tf[i].x, tf[i].y, tf[i].width, tf[i].height))
				{
					focus = i;
					break;
				}
			}
		}
		base.updateKey();
		T51.M483();
	}

	public void M2274()
	{
		instance = null;
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
		{
			T54.instance.switchToMe();
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
				T51.M489(mResources.vuilongnhapduthongtin);
				return;
			}
		}
		T146.M1594().M1602(tf);
		T54.instance.switchToMe();
	}
}
