public abstract class Dialog
{
	public Command left;

	public Command center;

	public Command right;

	private int lenCaption;

	public virtual void paint(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M918(-g.M920(), -g.M921());
		g.M922(0, 0, GameCanvas.w, GameCanvas.h);
		GameCanvas.paintz.M1209(g);
		GameCanvas.paintz.M1208(g, left, center, right);
	}

	public virtual void keyPress(int keyCode)
	{
		switch (keyCode)
		{
		case -22:
		case -7:
			GameCanvas.keyHold[13] = true;
			GameCanvas.keyPressed[13] = true;
			break;
		case -5:
		case 10:
			GameCanvas.keyHold[(!Main.isPC) ? 5 : 25] = true;
			GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = true;
			break;
		case -39:
		case -2:
			GameCanvas.keyHold[(!Main.isPC) ? 8 : 22] = true;
			GameCanvas.keyPressed[(!Main.isPC) ? 8 : 22] = true;
			break;
		case -38:
		case -1:
			GameCanvas.keyHold[(!Main.isPC) ? 2 : 21] = true;
			GameCanvas.keyPressed[(!Main.isPC) ? 2 : 21] = true;
			break;
		case -21:
		case -6:
			GameCanvas.keyHold[12] = true;
			GameCanvas.keyPressed[12] = true;
			break;
		}
	}

	public virtual void update()
	{
		if (center != null && (GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] || mScreen.M1034(center)))
		{
			GameCanvas.keyPressed[(!Main.isPC) ? 5 : 25] = false;
			GameCanvas.isPointerClick = false;
			mScreen.keyTouch = -1;
			GameCanvas.isPointerJustRelease = false;
			if (center != null)
			{
				center.M294();
			}
			mScreen.keyTouch = -1;
		}
		if (left != null && (GameCanvas.keyPressed[12] || mScreen.M1034(left)))
		{
			GameCanvas.keyPressed[12] = false;
			GameCanvas.isPointerClick = false;
			mScreen.keyTouch = -1;
			GameCanvas.isPointerJustRelease = false;
			if (left != null)
			{
				left.M294();
			}
			mScreen.keyTouch = -1;
		}
		if (right != null && (GameCanvas.keyPressed[13] || mScreen.M1034(right)))
		{
			GameCanvas.keyPressed[13] = false;
			GameCanvas.isPointerClick = false;
			GameCanvas.isPointerJustRelease = false;
			mScreen.keyTouch = -1;
			if (right != null)
			{
				right.M294();
			}
			mScreen.keyTouch = -1;
		}
		GameCanvas.M483();
		GameCanvas.M484();
	}

	public virtual void show()
	{
	}
}
