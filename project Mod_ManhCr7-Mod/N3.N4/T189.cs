using System.Collections.Generic;
using System.Threading;

namespace N3.N4;

public class T189 : T57, T58
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

	private static T189 _Instance;

	private static List<T223> listItemAuto = new List<T223>();

	private static T223 itemToAuto;

	public static List<string> set1 = new List<string>();

	public static List<string> set2 = new List<string>();

	private static bool isChangingSet;

	private static string[] inputDelay = new string[2] { "Nhập delay", "giây" };

	private static string[] inputSellQuantity = new string[2] { "Nhập số lượng bán", "số lượng" };

	private static string[] inputBuyQuantity = new string[2] { "Nhập số lượng mua", "số lượng" };

	public static T189 M2048()
	{
		if (_Instance == null)
		{
			_Instance = new T189();
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
			if (T110.M1054() - t.LastTimeUse > t.Delay * 1000)
			{
				t.LastTimeUse = T110.M1054();
				T146.M1594().M1615(0, 1, -1, (short)t.Id);
				break;
			}
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (T15.M279().tfChat.M1924() != null && !T15.M279().tfChat.M1924().Equals(string.Empty) && !text.Equals(string.Empty) && text != null)
		{
			if (T15.M279().strChat.Equals(inputDelay[0]))
			{
				try
				{
					int delay = int.Parse(T15.M279().tfChat.M1924());
					itemToAuto.Delay = delay;
					T54.info1.M762("Auto " + itemToAuto.Name + ": " + delay + " giây", 0);
					listItemAuto.Add(itemToAuto);
				}
				catch
				{
					T54.info1.M762("Delay Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2050();
			}
			else if (T15.M279().strChat.Equals(inputBuyQuantity[0]))
			{
				try
				{
					int quantity = int.Parse(T15.M279().tfChat.M1924());
					itemToAuto.Quantity = quantity;
					new Thread((ThreadStart)delegate
					{
						M2056(itemToAuto);
					}).Start();
				}
				catch
				{
					T54.info1.M762("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2050();
			}
			else
			{
				if (!T15.M279().strChat.Equals(inputSellQuantity[0]))
				{
					return;
				}
				try
				{
					int quantity2 = int.Parse(T15.M279().tfChat.M1924());
					itemToAuto.Quantity = quantity2;
					new Thread((ThreadStart)delegate
					{
						M2055(itemToAuto);
					}).Start();
				}
				catch
				{
					T54.info1.M762("Số Lượng Không Hợp Lệ, Vui Lòng Nhập Lại!", 0);
				}
				M2050();
			}
		}
		else
		{
			T15.M279().isShow = false;
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
			set1.Add(((T79)p).M821());
			break;
		case 5:
			set2.Add(((T79)p).M821());
			break;
		case 6:
			set1.Remove(((T79)p).M821());
			break;
		case 7:
			set2.Remove(((T79)p).M821());
			break;
		}
	}

	private static void M2050()
	{
		T15.M279().strChat = "Chat";
		T15.M279().tfChat.name = "chat";
		T15.M279().isShow = false;
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
		T15.M279().strChat = inputDelay[0];
		T15.M279().tfChat.name = inputDelay[1];
		T51.panel.isShow = false;
		T15.M279().M282(M2048(), string.Empty);
	}

	private static void M2054(T223 item)
	{
		itemToAuto = item;
		T51.panel.isShow = false;
		if (item.IsSell)
		{
			T15.M279().strChat = inputSellQuantity[0];
			T15.M279().tfChat.name = inputSellQuantity[1];
		}
		else
		{
			T15.M279().strChat = inputBuyQuantity[0];
			T15.M279().tfChat.name = inputBuyQuantity[1];
		}
		T15.M279().M282(M2048(), string.Empty);
	}

	private static void M2055(T223 item)
	{
		Thread.Sleep(100);
		short index = item.Index;
		while (item.Quantity > 0)
		{
			if (T13.M113().arrItemBag[index] != null && (T13.M113().arrItemBag[index] == null || T13.M113().arrItemBag[index].template.id == (short)item.Id))
			{
				T146.M1594().M1650(0, 1, (short)(index + 3));
				Thread.Sleep(100);
				T146.M1594().M1650(1, 1, index);
				Thread.Sleep(1000);
				item.Quantity--;
				if (T13.M113().xu > 1963100000L)
				{
					T54.info1.M762("Xong!", 0);
					return;
				}
				continue;
			}
			T54.info1.M762("Không Tìm Thấy Item!", 0);
			return;
		}
		T54.info1.M762("Xong!", 0);
	}

	private void M2056(T223 item)
	{
		while (item.Quantity > 0 && !T54.M559().M551())
		{
			T146.M1594().M1651((!item.IsGold) ? ((sbyte)1) : ((sbyte)0), item.Id, 0);
			item.Quantity--;
			Thread.Sleep(1000);
		}
		T54.info1.M762("Xong!", 0);
	}

	public static void M2057(int type)
	{
		if (isChangingSet)
		{
			T54.info1.M762("Đang Mặc Đồ!", 0);
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
			T54.info1.M762("Đang Mặc Đồ!", 0);
			return;
		}
		isChangingSet = true;
		for (int num = T13.M113().arrItemBag.Length - 1; num >= 0; num--)
		{
			T79 t = T13.M113().arrItemBag[num];
			if (t != null && set.Contains(t.M821()))
			{
				T146.M1594().M1625(4, (sbyte)num);
				Thread.Sleep(100);
			}
		}
		isChangingSet = false;
	}
}
