public class ClanImage
{
	public int ID;

	public string name;

	public short[] idImage;

	public int xu;

	public int luong;

	public static MyVector vClanImage = new MyVector();

	public static MyHashTable idImages = new MyHashTable();

	public static void M287(ClanImage cm)
	{
		Service.M1594().M1611((sbyte)cm.ID);
		vClanImage.M1111(cm);
	}

	public static ClanImage M288(sbyte ID)
	{
		for (int i = 0; i < vClanImage.M1113(); i++)
		{
			ClanImage t = (ClanImage)vClanImage.M1114(i);
			if (t.ID == ID)
			{
				return t;
			}
		}
		return null;
	}

	public static bool M289(int ID)
	{
		for (int i = 0; i < vClanImage.M1113(); i++)
		{
			if (((ClanImage)vClanImage.M1114(i)).ID == ID)
			{
				return true;
			}
		}
		return false;
	}
}
