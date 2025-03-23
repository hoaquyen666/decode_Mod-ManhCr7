using System;

namespace N5.N6.N7;

internal class T205
{
	public sbyte version;

	public string id;

	public static T117 vSource = new T117();

	public static T117 vRms = new T117();

	public T205(string ID, sbyte version)
	{
		id = ID;
		this.version = version;
	}

	public static void M2275()
	{
		T117 t = new T117();
		sbyte[] array = T138.M1535("ImageSource");
		if (array == null)
		{
			T146.M1594().M1731(t);
			return;
		}
		vRms = new T117();
		T28 t2 = new T28(array);
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
				vRms.M1111(new T205(array2[i], array3[i]));
			}
			t2.M357();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		T137.M1513("vS size= " + vSource.M1113() + " vRMS size= " + vRms.M1113());
		for (int j = 0; j < vSource.M1113(); j++)
		{
			T205 t3 = (T205)vSource.M1114(j);
			if (!M2278(t3.id))
			{
				t.M1111(t3);
			}
		}
		for (int k = 0; k < vRms.M1113(); k++)
		{
			T205 t4 = (T205)vRms.M1114(k);
			if (M2276(t4.id) != M2277(t4.id))
			{
				t.M1111(t4);
			}
		}
		T146.M1594().M1731(t);
	}

	public static sbyte M2276(string id)
	{
		for (int i = 0; i < vRms.M1113(); i++)
		{
			if (id.Equals(((T205)vRms.M1114(i)).id))
			{
				return ((T205)vRms.M1114(i)).version;
			}
		}
		return -1;
	}

	public static sbyte M2277(string id)
	{
		for (int i = 0; i < vSource.M1113(); i++)
		{
			if (id.Equals(((T205)vSource.M1114(i)).id))
			{
				return ((T205)vSource.M1114(i)).version;
			}
		}
		return -1;
	}

	public static bool M2278(string id)
	{
		for (int i = 0; i < vRms.M1113(); i++)
		{
			if (id.Equals(((T205)vRms.M1114(i)).id))
			{
				return true;
			}
		}
		return false;
	}

	public static void M2279()
	{
		T29 t = new T29();
		try
		{
			t.M368((short)vSource.M1113());
			for (int i = 0; i < vSource.M1113(); i++)
			{
				t.M374(((T205)vSource.M1114(i)).id);
				t.M373(((T205)vSource.M1114(i)).version);
			}
			T138.M1534("ImageSource", t.M371());
			t.M372();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
	}
}
