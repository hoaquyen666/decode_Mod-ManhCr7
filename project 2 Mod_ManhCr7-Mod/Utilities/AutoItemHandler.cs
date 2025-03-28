using System.Collections.Generic;
using System.Threading;

namespace Utilities;

public class AutoItemHandler : IActionListener, IChatable
{
	public class T223
	{
		public int Id;

		public string Name;

		public int Quantity;

		public short Index;

		public bool IsGold;

		public bool IsSell;

		public int Delay;

		public long LastTimeUse;

		public T223()
		{
		}

		public T223(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public T223(int id, short isGold, bool index, bool isSell)
		{
			Id = id;
			IsGold = index;
			Index = isGold;
			IsSell = isSell;
		}
	}

	private static AutoItemHandler _Instance;

	private static List<T223> listItemAuto = new List<T223>();

	private static T223 itemToAuto;

	public static List<string> set1 = new List<string>();

	public static List<string> set2 = new List<string>();

	private static bool isChangingSet;

	private static string[] inputDelay = new string[2] { "Nhập delay", "giây" };

	private static string[] inputSellQuantity = new string[2] { "Nhập số lượng bán", "số lượng" };

	private static string[] inputBuyQuantity = new string[2] { "Nhập số lượng mua", "số lượng" };

	public static AutoItemHandler M2048()
	{
		if (_Instance == null)
		{
			_Instance = new AutoItemHandler();
		}
		return _Instance;
	}

	public static void M2049()
	{
		if (listItemAuto.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < listItemAuto.Count; i++)
		{
			T223 t = listItemAuto[i];
			if (mSystem.M1054() - t.LastTimeUse > t.Delay * 1000)
			{
				t.LastTimeUse = mSystem.M1054();
				Service.M1594().M1615(0, 1, -1, (short)t.Id);
				break;
			}
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (ChatTextField.M279().tfChat.M1924() != null && !ChatTextField.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (ChatTextField.M279().strChat.Equals(inputDelay[0]))
			{
				try
				{
					int delay = int.Parse(ChatTextField.M279().tfChat.M1924());
					itemToAuto.Delay = delay;
					GameScr.info1.M762("Auto " + itemToAuto.Name + ": " + delay + " giây", 0);
					listItemAuto.Add(itemToAuto);
				}
				catch
				{
					GameScr.info1.M762("Delay Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2050();
			}
			else if (ChatTextField.M279().strChat.Equals(inputBuyQuantity[0]))
			{
				try
				{
					int quantity = int.Parse(ChatTextField.M279().tfChat.M1924());
					itemToAuto.Quantity = quantity;
					new Thread((ThreadStart)delegate
					{
						M2056(itemToAuto);
					}).Start();
				}
				catch
				{
					GameScr.info1.M762("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2050();
			}
			else
			{
				if (!ChatTextField.M279().strChat.Equals(inputSellQuantity[0]))
				{
					return;
				}
				try
				{
					int quantity2 = int.Parse(ChatTextField.M279().tfChat.M1924());
					itemToAuto.Quantity = quantity2;
					new Thread((ThreadStart)delegate
					{
						M2055(itemToAuto);
					}).Start();
				}
				catch
				{
					GameScr.info1.M762("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2050();
			}
		}
		else
		{
			ChatTextField.M279().isShow = false;
		}
	}

	public void onCancelChat()
	{
	}

	public void perform(int idAction, object p)
	{
		switch (idAction)
		{
		case 1:
			M2053((T223)p);
			break;
		case 2:
			M2052((int)p);
			break;
		case 3:
			M2054((T223)p);
			break;
		case 4:
			set1.Add(((Item)p).M821());
			break;
		case 5:
			set2.Add(((Item)p).M821());
			break;
		case 6:
			set1.Remove(((Item)p).M821());
			break;
		case 7:
			set2.Remove(((Item)p).M821());
			break;
		}
	}

	private static void M2050()
	{
		ChatTextField.M279().strChat = "Chat";
		ChatTextField.M279().tfChat.name = "chat";
		ChatTextField.M279().isShow = false;
	}

	public static bool M2051(int templateId)
	{
		for (int i = 0; i < listItemAuto.Count; i++)
		{
			if (listItemAuto[i].Id == templateId)
			{
				return true;
			}
		}
		return false;
	}

	private static void M2052(int templateId)
	{
		for (int i = 0; i < listItemAuto.Count; i++)
		{
			if (listItemAuto[i].Id == templateId)
			{
				listItemAuto.RemoveAt(i);
				break;
			}
		}
	}

	private static void M2053(T223 item)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		itemToAuto = item;
		ChatTextField.M279().strChat = inputDelay[0];
		ChatTextField.M279().tfChat.name = inputDelay[1];
		GameCanvas.panel.isShow = false;
		ChatTextField.M279().M282(M2048(), string.Empty);
	}

	private static void M2054(T223 item)
	{
		itemToAuto = item;
		GameCanvas.panel.isShow = false;
		if (item.IsSell)
		{
			ChatTextField.M279().strChat = inputSellQuantity[0];
			ChatTextField.M279().tfChat.name = inputSellQuantity[1];
		}
		else
		{
			ChatTextField.M279().strChat = inputBuyQuantity[0];
			ChatTextField.M279().tfChat.name = inputBuyQuantity[1];
		}
		ChatTextField.M279().M282(M2048(), string.Empty);
	}

	private static void M2055(T223 item)
	{
		Thread.Sleep(100);
		short index = item.Index;
		while (item.Quantity > 0)
		{
			if (Char.M113().arrItemBag[index] != null && (Char.M113().arrItemBag[index] == null || Char.M113().arrItemBag[index].template.id == (short)item.Id))
			{
				Service.M1594().M1650(0, 1, (short)(index + 3));
				Thread.Sleep(100);
				Service.M1594().M1650(1, 1, index);
				Thread.Sleep(1000);
				item.Quantity--;
				if (Char.M113().xu > 1963100000L)
				{
					GameScr.info1.M762("Xong!", 0);
					return;
				}
				continue;
			}
			GameScr.info1.M762("Không Tìm Thấy Item!", 0);
			return;
		}
		GameScr.info1.M762("Xong!", 0);
	}

	private void M2056(T223 item)
	{
		while (item.Quantity > 0 && !GameScr.M559().M551())
		{
			Service.M1594().M1651((!item.IsGold) ? ((sbyte)1) : ((sbyte)0), item.Id, 0);
			item.Quantity--;
			Thread.Sleep(1000);
		}
		GameScr.info1.M762("Xong!", 0);
	}

	public static void M2057(int type)
	{
		if (isChangingSet)
		{
			GameScr.info1.M762("Đang Mặc Đồ!", 0);
			return;
		}
		new Thread((ThreadStart)delegate
		{
			if (type == 0)
			{
				M2058(set1);
			}
			if (type == 1)
			{
				M2058(set2);
			}
		}).Start();
	}

	private static void M2058(List<string> set)
	{
		if (isChangingSet)
		{
			GameScr.info1.M762("Đang Mặc Đồ!", 0);
			return;
		}
		isChangingSet = true;
		for (int num = Char.M113().arrItemBag.Length - 1; num >= 0; num--)
		{
			Item t = Char.M113().arrItemBag[num];
			if (t != null && set.Contains(t.M821()))
			{
				Service.M1594().M1625(4, (sbyte)num);
				Thread.Sleep(100);
			}
		}
		isChangingSet = false;
	}
}
