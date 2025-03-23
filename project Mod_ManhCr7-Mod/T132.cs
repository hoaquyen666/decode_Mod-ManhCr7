public class T132
{
	public byte type;

	public int x;

	public int y;

	public int g;

	public int v;

	public int vMax;

	public int w;

	public int h;

	public int color;

	public int limitY;

	public int vx;

	public int vy;

	public int x2;

	public int y2;

	public int toX;

	public int toY;

	public int dis;

	public int f;

	public int ftam;

	public int fRe;

	public int frame;

	public int maxframe;

	public int fSmall;

	public int goc;

	public int gocT_Arc;

	public int idir;

	public int dirThrow;

	public int dir;

	public int dir_nguoc;

	public int idSkill;

	public int id;

	public int levelPaint;

	public int num_per_frame = 1;

	public int life;

	public int goc_Arc;

	public int vx1000;

	public int vy1000;

	public int va;

	public int x1000;

	public int y1000;

	public int vX1000;

	public int vY1000;

	public long time;

	public long timecount;

	public T117 vecEffPoint;

	public string name;

	public string info;

	public bool isRemove;

	public bool isSmall;

	public bool isPaint;

	public bool isChange;

	public static T49[] FraEffInMap;

	public T49 fraImgEff;

	public T132()
	{
	}

	public T132(int x, int y)
	{
		this.x = x;
		this.y = y;
	}

	public T132(int x, int y, int goc)
	{
		this.x = x;
		this.y = y;
		this.goc = goc;
	}

	public void M1471()
	{
		f++;
		x += vx;
		y += vy;
	}

	public void M1472()
	{
		x += vx;
		y += vy;
	}

	public void M1473(T99 g)
	{
		if (!isRemove)
		{
			int num = 0;
			if (isSmall && f >= fSmall)
			{
				num = 1;
			}
			FraEffInMap[color].M439(frame / 2 + num, x, y, dis, 3, g);
		}
	}

	public void M1474()
	{
		f++;
		if (maxframe > 1)
		{
			frame++;
			if (frame / 2 >= maxframe)
			{
				frame = 0;
			}
		}
		if (f >= fRe)
		{
			isRemove = true;
		}
	}
}
