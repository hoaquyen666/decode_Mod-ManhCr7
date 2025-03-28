namespace Utilities;

public class AutoPotentialEnhancer : IActionListener, IChatable
{
	private static AutoPotentialEnhancer _Instance;

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

	static AutoPotentialEnhancer()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		inputDamageAuto = new string[2] { "Nhập Sức Đánh Mà Bạn Muốn Auto", "Sức Đánh" };
		inputHPAuto = new string[2] { "Nhập HP Mà Bạn Muốn Auto", "HP" };
		inputMPAuto = new string[2] { "Nhập MP Mà Bạn Muốn Auto", "MP" };
		inputPointToAdd = new string[2] { "Nhập Chỉ Số Mà Bạn Muốn Cộng Thêm", "Chỉ Số" };
		inputPointAddTo = new string[2] { "Nhập Chỉ Số Mà Bạn Muốn Cộng Tới", "Chỉ Số" };
	}

	public static AutoPotentialEnhancer M2118()
	{
		if (_Instance == null)
		{
			_Instance = new AutoPotentialEnhancer();
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
		if (ChatTextField.M279().tfChat.M1924() != null && !ChatTextField.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (ChatTextField.M279().strChat.Equals(inputPointToAdd[0]))
			{
				try
				{
					int num = int.Parse(ChatTextField.M279().tfChat.M1924());
					if ((typePotential == 0 || typePotential == 1) && num % 20 != 0)
					{
						GameScr.info1.M762("Chỉ Số HP, MP Phải chia hết cho 20. Vui Lòng Nhập Lại!", 0);
						return;
					}
					if (typePotential == 0 || typePotential == 1)
					{
						num /= 20;
					}
					Service.M1594().M1719(typePotential, num);
					GameScr.info1.M762("Đã Cộng Xong!", 0);
				}
				catch
				{
					GameScr.info1.M762("Chỉ Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
			else if (ChatTextField.M279().strChat.Equals(inputPointAddTo[0]))
			{
				try
				{
					int num2 = int.Parse(ChatTextField.M279().tfChat.M1924());
					if ((typePotential == 0 || typePotential == 1) && num2 % 20 != 0)
					{
						GameScr.info1.M762("Chỉ Số HP, MP Phải chia hết cho 20. Vui Lòng Nhập Lại!", 0);
						return;
					}
					if (typePotential == 0 || typePotential == 1)
					{
						num2 /= 20;
					}
					int num3 = Char.M113().cHPGoc / 20;
					if (typePotential == 1)
					{
						num3 = Char.M113().cMPGoc / 20;
					}
					if (typePotential == 2)
					{
						num3 = Char.M113().cDamGoc;
					}
					if (typePotential == 3)
					{
						num3 = Char.M113().cDefGoc;
					}
					if (typePotential == 4)
					{
						num3 = Char.M113().cCriticalGoc;
					}
					if (num2 <= num3)
					{
						GameScr.info1.M762("Chỉ Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
						return;
					}
					Service.M1594().M1719(typePotential, num2 - num3);
					GameScr.info1.M762("Đã Cộng Xong!", 0);
				}
				catch
				{
					GameScr.info1.M762("Chỉ Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
			else if (ChatTextField.M279().strChat.Equals(inputDamageAuto[0]))
			{
				try
				{
					int num4 = (damageToAuto = int.Parse(ChatTextField.M279().tfChat.M1924()));
					GameScr.info1.M762("Auto Cộng Sức Đánh: " + NinjaUtil.M1192(num4), 0);
				}
				catch
				{
					GameScr.info1.M762("Sức Đánh Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
			else if (ChatTextField.M279().strChat.Equals(inputHPAuto[0]))
			{
				try
				{
					int num5 = (hpToAuto = int.Parse(ChatTextField.M279().tfChat.M1924()));
					GameScr.info1.M762("Auto Cộng HP: " + NinjaUtil.M1192(num5), 0);
				}
				catch
				{
					GameScr.info1.M762("HP Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
			else if (ChatTextField.M279().strChat.Equals(inputMPAuto[0]))
			{
				try
				{
					int num6 = (mpToAuto = int.Parse(ChatTextField.M279().tfChat.M1924()));
					GameScr.info1.M762("Auto Cộng MP: " + NinjaUtil.M1192(num6), 0);
				}
				catch
				{
					GameScr.info1.M762("MP Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2123();
			}
		}
		else
		{
			ChatTextField.M279().isShow = false;
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
			GameScr.info1.M762("Auto\n" + (isAutoPoint ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 4:
			ChatTextField.M279().strChat = inputDamageAuto[0];
			ChatTextField.M279().tfChat.name = inputDamageAuto[1];
			ChatTextField.M279().M282(M2118(), string.Empty);
			break;
		case 5:
			ChatTextField.M279().strChat = inputHPAuto[0];
			ChatTextField.M279().tfChat.name = inputHPAuto[1];
			ChatTextField.M279().M282(M2118(), string.Empty);
			break;
		case 6:
			ChatTextField.M279().strChat = inputMPAuto[0];
			ChatTextField.M279().tfChat.name = inputMPAuto[1];
			ChatTextField.M279().M282(M2118(), string.Empty);
			break;
		case 12:
			typePotential = (int)p;
			GameCanvas.panel.isShow = false;
			ChatTextField.M279().strChat = inputPointToAdd[0];
			ChatTextField.M279().tfChat.name = inputPointToAdd[1];
			ChatTextField.M279().M282(M2118(), string.Empty);
			break;
		case 13:
			typePotential = (int)p;
			GameCanvas.panel.isShow = false;
			ChatTextField.M279().strChat = inputPointAddTo[0];
			ChatTextField.M279().tfChat.name = inputPointAddTo[1];
			ChatTextField.M279().M282(M2118(), string.Empty);
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
		MyVector t = new MyVector();
		t.M1111(new Command("Auto\nCộng\nChỉ Số", M2118(), 1, null));
		GameCanvas.menu.M877(t, 3);
	}

	public static void M2121()
	{
		MyVector t = new MyVector();
		t.M1111(new Command("Auto\n" + (isAutoPoint ? "[STATUS: ON]" : "[STATUS: OFF]"), M2118(), 3, null));
		t.M1111(new Command("Sức Đánh\n[" + NinjaUtil.M1192(damageToAuto) + "]", M2118(), 4, null));
		t.M1111(new Command("HP\n[" + NinjaUtil.M1192(hpToAuto) + "]", M2118(), 5, null));
		t.M1111(new Command("MP\n[" + NinjaUtil.M1192(mpToAuto) + "]", M2118(), 6, null));
		GameCanvas.menu.M877(t, 3);
	}

	public static void M2122(int typePotential)
	{
		MyVector t = new MyVector();
		t.M1111(new Command("Cộng", M2118(), 12, typePotential));
		t.M1111(new Command("Cộng\nTới Mức", M2118(), 13, typePotential));
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2123()
	{
		ChatTextField.M279().strChat = "Chat";
		ChatTextField.M279().tfChat.name = "chat";
		ChatTextField.M279().isShow = false;
	}

	private static void M2124()
	{
	}

	private static void M2125()
	{
	}

	public static void M2126()
	{
		if (Char.M113().cDamGoc < damageToAuto)
		{
			if (Char.M113().cTiemNang > Char.M113().cDamGoc * 10000 + 495000 && GameCanvas.gameTick % 20 == 0)
			{
				Service.M1594().M1719(2, 3);
			}
			else if (Char.M113().cTiemNang > Char.M113().cDamGoc * 1000 + 4500 && GameCanvas.gameTick % 20 == 0)
			{
				Service.M1594().M1719(2, 2);
			}
			else if (Char.M113().cTiemNang > Char.M113().cDamGoc * 100 && GameCanvas.gameTick % 20 == 0)
			{
				Service.M1594().M1719(2, 1);
			}
		}
		else if (Char.M113().cHPGoc < hpToAuto)
		{
			if (Char.M113().cTiemNang > Char.M113().cHPGoc * 100 + 199000 && GameCanvas.gameTick % 20 == 0)
			{
				Service.M1594().M1719(0, 3);
			}
			else if (Char.M113().cTiemNang > Char.M113().cHPGoc * 10 + 10900 && GameCanvas.gameTick % 20 == 0)
			{
				Service.M1594().M1719(0, 2);
			}
			else if (Char.M113().cTiemNang > Char.M113().cHPGoc + 1000 && GameCanvas.gameTick % 20 == 0)
			{
				Service.M1594().M1719(0, 1);
			}
		}
		else if (Char.M113().cMPGoc < mpToAuto)
		{
			if (Char.M113().cTiemNang > Char.M113().cMPGoc * 100 + 199000 && GameCanvas.gameTick % 20 == 0)
			{
				Service.M1594().M1719(1, 3);
			}
			else if (Char.M113().cTiemNang > Char.M113().cMPGoc * 10 + 10900 && GameCanvas.gameTick % 20 == 0)
			{
				Service.M1594().M1719(1, 2);
			}
			else if (Char.M113().cTiemNang > Char.M113().cMPGoc + 1000 && GameCanvas.gameTick % 20 == 0)
			{
				Service.M1594().M1719(1, 1);
			}
		}
	}
}
