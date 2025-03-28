using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using UnityEngine;

namespace Utilities;

public class GameAutomationHub : IActionListener, IChatable
{
	public static GameAutomationHub _Instance;

	public static int int_0;

	public static string account;

	public static string password;

	public static int int_1;

	public static int int_2;

	public static List<int> list_0;

	public static List<int> list_1;

	public static string string_2;

	public static int runSpeed;

	public static bool isAutoRevive;

	public static bool isLockFocus;

	public static int charIDLock;

	public static string[] inputLockFocusCharID;

	public static bool isConnectToAccountManager;

	public static int zoneIdNRD;

	public static int mapIdNRD;

	public static bool isOpenMenuNPC;

	public static bool isAutoEnterNRDMap;

	public static string[] nameMapsNRD;

	public static int int_4;

	public static bool bool_1;

	public static string[] inputHPPercentFusionDance;

	public static string[] inputHPFusionDance;

	public static int minumumHPPercentFusionDance;

	public static int minimumHPFusionDance;

	public static long long_0;

	public static List<int> listCharIDs;

	public static string[] inputCharID;

	public static bool isAutoLockControl;

	public static bool isAutoTeleport;

	public static long long_1;

	public static long long_2;

	public static bool isAutoAttackBoss;

	public static int HPLimit;

	public static string[] inputHPLimit;

	public static long long_3;

	public static bool isAutoAttackOtherChars;

	public static int limitHPChar;

	public static long long_4;

	public static string[] inputHPChar;

	public static bool isHuntingBoss;

	public static List<BossAppearanceInfo> listBosses;

	public static Image logoServerListScreen;

	public static Image logoGameScreen;

	public static List<Image> listBackgroundImages;

	public static List<Color> listFlagColor;

	public static int widthRect;

	public static int heightRect;

	public static List<Char> listCharsInMap;

	public static bool isShowCharsInMap;

	public static string string_0;

	public static bool isUsingSkill;

	public static long lastTimeConnected;

	public static bool isUsingCapsule;

	public static string string_1;

	public static int delay;

	public static Image image_0;

	public static int indexBackgroundImages;

	public static long lastTimeChangeBackground;

	public static string string_4;

	public static string string_3;

	public static int server;

	public static string APIKey;

	public static string APIServer;

	public static bool isSlovingCapcha;

	public static int int_3;

	public static long long_5;

	public static long long_6;

	public static bool bool_0;

	public static long long_7;

	public static bool isAutoT77;

	public static bool isAutoBomPicPoc;

	public static bool autoLogin;

	private static string pathfile;

	private static string resetLoadMapFile;

	private static bool RunningGoMapQLTK;

	private static bool thongBao;

	private static bool logoVoTri;

	public static int time_;

	public static long TIME_DELAY_UPDATE_ZONE;

	public static long LAST_TIME_UPDATE_ZONE;

	public static bool IsUpdateZone;

	static GameAutomationHub()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		logoVoTri = false;
		TIME_DELAY_UPDATE_ZONE = 500L;
		IsUpdateZone = true;
		account = "";
		isHuntingBoss = true;
		listFlagColor = new List<Color>();
		listCharsInMap = new List<Char>();
		isShowCharsInMap = true;
		string_0 = "https://www.facebook.com/zmanhcr7";
		pathfile = "Data/LoadMap.ini";
		resetLoadMapFile = "F|-1";
		thongBao = true;
		isHuntingBoss = true;
		listBosses = new List<BossAppearanceInfo>();
		listBackgroundImages = new List<Image>();
		limitHPChar = -1;
		inputHPChar = new string[2] { "Nhập HP Char:", "HP" };
		inputHPLimit = new string[2] { "Nhập HP:", "HP" };
		listCharIDs = new List<int>();
		inputCharID = new string[2] { "Nhập charID:", "charID" };
		inputHPPercentFusionDance = new string[2] { "Nhập %HP ", "%HP" };
		inputHPFusionDance = new string[2] { "Nhập HP", "HP" };
		nameMapsNRD = new string[7] { "Hành tinh M-2", "Hành tinh Polaris", "Hành tinh Cretaceous", "Hành tinh Monmaasu", "Hành tinh Rudeeze", "Hành tinh Gelbo", "Hành tinh Tigere" };
		inputLockFocusCharID = new string[2] { "Nhập charID lock", "charID" };
		list_0 = new List<int>();
		list_1 = new List<int>();
		string_2 = "2.0.6 - 06/04/2022 00:00:00";
		runSpeed = 6;
	}

	public static GameAutomationHub M2162()
	{
		if (_Instance == null)
		{
			_Instance = new GameAutomationHub();
		}
		return _Instance;
	}

	public static void M2163()
	{
		M2219();
		if (thongBao && GameCanvas.gameTick % 20 == 0)
		{
			new Thread(M2217).Start();
			thongBao = false;
		}
		if (File.Exists(pathfile) && !RunningGoMapQLTK)
		{
			string[] array = File.ReadAllText(pathfile).Split('|');
			try
			{
				if (array.Length > 1 && array[0] == "T" && int.TryParse(array[1], out var mapId))
				{
					RunningGoMapQLTK = true;
					new Thread((ThreadStart)delegate
					{
						if (mapId == -99)
						{
							if (Char.M113().M264().Equals("NM"))
							{
								mapId = 22;
							}
							else if (Char.M113().M264().Equals("XD"))
							{
								mapId = 23;
							}
							else
							{
								mapId = 21;
							}
						}
						M2216(mapId);
					}).Start();
				}
			}
			catch
			{
			}
		}
		if ((!MobCapcha.isAttack || !MobCapcha.explode) && GameScr.M559().mobCapcha != null)
		{
			if (!isSlovingCapcha && GameCanvas.gameTick % 100 == 0)
			{
				isSlovingCapcha = true;
				new Thread(M2209).Start();
			}
			return;
		}
		if (isShowCharsInMap)
		{
			listCharsInMap.Clear();
			for (int i = 0; i < GameScr.vCharInMap.M1113(); i++)
			{
				Char t = (Char)GameScr.vCharInMap.M1114(i);
				if (t.cName != null && t.cName != "" && !t.isPet && !t.isMiniPet && !t.cName.StartsWith("#") && !t.cName.StartsWith("$") && t.cName != "Trọng tài")
				{
					listCharsInMap.Add(t);
				}
			}
		}
		if (isAutoEnterNRDMap)
		{
			M2190();
		}
		if (isAutoRevive)
		{
			M2182();
		}
		if (isLockFocus)
		{
			M2183(charIDLock);
		}
		if (isConnectToAccountManager)
		{
			M2203();
		}
		AutoItemHandler.M2049();
		AutoChatManager.M2038();
		AutoPeanManager.M2093();
		GameAutomationController.M2128();
		AutoCombatSystem.M2149();
		AutoPickItem.M2107();
		MapNavigationSystem.M2060();
		AutoPotentialEnhancer.M2119();
		Char.M113().cspeed = runSpeed;
	}

	public static void M2164(mGraphics g)
	{
		if (logoVoTri)
		{
			try
			{
				g.M948(Image.M704(File.ReadAllBytes("Data//logo//manhcr7.png")), GameCanvas.w / 2, 1, 1);
			}
			catch
			{
				g.M948(Image.M721(Convert.FromBase64String(LogoHandler.Logo)), GameCanvas.w / 2, 1, 1);
			}
		}
		M2169(g);
		if (isShowCharsInMap)
		{
			M2165(g);
		}
		mFont.tahoma_7_white.M902(g, TileMap.mapNames[TileMap.mapID] + " [" + TileMap.zoneID + "-" + Char.M113().cx + "-" + Char.M113().cy + "]", 20, GameCanvas.h - 230, mFont.LEFT, mFont.tahoma_7b_dark);
		mFont.bigNumber_red.M898(g, "MẠNH CRIS", 260, 12, mFont.CENTER);
		mFont.bigNumber_While.M898(g, "--> shop manhcr7.com <--", 260, 25, mFont.CENTER);
		string st = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
		mFont.tahoma_7_white.M902(g, st, 20, GameCanvas.h - 220, mFont.LEFT, mFont.tahoma_7b_dark);
		mFont.tahoma_7_blue1Small.M898(g, "Mod by Mạnh Cris", 86, 28, mFont.LEFT);
		int num = GameCanvas.h - 200;
		if (isConnectToAccountManager)
		{
			mFont.tahoma_7.M898(g, "Đã kết nối!", 25, num, 0);
			num += 10;
		}
		if (GameAutomationController.isAutoSendAttack)
		{
			mFont.tahoma_7.M898(g, "Tự đánh: on", 25, num, 0);
			num += 10;
		}
		if (isAutoRevive)
		{
			mFont.tahoma_7.M898(g, "Hồi sinh: on", 25, num, 0);
			num += 10;
		}
		if (AutoPickItem.isAutoPick)
		{
			mFont.tahoma_7.M898(g, "Auto nhặt: on", 25, num, 0);
			num += 10;
		}
		if (isLockFocus)
		{
			mFont.tahoma_7.M898(g, "Khóa: " + charIDLock, 25, num, 0);
			num += 10;
		}
		if (isAutoEnterNRDMap)
		{
			mFont.tahoma_7.M898(g, "Đang auto nrd: " + mapIdNRD + "sk" + zoneIdNRD, 25, num, 0);
			num += 10;
		}
	}

	public static void M2165(mGraphics g)
	{
		int num = (M2184() ? 35 : 95);
		widthRect = 180;
		heightRect = 9;
		for (int i = 0; i < listCharsInMap.Count; i++)
		{
			Char t = listCharsInMap[i];
			g.M937(2721889, 0.5f);
			g.M932(GameCanvas.w - widthRect - 7, num + 2, widthRect - 2, heightRect);
			if (t.cName == null || !(t.cName != "") || t.isPet || t.isMiniPet || t.cName.StartsWith("#") || t.cName.StartsWith("$") || !(t.cName != "Trọng tài"))
			{
				continue;
			}
			if (t.isNRD)
			{
				M2167(g, t);
			}
			int num2 = GameCanvas.w - widthRect - 5;
			int num3 = num2;
			int num4 = num3 + mFont.tahoma_7.M909(i + 1 + ". ");
			bool flag = M2189(t);
			if (Char.M113().charFocus != null && Char.M113().charFocus.cName == t.cName)
			{
				g.M933(14155776);
				g.M928(Char.M113().cx - GameScr.cmx, Char.M113().cy - GameScr.cmy + 1, t.cx - GameScr.cmx, t.cy - GameScr.cmy);
				mFont.tahoma_7b_red.M898(g, i + 1 + ". ", num3, num, 0);
				mFont.tahoma_7b_red.M898(g, t.cName, num4, num, 0);
				int num5 = num4 + mFont.tahoma_7b_red.M909(t.cName + " [");
				mFont.tahoma_7b_red.M898(g, " [", num4 + mFont.tahoma_7b_red.M909(t.cName), num, 0);
				mFont.tahoma_7b_red.M898(g, NinjaUtil.M1192(t.cHP), num5, num, 0);
				string text = "/" + M2166(t.cHPFull);
				int num6 = num5 + mFont.tahoma_7b_red.M909(NinjaUtil.M1192(t.cHP));
				mFont.tahoma_7.M898(g, text, num6, num, 0);
				if (!flag)
				{
					int num7 = num6 + mFont.tahoma_7.M909(text);
					mFont.tahoma_7b_red.M898(g, " - ", num7, num, 0);
					mFont.tahoma_7b_red.M898(g, t.M264(), num7 + mFont.tahoma_7b_red.M909(" - "), num, 0);
				}
				int x = (flag ? (num6 + mFont.tahoma_7.M909(text)) : (num6 + mFont.tahoma_7.M909(text) + mFont.tahoma_7b_red.M909(" - " + t.M264())));
				mFont.tahoma_7b_red.M898(g, "]", x, num, 0);
			}
			else if (flag)
			{
				g.M933(16383818);
				g.M928(Char.M113().cx - GameScr.cmx, Char.M113().cy - GameScr.cmy + 1, t.cx - GameScr.cmx, t.cy - GameScr.cmy);
				mFont.tahoma_7_red.M898(g, i + 1 + ". ", num3, num, 0);
				mFont.tahoma_7_red.M898(g, t.cName, num4, num, 0);
				int num8 = num4 + mFont.tahoma_7_red.M909(t.cName + " [");
				mFont.tahoma_7_red.M898(g, " [", num4 + mFont.tahoma_7_red.M909(t.cName), num, 0);
				mFont.tahoma_7_red.M898(g, NinjaUtil.M1192(t.cHP), num8, num, 0);
				string text2 = "/" + M2166(t.cHPFull);
				int num9 = num8 + mFont.tahoma_7_red.M909(NinjaUtil.M1192(t.cHP));
				mFont.tahoma_7.M898(g, text2, num9, num, 0);
				int x2 = num9 + mFont.tahoma_7.M909(text2);
				mFont.tahoma_7_red.M898(g, "]", x2, num, 0);
			}
			else if (t.cHPFull > 100000000 && t.cHP > 0 && M2184() && !t.isNRD)
			{
				mFont.tahoma_7b_red.M898(g, i + 1 + ". ", num3, num, 0);
				mFont.tahoma_7b_red.M898(g, t.cName, num4, num, 0);
				int num10 = num4 + mFont.tahoma_7b_red.M909(t.cName + " [");
				mFont.tahoma_7b_red.M898(g, " [", num4 + mFont.tahoma_7b_red.M909(t.cName), num, 0);
				mFont.tahoma_7b_red.M898(g, NinjaUtil.M1192(t.cHP), num10, num, 0);
				string text3 = "/" + M2166(t.cHPFull);
				int num11 = num10 + mFont.tahoma_7b_red.M909(NinjaUtil.M1192(t.cHP));
				mFont.tahoma_7.M898(g, text3, num11, num, 0);
				int num12 = num11 + mFont.tahoma_7.M909(text3);
				mFont.tahoma_7b_red.M898(g, " - ", num12, num, 0);
				mFont.tahoma_7b_red.M898(g, t.M264(), num12 + mFont.tahoma_7b_red.M909(" - "), num, 0);
				int x3 = num12 + mFont.tahoma_7b_red.M909(" - " + t.M264());
				mFont.tahoma_7b_red.M898(g, "]", x3, num, 0);
			}
			else
			{
				mFont.tahoma_7.M898(g, i + 1 + ". ", num3, num, 0);
				mFont.tahoma_7_white.M898(g, t.cName, num4, num, 0);
				int num13 = num4 + mFont.tahoma_7.M909(t.cName + " [");
				mFont.tahoma_7.M898(g, " [", num4 + mFont.tahoma_7.M909(t.cName), num, 0);
				mFont.tahoma_7_red.M898(g, NinjaUtil.M1192(t.cHP), num13, num, 0);
				string text4 = "/" + M2166(t.cHPFull);
				int num14 = num13 + mFont.tahoma_7.M909(NinjaUtil.M1192(t.cHP));
				mFont.tahoma_7.M898(g, text4, num14, num, 0);
				int num15 = num14 + mFont.tahoma_7.M909(text4);
				mFont.tahoma_7.M898(g, " - ", num15, num, 0);
				mFont.tahoma_7.M898(g, t.M264(), num15 + mFont.tahoma_7.M909(" - "), num, 0);
				int x4 = num15 + mFont.tahoma_7.M909(" - " + t.M264());
				mFont.tahoma_7.M898(g, "]", x4, num, 0);
			}
			num += heightRect + 1;
		}
	}

	public static string M2166(long number)
	{
		if (number >= 1000000L)
		{
			return $"{(double)number / 1000000.0:0.0}m";
		}
		if (number >= 1000L)
		{
			return $"{(double)number / 1000.0:0.0}k";
		}
		return number.ToString();
	}

	public static void M2167(mGraphics g, Char ch)
	{
		mFont.tahoma_7b_red.M898(g, ch.cName + " [" + NinjaUtil.M1192(ch.cHP) + "/" + NinjaUtil.M1192(ch.cHPFull) + "]", GameCanvas.w / 2, 62, 2);
		int num = 72;
		int num2 = 10;
		if (ch.isNRD)
		{
			mFont.tahoma_7b_red.M898(g, "Còn: " + ch.timeNRD + " giây", GameCanvas.w / 2, num, 2);
			num += num2;
		}
		if (ch.isFreez)
		{
			mFont.tahoma_7b_red.M898(g, "Bị TDHS: " + ch.freezSeconds + " giây", GameCanvas.w / 2, num, 2);
			num += num2;
		}
	}

	public static void M2168(mGraphics g, int x, int y)
	{
	}

	public static void M2169(mGraphics g)
	{
		if (isHuntingBoss && !M2184())
		{
			int num = 42;
			for (int i = 0; i < listBosses.Count; i++)
			{
				g.M937(2721889, 0.5f);
				g.M932(GameCanvas.w - 23, num + 2, 21, 9);
				listBosses[i].M2161(g, GameCanvas.w - 2, num, mFont.RIGHT);
				num += 10;
			}
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (ChatTextField.M279().tfChat.M1924() == null || ChatTextField.M279().tfChat.M1924().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
		{
			ChatTextField.M279().isShow = false;
			M2178();
		}
		else if (ChatTextField.M279().strChat.Equals(inputLockFocusCharID[0]))
		{
			try
			{
				int num = (charIDLock = int.Parse(ChatTextField.M279().tfChat.M1924()));
				isLockFocus = true;
				GameScr.info1.M762("Đã Thêm: " + num, 0);
			}
			catch
			{
				GameScr.info1.M762("CharID Không Hợp Lệ, Vui Lòng Nhập Lại", 0);
			}
			M2178();
		}
		else if (ChatTextField.M279().strChat.Equals(inputHPFusionDance[0]))
		{
			try
			{
				int num2 = (minimumHPFusionDance = int.Parse(ChatTextField.M279().tfChat.M1924()));
				GameScr.info1.M762("Hợp Thể Khi HP Dưới: " + Res.M1533(num2), 0);
			}
			catch
			{
				GameScr.info1.M762("HP Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
			}
			M2178();
		}
		else if (ChatTextField.M279().strChat.Equals(inputCharID[0]))
		{
			try
			{
				int item = int.Parse(ChatTextField.M279().tfChat.M1924());
				listCharIDs.Add(item);
				GameScr.info1.M762("Đã Thêm: " + item, 0);
			}
			catch
			{
				GameScr.info1.M762("CharID Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
			}
			M2178();
		}
		else if (ChatTextField.M279().strChat.Equals(inputHPLimit[0]))
		{
			try
			{
				int num3 = (HPLimit = int.Parse(ChatTextField.M279().tfChat.M1924()));
				GameScr.info1.M762("Limit: " + NinjaUtil.M1192(num3) + " HP", 0);
			}
			catch
			{
				GameScr.info1.M762("HP Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
			}
			M2178();
		}
		else if (ChatTextField.M279().strChat.Equals(inputHPChar[0]))
		{
			try
			{
				int num4 = (limitHPChar = int.Parse(ChatTextField.M279().tfChat.M1924()));
				GameScr.info1.M762("Limit: " + NinjaUtil.M1192(num4) + " HP", 0);
			}
			catch
			{
				GameScr.info1.M762("HP Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
			}
			M2178();
		}
		else
		{
			if (!ChatTextField.M279().strChat.Equals(inputHPPercentFusionDance[0]))
			{
				return;
			}
			try
			{
				int num5 = int.Parse(ChatTextField.M279().tfChat.M1924());
				if (num5 > 99)
				{
					num5 = 99;
				}
				minumumHPPercentFusionDance = num5;
				GameScr.info1.M762("Hợp Thể Khi HP Dưới: " + num5 + "%", 0);
			}
			catch
			{
				GameScr.info1.M762("%HP Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
			}
			M2178();
		}
	}

	public void onCancelChat()
	{
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 100:
			Application.OpenURL("https://www.facebook.com/zmanhcr7");
			break;
		case 101:
			autoLogin = !autoLogin;
			GameScr.info1.M762("Auto login :" + (autoLogin ? "Bật" : "Tắt"), 0);
			break;
		case 102:
			Application.OpenURL("https://manhcr7.com/home_page");
			break;
		case 103:
			Application.OpenURL("https://manhcr7.com/data-nro");
			break;
		case 1:
			MapNavigationSystem.M2061();
			break;
		case 2:
			GameAutomationController.M2129();
			break;
		case 3:
			AutoPeanManager.M2094();
			break;
		case 4:
			AutoPickItem.M2108();
			break;
		case 5:
			AutoCombatSystem.M2150();
			break;
		case 6:
			AutoChatManager.M2039();
			break;
		case 7:
			AutoPotentialEnhancer.M2120();
			break;
		case 8:
			M2173();
			break;
		case 9:
			if (minumumHPPercentFusionDance > 0)
			{
				minumumHPPercentFusionDance = 0;
				GameScr.info1.M762("Hợp thể khi HP dưới: 0% HP", 0);
			}
			else
			{
				ChatTextField.M279().strChat = inputHPPercentFusionDance[0];
				ChatTextField.M279().tfChat.name = inputHPPercentFusionDance[1];
				ChatTextField.M279().M282(M2162(), string.Empty);
			}
			break;
		case 10:
			if (minimumHPFusionDance > 0)
			{
				minimumHPFusionDance = 0;
				GameScr.info1.M762("Hợp thể khi HP dưới: 0", 0);
			}
			else
			{
				ChatTextField.M279().strChat = inputHPFusionDance[0];
				ChatTextField.M279().tfChat.name = inputHPFusionDance[1];
				ChatTextField.M279().M282(M2162(), string.Empty);
			}
			break;
		case 11:
			M2176();
			break;
		case 12:
			isAutoLockControl = !isAutoLockControl;
			GameScr.info1.M762("Auto Khống Chế\n" + (isAutoLockControl ? "[ON]" : "[OFF]"), 0);
			break;
		case 13:
			isAutoTeleport = !isAutoTeleport;
			GameScr.info1.M762("Auto Teleport\n" + (isAutoTeleport ? "[ON]" : "[OFF]"), 0);
			break;
		case 14:
			M2177();
			break;
		case 15:
			ChatTextField.M279().strChat = inputCharID[0];
			ChatTextField.M279().tfChat.name = inputCharID[1];
			ChatTextField.M279().M282(M2162(), string.Empty);
			break;
		case 16:
		{
			int num2 = (int)p;
			if (num2 != 0)
			{
				listCharIDs.Add(num2);
				GameScr.info1.M762("Đã Thêm: " + num2, 0);
			}
			break;
		}
		case 17:
		{
			int num = (int)p;
			if (num != 0)
			{
				listCharIDs.Remove(num);
				GameScr.info1.M762("Đã Xóa: " + num, 0);
			}
			break;
		}
		case 18:
			M2174();
			break;
		case 19:
			isAutoAttackBoss = !isAutoAttackBoss;
			GameScr.info1.M762("Tấn Công Boss\n" + (isAutoAttackBoss ? "[ON]" : "[OFF]"), 0);
			break;
		case 20:
			ChatTextField.M279().strChat = inputHPLimit[0];
			ChatTextField.M279().tfChat.name = inputHPLimit[1];
			ChatTextField.M279().M282(M2162(), string.Empty);
			break;
		case 21:
			M2175();
			break;
		case 22:
			isAutoAttackOtherChars = !isAutoAttackOtherChars;
			GameScr.info1.M762("Tàn Sát Người\n" + (isAutoAttackOtherChars ? "[ON]" : "[OFF]"), 0);
			break;
		case 23:
			ChatTextField.M279().strChat = inputHPChar[0];
			ChatTextField.M279().tfChat.name = inputHPChar[1];
			ChatTextField.M279().M282(M2162(), string.Empty);
			break;
		case 24:
			GameScr.info1.M762("Hihi Mạnh đếu biết làm ! Tính sau đi !", 0);
			break;
		case 25:
			GameScr.info1.M762("Hihi Mạnh đếu biết làm ! Tính sau đi !", 0);
			break;
		case 26:
			GameScr.info1.M762("Hihi Mạnh đếu biết làm ! Tính sau đi !", 0);
			break;
		case 27:
			GameScr.info1.M762("Hihi Mạnh đếu biết làm ! Tính sau đi !", 0);
			break;
		case 28:
			GameScr.info1.M762("Hihi Mạnh đếu biết làm ! Tính sau đi !", 0);
			break;
		case 29:
			isHuntingBoss = !isHuntingBoss;
			Rms.M1543("sanboss", isHuntingBoss ? 1 : 0);
			break;
		case 30:
			isShowCharsInMap = !isShowCharsInMap;
			Rms.M1543("showchar", isShowCharsInMap ? 1 : 0);
			break;
		case 31:
			GameScr.info1.M762("Hihi Mạnh đếu biết làm ! Tính sau đi !", 0);
			break;
		case 32:
			isAutoT77 = !isAutoT77;
			GameScr.info1.M762("Auto T77\n" + (isAutoT77 ? "[STATUS: ON] " : "[STATUS: OFF]"), 0);
			break;
		case 33:
			isAutoBomPicPoc = !isAutoBomPicPoc;
			GameScr.info1.M762("Auto Bom\nPic Poc" + (isAutoBomPicPoc ? "[ON] " : "[OFF]"), 0);
			break;
		case 34:
			AutoActionController.M2221();
			break;
		}
	}

	public static void M2170()
	{
		try
		{
			sbyte b = 0;
			while (true)
			{
				if (b < Char.M113().arrItemBag.Length)
				{
					if (Char.M113().arrItemBag[b].template.id == 454)
					{
						break;
					}
					b++;
					continue;
				}
				return;
			}
			Service.M1594().M1615(0, 1, b, -1);
		}
		catch (Exception)
		{
			GameScr.info1.M762("Mạnh Cris: bạn dell có bông tai !", 0);
		}
	}

	public static bool M2171(int unused)
	{
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.A)
		{
			GameAutomationController.isAutoSendAttack = !GameAutomationController.isAutoSendAttack;
			GameScr.info1.M762("Tự Đánh\n" + (GameAutomationController.isAutoSendAttack ? "[ON]" : "[OFF]"), 0);
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.B)
		{
			Service.M1594().M1608(0, -1);
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.C)
		{
			for (int i = 0; i < Char.M113().arrItemBag.Length; i++)
			{
				Item t = Char.M113().arrItemBag[i];
				if (t != null && (t.template.id == 194 || t.template.id == 193))
				{
					Service.M1594().M1615(0, 1, (sbyte)t.indexUI, -1);
					break;
				}
			}
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.D)
		{
			GameAutomationController.M2147();
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.E)
		{
			isAutoRevive = !isAutoRevive;
			GameScr.info1.M762("Auto Hồi Sinh\n" + (isAutoRevive ? "[ON]" : "[OFF]"), 0);
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.F)
		{
			M2170();
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.G)
		{
			if (Char.M113().charFocus == null)
			{
				GameScr.info1.M762("Vui Lòng Chọn Mục Tiêu!", 0);
			}
			else
			{
				Service.M1594().M1601(0, Char.M113().charFocus.charID, -1, -1);
				GameScr.info1.M762("Đã Gửi Lời Mời Giao Dịch Đến: " + Char.M113().charFocus.cName, 0);
			}
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.I)
		{
			isLockFocus = !isLockFocus;
			if (!isLockFocus)
			{
				GameScr.info1.M762("Khoá Mục Tiêu\n[OFF]", 0);
			}
			else if (Char.M113().charFocus == null)
			{
				GameScr.info1.M762("Vui Lòng Chọn Mục Tiêu!", 0);
			}
			else
			{
				charIDLock = Char.M113().charFocus.charID;
				GameScr.info1.M762("Đã Khóa: " + Char.M113().charFocus.cName, 0);
			}
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.J)
		{
			MapNavigationSystem.M2067();
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.K)
		{
			MapNavigationSystem.M2068();
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.L)
		{
			MapNavigationSystem.M2069();
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.M)
		{
			Service.M1594().M1654();
			GameCanvas.panel.M1276();
			GameCanvas.panel.M1285();
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.N)
		{
			if (M2184())
			{
				AutoPickItem.isAutoPick = !AutoPickItem.isAutoPick;
				GameScr.info1.M762("Auto Nhặt\n" + (AutoPickItem.isAutoPick ? "[ON]" : "[OFF]"), 0);
			}
			else
			{
				AutoPickItem.M2108();
			}
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.O)
		{
			isAutoEnterNRDMap = !isAutoEnterNRDMap;
			isOpenMenuNPC = true;
			GameScr.info1.M762("Auto Vào NRD\n" + (isAutoEnterNRDMap ? "[ON]" : "[OFF]"), 0);
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.P)
		{
			if (!ItemTime.M839(4387))
			{
				if (AutoActionController.M2239(521))
				{
					if (AutoActionController.M2240() == 0)
					{
						GameScr.info1.M762("TDLT đã hết thời gian", 0);
						AutoActionController.DoBoss2 = false;
					}
				}
				else
				{
					GameScr.info1.M762("Không tìm thấy TDLT", 0);
					AutoActionController.DoBoss2 = false;
				}
			}
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.T)
		{
			M2179(521);
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.X)
		{
			M2172();
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.Z)
		{
			if (Char.M113().cFlag == 0)
			{
				Service.M1594().M1726(1, 8);
				GameScr.info1.M762("Đã gửi yêu cầu bật cờ đen", 0);
			}
			else
			{
				Service.M1594().M1726(1, 0);
				GameScr.info1.M762("Đã gửi yêu cầu tắt cờ", 0);
			}
			return true;
		}
		if (GameCanvas.keyAsciiPress == AsciiAlphabetConstants.S)
		{
			AutoActionController.aGimBoss = !AutoActionController.aGimBoss;
			new Thread(AutoActionController.M2233).Start();
			GameScr.info1.M762("Auto gim boss: " + (AutoActionController.aGimBoss ? "Bật" : "Tắt"), 0);
		}
		return false;
	}

	public static void M2172()
	{
		MyVector t = new MyVector();
		t.M1111(new Command("Auto Map", M2162(), 1, null));
		t.M1111(new Command("Auto ManhCr7", M2162(), 34, null));
		t.M1111(new Command("Auto Skill", M2162(), 2, null));
		t.M1111(new Command("Auto Pean", M2162(), 3, null));
		t.M1111(new Command("Auto Pick", M2162(), 4, null));
		t.M1111(new Command("Auto Train", M2162(), 5, null));
		t.M1111(new Command("Auto Chat", M2162(), 6, null));
		t.M1111(new Command("More", M2162(), 8, null));
		GameCanvas.menu.M877(t, 3);
	}

	public static void M2173()
	{
		MyVector t = new MyVector();
		t.M1111(new Command("Thông Báo\nBoss\n" + (isHuntingBoss ? "[ON] " : "[OFF]"), M2162(), 29, null));
		t.M1111(new Command("Danh Sách\nNgười Trong Map\n" + (isShowCharsInMap ? "[ON] " : "[OFF]"), M2162(), 30, null));
		t.M1111(new Command("Auto Login: " + (autoLogin ? "ON" : "OFF"), M2162(), 101, null));
		t.M1111(new Command("Auto Point", M2162(), 7, null));
		t.M1111(new Command("Facebook Mạnh Cris", M2162(), 100, null));
		t.M1111(new Command("Web xem id vật phẩm", M2162(), 103, null));
		t.M1111(new Command("Cập nhập phiên bản", M2162(), 102, null));
		GameCanvas.menu.M877(t, 3);
	}

	public static void M2174()
	{
	}

	public static void M2175()
	{
	}

	public static void M2176()
	{
	}

	public static void M2177()
	{
	}

	public static void M2178()
	{
		ChatTextField.M279().strChat = "Chat";
		ChatTextField.M279().tfChat.name = "chat";
		ChatTextField.M279().isShow = false;
	}

	public static void M2179(int templateId)
	{
		int num = 0;
		Item t;
		while (true)
		{
			if (num < Char.M113().arrItemBag.Length)
			{
				t = Char.M113().arrItemBag[num];
				if (t != null && t.template.id == templateId)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Service.M1594().M1615(0, 1, (sbyte)t.indexUI, -1);
	}

	public static void M2180(int x, int y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Char.M113().cx = x;
		Char.M113().cy = y;
		Service.M1594().M1640();
		Char.M113().cx = x;
		Char.M113().cy = y + 1;
		Service.M1594().M1640();
		Char.M113().cx = x;
		Char.M113().cy = y;
		Service.M1594().M1640();
	}

	public static int M2181(int x)
	{
		int num = 50;
		int num2 = 0;
		while (num2 < 30)
		{
			num2++;
			num += 24;
			if (TileMap.M1958(x, num, 2))
			{
				if (num % 24 != 0)
				{
					num -= num % 24;
				}
				break;
			}
		}
		return num;
	}

	public static void M2182()
	{
		if (Char.M113().luong + Char.M113().luongKhoa > 0 && Char.M113().meDead && Char.M113().cHP <= 0 && GameCanvas.gameTick % 20 == 0)
		{
			Service.M1594().M1673();
			Char.M113().meDead = false;
			Char.M113().statusMe = 1;
			Char.M113().cHP = Char.M113().cHPFull;
			Char.M113().cMP = Char.M113().cMPFull;
			Char t = Char.M113();
			Char t2 = Char.M113();
			Char.M113().cp3 = 0;
			t2.cp2 = 0;
			t.cp1 = 0;
			ServerEffect.M1574(109, Char.M113(), 2);
			GameScr.M559().center = null;
			GameScr.isHaveSelectSkill = true;
		}
	}

	public static void M2183(int charId)
	{
		int num = 0;
		Char t;
		while (true)
		{
			if (num < GameScr.vCharInMap.M1113())
			{
				t = (Char)GameScr.vCharInMap.M1114(num);
				if (!t.isMiniPet && !t.isPet && t.charID == charId)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		Char.M113().mobFocus = null;
		Char.M113().npcFocus = null;
		Char.M113().itemFocus = null;
		Char.M113().charFocus = t;
	}

	public static bool M2184()
	{
		if (TileMap.mapID >= 85)
		{
			return TileMap.mapID <= 91;
		}
		return false;
	}

	public static void M2185()
	{
	}

	public static void M2186()
	{
	}

	public static bool M2187(int int_0)
	{
		return list_0.Contains(int_0);
	}

	public static void M2188()
	{
		if (Char.M113().charFocus != null)
		{
			M2180(Char.M113().charFocus.cx, Char.M113().charFocus.cy);
		}
		else if (Char.M113().itemFocus != null)
		{
			M2180(Char.M113().itemFocus.x, Char.M113().itemFocus.y);
		}
		else if (Char.M113().mobFocus != null)
		{
			M2180(Char.M113().mobFocus.x, Char.M113().mobFocus.y);
		}
		else if (Char.M113().npcFocus != null)
		{
			M2180(Char.M113().npcFocus.cx, Char.M113().npcFocus.cy - 3);
		}
		else
		{
			GameScr.info1.M762("Không Có Mục Tiêu!", 0);
		}
	}

	public static bool M2189(Char ch)
	{
		if (ch.cName != null && ch.cName != "" && !ch.isPet && !ch.isMiniPet && char.IsUpper(char.Parse(ch.cName.Substring(0, 1))) && ch.cName != "Trọng tài" && !ch.cName.StartsWith("#"))
		{
			return !ch.cName.StartsWith("$");
		}
		return false;
	}

	public static void M2190()
	{
		if (isOpenMenuNPC && (TileMap.mapID == 24 || TileMap.mapID == 25 || TileMap.mapID == 26) && GameCanvas.gameTick % 20 == 0)
		{
			Service.M1594().M1656(29);
			Service.M1594().M1655(29, 1);
			if (GameCanvas.panel.mapNames != null && GameCanvas.panel.mapNames.Length > 6 && GameCanvas.panel.mapNames[mapIdNRD - 1] == nameMapsNRD[mapIdNRD - 1])
			{
				Service.M1594().M1721(mapIdNRD - 1);
				isOpenMenuNPC = false;
			}
		}
		if (M2184() && !Char.isLoadingMap && !Controller.isStopReadMessage && GameCanvas.gameTick % 20 == 0)
		{
			Service.M1594().M1638(zoneIdNRD, -1);
			isAutoEnterNRDMap = false;
			isOpenMenuNPC = true;
		}
	}

	public static void M2191()
	{
	}

	public static void M2192()
	{
	}

	public static int M2193()
	{
		return (int)(Char.M113().cHP * 100L / Char.M113().cHPFull);
	}

	public static bool M2194(int percent)
	{
		if (Char.M113().cHP > 0)
		{
			return M2193() < percent;
		}
		return false;
	}

	public static void M2195()
	{
	}

	public static void M2196()
	{
	}

	public static void M2197()
	{
	}

	public static int M2198()
	{
		return 2000000000;
	}

	public static string M2199(int flagId)
	{
		if (flagId == -1 || flagId == 0)
		{
			return "";
		}
		string text = "";
		switch (flagId)
		{
		case 1:
			text = "Cờ xanh";
			break;
		case 2:
			text = "Cờ đỏ";
			break;
		case 3:
			text = "Cờ tím";
			break;
		case 4:
			text = "Cờ vàng";
			break;
		case 5:
			text = "Cờ lục";
			break;
		case 6:
			text = "Cờ hồng";
			break;
		case 7:
			text = "Cờ cam";
			break;
		case 8:
			text = "Cờ đen";
			break;
		case 9:
			text = "Cờ Kaio";
			break;
		case 10:
			text = "Cờ Mabu";
			break;
		case 11:
			text = "Cờ xanh dương";
			break;
		}
		if (!text.Equals(""))
		{
			return "(" + text + ") ";
		}
		return text;
	}

	public static void M2200()
	{
		M2201();
		isHuntingBoss = Rms.M1542("sanboss") == 1;
		isShowCharsInMap = Rms.M1542("showchar") == 1;
		if (mGraphics.zoomLevel == 2)
		{
			try
			{
				logoGameScreen = Image.M721(Convert.FromBase64String(ManhCr7Logo.logoManhCr7));
				logoServerListScreen = Image.M721(Convert.FromBase64String(ManhCr7Logo.logoManhCr7));
			}
			catch
			{
			}
		}
		if (mGraphics.zoomLevel == 1)
		{
			try
			{
				logoServerListScreen = Image.M721(Convert.FromBase64String(ManhCr7Logo.logoManhCr7));
				logoGameScreen = Image.M721(Convert.FromBase64String(ManhCr7Logo.logoManhCr7));
			}
			catch
			{
			}
		}
		try
		{
			APIKey = File.ReadAllText("Data\\keyAPI.ini");
			APIServer = File.ReadAllText("Data\\serverAPI.ini");
		}
		catch
		{
		}
		new Thread(M2207).Start();
	}

	public static void M2201()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		listFlagColor.Add(Color.black);
		listFlagColor.Add(new Color(0f, 0.99609375f, 0.99609375f));
		listFlagColor.Add(Color.red);
		listFlagColor.Add(new Color(0.54296875f, 0f, 0.54296875f));
		listFlagColor.Add(Color.yellow);
		listFlagColor.Add(Color.green);
		listFlagColor.Add(new Color(0.99609375f, 0.51171875f, 125f / 128f));
		listFlagColor.Add(new Color(0.80078125f, 51f / 128f, 0f));
		listFlagColor.Add(Color.black);
		listFlagColor.Add(Color.blue);
		listFlagColor.Add(Color.red);
		listFlagColor.Add(Color.blue);
	}

	public static void M2202()
	{
		if (listCharsInMap.Count <= 2)
		{
			return;
		}
		List<Char> list = new List<Char>();
		while (listCharsInMap.Count != 0)
		{
			Char t = listCharsInMap[0];
			list.Add(t);
			string text = t.M265();
			listCharsInMap.RemoveAt(0);
			for (int i = 0; i < listCharsInMap.Count; i++)
			{
				Char t2 = listCharsInMap[i];
				if (text == t2.M265())
				{
					list.Add(t2);
					listCharsInMap.RemoveAt(i);
					i--;
				}
			}
		}
		listCharsInMap.Clear();
		listCharsInMap = list;
	}

	public static void M2203()
	{
		string path = Path.GetTempPath() + "koi occtiu957\\mod 222\\auto";
		if (mSystem.M1054() - lastTimeConnected >= 3500L && File.Exists(path))
		{
			string text = File.ReadAllText(path);
			new Thread((ThreadStart)delegate
			{
				M2206(int.Parse(text));
			}).Start();
			lastTimeConnected = mSystem.M1054();
		}
	}

	public static bool M2204(Item item)
	{
		int id = item.template.id;
		if (id != 450 && id != 630 && id != 631 && id != 632 && id != 878 && id != 879)
		{
			if (id >= 386)
			{
				return id <= 394;
			}
			return false;
		}
		return true;
	}

	public static void M2205()
	{
		isUsingCapsule = true;
		for (int i = 0; i < Char.M113().arrItemBag.Length; i++)
		{
			Item t = Char.M113().arrItemBag[i];
			if (t != null && (t.template.id == 194 || t.template.id == 193))
			{
				Service.M1594().M1615(0, 1, (sbyte)t.indexUI, -1);
				break;
			}
		}
		Thread.Sleep(500);
		Service.M1594().M1721(0);
		Thread.Sleep(1000);
		isUsingCapsule = false;
	}

	public static void M2206(int skillIndex)
	{
		if (!isUsingSkill)
		{
			isUsingSkill = true;
			if (Char.M113().myskill != GameScr.keySkill[skillIndex])
			{
				GameScr.M559().M601(GameScr.keySkill[skillIndex], isShortcut: true);
				Thread.Sleep(200);
				GameScr.M559().M601(GameScr.keySkill[skillIndex], isShortcut: true);
				isUsingSkill = false;
			}
			else
			{
				GameScr.M559().M601(GameScr.keySkill[skillIndex], isShortcut: true);
				isUsingSkill = false;
			}
		}
	}

	public static void M2207()
	{
		try
		{
			string[] array = Environment.GetCommandLineArgs()[1].Split('|');
			account = array[1];
			server = int.Parse(array[2]);
			password = M2214(array[3], "ud");
			new Thread(M2208).Start();
		}
		catch
		{
			account = "";
		}
	}

	public static void M2208()
	{
		Thread.Sleep(1000);
		while (true)
		{
			try
			{
				if (string.IsNullOrEmpty(Char.M113().cName))
				{
					Thread.Sleep(100);
					while (!ServerListScreen.loadScreen)
					{
						Thread.Sleep(10);
					}
					Thread.Sleep(500);
					Rms.M1538("acc", "Mạnh Cr7");
					Rms.M1538("pass", "nhin clmm");
					Thread.Sleep(500);
					Rms.M1543("svselect", server - 1);
					ServerListScreen.ipSelect = server - 1;
					if (server <= 20)
					{
						GameCanvas.serverScreen.M1582();
						while (!ServerListScreen.loadScreen)
						{
							Thread.Sleep(10);
						}
						while (!Session_ME.M1744().isConnected())
						{
							Thread.Sleep(100);
						}
						Thread.Sleep(100);
						while (!ServerListScreen.loadScreen)
						{
							Thread.Sleep(10);
						}
					}
					Thread.Sleep(1000);
					GameCanvas.serverScreen.perform(3, null);
					Thread.Sleep(1000);
					GameCanvas.gameTick = 0;
					Thread.Sleep(30000);
				}
			}
			catch
			{
			}
			Thread.Sleep(5000);
		}
	}

	public static void M2209()
	{
		isSlovingCapcha = true;
		Thread.Sleep(1000);
		try
		{
			WebClient webClient = new WebClient();
			NameValueCollection data = new NameValueCollection
			{
				["merchant_key"] = APIKey,
				["type"] = "19",
				["image"] = Convert.ToBase64String(GameScr.imgCapcha.texture.EncodeToPNG())
			};
			Thread.Sleep(500);
			byte[] bytes = webClient.UploadValues(APIServer, data);
			string @string = Encoding.Default.GetString(bytes);
			Thread.Sleep(500);
			if (@string.Contains("\"message\":\"success\"") && @string.Contains("\"success\":true"))
			{
				string text = @string.Split(':')[3].Split('"')[1].Trim();
				Thread.Sleep(500);
				if (text.Length >= 4 && text.Length <= 7)
				{
					for (int i = 0; i < text.Length; i++)
					{
						Service.M1594().M1607(text[i]);
						Thread.Sleep(Res.M1522(500, 700));
					}
					Thread.Sleep(3000);
				}
			}
		}
		catch
		{
			Thread.Sleep(3000);
		}
		Thread.Sleep(1000);
		if (GameScr.M559().mobCapcha != null)
		{
			Thread.Sleep(3000);
		}
		isSlovingCapcha = false;
	}

	public static void M2210()
	{
	}

	public static bool M2211(Skill skillToUse)
	{
		if (skillToUse.template.manaUseType == 2)
		{
			return true;
		}
		if (skillToUse.template.manaUseType != 1)
		{
			return Char.M113().cMP >= skillToUse.manaUse;
		}
		return Char.M113().cMP >= skillToUse.manaUse * Char.M113().cMPFull / 100;
	}

	public static void M2212()
	{
	}

	public static void M2213()
	{
	}

	public static string M2214(string str, string key)
	{
		byte[] array = Convert.FromBase64String(str);
		byte[] key2 = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(key));
		byte[] bytes = new TripleDESCryptoServiceProvider
		{
			Key = key2,
			Mode = CipherMode.ECB,
			Padding = PaddingMode.PKCS7
		}.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void M2215()
	{
		Service.M1594().M1656(19);
		Thread.Sleep(4000);
		Service.M1594().M1655(19, 3);
		Thread.Sleep(1000);
		Service.M1594().M1655(19, 1);
	}

	public static void M2216(int x)
	{
		MapNavigationSystem.M2064(x);
		File.WriteAllText(pathfile, resetLoadMapFile);
		RunningGoMapQLTK = false;
	}

	public static void M2217()
	{
		Thread.Sleep(4000);
		GameScr.M559().M677("Shop manhcr7.com chúc anh em chơi game vui vẻ - nhớ ủng hộ sốp nhé !");
	}

	public static void M2218()
	{
		if (autoLogin)
		{
			time_++;
			if (time_ == 150)
			{
				GameCanvas.serverScreen.perform(3, null);
				time_ = 0;
			}
		}
	}

	public static void M2219()
	{
		if (IsUpdateZone && mSystem.M1054() - LAST_TIME_UPDATE_ZONE > TIME_DELAY_UPDATE_ZONE)
		{
			Service.M1594().M1654();
			LAST_TIME_UPDATE_ZONE = mSystem.M1054();
		}
	}
}
