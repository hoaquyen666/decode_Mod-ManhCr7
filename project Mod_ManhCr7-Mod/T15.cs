public class T15 : T57
{
	private static T15 instance;

	public T173 tfChat;

	public bool isShow;

	public T58 parentScreen;

	private long lastChatTime;

	public T22 left;

	public T22 cmdChat;

	public T22 right;

	public T22 center;

	private int x;

	private int y;

	private int w;

	private int h;

	private bool isPublic;

	public T22 cmdChat2;

	public int yBegin;

	public int yUp;

	public int KC;

	public string to;

	public string strChat = "Chat ";

	public T15()
	{
		tfChat = new T173();
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
		tfChat.width = T51.w - 6;
		if (Main.isPC && tfChat.width > 250)
		{
			tfChat.width = 250;
		}
		tfChat.height = T108.ITEM_HEIGHT + 2;
		tfChat.x = T51.w / 2 - tfChat.width / 2;
		tfChat.isFocus = true;
		tfChat.M1929(80);
	}

	public void M276()
	{
		left = new T22(mResources.OK, this, 8000, null, 1, T51.h - T108.cmdH + 1);
		right = new T22(mResources.DELETE, this, 8001, null, T51.w - 70, T51.h - T108.cmdH + 1);
		center = null;
		w = tfChat.width + 20;
		h = tfChat.height + 26;
		x = T51.w / 2 - w / 2;
		y = tfChat.y - 18;
		if (Main.isPC && w > 320)
		{
			w = 320;
		}
		left.x = x;
		right.x = x + w - 68;
		if (T51.isTouch)
		{
			tfChat.y -= 5;
			y -= 20;
			h += 30;
			left.x = T51.w / 2 - 68 - 5;
			right.x = T51.w / 2 + 5;
			left.y = T51.h - 30;
			right.y = T51.h - 30;
		}
		cmdChat = new T22();
		T0 actionChat = delegate(string str)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			tfChat.justReturnFromTextBox = false;
			tfChat.M1926(str);
			parentScreen.onChatFromMe(str, to);
			tfChat.M1926(string.Empty);
			right.caption = mResources.CLOSE;
		};
		cmdChat.actionChat = actionChat;
		cmdChat2 = new T22();
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
		yUp = T51.h / 2 - 2 * tfChat.height;
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

	public static T15 M279()
	{
		if (instance == null)
		{
			return instance = new T15();
		}
		return instance;
	}

	public void M280(int firstCharacter, T58 parentScreen, string to)
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
		if (!tfChat.M1924().Equals(string.Empty) && T51.currentDialog == null)
		{
			this.parentScreen = parentScreen;
			isShow = true;
		}
	}

	public void M281(T58 parentScreen, string to)
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
		if (T51.currentDialog == null)
		{
			isShow = true;
			tfChat.isFocus = true;
			if (!Main.isPC)
			{
				T77.M794(strChat, T77.TEXT, string.Empty, cmdChat);
				tfChat.M1923(isFocus: true);
			}
		}
		tfChat.M1926(string.Empty);
		tfChat.M1907();
		isPublic = false;
	}

	public void M282(T58 parentScreen, string to)
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
		if (T51.currentDialog == null)
		{
			isShow = true;
			if (!Main.isPC)
			{
				T77.M794(strChat, T77.TEXT, string.Empty, cmdChat2);
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
		if (T51.keyPressed[15])
		{
			if (left != null && tfChat.M1924() != string.Empty)
			{
				left.M294();
			}
			T51.keyPressed[15] = false;
			T51.keyPressed[(!Main.isPC) ? 5 : 25] = false;
		}
		if (T51.keyPressed[14])
		{
			if (right != null)
			{
				right.M294();
			}
			T51.keyPressed[14] = false;
		}
	}

	public void M285()
	{
		tfChat.M1926(string.Empty);
		isShow = false;
	}

	public void M286(T99 g)
	{
		if (isShow && !Main.isIPhone)
		{
			int num = ((!Main.isWindowsPhone) ? (y - KC) : (tfChat.y - 5));
			T133.M1481(g, (!Main.isWindowsPhone) ? x : 0, num, (!Main.isWindowsPhone) ? w : T51.w, h, -1, isButton: true);
			if (Main.isPC)
			{
				T98.tahoma_7b_green2.M898(g, strChat + to, tfChat.x, tfChat.y - ((!T51.isTouch) ? 12 : 17), 0);
				T51.paintz.M1208(g, left, center, right);
			}
			tfChat.M1916(g);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 8000:
			T24.M328("perform chat 8000");
			if (parentScreen != null)
			{
				long num = T110.M1054();
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
			T24.M328("perform chat 8001");
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
