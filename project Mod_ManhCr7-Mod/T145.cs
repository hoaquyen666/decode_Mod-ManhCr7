public class T145 : T108, T57
{
	private int mainSelect;

	private T22[] vecServer;

	private T22 cmdCheck;

	public const int icmd = 100;

	private int wc;

	private int hc;

	private int w2c;

	private int numw;

	private int numh;

	public T145()
	{
		T174.bgID = (byte)(T110.M1054() % 9L);
		if (T174.bgID == 5 || T174.bgID == 6)
		{
			T174.bgID = 4;
		}
		T54.M564(fullmScreen: true, -1, -1);
		T54.cmx = 100;
		T54.cmy = 200;
	}

	public override void switchToMe()
	{
		T160.M1826().M1873();
		base.switchToMe();
		vecServer = new T22[T144.nameServer.Length];
		for (int i = 0; i < T144.nameServer.Length; i++)
		{
			vecServer[i] = new T22(T144.nameServer[i], this, 100 + i, null);
		}
		mainSelect = T144.ipSelect;
		w2c = 5;
		wc = 76;
		hc = T108.cmdH;
		numw = 2;
		if (T51.w > 3 * (wc + w2c))
		{
			numw = 3;
		}
		numh = vecServer.Length / numw + ((vecServer.Length % numw != 0) ? 1 : 0);
		for (int j = 0; j < vecServer.Length; j++)
		{
			if (vecServer[j] != null)
			{
				int x = T51.hw - numw * (wc + w2c) / 2 + j % numw * (wc + w2c);
				int y = T51.hh - numh * (hc + w2c) / 2 + j / numw * (hc + w2c);
				vecServer[j].x = x;
				vecServer[j].y = y;
			}
		}
		if (!T51.isTouch)
		{
			cmdCheck = new T22(mResources.SELECT, this, 99, null);
			center = cmdCheck;
		}
	}

	public override void update()
	{
		T54.cmx++;
		if (T54.cmx > T51.w * 3 + 100)
		{
			T54.cmx = 100;
		}
		for (int i = 0; i < vecServer.Length; i++)
		{
			if (!T51.isTouch)
			{
				if (i == mainSelect)
				{
					if (T51.gameTick % 10 < 4)
					{
						vecServer[i].isFocus = true;
					}
					else
					{
						vecServer[i].isFocus = false;
					}
				}
				else
				{
					vecServer[i].isFocus = false;
				}
			}
			else if (vecServer[i] != null && vecServer[i].M298())
			{
				vecServer[i].M294();
			}
		}
	}

	public override void paint(T99 g)
	{
		T51.M466(g);
		for (int i = 0; i < vecServer.Length; i++)
		{
			if (vecServer[i] != null)
			{
				vecServer[i].M296(g);
			}
		}
		base.paint(g);
	}

	public override void updateKey()
	{
		base.updateKey();
		int num = mainSelect % numw;
		int num2 = mainSelect / numw;
		if (T51.keyPressed[4])
		{
			if (num > 0)
			{
				mainSelect--;
			}
			T51.keyPressed[4] = false;
		}
		else if (T51.keyPressed[6])
		{
			if (num < numw - 1)
			{
				mainSelect++;
			}
			T51.keyPressed[6] = false;
		}
		else if (T51.keyPressed[2])
		{
			if (num2 > 0)
			{
				mainSelect -= numw;
			}
			T51.keyPressed[2] = false;
		}
		else if (T51.keyPressed[8])
		{
			if (num2 < numh - 1)
			{
				mainSelect += numw;
			}
			T51.keyPressed[8] = false;
		}
		if (mainSelect < 0)
		{
			mainSelect = 0;
		}
		if (mainSelect >= vecServer.Length)
		{
			mainSelect = vecServer.Length - 1;
		}
		if (T51.keyPressed[5])
		{
			vecServer[num].M294();
			T51.keyPressed[5] = false;
		}
		T51.M483();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 99)
		{
			T144.ipSelect = mainSelect;
			T51.serverScreen.M1582();
			T51.serverScreen.switchToMe();
		}
		else
		{
			T144.ipSelect = idAction - 100;
			T51.serverScreen.M1582();
			T51.serverScreen.switchToMe();
		}
	}
}
