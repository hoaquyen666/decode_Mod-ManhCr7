using System;
using System.Collections;

public class ImageByName
{
	public static MyHashTable hashImagePath = new MyHashTable();

	public static void M735(string name, Image img, sbyte nFrame)
	{
		hashImagePath.M1078(string.Empty + name, new MainImage(img, nFrame));
	}

	public static MainImage M736(string nameImg, MyHashTable hash)
	{
		MainImage t = (MainImage)hash.M1074(string.Empty + nameImg);
		if (t == null)
		{
			t = new MainImage();
			MainImage t2 = M737(nameImg);
			if (t2 != null)
			{
				t.img = t2.img;
				t.nFrame = t2.nFrame;
			}
			hash.M1078(string.Empty + nameImg, t);
		}
		t.count = GameCanvas.timeNow / 1000L;
		if (t.img == null)
		{
			t.timeImageNull--;
			if (t.timeImageNull <= 0)
			{
				Service.M1594().M1739(nameImg);
				t.timeImageNull = 200;
			}
		}
		return t;
	}

	public static MainImage M737(string nameImg)
	{
		string filename = mGraphics.zoomLevel + "ImgByName_" + nameImg;
		MainImage result = null;
		sbyte[] array = null;
		array = Rms.M1535(filename);
		if (array == null)
		{
			return result;
		}
		try
		{
			result = new MainImage();
			result.nFrame = array[0];
			result.img = Image.M708(array, 1, array.Length);
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void M738(string nameImg, sbyte nFrame, sbyte[] data)
	{
		string filename = mGraphics.zoomLevel + "ImgByName_" + nameImg;
		DataOutputStream t = new DataOutputStream();
		try
		{
			t.M373(nFrame);
			for (int i = 0; i < data.Length; i++)
			{
				t.M373(data[i]);
			}
			Rms.M1534(filename, t.M371());
			t.M372();
		}
		catch (Exception)
		{
		}
	}

	public static void M739(MyHashTable hash, int minute, bool isTrue)
	{
		MyVector t = new MyVector("checkDelHash");
		if (isTrue)
		{
			hash.M1075();
			return;
		}
		IDictionaryEnumerator dictionaryEnumerator = hash.M1076();
		while (dictionaryEnumerator.MoveNext())
		{
			MainImage t2 = (MainImage)dictionaryEnumerator.Value;
			if (GameCanvas.timeNow / 1000L - t2.count > minute * 60)
			{
				t.M1111((string)dictionaryEnumerator.Key);
			}
		}
		for (int i = 0; i < t.M1113(); i++)
		{
			hash.M1079((string)t.M1114(i));
		}
	}
}
