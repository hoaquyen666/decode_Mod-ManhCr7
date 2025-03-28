using System;

namespace Assets.src.g;

internal class ImageSource
{
	public sbyte version;

	public string id;

	public static MyVector vSource = new MyVector();

	public static MyVector vRms = new MyVector();

	public ImageSource(string ID, sbyte version)
	{
		id = ID;
		this.version = version;
	}

	public static void M2275()
	{
		MyVector t = new MyVector();
		sbyte[] array = Rms.M1535("ImageSource");
		if (array == null)
		{
			Service.M1594().M1731(t);
			return;
		}
		vRms = new MyVector();
		DataInputStream t2 = new DataInputStream(array);
		if (t2 == null)
		{
			return;
		}
		try
		{
			short num = t2.M353();
			string[] array2 = new string[num];
			sbyte[] array3 = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = t2.M359();
				array3[i] = t2.M360();
				vRms.M1111(new ImageSource(array2[i], array3[i]));
			}
			t2.M357();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		Res.M1513("vS size= " + vSource.M1113() + " vRMS size= " + vRms.M1113());
		for (int j = 0; j < vSource.M1113(); j++)
		{
			ImageSource t3 = (ImageSource)vSource.M1114(j);
			if (!M2278(t3.id))
			{
				t.M1111(t3);
			}
		}
		for (int k = 0; k < vRms.M1113(); k++)
		{
			ImageSource t4 = (ImageSource)vRms.M1114(k);
			if (M2276(t4.id) != M2277(t4.id))
			{
				t.M1111(t4);
			}
		}
		Service.M1594().M1731(t);
	}

	public static sbyte M2276(string id)
	{
		for (int i = 0; i < vRms.M1113(); i++)
		{
			if (id.Equals(((ImageSource)vRms.M1114(i)).id))
			{
				return ((ImageSource)vRms.M1114(i)).version;
			}
		}
		return -1;
	}

	public static sbyte M2277(string id)
	{
		for (int i = 0; i < vSource.M1113(); i++)
		{
			if (id.Equals(((ImageSource)vSource.M1114(i)).id))
			{
				return ((ImageSource)vSource.M1114(i)).version;
			}
		}
		return -1;
	}

	public static bool M2278(string id)
	{
		for (int i = 0; i < vRms.M1113(); i++)
		{
			if (id.Equals(((ImageSource)vRms.M1114(i)).id))
			{
				return true;
			}
		}
		return false;
	}

	public static void M2279()
	{
		DataOutputStream t = new DataOutputStream();
		try
		{
			t.M368((short)vSource.M1113());
			for (int i = 0; i < vSource.M1113(); i++)
			{
				t.M374(((ImageSource)vSource.M1114(i)).id);
				t.M373(((ImageSource)vSource.M1114(i)).version);
			}
			Rms.M1534("ImageSource", t.M371());
			t.M372();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
	}
}
