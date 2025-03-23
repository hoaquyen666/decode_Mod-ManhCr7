public class T179 : T108, T57
{
	public static T179 instance;

	public static T60 ship;

	public static T60 taungam;

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

	public T179()
	{
		posX = new int[n];
		posY = new int[n];
		for (int i = 0; i < n; i++)
		{
			posX[i] = T137.M1522(0, T51.w);
			posY[i] = i * (T51.h / n);
		}
		posX2 = new int[n];
		posY2 = new int[n];
		for (int j = 0; j < n; j++)
		{
			posX2[j] = T137.M1522(0, T51.w);
			posY2[j] = j * (T51.h / n);
		}
	}

	public static T179 M1969()
	{
		if (instance == null)
		{
			instance = new T179();
		}
		return instance;
	}

	public override void switchToMe()
	{
		if (ship == null)
		{
			ship = T51.M503("/mainImage/myTexture2dfutherShip.png");
		}
		if (taungam == null)
		{
			taungam = T51.M503("/mainImage/taungam.png");
		}
		isSpeed = false;
		transNow = false;
		if (T13.M113().M251() > 0 && type == 0)
		{
			center = new T22(mResources.faster, this, 1, null);
		}
		else
		{
			center = null;
		}
		currSpeed = 0;
		base.switchToMe();
	}

	public override void paint(T99 g)
	{
		g.M933((type != 0) ? 3056895 : 0);
		g.M932(0, 0, T51.w, T51.h);
		for (int i = 0; i < n; i++)
		{
			g.M933((type != 0) ? 11140863 : 14802654);
			g.M932(posX[i], posY[i], 10, 2);
		}
		if (type == 0)
		{
			g.M940(ship, 0, 0, 72, 95, 7, cmx + currSpeed, T51.h / 2, 3);
		}
		if (type == 1)
		{
			g.M940(taungam, 0, 0, 144, 79, 2, cmx + currSpeed, T51.h / 2, 3);
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
				currSpeed = T51.w / 2 * time / maxTime;
			}
		}
		else
		{
			currSpeed += 2;
		}
		T23.isStopReadMessage = false;
		cmx = (((T51.w / 2 + cmx) / 2 + cmx) / 2 + cmx) / 2;
		if (type == 1)
		{
			cmx = 0;
		}
		for (int i = 0; i < n; i++)
		{
			posX[i] -= speed / 2;
			if (posX[i] < -20)
			{
				posX[i] = T51.w;
			}
		}
		for (int j = 0; j < n; j++)
		{
			posX2[j] -= speed;
			if (posX2[j] < -20)
			{
				posX2[j] = T51.w;
			}
		}
		if (T51.gameTick % 3 == 0)
		{
			speed += ((!isSpeed) ? 1 : 2);
		}
		if (speed > ((!isSpeed) ? 25 : 80))
		{
			speed = ((!isSpeed) ? 25 : 80);
		}
		curr = T110.M1054();
		if (curr - last >= 1000L)
		{
			time++;
			last = curr;
		}
		if (isSpeed)
		{
			currSpeed += 3;
		}
		if (currSpeed >= T51.w / 2 + 30 && !transNow)
		{
			transNow = true;
			T146.M1594().M1729();
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
			T51.M496(mResources.fasterQuestion, new T22(mResources.YES, this, 2, null), new T22(mResources.NO, this, 3, null));
		}
		if (idAction == 2 && T13.M113().M251() > 0)
		{
			isSpeed = true;
			T51.M488();
			center = null;
		}
		if (idAction == 3)
		{
			T51.M488();
		}
	}
}
