using UnityEngine;

public class T111
{
	public string name;

	public AudioClip clip;

	public long timeStart;

	public T111(string filename)
	{
		clip = (AudioClip)Resources.Load(filename);
		name = filename;
	}

	public void M1072()
	{
		Main.main.GetComponent<AudioSource>().PlayOneShot(clip);
		timeStart = T110.M1054();
	}

	public bool M1073()
	{
		return false;
	}
}
