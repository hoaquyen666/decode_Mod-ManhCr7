using System;
using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using Utilities;
using Xmap;
using UnityEngine;

public class GameScr : mScreen, IChatable
{
	public MyVector BossVip = new MyVector();

	public static bool isPaintOther;

	public static MyVector textTime;

	public static bool isLoadAllData;

	public static GameScr instance;

	public static int gW;

	public static int gH;

	public static int gW2;

	public static int gssw;

	public static int gssh;

	public static int gH34;

	public static int gW3;

	public static int gH3;

	public static int gH23;

	public static int gW23;

	public static int gH2;

	public static int csPadMaxH;

	public static int cmdBarH;

	public static int gW34;

	public static int gW6;

	public static int gH6;

	public static int cmx;

	public static int cmy;

	public static int cmdx;

	public static int cmdy;

	public static int cmvx;

	public static int cmvy;

	public static int cmtoX;

	public static int cmtoY;

	public static int cmxLim;

	public static int cmyLim;

	public static int gssx;

	public static int gssy;

	public static int gssxe;

	public static int gssye;

	public Command cmdback;

	public Command cmdBag;

	public Command cmdSkill;

	public Command cmdTiemnang;

	public Command cmdtrangbi;

	public Command cmdInfo;

	public Command cmdFocus;

	public Command cmdFire;

	public static int d;

	public static int hpPotion;

	public static SkillPaint[] sks;

	public static Arrowpaint[] arrs;

	public static DartInfo[] darts;

	public static Part[] parts;

	public static EffectCharPaint[] efs;

	public static int lockTick;

	private int moveUp;

	private int moveDow;

	private int idTypeTask;

	private bool isstarOpen;

	private bool isChangeSkill;

	public static MyVector vClan;

	public static MyVector vPtMap;

	public static MyVector vFriend;

	public static MyVector vEnemies;

	public static MyVector vCharInMap;

	public static MyVector vItemMap;

	public static MyVector vMobAttack;

	public static MyVector vSet;

	public static MyVector vMob;

	public static MyVector vNpc;

	public static MyVector vFlag;

	public static NClass[] nClasss;

	public static int indexSize;

	public static int indexTitle;

	public static int indexSelect;

	public static int indexRow;

	public static int indexRowMax;

	public static int indexMenu;

	public Item itemFocus;

	public ItemOptionTemplate[] iOptionTemplates;

	public SkillOptionTemplate[] sOptionTemplates;

	private static Scroll scrInfo;

	public static Scroll scrMain;

	public static MyVector vItemUpGrade;

	public static bool isTypeXu;

	public static bool isViewNext;

	public static bool isViewClanMemOnline;

	public static bool isViewClanInvite;

	public static bool isChop;

	public static string titleInputText;

	public static int tickMove;

	public static bool isPaintAlert;

	public static bool isPaintTask;

	public static bool isPaintTeam;

	public static bool isPaintFindTeam;

	public static bool isPaintFriend;

	public static bool isPaintEnemies;

	public static bool isPaintItemInfo;

	public static bool isHaveSelectSkill;

	public static bool isPaintSkill;

	public static bool isPaintInfoMe;

	public static bool isPaintStore;

	public static bool isPaintNonNam;

	public static bool isPaintNonNu;

	public static bool isPaintAoNam;

	public static bool isPaintAoNu;

	public static bool isPaintGangTayNam;

	public static bool isPaintGangTayNu;

	public static bool isPaintQuanNam;

	public static bool isPaintQuanNu;

	public static bool isPaintGiayNam;

	public static bool isPaintGiayNu;

	public static bool isPaintLien;

	public static bool isPaintNhan;

	public static bool isPaintNgocBoi;

	public static bool isPaintPhu;

	public static bool isPaintWeapon;

	public static bool isPaintStack;

	public static bool isPaintStackLock;

	public static bool isPaintGrocery;

	public static bool isPaintGroceryLock;

	public static bool isPaintUpGrade;

	public static bool isPaintConvert;

	public static bool isPaintUpGradeGold;

	public static bool isPaintUpPearl;

	public static bool isPaintBox;

	public static bool isPaintSplit;

	public static bool isPaintCharInMap;

	public static bool isPaintTrade;

	public static bool isPaintZone;

	public static bool isPaintMessage;

	public static bool isPaintClan;

	public static bool isRequestMember;

	public static Char currentCharViewInfo;

	public static long[] exps;

	public static int[] crystals;

	public static int[] upClothe;

	public static int[] upAdorn;

	public static int[] upWeapon;

	public static int[] coinUpCrystals;

	public static int[] coinUpClothes;

	public static int[] coinUpAdorns;

	public static int[] coinUpWeapons;

	public static int[] maxPercents;

	public static int[] goldUps;

	public int tMenuDelay;

	public int zoneCol = 6;

	public int[] zones;

	public int[] pts;

	public int[] numPlayer;

	public int[] maxPlayer;

	public int[] rank1;

	public int[] rank2;

	public string[] rankName1;

	public string[] rankName2;

	public int typeTrade;

	public int typeTradeOrder;

	public int coinTrade;

	public int coinTradeOrder;

	public int timeTrade;

	public int indexItemUse = -1;

	public int cLastFocusID = -1;

	public int cPreFocusID = -1;

	public bool isLockKey;

	public static int[] tasks;

	public static int[] mapTasks;

	public static Image imgRoomStat;

	public static Image frBarPow0;

	public static Image frBarPow1;

	public static Image frBarPow2;

	public static Image frBarPow20;

	public static Image frBarPow21;

	public static Image frBarPow22;

	public MyVector texts;

	public string textsTitle;

	public static sbyte vcData;

	public static sbyte vcMap;

	public static sbyte vcSkill;

	public static sbyte vcItem;

	public static sbyte vsData;

	public static sbyte vsMap;

	public static sbyte vsSkill;

	public static sbyte vsItem;

	public static sbyte vcTask;

	public static Image imgArrow;

	public static Image imgArrow2;

	public static Image imgChat;

	public static Image imgChat2;

	public static Image imgMenu;

	public static Image imgFocus;

	public static Image imgFocus2;

	public static Image imgSkill;

	public static Image imgSkill2;

	public static Image imgHP1;

	public static Image imgHP2;

	public static Image imgHP3;

	public static Image imgHP4;

	public static Image imgFire0;

	public static Image imgFire1;

	public static Image imgLbtn;

	public static Image imgLbtnFocus;

	public static Image imgLbtn2;

	public static Image imgLbtnFocus2;

	public static Image imgAnalog1;

	public static Image imgAnalog2;

	public string tradeName = string.Empty;

	public string tradeItemName = string.Empty;

	public int timeLengthMap;

	public int timeStartMap;

	public static sbyte typeViewInfo;

	public static sbyte typeActive;

	public static InfoMe info1;

	public static InfoMe info2;

	public static Image imgPanel;

	public static Image imgPanel2;

	public static Image imgHP;

	public static Image imgMP;

	public static Image imgSP;

	public static Image imgHPLost;

	public static Image imgMPLost;

	public Mob mobCapcha;

	public MagicTree magicTree;

	public static int countEff;

	public static GamePad gamePad;

	public static Image imgChatPC;

	public static Image imgChatsPC2;

	public static int isAnalog;

	public static bool isUseTouch;

	public const int numSkill = 10;

	public const int numSkill_2 = 5;

	public static Skill[] keySkill;

	public static Skill[] onScreenSkill;

	public Command cmdMenu;

	public static int firstY;

	public static int wSkill;

	public static long deltaTime;

	public bool isPointerDowning;

	public bool isChangingCameraMode;

	private int ptLastDownX;

	private int ptLastDownY;

	private int ptFirstDownX;

	private int ptFirstDownY;

	private int ptDownTime;

	private bool disableSingleClick;

	public long lastSingleClick;

	public bool clickMoving;

	public bool clickOnTileTop;

	public bool clickMovingRed;

	private int clickToX;

	private int clickToY;

	private int lastClickCMX;

	private int lastClickCMY;

	private int clickMovingP1;

	private int clickMovingTimeOut;

	private long lastMove;

	public static bool isNewClanMessage;

	private long lastFire;

	private long lastUsePotion;

	public int auto;

	public int dem;

	private string strTam = string.Empty;

	private int a;

	public bool isFreez;

	public bool isUseFreez;

	public static Image imgTrans;

	public bool isRongThanXuatHien;

	public bool isRongNamek;

	public bool isSuperPower;

	public int tPower;

	public int xPower;

	public int yPower;

	public int dxPower;

	public bool activeRongThan;

	public bool isMeCallRongThan;

	public int mautroi;

	public int mapRID;

	public int zoneRID;

	public int bgRID = -1;

	public static int tam;

	public static bool isAutoPlay;

	public static bool canAutoPlay;

	public static bool isChangeZone;

	private int timeSkill;

	private int nSkill;

	private int selectedIndexSkill = -1;

	private Skill lastSkill;

	private bool doSeleckSkillFlag;

	public string strCapcha;

	private long longPress;

	private int move;

	public bool flareFindFocus;

	private int flareTime;

	public int keyTouchSkill = -1;

	private long lastSendUpdatePostion;

	public static long lastTick;

	public static long currTick;

	private int timeAuto;

	public static long lastXS;

	public static long currXS;

	public static int secondXS;

	public int runArrow;

	public static int isPaintRada;

	public static Image imgNut;

	public static Image imgNutF;

	public int[] keyCapcha;

	public static Image imgCapcha;

	public string keyInput;

	public static int disXC;

	public static bool isPaint;

	public static int shock_scr;

	private static int[] shock_x;

	private static int[] shock_y;

	private int tDoubleDelay;

	public static Image arrow;

	private static int yTouchBar;

	private static int xC;

	private static int yC;

	private static int xL;

	private static int yL;

	public int xR;

	public int yR;

	private static int xU;

	private static int yU;

	private static int xF;

	private static int yF;

	public static int xHP;

	public static int yHP;

	private static int xTG;

	private static int yTG;

	public static int[] xS;

	public static int[] yS;

	public static int xSkill;

	public static int ySkill;

	public static int padSkill;

	public int dMP;

	public int twMp;

	public bool isInjureMp;

	public int dHP;

	public int twHp;

	public bool isInjureHp;

	private long curr;

	private long last;

	private int secondVS;

	private int[] idVS = new int[2] { -1, -1 };

	public static string[] flyTextString;

	public static int[] flyTextX;

	public static int[] flyTextY;

	public static int[] flyTextYTo;

	public static int[] flyTextDx;

	public static int[] flyTextDy;

	public static int[] flyTextState;

	public static int[] flyTextColor;

	public static int[] flyTime;

	public static int[] splashX;

	public static int[] splashY;

	public static int[] splashState;

	public static int[] splashF;

	public static int[] splashDir;

	public static Image[] imgSplash;

	public static int cmdBarX;

	public static int cmdBarY;

	public static int cmdBarW;

	public static int cmdBarLeftW;

	public static int cmdBarRightW;

	public static int cmdBarCenterW;

	public static int hpBarX;

	public static int hpBarY;

	public static int hpBarW;

	public static int spBarW;

	public static int mpBarW;

	public static int expBarW;

	public static int lvPosX;

	public static int moneyPosX;

	public static int hpBarH;

	public static int girlHPBarY;

	public static Image[] imgCmdBar;

	private int imgScrW;

	public static int popupY;

	public static int popupX;

	public static int isborderIndex;

	public static int isselectedRow;

	private static Image imgNolearn;

	public int cmxp;

	public int cmvxp;

	public int cmdxp;

	public int cmxLimp;

	public int cmyLimp;

	public int cmyp;

	public int cmvyp;

	public int cmdyp;

	private int indexTiemNang;

	private string alertURL;

	private string fnick;

	public static int xstart;

	public static int ystart;

	public static int popupW;

	public static int popupH;

	public static int cmySK;

	public static int cmtoYSK;

	public static int cmdySK;

	public static int cmvySK;

	public static int cmyLimSK;

	public static int columns;

	public static int rows;

	private int totalRowInfo;

	private int ypaintKill;

	private int ylimUp;

	private int ylimDow;

	private int yPaint;

	public static int indexEff;

	public static EffectCharPaint effUpok;

	public static int inforX;

	public static int inforY;

	public static int inforW;

	public static int inforH;

	public Command cmdDead;

	public static bool notPaint;

	public static bool isPing;

	public static int INFO;

	public static int STORE;

	public static int ZONE;

	public static int UPGRADE;

	private int Hitem = 30;

	private int maxSizeRow = 5;

	private int isTranKyNang;

	private bool isTran;

	private int cmY_Old;

	private int cmX_Old;

	public PopUpYesNo popUpYesNo;

	public static MyVector vChatVip;

	public static int vBig;

	public bool isFireWorks;

	public int[] winnumber;

	public int[] randomNumber;

	public int[] tMove;

	public int[] moveCount;

	public int[] delayMove;

	public int moveIndex;

	private bool isWin;

	private string strFinish;

	private int tShow;

	private int xChatVip;

	private int currChatWidth;

	private bool startChat;

	public sbyte percentMabu;

	public bool mabuEff;

	public int tMabuEff;

	public static bool isPaintChatVip;

	public static sbyte mabuPercent;

	public static sbyte isNewMember;

	private string yourNumber = string.Empty;

	private string[] strPaint;

	public static Image imgHP_NEW;

	public static InfoPhuBan phuban_Info;

	public static FrameImage fra_PVE_Bar_0;

	public static FrameImage fra_PVE_Bar_1;

	public static Image imgVS;

	public static Image imgBall;

	public static Image imgKhung;

	public GameScr()
	{
		if (GameCanvas.w == 128 || GameCanvas.h <= 208)
		{
			indexSize = 20;
		}
		cmdback = new Command(string.Empty, 11021);
		cmdMenu = new Command("menu", 11000);
		cmdFocus = new Command(string.Empty, 11001);
		cmdMenu.img = imgMenu;
		cmdMenu.w = mGraphics.M958(cmdMenu.img) + 20;
		cmdMenu.isPlaySoundButton = false;
		cmdFocus.img = imgFocus;
		if (GameCanvas.isTouch)
		{
			cmdMenu.x = 0;
			cmdMenu.y = 50;
			cmdFocus = null;
		}
		else
		{
			cmdMenu.x = 0;
			cmdMenu.y = gH - 30;
			cmdFocus.x = gW - 32;
			cmdFocus.y = gH - 32;
		}
		right = cmdFocus;
		isPaintRada = 1;
		if (GameCanvas.isTouch)
		{
			isHaveSelectSkill = true;
		}
	}

	static GameScr()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		isPaintOther = false;
		textTime = new MyVector(string.Empty);
		isLoadAllData = false;
		vClan = new MyVector();
		vPtMap = new MyVector();
		vFriend = new MyVector();
		vEnemies = new MyVector();
		vCharInMap = new MyVector();
		vItemMap = new MyVector();
		vMobAttack = new MyVector();
		vSet = new MyVector();
		vMob = new MyVector();
		vNpc = new MyVector();
		vFlag = new MyVector();
		indexSize = 28;
		indexTitle = 0;
		indexSelect = 0;
		indexRow = -1;
		indexMenu = 0;
		scrInfo = new Scroll();
		scrMain = new Scroll();
		vItemUpGrade = new MyVector();
		isViewClanMemOnline = false;
		isViewClanInvite = true;
		titleInputText = string.Empty;
		isPaintAlert = false;
		isPaintTask = false;
		isPaintTeam = false;
		isPaintFindTeam = false;
		isPaintFriend = false;
		isPaintEnemies = false;
		isPaintItemInfo = false;
		isHaveSelectSkill = false;
		isPaintSkill = false;
		isPaintInfoMe = false;
		isPaintStore = false;
		isPaintNonNam = false;
		isPaintNonNu = false;
		isPaintAoNam = false;
		isPaintAoNu = false;
		isPaintGangTayNam = false;
		isPaintGangTayNu = false;
		isPaintQuanNam = false;
		isPaintQuanNu = false;
		isPaintGiayNam = false;
		isPaintGiayNu = false;
		isPaintLien = false;
		isPaintNhan = false;
		isPaintNgocBoi = false;
		isPaintPhu = false;
		isPaintWeapon = false;
		isPaintStack = false;
		isPaintStackLock = false;
		isPaintGrocery = false;
		isPaintGroceryLock = false;
		isPaintUpGrade = false;
		isPaintConvert = false;
		isPaintUpGradeGold = false;
		isPaintUpPearl = false;
		isPaintBox = false;
		isPaintSplit = false;
		isPaintCharInMap = false;
		isPaintTrade = false;
		isPaintZone = false;
		isPaintMessage = false;
		isPaintClan = false;
		isRequestMember = false;
		typeViewInfo = 0;
		typeActive = 0;
		info1 = new InfoMe();
		info2 = new InfoMe();
		gamePad = new GamePad();
		isAnalog = 0;
		keySkill = new Skill[10];
		onScreenSkill = new Skill[10];
		tam = 0;
		isPaint = true;
		shock_x = new int[4] { 3, -3, 3, -3 };
		shock_y = new int[4] { 3, -3, -3, 3 };
		popupW = 140;
		popupH = 160;
		columns = 6;
		indexEff = 0;
		notPaint = false;
		isPing = false;
		INFO = 0;
		STORE = 1;
		ZONE = 2;
		UPGRADE = 3;
		vChatVip = new MyVector();
	}

	public static void M531()
	{
		fra_PVE_Bar_0 = new FrameImage(mSystem.M1071("/mainImage/i_pve_bar_0.png"), 6, 15);
		fra_PVE_Bar_1 = new FrameImage(mSystem.M1071("/mainImage/i_pve_bar_1.png"), 38, 21);
		imgVS = mSystem.M1071("/mainImage/i_vs.png");
		imgBall = mSystem.M1071("/mainImage/i_charlife.png");
		imgHP_NEW = mSystem.M1071("/mainImage/i_hp.png");
		imgKhung = mSystem.M1071("/mainImage/i_khung.png");
		imgLbtn = GameCanvas.M503("/mainImage/myTexture2dbtnl.png");
		imgLbtnFocus = GameCanvas.M503("/mainImage/myTexture2dbtnlf.png");
		imgLbtn2 = GameCanvas.M503("/mainImage/myTexture2dbtnl2.png");
		imgLbtnFocus2 = GameCanvas.M503("/mainImage/myTexture2dbtnlf2.png");
		imgPanel = GameCanvas.M503("/mainImage/myTexture2dpanel.png");
		imgPanel2 = GameCanvas.M503("/mainImage/panel2.png");
		imgHP = GameCanvas.M503("/mainImage/myTexture2dHP.png");
		imgSP = GameCanvas.M503("/mainImage/SP.png");
		imgHPLost = GameCanvas.M503("/mainImage/myTexture2dhpLost.png");
		imgMPLost = GameCanvas.M503("/mainImage/myTexture2dmpLost.png");
		imgMP = GameCanvas.M503("/mainImage/myTexture2dMP.png");
		imgSkill = GameCanvas.M503("/mainImage/myTexture2dskill.png");
		imgSkill2 = GameCanvas.M503("/mainImage/myTexture2dskill2.png");
		imgMenu = GameCanvas.M503("/mainImage/myTexture2dmenu.png");
		imgFocus = GameCanvas.M503("/mainImage/myTexture2dfocus.png");
		imgChatPC = GameCanvas.M503("/pc/chat.png");
		imgChatsPC2 = GameCanvas.M503("/pc/chat2.png");
		if (GameCanvas.isTouch)
		{
			imgArrow = GameCanvas.M503("/mainImage/myTexture2darrow.png");
			imgArrow2 = GameCanvas.M503("/mainImage/myTexture2darrow2.png");
			imgChat = GameCanvas.M503("/mainImage/myTexture2dchat.png");
			imgChat2 = GameCanvas.M503("/mainImage/myTexture2dchat2.png");
			imgFocus2 = GameCanvas.M503("/mainImage/myTexture2dfocus2.png");
			imgHP1 = GameCanvas.M503("/mainImage/myTexture2dPea0.png");
			imgHP2 = GameCanvas.M503("/mainImage/myTexture2dPea1.png");
			imgAnalog1 = GameCanvas.M503("/mainImage/myTexture2danalog1.png");
			imgAnalog2 = GameCanvas.M503("/mainImage/myTexture2danalog2.png");
			imgHP3 = GameCanvas.M503("/mainImage/myTexture2dPea2.png");
			imgHP4 = GameCanvas.M503("/mainImage/myTexture2dPea3.png");
			imgFire0 = GameCanvas.M503("/mainImage/myTexture2dfirebtn0.png");
			imgFire1 = GameCanvas.M503("/mainImage/myTexture2dfirebtn1.png");
		}
		flyTextX = new int[5];
		flyTextY = new int[5];
		flyTextDx = new int[5];
		flyTextDy = new int[5];
		flyTextState = new int[5];
		flyTextString = new string[5];
		flyTextYTo = new int[5];
		flyTime = new int[5];
		flyTextColor = new int[8];
		for (int i = 0; i < 5; i++)
		{
			flyTextState[i] = -1;
		}
		sbyte[] array = Rms.M1535("NRdataVersion");
		sbyte[] array2 = Rms.M1535("NRmapVersion");
		sbyte[] array3 = Rms.M1535("NRskillVersion");
		sbyte[] array4 = Rms.M1535("NRitemVersion");
		if (array != null)
		{
			vcData = array[0];
		}
		if (array2 != null)
		{
			vcMap = array2[0];
		}
		if (array3 != null)
		{
			vcSkill = array3[0];
		}
		if (array4 != null)
		{
			vcItem = array4[0];
		}
		imgNut = GameCanvas.M503("/mainImage/myTexture2dnut.png");
		imgNutF = GameCanvas.M503("/mainImage/myTexture2dnutF.png");
		MobCapcha.M1010();
		isAnalog = ((Rms.M1542("analog") == 1) ? 1 : 0);
		gamePad = new GamePad();
		arrow = GameCanvas.M503("/mainImage/myTexture2darrow3.png");
		imgTrans = GameCanvas.M503("/bg/trans.png");
		imgRoomStat = GameCanvas.M503("/mainImage/myTexture2dstat.png");
		frBarPow0 = GameCanvas.M503("/mainImage/myTexture2dlineColor20.png");
		frBarPow1 = GameCanvas.M503("/mainImage/myTexture2dlineColor21.png");
		frBarPow2 = GameCanvas.M503("/mainImage/myTexture2dlineColor22.png");
		frBarPow20 = GameCanvas.M503("/mainImage/myTexture2dlineColor00.png");
		frBarPow21 = GameCanvas.M503("/mainImage/myTexture2dlineColor01.png");
		frBarPow22 = GameCanvas.M503("/mainImage/myTexture2dlineColor02.png");
	}

	public void M532()
	{
		M554();
		SmallImage.M1780();
	}

	public static void M533(Image img0, Image img1, Image img2, float x, float y, int size, float pixelPercent, mGraphics g)
	{
		int x2 = g.M923();
		int y2 = g.M924();
		int w = g.M925();
		int h = g.M926();
		g.M922((int)x, (int)y, (int)pixelPercent, 13);
		int num = size / 15 - 2;
		for (int i = 0; i < num; i++)
		{
			g.M951(img1, x + (float)((i + 1) * 15), y, 0);
		}
		g.M951(img0, x, y, 0);
		g.M951(img1, x + (float)size - 30f, y, 0);
		g.M951(img2, x + (float)size - 15f, y, 0);
		g.M922(x2, y2, w, h);
	}

	public void M534()
	{
		if (CreateCharScr.isCreateChar)
		{
			CreateCharScr.isCreateChar = false;
			right = null;
		}
	}

	public bool M535()
	{
		if (TileMap.mapID >= 53)
		{
			return TileMap.mapID <= 62;
		}
		return false;
	}

	public bool M536()
	{
		return TileMap.mapID >= 63;
	}

	public override void switchToMe()
	{
		vChatVip.M1120();
		ServerListScreen.isWait = false;
		if (BackgroundEffect.M40())
		{
			SoundMn.M1826().M1833();
		}
		LoginScr.isContinueToLogin = false;
		Char.isLoadingMap = false;
		if (!isPaintOther)
		{
			Service.M1594().M1712();
		}
		if (TileMap.M1933())
		{
			M534();
		}
		info1.isUpdate = true;
		info2.isUpdate = true;
		M574();
		isLoadAllData = true;
		isPaintOther = false;
		base.switchToMe();
	}

	public static int M537(int level)
	{
		int num = 0;
		for (int i = 0; i <= level; i++)
		{
			num += (int)exps[i];
		}
		return num;
	}

	public static void M538()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		vCharInMap.M1120();
		Teleport.vTeleport.M1120();
		vItemMap.M1120();
		Effect2.vEffect2.M1120();
		Effect2.vAnimateEffect.M1120();
		Effect2.vEffect2Outside.M1120();
		Effect2.vEffectFeet.M1120();
		Effect2.vEffect3.M1120();
		vMobAttack.M1120();
		vMob.M1120();
		vNpc.M1120();
		Char.M113().vMovePoints.M1120();
	}

	public void M539()
	{
	}

	public void M540(sbyte[] oSkillID)
	{
		Cout.M326("GET onScreenSkill!");
		onScreenSkill = new Skill[10];
		if (oSkillID == null)
		{
			M543();
			return;
		}
		for (int i = 0; i < oSkillID.Length; i++)
		{
			for (int j = 0; j < Char.M113().vSkillFight.M1113(); j++)
			{
				Skill t = (Skill)Char.M113().vSkillFight.M1114(j);
				if (t.template.id == oSkillID[i])
				{
					onScreenSkill[i] = t;
					break;
				}
			}
		}
	}

	public void M541(sbyte[] kSkillID)
	{
		Cout.M326("GET KEYSKILL!");
		keySkill = new Skill[10];
		if (kSkillID == null)
		{
			M544();
			return;
		}
		for (int i = 0; i < kSkillID.Length; i++)
		{
			for (int j = 0; j < Char.M113().vSkillFight.M1113(); j++)
			{
				Skill t = (Skill)Char.M113().vSkillFight.M1114(j);
				if (t.template.id == kSkillID[i])
				{
					keySkill[i] = t;
					break;
				}
			}
		}
	}

	public void M542(sbyte[] cSkillID)
	{
		Cout.M326("GET CURRENTSKILL!");
		if (cSkillID != null && cSkillID.Length != 0)
		{
			for (int i = 0; i < Char.M113().vSkillFight.M1113(); i++)
			{
				Skill t = (Skill)Char.M113().vSkillFight.M1114(i);
				if (t.template.id == cSkillID[0])
				{
					Char.M113().myskill = t;
					break;
				}
			}
		}
		else if (Char.M113().vSkillFight.M1113() > 0)
		{
			Char.M113().myskill = (Skill)Char.M113().vSkillFight.M1114(0);
		}
		if (Char.M113().myskill != null)
		{
			Service.M1594().M1652(Char.M113().myskill.template.id);
			M549(Char.M113().myskill.template.id);
		}
	}

	private void M543()
	{
		Cout.M326("LOAD DEFAULT ONmScreen SKILL");
		for (int i = 0; i < onScreenSkill.Length && i < Char.M113().vSkillFight.M1113(); i++)
		{
			Skill t = (Skill)Char.M113().vSkillFight.M1114(i);
			onScreenSkill[i] = t;
		}
		M547();
	}

	private void M544()
	{
		Cout.M326("LOAD DEFAULT KEY SKILL");
		for (int i = 0; i < keySkill.Length && i < Char.M113().vSkillFight.M1113(); i++)
		{
			Skill t = (Skill)Char.M113().vSkillFight.M1114(i);
			keySkill[i] = t;
		}
		M548();
	}

	public void M545(SkillTemplate skillTemplate)
	{
		Skill t = Char.M113().M119(skillTemplate);
		MyVector t2 = new MyVector();
		for (int i = 0; i < 10; i++)
		{
			MyVector t3 = t2;
			object p = new object[2]
			{
				t,
				i + string.Empty
			};
			t3.M1111(new Command(mResources.into_place + (i + 1), 11120, p));
		}
		GameCanvas.menu.M877(t2, 0);
	}

	public void M546(SkillTemplate skillTemplate)
	{
		Cout.M326("DO SET KEY SKILL");
		Skill t = Char.M113().M119(skillTemplate);
		string[] array = ((!TField.isQwerty) ? mResources.key_skill : mResources.key_skill_qwerty);
		MyVector t2 = new MyVector();
		for (int i = 0; i < 10; i++)
		{
			MyVector t3 = t2;
			object p = new object[2]
			{
				t,
				i + string.Empty
			};
			t3.M1111(new Command(array[i], 11121, p));
		}
		GameCanvas.menu.M877(t2, 0);
	}

	public void M547()
	{
		sbyte[] array = new sbyte[onScreenSkill.Length];
		for (int i = 0; i < onScreenSkill.Length; i++)
		{
			if (onScreenSkill[i] == null)
			{
				array[i] = -1;
			}
			else
			{
				array[i] = onScreenSkill[i].template.id;
			}
		}
		Service.M1594().M1734(array);
	}

	public void M548()
	{
		sbyte[] array = new sbyte[keySkill.Length];
		for (int i = 0; i < keySkill.Length; i++)
		{
			if (keySkill[i] == null)
			{
				array[i] = -1;
			}
			else
			{
				array[i] = keySkill[i].template.id;
			}
		}
		Service.M1594().M1734(array);
	}

	public void M549(sbyte id)
	{
	}

	public void M550(Skill skill)
	{
		Cout.M326("ADD SKILL SHORTCUT TO SKILL " + skill.template.id);
		for (int i = 0; i < onScreenSkill.Length; i++)
		{
			if (onScreenSkill[i] == null)
			{
				onScreenSkill[i] = skill;
				break;
			}
		}
		for (int j = 0; j < keySkill.Length; j++)
		{
			if (keySkill[j] == null)
			{
				keySkill[j] = skill;
				break;
			}
		}
		if (Char.M113().myskill == null)
		{
			Char.M113().myskill = skill;
		}
		M548();
		M547();
	}

	public bool M551()
	{
		int num = Char.M113().arrItemBag.Length - 1;
		while (true)
		{
			if (num >= 0)
			{
				if (Char.M113().arrItemBag[num] == null)
				{
					break;
				}
				num--;
				continue;
			}
			return true;
		}
		return false;
	}

	public void M552(string[] menu, Npc npc)
	{
		M574();
		isLockKey = true;
		left = new Command(menu[0], 130011, npc);
		right = new Command(menu[1], 130012, npc);
	}

	public void M553(string[] menu, Npc npc)
	{
		MyVector t = new MyVector();
		for (int i = 0; i < menu.Length; i++)
		{
			t.M1111(new Command(menu[i], 11057, npc));
		}
		GameCanvas.menu.M877(t, 2);
	}

	public void M554()
	{
		DataInputStream t = null;
		try
		{
			t = new DataInputStream(Rms.M1535("NR_part"));
			int num = t.M353();
			parts = new Part[num];
			for (int i = 0; i < num; i++)
			{
				sbyte type = t.M360();
				parts[i] = new Part(type);
				for (int j = 0; j < parts[i].pi.Length; j++)
				{
					parts[i].pi[j] = new PartImage();
					parts[i].pi[j].id = t.M353();
					parts[i].pi[j].dx = t.M360();
					parts[i].pi[j].dy = t.M360();
				}
			}
		}
		catch (Exception ex)
		{
			Cout.M328("LOI TAI readPart " + ex.ToString());
		}
		finally
		{
			try
			{
				t.M357();
			}
			catch (Exception ex2)
			{
				Cout.M328("LOI TAI readPart 2" + ex2.ToString());
			}
		}
	}

	public void M555()
	{
		DataInputStream t = null;
		try
		{
			t = new DataInputStream(Rms.M1535("NR_effect"));
			int num = t.M353();
			efs = new EffectCharPaint[num];
			for (int i = 0; i < num; i++)
			{
				efs[i] = new EffectCharPaint();
				efs[i].idEf = t.M353();
				efs[i].arrEfInfo = new EffectInfoPaint[t.M360()];
				for (int j = 0; j < efs[i].arrEfInfo.Length; j++)
				{
					efs[i].arrEfInfo[j] = new EffectInfoPaint();
					efs[i].arrEfInfo[j].idImg = t.M353();
					efs[i].arrEfInfo[j].dx = t.M360();
					efs[i].arrEfInfo[j].dy = t.M360();
				}
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			try
			{
				t.M357();
			}
			catch (Exception ex2)
			{
				Cout.M328("Loi ham Eff: " + ex2.ToString());
			}
		}
	}

	public void M556()
	{
		DataInputStream t = null;
		try
		{
			t = new DataInputStream(Rms.M1535("NR_arrow"));
			int num = t.M353();
			arrs = new Arrowpaint[num];
			for (int i = 0; i < num; i++)
			{
				arrs[i] = new Arrowpaint();
				arrs[i].id = t.M353();
				arrs[i].imgId[0] = t.M353();
				arrs[i].imgId[1] = t.M353();
				arrs[i].imgId[2] = t.M353();
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			try
			{
				t.M357();
			}
			catch (Exception ex2)
			{
				Cout.M328("Loi ham readArrow: " + ex2.ToString());
			}
		}
	}

	public void M557()
	{
		DataInputStream t = null;
		try
		{
			t = new DataInputStream(Rms.M1535("NR_dart"));
			int num = t.M353();
			darts = new DartInfo[num];
			for (int i = 0; i < num; i++)
			{
				darts[i] = new DartInfo();
				darts[i].id = t.M353();
				darts[i].nUpdate = t.M353();
				darts[i].va = t.M353() * 256;
				darts[i].xdPercent = t.M353();
				int num2 = t.M353();
				darts[i].tail = new short[num2];
				for (int j = 0; j < num2; j++)
				{
					darts[i].tail[j] = t.M353();
				}
				num2 = t.M353();
				darts[i].tailBorder = new short[num2];
				for (int k = 0; k < num2; k++)
				{
					darts[i].tailBorder[k] = t.M353();
				}
				num2 = t.M353();
				darts[i].xd1 = new short[num2];
				for (int l = 0; l < num2; l++)
				{
					darts[i].xd1[l] = t.M353();
				}
				num2 = t.M353();
				darts[i].xd2 = new short[num2];
				for (int m = 0; m < num2; m++)
				{
					darts[i].xd2[m] = t.M353();
				}
				num2 = t.M353();
				darts[i].head = new short[num2][];
				for (int n = 0; n < num2; n++)
				{
					short num3 = t.M353();
					darts[i].head[n] = new short[num3];
					for (int num4 = 0; num4 < num3; num4++)
					{
						darts[i].head[n][num4] = t.M353();
					}
				}
				num2 = t.M353();
				darts[i].headBorder = new short[num2][];
				for (int num5 = 0; num5 < num2; num5++)
				{
					short num6 = t.M353();
					darts[i].headBorder[num5] = new short[num6];
					for (int num7 = 0; num7 < num6; num7++)
					{
						darts[i].headBorder[num5][num7] = t.M353();
					}
				}
			}
		}
		catch (Exception ex)
		{
			Cout.M328("Loi ham ReadDart: " + ex.ToString());
		}
		finally
		{
			try
			{
				t.M357();
			}
			catch (Exception ex2)
			{
				Cout.M328("Loi ham reaaDart: " + ex2.ToString());
			}
		}
	}

	public void M558()
	{
		DataInputStream t = null;
		try
		{
			t = new DataInputStream(Rms.M1535("NR_skill"));
			int num = t.M353();
			sks = new SkillPaint[Skills.skills.M1077()];
			for (int i = 0; i < num; i++)
			{
				short num2 = t.M353();
				Res.M1513("skill id= " + num2);
				if (num2 == 1111)
				{
					num2 = (short)(num - 1);
				}
				sks[num2] = new SkillPaint();
				sks[num2].id = num2;
				sks[num2].effectHappenOnMob = t.M353();
				if (sks[num2].effectHappenOnMob <= 0)
				{
					sks[num2].effectHappenOnMob = 80;
				}
				sks[num2].numEff = t.M360();
				sks[num2].skillStand = new SkillInfoPaint[t.M360()];
				for (int j = 0; j < sks[num2].skillStand.Length; j++)
				{
					sks[num2].skillStand[j] = new SkillInfoPaint();
					sks[num2].skillStand[j].status = t.M360();
					sks[num2].skillStand[j].effS0Id = t.M353();
					sks[num2].skillStand[j].e0dx = t.M353();
					sks[num2].skillStand[j].e0dy = t.M353();
					sks[num2].skillStand[j].effS1Id = t.M353();
					sks[num2].skillStand[j].e1dx = t.M353();
					sks[num2].skillStand[j].e1dy = t.M353();
					sks[num2].skillStand[j].effS2Id = t.M353();
					sks[num2].skillStand[j].e2dx = t.M353();
					sks[num2].skillStand[j].e2dy = t.M353();
					sks[num2].skillStand[j].arrowId = t.M353();
					sks[num2].skillStand[j].adx = t.M353();
					sks[num2].skillStand[j].ady = t.M353();
				}
				sks[num2].skillfly = new SkillInfoPaint[t.M360()];
				for (int k = 0; k < sks[num2].skillfly.Length; k++)
				{
					sks[num2].skillfly[k] = new SkillInfoPaint();
					sks[num2].skillfly[k].status = t.M360();
					sks[num2].skillfly[k].effS0Id = t.M353();
					sks[num2].skillfly[k].e0dx = t.M353();
					sks[num2].skillfly[k].e0dy = t.M353();
					sks[num2].skillfly[k].effS1Id = t.M353();
					sks[num2].skillfly[k].e1dx = t.M353();
					sks[num2].skillfly[k].e1dy = t.M353();
					sks[num2].skillfly[k].effS2Id = t.M353();
					sks[num2].skillfly[k].e2dx = t.M353();
					sks[num2].skillfly[k].e2dy = t.M353();
					sks[num2].skillfly[k].arrowId = t.M353();
					sks[num2].skillfly[k].adx = t.M353();
					sks[num2].skillfly[k].ady = t.M353();
				}
			}
		}
		catch (Exception ex)
		{
			Cout.M328("Loi ham readSkill: " + ex.ToString());
		}
		finally
		{
			try
			{
				t.M357();
			}
			catch (Exception ex2)
			{
				Cout.M328("Loi ham readskill: " + ex2.ToString());
			}
		}
	}

	public static GameScr M559()
	{
		if (instance == null)
		{
			instance = new GameScr();
		}
		return instance;
	}

	public static void M560()
	{
		instance = null;
	}

	public void M561()
	{
		M645();
		Res.M1506();
		M649();
	}

	public void M562()
	{
		scrMain.M1560();
		scrInfo.M1560();
		isViewNext = false;
		cmdBag = new Command(mResources.MENUME[0], 1100011);
		cmdSkill = new Command(mResources.MENUME[1], 1100012);
		cmdTiemnang = new Command(mResources.MENUME[2], 1100013);
		cmdInfo = new Command(mResources.MENUME[3], 1100014);
		cmdtrangbi = new Command(mResources.MENUME[4], 1100015);
		MyVector t = new MyVector();
		t.M1111(cmdBag);
		t.M1111(cmdSkill);
		t.M1111(cmdTiemnang);
		t.M1111(cmdInfo);
		t.M1111(cmdtrangbi);
		GameCanvas.menu.M877(t, 3);
	}

	public void M563()
	{
		MyVector t = new MyVector();
		t.M1111(new Command(mResources.SYNTHESIS[0], 110002));
		t.M1111(new Command(mResources.SYNTHESIS[1], 1100032));
		t.M1111(new Command(mResources.SYNTHESIS[2], 1100033));
		GameCanvas.menu.M877(t, 3);
	}

	public static void M564(bool fullmScreen, int cx, int cy)
	{
		gW = GameCanvas.w;
		cmdBarH = 39;
		gH = GameCanvas.h;
		cmdBarW = gW;
		cmdBarX = 0;
		cmdBarY = GameCanvas.h - Paint.hTab - cmdBarH;
		girlHPBarY = 0;
		csPadMaxH = GameCanvas.h / 6;
		if (csPadMaxH < 48)
		{
			csPadMaxH = 48;
		}
		gW2 = gW >> 1;
		gH2 = gH >> 1;
		gW3 = gW / 3;
		gH3 = gH / 3;
		gW23 = gH - 120;
		gH23 = gH * 2 / 3;
		gW34 = 3 * gW / 4;
		gH34 = 3 * gH / 4;
		gW6 = gW / 6;
		gH6 = gH / 6;
		gssw = gW / TileMap.size + 2;
		gssh = gH / TileMap.size + 2;
		if (gW % 24 != 0)
		{
			gssw++;
		}
		cmxLim = (TileMap.tmw - 1) * TileMap.size - gW;
		cmyLim = (TileMap.tmh - 1) * TileMap.size - gH;
		if (cx == -1 && cy == -1)
		{
			cmx = (cmtoX = Char.M113().cx - gW2 + gW6 * Char.M113().cdir);
			cmy = (cmtoY = Char.M113().cy - gH23);
		}
		else
		{
			cmx = (cmtoX = cx - gW23 + gW6 * Char.M113().cdir);
			cmy = (cmtoY = cy - gH23);
		}
		firstY = cmy;
		if (cmx < 24)
		{
			cmtoX = 24;
			cmx = 24;
		}
		if (cmx > cmxLim)
		{
			cmx = (cmtoX = cmxLim);
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
		gssx = cmx / TileMap.size - 1;
		if (gssx < 0)
		{
			gssx = 0;
		}
		gssy = cmy / TileMap.size;
		gssxe = gssx + gssw;
		gssye = gssy + gssh;
		if (gssy < 0)
		{
			gssy = 0;
		}
		if (gssye > TileMap.tmh - 1)
		{
			gssye = TileMap.tmh - 1;
		}
		TileMap.countx = (gssxe - gssx) * 4;
		if (TileMap.countx > TileMap.tmw)
		{
			TileMap.countx = TileMap.tmw;
		}
		TileMap.county = (gssye - gssy) * 4;
		if (TileMap.county > TileMap.tmh)
		{
			TileMap.county = TileMap.tmh;
		}
		TileMap.gssx = (Char.M113().cx - 2 * gW) / TileMap.size;
		if (TileMap.gssx < 0)
		{
			TileMap.gssx = 0;
		}
		TileMap.gssxe = TileMap.gssx + TileMap.countx;
		if (TileMap.gssxe > TileMap.tmw)
		{
			TileMap.gssxe = TileMap.tmw;
		}
		TileMap.gssy = (Char.M113().cy - 2 * gH) / TileMap.size;
		if (TileMap.gssy < 0)
		{
			TileMap.gssy = 0;
		}
		TileMap.gssye = TileMap.gssy + TileMap.county;
		if (TileMap.gssye > TileMap.tmh)
		{
			TileMap.gssye = TileMap.tmh;
		}
		ChatTextField.M279().parentScreen = instance;
		ChatTextField.M279().tfChat.y = GameCanvas.h - 35 - ChatTextField.M279().tfChat.height;
		ChatTextField.M279().M276();
		if (GameCanvas.isTouch)
		{
			yTouchBar = gH - 88;
			xC = gW - 40;
			yC = 2;
			if (GameCanvas.w <= 240)
			{
				xC = gW - 35;
				yC = 5;
			}
			xF = gW - 55;
			yF = yTouchBar + 35;
			xTG = gW - 37;
			yTG = yTouchBar - 1;
			if (GameCanvas.w >= 450)
			{
				yTG -= 12;
				yHP -= 7;
				xF -= 10;
				yF -= 5;
				xTG -= 10;
			}
		}
		M565();
		disXC = ((GameCanvas.w <= 200) ? 30 : 40);
		if (Rms.M1542("viewchat") == -1)
		{
			GameCanvas.panel.isViewChatServer = true;
		}
		else
		{
			GameCanvas.panel.isViewChatServer = Rms.M1542("viewchat") == 1;
		}
	}

	public static void M565()
	{
		Skill[] array = ((!GameCanvas.isTouch) ? keySkill : onScreenSkill);
		xS = new int[array.Length];
		yS = new int[array.Length];
		if (GameCanvas.isTouchControlSmallScreen && isUseTouch)
		{
			xSkill = 23;
			ySkill = 52;
			padSkill = 5;
			for (int i = 0; i < xS.Length; i++)
			{
				xS[i] = i * (25 + padSkill);
				yS[i] = ySkill;
			}
			xHP = array.Length * (25 + padSkill);
			yHP = ySkill;
		}
		else
		{
			wSkill = 30;
			if (GameCanvas.w <= 320)
			{
				ySkill = gH - wSkill - 6;
				xSkill = gW2 - array.Length * wSkill / 2 - 25;
			}
			else
			{
				wSkill = 40;
				xSkill = 10;
				ySkill = GameCanvas.h - wSkill + 7;
			}
			for (int j = 0; j < xS.Length; j++)
			{
				xS[j] = j * wSkill;
				yS[j] = ySkill;
			}
			xHP = array.Length * wSkill;
			yHP = ySkill;
		}
		if (GameCanvas.isTouch)
		{
			xSkill = 17;
			ySkill = GameCanvas.h - 40;
			if (gamePad.isSmallGamePad && isAnalog == 1)
			{
				xHP = array.Length * wSkill;
				yHP = ySkill;
			}
			else
			{
				xHP = GameCanvas.w - 45;
				yHP = GameCanvas.h - 45;
			}
			M673();
			for (int k = 0; k < xS.Length; k++)
			{
				xS[k] = k * wSkill;
				yS[k] = ySkill;
			}
		}
	}

	private static void M566()
	{
		if (isPaintOther)
		{
			return;
		}
		if (cmx != cmtoX || cmy != cmtoY)
		{
			cmvx = cmtoX - cmx << 2;
			cmvy = cmtoY - cmy << 2;
			cmdx += cmvx;
			cmx += cmdx >> 4;
			cmdx &= 15;
			cmdy += cmvy;
			cmy += cmdy >> 4;
			cmdy &= 15;
			if (cmx < 24)
			{
				cmx = 24;
			}
			if (cmx > cmxLim)
			{
				cmx = cmxLim;
			}
			if (cmy < 0)
			{
				cmy = 0;
			}
			if (cmy > cmyLim)
			{
				cmy = cmyLim;
			}
		}
		gssx = cmx / TileMap.size - 1;
		if (gssx < 0)
		{
			gssx = 0;
		}
		gssy = cmy / TileMap.size;
		gssxe = gssx + gssw;
		gssye = gssy + gssh;
		if (gssy < 0)
		{
			gssy = 0;
		}
		if (gssye > TileMap.tmh - 1)
		{
			gssye = TileMap.tmh - 1;
		}
		TileMap.gssx = (Char.M113().cx - 2 * gW) / TileMap.size;
		if (TileMap.gssx < 0)
		{
			TileMap.gssx = 0;
		}
		TileMap.gssxe = TileMap.gssx + TileMap.countx;
		if (TileMap.gssxe > TileMap.tmw)
		{
			TileMap.gssxe = TileMap.tmw;
			TileMap.gssx = TileMap.gssxe - TileMap.countx;
		}
		TileMap.gssy = (Char.M113().cy - 2 * gH) / TileMap.size;
		if (TileMap.gssy < 0)
		{
			TileMap.gssy = 0;
		}
		TileMap.gssye = TileMap.gssy + TileMap.county;
		if (TileMap.gssye > TileMap.tmh)
		{
			TileMap.gssye = TileMap.tmh;
			TileMap.gssy = TileMap.gssye - TileMap.county;
		}
		scrMain.M1565();
		scrInfo.M1565();
	}

	public bool M567()
	{
		sbyte b = 2;
		while (true)
		{
			if (b < 9)
			{
				if (GameCanvas.keyHold[b])
				{
					break;
				}
				b += 2;
				continue;
			}
			return true;
		}
		return false;
	}

	public void M568(string strInvite, int clanID, int code)
	{
		ClanObject t = new ClanObject();
		t.code = code;
		t.clanID = clanID;
		M668(strInvite, new Command(mResources.YES, 12002, t), new Command(mResources.NO, 12003, t));
	}

	public void M569(Char c)
	{
		auto = 0;
		GameCanvas.M484();
		if (Char.M113().charFocus.charID < 0 || Char.M113().charID < 0)
		{
			return;
		}
		MyVector vPlayerMenu = GameCanvas.panel.vPlayerMenu;
		if (vPlayerMenu.M1113() > 0)
		{
			return;
		}
		if (Char.M113().taskMaint != null && Char.M113().taskMaint.taskId > 1)
		{
			vPlayerMenu.M1111(new Command(mResources.make_friend, 11112, Char.M113().charFocus));
			vPlayerMenu.M1111(new Command(mResources.trade, 11113, Char.M113().charFocus));
		}
		if (Char.M113().clan != null && Char.M113().role < 2 && Char.M113().charFocus.clanID == -1)
		{
			vPlayerMenu.M1111(new Command(mResources.CHAR_ORDER[4], 110391));
		}
		if (Char.M113().charFocus.statusMe != 14 && Char.M113().charFocus.statusMe != 5)
		{
			if (Char.M113().taskMaint != null && Char.M113().taskMaint.taskId >= 14)
			{
				vPlayerMenu.M1111(new Command(mResources.CHAR_ORDER[0], 2003));
			}
		}
		else
		{
			_ = Char.M113().myskill.template.type;
		}
		if (Char.M113().clan != null && Char.M113().clan.ID == Char.M113().charFocus.clanID && Char.M113().charFocus.statusMe != 14 && Char.M113().taskMaint != null && Char.M113().taskMaint.taskId >= 14)
		{
			vPlayerMenu.M1111(new Command(mResources.CHAR_ORDER[1], 2004));
		}
		int num = Char.M113().nClass.skillTemplates.Length;
		for (int i = 0; i < num; i++)
		{
			SkillTemplate t = Char.M113().nClass.skillTemplates[i];
			Skill t2 = Char.M113().M119(t);
			if (t2 != null && t.M1774() && t2.point >= 1)
			{
				vPlayerMenu.M1111(new Command(t.name, 12004, t2));
			}
		}
	}

	public bool M570()
	{
		if (M582(Char.M113().charFocus))
		{
			return false;
		}
		if (M582(Char.M113().mobFocus))
		{
			return false;
		}
		if (M582(Char.M113().npcFocus))
		{
			return false;
		}
		if (ChatTextField.M279().isShow)
		{
			return false;
		}
		if (InfoDlg.isLock || Char.M113().isLockAttack || Char.isLockKey)
		{
			return false;
		}
		if (Char.M113().myskill != null && Char.M113().myskill.template.id == 6 && Char.M113().itemFocus != null)
		{
			M599();
			return false;
		}
		if (Char.M113().myskill != null && Char.M113().myskill.template.type == 2 && Char.M113().npcFocus == null && Char.M113().myskill.template.id != 6)
		{
			return M572();
		}
		if (Char.M113().skillPaint != null || (Char.M113().mobFocus == null && Char.M113().npcFocus == null && Char.M113().charFocus == null && Char.M113().itemFocus == null))
		{
			return false;
		}
		if (Char.M113().mobFocus != null)
		{
			if (Char.M113().mobFocus.M974() && Char.M113().mobFocus.status == 4)
			{
				Char.M113().mobFocus = null;
				Char.M113().currentMovePoint = null;
			}
			isAutoPlay = true;
			if (!M571(Char.M113().mobFocus))
			{
				Res.M1513("can not attack");
				return false;
			}
			if (mobCapcha != null)
			{
				return false;
			}
			if (Char.M113().myskill == null)
			{
				return false;
			}
			if (Char.M113().M169())
			{
				return false;
			}
			if (Char.M113().mobFocus.status == 1 || Char.M113().mobFocus.status == 0 || Char.M113().myskill.template.type == 4)
			{
				return false;
			}
			if (!M572())
			{
				return false;
			}
			if (Char.M113().cx < Char.M113().mobFocus.getX())
			{
				Char.M113().cdir = 1;
			}
			else
			{
				Char.M113().cdir = -1;
			}
			int num = Math.M869(Char.M113().cx - Char.M113().mobFocus.getX());
			int num2 = Math.M869(Char.M113().cy - Char.M113().mobFocus.getY());
			Char.M113().cvx = 0;
			if (num > Char.M113().myskill.dx || num2 > Char.M113().myskill.dy)
			{
				bool flag = false;
				if (Char.M113().mobFocus is BigBoss || Char.M113().mobFocus is BigBoss2)
				{
					flag = true;
				}
				int num3 = (Char.M113().myskill.dx - ((!flag) ? 20 : 50)) * ((Char.M113().cx > Char.M113().mobFocus.getX()) ? 1 : (-1));
				if (num <= Char.M113().myskill.dx)
				{
					num3 = 0;
				}
				Char.M113().currentMovePoint = new MovePoint(Char.M113().mobFocus.getX() + num3, Char.M113().mobFocus.getY());
				Char.M113().endMovePointCommand = new Command(null, null, 8002, null);
				GameCanvas.M484();
				GameCanvas.M483();
				return false;
			}
			if (Char.M113().myskill.template.id == 20)
			{
				return true;
			}
			if (num2 > num && Res.M1529(Char.M113().cy - Char.M113().mobFocus.getY()) > 30 && Char.M113().mobFocus.M998().type == 4)
			{
				Char.M113().currentMovePoint = new MovePoint(Char.M113().cx + Char.M113().cdir, Char.M113().mobFocus.getY());
				Char.M113().endMovePointCommand = new Command(null, null, 8002, null);
				GameCanvas.M484();
				GameCanvas.M483();
				return false;
			}
			int num4 = 20;
			bool flag2 = false;
			if (Char.M113().mobFocus is BigBoss || Char.M113().mobFocus is BigBoss2)
			{
				flag2 = true;
			}
			if (Char.M113().myskill.dx > 100)
			{
				num4 = 60;
				if (num < 20)
				{
					Char.M113().M182(Char.M113().cx, Char.M113().cy, 10);
				}
			}
			bool flag3 = false;
			if ((TileMap.M1957(Char.M113().cx, Char.M113().cy + 3) & 2) == 2)
			{
				int num5 = ((Char.M113().cx > Char.M113().mobFocus.getX()) ? 1 : (-1));
				if ((TileMap.M1957(Char.M113().mobFocus.getX() + num4 * num5, Char.M113().cy + 3) & 2) != 2)
				{
					flag3 = true;
				}
			}
			if (num <= num4 && !flag3)
			{
				if (num >= 30)
				{
					int num6 = ((Char.M113().cx <= Char.M113().mobFocus.getX()) ? (-num4) : num4);
					Char.M113().currentMovePoint = new MovePoint(Char.M113().cx + num6, Char.M113().cy);
					Char.M113().endMovePointCommand = new Command(null, null, 8002, null);
					GameCanvas.M484();
					GameCanvas.M483();
					return false;
				}
				if (Char.M113().cx > Char.M113().mobFocus.getX())
				{
					Char.M113().cx = Char.M113().mobFocus.getX() + num4 + (flag2 ? 30 : 0);
					Char.M113().cdir = -1;
				}
				else
				{
					Char.M113().cx = Char.M113().mobFocus.getX() - num4 - (flag2 ? 30 : 0);
					Char.M113().cdir = 1;
				}
				Service.M1594().M1640();
			}
			GameCanvas.M484();
			GameCanvas.M483();
			return true;
		}
		if (Char.M113().npcFocus != null)
		{
			if (Char.M113().npcFocus.isHide)
			{
				return false;
			}
			if (Char.M113().cx < Char.M113().npcFocus.cx)
			{
				Char.M113().cdir = 1;
			}
			else
			{
				Char.M113().cdir = -1;
			}
			if (Char.M113().cx < Char.M113().npcFocus.cx)
			{
				Char.M113().npcFocus.cdir = -1;
			}
			else
			{
				Char.M113().npcFocus.cdir = 1;
			}
			int num7 = Math.M869(Char.M113().cx - Char.M113().npcFocus.cx);
			if (Math.M869(Char.M113().cy - Char.M113().npcFocus.cy) > 40)
			{
				Char.M113().cy = Char.M113().npcFocus.cy - 40;
			}
			if (num7 < 60)
			{
				GameCanvas.M484();
				GameCanvas.M483();
				if (tMenuDelay == 0)
				{
					if (Char.M113().taskMaint != null && Char.M113().taskMaint.taskId == 0)
					{
						if (Char.M113().taskMaint.index < 4 && Char.M113().npcFocus.template.npcTemplateId == 4)
						{
							return false;
						}
						if (Char.M113().taskMaint.index < 3 && Char.M113().npcFocus.template.npcTemplateId == 3)
						{
							return false;
						}
					}
					tMenuDelay = 50;
					InfoDlg.M749();
					Service.M1594().M1640();
					Service.M1594().M1656(Char.M113().npcFocus.template.npcTemplateId);
				}
			}
			else
			{
				int num8 = 20 + Res.r.M1084(20);
				int num9 = ((Char.M113().cx > Char.M113().npcFocus.cx) ? 1 : (-1));
				Char.M113().currentMovePoint = new MovePoint(Char.M113().npcFocus.cx + num8 * num9, Char.M113().cy);
				Char.M113().endMovePointCommand = new Command(null, null, 8002, null);
				GameCanvas.M484();
				GameCanvas.M483();
			}
			return false;
		}
		if (Char.M113().charFocus != null)
		{
			if (mobCapcha != null)
			{
				return false;
			}
			if (Char.M113().cx < Char.M113().charFocus.cx)
			{
				Char.M113().cdir = 1;
			}
			else
			{
				Char.M113().cdir = -1;
			}
			int num10 = Math.M869(Char.M113().cx - Char.M113().charFocus.cx);
			int num11 = Math.M869(Char.M113().cy - Char.M113().charFocus.cy);
			if (!Char.M113().M225(Char.M113().charFocus) && !Char.M113().M170())
			{
				if (num10 < 60 && num11 < 40)
				{
					M569(Char.M113().charFocus);
					if (!GameCanvas.isTouch && Char.M113().charFocus.charID >= 0 && TileMap.mapID != 51 && TileMap.mapID != 52 && popUpYesNo == null)
					{
						GameCanvas.panel.M1259(Char.M113().charFocus);
						GameCanvas.panel.M1285();
						Service.M1594().M1610(Char.M113().charFocus.charID);
						Service.M1594().M1737(Char.M113().charFocus.charID);
					}
				}
				else
				{
					int num12 = 20 + Res.r.M1084(20);
					int num13 = ((Char.M113().cx > Char.M113().charFocus.cx) ? 1 : (-1));
					Char.M113().currentMovePoint = new MovePoint(Char.M113().charFocus.cx + num12 * num13, Char.M113().charFocus.cy);
					Char.M113().endMovePointCommand = new Command(null, null, 8002, null);
					GameCanvas.M484();
					GameCanvas.M483();
				}
				return false;
			}
			if (Char.M113().myskill == null)
			{
				return false;
			}
			if (!M572())
			{
				return false;
			}
			if (Char.M113().cx < Char.M113().charFocus.cx)
			{
				Char.M113().cdir = 1;
			}
			else
			{
				Char.M113().cdir = -1;
			}
			Char.M113().cvx = 0;
			if (num10 > Char.M113().myskill.dx || num11 > Char.M113().myskill.dy)
			{
				int num14 = (Char.M113().myskill.dx - 20) * ((Char.M113().cx > Char.M113().charFocus.cx) ? 1 : (-1));
				if (num10 <= Char.M113().myskill.dx)
				{
					num14 = 0;
				}
				Char.M113().currentMovePoint = new MovePoint(Char.M113().charFocus.cx + num14, Char.M113().charFocus.cy);
				Char.M113().endMovePointCommand = new Command(null, null, 8002, null);
				GameCanvas.M484();
				GameCanvas.M483();
				return false;
			}
			if (Char.M113().myskill.template.id == 20)
			{
				return true;
			}
			int num15 = 20;
			if (Char.M113().myskill.dx > 60)
			{
				num15 = 60;
				if (num10 < 20)
				{
					Char.M113().M182(Char.M113().cx, Char.M113().cy, 10);
				}
			}
			bool flag4 = false;
			if ((TileMap.M1957(Char.M113().cx, Char.M113().cy + 3) & 2) == 2)
			{
				int num16 = ((Char.M113().cx > Char.M113().charFocus.cx) ? 1 : (-1));
				if ((TileMap.M1957(Char.M113().charFocus.cx + num15 * num16, Char.M113().cy + 3) & 2) != 2)
				{
					flag4 = true;
				}
			}
			if (num10 <= num15 && !flag4)
			{
				if (Char.M113().cx > Char.M113().charFocus.cx)
				{
					Char.M113().cx = Char.M113().charFocus.cx + num15;
					Char.M113().cdir = -1;
				}
				else
				{
					Char.M113().cx = Char.M113().charFocus.cx - num15;
					Char.M113().cdir = 1;
				}
				Service.M1594().M1640();
			}
			GameCanvas.M484();
			GameCanvas.M483();
			return true;
		}
		if (Char.M113().itemFocus != null)
		{
			M599();
			return false;
		}
		return true;
	}

	public bool M571(Mob m)
	{
		if (m == null)
		{
			return false;
		}
		if (Char.M113().cTypePk == 5)
		{
			return true;
		}
		if (Char.M113().M209() && !m.isMobMe)
		{
			return false;
		}
		if (Char.M113().mobMe != null && m.Equals(Char.M113().mobMe))
		{
			return false;
		}
		Char t = M626(m.mobId);
		if (t != null && t.cTypePk != 5)
		{
			return Char.M113().M225(t);
		}
		return true;
	}

	private bool M572()
	{
		if (Char.M113().myskill != null && ((Char.M113().myskill.template.manaUseType != 1 && Char.M113().cMP < Char.M113().myskill.manaUse) || (Char.M113().myskill.template.manaUseType == 1 && Char.M113().cMP < Char.M113().cMPFull * Char.M113().myskill.manaUse / 100)))
		{
			info1.M762(mResources.NOT_ENOUGH_MP, 0);
			auto = 0;
			return false;
		}
		if (Char.M113().myskill != null && (Char.M113().myskill.template.maxPoint <= 0 || Char.M113().myskill.point != 0))
		{
			return true;
		}
		GameCanvas.M489(mResources.SKILL_FAIL);
		return false;
	}

	private bool M573()
	{
		if ((Char.M113().myskill == null || ((Char.M113().myskill.template.manaUseType == 1 || Char.M113().cMP >= Char.M113().myskill.manaUse) && (Char.M113().myskill.template.manaUseType != 1 || Char.M113().cMP >= Char.M113().cMPFull * Char.M113().myskill.manaUse / 100))) && Char.M113().myskill != null)
		{
			if (Char.M113().myskill.template.maxPoint > 0)
			{
				return Char.M113().myskill.point != 0;
			}
			return true;
		}
		return false;
	}

	public void M574()
	{
		GameCanvas.menu.showMenu = false;
		ChatTextField.M279().M285();
		ChatTextField.M279().center = null;
		isLockKey = false;
		typeTrade = 0;
		indexMenu = 0;
		indexSelect = 0;
		indexItemUse = -1;
		indexRow = -1;
		indexRowMax = 0;
		indexTitle = 0;
		typeTradeOrder = 0;
		typeTrade = 0;
		mSystem.M1069();
		if (Char.M113().cHP > 0 && Char.M113().statusMe != 14 && Char.M113().statusMe != 5)
		{
			isHaveSelectSkill = true;
		}
		else
		{
			if (Char.M113().meDead)
			{
				cmdDead = new Command(mResources.DIES[0], 11038);
				center = cmdDead;
				Char.M113().cHP = 0;
			}
			isHaveSelectSkill = false;
		}
		scrMain.M1560();
	}

	public override void keyPress(int keyCode)
	{
		base.keyPress(keyCode);
	}

	public override void updateKey()
	{
		if (Controller.isStopReadMessage || Char.M113().isTeleport || InfoDlg.isLock)
		{
			return;
		}
		if (GameCanvas.isTouch && !ChatTextField.M279().isShow && !GameCanvas.menu.showMenu)
		{
			M608();
		}
		M588();
		GameCanvas.M456("F2", 0);
		if (ChatPopup.currChatPopup != null)
		{
			Command cmdNextLine = ChatPopup.currChatPopup.cmdNextLine;
			if ((GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] || mScreen.M1034(cmdNextLine)) && cmdNextLine != null)
			{
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
				mScreen.keyTouch = -1;
				cmdNextLine?.M294();
			}
		}
		else if (!ChatTextField.M279().isShow)
		{
			if ((GameCanvas.keyPressed[12] || mScreen.M1034(GameCanvas.currentScreen.left)) && left != null)
			{
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.isPointerClick = false;
				GameCanvas.keyPressed[12] = false;
				mScreen.keyTouch = -1;
				if (left != null)
				{
					left.M294();
				}
			}
			if ((GameCanvas.keyPressed[13] || mScreen.M1034(GameCanvas.currentScreen.right)) && right != null)
			{
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.isPointerClick = false;
				GameCanvas.keyPressed[13] = false;
				mScreen.keyTouch = -1;
				if (right != null)
				{
					right.M294();
				}
			}
			if ((GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] || mScreen.M1034(GameCanvas.currentScreen.center)) && center != null)
			{
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
				mScreen.keyTouch = -1;
				if (center != null)
				{
					center.M294();
				}
			}
		}
		else
		{
			if (ChatTextField.M279().left != null && (GameCanvas.keyPressed[12] || mScreen.M1034(ChatTextField.M279().left)) && ChatTextField.M279().left != null)
			{
				ChatTextField.M279().left.M294();
			}
			if (ChatTextField.M279().right != null && (GameCanvas.keyPressed[13] || mScreen.M1034(ChatTextField.M279().right)) && ChatTextField.M279().right != null)
			{
				ChatTextField.M279().right.M294();
			}
			if (ChatTextField.M279().center != null && (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] || mScreen.M1034(ChatTextField.M279().center)) && ChatTextField.M279().center != null)
			{
				ChatTextField.M279().center.M294();
			}
		}
		GameCanvas.M456("F6", 0);
		M651();
		GameCanvas.M456("F7", 0);
		if (Char.M113().currentMovePoint != null)
		{
			for (int i = 0; i < GameCanvas.keyPressed.Length; i++)
			{
				if (GameCanvas.keyPressed[i])
				{
					Char.M113().currentMovePoint = null;
					break;
				}
			}
		}
		GameCanvas.M456("F8", 0);
		if (ChatTextField.M279().isShow && GameCanvas.keyAsciiPress != 0)
		{
			ChatTextField.M279().M278(GameCanvas.keyAsciiPress);
			GameCanvas.keyAsciiPress = 0;
		}
		else if (isLockKey)
		{
			GameCanvas.M484();
			GameCanvas.M483();
		}
		else
		{
			if (GameCanvas.menu.showMenu || M655() || Char.isLockKey)
			{
				return;
			}
			if (GameCanvas.keyPressed[10])
			{
				GameCanvas.keyPressed[10] = false;
				M589();
				GameCanvas.M483();
			}
			if (GameCanvas.keyPressed[11] && mobCapcha == null)
			{
				if (popUpYesNo != null)
				{
					popUpYesNo.cmdYes.M294();
				}
				else if (info2.info.info != null && info2.info.info.charInfo != null)
				{
					GameCanvas.panel.M1266();
					GameCanvas.panel.M1285();
				}
				GameCanvas.keyPressed[11] = false;
				GameCanvas.M483();
			}
			if (GameCanvas.keyAsciiPress != 0 && TField.isQwerty && GameCanvas.keyAsciiPress == 32)
			{
				M589();
				GameCanvas.keyAsciiPress = 0;
				GameCanvas.M483();
			}
			if (GameCanvas.keyAsciiPress != 0 && mobCapcha == null && TField.isQwerty && GameCanvas.keyAsciiPress == 121)
			{
				if (popUpYesNo != null)
				{
					popUpYesNo.cmdYes.M294();
					GameCanvas.keyAsciiPress = 0;
					GameCanvas.M483();
				}
				else if (info2.info.info != null && info2.info.info.charInfo != null)
				{
					GameCanvas.panel.M1266();
					GameCanvas.panel.M1285();
					GameCanvas.keyAsciiPress = 0;
					GameCanvas.M483();
				}
			}
			if (GameCanvas.keyPressed[10] && mobCapcha == null)
			{
				GameCanvas.keyPressed[10] = false;
				info2.M759(10);
				GameCanvas.M483();
			}
			M576();
			if (!Char.M113().isFlyAndCharge)
			{
				M577();
			}
			if (Char.M113().cmdMenu != null && Char.M113().cmdMenu.M298())
			{
				Char.M113().cmdMenu.M294();
			}
			if (Char.M113().skillPaint != null)
			{
				return;
			}
			if (GameCanvas.keyAsciiPress != 0)
			{
				if (mobCapcha == null)
				{
					if (TField.isQwerty)
					{
						if (GameCanvas.keyPressed[1])
						{
							if (keySkill[0] != null)
							{
								M601(keySkill[0], isShortcut: true);
							}
						}
						else if (GameCanvas.keyPressed[2])
						{
							if (keySkill[1] != null)
							{
								M601(keySkill[1], isShortcut: true);
							}
						}
						else if (GameCanvas.keyPressed[3])
						{
							if (keySkill[2] != null)
							{
								M601(keySkill[2], isShortcut: true);
							}
						}
						else if (GameCanvas.keyPressed[4])
						{
							if (keySkill[3] != null)
							{
								M601(keySkill[3], isShortcut: true);
							}
						}
						else if (GameCanvas.keyPressed[5])
						{
							if (keySkill[4] != null)
							{
								M601(keySkill[4], isShortcut: true);
							}
						}
						else if (GameCanvas.keyPressed[6])
						{
							if (keySkill[5] != null)
							{
								M601(keySkill[5], isShortcut: true);
							}
						}
						else if (GameCanvas.keyPressed[7])
						{
							if (keySkill[6] != null)
							{
								M601(keySkill[6], isShortcut: true);
							}
						}
						else if (GameCanvas.keyPressed[8])
						{
							if (keySkill[7] != null)
							{
								M601(keySkill[7], isShortcut: true);
							}
						}
						else if (GameCanvas.keyPressed[9])
						{
							if (keySkill[8] != null)
							{
								M601(keySkill[8], isShortcut: true);
							}
						}
						else if (GameCanvas.keyPressed[0])
						{
							if (keySkill[9] != null)
							{
								M601(keySkill[9], isShortcut: true);
							}
						}
						else if (GameCanvas.keyAsciiPress == 114)
						{
							ChatTextField.M279().M281(this, string.Empty);
						}
						else if (!GameAutomationHub.M2171(GameCanvas.keyAsciiPress))
						{
						}
					}
					else if (!GameCanvas.isMoveNumberPad)
					{
						ChatTextField.M279().M280(GameCanvas.keyAsciiPress, this, string.Empty);
					}
					else if (GameCanvas.keyAsciiPress == 55)
					{
						if (keySkill[0] != null)
						{
							M601(keySkill[0], isShortcut: true);
						}
					}
					else if (GameCanvas.keyAsciiPress == 56)
					{
						if (keySkill[1] != null)
						{
							M601(keySkill[1], isShortcut: true);
						}
					}
					else if (GameCanvas.keyAsciiPress == 57)
					{
						if (keySkill[(!Main.isPC) ? 2 : 21] != null)
						{
							M601(keySkill[2], isShortcut: true);
						}
					}
					else if (GameCanvas.keyAsciiPress == 48)
					{
						ChatTextField.M279().M281(this, string.Empty);
					}
				}
				else
				{
					char[] array = keyInput.ToCharArray();
					MyVector t = new MyVector();
					for (int j = 0; j < array.Length; j++)
					{
						t.M1111(array[j] + string.Empty);
					}
					t.M1118(0);
					string text = (char)GameCanvas.keyAsciiPress + string.Empty;
					if (text.Equals(string.Empty) || text == null || text.Equals("\n"))
					{
						text = "-";
					}
					t.M1121(text, t.M1113());
					keyInput = string.Empty;
					for (int k = 0; k < t.M1113(); k++)
					{
						keyInput += ((string)t.M1114(k)).ToUpper();
					}
					Service.M1594().M1607((char)GameCanvas.keyAsciiPress);
				}
				GameCanvas.keyAsciiPress = 0;
			}
			if (Char.M113().statusMe == 1)
			{
				GameCanvas.M456("F10", 0);
				if (!doSeleckSkillFlag)
				{
					if (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25])
					{
						GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
						M597(isFireByShortCut: false, skipWaypoint: false);
					}
					else if (GameCanvas.keyHold[(!Main.isPC) ? 2 : 21])
					{
						if (!Char.M113().isLockMove)
						{
							M610(0);
						}
					}
					else if (GameCanvas.keyHold[1] && mobCapcha == null)
					{
						if (!Main.isPC)
						{
							Char.M113().cdir = -1;
							if (!Char.M113().isLockMove)
							{
								M610(-4);
							}
						}
					}
					else if (GameCanvas.keyHold[(!Main.isPC) ? 5 : 25] && mobCapcha == null)
					{
						if (!Main.isPC)
						{
							Char.M113().cdir = 1;
							if (!Char.M113().isLockMove)
							{
								M610(4);
							}
						}
					}
					else if (GameCanvas.keyHold[(!Main.isPC) ? 4 : 23])
					{
						isAutoPlay = false;
						Char.M113().isAttack = false;
						if (Char.M113().cdir == 1)
						{
							Char.M113().cdir = -1;
						}
						else if (!Char.M113().isLockMove)
						{
							if (Char.M113().cx - Char.M113().cxSend != 0)
							{
								Service.M1594().M1640();
							}
							Char.M113().statusMe = 2;
							Char.M113().cvx = -Char.M113().cspeed;
						}
						Char.M113().holder = false;
					}
					else if (GameCanvas.keyHold[(!Main.isPC) ? 6 : 24])
					{
						isAutoPlay = false;
						Char.M113().isAttack = false;
						if (Char.M113().cdir == -1)
						{
							Char.M113().cdir = 1;
						}
						else if (!Char.M113().isLockMove)
						{
							if (Char.M113().cx - Char.M113().cxSend != 0)
							{
								Service.M1594().M1640();
							}
							Char.M113().statusMe = 2;
							Char.M113().cvx = Char.M113().cspeed;
						}
						Char.M113().holder = false;
					}
				}
			}
			else if (Char.M113().statusMe == 2)
			{
				GameCanvas.M456("F11", 0);
				if (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25])
				{
					GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
					M597(isFireByShortCut: false, skipWaypoint: true);
				}
				else if (GameCanvas.keyHold[(!Main.isPC) ? 2 : 21])
				{
					if (Char.M113().cx - Char.M113().cxSend != 0 || Char.M113().cy - Char.M113().cySend != 0)
					{
						Service.M1594().M1640();
					}
					Char.M113().cvy = -10;
					Char.M113().statusMe = 3;
					Char.M113().cp1 = 0;
				}
				else if (GameCanvas.keyHold[1] && mobCapcha == null)
				{
					if (Main.isPC)
					{
						if (Char.M113().cx - Char.M113().cxSend != 0 || Char.M113().cy - Char.M113().cySend != 0)
						{
							Service.M1594().M1640();
						}
						Char.M113().cdir = -1;
						Char.M113().cvy = -10;
						Char.M113().cvx = -4;
						Char.M113().statusMe = 3;
						Char.M113().cp1 = 0;
					}
				}
				else if (GameCanvas.keyHold[3] && mobCapcha == null)
				{
					if (!Main.isPC)
					{
						if (Char.M113().cx - Char.M113().cxSend != 0 || Char.M113().cy - Char.M113().cySend != 0)
						{
							Service.M1594().M1640();
						}
						Char.M113().cdir = 1;
						Char.M113().cvy = -10;
						Char.M113().cvx = 4;
						Char.M113().statusMe = 3;
						Char.M113().cp1 = 0;
					}
				}
				else if (GameCanvas.keyHold[(!Main.isPC) ? 4 : 23])
				{
					isAutoPlay = false;
					if (Char.M113().cdir == 1)
					{
						Char.M113().cdir = -1;
					}
					else
					{
						Char.M113().cvx = -Char.M113().cspeed + Char.M113().cBonusSpeed;
					}
				}
				else if (GameCanvas.keyHold[(!Main.isPC) ? 6 : 24])
				{
					isAutoPlay = false;
					if (Char.M113().cdir == -1)
					{
						Char.M113().cdir = 1;
					}
					else
					{
						Char.M113().cvx = Char.M113().cspeed + Char.M113().cBonusSpeed;
					}
				}
			}
			else if (Char.M113().statusMe == 3)
			{
				isAutoPlay = false;
				GameCanvas.M456("F12", 0);
				if (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25])
				{
					GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
					M597(isFireByShortCut: false, skipWaypoint: true);
				}
				if (!GameCanvas.keyHold[(!Main.isPC) ? 4 : 23] && (!GameCanvas.keyHold[1] || mobCapcha != null))
				{
					if (GameCanvas.keyHold[(!Main.isPC) ? 6 : 24] || (GameCanvas.keyHold[3] && mobCapcha == null))
					{
						if (Char.M113().cdir == -1)
						{
							Char.M113().cdir = 1;
						}
						else
						{
							Char.M113().cvx = Char.M113().cspeed;
						}
					}
				}
				else if (Char.M113().cdir == 1)
				{
					Char.M113().cdir = -1;
				}
				else
				{
					Char.M113().cvx = -Char.M113().cspeed;
				}
				if ((GameCanvas.keyHold[(!Main.isPC) ? 2 : 21] || ((GameCanvas.keyHold[1] || GameCanvas.keyHold[3]) && mobCapcha == null)) && Char.M113().canFly && Char.M113().cMP > 0 && Char.M113().cp1 < 8 && Char.M113().cvy > -4)
				{
					Char.M113().cp1++;
					Char.M113().cvy = -7;
				}
			}
			else if (Char.M113().statusMe == 4)
			{
				GameCanvas.M456("F13", 0);
				if (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25])
				{
					GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
					M597(isFireByShortCut: false, skipWaypoint: true);
				}
				if (GameCanvas.keyHold[(!Main.isPC) ? 2 : 21] && Char.M113().cMP > 0 && Char.M113().canFly)
				{
					isAutoPlay = false;
					if ((Char.M113().cx - Char.M113().cxSend != 0 || Char.M113().cy - Char.M113().cySend != 0) && (Res.M1529(Char.M113().cx - Char.M113().cxSend) > 96 || Res.M1529(Char.M113().cy - Char.M113().cySend) > 24))
					{
						Service.M1594().M1640();
					}
					Char.M113().cvy = -10;
					Char.M113().statusMe = 3;
					Char.M113().cp1 = 0;
				}
				if (GameCanvas.keyHold[(!Main.isPC) ? 4 : 23])
				{
					isAutoPlay = false;
					if (Char.M113().cdir == 1)
					{
						Char.M113().cdir = -1;
					}
					else
					{
						Char.M113().cp1++;
						Char.M113().cvx = -Char.M113().cspeed;
						if (Char.M113().cp1 > 5 && Char.M113().cvy > 6)
						{
							Char.M113().statusMe = 10;
							Char.M113().cp1 = 0;
							Char.M113().cvy = 0;
						}
					}
				}
				else if (GameCanvas.keyHold[(!Main.isPC) ? 6 : 24])
				{
					isAutoPlay = false;
					if (Char.M113().cdir == -1)
					{
						Char.M113().cdir = 1;
					}
					else
					{
						Char.M113().cp1++;
						Char.M113().cvx = Char.M113().cspeed;
						if (Char.M113().cp1 > 5 && Char.M113().cvy > 6)
						{
							Char.M113().statusMe = 10;
							Char.M113().cp1 = 0;
							Char.M113().cvy = 0;
						}
					}
				}
			}
			else if (Char.M113().statusMe == 10)
			{
				GameCanvas.M456("F14", 0);
				if (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25])
				{
					GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
					M597(isFireByShortCut: false, skipWaypoint: true);
				}
				if (Char.M113().canFly && Char.M113().cMP > 0)
				{
					if (GameCanvas.keyHold[(!Main.isPC) ? 2 : 21])
					{
						isAutoPlay = false;
						if ((Char.M113().cx - Char.M113().cxSend != 0 || Char.M113().cy - Char.M113().cySend != 0) && (Res.M1529(Char.M113().cx - Char.M113().cxSend) > 96 || Res.M1529(Char.M113().cy - Char.M113().cySend) > 24))
						{
							Service.M1594().M1640();
						}
						Char.M113().cvy = -10;
						Char.M113().statusMe = 3;
						Char.M113().cp1 = 0;
					}
					else if (GameCanvas.keyHold[(!Main.isPC) ? 4 : 23])
					{
						isAutoPlay = false;
						if (Char.M113().cdir == 1)
						{
							Char.M113().cdir = -1;
						}
						else
						{
							Char.M113().cvx = -(Char.M113().cspeed + 1);
						}
					}
					else if (GameCanvas.keyHold[(!Main.isPC) ? 6 : 24])
					{
						if (Char.M113().cdir == -1)
						{
							Char.M113().cdir = 1;
						}
						else
						{
							Char.M113().cvx = Char.M113().cspeed + 1;
						}
					}
				}
			}
			else if (Char.M113().statusMe == 7)
			{
				GameCanvas.M456("F15", 0);
				if (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25])
				{
					GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
				}
				if (GameCanvas.keyHold[(!Main.isPC) ? 4 : 23])
				{
					isAutoPlay = false;
					if (Char.M113().cdir == 1)
					{
						Char.M113().cdir = -1;
					}
					else
					{
						Char.M113().cvx = -Char.M113().cspeed + 2;
					}
				}
				else if (GameCanvas.keyHold[(!Main.isPC) ? 6 : 24])
				{
					isAutoPlay = false;
					if (Char.M113().cdir == -1)
					{
						Char.M113().cdir = 1;
					}
					else
					{
						Char.M113().cvx = Char.M113().cspeed - 2;
					}
				}
			}
			GameCanvas.M456("F17", 0);
			if (GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22] && GameCanvas.keyAsciiPress != 56)
			{
				GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22] = false;
				Char.M113().delayFall = 0;
			}
			if (GameCanvas.keyPressed[10])
			{
				GameCanvas.keyPressed[10] = false;
				M589();
			}
			GameCanvas.M456("F20", 0);
			GameCanvas.M483();
			GameCanvas.M456("F23", 0);
			doSeleckSkillFlag = false;
		}
	}

	public bool M575()
	{
		return true;
	}

	private void M576()
	{
		if (isAnalog == 1 || gamePad.M529())
		{
			return;
		}
		Char.M113().cmtoChar = true;
		if (isUseTouch)
		{
			return;
		}
		if (GameCanvas.isPointerJustDown)
		{
			GameCanvas.isPointerJustDown = false;
			isPointerDowning = true;
			ptDownTime = 0;
			ptLastDownX = (ptFirstDownX = GameCanvas.px);
			ptLastDownY = (ptFirstDownY = GameCanvas.py);
		}
		if (isPointerDowning)
		{
			int num = GameCanvas.px - ptLastDownX;
			int num2 = GameCanvas.py - ptLastDownY;
			if (!isChangingCameraMode && (Res.M1529(GameCanvas.px - ptFirstDownX) > 15 || Res.M1529(GameCanvas.py - ptFirstDownY) > 15))
			{
				isChangingCameraMode = true;
			}
			ptLastDownX = GameCanvas.px;
			ptLastDownY = GameCanvas.py;
			ptDownTime++;
			if (isChangingCameraMode)
			{
				Char.M113().cmtoChar = false;
				cmx -= num;
				cmy -= num2;
				if (cmx < 24)
				{
					int num3 = (24 - cmx) / 3;
					if (num3 != 0)
					{
						cmx += num - num / num3;
					}
				}
				if (cmx < (M575() ? 24 : 0))
				{
					cmx = (M575() ? 24 : 0);
				}
				if (cmx > cmxLim)
				{
					int num4 = (cmx - cmxLim) / 3;
					if (num4 != 0)
					{
						cmx += num - num / num4;
					}
				}
				if (cmx > cmxLim + ((!M575()) ? 24 : 0))
				{
					cmx = cmxLim + ((!M575()) ? 24 : 0);
				}
				if (cmy < 0)
				{
					int num5 = -cmy / 3;
					if (num5 != 0)
					{
						cmy += num2 - num2 / num5;
					}
				}
				if (cmy < -((!M575()) ? 24 : 0))
				{
					cmy = -((!M575()) ? 24 : 0);
				}
				if (cmy > cmyLim)
				{
					cmy = cmyLim;
				}
				cmtoX = cmx;
				cmtoY = cmy;
			}
		}
		if (isPointerDowning && GameCanvas.isPointerJustRelease)
		{
			isPointerDowning = false;
			isChangingCameraMode = false;
			if (Res.M1529(GameCanvas.px - ptFirstDownX) > 15 || Res.M1529(GameCanvas.py - ptFirstDownY) > 15)
			{
				GameCanvas.isPointerJustRelease = false;
			}
		}
	}

	private void M577()
	{
		if (M600())
		{
			return;
		}
		if (popUpYesNo != null && popUpYesNo.cmdYes != null && popUpYesNo.cmdYes.M298())
		{
			popUpYesNo.cmdYes.M294();
		}
		else
		{
			if (M606())
			{
				return;
			}
			long num = mSystem.M1054();
			if (lastSingleClick != 0L && num - lastSingleClick > 300L)
			{
				lastSingleClick = 0L;
				GameCanvas.isPointerJustDown = false;
				if (!disableSingleClick)
				{
					M584();
					GameCanvas.isPointerJustRelease = false;
				}
			}
			if (GameCanvas.isPointerJustRelease)
			{
				disableSingleClick = M580();
				if (num - lastSingleClick < 300L)
				{
					lastSingleClick = 0L;
					M581();
				}
				else
				{
					lastSingleClick = num;
					lastClickCMX = cmx;
					lastClickCMY = cmy;
				}
				GameCanvas.isPointerJustRelease = false;
			}
		}
	}

	private IMapObject M578(int px, int py)
	{
		IMapObject t = null;
		int num = 0;
		int num2 = 30;
		MyVector[] array = new MyVector[4] { vMob, vNpc, vItemMap, vCharInMap };
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = 0; j < array[i].M1113(); j++)
			{
				IMapObject t2 = (IMapObject)array[i].M1114(j);
				if (t2.isInvisible())
				{
					continue;
				}
				if (t2 is Mob)
				{
					Mob t3 = (Mob)t2;
					if (t3.isMobMe && t3.Equals(Char.M113().mobMe))
					{
						continue;
					}
				}
				int x = t2.getX();
				int y = t2.getY();
				int w = t2.getW();
				int h = t2.getH();
				if (!M579(px, py, x - w / 2 - num2, y - h - num2, w + num2 * 2, h + num2 * 2))
				{
					continue;
				}
				if (t == null)
				{
					t = t2;
					num = Res.M1529(px - x) + Res.M1529(py - y);
					if (i == 1)
					{
						return t;
					}
				}
				else
				{
					int num3 = Res.M1529(px - x) + Res.M1529(py - y);
					if (num3 < num)
					{
						t = t2;
						num = num3;
					}
				}
			}
		}
		return t;
	}

	private bool M579(int xClick, int yClick, int x, int y, int w, int h)
	{
		if (xClick >= x && xClick <= x + w && yClick >= y)
		{
			return yClick <= y + h;
		}
		return false;
	}

	private bool M580()
	{
		int num = GameCanvas.px + cmx;
		int num2 = GameCanvas.py + cmy;
		Char.M113().M228();
		IMapObject t = M578(num, num2);
		if (t == null)
		{
			return false;
		}
		if (Char.M113().M209() && Char.M113().charFocus != null && !t.Equals(Char.M113().charFocus) && !t.Equals(Char.M113().charFocus.mobMe) && t is Char)
		{
			Char t2 = (Char)t;
			if (t2.cTypePk != 5 && !t2.M209())
			{
				M587(num, num2);
				return false;
			}
		}
		if ((Char.M113().mobFocus == t || Char.M113().itemFocus == t) && !Main.isPC)
		{
			M583(t);
			return true;
		}
		if (TileMap.mapID == 51 && t.Equals(Char.M113().npcFocus))
		{
			M587(num, num2);
			return false;
		}
		if (Char.M113().skillPaint == null && Char.M113().arr == null && Char.M113().dart == null && Char.M113().M178() == null)
		{
			Char.M113().M227(t);
			t.stopMoving();
			return false;
		}
		return false;
	}

	private void M581()
	{
		int num = GameCanvas.px + lastClickCMX;
		int num2 = GameCanvas.py + lastClickCMY;
		_ = Char.M113().cy;
		if (isLockKey)
		{
			return;
		}
		IMapObject t = M578(num, num2);
		if (t == null)
		{
			if (!M586(num, num2) && !M585(num, num2) && !Main.isPC)
			{
				M587(num, num2);
			}
		}
		else if (t is Mob && !M571((Mob)t))
		{
			M587(num, num2);
		}
		else
		{
			if (M582(t) || (!t.Equals(Char.M113().npcFocus) && mobCapcha != null))
			{
				return;
			}
			if (Char.M113().M209() && Char.M113().charFocus != null && !t.Equals(Char.M113().charFocus) && !t.Equals(Char.M113().charFocus.mobMe) && t is Char)
			{
				Char t2 = (Char)t;
				if (t2.cTypePk != 5 && !t2.M209())
				{
					M587(num, num2);
					return;
				}
			}
			if (TileMap.mapID == 51 && t.Equals(Char.M113().npcFocus))
			{
				M587(num, num2);
			}
			else
			{
				M583(t);
			}
		}
	}

	private bool M582(IMapObject Object)
	{
		if (Object == null)
		{
			return false;
		}
		int y = Object.getY();
		int num = Char.M113().cy;
		if (y < num)
		{
			while (y < num)
			{
				num -= 5;
				if (TileMap.M1958(Char.M113().cx, num, 8192))
				{
					auto = 0;
					Char.M113().M228();
					Char.M113().currentMovePoint = null;
					return true;
				}
			}
		}
		return false;
	}

	public void M583(IMapObject obj)
	{
		if ((obj.Equals(Char.M113().npcFocus) || mobCapcha == null) && !M582(obj))
		{
			M622(obj);
			Char.M113().M228();
			Char.M113().currentMovePoint = null;
			Char t = Char.M113();
			Char.M113().cvy = 0;
			t.cvx = 0;
			obj.stopMoving();
			auto = 10;
			M597(isFireByShortCut: false, skipWaypoint: true);
			clickToX = obj.getX();
			clickToY = obj.getY();
			clickOnTileTop = false;
			clickMoving = true;
			clickMovingRed = true;
			clickMovingTimeOut = 20;
			clickMovingP1 = 30;
		}
	}

	private void M584()
	{
		int xClick = GameCanvas.px + lastClickCMX;
		int yClick = GameCanvas.py + lastClickCMY;
		if (!isLockKey && !M586(xClick, yClick) && !M585(xClick, yClick))
		{
			M587(xClick, yClick);
		}
	}

	private bool M585(int xClick, int yClick)
	{
		if (Equals(info2) && M559().popUpYesNo != null)
		{
			return false;
		}
		if (info2.info.info != null && info2.info.info.charInfo != null)
		{
			int x = Res.M1529(info2.cmx) + info2.info.X - 40;
			int y = Res.M1529(info2.cmy) + info2.info.Y;
			if (M579(xClick - cmx, yClick - cmy, x, y, 200, info2.info.H))
			{
				info2.M759(10);
				return true;
			}
		}
		return false;
	}

	private bool M586(int xClick, int yClick)
	{
		int num = 0;
		PopUp t;
		while (true)
		{
			if (num < PopUp.vPopups.M1113())
			{
				t = (PopUp)PopUp.vPopups.M1114(num);
				if (M579(xClick, yClick, t.cx, t.cy, t.cw, t.ch))
				{
					if (t.cy <= 24 && TileMap.M1945() && Char.M113().cTypePk != 0)
					{
						return false;
					}
					if (t.isPaint)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return false;
		}
		t.M1484(10);
		return true;
	}

	private void M587(int xClick, int yClick)
	{
		if (gamePad.M530())
		{
			return;
		}
		Char.M113().M228();
		if (xClick < TileMap.pxw && xClick > TileMap.pxw - 32)
		{
			Char.M113().currentMovePoint = new MovePoint(TileMap.pxw, yClick);
			return;
		}
		if (xClick < 32 && xClick > 0)
		{
			Char.M113().currentMovePoint = new MovePoint(0, yClick);
			return;
		}
		if (xClick < TileMap.pxw && xClick > TileMap.pxw - 48)
		{
			Char.M113().currentMovePoint = new MovePoint(TileMap.pxw, yClick);
			return;
		}
		if (xClick < 48 && xClick > 0)
		{
			Char.M113().currentMovePoint = new MovePoint(0, yClick);
			return;
		}
		clickToX = xClick;
		clickToY = yClick;
		clickOnTileTop = false;
		Char.M113().delayFall = 0;
		int num = ((!Char.M113().canFly || Char.M113().cMP <= 0) ? 1000 : 0);
		if (clickToY > Char.M113().cy && Res.M1529(clickToX - Char.M113().cx) < 12)
		{
			return;
		}
		for (int i = 0; i < 60 + num && clickToY + i < TileMap.pxh - 24; i += 24)
		{
			if (TileMap.M1958(clickToX, clickToY + i, 2))
			{
				clickToY = TileMap.M1962(clickToY + i);
				clickOnTileTop = true;
				break;
			}
		}
		for (int j = 0; j < 40 + num; j += 24)
		{
			if (TileMap.M1958(clickToX, clickToY - j, 2))
			{
				clickToY = TileMap.M1962(clickToY - j);
				clickOnTileTop = true;
				break;
			}
		}
		clickMoving = true;
		clickMovingRed = false;
		clickMovingP1 = ((!clickOnTileTop) ? 30 : ((yClick >= clickToY) ? clickToY : yClick));
		Char.M113().delayFall = 0;
		if (!clickOnTileTop && clickToY < Char.M113().cy - 50)
		{
			Char.M113().delayFall = 20;
		}
		clickMovingTimeOut = 30;
		auto = 0;
		if (Char.M113().holder)
		{
			Char.M113().M233();
		}
		Char.M113().currentMovePoint = new MovePoint(clickToX, clickToY);
		Char.M113().cdir = ((Char.M113().cx - Char.M113().currentMovePoint.xEnd <= 0) ? 1 : (-1));
		Char.M113().endMovePointCommand = null;
		isAutoPlay = false;
	}

	private void M588()
	{
		long num = mSystem.M1054();
		if (GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21] || GameCanvas.keyPressed[(!Main.isPC) ? 4 : 23] || GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24] || GameCanvas.keyPressed[1] || GameCanvas.keyPressed[3])
		{
			auto = 0;
			isAutoPlay = false;
		}
		if (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] && !M652())
		{
			if (auto == 0)
			{
				if (num - lastFire < 800L && M573() && (Char.M113().mobFocus != null || (Char.M113().charFocus != null && Char.M113().M225(Char.M113().charFocus))))
				{
					Res.M1513("toi day");
					auto = 10;
					GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
				}
			}
			else
			{
				auto = 0;
				bool[] keyPressed = GameCanvas.keyPressed;
				int num2 = ((!Main.isPC) ? 4 : 23);
				GameCanvas.keyPressed[(!Main.isPC) ? 6 : 24] = false;
				keyPressed[num2] = false;
			}
			lastFire = num;
		}
		if (GameCanvas.gameTick % 5 == 0 && auto > 0 && Char.M113().currentMovePoint == null)
		{
			if (Char.M113().myskill != null && (Char.M113().myskill.template.M1775() || Char.M113().myskill.paintCanNotUseSkill))
			{
				return;
			}
			if ((Char.M113().mobFocus != null && Char.M113().mobFocus.status != 1 && Char.M113().mobFocus.status != 0 && Char.M113().charFocus == null) || (Char.M113().charFocus != null && Char.M113().M225(Char.M113().charFocus)))
			{
				if (Char.M113().myskill.paintCanNotUseSkill)
				{
					return;
				}
				M597(isFireByShortCut: false, skipWaypoint: true);
			}
		}
		if (auto > 1)
		{
			auto--;
		}
	}

	public void M589()
	{
		if (Char.M113().stone || Char.M113().blindEff || Char.M113().holdEffID > 0)
		{
			return;
		}
		long num = mSystem.M1054();
		if (num - lastUsePotion >= 10000L)
		{
			if (!Char.M113().M223())
			{
				info1.M762(mResources.HP_EMPTY, 0);
				return;
			}
			ServerEffect.M1574(11, Char.M113(), 5);
			ServerEffect.M1574(104, Char.M113(), 4);
			lastUsePotion = num;
			SoundMn.M1826().M1863();
		}
	}

	public void M590(int x, int y)
	{
		if (!isSuperPower)
		{
			SoundMn.M1826().M1843();
			isSuperPower = true;
			tPower = 0;
			dxPower = 0;
			xPower = x - cmx;
			yPower = y - cmy;
		}
	}

	public void M591(bool isMe)
	{
		activeRongThan = true;
		isUseFreez = true;
		isMeCallRongThan = true;
		if (isMe)
		{
			EffectMn.M376(new Effect(20, Char.M113().cx, Char.M113().cy - 77, 2, 8, 1));
		}
	}

	public void M592()
	{
		activeRongThan = false;
		isUseFreez = true;
		isMeCallRongThan = false;
	}

	public void M593()
	{
		isRongThanXuatHien = true;
		mautroi = mGraphics.M964(0.4f, 0, GameCanvas.colorTop[GameCanvas.colorTop.Length - 1]);
	}

	public void M594(int x, int y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Res.M1513("VE RONG THAN O VI TRI x= " + x + " y=" + y);
		M593();
		EffectMn.M376(new Effect((!isRongNamek) ? 17 : 25, x, y - 77, 2, -1, 1));
	}

	public void M595()
	{
		isRongThanXuatHien = false;
		EffectMn.M377(17);
		if (isRongNamek)
		{
			isRongNamek = false;
			EffectMn.M377(25);
		}
	}

	private void M596()
	{
		if (timeSkill > 0)
		{
			timeSkill--;
		}
		if (!canAutoPlay || isChangeZone || Char.M113().statusMe == 14 || Char.M113().statusMe == 5 || Char.M113().isCharge || Char.M113().isFlyAndCharge || Char.M113().M171())
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < vMob.M1113(); i++)
		{
			Mob t = (Mob)vMob.M1114(i);
			if (t.status != 0 && t.status != 1)
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		bool flag2 = false;
		for (int j = 0; j < Char.M113().arrItemBag.Length; j++)
		{
			Item t2 = Char.M113().arrItemBag[j];
			if (t2 != null && t2.template.type == 6)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2 && GameCanvas.gameTick % 150 == 0)
		{
			Service.M1594().M1735();
		}
		if (Char.M113().cHP <= Char.M113().cHPFull * 20 / 100 || Char.M113().cMP <= Char.M113().cMPFull * 20 / 100)
		{
			M589();
		}
		if (Char.M113().mobFocus != null && (Char.M113().mobFocus == null || !Char.M113().mobFocus.isMobMe))
		{
			if (Char.M113().mobFocus.hp <= 0 || Char.M113().mobFocus.status == 1 || Char.M113().mobFocus.status == 0)
			{
				Char.M113().mobFocus = null;
			}
		}
		else
		{
			for (int k = 0; k < vMob.M1113(); k++)
			{
				Mob t3 = (Mob)vMob.M1114(k);
				if (t3.status != 0 && t3.status != 1 && t3.hp > 0 && !t3.isMobMe)
				{
					Char.M113().cx = t3.x;
					Char.M113().cy = t3.y;
					Char.M113().mobFocus = t3;
					Service.M1594().M1640();
					Res.M1513("focus 1 con bossssssssssssssssssssssssssssssssssssssssssssssssss");
					break;
				}
			}
		}
		if (Char.M113().mobFocus == null || timeSkill != 0 || (Char.M113().M178() != null && Char.M113().indexSkill < Char.M113().M178().Length && Char.M113().dart != null && Char.M113().arr != null))
		{
			return;
		}
		Skill t4 = null;
		if (GameCanvas.isTouch)
		{
			for (int l = 0; l < onScreenSkill.Length; l++)
			{
				if (onScreenSkill[l] == null || onScreenSkill[l].paintCanNotUseSkill || onScreenSkill[l].template.id == 10 || onScreenSkill[l].template.id == 11 || onScreenSkill[l].template.id == 14 || onScreenSkill[l].template.id == 23 || onScreenSkill[l].template.id == 7 || Char.M113().M178() != null)
				{
					continue;
				}
				int num = ((onScreenSkill[l].template.manaUseType == 2) ? 1 : ((onScreenSkill[l].template.manaUseType == 1) ? (onScreenSkill[l].manaUse * Char.M113().cMPFull / 100) : onScreenSkill[l].manaUse));
				if (Char.M113().cMP >= num)
				{
					if (t4 == null)
					{
						t4 = onScreenSkill[l];
					}
					else if (t4.coolDown < onScreenSkill[l].coolDown)
					{
						t4 = onScreenSkill[l];
					}
				}
			}
			if (t4 != null)
			{
				M601(t4, isShortcut: true);
				M583(Char.M113().mobFocus);
			}
			return;
		}
		for (int m = 0; m < keySkill.Length; m++)
		{
			if (keySkill[m] == null || keySkill[m].paintCanNotUseSkill || keySkill[m].template.id == 10 || keySkill[m].template.id == 11 || keySkill[m].template.id == 14 || keySkill[m].template.id == 23 || keySkill[m].template.id == 7 || Char.M113().M178() != null)
			{
				continue;
			}
			int num2 = ((keySkill[m].template.manaUseType == 2) ? 1 : ((keySkill[m].template.manaUseType == 1) ? (keySkill[m].manaUse * Char.M113().cMPFull / 100) : keySkill[m].manaUse));
			if (Char.M113().cMP >= num2)
			{
				if (t4 == null)
				{
					t4 = keySkill[m];
				}
				else if (t4.coolDown < keySkill[m].coolDown)
				{
					t4 = keySkill[m];
				}
			}
		}
		if (t4 != null)
		{
			M601(t4, isShortcut: true);
			M583(Char.M113().mobFocus);
		}
	}

	private void M597(bool isFireByShortCut, bool skipWaypoint)
	{
		tam++;
		Waypoint t = Char.M113().M120();
		Waypoint t2 = Char.M113().M121();
		if (!skipWaypoint && t != null && (Char.M113().mobFocus == null || (Char.M113().mobFocus != null && Char.M113().mobFocus.templateId == 0)))
		{
			t.popup.command.M294();
		}
		else if (!skipWaypoint && t2 != null && (Char.M113().mobFocus == null || (Char.M113().mobFocus != null && Char.M113().mobFocus.templateId == 0)))
		{
			t2.popup.command.M294();
		}
		else
		{
			if ((TileMap.mapID == 51 && Char.M113().npcFocus != null) || Char.M113().statusMe == 14)
			{
				return;
			}
			Char t3 = Char.M113();
			Char.M113().cvy = 0;
			t3.cvx = 0;
			if (Char.M113().M169() && Char.M113().M229())
			{
				if (M572())
				{
					Char.M113().currentFireByShortcut = isFireByShortCut;
					Char.M113().M173();
				}
			}
			else if (M570())
			{
				if (Char.M113().M171() && Char.M113().M229())
				{
					if (M572())
					{
						Char.M113().currentFireByShortcut = isFireByShortCut;
						Char.M113().M174();
					}
					else
					{
						Char.M113().M175();
					}
				}
				else
				{
					bool flag = TileMap.M1958(Char.M113().cx, Char.M113().cy, 2);
					Char.M113().M172(sks[Char.M113().myskill.skillId], (!flag) ? 1 : 0);
					if (flag)
					{
						Char.M113().delayFall = 20;
					}
					Char.M113().currentFireByShortcut = isFireByShortCut;
				}
			}
			if (Char.M113().M170())
			{
				auto = 0;
			}
		}
	}

	private void M598()
	{
		Npc t = new Npc(5, 0, -100, 100, 5, info1.charId[Char.M113().cgender][2]);
		string nhatvatpham = mResources.nhatvatpham;
		string[] menu = new string[2]
		{
			mResources.YES,
			mResources.NO
		};
		t.idItem = 673;
		M559().M553(menu, t);
		ChatPopup.M270(nhatvatpham, 100000, t, 5820);
	}

	public void M599()
	{
		if (Char.M113().itemFocus == null)
		{
			return;
		}
		if (Char.M113().cx < Char.M113().itemFocus.x)
		{
			Char.M113().cdir = 1;
		}
		else
		{
			Char.M113().cdir = -1;
		}
		int num = Math.M869(Char.M113().cx - Char.M113().itemFocus.x);
		int num2 = Math.M869(Char.M113().cy - Char.M113().itemFocus.y);
		if (num > 40 || num2 >= 40)
		{
			Char.M113().currentMovePoint = new MovePoint(Char.M113().itemFocus.x, Char.M113().itemFocus.y);
			Char.M113().endMovePointCommand = new Command(null, null, 8002, null);
			GameCanvas.M484();
			GameCanvas.M483();
			return;
		}
		GameCanvas.M484();
		GameCanvas.M483();
		if (Char.M113().itemFocus.template.id != 673)
		{
			Service.M1594().M1670(Char.M113().itemFocus.itemMapID);
		}
		else
		{
			M598();
		}
	}

	public bool M600()
	{
		if (!Char.M113().isFlyAndCharge && !Char.M113().isUseSkillAfterCharge && !Char.M113().isStandAndCharge && !Char.M113().isWaitMonkey && !isSuperPower)
		{
			return Char.M113().isFreez;
		}
		return true;
	}

	public void M601(Skill skill, bool isShortcut)
	{
		if (Char.M113().isCreateDark || M600() || Char.M113().taskMaint.taskId <= 1)
		{
			return;
		}
		Char.M113().myskill = skill;
		if (lastSkill != skill && lastSkill != null)
		{
			Service.M1594().M1652(skill.template.id);
			M549(skill.template.id);
			M574();
			lastSkill = skill;
			selectedIndexSkill = -1;
			M559().auto = 0;
			return;
		}
		if (Char.M113().M169())
		{
			Res.M1513("use skill not focus");
			M603(skill);
			lastSkill = skill;
			return;
		}
		selectedIndexSkill = -1;
		if (skill == null)
		{
			return;
		}
		Res.M1513("only select skill");
		if (lastSkill != skill)
		{
			Service.M1594().M1652(skill.template.id);
			M549(skill.template.id);
			M574();
		}
		if (Char.M113().charFocus != null || !Char.M113().M170())
		{
			if (Char.M113().M229())
			{
				M597(isShortcut, skipWaypoint: true);
				doSeleckSkillFlag = true;
			}
			lastSkill = skill;
		}
	}

	public void M602(Skill skill, bool isShortcut)
	{
		if ((TileMap.mapID == 112 || TileMap.mapID == 113) && Char.M113().cTypePk == 0)
		{
			return;
		}
		if (Char.M113().M169())
		{
			Res.M1513("HERE");
			M603(skill);
			return;
		}
		selectedIndexSkill = -1;
		if (skill != null)
		{
			Service.M1594().M1652(skill.template.id);
			M549(skill.template.id);
			M574();
			Char.M113().myskill = skill;
			M597(isShortcut, skipWaypoint: true);
		}
	}

	public void M603(Skill skill)
	{
		if (((TileMap.mapID != 112 && TileMap.mapID != 113) || Char.M113().cTypePk != 0) && M572())
		{
			selectedIndexSkill = -1;
			if (skill != null)
			{
				Service.M1594().M1652(skill.template.id);
				M549(skill.template.id);
				M574();
				Char.M113().myskill = skill;
				Char.M113().M173();
				Char.M113().currentFireByShortcut = true;
				auto = 0;
			}
		}
	}

	public void M604()
	{
		for (int i = 0; i < Char.M113().vSkillFight.M1113() - 1; i++)
		{
			Skill t = (Skill)Char.M113().vSkillFight.M1114(i);
			for (int j = i + 1; j < Char.M113().vSkillFight.M1113(); j++)
			{
				Skill t2 = (Skill)Char.M113().vSkillFight.M1114(j);
				if (t2.template.id < t.template.id)
				{
					Skill t3 = t2;
					t2 = t;
					t = t3;
					Char.M113().vSkillFight.M1116(t, i);
					Char.M113().vSkillFight.M1116(t2, j);
				}
			}
		}
	}

	public void M605()
	{
		if (M653())
		{
			return;
		}
		for (int i = 0; i < strCapcha.Length; i++)
		{
			keyCapcha[i] = -1;
			if (!GameCanvas.isTouchControl)
			{
				continue;
			}
			int num = (GameCanvas.w - strCapcha.Length * disXC) / 2;
			int w = strCapcha.Length * disXC;
			if (!GameCanvas.M481(num, GameCanvas.h - 40, w, disXC))
			{
				continue;
			}
			int num2 = (GameCanvas.px - num) / disXC;
			if (i == num2)
			{
				keyCapcha[i] = 1;
			}
			if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease && i == num2)
			{
				char[] array = keyInput.ToCharArray();
				MyVector t = new MyVector();
				for (int j = 0; j < array.Length; j++)
				{
					t.M1111(array[j] + string.Empty);
				}
				t.M1118(0);
				t.M1121(strCapcha[i] + string.Empty, t.M1113());
				keyInput = string.Empty;
				for (int k = 0; k < t.M1113(); k++)
				{
					keyInput += ((string)t.M1114(k)).ToUpper();
				}
				Service.M1594().M1607(strCapcha[i]);
			}
		}
	}

	public bool M606()
	{
		if (mobCapcha == null)
		{
			return false;
		}
		return GameCanvas.M481((GameCanvas.w - 5 * disXC) / 2, w: 5 * disXC, y: GameCanvas.h - 40, h: disXC);
	}

	public void M607()
	{
		if (GameCanvas.M482(xC, yC, 34, 34))
		{
			if (!TileMap.M1936())
			{
				mScreen.keyMouse = 15;
			}
		}
		else if (GameCanvas.M482(xHP, yHP, 40, 40))
		{
			if (Char.M113().statusMe != 14)
			{
				mScreen.keyMouse = 10;
			}
		}
		else if (GameCanvas.M482(xF, yF, 40, 40))
		{
			if (Char.M113().statusMe != 14)
			{
				mScreen.keyMouse = 5;
			}
		}
		else if (cmdMenu != null && GameCanvas.M482(cmdMenu.x, cmdMenu.y, cmdMenu.w / 2, cmdMenu.h))
		{
			mScreen.keyMouse = 1;
		}
		else
		{
			mScreen.keyMouse = -1;
		}
	}

	private void M608()
	{
		if (M653())
		{
			return;
		}
		mScreen.keyTouch = -1;
		if (GameCanvas.isTouchControl)
		{
			if (GameCanvas.M481(0, 0, 60, 50) && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
			{
				if (Char.M113().cmdMenu != null)
				{
					Char.M113().cmdMenu.M294();
				}
				Char.M113().currentMovePoint = null;
				GameCanvas.M517();
				flareFindFocus = true;
				flareTime = 5;
				return;
			}
			if (Main.isPC)
			{
				M607();
			}
			if (!TileMap.M1936() && GameCanvas.M481(xC, yC, 34, 34))
			{
				mScreen.keyTouch = 15;
				GameCanvas.isPointerJustDown = false;
				isPointerDowning = false;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					ChatTextField.M279().M281(this, string.Empty);
					SoundMn.M1826().M1857();
					Char.M113().currentMovePoint = null;
					GameCanvas.M517();
					return;
				}
			}
			if (Char.M113().cmdMenu != null && GameCanvas.M481(Char.M113().cmdMenu.x - 17, Char.M113().cmdMenu.y - 17, 34, 34))
			{
				mScreen.keyTouch = 20;
				GameCanvas.isPointerJustDown = false;
				isPointerDowning = false;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					GameCanvas.M517();
					Char.M113().cmdMenu.M294();
					return;
				}
			}
			M674();
			if (((isAnalog != 0) ? GameCanvas.M481(xHP, yHP, 34, 34) : GameCanvas.M481(xHP, yHP, 40, 40)) && Char.M113().statusMe != 14 && mobCapcha == null)
			{
				mScreen.keyTouch = 10;
				GameCanvas.isPointerJustDown = false;
				isPointerDowning = false;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					GameCanvas.keyPressed[10] = true;
					GameCanvas.isPointerJustRelease = false;
					GameCanvas.isPointerJustDown = false;
					GameCanvas.isPointerClick = false;
				}
			}
		}
		if (mobCapcha != null)
		{
			M605();
		}
		else if (isHaveSelectSkill)
		{
			if (M600())
			{
				return;
			}
			keyTouchSkill = -1;
			bool flag = false;
			if (onScreenSkill.Length > 5 && (GameCanvas.M481(xSkill + xS[0] - wSkill / 2 + 12, yS[0] - wSkill / 2 + 12, 5 * wSkill, wSkill) || GameCanvas.M481(xSkill + xS[5] - wSkill / 2 + 12, yS[5] - wSkill / 2 + 12, 5 * wSkill, wSkill)))
			{
				flag = true;
			}
			if (flag || GameCanvas.M481(xSkill + xS[0] - wSkill / 2 + 12, yS[0] - wSkill / 2 + 12, 5 * wSkill, wSkill) || (!GameCanvas.isTouchControl && GameCanvas.M481(xSkill + xS[0] - wSkill / 2 + 12, yS[0] - wSkill / 2 + 12, wSkill, onScreenSkill.Length * wSkill)))
			{
				GameCanvas.isPointerJustDown = false;
				isPointerDowning = false;
				int num = (GameCanvas.pxLast - (xSkill + xS[0] - wSkill / 2 + 12)) / wSkill;
				if (flag && GameCanvas.pyLast < yS[0])
				{
					num += 5;
				}
				keyTouchSkill = num;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					GameCanvas.isPointerJustRelease = false;
					GameCanvas.isPointerJustDown = false;
					GameCanvas.isPointerClick = false;
					selectedIndexSkill = num;
					if (indexSelect < 0)
					{
						indexSelect = 0;
					}
					if (!Main.isPC)
					{
						if (selectedIndexSkill > onScreenSkill.Length - 1)
						{
							selectedIndexSkill = onScreenSkill.Length - 1;
						}
					}
					else if (selectedIndexSkill > keySkill.Length - 1)
					{
						selectedIndexSkill = keySkill.Length - 1;
					}
					Skill t = (Main.isPC ? keySkill[selectedIndexSkill] : onScreenSkill[selectedIndexSkill]);
					if (t != null)
					{
						M601(t, isShortcut: true);
					}
				}
			}
		}
		if (GameCanvas.isPointerJustRelease)
		{
			if (GameCanvas.keyHold[1] || GameCanvas.keyHold[(!Main.isPC) ? 2 : 21] || GameCanvas.keyHold[3] || GameCanvas.keyHold[(!Main.isPC) ? 4 : 23] || GameCanvas.keyHold[(!Main.isPC) ? 6 : 24])
			{
				GameCanvas.isPointerJustRelease = false;
			}
			GameCanvas.keyHold[1] = false;
			GameCanvas.keyHold[(!Main.isPC) ? 2 : 21] = false;
			GameCanvas.keyHold[3] = false;
			GameCanvas.keyHold[(!Main.isPC) ? 4 : 23] = false;
			GameCanvas.keyHold[(!Main.isPC) ? 6 : 24] = false;
		}
	}

	public void M609()
	{
		Char.M113().cvy = -10;
		Char.M113().statusMe = 3;
		Char.M113().cp1 = 0;
	}

	public void M610(int cvx)
	{
		if (Char.M113().cx - Char.M113().cxSend != 0 || Char.M113().cy - Char.M113().cySend != 0)
		{
			Service.M1594().M1640();
		}
		Char.M113().cvy = -10;
		Char.M113().cvx = cvx;
		Char.M113().statusMe = 3;
		Char.M113().cp1 = 0;
	}

	public void M611()
	{
		if (isstarOpen)
		{
			if (moveUp > -3)
			{
				moveUp -= 4;
			}
			else
			{
				moveUp = -2;
			}
			if (moveDow < GameCanvas.h + 3)
			{
				moveDow += 4;
			}
			else
			{
				moveDow = GameCanvas.h + 2;
			}
			if (moveUp <= -2 && moveDow >= GameCanvas.h + 2)
			{
				isstarOpen = false;
			}
		}
	}

	public void M612()
	{
	}

	public void M613()
	{
	}

	public void M614()
	{
		if (tShow == 0)
		{
			return;
		}
		currXS = mSystem.M1054();
		if (currXS - lastXS > 1000L)
		{
			lastXS = mSystem.M1054();
			secondXS++;
		}
		if (secondXS > 20)
		{
			for (int i = 0; i < winnumber.Length; i++)
			{
				randomNumber[i] = winnumber[i];
			}
			tShow--;
			if (tShow == 0)
			{
				yourNumber = string.Empty;
				info1.M762(strFinish, 0);
				secondXS = 0;
			}
			return;
		}
		if (moveIndex > winnumber.Length - 1)
		{
			tShow--;
			if (tShow == 0)
			{
				yourNumber = string.Empty;
				info1.M762(strFinish, 0);
			}
			return;
		}
		if (moveIndex < randomNumber.Length)
		{
			if (tMove[moveIndex] == 15)
			{
				if (randomNumber[moveIndex] == winnumber[moveIndex] - 1)
				{
					delayMove[moveIndex] = 10;
				}
				if (randomNumber[moveIndex] == winnumber[moveIndex])
				{
					tMove[moveIndex] = -1;
					moveIndex++;
				}
			}
			else if (GameCanvas.gameTick % 5 == 0)
			{
				tMove[moveIndex]++;
			}
		}
		for (int j = 0; j < winnumber.Length; j++)
		{
			if (tMove[j] == -1)
			{
				continue;
			}
			moveCount[j]++;
			if (moveCount[j] > tMove[j] + delayMove[j])
			{
				moveCount[j] = 0;
				randomNumber[j]++;
				if (randomNumber[j] >= 10)
				{
					randomNumber[j] = 0;
				}
			}
		}
	}

	public override void update()
	{
		GameAutomationHub.M2163();
		if (GameCanvas.keyPressed[16])
		{
			GameCanvas.keyPressed[16] = false;
			Char.M113().M212();
		}
		if (GameCanvas.keyPressed[13] && !GameCanvas.panel.isShow)
		{
			GameCanvas.keyPressed[13] = false;
			Char.M113().M212();
		}
		if (GameCanvas.keyPressed[17])
		{
			GameCanvas.keyPressed[17] = false;
			Char.M113().M205();
			if (Char.M113().itemFocus != null)
			{
				M599();
			}
		}
		if (GameCanvas.gameTick % 100 == 0 && TileMap.mapID == 137)
		{
			shock_scr = 30;
		}
		M614();
		mSystem.M1050();
		SmallImage.M1787();
		try
		{
			if (LoginScr.isContinueToLogin)
			{
				LoginScr.isContinueToLogin = false;
			}
			if (tickMove == 1)
			{
				lastTick = mSystem.M1054();
			}
			if (tickMove == 100)
			{
				tickMove = 0;
				currTick = mSystem.M1054();
				int second = (int)(currTick - lastTick) / 1000;
				Service.M1594().M1639(second);
			}
			if (lockTick > 0)
			{
				lockTick--;
				if (lockTick == 0)
				{
					Controller.isStopReadMessage = false;
				}
			}
			M613();
			GameCanvas.M456("E1", 0);
			M566();
			GameCanvas.M456("E2", 0);
			ChatTextField.M279().M284();
			GameCanvas.M456("E3", 0);
			for (int i = 0; i < vCharInMap.M1113(); i++)
			{
				((Char)vCharInMap.M1114(i)).update();
			}
			for (int j = 0; j < Teleport.vTeleport.M1113(); j++)
			{
				((Teleport)Teleport.vTeleport.M1114(j)).M1897();
			}
			Char.M113().update();
			_ = Char.M113().statusMe;
			if (popUpYesNo != null)
			{
				popUpYesNo.M1489();
			}
			EffectMn.M384();
			GameCanvas.M456("E5x", 0);
			for (int k = 0; k < vMob.M1113(); k++)
			{
				((Mob)vMob.M1114(k)).update();
			}
			GameCanvas.M456("E6", 0);
			for (int l = 0; l < vNpc.M1113(); l++)
			{
				((Npc)vNpc.M1114(l)).update();
			}
			nSkill = onScreenSkill.Length;
			int num = onScreenSkill.Length - 1;
			while (num >= 0)
			{
				if (onScreenSkill[num] == null)
				{
					nSkill--;
					num--;
					continue;
				}
				nSkill = num + 1;
				break;
			}
			if (nSkill == 1 && GameCanvas.isTouch)
			{
				xSkill = -200;
			}
			else if (xSkill < 0)
			{
				M565();
			}
			GameCanvas.M456("E7", 0);
			GameCanvas.M442().M510();
			GameCanvas.M456("E8", 0);
			M644();
			PopUp.M1486();
			M647();
			M650();
			GameCanvas.M460();
			GameCanvas.M456("E9", 0);
			M623();
			GameCanvas.M456("E10", 0);
			for (int m = 0; m < vItemMap.M1113(); m++)
			{
				((ItemMap)vItemMap.M1114(m)).M823();
			}
			GameCanvas.M456("E11", 0);
			GameCanvas.M456("E13", 0);
			for (int num2 = Effect2.vRemoveEffect2.M1113() - 1; num2 >= 0; num2--)
			{
				Effect2.vEffect2.M1119(Effect2.vRemoveEffect2.M1114(num2));
				Effect2.vRemoveEffect2.M1118(num2);
			}
			for (int n = 0; n < Effect2.vEffect2.M1113(); n++)
			{
				((Effect2)Effect2.vEffect2.M1114(n)).update();
			}
			for (int num3 = 0; num3 < Effect2.vEffect2Outside.M1113(); num3++)
			{
				((Effect2)Effect2.vEffect2Outside.M1114(num3)).update();
			}
			for (int num4 = 0; num4 < Effect2.vAnimateEffect.M1113(); num4++)
			{
				((Effect2)Effect2.vAnimateEffect.M1114(num4)).update();
			}
			for (int num5 = 0; num5 < Effect2.vEffectFeet.M1113(); num5++)
			{
				((Effect2)Effect2.vEffectFeet.M1114(num5)).update();
			}
			for (int num6 = 0; num6 < Effect2.vEffect3.M1113(); num6++)
			{
				((Effect2)Effect2.vEffect3.M1114(num6)).update();
			}
			BackgroundEffect.M62();
			info1.M760();
			info2.M760();
			GameCanvas.M456("E15", 0);
			if (currentCharViewInfo != null && !currentCharViewInfo.Equals(Char.M113()))
			{
				currentCharViewInfo.update();
			}
			runArrow++;
			if (runArrow > 3)
			{
				runArrow = 0;
			}
			if (isInjureHp)
			{
				twHp++;
				if (twHp == 20)
				{
					twHp = 0;
					isInjureHp = false;
				}
			}
			else if (dHP > Char.M113().cHP)
			{
				int num7 = dHP - Char.M113().cHP >> 1;
				if (num7 < 1)
				{
					num7 = 1;
				}
				dHP -= num7;
			}
			else
			{
				dHP = Char.M113().cHP;
			}
			if (isInjureMp)
			{
				twMp++;
				if (twMp == 20)
				{
					twMp = 0;
					isInjureMp = false;
				}
			}
			else if (dMP > Char.M113().cMP)
			{
				int num8 = dMP - Char.M113().cMP >> 1;
				if (num8 < 1)
				{
					num8 = 1;
				}
				dMP -= num8;
			}
			else
			{
				dMP = Char.M113().cMP;
			}
			if (tMenuDelay > 0)
			{
				tMenuDelay--;
			}
			if (M616())
			{
				int num9 = 100;
				while (yR - num9 < cmy)
				{
					cmy--;
				}
			}
			for (int num10 = 0; num10 < Char.vItemTime.M1113(); num10++)
			{
				((ItemTime)Char.vItemTime.M1114(num10)).M846();
			}
			for (int num11 = 0; num11 < textTime.M1113(); num11++)
			{
				((ItemTime)textTime.M1114(num11)).M846();
			}
			M680();
		}
		catch (Exception)
		{
		}
		if (GameCanvas.gameTick % 4000 == 1000)
		{
			M682();
		}
		EffectManager.M405();
	}

	public void M615()
	{
	}

	public bool M616()
	{
		return isMeCallRongThan;
	}

	public void M617(mGraphics g)
	{
		for (int i = 0; i < Effect2.vEffect2.M1113(); i++)
		{
			Effect2 t = (Effect2)Effect2.vEffect2.M1114(i);
			if (!(t is ChatPopup))
			{
				t.paint(g);
			}
		}
		for (int j = 0; j < Effect2.vEffect2Outside.M1113(); j++)
		{
			((Effect2)Effect2.vEffect2Outside.M1114(j)).paint(g);
		}
	}

	public void M618(mGraphics g, int layer)
	{
		for (int i = 0; i < TileMap.vCurrItem.M1113(); i++)
		{
			BgItem t = (BgItem)TileMap.vCurrItem.M1114(i);
			if (t.idImage != -1 && t.layer == layer)
			{
				t.M71(g);
			}
		}
		if (TileMap.mapID == 48 && layer == 3 && !GameCanvas.lowGraphic && GameCanvas.bgW != null && GameCanvas.bgW[0] != 0)
		{
			for (int j = 0; j < TileMap.pxw / GameCanvas.bgW[0] + 1; j++)
			{
				g.M948(GameCanvas.imgBG[0], j * GameCanvas.bgW[0], TileMap.pxh - GameCanvas.bgH[0] - 70, 0);
			}
		}
	}

	public void M619(mGraphics g)
	{
		if (!GameCanvas.lowGraphic)
		{
			g.M963(imgTrans, 0, 0, GameCanvas.w, GameCanvas.h);
		}
	}

	public void M620(mGraphics g)
	{
		MobCapcha.M1011(g, Char.M113().cx, Char.M113().cy);
		g.M918(-g.M920(), -g.M921());
		if (GameCanvas.menu.showMenu || GameCanvas.panel.isShow || ChatPopup.currChatPopup != null || !GameCanvas.isTouch)
		{
			return;
		}
		for (int i = 0; i < strCapcha.Length; i++)
		{
			int x = (GameCanvas.w - strCapcha.Length * disXC) / 2 + i * disXC + disXC / 2;
			if (keyCapcha[i] == -1)
			{
				g.M948(imgNut, x, GameCanvas.h - 25, 3);
				mFont.tahoma_7b_dark.M898(g, strCapcha[i] + string.Empty, x, GameCanvas.h - 30, 2);
			}
			else
			{
				g.M948(imgNutF, x, GameCanvas.h - 25, 3);
				mFont.tahoma_7b_green2.M898(g, strCapcha[i] + string.Empty, x, GameCanvas.h - 30, 2);
			}
		}
	}

	public override void paint(mGraphics g)
	{
		countEff = 0;
		if (!isPaint)
		{
			return;
		}
		GameCanvas.M456("PA1", 1);
		if (isFreez || (isUseFreez && ChatPopup.currChatPopup == null))
		{
			dem++;
			if (((dem < 30 && dem >= 0 && GameCanvas.gameTick % 4 == 0) || (dem >= 30 && dem <= 50 && GameCanvas.gameTick % 3 == 0) || dem > 50) && dem > 50)
			{
				if (isUseFreez)
				{
					isUseFreez = false;
					dem = 0;
				}
				M631(g);
			}
		}
		GameCanvas.M456("PA2", 1);
		GameCanvas.M466(g);
		if ((isRongThanXuatHien || isFireWorks) && TileMap.bgID != 3)
		{
			M619(g);
		}
		GameCanvas.M456("PA3", 1);
		if (shock_scr > 0)
		{
			g.M918(-cmx + shock_x[shock_scr % shock_x.Length], -cmy + shock_y[shock_scr % shock_y.Length]);
			shock_scr--;
		}
		else
		{
			g.M918(-cmx, -cmy);
		}
		if (isSuperPower)
		{
			g.M918((GameCanvas.gameTick % 3 != 0) ? (-3) : 3, 0);
		}
		TileMap.M1951(g);
		for (int i = 0; i < vCharInMap.M1113(); i++)
		{
			Char t = (Char)vCharInMap.M1114(i);
			if (t.isMabuHold && TileMap.mapID == 128)
			{
				t.M198(g, t.cx, t.cy, 0);
			}
		}
		if (Char.M113().isMabuHold && TileMap.mapID == 128)
		{
			Char.M113().M198(g, Char.M113().cx, Char.M113().cy, 0);
		}
		if (Char.M113().cmdMenu != null && GameCanvas.isTouch)
		{
			if (mScreen.keyTouch == 20)
			{
				g.M948(imgChat2, Char.M113().cmdMenu.x + cmx, Char.M113().cmdMenu.y + cmy, mGraphics.HCENTER | mGraphics.VCENTER);
			}
			else
			{
				g.M948(imgChat, Char.M113().cmdMenu.x + cmx, Char.M113().cmdMenu.y + cmy, mGraphics.HCENTER | mGraphics.VCENTER);
			}
		}
		GameCanvas.M456("PA4", 1);
		GameCanvas.M456("PA5", 1);
		for (int j = 0; j < Teleport.vTeleport.M1113(); j++)
		{
			((Teleport)Teleport.vTeleport.M1114(j)).M1895(g);
		}
		for (int k = 0; k < vNpc.M1113(); k++)
		{
			Npc t2 = (Npc)vNpc.M1114(k);
			if (t2.cHP > 0)
			{
				t2.M192(g);
			}
		}
		for (int l = 0; l < vNpc.M1113(); l++)
		{
			((Npc)vNpc.M1114(l)).paint(g);
		}
		g.M918(0, GameCanvas.transY);
		GameCanvas.M456("PA7", 1);
		GameCanvas.M456("PA8", 1);
		for (int m = 0; m < vCharInMap.M1113(); m++)
		{
			Char t3 = null;
			try
			{
				t3 = (Char)vCharInMap.M1114(m);
			}
			catch (Exception ex)
			{
				Cout.M328("Loi ham paint char gamesc: " + ex.ToString());
			}
			if (t3 != null && (!GameCanvas.panel.isShow || !GameCanvas.panel.M1443()) && t3.isShadown)
			{
				t3.M192(g);
			}
		}
		Char.M113().M192(g);
		for (int n = 0; n < vMob.M1113(); n++)
		{
			((Mob)vMob.M1114(n)).paint(g);
		}
		for (int num = 0; num < Teleport.vTeleport.M1113(); num++)
		{
			((Teleport)Teleport.vTeleport.M1114(num)).M1896(g);
		}
		for (int num2 = 0; num2 < vCharInMap.M1113(); num2++)
		{
			Char t4 = null;
			try
			{
				t4 = (Char)vCharInMap.M1114(num2);
			}
			catch (Exception)
			{
			}
			if (t4 != null && (!GameCanvas.panel.isShow || !GameCanvas.panel.M1443()))
			{
				t4.paint(g);
			}
		}
		Char.M113().paint(g);
		if (Char.M113().skillPaint != null && Char.M113().M178() != null && Char.M113().indexSkill < Char.M113().M178().Length)
		{
			Char.M113().M200(g);
			Char.M113().M160(g);
		}
		for (int num3 = 0; num3 < vCharInMap.M1113(); num3++)
		{
			Char t5 = null;
			try
			{
				t5 = (Char)vCharInMap.M1114(num3);
			}
			catch (Exception ex3)
			{
				Cout.M328("Loi ham paint char gamescr: " + ex3.ToString());
			}
			if (t5 != null && (!GameCanvas.panel.isShow || !GameCanvas.panel.M1443()) && t5.skillPaint != null && t5.M178() != null && t5.indexSkill < t5.M178().Length)
			{
				t5.M200(g);
				t5.M160(g);
			}
		}
		for (int num4 = 0; num4 < vItemMap.M1113(); num4++)
		{
			((ItemMap)vItemMap.M1114(num4)).M824(g);
		}
		g.M918(0, -GameCanvas.transY);
		GameCanvas.M456("PA9", 1);
		M648(g);
		GameCanvas.M456("PA10", 1);
		GameCanvas.M456("PA11", 1);
		GameCanvas.M456("PA13", 1);
		M617(g);
		for (int num5 = 0; num5 < vNpc.M1113(); num5++)
		{
			((Npc)vNpc.M1114(num5)).M1198(g);
		}
		EffectMn.M382(g);
		for (int num6 = 0; num6 < vNpc.M1113(); num6++)
		{
			Npc t6 = (Npc)vNpc.M1114(num6);
			if (t6.chatInfo != null)
			{
				t6?.chatInfo.M741(g, t6.cx, t6.cy - t6.ch - GameCanvas.transY, t6.cdir);
			}
		}
		for (int num7 = 0; num7 < vCharInMap.M1113(); num7++)
		{
			Char t7 = null;
			try
			{
				t7 = (Char)vCharInMap.M1114(num7);
			}
			catch (Exception)
			{
			}
			if (t7 != null && t7.chatInfo != null)
			{
				t7.chatInfo.M741(g, t7.cx, t7.cy - t7.ch, t7.cdir);
			}
		}
		if (Char.M113().chatInfo != null)
		{
			Char.M113().chatInfo.M741(g, Char.M113().cx, Char.M113().cy - Char.M113().ch, Char.M113().cdir);
		}
		PopUp.M1485(g);
		mSystem.M1068(g);
		GameCanvas.M456("PA14", 1);
		GameCanvas.M456("PA15", 1);
		GameCanvas.M456("PA16", 1);
		GameCanvas.M456("PA17", 1);
		if (!isPaintOther && isPaintRada == 1 && !GameCanvas.panel.isShow)
		{
			M639(g);
		}
		M631(g);
		if (!isPaintOther)
		{
			GameAutomationHub.M2164(g);
			GameCanvas.M456("PA21", 1);
			GameCanvas.M456("PA18", 1);
			g.M918(-g.M920(), -g.M921());
			if ((TileMap.mapID == 128 || TileMap.mapID == 127) && mabuPercent != 0)
			{
				g.M933(0);
				g.M932(3, 88, 54, 8);
				g.M933(16711680);
				g.M922(5, 90, mabuPercent, 4);
				g.M932(5, 90, 50, 4);
				g.M922(0, 0, 3000, 3000);
				mFont.tahoma_7b_white.M902(g, "Mabu", 30, 98, 2, mFont.tahoma_7b_dark);
			}
			if (Char.M113().isFusion)
			{
				Char.M113().tFusion++;
				if (GameCanvas.gameTick % 3 != 0)
				{
				}
				if (Char.M113().tFusion >= 100)
				{
					Char.M113().M239();
				}
			}
			for (int num8 = 0; num8 < vCharInMap.M1113(); num8++)
			{
				Char t8 = null;
				try
				{
					t8 = (Char)vCharInMap.M1114(num8);
				}
				catch (Exception)
				{
				}
				if (t8 != null && t8.isFusion && Char.M208(t8))
				{
					t8.tFusion++;
					if (GameCanvas.gameTick % 3 != 0)
					{
					}
					if (t8.tFusion >= 100)
					{
						t8.M239();
					}
				}
			}
			GameCanvas.paintz.M1209(g);
			GameCanvas.M456("PA19", 1);
			GameCanvas.M456("PA20", 1);
			M631(g);
			M641(g);
			GameCanvas.M456("PA22", 1);
			M631(g);
			if (GameCanvas.isTouch && GameCanvas.isTouchControl)
			{
				M632(g);
			}
			M631(g);
			M679(g);
			if (!GameCanvas.panel.isShow && GameCanvas.currentDialog == null && ChatPopup.currChatPopup == null && ChatPopup.serverChatPopUp == null && GameCanvas.currentScreen.Equals(instance))
			{
				base.paint(g);
				if (mScreen.keyMouse == 1 && cmdMenu != null)
				{
					g.M948(ItemMap.imageFlare, cmdMenu.x + 7, cmdMenu.y + 15, 3);
				}
			}
			M631(g);
			int num9 = 100 + ((Char.vItemTime.M1113() != 0) ? (textTime.M1113() * 12) : 0);
			if (Char.M113().clan != null)
			{
				int num10 = 0;
				int num11 = 0;
				int num12 = (GameCanvas.h - 100 - 60) / 12;
				for (int num13 = 0; num13 < vCharInMap.M1113(); num13++)
				{
					Char t9 = (Char)vCharInMap.M1114(num13);
					if (t9.clanID == -1 || t9.clanID != Char.M113().clan.ID)
					{
						continue;
					}
					if (t9.M180() && t9.cx < Char.M113().cx)
					{
						int num14 = num12;
						if (Char.vItemTime.M1113() != 0)
						{
							num14 -= textTime.M1113();
						}
						if (num10 <= num14)
						{
							mFont.tahoma_7_green.M902(g, t9.cName, 20, num9 - 12 + num10 * 12, mFont.LEFT, mFont.tahoma_7_grey);
							t9.M188(g, 10, num9 + num10 * 12 - 5);
							num10++;
						}
					}
					else if (t9.M180() && t9.cx > Char.M113().cx && num11 <= num12)
					{
						mFont.tahoma_7_green.M902(g, t9.cName, GameCanvas.w - 25, num9 - 12 + num11 * 12, mFont.RIGHT, mFont.tahoma_7_grey);
						t9.M188(g, GameCanvas.w - 15, num9 + num11 * 12 - 5);
						num11++;
					}
				}
			}
			ChatTextField.M279().M286(g);
			if (isNewClanMessage && !GameCanvas.panel.isShow && GameCanvas.gameTick % 4 == 0)
			{
				g.M948(ItemMap.imageFlare, cmdMenu.x + 15, cmdMenu.y + 30, mGraphics.BOTTOM | mGraphics.HCENTER);
			}
			if (isSuperPower)
			{
				dxPower += 5;
				if (tPower >= 0)
				{
					tPower += dxPower;
				}
				Res.M1513("x power= " + xPower);
				if (tPower < 0)
				{
					tPower--;
					if (tPower == -20)
					{
						isSuperPower = false;
						tPower = 0;
						dxPower = 0;
					}
				}
				else if ((xPower - tPower > 0 || tPower < TileMap.pxw) && tPower > 0)
				{
					g.M933(16777215);
					if (!GameCanvas.lowGraphic)
					{
						g.M968(0, 0, GameCanvas.w, GameCanvas.h, 0, 0);
					}
					else
					{
						g.M932(0, 0, GameCanvas.w, GameCanvas.h);
					}
				}
				else
				{
					tPower = -1;
				}
			}
			for (int num15 = 0; num15 < Char.vItemTime.M1113(); num15++)
			{
				((ItemTime)Char.vItemTime.M1114(num15)).M844(g, cmdMenu.x + 32 + num15 * 24, 55);
			}
			for (int num16 = 0; num16 < textTime.M1113(); num16++)
			{
				if (!((ItemTime)textTime.M1114(num16)).text.ToLower().Contains("bà hạt mít"))
				{
					((ItemTime)textTime.M1114(num16)).M845(g, cmdMenu.x + ((Char.vItemTime.M1113() == 0) ? 25 : 5), ((Char.vItemTime.M1113() == 0) ? 45 : 90) + num16 * 12);
				}
			}
		}
		int num17 = 0;
		int num18 = GameCanvas.hw;
		if (num18 > 200)
		{
			num18 = 200;
		}
		M685(g, num17 + GameCanvas.w / 2, 0, num18);
		EffectManager.hiEffects.M406(g);
	}

	private void M621(mGraphics g)
	{
		if (tShow != 0)
		{
			string text = string.Empty;
			for (int i = 0; i < winnumber.Length; i++)
			{
				text = text + randomNumber[i] + " ";
			}
			PopUp.M1481(g, 20, 45, 95, 35, 16777215, isButton: false);
			mFont.tahoma_7b_dark.M898(g, mResources.kquaVongQuay, 68, 50, 2);
			mFont.tahoma_7b_dark.M898(g, text + string.Empty, 68, 65, 2);
		}
	}

	private void M622(IMapObject obj)
	{
		if (obj == null || tDoubleDelay > 0)
		{
			return;
		}
		tDoubleDelay = 10;
		int x = obj.getX();
		int num = Res.M1529(Char.M113().cx - x);
		int loopCount = ((num <= 80) ? 1 : ((num > 80 && num <= 200) ? 2 : ((num <= 200 || num > 400) ? 4 : 3)));
		Res.M1513("nLoop= " + loopCount);
		if (!obj.Equals(Char.M113().mobFocus) && (!obj.Equals(Char.M113().charFocus) || !Char.M113().M225(Char.M113().charFocus)))
		{
			if (obj.Equals(Char.M113().npcFocus) || obj.Equals(Char.M113().itemFocus) || obj.Equals(Char.M113().charFocus))
			{
				ServerEffect.M1571(136, obj.getX(), obj.getY(), loopCount);
			}
		}
		else
		{
			ServerEffect.M1571(135, obj.getX(), obj.getY(), loopCount);
		}
	}

	private void M623()
	{
		if (tDoubleDelay > 0)
		{
			tDoubleDelay--;
		}
		if (clickMoving)
		{
			clickMoving = false;
			IMapObject t = M578(clickToX, clickToY);
			if (t == null || (t != null && t.Equals(Char.M113().npcFocus) && TileMap.mapID == 51))
			{
				ServerEffect.M1571(134, clickToX, clickToY + GameCanvas.transY / 2, 3);
			}
		}
	}

	private void M624(mGraphics g)
	{
		int num = 10;
		Task taskMaint = Char.M113().taskMaint;
		if (taskMaint != null && taskMaint.taskId == 0 && ((taskMaint.index != 1 && taskMaint.index < 6) || taskMaint.index == 0))
		{
			return;
		}
		for (int i = 0; i < TileMap.vGo.M1113(); i++)
		{
			Waypoint t = (Waypoint)TileMap.vGo.M1114(i);
			if (t.minY != 0 && t.maxY < TileMap.pxh - 24)
			{
				if (t.minX >= 0 && t.minX < 24)
				{
					if (!GameCanvas.isTouch)
					{
						g.M940(arrow, 0, 0, 13, 16, 2, t.maxX + 12 + runArrow, t.maxY - 12, StaticObj.VCENTER_HCENTER);
					}
					else
					{
						g.M940(arrow, 0, 0, 13, 16, 2, t.maxX + 12 + runArrow, t.maxY - 32, StaticObj.VCENTER_HCENTER);
					}
				}
				else if (t.minX <= TileMap.tmw * 24 && t.minX >= TileMap.tmw * 24 - 48)
				{
					if (!GameCanvas.isTouch)
					{
						g.M940(arrow, 0, 0, 13, 16, 0, t.minX - 12 - runArrow, t.maxY - 12, StaticObj.VCENTER_HCENTER);
					}
					else
					{
						g.M940(arrow, 0, 0, 13, 16, 0, t.minX - 12 - runArrow, t.maxY - 32, StaticObj.VCENTER_HCENTER);
					}
				}
				else
				{
					g.M940(arrow, 0, 0, 13, 16, 4, t.minX + (t.maxX - t.minX) / 2, t.maxY - 48 - runArrow, StaticObj.VCENTER_HCENTER);
				}
			}
			else if (t.maxY <= TileMap.pxh / 2)
			{
				int x = t.minX + (t.maxX - t.minX) / 2;
				int y = t.minY + (t.maxY - t.minY) / 2 + runArrow;
				if (GameCanvas.isTouch)
				{
					y = t.maxY + (t.maxY - t.minY) + runArrow + num;
				}
				g.M940(arrow, 0, 0, 13, 16, 6, x, y, StaticObj.VCENTER_HCENTER);
			}
			else if (t.minY >= TileMap.pxh / 2)
			{
				g.M940(arrow, 0, 0, 13, 16, 4, t.minX + (t.maxX - t.minX) / 2, t.minY - 12 - runArrow, StaticObj.VCENTER_HCENTER);
			}
		}
	}

	public static Npc M625(short id)
	{
		int num = 0;
		Npc t;
		while (true)
		{
			if (num < vNpc.M1113())
			{
				t = (Npc)vNpc.M1114(num);
				if (t.template.npcTemplateId == id)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return t;
	}

	public static Char M626(int charId)
	{
		int num = 0;
		Char t;
		while (true)
		{
			if (num < vCharInMap.M1113())
			{
				t = (Char)vCharInMap.M1114(num);
				if (t.charID == charId)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return t;
	}

	public static Mob M627(sbyte mobIndex)
	{
		return (Mob)vMob.M1114(mobIndex);
	}

	public static Mob M628(int mobId)
	{
		int num = 0;
		Mob t;
		while (true)
		{
			if (num < vMob.M1113())
			{
				t = (Mob)vMob.M1114(num);
				if (t.mobId == mobId)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return t;
	}

	public static Npc M629()
	{
		int num = 0;
		Npc t;
		while (true)
		{
			if (num < vNpc.M1113())
			{
				t = (Npc)vNpc.M1114(num);
				if (t.template.npcTemplateId == M660())
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return t;
	}

	private void M630(mGraphics g)
	{
		try
		{
			if (ChatPopup.currChatPopup != null)
			{
				return;
			}
			int num = M660();
			if (num == -1)
			{
				return;
			}
			Npc t = null;
			for (int i = 0; i < vNpc.M1113(); i++)
			{
				Npc t2 = (Npc)vNpc.M1114(i);
				if (t2.template.npcTemplateId == num)
				{
					if (t == null)
					{
						t = t2;
					}
					else if (Res.M1529(t2.cx - Char.M113().cx) < Res.M1529(t.cx - Char.M113().cx))
					{
						t = t2;
					}
				}
			}
			if (t == null || t.statusMe == 15 || (t.cx > cmx && t.cx < cmx + gW && t.cy > cmy && t.cy < cmy + gH) || GameCanvas.gameTick % 10 < 5)
			{
				return;
			}
			int num2 = t.cx - Char.M113().cx;
			int num3 = t.cy - Char.M113().cy;
			int x = 0;
			int y = 0;
			int arg = 0;
			if (num2 > 0 && num3 >= 0)
			{
				if (Res.M1529(num2) >= Res.M1529(num3))
				{
					x = gW - 10;
					y = gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						y = gH / 2 + 10;
					}
					arg = 0;
				}
				else
				{
					x = gW / 2;
					y = gH - 10;
					arg = 5;
				}
			}
			else if (num2 >= 0 && num3 < 0)
			{
				if (Res.M1529(num2) >= Res.M1529(num3))
				{
					x = gW - 10;
					y = gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						y = gH / 2 + 10;
					}
					arg = 0;
				}
				else
				{
					x = gW / 2;
					y = 10;
					arg = 6;
				}
			}
			if (num2 < 0 && num3 >= 0)
			{
				if (Res.M1529(num2) >= Res.M1529(num3))
				{
					x = 10;
					y = gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						y = gH / 2 + 10;
					}
					arg = 3;
				}
				else
				{
					x = gW / 2;
					y = gH - 10;
					arg = 5;
				}
			}
			else if (num2 <= 0 && num3 < 0)
			{
				if (Res.M1529(num2) >= Res.M1529(num3))
				{
					x = 10;
					y = gH / 2 + 30;
					if (GameCanvas.isTouch)
					{
						y = gH / 2 + 10;
					}
					arg = 3;
				}
				else
				{
					x = gW / 2;
					y = 10;
					arg = 6;
				}
			}
			M631(g);
			g.M940(arrow, 0, 0, 13, 16, arg, x, y, StaticObj.VCENTER_HCENTER);
		}
		catch (Exception ex)
		{
			Cout.M328("Loi ham arrow to npc: " + ex.ToString());
		}
	}

	public static void M631(mGraphics g)
	{
		g.M918(-g.M920(), -g.M921());
		g.M922(0, -200, GameCanvas.w, 200 + GameCanvas.h);
	}

	private void M632(mGraphics g)
	{
		if (M653())
		{
			return;
		}
		M631(g);
		if (!TileMap.M1936() && !M640())
		{
			if (mScreen.keyTouch != 15 && mScreen.keyMouse != 15)
			{
				g.M948((!Main.isPC) ? imgChat : imgChatPC, xC + 17, yC + 17 + mGraphics.addYWhenOpenKeyBoard, mGraphics.HCENTER | mGraphics.VCENTER);
			}
			else
			{
				g.M948((!Main.isPC) ? imgChat2 : imgChatsPC2, xC + 17, yC + 17 + mGraphics.addYWhenOpenKeyBoard, mGraphics.HCENTER | mGraphics.VCENTER);
			}
		}
	}

	public void M633(mGraphics g, Char c)
	{
		int num = c.cHP * hpBarW / c.cHPFull;
		int num2 = c.cMP * mpBarW;
		int num3 = dHP * hpBarW / c.cHPFull;
		int num4 = dMP * mpBarW;
		g.M922(GameCanvas.w / 2 + 58 - mGraphics.M958(imgPanel), 0, 95, 100);
		g.M940(imgPanel, 0, 0, mGraphics.M958(imgPanel), mGraphics.M959(imgPanel), 2, GameCanvas.w / 2 + 60, 0, mGraphics.RIGHT | mGraphics.TOP);
		g.M922(GameCanvas.w / 2 + 60 - 83 - hpBarW + hpBarW - num3, 5, num3, 10);
		g.M948(imgHPLost, GameCanvas.w / 2 + 60 - 83, 5, mGraphics.RIGHT | mGraphics.TOP);
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
		g.M922(GameCanvas.w / 2 + 60 - 83 - hpBarW + hpBarW - num, 5, num, 10);
		g.M948(imgHP, GameCanvas.w / 2 + 60 - 83, 5, mGraphics.RIGHT | mGraphics.TOP);
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
		g.M922(GameCanvas.w / 2 + 60 - 83 - mpBarW + hpBarW - num4, 20, num4, 6);
		g.M948(imgMPLost, GameCanvas.w / 2 + 60 - 83, 20, mGraphics.RIGHT | mGraphics.TOP);
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
		g.M922(GameCanvas.w / 2 + 60 - 83 - mpBarW + hpBarW - num2, 20, num2, 6);
		g.M948(imgMP, GameCanvas.w / 2 + 60 - 83, 20, mGraphics.RIGHT | mGraphics.TOP);
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
	}

	private void M634(mGraphics g, bool isLeft, Char c)
	{
		if (c != null)
		{
			int num;
			int num2;
			int num3;
			int num4;
			if (c.charID == Char.M113().charID)
			{
				num = dHP * hpBarW / c.cHPFull;
				num2 = dMP * mpBarW / c.cMPFull;
				num3 = c.cHP * hpBarW / c.cHPFull;
				num4 = c.cMP * mpBarW / c.cMPFull;
			}
			else
			{
				num = c.dHP * hpBarW / c.cHPFull;
				num2 = c.perCentMp * mpBarW / 100;
				num3 = c.cHP * hpBarW / c.cHPFull;
				num4 = c.perCentMp * mpBarW / 100;
			}
			if (Char.M113().secondPower > 0)
			{
				int w = Char.M113().powerPoint * spBarW / Char.M113().maxPowerPoint;
				g.M948(imgPanel2, 58, 29, 0);
				g.M922(83, 31, w, 10);
				g.M948(imgSP, 83, 31, 0);
				g.M922(0, 0, GameCanvas.w, GameCanvas.h);
				mFont.tahoma_7_white.M898(g, Char.M113().strInfo + ":" + Char.M113().powerPoint + "/" + Char.M113().maxPowerPoint, 115, 29, 2);
			}
			if (c.charID != Char.M113().charID)
			{
				g.M922(mGraphics.M958(imgPanel) - 95, 0, 95, 100);
			}
			g.M948(imgPanel, 0, 0, 0);
			if (isLeft)
			{
				g.M922(83, 5, num, 10);
			}
			else
			{
				g.M922(83 + hpBarW - num, 5, num, 10);
			}
			g.M948(imgHPLost, 83, 5, 0);
			g.M922(0, 0, GameCanvas.w, GameCanvas.h);
			if (isLeft)
			{
				g.M922(83, 5, num3, 10);
			}
			else
			{
				g.M922(83 + hpBarW - num3, 5, num3, 10);
			}
			g.M948(imgHP, 83, 5, 0);
			g.M922(0, 0, GameCanvas.w, GameCanvas.h);
			if (isLeft)
			{
				g.M922(83, 20, num2, 6);
			}
			else
			{
				g.M922(83 + mpBarW - num2, 20, num2, 6);
			}
			g.M948(imgMPLost, 83, 20, 0);
			g.M922(0, 0, GameCanvas.w, GameCanvas.h);
			if (isLeft)
			{
				g.M922(83, 20, num2, 6);
			}
			else
			{
				g.M922(83 + mpBarW - num4, 20, num4, 6);
			}
			g.M948(imgMP, 83, 20, 0);
			g.M922(0, 0, GameCanvas.w, GameCanvas.h);
			if (Char.M113().cMP == 0 && GameCanvas.gameTick % 10 > 5)
			{
				g.M922(83, 20, 2, 6);
				g.M948(imgMPLost, 83, 20, 0);
				g.M922(0, 0, GameCanvas.w, GameCanvas.h);
			}
			if (mGraphics.zoomLevel > 1)
			{
				GUIStyle gUIStyle = new GUIStyle(GUI.skin.label);
				gUIStyle.normal.textColor = Color.yellow;
				gUIStyle.fontSize = 17;
				g.M936(NinjaUtil.M1192(c.cHP), 85, 4, gUIStyle);
				gUIStyle.fontSize = 10;
				g.M936(NinjaUtil.M1192(c.cMP), 85, 19, gUIStyle);
			}
		}
	}

	public void M635()
	{
	}

	public void M636()
	{
		curr = (last = mSystem.M1054());
		secondVS = 180;
	}

	private Char M637()
	{
		int num = 0;
		Char t;
		while (true)
		{
			if (num < vCharInMap.M1113())
			{
				t = (Char)vCharInMap.M1114(num);
				if (t.cTypePk != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return t;
	}

	private Char M638()
	{
		int num = 0;
		Char t;
		while (true)
		{
			if (num < vCharInMap.M1113())
			{
				t = (Char)vCharInMap.M1114(num);
				if (t.cTypePk != 0 && t != M637())
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return t;
	}

	private void M639(mGraphics g)
	{
		M631(g);
		if (M640() && Char.M113().charFocus != null)
		{
			g.M918(GameCanvas.w / 2 - 62, 0);
			M634(g, isLeft: true, Char.M113().charFocus);
			g.M918(-(GameCanvas.w / 2 - 65), 0);
			M633(g, Char.M113());
			Char.M113().M198(g, 15, 20, 0);
			Char.M113().charFocus.M198(g, GameCanvas.w - 15, 20, 2);
		}
		else if (TileMap.mapID == 130 && M637() != null && M638() != null)
		{
			g.M918(GameCanvas.w / 2 - 62, 0);
			M634(g, isLeft: true, M637());
			g.M918(-(GameCanvas.w / 2 - 65), 0);
			M633(g, M638());
			M637().M198(g, 15, 20, 0);
			M638().M198(g, GameCanvas.w - 15, 20, 2);
		}
		else if (M684() && M691())
		{
			M687(g, 1, 1, Char.M113());
		}
		else
		{
			M634(g, isLeft: true, Char.M113());
			if (Char.M113().M120() == null && Char.M113().M121() == null)
			{
				if (Char.M113().mobFocus != null)
				{
					if (Char.M113().mobFocus.M998() != null)
					{
						mFont.tahoma_7b_green2.M898(g, Char.M113().mobFocus.M998().name, imgScrW / 2, 9 + mGraphics.addYWhenOpenKeyBoard, mFont.CENTER);
					}
					if (Char.M113().mobFocus.templateId != 0)
					{
						mFont.tahoma_7b_green2.M898(g, NinjaUtil.M1192(Char.M113().mobFocus.hp) + string.Empty, imgScrW / 2, 22 + mGraphics.addYWhenOpenKeyBoard, mFont.CENTER);
					}
				}
				else if (Char.M113().npcFocus != null)
				{
					mFont.tahoma_7b_green2.M898(g, Char.M113().npcFocus.template.name, imgScrW / 2, 9 + mGraphics.addYWhenOpenKeyBoard, mFont.CENTER);
					if (Char.M113().npcFocus.template.npcTemplateId == 4)
					{
						mFont.tahoma_7b_green2.M898(g, M559().magicTree.currPeas + "/" + M559().magicTree.maxPeas, imgScrW / 2, 22 + mGraphics.addYWhenOpenKeyBoard, mFont.CENTER);
					}
				}
				else if (Char.M113().charFocus != null)
				{
					mFont.tahoma_7b_green2.M898(g, Char.M113().charFocus.cName, imgScrW / 2, 9 + mGraphics.addYWhenOpenKeyBoard, mFont.CENTER);
					mFont.tahoma_7b_green2.M898(g, NinjaUtil.M1192(Char.M113().charFocus.cHP) + string.Empty, imgScrW / 2, 22 + mGraphics.addYWhenOpenKeyBoard, mFont.CENTER);
				}
				else
				{
					mFont.tahoma_7b_green2.M898(g, Char.M113().cName, imgScrW / 2, 9 + mGraphics.addYWhenOpenKeyBoard, mFont.CENTER);
					mFont.tahoma_7b_green2.M898(g, NinjaUtil.M1192(Char.M113().cPower) + string.Empty, imgScrW / 2, 22 + mGraphics.addYWhenOpenKeyBoard, mFont.CENTER);
				}
			}
			else
			{
				mFont.tahoma_7_green2.M898(g, mResources.enter, imgScrW / 2, 8 + mGraphics.addYWhenOpenKeyBoard, mFont.CENTER);
			}
		}
		g.M918(-g.M920(), -g.M921());
		if (M640() && secondVS > 0)
		{
			curr = mSystem.M1054();
			if (curr - last >= 1000L)
			{
				last = mSystem.M1054();
				secondVS--;
			}
			mFont.tahoma_7b_white.M902(g, secondVS + string.Empty, GameCanvas.w / 2, 13, 2, mFont.tahoma_7b_dark);
		}
		if (flareFindFocus)
		{
			g.M948(ItemMap.imageFlare, 40, 35, mGraphics.BOTTOM | mGraphics.HCENTER);
			flareTime--;
			if (flareTime < 0)
			{
				flareTime = 0;
				flareFindFocus = false;
			}
		}
	}

	public bool M640()
	{
		if (TileMap.mapID == 130 || TileMap.mapID == 51 || TileMap.mapID == 112 || TileMap.mapID == 113 || TileMap.mapID == 129)
		{
			if (Char.M113().cTypePk == 0)
			{
				if (TileMap.mapID == 130 && M637() != null)
				{
					return M638() != null;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	private void M641(mGraphics g)
	{
		if (mobCapcha != null)
		{
			M620(g);
		}
		else
		{
			if (GameCanvas.currentDialog != null || ChatPopup.currChatPopup != null || GameCanvas.menu.showMenu || M652() || GameCanvas.panel.isShow || Char.M113().taskMaint.taskId == 0 || ChatTextField.M279().isShow || GameCanvas.currentScreen == MoneyCharge.instance)
			{
				return;
			}
			long num = mSystem.M1054() - lastUsePotion;
			int num2 = 0;
			if (num < 10000L)
			{
				num2 = (int)(num * 20L / 10000L);
			}
			if (!GameCanvas.isTouch)
			{
				g.M948((mScreen.keyTouch != 10) ? imgSkill : imgSkill2, xSkill + xHP - 1, yHP - 1, 0);
				SmallImage.M1785(g, 542, xSkill + xHP + 3, yHP + 3, 0, 0);
				mFont.number_gray.M898(g, string.Empty + hpPotion, xSkill + xHP + 22, yHP + 15, 1);
				if (num < 10000L)
				{
					g.M933(2721889);
					num2 = (int)(num * 20L / 10000L);
					g.M932(xSkill + xHP + 3, yHP + 3 + num2, 20, 20 - num2);
				}
			}
			else if (Char.M113().statusMe != 14)
			{
				if (gamePad.isSmallGamePad)
				{
					if (isAnalog != 1)
					{
						g.M933(9670800);
						g.M932(xHP + 9, yHP + 10, 22, 20);
						g.M933(16777215);
						g.M932(xHP + 9, yHP + 10 + ((num2 != 0) ? (20 - num2) : 0), 22, (num2 == 0) ? 20 : num2);
						g.M948((mScreen.keyTouch != 10) ? imgHP1 : imgHP2, xHP, yHP, 0);
						mFont.tahoma_7_red.M898(g, string.Empty + hpPotion, xHP + 20, yHP + 15, 2);
					}
					else if (isAnalog == 1)
					{
						g.M948((mScreen.keyTouch != 10) ? imgSkill : imgSkill2, xSkill + xHP - 1, yHP - 1, 0);
						SmallImage.M1785(g, 542, xSkill + xHP + 3, yHP + 3, 0, 0);
						mFont.number_gray.M898(g, string.Empty + hpPotion, xSkill + xHP + 22, yHP + 13, 1);
						if (num < 10000L)
						{
							g.M933(2721889);
							num2 = (int)(num * 20L / 10000L);
							g.M932(xSkill + xHP + 3, yHP + 3 + num2, 20, 20 - num2);
						}
					}
				}
				else if (!gamePad.isSmallGamePad)
				{
					if (isAnalog != 1)
					{
						g.M933(9670800);
						g.M932(xHP + 9, yHP + 10, 22, 20);
						g.M933(16777215);
						g.M932(xHP + 9, yHP + 10 + ((num2 != 0) ? (20 - num2) : 0), 22, (num2 == 0) ? 20 : num2);
						g.M948((mScreen.keyTouch != 10) ? imgHP1 : imgHP2, xHP, yHP, 0);
						mFont.tahoma_7_red.M898(g, string.Empty + hpPotion, xHP + 20, yHP + 15, 2);
					}
					else
					{
						g.M933(9670800);
						g.M932(xHP + 10, yHP + 10, 20, 18);
						g.M933(16777215);
						g.M932(xHP + 10, yHP + 10 + ((num2 != 0) ? (20 - num2) : 0), 20, (num2 == 0) ? 18 : num2);
						g.M948((mScreen.keyTouch != 10) ? imgHP3 : imgHP4, xHP + 20, yHP + 20, mGraphics.HCENTER | mGraphics.VCENTER);
						mFont.tahoma_7_red.M898(g, string.Empty + hpPotion, xHP + 20, yHP + 15, 2);
					}
				}
			}
			if (isHaveSelectSkill)
			{
				Skill[] array = (Main.isPC ? keySkill : onScreenSkill);
				if (!GameCanvas.isTouch)
				{
					g.M933(11152401);
					g.M932(xSkill + xHP + 2, yHP - 10, 20, 10);
					mFont.tahoma_7_white.M898(g, "*", xSkill + xHP + 12, yHP - 8, mFont.CENTER);
				}
				int num3 = ((!Main.isPC) ? nSkill : array.Length);
				for (int i = 0; i < num3; i++)
				{
					Skill t = array[i];
					if (t != Char.M113().myskill)
					{
						g.M948(imgSkill, xSkill + xS[i] - 1, yS[i] - 1, 0);
					}
					if (t == null)
					{
						continue;
					}
					if (t == Char.M113().myskill)
					{
						g.M948(imgSkill2, xSkill + xS[i] - 1, yS[i] - 1, 0);
						if (GameCanvas.isTouch && !Main.isPC)
						{
							g.M940(Mob.imgHP, 0, 12, 9, 6, 0, xSkill + xS[i] + 8, yS[i] - 7, 0);
						}
					}
					t.M1770(xSkill + xS[i] + 13, yS[i] + 13, g);
					if ((i == selectedIndexSkill && !M654() && GameCanvas.gameTick % 10 > 5) || i == keyTouchSkill)
					{
						g.M948(ItemMap.imageFlare, xSkill + xS[i] + 13, yS[i] + 14, 3);
					}
					long num4 = t.coolDown - mSystem.M1054() + t.lastTimeUseThisSkill;
					mFont.tahoma_7b_dark.M902(g, (num4 > 0L) ? string.Concat(num4 / 1000L) : string.Empty, xSkill + xS[i] + 14, yS[i] + 8, mFont.CENTER, mFont.tahoma_7_red);
				}
			}
			M675(g);
		}
	}

	public void M642(mGraphics g)
	{
		if (isstarOpen)
		{
			g.M918(-g.M920(), -g.M921());
			g.M932(0, 0, GameCanvas.w, moveUp);
			g.M933(10275899);
			g.M932(0, moveUp - 1, GameCanvas.w, 1);
			g.M932(0, moveDow + 1, GameCanvas.w, 1);
		}
	}

	public static void M643(string flyString, int x, int y, int dx, int dy, int color)
	{
		int num = -1;
		for (int i = 0; i < 5; i++)
		{
			if (flyTextState[i] == -1)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return;
		}
		flyTextColor[num] = color;
		flyTextString[num] = flyString;
		flyTextX[num] = x;
		flyTextY[num] = y;
		flyTextDx[num] = dx;
		flyTextDy[num] = ((dy >= 0) ? 5 : (-5));
		flyTextState[num] = 0;
		flyTime[num] = 0;
		flyTextYTo[num] = 10;
		for (int j = 0; j < 5; j++)
		{
			if (flyTextState[j] != -1 && num != j && flyTextDy[num] < 0 && Res.M1529(flyTextX[num] - flyTextX[j]) <= 20 && flyTextYTo[num] == flyTextYTo[j])
			{
				flyTextYTo[num] += 10;
			}
		}
	}

	public static void M644()
	{
		for (int i = 0; i < 5; i++)
		{
			if (flyTextState[i] == -1)
			{
				continue;
			}
			if (flyTextState[i] > flyTextYTo[i])
			{
				flyTime[i]++;
				if (flyTime[i] == 25)
				{
					flyTime[i] = 0;
					flyTextState[i] = -1;
					flyTextYTo[i] = 0;
					flyTextDx[i] = 0;
					flyTextX[i] = 0;
				}
			}
			else
			{
				flyTextState[i] += Res.M1529(flyTextDy[i]);
				flyTextX[i] += flyTextDx[i];
				flyTextY[i] += flyTextDy[i];
			}
		}
	}

	public static void M645()
	{
		if (imgSplash == null)
		{
			imgSplash = new Image[3];
			for (int i = 0; i < 3; i++)
			{
				imgSplash[i] = GameCanvas.M503("/e/sp" + i + ".png");
			}
		}
		splashX = new int[2];
		splashY = new int[2];
		splashState = new int[2];
		splashF = new int[2];
		splashDir = new int[2];
		int[] array = splashState;
		splashState[1] = -1;
		array[0] = -1;
	}

	public static bool M646(int x, int y, int dir)
	{
		int num = ((splashState[0] != -1) ? 1 : 0);
		if (splashState[num] != -1)
		{
			return false;
		}
		splashState[num] = 0;
		splashDir[num] = dir;
		splashX[num] = x;
		splashY[num] = y;
		return true;
	}

	public static void M647()
	{
		for (int i = 0; i < 2; i++)
		{
			if (splashState[i] != -1)
			{
				splashState[i]++;
				splashX[i] += splashDir[i] << 2;
				splashY[i]--;
				if (splashState[i] >= 6)
				{
					splashState[i] = -1;
				}
				else
				{
					splashF[i] = (splashState[i] >> 1) % 3;
				}
			}
		}
	}

	public static void M648(mGraphics g)
	{
		for (int i = 0; i < 2; i++)
		{
			if (splashState[i] != -1)
			{
				if (splashDir[i] == 1)
				{
					g.M948(imgSplash[splashF[i]], splashX[i], splashY[i], 3);
				}
				else
				{
					g.M940(imgSplash[splashF[i]], 0, 0, mGraphics.M958(imgSplash[splashF[i]]), mGraphics.M959(imgSplash[splashF[i]]), 2, splashX[i], splashY[i], 3);
				}
			}
		}
	}

	private void M649()
	{
		imgScrW = 84;
		hpBarW = 66;
		mpBarW = 59;
		hpBarX = 52;
		hpBarY = 10;
		spBarW = 61;
		expBarW = gW - 61;
	}

	public void M650()
	{
		if (indexMenu != -1)
		{
			if (cmySK != cmtoYSK)
			{
				cmvySK = cmtoYSK - cmySK << 2;
				cmdySK += cmvySK;
				cmySK += cmdySK >> 4;
				cmdySK &= 15;
			}
			if (Math.M869(cmtoYSK - cmySK) < 15 && cmySK < 0)
			{
				cmtoYSK = 0;
			}
			if (Math.M869(cmtoYSK - cmySK) < 15 && cmySK > cmyLimSK)
			{
				cmtoYSK = cmyLimSK;
			}
		}
	}

	public void M651()
	{
		if (!isPaintAlert || GameCanvas.currentDialog != null)
		{
			return;
		}
		bool flag = false;
		if (GameCanvas.keyPressed[Key.NUM8])
		{
			indexRow++;
			if (indexRow >= texts.M1113())
			{
				indexRow = 0;
			}
			flag = true;
		}
		else if (GameCanvas.keyPressed[Key.NUM2])
		{
			indexRow--;
			if (indexRow < 0)
			{
				indexRow = texts.M1113() - 1;
			}
			flag = true;
		}
		if (flag)
		{
			scrMain.M1567(indexRow * scrMain.ITEM_SIZE);
			GameCanvas.M484();
			GameCanvas.M483();
		}
		if (GameCanvas.isTouch)
		{
			ScrollResult t = scrMain.M1561();
			if (t.isDowning || t.isFinish)
			{
				indexRow = t.selected;
				flag = true;
			}
		}
		if (!flag || indexRow < 0 || indexRow >= texts.M1113())
		{
			return;
		}
		string text = (string)texts.M1114(indexRow);
		fnick = null;
		alertURL = null;
		center = null;
		ChatTextField.M279().center = null;
		int startIndex;
		if ((startIndex = text.IndexOf("http://")) >= 0)
		{
			Cout.M326("currentLine: " + text);
			alertURL = text.Substring(startIndex);
			center = new Command(mResources.open_link, 12000);
			if (!GameCanvas.isTouch)
			{
				ChatTextField.M279().center = new Command(mResources.open_link, null, 12000, null);
			}
		}
		else
		{
			if (text.IndexOf("@") < 0)
			{
				return;
			}
			string text2 = text.Substring(2).Trim();
			startIndex = text2.IndexOf("@");
			string text3 = text2.Substring(startIndex);
			int num = text3.IndexOf(" ");
			fnick = text2.Substring(startIndex + 1, (num > 0) ? (num + startIndex) : (startIndex + text3.Length));
			if (!fnick.Equals(string.Empty) && !fnick.Equals(Char.M113().cName))
			{
				center = new Command(mResources.SELECT, 12009, fnick);
				if (!GameCanvas.isTouch)
				{
					ChatTextField.M279().center = new Command(mResources.SELECT, null, 12009, fnick);
				}
			}
			else
			{
				fnick = null;
				center = null;
			}
		}
	}

	public bool M652()
	{
		if (!isPaintItemInfo && !isPaintInfoMe && !isPaintStore && !isPaintWeapon && !isPaintNonNam && !isPaintNonNu && !isPaintAoNam && !isPaintAoNu && !isPaintGangTayNam && !isPaintGangTayNu && !isPaintQuanNam && !isPaintQuanNu && !isPaintGiayNam && !isPaintGiayNu && !isPaintLien && !isPaintNhan && !isPaintNgocBoi && !isPaintPhu && !isPaintStack && !isPaintStackLock && !isPaintGrocery && !isPaintGroceryLock && !isPaintUpGrade && !isPaintConvert && !isPaintSplit && !isPaintUpPearl && !isPaintBox && !isPaintTrade && !isPaintAlert && !isPaintZone && !isPaintTeam && !isPaintClan && !isPaintFindTeam && !isPaintTask && !isPaintFriend && !isPaintEnemies && !isPaintCharInMap)
		{
			return isPaintMessage;
		}
		return true;
	}

	public bool M653()
	{
		if ((GameCanvas.isTouchControl || GameCanvas.currentScreen != M559()) && GameCanvas.isTouch && !ChatTextField.M279().isShow && !InfoDlg.isShow && GameCanvas.currentDialog == null && ChatPopup.currChatPopup == null && !GameCanvas.menu.showMenu && !GameCanvas.panel.isShow)
		{
			return M652();
		}
		return true;
	}

	public bool M654()
	{
		if (!isPaintStore && !isPaintWeapon && !isPaintNonNam && !isPaintNonNu && !isPaintAoNam && !isPaintAoNu && !isPaintGangTayNam && !isPaintGangTayNu && !isPaintQuanNam && !isPaintQuanNu && !isPaintGiayNam && !isPaintGiayNu && !isPaintLien && !isPaintNhan && !isPaintNgocBoi && !isPaintPhu && !isPaintStack && !isPaintStackLock && !isPaintGrocery && !isPaintGroceryLock && !isPaintUpGrade && !isPaintConvert && !isPaintSplit && !isPaintUpPearl && !isPaintBox)
		{
			return isPaintTrade;
		}
		return true;
	}

	public bool M655()
	{
		if (!isPaintItemInfo && !isPaintInfoMe && !isPaintStore && !isPaintNonNam && !isPaintNonNu && !isPaintAoNam && !isPaintAoNu && !isPaintGangTayNam && !isPaintGangTayNu && !isPaintQuanNam && !isPaintQuanNu && !isPaintGiayNam && !isPaintGiayNu && !isPaintLien && !isPaintNhan && !isPaintNgocBoi && !isPaintPhu && !isPaintWeapon && !isPaintStack && !isPaintStackLock && !isPaintGrocery && !isPaintGroceryLock && !isPaintUpGrade && !isPaintConvert && !isPaintUpPearl && !isPaintBox && !isPaintSplit)
		{
			return isPaintTrade;
		}
		return true;
	}

	public static void M656(int w, int h)
	{
		if (GameCanvas.w == 128 || GameCanvas.h <= 208)
		{
			w = 126;
			h = 160;
		}
		indexTitle = 0;
		popupW = w;
		popupH = h;
		popupX = gW2 - w / 2;
		popupY = gH2 - h / 2;
		if (GameCanvas.isTouch && !isPaintZone && !isPaintTeam && !isPaintClan && !isPaintCharInMap && !isPaintFindTeam && !isPaintFriend && !isPaintEnemies && !isPaintTask && !isPaintMessage)
		{
			if (GameCanvas.h <= 240)
			{
				popupY -= 10;
			}
			if (GameCanvas.isTouch && !GameCanvas.isTouchControlSmallScreen && GameCanvas.currentScreen is GameScr)
			{
				popupW = 310;
				popupX = gW / 2 - popupW / 2;
				if (isPaintInfoMe && indexMenu > 0)
				{
					popupW = w;
					popupX = gW2 - w / 2;
				}
			}
		}
		if (popupY < -10)
		{
			popupY = -10;
		}
		if (GameCanvas.h > 208 && popupY < 0)
		{
			popupY = 0;
		}
		if (GameCanvas.h == 208 && popupY < 10)
		{
			popupY = 10;
		}
	}

	public static void M657()
	{
		TileMap.M1942();
	}

	public void M658(mGraphics g, string title, bool arrow)
	{
		int num = gW / 2;
		g.M933(Paint.COLORDARK);
		g.M953(num - mFont.tahoma_8b.M909(title) / 2 - 12, popupY + 4, mFont.tahoma_8b.M909(title) + 22, 24, 6, 6);
		if ((indexTitle == 0 || GameCanvas.isTouch) && arrow)
		{
			SmallImage.M1785(g, 989, num - mFont.tahoma_8b.M909(title) / 2 - 15 - 7 - ((GameCanvas.gameTick % 8 <= 3) ? 2 : 0), popupY + 16, 2, StaticObj.VCENTER_HCENTER);
			SmallImage.M1785(g, 989, num + mFont.tahoma_8b.M909(title) / 2 + 15 + 5 + ((GameCanvas.gameTick % 8 <= 3) ? 2 : 0), popupY + 16, 0, StaticObj.VCENTER_HCENTER);
		}
		if (indexTitle == 0)
		{
			g.M933(Paint.COLORFOCUS);
		}
		else
		{
			g.M933(Paint.COLORBORDER);
		}
		g.M952(num - mFont.tahoma_8b.M909(title) / 2 - 12, popupY + 4, mFont.tahoma_8b.M909(title) + 22, 24, 6, 6);
		mFont.tahoma_8b.M898(g, title, num, popupY + 9, 2);
	}

	public static int M659()
	{
		if (Char.M113().taskMaint == null)
		{
			return -1;
		}
		return mapTasks[Char.M113().taskMaint.index];
	}

	public static sbyte M660()
	{
		sbyte result = 0;
		if (Char.M113().taskMaint == null)
		{
			result = -1;
		}
		else if (Char.M113().taskMaint.index <= tasks.Length - 1)
		{
			result = (sbyte)tasks[Char.M113().taskMaint.index];
		}
		return result;
	}

	public void M661()
	{
	}

	public void onChatFromMe(string text, string to)
	{
		if (text.StartsWith("cheat_"))
		{
			try
			{
				float num2 = (Time.timeScale = float.Parse(text.Split('_')[1]));
				info1.M762("Cheat: " + num2, 0);
			}
			catch
			{
			}
		}
		AutoActionController.M2238(text, to);
		Res.M1513("CHAT");
		if (!isPaintMessage || GameCanvas.isTouch)
		{
			ChatTextField.M279().isShow = false;
		}
		if (to.Equals(mResources.chat_player))
		{
			if (info2.playerID != Char.M113().charID)
			{
				Service.M1594().M1693(text, info2.playerID);
			}
		}
		else if (!text.Equals(string.Empty))
		{
			Service.M1594().M1674(text);
		}
	}

	public void onCancelChat()
	{
		if (isPaintMessage)
		{
			isPaintMessage = false;
			ChatTextField.M279().center = null;
		}
	}

	public void M662(string strLeft, string strRight, string url, string title, string str)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		isPaintAlert = true;
		isLockKey = true;
		indexRow = 0;
		M656(175, 200);
		textsTitle = title;
		texts = mFont.tahoma_7.M903(str, popupW - 30);
		center = null;
		left = new Command(strLeft, 11068, url);
		right = new Command(strRight, 11069);
	}

	public void M663(string strLeft, string strRight, short port, string syntax, string title, string str)
	{
		isPaintAlert = true;
		isLockKey = true;
		indexRow = 0;
		M656(175, 200);
		textsTitle = title;
		texts = mFont.tahoma_7.M903(str, popupW - 30);
		center = null;
		MyVector t = new MyVector();
		t.M1111(string.Empty + port);
		t.M1111(syntax);
		left = new Command(strLeft, 11074);
		right = new Command(strRight, 11075);
	}

	public void M664()
	{
		GameCanvas.panel.M1275();
		GameCanvas.panel.M1285();
	}

	public void M665(Message message)
	{
		InfoDlg.M753();
		try
		{
			zones = new int[message.M887().M1088()];
			pts = new int[zones.Length];
			numPlayer = new int[zones.Length];
			maxPlayer = new int[zones.Length];
			rank1 = new int[zones.Length];
			rankName1 = new string[zones.Length];
			rank2 = new int[zones.Length];
			rankName2 = new string[zones.Length];
			for (int i = 0; i < zones.Length; i++)
			{
				zones[i] = message.M887().M1088();
				pts[i] = message.M887().M1088();
				numPlayer[i] = message.M887().M1088();
				maxPlayer[i] = message.M887().M1088();
				if (message.M887().M1088() == 1)
				{
					rankName1[i] = message.M887().M1100();
					rank1[i] = message.M887().M1094();
					rankName2[i] = message.M887().M1100();
					rank2[i] = message.M887().M1094();
				}
			}
		}
		catch (Exception ex)
		{
			Cout.M328("Loi ham OPEN UIZONE " + ex.ToString());
		}
	}

	public void M666()
	{
		indexMenu = 3;
		isPaintInfoMe = true;
		M656(175, 200);
	}

	private void M667()
	{
		MyVector t = new MyVector();
		t.M1111(new Command(mResources.DIES[1], 110381));
		t.M1111(new Command(mResources.DIES[2], 110382));
		t.M1111(new Command(mResources.DIES[3], 110383));
		GameCanvas.menu.M877(t, 3);
	}

	public void M668(string info, Command cmdYes, Command cmdNo)
	{
		popUpYesNo = new PopUpYesNo();
		popUpYesNo.M1487(info, cmdYes, cmdNo);
	}

	public void M669(int playerId, int xu, string info, sbyte typePK)
	{
		Char t = M626(playerId);
		if (t != null)
		{
			if (typePK == 3)
			{
				M668(info, new Command(mResources.OK, 2000, t), new Command(mResources.CLOSE, 2009, t));
			}
			if (typePK == 4)
			{
				M668(info, new Command(mResources.OK, 2005, t), new Command(mResources.CLOSE, 2009, t));
			}
		}
	}

	public void M670(int playerID)
	{
		Char t = M626(playerID);
		if (t != null)
		{
			M668(t.cName + mResources.want_to_trade, new Command(mResources.YES, 11114, t), new Command(mResources.NO, 2009, t));
		}
	}

	public void M671(int charID, sbyte cflag)
	{
		if (vFlag.M1113() == 0)
		{
			Service.M1594().M1726(2, cflag);
			Res.M1513("getFlag1");
			return;
		}
		if (charID == Char.M113().charID)
		{
			Res.M1513("my cflag: isme");
			if (Char.M113().M231(cflag))
			{
				Res.M1513("my cflag: true");
				for (int i = 0; i < vFlag.M1113(); i++)
				{
					PKFlag t = (PKFlag)vFlag.M1114(i);
					if (t != null && t.cflag == cflag)
					{
						Res.M1513("my cflag: cflag==");
						Char.M113().flagImage = t.IDimageFlag;
					}
				}
			}
			else if (!Char.M113().M231(cflag))
			{
				Res.M1513("my cflag: false");
				Service.M1594().M1726(2, cflag);
			}
			return;
		}
		Res.M1513("my cflag: not me");
		if (M626(charID) == null)
		{
			return;
		}
		if (M626(charID).M231(cflag))
		{
			Res.M1513("my cflag: true");
			for (int j = 0; j < vFlag.M1113(); j++)
			{
				PKFlag t2 = (PKFlag)vFlag.M1114(j);
				if (t2 != null && t2.cflag == cflag)
				{
					Res.M1513("my cflag: cflag==");
					M626(charID).flagImage = t2.IDimageFlag;
				}
			}
		}
		else if (!M626(charID).M231(cflag))
		{
			Res.M1513("my cflag: false");
			Service.M1594().M1726(2, cflag);
		}
	}

	public void M672(int idAction, object p)
	{
		Cout.M326("PERFORM WITH ID = " + idAction);
		switch (idAction)
		{
		case 2:
			GameCanvas.menu.showMenu = false;
			break;
		case 1:
			GameCanvas.M488();
			break;
		case 8002:
			M597(isFireByShortCut: false, skipWaypoint: true);
			GameCanvas.M484();
			GameCanvas.M483();
			break;
		case 2000:
			popUpYesNo = null;
			GameCanvas.M488();
			if ((Char)p == null)
			{
				Service.M1594().M1687(1, 3, -1);
				break;
			}
			Service.M1594().M1687(1, 3, ((Char)p).charID);
			Service.M1594().M1640();
			break;
		case 2001:
			GameCanvas.M488();
			break;
		case 2003:
			GameCanvas.M488();
			InfoDlg.M749();
			Service.M1594().M1687(0, 3, Char.M113().charFocus.charID);
			break;
		case 2004:
			GameCanvas.M488();
			Service.M1594().M1687(0, 4, Char.M113().charFocus.charID);
			break;
		case 2005:
			GameCanvas.M488();
			popUpYesNo = null;
			if ((Char)p == null)
			{
				Service.M1594().M1687(1, 4, -1);
			}
			else
			{
				Service.M1594().M1687(1, 4, ((Char)p).charID);
			}
			break;
		case 2006:
			GameCanvas.M488();
			Service.M1594().M1687(2, 4, Char.M113().charFocus.charID);
			break;
		case 2007:
			GameCanvas.M488();
			GameMidlet.instance.M520();
			break;
		case 2009:
			popUpYesNo = null;
			break;
		case 11038:
			M667();
			break;
		case 11000:
			M664();
			break;
		case 11001:
			Char.M113().M212();
			break;
		case 11002:
			GameCanvas.panel.M1382();
			break;
		case 11059:
			M602(onScreenSkill[selectedIndexSkill], isShortcut: false);
			center = null;
			break;
		case 11057:
		{
			Effect2.vEffect2Outside.M1120();
			Effect2.vEffect2.M1120();
			Npc t8 = (Npc)p;
			if (t8.idItem == 0)
			{
				Service.M1594().M1655((short)t8.template.npcTemplateId, (sbyte)GameCanvas.menu.menuSelectedItem);
			}
			else if (GameCanvas.menu.menuSelectedItem == 0)
			{
				Service.M1594().M1670(t8.idItem);
			}
			break;
		}
		case 11111:
			if (Char.M113().charFocus != null)
			{
				InfoDlg.M749();
				if (GameCanvas.panel.vPlayerMenu.M1113() <= 0)
				{
					M569(Char.M113().charFocus);
				}
				GameCanvas.panel.M1259(Char.M113().charFocus);
				GameCanvas.panel.M1285();
				Service.M1594().M1610(Char.M113().charFocus.charID);
				Service.M1594().M1737(Char.M113().charFocus.charID);
			}
			break;
		case 11112:
		{
			Char t7 = (Char)p;
			Service.M1594().M1608(1, t7.charID);
			break;
		}
		case 11113:
		{
			Char t6 = (Char)p;
			if (t6 != null)
			{
				Service.M1594().M1601(0, t6.charID, -1, -1);
			}
			break;
		}
		case 11114:
		{
			popUpYesNo = null;
			GameCanvas.M488();
			Char t5 = (Char)p;
			if (t5 != null)
			{
				Service.M1594().M1601(1, t5.charID, -1, -1);
			}
			break;
		}
		case 11115:
			if (Char.M113().charFocus != null)
			{
				InfoDlg.M749();
				Service.M1594().M1738(Char.M113().charFocus.charID, (short)Char.M113().charFocus.menuSelect);
			}
			break;
		case 11120:
		{
			object[] array2 = (object[])p;
			Skill t4 = (Skill)array2[0];
			int num2 = int.Parse((string)array2[1]);
			for (int j = 0; j < onScreenSkill.Length; j++)
			{
				if (onScreenSkill[j] == t4)
				{
					onScreenSkill[j] = null;
				}
			}
			onScreenSkill[num2] = t4;
			M547();
			break;
		}
		case 11121:
		{
			object[] array = (object[])p;
			Skill t3 = (Skill)array[0];
			int num = int.Parse((string)array[1]);
			for (int i = 0; i < keySkill.Length; i++)
			{
				if (keySkill[i] == t3)
				{
					keySkill[i] = null;
				}
			}
			keySkill[num] = t3;
			M548();
			break;
		}
		case 11067:
			if (TileMap.zoneID != indexSelect)
			{
				Service.M1594().M1638(indexSelect, indexItemUse);
				InfoDlg.M749();
			}
			else
			{
				info1.M762(mResources.ZONE_HERE, 0);
			}
			break;
		case 110001:
			GameCanvas.panel.M1275();
			GameCanvas.panel.M1285();
			break;
		case 12000:
			Service.M1594().M1623(1, -1, null);
			break;
		case 12001:
			GameCanvas.M488();
			break;
		case 12002:
		{
			GameCanvas.M488();
			ClanObject t2 = (ClanObject)p;
			Service.M1594().M1622(1, -1, t2.clanID, t2.code);
			popUpYesNo = null;
			break;
		}
		case 12003:
		{
			ClanObject t = (ClanObject)p;
			GameCanvas.M488();
			Service.M1594().M1622(2, -1, t.clanID, t.code);
			popUpYesNo = null;
			break;
		}
		case 12004:
			M602((Skill)p, isShortcut: true);
			Char.M113().M131();
			break;
		case 110382:
			Service.M1594().M1672();
			break;
		case 110004:
			GameCanvas.menu.showMenu = false;
			break;
		case 888351:
			Service.M1594().M1728(5);
			GameCanvas.M488();
			break;
		case 110391:
			Service.M1594().M1622(0, Char.M113().charFocus.charID, -1, -1);
			break;
		case 110383:
			Service.M1594().M1673();
			break;
		}
	}

	private static void M673()
	{
		if (isAnalog != 0)
		{
			xTG = (xF = GameCanvas.w - 45);
			if (gamePad.isLargeGamePad)
			{
				xSkill = gamePad.wZone + 20;
				wSkill = 35;
				xHP = xF - 45;
			}
			else if (gamePad.isMediumGamePad)
			{
				xHP = xF - 45;
			}
			yF = GameCanvas.h - 45;
			yTG = yF - 45;
		}
	}

	private void M674()
	{
		if (isAnalog == 0 || Char.M113().statusMe == 14)
		{
			return;
		}
		if (GameCanvas.M481(xF, yF, 40, 40))
		{
			mScreen.keyTouch = 5;
			if (GameCanvas.isPointerJustRelease)
			{
				GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = true;
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.isPointerJustDown = false;
				GameCanvas.isPointerClick = false;
			}
		}
		gamePad.M525();
		if (GameCanvas.M481(xTG, yTG, 34, 34))
		{
			mScreen.keyTouch = 13;
			GameCanvas.isPointerJustDown = false;
			isPointerDowning = false;
			if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
			{
				Char.M113().M212();
				GameCanvas.isPointerJustRelease = false;
				GameCanvas.isPointerJustDown = false;
				GameCanvas.isPointerClick = false;
			}
		}
	}

	private void M675(mGraphics g)
	{
		if (isAnalog != 0 && Char.M113().statusMe != 14)
		{
			g.M948((mScreen.keyTouch == 5 || mScreen.keyMouse == 5) ? imgFire1 : imgFire0, xF + 20, yF + 20, mGraphics.HCENTER | mGraphics.VCENTER);
			gamePad.M528(g);
			g.M948((mScreen.keyTouch != 13) ? imgFocus : imgFocus2, xTG + 20, yTG + 20, mGraphics.HCENTER | mGraphics.VCENTER);
		}
	}

	public void M676(string num, string finish)
	{
		winnumber = new int[num.Length];
		randomNumber = new int[num.Length];
		tMove = new int[num.Length];
		moveCount = new int[num.Length];
		delayMove = new int[num.Length];
		for (int i = 0; i < num.Length; i++)
		{
			winnumber[i] = (short)num[i];
			randomNumber[i] = Res.M1522(0, 11);
			tMove[i] = 1;
			delayMove[i] = 0;
		}
		tShow = 100;
		moveIndex = 0;
		strFinish = finish;
		lastXS = (currXS = mSystem.M1054());
	}

	public void M677(string chatVip)
	{
		if (!startChat)
		{
			currChatWidth = mFont.tahoma_7b_yellowSmall.M909(chatVip);
			xChatVip = GameCanvas.w;
			startChat = true;
		}
		if (chatVip.StartsWith("!"))
		{
			chatVip = chatVip.Substring(1, chatVip.Length);
			isFireWorks = true;
		}
		if (chatVip.StartsWith("BOSS"))
		{
			GameAutomationHub.listBosses.Add(new BossAppearanceInfo(chatVip));
			if (GameAutomationHub.listBosses.Count > 5)
			{
				GameAutomationHub.listBosses.RemoveAt(0);
			}
		}
		vChatVip.M1111(chatVip);
	}

	public void M678()
	{
		vChatVip.M1120();
		xChatVip = GameCanvas.w;
		startChat = false;
	}

	public void M679(mGraphics g)
	{
		if (vChatVip.M1113() != 0 && isPaintChatVip)
		{
			g.M922(0, GameCanvas.h - 13, GameCanvas.w, 15);
			g.M927(0, GameCanvas.h - 13, GameCanvas.w, 15, 0, 90);
			string st = (string)vChatVip.M1114(0);
			mFont.tahoma_7b_yellow.M902(g, st, xChatVip, GameCanvas.h - 13, 0, mFont.tahoma_7b_dark);
		}
	}

	public void M680()
	{
		if (!startChat)
		{
			return;
		}
		xChatVip -= 2;
		if (xChatVip < -currChatWidth)
		{
			xChatVip = GameCanvas.w;
			vChatVip.M1118(0);
			if (vChatVip.M1113() == 0)
			{
				isFireWorks = false;
				startChat = false;
			}
			else
			{
				currChatWidth = mFont.tahoma_7b_white.M909((string)vChatVip.M1114(0));
			}
		}
	}

	public void M681(string strNum)
	{
		yourNumber = strNum;
		strPaint = mFont.tahoma_7.M907(yourNumber, 500);
	}

	public static void M682()
	{
		ImageByName.M739(ImageByName.hashImagePath, 10, isTrue: false);
	}

	public static void M683(string strMsg)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		GameCanvas.M488();
		ChatPopup.M268(strMsg, 100000, new Npc(-1, 0, 0, 0, 0, 0)
		{
			avatar = 1139
		});
		ChatPopup.serverChatPopUp.cmdMsg1 = new Command(mResources.CLOSE, ChatPopup.serverChatPopUp, 1001, null);
		ChatPopup.serverChatPopUp.cmdMsg1.x = GameCanvas.w / 2 - 35;
		ChatPopup.serverChatPopUp.cmdMsg1.y = GameCanvas.h - 35;
	}

	public static bool M684()
	{
		if (TileMap.M1934())
		{
			return phuban_Info.type_PB == 0;
		}
		return false;
	}

	public void M685(mGraphics g, int x, int y, int w)
	{
		if (phuban_Info == null || isPaintOther || isPaintRada != 1 || GameCanvas.panel.isShow || !M684())
		{
			return;
		}
		if (w < fra_PVE_Bar_1.frameWidth + fra_PVE_Bar_0.frameWidth * 4)
		{
			w = fra_PVE_Bar_1.frameWidth + fra_PVE_Bar_0.frameWidth * 4;
		}
		if (x > GameCanvas.w - w / 2)
		{
			x = GameCanvas.w - w / 2;
		}
		if (x < mGraphics.M958(imgKhung) + w / 2 + 10)
		{
			x = mGraphics.M958(imgKhung) + w / 2 + 10;
		}
		int frameHeight = fra_PVE_Bar_0.frameHeight;
		int num = y + frameHeight + imgBall.M728() / 2 + 2;
		int frameWidth = fra_PVE_Bar_1.frameWidth;
		int num2 = w / 2 - frameWidth / 2;
		int num3 = x - w / 2;
		int num4 = x + frameWidth / 2;
		int y2 = y + 3;
		int num5 = num2 - fra_PVE_Bar_0.frameWidth;
		int num6 = num5 / fra_PVE_Bar_0.frameWidth;
		if (num5 % fra_PVE_Bar_0.frameWidth > 0)
		{
			num6++;
		}
		for (int i = 0; i < num6; i++)
		{
			if (i < num6 - 1)
			{
				fra_PVE_Bar_0.M439(1, num3 + fra_PVE_Bar_0.frameWidth + i * fra_PVE_Bar_0.frameWidth, y2, 0, 0, g);
			}
			else
			{
				fra_PVE_Bar_0.M439(1, num3 + num5, y2, 0, 0, g);
			}
			if (i < num6 - 1)
			{
				fra_PVE_Bar_0.M439(1, num4 + i * fra_PVE_Bar_0.frameWidth, y2, 0, 0, g);
			}
			else
			{
				fra_PVE_Bar_0.M439(1, num4 + num5 - fra_PVE_Bar_0.frameWidth, y2, 0, 0, g);
			}
		}
		fra_PVE_Bar_0.M439(0, num3, y2, 2, 0, g);
		fra_PVE_Bar_0.M439(0, num4 + num5, y2, 0, 0, g);
		if (phuban_Info.pointTeam1 > 0)
		{
			int idx = 2;
			int idx2 = 3;
			if (phuban_Info.color_1 == 4)
			{
				idx = 4;
				idx2 = 5;
			}
			int num7 = phuban_Info.pointTeam1 * num2 / phuban_Info.maxPoint;
			if (num7 < 0)
			{
				num7 = 0;
			}
			if (num7 > num2)
			{
				num7 = num2;
			}
			g.M922(num3 + num2 - num7, y2, num7, frameHeight);
			for (int j = 0; j < num6; j++)
			{
				if (j < num6 - 1)
				{
					fra_PVE_Bar_0.M439(idx2, num3 + fra_PVE_Bar_0.frameWidth + j * fra_PVE_Bar_0.frameWidth, y2, 0, 0, g);
				}
				else
				{
					fra_PVE_Bar_0.M439(idx2, num3 + num5, y2, 0, 0, g);
				}
			}
			fra_PVE_Bar_0.M439(idx, num3, y2, 2, 0, g);
			GameCanvas.M451(g);
		}
		if (phuban_Info.pointTeam2 > 0)
		{
			int idx3 = 2;
			int idx4 = 3;
			if (phuban_Info.color_2 == 4)
			{
				idx3 = 4;
				idx4 = 5;
			}
			int num8 = phuban_Info.pointTeam2 * num2 / phuban_Info.maxPoint;
			if (num8 < 0)
			{
				num8 = 0;
			}
			if (num8 > num2)
			{
				num8 = num2;
			}
			g.M922(num4, y2, num8, frameHeight);
			for (int k = 0; k < num6; k++)
			{
				if (k < num6 - 1)
				{
					fra_PVE_Bar_0.M439(idx4, num4 + k * fra_PVE_Bar_0.frameWidth, y2, 0, 0, g);
				}
				else
				{
					fra_PVE_Bar_0.M439(idx4, num4 + num5 - fra_PVE_Bar_0.frameWidth, y2, 0, 0, g);
				}
			}
			fra_PVE_Bar_0.M439(idx3, num4 + num5, y2, 0, 0, g);
			GameCanvas.M451(g);
		}
		fra_PVE_Bar_1.M439(0, x - frameWidth / 2, y, 0, 0, g);
		string st = mSystem.M1040(phuban_Info.timeStart, phuban_Info.timeSecond, isOnlySecond: true, isShortText: false);
		mFont.tahoma_7b_yellow.M898(g, st, x + 1, y + fra_PVE_Bar_1.frameHeight / 2 - mFont.tahoma_7b_green2.M912() / 2, 2);
		Panel.M1453(phuban_Info.color_1, 1).M898(g, phuban_Info.nameTeam1, x - 5, num + 5, 1);
		Panel.M1453(phuban_Info.color_2, 1).M898(g, phuban_Info.nameTeam2, x + 5, num + 5, 0);
		if (phuban_Info.type_PB != 0)
		{
			int y3 = y + frameHeight / 2 - 2;
			mFont.bigNumber_While.M898(g, string.Empty + phuban_Info.pointTeam1, num3 + num2 / 2, y3, 2);
			mFont.bigNumber_While.M898(g, string.Empty + phuban_Info.pointTeam2, num4 + num2 / 2, y3, 2);
		}
		g.M948(imgVS, x, y + fra_PVE_Bar_1.frameHeight + 2, 3);
		if (phuban_Info.type_PB == 0)
		{
			M686(g, phuban_Info.maxLife, phuban_Info.color_1, phuban_Info.lifeTeam1, x - 13, phuban_Info.color_2, phuban_Info.lifeTeam2, x + 13, num);
		}
	}

	public static void M686(mGraphics g, int maxLife, int cl1, int lifeTeam1, int x1, int cl2, int lifeTeam2, int x2, int y)
	{
		if (imgBall == null)
		{
			return;
		}
		int num = imgBall.M728() / 2;
		for (int i = 0; i < maxLife; i++)
		{
			int num2 = 0;
			if (i < lifeTeam1)
			{
				num2 = 1;
			}
			g.M940(imgBall, 0, num2 * num, imgBall.M727(), num, 0, x1 - i * (num + 1), y, mGraphics.VCENTER | mGraphics.HCENTER);
		}
		for (int j = 0; j < maxLife; j++)
		{
			int num3 = 0;
			if (j < lifeTeam2)
			{
				num3 = 1;
			}
			g.M940(imgBall, 0, num3 * num, imgBall.M727(), num, 0, x2 + j * (num + 1), y, mGraphics.VCENTER | mGraphics.HCENTER);
		}
	}

	public static void M687(mGraphics g, int x, int y, Char c)
	{
		g.M948(imgKhung, x, y, 0);
		int x2 = x + 3;
		int num = y + 19;
		int num2 = imgHP_NEW.M727();
		int num3 = imgHP_NEW.M728() / 2;
		int num4 = c.cHP * num2 / c.cHPFull;
		if (num4 <= 0)
		{
			num4 = 1;
		}
		else if (num4 > num2)
		{
			num4 = num2;
		}
		g.M940(imgHP_NEW, 0, num3, num4, num3, 0, x2, num, 0);
		int num5 = c.cMP * num2 / c.cMPFull;
		if (num5 <= 0)
		{
			num5 = 1;
		}
		else if (num5 > num2)
		{
			num5 = num2;
		}
		g.M940(imgHP_NEW, 0, 0, num5, num3, 0, x2, num + 6, 0);
		int x3 = x + imgKhung.M727() / 2 + 1;
		int y2 = num + 13;
		mFont.tahoma_7_green2.M898(g, c.cName, x3, y + 4, 2);
		if (c.mobFocus != null)
		{
			if (c.mobFocus.M998() != null)
			{
				mFont.tahoma_7_green2.M898(g, c.mobFocus.M998().name, x3, y2, 2);
			}
		}
		else if (c.npcFocus != null)
		{
			mFont.tahoma_7_green2.M898(g, c.npcFocus.template.name, x3, y2, 2);
		}
		else if (c.charFocus != null)
		{
			mFont.tahoma_7_green2.M898(g, c.charFocus.cName, x3, y2, 2);
		}
	}

	public static void M688(int type, int subtype, int x, int y, int levelPaint, int dir)
	{
		M689(new Effect_End(type, subtype, x, y, levelPaint, dir));
	}

	public static void M689(Effect_End eff)
	{
		if (eff.levelPaint == 0)
		{
			EffectManager.M408(eff);
		}
		else if (eff.levelPaint == 1)
		{
			EffectManager.M410(eff);
		}
		else
		{
			EffectManager.M412(eff);
		}
	}

	public static bool M690(int x, int y, int wOne, int hOne)
	{
		if (x >= cmx - wOne && x <= cmx + GameCanvas.w + wOne && y >= cmy - hOne)
		{
			return y <= cmy + GameCanvas.h + hOne * 3 / 2;
		}
		return false;
	}

	public static bool M691()
	{
		return GameCanvas.w <= 320;
	}
}
