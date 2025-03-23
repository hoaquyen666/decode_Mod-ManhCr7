public class T10
{
	public int id;

	public int trans;

	public short idImage;

	public int x;

	public int y;

	public int dx;

	public int dy;

	public sbyte layer;

	public int nTilenotMove;

	public int[] tileX;

	public int[] tileY;

	public static T112 imgNew = new T112();

	public static T117 vKeysNew = new T117();

	public static T117 vKeysLast = new T117();

	private bool isBlur;

	public int transX;

	public int transY;

	public static int[] idNotBlend = new int[61]
	{
		79, 80, 81, 82, 83, 84, 85, 86, 87, 88,
		89, 90, 91, 92, 95, 144, 99, 100, 101, 102,
		103, 104, 105, 106, 107, 108, 109, 110, 111, 112,
		113, 114, 115, 117, 118, 119, 120, 121, 122, 123,
		124, 125, 126, 127, 132, 133, 134, 139, 140, 141,
		142, 143, 144, 145, 146, 147, 171, 121, 122, 229,
		218
	};

	public static int[] isMiniBgz = new int[18]
	{
		79, 80, 81, 85, 86, 90, 91, 92, 99, 100,
		101, 102, 103, 104, 105, 106, 107, 108
	};

	public static sbyte[] newSmallVersion;

	public static void M65()
	{
	}

	public static bool M66(string keyNew)
	{
		for (int i = 0; i < vKeysNew.M1113(); i++)
		{
			if (((string)vKeysNew.M1114(i)).Equals(keyNew))
			{
				return true;
			}
		}
		return false;
	}

	public static bool M67(string keyLast)
	{
		for (int i = 0; i < vKeysLast.M1113(); i++)
		{
			if (((string)vKeysLast.M1114(i)).Equals(keyLast))
			{
				return true;
			}
		}
		return false;
	}

	public bool M68()
	{
		if (T99.zoomLevel == 1)
		{
			return true;
		}
		if (T174.M1945())
		{
			return true;
		}
		for (int i = 0; i < idNotBlend.Length; i++)
		{
			if (idImage == idNotBlend[i])
			{
				return true;
			}
		}
		return false;
	}

	public bool M69()
	{
		for (int i = 0; i < isMiniBgz.Length; i++)
		{
			if (idImage == isMiniBgz[i])
			{
				return true;
			}
		}
		return false;
	}

	public void M70()
	{
		if (M68() || layer == 2 || layer == 4 || imgNew.M1081(idImage + "blend" + layer))
		{
			return;
		}
		T60 t = (T60)imgNew.M1074(idImage + string.Empty);
		if (t != null && t.M732() > 4)
		{
			sbyte[] array = T138.M1535("x" + T99.zoomLevel + "blend" + idImage + "layer" + layer);
			if (array == null)
			{
				imgNew.M1078(idImage + "blend" + layer, T11.M72(t, layer, idImage));
				return;
			}
			T60 v = T60.M708(array, 0, array.Length);
			imgNew.M1078(idImage + "blend" + layer, v);
		}
	}

	public void M71(T99 g)
	{
		if (T13.isLoadingMap || (idImage == 279 && T54.M559().tMabuEff >= 110))
		{
			return;
		}
		int cmx = T54.cmx;
		int cmy = T54.cmy;
		T60 t = null;
		t = ((layer == 2 || layer == 4) ? ((T60)imgNew.M1074(idImage + string.Empty)) : (M68() ? ((T60)imgNew.M1074(idImage + string.Empty)) : ((T60)imgNew.M1074(idImage + "blend" + layer))));
		if (t == null || idImage == 96)
		{
			return;
		}
		if (layer == 4)
		{
			transX = -cmx / 2 + 100;
		}
		if (idImage == 28 && layer == 3)
		{
			transX = -cmx / 3 + 200;
		}
		if ((idImage == 67 || idImage == 68 || idImage == 69 || idImage == 70) && layer == 3)
		{
			transX = -cmx / 3 + 200;
		}
		if (M69() && layer < 4)
		{
			transX = -(cmx >> 4) + 50;
			transY = (cmy >> 5) - 15;
		}
		int num = x + dx + transX;
		int num2 = y + dy + transY;
		if (x + dx + t.M727() + transX >= cmx && x + dx + transX <= cmx + T51.w && y + dy + transY + t.M728() >= cmy && y + dy + transY <= cmy + T51.h)
		{
			g.M940(t, 0, 0, T99.M958(t), T99.M959(t), trans, x + dx + transX, y + dy + transY, 0);
			if (idImage == 11 && T174.mapID != 122)
			{
				g.M922(num, num2 + 24, 48, 14);
				for (int i = 0; i < 2; i++)
				{
					g.M940(T174.imgWaterflow, 0, (T51.gameTick % 8 >> 2) * 24, 24, 24, 0, num + i * 24, num2 + 24, 0);
				}
				g.M922(T54.cmx, T54.cmy, T54.gW, T54.gH);
			}
		}
		if (T174.M1946() && idImage > 137 && idImage != 156 && idImage != 159 && idImage != 157 && idImage != 165 && idImage != 167 && idImage != 168 && idImage != 169 && idImage != 170 && idImage != 238 && T174.pxw - (x + dx + transX) >= cmx && T174.pxw - (x + dx + transX + t.M727()) <= cmx + T51.w && y + dy + transY + t.M728() >= cmy && y + dy + transY <= cmy + T51.h && (idImage < 241 || idImage >= 266))
		{
			g.M940(t, 0, 0, T99.M958(t), T99.M959(t), 2, T174.pxw - (x + dx + transX), y + dy + transY, T163.TOP_RIGHT);
		}
	}
}
