using System;
using System.Collections.Generic;

namespace Utilities;

public class AutoPickItem : IActionListener, IChatable
{
	private static AutoPickItem _Instance;

	public static bool isAutoPick;

	public static long lastTimePickedItem;

	private static int maximumPickDistance;

	private static bool isTeleportToItem;

	private static bool isPickAll;

	public static int pickByList;

	private static List<int> listItemAutoPick;

	private static string[] inputMaximumPickDistance;

	private static string[] inputItemID;

	static AutoPickItem()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		maximumPickDistance = 50;
		listItemAutoPick = new List<int>();
		inputMaximumPickDistance = new string[2] { "Nhập khoảng cách nhặt", "khoảng cách (>50)" };
		inputItemID = new string[2] { "Nhập ID của item", "ID" };
	}

	public static AutoPickItem M2106()
	{
		if (_Instance == null)
		{
			_Instance = new AutoPickItem();
		}
		return _Instance;
	}

	public static void M2107()
	{
		if ((GameScr.isAutoPlay && (GameScr.canAutoPlay || AutoCombatSystem.isAutoTrain)) || !isAutoPick)
		{
			return;
		}
		if (M2116(TileMap.mapID))
		{
			try
			{
				for (int i = 0; i < GameScr.vItemMap.M1113(); i++)
				{
					ItemMap t = (ItemMap)GameScr.vItemMap.M1114(i);
					int num = Math.M869(Char.M113().cx - t.x);
					if ((t.playerId == Char.M113().charID || t.playerId == -1) && num <= 60 && t != null && mSystem.M1054() - lastTimePickedItem > 550L && M2117(t))
					{
						Service.M1594().M1670(t.itemMapID);
						lastTimePickedItem = mSystem.M1054();
						break;
					}
				}
			}
			catch (Exception)
			{
			}
		}
		if (!M2116(TileMap.mapID))
		{
			M2112();
			if (Char.M113().itemFocus != null)
			{
				M2113();
			}
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (ChatTextField.M279().tfChat.M1924() != null && !ChatTextField.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (ChatTextField.M279().strChat.Equals(inputMaximumPickDistance[0]))
			{
				try
				{
					int num = (maximumPickDistance = int.Parse(ChatTextField.M279().tfChat.M1924()));
					GameScr.info1.M762("Khoảng Cách Nhặt: " + num, 0);
				}
				catch
				{
					GameScr.info1.M762("Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2109();
			}
			else if (ChatTextField.M279().strChat.Equals(inputItemID[0]))
			{
				try
				{
					int item = int.Parse(ChatTextField.M279().tfChat.M1924());
					listItemAutoPick.Add(item);
					GameScr.info1.M762("Đã Thêm Item " + item, 0);
				}
				catch
				{
					GameScr.info1.M762("Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2109();
			}
		}
		else
		{
			ChatTextField.M279().isShow = false;
		}
	}

	public void onCancelChat()
	{
		if (GameScr.isPaintMessage)
		{
			GameScr.isPaintMessage = false;
			ChatTextField.M279().center = null;
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 1:
			isAutoPick = !isAutoPick;
			pickByList = 0;
			GameScr.info1.M762("Auto Nhặt\n" + (isAutoPick ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 2:
			isPickAll = !isPickAll;
			GameScr.info1.M762("Nhặt Tất Cả\n" + (isPickAll ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 3:
			isAutoPick = !isAutoPick;
			pickByList = 1;
			GameScr.info1.M762("Nhặt Theo Danh Sách\n" + (isAutoPick ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 4:
			isTeleportToItem = !isTeleportToItem;
			GameScr.info1.M762("Dịch Đến Item\n" + (isTeleportToItem ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 5:
			ChatTextField.M279().strChat = inputMaximumPickDistance[0];
			ChatTextField.M279().tfChat.name = inputMaximumPickDistance[1];
			ChatTextField.M279().M282(M2106(), string.Empty);
			break;
		case 6:
			if (listItemAutoPick.Count == 0)
			{
				GameScr.info1.M762("Danh Sách Trống!", 0);
			}
			if (listItemAutoPick.Count > 0)
			{
				string text = "";
				for (int i = 0; i < listItemAutoPick.Count; i++)
				{
					text = text + listItemAutoPick[i] + " ";
				}
				GameScr.info1.M762(text, 0);
			}
			break;
		case 7:
			listItemAutoPick.Clear();
			GameScr.info1.M762("Đã Clear Danh Sách Nhặt!", 0);
			break;
		case 8:
			ChatTextField.M279().strChat = inputItemID[0];
			ChatTextField.M279().tfChat.name = inputItemID[1];
			ChatTextField.M279().M282(M2106(), string.Empty);
			break;
		case 9:
			listItemAutoPick.Add(Char.M113().itemFocus.template.id);
			GameScr.info1.M762("Đã thêm " + Char.M113().itemFocus.template.name + " [" + Char.M113().itemFocus.template.id + "]", 0);
			break;
		}
	}

	public static void M2108()
	{
		MyVector t = new MyVector();
		t.M1111(new Command("Auto Nhặt\n" + ((!isAutoPick || pickByList != 0) ? "[STATUS: OFF]" : "[STATUS: ON]"), M2106(), 1, null));
		t.M1111(new Command("Nhặt Tất Cả\n" + (isPickAll ? "[STATUS: ON]" : "[STATUS: OFF]"), M2106(), 2, null));
		t.M1111(new Command("Nhặt Theo Danh Sách\n" + ((!isAutoPick || pickByList != 1) ? "[STATUS: OFF]" : "[STATUS: ON]"), M2106(), 3, null));
		t.M1111(new Command("Dịch Đến Item\n" + (isTeleportToItem ? "[STATUS: ON]" : "[STATUS: OFF]"), M2106(), 4, null));
		t.M1111(new Command("Khoảng Cách Nhặt\n[" + maximumPickDistance + "]", M2106(), 5, null));
		t.M1111(new Command("Xem Danh Sách Nhặt", M2106(), 6, null));
		t.M1111(new Command("Clear Danh Sách Nhặt", M2106(), 7, null));
		t.M1111(new Command("Thêm ItemID", M2106(), 8, null));
		if (Char.M113().itemFocus != null)
		{
			t.M1111(new Command("Thêm: " + Char.M113().itemFocus.template.name + " [" + Char.M113().itemFocus.template.id + "] ", M2106(), 9, null));
		}
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2109()
	{
		ChatTextField.M279().strChat = "Chat";
		ChatTextField.M279().tfChat.name = "chat";
		ChatTextField.M279().isShow = false;
	}

	private static void M2110()
	{
	}

	private static void M2111()
	{
	}

	public static void M2112()
	{
		if (Char.M113().itemFocus != null)
		{
			return;
		}
		for (int i = 0; i < GameScr.vItemMap.M1113(); i++)
		{
			ItemMap t = (ItemMap)GameScr.vItemMap.M1114(i);
			int num = Math.M869(Char.M113().cx - t.x);
			int num2 = Math.M869(Char.M113().cy - t.y);
			if (num <= maximumPickDistance && num2 <= maximumPickDistance && M2115(t) && t.template.id != 673)
			{
				Char.M113().itemFocus = t;
				break;
			}
		}
	}

	public static void M2113()
	{
		if (mSystem.M1054() - lastTimePickedItem < 550L || Char.M113().itemFocus == null)
		{
			return;
		}
		if (isTeleportToItem && !Char.isLockKey)
		{
			M2114(Char.M113().itemFocus.x, Char.M113().itemFocus.y);
			GameCanvas.M484();
			GameCanvas.M483();
			if (Char.M113().itemFocus.template.id != 673)
			{
				Service.M1594().M1670(Char.M113().itemFocus.itemMapID);
				lastTimePickedItem = mSystem.M1054();
			}
			return;
		}
		if (Char.M113().cx < Char.M113().itemFocus.x)
		{
			Char.M113().cdir = 1;
		}
		else
		{
			Char.M113().cdir = -1;
		}
		int num = Math.M869(Char.M113().cx - Char.M113().itemFocus.x);
		int num2 = Math.M869(Char.M113().cy - Char.M113().itemFocus.y);
		if (num <= 40 && num2 < 40)
		{
			GameCanvas.M484();
			GameCanvas.M483();
			if (Char.M113().itemFocus.template.id != 673)
			{
				Service.M1594().M1670(Char.M113().itemFocus.itemMapID);
				lastTimePickedItem = mSystem.M1054();
			}
		}
		else
		{
			Char.M113().currentMovePoint = new MovePoint(Char.M113().itemFocus.x, Char.M113().itemFocus.y);
			Char.M113().endMovePointCommand = new Command(null, null, 8002, null);
			GameCanvas.M484();
			GameCanvas.M483();
		}
	}

	private static void M2114(int x, int y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Char.M113().cx = x;
		Char.M113().cy = y;
		Service.M1594().M1640();
		Char.M113().cx = x;
		Char.M113().cy = y + 1;
		Service.M1594().M1640();
		Char.M113().cx = x;
		Char.M113().cy = y;
		Service.M1594().M1640();
	}

	private static bool M2115(ItemMap item)
	{
		if (isPickAll)
		{
			return true;
		}
		if (pickByList == 0)
		{
			if (item.playerId != Char.M113().charID)
			{
				return item.playerId == -1;
			}
			return true;
		}
		if (pickByList == 1 && listItemAutoPick.Contains(item.template.id))
		{
			if (item.playerId != Char.M113().charID)
			{
				return item.playerId == -1;
			}
			return true;
		}
		return false;
	}

	private static bool M2116(int mapID)
	{
		if (mapID >= 85)
		{
			return mapID <= 91;
		}
		return false;
	}

	private static bool M2117(ItemMap item)
	{
		if (item.template.id >= 372)
		{
			return item.template.id <= 378;
		}
		return false;
	}
}
