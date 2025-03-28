using UnityEngine;

public class MyAudioClip
{
	public string name;

	public AudioClip clip;

	public long timeStart;

	public MyAudioClip(string filename)
	{
		clip = (AudioClip)Resources.Load(filename);
		name = filename;
	}

	public void M1072()
	{
		Main.main.GetComponent<AudioSource>().PlayOneShot(clip);
		timeStart = mSystem.M1054();
	}

	public bool M1073()
	{
		return false;
	}
}
