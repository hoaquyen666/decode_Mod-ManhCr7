public class T107
{
	public int xEnd;

	public int yEnd;

	public int dir;

	public int cvx;

	public int cvy;

	public int status;

	public T107(int xEnd, int yEnd, int act, int dir)
	{
		this.xEnd = xEnd;
		this.yEnd = yEnd;
		this.dir = dir;
		status = act;
	}

	public T107(int xEnd, int yEnd)
	{
		this.xEnd = xEnd;
		this.yEnd = yEnd;
	}
}
