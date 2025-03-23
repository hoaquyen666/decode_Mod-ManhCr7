public class T180 : T57
{
	public short minX;

	public short minY;

	public short maxX;

	public short maxY;

	public bool isEnter;

	public bool isOffline;

	public T133 popup;

	public T180(short minX, short minY, short maxX, short maxY, bool isEnter, bool isOffline, string name)
	{
		this.minX = minX;
		this.minY = minY;
		this.maxX = maxX;
		this.maxY = maxY;
		name = T137.M1518(name);
		this.isEnter = isEnter;
		this.isOffline = isOffline;
		if (((T174.mapID == 21 || T174.mapID == 22 || T174.mapID == 23) && this.minX >= 0 && this.minX <= 24) || (((T174.mapID == 0 && T13.M113().cgender != 0) || (T174.mapID == 7 && T13.M113().cgender != 1) || (T174.mapID == 14 && T13.M113().cgender != 2)) && isOffline))
		{
			return;
		}
		if (!T174.M1945() && T174.mapID != 47)
		{
			if (!isEnter && !isOffline)
			{
				popup = new T133(name, minX, minY - 24);
				popup.command = new T22(null, this, 1, this);
				popup.isWayPoint = true;
				popup.isPaint = false;
				T133.M1478(popup);
			}
			else
			{
				if (T174.M1933())
				{
					popup = new T133(name, minX, minY - 16);
				}
				else
				{
					popup = new T133(name, minX + (maxX - minX) / 2, minY - ((minY == 0) ? (-32) : 16));
				}
				popup.command = new T22(null, this, 2, this);
				popup.isWayPoint = true;
				popup.isPaint = false;
				T133.M1478(popup);
			}
			T174.vGo.M1111(this);
		}
		else if (minY <= 150 || !T174.M1945())
		{
			popup = new T133(name, minX + (maxX - minX) / 2, maxY - ((minX <= 100) ? 48 : 24));
			popup.command = new T22(null, this, 1, this);
			popup.isWayPoint = true;
			popup.isPaint = false;
			T133.M1478(popup);
			T174.vGo.M1111(this);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 2:
			T54.M559().auto = 0;
			if (T13.M113().M120() != null)
			{
				T146.M1594().M1640();
				T66.M749();
				T146.M1594().M1710();
				T13.ischangingMap = true;
			}
			else if (T13.M113().M121() != null)
			{
				T146.M1594().M1640();
				T146.M1594().M1636();
				T13.isLockKey = true;
				T13.ischangingMap = true;
				T51.M484();
				T51.M483();
				T66.M749();
			}
			else
			{
				int xEnd2 = (minX + maxX) / 2;
				short yEnd2 = maxY;
				T13.M113().currentMovePoint = new T107(xEnd2, yEnd2);
				T13.M113().cdir = ((T13.M113().cx - T13.M113().currentMovePoint.xEnd <= 0) ? 1 : (-1));
				T13.M113().endMovePointCommand = new T22(null, this, 2, null);
			}
			break;
		case 1:
		{
			int xEnd = (minX + maxX) / 2;
			int yEnd = maxY;
			if (maxY > minY + 24)
			{
				yEnd = (minY + maxY) / 2;
			}
			T54.M559().auto = 0;
			T13.M113().currentMovePoint = new T107(xEnd, yEnd);
			T13.M113().cdir = ((T13.M113().cx - T13.M113().currentMovePoint.xEnd <= 0) ? 1 : (-1));
			T146.M1594().M1640();
			break;
		}
		}
	}
}
