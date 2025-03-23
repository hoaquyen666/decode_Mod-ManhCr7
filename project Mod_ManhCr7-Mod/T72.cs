public class T72 : T115
{
	public T72()
	{
	}

	public T72(sbyte[] data)
	{
		buffer = data;
	}

	public T72(string filename)
		: base(filename)
	{
	}
}
