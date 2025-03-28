using System.Collections;

public class MyHashTable
{
	public Hashtable h = new Hashtable();

	public object M1074(object k)
	{
		return h[k];
	}

	public void M1075()
	{
		h.Clear();
	}

	public IDictionaryEnumerator M1076()
	{
		return h.GetEnumerator();
	}

	public int M1077()
	{
		return h.Count;
	}

	public void M1078(object k, object v)
	{
		if (h.ContainsKey(k))
		{
			h.Remove(k);
		}
		h.Add(k, v);
	}

	public void M1079(object k)
	{
		h.Remove(k);
	}

	public void M1080(string key)
	{
		h.Remove(key);
	}

	public bool M1081(object key)
	{
		return h.ContainsKey(key);
	}
}
