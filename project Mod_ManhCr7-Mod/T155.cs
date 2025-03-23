public class T155
{
	public sbyte id;

	public int classId;

	public string name;

	public int maxPoint;

	public int manaUseType;

	public int type;

	public int iconId;

	public string[] description;

	public T149[] skills;

	public string damInfo;

	public bool M1774()
	{
		if (type == 2)
		{
			return true;
		}
		return false;
	}

	public bool M1775()
	{
		if (type == 3)
		{
			return true;
		}
		return false;
	}

	public bool M1776()
	{
		if (type == 1)
		{
			return true;
		}
		return false;
	}
}
