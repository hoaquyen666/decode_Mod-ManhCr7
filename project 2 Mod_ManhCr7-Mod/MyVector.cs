using System.Collections;

public class MyVector
{
	private ArrayList a;

	public MyVector()
	{
		a = new ArrayList();
	}

	public MyVector(string s)
	{
		a = new ArrayList();
	}

	public MyVector(ArrayList a)
	{
		this.a = a;
	}

	public void M1111(object o)
	{
		a.Add(o);
	}

	public bool M1112(object o)
	{
		if (a.Contains(o))
		{
			return true;
		}
		return false;
	}

	public int M1113()
	{
		if (a == null)
		{
			return 0;
		}
		return a.Count;
	}

	public object M1114(int index)
	{
		if (index > -1 && index < a.Count)
		{
			return a[index];
		}
		return null;
	}

	public void M1115(int index, object obj)
	{
		if (index > -1 && index < a.Count)
		{
			a[index] = obj;
		}
	}

	public void M1116(object obj, int index)
	{
		if (index > -1 && index < a.Count)
		{
			a[index] = obj;
		}
	}

	public int M1117(object o)
	{
		return a.IndexOf(o);
	}

	public void M1118(int index)
	{
		if (index > -1 && index < a.Count)
		{
			a.RemoveAt(index);
		}
	}

	public void M1119(object o)
	{
		a.Remove(o);
	}

	public void M1120()
	{
		a.Clear();
	}

	public void M1121(object o, int i)
	{
		a.Insert(i, o);
	}

	public object M1122()
	{
		return a[0];
	}

	public object M1123()
	{
		return a[a.Count - 1];
	}
}
