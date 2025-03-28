using System;

public class BgItemMn
{
	public static Image M72(Image img, int layer, int idImage)
	{
		int num = TileMap.tileID - 1;
		Image t = img;
		if (num == 0 && layer == 1)
		{
			t = mGraphics.M961(img, 0.3f, 807956);
		}
		if (num == 1 && layer == 1)
		{
			t = mGraphics.M961(img, 0.35f, 739339);
		}
		if (num == 2 && layer == 1)
		{
			t = mGraphics.M961(img, 0.1f, 3977975);
		}
		if (num == 3)
		{
			if (layer == 1)
			{
				t = mGraphics.M961(img, 0.2f, 15265992);
			}
			if (layer == 3)
			{
				t = mGraphics.M961(img, 0.1f, 15265992);
			}
		}
		if (num == 4)
		{
			if (layer == 1)
			{
				t = mGraphics.M961(img, 0.3f, 1330178);
			}
			if (layer == 3)
			{
				t = mGraphics.M961(img, 0.1f, 1330178);
			}
		}
		if (num == 6)
		{
			if (layer == 1)
			{
				t = mGraphics.M961(img, 0.3f, 420382);
			}
			if (layer == 3)
			{
				t = mGraphics.M961(img, 0.15f, 420382);
			}
		}
		if (num == 5)
		{
			if (layer == 1)
			{
				t = mGraphics.M961(img, 0.35f, 3270903);
			}
			if (layer == 3)
			{
				t = mGraphics.M961(img, 0.15f, 3270903);
			}
		}
		if (num == 8)
		{
			if (layer == 1)
			{
				t = mGraphics.M961(img, 0.3f, 7094528);
			}
			if (layer == 3)
			{
				t = mGraphics.M961(img, 0.15f, 7094528);
			}
		}
		if (num == 9)
		{
			if (layer == 1)
			{
				t = mGraphics.M961(img, 0.3f, 12113627);
			}
			if (layer == 3)
			{
				t = mGraphics.M961(img, 0.15f, 12113627);
			}
		}
		if (num == 10 && layer == 1)
		{
			t = mGraphics.M961(img, 0.3f, 14938312);
		}
		if (num == 10 && layer == 1)
		{
			t = mGraphics.M961(img, 0.2f, 14938312);
		}
		if (num == 11)
		{
			if (layer == 1)
			{
				t = mGraphics.M961(img, 0.3f, 0);
			}
			if (layer == 3)
			{
				t = mGraphics.M961(img, 0.15f, 0);
			}
		}
		if (num > 11)
		{
			if (layer == 1 || layer == 2)
			{
				t = mGraphics.M961(img, 0.3f, 0);
			}
			if (layer == 3)
			{
				t = mGraphics.M961(img, 0.15f, 0);
			}
		}
		sbyte[] data = ArrayCast.M0(M73(t));
		Rms.M1534("x" + mGraphics.zoomLevel + "blend" + idImage + "layer" + layer, data);
		return t;
	}

	public static byte[] M73(Image img)
	{
		try
		{
			return img.texture.EncodeToPNG();
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static void M74(short id, Image img)
	{
		for (int i = 0; i < TileMap.vCurrItem.M1113(); i++)
		{
			BgItem t = (BgItem)TileMap.vCurrItem.M1114(i);
			if (t.idImage == id && !t.M68() && t.layer != 2 && t.layer != 4 && !BgItem.imgNew.M1081(t.idImage + "blend" + t.layer))
			{
				sbyte[] array = Rms.M1535("x" + mGraphics.zoomLevel + "blend" + id + "layer" + t.layer);
				if (array == null)
				{
					BgItem.imgNew.M1078(t.idImage + "blend" + t.layer, M72(img, t.layer, t.idImage));
					continue;
				}
				Image v = Image.M708(array, 0, array.Length);
				BgItem.imgNew.M1078(t.idImage + "blend" + t.layer, v);
			}
		}
	}
}
