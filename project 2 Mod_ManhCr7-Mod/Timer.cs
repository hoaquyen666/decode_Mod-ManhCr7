using System;

public class Timer
{
	public static IActionListener timeListener;

	public static int idAction;

	public static long timeExecute;

	public static bool isON;

	public static void M1965(IActionListener actionListener, int action, long timeEllapse)
	{
		timeListener = actionListener;
		idAction = action;
		timeExecute = mSystem.M1054() + timeEllapse;
		isON = true;
	}

	public static void M1966()
	{
		long num = mSystem.M1054();
		if (!isON || num <= timeExecute)
		{
			return;
		}
		isON = false;
		try
		{
			if (idAction > 0)
			{
				GameScr.M559().M672(idAction, null);
			}
		}
		catch (Exception)
		{
		}
	}
}
