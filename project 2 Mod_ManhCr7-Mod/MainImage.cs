public class MainImage
{
	public Image img;

	public long count = -1L;

	public int timeImageNull;

	public int idImage;

	public long timerequest;

	public sbyte nFrame = 1;

	public long timeUse = mSystem.M1054();

	public MainImage()
	{
	}

	public MainImage(Image im, sbyte nFrame)
	{
		img = im;
		count = 0L;
		this.nFrame = nFrame;
	}
}
