using System.Collections.Generic;
using System.IO;

namespace N3.N4;

public class T188 : T57, T58
{
	private static T188 _Instance;

	private static bool isAutoChatPublic;

	private static long delayAutoChatPublic;

	private static long lastTimeChatPublic;

	private static string autoChatPublicContent;

	private static bool isAutoChatGlobal;

	private static long delayAutoChatGlobal;

	private static long lastTimeChatGlobal;

	private static string autoChatGlobalContent;

	private static int countChatGlobal;

	private static int gems;

	private static bool isAutoSpamChatGlobal;

	private static int spammedChatGlobalTimes;

	private static int timesSpamChatGlobal;

	public static bool isAutoInbox;

	public static List<int> listCharInbox;

	private static string autoInboxContent;

	private static long lastTimeInbox;

	private static int countChatInbox;

	private static bool isSaveData;

	private static string[] inputDelayChatPublic;

	private static string[] inputDelayChatGlobal;

	private static string[] inputSpamChatGlobal;

	static T188()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		listCharInbox = new List<int>();
		inputDelayChatPublic = new string[2] { "Nhập delay chat:", "Mili giây (>=5000ms)" };
		inputDelayChatGlobal = new string[2] { "Nhập delay chat thế giới:", "Mili giây (>=5000ms)" };
		inputSpamChatGlobal = new string[2] { "Nhập số lần spam", "Số lần" };
		M2041();
	}

	public static T188 M2037()
	{
		if (_Instance == null)
		{
			_Instance = new T188();
		}
		return _Instance;
	}

	public static void M2038()
	{
		if (isAutoChatPublic)
		{
			M2043();
		}
		if (isAutoChatGlobal)
		{
			M2044();
		}
		if (isAutoSpamChatGlobal)
		{
			M2045();
		}
		if (isAutoInbox)
		{
			M2046();
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (T15.M279().tfChat.M1924() == null || T15.M279().tfChat.M1924().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
		{
			T15.M279().isShow = false;
			M2040();
		}
		else if (T15.M279().strChat.Equals(inputDelayChatPublic[0]))
		{
			int num = 0;
			try
			{
				num = int.Parse(T15.M279().tfChat.M1924());
				if (num > 0)
				{
					try
					{
						autoChatPublicContent = File.ReadAllText("Data\\TextChatPublic.ini");
						delayAutoChatPublic = num;
						isAutoChatPublic = true;
						T54.info1.M762("Auto Chat: " + ((delayAutoChatPublic >= 5000L) ? T122.M1192(delayAutoChatPublic) : "5.000") + " mili giây", 0);
						if (isSaveData)
						{
							T138.M1543("AutoChatIsAutoChatPublic", 1);
							T138.M1538("AutoChatDelayChatPublic", delayAutoChatPublic.ToString());
						}
					}
					catch
					{
						T54.info1.M762("Lỗi đọc File!", 0);
					}
				}
				if (num <= 0)
				{
					T51.M489("Delay không hợp lệ!");
				}
			}
			catch
			{
				T51.M489("Delay không hợp lệ!");
			}
			M2040();
		}
		else if (T15.M279().strChat.Equals(inputDelayChatGlobal[0]))
		{
			int num2 = 0;
			try
			{
				num2 = int.Parse(T15.M279().tfChat.M1924());
				if (num2 > 0)
				{
					try
					{
						autoChatGlobalContent = File.ReadAllText("Data\\TextChatGlobal.ini");
						delayAutoChatGlobal = num2;
						isAutoChatGlobal = true;
						isAutoSpamChatGlobal = false;
						T54.info1.M762("Auto Chat Thế Giới: " + T122.M1192(delayAutoChatGlobal) + " mili giây", 0);
						if (isSaveData)
						{
							T138.M1543("AutoChatIsAutoChatGlobal", 1);
							T138.M1538("AutoChatDelayChatGlobal", delayAutoChatGlobal.ToString());
						}
					}
					catch
					{
						T54.info1.M762("Lỗi đọc File!", 0);
					}
				}
				if (num2 <= 0)
				{
					T51.M489("Delay không hợp lệ!");
				}
			}
			catch
			{
				T51.M489("Delay không hợp lệ!");
			}
			M2040();
		}
		else
		{
			if (!T15.M279().strChat.Equals(inputSpamChatGlobal[0]))
			{
				return;
			}
			int num3 = 0;
			try
			{
				num3 = int.Parse(T15.M279().tfChat.M1924());
				if (num3 > 0)
				{
					try
					{
						autoChatGlobalContent = File.ReadAllText("Data\\TextChatGlobal.ini");
						timesSpamChatGlobal = num3;
						spammedChatGlobalTimes = 0;
						gems = T13.M113().luong + T13.M113().luongKhoa;
						isAutoChatGlobal = false;
						isAutoSpamChatGlobal = true;
						T54.info1.M762("Spam Chat Thế Giới: " + timesSpamChatGlobal + " lần", 0);
					}
					catch
					{
						T54.info1.M762("Lỗi đọc File!", 0);
					}
				}
				if (num3 <= 0)
				{
					T51.M489("Số lần không hợp lệ!");
				}
			}
			catch
			{
				T51.M489("Số lần không hợp lệ!");
			}
			M2040();
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
			if (!isAutoChatPublic)
			{
				T15.M279().strChat = inputDelayChatPublic[0];
				T15.M279().tfChat.name = inputDelayChatPublic[1];
				T15.M279().M282(M2037(), string.Empty);
			}
			if (isAutoChatPublic)
			{
				isAutoChatPublic = false;
				T54.info1.M762("Auto Chat\n[STATUS: OFF]", 0);
				if (isSaveData)
				{
					T138.M1543("AutoChatIsAutoChatPublic", 0);
				}
			}
			break;
		case 2:
			if (!isAutoChatGlobal)
			{
				T15.M279().strChat = inputDelayChatGlobal[0];
				T15.M279().tfChat.name = inputDelayChatGlobal[1];
				T15.M279().M282(M2037(), string.Empty);
			}
			if (isAutoChatGlobal)
			{
				isAutoChatGlobal = false;
				T54.info1.M762("Auto Chat Thế Giới\n[STATUS: OFF]", 0);
				if (isSaveData)
				{
					T138.M1543("AutoChatIsAutoChatGlobal", 0);
				}
			}
			break;
		case 3:
			if (!isAutoSpamChatGlobal)
			{
				T15.M279().strChat = inputSpamChatGlobal[0];
				T15.M279().tfChat.name = inputSpamChatGlobal[1];
				T15.M279().M282(M2037(), string.Empty);
			}
			if (isAutoSpamChatGlobal)
			{
				isAutoSpamChatGlobal = false;
				T54.info1.M762("Auto Spam Chat Thế Giới\n[STATUS: OFF]", 0);
			}
			break;
		case 4:
			if (isAutoInbox)
			{
				isAutoInbox = false;
				T54.info1.M762("Auto Inbox\n[STATUS: OFF]", 0);
			}
			else
			{
				try
				{
					autoInboxContent = File.ReadAllText("Data\\TextChatInbox.ini");
					isAutoInbox = true;
					T54.info1.M762("Auto Inbox\n[STATUS: ON]", 0);
				}
				catch
				{
					T54.info1.M762("Lỗi đọc File!", 0);
				}
			}
			if (isSaveData)
			{
				T138.M1543("AutoChatIsAutoChatInbox", isAutoInbox ? 1 : 0);
			}
			break;
		case 5:
			isSaveData = !isSaveData;
			T54.info1.M762("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			T138.M1543("AutoChatIsSaveRms", isSaveData ? 1 : 0);
			if (isSaveData)
			{
				M2042();
			}
			break;
		}
	}

	public static void M2039()
	{
		M2041();
		T117 t = new T117();
		t.M1111(new T22("Auto Chat\n" + (isAutoChatPublic ? ("[" + T122.M1192(delayAutoChatPublic) + " mili giây]") : "[STATUS: OFF]"), M2037(), 1, null));
		t.M1111(new T22("Auto Chat Thế Giới\n" + (isAutoChatGlobal ? ("[" + T122.M1192(delayAutoChatGlobal) + " mili giây]") : "[STATUS: OFF]"), M2037(), 2, null));
		t.M1111(new T22("Auto Spam Chat Thế Giới\n" + (isAutoSpamChatGlobal ? ("[" + spammedChatGlobalTimes + "/" + timesSpamChatGlobal + "]") : "[STATUS: OFF]"), M2037(), 3, null));
		t.M1111(new T22("Auto Inbox\n" + (isAutoInbox ? "[STATUS: ON]" : "[STATUS: OFF]"), M2037(), 4, null));
		t.M1111(new T22("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), M2037(), 5, null));
		T51.menu.M877(t, 3);
	}

	private static void M2040()
	{
		T15.M279().strChat = "Chat";
		T15.M279().tfChat.name = "chat";
		T15.M279().isShow = false;
	}

	private static void M2041()
	{
		isSaveData = T138.M1542("AutoChatIsSaveRms") == 1;
		if (isSaveData)
		{
			isAutoChatPublic = T138.M1542("AutoChatIsAutoChatPublic") == 1;
			isAutoChatGlobal = T138.M1542("AutoChatIsAutoChatGlobal") == 1;
			isAutoInbox = T138.M1542("AutoChatIsAutoChatInbox") == 1;
			if (isAutoChatPublic)
			{
				delayAutoChatPublic = long.Parse(T138.M1536("AutoChatDelayChatPublic"));
			}
			if (isAutoChatGlobal)
			{
				delayAutoChatGlobal = long.Parse(T138.M1536("AutoChatDelayChatGlobal"));
			}
		}
	}

	private static void M2042()
	{
		T138.M1543("AutoChatIsAutoChatPublic", isAutoChatPublic ? 1 : 0);
		T138.M1543("AutoChatIsAutoChatGlobal", isAutoChatGlobal ? 1 : 0);
		T138.M1543("AutoChatIsAutoChatInbox", isAutoInbox ? 1 : 0);
		if (isAutoChatPublic)
		{
			T138.M1538("AutoChatDelayChatPublic", delayAutoChatPublic.ToString());
		}
		if (isAutoChatGlobal)
		{
			T138.M1538("AutoChatDelayChatGlobal", delayAutoChatGlobal.ToString());
		}
	}

	private static void M2043()
	{
		if (delayAutoChatPublic < 5000L)
		{
			delayAutoChatPublic = 5000L;
		}
		if (autoChatPublicContent == null || autoChatPublicContent.Equals(""))
		{
			try
			{
				autoChatPublicContent = File.ReadAllText("Data\\TextChatPublic.ini");
			}
			catch
			{
				autoChatPublicContent = "Mạnh Cris - shop manhcr7.com";
			}
		}
		if (T110.M1054() - lastTimeChatPublic > delayAutoChatPublic)
		{
			lastTimeChatPublic = T110.M1054();
			T146.M1594().M1674("(" + T137.M1522(1, 100) + " Mạnh Cr7) " + autoChatPublicContent);
		}
	}

	private static void M2044()
	{
		int num = T13.M113().luong + T13.M113().luongKhoa;
		if (num < 5)
		{
			isAutoChatGlobal = false;
			T54.info1.M762("Bạn không đủ ngọc để chat!", 0);
			return;
		}
		if (delayAutoChatGlobal <= 0L)
		{
			delayAutoChatGlobal = 5000L;
		}
		if (autoChatGlobalContent == null || autoChatGlobalContent.Equals(""))
		{
			try
			{
				autoChatGlobalContent = File.ReadAllText("Data\\TextChatGlobal.ini");
			}
			catch
			{
				autoChatGlobalContent = "Mạnh Cris - shop manhcr7.com";
			}
		}
		if (gems == num && T110.M1054() - lastTimeChatGlobal > 1000L)
		{
			lastTimeChatGlobal = T110.M1054() - delayAutoChatGlobal - 500L;
		}
		if (T110.M1054() - lastTimeChatGlobal > delayAutoChatGlobal)
		{
			lastTimeChatGlobal = T110.M1054();
			countChatGlobal++;
			gems = num;
			T146.M1594().M1694(countChatGlobal + "manhcr7: " + autoChatGlobalContent + " " + T137.M1522(1, 200));
		}
	}

	private static void M2045()
	{
		int num = T13.M113().luong + T13.M113().luongKhoa;
		if (num < 5 || timesSpamChatGlobal <= 0 || spammedChatGlobalTimes >= timesSpamChatGlobal)
		{
			isAutoSpamChatGlobal = false;
		}
		if (autoChatGlobalContent == null || autoChatGlobalContent.Equals(""))
		{
			try
			{
				autoChatGlobalContent = File.ReadAllText("Data\\TextChatGlobal.ini");
			}
			catch
			{
				autoChatGlobalContent = "Mạnh Cris - shop manhcr7.com";
			}
		}
		if (gems != num)
		{
			gems = num;
			spammedChatGlobalTimes++;
		}
		if (T110.M1054() - lastTimeChatGlobal >= 150L)
		{
			lastTimeChatGlobal = T110.M1054();
			countChatGlobal++;
			gems = num;
			T146.M1594().M1694(countChatGlobal + "manhcr7: " + autoChatGlobalContent + " " + T137.M1522(1, 200));
		}
	}

	private static void M2046()
	{
		if (listCharInbox == null)
		{
			listCharInbox = new List<int>();
		}
		for (int i = 0; i < T54.vCharInMap.M1113(); i++)
		{
			T13 t = (T13)T54.vCharInMap.M1114(i);
			if (M2047(t) && !listCharInbox.Contains(t.charID))
			{
				listCharInbox.Add(t.charID);
			}
		}
		if (autoInboxContent == null || autoInboxContent.Equals(""))
		{
			try
			{
				autoInboxContent = File.ReadAllText("Data\\TextChatInbox.ini");
			}
			catch
			{
				autoInboxContent = "Mạnh Cris - shop manhcr7.com";
			}
		}
		if (listCharInbox.Count > 0 && T110.M1054() - lastTimeInbox > 2000L)
		{
			lastTimeInbox = T110.M1054();
			countChatInbox++;
			T146.M1594().M1693(countChatInbox + "manhcr7: " + autoInboxContent + " " + T137.M1522(1, 200), listCharInbox[0]);
			listCharInbox.RemoveAt(0);
		}
	}

	private static bool M2047(T13 ch)
	{
		if (ch != null && ch.cName != null && !ch.cName.Equals("") && !char.IsUpper(char.Parse(ch.cName.Substring(0, 1))) && !ch.isPet && !ch.isMiniPet && !ch.cName.StartsWith("#"))
		{
			return !ch.cName.StartsWith("$");
		}
		return false;
	}
}
