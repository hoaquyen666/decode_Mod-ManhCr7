using System;
using System.Collections.Generic;

namespace N3.N4;

public class T192 : T57, T58
{
	private static T192 _Instance;

	public static bool isAutoPick;

	public static long lastTimePickedItem;

	private static int maximumPickDistance;

	private static bool isTeleportToItem;

	private static bool isPickAll;

	public static int pickByList;

	private static List<int> listItemAutoPick;

	private static string[] inputMaximumPickDistance;

	private static string[] inputItemID;

	static T192()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		maximumPickDistance = 50;
		listItemAutoPick = new List<int>();
		inputMaximumPickDistance = new string[2] { "Nhập khoảng cách nhặt", "khoảng cách (>50)" };
		inputItemID = new string[2] { "Nhập ID của item", "ID" };
	}

	public static T192 M2106()
	{
		if (_Instance == null)
		{
			_Instance = new T192();
		}
		return _Instance;
	}

	public static void M2107()
	{
		if ((T54.isAutoPlay && (T54.canAutoPlay || T195.isAutoTrain)) || !isAutoPick)
		{
			return;
		}
		if (M2116(T174.mapID))
		{
			try
			{
				for (int i = 0; i < T54.vItemMap.M1113(); i++)
				{
					T80 t = (T80)T54.vItemMap.M1114(i);
					int num = T94.M869(T13.M113().cx - t.x);
					if ((t.playerId == T13.M113().charID || t.playerId == -1) && num <= 60 && t != null && T110.M1054() - lastTimePickedItem > 550L && M2117(t))
					{
						T146.M1594().M1670(t.itemMapID);
						lastTimePickedItem = T110.M1054();
						break;
					}
				}
			}
			catch (Exception)
			{
			}
		}
		if (!M2116(T174.mapID))
		{
			M2112();
			if (T13.M113().itemFocus != null)
			{
				M2113();
			}
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (T15.M279().tfChat.M1924() != null && !T15.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (T15.M279().strChat.Equals(inputMaximumPickDistance[0]))
			{
				try
				{
					int num = (maximumPickDistance = int.Parse(T15.M279().tfChat.M1924()));
					T54.info1.M762("Khoảng Cách Nhặt: " + num, 0);
				}
				catch
				{
					T54.info1.M762("Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2109();
			}
			else if (T15.M279().strChat.Equals(inputItemID[0]))
			{
				try
				{
					int item = int.Parse(T15.M279().tfChat.M1924());
					listItemAutoPick.Add(item);
					T54.info1.M762("Đã Thêm Item " + item, 0);
				}
				catch
				{
					T54.info1.M762("Số Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2109();
			}
		}
		else
		{
			T15.M279().isShow = false;
		}
	}

	public void onCancelChat()
	{
		if (T54.isPaintMessage)
		{
			T54.isPaintMessage = false;
			T15.M279().center = null;
		}
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 1:
			isAutoPick = !isAutoPick;
			pickByList = 0;
			T54.info1.M762("Auto Nhặt\n" + (isAutoPick ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 2:
			isPickAll = !isPickAll;
			T54.info1.M762("Nhặt Tất Cả\n" + (isPickAll ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 3:
			isAutoPick = !isAutoPick;
			pickByList = 1;
			T54.info1.M762("Nhặt Theo Danh Sách\n" + (isAutoPick ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 4:
			isTeleportToItem = !isTeleportToItem;
			T54.info1.M762("Dịch Đến Item\n" + (isTeleportToItem ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			break;
		case 5:
			T15.M279().strChat = inputMaximumPickDistance[0];
			T15.M279().tfChat.name = inputMaximumPickDistance[1];
			T15.M279().M282(M2106(), string.Empty);
			break;
		case 6:
			if (listItemAutoPick.Count == 0)
			{
				T54.info1.M762("Danh Sách Trống!", 0);
			}
			if (listItemAutoPick.Count > 0)
			{
				string text = "";
				for (int i = 0; i < listItemAutoPick.Count; i++)
				{
					text = text + listItemAutoPick[i] + " ";
				}
				T54.info1.M762(text, 0);
			}
			break;
		case 7:
			listItemAutoPick.Clear();
			T54.info1.M762("Đã Clear Danh Sách Nhặt!", 0);
			break;
		case 8:
			T15.M279().strChat = inputItemID[0];
			T15.M279().tfChat.name = inputItemID[1];
			T15.M279().M282(M2106(), string.Empty);
			break;
		case 9:
			listItemAutoPick.Add(T13.M113().itemFocus.template.id);
			T54.info1.M762("Đã thêm " + T13.M113().itemFocus.template.name + " [" + T13.M113().itemFocus.template.id + "]", 0);
			break;
		}
	}

	public static void M2108()
	{
		T117 t = new T117();
		t.M1111(new T22("Auto Nhặt\n" + ((!isAutoPick || pickByList != 0) ? "[STATUS: OFF]" : "[STATUS: ON]"), M2106(), 1, null));
		t.M1111(new T22("Nhặt Tất Cả\n" + (isPickAll ? "[STATUS: ON]" : "[STATUS: OFF]"), M2106(), 2, null));
		t.M1111(new T22("Nhặt Theo Danh Sách\n" + ((!isAutoPick || pickByList != 1) ? "[STATUS: OFF]" : "[STATUS: ON]"), M2106(), 3, null));
		t.M1111(new T22("Dịch Đến Item\n" + (isTeleportToItem ? "[STATUS: ON]" : "[STATUS: OFF]"), M2106(), 4, null));
		t.M1111(new T22("Khoảng Cách Nhặt\n[" + maximumPickDistance + "]", M2106(), 5, null));
		t.M1111(new T22("Xem Danh Sách Nhặt", M2106(), 6, null));
		t.M1111(new T22("Clear Danh Sách Nhặt", M2106(), 7, null));
		t.M1111(new T22("Thêm ItemID", M2106(), 8, null));
		if (T13.M113().itemFocus != null)
		{
			t.M1111(new T22("Thêm: " + T13.M113().itemFocus.template.name + " [" + T13.M113().itemFocus.template.id + "] ", M2106(), 9, null));
		}
		T51.menu.M877(t, 3);
	}

	private static void M2109()
	{
		T15.M279().strChat = "Chat";
		T15.M279().tfChat.name = "chat";
		T15.M279().isShow = false;
	}

	private static void M2110()
	{
	}

	private static void M2111()
	{
	}

	public static void M2112()
	{
		if (T13.M113().itemFocus != null)
		{
			return;
		}
		for (int i = 0; i < T54.vItemMap.M1113(); i++)
		{
			T80 t = (T80)T54.vItemMap.M1114(i);
			int num = T94.M869(T13.M113().cx - t.x);
			int num2 = T94.M869(T13.M113().cy - t.y);
			if (num <= maximumPickDistance && num2 <= maximumPickDistance && M2115(t) && t.template.id != 673)
			{
				T13.M113().itemFocus = t;
				break;
			}
		}
	}

	public static void M2113()
	{
		if (T110.M1054() - lastTimePickedItem < 550L || T13.M113().itemFocus == null)
		{
			return;
		}
		if (isTeleportToItem && !T13.isLockKey)
		{
			M2114(T13.M113().itemFocus.x, T13.M113().itemFocus.y);
			T51.M484();
			T51.M483();
			if (T13.M113().itemFocus.template.id != 673)
			{
				T146.M1594().M1670(T13.M113().itemFocus.itemMapID);
				lastTimePickedItem = T110.M1054();
			}
			return;
		}
		if (T13.M113().cx < T13.M113().itemFocus.x)
		{
			T13.M113().cdir = 1;
		}
		else
		{
			T13.M113().cdir = -1;
		}
		int num = T94.M869(T13.M113().cx - T13.M113().itemFocus.x);
		int num2 = T94.M869(T13.M113().cy - T13.M113().itemFocus.y);
		if (num <= 40 && num2 < 40)
		{
			T51.M484();
			T51.M483();
			if (T13.M113().itemFocus.template.id != 673)
			{
				T146.M1594().M1670(T13.M113().itemFocus.itemMapID);
				lastTimePickedItem = T110.M1054();
			}
		}
		else
		{
			T13.M113().currentMovePoint = new T107(T13.M113().itemFocus.x, T13.M113().itemFocus.y);
			T13.M113().endMovePointCommand = new T22(null, null, 8002, null);
			T51.M484();
			T51.M483();
		}
	}

	private static void M2114(int x, int y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		T13.M113().cx = x;
		T13.M113().cy = y;
		T146.M1594().M1640();
		T13.M113().cx = x;
		T13.M113().cy = y + 1;
		T146.M1594().M1640();
		T13.M113().cx = x;
		T13.M113().cy = y;
		T146.M1594().M1640();
	}

	private static bool M2115(T80 item)
	{
		if (isPickAll)
		{
			return true;
		}
		if (pickByList == 0)
		{
			if (item.playerId != T13.M113().charID)
			{
				return item.playerId == -1;
			}
			return true;
		}
		if (pickByList == 1 && listItemAutoPick.Contains(item.template.id))
		{
			if (item.playerId != T13.M113().charID)
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

	private static bool M2117(T80 item)
	{
		if (item.template.id >= 372)
		{
			return item.template.id <= 378;
		}
		return false;
	}
}
