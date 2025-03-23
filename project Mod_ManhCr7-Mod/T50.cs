public class T50
{
	public string friendName;

	public sbyte type;

	public T50(string friendName, sbyte type)
	{
		this.friendName = friendName;
		this.type = type;
	}

	public T50(string friendName)
	{
		this.friendName = friendName;
		type = 2;
	}
}
