public class T97
{
	public sbyte command;

	private T115 dis;

	private T118 dos;

	public T97(int command)
	{
		this.command = (sbyte)command;
		dos = new T118();
	}

	public T97()
	{
		dos = new T118();
	}

	public T97(sbyte command)
	{
		this.command = command;
		dos = new T118();
	}

	public T97(sbyte command, sbyte[] data)
	{
		this.command = command;
		dis = new T115(data);
	}

	public sbyte[] M886()
	{
		return dos.M1144();
	}

	public T115 M887()
	{
		return dis;
	}

	public T118 M888()
	{
		return dos;
	}

	public int M889()
	{
		return dis.M1094();
	}

	public void M890()
	{
	}
}
