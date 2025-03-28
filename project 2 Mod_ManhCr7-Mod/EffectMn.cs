public class EffectMn
{
	public static MyVector vEff = new MyVector();

	public static void M376(Effect me)
	{
		vEff.M1111(me);
	}

	public static void M377(int id)
	{
		if (M378(id) != null)
		{
			vEff.M1119(M378(id));
		}
	}

	public static Effect M378(int id)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			Effect t = (Effect)vEff.M1114(i);
			if (t.effId == id)
			{
				return t;
			}
		}
		return null;
	}

	public static void M379(mGraphics g, int x, int y, int layer)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((Effect)vEff.M1114(i)).layer == -layer)
			{
				((Effect)vEff.M1114(i)).M390(g, x, y);
			}
		}
	}

	public static void M380(mGraphics g)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((Effect)vEff.M1114(i)).layer == 1)
			{
				((Effect)vEff.M1114(i)).M392(g);
			}
		}
	}

	public static void M381(mGraphics g)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((Effect)vEff.M1114(i)).layer == 2)
			{
				((Effect)vEff.M1114(i)).M392(g);
			}
		}
	}

	public static void M382(mGraphics g)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((Effect)vEff.M1114(i)).layer == 3)
			{
				((Effect)vEff.M1114(i)).M392(g);
			}
		}
	}

	public static void M383(mGraphics g)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((Effect)vEff.M1114(i)).layer == 4)
			{
				((Effect)vEff.M1114(i)).M392(g);
			}
		}
	}

	public static void M384()
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			((Effect)vEff.M1114(i)).M393();
		}
	}
}
