using System;
using System.Threading;
using UnityEngine;

public class T60
{
	private const int INTERVAL = 5;

	private const int MAXTIME = 500;

	public Texture2D texture = new Texture2D(1, 1);

	public static T60 imgTemp;

	public static string filenametemp;

	public static byte[] datatemp;

	public static T60 imgSrcTemp;

	public static int xtemp;

	public static int ytemp;

	public static int wtemp;

	public static int htemp;

	public static int transformtemp;

	public int w;

	public int h;

	public static int status;

	public Color colorBlend = Color.black;

	public static T60 M702()
	{
		return M723();
	}

	public static T60 M703(string filename)
	{
		return M720(filename);
	}

	public static T60 M704(byte[] imageData)
	{
		return M721(imageData);
	}

	public static T60 M705(T60 src, int x, int y, int w, int h, int transform)
	{
		return M722(src, x, y, w, h, transform);
	}

	public static T60 M706(int w, int h)
	{
		return M724(w, h);
	}

	public static T60 M707(T60 img)
	{
		T60 t = M706(img.w, img.h);
		t.texture = img.texture;
		t.texture.Apply();
		return t;
	}

	public static T60 M708(sbyte[] imageData, int offset, int lenght)
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

	public static T60 M711(int[] rbg, int w, int h, bool bl)
	{
		T60 t = M706(w, h);
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

	private static T60 M714()
	{
		if (status != 0)
		{
			T24.M328("CANNOT CREATE EMPTY IMAGE WHEN CREATING OTHER IMAGE");
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
			T24.M328("TOO LONG FOR CREATE EMPTY IMAGE");
			status = 0;
		}
		return imgTemp;
	}

	private static T60 M715(string filename)
	{
		if (status != 0)
		{
			T24.M328("CANNOT CREATE IMAGE " + filename + " WHEN CREATING OTHER IMAGE");
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
			T24.M328("TOO LONG FOR CREATE IMAGE " + filename);
			status = 0;
		}
		return imgTemp;
	}

	private static T60 M716(byte[] imageData)
	{
		if (status != 0)
		{
			T24.M328("CANNOT CREATE IMAGE(FromArray) WHEN CREATING OTHER IMAGE");
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
			T24.M328("TOO LONG FOR CREATE IMAGE(FromArray)");
			status = 0;
		}
		return imgTemp;
	}

	private static T60 M717(T60 src, int x, int y, int w, int h, int transform)
	{
		if (status != 0)
		{
			T24.M328("CANNOT CREATE IMAGE(FromSrcPart) WHEN CREATING OTHER IMAGE");
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
			T24.M328("TOO LONG FOR CREATE IMAGE(FromSrcPart)");
			status = 0;
		}
		return imgTemp;
	}

	private static T60 M718(int w, int h)
	{
		if (status != 0)
		{
			T24.M328("CANNOT CREATE IMAGE(w,h) WHEN CREATING OTHER IMAGE");
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
			T24.M328("TOO LONG FOR CREATE IMAGE(w,h)");
			status = 0;
		}
		return imgTemp;
	}

	public static byte[] M719(string filename)
	{
		new T60();
		TextAsset textAsset = (TextAsset)Resources.Load(filename, typeof(TextAsset));
		if (textAsset == null || textAsset.bytes == null || textAsset.bytes.Length == 0)
		{
			throw new Exception("NULL POINTER EXCEPTION AT Image __createImage " + filename);
		}
		Debug.LogError("CHIEU DAI MANG BYTE IMAGE CREAT = " + T4.M0(textAsset.bytes).Length);
		return textAsset.bytes;
	}

	private static T60 M720(string filename)
	{
		T60 t = new T60();
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

	public static T60 M721(byte[] imageData)
	{
		if (imageData != null && imageData.Length != 0)
		{
			T60 t = new T60();
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
				T24.M328("CREAT IMAGE FROM ARRAY FAIL \n" + Environment.StackTrace);
				return t;
			}
		}
		T24.M328("Create Image from byte array fail");
		return null;
	}

	private static T60 M722(T60 src, int x, int y, int w, int h, int transform)
	{
		T60 t = new T60();
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

	private static T60 M723()
	{
		return new T60();
	}

	public static T60 M724(int w, int h)
	{
		T60 t = new T60
		{
			texture = new Texture2D(w, h, TextureFormat.RGBA32, mipmap: false)
		};
		M729(t);
		t.w = w;
		t.h = h;
		t.texture.Apply();
		return t;
	}

	public static int M725(T60 image)
	{
		return image.M727();
	}

	public static int M726(T60 image)
	{
		return image.M728();
	}

	public int M727()
	{
		return w / T99.zoomLevel;
	}

	public int M728()
	{
		return h / T99.zoomLevel;
	}

	private static void M729(T60 img)
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
			data[i] = T99.M965(pixels[i]);
		}
	}
}
