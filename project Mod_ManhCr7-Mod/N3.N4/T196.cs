using System;

namespace N3.N4;

public class T196
{
	public string NameBoss;

	public string MapName;

	public int MapId;

	public DateTime AppearTime;

	public T196()
	{
	}

	public T196(string chatVip)
	{
		chatVip = chatVip.Replace("BOSS ", "").Replace(" vừa xuất hiện tại ", "|").Replace(" appear at ", "|");
		string[] array = chatVip.Split('|');
		NameBoss = array[0].Trim();
		MapName = array[1].Trim();
		MapId = M2160(MapName);
		AppearTime = DateTime.Now;
	}

	public int M2160(string mapName)
	{
		int num = 0;
		while (true)
		{
			if (num < T174.mapNames.Length)
			{
				if (T174.mapNames[num].Equals(mapName))
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public void M2161(T99 g, int x, int y, int align)
	{
		TimeSpan timeSpan = DateTime.Now.Subtract(AppearTime);
		int num = (int)timeSpan.TotalSeconds;
		if (T174.mapID == MapId)
		{
			for (int i = 0; i < T54.vCharInMap.M1113() && !((T13)T54.vCharInMap.M1114(i)).cName.Equals(NameBoss); i++)
			{
			}
		}
		T98.tahoma_7_yellow.M898(g, NameBoss + " - " + MapName + " - " + ((num < 60) ? (num + "s") : (timeSpan.Minutes + "ph")) + " trước", x, y, align);
	}
}
