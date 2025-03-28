using System.Collections.Generic;

namespace Utilities;

public class GameAutomationController : IActionListener, IChatable
{
	private static GameAutomationController _Instance;

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

	private static List<Char> listTargetAutoChangeFocus;

	private static int targetIndex;

	private static bool isAutoShield;

	private static string[] inputDelay;

	private static bool isSaveData;

	private static long lastTimeAutoUseSkill;

	static GameAutomationController()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		isLoadKeySkill = true;
		lastTimeSendAttack = new long[10];
		isAutoUseSkills = new bool[10];
		lastTimeUseSkill = new long[10];
		timeAutoSkills = new long[10];
		listTargetAutoChangeFocus = new List<Char>();
		inputDelay = new string[2] { "Nhập delay", "mili giây" };
		M2132();
	}

	public static GameAutomationController M2127()
	{
		if (_Instance == null)
		{
			_Instance = new GameAutomationController();
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
		if (!Char.M113().meDead)
		{
			for (int i = 0; i < GameScr.keySkill.Length; i++)
			{
				if (isAutoUseSkills[i])
				{
					M2137(i);
				}
			}
		}
		if (isLoadKeySkill && GameCanvas.gameTick % 20 == 0)
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
		if (ChatTextField.M279().tfChat.M1924() != null && !ChatTextField.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (ChatTextField.M279().strChat.Equals(inputDelay[0]))
			{
				try
				{
					long num = long.Parse(ChatTextField.M279().tfChat.M1924());
					timeAutoSkills[indexSkillAuto] = num;
					isAutoUseSkills[indexSkillAuto] = true;
					GameScr.info1.M762("Auto " + GameScr.keySkill[indexSkillAuto].template.name + ": " + NinjaUtil.M1192(num) + " mili giây", 0);
				}
				catch
				{
					GameScr.info1.M762("Vui Lòng Nhập Lại Delay!", 0);
				}
				M2131();
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
			isAutoSendAttack = !isAutoSendAttack;
			GameScr.info1.M762("Tự Đánh\n" + (isAutoSendAttack ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isAutoSendAttack)
			{
				isAutoChangeFocus = false;
			}
			break;
		case 2:
			isTrainPet = !isTrainPet;
			GameScr.info1.M762("Đánh Khi Đệ Cần\n" + (isTrainPet ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 3:
		{
			MyVector t = new MyVector();
			for (int i = 0; i < GameScr.keySkill.Length; i++)
			{
				t.M1111(new Command(((GameScr.keySkill[i] != null) ? GameScr.keySkill[i].template.name : "null") + "\n[" + (i + 1) + "]\n", M2127(), 10, i));
			}
			GameCanvas.menu.M877(t, 3);
			break;
		}
		case 4:
			isAutoShield = !isAutoShield;
			GameScr.info1.M762("Auto Khiên Pro\n" + (isAutoShield ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 5:
			GameScr.info1.M762("Không Hỗ Trợ Lưu Cài Đặt Ở Mục Này!", 0);
			break;
		case 6:
			isAutoChangeFocus = !isAutoChangeFocus;
			GameScr.info1.M762("Đánh Chuyển Mục Tiêu\n" + (isAutoChangeFocus ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			if (isAutoChangeFocus)
			{
				isAutoSendAttack = false;
			}
			break;
		case 7:
			listTargetAutoChangeFocus.Clear();
			GameScr.info1.M762("Đã Xóa Danh Sách Đánh Chuyển Mục Tiêu!", 0);
			break;
		case 8:
			if (Char.M113().charFocus != null)
			{
				listTargetAutoChangeFocus.Remove(Char.M113().charFocus);
				GameScr.info1.M762("Đã Xóa " + Char.M113().charFocus.cName + " [" + Char.M113().charFocus.charID + "]", 0);
			}
			break;
		case 9:
			if (Char.M113().charFocus != null)
			{
				listTargetAutoChangeFocus.Add(Char.M113().charFocus);
				GameScr.info1.M762("Đã Thêm " + Char.M113().charFocus.cName + " [" + Char.M113().charFocus.charID + "]", 0);
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
			GameScr.info1.M762("Auto " + GameScr.keySkill[num2].template.name + (isAutoUseSkills[num2] ? (": " + NinjaUtil.M1192(timeAutoSkills[num2]) + " mili giây") : "\n[STATUS: OFF]"), 0);
			break;
		}
		case 12:
			ChatTextField.M279().strChat = inputDelay[0];
			ChatTextField.M279().tfChat.name = inputDelay[1];
			ChatTextField.M279().M282(M2127(), string.Empty);
			indexSkillAuto = (int)p;
			break;
		case 13:
		{
			int num = (int)p;
			GameScr.keySkill[num].coolDown = 0;
			GameScr.keySkill[num].manaUse = 0;
			GameScr.info1.M762("Đóng Băng " + GameScr.keySkill[num].template.name, 0);
			break;
		}
		}
	}

	public static void M2129()
	{
		M2132();
		MyVector t = new MyVector();
		t.M1111(new Command("Tự Đánh\n" + (isAutoSendAttack ? "[STATUS: ON]" : "[STATUS: OFF]"), M2127(), 1, null));
		t.M1111(new Command("Đánh Khi Đệ Cần\n" + (isTrainPet ? "[STATUS: ON]" : "[STATUS: OFF]"), M2127(), 2, null));
		t.M1111(new Command(GameScr.keySkill.Length + " Ô Kỹ Năng", M2127(), 3, null));
		t.M1111(new Command("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), M2127(), 5, null));
		t.M1111(new Command("Đánh Chuyển Mục Tiêu\n" + (isAutoChangeFocus ? "[STATUS: ON]" : "[STATUS: OFF]"), M2127(), 6, null));
		if (listTargetAutoChangeFocus.Count > 0)
		{
			t.M1111(new Command("Clear Danh Sách Chuyển Mục Tiêu", M2127(), 7, null));
		}
		if (Char.M113().charFocus != null)
		{
			if (listTargetAutoChangeFocus.Contains(Char.M113().charFocus))
			{
				t.M1111(new Command("Xóa Khỏi Danh Sách Chuyển Mục Tiêu", M2127(), 8, null));
			}
			else
			{
				t.M1111(new Command("Thêm Vào Danh Sách Chuyển Mục Tiêu", M2127(), 9, null));
			}
		}
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2130(int skillIndex)
	{
		MyVector t = new MyVector();
		t.M1111(new Command("Auto Sử Dụng\n" + (isAutoUseSkills[skillIndex] ? ("[" + NinjaUtil.M1192(timeAutoSkills[skillIndex]) + " mili giây]") : "[STATUS: OFF]"), M2127(), 11, skillIndex));
		t.M1111(new Command("Nhập Delay\n[mili giây]", M2127(), 12, skillIndex));
		t.M1111(new Command("Đóng Băng\n" + GameScr.keySkill[skillIndex].template.name, M2127(), 13, skillIndex));
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2131()
	{
		ChatTextField.M279().strChat = "Chat";
		ChatTextField.M279().tfChat.name = "chat";
		ChatTextField.M279().isShow = false;
	}

	private static void M2132()
	{
	}

	private static void M2133()
	{
	}

	private static void M2134()
	{
		for (int i = 0; i < Char.M113().nClass.skillTemplates.Length; i++)
		{
			SkillTemplate skillTemplate = Char.M113().nClass.skillTemplates[i];
			Skill t = Char.M113().M119(skillTemplate);
			if (t != null)
			{
				GameScr.keySkill[i] = t;
			}
			GameScr.M559().M548();
		}
	}

	public static void M2135()
	{
		if (Char.M113().meDead || Char.M113().cHP <= 0 || Char.M113().statusMe == 14 || Char.M113().statusMe == 5 || Char.M113().myskill.template.type == 3 || Char.M113().myskill.template.id == 10 || Char.M113().myskill.template.id == 11 || (Char.M113().myskill.paintCanNotUseSkill && !GameCanvas.panel.isShow))
		{
			return;
		}
		int num = M2143();
		if (mSystem.M1054() - lastTimeSendAttack[num] > M2142(Char.M113().myskill))
		{
			if (GameScr.M559().M571(Char.M113().mobFocus))
			{
				Char.M113().myskill.lastTimeUseThisSkill = mSystem.M1054();
				M2141();
				lastTimeSendAttack[num] = mSystem.M1054();
			}
			else if (Char.M113().charFocus != null && M2138(Char.M113().charFocus) && (double)Math.M869(Char.M113().charFocus.cx - Char.M113().cx) < (double)Char.M113().myskill.dx * 1.7)
			{
				Char.M113().myskill.lastTimeUseThisSkill = mSystem.M1054();
				M2140();
				lastTimeSendAttack[num] = mSystem.M1054();
			}
		}
	}

	private static void M2136()
	{
		if (isPetAskedForUseSkill && GameScr.vMob.M1113() != 0 && Char.M113().myskill.template.type != 3)
		{
			Mob t = (Mob)GameScr.vMob.M1114(0);
			Char.M113().cx = t.x;
			Char.M113().cy = t.y;
			Char.M113().npcFocus = null;
			Char.M113().itemFocus = null;
			Char.M113().charFocus = null;
			Char.M113().mobFocus = t;
			if (!Char.M113().meDead)
			{
				GameScr.M559().M603(GameScr.keySkill[0]);
			}
			isPetAskedForUseSkill = false;
		}
	}

	private static void M2137(int skillIndex)
	{
		if (TileMap.mapID == 21 || TileMap.mapID == 22 || TileMap.mapID == 23)
		{
			return;
		}
		if (skillIndex >= GameScr.keySkill.Length)
		{
			skillIndex = GameScr.keySkill.Length - 1;
		}
		if (skillIndex < 0)
		{
			skillIndex = 0;
		}
		if (GameScr.keySkill[skillIndex] == null || GameScr.keySkill[skillIndex].paintCanNotUseSkill)
		{
			return;
		}
		if (GameScr.keySkill[skillIndex].coolDown == 0)
		{
			timeAutoSkills[skillIndex] = 500L;
		}
		else if (M2139(GameScr.keySkill[skillIndex]) && !GameScr.M559().M600() && mSystem.M1054() - lastTimeAutoUseSkill > 150L)
		{
			if (timeAutoSkills[skillIndex] == -1L && GameCanvas.gameTick % 20 == 0)
			{
				lastTimeUseSkill[skillIndex] = mSystem.M1054();
				lastTimeAutoUseSkill = mSystem.M1054();
				GameScr.M559().M601(GameScr.keySkill[skillIndex], isShortcut: true);
			}
			if (mSystem.M1054() - lastTimeUseSkill[skillIndex] > timeAutoSkills[skillIndex])
			{
				lastTimeUseSkill[skillIndex] = mSystem.M1054();
				lastTimeAutoUseSkill = mSystem.M1054();
				GameScr.M559().M601(GameScr.keySkill[skillIndex], isShortcut: true);
			}
		}
	}

	public static bool M2138(Char ch)
	{
		if (TileMap.mapID == 113)
		{
			if (ch != null && Char.M113().myskill != null)
			{
				if (ch.cTypePk != 5)
				{
					return ch.cTypePk == 3;
				}
				return true;
			}
			return false;
		}
		if (ch != null && Char.M113().myskill != null)
		{
			if (ch.statusMe == 14 || ch.statusMe == 5 || Char.M113().myskill.template.type == 2 || ((Char.M113().cFlag != 8 || ch.cFlag == 0) && (Char.M113().cFlag == 0 || ch.cFlag != 8) && (Char.M113().cFlag == ch.cFlag || Char.M113().cFlag == 0 || ch.cFlag == 0) && (ch.cTypePk != 3 || Char.M113().cTypePk != 3) && Char.M113().cTypePk != 5 && ch.cTypePk != 5 && (Char.M113().cTypePk != 1 || ch.cTypePk != 1) && (Char.M113().cTypePk != 4 || ch.cTypePk != 4)))
			{
				if (Char.M113().myskill.template.type == 2)
				{
					return ch.cTypePk != 5;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	private static bool M2139(Skill skillToUse)
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

	private static void M2140()
	{
		try
		{
			MyVector t = new MyVector();
			t.M1111(Char.M113().charFocus);
			Service.M1594().M1669(new MyVector(), t, 2);
		}
		catch
		{
		}
	}

	private static void M2141()
	{
		try
		{
			MyVector t = new MyVector();
			t.M1111(Char.M113().mobFocus);
			Service.M1594().M1669(t, new MyVector(), 1);
		}
		catch
		{
		}
	}

	private static long M2142(Skill skill)
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
			if (num < GameScr.keySkill.Length)
			{
				if (GameScr.keySkill[num] == Char.M113().myskill)
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
			GameScr.info1.M762("Danh sách chuyển mục tiêu trống!", 0);
			isAutoChangeFocus = false;
		}
		else
		{
			if (Char.M113().meDead || Char.M113().statusMe == 14 || Char.M113().statusMe == 5 || Char.M113().myskill.template.type == 3 || Char.M113().myskill.template.id == 10 || Char.M113().myskill.template.id == 11 || Char.M113().myskill.paintCanNotUseSkill)
			{
				return;
			}
			cooldownAutoChangeFocus = M2145(Char.M113().myskill);
			if (targetIndex >= listTargetAutoChangeFocus.Count)
			{
				targetIndex = 0;
			}
			if (mSystem.M1054() - lastTimeChangeFocus >= cooldownAutoChangeFocus)
			{
				lastTimeChangeFocus = mSystem.M1054();
				Char.M113().charFocus = GameScr.M626(listTargetAutoChangeFocus[targetIndex].charID);
				targetIndex++;
				if (targetIndex >= listTargetAutoChangeFocus.Count)
				{
					targetIndex = 0;
				}
				if (Char.M113().charFocus != null && M2138(Char.M113().charFocus) && (double)Math.M869(Char.M113().charFocus.cx - Char.M113().cx) < (double)Char.M113().myskill.dx * 1.5)
				{
					Char.M113().myskill.lastTimeUseThisSkill = mSystem.M1054();
					M2140();
				}
			}
		}
	}

	private static long M2145(Skill skill)
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
		GameScr.keySkill[num].coolDown = 0;
		GameScr.keySkill[num].manaUse = 0;
		GameScr.info1.M762("Đóng Băng\n" + GameScr.keySkill[num].template.name, 0);
	}
}
