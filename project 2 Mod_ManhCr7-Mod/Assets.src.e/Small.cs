namespace Assets.src.e;

public class Small
{
	public Image img;

	public int id;

	public int timePaint;

	public int timeUpdate;

	public Small(Image img, int id)
	{
		this.img = img;
		this.id = id;
		timePaint = 0;
		timeUpdate = 0;
	}

	public void M2313(mGraphics g, int transform, int x, int y, int anchor)
	{
		g.M940(img, 0, 0, mGraphics.M958(img), mGraphics.M959(img), transform, x, y, anchor);
		if (GameCanvas.gameTick % 1000 == 0)
		{
			timePaint++;
			timeUpdate = timePaint;
		}
	}

	public void M2314(mGraphics g, int transform, int f, int x, int y, int w, int h, int anchor)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M2315(g, transform, f, x, y, w, h, anchor, isClip: false);
	}

	public void M2315(mGraphics g, int transform, int f, int x, int y, int w, int h, int anchor, bool isClip)
	{
		if (mGraphics.M958(img) != 1)
		{
			g.M942(img, 0, f * w, w, h, transform, x, y, anchor, isClip);
			if (GameCanvas.gameTick % 1000 == 0)
			{
				timePaint++;
				timeUpdate = timePaint;
			}
		}
	}

	public void M2316()
	{
		timeUpdate++;
		if (timeUpdate - timePaint > 1 && !Char.M113().M196(id))
		{
			SmallImage.imgNew[id] = null;
		}
	}
}
