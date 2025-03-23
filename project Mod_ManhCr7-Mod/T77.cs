using System;

public class T77
{
	private static T177 tk;

	public static int TEXT;

	public static int NUMBERIC = 1;

	public static int PASS = 2;

	private static T22 act;

	public static void M794(string caption, int type, string text, T22 action)
	{
		act = action;
		T178 t = ((type == 0 || type == 2) ? T178.ASCIICapable : T178.NumberPad);
		T177.hideInput = false;
		tk = T177.M1967(text, t, b1: false, b2: false, type == 2, b3: false, caption);
	}

	public static void M795()
	{
		try
		{
			if (tk != null && tk.done)
			{
				if (act != null)
				{
					act.M293(tk.text);
				}
				tk.text = string.Empty;
				tk = null;
			}
		}
		catch (Exception)
		{
		}
	}
}
