public class T123 : T13
{
	public const sbyte BINH_KHI = 0;

	public const sbyte PHONG_CU = 1;

	public const sbyte TRANG_SUC = 2;

	public const sbyte DUOC_PHAM = 3;

	public const sbyte TAP_HOA = 4;

	public const sbyte THU_KHO = 5;

	public const sbyte DA_LUYEN = 6;

	public T124 template;

	public int npcId;

	public bool isFocus = true;

	public static T124[] arrNpcTemplate;

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

	public T123(int npcId, int status, int cx, int cy, int templateId, int avatar)
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
			template.name = T137.M1518(template.name);
		}
	}

	public void M1195(sbyte s, int sc)
	{
		duaHauIndex = s;
		last = (cur = T110.M1054());
		seconds = sc;
	}

	public static void M1196()
	{
		for (int i = 0; i < T54.vNpc.M1113(); i++)
		{
			T123 t = (T123)T54.vNpc.M1114(i);
			t.effTask = null;
			t.indexEffTask = -1;
		}
	}

	public override void update()
	{
		if (template.npcTemplateId == 51)
		{
			cur = T110.M1054();
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
			if (T13.M113().ctaskId >= 9 && T13.M113().ctaskId <= 10 && T13.M113().nClass.classId > 0 && array[T13.M113().nClass.classId] == template.npcTemplateId)
			{
				if (T13.M113().taskMaint == null)
				{
					effTask = T54.efs[57];
					indexEffTask = 0;
				}
				else if (T13.M113().taskMaint != null && T13.M113().taskMaint.index + 1 == T13.M113().taskMaint.subNames.Length)
				{
					effTask = T54.efs[62];
					indexEffTask = 0;
				}
			}
			else
			{
				sbyte b = T54.M660();
				if (T13.M113().taskMaint == null && b == template.npcTemplateId)
				{
					indexEffTask = 0;
				}
				else if (T13.M113().taskMaint != null && b == template.npcTemplateId)
				{
					if (T13.M113().taskMaint.index + 1 == T13.M113().taskMaint.subNames.Length)
					{
						effTask = T54.efs[98];
					}
					else
					{
						effTask = T54.efs[98];
					}
					indexEffTask = 0;
				}
			}
		}
		base.update();
		if (T174.mapID != 51)
		{
			return;
		}
		if (cx > T13.M113().cx)
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

	public void M1197(T99 g, int xStart, int yStart)
	{
		T127 t = T54.parts[template.headId];
		if (cdir == 1)
		{
			T157.M1785(g, t.pi[T13.CharInfo[cf][0][0]].id, T51.w - 31 - g.M920(), 2 - g.M921(), 0, 0);
		}
		else
		{
			T157.M1785(g, t.pi[T13.CharInfo[cf][0][0]].id, T51.w - 31 - g.M920(), 2 - g.M921(), 2, 24);
		}
	}

	public override void paint(T99 g)
	{
		if (T13.isLoadingMap || isHide || !M181() || statusMe == 15)
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
				g.M948(T174.bong, cx, cy, 3);
			}
			if (template.npcTemplateId == 3)
			{
				T157.M1785(g, 265, cx, cy, 0, T99.BOTTOM | T99.HCENTER);
				if (T13.M113().npcFocus != null && T13.M113().npcFocus.Equals(this) && T14.currChatPopup == null)
				{
					g.M940(T101.imgHP, 0, 0, 9, 6, 0, cx, cy - ch + 4, T99.BOTTOM | T99.HCENTER);
				}
				dyEff = 60;
			}
			else if (template.npcTemplateId != 4)
			{
				if (template.npcTemplateId != 50 && template.npcTemplateId != 51)
				{
					if (template.npcTemplateId == 6)
					{
						T157.M1785(g, 545, cx, cy + 5, 0, T99.BOTTOM | T99.HCENTER);
						if (T13.M113().npcFocus != null && T13.M113().npcFocus.Equals(this) && T14.currChatPopup == null)
						{
							g.M940(T101.imgHP, 0, 0, 9, 6, 0, cx, cy - ch - 9, T99.BOTTOM | T99.HCENTER);
						}
						T98.tahoma_7b_white.M898(g, T174.zoneID + string.Empty, cx, cy - ch + 19 - T98.tahoma_7.M912(), T98.CENTER);
					}
					else
					{
						int headId = template.headId;
						int legId = template.legId;
						int bodyId = template.bodyId;
						T127 t = T54.parts[headId];
						T127 t2 = T54.parts[legId];
						T127 t3 = T54.parts[bodyId];
						if (cdir == 1)
						{
							T157.M1785(g, t.pi[T13.CharInfo[cf][0][0]].id, cx + T13.CharInfo[cf][0][1] + t.pi[T13.CharInfo[cf][0][0]].dx, cy - T13.CharInfo[cf][0][2] + t.pi[T13.CharInfo[cf][0][0]].dy, 0, 0);
							T157.M1785(g, t2.pi[T13.CharInfo[cf][1][0]].id, cx + T13.CharInfo[cf][1][1] + t2.pi[T13.CharInfo[cf][1][0]].dx, cy - T13.CharInfo[cf][1][2] + t2.pi[T13.CharInfo[cf][1][0]].dy, 0, 0);
							T157.M1785(g, t3.pi[T13.CharInfo[cf][2][0]].id, cx + T13.CharInfo[cf][2][1] + t3.pi[T13.CharInfo[cf][2][0]].dx, cy - T13.CharInfo[cf][2][2] + t3.pi[T13.CharInfo[cf][2][0]].dy, 0, 0);
						}
						else
						{
							T157.M1785(g, t.pi[T13.CharInfo[cf][0][0]].id, cx - T13.CharInfo[cf][0][1] - t.pi[T13.CharInfo[cf][0][0]].dx, cy - T13.CharInfo[cf][0][2] + t.pi[T13.CharInfo[cf][0][0]].dy, 2, 24);
							T157.M1785(g, t2.pi[T13.CharInfo[cf][1][0]].id, cx - T13.CharInfo[cf][1][1] - t2.pi[T13.CharInfo[cf][1][0]].dx, cy - T13.CharInfo[cf][1][2] + t2.pi[T13.CharInfo[cf][1][0]].dy, 2, 24);
							T157.M1785(g, t3.pi[T13.CharInfo[cf][2][0]].id, cx - T13.CharInfo[cf][2][1] - t3.pi[T13.CharInfo[cf][2][0]].dx, cy - T13.CharInfo[cf][2][2] + t3.pi[T13.CharInfo[cf][2][0]].dy, 2, 24);
						}
						if (T174.mapID != 51)
						{
							int num = 15;
							if (template.npcTemplateId == 47)
							{
								num = 47;
							}
							if (T13.M113().npcFocus != null && T13.M113().npcFocus.Equals(this))
							{
								if (T14.currChatPopup == null)
								{
									g.M940(T101.imgHP, 0, 0, 9, 6, 0, cx, cy - ch - (num - 8), T99.BOTTOM | T99.HCENTER);
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
						if (T51.gameTick % 3 == 0)
						{
							T31.M376(new T32(19, cx + T137.M1522(-50, 50), cy, 2, 1, -1));
						}
						if (T51.gameTick % 15 == 0)
						{
							T31.M376(new T32(18, cx + T137.M1522(-5, 5), cy + T137.M1522(-90, 0), 2, 1, -1));
						}
						if (tMabuEff == 100)
						{
							T54.M559().M590(cx, cy);
						}
						if (tMabuEff == 110)
						{
							mabuEff = false;
							template.npcTemplateId = 4;
						}
					}
					int num2 = 0;
					if (T157.imgNew[duahau[duaHauIndex]] != null && T157.imgNew[duahau[duaHauIndex]].img != null)
					{
						num2 = T99.M959(T157.imgNew[duahau[duaHauIndex]].img);
					}
					T157.M1785(g, duahau[duaHauIndex], cx + T137.M1522(-1, 1), cy, 0, T99.BOTTOM | T99.HCENTER);
					if (T13.M113().npcFocus != null && T13.M113().npcFocus.Equals(this))
					{
						if (T14.currChatPopup == null)
						{
							g.M940(T101.imgHP, 0, 0, 9, 6, 0, cx, cy - ch - 9 + 16 - num2, T99.BOTTOM | T99.HCENTER);
						}
						T98.tahoma_7b_white.M902(g, T122.M1191(seconds), cx, cy - ch - 16 - T98.tahoma_7.M912() - 20 - num2 + 16, T98.CENTER, T98.tahoma_7b_dark);
					}
					else
					{
						T98.tahoma_7b_white.M902(g, T122.M1191(seconds), cx, cy - ch - 8 - T98.tahoma_7.M912() - 20 - num2 + 16, T98.CENTER, T98.tahoma_7b_dark);
					}
				}
			}
			if (indexEffTask < 0 || effTask == null || cTypePk != 0)
			{
				return;
			}
			T157.M1785(g, effTask.arrEfInfo[indexEffTask].idImg, cx + effTask.arrEfInfo[indexEffTask].dx, cy + effTask.arrEfInfo[indexEffTask].dy - dyEff, 0, T99.VCENTER | T99.HCENTER);
			if (T51.gameTick % 2 == 0)
			{
				indexEffTask++;
				if (indexEffTask >= effTask.arrEfInfo.Length)
				{
					indexEffTask = 0;
				}
			}
		}
	}

	public void M1198(T99 g)
	{
		if (T13.isLoadingMap || isHide || !M181() || statusMe == 15 || template == null)
		{
			return;
		}
		if (template.npcTemplateId == 3)
		{
			if (T13.M113().npcFocus != null && T13.M113().npcFocus.Equals(this))
			{
				T98.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - T98.tahoma_7.M912() - 5, T98.CENTER, T98.tahoma_7_grey);
			}
			else
			{
				T98.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - 3 - T98.tahoma_7.M912(), T98.CENTER, T98.tahoma_7_grey);
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
					if (T13.M113().npcFocus != null && T13.M113().npcFocus.Equals(this))
					{
						T98.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - T98.tahoma_7.M912() - 16, T98.CENTER, T98.tahoma_7_grey);
					}
					else
					{
						T98.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - 8 - T98.tahoma_7.M912(), T98.CENTER, T98.tahoma_7_grey);
					}
					return;
				}
				if (T174.mapID != 51)
				{
					int num = 15;
					if (template.npcTemplateId == 47)
					{
						num = 47;
					}
					if (T13.M113().npcFocus != null && T13.M113().npcFocus.Equals(this))
					{
						if (T174.mapID != 113)
						{
							T98.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - T98.tahoma_7.M912() - num, T98.CENTER, T98.tahoma_7_grey);
						}
					}
					else
					{
						num = 8;
						if (template.npcTemplateId == 47)
						{
							num = 40;
						}
						if (T174.mapID != 113)
						{
							T98.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - num - T98.tahoma_7.M912(), T98.CENTER, T98.tahoma_7_grey);
						}
					}
				}
				dyEff = 65;
			}
			else if (duahau != null)
			{
				int num2 = 0;
				if (T157.imgNew[duahau[duaHauIndex]] != null && T157.imgNew[duahau[duaHauIndex]].img != null)
				{
					num2 = T99.M959(T157.imgNew[duahau[duaHauIndex]].img);
				}
				if (T13.M113().npcFocus != null && T13.M113().npcFocus.Equals(this))
				{
					T98.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - T98.tahoma_7.M912() - num2, T98.CENTER, T98.tahoma_7_grey);
				}
				else
				{
					T98.tahoma_7_yellow.M902(g, template.name, cx, cy - ch - 8 - T98.tahoma_7.M912() - num2 + 16, T98.CENTER, T98.tahoma_7_grey);
				}
			}
		}
	}

	public void M1199()
	{
		statusMe = 15;
		T13.chatPopup = null;
	}
}
