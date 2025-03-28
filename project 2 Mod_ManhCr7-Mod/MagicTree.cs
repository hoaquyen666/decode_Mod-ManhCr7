using System;

public class MagicTree : Npc, IActionListener
{
	public static Image imgMagicTree;

	public static Image pea = GameCanvas.M503("/mainImage/myTexture2dhatdau.png");

	public int id;

	public int level;

	public int x;

	public int y;

	public int currPeas;

	public int remainPeas;

	public int maxPeas;

	public new string strInfo;

	public string name;

	public int timeToRecieve;

	public bool isUpdate;

	public int[] peaPostionX;

	public int[] peaPostionY;

	private int num;

	public PopUp p;

	public bool isUpdateTree;

	public static bool isPaint = true;

	public bool isPeasEffect;

	public new int seconds;

	public new long last;

	public new long cur;

	private int wPopUp;

	private bool waitToUpdate;

	private int delay;

	public MagicTree(int npcId, int status, int cx, int cy, int templateId, int iconId)
		: base(npcId, status, cx, cy, templateId, iconId)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		p = new PopUp(string.Empty, 0, 0);
		p.command = new Command(null, this, 1, null);
		PopUp.M1478(p);
	}

	public override void paint(mGraphics g)
	{
		if (id == 0)
		{
			return;
		}
		SmallImage.M1785(g, id, cx, cy, 0, StaticObj.BOTTOM_HCENTER);
		if (Char.M113().npcFocus != null && Char.M113().npcFocus.Equals(this))
		{
			g.M940(Mob.imgHP, 0, 0, 9, 6, 0, cx, cy - SmallImage.smallImg[id][4] - 1, mGraphics.BOTTOM | mGraphics.HCENTER);
			if (name != null)
			{
				mFont.tahoma_7b_white.M902(g, name, cx, cy - SmallImage.smallImg[id][4] - 20, mFont.CENTER, mFont.tahoma_7_grey);
			}
		}
		else if (name != null)
		{
			mFont.tahoma_7b_white.M902(g, name, cx, cy - SmallImage.smallImg[id][4] - 17, mFont.CENTER, mFont.tahoma_7_grey);
		}
		try
		{
			for (int i = 0; i < currPeas; i++)
			{
				g.M948(pea, cx + peaPostionX[i] - SmallImage.smallImg[id][3] / 2, cy + peaPostionY[i] - SmallImage.smallImg[id][4], 0);
			}
		}
		catch (Exception)
		{
		}
		if (indexEffTask < 0 || effTask == null || cTypePk != 0)
		{
			return;
		}
		SmallImage.M1785(g, effTask.arrEfInfo[indexEffTask].idImg, cx + effTask.arrEfInfo[indexEffTask].dx + SmallImage.smallImg[id][3] / 2 + 5, cy - 15 + effTask.arrEfInfo[indexEffTask].dy, 0, mGraphics.VCENTER | mGraphics.HCENTER);
		if (GameCanvas.gameTick % 2 == 0)
		{
			indexEffTask++;
			if (indexEffTask >= effTask.arrEfInfo.Length)
			{
				indexEffTask = 0;
			}
		}
	}

	public override void update()
	{
		p.isPaint = isPaint;
		cur = mSystem.M1054();
		if (cur - last >= 1000L)
		{
			seconds--;
			last = cur;
			if (seconds < 0)
			{
				seconds = 0;
			}
		}
		if (!isUpdate)
		{
			if (currPeas < maxPeas && seconds == 0)
			{
				waitToUpdate = true;
			}
		}
		else if (seconds == 0)
		{
			isUpdate = false;
			waitToUpdate = true;
		}
		if (waitToUpdate)
		{
			delay++;
			if (delay == 20)
			{
				delay = 0;
				waitToUpdate = false;
				Service.M1594().M1718(2);
			}
		}
		num = ((peaPostionX != null) ? (peaPostionX.Length * currPeas / maxPeas) : 0);
		if (isUpdateTree)
		{
			isUpdateTree = false;
			if ((seconds >= 0 && currPeas < maxPeas) || (seconds >= 0 && isUpdate) || isPeasEffect)
			{
				p.M1476(new string[2]
				{
					isUpdate ? mResources.UPGRADING : (currPeas + "/" + maxPeas),
					NinjaUtil.M1191(seconds)
				}, cx, cy - 20 - SmallImage.smallImg[id][4]);
			}
			else if (currPeas == maxPeas && !isUpdate)
			{
				p.M1476(new string[2]
				{
					mResources.can_harvest,
					currPeas + "/" + maxPeas
				}, cx, cy - 20 - SmallImage.smallImg[id][4]);
			}
		}
		if ((seconds >= 0 && currPeas < maxPeas) || (seconds >= 0 && isUpdate))
		{
			p.says[p.says.Length - 1] = NinjaUtil.M1191(seconds);
		}
		if (isPeasEffect)
		{
			p.isPaint = false;
			ServerEffect.M1571(98, cx + peaPostionX[currPeas - 1] - SmallImage.smallImg[id][3] / 2, cy + peaPostionY[currPeas - 1] - SmallImage.smallImg[id][4], 1);
			currPeas--;
			if (GameCanvas.gameTick % 2 == 0)
			{
				SoundMn.M1826().M1830();
			}
			if (currPeas == remainPeas)
			{
				p.isPaint = true;
				isUpdateTree = true;
				isPeasEffect = false;
			}
		}
		base.update();
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1)
		{
			Service.M1594().M1637(1);
		}
	}
}
