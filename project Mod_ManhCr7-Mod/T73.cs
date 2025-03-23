using System.Runtime.InteropServices;
using UnityEngine;

public class T73
{
	public static string devide;

	public static string Myname;

	[DllImport("__Internal")]
	private static extern void _SMSsend(string tophone, string withtext, int n);

	[DllImport("__Internal")]
	private static extern int _unpause();

	[DllImport("__Internal")]
	private static extern int _checkRotation();

	[DllImport("__Internal")]
	private static extern int _back();

	[DllImport("__Internal")]
	private static extern int _Send();

	[DllImport("__Internal")]
	private static extern void _purchaseItem(string itemID, string userName, string gameID);

	public static int M785()
	{
		if (Application.platform == RuntimePlatform.IPhonePlayer)
		{
			return M786();
		}
		devide = T76.generation.ToString();
		if (string.Empty + devide[2] == "h" && devide.Length > 6)
		{
			Myname = SystemInfo.operatingSystem.ToString();
			string text = string.Empty + Myname[10];
			if (text != "2" && text != "3")
			{
				return 0;
			}
			return 1;
		}
		T24.M326(devide + "  loai");
		if (devide == "Unknown" && T139.WIDTH * T139.HEIGHT < 786432f)
		{
			return 0;
		}
		return -1;
	}

	public static int M786()
	{
		if (T76.generation != T75.iPhone3GS && T76.generation != T75.iPhone4 && T76.generation != T75.iPhone4S && T76.generation != T75.iPhone5)
		{
			return -1;
		}
		return 0;
	}

	public static void M787(string phonenumber, string bodytext, int n)
	{
		if (Application.platform != 0)
		{
			_SMSsend(phonenumber, bodytext, n);
		}
	}

	public static void M788()
	{
		if (Application.platform != 0)
		{
			_back();
		}
	}

	public static void M789()
	{
		if (Application.platform != 0)
		{
			_Send();
		}
	}

	public static int M790()
	{
		if (Application.platform != 0)
		{
			return _unpause();
		}
		return 0;
	}

	public static int M791()
	{
		if (Application.platform != 0)
		{
			return _checkRotation();
		}
		return 0;
	}

	public static void M792(string itemID, string userName, string gameID)
	{
		if (Application.platform != 0)
		{
			_purchaseItem(itemID, userName, gameID);
		}
	}
}
