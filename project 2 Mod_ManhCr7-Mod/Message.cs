public class Message
{
	public sbyte command;

	private myReader dis;

	private myWriter dos;

	public Message(int command)
	{
		this.command = (sbyte)command;
		dos = new myWriter();
	}

	public Message()
	{
		dos = new myWriter();
	}

	public Message(sbyte command)
	{
		this.command = command;
		dos = new myWriter();
	}

	public Message(sbyte command, sbyte[] data)
	{
		this.command = command;
		dis = new myReader(data);
	}

	public sbyte[] M886()
	{
		return dos.M1144();
	}

	public myReader M887()
	{
		return dis;
	}

	public myWriter M888()
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
