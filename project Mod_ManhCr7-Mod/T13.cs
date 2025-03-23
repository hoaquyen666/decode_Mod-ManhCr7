using System;
using N5.N6.N7;
using N5.N6.N9;

public class T13 : T62
{
	public string xuStr;

	public string luongStr;

	public string luongKhoaStr;

	public long lastUpdateTime;

	public bool meLive;

	public bool isMask;

	public bool isTeleport;

	public bool isUsePlane;

	public int shadowX;

	public int shadowY;

	public int shadowLife;

	public bool isNhapThe;

	public T207 petFollow;

	public int rank;

	public const sbyte A_STAND = 1;

	public const sbyte A_RUN = 2;

	public const sbyte A_JUMP = 3;

	public const sbyte A_FALL = 4;

	public const sbyte A_DEADFLY = 5;

	public const sbyte A_NOTHING = 6;

	public const sbyte A_ATTK = 7;

	public const sbyte A_INJURE = 8;

	public const sbyte A_AUTOJUMP = 9;

	public const sbyte A_FLY = 10;

	public const sbyte SKILL_STAND = 12;

	public const sbyte SKILL_FALL = 13;

	public const sbyte A_DEAD = 14;

	public const sbyte A_HIDE = 15;

	public const sbyte A_RESETPOINT = 16;

	public static T14 chatPopup;

	public long cPower;

	public T65 chatInfo;

	public sbyte petStatus;

	public int cx = 24;

	public int cy = 24;

	public int cvx;

	public int cvy;

	public int cp1;

	public int cp2;

	public int cp3;

	public int statusMe = 5;

	public int cdir = 1;

	public int charID;

	public int cgender;

	public int ctaskId;

	public int menuSelect;

	public int cBonusSpeed;

	public int cspeed = 4;

	public int ccurrentAttack;

	public int cDamFull;

	public int cDefull;

	public int cCriticalFull;

	public int clevel;

	public int cMP;

	public int cHP;

	public int cHPNew;

	public int cMaxEXP;

	public int cHPShow;

	public int xReload;

	public int yReload;

	public int cyStartFall;

	public int saveStatus;

	public int eff5BuffHp;

	public int eff5BuffMp;

	public int cHPFull;

	public int cMPFull;

	public int cdameDown;

	public int cStr;

	public long cLevelPercent;

	public long cTiemNang;

	public long cNangdong;

	public int damHP;

	public int damMP;

	public bool isMob;

	public bool isCrit;

	public bool isDie;

	public int pointUydanh;

	public int pointNon;

	public int pointVukhi;

	public int pointAo;

	public int pointLien;

	public int pointGangtay;

	public int pointNhan;

	public int pointQuan;

	public int pointNgocboi;

	public int pointGiay;

	public int pointPhu;

	public int countFinishDay;

	public int countLoopBoos;

	public int limitTiemnangso;

	public int limitKynangso;

	public short[] potential = new short[4];

	public string cName = string.Empty;

	public int clanID;

	public sbyte ctypeClan;

	public T16 clan;

	public sbyte role;

	public int cw = 22;

	public int ch = 32;

	public int chw = 11;

	public int chh = 16;

	public T22 cmdMenu;

	public bool canFly = true;

	public bool cmtoChar;

	public bool me;

	public bool cFinishedAttack;

	public bool cchistlast;

	public bool isAttack;

	public bool isAttFly;

	public int cwpt;

	public int cwplv;

	public int cf;

	public int tick;

	public static bool fallAttack;

	public bool isJump;

	public bool autoFall;

	public bool attack = true;

	public long xu;

	public int xuInBox;

	public int yen;

	public int gold_lock;

	public int luong;

	public int luongKhoa;

	public T119 nClass;

	public T22 endMovePointCommand;

	public T117 vSkill = new T117();

	public T117 vSkillFight = new T117();

	public T117 vEff = new T117();

	public T149 myskill;

	public T168 taskMaint;

	public bool paintName = true;

	public T3[] arrArchive;

	public T79[] arrItemBag;

	public T79[] arrItemBox;

	public T79[] arrItemBody;

	public T149[] arrPetSkill;

	public T79[][] arrItemShop;

	public string[][] infoSpeacialSkill;

	public short[][] imgSpeacialSkill;

	public short cResFire;

	public short cResIce;

	public short cResWind;

	public short cMiss;

	public short cExactly;

	public short cFatal;

	public sbyte cPk;

	public sbyte cTypePk;

	public short cReactDame;

	public short sysUp;

	public short sysDown;

	public int avatar;

	public int skillTemplateId;

	public T101 mobFocus;

	public T101 mobMe;

	public int tMobMeBorn;

	public T123 npcFocus;

	public T13 charFocus;

	public T80 itemFocus;

	public T117 focus = new T117();

	public T101[] attMobs;

	public T13[] attChars;

	public short[] moveFast;

	public int testCharId = -9999;

	public int killCharId = -9999;

	public sbyte resultTest;

	public int countKill;

	public int countKillMax;

	public bool isInvisiblez;

	public bool isShadown = true;

	public const sbyte PK_NORMAL = 0;

	public const sbyte PK_PHE = 1;

	public const sbyte PK_BANG = 2;

	public const sbyte PK_THIDAU = 3;

	public const sbyte PK_LUYENTAP = 4;

	public const sbyte PK_TUDO = 5;

	public T117 taskOrders = new T117();

	public int cStamina;

	public static short[] idHead;

	public static short[] idAvatar;

	public int exp;

	public string[] strLevel;

	public string currStrLevel;

	public static T60 eyeTraiDat;

	public static T60 eyeNamek;

	public bool isFreez;

	public bool isCharge;

	public int seconds;

	public int freezSeconds;

	public long last;

	public long cur;

	public long lastFreez;

	public long currFreez;

	public bool isFlyUp;

	public static T117 vItemTime;

	public static short ID_NEW_MOUNT;

	public short idMount;

	public bool isHaveMount;

	public bool isMountVip;

	public bool isEventMount;

	public bool isSpeacialMount;

	public static T60 imgMount_TD;

	public static T60 imgMount_NM;

	public static T60 imgMount_NM_1;

	public static T60 imgMount_XD;

	public static T60 imgMount_TD_VIP;

	public static T60 imgMount_NM_VIP;

	public static T60 imgMount_NM_1_VIP;

	public static T60 imgMount_XD_VIP;

	public static T60 imgEventMount;

	public static T60 imgEventMountWing;

	public sbyte[] FrameMount = new sbyte[8] { 0, 0, 1, 1, 2, 2, 1, 1 };

	public int frameMount;

	public int frameNewMount;

	public int transMount;

	public int genderMount;

	public int idcharMount;

	public int xMount;

	public int yMount;

	public int dxMount;

	public int dyMount;

	public int xChar;

	public int xdis;

	public int speedMount;

	public bool isStartMount;

	public bool isMount;

	public bool isEndMount;

	public sbyte cFlag;

	public int flagImage;

	public static int[][][] CharInfo;

	public static int[] CHAR_WEAPONX;

	public static int[] CHAR_WEAPONY;

	private static T13 myChar;

	private static T13 myPet;

	public static int[] listAttack;

	public static int[][] listIonC;

	public int cvyJump;

	private int indexUseSkill = -1;

	public int cxSend;

	public int cySend;

	public int cdirSend = 1;

	public int cxFocus;

	public int cyFocus;

	public int cactFirst = 5;

	public T117 vMovePoints = new T117();

	public static string[][] inforClass;

	public static int[][] inforSkill;

	public static bool flag;

	public static bool ischangingMap;

	public static bool isLockKey;

	public static bool isLoadingMap;

	public bool isLockMove;

	public bool isLockAttack;

	public string strInfo;

	public short powerPoint;

	public short maxPowerPoint;

	public short secondPower;

	public long lastS;

	public long currS;

	public bool havePet = true;

	public T107 currentMovePoint;

	public int bom;

	public int delayFall;

	private bool isSoundJump;

	public int lastFrame;

	private T32 eProtect;

	private int twHp;

	public bool isInjureHp;

	public bool changePos;

	private bool isHide;

	private bool wy;

	public int wt;

	public int fy;

	public int ty;

	private int t;

	private int fM;

	public int[] move = new int[15]
	{
		1, 1, 1, 1, 2, 2, 2, 2, 3, 3,
		3, 3, 2, 2, 2
	};

	private string strMount = "mount_";

	public int headICON = -1;

	public int head;

	public int leg;

	public int body;

	public int bag;

	public int wp;

	public int indexEff = -1;

	public int indexEffTask = -1;

	public T35 eff;

	public T35 effTask;

	public int indexSkill;

	public int i0;

	public int i1;

	public int i2;

	public int dx0;

	public int dx1;

	public int dx2;

	public int dy0;

	public int dy1;

	public int dy2;

	public T35 eff0;

	public T35 eff1;

	public T35 eff2;

	public T5 arr;

	public T130 dart;

	public bool isCreateDark;

	public T153 skillPaint;

	public T153 skillPaintRandomPaint;

	public T40[] effPaints;

	public int sType;

	public sbyte isInjure;

	public bool isUseSkillAfterCharge;

	public bool isFlyAndCharge;

	public bool isStandAndCharge;

	private bool isFlying;

	public int posDisY;

	private int chargeCount;

	private bool hasSendAttack;

	public bool isMabuHold;

	private long timeBlue;

	private int tBlue;

	private bool IsAddDust1;

	private bool IsAddDust2;

	public bool isPet;

	public bool isMiniPet;

	public int xSd;

	public int ySd;

	private bool isOutMap;

	private int fBag;

	private int statusBeforeNothing;

	private int timeFocusToMob;

	public static bool isManualFocus;

	private T13 charHold;

	private T101 mobHold;

	private int nInjure;

	public short wdx;

	public short wdy;

	public bool isDirtyPostion;

	public T149 lastNormalSkill;

	public bool currentFireByShortcut;

	public int cDamGoc;

	public int cHPGoc;

	public int cMPGoc;

	public int cDefGoc;

	public int cCriticalGoc;

	public sbyte hpFrom1000TiemNang;

	public sbyte mpFrom1000TiemNang;

	public sbyte damFrom1000TiemNang;

	public sbyte defFrom1000TiemNang = 1;

	public sbyte criticalFrom1000Tiemnang = 1;

	public short cMaxStamina;

	public short expForOneAdd;

	public sbyte isMonkey;

	public bool isCopy;

	public bool isWaitMonkey;

	private bool isFeetEff;

	public bool meDead;

	public int holdEffID;

	public bool holder;

	public bool protectEff;

	private bool isSetPos;

	private int tpos;

	private short xPos;

	private short yPos;

	private sbyte typePos;

	private bool isMyFusion;

	public bool isFusion;

	public int tFusion;

	public bool huytSao;

	public bool blindEff;

	public bool telePortSkill;

	public bool sleepEff;

	public bool stone;

	public int perCentMp = 100;

	public int dHP;

	public int headTemp = -1;

	public int bodyTemp = -1;

	public int legTemp = -1;

	public int bagTemp = -1;

	public int wpTemp = -1;

	public T117 vEffChar = new T117("vEff");

	public static T49 fraRedEye;

	private int fChopmat;

	private bool isAddChopMat;

	private long timeAddChopmat;

	private int[] frChopNhanh = new int[34]
	{
		-1, -1, -1, -1, 0, 0, 1, 1, 0, 0,
		1, 1, 0, 0, 1, 1, 0, 0, 1, 1,
		0, 0, 1, 1, 0, 0, 1, 1, 0, 0,
		-1, -1, -1, -1
	};

	private int[] frChopCham = new int[23]
	{
		-1, -1, -1, -1, 0, 0, 1, 1, 1, 0,
		0, 1, 1, 1, 0, 0, 1, 1, 1, -1,
		-1, -1, -1
	};

	private int[] frEye = new int[30]
	{
		-1, -1, 0, 0, 1, 1, 0, 0, 1, 1,
		0, 0, 1, 1, 0, 0, 1, 1, 0, 0,
		1, 1, 0, 0, 1, 1, 0, 0, -1, -1
	};

	public static int[][] Arr_Head_2Fr;

	private int fHead;

	private string strEffAura = "aura_";

	public short idAuraEff = -1;

	public static bool isPaintAura;

	private T49 fraEff;

	private T49 fraEffSub;

	private string strEff_Set_Item = "set_eff_";

	public short idEff_Set_Item = -1;

	private T49 fraHat_behind;

	private T49 fraHat_font;

	private T49 fraHat_behind_2;

	private T49 fraHat_font_2;

	private string strHat_behind = "hat_sau_";

	private string strHat_font = "hat_truoc_";

	private string strNgang = "ngang_";

	public short idHat = -1;

	public static int[][] hatInfo;

	public bool isNRD;

	public int timeNRD;

	public long lastTimeNRD;

	public T13()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		statusMe = 6;
	}

	static T13()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		eyeTraiDat = T51.M503("/mainImage/myTexture2dmat-trai-dat.png");
		eyeNamek = T51.M503("/mainImage/myTexture2dmat-namek.png");
		vItemTime = new T117();
		ID_NEW_MOUNT = 30000;
		imgMount_TD = T51.M503("/mainImage/myTexture2dthucuoi10.png");
		imgMount_NM = T51.M503("/mainImage/myTexture2dthucuoi20.png");
		imgMount_NM_1 = T51.M503("/mainImage/myTexture2dthucuoi21.png");
		imgMount_XD = T51.M503("/mainImage/myTexture2dthucuoi30.png");
		imgMount_TD_VIP = T51.M503("/mainImage/myTexture2dthucuoi11.png");
		imgMount_NM_VIP = T51.M503("/mainImage/myTexture2dthucuoi22.png");
		imgMount_NM_1_VIP = T51.M503("/mainImage/myTexture2dthucuoi23.png");
		imgMount_XD_VIP = T51.M503("/mainImage/myTexture2dthucuoi31.png");
		imgEventMount = T51.M503("/mainImage/myTexture2drong.png");
		imgEventMountWing = T51.M503("/mainImage/myTexture2dcanhrong.png");
		CharInfo = new int[33][][]
		{
			new int[4][]
			{
				new int[3] { 0, -13, 34 },
				new int[3] { 1, -8, 10 },
				new int[3] { 1, -9, 16 },
				new int[3] { 1, -9, 45 }
			},
			new int[4][]
			{
				new int[3] { 0, -13, 35 },
				new int[3] { 1, -8, 10 },
				new int[3] { 1, -9, 17 },
				new int[3] { 1, -9, 46 }
			},
			new int[4][]
			{
				new int[3] { 1, -10, 33 },
				new int[3] { 2, -10, 11 },
				new int[3] { 2, -8, 16 },
				new int[3] { 1, -12, 49 }
			},
			new int[4][]
			{
				new int[3] { 1, -10, 32 },
				new int[3] { 3, -12, 10 },
				new int[3] { 3, -11, 15 },
				new int[3] { 1, -13, 47 }
			},
			new int[4][]
			{
				new int[3] { 1, -10, 34 },
				new int[3] { 4, -8, 11 },
				new int[3] { 4, -7, 17 },
				new int[3] { 1, -12, 47 }
			},
			new int[4][]
			{
				new int[3] { 1, -10, 34 },
				new int[3] { 5, -12, 11 },
				new int[3] { 5, -9, 17 },
				new int[3] { 1, -13, 49 }
			},
			new int[4][]
			{
				new int[3] { 1, -10, 33 },
				new int[3] { 6, -10, 10 },
				new int[3] { 6, -8, 16 },
				new int[3] { 1, -12, 47 }
			},
			new int[4][]
			{
				new int[3] { 0, -9, 36 },
				new int[3] { 7, -5, 17 },
				new int[3] { 7, -11, 25 },
				new int[3] { 1, -8, 49 }
			},
			new int[4][]
			{
				new int[3] { 0, -7, 35 },
				new int[3] { 0, -18, 22 },
				new int[3] { 7, -10, 25 },
				new int[3] { 1, -7, 48 }
			},
			new int[4][]
			{
				new int[3] { 1, -11, 35 },
				new int[3] { 10, -3, 25 },
				new int[3] { 12, -10, 26 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 1, -11, 37 },
				new int[3] { 11, -3, 25 },
				new int[3] { 12, -11, 27 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -14, 34 },
				new int[3] { 12, -8, 21 },
				new int[3] { 9, -7, 31 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -12, 35 },
				new int[3] { 8, -5, 14 },
				new int[3] { 8, -15, 29 },
				new int[3] { 1, -9, 49 }
			},
			new int[4][]
			{
				new int[3] { 1, -9, 34 },
				new int[3] { 9, -12, 9 },
				new int[3] { 10, -7, 19 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 1, -13, 34 },
				new int[3] { 9, -12, 9 },
				new int[3] { 11, -10, 19 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 1, -8, 32 },
				new int[3] { 9, -12, 9 },
				new int[3] { 2, -6, 15 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 1, -8, 32 },
				new int[3] { 9, -12, 9 },
				new int[3] { 13, -12, 16 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -10, 31 },
				new int[3] { 9, -12, 9 },
				new int[3] { 7, -13, 20 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -11, 32 },
				new int[3] { 9, -12, 9 },
				new int[3] { 8, -15, 26 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -9, 33 },
				new int[3] { 9, -12, 9 },
				new int[3] { 14, -8, 18 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -11, 33 },
				new int[3] { 9, -12, 9 },
				new int[3] { 15, -6, 19 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -16, 31 },
				new int[3] { 9, -12, 9 },
				new int[3] { 9, -8, 28 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -14, 34 },
				new int[3] { 1, -8, 10 },
				new int[3] { 8, -16, 28 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -8, 36 },
				new int[3] { 7, -5, 17 },
				new int[3] { 0, -5, 25 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -9, 31 },
				new int[3] { 9, -12, 9 },
				new int[3] { 0, -6, 20 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 2, -9, 36 },
				new int[3] { 13, -5, 17 },
				new int[3] { 16, -11, 25 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 1, -9, 34 },
				new int[3] { 8, -5, 13 },
				new int[3] { 10, -7, 19 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 1, -13, 34 },
				new int[3] { 8, -5, 13 },
				new int[3] { 11, -10, 19 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 1, -8, 32 },
				new int[3] { 8, -5, 13 },
				new int[3] { 2, -6, 15 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 1, -8, 32 },
				new int[3] { 8, -5, 13 },
				new int[3] { 13, -12, 16 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -9, 33 },
				new int[3] { 8, -5, 13 },
				new int[3] { 14, -8, 18 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -11, 33 },
				new int[3] { 8, -5, 13 },
				new int[3] { 15, -6, 19 },
				new int[3]
			},
			new int[4][]
			{
				new int[3] { 0, -16, 32 },
				new int[3] { 8, -5, 13 },
				new int[3] { 9, -8, 29 },
				new int[3]
			}
		};
		CHAR_WEAPONX = new int[11]
		{
			-2, -6, 22, 21, 19, 22, 10, -2, -2, 5,
			19
		};
		CHAR_WEAPONY = new int[11]
		{
			9, 22, 25, 17, 26, 37, 36, 49, 50, 52,
			36
		};
		inforClass = new string[2][]
		{
			new string[4] { "1", "1", "chiêu 1", "0" },
			new string[4] { "2", "2", "chiêu 2", "5" }
		};
		inforSkill = new int[10][]
		{
			new int[12]
			{
				1, 0, 1, 1000, 40, 1, 0, 20, 0, 0,
				0, 0
			},
			new int[12]
			{
				2, 1, 10, 1000, 100, 1, 0, 40, 0, 0,
				0, 0
			},
			new int[12]
			{
				2, 2, 11, 800, 100, 1, 0, 45, 0, 0,
				0, 0
			},
			new int[12]
			{
				2, 3, 12, 600, 100, 1, 0, 50, 0, 0,
				0, 0
			},
			new int[12]
			{
				2, 4, 13, 500, 100, 1, 0, 55, 0, 0,
				0, 0
			},
			new int[12]
			{
				3, 1, 14, 500, 100, 1, 0, 60, 0, 0,
				0, 0
			},
			new int[12]
			{
				3, 2, 14, 500, 100, 1, 0, 60, 0, 0,
				0, 0
			},
			new int[12]
			{
				3, 3, 14, 500, 100, 1, 0, 60, 0, 0,
				0, 0
			},
			new int[12]
			{
				3, 4, 14, 500, 100, 1, 0, 60, 0, 0,
				0, 0
			},
			new int[12]
			{
				3, 5, 14, 500, 100, 1, 0, 60, 0, 0,
				0, 0
			}
		};
		isManualFocus = false;
		Arr_Head_2Fr = new int[1][] { new int[2] { 542, 543 } };
		isPaintAura = true;
		hatInfo = new int[32][]
		{
			new int[2] { 5, -7 },
			new int[2] { 5, -7 },
			new int[2] { 5, -8 },
			new int[2] { 5, -7 },
			new int[2] { 5, -6 },
			new int[2] { 5, -8 },
			new int[2] { 5, -7 },
			new int[2] { 9, 0 },
			new int[2] { 11, 1 },
			new int[2] { 4, 0 },
			new int[2] { 4, -1 },
			new int[2] { 4, 8 },
			new int[2] { 6, 5 },
			new int[2] { 6, -6 },
			new int[2] { 2, -5 },
			new int[2] { 7, -8 },
			new int[2] { 7, -6 },
			new int[2] { 8, 0 },
			new int[2] { 7, 5 },
			new int[2] { 9, -7 },
			new int[2] { 7, -3 },
			new int[2] { 2, 8 },
			new int[2] { 4, 5 },
			new int[2] { 10, -5 },
			new int[2] { 9, -5 },
			new int[2] { 9, -5 },
			new int[2] { 6, -6 },
			new int[2] { 2, -5 },
			new int[2] { 7, -8 },
			new int[2] { 7, -6 },
			new int[2] { 9, -7 },
			new int[2] { 7, -3 }
		};
	}

	public void M103()
	{
		try
		{
			long num = 1L;
			long num2 = 0L;
			int num3 = 0;
			int num4 = T54.exps.Length - 1;
			while (num4 >= 0)
			{
				if (cPower < T54.exps[num4])
				{
					num4--;
					continue;
				}
				num = ((num4 != T54.exps.Length - 1) ? (T54.exps[num4 + 1] - T54.exps[num4]) : 1L);
				num2 = cPower - T54.exps[num4];
				num3 = num4;
				break;
			}
			clevel = num3;
			cLevelPercent = (int)(num2 * 10000L / num);
		}
		catch (Exception ex)
		{
			T24.M328("Loi char level percent: " + ex.ToString());
		}
	}

	public int M104()
	{
		if (myskill != null)
		{
			return myskill.dx;
		}
		return 0;
	}

	public int M105()
	{
		if (myskill != null)
		{
			return myskill.dy;
		}
		return 0;
	}

	public static void M106(bool isNextStep)
	{
		T168 t = M113().taskMaint;
		if (t.index > t.contentInfo.Length - 1)
		{
			t.index = t.contentInfo.Length - 1;
		}
		string text = t.contentInfo[t.index];
		if (text != null && !text.Equals(string.Empty))
		{
			if (text.StartsWith("#"))
			{
				text = T122.M1187(text, "#", string.Empty);
				T123 t2 = new T123(5, 0, -100, -100, 5, T54.info1.charId[M113().cgender][2]);
				t2.cy = -100;
				t2.cx = -100;
				t2.avatar = T54.info1.charId[M113().cgender][2];
				t2.charID = 5;
				if (T51.currentScreen == T54.instance)
				{
					T14.M267(text, t2);
				}
			}
			else if (isNextStep)
			{
				T54.info1.M762(text, 0);
			}
		}
		T54.isHaveSelectSkill = true;
		T24.M326("TASKx " + M113().taskMaint.taskId);
		if (M113().taskMaint.taskId <= 2)
		{
			M113().canFly = false;
		}
		else
		{
			M113().canFly = true;
		}
		T54.M559().left = null;
		if (t.taskId == 0)
		{
			T55.isViewMap = false;
			T54.M559().right = null;
			T54.isHaveSelectSkill = false;
			T54.M559().left = null;
			if (t.index < 4)
			{
				T91.isPaint = false;
				T54.isPaintRada = -1;
			}
			if (t.index == 4)
			{
				T54.isPaintRada = 1;
				T91.isPaint = true;
			}
			if (t.index >= 5)
			{
				T54.M559().right = T54.M559().cmdFocus;
			}
		}
		if (t.taskId == 1)
		{
			T54.isHaveSelectSkill = true;
		}
		if (t.taskId >= 1)
		{
			T54.M559().right = T54.M559().cmdFocus;
			T54.M559().left = T54.M559().cmdMenu;
		}
		if (t.taskId >= 0)
		{
			T126.isPaintMap = true;
		}
		else
		{
			T126.isPaintMap = false;
		}
		if (t.taskId < 12)
		{
			T51.panel.mainTabName = mResources.mainTab1;
		}
		else
		{
			T51.panel.mainTabName = mResources.mainTab2;
		}
		T51.panel.tabName[0] = T51.panel.mainTabName;
		if (myChar.taskMaint.taskId > 10)
		{
			T138.M1538("fake", "aa");
		}
	}

	public string M107()
	{
		return strLevel[clevel] + "+" + cLevelPercent / 100L + "." + cLevelPercent % 100L + "%";
	}

	public int M108()
	{
		return M109(head);
	}

	public int M109(int headId)
	{
		for (int i = 0; i < idHead.Length; i++)
		{
			if (headId == idHead[i])
			{
				return idAvatar[i];
			}
		}
		return -1;
	}

	public void M110(string info, short p, short maxP, short sc)
	{
		powerPoint = p;
		strInfo = info;
		maxPowerPoint = maxP;
		secondPower = sc;
		lastS = (currS = T110.M1054());
	}

	public void M111(string info)
	{
		if (chatInfo == null)
		{
			chatInfo = new T65();
		}
		chatInfo.M744(info, 0, null, isChatServer: false);
	}

	public int M112()
	{
		if (nClass.classId != 1 && nClass.classId != 2)
		{
			if (nClass.classId != 3 && nClass.classId != 4)
			{
				if (nClass.classId != 5 && nClass.classId != 6)
				{
					return 0;
				}
				return 3;
			}
			return 2;
		}
		return 1;
	}

	public static T13 M113()
	{
		if (myChar == null)
		{
			myChar = new T13();
			myChar.me = true;
			myChar.cmtoChar = true;
		}
		return myChar;
	}

	public static T13 M114()
	{
		if (myPet == null)
		{
			myPet = new T13();
			myPet.me = false;
		}
		return myPet;
	}

	public static void M115()
	{
		myChar = null;
	}

	public void M116()
	{
		try
		{
			T117 t = new T117();
			for (int i = 0; i < arrItemBag.Length; i++)
			{
				T79 t2 = arrItemBag[i];
				if (t2 != null && t2.template.isUpToUp && !t2.isExpires)
				{
					t.M1111(t2);
				}
			}
			for (int j = 0; j < t.M1113(); j++)
			{
				T79 t3 = (T79)t.M1114(j);
				if (t3 == null)
				{
					continue;
				}
				for (int k = j + 1; k < t.M1113(); k++)
				{
					T79 t4 = (T79)t.M1114(k);
					if (t4 != null && t3.template.Equals(t4.template) && t3.isLock == t4.isLock)
					{
						t3.quantity += t4.quantity;
						arrItemBag[t4.indexUI] = null;
						t.M1116(null, k);
					}
				}
			}
			for (int l = 0; l < arrItemBag.Length; l++)
			{
				if (arrItemBag[l] == null)
				{
					continue;
				}
				for (int m = 0; m <= l; m++)
				{
					if (arrItemBag[m] == null)
					{
						arrItemBag[m] = arrItemBag[l];
						arrItemBag[m].indexUI = m;
						arrItemBag[l] = null;
						break;
					}
				}
			}
		}
		catch (Exception)
		{
			T24.M326("Char.bagSort()");
		}
	}

	public void M117()
	{
		try
		{
			T117 t = new T117();
			for (int i = 0; i < arrItemBox.Length; i++)
			{
				T79 t2 = arrItemBox[i];
				if (t2 != null && t2.template.isUpToUp && !t2.isExpires)
				{
					t.M1111(t2);
				}
			}
			for (int j = 0; j < t.M1113(); j++)
			{
				T79 t3 = (T79)t.M1114(j);
				if (t3 == null)
				{
					continue;
				}
				for (int k = j + 1; k < t.M1113(); k++)
				{
					T79 t4 = (T79)t.M1114(k);
					if (t4 != null && t3.template.Equals(t4.template) && t3.isLock == t4.isLock)
					{
						t3.quantity += t4.quantity;
						arrItemBox[t4.indexUI] = null;
						t.M1116(null, k);
					}
				}
			}
			for (int l = 0; l < arrItemBox.Length; l++)
			{
				if (arrItemBox[l] == null)
				{
					continue;
				}
				for (int m = 0; m <= l; m++)
				{
					if (arrItemBox[m] == null)
					{
						arrItemBox[m] = arrItemBox[l];
						arrItemBox[m].indexUI = m;
						arrItemBox[l] = null;
						break;
					}
				}
			}
		}
		catch (Exception)
		{
			T24.M326("Char.boxSort()");
		}
	}

	public void M118(int indexUI)
	{
		T79 t = arrItemBag[indexUI];
		if (!t.M805())
		{
			return;
		}
		t.isLock = true;
		t.typeUI = 5;
		T79 t2 = arrItemBody[t.template.type];
		arrItemBag[indexUI] = null;
		if (t2 != null)
		{
			t2.typeUI = 3;
			arrItemBody[t.template.type] = null;
			t2.indexUI = indexUI;
			arrItemBag[indexUI] = t2;
		}
		t.indexUI = t.template.type;
		arrItemBody[t.indexUI] = t;
		for (int i = 0; i < arrItemBody.Length; i++)
		{
			T79 t3 = arrItemBody[i];
			if (t3 != null)
			{
				if (t3.template.type == 0)
				{
					body = t3.template.part;
				}
				else if (t3.template.type == 1)
				{
					leg = t3.template.part;
				}
			}
		}
	}

	public T149 M119(T155 skillTemplate)
	{
		for (int i = 0; i < vSkill.M1113(); i++)
		{
			if (((T149)vSkill.M1114(i)).template.id == skillTemplate.id)
			{
				return (T149)vSkill.M1114(i);
			}
		}
		return null;
	}

	public T180 M120()
	{
		T168 t = myChar.taskMaint;
		if (t != null && t.taskId == 0 && t.index < 6)
		{
			return null;
		}
		int num = T174.vGo.M1113();
		sbyte b = 0;
		while (b < num)
		{
			T180 t2 = (T180)T174.vGo.M1114(b);
			if (T133.vPopups.M1113() < num || ((T133)T133.vPopups.M1114(b)).isPaint)
			{
				if (cx < t2.minX || cx > t2.maxX || cy < t2.minY || cy > t2.maxY || !t2.isEnter || !t2.isOffline)
				{
					b++;
					continue;
				}
				return t2;
			}
			return null;
		}
		return null;
	}

	public T180 M121()
	{
		T168 t = myChar.taskMaint;
		if (t != null && t.taskId == 0 && t.index < 6)
		{
			return null;
		}
		int num = T174.vGo.M1113();
		sbyte b = 0;
		while (b < num)
		{
			T180 t2 = (T180)T174.vGo.M1114(b);
			if (T133.vPopups.M1113() < num || ((T133)T133.vPopups.M1114(b)).isPaint)
			{
				if (cx < t2.minX || cx > t2.maxX || cy < t2.minY || cy > t2.maxY || !t2.isEnter || t2.isOffline)
				{
					b++;
					continue;
				}
				return t2;
			}
			return null;
		}
		return null;
	}

	public bool M122()
	{
		if (T174.M1945() && cy >= T174.pxh - 48)
		{
			return true;
		}
		if (!isTeleport && !isUsePlane)
		{
			int num = T174.vGo.M1113();
			sbyte b = 0;
			while (b < num)
			{
				T180 t = (T180)T174.vGo.M1114(b);
				if ((T174.mapID != 47 && !T174.M1945()) || cy > t.minY + t.maxY || cx <= t.minX || cx >= t.maxX)
				{
					if (cx < t.minX || cx > t.maxX || cy < t.minY || cy > t.maxY || t.isEnter)
					{
						b++;
						continue;
					}
					return true;
				}
				if (T174.M1945())
				{
					return cTypePk == 0;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public bool M123()
	{
		if (skillPaint != null)
		{
			if ((skillPaint.id >= 0 && skillPaint.id <= 6) || (skillPaint.id >= 14 && skillPaint.id <= 20) || (skillPaint.id >= 28 && skillPaint.id <= 34))
			{
				return true;
			}
			if (skillPaint.id >= 63)
			{
				return skillPaint.id <= 69;
			}
			return false;
		}
		return false;
	}

	public void M124()
	{
		if (me && statusMe == 10 && cf == 8 && ty > 20 && T51.gameTick % 20 == 0)
		{
			T160.M1826().M1859();
		}
		if (skillPaint != null && M178() != null && indexSkill < M178().Length && M123() && (me || (!me && cx >= T54.cmx && cx <= T54.cmx + T51.w)) && T51.gameTick % 5 == 0)
		{
			if (cf != 9 && cf != 10 && cf != 11)
			{
				T160.M1826().M1831(isKick: false, (!me) ? 0.05f : 0.1f);
			}
			else
			{
				T160.M1826().M1831(isKick: true, (!me) ? 0.05f : 0.1f);
			}
		}
	}

	public void M125()
	{
	}

	public virtual void update()
	{
		if (M266() && bag >= 0 && T17.idImages.M1081(bag + string.Empty))
		{
			T17 t = (T17)T17.idImages.M1074(bag + string.Empty);
			bool flag = false;
			if (t.idImage != null)
			{
				for (int i = 0; i < t.idImage.Length; i++)
				{
					if (t.idImage[i] == 2322)
					{
						isNRD = true;
						flag = true;
						if (timeNRD == 0)
						{
							timeNRD = 301;
						}
						break;
					}
				}
			}
			if (!flag)
			{
				isNRD = false;
				timeNRD = 0;
			}
		}
		if (timeNRD > 0 && T110.M1054() - lastTimeNRD >= 1000L)
		{
			timeNRD--;
			lastTimeNRD = T110.M1054();
		}
		if (isHide || isMabuHold)
		{
			return;
		}
		if (isCopy || clevel < 14)
		{
		}
		if (petFollow != null)
		{
			if (T51.gameTick % 3 == 0)
			{
				if (M113().cdir == 1)
				{
					petFollow.cmtoX = cx - 20;
				}
				if (M113().cdir == -1)
				{
					petFollow.cmtoX = cx + 20;
				}
				petFollow.cmtoY = cy - 40;
				if (petFollow.cmx > cx)
				{
					petFollow.dir = -1;
				}
				else
				{
					petFollow.dir = 1;
				}
				if (petFollow.cmtoX < 100)
				{
					petFollow.cmtoX = 100;
				}
				if (petFollow.cmtoX > T174.pxw - 100)
				{
					petFollow.cmtoX = T174.pxw - 100;
				}
			}
			petFollow.M2287();
		}
		if (!me && cHP <= 0 && clanID != -100 && statusMe != 14 && statusMe != 5)
		{
			M220((short)cx, (short)cy);
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
		else if (dHP > cHP)
		{
			int num = dHP - cHP >> 1;
			if (num < 1)
			{
				num = 1;
			}
			dHP -= num;
		}
		else
		{
			dHP = cHP;
		}
		if (secondPower != 0)
		{
			currS = T110.M1054();
			if (currS - lastS >= 1000L)
			{
				lastS = T110.M1054();
				secondPower--;
			}
		}
		if (!me && T54.notPaint)
		{
			return;
		}
		if (sleepEff && T51.gameTick % 10 == 0)
		{
			T31.M376(new T32(41, cx, cy, 3, 1, 1));
		}
		if (huytSao)
		{
			huytSao = false;
			T31.M376(new T32(39, cx, cy, 3, 3, 1));
		}
		if (blindEff && T51.gameTick % 5 == 0)
		{
			T143.M1574(113, this, 1);
		}
		if (protectEff)
		{
			if (T51.gameTick % 5 == 0)
			{
				eProtect = new T32(33, cx, cy + 37, 3, 3, 1);
			}
			if (eProtect != null)
			{
				eProtect.M393();
				eProtect.x = cx;
				eProtect.y = cy + 37;
			}
		}
		if (charFocus != null && charFocus.cy < 0)
		{
			charFocus = null;
		}
		if (isFusion)
		{
			tFusion++;
		}
		if (isNhapThe && T51.gameTick % 25 == 0)
		{
			T143.M1574(114, this, 1);
		}
		if (isSetPos)
		{
			tpos++;
			if (tpos != 1)
			{
				return;
			}
			tpos = 0;
			isSetPos = false;
			cx = xPos;
			cy = yPos;
			cp3 = 0;
			cp2 = 0;
			cp1 = 0;
			if (typePos == 1)
			{
				if (me)
				{
					cxSend = cx;
					cySend = cy;
				}
				currentMovePoint = null;
				telePortSkill = false;
				T143.M1571(173, cx, cy, 1);
			}
			else
			{
				T143.M1571(60, cx, cy, 1);
			}
			if ((T174.M1957(cx, cy) & 2) == 2)
			{
				statusMe = 1;
			}
			else
			{
				statusMe = 4;
			}
			return;
		}
		M124();
		if (stone)
		{
			return;
		}
		if (isFreez)
		{
			if (T51.gameTick % 5 == 0)
			{
				T143.M1571(113, cx, cy, 1);
			}
			cf = 23;
			long num2 = T110.M1054();
			if (num2 - lastFreez >= 1000L)
			{
				freezSeconds--;
				lastFreez = num2;
				if (freezSeconds < 0)
				{
					isFreez = false;
					seconds = 0;
					if (me)
					{
						M113().isLockMove = false;
						T54.M559().dem = 0;
						T54.M559().isFreez = false;
					}
				}
			}
			if (T174.M1956(cx / T174.size, cy / T174.size) == 0)
			{
				ty++;
				wt++;
				fy += ((!wy) ? 1 : (-1));
				if (wt == 10)
				{
					wt = 0;
					wy = !wy;
				}
			}
			return;
		}
		if (isWaitMonkey)
		{
			isLockMove = true;
			cf = 17;
			if (T51.gameTick % 5 == 0)
			{
				T143.M1571(154, cx, cy - 10, 2);
			}
			if (T51.gameTick % 5 == 0)
			{
				T143.M1571(1, cx, cy + 10, 1);
			}
			chargeCount++;
			if (chargeCount == 500)
			{
				isWaitMonkey = false;
				isLockMove = false;
			}
			return;
		}
		if (isStandAndCharge)
		{
			chargeCount++;
			bool flag2 = !T174.M1958(M113().cx, M113().cy, 2);
			M126();
			M130();
			moveFast = null;
			currentMovePoint = null;
			cf = 17;
			if (flag2 && cgender != 2)
			{
				cf = 12;
			}
			if (cgender == 2)
			{
				if (T51.gameTick % 3 == 0)
				{
					T143.M1571(154, cx, cy - ch / 2 + 10, 1);
				}
				if (T51.gameTick % 5 == 0)
				{
					T143.M1571(114, cx + T137.M1522(-20, 20), cy + T137.M1522(-20, 20), 1);
				}
			}
			if (cgender == 1 && T51.gameTick % 2 == 0)
			{
				if (cdir == 1)
				{
					T143.M1571(70, cx - 18, cy - ch / 2 + 8, 1);
					T143.M1571(70, cx + 23, cy - ch / 2 + 15, 1);
				}
				else
				{
					T143.M1571(70, cx + 18, cy - ch / 2 + 8, 1);
					T143.M1571(70, cx - 23, cy - ch / 2 + 15, 1);
				}
			}
			cur = T110.M1054();
			if (cur - last > seconds || cur - last > 10000L)
			{
				M175();
				if (me)
				{
					T54.M559().auto = 0;
					if (cgender == 2)
					{
						M113().M177(T54.sks[M113().myskill.skillId], flag2 ? 1 : 0);
						T146.M1594().M1612(8);
					}
					if (cgender == 1)
					{
						T137.M1513("set skipp paint");
						isCreateDark = true;
						M113().M172(T54.sks[M113().myskill.skillId], flag2 ? 1 : 0);
					}
				}
				else if (cgender == 2)
				{
					M177(T54.sks[skillTemplateId], flag2 ? 1 : 0);
				}
				if (cgender == 2 && statusMe != 14 && statusMe != 5)
				{
					T54.M559().M590(cx, cy);
				}
			}
			chargeCount++;
			if (chargeCount == 500)
			{
				M175();
			}
			return;
		}
		if (isFlyAndCharge)
		{
			M126();
			M130();
			moveFast = null;
			currentMovePoint = null;
			posDisY++;
			if (T174.M1958(cx, cy - ch, 8192))
			{
				M175();
				return;
			}
			if (posDisY == 20)
			{
				last = T110.M1054();
			}
			if (posDisY <= 20)
			{
				if (statusMe != 14)
				{
					statusMe = 3;
				}
				cvy = -3;
				cy += cvy;
				cf = 7;
				return;
			}
			cur = T110.M1054();
			if (cur - last <= seconds && cur - last <= 10000L)
			{
				cf = 32;
				if (cgender == 0 && T51.gameTick % 3 == 0)
				{
					T143.M1571(153, cx, cy - ch, 2);
				}
				chargeCount++;
				if (chargeCount == 500)
				{
					M175();
				}
			}
			else
			{
				isFlyAndCharge = false;
				if (me)
				{
					isCreateDark = true;
					bool flag3 = T174.M1958(M113().cx, M113().cy, 2);
					isUseSkillAfterCharge = true;
					M113().M172(T54.sks[M113().myskill.skillId], (!flag3) ? 1 : 0);
				}
			}
			return;
		}
		if (me && T51.isTouch)
		{
			if (charFocus != null && charFocus.charID >= 0 && charFocus.cx > 100 && charFocus.cx < T174.pxw - 100 && M121() == null && M120() == null && !M209() && T174.mapID != 51 && T174.mapID != 52 && T51.panel.vPlayerMenu.M1113() > 0 && T54.M559().popUpYesNo == null)
			{
				int num3 = T94.M869(cx - charFocus.cx);
				int num4 = T94.M869(cy - charFocus.cy);
				if (num3 < 60 && num4 < 40)
				{
					if (cmdMenu == null)
					{
						cmdMenu = new T22(mResources.MENU, 11111);
						cmdMenu.isPlaySoundButton = false;
					}
					cmdMenu.x = charFocus.cx - T54.cmx;
					cmdMenu.y = charFocus.cy - charFocus.ch - 30 - T54.cmy;
				}
				else
				{
					cmdMenu = null;
				}
			}
			else
			{
				cmdMenu = null;
			}
		}
		if (isShadown)
		{
			M193();
		}
		if (isTeleport)
		{
			return;
		}
		if (chatInfo != null)
		{
			chatInfo.M742();
		}
		if (shadowLife > 0)
		{
			shadowLife--;
		}
		if (resultTest > 0 && T51.gameTick % 2 == 0)
		{
			resultTest--;
			if (resultTest == 30 || resultTest == 60)
			{
				resultTest = 0;
			}
		}
		M130();
		if (mobMe != null)
		{
			M129();
		}
		if (arr != null)
		{
			arr.M3();
		}
		if (dart != null)
		{
			dart.M1463();
		}
		M126();
		if (holdEffID != 0)
		{
			if (T51.gameTick % 5 == 0)
			{
				T31.M376(new T32(32, cx, cy + 24, 3, 5, 1));
			}
		}
		else
		{
			if (blindEff || sleepEff)
			{
				return;
			}
			if (!holder)
			{
				if (cHP > 0)
				{
					for (int j = 0; j < vEff.M1113(); j++)
					{
						T34 t2 = (T34)vEff.M1114(j);
						if (t2.template.type != 0 && t2.template.type != 12)
						{
							if (t2.template.type != 4 && t2.template.type != 17)
							{
								if (t2.template.type == 13 && T51.isEff1)
								{
									cHP -= cHPFull * 3 / 100;
									if (cHP < 1)
									{
										cHP = 1;
									}
								}
							}
							else if (T51.isEff1)
							{
								cHP += t2.param;
							}
						}
						else if (T51.isEff1)
						{
							cHP += t2.param;
							cMP += t2.param;
						}
					}
					if (eff5BuffHp > 0 && T51.isEff2)
					{
						cHP += eff5BuffHp;
					}
					if (eff5BuffMp > 0 && T51.isEff2)
					{
						cMP += eff5BuffMp;
					}
					if (cHP > cHPFull)
					{
						cHP = cHPFull;
					}
					if (cMP > cMPFull)
					{
						cMP = cMPFull;
					}
				}
				if (cmtoChar)
				{
					T54.cmtoX = cx - T54.gW2;
					T54.cmtoY = cy - T54.gH23;
					if (!T51.isTouchControl)
					{
						T54.cmtoX += T54.gW6 * cdir;
					}
				}
				tick = (tick + 1) % 100;
				if (me)
				{
					if (charFocus != null && !T54.vCharInMap.M1112(charFocus))
					{
						charFocus = null;
					}
					if (cx < 10)
					{
						cvx = 0;
						cx = 10;
					}
					else if (cx > T174.pxw - 10)
					{
						cx = T174.pxw - 10;
						cvx = 0;
					}
					if (me && !ischangingMap && M122())
					{
						T146.M1594().M1640();
						if (T174.M1933())
						{
							T146.M1594().M1710();
							ischangingMap = true;
						}
						else
						{
							T146.M1594().M1636();
						}
						isLockKey = true;
						ischangingMap = true;
						T51.M484();
						T51.M483();
						T66.M749();
						return;
					}
					if (statusMe != 4 && T137.M1529(cx - cxSend) + T137.M1529(cy - cySend) >= 70 && cy - cySend <= 0 && me)
					{
						T146.M1594().M1640();
					}
					if (isLockMove)
					{
						currentMovePoint = null;
					}
					if (currentMovePoint != null)
					{
						if (M149(cx - currentMovePoint.xEnd) <= 16 && M149(cy - currentMovePoint.yEnd) <= 16)
						{
							cx = (currentMovePoint.xEnd + cx) / 2;
							cy = currentMovePoint.yEnd;
							currentMovePoint = null;
							T54.instance.clickMoving = false;
							M127();
							cvy = 0;
							cvx = 0;
							if ((T174.M1957(cx, cy) & 2) == 2)
							{
								statusMe = 1;
							}
							else
							{
								M152();
							}
							T146.M1594().M1640();
						}
						else
						{
							cdir = ((currentMovePoint.xEnd > cx) ? 1 : (-1));
							if (T174.M1958(cx, cy, 2))
							{
								statusMe = 2;
								if (currentMovePoint != null)
								{
									cvx = cspeed * cdir;
									cvy = 0;
								}
								if (M149(cx - currentMovePoint.xEnd) <= 10)
								{
									if (currentMovePoint.yEnd > cy)
									{
										currentMovePoint = null;
										T54.instance.clickMoving = false;
										statusMe = 1;
										cvy = 0;
										cvx = 0;
										M127();
									}
									else
									{
										T160.M1826().M1854();
										cx = currentMovePoint.xEnd;
										statusMe = 10;
										cvy = -5;
										cvx = 0;
									}
								}
								if (cdir == 1)
								{
									if (T174.M1958(cx + chw, cy - chh, 4))
									{
										cvx = cspeed * cdir;
										statusMe = 10;
										cvy = -5;
									}
								}
								else if (T174.M1958(cx - chw - 1, cy - chh, 8))
								{
									cvx = cspeed * cdir;
									statusMe = 10;
									cvy = -5;
								}
							}
							else
							{
								if (currentMovePoint.yEnd < cy + 10)
								{
									statusMe = 10;
									cvy = -5;
									if (M149(cy - currentMovePoint.yEnd) <= 10)
									{
										cy = currentMovePoint.yEnd;
										cvy = 0;
									}
									if (M149(cx - currentMovePoint.xEnd) <= 10)
									{
										cvx = 0;
									}
									else
									{
										cvx = cspeed * cdir;
									}
								}
								else if (T174.M1958(cx, cy, 2))
								{
									currentMovePoint = null;
									T54.instance.clickMoving = false;
									statusMe = 1;
									cvy = 0;
									cvx = 0;
									M127();
								}
								else
								{
									if (statusMe == 10 || statusMe == 2)
									{
										cvy = 0;
									}
									statusMe = 4;
								}
								if (currentMovePoint.yEnd > cy)
								{
									if (cdir == 1)
									{
										if (T174.M1958(cx + chw, cy - chh, 4))
										{
											cvy = 0;
											cvx = 0;
											statusMe = 4;
											currentMovePoint = null;
											T54.instance.clickMoving = false;
											M127();
										}
									}
									else if (T174.M1958(cx - chw - 1, cy - chh, 8))
									{
										cvy = 0;
										cvx = 0;
										statusMe = 4;
										currentMovePoint = null;
										T54.instance.clickMoving = false;
										M127();
									}
								}
							}
						}
					}
					M206();
				}
				else
				{
					M128();
					if (statusMe == 1 || statusMe == 6)
					{
						bool flag4 = false;
						if (currentMovePoint != null)
						{
							if (M149(currentMovePoint.xEnd - cx) < 17 && M149(currentMovePoint.yEnd - cy) < 25)
							{
								cx = currentMovePoint.xEnd;
								cy = currentMovePoint.yEnd;
								currentMovePoint = null;
								if ((T174.M1957(cx, cy) & 2) == 2)
								{
									statusMe = 1;
									cp3 = 0;
									T51.M442().M506(-1, cx - -8, cy);
									T51.M442().M506(1, cx - 8, cy);
								}
								else
								{
									statusMe = 4;
									cvy = 0;
									cp1 = 0;
								}
								flag4 = true;
							}
							else if ((statusBeforeNothing == 10 || cf == 8) && vMovePoints.M1113() > 0)
							{
								flag4 = true;
							}
							else if (cy == currentMovePoint.yEnd)
							{
								if (cx != currentMovePoint.xEnd)
								{
									cx = (cx + currentMovePoint.xEnd) / 2;
									cf = T51.gameTick % 5 + 2;
								}
							}
							else if (cy < currentMovePoint.yEnd)
							{
								cf = 12;
								cx = (cx + currentMovePoint.xEnd) / 2;
								if (cvy < 0)
								{
									cvy = 0;
								}
								cy += cvy;
								if ((T174.M1957(cx, cy) & 2) == 2)
								{
									T51.M442().M506(-1, cx - -8, cy);
									T51.M442().M506(1, cx - 8, cy);
								}
								cvy++;
								if (cvy > 16)
								{
									cy = (cy + currentMovePoint.yEnd) / 2;
								}
							}
							else
							{
								cf = 7;
								cx = (cx + currentMovePoint.xEnd) / 2;
								cy = (cy + currentMovePoint.yEnd) / 2;
							}
						}
						else
						{
							flag4 = true;
						}
						if (flag4 && vMovePoints.M1113() > 0)
						{
							currentMovePoint = (T107)vMovePoints.M1122();
							vMovePoints.M1118(0);
							if (currentMovePoint.status == 2)
							{
								if ((T174.M1957(cx, cy + 12) & 2) != 2)
								{
									statusMe = 10;
									cp1 = 0;
									cp2 = 0;
									cvx = -(cx - currentMovePoint.xEnd) / 10;
									cvy = -(cy - currentMovePoint.yEnd) / 10;
									if (cx - currentMovePoint.xEnd > 0)
									{
										cdir = -1;
									}
									else if (cx - currentMovePoint.xEnd < 0)
									{
										cdir = 1;
									}
								}
								else
								{
									statusMe = 2;
									if (cx - currentMovePoint.xEnd > 0)
									{
										cdir = -1;
									}
									else if (cx - currentMovePoint.xEnd < 0)
									{
										cdir = 1;
									}
									cvx = cspeed * cdir;
									cvy = 0;
								}
							}
							else if (currentMovePoint.status == 3)
							{
								if ((T174.M1957(cx, cy + 23) & 2) != 2)
								{
									statusMe = 10;
									cp1 = 0;
									cp2 = 0;
									cvx = -(cx - currentMovePoint.xEnd) / 10;
									cvy = -(cy - currentMovePoint.yEnd) / 10;
									if (cx - currentMovePoint.xEnd > 0)
									{
										cdir = -1;
									}
									else if (cx - currentMovePoint.xEnd < 0)
									{
										cdir = 1;
									}
								}
								else
								{
									statusMe = 3;
									T51.M442().M506(-1, cx - -8, cy);
									T51.M442().M506(1, cx - 8, cy);
									if (cx - currentMovePoint.xEnd > 0)
									{
										cdir = -1;
									}
									else if (cx - currentMovePoint.xEnd < 0)
									{
										cdir = 1;
									}
									cvx = M149(cx - currentMovePoint.xEnd) / 10 * cdir;
									cvy = -10;
								}
							}
							else if (currentMovePoint.status == 4)
							{
								statusMe = 4;
								if (cx - currentMovePoint.xEnd > 0)
								{
									cdir = -1;
								}
								else if (cx - currentMovePoint.xEnd < 0)
								{
									cdir = 1;
								}
								cvx = M149(cx - currentMovePoint.xEnd) / 9 * cdir;
								cvy = 0;
							}
							else
							{
								cx = currentMovePoint.xEnd;
								cy = currentMovePoint.yEnd;
								currentMovePoint = null;
							}
						}
					}
				}
				switch (statusMe)
				{
				case 1:
					M144();
					break;
				case 2:
					M147();
					break;
				case 3:
					M150();
					break;
				case 4:
					M153();
					break;
				case 5:
					M133();
					break;
				case 6:
					if (isInjure <= 0)
					{
						cf = 0;
					}
					else if (statusBeforeNothing == 10)
					{
						cx += cvx;
					}
					else if (cf <= 1)
					{
						cp1++;
						if (cp1 > 6)
						{
							cf = 0;
						}
						else
						{
							cf = 1;
						}
						if (cp1 > 10)
						{
							cp1 = 0;
						}
					}
					if (cf != 7 && cf != 12 && (T174.M1957(cx, cy + 1) & 2) != 2)
					{
						cvx = 0;
						cvy = 0;
						statusMe = 4;
						cf = 7;
					}
					if (me)
					{
						break;
					}
					cp3++;
					if (cp3 > 10)
					{
						if ((T174.M1957(cx, cy + 1) & 2) != 2)
						{
							cy += 5;
						}
						else
						{
							cf = 0;
						}
					}
					if (cp3 > 50)
					{
						cp3 = 0;
						currentMovePoint = null;
					}
					break;
				case 9:
					M137();
					break;
				case 10:
					M154();
					break;
				case 12:
					M136();
					break;
				case 13:
					M135();
					break;
				case 14:
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
					break;
				case 16:
					M134();
					break;
				}
				if (isInjure > 0)
				{
					cf = 23;
					isInjure--;
				}
				if (wdx != 0 || wdy != 0)
				{
					M220(wdx, wdy);
					wdx = 0;
					wdy = 0;
				}
				if (moveFast != null)
				{
					if (moveFast[0] == 0)
					{
						moveFast[0]++;
						T143.M1574(60, this, 1);
					}
					else if (moveFast[0] < 10)
					{
						moveFast[0]++;
					}
					else
					{
						cx = moveFast[1];
						cy = moveFast[2];
						moveFast = null;
						T143.M1574(60, this, 1);
						if (me)
						{
							if ((T174.M1957(cx, cy) & 2) != 2)
							{
								statusMe = 4;
								M113().M177(T54.sks[38], 1);
							}
							else
							{
								T146.M1594().M1640();
								M113().M177(T54.sks[38], 0);
							}
						}
					}
				}
				if (statusMe != 10)
				{
					fy = 0;
				}
				if (isCharge)
				{
					cf = 17;
					if (T51.gameTick % 4 == 0)
					{
						T143.M1571(1, cx, cy + T51.transY, 1);
					}
					if (me)
					{
						long num5 = T110.M1054();
						if (num5 - last >= 1000L)
						{
							T137.M1513("%= " + myskill.damage);
							last = num5;
							cHP += cHPFull * myskill.damage / 100;
							cMP += cMPFull * myskill.damage / 100;
							if (cHP < cHPFull)
							{
								T54.M643("+" + cHPFull * myskill.damage / 100 + " " + mResources.HP, cx, cy - ch - 20, 0, -1, T98.HP);
							}
							if (cMP < cMPFull)
							{
								T54.M643("+" + cMPFull * myskill.damage / 100 + " " + mResources.KI, cx, cy - ch - 20, 0, -2, T98.MP);
							}
							T146.M1594().M1612(2);
						}
					}
				}
				if (isFlyUp)
				{
					if (me)
					{
						isLockKey = true;
						statusMe = 3;
						cvy = -8;
						if (cy <= T174.pxh - 240)
						{
							isFlyUp = false;
							isLockKey = false;
							statusMe = 4;
						}
					}
					else
					{
						statusMe = 3;
						cvy = -8;
						if (cy <= T174.pxh - 240)
						{
							cvy = 0;
							isFlyUp = false;
							cvy = 0;
							statusMe = 1;
						}
					}
				}
				M156();
				M250();
				M252();
				M255();
			}
			else
			{
				if (charHold != null && (charHold.statusMe == 14 || charHold.statusMe == 5))
				{
					M233();
				}
				if (mobHold != null && mobHold.status == 1)
				{
					M233();
				}
				if (me && statusMe == 2 && currentMovePoint != null)
				{
					holder = false;
					charHold = null;
					mobHold = null;
				}
				if (T174.M1958(cx, cy, 2))
				{
					cf = 16;
				}
				else
				{
					cf = 31;
				}
			}
		}
	}

	private void M126()
	{
		if (effPaints != null)
		{
			for (int i = 0; i < effPaints.Length; i++)
			{
				if (effPaints[i] == null)
				{
					continue;
				}
				if (effPaints[i].eMob != null)
				{
					if (!effPaints[i].isFly)
					{
						effPaints[i].eMob.M984();
						effPaints[i].eMob.injureBy = this;
						if (me)
						{
							effPaints[i].eMob.hpInjure = M113().cDamFull / 2 - M113().cDamFull * T122.M1184(11) / 100;
						}
						int num = effPaints[i].eMob.h >> 1;
						if (effPaints[i].eMob.M974())
						{
							num = effPaints[i].eMob.getY() + 20;
						}
						T54.M646(effPaints[i].eMob.x, effPaints[i].eMob.y - num, cdir);
						effPaints[i].isFly = true;
					}
				}
				else if (effPaints[i].eChar != null && !effPaints[i].isFly)
				{
					if (effPaints[i].eChar.charID >= 0)
					{
						effPaints[i].eChar.M219();
					}
					T54.M646(effPaints[i].eChar.cx, effPaints[i].eChar.cy - (effPaints[i].eChar.ch >> 1), cdir);
					effPaints[i].isFly = true;
				}
				effPaints[i].index++;
				if (effPaints[i].index >= effPaints[i].effCharPaint.arrEfInfo.Length)
				{
					effPaints[i] = null;
				}
			}
		}
		if (indexEff >= 0 && eff != null && T51.gameTick % 2 == 0)
		{
			indexEff++;
			if (indexEff >= eff.arrEfInfo.Length)
			{
				indexEff = -1;
				eff = null;
			}
		}
		if (indexEffTask >= 0 && effTask != null && T51.gameTick % 2 == 0)
		{
			indexEffTask++;
			if (indexEffTask >= effTask.arrEfInfo.Length)
			{
				indexEffTask = -1;
				effTask = null;
			}
		}
	}

	private void M127()
	{
		if (endMovePointCommand != null)
		{
			T22 t = endMovePointCommand;
			endMovePointCommand = null;
			t.M294();
		}
	}

	private void M128()
	{
		if (T51.gameTick % 20 != 0 || charID < 0)
		{
			return;
		}
		paintName = true;
		for (int i = 0; i < T54.vCharInMap.M1113(); i++)
		{
			T13 t = null;
			try
			{
				t = (T13)T54.vCharInMap.M1114(i);
			}
			catch (Exception)
			{
			}
			if (t != null && !t.Equals(this) && ((t.cy == cy && T137.M1529(t.cx - cx) < 35) || (cy - t.cy < 32 && cy - t.cy > 0 && T137.M1529(t.cx - cx) < 24)))
			{
				paintName = false;
			}
		}
		for (int j = 0; j < T54.vNpc.M1113(); j++)
		{
			T123 t2 = null;
			try
			{
				t2 = (T123)T54.vNpc.M1114(j);
			}
			catch (Exception)
			{
			}
			if (t2 != null && t2.cy == cy && T137.M1529(t2.cx - cx) < 24)
			{
				paintName = false;
			}
		}
	}

	private void M129()
	{
		if (tMobMeBorn != 0)
		{
			tMobMeBorn--;
		}
		if (tMobMeBorn == 0)
		{
			mobMe.xFirst = ((cdir != 1) ? (cx + 30) : (cx - 30));
			mobMe.yFirst = cy - 60;
			int num = mobMe.xFirst - mobMe.x;
			int num2 = mobMe.yFirst - mobMe.y;
			mobMe.x += num / 4;
			mobMe.y += num2 / 4;
			mobMe.dir = cdir;
		}
	}

	private void M130()
	{
		if (statusMe == 14 || statusMe == 5)
		{
			return;
		}
		if (skillPaint != null && ((charFocus != null && M225(charFocus) && charFocus.statusMe == 14) || (mobFocus != null && mobFocus.status == 0)))
		{
			if (!me)
			{
				if ((T174.M1957(cx, cy) & 2) == 2)
				{
					statusMe = 1;
				}
				else
				{
					statusMe = 6;
				}
				cp3 = 0;
			}
			indexSkill = 0;
			skillPaint = null;
			skillPaintRandomPaint = null;
			eff0 = (eff1 = (eff2 = null));
			i2 = 0;
			i1 = 0;
			i0 = 0;
			mobFocus = null;
			charFocus = null;
			effPaints = null;
			currentMovePoint = null;
			arr = null;
			if ((T174.M1957(cx, cy) & 2) != 2)
			{
				delayFall = 5;
			}
		}
		if (skillPaint != null && arr == null && M178() != null && indexSkill >= M178().Length)
		{
			if (!me)
			{
				if ((T174.M1957(cx, cy) & 2) == 2)
				{
					statusMe = 1;
				}
				else
				{
					statusMe = 6;
				}
				cp3 = 0;
			}
			indexSkill = 0;
			T137.M1513("remove 2");
			skillPaint = null;
			skillPaintRandomPaint = null;
			eff0 = (eff1 = (eff2 = null));
			i2 = 0;
			i1 = 0;
			i0 = 0;
			arr = null;
			if ((T174.M1957(cx, cy) & 2) != 2)
			{
				delayFall = 5;
			}
		}
		T150[] array = M178();
		if (array == null || indexSkill < 0 || indexSkill > array.Length - 1)
		{
			return;
		}
		if (array[indexSkill].effS0Id != 0)
		{
			eff0 = T54.efs[array[indexSkill].effS0Id - 1];
			dy0 = 0;
			dx0 = 0;
			i0 = 0;
		}
		if (array[indexSkill].effS1Id != 0)
		{
			eff1 = T54.efs[array[indexSkill].effS1Id - 1];
			dy1 = 0;
			dx1 = 0;
			i1 = 0;
		}
		if (array[indexSkill].effS2Id != 0)
		{
			eff2 = T54.efs[array[indexSkill].effS2Id - 1];
			dy2 = 0;
			dx2 = 0;
			i2 = 0;
		}
		T150[] array2 = array;
		int num = indexSkill;
		if (array2 != null && array2[num] != null && num >= 0 && num <= array2.Length - 1 && array2[num].arrowId != 0)
		{
			int arrowId = array2[num].arrowId;
			if (arrowId >= 100)
			{
				T62 t2;
				if (mobFocus == null)
				{
					T62 t = charFocus;
					t2 = t;
				}
				else
				{
					T62 t3 = mobFocus;
					t2 = t3;
				}
				T62 t4 = t2;
				if (t4 != null)
				{
					int num2;
					if (T137.M1529(t4.getX() - cx) > 4 * T137.M1529(t4.getY() - cy))
					{
						num2 = 0;
					}
					else
					{
						num2 = ((t4.getY() >= cy) ? 3 : (-3));
						if (t4 is T202 && ((T202)t4).haftBody)
						{
							num2 = -20;
						}
					}
					dart = new T130(this, arrowId - 100, skillPaintRandomPaint, cx + (array2[num].adx - 10) * cdir, cy + array2[num].ady + num2);
					if (myskill != null)
					{
						if (myskill.template.id == 1)
						{
							T160.M1826().M1846();
						}
						else if (myskill.template.id == 3)
						{
							T160.M1826().M1847();
						}
						else if (myskill.template.id == 5)
						{
							T160.M1826().M1849();
						}
						else if (myskill.template.id == 11)
						{
							T160.M1826().M1848();
						}
					}
				}
				else if (isFlyAndCharge || isUseSkillAfterCharge)
				{
					M175();
				}
			}
			else
			{
				T137.M1513("g");
				arr = new T5(this, T54.arrs[arrowId - 1]);
				arr.life = 10;
				arr.ax = cx + array2[num].adx;
				arr.ay = cy + array2[num].ady;
			}
		}
		if ((mobFocus != null || (!me && charFocus != null) || (me && charFocus != null && (M225(charFocus) || M170()) && arr == null && dart == null)) && indexSkill == array.Length - 1)
		{
			M179();
			if (me && myskill.template.M1776())
			{
				M131();
			}
		}
		if (me)
		{
			return;
		}
		T62 t5 = null;
		if (mobFocus != null)
		{
			t5 = mobFocus;
		}
		else if (charFocus != null)
		{
			t5 = charFocus;
		}
		if (t5 == null)
		{
			return;
		}
		if (T137.M1529(t5.getX() - cx) < 10)
		{
			if (t5.getX() > cx)
			{
				cx -= 10;
			}
			else
			{
				cx += 10;
			}
		}
		if (t5.getX() > cx)
		{
			cdir = 1;
		}
		else
		{
			cdir = -1;
		}
	}

	public void M131()
	{
	}

	public void M132(int x, int y)
	{
		T66.M753();
		currentMovePoint = null;
		if (cy - y == 0)
		{
			cx = x;
			ischangingMap = false;
			isLockKey = false;
			return;
		}
		statusMe = 16;
		cp2 = x;
		cp3 = y;
		cp1 = 0;
		M113().cxSend = x;
		M113().cySend = y;
	}

	private void M133()
	{
		isFreez = false;
		if (isCharge)
		{
			isCharge = false;
			T160.M1826().M1867();
			T146.M1594().M1612(3);
		}
		cp1++;
		cx += (cp2 - cx) / 4;
		if (cp1 > 7)
		{
			cy += (cp3 - cy) / 4;
		}
		else
		{
			cy += cp1 - 10;
		}
		if (T137.M1529(cp2 - cx) < 4 && T137.M1529(cp3 - cy) < 10)
		{
			cx = cp2;
			cy = cp3;
			statusMe = 14;
			if (me)
			{
				T54.M559().M574();
				T146.M1594().M1640();
			}
		}
		cf = 23;
	}

	private void M134()
	{
		T66.M753();
		T51.M517();
		currentMovePoint = null;
		cp1++;
		cx += (cp2 - cx) / 4;
		if (cp1 > 7)
		{
			cy += (cp3 - cy) / 4;
		}
		else
		{
			cy += cp1 - 10;
		}
		if (T137.M1529(cp2 - cx) < 4 && T137.M1529(cp3 - cy) < 10)
		{
			cx = cp2;
			cy = cp3;
			statusMe = 1;
			cp3 = 0;
			ischangingMap = false;
			T146.M1594().M1640();
		}
		cf = 23;
	}

	public void M135()
	{
	}

	public void M136()
	{
		ty = 0;
		cp1++;
		if (cdir == 1)
		{
			if ((T174.M1957(cx + chw, cy - chh) & 4) == 4)
			{
				cvx = 0;
			}
		}
		else if ((T174.M1957(cx - chw, cy - chh) & 8) == 8)
		{
			cvx = 0;
		}
		if (cy > ch && T174.M1958(cx, cy - ch + 24, 8192))
		{
			if (!T174.M1958(cx, cy, 2))
			{
				statusMe = 4;
				cp1 = 0;
				cp2 = 0;
				cvy = 1;
			}
			else
			{
				cy = T174.M1962(cy);
			}
		}
		cx += cvx;
		cy += cvy;
		if (cy < 0)
		{
			cvy = 0;
			cy = 0;
		}
		if (cvy == 0)
		{
			if ((T174.M1957(cx, cy) & 2) != 2)
			{
				statusMe = 4;
				cvx = (cspeed >> 1) * cdir;
				cp2 = 0;
				cp1 = 0;
			}
		}
		else if (cvy < 0)
		{
			cvy++;
			if (cvy == 0)
			{
				cvy = 1;
			}
		}
		else
		{
			if (cvy < 20 && cp1 % 5 == 0)
			{
				cvy++;
			}
			if (cvy > 3)
			{
				cvy = 3;
			}
			if ((T174.M1957(cx, cy + 3) & 2) == 2 && cy <= T174.M1963(cy + 3))
			{
				cvy = 0;
				cvx = 0;
				cy = T174.M1963(cy + 3);
			}
		}
		if (cvx > 0)
		{
			cvx--;
		}
		else if (cvx < 0)
		{
			cvx++;
		}
	}

	public void M137()
	{
		isFreez = false;
		if (isCharge)
		{
			isCharge = false;
			T160.M1826().M1867();
			T146.M1594().M1612(3);
		}
		cx += cvx * cdir;
		cy += cvyJump;
		cvyJump++;
		if (cp1 == 0)
		{
			cf = 7;
		}
		else
		{
			cf = 23;
		}
		if (cvyJump == -3)
		{
			cf = 8;
		}
		else if (cvyJump == -2)
		{
			cf = 9;
		}
		else if (cvyJump == -1)
		{
			cf = 10;
		}
		else if (cvyJump == 0)
		{
			cf = 11;
		}
		if (cvyJump == 0)
		{
			statusMe = 6;
			cp3 = 0;
			((T107)vMovePoints.M1122()).status = 4;
			isJump = true;
			cp1 = 0;
			cvy = 1;
		}
	}

	public int M138(int size, int dx, int dy)
	{
		if (dy > 0 && !T174.M1958(cx, cy, 2))
		{
			if (dx - dy <= 10)
			{
				return 5;
			}
			if (dx - dy <= 30)
			{
				return 6;
			}
			if (dx - dy <= 50)
			{
				return 7;
			}
			if (dx - dy <= 70)
			{
				return 8;
			}
		}
		if (dx <= 30)
		{
			return 4;
		}
		if (dx <= 160)
		{
			return 5;
		}
		if (dx <= 270)
		{
			return 6;
		}
		if (dx <= 320)
		{
			return 7;
		}
		return 8;
	}

	public void M139()
	{
		isHide = true;
		T31.M376(new T32(107, cx, cy + 25, 3, 15, 1));
	}

	public void M140()
	{
		isHide = false;
		T31.M376(new T32(107, cx, cy + 25, 3, 10, 1));
	}

	public int M141(int size, int dx, int dy)
	{
		if (dy <= 10)
		{
			return 5;
		}
		if (dy <= 20)
		{
			return 6;
		}
		if (dy <= 30)
		{
			return 7;
		}
		if (dy <= 40)
		{
			return 8;
		}
		if (dy <= 50)
		{
			return 9;
		}
		return 10;
	}

	public int M142(int xFirst, int yFirst, int xEnd, int yEnd)
	{
		int num = xEnd - xFirst;
		int num2 = yEnd - yFirst;
		if (num == 0 && num2 == 0)
		{
			return 1;
		}
		if (num2 == 0 && yFirst % 24 == 0 && T174.M1958(xFirst, yFirst, 2))
		{
			return 2;
		}
		if (num2 > 0 && (yFirst % 24 != 0 || !T174.M1958(xFirst, yFirst, 2)))
		{
			return 4;
		}
		cvy = -10;
		cp1 = 0;
		cdir = ((num > 0) ? 1 : (-1));
		if (num <= 5)
		{
			cvx = 0;
		}
		else if (num <= 10)
		{
			cvx = 3;
		}
		else
		{
			cvx = 5;
		}
		return 9;
	}

	public void M143()
	{
		int num = ((T107)vMovePoints.M1122()).xEnd - cx;
		cvyJump = -10;
		cp1 = 0;
		cdir = ((num > 0) ? 1 : (-1));
		if (num <= 6)
		{
			cvx = 0;
		}
		else if (num <= 20)
		{
			cvx = 3;
		}
		else
		{
			cvx = 5;
		}
	}

	public void M144()
	{
		isSoundJump = false;
		isAttack = false;
		isAttFly = false;
		cvx = 0;
		cvy = 0;
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
		M214();
		if (!me)
		{
			cp3++;
			if (cp3 > 50)
			{
				cp3 = 0;
				currentMovePoint = null;
			}
		}
		M145();
		if (!me || T54.vCharInMap.M1113() == 0 || T174.mapID != 50)
		{
			return;
		}
		T13 t = (T13)T54.vCharInMap.M1114(0);
		if (!t.changePos)
		{
			if (t.statusMe != 2)
			{
				t.M202(cx - 45, cy, 0);
			}
			t.lastUpdateTime = T110.M1054();
			if (T137.M1529(cx - 45 - t.cx) <= 10)
			{
				t.changePos = true;
			}
		}
		else
		{
			if (t.statusMe != 2)
			{
				t.M202(cx + 45, cy, 0);
			}
			t.lastUpdateTime = T110.M1054();
			if (T137.M1529(cx + 45 - t.cx) <= 10)
			{
				t.changePos = false;
			}
		}
		if (T51.gameTick % 100 == 0)
		{
			t.M111("Cắc cùm cum");
		}
	}

	public void M145()
	{
		if (T51.panel.isShow || isCopy || isFusion || isSetPos || isPet || isMiniPet || isMonkey == 1)
		{
			return;
		}
		if (me)
		{
			if (isPaintAura && idAuraEff > -1)
			{
				return;
			}
		}
		else if (idAuraEff > -1)
		{
			return;
		}
		ty++;
		if (clevel >= 14)
		{
			return;
		}
		if (clevel >= 9 && !T51.lowGraphic && (ty == 40 || ty == 50))
		{
			T51.M442().M506(-1, cx - -8, cy);
			T51.M442().M506(1, cx - 8, cy);
			M230(1);
		}
		if (ty <= 50 || clevel < 9)
		{
			return;
		}
		if (cgender == 0)
		{
			if (T51.gameTick % 25 == 0)
			{
				T143.M1574(114, this, 1);
			}
			if (clevel >= 13 && T51.gameTick % 4 == 0)
			{
				T143.M1574(132, this, 1);
			}
		}
		if (cgender == 1)
		{
			if (T51.gameTick % 4 == 0)
			{
				T143.M1574(132, this, 1);
			}
			if (clevel >= 13 && T51.gameTick % 7 == 0)
			{
				T143.M1574(131, this, 1);
			}
		}
		if (cgender == 2)
		{
			if (T51.gameTick % 7 == 0)
			{
				T143.M1574(131, this, 1);
			}
			if (clevel >= 13 && T51.gameTick % 25 == 0)
			{
				T143.M1574(114, this, 1);
			}
		}
	}

	public float M146()
	{
		if (me)
		{
			return 0.1f;
		}
		int num = T137.M1529(myChar.cx - cx);
		if (num >= 0 && num <= 50)
		{
			return 0.1f;
		}
		return 0.05f;
	}

	public void M147()
	{
		int num = ((isMonkey != 1 || me) ? 1 : 2);
		if (cx >= T54.cmx && cx <= T54.cmx + T51.w)
		{
			if (isMonkey == 0)
			{
				T160.M1826().M1851(M146());
			}
			else
			{
				T160.M1826().M1852(M146());
			}
		}
		ty = 0;
		isFreez = false;
		if (isCharge)
		{
			isCharge = false;
			T160.M1826().M1867();
			T146.M1594().M1612(3);
		}
		int num2 = 0;
		if (!me && currentMovePoint != null)
		{
			num2 = M149(cx - currentMovePoint.xEnd);
		}
		cp1++;
		if (cp1 >= 10)
		{
			cp1 = 0;
			cBonusSpeed = 0;
		}
		cf = (cp1 >> 1) + 2;
		if ((T174.M1957(cx, cy - 1) & 0x40) == 64)
		{
			cx += cvx * num >> 1;
		}
		else
		{
			cx += cvx * num;
		}
		if (cdir == 1)
		{
			if (T174.M1958(cx + chw, cy - chh, 4))
			{
				if (me)
				{
					cvx = 0;
					cx = T174.M1963(cx + chw) - chw;
				}
				else
				{
					M148();
				}
			}
		}
		else if (T174.M1958(cx - chw - 1, cy - chh, 8))
		{
			if (me)
			{
				cvx = 0;
				cx = T174.M1963(cx - chw - 1) + T174.size + chw;
			}
			else
			{
				M148();
			}
		}
		if (me)
		{
			if (cvx > 0)
			{
				cvx--;
			}
			else if (cvx < 0)
			{
				cvx++;
			}
			else
			{
				if (cx - cxSend != 0 && me)
				{
					T146.M1594().M1640();
				}
				statusMe = 1;
				cBonusSpeed = 0;
			}
		}
		if ((T174.M1957(cx, cy) & 2) != 2)
		{
			if (me)
			{
				if (cx - cxSend != 0 || cy - cySend != 0)
				{
					T146.M1594().M1640();
				}
				cf = 7;
				statusMe = 4;
				delayFall = 0;
				cvx = 3 * cdir;
				cp2 = 0;
			}
			else
			{
				M148();
			}
		}
		if (!me && currentMovePoint != null && M149(cx - currentMovePoint.xEnd) > num2)
		{
			M148();
		}
		T51.M442().M506(cdir, cx - (cdir << 3), cy);
		M214();
		M230(2);
	}

	private void M148()
	{
		statusMe = 6;
		cp3 = 0;
		cvx = 0;
		cvy = 0;
		cp2 = 0;
		cp1 = 0;
	}

	public static int M149(int i)
	{
		if (i > 0)
		{
			return i;
		}
		return -i;
	}

	public void M150()
	{
		M161();
		ty = 0;
		isFreez = false;
		if (isCharge)
		{
			isCharge = false;
			T160.M1826().M1867();
			T146.M1594().M1612(3);
		}
		M230(3);
		cx += cvx;
		cy += cvy;
		if (cy < 0)
		{
			cy = 0;
			cvy = -1;
		}
		cvy++;
		if (cvy > 0)
		{
			cvy = 0;
		}
		if (!me && currentMovePoint != null)
		{
			int num = currentMovePoint.xEnd - cx;
			if (num > 0)
			{
				if (cvx > num)
				{
					cvx = num;
				}
				if (cvx < 0)
				{
					cvx = num;
				}
			}
			else if (num < 0)
			{
				if (cvx < num)
				{
					cvx = num;
				}
				if (cvx > 0)
				{
					cvx = num;
				}
			}
			else
			{
				cvx = num;
			}
		}
		if (cdir == 1)
		{
			if ((T174.M1957(cx + chw, cy - 1) & 4) == 4 && cx <= T174.M1963(cx + chw) + 12)
			{
				cx = T174.M1963(cx + chw) - chw;
				cvx = 0;
			}
		}
		else if ((T174.M1957(cx - chw, cy - 1) & 8) == 8 && cx >= T174.M1963(cx - chw) + 12)
		{
			cx = T174.M1963(cx + 24 - chw) + chw;
			cvx = 0;
		}
		if (cvy == 0)
		{
			if (!isAttFly)
			{
				if (me)
				{
					M152();
				}
				else
				{
					M148();
				}
			}
			else
			{
				M152();
			}
		}
		if (me && !ischangingMap && M122())
		{
			T146.M1594().M1640();
			if (T174.M1933())
			{
				ischangingMap = true;
				T146.M1594().M1710();
			}
			else
			{
				T146.M1594().M1636();
			}
			isLockKey = true;
			ischangingMap = true;
			T51.M484();
			T51.M483();
			T66.M749();
			return;
		}
		if (statusMe != 16 && (T174.M1958(cx, cy - ch + 24, 8192) || cy < 0))
		{
			statusMe = 4;
			cp1 = 0;
			cp2 = 0;
			cvy = 1;
			delayFall = 0;
			if (cy < 0)
			{
				cy = 0;
			}
			cy = T174.M1962(cy + 25);
			T51.M484();
		}
		if (cp3 < 0)
		{
			cp3++;
		}
		cf = 7;
		if (!me && currentMovePoint != null && cy < currentMovePoint.yEnd)
		{
			M148();
		}
	}

	public bool M151(int x1, int xw1, int xmob, int y1, int yh1, int ymob)
	{
		if (xmob <= xw1 && xmob >= x1 && ymob <= y1)
		{
			return ymob >= yh1;
		}
		return false;
	}

	public void M152()
	{
		cyStartFall = cy;
		cp1 = 0;
		cp2 = 0;
		statusMe = 10;
		cvx = cdir << 2;
		cvy = 0;
		cy = T174.M1962(cy) + 12;
		if (me && (cx - cxSend != 0 || cy - cySend != 0) && (T137.M1529(M113().cx - M113().cxSend) > 96 || T137.M1529(M113().cy - M113().cySend) > 24))
		{
			T146.M1594().M1640();
		}
	}

	public void M153()
	{
		if (holder)
		{
			return;
		}
		ty = 0;
		if (cy + 4 >= T174.pxh)
		{
			statusMe = 1;
			if (me)
			{
				T160.M1826().M1853();
			}
			cvy = 0;
			cvx = 0;
			cp3 = 0;
			return;
		}
		if (cy % 24 == 0 && (T174.M1957(cx, cy) & 2) == 2)
		{
			delayFall = 0;
			if (me)
			{
				if (cy - cySend > 0)
				{
					T146.M1594().M1640();
				}
				else if (cx - cxSend != 0 || cy - cySend < 0)
				{
					T146.M1594().M1640();
				}
				cvy = 0;
				cvx = 0;
				cp2 = 0;
				cp1 = 0;
				statusMe = 1;
				cp3 = 0;
				return;
			}
			M148();
			cf = 0;
			T51.M442().M506(-1, cx - -8, cy);
			T51.M442().M506(1, cx - 8, cy);
			M230(1);
		}
		if (delayFall > 0)
		{
			delayFall--;
			if (delayFall % 10 > 5)
			{
				cy++;
			}
			else
			{
				cy--;
			}
			return;
		}
		if (cvy < -4)
		{
			cf = 7;
		}
		else
		{
			cf = 12;
		}
		cx += cvx;
		if (!me && currentMovePoint != null)
		{
			int num = currentMovePoint.xEnd - cx;
			if (num > 0)
			{
				if (cvx > num)
				{
					cvx = num;
				}
				if (cvx < 0)
				{
					cvx = num;
				}
			}
			else if (num < 0)
			{
				if (cvx < num)
				{
					cvx = num;
				}
				if (cvx > 0)
				{
					cvx = num;
				}
			}
			else
			{
				cvx = num;
			}
		}
		cvy++;
		if (cvy > 8)
		{
			cvy = 8;
		}
		if (skillPaintRandomPaint == null)
		{
			cy += cvy;
		}
		if (cdir == 1)
		{
			if ((T174.M1957(cx + chw, cy - 1) & 4) == 4 && cx <= T174.M1963(cx + chw) + 12)
			{
				cx = T174.M1963(cx + chw) - chw;
				cvx = 0;
			}
		}
		else if ((T174.M1957(cx - chw, cy - 1) & 8) == 8 && cx >= T174.M1963(cx - chw) + 12)
		{
			cx = T174.M1963(cx + 24 - chw) + chw;
			cvx = 0;
		}
		if (cvy > 3 && (cyStartFall == 0 || cyStartFall <= T174.M1962(cy + 3)) && (T174.M1957(cx, cy + 3) & 2) == 2)
		{
			if (me)
			{
				cyStartFall = 0;
				cvy = 0;
				cvx = 0;
				cp2 = 0;
				cp1 = 0;
				cy = T174.M1963(cy + 3);
				statusMe = 1;
				if (me)
				{
					T160.M1826().M1853();
				}
				cp3 = 0;
				T51.M442().M506(-1, cx - -8, cy);
				T51.M442().M506(1, cx - 8, cy);
				M230(1);
				if (cy - cySend > 0)
				{
					if (me)
					{
						T146.M1594().M1640();
					}
				}
				else if ((cx - cxSend != 0 || cy - cySend < 0) && me)
				{
					T146.M1594().M1640();
				}
			}
			else
			{
				M148();
				cy = T174.M1963(cy + 3);
				cf = 0;
				T51.M442().M506(-1, cx - -8, cy);
				T51.M442().M506(1, cx - 8, cy);
				M230(1);
			}
			return;
		}
		cf = 12;
		if (!me)
		{
			if ((T174.M1957(cx, cy + 1) & 2) == 2)
			{
				cf = 0;
			}
			if (currentMovePoint != null && cy > currentMovePoint.yEnd)
			{
				M148();
			}
		}
	}

	public void M154()
	{
		int num = ((isMonkey != 1 || me) ? 1 : 2);
		M161();
		if (statusMe != 16 && (T174.M1958(cx, cy - ch + 24, 8192) || cy < 0))
		{
			if (cy - ch < 0)
			{
				cy = ch;
			}
			cf = 7;
			statusMe = 4;
			cvx = 0;
			cp2 = 0;
			currentMovePoint = null;
			return;
		}
		int num2 = cy;
		cp1++;
		if (cp1 >= 9)
		{
			cp1 = 0;
			if (!me)
			{
				cvy = 0;
				cvx = 0;
			}
			cBonusSpeed = 0;
		}
		cf = 8;
		if (T137.M1529(cvx) <= 4 && me)
		{
			if (currentMovePoint != null)
			{
				int num3 = M149(cx - currentMovePoint.xEnd);
				int num4 = M149(cy - currentMovePoint.yEnd);
				if (num3 > num4 * 10)
				{
					cf = 8;
				}
				else if (num3 > num4 && num3 > 48 && num4 > 32)
				{
					cf = 8;
				}
				else
				{
					cf = 7;
				}
			}
			else
			{
				if (cvy < 0)
				{
					cvy = 0;
				}
				if (cvy > 16)
				{
					cvy = 16;
				}
				cf = 7;
			}
		}
		if (!me)
		{
			if (M149(cvx) < 2)
			{
				cvx = (cdir << 1) * num;
			}
			if (cvy != 0)
			{
				cf = 7;
			}
			if (M149(cvx) <= 2)
			{
				cp2++;
				if (cp2 > 32)
				{
					statusMe = 4;
					cvx = 0;
					cvy = 0;
				}
			}
		}
		if (cdir == 1)
		{
			if (T174.M1958(cx + chw, cy - 1, 4))
			{
				cvx = 0;
				cx = T174.M1963(cx + chw) - chw;
				if (cvy == 0)
				{
					currentMovePoint = null;
				}
			}
		}
		else if (T174.M1958(cx - chw - 1, cy - 1, 8))
		{
			cvx = 0;
			cx = T174.M1963(cx - chw - 1) + T174.size + chw;
			if (cvy == 0)
			{
				currentMovePoint = null;
			}
		}
		cx += cvx * num;
		cy += cvy * num;
		if (!isMount && num2 - cy == 0)
		{
			ty++;
			wt++;
			fy += ((!wy) ? 1 : (-1));
			if (wt == 10)
			{
				wt = 0;
				wy = !wy;
			}
			if (ty > 20)
			{
				delayFall = 10;
				if (T51.gameTick % 3 == 0)
				{
					T143.M1572(111, cx + ((cdir != 1) ? 27 : (-17)), cy + fy + 13, 1, (cdir != 1) ? 2 : 0);
				}
			}
		}
		if (!me)
		{
			return;
		}
		if (cvx > 0)
		{
			cvx--;
		}
		else if (cvx < 0)
		{
			cvx++;
		}
		else if (cvy == 0)
		{
			statusMe = 4;
			M164();
			T146.M1594().M1640();
		}
		if ((T174.M1957(cx, cy + 20) & 2) == 2 || (T174.M1957(cx, cy + 40) & 2) == 2)
		{
			if (cvy == 0)
			{
				delayFall = 0;
			}
			cyStartFall = 0;
			cvy = 0;
			cvx = 0;
			cp2 = 0;
			cp1 = 0;
			statusMe = 4;
			M230(3);
		}
		if (M149(cx - cxSend) > 96 || M149(cy - cySend) > 24)
		{
			T146.M1594().M1640();
		}
	}

	public void M155(int cid, int ctrans, int cgender)
	{
		idcharMount = cid;
		transMount = ctrans;
		genderMount = cgender;
		speedMount = 30;
		if (transMount < 0)
		{
			transMount = 0;
			xMount = T54.cmx + T51.w + 50;
			dxMount = -19;
		}
		else if (transMount == 1)
		{
			transMount = 2;
			xMount = T54.cmx - 100;
			dxMount = -33;
		}
		dyMount = -17;
		yMount = cy;
		frameMount = 0;
		frameNewMount = 0;
		isMount = false;
		isEndMount = false;
	}

	public void M156()
	{
		frameMount++;
		if (frameMount > FrameMount.Length - 1)
		{
			frameMount = 0;
		}
		frameNewMount++;
		if (frameNewMount > 1000)
		{
			frameNewMount = 0;
		}
		if (isStartMount && !isMount)
		{
			yMount = cy;
			if (transMount == 0)
			{
				if (xMount - cx >= speedMount)
				{
					xMount -= speedMount;
					return;
				}
				xMount = cx;
				isMount = true;
				isEndMount = false;
			}
			else if (transMount == 2)
			{
				if (cx - xMount >= speedMount)
				{
					xMount += speedMount;
					return;
				}
				xMount = cx;
				isMount = true;
				isEndMount = false;
			}
		}
		else if (isMount)
		{
			if (statusMe == 14 || ySd - cy < 24)
			{
				M162();
			}
			if (cp1 % 15 < 5)
			{
				cf = 0;
			}
			else
			{
				cf = 1;
			}
			transMount = cdir;
			M145();
			if (transMount < 0)
			{
				transMount = 0;
				dxMount = -19;
			}
			else if (transMount == 1)
			{
				transMount = 2;
				dxMount = -31;
				if (isEventMount)
				{
					dxMount = -38;
				}
			}
			if (M178() != null)
			{
				dyMount = -15;
			}
			else
			{
				dyMount = -17;
			}
			yMount = cy;
			xMount = cx;
		}
		else if (isEndMount)
		{
			if (transMount == 0)
			{
				if (xMount > T54.cmx - 100)
				{
					xMount -= 20;
					return;
				}
				isStartMount = false;
				isMount = false;
				isEndMount = false;
			}
			else if (transMount == 2)
			{
				if (xMount < T54.cmx + T51.w + 50)
				{
					xMount += 20;
					return;
				}
				isStartMount = false;
				isMount = false;
				isEndMount = false;
			}
		}
		else if (!isStartMount || !isMount || !isEndMount)
		{
			xMount = T54.cmx - 100;
			yMount = T54.cmy - 100;
		}
	}

	public void M157()
	{
		if (T101.arrMobTemplate[50].data == null)
		{
			T101.arrMobTemplate[50].data = new T36();
			string text = "/Mob/" + 50;
			if (T116.M1110(text) != null)
			{
				T101.arrMobTemplate[50].data.M395(text + "/data");
				T101.arrMobTemplate[50].data.img = T51.M503(text + "/img.png");
			}
			else
			{
				T146.M1594().M1644(50);
			}
			T101.lastMob.M1111(50 + string.Empty);
		}
	}

	public void M158(int[] array)
	{
		t++;
		if (t > array.Length - 1)
		{
			t = 0;
		}
		fM = array[t];
	}

	public void M159(T99 g)
	{
		if (xMount <= T54.cmx || xMount >= T54.cmx + T51.w)
		{
			return;
		}
		if (me)
		{
			if (!isEndMount && !isStartMount && !isMount)
			{
				return;
			}
			if (idMount >= ID_NEW_MOUNT)
			{
				T49 t = T110.M1070(strMount + (idMount - ID_NEW_MOUNT) + "_0");
				t?.M439(frameNewMount / 2 % t.nFrame, xMount, yMount + fy, transMount, 3, g);
			}
			else
			{
				if (isSpeacialMount)
				{
					return;
				}
				if (isEventMount)
				{
					g.M940(imgEventMountWing, 0, FrameMount[frameMount] * 60, 60, 60, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
				else if (genderMount == 2)
				{
					if (!isMountVip)
					{
						g.M940(imgMount_XD, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
					}
					else
					{
						g.M940(imgMount_XD_VIP, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
					}
				}
				else if (genderMount == 1)
				{
					if (!isMountVip)
					{
						g.M940(imgMount_NM, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
					}
					else
					{
						g.M940(imgMount_NM_VIP, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
					}
				}
			}
		}
		else
		{
			if (me)
			{
				return;
			}
			if (idMount >= ID_NEW_MOUNT)
			{
				T49 t2 = T110.M1070(strMount + (idMount - ID_NEW_MOUNT) + "_0");
				t2?.M439(frameNewMount / 2 % t2.nFrame, xMount, yMount + fy, transMount, 3, g);
			}
			else
			{
				if (isSpeacialMount)
				{
					return;
				}
				if (isEventMount)
				{
					g.M940(imgEventMountWing, 0, FrameMount[frameMount] * 60, 60, 60, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
				else
				{
					if (!isMount)
					{
						return;
					}
					if (genderMount == 2)
					{
						if (!isMountVip)
						{
							g.M940(imgMount_XD, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
						}
						else
						{
							g.M940(imgMount_XD_VIP, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
						}
					}
					else if (genderMount == 1)
					{
						if (!isMountVip)
						{
							g.M940(imgMount_NM, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
						}
						else
						{
							g.M940(imgMount_NM_VIP, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
						}
					}
				}
			}
		}
	}

	public void M160(T99 g)
	{
		if (xMount <= T54.cmx || xMount >= T54.cmx + T51.w)
		{
			return;
		}
		if (me)
		{
			if (!isEndMount && !isStartMount && !isMount)
			{
				return;
			}
			if (idMount >= ID_NEW_MOUNT)
			{
				T49 t = T110.M1070(strMount + (idMount - ID_NEW_MOUNT) + "_1");
				t?.M439(frameNewMount / 2 % t.nFrame, xMount, yMount + fy, transMount, 3, g);
			}
			else if (isSpeacialMount)
			{
				M158(move);
				if (T101.arrMobTemplate[50] != null && T101.arrMobTemplate[50].data != null)
				{
					T101.arrMobTemplate[50].data.M401(g, fM, xMount + ((cdir != 1) ? 8 : (-8)), yMount + 35, (cdir != 1) ? 1 : 0, 0);
				}
				else
				{
					M157();
				}
			}
			else if (isEventMount)
			{
				g.M940(imgEventMount, 0, FrameMount[frameMount] * 60, 60, 60, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
			}
			else if (genderMount == 0)
			{
				if (!isMountVip)
				{
					g.M940(imgMount_TD, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
				else
				{
					g.M940(imgMount_TD_VIP, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
			}
			else if (genderMount == 1)
			{
				if (!isMountVip)
				{
					g.M940(imgMount_NM_1, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
				else
				{
					g.M940(imgMount_NM_1_VIP, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
			}
		}
		else
		{
			if (me)
			{
				return;
			}
			if (idMount >= ID_NEW_MOUNT)
			{
				T49 t2 = T110.M1070(strMount + (idMount - ID_NEW_MOUNT) + "_1");
				t2?.M439(frameNewMount / 2 % t2.nFrame, xMount, yMount + fy, transMount, 3, g);
				return;
			}
			if (isSpeacialMount)
			{
				M158(move);
				if (T101.arrMobTemplate[50] != null && T101.arrMobTemplate[50].data != null)
				{
					T101.arrMobTemplate[50].data.M401(g, fM, xMount + ((cdir != 1) ? 8 : (-8)), yMount + 35, (cdir != 1) ? 1 : 0, 0);
				}
				else
				{
					M157();
				}
				return;
			}
			if (isEventMount)
			{
				g.M940(imgEventMount, 0, FrameMount[frameMount] * 60, 60, 60, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
			}
			if (!isMount)
			{
				return;
			}
			if (genderMount == 0)
			{
				if (!isMountVip)
				{
					g.M940(imgMount_TD, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
				else
				{
					g.M940(imgMount_TD_VIP, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
			}
			else if (genderMount == 1)
			{
				if (!isMountVip)
				{
					g.M940(imgMount_NM_1, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
				else
				{
					g.M940(imgMount_NM_1_VIP, 0, FrameMount[frameMount] * 40, 50, 40, transMount, xMount + dxMount, yMount + dyMount + fy, 0);
				}
			}
		}
	}

	public void M161()
	{
		if (me)
		{
			isHaveMount = M163();
			if (T174.mapID == 112 || T174.mapID == 113 || T174.mapID == 51 || T174.mapID == 103)
			{
				isHaveMount = false;
			}
		}
		if (isHaveMount)
		{
			if (ySd - cy <= 20)
			{
				xChar = cx;
			}
			if (xdis < 100)
			{
				xdis = T137.M1529(xChar - cx);
			}
			if (xdis >= 70 && ySd - cy > 30 && !isStartMount && !isEndMount)
			{
				M155(charID, cdir, cgender);
				isStartMount = true;
			}
		}
	}

	public void M162()
	{
		if (ySd - cy < 24 && !isEndMount)
		{
			isStartMount = false;
			isMount = false;
			isEndMount = true;
			xdis = 0;
		}
	}

	public bool M163()
	{
		bool result = false;
		short num = -1;
		T79[] array = arrItemBody;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && (array[i].template.type == 24 || array[i].template.type == 23))
			{
				num = ((array[i].template.part < 0) ? array[i].template.id : ((short)(ID_NEW_MOUNT + array[i].template.part)));
				result = true;
				break;
			}
		}
		isMountVip = false;
		isSpeacialMount = false;
		isEventMount = false;
		idMount = -1;
		switch (num)
		{
		default:
			if (num >= ID_NEW_MOUNT)
			{
				idMount = num;
			}
			break;
		case 532:
			isSpeacialMount = true;
			break;
		case 396:
			isEventMount = true;
			break;
		case 349:
		case 350:
		case 351:
			isMountVip = true;
			break;
		}
		return result;
	}

	private void M164()
	{
		bool flag = true;
		for (int i = 0; i < 150; i += 24)
		{
			if ((T174.M1957(cx, cy + i) & 2) == 2 || cy + i > T174.tmh * T174.size - 24)
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			delayFall = 40;
		}
	}

	public void M165()
	{
		M166();
		M167();
		M168();
	}

	public void M166()
	{
		if (cgender == 0)
		{
			wp = 0;
		}
	}

	public void M167()
	{
		if (cgender == 0)
		{
			body = 57;
		}
		else if (cgender == 1)
		{
			body = 59;
		}
		else if (cgender == 2)
		{
			body = 57;
		}
	}

	public void M168()
	{
		if (cgender == 0)
		{
			leg = 58;
		}
		else if (cgender == 1)
		{
			leg = 60;
		}
		else if (cgender == 2)
		{
			leg = 58;
		}
	}

	public bool M169()
	{
		if (myskill != null)
		{
			return myskill.template.M1775();
		}
		return false;
	}

	public bool M170()
	{
		if (myskill != null)
		{
			return myskill.template.M1774();
		}
		return false;
	}

	public bool M171()
	{
		if (!isUseSkillAfterCharge && myskill != null)
		{
			if (myskill.template.id != 10)
			{
				return myskill.template.id == 11;
			}
			return true;
		}
		return false;
	}

	public void M172(T153 skillPaint, int sType)
	{
		hasSendAttack = false;
		if (stone || (me && myskill.template.id == 9 && cHP <= cHPFull / 10))
		{
			return;
		}
		if (me)
		{
			if (mobFocus == null && charFocus == null)
			{
				M175();
			}
			if (mobFocus != null && (mobFocus.status == 1 || mobFocus.status == 0))
			{
				M175();
			}
			if (charFocus != null && (charFocus.statusMe == 14 || charFocus.statusMe == 5))
			{
				M175();
			}
			if ((myskill.template.id == 23 && ((charFocus != null && charFocus.holdEffID != 0) || (mobFocus != null && mobFocus.holdEffID != 0) || holdEffID != 0)) || sleepEff || blindEff)
			{
				return;
			}
		}
		T137.M1513("skill id= " + skillPaint.id);
		if ((me && dart != null) || T174.M1936())
		{
			return;
		}
		long num = T110.M1054();
		if (me)
		{
			if (M170() && charFocus == null)
			{
				return;
			}
			if (num - myskill.lastTimeUseThisSkill < myskill.coolDown)
			{
				myskill.paintCanNotUseSkill = true;
				return;
			}
			myskill.lastTimeUseThisSkill = num;
			if (myskill.template.manaUseType == 2)
			{
				cMP = 1;
			}
			else if (myskill.template.manaUseType != 1)
			{
				cMP -= myskill.manaUse;
			}
			else
			{
				cMP -= myskill.manaUse * cMPFull / 100;
			}
			M113().cStamina--;
			T54.M559().isInjureMp = true;
			T54.M559().twMp = 0;
			if (cMP < 0)
			{
				cMP = 0;
			}
		}
		if (me)
		{
			if (myskill.template.id == 7)
			{
				T160.M1826().M1865();
			}
			if (myskill.template.id == 6)
			{
				T146.M1594().M1612(0);
				T54.M559().isUseFreez = true;
				T160.M1826().M1832();
			}
			if (myskill.template.id == 8)
			{
				if (!isCharge)
				{
					T160.M1826().M1867();
					T146.M1594().M1612(1);
					isCharge = true;
					last = (cur = T110.M1054());
				}
				else
				{
					T146.M1594().M1612(3);
					isCharge = false;
					T160.M1826().M1867();
				}
			}
			if (myskill.template.id == 13)
			{
				if (isMonkey != 0)
				{
					T54.M559().auto = 0;
				}
				else if (!isCreateDark)
				{
					T160.M1826().M1835();
					T146.M1594().M1612(6);
					chargeCount = 0;
					isWaitMonkey = true;
				}
				return;
			}
			if (myskill.template.id == 14)
			{
				T160.M1826().M1835();
				T146.M1594().M1612(7);
				M176(isGround: true);
			}
			if (myskill.template.id == 21)
			{
				T146.M1594().M1612(10);
				return;
			}
			if (myskill.template.id == 12)
			{
				T146.M1594().M1612(8);
			}
			if (myskill.template.id == 19)
			{
				T146.M1594().M1612(9);
				return;
			}
		}
		if (isMonkey == 1 && skillPaint.id >= 35 && skillPaint.id <= 41)
		{
			skillPaint = T54.sks[106];
		}
		if (skillPaint.id >= 128 && skillPaint.id <= 134)
		{
			skillPaint = T54.sks[skillPaint.id - 65];
			if (charFocus != null)
			{
				cx = charFocus.cx;
				cy = charFocus.cy;
				currentMovePoint = null;
			}
			if (mobFocus != null)
			{
				cx = mobFocus.x;
				cy = mobFocus.y;
				currentMovePoint = null;
			}
			T143.M1571(60, cx, cy, 1);
			telePortSkill = true;
		}
		if (skillPaint.id >= 107 && skillPaint.id <= 113)
		{
			skillPaint = T54.sks[skillPaint.id - 44];
			T31.M376(new T32(23, cx, cy + ch / 2, 3, 2, 1));
		}
		M177(skillPaint, sType);
	}

	public void M173()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T54.M559().auto = 0;
		M113().M172(T54.sks[M113().myskill.skillId], (!T174.M1958(M113().cx, M113().cy, 2)) ? 1 : 0);
	}

	public void M174()
	{
		if (me && (isFreez || isUsePlane))
		{
			T54.M559().auto = 0;
			return;
		}
		long num = T110.M1054();
		if (me && num - myskill.lastTimeUseThisSkill < myskill.coolDown)
		{
			myskill.paintCanNotUseSkill = true;
			return;
		}
		if (myskill.template.id == 10)
		{
			M176(isGround: false);
		}
		if (myskill.template.id == 11)
		{
			M176(isGround: true);
		}
	}

	public void M175()
	{
		isFlyAndCharge = false;
		isStandAndCharge = false;
		isUseSkillAfterCharge = false;
		isCreateDark = false;
		if (me && statusMe != 14 && statusMe != 5)
		{
			isLockMove = false;
		}
		T54.M559().auto = 0;
	}

	public void M176(bool isGround)
	{
		if (isCreateDark)
		{
			return;
		}
		T54.M559().auto = 0;
		if (isGround)
		{
			if (isStandAndCharge)
			{
				return;
			}
			chargeCount = 0;
			seconds = 50000;
			posDisY = 0;
			last = T110.M1054();
			if (me)
			{
				isLockMove = true;
				if (cgender == 1)
				{
					T146.M1594().M1612(4);
				}
			}
			if (cgender == 1)
			{
				T160.M1826().M1834();
			}
			isStandAndCharge = true;
		}
		else if (!isFlyAndCharge)
		{
			if (me)
			{
				T54.M559().auto = 0;
				isLockMove = true;
				T146.M1594().M1612(4);
			}
			isUseSkillAfterCharge = false;
			chargeCount = 0;
			isFlyAndCharge = true;
			posDisY = 0;
			seconds = 50000;
			isFlying = T174.M1958(cx, cy, 2);
		}
	}

	public void M177(T153 skillPaint, int sType)
	{
		this.skillPaint = skillPaint;
		T137.M1513("set auto skill " + ((skillPaint == null) ? "null" : "!null"));
		if (skillPaint.id >= 0 && skillPaint.id <= 6)
		{
			int num = T137.M1522(0, skillPaint.id + 4) - 1;
			if (num < 0)
			{
				num = 0;
			}
			if (num > 6)
			{
				num = 6;
			}
			skillPaintRandomPaint = T54.sks[num];
		}
		else if (skillPaint.id >= 14 && skillPaint.id <= 20)
		{
			int num2 = T137.M1522(0, skillPaint.id - 14 + 4) - 1;
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 > 6)
			{
				num2 = 6;
			}
			skillPaintRandomPaint = T54.sks[num2 + 14];
		}
		else if (skillPaint.id >= 28 && skillPaint.id <= 34)
		{
			int num3 = T137.M1522(0, ((isMonkey != 1) ? skillPaint.id : 105) - ((isMonkey != 1) ? 28 : 105) + 4) - 1;
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (num3 > 6)
			{
				num3 = 6;
			}
			if (isMonkey == 1)
			{
				num3 = 0;
			}
			skillPaintRandomPaint = T54.sks[num3 + ((isMonkey != 1) ? 28 : 105)];
		}
		else if (skillPaint.id >= 63 && skillPaint.id <= 69)
		{
			int num4 = T137.M1522(0, skillPaint.id - 63 + 4) - 1;
			if (num4 < 0)
			{
				num4 = 0;
			}
			if (num4 > 6)
			{
				num4 = 6;
			}
			skillPaintRandomPaint = T54.sks[num4 + 63];
		}
		else if (skillPaint.id >= 107 && skillPaint.id <= 109)
		{
			int num5 = T137.M1522(0, skillPaint.id - 107 + 4) - 1;
			if (num5 < 0)
			{
				num5 = 0;
			}
			if (num5 > 6)
			{
				num5 = 6;
			}
			skillPaintRandomPaint = T54.sks[num5 + 107];
		}
		else
		{
			skillPaintRandomPaint = skillPaint;
		}
		this.sType = sType;
		indexSkill = 0;
		dy2 = 0;
		dy1 = 0;
		dy0 = 0;
		dx2 = 0;
		dx1 = 0;
		dx0 = 0;
		i2 = 0;
		i1 = 0;
		i0 = 0;
		eff0 = null;
		eff1 = null;
		eff2 = null;
		cvy = 0;
	}

	public T150[] M178()
	{
		if (skillPaint == null)
		{
			return null;
		}
		if (skillPaintRandomPaint == null)
		{
			return null;
		}
		if (sType == 0)
		{
			return skillPaintRandomPaint.skillStand;
		}
		return skillPaintRandomPaint.skillfly;
	}

	public void M179()
	{
		if (me)
		{
			T153 t = skillPaintRandomPaint;
			if (dart != null)
			{
				t = dart.skillPaint;
			}
			if (t == null)
			{
				return;
			}
			T117 t2 = new T117();
			T117 t3 = new T117();
			if (charFocus != null)
			{
				t3.M1111(charFocus);
			}
			else if (mobFocus != null)
			{
				t2.M1111(mobFocus);
			}
			effPaints = new T40[t2.M1113() + t3.M1113()];
			for (int i = 0; i < t2.M1113(); i++)
			{
				effPaints[i] = new T40();
				effPaints[i].effCharPaint = T54.efs[t.effectHappenOnMob - 1];
				if (!M169())
				{
					effPaints[i].eMob = (T101)t2.M1114(i);
				}
			}
			for (int j = 0; j < t3.M1113(); j++)
			{
				effPaints[j + t2.M1113()] = new T40();
				effPaints[j + t2.M1113()].effCharPaint = T54.efs[t.effectHappenOnMob - 1];
				effPaints[j + t2.M1113()].eChar = (T13)t3.M1114(j);
			}
			int type = 0;
			if (mobFocus != null)
			{
				type = 1;
			}
			else if (charFocus != null)
			{
				type = 2;
			}
			if (t2.M1113() == 0 && t3.M1113() == 0)
			{
				M175();
			}
			if (me && !M169() && !hasSendAttack)
			{
				T146.M1594().M1669(t2, t3, type);
				hasSendAttack = true;
			}
			return;
		}
		T153 t4 = skillPaintRandomPaint;
		if (dart != null)
		{
			t4 = dart.skillPaint;
		}
		if (t4 == null)
		{
			return;
		}
		if (attMobs != null)
		{
			effPaints = new T40[attMobs.Length];
			for (int k = 0; k < attMobs.Length; k++)
			{
				effPaints[k] = new T40();
				effPaints[k].effCharPaint = T54.efs[t4.effectHappenOnMob - 1];
				effPaints[k].eMob = attMobs[k];
			}
			attMobs = null;
		}
		else if (attChars != null)
		{
			effPaints = new T40[attChars.Length];
			for (int l = 0; l < attChars.Length; l++)
			{
				effPaints[l] = new T40();
				effPaints[l].effCharPaint = T54.efs[t4.effectHappenOnMob - 1];
				effPaints[l].eChar = attChars[l];
			}
			attChars = null;
		}
	}

	public bool M180()
	{
		if (cx >= T54.cmx)
		{
			return cx > T54.cmx + T54.gW;
		}
		return true;
	}

	public bool M181()
	{
		if (cy >= T54.cmy && cy <= T54.cmy + T54.gH + 30 && !M180() && !isSetPos)
		{
			return !isFusion;
		}
		return false;
	}

	public void M182(int x, int y, int life)
	{
		shadowX = x;
		shadowY = y;
		shadowLife = life;
	}

	public void M183(bool m)
	{
		isMabuHold = m;
	}

	public virtual void paint(T99 g)
	{
		if (isHide)
		{
			return;
		}
		if (isMabuHold)
		{
			if (cmtoChar)
			{
				T54.cmtoX = cx - T54.gW2;
				T54.cmtoY = cy - T54.gH23;
				if (!T51.isTouchControl)
				{
					T54.cmtoX += T54.gW6 * cdir;
				}
			}
		}
		else
		{
			if (!M181() || (!me && T54.notPaint))
			{
				return;
			}
			if (petFollow != null)
			{
				petFollow.M2286(g);
			}
			M159(g);
			if ((T174.M1945() && cy >= T174.pxh - 48) || isTeleport)
			{
				return;
			}
			if (holder && T51.gameTick % 2 == 0)
			{
				g.M933(16185600);
				if (charHold != null)
				{
					g.M928(cx, cy - ch / 2, charHold.cx, charHold.cy - charHold.ch / 2);
				}
				if (mobHold != null)
				{
					g.M928(cx, cy - ch / 2, mobHold.x, mobHold.y - mobHold.h / 2);
				}
			}
			M184(g);
			M257(g);
			M248(g);
			M259(g);
			if (shadowLife > 0)
			{
				if (T51.gameTick % 2 == 0)
				{
					M199(g, shadowX, shadowY, cdir, 25, isPaintBag: true);
				}
				else if (shadowLife > 5)
				{
					M199(g, shadowX, shadowY, cdir, 7, isPaintBag: true);
				}
			}
			if (!M181() && skillPaint != null && (skillPaint.id < 70 || skillPaint.id > 76) && (skillPaint.id < 77 || skillPaint.id > 83))
			{
				if (skillPaint != null)
				{
					indexSkill = M178().Length;
					skillPaint = null;
				}
				effPaints = null;
				eff = null;
				effTask = null;
				indexEff = -1;
				indexEffTask = -1;
			}
			else if (statusMe != 15 && (moveFast == null || moveFast[0] <= 0))
			{
				M191(g);
				if (skillPaint == null || M178() == null || indexSkill >= M178().Length)
				{
					M194(g);
				}
				if (arr != null)
				{
					arr.M5(g);
				}
				if (dart != null)
				{
					dart.M1465(g);
				}
				M186(g);
				M160(g);
				M260(g);
				M185(g);
				M258(g);
				M249(g);
			}
		}
	}

	private void M184(T99 g)
	{
		if (me)
		{
			if (isPaintAura && idAuraEff > -1)
			{
				return;
			}
		}
		else if (idAuraEff > -1)
		{
			return;
		}
		if ((statusMe != 1 && statusMe != 6) || T51.panel.isShow || T110.M1054() - timeBlue <= 0L || isCopy || clevel < 16)
		{
			return;
		}
		int num = 7598;
		int num2 = 4;
		if (clevel >= 19)
		{
			num = 7676;
		}
		if (clevel >= 22)
		{
			num = 7677;
		}
		if (clevel >= 25)
		{
			num = 7678;
		}
		if (num != -1)
		{
			T211 t = T157.imgNew[num];
			if (t == null)
			{
				T157.M1784(num);
			}
			else
			{
				g.M940(y0: T51.gameTick / 4 % num2 * (T99.M959(t.img) / num2), arg0: t.img, x0: 0, w0: T99.M958(t.img), h0: T99.M959(t.img) / num2, arg5: 0, x: cx, y: cy + 2, arg8: T99.BOTTOM | T99.HCENTER);
			}
		}
	}

	private void M185(T99 g)
	{
		if (me)
		{
			if (isPaintAura && idAuraEff > -1)
			{
				return;
			}
		}
		else if (idAuraEff > -1)
		{
			return;
		}
		if (statusMe != 1 && statusMe != 6)
		{
			timeBlue = T110.M1054() + 1500L;
			IsAddDust1 = true;
			IsAddDust2 = true;
		}
		else
		{
			if (T51.panel.isShow || T110.M1054() - timeBlue <= 0L)
			{
				return;
			}
			if (isCopy)
			{
				if (T51.gameTick % 2 == 0)
				{
					tBlue++;
				}
				if (tBlue > 6)
				{
					tBlue = 0;
				}
				g.M948(T51.imgViolet[tBlue], cx, cy + 9, T99.BOTTOM | T99.HCENTER);
				return;
			}
			if (clevel >= 14 && !T51.lowGraphic)
			{
				bool flag = false;
				if (T110.M1054() - timeBlue > -1000L && IsAddDust1)
				{
					flag = true;
					IsAddDust1 = false;
				}
				if (T110.M1054() - timeBlue > -500L && IsAddDust2)
				{
					flag = true;
					IsAddDust2 = false;
				}
				if (flag)
				{
					T51.M442().M506(-1, cx - -8, cy);
					T51.M442().M506(1, cx - 8, cy);
					M230(1);
				}
			}
			if (clevel == 14)
			{
				if (T51.gameTick % 2 == 0)
				{
					tBlue++;
				}
				if (tBlue > 6)
				{
					tBlue = 0;
				}
				g.M948(T51.imgBlue[tBlue], cx, cy + 9, T99.BOTTOM | T99.HCENTER);
			}
			else if (clevel == 15)
			{
				if (T51.gameTick % 2 == 0)
				{
					tBlue++;
				}
				if (tBlue > 6)
				{
					tBlue = 0;
				}
				g.M948(T51.imgViolet[tBlue], cx, cy + 9, T99.BOTTOM | T99.HCENTER);
			}
			else
			{
				if (clevel < 16)
				{
					return;
				}
				int num = -1;
				int num2 = 4;
				if (clevel >= 16 && clevel < 22)
				{
					num = 7599;
					num2 = 4;
				}
				if (num != -1)
				{
					T211 t = T157.imgNew[num];
					if (t == null)
					{
						T157.M1784(num);
					}
					else
					{
						g.M940(y0: T51.gameTick / 4 % num2 * (T99.M959(t.img) / num2), arg0: t.img, x0: 0, w0: T99.M958(t.img), h0: T99.M959(t.img) / num2, arg5: 0, x: cx, y: cy + 2, arg8: T99.BOTTOM | T99.HCENTER);
					}
				}
			}
		}
	}

	private void M186(T99 g)
	{
		if (effPaints != null)
		{
			for (int i = 0; i < effPaints.Length; i++)
			{
				if (effPaints[i] == null)
				{
					continue;
				}
				if (effPaints[i].eMob != null)
				{
					int y = effPaints[i].eMob.y;
					if (effPaints[i].eMob is T202)
					{
						y = effPaints[i].eMob.y - 60;
					}
					if (effPaints[i].eMob is T12)
					{
						y = effPaints[i].eMob.y - 50;
					}
					if (effPaints[i].eMob is T7)
					{
						y = effPaints[i].eMob.y - 40;
					}
					T157.M1785(g, effPaints[i].M414(), effPaints[i].eMob.x, y, 0, T99.BOTTOM | T99.HCENTER);
				}
				else if (effPaints[i].eChar != null)
				{
					T157.M1785(g, effPaints[i].M414(), effPaints[i].eChar.cx, effPaints[i].eChar.cy, 0, T99.BOTTOM | T99.HCENTER);
				}
			}
		}
		if (indexEff >= 0 && eff != null)
		{
			T157.M1785(g, eff.arrEfInfo[indexEff].idImg, cx + eff.arrEfInfo[indexEff].dx, cy + eff.arrEfInfo[indexEff].dy, 0, T99.VCENTER | T99.HCENTER);
		}
		if (indexEffTask >= 0 && effTask != null)
		{
			T157.M1785(g, effTask.arrEfInfo[indexEffTask].idImg, cx + effTask.arrEfInfo[indexEffTask].dx, cy + effTask.arrEfInfo[indexEffTask].dy, 0, T99.VCENTER | T99.HCENTER);
		}
	}

	private void M187(T99 g)
	{
	}

	public void M188(T99 g, int x, int y)
	{
		int num = cHP * 100 / cHPFull / 10 - 1;
		if (num < 0)
		{
			num = 0;
		}
		if (num > 9)
		{
			num = 9;
		}
		g.M940(T101.imgHP, 0, 6 * (9 - num), 9, 6, 0, x, y, 3);
	}

	public int M189()
	{
		int result = 9145227;
		if (nClass.classId != 1 && nClass.classId != 2)
		{
			if (nClass.classId != 3 && nClass.classId != 4)
			{
				if (nClass.classId == 5 || nClass.classId == 6)
				{
					result = 7443811;
				}
			}
			else
			{
				result = 33023;
			}
		}
		else
		{
			result = 16711680;
		}
		return result;
	}

	public void M190(T99 g)
	{
		if (cTypePk == 3 || cTypePk == 5 || !M181())
		{
			return;
		}
		if (M113().charFocus != null && M113().charFocus.Equals(this))
		{
			if (M113().charFocus != null && M113().charFocus.Equals(this))
			{
				T98.tahoma_7_yellow.M902(g, cName, cx, cy - ch - T98.tahoma_7_green.M912() - 10, T98.CENTER, T98.tahoma_7_grey);
			}
		}
		else
		{
			T98.tahoma_7_yellow.M902(g, cName, cx, cy - ch - T98.tahoma_7_green.M912() - 5, T98.CENTER, T98.tahoma_7_grey);
		}
	}

	private void M191(T99 g)
	{
		T127 t = T54.parts[M256(head)];
		int num = CharInfo[cf][0][2] - t.pi[CharInfo[cf][0][0]].dy + 5;
		if ((isInvisiblez && !me) || (!me && T174.mapID == 113 && cy >= 360) || me)
		{
			return;
		}
		bool flag = myChar.clan != null && clanID == myChar.clan.ID;
		bool flag2 = cTypePk == 3 || cTypePk == 5;
		bool flag3 = cTypePk == 4;
		if (cName.StartsWith("$"))
		{
			cName = cName.Substring(1);
			isPet = true;
		}
		if (cName.StartsWith("#"))
		{
			cName = cName.Substring(1);
			isMiniPet = true;
		}
		if (M113().charFocus != null && M113().charFocus.Equals(this))
		{
			num += 5;
			M188(g, cx, cy - num + 3);
		}
		num += T98.tahoma_7_white.M912();
		T98 t2 = T98.tahoma_7_whiteSmall;
		if (!isPet && !isMiniPet)
		{
			if (flag2)
			{
				t2 = T98.nameFontRed;
			}
			else if (flag3)
			{
				t2 = T98.nameFontYellow;
			}
			else if (flag)
			{
				t2 = T98.nameFontGreen;
			}
		}
		else
		{
			t2 = T98.tahoma_7_blue1Small;
		}
		if ((paintName || flag2 || flag3) && !flag)
		{
			if (T110.clientType == 1)
			{
				t2.M902(g, cName, cx, cy - num, T98.CENTER, T98.tahoma_7_greySmall);
			}
			else
			{
				t2.M898(g, cName, cx, cy - num, T98.CENTER);
			}
			num += T98.tahoma_7.M912();
		}
		if (flag)
		{
			if (M113().charFocus != null && M113().charFocus.Equals(this))
			{
				t2.M902(g, cName, cx, cy - num, T98.CENTER, T98.tahoma_7_greySmall);
			}
			else if (charFocus == null)
			{
				t2.M902(g, cName, cx - 10, cy - num + 3, T98.LEFT, T98.tahoma_7_grey);
				M188(g, cx - 16, cy - num + 10);
			}
		}
	}

	public void M192(T99 g)
	{
		if (isMabuHold || head == 377 || leg == 471 || isTeleport || isFlyUp)
		{
			return;
		}
		int size = T174.size;
		if ((T174.mapID < 114 || T174.mapID > 120) && T174.mapID != 127 && T174.mapID != 128)
		{
			if (T174.M1958(xSd + size / 2, ySd + 1, 4))
			{
				g.M922(xSd / size * size, (ySd - 30) / size * size, size, 100);
			}
			else if (T174.M1956((xSd - size / 2) / size, (ySd + 1) / size) == 0)
			{
				g.M922(xSd / size * size, (ySd - 30) / size * size, 100, 100);
			}
			else if (T174.M1956((xSd + size / 2) / size, (ySd + 1) / size) == 0)
			{
				g.M922(xSd / size * size, (ySd - 30) / size * size, size, 100);
			}
			else if (T174.M1958(xSd - size / 2, ySd + 1, 8))
			{
				g.M922(xSd / 24 * size, (ySd - 30) / size * size, size, 100);
			}
		}
		g.M948(T174.bong, xSd, ySd, 3);
		g.M922(T54.cmx, T54.cmy - T51.transY, T54.gW, T54.gH + 2 * T51.transY);
	}

	public void M193()
	{
		int num = 0;
		xSd = cx;
		if (T174.M1958(cx, cy, 2))
		{
			ySd = cy;
			return;
		}
		ySd = cy;
		while (num < 30)
		{
			num++;
			ySd += 24;
			if (T174.M1958(xSd, ySd, 2))
			{
				if (ySd % 24 != 0)
				{
					ySd -= ySd % 24;
				}
				break;
			}
		}
	}

	private void M194(T99 g)
	{
		try
		{
			if (isInvisiblez)
			{
				if (me)
				{
					if (T51.gameTick % 50 != 48 && T51.gameTick % 50 != 90)
					{
						T157.M1785(g, 1195, cx, cy - 18, 0, T99.VCENTER | T99.HCENTER);
					}
					else
					{
						T157.M1785(g, 1196, cx, cy - 18, 0, T99.VCENTER | T99.HCENTER);
					}
				}
			}
			else
			{
				M199(g, cx, cy + fy, cdir, cf, isPaintBag: true);
			}
			if (isLockAttack)
			{
				T157.M1785(g, 290, cx, cy, 0, T99.BOTTOM | T99.HCENTER);
			}
		}
		catch (Exception ex)
		{
			T24.M328("Loi paint char without skill: " + ex.ToString());
		}
	}

	public void M195(T99 g, short[] id, int x, int y, int dir, bool isPaintChar)
	{
		int num = 0;
		int num2 = 0;
		if (statusMe == 6)
		{
			num = 8;
			num2 = 17;
		}
		if (statusMe == 1)
		{
			if (cp1 % 15 < 5)
			{
				num = 8;
				num2 = 17;
			}
			else
			{
				num = 8;
				num2 = 18;
			}
		}
		if (statusMe == 2)
		{
			if (cf <= 3)
			{
				num = 7;
				num2 = 17;
			}
			else
			{
				num = 7;
				num2 = 18;
			}
		}
		if (statusMe == 3 || statusMe == 9)
		{
			num = 5;
			num2 = 20;
		}
		if (statusMe == 4)
		{
			if (cf == 8)
			{
				num = 5;
				num2 = 16;
			}
			else
			{
				num = 5;
				num2 = 20;
			}
		}
		if (statusMe == 10)
		{
			T137.M1513("cf= " + cf);
			if (cf == 8)
			{
				num = 0;
				num2 = 23;
			}
			else
			{
				num = 5;
				num2 = 22;
			}
		}
		if (isInjure > 0)
		{
			num = 5;
			num2 = 18;
		}
		if (skillPaint != null && M178() != null && indexSkill < M178().Length)
		{
			num = -1;
			num2 = 17;
		}
		fBag++;
		if (fBag > 10000)
		{
			fBag = 0;
		}
		sbyte b = (sbyte)(fBag / 4 % id.Length);
		if (!isPaintChar)
		{
			if (id.Length == 2)
			{
				b = 1;
			}
			if (id.Length == 3)
			{
				if (id[2] >= 0)
				{
					b = 2;
					if (T51.gameTick % 10 > 5)
					{
						b = 1;
					}
				}
				else
				{
					b = 1;
				}
			}
		}
		else if (id.Length > 1 && (b == 0 || b == 1) && statusMe != 1 && statusMe != 6)
		{
			fBag = 0;
			b = 0;
			if (T51.gameTick % 10 > 5)
			{
				b = 1;
			}
		}
		T157.M1785(g, id[b], x + ((dir != 1) ? num : (-num)), y - num2, (dir != 1) ? 2 : 0, T163.VCENTER_HCENTER);
	}

	public bool M196(int id)
	{
		T127 t = T54.parts[head];
		T127 t2 = T54.parts[leg];
		T127 t3 = T54.parts[body];
		for (int i = 0; i < CharInfo.Length; i++)
		{
			if (id != t.pi[CharInfo[i][0][0]].id)
			{
				if (id != t2.pi[CharInfo[i][1][0]].id)
				{
					if (id == t3.pi[CharInfo[i][2][0]].id)
					{
						return true;
					}
					continue;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	public void M197(T99 g, int cx, int cy, int look)
	{
		T157.M1785(g, T54.parts[head].pi[CharInfo[0][0][0]].id, cx, cy, (look != 0) ? 2 : 0, T99.RIGHT | T99.VCENTER);
	}

	public void M198(T99 g, int x, int y, int look)
	{
		T127 t = T54.parts[head];
		T157.M1785(g, t.pi[CharInfo[0][0][0]].id, x + CharInfo[0][0][1] + t.pi[CharInfo[0][0][0]].dx - 3, y + 3, look, T99.LEFT | T99.BOTTOM);
	}

	public void M199(T99 g, int cx, int cy, int cdir, int cf, bool isPaintBag)
	{
		T127 t = T54.parts[head];
		T127 t2 = T54.parts[leg];
		T127 t3 = T54.parts[body];
		if (bag >= 0 && statusMe != 14 && isMonkey == 0)
		{
			if (!T17.idImages.M1081(bag + string.Empty))
			{
				T17.idImages.M1078(bag + string.Empty, new T17());
				T146.M1594().M1714((sbyte)bag);
			}
			else
			{
				T17 t4 = (T17)T17.idImages.M1074(bag + string.Empty);
				if (t4.idImage != null && isPaintBag)
				{
					M195(g, t4.idImage, cx, cy, cdir, isPaintChar: true);
				}
			}
		}
		int num = 2;
		int anchor = 24;
		int anchor2 = T163.TOP_RIGHT;
		int num2 = -1;
		if (cdir == 1)
		{
			num = 0;
			anchor = 0;
			anchor2 = 0;
			num2 = 1;
		}
		if (statusMe == 14)
		{
			if (T51.gameTick % 4 > 0)
			{
				g.M948(T80.imageFlare, cx, cy - ch - 11, T99.HCENTER | T99.VCENTER);
			}
			int num3 = 0;
			if (head == 89 || head == 457 || head == 460 || head == 461 || head == 462 || head == 463 || head == 464 || head == 465 || head == 466)
			{
				num3 = 15;
			}
			T157.M1785(g, 834, cx, cy - CharInfo[cf][2][2] + t3.pi[CharInfo[cf][2][0]].dy - 2 + num3, num, T163.TOP_CENTER);
			T157.M1785(g, 79, cx, cy - ch - 8, 0, T99.HCENTER | T99.BOTTOM);
			M261(g, cf, cy - CharInfo[cf][2][2] + t3.pi[CharInfo[cf][2][0]].dy);
			if (M254(head))
			{
				T127 t5 = T54.parts[M256(head)];
				T157.M1785(g, t5.pi[CharInfo[cf][0][0]].id, cx + (CharInfo[cf][0][1] + t5.pi[CharInfo[cf][0][0]].dx) * num2, cy - CharInfo[cf][0][2] + t5.pi[CharInfo[cf][0][0]].dy, num, anchor);
			}
			else
			{
				T157.M1785(g, t.pi[CharInfo[cf][0][0]].id, cx + (CharInfo[cf][0][1] + t.pi[CharInfo[cf][0][0]].dx) * num2, cy - CharInfo[cf][0][2] + t.pi[CharInfo[cf][0][0]].dy, num, anchor);
			}
			M262(g, cf, cy - CharInfo[cf][2][2] + t3.pi[CharInfo[cf][2][0]].dy);
			M253(g, cx + (CharInfo[cf][0][1] + t.pi[CharInfo[cf][0][0]].dx) * num2, cy - CharInfo[cf][0][2] + t.pi[CharInfo[cf][0][0]].dy, num, anchor);
		}
		else
		{
			M261(g, cf, cy - CharInfo[cf][2][2] + t3.pi[CharInfo[cf][2][0]].dy);
			if (M254(head))
			{
				T127 t6 = T54.parts[M256(head)];
				T157.M1785(g, t6.pi[CharInfo[cf][0][0]].id, cx + (CharInfo[cf][0][1] + t6.pi[CharInfo[cf][0][0]].dx) * num2, cy - CharInfo[cf][0][2] + t6.pi[CharInfo[cf][0][0]].dy, num, anchor);
			}
			else
			{
				T157.M1785(g, t.pi[CharInfo[cf][0][0]].id, cx + (CharInfo[cf][0][1] + t.pi[CharInfo[cf][0][0]].dx) * num2, cy - CharInfo[cf][0][2] + t.pi[CharInfo[cf][0][0]].dy, num, anchor);
			}
			M262(g, cf, cy - CharInfo[cf][2][2] + t3.pi[CharInfo[cf][2][0]].dy);
			T157.M1785(g, t2.pi[CharInfo[cf][1][0]].id, cx + (CharInfo[cf][1][1] + t2.pi[CharInfo[cf][1][0]].dx) * num2, cy - CharInfo[cf][1][2] + t2.pi[CharInfo[cf][1][0]].dy, num, anchor);
			T157.M1785(g, t3.pi[CharInfo[cf][2][0]].id, cx + (CharInfo[cf][2][1] + t3.pi[CharInfo[cf][2][0]].dx) * num2, cy - CharInfo[cf][2][2] + t3.pi[CharInfo[cf][2][0]].dy, num, anchor);
			M253(g, cx + (CharInfo[cf][0][1] + t.pi[CharInfo[cf][0][0]].dx) * num2, cy - CharInfo[cf][0][2] + t.pi[CharInfo[cf][0][0]].dy, num, anchor);
		}
		ch = ((isMonkey == 1 || isFusion) ? 60 : (CharInfo[0][0][2] + t.pi[CharInfo[0][0][0]].dy + 10));
		if (statusMe == 1 && charID > 0 && !isMask && !M171() && !isWaitMonkey && skillPaint == null && cf != 23 && bag < 0 && ((T51.gameTick + charID) % 30 == 0 || isFreez))
		{
			g.M948((cgender != 1) ? eyeTraiDat : eyeNamek, cx + -((cgender != 1) ? 2 : 2) * num2, cy - 32 + ((cgender != 1) ? 11 : 10) - cf, anchor2);
		}
		if (eProtect != null)
		{
			eProtect.M392(g);
		}
		M232(g);
	}

	public void M200(T99 g)
	{
		ty = 0;
		T150[] array = M178();
		cf = array[indexSkill].status;
		M194(g);
		if (cdir == 1)
		{
			if (eff0 != null)
			{
				if (dx0 == 0)
				{
					dx0 = array[indexSkill].e0dx;
				}
				if (dy0 == 0)
				{
					dy0 = array[indexSkill].e0dy;
				}
				T157.M1785(g, eff0.arrEfInfo[i0].idImg, cx + dx0 + eff0.arrEfInfo[i0].dx, cy + dy0 + eff0.arrEfInfo[i0].dy, 0, T99.VCENTER | T99.HCENTER);
				i0++;
				if (i0 >= eff0.arrEfInfo.Length)
				{
					eff0 = null;
					dy0 = 0;
					dx0 = 0;
					i0 = 0;
				}
			}
			if (eff1 != null)
			{
				if (dx1 == 0)
				{
					dx1 = array[indexSkill].e1dx;
				}
				if (dy1 == 0)
				{
					dy1 = array[indexSkill].e1dy;
				}
				T157.M1785(g, eff1.arrEfInfo[i1].idImg, cx + dx1 + eff1.arrEfInfo[i1].dx, cy + dy1 + eff1.arrEfInfo[i1].dy, 0, T99.VCENTER | T99.HCENTER);
				i1++;
				if (i1 >= eff1.arrEfInfo.Length)
				{
					eff1 = null;
					dy1 = 0;
					dx1 = 0;
					i1 = 0;
				}
			}
			if (eff2 != null)
			{
				if (dx2 == 0)
				{
					dx2 = array[indexSkill].e2dx;
				}
				if (dy2 == 0)
				{
					dy2 = array[indexSkill].e2dy;
				}
				T157.M1785(g, eff2.arrEfInfo[i2].idImg, cx + dx2 + eff2.arrEfInfo[i2].dx, cy + dy2 + eff2.arrEfInfo[i2].dy, 0, T99.VCENTER | T99.HCENTER);
				i2++;
				if (i2 >= eff2.arrEfInfo.Length)
				{
					eff2 = null;
					dy2 = 0;
					dx2 = 0;
					i2 = 0;
				}
			}
		}
		else
		{
			if (eff0 != null)
			{
				if (dx0 == 0)
				{
					dx0 = array[indexSkill].e0dx;
				}
				if (dy0 == 0)
				{
					dy0 = array[indexSkill].e0dy;
				}
				T157.M1785(g, eff0.arrEfInfo[i0].idImg, cx - dx0 - eff0.arrEfInfo[i0].dx, cy + dy0 + eff0.arrEfInfo[i0].dy, 2, T99.VCENTER | T99.HCENTER);
				i0++;
				if (i0 >= eff0.arrEfInfo.Length)
				{
					eff0 = null;
					i0 = 0;
					dx0 = 0;
					dy0 = 0;
				}
			}
			if (eff1 != null)
			{
				if (dx1 == 0)
				{
					dx1 = array[indexSkill].e1dx;
				}
				if (dy1 == 0)
				{
					dy1 = array[indexSkill].e1dy;
				}
				T157.M1785(g, eff1.arrEfInfo[i1].idImg, cx - dx1 - eff1.arrEfInfo[i1].dx, cy + dy1 + eff1.arrEfInfo[i1].dy, 2, T99.VCENTER | T99.HCENTER);
				i1++;
				if (i1 >= eff1.arrEfInfo.Length)
				{
					eff1 = null;
					i1 = 0;
					dx1 = 0;
					dy1 = 0;
				}
			}
			if (eff2 != null)
			{
				if (dx2 == 0)
				{
					dx2 = array[indexSkill].e2dx;
				}
				if (dy2 == 0)
				{
					dy2 = array[indexSkill].e2dy;
				}
				T157.M1785(g, eff2.arrEfInfo[i2].idImg, cx - dx2 - eff2.arrEfInfo[i2].dx, cy + dy2 + eff2.arrEfInfo[i2].dy, 2, T99.VCENTER | T99.HCENTER);
				i2++;
				if (i2 >= eff2.arrEfInfo.Length)
				{
					eff2 = null;
					i2 = 0;
					dx2 = 0;
					dy2 = 0;
				}
			}
		}
		indexSkill++;
	}

	public static int M201(int ID)
	{
		for (int i = 0; i < T54.vCharInMap.M1113(); i++)
		{
			if (((T13)T54.vCharInMap.M1114(i)).charID == ID)
			{
				return i;
			}
		}
		return -1;
	}

	public void M202(int toX, int toY, int type)
	{
		if (type != 1 && T137.M1529(toX - cx) <= 100 && T137.M1529(toY - cy) <= 300)
		{
			int dir = 0;
			int act = 0;
			int num = toX - cx;
			int num2 = toY - cy;
			if (num == 0 && num2 == 0)
			{
				act = 1;
				cp3 = 0;
			}
			else if (num2 == 0)
			{
				act = 2;
				if (num > 0)
				{
					dir = 1;
				}
				if (num < 0)
				{
					dir = -1;
				}
			}
			else if (num2 != 0)
			{
				if (num2 < 0)
				{
					act = 3;
				}
				if (num2 > 0)
				{
					act = 4;
				}
				if (num < 0)
				{
					dir = -1;
				}
				if (num > 0)
				{
					dir = 1;
				}
			}
			vMovePoints.M1111(new T107(toX, toY, act, dir));
			if (statusMe != 6)
			{
				statusBeforeNothing = statusMe;
			}
			statusMe = 6;
			cp3 = 0;
		}
		else
		{
			M182(cx, cy, 10);
			cx = toX;
			cy = toY;
			vMovePoints.M1120();
			statusMe = 6;
			cp3 = 0;
			currentMovePoint = null;
			cf = 25;
		}
	}

	public static void M203(int cID, int dx, int dy, int HP)
	{
		T13 t = (T13)T54.vCharInMap.M1114(cID);
		if (t.vMovePoints.M1113() != 0)
		{
			T107 t2 = (T107)t.vMovePoints.M1123();
			int xEnd = t2.xEnd + dx;
			int yEnd = t2.yEnd + dy;
			T13 t3 = (T13)T54.vCharInMap.M1114(cID);
			t3.cHP -= HP;
			if (t3.cHP < 0)
			{
				t3.cHP = 0;
			}
			t3.cHPShow = ((T13)T54.vCharInMap.M1114(cID)).cHP - HP;
			t3.statusMe = 6;
			t3.cp3 = 0;
			t3.vMovePoints.M1111(new T107(xEnd, yEnd, 8, t3.cdir));
		}
	}

	public bool M204()
	{
		if (T54.M559().magicTree != null)
		{
			int x = T54.M559().magicTree.x;
			int y = T54.M559().magicTree.y;
			if (cx > x - 30 && cx < x + 30 && cy > y - 30)
			{
				return cy < y + 30;
			}
			return false;
		}
		return false;
	}

	public void M205()
	{
		int[] array = new int[4] { -1, -1, -1, -1 };
		if (itemFocus != null)
		{
			return;
		}
		for (int i = 0; i < T54.vItemMap.M1113(); i++)
		{
			T80 t = (T80)T54.vItemMap.M1114(i);
			int num = T94.M869(M113().cx - t.x);
			int num2 = T94.M869(M113().cy - t.y);
			int num3 = ((num <= num2) ? num2 : num);
			if (num > 48 || num2 > 48 || (itemFocus != null && num3 >= array[3]))
			{
				continue;
			}
			if (T54.M559().auto != 0 && T54.M559().M551())
			{
				if (t.template.type == 9)
				{
					itemFocus = t;
					array[3] = num3;
				}
			}
			else
			{
				itemFocus = t;
				array[3] = num3;
			}
		}
	}

	public void M206()
	{
		if (M113().skillPaint == null && M113().arr == null && M113().dart == null)
		{
			if (timeFocusToMob > 0)
			{
				timeFocusToMob--;
				return;
			}
			if (isManualFocus && charFocus != null && (charFocus.statusMe == 15 || charFocus.isInvisiblez))
			{
				charFocus = null;
			}
			if (T51.gameTick % 2 == 0 || M225(charFocus))
			{
				return;
			}
			int num = 0;
			if (nClass.classId == 0 || nClass.classId == 1 || nClass.classId == 3 || nClass.classId == 5)
			{
				num = 40;
			}
			int[] array = new int[4] { -1, -1, -1, -1 };
			int num2 = T54.cmx - 10;
			int num3 = T54.cmx + T51.w + 10;
			int cmy = T54.cmy;
			int num4 = T54.cmy + T51.h - T54.cmdBarH + 10;
			if (isManualFocus)
			{
				if ((mobFocus != null && mobFocus.status != 1 && mobFocus.status != 0 && num2 <= mobFocus.x && mobFocus.x <= num3 && cmy <= mobFocus.y && mobFocus.y <= num4) || (npcFocus != null && num2 <= npcFocus.cx && npcFocus.cx <= num3 && cmy <= npcFocus.cy && npcFocus.cy <= num4) || (charFocus != null && num2 <= charFocus.cx && charFocus.cx <= num3 && cmy <= charFocus.cy && charFocus.cy <= num4) || (itemFocus != null && num2 <= itemFocus.x && itemFocus.x <= num3 && cmy <= itemFocus.y && itemFocus.y <= num4))
				{
					return;
				}
				isManualFocus = false;
			}
			num2 = M113().cx - 80;
			num3 = M113().cx + 80;
			cmy = M113().cy - 30;
			num4 = M113().cy + 30;
			if (npcFocus != null && npcFocus.template.npcTemplateId == 6)
			{
				num2 = M113().cx - 20;
				num3 = M113().cx + 20;
				cmy = M113().cy - 10;
				num4 = M113().cy + 10;
			}
			num2 = M113().cx - M113().M104() - 10;
			num3 = M113().cx + M113().M104() + 10;
			cmy = M113().cy - M113().M105() - num - 20;
			if (M113().cy + M113().M105() + 20 > M113().cy + 30)
			{
				num4 = M113().cy + 30;
			}
			int num5 = -1;
			for (int i = 0; i < array.Length; i++)
			{
				if (num5 == -1)
				{
					if (array[i] != -1)
					{
						num5 = i;
					}
				}
				else if (array[i] < array[num5] && array[i] != -1)
				{
					num5 = i;
				}
			}
			M207(num5);
			if (me && M209())
			{
				if (mobFocus != null && !mobFocus.isMobMe)
				{
					mobFocus = null;
				}
				npcFocus = null;
				itemFocus = null;
			}
		}
		else
		{
			timeFocusToMob = 200;
		}
	}

	public void M207(int index)
	{
		switch (index)
		{
		case 0:
			M213();
			charFocus = null;
			itemFocus = null;
			break;
		case 1:
			mobFocus = null;
			charFocus = null;
			itemFocus = null;
			break;
		case 2:
			mobFocus = null;
			M213();
			itemFocus = null;
			break;
		case 3:
			mobFocus = null;
			M213();
			charFocus = null;
			break;
		}
	}

	public static bool M208(T13 c)
	{
		int cmx = T54.cmx;
		int num = T54.cmx + T51.w;
		int num2 = T54.cmy + 10;
		int num3 = T54.cmy + T54.gH;
		if (c.statusMe != 15 && !c.isInvisiblez && cmx <= c.cx && c.cx <= num && num2 <= c.cy)
		{
			return c.cy <= num3;
		}
		return false;
	}

	public bool M209()
	{
		if (cTypePk != 4)
		{
			return cTypePk == 3;
		}
		return true;
	}

	public void M210(T13 r)
	{
		if (cx < r.cx)
		{
			cdir = 1;
		}
		else
		{
			cdir = -1;
		}
		charHold = r;
		holder = true;
	}

	public void M211(T101 r)
	{
		if (cx < r.x)
		{
			cdir = 1;
		}
		else
		{
			cdir = -1;
		}
		mobHold = r;
		holder = true;
	}

	public void M212()
	{
		T137.M1513("focus size= " + focus.M1113());
		if ((M113().skillPaint != null || M113().arr != null || M113().dart != null || M113().M178() != null) && focus.M1113() == 0)
		{
			return;
		}
		focus.M1120();
		int num = 0;
		int num2 = T54.cmx + 10;
		int num3 = T54.cmx + T51.w - 10;
		int num4 = T54.cmy + 10;
		int num5 = T54.cmy + T54.gH;
		for (int i = 0; i < T54.vCharInMap.M1113(); i++)
		{
			T13 t = (T13)T54.vCharInMap.M1114(i);
			if (t.statusMe != 15 && !t.isInvisiblez && num2 <= t.cx && t.cx <= num3 && num4 <= t.cy && t.cy <= num5 && t.charID != -114 && (T174.mapID != 129 || (T174.mapID == 129 && M113().cy > 264)))
			{
				focus.M1111(t);
				if (charFocus != null && t.Equals(charFocus))
				{
					num = focus.M1113();
				}
			}
		}
		if (me && M209())
		{
			T137.M1513("co the tan cong nguoi");
			for (int j = 0; j < T54.vMob.M1113(); j++)
			{
				T101 t2 = (T101)T54.vMob.M1114(j);
				if (!T54.M559().M571(t2))
				{
					T137.M1513("khong the tan cong quai");
					mobFocus = null;
					continue;
				}
				T137.M1513("co the tan ong quai");
				focus.M1111(t2);
				if (mobFocus != null)
				{
					num = focus.M1113();
				}
			}
			npcFocus = null;
			itemFocus = null;
			if (focus.M1113() > 0)
			{
				if (num >= focus.M1113())
				{
					num = 0;
				}
				M227(focus.M1114(num));
			}
			else
			{
				mobFocus = null;
				M213();
				charFocus = null;
				itemFocus = null;
				isManualFocus = false;
			}
			return;
		}
		for (int k = 0; k < T54.vItemMap.M1113(); k++)
		{
			T80 t3 = (T80)T54.vItemMap.M1114(k);
			if (num2 <= t3.x && t3.x <= num3 && num4 <= t3.y && t3.y <= num5)
			{
				focus.M1111(t3);
				if (itemFocus != null && t3.Equals(itemFocus))
				{
					num = focus.M1113();
				}
			}
		}
		for (int l = 0; l < T54.vMob.M1113(); l++)
		{
			T101 t4 = (T101)T54.vMob.M1114(l);
			if (t4.status != 1 && t4.status != 0 && num2 <= t4.x && t4.x <= num3 && num4 <= t4.y && t4.y <= num5)
			{
				focus.M1111(t4);
				if (mobFocus != null && t4.Equals(mobFocus))
				{
					num = focus.M1113();
				}
			}
		}
		for (int m = 0; m < T54.vNpc.M1113(); m++)
		{
			T123 t5 = (T123)T54.vNpc.M1114(m);
			if (t5.statusMe != 15 && num2 <= t5.cx && t5.cx <= num3 && num4 <= t5.cy && t5.cy <= num5)
			{
				focus.M1111(t5);
				if (npcFocus != null && t5.Equals(npcFocus))
				{
					num = focus.M1113();
				}
			}
		}
		if (focus.M1113() > 0)
		{
			if (num >= focus.M1113())
			{
				num = 0;
			}
			M227(focus.M1114(num));
		}
		else
		{
			mobFocus = null;
			M213();
			charFocus = null;
			itemFocus = null;
			isManualFocus = false;
		}
	}

	public void M213()
	{
		if (me && npcFocus != null)
		{
			if (!T51.menu.showMenu)
			{
				chatPopup = null;
			}
			npcFocus = null;
		}
	}

	public void M214()
	{
		if (!T51.lowGraphic)
		{
			if (T174.M1958(cx, cy + 1, 1024))
			{
				T174.M1959(cx, cy + 1, 512);
				T174.M1959(cx, cy - 2, 512);
			}
			if (T174.M1958(cx - T174.size, cy + 1, 512))
			{
				T174.M1961(cx - T174.size, cy + 1, 512);
				T174.M1961(cx - T174.size, cy - 2, 512);
			}
			if (T174.M1958(cx + T174.size, cy + 1, 512))
			{
				T174.M1961(cx + T174.size, cy + 1, 512);
				T174.M1961(cx + T174.size, cy - 2, 512);
			}
		}
	}

	public static void M215(int[] data)
	{
		int num = 5;
		for (int i = 0; i < num - 1; i++)
		{
			for (int j = i + 1; j < num; j++)
			{
				if (data[i] < data[j])
				{
					int num2 = data[j];
					data[j] = data[i];
					data[i] = num2;
				}
			}
		}
	}

	public static bool M216(int cmX, int cmWx, int x, int cmy, int cmyH, int y)
	{
		if (x <= cmWx && x >= cmX && y <= cmyH)
		{
			return y >= cmy;
		}
		return false;
	}

	public void M217(T79 item, int maxKick)
	{
		int num = 0;
		if (item == null || item.options == null)
		{
			return;
		}
		for (int i = 0; i < item.options.M1113(); i++)
		{
			T82 t = (T82)item.options.M1114(i);
			t.active = 0;
			if (t.optionTemplate.type == 2)
			{
				if (num < maxKick)
				{
					t.active = 1;
					num++;
				}
			}
			else if (t.optionTemplate.type == 3 && item.upgrade >= 4)
			{
				t.active = 1;
			}
			else if (t.optionTemplate.type == 4 && item.upgrade >= 8)
			{
				t.active = 1;
			}
			else if (t.optionTemplate.type == 5 && item.upgrade >= 12)
			{
				t.active = 1;
			}
			else if (t.optionTemplate.type == 6 && item.upgrade >= 14)
			{
				t.active = 1;
			}
			else if (t.optionTemplate.type == 7 && item.upgrade >= 16)
			{
				t.active = 1;
			}
		}
	}

	public void M218(int HPShow, int MPShow, bool isCrit, bool isMob)
	{
		this.isCrit = isCrit;
		this.isMob = isMob;
		T137.M1513("CHP= " + cHP + " dame -= " + HPShow + " HP FULL= " + cHPFull);
		cHP -= HPShow;
		cMP -= MPShow;
		T54.M559().isInjureHp = true;
		T54.M559().twHp = 0;
		T54.M559().isInjureMp = true;
		T54.M559().twMp = 0;
		if (cHP < 0)
		{
			cHP = 0;
		}
		if (cMP < 0)
		{
			cMP = 0;
		}
		if (isMob || (!isMob && cTypePk != 4 && damMP != -100))
		{
			if (HPShow <= 0)
			{
				if (me)
				{
					T54.M643(mResources.miss, cx, cy - ch, 0, -2, T98.MISS_ME);
				}
				else
				{
					T54.M643(mResources.miss, cx, cy - ch, 0, -2, T98.MISS);
				}
			}
			else
			{
				T54.M643("-" + HPShow, cx, cy - ch, 0, -2, isCrit ? T98.FATAL : T98.RED);
			}
		}
		if (HPShow > 0)
		{
			isInjure = 6;
		}
		T143.M1574(80, this, 1);
		if (isDie)
		{
			isDie = false;
			isLockKey = false;
			M220((short)xSd, (short)ySd);
		}
	}

	public void M219()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T54.M559().isInjureHp = true;
		T54.M559().twHp = 0;
		T54.M559().isInjureMp = true;
		T54.M559().twMp = 0;
		isInjure = 6;
		T143.M1574(8, this, 1);
		isInjureHp = true;
		twHp = 0;
	}

	public void M220(short toX, short toY)
	{
		isMonkey = 0;
		isWaitMonkey = false;
		if (me && isDie)
		{
			return;
		}
		if (me)
		{
			isLockMove = true;
			for (int i = 0; i < T54.vCharInMap.M1113(); i++)
			{
				((T13)T54.vCharInMap.M1114(i)).killCharId = -9999;
			}
			if (T51.panel != null && T51.panel.cp != null)
			{
				T51.panel.cp = null;
			}
			if (T51.panel2 != null && T51.panel2.cp != null)
			{
				T51.panel2.cp = null;
			}
		}
		statusMe = 5;
		cp2 = toX;
		cp3 = toY;
		cp1 = 0;
		cHP = 0;
		testCharId = -9999;
		killCharId = -9999;
		if (me && myskill != null && myskill.template.id != 14)
		{
			M175();
		}
		cTypePk = 0;
	}

	public void M221(short toX, short toY)
	{
		wdx = toX;
		wdy = toY;
	}

	public void M222()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		cHP = cHPFull;
		cMP = cMPFull;
		statusMe = 1;
		cp3 = 0;
		cp2 = 0;
		cp1 = 0;
		T143.M1574(109, this, 2);
		T54.M559().center = null;
		T54.isHaveSelectSkill = true;
	}

	public bool M223()
	{
		if (arrItemBag == null)
		{
			return false;
		}
		for (int i = 0; i < arrItemBag.Length; i++)
		{
			if (arrItemBag[i] != null && arrItemBag[i].template.type == 6)
			{
				T146.M1594().M1615(0, 1, -1, arrItemBag[i].template.id);
				return true;
			}
		}
		return false;
	}

	public bool M224()
	{
		if (T174.mapID != 1 && T174.mapID != 27 && T174.mapID != 72 && T174.mapID != 10 && T174.mapID != 17 && T174.mapID != 22 && T174.mapID != 32 && T174.mapID != 38 && T174.mapID != 43)
		{
			return T174.mapID == 48;
		}
		return true;
	}

	public bool M225(T13 cAtt)
	{
		if (cAtt != null && M113().myskill != null && M113().myskill.template.type != 2 && (M113().myskill.template.type != 4 || cAtt.statusMe == 14 || cAtt.statusMe == 5) && ((cAtt.cTypePk == 3 && M113().cTypePk == 3) || M113().cTypePk == 5 || cAtt.cTypePk == 5 || (M113().cTypePk == 1 && cAtt.cTypePk == 1) || (M113().cTypePk == 4 && cAtt.cTypePk == 4) || (M113().testCharId >= 0 && M113().testCharId == cAtt.charID) || (M113().killCharId >= 0 && M113().killCharId == cAtt.charID && !M224()) || (cAtt.killCharId >= 0 && cAtt.killCharId == M113().charID && !M224()) || (M113().cFlag == 8 && cAtt.cFlag != 0) || (M113().cFlag != 0 && cAtt.cFlag == 8) || (M113().cFlag != cAtt.cFlag && M113().cFlag != 0 && cAtt.cFlag != 0)) && cAtt.statusMe != 14)
		{
			return cAtt.statusMe != 5;
		}
		return false;
	}

	public void M226()
	{
		M113().taskMaint = null;
		for (int i = 0; i < M113().arrItemBag.Length; i++)
		{
			if (M113().arrItemBag[i] != null && M113().arrItemBag[i].template.type == 8)
			{
				M113().arrItemBag[i] = null;
			}
		}
		T123.M1196();
	}

	public int getX()
	{
		return cx;
	}

	public int getY()
	{
		return cy;
	}

	public int getH()
	{
		return 32;
	}

	public int getW()
	{
		return 24;
	}

	public void M227(object objectz)
	{
		if (objectz is T101)
		{
			mobFocus = (T101)objectz;
			M213();
			charFocus = null;
			itemFocus = null;
		}
		else if (objectz is T123)
		{
			M113().mobFocus = null;
			M113().M213();
			M113().npcFocus = (T123)objectz;
			M113().charFocus = null;
			M113().itemFocus = null;
		}
		else if (objectz is T13)
		{
			M113().mobFocus = null;
			M113().M213();
			M113().charFocus = (T13)objectz;
			M113().itemFocus = null;
		}
		else if (objectz is T80)
		{
			M113().mobFocus = null;
			M113().M213();
			M113().charFocus = null;
			M113().itemFocus = (T80)objectz;
		}
		isManualFocus = true;
	}

	public void stopMoving()
	{
	}

	public void M228()
	{
	}

	public bool isInvisible()
	{
		return false;
	}

	public bool M229()
	{
		if (mobFocus == null)
		{
			if (charFocus != null)
			{
				return M225(charFocus);
			}
			return false;
		}
		return true;
	}

	public void M230(int type)
	{
		if (T51.lowGraphic)
		{
			return;
		}
		switch (type)
		{
		case 1:
			if (clevel >= 9)
			{
				T31.M376(new T32(19, cx - 5, cy + 20, 2, 1, -1));
			}
			break;
		case 2:
			if ((!me || isMonkey != 1) && isNhapThe && T51.gameTick % 5 == 0)
			{
				T31.M376(new T32(22, cx - 5, cy + 35, 2, 1, -1));
			}
			break;
		case 3:
			if (clevel >= 9 && ySd - cy <= 5)
			{
				T31.M376(new T32(19, cx - 5, ySd + 20, 2, 1, -1));
			}
			break;
		}
	}

	public bool M231(sbyte getFlag)
	{
		bool result = true;
		for (int i = 0; i < T54.vFlag.M1113(); i++)
		{
			T129 t = (T129)T54.vFlag.M1114(i);
			if (t != null)
			{
				if (t.cflag == getFlag)
				{
					return true;
				}
				result = false;
			}
		}
		return result;
	}

	private void M232(T99 g)
	{
		if (cdir == 1)
		{
			if (cFlag != 0 && cFlag != -1)
			{
				T157.M1785(g, flagImage, cx - 10, cy - ch - ((!me) ? 30 : 30) + ((T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0), 2, 0);
			}
		}
		else if (cFlag != 0 && cFlag != -1)
		{
			T157.M1785(g, flagImage, cx, cy - ch - ((!me) ? 30 : 30) + ((T51.gameTick % 20 > 10) ? (T51.gameTick % 4 / 2) : 0), 0, 0);
		}
	}

	public void M233()
	{
		if (holder)
		{
			holder = false;
			charHold = null;
			mobHold = null;
		}
		else
		{
			holdEffID = 0;
			charHold = null;
			mobHold = null;
		}
	}

	public void M234()
	{
		protectEff = false;
		eProtect = null;
	}

	public void M235()
	{
		blindEff = false;
	}

	public void M236()
	{
		if (holdEffID != 0)
		{
			holdEffID = 0;
		}
		if (holder)
		{
			holder = false;
		}
		if (protectEff)
		{
			protectEff = false;
		}
		eProtect = null;
		charHold = null;
		mobHold = null;
		blindEff = false;
		sleepEff = false;
	}

	public void M237(short xPos, short yPos, sbyte typePos)
	{
		isSetPos = true;
		this.xPos = xPos;
		this.yPos = yPos;
		this.typePos = typePos;
		tpos = 0;
		if (me)
		{
			if (T51.panel != null)
			{
				T51.panel.M1382();
			}
			if (T51.panel2 != null)
			{
				T51.panel2.M1382();
			}
		}
	}

	public void M238()
	{
		huytSao = false;
	}

	public void M239()
	{
		isFusion = false;
		isLockKey = false;
		tFusion = 0;
	}

	public void M240(sbyte fusion)
	{
		tFusion = 0;
		if (fusion == 4 || fusion == 5)
		{
			if (me)
			{
				T146.M1594().M1730(fusion);
			}
			T31.M376(new T32(34, cx, cy + 12, 2, 1, -1));
		}
		if (fusion == 6)
		{
			T31.M376(new T32(38, cx, cy + 12, 2, 1, -1));
		}
		if (me)
		{
			T51.panel.M1381();
			isLockKey = true;
		}
		isFusion = true;
		if (fusion == 1)
		{
			isNhapThe = false;
		}
		else
		{
			isNhapThe = true;
		}
	}

	public void M241()
	{
		sleepEff = false;
	}

	public void M242()
	{
		headTemp = head;
		bodyTemp = body;
		legTemp = leg;
		bagTemp = bag;
	}

	public void M243(int head, int body, int leg, int bag)
	{
		if (head != -1)
		{
			this.head = head;
		}
		if (body != -1)
		{
			this.body = body;
		}
		if (leg != -1)
		{
			this.leg = leg;
		}
		if (bag != -1)
		{
			this.bag = bag;
		}
	}

	public void M244()
	{
		if (headTemp != -1)
		{
			head = headTemp;
			headTemp = -1;
		}
		if (bodyTemp != -1)
		{
			body = bodyTemp;
			bodyTemp = -1;
		}
		if (legTemp != -1)
		{
			leg = legTemp;
			legTemp = -1;
		}
		if (bagTemp != -1)
		{
			bag = bagTemp;
			bagTemp = -1;
		}
	}

	public T32 M245(int id)
	{
		for (int i = 0; i < vEffChar.M1113(); i++)
		{
			T32 t = (T32)vEffChar.M1114(i);
			if (t.effId == id)
			{
				return t;
			}
		}
		return null;
	}

	public void M246(T32 e)
	{
		M247(0, e.effId);
		vEffChar.M1111(e);
	}

	public void M247(int type, int id)
	{
		if (type == -1)
		{
			vEffChar.M1120();
		}
		else if (M245(id) != null)
		{
			vEffChar.M1119(M245(id));
		}
	}

	public void M248(T99 g)
	{
		for (int i = 0; i < vEffChar.M1113(); i++)
		{
			T32 t = (T32)vEffChar.M1114(i);
			if (t.layer == 0)
			{
				bool flag = true;
				if (t.isStand == 0)
				{
					flag = statusMe == 1 || statusMe == 6;
				}
				if (flag)
				{
					t.M392(g);
				}
			}
		}
	}

	public void M249(T99 g)
	{
		for (int i = 0; i < vEffChar.M1113(); i++)
		{
			T32 t = (T32)vEffChar.M1114(i);
			if (t.layer == 1)
			{
				bool flag = true;
				if (t.isStand == 0)
				{
					flag = statusMe == 1 || statusMe == 6;
				}
				if (flag)
				{
					t.M392(g);
				}
			}
		}
	}

	public void M250()
	{
		for (int i = 0; i < vEffChar.M1113(); i++)
		{
			((T32)vEffChar.M1114(i)).M393();
		}
	}

	public int M251()
	{
		return luong + luongKhoa;
	}

	public void M252()
	{
		if (head != 934)
		{
			return;
		}
		if (T51.timeNow - timeAddChopmat > 0L)
		{
			fChopmat++;
			if (fChopmat > frEye.Length - 1)
			{
				fChopmat = 0;
				timeAddChopmat = T51.timeNow + T137.M1522(2000, 3500);
				frEye = frChopCham;
				if (T137.M1523(2) == 0)
				{
					frEye = frChopNhanh;
				}
			}
		}
		else
		{
			fChopmat = 0;
		}
	}

	private void M253(T99 g, int xx, int yy, int trans, int anchor)
	{
		if (head != 934 || (statusMe != 1 && statusMe != 6))
		{
			return;
		}
		if (fraRedEye != null && fraRedEye.imgFrame != null)
		{
			if (frEye[fChopmat] != -1)
			{
				int num = 8;
				int num2 = 15;
				if (trans == 2)
				{
					num = -8;
				}
				fraRedEye.M439(frEye[fChopmat], xx + num, yy + num2, trans, anchor, g);
			}
		}
		else
		{
			fraRedEye = new T49(T110.M1071("/redeye.png"), 14, 10);
		}
	}

	public bool M254(int idHead)
	{
		for (int i = 0; i < Arr_Head_2Fr.Length; i++)
		{
			if (Arr_Head_2Fr[i][0] == idHead)
			{
				return true;
			}
		}
		return false;
	}

	private void M255()
	{
		if (M254(head))
		{
			fHead++;
			if (fHead > 10000)
			{
				fHead = 0;
			}
		}
		else
		{
			fHead = 0;
		}
	}

	private int M256(int idHead)
	{
		for (int i = 0; i < Arr_Head_2Fr.Length; i++)
		{
			if (Arr_Head_2Fr[i][0] == idHead)
			{
				return Arr_Head_2Fr[i][fHead / 4 % Arr_Head_2Fr[i].Length];
			}
		}
		return idHead;
	}

	public void M257(T99 g)
	{
		if ((!me || isPaintAura) && idAuraEff > -1 && (statusMe == 1 || statusMe == 6) && !T51.panel.isShow && T110.M1054() - timeBlue > 0L)
		{
			T49 t = T110.M1070(strEffAura + idAuraEff + "_0");
			t?.M439(T51.gameTick / 4 % t.nFrame, cx, cy, (cdir != 1) ? 2 : 0, T99.BOTTOM | T99.HCENTER, g);
		}
	}

	public void M258(T99 g)
	{
		if ((me && !isPaintAura) || idAuraEff <= -1)
		{
			return;
		}
		if (statusMe != 1 && statusMe != 6)
		{
			timeBlue = T110.M1054() + 1500L;
			IsAddDust1 = true;
			IsAddDust2 = true;
		}
		else if (!T51.panel.isShow && !T51.lowGraphic)
		{
			bool flag = false;
			if (T110.M1054() - timeBlue > -1000L && IsAddDust1)
			{
				flag = true;
				IsAddDust1 = false;
			}
			if (T110.M1054() - timeBlue > -500L && IsAddDust2)
			{
				flag = true;
				IsAddDust2 = false;
			}
			if (flag)
			{
				T51.M442().M506(-1, cx - -8, cy);
				T51.M442().M506(1, cx - 8, cy);
				M230(1);
			}
			if (T110.M1054() - timeBlue > 0L)
			{
				T49 t = T110.M1070(strEffAura + idAuraEff + "_1");
				t?.M439(T51.gameTick / 4 % t.nFrame, cx, cy + 2, (cdir != 1) ? 2 : 0, T99.BOTTOM | T99.HCENTER, g);
			}
		}
	}

	public void M259(T99 g)
	{
		if (idEff_Set_Item != -1)
		{
			if (fraEff != null)
			{
				fraEff.M439(T51.gameTick / 4 % fraEff.nFrame, cx, cy + 3, (cdir != 1) ? 2 : 0, T99.BOTTOM | T99.HCENTER, g);
			}
			else
			{
				fraEff = T110.M1070(strEff_Set_Item + idEff_Set_Item + "_0");
			}
		}
	}

	public void M260(T99 g)
	{
		if (idEff_Set_Item != -1)
		{
			if (fraEffSub != null)
			{
				fraEffSub.M439(T51.gameTick / 4 % fraEffSub.nFrame, cx, cy + 8, (cdir != 1) ? 2 : 0, T99.BOTTOM | T99.HCENTER, g);
			}
			else
			{
				fraEffSub = T110.M1070(strEff_Set_Item + idEff_Set_Item + "_1");
			}
		}
	}

	public void M261(T99 g, int cf, int yh)
	{
		try
		{
			if (idHat == -1)
			{
				return;
			}
			if (M263(cf))
			{
				if (fraHat_behind_2 != null)
				{
					fraHat_behind_2.M439(T51.gameTick / 4 % fraHat_behind_2.nFrame, cx + hatInfo[cf][0] * ((cdir == 1) ? 1 : (-1)), yh + hatInfo[cf][1], (cdir != 1) ? 2 : 0, T99.BOTTOM | T99.HCENTER, g);
				}
				else
				{
					fraHat_behind_2 = T110.M1070(strHat_behind + strNgang + idHat);
				}
			}
			else if (fraHat_behind != null)
			{
				fraHat_behind.M439(T51.gameTick / 4 % fraHat_behind.nFrame, cx + hatInfo[cf][0] * ((cdir == 1) ? 1 : (-1)), yh + hatInfo[cf][1], (cdir != 1) ? 2 : 0, T99.BOTTOM | T99.HCENTER, g);
			}
			else
			{
				fraHat_behind = T110.M1070(strHat_behind + idHat);
			}
		}
		catch (Exception)
		{
		}
	}

	public void M262(T99 g, int cf, int yh)
	{
		try
		{
			if (idHat == -1)
			{
				return;
			}
			if (M263(cf))
			{
				if (fraHat_font_2 != null)
				{
					fraHat_font_2.M439(T51.gameTick / 4 % fraHat_font_2.nFrame, cx + hatInfo[cf][0] * ((cdir == 1) ? 1 : (-1)), yh + hatInfo[cf][1], (cdir != 1) ? 2 : 0, T99.BOTTOM | T99.HCENTER, g);
				}
				else
				{
					fraHat_font_2 = T110.M1070(strHat_font + strNgang + idHat);
				}
			}
			else if (fraHat_font != null)
			{
				fraHat_font.M439(T51.gameTick / 4 % fraHat_font.nFrame, cx + hatInfo[cf][0] * ((cdir == 1) ? 1 : (-1)), yh + hatInfo[cf][1], (cdir != 1) ? 2 : 0, T99.BOTTOM | T99.HCENTER, g);
			}
			else
			{
				fraHat_font = T110.M1070(strHat_font + idHat);
			}
		}
		catch (Exception)
		{
		}
	}

	public bool M263(int fr)
	{
		if (fr != 2 && fr != 3 && fr != 4 && fr != 5 && fr != 6 && fr != 9 && fr != 10 && fr != 13 && fr != 14 && fr != 15 && fr != 16 && fr != 26 && fr != 27 && fr != 28)
		{
			return fr == 29;
		}
		return true;
	}

	public string M264()
	{
		if (cgender == 0)
		{
			return "TĐ";
		}
		if (cgender == 1)
		{
			return "NM";
		}
		return "XD";
	}

	public string M265()
	{
		if (cName != null && !(cName == "") && cName.StartsWith("["))
		{
			return cName.Substring(0, cName.IndexOf("]") + 1);
		}
		return "";
	}

	public static bool M266()
	{
		if (T174.mapID >= 85)
		{
			return T174.mapID <= 91;
		}
		return false;
	}
}
