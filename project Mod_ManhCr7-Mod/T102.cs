public class T102
{
	public static T60 imgMob;

	public static int cmtoY;

	public static int cmy;

	public static int cmdy;

	public static int cmvy;

	public static int cmyLim;

	public static int cmtoX;

	public static int cmx;

	public static int cmdx;

	public static int cmvx;

	public static int cmxLim;

	public static bool explode;

	public static int delay;

	public static bool isCreateMob;

	public static int tF;

	public static int f;

	public static int dir;

	public static bool isAttack;

	public static void M1010()
	{
		imgMob = T51.M503("/mainImage/myTexture2dmobCapcha.png");
	}

	public static void M1011(T99 g, int x, int y)
	{
		if (!isAttack)
		{
			if (T51.gameTick % 3 == 0)
			{
				if (T13.M113().cdir == 1)
				{
					cmtoX = x - 20 - T54.cmx;
				}
				if (T13.M113().cdir == -1)
				{
					cmtoX = x + 20 - T54.cmx;
				}
			}
			cmtoY = T13.M113().cy - 40 - T54.cmy;
		}
		else
		{
			delay++;
			if (delay == 5)
			{
				isAttack = false;
				delay = 0;
			}
			cmtoX = x - T54.cmx;
			cmtoY = y - T54.cmy;
		}
		if (cmx > x - T54.cmx)
		{
			dir = -1;
		}
		else
		{
			dir = 1;
		}
		g.M948(T54.imgCapcha, cmx, cmy - 40, 3);
		T133.M1481(g, cmx - 25, cmy - 70, 50, 20, 16777215, isButton: false);
		T98.tahoma_7b_dark.M898(g, T54.M559().keyInput, cmx, cmy - 65, 2);
		if (isCreateMob)
		{
			isCreateMob = false;
			T31.M376(new T32(18, cmx + T54.cmx, cmy + T54.cmy, 2, 10, -1));
		}
		if (explode)
		{
			explode = false;
			T31.M376(new T32(18, cmx + T54.cmx, cmy + T54.cmy, 2, 10, -1));
			T54.M559().mobCapcha = null;
			cmtoX = -T54.cmx;
			cmtoY = -T54.cmy;
		}
		g.M940(imgMob, 0, f * 40, 40, 40, (dir != 1) ? 2 : 0, cmx, cmy + 3 + ((T51.gameTick % 10 > 5) ? 1 : 0), 3);
		M1012();
	}

	public static void M1012()
	{
		if (cmy != cmtoY)
		{
			cmvy = cmtoY - cmy << 2;
			cmdy += cmvy;
			cmy += cmdy >> 4;
			cmdy &= 15;
		}
		if (cmx != cmtoX)
		{
			cmvx = cmtoX - cmx << 2;
			cmdx += cmvx;
			cmx += cmdx >> 4;
			cmdx &= 15;
		}
		tF++;
		if (tF == 5)
		{
			tF = 0;
			f++;
			if (f > 2)
			{
				f = 0;
			}
		}
	}
}
