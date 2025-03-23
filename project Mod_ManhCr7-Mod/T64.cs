using System;
using System.Collections;

public class T64
{
	public static T112 hashImagePath = new T112();

	public static void M735(string name, T60 img, sbyte nFrame)
	{
		hashImagePath.M1078(string.Empty + name, new T92(img, nFrame));
	}

	public static T92 M736(string nameImg, T112 hash)
	{
		T92 t = (T92)hash.M1074(string.Empty + nameImg);
		if (t == null)
		{
			t = new T92();
			T92 t2 = M737(nameImg);
			if (t2 != null)
			{
				t.img = t2.img;
				t.nFrame = t2.nFrame;
			}
			hash.M1078(string.Empty + nameImg, t);
		}
		t.count = T51.timeNow / 1000L;
		if (t.img == null)
		{
			t.timeImageNull--;
			if (t.timeImageNull <= 0)
			{
				T146.M1594().M1739(nameImg);
				t.timeImageNull = 200;
			}
		}
		return t;
	}

	public static T92 M737(string nameImg)
	{
		string filename = T99.zoomLevel + "ImgByName_" + nameImg;
		T92 result = null;
		sbyte[] array = null;
		array = T138.M1535(filename);
		if (array == null)
		{
			return result;
		}
		try
		{
			result = new T92();
			result.nFrame = array[0];
			result.img = T60.M708(array, 1, array.Length);
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void M738(string nameImg, sbyte nFrame, sbyte[] data)
	{
		string filename = T99.zoomLevel + "ImgByName_" + nameImg;
		T29 t = new T29();
		try
		{
			t.M373(nFrame);
			for (int i = 0; i < data.Length; i++)
			{
				t.M373(data[i]);
			}
			T138.M1534(filename, t.M371());
			t.M372();
		}
		catch (Exception)
		{
		}
	}

	public static void M739(T112 hash, int minute, bool isTrue)
	{
		T117 t = new T117("checkDelHash");
		if (isTrue)
		{
			hash.M1075();
			return;
		}
		IDictionaryEnumerator dictionaryEnumerator = hash.M1076();
		while (dictionaryEnumerator.MoveNext())
		{
			T92 t2 = (T92)dictionaryEnumerator.Value;
			if (T51.timeNow / 1000L - t2.count > minute * 60)
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
