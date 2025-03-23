namespace N3.N4;

public class T193 : T57, T58
{
	private static T193 _Instance;

	public static int typePotential;

	public static bool isAutoPoint;

	public static int damageToAuto;

	public static int hpToAuto;

	public static int mpToAuto;

	public static string[] inputDamageAuto;

	public static string[] inputHPAuto;

	public static string[] inputMPAuto;

	public static string[] inputPointToAdd;

	public static string[] inputPointAddTo;

	static T193()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		inputDamageAuto = new string[2] { "Nhập Sức Đánh Mà Bạn Muốn Auto", "Sức Đánh" };
		inputHPAuto = new string[2] { "Nhập HP Mà Bạn Muốn Auto", "HP" };
		inputMPAuto = new string[2] { "Nhập MP Mà Bạn Muốn Auto", "MP" };
		inputPointToAdd = new string[2] { "Nhập Chỉ Số Mà Bạn Muốn Cộng Thêm", "Chỉ Số" };
		inputPointAddTo = new string[2] { "Nhập Chỉ Số Mà Bạn Muốn Cộng Tới", "Chỉ Số" };
	}

	public static T193 M2118()
	{
		if (_Instance == null)
		{
			_Instance = new T193();
		}
		return _Instance;
	}

	public static void M2119()
	{
		if (isAutoPoint)
		{
			M2126();
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (T15.M279().tfChat.M1924() != null && !T15.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (T15.M279().strChat.Equals(inputPointToAdd[0]))
			{
				try
				{
					int num = int.Parse(T15.M279().tfChat.M1924());
					if ((typePotential == 0 || typePotential == 1) && num % 20 != 0)
					{
						T54.info1.M762("Chỉ Số HP, MP Phải chia hết cho 20. Vui Lòng Nhập Lại!", 0);
						return;
					}
					if (typePotential == 0 || typePotential == 1)
					{
						num /= 20;
					}
					T146.M1594().M1719(typePotential, num);
					T54.info1.M762("Đã Cộng Xong!", 0);
				}
				catch
				{
					T54.info1.M762("Chỉ Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
			else if (T15.M279().strChat.Equals(inputPointAddTo[0]))
			{
				try
				{
					int num2 = int.Parse(T15.M279().tfChat.M1924());
					if ((typePotential == 0 || typePotential == 1) && num2 % 20 != 0)
					{
						T54.info1.M762("Chỉ Số HP, MP Phải chia hết cho 20. Vui Lòng Nhập Lại!", 0);
						return;
					}
					if (typePotential == 0 || typePotential == 1)
					{
						num2 /= 20;
					}
					int num3 = T13.M113().cHPGoc / 20;
					if (typePotential == 1)
					{
						num3 = T13.M113().cMPGoc / 20;
					}
					if (typePotential == 2)
					{
						num3 = T13.M113().cDamGoc;
					}
					if (typePotential == 3)
					{
						num3 = T13.M113().cDefGoc;
					}
					if (typePotential == 4)
					{
						num3 = T13.M113().cCriticalGoc;
					}
					if (num2 <= num3)
					{
						T54.info1.M762("Chỉ Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
						return;
					}
					T146.M1594().M1719(typePotential, num2 - num3);
					T54.info1.M762("Đã Cộng Xong!", 0);
				}
				catch
				{
					T54.info1.M762("Chỉ Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
			else if (T15.M279().strChat.Equals(inputDamageAuto[0]))
			{
				try
				{
					int num4 = (damageToAuto = int.Parse(T15.M279().tfChat.M1924()));
					T54.info1.M762("Auto Cộng Sức Đánh: " + T122.M1192(num4), 0);
				}
				catch
				{
					T54.info1.M762("Sức Đánh Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
			else if (T15.M279().strChat.Equals(inputHPAuto[0]))
			{
				try
				{
					int num5 = (hpToAuto = int.Parse(T15.M279().tfChat.M1924()));
					T54.info1.M762("Auto Cộng HP: " + T122.M1192(num5), 0);
				}
				catch
				{
					T54.info1.M762("HP Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
			else if (T15.M279().strChat.Equals(inputMPAuto[0]))
			{
				try
				{
					int num6 = (mpToAuto = int.Parse(T15.M279().tfChat.M1924()));
					T54.info1.M762("Auto Cộng MP: " + T122.M1192(num6), 0);
				}
				catch
				{
					T54.info1.M762("MP Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
		}
		else
		{
			T15.M279().isShow = false;
			M2123();
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
			M2121();
			break;
		case 3:
			isAutoPoint = !isAutoPoint;
			T54.info1.M762("Auto\n" + (isAutoPoint ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 4:
			T15.M279().strChat = inputDamageAuto[0];
			T15.M279().tfChat.name = inputDamageAuto[1];
			T15.M279().M282(M2118(), string.Empty);
			break;
		case 5:
			T15.M279().strChat = inputHPAuto[0];
			T15.M279().tfChat.name = inputHPAuto[1];
			T15.M279().M282(M2118(), string.Empty);
			break;
		case 6:
			T15.M279().strChat = inputMPAuto[0];
			T15.M279().tfChat.name = inputMPAuto[1];
			T15.M279().M282(M2118(), string.Empty);
			break;
		case 12:
			typePotential = (int)p;
			T51.panel.isShow = false;
			T15.M279().strChat = inputPointToAdd[0];
			T15.M279().tfChat.name = inputPointToAdd[1];
			T15.M279().M282(M2118(), string.Empty);
			break;
		case 13:
			typePotential = (int)p;
			T51.panel.isShow = false;
			T15.M279().strChat = inputPointAddTo[0];
			T15.M279().tfChat.name = inputPointAddTo[1];
			T15.M279().M282(M2118(), string.Empty);
			break;
		case 2:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
			break;
		}
	}

	public static void M2120()
	{
		M2124();
		T117 t = new T117();
		t.M1111(new T22("Auto\nCộng\nChỉ Số", M2118(), 1, null));
		T51.menu.M877(t, 3);
	}

	public static void M2121()
	{
		T117 t = new T117();
		t.M1111(new T22("Auto\n" + (isAutoPoint ? "[STATUS: ON]" : "[STATUS: OFF]"), M2118(), 3, null));
		t.M1111(new T22("Sức Đánh\n[" + T122.M1192(damageToAuto) + "]", M2118(), 4, null));
		t.M1111(new T22("HP\n[" + T122.M1192(hpToAuto) + "]", M2118(), 5, null));
		t.M1111(new T22("MP\n[" + T122.M1192(mpToAuto) + "]", M2118(), 6, null));
		T51.menu.M877(t, 3);
	}

	public static void M2122(int typePotential)
	{
		T117 t = new T117();
		t.M1111(new T22("Cộng", M2118(), 12, typePotential));
		t.M1111(new T22("Cộng\nTới Mức", M2118(), 13, typePotential));
		T51.menu.M877(t, 3);
	}

	private static void M2123()
	{
		T15.M279().strChat = "Chat";
		T15.M279().tfChat.name = "chat";
		T15.M279().isShow = false;
	}

	private static void M2124()
	{
	}

	private static void M2125()
	{
	}

	public static void M2126()
	{
		if (T13.M113().cDamGoc < damageToAuto)
		{
			if (T13.M113().cTiemNang > T13.M113().cDamGoc * 10000 + 495000 && T51.gameTick % 20 == 0)
			{
				T146.M1594().M1719(2, 3);
			}
			else if (T13.M113().cTiemNang > T13.M113().cDamGoc * 1000 + 4500 && T51.gameTick % 20 == 0)
			{
				T146.M1594().M1719(2, 2);
			}
			else if (T13.M113().cTiemNang > T13.M113().cDamGoc * 100 && T51.gameTick % 20 == 0)
			{
				T146.M1594().M1719(2, 1);
			}
		}
		else if (T13.M113().cHPGoc < hpToAuto)
		{
			if (T13.M113().cTiemNang > T13.M113().cHPGoc * 100 + 199000 && T51.gameTick % 20 == 0)
			{
				T146.M1594().M1719(0, 3);
			}
			else if (T13.M113().cTiemNang > T13.M113().cHPGoc * 10 + 10900 && T51.gameTick % 20 == 0)
			{
				T146.M1594().M1719(0, 2);
			}
			else if (T13.M113().cTiemNang > T13.M113().cHPGoc + 1000 && T51.gameTick % 20 == 0)
			{
				T146.M1594().M1719(0, 1);
			}
		}
		else if (T13.M113().cMPGoc < mpToAuto)
		{
			if (T13.M113().cTiemNang > T13.M113().cMPGoc * 100 + 199000 && T51.gameTick % 20 == 0)
			{
				T146.M1594().M1719(1, 3);
			}
			else if (T13.M113().cTiemNang > T13.M113().cMPGoc * 10 + 10900 && T51.gameTick % 20 == 0)
			{
				T146.M1594().M1719(1, 2);
			}
			else if (T13.M113().cTiemNang > T13.M113().cMPGoc + 1000 && T51.gameTick % 20 == 0)
			{
				T146.M1594().M1719(1, 1);
			}
		}
	}
}
