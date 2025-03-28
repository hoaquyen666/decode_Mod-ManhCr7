public class Waypoint : IActionListener
{
	public short minX;

	public short minY;

	public short maxX;

	public short maxY;

	public bool isEnter;

	public bool isOffline;

	public PopUp popup;

	public Waypoint(short minX, short minY, short maxX, short maxY, bool isEnter, bool isOffline, string name)
	{
		this.minX = minX;
		this.minY = minY;
		this.maxX = maxX;
		this.maxY = maxY;
		name = Res.M1518(name);
		this.isEnter = isEnter;
		this.isOffline = isOffline;
		if (((TileMap.mapID == 21 || TileMap.mapID == 22 || TileMap.mapID == 23) && this.minX >= 0 && this.minX <= 24) || (((TileMap.mapID == 0 && Char.M113().cgender != 0) || (TileMap.mapID == 7 && Char.M113().cgender != 1) || (TileMap.mapID == 14 && Char.M113().cgender != 2)) && isOffline))
		{
			return;
		}
		if (!TileMap.M1945() && TileMap.mapID != 47)
		{
			if (!isEnter && !isOffline)
			{
				popup = new PopUp(name, minX, minY - 24);
				popup.command = new Command(null, this, 1, this);
				popup.isWayPoint = true;
				popup.isPaint = false;
				PopUp.M1478(popup);
			}
			else
			{
				if (TileMap.M1933())
				{
					popup = new PopUp(name, minX, minY - 16);
				}
				else
				{
					popup = new PopUp(name, minX + (maxX - minX) / 2, minY - ((minY == 0) ? (-32) : 16));
				}
				popup.command = new Command(null, this, 2, this);
				popup.isWayPoint = true;
				popup.isPaint = false;
				PopUp.M1478(popup);
			}
			TileMap.vGo.M1111(this);
		}
		else if (minY <= 150 || !TileMap.M1945())
		{
			popup = new PopUp(name, minX + (maxX - minX) / 2, maxY - ((minX <= 100) ? 48 : 24));
			popup.command = new Command(null, this, 1, this);
			popup.isWayPoint = true;
			popup.isPaint = false;
			PopUp.M1478(popup);
			TileMap.vGo.M1111(this);
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 2:
			GameScr.M559().auto = 0;
			if (Char.M113().M120() != null)
			{
				Service.M1594().M1640();
				InfoDlg.M749();
				Service.M1594().M1710();
				Char.ischangingMap = true;
			}
			else if (Char.M113().M121() != null)
			{
				Service.M1594().M1640();
				Service.M1594().M1636();
				Char.isLockKey = true;
				Char.ischangingMap = true;
				GameCanvas.M484();
				GameCanvas.M483();
				InfoDlg.M749();
			}
			else
			{
				int xEnd2 = (minX + maxX) / 2;
				short yEnd2 = maxY;
				Char.M113().currentMovePoint = new MovePoint(xEnd2, yEnd2);
				Char.M113().cdir = ((Char.M113().cx - Char.M113().currentMovePoint.xEnd <= 0) ? 1 : (-1));
				Char.M113().endMovePointCommand = new Command(null, this, 2, null);
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
			GameScr.M559().auto = 0;
			Char.M113().currentMovePoint = new MovePoint(xEnd, yEnd);
			Char.M113().cdir = ((Char.M113().cx - Char.M113().currentMovePoint.xEnd <= 0) ? 1 : (-1));
			Service.M1594().M1640();
			break;
		}
		}
	}
}
