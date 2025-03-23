public abstract class T30
{
	public T22 left;

	public T22 center;

	public T22 right;

	private int lenCaption;

	public virtual void paint(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		g.M918(-g.M920(), -g.M921());
		g.M922(0, 0, T51.w, T51.h);
		T51.paintz.M1209(g);
		T51.paintz.M1208(g, left, center, right);
	}

	public virtual void keyPress(int keyCode)
	{
		switch (keyCode)
		{
		case -22:
		case -7:
			T51.keyHold[13] = true;
			T51.keyPressed[13] = true;
			break;
		case -5:
		case 10:
			T51.keyHold[(!Main.isPC) ? 5 : 25] = true;
			T51.keyPressed[(!Main.isPC) ? 5 : 25] = true;
			break;
		case -39:
		case -2:
			T51.keyHold[(!Main.isPC) ? 8 : 22] = true;
			T51.keyPressed[(!Main.isPC) ? 8 : 22] = true;
			break;
		case -38:
		case -1:
			T51.keyHold[(!Main.isPC) ? 2 : 21] = true;
			T51.keyPressed[(!Main.isPC) ? 2 : 21] = true;
			break;
		case -21:
		case -6:
			T51.keyHold[12] = true;
			T51.keyPressed[12] = true;
			break;
		}
	}

	public virtual void update()
	{
		if (center != null && (T51.keyPressed[(!Main.isPC) ? 5 : 25] || T108.M1034(center)))
		{
			T51.keyPressed[(!Main.isPC) ? 5 : 25] = false;
			T51.isPointerClick = false;
			T108.keyTouch = -1;
			T51.isPointerJustRelease = false;
			if (center != null)
			{
				center.M294();
			}
			T108.keyTouch = -1;
		}
		if (left != null && (T51.keyPressed[12] || T108.M1034(left)))
		{
			T51.keyPressed[12] = false;
			T51.isPointerClick = false;
			T108.keyTouch = -1;
			T51.isPointerJustRelease = false;
			if (left != null)
			{
				left.M294();
			}
			T108.keyTouch = -1;
		}
		if (right != null && (T51.keyPressed[13] || T108.M1034(right)))
		{
			T51.keyPressed[13] = false;
			T51.isPointerClick = false;
			T51.isPointerJustRelease = false;
			T108.keyTouch = -1;
			if (right != null)
			{
				right.M294();
			}
			T108.keyTouch = -1;
		}
		T51.M483();
		T51.M484();
	}

	public virtual void show()
	{
	}
}
