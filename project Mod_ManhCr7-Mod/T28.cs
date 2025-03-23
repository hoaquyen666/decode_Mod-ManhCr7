using System;
using System.Threading;
using UnityEngine;

public class T28
{
	public T115 r;

	private const int INTERVAL = 5;

	private const int MAXTIME = 500;

	public static T28 istemp;

	private static int status;

	private static string filenametemp;

	public T28(string filename)
	{
		r = new T115(T4.M0(((TextAsset)Resources.Load(filename, typeof(TextAsset))).bytes));
	}

	public T28(sbyte[] data)
	{
		r = new T115(data);
	}

	public static void M349()
	{
		if (status == 2)
		{
			status = 1;
			istemp = M352(filenametemp);
			status = 0;
		}
	}

	public static T28 M350(string filename)
	{
		return M352(filename);
	}

	private static T28 M351(string filename)
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
				Debug.LogError("CANNOT GET INPUTSTREAM " + filename + " WHEN GETTING " + filenametemp);
				return null;
			}
		}
		istemp = null;
		filenametemp = filename;
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
			Debug.LogError("TOO LONG FOR CREATE INPUTSTREAM " + filename);
			status = 0;
			return null;
		}
		return istemp;
	}

	private static T28 M352(string filename)
	{
		try
		{
			return new T28(filename);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public short M353()
	{
		return r.M1092();
	}

	public int M354()
	{
		return r.M1094();
	}

	public int M355()
	{
		return r.M1091();
	}

	public void M356(ref sbyte[] data)
	{
		r.M1102(ref data);
	}

	public void M357()
	{
		r.M1107();
	}

	public void M358()
	{
		r.M1107();
	}

	public string M359()
	{
		return r.M1100();
	}

	public sbyte M360()
	{
		return r.M1088();
	}

	public long M361()
	{
		return r.M1095();
	}

	public bool M362()
	{
		return r.M1097();
	}

	public int M363()
	{
		return (byte)r.M1088();
	}

	public int M364()
	{
		return r.M1093();
	}

	public void M365(ref sbyte[] data)
	{
		r.M1102(ref data);
	}

	public int M366()
	{
		return r.M1104();
	}

	internal void M367(ref sbyte[] byteData, int p, int size)
	{
		throw new NotImplementedException();
	}
}
