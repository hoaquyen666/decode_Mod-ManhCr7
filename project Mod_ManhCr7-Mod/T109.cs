public class T109 : T30
{
	public string[] info;

	public bool isWait;

	private int h;

	private int padLeft;

	private long time = -1L;

	public T109()
	{
		padLeft = 35;
		if (T51.w <= 176)
		{
			padLeft = 10;
		}
		if (T51.w > 320)
		{
			padLeft = 80;
		}
	}

	public void M1035()
	{
		M1037(mResources.PLEASEWAIT, null, null, null);
		T51.currentDialog = this;
		time = T110.M1054() + 5000L;
	}

	public override void show()
	{
		T51.currentDialog = this;
		time = -1L;
	}

	public void M1036(string info)
	{
		this.info = T98.tahoma_8b.M907(info, T51.w - (padLeft * 2 + 20));
		h = 80;
		if (this.info.Length >= 5)
		{
			h = this.info.Length * T98.tahoma_8b.M912() + 20;
		}
	}

	public void M1037(string info, T22 left, T22 center, T22 right)
	{
		this.info = T98.tahoma_8b.M907(info, T51.w - (padLeft * 2 + 20));
		base.left = left;
		base.center = center;
		base.right = right;
		h = 80;
		if (this.info.Length >= 5)
		{
			h = this.info.Length * T98.tahoma_8b.M912() + 20;
		}
		if (T51.isTouch)
		{
			if (left != null)
			{
				base.left.x = T51.w / 2 - 68 - 5;
				base.left.y = T51.h - 50;
			}
			if (right != null)
			{
				base.right.x = T51.w / 2 + 5;
				base.right.y = T51.h - 50;
			}
			if (center != null)
			{
				base.center.x = T51.w / 2 - 35;
				base.center.y = T51.h - 50;
			}
		}
		isWait = false;
		time = -1L;
	}

	public override void paint(T99 g)
	{
		g.M922(0, 0, T51.w, T51.h);
		if (!T90.isContinueToLogin)
		{
			int num = T51.h - h - 38;
			int w = T51.w;
			int num2 = padLeft;
			T51.paintz.M1234(padLeft, num, w - num2 * 2, h, g);
			int num3 = num + (h - info.Length * T98.tahoma_8b.M912()) / 2 - 2;
			if (isWait)
			{
				num3 += 8;
				T51.M514(T51.hw, num3 - 12, g);
			}
			int num4 = 0;
			int num5 = num3;
			while (num4 < info.Length)
			{
				T98.tahoma_7b_dark.M898(g, info[num4], T51.hw, num5, 2);
				num4++;
				num5 += T98.tahoma_8b.M912();
			}
			base.paint(g);
		}
	}

	public override void update()
	{
		base.update();
		if (time != -1L && T110.M1054() > time)
		{
			T51.M488();
		}
	}
}
