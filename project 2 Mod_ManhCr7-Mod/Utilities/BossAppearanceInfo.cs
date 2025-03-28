using System;

namespace Utilities;

public class BossAppearanceInfo
{
	public string NameBoss;

	public string MapName;

	public int MapId;

	public DateTime AppearTime;

	public BossAppearanceInfo()
	{
	}

	public BossAppearanceInfo(string chatVip)
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
			if (num < TileMap.mapNames.Length)
			{
				if (TileMap.mapNames[num].Equals(mapName))
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

	public void M2161(mGraphics g, int x, int y, int align)
	{
		TimeSpan timeSpan = DateTime.Now.Subtract(AppearTime);
		int num = (int)timeSpan.TotalSeconds;
		if (TileMap.mapID == MapId)
		{
			for (int i = 0; i < GameScr.vCharInMap.M1113() && !((Char)GameScr.vCharInMap.M1114(i)).cName.Equals(NameBoss); i++)
			{
			}
		}
		mFont.tahoma_7_yellow.M898(g, NameBoss + " - " + MapName + " - " + ((num < 60) ? (num + "s") : (timeSpan.Minutes + "ph")) + " trước", x, y, align);
	}
}
