public class T86
{
	public short idIcon;

	public int second;

	public int minute;

	private long curr;

	private long last;

	private bool isText;

	private bool dontClear;

	public string text;

	public T86()
	{
	}

	public T86(short idIcon, int s)
	{
		this.idIcon = idIcon;
		minute = s / 60;
		second = s % 60;
		curr = (last = T110.M1054());
	}

	public void M837(sbyte id, string text, int time)
	{
		if (time == -1)
		{
			dontClear = true;
		}
		else
		{
			dontClear = false;
		}
		isText = true;
		minute = time / 60;
		second = time % 60;
		idIcon = id;
		curr = (last = T110.M1054());
		this.text = text;
	}

	public void M838(int time, bool isText)
	{
		minute = time / 60;
		second = time % 60;
		curr = (last = T110.M1054());
		this.isText = isText;
	}

	public static bool M839(int id)
	{
		for (int i = 0; i < T13.vItemTime.M1113(); i++)
		{
			if (((T86)T13.vItemTime.M1114(i)).idIcon == id)
			{
				return true;
			}
		}
		return false;
	}

	public static T86 M840(int id)
	{
		for (int i = 0; i < T54.textTime.M1113(); i++)
		{
			T86 t = (T86)T54.textTime.M1114(i);
			if (t.idIcon == id)
			{
				return t;
			}
		}
		return null;
	}

	public static bool M841(int id)
	{
		for (int i = 0; i < T54.textTime.M1113(); i++)
		{
			if (((T86)T54.textTime.M1114(i)).idIcon == id)
			{
				return true;
			}
		}
		return false;
	}

	public static T86 M842(int id)
	{
		for (int i = 0; i < T13.vItemTime.M1113(); i++)
		{
			T86 t = (T86)T13.vItemTime.M1114(i);
			if (t.idIcon == id)
			{
				return t;
			}
		}
		return null;
	}

	public void M843(int time)
	{
		minute = time / 60;
		second = time % 60;
		curr = (last = T110.M1054());
	}

	public void M844(T99 g, int x, int y)
	{
		T157.M1785(g, idIcon, x, y, 0, 3);
		string empty = string.Empty;
		empty = minute + "'";
		if (minute == 0)
		{
			empty = second + "s";
		}
		T98.tahoma_7b_white.M902(g, empty, x, y + 15, 2, T98.tahoma_7b_dark);
	}

	public void M845(T99 g, int x, int y)
	{
		string empty = string.Empty;
		empty = minute + "'";
		if (minute < 1)
		{
			empty = second + "s";
		}
		if (minute < 0)
		{
			empty = string.Empty;
		}
		if (dontClear)
		{
			empty = string.Empty;
		}
		T98.tahoma_7b_white.M902(g, text + " " + empty, x, y, T98.LEFT, T98.tahoma_7b_dark);
	}

	public void M846()
	{
		curr = T110.M1054();
		if (curr - last >= 1000L)
		{
			last = T110.M1054();
			second--;
			if (second <= 0)
			{
				second = 60;
				minute--;
			}
		}
		if (minute < 0 && !isText)
		{
			T13.vItemTime.M1119(this);
		}
		if (minute < 0 && isText && !dontClear)
		{
			T54.textTime.M1119(this);
		}
	}
}
