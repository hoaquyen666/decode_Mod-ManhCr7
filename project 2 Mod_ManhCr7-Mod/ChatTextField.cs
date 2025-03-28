public class ChatTextField : IActionListener
{
	private static ChatTextField instance;

	public TField tfChat;

	public bool isShow;

	public IChatable parentScreen;

	private long lastChatTime;

	public Command left;

	public Command cmdChat;

	public Command right;

	public Command center;

	private int x;

	private int y;

	private int w;

	private int h;

	private bool isPublic;

	public Command cmdChat2;

	public int yBegin;

	public int yUp;

	public int KC;

	public string to;

	public string strChat = "Chat ";

	public ChatTextField()
	{
		tfChat = new TField();
		if (Main.isWindowsPhone)
		{
			tfChat.showSubTextField = false;
		}
		if (Main.isIPhone)
		{
			tfChat.isPaintMouse = false;
		}
		tfChat.name = "chat";
		if (Main.isWindowsPhone)
		{
			tfChat.strInfo = tfChat.name;
		}
		tfChat.width = GameCanvas.w - 6;
		if (Main.isPC && tfChat.width > 250)
		{
			tfChat.width = 250;
		}
		tfChat.height = mScreen.ITEM_HEIGHT + 2;
		tfChat.x = GameCanvas.w / 2 - tfChat.width / 2;
		tfChat.isFocus = true;
		tfChat.M1929(80);
	}

	public void M276()
	{
		left = new Command(mResources.OK, this, 8000, null, 1, GameCanvas.h - mScreen.cmdH + 1);
		right = new Command(mResources.DELETE, this, 8001, null, GameCanvas.w - 70, GameCanvas.h - mScreen.cmdH + 1);
		center = null;
		w = tfChat.width + 20;
		h = tfChat.height + 26;
		x = GameCanvas.w / 2 - w / 2;
		y = tfChat.y - 18;
		if (Main.isPC && w > 320)
		{
			w = 320;
		}
		left.x = x;
		right.x = x + w - 68;
		if (GameCanvas.isTouch)
		{
			tfChat.y -= 5;
			y -= 20;
			h += 30;
			left.x = GameCanvas.w / 2 - 68 - 5;
			right.x = GameCanvas.w / 2 + 5;
			left.y = GameCanvas.h - 30;
			right.y = GameCanvas.h - 30;
		}
		cmdChat = new Command();
		ActionChat actionChat = delegate(string str)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			tfChat.justReturnFromTextBox = false;
			tfChat.M1926(str);
			parentScreen.onChatFromMe(str, to);
			tfChat.M1926(string.Empty);
			right.caption = mResources.CLOSE;
		};
		cmdChat.actionChat = actionChat;
		cmdChat2 = new Command();
		cmdChat2.actionChat = delegate(string str)
		{
			tfChat.justReturnFromTextBox = false;
			if (parentScreen != null)
			{
				tfChat.M1926(str);
				parentScreen.onChatFromMe(str, to);
				tfChat.M1926(string.Empty);
				tfChat.M1925();
				if (right != null)
				{
					right.M294();
				}
			}
			isShow = false;
		};
		yBegin = tfChat.y;
		yUp = GameCanvas.h / 2 - 2 * tfChat.height;
		if (Main.isWindowsPhone)
		{
			tfChat.showSubTextField = false;
		}
		if (Main.isIPhone)
		{
			tfChat.isPaintMouse = false;
		}
	}

	public void M277()
	{
	}

	public void M278(int keyCode)
	{
		if (isShow)
		{
			tfChat.M1913(keyCode);
		}
		if (tfChat.M1924().Equals(string.Empty))
		{
			right.caption = mResources.CLOSE;
		}
		else
		{
			right.caption = mResources.DELETE;
		}
	}

	public static ChatTextField M279()
	{
		if (instance == null)
		{
			return instance = new ChatTextField();
		}
		return instance;
	}

	public void M280(int firstCharacter, IChatable parentScreen, string to)
	{
		right.caption = mResources.CLOSE;
		this.to = to;
		if (Main.isWindowsPhone)
		{
			tfChat.showSubTextField = false;
		}
		if (Main.isIPhone)
		{
			tfChat.isPaintMouse = false;
		}
		tfChat.M1913(firstCharacter);
		if (!tfChat.M1924().Equals(string.Empty) && GameCanvas.currentDialog == null)
		{
			this.parentScreen = parentScreen;
			isShow = true;
		}
	}

	public void M281(IChatable parentScreen, string to)
	{
		right.caption = mResources.CLOSE;
		this.to = to;
		if (Main.isWindowsPhone)
		{
			tfChat.showSubTextField = false;
		}
		if (Main.isIPhone)
		{
			tfChat.isPaintMouse = false;
		}
		if (GameCanvas.currentDialog == null)
		{
			isShow = true;
			tfChat.isFocus = true;
			if (!Main.isPC)
			{
				ipKeyboard.M794(strChat, ipKeyboard.TEXT, string.Empty, cmdChat);
				tfChat.M1923(isFocus: true);
			}
		}
		tfChat.M1926(string.Empty);
		tfChat.M1907();
		isPublic = false;
	}

	public void M282(IChatable parentScreen, string to)
	{
		tfChat.M1923(isFocus: true);
		this.to = to;
		this.parentScreen = parentScreen;
		if (Main.isWindowsPhone)
		{
			tfChat.showSubTextField = false;
		}
		if (Main.isIPhone)
		{
			tfChat.isPaintMouse = false;
		}
		if (GameCanvas.currentDialog == null)
		{
			isShow = true;
			if (!Main.isPC)
			{
				ipKeyboard.M794(strChat, ipKeyboard.TEXT, string.Empty, cmdChat2);
				tfChat.M1923(isFocus: true);
			}
		}
		tfChat.M1926(string.Empty);
		tfChat.M1907();
		isPublic = false;
	}

	public void M283()
	{
	}

	public void M284()
	{
		if (!isShow)
		{
			return;
		}
		tfChat.M1920();
		if (Main.isWindowsPhone)
		{
			M277();
		}
		if (tfChat.justReturnFromTextBox)
		{
			tfChat.justReturnFromTextBox = false;
			parentScreen.onChatFromMe(tfChat.M1924(), to);
			tfChat.M1926(string.Empty);
			right.caption = mResources.CLOSE;
		}
		if (!Main.isPC)
		{
			return;
		}
		if (GameCanvas.keyPressed[15])
		{
			if (left != null && tfChat.M1924() != string.Empty)
			{
				left.M294();
			}
			GameCanvas.keyPressed[15] = false;
			GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
		}
		if (GameCanvas.keyPressed[14])
		{
			if (right != null)
			{
				right.M294();
			}
			GameCanvas.keyPressed[14] = false;
		}
	}

	public void M285()
	{
		tfChat.M1926(string.Empty);
		isShow = false;
	}

	public void M286(mGraphics g)
	{
		if (isShow && !Main.isIPhone)
		{
			int num = ((!Main.isWindowsPhone) ? (y - KC) : (tfChat.y - 5));
			PopUp.M1481(g, (!Main.isWindowsPhone) ? x : 0, num, (!Main.isWindowsPhone) ? w : GameCanvas.w, h, -1, isButton: true);
			if (Main.isPC)
			{
				mFont.tahoma_7b_green2.M898(g, strChat + to, tfChat.x, tfChat.y - ((!GameCanvas.isTouch) ? 12 : 17), 0);
				GameCanvas.paintz.M1208(g, left, center, right);
			}
			tfChat.M1916(g);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8000:
			Cout.M328("perform chat 8000");
			if (parentScreen != null)
			{
				long num = mSystem.M1054();
				if (num - lastChatTime >= 1000L)
				{
					lastChatTime = num;
					parentScreen.onChatFromMe(tfChat.M1924(), to);
					tfChat.M1926(string.Empty);
					right.caption = mResources.CLOSE;
					tfChat.M1925();
				}
			}
			break;
		case 8001:
			Cout.M328("perform chat 8001");
			if (tfChat.M1924().Equals(string.Empty))
			{
				isShow = false;
				parentScreen.onCancelChat();
			}
			tfChat.M1906();
			break;
		case 8002:
			break;
		}
	}
}
