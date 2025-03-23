using System;
using N3.N4;
using N5.N6.N7;
using UnityEngine;

public class T51 : T57
{
	public static long timeNow;

	public static bool open3Hour;

	public static bool lowGraphic;

	public static bool isMoveNumberPad;

	public static bool isLoading;

	public static bool isTouch;

	public static bool isTouchControl;

	public static bool isTouchControlSmallScreen;

	public static bool isTouchControlLargeScreen;

	public static bool isConnectFail;

	public static T51 instance;

	public static bool bRun;

	public static bool[] keyPressed;

	public static bool[] keyReleased;

	public static bool[] keyHold;

	public static bool isPointerDown;

	public static bool isPointerClick;

	public static bool isPointerJustRelease;

	public static bool isPointerMove;

	public static int px;

	public static int py;

	public static int pxFirst;

	public static int pyFirst;

	public static int pxLast;

	public static int pyLast;

	public static int pxMouse;

	public static int pyMouse;

	public static T135[] arrPos;

	public static int gameTick;

	public static int taskTick;

	public static bool isEff1;

	public static bool isEff2;

	public static long timeTickEff1;

	public static long timeTickEff2;

	public static int w;

	public static int h;

	public static int hw;

	public static int hh;

	public static int wd3;

	public static int hd3;

	public static int w2d3;

	public static int h2d3;

	public static int w3d4;

	public static int h3d4;

	public static int wd6;

	public static int hd6;

	public static T108 currentScreen;

	public static T96 menu;

	public static T126 panel;

	public static T126 panel2;

	public static T90 loginScr;

	public static T208 registerScr;

	public static T30 currentDialog;

	public static T109 msgdlg;

	public static T71 inputDlg;

	public static T117 currentPopup;

	public static int requestLoseCount;

	public static T117 listPoint;

	public static T125 paintz;

	public static bool isGetResFromServer;

	public static T60[] imgBG;

	public static int skyColor;

	public static int curPos;

	public static int[] bgW;

	public static int[] bgH;

	public static int planet;

	private T99 g = new T99();

	public static T60 img12;

	public static T60[] imgBlue;

	public static T60[] imgViolet;

	public static bool isPlaySound;

	private static int clearOldData;

	public static int timeOpenKeyBoard;

	public static bool isFocusPanel2;

	public bool isPaintCarret;

	public static T117 debugUpdate;

	public static T117 debugPaint;

	public static T117 debugSession;

	private static bool isShowErrorForm;

	public static bool paintBG;

	public static int gsskyHeight;

	public static int gsgreenField1Y;

	public static int gsgreenField2Y;

	public static int gshouseY;

	public static int gsmountainY;

	public static int bgLayer0y;

	public static int bgLayer1y;

	public static T60 imgCloud;

	public static T60 imgSun;

	public static T60 imgSun2;

	public static T60 imgClear;

	public static T60[] imgBorder;

	public static T60[] imgSunSpec;

	public static int borderConnerW;

	public static int borderConnerH;

	public static int borderCenterW;

	public static int borderCenterH;

	public static int[] cloudX;

	public static int[] cloudY;

	public static int sunX;

	public static int sunY;

	public static int sunX2;

	public static int sunY2;

	public static int[] layerSpeed;

	public static int[] moveX;

	public static int[] moveXSpeed;

	public static bool isBoltEff;

	public static bool boltActive;

	public static int tBolt;

	public static int typeBg;

	public static int transY;

	public static int[] yb;

	public static int[] colorTop;

	public static int[] colorBotton;

	public static int yb1;

	public static int yb2;

	public static int yb3;

	public static int nBg;

	public static int lastBg;

	public static int[] bgRain;

	public static int[] bgRainFont;

	public static T60 imgCaycot;

	public static T60 tam;

	public static int typeBackGround;

	public static int saveIDBg;

	public static bool isLoadBGok;

	private static long lastTimePress;

	public static int keyAsciiPress;

	public static int pXYScrollMouse;

	private static T60 imgSignal;

	public static T117 flyTexts;

	public int longTime;

	public static bool isPointerJustDown;

	private int count = 1;

	public static bool csWait;

	public static T114 r;

	public static bool isBlackScreen;

	public static int[] bgSpeed;

	public static int cmdBarX;

	public static int cmdBarY;

	public static int cmdBarW;

	public static int cmdBarH;

	public static int cmdBarLeftW;

	public static int cmdBarRightW;

	public static int cmdBarCenterW;

	public static int hpBarX;

	public static int hpBarY;

	public static int hpBarW;

	public static int expBarW;

	public static int lvPosX;

	public static int moneyPosX;

	public static int hpBarH;

	public static int girlHPBarY;

	public int timeOut;

	public int[] dustX;

	public int[] dustY;

	public int[] dustState;

	public static int[] wsX;

	public static int[] wsY;

	public static int[] wsState;

	public static int[] wsF;

	public static T60[] imgWS;

	public static T60 imgShuriken;

	public static T60[][] imgDust;

	public static bool isResume;

	public static T144 serverScreen;

	public static T145 serverScr;

	public bool resetToLoginScr;

	public T51()
	{
		switch (T138.M1542("languageVersion"))
		{
		default:
			Main.main.doClearRMS();
			T138.M1543("languageVersion", 2);
			break;
		case -1:
			T138.M1543("languageVersion", 2);
			break;
		case 2:
			break;
		}
		clearOldData = T138.M1542(T52.VERSION);
		if (clearOldData != 1)
		{
			Main.main.doClearRMS();
			T138.M1543(T52.VERSION, 1);
		}
		M441();
	}

	static T51()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		timeNow = 0L;
		lowGraphic = false;
		isMoveNumberPad = true;
		isTouch = false;
		keyPressed = new bool[30];
		keyReleased = new bool[30];
		keyHold = new bool[30];
		arrPos = new T135[4];
		menu = new T96();
		currentPopup = new T117();
		curPos = 0;
		planet = 0;
		imgBlue = new T60[7];
		imgViolet = new T60[7];
		isPlaySound = true;
		isShowErrorForm = false;
		imgBorder = new T60[3];
		imgSunSpec = new T60[3];
		typeBg = -1;
		yb = new int[5];
		nBg = 0;
		lastBg = -1;
		bgRain = new int[3] { 1, 4, 11 };
		bgRainFont = new int[1] { -1 };
		typeBackGround = -1;
		saveIDBg = -10;
		lastTimePress = 0L;
		flyTexts = new T117();
		isPointerJustDown = false;
		r = new T114();
	}

	public static string M440()
	{
		return "Pc platform xxx";
	}

	public void M441()
	{
		T106.instance.M1024(this);
		w = T106.instance.M1031();
		h = T106.instance.M1032();
		hw = w / 2;
		hh = h / 2;
		isTouch = true;
		if (w >= 240)
		{
			isTouchControl = true;
		}
		if (w < 320)
		{
			isTouchControlSmallScreen = true;
		}
		if (w >= 320)
		{
			isTouchControlLargeScreen = true;
		}
		msgdlg = new T109();
		if (h <= 160)
		{
			T125.hTab = 15;
			T108.cmdH = 17;
		}
		T54.d = ((w <= h) ? h : w) + 20;
		instance = this;
		T98.M891();
		T108.ITEM_HEIGHT = T98.tahoma_8b.M912() + 8;
		M443();
		M513();
		M507();
		panel = new T126();
		imgShuriken = M503("/mainImage/myTexture2df.png");
		int num = T138.M1542("clienttype");
		if (num != -1)
		{
			if (num > 7)
			{
				T138.M1543("clienttype", T110.clientType);
			}
			else
			{
				T110.clientType = num;
			}
		}
		if (T110.clientType == 7 && (T138.M1536("fake") == null || T138.M1536("fake") == string.Empty))
		{
			imgShuriken = M503("/mainImage/wait.png");
		}
		imgClear = M503("/mainImage/myTexture2der.png");
		img12 = M503("/mainImage/12+.png");
		debugUpdate = new T117();
		debugPaint = new T117();
		debugSession = new T117();
		for (int i = 0; i < 3; i++)
		{
			imgBorder[i] = M503("/mainImage/myTexture2dbd" + i + ".png");
		}
		borderConnerW = T99.M958(imgBorder[0]);
		borderConnerH = T99.M959(imgBorder[0]);
		borderCenterW = T99.M958(imgBorder[1]);
		borderCenterH = T99.M959(imgBorder[1]);
		T126.graphics = T138.M1542("lowGraphic");
		lowGraphic = T138.M1542("lowGraphic") == 1;
		T54.isPaintChatVip = T138.M1542("serverchat") != 1;
		T13.isPaintAura = T138.M1542("isPaintAura") == 1;
		T137.M1506();
		T157.M1779();
		T126.WIDTH_PANEL = 176;
		if (T126.WIDTH_PANEL > w)
		{
			T126.WIDTH_PANEL = w;
		}
		T68.M754().M755();
		T22.btn0left = M503("/mainImage/btn0left.png");
		T22.btn0mid = M503("/mainImage/btn0mid.png");
		T22.btn0right = M503("/mainImage/btn0right.png");
		T22.btn1left = M503("/mainImage/btn1left.png");
		T22.btn1mid = M503("/mainImage/btn1mid.png");
		T22.btn1right = M503("/mainImage/btn1right.png");
		serverScreen = new T144();
		img12 = M503("/mainImage/12+.png");
		for (int j = 0; j < 7; j++)
		{
			imgBlue[j] = M503("/effectdata/blue/" + j + ".png");
			imgViolet[j] = M503("/effectdata/violet/" + j + ".png");
		}
		T144.M1578();
		serverScr = new T145();
	}

	public static T51 M442()
	{
		return instance;
	}

	public void M443()
	{
		paintz = new T125();
	}

	public static void M444()
	{
		T99.addYWhenOpenKeyBoard = 0;
		timeOpenKeyBoard = 0;
		Main.closeKeyBoard();
	}

	public void M445()
	{
		if (gameTick % 5 == 0)
		{
			timeNow = T110.M1054();
		}
		T137.M1517();
		try
		{
			if (T177.visible)
			{
				timeOpenKeyBoard++;
				if (timeOpenKeyBoard > ((!Main.isWindowsPhone) ? 10 : 5))
				{
					T99.addYWhenOpenKeyBoard = 94;
				}
			}
			else
			{
				T99.addYWhenOpenKeyBoard = 0;
				timeOpenKeyBoard = 0;
			}
			debugUpdate.M1120();
			long num = T110.M1054();
			if (num - timeTickEff1 >= 780L && !isEff1)
			{
				timeTickEff1 = num;
				isEff1 = true;
			}
			else
			{
				isEff1 = false;
			}
			if (num - timeTickEff2 >= 7800L && !isEff2)
			{
				timeTickEff2 = num;
				isEff2 = true;
			}
			else
			{
				isEff2 = false;
			}
			if (taskTick > 0)
			{
				taskTick--;
			}
			gameTick++;
			if (gameTick > 10000)
			{
				if (T110.M1054() - lastTimePress > 20000L && currentScreen == loginScr)
				{
					T52.instance.M520();
				}
				gameTick = 0;
			}
			if (currentScreen != null)
			{
				if (T14.serverChatPopUp != null)
				{
					T14.serverChatPopUp.update();
					T14.serverChatPopUp.M274();
				}
				else if (T14.currChatPopup != null)
				{
					T14.currChatPopup.update();
					T14.currChatPopup.M274();
				}
				else if (currentDialog != null)
				{
					M456("B", 0);
					currentDialog.update();
				}
				else if (menu.showMenu)
				{
					M456("C", 0);
					menu.M884();
					M456("D", 0);
					menu.M879();
				}
				else if (panel.isShow)
				{
					panel.M1383();
					if (M516(panel.X, panel.Y, panel.W, panel.H))
					{
						isFocusPanel2 = false;
					}
					if (panel2 != null && panel2.isShow)
					{
						panel2.M1383();
						if (M516(panel2.X, panel2.Y, panel2.W, panel2.H))
						{
							isFocusPanel2 = true;
						}
					}
					if (panel2 != null)
					{
						if (isFocusPanel2)
						{
							panel2.M1287();
						}
						else
						{
							panel.M1287();
						}
					}
					else
					{
						panel.M1287();
					}
					if (panel.chatTField != null && panel.chatTField.isShow)
					{
						panel.M1286();
					}
					else if (panel2 != null && panel2.chatTField != null && panel2.chatTField.isShow)
					{
						panel2.M1286();
					}
					else if ((M516(panel.X, panel.Y, panel.W, panel.H) && panel2 != null) || panel2 == null)
					{
						panel.M1287();
					}
					else if (panel2 != null && panel2.isShow && M516(panel2.X, panel2.Y, panel2.W, panel2.H))
					{
						panel2.M1287();
					}
					if (M516(panel.X + panel.W, panel.Y, w - panel.W * 2, panel.H) && isPointerJustRelease && panel.isDoneCombine)
					{
						panel.M1382();
					}
				}
				M456("E", 0);
				if (!isLoading)
				{
					currentScreen.update();
				}
				M456("F", 0);
				if (!panel.isShow && T14.serverChatPopUp == null)
				{
					currentScreen.updateKey();
				}
				T55.M701();
				T160.M1826().M1840();
			}
			M456("Ix", 0);
			T175.M1966();
			M456("Hx", 0);
			T66.M752();
			M456("G", 0);
			if (resetToLoginScr)
			{
				resetToLoginScr = false;
				M457(serverScreen);
			}
			M456("Zzz", 0);
			if (T23.isConnectOK)
			{
				if (T23.isMain)
				{
					T52.IP = T144.address[T144.ipSelect];
					T52.PORT = T144.port[T144.ipSelect];
					T24.M326("Connect ok");
					T144.testConnect = 2;
					T138.M1543("svselect", T144.ipSelect);
					T138.M1553(T52.IP + ":" + T52.PORT);
					T146.M1594().M1630();
					T146.M1594().M1596();
				}
				else
				{
					T146.M1594().M1631();
					T146.M1594().M1598();
				}
				T23.isConnectOK = false;
			}
			if (T23.isDisconnected)
			{
				Debug.Log("disconnect");
				if (!T23.isMain)
				{
					if (currentScreen == serverScreen && !T146.reciveFromMainSession)
					{
						serverScreen.M1590();
					}
					if (currentScreen == loginScr && !T146.reciveFromMainSession)
					{
						M446();
					}
				}
				else
				{
					M446();
				}
				T23.isDisconnected = false;
			}
			if (T23.isConnectionFail)
			{
				Debug.Log("connect fail");
				if (!T23.isMain)
				{
					if (currentScreen == serverScreen && T144.isGetData && !T146.reciveFromMainSession)
					{
						serverScreen.M1590();
					}
					if (currentScreen == loginScr && !T146.reciveFromMainSession)
					{
						M447();
					}
				}
				else
				{
					M447();
				}
				T23.isConnectionFail = false;
			}
			if (Main.isResume)
			{
				Main.isResume = false;
				if (currentDialog != null && currentDialog.left != null && currentDialog.left.actionListener != null)
				{
					currentDialog.left.M294();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void M446()
	{
		if (T23.isConnectionFail)
		{
			T23.isConnectionFail = false;
		}
		isResume = true;
		T147.M1744().M1743();
		T148.M1757().M1756();
		if (T23.isLoadingData)
		{
			instance.M515();
			M494(mResources.pls_restart_game_error, 8885, null);
			T23.isDisconnected = false;
			return;
		}
		T13.isLoadingMap = false;
		if (T23.isMain)
		{
			T144.testConnect = 0;
		}
		instance.M515();
		if (Main.typeClient == 6)
		{
			if (currentScreen != serverScreen && currentScreen != loginScr)
			{
				M489(mResources.maychutathoacmatsong);
			}
		}
		else
		{
			M489(mResources.maychutathoacmatsong);
		}
		T110.M1069();
	}

	public void M447()
	{
		if (currentScreen.Equals(T161.instance))
		{
			if (T144.hasConnected == null)
			{
				M494(mResources.pls_restart_game_error, 8885, null);
			}
			else if (!T144.hasConnected[0])
			{
				T144.hasConnected[0] = true;
				T144.ipSelect = 0;
				T52.IP = T144.address[T144.ipSelect];
				T138.M1543("svselect", T144.ipSelect);
				M449();
			}
			else if (!T144.hasConnected[2])
			{
				T144.hasConnected[2] = true;
				T144.ipSelect = 2;
				T52.IP = T144.address[T144.ipSelect];
				T138.M1543("svselect", T144.ipSelect);
				M449();
			}
			else
			{
				M494(mResources.pls_restart_game_error, 8885, null);
			}
			return;
		}
		T147.M1744().M1743();
		T148.M1757().M1756();
		T144.isWait = false;
		if (T23.isLoadingData)
		{
			M494(mResources.pls_restart_game_error, 8885, null);
			T23.isConnectionFail = false;
			return;
		}
		isResume = true;
		T90.isContinueToLogin = false;
		if (loginScr != null)
		{
			instance.M515();
		}
		else
		{
			loginScr = new T90();
		}
		T90.serverName = T144.nameServer[T144.ipSelect];
		if (currentScreen != serverScreen)
		{
			M494(mResources.lost_connection + T90.serverName, 888395, null);
		}
		else
		{
			M488();
		}
		T13.isLoadingMap = false;
		if (T23.isMain)
		{
			T144.testConnect = 0;
		}
		T110.M1069();
	}

	public static bool M448()
	{
		if (!T66.isShow && (msgdlg == null || !msgdlg.info.Equals(mResources.PLEASEWAIT)) && !T13.isLoadingMap)
		{
			return T90.isContinueToLogin;
		}
		return true;
	}

	public static void M449()
	{
		if (!T147.M1744().isConnected())
		{
			T147.M1744().connect(T52.IP, T52.PORT);
		}
	}

	public static void M450()
	{
		if (!T148.M1757().isConnected())
		{
			T137.M1513("IP2= " + T52.IP2 + " PORT 2= " + T52.PORT2);
			T148.M1757().connect(T52.IP2, T52.PORT2);
		}
	}

	public static void M451(T99 g)
	{
		g.M918(-g.M920(), -g.M921());
		g.M922(0, 0, w, h);
	}

	public void M452()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M456("SP2i1", 0);
		w = T106.instance.M1031();
		h = T106.instance.M1032();
		M456("SP2i2", 0);
		hw = w / 2;
		hh = h / 2;
		wd3 = w / 3;
		hd3 = h / 3;
		w2d3 = 2 * w / 3;
		h2d3 = 2 * h / 3;
		w3d4 = 3 * w / 4;
		h3d4 = 3 * h / 4;
		wd6 = w / 6;
		hd6 = h / 6;
		M456("SP2i3", 0);
		T108.M1033();
		M456("SP2i4", 0);
		M456("SP2i5", 0);
		inputDlg = new T71();
		M456("SP2i6", 0);
		listPoint = new T117();
		M456("SP2i7", 0);
	}

	public void M453()
	{
	}

	public int M454()
	{
		return (int)T139.WIDTH;
	}

	public int M455()
	{
		return (int)T139.HEIGHT;
	}

	public static void M456(string s, int type)
	{
	}

	public void M457(T108 screen)
	{
		try
		{
			T160.M1826().M1873();
			T90.isContinueToLogin = false;
			T174.bgType = 0;
			T174.lastType = 0;
			T13.M115();
			T54.M560();
			T54.M538();
			T66.M753();
			T54.info1.M757();
			T54.info2.M757();
			T54.info2.cmdChat = null;
			T55.isShow = false;
			T14.currChatPopup = null;
			T23.isStopReadMessage = false;
			T54.M564(fullmScreen: true, -1, -1);
			T54.cmx = 100;
			panel.currentTabIndex = 0;
			panel.selected = (isTouch ? (-1) : 0);
			panel.M1241();
			panel2 = null;
			T54.isPaint = true;
			T19.vMessage.M1120();
			T54.textTime.M1120();
			T54.vClan.M1120();
			T54.vFriend.M1120();
			T54.vEnemies.M1120();
			T174.vCurrItem.M1120();
			T8.vBgEffect.M1120();
			T31.vEff.M1120();
			T32.newEff.M1120();
			menu.showMenu = false;
			panel.vItemCombine.M1120();
			panel.isShow = false;
			if (panel.tabIcon != null)
			{
				panel.tabIcon.isShow = false;
			}
			if (T99.zoomLevel == 1)
			{
				T157.M1783();
			}
			T147.M1744().close();
			T148.M1757().close();
			screen.switchToMe();
		}
		catch (Exception ex)
		{
			T24.M326("Loi tai doResetToLoginScr " + ex.ToString());
		}
	}

	public static void M458(int type, string moreInfo)
	{
	}

	public static void M459(T99 g)
	{
	}

	public static void M460()
	{
	}

	public static void M461(T99 g, int color, int x, int y, int w, int h, int detalY)
	{
		g.M933(color);
		int cmy = T54.cmy;
		if (cmy > T51.h)
		{
			cmy = T51.h;
		}
		g.M932(x, y - ((detalY != 0) ? (cmy >> detalY) : 0), w, h + ((detalY != 0) ? (cmy >> detalY) : 0));
	}

	public static void M462(T99 g, int layer, int deltaY, int color1, int color2)
	{
		try
		{
			int num = layer - 1;
			if (num == imgBG.Length - 1 && (T54.M559().isRongThanXuatHien || T54.M559().isFireWorks))
			{
				g.M933(T54.M559().mautroi);
				g.M932(0, 0, w, h);
				if (typeBg == 2 || typeBg == 4 || typeBg == 7)
				{
					M463(g);
					M464(g);
				}
				if (T54.M559().isFireWorks && !lowGraphic)
				{
					T46.M433(g);
				}
			}
			else
			{
				if (imgBG == null || imgBG[num] == null)
				{
					return;
				}
				if (moveX[num] != 0)
				{
					moveX[num] += moveXSpeed[num];
				}
				int cmy = T54.cmy;
				if (cmy > h)
				{
					cmy = h;
				}
				if (layerSpeed[num] != 0)
				{
					for (int i = -((T54.cmx + moveX[num] >> layerSpeed[num]) % bgW[num]); i < T54.gW; i += bgW[num])
					{
						g.M948(imgBG[num], i, yb[num] - ((deltaY > 0) ? (cmy >> deltaY) : 0), 0);
					}
				}
				else
				{
					for (int j = 0; j < T54.gW; j += bgW[num])
					{
						g.M948(imgBG[num], j, yb[num] - ((deltaY > 0) ? (cmy >> deltaY) : 0), 0);
					}
				}
				if (color1 != -1)
				{
					if (num == nBg - 1)
					{
						M461(g, color1, 0, -(cmy >> deltaY), T54.gW, yb[num], deltaY);
					}
					else
					{
						M461(g, color1, 0, yb[num - 1] + bgH[num - 1], T54.gW, yb[num] - (yb[num - 1] + bgH[num - 1]), deltaY);
					}
				}
				if (color2 != -1)
				{
					if (num == 0)
					{
						M461(g, color2, 0, yb[num] + bgH[num], T54.gW, T54.gH - (yb[num] + bgH[num]), deltaY);
					}
					else
					{
						M461(g, color2, 0, yb[num] + bgH[num], T54.gW, yb[num - 1] - (yb[num] + bgH[num]) + 80, deltaY);
					}
				}
				if (currentScreen == T54.instance)
				{
					if (layer == 1 && typeBg == 11)
					{
						g.M948(imgSun2, -(T54.cmx >> layerSpeed[0]) + 400, yb[0] + 30 - (cmy >> 2), T163.BOTTOM_HCENTER);
					}
					if (layer == 1 && typeBg == 13)
					{
						g.M948(imgBG[1], -(T54.cmx >> layerSpeed[0]) + 200, yb[0] - (cmy >> 3) + 30, 0);
						g.M940(imgBG[1], 0, 0, bgW[1], bgH[1], 2, -(T54.cmx >> layerSpeed[0]) + 200 + bgW[1], yb[0] - (cmy >> 3) + 30, 0);
					}
					if (layer == 3 && T174.mapID == 1)
					{
						for (int k = 0; k < T174.pxh / T99.M959(imgCaycot); k++)
						{
							g.M948(imgCaycot, -(T54.cmx >> layerSpeed[2]) + 300, k * T99.M959(imgCaycot) - (cmy >> 3), 0);
						}
					}
				}
				T31.M379(g, -(T54.cmx + moveX[num] >> layerSpeed[num]), yb[num] + bgH[num] - (cmy >> deltaY), num);
			}
		}
		catch (Exception ex)
		{
			T24.M328("Loi ham paint bground: " + ex.ToString());
		}
	}

	public static void M463(T99 g)
	{
		if (imgSun != null)
		{
			g.M948(imgSun, sunX, sunY, 0);
		}
		if (!isBoltEff)
		{
			return;
		}
		if (gameTick % 200 == 0)
		{
			boltActive = true;
		}
		if (boltActive)
		{
			tBolt++;
			if (tBolt == 10)
			{
				tBolt = 0;
				boltActive = false;
			}
			if (tBolt % 2 == 0)
			{
				g.M933(16777215);
				g.M932(0, 0, w, h);
			}
		}
	}

	public static void M464(T99 g)
	{
		if (imgSun2 != null)
		{
			g.M948(imgSun2, sunX2, sunY2, 0);
		}
	}

	public static bool M465()
	{
		return T99.zoomLevel > 1;
	}

	public static void M466(T99 g)
	{
		if (!isLoadBGok)
		{
			g.M933(0);
			g.M932(0, 0, w, h);
		}
		if (!T13.isLoadingMap)
		{
			g.M918(-g.M920(), -g.M921());
			g.M933(0);
			g.M932(0, 0, w, h);
		}
	}

	public static void M467()
	{
	}

	public static void M468(int typeBg)
	{
		int gH = T54.gH23;
		switch (typeBg)
		{
		case 0:
			yb[0] = gH - bgH[0] + 70;
			yb[1] = yb[0] - bgH[1] + 20;
			yb[2] = yb[1] - bgH[2] + 30;
			yb[3] = yb[2] - bgH[3] + 50;
			break;
		case 1:
			yb[0] = gH - bgH[0] + 120;
			yb[1] = yb[0] - bgH[1] + 40;
			yb[2] = yb[1] - 90;
			yb[3] = yb[2] - 25;
			break;
		case 2:
			yb[0] = gH - bgH[0] + 150;
			yb[1] = yb[0] - bgH[1] - 60;
			yb[2] = yb[1] - bgH[2] - 40;
			yb[3] = yb[2] - bgH[3] - 10;
			yb[4] = yb[3] - bgH[4];
			break;
		case 3:
			yb[0] = gH - bgH[0] + 10;
			yb[1] = yb[0] + 80;
			yb[2] = yb[1] - bgH[2] - 10;
			break;
		case 4:
			yb[0] = gH - bgH[0] + 130;
			yb[1] = yb[0] - bgH[1];
			yb[2] = yb[1] - bgH[2] - 20;
			yb[3] = yb[1] - bgH[2] - 80;
			break;
		case 5:
			yb[0] = gH - bgH[0] + 40;
			yb[1] = yb[0] - bgH[1] + 10;
			yb[2] = yb[1] - bgH[2] + 15;
			yb[3] = yb[2] - bgH[3] + 50;
			break;
		case 6:
			yb[0] = gH - bgH[0] + 100;
			yb[1] = yb[0] - bgH[1] - 30;
			yb[2] = yb[1] - bgH[2] + 10;
			yb[3] = yb[2] - bgH[3] + 15;
			yb[4] = yb[3] - bgH[4] + 15;
			break;
		case 7:
			yb[0] = gH - bgH[0] + 20;
			yb[1] = yb[0] - bgH[1] + 15;
			yb[2] = yb[1] - bgH[2] + 20;
			yb[3] = yb[1] - bgH[2] - 10;
			break;
		case 8:
			yb[0] = gH - 103 + 150;
			if (T174.mapID == 103)
			{
				yb[0] -= 100;
			}
			yb[1] = yb[0] - bgH[1] - 10;
			yb[2] = yb[1] - bgH[2] + 40;
			yb[3] = yb[2] - bgH[3] + 10;
			break;
		case 9:
			yb[0] = gH - bgH[0] + 100;
			yb[1] = yb[0] - bgH[1] + 22;
			yb[2] = yb[1] - bgH[2] + 50;
			yb[3] = yb[2] - bgH[3];
			break;
		case 10:
			yb[0] = gH - bgH[0] - 45;
			yb[1] = yb[0] - bgH[1] - 10;
			break;
		case 11:
			yb[0] = gH - bgH[0] + 60;
			yb[1] = yb[0] - bgH[1] + 5;
			yb[2] = yb[1] - bgH[2] - 15;
			break;
		case 12:
			yb[0] = gH + 40;
			yb[1] = yb[0] - 40;
			yb[2] = yb[1] - 40;
			break;
		case 13:
			yb[0] = gH - 80;
			yb[1] = yb[0];
			break;
		default:
			yb[0] = gH - bgH[0] + 75;
			yb[1] = yb[0] - bgH[1] + 50;
			yb[2] = yb[1] - bgH[2] + 50;
			yb[3] = yb[2] - bgH[3] + 90;
			break;
		case 15:
			yb[0] = gH - 20;
			yb[1] = yb[0] - 80;
			break;
		case 16:
			yb[0] = gH - bgH[0] + 75;
			yb[1] = yb[0] - bgH[1] + 50;
			yb[2] = yb[1] - bgH[2] + 50;
			yb[3] = yb[2] - bgH[3] + 90;
			break;
		}
	}

	public static void M469(int typeBG)
	{
		try
		{
			isLoadBGok = true;
			if (typeBg == 12)
			{
				T8.yfog = T174.pxh - 100;
			}
			else
			{
				T8.yfog = T174.pxh - 160;
			}
			T8.M39();
			M470(typeBG);
			if ((T174.lastBgID == typeBG && T174.lastType == T174.bgType) || typeBG == -1)
			{
				return;
			}
			transY = 12;
			T174.lastBgID = (sbyte)typeBG;
			T174.lastType = (sbyte)T174.bgType;
			layerSpeed = new int[5] { 1, 2, 3, 7, 8 };
			moveX = new int[5];
			moveXSpeed = new int[5];
			typeBg = typeBG;
			isBoltEff = false;
			T54.firstY = T54.cmy;
			imgBG = null;
			imgCloud = null;
			imgSun = null;
			imgCaycot = null;
			T54.firstY = -1;
			switch (typeBg)
			{
			case 0:
				imgCaycot = M502("/bg/caycot.png");
				layerSpeed = new int[4] { 1, 3, 5, 7 };
				nBg = 4;
				if (T174.bgType == 2)
				{
					transY = 8;
				}
				break;
			case 1:
				transY = 7;
				nBg = 4;
				break;
			case 2:
				moveX = new int[5] { 0, 0, 1, 0, 0 };
				moveXSpeed = new int[5] { 0, 0, 2, 0, 0 };
				nBg = 5;
				break;
			case 3:
				nBg = 3;
				break;
			case 4:
				T8.M55(3);
				moveX = new int[5] { 0, 1, 0, 0, 0 };
				moveXSpeed = new int[5] { 0, 1, 0, 0, 0 };
				nBg = 4;
				break;
			case 5:
				nBg = 4;
				break;
			case 6:
				moveX = new int[5] { 1, 0, 0, 0, 0 };
				moveXSpeed = new int[5] { 2, 0, 0, 0, 0 };
				nBg = 5;
				break;
			case 7:
				nBg = 4;
				break;
			case 8:
				transY = 8;
				nBg = 4;
				break;
			case 9:
				T8.M55(9);
				nBg = 4;
				break;
			case 10:
				nBg = 2;
				break;
			case 11:
				transY = 7;
				layerSpeed[2] = 0;
				nBg = 3;
				break;
			case 12:
				moveX = new int[5] { 1, 1, 0, 0, 0 };
				moveXSpeed = new int[5] { 2, 1, 0, 0, 0 };
				nBg = 3;
				break;
			case 13:
				nBg = 2;
				break;
			default:
				layerSpeed = new int[4] { 1, 3, 5, 7 };
				nBg = 4;
				break;
			case 15:
				T137.M1513("HELL");
				nBg = 2;
				break;
			case 16:
				layerSpeed = new int[4] { 1, 3, 5, 7 };
				nBg = 4;
				break;
			}
			if (typeBG < 16)
			{
				skyColor = T163.SKYCOLOR[typeBg];
			}
			else
			{
				try
				{
					string path = "/bg/b" + typeBg + 3 + ".png";
					if (T174.bgType != 0)
					{
						path = "/bg/b" + typeBg + 3 + "-" + T174.bgType + ".png";
					}
					int[] data = new int[1];
					T60 t = M502(path);
					t.M734(ref data, 0, 1, T99.M966(t) / 2, 0, 1, 1);
					skyColor = data[0];
				}
				catch (Exception)
				{
					skyColor = T163.SKYCOLOR[T163.SKYCOLOR.Length - 1];
				}
			}
			if (lowGraphic)
			{
				tam = M502("/bg/b63.png");
				return;
			}
			imgBG = new T60[nBg];
			bgW = new int[nBg];
			bgH = new int[nBg];
			colorBotton = new int[nBg];
			colorTop = new int[nBg];
			if (T174.bgType == 100)
			{
				imgBG[0] = M502("/bg/b100.png");
				imgBG[1] = M502("/bg/b100.png");
				imgBG[2] = M502("/bg/b82-1.png");
				imgBG[3] = M502("/bg/b93.png");
				for (int i = 0; i < nBg; i++)
				{
					if (imgBG[i] != null)
					{
						int[] data2 = new int[1];
						imgBG[i].M734(ref data2, 0, 1, T99.M966(imgBG[i]) / 2, 0, 1, 1);
						colorTop[i] = data2[0];
						data2 = new int[1];
						imgBG[i].M734(ref data2, 0, 1, T99.M966(imgBG[i]) / 2, T99.M967(imgBG[i]) - 1, 1, 1);
						colorBotton[i] = data2[0];
						bgW[i] = T99.M958(imgBG[i]);
						bgH[i] = T99.M959(imgBG[i]);
					}
					else if (nBg > 1)
					{
						imgBG[i] = M502("/bg/b" + typeBg + "0.png");
						bgW[i] = T99.M958(imgBG[i]);
						bgH[i] = T99.M959(imgBG[i]);
					}
				}
			}
			else
			{
				for (int j = 0; j < nBg; j++)
				{
					string path2 = "/bg/b" + typeBg + j + ".png";
					if (T174.bgType != 0)
					{
						path2 = "/bg/b" + typeBg + j + "-" + T174.bgType + ".png";
					}
					imgBG[j] = M502(path2);
					if (imgBG[j] != null)
					{
						int[] data3 = new int[1];
						imgBG[j].M734(ref data3, 0, 1, T99.M966(imgBG[j]) / 2, 0, 1, 1);
						colorTop[j] = data3[0];
						data3 = new int[1];
						imgBG[j].M734(ref data3, 0, 1, T99.M966(imgBG[j]) / 2, T99.M967(imgBG[j]) - 1, 1, 1);
						colorBotton[j] = data3[0];
						bgW[j] = T99.M958(imgBG[j]);
						bgH[j] = T99.M959(imgBG[j]);
					}
					else if (nBg > 1)
					{
						imgBG[j] = M502("/bg/b" + typeBg + "0.png");
						bgW[j] = T99.M958(imgBG[j]);
						bgH[j] = T99.M959(imgBG[j]);
					}
				}
			}
			M468(typeBg);
			cloudX = new int[5]
			{
				T54.gW / 2 - 40,
				T54.gW / 2 + 40,
				T54.gW / 2 - 100,
				T54.gW / 2 - 80,
				T54.gW / 2 - 120
			};
			cloudY = new int[5] { 130, 100, 150, 140, 80 };
			imgSunSpec = null;
			if (typeBg != 0)
			{
				if (typeBg == 2)
				{
					imgSun = M502("/bg/sun0.png");
					sunX = T54.gW / 2 + 50;
					sunY = yb[4] - 40;
				}
				else if (typeBg == 4)
				{
					imgSun = M502("/bg/sun2.png");
					sunX = T54.gW / 2 + 30;
					sunY = yb[3];
				}
				else if (typeBg == 7)
				{
					imgSun = M502("/bg/sun3" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
					imgSun2 = M502("/bg/sun4" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
					sunX = T54.gW - T54.gW / 3;
					sunY = yb[3] - 80;
					sunX2 = sunX - 100;
					sunY2 = yb[3] - 30;
				}
				else if (typeBg == 6)
				{
					imgSun = M502("/bg/sun5" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
					imgSun2 = M502("/bg/sun6" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
					sunX = T54.gW - T54.gW / 3;
					sunY = yb[4];
					sunX2 = sunX - 100;
					sunY2 = yb[4] + 20;
				}
				else if (typeBG == 5)
				{
					imgSun = M502("/bg/sun8" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
					imgSun2 = M502("/bg/sun7" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
					sunX = T54.gW / 2 - 50;
					sunY = yb[3] + 20;
					sunX2 = T54.gW / 2 + 20;
					sunY2 = yb[3] - 30;
				}
				else if (typeBg == 8 && T174.mapID < 90)
				{
					imgSun = M502("/bg/sun9" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
					imgSun2 = M502("/bg/sun10" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
					sunX = T54.gW / 2 - 30;
					sunY = yb[3] + 60;
					sunX2 = T54.gW / 2 + 20;
					sunY2 = yb[3] + 10;
				}
				else
				{
					switch (typeBG)
					{
					case 9:
						imgSun = M502("/bg/sun11" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
						imgSun2 = M502("/bg/sun12" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
						sunX = T54.gW - T54.gW / 3;
						sunY = yb[4] + 20;
						sunX2 = sunX - 80;
						sunY2 = yb[4] + 40;
						break;
					case 10:
						imgSun = M502("/bg/sun13" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
						imgSun2 = M502("/bg/sun14" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
						sunX = T54.gW - T54.gW / 3;
						sunY = yb[1] - 30;
						sunX2 = sunX - 80;
						sunY2 = yb[1];
						break;
					case 11:
						imgSun = M502("/bg/sun15" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
						imgSun2 = M502("/bg/b113" + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
						sunX = T54.gW / 2 - 30;
						sunY = yb[2] - 30;
						break;
					case 12:
						cloudY = new int[5] { 200, 170, 220, 150, 250 };
						break;
					default:
						imgCloud = null;
						imgSun = null;
						imgSun2 = null;
						imgSun = M502("/bg/sun" + typeBG + ((T174.bgType != 0) ? ("-" + T174.bgType) : string.Empty) + ".png");
						sunX = T54.gW - T54.gW / 3;
						sunY = yb[2] - 30;
						break;
					case 16:
					{
						cloudX = new int[7] { 90, 170, 250, 320, 400, 450, 500 };
						cloudY = new int[7]
						{
							yb[2] + 5,
							yb[2] - 20,
							yb[2] - 50,
							yb[2] - 30,
							yb[2] - 50,
							yb[2],
							yb[2] - 40
						};
						imgSunSpec = new T60[7];
						for (int k = 0; k < imgSunSpec.Length; k++)
						{
							int num = 161;
							if (k == 0 || k == 2 || k == 3 || k == 2 || k == 6)
							{
								num = 160;
							}
							imgSunSpec[k] = M502("/bg/sun" + num + ".png");
						}
						break;
					}
					}
				}
			}
			paintBG = false;
			if (!paintBG)
			{
				paintBG = true;
			}
		}
		catch (Exception)
		{
			isLoadBGok = false;
		}
	}

	private static void M470(int typeBG)
	{
		int num = 0;
		while (true)
		{
			if (num < bgRain.Length)
			{
				if (typeBG == bgRain[num] && T137.M1522(0, 2) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		T8.M55(0);
	}

	public void M471(int keyCode)
	{
		lastTimePress = T110.M1054();
		if ((keyCode >= 48 && keyCode <= 57) || (keyCode >= 65 && keyCode <= 122) || keyCode == 10 || keyCode == 8 || keyCode == 13 || keyCode == 32 || keyCode == 31)
		{
			keyAsciiPress = keyCode;
		}
		M472(keyCode);
	}

	public void M472(int keyCode)
	{
		if (currentDialog != null)
		{
			currentDialog.keyPress(keyCode);
			keyAsciiPress = 0;
			return;
		}
		currentScreen.keyPress(keyCode);
		switch (keyCode)
		{
		case -26:
			keyHold[16] = true;
			keyPressed[16] = true;
			break;
		case -8:
			keyHold[14] = true;
			keyPressed[14] = true;
			break;
		case -22:
		case -7:
			keyHold[13] = true;
			keyPressed[13] = true;
			break;
		case -4:
			if ((currentScreen is T54 || currentScreen is T25) && T13.M113().isAttack)
			{
				M484();
				M483();
			}
			else
			{
				keyHold[24] = true;
				keyPressed[24] = true;
			}
			break;
		case -3:
			if ((currentScreen is T54 || currentScreen is T25) && T13.M113().isAttack)
			{
				M484();
				M483();
			}
			else
			{
				keyHold[23] = true;
				keyPressed[23] = true;
			}
			break;
		case -39:
		case -2:
			if ((currentScreen is T54 || currentScreen is T25) && T13.M113().isAttack)
			{
				M484();
				M483();
			}
			else
			{
				keyHold[22] = true;
				keyPressed[22] = true;
			}
			break;
		case -38:
		case -1:
			if ((currentScreen is T54 || currentScreen is T25) && T13.M113().isAttack)
			{
				M484();
				M483();
			}
			else
			{
				keyHold[21] = true;
				keyPressed[21] = true;
			}
			break;
		case -21:
		case -6:
			keyHold[12] = true;
			keyPressed[12] = true;
			break;
		case 113:
			keyHold[17] = true;
			keyPressed[17] = true;
			break;
		case 35:
			keyHold[11] = true;
			keyPressed[11] = true;
			break;
		case 42:
			keyHold[10] = true;
			keyPressed[10] = true;
			break;
		case 48:
			keyHold[0] = true;
			keyPressed[0] = true;
			break;
		case 49:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[1] = true;
				keyPressed[1] = true;
			}
			break;
		case 50:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[2] = true;
				keyPressed[2] = true;
			}
			break;
		case 51:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[3] = true;
				keyPressed[3] = true;
			}
			break;
		case 52:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[4] = true;
				keyPressed[4] = true;
			}
			break;
		case 53:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[5] = true;
				keyPressed[5] = true;
			}
			break;
		case 54:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[6] = true;
				keyPressed[6] = true;
			}
			break;
		case 55:
			keyHold[7] = true;
			keyPressed[7] = true;
			break;
		case 56:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[8] = true;
				keyPressed[8] = true;
			}
			break;
		case 57:
			keyHold[9] = true;
			keyPressed[9] = true;
			break;
		case -5:
		case 10:
			if ((currentScreen is T54 || currentScreen is T25) && T13.M113().isAttack)
			{
				M484();
				M483();
				break;
			}
			keyHold[25] = true;
			keyPressed[25] = true;
			keyHold[15] = true;
			keyPressed[15] = true;
			break;
		}
	}

	public void M473(int keyCode)
	{
		keyAsciiPress = 0;
		M474(keyCode);
	}

	public void M474(int keyCode)
	{
		switch (keyCode)
		{
		case -26:
			keyHold[16] = false;
			break;
		case -8:
			keyHold[14] = false;
			break;
		case -22:
		case -7:
			keyHold[13] = false;
			keyReleased[13] = true;
			break;
		case -4:
			keyHold[24] = false;
			break;
		case -3:
			keyHold[23] = false;
			break;
		case -39:
		case -2:
			keyHold[22] = false;
			break;
		case -38:
		case -1:
			keyHold[21] = false;
			break;
		case -21:
		case -6:
			keyHold[12] = false;
			keyReleased[12] = true;
			break;
		case 113:
			keyHold[17] = false;
			keyReleased[17] = true;
			break;
		case 35:
			keyHold[11] = false;
			keyReleased[11] = true;
			break;
		case 42:
			keyHold[10] = false;
			keyReleased[10] = true;
			break;
		case 48:
			keyHold[0] = false;
			keyReleased[0] = true;
			break;
		case 49:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[1] = false;
				keyReleased[1] = true;
			}
			break;
		case 50:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[2] = false;
				keyReleased[2] = true;
			}
			break;
		case 51:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[3] = false;
				keyReleased[3] = true;
			}
			break;
		case 52:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[4] = false;
				keyReleased[4] = true;
			}
			break;
		case 53:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[5] = false;
				keyReleased[5] = true;
			}
			break;
		case 54:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[6] = false;
				keyReleased[6] = true;
			}
			break;
		case 55:
			keyHold[7] = false;
			keyReleased[7] = true;
			break;
		case 56:
			if (currentScreen == T25.instance || (currentScreen == T54.instance && isMoveNumberPad && !T15.M279().isShow))
			{
				keyHold[8] = false;
				keyReleased[8] = true;
			}
			break;
		case 57:
			keyHold[9] = false;
			keyReleased[9] = true;
			break;
		case -5:
		case 10:
			keyHold[25] = false;
			keyReleased[25] = true;
			keyHold[15] = true;
			keyPressed[15] = true;
			break;
		}
	}

	public void M475(int x, int y)
	{
		pxMouse = x;
		pyMouse = y;
	}

	public void M476(int a)
	{
		pXYScrollMouse = a;
		if (panel != null && panel.isShow)
		{
			panel.M1306(a);
		}
	}

	public void M477(int x, int y)
	{
		if (T137.M1529(x - pxLast) >= 10 || T137.M1529(y - pyLast) >= 10)
		{
			isPointerClick = false;
			isPointerDown = true;
			isPointerMove = true;
		}
		px = x;
		py = y;
		curPos++;
		if (curPos > 3)
		{
			curPos = 0;
		}
		arrPos[curPos] = new T135(x, y);
	}

	public static bool M478()
	{
		return T110.M1054() - lastTimePress >= 800L;
	}

	public void M479(int x, int y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		isPointerJustRelease = false;
		isPointerJustDown = true;
		isPointerDown = true;
		isPointerClick = true;
		isPointerMove = false;
		lastTimePress = T110.M1054();
		pxFirst = x;
		pyFirst = y;
		pxLast = x;
		pyLast = y;
		px = x;
		py = y;
	}

	public void M480(int x, int y)
	{
		isPointerDown = false;
		isPointerJustRelease = true;
		isPointerMove = false;
		T108.keyTouch = -1;
		px = x;
		py = y;
	}

	public static bool M481(int x, int y, int w, int h)
	{
		if ((isPointerDown || isPointerJustRelease) && px >= x && px <= x + w && py >= y)
		{
			return py <= y + h;
		}
		return false;
	}

	public static bool M482(int x, int y, int w, int h)
	{
		if (pxMouse >= x && pxMouse <= x + w && pyMouse >= y)
		{
			return pyMouse <= y + h;
		}
		return false;
	}

	public static void M483()
	{
		for (int i = 0; i < keyPressed.Length; i++)
		{
			keyPressed[i] = false;
		}
		isPointerJustRelease = false;
	}

	public static void M484()
	{
		for (int i = 0; i < keyHold.Length; i++)
		{
			keyHold[i] = false;
		}
	}

	public static void M485()
	{
		if (T14.serverChatPopUp == null && T14.currChatPopup == null)
		{
			M496(mResources.DOYOUWANTEXIT, new T22(mResources.YES, instance, 8885, null), new T22(mResources.NO, instance, 8882, null));
		}
	}

	public void M486(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M451(g);
		g.M933(0);
		g.M932(0, 0, w, h);
		g.M948(T200.logoServerListScreen, w / 2, h / 2 - 8, T163.BOTTOM_HCENTER);
		M514(hw, h / 2 + 24, g);
		T98.tahoma_7b_white.M898(g, mResources.PLEASEWAIT + ((T90.timeLogin <= 0) ? string.Empty : (" " + T90.timeLogin + "s")), w / 2, h / 2, 2);
	}

	public void M487(T99 gx)
	{
		try
		{
			debugPaint.M1120();
			M456("PA", 1);
			if (currentScreen != null)
			{
				currentScreen.paint(g);
			}
			M456("PB", 1);
			g.M918(-g.M920(), -g.M921());
			g.M922(0, 0, w, h);
			if (panel.isShow)
			{
				panel.M1329(g);
				if (panel2 != null && panel2.isShow)
				{
					panel2.M1329(g);
				}
				if (panel.chatTField != null && panel.chatTField.isShow)
				{
					panel.chatTField.M286(g);
				}
				if (panel2 != null && panel2.chatTField != null && panel2.chatTField.isShow)
				{
					panel2.chatTField.M286(g);
				}
			}
			T137.M1516(g);
			T66.M751(g);
			if (currentDialog != null)
			{
				M456("PC", 1);
				currentDialog.paint(g);
			}
			else if (menu.showMenu)
			{
				M456("PD", 1);
				menu.M881(g);
			}
			T54.info1.M756(g);
			T54.info2.M756(g);
			if (T54.M559().popUpYesNo != null)
			{
				T54.M559().popUpYesNo.M1488(g);
			}
			if (T14.currChatPopup != null)
			{
				T14.currChatPopup.paint(g);
			}
			T55.M699(g);
			if (T14.serverChatPopUp != null)
			{
				T14.serverChatPopUp.paint(g);
			}
			for (int i = 0; i < T33.vEffect2.M1113(); i++)
			{
				T33 t = (T33)T33.vEffect2.M1114(i);
				if (t is T14 && !t.Equals(T14.currChatPopup) && !t.Equals(T14.serverChatPopUp))
				{
					t.paint(g);
				}
			}
			if (T13.isLoadingMap || T90.isContinueToLogin || T144.waitToLogin || T144.isWait)
			{
				M486(g);
			}
			M456("PE", 1);
			M451(g);
			T31.M383(g);
			if (mResources.language == 0 && open3Hour && !isLoading)
			{
				if (currentScreen == loginScr || currentScreen == serverScreen || currentScreen == serverScr)
				{
					g.M948(img12, 5, 5, 0);
				}
				if (currentScreen == T26.instance)
				{
					g.M948(img12, 5, 20, 0);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void M488()
	{
		if (inputDlg != null)
		{
			inputDlg.tfInput.M1929(500);
		}
		currentDialog = null;
		T66.M753();
	}

	public static void M489(string info)
	{
		if (!info.ToLower().Contains("không thể đổi khu vực trong map này"))
		{
			M444();
			msgdlg.M1037(info, null, new T22(mResources.OK, instance, 8882, null), null);
			currentDialog = msgdlg;
		}
	}

	public static void M490(string info)
	{
		M444();
		msgdlg.M1037(info, null, new T22(mResources.CANCEL, instance, 8882, null), null);
		currentDialog = msgdlg;
		msgdlg.isWait = true;
	}

	public static void M491(string info, bool isError)
	{
		if (!info.ToLower().Contains("không thể đổi khu vực trong map này"))
		{
			M444();
			msgdlg.M1037(info, null, new T22(mResources.CANCEL, instance, 8882, null), null);
			currentDialog = msgdlg;
			msgdlg.isWait = true;
		}
	}

	public static void M492()
	{
		M444();
		T13.isLoadingMap = true;
	}

	public void M493(string strLeft, string strRight, string url, string str)
	{
		msgdlg.M1037(str, new T22(strLeft, this, 8881, url), null, new T22(strRight, this, 8882, null));
		currentDialog = msgdlg;
	}

	public static void M494(string info, int actionID, object p)
	{
		M444();
		msgdlg.M1037(info, null, new T22(mResources.OK, instance, actionID, p), null);
		msgdlg.show();
	}

	public static void M495(string info, int iYes, object pYes, int iNo, object pNo)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M444();
		msgdlg.M1037(info, new T22(mResources.YES, instance, iYes, pYes), new T22(string.Empty, instance, iYes, pYes), new T22(mResources.NO, instance, iNo, pNo));
		msgdlg.show();
	}

	public static void M496(string info, T22 cmdYes, T22 cmdNo)
	{
		M444();
		msgdlg.M1037(info, cmdYes, null, cmdNo);
		msgdlg.show();
	}

	public static string M497(int m)
	{
		string text = string.Empty;
		int num = m / 1000 + 1;
		for (int i = 0; i < num; i++)
		{
			if (m >= 1000)
			{
				int num2 = m % 1000;
				text = ((num2 != 0) ? ((num2 >= 10) ? ((num2 >= 100) ? ("." + num2 + text) : (".0" + num2 + text)) : (".00" + num2 + text)) : (".000" + text));
				m /= 1000;
				continue;
			}
			text = m + text;
			break;
		}
		return text;
	}

	public static int M498(int start, int w)
	{
		return (px - start) / w;
	}

	public static int M499(int start, int w)
	{
		return (py - start) / w;
	}

	protected void M500(int w, int h)
	{
	}

	public static bool M501()
	{
		return true;
	}

	public static T60 M502(string path)
	{
		path = Main.res + "/x" + T99.zoomLevel + path;
		path = M504(path);
		T60 result = null;
		try
		{
			result = T60.M703(path);
			return result;
		}
		catch (Exception ex)
		{
			try
			{
				string[] array = T137.M1531(path, "/", 0);
				sbyte[] array2 = T138.M1535("x" + T99.zoomLevel + array[array.Length - 1]);
				if (array2 != null)
				{
					result = T60.M708(array2, 0, array2.Length);
					return result;
				}
				return result;
			}
			catch (Exception)
			{
				T24.M328("Loi ham khong tim thay a: " + ex.ToString());
				return result;
			}
		}
	}

	public static T60 M503(string path)
	{
		path = Main.res + "/x" + T99.zoomLevel + path;
		path = M504(path);
		T60 result = null;
		try
		{
			result = T60.M703(path);
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	public static string M504(string str)
	{
		string result = str;
		if (str.Contains(".png"))
		{
			result = str.Replace(".png", string.Empty);
		}
		return result;
	}

	public static int M505(int a, int b)
	{
		return a + r.M1084(b - a);
	}

	public bool M506(int dir, int x, int y)
	{
		if (lowGraphic)
		{
			return false;
		}
		int num = ((dir != 1) ? 1 : 0);
		if (dustState[num] != -1)
		{
			return false;
		}
		dustState[num] = 0;
		dustX[num] = x;
		dustY[num] = y;
		return true;
	}

	public void M507()
	{
		if (!lowGraphic)
		{
			imgWS = new T60[3];
			for (int i = 0; i < 3; i++)
			{
				imgWS[i] = M503("/e/w" + i + ".png");
			}
			wsX = new int[2];
			wsY = new int[2];
			wsState = new int[2];
			wsF = new int[2];
			int[] array = wsState;
			wsState[1] = -1;
			array[0] = -1;
		}
	}

	public bool M508(int x, int y)
	{
		if (lowGraphic)
		{
			return false;
		}
		int num = ((wsState[0] != -1) ? 1 : 0);
		if (wsState[num] != -1)
		{
			return false;
		}
		wsState[num] = 0;
		wsX[num] = x;
		wsY[num] = y;
		return true;
	}

	public void M509()
	{
		if (lowGraphic)
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			if (wsState[i] == -1)
			{
				continue;
			}
			wsY[i]--;
			if (gameTick % 2 == 0)
			{
				wsState[i]++;
				if (wsState[i] > 2)
				{
					wsState[i] = -1;
				}
				else
				{
					wsF[i] = wsState[i];
				}
			}
		}
	}

	public void M510()
	{
		if (lowGraphic)
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			if (dustState[i] != -1)
			{
				dustState[i]++;
				if (dustState[i] >= 5)
				{
					dustState[i] = -1;
				}
				if (i == 0)
				{
					dustX[i]--;
				}
				else
				{
					dustX[i]++;
				}
				dustY[i]--;
			}
		}
	}

	public static bool M511(int x, int y)
	{
		if (x >= T54.cmx && x <= T54.cmx + T54.gW && y >= T54.cmy)
		{
			return y <= T54.cmy + T54.gH + 30;
		}
		return false;
	}

	public void M512(T99 g)
	{
		if (lowGraphic)
		{
			return;
		}
		for (int i = 0; i < 2; i++)
		{
			if (dustState[i] != -1 && M511(dustX[i], dustY[i]))
			{
				g.M948(imgDust[i][dustState[i]], dustX[i], dustY[i], 3);
			}
		}
	}

	public void M513()
	{
		if (lowGraphic)
		{
			return;
		}
		if (imgDust == null)
		{
			imgDust = new T60[2][];
			for (int i = 0; i < imgDust.Length; i++)
			{
				imgDust[i] = new T60[5];
			}
			for (int j = 0; j < 2; j++)
			{
				for (int k = 0; k < 5; k++)
				{
					imgDust[j][k] = M503("/e/d" + j + k + ".png");
				}
			}
		}
		dustX = new int[2];
		dustY = new int[2];
		dustState = new int[2];
		int[] array = dustState;
		dustState[1] = -1;
		array[0] = -1;
	}

	public static void M514(int x, int y, T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M940(imgShuriken, 0, Main.f * 16, 16, 16, 0, x, y, T99.HCENTER | T99.VCENTER);
	}

	public void M515()
	{
		resetToLoginScr = true;
	}

	public static bool M516(int x, int y, int w, int h)
	{
		if ((isPointerDown || isPointerJustRelease) && px >= x && px <= x + w && py >= y)
		{
			return py <= y + h;
		}
		return false;
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8881:
		{
			string url = (string)p;
			try
			{
				T52.instance.M524(url);
			}
			catch (Exception)
			{
			}
			currentDialog = null;
			break;
		}
		case 8882:
			T66.M753();
			currentDialog = null;
			break;
		case 8884:
			M488();
			loginScr.switchToMe();
			break;
		case 8885:
			T52.instance.M520();
			break;
		case 8886:
		{
			M488();
			string name = (string)p;
			T146.M1594().M1681(name);
			break;
		}
		case 8887:
		{
			M488();
			int charId2 = (int)p;
			T146.M1594().M1682(charId2);
			break;
		}
		case 8888:
		{
			int charId = (int)p;
			T146.M1594().M1683(charId);
			M488();
			break;
		}
		case 8889:
		{
			string str = (string)p;
			M488();
			T146.M1594().M1692(str);
			break;
		}
		case 999:
			T110.M1047();
			M488();
			break;
		case 9999:
			M488();
			M449();
			T146.M1594().M1630();
			if (loginScr == null)
			{
				loginScr = new T90();
			}
			loginScr.M861();
			break;
		case 9000:
			M488();
			T161.imgLogo = null;
			T157.M1777();
			T110.M1062();
			T144.bigOk = true;
			T144.loadScreen = true;
			T54.M559().M561();
			if (currentScreen != loginScr)
			{
				serverScreen.M1588();
			}
			break;
		case 101023:
			Main.numberQuit = 0;
			break;
		case 88810:
		{
			int playerMapId = (int)p;
			M488();
			T146.M1594().M1665(playerMapId);
			break;
		}
		case 88811:
			M488();
			T146.M1594().M1666();
			break;
		case 88814:
		{
			T79[] items = (T79[])p;
			M488();
			T146.M1594().M1664(items);
			break;
		}
		case 88817:
			T14.M271(string.Empty, 1, T13.M113().npcFocus);
			T146.M1594().M1657(T13.M113().npcFocus.template.npcTemplateId, menu.menuSelectedItem, 0);
			break;
		case 88818:
		{
			short menuId3 = (short)p;
			T146.M1594().M1659(menuId3, inputDlg.tfInput.M1924());
			M488();
			break;
		}
		case 88819:
		{
			short menuId2 = (short)p;
			T146.M1594().M1658(menuId2);
			break;
		}
		case 88820:
		{
			string[] array = (string[])p;
			if (T13.M113().npcFocus == null)
			{
				break;
			}
			int menuSelectedItem = menu.menuSelectedItem;
			if (array.Length > 1)
			{
				T117 t = new T117();
				for (int i = 0; i < array.Length - 1; i++)
				{
					t.M1111(new T22(array[i + 1], instance, 88821, menuSelectedItem));
				}
				menu.M877(t, 3);
			}
			else
			{
				T14.M271(string.Empty, 1, T13.M113().npcFocus);
				T146.M1594().M1657(T13.M113().npcFocus.template.npcTemplateId, menuSelectedItem, 0);
			}
			break;
		}
		case 88821:
		{
			int menuId = (int)p;
			T14.M271(string.Empty, 1, T13.M113().npcFocus);
			T146.M1594().M1657(T13.M113().npcFocus.template.npcTemplateId, menuId, menu.menuSelectedItem);
			break;
		}
		case 88822:
			T14.M271(string.Empty, 1, T13.M113().npcFocus);
			T146.M1594().M1657(T13.M113().npcFocus.template.npcTemplateId, menu.menuSelectedItem, 0);
			break;
		case 88823:
			M489(mResources.SENTMSG);
			break;
		case 88824:
			M489(mResources.NOSENDMSG);
			break;
		case 88825:
			M491(mResources.sendMsgSuccess, isError: false);
			break;
		case 88826:
			M491(mResources.cannotSendMsg, isError: false);
			break;
		case 88827:
			M489(mResources.sendGuessMsgSuccess);
			break;
		case 88828:
			M489(mResources.sendMsgFail);
			break;
		case 88829:
		{
			string text4 = inputDlg.tfInput.M1924();
			if (!text4.Equals(string.Empty))
			{
				T146.M1594().M1700(text4, (int)p);
				T66.M749();
			}
			break;
		}
		case 88836:
			inputDlg.tfInput.M1929(6);
			inputDlg.M777(mResources.INPUT_PRIVATE_PASS, new T22(mResources.ACCEPT, instance, 888361, null), T173.INPUT_TYPE_NUMERIC);
			break;
		case 88837:
		{
			string text3 = inputDlg.tfInput.M1924();
			M488();
			try
			{
				T146.M1594().M1708(int.Parse(text3.Trim()));
				break;
			}
			catch (Exception ex4)
			{
				T24.M326("Loi tai 88837 " + ex4.ToString());
				break;
			}
		}
		case 88839:
		{
			string text2 = inputDlg.tfInput.M1924();
			M488();
			if (text2.Length >= 6 && !text2.Equals(string.Empty))
			{
				try
				{
					M495(mResources.cancelAccountProtection, 888391, text2, 8882, null);
					break;
				}
				catch (Exception)
				{
					M489(mResources.ALERT_PRIVATE_PASS_2);
					break;
				}
			}
			M489(mResources.ALERT_PRIVATE_PASS_1);
			break;
		}
		case 888391:
		{
			string s = (string)p;
			M488();
			T146.M1594().M1706(int.Parse(s));
			break;
		}
		case 888392:
			T146.M1594().M1657(4, menu.menuSelectedItem, 0);
			break;
		case 888393:
			if (loginScr == null)
			{
				loginScr = new T90();
			}
			loginScr.M861();
			Main.closeKeyBoard();
			break;
		case 888394:
			M488();
			break;
		case 888395:
			M488();
			break;
		case 888396:
			M488();
			break;
		case 888361:
		{
			string text = inputDlg.tfInput.M1924();
			M488();
			if (text.Length >= 6 && !text.Equals(string.Empty))
			{
				try
				{
					T146.M1594().M1705(int.Parse(text));
					break;
				}
				catch (Exception ex)
				{
					M489(mResources.ALERT_PRIVATE_PASS_2);
					T24.M326("Loi tai 888361 Gamescavas " + ex.ToString());
					break;
				}
			}
			M489(mResources.ALERT_PRIVATE_PASS_1);
			break;
		}
		}
	}

	public static void M517()
	{
		isPointerClick = false;
		isPointerDown = false;
		isPointerJustDown = false;
		isPointerJustRelease = false;
		T54.M559().lastSingleClick = 0L;
		T54.M559().isPointerDowning = false;
	}

	public static void M518()
	{
	}
}
