using System;

namespace Assets.src.g;

public class RegisterScreen : mScreen, IActionListener
{
	public TField tfUser;

	public TField tfNgay;

	public TField tfThang;

	public TField tfNam;

	public TField tfDiachi;

	public TField tfCMND;

	public TField tfNgayCap;

	public TField tfNoiCap;

	public TField tfSodt;

	public static bool isContinueToLogin = false;

	private int focus;

	private int wC;

	private int yL;

	private int defYL;

	public bool isCheck;

	public bool isRes;

	private Command cmdLogin;

	private Command cmdCheck;

	private Command cmdFogetPass;

	private Command cmdRes;

	private Command cmdMenu;

	private Command cmdBackFromRegister;

	public string listFAQ = string.Empty;

	public string titleFAQ;

	public string subtitleFAQ;

	private string numSupport = string.Empty;

	private string strUser;

	private string strPass;

	public static bool isLocal = false;

	public static bool isUpdateAll;

	public static bool isUpdateData;

	public static bool isUpdateMap;

	public static bool isUpdateSkill;

	public static bool isUpdateItem;

	public static string serverName;

	public static Image imgTitle;

	public int plX;

	public int plY;

	public int lY;

	public int lX;

	public int logoDes;

	public int lineX;

	public int lineY;

	public static int[] bgId = new int[5] { 0, 8, 2, 6, 9 };

	public static bool isTryGetIPFromWap;

	public static short timeLogin;

	public static long lastTimeLogin;

	public static long currTimeLogin;

	private int yt;

	private Command cmdSelect;

	private Command cmdOK;

	private int xLog;

	private int yLog;

	private int xP;

	private int yP;

	private int wP;

	private int hP;

	private string passRe = string.Empty;

	public bool isFAQ;

	private int tipid = -1;

	public bool isLogin2;

	private int v = 2;

	private int g;

	private int ylogo = -40;

	private int dir = 1;

	public static bool isLoggingIn;

	public RegisterScreen(sbyte haveName)
	{
		yLog = 130;
		TileMap.bgID = (sbyte)(mSystem.M1054() % 9L);
		if (TileMap.bgID == 5 || TileMap.bgID == 6)
		{
			TileMap.bgID = 4;
		}
		GameScr.M564(fullmScreen: true, -1, -1);
		GameScr.cmx = 100;
		GameScr.cmy = 200;
		if (GameCanvas.h > 200)
		{
			defYL = GameCanvas.hh - 80;
		}
		else
		{
			defYL = GameCanvas.hh - 65;
		}
		M2304();
		wC = ((GameCanvas.w < 200) ? 140 : 160);
		yt = GameCanvas.hh - mScreen.ITEM_HEIGHT - 5;
		if (GameCanvas.h <= 160)
		{
			yt = 20;
		}
		tfSodt = new TField();
		tfSodt.M1931(TField.INPUT_TYPE_NUMERIC);
		tfSodt.width = 220;
		tfSodt.height = mScreen.ITEM_HEIGHT + 2;
		tfSodt.name = "Số điện thoại/ địa chỉ email";
		if (haveName == 1)
		{
			tfSodt.M1926("01234567890");
		}
		tfUser = new TField();
		tfUser.width = 220;
		tfUser.height = mScreen.ITEM_HEIGHT + 2;
		tfUser.isFocus = true;
		tfUser.name = "Họ và tên";
		if (haveName == 1)
		{
			tfUser.M1926("Nguyễn Văn A");
		}
		tfUser.M1931(TField.INPUT_TYPE_ANY);
		tfNgay = new TField();
		tfNgay.M1931(TField.INPUT_TYPE_NUMERIC);
		tfNgay.width = 70;
		tfNgay.height = mScreen.ITEM_HEIGHT + 2;
		tfNgay.name = "Ngày sinh";
		if (haveName == 1)
		{
			tfNgay.M1926("01");
		}
		tfThang = new TField();
		tfThang.M1931(TField.INPUT_TYPE_NUMERIC);
		tfThang.width = 70;
		tfThang.height = mScreen.ITEM_HEIGHT + 2;
		tfThang.name = "Tháng sinh";
		if (haveName == 1)
		{
			tfThang.M1926("01");
		}
		tfNam = new TField();
		tfNam.M1931(TField.INPUT_TYPE_NUMERIC);
		tfNam.width = 70;
		tfNam.height = mScreen.ITEM_HEIGHT + 2;
		tfNam.name = "Năm sinh";
		if (haveName == 1)
		{
			tfNam.M1926("1990");
		}
		tfDiachi = new TField();
		tfDiachi.M1931(TField.INPUT_TYPE_ANY);
		tfDiachi.width = 220;
		tfDiachi.height = mScreen.ITEM_HEIGHT + 2;
		tfDiachi.name = "Địa chỉ đăng ký thường trú";
		if (haveName == 1)
		{
			tfDiachi.M1926("123 đường số 1, Quận 1, TP.HCM");
		}
		tfCMND = new TField();
		tfCMND.M1931(TField.INPUT_TYPE_NUMERIC);
		tfCMND.width = 220;
		tfCMND.height = mScreen.ITEM_HEIGHT + 2;
		tfCMND.name = "Số Chứng minh nhân dân hoặc số hộ chiếu";
		if (haveName == 1)
		{
			tfCMND.M1926("123456789");
		}
		tfNgayCap = new TField();
		tfNgayCap.M1931(TField.INPUT_TYPE_NUMERIC);
		tfNgayCap.width = 220;
		tfNgayCap.height = mScreen.ITEM_HEIGHT + 2;
		tfNgayCap.name = "Ngày cấp";
		if (haveName == 1)
		{
			tfNgayCap.M1926("01/01/2005");
		}
		tfNoiCap = new TField();
		tfNoiCap.M1931(TField.INPUT_TYPE_ANY);
		tfNoiCap.width = 220;
		tfNoiCap.height = mScreen.ITEM_HEIGHT + 2;
		tfNoiCap.name = "Nơi cấp";
		if (haveName == 1)
		{
			tfNoiCap.M1926("TP.HCM");
		}
		yt += 35;
		isCheck = true;
		focus = 0;
		cmdLogin = new Command((GameCanvas.w <= 200) ? mResources.login2 : mResources.login, GameCanvas.instance, 888393, null);
		cmdCheck = new Command(mResources.remember, this, 2001, null);
		cmdRes = new Command(mResources.register, this, 2002, null);
		cmdBackFromRegister = new Command(mResources.CANCEL, this, 10021, null);
		left = (cmdMenu = new Command(mResources.MENU, this, 2003, null));
		if (GameCanvas.isTouch)
		{
			cmdLogin.x = GameCanvas.w / 2 - 100;
			cmdMenu.x = GameCanvas.w / 2 - mScreen.cmdW - 8;
			if (GameCanvas.h >= 200)
			{
				cmdLogin.y = GameCanvas.h / 2 - 40;
				cmdMenu.y = yLog + 110;
			}
			cmdBackFromRegister.x = GameCanvas.w / 2 + 3;
			cmdBackFromRegister.y = yLog + 110;
			cmdRes.x = GameCanvas.w / 2 - 84;
			cmdRes.y = cmdMenu.y;
		}
		wP = 170;
		hP = ((!isRes) ? 100 : 110);
		xP = GameCanvas.hw - wP / 2;
		yP = tfUser.y - 15;
		int num = 4;
		int num2 = 184;
		if (184 >= GameCanvas.w)
		{
			num2 = (num - 1) * 32 + 23 + 33;
		}
		xLog = GameCanvas.w / 2 - num2 / 2;
		yLog = 5;
		lY = ((GameCanvas.w < 200) ? (tfUser.y - 30) : (yLog - 30));
		tfUser.x = xLog + 10;
		tfUser.y = yLog + 20;
		cmdOK = new Command(mResources.OK, this, 2008, null);
		cmdOK.x = 260;
		cmdOK.y = GameCanvas.h - 60;
		cmdFogetPass = new Command("Thoát", this, 1003, null);
		cmdFogetPass.x = 260;
		cmdFogetPass.y = GameCanvas.h - 30;
		if (GameCanvas.w < 250)
		{
			cmdOK.x = GameCanvas.w / 2 - 80;
			cmdFogetPass.x = GameCanvas.w / 2 + 10;
			cmdFogetPass.y = (cmdOK.y = GameCanvas.h - 25);
		}
		center = cmdOK;
		left = cmdFogetPass;
	}

	public void M2290()
	{
		Res.M1513("Res switch");
		SoundMn.M1826().M1873();
		focus = 0;
		tfUser.isFocus = true;
		tfNgay.isFocus = false;
		if (GameCanvas.isTouch)
		{
			tfUser.isFocus = false;
			focus = -1;
		}
		base.switchToMe();
	}

	protected void M2291()
	{
		MyVector t = new MyVector("vMenu Login");
		t.M1111(new Command(mResources.registerNewAcc, this, 2004, null));
		if (!isLogin2)
		{
			t.M1111(new Command(mResources.selectServer, this, 1004, null));
		}
		t.M1111(new Command(mResources.forgetPass, this, 1003, null));
		t.M1111(new Command(mResources.website, this, 1005, null));
		if (Rms.M1542("lowGraphic") == 1)
		{
			t.M1111(new Command(mResources.increase_vga, this, 10041, null));
		}
		else
		{
			t.M1111(new Command(mResources.decrease_vga, this, 10042, null));
		}
		t.M1111(new Command(mResources.EXIT, GameCanvas.instance, 8885, null));
		GameCanvas.menu.M877(t, 0);
	}

	protected void M2292()
	{
		if (tfUser.M1924().Equals(string.Empty))
		{
			GameCanvas.M489(mResources.userBlank);
			return;
		}
		tfUser.M1924().ToCharArray();
		if (tfNgay.M1924().Equals(string.Empty))
		{
			GameCanvas.M489(mResources.passwordBlank);
			return;
		}
		if (tfUser.M1924().Length < 5)
		{
			GameCanvas.M489(mResources.accTooShort);
			return;
		}
		int num = 0;
		string text = null;
		if (mResources.language == 2)
		{
			if (tfUser.M1924().IndexOf("@") == -1 || tfUser.M1924().IndexOf(".") == -1)
			{
				text = mResources.emailInvalid;
			}
			num = 0;
		}
		else
		{
			try
			{
				long.Parse(tfUser.M1924());
				if (tfUser.M1924().Length < 8 || tfUser.M1924().Length > 12 || (!tfUser.M1924().StartsWith("0") && !tfUser.M1924().StartsWith("84")))
				{
					text = mResources.phoneInvalid;
				}
				num = 1;
			}
			catch (Exception)
			{
				if (tfUser.M1924().IndexOf("@") == -1 || tfUser.M1924().IndexOf(".") == -1)
				{
					text = mResources.emailInvalid;
				}
				num = 0;
			}
		}
		if (text != null)
		{
			GameCanvas.M489(text);
		}
		else
		{
			GameCanvas.msgdlg.M1037(mResources.plsCheckAcc + ((num != 1) ? (mResources.email + ": ") : (mResources.phone + ": ")) + tfUser.M1924() + "\n" + mResources.password + ": " + tfNgay.M1924(), new Command(mResources.ACCEPT, this, 4000, null), null, new Command(mResources.NO, GameCanvas.instance, 8882, null));
		}
		GameCanvas.currentDialog = GameCanvas.msgdlg;
	}

	protected void M2293(string user)
	{
	}

	public void M2294()
	{
		if (listFAQ.Equals(string.Empty))
		{
			listFAQ.Equals(string.Empty);
		}
		if (!Session_ME.connected)
		{
			isFAQ = true;
			GameCanvas.M449();
		}
		GameCanvas.M492();
	}

	protected void M2295()
	{
		MyVector t = new MyVector("vServer");
		if (isLocal)
		{
			t.M1111(new Command("Server LOCAL", this, 20004, null));
		}
		t.M1111(new Command("Server Bokken", this, 20001, null));
		t.M1111(new Command("Server Shuriken", this, 20002, null));
		t.M1111(new Command("Server Tessen (mới)", this, 20003, null));
		GameCanvas.menu.M877(t, 0);
		if (M2297() != -1 && !GameCanvas.isTouch)
		{
			GameCanvas.menu.menuSelectedItem = M2297();
		}
	}

	protected void M2296(int index)
	{
		Rms.M1543("indServer", index);
	}

	protected int M2297()
	{
		return Rms.M1542("indServer");
	}

	public void M2298()
	{
	}

	public void M2299()
	{
	}

	public override void update()
	{
		tfUser.M1920();
		tfNgay.M1920();
		tfThang.M1920();
		tfNam.M1920();
		tfDiachi.M1920();
		tfCMND.M1920();
		tfNoiCap.M1920();
		tfSodt.M1920();
		tfNgayCap.M1920();
		for (int i = 0; i < Effect2.vEffect2.M1113(); i++)
		{
			((Effect2)Effect2.vEffect2.M1114(i)).update();
		}
		if (isUpdateAll && !isUpdateData && !isUpdateItem && !isUpdateMap && !isUpdateSkill)
		{
			isUpdateAll = false;
			mSystem.M1062();
			Service.M1594().M1711();
		}
		GameScr.cmx++;
		if (GameScr.cmx > GameCanvas.w * 3 + 100)
		{
			GameScr.cmx = 100;
		}
		if (ChatPopup.currChatPopup != null)
		{
			return;
		}
		GameCanvas.M456("LGU1", 0);
		GameCanvas.M456("LGU2", 0);
		GameCanvas.M456("LGU3", 0);
		M2301();
		GameCanvas.M456("LGU4", 0);
		GameCanvas.M456("LGU5", 0);
		if (g >= 0)
		{
			ylogo += dir * g;
			g += dir * v;
			if (g <= 0)
			{
				dir *= -1;
			}
			if (ylogo > 0)
			{
				dir *= -1;
				g -= 2 * v;
			}
		}
		GameCanvas.M456("LGU6", 0);
		if (tipid >= 0 && GameCanvas.gameTick % 100 == 0)
		{
			M2300();
		}
		if (GameCanvas.isTouch)
		{
			if (isRes)
			{
				center = cmdRes;
				left = cmdBackFromRegister;
			}
			else
			{
				center = cmdOK;
				left = cmdFogetPass;
			}
		}
		else if (isRes)
		{
			center = cmdRes;
			left = cmdBackFromRegister;
		}
		else
		{
			center = cmdOK;
			left = cmdFogetPass;
		}
	}

	private void M2300()
	{
		tipid++;
		if (tipid >= mResources.tips.Length)
		{
			tipid = 0;
		}
		if (GameCanvas.currentDialog == GameCanvas.msgdlg && GameCanvas.msgdlg.isWait)
		{
			GameCanvas.msgdlg.M1036(mResources.tips[tipid]);
		}
	}

	public void M2301()
	{
		if (defYL != yL)
		{
			yL += defYL - yL >> 1;
		}
	}

	public override void keyPress(int keyCode)
	{
		if (tfUser.isFocus)
		{
			tfUser.M1913(keyCode);
		}
		else if (tfNgay.isFocus)
		{
			tfNgay.M1913(keyCode);
		}
		else if (tfThang.isFocus)
		{
			tfThang.M1913(keyCode);
		}
		else if (tfNam.isFocus)
		{
			tfNam.M1913(keyCode);
		}
		else if (tfDiachi.isFocus)
		{
			tfDiachi.M1913(keyCode);
		}
		else if (tfCMND.isFocus)
		{
			tfCMND.M1913(keyCode);
		}
		else if (tfNoiCap.isFocus)
		{
			tfNoiCap.M1913(keyCode);
		}
		else if (tfSodt.isFocus)
		{
			tfSodt.M1913(keyCode);
		}
		else if (tfNgayCap.isFocus)
		{
			tfNgayCap.M1913(keyCode);
		}
		base.keyPress(keyCode);
	}

	public override void unLoad()
	{
		base.unLoad();
	}

	public override void paint(mGraphics g)
	{
		GameCanvas.M456("PLG1", 1);
		GameCanvas.M466(g);
		GameCanvas.M456("PLG2", 2);
		int num = tfUser.y - 50;
		if (GameCanvas.h <= 220)
		{
			num += 5;
		}
		if (ChatPopup.currChatPopup != null || ChatPopup.serverChatPopUp != null)
		{
			return;
		}
		if (GameCanvas.currentDialog == null)
		{
			xLog = 5;
			int num2 = 233;
			if (GameCanvas.w < 260)
			{
				xLog = (GameCanvas.w - 240) / 2;
			}
			yLog = (GameCanvas.h - num2) / 2;
			PopUp.M1481(g, xLog, yLog, 240, num2, -1, isButton: true);
			if (GameCanvas.h > 160 && imgTitle != null)
			{
				g.M948(imgTitle, GameCanvas.hw, num, 3);
			}
			GameCanvas.M456("PLG4", 1);
			int num3 = 4;
			if (184 >= GameCanvas.w)
			{
				num3--;
			}
			tfSodt.x = xLog + 10;
			tfSodt.y = yLog + 15;
			tfUser.x = tfSodt.x;
			tfUser.y = tfSodt.y + 30;
			tfNgay.x = xLog + 10;
			tfNgay.y = tfUser.y + 30;
			tfThang.x = tfNgay.x + 75;
			tfThang.y = tfNgay.y;
			tfNam.x = tfThang.x + 75;
			tfNam.y = tfThang.y;
			tfDiachi.x = tfUser.x;
			tfDiachi.y = tfNgay.y + 30;
			tfCMND.x = tfUser.x;
			tfCMND.y = tfDiachi.y + 30;
			tfNgayCap.x = tfUser.x;
			tfNgayCap.y = tfCMND.y + 30;
			tfNoiCap.x = tfUser.x;
			tfNoiCap.y = tfNgayCap.y + 30;
			tfUser.M1916(g);
			tfNgay.M1916(g);
			tfThang.M1916(g);
			tfNam.M1916(g);
			tfDiachi.M1916(g);
			tfCMND.M1916(g);
			tfNgayCap.M1916(g);
			tfNoiCap.M1916(g);
			tfSodt.M1916(g);
			if (GameCanvas.w < 176)
			{
				mFont.tahoma_7b_green2.M898(g, mResources.acc + ":", tfUser.x - 35, tfUser.y + 7, 0);
				mFont.tahoma_7b_green2.M898(g, mResources.pwd + ":", tfNgay.x - 35, tfNgay.y + 7, 0);
				mFont.tahoma_7b_green2.M898(g, mResources.server + ": " + serverName, GameCanvas.w / 2, tfNgay.y + 32, 2);
			}
		}
		string vERSION = GameMidlet.VERSION;
		g.M933(GameCanvas.skyColor);
		g.M932(GameCanvas.w - 40, 4, 36, 11);
		mFont.tahoma_7_grey.M898(g, vERSION, GameCanvas.w - 22, 4, mFont.CENTER);
		GameCanvas.M451(g);
		if (GameCanvas.currentDialog == null)
		{
			if (GameCanvas.w > 250)
			{
				mFont.tahoma_7b_white.M902(g, "Dưới 18 tuổi", 260, 10, 0, mFont.tahoma_7b_dark);
				mFont.tahoma_7b_white.M902(g, "chỉ có thể chơi", 260, 25, 0, mFont.tahoma_7b_dark);
				mFont.tahoma_7b_white.M902(g, "180p 1 ngày", 260, 40, 0, mFont.tahoma_7b_dark);
			}
			else
			{
				mFont.tahoma_7b_white.M902(g, "Dưới 18 tuổi chỉ có thể chơi", GameCanvas.w / 2, 5, 2, mFont.tahoma_7b_dark);
				mFont.tahoma_7b_white.M902(g, "180p 1 ngày", GameCanvas.w / 2, 15, 2, mFont.tahoma_7b_dark);
			}
		}
		base.paint(g);
	}

	private void M2302()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		tfUser.isFocus = false;
		tfNgay.isFocus = false;
		tfThang.isFocus = false;
		tfNam.isFocus = false;
		tfDiachi.isFocus = false;
		tfCMND.isFocus = false;
		tfNgayCap.isFocus = false;
		tfNoiCap.isFocus = false;
		tfSodt.isFocus = false;
	}

	private void M2303()
	{
		M2302();
		switch (focus)
		{
		case 0:
			tfUser.isFocus = true;
			break;
		case 1:
			tfNgay.isFocus = true;
			break;
		case 2:
			tfThang.isFocus = true;
			break;
		case 3:
			tfNam.isFocus = true;
			break;
		case 4:
			tfDiachi.isFocus = true;
			break;
		case 5:
			tfCMND.isFocus = true;
			break;
		case 6:
			tfNgayCap.isFocus = true;
			break;
		case 7:
			tfNoiCap.isFocus = true;
			break;
		case 8:
			tfSodt.isFocus = true;
			break;
		}
	}

	public override void updateKey()
	{
		if (isContinueToLogin)
		{
			return;
		}
		if (!GameCanvas.isTouch)
		{
			if (tfUser.isFocus)
			{
				right = tfUser.cmdClear;
			}
			else if (tfNgay.isFocus)
			{
				right = tfNgay.cmdClear;
			}
			else if (tfThang.isFocus)
			{
				right = tfThang.cmdClear;
			}
			else if (tfNam.isFocus)
			{
				right = tfNam.cmdClear;
			}
			else if (tfDiachi.isFocus)
			{
				right = tfDiachi.cmdClear;
			}
			else if (tfCMND.isFocus)
			{
				right = tfCMND.cmdClear;
			}
			else if (tfNgayCap.isFocus)
			{
				right = tfNgayCap.cmdClear;
			}
			else if (tfNoiCap.isFocus)
			{
				right = tfNoiCap.cmdClear;
			}
			else if (tfSodt.isFocus)
			{
				right = tfSodt.cmdClear;
			}
		}
		if (GameCanvas.keyPressed[21])
		{
			focus--;
			if (focus < 0)
			{
				focus = 8;
			}
			M2303();
		}
		else if (GameCanvas.keyPressed[22])
		{
			focus++;
			if (focus > 8)
			{
				focus = 0;
			}
			M2303();
		}
		if (GameCanvas.keyPressed[21] || GameCanvas.keyPressed[22])
		{
			GameCanvas.M483();
			if (!isLogin2 || isRes)
			{
				if (focus == 1)
				{
					tfUser.isFocus = false;
					tfNgay.isFocus = true;
				}
				else if (focus == 0)
				{
					tfUser.isFocus = true;
					tfNgay.isFocus = false;
				}
				else
				{
					tfUser.isFocus = false;
					tfNgay.isFocus = false;
				}
			}
		}
		if (GameCanvas.isTouch)
		{
			if (isRes)
			{
				center = cmdRes;
				left = cmdBackFromRegister;
			}
			else
			{
				center = cmdOK;
				left = cmdFogetPass;
			}
		}
		else if (isRes)
		{
			center = cmdRes;
			left = cmdBackFromRegister;
		}
		else
		{
			center = cmdOK;
			left = cmdFogetPass;
		}
		if (GameCanvas.isPointerJustRelease)
		{
			if (GameCanvas.M481(tfUser.x, tfUser.y, tfUser.width, tfUser.height))
			{
				focus = 0;
				M2303();
			}
			else if (GameCanvas.M481(tfNgay.x, tfNgay.y, tfNgay.width, tfNgay.height))
			{
				focus = 1;
				M2303();
			}
			else if (GameCanvas.M481(tfThang.x, tfThang.y, tfThang.width, tfThang.height))
			{
				focus = 2;
				M2303();
			}
			else if (GameCanvas.M481(tfNam.x, tfNam.y, tfNam.width, tfNam.height))
			{
				focus = 3;
				M2303();
			}
			else if (GameCanvas.M481(tfDiachi.x, tfDiachi.y, tfDiachi.width, tfDiachi.height))
			{
				focus = 4;
				M2303();
			}
			else if (GameCanvas.M481(tfCMND.x, tfCMND.y, tfCMND.width, tfCMND.height))
			{
				focus = 5;
				M2303();
			}
			else if (GameCanvas.M481(tfNgayCap.x, tfNgayCap.y, tfNgayCap.width, tfNgayCap.height))
			{
				focus = 6;
				M2303();
			}
			else if (GameCanvas.M481(tfNoiCap.x, tfNoiCap.y, tfNoiCap.width, tfNoiCap.height))
			{
				focus = 7;
				M2303();
			}
			else if (GameCanvas.M481(tfSodt.x, tfSodt.y, tfSodt.width, tfSodt.height))
			{
				focus = 8;
				M2303();
			}
		}
		base.updateKey();
		GameCanvas.M483();
	}

	public void M2304()
	{
		yL = -50;
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 2001:
			if (isCheck)
			{
				isCheck = false;
			}
			else
			{
				isCheck = true;
			}
			break;
		case 2002:
			M2292();
			break;
		case 2003:
			M2291();
			break;
		case 2004:
			M2306();
			break;
		case 2008:
			if (!tfNgay.M1924().Equals(string.Empty) && !tfThang.M1924().Equals(string.Empty) && !tfNam.M1924().Equals(string.Empty) && !tfDiachi.M1924().Equals(string.Empty) && !tfCMND.M1924().Equals(string.Empty) && !tfNgayCap.M1924().Equals(string.Empty) && !tfNoiCap.M1924().Equals(string.Empty) && !tfSodt.M1924().Equals(string.Empty) && !tfUser.M1924().Equals(string.Empty))
			{
				GameCanvas.M489(mResources.PLEASEWAIT);
				Service.M1594().M1597(tfNgay.M1924(), tfThang.M1924(), tfNam.M1924(), tfDiachi.M1924(), tfCMND.M1924(), tfNgayCap.M1924(), tfNoiCap.M1924(), tfSodt.M1924(), tfUser.M1924());
			}
			else
			{
				GameCanvas.M489("Vui lòng điền đầy đủ thông tin");
			}
			break;
		case 1000:
			try
			{
				GameMidlet.instance.M524((string)p);
			}
			catch (Exception ex2)
			{
				ex2.StackTrace.ToString();
			}
			GameCanvas.M488();
			break;
		case 1001:
			GameCanvas.M488();
			isRes = false;
			break;
		case 1003:
			Session_ME.M1744().close();
			GameCanvas.serverScreen.switchToMe();
			break;
		case 1004:
			ServerListScreen.M1580();
			GameCanvas.serverScreen.switchToMe();
			break;
		case 1005:
			try
			{
				GameMidlet.instance.M524("http://ngocrongonline.com");
				break;
			}
			catch (Exception ex)
			{
				ex.StackTrace.ToString();
				break;
			}
		case 10021:
			M2305();
			break;
		case 4000:
			M2293(tfUser.M1924());
			break;
		}
	}

	public void M2305()
	{
		if (isLogin2)
		{
			M2298();
			return;
		}
		isRes = false;
		tfNgay.isFocus = false;
		tfUser.isFocus = true;
		left = cmdMenu;
	}

	public void M2306()
	{
		GameCanvas.M488();
		GameCanvas.M489(mResources.regNote);
		isRes = true;
		tfNgay.isFocus = false;
		tfUser.isFocus = true;
	}

	public void M2307()
	{
		if (GameCanvas.loginScr.isLogin2)
		{
			GameCanvas.M496(mResources.note, new Command(mResources.YES, GameCanvas.panel, 10019, null), new Command(mResources.NO, GameCanvas.panel, 10020, null));
			return;
		}
		GameCanvas.instance.M457(GameCanvas.loginScr);
		Session_ME.M1744().close();
	}
}
