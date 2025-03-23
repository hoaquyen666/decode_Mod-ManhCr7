public class T19 : T57
{
	public int id;

	public int type;

	public int playerId;

	public string playerName;

	public long time;

	public int headId;

	public string[] chat;

	public sbyte color;

	public sbyte role;

	private int timeAgo;

	public int recieve;

	public int maxCap;

	public string[] option;

	public static T117 vMessage = new T117();

	public static void M290(T19 cm, int index, bool upToTop)
	{
		for (int i = 0; i < vMessage.M1113(); i++)
		{
			T19 t = (T19)vMessage.M1114(i);
			if (t.id != cm.id)
			{
				if (t.maxCap != 0 && t.recieve == t.maxCap)
				{
					vMessage.M1119(t);
				}
				continue;
			}
			vMessage.M1119(t);
			if (!upToTop)
			{
				vMessage.M1121(cm, i);
			}
			else
			{
				vMessage.M1121(cm, 0);
			}
			return;
		}
		if (index == -1)
		{
			vMessage.M1111(cm);
		}
		else
		{
			vMessage.M1121(cm, 0);
		}
		if (vMessage.M1113() > 20)
		{
			vMessage.M1118(vMessage.M1113() - 1);
		}
	}

	public void M291(T99 g, int x, int y)
	{
		T98 t = T98.tahoma_7b_dark;
		if (role == 0)
		{
			t = T98.tahoma_7b_red;
		}
		else if (role == 1)
		{
			t = T98.tahoma_7b_green;
		}
		else if (role == 2)
		{
			t = T98.tahoma_7b_green2;
		}
		if (type == 0)
		{
			t.M898(g, playerName, x + 3, y + 1, 0);
			if (color == 0)
			{
				T98.tahoma_7_grey.M898(g, chat[0] + ((chat.Length <= 1) ? string.Empty : "..."), x + 3, y + 11, 0);
			}
			else
			{
				T98.tahoma_7_red.M898(g, chat[0] + ((chat.Length <= 1) ? string.Empty : "..."), x + 3, y + 11, 0);
			}
			T98.tahoma_7_grey.M898(g, T122.M1193(timeAgo) + " " + mResources.ago, x + T51.panel.wScroll - 3, y + 1, T98.RIGHT);
		}
		if (type == 1)
		{
			t.M898(g, playerName + " (" + recieve + "/" + maxCap + ")", x + 3, y + 1, 0);
			T98.tahoma_7_blue.M898(g, mResources.request_pea + " " + T122.M1193(timeAgo) + " " + mResources.ago, x + 3, y + 11, 0);
		}
		if (type == 2)
		{
			t.M898(g, playerName, x + 3, y + 1, 0);
			T98.tahoma_7_blue.M898(g, mResources.request_join_clan, x + 3, y + 11, 0);
		}
	}

	public void perform(int idAction, object p)
	{
	}

	public void M292()
	{
		if ((ulong)time > 0uL)
		{
			timeAgo = (int)(T110.M1054() / 1000L - time);
		}
	}
}
