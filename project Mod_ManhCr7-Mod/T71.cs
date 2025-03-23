public class T71 : T30
{
	protected string[] info;

	public T173 tfInput;

	private int padLeft;

	public T71()
	{
		padLeft = 40;
		if (T51.w <= 176)
		{
			padLeft = 10;
		}
		tfInput = new T173();
		tfInput.x = padLeft + 10;
		tfInput.y = T51.h - T108.ITEM_HEIGHT - 43;
		tfInput.width = T51.w - 2 * (padLeft + 10);
		tfInput.height = T108.ITEM_HEIGHT + 2;
		tfInput.isFocus = true;
		right = tfInput.cmdClear;
	}

	public void M777(string info, T22 ok, int type)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		tfInput.M1926(string.Empty);
		tfInput.M1931(type);
		this.info = T98.tahoma_8b.M907(info, T51.w - padLeft * 2);
		left = new T22(mResources.CLOSE, T51.M442(), 8882, null);
		center = ok;
		show();
	}

	public override void paint(T99 g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T51.paintz.M1220(g, padLeft, T51.h - 77 - T108.cmdH, T51.w - padLeft * 2, 69, info);
		tfInput.M1916(g);
		base.paint(g);
	}

	public override void keyPress(int keyCode)
	{
		tfInput.M1913(keyCode);
		base.keyPress(keyCode);
	}

	public override void update()
	{
		tfInput.M1920();
		base.update();
	}

	public override void show()
	{
		T51.currentDialog = this;
	}

	public void M778()
	{
		T51.M488();
	}
}
