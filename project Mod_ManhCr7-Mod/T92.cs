public class T92
{
	public T60 img;

	public long count = -1L;

	public int timeImageNull;

	public int idImage;

	public long timerequest;

	public sbyte nFrame = 1;

	public long timeUse = T110.M1054();

	public T92()
	{
	}

	public T92(T60 im, sbyte nFrame)
	{
		img = im;
		count = 0L;
		this.nFrame = nFrame;
	}
}
