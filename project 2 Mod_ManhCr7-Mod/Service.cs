using System;
using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using Utilities;
using Xmap;
public class Service
{
	private ISession session = Session_ME.M1744();

	protected static Service instance;

	public static long curCheckController;

	public static long curCheckMap;

	public static long logController;

	public static long logMap;

	public int demGui;

	public static bool reciveFromMainSession;

	public static Service M1594()
	{
		if (instance == null)
		{
			instance = new Service();
		}
		return instance;
	}

	public void M1595(int id)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)18);
			t.M888().M1135(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1596()
	{
		if (mSystem.android_pack == null)
		{
			return;
		}
		Message t = null;
		try
		{
			t = new Message((sbyte)126);
			t.M888().M1140(mSystem.android_pack);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1597(string day, string month, string year, string address, string cmnd, string dayCmnd, string noiCapCmnd, string sdt, string name)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)42);
			t.M888().M1140(day);
			t.M888().M1140(month);
			t.M888().M1140(year);
			t.M888().M1140(address);
			t.M888().M1140(cmnd);
			t.M888().M1140(dayCmnd);
			t.M888().M1140(noiCapCmnd);
			t.M888().M1140(sdt);
			t.M888().M1140(name);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1598()
	{
		if (mSystem.android_pack == null)
		{
			return;
		}
		Message t = null;
		try
		{
			t = new Message((sbyte)126);
			t.M888().M1140(mSystem.android_pack);
			if (Session_ME2.M1757().isConnected() && !Session_ME2.connecting)
			{
				session = Session_ME2.M1757();
			}
			else
			{
				session = Session_ME.M1744();
			}
			session.sendMessage(t);
			session = Session_ME.M1744();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1599(sbyte status)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-44));
			t.M888().M1126(status);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1600(sbyte action, MyVector id)
	{
		Res.M1513("combine");
		Message t = null;
		try
		{
			t = new Message((sbyte)(-81));
			t.M888().M1126(action);
			if (action == 1)
			{
				t.M888().M1127(id.M1113());
				for (int i = 0; i < id.M1113(); i++)
				{
					t.M888().M1127(((Item)id.M1114(i)).indexUI);
					Res.M1513("gui id " + ((Item)id.M1114(i)).indexUI);
				}
			}
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1601(sbyte action, int playerID, sbyte index, int num)
	{
		Res.M1514("giao dich action = " + action);
		Message t = null;
		try
		{
			t = new Message((sbyte)(-86));
			t.M888().M1126(action);
			if (action == 0 || action == 1)
			{
				Res.M1514(">>>> len playerID =" + playerID);
				t.M888().M1135(playerID);
			}
			if (action == 2)
			{
				Res.M1514("gui len index =" + index + " num= " + num);
				t.M888().M1126(index);
				t.M888().M1135(num);
			}
			if (action == 4)
			{
				Res.M1514(">>>> len index =" + index);
				t.M888().M1126(index);
			}
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1602(TField[] t)
	{
		Message t2 = null;
		try
		{
			Res.M1513(" gui input ");
			t2 = new Message((sbyte)(-125));
			Res.M1513("byte lent = " + t.Length);
			t2.M888().M1127(t.Length);
			for (int i = 0; i < t.Length; i++)
			{
				t2.M888().M1140(t[i].M1924());
			}
			session.sendMessage(t2);
		}
		catch (Exception)
		{
		}
		finally
		{
			t2.M890();
		}
	}

	public void M1603(sbyte index)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)112);
			t.M888().M1126(index);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1604(short x, short y)
	{
		Res.M1513("gui x= " + x + " y= " + y);
		Message t = null;
		try
		{
			t = new Message(0);
			t.M888().M1132(x);
			t.M888().M1132(y);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1605()
	{
		Res.M1513("gui test1");
		Message t = null;
		try
		{
			t = new Message(1);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1606()
	{
	}

	public void M1607(char ch)
	{
		Res.M1513("cap char c= " + ch);
		Message t = null;
		try
		{
			t = new Message((sbyte)(-85));
			t.M888().M1128(ch);
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1608(sbyte action, int playerId)
	{
		Res.M1513("add friend");
		Message t = null;
		try
		{
			t = new Message((sbyte)(-80));
			t.M888().M1126(action);
			if (playerId != -1)
			{
				t.M888().M1135(playerId);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1609(int index)
	{
		Res.M1513("get ngoc");
		Message t = null;
		try
		{
			t = new Message((sbyte)(-76));
			t.M888().M1127(index);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1610(int playerID)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-79));
			t.M888().M1135(playerID);
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1611(sbyte id)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-62));
			t.M888().M1126(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1612(sbyte status)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-45));
			t.M888().M1126(status);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1613(int id)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-54));
			t.M888().M1135(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1614(int type, string text, int clanID)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-51));
			t.M888().M1127(type);
			if (type == 0)
			{
				t.M888().M1140(text);
			}
			if (type == 2)
			{
				t.M888().M1135(clanID);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1615(sbyte type, sbyte where, sbyte index, short template)
	{
		Cout.M326("USE ITEM! " + type);
		if (Char.M113().statusMe == 14)
		{
			return;
		}
		Message t = null;
		try
		{
			t = new Message((sbyte)(-43));
			t.M888().M1126(type);
			t.M888().M1126(where);
			t.M888().M1126(index);
			if (index == -1)
			{
				t.M888().M1132(template);
			}
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1616(int id, sbyte action)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-49));
			t.M888().M1135(id);
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1617(int id)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-50));
			t.M888().M1135(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1618(string text)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-47));
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1619(short id)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-53));
			t.M888().M1132(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1620(int id, sbyte role)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-56));
			t.M888().M1135(id);
			t.M888().M1126(role);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1621()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-55));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1622(sbyte action, int playerID, int clanID, int code)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-57));
			t.M888().M1126(action);
			if (action == 0)
			{
				t.M888().M1135(playerID);
			}
			if (action == 1 || action == 2)
			{
				t.M888().M1135(clanID);
				t.M888().M1135(code);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1623(sbyte action, sbyte id, string text)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-46));
			t.M888().M1126(action);
			if (action == 2 || action == 4)
			{
				t.M888().M1126(id);
				t.M888().M1140(text);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1624(sbyte gender)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-41));
			t.M888().M1126(gender);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1625(sbyte type, sbyte id)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-40));
			t.M888().M1126(type);
			t.M888().M1126(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1626(int npcTemplateId, int menuId, int optionId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)40);
			t.M888().M1127(npcTemplateId);
			t.M888().M1127(menuId);
			if (optionId >= 0)
			{
				t.M888().M1127(optionId);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public Message M1627(sbyte command)
	{
		Message t = new Message((sbyte)(-29));
		t.M888().M1126(command);
		return t;
	}

	public Message M1628(sbyte command)
	{
		Message t = new Message((sbyte)(-28));
		t.M888().M1126(command);
		return t;
	}

	public static Message M1629(sbyte command)
	{
		Message t = new Message((sbyte)(-30));
		t.M888().M1126(command);
		return t;
	}

	public void M1630()
	{
		if (Rms.M1542("clienttype") != -1)
		{
			Main.typeClient = Rms.M1542("clienttype");
		}
		try
		{
			Message t = M1627(2);
			t.M888().M1127(Main.typeClient);
			t.M888().M1127(mGraphics.zoomLevel);
			t.M888().M1137(value: false);
			t.M888().M1135(GameCanvas.w);
			t.M888().M1135(GameCanvas.h);
			t.M888().M1137(TField.isQwerty);
			t.M888().M1137(GameCanvas.isTouch);
			t.M888().M1140(GameCanvas.M440() + "|" + GameMidlet.VERSION);
			session.sendMessage(t);
			t.M890();
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
	}

	public void M1631()
	{
		Res.M1513("SET CLIENT TYPE");
		if (Rms.M1542("clienttype") != -1)
		{
			mSystem.clientType = Rms.M1542("clienttype");
		}
		try
		{
			Res.M1513("setType");
			Message t = M1627(2);
			t.M888().M1127(mSystem.clientType);
			t.M888().M1127(mGraphics.zoomLevel);
			Res.M1513("gui zoomlevel = " + mGraphics.zoomLevel);
			t.M888().M1137(value: false);
			t.M888().M1135(GameCanvas.w);
			t.M888().M1135(GameCanvas.h);
			t.M888().M1137(TField.isQwerty);
			t.M888().M1137(GameCanvas.isTouch);
			t.M888().M1140(GameCanvas.M440() + "|" + GameMidlet.VERSION);
			session = Session_ME2.M1757();
			session.sendMessage(t);
			session = Session_ME.M1744();
			t.M890();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
	}

	public void M1632()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-120));
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			curCheckController = mSystem.M1054();
			t.M890();
		}
	}

	public void M1633()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-121));
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			curCheckMap = mSystem.M1054();
			t.M890();
		}
	}

	public void M1634(string username, string pass, string version, sbyte type)
	{
		try
		{
			Message t = M1627(0);
			if (!GameAutomationHub.account.Equals(""))
			{
				t.M888().M1140(GameAutomationHub.account);
				t.M888().M1140(GameAutomationHub.password);
			}
			else
			{
				t.M888().M1140(username);
				t.M888().M1140(pass);
			}
			t.M888().M1140(version);
			t.M888().M1126(type);
			session.sendMessage(t);
			t.M890();
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
	}

	public void M1635(string username, string pass, string usernameAo, string passAo, string version)
	{
		try
		{
			Message t = M1627(1);
			t.M888().M1140(username);
			t.M888().M1140(pass);
			if (usernameAo != null && !usernameAo.Equals(string.Empty))
			{
				t.M888().M1140(usernameAo);
				t.M888().M1140("a");
			}
			session.sendMessage(t);
			t.M890();
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
	}

	public void M1636()
	{
		Message t = new Message((sbyte)(-23));
		session.sendMessage(t);
		t.M890();
	}

	public void M1637(sbyte type)
	{
		Message t = new Message((sbyte)(-34));
		try
		{
			t.M888().M1126(type);
			session.sendMessage(t);
			t.M890();
		}
		catch (Exception)
		{
		}
	}

	public void M1638(int zoneId, int indexUI)
	{
		Message t = new Message((sbyte)21);
		try
		{
			t.M888().M1127(zoneId);
			session.sendMessage(t);
			t.M890();
		}
		catch (Exception)
		{
		}
	}

	public void M1639(int second)
	{
		Message t = new Message((sbyte)(-78));
		try
		{
			t.M888().M1135(second);
			session.sendMessage(t);
			t.M890();
		}
		catch (Exception)
		{
		}
	}

	public void M1640()
	{
		int num = Char.M113().cx - Char.M113().cxSend;
		int num2 = Char.M113().cy - Char.M113().cySend;
		if (Char.ischangingMap || (num == 0 && num2 == 0) || Controller.isStopReadMessage || Char.M113().isTeleport || Char.M113().cy <= 0 || Char.M113().telePortSkill)
		{
			return;
		}
		try
		{
			Message t = new Message((sbyte)(-7));
			Char.M113().cxSend = Char.M113().cx;
			Char.M113().cySend = Char.M113().cy;
			Char.M113().cdirSend = Char.M113().cdir;
			Char.M113().cactFirst = Char.M113().statusMe;
			if (TileMap.M1956(Char.M113().cx / TileMap.size, Char.M113().cy / TileMap.size) == 0)
			{
				t.M888().M1126(1);
				if (Char.M113().canFly)
				{
					if (!Char.M113().isHaveMount)
					{
						Char.M113().cMP -= Char.M113().cMPGoc / 100 * ((Char.M113().isMonkey != 1) ? 1 : 2);
					}
					if (Char.M113().cMP < 0)
					{
						Char.M113().cMP = 0;
					}
					GameScr.M559().isInjureMp = true;
					GameScr.M559().twMp = 0;
				}
			}
			else
			{
				t.M888().M1126(0);
			}
			t.M888().M1133(Char.M113().cx);
			if (num2 != 0)
			{
				t.M888().M1133(Char.M113().cy);
			}
			session.sendMessage(t);
			GameScr.tickMove++;
			t.M890();
		}
		catch (Exception ex)
		{
			Cout.M328("LOI CHAR MOVE " + ex.ToString());
		}
	}

	public void M1641(string charname)
	{
		Message t = new Message((sbyte)(-28));
		try
		{
			t.M888().M1126(1);
			t.M888().M1140(charname);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		session.sendMessage(t);
	}

	public void M1642(sbyte sub, int value)
	{
	}

	public void M1643(string name, int gender, int hair)
	{
		Message t = new Message((sbyte)(-28));
		try
		{
			t.M888().M1126(2);
			t.M888().M1140(name);
			t.M888().M1127(gender);
			t.M888().M1127(hair);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		session.sendMessage(t);
	}

	public void M1644(int modTemplateId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)11);
			t.M888().M1127(modTemplateId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1645(int npcTemplateId)
	{
		Message t = null;
		try
		{
			t = M1628(12);
			t.M888().M1127(npcTemplateId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1646(int skillId)
	{
		Message t = null;
		try
		{
			t = M1628(9);
			t.M888().M1133(skillId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1647(int typeUI, int indexUI)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)35);
			t.M888().M1127(typeUI);
			t.M888().M1127(indexUI);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1648(int charId, int indexUI)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)90);
			t.M888().M1135(charId);
			t.M888().M1127(indexUI);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1649(int skillTemplateId, int point)
	{
		Message t = null;
		try
		{
			t = M1629(17);
			t.M888().M1133(skillTemplateId);
			t.M888().M1127(point);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1650(sbyte action, sbyte type, short id)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)7);
			t.M888().M1126(action);
			t.M888().M1126(type);
			t.M888().M1132(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1651(sbyte type, int id, int quantity)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)6);
			t.M888().M1126(type);
			t.M888().M1133(id);
			if (quantity > 1)
			{
				t.M888().M1133(quantity);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1652(int skillTemplateId)
	{
		Cout.M326(Char.M113().cName + " SELECT SKILL " + skillTemplateId);
		Message t = null;
		try
		{
			t = new Message((sbyte)34);
			t.M888().M1133(skillTemplateId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1653(short id)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-66));
			t.M888().M1132(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1654()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)29);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1655(short npcID, sbyte select)
	{
		Res.M1513("confirme menu" + select);
		Message t = null;
		try
		{
			t = new Message((sbyte)32);
			t.M888().M1132(npcID);
			t.M888().M1126(select);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1656(int npcId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)33);
			t.M888().M1133(npcId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1657(int npcId, int menuId, int optionId)
	{
		Cout.M326("menuid: " + menuId);
		Message t = null;
		try
		{
			t = new Message((sbyte)22);
			t.M888().M1127(npcId);
			t.M888().M1127(menuId);
			t.M888().M1127(optionId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1658(short menuId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)27);
			t.M888().M1132(menuId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1659(short menuId, string str)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)88);
			t.M888().M1132(menuId);
			t.M888().M1140(str);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1660(int typeUI)
	{
		Message t = null;
		try
		{
			t = M1629(22);
			t.M888().M1127(typeUI);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1661()
	{
		Message t = null;
		try
		{
			t = M1629(19);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1662(int coinOut)
	{
		Message t = null;
		try
		{
			t = M1629(21);
			t.M888().M1135(coinOut);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1663(Item item, Item[] items, bool isGold)
	{
		GameCanvas.msgdlg.M1035();
		Message t = null;
		try
		{
			t = new Message((sbyte)14);
			t.M888().M1137(isGold);
			t.M888().M1127(item.indexUI);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
				{
					t.M888().M1127(items[i].indexUI);
				}
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1664(Item[] items)
	{
		GameCanvas.msgdlg.M1035();
		Message t = null;
		try
		{
			t = new Message((sbyte)13);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
				{
					t.M888().M1127(items[i].indexUI);
				}
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1665(int playerMapId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)37);
			t.M888().M1135(playerMapId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1666()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)50);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1667()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)39);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1668(int coin, Item[] items)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)38);
			t.M888().M1135(coin);
			int num = 0;
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
				{
					num++;
				}
			}
			t.M888().M1127(num);
			for (int j = 0; j < items.Length; j++)
			{
				if (items[j] != null)
				{
					t.M888().M1127(items[j].indexUI);
				}
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1669(MyVector vMob, MyVector vChar, int type)
	{
		try
		{
			Message t = null;
			if (type == 0)
			{
				return;
			}
			if (vMob.M1113() > 0 && vChar.M1113() > 0)
			{
				switch (type)
				{
				case 2:
					t = new Message((sbyte)67);
					break;
				case 1:
					t = new Message((sbyte)(-4));
					break;
				}
				t.M888().M1127(vMob.M1113());
				for (int i = 0; i < vMob.M1113(); i++)
				{
					Mob t2 = (Mob)vMob.M1114(i);
					t.M888().M1127(t2.mobId);
				}
				for (int j = 0; j < vChar.M1113(); j++)
				{
					Char t3 = (Char)vChar.M1114(j);
					if (t3 != null)
					{
						t.M888().M1135(t3.charID);
					}
					else
					{
						t.M888().M1135(-1);
					}
				}
			}
			else if (vMob.M1113() > 0)
			{
				t = new Message((sbyte)54);
				for (int k = 0; k < vMob.M1113(); k++)
				{
					Mob t4 = (Mob)vMob.M1114(k);
					if (!t4.isMobMe)
					{
						t.M888().M1127(t4.mobId);
						continue;
					}
					t.M888().M1126(-1);
					t.M888().M1135(t4.mobId);
				}
			}
			else if (vChar.M1113() > 0)
			{
				t = new Message((sbyte)(-60));
				for (int l = 0; l < vChar.M1113(); l++)
				{
					Char t5 = (Char)vChar.M1114(l);
					t.M888().M1135(t5.charID);
				}
			}
			if (t != null)
			{
				session.sendMessage(t);
			}
		}
		catch (Exception)
		{
		}
	}

	public void M1670(int itemMapId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-20));
			t.M888().M1133(itemMapId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1671(int index)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-18));
			t.M888().M1127(index);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1672()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-15));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1673()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-16));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1674(string text)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)44);
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1675()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-87));
			if (Session_ME2.M1757().isConnected() && !Session_ME2.connecting)
			{
				session = Session_ME2.M1757();
			}
			else
			{
				session = Session_ME.M1744();
			}
			session.sendMessage(t);
			session = Session_ME.M1744();
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1676()
	{
		Message t = null;
		try
		{
			t = M1628(6);
			if (Session_ME2.M1757().isConnected() && !Session_ME2.connecting)
			{
				session = Session_ME2.M1757();
			}
			else
			{
				session = Session_ME.M1744();
			}
			session.sendMessage(t);
			session = Session_ME.M1744();
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1677()
	{
		Message t = null;
		try
		{
			t = M1628(7);
			if (Session_ME2.M1757().isConnected() && !Session_ME2.connecting)
			{
				session = Session_ME2.M1757();
			}
			else
			{
				session = Session_ME.M1744();
			}
			session.sendMessage(t);
			session = Session_ME.M1744();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1678()
	{
		Message t = null;
		try
		{
			t = M1628(8);
			if (Session_ME2.M1757().isConnected() && !Session_ME2.connecting)
			{
				session = Session_ME2.M1757();
			}
			else
			{
				session = Session_ME.M1744();
			}
			session.sendMessage(t);
			session = Session_ME.M1744();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1679()
	{
		Message t = null;
		try
		{
			t = M1628(13);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1680(int charId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)36);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1681(string name)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)53);
			t.M888().M1140(name);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1682(int charId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)76);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1683(int charId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)77);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1684(int charId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)59);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1685(int charId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)62);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1686(string name)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)75);
			t.M888().M1140(name);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1687(sbyte action, sbyte type, int playerId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-59));
			t.M888().M1126(action);
			t.M888().M1126(type);
			t.M888().M1135(playerId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1688(int maptemplateId)
	{
		Message t = null;
		try
		{
			t = M1628(10);
			t.M888().M1127(maptemplateId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1689()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)79);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1690(MyVector chars)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)18);
			t.M888().M1127(chars.M1113());
			for (int i = 0; i < chars.M1113(); i++)
			{
				Char t2 = (Char)chars.M1114(i);
				t.M888().M1135(t2.charID);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1691(string str)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)16);
			t.M888().M1140(str);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1692(string str)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)17);
			t.M888().M1140(str);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1693(string text, int id)
	{
		Res.M1513("chat player text = " + text);
		Message t = null;
		try
		{
			t = new Message((sbyte)(-72));
			t.M888().M1135(id);
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1694(string text)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-71));
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1695(string to, string text)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)91);
			t.M888().M1140(to);
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1696(string NAP, string PIN)
	{
		Message t = null;
		try
		{
			t = M1628(16);
			t.M888().M1140(NAP);
			t.M888().M1140(PIN);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1697(string key, sbyte[] data)
	{
		Message t = null;
		try
		{
			t = M1629(60);
			t.M888().M1140(key);
			t.M888().M1135(data.Length);
			t.M888().M1143(data);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1698(string key)
	{
		Cout.M326("REQUEST RMS");
		Message t = null;
		try
		{
			t = M1629(61);
			t.M888().M1140(key);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1699()
	{
		Message t = null;
		try
		{
			t = M1628(17);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1700(string name, int id)
	{
		Message t = null;
		try
		{
			t = M1628(18);
			t.M888().M1135(id);
			t.M888().M1140(name);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1701(int id)
	{
		GameCanvas.M449();
		Message t = null;
		try
		{
			Res.M1513("REQUEST ICON " + id);
			t = new Message((sbyte)(-67));
			t.M888().M1135(id);
			if (Session_ME2.M1757().isConnected() && !Session_ME2.connecting)
			{
				session = Session_ME2.M1757();
			}
			else
			{
				session = Session_ME.M1744();
			}
			session.sendMessage(t);
			session = Session_ME.M1744();
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1702(int index1, int index2, int index3)
	{
		Message t = null;
		try
		{
			t = M1628(33);
			t.M888().M1127(index1);
			t.M888().M1127(index2);
			t.M888().M1127(index3);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1703(string name)
	{
		Message t = null;
		try
		{
			t = M1628(34);
			t.M888().M1140(name);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1704(int indexItem, int numSplit)
	{
		Message t = null;
		try
		{
			t = M1628(40);
			t.M888().M1127(indexItem);
			t.M888().M1135(numSplit);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1705(int pass)
	{
		Message t = null;
		try
		{
			t = M1628(37);
			t.M888().M1135(pass);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1706(int pass)
	{
		Message t = null;
		try
		{
			t = M1628(41);
			t.M888().M1135(pass);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1707(int passOld, int passNew)
	{
		Message t = null;
		try
		{
			t = M1628(38);
			t.M888().M1135(passOld);
			t.M888().M1135(passNew);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1708(int pass2)
	{
		Message t = null;
		try
		{
			t = M1628(39);
			t.M888().M1135(pass2);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1709(short id)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-32));
			t.M888().M1132(id);
			if (Session_ME2.M1757().isConnected() && !Session_ME2.connecting)
			{
				session = Session_ME2.M1757();
			}
			else
			{
				session = Session_ME.M1744();
			}
			session.sendMessage(t);
			session = Session_ME.M1744();
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1710()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-33));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1711()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-38));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1712()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-39));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1713(sbyte action)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-35));
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1714(sbyte ID)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-63));
			t.M888().M1126(ID);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1715(sbyte action)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-36));
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1716(sbyte action)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-37));
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1717(string user)
	{
		Res.M1513("Login 2");
		Message t = null;
		try
		{
			t = new Message((sbyte)(-101));
			t.M888().M1140(user);
			t.M888().M1127(1);
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1718(sbyte action)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-34));
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1719(int typePotential, int num)
	{
		Message t = null;
		try
		{
			t = M1629(16);
			t.M888().M1127(typePotential);
			t.M888().M1133(num);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1720(sbyte action, MyVector vResourceIndex)
	{
		Res.M1513("request resource action= " + action);
		Message t = null;
		try
		{
			t = new Message((sbyte)(-74));
			t.M888().M1126(action);
			if (action == 2 && vResourceIndex != null)
			{
				t.M888().M1133(vResourceIndex.M1113());
				for (int i = 0; i < vResourceIndex.M1113(); i++)
				{
					t.M888().M1132(short.Parse((string)vResourceIndex.M1114(i)));
				}
			}
			if (Session_ME2.M1757().isConnected() && !Session_ME2.connecting)
			{
				session = Session_ME2.M1757();
			}
			else
			{
				reciveFromMainSession = true;
				session = Session_ME.M1744();
			}
			session.sendMessage(t);
			session = Session_ME.M1744();
		}
		catch (Exception ex)
		{
			Cout.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1721(int selected)
	{
		Res.M1513("request magic tree");
		Message t = null;
		try
		{
			t = new Message((sbyte)(-91));
			t.M888().M1127(selected);
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1722()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-107));
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1723(string topName, sbyte selected)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-96));
			t.M888().M1140(topName);
			t.M888().M1126(selected);
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1724(sbyte b, int charID)
	{
		Message t = null;
		Res.M1513("add enemy");
		try
		{
			t = new Message((sbyte)(-99));
			t.M888().M1126(b);
			if (b == 1 || b == 2)
			{
				t.M888().M1135(charID);
			}
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1725(sbyte action, int itemId, sbyte moneyType, int money, int quaintly)
	{
		Message t = null;
		try
		{
			Res.M1513("ki gui action= " + action);
			t = new Message((sbyte)(-100));
			t.M888().M1126(action);
			if (action == 0)
			{
				t.M888().M1133(itemId);
				t.M888().M1126(moneyType);
				t.M888().M1135(money);
				t.M888().M1135(quaintly);
			}
			if (action == 1 || action == 2)
			{
				t.M888().M1133(itemId);
			}
			if (action == 3)
			{
				t.M888().M1133(itemId);
				t.M888().M1126(moneyType);
				t.M888().M1135(money);
			}
			if (action == 4)
			{
				t.M888().M1126(moneyType);
				t.M888().M1127(money);
				Res.M1513("currTab= " + moneyType + " page= " + money);
			}
			if (action == 5)
			{
				t.M888().M1133(itemId);
			}
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1726(sbyte action, sbyte flagType)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-103));
			t.M888().M1126(action);
			Res.M1513("------------service--  " + action + "   " + flagType);
			if (action != 0)
			{
				t.M888().M1126(flagType);
			}
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1727(int pass)
	{
		Message t = null;
		try
		{
			Res.M1513("------------setLockInventory:     " + pass);
			t = new Message((sbyte)(-104));
			t.M888().M1135(pass);
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1728(sbyte status)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-108));
			t.M888().M1126(status);
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1729()
	{
		Message t = null;
		try
		{
			Res.M1513("------------transportNow  ");
			t = new Message((sbyte)(-105));
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1730(sbyte type)
	{
		Message t = null;
		try
		{
			Res.M1513("FUNSION");
			t = new Message((sbyte)125);
			t.M888().M1126(type);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1731(MyVector vID)
	{
		Message t = null;
		try
		{
			Res.M1513("IMAGE SOURCE size= " + vID.M1113());
			t = new Message((sbyte)(-111));
			t.M888().M1133(vID.M1113());
			if (vID.M1113() > 0)
			{
				for (int i = 0; i < vID.M1113(); i++)
				{
					Res.M1513("gui len str " + ((ImageSource)vID.M1114(i)).id);
					t.M888().M1140(((ImageSource)vID.M1114(i)).id);
				}
			}
			if (Session_ME2.M1757().isConnected() && !Session_ME2.connecting)
			{
				session = Session_ME2.M1757();
			}
			else
			{
				session = Session_ME.M1744();
				reciveFromMainSession = true;
			}
			session.sendMessage(t);
			session = Session_ME.M1744();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1732()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-126));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1733(sbyte action, int id, sbyte[] data)
	{
		Message t = null;
		try
		{
			Res.M1513("SERVER DATA");
			t = new Message((sbyte)(-110));
			t.M888().M1126(action);
			if (action == 1)
			{
				t.M888().M1135(id);
				if (data != null)
				{
					int num = data.Length;
					t.M888().M1133(num);
					t.M888().M1142(ref data, 0, num);
				}
			}
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1734(sbyte[] skill)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-113));
			for (int i = 0; i < GameScr.onScreenSkill.Length; i++)
			{
				t.M888().M1126(skill[i]);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1735()
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-114));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1736(int id)
	{
		Res.M1513("GUI THACH DAU");
		Message t = null;
		try
		{
			t = new Message((sbyte)(-118));
			t.M888().M1135(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1737(int charId)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-30));
			t.M888().M1126(63);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1738(int charId, short select)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)(-30));
			t.M888().M1126(64);
			t.M888().M1135(charId);
			t.M888().M1132(select);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			t.M890();
		}
	}

	public void M1739(string nameImg)
	{
		Message t = null;
		try
		{
			t = new Message((sbyte)66);
			t.M888().M1140(nameImg);
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1740(byte type, byte soluong)
	{
		Message t = new Message((sbyte)(-127));
		try
		{
			t.M888().M1127(type);
			if (soluong > 0)
			{
				t.M888().M1127(soluong);
			}
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1741(int i, int id)
	{
		Message t = new Message(sbyte.MaxValue);
		try
		{
			t.M888().M1127(i);
			if (id != -1)
			{
				t.M888().M1133(id);
			}
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}

	public void M1742()
	{
		Message t = new Message((sbyte)24);
		try
		{
			t.M888().M1127(0);
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			t.M890();
		}
	}
}
