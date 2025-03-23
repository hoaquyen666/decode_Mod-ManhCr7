using System;
using System.Text;
using UnityEngine;

public class T110
{
	public static bool isTest;

	public static string strAdmob;

	public static bool loadAdOk;

	public static string publicID;

	public static string android_pack;

	public static int clientType = 4;

	public static sbyte LANGUAGE;

	public static sbyte curINAPP;

	public static sbyte maxINAPP = 5;

	public const int JAVA = 1;

	public const int ANDROID = 2;

	public const int IP_JB = 3;

	public const int PC = 4;

	public const int IP_APPSTORE = 5;

	public const int WINDOWS_PHONE = 6;

	public const int GOOGLE_PLAY = 7;

	public static T110 instance;

	public static void M1038()
	{
		curINAPP = 0;
	}

	public static void M1039(string st)
	{
	}

	public static string M1040(long timeStart, int secondCount, bool isOnlySecond, bool isShortText)
	{
		string result = string.Empty;
		long num = (timeStart + secondCount * 1000 - M1054()) / 1000L;
		if (num <= 0L)
		{
			return string.Empty;
		}
		long num2 = 0L;
		long num3 = 0L;
		long num4 = num / 60L;
		long num5 = num;
		if (isOnlySecond)
		{
			return num5 + string.Empty;
		}
		if (num >= 86400L)
		{
			num2 = num / 86400L;
			num3 = num % 86400L / 3600L;
		}
		else if (num >= 3600L)
		{
			num3 = num / 3600L;
			num4 = num % 3600L / 60L;
		}
		else if (num >= 60L)
		{
			num4 = num / 60L;
			num5 = num % 60L;
		}
		else
		{
			num5 = num;
		}
		if (isShortText)
		{
			if (num2 > 0L)
			{
				return num2 + "d";
			}
			if (num3 > 0L)
			{
				return num3 + "h";
			}
			if (num4 > 0L)
			{
				return num4 + "m";
			}
			if (num5 > 0L)
			{
				return num5 + "s";
			}
		}
		if (num2 > 0L)
		{
			if (num2 >= 10L)
			{
				result = ((num3 < 1L) ? (num2 + "d") : ((num3 >= 10L) ? (num2 + "d" + num3 + "h") : (num2 + "d0" + num3 + "h")));
			}
			else if (num2 < 10L)
			{
				result = ((num3 < 1L) ? (num2 + "d") : ((num3 >= 10L) ? (num2 + "d" + num3 + "h") : (num2 + "d0" + num3 + "h")));
			}
		}
		else if (num3 > 0L)
		{
			if (num3 >= 10L)
			{
				result = ((num4 < 1L) ? (num3 + "h") : ((num4 >= 10L) ? (num3 + "h" + num4 + "m") : (num3 + "h0" + num4 + "m")));
			}
			else if (num3 < 10L)
			{
				result = ((num4 < 1L) ? (num3 + "h") : ((num4 >= 10L) ? (num3 + "h" + num4 + "m") : (num3 + "h0" + num4 + "m")));
			}
		}
		else if (num4 > 0L)
		{
			if (num4 >= 10L)
			{
				if (num5 >= 10L)
				{
					result = num4 + "m" + num5 + string.Empty;
				}
				else if (num5 < 10L)
				{
					result = num4 + "m0" + num5 + string.Empty;
				}
			}
			else if (num4 < 10L)
			{
				if (num5 >= 10L)
				{
					result = num4 + "m" + num5 + string.Empty;
				}
				else if (num5 < 10L)
				{
					result = num4 + "m0" + num5 + string.Empty;
				}
			}
		}
		else
		{
			result = ((num5 >= 10L) ? (num5 + string.Empty) : ("0" + num5 + string.Empty));
		}
		return result;
	}

	public static string M1041(int aa)
	{
		try
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = aa + string.Empty;
			if (text3.Equals(string.Empty))
			{
				return text;
			}
			if (text3[0] == '-')
			{
				text2 = "-";
				text3 = text3.Substring(1);
			}
			for (int num = text3.Length - 1; num >= 0; num--)
			{
				text = (((text3.Length - 1 - num) % 3 != 0 || text3.Length - 1 - num <= 0) ? (text3[num] + text) : (text3[num] + "." + text));
			}
			return text2 + text;
		}
		catch (Exception)
		{
			return aa + string.Empty;
		}
	}

	public static string M1042(long number)
	{
		string text = string.Empty + number;
		bool flag = false;
		try
		{
			string empty = string.Empty;
			if (number < 0L)
			{
				flag = true;
				number = -number;
				text = string.Empty + number;
			}
			int num = 0;
			if (number >= 1000000000L)
			{
				empty = "b";
				number /= 1000000000L;
				num = (string.Empty + number).Length;
			}
			else if (number >= 1000000L)
			{
				empty = "m";
				number /= 1000000L;
				num = (string.Empty + number).Length;
			}
			else
			{
				if (number < 1000L)
				{
					if (flag)
					{
						return "-" + text;
					}
					return text;
				}
				empty = "k";
				number /= 1000L;
				num = (string.Empty + number).Length;
			}
			int num2 = int.Parse(text.Substring(num, 2));
			text = ((num2 == 0) ? (text.Substring(0, num) + empty) : ((num2 % 10 != 0) ? (text.Substring(0, num) + "," + text.Substring(num, 2) + empty) : (text.Substring(0, num) + "," + text.Substring(num, 1) + empty)));
		}
		catch (Exception)
		{
		}
		if (flag)
		{
			return "-" + text;
		}
		return text;
	}

	public static void M1043()
	{
		Application.OpenURL("http://ngocrongonline.com/");
	}

	public static void M1044()
	{
	}

	public static void M1045()
	{
	}

	public static void M1046()
	{
	}

	public static void M1047()
	{
	}

	public static void M1048()
	{
	}

	public static void M1049()
	{
	}

	public static void M1050()
	{
	}

	public static void M1051(T99 g, int x, int y, int w, int h)
	{
		g.M927(x, y, w + 10, h, 0, 90);
	}

	public static void M1052(sbyte[] scr, int scrPos, sbyte[] dest, int destPos, int lenght)
	{
		Array.Copy(scr, scrPos, dest, destPos, lenght);
	}

	public static void M1053(sbyte[] scr, int scrPos, ref sbyte[] dest, int destPos, int lenght)
	{
		if (scr != null && dest != null && scrPos + lenght <= scr.Length)
		{
			sbyte[] array = new sbyte[dest.Length + lenght];
			for (int i = 0; i < destPos; i++)
			{
				array[i] = dest[i];
			}
			for (int j = destPos; j < destPos + lenght; j++)
			{
				array[j] = scr[scrPos + j - destPos];
			}
			for (int k = destPos + lenght; k < array.Length; k++)
			{
				array[k] = dest[destPos + k - lenght];
			}
		}
	}

	public static long M1054()
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		return (DateTime.UtcNow.Ticks - dateTime.Ticks) / 10000L;
	}

	public static void M1055()
	{
		Resources.UnloadUnusedAssets();
		GC.Collect();
	}

	public static sbyte[] M1056(byte[] scr)
	{
		sbyte[] array = new sbyte[scr.Length];
		for (int i = 0; i < scr.Length; i++)
		{
			array[i] = (sbyte)scr[i];
		}
		return array;
	}

	public static sbyte[] M1057(string scr)
	{
		return M1056(new ASCIIEncoding().GetBytes(scr));
	}

	public static byte[] M1058(sbyte[] scr)
	{
		byte[] array = new byte[scr.Length];
		for (int i = 0; i < scr.Length; i++)
		{
			if (scr[i] > 0)
			{
				array[i] = (byte)scr[i];
			}
			else
			{
				array[i] = (byte)(scr[i] + 256);
			}
		}
		return array;
	}

	public static char[] M1059(sbyte[] scr)
	{
		char[] array = new char[scr.Length];
		for (int i = 0; i < scr.Length; i++)
		{
			array[i] = (char)scr[i];
		}
		return array;
	}

	public static int M1060()
	{
		return DateTime.Now.Hour;
	}

	public static void M1061(object str)
	{
		Debug.Log(str);
	}

	public static void M1062()
	{
		Resources.UnloadUnusedAssets();
		GC.Collect();
	}

	public static T110 M1063()
	{
		if (instance == null)
		{
			instance = new T110();
		}
		return instance;
	}

	public static void M1064()
	{
		T23.isConnectOK = true;
	}

	public static void M1065()
	{
		T23.isConnectionFail = true;
	}

	public static void M1066()
	{
		T23.isDisconnected = true;
	}

	public static void M1067()
	{
	}

	public static void M1068(T99 g)
	{
		for (int i = 0; i < 5; i++)
		{
			if (T54.flyTextState[i] != -1 && T51.M511(T54.flyTextX[i], T54.flyTextY[i]))
			{
				if (T54.flyTextColor[i] == T98.RED)
				{
					T98.bigNumber_red.M899(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER);
				}
				else if (T54.flyTextColor[i] == T98.YELLOW)
				{
					T98.bigNumber_yellow.M899(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER);
				}
				else if (T54.flyTextColor[i] == T98.GREEN)
				{
					T98.bigNumber_green.M899(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER);
				}
				else if (T54.flyTextColor[i] == T98.FATAL)
				{
					T98.bigNumber_yellow.M900(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER, T98.bigNumber_black);
				}
				else if (T54.flyTextColor[i] == T98.FATAL_ME)
				{
					T98.bigNumber_green.M900(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER, T98.bigNumber_black);
				}
				else if (T54.flyTextColor[i] == T98.MISS)
				{
					T98.bigNumber_While.M900(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER, T98.tahoma_7_grey);
				}
				else if (T54.flyTextColor[i] == T98.ORANGE)
				{
					T98.bigNumber_orange.M899(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER);
				}
				else if (T54.flyTextColor[i] == T98.ADDMONEY)
				{
					T98.bigNumber_yellow.M900(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER, T98.bigNumber_black);
				}
				else if (T54.flyTextColor[i] == T98.MISS_ME)
				{
					T98.bigNumber_While.M900(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER, T98.bigNumber_black);
				}
				else if (T54.flyTextColor[i] == T98.HP)
				{
					T98.bigNumber_red.M900(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER, T98.bigNumber_black);
				}
				else if (T54.flyTextColor[i] == T98.MP)
				{
					T98.bigNumber_blue.M900(g, T54.flyTextString[i], T54.flyTextX[i], T54.flyTextY[i], T98.CENTER, T98.bigNumber_black);
				}
			}
		}
	}

	public static void M1069()
	{
	}

	public static T49 M1070(string nameImg)
	{
		T49 result = null;
		T92 t = null;
		t = T64.M736(nameImg, T64.hashImagePath);
		if (t.img != null)
		{
			int num = t.img.M728() / t.nFrame;
			if (num < 1)
			{
				num = 1;
			}
			result = new T49(t.img, t.img.M727(), num);
		}
		return result;
	}

	public static T60 M1071(string path)
	{
		return T51.M503(path);
	}
}
