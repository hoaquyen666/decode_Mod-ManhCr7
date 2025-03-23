namespace N5.N6.N9;

public class T211
{
	public T60 img;

	public int id;

	public int timePaint;

	public int timeUpdate;

	public T211(T60 img, int id)
	{
		this.img = img;
		this.id = id;
		timePaint = 0;
		timeUpdate = 0;
	}

	public void M2313(T99 g, int transform, int x, int y, int anchor)
	{
		g.M940(img, 0, 0, T99.M958(img), T99.M959(img), transform, x, y, anchor);
		if (T51.gameTick % 1000 == 0)
		{
			timePaint++;
			timeUpdate = timePaint;
		}
	}

	public void M2314(T99 g, int transform, int f, int x, int y, int w, int h, int anchor)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M2315(g, transform, f, x, y, w, h, anchor, isClip: false);
	}

	public void M2315(T99 g, int transform, int f, int x, int y, int w, int h, int anchor, bool isClip)
	{
		if (T99.M958(img) != 1)
		{
			g.M942(img, 0, f * w, w, h, transform, x, y, anchor, isClip);
			if (T51.gameTick % 1000 == 0)
			{
				timePaint++;
				timeUpdate = timePaint;
			}
		}
	}

	public void M2316()
	{
		timeUpdate++;
		if (timeUpdate - timePaint > 1 && !T13.M113().M196(id))
		{
			T157.imgNew[id] = null;
		}
	}
}
