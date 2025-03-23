public class T31
{
	public static T117 vEff = new T117();

	public static void M376(T32 me)
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

	public static T32 M378(int id)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			T32 t = (T32)vEff.M1114(i);
			if (t.effId == id)
			{
				return t;
			}
		}
		return null;
	}

	public static void M379(T99 g, int x, int y, int layer)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((T32)vEff.M1114(i)).layer == -layer)
			{
				((T32)vEff.M1114(i)).M390(g, x, y);
			}
		}
	}

	public static void M380(T99 g)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((T32)vEff.M1114(i)).layer == 1)
			{
				((T32)vEff.M1114(i)).M392(g);
			}
		}
	}

	public static void M381(T99 g)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((T32)vEff.M1114(i)).layer == 2)
			{
				((T32)vEff.M1114(i)).M392(g);
			}
		}
	}

	public static void M382(T99 g)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((T32)vEff.M1114(i)).layer == 3)
			{
				((T32)vEff.M1114(i)).M392(g);
			}
		}
	}

	public static void M383(T99 g)
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			if (((T32)vEff.M1114(i)).layer == 4)
			{
				((T32)vEff.M1114(i)).M392(g);
			}
		}
	}

	public static void M384()
	{
		for (int i = 0; i < vEff.M1113(); i++)
		{
			((T32)vEff.M1114(i)).M393();
		}
	}
}
