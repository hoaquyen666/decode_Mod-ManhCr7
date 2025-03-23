using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using N3.N4;
using UnityEngine;

public class Main : MonoBehaviour
{
	public static Main main;

	public static T99 g;

	public static T52 midlet;

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
		Time.timeScale = T201.timeScale;
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
			level = T138.M1542("levelScreenKN");
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
				timefps = T110.M1054();
			}
			else if (T110.M1054() - timefps > 1000L)
			{
				max = fps;
				fps = 0;
				timefps = T110.M1054();
			}
			fps++;
			checkInput();
			T147.M1751();
			T148.M1764();
			if (Event.current.type.Equals(EventType.Repaint) && paintCount <= updateCount)
			{
				T52.gameCanvas.M487(g);
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
			T139.M1555();
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
			if (T76.generation == T75.iPodTouch4Gen)
			{
				isIpod = true;
			}
			if (T76.generation == T75.iPhone4)
			{
				isIphone4 = true;
			}
			g = new T99();
			midlet = new T52();
			T174.M1932();
			T125.M1200();
			T133.M1475();
			T54.M531();
			T68.M754().M755();
			T126.M1240();
			T96.M874();
			T87.M847();
			T160.M1826().M1827(T174.mapID);
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
		if (isPC && T138.M1542("lastZoomlevel") != T99.zoomLevel)
		{
			T138.M1547();
			T138.M1543("lastZoomlevel", T99.zoomLevel);
			T138.M1543("levelScreenKN", level);
		}
	}

	public static void closeKeyBoard()
	{
		if (T177.visible)
		{
			T173.kb.active = false;
			T173.kb = null;
		}
	}

	private void FixedUpdate()
	{
		T138.M1541();
		count++;
		if (count >= 10)
		{
			if (up == 0)
			{
				timeup = T110.M1054();
			}
			else if (T110.M1054() - timeup > 1000L)
			{
				upmax = up;
				up = 0;
				timeup = T110.M1054();
			}
			up++;
			setsizeChange();
			updateCount++;
			T77.M795();
			T52.gameCanvas.M445();
			T60.M713();
			T28.M349();
			T158.M1791();
			T120.M1152();
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
			T52.gameCanvas.M479((int)(mousePosition.x / (float)T99.zoomLevel), (int)(((float)Screen.height - mousePosition.y) / (float)T99.zoomLevel) + T99.addYWhenOpenKeyBoard);
			lastMousePos.x = mousePosition.x / (float)T99.zoomLevel;
			lastMousePos.y = mousePosition.y / (float)T99.zoomLevel + (float)T99.addYWhenOpenKeyBoard;
		}
		if (Input.GetMouseButton(0))
		{
			Vector3 mousePosition2 = Input.mousePosition;
			T52.gameCanvas.M477((int)(mousePosition2.x / (float)T99.zoomLevel), (int)(((float)Screen.height - mousePosition2.y) / (float)T99.zoomLevel) + T99.addYWhenOpenKeyBoard);
			lastMousePos.x = mousePosition2.x / (float)T99.zoomLevel;
			lastMousePos.y = mousePosition2.y / (float)T99.zoomLevel + (float)T99.addYWhenOpenKeyBoard;
		}
		if (Input.GetMouseButtonUp(0))
		{
			Vector3 mousePosition3 = Input.mousePosition;
			lastMousePos.x = mousePosition3.x / (float)T99.zoomLevel;
			lastMousePos.y = mousePosition3.y / (float)T99.zoomLevel + (float)T99.addYWhenOpenKeyBoard;
			T52.gameCanvas.M480((int)(mousePosition3.x / (float)T99.zoomLevel), (int)(((float)Screen.height - mousePosition3.y) / (float)T99.zoomLevel) + T99.addYWhenOpenKeyBoard);
		}
		if (Input.anyKeyDown && Event.current.type == EventType.KeyDown)
		{
			int num = T113.M1082(Event.current.keyCode);
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
				T52.gameCanvas.M471(num);
			}
		}
		if (Event.current.type == EventType.KeyUp)
		{
			int num2 = T113.M1082(Event.current.keyCode);
			if (num2 != 0)
			{
				T52.gameCanvas.M473(num2);
			}
		}
		if (isPC)
		{
			T52.gameCanvas.M476((int)(Input.GetAxis("Mouse ScrollWheel") * 10f));
			int num3 = (int)Input.mousePosition.x;
			float y = Input.mousePosition.y;
			int x = num3 / T99.zoomLevel;
			int y2 = (Screen.height - (int)y) / T99.zoomLevel;
			T52.gameCanvas.M475(x, y2);
		}
	}

	private void OnApplicationQuit()
	{
		Debug.LogWarning("APP QUIT");
		T51.bRun = false;
		T147.M1744().close();
		T148.M1757().close();
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
			if (T51.M448())
			{
				isQuitApp = true;
			}
		}
		else
		{
			isResume = true;
		}
		if (T177.visible)
		{
			T173.kb.active = false;
			T173.kb = null;
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
		if (T76.generation != T75.iPhone && T76.generation != T75.iPhone3G && T76.generation != T75.iPodTouch1Gen)
		{
			return T76.generation != T75.iPodTouch2Gen;
		}
		return false;
	}

	public static bool checkCanSendSMS()
	{
		if (T76.generation != T75.iPhone3GS && T76.generation != T75.iPhone4)
		{
			return T76.generation > T75.iPodTouch4Gen;
		}
		return true;
	}
}
