using System.Collections.Generic;

namespace N3.N4;

public class T194 : T57, T58
{
	private static T194 _Instance;

	public static bool isLoadKeySkill;

	public static bool isAutoSendAttack;

	private static long[] lastTimeSendAttack;

	public static bool isTrainPet;

	public static bool isPetAskedForUseSkill;

	public static bool[] isAutoUseSkills;

	private static long[] lastTimeUseSkill;

	private static long[] timeAutoSkills;

	private static int indexSkillAuto;

	private static bool isAutoChangeFocus;

	private static long cooldownAutoChangeFocus;

	private static long lastTimeChangeFocus;

	private static List<T13> listTargetAutoChangeFocus;

	private static int targetIndex;

	private static bool isAutoShield;

	private static string[] inputDelay;

	private static bool isSaveData;

	private static long lastTimeAutoUseSkill;

	static T194()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		isLoadKeySkill = true;
		lastTimeSendAttack = new long[10];
		isAutoUseSkills = new bool[10];
		lastTimeUseSkill = new long[10];
		timeAutoSkills = new long[10];
		listTargetAutoChangeFocus = new List<T13>();
		inputDelay = new string[2] { "Nhập delay", "mili giây" };
		M2132();
	}

	public static T194 M2127()
	{
		if (_Instance == null)
		{
			_Instance = new T194();
		}
		return _Instance;
	}

	public static void M2128()
	{
		if (isAutoSendAttack)
		{
			M2135();
		}
		if (isTrainPet)
		{
			M2136();
		}
		if (!T13.M113().meDead)
		{
			for (int i = 0; i < T54.keySkill.Length; i++)
			{
				if (isAutoUseSkills[i])
				{
					M2137(i);
				}
			}
		}
		if (isLoadKeySkill && T51.gameTick % 20 == 0)
		{
			isLoadKeySkill = false;
			M2134();
		}
		if (isAutoChangeFocus)
		{
			M2144();
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (T15.M279().tfChat.M1924() != null && !T15.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (T15.M279().strChat.Equals(inputDelay[0]))
			{
				try
				{
					long num = long.Parse(T15.M279().tfChat.M1924());
					timeAutoSkills[indexSkillAuto] = num;
					isAutoUseSkills[indexSkillAuto] = true;
					T54.info1.M762("Auto " + T54.keySkill[indexSkillAuto].template.name + ": " + T122.M1192(num) + " mili giây", 0);
				}
				catch
				{
					T54.info1.M762("Vui Lòng Nhập Lại Delay!", 0);
				}
				M2131();
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
			isAutoSendAttack = !isAutoSendAttack;
			T54.info1.M762("Tự Đánh\n" + (isAutoSendAttack ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isAutoSendAttack)
			{
				isAutoChangeFocus = false;
			}
			break;
		case 2:
			isTrainPet = !isTrainPet;
			T54.info1.M762("Đánh Khi Đệ Cần\n" + (isTrainPet ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 3:
		{
			T117 t = new T117();
			for (int i = 0; i < T54.keySkill.Length; i++)
			{
				t.M1111(new T22(((T54.keySkill[i] != null) ? T54.keySkill[i].template.name : "null") + "\n[" + (i + 1) + "]\n", M2127(), 10, i));
			}
			T51.menu.M877(t, 3);
			break;
		}
		case 4:
			isAutoShield = !isAutoShield;
			T54.info1.M762("Auto Khiên Pro\n" + (isAutoShield ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 5:
			T54.info1.M762("Không Hỗ Trợ Lưu Cài Đặt Ở Mục Này!", 0);
			break;
		case 6:
			isAutoChangeFocus = !isAutoChangeFocus;
			T54.info1.M762("Đánh Chuyển Mục Tiêu\n" + (isAutoChangeFocus ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isAutoChangeFocus)
			{
				isAutoSendAttack = false;
			}
			break;
		case 7:
			listTargetAutoChangeFocus.Clear();
			T54.info1.M762("Đã Xóa Danh Sách Đánh Chuyển Mục Tiêu!", 0);
			break;
		case 8:
			if (T13.M113().charFocus != null)
			{
				listTargetAutoChangeFocus.Remove(T13.M113().charFocus);
				T54.info1.M762("Đã Xóa " + T13.M113().charFocus.cName + " [" + T13.M113().charFocus.charID + "]", 0);
			}
			break;
		case 9:
			if (T13.M113().charFocus != null)
			{
				listTargetAutoChangeFocus.Add(T13.M113().charFocus);
				T54.info1.M762("Đã Thêm " + T13.M113().charFocus.cName + " [" + T13.M113().charFocus.charID + "]", 0);
			}
			break;
		case 10:
			M2130((int)p);
			break;
		case 11:
		{
			int num2 = (int)p;
			isAutoUseSkills[num2] = !isAutoUseSkills[num2];
			if (isAutoUseSkills[num2])
			{
				timeAutoSkills[num2] = -1L;
			}
			T54.info1.M762("Auto " + T54.keySkill[num2].template.name + (isAutoUseSkills[num2] ? (": " + T122.M1192(timeAutoSkills[num2]) + " mili giây") : "\n[STATUS: OFF]"), 0);
			break;
		}
		case 12:
			T15.M279().strChat = inputDelay[0];
			T15.M279().tfChat.name = inputDelay[1];
			T15.M279().M282(M2127(), string.Empty);
			indexSkillAuto = (int)p;
			break;
		case 13:
		{
			int num = (int)p;
			T54.keySkill[num].coolDown = 0;
			T54.keySkill[num].manaUse = 0;
			T54.info1.M762("Đóng Băng " + T54.keySkill[num].template.name, 0);
			break;
		}
		}
	}

	public static void M2129()
	{
		M2132();
		T117 t = new T117();
		t.M1111(new T22("Tự Đánh\n" + (isAutoSendAttack ? "[STATUS: ON]" : "[STATUS: OFF]"), M2127(), 1, null));
		t.M1111(new T22("Đánh Khi Đệ Cần\n" + (isTrainPet ? "[STATUS: ON]" : "[STATUS: OFF]"), M2127(), 2, null));
		t.M1111(new T22(T54.keySkill.Length + " Ô Kỹ Năng", M2127(), 3, null));
		t.M1111(new T22("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), M2127(), 5, null));
		t.M1111(new T22("Đánh Chuyển Mục Tiêu\n" + (isAutoChangeFocus ? "[STATUS: ON]" : "[STATUS: OFF]"), M2127(), 6, null));
		if (listTargetAutoChangeFocus.Count > 0)
		{
			t.M1111(new T22("Clear Danh Sách Chuyển Mục Tiêu", M2127(), 7, null));
		}
		if (T13.M113().charFocus != null)
		{
			if (listTargetAutoChangeFocus.Contains(T13.M113().charFocus))
			{
				t.M1111(new T22("Xóa Khỏi Danh Sách Chuyển Mục Tiêu", M2127(), 8, null));
			}
			else
			{
				t.M1111(new T22("Thêm Vào Danh Sách Chuyển Mục Tiêu", M2127(), 9, null));
			}
		}
		T51.menu.M877(t, 3);
	}

	private static void M2130(int skillIndex)
	{
		T117 t = new T117();
		t.M1111(new T22("Auto Sử Dụng\n" + (isAutoUseSkills[skillIndex] ? ("[" + T122.M1192(timeAutoSkills[skillIndex]) + " mili giây]") : "[STATUS: OFF]"), M2127(), 11, skillIndex));
		t.M1111(new T22("Nhập Delay\n[mili giây]", M2127(), 12, skillIndex));
		t.M1111(new T22("Đóng Băng\n" + T54.keySkill[skillIndex].template.name, M2127(), 13, skillIndex));
		T51.menu.M877(t, 3);
	}

	private static void M2131()
	{
		T15.M279().strChat = "Chat";
		T15.M279().tfChat.name = "chat";
		T15.M279().isShow = false;
	}

	private static void M2132()
	{
	}

	private static void M2133()
	{
	}

	private static void M2134()
	{
		for (int i = 0; i < T13.M113().nClass.skillTemplates.Length; i++)
		{
			T155 skillTemplate = T13.M113().nClass.skillTemplates[i];
			T149 t = T13.M113().M119(skillTemplate);
			if (t != null)
			{
				T54.keySkill[i] = t;
			}
			T54.M559().M548();
		}
	}

	public static void M2135()
	{
		if (T13.M113().meDead || T13.M113().cHP <= 0 || T13.M113().statusMe == 14 || T13.M113().statusMe == 5 || T13.M113().myskill.template.type == 3 || T13.M113().myskill.template.id == 10 || T13.M113().myskill.template.id == 11 || (T13.M113().myskill.paintCanNotUseSkill && !T51.panel.isShow))
		{
			return;
		}
		int num = M2143();
		if (T110.M1054() - lastTimeSendAttack[num] > M2142(T13.M113().myskill))
		{
			if (T54.M559().M571(T13.M113().mobFocus))
			{
				T13.M113().myskill.lastTimeUseThisSkill = T110.M1054();
				M2141();
				lastTimeSendAttack[num] = T110.M1054();
			}
			else if (T13.M113().charFocus != null && M2138(T13.M113().charFocus) && (double)T94.M869(T13.M113().charFocus.cx - T13.M113().cx) < (double)T13.M113().myskill.dx * 1.7)
			{
				T13.M113().myskill.lastTimeUseThisSkill = T110.M1054();
				M2140();
				lastTimeSendAttack[num] = T110.M1054();
			}
		}
	}

	private static void M2136()
	{
		if (isPetAskedForUseSkill && T54.vMob.M1113() != 0 && T13.M113().myskill.template.type != 3)
		{
			T101 t = (T101)T54.vMob.M1114(0);
			T13.M113().cx = t.x;
			T13.M113().cy = t.y;
			T13.M113().npcFocus = null;
			T13.M113().itemFocus = null;
			T13.M113().charFocus = null;
			T13.M113().mobFocus = t;
			if (!T13.M113().meDead)
			{
				T54.M559().M603(T54.keySkill[0]);
			}
			isPetAskedForUseSkill = false;
		}
	}

	private static void M2137(int skillIndex)
	{
		if (T174.mapID == 21 || T174.mapID == 22 || T174.mapID == 23)
		{
			return;
		}
		if (skillIndex >= T54.keySkill.Length)
		{
			skillIndex = T54.keySkill.Length - 1;
		}
		if (skillIndex < 0)
		{
			skillIndex = 0;
		}
		if (T54.keySkill[skillIndex] == null || T54.keySkill[skillIndex].paintCanNotUseSkill)
		{
			return;
		}
		if (T54.keySkill[skillIndex].coolDown == 0)
		{
			timeAutoSkills[skillIndex] = 500L;
		}
		else if (M2139(T54.keySkill[skillIndex]) && !T54.M559().M600() && T110.M1054() - lastTimeAutoUseSkill > 150L)
		{
			if (timeAutoSkills[skillIndex] == -1L && T51.gameTick % 20 == 0)
			{
				lastTimeUseSkill[skillIndex] = T110.M1054();
				lastTimeAutoUseSkill = T110.M1054();
				T54.M559().M601(T54.keySkill[skillIndex], isShortcut: true);
			}
			if (T110.M1054() - lastTimeUseSkill[skillIndex] > timeAutoSkills[skillIndex])
			{
				lastTimeUseSkill[skillIndex] = T110.M1054();
				lastTimeAutoUseSkill = T110.M1054();
				T54.M559().M601(T54.keySkill[skillIndex], isShortcut: true);
			}
		}
	}

	public static bool M2138(T13 ch)
	{
		if (T174.mapID == 113)
		{
			if (ch != null && T13.M113().myskill != null)
			{
				if (ch.cTypePk != 5)
				{
					return ch.cTypePk == 3;
				}
				return true;
			}
			return false;
		}
		if (ch != null && T13.M113().myskill != null)
		{
			if (ch.statusMe == 14 || ch.statusMe == 5 || T13.M113().myskill.template.type == 2 || ((T13.M113().cFlag != 8 || ch.cFlag == 0) && (T13.M113().cFlag == 0 || ch.cFlag != 8) && (T13.M113().cFlag == ch.cFlag || T13.M113().cFlag == 0 || ch.cFlag == 0) && (ch.cTypePk != 3 || T13.M113().cTypePk != 3) && T13.M113().cTypePk != 5 && ch.cTypePk != 5 && (T13.M113().cTypePk != 1 || ch.cTypePk != 1) && (T13.M113().cTypePk != 4 || ch.cTypePk != 4)))
			{
				if (T13.M113().myskill.template.type == 2)
				{
					return ch.cTypePk != 5;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	private static bool M2139(T149 skillToUse)
	{
		if (skillToUse.template.manaUseType == 2)
		{
			return true;
		}
		if (skillToUse.template.manaUseType != 1)
		{
			return T13.M113().cMP >= skillToUse.manaUse;
		}
		return T13.M113().cMP >= skillToUse.manaUse * T13.M113().cMPFull / 100;
	}

	private static void M2140()
	{
		try
		{
			T117 t = new T117();
			t.M1111(T13.M113().charFocus);
			T146.M1594().M1669(new T117(), t, 2);
		}
		catch
		{
		}
	}

	private static void M2141()
	{
		try
		{
			T117 t = new T117();
			t.M1111(T13.M113().mobFocus);
			T146.M1594().M1669(t, new T117(), 1);
		}
		catch
		{
		}
	}

	private static long M2142(T149 skill)
	{
		if (skill.template.id != 20 && skill.template.id != 22 && skill.template.id != 7 && skill.template.id != 18 && skill.template.id != 23)
		{
			return skill.coolDown + 100;
		}
		return skill.coolDown + 500L;
	}

	private static int M2143()
	{
		int num = 0;
		while (true)
		{
			if (num < T54.keySkill.Length)
			{
				if (T54.keySkill[num] == T13.M113().myskill)
				{
					break;
				}
				num++;
				continue;
			}
			return 0;
		}
		return num;
	}

	private static void M2144()
	{
		if (listTargetAutoChangeFocus.Count == 0)
		{
			T54.info1.M762("Danh sách chuyển mục tiêu trống!", 0);
			isAutoChangeFocus = false;
		}
		else
		{
			if (T13.M113().meDead || T13.M113().statusMe == 14 || T13.M113().statusMe == 5 || T13.M113().myskill.template.type == 3 || T13.M113().myskill.template.id == 10 || T13.M113().myskill.template.id == 11 || T13.M113().myskill.paintCanNotUseSkill)
			{
				return;
			}
			cooldownAutoChangeFocus = M2145(T13.M113().myskill);
			if (targetIndex >= listTargetAutoChangeFocus.Count)
			{
				targetIndex = 0;
			}
			if (T110.M1054() - lastTimeChangeFocus >= cooldownAutoChangeFocus)
			{
				lastTimeChangeFocus = T110.M1054();
				T13.M113().charFocus = T54.M626(listTargetAutoChangeFocus[targetIndex].charID);
				targetIndex++;
				if (targetIndex >= listTargetAutoChangeFocus.Count)
				{
					targetIndex = 0;
				}
				if (T13.M113().charFocus != null && M2138(T13.M113().charFocus) && (double)T94.M869(T13.M113().charFocus.cx - T13.M113().cx) < (double)T13.M113().myskill.dx * 1.5)
				{
					T13.M113().myskill.lastTimeUseThisSkill = T110.M1054();
					M2140();
				}
			}
		}
	}

	private static long M2145(T149 skill)
	{
		if (skill.coolDown <= 500)
		{
			return 1000L;
		}
		return (long)((double)skill.coolDown * 1.2 + 200.0);
	}

	private static void M2146()
	{
	}

	public static void M2147()
	{
		int num = M2143();
		T54.keySkill[num].coolDown = 0;
		T54.keySkill[num].manaUse = 0;
		T54.info1.M762("Đóng Băng\n" + T54.keySkill[num].template.name, 0);
	}
}
