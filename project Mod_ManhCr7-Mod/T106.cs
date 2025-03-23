using System.IO;
using N3.N4;

public class T106
{
	public static T106 instance;

	public T51 tCanvas;

	public int zoomLevel = 1;

	public T60 imgCache;

	private int[] imgRGBCache;

	private int newWidth;

	private int newHeight;

	private int[] output;

	private int OUTPUTSIZE = 20;

	public T106()
	{
		M1021(M1022(), M1023());
	}

	public void M1021(int w, int h)
	{
		if (Main.isWindowsPhone)
		{
			T99.zoomLevel = 2;
			if (w * h >= 2073600)
			{
				T99.zoomLevel = 4;
			}
			else if (w * h > 384000)
			{
				T99.zoomLevel = 3;
			}
			return;
		}
		if (!Main.isPC)
		{
			if (Main.isIpod)
			{
				T99.zoomLevel = 2;
			}
			else if (w * h >= 2073600)
			{
				T99.zoomLevel = 4;
			}
			else if (w * h >= 691200)
			{
				T99.zoomLevel = 3;
			}
			else if (w * h > 153600)
			{
				T99.zoomLevel = 2;
			}
			return;
		}
		try
		{
			T200.listBackgroundImages.Add(T60.M721(File.ReadAllBytes("Dragonboy_vn_v206_Data\\Resources\\unity_bgr")));
			T200.listBackgroundImages.Add(T60.M721(File.ReadAllBytes("Dragonboy_vn_v206_Data\\Resources\\unity_default_bg")));
			FileInfo[] files = new DirectoryInfo("background_image").GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				T200.listBackgroundImages.Add(T60.M721(File.ReadAllBytes("background_image\\" + fileInfo.Name)));
			}
		}
		catch
		{
		}
		T99.zoomLevel = 2;
		if (w * h < 480000)
		{
			T99.zoomLevel = 1;
		}
	}

	public int M1022()
	{
		return (int)T139.WIDTH;
	}

	public int M1023()
	{
		return (int)T139.HEIGHT;
	}

	public void M1024(T51 tCanvas)
	{
		this.tCanvas = tCanvas;
	}

	protected void M1025(T99 g)
	{
		tCanvas.M487(g);
	}

	protected void M1026(int keyCode)
	{
		tCanvas.M471(keyCode);
	}

	protected void M1027(int keyCode)
	{
		tCanvas.M473(keyCode);
	}

	protected void M1028(int x, int y)
	{
		x /= T99.zoomLevel;
		y /= T99.zoomLevel;
		tCanvas.M477(x, y);
	}

	protected void M1029(int x, int y)
	{
		x /= T99.zoomLevel;
		y /= T99.zoomLevel;
		tCanvas.M479(x, y);
	}

	protected void M1030(int x, int y)
	{
		x /= T99.zoomLevel;
		y /= T99.zoomLevel;
		tCanvas.M480(x, y);
	}

	public int M1031()
	{
		int num = M1022();
		return num / T99.zoomLevel + num % T99.zoomLevel;
	}

	public int M1032()
	{
		int num = M1023();
		return num / T99.zoomLevel + num % T99.zoomLevel;
	}
}
