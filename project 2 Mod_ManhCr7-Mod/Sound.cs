using System.Threading;
using UnityEngine;

public class Sound
{
	private const int INTERVAL = 5;

	private const int MAXTIME = 100;

	public static int status;

	public static int postem;

	public static int timestart;

	private static string filenametemp;

	private static float volumetem;

	public static bool isSound = true;

	public static bool isNotPlay;

	public static bool stopAll;

	public static AudioSource SoundWater;

	public static AudioSource SoundRun;

	public static AudioSource SoundBGLoop;

	public static AudioClip[] music;

	public static GameObject[] player;

	public static string[] fileName = new string[34]
	{
		"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
		"10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
		"29", "21", "22", "23", "24", "25", "26", "27", "28", "29",
		"30", "31", "32", "33"
	};

	public static sbyte MLogin = 0;

	public static sbyte MBClick = 1;

	public static sbyte MTone = 2;

	public static sbyte MSanzu = 3;

	public static sbyte MChakumi = 4;

	public static sbyte MChai = 5;

	public static sbyte MOshin = 6;

	public static sbyte MEchigo = 7;

	public static sbyte MKojin = 8;

	public static sbyte MHaruna = 9;

	public static sbyte MHirosaki = 10;

	public static sbyte MOokaza = 11;

	public static sbyte MGiotuyet = 12;

	public static sbyte MHangdong = 13;

	public static sbyte MDeKeu = 14;

	public static sbyte MChimKeu = 15;

	public static sbyte MBuocChan = 16;

	public static sbyte MNuocChay = 17;

	public static sbyte MBomMau = 18;

	public static sbyte MKiemGo = 19;

	public static sbyte MKiem = 20;

	public static sbyte MTieu = 21;

	public static sbyte MKunai = 22;

	public static sbyte MCung = 23;

	public static sbyte MDao = 24;

	public static sbyte MQuat = 25;

	public static sbyte MCung2 = 26;

	public static sbyte MTieu2 = 27;

	public static sbyte MTieu3 = 28;

	public static sbyte MKiem2 = 29;

	public static sbyte MKiem3 = 30;

	public static sbyte MDao2 = 31;

	public static sbyte MDao3 = 32;

	public static sbyte MCung3 = 33;

	public static int l1;

	public static void M1793(SoundMn.T222 ac)
	{
	}

	public static void M1794()
	{
		for (int i = 0; i < player.Length; i++)
		{
			if (player[i] != null)
			{
				player[i].GetComponent<AudioSource>().Pause();
			}
		}
	}

	public static bool M1795()
	{
		return false;
	}

	public static void M1796()
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Audio Player";
		gameObject.transform.position = Vector3.zero;
		gameObject.AddComponent<AudioListener>();
		SoundBGLoop = gameObject.AddComponent<AudioSource>();
	}

	public static void M1797(int[] musicID, int[] sID)
	{
		if (player == null && music == null)
		{
			M1796();
			l1 = musicID.Length;
			player = new GameObject[musicID.Length + sID.Length];
			music = new AudioClip[musicID.Length + sID.Length];
			for (int i = 0; i < player.Length; i++)
			{
				M1800((i >= l1) ? ("/sound/" + (i - l1)) : ("/music/" + i), i);
			}
		}
	}

	public static void M1798(int id, float volume)
	{
		M1805(id + l1, volume);
	}

	public static void M1799(int id, float volume)
	{
		M1805(id, volume);
	}

	public static void M1800(string fileName, int pos)
	{
		M1822(pos);
		M1816(Main.res + fileName, pos);
	}

	public static void M1801()
	{
		for (int i = 0; i < music.Length; i++)
		{
			M1822(i);
		}
		for (int j = 0; j < l1; j++)
		{
			M1814(j);
		}
	}

	public static void M1802()
	{
		for (int i = 0; i < music.Length; i++)
		{
			M1822(i);
		}
		M1814(0);
		M1807();
		M1810(0);
	}

	public static void M1803()
	{
	}

	public static void M1804(int x)
	{
		if (GameCanvas.isPlaySound)
		{
			M1822(x);
		}
	}

	public static void M1805(int id, float volume)
	{
		if (!isNotPlay && GameCanvas.isPlaySound)
		{
			M1819(volume, id);
		}
	}

	public static void M1806(int id, float volume)
	{
		if (GameCanvas.isPlaySound && !(SoundRun == null))
		{
			SoundRun.GetComponent<AudioSource>().loop = true;
			SoundRun.GetComponent<AudioSource>().clip = music[id];
			SoundRun.GetComponent<AudioSource>().volume = volume;
			SoundRun.GetComponent<AudioSource>().Play();
		}
	}

	public static void M1807()
	{
		SoundRun.GetComponent<AudioSource>().Stop();
	}

	public static bool M1808()
	{
		if (SoundRun == null)
		{
			return false;
		}
		return SoundRun.GetComponent<AudioSource>().isPlaying;
	}

	public static void M1809(int id, float volume, bool isLoop)
	{
		if (GameCanvas.isPlaySound && !(SoundBGLoop == null))
		{
			SoundWater.GetComponent<AudioSource>().loop = isLoop;
			SoundWater.GetComponent<AudioSource>().clip = music[id];
			SoundWater.GetComponent<AudioSource>().volume = volume;
			SoundWater.GetComponent<AudioSource>().Play();
		}
	}

	public static void M1810(int id)
	{
		SoundWater.GetComponent<AudioSource>().Stop();
	}

	public static bool M1811(int id)
	{
		if (SoundWater == null)
		{
			return false;
		}
		return SoundWater.GetComponent<AudioSource>().isPlaying;
	}

	public static void M1812(int type, float vl, bool loop)
	{
		if (!isNotPlay)
		{
			vl -= 0.3f;
			if (vl <= 0f)
			{
				vl = 0.01f;
			}
			M1813(type, vl);
		}
	}

	public static void M1813(int id, float volume)
	{
		if (GameCanvas.isPlaySound)
		{
			if (id == SoundMn.AIR_SHIP)
			{
				M1799(id, volume + 0.2f);
			}
			else if (!(SoundBGLoop == null) && !M1815(id))
			{
				SoundBGLoop.GetComponent<AudioSource>().loop = true;
				SoundBGLoop.GetComponent<AudioSource>().clip = music[id];
				SoundBGLoop.GetComponent<AudioSource>().volume = volume;
				SoundBGLoop.GetComponent<AudioSource>().Play();
			}
		}
	}

	public static void M1814(int id)
	{
		SoundBGLoop.GetComponent<AudioSource>().Stop();
	}

	public static bool M1815(int id)
	{
		if (SoundBGLoop == null)
		{
			return false;
		}
		return SoundBGLoop.GetComponent<AudioSource>().isPlaying;
	}

	public static void M1816(string filename, int pos)
	{
		if (Thread.CurrentThread.Name == Main.mainThreadName)
		{
			M1818(filename, pos);
		}
		else
		{
			M1817(filename, pos);
		}
	}

	private static void M1817(string filename, int pos)
	{
		if (status != 0)
		{
			Cout.M328("CANNOT LOAD AUDIO " + filename + " WHEN LOADING " + filenametemp);
			return;
		}
		filenametemp = filename;
		postem = pos;
		status = 2;
		int i;
		for (i = 0; i < 100; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 100)
		{
			Cout.M328("TOO LONG FOR LOAD AUDIO " + filename);
			return;
		}
		Cout.M327("Load Audio " + filename + " done in " + i * 5 + "ms");
	}

	private static void M1818(string filename, int pos)
	{
		music[pos] = (AudioClip)Resources.Load(filename, typeof(AudioClip));
		GameObject.Find("Main Camera").AddComponent<AudioSource>();
		player[pos] = GameObject.Find("Main Camera");
	}

	public static void M1819(float volume, int pos)
	{
		if (Thread.CurrentThread.Name == Main.mainThreadName)
		{
			M1821(volume, pos);
		}
		else
		{
			M1820(volume, pos);
		}
	}

	public static void M1820(float volume, int pos)
	{
		if (status != 0)
		{
			Debug.LogError("CANNOT START AUDIO WHEN STARTING");
			return;
		}
		volumetem = volume;
		postem = pos;
		status = 3;
		int i;
		for (i = 0; i < 100; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 100)
		{
			Debug.LogError("TOO LONG FOR START AUDIO");
		}
		else
		{
			Debug.Log("Start Audio done in " + i * 5 + "ms");
		}
	}

	public static void M1821(float volume, int pos)
	{
		if (!(player[pos] == null))
		{
			player[pos].GetComponent<AudioSource>().PlayOneShot(music[pos], volume);
		}
	}

	public static void M1822(int pos)
	{
		if (Thread.CurrentThread.Name == Main.mainThreadName)
		{
			M1824(pos);
		}
		else
		{
			M1823(pos);
		}
	}

	public static void M1823(int pos)
	{
		if (status != 0)
		{
			Debug.LogError("CANNOT STOP AUDIO WHEN STOPPING");
			return;
		}
		postem = pos;
		status = 4;
		int i;
		for (i = 0; i < 100; i++)
		{
			Thread.Sleep(5);
			if (status == 0)
			{
				break;
			}
		}
		if (i == 100)
		{
			Debug.LogError("TOO LONG FOR STOP AUDIO");
		}
		else
		{
			Debug.Log("Stop Audio done in " + i * 5 + "ms");
		}
	}

	public static void M1824(int pos)
	{
		if (player[pos] != null)
		{
			player[pos].GetComponent<AudioSource>().Stop();
		}
	}
}
