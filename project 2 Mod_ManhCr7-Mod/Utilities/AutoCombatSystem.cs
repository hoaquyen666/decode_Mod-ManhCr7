using System.Collections.Generic;

namespace Utilities;

public class AutoCombatSystem : IActionListener, IChatable
{
	private static AutoCombatSystem _Instance;

	private static bool isAvoidSuperMob;

	private static bool isGoBack;

	private static bool isGobackCoordinate;

	private static int gobackX;

	private static int gobackY;

	private static int gobackMapID;

	private static int gobackZoneID;

	public static bool isAutoTrain;

	private static int minimumMPGoHome;

	private static string[] inputMPPercentGoHome;

	public static List<int> listMobIds;

	public static long lastTimeAddNewMob;

	private static long lastTimeTeleportToMob;

	static AutoCombatSystem()
	{
		listMobIds = new List<int>();
		minimumMPGoHome = 5;
		inputMPPercentGoHome = new string[2] { "Nhập %MP", "%MP" };
	}

	public static AutoCombatSystem M2148()
	{
		if (_Instance == null)
		{
			_Instance = new AutoCombatSystem();
		}
		return _Instance;
	}

	public static void M2149()
	{
		if (GameScr.isAutoPlay && (GameScr.canAutoPlay || isAutoTrain) && GameCanvas.gameTick % 20 == 0)
		{
			M2158();
		}
		if (Char.M113().cStamina <= 5 && GameCanvas.gameTick % 100 == 0)
		{
			M2159();
		}
		if (!isGoBack)
		{
			return;
		}
		if (Char.M113().meDead && GameCanvas.gameTick % 100 == 0)
		{
			Service.M1594().M1672();
		}
		if (M2155())
		{
			int num = 21 + Char.M113().cgender;
			if (TileMap.mapID != num)
			{
				GameScr.isAutoPlay = false;
				Char.M113().mobFocus = null;
				if (GameCanvas.gameTick % 50 == 0)
				{
					MapNavigationSystem.M2064(num);
				}
			}
		}
		else
		{
			if (M2155())
			{
				return;
			}
			if (TileMap.mapID != gobackMapID)
			{
				GameScr.isAutoPlay = false;
				MapNavigationSystem.M2064(gobackMapID);
			}
			if (TileMap.mapID == gobackMapID)
			{
				if (!isGobackCoordinate && GameCanvas.gameTick % 100 == 0)
				{
					GameScr.isAutoPlay = true;
				}
				if (TileMap.zoneID != gobackZoneID && !Char.ischangingMap && !Controller.isStopReadMessage && GameCanvas.gameTick % 100 == 0)
				{
					Service.M1594().M1638(gobackZoneID, -1);
				}
				if (isGobackCoordinate && (Char.M113().cx != gobackX || Char.M113().cy != gobackY) && GameCanvas.gameTick % 100 == 0)
				{
					M2153(gobackX, gobackY);
				}
			}
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (ChatTextField.M279().tfChat.M1924() != null && !ChatTextField.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (ChatTextField.M279().strChat.Equals(inputMPPercentGoHome[0]))
			{
				try
				{
					int num = (minimumMPGoHome = int.Parse(ChatTextField.M279().tfChat.M1924()));
					GameScr.info1.M762("Về Nhà Khi MP Dưới\n[" + num + "%]", 0);
				}
				catch
				{
					GameScr.info1.M762("%MP Không Hợp Lệ, Vui Lòng Nhập Lại", 0);
				}
				M2152();
			}
		}
		else
		{
			ChatTextField.M279().isShow = false;
		}
	}

	public void onCancelChat()
	{
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 1:
		{
			int num = (int)p;
			listMobIds.Clear();
			for (int i = 0; i < GameScr.vMob.M1113(); i++)
			{
				Mob t = (Mob)GameScr.vMob.M1114(i);
				if (!t.isMobMe && t.templateId == num)
				{
					listMobIds.Add(t.mobId);
				}
			}
			M2157();
			break;
		}
		case 2:
		{
			listMobIds.Clear();
			for (int j = 0; j < GameScr.vMob.M1113(); j++)
			{
				Mob t2 = (Mob)GameScr.vMob.M1114(j);
				if (!t2.isMobMe)
				{
					listMobIds.Add(t2.mobId);
				}
			}
			M2157();
			break;
		}
		case 3:
			M2157();
			break;
		case 4:
			isAvoidSuperMob = !isAvoidSuperMob;
			GameScr.info1.M762("Né Siêu Quái\n" + (isAvoidSuperMob ? "[STATUS: OFF]" : "[STATUS: ON]"), 0);
			break;
		case 5:
			M2151();
			break;
		case 6:
			listMobIds.Clear();
			isAutoTrain = false;
			GameScr.info1.M762("Đã Clear Danh Sách Train!", 0);
			break;
		case 7:
			if (Char.M113().mobFocus == null)
			{
				GameScr.info1.M762("Vui Lòng Chọn Quái!", 0);
			}
			if (Char.M113().mobFocus != null)
			{
				listMobIds.Add(Char.M113().mobFocus.mobId);
				GameScr.info1.M762("Đã Thêm Quái: " + Char.M113().mobFocus.mobId, 0);
			}
			break;
		case 8:
			isAutoTrain = false;
			Char.M113().mobFocus = null;
			GameScr.info1.M762("Đã Tắt Auto Train!", 0);
			break;
		case 9:
			if (isGoBack)
			{
				isGoBack = false;
				GameScr.info1.M762("Goback\n[STATUS: OFF]", 0);
			}
			else if (!isGoBack)
			{
				isGobackCoordinate = false;
				isGoBack = true;
				gobackMapID = TileMap.mapID;
				gobackZoneID = TileMap.zoneID;
				GameScr.info1.M762("Goback\n[" + TileMap.mapNames[gobackMapID] + "]\n[" + gobackZoneID + "]", 0);
			}
			break;
		case 10:
			if (isGoBack)
			{
				isGoBack = false;
				GameScr.info1.M762("Goback\n[STATUS: OFF]", 0);
			}
			else if (!isGoBack)
			{
				isGobackCoordinate = true;
				isGoBack = true;
				gobackMapID = TileMap.mapID;
				gobackZoneID = TileMap.zoneID;
				gobackX = Char.M113().cx;
				gobackY = Char.M113().cy;
				GameScr.info1.M762("Goback Tọa Độ\n[" + gobackX + "-" + gobackY + "]", 0);
			}
			break;
		case 11:
			ChatTextField.M279().strChat = inputMPPercentGoHome[0];
			ChatTextField.M279().tfChat.name = inputMPPercentGoHome[1];
			ChatTextField.M279().M282(M2148(), string.Empty);
			break;
		}
	}

	public static void M2150()
	{
		MyVector t = new MyVector();
		List<Mob> list = new List<Mob>();
		if (isAutoTrain && !GameScr.canAutoPlay)
		{
			t.M1111(new Command("Tắt Auto Train", M2148(), 8, null));
		}
		for (int i = 0; i < GameScr.vMob.M1113(); i++)
		{
			Mob t2 = (Mob)GameScr.vMob.M1114(i);
			if (t2.isMobMe)
			{
				continue;
			}
			bool flag = false;
			for (int j = 0; j < list.Count; j++)
			{
				if (t2.templateId == list[j].templateId)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(t2);
				t.M1111(new Command("Tàn Sát\n" + t2.M998().name + "\n[" + NinjaUtil.M1192(t2.maxHp) + "HP]", M2148(), 1, t2.templateId));
			}
		}
		t.M1111(new Command("Tàn Sát Tất Cả", M2148(), 2, null));
		t.M1111(new Command("Tàn Sát Theo Vị Trí", M2148(), 3, null));
		t.M1111(new Command("Né Siêu Quái\n" + (isAvoidSuperMob ? "[STATUS: OFF]" : "[STATUS: ON]"), M2148(), 4, null));
		t.M1111(new Command("Goback", M2148(), 5, null));
		t.M1111(new Command("Clear Danh Sách Train", M2148(), 6, null));
		if (Char.M113().mobFocus != null)
		{
			t.M1111(new Command("Thêm\n[" + Char.M113().mobFocus.M998().name + "]\n[" + Char.M113().mobFocus.mobId + "]", M2148(), 7, null));
		}
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2151()
	{
		MyVector t = new MyVector();
		t.M1111(new Command("Goback\n" + (isGoBack ? ("[" + TileMap.mapNames[gobackMapID] + "]\n[" + gobackZoneID + "]") : "[STATUS: OFF]"), M2148(), 9, null));
		t.M1111(new Command("Goback Tọa Độ\n" + ((!isGoBack || !isGobackCoordinate) ? "[STATUS: OFF]" : ("[" + gobackX + "-" + gobackY + "]")), M2148(), 10, null));
		t.M1111(new Command("Về Nhà Khi MP Dưới\n[" + minimumMPGoHome + "%]", M2148(), 11, null));
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2152()
	{
		ChatTextField.M279().strChat = "Chat";
		ChatTextField.M279().tfChat.name = "chat";
		ChatTextField.M279().isShow = false;
	}

	private static void M2153(int x, int y)
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

	private static bool M2154(Mob mob)
	{
		if (!GameScr.canAutoPlay && mob.M1001())
		{
			if (mob.M1001())
			{
				return isAvoidSuperMob;
			}
			return false;
		}
		return true;
	}

	private static bool M2155()
	{
		return Char.M113().cMP < Char.M113().cMPFull * minimumMPGoHome / 100;
	}

	private static Mob M2156(int type)
	{
		if (type == 1)
		{
			long num = mSystem.M1054();
			Mob result = null;
			for (int i = 0; i < listMobIds.Count; i++)
			{
				Mob t = (Mob)GameScr.vMob.M1114(listMobIds[i]);
				long cTimeDie = t.cTimeDie;
				if (!t.isMobMe && cTimeDie < num)
				{
					result = t;
					num = cTimeDie;
				}
			}
			return result;
		}
		Mob result2 = null;
		int num2 = 9999;
		for (int j = 0; j < listMobIds.Count; j++)
		{
			Mob t2 = (Mob)GameScr.vMob.M1114(listMobIds[j]);
			if (t2.status != 0 && t2.status != 1 && t2.hp > 0 && !t2.isMobMe && M2154(t2))
			{
				int num3 = Math.M869(Char.M113().cx - t2.x);
				if (num2 > num3)
				{
					result2 = t2;
					num2 = num3;
				}
			}
		}
		return result2;
	}

	private static void M2157()
	{
		if (listMobIds.Count == 0)
		{
			GameScr.info1.M762("Danh Sách Tàn Sát Trống!", 0);
			isAutoTrain = false;
			return;
		}
		if (!GameScr.canAutoPlay)
		{
			isAutoTrain = true;
		}
		else
		{
			isAutoTrain = false;
		}
		GameScr.isAutoPlay = true;
	}

	private static void M2158()
	{
		if ((!isAutoTrain && !GameScr.canAutoPlay) || Char.M113().statusMe == 14 || Char.M113().statusMe == 5)
		{
			return;
		}
		if (listMobIds.Count == 0)
		{
			if (mSystem.M1054() - lastTimeAddNewMob > 5000L)
			{
				lastTimeAddNewMob = mSystem.M1054();
				GameScr.info1.M762("Danh Sách Tàn Sát Trống!", 0);
			}
			isAutoTrain = false;
			return;
		}
		if (Char.M113().mobFocus != null && (Char.M113().mobFocus == null || !Char.M113().mobFocus.isMobMe))
		{
			if (Char.M113().mobFocus.hp <= 0 || Char.M113().mobFocus.status == 1 || Char.M113().mobFocus.status == 0 || !M2154(Char.M113().mobFocus))
			{
				Char.M113().mobFocus = null;
			}
		}
		else
		{
			if (!GameScr.canAutoPlay && AutoPickItem.isAutoPick)
			{
				AutoPickItem.M2112();
				if (Char.M113().itemFocus != null)
				{
					AutoPickItem.M2113();
					AutoPickItem.M2112();
				}
			}
			else
			{
				Char.M113().itemFocus = null;
			}
			if (Char.M113().itemFocus == null)
			{
				Mob t = M2156(0);
				if (t == null)
				{
					t = M2156(1);
					if (!GameScr.canAutoPlay)
					{
						Char.M113().currentMovePoint = new MovePoint(t.xFirst, t.yFirst);
						Char.M113().endMovePointCommand = new Command(null, null, 8002, null);
					}
				}
				else
				{
					Char.M113().mobFocus = t;
					if (GameScr.canAutoPlay)
					{
						Char.M113().cx = t.x;
						Char.M113().cy = t.y;
						Service.M1594().M1640();
					}
				}
			}
		}
		if (Char.M113().mobFocus == null || (Char.M113().M178() != null && Char.M113().indexSkill < Char.M113().M178().Length && Char.M113().dart != null && Char.M113().arr != null))
		{
			return;
		}
		if (Char.M113().mobFocus != null && GameScr.canAutoPlay && (Math.M869(Char.M113().mobFocus.x - Char.M113().cx) > 100 || Math.M869(Char.M113().mobFocus.y - Char.M113().cy) > 100) && mSystem.M1054() - lastTimeTeleportToMob > 100L)
		{
			lastTimeTeleportToMob = mSystem.M1054();
			Char.M113().cx = Char.M113().mobFocus.x;
			Char.M113().cy = Char.M113().mobFocus.y;
			Service.M1594().M1640();
		}
		Skill t2 = null;
		for (int i = 0; i < GameScr.keySkill.Length; i++)
		{
			if (GameScr.keySkill[i] == null || GameScr.keySkill[i].paintCanNotUseSkill || GameScr.keySkill[i].template.id == 10 || GameScr.keySkill[i].template.id == 11 || GameScr.keySkill[i].template.id == 14 || GameScr.keySkill[i].template.id == 23 || GameScr.keySkill[i].template.id == 7 || GameScr.keySkill[i].template.id == 3 || GameScr.keySkill[i].template.id == 1 || GameScr.keySkill[i].template.id == 5 || GameScr.keySkill[i].template.id == 20 || GameScr.keySkill[i].template.id == 9 || GameScr.keySkill[i].template.id == 22 || GameScr.keySkill[i].template.id == 18 || (Char.M113().cgender == 1 && (Char.M113().cgender != 1 || (Char.M113().M119(Char.M113().nClass.skillTemplates[5]) != null && (Char.M113().M119(Char.M113().nClass.skillTemplates[5]) == null || GameScr.keySkill[i].template.id == 2)))) || Char.M113().M178() != null)
			{
				continue;
			}
			int num = ((GameScr.keySkill[i].template.manaUseType == 2) ? 1 : ((GameScr.keySkill[i].template.manaUseType == 1) ? (GameScr.keySkill[i].manaUse * Char.M113().cMPFull / 100) : GameScr.keySkill[i].manaUse));
			if (Char.M113().cMP >= num)
			{
				if (t2 == null)
				{
					t2 = GameScr.keySkill[i];
				}
				else if (t2.coolDown < GameScr.keySkill[i].coolDown)
				{
					t2 = GameScr.keySkill[i];
				}
			}
		}
		if (t2 != null)
		{
			GameScr.M559().M601(t2, isShortcut: true);
			GameScr.M559().M583(Char.M113().mobFocus);
		}
	}

	public static void M2159()
	{
		for (int i = 0; i < Char.M113().arrItemBag.Length; i++)
		{
			Item t = Char.M113().arrItemBag[i];
			if (t != null && t.template.id == 212)
			{
				Service.M1594().M1615(0, 1, (sbyte)t.indexUI, -1);
				return;
			}
		}
		for (int j = 0; j < Char.M113().arrItemBag.Length; j++)
		{
			Item t2 = Char.M113().arrItemBag[j];
			if (t2 != null && t2.template.id == 211)
			{
				Service.M1594().M1615(0, 1, (sbyte)t2.indexUI, -1);
				break;
			}
		}
	}
}
