using UnityEngine;

public class GameMidlet
{
	public static string IP = "112.213.94.23";

	public static int PORT = 14445;

	public static string IP2;

	public static int PORT2;

	public static sbyte PROVIDER;

	public static string VERSION = "2.4.3"; //default: 2.2.2

	public static GameCanvas gameCanvas;

	public static GameMidlet instance;

	public static bool isConnect2;

	public static bool isBackWindowsPhone;

	public GameMidlet()
	{
		M519();
	}

	public void M519()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		instance = this;
		MotherCanvas.instance = new MotherCanvas();
		Session_ME.M1744().setHandler(Controller.M300());
		Session_ME2.M1757().setHandler(Controller.M300());
		Session_ME2.isMainSession = false;
		instance = this;
		gameCanvas = new GameCanvas();
		gameCanvas.M453();
		SplashScr.M1881();
		SplashScr.M1879();
		GameCanvas.currentScreen = new SplashScr();
	}

	public void M520()
	{
		if (Main.typeClient == 6)
		{
			mSystem.M1067();
			return;
		}
		GameCanvas.bRun = false;
		mSystem.M1062();
		M523();
	}

	public static void M521(string data, string to, Command successAction, Command failAction)
	{
		Cout.M326("SEND SMS");
	}

	public static void M522(string url)
	{
		Cout.M331("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}

	public void M523()
	{
		Main.exit();
	}

	public void M524(string url)
	{
		Cout.M331("PLATFORM REQUEST: " + url);
		Application.OpenURL(url);
	}
}
