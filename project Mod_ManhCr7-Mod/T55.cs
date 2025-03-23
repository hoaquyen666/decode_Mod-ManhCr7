using System;

public class T55
{
	public static int x;

	public static int y;

	public static int type;

	public static int t;

	public static int xF;

	public static int yF;

	public static bool isShow;

	public static bool activeClick;

	public static bool isViewMap;

	public static bool isCloseMap;

	public static bool isPaint;

	public static bool isCamera;

	public static int trans;

	public static bool paintFlare;

	public static bool isPaintArrow;

	private int s = 2;

	public static bool M692(int tastId, int index)
	{
		if (T13.M113().taskMaint != null && T13.M113().taskMaint.taskId == tastId && T13.M113().taskMaint.index == index)
		{
			return true;
		}
		return false;
	}

	public static bool M693()
	{
		if (M692(0, 3) && T51.panel.currentTabIndex == 0 && (T51.panel.cmy < 0 || T51.panel.cmy > 30))
		{
			return false;
		}
		if (M692(2, 0) && T51.panel.isShow && T51.panel.currentTabIndex != 0)
		{
			return false;
		}
		return true;
	}

	public static void M694()
	{
		if (T51.panel.isShow)
		{
			isPaint = false;
		}
		if (T54.M629() != null)
		{
			x = T54.M629().cx;
			y = T54.M629().cy;
			trans = 0;
			isCamera = true;
			type = (T51.isTouch ? 1 : 0);
		}
	}

	public static void M695(int index)
	{
		if (!T51.panel.isShow && T133.vPopups.M1113() - 1 >= index)
		{
			T133 t = (T133)T133.vPopups.M1114(index);
			x = t.cx + t.sayWidth / 2;
			y = t.cy + 30;
			if (!t.isHide && t.isPaint)
			{
				isPaint = true;
			}
			else
			{
				isPaint = false;
			}
			type = 0;
			isCamera = true;
			trans = 0;
			if (!T51.isTouch)
			{
				isPaint = false;
			}
		}
	}

	public static void M696()
	{
		type = 1;
		if (T51.panel.isShow)
		{
			isPaint = false;
		}
		bool flag = false;
		for (int i = 0; i < T54.vMob.M1113(); i++)
		{
			if (((T101)T54.vMob.M1114(i)).isHintFocus)
			{
				flag = true;
				break;
			}
		}
		int num = 0;
		T101 t;
		while (true)
		{
			if (num >= T54.vMob.M1113())
			{
				return;
			}
			t = (T101)T54.vMob.M1114(num);
			if (t.isHintFocus)
			{
				break;
			}
			if (!flag)
			{
				if (t.status != 0)
				{
					t.isHintFocus = true;
					return;
				}
				t.isHintFocus = false;
			}
			num++;
		}
		x = t.x;
		y = t.y + 5;
		isCamera = true;
		if (t.status == 0)
		{
			t.isHintFocus = false;
		}
	}

	public static bool M697()
	{
		if (T51.panel.isShow)
		{
			isPaint = false;
		}
		for (int i = 0; i < T54.vItemMap.M1113(); i++)
		{
			T80 t = (T80)T54.vItemMap.M1114(i);
			if (t.playerId == T13.M113().charID && t.template.id == 73)
			{
				type = 1;
				x = t.x;
				y = t.y + 5;
				isCamera = true;
				return true;
			}
		}
		return false;
	}

	public static void M698(T99 g)
	{
		try
		{
			if (!isPaintArrow || (x > T54.cmx && x < T54.cmx + T54.gW && y > T54.cmy && y < T54.cmy + T54.gH) || T51.gameTick % 10 < 5 || T14.currChatPopup != null || T14.serverChatPopUp != null || T51.panel.isShow || !isCamera)
			{
				return;
			}
			int num = x - T13.M113().cx;
			int num2 = y - T13.M113().cy;
			int num3 = 0;
			int num4 = 0;
			int arg = 0;
			if (num > 0 && num2 >= 0)
			{
				if (T137.M1529(num) >= T137.M1529(num2))
				{
					num3 = T54.gW - 10;
					num4 = T54.gH / 2 + 30;
					if (T51.isTouch)
					{
						num4 = T54.gH / 2 + 10;
					}
					arg = 0;
				}
				else
				{
					num3 = T54.gW / 2;
					num4 = T54.gH - 10;
					arg = 5;
				}
			}
			else if (num >= 0 && num2 < 0)
			{
				if (T137.M1529(num) >= T137.M1529(num2))
				{
					num3 = T54.gW - 10;
					num4 = T54.gH / 2 + 30;
					if (T51.isTouch)
					{
						num4 = T54.gH / 2 + 10;
					}
					arg = 0;
				}
				else
				{
					num3 = T54.gW / 2;
					num4 = 10;
					arg = 6;
				}
			}
			if (num < 0 && num2 >= 0)
			{
				if (T137.M1529(num) >= T137.M1529(num2))
				{
					num3 = 10;
					num4 = T54.gH / 2 + 30;
					if (T51.isTouch)
					{
						num4 = T54.gH / 2 + 10;
					}
					arg = 3;
				}
				else
				{
					num3 = T54.gW / 2;
					num4 = T54.gH - 10;
					arg = 5;
				}
			}
			else if (num <= 0 && num2 < 0)
			{
				if (T137.M1529(num) >= T137.M1529(num2))
				{
					num3 = 10;
					num4 = T54.gH / 2 + 30;
					if (T51.isTouch)
					{
						num4 = T54.gH / 2 + 10;
					}
					arg = 3;
				}
				else
				{
					num3 = T54.gW / 2;
					num4 = 10;
					arg = 6;
				}
			}
			T54.M631(g);
			g.M940(T54.arrow, 0, 0, 13, 16, arg, num3, num4, T163.VCENTER_HCENTER);
		}
		catch (Exception)
		{
		}
	}

	public static void M699(T99 g)
	{
		if (T14.serverChatPopUp != null || T13.M113().isUsePlane || T13.M113().isTeleport)
		{
			return;
		}
		M698(g);
		if (T51.menu.tDelay == 0 && isPaint && T14.scr == null && !T13.ischangingMap && T51.currentScreen == T54.M559() && (!T51.panel.isShow || T51.panel.cmx == 0))
		{
			if (isCamera)
			{
				g.M918(-T54.cmx, -T54.cmy);
			}
			if (trans == 0)
			{
				g.M948(T126.imgBantay, x - 15, y, 0);
			}
			if (trans == 1)
			{
				g.M940(T126.imgBantay, 0, 0, 14, 16, 2, x + 15, y, T163.TOP_RIGHT);
			}
			if (paintFlare)
			{
				g.M948(T80.imageFlare, x, y, 3);
			}
		}
	}

	public static void M700()
	{
		if (T13.M113().taskMaint != null && T51.currentScreen == T54.instance)
		{
			int taskId = T13.M113().taskMaint.taskId;
			int index = T13.M113().taskMaint.index;
			isCamera = false;
			trans = 0;
			type = 0;
			isPaint = true;
			isPaintArrow = true;
			if (T51.menu.showMenu && taskId > 0)
			{
				isPaint = false;
			}
			switch (taskId)
			{
			case 0:
				if (T14.currChatPopup == null && T13.M113().statusMe != 14)
				{
					if (index == 0 && T174.vGo.M1113() != 0)
					{
						x = ((T180)T174.vGo.M1114(0)).minX - 100;
						y = ((T180)T174.vGo.M1114(0)).minY + 40;
						isCamera = true;
					}
					if (index == 1)
					{
						M695(0);
					}
					if (index == 2)
					{
						M694();
					}
					if (index == 3)
					{
						if (!T51.panel.isShow)
						{
							M694();
						}
						else if (T51.panel.currentTabIndex == 0)
						{
							if (T51.panel.cp == null)
							{
								x = T51.panel.xScroll + T51.panel.wScroll / 2;
								y = T51.panel.yScroll + 20;
							}
							else if (T51.menu.tDelay != 0)
							{
								x = T51.panel.xScroll + 25;
								y = T51.panel.yScroll + 60;
							}
						}
						else if (T51.panel.currentTabIndex == 1)
						{
							x = T51.panel.startTabPos + 10;
							y = 65;
						}
					}
					if (index == 4)
					{
						if (T51.panel.isShow)
						{
							x = T51.panel.cmdClose.x + 5;
							y = T51.panel.cmdClose.y + 5;
						}
						else if (T51.menu.showMenu)
						{
							x = T51.w / 2;
							y = T51.h - 20;
						}
						else
						{
							M694();
						}
					}
					if (index == 5)
					{
						M694();
					}
				}
				else
				{
					x = T51.w / 2;
					y = T51.h - 15;
				}
				return;
			case 1:
				if (T14.currChatPopup == null && T13.M113().statusMe != 14)
				{
					if (index == 0)
					{
						if (T174.M1936())
						{
							M695(0);
						}
						else
						{
							M696();
						}
					}
					if (index == 1)
					{
						if (!T174.M1936())
						{
							M695(1);
						}
						else
						{
							M694();
						}
					}
				}
				else
				{
					x = T51.w / 2;
					y = T51.h - 15;
				}
				return;
			case 2:
				if (T14.currChatPopup == null && T13.M113().statusMe != 14)
				{
					if (index == 0)
					{
						if (!T174.M1936())
						{
							isViewMap = true;
						}
						if (!T51.panel.isShow)
						{
							if (!isViewMap)
							{
								x = T54.M559().cmdMenu.x;
								y = T54.M559().cmdMenu.y + 13;
								trans = 1;
							}
							else
							{
								if (T54.M659() == T174.mapID)
								{
									if (!M697())
									{
										M696();
									}
								}
								else
								{
									M695(0);
								}
								if (isViewMap)
								{
									isCloseMap = true;
								}
							}
						}
						else if (!isViewMap)
						{
							if (T51.panel.currentTabIndex == 0)
							{
								int num = ((T51.h <= 300) ? 10 : 15);
								x = T51.panel.xScroll + T51.panel.wScroll / 2;
								y = T51.panel.yScroll + T51.panel.hScroll - num;
							}
							else
							{
								x = T51.panel.startTabPos + 10;
								y = 65;
							}
						}
						else if (!isCloseMap)
						{
							x = T51.panel.cmdClose.x + 5;
							y = T51.panel.cmdClose.y + 5;
						}
						else
						{
							isPaint = false;
						}
						if (T13.M113().cMP <= 0)
						{
							x = T54.xHP + 5;
							y = T54.yHP + 13;
							isCamera = false;
						}
					}
					if (index == 1)
					{
						isPaint = false;
						isPaintArrow = false;
					}
				}
				else
				{
					x = T51.w / 2;
					y = T51.h - 15;
				}
				return;
			}
			if (T13.M113().taskMaint.taskId == 9 && T13.M113().taskMaint.index == 2)
			{
				for (int i = 0; i < T133.vPopups.M1113(); i++)
				{
					T133 t = (T133)T133.vPopups.M1114(i);
					if (t.cy <= 24)
					{
						x = t.cx + t.sayWidth / 2;
						y = t.cy + 30;
						isCamera = true;
						isPaint = false;
						isPaintArrow = true;
						return;
					}
				}
			}
			isPaint = false;
			isPaintArrow = false;
		}
		else
		{
			isPaint = false;
			isPaintArrow = false;
		}
	}

	public static void M701()
	{
		M700();
		int num = ((trans != 0) ? (-2) : 2);
		if (!activeClick)
		{
			paintFlare = false;
			t++;
			if (t == 50)
			{
				t = 0;
				activeClick = true;
			}
			return;
		}
		t++;
		if (type == 0)
		{
			if (t == 2)
			{
				x += 2 * num;
				y -= 4;
				paintFlare = true;
			}
			if (t == 4)
			{
				x -= 2 * num;
				y += 4;
				activeClick = false;
				paintFlare = false;
				t = 0;
			}
			if (t > 4)
			{
				activeClick = false;
			}
		}
		if (type != 1)
		{
			return;
		}
		if (t == 2)
		{
			if (T51.isTouch)
			{
				T54.M643(mResources.press_twice, x, y + 10, 0, 20, T98.MISS_ME);
			}
			paintFlare = true;
			x += 2 * num;
			y -= 4;
		}
		if (t == 4)
		{
			paintFlare = false;
			x -= num;
			y += 2;
		}
		if (t == 6)
		{
			paintFlare = true;
			x += num;
			y -= 2;
		}
		if (t == 8)
		{
			paintFlare = false;
			x -= num;
			y += 2;
		}
		if (t == 10)
		{
			x -= num;
			y += 2;
			activeClick = false;
			t = 0;
		}
	}
}
