using System;

public class EffectData
{
	public Image img;

	public ImageInfo[] imgInfo;

	public Frame[] frame;

	public short[] arrFrame;

	public int ID;

	public int typeData;

	public int width;

	public int height;

	public ImageInfo M394(sbyte id)
	{
		for (int i = 0; i < imgInfo.Length; i++)
		{
			if (imgInfo[i].ID == id)
			{
				return imgInfo[i];
			}
		}
		return null;
	}

	public void M395(string patch)
	{
		DataInputStream t = null;
		try
		{
			t = MyStream.M1110(patch);
		}
		catch (Exception)
		{
			return;
		}
		M398(t.r);
	}

	public void M396(string patch)
	{
		DataInputStream t = null;
		try
		{
			t = MyStream.M1110(patch);
		}
		catch (Exception)
		{
			return;
		}
		M397(t.r);
	}

	public void M397(myReader msg)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		try
		{
			sbyte b = msg.M1088();
			Res.M1513("size IMG==========" + b);
			imgInfo = new ImageInfo[b];
			for (int i = 0; i < b; i++)
			{
				imgInfo[i] = new ImageInfo();
				imgInfo[i].ID = msg.M1088();
				imgInfo[i].x0 = msg.M1091();
				imgInfo[i].y0 = msg.M1091();
				imgInfo[i].w = msg.M1091();
				imgInfo[i].h = msg.M1091();
			}
			frame = new Frame[msg.M1092()];
			for (int j = 0; j < frame.Length; j++)
			{
				frame[j] = new Frame();
				sbyte b2 = msg.M1088();
				frame[j].dx = new short[b2];
				frame[j].dy = new short[b2];
				frame[j].idImg = new sbyte[b2];
				for (int k = 0; k < b2; k++)
				{
					frame[j].dx[k] = msg.M1092();
					frame[j].dy[k] = msg.M1092();
					frame[j].idImg[k] = msg.M1088();
					if (j == 0)
					{
						if (num > frame[j].dx[k])
						{
							num = frame[j].dx[k];
						}
						if (num2 > frame[j].dy[k])
						{
							num2 = frame[j].dy[k];
						}
						if (num3 < frame[j].dx[k] + imgInfo[frame[j].idImg[k]].w)
						{
							num3 = frame[j].dx[k] + imgInfo[frame[j].idImg[k]].w;
						}
						if (num4 < frame[j].dy[k] + imgInfo[frame[j].idImg[k]].h)
						{
							num4 = frame[j].dy[k] + imgInfo[frame[j].idImg[k]].h;
						}
						width = num3 - num;
						height = num4 - num2;
					}
				}
			}
			arrFrame = new short[msg.M1092()];
			for (int l = 0; l < arrFrame.Length; l++)
			{
				arrFrame[l] = msg.M1092();
			}
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
			Res.M1513("1");
		}
	}

	public void M398(myReader iss)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		try
		{
			sbyte b = iss.M1088();
			imgInfo = new ImageInfo[b];
			for (int i = 0; i < b; i++)
			{
				imgInfo[i] = new ImageInfo();
				imgInfo[i].ID = iss.M1088();
				imgInfo[i].x0 = iss.M1088();
				imgInfo[i].y0 = iss.M1088();
				imgInfo[i].w = iss.M1088();
				imgInfo[i].h = iss.M1088();
			}
			short num5 = iss.M1092();
			frame = new Frame[num5];
			for (int j = 0; j < num5; j++)
			{
				frame[j] = new Frame();
				sbyte b2 = iss.M1088();
				frame[j].dx = new short[b2];
				frame[j].dy = new short[b2];
				frame[j].idImg = new sbyte[b2];
				for (int k = 0; k < b2; k++)
				{
					frame[j].dx[k] = iss.M1092();
					frame[j].dy[k] = iss.M1092();
					frame[j].idImg[k] = iss.M1088();
					if (j == 0)
					{
						if (num > frame[j].dx[k])
						{
							num = frame[j].dx[k];
						}
						if (num2 > frame[j].dy[k])
						{
							num2 = frame[j].dy[k];
						}
						if (num3 < frame[j].dx[k] + imgInfo[frame[j].idImg[k]].w)
						{
							num3 = frame[j].dx[k] + imgInfo[frame[j].idImg[k]].w;
						}
						if (num4 < frame[j].dy[k] + imgInfo[frame[j].idImg[k]].h)
						{
							num4 = frame[j].dy[k] + imgInfo[frame[j].idImg[k]].h;
						}
						width = num3 - num;
						height = num4 - num2;
					}
				}
			}
			short num6 = iss.M1092();
			arrFrame = new short[num6];
			for (int l = 0; l < num6; l++)
			{
				arrFrame[l] = iss.M1092();
			}
		}
		catch (Exception ex)
		{
			Cout.M328("LOI TAI readData cua EffectDAta" + ex.ToString());
		}
	}

	public void M399(sbyte[] data)
	{
		M398(new myReader(data));
	}

	public void M400(sbyte[] data, sbyte typeread)
	{
		M402(new myReader(data), typeread);
	}

	public void M401(mGraphics g, int f, int x, int y, int trans, int layer)
	{
		if (frame == null || frame.Length == 0)
		{
			return;
		}
		Frame t = frame[f];
		for (int i = 0; i < t.dx.Length; i++)
		{
			ImageInfo t2 = M394(t.idImg[i]);
			try
			{
				if (trans == -1)
				{
					g.M940(img, t2.x0, t2.y0, t2.w, t2.h, 0, x + t.dx[i], y + t.dy[i], 0);
				}
				if (trans == 0)
				{
					g.M940(img, t2.x0, t2.y0, t2.w, t2.h, 0, x + t.dx[i], y + t.dy[i] - ((layer < 4 && layer > 0) ? GameCanvas.transY : 0), 0);
				}
				if (trans == 1)
				{
					g.M940(img, t2.x0, t2.y0, t2.w, t2.h, 2, x - t.dx[i], y + t.dy[i] - ((layer < 4 && layer > 0) ? GameCanvas.transY : 0), StaticObj.TOP_RIGHT);
				}
				if (trans == 2)
				{
					g.M940(img, t2.x0, t2.y0, t2.w, t2.h, 7, x - t.dx[i], y + t.dy[i] - ((layer < 4 && layer > 0) ? GameCanvas.transY : 0), StaticObj.VCENTER_HCENTER);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public void M402(myReader msg, sbyte typeread)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		try
		{
			sbyte b = msg.M1088();
			imgInfo = new ImageInfo[b];
			for (int i = 0; i < b; i++)
			{
				imgInfo[i] = new ImageInfo();
				imgInfo[i].ID = msg.M1088();
				if (typeread == 1)
				{
					imgInfo[i].x0 = msg.M1091();
					imgInfo[i].y0 = msg.M1091();
				}
				else
				{
					imgInfo[i].x0 = msg.M1092();
					imgInfo[i].y0 = msg.M1092();
				}
				imgInfo[i].w = msg.M1091();
				imgInfo[i].h = msg.M1091();
			}
			frame = new Frame[msg.M1092()];
			for (int j = 0; j < frame.Length; j++)
			{
				frame[j] = new Frame();
				sbyte b2 = msg.M1088();
				frame[j].dx = new short[b2];
				frame[j].dy = new short[b2];
				frame[j].idImg = new sbyte[b2];
				for (int k = 0; k < b2; k++)
				{
					frame[j].dx[k] = msg.M1092();
					frame[j].dy[k] = msg.M1092();
					frame[j].idImg[k] = msg.M1088();
					if (j == 0)
					{
						if (num > frame[j].dx[k])
						{
							num = frame[j].dx[k];
						}
						if (num2 > frame[j].dy[k])
						{
							num2 = frame[j].dy[k];
						}
						if (num3 < frame[j].dx[k] + imgInfo[frame[j].idImg[k]].w)
						{
							num3 = frame[j].dx[k] + imgInfo[frame[j].idImg[k]].w;
						}
						if (num4 < frame[j].dy[k] + imgInfo[frame[j].idImg[k]].h)
						{
							num4 = frame[j].dy[k] + imgInfo[frame[j].idImg[k]].h;
						}
						width = num3 - num;
						height = num4 - num2;
					}
				}
			}
			arrFrame = new short[msg.M1092()];
			for (int l = 0; l < arrFrame.Length; l++)
			{
				arrFrame[l] = msg.M1092();
			}
		}
		catch (Exception)
		{
		}
	}
}
