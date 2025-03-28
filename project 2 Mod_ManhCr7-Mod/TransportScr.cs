public class TransportScr : mScreen, IActionListener
{
	public static TransportScr instance;

	public static Image ship;

	public static Image taungam;

	public sbyte type;

	public int speed = 5;

	public int[] posX;

	public int[] posY;

	public int[] posX2;

	public int[] posY2;

	private int cmx;

	private int n = 20;

	public short time;

	public short maxTime;

	public long last;

	public long curr;

	private bool isSpeed;

	private bool transNow;

	private int currSpeed;

	public TransportScr()
	{
		posX = new int[n];
		posY = new int[n];
		for (int i = 0; i < n; i++)
		{
			posX[i] = Res.M1522(0, GameCanvas.w);
			posY[i] = i * (GameCanvas.h / n);
		}
		posX2 = new int[n];
		posY2 = new int[n];
		for (int j = 0; j < n; j++)
		{
			posX2[j] = Res.M1522(0, GameCanvas.w);
			posY2[j] = j * (GameCanvas.h / n);
		}
	}

	public static TransportScr M1969()
	{
		if (instance == null)
		{
			instance = new TransportScr();
		}
		return instance;
	}

	public override void switchToMe()
	{
		if (ship == null)
		{
			ship = GameCanvas.M503("/mainImage/myTexture2dfutherShip.png");
		}
		if (taungam == null)
		{
			taungam = GameCanvas.M503("/mainImage/taungam.png");
		}
		isSpeed = false;
		transNow = false;
		if (Char.M113().M251() > 0 && type == 0)
		{
			center = new Command(mResources.faster, this, 1, null);
		}
		else
		{
			center = null;
		}
		currSpeed = 0;
		base.switchToMe();
	}

	public override void paint(mGraphics g)
	{
		g.M933((type != 0) ? 3056895 : 0);
		g.M932(0, 0, GameCanvas.w, GameCanvas.h);
		for (int i = 0; i < n; i++)
		{
			g.M933((type != 0) ? 11140863 : 14802654);
			g.M932(posX[i], posY[i], 10, 2);
		}
		if (type == 0)
		{
			g.M940(ship, 0, 0, 72, 95, 7, cmx + currSpeed, GameCanvas.h / 2, 3);
		}
		if (type == 1)
		{
			g.M940(taungam, 0, 0, 144, 79, 2, cmx + currSpeed, GameCanvas.h / 2, 3);
		}
		for (int j = 0; j < n; j++)
		{
			g.M933((type != 0) ? 7536127 : 14935011);
			g.M932(posX2[j], posY2[j], 18, 3);
		}
		base.paint(g);
	}

	public override void update()
	{
		if (type == 0)
		{
			if (!isSpeed)
			{
				currSpeed = GameCanvas.w / 2 * time / maxTime;
			}
		}
		else
		{
			currSpeed += 2;
		}
		Controller.isStopReadMessage = false;
		cmx = (((GameCanvas.w / 2 + cmx) / 2 + cmx) / 2 + cmx) / 2;
		if (type == 1)
		{
			cmx = 0;
		}
		for (int i = 0; i < n; i++)
		{
			posX[i] -= speed / 2;
			if (posX[i] < -20)
			{
				posX[i] = GameCanvas.w;
			}
		}
		for (int j = 0; j < n; j++)
		{
			posX2[j] -= speed;
			if (posX2[j] < -20)
			{
				posX2[j] = GameCanvas.w;
			}
		}
		if (GameCanvas.gameTick % 3 == 0)
		{
			speed += ((!isSpeed) ? 1 : 2);
		}
		if (speed > ((!isSpeed) ? 25 : 80))
		{
			speed = ((!isSpeed) ? 25 : 80);
		}
		curr = mSystem.M1054();
		if (curr - last >= 1000L)
		{
			time++;
			last = curr;
		}
		if (isSpeed)
		{
			currSpeed += 3;
		}
		if (currSpeed >= GameCanvas.w / 2 + 30 && !transNow)
		{
			transNow = true;
			Service.M1594().M1729();
		}
		base.update();
	}

	public override void updateKey()
	{
		base.updateKey();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
		{
			GameCanvas.M496(mResources.fasterQuestion, new Command(mResources.YES, this, 2, null), new Command(mResources.NO, this, 3, null));
		}
		if (idAction == 2 && Char.M113().M251() > 0)
		{
			isSpeed = true;
			GameCanvas.M488();
			center = null;
		}
		if (idAction == 3)
		{
			GameCanvas.M488();
		}
	}
}
