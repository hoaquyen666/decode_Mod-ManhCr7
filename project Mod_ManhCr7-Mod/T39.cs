public class T39 : T117
{
	public static T39 lowEffects = new T39();

	public static T39 midEffects = new T39();

	public static T39 hiEffects = new T39();

	public void M404()
	{
		for (int num = M1113() - 1; num >= 0; num--)
		{
			T43 t = (T43)M1114(num);
			if (t != null)
			{
				t.M419();
				if (t.isRemove)
				{
					M1118(num);
				}
			}
		}
	}

	public static void M405()
	{
		hiEffects.M404();
		midEffects.M404();
		lowEffects.M404();
	}

	public void M406(T99 g)
	{
		for (int i = 0; i < M1113(); i++)
		{
			T43 t = (T43)M1114(i);
			if (t != null && !t.isRemove)
			{
				((T43)M1114(i)).M420(g);
			}
		}
	}

	public void M407()
	{
		for (int num = M1113() - 1; num >= 0; num--)
		{
			T43 t = (T43)M1114(num);
			if (t != null)
			{
				t.isRemove = true;
				M1118(num);
			}
		}
	}

	public static void M408(T43 eff)
	{
		hiEffects.M1111(eff);
	}

	public static void M409(T43 eff)
	{
		hiEffects.M1119(eff);
	}

	public static void M410(T43 eff)
	{
		midEffects.M1111(eff);
	}

	public static void M411(T43 eff)
	{
		midEffects.M1119(eff);
	}

	public static void M412(T43 eff)
	{
		lowEffects.M1111(eff);
	}

	public static void M413(T43 eff)
	{
		lowEffects.M1119(eff);
	}
}
