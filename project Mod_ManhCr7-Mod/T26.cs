using System;

public class T26 : T108, T57
{
	public static T26 instance;

	private T133 p;

	public static bool isCreateChar = false;

	public static T173 tAddName;

	public static int indexGender;

	public static int indexHair;

	public static int selected;

	public static int[][] hairID = new int[3][]
	{
		new int[3] { 64, 30, 31 },
		new int[3] { 9, 29, 32 },
		new int[3] { 6, 27, 28 }
	};

	public static int[] defaultLeg = new int[3] { 2, 13, 8 };

	public static int[] defaultBody = new int[3] { 1, 12, 7 };

	private int yButton;

	private int disY;

	private int[] bgID = new int[3] { 0, 4, 8 };

	public int yBegin;

	private int curIndex;

	private int cx = 168;

	private int cy = 350;

	private int dy = 45;

	private int cp1;

	private int cf;

	public T26()
	{
		try
		{
			if (!T51.lowGraphic)
			{
				M346(new sbyte[3] { 39, 40, 41 });
			}
			M347(new sbyte[3] { 39, 40, 41 });
		}
		catch (Exception ex)
		{
			T24.M328("Tao char loi " + ex.ToString());
		}
		if (T51.w <= 200)
		{
			T54.M656(128, 100);
			T54.popupX = (T51.w - 128) / 2;
			T54.popupY = 10;
			cy += 15;
			dy -= 15;
		}
		indexGender = 1;
		tAddName = new T173();
		tAddName.width = T51.loginScr.tfUser.width;
		if (T51.w < 200)
		{
			tAddName.width = 60;
		}
		tAddName.height = T108.ITEM_HEIGHT + 2;
		if (T51.w < 200)
		{
			tAddName.x = T54.popupX + 45;
			tAddName.y = T54.popupY + 12;
		}
		else
		{
			tAddName.x = T51.w / 2 - tAddName.width / 2;
			tAddName.y = 35;
		}
		if (!T51.isTouch)
		{
			tAddName.isFocus = true;
		}
		tAddName.M1931(T173.INPUT_TYPE_ANY);
		tAddName.showSubTextField = false;
		tAddName.strInfo = mResources.char_name;
		if (tAddName.M1924().Equals("@"))
		{
			tAddName.M1926(T51.loginScr.tfUser.M1924().Substring(0, T51.loginScr.tfUser.M1924().IndexOf("@")));
		}
		tAddName.name = mResources.char_name;
		indexGender = 1;
		indexHair = 0;
		center = new T22(mResources.NEWCHAR, this, 8000, null);
		left = new T22(mResources.BACK, this, 8001, null);
		if (!T51.isTouch)
		{
			right = tAddName.cmdClear;
		}
		yBegin = tAddName.y;
	}

	public static T26 M344()
	{
		if (instance == null)
		{
			instance = new T26();
		}
		return instance;
	}

	public static void M345()
	{
	}

	public static void M346(sbyte[] mapID)
	{
		T137.M1513("newwwwwwwwww =============");
		T28 t = null;
		for (int i = 0; i < mapID.Length; i++)
		{
			t = T116.M1110("/mymap/" + mapID[i]);
			T93.tmw[i] = (ushort)t.M355();
			T93.tmh[i] = (ushort)t.M355();
			T24.M328("Thong TIn : " + T93.tmw[i] + "::" + T93.tmh[i]);
			T93.maps[i] = new int[t.M366()];
			T24.M328("lent= " + T93.maps[i].Length);
			for (int j = 0; j < T93.tmw[i] * T93.tmh[i]; j++)
			{
				T93.maps[i][j] = t.M355();
			}
			T93.types[i] = new int[T93.maps[i].Length];
		}
	}

	public void M347(sbyte[] mapID)
	{
		if (T51.lowGraphic)
		{
			return;
		}
		T28 t = null;
		try
		{
			for (int i = 0; i < mapID.Length; i++)
			{
				t = T116.M1110("/mymap/mapTable" + mapID[i]);
				T24.M328("mapTable : " + mapID[i]);
				short num = t.M353();
				T93.vCurrItem[i] = new T117();
				T137.M1513("nItem= " + num);
				for (int j = 0; j < num; j++)
				{
					short id = t.M353();
					short num2 = t.M353();
					short num3 = t.M353();
					if (T174.M1935(id) != null)
					{
						T10 t2 = T174.M1935(id);
						T10 t3 = new T10();
						t3.id = id;
						t3.idImage = t2.idImage;
						t3.dx = t2.dx;
						t3.dy = t2.dy;
						t3.x = num2 * T174.size;
						t3.y = num3 * T174.size;
						t3.layer = t2.layer;
						T93.vCurrItem[i].M1111(t3);
						if (!T10.imgNew.M1081(t3.idImage + string.Empty))
						{
							try
							{
								T60 t4 = T51.M503("/mapBackGround/" + t3.idImage + ".png");
								if (t4 == null)
								{
									T10.imgNew.M1078(t3.idImage + string.Empty, T60.M711(new int[1], 1, 1, bl: true));
									T146.M1594().M1709(t3.idImage);
								}
								else
								{
									T10.imgNew.M1078(t3.idImage + string.Empty, t4);
								}
							}
							catch (Exception)
							{
								T60 t5 = T51.M503("/mapBackGround/" + t3.idImage + ".png");
								if (t5 == null)
								{
									t5 = T60.M711(new int[1], 1, 1, bl: true);
									T146.M1594().M1709(t3.idImage);
								}
								T10.imgNew.M1078(t3.idImage + string.Empty, t5);
							}
							T10.vKeysLast.M1111(t3.idImage + string.Empty);
						}
						if (!T10.M66(t3.idImage + string.Empty))
						{
							T10.vKeysNew.M1111(t3.idImage + string.Empty);
						}
						t3.M70();
					}
					else
					{
						T137.M1513("item null");
					}
				}
			}
		}
		catch (Exception ex2)
		{
			T24.M326("LOI TAI loadMapTableFromResource" + ex2.ToString());
		}
	}

	public override void switchToMe()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T90.isContinueToLogin = false;
		T51.menu.showMenu = false;
		T51.M488();
		base.switchToMe();
		indexGender = T137.M1522(0, 3);
		indexHair = T137.M1522(0, 3);
		M348();
		T13.isLoadingMap = false;
		tAddName.M1923(isFocus: true);
	}

	public void M348()
	{
		T174.maps = new int[T93.maps[indexGender].Length];
		for (int i = 0; i < T93.maps[indexGender].Length; i++)
		{
			T174.maps[i] = T93.maps[indexGender][i];
		}
		T174.types = T93.types[indexGender];
		T174.pxh = T93.pxh[indexGender];
		T174.pxw = T93.pxw[indexGender];
		T174.tileID = T93.pxw[indexGender];
		T174.tmw = T93.tmw[indexGender];
		T174.tmh = T93.tmh[indexGender];
		T174.tileID = bgID[indexGender] + 1;
		T174.M1964();
		T174.M1940();
		T51.M469(bgID[indexGender]);
		T54.M564(fullmScreen: false, cx, cy);
	}

	public override void keyPress(int keyCode)
	{
		tAddName.M1913(keyCode);
	}

	public override void update()
	{
		cp1++;
		if (cp1 > 30)
		{
			cp1 = 0;
		}
		if (cp1 % 15 < 5)
		{
			cf = 0;
		}
		else
		{
			cf = 1;
		}
		tAddName.M1920();
		if (selected != 0)
		{
			tAddName.isFocus = false;
		}
	}

	public override void updateKey()
	{
		if (T51.keyPressed[(!Main.isPC) ? 2 : 21])
		{
			selected--;
			if (selected < 0)
			{
				selected = mResources.MENUNEWCHAR.Length - 1;
			}
		}
		if (T51.keyPressed[(!Main.isPC) ? 8 : 22])
		{
			selected++;
			if (selected >= mResources.MENUNEWCHAR.Length)
			{
				selected = 0;
			}
		}
		if (selected == 0)
		{
			if (!T51.isTouch)
			{
				right = tAddName.cmdClear;
			}
			tAddName.M1920();
		}
		if (selected == 1)
		{
			if (T51.keyPressed[(!Main.isPC) ? 4 : 23])
			{
				indexGender--;
				if (indexGender < 0)
				{
					indexGender = mResources.MENUGENDER.Length - 1;
				}
				M348();
			}
			if (T51.keyPressed[(!Main.isPC) ? 6 : 24])
			{
				indexGender++;
				if (indexGender > mResources.MENUGENDER.Length - 1)
				{
					indexGender = 0;
				}
				M348();
			}
			right = null;
		}
		if (selected == 2)
		{
			if (T51.keyPressed[(!Main.isPC) ? 4 : 23])
			{
				indexHair--;
				if (indexHair < 0)
				{
					indexHair = mResources.hairStyleName[0].Length - 1;
				}
			}
			if (T51.keyPressed[(!Main.isPC) ? 6 : 24])
			{
				indexHair++;
				if (indexHair > mResources.hairStyleName[0].Length - 1)
				{
					indexHair = 0;
				}
			}
			right = null;
		}
		if (T51.isPointerJustRelease)
		{
			int num = 110;
			int num2 = 60;
			int num3 = 78;
			if (T51.w > T51.h)
			{
				num = 100;
				num2 = 40;
			}
			if (T51.M481(T51.w / 2 - 3 * num3 / 2, 15, num3 * 3, 80))
			{
				selected = 0;
				tAddName.isFocus = true;
			}
			if (T51.M481(T51.w / 2 - 3 * num3 / 2, num - 30, num3 * 3, num2 + 5))
			{
				selected = 1;
				int num4 = indexGender;
				indexGender = (T51.px - (T51.w / 2 - 3 * num3 / 2)) / num3;
				if (indexGender < 0)
				{
					indexGender = 0;
				}
				if (indexGender > mResources.MENUGENDER.Length - 1)
				{
					indexGender = mResources.MENUGENDER.Length - 1;
				}
				if (num4 != indexGender)
				{
					M348();
				}
			}
			if (T51.M481(T51.w / 2 - 3 * num3 / 2, num - 30 + num2 + 5, num3 * 3, 65))
			{
				selected = 2;
				int num5 = indexHair;
				indexHair = (T51.px - (T51.w / 2 - 3 * num3 / 2)) / num3;
				if (indexHair < 0)
				{
					indexHair = 0;
				}
				if (indexHair > mResources.hairStyleName[0].Length - 1)
				{
					indexHair = mResources.hairStyleName[0].Length - 1;
				}
				if (num5 != selected)
				{
					M348();
				}
			}
		}
		if (!T177.visible)
		{
			base.updateKey();
		}
		T51.M484();
		T51.M483();
	}

	public override void paint(T99 g)
	{
		if (T13.isLoadingMap)
		{
			return;
		}
		T51.M466(g);
		g.M918(-T54.cmx, -T54.cmy);
		if (!T51.lowGraphic)
		{
			for (int i = 0; i < T93.vCurrItem[indexGender].M1113(); i++)
			{
				T10 t = (T10)T93.vCurrItem[indexGender].M1114(i);
				if (t.idImage != -1 && t.layer == 1)
				{
					t.M71(g);
				}
			}
		}
		T174.M1951(g);
		int num = 30;
		if (T51.w == 128)
		{
			num = 20;
		}
		int num2 = hairID[indexGender][indexHair];
		int num3 = defaultLeg[indexGender];
		int num4 = defaultBody[indexGender];
		g.M948(T174.bong, cx, cy + dy, 3);
		T127 t2 = T54.parts[num2];
		T127 t3 = T54.parts[num3];
		T127 t4 = T54.parts[num4];
		T157.M1785(g, t2.pi[T13.CharInfo[cf][0][0]].id, cx + T13.CharInfo[cf][0][1] + t2.pi[T13.CharInfo[cf][0][0]].dx, cy - T13.CharInfo[cf][0][2] + t2.pi[T13.CharInfo[cf][0][0]].dy + dy, 0, 0);
		T157.M1785(g, t3.pi[T13.CharInfo[cf][1][0]].id, cx + T13.CharInfo[cf][1][1] + t3.pi[T13.CharInfo[cf][1][0]].dx, cy - T13.CharInfo[cf][1][2] + t3.pi[T13.CharInfo[cf][1][0]].dy + dy, 0, 0);
		T157.M1785(g, t4.pi[T13.CharInfo[cf][2][0]].id, cx + T13.CharInfo[cf][2][1] + t4.pi[T13.CharInfo[cf][2][0]].dx, cy - T13.CharInfo[cf][2][2] + t4.pi[T13.CharInfo[cf][2][0]].dy + dy, 0, 0);
		if (!T51.lowGraphic)
		{
			for (int j = 0; j < T93.vCurrItem[indexGender].M1113(); j++)
			{
				T10 t5 = (T10)T93.vCurrItem[indexGender].M1114(j);
				if (t5.idImage != -1 && t5.layer == 3)
				{
					t5.M71(g);
				}
			}
		}
		g.M918(-g.M920(), -g.M921());
		if (T51.w < 200)
		{
			T51.paintz.M1235(T54.popupX, T54.popupY, T54.popupW, T54.popupH, g);
			T157.M1785(g, t2.pi[T13.CharInfo[0][0][0]].id, T51.w / 2 + T13.CharInfo[0][0][1] + t2.pi[T13.CharInfo[0][0][0]].dx, T54.popupY + 30 + 3 * num - T13.CharInfo[0][0][2] + t2.pi[T13.CharInfo[0][0][0]].dy + dy, 0, 0);
			T157.M1785(g, t3.pi[T13.CharInfo[0][1][0]].id, T51.w / 2 + T13.CharInfo[0][1][1] + t3.pi[T13.CharInfo[0][1][0]].dx, T54.popupY + 30 + 3 * num - T13.CharInfo[0][1][2] + t3.pi[T13.CharInfo[0][1][0]].dy + dy, 0, 0);
			T157.M1785(g, t4.pi[T13.CharInfo[0][2][0]].id, T51.w / 2 + T13.CharInfo[0][2][1] + t4.pi[T13.CharInfo[0][2][0]].dx, T54.popupY + 30 + 3 * num - T13.CharInfo[0][2][2] + t4.pi[T13.CharInfo[0][2][0]].dy + dy, 0, 0);
			for (int k = 0; k < mResources.MENUNEWCHAR.Length; k++)
			{
				if (selected == k)
				{
					g.M940(T54.arrow, 0, 0, 13, 16, 2, T54.popupX + 10 + ((T51.gameTick % 7 > 3) ? 1 : 0), T54.popupY + 35 + k * num, T163.VCENTER_HCENTER);
					g.M940(T54.arrow, 0, 0, 13, 16, 0, T54.popupX + T54.popupW - 10 - ((T51.gameTick % 7 > 3) ? 1 : 0), T54.popupY + 35 + k * num, T163.VCENTER_HCENTER);
				}
				T98.tahoma_7b_dark.M898(g, mResources.MENUNEWCHAR[k], T54.popupX + 20, T54.popupY + 30 + k * num, 0);
			}
			T98.tahoma_7b_dark.M898(g, mResources.MENUGENDER[indexGender], T54.popupX + 70, T54.popupY + 30 + num, T98.LEFT);
			T98.tahoma_7b_dark.M898(g, mResources.hairStyleName[indexGender][indexHair], T54.popupX + 55, T54.popupY + 30 + 2 * num, T98.LEFT);
			tAddName.M1916(g);
		}
		else
		{
			if (!Main.isPC)
			{
				if (T99.addYWhenOpenKeyBoard != 0)
				{
					yButton = 110;
					disY = 60;
					if (T51.w > T51.h)
					{
						yButton = T54.popupY + 30 + 3 * num + t4.pi[T13.CharInfo[0][2][0]].dy + dy - 15;
						disY = 35;
					}
				}
				else
				{
					yButton = 110;
					disY = 60;
					if (T51.w > T51.h)
					{
						yButton = 100;
						disY = 45;
					}
				}
				tAddName.y = yButton - tAddName.height - disY + 5;
			}
			else
			{
				yButton = 110;
				disY = 60;
				if (T51.w > T51.h)
				{
					yButton = 100;
					disY = 45;
				}
				tAddName.y = yBegin;
			}
			for (int l = 0; l < 3; l++)
			{
				int num5 = 78;
				if (l != indexGender)
				{
					g.M948(T54.imgLbtn, T51.w / 2 - num5 + l * num5, yButton, 3);
				}
				else
				{
					if (selected == 1)
					{
						g.M940(T54.arrow, 0, 0, 13, 16, 4, T51.w / 2 - num5 + l * num5, yButton - 20 + ((T51.gameTick % 7 > 3) ? 1 : 0), T163.VCENTER_HCENTER);
					}
					g.M948(T54.imgLbtnFocus, T51.w / 2 - num5 + l * num5, yButton, 3);
				}
				T98.tahoma_7b_dark.M898(g, mResources.MENUGENDER[l], T51.w / 2 - num5 + l * num5, yButton - 5, T98.CENTER);
			}
			for (int m = 0; m < 3; m++)
			{
				int num6 = 78;
				if (m != indexHair)
				{
					g.M948(T54.imgLbtn, T51.w / 2 - num6 + m * num6, yButton + disY, 3);
				}
				else
				{
					if (selected == 2)
					{
						g.M940(T54.arrow, 0, 0, 13, 16, 4, T51.w / 2 - num6 + m * num6, yButton + disY - 20 + ((T51.gameTick % 7 > 3) ? 1 : 0), T163.VCENTER_HCENTER);
					}
					g.M948(T54.imgLbtnFocus, T51.w / 2 - num6 + m * num6, yButton + disY, 3);
				}
				T98.tahoma_7b_dark.M898(g, mResources.hairStyleName[indexGender][m], T51.w / 2 - num6 + m * num6, yButton + disY - 5, T98.CENTER);
			}
			tAddName.M1916(g);
		}
		g.M922(0, 0, T51.w, T51.h);
		T98.tahoma_7b_white.M902(g, mResources.server + " " + T90.serverName, 5, 5, 0, T98.tahoma_7b_dark);
		if (!T177.visible)
		{
			base.paint(g);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8001:
			if (T51.loginScr.isLogin2)
			{
				T51.M496(mResources.note, new T22(mResources.YES, this, 10019, null), new T22(mResources.NO, this, 10020, null));
				break;
			}
			if (Main.isWindowsPhone)
			{
				T52.isBackWindowsPhone = true;
			}
			T147.M1744().close();
			T51.serverScreen.switchToMe();
			break;
		case 8000:
			if (tAddName.M1924().Equals(string.Empty))
			{
				T51.M489(mResources.char_name_blank);
				break;
			}
			if (tAddName.M1924().Length < 5)
			{
				T51.M489(mResources.char_name_short);
				break;
			}
			if (tAddName.M1924().Length > 15)
			{
				T51.M489(mResources.char_name_long);
				break;
			}
			T66.M749();
			T146.M1594().M1643(tAddName.M1924(), indexGender, hairID[indexGender][indexHair]);
			break;
		case 10020:
			T51.M488();
			break;
		case 10019:
			T147.M1744().close();
			T51.M488();
			T51.serverScreen.switchToMe();
			break;
		}
	}
}
