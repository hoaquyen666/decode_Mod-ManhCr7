using System;

public class T122
{
	public static void M1182()
	{
		T51.M488();
	}

	public void M1183()
	{
		T51.M490(mResources.downloading_data);
	}

	public static int M1184(int max)
	{
		return new T114().M1084(max);
	}

	public static sbyte[] M1185(T97 msg)
	{
		try
		{
			sbyte[] data = new sbyte[msg.M887().M1094()];
			msg.M887().M1102(ref data);
			return data;
		}
		catch (Exception)
		{
			T24.M328("LOI DOC readByteArray NINJAUTIL");
		}
		return null;
	}

	public static sbyte[] M1186(T115 dos)
	{
		try
		{
			sbyte[] data = new sbyte[dos.M1094()];
			dos.M1102(ref data);
			return data;
		}
		catch (Exception)
		{
			T24.M328("LOI DOC readByteArray dos  NINJAUTIL");
		}
		return null;
	}

	public static string M1187(string text, string regex, string replacement)
	{
		return text.Replace(regex, replacement);
	}

	public static string M1188(string number)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		if (number.Equals(string.Empty))
		{
			return text;
		}
		if (number[0] == '-')
		{
			text2 = "-";
			number = number.Substring(1);
		}
		for (int num = number.Length - 1; num >= 0; num--)
		{
			text = (((number.Length - 1 - num) % 3 != 0 || number.Length - 1 - num <= 0) ? (number[num] + text) : (number[num] + "." + text));
		}
		return text2 + text;
	}

	public static string M1189(int second)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(new TimeSpan(second * 1000L * 10000L)).ToUniversalTime();
		int hour = dateTime.Hour;
		_ = dateTime.Minute;
		int day = dateTime.Day;
		int month = dateTime.Month;
		int year = dateTime.Year;
		return day + "/" + month + "/" + year + " " + hour + "h";
	}

	public static string M1190(long second)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Add(new TimeSpan((second + 25200000L) * 10000L)).ToUniversalTime();
		int hour = dateTime.Hour;
		string text = dateTime.Minute.ToString();
		return hour + "h" + text + "m";
	}

	public static string M1191(int timeRemainS)
	{
		int num = 0;
		if (timeRemainS > 60)
		{
			num = timeRemainS / 60;
			timeRemainS %= 60;
		}
		int num2 = 0;
		if (num > 60)
		{
			num2 = num / 60;
			num %= 60;
		}
		int num3 = 0;
		if (num2 > 24)
		{
			num3 = num2 / 24;
			num2 %= 24;
		}
		string empty = string.Empty;
		if (num3 > 0)
		{
			return string.Concat(string.Concat(empty + num3, "d"), num2, "h");
		}
		if (num2 > 0)
		{
			return string.Concat(string.Concat(empty + num2, "h"), num, "'");
		}
		empty = ((num <= 9) ? (empty + "0" + num) : (empty + num)) + ":";
		if (timeRemainS > 9)
		{
			return empty + timeRemainS;
		}
		return empty + "0" + timeRemainS;
	}

	public static string M1192(long m)
	{
		string text = string.Empty;
		long num = m / 1000L + 1L;
		for (int i = 0; i < num; i++)
		{
			if (m >= 1000L)
			{
				long num2 = m % 1000L;
				text = ((num2 != 0L) ? ((num2 >= 10L) ? ((num2 >= 100L) ? ("." + num2 + text) : (".0" + num2 + text)) : (".00" + num2 + text)) : (".000" + text));
				m /= 1000L;
				continue;
			}
			text = m + text;
			break;
		}
		return text;
	}

	public static string M1193(int timeRemainS)
	{
		int num = 0;
		if (timeRemainS > 60)
		{
			num = timeRemainS / 60;
			timeRemainS %= 60;
		}
		int num2 = 0;
		if (num > 60)
		{
			num2 = num / 60;
			num %= 60;
		}
		int num3 = 0;
		if (num2 > 24)
		{
			num3 = num2 / 24;
			num2 %= 24;
		}
		string empty = string.Empty;
		if (num3 > 0)
		{
			return string.Concat(string.Concat(empty + num3, "d"), num2, "h");
		}
		if (num2 > 0)
		{
			return string.Concat(string.Concat(empty + num2, "h"), num, "'");
		}
		if (num == 0)
		{
			num = 1;
		}
		return string.Concat(empty + num, "ph");
	}

	public static string[] M1194(string original, string separator)
	{
		T117 t = new T117();
		for (int num = original.IndexOf(separator); num >= 0; num = original.IndexOf(separator))
		{
			t.M1111(original.Substring(0, num));
			original = original.Substring(num + separator.Length);
		}
		t.M1111(original);
		string[] array = new string[t.M1113()];
		if (t.M1113() > 0)
		{
			for (int i = 0; i < t.M1113(); i++)
			{
				array[i] = (string)t.M1114(i);
			}
		}
		return array;
	}
}
