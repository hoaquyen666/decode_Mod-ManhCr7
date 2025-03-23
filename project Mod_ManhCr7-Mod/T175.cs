using System;

public class T175
{
	public static T57 timeListener;

	public static int idAction;

	public static long timeExecute;

	public static bool isON;

	public static void M1965(T57 actionListener, int action, long timeEllapse)
	{
		timeListener = actionListener;
		idAction = action;
		timeExecute = T110.M1054() + timeEllapse;
		isON = true;
	}

	public static void M1966()
	{
		long num = T110.M1054();
		if (!isON || num <= timeExecute)
		{
			return;
		}
		isON = false;
		try
		{
			if (idAction > 0)
			{
				T54.M559().M672(idAction, null);
			}
		}
		catch (Exception)
		{
		}
	}
}
