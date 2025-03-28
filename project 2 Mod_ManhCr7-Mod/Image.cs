using System;
using System.Threading;
using UnityEngine;

public class Image
{
	private const int INTERVAL = 5;

	private const int MAXTIME = 500;

	public Texture2D texture = new Texture2D(1, 1);

	public static Image imgTemp;

	public static string filenametemp;

	public static byte[] datatemp;

	public static Image imgSrcTemp;

	public static int xtemp;

	public static int ytemp;

	public static int wtemp;

	public static int htemp;

	public static int transformtemp;

	public int w;

	public int h;

	public static int status;

	public Color colorBlend = Color.black;

	public static Image M702()
	{
		return M723();
	}

	public static Image M703(string filename)
	{
		return M720(filename);
	}

	public static Image M704(byte[] imageData)
	{
		return M721(imageData);
	}

	public static Image M705(Image src, int x, int y, int w, int h, int transform)
	{
		return M722(src, x, y, w, h, transform);
	}

	public static Image M706(int w, int h)
	{
		return M724(w, h);
	}

	public static Image M707(Image img)
	{
		Image t = M706(img.w, img.h);
		t.texture = img.texture;
		t.texture.Apply();
		return t;
	}

	public static Image M708(sbyte[] imageData, int offset, int lenght)
	{
		if (offset + lenght > imageData.Length)
		{
			return null;
		}
		byte[] array = new byte[lenght];
		for (int i = 0; i < lenght; i++)
		{
			array[i] = M709(imageData[i + offset]);
		}
		return M704(array);
	}

	public static byte M709(sbyte var)
	{
		if (var > 0)
		{
			return (byte)var;
		}
		return (byte)(var + 256);
	}

	public static byte[] M710(sbyte[] var)
	{
		byte[] array = new byte[var.Length];
		for (int i = 0; i < var.Length; i++)
		{
			if (var[i] > 0)
			{
				array[i] = (byte)var[i];
			}
			else
			{
				array[i] = (byte)(var[i] + 256);
			}
		}
		return array;
	}

	public static Image M711(int[] rbg, int w, int h, bool bl)
	{
		Image t = M706(w, h);
		Color[] array = new Color[rbg.Length];
		for (int i = 0; i < array.Length; i++)
		{
			ref Color reference = ref array[i];
			reference = M712(rbg[i]);
		}
		t.texture.SetPixels(0, 0, w, h, array);
		t.texture.Apply();
		return t;
	}

	public static Color M712(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float b = (float)num / 256f;
		float g = (float)num2 / 256f;
		return new Color((float)num3 / 256f, g, b);
	}

	public static void M713()
	{
		if (status == 2)
		{
			status = 1;
			imgTemp = M723();
			status = 0;
		}
		else if (status == 3)
		{
			status = 1;
			imgTemp = M720(filenametemp);
			status = 0;
		}
		else if (status == 4)
		{
			status = 1;
			imgTemp = M721(datatemp);
			status = 0;
		}
		else if (status == 5)
		{
			status = 1;
			imgTemp = M722(imgSrcTemp, xtemp, ytemp, wtemp, htemp, transformtemp);
			status = 0;
		}
		else if (status == 6)
		{
			status = 1;
			imgTemp = M724(wtemp, htemp);
			status = 0;
		}
	}

	private static Image M714()
	{
		if (status != 0)
		{
			Cout.M328("CANNOT CREATE EMPTY IMAGE WHEN CREATING OTHER IMAGE");
			return null;
		}
		imgTemp = null;
		status = 2;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 500)
		{
			Cout.M328("TOO LONG FOR CREATE EMPTY IMAGE");
			status = 0;
		}
		return imgTemp;
	}

	private static Image M715(string filename)
	{
		if (status != 0)
		{
			Cout.M328("CANNOT CREATE IMAGE " + filename + " WHEN CREATING OTHER IMAGE");
			return null;
		}
		imgTemp = null;
		filenametemp = filename;
		status = 3;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 500)
		{
			Cout.M328("TOO LONG FOR CREATE IMAGE " + filename);
			status = 0;
		}
		return imgTemp;
	}

	private static Image M716(byte[] imageData)
	{
		if (status != 0)
		{
			Cout.M328("CANNOT CREATE IMAGE(FromArray) WHEN CREATING OTHER IMAGE");
			return null;
		}
		imgTemp = null;
		datatemp = imageData;
		status = 4;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 500)
		{
			Cout.M328("TOO LONG FOR CREATE IMAGE(FromArray)");
			status = 0;
		}
		return imgTemp;
	}

	private static Image M717(Image src, int x, int y, int w, int h, int transform)
	{
		if (status != 0)
		{
			Cout.M328("CANNOT CREATE IMAGE(FromSrcPart) WHEN CREATING OTHER IMAGE");
			return null;
		}
		imgTemp = null;
		imgSrcTemp = src;
		xtemp = x;
		ytemp = y;
		wtemp = w;
		htemp = h;
		transformtemp = transform;
		status = 5;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 500)
		{
			Cout.M328("TOO LONG FOR CREATE IMAGE(FromSrcPart)");
			status = 0;
		}
		return imgTemp;
	}

	private static Image M718(int w, int h)
	{
		if (status != 0)
		{
			Cout.M328("CANNOT CREATE IMAGE(w,h) WHEN CREATING OTHER IMAGE");
			return null;
		}
		imgTemp = null;
		wtemp = w;
		htemp = h;
		status = 6;
		int i;
		for (i = 0; i < 500; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 500)
		{
			Cout.M328("TOO LONG FOR CREATE IMAGE(w,h)");
			status = 0;
		}
		return imgTemp;
	}

	public static byte[] M719(string filename)
	{
		new Image();
		TextAsset textAsset = (TextAsset)Resources.Load(filename, typeof(TextAsset));
		if (textAsset == null || textAsset.bytes == null || textAsset.bytes.Length == 0)
		{
			throw new Exception("NULL POINTER EXCEPTION AT Image __createImage " + filename);
		}
		Debug.LogError("CHIEU DAI MANG BYTE IMAGE CREAT = " + ArrayCast.M0(textAsset.bytes).Length);
		return textAsset.bytes;
	}

	private static Image M720(string filename)
	{
		Image t = new Image();
		Texture2D texture2D = Resources.Load(filename) as Texture2D;
		if (texture2D == null)
		{
			throw new Exception("NULL POINTER EXCEPTION AT Image __createImage " + filename);
		}
		t.texture = texture2D;
		t.w = t.texture.width;
		t.h = t.texture.height;
		M729(t);
		return t;
	}

	public static Image M721(byte[] imageData)
	{
		if (imageData != null && imageData.Length != 0)
		{
			Image t = new Image();
			try
			{
				t.texture.LoadImage(imageData);
				t.w = t.texture.width;
				t.h = t.texture.height;
				M729(t);
				return t;
			}
			catch (Exception)
			{
				Cout.M328("CREAT IMAGE FROM ARRAY FAIL \n" + Environment.StackTrace);
				return t;
			}
		}
		Cout.M328("Create Image from byte array fail");
		return null;
	}

	private static Image M722(Image src, int x, int y, int w, int h, int transform)
	{
		Image t = new Image();
		t.texture = new Texture2D(w, h);
		y = src.texture.height - y - h;
		for (int i = 0; i < w; i++)
		{
			for (int j = 0; j < h; j++)
			{
				int num = i;
				if (transform == 2)
				{
					num = w - i;
				}
				t.texture.SetPixel(i, j, src.texture.GetPixel(x + num, y + j));
			}
		}
		t.texture.Apply();
		t.w = t.texture.width;
		t.h = t.texture.height;
		M729(t);
		return t;
	}

	private static Image M723()
	{
		return new Image();
	}

	public static Image M724(int w, int h)
	{
		Image t = new Image
		{
			texture = new Texture2D(w, h, TextureFormat.RGBA32, mipmap: false)
		};
		M729(t);
		t.w = w;
		t.h = h;
		t.texture.Apply();
		return t;
	}

	public static int M725(Image image)
	{
		return image.M727();
	}

	public static int M726(Image image)
	{
		return image.M728();
	}

	public int M727()
	{
		return w / mGraphics.zoomLevel;
	}

	public int M728()
	{
		return h / mGraphics.zoomLevel;
	}

	private static void M729(Image img)
	{
		M730(img.texture);
	}

	public static void M730(Texture2D texture)
	{
		texture.anisoLevel = 0;
		texture.filterMode = FilterMode.Point;
		texture.mipMapBias = 0f;
		texture.wrapMode = TextureWrapMode.Clamp;
	}

	public Color[] M731()
	{
		return texture.GetPixels();
	}

	public int M732()
	{
		return w;
	}

	public int M733()
	{
		return h;
	}

	public void M734(ref int[] data, int x1, int x2, int x, int y, int w, int h)
	{
		Color[] pixels = texture.GetPixels(x, this.h - 1 - y, w, h);
		for (int i = 0; i < pixels.Length; i++)
		{
			data[i] = mGraphics.M965(pixels[i]);
		}
	}
}
