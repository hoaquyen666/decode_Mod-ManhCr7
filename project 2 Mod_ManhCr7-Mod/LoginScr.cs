using System;
using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using Utilities;
using Xmap;

public class LoginScr : mScreen, IActionListener
{
	public TField tfUser;

	public TField tfPass;

	public static bool isContinueToLogin = false;

	private int focus;

	private int wC;

	private int yL;

	private int defYL;

	public bool isCheck;

	public bool isRes;

	public Command cmdLogin;

	public Command cmdCheck;

	public Command cmdFogetPass;

	public Command cmdRes;

	public Command cmdMenu;

	public Command cmdBackFromRegister;

	public string listFAQ = string.Empty;

	public string titleFAQ;

	public string subtitleFAQ;

	private string numSupport = string.Empty;

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

	public static GameMidlet m;

	private int yy = GameCanvas.hh - mScreen.ITEM_HEIGHT - 5;

	private int freeAreaHeight;

	private int xP;

	private int yP;

	private int wP;

	private int hP;

	private int t = 20;

	private bool isRegistering;

	private string passRe = string.Empty;

	public bool isFAQ;

	private int tipid = -1;

	public bool isLogin2;

	private int v = 2;

	private int g;

	private int ylogo = -40;

	private int dir = 1;

	private Command cmdCallHotline;

	public static bool isLoggingIn;

	public LoginScr()
	{
		yLog = GameCanvas.hh - 30;
		TileMap.bgID = (sbyte)(mSystem.M1054() % 9L);
		if (TileMap.bgID == 5 || TileMap.bgID == 6)
		{
			TileMap.bgID = 4;
		}
		GameScr.M564(fullmScreen: true, -1, -1);
		GameScr.cmx = 100;
		GameScr.cmy = 200;
		Main.closeKeyBoard();
		if (GameCanvas.h > 200)
		{
			defYL = GameCanvas.hh - 80;
		}
		else
		{
			defYL = GameCanvas.hh - 65;
		}
		M865();
		wC = ((GameCanvas.w < 200) ? 140 : 160);
		yt = GameCanvas.hh - mScreen.ITEM_HEIGHT - 5;
		if (GameCanvas.h <= 160)
		{
			yt = 20;
		}
		tfUser = new TField();
		tfUser.y = GameCanvas.hh - mScreen.ITEM_HEIGHT - 9;
		tfUser.width = wC;
		tfUser.height = mScreen.ITEM_HEIGHT + 2;
		tfUser.isFocus = true;
		tfUser.M1931(TField.INPUT_TYPE_ANY);
		tfUser.name = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
		tfPass = new TField();
		tfPass.y = GameCanvas.hh - 4;
		tfPass.M1931(TField.INPUT_TYPE_PASSWORD);
		tfPass.width = wC;
		tfPass.height = mScreen.ITEM_HEIGHT + 2;
		yt += 35;
		isCheck = true;
		switch (Rms.M1542("check"))
		{
		case 2:
			isCheck = false;
			break;
		case 1:
			isCheck = true;
			break;
		}
		tfUser.M1926(Rms.M1536("acc"));
		tfPass.M1926(Rms.M1536("pass"));
		if (cmdCallHotline == null)
		{
			cmdCallHotline = new Command("Gọi hotline", this, 13, null);
			cmdCallHotline.x = GameCanvas.w - 75;
			if (mSystem.clientType == 1 && !GameCanvas.isTouch)
			{
				cmdCallHotline.y = GameCanvas.h - 20;
			}
			else
			{
				cmdCallHotline.y = 8;
			}
		}
		focus = 0;
		cmdLogin = new Command((GameCanvas.w <= 200) ? mResources.login2 : mResources.login, GameCanvas.instance, 888393, null);
		cmdCheck = new Command(mResources.remember, this, 2001, null);
		cmdRes = new Command(mResources.register, this, 2002, null);
		cmdBackFromRegister = new Command(mResources.CANCEL, this, 10021, null);
		left = (cmdMenu = new Command(mResources.MENU, this, 2003, null));
		freeAreaHeight = tfUser.y - 2 * tfUser.height;
		if (GameCanvas.isTouch)
		{
			cmdLogin.x = GameCanvas.w / 2 + 8;
			cmdMenu.x = GameCanvas.w / 2 - mScreen.cmdW - 8;
			if (GameCanvas.h >= 200)
			{
				cmdLogin.y = yLog + 110;
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
		yLog = GameCanvas.hh - 30;
		lY = ((GameCanvas.w < 200) ? (tfUser.y - 30) : (yLog - 30));
		tfUser.x = xLog + 10;
		tfUser.y = yLog + 20;
		cmdOK = new Command(mResources.OK, this, 2008, null);
		cmdOK.x = GameCanvas.w / 2 - 84;
		cmdOK.y = cmdLogin.y;
		cmdFogetPass = new Command(mResources.forgetPass, this, 1003, null);
		cmdFogetPass.x = GameCanvas.w / 2 + 3;
		cmdFogetPass.y = cmdLogin.y;
		center = cmdOK;
		left = cmdFogetPass;
	}

	public static void M851()
	{
		try
		{
			if (isTryGetIPFromWap)
			{
				return;
			}
			Command t = new Command();
			t.actionChat = delegate(string str)
			{
				try
				{
					if (str != null && !(str == string.Empty))
					{
						Rms.M1553(str);
						if (str.Contains(":"))
						{
							int num = str.IndexOf(":");
							string text = str.Substring(0, num);
							string s = str.Substring(num + 1);
							GameMidlet.IP = text;
							GameMidlet.PORT = int.Parse(s);
							Session_ME.M1744().connect(text, int.Parse(s));
							isTryGetIPFromWap = true;
						}
					}
				}
				catch (Exception)
				{
				}
			};
			Net.M1153(ServerListScreen.linkGetHost, t);
		}
		catch (Exception)
		{
		}
	}

	public override void switchToMe()
	{
		isRegistering = false;
		SoundMn.M1826().M1873();
		tfUser.isFocus = true;
		tfPass.isFocus = false;
		if (GameCanvas.isTouch)
		{
			tfUser.isFocus = false;
		}
		GameCanvas.M469(0);
		base.switchToMe();
	}

	public void M852()
	{
		string text = Rms.M1536("acc");
		if (text != null && !text.Equals(string.Empty))
		{
			tfUser.M1926(text);
		}
		string text2 = Rms.M1536("pass");
		if (text2 != null && !text2.Equals(string.Empty))
		{
			tfPass.M1926(text2);
		}
	}

	public void M853()
	{
	}

	protected void M854()
	{
		MyVector t = new MyVector();
		t.M1111(new Command(mResources.registerNewAcc, this, 2004, null));
		if (!isLogin2)
		{
			t.M1111(new Command(mResources.selectServer, this, 1004, null));
		}
		t.M1111(new Command(mResources.forgetPass, this, 1003, null));
		t.M1111(new Command(mResources.website, this, 1005, null));
		if (Main.isPC)
		{
			t.M1111(new Command(mResources.EXIT, GameCanvas.instance, 8885, null));
		}
		GameCanvas.menu.M877(t, 0);
	}

	protected void M855()
	{
		if (tfUser.M1924().Equals(string.Empty))
		{
			GameCanvas.M489(mResources.userBlank);
			return;
		}
		tfUser.M1924().ToCharArray();
		if (tfPass.M1924().Equals(string.Empty))
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
			GameCanvas.msgdlg.M1037(mResources.plsCheckAcc + ((num != 1) ? (mResources.email + ": ") : (mResources.phone + ": ")) + tfUser.M1924() + "\n" + mResources.password + ": " + tfPass.M1924(), new Command(mResources.ACCEPT, this, 4000, null), null, new Command(mResources.NO, GameCanvas.instance, 8882, null));
		}
		GameCanvas.currentDialog = GameCanvas.msgdlg;
	}

	protected void M856(string user)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		isFAQ = false;
		GameCanvas.M490(mResources.CONNECTING);
		GameCanvas.M449();
		GameCanvas.M490(mResources.REGISTERING);
		passRe = tfPass.M1924();
		Service.M1594().M1635(user, tfPass.M1924(), Rms.M1536("userAo" + ServerListScreen.ipSelect), Rms.M1536("passAo" + ServerListScreen.ipSelect), GameMidlet.VERSION);
		Rms.M1538("acc", user);
		Rms.M1538("pass", tfPass.M1924());
		t = 20;
		isRegistering = true;
	}

	public void M857()
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

	protected void M858()
	{
		MyVector t = new MyVector();
		if (isLocal)
		{
			t.M1111(new Command("Server LOCAL", this, 20004, null));
		}
		t.M1111(new Command("Server Bokken", this, 20001, null));
		t.M1111(new Command("Server Shuriken", this, 20002, null));
		t.M1111(new Command("Server Tessen (mới)", this, 20003, null));
		GameCanvas.menu.M877(t, 0);
		if (M860() != -1 && !GameCanvas.isTouch)
		{
			GameCanvas.menu.menuSelectedItem = M860();
		}
	}

	protected void M859(int index)
	{
		Rms.M1543("indServer", index);
	}

	protected int M860()
	{
		return Rms.M1542("indServer");
	}

	public void M861()
	{
		string text = Rms.M1536("acc");
		string text2 = Rms.M1536("pass");
		if (text != null && !text.Equals(string.Empty))
		{
			isLogin2 = false;
		}
		else if (Rms.M1536("userAo" + ServerListScreen.ipSelect) != null && !Rms.M1536("userAo" + ServerListScreen.ipSelect).Equals(string.Empty))
		{
			isLogin2 = true;
		}
		else
		{
			isLogin2 = false;
		}
		if ((text == null || text.Equals(string.Empty)) && isLogin2)
		{
			text = Rms.M1536("userAo" + ServerListScreen.ipSelect);
			text2 = "a";
		}
		if (text == null || text2 == null || GameMidlet.VERSION == null || text.Equals(string.Empty))
		{
			return;
		}
		if (text2.Equals(string.Empty))
		{
			focus = 1;
			tfUser.isFocus = false;
			tfPass.isFocus = true;
			if (!GameCanvas.isTouch)
			{
				right = tfPass.cmdClear;
			}
			return;
		}
		GameCanvas.M449();
		Res.M1513("ccccccc " + text + " " + text2 + " " + GameMidlet.VERSION + " " + (sbyte)(isLogin2 ? 1 : 0));
		Service.M1594().M1634(text, text2, GameMidlet.VERSION, (sbyte)(isLogin2 ? 1 : 0));
		if (Session_ME.connected)
		{
			GameCanvas.M492();
		}
		else
		{
			GameCanvas.M489(mResources.maychutathoacmatsong);
		}
		focus = 0;
		if (!isLogin2)
		{
			M866();
		}
	}

	public void M862()
	{
		if (isCheck)
		{
			Rms.M1543("check", 1);
			Rms.M1538("acc", tfUser.M1924().ToLower().Trim());
			Rms.M1538("pass", tfPass.M1924().ToLower().Trim());
		}
		else
		{
			Rms.M1543("check", 2);
			Rms.M1538("acc", string.Empty);
			Rms.M1538("pass", string.Empty);
		}
	}

	public override void update()
	{
		if (Main.isWindowsPhone && isRegistering)
		{
			if (t < 0)
			{
				GameCanvas.M488();
				Session_ME.M1744().close();
				GameCanvas.serverScreen.switchToMe();
				isRegistering = false;
			}
			else
			{
				t--;
			}
		}
		if (timeLogin > 0)
		{
			GameCanvas.M492();
			currTimeLogin = mSystem.M1054();
			if (currTimeLogin - lastTimeLogin >= 1000L)
			{
				timeLogin--;
				if (timeLogin == 0)
				{
					Session_ME.M1744().close();
					GameCanvas.loginScr.M861();
				}
				lastTimeLogin = currTimeLogin;
			}
		}
		if (isLogin2 && !isRes)
		{
			tfUser.name = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
			tfPass.name = mResources.password;
			tfUser.isPaintCarret = false;
			tfPass.isPaintCarret = false;
			tfUser.M1920();
			tfPass.M1920();
		}
		else
		{
			tfUser.name = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
			tfPass.name = mResources.password;
			tfUser.M1920();
			tfPass.M1920();
		}
		if (TouchScreenKeyboard.visible)
		{
			mGraphics.addYWhenOpenKeyBoard = 50;
		}
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
		M864();
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
			M863();
		}
		if (isLogin2 && !isRes)
		{
			tfUser.isPaintCarret = false;
			tfPass.isPaintCarret = false;
			tfUser.M1920();
			tfPass.M1920();
		}
		else
		{
			tfUser.name = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
			tfPass.name = mResources.password;
			tfUser.M1920();
			tfPass.M1920();
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
		if (!Main.isPC && !TouchScreenKeyboard.visible && !Main.isMiniApp && !Main.isWindowsPhone)
		{
			string text = tfUser.M1924().ToLower().Trim();
			string text2 = tfPass.M1924().ToLower().Trim();
			if (!text.Equals(string.Empty) && !text2.Equals(string.Empty))
			{
				M861();
			}
			Main.isMiniApp = true;
		}
		M853();
	}

	private void M863()
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

	public void M864()
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
		else if (tfPass.isFocus)
		{
			tfPass.M1913(keyCode);
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
		mFont.tahoma_7_white.M902(g, "v" + GameMidlet.VERSION, GameCanvas.w - 2, 17, 1, mFont.tahoma_7_grey);
		if (mSystem.clientType == 1 && !GameCanvas.isTouch)
		{
			mFont.tahoma_7_white.M902(g, ServerListScreen.linkweb, GameCanvas.w - 2, GameCanvas.h - 15, 1, mFont.tahoma_7_grey);
		}
		else
		{
			mFont.tahoma_7_white.M902(g, ServerListScreen.linkweb, GameCanvas.w - 2, 2, 1, mFont.tahoma_7_grey);
		}
		if (ChatPopup.currChatPopup != null || ChatPopup.serverChatPopUp != null)
		{
			return;
		}
		if (GameCanvas.currentDialog == null)
		{
			int w = ((GameCanvas.w < 200) ? 160 : 180);
			PopUp.M1481(g, xLog, yLog - 10, w, 105, -1, isButton: true);
			if (GameCanvas.h > 160 && GameAutomationHub.logoServerListScreen != null)
			{
				g.M948(GameAutomationHub.logoServerListScreen, GameCanvas.hw, num, 3);
			}
			GameCanvas.M456("PLG4", 1);
			int num2 = 4;
			int num3 = 184;
			if (184 >= GameCanvas.w)
			{
				num3 = (num2 - 1) * 32 + 23 + 33;
			}
			xLog = GameCanvas.w / 2 - num3 / 2;
			tfUser.x = xLog + 10;
			tfUser.y = yLog + 20;
			tfPass.x = xLog + 10;
			tfPass.y = yLog + 55;
			tfUser.M1916(g);
			tfPass.M1916(g);
			if (GameCanvas.w < 176)
			{
				mFont.tahoma_7b_green2.M898(g, mResources.acc + ":", tfUser.x - 35, tfUser.y + 7, 0);
				mFont.tahoma_7b_green2.M898(g, mResources.pwd + ":", tfPass.x - 35, tfPass.y + 7, 0);
				mFont.tahoma_7b_green2.M898(g, mResources.server + ":" + serverName, GameCanvas.w / 2, tfPass.y + 32, 2);
			}
		}
		base.paint(g);
	}

	public override void updateKey()
	{
		if (GameCanvas.isTouch)
		{
			if (cmdCallHotline != null && cmdCallHotline.M298())
			{
				cmdCallHotline.M294();
			}
		}
		else if (mSystem.clientType == 1 && GameCanvas.keyPressed[13])
		{
			GameCanvas.keyPressed[13] = false;
			cmdCallHotline.M294();
		}
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
			else
			{
				right = tfPass.cmdClear;
			}
		}
		if (GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21])
		{
			focus--;
			if (focus < 0)
			{
				focus = 1;
			}
		}
		else if (GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22] || GameCanvas.keyPressed[16])
		{
			focus++;
			if (focus > 1)
			{
				focus = 0;
			}
		}
		if (GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21] || GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22] || GameCanvas.keyPressed[16])
		{
			GameCanvas.M483();
			if (!isLogin2 || isRes)
			{
				if (focus == 1)
				{
					tfUser.isFocus = false;
					tfPass.isFocus = true;
				}
				else if (focus == 0)
				{
					tfUser.isFocus = true;
					tfPass.isFocus = false;
				}
				else
				{
					tfUser.isFocus = false;
					tfPass.isFocus = false;
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
		if (GameCanvas.isPointerJustRelease && (!isLogin2 || isRes))
		{
			if (GameCanvas.M481(tfUser.x, tfUser.y, tfUser.width, tfUser.height))
			{
				focus = 0;
			}
			else if (GameCanvas.M481(tfPass.x, tfPass.y, tfPass.width, tfPass.height))
			{
				focus = 1;
			}
		}
		if (Main.isPC && GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] && right != null)
		{
			right.M294();
		}
		base.updateKey();
		GameCanvas.M483();
	}

	public void M865()
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
			M855();
			break;
		case 2003:
			M854();
			break;
		case 2004:
			M867();
			break;
		case 2008:
			Rms.M1538("acc", tfUser.M1924().Trim());
			Rms.M1538("pass", tfPass.M1924().Trim());
			if (ServerListScreen.loadScreen)
			{
				GameCanvas.serverScreen.switchToMe();
			}
			else
			{
				GameCanvas.serverScreen.M1592();
			}
			break;
		case 1000:
			try
			{
				GameMidlet.instance.M524((string)p);
			}
			catch (Exception)
			{
			}
			GameCanvas.M488();
			break;
		case 1001:
			GameCanvas.M488();
			isRes = false;
			break;
		case 1002:
		{
			GameCanvas.M492();
			string text = Rms.M1536("userAo" + ServerListScreen.ipSelect);
			if (text != null && !text.Equals(string.Empty))
			{
				GameCanvas.loginScr.isLogin2 = true;
				GameCanvas.M449();
				Service.M1594().M1630();
				Service.M1594().M1634(text, string.Empty, GameMidlet.VERSION, 1);
			}
			else
			{
				Service.M1594().M1717(string.Empty);
			}
			break;
		}
		case 1003:
			GameCanvas.M489(mResources.goToWebForPassword);
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
			catch (Exception)
			{
				break;
			}
		case 13:
			switch (mSystem.clientType)
			{
			case 1:
				mSystem.M1044();
				break;
			case 4:
				mSystem.M1043();
				break;
			case 3:
			case 5:
				mSystem.M1045();
				break;
			case 6:
				mSystem.M1046();
				break;
			case 2:
				break;
			}
			break;
		case 10021:
			M866();
			break;
		case 4000:
			M856(tfUser.M1924());
			break;
		case 10042:
			Rms.M1543("lowGraphic", 1);
			GameCanvas.M494(mResources.plsRestartGame, 8885, null);
			break;
		case 10041:
			Rms.M1543("lowGraphic", 0);
			GameCanvas.M494(mResources.plsRestartGame, 8885, null);
			break;
		}
	}

	public void M866()
	{
		if (isLogin2)
		{
			M861();
			return;
		}
		isRes = false;
		tfPass.isFocus = false;
		tfUser.isFocus = true;
		left = cmdMenu;
	}

	public void M867()
	{
		GameCanvas.M488();
		isRes = true;
		tfPass.isFocus = false;
		tfUser.isFocus = true;
	}

	public void M868()
	{
		if (GameCanvas.loginScr.isLogin2)
		{
			GameCanvas.M496(mResources.note, new Command(mResources.YES, GameCanvas.panel, 10019, null), new Command(mResources.NO, GameCanvas.panel, 10020, null));
			return;
		}
		if (Main.isWindowsPhone)
		{
			GameMidlet.isBackWindowsPhone = true;
		}
		GameCanvas.instance.resetToLoginScr = false;
		GameCanvas.instance.M457(GameCanvas.loginScr);
		Session_ME.M1744().close();
	}
}
