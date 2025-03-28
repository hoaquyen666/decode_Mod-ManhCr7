public class ItemTemplates
{
	public static MyHashTable itemTemplates = new MyHashTable();

	public static void M833(ItemTemplate it)
	{
		itemTemplates.M1078(it.id, it);
	}

	public static ItemTemplate M834(short id)
	{
		return (ItemTemplate)itemTemplates.M1074(id);
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
