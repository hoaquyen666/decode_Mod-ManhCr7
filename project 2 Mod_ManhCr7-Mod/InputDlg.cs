public class InputDlg : Dialog
{
	protected string[] info;

	public TField tfInput;

	private int padLeft;

	public InputDlg()
	{
		padLeft = 40;
		if (GameCanvas.w <= 176)
		{
			padLeft = 10;
		}
		tfInput = new TField();
		tfInput.x = padLeft + 10;
		tfInput.y = GameCanvas.h - mScreen.ITEM_HEIGHT - 43;
		tfInput.width = GameCanvas.w - 2 * (padLeft + 10);
		tfInput.height = mScreen.ITEM_HEIGHT + 2;
		tfInput.isFocus = true;
		right = tfInput.cmdClear;
	}

	public void M777(string info, Command ok, int type)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		tfInput.M1926(string.Empty);
		tfInput.M1931(type);
		this.info = mFont.tahoma_8b.M907(info, GameCanvas.w - padLeft * 2);
		left = new Command(mResources.CLOSE, GameCanvas.M442(), 8882, null);
		center = ok;
		show();
	}

	public override void paint(mGraphics g)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		GameCanvas.paintz.M1220(g, padLeft, GameCanvas.h - 77 - mScreen.cmdH, GameCanvas.w - padLeft * 2, 69, info);
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
		GameCanvas.currentDialog = this;
	}

	public void M778()
	{
		GameCanvas.M488();
	}
}
