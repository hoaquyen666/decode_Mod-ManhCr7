using System;
using N5.N6.N7;
using UnityEngine;

public class Panel : IActionListener, IChatable
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

	public static Image imgBantay;

	public static Image imgX;

	public static Image imgMap;

	public TabClanIcon tabIcon;

	public MyVector vItemCombine = new MyVector();

	public int moneyGD;

	public int friendMoneyGD;

	public bool isLock;

	public bool isFriendLock;

	public bool isAccept;

	public bool isFriendAccep;

	public string topName;

	public ChatTextField chatTField;

	public static string specialInfo;

	public static short spearcialImage;

	public static Image imgStar;

	public static Image imgMaxStar;

	public static Image imgStar8;

	public static Image imgNew;

	public static Image imgXu;

	public static Image imgTicket;

	public static Image imgLuong;

	public static Image imgLuongKhoa;

	private static Image imgUp;

	private static Image imgDown;

	private int pa1;

	private int pa2;

	private bool trans;

	private int pX;

	private int pY;

	private Command left = new Command(mResources.SELECT, 0);

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

	public Item currItem;

	public Clan currClan;

	public ClanMessage currMess;

	public Member currMem;

	public Clan[] clans;

	public MyVector member;

	public MyVector myMember;

	public MyVector logChat = new MyVector();

	public MyVector vPlayerMenu = new MyVector();

	public MyVector vFriend = new MyVector();

	public MyVector vMyGD = new MyVector();

	public MyVector vFriendGD = new MyVector();

	public MyVector vTop = new MyVector();

	public MyVector vEnemy = new MyVector();

	public MyVector vFlag = new MyVector();

	public Command cmdClose;

	public static bool CanNapTien;

	public static int WIDTH_PANEL;

	private int position;

	public Char charMenu;

	private bool isThachDau;

	public int typeShop = -1;

	public int xScroll;

	public int yScroll;

	public int wScroll;

	public int hScroll;

	public ChatPopup cp;

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

	private Scroll scroll;

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

	public static MyVector vGameInfo;

	public static string[] contenInfo;

	public bool isViewChatServer;

	private int currInfoItem;

	public Char charInfo;

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

	private Image imgo_0;

	private Image imgo_1;

	private Image imgo_2;

	private Image imgo_3;

	public const int numItem = 20;

	public const sbyte INVENTORY_TAB = 1;

	public sbyte size_tab;

	public Panel()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M1241();
		cmdClose = new Command(string.Empty, this, 1003, null);
		cmdClose.img = GameCanvas.M503("/mainImage/myTexture2dbtX.png");
		cmdClose.cmdClosePanel = true;
	}

	static Panel()
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
			(!GameCanvas.isPlaySound) ? mResources.turnOnSound : mResources.turnOffSound,
			mResources.increase_vga,
			mResources.analog,
			(mGraphics.zoomLevel <= 1) ? mResources.x2Screen : mResources.x1Screen
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
		vGameInfo = new MyVector(string.Empty);
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
		imgMap = GameCanvas.M503("/img/map" + TileMap.planetID + ".png");
		imgBantay = GameCanvas.M503("/mainImage/myTexture2dbantay.png");
		imgX = GameCanvas.M503("/mainImage/myTexture2dbtX.png");
		imgXu = GameCanvas.M503("/mainImage/myTexture2dimgMoney.png");
		imgLuong = GameCanvas.M503("/mainImage/myTexture2dimgDiamond.png");
		imgLuongKhoa = GameCanvas.M503("/mainImage/luongkhoa.png");
		imgUp = GameCanvas.M503("/mainImage/myTexture2dup.png");
		imgDown = GameCanvas.M503("/mainImage/myTexture2ddown.png");
		imgStar = GameCanvas.M503("/mainImage/star.png");
		imgMaxStar = GameCanvas.M503("/mainImage/starE.png");
		imgStar8 = GameCanvas.M503("/mainImage/star8.png");
		imgNew = GameCanvas.M503("/mainImage/new.png");
		imgTicket = GameCanvas.M503("/mainImage/ticket12.png");
	}

	public void M1241()
	{
		pX = GameCanvas.pxLast + cmxMap;
		pY = GameCanvas.pyLast + cmyMap;
		lastTabIndex = new int[tabName.Length];
		for (int i = 0; i < lastTabIndex.Length; i++)
		{
			lastTabIndex[i] = -1;
		}
	}

	public int M1242()
	{
		for (int i = 0; i < mapId[TileMap.planetID].Length; i++)
		{
			if (TileMap.mapID == mapId[TileMap.planetID][i])
			{
				return mapX[TileMap.planetID][i];
			}
		}
		return -1;
	}

	public int M1243()
	{
		for (int i = 0; i < mapId[TileMap.planetID].Length; i++)
		{
			if (TileMap.mapID == mapId[TileMap.planetID][i])
			{
				return mapY[TileMap.planetID][i];
			}
		}
		return -1;
	}

	public int M1244()
	{
		if (Char.M113().taskMaint == null)
		{
			return -1;
		}
		for (int i = 0; i < mapId[TileMap.planetID].Length; i++)
		{
			if (GameScr.mapTasks[Char.M113().taskMaint.index] == mapId[TileMap.planetID][i])
			{
				return mapX[TileMap.planetID][i];
			}
		}
		return -1;
	}

	public int M1245()
	{
		if (Char.M113().taskMaint == null)
		{
			return -1;
		}
		for (int i = 0; i < mapId[TileMap.planetID].Length; i++)
		{
			if (GameScr.mapTasks[Char.M113().taskMaint.index] == mapId[TileMap.planetID][i])
			{
				return mapY[TileMap.planetID][i];
			}
		}
		return -1;
	}

	private void M1246(int position)
	{
		typeShop = -1;
		W = WIDTH_PANEL;
		H = GameCanvas.h;
		X = 0;
		Y = 0;
		ITEM_HEIGHT = 24;
		this.position = position;
		switch (position)
		{
		case 1:
			wScroll = W - 4;
			xScroll = GameCanvas.w - wScroll;
			yScroll = 80;
			hScroll = H - 96;
			X = xScroll - 2;
			cmx = -(GameCanvas.w + W);
			cmtoX = GameCanvas.w - W;
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
			lastSelect[i] = (GameCanvas.isTouch ? (-1) : 0);
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
		if (!GameScr.M559().M536() && isPaintMap)
		{
			if (Hint.M692(2, 0))
			{
				Hint.isViewMap = true;
				GameScr.info1.M762(mResources.go_to_quest, 0);
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
		currentListLength = Char.M113().arrArchive.Length;
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
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
		currentListLength = Char.M113().arrItemShop[4].Length;
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
	}

	public void M1253()
	{
		type = 7;
		M1246(1);
		M1323(resetSelect: true);
		currentTabIndex = 0;
	}

	public void M1254(InfoItem info)
	{
		logChat.M1121(info, 0);
		if (logChat.M1113() > 20)
		{
			logChat.M1118(logChat.M1113() - 1);
		}
	}

	public void M1255(Command pm)
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
	}

	public void M1257()
	{
		type = 18;
		M1246(0);
		ITEM_HEIGHT = 24;
		selected = (GameCanvas.isTouch ? (-1) : 0);
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

	public void M1259(Char c)
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
		M1264();
	}

	public void M1261()
	{
		type = 16;
		M1246(0);
		ITEM_HEIGHT = 24;
		selected = (GameCanvas.isTouch ? (-1) : 0);
		M1265();
	}

	public void M1262(sbyte t)
	{
		type = 15;
		M1246(0);
		ITEM_HEIGHT = 24;
		selected = (GameCanvas.isTouch ? (-1) : 0);
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
		if (GameCanvas.w > 2 * WIDTH_PANEL)
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
		if (GameCanvas.w > 2 * WIDTH_PANEL)
		{
			GameCanvas.panel2 = new Panel();
			GameCanvas.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
			GameCanvas.panel2.M1253();
			GameCanvas.panel2.M1285();
		}
	}

	public void M1270()
	{
		type = 12;
		if (GameCanvas.w > 2 * WIDTH_PANEL)
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
		if (GameCanvas.w > 2 * WIDTH_PANEL)
		{
			GameCanvas.panel2 = new Panel();
			GameCanvas.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
			GameCanvas.panel2.M1253();
			GameCanvas.panel2.M1285();
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
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
		if (GameCanvas.panel2 != null)
		{
			boxPet = mResources.petMainTab2;
		}
		else
		{
			boxPet = mResources.petMainTab;
		}
		tabName[21] = boxPet;
		if (Char.M113().cgender == 1)
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

	public void M1277(Item item)
	{
		cp = new ChatPopup();
		string empty = string.Empty;
		string text = string.Empty;
		if (item.template.gender != Char.M113().cgender)
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
						Res.M1513("STAR SLOT= " + cp.starSlot);
					}
					else if (item.itemOption[k].optionTemplate.id == 107)
					{
						cp.maxStarSlot = (sbyte)item.itemOption[k].param;
						Res.M1513("STAR SLOT= " + cp.maxStarSlot);
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
			if (currItem.template.strRequire > Char.M113().cPower)
			{
				string text4 = text + "\n|3|1|" + text3;
				text = text4 + "\n|3|1|" + mResources.your_pow + ": " + Char.M113().cPower;
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

	public void M1278(ChatPopup cp, string chat)
	{
		cp.isClip = false;
		cp.sayWidth = 180;
		cp.cx = 3 + X - ((X != 0) ? (Res.M1529(cp.sayWidth - W) + 8) : 0);
		cp.says = mFont.tahoma_7_red.M907(chat, cp.sayWidth - 10);
		cp.delay = 10000000;
		cp.c = null;
		cp.sayRun = 7;
		cp.ch = 15 - cp.sayRun + cp.says.Length * 12 + 10;
		if (cp.ch > GameCanvas.h - 80)
		{
			cp.ch = GameCanvas.h - 80;
			cp.lim = cp.says.Length * 12 - cp.ch + 17;
			if (cp.lim < 0)
			{
				cp.lim = 0;
			}
			ChatPopup.cmyText = 0;
			cp.isClip = true;
		}
		cp.cy = GameCanvas.menu.menuY - cp.ch;
		while (cp.cy < 10)
		{
			cp.cy++;
			GameCanvas.menu.menuY++;
		}
		cp.mH = 0;
		cp.strY = 10;
	}

	public void M1279(ChatPopup cp, string[] chat)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		cp.sayWidth = 160;
		cp.cx = 3 + X;
		cp.says = chat;
		cp.delay = 10000000;
		cp.c = null;
		cp.sayRun = 7;
		cp.ch = 15 - cp.sayRun + cp.says.Length * 12 + 10;
		cp.cy = GameCanvas.menu.menuY - cp.ch;
		cp.mH = 0;
		cp.strY = 10;
	}

	public void M1280(ClanMessage cm)
	{
		cp = new ChatPopup();
		string text = string.Concat("|0|" + cm.playerName, "\n|1|", Member.M873(cm.role));
		for (int i = 0; i < myMember.M1113(); i++)
		{
			Member t = (Member)myMember.M1114(i);
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

	public void M1281(TopInfo t)
	{
		string chat = string.Concat(string.Concat(string.Concat("|0|1|" + t.name, "\n|1|Top ", t.rank), "\n|1|", t.info), "\n|2|", t.info2);
		cp = new ChatPopup();
		M1278(cp, chat);
		partID = new int[3] { t.headID, t.leg, t.body };
		currItem = null;
		charInfo = null;
	}

	public void M1282(Member m)
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
		string text3 = text + text2 + Member.M873(m.role);
		text3 = string.Concat(text3 + "\n|2|1|" + mResources.power + ": " + m.powerPoint, "\n--");
		text3 = text3 + "\n|5|" + mResources.clan_capsuledonate + ": " + m.clanPoint;
		text3 = text3 + "\n|5|" + mResources.clan_capsuleself + ": " + m.curClanPoint;
		text3 = text3 + "\n|4|" + mResources.give_pea + ": " + m.donate + mResources.time;
		text3 = text3 + "\n|4|" + mResources.receive_pea + ": " + m.receive_donate + mResources.time;
		text = text3 + "\n|6|" + mResources.join_date + ": " + m.joinTime;
		cp = new ChatPopup();
		M1278(cp, text);
		partID = new int[3] { m.head, m.leg, m.body };
		currItem = null;
		charInfo = null;
	}

	public void M1283(Clan cl)
	{
		string text = "|0|" + cl.name;
		string[] array = mFont.tahoma_7_green.M907(cl.slogan, wScroll - 60);
		for (int i = 0; i < array.Length; i++)
		{
			text = text + "\n|2|" + array[i];
		}
		string text2 = text + "\n--";
		text2 = text2 + "\n|7|" + mResources.clan_leader + ": " + cl.leaderName;
		text2 = text2 + "\n|1|" + mResources.power_point + ": " + cl.powerPoint;
		text2 = text2 + "\n|4|" + mResources.member + ": " + cl.currMember + "/" + cl.maxMember;
		text2 = text2 + "\n|4|" + mResources.level + ": " + cl.level;
		text = text2 + "\n|4|" + mResources.clan_birthday + ": " + NinjaUtil.M1189(cl.date);
		cp = new ChatPopup();
		M1278(cp, text);
		idIcon = ClanImage.M288((sbyte)cl.imgID).idImage[0];
		currItem = null;
	}

	public void M1284(SkillTemplate tp, Skill skill, Skill nextSkill)
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
			text2 = string.Concat(text2 + "\n|2|" + mResources.cap_do + ": " + skill.point, "\n|5|", NinjaUtil.M1187(tp.damInfo, "#", skill.damage + string.Empty));
			text2 = text2 + "\n|5|" + mResources.KI_consume + skill.manaUse + ((tp.manaUseType != 1) ? string.Empty : "%");
			text = string.Concat(text2 + "\n|5|" + mResources.speed + ": " + skill.coolDown + mResources.milisecond, "\n--");
			if (skill.point == tp.maxPoint)
			{
				text = text + "\n|0|" + mResources.max_level_reach;
			}
			else
			{
				text2 = text;
				text = string.Concat(text2 + "\n|1|" + mResources.next_level_require + Res.M1532(nextSkill.powRequire) + " " + mResources.potential, "\n|4|", NinjaUtil.M1187(tp.damInfo, "#", nextSkill.damage + string.Empty));
			}
		}
		else
		{
			string text3 = text + "\n|2|" + mResources.not_learn;
			text3 = string.Concat(text3 + "\n|1|" + mResources.learn_require + Res.M1532(nextSkill.powRequire) + " " + mResources.potential, "\n|4|", NinjaUtil.M1187(tp.damInfo, "#", nextSkill.damage + string.Empty));
			text3 = text3 + "\n|4|" + mResources.KI_consume + nextSkill.manaUse + ((tp.manaUseType != 1) ? string.Empty : "%");
			text = text3 + "\n|4|" + mResources.speed + ": " + nextSkill.coolDown + mResources.milisecond;
		}
		currItem = null;
		partID = null;
		charInfo = null;
		cp = new ChatPopup();
		M1278(cp, text);
		idIcon = 0;
	}

	public void M1285()
	{
		if (GameCanvas.isTouch)
		{
			cmdClose.x = 156;
			cmdClose.y = 3;
		}
		else
		{
			cmdClose.x = GameCanvas.w - 19;
			cmdClose.y = GameCanvas.h - 19;
		}
		cmdClose.isPlaySoundButton = false;
		ChatPopup.currChatPopup = null;
		InfoDlg.M753();
		timeShow = 20;
		isShow = true;
		isClose = false;
		SoundMn.M1826().M1855();
		if (M1443())
		{
			Char.M113().M242();
		}
	}

	public void M1286()
	{
		if (chatTField != null && chatTField.isShow)
		{
			if (chatTField.left != null && (GameCanvas.keyPressed[12] || mScreen.M1034(chatTField.left)) && chatTField.left != null)
			{
				chatTField.left.M294();
			}
			if (chatTField.right != null && (GameCanvas.keyPressed[13] || mScreen.M1034(chatTField.right)) && chatTField.right != null)
			{
				chatTField.right.M294();
			}
			if (chatTField.center != null && (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] || mScreen.M1034(chatTField.center)) && chatTField.center != null)
			{
				chatTField.center.M294();
			}
			if (chatTField.isShow && GameCanvas.keyAsciiPress != 0)
			{
				chatTField.M278(GameCanvas.keyAsciiPress);
				GameCanvas.keyAsciiPress = 0;
			}
			GameCanvas.M484();
			GameCanvas.M483();
		}
	}

	public void M1287()
	{
		if ((chatTField != null && chatTField.isShow) || !GameCanvas.panel.isDoneCombine || InfoDlg.isShow)
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
			if (GameCanvas.keyPressed[13])
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
			if (GameCanvas.keyPressed[12] || GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25])
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
			if (Equals(GameCanvas.panel) && GameCanvas.panel2 == null && GameCanvas.isPointerJustRelease && !GameCanvas.M516(X, Y, W, H) && !pointerIsDowning)
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
					GameCanvas.M483();
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
				GameCanvas.M483();
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
				if (currentTabIndex < currentTabName.Length - ((GameCanvas.panel2 == null) ? 1 : 0) && type != 17)
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
			GameCanvas.M484();
			for (int i = 0; i < GameCanvas.keyPressed.Length; i++)
			{
				GameCanvas.keyPressed[i] = false;
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
			if (Equals(GameCanvas.panel))
			{
				M1458();
			}
			if (Equals(GameCanvas.panel2))
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
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

	public void M1297(Char cGD)
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
		if (GameCanvas.w > 2 * WIDTH_PANEL)
		{
			GameCanvas.panel2 = new Panel();
			GameCanvas.panel2.type = 13;
			GameCanvas.panel2.tabName[type] = new string[1][] { mResources.item_receive };
			GameCanvas.panel2.M1246(1);
			GameCanvas.panel2.M1296(isMe: false);
			GameCanvas.panel.tabName[type] = new string[2][]
			{
				mResources.inventory,
				mResources.item_give
			};
			GameCanvas.panel2.M1285();
			GameCanvas.panel2.charMenu = cGD;
		}
		if (Equals(GameCanvas.panel))
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

	private void M1298(mGraphics g, bool isMe)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		MyVector t = ((!isMe) ? vFriendGD : vMyGD);
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
									mFont.tahoma_7_grey.M898(g, mResources.opponent + mResources.not_lock_trade, xScroll + wScroll / 2, num3 + num5 / 2 - 4, mFont.CENTER);
								}
								else
								{
									mFont.tahoma_7_grey.M898(g, mResources.opponent + mResources.locked_trade, xScroll + wScroll / 2, num3 + num5 / 2 - 4, mFont.CENTER);
								}
							}
							else if (isFriendLock)
							{
								g.M933(15196114);
								g.M932(num6, num3, wScroll, num5);
								g.M948((num != selected) ? GameScr.imgLbtn2 : GameScr.imgLbtnFocus2, xScroll + wScroll - 5, num3 + 2, StaticObj.TOP_RIGHT);
								((num != selected) ? mFont.tahoma_7b_dark : mFont.tahoma_7b_green2).M898(g, mResources.done, xScroll + wScroll - 22, num3 + 7, 2);
								mFont.tahoma_7_grey.M898(g, mResources.opponent + mResources.locked_trade, xScroll + 5, num3 + num5 / 2 - 4, mFont.LEFT);
							}
							else
							{
								mFont.tahoma_7_grey.M898(g, mResources.opponent + mResources.not_lock_trade, xScroll + wScroll / 2, num3 + num5 / 2 - 4, mFont.CENTER);
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
									g.M948((num != selected) ? GameScr.imgLbtn2 : GameScr.imgLbtnFocus2, xScroll + wScroll - 5, num3 + 2, StaticObj.TOP_RIGHT);
									((num != selected) ? mFont.tahoma_7b_dark : mFont.tahoma_7b_green2).M898(g, mResources.mlock, xScroll + wScroll - 22, num3 + 7, 2);
									mFont.tahoma_7_grey.M898(g, mResources.you + mResources.not_lock_trade, xScroll + 5, num3 + num5 / 2 - 4, mFont.LEFT);
								}
								else
								{
									g.M948((num != selected) ? GameScr.imgLbtn2 : GameScr.imgLbtnFocus2, xScroll + wScroll - 5, num3 + 2, StaticObj.TOP_RIGHT);
									((num != selected) ? mFont.tahoma_7b_dark : mFont.tahoma_7b_green2).M898(g, mResources.CANCEL, xScroll + wScroll - 22, num3 + 7, 2);
									mFont.tahoma_7_grey.M898(g, mResources.you + mResources.locked_trade, xScroll + 5, num3 + num5 / 2 - 4, mFont.LEFT);
								}
							}
						}
						else if (!isFriendLock)
						{
							mFont.tahoma_7b_dark.M898(g, mResources.not_lock_trade_upper, xScroll + wScroll / 2, num3 + num5 / 2 - 4, mFont.CENTER);
						}
						else
						{
							mFont.tahoma_7b_dark.M898(g, mResources.locked_trade_upper, xScroll + wScroll / 2, num3 + num5 / 2 - 4, mFont.CENTER);
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
						mFont.tahoma_7_green2.M898(g, NinjaUtil.M1192((!isMe) ? friendMoneyGD : moneyGD) + " " + mResources.XU, num2 + 5, num3 + 11, 0);
						mFont.tahoma_7_green.M898(g, mResources.money_trade, num2 + 5, num3, 0);
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
						Item t2 = (Item)t.M1114(num);
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
							mFont t3 = mFont.tahoma_7_green2;
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
								mFont t4 = mFont.tahoma_7_blue;
								if (t2.compare < 0 && t2.template.type != 5)
								{
									t4 = mFont.tahoma_7_red;
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
								t4.M898(g, text2, num2 + 5, num3 + 11, mFont.LEFT);
							}
							SmallImage.M1785(g, t2.template.iconID, num6 + num8 / 2, num7 + num9 / 2, 0, 3);
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
								mFont.tahoma_7_yellow.M898(g, string.Empty + t2.quantity, num6 + num8, num7 + num9 - mFont.tahoma_7_yellow.M912(), 1);
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
		if (GameCanvas.keyHold[(!Main.isPC) ? 2 : 21])
		{
			yMove -= 5;
			cmyMap = yMove - (yScroll + hScroll / 2);
			if (yMove < yScroll)
			{
				yMove = yScroll;
			}
		}
		if (GameCanvas.keyHold[(!Main.isPC) ? 8 : 22])
		{
			yMove += 5;
			cmyMap = yMove - (yScroll + hScroll / 2);
			if (yMove > yScroll + 200)
			{
				yMove = yScroll + 200;
			}
		}
		if (GameCanvas.keyHold[(!Main.isPC) ? 4 : 23])
		{
			xMove -= 5;
			cmxMap = xMove - wScroll / 2;
			if (xMove < 16)
			{
				xMove = 16;
			}
		}
		if (GameCanvas.keyHold[(!Main.isPC) ? 6 : 24])
		{
			xMove += 5;
			cmxMap = xMove - wScroll / 2;
			if (xMove > 250)
			{
				xMove = 250;
			}
		}
		if (GameCanvas.isPointerDown)
		{
			pointerIsDowning = true;
			if (!trans)
			{
				pa1 = cmxMap;
				pa2 = cmyMap;
				trans = true;
			}
			cmxMap = pa1 + (GameCanvas.pxLast - GameCanvas.px);
			cmyMap = pa2 + (GameCanvas.pyLast - GameCanvas.py);
		}
		if (GameCanvas.isPointerJustRelease)
		{
			trans = false;
			GameCanvas.pxLast = GameCanvas.px;
			GameCanvas.pyLast = GameCanvas.py;
			pX = GameCanvas.pxLast + cmxMap;
			pY = GameCanvas.pyLast + cmyMap;
		}
		if (GameCanvas.isPointerClick)
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
			if (selected == vItemCombine.M1113() && GameCanvas.isPointerClick)
			{
				GameCanvas.isPointerClick = false;
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
		if (GameCanvas.keyHold[(!Main.isPC) ? 2 : 21])
		{
			cmyQuest -= 5;
		}
		if (GameCanvas.keyHold[(!Main.isPC) ? 8 : 22])
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
			if (!GameCanvas.isTouch)
			{
				scroll.cmy = cmyQuest;
			}
			scroll.M1561();
		}
		int num2 = xScroll + wScroll / 2 - 35;
		int num3 = ((GameCanvas.h <= 300) ? 15 : 20);
		int num4 = yScroll + hScroll - num3 - 15;
		int px = GameCanvas.px;
		int py = GameCanvas.py;
		keyTouchMapButton = -1;
		if (isPaintMap && !GameScr.M559().M535() && px >= num2 && px <= num2 + 70 && py >= num4 && py <= num4 + 30 && (scroll == null || !scroll.pointerIsDowning))
		{
			keyTouchMapButton = 1;
			if (GameCanvas.isPointerJustRelease)
			{
				SoundMn.M1826().M1857();
				waitToPerform = 2;
				GameCanvas.M517();
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
		if (GameCanvas.keyPressed[(!Main.isPC) ? 4 : 23])
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
		else if (GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24])
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
			cSelected = (GameCanvas.px - num) / TAB_W;
		}
		else
		{
			currMess = M1345();
			if (currMess != null && currMess.option != null)
			{
				num = xScroll + wScroll - 2 - currMess.option.Length * 40;
				cSelected = (GameCanvas.px - num) / 40;
			}
		}
		if (GameCanvas.px < num)
		{
			cSelected = -1;
		}
	}

	public void M1306(int a)
	{
		bool flag = false;
		if (GameCanvas.pxMouse > wScroll)
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
		if (GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21])
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
				if (Equals(GameCanvas.panel) && typeShop == 2 && currentTabIndex <= 3 && maxPageShop[currentTabIndex] > 1)
				{
					InfoDlg.M749();
					if (currPageShop[currentTabIndex] <= 0)
					{
						Service.M1594().M1725(4, -1, (sbyte)currentTabIndex, maxPageShop[currentTabIndex] - 1, -1);
					}
					else
					{
						Service.M1594().M1725(4, -1, (sbyte)currentTabIndex, currPageShop[currentTabIndex] - 1, -1);
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
		else if (GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22])
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
				if (Equals(GameCanvas.panel) && typeShop == 2 && currentTabIndex <= 3 && maxPageShop[currentTabIndex] > 1)
				{
					InfoDlg.M749();
					if (currPageShop[currentTabIndex] >= maxPageShop[currentTabIndex] - 1)
					{
						Service.M1594().M1725(4, -1, (sbyte)currentTabIndex, 0, -1);
					}
					else
					{
						Service.M1594().M1725(4, -1, (sbyte)currentTabIndex, currPageShop[currentTabIndex] + 1, -1);
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
		if (GameCanvas.isPointerDown)
		{
			justRelease = false;
			if (!pointerIsDowning && GameCanvas.M516(xScroll, yScroll, wScroll, hScroll))
			{
				for (int i = 0; i < pointerDownLastX.Length; i++)
				{
					pointerDownLastX[0] = GameCanvas.py;
				}
				pointerDownFirstX = GameCanvas.py;
				pointerIsDowning = true;
				isDownWhenRunning = cmRun != 0;
				cmRun = 0;
			}
			else if (pointerIsDowning)
			{
				pointerDownTime++;
				if (pointerDownTime > 5 && pointerDownFirstX == GameCanvas.py && !isDownWhenRunning)
				{
					pointerDownFirstX = -1000;
					selected = (cmtoY + GameCanvas.py - yScroll) / ITEM_HEIGHT;
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
				int num = GameCanvas.py - pointerDownLastX[0];
				if (num != 0 && selected != -1)
				{
					selected = -1;
					cSelected = -1;
				}
				for (int num2 = pointerDownLastX.Length - 1; num2 > 0; num2--)
				{
					pointerDownLastX[num2] = pointerDownLastX[num2 - 1];
				}
				pointerDownLastX[0] = GameCanvas.py;
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
				if (cmy < -(GameCanvas.h / 3))
				{
					wantUpdateList = true;
				}
				else
				{
					wantUpdateList = false;
				}
			}
		}
		if (!GameCanvas.isPointerJustRelease || !pointerIsDowning)
		{
			return;
		}
		justRelease = true;
		int i2 = GameCanvas.py - pointerDownLastX[0];
		GameCanvas.isPointerJustRelease = false;
		if (Res.M1529(i2) < 20 && Res.M1529(GameCanvas.py - pointerDownFirstX) < 20 && !isDownWhenRunning)
		{
			cmRun = 0;
			cmtoY = cmy;
			pointerDownFirstX = -1000;
			selected = (cmtoY + GameCanvas.py - yScroll) / ITEM_HEIGHT;
			if (selected >= currentListLength)
			{
				selected = -1;
			}
			M1305();
			pointerDownTime = 0;
			waitToPerform = 10;
			SoundMn.M1826().M1862();
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
				int num3 = GameCanvas.py - pointerDownLastX[0] + (pointerDownLastX[0] - pointerDownLastX[1]) + (pointerDownLastX[1] - pointerDownLastX[2]);
				cmRun = -((num3 > 10) ? 10 : ((num3 < -10) ? (-10) : 0)) * 100;
			}
		}
		pointerIsDowning = false;
		pointerDownTime = 0;
		GameCanvas.isPointerJustRelease = false;
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
			if (GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24])
			{
				currentTabIndex++;
				if (currentTabIndex >= currentTabName.Length)
				{
					if (GameCanvas.panel2 != null)
					{
						currentTabIndex = currentTabName.Length - 1;
						GameCanvas.isFocusPanel2 = true;
					}
					else
					{
						currentTabIndex = 0;
					}
				}
				selected = lastSelect[currentTabIndex];
				lastTabIndex[type] = currentTabIndex;
			}
			if (GameCanvas.keyPressed[(!Main.isPC) ? 4 : 23])
			{
				currentTabIndex--;
				if (currentTabIndex < 0)
				{
					currentTabIndex = currentTabName.Length - 1;
				}
				if (GameCanvas.isFocusPanel2)
				{
					GameCanvas.isFocusPanel2 = false;
				}
				selected = lastSelect[currentTabIndex];
				lastTabIndex[type] = currentTabIndex;
			}
		}
		keyTouchTab = -1;
		for (int i = 0; i < currentTabName.Length; i++)
		{
			if (!GameCanvas.M516(startTabPos + i * TAB_W, 52, TAB_W - 1, 25))
			{
				continue;
			}
			keyTouchTab = i;
			if (GameCanvas.isPointerJustRelease)
			{
				currentTabIndex = i;
				lastTabIndex[type] = i;
				GameCanvas.isPointerJustRelease = false;
				selected = lastSelect[currentTabIndex];
				if (num == currentTabIndex && cmRun == 0)
				{
					cmtoY = 0;
					selected = (GameCanvas.isTouch ? (-1) : 0);
				}
				break;
			}
		}
		if (num == currentTabIndex)
		{
			return;
		}
		size_tab = 0;
		SoundMn.M1826().M1862();
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
				if (Equals(GameCanvas.panel))
				{
					M1323(resetSelect: true);
				}
				else if (Equals(GameCanvas.panel2))
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
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
		SoundMn.M1826().M1828();
		currentListLength = strTool.Length;
		ITEM_HEIGHT = 24;
		selected = (GameCanvas.isTouch ? (-1) : 0);
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
			clanInfo = mResources.member + " " + ((currClan == null) ? Char.M113().clan.name : currClan.name);
		}
		else if (isMessage)
		{
			currentListLength = ClanMessage.vMessage.M1113() + 2;
			clanInfo = mResources.msg;
			clanReport = string.Empty;
		}
		if (Char.M113().clan == null)
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
		else if (Char.M113().role > 0)
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
		GameScr.isNewClanMessage = false;
		ITEM_HEIGHT = 24;
		if (lastSelect != null && lastSelect[3] == 0)
		{
			lastSelect[3] = -1;
		}
		currentListLength = 2;
		if (Char.M113().clan != null)
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
		if (Char.M113().clan != null)
		{
			currentListLength = ClanMessage.vMessage.M1113() + 2;
		}
		M1313();
		cSelected = -1;
		if (chatTField == null)
		{
			chatTField = new ChatTextField();
			chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
			chatTField.M276();
			chatTField.parentScreen = GameCanvas.panel;
		}
		if (Char.M113().clan == null)
		{
			clanReport = mResources.findingClan;
			Service.M1594().M1618(string.Empty);
		}
		selected = lastSelect[currentTabIndex];
		if (GameCanvas.isTouch)
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
	}

	public void M1317()
	{
		ITEM_HEIGHT = 24;
		if (currentTabIndex == currentTabName.Length - 1 && GameCanvas.panel2 == null && typeShop != 2)
		{
			currentListLength = M1460(Char.M113().arrItemBody.Length + Char.M113().arrItemBag.Length);
		}
		else
		{
			currentListLength = Char.M113().arrItemShop[currentTabIndex].Length;
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
	}

	private void M1318()
	{
		ITEM_HEIGHT = 30;
		currentListLength = Char.M113().nClass.skillTemplates.Length + 6;
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
	}

	private void M1319()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		ITEM_HEIGHT = 24;
		currentListLength = mapNames.Length;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		cmtoY = 0;
		cmy = 0;
		selected = (GameCanvas.isTouch ? (-1) : 0);
	}

	private void M1320()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		ITEM_HEIGHT = 24;
		currentListLength = GameScr.M559().zones.Length;
		cmyLim = currentListLength * ITEM_HEIGHT - hScroll;
		cmtoY = 0;
		cmy = 0;
		selected = (GameCanvas.isTouch ? (-1) : 0);
	}

	private void M1321()
	{
		currentListLength = M1460(Char.M113().arrItemBox.Length);
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
	}

	private void M1322()
	{
		ITEM_HEIGHT = 24;
		Item[] arrItemBody = Char.M114().arrItemBody;
		Skill[] arrPetSkill = Char.M114().arrPetSkill;
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
	}

	private void M1323(bool resetSelect)
	{
		currentListLength = Char.M113().arrItemBody.Length + Char.M113().arrItemBag.Length;
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
			selected = (GameCanvas.isTouch ? (-1) : 0);
		}
	}

	private void M1324()
	{
		if (!isPaintMap)
		{
			return;
		}
		if (TileMap.lastPlanetId != TileMap.planetID)
		{
			Res.M1513("LOAD TAM HINH");
			imgMap = GameCanvas.M502("/img/map" + TileMap.planetID + ".png");
			TileMap.lastPlanetId = TileMap.planetID;
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
		for (int i = 0; i < mapId[TileMap.planetID].Length; i++)
		{
			if (TileMap.mapID == mapId[TileMap.planetID][i])
			{
				xMove = mapX[TileMap.planetID][i] + xScroll;
				yMove = mapY[TileMap.planetID][i] + yScroll + 5;
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
		if (justRelease && Equals(GameCanvas.panel) && typeShop == 2 && maxPageShop[currentTabIndex] > 1)
		{
			if (cmy < -50)
			{
				InfoDlg.M749();
				justRelease = false;
				if (currPageShop[currentTabIndex] <= 0)
				{
					Service.M1594().M1725(4, -1, (sbyte)currentTabIndex, maxPageShop[currentTabIndex] - 1, -1);
				}
				else
				{
					Service.M1594().M1725(4, -1, (sbyte)currentTabIndex, currPageShop[currentTabIndex] - 1, -1);
				}
			}
			else if (cmy > cmyLim + 50)
			{
				justRelease = false;
				InfoDlg.M749();
				if (currPageShop[currentTabIndex] >= maxPageShop[currentTabIndex] - 1)
				{
					Service.M1594().M1725(4, -1, (sbyte)currentTabIndex, 0, -1);
				}
				else
				{
					Service.M1594().M1725(4, -1, (sbyte)currentTabIndex, currPageShop[currentTabIndex] + 1, -1);
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
		if (Math.M869(cmtoX - cmx) < 10)
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
				if (Char.M113().cHP > 0 && Char.M113().statusMe != 14)
				{
					InfoDlg.M749();
					if (type == 3)
					{
						Service.M1594().M1638(selected, -1);
					}
					else if (type == 14)
					{
						Service.M1594().M1721(selected);
					}
				}
			}
			if (isSelectPlayerMenu)
			{
				isSelectPlayerMenu = false;
				((Command)vPlayerMenu.M1114(selected)).M294();
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

	public void M1327(mGraphics g)
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
			Part t = GameScr.parts[partID[0]];
			Part t2 = GameScr.parts[partID[1]];
			Part t3 = GameScr.parts[partID[2]];
			SmallImage.M1785(g, t.pi[Char.CharInfo[0][0][0]].id, num + Char.CharInfo[0][0][1] + t.pi[Char.CharInfo[0][0][0]].dx, num2 - Char.CharInfo[0][0][2] + t.pi[Char.CharInfo[0][0][0]].dy, 0, 0);
			SmallImage.M1785(g, t2.pi[Char.CharInfo[0][1][0]].id, num + Char.CharInfo[0][1][1] + t2.pi[Char.CharInfo[0][1][0]].dx, num2 - Char.CharInfo[0][1][2] + t2.pi[Char.CharInfo[0][1][0]].dy, 0, 0);
			SmallImage.M1785(g, t3.pi[Char.CharInfo[0][2][0]].id, num + Char.CharInfo[0][2][1] + t3.pi[Char.CharInfo[0][2][0]].dx, num2 - Char.CharInfo[0][2][2] + t3.pi[Char.CharInfo[0][2][0]].dy, 0, 0);
		}
		else if (charInfo != null)
		{
			charInfo.M199(g, num + 5, num2 + 25, 1, 0, isPaintBag: true);
		}
		else if (idIcon != -1)
		{
			SmallImage.M1785(g, idIcon, num, num2, 0, 3);
		}
		if (currItem != null && currItem.template.type != 5)
		{
			if (currItem.compare > 0)
			{
				g.M948(imgUp, num - 7, num2 + 13, 3);
				mFont.tahoma_7b_green.M898(g, Res.M1529(currItem.compare) + string.Empty, num + 1, num2 + 8, 0);
			}
			else if (currItem.compare < 0 && currItem.compare != -1)
			{
				g.M948(imgDown, num - 7, num2 + 13, 3);
				mFont.tahoma_7b_red.M898(g, Res.M1529(currItem.compare) + string.Empty, num + 1, num2 + 8, 0);
			}
		}
	}

	public void M1328(mGraphics g)
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
			TopInfo t = (TopInfo)vTop.M1114(i);
			if (t.headICON != -1)
			{
				SmallImage.M1785(g, t.headICON, num3, num4, 0, 0);
			}
			else
			{
				Part t2 = GameScr.parts[t.headID];
				SmallImage.M1785(g, t2.pi[Char.CharInfo[0][0][0]].id, num3 + t2.pi[Char.CharInfo[0][0][0]].dx, num4 + num9 - 1, 0, mGraphics.BOTTOM | mGraphics.LEFT);
			}
			g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
			if (t.pId != Char.M113().charID)
			{
				mFont.tahoma_7b_green.M898(g, t.name, num6 + 5, num7, 0);
			}
			else
			{
				mFont.tahoma_7b_red.M898(g, t.name, num6 + 5, num7, 0);
			}
			mFont.tahoma_7_blue.M898(g, t.info, num6 + num8 - 5, num7 + 11, 1);
			mFont.tahoma_7_green2.M898(g, mResources.rank + ": " + t.rank + string.Empty, num6 + 5, num7 + 11, 0);
		}
		M1335(g);
	}

	public void M1329(mGraphics g)
	{
		g.M918(-g.M920(), -g.M921() + mGraphics.addYWhenOpenKeyBoard);
		g.M918(-cmx, 0);
		g.M918(X, Y);
		if (GameCanvas.panel.combineSuccess != -1)
		{
			if (Equals(GameCanvas.panel))
			{
				M1428(g);
			}
			return;
		}
		GameCanvas.paintz.M1236(X, Y, W, H, g);
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
				if (Equals(GameCanvas.panel))
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
		GameScr.M631(g);
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

	private void M1330(mGraphics g)
	{
		if (type == 1 && currentTabIndex == currentTabName.Length - 1 && GameCanvas.panel2 == null && typeShop != 2)
		{
			M1355(g);
			return;
		}
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		if (typeShop == 2 && Equals(GameCanvas.panel))
		{
			if (currentTabIndex <= 3 && GameCanvas.isTouch)
			{
				if (cmy < -50)
				{
					GameCanvas.M514(xScroll + wScroll / 2, yScroll + 30, g);
				}
				else if (cmy < 0)
				{
					mFont.tahoma_7_grey.M898(g, mResources.getDown, xScroll + wScroll / 2, yScroll + 15, 2);
				}
				else if (cmyLim >= 0)
				{
					if (cmy > cmyLim + 50)
					{
						GameCanvas.M514(xScroll + wScroll / 2, yScroll + hScroll - 30, g);
					}
					else if (cmy > cmyLim)
					{
						mFont.tahoma_7_grey.M898(g, mResources.getUp, xScroll + wScroll / 2, yScroll + hScroll - 25, 2);
					}
				}
			}
			if (Char.M113().arrItemShop[currentTabIndex].Length == 0 && type != 17)
			{
				mFont.tahoma_7_grey.M898(g, mResources.notYetSell, xScroll + wScroll / 2, yScroll + hScroll / 2 - 10, 2);
				return;
			}
		}
		g.M918(0, -cmy);
		Item[] array = Char.M113().arrItemShop[currentTabIndex];
		if (typeShop == 2 && (currentTabIndex == 4 || type == 17))
		{
			array = Char.M113().arrItemShop[4];
			if (array.Length == 0)
			{
				mFont.tahoma_7_grey.M898(g, mResources.notYetSell, xScroll + wScroll / 2, yScroll + hScroll / 2 - 10, 2);
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
			Item t = array[i];
			if (t != null)
			{
				string text = string.Empty;
				mFont t2 = mFont.tahoma_7_green2;
				if (t.isMe != 0 && typeShop == 2 && currentTabIndex <= 3 && !Equals(GameCanvas.panel2))
				{
					t2 = mFont.tahoma_7b_green;
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
					mFont t3 = mFont.tahoma_7_blue;
					if (t.compare < 0 && t.template.type != 5)
					{
						t3 = mFont.tahoma_7_red;
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
					SmallImage.M1785(g, t.iconSpec, num2 + num4 - 7, num3 + 9, 0, 3);
					mFont.tahoma_7b_blue.M898(g, Res.M1532(t.buySpec), num2 + num4 - 15, num3 + 1, mFont.RIGHT);
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
								mFont.tahoma_7b_yellow.M898(g, Res.M1532(t.buyCoin), num2 + num4 - 15, num3 + 1, mFont.RIGHT);
							}
							if (t.buyGold > 0)
							{
								g.M948(imgLuong, num2 + num4 - 7, num3 + 7 + 11, 3);
								mFont.tahoma_7b_green.M898(g, Res.M1532(t.buyGold), num2 + num4 - 15, num3 + 12, mFont.RIGHT);
							}
						}
						else
						{
							if (t.buyCoin > 0)
							{
								g.M948(imgXu, num2 + num4 - 7, num3 + 7, 3);
								mFont.tahoma_7b_yellow.M898(g, Res.M1532(t.buyCoin), num2 + num4 - 15, num3 + 1, mFont.RIGHT);
							}
							if (t.buyGold > 0)
							{
								g.M948(imgLuong, num2 + num4 - 7, num3 + 7, 3);
								mFont.tahoma_7b_green.M898(g, Res.M1532(t.buyGold), num2 + num4 - 15, num3 + 1, mFont.RIGHT);
							}
						}
					}
					if (typeShop == 2 && currentTabIndex <= 3 && !Equals(GameCanvas.panel2))
					{
						if (t.buyCoin > 0 && t.buyGold > 0)
						{
							if (t.buyCoin > 0)
							{
								g.M948(imgXu, num2 + num4 - 7, num3 + 7, 3);
								mFont.tahoma_7b_yellow.M898(g, Res.M1533(t.buyCoin), num2 + num4 - 15, num3 + 1, mFont.RIGHT);
							}
							if (t.buyGold > 0)
							{
								g.M948(imgLuong, num2 + num4 - 7, num3 + 7 + 11, 3);
								mFont.tahoma_7b_green.M898(g, Res.M1533(t.buyGold), num2 + num4 - 15, num3 + 12, mFont.RIGHT);
							}
						}
						else
						{
							if (t.buyCoin > 0)
							{
								g.M948(imgXu, num2 + num4 - 7, num3 + 7, 3);
								mFont.tahoma_7b_yellow.M898(g, Res.M1533(t.buyCoin), num2 + num4 - 15, num3 + 1, mFont.RIGHT);
							}
							if (t.buyGold > 0)
							{
								g.M948(imgLuong, num2 + num4 - 7, num3 + 7, 3);
								mFont.tahoma_7b_green.M898(g, Res.M1533(t.buyGold), num2 + num4 - 15, num3 + 1, mFont.RIGHT);
							}
						}
					}
				}
				SmallImage.M1785(g, t.template.iconID, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
				if (t.quantity > 1)
				{
					mFont.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num5 + num7, num6 + num8 - mFont.tahoma_7_yellow.M912(), 1);
				}
				if (t.newItem && GameCanvas.gameTick % 10 > 5)
				{
					g.M948(imgNew, num5 + num7 / 2, num3 + 19, 3);
				}
			}
			if (typeShop != 2 || (!Equals(GameCanvas.panel2) && currentTabIndex != 4) || t.buyType == 0)
			{
				continue;
			}
			if (t.buyType == 1)
			{
				mFont.tahoma_7_green.M898(g, mResources.dangban, num2 + num4 - 5, num3 + 1, mFont.RIGHT);
				if (t.buyCoin != -1)
				{
					g.M948(imgXu, num2 + num4 - 7, num3 + 19, 3);
					mFont.tahoma_7b_yellow.M898(g, Res.M1533(t.buyCoin), num2 + num4 - 15, num3 + 13, mFont.RIGHT);
				}
				else if (t.buyGold != -1)
				{
					g.M948(imgLuongKhoa, num2 + num4 - 7, num3 + 17, 3);
					mFont.tahoma_7b_red.M898(g, Res.M1533(t.buyGold), num2 + num4 - 15, num3 + 11, mFont.RIGHT);
				}
			}
			else if (t.buyType == 2)
			{
				mFont.tahoma_7b_blue.M898(g, mResources.daban, num2 + num4 - 5, num3 + 1, mFont.RIGHT);
				if (t.buyCoin != -1)
				{
					g.M948(imgXu, num2 + num4 - 7, num3 + 17, 3);
					mFont.tahoma_7b_yellow.M898(g, Res.M1533(t.buyCoin), num2 + num4 - 15, num3 + 11, mFont.RIGHT);
				}
				else if (t.buyGold != -1)
				{
					g.M948(imgLuongKhoa, num2 + num4 - 7, num3 + 17, 3);
					mFont.tahoma_7b_red.M898(g, Res.M1533(t.buyGold), num2 + num4 - 15, num3 + 11, mFont.RIGHT);
				}
			}
		}
		M1335(g);
	}

	private void M1331(mGraphics g)
	{
	}

	private void M1332(mGraphics g)
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
				mFont.tahoma_7b_dark.M898(g, strStatus[i], xScroll + wScroll / 2, num + 6, mFont.CENTER);
			}
		}
		M1335(g);
	}

	private void M1333()
	{
	}

	private void M1334(mGraphics g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		Item[] arrItemBody = Char.M114().arrItemBody;
		Skill[] arrPetSkill = Char.M114().arrPetSkill;
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
			Item t = ((!flag) ? null : arrItemBody[num]);
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
			if (t != null && t.isSelect && GameCanvas.panel.type == 12)
			{
				g.M933((i != selected) ? 6047789 : 7040779);
				g.M932(num6, num7, num8, num9);
			}
			if (t != null)
			{
				string text = string.Empty;
				mFont t2 = mFont.tahoma_7_green2;
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
					mFont.bigNumber_yellow.M898(g, t.M796() + "s", x, num4 + 1, mFont.RIGHT);
					mFont.tahoma_7_blue.M898(g, t.M797(), x, num4 + 11, mFont.RIGHT);
				}
				string text2 = string.Empty;
				if (t.itemOption != null)
				{
					if (t.itemOption.Length != 0 && t.itemOption[0] != null && t.itemOption[0].optionTemplate.id != 102 && t.itemOption[0].optionTemplate.id != 107)
					{
						text2 += t.itemOption[0].M830();
					}
					mFont t3 = mFont.tahoma_7_blue;
					if (t.compare < 0 && t.template.type != 5)
					{
						t3 = mFont.tahoma_7_red;
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
					t3.M898(g, text2, num3 + 5, num4 + 11, mFont.LEFT);
				}
				SmallImage.M1785(g, t.template.iconID, num6 + num8 / 2, num7 + num9 / 2, 0, 3);
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
					mFont.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num6 + num8, num7 + num9 - mFont.tahoma_7_yellow.M912(), 1);
				}
			}
			else if (!flag)
			{
				Skill t4 = arrPetSkill[num2];
				if (t4.template != null)
				{
					mFont.tahoma_7_blue.M898(g, t4.template.name, num3 + 5, num4 + 1, 0);
					mFont.tahoma_7_green2.M898(g, mResources.level + ": " + t4.point + string.Empty, num3 + 5, num4 + 11, 0);
					SmallImage.M1785(g, t4.template.iconId, num6 + num8 / 2, num7 + num9 / 2, 0, 3);
				}
				else
				{
					mFont.tahoma_7_green2.M898(g, t4.moreInfo, num3 + 5, num4 + 5, 0);
					SmallImage.M1785(g, GameScr.efs[98].arrEfInfo[0].idImg, num6 + num8 / 2, num7 + num9 / 2, 0, 3);
				}
			}
		}
		M1335(g);
	}

	private void M1335(mGraphics g)
	{
		g.M918(-g.M920(), -g.M921());
		if ((cmy > 24 && currentListLength > 0) || (Equals(GameCanvas.panel) && typeShop == 2 && maxPageShop[currentTabIndex] > 1))
		{
			g.M940(Mob.imgHP, 0, 0, 9, 6, 1, xScroll + wScroll - 12, yScroll + 3, 0);
		}
		if ((cmy < cmyLim && currentListLength > 0) || (Equals(GameCanvas.panel) && typeShop == 2 && maxPageShop[currentTabIndex] > 1))
		{
			g.M940(Mob.imgHP, 0, 0, 9, 6, 0, xScroll + wScroll - 12, yScroll + hScroll - 8, 0);
		}
	}

	private void M1336(mGraphics g)
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
			mFont.tahoma_7b_dark.M898(g, strTool[i], xScroll + wScroll / 2, num2 + 6, mFont.CENTER);
			if (!strTool[i].Equals(mResources.gameInfo))
			{
				continue;
			}
			for (int j = 0; j < vGameInfo.M1113(); j++)
			{
				if (!((GameInfo)vGameInfo.M1114(j)).hasRead)
				{
					if (GameCanvas.gameTick % 20 > 10)
					{
						g.M948(imgNew, num + 10, num2 + 10, 3);
					}
					break;
				}
			}
		}
		M1335(g);
	}

	private void M1337(mGraphics g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < contenInfo.Length; i++)
		{
			int num = yScroll + i * 15;
			if (num - cmy <= yScroll + hScroll && num - cmy >= yScroll - ITEM_HEIGHT)
			{
				mFont.tahoma_7b_dark.M898(g, contenInfo[i], xScroll + 5, num + 6, mFont.LEFT);
			}
		}
		M1335(g);
	}

	private void M1338(mGraphics g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		for (int i = 0; i < vGameInfo.M1113(); i++)
		{
			GameInfo t = (GameInfo)vGameInfo.M1114(i);
			int num = xScroll;
			int num2 = yScroll + i * ITEM_HEIGHT;
			int num3 = wScroll - 1;
			int h = ITEM_HEIGHT - 1;
			if (num2 - cmy <= yScroll + hScroll && num2 - cmy >= yScroll - ITEM_HEIGHT)
			{
				g.M933((i != selected) ? 15196114 : 16383818);
				g.M932(num, num2, num3, h);
				mFont.tahoma_7b_dark.M898(g, t.main, xScroll + wScroll / 2, num2 + 6, mFont.CENTER);
				if (!t.hasRead && GameCanvas.gameTick % 20 > 10)
				{
					g.M948(imgNew, num + 10, num2 + 10, 3);
				}
			}
		}
		M1335(g);
	}

	private void M1339(mGraphics g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		int num = Char.M113().nClass.skillTemplates.Length;
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
			g.M948(GameScr.imgSkill, num5, num6, 0);
			if (i == 0)
			{
				SmallImage.M1785(g, 567, num5 + 4, num6 + 4, 0, 0);
				string st = mResources.HP + " " + mResources.root + ": " + NinjaUtil.M1192(Char.M113().cHPGoc);
				mFont.tahoma_7b_blue.M898(g, st, num2 + 5, num3 + 3, 0);
				mFont.tahoma_7_green2.M898(g, NinjaUtil.M1192(Char.M113().cHPGoc + 1000) + " " + mResources.potential + ": " + mResources.increase + " " + Char.M113().hpFrom1000TiemNang, num2 + 5, num3 + 15, 0);
			}
			if (i == 1)
			{
				SmallImage.M1785(g, 569, num5 + 4, num6 + 4, 0, 0);
				string st2 = mResources.KI + " " + mResources.root + ": " + NinjaUtil.M1192(Char.M113().cMPGoc);
				mFont.tahoma_7b_blue.M898(g, st2, num2 + 5, num3 + 3, 0);
				mFont.tahoma_7_green2.M898(g, NinjaUtil.M1192(Char.M113().cMPGoc + 1000) + " " + mResources.potential + ": " + mResources.increase + " " + Char.M113().mpFrom1000TiemNang, num2 + 5, num3 + 15, 0);
			}
			if (i == 2)
			{
				SmallImage.M1785(g, 568, num5 + 4, num6 + 4, 0, 0);
				string st3 = mResources.hit_point + " " + mResources.root + ": " + NinjaUtil.M1192(Char.M113().cDamGoc);
				mFont.tahoma_7b_blue.M898(g, st3, num2 + 5, num3 + 3, 0);
				mFont.tahoma_7_green2.M898(g, NinjaUtil.M1192(Char.M113().cDamGoc * 100) + " " + mResources.potential + ": " + mResources.increase + " " + Char.M113().damFrom1000TiemNang, num2 + 5, num3 + 15, 0);
			}
			if (i == 3)
			{
				SmallImage.M1785(g, 721, num5 + 4, num6 + 4, 0, 0);
				string st4 = mResources.armor + " " + mResources.root + ": " + NinjaUtil.M1192(Char.M113().cDefGoc);
				mFont.tahoma_7b_blue.M898(g, st4, num2 + 5, num3 + 3, 0);
				mFont.tahoma_7_green2.M898(g, NinjaUtil.M1192(500000 + Char.M113().cDefGoc * 100000) + " " + mResources.potential + ": " + mResources.increase + " " + Char.M113().defFrom1000TiemNang, num2 + 5, num3 + 15, 0);
			}
			if (i == 4)
			{
				SmallImage.M1785(g, 719, num5 + 4, num6 + 4, 0, 0);
				string st5 = mResources.critical + " " + mResources.root + ": " + Char.M113().cCriticalGoc + "%";
				long num7 = 50000000L;
				for (int j = 0; j < Char.M113().cCriticalGoc; j++)
				{
					num7 *= 5L;
				}
				mFont.tahoma_7b_blue.M898(g, st5, num2 + 5, num3 + 3, 0);
				long m = num7;
				mFont.tahoma_7_green2.M898(g, NinjaUtil.M1192(m) + " " + mResources.potential + ": " + mResources.increase + " " + Char.M113().criticalFrom1000Tiemnang, num2 + 5, num3 + 15, 0);
			}
			if (i == 5)
			{
				if (specialInfo != null)
				{
					SmallImage.M1785(g, spearcialImage, num5 + 4, num6 + 4, 0, 0);
					string[] array = mFont.tahoma_7.M907(specialInfo, 120);
					for (int k = 0; k < array.Length; k++)
					{
						mFont.tahoma_7_green2.M898(g, array[k], num2 + 5, num3 + 3 + k * 12, 0);
					}
				}
				else
				{
					mFont.tahoma_7_green2.M898(g, string.Empty, num2 + 5, num3 + 9, 0);
				}
			}
			if (i < 6)
			{
				continue;
			}
			SkillTemplate t = Char.M113().nClass.skillTemplates[i - 6];
			SmallImage.M1785(g, t.iconId, num5 + 4, num6 + 4, 0, 0);
			Skill t2 = Char.M113().M119(t);
			if (t2 != null)
			{
				mFont.tahoma_7b_blue.M898(g, t.name, num2 + 5, num3 + 3, 0);
				mFont.tahoma_7_blue.M898(g, mResources.level + ": " + t2.point, num2 + num4 - 5, num3 + 3, mFont.RIGHT);
				if (t2.point == t.maxPoint)
				{
					mFont.tahoma_7_green2.M898(g, mResources.max_level_reach, num2 + 5, num3 + 15, 0);
					continue;
				}
				Skill t3 = t.skills[t2.point];
				mFont.tahoma_7_green2.M898(g, mResources.level + " " + (t2.point + 1) + " " + mResources.need + " " + Res.M1533(t3.powRequire) + " " + mResources.potential, num2 + 5, num3 + 15, 0);
			}
			else
			{
				Skill t4 = t.skills[0];
				mFont.tahoma_7b_green.M898(g, t.name, num2 + 5, num3 + 3, 0);
				mFont.tahoma_7_green2.M898(g, mResources.need_upper + " " + Res.M1533(t4.powRequire) + " " + mResources.potential_to_learn, num2 + 5, num3 + 15, 0);
			}
		}
		M1335(g);
	}

	private void M1340(mGraphics g)
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
				mFont.tahoma_7b_blue.M898(g, mapNames[i], 5, num + 1, 0);
				mFont.tahoma_7_grey.M898(g, planetNames[i], 5, num + 11, 0);
			}
		}
		M1335(g);
	}

	private void M1341(mGraphics g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		int[] zones = GameScr.M559().zones;
		int[] pts = GameScr.M559().pts;
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
					mFont.tahoma_7_yellow.M898(g, zones[i] + string.Empty, num4 + num5 / 2, num2 + 6, mFont.CENTER);
				}
				else
				{
					mFont.tahoma_7_grey.M898(g, zones[i] + string.Empty, num4 + num5 / 2, num2 + 6, mFont.CENTER);
				}
				mFont.tahoma_7_green2.M898(g, GameScr.M559().numPlayer[i] + "/" + GameScr.M559().maxPlayer[i], num + 5, num2 + 6, 0);
			}
			if (GameScr.M559().rankName1[i] != null)
			{
				mFont.tahoma_7_grey.M898(g, GameScr.M559().rankName1[i] + "(Top " + GameScr.M559().rank1[i] + ")", num + num3 - 2, num2 + 1, mFont.RIGHT);
				mFont.tahoma_7_grey.M898(g, GameScr.M559().rankName2[i] + "(Top " + GameScr.M559().rank2[i] + ")", num + num3 - 2, num2 + 11, mFont.RIGHT);
			}
		}
		M1335(g);
	}

	private void M1342(mGraphics g)
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
			SmallImage.M1785(g, Char.M113().imgSpeacialSkill[currentTabIndex][i], num3 + num5 / 2, num4 + num6 / 2, 0, 3);
			string[] array = mFont.tahoma_7_grey.M907(Char.M113().infoSpeacialSkill[currentTabIndex][i], 140);
			for (int j = 0; j < array.Length; j++)
			{
				mFont.tahoma_7_grey.M898(g, array[j], num7 + 5, num8 + 1 + j * 11, 0);
			}
		}
		M1335(g);
	}

	private void M1343(mGraphics g)
	{
		g.M933(16711680);
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		try
		{
			Item[] arrItemBox = Char.M113().arrItemBox;
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
				Item t = arrItemBox[i];
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
							mFont.bigNumber_yellow.M898(g, t.M796() + "s", x, num2 + 1, mFont.RIGHT);
							mFont.tahoma_7_blue.M898(g, t.M797(), x, num2 + 11, mFont.RIGHT);
						}
					}
				}
				g.M932(num4, num5, num6, num7);
				if (t == null)
				{
					continue;
				}
				string text = string.Empty;
				mFont t2 = mFont.tahoma_7_green2;
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
					mFont t3 = mFont.tahoma_7_blue;
					if (t.compare < 0 && t.template.type != 5)
					{
						t3 = mFont.tahoma_7_red;
					}
					t3.M898(g, text2, num + 5, num2 + 11, mFont.LEFT);
				}
				SmallImage.M1785(g, t.template.iconID, num4 + num6 / 2, num5 + num7 / 2, 0, 3);
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
					mFont.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num4 + num6, num5 + num7 - mFont.tahoma_7_yellow.M912(), 1);
				}
			}
		}
		catch (Exception)
		{
		}
		M1335(g);
	}

	public Member M1344()
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
			return (Member)member.M1114(selected - 2);
		}
		return (Member)myMember.M1114(selected - 2);
	}

	public ClanMessage M1345()
	{
		if (selected < 2)
		{
			return null;
		}
		if (selected > ClanMessage.vMessage.M1113() + 1)
		{
			return null;
		}
		return (ClanMessage)ClanMessage.vMessage.M1114(selected - 2);
	}

	public Clan M1346()
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

	private void M1347(mGraphics g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (logChat.M1113() == 0)
		{
			mFont.tahoma_7_green2.M898(g, mResources.no_msg, xScroll + wScroll / 2, yScroll + hScroll / 2 - mFont.tahoma_7.M912() / 2 + 24, 2);
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
				g.M948((i != selected) ? GameScr.imgLbtn2 : GameScr.imgLbtnFocus2, xScroll + wScroll - 5, num5 + 2, StaticObj.TOP_RIGHT);
				((i != selected) ? mFont.tahoma_7b_dark : mFont.tahoma_7b_green2).M898(g, (!isViewChatServer) ? mResources.on : mResources.off, xScroll + wScroll - 22, num5 + 7, 2);
				mFont.tahoma_7_grey.M898(g, (!isViewChatServer) ? mResources.onPlease : mResources.offPlease, xScroll + 5, num5 + num7 / 2 - 4, mFont.LEFT);
				continue;
			}
			g.M933((i != selected) ? 15196114 : 16383818);
			g.M932(num4, num5, num6, num7);
			g.M933((i != selected) ? 9993045 : 9541120);
			g.M932(num, num2, num3, h);
			InfoItem t = (InfoItem)logChat.M1114(i - 1);
			if (t.charInfo.headICON != -1)
			{
				SmallImage.M1785(g, t.charInfo.headICON, num, num2, 0, 0);
			}
			else
			{
				Part t2 = GameScr.parts[t.charInfo.head];
				SmallImage.M1785(g, t2.pi[Char.CharInfo[0][0][0]].id, num + t2.pi[Char.CharInfo[0][0][0]].dx, num2 + t2.pi[Char.CharInfo[0][0][0]].dy, 0, 0);
			}
			g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
			mFont.tahoma_7b_green2.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
			if (!t.isChatServer)
			{
				mFont.tahoma_7_blue.M898(g, Res.M1531(t.s, "|", 0)[2], num4 + 5, num5 + 11, 0);
			}
			else
			{
				mFont.tahoma_7_red.M898(g, Res.M1531(t.s, "|", 0)[2], num4 + 5, num5 + 11, 0);
			}
		}
		M1335(g);
	}

	private void M1348(mGraphics g)
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
			Item t = (Item)vFlag.M1114(i);
			if (t == null)
			{
				continue;
			}
			mFont.tahoma_7_green2.M898(g, t.template.name, num + 5, num2 + 1, 0);
			string text = string.Empty;
			if (t.itemOption != null && t.itemOption.Length >= 1)
			{
				if (t.itemOption[0] != null && t.itemOption[0].optionTemplate.id != 102 && t.itemOption[0].optionTemplate.id != 107)
				{
					text += t.itemOption[0].M830();
				}
				mFont.tahoma_7_blue.M898(g, text, num + 5, num2 + 11, 0);
				SmallImage.M1785(g, t.template.iconID, num4 + num6 / 2, num5 + num7 / 2, 0, 3);
			}
		}
		M1335(g);
	}

	private void M1349(mGraphics g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (currentListLength == 0)
		{
			mFont.tahoma_7_green2.M898(g, mResources.no_enemy, xScroll + wScroll / 2, yScroll + hScroll / 2 - mFont.tahoma_7.M912() / 2, 2);
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
			InfoItem t = (InfoItem)vEnemy.M1114(i);
			if (t.charInfo.headICON != -1)
			{
				SmallImage.M1785(g, t.charInfo.headICON, num, num2, 0, 0);
			}
			else
			{
				Part t2 = GameScr.parts[t.charInfo.head];
				SmallImage.M1785(g, t2.pi[Char.CharInfo[0][0][0]].id, num + t2.pi[Char.CharInfo[0][0][0]].dx, num2 + 3 + t2.pi[Char.CharInfo[0][0][0]].dy, 0, 0);
			}
			g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
			if (t.isOnline)
			{
				mFont.tahoma_7b_green.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
				mFont.tahoma_7_blue.M898(g, t.s, num4 + 5, num5 + 11, 0);
			}
			else
			{
				mFont.tahoma_7_grey.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
				mFont.tahoma_7_grey.M898(g, t.s, num4 + 5, num5 + 11, 0);
			}
		}
		M1335(g);
	}

	private void M1350(mGraphics g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (currentListLength == 0)
		{
			mFont.tahoma_7_green2.M898(g, mResources.no_friend, xScroll + wScroll / 2, yScroll + hScroll / 2 - mFont.tahoma_7.M912() / 2, 2);
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
			InfoItem t = (InfoItem)vFriend.M1114(i);
			if (t.charInfo.headICON != -1)
			{
				SmallImage.M1785(g, t.charInfo.headICON, num, num2, 0, 0);
			}
			else
			{
				Part t2 = GameScr.parts[t.charInfo.head];
				SmallImage.M1785(g, t2.pi[Char.CharInfo[0][0][0]].id, num + t2.pi[Char.CharInfo[0][0][0]].dx, num2 + 3 + t2.pi[Char.CharInfo[0][0][0]].dy, 0, 0);
			}
			g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
			if (t.isOnline)
			{
				mFont.tahoma_7b_green.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
				mFont.tahoma_7_blue.M898(g, t.s, num4 + 5, num5 + 11, 0);
			}
			else
			{
				mFont.tahoma_7_grey.M898(g, t.charInfo.cName, num4 + 5, num5, 0);
				mFont.tahoma_7_grey.M898(g, t.s, num4 + 5, num5 + 11, 0);
			}
		}
		M1335(g);
	}

	public void M1351(mGraphics g)
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
				Command t = (Command)vPlayerMenu.M1114(i);
				g.M933((i != selected) ? 15196114 : 16383818);
				g.M932(x, num, num2, h);
				if (t.caption2.Equals(string.Empty))
				{
					mFont.tahoma_7b_dark.M898(g, t.caption, xScroll + wScroll / 2, num + 6, mFont.CENTER);
					continue;
				}
				mFont.tahoma_7b_dark.M898(g, t.caption, xScroll + wScroll / 2, num + 1, mFont.CENTER);
				mFont.tahoma_7b_dark.M898(g, t.caption2, xScroll + wScroll / 2, num + 11, mFont.CENTER);
			}
		}
		M1335(g);
	}

	private void M1352(mGraphics g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(-cmx, -cmy);
		g.M933(0);
		int num = xScroll + wScroll / 2 - clansOption.Length * TAB_W / 2;
		if (currentListLength == 2)
		{
			mFont.tahoma_7_green2.M898(g, clanReport, xScroll + wScroll / 2, yScroll + 24 + hScroll / 2 - mFont.tahoma_7.M912() / 2, 2);
			if (isMessage && myMember.M1113() == 1)
			{
				for (int i = 0; i < mResources.clanEmpty.Length; i++)
				{
					mFont.tahoma_7b_dark.M898(g, mResources.clanEmpty[i], xScroll + wScroll / 2, yScroll + 24 + hScroll / 2 - mResources.clanEmpty.Length * 12 / 2 + i * 12, mFont.CENTER);
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
					mFont.tahoma_7b_dark.M898(g, clanInfo, xScroll + wScroll / 2, num7 + 6, mFont.CENTER);
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
						mFont.tahoma_7_grey.M898(g, clansOption[k][l], num + k * TAB_W + TAB_W / 2, yScroll + l * 11, mFont.CENTER);
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
				if (ClanImage.M289(clans[j - 2].imgID))
				{
					if (ClanImage.M288((sbyte)clans[j - 2].imgID).idImage != null)
					{
						SmallImage.M1785(g, ClanImage.M288((sbyte)clans[j - 2].imgID).idImage[0], num2 + num4 / 2, num3 + num5 / 2, 0, StaticObj.VCENTER_HCENTER);
					}
				}
				else
				{
					ClanImage t = new ClanImage();
					t.ID = clans[j - 2].imgID;
					if (!ClanImage.M289(t.ID))
					{
						ClanImage.M287(t);
					}
				}
				mFont.tahoma_7b_green2.M898(g, clans[j - 2].name, num6 + 5, num7, 0);
				g.M922(num6, num7, num8 - 10, num9);
				mFont.tahoma_7_blue.M898(g, clans[j - 2].slogan, num6 + 5, num7 + 11, 0);
				g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
				mFont.tahoma_7_green2.M898(g, clans[j - 2].currMember + "/" + clans[j - 2].maxMember, num6 + num8 - 5, num7, mFont.RIGHT);
				continue;
			}
			if (isViewMember)
			{
				g.M933((j != selected) ? 15196114 : 16383818);
				g.M932(num6, num7, num8, num9);
				g.M933((j != selected) ? 9993045 : 9541120);
				g.M932(num2, num3, num4, num5);
				Member t2 = ((member == null) ? ((Member)myMember.M1114(j - 2)) : ((Member)member.M1114(j - 2)));
				if (t2.headICON != -1)
				{
					SmallImage.M1785(g, t2.headICON, num2, num3, 0, 0);
				}
				else
				{
					Part t3 = GameScr.parts[t2.head];
					SmallImage.M1785(g, t3.pi[Char.CharInfo[0][0][0]].id, num2 + t3.pi[Char.CharInfo[0][0][0]].dx, num3 + 3 + t3.pi[Char.CharInfo[0][0][0]].dy, 0, 0);
				}
				g.M922(xScroll, yScroll + cmy, wScroll, hScroll);
				mFont t4 = mFont.tahoma_7b_dark;
				if (t2.role == 0)
				{
					t4 = mFont.tahoma_7b_red;
				}
				else if (t2.role == 1)
				{
					t4 = mFont.tahoma_7b_green;
				}
				else if (t2.role == 2)
				{
					t4 = mFont.tahoma_7b_green2;
				}
				t4.M898(g, t2.name, num6 + 5, num7, 0);
				mFont.tahoma_7_blue.M898(g, mResources.power + ": " + t2.powerPoint, num6 + 5, num7 + 11, 0);
				SmallImage.M1785(g, 7223, num6 + num8 - 7, num7 + 12, 0, 3);
				mFont.tahoma_7_blue.M898(g, string.Empty + t2.clanPoint, num6 + num8 - 15, num7 + 6, mFont.RIGHT);
				continue;
			}
			if (!isMessage || ClanMessage.vMessage.M1113() == 0)
			{
				continue;
			}
			ClanMessage t5 = (ClanMessage)ClanMessage.vMessage.M1114(j - 2);
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
					g.M948(GameScr.imgLbtnFocus2, num10 + m * 40 + 20, num7 + num9 / 2, StaticObj.VCENTER_HCENTER);
					mFont.tahoma_7b_green2.M898(g, t5.option[m], num10 + m * 40 + 20, num7 + 6, mFont.CENTER);
				}
				else
				{
					g.M948(GameScr.imgLbtn2, num10 + m * 40 + 20, num7 + num9 / 2, StaticObj.VCENTER_HCENTER);
					mFont.tahoma_7b_dark.M898(g, t5.option[m], num10 + m * 40 + 20, num7 + 6, mFont.CENTER);
				}
			}
		}
		M1335(g);
	}

	private void M1353(mGraphics g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(0, -cmy);
		g.M933(0);
		if (currentListLength == 0)
		{
			mFont.tahoma_7_green2.M898(g, mResources.no_mission, xScroll + wScroll / 2, yScroll + hScroll / 2 - mFont.tahoma_7.M912() / 2, 2);
		}
		else
		{
			if (Char.M113().arrArchive == null || Char.M113().arrArchive.Length != currentListLength)
			{
				return;
			}
			for (int i = 0; i < currentListLength; i++)
			{
				int num = xScroll;
				int num2 = yScroll + i * ITEM_HEIGHT;
				int num3 = wScroll;
				int num4 = ITEM_HEIGHT - 1;
				Archivement t = Char.M113().arrArchive[i];
				g.M933((i != selected || ((t.isRecieve || t.isFinish) && (!t.isRecieve || !t.isFinish))) ? 15196114 : 16383818);
				g.M932(num, num2, num3, num4);
				if (t == null)
				{
					continue;
				}
				if (!t.isFinish)
				{
					mFont.tahoma_7.M898(g, t.info1, num + 5, num2, 0);
					mFont.tahoma_7_green.M898(g, t.money + " " + mResources.RUBY, num + num3 - 5, num2, mFont.RIGHT);
					mFont.tahoma_7_red.M898(g, t.info2, num + 5, num2 + 11, 0);
				}
				else if (t.isFinish && !t.isRecieve)
				{
					mFont.tahoma_7.M898(g, t.info1, num + 5, num2, 0);
					mFont.tahoma_7_blue.M898(g, mResources.reward_mission + t.money + " " + mResources.RUBY, num + 5, num2 + 11, 0);
					if (i == selected)
					{
						mFont.tahoma_7b_green2.M898(g, mResources.receive_upper, num + num3 - 20, num2 + 6, mFont.CENTER);
						mFont.tahoma_7b_dark.M898(g, mResources.receive_upper, num + num3 - 20, num2 + 6, mFont.CENTER);
					}
					else
					{
						g.M948(GameScr.imgLbtn2, num + num3 - 20, num2 + num4 / 2, StaticObj.VCENTER_HCENTER);
						mFont.tahoma_7b_dark.M898(g, mResources.receive_upper, num + num3 - 20, num2 + 6, mFont.CENTER);
					}
				}
				else if (t.isFinish && t.isRecieve)
				{
					mFont.tahoma_7_green.M898(g, t.info1, num + 5, num2, 0);
					mFont.tahoma_7_green.M898(g, t.info2, num + 5, num2 + 11, 0);
				}
			}
			M1335(g);
		}
	}

	private void M1354(mGraphics g)
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
					mFont.tahoma_7b_dark.M898(g, combineInfo[i], xScroll + wScroll / 2, yScroll + hScroll / 2 - combineInfo.Length * 14 / 2 + i * 14 + 5, 2);
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
					if (!GameCanvas.isTouch && j == selected)
					{
						g.M933(16383818);
						g.M932(num5, num2, wScroll, num4 + 2);
					}
					if ((j == selected && keyTouchCombine == 1) || (!GameCanvas.isTouch && j == selected))
					{
						g.M948(GameScr.imgLbtnFocus, xScroll + wScroll / 2, num2 + num4 / 2 + 1, StaticObj.VCENTER_HCENTER);
						mFont.tahoma_7b_green2.M898(g, mResources.UPGRADE, xScroll + wScroll / 2, num2 + num4 / 2 - 4, mFont.CENTER);
					}
					else
					{
						g.M948(GameScr.imgLbtn, xScroll + wScroll / 2, num2 + num4 / 2 + 1, StaticObj.VCENTER_HCENTER);
						mFont.tahoma_7b_dark.M898(g, mResources.UPGRADE, xScroll + wScroll / 2, num2 + num4 / 2 - 4, mFont.CENTER);
					}
				}
				continue;
			}
			g.M933((j != selected) ? 15196114 : 16383818);
			g.M932(num, num2, num3, num4);
			g.M933((j != selected) ? 9993045 : 9541120);
			Item t = (Item)vItemCombine.M1114(j);
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
			mFont t2 = mFont.tahoma_7_green2;
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
				mFont t3 = mFont.tahoma_7_blue;
				if (t.compare < 0 && t.template.type != 5)
				{
					t3 = mFont.tahoma_7_red;
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
				t3.M898(g, text2, num + 5, num2 + 11, mFont.LEFT);
			}
			SmallImage.M1785(g, t.template.iconID, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
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
				mFont.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num5 + num7, num6 + num8 - mFont.tahoma_7_yellow.M912(), 1);
			}
		}
		M1335(g);
	}

	private void M1355(mGraphics g)
	{
		g.M933(16711680);
		Item[] arrItemBody = Char.M113().arrItemBody;
		Item[] arrItemBag = Char.M113().arrItemBag;
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
				Item t = ((i >= arrItemBody.Length) ? arrItemBag[i - arrItemBody.Length] : arrItemBody[i]);
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
				if (t != null && t.isSelect && GameCanvas.panel.type == 12)
				{
					g.M933((i != selected) ? 6047789 : 7040779);
					g.M932(num4, num5, num6, num7);
				}
				if (t == null)
				{
					continue;
				}
				string text = string.Empty;
				mFont t2 = mFont.tahoma_7_green2;
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
					mFont t3 = mFont.tahoma_7_blue;
					if (t.compare < 0 && t.template.type != 5)
					{
						t3 = mFont.tahoma_7_red;
					}
					t3.M898(g, text2, num + 5, num2 + 11, mFont.LEFT);
				}
				SmallImage.M1785(g, t.template.iconID, num4 + num6 / 2, num5 + num7 / 2, 0, 3);
				if (t.quantity > 1)
				{
					mFont.tahoma_7_yellow.M898(g, string.Empty + t.quantity, num4 + num6, num5 + num7 - mFont.tahoma_7_yellow.M912(), 1);
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
					mFont.bigNumber_yellow.M898(g, t.M796() + "s", x, num2 + 1, mFont.RIGHT);
					mFont.tahoma_7_blue.M898(g, t.M797(), x, num2 + 11, mFont.RIGHT);
				}
			}
		}
		catch (Exception)
		{
		}
		M1335(g);
	}

	private void M1356(mGraphics g)
	{
		if (type != 23 && type != 24)
		{
			if (type == 20)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.account, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 22)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.autoFunction, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 19)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.option, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 18)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.change_flag, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 13 && Equals(GameCanvas.panel2))
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.item_receive2, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 12 && GameCanvas.panel2 != null)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.UPGRADE, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 11)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.friend, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 16)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.enemy, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 15)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, topName, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 2 && GameCanvas.panel2 != null)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.chest, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 9)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.achievement_mission, xScroll + wScroll / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 3)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.select_zone, startTabPos + TAB_W / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 14)
			{
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				mFont.tahoma_7b_dark.M898(g, mResources.select_map, startTabPos + TAB_W / 2, 59, mFont.CENTER);
				return;
			}
			if (type == 4)
			{
				mFont.tahoma_7b_dark.M898(g, mResources.map, startTabPos + TAB_W / 2, 59, mFont.CENTER);
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				return;
			}
			if (type == 7)
			{
				mFont.tahoma_7b_dark.M898(g, mResources.trangbi, startTabPos + TAB_W / 2, 59, mFont.CENTER);
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				return;
			}
			if (type == 17)
			{
				mFont.tahoma_7b_dark.M898(g, mResources.kigui, startTabPos + TAB_W / 2, 59, mFont.CENTER);
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				return;
			}
			if (type == 8)
			{
				mFont.tahoma_7b_dark.M898(g, mResources.msg, startTabPos + TAB_W / 2, 59, mFont.CENTER);
				g.M933(13524492);
				g.M932(X + 1, 78, W - 2, 1);
				return;
			}
			if (type == 10)
			{
				mFont.tahoma_7b_dark.M898(g, mResources.wat_do_u_want, startTabPos + TAB_W / 2, 59, mFont.CENTER);
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
				PopUp.M1481(g, startTabPos + i * TAB_W, 52, TAB_W - 1, 25, (i == currentTabIndex) ? 1 : 0, isButton: true);
				if (i == keyTouchTab)
				{
					g.M948(ItemMap.imageFlare, startTabPos + i * TAB_W + TAB_W / 2, 62, 3);
				}
				mFont t = ((i != currentTabIndex) ? mFont.tahoma_7_grey : mFont.tahoma_7_green2);
				if (!currentTabName[i][1].Equals(string.Empty))
				{
					t.M898(g, currentTabName[i][0], startTabPos + i * TAB_W + TAB_W / 2, 53, mFont.CENTER);
					t.M898(g, currentTabName[i][1], startTabPos + i * TAB_W + TAB_W / 2, 64, mFont.CENTER);
				}
				else
				{
					t.M898(g, currentTabName[i][0], startTabPos + i * TAB_W + TAB_W / 2, 59, mFont.CENTER);
				}
				if (type == 0 && currentTabName.Length == 5 && GameScr.isNewClanMessage && GameCanvas.gameTick % 4 == 0)
				{
					g.M948(ItemMap.imageFlare, startTabPos + 3 * TAB_W + TAB_W / 2, 77, mGraphics.BOTTOM | mGraphics.HCENTER);
				}
			}
			g.M933(13524492);
			g.M932(1, 78, W - 2, 1);
		}
		else
		{
			g.M933(13524492);
			g.M932(X + 1, 78, W - 2, 1);
			mFont.tahoma_7b_dark.M898(g, mResources.gameInfo, xScroll + wScroll / 2, 59, mFont.CENTER);
		}
	}

	private void M1357(mGraphics g)
	{
		if (type != 13 || (currentTabIndex != 2 && !Equals(GameCanvas.panel2)))
		{
			g.M922(0, 0, GameCanvas.w, GameCanvas.h);
			g.M933(11837316);
			g.M932(X + 1, H - 15, W - 2, 14);
			g.M933(13524492);
			g.M932(X + 1, H - 15, W - 2, 1);
			g.M948(imgXu, X + 10, H - 7, 3);
			g.M948(imgLuong, X + 80, H - 8, 3);
			mFont.tahoma_7_yellow.M902(g, NinjaUtil.M1192(Char.M113().xu) + string.Empty, X + 20, H - 13, mFont.LEFT, mFont.tahoma_7_grey);
			mFont.tahoma_7_yellow.M902(g, NinjaUtil.M1192(Char.M113().luong) + string.Empty, X + 90, H - 13, mFont.LEFT, mFont.tahoma_7_grey);
			g.M948(imgLuongKhoa, X + 130, H - 8, 3);
			mFont.tahoma_7_yellow.M902(g, NinjaUtil.M1192(Char.M113().luongKhoa) + string.Empty, X + 140, H - 13, mFont.LEFT, mFont.tahoma_7_grey);
		}
	}

	private void M1358(mGraphics g)
	{
		if (Char.M113().clan == null)
		{
			SmallImage.M1785(g, Char.M113().M108(), 25, 50, 0, 33);
			mFont.tahoma_7b_white.M898(g, mResources.not_join_clan, (wScroll - 50) / 2 + 50, 20, mFont.CENTER);
		}
		else if (!isViewMember)
		{
			Clan clan = Char.M113().clan;
			if (clan != null)
			{
				SmallImage.M1785(g, Char.M113().M108(), 25, 50, 0, 33);
				mFont.tahoma_7b_white.M902(g, clan.name, 60, 4, mFont.LEFT, mFont.tahoma_7b_dark);
				mFont.tahoma_7_yellow.M902(g, mResources.achievement_point + ": " + clan.powerPoint, 60, 16, mFont.LEFT, mFont.tahoma_7_grey);
				mFont.tahoma_7_yellow.M902(g, mResources.clan_point + ": " + clan.clanPoint, 60, 27, mFont.LEFT, mFont.tahoma_7_grey);
				mFont.tahoma_7_yellow.M902(g, mResources.level + ": " + clan.level, 60, 38, mFont.LEFT, mFont.tahoma_7_grey);
				TextInfo.M1899(g, clan.slogan, 60, 38, wScroll - 70, ITEM_HEIGHT, mFont.tahoma_7_yellow);
			}
		}
		else
		{
			Clan t = ((currClan == null) ? Char.M113().clan : currClan);
			SmallImage.M1785(g, Char.M113().M108(), 25, 51, 0, 33);
			mFont.tahoma_7b_white.M902(g, t.name, 60, 4, mFont.LEFT, mFont.tahoma_7b_dark);
			mFont.tahoma_7_yellow.M902(g, mResources.member + ": " + t.currMember + "/" + t.maxMember, 60, 16, mFont.LEFT, mFont.tahoma_7_grey);
			mFont.tahoma_7_yellow.M902(g, mResources.clan_leader + ": " + t.leaderName, 60, 27, mFont.LEFT, mFont.tahoma_7_grey);
			TextInfo.M1899(g, t.slogan, 60, 38, wScroll - 70, ITEM_HEIGHT, mFont.tahoma_7_yellow);
		}
	}

	private void M1359(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		mFont.tahoma_7b_white.M902(g, mResources.dragon_ball + " " + GameMidlet.VERSION, 60, 4, mFont.LEFT, mFont.tahoma_7b_dark);
		mFont.tahoma_7_yellow.M902(g, mResources.character + ": " + Char.M113().cName, 60, 16, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7_yellow.M902(g, mResources.account_server + " " + ServerListScreen.nameServer[ServerListScreen.ipSelect] + ":", 60, 27, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7_yellow.M902(g, (!GameCanvas.loginScr.tfUser.M1924().Equals(string.Empty)) ? GameCanvas.loginScr.tfUser.M1924() : mResources.not_register_yet, 60, 39, mFont.LEFT, mFont.tahoma_7_grey);
	}

	private void M1360(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		mFont.tahoma_7_yellow.M902(g, mResources.select_item, 60, 4, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7_yellow.M902(g, mResources.lock_trade, 60, 16, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7_yellow.M902(g, mResources.wait_opp_lock_trade, 60, 27, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7_yellow.M902(g, mResources.press_done, 60, 38, mFont.LEFT, mFont.tahoma_7_grey);
	}

	private void M1361(mGraphics g)
	{
		M1363(g, Char.M113());
	}

	private void M1362(mGraphics g)
	{
		mFont.tahoma_7_yellow.M902(g, mResources.power + ": " + NinjaUtil.M1192(Char.M114().cPower), X + 52, 4, mFont.LEFT, mFont.tahoma_7_grey);
		if (Char.M114().cPower > 0L)
		{
			mFont.tahoma_7_yellow.M902(g, (!Char.M114().me) ? Char.M114().currStrLevel : Char.M114().M107(), X + 52, 16, mFont.LEFT, mFont.tahoma_7_grey);
		}
		if (Char.M114().cDamFull > 0)
		{
			mFont.tahoma_7_yellow.M902(g, mResources.hit_point + ": " + NinjaUtil.M1192(Char.M114().cDamFull), X + 52, 27, mFont.LEFT, mFont.tahoma_7_grey);
		}
		if (Char.M114().cMaxStamina > 0)
		{
			mFont.tahoma_7_yellow.M902(g, string.Concat(new object[5]
			{
				mResources.vitality,
				": ",
				NinjaUtil.M1192(Char.M114().cStamina),
				" / ",
				NinjaUtil.M1192(Char.M114().cMaxStamina)
			}), X + 52, 38, mFont.LEFT, mFont.tahoma_7_grey);
		}
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
	}

	private void M1363(mGraphics g, Char c)
	{
		mFont.tahoma_7b_white.M902(g, ((GameScr.isNewMember == 1) ? "       " : string.Empty) + c.cName, X + 60, 4, mFont.LEFT, mFont.tahoma_7b_dark);
		if (GameScr.isNewMember == 1)
		{
			SmallImage.M1785(g, 5427, X + 55, 4, 0, 0);
		}
		if (c.cMaxStamina > 0)
		{
			mFont.tahoma_7_yellow.M902(g, mResources.vitality, X + 60, 16, mFont.LEFT, mFont.tahoma_7_grey);
			g.M948(GameScr.imgMPLost, X + 95, 19, 0);
			g.M922(95, w: c.cStamina * mGraphics.M958(GameScr.imgMP) / c.cMaxStamina, y: X + 19, h: 20);
			g.M948(GameScr.imgMP, X + 95, 19, 0);
		}
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
		if (c.cPower > 0L)
		{
			mFont.tahoma_7_yellow.M902(g, (!c.me) ? c.currStrLevel : c.M107(), X + 60, 27, mFont.LEFT, mFont.tahoma_7_grey);
		}
		mFont.tahoma_7_yellow.M902(g, mResources.power + ": " + NinjaUtil.M1192(c.cPower), X + 60, 38, mFont.LEFT, mFont.tahoma_7_grey);
	}

	private void M1364(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		mFont.tahoma_7b_white.M902(g, mResources.zone + " " + TileMap.zoneID, 60, 4, mFont.LEFT, mFont.tahoma_7b_dark);
		mFont.tahoma_7_yellow.M902(g, TileMap.mapName, 60, 16, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7b_white.M898(g, TileMap.zoneID + string.Empty, 25, 27, mFont.CENTER);
	}

	public int M1365(Item item)
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
			ItemOption t = item.itemOption[0];
			if (t.optionTemplate.id == 22)
			{
				t.optionTemplate = GameScr.M559().iOptionTemplates[6];
				t.param *= 1000;
			}
			if (t.optionTemplate.id == 23)
			{
				t.optionTemplate = GameScr.M559().iOptionTemplates[7];
				t.param *= 1000;
			}
			Item t2 = null;
			for (int i = 0; i < Char.M113().arrItemBody.Length; i++)
			{
				Item t3 = Char.M113().arrItemBody[i];
				if (t.optionTemplate.id == 22)
				{
					t.optionTemplate = GameScr.M559().iOptionTemplates[6];
					t.param *= 1000;
				}
				if (t.optionTemplate.id == 23)
				{
					t.optionTemplate = GameScr.M559().iOptionTemplates[7];
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
				Res.M1513("5");
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

	private void M1366(mGraphics g)
	{
		mFont.tahoma_7b_white.M898(g, mResources.MENUGENDER[TileMap.planetID], 60, 4, mFont.LEFT);
		string text = string.Empty;
		if (TileMap.mapID >= 135 && TileMap.mapID <= 138)
		{
			text = " " + mResources.tang + TileMap.zoneID;
		}
		mFont.tahoma_7_yellow.M898(g, TileMap.mapName + text, 60, 16, mFont.LEFT);
		mFont.tahoma_7b_white.M898(g, mResources.quest_place + ": ", 60, 27, mFont.LEFT);
		if (GameScr.M659() >= 0 && GameScr.M659() <= TileMap.mapNames.Length - 1)
		{
			mFont.tahoma_7_yellow.M898(g, TileMap.mapNames[GameScr.M659()], 60, 38, mFont.LEFT);
		}
		else
		{
			mFont.tahoma_7_yellow.M898(g, mResources.random, 60, 38, mFont.LEFT);
		}
	}

	private void M1367(mGraphics g)
	{
		if (currentTabIndex == currentTabName.Length - 1 && GameCanvas.panel2 == null)
		{
			M1361(g);
		}
		else if (selected < 0)
		{
			if (typeShop != 2)
			{
				mFont.tahoma_7_white.M898(g, mResources.say_hello, X + 60, 14, 0);
				mFont.tahoma_7_white.M898(g, strWantToBuy, X + 60, 26, 0);
				return;
			}
			mFont.tahoma_7_white.M898(g, mResources.say_hello, X + 60, 5, 0);
			mFont.tahoma_7_white.M898(g, strWantToBuy, X + 60, 17, 0);
			mFont.tahoma_7_white.M898(g, mResources.page + " " + (currPageShop[currentTabIndex] + 1) + "/" + maxPageShop[currentTabIndex], X + 60, 29, 0);
		}
		else
		{
			if (currentTabIndex < 0 || currentTabIndex > Char.M113().arrItemShop.Length - 1 || selected < 0 || selected > Char.M113().arrItemShop[currentTabIndex].Length - 1)
			{
				return;
			}
			Item t = Char.M113().arrItemShop[currentTabIndex][selected];
			if (t != null)
			{
				if (Equals(GameCanvas.panel) && currentTabIndex <= 3 && typeShop == 2)
				{
					mFont.tahoma_7b_white.M898(g, mResources.page + " " + (currPageShop[currentTabIndex] + 1) + "/" + maxPageShop[currentTabIndex], X + 55, 4, 0);
				}
				mFont.tahoma_7b_white.M898(g, t.template.name, X + 55, 24, 0);
				string st = mResources.pow_request + " " + Res.M1532(t.template.strRequire);
				if (t.template.strRequire > Char.M113().cPower)
				{
					mFont.tahoma_7_yellow.M898(g, st, X + 55, 35, 0);
				}
				else
				{
					mFont.tahoma_7_green.M898(g, st, X + 55, 35, 0);
				}
			}
		}
	}

	private void M1368(mGraphics g)
	{
		string st = mResources.used + ": " + hasUse + "/" + Char.M113().arrItemBox.Length + " " + mResources.place;
		mFont.tahoma_7b_white.M898(g, mResources.chest, 60, 4, 0);
		mFont.tahoma_7_yellow.M898(g, st, 60, 16, 0);
	}

	private void M1369(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		mFont.tahoma_7_white.M898(g, "Top " + Char.M113().rank, X + 45 + (W - 50) / 2, 2, mFont.CENTER);
		mFont.tahoma_7_yellow.M898(g, mResources.potential_point, X + 45 + (W - 50) / 2, 14, mFont.CENTER);
		mFont.tahoma_7_white.M898(g, string.Empty + NinjaUtil.M1192(Char.M113().cTiemNang), X + ((GameCanvas.gameTick % 20 > 10) ? (GameCanvas.gameTick % 4 / 2) : 0) + 45 + (W - 50) / 2, 26, mFont.CENTER);
		mFont.tahoma_7_yellow.M898(g, mResources.active_point + ": " + NinjaUtil.M1192(Char.M113().cNangdong), X + ((GameCanvas.gameTick % 20 > 10) ? (GameCanvas.gameTick % 4 / 2) : 0) + 45 + (W - 50) / 2, 38, mFont.CENTER);
	}

	private void M1370(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		mFont.tahoma_7_yellow.M902(g, string.Concat(new object[5]
		{
			mResources.HP,
			": ",
			NinjaUtil.M1192(Char.M113().cHP),
			" / ",
			NinjaUtil.M1192(Char.M113().cHPFull)
		}), X + 52, 2, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7_yellow.M902(g, string.Concat(new object[5]
		{
			mResources.KI,
			": ",
			NinjaUtil.M1192(Char.M113().cMP),
			" / ",
			NinjaUtil.M1192(Char.M113().cMPFull)
		}), X + 52, 14, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7_yellow.M902(g, mResources.hit_point + ": " + NinjaUtil.M1192(Char.M113().cDamFull), X + 52, 26, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7_yellow.M902(g, string.Concat(new object[8]
		{
			mResources.armor,
			": ",
			NinjaUtil.M1192(Char.M113().cDefull),
			", ",
			mResources.critical,
			": ",
			NinjaUtil.M1192(Char.M113().cCriticalFull),
			"%"
		}), X + 52, 38, mFont.LEFT, mFont.tahoma_7_grey);
	}

	private void M1371(mGraphics g)
	{
		g.M922(X + 1, Y, W - 2, yScroll - 2);
		g.M933(9993045);
		g.M932(X, Y, W - 2, 50);
		switch (type)
		{
		case 0:
			if (currentTabIndex == 0)
			{
				SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
				M1361(g);
			}
			if (currentTabIndex == 1)
			{
				SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
				M1370(g);
			}
			if (currentTabIndex == 2)
			{
				SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
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
					SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
					M1359(g);
				}
			}
			if (currentTabIndex == 4)
			{
				SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
				M1359(g);
			}
			break;
		case 1:
			if (currentTabIndex == currentTabName.Length - 1 && GameCanvas.panel2 == null)
			{
				SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			}
			else
			{
				SmallImage.M1785(g, Char.M113().npcFocus.avatar, X + 25, 50, 0, 33);
			}
			M1367(g);
			break;
		case 2:
			if (currentTabIndex == 0)
			{
				SmallImage.M1785(g, 526, X + 25, 50, 0, 33);
				M1368(g);
			}
			if (currentTabIndex == 1)
			{
				SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
				M1370(g);
			}
			break;
		case 3:
			SmallImage.M1785(g, 561, X + 25, 50, 0, 33);
			M1364(g);
			break;
		case 4:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1366(g);
			break;
		case 8:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 9:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 10:
			if (charMenu != null)
			{
				SmallImage.M1785(g, charMenu.M108(), X + 25, 50, 0, 33);
				M1363(g, charMenu);
			}
			break;
		case 12:
			if (currentTabIndex == 0)
			{
				int id = 1410;
				for (int i = 0; i < GameScr.vNpc.M1113(); i++)
				{
					Npc t = (Npc)GameScr.vNpc.M1114(i);
					if (t.template.npcTemplateId == idNPC)
					{
						id = t.avatar;
					}
				}
				SmallImage.M1785(g, id, X + 25, 50, 0, 33);
				M1374(g);
			}
			if (currentTabIndex == 1)
			{
				SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
				M1361(g);
			}
			break;
		case 13:
			if (currentTabIndex == 0 || currentTabIndex == 1)
			{
				if (Equals(GameCanvas.panel))
				{
					SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
					M1360(g);
				}
				if (Equals(GameCanvas.panel2) && charMenu != null)
				{
					SmallImage.M1785(g, charMenu.M108(), X + 25, 50, 0, 33);
					M1363(g, charMenu);
				}
			}
			if (currentTabIndex == 2 && charMenu != null)
			{
				SmallImage.M1785(g, charMenu.M108(), X + 25, 50, 0, 33);
				M1363(g, charMenu);
			}
			break;
		case 14:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1366(g);
			break;
		case 15:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 7:
		case 17:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 18:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 19:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1359(g);
			break;
		case 20:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1359(g);
			break;
		case 21:
			if (currentTabIndex == 0)
			{
				SmallImage.M1785(g, Char.M114().M108(), X + 25, 50, 0, 33);
				M1362(g);
			}
			if (currentTabIndex == 1)
			{
				SmallImage.M1785(g, Char.M114().M108(), X + 25, 50, 0, 33);
				M1373(g);
			}
			if (currentTabIndex == 2)
			{
				SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
				M1370(g);
			}
			break;
		case 22:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1359(g);
			break;
		case 11:
		case 16:
		case 23:
		case 24:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
			M1361(g);
			break;
		case 25:
			SmallImage.M1785(g, Char.M113().M108(), X + 25, 50, 0, 33);
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

	private void M1373(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		mFont.tahoma_7b_white.M902(g, string.Concat(new object[4]
		{
			"HP: ",
			NinjaUtil.M1192(Char.M114().cHP),
			"/",
			NinjaUtil.M1192(Char.M114().cHPFull)
		}), X + 52, 4, mFont.LEFT, mFont.tahoma_7b_dark);
		mFont.tahoma_7b_white.M902(g, string.Concat(new object[4]
		{
			"MP: ",
			NinjaUtil.M1192(Char.M114().cMP),
			"/",
			NinjaUtil.M1192(Char.M114().cMPFull)
		}), X + 52, 16, mFont.LEFT, mFont.tahoma_7b_dark);
		mFont.tahoma_7_yellow.M902(g, string.Concat(new object[7]
		{
			mResources.critical,
			": ",
			NinjaUtil.M1192(Char.M114().cCriticalFull),
			"   ",
			mResources.armor,
			": ",
			NinjaUtil.M1192(Char.M114().cDefull)
		}), X + 52, 27, mFont.LEFT, mFont.tahoma_7_grey);
		mFont.tahoma_7_yellow.M902(g, mResources.status + ": " + strStatus[Char.M114().petStatus], X + 52, 38, mFont.LEFT, mFont.tahoma_7_grey);
	}

	private void M1374(mGraphics g)
	{
		if (combineTopInfo != null)
		{
			for (int i = 0; i < combineTopInfo.Length; i++)
			{
				mFont.tahoma_7_white.M898(g, combineTopInfo[i], X + 45 + (W - 50) / 2, 5 + i * 14, mFont.CENTER);
			}
		}
	}

	private void M1375(mGraphics g)
	{
	}

	public void M1376(mGraphics g)
	{
		g.M922(xScroll, yScroll, wScroll, hScroll);
		g.M918(-cmxMap, -cmyMap);
		g.M948(imgMap, xScroll, yScroll, 0);
		int head = Char.M113().head;
		SmallImage.M1785(g, GameScr.parts[head].pi[Char.CharInfo[0][0][0]].id, xMap, yMap + 5, 0, 3);
		int align = mFont.CENTER;
		if (xMap <= 40)
		{
			align = mFont.LEFT;
		}
		if (xMap >= 220)
		{
			align = mFont.RIGHT;
		}
		mFont.tahoma_7b_yellow.M902(g, TileMap.mapName, xMap, yMap - 12, align, mFont.tahoma_7_grey);
		int num = -1;
		if (GameScr.M659() != -1)
		{
			for (int i = 0; i < mapId[TileMap.planetID].Length; i++)
			{
				if (mapId[TileMap.planetID][i] != GameScr.M659())
				{
					num = 4;
					continue;
				}
				num = i;
				break;
			}
			if (GameCanvas.gameTick % 4 > 0)
			{
				g.M948(ItemMap.imageFlare, xScroll + mapX[TileMap.planetID][num], yScroll + mapY[TileMap.planetID][num], 3);
			}
		}
		if (!GameCanvas.isTouch)
		{
			g.M948(imgBantay, xMove, yMove, StaticObj.TOP_RIGHT);
			for (int j = 0; j < mapX[TileMap.planetID].Length; j++)
			{
				int num2 = mapX[TileMap.planetID][j] + xScroll;
				int num3 = mapY[TileMap.planetID][j] + yScroll;
				if (Res.M1530(num2 - 15, num3 - 15, 30, 30, xMove, yMove))
				{
					align = mFont.CENTER;
					if (num2 <= 20)
					{
						align = mFont.LEFT;
					}
					if (num2 >= 220)
					{
						align = mFont.RIGHT;
					}
					mFont.tahoma_7b_yellow.M902(g, TileMap.mapNames[mapId[TileMap.planetID][j]], num2, num3 - 12, align, mFont.tahoma_7_grey);
					break;
				}
			}
		}
		else if (!trans)
		{
			for (int k = 0; k < mapX[TileMap.planetID].Length; k++)
			{
				int num4 = mapX[TileMap.planetID][k] + xScroll;
				int num5 = mapY[TileMap.planetID][k] + yScroll;
				if (Res.M1530(num4 - 15, num5 - 15, 30, 30, pX, pY))
				{
					align = mFont.CENTER;
					if (num4 <= 30)
					{
						align = mFont.LEFT;
					}
					if (num4 >= 220)
					{
						align = mFont.RIGHT;
					}
					g.M948(imgBantay, num4, num5, StaticObj.TOP_RIGHT);
					mFont.tahoma_7b_yellow.M902(g, TileMap.mapNames[mapId[TileMap.planetID][k]], num4, num5 - 12, align, mFont.tahoma_7_grey);
					break;
				}
			}
		}
		g.M918(-g.M920(), -g.M921());
		if (num != -1)
		{
			if (mapX[TileMap.planetID][num] + xScroll < cmxMap)
			{
				g.M940(Mob.imgHP, 0, 0, 9, 6, 5, xScroll + 5, yScroll + hScroll / 2 - 4, 0);
			}
			if (cmxMap + wScroll < mapX[TileMap.planetID][num] + xScroll)
			{
				g.M940(Mob.imgHP, 0, 0, 9, 6, 6, xScroll + wScroll - 5, yScroll + hScroll / 2 - 4, StaticObj.TOP_RIGHT);
			}
			if (mapY[TileMap.planetID][num] < cmyMap)
			{
				g.M940(Mob.imgHP, 0, 0, 9, 6, 1, xScroll + wScroll / 2, yScroll + 5, StaticObj.TOP_CENTER);
			}
			if (mapY[TileMap.planetID][num] > cmyMap + hScroll)
			{
				g.M940(Mob.imgHP, 0, 0, 9, 6, 0, xScroll + wScroll / 2, yScroll + hScroll - 5, StaticObj.BOTTOM_HCENTER);
			}
		}
	}

	public void M1377(mGraphics g)
	{
		int num = ((GameCanvas.h <= 300) ? 15 : 20);
		if (isPaintMap && !GameScr.M559().M535() && !GameScr.M559().M536())
		{
			g.M948((keyTouchMapButton != 1) ? GameScr.imgLbtn : GameScr.imgLbtnFocus, xScroll + wScroll / 2, yScroll + hScroll - num, 3);
			mFont.tahoma_7b_dark.M898(g, mResources.map, xScroll + wScroll / 2, yScroll + hScroll - (num + 5), mFont.CENTER);
		}
		xstart = xScroll + 5;
		ystart = yScroll + 14;
		yPaint = ystart;
		g.M922(xScroll, yScroll, wScroll, hScroll - 35);
		if (scroll != null)
		{
			if (scroll.cmy > 0)
			{
				g.M940(Mob.imgHP, 0, 0, 9, 6, 1, xScroll + wScroll - 12, yScroll + 3, 0);
			}
			if (scroll.cmy < scroll.cmyLim)
			{
				g.M940(Mob.imgHP, 0, 0, 9, 6, 0, xScroll + wScroll - 12, yScroll + hScroll - 45, 0);
			}
			g.M918(0, -scroll.cmy);
		}
		indexRowMax = 0;
		if (indexMenu == 0)
		{
			bool flag = false;
			if (Char.M113().taskMaint != null)
			{
				for (int i = 0; i < Char.M113().taskMaint.names.Length; i++)
				{
					mFont.tahoma_7_grey.M898(g, Char.M113().taskMaint.names[i], xScroll + wScroll / 2, yPaint - 5 + i * 12, mFont.CENTER);
					indexRowMax++;
				}
				yPaint += (Char.M113().taskMaint.names.Length - 1) * 12;
				int num2 = 0;
				string empty = string.Empty;
				for (int j = 0; j < Char.M113().taskMaint.subNames.Length; j++)
				{
					if (Char.M113().taskMaint.subNames[j] != null)
					{
						num2 = j;
						empty = "- " + Char.M113().taskMaint.subNames[j];
						if (Char.M113().taskMaint.counts[j] != -1)
						{
							if (Char.M113().taskMaint.index == j)
							{
								if (Char.M113().taskMaint.counts[j] != 1)
								{
									string text = empty;
									empty = text + " (" + Char.M113().taskMaint.count + "/" + Char.M113().taskMaint.counts[j] + ")";
								}
								if (Char.M113().taskMaint.count == Char.M113().taskMaint.counts[j])
								{
									mFont.tahoma_7.M898(g, empty, xstart + 5, yPaint += 12, 0);
								}
								else
								{
									mFont tahoma_7_grey = mFont.tahoma_7_grey;
									if (!flag)
									{
										flag = true;
										tahoma_7_grey = mFont.tahoma_7_blue;
										tahoma_7_grey.M898(g, empty, xstart + 5 + ((tahoma_7_grey == mFont.tahoma_7_blue && GameCanvas.gameTick % 20 > 10) ? (GameCanvas.gameTick % 4 / 2) : 0), yPaint += 12, 0);
									}
									else
									{
										tahoma_7_grey.M898(g, "- ...", xstart + 5 + ((tahoma_7_grey == mFont.tahoma_7_blue && GameCanvas.gameTick % 20 > 10) ? (GameCanvas.gameTick % 4 / 2) : 0), yPaint += 12, 0);
									}
								}
							}
							else if (Char.M113().taskMaint.index > j)
							{
								if (Char.M113().taskMaint.counts[j] != 1)
								{
									string text2 = empty;
									empty = text2 + " (" + Char.M113().taskMaint.counts[j] + "/" + Char.M113().taskMaint.counts[j] + ")";
								}
								mFont.tahoma_7_white.M898(g, empty, xstart + 5, yPaint += 12, 0);
							}
							else
							{
								if (Char.M113().taskMaint.counts[j] != 1)
								{
									empty = empty + " 0/" + Char.M113().taskMaint.counts[j];
								}
								mFont tahoma_7_grey2 = mFont.tahoma_7_grey;
								if (!flag)
								{
									flag = true;
									tahoma_7_grey2 = mFont.tahoma_7_blue;
									tahoma_7_grey2.M898(g, empty, xstart + 5 + ((tahoma_7_grey2 == mFont.tahoma_7_blue && GameCanvas.gameTick % 20 > 10) ? (GameCanvas.gameTick % 4 / 2) : 0), yPaint += 12, 0);
								}
								else
								{
									tahoma_7_grey2.M898(g, "- ...", xstart + 5 + ((tahoma_7_grey2 == mFont.tahoma_7_blue && GameCanvas.gameTick % 20 > 10) ? (GameCanvas.gameTick % 4 / 2) : 0), yPaint += 12, 0);
								}
							}
						}
						else if (Char.M113().taskMaint.index > j)
						{
							mFont.tahoma_7_white.M898(g, empty, xstart + 5, yPaint += 12, 0);
						}
						else
						{
							mFont tahoma_7_grey3 = mFont.tahoma_7_grey;
							if (!flag)
							{
								flag = true;
								tahoma_7_grey3 = mFont.tahoma_7_blue;
								tahoma_7_grey3.M898(g, empty, xstart + 5 + ((tahoma_7_grey3 == mFont.tahoma_7_blue && GameCanvas.gameTick % 20 > 10) ? (GameCanvas.gameTick % 4 / 2) : 0), yPaint += 12, 0);
							}
							else
							{
								tahoma_7_grey3.M898(g, "- ...", xstart + 5 + ((tahoma_7_grey3 == mFont.tahoma_7_blue && GameCanvas.gameTick % 20 > 10) ? (GameCanvas.gameTick % 4 / 2) : 0), yPaint += 12, 0);
							}
						}
						indexRowMax++;
					}
					else if (Char.M113().taskMaint.index <= j)
					{
						empty = "- " + Char.M113().taskMaint.subNames[num2];
						mFont t = mFont.tahoma_7_grey;
						if (!flag)
						{
							flag = true;
							t = mFont.tahoma_7_blue;
						}
						t.M898(g, empty, xstart + 5 + ((t == mFont.tahoma_7_blue && GameCanvas.gameTick % 20 > 10) ? (GameCanvas.gameTick % 4 / 2) : 0), yPaint += 12, 0);
					}
				}
				yPaint += 5;
				for (int k = 0; k < Char.M113().taskMaint.details.Length; k++)
				{
					mFont.tahoma_7_green2.M898(g, Char.M113().taskMaint.details[k], xstart + 5, yPaint += 12, 0);
					indexRowMax++;
				}
			}
			else
			{
				int num3 = GameScr.M659();
				sbyte b = GameScr.M660();
				string empty2 = string.Empty;
				if (num3 != -3 && b != -3)
				{
					if (Char.M113().taskMaint == null && Char.M113().ctaskId == 9 && Char.M113().nClass.classId == 0)
					{
						empty2 = mResources.TASK_INPUT_CLASS;
					}
					else
					{
						if (b < 0 || num3 < 0)
						{
							return;
						}
						empty2 = mResources.DES_TASK[0] + Npc.arrNpcTemplate[b].name + mResources.DES_TASK[1] + TileMap.mapNames[num3] + mResources.DES_TASK[2];
					}
				}
				else
				{
					empty2 = mResources.DES_TASK[3];
				}
				string[] array = mFont.tahoma_7_white.M907(empty2, 150);
				for (int l = 0; l < array.Length; l++)
				{
					if (l == 0)
					{
						mFont.tahoma_7_white.M898(g, array[l], xstart + 5, yPaint = ystart, 0);
					}
					else
					{
						mFont.tahoma_7_white.M898(g, array[l], xstart + 5, yPaint += 12, 0);
					}
				}
			}
		}
		else if (indexMenu == 1)
		{
			yPaint = ystart - 12;
			for (int m = 0; m < Char.M113().taskOrders.M1113(); m++)
			{
				TaskOrder t2 = (TaskOrder)Char.M113().taskOrders.M1114(m);
				mFont.tahoma_7_white.M898(g, t2.name, xstart + 5, yPaint += 12, 0);
				if (t2.count == t2.maxCount)
				{
					mFont.tahoma_7_white.M898(g, ((t2.taskId != 0) ? mResources.KILLBOSS : mResources.KILL) + " " + Mob.arrMobTemplate[t2.killId].name + " (" + t2.count + "/" + t2.maxCount + ")", xstart + 5, yPaint += 12, 0);
				}
				else
				{
					mFont.tahoma_7_blue.M898(g, ((t2.taskId != 0) ? mResources.KILLBOSS : mResources.KILL) + " " + Mob.arrMobTemplate[t2.killId].name + " (" + t2.count + "/" + t2.maxCount + ")", xstart + 5, yPaint += 12, 0);
				}
				indexRowMax += 3;
				inforW = popupW - 25;
				M1379(g, mFont.tahoma_7_grey, t2.description, xstart + 5, yPaint += 12, 0);
				yPaint += 12;
			}
		}
		if (scroll == null)
		{
			scroll = new Scroll();
			scroll.M1566(indexRowMax, 12, xScroll, yScroll, wScroll, hScroll - num - 40, styleUPDOWN: true, 1);
		}
	}

	public void M1378(mGraphics g, mFont f, string[] arr, string str, int x, int y, int align)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			string text = arr[i];
			if (text.StartsWith("c"))
			{
				if (text.StartsWith("c0"))
				{
					text = text.Substring(2);
					f = mFont.tahoma_7b_dark;
				}
				else if (text.StartsWith("c1"))
				{
					text = text.Substring(2);
					f = mFont.tahoma_7b_yellow;
				}
				else if (text.StartsWith("c2"))
				{
					text = text.Substring(2);
					f = mFont.tahoma_7b_green;
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

	public void M1379(mGraphics g, mFont f, string str, int x, int y, int align)
	{
		int num = ((!GameCanvas.isTouch || GameCanvas.w < 320) ? 10 : 20);
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
			((Item)vItemCombine.M1114(i)).isSelect = false;
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
			Char.M113().M244();
		}
		if (chatTField != null && type == 13 && chatTField.isShow)
		{
			chatTField = null;
		}
		if (type == 13 && !isAccept)
		{
			Service.M1594().M1601(3, -1, -1, -1);
		}
		Res.M1513("HIDE PANELLLLLLLLLLLLLLLLLLLLLL");
		SoundMn.M1826().M1856();
		GameScr.isPaint = true;
		TileMap.lastPlanetId = -1;
		imgMap = null;
		mSystem.M1062();
		isClanOption = false;
		isClose = true;
		M1380();
		Hint.M694();
		GameCanvas.panel2 = null;
		GameCanvas.M517();
		GameCanvas.M483();
		pointerDownFirstX = 0;
		pointerDownTime = 0;
		pointerIsDowning = false;
		isShow = false;
		if ((Char.M113().cHP <= 0 || Char.M113().statusMe == 14 || Char.M113().statusMe == 5) && Char.M113().meDead)
		{
			Command center = new Command(mResources.DIES[0], 11038, GameScr.M559());
			GameScr.M559().center = center;
			Char.M113().cHP = 0;
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
			Char.M113().M244();
		}
		if (chatTField != null && type == 13 && chatTField.isShow)
		{
			chatTField = null;
		}
		if (type == 13 && !isAccept)
		{
			Service.M1594().M1601(3, -1, -1, -1);
		}
		if (type == 15)
		{
			Service.M1594().M1736(-1);
		}
		SoundMn.M1826().M1856();
		GameScr.isPaint = true;
		TileMap.lastPlanetId = -1;
		if (imgMap != null)
		{
			imgMap.texture = null;
			imgMap = null;
		}
		mSystem.M1062();
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
		Hint.M694();
		GameCanvas.panel2 = null;
		GameCanvas.M517();
		GameCanvas.M483();
		GameCanvas.isFocusPanel2 = false;
		pointerDownFirstX = 0;
		pointerDownTime = 0;
		pointerIsDowning = false;
		if ((Char.M113().cHP <= 0 || Char.M113().statusMe == 14 || Char.M113().statusMe == 5) && Char.M113().meDead)
		{
			Command center = new Command(mResources.DIES[0], 11038, GameScr.M559());
			GameScr.M559().center = center;
			Char.M113().cHP = 0;
		}
	}

	public void M1383()
	{
		if (GameCanvas.gameTick % 20 == 0)
		{
			Service.M1594().M1654();
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
				chatTField.tfChat.M1931(TField.INPUT_TYPE_NUMERIC);
				chatTField.tfChat.M1929(9);
				if (GameCanvas.isTouch)
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
				chatTField.tfChat.M1931(TField.INPUT_TYPE_NUMERIC);
				chatTField.tfChat.M1929(9);
				if (GameCanvas.isTouch)
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
					if (Equals(GameCanvas.panel2) && GameCanvas.panel.type == 2)
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
		for (int i = 0; i < ClanMessage.vMessage.M1113(); i++)
		{
			((ClanMessage)ClanMessage.vMessage.M1114(i)).M292();
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
			((GameInfo)vGameInfo.M1114(infoSelect)).hasRead = true;
			Rms.M1543(((GameInfo)vGameInfo.M1114(infoSelect)).id + string.Empty, 1);
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
			if (selected == -1 || selected > Char.M114().arrItemBody.Length - 1)
			{
				return;
			}
			MyVector t = new MyVector(string.Empty);
			currItem = Char.M114().arrItemBody[selected];
			if (currItem != null)
			{
				t.M1111(new Command(mResources.MOVEOUT, this, 2006, currItem));
				GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
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
			GameCanvas.M496(mResources.sure_fusion, new Command(mResources.YES, 888351), new Command(mResources.NO, 2001));
			return;
		}
		Service.M1594().M1728((sbyte)selected);
		if (selected < 4)
		{
			Char.M114().petStatus = (sbyte)selected;
		}
	}

	private void M1389()
	{
		if (selected >= -1)
		{
			if (isThachDau)
			{
				Service.M1594().M1723(topName, (sbyte)selected);
				return;
			}
			MyVector t = new MyVector(string.Empty);
			t.M1111(new Command(mResources.CHAR_ORDER[0], this, 9999, (TopInfo)vTop.M1114(selected)));
			GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1281((TopInfo)vTop.M1114(selected));
		}
	}

	private void M1390()
	{
		M1421();
	}

	private void M1391()
	{
		if (currentTabIndex == 0 && Equals(GameCanvas.panel))
		{
			M1396();
			return;
		}
		if ((currentTabIndex == 0 && Equals(GameCanvas.panel2)) || currentTabIndex == 2)
		{
			if (Equals(GameCanvas.panel2))
			{
				currItem = (Item)GameCanvas.panel2.vFriendGD.M1114(selected);
			}
			else
			{
				currItem = (Item)GameCanvas.panel.vFriendGD.M1114(selected);
			}
			Res.M1514("toi day select= " + selected);
			MyVector t = new MyVector();
			t.M1111(new Command(mResources.CLOSE, this, 8000, currItem));
			if (currItem != null)
			{
				GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
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
						Service.M1594().M1601(5, -1, -1, -1);
					}
					else
					{
						M1382();
						InfoDlg.M749();
						Service.M1594().M1601(3, -1, -1, -1);
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
					GameCanvas.M496(mResources.do_u_sure_to_trade, new Command(mResources.YES, this, 7002, null), new Command(mResources.NO, this, 4005, null));
				}
			}
			else
			{
				if (isLock)
				{
					return;
				}
				currItem = (Item)GameCanvas.panel.vMyGD.M1114(selected);
				MyVector t2 = new MyVector();
				t2.M1111(new Command(mResources.CLOSE, this, 8000, currItem));
				if (currItem != null)
				{
					GameCanvas.menu.M876(t2, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
					M1277(currItem);
				}
				else
				{
					cp = null;
				}
			}
		}
		if (GameCanvas.isTouch)
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
				selected = (GameCanvas.isTouch ? (-1) : 0);
				InfoDlg.M749();
				Service.M1594().M1600(1, vItemCombine);
				return;
			}
			if (selected > vItemCombine.M1113() - 1)
			{
				return;
			}
			currItem = (Item)GameCanvas.panel.vItemCombine.M1114(selected);
			MyVector t = new MyVector();
			t.M1111(new Command(mResources.GETOUT, this, 6001, currItem));
			if (currItem != null)
			{
				GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
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
		MyVector t = new MyVector();
		if (currentTabIndex < currentTabName.Length - ((GameCanvas.panel2 == null) ? 1 : 0) && type != 17)
		{
			currItem = Char.M113().arrItemShop[currentTabIndex][selected];
			if (currItem != null)
			{
				if (currItem.isBuySpec)
				{
					if (currItem.buySpec > 0)
					{
						t.M1111(new Command(mResources.buy_with + "\n" + Res.M1533(currItem.buySpec), this, 3005, currItem));
					}
				}
				else if (typeShop == 4)
				{
					t.M1111(new Command(mResources.receive_upper, this, 30001, currItem));
					t.M1111(new Command(mResources.DELETE, this, 30002, currItem));
					t.M1111(new Command(mResources.receive_all, this, 30003, currItem));
				}
				else if (currItem.buyCoin == 0 && currItem.buyGold == 0)
				{
					if ((ulong)currItem.powerRequire > 0uL)
					{
						t.M1111(new Command(mResources.learn_with + "\n" + Res.M1532(currItem.powerRequire) + " \n" + mResources.potential, this, 3004, currItem));
					}
					else
					{
						t.M1111(new Command(mResources.receive_upper + "\n" + mResources.free, this, 3000, currItem));
					}
				}
				else if (typeShop == 8)
				{
					if (currItem.buyCoin > 0)
					{
						t.M1111(new Command(mResources.buy_with + "\n" + Res.M1533(currItem.buyCoin) + "\n" + mResources.XU, this, 30001, currItem));
					}
					if (currItem.buyGold > 0)
					{
						t.M1111(new Command(mResources.buy_with + "\n" + Res.M1533(currItem.buyGold) + "\n" + mResources.LUONG, this, 30002, currItem));
					}
				}
				else if (typeShop != 2)
				{
					if (currItem.buyCoin > 0)
					{
						t.M1111(new Command(mResources.buy_with + "\n" + Res.M1533(currItem.buyCoin) + "\n" + mResources.XU, this, 3000, currItem));
					}
					if (currItem.buyGold > 0)
					{
						t.M1111(new Command(mResources.buy_with + "\n" + Res.M1533(currItem.buyGold) + "\n" + mResources.LUONG, this, 3001, currItem));
					}
				}
				else
				{
					if (currItem.buyCoin != -1)
					{
						t.M1111(new Command(mResources.buy_with + "\n" + Res.M1533(currItem.buyCoin) + "\n" + mResources.XU, this, 10016, currItem));
					}
					if (currItem.buyGold != -1)
					{
						t.M1111(new Command(mResources.buy_with + "\n" + Res.M1533(currItem.buyGold) + "\n" + mResources.LUONG, this, 10017, currItem));
					}
				}
			}
		}
		else if (typeShop == 0)
		{
			if (selected == 0)
			{
				M1461(Char.M113().arrItemBody.Length + Char.M113().arrItemBag.Length, resetSelect: false);
			}
			else
			{
				currItem = null;
				if (!M1454(selected, newSelected, Char.M113().arrItemBody))
				{
					Item t2 = Char.M113().arrItemBag[M1456(selected, newSelected, Char.M113().arrItemBody)];
					if (t2 != null)
					{
						currItem = t2;
					}
				}
				else
				{
					Item t3 = Char.M113().arrItemBody[M1455(selected, newSelected)];
					if (t3 != null)
					{
						currItem = t3;
					}
				}
				if (currItem != null)
				{
					t.M1111(new Command(mResources.SALE, this, 3002, currItem));
				}
			}
		}
		else
		{
			if (type == 17)
			{
				currItem = Char.M113().arrItemShop[4][selected];
			}
			else
			{
				currItem = Char.M113().arrItemShop[currentTabIndex][selected];
			}
			if (currItem.buyType == 0)
			{
				if (currItem.M803(87))
				{
					t.M1111(new Command(mResources.kiguiLuong, this, 10013, currItem));
				}
				else
				{
					t.M1111(new Command(mResources.kiguiXu, this, 10012, currItem));
				}
			}
			else if (currItem.buyType == 1)
			{
				t.M1111(new Command(mResources.huykigui, this, 10014, currItem));
				t.M1111(new Command(mResources.upTop, this, 10018, currItem));
			}
			else if (currItem.buyType == 2)
			{
				t.M1111(new Command(mResources.nhantien, this, 10015, currItem));
			}
		}
		if (currItem != null)
		{
			Char.M113().M243(currItem.headTemp, currItem.bodyTemp, currItem.legTemp, currItem.bagTemp);
			GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1277(currItem);
		}
		else
		{
			cp = null;
		}
	}

	private void M1395()
	{
		if (selected >= 0 && Char.M113().arrArchive[selected].isFinish && !Char.M113().arrArchive[selected].isRecieve)
		{
			if (!GameCanvas.isTouch)
			{
				Service.M1594().M1609(selected);
			}
			else if (GameCanvas.px > xScroll + wScroll - 40)
			{
				Service.M1594().M1609(selected);
			}
		}
	}

	private void M1396()
	{
		Res.M1513("fire inventory");
		if (Char.M113().statusMe == 14)
		{
			GameCanvas.M489(mResources.can_not_do_when_die);
		}
		else
		{
			if (selected == -1)
			{
				return;
			}
			currItem = null;
			MyVector t = new MyVector();
			Item[] arrItemBody = Char.M113().arrItemBody;
			if (selected >= arrItemBody.Length)
			{
				sbyte b = (sbyte)(selected - arrItemBody.Length);
				Item t2 = Char.M113().arrItemBag[b];
				if (t2 != null)
				{
					currItem = t2;
					if (GameCanvas.panel.type == 12)
					{
						t.M1111(new Command(mResources.use_for_combine, this, 6000, currItem));
					}
					else if (GameCanvas.panel.type == 13)
					{
						t.M1111(new Command(mResources.use_for_trade, this, 7000, currItem));
					}
					else if (currItem.M805())
					{
						t.M1111(new Command(mResources.USE, this, 2000, currItem));
						if (Char.M113().havePet)
						{
							t.M1111(new Command(mResources.MOVEFORPET, this, 2005, currItem));
						}
					}
					else
					{
						t.M1111(new Command(mResources.USE, this, 2001, currItem));
					}
				}
			}
			else
			{
				Item t3 = ((selected < 0 || selected >= arrItemBody.Length) ? null : Char.M113().arrItemBody[selected]);
				if (t3 != null)
				{
					currItem = t3;
					t.M1111(new Command(mResources.GETOUT, this, 2002, currItem));
				}
			}
			if (currItem != null)
			{
				Char.M113().M243(currItem.headTemp, currItem.bodyTemp, currItem.legTemp, currItem.bagTemp);
				if (GameCanvas.panel.type != 12 && GameCanvas.panel.type != 13)
				{
					if (position == 0)
					{
						t.M1111(new Command(mResources.MOVEOUT, this, 2003, currItem));
					}
					if (position == 1)
					{
						t.M1111(new Command(mResources.SALE, this, 3002, currItem));
					}
				}
				GameCanvas.menu.M876(t, X, selected * ITEM_HEIGHT - cmy + yScroll);
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
		if (RadarScr.list != null && RadarScr.list.M1113() != 0)
		{
			RadarScr.M1494().switchToMe();
			return;
		}
		Service.M1594().M1741(0, -1);
		RadarScr.M1494().switchToMe();
	}

	private void M1398()
	{
		if (selected < 0)
		{
			return;
		}
		if (!Char.M113().havePet)
		{
			switch (selected)
			{
			case 0:
				M1397();
				break;
			case 1:
				M1382();
				Service.M1594().M1656(54);
				break;
			case 2:
				M1400();
				break;
			case 3:
				Service.M1594().M1726(0, -1);
				InfoDlg.M749();
				break;
			case 4:
				if (Char.M113().statusMe == 14)
				{
					GameCanvas.M489(mResources.can_not_do_when_die);
					break;
				}
				Service.M1594().M1654();
				GameCanvas.panel.M1276();
				GameCanvas.panel.M1285();
				break;
			case 5:
				GameCanvas.M488();
				if (Char.M113().M251() < 5)
				{
					GameCanvas.M489(mResources.not_enough_luong_world_channel);
					break;
				}
				if (chatTField == null)
				{
					chatTField = new ChatTextField();
					chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
					chatTField.M276();
					chatTField.parentScreen = GameCanvas.panel;
				}
				chatTField.strChat = mResources.world_channel_5_luong;
				chatTField.tfChat.name = mResources.CHAT;
				chatTField.to = string.Empty;
				chatTField.isShow = true;
				chatTField.tfChat.isFocus = true;
				chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
				if (Main.isWindowsPhone)
				{
					chatTField.tfChat.strInfo = chatTField.strChat;
				}
				if (!Main.isPC)
				{
					chatTField.M282(this, string.Empty);
				}
				else if (GameCanvas.isTouch)
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
				GameCanvas.loginScr.M868();
				break;
			case 9:
				if (GameCanvas.loginScr.isLogin2)
				{
					SoundMn.M1826().M1874();
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
			Service.M1594().M1656(54);
			break;
		case 2:
			M1400();
			break;
		case 3:
			M1401();
			break;
		case 4:
			Service.M1594().M1726(0, -1);
			InfoDlg.M749();
			break;
		case 5:
			if (Char.M113().statusMe == 14)
			{
				GameCanvas.M489(mResources.can_not_do_when_die);
				break;
			}
			Service.M1594().M1654();
			GameCanvas.panel.M1276();
			GameCanvas.panel.M1285();
			break;
		case 6:
			GameCanvas.M488();
			if (Char.M113().M251() < 5)
			{
				GameCanvas.M489(mResources.not_enough_luong_world_channel);
				break;
			}
			if (chatTField == null)
			{
				chatTField = new ChatTextField();
				chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = GameCanvas.panel;
			}
			chatTField.strChat = mResources.world_channel_5_luong;
			chatTField.tfChat.name = mResources.CHAT;
			chatTField.to = string.Empty;
			chatTField.isShow = true;
			chatTField.tfChat.isFocus = true;
			chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
			if (Main.isWindowsPhone)
			{
				chatTField.tfChat.strInfo = chatTField.strChat;
			}
			if (!Main.isPC)
			{
				chatTField.M282(this, string.Empty);
			}
			else if (GameCanvas.isTouch)
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
			GameCanvas.loginScr.M868();
			break;
		case 10:
			if (GameCanvas.loginScr.isLogin2)
			{
				SoundMn.M1826().M1874();
			}
			break;
		}
	}

	private void M1399()
	{
		string content = ((GameInfo)vGameInfo.M1114(infoSelect)).content;
		contenInfo = mFont.tahoma_7_grey.M907(content, wScroll - 40);
		currentListLength = contenInfo.Length;
		ITEM_HEIGHT = 16;
		selected = (GameCanvas.isTouch ? (-1) : 0);
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
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
		InfoDlg.M749();
		Service.M1594().M1722();
		timeShow = 20;
	}

	private void M1402()
	{
		chatTField.strChat = mResources.input_clan_name;
		chatTField.tfChat.name = mResources.clan_name;
		chatTField.to = string.Empty;
		chatTField.isShow = true;
		chatTField.tfChat.isFocus = true;
		chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
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
		chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
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
		chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
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
			chatTField = new ChatTextField();
			chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
			chatTField.M276();
			chatTField.parentScreen = GameCanvas.panel;
		}
		chatTField.strChat = mResources.input_money_to_trade;
		chatTField.tfChat.name = mResources.input_money;
		chatTField.to = string.Empty;
		chatTField.isShow = true;
		chatTField.tfChat.M1931(TField.INPUT_TYPE_NUMERIC);
		chatTField.tfChat.M1929(9);
		if (GameCanvas.isTouch)
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
			chatTField = new ChatTextField();
			chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
			chatTField.M276();
			chatTField.parentScreen = GameCanvas.panel;
		}
		chatTField.strChat = mResources.input_quantity_to_trade;
		chatTField.tfChat.name = mResources.input_quantity;
		chatTField.to = string.Empty;
		chatTField.isShow = true;
		chatTField.tfChat.M1931(TField.INPUT_TYPE_NUMERIC);
		if (GameCanvas.isTouch)
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
		chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
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
			tabIcon = new TabClanIcon();
		}
		tabIcon.text = chatTField.tfChat.M1924();
		tabIcon.M1886(isGetName: false);
		chatTField.isShow = false;
	}

	private void M1409(InfoItem info)
	{
		string text = string.Concat("|0|1|" + info.charInfo.cName, "\n");
		string text2 = ((!info.isOnline) ? (text + "|3|1|" + mResources.is_offline) : (text + "|4|1|" + mResources.is_online)) + "\n--";
		text = text2 + "\n|5|" + mResources.power + ": " + info.s;
		cp = new ChatPopup();
		M1278(cp, text);
		charInfo = info.charInfo;
		currItem = null;
	}

	private void M1410()
	{
		if (selected >= 0 && vEnemy.M1113() != 0)
		{
			MyVector t = new MyVector();
			currInfoItem = selected;
			t.M1111(new Command(mResources.REVENGE, this, 10000, (InfoItem)vEnemy.M1114(currInfoItem)));
			t.M1111(new Command(mResources.DELETE, this, 10001, (InfoItem)vEnemy.M1114(currInfoItem)));
			t.M1111(new Command(mResources.den, this, 8004, (InfoItem)vEnemy.M1114(currInfoItem)));
			GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1409((InfoItem)vEnemy.M1114(selected));
		}
	}

	private void M1411()
	{
		if (selected >= 0 && vFriend.M1113() != 0)
		{
			MyVector t = new MyVector();
			currInfoItem = selected;
			t.M1111(new Command(mResources.CHAT, this, 8001, (InfoItem)vFriend.M1114(currInfoItem)));
			t.M1111(new Command(mResources.DELETE, this, 8002, (InfoItem)vFriend.M1114(currInfoItem)));
			t.M1111(new Command(mResources.den, this, 8004, (InfoItem)vFriend.M1114(currInfoItem)));
			GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1409((InfoItem)vFriend.M1114(selected));
		}
	}

	private void M1412()
	{
		if (selected >= 0)
		{
			MyVector t = new MyVector();
			currInfoItem = selected;
			t.M1111(new Command(mResources.change_flag, this, 10030, null));
			t.M1111(new Command(mResources.BACK, this, 10031, null));
			GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
		}
	}

	private void M1413()
	{
		if (selected == 0)
		{
			isViewChatServer = !isViewChatServer;
			Rms.M1543("viewchat", isViewChatServer ? 1 : 0);
			if (GameCanvas.isTouch)
			{
				selected = -1;
			}
		}
		else if (selected >= 0 && logChat.M1113() != 0)
		{
			MyVector t = new MyVector();
			currInfoItem = selected - 1;
			t.M1111(new Command(mResources.CHAT, this, 8001, (InfoItem)logChat.M1114(currInfoItem)));
			t.M1111(new Command(mResources.make_friend, this, 8003, (InfoItem)logChat.M1114(currInfoItem)));
			t.M1111(new Command(mResources.den, this, 8004, (InfoItem)logChat.M1114(currInfoItem)));
			GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1417((InfoItem)logChat.M1114(selected - 1));
		}
	}

	private void M1414()
	{
		partID = null;
		charInfo = null;
		Res.M1513("cSelect= " + cSelected);
		if (selected < 0)
		{
			cSelected = -1;
			return;
		}
		if (Char.M113().clan == null)
		{
			if (selected == 0)
			{
				if (cSelected == 0)
				{
					M1402();
				}
				else if (cSelected == 1)
				{
					InfoDlg.M749();
					M1404();
					Service.M1594().M1623(1, -1, null);
				}
			}
			else if (selected != -1)
			{
				if (selected == 1)
				{
					if (isSearchClan)
					{
						Service.M1594().M1618(string.Empty);
					}
					else if (isViewMember && currClan != null)
					{
						GameCanvas.M496(mResources.do_u_want_join_clan + currClan.name, new Command(mResources.YES, this, 4000, currClan), new Command(mResources.NO, this, 4005, currClan));
					}
				}
				else if (isSearchClan)
				{
					currClan = M1346();
					if (currClan != null)
					{
						MyVector t = new MyVector();
						t.M1111(new Command(mResources.request_join_clan, this, 4000, currClan));
						t.M1111(new Command(mResources.view_clan_member, this, 4001, currClan));
						GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
						M1283(M1346());
					}
				}
				else if (isViewMember)
				{
					currMem = M1344();
					if (currMem != null)
					{
						MyVector t2 = new MyVector();
						t2.M1111(new Command(mResources.CLOSE, this, 8000, currClan));
						GameCanvas.menu.M876(t2, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
						GameCanvas.menu.M876(t2, 0, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
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
					Service.M1594().M1614(1, null, -1);
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
					currentListLength = ClanMessage.vMessage.M1113() + 2;
					M1313();
				}
				if (cSelected == 1)
				{
					if (myMember.M1113() > 1)
					{
						Service.M1594().M1621();
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
						Service.M1594().M1623(3, -1, null);
					}
				}
				if (cSelected == 3)
				{
					Service.M1594().M1623(3, -1, null);
				}
			}
		}
		else if (selected == 1)
		{
			if (isSearchClan)
			{
				Service.M1594().M1618(string.Empty);
			}
		}
		else if (isSearchClan)
		{
			currClan = M1346();
			if (currClan != null)
			{
				MyVector t3 = new MyVector();
				t3.M1111(new Command(mResources.view_clan_member, this, 4001, currClan));
				GameCanvas.menu.M876(t3, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1283(M1346());
			}
		}
		else if (isViewMember)
		{
			Res.M1513("TOI DAY 1");
			currMem = M1344();
			if (currMem != null)
			{
				MyVector t4 = new MyVector();
				Res.M1513("TOI DAY 2");
				if (member != null)
				{
					t4.M1111(new Command(mResources.CLOSE, this, 8000, null));
					Res.M1513("TOI DAY 3");
				}
				else if (myMember != null)
				{
					Res.M1513("TOI DAY 4");
					Res.M1513("my role= " + Char.M113().role);
					if (Char.M113().charID == currMem.ID || Char.M113().role == 2)
					{
						t4.M1111(new Command(mResources.CLOSE, this, 8000, currMem));
					}
					if (Char.M113().role < 2 && Char.M113().charID != currMem.ID)
					{
						Res.M1513("TOI DAY");
						if (currMem.role == 0 || currMem.role == 1)
						{
							t4.M1111(new Command(mResources.CLOSE, this, 8000, currMem));
						}
						if (currMem.role == 2)
						{
							t4.M1111(new Command(mResources.create_clan_co_leader, this, 5002, currMem));
						}
						if (Char.M113().role == 0)
						{
							t4.M1111(new Command(mResources.create_clan_leader, this, 5001, currMem));
							if (currMem.role == 1)
							{
								t4.M1111(new Command(mResources.disable_clan_mastership, this, 5003, currMem));
							}
						}
					}
					if (Char.M113().role < currMem.role)
					{
						t4.M1111(new Command(mResources.kick_clan_mem, this, 5004, currMem));
					}
				}
				GameCanvas.menu.M876(t4, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
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
					MyVector t5 = new MyVector();
					t5.M1111(new Command(mResources.CLOSE, this, 8000, currMess));
					GameCanvas.menu.M876(t5, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
					M1280(currMess);
				}
				else if (currMess.type == 1)
				{
					if (currMess.playerId != Char.M113().charID && cSelected != -1)
					{
						Service.M1594().M1613(currMess.id);
					}
				}
				else if (currMess.type == 2 && currMess.option != null)
				{
					if (cSelected == 0)
					{
						Service.M1594().M1616(currMess.id, 1);
					}
					else if (cSelected == 1)
					{
						Service.M1594().M1616(currMess.id, 0);
					}
				}
			}
		}
		if (GameCanvas.isTouch)
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
		if (Char.M113().statusMe == 14)
		{
			GameCanvas.M489(mResources.can_not_do_when_die);
			return;
		}
		if (selected != 0 && selected != 1 && selected != 2 && selected != 3 && selected != 4 && selected != 5)
		{
			int num = selected;
			SkillTemplate t = Char.M113().nClass.skillTemplates[num - 6];
			Skill t2 = Char.M113().M119(t);
			Skill t3 = null;
			MyVector t4 = new MyVector();
			if (t2 != null)
			{
				if (t2.point == t.maxPoint)
				{
					t4.M1111(new Command(mResources.make_shortcut, this, 9003, t2.template));
					t4.M1111(new Command(mResources.CLOSE, 2));
				}
				else
				{
					t3 = t.skills[t2.point];
					t4.M1111(new Command(mResources.UPGRADE, this, 9002, t3));
					t4.M1111(new Command(mResources.make_shortcut, this, 9003, t2.template));
				}
			}
			else
			{
				t3 = t.skills[0];
				t4.M1111(new Command(mResources.learn, this, 9004, t3));
			}
			GameCanvas.menu.M876(t4, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
			M1284(t, t2, t3);
			return;
		}
		long cTiemNang = Char.M113().cTiemNang;
		int cHPGoc = Char.M113().cHPGoc;
		int cMPGoc = Char.M113().cMPGoc;
		int cDamGoc = Char.M113().cDamGoc;
		int cDefGoc = Char.M113().cDefGoc;
		_ = Char.M113().cCriticalGoc;
		int num2 = 1000;
		if (selected == 0)
		{
			if (cTiemNang < Char.M113().cHPGoc + num2)
			{
				GameCanvas.M491(mResources.not_enough_potential_point1 + Char.M113().cTiemNang + mResources.not_enough_potential_point2 + (Char.M113().cHPGoc + num2), isError: false);
				return;
			}
			if (cTiemNang > cHPGoc && cTiemNang < 10 * (2 * (cHPGoc + num2) + 180) / 2)
			{
				GameCanvas.M496(mResources.use_potential_point_for1 + (cHPGoc + num2) + mResources.use_potential_point_for2 + Char.M113().hpFrom1000TiemNang + mResources.for_HP, new Command(mResources.increase_upper, this, 9000, null), new Command(mResources.CANCEL, this, 4007, null));
				return;
			}
			if (cTiemNang >= 10 * (2 * (cHPGoc + num2) + 180) / 2 && cTiemNang < 100 * (2 * (cHPGoc + num2) + 1980) / 2)
			{
				MyVector t5 = new MyVector();
				t5.M1111(new Command(mResources.increase_upper + "\n" + Char.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + (cHPGoc + num2), this, 9000, null));
				t5.M1111(new Command(mResources.increase_upper + "\n" + 10 * Char.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + 10 * (2 * (cHPGoc + num2) + 180) / 2, this, 9006, null));
				GameCanvas.menu.M876(t5, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
			if (cTiemNang >= 100 * (2 * (cHPGoc + num2) + 1980) / 2)
			{
				MyVector t6 = new MyVector();
				t6.M1111(new Command(mResources.increase_upper + "\n" + Char.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + (cHPGoc + num2), this, 9000, null));
				t6.M1111(new Command(mResources.increase_upper + "\n" + 10 * Char.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + 10 * (2 * (cHPGoc + num2) + 180) / 2, this, 9006, null));
				t6.M1111(new Command(mResources.increase_upper + "\n" + 100 * Char.M113().hpFrom1000TiemNang + mResources.HP + "\n-" + 100 * (2 * (cHPGoc + num2) + 1980) / 2, this, 9007, null));
				GameCanvas.menu.M876(t6, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
		}
		if (selected == 1)
		{
			if (Char.M113().cTiemNang < Char.M113().cMPGoc + num2)
			{
				GameCanvas.M491(mResources.not_enough_potential_point1 + Char.M113().cTiemNang + mResources.not_enough_potential_point2 + (Char.M113().cMPGoc + num2), isError: false);
				return;
			}
			if (cTiemNang > cMPGoc && cTiemNang < 10 * (2 * (cMPGoc + num2) + 180) / 2)
			{
				GameCanvas.M496(mResources.use_potential_point_for1 + (cMPGoc + num2) + mResources.use_potential_point_for2 + Char.M113().mpFrom1000TiemNang + mResources.for_KI, new Command(mResources.increase_upper, this, 9000, null), new Command(mResources.CANCEL, this, 4007, null));
				return;
			}
			if (cTiemNang >= 10 * (2 * (cMPGoc + num2) + 180) / 2 && cTiemNang < 100 * (2 * (cMPGoc + num2) + 1980) / 2)
			{
				MyVector t7 = new MyVector();
				t7.M1111(new Command(mResources.increase_upper + "\n" + Char.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + (cHPGoc + num2), this, 9000, null));
				t7.M1111(new Command(mResources.increase_upper + "\n" + 10 * Char.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + 10 * (2 * (cHPGoc + num2) + 180) / 2, this, 9006, null));
				GameCanvas.menu.M876(t7, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
			if (cTiemNang >= 100 * (2 * (cMPGoc + num2) + 1980) / 2)
			{
				MyVector t8 = new MyVector();
				t8.M1111(new Command(mResources.increase_upper + "\n" + Char.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + (cMPGoc + num2), this, 9000, null));
				t8.M1111(new Command(mResources.increase_upper + "\n" + 10 * Char.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + 10 * (2 * (cMPGoc + num2) + 180) / 2, this, 9006, null));
				t8.M1111(new Command(mResources.increase_upper + "\n" + 100 * Char.M113().mpFrom1000TiemNang + mResources.KI + "\n-" + 100 * (2 * (cMPGoc + num2) + 1980) / 2, this, 9007, null));
				GameCanvas.menu.M876(t8, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
		}
		if (selected == 2)
		{
			if (Char.M113().cTiemNang < Char.M113().cDamGoc * Char.M113().expForOneAdd)
			{
				GameCanvas.M491(mResources.not_enough_potential_point1 + Char.M113().cTiemNang + mResources.not_enough_potential_point2 + cDamGoc * 100, isError: false);
				return;
			}
			if (cTiemNang > cDamGoc && cTiemNang < 10 * (2 * cDamGoc + 9) / 2 * Char.M113().expForOneAdd)
			{
				GameCanvas.M496(mResources.use_potential_point_for1 + cDamGoc * 100 + mResources.use_potential_point_for2 + Char.M113().damFrom1000TiemNang + mResources.for_hit_point, new Command(mResources.increase_upper, this, 9000, null), new Command(mResources.CANCEL, this, 4007, null));
				return;
			}
			if (cTiemNang >= 10 * (2 * cDamGoc + 9) / 2 * Char.M113().expForOneAdd && cTiemNang < 100 * (2 * cDamGoc + 99) / 2 * Char.M113().expForOneAdd)
			{
				MyVector t9 = new MyVector();
				t9.M1111(new Command(mResources.increase_upper + "\n" + Char.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + cDamGoc * 100, this, 9000, null));
				t9.M1111(new Command(mResources.increase_upper + "\n" + 10 * Char.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + 10 * (2 * cDamGoc + 9) / 2 * Char.M113().expForOneAdd, this, 9006, null));
				GameCanvas.menu.M876(t9, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
			if (cTiemNang >= 100 * (2 * cDamGoc + 99) / 2 * Char.M113().expForOneAdd)
			{
				MyVector t10 = new MyVector();
				t10.M1111(new Command(mResources.increase_upper + "\n" + Char.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + cDamGoc * 100, this, 9000, null));
				t10.M1111(new Command(mResources.increase_upper + "\n" + 10 * Char.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + 10 * (2 * cDamGoc + 9) / 2 * Char.M113().expForOneAdd, this, 9006, null));
				t10.M1111(new Command(mResources.increase_upper + "\n" + 100 * Char.M113().damFrom1000TiemNang + "\n" + mResources.hit_point + "\n-" + 100 * (2 * cDamGoc + 99) / 2 * Char.M113().expForOneAdd, this, 9007, null));
				GameCanvas.menu.M876(t10, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
				M1418(selected);
			}
		}
		if (selected == 3)
		{
			if (Char.M113().cTiemNang < 50000 + Char.M113().cDefGoc * 1000)
			{
				GameCanvas.M491(mResources.not_enough_potential_point1 + NinjaUtil.M1192(Char.M113().cTiemNang) + mResources.not_enough_potential_point2 + NinjaUtil.M1192(50000 + Char.M113().cDefGoc * 1000), isError: false);
				return;
			}
			int num3 = 2 * (cDefGoc + 5) / 2 * 100000;
			GameCanvas.M496(mResources.use_potential_point_for1 + NinjaUtil.M1192(num3) + mResources.use_potential_point_for2 + Char.M113().defFrom1000TiemNang + mResources.for_armor, new Command(mResources.increase_upper, this, 9000, null), new Command(mResources.CANCEL, this, 4007, null));
		}
		else if (selected == 4)
		{
			long num4 = 50000000L;
			for (int i = 0; i < Char.M113().cCriticalGoc; i++)
			{
				num4 *= 5L;
			}
			if (Char.M113().cTiemNang < num4)
			{
				GameCanvas.M491(mResources.not_enough_potential_point1 + NinjaUtil.M1192(Char.M113().cTiemNang) + mResources.not_enough_potential_point2 + NinjaUtil.M1192(num4), isError: false);
				return;
			}
			GameCanvas.M496(mResources.use_potential_point_for1 + NinjaUtil.M1192(num4) + mResources.use_potential_point_for2 + Char.M113().criticalFrom1000Tiemnang + mResources.for_crit, new Command(mResources.increase_upper, this, 9000, null), new Command(mResources.CANCEL, this, 4007, null));
		}
		else if (selected == 5)
		{
			Service.M1594().M1603(0);
		}
	}

	private void M1417(InfoItem info)
	{
		string chat = string.Concat(string.Concat(string.Concat("|0|1|" + info.charInfo.cName, "\n"), "\n--"), "\n|5|", Res.M1531(info.s, "|", 0)[2]);
		cp = new ChatPopup();
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
			num = Char.M113().cHPGoc + 1000;
		}
		if (selected == 1)
		{
			num = Char.M113().cMPGoc + 1000;
		}
		if (selected == 2)
		{
			num = Char.M113().cDamGoc * Char.M113().expForOneAdd;
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
		cp = new ChatPopup();
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
		TileMap.lastPlanetId = -1;
		mSystem.M1062();
		SmallImage.M1777();
		M1275();
		cmtoX = 0;
		cmx = 0;
	}

	private void M1421()
	{
		if (selected != -1)
		{
			Res.M1513("FIRE ZONE");
			isChangeZone = true;
			GameCanvas.panel.M1382();
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
		MyVector t = new MyVector();
		if (currentTabIndex == 0 && !Equals(GameCanvas.panel2))
		{
			Item t2 = Char.M113().arrItemBox[selected];
			if (t2 != null)
			{
				if (isBoxClan)
				{
					t.M1111(new Command(mResources.GETOUT, this, 1000, t2));
					t.M1111(new Command(mResources.USE, this, 2010, t2));
				}
				else if (t2.M805())
				{
					t.M1111(new Command(mResources.GETOUT, this, 1000, t2));
				}
				else
				{
					t.M1111(new Command(mResources.GETOUT, this, 1000, t2));
				}
				currItem = t2;
			}
		}
		if (currentTabIndex == 1 || Equals(GameCanvas.panel2))
		{
			Item[] arrItemBody = Char.M113().arrItemBody;
			if (selected >= arrItemBody.Length)
			{
				sbyte b = (sbyte)(selected - arrItemBody.Length);
				Item t3 = Char.M113().arrItemBag[b];
				if (t3 != null)
				{
					t.M1111(new Command(mResources.move_to_chest, this, 1001, t3));
					if (t3.M805())
					{
						t.M1111(new Command(mResources.USE, this, 2000, t3));
					}
					else
					{
						t.M1111(new Command(mResources.USE, this, 2001, t3));
					}
					currItem = t3;
				}
			}
			else
			{
				Item t4 = Char.M113().arrItemBody[M1455(selected + 1, newSelected)];
				if (t4 != null)
				{
					t.M1111(new Command(mResources.move_to_chest2, this, 1002, t4));
					currItem = t4;
				}
			}
		}
		if (currItem != null)
		{
			Char.M113().M243(currItem.headTemp, currItem.bodyTemp, currItem.legTemp, currItem.bagTemp);
			if (isBoxClan)
			{
				t.M1111(new Command(mResources.MOVEOUT, this, 2011, currItem));
			}
			GameCanvas.menu.M876(t, X, (selected + 1) * ITEM_HEIGHT - cmy + yScroll);
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
		GameCanvas.M488();
		ItemObject t = new ItemObject();
		t.type = itemAction;
		t.id = index;
		t.where = where;
		GameCanvas.M496(info, new Command(mResources.YES, this, 2004, t), new Command(mResources.NO, this, 4005, null));
	}

	public void M1425(sbyte type, string info, short id)
	{
		ItemObject t = new ItemObject();
		t.type = type;
		t.id = id;
		GameCanvas.M496(info, new Command(mResources.YES, this, 3003, t), new Command(mResources.NO, this, 4005, null));
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 9999)
		{
			TopInfo t = (TopInfo)p;
			Service.M1594().M1736(t.pId);
		}
		if (idAction == 170391)
		{
			Rms.M1547();
			if (mGraphics.zoomLevel > 1)
			{
				Rms.M1543("levelScreenKN", 1);
			}
			else
			{
				Rms.M1543("levelScreenKN", 0);
			}
			GameMidlet.instance.M520();
		}
		if (idAction == 6001)
		{
			Item t2 = (Item)p;
			t2.isSelect = false;
			GameCanvas.panel.vItemCombine.M1119(t2);
			if (GameCanvas.panel.currentTabIndex == 0)
			{
				GameCanvas.panel.M1271();
			}
		}
		if (idAction == 6000)
		{
			Item t3 = (Item)p;
			for (int i = 0; i < GameCanvas.panel.vItemCombine.M1113(); i++)
			{
				if (((Item)GameCanvas.panel.vItemCombine.M1114(i)).template.id == t3.template.id)
				{
					GameCanvas.M489(mResources.already_has_item);
					return;
				}
			}
			t3.isSelect = true;
			GameCanvas.panel.vItemCombine.M1111(t3);
			if (GameCanvas.panel.currentTabIndex == 0)
			{
				GameCanvas.panel.M1271();
			}
		}
		if (idAction == 7000)
		{
			if (isLock)
			{
				GameCanvas.M489(mResources.unlock_item_to_trade);
				return;
			}
			Item t4 = (Item)p;
			for (int j = 0; j < GameCanvas.panel.vMyGD.M1113(); j++)
			{
				if (((Item)GameCanvas.panel.vMyGD.M1114(j)).indexUI == t4.indexUI)
				{
					GameCanvas.M489(mResources.already_has_item);
					return;
				}
			}
			if (t4.quantity > 1)
			{
				M1406();
				return;
			}
			t4.isSelect = true;
			Item t5 = new Item();
			t5.template = t4.template;
			t5.itemOption = t4.itemOption;
			t5.indexUI = t4.indexUI;
			GameCanvas.panel.vMyGD.M1111(t5);
			Service.M1594().M1601(2, -1, (sbyte)t5.indexUI, t5.quantity);
		}
		if (idAction == 7001)
		{
			Item t6 = (Item)p;
			t6.isSelect = false;
			GameCanvas.panel.vMyGD.M1119(t6);
			if (GameCanvas.panel.currentTabIndex == 1)
			{
				GameCanvas.panel.M1296(isMe: true);
			}
			Service.M1594().M1601(4, -1, (sbyte)t6.indexUI, -1);
		}
		if (idAction == 7002)
		{
			isAccept = true;
			GameCanvas.M488();
			Service.M1594().M1601(7, -1, -1, -1);
			M1382();
		}
		if (idAction == 8003)
		{
			InfoItem t7 = (InfoItem)p;
			Service.M1594().M1608(1, t7.charInfo.charID);
		}
		if (idAction == 8002)
		{
			InfoItem t8 = (InfoItem)p;
			Service.M1594().M1608(2, t8.charInfo.charID);
		}
		if (idAction == 8004)
		{
			InfoItem t9 = (InfoItem)p;
			Service.M1594().M1595(t9.charInfo.charID);
		}
		if (idAction == 8001)
		{
			Res.M1513("chat player");
			InfoItem t10 = (InfoItem)p;
			if (chatTField == null)
			{
				chatTField = new ChatTextField();
				chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = GameCanvas.panel;
			}
			chatTField.strChat = mResources.chat_player;
			chatTField.tfChat.name = mResources.chat_with + " " + t10.charInfo.cName;
			chatTField.to = string.Empty;
			chatTField.isShow = true;
			chatTField.tfChat.isFocus = true;
			chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
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
			Service.M1594().M1625(BOX_BAG, (sbyte)selected);
		}
		if (idAction == 1001)
		{
			Item[] arrItemBody = Char.M113().arrItemBody;
			sbyte id = (sbyte)(selected - arrItemBody.Length);
			Service.M1594().M1625(BAG_BOX, id);
		}
		if (idAction == 1003)
		{
			M1382();
		}
		if (idAction == 1002)
		{
			Service.M1594().M1625(BODY_BOX, (sbyte)selected);
		}
		if (idAction == 2011)
		{
			Service.M1594().M1615(1, 2, (sbyte)selected, -1);
		}
		if (idAction == 2010)
		{
			Service.M1594().M1615(0, 2, (sbyte)selected, 0);
			Item t11 = (Item)p;
			if (t11 != null && (t11.template.id == 193 || t11.template.id == 194))
			{
				GameCanvas.panel.M1382();
			}
		}
		if (idAction == 2000)
		{
			Item[] arrItemBody2 = Char.M113().arrItemBody;
			sbyte id2 = (sbyte)(selected - arrItemBody2.Length);
			Service.M1594().M1625(BAG_BODY, id2);
		}
		if (idAction == 2001)
		{
			Res.M1513("use item");
			Item t12 = (Item)p;
			bool flag = selected < Char.M113().arrItemBody.Length;
			sbyte b = 0;
			if (!flag)
			{
				b = (sbyte)(selected - Char.M113().arrItemBody.Length);
			}
			Service.M1594().M1615(0, (!flag) ? ((sbyte)1) : ((sbyte)0), (sbyte)((!flag) ? b : selected), t12.template.id);
			if (t12.template.id == 193 || t12.template.id == 194)
			{
				GameCanvas.panel.M1382();
			}
		}
		if (idAction == 2002)
		{
			Service.M1594().M1625(BODY_BAG, (sbyte)selected);
		}
		if (idAction == 2003)
		{
			Res.M1513("remove item");
			bool flag2 = selected < Char.M113().arrItemBody.Length;
			sbyte b2 = 0;
			b2 = (flag2 ? ((sbyte)selected) : ((sbyte)(selected - Char.M113().arrItemBody.Length)));
			Service.M1594().M1615(1, (!flag2) ? ((sbyte)1) : ((sbyte)0), b2, -1);
		}
		if (idAction == 2004)
		{
			GameCanvas.M488();
			ItemObject t13 = (ItemObject)p;
			sbyte where = (sbyte)t13.where;
			sbyte index = (sbyte)t13.id;
			Service.M1594().M1615((sbyte)((t13.type != 0) ? 2 : 3), where, index, -1);
		}
		if (idAction == 2005)
		{
			int num = M1456(selected + 1, newSelected, Char.M113().arrItemBody);
			Service.M1594().M1625(BAG_PET, (sbyte)num);
		}
		if (idAction == 2006)
		{
			_ = Char.M114().arrItemBody;
			int num2 = selected;
			Service.M1594().M1625(PET_BAG, (sbyte)num2);
		}
		if (idAction == 30001)
		{
			Res.M1513("nhan do");
			Service.M1594().M1651(0, selected, 0);
		}
		if (idAction == 30002)
		{
			Res.M1513("xoa do");
			Service.M1594().M1651(1, selected, 0);
		}
		if (idAction == 30003)
		{
			Res.M1513("nhan tat");
			Service.M1594().M1651(2, selected, 0);
		}
		if (idAction == 3000)
		{
			Res.M1513("mua do");
			Item t14 = (Item)p;
			Service.M1594().M1651(0, t14.template.id, 0);
		}
		if (idAction == 3001)
		{
			Item t15 = (Item)p;
			GameCanvas.msgdlg.M1035();
			Service.M1594().M1651(1, t15.template.id, 0);
		}
		if (idAction == 3002)
		{
			GameCanvas.M488();
			bool flag3 = M1454(selected, newSelected, Char.M113().arrItemBody);
			sbyte b3 = 0;
			b3 = (flag3 ? ((sbyte)M1455(selected, newSelected)) : ((sbyte)M1456(selected, newSelected, Char.M113().arrItemBody)));
			Service.M1594().M1650(0, (!flag3) ? ((sbyte)1) : ((sbyte)0), b3);
		}
		if (idAction == 3003)
		{
			GameCanvas.M488();
			ItemObject t16 = (ItemObject)p;
			Service.M1594().M1650(1, (sbyte)t16.type, (short)t16.id);
		}
		if (idAction == 3004)
		{
			Item t17 = (Item)p;
			Service.M1594().M1651(3, t17.template.id, 0);
		}
		if (idAction == 3005)
		{
			Res.M1513("mua do");
			Item t18 = (Item)p;
			Service.M1594().M1651(3, t18.template.id, 0);
		}
		if (idAction == 4000)
		{
			Clan t19 = (Clan)p;
			if (t19 != null)
			{
				GameCanvas.M488();
				Service.M1594().M1614(2, null, t19.ID);
			}
		}
		if (idAction == 4001)
		{
			Clan t20 = (Clan)p;
			if (t20 != null)
			{
				InfoDlg.M749();
				clanReport = mResources.PLEASEWAIT;
				Service.M1594().M1617(t20.ID);
			}
		}
		if (idAction == 4005)
		{
			GameCanvas.M488();
		}
		if (idAction == 4007)
		{
			GameCanvas.M488();
		}
		if (idAction == 4006)
		{
			ClanMessage t21 = (ClanMessage)p;
			Service.M1594().M1613(t21.id);
		}
		if (idAction == 5001)
		{
			Member t22 = (Member)p;
			Service.M1594().M1620(t22.ID, 0);
		}
		if (idAction == 5002)
		{
			Member t23 = (Member)p;
			Service.M1594().M1620(t23.ID, 1);
		}
		if (idAction == 5003)
		{
			Member t24 = (Member)p;
			Service.M1594().M1620(t24.ID, 2);
		}
		if (idAction == 5004)
		{
			Member t25 = (Member)p;
			Service.M1594().M1620(t25.ID, -1);
		}
		if (idAction == 9000)
		{
			Service.M1594().M1719(selected, 1);
			GameCanvas.M488();
			InfoDlg.M749();
		}
		if (idAction == 9006)
		{
			Service.M1594().M1719(selected, 10);
			GameCanvas.M488();
			InfoDlg.M749();
		}
		if (idAction == 9007)
		{
			Service.M1594().M1719(selected, 100);
			GameCanvas.M488();
			InfoDlg.M749();
		}
		if (idAction == 9002)
		{
			Skill t26 = (Skill)p;
			GameCanvas.M489(mResources.can_buy_from_Uron1 + t26.powRequire + mResources.can_buy_from_Uron2 + t26.moreInfo + mResources.can_buy_from_Uron3);
		}
		if (idAction == 9003)
		{
			if (GameCanvas.isTouch && !Main.isPC)
			{
				GameScr.M559().M545((SkillTemplate)p);
			}
			else
			{
				GameScr.M559().M546((SkillTemplate)p);
			}
		}
		if (idAction == 9004)
		{
			Skill t27 = (Skill)p;
			GameCanvas.M489(mResources.can_buy_from_Uron1 + t27.powRequire + mResources.can_buy_from_Uron2 + t27.moreInfo + mResources.can_buy_from_Uron3);
		}
		if (idAction == 10000)
		{
			InfoItem t28 = (InfoItem)p;
			Service.M1594().M1724(1, t28.charInfo.charID);
			GameCanvas.panel.M1381();
		}
		if (idAction == 10001)
		{
			InfoItem t29 = (InfoItem)p;
			Service.M1594().M1724(2, t29.charInfo.charID);
			InfoDlg.M749();
		}
		if (idAction == 10012)
		{
			if (chatTField == null)
			{
				chatTField = new ChatTextField();
				chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = ((GameCanvas.panel2 != null) ? GameCanvas.panel2 : GameCanvas.panel);
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
			chatTField.tfChat.M1931(TField.INPUT_TYPE_NUMERIC);
			if (GameCanvas.isTouch)
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
				chatTField = new ChatTextField();
				chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = ((GameCanvas.panel2 != null) ? GameCanvas.panel2 : GameCanvas.panel);
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
			chatTField.tfChat.M1931(TField.INPUT_TYPE_NUMERIC);
			if (GameCanvas.isTouch)
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
			Item t30 = (Item)p;
			Service.M1594().M1725(1, t30.itemId, -1, -1, -1);
			InfoDlg.M749();
		}
		if (idAction == 10015)
		{
			Item t31 = (Item)p;
			Service.M1594().M1725(2, t31.itemId, -1, -1, -1);
			InfoDlg.M749();
		}
		if (idAction == 10016)
		{
			Item t32 = (Item)p;
			Service.M1594().M1725(3, t32.itemId, 0, t32.buyCoin, -1);
			InfoDlg.M749();
		}
		if (idAction == 10017)
		{
			Item t33 = (Item)p;
			Service.M1594().M1725(3, t33.itemId, 1, t33.buyGold, -1);
			InfoDlg.M749();
		}
		if (idAction == 10018)
		{
			Item t34 = (Item)p;
			Service.M1594().M1725(5, t34.itemId, -1, -1, -1);
			InfoDlg.M749();
		}
		if (idAction == 10019)
		{
			Session_ME.M1744().close();
			Rms.M1538("acc", string.Empty);
			Rms.M1538("pass", string.Empty);
			GameCanvas.loginScr.tfPass.M1926(string.Empty);
			GameCanvas.loginScr.tfUser.M1926(string.Empty);
			GameCanvas.loginScr.isLogin2 = false;
			GameCanvas.loginScr.switchToMe();
			GameCanvas.M488();
			M1382();
		}
		if (idAction == 10020)
		{
			GameCanvas.M488();
		}
		if (idAction == 10030)
		{
			Service.M1594().M1726(1, (sbyte)selected);
			GameCanvas.panel.M1381();
		}
		if (idAction == 10031)
		{
			Session_ME.M1744().close();
		}
		if (idAction == 11000)
		{
			Service.M1594().M1725(0, currItem.itemId, 1, currItem.buyRuby, 1);
			GameCanvas.M488();
		}
		if (idAction == 11001)
		{
			Service.M1594().M1725(0, currItem.itemId, 1, currItem.buyRuby, currItem.quantilyToBuy);
			GameCanvas.M488();
		}
		if (idAction == 11002)
		{
			chatTField.isShow = false;
			GameCanvas.M488();
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (chatTField.tfChat.M1924() != null && !chatTField.tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (chatTField.strChat.Equals(mResources.input_clan_name))
			{
				InfoDlg.M749();
				chatTField.isShow = false;
				Service.M1594().M1618(text);
				return;
			}
			if (chatTField.strChat.Equals(mResources.chat_clan))
			{
				InfoDlg.M749();
				chatTField.isShow = false;
				Service.M1594().M1614(0, text, -1);
				return;
			}
			if (chatTField.strChat.Equals(mResources.input_clan_name_to_create))
			{
				if (chatTField.tfChat.M1924() == string.Empty)
				{
					GameScr.info1.M762(mResources.clan_name_blank, 0);
					return;
				}
				if (tabIcon == null)
				{
					tabIcon = new TabClanIcon();
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
					GameScr.info1.M762(mResources.clan_slogan_blank, 0);
					return;
				}
				Service.M1594().M1623(4, (sbyte)Char.M113().clan.imgID, chatTField.tfChat.M1924());
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
						Service.M1594().M1727(pass);
						chatTField.isShow = false;
						chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
						M1382();
					}
					else
					{
						GameCanvas.M489(mResources.input_Inventory_Pass_wrong);
					}
					return;
				}
				catch (Exception)
				{
					GameCanvas.M489(mResources.ALERT_PRIVATE_PASS_2);
					return;
				}
			}
			if (chatTField.strChat.Equals(mResources.world_channel_5_luong))
			{
				if (!chatTField.tfChat.M1924().Equals(string.Empty))
				{
					Service.M1594().M1694(chatTField.tfChat.M1924());
					chatTField.isShow = false;
					M1382();
				}
			}
			else if (chatTField.strChat.Equals(mResources.chat_player))
			{
				chatTField.isShow = false;
				InfoItem t = null;
				if (type == 8)
				{
					t = (InfoItem)logChat.M1114(currInfoItem);
				}
				else if (type == 11)
				{
					t = (InfoItem)vFriend.M1114(currInfoItem);
				}
				if (t.charInfo.charID != Char.M113().charID)
				{
					Service.M1594().M1693(text, t.charInfo.charID);
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
					GameCanvas.M489(mResources.input_quantity_wrong);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
					return;
				}
				if (num > 0 && num <= currItem.quantity)
				{
					currItem.isSelect = true;
					Item t2 = new Item();
					t2.template = currItem.template;
					t2.quantity = num;
					t2.indexUI = currItem.indexUI;
					t2.itemOption = currItem.itemOption;
					GameCanvas.panel.vMyGD.M1111(t2);
					Service.M1594().M1601(2, -1, (sbyte)t2.indexUI, t2.quantity);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
				}
				else
				{
					GameCanvas.M489(mResources.input_quantity_wrong);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
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
					GameCanvas.M489(mResources.input_money_wrong);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
					return;
				}
				if (num2 > Char.M113().xu)
				{
					GameCanvas.M489(mResources.not_enough_money);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
				}
				else
				{
					moneyGD = num2;
					Service.M1594().M1601(2, -1, -1, num2);
					chatTField.isShow = false;
					chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
				}
			}
			else if (chatTField.strChat.Equals(mResources.kiguiXuchat))
			{
				Service.M1594().M1725(0, currItem.itemId, 0, int.Parse(chatTField.tfChat.M1924()), 1);
				chatTField.isShow = false;
			}
			else if (chatTField.strChat.Equals(mResources.kiguiXuchat + " "))
			{
				Service.M1594().M1725(0, currItem.itemId, 0, int.Parse(chatTField.tfChat.M1924()), currItem.quantilyToBuy);
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
					GameCanvas.M489(mResources.input_quantity_wrong);
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
					GameCanvas.M489(mResources.input_quantity_wrong);
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
		chatTField.tfChat.M1931(TField.INPUT_TYPE_ANY);
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
				Item t = (Item)vItemCombine.M1114(i);
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
				Item t2 = (Item)vItemCombine.M1114(j);
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
				Item t3 = (Item)vItemCombine.M1114(k);
				if (t3 != null)
				{
					iconID1 = t3.template.iconID;
				}
			}
		}
		else if (typeCombine == 3)
		{
			xS = GameCanvas.hw;
			yS = GameCanvas.hh;
			iDotS = 1;
			angleO = 1;
			angleS = 1;
			time = 4;
			for (int l = 0; l < vItemCombine.M1113(); l++)
			{
				Item t4 = (Item)vItemCombine.M1114(l);
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
				Item t5 = (Item)vItemCombine.M1114(m);
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
						if (GameCanvas.gameTick % 10 == 0)
						{
							EffectMn.M376(new Effect(21, xS - 10, yS + 25, 4, 1, 1));
							time--;
						}
					}
					else
					{
						if (GameCanvas.gameTick % 2 == 0)
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
								else if (GameCanvas.gameTick % 10 == 0)
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
							else if (GameCanvas.gameTick % 10 == 0)
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
			else if (GameCanvas.gameTick % 20 == 0)
			{
				isCompleteEffCombine = true;
			}
			if (GameCanvas.gameTick % 20 == 0)
			{
				if (typeCombine != 3)
				{
					EffectPanel.M415(132, xS, yS, 2);
				}
				EffectPanel.M415(114, xS, yS + 20, 2);
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
					EffectMn.M376(new Effect(22, xS - 3, yS + 25, 4, 1, 1));
				}
				countWait--;
				if (countWait < 0)
				{
					countWait = 0;
				}
				if (rS < 300)
				{
					rS = Res.M1529(rS + 10);
					if (rS == 20)
					{
						M1431(idNPC, mResources.combineFail);
					}
				}
				else if (GameCanvas.gameTick % 20 == 0)
				{
					if (GameCanvas.w > 2 * WIDTH_PANEL)
					{
						GameCanvas.panel2 = new Panel();
						GameCanvas.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
						GameCanvas.panel2.M1253();
						GameCanvas.panel2.M1285();
					}
					combineSuccess = -1;
					isDoneCombine = true;
					if (typeCombine == 4)
					{
						GameCanvas.panel.M1381();
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
						EffectMn.M376(new Effect(20, xS - 3, yS + 15, 4, 2, 1));
					}
					else
					{
						EffectMn.M376(new Effect(21, xS - 10, yS + 25, 4, 1, 1));
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
					if (typeCombine < 3 && GameCanvas.w > 2 * WIDTH_PANEL)
					{
						GameCanvas.panel2 = new Panel();
						GameCanvas.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
						GameCanvas.panel2.M1253();
						GameCanvas.panel2.M1285();
					}
					combineSuccess = -1;
					isDoneCombine = true;
					if (typeCombine == 4)
					{
						GameCanvas.panel.M1381();
					}
				}
			}
		}
	}

	public void M1428(mGraphics g)
	{
		GameScr.M559().M619(g);
		M1430(g);
		if (typeCombine == 0)
		{
			for (int i = 0; i < yArgS.Length; i++)
			{
				SmallImage.M1785(g, iconID1, xS, yS, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				if (isPaintCombine)
				{
					SmallImage.M1785(g, iconID2, xDotS[i], yDotS[i], 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
		}
		else if (typeCombine == 1)
		{
			if (!isPaintCombine)
			{
				SmallImage.M1785(g, iconID3, xS, yS, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				return;
			}
			for (int j = 0; j < yArgS.Length; j++)
			{
				SmallImage.M1785(g, iconID1, xDotS[0], yDotS[0], 0, mGraphics.VCENTER | mGraphics.HCENTER);
				SmallImage.M1785(g, iconID2, xDotS[1], yDotS[1], 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
		}
		else if (typeCombine == 2)
		{
			if (!isPaintCombine)
			{
				SmallImage.M1785(g, iconID3, xS, yS, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				return;
			}
			for (int k = 0; k < yArgS.Length; k++)
			{
				SmallImage.M1785(g, iconID1, xDotS[k], yDotS[k], 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
		}
		else if (typeCombine == 3)
		{
			if (!isPaintCombine)
			{
				SmallImage.M1785(g, iconID3, xS, yS, 0, mGraphics.VCENTER | mGraphics.HCENTER);
			}
			else
			{
				SmallImage.M1785(g, iconID1, xS, yS, 0, mGraphics.VCENTER | mGraphics.HCENTER);
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
					SmallImage.M1785(g, iconID3, xS, yS, 0, mGraphics.VCENTER | mGraphics.HCENTER);
				}
			}
			else
			{
				for (int l = 0; l < iconID.Length; l++)
				{
					SmallImage.M1785(g, iconID[l], xDotS[l], yDotS[l], 0, mGraphics.VCENTER | mGraphics.HCENTER);
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
			yArgS[i] = Res.M1529(rS * Res.M1507(angleS) / 1024);
			xArgS[i] = Res.M1529(rS * Res.M1508(angleS) / 1024);
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

	public void M1430(mGraphics g)
	{
		g.M918(-GameScr.cmx, -GameScr.cmy);
		if (typeCombine < 3)
		{
			for (int i = 0; i < GameScr.vNpc.M1113(); i++)
			{
				Npc t = (Npc)GameScr.vNpc.M1114(i);
				if (t.template.npcTemplateId == idNPC)
				{
					t.paint(g);
					if (t.chatInfo != null)
					{
						t.chatInfo.M741(g, t.cx, t.cy - t.ch - GameCanvas.transY, t.cdir);
					}
				}
			}
		}
		GameCanvas.M451(g);
		if (GameCanvas.gameTick % 4 == 0)
		{
			g.M948(ItemMap.imageFlare, xS - 5, yS + 15, mGraphics.BOTTOM | mGraphics.HCENTER);
			g.M948(ItemMap.imageFlare, xS + 5, yS + 15, mGraphics.BOTTOM | mGraphics.HCENTER);
			g.M948(ItemMap.imageFlare, xS, yS + 15, mGraphics.BOTTOM | mGraphics.HCENTER);
		}
		for (int j = 0; j < Effect2.vEffect3.M1113(); j++)
		{
			((Effect2)Effect2.vEffect3.M1114(j)).paint(g);
		}
	}

	public void M1431(int idNPC, string text)
	{
		if (typeCombine >= 3)
		{
			return;
		}
		for (int i = 0; i < GameScr.vNpc.M1113(); i++)
		{
			Npc t = (Npc)GameScr.vNpc.M1114(i);
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
		SoundMn.M1826().M1829();
		currentListLength = strCauhinh.Length;
		ITEM_HEIGHT = 24;
		selected = (GameCanvas.isTouch ? (-1) : 0);
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

	private void M1434(mGraphics g)
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
				mFont.tahoma_7b_dark.M898(g, strCauhinh[i], xScroll + wScroll / 2, num + 6, mFont.CENTER);
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
			SoundMn.M1826().M1839();
			break;
		case 1:
			SoundMn.M1826().M1838();
			break;
		case 2:
			SoundMn.M1826().M1837();
			break;
		case 3:
			if (Main.isPC)
			{
				GameCanvas.M496(mResources.changeSizeScreen, new Command(mResources.YES, this, 170391, null), new Command(mResources.NO, this, 4005, null));
				break;
			}
			if (GameScr.isAnalog == 0)
			{
				GameScr.isAnalog = 1;
				Rms.M1543("analog", GameScr.isAnalog);
				GameScr.M565();
			}
			else
			{
				GameScr.isAnalog = 0;
				Rms.M1543("analog", GameScr.isAnalog);
				GameScr.M565();
			}
			SoundMn.M1826().M1829();
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
			if (GameScr.canAutoPlay)
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
			if (GameScr.canAutoPlay)
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
			if ((mSystem.clientType == 2 || mSystem.clientType == 7) && mResources.language != 2)
			{
				strAccount = new string[5]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.charger
				};
				if (GameScr.canAutoPlay)
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
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

	private void M1438(mGraphics g)
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
				mFont.tahoma_7b_dark.M898(g, strAccount[i], xScroll + wScroll / 2, num + 6, mFont.CENTER);
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
			GameCanvas.M488();
			if (chatTField == null)
			{
				chatTField = new ChatTextField();
				chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = GameCanvas.panel;
			}
			chatTField.tfChat.M1926(string.Empty);
			chatTField.strChat = mResources.input_Inventory_Pass;
			chatTField.tfChat.name = mResources.input_Inventory_Pass;
			chatTField.to = string.Empty;
			chatTField.isShow = true;
			chatTField.tfChat.isFocus = true;
			chatTField.tfChat.M1931(TField.INPUT_TYPE_NUMERIC);
			if (GameCanvas.isTouch)
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
			Service.M1594().M1608(0, -1);
			InfoDlg.M749();
			break;
		case 2:
			Service.M1594().M1724(0, -1);
			InfoDlg.M749();
			break;
		case 3:
			M1266();
			if (chatTField == null)
			{
				chatTField = new ChatTextField();
				chatTField.tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
				chatTField.M276();
				chatTField.parentScreen = GameCanvas.panel;
			}
			break;
		case 4:
			if (mResources.language == 2)
			{
				string url = "http://dragonball.indonaga.com/coda/?username=" + GameCanvas.loginScr.tfUser.M1924();
				M1381();
				try
				{
					GameMidlet.instance.M524(url);
					break;
				}
				catch (Exception ex)
				{
					ex.StackTrace.ToString();
					break;
				}
			}
			M1381();
			if (Char.M113().taskMaint.taskId <= 10)
			{
				GameCanvas.M489(mResources.finishBomong);
			}
			else
			{
				MoneyCharge.M1013().switchToMe();
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
		currentListLength = Char.M113().infoSpeacialSkill[currentTabIndex].Length;
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
		selected = (GameCanvas.isTouch ? (-1) : 0);
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
			GameCanvas.M489(mResources.input_money_wrong);
			chatTField.isShow = false;
			return;
		}
		Command cmdYes = new Command(mResources.YES, this, (type != 0) ? 11001 : 11000, null);
		Command cmdNo = new Command(mResources.NO, this, 11002, null);
		GameCanvas.M496(mResources.notiRuby, cmdYes, cmdNo);
	}

	public static void M1445(int x, int y, int wItem, int hItem, int nline, int cl, mGraphics g)
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
					int x2 = x + M1446(num * i, GameCanvas.gameTick - j * 4, wItem, hItem, wSize);
					int y2 = y + M1447(num * i, GameCanvas.gameTick - j * 4, wItem, hItem, wSize);
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

	public static mFont M1450(int color)
	{
		mFont result = mFont.tahoma_7;
		switch (color)
		{
		case -1:
			result = mFont.tahoma_7;
			break;
		case 0:
			result = mFont.tahoma_7b_dark;
			break;
		case 1:
			result = mFont.tahoma_7b_green;
			break;
		case 2:
			result = mFont.tahoma_7b_blue;
			break;
		case 3:
			result = mFont.tahoma_7_red;
			break;
		case 4:
			result = mFont.tahoma_7_green;
			break;
		case 5:
			result = mFont.tahoma_7_blue;
			break;
		case 7:
			result = mFont.tahoma_7b_red;
			break;
		case 8:
			result = mFont.tahoma_7b_yellow;
			break;
		}
		return result;
	}

	public void M1451(mGraphics g, int idOpt, int param, int x, int y, int w, int h)
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
				imgo_0 = mSystem.M1071("/mainImage/o_0.png");
			}
			if (imgo_1 != null)
			{
				g.M950(imgo_1, x, y + h - imgo_1.M728());
			}
			else
			{
				imgo_1 = mSystem.M1071("/mainImage/o_1.png");
			}
			break;
		case 35:
			if (imgo_0 != null)
			{
				g.M950(imgo_0, x, y + h - imgo_0.M728());
			}
			else
			{
				imgo_0 = mSystem.M1071("/mainImage/o_0.png");
			}
			if (imgo_2 != null)
			{
				g.M950(imgo_2, x, y + h - imgo_2.M728());
			}
			else
			{
				imgo_2 = mSystem.M1071("/mainImage/o_2.png");
			}
			break;
		case 36:
			if (imgo_0 != null)
			{
				g.M950(imgo_0, x, y + h - imgo_0.M728());
			}
			else
			{
				imgo_0 = mSystem.M1071("/mainImage/o_0.png");
			}
			if (imgo_3 != null)
			{
				g.M950(imgo_3, x, y + h - imgo_3.M728());
			}
			else
			{
				imgo_3 = mSystem.M1071("/mainImage/o_3.png");
			}
			break;
		}
	}

	public void M1452(mGraphics g, int idOpt, int param, int x, int y, int w, int h)
	{
		if (idOpt == 102 && param > ChatPopup.numSlot)
		{
			int cl = M1449(param);
			M1445(x, y, w, h, param - ChatPopup.numSlot, cl, g);
		}
	}

	public static mFont M1453(int id, int type)
	{
		if (type == 0)
		{
			return id switch
			{
				0 => mFont.bigNumber_While, 
				1 => mFont.bigNumber_green, 
				3 => mFont.bigNumber_orange, 
				4 => mFont.bigNumber_blue, 
				5 => mFont.bigNumber_yellow, 
				6 => mFont.bigNumber_red, 
				_ => mFont.bigNumber_While, 
			};
		}
		return id switch
		{
			0 => mFont.tahoma_7b_white, 
			1 => mFont.tahoma_7b_green, 
			3 => mFont.tahoma_7b_yellowSmall2, 
			4 => mFont.tahoma_7b_blue, 
			5 => mFont.tahoma_7b_yellow, 
			6 => mFont.tahoma_7b_red, 
			7 => mFont.tahoma_7b_dark, 
			_ => mFont.tahoma_7b_white, 
		};
	}

	private bool M1454(int select, int subSelect, Item[] arrItem)
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

	private int M1456(int select, int subSelect, Item[] arrItem)
	{
		return select - 1 + subSelect * 20 - arrItem.Length;
	}

	private void M1457()
	{
		if (selected < 0)
		{
			return;
		}
		if (GameCanvas.keyPressed[(!Main.isPC) ? 4 : 23])
		{
			newSelected--;
			if (newSelected < 0)
			{
				newSelected = 0;
				if (GameCanvas.isFocusPanel2)
				{
					GameCanvas.isFocusPanel2 = false;
					GameCanvas.panel.selected = 0;
				}
			}
		}
		else
		{
			if (!GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24])
			{
				return;
			}
			newSelected++;
			if (newSelected > size_tab - 1)
			{
				newSelected = size_tab - 1;
				if (GameCanvas.panel2 != null)
				{
					GameCanvas.isFocusPanel2 = true;
					GameCanvas.panel2.selected = 0;
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
		newSelected = (GameCanvas.px - num2) / TAB_W_NEW;
		if (newSelected > num - 1)
		{
			newSelected = num - 1;
		}
		if (GameCanvas.px < num2)
		{
			newSelected = 0;
		}
		M1323(resetSelect);
	}
}
