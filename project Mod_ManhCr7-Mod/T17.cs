public class T17
{
	public int ID;

	public string name;

	public short[] idImage;

	public int xu;

	public int luong;

	public static T117 vClanImage = new T117();

	public static T112 idImages = new T112();

	public static void M287(T17 cm)
	{
		T146.M1594().M1611((sbyte)cm.ID);
		vClanImage.M1111(cm);
	}

	public static T17 M288(sbyte ID)
	{
		for (int i = 0; i < vClanImage.M1113(); i++)
		{
			T17 t = (T17)vClanImage.M1114(i);
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
			if (((T17)vClanImage.M1114(i)).ID == ID)
			{
				return true;
			}
		}
		return false;
	}
}
