public class ServerScreen : mScreen, IActionListener
{
	private int mainSelect;

	private Command[] vecServer;

	private Command cmdCheck;

	public const int icmd = 100;

	private int wc;

	private int hc;

	private int w2c;

	private int numw;

	private int numh;

	public ServerScreen()
	{
		TileMap.bgID = (byte)(mSystem.M1054() % 9L);
		if (TileMap.bgID == 5 || TileMap.bgID == 6)
		{
			TileMap.bgID = 4;
		}
		GameScr.M564(fullmScreen: true, -1, -1);
		GameScr.cmx = 100;
		GameScr.cmy = 200;
	}

	public override void switchToMe()
	{
		SoundMn.M1826().M1873();
		base.switchToMe();
		vecServer = new Command[ServerListScreen.nameServer.Length];
		for (int i = 0; i < ServerListScreen.nameServer.Length; i++)
		{
			vecServer[i] = new Command(ServerListScreen.nameServer[i], this, 100 + i, null);
		}
		mainSelect = ServerListScreen.ipSelect;
		w2c = 5;
		wc = 76;
		hc = mScreen.cmdH;
		numw = 2;
		if (GameCanvas.w > 3 * (wc + w2c))
		{
			numw = 3;
		}
		numh = vecServer.Length / numw + ((vecServer.Length % numw != 0) ? 1 : 0);
		for (int j = 0; j < vecServer.Length; j++)
		{
			if (vecServer[j] != null)
			{
				int x = GameCanvas.hw - numw * (wc + w2c) / 2 + j % numw * (wc + w2c);
				int y = GameCanvas.hh - numh * (hc + w2c) / 2 + j / numw * (hc + w2c);
				vecServer[j].x = x;
				vecServer[j].y = y;
			}
		}
		if (!GameCanvas.isTouch)
		{
			cmdCheck = new Command(mResources.SELECT, this, 99, null);
			center = cmdCheck;
		}
	}

	public override void update()
	{
		GameScr.cmx++;
		if (GameScr.cmx > GameCanvas.w * 3 + 100)
		{
			GameScr.cmx = 100;
		}
		for (int i = 0; i < vecServer.Length; i++)
		{
			if (!GameCanvas.isTouch)
			{
				if (i == mainSelect)
				{
					if (GameCanvas.gameTick % 10 < 4)
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

	public override void paint(mGraphics g)
	{
		GameCanvas.M466(g);
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
		if (GameCanvas.keyPressed[4])
		{
			if (num > 0)
			{
				mainSelect--;
			}
			GameCanvas.keyPressed[4] = false;
		}
		else if (GameCanvas.keyPressed[6])
		{
			if (num < numw - 1)
			{
				mainSelect++;
			}
			GameCanvas.keyPressed[6] = false;
		}
		else if (GameCanvas.keyPressed[2])
		{
			if (num2 > 0)
			{
				mainSelect -= numw;
			}
			GameCanvas.keyPressed[2] = false;
		}
		else if (GameCanvas.keyPressed[8])
		{
			if (num2 < numh - 1)
			{
				mainSelect += numw;
			}
			GameCanvas.keyPressed[8] = false;
		}
		if (mainSelect < 0)
		{
			mainSelect = 0;
		}
		if (mainSelect >= vecServer.Length)
		{
			mainSelect = vecServer.Length - 1;
		}
		if (GameCanvas.keyPressed[5])
		{
			vecServer[num].M294();
			GameCanvas.keyPressed[5] = false;
		}
		GameCanvas.M483();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 99)
		{
			ServerListScreen.ipSelect = mainSelect;
			GameCanvas.serverScreen.M1582();
			GameCanvas.serverScreen.switchToMe();
		}
		else
		{
			ServerListScreen.ipSelect = idAction - 100;
			GameCanvas.serverScreen.M1582();
			GameCanvas.serverScreen.switchToMe();
		}
	}
}
