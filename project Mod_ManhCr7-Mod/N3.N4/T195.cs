using System.Collections.Generic;

namespace N3.N4;

public class T195 : T57, T58
{
	private static T195 _Instance;

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

	static T195()
	{
		listMobIds = new List<int>();
		minimumMPGoHome = 5;
		inputMPPercentGoHome = new string[2] { "Nhập %MP", "%MP" };
	}

	public static T195 M2148()
	{
		if (_Instance == null)
		{
			_Instance = new T195();
		}
		return _Instance;
	}

	public static void M2149()
	{
		if (T54.isAutoPlay && (T54.canAutoPlay || isAutoTrain) && T51.gameTick % 20 == 0)
		{
			M2158();
		}
		if (T13.M113().cStamina <= 5 && T51.gameTick % 100 == 0)
		{
			M2159();
		}
		if (!isGoBack)
		{
			return;
		}
		if (T13.M113().meDead && T51.gameTick % 100 == 0)
		{
			T146.M1594().M1672();
		}
		if (M2155())
		{
			int num = 21 + T13.M113().cgender;
			if (T174.mapID != num)
			{
				T54.isAutoPlay = false;
				T13.M113().mobFocus = null;
				if (T51.gameTick % 50 == 0)
				{
					T190.M2064(num);
				}
			}
		}
		else
		{
			if (M2155())
			{
				return;
			}
			if (T174.mapID != gobackMapID)
			{
				T54.isAutoPlay = false;
				T190.M2064(gobackMapID);
			}
			if (T174.mapID == gobackMapID)
			{
				if (!isGobackCoordinate && T51.gameTick % 100 == 0)
				{
					T54.isAutoPlay = true;
				}
				if (T174.zoneID != gobackZoneID && !T13.ischangingMap && !T23.isStopReadMessage && T51.gameTick % 100 == 0)
				{
					T146.M1594().M1638(gobackZoneID, -1);
				}
				if (isGobackCoordinate && (T13.M113().cx != gobackX || T13.M113().cy != gobackY) && T51.gameTick % 100 == 0)
				{
					M2153(gobackX, gobackY);
				}
			}
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (T15.M279().tfChat.M1924() != null && !T15.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (T15.M279().strChat.Equals(inputMPPercentGoHome[0]))
			{
				try
				{
					int num = (minimumMPGoHome = int.Parse(T15.M279().tfChat.M1924()));
					T54.info1.M762("Về Nhà Khi MP Dưới\n[" + num + "%]", 0);
				}
				catch
				{
					T54.info1.M762("%MP Không Hợp Lệ, Vui Lòng Nhập Lại", 0);
				}
				M2152();
			}
		}
		else
		{
			T15.M279().isShow = false;
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
			for (int i = 0; i < T54.vMob.M1113(); i++)
			{
				T101 t = (T101)T54.vMob.M1114(i);
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
			for (int j = 0; j < T54.vMob.M1113(); j++)
			{
				T101 t2 = (T101)T54.vMob.M1114(j);
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
			T54.info1.M762("Né Siêu Quái\n" + (isAvoidSuperMob ? "[STATUS: OFF]" : "[STATUS: ON]"), 0);
			break;
		case 5:
			M2151();
			break;
		case 6:
			listMobIds.Clear();
			isAutoTrain = false;
			T54.info1.M762("Đã Clear Danh Sách Train!", 0);
			break;
		case 7:
			if (T13.M113().mobFocus == null)
			{
				T54.info1.M762("Vui Lòng Chọn Quái!", 0);
			}
			if (T13.M113().mobFocus != null)
			{
				listMobIds.Add(T13.M113().mobFocus.mobId);
				T54.info1.M762("Đã Thêm Quái: " + T13.M113().mobFocus.mobId, 0);
			}
			break;
		case 8:
			isAutoTrain = false;
			T13.M113().mobFocus = null;
			T54.info1.M762("Đã Tắt Auto Train!", 0);
			break;
		case 9:
			if (isGoBack)
			{
				isGoBack = false;
				T54.info1.M762("Goback\n[STATUS: OFF]", 0);
			}
			else if (!isGoBack)
			{
				isGobackCoordinate = false;
				isGoBack = true;
				gobackMapID = T174.mapID;
				gobackZoneID = T174.zoneID;
				T54.info1.M762("Goback\n[" + T174.mapNames[gobackMapID] + "]\n[" + gobackZoneID + "]", 0);
			}
			break;
		case 10:
			if (isGoBack)
			{
				isGoBack = false;
				T54.info1.M762("Goback\n[STATUS: OFF]", 0);
			}
			else if (!isGoBack)
			{
				isGobackCoordinate = true;
				isGoBack = true;
				gobackMapID = T174.mapID;
				gobackZoneID = T174.zoneID;
				gobackX = T13.M113().cx;
				gobackY = T13.M113().cy;
				T54.info1.M762("Goback Tọa Độ\n[" + gobackX + "-" + gobackY + "]", 0);
			}
			break;
		case 11:
			T15.M279().strChat = inputMPPercentGoHome[0];
			T15.M279().tfChat.name = inputMPPercentGoHome[1];
			T15.M279().M282(M2148(), string.Empty);
			break;
		}
	}

	public static void M2150()
	{
		T117 t = new T117();
		List<T101> list = new List<T101>();
		if (isAutoTrain && !T54.canAutoPlay)
		{
			t.M1111(new T22("Tắt Auto Train", M2148(), 8, null));
		}
		for (int i = 0; i < T54.vMob.M1113(); i++)
		{
			T101 t2 = (T101)T54.vMob.M1114(i);
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
				t.M1111(new T22("Tàn Sát\n" + t2.M998().name + "\n[" + T122.M1192(t2.maxHp) + "HP]", M2148(), 1, t2.templateId));
			}
		}
		t.M1111(new T22("Tàn Sát Tất Cả", M2148(), 2, null));
		t.M1111(new T22("Tàn Sát Theo Vị Trí", M2148(), 3, null));
		t.M1111(new T22("Né Siêu Quái\n" + (isAvoidSuperMob ? "[STATUS: OFF]" : "[STATUS: ON]"), M2148(), 4, null));
		t.M1111(new T22("Goback", M2148(), 5, null));
		t.M1111(new T22("Clear Danh Sách Train", M2148(), 6, null));
		if (T13.M113().mobFocus != null)
		{
			t.M1111(new T22("Thêm\n[" + T13.M113().mobFocus.M998().name + "]\n[" + T13.M113().mobFocus.mobId + "]", M2148(), 7, null));
		}
		T51.menu.M877(t, 3);
	}

	private static void M2151()
	{
		T117 t = new T117();
		t.M1111(new T22("Goback\n" + (isGoBack ? ("[" + T174.mapNames[gobackMapID] + "]\n[" + gobackZoneID + "]") : "[STATUS: OFF]"), M2148(), 9, null));
		t.M1111(new T22("Goback Tọa Độ\n" + ((!isGoBack || !isGobackCoordinate) ? "[STATUS: OFF]" : ("[" + gobackX + "-" + gobackY + "]")), M2148(), 10, null));
		t.M1111(new T22("Về Nhà Khi MP Dưới\n[" + minimumMPGoHome + "%]", M2148(), 11, null));
		T51.menu.M877(t, 3);
	}

	private static void M2152()
	{
		T15.M279().strChat = "Chat";
		T15.M279().tfChat.name = "chat";
		T15.M279().isShow = false;
	}

	private static void M2153(int x, int y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T13.M113().cx = x;
		T13.M113().cy = y;
		T146.M1594().M1640();
		T13.M113().cx = x;
		T13.M113().cy = y + 1;
		T146.M1594().M1640();
		T13.M113().cx = x;
		T13.M113().cy = y;
		T146.M1594().M1640();
	}

	private static bool M2154(T101 mob)
	{
		if (!T54.canAutoPlay && mob.M1001())
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
		return T13.M113().cMP < T13.M113().cMPFull * minimumMPGoHome / 100;
	}

	private static T101 M2156(int type)
	{
		if (type == 1)
		{
			long num = T110.M1054();
			T101 result = null;
			for (int i = 0; i < listMobIds.Count; i++)
			{
				T101 t = (T101)T54.vMob.M1114(listMobIds[i]);
				long cTimeDie = t.cTimeDie;
				if (!t.isMobMe && cTimeDie < num)
				{
					result = t;
					num = cTimeDie;
				}
			}
			return result;
		}
		T101 result2 = null;
		int num2 = 9999;
		for (int j = 0; j < listMobIds.Count; j++)
		{
			T101 t2 = (T101)T54.vMob.M1114(listMobIds[j]);
			if (t2.status != 0 && t2.status != 1 && t2.hp > 0 && !t2.isMobMe && M2154(t2))
			{
				int num3 = T94.M869(T13.M113().cx - t2.x);
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
			T54.info1.M762("Danh Sách Tàn Sát Trống!", 0);
			isAutoTrain = false;
			return;
		}
		if (!T54.canAutoPlay)
		{
			isAutoTrain = true;
		}
		else
		{
			isAutoTrain = false;
		}
		T54.isAutoPlay = true;
	}

	private static void M2158()
	{
		if ((!isAutoTrain && !T54.canAutoPlay) || T13.M113().statusMe == 14 || T13.M113().statusMe == 5)
		{
			return;
		}
		if (listMobIds.Count == 0)
		{
			if (T110.M1054() - lastTimeAddNewMob > 5000L)
			{
				lastTimeAddNewMob = T110.M1054();
				T54.info1.M762("Danh Sách Tàn Sát Trống!", 0);
			}
			isAutoTrain = false;
			return;
		}
		if (T13.M113().mobFocus != null && (T13.M113().mobFocus == null || !T13.M113().mobFocus.isMobMe))
		{
			if (T13.M113().mobFocus.hp <= 0 || T13.M113().mobFocus.status == 1 || T13.M113().mobFocus.status == 0 || !M2154(T13.M113().mobFocus))
			{
				T13.M113().mobFocus = null;
			}
		}
		else
		{
			if (!T54.canAutoPlay && T192.isAutoPick)
			{
				T192.M2112();
				if (T13.M113().itemFocus != null)
				{
					T192.M2113();
					T192.M2112();
				}
			}
			else
			{
				T13.M113().itemFocus = null;
			}
			if (T13.M113().itemFocus == null)
			{
				T101 t = M2156(0);
				if (t == null)
				{
					t = M2156(1);
					if (!T54.canAutoPlay)
					{
						T13.M113().currentMovePoint = new T107(t.xFirst, t.yFirst);
						T13.M113().endMovePointCommand = new T22(null, null, 8002, null);
					}
				}
				else
				{
					T13.M113().mobFocus = t;
					if (T54.canAutoPlay)
					{
						T13.M113().cx = t.x;
						T13.M113().cy = t.y;
						T146.M1594().M1640();
					}
				}
			}
		}
		if (T13.M113().mobFocus == null || (T13.M113().M178() != null && T13.M113().indexSkill < T13.M113().M178().Length && T13.M113().dart != null && T13.M113().arr != null))
		{
			return;
		}
		if (T13.M113().mobFocus != null && T54.canAutoPlay && (T94.M869(T13.M113().mobFocus.x - T13.M113().cx) > 100 || T94.M869(T13.M113().mobFocus.y - T13.M113().cy) > 100) && T110.M1054() - lastTimeTeleportToMob > 100L)
		{
			lastTimeTeleportToMob = T110.M1054();
			T13.M113().cx = T13.M113().mobFocus.x;
			T13.M113().cy = T13.M113().mobFocus.y;
			T146.M1594().M1640();
		}
		T149 t2 = null;
		for (int i = 0; i < T54.keySkill.Length; i++)
		{
			if (T54.keySkill[i] == null || T54.keySkill[i].paintCanNotUseSkill || T54.keySkill[i].template.id == 10 || T54.keySkill[i].template.id == 11 || T54.keySkill[i].template.id == 14 || T54.keySkill[i].template.id == 23 || T54.keySkill[i].template.id == 7 || T54.keySkill[i].template.id == 3 || T54.keySkill[i].template.id == 1 || T54.keySkill[i].template.id == 5 || T54.keySkill[i].template.id == 20 || T54.keySkill[i].template.id == 9 || T54.keySkill[i].template.id == 22 || T54.keySkill[i].template.id == 18 || (T13.M113().cgender == 1 && (T13.M113().cgender != 1 || (T13.M113().M119(T13.M113().nClass.skillTemplates[5]) != null && (T13.M113().M119(T13.M113().nClass.skillTemplates[5]) == null || T54.keySkill[i].template.id == 2)))) || T13.M113().M178() != null)
			{
				continue;
			}
			int num = ((T54.keySkill[i].template.manaUseType == 2) ? 1 : ((T54.keySkill[i].template.manaUseType == 1) ? (T54.keySkill[i].manaUse * T13.M113().cMPFull / 100) : T54.keySkill[i].manaUse));
			if (T13.M113().cMP >= num)
			{
				if (t2 == null)
				{
					t2 = T54.keySkill[i];
				}
				else if (t2.coolDown < T54.keySkill[i].coolDown)
				{
					t2 = T54.keySkill[i];
				}
			}
		}
		if (t2 != null)
		{
			T54.M559().M601(t2, isShortcut: true);
			T54.M559().M583(T13.M113().mobFocus);
		}
	}

	public static void M2159()
	{
		for (int i = 0; i < T13.M113().arrItemBag.Length; i++)
		{
			T79 t = T13.M113().arrItemBag[i];
			if (t != null && t.template.id == 212)
			{
				T146.M1594().M1615(0, 1, (sbyte)t.indexUI, -1);
				return;
			}
		}
		for (int j = 0; j < T13.M113().arrItemBag.Length; j++)
		{
			T79 t2 = T13.M113().arrItemBag[j];
			if (t2 != null && t2.template.id == 211)
			{
				T146.M1594().M1615(0, 1, (sbyte)t2.indexUI, -1);
				break;
			}
		}
	}
}
