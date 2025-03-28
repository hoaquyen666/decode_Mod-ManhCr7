using System;
using System.Threading;
using UnityEngine;

public class SMS
{
	private const int INTERVAL = 5;

	private const int MAXTIME = 500;

	private static int status;

	private static int _result;

	private static string _to;

	private static string _content;

	private static bool f;

	private static int time;

	public static bool sendEnable;

	private static int time0;

	public static int M1788(string content, string to)
	{
		if (Thread.CurrentThread.Name == Main.mainThreadName)
		{
			return M1790(content, to);
		}
		return M1789(content, to);
	}

	private static int M1789(string content, string to)
	{
		if (status != 0)
		{
			for (int i = 0; i < 500; i++)
			{
				Thread.Sleep(5);
				if (status == 0)
				{
					break;
				}
			}
			if (status != 0)
			{
				Cout.M328("CANNOT SEND SMS " + content + " WHEN SENDING " + _content);
				return -1;
			}
		}
		_content = content;
		_to = to;
		_result = -1;
		status = 2;
		int j;
		for (j = 0; j < 500; j++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (j == 500)
		{
			Debug.LogError("TOO LONG FOR SEND SMS " + content);
			status = 0;
		}
		else
		{
			Debug.Log("Send SMS " + content + " done in " + j * 5 + "ms");
		}
		return _result;
	}

	private static int M1790(string content, string to)
	{
		int num = iOSPlugins.M785();
		Cout.M326("vao sms ko " + num);
		if (num >= 0)
		{
			f = true;
			sendEnable = true;
			iOSPlugins.M787(to, content, num);
			Screen.orientation = ScreenOrientation.AutoRotation;
		}
		return num;
	}

	public static void M1791()
	{
		if (Time.time - (float)time > 1f)
		{
			time++;
		}
		if (f)
		{
			M1792();
		}
		if (status == 2)
		{
			status = 1;
			try
			{
				_result = M1790(_content, _to);
			}
			catch (Exception)
			{
				Debug.Log("CANNOT SEND SMS");
			}
			status = 0;
		}
	}

	private static void M1792()
	{
		if (sendEnable)
		{
			if (iOSPlugins.M791() == 1)
			{
				Screen.orientation = ScreenOrientation.LandscapeLeft;
			}
			else if (iOSPlugins.M791() == -1)
			{
				Screen.orientation = ScreenOrientation.Portrait;
			}
			else if (iOSPlugins.M791() == 0)
			{
				Screen.orientation = ScreenOrientation.AutoRotation;
			}
			else if (iOSPlugins.M791() == 2)
			{
				Screen.orientation = ScreenOrientation.LandscapeRight;
			}
			else if (iOSPlugins.M791() == 3)
			{
				Screen.orientation = ScreenOrientation.PortraitUpsideDown;
			}
			if (time0 < 5)
			{
				time0++;
			}
			else
			{
				iOSPlugins.M789();
				sendEnable = false;
				time0 = 0;
			}
		}
		if (iOSPlugins.M790() == 1)
		{
			Screen.orientation = ScreenOrientation.LandscapeLeft;
			if (time0 < 5)
			{
				time0++;
				return;
			}
			f = false;
			iOSPlugins.M788();
			time0 = 0;
		}
	}
}
