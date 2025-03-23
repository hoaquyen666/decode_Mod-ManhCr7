public class T85
{
	public static T112 itemTemplates = new T112();

	public static void M833(T84 it)
	{
		itemTemplates.M1078(it.id, it);
	}

	public static T84 M834(short id)
	{
		return (T84)itemTemplates.M1074(id);
	}

	public static short M835(short itemTemplateID)
	{
		return M834(itemTemplateID).part;
	}

	public static short M836(short itemTemplateID)
	{
		return M834(itemTemplateID).iconID;
	}
}
