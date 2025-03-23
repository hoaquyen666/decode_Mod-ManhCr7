public class T67
{
	public string s;

	private T98 f;

	public int speed = 70;

	public T13 charInfo;

	public bool isChatServer;

	public bool isOnline;

	public int timeCount;

	public int maxTime;

	public long last;

	public long curr;

	public T67(string s)
	{
		f = T98.tahoma_7_green2;
		this.s = s;
		speed = 20;
	}

	public T67(string s, T98 f, int speed)
	{
		this.f = f;
		this.s = s;
		this.speed = speed;
	}
}
