using System.IO;
using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using Utilities;
using Xmap;

public class MotherCanvas
{
	public static MotherCanvas instance;

	public GameCanvas tCanvas;

	public int zoomLevel = 1;

	public Image imgCache;

	private int[] imgRGBCache;

	private int newWidth;

	private int newHeight;

	private int[] output;

	private int OUTPUTSIZE = 20;

	public MotherCanvas()
	{
		M1021(M1022(), M1023());
	}

	public void M1021(int w, int h)
	{
		if (Main.isWindowsPhone)
		{
			mGraphics.zoomLevel = 2;
			if (w * h >= 2073600)
			{
				mGraphics.zoomLevel = 4;
			}
			else if (w * h > 384000)
			{
				mGraphics.zoomLevel = 3;
			}
			return;
		}
		if (!Main.isPC)
		{
			if (Main.isIpod)
			{
				mGraphics.zoomLevel = 2;
			}
			else if (w * h >= 2073600)
			{
				mGraphics.zoomLevel = 4;
			}
			else if (w * h >= 691200)
			{
				mGraphics.zoomLevel = 3;
			}
			else if (w * h > 153600)
			{
				mGraphics.zoomLevel = 2;
			}
			return;
		}
		try
		{
			GameAutomationHub.listBackgroundImages.Add(Image.M721(File.ReadAllBytes("Dragonboy_vn_v206_Data\\Resources\\unity_bgr")));
			GameAutomationHub.listBackgroundImages.Add(Image.M721(File.ReadAllBytes("Dragonboy_vn_v206_Data\\Resources\\unity_default_bg")));
			FileInfo[] files = new DirectoryInfo("background_image").GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				GameAutomationHub.listBackgroundImages.Add(Image.M721(File.ReadAllBytes("background_image\\" + fileInfo.Name)));
			}
		}
		catch
		{
		}
		mGraphics.zoomLevel = 2;
		if (w * h < 480000)
		{
			mGraphics.zoomLevel = 1;
		}
	}

	public int M1022()
	{
		return (int)ScaleUI.WIDTH;
	}

	public int M1023()
	{
		return (int)ScaleUI.HEIGHT;
	}

	public void M1024(GameCanvas tCanvas)
	{
		this.tCanvas = tCanvas;
	}

	protected void M1025(mGraphics g)
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
		x /= mGraphics.zoomLevel;
		y /= mGraphics.zoomLevel;
		tCanvas.M477(x, y);
	}

	protected void M1029(int x, int y)
	{
		x /= mGraphics.zoomLevel;
		y /= mGraphics.zoomLevel;
		tCanvas.M479(x, y);
	}

	protected void M1030(int x, int y)
	{
		x /= mGraphics.zoomLevel;
		y /= mGraphics.zoomLevel;
		tCanvas.M480(x, y);
	}

	public int M1031()
	{
		int num = M1022();
		return num / mGraphics.zoomLevel + num % mGraphics.zoomLevel;
	}

	public int M1032()
	{
		int num = M1023();
		return num / mGraphics.zoomLevel + num % mGraphics.zoomLevel;
	}
}
