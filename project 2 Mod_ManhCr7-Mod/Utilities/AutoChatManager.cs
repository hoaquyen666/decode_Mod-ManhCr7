using System.Collections.Generic;
using System.IO;

namespace Utilities;

public class AutoChatManager : IActionListener, IChatable
{
	private static AutoChatManager _Instance;

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

	static AutoChatManager()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		listCharInbox = new List<int>();
		inputDelayChatPublic = new string[2] { "Nhập delay chat:", "Mili giây (>=5000ms)" };
		inputDelayChatGlobal = new string[2] { "Nhập delay chat thế giới:", "Mili giây (>=5000ms)" };
		inputSpamChatGlobal = new string[2] { "Nhập số lần spam", "Số lần" };
		M2041();
	}

	public static AutoChatManager M2037()
	{
		if (_Instance == null)
		{
			_Instance = new AutoChatManager();
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
		if (ChatTextField.M279().tfChat.M1924() == null || ChatTextField.M279().tfChat.M1924().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
		{
			ChatTextField.M279().isShow = false;
			M2040();
		}
		else if (ChatTextField.M279().strChat.Equals(inputDelayChatPublic[0]))
		{
			int num = 0;
			try
			{
				num = int.Parse(ChatTextField.M279().tfChat.M1924());
				if (num > 0)
				{
					try
					{
						autoChatPublicContent = File.ReadAllText("Data\\TextChatPublic.ini");
						delayAutoChatPublic = num;
						isAutoChatPublic = true;
						GameScr.info1.M762("Auto Chat: " + ((delayAutoChatPublic >= 5000L) ? NinjaUtil.M1192(delayAutoChatPublic) : "5.000") + " mili giây", 0);
						if (isSaveData)
						{
							Rms.M1543("AutoChatIsAutoChatPublic", 1);
							Rms.M1538("AutoChatDelayChatPublic", delayAutoChatPublic.ToString());
						}
					}
					catch
					{
						GameScr.info1.M762("Lỗi đọc File!", 0);
					}
				}
				if (num <= 0)
				{
					GameCanvas.M489("Delay không hợp lệ!");
				}
			}
			catch
			{
				GameCanvas.M489("Delay không hợp lệ!");
			}
			M2040();
		}
		else if (ChatTextField.M279().strChat.Equals(inputDelayChatGlobal[0]))
		{
			int num2 = 0;
			try
			{
				num2 = int.Parse(ChatTextField.M279().tfChat.M1924());
				if (num2 > 0)
				{
					try
					{
						autoChatGlobalContent = File.ReadAllText("Data\\TextChatGlobal.ini");
						delayAutoChatGlobal = num2;
						isAutoChatGlobal = true;
						isAutoSpamChatGlobal = false;
						GameScr.info1.M762("Auto Chat Thế Giới: " + NinjaUtil.M1192(delayAutoChatGlobal) + " mili giây", 0);
						if (isSaveData)
						{
							Rms.M1543("AutoChatIsAutoChatGlobal", 1);
							Rms.M1538("AutoChatDelayChatGlobal", delayAutoChatGlobal.ToString());
						}
					}
					catch
					{
						GameScr.info1.M762("Lỗi đọc File!", 0);
					}
				}
				if (num2 <= 0)
				{
					GameCanvas.M489("Delay không hợp lệ!");
				}
			}
			catch
			{
				GameCanvas.M489("Delay không hợp lệ!");
			}
			M2040();
		}
		else
		{
			if (!ChatTextField.M279().strChat.Equals(inputSpamChatGlobal[0]))
			{
				return;
			}
			int num3 = 0;
			try
			{
				num3 = int.Parse(ChatTextField.M279().tfChat.M1924());
				if (num3 > 0)
				{
					try
					{
						autoChatGlobalContent = File.ReadAllText("Data\\TextChatGlobal.ini");
						timesSpamChatGlobal = num3;
						spammedChatGlobalTimes = 0;
						gems = Char.M113().luong + Char.M113().luongKhoa;
						isAutoChatGlobal = false;
						isAutoSpamChatGlobal = true;
						GameScr.info1.M762("Spam Chat Thế Giới: " + timesSpamChatGlobal + " lần", 0);
					}
					catch
					{
						GameScr.info1.M762("Lỗi đọc File!", 0);
					}
				}
				if (num3 <= 0)
				{
					GameCanvas.M489("Số lần không hợp lệ!");
				}
			}
			catch
			{
				GameCanvas.M489("Số lần không hợp lệ!");
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
				ChatTextField.M279().strChat = inputDelayChatPublic[0];
				ChatTextField.M279().tfChat.name = inputDelayChatPublic[1];
				ChatTextField.M279().M282(M2037(), string.Empty);
			}
			if (isAutoChatPublic)
			{
				isAutoChatPublic = false;
				GameScr.info1.M762("Auto Chat\n[STATUS: OFF]", 0);
				if (isSaveData)
				{
					Rms.M1543("AutoChatIsAutoChatPublic", 0);
				}
			}
			break;
		case 2:
			if (!isAutoChatGlobal)
			{
				ChatTextField.M279().strChat = inputDelayChatGlobal[0];
				ChatTextField.M279().tfChat.name = inputDelayChatGlobal[1];
				ChatTextField.M279().M282(M2037(), string.Empty);
			}
			if (isAutoChatGlobal)
			{
				isAutoChatGlobal = false;
				GameScr.info1.M762("Auto Chat Thế Giới\n[STATUS: OFF]", 0);
				if (isSaveData)
				{
					Rms.M1543("AutoChatIsAutoChatGlobal", 0);
				}
			}
			break;
		case 3:
			if (!isAutoSpamChatGlobal)
			{
				ChatTextField.M279().strChat = inputSpamChatGlobal[0];
				ChatTextField.M279().tfChat.name = inputSpamChatGlobal[1];
				ChatTextField.M279().M282(M2037(), string.Empty);
			}
			if (isAutoSpamChatGlobal)
			{
				isAutoSpamChatGlobal = false;
				GameScr.info1.M762("Auto Spam Chat Thế Giới\n[STATUS: OFF]", 0);
			}
			break;
		case 4:
			if (isAutoInbox)
			{
				isAutoInbox = false;
				GameScr.info1.M762("Auto Inbox\n[STATUS: OFF]", 0);
			}
			else
			{
				try
				{
					autoInboxContent = File.ReadAllText("Data\\TextChatInbox.ini");
					isAutoInbox = true;
					GameScr.info1.M762("Auto Inbox\n[STATUS: ON]", 0);
				}
				catch
				{
					GameScr.info1.M762("Lỗi đọc File!", 0);
				}
			}
			if (isSaveData)
			{
				Rms.M1543("AutoChatIsAutoChatInbox", isAutoInbox ? 1 : 0);
			}
			break;
		case 5:
			isSaveData = !isSaveData;
			GameScr.info1.M762("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), 0);
			Rms.M1543("AutoChatIsSaveRms", isSaveData ? 1 : 0);
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
		MyVector t = new MyVector();
		t.M1111(new Command("Auto Chat\n" + (isAutoChatPublic ? ("[" + NinjaUtil.M1192(delayAutoChatPublic) + " mili giây]") : "[STATUS: OFF]"), M2037(), 1, null));
		t.M1111(new Command("Auto Chat Thế Giới\n" + (isAutoChatGlobal ? ("[" + NinjaUtil.M1192(delayAutoChatGlobal) + " mili giây]") : "[STATUS: OFF]"), M2037(), 2, null));
		t.M1111(new Command("Auto Spam Chat Thế Giới\n" + (isAutoSpamChatGlobal ? ("[" + spammedChatGlobalTimes + "/" + timesSpamChatGlobal + "]") : "[STATUS: OFF]"), M2037(), 3, null));
		t.M1111(new Command("Auto Inbox\n" + (isAutoInbox ? "[STATUS: ON]" : "[STATUS: OFF]"), M2037(), 4, null));
		t.M1111(new Command("Lưu Cài Đặt\n" + (isSaveData ? "[STATUS: ON]" : "[STATUS: OFF]"), M2037(), 5, null));
		GameCanvas.menu.M877(t, 3);
	}

	private static void M2040()
	{
		ChatTextField.M279().strChat = "Chat";
		ChatTextField.M279().tfChat.name = "chat";
		ChatTextField.M279().isShow = false;
	}

	private static void M2041()
	{
		isSaveData = Rms.M1542("AutoChatIsSaveRms") == 1;
		if (isSaveData)
		{
			isAutoChatPublic = Rms.M1542("AutoChatIsAutoChatPublic") == 1;
			isAutoChatGlobal = Rms.M1542("AutoChatIsAutoChatGlobal") == 1;
			isAutoInbox = Rms.M1542("AutoChatIsAutoChatInbox") == 1;
			if (isAutoChatPublic)
			{
				delayAutoChatPublic = long.Parse(Rms.M1536("AutoChatDelayChatPublic"));
			}
			if (isAutoChatGlobal)
			{
				delayAutoChatGlobal = long.Parse(Rms.M1536("AutoChatDelayChatGlobal"));
			}
		}
	}

	private static void M2042()
	{
		Rms.M1543("AutoChatIsAutoChatPublic", isAutoChatPublic ? 1 : 0);
		Rms.M1543("AutoChatIsAutoChatGlobal", isAutoChatGlobal ? 1 : 0);
		Rms.M1543("AutoChatIsAutoChatInbox", isAutoInbox ? 1 : 0);
		if (isAutoChatPublic)
		{
			Rms.M1538("AutoChatDelayChatPublic", delayAutoChatPublic.ToString());
		}
		if (isAutoChatGlobal)
		{
			Rms.M1538("AutoChatDelayChatGlobal", delayAutoChatGlobal.ToString());
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
		if (mSystem.M1054() - lastTimeChatPublic > delayAutoChatPublic)
		{
			lastTimeChatPublic = mSystem.M1054();
			Service.M1594().M1674("(" + Res.M1522(1, 100) + " Mạnh Cr7) " + autoChatPublicContent);
		}
	}

	private static void M2044()
	{
		int num = Char.M113().luong + Char.M113().luongKhoa;
		if (num < 5)
		{
			isAutoChatGlobal = false;
			GameScr.info1.M762("Bạn không đủ ngọc để chat!", 0);
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
		if (gems == num && mSystem.M1054() - lastTimeChatGlobal > 1000L)
		{
			lastTimeChatGlobal = mSystem.M1054() - delayAutoChatGlobal - 500L;
		}
		if (mSystem.M1054() - lastTimeChatGlobal > delayAutoChatGlobal)
		{
			lastTimeChatGlobal = mSystem.M1054();
			countChatGlobal++;
			gems = num;
			Service.M1594().M1694(countChatGlobal + "manhcr7: " + autoChatGlobalContent + " " + Res.M1522(1, 200));
		}
	}

	private static void M2045()
	{
		int num = Char.M113().luong + Char.M113().luongKhoa;
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
		if (mSystem.M1054() - lastTimeChatGlobal >= 150L)
		{
			lastTimeChatGlobal = mSystem.M1054();
			countChatGlobal++;
			gems = num;
			Service.M1594().M1694(countChatGlobal + "manhcr7: " + autoChatGlobalContent + " " + Res.M1522(1, 200));
		}
	}

	private static void M2046()
	{
		if (listCharInbox == null)
		{
			listCharInbox = new List<int>();
		}
		for (int i = 0; i < GameScr.vCharInMap.M1113(); i++)
		{
			Char t = (Char)GameScr.vCharInMap.M1114(i);
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
		if (listCharInbox.Count > 0 && mSystem.M1054() - lastTimeInbox > 2000L)
		{
			lastTimeInbox = mSystem.M1054();
			countChatInbox++;
			Service.M1594().M1693(countChatInbox + "manhcr7: " + autoInboxContent + " " + Res.M1522(1, 200), listCharInbox[0]);
			listCharInbox.RemoveAt(0);
		}
	}

	private static bool M2047(Char ch)
	{
		if (ch != null && ch.cName != null && !ch.cName.Equals("") && !char.IsUpper(char.Parse(ch.cName.Substring(0, 1))) && !ch.isPet && !ch.isMiniPet && !ch.cName.StartsWith("#"))
		{
			return !ch.cName.StartsWith("$");
		}
		return false;
	}
}
