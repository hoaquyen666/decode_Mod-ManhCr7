public class EffectManager : MyVector
{
	public static EffectManager lowEffects = new EffectManager();

	public static EffectManager midEffects = new EffectManager();

	public static EffectManager hiEffects = new EffectManager();

	public void M404()
	{
		for (int num = M1113() - 1; num >= 0; num--)
		{
			Effect_End t = (Effect_End)M1114(num);
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

	public void M406(mGraphics g)
	{
		for (int i = 0; i < M1113(); i++)
		{
			Effect_End t = (Effect_End)M1114(i);
			if (t != null && !t.isRemove)
			{
				((Effect_End)M1114(i)).M420(g);
			}
		}
	}

	public void M407()
	{
		for (int num = M1113() - 1; num >= 0; num--)
		{
			Effect_End t = (Effect_End)M1114(num);
			if (t != null)
			{
				t.isRemove = true;
				M1118(num);
			}
		}
	}

	public static void M408(Effect_End eff)
	{
		hiEffects.M1111(eff);
	}

	public static void M409(Effect_End eff)
	{
		hiEffects.M1119(eff);
	}

	public static void M410(Effect_End eff)
	{
		midEffects.M1111(eff);
	}

	public static void M411(Effect_End eff)
	{
		midEffects.M1119(eff);
	}

	public static void M412(Effect_End eff)
	{
		lowEffects.M1111(eff);
	}

	public static void M413(Effect_End eff)
	{
		lowEffects.M1119(eff);
	}
}
