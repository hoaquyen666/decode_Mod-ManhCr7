using System;

public class Hint
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
		if (Char.M113().taskMaint != null && Char.M113().taskMaint.taskId == tastId && Char.M113().taskMaint.index == index)
		{
			return true;
		}
		return false;
	}

	public static bool M693()
	{
		if (M692(0, 3) && GameCanvas.panel.currentTabIndex == 0 && (GameCanvas.panel.cmy < 0 || GameCanvas.panel.cmy > 30))
		{
			return false;
		}
		if (M692(2, 0) && GameCanvas.panel.isShow && GameCanvas.panel.currentTabIndex != 0)
		{
			return false;
		}
		return true;
	}

	public static void M694()
	{
		if (GameCanvas.panel.isShow)
		{
			isPaint = false;
		}
		if (GameScr.M629() != null)
		{
			x = GameScr.M629().cx;
			y = GameScr.M629().cy;
			trans = 0;
			isCamera = true;
			type = (GameCanvas.isTouch ? 1 : 0);
		}
	}

	public static void M695(int index)
	{
		if (!GameCanvas.panel.isShow && PopUp.vPopups.M1113() - 1 >= index)
		{
			PopUp t = (PopUp)PopUp.vPopups.M1114(index);
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
			if (!GameCanvas.isTouch)
			{
				isPaint = false;
			}
		}
	}

	public static void M696()
	{
		type = 1;
		if (GameCanvas.panel.isShow)
		{
			isPaint = false;
		}
		bool flag = false;
		for (int i = 0; i < GameScr.vMob.M1113(); i++)
		{
			if (((Mob)GameScr.vMob.M1114(i)).isHintFocus)
			{
				flag = true;
				break;
			}
		}
		int num = 0;
		Mob t;
		while (true)
		{
			if (num >= GameScr.vMob.M1113())
			{
				return;
			}
			t = (Mob)GameScr.vMob.M1114(num);
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
		if (GameCanvas.panel.isShow)
		{
			isPaint = false;
		}
		for (int i = 0; i < GameScr.vItemMap.M1113(); i++)
		{
			ItemMap t = (ItemMap)GameScr.vItemMap.M1114(i);
			if (t.playerId == Char.M113().charID && t.template.id == 73)
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

	public static void M698(mGraphics g)
	{
		try
		{
			if (!isPaintArrow || (x > GameScr.cmx && x < GameScr.cmx + GameScr.gW && y > GameScr.cmy && y < GameScr.cmy + GameScr.gH) || GameCanvas.gameTick % 10 < 5 || ChatPopup.currChatPopup != null || ChatPopup.serverChatPopUp != null || GameCanvas.panel.isShow || !isCamera)
			{
				return;
			}
			int num = x - Char.M113().cx;
			int num2 = y - Char.M113().cy;
			int num3 = 0;
			int num4 = 0;
			int arg = 0;
			if (num > 0 && num2 >= 0)
			{
				if (Res.M1529(num) >= Res.M1529(num2))
				{
					num3 = GameScr.gW - 10;
					num4 = GameScr.gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						num4 = GameScr.gH / 2 + 10;
					}
					arg = 0;
				}
				else
				{
					num3 = GameScr.gW / 2;
					num4 = GameScr.gH - 10;
					arg = 5;
				}
			}
			else if (num >= 0 && num2 < 0)
			{
				if (Res.M1529(num) >= Res.M1529(num2))
				{
					num3 = GameScr.gW - 10;
					num4 = GameScr.gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						num4 = GameScr.gH / 2 + 10;
					}
					arg = 0;
				}
				else
				{
					num3 = GameScr.gW / 2;
					num4 = 10;
					arg = 6;
				}
			}
			if (num < 0 && num2 >= 0)
			{
				if (Res.M1529(num) >= Res.M1529(num2))
				{
					num3 = 10;
					num4 = GameScr.gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						num4 = GameScr.gH / 2 + 10;
					}
					arg = 3;
				}
				else
				{
					num3 = GameScr.gW / 2;
					num4 = GameScr.gH - 10;
					arg = 5;
				}
			}
			else if (num <= 0 && num2 < 0)
			{
				if (Res.M1529(num) >= Res.M1529(num2))
				{
					num3 = 10;
					num4 = GameScr.gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						num4 = GameScr.gH / 2 + 10;
					}
					arg = 3;
				}
				else
				{
					num3 = GameScr.gW / 2;
					num4 = 10;
					arg = 6;
				}
			}
			GameScr.M631(g);
			g.M940(GameScr.arrow, 0, 0, 13, 16, arg, num3, num4, StaticObj.VCENTER_HCENTER);
		}
		catch (Exception)
		{
		}
	}

	public static void M699(mGraphics g)
	{
		if (ChatPopup.serverChatPopUp != null || Char.M113().isUsePlane || Char.M113().isTeleport)
		{
			return;
		}
		M698(g);
		if (GameCanvas.menu.tDelay == 0 && isPaint && ChatPopup.scr == null && !Char.ischangingMap && GameCanvas.currentScreen == GameScr.M559() && (!GameCanvas.panel.isShow || GameCanvas.panel.cmx == 0))
		{
			if (isCamera)
			{
				g.M918(-GameScr.cmx, -GameScr.cmy);
			}
			if (trans == 0)
			{
				g.M948(Panel.imgBantay, x - 15, y, 0);
			}
			if (trans == 1)
			{
				g.M940(Panel.imgBantay, 0, 0, 14, 16, 2, x + 15, y, StaticObj.TOP_RIGHT);
			}
			if (paintFlare)
			{
				g.M948(ItemMap.imageFlare, x, y, 3);
			}
		}
	}

	public static void M700()
	{
		if (Char.M113().taskMaint != null && GameCanvas.currentScreen == GameScr.instance)
		{
			int taskId = Char.M113().taskMaint.taskId;
			int index = Char.M113().taskMaint.index;
			isCamera = false;
			trans = 0;
			type = 0;
			isPaint = true;
			isPaintArrow = true;
			if (GameCanvas.menu.showMenu && taskId > 0)
			{
				isPaint = false;
			}
			switch (taskId)
			{
			case 0:
				if (ChatPopup.currChatPopup == null && Char.M113().statusMe != 14)
				{
					if (index == 0 && TileMap.vGo.M1113() != 0)
					{
						x = ((Waypoint)TileMap.vGo.M1114(0)).minX - 100;
						y = ((Waypoint)TileMap.vGo.M1114(0)).minY + 40;
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
						if (!GameCanvas.panel.isShow)
						{
							M694();
						}
						else if (GameCanvas.panel.currentTabIndex == 0)
						{
							if (GameCanvas.panel.cp == null)
							{
								x = GameCanvas.panel.xScroll + GameCanvas.panel.wScroll / 2;
								y = GameCanvas.panel.yScroll + 20;
							}
							else if (GameCanvas.menu.tDelay != 0)
							{
								x = GameCanvas.panel.xScroll + 25;
								y = GameCanvas.panel.yScroll + 60;
							}
						}
						else if (GameCanvas.panel.currentTabIndex == 1)
						{
							x = GameCanvas.panel.startTabPos + 10;
							y = 65;
						}
					}
					if (index == 4)
					{
						if (GameCanvas.panel.isShow)
						{
							x = GameCanvas.panel.cmdClose.x + 5;
							y = GameCanvas.panel.cmdClose.y + 5;
						}
						else if (GameCanvas.menu.showMenu)
						{
							x = GameCanvas.w / 2;
							y = GameCanvas.h - 20;
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
					x = GameCanvas.w / 2;
					y = GameCanvas.h - 15;
				}
				return;
			case 1:
				if (ChatPopup.currChatPopup == null && Char.M113().statusMe != 14)
				{
					if (index == 0)
					{
						if (TileMap.M1936())
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
						if (!TileMap.M1936())
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
					x = GameCanvas.w / 2;
					y = GameCanvas.h - 15;
				}
				return;
			case 2:
				if (ChatPopup.currChatPopup == null && Char.M113().statusMe != 14)
				{
					if (index == 0)
					{
						if (!TileMap.M1936())
						{
							isViewMap = true;
						}
						if (!GameCanvas.panel.isShow)
						{
							if (!isViewMap)
							{
								x = GameScr.M559().cmdMenu.x;
								y = GameScr.M559().cmdMenu.y + 13;
								trans = 1;
							}
							else
							{
								if (GameScr.M659() == TileMap.mapID)
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
							if (GameCanvas.panel.currentTabIndex == 0)
							{
								int num = ((GameCanvas.h <= 300) ? 10 : 15);
								x = GameCanvas.panel.xScroll + GameCanvas.panel.wScroll / 2;
								y = GameCanvas.panel.yScroll + GameCanvas.panel.hScroll - num;
							}
							else
							{
								x = GameCanvas.panel.startTabPos + 10;
								y = 65;
							}
						}
						else if (!isCloseMap)
						{
							x = GameCanvas.panel.cmdClose.x + 5;
							y = GameCanvas.panel.cmdClose.y + 5;
						}
						else
						{
							isPaint = false;
						}
						if (Char.M113().cMP <= 0)
						{
							x = GameScr.xHP + 5;
							y = GameScr.yHP + 13;
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
					x = GameCanvas.w / 2;
					y = GameCanvas.h - 15;
				}
				return;
			}
			if (Char.M113().taskMaint.taskId == 9 && Char.M113().taskMaint.index == 2)
			{
				for (int i = 0; i < PopUp.vPopups.M1113(); i++)
				{
					PopUp t = (PopUp)PopUp.vPopups.M1114(i);
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
			if (GameCanvas.isTouch)
			{
				GameScr.M643(mResources.press_twice, x, y + 10, 0, 20, mFont.MISS_ME);
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
