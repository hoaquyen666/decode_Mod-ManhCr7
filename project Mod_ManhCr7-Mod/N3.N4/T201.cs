using System;
using System.Threading;

namespace N3.N4;

public class T201 : T57
{
	private static T201 _Instance;

	public static bool HealingPower;

	public static bool autoFlag;

	public static bool DoBoss;

	public static bool DoBoss2;

	public static bool autoPotara;

	public static bool autoChangeFocus;

	public static bool aGimBoss;

	public static bool aWhis;

	private static bool petDiTheo;

	private static bool petBaoVe;

	private static bool petTanCong;

	private static bool petVeNha;

	public static float timeScale;

	static T201()
	{
		timeScale = 1.8f;
	}

	public static T201 M2220()
	{
		if (_Instance == null)
		{
			_Instance = new T201();
		}
		return _Instance;
	}

	public static void M2221()
	{
		T117 t = new T117();
		t.M1111(new T22("Auto trị thương bản thân(namek) " + (HealingPower ? "Bật" : "Tắt"), M2220(), 1, null));
		t.M1111(new T22("Auto cờ đen chống địch: " + (autoFlag ? "Bật" : "Tắt"), M2220(), 2, null));
		t.M1111(new T22("Auto boss", M2220(), 5, null));
		t.M1111(new T22("Yardat", M2220(), 8, null));
		T51.menu.M877(t, 3);
	}

	public void perform(int idAction, object p)
	{
		if (idAction != 1)
		{
			if (idAction == 2)
			{
				autoFlag = !autoFlag;
				new Thread(M2225).Start();
				T54.info1.M762(autoFlag ? "Auto Cờ đen chống địch: ON" : "Auto Cờ đen chống địch: OFF", 0);
			}
			if (idAction == 3)
			{
				DoBoss = !DoBoss;
				new Thread(M2227).Start();
				T54.info1.M762(DoBoss ? "Dò boss: ON" : "Dò boss: OFF", 0);
			}
			if (idAction == 4)
			{
				if (M2239(521))
				{
					DoBoss2 = !DoBoss2;
					new Thread(M2229).Start();
					T54.info1.M762(DoBoss2 ? "Dò boss VIP (TDLT) : ON" : "Dò boss VIP (TDLT): OFF", 0);
				}
				else
				{
					T54.info1.M762("TDLT đâu ???????", 0);
				}
			}
			if (idAction == 5)
			{
				T117 t = new T117();
				t.M1111(new T22(DoBoss ? "Dò boss: ON" : "Dò boss: OFF", M2220(), 3, null));
				t.M1111(new T22(DoBoss2 ? "Dò boss VIP (TDLT) : ON" : "Dò boss VIP (TDLT): OFF", M2220(), 4, null));
				t.M1111(new T22(aGimBoss ? "Auto gim boss : ON" : "Auto gim boss: OFF", M2220(), 9, null));
				t.M1111(new T22(aWhis ? "Auto Leo top whis: ON" : "Auto Leo top whis: OFF", M2220(), 10, null));
				T51.menu.M877(t, 3);
			}
			if (idAction == 6)
			{
				new Thread(M2230).Start();
				autoChangeFocus = !autoChangeFocus;
				T54.info1.M762("Auto đổi mục tiêu :  " + (autoChangeFocus ? "ON" : "Off"), 0);
			}
			if (idAction == 7)
			{
				new Thread(M2232).Start();
				autoPotara = !autoPotara;
				T54.info1.M762("Auto bông tai + đệ về nhà :  " + (autoPotara ? "ON" : "Off"), 0);
			}
			if (idAction == 8)
			{
				T117 t2 = new T117();
				t2.M1111(new T22(autoChangeFocus ? "Auto đổi mục tiêu : ON" : "Auto đổi mục tiêu: OFF", M2220(), 6, null));
				t2.M1111(new T22(autoPotara ? "Auto bông tai liên tục: ON" : "Auto bông tai liên tục: OFF", M2220(), 7, null));
				t2.M1111(new T22("Auto Trạng thái đệ khi tách bt", M2220(), 15, null));
				T51.menu.M877(t2, 3);
			}
			if (idAction == 9)
			{
				aGimBoss = !aGimBoss;
				new Thread(M2233).Start();
				T54.info1.M762("Auto gim boss: " + (aGimBoss ? "Bật" : "Tắt"), 0);
			}
			if (idAction == 10)
			{
				aWhis = !aWhis;
				new Thread(M2234).Start();
				T54.info1.M762("Auto leo Tháp Whis: " + (aWhis ? "Bật" : "Tắt"), 0);
			}
			if (idAction == 11)
			{
				petDiTheo = !petDiTheo;
				if (petDiTheo)
				{
					M2237(petDiTheo, petVeNha, petBaoVe, petVeNha);
				}
				new Thread((ThreadStart)delegate
				{
					M2236(0);
				}).Start();
			}
			if (idAction == 12)
			{
				petBaoVe = !petBaoVe;
				if (petBaoVe)
				{
					M2237(petBaoVe, petDiTheo, petVeNha, petVeNha);
				}
				new Thread((ThreadStart)delegate
				{
					M2236(1);
				}).Start();
			}
			if (idAction == 13)
			{
				petTanCong = !petTanCong;
				if (petTanCong)
				{
					M2237(petTanCong, petVeNha, petDiTheo, petBaoVe);
				}
				new Thread((ThreadStart)delegate
				{
					M2236(2);
				}).Start();
				if (idAction == 14)
				{
					petVeNha = !petVeNha;
					if (petVeNha)
					{
						M2237(petVeNha, petBaoVe, petDiTheo, petTanCong);
					}
					new Thread((ThreadStart)delegate
					{
						M2236(3);
					}).Start();
				}
			}
			if (idAction == 15)
			{
				T117 t3 = new T117();
				t3.M1111(new T22("Đi theo " + (petDiTheo ? "ON" : "OFF"), M2220(), 11, null));
				t3.M1111(new T22("Bảo vệ " + (petBaoVe ? "ON" : "OFF"), M2220(), 12, null));
				t3.M1111(new T22("Tấn công " + (petTanCong ? "ON" : "OFF"), M2220(), 13, null));
				t3.M1111(new T22("Về nhà " + (petVeNha ? "ON" : "OFF"), M2220(), 14, null));
				T51.menu.M877(t3, 3);
			}
		}
		else
		{
			HealingPower = !HealingPower;
			new Thread(M2224).Start();
		}
	}

	public static void M2222(T13 player)
	{
		try
		{
			T117 t = new T117();
			t.M1111(player);
			T146.M1594().M1669(new T117(), t, -1);
		}
		catch (Exception)
		{
		}
	}

	public static void M2223()
	{
		if (!T13.M113().meDead)
		{
			T146.M1594().M1652(7);
			M2222(T13.M113());
			T146.M1594().M1652(T13.M113().myskill.template.id);
		}
	}

	public static void M2224()
	{
		if (!T13.M113().M264().Equals("NM"))
		{
			HealingPower = false;
			T54.info1.M762("Chỉ namek mới có thể dùng !!", 0);
			return;
		}
		if (HealingPower)
		{
			T54.info1.M762("Auto trị thương bản thân: Bật", 0);
		}
		while (HealingPower)
		{
			M2223();
			Thread.Sleep(((T149)T13.M113().vSkillFight.M1114(2)).coolDown);
		}
		HealingPower = false;
		T54.info1.M762("Auto trị thương bản thân:Tắt", 0);
	}

	public static void M2225()
	{
		while (autoFlag)
		{
			if (!M2226() && T13.M113().cFlag == 0)
			{
				T146.M1594().M1726(1, 8);
			}
			if (M2226() && T13.M113().cFlag == 8)
			{
				T146.M1594().M1726(1, 0);
			}
			Thread.Sleep(1000);
		}
		while (T13.M113().cFlag != 0)
		{
			T146.M1594().M1726(1, 0);
			Thread.Sleep(5000);
		}
	}

	public static bool M2226()
	{
		int num = 0;
		while (true)
		{
			if (num < T54.vCharInMap.M1113())
			{
				T13 t = (T13)T54.vCharInMap.M1114(num);
				if (t.cFlag != 0 && t.charID > 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void M2227()
	{
		try
		{
			DoBoss2 = false;
			if (T174.mapID == 23 || T174.mapID == 21 || T174.mapID == 22 || T174.mapID == 47 || T174.mapID == 48 || T174.mapID == 50 || T174.mapID == 116)
			{
				DoBoss = false;
				T54.info1.M762("Boss đâu ra trong map này ông thần ??", 0);
				return;
			}
			if (M2228())
			{
				T54.info1.M762("Đã tìm thấy boss", 0);
				DoBoss = false;
				return;
			}
			int num = T174.zoneID + 1;
			T54.info1.M762("Bắt đầu tìm khu boss từ " + T174.zoneID + " đến khu 14", 0);
			Thread.Sleep(300);
			while (num <= 14 && DoBoss && !T13.M113().meDead)
			{
				T146.M1594().M1638(num, -1);
				Thread.Sleep(10400);
				num++;
				if (M2228())
				{
					T54.info1.M762("Đã tìm thấy boss", 0);
					break;
				}
			}
			DoBoss = false;
		}
		catch
		{
			T54.info1.M762("lỗi r", 0);
			DoBoss = false;
		}
	}

	public static bool M2228()
	{
		int num = 0;
		while (true)
		{
			if (num < T54.vCharInMap.M1113())
			{
				T13 t = (T13)T54.vCharInMap.M1114(num);
				if (t.cName != null && t.cName != "" && !t.isPet && !t.isMiniPet && char.IsUpper(char.Parse(t.cName.Substring(0, 1))) && t.cName != "Trọng tài" && !t.cName.StartsWith("#") && !t.cName.StartsWith("$"))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void M2229()
	{
		try
		{
			DoBoss = false;
			if (T174.mapID == 23 || T174.mapID == 21 || T174.mapID == 22 || T174.mapID == 47 || T174.mapID == 48 || T174.mapID == 50 || T174.mapID == 116)
			{
				DoBoss2 = false;
				T54.info1.M762("Boss đâu ra trong map này ông thần ??", 0);
				return;
			}
			if (M2228())
			{
				T54.info1.M762("Đã tìm thấy boss", 0);
				DoBoss2 = false;
				return;
			}
			if (!T86.M839(4387))
			{
				M2235(521);
			}
			int num = T174.zoneID + 1;
			T54.info1.M762("Bắt đầu tìm khu boss bằng tdlt từ " + T174.zoneID + " đến khu 14", 0);
			Thread.Sleep(300);
			while (num <= 14 && DoBoss2 && !T13.M113().meDead)
			{
				T146.M1594().M1638(num, -1);
				Thread.Sleep(5600);
				num++;
				if (M2228())
				{
					T54.info1.M762("Đã tìm thấy boss", 0);
					break;
				}
			}
			DoBoss2 = false;
			if (T86.M839(4387))
			{
				M2235(521);
			}
		}
		catch
		{
			if (T86.M839(4387))
			{
				M2235(521);
			}
			T54.info1.M762("Lỗi r", 0);
			DoBoss2 = false;
		}
	}

	public static void M2230()
	{
		while (autoChangeFocus)
		{
			T51.M442().M471(-7);
			Thread.Sleep(5000);
		}
	}

	public static T79 M2231(int id)
	{
		int num = 0;
		while (true)
		{
			if (num < T13.M113().arrItemBag.Length)
			{
				if (T13.M113().arrItemBag[num] != null && T13.M113().arrItemBag[num].template.id == id)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return T13.M113().arrItemBag[num];
	}

	public static void M2232()
	{
		while (autoPotara)
		{
			if (!T13.M113().meDead)
			{
				T146.M1594().M1615(0, 1, (sbyte)M2231(454).indexUI, -1);
				if (T13.M113().isNhapThe)
				{
					Thread.Sleep(11000);
				}
				else
				{
					Thread.Sleep(2000);
				}
			}
			Thread.Sleep(100);
		}
	}

	public static void M2233()
	{
		while (aGimBoss)
		{
			for (int i = 0; i < T54.vCharInMap.M1113(); i++)
			{
				T13 t = (T13)T54.vCharInMap.M1114(i);
				if (t.cName != null && t.cName != "" && !t.isPet && !t.isMiniPet && char.IsUpper(char.Parse(t.cName.Substring(0, 1))) && t.cName != "Trọng tài" && !t.cName.StartsWith("#") && !t.cName.StartsWith("$"))
				{
					T13.M113().npcFocus = null;
					T13.M113().charFocus = null;
					T13.M113().mobFocus = null;
					T13.M113().charFocus = t;
				}
			}
			Thread.Sleep(500);
		}
	}

	public static void M2234()
	{
		bool flag = false;
		if (T174.mapID != 154)
		{
			T54.info1.M762("Chạy lên map hành tinh bill đi", 0);
			aWhis = false;
			return;
		}
		while (aWhis && !T13.M113().meDead)
		{
			T146.M1594().M1656(56);
			T146.M1594().M1655(56, 3);
			if (!T13.M113().isNhapThe)
			{
				M2235(454);
			}
			Thread.Sleep(500);
			while (T54.vCharInMap.M1113() != 0)
			{
				T194.isAutoSendAttack = true;
				Thread.Sleep(3000);
				flag = true;
			}
			Thread.Sleep(3500);
			if (!flag)
			{
				break;
			}
			flag = false;
		}
		T54.info1.M762("Cậu cook rồi à, tới ngắt auto nhá !", 0);
		T194.isAutoSendAttack = false;
		aWhis = false;
	}

	public static void M2235(int x)
	{
		sbyte b = 0;
		while (true)
		{
			if (b < T13.M113().arrItemBag.Length)
			{
				if (T13.M113().arrItemBag[b].template.id == x)
				{
					break;
				}
				b++;
				continue;
			}
			return;
		}
		T146.M1594().M1615(0, 1, b, -1);
	}

	public static void M2236(int x)
	{
		while ((petDiTheo || petBaoVe || petTanCong || petVeNha) && !T13.M113().isNhapThe)
		{
			T146.M1594().M1728((sbyte)x);
			Thread.Sleep(3000);
		}
	}

	public static void M2237(bool a = true, bool b = false, bool c = false, bool d = false)
	{
	}

	public static void M2238(string text, string to)
	{
		if (text.StartsWith("k_"))
		{
			try
			{
				int zoneId = int.Parse(text.Split('_')[1]);
				T146.M1594().M1638(zoneId, -1);
			}
			catch
			{
			}
		}
		if (text.StartsWith("s_"))
		{
			try
			{
				int num = (T200.runSpeed = int.Parse(text.Split('_')[1]));
				T54.info1.M762("Tốc Độ Di Chuyển: " + num, 0);
			}
			catch
			{
			}
		}
	}

	public static bool M2239(int x)
	{
		sbyte b = 0;
		while (true)
		{
			if (b < T13.M113().arrItemBag.Length)
			{
				if (T13.M113().arrItemBag[b].template.id == x)
				{
					break;
				}
				b++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static int M2240()
	{
		int result = 0;
		sbyte b = 0;
		while (b < T13.M113().arrItemBag.Length)
		{
			if (T13.M113().arrItemBag[b].template.id != 521)
			{
				b++;
				continue;
			}
			result = T13.M113().arrItemBag[b].itemOption[0].param;
			break;
		}
		return result;
	}

	public static bool M2241()
	{
		if (!T86.M839(4387))
		{
			if (M2239(521))
			{
				return M2240() != 0;
			}
			return false;
		}
		return true;
	}
}
