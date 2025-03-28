using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using Utilities;
using Xmap;
using UnityEngine;

public class Main : MonoBehaviour
{
	public static Main main;

	public static mGraphics g;

	public static GameMidlet midlet;

	public static string res;

	public static string mainThreadName;

	public static bool started;

	public static bool isIpod;

	public static bool isIphone4;

	public static bool isPC;

	public static bool isWindowsPhone;

	public static bool isIPhone;

	public static bool IphoneVersionApp;

	public static string IMEI;

	public static int versionIp;

	public static int numberQuit;

	public static int typeClient;

	public const sbyte PC_VERSION = 4;

	public const sbyte IP_APPSTORE = 5;

	public const sbyte WINDOWSPHONE = 6;

	private int level;

	public const sbyte IP_JB = 3;

	private int updateCount;

	private int paintCount;

	private int count;

	private int fps;

	private int max;

	private int up;

	private int upmax;

	private long timefps;

	private long timeup;

	private bool isRun;

	public static int waitTick;

	public static int f;

	public static bool isResume;

	public static bool isMiniApp;

	public static bool isQuitApp;

	private Vector2 lastMousePos;

	public static int a;

	public static bool isCompactDevice;

	static Main()
	{
		res = "res";
		numberQuit = 1;
		typeClient = 4;
		isMiniApp = true;
		a = 1;
		isCompactDevice = true;
	}

	private void Start()
	{
		if (started)
		{
			return;
		}
		Time.timeScale = AutoActionController.timeScale;
		if (Thread.CurrentThread.Name != "Main")
		{
			Thread.CurrentThread.Name = "Main";
		}
		mainThreadName = Thread.CurrentThread.Name;
		isPC = true;
		started = true;
		if (isPC)
		{
			bool fullscreen = false;
			string[] array = File.ReadAllText("Data\\size.ini").Split('|');
			if (!array[2].Equals("0"))
			{
				fullscreen = true;
			}
			level = Rms.M1542("levelScreenKN");
			if (level == 1)
			{
				Screen.SetResolution(int.Parse(array[0]), int.Parse(array[1]), fullscreen);
			}
			else
			{
				Screen.SetResolution(int.Parse(array[0]), int.Parse(array[1]), fullscreen);
			}
		}
	}

	private void SetInit()
	{
		base.enabled = true;
	}

	private void OnHideUnity(bool isGameShown)
	{
		if (!isGameShown)
		{
			Time.timeScale = 0f;
		}
		else
		{
			Time.timeScale = 1f;
		}
	}

	private void OnGUI()
	{
		if (count >= 10)
		{
			if (fps == 0)
			{
				timefps = mSystem.M1054();
			}
			else if (mSystem.M1054() - timefps > 1000L)
			{
				max = fps;
				fps = 0;
				timefps = mSystem.M1054();
			}
			fps++;
			checkInput();
			Session_ME.M1751();
			Session_ME2.M1764();
			if (Event.current.type.Equals(EventType.Repaint) && paintCount <= updateCount)
			{
				GameMidlet.gameCanvas.M487(g);
				paintCount++;
				g.M954();
			}
		}
	}

	public void setsizeChange()
	{
		if (!isRun)
		{
			Screen.orientation = ScreenOrientation.LandscapeLeft;
			Application.runInBackground = true;
			Application.targetFrameRate = -1;
			base.useGUILayout = false;
			isCompactDevice = detectCompactDevice();
			if (main == null)
			{
				main = this;
			}
			isRun = true;
			ScaleUI.M1555();
			if (isPC)
			{
				IMEI = SystemInfo.deviceUniqueIdentifier;
			}
			else
			{
				IMEI = GetMacAddress();
			}
			isPC = true;
			if (isPC)
			{
				Screen.fullScreen = false;
			}
			if (isWindowsPhone)
			{
				typeClient = 6;
			}
			if (isPC)
			{
				typeClient = 4;
			}
			if (IphoneVersionApp)
			{
				typeClient = 5;
			}
			if (iPhoneSettings.generation == iPhoneGeneration.iPodTouch4Gen)
			{
				isIpod = true;
			}
			if (iPhoneSettings.generation == iPhoneGeneration.iPhone4)
			{
				isIphone4 = true;
			}
			g = new mGraphics();
			midlet = new GameMidlet();
			TileMap.M1932();
			Paint.M1200();
			PopUp.M1475();
			GameScr.M531();
			InfoMe.M754().M755();
			Panel.M1240();
			Menu.M874();
			Key.M847();
			SoundMn.M1826().M1827(TileMap.mapID);
			g.M969();
		}
	}

	public static void setBackupIcloud(string path)
	{
	}

	public string GetMacAddress()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		int num = 0;
		PhysicalAddress physicalAddress;
		while (true)
		{
			if (num < allNetworkInterfaces.Length)
			{
				physicalAddress = allNetworkInterfaces[num].GetPhysicalAddress();
				if (physicalAddress.ToString() != string.Empty)
				{
					break;
				}
				num++;
				continue;
			}
			return string.Empty;
		}
		return physicalAddress.ToString();
	}

	public void doClearRMS()
	{
		if (isPC && Rms.M1542("lastZoomlevel") != mGraphics.zoomLevel)
		{
			Rms.M1547();
			Rms.M1543("lastZoomlevel", mGraphics.zoomLevel);
			Rms.M1543("levelScreenKN", level);
		}
	}

	public static void closeKeyBoard()
	{
		if (TouchScreenKeyboard.visible)
		{
			TField.kb.active = false;
			TField.kb = null;
		}
	}

	private void FixedUpdate()
	{
		Rms.M1541();
		count++;
		if (count >= 10)
		{
			if (up == 0)
			{
				timeup = mSystem.M1054();
			}
			else if (mSystem.M1054() - timeup > 1000L)
			{
				upmax = up;
				up = 0;
				timeup = mSystem.M1054();
			}
			up++;
			setsizeChange();
			updateCount++;
			ipKeyboard.M795();
			GameMidlet.gameCanvas.M445();
			Image.M713();
			DataInputStream.M349();
			SMS.M1791();
			Net.M1152();
			f++;
			if (f > 8)
			{
				f = 0;
			}
		}
	}

	private void Update()
	{
	}

	private void checkInput()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 mousePosition = Input.mousePosition;
			GameMidlet.gameCanvas.M479((int)(mousePosition.x / (float)mGraphics.zoomLevel), (int)(((float)Screen.height - mousePosition.y) / (float)mGraphics.zoomLevel) + mGraphics.addYWhenOpenKeyBoard);
			lastMousePos.x = mousePosition.x / (float)mGraphics.zoomLevel;
			lastMousePos.y = mousePosition.y / (float)mGraphics.zoomLevel + (float)mGraphics.addYWhenOpenKeyBoard;
		}
		if (Input.GetMouseButton(0))
		{
			Vector3 mousePosition2 = Input.mousePosition;
			GameMidlet.gameCanvas.M477((int)(mousePosition2.x / (float)mGraphics.zoomLevel), (int)(((float)Screen.height - mousePosition2.y) / (float)mGraphics.zoomLevel) + mGraphics.addYWhenOpenKeyBoard);
			lastMousePos.x = mousePosition2.x / (float)mGraphics.zoomLevel;
			lastMousePos.y = mousePosition2.y / (float)mGraphics.zoomLevel + (float)mGraphics.addYWhenOpenKeyBoard;
		}
		if (Input.GetMouseButtonUp(0))
		{
			Vector3 mousePosition3 = Input.mousePosition;
			lastMousePos.x = mousePosition3.x / (float)mGraphics.zoomLevel;
			lastMousePos.y = mousePosition3.y / (float)mGraphics.zoomLevel + (float)mGraphics.addYWhenOpenKeyBoard;
			GameMidlet.gameCanvas.M480((int)(mousePosition3.x / (float)mGraphics.zoomLevel), (int)(((float)Screen.height - mousePosition3.y) / (float)mGraphics.zoomLevel) + mGraphics.addYWhenOpenKeyBoard);
		}
		if (Input.anyKeyDown && Event.current.type == EventType.KeyDown)
		{
			int num = MyKeyMap.M1082(Event.current.keyCode);
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				switch (Event.current.keyCode)
				{
				case KeyCode.Alpha2:
					num = 64;
					break;
				case KeyCode.Minus:
					num = 95;
					break;
				}
			}
			if (num != 0)
			{
				GameMidlet.gameCanvas.M471(num);
			}
		}
		if (Event.current.type == EventType.KeyUp)
		{
			int num2 = MyKeyMap.M1082(Event.current.keyCode);
			if (num2 != 0)
			{
				GameMidlet.gameCanvas.M473(num2);
			}
		}
		if (isPC)
		{
			GameMidlet.gameCanvas.M476((int)(Input.GetAxis("Mouse ScrollWheel") * 10f));
			int num3 = (int)Input.mousePosition.x;
			float y = Input.mousePosition.y;
			int x = num3 / mGraphics.zoomLevel;
			int y2 = (Screen.height - (int)y) / mGraphics.zoomLevel;
			GameMidlet.gameCanvas.M475(x, y2);
		}
	}

	private void OnApplicationQuit()
	{
		Debug.LogWarning("APP QUIT");
		GameCanvas.bRun = false;
		Session_ME.M1744().close();
		Session_ME2.M1757().close();
		if (isPC)
		{
			Application.Quit();
		}
	}

	private void OnApplicationPause(bool paused)
	{
		isResume = false;
		if (paused)
		{
			if (GameCanvas.M448())
			{
				isQuitApp = true;
			}
		}
		else
		{
			isResume = true;
		}
		if (TouchScreenKeyboard.visible)
		{
			TField.kb.active = false;
			TField.kb = null;
		}
		if (isQuitApp)
		{
			Application.Quit();
		}
	}

	public static void exit()
	{
		if (isPC)
		{
			main.OnApplicationQuit();
		}
		else
		{
			a = 0;
		}
	}

	public static bool detectCompactDevice()
	{
		if (iPhoneSettings.generation != iPhoneGeneration.iPhone && iPhoneSettings.generation != iPhoneGeneration.iPhone3G && iPhoneSettings.generation != iPhoneGeneration.iPodTouch1Gen)
		{
			return iPhoneSettings.generation != iPhoneGeneration.iPodTouch2Gen;
		}
		return false;
	}

	public static bool checkCanSendSMS()
	{
		if (iPhoneSettings.generation != iPhoneGeneration.iPhone3GS && iPhoneSettings.generation != iPhoneGeneration.iPhone4)
		{
			return iPhoneSettings.generation > iPhoneGeneration.iPodTouch4Gen;
		}
		return true;
	}
}
