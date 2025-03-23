public class T127
{
	public int type;

	public T128[] pi;

	public T127(int type)
	{
		this.type = type;
		if (type == 0)
		{
			pi = new T128[3];
		}
		if (type == 1)
		{
			pi = new T128[17];
		}
		if (type == 2)
		{
			pi = new T128[14];
		}
		if (type == 3)
		{
			pi = new T128[2];
		}
	}
}
