using System;

public class CreateCharScr : mScreen, IActionListener
{
	public static CreateCharScr instance;

	private PopUp p;

	public static bool isCreateChar = false;

	public static TField tAddName;

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

	public CreateCharScr()
	{
		try
		{
			if (!GameCanvas.lowGraphic)
			{
				M346(new sbyte[3] { 39, 40, 41 });
			}
			M347(new sbyte[3] { 39, 40, 41 });
		}
		catch (Exception ex)
		{
			Cout.M328("Tao char loi " + ex.ToString());
		}
		if (GameCanvas.w <= 200)
		{
			GameScr.M656(128, 100);
			GameScr.popupX = (GameCanvas.w - 128) / 2;
			GameScr.popupY = 10;
			cy += 15;
			dy -= 15;
		}
		indexGender = 1;
		tAddName = new TField();
		tAddName.width = GameCanvas.loginScr.tfUser.width;
		if (GameCanvas.w < 200)
		{
			tAddName.width = 60;
		}
		tAddName.height = mScreen.ITEM_HEIGHT + 2;
		if (GameCanvas.w < 200)
		{
			tAddName.x = GameScr.popupX + 45;
			tAddName.y = GameScr.popupY + 12;
		}
		else
		{
			tAddName.x = GameCanvas.w / 2 - tAddName.width / 2;
			tAddName.y = 35;
		}
		if (!GameCanvas.isTouch)
		{
			tAddName.isFocus = true;
		}
		tAddName.M1931(TField.INPUT_TYPE_ANY);
		tAddName.showSubTextField = false;
		tAddName.strInfo = mResources.char_name;
		if (tAddName.M1924().Equals("@"))
		{
			tAddName.M1926(GameCanvas.loginScr.tfUser.M1924().Substring(0, GameCanvas.loginScr.tfUser.M1924().IndexOf("@")));
		}
		tAddName.name = mResources.char_name;
		indexGender = 1;
		indexHair = 0;
		center = new Command(mResources.NEWCHAR, this, 8000, null);
		left = new Command(mResources.BACK, this, 8001, null);
		if (!GameCanvas.isTouch)
		{
			right = tAddName.cmdClear;
		}
		yBegin = tAddName.y;
	}

	public static CreateCharScr M344()
	{
		if (instance == null)
		{
			instance = new CreateCharScr();
		}
		return instance;
	}

	public static void M345()
	{
	}

	public static void M346(sbyte[] mapID)
	{
		Res.M1513("newwwwwwwwww =============");
		DataInputStream t = null;
		for (int i = 0; i < mapID.Length; i++)
		{
			t = MyStream.M1110("/mymap/" + mapID[i]);
			MapTemplate.tmw[i] = (ushort)t.M355();
			MapTemplate.tmh[i] = (ushort)t.M355();
			Cout.M328("Thong TIn : " + MapTemplate.tmw[i] + "::" + MapTemplate.tmh[i]);
			MapTemplate.maps[i] = new int[t.M366()];
			Cout.M328("lent= " + MapTemplate.maps[i].Length);
			for (int j = 0; j < MapTemplate.tmw[i] * MapTemplate.tmh[i]; j++)
			{
				MapTemplate.maps[i][j] = t.M355();
			}
			MapTemplate.types[i] = new int[MapTemplate.maps[i].Length];
		}
	}

	public void M347(sbyte[] mapID)
	{
		if (GameCanvas.lowGraphic)
		{
			return;
		}
		DataInputStream t = null;
		try
		{
			for (int i = 0; i < mapID.Length; i++)
			{
				t = MyStream.M1110("/mymap/mapTable" + mapID[i]);
				Cout.M328("mapTable : " + mapID[i]);
				short num = t.M353();
				MapTemplate.vCurrItem[i] = new MyVector();
				Res.M1513("nItem= " + num);
				for (int j = 0; j < num; j++)
				{
					short id = t.M353();
					short num2 = t.M353();
					short num3 = t.M353();
					if (TileMap.M1935(id) != null)
					{
						BgItem t2 = TileMap.M1935(id);
						BgItem t3 = new BgItem();
						t3.id = id;
						t3.idImage = t2.idImage;
						t3.dx = t2.dx;
						t3.dy = t2.dy;
						t3.x = num2 * TileMap.size;
						t3.y = num3 * TileMap.size;
						t3.layer = t2.layer;
						MapTemplate.vCurrItem[i].M1111(t3);
						if (!BgItem.imgNew.M1081(t3.idImage + string.Empty))
						{
							try
							{
								Image t4 = GameCanvas.M503("/mapBackGround/" + t3.idImage + ".png");
								if (t4 == null)
								{
									BgItem.imgNew.M1078(t3.idImage + string.Empty, Image.M711(new int[1], 1, 1, bl: true));
									Service.M1594().M1709(t3.idImage);
								}
								else
								{
									BgItem.imgNew.M1078(t3.idImage + string.Empty, t4);
								}
							}
							catch (Exception)
							{
								Image t5 = GameCanvas.M503("/mapBackGround/" + t3.idImage + ".png");
								if (t5 == null)
								{
									t5 = Image.M711(new int[1], 1, 1, bl: true);
									Service.M1594().M1709(t3.idImage);
								}
								BgItem.imgNew.M1078(t3.idImage + string.Empty, t5);
							}
							BgItem.vKeysLast.M1111(t3.idImage + string.Empty);
						}
						if (!BgItem.M66(t3.idImage + string.Empty))
						{
							BgItem.vKeysNew.M1111(t3.idImage + string.Empty);
						}
						t3.M70();
					}
					else
					{
						Res.M1513("item null");
					}
				}
			}
		}
		catch (Exception ex2)
		{
			Cout.M326("LOI TAI loadMapTableFromResource" + ex2.ToString());
		}
	}

	public override void switchToMe()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		LoginScr.isContinueToLogin = false;
		GameCanvas.menu.showMenu = false;
		GameCanvas.M488();
		base.switchToMe();
		indexGender = Res.M1522(0, 3);
		indexHair = Res.M1522(0, 3);
		M348();
		Char.isLoadingMap = false;
		tAddName.M1923(isFocus: true);
	}

	public void M348()
	{
		TileMap.maps = new int[MapTemplate.maps[indexGender].Length];
		for (int i = 0; i < MapTemplate.maps[indexGender].Length; i++)
		{
			TileMap.maps[i] = MapTemplate.maps[indexGender][i];
		}
		TileMap.types = MapTemplate.types[indexGender];
		TileMap.pxh = MapTemplate.pxh[indexGender];
		TileMap.pxw = MapTemplate.pxw[indexGender];
		TileMap.tileID = MapTemplate.pxw[indexGender];
		TileMap.tmw = MapTemplate.tmw[indexGender];
		TileMap.tmh = MapTemplate.tmh[indexGender];
		TileMap.tileID = bgID[indexGender] + 1;
		TileMap.M1964();
		TileMap.M1940();
		GameCanvas.M469(bgID[indexGender]);
		GameScr.M564(fullmScreen: false, cx, cy);
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
		if (GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21])
		{
			selected--;
			if (selected < 0)
			{
				selected = mResources.MENUNEWCHAR.Length - 1;
			}
		}
		if (GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22])
		{
			selected++;
			if (selected >= mResources.MENUNEWCHAR.Length)
			{
				selected = 0;
			}
		}
		if (selected == 0)
		{
			if (!GameCanvas.isTouch)
			{
				right = tAddName.cmdClear;
			}
			tAddName.M1920();
		}
		if (selected == 1)
		{
			if (GameCanvas.keyPressed[(!Main.isPC) ? 4 : 23])
			{
				indexGender--;
				if (indexGender < 0)
				{
					indexGender = mResources.MENUGENDER.Length - 1;
				}
				M348();
			}
			if (GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24])
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
			if (GameCanvas.keyPressed[(!Main.isPC) ? 4 : 23])
			{
				indexHair--;
				if (indexHair < 0)
				{
					indexHair = mResources.hairStyleName[0].Length - 1;
				}
			}
			if (GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24])
			{
				indexHair++;
				if (indexHair > mResources.hairStyleName[0].Length - 1)
				{
					indexHair = 0;
				}
			}
			right = null;
		}
		if (GameCanvas.isPointerJustRelease)
		{
			int num = 110;
			int num2 = 60;
			int num3 = 78;
			if (GameCanvas.w > GameCanvas.h)
			{
				num = 100;
				num2 = 40;
			}
			if (GameCanvas.M481(GameCanvas.w / 2 - 3 * num3 / 2, 15, num3 * 3, 80))
			{
				selected = 0;
				tAddName.isFocus = true;
			}
			if (GameCanvas.M481(GameCanvas.w / 2 - 3 * num3 / 2, num - 30, num3 * 3, num2 + 5))
			{
				selected = 1;
				int num4 = indexGender;
				indexGender = (GameCanvas.px - (GameCanvas.w / 2 - 3 * num3 / 2)) / num3;
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
			if (GameCanvas.M481(GameCanvas.w / 2 - 3 * num3 / 2, num - 30 + num2 + 5, num3 * 3, 65))
			{
				selected = 2;
				int num5 = indexHair;
				indexHair = (GameCanvas.px - (GameCanvas.w / 2 - 3 * num3 / 2)) / num3;
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
		if (!TouchScreenKeyboard.visible)
		{
			base.updateKey();
		}
		GameCanvas.M484();
		GameCanvas.M483();
	}

	public override void paint(mGraphics g)
	{
		if (Char.isLoadingMap)
		{
			return;
		}
		GameCanvas.M466(g);
		g.M918(-GameScr.cmx, -GameScr.cmy);
		if (!GameCanvas.lowGraphic)
		{
			for (int i = 0; i < MapTemplate.vCurrItem[indexGender].M1113(); i++)
			{
				BgItem t = (BgItem)MapTemplate.vCurrItem[indexGender].M1114(i);
				if (t.idImage != -1 && t.layer == 1)
				{
					t.M71(g);
				}
			}
		}
		TileMap.M1951(g);
		int num = 30;
		if (GameCanvas.w == 128)
		{
			num = 20;
		}
		int num2 = hairID[indexGender][indexHair];
		int num3 = defaultLeg[indexGender];
		int num4 = defaultBody[indexGender];
		g.M948(TileMap.bong, cx, cy + dy, 3);
		Part t2 = GameScr.parts[num2];
		Part t3 = GameScr.parts[num3];
		Part t4 = GameScr.parts[num4];
		SmallImage.M1785(g, t2.pi[Char.CharInfo[cf][0][0]].id, cx + Char.CharInfo[cf][0][1] + t2.pi[Char.CharInfo[cf][0][0]].dx, cy - Char.CharInfo[cf][0][2] + t2.pi[Char.CharInfo[cf][0][0]].dy + dy, 0, 0);
		SmallImage.M1785(g, t3.pi[Char.CharInfo[cf][1][0]].id, cx + Char.CharInfo[cf][1][1] + t3.pi[Char.CharInfo[cf][1][0]].dx, cy - Char.CharInfo[cf][1][2] + t3.pi[Char.CharInfo[cf][1][0]].dy + dy, 0, 0);
		SmallImage.M1785(g, t4.pi[Char.CharInfo[cf][2][0]].id, cx + Char.CharInfo[cf][2][1] + t4.pi[Char.CharInfo[cf][2][0]].dx, cy - Char.CharInfo[cf][2][2] + t4.pi[Char.CharInfo[cf][2][0]].dy + dy, 0, 0);
		if (!GameCanvas.lowGraphic)
		{
			for (int j = 0; j < MapTemplate.vCurrItem[indexGender].M1113(); j++)
			{
				BgItem t5 = (BgItem)MapTemplate.vCurrItem[indexGender].M1114(j);
				if (t5.idImage != -1 && t5.layer == 3)
				{
					t5.M71(g);
				}
			}
		}
		g.M918(-g.M920(), -g.M921());
		if (GameCanvas.w < 200)
		{
			GameCanvas.paintz.M1235(GameScr.popupX, GameScr.popupY, GameScr.popupW, GameScr.popupH, g);
			SmallImage.M1785(g, t2.pi[Char.CharInfo[0][0][0]].id, GameCanvas.w / 2 + Char.CharInfo[0][0][1] + t2.pi[Char.CharInfo[0][0][0]].dx, GameScr.popupY + 30 + 3 * num - Char.CharInfo[0][0][2] + t2.pi[Char.CharInfo[0][0][0]].dy + dy, 0, 0);
			SmallImage.M1785(g, t3.pi[Char.CharInfo[0][1][0]].id, GameCanvas.w / 2 + Char.CharInfo[0][1][1] + t3.pi[Char.CharInfo[0][1][0]].dx, GameScr.popupY + 30 + 3 * num - Char.CharInfo[0][1][2] + t3.pi[Char.CharInfo[0][1][0]].dy + dy, 0, 0);
			SmallImage.M1785(g, t4.pi[Char.CharInfo[0][2][0]].id, GameCanvas.w / 2 + Char.CharInfo[0][2][1] + t4.pi[Char.CharInfo[0][2][0]].dx, GameScr.popupY + 30 + 3 * num - Char.CharInfo[0][2][2] + t4.pi[Char.CharInfo[0][2][0]].dy + dy, 0, 0);
			for (int k = 0; k < mResources.MENUNEWCHAR.Length; k++)
			{
				if (selected == k)
				{
					g.M940(GameScr.arrow, 0, 0, 13, 16, 2, GameScr.popupX + 10 + ((GameCanvas.gameTick % 7 > 3) ? 1 : 0), GameScr.popupY + 35 + k * num, StaticObj.VCENTER_HCENTER);
					g.M940(GameScr.arrow, 0, 0, 13, 16, 0, GameScr.popupX + GameScr.popupW - 10 - ((GameCanvas.gameTick % 7 > 3) ? 1 : 0), GameScr.popupY + 35 + k * num, StaticObj.VCENTER_HCENTER);
				}
				mFont.tahoma_7b_dark.M898(g, mResources.MENUNEWCHAR[k], GameScr.popupX + 20, GameScr.popupY + 30 + k * num, 0);
			}
			mFont.tahoma_7b_dark.M898(g, mResources.MENUGENDER[indexGender], GameScr.popupX + 70, GameScr.popupY + 30 + num, mFont.LEFT);
			mFont.tahoma_7b_dark.M898(g, mResources.hairStyleName[indexGender][indexHair], GameScr.popupX + 55, GameScr.popupY + 30 + 2 * num, mFont.LEFT);
			tAddName.M1916(g);
		}
		else
		{
			if (!Main.isPC)
			{
				if (mGraphics.addYWhenOpenKeyBoard != 0)
				{
					yButton = 110;
					disY = 60;
					if (GameCanvas.w > GameCanvas.h)
					{
						yButton = GameScr.popupY + 30 + 3 * num + t4.pi[Char.CharInfo[0][2][0]].dy + dy - 15;
						disY = 35;
					}
				}
				else
				{
					yButton = 110;
					disY = 60;
					if (GameCanvas.w > GameCanvas.h)
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
				if (GameCanvas.w > GameCanvas.h)
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
					g.M948(GameScr.imgLbtn, GameCanvas.w / 2 - num5 + l * num5, yButton, 3);
				}
				else
				{
					if (selected == 1)
					{
						g.M940(GameScr.arrow, 0, 0, 13, 16, 4, GameCanvas.w / 2 - num5 + l * num5, yButton - 20 + ((GameCanvas.gameTick % 7 > 3) ? 1 : 0), StaticObj.VCENTER_HCENTER);
					}
					g.M948(GameScr.imgLbtnFocus, GameCanvas.w / 2 - num5 + l * num5, yButton, 3);
				}
				mFont.tahoma_7b_dark.M898(g, mResources.MENUGENDER[l], GameCanvas.w / 2 - num5 + l * num5, yButton - 5, mFont.CENTER);
			}
			for (int m = 0; m < 3; m++)
			{
				int num6 = 78;
				if (m != indexHair)
				{
					g.M948(GameScr.imgLbtn, GameCanvas.w / 2 - num6 + m * num6, yButton + disY, 3);
				}
				else
				{
					if (selected == 2)
					{
						g.M940(GameScr.arrow, 0, 0, 13, 16, 4, GameCanvas.w / 2 - num6 + m * num6, yButton + disY - 20 + ((GameCanvas.gameTick % 7 > 3) ? 1 : 0), StaticObj.VCENTER_HCENTER);
					}
					g.M948(GameScr.imgLbtnFocus, GameCanvas.w / 2 - num6 + m * num6, yButton + disY, 3);
				}
				mFont.tahoma_7b_dark.M898(g, mResources.hairStyleName[indexGender][m], GameCanvas.w / 2 - num6 + m * num6, yButton + disY - 5, mFont.CENTER);
			}
			tAddName.M1916(g);
		}
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
		mFont.tahoma_7b_white.M902(g, mResources.server + " " + LoginScr.serverName, 5, 5, 0, mFont.tahoma_7b_dark);
		if (!TouchScreenKeyboard.visible)
		{
			base.paint(g);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8001:
			if (GameCanvas.loginScr.isLogin2)
			{
				GameCanvas.M496(mResources.note, new Command(mResources.YES, this, 10019, null), new Command(mResources.NO, this, 10020, null));
				break;
			}
			if (Main.isWindowsPhone)
			{
				GameMidlet.isBackWindowsPhone = true;
			}
			Session_ME.M1744().close();
			GameCanvas.serverScreen.switchToMe();
			break;
		case 8000:
			if (tAddName.M1924().Equals(string.Empty))
			{
				GameCanvas.M489(mResources.char_name_blank);
				break;
			}
			if (tAddName.M1924().Length < 5)
			{
				GameCanvas.M489(mResources.char_name_short);
				break;
			}
			if (tAddName.M1924().Length > 15)
			{
				GameCanvas.M489(mResources.char_name_long);
				break;
			}
			InfoDlg.M749();
			Service.M1594().M1643(tAddName.M1924(), indexGender, hairID[indexGender][indexHair]);
			break;
		case 10020:
			GameCanvas.M488();
			break;
		case 10019:
			Session_ME.M1744().close();
			GameCanvas.M488();
			GameCanvas.serverScreen.switchToMe();
			break;
		}
	}
}
