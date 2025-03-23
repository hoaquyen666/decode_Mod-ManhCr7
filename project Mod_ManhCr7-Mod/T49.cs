using System;

public class T49
{
	public int frameWidth;

	public int frameHeight;

	public int nFrame;

	public T60 imgFrame;

	public int Id = -1;

	public int numWidth;

	public int numHeight;

	public T49(int ID)
	{
		Id = ID;
		T60 t = T43.M416(ID);
		if (t != null)
		{
			imgFrame = t;
			frameWidth = T43.arrInfoEff[ID][0];
			frameHeight = T43.arrInfoEff[ID][1] / T43.arrInfoEff[ID][2];
			nFrame = T43.arrInfoEff[ID][2];
		}
	}

	public T49(T60 img, int width, int height)
	{
		if (img != null)
		{
			imgFrame = img;
			frameWidth = width;
			frameHeight = height;
			nFrame = img.M728() / height;
			if (nFrame < 1)
			{
				nFrame = 1;
			}
		}
	}

	public T49(T60 img, int numW, int numH, int numNull)
	{
		if (img != null)
		{
			imgFrame = img;
			numWidth = numW;
			numHeight = numH;
			frameWidth = imgFrame.M727() / numW;
			frameHeight = imgFrame.M728() / numH;
			nFrame = numW * numH - numNull;
		}
	}

	public void M439(int idx, int x, int y, int trans, int anchor, T99 g)
	{
		try
		{
			if (imgFrame != null)
			{
				if (idx > nFrame)
				{
					idx = nFrame;
				}
				int num = idx * frameHeight;
				if (num > frameHeight * (nFrame - 1) || num < 0)
				{
					num = frameHeight * (nFrame - 1);
				}
				g.M940(imgFrame, 0, idx * frameHeight, frameWidth, frameHeight, trans, x, y, anchor);
			}
		}
		catch (Exception)
		{
		}
	}
}
