using System;
using System.IO;
using System.Threading;
using UnityEngine;

public class Rms
{
	public static int status;

	public static sbyte[] data;

	public static string filename;

	private const int INTERVAL = 5;

	private const int MAXTIME = 500;

	public static void M1534(string filename, sbyte[] data)
	{
		if (Thread.CurrentThread.Name == Main.mainThreadName)
		{
			M1545(filename, data);
		}
		else
		{
			M1539(filename, data);
		}
	}

	public static sbyte[] M1535(string filename)
	{
		if (Thread.CurrentThread.Name == Main.mainThreadName)
		{
			return M1546(filename);
		}
		return M1540(filename);
	}

	public static string M1536(string fileName)
	{
		sbyte[] array = M1535(fileName);
		if (array == null)
		{
			return null;
		}
		DataInputStream t = new DataInputStream(array);
		try
		{
			string result = t.M359();
			t.M357();
			return result;
		}
		catch (Exception ex)
		{
			Cout.M326(ex.StackTrace);
		}
		return null;
	}

	public static byte[] M1537(sbyte[] var)
	{
		byte[] array = new byte[var.Length];
		for (int i = 0; i < var.Length; i++)
		{
			if (var[i] > 0)
			{
				array[i] = (byte)var[i];
			}
			else
			{
				array[i] = (byte)(var[i] + 256);
			}
		}
		return array;
	}

	public static void M1538(string filename, string data)
	{
		DataOutputStream t = new DataOutputStream();
		try
		{
			t.M374(data);
			M1534(filename, t.M371());
			t.M372();
		}
		catch (Exception ex)
		{
			Cout.M326(ex.StackTrace);
		}
	}

	private static void M1539(string filename, sbyte[] data)
	{
		if (status != 0)
		{
			Debug.LogError("Cannot save RMS " + filename + " because current is saving " + Rms.filename);
			return;
		}
		Rms.filename = filename;
		Rms.data = data;
		status = 2;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 500)
		{
			Debug.LogError("TOO LONG TO SAVE RMS " + filename);
		}
	}

	private static sbyte[] M1540(string filename)
	{
		if (status != 0)
		{
			Debug.LogError("Cannot load RMS " + filename + " because current is loading " + Rms.filename);
			return null;
		}
		Rms.filename = filename;
		data = null;
		status = 3;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 500)
		{
			Debug.LogError("TOO LONG TO LOAD RMS " + filename);
		}
		return data;
	}

	public static void M1541()
	{
		if (status == 2)
		{
			status = 1;
			M1545(filename, data);
			status = 0;
		}
		else if (status == 3)
		{
			status = 1;
			data = M1546(filename);
			status = 0;
		}
	}

	public static int M1542(string file)
	{
		sbyte[] array = M1535(file);
		if (array == null)
		{
			return -1;
		}
		return array[0];
	}

	public static void M1543(string file, int x)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			M1534(file, new sbyte[1] { (sbyte)x });
		}
		catch (Exception)
		{
		}
	}

	public static string M1544()
	{
		return Application.persistentDataPath;
	}

	private static void M1545(string filename, sbyte[] data)
	{
		string text = M1544() + "/" + filename;
		FileStream fileStream = new FileStream(text, FileMode.Create);
		fileStream.Write(ArrayCast.M1(data), 0, data.Length);
		fileStream.Flush();
		fileStream.Close();
		Main.setBackupIcloud(text);
	}

	private static sbyte[] M1546(string filename)
	{
		try
		{
			FileStream fileStream = new FileStream(M1544() + "/" + filename, FileMode.Open);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
			ArrayCast.M0(array);
			return ArrayCast.M0(array);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void M1547()
	{
		Cout.M330("clean rms");
		FileInfo[] files = new DirectoryInfo(M1544() + "/").GetFiles();
		for (int i = 0; i < files.Length; i++)
		{
			files[i].Delete();
		}
	}

	public static void M1548(string path)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			File.Delete(M1544() + "/" + path);
		}
		catch (Exception)
		{
		}
	}

	public static string M1549(byte[] ba)
	{
		return BitConverter.ToString(ba).Replace("-", string.Empty);
	}

	public static byte[] M1550(string hex)
	{
		int length = hex.Length;
		byte[] array = new byte[length / 2];
		for (int i = 0; i < length; i += 2)
		{
			array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
		}
		return array;
	}

	public static void M1551(string name)
	{
		try
		{
			PlayerPrefs.DeleteKey(name);
		}
		catch (Exception ex)
		{
			Cout.M326("loi xoa RMS --------------------------" + ex.ToString());
		}
	}

	public static void M1552()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M1551("data");
		M1551("dataVersion");
		M1551("map");
		M1551("mapVersion");
		M1551("skill");
		M1551("killVersion");
		M1551("item");
		M1551("itemVersion");
	}

	public static void M1553(string strID)
	{
		M1538("NRIPlink", strID);
	}

	public static string M1554()
	{
		string text = M1536("NRIPlink");
		if (text == null)
		{
			return null;
		}
		return text;
	}
}
