using System;
using N5.N6.N7;
using UnityEngine;

public class T126 : T57, T58
{
	public bool isShow;

	public int X;

	public int Y;

	public int W;

	public int H;

	public int ITEM_HEIGHT;

	public int TAB_W;

	public int TAB_W_NEW;

	public int cmtoY;

	public int cmy;

	public int cmdy;

	public int cmvy;

	public int cmyLim;

	public int xc;

	public int[] cmyLast;

	public int cmtoX;

	public int cmx;

	public int cmxLim;

	public int cmxMap;

	public int cmyMap;

	public int cmxMapLim;

	public int cmyMapLim;

	public int cmyQuest;

	public static T60 imgBantay;

	public static T60 imgX;

	public static T60 imgMap;

	public T167 tabIcon;

	public T117 vItemCombine = new T117();

	public int moneyGD;

	public int friendMoneyGD;

	public bool isLock;

	public bool isFriendLock;

	public bool isAccept;

	public bool isFriendAccep;

	public string topName;

	public T15 chatTField;

	public static string specialInfo;

	public static short spearcialImage;

	public static T60 imgStar;

	public static T60 imgMaxStar;

	public static T60 imgStar8;

	public static T60 imgNew;

	public static T60 imgXu;

	public static T60 imgTicket;

	public static T60 imgLuong;

	public static T60 imgLuongKhoa;

	private static T60 imgUp;

	private static T60 imgDown;

	private int pa1;

	private int pa2;

	private bool trans;

	private int pX;

	private int pY;

	private T22 left = new T22(mResources.SELECT, 0);

	public int type;

	public int currentTabIndex;

	public int startTabPos;

	public int[] lastTabIndex;

	public string[][] currentTabName;

	private int[] currClanOption;

	public int mainTabPos = 4;

	public int shopTabPos = 50;

	public int boxTabPos = 50;

	public string[][] mainTabName;

	public string[] mapNames;

	public string[] planetNames;

	public static string[] strTool;

	public static string[] strCauhinh;

	public static string[] strAccount;

	public static string[] strAuto;

	public static int graphics;

	public string[][] shopTabName;

	public int[] maxPageShop;

	public int[] currPageShop;

	private static string[][] boxTabName;

	private static string[][] boxCombine;

	private static string[][] boxZone;

	private static string[][] boxMap;

	private static string[][] boxGD;

	private static string[][] boxPet;

	public string[][][] tabName = new string[27][][]
	{
		null,
		null,
		boxTabName,
		boxZone,
		boxMap,
		null,
		null,
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		boxCombine,
		boxGD,
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		boxPet,
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } }
	};

	private static sbyte BOX_BAG;

	private static sbyte BAG_BOX;

	private static sbyte BOX_BODY;

	private static sbyte BODY_BOX;

	private static sbyte BAG_BODY;

	private static sbyte BODY_BAG;

	private static sbyte BAG_PET;

	private static sbyte PET_BAG;

	public int hasUse;

	public int hasUseBag;

	public int currentListLength;

	private int[] lastSelect;

	public static int[] mapIdTraidat;

	public static int[] mapXTraidat;

	public static int[] mapYTraidat;

	public static int[] mapIdNamek;

	public static int[] mapXNamek;

	public static int[] mapYNamek;

	public static int[] mapIdSaya;

	public static int[] mapXSaya;

	public static int[] mapYSaya;

	public static int[][] mapId;

	public static int[][] mapX;

	public static int[][] mapY;

	public T79 currItem;

	public T16 currClan;

	public T19 currMess;

	public T95 currMem;

	public T16[] clans;

	public T117 member;

	public T117 myMember;

	public T117 logChat = new T117();

	public T117 vPlayerMenu = new T117();

	public T117 vFriend = new T117();

	public T117 vMyGD = new T117();

	public T117 vFriendGD = new T117();

	public T117 vTop = new T117();

	public T117 vEnemy = new T117();

	public T117 vFlag = new T117();

	public T22 cmdClose;

	public static bool CanNapTien;

	public static int WIDTH_PANEL;

	private int position;

	public T13 charMenu;

	private bool isThachDau;

	public int typeShop = -1;

	public int xScroll;

	public int yScroll;

	public int wScroll;

	public int hScroll;

	public T14 cp;

	public int idIcon;

	public int[] partID;

	private int timeShow;

	public bool isBoxClan;

	public int w;

	private int pa;

	public int selected;

	private int cSelected;

	private int newSelected;

	private bool isClanOption;

	public bool isSearchClan;

	public bool isMessage;

	public bool isViewMember;

	public const int TYPE_MAIN = 0;

	public const int TYPE_SHOP = 1;

	public const int TYPE_BOX = 2;

	public const int TYPE_ZONE = 3;

	public const int TYPE_MAP = 4;

	public const int TYPE_CLANS = 5;

	public const int TYPE_INFOMATION = 6;

	public const int TYPE_BODY = 7;

	public const int TYPE_MESS = 8;

	public const int TYPE_ARCHIVEMENT = 9;

	public const int PLAYER_MENU = 10;

	public const int TYPE_FRIEND = 11;

	public const int TYPE_COMBINE = 12;

	public const int TYPE_GIAODICH = 13;

	public const int TYPE_MAPTRANS = 14;

	public const int TYPE_TOP = 15;

	public const int TYPE_ENEMY = 16;

	public const int TYPE_KIGUI = 17;

	public const int TYPE_FLAG = 18;

	public const int TYPE_OPTION = 19;

	public const int TYPE_ACCOUNT = 20;

	public const int TYPE_PET_MAIN = 21;

	public const int TYPE_AUTO = 22;

	public const int TYPE_GAMEINFO = 23;

	public const int TYPE_GAMEINFOSUB = 24;

	public const int TYPE_SPEACIALSKILL = 25;

	private int pointerDownTime;

	private int pointerDownFirstX;

	private int[] pointerDownLastX = new int[3];

	private bool pointerIsDowning;

	private bool isDownWhenRunning;

	private bool wantUpdateList;

	private int waitToPerform;

	private int cmRun;

	private int keyTouchLock = -1;

	private int keyToundGD = -1;

	private int keyTouchCombine = -1;

	private int keyTouchMapButton = -1;

	public int indexMouse = -1;

	private bool justRelease;

	private int keyTouchTab = -1;

	public string[][] clansOption;

	public string clanInfo = string.Empty;

	public string clanReport = string.Empty;

	private bool isHaveClan;

	private T140 scroll;

	private int cmvx;

	private int cmdx;

	private bool isSelectPlayerMenu;

	private string[] strStatus = new string[6]
	{
		mResources.follow,
		mResources.defend,
		mResources.attack,
		mResources.gohome,
		mResources.fusion,
		mResources.fusionForever
	};

	private int currentButtonPress;

	private int[] zoneColor = new int[3] { 43520, 14743570, 14155776 };

	public string[] combineInfo;

	public string[] combineTopInfo;

	public static int[] color1;

	public static int[] color2;

	private bool isUp;

	private int compare;

	public static string strWantToBuy;

	public int xstart;

	public int ystart;

	public int popupW = 140;

	public int popupH = 160;

	public int cmySK;

	public int cmtoYSK;

	public int cmdySK;

	public int cmvySK;

	public int cmyLimSK;

	public int popupY;

	public int popupX;

	public int isborderIndex;

	public int isselectedRow;

	public int indexSize = 28;

	public int indexTitle;

	public int indexSelect;

	public int indexRow = -1;

	public int indexRowMax;

	public int indexMenu;

	public int columns = 6;

	public int rows;

	public int inforX;

	public int inforY;

	public int inforW;

	public int inforH;

	private int yPaint;

	private int xMap;

	private int yMap;

	private int xMapTask;

	private int yMapTask;

	private int xMove;

	private int yMove;

	public static bool isPaintMap;

	public bool isClose;

	private int infoSelect;

	public static T117 vGameInfo;

	public static string[] contenInfo;

	public bool isViewChatServer;

	private int currInfoItem;

	public T13 charInfo;

	private bool isChangeZone;

	private bool isKiguiXu;

	private bool isKiguiLuong;

	private int delayKigui;

	public sbyte combineSuccess = -1;

	public int idNPC;

	public int xS;

	public int yS;

	private int rS;

	private int angleS;

	private int angleO;

	private int iAngleS;

	private int iDotS;

	private int speed;

	private int[] xArgS;

	private int[] yArgS;

	private int[] xDotS;

	private int[] yDotS;

	private int time;

	private int typeCombine;

	private int countUpdate;

	private int countR;

	private int countWait;

	private bool isSpeedCombine;

	private bool isCompleteEffCombine = true;

	private bool isPaintCombine;

	public bool isDoneCombine = true;

	public short iconID1;

	public short iconID2;

	public short iconID3;

	public short[] iconID;

	public string[][] speacialTabName;

	public static int[] sizeUpgradeEff;

	public static int nsize;

	public const sbyte COLOR_WHITE = 0;

	public const sbyte COLOR_GREEN = 1;

	public const sbyte COLOR_PURPLE = 2;

	public const sbyte COLOR_ORANGE = 3;

	public const sbyte COLOR_BLUE = 4;

	public const sbyte COLOR_YELLOW = 5;

	public const sbyte COLOR_RED = 6;

	public const sbyte COLOR_BLACK = 7;

	public static int[][] colorUpgradeEffect;

	public const int color_item_white = 15987701;

	public const int color_item_green = 2786816;

	public const int color_item_purple = 7078041;

	public const int color_item_orange = 12537346;

	public const int color_item_blue = 1269146;

	public const int color_item_yellow = 13279744;

	public const int color_item_red = 11599872;

	public const int color_item_black = 2039326;

	private T60 imgo_0;

	private T60 imgo_1;

	private T60 imgo_2;

	private T60 imgo_3;

	public const int numItem = 20;

	public const sbyte INVENTORY_TAB = 1;

	public sbyte size_tab;

	public T126()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M1241();
		cmdClose = new T22(string.Empty, this, 1003, null);
		cmdClose.img = T51.M503("/mainImage/myTexture2dbtX.png");
		cmdClose.cmdClosePanel = true;
	}

	static T126()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		strTool = new string[7]
		{
			mResources.gameInfo,
			mResources.change_flag,
			mResources.change_zone,
			mResources.chat_world,
			mResources.account,
			mResources.option,
			mResources.change_account
		};
		strCauhinh = new string[4]
		{
			(!T51.isPlaySound) ? mResources.turnOnSound : mResources.turnOffSound,
			mResources.increase_vga,
			mResources.analog,
			(T99.zoomLevel <= 1) ? mResources.x2Screen : mResources.x1Screen
		};
		strAccount = new string[5]
		{
			mResources.inventory_Pass,
			mResources.friend,
			mResources.enemy,
			mResources.msg,
			mResources.charger
		};
		strAuto = new string[1] { mResources.useGem };
		graphics = 0;
		boxTabName = new string[2][]
		{
			mResources.chestt,
			mResources.inventory
		};
		boxCombine = new string[2][]
		{
			mResources.combine,
			mResources.inventory
		};
		boxZone = new string[1][] { mResources.zonee };
		boxMap = new string[1][] { mResources.mapp };
		boxGD = new string[3][]
		{
			mResources.inventory,
			mResources.item_give,
			mResources.item_receive
		};
		boxPet = mResources.petMainTab;
		BOX_BAG = 0;
		BAG_BOX = 1;
		BOX_BODY = 2;
		BODY_BOX = 3;
		BAG_BODY = 4;
		BODY_BAG = 5;
		BAG_PET = 6;
		PET_BAG = 7;
		mapIdTraidat = new int[16]
		{
			21, 0, 1, 2, 24, 3, 4, 5, 6, 27,
			28, 29, 30, 42, 47, 46
		};
		mapXTraidat = new int[16]
		{
			39, 42, 105, 93, 61, 93, 142, 165, 210, 100,
			165, 220, 233, 10, 125, 125
		};
		mapYTraidat = new int[16]
		{
			28, 60, 48, 96, 88, 131, 136, 95, 32, 200,
			189, 167, 120, 110, 20, 20
		};
		mapIdNamek = new int[14]
		{
			22, 7, 8, 9, 25, 11, 12, 13, 10, 31,
			32, 33, 34, 43
		};
		mapXNamek = new int[14]
		{
			55, 30, 93, 80, 24, 149, 219, 220, 233, 170,
			148, 195, 148, 10
		};
		mapYNamek = new int[14]
		{
			136, 84, 69, 34, 25, 42, 32, 110, 192, 70,
			106, 156, 210, 57
		};
		mapIdSaya = new int[14]
		{
			23, 14, 15, 16, 26, 17, 18, 20, 19, 35,
			36, 37, 38, 44
		};
		mapXSaya = new int[14]
		{
			90, 95, 144, 234, 231, 122, 176, 158, 205, 54,
			105, 159, 231, 27
		};
		mapYSaya = new int[14]
		{
			10, 43, 20, 36, 69, 87, 112, 167, 160, 151,
			173, 207, 194, 29
		};
		mapId = new int[3][] { mapIdTraidat, mapIdNamek, mapIdSaya };
		mapX = new int[3][] { mapXTraidat, mapXNamek, mapXSaya };
		mapY = new int[3][] { mapYTraidat, mapYNamek, mapYSaya };
		CanNapTien = false;
		WIDTH_PANEL = 240;
		color1 = new int[3] { 2327248, 8982199, 16713222 };
		color2 = new int[3] { 4583423, 16719103, 16714764 };
		strWantToBuy = string.Empty;
		isPaintMap = true;
		vGameInfo = new T117(string.Empty);
		sizeUpgradeEff = new int[3] { 2, 1, 1 };
		nsize = 1;
		colorUpgradeEffect = new int[7][]
		{
			new int[6] { 16777215, 15000805, 13487823, 11711155, 9671828, 7895160 },
			new int[6] { 61952, 58624, 52224, 45824, 39168, 32768 },
			new int[6] { 13500671, 12058853, 10682572, 9371827, 7995545, 6684800 },
			new int[6] { 16744192, 15037184, 13395456, 11753728, 10046464, 8404992 },
			new int[6] { 37119, 33509, 28108, 24499, 21145, 17536 },
			new int[6] { 16776192, 15063040, 12635136, 11776256, 10063872, 8290304 },
			new int[6] { 16711680, 15007744, 13369344, 11730944, 10027008, 8388608 }
		};
	}

	public static void M1240()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		imgMap = T51.M503("/img/map" + T174.planetID + ".png");
		imgBantay = T51.M503("/mainImage/myTexture2dbantay.png");
		imgX = T51.M503("/mainImage/myTexture2dbtX.png");
		imgXu = T51.M503("/mainImage/myTexture2dimgMoney.png");
		imgLuong = T51.M503("/mainImage/myTexture2dimgDiamond.png");
		imgLuongKhoa = T51.M503("/mainImage/luongkhoa.png");
		imgUp = T51.M503("/mainImage/myTexture2dup.png");
		imgDown = T51.M503("/mainImage/myTexture2ddown.png");
		imgStar = T51.M503("/mainImage/star.png");
		imgMaxStar = T51.M503("/mainImage/starE.png");
		imgStar8 = T51.M503("/mainImage/star8.png");
		imgNew = T51.M503("/mainImage/new.png");
		imgTicket = T51.M503("/mainImage/ticket12.png");
	}

	public void M1241()
	{
		pX = T51.pxLast + cmxMap;
		pY = T51.pyLast + cmyMap;
		lastTabIndex = new int[tabName.Length];
		for (int i = 0; i < lastTabIndex.Length; i++)
		{
			lastTabIndex[i] = -1;
		}
	}

	public int M1242()
	{
		for (int i = 0; i < mapId[T174.planetID].Length; i++)
		{
			if (T174.mapID == mapId[T174.planetID][i])
			{
				return mapX[T174.planetID][i];
			}
		}
		return -1;
	}

	public int M1243()
	{
		for (int i = 0; i < mapId[T174.planetID].Length; i++)
		{
			if (T174.mapID == mapId[T174.planetID][i])
			{
				return mapY[T174.planetID][i];
			}
		}
		return -1;
	}

	public int M1244()
	{
		if (T13.M113().taskMaint == null)
		{
			return -1;
		}
		for (int i = 0; i < mapId[T174.planetID].Length; i++)
		{
			if (T54.mapTasks[T13.M113().taskMaint.index] == mapId[T174.planetID][i])
			{
				return mapX[T174.planetID][i];
			}
		}
		return -1;
	}

	public int M1245()
	{
		if (T13.M113().taskMaint == null)
		{
			return -1;
		}
		for (int i = 0; i < mapId[T174.planetID].Length; i++)
		{
			if (T54.mapTasks[T13.M113().taskMaint.index] == mapId[T174.planetID][i])
			{
				return mapY[T174.planetID][i];
			}
		}
		return -1;
	}

	private void M1246(int position)
	{
		typeShop = -1;
		W = WIDTH_PANEL;
		H = T51.h;
		X = 0;
		Y = 0;
		ITEM_HEIGHT = 24;
		this.position = position;
		switch (position)
		{
		case 1:
			wScroll = W - 4;
			xScroll = T51.w - wScroll;
			yScroll = 80;
			hScroll = H - 96;
			X = xScroll - 2;
			cmx = -(T51.w + W);
			cmtoX = T51.w - W;
			break;
		case 0:
			xScroll = 2;
			yScroll = 80;
			wScroll = W - 4;
			hScroll = H - 96;
			cmx = wScroll;
			cmtoX = 0;
			X = 0;
			break;
		}
		TAB_W = W / 5 - 1;
		currentTabIndex = 0;
		currentTabName = tabName[type];
		if (currentTabName.Length < 5)
		{
			TAB_W += 5;
		}
		startTabPos = xScroll + wScroll / 2 - currentTabName.Length * TAB_W / 2;
		lastSelect = new int[currentTabName.Length];
		cmyLast = new int[currentTabName.Length];
		for (int i = 0; i < currentTabName.Length; i++)
		{
			lastSelect[i] = (T51.isTouch ? (-1) : 0);
		}
		if (lastTabIndex[type] != -1)
		{
			currentTabIndex = lastTabIndex[type];
		}
		if (currentTabIndex < 0)
		{
			currentTabIndex = 0;
		}
		if (currentTabIndex > currentTabName.Length - 1)
		{
			currentTabIndex = currentTabName.Length - 1;
		}
		scroll = null;
	}

	public void M1247()
	{
		type = 14;
		M1246(0);
		M1319();
		cmtoX = 0;
		cmx = 0;
	}

	public void M1248()
	{
		type = 6;
		cmx = wScroll;
		cmtoX = 0;
	}

	public void M1249()
	{
		if (!T54.M559().M536() && isPaintMap)
		{
			if (T55.M692(2, 0))
			{
				T55.isViewMap = true;
				T54.info1.M762(mResources.go_to_quest, 0);
			}
			type = 4;
			currentTabName = tabName[type];
			startTabPos = xScroll + wScroll / 2 - currentTabName.Length * TAB_W / 2;
			cmtoX = 0;
			cmx = 0;
			M1324();
		}
	}

	public void M1250()
	{
		currentListLength = T13.M113().arrArchive.Length;
		M1246(0);
		type = 9;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmtoY = 0;
			cmy = 0;
		}
		selected = (T51.isTouch ? (-1) : 0);
	}

	public void M1251()
	{
		type = 17;
		M1246(1);
		M1252();
		typeShop = 2;
		currentTabIndex = 0;
	}

	public void M1252()
	{
		ITEM_HEIGHT = 24;
		currentListLength = T13.M113().arrItemShop[4].Length;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		selected = (T51.isTouch ? (-1) : 0);
	}

	public void M1253()
	{
		type = 7;
		M1246(1);
		M1323(resetSelect: true);
		currentTabIndex = 0;
	}

	public void M1254(T67 info)
	{
		logChat.M1121(info, 0);
		if (logChat.M1113() > 20)
		{
			logChat.M1118(logChat.M1113() - 1);
		}
	}

	public void M1255(T22 pm)
	{
		vPlayerMenu.M1111(pm);
	}

	public void M1256()
	{
		ITEM_HEIGHT = 24;
		currentListLength = vPlayerMenu.M1113();
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		selected = (T51.isTouch ? (-1) : 0);
	}

	public void M1257()
	{
		type = 18;
		M1246(0);
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		M1258();
	}

	public void M1258()
	{
		currentListLength = vFlag.M1113();
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		if (selected > currentListLength - 1)
		{
			selected = currentListLength - 1;
		}
		cmtoX = 0;
		cmx = 0;
	}

	public void M1259(T13 c)
	{
		type = 10;
		M1246(0);
		M1256();
		charMenu = c;
	}

	public void M1260()
	{
		type = 11;
		M1246(0);
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		M1264();
	}

	public void M1261()
	{
		type = 16;
		M1246(0);
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		M1265();
	}

	public void M1262(sbyte t)
	{
		type = 15;
		M1246(0);
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		M1263();
		isThachDau = ((t != 0) ? true : false);
	}

	public void M1263()
	{
		currentListLength = vTop.M1113();
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		if (selected > currentListLength - 1)
		{
			selected = currentListLength - 1;
		}
		cmtoX = 0;
		cmx = 0;
	}

	public void M1264()
	{
		currentListLength = vFriend.M1113();
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		if (selected > currentListLength - 1)
		{
			selected = currentListLength - 1;
		}
		cmtoX = 0;
		cmx = 0;
	}

	public void M1265()
	{
		currentListLength = vEnemy.M1113();
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		if (selected > currentListLength - 1)
		{
			selected = currentListLength - 1;
		}
		cmtoX = 0;
		cmx = 0;
	}

	public void M1266()
	{
		type = 8;
		M1246(0);
		M1316();
		currentTabIndex = 0;
	}

	public void M1267()
	{
		type = 8;
		M1246(0);
		M1316();
		currentTabIndex = 0;
	}

	public void M1268(int typeShop)
	{
		type = 1;
		M1246(0);
		M1317();
		currentTabIndex = 0;
		this.typeShop = typeShop;
	}

	public void M1269()
	{
		type = 2;
		if (T51.w > 2 * WIDTH_PANEL)
		{
			boxTabName = new string[1][] { mResources.chestt };
		}
		else
		{
			boxTabName = new string[2][]
			{
				mResources.chestt,
				mResources.inventory
			};
		}
		tabName[2] = boxTabName;
		M1246(0);
		if (currentTabIndex == 0)
		{
			M1321();
		}
		if (currentTabIndex == 1)
		{
			M1323(resetSelect: true);
		}
		if (T51.w > 2 * WIDTH_PANEL)
		{
			T51.panel2 = new T126();
			T51.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
			T51.panel2.M1253();
			T51.panel2.M1285();
		}
	}

	public void M1270()
	{
		type = 12;
		if (T51.w > 2 * WIDTH_PANEL)
		{
			boxCombine = new string[1][] { mResources.combine };
		}
		else
		{
			boxCombine = new string[2][]
			{
				mResources.combine,
				mResources.inventory
			};
		}
		tabName[type] = boxCombine;
		M1246(0);
		if (currentTabIndex == 0)
		{
			M1271();
		}
		if (currentTabIndex == 1)
		{
			M1323(resetSelect: true);
		}
		if (T51.w > 2 * WIDTH_PANEL)
		{
			T51.panel2 = new T126();
			T51.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
			T51.panel2.M1253();
			T51.panel2.M1285();
		}
		combineSuccess = -1;
		isDoneCombine = true;
	}

	public void M1271()
	{
		currentListLength = vItemCombine.M1113() + 1;
		ITEM_HEIGHT = 24;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 9;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		selected = (T51.isTouch ? (-1) : 0);
	}

	public void M1272()
	{
		type = 22;
		M1246(0);
		M1273();
		cmtoX = 0;
		cmx = 0;
	}

	private void M1273()
	{
		currentListLength = strAuto.Length;
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
	}

	public void M1274()
	{
		type = 21;
		if (T51.panel2 != null)
		{
			boxPet = mResources.petMainTab2;
		}
		else
		{
			boxPet = mResources.petMainTab;
		}
		tabName[21] = boxPet;
		if (T13.M113().cgender == 1)
		{
			strStatus = new string[6]
			{
				mResources.follow,
				mResources.defend,
				mResources.attack,
				mResources.gohome,
				mResources.fusion,
				mResources.fusionForever
			};
		}
		else
		{
			strStatus = new string[5]
			{
				mResources.follow,
				mResources.defend,
				mResources.attack,
				mResources.gohome,
				mResources.fusion
			};
		}
		M1246(2);
		if (currentTabIndex == 0)
		{
			M1322();
		}
		if (currentTabIndex == 1)
		{
			M1310();
		}
		if (currentTabIndex == 2)
		{
			M1323(resetSelect: true);
		}
	}

	public void M1275()
	{
		type = 0;
		M1246(0);
		if (currentTabIndex == 1)
		{
			M1323(resetSelect: true);
		}
		if (currentTabIndex == 2)
		{
			M1318();
		}
		if (currentTabIndex == 3)
		{
			if (mainTabName.Length == 4)
			{
				M1312();
			}
			else
			{
				M1314();
			}
		}
		if (currentTabIndex == 4)
		{
			M1312();
		}
	}

	public void M1276()
	{
		type = 3;
		M1246(0);
		M1320();
		cmtoX = 0;
		cmx = 0;
	}

	public void M1277(T79 item)
	{
		cp = new T14();
		string empty = string.Empty;
		string text = string.Empty;
		if (item.template.gender != T13.M113().cgender)
		{
			if (item.template.gender == 0)
			{
				text = text + "\n|7|1|" + mResources.from_earth;
			}
			else if (item.template.gender == 1)
			{
				text = text + "\n|7|1|" + mResources.from_namec;
			}
			else if (item.template.gender == 2)
			{
				text = text + "\n|7|1|" + mResources.from_sayda;
			}
		}
		string text2 = string.Empty;
		if (item.itemOption != null)
		{
			for (int i = 0; i < item.itemOption.Length; i++)
			{
				if (item.itemOption[i].optionTemplate.id == 72)
				{
					text2 = " [+" + item.itemOption[i].param + "]";
				}
			}
		}
		bool flag = false;
		if (item.itemOption != null)
		{
			for (int j = 0; j < item.itemOption.Length; j++)
			{
				if (item.itemOption[j].optionTemplate.id == 41)
				{
					flag = true;
					if (item.itemOption[j].param == 1)
					{
						text = text + "|0|1|" + item.template.name + text2;
					}
					if (item.itemOption[j].param == 2)
					{
						text = text + "|2|1|" + item.template.name + text2;
					}
					if (item.itemOption[j].param == 3)
					{
						text = text + "|8|1|" + item.template.name + text2;
					}
					if (item.itemOption[j].param == 4)
					{
						text = text + "|7|1|" + item.template.name + text2;
					}
				}
			}
		}
		if (!flag)
		{
			text = text + "|0|1|" + item.template.name + text2;
		}
		if (item.itemOption != null)
		{
			for (int k = 0; k < item.itemOption.Length; k++)
			{
				if (item.itemOption[k].optionTemplate.name.StartsWith("$") ? true : false)
				{
					empty = item.itemOption[k].M832();
					if (item.itemOption[k].param == 1)
					{
						text = text + "\n|1|1|" + empty;
					}
					if (item.itemOption[k].param == 0)
					{
						text = text + "\n|0|1|" + empty;
					}
					continue;
				}
				empty = item.itemOption[k].M830();
				if (!empty.Equals(string.Empty) && item.itemOption[k].optionTemplate.id != 72)
				{
					if (item.itemOption[k].optionTemplate.id == 102)
					{
						cp.starSlot = (sbyte)item.itemOption[k].param;
						T137.M1513("STAR SLOT= " + cp.starSlot);
					}
					else if (item.itemOption[k].optionTemplate.id == 107)
					{
						cp.maxStarSlot = (sbyte)item.itemOption[k].param;
						T137.M1513("STAR SLOT= " + cp.maxStarSlot);
					}
					else
					{
						text = text + "\n|1|1|" + empty;
					}
				}
			}
		}
		if (currItem.template.strRequire > 1)
		{
			string text3 = mResources.pow_request + ": " + currItem.template.strRequire;
			if (currItem.template.strRequire > T13.M113().cPower)
			{
				string text4 = text + "\n|3|1|" + text3;
				text = text4 + "\n|3|1|" + mResources.your_pow + ": " + T13.M113().cPower;
			}
			else
			{
				text = text + "\n|6|1|" + text3;
			}
		}
		else
		{
			text += "\n|6|1|";
		}
		currItem.compare = M1365(currItem);
		text = string.Concat(text + "\n--", "\n|6|", item.template.description);
		if (!item.reason.Equals(string.Empty))
		{
			if (!item.template.description.Equals(string.Empty))
			{
				text += "\n--";
			}
			text = text + "\n|2|" + item.reason;
		}
		if (cp.maxStarSlot > 0)
		{
			text += "\n\n";
		}
		M1278(cp, text);
		idIcon = item.template.iconID;
		partID = null;
		charInfo = null;
	}

	public void M1278(T14 cp, string chat)
	{
		cp.isClip = false;
		cp.sayWidth = 180;
		cp.cx = 3 + X - ((X != 0) ? (T137.M1529(cp.sayWidth - W) + 8) : 0);
		cp.says = T98.tahoma_7_red.M907(chat, cp.sayWidth - 10);
		cp.delay = 10000000;
		cp.c = null;
		cp.sayRun = 7;
		cp.ch = 15 - cp.sayRun + cp.says.Length * 12 + 10;
		if (cp.ch > T51.h - 80)
		{
			cp.ch = T51.h - 80;
			cp.lim = cp.says.Length * 12 - cp.ch + 17;
			if (cp.lim < 0)
			{
				cp.lim = 0;
			}
			T14.cmyText = 0;
			cp.isClip = true;
		}
		cp.cy = T51.menu.menuY - cp.ch;
		while (cp.cy < 10)
		{
			cp.cy++;
			T51.menu.menuY++;
		}
		cp.mH = 0;
		cp.strY = 10;
	}

	public void M1279(T14 cp, string[] chat)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		cp.sayWidth = 160;
		cp.cx = 3 + X;
		cp.says = chat;
		cp.delay = 10000000;
		cp.c = null;
		cp.sayRun = 7;
		cp.ch = 15 - cp.sayRun + cp.says.Length * 12 + 10;
		cp.cy = T51.menu.menuY - cp.ch;
		cp.mH = 0;
		cp.strY = 10;
	}

	public void M1280(T19 cm)
	{
		cp = new T14();
		string text = string.Concat("|0|" + cm.playerName, "\n|1|", T95.M873(cm.role));
		for (int i = 0; i < myMember.M1113(); i++)
		{
			T95 t = (T95)myMember.M1114(i);
			if (cm.playerId == t.ID)
			{
				string text2 = text;
				text2 = text2 + "\n|5|" + mResources.clan_capsuledonate + ": " + t.clanPoint;
				text2 = text2 + "\n|5|" + mResources.clan_capsuleself + ": " + t.curClanPoint;
				text2 = text2 + "\n|4|" + mResources.give_pea + ": " + t.donate + mResources.time;
				text = text2 + "\n|4|" + mResources.receive_pea + ": " + t.receive_donate + mResources.time;
				partID = new int[3] { t.head, t.leg, t.body };
				break;
			}
		}
		text += "\n--";
		for (int j = 0; j < cm.chat.Length; j++)
		{
			text = text + "\n" + cm.chat[j];
		}
		if (cm.type == 1)
		{
			string text3 = text;
			text = text3 + "\n|6|" + mResources.received + " " + cm.recieve + "/" + cm.maxCap;
		}
		M1278(cp, text);
		charInfo = null;
	}

	public void M1281(T176 t)
	{
		string chat = string.Concat(string.Concat(string.Concat("|0|1|" + t.name, "\n|1|Top ", t.rank), "\n|1|", t.info), "\n|2|", t.info2);
		cp = new T14();
		M1278(cp, chat);
		partID = new int[3] { t.headID, t.leg, t.body };
		currItem = null;
		charInfo = null;
	}

	public void M1282(T95 m)
	{
		string text = "|0|1|" + m.name;
		string text2 = "\n|2|1|";
		if (m.role == 0)
		{
			text2 = "\n|7|1|";
		}
		if (m.role == 1)
		{
			text2 = "\n|1|1|";
		}
		if (m.role == 2)
		{
			text2 = "\n|0|1|";
		}
		string text3 = text + text2 + T95.M873(m.role);
		text3 = string.Concat(text3 + "\n|2|1|" + mResources.power + ": " + m.powerPoint, "\n--");
		text3 = text3 + "\n|5|" + mResources.clan_capsuledonate + ": " + m.clanPoint;
		text3 = text3 + "\n|5|" + mResources.clan_capsuleself + ": " + m.curClanPoint;
		text3 = text3 + "\n|4|" + mResources.give_pea + ": " + m.donate + mResources.time;
		text3 = text3 + "\n|4|" + mResources.receive_pea + ": " + m.receive_donate + mResources.time;
		text = text3 + "\n|6|" + mResources.join_date + ": " + m.joinTime;
		cp = new T14();
		M1278(cp, text);
		partID = new int[3] { m.head, m.leg, m.body };
		currItem = null;
		charInfo = null;
	}

	public void M1283(T16 cl)
	{
		string text = "|0|" + cl.name;
		string[] array = T98.tahoma_7_green.M907(cl.slogan, wScroll - 60);
		for (int i = 0; i < array.Length; i++)
		{
			text = text + "\n|2|" + array[i];
		}
		string text2 = text + "\n--";
		text2 = text2 + "\n|7|" + mResources.clan_leader + ": " + cl.leaderName;
		text2 = text2 + "\n|1|" + mResources.power_point + ": " + cl.powerPoint;
		text2 = text2 + "\n|4|" + mResources.member + ": " + cl.currMember + "/" + cl.maxMember;
		text2 = text2 + "\n|4|" + mResources.level + ": " + cl.level;
		text = text2 + "\n|4|" + mResources.clan_birthday + ": " + T122.M1189(cl.date);
		cp = new T14();
		M1278(cp, text);
		idIcon = T17.M288((sbyte)cl.imgID).idImage[0];
		currItem = null;
	}

	public void M1284(T155 tp, T149 skill, T149 nextSkill)
	{
		string text = "|0|" + tp.name;
		for (int i = 0; i < tp.description.Length; i++)
		{
			text = text + "\n|4|" + tp.description[i];
		}
		text += "\n--";
		if (skill != null)
		{
			string text2 = text;
			text2 = string.Concat(text2 + "\n|2|" + mResources.cap_do + ": " + skill.point, "\n|5|", T122.M1187(tp.damInfo, "#", skill.damage + string.Empty));
			text2 = text2 + "\n|5|" + mResources.KI_consume + skill.manaUse + ((tp.manaUseType != 1) ? string.Empty : "%");
			text = string.Concat(text2 + "\n|5|" + mResources.speed + ": " + skill.coolDown + mResources.milisecond, "\n--");
			if (skill.point == tp.maxPoint)
			{
				text = text + "\n|0|" + mResources.max_level_reach;
			}
			else
			{
				text2 = text;
				text = string.Concat(text2 + "\n|1|" + mResources.next_level_require + T137.M1532(nextSkill.powRequire) + " " + mResources.potential, "\n|4|", T122.M1187(tp.damInfo, "#", nextSkill.damage + string.Empty));
			}
		}
		else
		{
			string text3 = text + "\n|2|" + mResources.not_learn;
			text3 = string.Concat(text3 + "\n|1|" + mResources.learn_require + T137.M1532(nextSkill.powRequire) + " " + mResources.potential, "\n|4|", T122.M1187(tp.damInfo, "#", nextSkill.damage + string.Empty));
			text3 = text3 + "\n|4|" + mResources.KI_consume + nextSkill.manaUse + ((tp.manaUseType != 1) ? string.Empty : "%");
			text = text3 + "\n|4|" + mResources.speed + ": " + nextSkill.coolDown + mResources.milisecond;
		}
		currItem = null;
		partID = null;
		charInfo = null;
		cp = new T14();
		M1278(cp, text);
		idIcon = 0;
	}

	public void M1285()
	{
		if (T51.isTouch)
		{
			cmdClose.x = 156;
			cmdClose.y = 3;
		}
		else
		{
			cmdClose.x = T51.w - 19;
			cmdClose.y = T51.h - 19;
		}
		cmdClose.isPlaySoundButton = false;
		T14.currChatPopup = null;
		T66.M753();
		timeShow = 20;
		isShow = true;
		isClose = false;
		T160.M1826().M1855();
		if (M1443())
		{
			T13.M113().M242();
		}
	}

	public void M1286()
	{
		if (chatTField != null && chatTField.isShow)
		{
			if (chatTField.left != null && (T51.keyPressed[12] || T108.M1034(chatTField.left)) && chatTField.left != null)
			{
				chatTField.left.M294();
			}
			if (chatTField.right != null && (T51.keyPressed[13] || T108.M1034(chatTField.right)) && chatTField.right != null)
			{
				chatTField.right.M294();
			}
			if (chatTField.center != null && (T51.keyPressed[(!Main.isPC) ? 5 : 25] || T108.M1034(chatTField.center)) && chatTField.center != null)
			{
				chatTField.center.M294();
			}
			if (chatTField.isShow && T51.keyAsciiPress != 0)
			{
				chatTField.M278(T51.keyAsciiPress);
				T51.keyAsciiPress = 0;
			}
			T51.M484();
			T51.M483();
		}
	}

	public void M1287()
	{
		if ((chatTField != null && chatTField.isShow) || !T51.panel.isDoneCombine || T66.isShow)
		{
			return;
		}
		if (tabIcon != null && tabIcon.isShow)
		{
			tabIcon.M1893();
		}
		else
		{
			if (isClose || !isShow)
			{
				return;
			}
			if (cmdClose.M298())
			{
				cmdClose.M294();
				return;
			}
			if (T51.keyPressed[13])
			{
				if (type != 4)
				{
					M1382();
					return;
				}
				M1275();
				cmtoX = 0;
				cmx = 0;
			}
			if (T51.keyPressed[12] || T51.keyPressed[(!Main.isPC) ? 5 : 25])
			{
				if (left.idAction > 0)
				{
					perform(left.idAction, left.p);
				}
				else
				{
					waitToPerform = 2;
				}
			}
			if (Equals(T51.panel) && T51.panel2 == null && T51.isPointerJustRelease && !T51.M516(X, Y, W, H) && !pointerIsDowning)
			{
				M1382();
				return;
			}
			if (!isClanOption)
			{
				M1309();
			}
			switch (type)
			{
			case 0:
				if (currentTabIndex == 0)
				{
					M1301();
					T51.M483();
					return;
				}
				if (currentTabIndex == 1)
				{
					M1458();
				}
				if (currentTabIndex == 2)
				{
					M1294();
				}
				if (currentTabIndex == 3)
				{
					if (mainTabName.Length == 4)
					{
						M1293();
					}
					else
					{
						M1304();
					}
				}
				if (currentTabIndex == 4)
				{
					M1293();
				}
				break;
			case 2:
				M1458();
				break;
			case 3:
				M1307();
				break;
			case 4:
				M1299();
				T51.M483();
				return;
			case 7:
				M1458();
				break;
			case 8:
				M1307();
				break;
			case 9:
				M1307();
				break;
			case 10:
				M1307();
				break;
			case 12:
				M1300();
				break;
			case 13:
				M1292();
				break;
			case 14:
				M1307();
				break;
			case 15:
				M1307();
				break;
			case 11:
			case 16:
				M1307();
				break;
			case 18:
				M1307();
				break;
			case 19:
				M1440();
				break;
			case 20:
				M1440();
				break;
			case 21:
				if (currentTabIndex == 0)
				{
					M1307();
				}
				if (currentTabIndex == 1)
				{
					M1289();
				}
				if (currentTabIndex == 2)
				{
					M1307();
				}
				break;
			case 22:
				M1288();
				break;
			case 23:
			case 24:
				M1307();
				break;
			case 1:
			case 17:
			case 25:
				if (currentTabIndex < currentTabName.Length - ((T51.panel2 == null) ? 1 : 0) && type != 17)
				{
					M1307();
				}
				else if (typeShop == 0)
				{
					M1458();
				}
				else
				{
					M1307();
				}
				break;
			}
			T51.M484();
			for (int i = 0; i < T51.keyPressed.Length; i++)
			{
				T51.keyPressed[i] = false;
			}
		}
	}

	private void M1288()
	{
	}

	private void M1289()
	{
		M1307();
	}

	private void M1290()
	{
	}

	private void M1291()
	{
		M1307();
	}

	private void M1292()
	{
		if (currentTabIndex == 0)
		{
			if (Equals(T51.panel))
			{
				M1458();
			}
			if (Equals(T51.panel2))
			{
				M1291();
			}
		}
		if (currentTabIndex == 1 || currentTabIndex == 2)
		{
			M1291();
		}
	}

	private void M1293()
	{
		M1307();
	}

	private void M1294()
	{
		M1307();
	}

	private void M1295()
	{
		M1307();
	}

	public void M1296(bool isMe)
	{
		currentListLength = ((!isMe) ? (vFriendGD.M1113() + 3) : (vMyGD.M1113() + 3));
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
	}

	public void M1297(T13 cGD)
	{
		type = 13;
		tabName[type] = boxGD;
		isAccept = false;
		isLock = false;
		isFriendLock = false;
		vMyGD.M1120();
		vFriendGD.M1120();
		moneyGD = 0;
		friendMoneyGD = 0;
		if (T51.w > 2 * WIDTH_PANEL)
		{
			T51.panel2 = new T126();
			T51.panel2.type = 13;
			T51.panel2.tabName[type] = new string[1][] { mResources.item_receive };
			T51.panel2.M1246(1);
			T51.panel2.M1296(isMe: false);
			T51.panel.tabName[type] = new string[2][]
			{
				mResources.inventory,
				mResources.item_give
			};
			T51.panel2.M1285();
			T51.panel2.charMenu = cGD;
		}
		if (Equals(T51.panel))
		{
			M1246(0);
		}
		if (currentTabIndex == 0)
		{
			M1323(resetSelect: true);
		}
		if (currentTabIndex == 1)
		{
			M1296(isMe: true);
		}
		if (currentTabIndex == 2)
		{
			M1296(isMe: false);
		}
		charMenu = cGD;
	}

	private void M1298(T99 g, bool isMe)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		T117 t = ((!isMe) ? vFriendGD : vMyGD);
		int num = 0;
		while (true)
		{
			if (num < currentListLength)
			{
				int num2 = xScroll + 36;
				int num3 = yScroll + num * ITEM_HEIGHT;
				int num4 = wScroll - 36;
				int num5 = ITEM_HEIGHT - 1;
				int num6 = xScroll;
				int num7 = yScroll + num * ITEM_HEIGHT;
				int num8 = 34;
				int num9 = ITEM_HEIGHT - 1;
				if (num3 - cmy <= yScroll + hScroll && num3 - cmy >= yScroll - ITEM_HEIGHT)
				{
					if (num == currentListLength - 1)
					{
						if (isMe)
						{
							g.M933(15196114);
							g.M932(num6, num3, wScroll, num5);
							if (!isLock)
							{
								if (!isFriendLock)
								{
									T98.tahoma_7_grey.M898(g, mResources.opponent + mResources.not_lock_trade, xScroll + wScroll / 2, num3 + num5 / 2 - 4, T98.CENTER);
								}
								else
								{
									T98.tahoma_7_grey.M898(g, mResources.opponent + mResources.locked_trade, xScroll + wScroll / 2, num3 + num5 / 2 - 4, T98.CENTER);
								}
							}
							else if (isFriendLock)
							{
								g.M933(15196114);
								g.M932(num6, num3, wScroll, num5);
								g.M948((num != selected) ? T54.imgLbtn2 : T54.imgLbtnFocus2, xScroll + wScroll - 5, num3 + 2, T163.TOP_RIGHT);
								((num != selected) ? T98.tahoma_7b_dark : T98.tahoma_7b_green2).M898(g, mResources.done, xScroll + wScroll - 22, num3 + 7, 2);
								T98.tahoma_7_grey.M898(g, mResources.opponent + mResources.locked_trade, xScroll + 5, num3 + num5 / 2 - 4, T98.LEFT);
							}
							else
							{
								T98.tahoma_7_grey.M898(g, mResources.opponent + mResources.not_lock_trade, xScroll + wScroll / 2, num3 + num5 / 2 - 4, T98.CENTER);
							}
						}
					}
					else if (num == currentListLength - 2)
					{
						if (isMe)
						{
							g.M933(15196114);
							g.M932(num6, num3, wScroll, num5);
							if (!isAccept)
							{
								if (!isLock)
								{
									g.M948((num != selected) ? T54.imgLbtn2 : T54.imgLbtnFocus2, xScroll + wScroll - 5, num3 + 2, T163.TOP_RIGHT);
									((num != selected) ? T98.tahoma_7b_dark : T98.tahoma_7b_green2).M898(g, mResources.mlock, xScroll + wScroll - 22, num3 + 7, 2);
									T98.tahoma_7_grey.M898(g, mResources.you + mResources.not_lock_trade, xScroll + 5, num3 + num5 / 2 - 4, T98.LEFT);
								}
								else
								{
									g.M948((num != selected) ? T54.imgLbtn2 : T54.imgLbtnFocus2, xScroll + wScroll - 5, num3 + 2, T163.TOP_RIGHT);
									((num != selected) ? T98.tahoma_7b_dark : T98.tahoma_7b_green2).M898(g, mResources.CANCEL, xScroll + wScroll - 22, num3 + 7, 2);
									T98.tahoma_7_grey.M898(g, mResources.you + mResources.locked_trade, xScroll + 5, num3 + num5 / 2 - 4, T98.LEFT);
								}
							}
						}
						else if (!isFriendLock)
						{
							T98.tahoma_7b_dark.M898(g, mResources.not_lock_trade_upper, xScroll + wScroll / 2, num3 + num5 / 2 - 4, T98.CENTER);
						}
						else
						{
							T98.tahoma_7b_dark.M898(g, mResources.locked_trade_upper, xScroll + wScroll / 2, num3 + num5 / 2 - 4, T98.CENTER);
						}
					}
					else if (num == currentListLength - 3)
					{
						if (isLock)
						{
							g.M933(13748667);
						}
						else
						{
							g.M933((num != selected) ? 15196114 : 16383818);
						}
						g.M932(num2, num3, num4, num5);
						if (isLock)
						{
							g.M933(13748667);
						}
						else
						{
							g.M933((num != selected) ? 9993045 : 7300181);
						}
						g.M932(num6, num7, num8, num9);
						g.M948(imgXu, num6 + num8 / 2, num7 + num9 / 2, 3);
						T98.tahoma_7_green2.M898(g, T122.M1192((!isMe) ? friendMoneyGD : moneyGD) + " " + mResources.XU, num2 + 5, num3 + 11, 0);
						T98.tahoma_7_green.M898(g, mResources.money_trade, num2 + 5, num3, 0);
					}
					else
					{
						if (t.M1113() == 0)
						{
							break;
						}
						if (isLock)
						{
							g.M933(13748667);
						}
						else
						{
							g.M933((num != selected) ? 15196114 : 16383818);
						}
						g.M932(num2, num3, num4, num5);
						if (isLock)
						{
							g.M933(13748667);
						}
						else
						{
							g.M933((num != selected) ? 9993045 : 9541120);
						}
						T79 t2 = (T79)t.M1114(num);
						if (t2 != null)
						{
							for (int i = 0; i < t2.itemOption.Length; i++)
							{
								if (t2.itemOption[i].optionTemplate.id != 72 || t2.itemOption[i].param <= 0)
								{
									continue;
								}
								sbyte id = M1449(t2.itemOption[i].param);
								if (M1448(id) != -1)
								{
									if (isLock)
									{
										g.M933(13748667);
									}
									else
									{
										g.M933((num != selected) ? M1448(id) : M1448(id));
									}
								}
							}
						}
						g.M932(num6, num7, num8, num9);
						if (t2 != null)
						{
							string text = string.Empty;
							T98 t3 = T98.tahoma_7_green2;
							if (t2.itemOption != null)
							{
								for (int j = 0; j < t2.itemOption.Length; j++)
								{
									if (t2.itemOption[j].optionTemplate.id == 72)
									{
										text = " [+" + t2.itemOption[j].param + "]";
										t2.M818(g, num6 + 18, num7 + 12, t2.itemOption[j].param);
									}
									if (t2.itemOption[j].optionTemplate.id == 41)
									{
										if (t2.itemOption[j].param == 1)
										{
											t3 = M1450(0);
										}
										else if (t2.itemOption[j].param == 2)
										{
											t3 = M1450(2);
										}
										else if (t2.itemOption[j].param == 3)
										{
											t3 = M1450(8);
										}
										else if (t2.itemOption[j].param == 4)
										{
											t3 = M1450(7);
										}
									}
								}
							}
							t3.M898(g, t2.template.name + text, num2 + 5, num3 + 1, 0);
							string text2 = string.Empty;
							if (t2.itemOption != null)
							{
								if (t2.itemOption.Length != 0 && t2.itemOption[0] != null)
								{
									text2 += t2.itemOption[0].M830();
								}
								T98 t4 = T98.tahoma_7_blue;
								if (t2.compare < 0 && t2.template.type != 5)
								{
									t4 = T98.tahoma_7_red;
								}
								if (t2.itemOption.Length > 1)
								{
									for (int k = 1; k < t2.itemOption.Length; k++)
									{
										if (t2.itemOption[k] != null && t2.itemOption[k].optionTemplate.id != 102 && t2.itemOption[k].optionTemplate.id != 107)
										{
											text2 = text2 + "," + t2.itemOption[k].M830();
										}
									}
								}
								t4.M898(g, text2, num2 + 5, num3 + 11, T98.LEFT);
							}
							T157.M1785(g, t2.template.iconID, num6 + num8 / 2, num7 + num9 / 2, 0, 3);
							if (t2.itemOption != null)
							{
								for (int l = 0; l < t2.itemOption.Length; l++)
								{
									M1451(g, t2.itemOption[l].optionTemplate.id, t2.itemOption[l].param, num6, num7, num8, num9);
								}
								for (int m = 0; m < t2.itemOption.Length; m++)
								{
									M1452(g, t2.itemOption[m].optionTemplate.id, t2.itemOption[m].param, num6, num7, num8, num9);
								}
							}
							if (t2.quantity > 1)
							{
								T98.tahoma_7_yellow.M898(g, string.Empty + t2.quantity, num6 + num8, num7 + num9 - T98.tahoma_7_yellow.M912(), 1);
							}
						}
					}
				}
				num++;
				continue;
			}
			M1335(g);
			break;
		}
	}

	private void M1299()
	{
		if (T51.keyHold[(!Main.isPC) ? 2 : 21])
		{
			yMove -= 5;
			cmyMap = yMove - (yScroll + hScroll / 2);
			if (yMove < yScroll)
			{
				yMove = yScroll;
			}
		}
		if (T51.keyHold[(!Main.isPC) ? 8 : 22])
		{
			yMove += 5;
			cmyMap = yMove - (yScroll + hScroll / 2);
			if (yMove > yScroll + 200)
			{
				yMove = yScroll + 200;
			}
		}
		if (T51.keyHold[(!Main.isPC) ? 4 : 23])
		{
			xMove -= 5;
			cmxMap = xMove - wScroll / 2;
			if (xMove < 16)
			{
				xMove = 16;
			}
		}
		if (T51.keyHold[(!Main.isPC) ? 6 : 24])
		{
			xMove += 5;
			cmxMap = xMove - wScroll / 2;
			if (xMove > 250)
			{
				xMove = 250;
			}
		}
		if (T51.isPointerDown)
		{
			pointerIsDowning = true;
			if (!trans)
			{
				pa1 = cmxMap;
				pa2 = cmyMap;
				trans = true;
			}
			cmxMap = pa1 + (T51.pxLast - T51.px);
			cmyMap = pa2 + (T51.pyLast - T51.py);
		}
		if (T51.isPointerJustRelease)
		{
			trans = false;
			T51.pxLast = T51.px;
			T51.pyLast = T51.py;
			pX = T51.pxLast + cmxMap;
			pY = T51.pyLast + cmyMap;
		}
		if (T51.isPointerClick)
		{
			pointerIsDowning = false;
		}
		if (cmxMap < 0)
		{
			cmxMap = 0;
		}
		if (cmxMap > cmxMapLim)
		{
			cmxMap = cmxMapLim;
		}
		if (cmyMap < 0)
		{
			cmyMap = 0;
		}
		if (cmyMap > cmyMapLim)
		{
			cmyMap = cmyMapLim;
		}
	}

	private void M1300()
	{
		if (currentTabIndex == 0)
		{
			M1307();
			keyTouchCombine = -1;
			if (selected == vItemCombine.M1113() && T51.isPointerClick)
			{
				T51.isPointerClick = false;
				keyTouchCombine = 1;
			}
		}
		if (currentTabIndex == 1)
		{
			M1307();
		}
	}

	private void M1301()
	{
		if (T51.keyHold[(!Main.isPC) ? 2 : 21])
		{
			cmyQuest -= 5;
		}
		if (T51.keyHold[(!Main.isPC) ? 8 : 22])
		{
			cmyQuest += 5;
		}
		if (cmyQuest < 0)
		{
			cmyQuest = 0;
		}
		int num = indexRowMax * 12 - (hScroll - 60);
		if (num < 0)
		{
			num = 0;
		}
		if (cmyQuest > num)
		{
			cmyQuest = num;
		}
		if (scroll != null)
		{
			if (!T51.isTouch)
			{
				scroll.cmy = cmyQuest;
			}
			scroll.M1561();
		}
		int num2 = xScroll + wScroll / 2 - 35;
		int num3 = ((T51.h <= 300) ? 15 : 20);
		int num4 = yScroll + hScroll - num3 - 15;
		int px = T51.px;
		int py = T51.py;
		keyTouchMapButton = -1;
		if (isPaintMap && !T54.M559().M535() && px >= num2 && px <= num2 + 70 && py >= num4 && py <= num4 + 30 && (scroll == null || !scroll.pointerIsDowning))
		{
			keyTouchMapButton = 1;
			if (T51.isPointerJustRelease)
			{
				T160.M1826().M1857();
				waitToPerform = 2;
				T51.M517();
			}
		}
	}

	private void M1302()
	{
		isClanOption = false;
		if (type != 0 || mainTabName.Length != 5 || currentTabIndex != 3)
		{
			return;
		}
		isClanOption = false;
		if (selected == 0)
		{
			currClanOption = new int[clansOption.Length];
			for (int i = 0; i < currClanOption.Length; i++)
			{
				currClanOption[i] = i;
			}
			if (!isViewMember)
			{
				isClanOption = true;
			}
		}
		else if (selected != 1 && !isSearchClan && selected > 0)
		{
			currClanOption = new int[1];
			for (int j = 0; j < currClanOption.Length; j++)
			{
				currClanOption[j] = j;
			}
			isClanOption = true;
		}
	}

	private void M1303()
	{
		if (currClanOption == null)
		{
			return;
		}
		if (T51.keyPressed[(!Main.isPC) ? 4 : 23])
		{
			currMess = M1345();
			cSelected--;
			if (selected == 0 && cSelected < 0)
			{
				cSelected = currClanOption.Length - 1;
			}
			if (selected > 1 && isMessage && currMess.option != null && cSelected < 0)
			{
				cSelected = currMess.option.Length - 1;
			}
		}
		else if (T51.keyPressed[(!Main.isPC) ? 6 : 24])
		{
			currMess = M1345();
			cSelected++;
			if (selected == 0 && cSelected > currClanOption.Length - 1)
			{
				cSelected = 0;
			}
			if (selected > 1 && isMessage && currMess.option != null && cSelected > currMess.option.Length - 1)
			{
				cSelected = 0;
			}
		}
	}

	private void M1304()
	{
		M1307();
		M1303();
	}

	private void M1305()
	{
		if (type != 0 || currentTabIndex != 3 || mainTabName.Length != 5 || selected == -1)
		{
			return;
		}
		int num = 0;
		if (selected == 0)
		{
			num = xScroll + wScroll / 2 - clansOption.Length * TAB_W / 2;
			cSelected = (T51.px - num) / TAB_W;
		}
		else
		{
			currMess = M1345();
			if (currMess != null && currMess.option != null)
			{
				num = xScroll + wScroll - 2 - currMess.option.Length * 40;
				cSelected = (T51.px - num) / 40;
			}
		}
		if (T51.px < num)
		{
			cSelected = -1;
		}
	}

	public void M1306(int a)
	{
		bool flag = false;
		if (T51.pxMouse > wScroll)
		{
			return;
		}
		if (indexMouse == -1)
		{
			indexMouse = selected;
		}
		if (a > 0)
		{
			indexMouse -= a;
			flag = true;
		}
		else if (a < 0)
		{
			indexMouse += -a;
			flag = true;
		}
		if (indexMouse < 0)
		{
			indexMouse = 0;
		}
		if (flag)
		{
			cmtoY = indexMouse * 12;
			if (cmtoY > cmyLim)
			{
				cmtoY = cmyLim;
			}
			if (cmtoY < 0)
			{
				cmtoY = 0;
			}
		}
	}

	private void M1307()
	{
		if (currentListLength <= 0)
		{
			return;
		}
		bool flag = false;
		if (T51.keyPressed[(!Main.isPC) ? 2 : 21])
		{
			flag = true;
			selected--;
			if (type == 24)
			{
				selected -= 2;
				if (selected < 0)
				{
					selected = 0;
				}
			}
			else if (selected < 0)
			{
				if (Equals(T51.panel) && typeShop == 2 && currentTabIndex <= 3 && maxPageShop[currentTabIndex] > 1)
				{
					T66.M749();
					if (currPageShop[currentTabIndex] <= 0)
					{
						T146.M1594().M1725(4, -1, (sbyte)currentTabIndex, maxPageShop[currentTabIndex] - 1, -1);
					}
					else
					{
						T146.M1594().M1725(4, -1, (sbyte)currentTabIndex, currPageShop[currentTabIndex] - 1, -1);
					}
					return;
				}
				selected = currentListLength - 1;
				if (isClanOption)
				{
					selected = -1;
				}
				if (size_tab > 0)
				{
					selected = -1;
				}
			}
			lastSelect[currentTabIndex] = selected;
			cSelected = 0;
			M1302();
		}
		else if (T51.keyPressed[(!Main.isPC) ? 8 : 22])
		{
			flag = true;
			selected++;
			if (type == 24)
			{
				selected += 2;
				if (selected > currentListLength - 1)
				{
					selected = currentListLength - 1;
				}
			}
			else if (selected > currentListLength - 1)
			{
				if (Equals(T51.panel) && typeShop == 2 && currentTabIndex <= 3 && maxPageShop[currentTabIndex] > 1)
				{
					T66.M749();
					if (currPageShop[currentTabIndex] >= maxPageShop[currentTabIndex] - 1)
					{
						T146.M1594().M1725(4, -1, (sbyte)currentTabIndex, 0, -1);
					}
					else
					{
						T146.M1594().M1725(4, -1, (sbyte)currentTabIndex, currPageShop[currentTabIndex] + 1, -1);
					}
					return;
				}
				selected = 0;
			}
			lastSelect[currentTabIndex] = selected;
			cSelected = 0;
			M1302();
		}
		if (flag)
		{
			cmtoY = selected * ITEM_HEIGHT - hScroll / 2;
			if (cmtoY > cmyLim)
			{
				cmtoY = cmyLim;
			}
			if (cmtoY < 0)
			{
				cmtoY = 0;
			}
			if (selected == currentListLength || selected == 0)
			{
				cmy = cmtoY;
			}
		}
		if (T51.isPointerDown)
		{
			justRelease = false;
			if (!pointerIsDowning && T51.M516(xScroll, yScroll, wScroll, hScroll))
			{
				for (int i = 0; i < pointerDownLastX.Length; i++)
				{
					pointerDownLastX[0] = T51.py;
				}
				pointerDownFirstX = T51.py;
				pointerIsDowning = true;
				isDownWhenRunning = cmRun != 0;
				cmRun = 0;
			}
			else if (pointerIsDowning)
			{
				pointerDownTime++;
				if (pointerDownTime > 5 && pointerDownFirstX == T51.py && !isDownWhenRunning)
				{
					pointerDownFirstX = -1000;
					selected = (cmtoY + T51.py - yScroll) / ITEM_HEIGHT;
					if (selected >= currentListLength)
					{
						selected = -1;
					}
					M1305();
				}
				else
				{
					indexMouse = -1;
				}
				int num = T51.py - pointerDownLastX[0];
				if (num != 0 && selected != -1)
				{
					selected = -1;
					cSelected = -1;
				}
				for (int num2 = pointerDownLastX.Length - 1; num2 > 0; num2--)
				{
					pointerDownLastX[num2] = pointerDownLastX[num2 - 1];
				}
				pointerDownLastX[0] = T51.py;
				cmtoY -= num;
				if (cmtoY < 0)
				{
					cmtoY = 0;
				}
				if (cmtoY > cmyLim)
				{
					cmtoY = cmyLim;
				}
				if (cmy < 0 || cmy > cmyLim)
				{
					num /= 2;
				}
				cmy -= num;
				if (cmy < -(T51.h / 3))
				{
					wantUpdateList = true;
				}
				else
				{
					wantUpdateList = false;
				}
			}
		}
		if (!T51.isPointerJustRelease || !pointerIsDowning)
		{
			return;
		}
		justRelease = true;
		int i2 = T51.py - pointerDownLastX[0];
		T51.isPointerJustRelease = false;
		if (T137.M1529(i2) < 20 && T137.M1529(T51.py - pointerDownFirstX) < 20 && !isDownWhenRunning)
		{
			cmRun = 0;
			cmtoY = cmy;
			pointerDownFirstX = -1000;
			selected = (cmtoY + T51.py - yScroll) / ITEM_HEIGHT;
			if (selected >= currentListLength)
			{
				selected = -1;
			}
			M1305();
			pointerDownTime = 0;
			waitToPerform = 10;
			T160.M1826().M1862();
		}
		else if (selected != -1 && pointerDownTime > 5)
		{
			pointerDownTime = 0;
			waitToPerform = 1;
		}
		else if (selected == -1 && !isDownWhenRunning)
		{
			if (cmy < 0)
			{
				cmtoY = 0;
			}
			else if (cmy > cmyLim)
			{
				cmtoY = cmyLim;
			}
			else
			{
				int num3 = T51.py - pointerDownLastX[0] + (pointerDownLastX[0] - pointerDownLastX[1]) + (pointerDownLastX[1] - pointerDownLastX[2]);
				cmRun = -((num3 > 10) ? 10 : ((num3 < -10) ? (-10) : 0)) * 100;
			}
		}
		pointerIsDowning = false;
		pointerDownTime = 0;
		T51.isPointerJustRelease = false;
	}

	public string M1308(string[] str)
	{
		return null;
	}

	private void M1309()
	{
		if ((scroll != null && scroll.pointerIsDowning) || pointerIsDowning)
		{
			return;
		}
		int num = currentTabIndex;
		if (!M1459())
		{
			if (T51.keyPressed[(!Main.isPC) ? 6 : 24])
			{
				currentTabIndex++;
				if (currentTabIndex >= currentTabName.Length)
				{
					if (T51.panel2 != null)
					{
						currentTabIndex = currentTabName.Length - 1;
						T51.isFocusPanel2 = true;
					}
					else
					{
						currentTabIndex = 0;
					}
				}
				selected = lastSelect[currentTabIndex];
				lastTabIndex[type] = currentTabIndex;
			}
			if (T51.keyPressed[(!Main.isPC) ? 4 : 23])
			{
				currentTabIndex--;
				if (currentTabIndex < 0)
				{
					currentTabIndex = currentTabName.Length - 1;
				}
				if (T51.isFocusPanel2)
				{
					T51.isFocusPanel2 = false;
				}
				selected = lastSelect[currentTabIndex];
				lastTabIndex[type] = currentTabIndex;
			}
		}
		keyTouchTab = -1;
		for (int i = 0; i < currentTabName.Length; i++)
		{
			if (!T51.M516(startTabPos + i * TAB_W, 52, TAB_W - 1, 25))
			{
				continue;
			}
			keyTouchTab = i;
			if (T51.isPointerJustRelease)
			{
				currentTabIndex = i;
				lastTabIndex[type] = i;
				T51.isPointerJustRelease = false;
				selected = lastSelect[currentTabIndex];
				if (num == currentTabIndex && cmRun == 0)
				{
					cmtoY = 0;
					selected = (T51.isTouch ? (-1) : 0);
				}
				break;
			}
		}
		if (num == currentTabIndex)
		{
			return;
		}
		size_tab = 0;
		T160.M1826().M1862();
		switch (type)
		{
		case 12:
			if (currentTabIndex == 0)
			{
				M1271();
			}
			if (currentTabIndex == 1)
			{
				M1323(resetSelect: true);
			}
			break;
		case 0:
			if (currentTabIndex == 0)
			{
				M1325();
			}
			if (currentTabIndex == 1)
			{
				M1323(resetSelect: true);
			}
			if (currentTabIndex == 2)
			{
				M1318();
			}
			if (currentTabIndex == 3)
			{
				if (mainTabName.Length > 4)
				{
					M1314();
				}
				else
				{
					M1312();
				}
			}
			if (currentTabIndex == 4)
			{
				M1312();
			}
			break;
		case 1:
			M1317();
			break;
		case 2:
			if (currentTabIndex == 0)
			{
				M1321();
			}
			if (currentTabIndex == 1)
			{
				M1323(resetSelect: true);
			}
			break;
		case 3:
			M1320();
			break;
		case 25:
			M1442();
			break;
		case 21:
			if (currentTabIndex == 0)
			{
				M1322();
			}
			if (currentTabIndex == 1)
			{
				M1310();
			}
			if (currentTabIndex == 2)
			{
				M1323(resetSelect: true);
			}
			break;
		case 13:
			if (currentTabIndex == 0)
			{
				if (Equals(T51.panel))
				{
					M1323(resetSelect: true);
				}
				else if (Equals(T51.panel2))
				{
					M1296(isMe: false);
				}
			}
			if (currentTabIndex == 1)
			{
				M1296(isMe: true);
			}
			if (currentTabIndex == 2)
			{
				M1296(isMe: false);
			}
			break;
		}
		selected = lastSelect[currentTabIndex];
	}

	private void M1310()
	{
		currentListLength = strStatus.Length;
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
	}

	private void M1311()
	{
	}

	private void M1312()
	{
		T160.M1826().M1828();
		currentListLength = strTool.Length;
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
	}

	public void M1313()
	{
		if (isSearchClan)
		{
			currentListLength = ((clans != null) ? (clans.Length + 2) : 2);
			clanInfo = mResources.clan_list;
		}
		else if (isViewMember)
		{
			clanReport = string.Empty;
			currentListLength = ((member != null) ? member.M1113() : myMember.M1113()) + 2;
			clanInfo = mResources.member + " " + ((currClan == null) ? T13.M113().clan.name : currClan.name);
		}
		else if (isMessage)
		{
			currentListLength = T19.vMessage.M1113() + 2;
			clanInfo = mResources.msg;
			clanReport = string.Empty;
		}
		if (T13.M113().clan == null)
		{
			clansOption = new string[2][]
			{
				mResources.findClan,
				mResources.createClan
			};
		}
		else if (!isViewMember)
		{
			if (myMember.M1113() > 1)
			{
				clansOption = new string[3][]
				{
					mResources.chatClan,
					mResources.request_pea2,
					mResources.memberr
				};
			}
			else
			{
				clansOption = new string[1][] { mResources.memberr };
			}
		}
		else if (T13.M113().role > 0)
		{
			clansOption = new string[2][]
			{
				mResources.msgg,
				mResources.leaveClan
			};
		}
		else if (myMember.M1113() > 1)
		{
			clansOption = new string[4][]
			{
				mResources.msgg,
				mResources.leaveClan,
				mResources.khau_hieuu,
				mResources.bieu_tuongg
			};
		}
		else
		{
			clansOption = new string[3][]
			{
				mResources.msgg,
				mResources.khau_hieuu,
				mResources.bieu_tuongg
			};
		}
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
	}

	public void M1314()
	{
		T54.isNewClanMessage = false;
		ITEM_HEIGHT = 24;
		if (lastSelect != null && lastSelect[3] == 0)
		{
			lastSelect[3] = -1;
		}
		currentListLength = 2;
		if (T13.M113().clan != null)
		{
			isMessage = true;
			isViewMember = false;
			isSearchClan = false;
		}
		else
		{
			isMessage = false;
			isViewMember = false;
			isSearchClan = true;
		}
		if (T13.M113().clan != null)
		{
			currentListLength = T19.vMessage.M1113() + 2;
		}
		M1313();
		cSelected = -1;
		if (chatTField == null)
		{
			chatTField = new T15();
			chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
			chatTField.M276();
			chatTField.parentScreen = T51.panel;
		}
		if (T13.M113().clan == null)
		{
			clanReport = mResources.findingClan;
			T146.M1594().M1618(string.Empty);
		}
		selected = lastSelect[currentTabIndex];
		if (T51.isTouch)
		{
			selected = -1;
		}
	}

	public void M1315()
	{
		currentListLength = logChat.M1113() + 1;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		cmtoX = 0;
		cmx = 0;
	}

	private void M1316()
	{
		ITEM_HEIGHT = 24;
		M1315();
		selected = (T51.isTouch ? (-1) : 0);
	}

	public void M1317()
	{
		ITEM_HEIGHT = 24;
		if (currentTabIndex == currentTabName.Length - 1 && T51.panel2 == null && typeShop != 2)
		{
			currentListLength = M1460(T13.M113().arrItemBody.Length + T13.M113().arrItemBag.Length);
		}
		else
		{
			currentListLength = T13.M113().arrItemShop[currentTabIndex].Length;
		}
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		selected = (T51.isTouch ? (-1) : 0);
	}

	private void M1318()
	{
		ITEM_HEIGHT = 30;
		currentListLength = T13.M113().nClass.skillTemplates.Length + 6;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = cmyLim;
		}
		selected = (T51.isTouch ? (-1) : 0);
	}

	private void M1319()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		ITEM_HEIGHT = 24;
		currentListLength = mapNames.Length;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		cmtoY = 0;
		cmy = 0;
		selected = (T51.isTouch ? (-1) : 0);
	}

	private void M1320()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		ITEM_HEIGHT = 24;
		currentListLength = T54.M559().zones.Length;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		cmtoY = 0;
		cmy = 0;
		selected = (T51.isTouch ? (-1) : 0);
	}

	private void M1321()
	{
		currentListLength = M1460(T13.M113().arrItemBox.Length);
		ITEM_HEIGHT = 24;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 9;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		selected = (T51.isTouch ? (-1) : 0);
	}

	private void M1322()
	{
		ITEM_HEIGHT = 24;
		T79[] arrItemBody = T13.M114().arrItemBody;
		T149[] arrPetSkill = T13.M114().arrPetSkill;
		currentListLength = arrItemBody.Length + arrPetSkill.Length;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmtoY = 0;
			cmy = 0;
		}
		selected = (T51.isTouch ? (-1) : 0);
	}

	private void M1323(bool resetSelect)
	{
		currentListLength = T13.M113().arrItemBody.Length + T13.M113().arrItemBag.Length;
		ITEM_HEIGHT = 24;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		if (cmy < 0)
		{
			int num = 0;
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			int num = 0;
			cmtoY = 0;
			cmy = 0;
		}
		if (resetSelect)
		{
			selected = (T51.isTouch ? (-1) : 0);
		}
	}

	private void M1324()
	{
		if (!isPaintMap)
		{
			return;
		}
		if (T174.lastPlanetId != T174.planetID)
		{
			T137.M1513("LOAD TAM HINH");
			imgMap = T51.M502("/img/map" + T174.planetID + ".png");
			T174.lastPlanetId = T174.planetID;
		}
		cmxMap = M1242() - wScroll / 2;
		cmyMap = M1243() + yScroll - (yScroll + hScroll / 2);
		pa1 = cmxMap;
		pa2 = cmyMap;
		cmxMapLim = 250 - wScroll;
		cmyMapLim = 220 - hScroll;
		if (cmxMapLim < 0)
		{
			cmxMapLim = 0;
		}
		if (cmyMapLim < 0)
		{
			cmyMapLim = 0;
		}
		for (int i = 0; i < mapId[T174.planetID].Length; i++)
		{
			if (T174.mapID == mapId[T174.planetID][i])
			{
				xMove = mapX[T174.planetID][i] + xScroll;
				yMove = mapY[T174.planetID][i] + yScroll + 5;
				break;
			}
		}
		xMap = M1242() + xScroll;
		yMap = M1243() + yScroll;
		xMapTask = M1244() + xScroll;
		yMapTask = M1245() + yScroll;
		Resources.UnloadUnusedAssets();
		GC.Collect();
	}

	private void M1325()
	{
		cmyQuest = 0;
	}

	public void M1326()
	{
		if (timeShow > 0)
		{
			timeShow--;
		}
		if (justRelease && Equals(T51.panel) && typeShop == 2 && maxPageShop[currentTabIndex] > 1)
		{
			if (cmy < -50)
			{
				T66.M749();
				justRelease = false;
				if (currPageShop[currentTabIndex] <= 0)
				{
					T146.M1594().M1725(4, -1, (sbyte)currentTabIndex, maxPageShop[currentTabIndex] - 1, -1);
				}
				else
				{
					T146.M1594().M1725(4, -1, (sbyte)currentTabIndex, currPageShop[currentTabIndex] - 1, -1);
				}
			}
			else if (cmy > cmyLim + 50)
			{
				justRelease = false;
				T66.M749();
				if (currPageShop[currentTabIndex] >= maxPageShop[currentTabIndex] - 1)
				{
					T146.M1594().M1725(4, -1, (sbyte)currentTabIndex, 0, -1);
				}
				else
				{
					T146.M1594().M1725(4, -1, (sbyte)currentTabIndex, currPageShop[currentTabIndex] + 1, -1);
				}
			}
		}
		if (cmx != cmtoX && !pointerIsDowning)
		{
			cmvx = cmtoX - cmx << 2;
			cmdx += cmvx;
			cmx += cmdx >> 3;
			cmdx &= 15;
		}
		if (T94.M869(cmtoX - cmx) < 10)
		{
			cmx = cmtoX;
		}
		if (isClose)
		{
			isClose = false;
			cmtoX = wScroll;
		}
		if (cmtoX >= wScroll - 10 && cmx >= wScroll - 10 && position == 0)
		{
			isShow = false;
			M1380();
			if (isChangeZone)
			{
				isChangeZone = false;
				if (T13.M113().cHP > 0 && T13.M113().statusMe != 14)
				{
					T66.M749();
					if (type == 3)
					{
						T146.M1594().M1638(selected, -1);
					}
					else if (type == 14)
					{
						T146.M1594().M1721(selected);
					}
				}
			}
			if (isSelectPlayerMenu)
			{
				isSelectPlayerMenu = false;
				((T22)vPlayerMenu.M1114(selected)).M294();
			}
			vPlayerMenu.M1120();
			charMenu = null;
		}
		if (cmRun != 0 && !pointerIsDowning)
		{
			cmtoY += cmRun / 100;
			if (cmtoY < 0)
			{
				cmtoY = 0;
			}
			else if (cmtoY > cmyLim)
			{
				cmtoY = cmyLim;
			}
			else
			{
				cmy = cmtoY;
			}
			cmRun = cmRun * 9 / 10;
			if (cmRun < 100 && cmRun > -100)
			{
				cmRun = 0;
			}
		}
		if (cmy != cmtoY && !pointerIsDowning)
		{
			cmvy = cmtoY - cmy << 2;
			cmdy += cmvy;
			cmy += cmdy >> 4;
			cmdy &= 15;
		}
		cmyLast[currentTabIndex] = cmy;
	}

	public void M1327(T99 g)
	{
		if (cp == null || cp.says == null)
		{
			return;
		}
		cp.paint(g);
		int num = cp.cx + 13;
		int num2 = cp.cy + 11;
		if (type == 15)
		{
			num += 5;
			num2 += 26;
		}
		if (type == 0 && currentTabIndex == 3)
		{
			if (isSearchClan)
			{
				num -= 5;
			}
			else if (partID != null || charInfo != null)
			{
				num = cp.cx + 21;
				num2 = cp.cy + 40;
			}
		}
		if (partID != null)
		{
			T127 t = T54.parts[partID[0]];
			T127 t2 = T54.parts[partID[1]];
			T127 t3 = T54.parts[partID[2]];
			T157.M1785(g, t.pi[T13.CharInfo[0][0][0]].id, num + T13.CharInfo[0][0][1] + t.pi[T13.CharInfo[0][0][0]].dx, num2 - T13.CharInfo[0][0][2] + t.pi[T13.CharInfo[0][0][0]].dy, 0, 0);
			T157.M1785(g, t2.pi[T13.CharInfo[0][1][0]].id, num + T13.CharInfo[0][1][1] + t2.pi[T13.CharInfo[0][1][0]].dx, num2 - T13.CharInfo[0][1][2] + t2.pi[T13.CharInfo[0][1][0]].dy, 0, 0);
			T157.M1785(g, t3.pi[T13.CharInfo[0][2][0]].id, num + T13.CharInfo[0][2][1] + t3.pi[T13.CharInfo[0][2][0]].dx, num2 - T13.CharInfo[0][2][2] + t3.pi[T13.CharInfo[0][2][0]].dy, 0, 0);
		}
		else if (charInfo != null)
		{
			charInfo.M199(g, num + 5, num2 + 25, 1, 0, isPaintBag: true);
		}
		else if (idIcon != -1)
		{
			T157.M1785(g, idIcon, num, num2, 0, 3);
		}
		if (currItem != null && currItem.template.type != 5)
		{
			if (currItem.compare > 0)
			{
				g.M948(imgUp, num - 7, num2 + 13, 3);
				T98.tahoma_7b_green.M898(g, T137.M1529(currItem.compare) + string.Empty, num + 1, num2 + 8, 0);
			}
			else if (currItem.compare < 0 && currItem.compare != -1)
			{
				g.M948(imgDown, num - 7, num2 + 13, 3);
				T98.tahoma_7b_red.M898(g, T137.M1529(currItem.compare) + string.Empty, num + 1, num2 + 8, 0);
			}
		}
	}

	public void M1328(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (currentListLength == 0)
		{
			return;
		}
		int num = (cmy + hScroll) / 24 + 1;
		if (num < hScroll / 24 + 1)
		{
			num = hScroll / 24 + 1;
		}
		if (num > currentListLength)
		{
			num = currentListLength;
		}
		int num2 = cmy / 24;
		if (num2 >= num)
		{
			num2 = num - 1;
		}
		if (num2 < 0)
		{
			num2 = 0;
		}
		for (int i = num2; i < num; i++)
		{
			int num3 = xScroll;
			int num4 = yScroll + i * ITEM_HEIGHT;
			int num5 = 24;
			int h = ITEM_HEIGHT - 1;
			int num6 = xScroll + 24;
			int num7 = yScroll + i * ITEM_HEIGHT;
			int num8 = wScroll - 24;
			int num9 = ITEM_HEIGHT - 1;
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num6, num7, num8, num9);
			g.M933((i != selected) ? 9993045 : 9541120);
			g.M932(num3, num4, num5, h);
			T176 t = (T176)vTop.M1114(i);
			if (t.headICON != -1)
			{
				T157.M1785(g, t.headICON, num3, num4, 0, 0);
			}
			else
			{
				T127 t2 = T54.parts[t.headID];
				T157.M1785(g, t2.pi[T13.CharInfo[0][0][0]].id, num3 + t2.pi[T13.CharInfo[0][0][0]].dx, num4 + num9 - 1, 0, T99.BOTTOM | T99.LEFT);
			}
			g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
			if (t.pId != T13.M113().charID)
			{
				T98.tahoma_7b_green.M898(g, t.name, num6 + 5, num7, 0);
			}
			else
			{
				T98.tahoma_7b_red.M898(g, t.name, num6 + 5, num7, 0);
			}
			T98.tahoma_7_blue.M898(g, t.info, num6 + num8 - 5, num7 + 11, 1);
			T98.tahoma_7_green2.M898(g, mResources.rank + ": " + t.rank + string.Empty, num6 + 5, num7 + 11, 0);
		}
		M1335(g);
	}

	public void M1329(T99 g)
	{
		g.M918(-g.M920(), -g.M921() + T99.addYWhenOpenKeyBoard);
		g.M918(-cmx, 0);
		g.M918(X, Y);
		if (T51.panel.combineSuccess != -1)
		{
			if (Equals(T51.panel))
			{
				M1428(g);
			}
			return;
		}
		T51.paintz.M1236(X, Y, W, H, g);
		M1371(g);
		M1357(g);
		M1356(g);
		switch (type)
		{
		case 0:
			if (currentTabIndex == 0)
			{
				M1377(g);
			}
			if (currentTabIndex == 1)
			{
				M1355(g);
			}
			if (currentTabIndex == 2)
			{
				M1339(g);
			}
			if (currentTabIndex == 3)
			{
				if (mainTabName.Length == 4)
				{
					M1336(g);
				}
				else
				{
					M1352(g);
				}
			}
			if (currentTabIndex == 4)
			{
				M1336(g);
			}
			break;
		case 1:
			M1330(g);
			break;
		case 2:
			if (currentTabIndex == 0)
			{
				M1343(g);
			}
			if (currentTabIndex == 1)
			{
				M1355(g);
			}
			break;
		case 3:
			M1341(g);
			break;
		case 4:
			M1376(g);
			break;
		case 7:
			M1355(g);
			break;
		case 8:
			M1347(g);
			break;
		case 9:
			M1353(g);
			break;
		case 10:
			M1351(g);
			break;
		case 11:
			M1350(g);
			break;
		case 12:
			if (currentTabIndex == 0)
			{
				M1354(g);
			}
			if (currentTabIndex == 1)
			{
				M1355(g);
			}
			break;
		case 13:
			if (currentTabIndex == 0)
			{
				if (Equals(T51.panel))
				{
					M1355(g);
				}
				else
				{
					M1298(g, isMe: false);
				}
			}
			if (currentTabIndex == 1)
			{
				M1298(g, isMe: true);
			}
			if (currentTabIndex == 2)
			{
				M1298(g, isMe: false);
			}
			break;
		case 14:
			M1340(g);
			break;
		case 15:
			M1328(g);
			break;
		case 16:
			M1349(g);
			break;
		case 17:
			M1330(g);
			break;
		case 18:
			M1348(g);
			break;
		case 19:
			M1434(g);
			break;
		case 20:
			M1438(g);
			break;
		case 21:
			if (currentTabIndex == 0)
			{
				M1334(g);
			}
			if (currentTabIndex == 1)
			{
				M1332(g);
			}
			if (currentTabIndex == 2)
			{
				M1355(g);
			}
			break;
		case 22:
			M1331(g);
			break;
		case 23:
			M1338(g);
			break;
		case 24:
			M1337(g);
			break;
		case 25:
			M1342(g);
			break;
		}
		T54.M631(g);
		M1327(g);
		if (cmx == cmtoX)
		{
			cmdClose.M296(g);
		}
		if (tabIcon != null && tabIcon.isShow)
		{
			tabIcon.M1891(g);
		}
	}

	private void M1330(T99 g)
	{
		if (type == 1 && currentTabIndex == currentTabName.Length - 1 && T51.panel2 == null && typeShop != 2)
		{
			M1355(g);
			return;
		}
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		if (typeShop == 2 && Equals(T51.panel))
		{
			if (currentTabIndex <= 3 && T51.isTouch)
			{
				if (cmy < -50)
				{
					T51.M514(xScroll + wScroll / 2, yScroll + 30, g);
				}
				else if (cmy < 0)
				{
					T98.tahoma_7_grey.M898(g, mResources.getDown, xScroll + wScroll / 2, yScroll + 15, 2);
				}
				else if (cmyLim >= 0)
				{
					if (cmy > cmyLim + 50)
					{
						T51.M514(xScroll + wScroll / 2, yScroll + hScroll - 30, g);
					}
					else if (cmy > cmyLim)
					{
						T98.tahoma_7_grey.M898(g, mResources.getUp, xScroll + wScroll / 2, yScroll + hScroll - 25, 2);
					}
				}
			}
			if (T13.M113().arrItemShop[currentTabIndex].Length == 0 && type != 17)
			{
				T98.tahoma_7_grey.M898(g, mResources.notYetSell, xScroll + wScroll / 2, yScroll + hScroll / 2 - 10, 2);
				return;
			}
		}
		g.M918(0, -cmy);
		T79[] array = T13.M113().arrItemShop[currentTabIndex];
		if (typeShop == 2 && (currentTabIndex == 4 || type == 17))
		{
			array = T13.M113().arrItemShop[4];
			if (array.Length == 0)
			{
				T98.tahoma_7_grey.M898(g, mResources.notYetSell, xScroll + wScroll / 2, yScroll + hScroll / 2 - 10, 2);
				return;
			}
		}
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			int num2 = xScroll + 36;
			int num3 = yScroll + i * ITEM_HEIGHT;
			int num4 = wScroll - 36;
			int h = ITEM_HEIGHT - 1;
			int num5 = xScroll;
			int num6 = yScroll + i * ITEM_HEIGHT;
			int num7 = 34;
			int num8 = ITEM_HEIGHT - 1;
			if (num3 - cmy > yScroll + hScroll || num3 - cmy < yScroll - ITEM_HEIGHT)
			{
				continue;
			}
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num2, num3, num4, h);
			g.M933((i != selected) ? 9993045 : 9541120);
			g.M932(num5, num6, num7, num8);
			T79 t = array[i];
			if (t != null)
			{
				string text = string.Empty;
				T98 t2 = T98.tahoma_7_green2;
				if (t.isMe != 0 && typeShop == 2 && currentTabIndex <= 3 && !Equals(T51.panel2))
				{
					t2 = T98.tahoma_7b_green;
				}
				if (t.itemOption != null)
				{
					for (int j = 0; j < t.itemOption.Length; j++)
					{
						if (t.itemOption[j].optionTemplate.id == 72)
						{
							text = " [+" + t.itemOption[j].param + "]";
							t.M818(g, num5 + 18, num6 + 12, t.itemOption[j].param);
						}
						if (t.itemOption[j].optionTemplate.id == 41)
						{
							if (t.itemOption[j].param == 1)
							{
								t2 = M1450(0);
							}
							else if (t.itemOption[j].param == 2)
							{
								t2 = M1450(2);
							}
							else if (t.itemOption[j].param == 3)
							{
								t2 = M1450(8);
							}
							else if (t.itemOption[j].param == 4)
							{
								t2 = M1450(7);
							}
						}
					}
				}
				t2.M898(g, t.template.name + text, num2 + 5, num3 + 1, 0);
				string text2 = string.Empty;
				if (t.itemOption != null && t.itemOption.Length >= 1)
				{
					if (t.itemOption[0] != null && t.itemOption[0].optionTemplate.id != 102 && t.itemOption[0].optionTemplate.id != 107)
					{
						text2 += t.itemOption[0].M830();
					}
					T98 t3 = T98.tahoma_7_blue;
					if (t.compare < 0 && t.template.type != 5)
					{
						t3 = T98.tahoma_7_red;
					}
					if (typeShop == 2 && t.itemOption.Length > 1 && t.buyType != -1)
					{
						text2 += string.Empty;
					}
					if (typeShop != 2 || (typeShop == 2 && t.buyType <= 1))
					{
						t3.M898(g, text2, num2 + 5, num3 + 11, 0);
					}
				}
				if (t.buySpec > 0)
				{
					T157.M1785(g, t.iconSpec, num2 + num4 - 7, num3 + 9, 0, 3);
					T98.tahoma_7b_blue.M898(g, T137.M1532(t.buySpec), num2 + num4 - 15, num3 + 1, T98.RIGHT);
				}
				if (t.buyCoin != 0 || t.buyGold != 0)
				{
					if (typeShop != 2 && t.powerRequire == 0L)
					{
						if (t.buyCoin > 0 && t.buyGold > 0)
						{
							if (t.buyCoin > 0)
							{
								g.M948(imgXu, num2 + num4 - 7, num3 + 7, 3);
								T98.tahoma_7b_yellow.M898(g, T137.M1532(t.buyCoin), num2 + num4 - 15, num3 + 1, T98.RIGHT);
							}
							if (t.buyGold > 0)
							{
								g.M948(imgLuong, num2 + num4 - 7, num3 + 7 + 11, 3);
								T98.tahoma_7b_green.M898(g, T137.M1532(t.buyGold), num2 + num4 - 15, num3 + 12, T98.RIGHT);
							}
						}
						else
						{
							if (t.buyCoin > 0)
							{
								g.M948(imgXu, num2 + num4 - 7, num3 + 7, 3);
								T98.tahoma_7b_yellow.M898(g, T137.M1532(t.buyCoin), num2 + num4 - 15, num3 + 1, T98.RIGHT);
							}
							if (t.buyGold > 0)
							{
								g.M948(imgLuong, num2 + num4 - 7, num3 + 7, 3);
								T98.tahoma_7b_green.M898(g, T137.M1532(t.buyGold), num2 + num4 - 15, num3 + 1, T98.RIGHT);
							}
						}
					}
					if (typeShop == 2 && currentTabIndex <= 3 && !Equals(T51.panel2))
					{
						if (t.buyCoin > 0 && t.buyGold > 0)
						{
							if (t.buyCoin > 0)
							{
								g.M948(imgXu, num2 + num4 - 7, num3 + 7, 3);
								T98.tahoma_7b_yellow.M898(g, T137.M1533(t.buyCoin), num2 + num4 - 15, num3 + 1, T98.RIGHT);
							}
							if (t.buyGold > 0)
							{
								g.M948(imgLuong, num2 + num4 - 7, num3 + 7 + 11, 3);
								T98.tahoma_7b_green.M898(g, T137.M1533(t.buyGold), num2 + num4 - 15, num3 + 12, T98.RIGHT);
							}
						}
						else
						{
							if (t.buyCoin > 0)
							{
								g.M948(imgXu, num2 + num4 - 7, num3 + 7, 3);
								T98.tahoma_7b_yellow.M898(g, T137.M1533(t.buyCoin), num2 + num4 - 15, num3 + 1, T98.RIGHT);
							}
							if (t.buyGold > 0)
							{
								g.M948(imgLuong, num2 + num4 - 7, num3 + 7, 3);
								T98.tahoma_7b_green.M898(g, T137.M1533(t.buyGold), num2 + num4 - 15, num3 + 1, T98.RIGHT);
							}
						}
					}
				}
				T157.M1785(g, t.template.iconID, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
				if (t.quantity > 1)
				{
					T98.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num5 + num7, num6 + num8 - T98.tahoma_7_yellow.M912(), 1);
				}
				if (t.newItem && T51.gameTick % 10 > 5)
				{
					g.M948(imgNew, num5 + num7 / 2, num3 + 19, 3);
				}
			}
			if (typeShop != 2 || (!Equals(T51.panel2) && currentTabIndex != 4) || t.buyType == 0)
			{
				continue;
			}
			if (t.buyType == 1)
			{
				T98.tahoma_7_green.M898(g, mResources.dangban, num2 + num4 - 5, num3 + 1, T98.RIGHT);
				if (t.buyCoin != -1)
				{
					g.M948(imgXu, num2 + num4 - 7, num3 + 19, 3);
					T98.tahoma_7b_yellow.M898(g, T137.M1533(t.buyCoin), num2 + num4 - 15, num3 + 13, T98.RIGHT);
				}
				else if (t.buyGold != -1)
				{
					g.M948(imgLuongKhoa, num2 + num4 - 7, num3 + 17, 3);
					T98.tahoma_7b_red.M898(g, T137.M1533(t.buyGold), num2 + num4 - 15, num3 + 11, T98.RIGHT);
				}
			}
			else if (t.buyType == 2)
			{
				T98.tahoma_7b_blue.M898(g, mResources.daban, num2 + num4 - 5, num3 + 1, T98.RIGHT);
				if (t.buyCoin != -1)
				{
					g.M948(imgXu, num2 + num4 - 7, num3 + 17, 3);
					T98.tahoma_7b_yellow.M898(g, T137.M1533(t.buyCoin), num2 + num4 - 15, num3 + 11, T98.RIGHT);
				}
				else if (t.buyGold != -1)
				{
					g.M948(imgLuongKhoa, num2 + num4 - 7, num3 + 17, 3);
					T98.tahoma_7b_red.M898(g, T137.M1533(t.buyGold), num2 + num4 - 15, num3 + 11, T98.RIGHT);
				}
			}
		}
		M1335(g);
	}

	private void M1331(T99 g)
	{
	}

	private void M1332(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < strStatus.Length; i++)
		{
			int x = xScroll;
			int num = yScroll + i * ITEM_HEIGHT;
			int num2 = wScroll - 1;
			int h = ITEM_HEIGHT - 1;
			if (num - cmy <= yScroll + hScroll && num - cmy >= yScroll - ITEM_HEIGHT)
			{
				g.M933((i != selected) ? 15196114 : 16383818);
				g.M932(x, num, num2, h);
				T98.tahoma_7b_dark.M898(g, strStatus[i], xScroll + wScroll / 2, num + 6, T98.CENTER);
			}
		}
		M1335(g);
	}

	private void M1333()
	{
	}

	private void M1334(T99 g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		T79[] arrItemBody = T13.M114().arrItemBody;
		T149[] arrPetSkill = T13.M114().arrPetSkill;
		for (int i = 0; i < arrItemBody.Length + arrPetSkill.Length; i++)
		{
			bool flag = i < arrItemBody.Length;
			int num = i;
			int num2 = i - arrItemBody.Length;
			int num3 = xScroll + 36;
			int num4 = yScroll + i * ITEM_HEIGHT;
			int num5 = wScroll - 36;
			int h = ITEM_HEIGHT - 1;
			int num6 = xScroll;
			int num7 = yScroll + i * ITEM_HEIGHT;
			int num8 = 34;
			int num9 = ITEM_HEIGHT - 1;
			if (num4 - cmy > yScroll + hScroll || num4 - cmy < yScroll - ITEM_HEIGHT)
			{
				continue;
			}
			T79 t = ((!flag) ? null : arrItemBody[num]);
			g.M933((i == selected) ? 16383818 : ((!flag) ? 15723751 : 15196114));
			g.M932(num3, num4, num5, h);
			g.M933((i == selected) ? 9541120 : ((!flag) ? 11837316 : 9993045));
			if (t != null)
			{
				for (int j = 0; j < t.itemOption.Length; j++)
				{
					if (t.itemOption[j].optionTemplate.id == 72 && t.itemOption[j].param > 0)
					{
						sbyte id = M1449(t.itemOption[j].param);
						if (M1448(id) != -1)
						{
							g.M933((i != selected) ? M1448(id) : M1448(id));
						}
					}
				}
			}
			g.M932(num6, num7, num8, num9);
			if (t != null && t.isSelect && T51.panel.type == 12)
			{
				g.M933((i != selected) ? 6047789 : 7040779);
				g.M932(num6, num7, num8, num9);
			}
			if (t != null)
			{
				string text = string.Empty;
				T98 t2 = T98.tahoma_7_green2;
				if (t.itemOption != null)
				{
					for (int k = 0; k < t.itemOption.Length; k++)
					{
						if (t.itemOption[k].optionTemplate.id == 72)
						{
							text = " [+" + t.itemOption[k].param + "]";
							t.M818(g, num6 + 18, num7 + 12, t.itemOption[k].param);
						}
						if (t.itemOption[k].optionTemplate.id == 41)
						{
							if (t.itemOption[k].param == 1)
							{
								t2 = M1450(0);
							}
							else if (t.itemOption[k].param == 2)
							{
								t2 = M1450(2);
							}
							else if (t.itemOption[k].param == 3)
							{
								t2 = M1450(8);
							}
							else if (t.itemOption[k].param == 4)
							{
								t2 = M1450(7);
							}
						}
					}
				}
				t2.M898(g, t.template.name + text, num3 + 5, num4 + 1, 0);
				if (t.M796() > 0)
				{
					int x = num3 + num5 - 5;
					T98.bigNumber_yellow.M898(g, t.M796() + "s", x, num4 + 1, T98.RIGHT);
					T98.tahoma_7_blue.M898(g, t.M797(), x, num4 + 11, T98.RIGHT);
				}
				string text2 = string.Empty;
				if (t.itemOption != null)
				{
					if (t.itemOption.Length != 0 && t.itemOption[0] != null && t.itemOption[0].optionTemplate.id != 102 && t.itemOption[0].optionTemplate.id != 107)
					{
						text2 += t.itemOption[0].M830();
					}
					T98 t3 = T98.tahoma_7_blue;
					if (t.compare < 0 && t.template.type != 5)
					{
						t3 = T98.tahoma_7_red;
					}
					if (t.itemOption.Length > 1)
					{
						for (int l = 1; l < 2; l++)
						{
							if (t.itemOption[l] != null && t.itemOption[l].optionTemplate.id != 102 && t.itemOption[l].optionTemplate.id != 107)
							{
								text2 = text2 + "," + t.itemOption[l].M830();
							}
						}
					}
					t3.M898(g, text2, num3 + 5, num4 + 11, T98.LEFT);
				}
				T157.M1785(g, t.template.iconID, num6 + num8 / 2, num7 + num9 / 2, 0, 3);
				if (t.itemOption != null)
				{
					for (int m = 0; m < t.itemOption.Length; m++)
					{
						M1451(g, t.itemOption[m].optionTemplate.id, t.itemOption[m].param, num6, num7, num8, num9);
					}
					for (int n = 0; n < t.itemOption.Length; n++)
					{
						M1452(g, t.itemOption[n].optionTemplate.id, t.itemOption[n].param, num6, num7, num8, num9);
					}
				}
				if (t.quantity > 1)
				{
					T98.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num6 + num8, num7 + num9 - T98.tahoma_7_yellow.M912(), 1);
				}
			}
			else if (!flag)
			{
				T149 t4 = arrPetSkill[num2];
				if (t4.template != null)
				{
					T98.tahoma_7_blue.M898(g, t4.template.name, num3 + 5, num4 + 1, 0);
					T98.tahoma_7_green2.M898(g, mResources.level + ": " + t4.point + string.Empty, num3 + 5, num4 + 11, 0);
					T157.M1785(g, t4.template.iconId, num6 + num8 / 2, num7 + num9 / 2, 0, 3);
				}
				else
				{
					T98.tahoma_7_green2.M898(g, t4.moreInfo, num3 + 5, num4 + 5, 0);
					T157.M1785(g, T54.efs[98].arrEfInfo[0].idImg, num6 + num8 / 2, num7 + num9 / 2, 0, 3);
				}
			}
		}
		M1335(g);
	}

	private void M1335(T99 g)
	{
		g.M918(-g.M920(), -g.M921());
		if ((cmy > 24 && currentListLength > 0) || (Equals(T51.panel) && typeShop == 2 && maxPageShop[currentTabIndex] > 1))
		{
			g.M940(T101.imgHP, 0, 0, 9, 6, 1, xScroll + wScroll - 12, yScroll + 3, 0);
		}
		if ((cmy < cmyLim && currentListLength > 0) || (Equals(T51.panel) && typeShop == 2 && maxPageShop[currentTabIndex] > 1))
		{
			g.M940(T101.imgHP, 0, 0, 9, 6, 0, xScroll + wScroll - 12, yScroll + hScroll - 8, 0);
		}
	}

	private void M1336(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < strTool.Length; i++)
		{
			int num = xScroll;
			int num2 = yScroll + i * ITEM_HEIGHT;
			int num3 = wScroll - 1;
			int h = ITEM_HEIGHT - 1;
			if (num2 - cmy > yScroll + hScroll || num2 - cmy < yScroll - ITEM_HEIGHT)
			{
				continue;
			}
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num, num2, num3, h);
			T98.tahoma_7b_dark.M898(g, strTool[i], xScroll + wScroll / 2, num2 + 6, T98.CENTER);
			if (!strTool[i].Equals(mResources.gameInfo))
			{
				continue;
			}
			for (int j = 0; j < vGameInfo.M1113(); j++)
			{
				if (!((T204)vGameInfo.M1114(j)).hasRead)
				{
					if (T51.gameTick % 20 > 10)
					{
						g.M948(imgNew, num + 10, num2 + 10, 3);
					}
					break;
				}
			}
		}
		M1335(g);
	}

	private void M1337(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < contenInfo.Length; i++)
		{
			int num = yScroll + i * 15;
			if (num - cmy <= yScroll + hScroll && num - cmy >= yScroll - ITEM_HEIGHT)
			{
				T98.tahoma_7b_dark.M898(g, contenInfo[i], xScroll + 5, num + 6, T98.LEFT);
			}
		}
		M1335(g);
	}

	private void M1338(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < vGameInfo.M1113(); i++)
		{
			T204 t = (T204)vGameInfo.M1114(i);
			int num = xScroll;
			int num2 = yScroll + i * ITEM_HEIGHT;
			int num3 = wScroll - 1;
			int h = ITEM_HEIGHT - 1;
			if (num2 - cmy <= yScroll + hScroll && num2 - cmy >= yScroll - ITEM_HEIGHT)
			{
				g.M933((i != selected) ? 15196114 : 16383818);
				g.M932(num, num2, num3, h);
				T98.tahoma_7b_dark.M898(g, t.main, xScroll + wScroll / 2, num2 + 6, T98.CENTER);
				if (!t.hasRead && T51.gameTick % 20 > 10)
				{
					g.M948(imgNew, num + 10, num2 + 10, 3);
				}
			}
		}
		M1335(g);
	}

	private void M1339(T99 g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		int num = T13.M113().nClass.skillTemplates.Length;
		for (int i = 0; i < num + 6; i++)
		{
			int num2 = xScroll + 30;
			int num3 = yScroll + i * ITEM_HEIGHT;
			int num4 = wScroll - 30;
			int h = ITEM_HEIGHT - 1;
			int num5 = xScroll;
			int num6 = yScroll + i * ITEM_HEIGHT;
			if (num3 - cmy > yScroll + hScroll || num3 - cmy < yScroll - ITEM_HEIGHT)
			{
				continue;
			}
			g.M933((i != selected) ? 15196114 : 16383818);
			if (i == 5)
			{
				g.M933((i != selected) ? 16765060 : 16776068);
			}
			g.M932(num2, num3, num4, h);
			g.M948(T54.imgSkill, num5, num6, 0);
			if (i == 0)
			{
				T157.M1785(g, 567, num5 + 4, num6 + 4, 0, 0);
				string st = mResources.HP + " " + mResources.root + ": " + T122.M1192(T13.M113().cHPGoc);
				T98.tahoma_7b_blue.M898(g, st, num2 + 5, num3 + 3, 0);
				T98.tahoma_7_green2.M898(g, T122.M1192(T13.M113().cHPGoc + 1000) + " " + mResources.potential + ": " + mResources.increase + " " + T13.M113().hpFrom1000TiemNang, num2 + 5, num3 + 15, 0);
			}
			if (i == 1)
			{
				T157.M1785(g, 569, num5 + 4, num6 + 4, 0, 0);
				string st2 = mResources.KI + " " + mResources.root + ": " + T122.M1192(T13.M113().cMPGoc);
				T98.tahoma_7b_blue.M898(g, st2, num2 + 5, num3 + 3, 0);
				T98.tahoma_7_green2.M898(g, T122.M1192(T13.M113().cMPGoc + 1000) + " " + mResources.potential + ": " + mResources.increase + " " + T13.M113().mpFrom1000TiemNang, num2 + 5, num3 + 15, 0);
			}
			if (i == 2)
			{
				T157.M1785(g, 568, num5 + 4, num6 + 4, 0, 0);
				string st3 = mResources.hit_point + " " + mResources.root + ": " + T122.M1192(T13.M113().cDamGoc);
				T98.tahoma_7b_blue.M898(g, st3, num2 + 5, num3 + 3, 0);
				T98.tahoma_7_green2.M898(g, T122.M1192(T13.M113().cDamGoc * 100) + " " + mResources.potential + ": " + mResources.increase + " " + T13.M113().damFrom1000TiemNang, num2 + 5, num3 + 15, 0);
			}
			if (i == 3)
			{
				T157.M1785(g, 721, num5 + 4, num6 + 4, 0, 0);
				string st4 = mResources.armor + " " + mResources.root + ": " + T122.M1192(T13.M113().cDefGoc);
				T98.tahoma_7b_blue.M898(g, st4, num2 + 5, num3 + 3, 0);
				T98.tahoma_7_green2.M898(g, T122.M1192(500000 + T13.M113().cDefGoc * 100000) + " " + mResources.potential + ": " + mResources.increase + " " + T13.M113().defFrom1000TiemNang, num2 + 5, num3 + 15, 0);
			}
			if (i == 4)
			{
				T157.M1785(g, 719, num5 + 4, num6 + 4, 0, 0);
				string st5 = mResources.critical + " " + mResources.root + ": " + T13.M113().cCriticalGoc + "%";
				long num7 = 50000000L;
				for (int j = 0; j < T13.M113().cCriticalGoc; j++)
				{
					num7 *= 5L;
				}
				T98.tahoma_7b_blue.M898(g, st5, num2 + 5, num3 + 3, 0);
				long m = num7;
				T98.tahoma_7_green2.M898(g, T122.M1192(m) + " " + mResources.potential + ": " + mResources.increase + " " + T13.M113().criticalFrom1000Tiemnang, num2 + 5, num3 + 15, 0);
			}
			if (i == 5)
			{
				if (specialInfo != null)
				{
					T157.M1785(g, spearcialImage, num5 + 4, num6 + 4, 0, 0);
					string[] array = T98.tahoma_7.M907(specialInfo, 120);
					for (int k = 0; k < array.Length; k++)
					{
						T98.tahoma_7_green2.M898(g, array[k], num2 + 5, num3 + 3 + k * 12, 0);
					}
				}
				else
				{
					T98.tahoma_7_green2.M898(g, string.Empty, num2 + 5, num3 + 9, 0);
				}
			}
			if (i < 6)
			{
				continue;
			}
			T155 t = T13.M113().nClass.skillTemplates[i - 6];
			T157.M1785(g, t.iconId, num5 + 4, num6 + 4, 0, 0);
			T149 t2 = T13.M113().M119(t);
			if (t2 != null)
			{
				T98.tahoma_7b_blue.M898(g, t.name, num2 + 5, num3 + 3, 0);
				T98.tahoma_7_blue.M898(g, mResources.level + ": " + t2.point, num2 + num4 - 5, num3 + 3, T98.RIGHT);
				if (t2.point == t.maxPoint)
				{
					T98.tahoma_7_green2.M898(g, mResources.max_level_reach, num2 + 5, num3 + 15, 0);
					continue;
				}
				T149 t3 = t.skills[t2.point];
				T98.tahoma_7_green2.M898(g, mResources.level + " " + (t2.point + 1) + " " + mResources.need + " " + T137.M1533(t3.powRequire) + " " + mResources.potential, num2 + 5, num3 + 15, 0);
			}
			else
			{
				T149 t4 = t.skills[0];
				T98.tahoma_7b_green.M898(g, t.name, num2 + 5, num3 + 3, 0);
				T98.tahoma_7_green2.M898(g, mResources.need_upper + " " + T137.M1533(t4.powRequire) + " " + mResources.potential_to_learn, num2 + 5, num3 + 15, 0);
			}
		}
		M1335(g);
	}

	private void M1340(T99 g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < mapNames.Length; i++)
		{
			int num = yScroll + i * ITEM_HEIGHT;
			int h = ITEM_HEIGHT - 1;
			if (num - cmy <= yScroll + hScroll && num - cmy >= yScroll - ITEM_HEIGHT)
			{
				g.M933((i != selected) ? 15196114 : 16383818);
				g.M932(xScroll, num, wScroll, h);
				T98.tahoma_7b_blue.M898(g, mapNames[i], 5, num + 1, 0);
				T98.tahoma_7_grey.M898(g, planetNames[i], 5, num + 11, 0);
			}
		}
		M1335(g);
	}

	private void M1341(T99 g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		int[] zones = T54.M559().zones;
		int[] pts = T54.M559().pts;
		for (int i = 0; i < pts.Length; i++)
		{
			int num = xScroll + 36;
			int num2 = yScroll + i * ITEM_HEIGHT;
			int num3 = wScroll - 36;
			int h = ITEM_HEIGHT - 1;
			int num4 = xScroll;
			int y = yScroll + i * ITEM_HEIGHT;
			int num5 = 34;
			int h2 = ITEM_HEIGHT - 1;
			if (num2 - cmy > yScroll + hScroll || num2 - cmy < yScroll - ITEM_HEIGHT)
			{
				continue;
			}
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num, num2, num3, h);
			g.M933(zoneColor[pts[i]]);
			g.M932(num4, y, num5, h2);
			if (zones[i] != -1)
			{
				if (pts[i] != 1)
				{
					T98.tahoma_7_yellow.M898(g, zones[i] + string.Empty, num4 + num5 / 2, num2 + 6, T98.CENTER);
				}
				else
				{
					T98.tahoma_7_grey.M898(g, zones[i] + string.Empty, num4 + num5 / 2, num2 + 6, T98.CENTER);
				}
				T98.tahoma_7_green2.M898(g, T54.M559().numPlayer[i] + "/" + T54.M559().maxPlayer[i], num + 5, num2 + 6, 0);
			}
			if (T54.M559().rankName1[i] != null)
			{
				T98.tahoma_7_grey.M898(g, T54.M559().rankName1[i] + "(Top " + T54.M559().rank1[i] + ")", num + num3 - 2, num2 + 1, T98.RIGHT);
				T98.tahoma_7_grey.M898(g, T54.M559().rankName2[i] + "(Top " + T54.M559().rank2[i] + ")", num + num3 - 2, num2 + 11, T98.RIGHT);
			}
		}
		M1335(g);
	}

	private void M1342(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (currentListLength == 0)
		{
			return;
		}
		int num = (cmy + hScroll) / 24 + 1;
		if (num < hScroll / 24 + 1)
		{
			num = hScroll / 24 + 1;
		}
		if (num > currentListLength)
		{
			num = currentListLength;
		}
		int num2 = cmy / 24;
		if (num2 >= num)
		{
			num2 = num - 1;
		}
		if (num2 < 0)
		{
			num2 = 0;
		}
		for (int i = num2; i < num; i++)
		{
			int num3 = xScroll;
			int num4 = yScroll + i * ITEM_HEIGHT;
			int num5 = 24;
			int num6 = ITEM_HEIGHT - 1;
			int num7 = xScroll + 24;
			int num8 = yScroll + i * ITEM_HEIGHT;
			int num9 = wScroll - 24;
			int h = ITEM_HEIGHT - 1;
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num7, num8, num9, h);
			g.M933((i != selected) ? 9993045 : 9541120);
			g.M932(num3, num4, num5, num6);
			T157.M1785(g, T13.M113().imgSpeacialSkill[currentTabIndex][i], num3 + num5 / 2, num4 + num6 / 2, 0, 3);
			string[] array = T98.tahoma_7_grey.M907(T13.M113().infoSpeacialSkill[currentTabIndex][i], 140);
			for (int j = 0; j < array.Length; j++)
			{
				T98.tahoma_7_grey.M898(g, array[j], num7 + 5, num8 + 1 + j * 11, 0);
			}
		}
		M1335(g);
	}

	private void M1343(T99 g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		try
		{
			T79[] arrItemBox = T13.M113().arrItemBox;
			currentListLength = arrItemBox.Length;
			for (int i = 0; i < currentListLength; i++)
			{
				int num = xScroll + 36;
				int num2 = yScroll + i * ITEM_HEIGHT;
				int num3 = wScroll - 36;
				int h = ITEM_HEIGHT - 1;
				int num4 = xScroll;
				int num5 = yScroll + i * ITEM_HEIGHT;
				int num6 = 34;
				int num7 = ITEM_HEIGHT - 1;
				if (num2 - cmy > yScroll + hScroll || num2 - cmy < yScroll - ITEM_HEIGHT)
				{
					continue;
				}
				g.M933((i != selected) ? 15196114 : 16383818);
				g.M932(num, num2, num3, h);
				g.M933((i != selected) ? 9993045 : 9541120);
				T79 t = arrItemBox[i];
				if (t != null)
				{
					for (int j = 0; j < t.itemOption.Length; j++)
					{
						if (t.itemOption[j].optionTemplate.id == 72 && t.itemOption[j].param > 0)
						{
							sbyte id = M1449(t.itemOption[j].param);
							int num8 = M1448(id);
							if (num8 != -1)
							{
								g.M933((i != selected) ? M1448(id) : M1448(id));
							}
						}
						if (t.M796() > 0)
						{
							int x = num + num3 - 5;
							T98.bigNumber_yellow.M898(g, t.M796() + "s", x, num2 + 1, T98.RIGHT);
							T98.tahoma_7_blue.M898(g, t.M797(), x, num2 + 11, T98.RIGHT);
						}
					}
				}
				g.M932(num4, num5, num6, num7);
				if (t == null)
				{
					continue;
				}
				string text = string.Empty;
				T98 t2 = T98.tahoma_7_green2;
				if (t.itemOption != null)
				{
					for (int k = 0; k < t.itemOption.Length; k++)
					{
						if (t.itemOption[k].optionTemplate.id == 72)
						{
							text = " [+" + t.itemOption[k].M830() + "]";
						}
						if (t.itemOption[k].optionTemplate.id == 41)
						{
							if (t.itemOption[k].param == 1)
							{
								t2 = M1450(0);
							}
							else if (t.itemOption[k].param == 2)
							{
								t2 = M1450(2);
							}
							else if (t.itemOption[k].param == 3)
							{
								t2 = M1450(8);
							}
							else if (t.itemOption[k].param == 4)
							{
								t2 = M1450(7);
							}
						}
					}
				}
				t2.M898(g, t.template.name + text, num + 5, num2 + 1, 0);
				string text2 = string.Empty;
				if (t.itemOption != null)
				{
					if (t.itemOption.Length != 0 && t.itemOption[0] != null)
					{
						text2 += t.itemOption[0].M830();
					}
					T98 t3 = T98.tahoma_7_blue;
					if (t.compare < 0 && t.template.type != 5)
					{
						t3 = T98.tahoma_7_red;
					}
					t3.M898(g, text2, num + 5, num2 + 11, T98.LEFT);
				}
				T157.M1785(g, t.template.iconID, num4 + num6 / 2, num5 + num7 / 2, 0, 3);
				if (t.itemOption != null)
				{
					for (int l = 0; l < t.itemOption.Length; l++)
					{
						M1451(g, t.itemOption[l].optionTemplate.id, t.itemOption[l].param, num4, num5, num6, num7);
					}
					for (int m = 0; m < t.itemOption.Length; m++)
					{
						M1452(g, t.itemOption[m].optionTemplate.id, t.itemOption[m].param, num4, num5, num6, num7);
					}
				}
				if (t.quantity > 1)
				{
					T98.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num4 + num6, num5 + num7 - T98.tahoma_7_yellow.M912(), 1);
				}
			}
		}
		catch (Exception)
		{
		}
		M1335(g);
	}

	public T95 M1344()
	{
		if (selected < 2)
		{
			return null;
		}
		if (selected > ((member == null) ? myMember.M1113() : member.M1113()) + 1)
		{
			return null;
		}
		if (member != null)
		{
			return (T95)member.M1114(selected - 2);
		}
		return (T95)myMember.M1114(selected - 2);
	}

	public T19 M1345()
	{
		if (selected < 2)
		{
			return null;
		}
		if (selected > T19.vMessage.M1113() + 1)
		{
			return null;
		}
		return (T19)T19.vMessage.M1114(selected - 2);
	}

	public T16 M1346()
	{
		if (selected < 2)
		{
			return null;
		}
		if (selected > clans.Length + 1)
		{
			return null;
		}
		return clans[selected - 2];
	}

	private void M1347(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (logChat.M1113() == 0)
		{
			T98.tahoma_7_green2.M898(g, mResources.no_msg, xScroll + wScroll / 2, yScroll + hScroll / 2 - T98.tahoma_7.M912() / 2 + 24, 2);
		}
		for (int i = 0; i < currentListLength; i++)
		{
			int num = xScroll;
			int num2 = yScroll + i * ITEM_HEIGHT;
			int num3 = 24;
			int h = ITEM_HEIGHT - 1;
			int num4 = xScroll + 24;
			int num5 = yScroll + i * ITEM_HEIGHT;
			int num6 = wScroll - 24;
			int num7 = ITEM_HEIGHT - 1;
			if (i == 0)
			{
				g.M933(15196114);
				g.M932(num, num5, wScroll, num7);
				g.M948((i != selected) ? T54.imgLbtn2 : T54.imgLbtnFocus2, xScroll + wScroll - 5, num5 + 2, T163.TOP_RIGHT);
				((i != selected) ? T98.tahoma_7b_dark : T98.tahoma_7b_green2).M898(g, (!isViewChatServer) ? mResources.on : mResources.off, xScroll + wScroll - 22, num5 + 7, 2);
				T98.tahoma_7_grey.M898(g, (!isViewChatServer) ? mResources.onPlease : mResources.offPlease, xScroll + 5, num5 + num7 / 2 - 4, T98.LEFT);
				continue;
			}
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num4, num5, num6, num7);
			g.M933((i != selected) ? 9993045 : 9541120);
			g.M932(num, num2, num3, h);
			T67 t = (T67)logChat.M1114(i - 1);
			if (t.charInfo.headICON != -1)
			{
				T157.M1785(g, t.charInfo.headICON, num, num2, 0, 0);
			}
			else
			{
				T127 t2 = T54.parts[t.charInfo.head];
				T157.M1785(g, t2.pi[T13.CharInfo[0][0][0]].id, num + t2.pi[T13.CharInfo[0][0][0]].dx, num2 + t2.pi[T13.CharInfo[0][0][0]].dy, 0, 0);
			}
			g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
			T98.tahoma_7b_green2.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
			if (!t.isChatServer)
			{
				T98.tahoma_7_blue.M898(g, T137.M1531(t.s, "|", 0)[2], num4 + 5, num5 + 11, 0);
			}
			else
			{
				T98.tahoma_7_red.M898(g, T137.M1531(t.s, "|", 0)[2], num4 + 5, num5 + 11, 0);
			}
		}
		M1335(g);
	}

	private void M1348(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		for (int i = 0; i < currentListLength; i++)
		{
			int num = xScroll + 26;
			int num2 = yScroll + i * ITEM_HEIGHT;
			int num3 = wScroll - 26;
			int h = ITEM_HEIGHT - 1;
			int num4 = xScroll;
			int num5 = yScroll + i * ITEM_HEIGHT;
			int num6 = 24;
			int num7 = ITEM_HEIGHT - 1;
			if (num2 - cmy > yScroll + hScroll || num2 - cmy < yScroll - ITEM_HEIGHT)
			{
				continue;
			}
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num, num2, num3, h);
			g.M933((i != selected) ? 9993045 : 9541120);
			g.M932(num4, num5, num6, num7);
			T79 t = (T79)vFlag.M1114(i);
			if (t == null)
			{
				continue;
			}
			T98.tahoma_7_green2.M898(g, t.template.name, num + 5, num2 + 1, 0);
			string text = string.Empty;
			if (t.itemOption != null && t.itemOption.Length >= 1)
			{
				if (t.itemOption[0] != null && t.itemOption[0].optionTemplate.id != 102 && t.itemOption[0].optionTemplate.id != 107)
				{
					text += t.itemOption[0].M830();
				}
				T98.tahoma_7_blue.M898(g, text, num + 5, num2 + 11, 0);
				T157.M1785(g, t.template.iconID, num4 + num6 / 2, num5 + num7 / 2, 0, 3);
			}
		}
		M1335(g);
	}

	private void M1349(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (currentListLength == 0)
		{
			T98.tahoma_7_green2.M898(g, mResources.no_enemy, xScroll + wScroll / 2, yScroll + hScroll / 2 - T98.tahoma_7.M912() / 2, 2);
			return;
		}
		for (int i = 0; i < currentListLength; i++)
		{
			int num = xScroll;
			int num2 = yScroll + i * ITEM_HEIGHT;
			int num3 = 24;
			int h = ITEM_HEIGHT - 1;
			int num4 = xScroll + 24;
			int num5 = yScroll + i * ITEM_HEIGHT;
			int num6 = wScroll - 24;
			int h2 = ITEM_HEIGHT - 1;
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num4, num5, num6, h2);
			g.M933((i != selected) ? 9993045 : 9541120);
			g.M932(num, num2, num3, h);
			T67 t = (T67)vEnemy.M1114(i);
			if (t.charInfo.headICON != -1)
			{
				T157.M1785(g, t.charInfo.headICON, num, num2, 0, 0);
			}
			else
			{
				T127 t2 = T54.parts[t.charInfo.head];
				T157.M1785(g, t2.pi[T13.CharInfo[0][0][0]].id, num + t2.pi[T13.CharInfo[0][0][0]].dx, num2 + 3 + t2.pi[T13.CharInfo[0][0][0]].dy, 0, 0);
			}
			g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
			if (t.isOnline)
			{
				T98.tahoma_7b_green.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
				T98.tahoma_7_blue.M898(g, t.s, num4 + 5, num5 + 11, 0);
			}
			else
			{
				T98.tahoma_7_grey.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
				T98.tahoma_7_grey.M898(g, t.s, num4 + 5, num5 + 11, 0);
			}
		}
		M1335(g);
	}

	private void M1350(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (currentListLength == 0)
		{
			T98.tahoma_7_green2.M898(g, mResources.no_friend, xScroll + wScroll / 2, yScroll + hScroll / 2 - T98.tahoma_7.M912() / 2, 2);
			return;
		}
		for (int i = 0; i < currentListLength; i++)
		{
			int num = xScroll;
			int num2 = yScroll + i * ITEM_HEIGHT;
			int num3 = 24;
			int h = ITEM_HEIGHT - 1;
			int num4 = xScroll + 24;
			int num5 = yScroll + i * ITEM_HEIGHT;
			int num6 = wScroll - 24;
			int h2 = ITEM_HEIGHT - 1;
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num4, num5, num6, h2);
			g.M933((i != selected) ? 9993045 : 9541120);
			g.M932(num, num2, num3, h);
			T67 t = (T67)vFriend.M1114(i);
			if (t.charInfo.headICON != -1)
			{
				T157.M1785(g, t.charInfo.headICON, num, num2, 0, 0);
			}
			else
			{
				T127 t2 = T54.parts[t.charInfo.head];
				T157.M1785(g, t2.pi[T13.CharInfo[0][0][0]].id, num + t2.pi[T13.CharInfo[0][0][0]].dx, num2 + 3 + t2.pi[T13.CharInfo[0][0][0]].dy, 0, 0);
			}
			g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
			if (t.isOnline)
			{
				T98.tahoma_7b_green.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
				T98.tahoma_7_blue.M898(g, t.s, num4 + 5, num5 + 11, 0);
			}
			else
			{
				T98.tahoma_7_grey.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
				T98.tahoma_7_grey.M898(g, t.s, num4 + 5, num5 + 11, 0);
			}
		}
		M1335(g);
	}

	public void M1351(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < vPlayerMenu.M1113(); i++)
		{
			int x = xScroll;
			int num = yScroll + i * ITEM_HEIGHT;
			int num2 = wScroll - 1;
			int h = ITEM_HEIGHT - 1;
			if (num - cmy <= yScroll + hScroll && num - cmy >= yScroll - ITEM_HEIGHT)
			{
				T22 t = (T22)vPlayerMenu.M1114(i);
				g.M933((i != selected) ? 15196114 : 16383818);
				g.M932(x, num, num2, h);
				if (t.caption2.Equals(string.Empty))
				{
					T98.tahoma_7b_dark.M898(g, t.caption, xScroll + wScroll / 2, num + 6, T98.CENTER);
					continue;
				}
				T98.tahoma_7b_dark.M898(g, t.caption, xScroll + wScroll / 2, num + 1, T98.CENTER);
				T98.tahoma_7b_dark.M898(g, t.caption2, xScroll + wScroll / 2, num + 11, T98.CENTER);
			}
		}
		M1335(g);
	}

	private void M1352(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(-cmx, -cmy);
		g.M933(0);
		int num = xScroll + wScroll / 2 - clansOption.Length * TAB_W / 2;
		if (currentListLength == 2)
		{
			T98.tahoma_7_green2.M898(g, clanReport, xScroll + wScroll / 2, yScroll + 24 + hScroll / 2 - T98.tahoma_7.M912() / 2, 2);
			if (isMessage && myMember.M1113() == 1)
			{
				for (int i = 0; i < mResources.clanEmpty.Length; i++)
				{
					T98.tahoma_7b_dark.M898(g, mResources.clanEmpty[i], xScroll + wScroll / 2, yScroll + 24 + hScroll / 2 - mResources.clanEmpty.Length * 12 / 2 + i * 12, T98.CENTER);
				}
			}
		}
		for (int j = 0; j < currentListLength; j++)
		{
			int num2 = xScroll;
			int num3 = yScroll + j * ITEM_HEIGHT;
			int num4 = 24;
			int num5 = ITEM_HEIGHT - 1;
			int num6 = xScroll + 24;
			int num7 = yScroll + j * ITEM_HEIGHT;
			int num8 = wScroll - 24;
			int num9 = ITEM_HEIGHT - 1;
			if (num7 - cmy > yScroll + hScroll || num7 - cmy < yScroll - ITEM_HEIGHT)
			{
				continue;
			}
			switch (j)
			{
			case 1:
				g.M933((j != selected) ? 15196114 : 16383818);
				g.M932(xScroll, num7, wScroll, num9);
				if (clanInfo != null)
				{
					T98.tahoma_7b_dark.M898(g, clanInfo, xScroll + wScroll / 2, num7 + 6, T98.CENTER);
				}
				continue;
			case 0:
			{
				for (int k = 0; k < clansOption.Length; k++)
				{
					g.M933((k != cSelected || j != selected) ? 15723751 : 16383818);
					g.M932(num + k * TAB_W, num7, TAB_W - 1, 23);
					for (int l = 0; l < clansOption[k].Length; l++)
					{
						T98.tahoma_7_grey.M898(g, clansOption[k][l], num + k * TAB_W + TAB_W / 2, yScroll + l * 11, T98.CENTER);
					}
				}
				continue;
			}
			}
			if (isSearchClan)
			{
				if (clans == null || clans.Length == 0)
				{
					continue;
				}
				g.M933((j != selected) ? 15196114 : 16383818);
				g.M932(num6, num7, num8, num9);
				g.M933((j != selected) ? 9993045 : 9541120);
				g.M932(num2, num3, num4, num5);
				if (T17.M289(clans[j - 2].imgID))
				{
					if (T17.M288((sbyte)clans[j - 2].imgID).idImage != null)
					{
						T157.M1785(g, T17.M288((sbyte)clans[j - 2].imgID).idImage[0], num2 + num4 / 2, num3 + num5 / 2, 0, T163.VCENTER_HCENTER);
					}
				}
				else
				{
					T17 t = new T17();
					t.ID = clans[j - 2].imgID;
					if (!T17.M289(t.ID))
					{
						T17.M287(t);
					}
				}
				T98.tahoma_7b_green2.M898(g, clans[j - 2].name, num6 + 5, num7, 0);
				g.M922(num6, num7, num8 - 10, num9);
				T98.tahoma_7_blue.M898(g, clans[j - 2].slogan, num6 + 5, num7 + 11, 0);
				g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
				T98.tahoma_7_green2.M898(g, clans[j - 2].currMember + "/" + clans[j - 2].maxMember, num6 + num8 - 5, num7, T98.RIGHT);
				continue;
			}
			if (isViewMember)
			{
				g.M933((j != selected) ? 15196114 : 16383818);
				g.M932(num6, num7, num8, num9);
				g.M933((j != selected) ? 9993045 : 9541120);
				g.M932(num2, num3, num4, num5);
				T95 t2 = ((member == null) ? ((T95)myMember.M1114(j - 2)) : ((T95)member.M1114(j - 2)));
				if (t2.headICON != -1)
				{
					T157.M1785(g, t2.headICON, num2, num3, 0, 0);
				}
				else
				{
					T127 t3 = T54.parts[t2.head];
					T157.M1785(g, t3.pi[T13.CharInfo[0][0][0]].id, num2 + t3.pi[T13.CharInfo[0][0][0]].dx, num3 + 3 + t3.pi[T13.CharInfo[0][0][0]].dy, 0, 0);
				}
				g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
				T98 t4 = T98.tahoma_7b_dark;
				if (t2.role == 0)
				{
					t4 = T98.tahoma_7b_red;
				}
				else if (t2.role == 1)
				{
					t4 = T98.tahoma_7b_green;
				}
				else if (t2.role == 2)
				{
					t4 = T98.tahoma_7b_green2;
				}
				t4.M898(g, t2.name, num6 + 5, num7, 0);
				T98.tahoma_7_blue.M898(g, mResources.power + ": " + t2.powerPoint, num6 + 5, num7 + 11, 0);
				T157.M1785(g, 7223, num6 + num8 - 7, num7 + 12, 0, 3);
				T98.tahoma_7_blue.M898(g, string.Empty + t2.clanPoint, num6 + num8 - 15, num7 + 6, T98.RIGHT);
				continue;
			}
			if (!isMessage || T19.vMessage.M1113() == 0)
			{
				continue;
			}
			T19 t5 = (T19)T19.vMessage.M1114(j - 2);
			g.M933((j != selected || t5.option != null) ? 15196114 : 16383818);
			g.M932(num2, num3, num8 + num4, num9);
			t5.M291(g, num2, num3);
			if (t5.option == null)
			{
				continue;
			}
			int num10 = xScroll + wScroll - 2 - t5.option.Length * 40;
			for (int m = 0; m < t5.option.Length; m++)
			{
				if (m == cSelected && j == selected)
				{
					g.M948(T54.imgLbtnFocus2, num10 + m * 40 + 20, num7 + num9 / 2, T163.VCENTER_HCENTER);
					T98.tahoma_7b_green2.M898(g, t5.option[m], num10 + m * 40 + 20, num7 + 6, T98.CENTER);
				}
				else
				{
					g.M948(T54.imgLbtn2, num10 + m * 40 + 20, num7 + num9 / 2, T163.VCENTER_HCENTER);
					T98.tahoma_7b_dark.M898(g, t5.option[m], num10 + m * 40 + 20, num7 + 6, T98.CENTER);
				}
			}
		}
		M1335(g);
	}

	private void M1353(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (currentListLength == 0)
		{
			T98.tahoma_7_green2.M898(g, mResources.no_mission, xScroll + wScroll / 2, yScroll + hScroll / 2 - T98.tahoma_7.M912() / 2, 2);
		}
		else
		{
			if (T13.M113().arrArchive == null || T13.M113().arrArchive.Length != currentListLength)
			{
				return;
			}
			for (int i = 0; i < currentListLength; i++)
			{
				int num = xScroll;
				int num2 = yScroll + i * ITEM_HEIGHT;
				int num3 = wScroll;
				int num4 = ITEM_HEIGHT - 1;
				T3 t = T13.M113().arrArchive[i];
				g.M933((i != selected || ((t.isRecieve || t.isFinish) && (!t.isRecieve || !t.isFinish))) ? 15196114 : 16383818);
				g.M932(num, num2, num3, num4);
				if (t == null)
				{
					continue;
				}
				if (!t.isFinish)
				{
					T98.tahoma_7.M898(g, t.info1, num + 5, num2, 0);
					T98.tahoma_7_green.M898(g, t.money + " " + mResources.RUBY, num + num3 - 5, num2, T98.RIGHT);
					T98.tahoma_7_red.M898(g, t.info2, num + 5, num2 + 11, 0);
				}
				else if (t.isFinish && !t.isRecieve)
				{
					T98.tahoma_7.M898(g, t.info1, num + 5, num2, 0);
					T98.tahoma_7_blue.M898(g, mResources.reward_mission + t.money + " " + mResources.RUBY, num + 5, num2 + 11, 0);
					if (i == selected)
					{
						T98.tahoma_7b_green2.M898(g, mResources.receive_upper, num + num3 - 20, num2 + 6, T98.CENTER);
						T98.tahoma_7b_dark.M898(g, mResources.receive_upper, num + num3 - 20, num2 + 6, T98.CENTER);
					}
					else
					{
						g.M948(T54.imgLbtn2, num + num3 - 20, num2 + num4 / 2, T163.VCENTER_HCENTER);
						T98.tahoma_7b_dark.M898(g, mResources.receive_upper, num + num3 - 20, num2 + 6, T98.CENTER);
					}
				}
				else if (t.isFinish && t.isRecieve)
				{
					T98.tahoma_7_green.M898(g, t.info1, num + 5, num2, 0);
					T98.tahoma_7_green.M898(g, t.info2, num + 5, num2 + 11, 0);
				}
			}
			M1335(g);
		}
	}

	private void M1354(T99 g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		if (vItemCombine.M1113() == 0)
		{
			if (combineInfo != null)
			{
				for (int i = 0; i < combineInfo.Length; i++)
				{
					T98.tahoma_7b_dark.M898(g, combineInfo[i], xScroll + wScroll / 2, yScroll + hScroll / 2 - combineInfo.Length * 14 / 2 + i * 14 + 5, 2);
				}
			}
			return;
		}
		for (int j = 0; j < vItemCombine.M1113() + 1; j++)
		{
			int num = xScroll + 36;
			int num2 = yScroll + j * ITEM_HEIGHT;
			int num3 = wScroll - 36;
			int num4 = ITEM_HEIGHT - 1;
			int num5 = xScroll;
			int num6 = yScroll + j * ITEM_HEIGHT;
			int num7 = 34;
			int num8 = ITEM_HEIGHT - 1;
			if (num2 - cmy > yScroll + hScroll || num2 - cmy < yScroll - ITEM_HEIGHT)
			{
				continue;
			}
			if (j == vItemCombine.M1113())
			{
				if (vItemCombine.M1113() > 0)
				{
					if (!T51.isTouch && j == selected)
					{
						g.M933(16383818);
						g.M932(num5, num2, wScroll, num4 + 2);
					}
					if ((j == selected && keyTouchCombine == 1) || (!T51.isTouch && j == selected))
					{
						g.M948(T54.imgLbtnFocus, xScroll + wScroll / 2, num2 + num4 / 2 + 1, T163.VCENTER_HCENTER);
						T98.tahoma_7b_green2.M898(g, mResources.UPGRADE, xScroll + wScroll / 2, num2 + num4 / 2 - 4, T98.CENTER);
					}
					else
					{
						g.M948(T54.imgLbtn, xScroll + wScroll / 2, num2 + num4 / 2 + 1, T163.VCENTER_HCENTER);
						T98.tahoma_7b_dark.M898(g, mResources.UPGRADE, xScroll + wScroll / 2, num2 + num4 / 2 - 4, T98.CENTER);
					}
				}
				continue;
			}
			g.M933((j != selected) ? 15196114 : 16383818);
			g.M932(num, num2, num3, num4);
			g.M933((j != selected) ? 9993045 : 9541120);
			T79 t = (T79)vItemCombine.M1114(j);
			if (t != null)
			{
				for (int k = 0; k < t.itemOption.Length; k++)
				{
					if (t.itemOption[k].optionTemplate.id == 72 && t.itemOption[k].param > 0)
					{
						sbyte id = M1449(t.itemOption[k].param);
						if (M1448(id) != -1)
						{
							g.M933((j != selected) ? M1448(id) : M1448(id));
						}
					}
				}
			}
			g.M932(num5, num6, num7, num8);
			if (t == null)
			{
				continue;
			}
			string text = string.Empty;
			T98 t2 = T98.tahoma_7_green2;
			if (t.itemOption != null)
			{
				for (int l = 0; l < t.itemOption.Length; l++)
				{
					if (t.itemOption[l].optionTemplate.id == 72)
					{
						text = " [+" + t.itemOption[l].param + "]";
					}
					if (t.itemOption[l].optionTemplate.id == 41)
					{
						if (t.itemOption[l].param == 1)
						{
							t2 = M1450(0);
						}
						else if (t.itemOption[l].param == 2)
						{
							t2 = M1450(2);
						}
						else if (t.itemOption[l].param == 3)
						{
							t2 = M1450(8);
						}
						else if (t.itemOption[l].param == 4)
						{
							t2 = M1450(7);
						}
					}
				}
			}
			t2.M898(g, t.template.name + text, num + 5, num2 + 1, 0);
			string text2 = string.Empty;
			if (t.itemOption != null)
			{
				if (t.itemOption.Length != 0 && t.itemOption[0] != null && t.itemOption[0].optionTemplate.id != 102 && t.itemOption[0].optionTemplate.id != 107)
				{
					text2 += t.itemOption[0].M830();
				}
				T98 t3 = T98.tahoma_7_blue;
				if (t.compare < 0 && t.template.type != 5)
				{
					t3 = T98.tahoma_7_red;
				}
				if (t.itemOption.Length > 1)
				{
					for (int m = 1; m < t.itemOption.Length; m++)
					{
						if (t.itemOption[m] != null && t.itemOption[m].optionTemplate.id != 102 && t.itemOption[m].optionTemplate.id != 107)
						{
							text2 = text2 + "," + t.itemOption[m].M830();
						}
					}
				}
				t3.M898(g, text2, num + 5, num2 + 11, T98.LEFT);
			}
			T157.M1785(g, t.template.iconID, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
			if (t.itemOption != null)
			{
				for (int n = 0; n < t.itemOption.Length; n++)
				{
					M1451(g, t.itemOption[n].optionTemplate.id, t.itemOption[n].param, num5, num6, num7, num8);
				}
				for (int num9 = 0; num9 < t.itemOption.Length; num9++)
				{
					M1452(g, t.itemOption[num9].optionTemplate.id, t.itemOption[num9].param, num5, num6, num7, num8);
				}
			}
			if (t.quantity > 1)
			{
				T98.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num5 + num7, num6 + num8 - T98.tahoma_7_yellow.M912(), 1);
			}
		}
		M1335(g);
	}

	private void M1355(T99 g)
	{
		g.M933(16711680);
		T79[] arrItemBody = T13.M113().arrItemBody;
		T79[] arrItemBag = T13.M113().arrItemBag;
		currentListLength = arrItemBody.Length + arrItemBag.Length;
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		try
		{
			for (int i = 0; i < currentListLength; i++)
			{
				int num = xScroll + 36;
				int num2 = yScroll + i * ITEM_HEIGHT;
				int num3 = wScroll - 36;
				int h = ITEM_HEIGHT - 1;
				int num4 = xScroll;
				int num5 = yScroll + i * ITEM_HEIGHT;
				int num6 = 34;
				int num7 = ITEM_HEIGHT - 1;
				if (num2 - cmy > yScroll + hScroll || num2 - cmy < yScroll - ITEM_HEIGHT)
				{
					continue;
				}
				g.M933((i == selected) ? 16383818 : ((i >= arrItemBody.Length) ? 15723751 : 15196114));
				g.M932(num, num2, num3, h);
				g.M933((i == selected) ? 9541120 : ((i >= arrItemBody.Length) ? 11837316 : 9993045));
				T79 t = ((i >= arrItemBody.Length) ? arrItemBag[i - arrItemBody.Length] : arrItemBody[i]);
				if (t != null)
				{
					for (int j = 0; j < t.itemOption.Length; j++)
					{
						if (t.itemOption[j].optionTemplate.id == 72 && t.itemOption[j].param > 0)
						{
							byte id = (byte)M1449(t.itemOption[j].param);
							int num8 = M1448(id);
							if (num8 != -1)
							{
								g.M933((i != selected) ? M1448(id) : M1448(id));
							}
						}
					}
				}
				g.M932(num4, num5, num6, num7);
				if (t != null && t.isSelect && T51.panel.type == 12)
				{
					g.M933((i != selected) ? 6047789 : 7040779);
					g.M932(num4, num5, num6, num7);
				}
				if (t == null)
				{
					continue;
				}
				string text = string.Empty;
				T98 t2 = T98.tahoma_7_green2;
				if (t.itemOption != null)
				{
					for (int k = 0; k < t.itemOption.Length; k++)
					{
						if (t.itemOption[k].optionTemplate.id == 72)
						{
							text = " [+" + t.itemOption[k].param + "]";
						}
						if (t.itemOption[k].optionTemplate.id == 41)
						{
							if (t.itemOption[k].param == 1)
							{
								t2 = M1450(0);
							}
							else if (t.itemOption[k].param == 2)
							{
								t2 = M1450(2);
							}
							else if (t.itemOption[k].param == 3)
							{
								t2 = M1450(8);
							}
							else if (t.itemOption[k].param == 4)
							{
								t2 = M1450(7);
							}
						}
					}
				}
				t2.M898(g, t.template.name + text, num + 5, num2 + 1, 0);
				string text2 = string.Empty;
				if (t.itemOption != null)
				{
					if (t.itemOption.Length != 0 && t.itemOption[0] != null && t.itemOption[0].optionTemplate.id != 102 && t.itemOption[0].optionTemplate.id != 107)
					{
						text2 += t.itemOption[0].M830();
					}
					T98 t3 = T98.tahoma_7_blue;
					if (t.compare < 0 && t.template.type != 5)
					{
						t3 = T98.tahoma_7_red;
					}
					t3.M898(g, text2, num + 5, num2 + 11, T98.LEFT);
				}
				T157.M1785(g, t.template.iconID, num4 + num6 / 2, num5 + num7 / 2, 0, 3);
				if (t.quantity > 1)
				{
					T98.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num4 + num6, num5 + num7 - T98.tahoma_7_yellow.M912(), 1);
				}
				if (t.itemOption != null)
				{
					for (int l = 0; l < t.itemOption.Length; l++)
					{
						M1451(g, t.itemOption[l].optionTemplate.id, t.itemOption[l].param, num4, num5, num6, num7);
					}
					for (int m = 0; m < t.itemOption.Length; m++)
					{
						M1452(g, t.itemOption[m].optionTemplate.id, t.itemOption[m].param, num4, num5, num6, num7);
					}
				}
				if (t.M796() > 0)
				{
					int x = xScroll + wScroll - 5;
					T98.bigNumber_yellow.M898(g, t.M796() + "s", x, num2 + 1, T98.RIGHT);
					T98.tahoma_7_blue.M898(g, t.M797(), x, num2 + 11, T98.RIGHT);
				}
			}
		}
		catch (Exception)
		{
		}
		M1335(g);
	}

	private void M1356(T99 g)
	{
		if (type != 23 && type != 24)
		{
			if (type == 20)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.account, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 22)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.autoFunction, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 19)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.option, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 18)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.change_flag, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 13 && Equals(T51.panel2))
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.item_receive2, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 12 && T51.panel2 != null)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.UPGRADE, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 11)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.friend, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 16)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.enemy, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 15)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, topName, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 2 && T51.panel2 != null)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.chest, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 9)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.achievement_mission, xScroll + wScroll / 2, 59, T98.CENTER);
				return;
			}
			if (type == 3)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.select_zone, startTabPos + TAB_W / 2, 59, T98.CENTER);
				return;
			}
			if (type == 14)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				T98.tahoma_7b_dark.M898(g, mResources.select_map, startTabPos + TAB_W / 2, 59, T98.CENTER);
				return;
			}
			if (type == 4)
			{
				T98.tahoma_7b_dark.M898(g, mResources.map, startTabPos + TAB_W / 2, 59, T98.CENTER);
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				return;
			}
			if (type == 7)
			{
				T98.tahoma_7b_dark.M898(g, mResources.trangbi, startTabPos + TAB_W / 2, 59, T98.CENTER);
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				return;
			}
			if (type == 17)
			{
				T98.tahoma_7b_dark.M898(g, mResources.kigui, startTabPos + TAB_W / 2, 59, T98.CENTER);
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				return;
			}
			if (type == 8)
			{
				T98.tahoma_7b_dark.M898(g, mResources.msg, startTabPos + TAB_W / 2, 59, T98.CENTER);
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				return;
			}
			if (type == 10)
			{
				T98.tahoma_7b_dark.M898(g, mResources.wat_do_u_want, startTabPos + TAB_W / 2, 59, T98.CENTER);
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				return;
			}
			if (currentTabIndex == 3 && mainTabName.Length != 4)
			{
				g.M918(-cmx, 0);
			}
			for (int i = 0; i < currentTabName.Length; i++)
			{
				g.M933((i != currentTabIndex) ? 16773296 : 6805896);
				T133.M1481(g, startTabPos + i * TAB_W, 52, TAB_W - 1, 25, (i == currentTabIndex) ? 1 : 0, isButton: true);
				if (i == keyTouchTab)
				{
					g.M948(T80.imageFlare, startTabPos + i * TAB_W + TAB_W / 2, 62, 3);
				}
				T98 t = ((i != currentTabIndex) ? T98.tahoma_7_grey : T98.tahoma_7_green2);
				if (!currentTabName[i][1].Equals(string.Empty))
				{
					t.M898(g, currentTabName[i][0], startTabPos + i * TAB_W + TAB_W / 2, 53, T98.CENTER);
					t.M898(g, currentTabName[i][1], startTabPos + i * TAB_W + TAB_W / 2, 64, T98.CENTER);
				}
				else
				{
					t.M898(g, currentTabName[i][0], startTabPos + i * TAB_W + TAB_W / 2, 59, T98.CENTER);
				}
				if (type == 0 && currentTabName.Length == 5 && T54.isNewClanMessage && T51.gameTick % 4 == 0)
				{
					g.M948(T80.imageFlare, startTabPos + 3 * TAB_W + TAB_W / 2, 77, T99.BOTTOM | T99.HCENTER);
				}
			}
			g.M933(13524492);
			g.M932(1, 78, W - 2, 1);
		}
		else
		{
			g.M933(13524492);
			g.M932(X + 1, 78, W - 2, 1);
			T98.tahoma_7b_dark.M898(g, mResources.gameInfo, xScroll + wScroll / 2, 59, T98.CENTER);
		}
	}

	private void M1357(T99 g)
	{
		if (type != 13 || (currentTabIndex != 2 && !Equals(T51.panel2)))
		{
			g.M922(0, 0, T51.w, T51.h);
			g.M933(11837316);
			g.M932(X + 1, H - 15, W - 2, 14);
			g.M933(13524492);
			g.M932(X + 1, H - 15, W - 2, 1);
			g.M948(imgXu, X + 10, H - 7, 3);
			g.M948(imgLuong, X + 80, H - 8, 3);
			T98.tahoma_7_yellow.M902(g, T122.M1192(T13.M113().xu) + string.Empty, X + 20, H - 13, T98.LEFT, T98.tahoma_7_grey);
			T98.tahoma_7_yellow.M902(g, T122.M1192(T13.M113().luong) + string.Empty, X + 90, H - 13, T98.LEFT, T98.tahoma_7_grey);
			g.M948(imgLuongKhoa, X + 130, H - 8, 3);
			T98.tahoma_7_yellow.M902(g, T122.M1192(T13.M113().luongKhoa) + string.Empty, X + 140, H - 13, T98.LEFT, T98.tahoma_7_grey);
		}
	}

	private void M1358(T99 g)
	{
		if (T13.M113().clan == null)
		{
			T157.M1785(g, T13.M113().M108(), 25, 50, 0, 33);
			T98.tahoma_7b_white.M898(g, mResources.not_join_clan, (wScroll - 50) / 2 + 50, 20, T98.CENTER);
		}
		else if (!isViewMember)
		{
			T16 clan = T13.M113().clan;
			if (clan != null)
			{
				T157.M1785(g, T13.M113().M108(), 25, 50, 0, 33);
				T98.tahoma_7b_white.M902(g, clan.name, 60, 4, T98.LEFT, T98.tahoma_7b_dark);
				T98.tahoma_7_yellow.M902(g, mResources.achievement_point + ": " + clan.powerPoint, 60, 16, T98.LEFT, T98.tahoma_7_grey);
				T98.tahoma_7_yellow.M902(g, mResources.clan_point + ": " + clan.clanPoint, 60, 27, T98.LEFT, T98.tahoma_7_grey);
				T98.tahoma_7_yellow.M902(g, mResources.level + ": " + clan.level, 60, 38, T98.LEFT, T98.tahoma_7_grey);
				T172.M1899(g, clan.slogan, 60, 38, wScroll - 70, ITEM_HEIGHT, T98.tahoma_7_yellow);
			}
		}
		else
		{
			T16 t = ((currClan == null) ? T13.M113().clan : currClan);
			T157.M1785(g, T13.M113().M108(), 25, 51, 0, 33);
			T98.tahoma_7b_white.M902(g, t.name, 60, 4, T98.LEFT, T98.tahoma_7b_dark);
			T98.tahoma_7_yellow.M902(g, mResources.member + ": " + t.currMember + "/" + t.maxMember, 60, 16, T98.LEFT, T98.tahoma_7_grey);
			T98.tahoma_7_yellow.M902(g, mResources.clan_leader + ": " + t.leaderName, 60, 27, T98.LEFT, T98.tahoma_7_grey);
			T172.M1899(g, t.slogan, 60, 38, wScroll - 70, ITEM_HEIGHT, T98.tahoma_7_yellow);
		}
	}

	private void M1359(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T98.tahoma_7b_white.M902(g, mResources.dragon_ball + " " + T52.VERSION, 60, 4, T98.LEFT, T98.tahoma_7b_dark);
		T98.tahoma_7_yellow.M902(g, mResources.character + ": " + T13.M113().cName, 60, 16, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7_yellow.M902(g, mResources.account_server + " " + T144.nameServer[T144.ipSelect] + ":", 60, 27, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7_yellow.M902(g, (!T51.loginScr.tfUser.M1924().Equals(string.Empty)) ? T51.loginScr.tfUser.M1924() : mResources.not_register_yet, 60, 39, T98.LEFT, T98.tahoma_7_grey);
	}

	private void M1360(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T98.tahoma_7_yellow.M902(g, mResources.select_item, 60, 4, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7_yellow.M902(g, mResources.lock_trade, 60, 16, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7_yellow.M902(g, mResources.wait_opp_lock_trade, 60, 27, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7_yellow.M902(g, mResources.press_done, 60, 38, T98.LEFT, T98.tahoma_7_grey);
	}

	private void M1361(T99 g)
	{
		M1363(g, T13.M113());
	}

	private void M1362(T99 g)
	{
		T98.tahoma_7_yellow.M902(g, mResources.power + ": " + T122.M1192(T13.M114().cPower), X + 52, 4, T98.LEFT, T98.tahoma_7_grey);
		if (T13.M114().cPower > 0L)
		{
			T98.tahoma_7_yellow.M902(g, (!T13.M114().me) ? T13.M114().currStrLevel : T13.M114().M107(), X + 52, 16, T98.LEFT, T98.tahoma_7_grey);
		}
		if (T13.M114().cDamFull > 0)
		{
			T98.tahoma_7_yellow.M902(g, mResources.hit_point + ": " + T122.M1192(T13.M114().cDamFull), X + 52, 27, T98.LEFT, T98.tahoma_7_grey);
		}
		if (T13.M114().cMaxStamina > 0)
		{
			T98.tahoma_7_yellow.M902(g, string.Concat(new object[5]
			{
				mResources.vitality,
				": ",
				T122.M1192(T13.M114().cStamina),
				" / ",
				T122.M1192(T13.M114().cMaxStamina)
			}), X + 52, 38, T98.LEFT, T98.tahoma_7_grey);
		}
		g.M922(0, 0, T51.w, T51.h);
	}

	private void M1363(T99 g, T13 c)
	{
		T98.tahoma_7b_white.M902(g, ((T54.isNewMember == 1) ? "       " : string.Empty) + c.cName, X + 60, 4, T98.LEFT, T98.tahoma_7b_dark);
		if (T54.isNewMember == 1)
		{
			T157.M1785(g, 5427, X + 55, 4, 0, 0);
		}
		if (c.cMaxStamina > 0)
		{
			T98.tahoma_7_yellow.M902(g, mResources.vitality, X + 60, 16, T98.LEFT, T98.tahoma_7_grey);
			g.M948(T54.imgMPLost, X + 95, 19, 0);
			g.M922(95, w: c.cStamina * T99.M958(T54.imgMP) / c.cMaxStamina, y: X + 19, h: 20);
			g.M948(T54.imgMP, X + 95, 19, 0);
		}
		g.M922(0, 0, T51.w, T51.h);
		if (c.cPower > 0L)
		{
			T98.tahoma_7_yellow.M902(g, (!c.me) ? c.currStrLevel : c.M107(), X + 60, 27, T98.LEFT, T98.tahoma_7_grey);
		}
		T98.tahoma_7_yellow.M902(g, mResources.power + ": " + T122.M1192(c.cPower), X + 60, 38, T98.LEFT, T98.tahoma_7_grey);
	}

	private void M1364(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T98.tahoma_7b_white.M902(g, mResources.zone + " " + T174.zoneID, 60, 4, T98.LEFT, T98.tahoma_7b_dark);
		T98.tahoma_7_yellow.M902(g, T174.mapName, 60, 16, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7b_white.M898(g, T174.zoneID + string.Empty, 25, 27, T98.CENTER);
	}

	public int M1365(T79 item)
	{
		if (item == null)
		{
			return -1;
		}
		if (item.M805())
		{
			if (item.itemOption == null)
			{
				return -1;
			}
			T82 t = item.itemOption[0];
			if (t.optionTemplate.id == 22)
			{
				t.optionTemplate = T54.M559().iOptionTemplates[6];
				t.param *= 1000;
			}
			if (t.optionTemplate.id == 23)
			{
				t.optionTemplate = T54.M559().iOptionTemplates[7];
				t.param *= 1000;
			}
			T79 t2 = null;
			for (int i = 0; i < T13.M113().arrItemBody.Length; i++)
			{
				T79 t3 = T13.M113().arrItemBody[i];
				if (t.optionTemplate.id == 22)
				{
					t.optionTemplate = T54.M559().iOptionTemplates[6];
					t.param *= 1000;
				}
				if (t.optionTemplate.id == 23)
				{
					t.optionTemplate = T54.M559().iOptionTemplates[7];
					t.param *= 1000;
				}
				if (t3 != null && t3.itemOption != null && t3.template.type == item.template.type)
				{
					t2 = t3;
					break;
				}
			}
			if (t2 == null)
			{
				T137.M1513("5");
				isUp = true;
				return t.param;
			}
			int num = ((t2 == null || t2.itemOption == null) ? t.param : (t.param - t2.itemOption[0].param));
			if (num < 0)
			{
				isUp = false;
				return num;
			}
			isUp = true;
			return num;
		}
		return 0;
	}

	private void M1366(T99 g)
	{
		T98.tahoma_7b_white.M898(g, mResources.MENUGENDER[T174.planetID], 60, 4, T98.LEFT);
		string text = string.Empty;
		if (T174.mapID >= 135 && T174.mapID <= 138)
		{
			text = " " + mResources.tang + T174.zoneID;
		}
		T98.tahoma_7_yellow.M898(g, T174.mapName + text, 60, 16, T98.LEFT);
		T98.tahoma_7b_white.M898(g, mResources.quest_place + ": ", 60, 27, T98.LEFT);
		if (T54.M659() >= 0 && T54.M659() <= T174.mapNames.Length - 1)
		{
			T98.tahoma_7_yellow.M898(g, T174.mapNames[T54.M659()], 60, 38, T98.LEFT);
		}
		else
		{
			T98.tahoma_7_yellow.M898(g, mResources.random, 60, 38, T98.LEFT);
		}
	}

	private void M1367(T99 g)
	{
		if (currentTabIndex == currentTabName.Length - 1 && T51.panel2 == null)
		{
			M1361(g);
		}
		else if (selected < 0)
		{
			if (typeShop != 2)
			{
				T98.tahoma_7_white.M898(g, mResources.say_hello, X + 60, 14, 0);
				T98.tahoma_7_white.M898(g, strWantToBuy, X + 60, 26, 0);
				return;
			}
			T98.tahoma_7_white.M898(g, mResources.say_hello, X + 60, 5, 0);
			T98.tahoma_7_white.M898(g, strWantToBuy, X + 60, 17, 0);
			T98.tahoma_7_white.M898(g, mResources.page + " " + (currPageShop[currentTabIndex] + 1) + "/" + maxPageShop[currentTabIndex], X + 60, 29, 0);
		}
		else
		{
			if (currentTabIndex < 0 || currentTabIndex > T13.M113().arrItemShop.Length - 1 || selected < 0 || selected > T13.M113().arrItemShop[currentTabIndex].Length - 1)
			{
				return;
			}
			T79 t = T13.M113().arrItemShop[currentTabIndex][selected];
			if (t != null)
			{
				if (Equals(T51.panel) && currentTabIndex <= 3 && typeShop == 2)
				{
					T98.tahoma_7b_white.M898(g, mResources.page + " " + (currPageShop[currentTabIndex] + 1) + "/" + maxPageShop[currentTabIndex], X + 55, 4, 0);
				}
				T98.tahoma_7b_white.M898(g, t.template.name, X + 55, 24, 0);
				string st = mResources.pow_request + " " + T137.M1532(t.template.strRequire);
				if (t.template.strRequire > T13.M113().cPower)
				{
					T98.tahoma_7_yellow.M898(g, st, X + 55, 35, 0);
				}
				else
				{
					T98.tahoma_7_green.M898(g, st, X + 55, 35, 0);
				}
			}
		}
	}

	private void M1368(T99 g)
	{
		string st = mResources.used + ": " + hasUse + "/" + T13.M113().arrItemBox.Length + " " + mResources.place;
		T98.tahoma_7b_white.M898(g, mResources.chest, 60, 4, 0);
		T98.tahoma_7_yellow.M898(g, st, 60, 16, 0);
	}

	private void M1369(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T98.tahoma_7_white.M898(g, "Top " + T13.M113().rank, X + 45 + (W - 50) / 2, 2, T98.CENTER);
		T98.tahoma_7_yellow.M898(g, mResources.potential_point, X + 45 + (W - 50) / 2, 14, T98.CENTER);
		T98.tahoma_7_white.M898(g, string.Empty + T122.M1192(T13.M113().cTiemNang), X + ((T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0) + 45 + (W - 50) / 2, 26, T98.CENTER);
		T98.tahoma_7_yellow.M898(g, mResources.active_point + ": " + T122.M1192(T13.M113().cNangdong), X + ((T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0) + 45 + (W - 50) / 2, 38, T98.CENTER);
	}

	private void M1370(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T98.tahoma_7_yellow.M902(g, string.Concat(new object[5]
		{
			mResources.HP,
			": ",
			T122.M1192(T13.M113().cHP),
			" / ",
			T122.M1192(T13.M113().cHPFull)
		}), X + 52, 2, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7_yellow.M902(g, string.Concat(new object[5]
		{
			mResources.KI,
			": ",
			T122.M1192(T13.M113().cMP),
			" / ",
			T122.M1192(T13.M113().cMPFull)
		}), X + 52, 14, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7_yellow.M902(g, mResources.hit_point + ": " + T122.M1192(T13.M113().cDamFull), X + 52, 26, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7_yellow.M902(g, string.Concat(new object[8]
		{
			mResources.armor,
			": ",
			T122.M1192(T13.M113().cDefull),
			", ",
			mResources.critical,
			": ",
			T122.M1192(T13.M113().cCriticalFull),
			"%"
		}), X + 52, 38, T98.LEFT, T98.tahoma_7_grey);
	}

	private void M1371(T99 g)
	{
		g.M922(X + 1, Y, W - 2, yScroll - 2);
		g.M933(9993045);
		g.M932(X, Y, W - 2, 50);
		switch (type)
		{
		case 0:
			if (currentTabIndex == 0)
			{
				T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
				M1361(g);
			}
			if (currentTabIndex == 1)
			{
				T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
				M1370(g);
			}
			if (currentTabIndex == 2)
			{
				T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
				M1369(g);
			}
			if (currentTabIndex == 3)
			{
				if (mainTabName.Length == 5)
				{
					M1358(g);
				}
				else
				{
					T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
					M1359(g);
				}
			}
			if (currentTabIndex == 4)
			{
				T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
				M1359(g);
			}
			break;
		case 1:
			if (currentTabIndex == currentTabName.Length - 1 && T51.panel2 == null)
			{
				T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			}
			else
			{
				T157.M1785(g, T13.M113().npcFocus.avatar, X + 25, 50, 0, 33);
			}
			M1367(g);
			break;
		case 2:
			if (currentTabIndex == 0)
			{
				T157.M1785(g, 526, X + 25, 50, 0, 33);
				M1368(g);
			}
			if (currentTabIndex == 1)
			{
				T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
				M1370(g);
			}
			break;
		case 3:
			T157.M1785(g, 561, X + 25, 50, 0, 33);
			M1364(g);
			break;
		case 4:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1366(g);
			break;
		case 8:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 9:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 10:
			if (charMenu != null)
			{
				T157.M1785(g, charMenu.M108(), X + 25, 50, 0, 33);
				M1363(g, charMenu);
			}
			break;
		case 12:
			if (currentTabIndex == 0)
			{
				int id = 1410;
				for (int i = 0; i < T54.vNpc.M1113(); i++)
				{
					T123 t = (T123)T54.vNpc.M1114(i);
					if (t.template.npcTemplateId == idNPC)
					{
						id = t.avatar;
					}
				}
				T157.M1785(g, id, X + 25, 50, 0, 33);
				M1374(g);
			}
			if (currentTabIndex == 1)
			{
				T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
				M1361(g);
			}
			break;
		case 13:
			if (currentTabIndex == 0 || currentTabIndex == 1)
			{
				if (Equals(T51.panel))
				{
					T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
					M1360(g);
				}
				if (Equals(T51.panel2) && charMenu != null)
				{
					T157.M1785(g, charMenu.M108(), X + 25, 50, 0, 33);
					M1363(g, charMenu);
				}
			}
			if (currentTabIndex == 2 && charMenu != null)
			{
				T157.M1785(g, charMenu.M108(), X + 25, 50, 0, 33);
				M1363(g, charMenu);
			}
			break;
		case 14:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1366(g);
			break;
		case 15:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 7:
		case 17:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 18:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 19:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1359(g);
			break;
		case 20:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1359(g);
			break;
		case 21:
			if (currentTabIndex == 0)
			{
				T157.M1785(g, T13.M114().M108(), X + 25, 50, 0, 33);
				M1362(g);
			}
			if (currentTabIndex == 1)
			{
				T157.M1785(g, T13.M114().M108(), X + 25, 50, 0, 33);
				M1373(g);
			}
			if (currentTabIndex == 2)
			{
				T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
				M1370(g);
			}
			break;
		case 22:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1359(g);
			break;
		case 11:
		case 16:
		case 23:
		case 24:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 25:
			T157.M1785(g, T13.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 5:
		case 6:
			break;
		}
	}

	private string M1372(int status)
	{
		return status switch
		{
			0 => mResources.follow, 
			1 => mResources.defend, 
			2 => mResources.attack, 
			3 => mResources.gohome, 
			_ => "aaa", 
		};
	}

	private void M1373(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T98.tahoma_7b_white.M902(g, string.Concat(new object[4]
		{
			"HP: ",
			T122.M1192(T13.M114().cHP),
			"/",
			T122.M1192(T13.M114().cHPFull)
		}), X + 52, 4, T98.LEFT, T98.tahoma_7b_dark);
		T98.tahoma_7b_white.M902(g, string.Concat(new object[4]
		{
			"MP: ",
			T122.M1192(T13.M114().cMP),
			"/",
			T122.M1192(T13.M114().cMPFull)
		}), X + 52, 16, T98.LEFT, T98.tahoma_7b_dark);
		T98.tahoma_7_yellow.M902(g, string.Concat(new object[7]
		{
			mResources.critical,
			": ",
			T122.M1192(T13.M114().cCriticalFull),
			"   ",
			mResources.armor,
			": ",
			T122.M1192(T13.M114().cDefull)
		}), X + 52, 27, T98.LEFT, T98.tahoma_7_grey);
		T98.tahoma_7_yellow.M902(g, mResources.status + ": " + strStatus[T13.M114().petStatus], X + 52, 38, T98.LEFT, T98.tahoma_7_grey);
	}

	private void M1374(T99 g)
	{
		if (combineTopInfo != null)
		{
			for (int i = 0; i < combineTopInfo.Length; i++)
			{
				T98.tahoma_7_white.M898(g, combineTopInfo[i], X + 45 + (W - 50) / 2, 5 + i * 14, T98.CENTER);
			}
		}
	}

	private void M1375(T99 g)
	{
	}

	public void M1376(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(-cmxMap, -cmyMap);
		g.M948(imgMap, xScroll, yScroll, 0);
		int head = T13.M113().head;
		T157.M1785(g, T54.parts[head].pi[T13.CharInfo[0][0][0]].id, xMap, yMap + 5, 0, 3);
		int align = T98.CENTER;
		if (xMap <= 40)
		{
			align = T98.LEFT;
		}
		if (xMap >= 220)
		{
			align = T98.RIGHT;
		}
		T98.tahoma_7b_yellow.M902(g, T174.mapName, xMap, yMap - 12, align, T98.tahoma_7_grey);
		int num = -1;
		if (T54.M659() != -1)
		{
			for (int i = 0; i < mapId[T174.planetID].Length; i++)
			{
				if (mapId[T174.planetID][i] != T54.M659())
				{
					num = 4;
					continue;
				}
				num = i;
				break;
			}
			if (T51.gameTick % 4 > 0)
			{
				g.M948(T80.imageFlare, xScroll + mapX[T174.planetID][num], yScroll + mapY[T174.planetID][num], 3);
			}
		}
		if (!T51.isTouch)
		{
			g.M948(imgBantay, xMove, yMove, T163.TOP_RIGHT);
			for (int j = 0; j < mapX[T174.planetID].Length; j++)
			{
				int num2 = mapX[T174.planetID][j] + xScroll;
				int num3 = mapY[T174.planetID][j] + yScroll;
				if (T137.M1530(num2 - 15, num3 - 15, 30, 30, xMove, yMove))
				{
					align = T98.CENTER;
					if (num2 <= 20)
					{
						align = T98.LEFT;
					}
					if (num2 >= 220)
					{
						align = T98.RIGHT;
					}
					T98.tahoma_7b_yellow.M902(g, T174.mapNames[mapId[T174.planetID][j]], num2, num3 - 12, align, T98.tahoma_7_grey);
					break;
				}
			}
		}
		else if (!trans)
		{
			for (int k = 0; k < mapX[T174.planetID].Length; k++)
			{
				int num4 = mapX[T174.planetID][k] + xScroll;
				int num5 = mapY[T174.planetID][k] + yScroll;
				if (T137.M1530(num4 - 15, num5 - 15, 30, 30, pX, pY))
				{
					align = T98.CENTER;
					if (num4 <= 30)
					{
						align = T98.LEFT;
					}
					if (num4 >= 220)
					{
						align = T98.RIGHT;
					}
					g.M948(imgBantay, num4, num5, T163.TOP_RIGHT);
					T98.tahoma_7b_yellow.M902(g, T174.mapNames[mapId[T174.planetID][k]], num4, num5 - 12, align, T98.tahoma_7_grey);
					break;
				}
			}
		}
		g.M918(-g.M920(), -g.M921());
		if (num != -1)
		{
			if (mapX[T174.planetID][num] + xScroll < cmxMap)
			{
				g.M940(T101.imgHP, 0, 0, 9, 6, 5, xScroll + 5, yScroll + hScroll / 2 - 4, 0);
			}
			if (cmxMap + wScroll < mapX[T174.planetID][num] + xScroll)
			{
				g.M940(T101.imgHP, 0, 0, 9, 6, 6, xScroll + wScroll - 5, yScroll + hScroll / 2 - 4, T163.TOP_RIGHT);
			}
			if (mapY[T174.planetID][num] < cmyMap)
			{
				g.M940(T101.imgHP, 0, 0, 9, 6, 1, xScroll + wScroll / 2, yScroll + 5, T163.TOP_CENTER);
			}
			if (mapY[T174.planetID][num] > cmyMap + hScroll)
			{
				g.M940(T101.imgHP, 0, 0, 9, 6, 0, xScroll + wScroll / 2, yScroll + hScroll - 5, T163.BOTTOM_HCENTER);
			}
		}
	}

	public void M1377(T99 g)
	{
		int num = ((T51.h <= 300) ? 15 : 20);
		if (isPaintMap && !T54.M559().M535() && !T54.M559().M536())
		{
			g.M948((keyTouchMapButton != 1) ? T54.imgLbtn : T54.imgLbtnFocus, xScroll + wScroll / 2, yScroll + hScroll - num, 3);
			T98.tahoma_7b_dark.M898(g, mResources.map, xScroll + wScroll / 2, yScroll + hScroll - (num + 5), T98.CENTER);
		}
		xstart = xScroll + 5;
		ystart = yScroll + 14;
		yPaint = ystart;
		g.M922(xScroll, yScroll, wScroll, hScroll - 35);
		if (scroll != null)
		{
			if (scroll.cmy > 0)
			{
				g.M940(T101.imgHP, 0, 0, 9, 6, 1, xScroll + wScroll - 12, yScroll + 3, 0);
			}
			if (scroll.cmy < scroll.cmyLim)
			{
				g.M940(T101.imgHP, 0, 0, 9, 6, 0, xScroll + wScroll - 12, yScroll + hScroll - 45, 0);
			}
			g.M918(0, -scroll.cmy);
		}
		indexRowMax = 0;
		if (indexMenu == 0)
		{
			bool flag = false;
			if (T13.M113().taskMaint != null)
			{
				for (int i = 0; i < T13.M113().taskMaint.names.Length; i++)
				{
					T98.tahoma_7_grey.M898(g, T13.M113().taskMaint.names[i], xScroll + wScroll / 2, yPaint - 5 + i * 12, T98.CENTER);
					indexRowMax++;
				}
				yPaint += (T13.M113().taskMaint.names.Length - 1) * 12;
				int num2 = 0;
				string empty = string.Empty;
				for (int j = 0; j < T13.M113().taskMaint.subNames.Length; j++)
				{
					if (T13.M113().taskMaint.subNames[j] != null)
					{
						num2 = j;
						empty = "- " + T13.M113().taskMaint.subNames[j];
						if (T13.M113().taskMaint.counts[j] != -1)
						{
							if (T13.M113().taskMaint.index == j)
							{
								if (T13.M113().taskMaint.counts[j] != 1)
								{
									string text = empty;
									empty = text + " (" + T13.M113().taskMaint.count + "/" + T13.M113().taskMaint.counts[j] + ")";
								}
								if (T13.M113().taskMaint.count == T13.M113().taskMaint.counts[j])
								{
									T98.tahoma_7.M898(g, empty, xstart + 5, yPaint += 12, 0);
								}
								else
								{
									T98 tahoma_7_grey = T98.tahoma_7_grey;
									if (!flag)
									{
										flag = true;
										tahoma_7_grey = T98.tahoma_7_blue;
										tahoma_7_grey.M898(g, empty, xstart + 5 + ((tahoma_7_grey == T98.tahoma_7_blue && T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0), yPaint += 12, 0);
									}
									else
									{
										tahoma_7_grey.M898(g, "- ...", xstart + 5 + ((tahoma_7_grey == T98.tahoma_7_blue && T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0), yPaint += 12, 0);
									}
								}
							}
							else if (T13.M113().taskMaint.index > j)
							{
								if (T13.M113().taskMaint.counts[j] != 1)
								{
									string text2 = empty;
									empty = text2 + " (" + T13.M113().taskMaint.counts[j] + "/" + T13.M113().taskMaint.counts[j] + ")";
								}
								T98.tahoma_7_white.M898(g, empty, xstart + 5, yPaint += 12, 0);
							}
							else
							{
								if (T13.M113().taskMaint.counts[j] != 1)
								{
									empty = empty + " 0/" + T13.M113().taskMaint.counts[j];
								}
								T98 tahoma_7_grey2 = T98.tahoma_7_grey;
								if (!flag)
								{
									flag = true;
									tahoma_7_grey2 = T98.tahoma_7_blue;
									tahoma_7_grey2.M898(g, empty, xstart + 5 + ((tahoma_7_grey2 == T98.tahoma_7_blue && T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0), yPaint += 12, 0);
								}
								else
								{
									tahoma_7_grey2.M898(g, "- ...", xstart + 5 + ((tahoma_7_grey2 == T98.tahoma_7_blue && T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0), yPaint += 12, 0);
								}
							}
						}
						else if (T13.M113().taskMaint.index > j)
						{
							T98.tahoma_7_white.M898(g, empty, xstart + 5, yPaint += 12, 0);
						}
						else
						{
							T98 tahoma_7_grey3 = T98.tahoma_7_grey;
							if (!flag)
							{
								flag = true;
								tahoma_7_grey3 = T98.tahoma_7_blue;
								tahoma_7_grey3.M898(g, empty, xstart + 5 + ((tahoma_7_grey3 == T98.tahoma_7_blue && T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0), yPaint += 12, 0);
							}
							else
							{
								tahoma_7_grey3.M898(g, "- ...", xstart + 5 + ((tahoma_7_grey3 == T98.tahoma_7_blue && T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0), yPaint += 12, 0);
							}
						}
						indexRowMax++;
					}
					else if (T13.M113().taskMaint.index <= j)
					{
						empty = "- " + T13.M113().taskMaint.subNames[num2];
						T98 t = T98.tahoma_7_grey;
						if (!flag)
						{
							flag = true;
							t = T98.tahoma_7_blue;
						}
						t.M898(g, empty, xstart + 5 + ((t == T98.tahoma_7_blue && T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0), yPaint += 12, 0);
					}
				}
				yPaint += 5;
				for (int k = 0; k < T13.M113().taskMaint.details.Length; k++)
				{
					T98.tahoma_7_green2.M898(g, T13.M113().taskMaint.details[k], xstart + 5, yPaint += 12, 0);
					indexRowMax++;
				}
			}
			else
			{
				int num3 = T54.M659();
				sbyte b = T54.M660();
				string empty2 = string.Empty;
				if (num3 != -3 && b != -3)
				{
					if (T13.M113().taskMaint == null && T13.M113().ctaskId == 9 && T13.M113().nClass.classId == 0)
					{
						empty2 = mResources.TASK_INPUT_CLASS;
					}
					else
					{
						if (b < 0 || num3 < 0)
						{
							return;
						}
						empty2 = mResources.DES_TASK[0] + T123.arrNpcTemplate[b].name + mResources.DES_TASK[1] + T174.mapNames[num3] + mResources.DES_TASK[2];
					}
				}
				else
				{
					empty2 = mResources.DES_TASK[3];
				}
				string[] array = T98.tahoma_7_white.M907(empty2, 150);
				for (int l = 0; l < array.Length; l++)
				{
					if (l == 0)
					{
						T98.tahoma_7_white.M898(g, array[l], xstart + 5, yPaint = ystart, 0);
					}
					else
					{
						T98.tahoma_7_white.M898(g, array[l], xstart + 5, yPaint += 12, 0);
					}
				}
			}
		}
		else if (indexMenu == 1)
		{
			yPaint = ystart - 12;
			for (int m = 0; m < T13.M113().taskOrders.M1113(); m++)
			{
				T169 t2 = (T169)T13.M113().taskOrders.M1114(m);
				T98.tahoma_7_white.M898(g, t2.name, xstart + 5, yPaint += 12, 0);
				if (t2.count == t2.maxCount)
				{
					T98.tahoma_7_white.M898(g, ((t2.taskId != 0) ? mResources.KILLBOSS : mResources.KILL) + " " + T101.arrMobTemplate[t2.killId].name + " (" + t2.count + "/" + t2.maxCount + ")", xstart + 5, yPaint += 12, 0);
				}
				else
				{
					T98.tahoma_7_blue.M898(g, ((t2.taskId != 0) ? mResources.KILLBOSS : mResources.KILL) + " " + T101.arrMobTemplate[t2.killId].name + " (" + t2.count + "/" + t2.maxCount + ")", xstart + 5, yPaint += 12, 0);
				}
				indexRowMax += 3;
				inforW = popupW - 25;
				M1379(g, T98.tahoma_7_grey, t2.description, xstart + 5, yPaint += 12, 0);
				yPaint += 12;
			}
		}
		if (scroll == null)
		{
			scroll = new T140();
			scroll.M1566(indexRowMax, 12, xScroll, yScroll, wScroll, hScroll - num - 40, styleUPDOWN: true, 1);
		}
	}

	public void M1378(T99 g, T98 f, string[] arr, string str, int x, int y, int align)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			string text = arr[i];
			if (text.StartsWith("c"))
			{
				if (text.StartsWith("c0"))
				{
					text = text.Substring(2);
					f = T98.tahoma_7b_dark;
				}
				else if (text.StartsWith("c1"))
				{
					text = text.Substring(2);
					f = T98.tahoma_7b_yellow;
				}
				else if (text.StartsWith("c2"))
				{
					text = text.Substring(2);
					f = T98.tahoma_7b_green;
				}
			}
			if (i == 0)
			{
				f.M898(g, text, x, y, align);
				continue;
			}
			if (i < indexRow + 30 && i > indexRow - 30)
			{
				f.M898(g, text, x, y += 12, align);
			}
			else
			{
				y += 12;
			}
			yPaint += 12;
			indexRowMax++;
		}
	}

	public void M1379(T99 g, T98 f, string str, int x, int y, int align)
	{
		int num = ((!T51.isTouch || T51.w < 320) ? 10 : 20);
		string[] array = f.M907(str, inforW - num);
		for (int i = 0; i < array.Length; i++)
		{
			if (i == 0)
			{
				f.M898(g, array[i], x, y, align);
				continue;
			}
			if (i < indexRow + 15 && i > indexRow - 15)
			{
				f.M898(g, array[i], x, y += 12, align);
			}
			else
			{
				y += 12;
			}
			yPaint += 12;
			indexRowMax++;
		}
	}

	public void M1380()
	{
		for (int i = 0; i < vItemCombine.M1113(); i++)
		{
			((T79)vItemCombine.M1114(i)).isSelect = false;
		}
		vItemCombine.M1120();
	}

	public void M1381()
	{
		if (timeShow > 0)
		{
			isClose = false;
			return;
		}
		if (M1443())
		{
			T13.M113().M244();
		}
		if (chatTField != null && type == 13 && chatTField.isShow)
		{
			chatTField = null;
		}
		if (type == 13 && !isAccept)
		{
			T146.M1594().M1601(3, -1, -1, -1);
		}
		T137.M1513("HIDE PANELLLLLLLLLLLLLLLLLLLLLL");
		T160.M1826().M1856();
		T54.isPaint = true;
		T174.lastPlanetId = -1;
		imgMap = null;
		T110.M1062();
		isClanOption = false;
		isClose = true;
		M1380();
		T55.M694();
		T51.panel2 = null;
		T51.M517();
		T51.M483();
		pointerDownFirstX = 0;
		pointerDownTime = 0;
		pointerIsDowning = false;
		isShow = false;
		if ((T13.M113().cHP <= 0 || T13.M113().statusMe == 14 || T13.M113().statusMe == 5) && T13.M113().meDead)
		{
			T22 center = new T22(mResources.DIES[0], 11038, T54.M559());
			T54.M559().center = center;
			T13.M113().cHP = 0;
		}
	}

	public void M1382()
	{
		if (timeShow > 0)
		{
			isClose = false;
			return;
		}
		if (M1443())
		{
			T13.M113().M244();
		}
		if (chatTField != null && type == 13 && chatTField.isShow)
		{
			chatTField = null;
		}
		if (type == 13 && !isAccept)
		{
			T146.M1594().M1601(3, -1, -1, -1);
		}
		if (type == 15)
		{
			T146.M1594().M1736(-1);
		}
		T160.M1826().M1856();
		T54.isPaint = true;
		T174.lastPlanetId = -1;
		if (imgMap != null)
		{
			imgMap.texture = null;
			imgMap = null;
		}
		T110.M1062();
		isClanOption = false;
		if (type != 4)
		{
			if (type == 24)
			{
				M1400();
			}
			else if (type == 23)
			{
				M1275();
			}
			else if (type != 3 && type != 14)
			{
				if (type != 18 && type != 19 && type != 20 && type != 21)
				{
					if (type != 8 && type != 11 && type != 16)
					{
						isClose = true;
					}
					else
					{
						M1436();
						cmtoX = 0;
						cmx = 0;
					}
				}
				else
				{
					M1275();
					cmtoX = 0;
					cmx = 0;
				}
			}
			else if (isChangeZone)
			{
				isClose = true;
			}
			else
			{
				M1275();
				cmtoX = 0;
				cmx = 0;
			}
		}
		else
		{
			M1275();
			cmtoX = 0;
			cmx = 0;
		}
		T55.M694();
		T51.panel2 = null;
		T51.M517();
		T51.M483();
		T51.isFocusPanel2 = false;
		pointerDownFirstX = 0;
		pointerDownTime = 0;
		pointerIsDowning = false;
		if ((T13.M113().cHP <= 0 || T13.M113().statusMe == 14 || T13.M113().statusMe == 5) && T13.M113().meDead)
		{
			T22 center = new T22(mResources.DIES[0], 11038, T54.M559());
			T54.M559().center = center;
			T13.M113().cHP = 0;
		}
	}

	public void M1383()
	{
		if (T51.gameTick % 20 == 0)
		{
			T146.M1594().M1654();
		}
		if (chatTField != null && chatTField.isShow)
		{
			chatTField.M284();
			return;
		}
		if (isKiguiXu)
		{
			delayKigui++;
			if (delayKigui == 10)
			{
				delayKigui = 0;
				isKiguiXu = false;
				chatTField.tfChat.M1926(string.Empty);
				chatTField.strChat = mResources.kiguiXuchat + " ";
				chatTField.tfChat.name = mResources.input_money;
				chatTField.to = string.Empty;
				chatTField.isShow = true;
				chatTField.tfChat.M1931(T173.INPUT_TYPE_NUMERIC);
				chatTField.tfChat.M1929(9);
				if (T51.isTouch)
				{
					chatTField.tfChat.M1901();
				}
				if (Main.isWindowsPhone)
				{
					chatTField.tfChat.strInfo = chatTField.strChat;
				}
				if (!Main.isPC)
				{
					chatTField.M282(this, string.Empty);
				}
			}
			return;
		}
		if (isKiguiLuong)
		{
			delayKigui++;
			if (delayKigui == 10)
			{
				delayKigui = 0;
				isKiguiLuong = false;
				chatTField.tfChat.M1926(string.Empty);
				chatTField.strChat = mResources.kiguiLuongchat + "  ";
				chatTField.tfChat.name = mResources.input_money;
				chatTField.to = string.Empty;
				chatTField.isShow = true;
				chatTField.tfChat.M1931(T173.INPUT_TYPE_NUMERIC);
				chatTField.tfChat.M1929(9);
				if (T51.isTouch)
				{
					chatTField.tfChat.M1901();
				}
				if (Main.isWindowsPhone)
				{
					chatTField.tfChat.strInfo = chatTField.strChat;
				}
				if (!Main.isPC)
				{
					chatTField.M282(this, string.Empty);
				}
			}
			return;
		}
		if (scroll != null)
		{
			scroll.M1565();
		}
		if (tabIcon != null && tabIcon.isShow)
		{
			tabIcon.M1892();
			return;
		}
		M1326();
		if (waitToPerform > 0)
		{
			waitToPerform--;
			if (waitToPerform == 0)
			{
				lastSelect[currentTabIndex] = selected;
				switch (type)
				{
				case 0:
					M1415();
					break;
				case 2:
					M1423();
					break;
				case 3:
					M1421();
					break;
				case 4:
					M1420();
					break;
				case 7:
					if (Equals(T51.panel2) && T51.panel.type == 2)
					{
						M1423();
						return;
					}
					M1396();
					break;
				case 8:
					M1413();
					break;
				case 9:
					M1395();
					break;
				case 10:
					M1393();
					break;
				case 11:
					M1411();
					break;
				case 12:
					M1392();
					break;
				case 13:
					M1391();
					break;
				case 14:
					M1390();
					break;
				case 15:
					M1389();
					break;
				case 16:
					M1410();
					break;
				case 1:
				case 17:
					M1394();
					break;
				case 18:
					M1412();
					break;
				case 19:
					M1435();
					break;
				case 20:
					M1439();
					break;
				case 21:
					M1387();
					break;
				case 22:
					M1386();
					break;
				case 23:
					M1385();
					break;
				case 25:
					M1384();
					break;
				}
			}
		}
		for (int i = 0; i < T19.vMessage.M1113(); i++)
		{
			((T19)T19.vMessage.M1114(i)).M292();
		}
		M1427();
	}

	private void M1384()
	{
	}

	private void M1385()
	{
		if (selected != -1)
		{
			infoSelect = selected;
			((T204)vGameInfo.M1114(infoSelect)).hasRead = true;
			T138.M1543(((T204)vGameInfo.M1114(infoSelect)).id + string.Empty, 1);
			M1399();
		}
	}

	private void M1386()
	{
	}

	private void M1387()
	{
		if (currentTabIndex == 0)
		{
			if (selected == -1 || selected > T13.M114().arrItemBody.Length - 1)
			{
				return;
			}
			T117 t = new T117(string.Empty);
			currItem = T13.M114().arrItemBody[selected];
			if (currItem != null)
			{
				t.M1111(new T22(mResources.MOVEOUT, this, 2006, currItem));
				T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1277(currItem);
			}
			else
			{
				cp = null;
			}
		}
		if (currentTabIndex == 1)
		{
			M1388();
		}
		if (currentTabIndex == 2)
		{
			M1396();
		}
	}

	private void M1388()
	{
		if (selected == -1)
		{
			return;
		}
		if (selected == 5)
		{
			T51.M496(mResources.sure_fusion, new T22(mResources.YES, 888351), new T22(mResources.NO, 2001));
			return;
		}
		T146.M1594().M1728((sbyte)selected);
		if (selected < 4)
		{
			T13.M114().petStatus = (sbyte)selected;
		}
	}

	private void M1389()
	{
		if (selected >= -1)
		{
			if (isThachDau)
			{
				T146.M1594().M1723(topName, (sbyte)selected);
				return;
			}
			T117 t = new T117(string.Empty);
			t.M1111(new T22(mResources.CHAR_ORDER[0], this, 9999, (T176)vTop.M1114(selected)));
			T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1281((T176)vTop.M1114(selected));
		}
	}

	private void M1390()
	{
		M1421();
	}

	private void M1391()
	{
		if (currentTabIndex == 0 && Equals(T51.panel))
		{
			M1396();
			return;
		}
		if ((currentTabIndex == 0 && Equals(T51.panel2)) || currentTabIndex == 2)
		{
			if (Equals(T51.panel2))
			{
				currItem = (T79)T51.panel2.vFriendGD.M1114(selected);
			}
			else
			{
				currItem = (T79)T51.panel.vFriendGD.M1114(selected);
			}
			T137.M1514("toi day select= " + selected);
			T117 t = new T117();
			t.M1111(new T22(mResources.CLOSE, this, 8000, currItem));
			if (currItem != null)
			{
				T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1277(currItem);
			}
			else
			{
				cp = null;
			}
		}
		if (currentTabIndex == 1)
		{
			if (selected == currentListLength - 3)
			{
				if (isLock)
				{
					return;
				}
				M1405();
			}
			else if (selected == currentListLength - 2)
			{
				if (!isAccept)
				{
					isLock = !isLock;
					if (isLock)
					{
						T146.M1594().M1601(5, -1, -1, -1);
					}
					else
					{
						M1382();
						T66.M749();
						T146.M1594().M1601(3, -1, -1, -1);
					}
				}
				else
				{
					isAccept = false;
				}
			}
			else if (selected == currentListLength - 1)
			{
				if (isLock && !isAccept && isFriendLock)
				{
					T51.M496(mResources.do_u_sure_to_trade, new T22(mResources.YES, this, 7002, null), new T22(mResources.NO, this, 4005, null));
				}
			}
			else
			{
				if (isLock)
				{
					return;
				}
				currItem = (T79)T51.panel.vMyGD.M1114(selected);
				T117 t2 = new T117();
				t2.M1111(new T22(mResources.CLOSE, this, 8000, currItem));
				if (currItem != null)
				{
					T51.menu.M876(t2, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
					M1277(currItem);
				}
				else
				{
					cp = null;
				}
			}
		}
		if (T51.isTouch)
		{
			selected = -1;
		}
	}

	private void M1392()
	{
		if (currentTabIndex == 0)
		{
			if (selected == -1 || vItemCombine.M1113() == 0)
			{
				return;
			}
			if (selected == vItemCombine.M1113())
			{
				keyTouchCombine = -1;
				selected = (T51.isTouch ? (-1) : 0);
				T66.M749();
				T146.M1594().M1600(1, vItemCombine);
				return;
			}
			if (selected > vItemCombine.M1113() - 1)
			{
				return;
			}
			currItem = (T79)T51.panel.vItemCombine.M1114(selected);
			T117 t = new T117();
			t.M1111(new T22(mResources.GETOUT, this, 6001, currItem));
			if (currItem != null)
			{
				T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1277(currItem);
			}
			else
			{
				cp = null;
			}
		}
		if (currentTabIndex == 1)
		{
			M1396();
		}
	}

	private void M1393()
	{
		if (selected != -1)
		{
			isSelectPlayerMenu = true;
			M1382();
		}
	}

	private void M1394()
	{
		currItem = null;
		if (selected < 0)
		{
			return;
		}
		T117 t = new T117();
		if (currentTabIndex < currentTabName.Length - ((T51.panel2 == null) ? 1 : 0) && type != 17)
		{
			currItem = T13.M113().arrItemShop[currentTabIndex][selected];
			if (currItem != null)
			{
				if (currItem.isBuySpec)
				{
					if (currItem.buySpec > 0)
					{
						t.M1111(new T22(mResources.buy_with + "\n" + T137.M1533(currItem.buySpec), this, 3005, currItem));
					}
				}
				else if (typeShop == 4)
				{
					t.M1111(new T22(mResources.receive_upper, this, 30001, currItem));
					t.M1111(new T22(mResources.DELETE, this, 30002, currItem));
					t.M1111(new T22(mResources.receive_all, this, 30003, currItem));
				}
				else if (currItem.buyCoin == 0 && currItem.buyGold == 0)
				{
					if ((ulong)currItem.powerRequire > 0uL)
					{
						t.M1111(new T22(mResources.learn_with + "\n" + T137.M1532(currItem.powerRequire) + " \n" + mResources.potential, this, 3004, currItem));
					}
					else
					{
						t.M1111(new T22(mResources.receive_upper + "\n" + mResources.free, this, 3000, currItem));
					}
				}
				else if (typeShop == 8)
				{
					if (currItem.buyCoin > 0)
					{
						t.M1111(new T22(mResources.buy_with + "\n" + T137.M1533(currItem.buyCoin) + "\n" + mResources.XU, this, 30001, currItem));
					}
					if (currItem.buyGold > 0)
					{
						t.M1111(new T22(mResources.buy_with + "\n" + T137.M1533(currItem.buyGold) + "\n" + mResources.LUONG, this, 30002, currItem));
					}
				}
				else if (typeShop != 2)
				{
					if (currItem.buyCoin > 0)
					{
						t.M1111(new T22(mResources.buy_with + "\n" + T137.M1533(currItem.buyCoin) + "\n" + mResources.XU, this, 3000, currItem));
					}
					if (currItem.buyGold > 0)
					{
						t.M1111(new T22(mResources.buy_with + "\n" + T137.M1533(currItem.buyGold) + "\n" + mResources.LUONG, this, 3001, currItem));
					}
				}
				else
				{
					if (currItem.buyCoin != -1)
					{
						t.M1111(new T22(mResources.buy_with + "\n" + T137.M1533(currItem.buyCoin) + "\n" + mResources.XU, this, 10016, currItem));
					}
					if (currItem.buyGold != -1)
					{
						t.M1111(new T22(mResources.buy_with + "\n" + T137.M1533(currItem.buyGold) + "\n" + mResources.LUONG, this, 10017, currItem));
					}
				}
			}
		}
		else if (typeShop == 0)
		{
			if (selected == 0)
			{
				M1461(T13.M113().arrItemBody.Length + T13.M113().arrItemBag.Length, resetSelect: false);
			}
			else
			{
				currItem = null;
				if (!M1454(selected, newSelected, T13.M113().arrItemBody))
				{
					T79 t2 = T13.M113().arrItemBag[M1456(selected, newSelected, T13.M113().arrItemBody)];
					if (t2 != null)
					{
						currItem = t2;
					}
				}
				else
				{
					T79 t3 = T13.M113().arrItemBody[M1455(selected, newSelected)];
					if (t3 != null)
					{
						currItem = t3;
					}
				}
				if (currItem != null)
				{
					t.M1111(new T22(mResources.SALE, this, 3002, currItem));
				}
			}
		}
		else
		{
			if (type == 17)
			{
				currItem = T13.M113().arrItemShop[4][selected];
			}
			else
			{
				currItem = T13.M113().arrItemShop[currentTabIndex][selected];
			}
			if (currItem.buyType == 0)
			{
				if (currItem.M803(87))
				{
					t.M1111(new T22(mResources.kiguiLuong, this, 10013, currItem));
				}
				else
				{
					t.M1111(new T22(mResources.kiguiXu, this, 10012, currItem));
				}
			}
			else if (currItem.buyType == 1)
			{
				t.M1111(new T22(mResources.huykigui, this, 10014, currItem));
				t.M1111(new T22(mResources.upTop, this, 10018, currItem));
			}
			else if (currItem.buyType == 2)
			{
				t.M1111(new T22(mResources.nhantien, this, 10015, currItem));
			}
		}
		if (currItem != null)
		{
			T13.M113().M243(currItem.headTemp, currItem.bodyTemp, currItem.legTemp, currItem.bagTemp);
			T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1277(currItem);
		}
		else
		{
			cp = null;
		}
	}

	private void M1395()
	{
		if (selected >= 0 && T13.M113().arrArchive[selected].isFinish && !T13.M113().arrArchive[selected].isRecieve)
		{
			if (!T51.isTouch)
			{
				T146.M1594().M1609(selected);
			}
			else if (T51.px > xScroll + wScroll - 40)
			{
				T146.M1594().M1609(selected);
			}
		}
	}

	private void M1396()
	{
		T137.M1513("fire inventory");
		if (T13.M113().statusMe == 14)
		{
			T51.M489(mResources.can_not_do_when_die);
		}
		else
		{
			if (selected == -1)
			{
				return;
			}
			currItem = null;
			T117 t = new T117();
			T79[] arrItemBody = T13.M113().arrItemBody;
			if (selected >= arrItemBody.Length)
			{
				sbyte b = (sbyte)(selected - arrItemBody.Length);
				T79 t2 = T13.M113().arrItemBag[b];
				if (t2 != null)
				{
					currItem = t2;
					if (T51.panel.type == 12)
					{
						t.M1111(new T22(mResources.use_for_combine, this, 6000, currItem));
					}
					else if (T51.panel.type == 13)
					{
						t.M1111(new T22(mResources.use_for_trade, this, 7000, currItem));
					}
					else if (currItem.M805())
					{
						t.M1111(new T22(mResources.USE, this, 2000, currItem));
						if (T13.M113().havePet)
						{
							t.M1111(new T22(mResources.MOVEFORPET, this, 2005, currItem));
						}
					}
					else
					{
						t.M1111(new T22(mResources.USE, this, 2001, currItem));
					}
				}
			}
			else
			{
				T79 t3 = ((selected < 0 || selected >= arrItemBody.Length) ? null : T13.M113().arrItemBody[selected]);
				if (t3 != null)
				{
					currItem = t3;
					t.M1111(new T22(mResources.GETOUT, this, 2002, currItem));
				}
			}
			if (currItem != null)
			{
				T13.M113().M243(currItem.headTemp, currItem.bodyTemp, currItem.legTemp, currItem.bagTemp);
				if (T51.panel.type != 12 && T51.panel.type != 13)
				{
					if (position == 0)
					{
						t.M1111(new T22(mResources.MOVEOUT, this, 2003, currItem));
					}
					if (position == 1)
					{
						t.M1111(new T22(mResources.SALE, this, 3002, currItem));
					}
				}
				T51.menu.M876(t, X, selected * ITEM_HEIGHT - cmy + yScroll);
				M1277(currItem);
			}
			else
			{
				cp = null;
			}
		}
	}

	private void M1397()
	{
		M1382();
		if (T136.list != null && T136.list.M1113() != 0)
		{
			T136.M1494().switchToMe();
			return;
		}
		T146.M1594().M1741(0, -1);
		T136.M1494().switchToMe();
	}

	private void M1398()
	{
		if (selected < 0)
		{
			return;
		}
		if (!T13.M113().havePet)
		{
			switch (selected)
			{
			case 0:
				M1397();
				break;
			case 1:
				M1382();
				T146.M1594().M1656(54);
				break;
			case 2:
				M1400();
				break;
			case 3:
				T146.M1594().M1726(0, -1);
				T66.M749();
				break;
			case 4:
				if (T13.M113().statusMe == 14)
				{
					T51.M489(mResources.can_not_do_when_die);
					break;
				}
				T146.M1594().M1654();
				T51.panel.M1276();
				T51.panel.M1285();
				break;
			case 5:
				T51.M488();
				if (T13.M113().M251() < 5)
				{
					T51.M489(mResources.not_enough_luong_world_channel);
					break;
				}
				if (chatTField == null)
				{
					chatTField = new T15();
					chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
					chatTField.M276();
					chatTField.parentScreen = T51.panel;
				}
				chatTField.strChat = mResources.world_channel_5_luong;
				chatTField.tfChat.name = mResources.CHAT;
				chatTField.to = string.Empty;
				chatTField.isShow = true;
				chatTField.tfChat.isFocus = true;
				chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
				if (Main.isWindowsPhone)
				{
					chatTField.tfChat.strInfo = chatTField.strChat;
				}
				if (!Main.isPC)
				{
					chatTField.M282(this, string.Empty);
				}
				else if (T51.isTouch)
				{
					chatTField.tfChat.M1901();
				}
				break;
			case 6:
				M1436();
				break;
			case 7:
				M1432();
				break;
			case 8:
				T51.loginScr.M868();
				break;
			case 9:
				if (T51.loginScr.isLogin2)
				{
					T160.M1826().M1874();
				}
				break;
			}
			return;
		}
		switch (selected)
		{
		case 0:
			M1397();
			break;
		case 1:
			M1382();
			T146.M1594().M1656(54);
			break;
		case 2:
			M1400();
			break;
		case 3:
			M1401();
			break;
		case 4:
			T146.M1594().M1726(0, -1);
			T66.M749();
			break;
		case 5:
			if (T13.M113().statusMe == 14)
			{
				T51.M489(mResources.can_not_do_when_die);
				break;
			}
			T146.M1594().M1654();
			T51.panel.M1276();
			T51.panel.M1285();
			break;
		case 6:
			T51.M488();
			if (T13.M113().M251() < 5)
			{
				T51.M489(mResources.not_enough_luong_world_channel);
				break;
			}
			if (chatTField == null)
			{
				chatTField = new T15();
				chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = T51.panel;
			}
			chatTField.strChat = mResources.world_channel_5_luong;
			chatTField.tfChat.name = mResources.CHAT;
			chatTField.to = string.Empty;
			chatTField.isShow = true;
			chatTField.tfChat.isFocus = true;
			chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
			if (Main.isWindowsPhone)
			{
				chatTField.tfChat.strInfo = chatTField.strChat;
			}
			if (!Main.isPC)
			{
				chatTField.M282(this, string.Empty);
			}
			else if (T51.isTouch)
			{
				chatTField.tfChat.M1901();
			}
			break;
		case 7:
			M1436();
			break;
		case 8:
			M1432();
			break;
		case 9:
			T51.loginScr.M868();
			break;
		case 10:
			if (T51.loginScr.isLogin2)
			{
				T160.M1826().M1874();
			}
			break;
		}
	}

	private void M1399()
	{
		string content = ((T204)vGameInfo.M1114(infoSelect)).content;
		contenInfo = T98.tahoma_7_grey.M907(content, wScroll - 40);
		currentListLength = contenInfo.Length;
		ITEM_HEIGHT = 16;
		selected = (T51.isTouch ? (-1) : 0);
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		type = 24;
		M1246(0);
	}

	private void M1400()
	{
		currentListLength = vGameInfo.M1113();
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		type = 23;
		M1246(0);
	}

	private void M1401()
	{
		T66.M749();
		T146.M1594().M1722();
		timeShow = 20;
	}

	private void M1402()
	{
		chatTField.strChat = mResources.input_clan_name;
		chatTField.tfChat.name = mResources.clan_name;
		chatTField.to = string.Empty;
		chatTField.isShow = true;
		chatTField.tfChat.isFocus = true;
		chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
		if (Main.isWindowsPhone)
		{
			chatTField.tfChat.strInfo = chatTField.strChat;
		}
		if (!Main.isPC)
		{
			chatTField.M282(this, string.Empty);
		}
	}

	private void M1403()
	{
		chatTField.strChat = mResources.chat_clan;
		chatTField.tfChat.name = mResources.CHAT;
		chatTField.to = string.Empty;
		chatTField.isShow = true;
		chatTField.tfChat.isFocus = true;
		chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
		if (Main.isWindowsPhone)
		{
			chatTField.tfChat.strInfo = chatTField.strChat;
		}
		if (!Main.isPC)
		{
			chatTField.M282(this, string.Empty);
		}
	}

	public void M1404()
	{
		chatTField.strChat = mResources.input_clan_name_to_create;
		chatTField.tfChat.name = mResources.input_clan_name;
		chatTField.to = string.Empty;
		chatTField.isShow = true;
		chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
		if (Main.isWindowsPhone)
		{
			chatTField.tfChat.strInfo = chatTField.strChat;
		}
		if (!Main.isPC)
		{
			chatTField.M282(this, string.Empty);
		}
	}

	public void M1405()
	{
		if (chatTField == null)
		{
			chatTField = new T15();
			chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
			chatTField.M276();
			chatTField.parentScreen = T51.panel;
		}
		chatTField.strChat = mResources.input_money_to_trade;
		chatTField.tfChat.name = mResources.input_money;
		chatTField.to = string.Empty;
		chatTField.isShow = true;
		chatTField.tfChat.M1931(T173.INPUT_TYPE_NUMERIC);
		chatTField.tfChat.M1929(9);
		if (T51.isTouch)
		{
			chatTField.tfChat.M1901();
		}
		if (Main.isWindowsPhone)
		{
			chatTField.tfChat.strInfo = chatTField.strChat;
		}
		if (!Main.isPC)
		{
			chatTField.M282(this, string.Empty);
		}
	}

	public void M1406()
	{
		if (chatTField == null)
		{
			chatTField = new T15();
			chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
			chatTField.M276();
			chatTField.parentScreen = T51.panel;
		}
		chatTField.strChat = mResources.input_quantity_to_trade;
		chatTField.tfChat.name = mResources.input_quantity;
		chatTField.to = string.Empty;
		chatTField.isShow = true;
		chatTField.tfChat.M1931(T173.INPUT_TYPE_NUMERIC);
		if (T51.isTouch)
		{
			chatTField.tfChat.M1901();
		}
		if (Main.isWindowsPhone)
		{
			chatTField.tfChat.strInfo = chatTField.strChat;
		}
		if (!Main.isPC)
		{
			chatTField.M282(this, string.Empty);
		}
	}

	public void M1407()
	{
		chatTField.strChat = mResources.input_clan_slogan;
		chatTField.tfChat.name = mResources.input_clan_slogan;
		chatTField.to = string.Empty;
		chatTField.isShow = true;
		chatTField.tfChat.isFocus = true;
		chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
		if (Main.isWindowsPhone)
		{
			chatTField.tfChat.strInfo = chatTField.strChat;
		}
		if (!Main.isPC)
		{
			chatTField.M282(this, string.Empty);
		}
	}

	public void M1408()
	{
		if (tabIcon == null)
		{
			tabIcon = new T167();
		}
		tabIcon.text = chatTField.tfChat.M1924();
		tabIcon.M1886(isGetName: false);
		chatTField.isShow = false;
	}

	private void M1409(T67 info)
	{
		string text = string.Concat("|0|1|" + info.charInfo.cName, "\n");
		string text2 = ((!info.isOnline) ? (text + "|3|1|" + mResources.is_offline) : (text + "|4|1|" + mResources.is_online)) + "\n--";
		text = text2 + "\n|5|" + mResources.power + ": " + info.s;
		cp = new T14();
		M1278(cp, text);
		charInfo = info.charInfo;
		currItem = null;
	}

	private void M1410()
	{
		if (selected >= 0 && vEnemy.M1113() != 0)
		{
			T117 t = new T117();
			currInfoItem = selected;
			t.M1111(new T22(mResources.REVENGE, this, 10000, (T67)vEnemy.M1114(currInfoItem)));
			t.M1111(new T22(mResources.DELETE, this, 10001, (T67)vEnemy.M1114(currInfoItem)));
			t.M1111(new T22(mResources.den, this, 8004, (T67)vEnemy.M1114(currInfoItem)));
			T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1409((T67)vEnemy.M1114(selected));
		}
	}

	private void M1411()
	{
		if (selected >= 0 && vFriend.M1113() != 0)
		{
			T117 t = new T117();
			currInfoItem = selected;
			t.M1111(new T22(mResources.CHAT, this, 8001, (T67)vFriend.M1114(currInfoItem)));
			t.M1111(new T22(mResources.DELETE, this, 8002, (T67)vFriend.M1114(currInfoItem)));
			t.M1111(new T22(mResources.den, this, 8004, (T67)vFriend.M1114(currInfoItem)));
			T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1409((T67)vFriend.M1114(selected));
		}
	}

	private void M1412()
	{
		if (selected >= 0)
		{
			T117 t = new T117();
			currInfoItem = selected;
			t.M1111(new T22(mResources.change_flag, this, 10030, null));
			t.M1111(new T22(mResources.BACK, this, 10031, null));
			T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
		}
	}

	private void M1413()
	{
		if (selected == 0)
		{
			isViewChatServer = !isViewChatServer;
			T138.M1543("viewchat", isViewChatServer ? 1 : 0);
			if (T51.isTouch)
			{
				selected = -1;
			}
		}
		else if (selected >= 0 && logChat.M1113() != 0)
		{
			T117 t = new T117();
			currInfoItem = selected - 1;
			t.M1111(new T22(mResources.CHAT, this, 8001, (T67)logChat.M1114(currInfoItem)));
			t.M1111(new T22(mResources.make_friend, this, 8003, (T67)logChat.M1114(currInfoItem)));
			t.M1111(new T22(mResources.den, this, 8004, (T67)logChat.M1114(currInfoItem)));
			T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1417((T67)logChat.M1114(selected - 1));
		}
	}

	private void M1414()
	{
		partID = null;
		charInfo = null;
		T137.M1513("cSelect= " + cSelected);
		if (selected < 0)
		{
			cSelected = -1;
			return;
		}
		if (T13.M113().clan == null)
		{
			if (selected == 0)
			{
				if (cSelected == 0)
				{
					M1402();
				}
				else if (cSelected == 1)
				{
					T66.M749();
					M1404();
					T146.M1594().M1623(1, -1, null);
				}
			}
			else if (selected != -1)
			{
				if (selected == 1)
				{
					if (isSearchClan)
					{
						T146.M1594().M1618(string.Empty);
					}
					else if (isViewMember && currClan != null)
					{
						T51.M496(mResources.do_u_want_join_clan + currClan.name, new T22(mResources.YES, this, 4000, currClan), new T22(mResources.NO, this, 4005, currClan));
					}
				}
				else if (isSearchClan)
				{
					currClan = M1346();
					if (currClan != null)
					{
						T117 t = new T117();
						t.M1111(new T22(mResources.request_join_clan, this, 4000, currClan));
						t.M1111(new T22(mResources.view_clan_member, this, 4001, currClan));
						T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
						M1283(M1346());
					}
				}
				else if (isViewMember)
				{
					currMem = M1344();
					if (currMem != null)
					{
						T117 t2 = new T117();
						t2.M1111(new T22(mResources.CLOSE, this, 8000, currClan));
						T51.menu.M876(t2, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
						T51.menu.M876(t2, 0, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
						M1282(currMem);
					}
				}
			}
		}
		else if (selected == 0)
		{
			if (isMessage)
			{
				if (cSelected == 0)
				{
					if (myMember.M1113() > 1)
					{
						M1403();
					}
					else
					{
						member = null;
						isSearchClan = false;
						isViewMember = true;
						isMessage = false;
						currentListLength = myMember.M1113() + 2;
						M1313();
					}
				}
				if (cSelected == 1)
				{
					T146.M1594().M1614(1, null, -1);
				}
				if (cSelected == 2)
				{
					member = null;
					isSearchClan = false;
					isViewMember = true;
					isMessage = false;
					currentListLength = myMember.M1113() + 2;
					M1313();
					M1302();
				}
			}
			else if (isViewMember)
			{
				if (cSelected == 0)
				{
					isSearchClan = false;
					isViewMember = false;
					isMessage = true;
					currentListLength = T19.vMessage.M1113() + 2;
					M1313();
				}
				if (cSelected == 1)
				{
					if (myMember.M1113() > 1)
					{
						T146.M1594().M1621();
					}
					else
					{
						M1407();
					}
				}
				if (cSelected == 2)
				{
					if (myMember.M1113() > 1)
					{
						M1407();
					}
					else
					{
						T146.M1594().M1623(3, -1, null);
					}
				}
				if (cSelected == 3)
				{
					T146.M1594().M1623(3, -1, null);
				}
			}
		}
		else if (selected == 1)
		{
			if (isSearchClan)
			{
				T146.M1594().M1618(string.Empty);
			}
		}
		else if (isSearchClan)
		{
			currClan = M1346();
			if (currClan != null)
			{
				T117 t3 = new T117();
				t3.M1111(new T22(mResources.view_clan_member, this, 4001, currClan));
				T51.menu.M876(t3, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1283(M1346());
			}
		}
		else if (isViewMember)
		{
			T137.M1513("TOI DAY 1");
			currMem = M1344();
			if (currMem != null)
			{
				T117 t4 = new T117();
				T137.M1513("TOI DAY 2");
				if (member != null)
				{
					t4.M1111(new T22(mResources.CLOSE, this, 8000, null));
					T137.M1513("TOI DAY 3");
				}
				else if (myMember != null)
				{
					T137.M1513("TOI DAY 4");
					T137.M1513("my role= " + T13.M113().role);
					if (T13.M113().charID == currMem.ID || T13.M113().role == 2)
					{
						t4.M1111(new T22(mResources.CLOSE, this, 8000, currMem));
					}
					if (T13.M113().role < 2 && T13.M113().charID != currMem.ID)
					{
						T137.M1513("TOI DAY");
						if (currMem.role == 0 || currMem.role == 1)
						{
							t4.M1111(new T22(mResources.CLOSE, this, 8000, currMem));
						}
						if (currMem.role == 2)
						{
							t4.M1111(new T22(mResources.create_clan_co_leader, this, 5002, currMem));
						}
						if (T13.M113().role == 0)
						{
							t4.M1111(new T22(mResources.create_clan_leader, this, 5001, currMem));
							if (currMem.role == 1)
							{
								t4.M1111(new T22(mResources.disable_clan_mastership, this, 5003, currMem));
							}
						}
					}
					if (T13.M113().role < currMem.role)
					{
						t4.M1111(new T22(mResources.kick_clan_mem, this, 5004, currMem));
					}
				}
				T51.menu.M876(t4, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1282(currMem);
			}
		}
		else if (isMessage)
		{
			currMess = M1345();
			if (currMess != null)
			{
				if (currMess.type == 0)
				{
					T117 t5 = new T117();
					t5.M1111(new T22(mResources.CLOSE, this, 8000, currMess));
					T51.menu.M876(t5, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
					M1280(currMess);
				}
				else if (currMess.type == 1)
				{
					if (currMess.playerId != T13.M113().charID && cSelected != -1)
					{
						T146.M1594().M1613(currMess.id);
					}
				}
				else if (currMess.type == 2 && currMess.option != null)
				{
					if (cSelected == 0)
					{
						T146.M1594().M1616(currMess.id, 1);
					}
					else if (cSelected == 1)
					{
						T146.M1594().M1616(currMess.id, 0);
					}
				}
			}
		}
		if (T51.isTouch)
		{
			cSelected = -1;
			selected = -1;
		}
	}

	private void M1415()
	{
		if (currentTabIndex == 0)
		{
			M1249();
		}
		if (currentTabIndex == 1)
		{
			M1396();
		}
		if (currentTabIndex == 2)
		{
			M1416();
		}
		if (currentTabIndex == 3)
		{
			if (mainTabName.Length == 4)
			{
				M1398();
			}
			else
			{
				M1414();
			}
		}
		if (currentTabIndex == 4)
		{
			M1398();
		}
	}

	private void M1416()
	{
		if (selected < 0)
		{
			return;
		}
		if (T13.M113().statusMe == 14)
		{
			T51.M489(mResources.can_not_do_when_die);
			return;
		}
		if (selected != 0 && selected != 1 && selected != 2 && selected != 3 && selected != 4 && selected != 5)
		{
			int num = selected;
			T155 t = T13.M113().nClass.skillTemplates[num - 6];
			T149 t2 = T13.M113().M119(t);
			T149 t3 = null;
			T117 t4 = new T117();
			if (t2 != null)
			{
				if (t2.point == t.maxPoint)
				{
					t4.M1111(new T22(mResources.make_shortcut, this, 9003, t2.template));
					t4.M1111(new T22(mResources.CLOSE, 2));
				}
				else
				{
					t3 = t.skills[t2.point];
					t4.M1111(new T22(mResources.UPGRADE, this, 9002, t3));
					t4.M1111(new T22(mResources.make_shortcut, this, 9003, t2.template));
				}
			}
			else
			{
				t3 = t.skills[0];
				t4.M1111(new T22(mResources.learn, this, 9004, t3));
			}
			T51.menu.M876(t4, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1284(t, t2, t3);
			return;
		}
		long cTiemNang = T13.M113().cTiemNang;
		int cHPGoc = T13.M113().cHPGoc;
		int cMPGoc = T13.M113().cMPGoc;
		int cDamGoc = T13.M113().cDamGoc;
		int cDefGoc = T13.M113().cDefGoc;
		_ = T13.M113().cCriticalGoc;
		int num2 = 1000;
		if (selected == 0)
		{
			if (cTiemNang < T13.M113().cHPGoc + num2)
			{
				T51.M491(mResources.not_enough_potential_point1 + T13.M113().cTiemNang + mResources.not_enough_potential_point2 + (T13.M113().cHPGoc + num2), isError: false);
				return;
			}
			if (cTiemNang > cHPGoc && cTiemNang < 10 * (2 * (cHPGoc + num2) + 180) / 2)
			{
				T51.M496(mResources.use_potential_point_for1 + (cHPGoc + num2) + mResources.use_potential_point_for2 + T13.M113().hpFrom1000TiemNang + mResources.for_HP, new T22(mResources.increase_upper, this, 9000, null), new T22(mResources.CANCEL, this, 4007, null));
				return;
			}
			if (cTiemNang >= 10 * (2 * (cHPGoc + num2) + 180) / 2 && cTiemNang < 100 * (2 * (cHPGoc + num2) + 1980) / 2)
			{
				T117 t5 = new T117();
				t5.M1111(new T22(mResources.increase_upper + "\n" + T13.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + (cHPGoc + num2), this, 9000, null));
				t5.M1111(new T22(mResources.increase_upper + "\n" + 10 * T13.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + 10 * (2 * (cHPGoc + num2) + 180) / 2, this, 9006, null));
				T51.menu.M876(t5, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
			if (cTiemNang >= 100 * (2 * (cHPGoc + num2) + 1980) / 2)
			{
				T117 t6 = new T117();
				t6.M1111(new T22(mResources.increase_upper + "\n" + T13.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + (cHPGoc + num2), this, 9000, null));
				t6.M1111(new T22(mResources.increase_upper + "\n" + 10 * T13.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + 10 * (2 * (cHPGoc + num2) + 180) / 2, this, 9006, null));
				t6.M1111(new T22(mResources.increase_upper + "\n" + 100 * T13.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + 100 * (2 * (cHPGoc + num2) + 1980) / 2, this, 9007, null));
				T51.menu.M876(t6, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
		}
		if (selected == 1)
		{
			if (T13.M113().cTiemNang < T13.M113().cMPGoc + num2)
			{
				T51.M491(mResources.not_enough_potential_point1 + T13.M113().cTiemNang + mResources.not_enough_potential_point2 + (T13.M113().cMPGoc + num2), isError: false);
				return;
			}
			if (cTiemNang > cMPGoc && cTiemNang < 10 * (2 * (cMPGoc + num2) + 180) / 2)
			{
				T51.M496(mResources.use_potential_point_for1 + (cMPGoc + num2) + mResources.use_potential_point_for2 + T13.M113().mpFrom1000TiemNang + mResources.for_KI, new T22(mResources.increase_upper, this, 9000, null), new T22(mResources.CANCEL, this, 4007, null));
				return;
			}
			if (cTiemNang >= 10 * (2 * (cMPGoc + num2) + 180) / 2 && cTiemNang < 100 * (2 * (cMPGoc + num2) + 1980) / 2)
			{
				T117 t7 = new T117();
				t7.M1111(new T22(mResources.increase_upper + "\n" + T13.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + (cHPGoc + num2), this, 9000, null));
				t7.M1111(new T22(mResources.increase_upper + "\n" + 10 * T13.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + 10 * (2 * (cHPGoc + num2) + 180) / 2, this, 9006, null));
				T51.menu.M876(t7, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
			if (cTiemNang >= 100 * (2 * (cMPGoc + num2) + 1980) / 2)
			{
				T117 t8 = new T117();
				t8.M1111(new T22(mResources.increase_upper + "\n" + T13.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + (cMPGoc + num2), this, 9000, null));
				t8.M1111(new T22(mResources.increase_upper + "\n" + 10 * T13.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + 10 * (2 * (cMPGoc + num2) + 180) / 2, this, 9006, null));
				t8.M1111(new T22(mResources.increase_upper + "\n" + 100 * T13.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + 100 * (2 * (cMPGoc + num2) + 1980) / 2, this, 9007, null));
				T51.menu.M876(t8, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
		}
		if (selected == 2)
		{
			if (T13.M113().cTiemNang < T13.M113().cDamGoc * T13.M113().expForOneAdd)
			{
				T51.M491(mResources.not_enough_potential_point1 + T13.M113().cTiemNang + mResources.not_enough_potential_point2 + cDamGoc * 100, isError: false);
				return;
			}
			if (cTiemNang > cDamGoc && cTiemNang < 10 * (2 * cDamGoc + 9) / 2 * T13.M113().expForOneAdd)
			{
				T51.M496(mResources.use_potential_point_for1 + cDamGoc * 100 + mResources.use_potential_point_for2 + T13.M113().damFrom1000TiemNang + mResources.for_hit_point, new T22(mResources.increase_upper, this, 9000, null), new T22(mResources.CANCEL, this, 4007, null));
				return;
			}
			if (cTiemNang >= 10 * (2 * cDamGoc + 9) / 2 * T13.M113().expForOneAdd && cTiemNang < 100 * (2 * cDamGoc + 99) / 2 * T13.M113().expForOneAdd)
			{
				T117 t9 = new T117();
				t9.M1111(new T22(mResources.increase_upper + "\n" + T13.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + cDamGoc * 100, this, 9000, null));
				t9.M1111(new T22(mResources.increase_upper + "\n" + 10 * T13.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + 10 * (2 * cDamGoc + 9) / 2 * T13.M113().expForOneAdd, this, 9006, null));
				T51.menu.M876(t9, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
			if (cTiemNang >= 100 * (2 * cDamGoc + 99) / 2 * T13.M113().expForOneAdd)
			{
				T117 t10 = new T117();
				t10.M1111(new T22(mResources.increase_upper + "\n" + T13.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + cDamGoc * 100, this, 9000, null));
				t10.M1111(new T22(mResources.increase_upper + "\n" + 10 * T13.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + 10 * (2 * cDamGoc + 9) / 2 * T13.M113().expForOneAdd, this, 9006, null));
				t10.M1111(new T22(mResources.increase_upper + "\n" + 100 * T13.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + 100 * (2 * cDamGoc + 99) / 2 * T13.M113().expForOneAdd, this, 9007, null));
				T51.menu.M876(t10, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
		}
		if (selected == 3)
		{
			if (T13.M113().cTiemNang < 50000 + T13.M113().cDefGoc * 1000)
			{
				T51.M491(mResources.not_enough_potential_point1 + T122.M1192(T13.M113().cTiemNang) + mResources.not_enough_potential_point2 + T122.M1192(50000 + T13.M113().cDefGoc * 1000), isError: false);
				return;
			}
			int num3 = 2 * (cDefGoc + 5) / 2 * 100000;
			T51.M496(mResources.use_potential_point_for1 + T122.M1192(num3) + mResources.use_potential_point_for2 + T13.M113().defFrom1000TiemNang + mResources.for_armor, new T22(mResources.increase_upper, this, 9000, null), new T22(mResources.CANCEL, this, 4007, null));
		}
		else if (selected == 4)
		{
			long num4 = 50000000L;
			for (int i = 0; i < T13.M113().cCriticalGoc; i++)
			{
				num4 *= 5L;
			}
			if (T13.M113().cTiemNang < num4)
			{
				T51.M491(mResources.not_enough_potential_point1 + T122.M1192(T13.M113().cTiemNang) + mResources.not_enough_potential_point2 + T122.M1192(num4), isError: false);
				return;
			}
			T51.M496(mResources.use_potential_point_for1 + T122.M1192(num4) + mResources.use_potential_point_for2 + T13.M113().criticalFrom1000Tiemnang + mResources.for_crit, new T22(mResources.increase_upper, this, 9000, null), new T22(mResources.CANCEL, this, 4007, null));
		}
		else if (selected == 5)
		{
			T146.M1594().M1603(0);
		}
	}

	private void M1417(T67 info)
	{
		string chat = string.Concat(string.Concat(string.Concat("|0|1|" + info.charInfo.cName, "\n"), "\n--"), "\n|5|", T137.M1531(info.s, "|", 0)[2]);
		cp = new T14();
		M1278(cp, chat);
		charInfo = info.charInfo;
		currItem = null;
	}

	private void M1418(int type)
	{
		string empty = string.Empty;
		int num = 0;
		if (selected == 0)
		{
			num = T13.M113().cHPGoc + 1000;
		}
		if (selected == 1)
		{
			num = T13.M113().cMPGoc + 1000;
		}
		if (selected == 2)
		{
			num = T13.M113().cDamGoc * T13.M113().expForOneAdd;
		}
		string text = empty;
		empty = text + "|5|2|" + mResources.USE + " " + num + " " + mResources.potential;
		if (type == 0)
		{
			empty = empty + "\n|5|2|" + mResources.to_gain_20hp;
		}
		if (type == 1)
		{
			empty = empty + "\n|5|2|" + mResources.to_gain_20mp;
		}
		if (type == 2)
		{
			empty = empty + "\n|5|2|" + mResources.to_gain_1pow;
		}
		currItem = null;
		partID = null;
		charInfo = null;
		idIcon = -1;
		cp = new T14();
		M1278(cp, empty);
	}

	private void M1419()
	{
	}

	private void M1420()
	{
		if (imgMap != null)
		{
			imgMap.texture = null;
			imgMap = null;
		}
		T174.lastPlanetId = -1;
		T110.M1062();
		T157.M1777();
		M1275();
		cmtoX = 0;
		cmx = 0;
	}

	private void M1421()
	{
		if (selected != -1)
		{
			T137.M1513("FIRE ZONE");
			isChangeZone = true;
			T51.panel.M1382();
		}
	}

	public void M1422(int recieve, int maxCap)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		cp.says[cp.says.Length - 1] = mResources.received + " " + recieve + "/" + maxCap;
	}

	private void M1423()
	{
		if (selected < 0)
		{
			return;
		}
		currItem = null;
		T117 t = new T117();
		if (currentTabIndex == 0 && !Equals(T51.panel2))
		{
			T79 t2 = T13.M113().arrItemBox[selected];
			if (t2 != null)
			{
				if (isBoxClan)
				{
					t.M1111(new T22(mResources.GETOUT, this, 1000, t2));
					t.M1111(new T22(mResources.USE, this, 2010, t2));
				}
				else if (t2.M805())
				{
					t.M1111(new T22(mResources.GETOUT, this, 1000, t2));
				}
				else
				{
					t.M1111(new T22(mResources.GETOUT, this, 1000, t2));
				}
				currItem = t2;
			}
		}
		if (currentTabIndex == 1 || Equals(T51.panel2))
		{
			T79[] arrItemBody = T13.M113().arrItemBody;
			if (selected >= arrItemBody.Length)
			{
				sbyte b = (sbyte)(selected - arrItemBody.Length);
				T79 t3 = T13.M113().arrItemBag[b];
				if (t3 != null)
				{
					t.M1111(new T22(mResources.move_to_chest, this, 1001, t3));
					if (t3.M805())
					{
						t.M1111(new T22(mResources.USE, this, 2000, t3));
					}
					else
					{
						t.M1111(new T22(mResources.USE, this, 2001, t3));
					}
					currItem = t3;
				}
			}
			else
			{
				T79 t4 = T13.M113().arrItemBody[M1455(selected + 1, newSelected)];
				if (t4 != null)
				{
					t.M1111(new T22(mResources.move_to_chest2, this, 1002, t4));
					currItem = t4;
				}
			}
		}
		if (currItem != null)
		{
			T13.M113().M243(currItem.headTemp, currItem.bodyTemp, currItem.legTemp, currItem.bagTemp);
			if (isBoxClan)
			{
				t.M1111(new T22(mResources.MOVEOUT, this, 2011, currItem));
			}
			T51.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1277(currItem);
		}
		else
		{
			cp = null;
		}
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
	}

	public void M1424(sbyte itemAction, string info, sbyte where, sbyte index)
	{
		T51.M488();
		T81 t = new T81();
		t.type = itemAction;
		t.id = index;
		t.where = where;
		T51.M496(info, new T22(mResources.YES, this, 2004, t), new T22(mResources.NO, this, 4005, null));
	}

	public void M1425(sbyte type, string info, short id)
	{
		T81 t = new T81();
		t.type = type;
		t.id = id;
		T51.M496(info, new T22(mResources.YES, this, 3003, t), new T22(mResources.NO, this, 4005, null));
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 9999)
		{
			T176 t = (T176)p;
			T146.M1594().M1736(t.pId);
		}
		if (idAction == 170391)
		{
			T138.M1547();
			if (T99.zoomLevel > 1)
			{
				T138.M1543("levelScreenKN", 1);
			}
			else
			{
				T138.M1543("levelScreenKN", 0);
			}
			T52.instance.M520();
		}
		if (idAction == 6001)
		{
			T79 t2 = (T79)p;
			t2.isSelect = false;
			T51.panel.vItemCombine.M1119(t2);
			if (T51.panel.currentTabIndex == 0)
			{
				T51.panel.M1271();
			}
		}
		if (idAction == 6000)
		{
			T79 t3 = (T79)p;
			for (int i = 0; i < T51.panel.vItemCombine.M1113(); i++)
			{
				if (((T79)T51.panel.vItemCombine.M1114(i)).template.id == t3.template.id)
				{
					T51.M489(mResources.already_has_item);
					return;
				}
			}
			t3.isSelect = true;
			T51.panel.vItemCombine.M1111(t3);
			if (T51.panel.currentTabIndex == 0)
			{
				T51.panel.M1271();
			}
		}
		if (idAction == 7000)
		{
			if (isLock)
			{
				T51.M489(mResources.unlock_item_to_trade);
				return;
			}
			T79 t4 = (T79)p;
			for (int j = 0; j < T51.panel.vMyGD.M1113(); j++)
			{
				if (((T79)T51.panel.vMyGD.M1114(j)).indexUI == t4.indexUI)
				{
					T51.M489(mResources.already_has_item);
					return;
				}
			}
			if (t4.quantity > 1)
			{
				M1406();
				return;
			}
			t4.isSelect = true;
			T79 t5 = new T79();
			t5.template = t4.template;
			t5.itemOption = t4.itemOption;
			t5.indexUI = t4.indexUI;
			T51.panel.vMyGD.M1111(t5);
			T146.M1594().M1601(2, -1, (sbyte)t5.indexUI, t5.quantity);
		}
		if (idAction == 7001)
		{
			T79 t6 = (T79)p;
			t6.isSelect = false;
			T51.panel.vMyGD.M1119(t6);
			if (T51.panel.currentTabIndex == 1)
			{
				T51.panel.M1296(isMe: true);
			}
			T146.M1594().M1601(4, -1, (sbyte)t6.indexUI, -1);
		}
		if (idAction == 7002)
		{
			isAccept = true;
			T51.M488();
			T146.M1594().M1601(7, -1, -1, -1);
			M1382();
		}
		if (idAction == 8003)
		{
			T67 t7 = (T67)p;
			T146.M1594().M1608(1, t7.charInfo.charID);
		}
		if (idAction == 8002)
		{
			T67 t8 = (T67)p;
			T146.M1594().M1608(2, t8.charInfo.charID);
		}
		if (idAction == 8004)
		{
			T67 t9 = (T67)p;
			T146.M1594().M1595(t9.charInfo.charID);
		}
		if (idAction == 8001)
		{
			T137.M1513("chat player");
			T67 t10 = (T67)p;
			if (chatTField == null)
			{
				chatTField = new T15();
				chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = T51.panel;
			}
			chatTField.strChat = mResources.chat_player;
			chatTField.tfChat.name = mResources.chat_with + " " + t10.charInfo.cName;
			chatTField.to = string.Empty;
			chatTField.isShow = true;
			chatTField.tfChat.isFocus = true;
			chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
			if (Main.isWindowsPhone)
			{
				chatTField.tfChat.strInfo = chatTField.strChat;
			}
			if (!Main.isPC)
			{
				chatTField.M282(this, string.Empty);
			}
		}
		if (idAction == 1000)
		{
			T146.M1594().M1625(BOX_BAG, (sbyte)selected);
		}
		if (idAction == 1001)
		{
			T79[] arrItemBody = T13.M113().arrItemBody;
			sbyte id = (sbyte)(selected - arrItemBody.Length);
			T146.M1594().M1625(BAG_BOX, id);
		}
		if (idAction == 1003)
		{
			M1382();
		}
		if (idAction == 1002)
		{
			T146.M1594().M1625(BODY_BOX, (sbyte)selected);
		}
		if (idAction == 2011)
		{
			T146.M1594().M1615(1, 2, (sbyte)selected, -1);
		}
		if (idAction == 2010)
		{
			T146.M1594().M1615(0, 2, (sbyte)selected, 0);
			T79 t11 = (T79)p;
			if (t11 != null && (t11.template.id == 193 || t11.template.id == 194))
			{
				T51.panel.M1382();
			}
		}
		if (idAction == 2000)
		{
			T79[] arrItemBody2 = T13.M113().arrItemBody;
			sbyte id2 = (sbyte)(selected - arrItemBody2.Length);
			T146.M1594().M1625(BAG_BODY, id2);
		}
		if (idAction == 2001)
		{
			T137.M1513("use item");
			T79 t12 = (T79)p;
			bool flag = selected < T13.M113().arrItemBody.Length;
			sbyte b = 0;
			if (!flag)
			{
				b = (sbyte)(selected - T13.M113().arrItemBody.Length);
			}
			T146.M1594().M1615(0, (!flag) ? ((sbyte)1) : ((sbyte)0), (sbyte)((!flag) ? b : selected), t12.template.id);
			if (t12.template.id == 193 || t12.template.id == 194)
			{
				T51.panel.M1382();
			}
		}
		if (idAction == 2002)
		{
			T146.M1594().M1625(BODY_BAG, (sbyte)selected);
		}
		if (idAction == 2003)
		{
			T137.M1513("remove item");
			bool flag2 = selected < T13.M113().arrItemBody.Length;
			sbyte b2 = 0;
			b2 = (flag2 ? ((sbyte)selected) : ((sbyte)(selected - T13.M113().arrItemBody.Length)));
			T146.M1594().M1615(1, (!flag2) ? ((sbyte)1) : ((sbyte)0), b2, -1);
		}
		if (idAction == 2004)
		{
			T51.M488();
			T81 t13 = (T81)p;
			sbyte where = (sbyte)t13.where;
			sbyte index = (sbyte)t13.id;
			T146.M1594().M1615((sbyte)((t13.type != 0) ? 2 : 3), where, index, -1);
		}
		if (idAction == 2005)
		{
			int num = M1456(selected + 1, newSelected, T13.M113().arrItemBody);
			T146.M1594().M1625(BAG_PET, (sbyte)num);
		}
		if (idAction == 2006)
		{
			_ = T13.M114().arrItemBody;
			int num2 = selected;
			T146.M1594().M1625(PET_BAG, (sbyte)num2);
		}
		if (idAction == 30001)
		{
			T137.M1513("nhan do");
			T146.M1594().M1651(0, selected, 0);
		}
		if (idAction == 30002)
		{
			T137.M1513("xoa do");
			T146.M1594().M1651(1, selected, 0);
		}
		if (idAction == 30003)
		{
			T137.M1513("nhan tat");
			T146.M1594().M1651(2, selected, 0);
		}
		if (idAction == 3000)
		{
			T137.M1513("mua do");
			T79 t14 = (T79)p;
			T146.M1594().M1651(0, t14.template.id, 0);
		}
		if (idAction == 3001)
		{
			T79 t15 = (T79)p;
			T51.msgdlg.M1035();
			T146.M1594().M1651(1, t15.template.id, 0);
		}
		if (idAction == 3002)
		{
			T51.M488();
			bool flag3 = M1454(selected, newSelected, T13.M113().arrItemBody);
			sbyte b3 = 0;
			b3 = (flag3 ? ((sbyte)M1455(selected, newSelected)) : ((sbyte)M1456(selected, newSelected, T13.M113().arrItemBody)));
			T146.M1594().M1650(0, (!flag3) ? ((sbyte)1) : ((sbyte)0), b3);
		}
		if (idAction == 3003)
		{
			T51.M488();
			T81 t16 = (T81)p;
			T146.M1594().M1650(1, (sbyte)t16.type, (short)t16.id);
		}
		if (idAction == 3004)
		{
			T79 t17 = (T79)p;
			T146.M1594().M1651(3, t17.template.id, 0);
		}
		if (idAction == 3005)
		{
			T137.M1513("mua do");
			T79 t18 = (T79)p;
			T146.M1594().M1651(3, t18.template.id, 0);
		}
		if (idAction == 4000)
		{
			T16 t19 = (T16)p;
			if (t19 != null)
			{
				T51.M488();
				T146.M1594().M1614(2, null, t19.ID);
			}
		}
		if (idAction == 4001)
		{
			T16 t20 = (T16)p;
			if (t20 != null)
			{
				T66.M749();
				clanReport = mResources.PLEASEWAIT;
				T146.M1594().M1617(t20.ID);
			}
		}
		if (idAction == 4005)
		{
			T51.M488();
		}
		if (idAction == 4007)
		{
			T51.M488();
		}
		if (idAction == 4006)
		{
			T19 t21 = (T19)p;
			T146.M1594().M1613(t21.id);
		}
		if (idAction == 5001)
		{
			T95 t22 = (T95)p;
			T146.M1594().M1620(t22.ID, 0);
		}
		if (idAction == 5002)
		{
			T95 t23 = (T95)p;
			T146.M1594().M1620(t23.ID, 1);
		}
		if (idAction == 5003)
		{
			T95 t24 = (T95)p;
			T146.M1594().M1620(t24.ID, 2);
		}
		if (idAction == 5004)
		{
			T95 t25 = (T95)p;
			T146.M1594().M1620(t25.ID, -1);
		}
		if (idAction == 9000)
		{
			T146.M1594().M1719(selected, 1);
			T51.M488();
			T66.M749();
		}
		if (idAction == 9006)
		{
			T146.M1594().M1719(selected, 10);
			T51.M488();
			T66.M749();
		}
		if (idAction == 9007)
		{
			T146.M1594().M1719(selected, 100);
			T51.M488();
			T66.M749();
		}
		if (idAction == 9002)
		{
			T149 t26 = (T149)p;
			T51.M489(mResources.can_buy_from_Uron1 + t26.powRequire + mResources.can_buy_from_Uron2 + t26.moreInfo + mResources.can_buy_from_Uron3);
		}
		if (idAction == 9003)
		{
			if (T51.isTouch && !Main.isPC)
			{
				T54.M559().M545((T155)p);
			}
			else
			{
				T54.M559().M546((T155)p);
			}
		}
		if (idAction == 9004)
		{
			T149 t27 = (T149)p;
			T51.M489(mResources.can_buy_from_Uron1 + t27.powRequire + mResources.can_buy_from_Uron2 + t27.moreInfo + mResources.can_buy_from_Uron3);
		}
		if (idAction == 10000)
		{
			T67 t28 = (T67)p;
			T146.M1594().M1724(1, t28.charInfo.charID);
			T51.panel.M1381();
		}
		if (idAction == 10001)
		{
			T67 t29 = (T67)p;
			T146.M1594().M1724(2, t29.charInfo.charID);
			T66.M749();
		}
		if (idAction == 10012)
		{
			if (chatTField == null)
			{
				chatTField = new T15();
				chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = ((T51.panel2 != null) ? T51.panel2 : T51.panel);
			}
			if (currItem.quantity == 1)
			{
				chatTField.strChat = mResources.kiguiXuchat;
				chatTField.tfChat.name = mResources.input_money;
			}
			else
			{
				chatTField.strChat = mResources.input_quantity + " ";
				chatTField.tfChat.name = mResources.input_quantity;
			}
			chatTField.tfChat.M1929(9);
			chatTField.to = string.Empty;
			chatTField.isShow = true;
			chatTField.tfChat.M1931(T173.INPUT_TYPE_NUMERIC);
			if (T51.isTouch)
			{
				chatTField.tfChat.M1901();
			}
			if (Main.isWindowsPhone)
			{
				chatTField.tfChat.strInfo = chatTField.strChat;
			}
			if (!Main.isPC)
			{
				chatTField.M282(this, string.Empty);
			}
		}
		if (idAction == 10013)
		{
			if (chatTField == null)
			{
				chatTField = new T15();
				chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = ((T51.panel2 != null) ? T51.panel2 : T51.panel);
			}
			if (currItem.quantity == 1)
			{
				chatTField.strChat = mResources.kiguiLuongchat;
				chatTField.tfChat.name = mResources.input_money;
			}
			else
			{
				chatTField.strChat = mResources.input_quantity + "  ";
				chatTField.tfChat.name = mResources.input_quantity;
			}
			chatTField.to = string.Empty;
			chatTField.isShow = true;
			chatTField.tfChat.M1931(T173.INPUT_TYPE_NUMERIC);
			if (T51.isTouch)
			{
				chatTField.tfChat.M1901();
			}
			if (Main.isWindowsPhone)
			{
				chatTField.tfChat.strInfo = chatTField.strChat;
			}
			if (!Main.isPC)
			{
				chatTField.M282(this, string.Empty);
			}
		}
		if (idAction == 10014)
		{
			T79 t30 = (T79)p;
			T146.M1594().M1725(1, t30.itemId, -1, -1, -1);
			T66.M749();
		}
		if (idAction == 10015)
		{
			T79 t31 = (T79)p;
			T146.M1594().M1725(2, t31.itemId, -1, -1, -1);
			T66.M749();
		}
		if (idAction == 10016)
		{
			T79 t32 = (T79)p;
			T146.M1594().M1725(3, t32.itemId, 0, t32.buyCoin, -1);
			T66.M749();
		}
		if (idAction == 10017)
		{
			T79 t33 = (T79)p;
			T146.M1594().M1725(3, t33.itemId, 1, t33.buyGold, -1);
			T66.M749();
		}
		if (idAction == 10018)
		{
			T79 t34 = (T79)p;
			T146.M1594().M1725(5, t34.itemId, -1, -1, -1);
			T66.M749();
		}
		if (idAction == 10019)
		{
			T147.M1744().close();
			T138.M1538("acc", string.Empty);
			T138.M1538("pass", string.Empty);
			T51.loginScr.tfPass.M1926(string.Empty);
			T51.loginScr.tfUser.M1926(string.Empty);
			T51.loginScr.isLogin2 = false;
			T51.loginScr.switchToMe();
			T51.M488();
			M1382();
		}
		if (idAction == 10020)
		{
			T51.M488();
		}
		if (idAction == 10030)
		{
			T146.M1594().M1726(1, (sbyte)selected);
			T51.panel.M1381();
		}
		if (idAction == 10031)
		{
			T147.M1744().close();
		}
		if (idAction == 11000)
		{
			T146.M1594().M1725(0, currItem.itemId, 1, currItem.buyRuby, 1);
			T51.M488();
		}
		if (idAction == 11001)
		{
			T146.M1594().M1725(0, currItem.itemId, 1, currItem.buyRuby, currItem.quantilyToBuy);
			T51.M488();
		}
		if (idAction == 11002)
		{
			chatTField.isShow = false;
			T51.M488();
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (chatTField.tfChat.M1924() != null && !chatTField.tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (chatTField.strChat.Equals(mResources.input_clan_name))
			{
				T66.M749();
				chatTField.isShow = false;
				T146.M1594().M1618(text);
				return;
			}
			if (chatTField.strChat.Equals(mResources.chat_clan))
			{
				T66.M749();
				chatTField.isShow = false;
				T146.M1594().M1614(0, text, -1);
				return;
			}
			if (chatTField.strChat.Equals(mResources.input_clan_name_to_create))
			{
				if (chatTField.tfChat.M1924() == string.Empty)
				{
					T54.info1.M762(mResources.clan_name_blank, 0);
					return;
				}
				if (tabIcon == null)
				{
					tabIcon = new T167();
				}
				tabIcon.text = chatTField.tfChat.M1924();
				tabIcon.M1886(isGetName: false);
				chatTField.isShow = false;
				return;
			}
			if (chatTField.strChat.Equals(mResources.input_clan_slogan))
			{
				if (chatTField.tfChat.M1924() == string.Empty)
				{
					T54.info1.M762(mResources.clan_slogan_blank, 0);
					return;
				}
				T146.M1594().M1623(4, (sbyte)T13.M113().clan.imgID, chatTField.tfChat.M1924());
				chatTField.isShow = false;
				return;
			}
			if (chatTField.strChat.Equals(mResources.input_Inventory_Pass))
			{
				try
				{
					int pass = int.Parse(chatTField.tfChat.M1924());
					if (chatTField.tfChat.M1924().Length == 6 && !chatTField.tfChat.M1924().Equals(string.Empty))
					{
						T146.M1594().M1727(pass);
						chatTField.isShow = false;
						chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
						M1382();
					}
					else
					{
						T51.M489(mResources.input_Inventory_Pass_wrong);
					}
					return;
				}
				catch (Exception)
				{
					T51.M489(mResources.ALERT_PRIVATE_PASS_2);
					return;
				}
			}
			if (chatTField.strChat.Equals(mResources.world_channel_5_luong))
			{
				if (!chatTField.tfChat.M1924().Equals(string.Empty))
				{
					T146.M1594().M1694(chatTField.tfChat.M1924());
					chatTField.isShow = false;
					M1382();
				}
			}
			else if (chatTField.strChat.Equals(mResources.chat_player))
			{
				chatTField.isShow = false;
				T67 t = null;
				if (type == 8)
				{
					t = (T67)logChat.M1114(currInfoItem);
				}
				else if (type == 11)
				{
					t = (T67)vFriend.M1114(currInfoItem);
				}
				if (t.charInfo.charID != T13.M113().charID)
				{
					T146.M1594().M1693(text, t.charInfo.charID);
				}
			}
			else if (chatTField.strChat.Equals(mResources.input_quantity_to_trade))
			{
				int num = 0;
				try
				{
					num = int.Parse(chatTField.tfChat.M1924());
				}
				catch (Exception)
				{
					T51.M489(mResources.input_quantity_wrong);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
					return;
				}
				if (num > 0 && num <= currItem.quantity)
				{
					currItem.isSelect = true;
					T79 t2 = new T79();
					t2.template = currItem.template;
					t2.quantity = num;
					t2.indexUI = currItem.indexUI;
					t2.itemOption = currItem.itemOption;
					T51.panel.vMyGD.M1111(t2);
					T146.M1594().M1601(2, -1, (sbyte)t2.indexUI, t2.quantity);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
				}
				else
				{
					T51.M489(mResources.input_quantity_wrong);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
				}
			}
			else if (chatTField.strChat == mResources.input_money_to_trade)
			{
				int num2 = 0;
				try
				{
					num2 = int.Parse(chatTField.tfChat.M1924());
				}
				catch (Exception)
				{
					T51.M489(mResources.input_money_wrong);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
					return;
				}
				if (num2 > T13.M113().xu)
				{
					T51.M489(mResources.not_enough_money);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
				}
				else
				{
					moneyGD = num2;
					T146.M1594().M1601(2, -1, -1, num2);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
				}
			}
			else if (chatTField.strChat.Equals(mResources.kiguiXuchat))
			{
				T146.M1594().M1725(0, currItem.itemId, 0, int.Parse(chatTField.tfChat.M1924()), 1);
				chatTField.isShow = false;
			}
			else if (chatTField.strChat.Equals(mResources.kiguiXuchat + " "))
			{
				T146.M1594().M1725(0, currItem.itemId, 0, int.Parse(chatTField.tfChat.M1924()), currItem.quantilyToBuy);
				chatTField.isShow = false;
			}
			else if (chatTField.strChat.Equals(mResources.kiguiLuongchat))
			{
				M1444(0);
				chatTField.isShow = false;
			}
			else if (chatTField.strChat.Equals(mResources.kiguiLuongchat + "  "))
			{
				M1444(1);
				chatTField.isShow = false;
			}
			else if (chatTField.strChat.Equals(mResources.input_quantity + " "))
			{
				currItem.quantilyToBuy = int.Parse(chatTField.tfChat.M1924());
				if (currItem.quantilyToBuy > currItem.quantity)
				{
					T51.M489(mResources.input_quantity_wrong);
					return;
				}
				isKiguiXu = true;
				chatTField.isShow = false;
			}
			else if (chatTField.strChat.Equals(mResources.input_quantity + "  "))
			{
				currItem.quantilyToBuy = int.Parse(chatTField.tfChat.M1924());
				if (currItem.quantilyToBuy > currItem.quantity)
				{
					T51.M489(mResources.input_quantity_wrong);
					return;
				}
				isKiguiLuong = true;
				chatTField.isShow = false;
			}
		}
		else
		{
			chatTField.isShow = false;
		}
	}

	public void onCancelChat()
	{
		chatTField.tfChat.M1931(T173.INPUT_TYPE_ANY);
	}

	public void M1426(int type)
	{
		typeCombine = type;
		rS = 90;
		if (typeCombine == 0)
		{
			iDotS = 5;
			angleO = 90;
			angleS = 90;
			time = 2;
			for (int i = 0; i < vItemCombine.M1113(); i++)
			{
				T79 t = (T79)vItemCombine.M1114(i);
				if (t != null)
				{
					if (t.template.type == 14)
					{
						iconID2 = t.template.iconID;
					}
					else
					{
						iconID1 = t.template.iconID;
					}
				}
			}
		}
		else if (typeCombine == 1)
		{
			iDotS = 2;
			angleO = 0;
			angleS = 0;
			time = 1;
			for (int j = 0; j < vItemCombine.M1113(); j++)
			{
				T79 t2 = (T79)vItemCombine.M1114(j);
				if (t2 != null)
				{
					if (j == 0)
					{
						iconID1 = t2.template.iconID;
					}
					else
					{
						iconID2 = t2.template.iconID;
					}
				}
			}
		}
		else if (typeCombine == 2)
		{
			iDotS = 7;
			angleO = 25;
			angleS = 25;
			time = 1;
			for (int k = 0; k < vItemCombine.M1113(); k++)
			{
				T79 t3 = (T79)vItemCombine.M1114(k);
				if (t3 != null)
				{
					iconID1 = t3.template.iconID;
				}
			}
		}
		else if (typeCombine == 3)
		{
			xS = T51.hw;
			yS = T51.hh;
			iDotS = 1;
			angleO = 1;
			angleS = 1;
			time = 4;
			for (int l = 0; l < vItemCombine.M1113(); l++)
			{
				T79 t4 = (T79)vItemCombine.M1114(l);
				if (t4 != null)
				{
					iconID1 = t4.template.iconID;
				}
			}
		}
		else if (typeCombine == 4)
		{
			iDotS = vItemCombine.M1113();
			iconID = new short[iDotS];
			angleO = 25;
			angleS = 25;
			time = 1;
			for (int m = 0; m < vItemCombine.M1113(); m++)
			{
				T79 t5 = (T79)vItemCombine.M1114(m);
				if (t5 != null)
				{
					iconID[m] = t5.template.iconID;
				}
			}
		}
		speed = 1;
		isSpeedCombine = true;
		isDoneCombine = false;
		isCompleteEffCombine = false;
		iAngleS = 360 / iDotS;
		xArgS = new int[iDotS];
		yArgS = new int[iDotS];
		xDotS = new int[iDotS];
		yDotS = new int[iDotS];
		M1429();
		isPaintCombine = true;
		countUpdate = 10;
		countR = 30;
		countWait = 10;
		M1431(idNPC, mResources.combineSpell);
	}

	private void M1427()
	{
		countUpdate--;
		if (countUpdate < 0)
		{
			countUpdate = 0;
		}
		countR--;
		if (countR < 0)
		{
			countR = 0;
		}
		if (countUpdate != 0)
		{
			return;
		}
		if (!isCompleteEffCombine)
		{
			if (time > 0)
			{
				if (combineSuccess != -1)
				{
					if (typeCombine == 3)
					{
						if (T51.gameTick % 10 == 0)
						{
							T31.M376(new T32(21, xS - 10, yS + 25, 4, 1, 1));
							time--;
						}
					}
					else
					{
						if (T51.gameTick % 2 == 0)
						{
							if (isSpeedCombine)
							{
								if (speed < 40)
								{
									speed += 2;
								}
							}
							else if (speed > 10)
							{
								speed -= 2;
							}
						}
						if (countR == 0)
						{
							if (isSpeedCombine)
							{
								if (rS > 0)
								{
									rS -= 5;
								}
								else if (T51.gameTick % 10 == 0)
								{
									isSpeedCombine = false;
									time--;
									countR = 5;
									countWait = 10;
								}
							}
							else if (rS < 90)
							{
								rS += 5;
							}
							else if (T51.gameTick % 10 == 0)
							{
								isSpeedCombine = true;
								countR = 10;
							}
						}
						angleS = angleO;
						angleS -= speed;
						if (angleS >= 360)
						{
							angleS -= 360;
						}
						if (angleS < 0)
						{
							angleS = 360 + angleS;
						}
						angleO = angleS;
						M1429();
					}
				}
			}
			else if (T51.gameTick % 20 == 0)
			{
				isCompleteEffCombine = true;
			}
			if (T51.gameTick % 20 == 0)
			{
				if (typeCombine != 3)
				{
					T41.M415(132, xS, yS, 2);
				}
				T41.M415(114, xS, yS + 20, 2);
			}
		}
		else
		{
			if (!isCompleteEffCombine)
			{
				return;
			}
			if (combineSuccess == 1)
			{
				if (countWait == 10)
				{
					T31.M376(new T32(22, xS - 3, yS + 25, 4, 1, 1));
				}
				countWait--;
				if (countWait < 0)
				{
					countWait = 0;
				}
				if (rS < 300)
				{
					rS = T137.M1529(rS + 10);
					if (rS == 20)
					{
						M1431(idNPC, mResources.combineFail);
					}
				}
				else if (T51.gameTick % 20 == 0)
				{
					if (T51.w > 2 * WIDTH_PANEL)
					{
						T51.panel2 = new T126();
						T51.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
						T51.panel2.M1253();
						T51.panel2.M1285();
					}
					combineSuccess = -1;
					isDoneCombine = true;
					if (typeCombine == 4)
					{
						T51.panel.M1381();
					}
				}
				M1429();
			}
			else
			{
				if (combineSuccess != 0)
				{
					return;
				}
				if (countWait == 10)
				{
					if (typeCombine == 2)
					{
						T31.M376(new T32(20, xS - 3, yS + 15, 4, 2, 1));
					}
					else
					{
						T31.M376(new T32(21, xS - 10, yS + 25, 4, 1, 1));
					}
					M1431(idNPC, mResources.combineSuccess);
					isPaintCombine = false;
				}
				if (isPaintCombine)
				{
					return;
				}
				countWait--;
				if (countWait < -50)
				{
					countWait = -50;
					if (typeCombine < 3 && T51.w > 2 * WIDTH_PANEL)
					{
						T51.panel2 = new T126();
						T51.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
						T51.panel2.M1253();
						T51.panel2.M1285();
					}
					combineSuccess = -1;
					isDoneCombine = true;
					if (typeCombine == 4)
					{
						T51.panel.M1381();
					}
				}
			}
		}
	}

	public void M1428(T99 g)
	{
		T54.M559().M619(g);
		M1430(g);
		if (typeCombine == 0)
		{
			for (int i = 0; i < yArgS.Length; i++)
			{
				T157.M1785(g, iconID1, xS, yS, 0, T99.VCENTER | T99.HCENTER);
				if (isPaintCombine)
				{
					T157.M1785(g, iconID2, xDotS[i], yDotS[i], 0, T99.VCENTER | T99.HCENTER);
				}
			}
		}
		else if (typeCombine == 1)
		{
			if (!isPaintCombine)
			{
				T157.M1785(g, iconID3, xS, yS, 0, T99.VCENTER | T99.HCENTER);
				return;
			}
			for (int j = 0; j < yArgS.Length; j++)
			{
				T157.M1785(g, iconID1, xDotS[0], yDotS[0], 0, T99.VCENTER | T99.HCENTER);
				T157.M1785(g, iconID2, xDotS[1], yDotS[1], 0, T99.VCENTER | T99.HCENTER);
			}
		}
		else if (typeCombine == 2)
		{
			if (!isPaintCombine)
			{
				T157.M1785(g, iconID3, xS, yS, 0, T99.VCENTER | T99.HCENTER);
				return;
			}
			for (int k = 0; k < yArgS.Length; k++)
			{
				T157.M1785(g, iconID1, xDotS[k], yDotS[k], 0, T99.VCENTER | T99.HCENTER);
			}
		}
		else if (typeCombine == 3)
		{
			if (!isPaintCombine)
			{
				T157.M1785(g, iconID3, xS, yS, 0, T99.VCENTER | T99.HCENTER);
			}
			else
			{
				T157.M1785(g, iconID1, xS, yS, 0, T99.VCENTER | T99.HCENTER);
			}
		}
		else
		{
			if (typeCombine != 4)
			{
				return;
			}
			if (!isPaintCombine)
			{
				if (iconID3 != -1)
				{
					T157.M1785(g, iconID3, xS, yS, 0, T99.VCENTER | T99.HCENTER);
				}
			}
			else
			{
				for (int l = 0; l < iconID.Length; l++)
				{
					T157.M1785(g, iconID[l], xDotS[l], yDotS[l], 0, T99.VCENTER | T99.HCENTER);
				}
			}
		}
	}

	private void M1429()
	{
		for (int i = 0; i < yArgS.Length; i++)
		{
			if (angleS >= 360)
			{
				angleS -= 360;
			}
			if (angleS < 0)
			{
				angleS = 360 + angleS;
			}
			yArgS[i] = T137.M1529(rS * T137.M1507(angleS) / 1024);
			xArgS[i] = T137.M1529(rS * T137.M1508(angleS) / 1024);
			if (angleS < 90)
			{
				xDotS[i] = xS + xArgS[i];
				yDotS[i] = yS - yArgS[i];
			}
			else if (angleS >= 90 && angleS < 180)
			{
				xDotS[i] = xS - xArgS[i];
				yDotS[i] = yS - yArgS[i];
			}
			else if (angleS >= 180 && angleS < 270)
			{
				xDotS[i] = xS - xArgS[i];
				yDotS[i] = yS + yArgS[i];
			}
			else
			{
				xDotS[i] = xS + xArgS[i];
				yDotS[i] = yS + yArgS[i];
			}
			angleS -= iAngleS;
		}
	}

	public void M1430(T99 g)
	{
		g.M918(-T54.cmx, -T54.cmy);
		if (typeCombine < 3)
		{
			for (int i = 0; i < T54.vNpc.M1113(); i++)
			{
				T123 t = (T123)T54.vNpc.M1114(i);
				if (t.template.npcTemplateId == idNPC)
				{
					t.paint(g);
					if (t.chatInfo != null)
					{
						t.chatInfo.M741(g, t.cx, t.cy - t.ch - T51.transY, t.cdir);
					}
				}
			}
		}
		T51.M451(g);
		if (T51.gameTick % 4 == 0)
		{
			g.M948(T80.imageFlare, xS - 5, yS + 15, T99.BOTTOM | T99.HCENTER);
			g.M948(T80.imageFlare, xS + 5, yS + 15, T99.BOTTOM | T99.HCENTER);
			g.M948(T80.imageFlare, xS, yS + 15, T99.BOTTOM | T99.HCENTER);
		}
		for (int j = 0; j < T33.vEffect3.M1113(); j++)
		{
			((T33)T33.vEffect3.M1114(j)).paint(g);
		}
	}

	public void M1431(int idNPC, string text)
	{
		if (typeCombine >= 3)
		{
			return;
		}
		for (int i = 0; i < T54.vNpc.M1113(); i++)
		{
			T123 t = (T123)T54.vNpc.M1114(i);
			if (t.template.npcTemplateId == idNPC)
			{
				t.M111(text);
			}
		}
	}

	public void M1432()
	{
		type = 19;
		M1246(0);
		M1433();
		cmtoX = 0;
		cmx = 0;
	}

	private void M1433()
	{
		T160.M1826().M1829();
		currentListLength = strCauhinh.Length;
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
	}

	private void M1434(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < strCauhinh.Length; i++)
		{
			int x = xScroll;
			int num = yScroll + i * ITEM_HEIGHT;
			int num2 = wScroll - 1;
			int h = ITEM_HEIGHT - 1;
			if (num - cmy <= yScroll + hScroll && num - cmy >= yScroll - ITEM_HEIGHT)
			{
				g.M933((i != selected) ? 15196114 : 16383818);
				g.M932(x, num, num2, h);
				T98.tahoma_7b_dark.M898(g, strCauhinh[i], xScroll + wScroll / 2, num + 6, T98.CENTER);
			}
		}
		M1335(g);
	}

	private void M1435()
	{
		if (selected < 0)
		{
			return;
		}
		switch (selected)
		{
		case 0:
			T160.M1826().M1839();
			break;
		case 1:
			T160.M1826().M1838();
			break;
		case 2:
			T160.M1826().M1837();
			break;
		case 3:
			if (Main.isPC)
			{
				T51.M496(mResources.changeSizeScreen, new T22(mResources.YES, this, 170391, null), new T22(mResources.NO, this, 4005, null));
				break;
			}
			if (T54.isAnalog == 0)
			{
				T54.isAnalog = 1;
				T138.M1543("analog", T54.isAnalog);
				T54.M565();
			}
			else
			{
				T54.isAnalog = 0;
				T138.M1543("analog", T54.isAnalog);
				T54.M565();
			}
			T160.M1826().M1829();
			break;
		}
	}

	public void M1436()
	{
		type = 20;
		M1246(0);
		M1437();
		cmtoX = 0;
		cmx = 0;
	}

	private void M1437()
	{
		if (Main.IphoneVersionApp)
		{
			strAccount = new string[4]
			{
				mResources.inventory_Pass,
				mResources.friend,
				mResources.enemy,
				mResources.msg
			};
			if (T54.canAutoPlay)
			{
				strAccount = new string[5]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.autoFunction
				};
			}
		}
		else
		{
			strAccount = new string[5]
			{
				mResources.inventory_Pass,
				mResources.friend,
				mResources.enemy,
				mResources.msg,
				mResources.charger
			};
			if (T54.canAutoPlay)
			{
				strAccount = new string[6]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.charger,
					mResources.autoFunction
				};
			}
			if ((T110.clientType == 2 || T110.clientType == 7) && mResources.language != 2)
			{
				strAccount = new string[5]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.charger
				};
				if (T54.canAutoPlay)
				{
					strAccount = new string[6]
					{
						mResources.inventory_Pass,
						mResources.friend,
						mResources.enemy,
						mResources.msg,
						mResources.charger,
						mResources.autoFunction
					};
				}
			}
		}
		currentListLength = strAccount.Length;
		ITEM_HEIGHT = 24;
		selected = (T51.isTouch ? (-1) : 0);
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
	}

	private void M1438(T99 g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < strAccount.Length; i++)
		{
			int x = xScroll;
			int num = yScroll + i * ITEM_HEIGHT;
			int num2 = wScroll - 1;
			int h = ITEM_HEIGHT - 1;
			if (num - cmy <= yScroll + hScroll && num - cmy >= yScroll - ITEM_HEIGHT)
			{
				g.M933((i != selected) ? 15196114 : 16383818);
				g.M932(x, num, num2, h);
				T98.tahoma_7b_dark.M898(g, strAccount[i], xScroll + wScroll / 2, num + 6, T98.CENTER);
			}
		}
		M1335(g);
	}

	private void M1439()
	{
		if (selected < 0)
		{
			return;
		}
		switch (selected)
		{
		case 0:
			T51.M488();
			if (chatTField == null)
			{
				chatTField = new T15();
				chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = T51.panel;
			}
			chatTField.tfChat.M1926(string.Empty);
			chatTField.strChat = mResources.input_Inventory_Pass;
			chatTField.tfChat.name = mResources.input_Inventory_Pass;
			chatTField.to = string.Empty;
			chatTField.isShow = true;
			chatTField.tfChat.isFocus = true;
			chatTField.tfChat.M1931(T173.INPUT_TYPE_NUMERIC);
			if (T51.isTouch)
			{
				chatTField.tfChat.M1901();
			}
			if (!Main.isPC)
			{
				chatTField.M282(this, string.Empty);
			}
			if (Main.isWindowsPhone)
			{
				chatTField.tfChat.strInfo = chatTField.strChat;
			}
			break;
		case 1:
			T146.M1594().M1608(0, -1);
			T66.M749();
			break;
		case 2:
			T146.M1594().M1724(0, -1);
			T66.M749();
			break;
		case 3:
			M1266();
			if (chatTField == null)
			{
				chatTField = new T15();
				chatTField.tfChat.y = T51.h - 35 - T15.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = T51.panel;
			}
			break;
		case 4:
			if (mResources.language == 2)
			{
				string url = "http://dragonball.indonaga.com/coda/?username=" + T51.loginScr.tfUser.M1924();
				M1381();
				try
				{
					T52.instance.M524(url);
					break;
				}
				catch (Exception ex)
				{
					ex.StackTrace.ToString();
					break;
				}
			}
			M1381();
			if (T13.M113().taskMaint.taskId <= 10)
			{
				T51.M489(mResources.finishBomong);
			}
			else
			{
				T104.M1013().switchToMe();
			}
			break;
		case 5:
			M1272();
			break;
		}
	}

	private void M1440()
	{
		M1307();
	}

	public void M1441()
	{
		type = 25;
		M1246(0);
		M1442();
		currentTabIndex = 0;
	}

	private void M1442()
	{
		ITEM_HEIGHT = 24;
		currentListLength = T13.M113().infoSpeacialSkill[currentTabIndex].Length;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		if (cmyLim < 0)
		{
			cmyLim = 0;
		}
		cmy = (cmtoY = cmyLast[currentTabIndex]);
		if (cmy < 0)
		{
			cmtoY = 0;
			cmy = 0;
		}
		if (cmy > cmyLim)
		{
			cmy = (cmtoY = cmyLim);
		}
		selected = (T51.isTouch ? (-1) : 0);
	}

	public bool M1443()
	{
		if (type == 1)
		{
			return true;
		}
		return false;
	}

	private void M1444(int type)
	{
		try
		{
			currItem.buyRuby = int.Parse(chatTField.tfChat.M1924());
		}
		catch (Exception)
		{
			T51.M489(mResources.input_money_wrong);
			chatTField.isShow = false;
			return;
		}
		T22 cmdYes = new T22(mResources.YES, this, (type != 0) ? 11001 : 11000, null);
		T22 cmdNo = new T22(mResources.NO, this, 11002, null);
		T51.M496(mResources.notiRuby, cmdYes, cmdNo);
	}

	public static void M1445(int x, int y, int wItem, int hItem, int nline, int cl, T99 g)
	{
		try
		{
			int num = ((wItem << 1) + (hItem << 1)) / nline;
			nsize = sizeUpgradeEff.Length;
			if (nline > 4)
			{
				nsize = 2;
			}
			for (int i = 0; i < nline; i++)
			{
				for (int j = 0; j < nsize; j++)
				{
					int wSize = ((sizeUpgradeEff[j] <= 1) ? 1 : ((sizeUpgradeEff[j] >> 1) + 1));
					int x2 = x + M1446(num * i, T51.gameTick - j * 4, wItem, hItem, wSize);
					int y2 = y + M1447(num * i, T51.gameTick - j * 4, wItem, hItem, wSize);
					g.M933(colorUpgradeEffect[cl][j]);
					g.M932(x2, y2, sizeUpgradeEff[j], sizeUpgradeEff[j]);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static int M1446(int dk, int tick, int wItem, int hitem, int wSize)
	{
		int num = (tick + dk) % ((wItem << 1) + (hitem << 1));
		if (0 <= num && num < wItem)
		{
			return num % wItem;
		}
		if (wItem <= num && num < wItem + hitem)
		{
			return wItem - wSize;
		}
		if (wItem + hitem <= num && num < (wItem << 1) + hitem)
		{
			return wItem - (num - hitem) % wItem - wSize;
		}
		return 0;
	}

	private static int M1447(int dk, int tick, int wItem, int hitem, int wSize)
	{
		int num = (tick + dk) % ((wItem << 1) + (hitem << 1));
		if (0 <= num && num < wItem)
		{
			return 0;
		}
		if (wItem <= num && num < wItem + hitem)
		{
			return num % wItem;
		}
		if (wItem + hitem <= num && num < (wItem << 1) + hitem)
		{
			return hitem - wSize;
		}
		return hitem - (num - (wItem << 1)) % hitem - wSize;
	}

	public static int M1448(int id)
	{
		return id switch
		{
			1 => 2786816, 
			2 => 7078041, 
			3 => 12537346, 
			4 => 1269146, 
			5 => 13279744, 
			6 => 11599872, 
			_ => -1, 
		};
	}

	public static sbyte M1449(int lv)
	{
		if (lv < 0)
		{
			return 0;
		}
		switch (lv)
		{
		default:
			return 6;
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
			return 0;
		case 9:
			return 4;
		case 10:
			return 1;
		case 11:
			return 5;
		case 12:
			return 3;
		case 13:
			return 2;
		}
	}

	public static T98 M1450(int color)
	{
		T98 result = T98.tahoma_7;
		switch (color)
		{
		case -1:
			result = T98.tahoma_7;
			break;
		case 0:
			result = T98.tahoma_7b_dark;
			break;
		case 1:
			result = T98.tahoma_7b_green;
			break;
		case 2:
			result = T98.tahoma_7b_blue;
			break;
		case 3:
			result = T98.tahoma_7_red;
			break;
		case 4:
			result = T98.tahoma_7_green;
			break;
		case 5:
			result = T98.tahoma_7_blue;
			break;
		case 7:
			result = T98.tahoma_7b_red;
			break;
		case 8:
			result = T98.tahoma_7b_yellow;
			break;
		}
		return result;
	}

	public void M1451(T99 g, int idOpt, int param, int x, int y, int w, int h)
	{
		switch (idOpt)
		{
		case 34:
			if (imgo_0 != null)
			{
				g.M950(imgo_0, x, y + h - imgo_0.M728());
			}
			else
			{
				imgo_0 = T110.M1071("/mainImage/o_0.png");
			}
			if (imgo_1 != null)
			{
				g.M950(imgo_1, x, y + h - imgo_1.M728());
			}
			else
			{
				imgo_1 = T110.M1071("/mainImage/o_1.png");
			}
			break;
		case 35:
			if (imgo_0 != null)
			{
				g.M950(imgo_0, x, y + h - imgo_0.M728());
			}
			else
			{
				imgo_0 = T110.M1071("/mainImage/o_0.png");
			}
			if (imgo_2 != null)
			{
				g.M950(imgo_2, x, y + h - imgo_2.M728());
			}
			else
			{
				imgo_2 = T110.M1071("/mainImage/o_2.png");
			}
			break;
		case 36:
			if (imgo_0 != null)
			{
				g.M950(imgo_0, x, y + h - imgo_0.M728());
			}
			else
			{
				imgo_0 = T110.M1071("/mainImage/o_0.png");
			}
			if (imgo_3 != null)
			{
				g.M950(imgo_3, x, y + h - imgo_3.M728());
			}
			else
			{
				imgo_3 = T110.M1071("/mainImage/o_3.png");
			}
			break;
		}
	}

	public void M1452(T99 g, int idOpt, int param, int x, int y, int w, int h)
	{
		if (idOpt == 102 && param > T14.numSlot)
		{
			int cl = M1449(param);
			M1445(x, y, w, h, param - T14.numSlot, cl, g);
		}
	}

	public static T98 M1453(int id, int type)
	{
		if (type == 0)
		{
			return id switch
			{
				0 => T98.bigNumber_While, 
				1 => T98.bigNumber_green, 
				3 => T98.bigNumber_orange, 
				4 => T98.bigNumber_blue, 
				5 => T98.bigNumber_yellow, 
				6 => T98.bigNumber_red, 
				_ => T98.bigNumber_While, 
			};
		}
		return id switch
		{
			0 => T98.tahoma_7b_white, 
			1 => T98.tahoma_7b_green, 
			3 => T98.tahoma_7b_yellowSmall2, 
			4 => T98.tahoma_7b_blue, 
			5 => T98.tahoma_7b_yellow, 
			6 => T98.tahoma_7b_red, 
			7 => T98.tahoma_7b_dark, 
			_ => T98.tahoma_7b_white, 
		};
	}

	private bool M1454(int select, int subSelect, T79[] arrItem)
	{
		int num = select - 1 + subSelect * 20;
		if (subSelect == 0)
		{
			return num < arrItem.Length;
		}
		return false;
	}

	private int M1455(int select, int subSelect)
	{
		return select - 1 + subSelect * 20;
	}

	private int M1456(int select, int subSelect, T79[] arrItem)
	{
		return select - 1 + subSelect * 20 - arrItem.Length;
	}

	private void M1457()
	{
		if (selected < 0)
		{
			return;
		}
		if (T51.keyPressed[(!Main.isPC) ? 4 : 23])
		{
			newSelected--;
			if (newSelected < 0)
			{
				newSelected = 0;
				if (T51.isFocusPanel2)
				{
					T51.isFocusPanel2 = false;
					T51.panel.selected = 0;
				}
			}
		}
		else
		{
			if (!T51.keyPressed[(!Main.isPC) ? 6 : 24])
			{
				return;
			}
			newSelected++;
			if (newSelected > size_tab - 1)
			{
				newSelected = size_tab - 1;
				if (T51.panel2 != null)
				{
					T51.isFocusPanel2 = true;
					T51.panel2.selected = 0;
				}
			}
		}
	}

	private void M1458()
	{
		M1307();
		M1457();
	}

	private bool M1459()
	{
		if (size_tab > 0)
		{
			if (currentTabName.Length > 1)
			{
				if (selected == 0)
				{
					return true;
				}
			}
			else if (selected >= 0)
			{
				return true;
			}
		}
		return false;
	}

	private int M1460(int arrLength)
	{
		size_tab = 1;
		if (newSelected > 0)
		{
			newSelected = 0;
		}
		return arrLength + 1;
	}

	private void M1461(int arrLength, bool resetSelect)
	{
		int num = arrLength / 20 + ((arrLength % 20 > 0) ? 1 : 0);
		int num2 = xScroll;
		newSelected = (T51.px - num2) / TAB_W_NEW;
		if (newSelected > num - 1)
		{
			newSelected = num - 1;
		}
		if (T51.px < num2)
		{
			newSelected = 0;
		}
		M1323(resetSelect);
	}
}
