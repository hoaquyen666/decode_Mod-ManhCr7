public class T131
{
	public string name;

	public string showName;

	public string status;

	public int IDDB;

	private int exp;

	public bool isReady;

	public int xu;

	public int gold;

	public string strMoney = string.Empty;

	public sbyte finishPosition;

	public bool isMaster;

	public static T60[] imgStart;

	public sbyte[] indexLv;

	public int onlineTime;

	public string M1466()
	{
		return name;
	}

	public void M1467(int m)
	{
		xu = m;
		strMoney = T51.M497(xu);
	}

	public void M1468(string name)
	{
		this.name = name;
		if (name.Length > 9)
		{
			showName = name.Substring(0, 8);
		}
		else
		{
			showName = name;
		}
	}

	public void M1469(T99 g, int x, int y)
	{
	}

	public int M1470()
	{
		return exp;
	}
}
