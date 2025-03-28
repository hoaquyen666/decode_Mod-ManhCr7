public class Npc : Char
{
	public const sbyte BINH_KHI = 0;

	public const sbyte PHONG_CU = 1;

	public const sbyte TRANG_SUC = 2;

	public const sbyte DUOC_PHAM = 3;

	public const sbyte TAP_HOA = 4;

	public const sbyte THU_KHO = 5;

	public const sbyte DA_LUYEN = 6;

	public NpcTemplate template;

	public int npcId;

	public bool isFocus = true;

	public static NpcTemplate[] arrNpcTemplate;

	public int sys;

	public bool isHide;

	private int duaHauIndex;

	private int dyEff;

	public static bool mabuEff;

	public static int tMabuEff;

	private static int[] shock_x = new int[4] { 1, -1, 1, -1 };

	private static int[] shock_y = new int[4] { 1, -1, -1, 1 };

	public static int shock_scr;

	public int[] duahau;

	public new int seconds;

	public new long last;

	public new long cur;

	public int idItem;

	public Npc(int npcId, int status, int cx, int cy, int templateId, int avatar)
	{
		isShadown = true;
		this.npcId = npcId;
		base.avatar = avatar;
		base.cx = cx;
		base.cy = cy;
		xSd = cx;
		ySd = cy;
		statusMe = status;
		if (npcId != -1)
		{
			template = arrNpcTemplate[templateId];
		}
		if (templateId == 23 || templateId == 42)
		{
			ch = 45;
		}
		if (templateId == 51)
		{
			isShadown = false;
			duaHauIndex = status;
		}
		if (template != null)
		{
			if (template.name == null)
			{
				template.name = string.Empty;
			}
			template.name = Res.M1518(template.name);
		}
	}

	public void M1195(sbyte s, int sc)
	{
		duaHauIndex = s;
		last = (cur = mSystem.M1054());
		seconds = sc;
	}

	public static void M1196()
	{
		for (int i = 0; i < GameScr.vNpc.M1113(); i++)
		{
			Npc t = (Npc)GameScr.vNpc.M1114(i);
			t.effTask = null;
			t.indexEffTask = -1;
		}
	}

	public override void update()
	{
		if (template.npcTemplateId == 51)
		{
			cur = mSystem.M1054();
			if (cur - last >= 1000L)
			{
				seconds--;
				last = cur;
				if (seconds < 0)
				{
					seconds = 0;
				}
			}
		}
		if (isShadown)
		{
			M193();
		}
		if (effTask == null)
		{
			sbyte[] array = new sbyte[7] { -1, 9, 9, 10, 10, 11, 11 };
			if (Char.M113().ctaskId >= 9 && Char.M113().ctaskId <= 10 && Char.M113().nClass.classId > 0 && array[Char.M113().nClass.classId] == template.npcTemplateId)
			{
				if (Char.M113().taskMaint == null)
				{
					effTask = GameScr.efs[57];
					indexEffTask = 0;
				}
				else if (Char.M113().taskMaint != null && Char.M113().taskMaint.index + 1 == Char.M113().taskMaint.subNames.Length)
				{
					effTask = GameScr.efs[62];
					indexEffTask = 0;
				}
			}
			else
			{
				sbyte b = GameScr.M660();
				if (Char.M113().taskMaint == null && b == template.npcTemplateId)
				{
					indexEffTask = 0;
				}
				else if (Char.M113().taskMaint != null && b == template.npcTemplateId)
				{
					if (Char.M113().taskMaint.index + 1 == Char.M113().taskMaint.subNames.Length)
					{
						effTask = GameScr.efs[98];
					}
					else
					{
						effTask = GameScr.efs[98];
					}
					indexEffTask = 0;
				}
			}
		}
		base.update();
		if (TileMap.mapID != 51)
		{
			return;
		}
		if (cx > Char.M113().cx)
		{
			cdir = -1;
		}
		else
		{
			cdir = 1;
		}
		if (template.npcTemplateId % 2 == 0)
		{
			if (cf == 1)
			{
				cf = 0;
			}
			else
			{
				cf = 1;
			}
		}
	}

	public void M1197(mGraphics g, int xStart, int yStart)
	{
		Part t = GameScr.parts[template.headId];
		if (cdir == 1)
		{
			SmallImage.M1785(g, t.pi[Char.CharInfo[cf][0][0]].id, GameCanvas.w - 31 - g.M920(), 2 - g.M921(), 0, 0);
		}
		else
		{
			SmallImage.M1785(g, t.pi[Char.CharInfo[cf][0][0]].id, GameCanvas.w - 31 - g.M920(), 2 - g.M921(), 2, 24);
		}
	}

	public override void paint(mGraphics g)
	{
		if (Char.isLoadingMap || isHide || !M181() || statusMe == 15)
		{
			return;
		}
		if (cTypePk != 0)
		{
			base.paint(g);
		}
		else
		{
			if (template == null)
			{
				return;
			}
			if (template.npcTemplateId != 4 && template.npcTemplateId != 51 && template.npcTemplateId != 50)
			{
				g.M948(TileMap.bong, cx, cy, 3);
			}
			if (template.npcTemplateId == 3)
			{
				SmallImage.M1785(g, 265, cx, cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
				if (Char.M113().npcFocus != null && Char.M113().npcFocus.Equals(this) && ChatPopup.currChatPopup == null)
				{
					g.M940(Mob.imgHP, 0, 0, 9, 6, 0, cx, cy - ch + 4, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
				dyEff = 60;
			}
			else if (template.npcTemplateId != 4)
			{
				if (template.npcTemplateId != 50 && template.npcTemplateId != 51)
				{
					if (template.npcTemplateId == 6)
					{
						SmallImage.M1785(g, 545, cx, cy + 5, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
						if (Char.M113().npcFocus != null && Char.M113().npcFocus.Equals(this) && ChatPopup.currChatPopup == null)
						{
							g.M940(Mob.imgHP, 0, 0, 9, 6, 0, cx, cy - ch - 9, mGraphics.BOTTOM | mGraphics.HCENTER);
						}
						mFont.tahoma_7b_white.M898(g, TileMap.zoneID + string.Empty, cx, cy - ch + 19 - mFont.tahoma_7.M912(), mFont.CENTER);
					}
					else
					{
						int headId = template.headId;
						int legId = template.legId;
						int bodyId = template.bodyId;
						Part t = GameScr.parts[headId];
						Part t2 = GameScr.parts[legId];
						Part t3 = GameScr.parts[bodyId];
						if (cdir == 1)
						{
							SmallImage.M1785(g, t.pi[Char.CharInfo[cf][0][0]].id, cx + Char.CharInfo[cf][0][1] + t.pi[Char.CharInfo[cf][0][0]].dx, cy - Char.CharInfo[cf][0][2] + t.pi[Char.CharInfo[cf][0][0]].dy, 0, 0);
							SmallImage.M1785(g, t2.pi[Char.CharInfo[cf][1][0]].id, cx + Char.CharInfo[cf][1][1] + t2.pi[Char.CharInfo[cf][1][0]].dx, cy - Char.CharInfo[cf][1][2] + t2.pi[Char.CharInfo[cf][1][0]].dy, 0, 0);
							SmallImage.M1785(g, t3.pi[Char.CharInfo[cf][2][0]].id, cx + Char.CharInfo[cf][2][1] + t3.pi[Char.CharInfo[cf][2][0]].dx, cy - Char.CharInfo[cf][2][2] + t3.pi[Char.CharInfo[cf][2][0]].dy, 0, 0);
						}
						else
						{
							SmallImage.M1785(g, t.pi[Char.CharInfo[cf][0][0]].id, cx - Char.CharInfo[cf][0][1] - t.pi[Char.CharInfo[cf][0][0]].dx, cy - Char.CharInfo[cf][0][2] + t.pi[Char.CharInfo[cf][0][0]].dy, 2, 24);
							SmallImage.M1785(g, t2.pi[Char.CharInfo[cf][1][0]].id, cx - Char.CharInfo[cf][1][1] - t2.pi[Char.CharInfo[cf][1][0]].dx, cy - Char.CharInfo[cf][1][2] + t2.pi[Char.CharInfo[cf][1][0]].dy, 2, 24);
							SmallImage.M1785(g, t3.pi[Char.CharInfo[cf][2][0]].id, cx - Char.CharInfo[cf][2][1] - t3.pi[Char.CharInfo[cf][2][0]].dx, cy - Char.CharInfo[cf][2][2] + t3.pi[Char.CharInfo[cf][2][0]].dy, 2, 24);
						}
						if (TileMap.mapID != 51)
						{
							int num = 15;
							if (template.npcTemplateId == 47)
							{
								num = 47;
							}
							if (Char.M113().npcFocus != null && Char.M113().npcFocus.Equals(this))
							{
								if (ChatPopup.currChatPopup == null)
								{
									g.M940(Mob.imgHP, 0, 0, 9, 6, 0, cx, cy - ch - (num - 8), mGraphics.BOTTOM | mGraphics.HCENTER);
								}
							}
							else
							{
								num = 8;
								if (template.npcTemplateId == 47)
								{
									num = 40;
								}
							}
						}
						dyEff = 65;
					}
				}
				else if (duahau != null)
				{
					if (template.npcTemplateId == 50 && mabuEff)
					{
						tMabuEff++;
						if (GameCanvas.gameTick % 3 == 0)
						{
							EffectMn.M376(new Effect(19, cx + Res.M1522(-50, 50), cy, 2, 1, -1));
						}
						if (GameCanvas.gameTick % 15 == 0)
						{
							EffectMn.M376(new Effect(18, cx + Res.M1522(-5, 5), cy + Res.M1522(-90, 0), 2, 1, -1));
						}
						if (tMabuEff == 100)
						{
							GameScr.M559().M590(cx, cy);
						}
						if (tMabuEff == 110)
						{
							mabuEff = false;
							template.npcTemplateId = 4;
						}
					}
					int num2 = 0;
					if (SmallImage.imgNew[duahau[duaHauIndex]] != null && SmallImage.imgNew[duahau[duaHauIndex]].img != null)
					{
						num2 = mGraphics.M959(SmallImage.imgNew[duahau[duaHauIndex]].img);
					}
					SmallImage.M1785(g, duahau[duaHauIndex], cx + Res.M1522(-1, 1), cy, 0, mGraphics.BOTTOM | mGraphics.HCENTER);
					if (Char.M113().npcFocus != null && Char.M113().npcFocus.Equals(this))
					{
						if (ChatPopup.currChatPopup == null)
						{
							g.M940(Mob.imgHP, 0, 0, 9, 6, 0, cx, cy - ch - 9 + 16 - num2, mGraphics.BOTTOM | mGraphics.HCENTER);
						}
						mFont.tahoma_7b_white.M902(g, NinjaUtil.M1191(seconds), cx, cy - ch - 16 - mFont.tahoma_7.M912() - 20 - num2 + 16, mFont.CENTER, mFont.tahoma_7b_dark);
					}
					else
					{
						mFont.tahoma_7b_white.M902(g, NinjaUtil.M1191(seconds), cx, cy - ch - 8 - mFont.tahoma_7.M912() - 20 - num2 + 16, mFont.CENTER, mFont.tahoma_7b_dark);
					}
				}
			}
			if (indexEffTask < 0 || effTask == null || cTypePk != 0)
			{
				return;
			}
			SmallImage.M1785(g, effTask.arrEfInfo[indexEffTask].idImg, cx + effTask.arrEfInfo[indexEffTask].dx, cy + effTask.arrEfInfo[indexEffTask].dy - dyEff, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			if (GameCanvas.gameTick % 2 == 0)
			{
				indexEffTask++;
				if (indexEffTask >= effTask.arrEfInfo.Length)
				{
					indexEffTask = 0;
				}
			}
		}
	}

	public void M1198(mGraphics g)
	{
		if (Char.isLoadingMap || isHide || !M181() || statusMe == 15 || template == null)
		{
			return;
		}
		if (template.npcTemplateId == 3)
		{
			if (Char.M113().npcFocus != null && Char.M113().npcFocus.Equals(this))
			{
				mFont.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - mFont.tahoma_7.M912() - 5, mFont.CENTER, mFont.tahoma_7_grey);
			}
			else
			{
				mFont.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - 3 - mFont.tahoma_7.M912(), mFont.CENTER, mFont.tahoma_7_grey);
			}
			dyEff = 60;
		}
		else
		{
			if (template.npcTemplateId == 4)
			{
				return;
			}
			if (template.npcTemplateId != 50 && template.npcTemplateId != 51)
			{
				if (template.npcTemplateId == 6)
				{
					if (Char.M113().npcFocus != null && Char.M113().npcFocus.Equals(this))
					{
						mFont.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - mFont.tahoma_7.M912() - 16, mFont.CENTER, mFont.tahoma_7_grey);
					}
					else
					{
						mFont.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - 8 - mFont.tahoma_7.M912(), mFont.CENTER, mFont.tahoma_7_grey);
					}
					return;
				}
				if (TileMap.mapID != 51)
				{
					int num = 15;
					if (template.npcTemplateId == 47)
					{
						num = 47;
					}
					if (Char.M113().npcFocus != null && Char.M113().npcFocus.Equals(this))
					{
						if (TileMap.mapID != 113)
						{
							mFont.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - mFont.tahoma_7.M912() - num, mFont.CENTER, mFont.tahoma_7_grey);
						}
					}
					else
					{
						num = 8;
						if (template.npcTemplateId == 47)
						{
							num = 40;
						}
						if (TileMap.mapID != 113)
						{
							mFont.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - num - mFont.tahoma_7.M912(), mFont.CENTER, mFont.tahoma_7_grey);
						}
					}
				}
				dyEff = 65;
			}
			else if (duahau != null)
			{
				int num2 = 0;
				if (SmallImage.imgNew[duahau[duaHauIndex]] != null && SmallImage.imgNew[duahau[duaHauIndex]].img != null)
				{
					num2 = mGraphics.M959(SmallImage.imgNew[duahau[duaHauIndex]].img);
				}
				if (Char.M113().npcFocus != null && Char.M113().npcFocus.Equals(this))
				{
					mFont.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - mFont.tahoma_7.M912() - num2, mFont.CENTER, mFont.tahoma_7_grey);
				}
				else
				{
					mFont.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - 8 - mFont.tahoma_7.M912() - num2 + 16, mFont.CENTER, mFont.tahoma_7_grey);
				}
			}
		}
	}

	public void M1199()
	{
		statusMe = 15;
		Char.chatPopup = null;
	}
}
