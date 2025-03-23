using UnityEngine;

public class T52
{
	public static string IP = "112.213.94.23";

	public static int PORT = 14445;

	public static string IP2;

	public static int PORT2;

	public static sbyte PROVIDER;

	public static string VERSION = "2.2.2";

	public static T51 gameCanvas;

	public static T52 instance;

	public static bool isConnect2;

	public static bool isBackWindowsPhone;

	public T52()
	{
		M519();
	}

	public void M519()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		instance = this;
		T106.instance = new T106();
		T147.M1744().setHandler(T23.M300());
		T148.M1757().setHandler(T23.M300());
		T148.isMainSession = false;
		instance = this;
		gameCanvas = new T51();
		gameCanvas.M453();
		T161.M1881();
		T161.M1879();
		T51.currentScreen = new T161();
	}

	public void M520()
	{
		if (Main.typeClient == 6)
		{
			T110.M1067();
			return;
		}
		T51.bRun = false;
		T110.M1062();
		M523();
	}

	public static void M521(string data, string to, T22 successAction, T22 failAction)
	{
		T24.M326("SEND SMS");
	}

	public static void M522(string url)
	{
		T24.M331("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}

	public void M523()
	{
		Main.exit();
	}

	public void M524(string url)
	{
		T24.M331("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}
}
