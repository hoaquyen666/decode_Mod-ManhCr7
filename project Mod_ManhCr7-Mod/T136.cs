using System;
using UnityEngine;

public class T136 : T108
{
	public const sbyte SUBCMD_ALL = 0;

	public const sbyte SUBCMD_USE = 1;

	public const sbyte SUBCMD_LEVEL = 2;

	public const sbyte SUBCMD_AMOUNT = 3;

	public const sbyte SUBCMD_AURA = 4;

	public static T136 instance;

	public static bool TYPE_UI;

	public static T49 fraImgFocus;

	public static T49 fraImgFocusNone;

	public static T49 fraEff;

	private static T60 imgUI;

	private static T60 imgUIText;

	private static T60 imgArrow_Left;

	private static T60 imgArrow_Right;

	private static T60 imgArrow_Down;

	private static T60 imgLock;

	private static T60 imgUse_0;

	private static T60 imgUse;

	private static T60 imgBack;

	private static T60 imgChange;

	private static T60 imgBar_0;

	private static T60 imgBar_1;

	private static T60 imgPro_0;

	private static T60 imgPro_1;

	private static T60[] imgRank;

	public static int xUi;

	public static int yUi;

	public static int wUi;

	public static int hUi;

	public static int xMon;

	public static int yMon;

	public static int xText;

	public static int yText;

	public static int wText;

	public static int cmyText;

	public static int hText;

	public static int yCmd;

	public static int[] xCmd = new int[0];

	public static int[] dxCmd = new int[0];

	private static int[][] xyArrow;

	private static int[][] xyItem;

	private static int[] index = new int[5] { -2, -1, 0, 1, 2 };

	private int dyArrow;

	private int[] dxArrow;

	private int page;

	private int maxpage;

	private int indexFocus;

	public static T117 list;

	public static T117 listUse;

	private static int num;

	private static int numMax;

	private T70 focus_card;

	private int pxx;

	private int pyy;

	private int xClip;

	private int wClip;

	private int yClip;

	private int hClip;

	public T136()
	{
		TYPE_UI = true;
		T60 img = T110.M1071("/radar/17.png");
		T60 img2 = T110.M1071("/radar/3.png");
		T60 img3 = T110.M1071("/radar/23.png");
		fraImgFocus = new T49(img, 28, 28);
		fraImgFocusNone = new T49(img2, 30, 30);
		fraEff = new T49(img3, 11, 11);
		imgUI = T110.M1071("/radar/0.png");
		imgArrow_Left = T110.M1071("/radar/1.png");
		imgArrow_Right = T110.M1071("/radar/2.png");
		imgUIText = T110.M1071("/radar/17.png");
		imgArrow_Down = T110.M1071("/radar/4.png");
		imgLock = T110.M1071("/radar/5.png");
		imgUse_0 = T110.M1071("/radar/6.png");
		imgRank = new T60[7];
		for (int i = 0; i < 7; i++)
		{
			imgRank[i] = T110.M1071("/radar/" + (i + 7) + ".png");
		}
		imgUse = T110.M1071("/radar/14.png");
		imgBack = T110.M1071("/radar/15.png");
		imgChange = T110.M1071("/radar/16.png");
		imgUIText = T110.M1071("/radar/18.png");
		imgBar_1 = T110.M1071("/radar/19.png");
		imgPro_0 = T110.M1071("/radar/20.png");
		imgPro_1 = T110.M1071("/radar/21.png");
		imgBar_0 = T110.M1071("/radar/22.png");
		wUi = 200;
		hUi = 219;
		xUi = T51.hw - (wUi + 40) / 2;
		yUi = T51.hh - hUi / 2;
		xText = xUi + wUi - 81;
		yText = yUi + 29;
		wText = 120;
		hText = 80;
		xyArrow = new int[3][]
		{
			new int[2]
			{
				xUi + 34,
				yUi + hUi - 42
			},
			new int[2]
			{
				xUi + wUi / 2 - imgArrow_Down.M727() / 2,
				yUi + hUi / 2 + 33
			},
			new int[2]
			{
				xUi + wUi - 41,
				yUi + hUi - 42
			}
		};
		xyItem = new int[5][]
		{
			new int[2]
			{
				xUi + 25,
				yUi + hUi - 82
			},
			new int[2]
			{
				xUi + 57,
				yUi + hUi - 62
			},
			new int[2]
			{
				xUi + wUi / 2 - 14,
				yUi + hUi - 102
			},
			new int[2]
			{
				xUi + wUi - 57 - 28,
				yUi + hUi - 62
			},
			new int[2]
			{
				xUi + wUi - 25 - 28,
				yUi + hUi - 82
			}
		};
		dxArrow = new int[2];
		dyArrow = 0;
		xMon = xUi + 73;
		yMon = yUi + hUi / 2 + 5;
		yCmd = yUi + hUi - 22;
		xCmd = new int[3]
		{
			xUi + wUi / 2 - 8 - 80,
			xUi + wUi / 2 - 8,
			xUi + wUi / 2 - 8 + 80
		};
		dxCmd = new int[3];
		yClip = yText + 10 + 70;
		hClip = 0;
		list = new T117();
		listUse = new T117();
		page = 1;
		maxpage = 2;
	}

	public static T136 M1494()
	{
		if (instance == null)
		{
			instance = new T136();
		}
		return instance;
	}

	public void M1495(T117 list, int num, int numMax)
	{
		T136.list = list;
		M1496(num, numMax);
		page = 1;
		indexFocus = 2;
		M1498();
		TYPE_UI = true;
		M1497();
		if (TYPE_UI)
		{
			maxpage = list.M1113() / 5 + ((list.M1113() % 5 > 0) ? 1 : 0);
		}
		else
		{
			maxpage = listUse.M1113() / 5 + ((listUse.M1113() % 5 > 0) ? 1 : 0);
		}
	}

	public static void M1496(int num, int numMax)
	{
		T136.num = num;
		T136.numMax = numMax;
	}

	public static void M1497()
	{
		listUse = new T117(string.Empty);
		for (int i = 0; i < list.M1113(); i++)
		{
			T70 t = (T70)list.M1114(i);
			if (t != null && t.isUse == 1)
			{
				listUse.M1111(t);
			}
		}
	}

	public void M1498()
	{
		T117 t = listUse;
		if (TYPE_UI)
		{
			t = list;
		}
		int num = (page - 1) * 5;
		int num2 = num + 5;
		for (int i = num; i < num2; i++)
		{
			if (i >= t.M1113())
			{
				index[i - num] = -1;
				continue;
			}
			T70 t2 = (T70)t.M1114(i);
			if (t2 != null)
			{
				index[i - num] = t2.id;
			}
		}
		cmyText = 0;
		hText = 0;
		T160.M1826().M1877();
	}

	public override void update()
	{
		try
		{
			if (hText < 80)
			{
				hText += 4;
				if (hText > 80)
				{
					hText = 80;
				}
			}
			focus_card = T70.M771(listUse, index[indexFocus]);
			if (TYPE_UI)
			{
				focus_card = T70.M771(list, index[indexFocus]);
			}
			T54.M559().update();
			if (T51.gameTick % 10 < 6)
			{
				if (T51.gameTick % 2 == 0)
				{
					dyArrow--;
				}
			}
			else
			{
				dyArrow = 0;
			}
			if (focus_card != null)
			{
				hClip = focus_card.amount * 100 / focus_card.max_amount * imgBar_1.M728() / 100;
				wClip = num * 100 / list.M1113() * imgPro_1.M727() / 100;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("-upd-radaScr-null: " + ex.ToString());
		}
	}

	public override void updateKey()
	{
		if (!T66.isLock)
		{
			if (T51.isTouch && !T15.M279().isShow && !T51.menu.showMenu)
			{
				M1500();
			}
			if (T51.keyPressed[(!Main.isPC) ? 8 : 22])
			{
				T51.keyPressed[(!Main.isPC) ? 8 : 22] = false;
				M1504(1);
			}
			if (T51.keyPressed[(!Main.isPC) ? 2 : 21])
			{
				T51.keyPressed[(!Main.isPC) ? 2 : 21] = false;
				M1504(-1);
			}
			if (T51.keyPressed[(!Main.isPC) ? 4 : 23])
			{
				T51.keyPressed[(!Main.isPC) ? 4 : 23] = false;
				M1505(1);
			}
			if (T51.keyPressed[(!Main.isPC) ? 6 : 24])
			{
				T51.keyPressed[(!Main.isPC) ? 6 : 24] = false;
				M1505(0);
			}
			if (T51.keyPressed[(!Main.isPC) ? 5 : 25])
			{
				T51.keyPressed[(!Main.isPC) ? 5 : 25] = false;
				M1501(1);
			}
			if (T51.keyPressed[13])
			{
				M1501(2);
			}
			if (T51.keyPressed[12])
			{
				T51.keyPressed[12] = false;
				M1501(0);
			}
			T51.M483();
		}
	}

	private void M1499()
	{
		TYPE_UI = !TYPE_UI;
		page = 1;
		indexFocus = 0;
		if (TYPE_UI)
		{
			maxpage = list.M1113() / 5 + ((list.M1113() % 5 > 0) ? 1 : 0);
		}
		else
		{
			maxpage = listUse.M1113() / 5 + ((listUse.M1113() % 5 > 0) ? 1 : 0);
		}
		M1498();
	}

	private void M1500()
	{
		if (T51.isPointerClick)
		{
			for (int i = 0; i < 5; i++)
			{
				if (T51.M481(xyItem[i][0], xyItem[i][1], 30, 30) && T51.isPointerClick && T51.isPointerJustRelease && i != indexFocus)
				{
					M1503(i);
				}
			}
			if (T51.M481(xyArrow[0][0] - 5, xyArrow[0][1] - 5, 20, 20))
			{
				if (T51.isPointerDown)
				{
					dxArrow[0] = 1;
				}
				if (T51.isPointerClick && T51.isPointerJustRelease)
				{
					M1502(0);
					dxArrow[0] = 0;
				}
			}
			if (T51.M481(xyArrow[2][0] - 5, xyArrow[2][1] - 5, 20, 20))
			{
				if (T51.isPointerDown)
				{
					dxArrow[1] = 1;
				}
				if (T51.isPointerClick && T51.isPointerJustRelease)
				{
					M1502(1);
					dxArrow[1] = 0;
				}
			}
			for (int j = 0; j < xCmd.Length; j++)
			{
				if (T51.M481(xCmd[j] - 5, yCmd - 5, 20, 20))
				{
					if (T51.isPointerDown)
					{
						dxCmd[j] = 1;
					}
					if (T51.isPointerClick && T51.isPointerJustRelease)
					{
						M1501(j);
						dxCmd[j] = 0;
					}
				}
			}
		}
		else
		{
			dxCmd[0] = 0;
			dxCmd[1] = 0;
			dxCmd[2] = 0;
			dxArrow[0] = 0;
			dxArrow[1] = 0;
		}
		if (!T51.M481(xText, 0, wText, yText + hText))
		{
			return;
		}
		if (T51.isPointerMove)
		{
			if (pyy == 0)
			{
				pyy = T51.py;
			}
			pxx = pyy - T51.py;
			if (pxx != 0)
			{
				cmyText += pxx;
				pyy = T51.py;
			}
			if (cmyText < 0)
			{
				cmyText = 0;
			}
			if (cmyText > focus_card.cp.lim)
			{
				cmyText = focus_card.cp.lim;
			}
		}
		else
		{
			pyy = 0;
			pyy = 0;
		}
	}

	private void M1501(int i)
	{
		switch (i)
		{
		case 0:
			M1499();
			break;
		case 1:
			if (focus_card != null)
			{
				T146.M1594().M1741(1, focus_card.id);
			}
			break;
		case 2:
			T54.M559().switchToMe();
			break;
		}
		T160.M1826().M1876();
	}

	private void M1502(int dir)
	{
		if (TYPE_UI)
		{
			maxpage = list.M1113() / 5 + ((list.M1113() % 5 > 0) ? 1 : 0);
		}
		else
		{
			maxpage = listUse.M1113() / 5 + ((listUse.M1113() % 5 > 0) ? 1 : 0);
		}
		int num = page;
		if (dir == 0)
		{
			if (page == 1)
			{
				return;
			}
			num--;
			if (num < 1)
			{
				num = 1;
			}
		}
		else
		{
			if (page == maxpage)
			{
				return;
			}
			num++;
			if (num > maxpage)
			{
				num = maxpage;
			}
		}
		if (num != page)
		{
			page = num;
			M1498();
		}
	}

	private void M1503(int focus)
	{
		indexFocus = focus;
		M1498();
	}

	private void M1504(int type)
	{
		cmyText += 12 * type;
		if (cmyText < 0)
		{
			cmyText = 0;
		}
		if (cmyText > focus_card.cp.lim)
		{
			cmyText = focus_card.cp.lim;
		}
	}

	private void M1505(int type)
	{
		int num = indexFocus;
		int num2 = page;
		num = ((type != 0) ? (num - 1) : (num + 1));
		if (num >= index.Length)
		{
			if (page < maxpage)
			{
				num = 0;
				num2++;
			}
			else
			{
				num = index.Length - 1;
			}
		}
		if (num < 0)
		{
			if (page > 1)
			{
				num = index.Length - 1;
				num2--;
			}
			else
			{
				num = 0;
			}
		}
		if (num != indexFocus)
		{
			indexFocus = num;
			cmyText = 0;
			hText = 0;
		}
		if (num2 != page)
		{
			page = num2;
			M1498();
		}
	}

	public override void paint(T99 g)
	{
		try
		{
			T54.M559().paint(g);
			g.M918(-T54.cmx, -T54.cmy);
			g.M918(0, T51.transY);
			T54.M631(g);
			g.M948(imgUI, xUi, yUi, 0);
			g.M948(imgPro_0, xUi + wUi / 2 - imgPro_0.M727() / 2, yUi - imgPro_0.M728() / 2 - 2, 0);
			g.M922(xUi + wUi / 2 - imgPro_0.M727() / 2 + 13, yUi - imgPro_0.M728() / 2 + 3, wClip, imgPro_0.M728());
			g.M948(imgPro_1, xUi + wUi / 2 - imgPro_0.M727() / 2 + 13, yUi - imgPro_0.M728() / 2 + 3, 0);
			T54.M631(g);
			g.M948(imgChange, xCmd[0], yCmd + dxCmd[0], 0);
			g.M948(imgUse_0, xCmd[1], yCmd + dxCmd[1], 0);
			g.M948(imgBack, xCmd[2], yCmd + dxCmd[2], 0);
			if (TYPE_UI)
			{
				g.M940(imgUse, 0, 0, 17, 17, 0, xCmd[1], yCmd + dxCmd[1], 0);
			}
			else
			{
				g.M940(imgUse, 0, 0, 17, 17, 1, xCmd[1], yCmd + dxCmd[1], 0);
			}
			if (focus_card != null)
			{
				g.M922(xUi + 30, yUi + 13, wUi - 60, hUi / 2);
				focus_card.M772(g, xMon, yMon);
				T54.M631(g);
				T98.tahoma_7b_yellow.M898(g, ((focus_card.level <= 0) ? " " : ("Lv." + focus_card.level + " ")) + focus_card.name, xUi + wUi / 2, yUi + 15, 2);
				T98.tahoma_7_white.M898(g, "no." + focus_card.no, xUi + 30, yText - 2, 0);
				g.M948(imgBar_0, xUi + 36, yText + 10, 0);
				g.M922(xUi + 36, yClip - hClip, 7, hClip);
				g.M948(imgBar_1, xUi + 36, yText + 10, 0);
				T54.M631(g);
				g.M948(imgRank[focus_card.rank], xUi + 39 - 5 + 14, yText + 12, 0);
			}
			g.M922(xText, yText, wText + 5, hText + 8);
			if (focus_card != null)
			{
				g.M948(imgUIText, xText, yText, 0);
			}
			T54.M631(g);
			g.M922(xText, yText + 1, wText, hText + 5);
			if (focus_card != null && focus_card.cp != null)
			{
				if (focus_card.cp.says == null)
				{
					return;
				}
				focus_card.cp.M272(g, cmyText);
			}
			T54.M631(g);
			if ((!TYPE_UI && listUse.M1113() > 5) || TYPE_UI)
			{
				if (page > 1)
				{
					g.M948(imgArrow_Left, xyArrow[0][0], xyArrow[0][1] + dxArrow[0], 0);
				}
				if (page < maxpage)
				{
					g.M948(imgArrow_Right, xyArrow[2][0], xyArrow[2][1] + dxArrow[1], 0);
				}
			}
			for (int i = 0; i < index.Length; i++)
			{
				int num = 0;
				int num2 = 0;
				int idx = 0;
				if (i == indexFocus)
				{
					num = dyArrow;
					num2 = -10;
					idx = 1;
					g.M948(imgArrow_Down, xyItem[i][0] + 10, xyItem[i][1] + dyArrow + 29 + -10, 0);
				}
				T70 t = T70.M771(listUse, index[i]);
				if (TYPE_UI)
				{
					t = T70.M771(list, index[i]);
				}
				if (t != null)
				{
					fraImgFocus.M439(t.rank, xyItem[i][0], xyItem[i][1] + num + num2, 0, 0, g);
					T157.M1785(g, t.idIcon, xyItem[i][0] + 14, xyItem[i][1] + 14 + num + num2, 0, T163.VCENTER_HCENTER);
					t.M776(g, xyItem[i][0], xyItem[i][1] + num + num2);
					if (t.level == 0)
					{
						g.M948(imgLock, xyItem[i][0], xyItem[i][1] + num + num2, 0);
					}
					if (i == indexFocus)
					{
						fraImgFocus.M439(7, xyItem[i][0], xyItem[i][1] + num + num2, 0, 0, g);
					}
					if (t.isUse == 1)
					{
						fraImgFocus.M439(8, xyItem[i][0], xyItem[i][1] + num + num2, 0, 0, g);
					}
				}
				else
				{
					fraImgFocusNone.M439(idx, xyItem[i][0] - 1, xyItem[i][1] - 1 + num + num2, 0, 0, g);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError("-pnt-radaScr-null: " + ex.ToString());
		}
	}

	public override void switchToMe()
	{
		T54.isPaintOther = true;
		base.switchToMe();
	}
}
