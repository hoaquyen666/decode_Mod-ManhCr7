using System;
using N3.N4;

public class T90 : T108, T57
{
	public T173 tfUser;

	public T173 tfPass;

	public static bool isContinueToLogin = false;

	private int focus;

	private int wC;

	private int yL;

	private int defYL;

	public bool isCheck;

	public bool isRes;

	public T22 cmdLogin;

	public T22 cmdCheck;

	public T22 cmdFogetPass;

	public T22 cmdRes;

	public T22 cmdMenu;

	public T22 cmdBackFromRegister;

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

	public static T60 imgTitle;

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

	private T22 cmdSelect;

	private T22 cmdOK;

	private int xLog;

	private int yLog;

	public static T52 m;

	private int yy = T51.hh - T108.ITEM_HEIGHT - 5;

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

	private T22 cmdCallHotline;

	public static bool isLoggingIn;

	public T90()
	{
		yLog = T51.hh - 30;
		T174.bgID = (sbyte)(T110.M1054() % 9L);
		if (T174.bgID == 5 || T174.bgID == 6)
		{
			T174.bgID = 4;
		}
		T54.M564(fullmScreen: true, -1, -1);
		T54.cmx = 100;
		T54.cmy = 200;
		Main.closeKeyBoard();
		if (T51.h > 200)
		{
			defYL = T51.hh - 80;
		}
		else
		{
			defYL = T51.hh - 65;
		}
		M865();
		wC = ((T51.w < 200) ? 140 : 160);
		yt = T51.hh - T108.ITEM_HEIGHT - 5;
		if (T51.h <= 160)
		{
			yt = 20;
		}
		tfUser = new T173();
		tfUser.y = T51.hh - T108.ITEM_HEIGHT - 9;
		tfUser.width = wC;
		tfUser.height = T108.ITEM_HEIGHT + 2;
		tfUser.isFocus = true;
		tfUser.M1931(T173.INPUT_TYPE_ANY);
		tfUser.name = ((mResources.language != 2) ? (mResources.phone + "/") : string.Empty) + mResources.email;
		tfPass = new T173();
		tfPass.y = T51.hh - 4;
		tfPass.M1931(T173.INPUT_TYPE_PASSWORD);
		tfPass.width = wC;
		tfPass.height = T108.ITEM_HEIGHT + 2;
		yt += 35;
		isCheck = true;
		switch (T138.M1542("check"))
		{
		case 2:
			isCheck = false;
			break;
		case 1:
			isCheck = true;
			break;
		}
		tfUser.M1926(T138.M1536("acc"));
		tfPass.M1926(T138.M1536("pass"));
		if (cmdCallHotline == null)
		{
			cmdCallHotline = new T22("Gọi hotline", this, 13, null);
			cmdCallHotline.x = T51.w - 75;
			if (T110.clientType == 1 && !T51.isTouch)
			{
				cmdCallHotline.y = T51.h - 20;
			}
			else
			{
				cmdCallHotline.y = 8;
			}
		}
		focus = 0;
		cmdLogin = new T22((T51.w <= 200) ? mResources.login2 : mResources.login, T51.instance, 888393, null);
		cmdCheck = new T22(mResources.remember, this, 2001, null);
		cmdRes = new T22(mResources.register, this, 2002, null);
		cmdBackFromRegister = new T22(mResources.CANCEL, this, 10021, null);
		left = (cmdMenu = new T22(mResources.MENU, this, 2003, null));
		freeAreaHeight = tfUser.y - 2 * tfUser.height;
		if (T51.isTouch)
		{
			cmdLogin.x = T51.w / 2 + 8;
			cmdMenu.x = T51.w / 2 - T108.cmdW - 8;
			if (T51.h >= 200)
			{
				cmdLogin.y = yLog + 110;
				cmdMenu.y = yLog + 110;
			}
			cmdBackFromRegister.x = T51.w / 2 + 3;
			cmdBackFromRegister.y = yLog + 110;
			cmdRes.x = T51.w / 2 - 84;
			cmdRes.y = cmdMenu.y;
		}
		wP = 170;
		hP = ((!isRes) ? 100 : 110);
		xP = T51.hw - wP / 2;
		yP = tfUser.y - 15;
		int num = 4;
		int num2 = 184;
		if (184 >= T51.w)
		{
			num2 = (num - 1) * 32 + 23 + 33;
		}
		xLog = T51.w / 2 - num2 / 2;
		yLog = T51.hh - 30;
		lY = ((T51.w < 200) ? (tfUser.y - 30) : (yLog - 30));
		tfUser.x = xLog + 10;
		tfUser.y = yLog + 20;
		cmdOK = new T22(mResources.OK, this, 2008, null);
		cmdOK.x = T51.w / 2 - 84;
		cmdOK.y = cmdLogin.y;
		cmdFogetPass = new T22(mResources.forgetPass, this, 1003, null);
		cmdFogetPass.x = T51.w / 2 + 3;
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
			T22 t = new T22();
			t.actionChat = delegate(string str)
			{
				try
				{
					if (str != null && !(str == string.Empty))
					{
						T138.M1553(str);
						if (str.Contains(":"))
						{
							int num = str.IndexOf(":");
							string text = str.Substring(0, num);
							string s = str.Substring(num + 1);
							T52.IP = text;
							T52.PORT = int.Parse(s);
							T147.M1744().connect(text, int.Parse(s));
							isTryGetIPFromWap = true;
						}
					}
				}
				catch (Exception)
				{
				}
			};
			T120.M1153(T144.linkGetHost, t);
		}
		catch (Exception)
		{
		}
	}

	public override void switchToMe()
	{
		isRegistering = false;
		T160.M1826().M1873();
		tfUser.isFocus = true;
		tfPass.isFocus = false;
		if (T51.isTouch)
		{
			tfUser.isFocus = false;
		}
		T51.M469(0);
		base.switchToMe();
	}

	public void M852()
	{
		string text = T138.M1536("acc");
		if (text != null && !text.Equals(string.Empty))
		{
			tfUser.M1926(text);
		}
		string text2 = T138.M1536("pass");
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
		T117 t = new T117();
		t.M1111(new T22(mResources.registerNewAcc, this, 2004, null));
		if (!isLogin2)
		{
			t.M1111(new T22(mResources.selectServer, this, 1004, null));
		}
		t.M1111(new T22(mResources.forgetPass, this, 1003, null));
		t.M1111(new T22(mResources.website, this, 1005, null));
		if (Main.isPC)
		{
			t.M1111(new T22(mResources.EXIT, T51.instance, 8885, null));
		}
		T51.menu.M877(t, 0);
	}

	protected void M855()
	{
		if (tfUser.M1924().Equals(string.Empty))
		{
			T51.M489(mResources.userBlank);
			return;
		}
		tfUser.M1924().ToCharArray();
		if (tfPass.M1924().Equals(string.Empty))
		{
			T51.M489(mResources.passwordBlank);
			return;
		}
		if (tfUser.M1924().Length < 5)
		{
			T51.M489(mResources.accTooShort);
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
			T51.M489(text);
		}
		else
		{
			T51.msgdlg.M1037(mResources.plsCheckAcc + ((num != 1) ? (mResources.email + ": ") : (mResources.phone + ": ")) + tfUser.M1924() + "\n" + mResources.password + ": " + tfPass.M1924(), new T22(mResources.ACCEPT, this, 4000, null), null, new T22(mResources.NO, T51.instance, 8882, null));
		}
		T51.currentDialog = T51.msgdlg;
	}

	protected void M856(string user)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		isFAQ = false;
		T51.M490(mResources.CONNECTING);
		T51.M449();
		T51.M490(mResources.REGISTERING);
		passRe = tfPass.M1924();
		T146.M1594().M1635(user, tfPass.M1924(), T138.M1536("userAo" + T144.ipSelect), T138.M1536("passAo" + T144.ipSelect), T52.VERSION);
		T138.M1538("acc", user);
		T138.M1538("pass", tfPass.M1924());
		t = 20;
		isRegistering = true;
	}

	public void M857()
	{
		if (listFAQ.Equals(string.Empty))
		{
			listFAQ.Equals(string.Empty);
		}
		if (!T147.connected)
		{
			isFAQ = true;
			T51.M449();
		}
		T51.M492();
	}

	protected void M858()
	{
		T117 t = new T117();
		if (isLocal)
		{
			t.M1111(new T22("Server LOCAL", this, 20004, null));
		}
		t.M1111(new T22("Server Bokken", this, 20001, null));
		t.M1111(new T22("Server Shuriken", this, 20002, null));
		t.M1111(new T22("Server Tessen (mới)", this, 20003, null));
		T51.menu.M877(t, 0);
		if (M860() != -1 && !T51.isTouch)
		{
			T51.menu.menuSelectedItem = M860();
		}
	}

	protected void M859(int index)
	{
		T138.M1543("indServer", index);
	}

	protected int M860()
	{
		return T138.M1542("indServer");
	}

	public void M861()
	{
		string text = T138.M1536("acc");
		string text2 = T138.M1536("pass");
		if (text != null && !text.Equals(string.Empty))
		{
			isLogin2 = false;
		}
		else if (T138.M1536("userAo" + T144.ipSelect) != null && !T138.M1536("userAo" + T144.ipSelect).Equals(string.Empty))
		{
			isLogin2 = true;
		}
		else
		{
			isLogin2 = false;
		}
		if ((text == null || text.Equals(string.Empty)) && isLogin2)
		{
			text = T138.M1536("userAo" + T144.ipSelect);
			text2 = "a";
		}
		if (text == null || text2 == null || T52.VERSION == null || text.Equals(string.Empty))
		{
			return;
		}
		if (text2.Equals(string.Empty))
		{
			focus = 1;
			tfUser.isFocus = false;
			tfPass.isFocus = true;
			if (!T51.isTouch)
			{
				right = tfPass.cmdClear;
			}
			return;
		}
		T51.M449();
		T137.M1513("ccccccc " + text + " " + text2 + " " + T52.VERSION + " " + (sbyte)(isLogin2 ? 1 : 0));
		T146.M1594().M1634(text, text2, T52.VERSION, (sbyte)(isLogin2 ? 1 : 0));
		if (T147.connected)
		{
			T51.M492();
		}
		else
		{
			T51.M489(mResources.maychutathoacmatsong);
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
			T138.M1543("check", 1);
			T138.M1538("acc", tfUser.M1924().ToLower().Trim());
			T138.M1538("pass", tfPass.M1924().ToLower().Trim());
		}
		else
		{
			T138.M1543("check", 2);
			T138.M1538("acc", string.Empty);
			T138.M1538("pass", string.Empty);
		}
	}

	public override void update()
	{
		if (Main.isWindowsPhone && isRegistering)
		{
			if (t < 0)
			{
				T51.M488();
				T147.M1744().close();
				T51.serverScreen.switchToMe();
				isRegistering = false;
			}
			else
			{
				t--;
			}
		}
		if (timeLogin > 0)
		{
			T51.M492();
			currTimeLogin = T110.M1054();
			if (currTimeLogin - lastTimeLogin >= 1000L)
			{
				timeLogin--;
				if (timeLogin == 0)
				{
					T147.M1744().close();
					T51.loginScr.M861();
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
		if (T177.visible)
		{
			T99.addYWhenOpenKeyBoard = 50;
		}
		for (int i = 0; i < T33.vEffect2.M1113(); i++)
		{
			((T33)T33.vEffect2.M1114(i)).update();
		}
		if (isUpdateAll && !isUpdateData && !isUpdateItem && !isUpdateMap && !isUpdateSkill)
		{
			isUpdateAll = false;
			T110.M1062();
			T146.M1594().M1711();
		}
		T54.cmx++;
		if (T54.cmx > T51.w * 3 + 100)
		{
			T54.cmx = 100;
		}
		if (T14.currChatPopup != null)
		{
			return;
		}
		T51.M456("LGU1", 0);
		T51.M456("LGU2", 0);
		T51.M456("LGU3", 0);
		M864();
		T51.M456("LGU4", 0);
		T51.M456("LGU5", 0);
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
		T51.M456("LGU6", 0);
		if (tipid >= 0 && T51.gameTick % 100 == 0)
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
		if (T51.isTouch)
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
		if (!Main.isPC && !T177.visible && !Main.isMiniApp && !Main.isWindowsPhone)
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
		if (T51.currentDialog == T51.msgdlg && T51.msgdlg.isWait)
		{
			T51.msgdlg.M1036(mResources.tips[tipid]);
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

	public override void paint(T99 g)
	{
		T51.M456("PLG1", 1);
		T51.M466(g);
		T51.M456("PLG2", 2);
		int num = tfUser.y - 50;
		if (T51.h <= 220)
		{
			num += 5;
		}
		T98.tahoma_7_white.M902(g, "v" + T52.VERSION, T51.w - 2, 17, 1, T98.tahoma_7_grey);
		if (T110.clientType == 1 && !T51.isTouch)
		{
			T98.tahoma_7_white.M902(g, T144.linkweb, T51.w - 2, T51.h - 15, 1, T98.tahoma_7_grey);
		}
		else
		{
			T98.tahoma_7_white.M902(g, T144.linkweb, T51.w - 2, 2, 1, T98.tahoma_7_grey);
		}
		if (T14.currChatPopup != null || T14.serverChatPopUp != null)
		{
			return;
		}
		if (T51.currentDialog == null)
		{
			int w = ((T51.w < 200) ? 160 : 180);
			T133.M1481(g, xLog, yLog - 10, w, 105, -1, isButton: true);
			if (T51.h > 160 && T200.logoServerListScreen != null)
			{
				g.M948(T200.logoServerListScreen, T51.hw, num, 3);
			}
			T51.M456("PLG4", 1);
			int num2 = 4;
			int num3 = 184;
			if (184 >= T51.w)
			{
				num3 = (num2 - 1) * 32 + 23 + 33;
			}
			xLog = T51.w / 2 - num3 / 2;
			tfUser.x = xLog + 10;
			tfUser.y = yLog + 20;
			tfPass.x = xLog + 10;
			tfPass.y = yLog + 55;
			tfUser.M1916(g);
			tfPass.M1916(g);
			if (T51.w < 176)
			{
				T98.tahoma_7b_green2.M898(g, mResources.acc + ":", tfUser.x - 35, tfUser.y + 7, 0);
				T98.tahoma_7b_green2.M898(g, mResources.pwd + ":", tfPass.x - 35, tfPass.y + 7, 0);
				T98.tahoma_7b_green2.M898(g, mResources.server + ":" + serverName, T51.w / 2, tfPass.y + 32, 2);
			}
		}
		base.paint(g);
	}

	public override void updateKey()
	{
		if (T51.isTouch)
		{
			if (cmdCallHotline != null && cmdCallHotline.M298())
			{
				cmdCallHotline.M294();
			}
		}
		else if (T110.clientType == 1 && T51.keyPressed[13])
		{
			T51.keyPressed[13] = false;
			cmdCallHotline.M294();
		}
		if (isContinueToLogin)
		{
			return;
		}
		if (!T51.isTouch)
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
		if (T51.keyPressed[(!Main.isPC) ? 2 : 21])
		{
			focus--;
			if (focus < 0)
			{
				focus = 1;
			}
		}
		else if (T51.keyPressed[(!Main.isPC) ? 8 : 22] || T51.keyPressed[16])
		{
			focus++;
			if (focus > 1)
			{
				focus = 0;
			}
		}
		if (T51.keyPressed[(!Main.isPC) ? 2 : 21] || T51.keyPressed[(!Main.isPC) ? 8 : 22] || T51.keyPressed[16])
		{
			T51.M483();
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
		if (T51.isTouch)
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
		if (T51.isPointerJustRelease && (!isLogin2 || isRes))
		{
			if (T51.M481(tfUser.x, tfUser.y, tfUser.width, tfUser.height))
			{
				focus = 0;
			}
			else if (T51.M481(tfPass.x, tfPass.y, tfPass.width, tfPass.height))
			{
				focus = 1;
			}
		}
		if (Main.isPC && T51.keyPressed[(!Main.isPC) ? 5 : 25] && right != null)
		{
			right.M294();
		}
		base.updateKey();
		T51.M483();
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
			T138.M1538("acc", tfUser.M1924().Trim());
			T138.M1538("pass", tfPass.M1924().Trim());
			if (T144.loadScreen)
			{
				T51.serverScreen.switchToMe();
			}
			else
			{
				T51.serverScreen.M1592();
			}
			break;
		case 1000:
			try
			{
				T52.instance.M524((string)p);
			}
			catch (Exception)
			{
			}
			T51.M488();
			break;
		case 1001:
			T51.M488();
			isRes = false;
			break;
		case 1002:
		{
			T51.M492();
			string text = T138.M1536("userAo" + T144.ipSelect);
			if (text != null && !text.Equals(string.Empty))
			{
				T51.loginScr.isLogin2 = true;
				T51.M449();
				T146.M1594().M1630();
				T146.M1594().M1634(text, string.Empty, T52.VERSION, 1);
			}
			else
			{
				T146.M1594().M1717(string.Empty);
			}
			break;
		}
		case 1003:
			T51.M489(mResources.goToWebForPassword);
			break;
		case 1004:
			T144.M1580();
			T51.serverScreen.switchToMe();
			break;
		case 1005:
			try
			{
				T52.instance.M524("http://ngocrongonline.com");
				break;
			}
			catch (Exception)
			{
				break;
			}
		case 13:
			switch (T110.clientType)
			{
			case 1:
				T110.M1044();
				break;
			case 4:
				T110.M1043();
				break;
			case 3:
			case 5:
				T110.M1045();
				break;
			case 6:
				T110.M1046();
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
			T138.M1543("lowGraphic", 1);
			T51.M494(mResources.plsRestartGame, 8885, null);
			break;
		case 10041:
			T138.M1543("lowGraphic", 0);
			T51.M494(mResources.plsRestartGame, 8885, null);
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
		T51.M488();
		isRes = true;
		tfPass.isFocus = false;
		tfUser.isFocus = true;
	}

	public void M868()
	{
		if (T51.loginScr.isLogin2)
		{
			T51.M496(mResources.note, new T22(mResources.YES, T51.panel, 10019, null), new T22(mResources.NO, T51.panel, 10020, null));
			return;
		}
		if (Main.isWindowsPhone)
		{
			T52.isBackWindowsPhone = true;
		}
		T51.instance.resetToLoginScr = false;
		T51.instance.M457(T51.loginScr);
		T147.M1744().close();
	}
}
