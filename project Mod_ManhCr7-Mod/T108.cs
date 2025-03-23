public class T108
{
	public T22 left;

	public T22 center;

	public T22 right;

	public T22 cmdClose;

	public static int ITEM_HEIGHT;

	public static int yOpenKeyBoard = 100;

	public static int cmdW = 68;

	public static int cmdH = 26;

	public static int keyTouch = -1;

	public static int keyMouse = -1;

	public virtual void switchToMe()
	{
		T51.M483();
		T51.M484();
		if (T51.currentScreen != null)
		{
			T51.currentScreen.unLoad();
		}
		T51.currentScreen = this;
		T24.M330("cur Screen: " + T51.currentScreen);
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
		if (T51.keyPressed[(!Main.isPC) ? 5 : 25] || M1034(T51.currentScreen.center))
		{
			T51.keyPressed[(!Main.isPC) ? 5 : 25] = false;
			keyTouch = -1;
			T51.isPointerJustRelease = false;
			if (center != null)
			{
				center.M294();
			}
		}
		if (T51.keyPressed[12] || M1034(T51.currentScreen.left))
		{
			T51.keyPressed[12] = false;
			keyTouch = -1;
			T51.isPointerJustRelease = false;
			if (T15.M279().isShow)
			{
				if (T15.M279().left != null)
				{
					T15.M279().left.M294();
				}
			}
			else if (left != null)
			{
				left.M294();
			}
		}
		if (!T51.keyPressed[13] && !M1034(T51.currentScreen.right))
		{
			return;
		}
		T51.keyPressed[13] = false;
		keyTouch = -1;
		T51.isPointerJustRelease = false;
		if (T15.M279().isShow)
		{
			if (T15.M279().right != null)
			{
				T15.M279().right.M294();
			}
		}
		else if (right != null)
		{
			right.M294();
		}
	}

	public static bool M1034(T22 cmd)
	{
		if (cmd == null)
		{
			return false;
		}
		if (cmd.x >= 0 && cmd.y != 0)
		{
			return cmd.M298();
		}
		if (T51.currentDialog != null)
		{
			if (T51.currentDialog.center != null && T51.M481(T51.w - cmdW >> 1, T51.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 1;
				if (cmd == T51.currentDialog.center && T51.isPointerClick && T51.isPointerJustRelease)
				{
					return true;
				}
			}
			if (T51.currentDialog.left != null && T51.M481(0, T51.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 0;
				if (cmd == T51.currentDialog.left && T51.isPointerClick && T51.isPointerJustRelease)
				{
					return true;
				}
			}
			if (T51.currentDialog.right != null && T51.M481(T51.w - cmdW, T51.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 2;
				if ((cmd == T51.currentDialog.right || cmd == T15.M279().right) && T51.isPointerClick && T51.isPointerJustRelease)
				{
					return true;
				}
			}
		}
		else
		{
			if (cmd == T51.currentScreen.left && T51.M481(0, T51.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 0;
				if (T51.isPointerClick && T51.isPointerJustRelease)
				{
					return true;
				}
			}
			if (cmd == T51.currentScreen.right && T51.M481(T51.w - cmdW, T51.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 2;
				if (T51.isPointerClick && T51.isPointerJustRelease)
				{
					return true;
				}
			}
			if ((cmd == T51.currentScreen.center || T14.currChatPopup != null) && T51.M481(T51.w - cmdW >> 1, T51.h - cmdH - 5, cmdW, cmdH + 10))
			{
				keyTouch = 1;
				if (T51.isPointerClick && T51.isPointerJustRelease)
				{
					return true;
				}
			}
		}
		return false;
	}

	public virtual void paint(T99 g)
	{
		g.M918(-g.M920(), -g.M921());
		g.M922(0, 0, T51.w, T51.h + 1);
		if ((!T15.M279().isShow || !Main.isPC) && T51.currentDialog == null && !T51.menu.showMenu)
		{
			T51.paintz.M1208(g, left, center, right);
		}
	}
}
