using System;

namespace Assets.src.g;

internal class Mabu : Char
{
	public static EffectData data1;

	public static EffectData data2;

	private new int tick;

	private int lastDir;

	private bool addFoot;

	private Effect effEat;

	private new Char focus;

	public int xTo;

	public int yTo;

	public bool haftBody;

	public bool change;

	private Char[] charAttack;

	private int[] damageAttack;

	private int dx;

	public static int[] skill1 = new int[30]
	{
		0, 0, 1, 1, 2, 2, 3, 3, 4, 4,
		5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
		5, 5, 5, 5, 5, 5, 5, 5, 5, 5
	};

	public static int[] skill2 = new int[15]
	{
		0, 0, 6, 6, 7, 7, 8, 8, 9, 9,
		9, 9, 9, 10, 10
	};

	public static int[] skill3 = new int[26]
	{
		0, 0, 1, 1, 2, 2, 3, 3, 4, 4,
		5, 5, 6, 6, 7, 7, 8, 8, 9, 9,
		10, 10, 11, 11, 12, 12
	};

	public static int[] skill4 = new int[8] { 13, 13, 14, 14, 15, 15, 16, 16 };

	public static int[][] skills = new int[4][] { skill1, skill2, skill3, skill4 };

	public sbyte skillID = -1;

	private int frame;

	private int pIndex;

	public Mabu()
	{
		M2282();
		M2284();
	}

	public void M2280(int id)
	{
		effEat = new Effect(105, cx, cy + 20, 2, 1, -1);
		EffectMn.M376(effEat);
		if (id == Char.M113().charID)
		{
			focus = Char.M113();
		}
		else
		{
			focus = GameScr.M626(id);
		}
	}

	public void M2281(int[] array)
	{
		if (skillID == 0)
		{
			if (tick == 11)
			{
				addFoot = true;
				EffectMn.M376(new Effect(19, cx, cy + 20, 2, 1, -1));
			}
			if (tick >= array.Length - 1)
			{
				skillID = 2;
				return;
			}
		}
		if (skillID == 1 && tick == array.Length - 1)
		{
			skillID = 3;
			cy -= 15;
			return;
		}
		tick++;
		if (tick > array.Length - 1)
		{
			tick = 0;
		}
		frame = array[tick];
	}

	public void M2282()
	{
		data1 = null;
		data1 = new EffectData();
		string patch = "/x" + mGraphics.zoomLevel + "/effectdata/" + 102 + "/data";
		try
		{
			data1.M396(patch);
			data1.img = GameCanvas.M503("/effectdata/" + 102 + "/img.png");
		}
		catch (Exception)
		{
		}
	}

	public void M2283(sbyte id, short x, short y, Char[] charHit, int[] damageHit)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		skillID = id;
		xTo = x;
		yTo = y;
		lastDir = cdir;
		cdir = ((xTo > cx) ? 1 : (-1));
		charAttack = charHit;
		damageAttack = damageHit;
	}

	public void M2284()
	{
		data2 = null;
		data2 = new EffectData();
		string patch = "/x" + mGraphics.zoomLevel + "/effectdata/" + 103 + "/data";
		try
		{
			data2.M396(patch);
			data2.img = GameCanvas.M503("/effectdata/" + 103 + "/img.png");
			Res.M1513("read xong data");
		}
		catch (Exception)
		{
		}
	}

	public override void update()
	{
		if (focus != null)
		{
			if (effEat.t >= 30)
			{
				effEat.x += (cx - effEat.x) / 4;
				effEat.y += (cy - effEat.y) / 4;
				focus.cx = effEat.x;
				focus.cy = effEat.y;
				focus.isMabuHold = true;
			}
			else
			{
				effEat.trans = ((effEat.x > focus.cx) ? 1 : 0);
				effEat.x += (focus.cx - effEat.x) / 3;
				effEat.y += (focus.cy - effEat.y) / 3;
			}
		}
		if (skillID != -1)
		{
			if (skillID == 0 && addFoot && GameCanvas.gameTick % 2 == 0)
			{
				dx += ((xTo <= cx) ? (-30) : 30);
				EffectMn.M376(new Effect(103, cx + dx, cy + 20, 2, 1, -1)
				{
					trans = ((xTo <= cx) ? 1 : 0)
				});
				if ((cdir == 1 && cx + dx >= xTo) || (cdir == -1 && cx + dx <= xTo))
				{
					addFoot = false;
					skillID = -1;
					dx = 0;
					tick = 0;
					cdir = lastDir;
					for (int i = 0; i < charAttack.Length; i++)
					{
						charAttack[i].M218(damageAttack[i], 0, isCrit: false, isMob: false);
					}
				}
			}
			if (skillID != 3)
			{
				return;
			}
			xTo = charAttack[pIndex].cx;
			yTo = charAttack[pIndex].cy;
			cx += (xTo - cx) / 3;
			cy += (yTo - cy) / 3;
			if (GameCanvas.gameTick % 5 == 0)
			{
				EffectMn.M376(new Effect(19, cx, cy, 2, 1, -1));
			}
			if (Res.M1529(cx - xTo) <= 20 && Res.M1529(cy - yTo) <= 20)
			{
				cx = xTo;
				cy = yTo;
				charAttack[pIndex].M218(damageAttack[pIndex], 0, isCrit: false, isMob: false);
				pIndex++;
				if (pIndex == charAttack.Length)
				{
					skillID = -1;
					pIndex = 0;
				}
			}
		}
		else
		{
			base.update();
		}
	}

	public override void paint(mGraphics g)
	{
		if (skillID != -1)
		{
			M192(g);
			g.M918(0, GameCanvas.transY);
			M2281(skills[skillID]);
			if (skillID != 0 && skillID != 1)
			{
				data2.M401(g, frame, cx, cy + fy, (cdir != 1) ? 1 : 0, 2);
			}
			else
			{
				data1.M401(g, frame, cx, cy + fy, (cdir != 1) ? 1 : 0, 2);
			}
			g.M918(0, -GameCanvas.transY);
		}
		else
		{
			base.paint(g);
		}
	}
}
