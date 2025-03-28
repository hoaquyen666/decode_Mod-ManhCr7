public class mScreen
{
	public Command left;

	public Command center;

	public Command right;

	public Command cmdClose;

	public static int ITEM_HEIGHT;

	public static int yOpenKeyBoard = 100;

	public static int cmdW = 68;

	public static int cmdH = 26;

	public static int keyTouch = -1;

	public static int keyMouse = -1;

	public virtual void switchToMe()
	{
		GameCanvas.M483();
		GameCanvas.M484();
		if (GameCanvas.currentScreen != null)
		{
			GameCanvas.currentScreen.unLoad();
		}
		GameCanvas.currentScreen = this;
		Cout.M330("cur Screen: " + GameCanvas.currentScreen);
	}

	public virtual void unLoad()
	{
	}

	public static void M1033()
	{
	}

	public virtual void keyPress(int keyCode)
	{
	}

	public virtual void update()
	{
	}

	public virtual void updateKey()
	{
		if (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] || M1034(GameCanvas.currentScreen.center))
		{
			GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
			keyTouch = -1;
			GameCanvas.isPointerJustRelease = false;
			if (center != null)
			{
				center.M294();
			}
		}
		if (GameCanvas.keyPressed[12] || M1034(GameCanvas.currentScreen.left))
		{
			GameCanvas.keyPressed[12] = false;
			keyTouch = -1;
			GameCanvas.isPointerJustRelease = false;
			if (ChatTextField.M279().isShow)
			{
				if (ChatTextField.M279().left != null)
				{
					ChatTextField.M279().left.M294();
				}
			}
			else if (left != null)
			{
				left.M294();
			}
		}
		if (!GameCanvas.keyPressed[13] && !M1034(GameCanvas.currentScreen.right))
		{
			return;
		}
		GameCanvas.keyPressed[13] = false;
		keyTouch = -1;
		GameCanvas.isPointerJustRelease = false;
		if (ChatTextField.M279().isShow)
		{
			if (ChatTextField.M279().right != null)
			{
				ChatTextField.M279().right.M294();
			}
		}
		else if (right != null)
		{
			right.M294();
		}
	}

	public static bool M1034(Command cmd)
	{
		if (cmd == null)
		{
			return false;
		}
		if (cmd.x >= 0 && cmd.y != 0)
		{
			return cmd.M298();
		}
		if (GameCanvas.currentDialog != null)
		{
			if (GameCanvas.currentDialog.center != null && GameCanvas.M481(GameCanvas.w - cmdW >> 1, GameCanvas.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 1;
				if (cmd == GameCanvas.currentDialog.center && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					return true;
				}
			}
			if (GameCanvas.currentDialog.left != null && GameCanvas.M481(0, GameCanvas.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 0;
				if (cmd == GameCanvas.currentDialog.left && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					return true;
				}
			}
			if (GameCanvas.currentDialog.right != null && GameCanvas.M481(GameCanvas.w - cmdW, GameCanvas.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 2;
				if ((cmd == GameCanvas.currentDialog.right || cmd == ChatTextField.M279().right) && GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					return true;
				}
			}
		}
		else
		{
			if (cmd == GameCanvas.currentScreen.left && GameCanvas.M481(0, GameCanvas.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 0;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					return true;
				}
			}
			if (cmd == GameCanvas.currentScreen.right && GameCanvas.M481(GameCanvas.w - cmdW, GameCanvas.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 2;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					return true;
				}
			}
			if ((cmd == GameCanvas.currentScreen.center || ChatPopup.currChatPopup != null) && GameCanvas.M481(GameCanvas.w - cmdW >> 1, GameCanvas.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 1;
				if (GameCanvas.isPointerClick && GameCanvas.isPointerJustRelease)
				{
					return true;
				}
			}
		}
		return false;
	}

	public virtual void paint(mGraphics g)
	{
		g.M918(-g.M920(), -g.M921());
		g.M922(0, 0, GameCanvas.w, GameCanvas.h + 1);
		if ((!ChatTextField.M279().isShow || !Main.isPC) && GameCanvas.currentDialog == null && !GameCanvas.menu.showMenu)
		{
			GameCanvas.paintz.M1208(g, left, center, right);
		}
	}
}
