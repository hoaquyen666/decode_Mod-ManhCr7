using System;
using N3.N4;
using N5.N6.N7;

public class T146
{
	private T78 session = T147.M1744();

	protected static T146 instance;

	public static long curCheckController;

	public static long curCheckMap;

	public static long logController;

	public static long logMap;

	public int demGui;

	public static bool reciveFromMainSession;

	public static T146 M1594()
	{
		if (instance == null)
		{
			instance = new T146();
		}
		return instance;
	}

	public void M1595(int id)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)18);
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
		if (T110.android_pack == null)
		{
			return;
		}
		T97 t = null;
		try
		{
			t = new T97((sbyte)126);
			t.M888().M1140(T110.android_pack);
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)42);
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
		if (T110.android_pack == null)
		{
			return;
		}
		T97 t = null;
		try
		{
			t = new T97((sbyte)126);
			t.M888().M1140(T110.android_pack);
			if (T148.M1757().isConnected() && !T148.connecting)
			{
				session = T148.M1757();
			}
			else
			{
				session = T147.M1744();
			}
			session.sendMessage(t);
			session = T147.M1744();
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-44));
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

	public void M1600(sbyte action, T117 id)
	{
		T137.M1513("combine");
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-81));
			t.M888().M1126(action);
			if (action == 1)
			{
				t.M888().M1127(id.M1113());
				for (int i = 0; i < id.M1113(); i++)
				{
					t.M888().M1127(((T79)id.M1114(i)).indexUI);
					T137.M1513("gui id " + ((T79)id.M1114(i)).indexUI);
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
		T137.M1514("giao dich action = " + action);
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-86));
			t.M888().M1126(action);
			if (action == 0 || action == 1)
			{
				T137.M1514(">>>> len playerID =" + playerID);
				t.M888().M1135(playerID);
			}
			if (action == 2)
			{
				T137.M1514("gui len index =" + index + " num= " + num);
				t.M888().M1126(index);
				t.M888().M1135(num);
			}
			if (action == 4)
			{
				T137.M1514(">>>> len index =" + index);
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

	public void M1602(T173[] t)
	{
		T97 t2 = null;
		try
		{
			T137.M1513(" gui input ");
			t2 = new T97((sbyte)(-125));
			T137.M1513("byte lent = " + t.Length);
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)112);
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
		T137.M1513("gui x= " + x + " y= " + y);
		T97 t = null;
		try
		{
			t = new T97(0);
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
		T137.M1513("gui test1");
		T97 t = null;
		try
		{
			t = new T97(1);
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
		T137.M1513("cap char c= " + ch);
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-85));
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
		T137.M1513("add friend");
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-80));
			t.M888().M1126(action);
			if (playerId != -1)
			{
				t.M888().M1135(playerId);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1609(int index)
	{
		T137.M1513("get ngoc");
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-76));
			t.M888().M1127(index);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1610(int playerID)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-79));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-62));
			t.M888().M1126(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1612(sbyte status)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-45));
			t.M888().M1126(status);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1613(int id)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-54));
			t.M888().M1135(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1614(int type, string text, int clanID)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-51));
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1615(sbyte type, sbyte where, sbyte index, short template)
	{
		T24.M326("USE ITEM! " + type);
		if (T13.M113().statusMe == 14)
		{
			return;
		}
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-43));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-49));
			t.M888().M1135(id);
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1617(int id)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-50));
			t.M888().M1135(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1618(string text)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-47));
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1619(short id)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-53));
			t.M888().M1132(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1620(int id, sbyte role)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-56));
			t.M888().M1135(id);
			t.M888().M1126(role);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1621()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-55));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1622(sbyte action, int playerID, int clanID, int code)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-57));
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1623(sbyte action, sbyte id, string text)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-46));
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1624(sbyte gender)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-41));
			t.M888().M1126(gender);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1625(sbyte type, sbyte id)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-40));
			t.M888().M1126(type);
			t.M888().M1126(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1626(int npcTemplateId, int menuId, int optionId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)40);
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public T97 M1627(sbyte command)
	{
		T97 t = new T97((sbyte)(-29));
		t.M888().M1126(command);
		return t;
	}

	public T97 M1628(sbyte command)
	{
		T97 t = new T97((sbyte)(-28));
		t.M888().M1126(command);
		return t;
	}

	public static T97 M1629(sbyte command)
	{
		T97 t = new T97((sbyte)(-30));
		t.M888().M1126(command);
		return t;
	}

	public void M1630()
	{
		if (T138.M1542("clienttype") != -1)
		{
			Main.typeClient = T138.M1542("clienttype");
		}
		try
		{
			T97 t = M1627(2);
			t.M888().M1127(Main.typeClient);
			t.M888().M1127(T99.zoomLevel);
			t.M888().M1137(value: false);
			t.M888().M1135(T51.w);
			t.M888().M1135(T51.h);
			t.M888().M1137(T173.isQwerty);
			t.M888().M1137(T51.isTouch);
			t.M888().M1140(T51.M440() + "|" + T52.VERSION);
			session.sendMessage(t);
			t.M890();
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
	}

	public void M1631()
	{
		T137.M1513("SET CLIENT TYPE");
		if (T138.M1542("clienttype") != -1)
		{
			T110.clientType = T138.M1542("clienttype");
		}
		try
		{
			T137.M1513("setType");
			T97 t = M1627(2);
			t.M888().M1127(T110.clientType);
			t.M888().M1127(T99.zoomLevel);
			T137.M1513("gui zoomlevel = " + T99.zoomLevel);
			t.M888().M1137(value: false);
			t.M888().M1135(T51.w);
			t.M888().M1135(T51.h);
			t.M888().M1137(T173.isQwerty);
			t.M888().M1137(T51.isTouch);
			t.M888().M1140(T51.M440() + "|" + T52.VERSION);
			session = T148.M1757();
			session.sendMessage(t);
			session = T147.M1744();
			t.M890();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
	}

	public void M1632()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-120));
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			curCheckController = T110.M1054();
			t.M890();
		}
	}

	public void M1633()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-121));
			session.sendMessage(t);
		}
		catch (Exception)
		{
		}
		finally
		{
			curCheckMap = T110.M1054();
			t.M890();
		}
	}

	public void M1634(string username, string pass, string version, sbyte type)
	{
		try
		{
			T97 t = M1627(0);
			if (!T200.account.Equals(""))
			{
				t.M888().M1140(T200.account);
				t.M888().M1140(T200.password);
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
			T24.M326(ex.Message + ex.StackTrace);
		}
	}

	public void M1635(string username, string pass, string usernameAo, string passAo, string version)
	{
		try
		{
			T97 t = M1627(1);
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
			T24.M326(ex.Message + ex.StackTrace);
		}
	}

	public void M1636()
	{
		T97 t = new T97((sbyte)(-23));
		session.sendMessage(t);
		t.M890();
	}

	public void M1637(sbyte type)
	{
		T97 t = new T97((sbyte)(-34));
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
		T97 t = new T97((sbyte)21);
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
		T97 t = new T97((sbyte)(-78));
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
		int num = T13.M113().cx - T13.M113().cxSend;
		int num2 = T13.M113().cy - T13.M113().cySend;
		if (T13.ischangingMap || (num == 0 && num2 == 0) || T23.isStopReadMessage || T13.M113().isTeleport || T13.M113().cy <= 0 || T13.M113().telePortSkill)
		{
			return;
		}
		try
		{
			T97 t = new T97((sbyte)(-7));
			T13.M113().cxSend = T13.M113().cx;
			T13.M113().cySend = T13.M113().cy;
			T13.M113().cdirSend = T13.M113().cdir;
			T13.M113().cactFirst = T13.M113().statusMe;
			if (T174.M1956(T13.M113().cx / T174.size, T13.M113().cy / T174.size) == 0)
			{
				t.M888().M1126(1);
				if (T13.M113().canFly)
				{
					if (!T13.M113().isHaveMount)
					{
						T13.M113().cMP -= T13.M113().cMPGoc / 100 * ((T13.M113().isMonkey != 1) ? 1 : 2);
					}
					if (T13.M113().cMP < 0)
					{
						T13.M113().cMP = 0;
					}
					T54.M559().isInjureMp = true;
					T54.M559().twMp = 0;
				}
			}
			else
			{
				t.M888().M1126(0);
			}
			t.M888().M1133(T13.M113().cx);
			if (num2 != 0)
			{
				t.M888().M1133(T13.M113().cy);
			}
			session.sendMessage(t);
			T54.tickMove++;
			t.M890();
		}
		catch (Exception ex)
		{
			T24.M328("LOI CHAR MOVE " + ex.ToString());
		}
	}

	public void M1641(string charname)
	{
		T97 t = new T97((sbyte)(-28));
		try
		{
			t.M888().M1126(1);
			t.M888().M1140(charname);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		session.sendMessage(t);
	}

	public void M1642(sbyte sub, int value)
	{
	}

	public void M1643(string name, int gender, int hair)
	{
		T97 t = new T97((sbyte)(-28));
		try
		{
			t.M888().M1126(2);
			t.M888().M1140(name);
			t.M888().M1127(gender);
			t.M888().M1127(hair);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		session.sendMessage(t);
	}

	public void M1644(int modTemplateId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)11);
			t.M888().M1127(modTemplateId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1645(int npcTemplateId)
	{
		T97 t = null;
		try
		{
			t = M1628(12);
			t.M888().M1127(npcTemplateId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1646(int skillId)
	{
		T97 t = null;
		try
		{
			t = M1628(9);
			t.M888().M1133(skillId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1647(int typeUI, int indexUI)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)35);
			t.M888().M1127(typeUI);
			t.M888().M1127(indexUI);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1648(int charId, int indexUI)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)90);
			t.M888().M1135(charId);
			t.M888().M1127(indexUI);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1649(int skillTemplateId, int point)
	{
		T97 t = null;
		try
		{
			t = M1629(17);
			t.M888().M1133(skillTemplateId);
			t.M888().M1127(point);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1650(sbyte action, sbyte type, short id)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)7);
			t.M888().M1126(action);
			t.M888().M1126(type);
			t.M888().M1132(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1651(sbyte type, int id, int quantity)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)6);
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1652(int skillTemplateId)
	{
		T24.M326(T13.M113().cName + " SELECT SKILL " + skillTemplateId);
		T97 t = null;
		try
		{
			t = new T97((sbyte)34);
			t.M888().M1133(skillTemplateId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1653(short id)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-66));
			t.M888().M1132(id);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1654()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)29);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1655(short npcID, sbyte select)
	{
		T137.M1513("confirme menu" + select);
		T97 t = null;
		try
		{
			t = new T97((sbyte)32);
			t.M888().M1132(npcID);
			t.M888().M1126(select);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1656(int npcId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)33);
			t.M888().M1133(npcId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1657(int npcId, int menuId, int optionId)
	{
		T24.M326("menuid: " + menuId);
		T97 t = null;
		try
		{
			t = new T97((sbyte)22);
			t.M888().M1127(npcId);
			t.M888().M1127(menuId);
			t.M888().M1127(optionId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1658(short menuId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)27);
			t.M888().M1132(menuId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1659(short menuId, string str)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)88);
			t.M888().M1132(menuId);
			t.M888().M1140(str);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1660(int typeUI)
	{
		T97 t = null;
		try
		{
			t = M1629(22);
			t.M888().M1127(typeUI);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1661()
	{
		T97 t = null;
		try
		{
			t = M1629(19);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1662(int coinOut)
	{
		T97 t = null;
		try
		{
			t = M1629(21);
			t.M888().M1135(coinOut);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1663(T79 item, T79[] items, bool isGold)
	{
		T51.msgdlg.M1035();
		T97 t = null;
		try
		{
			t = new T97((sbyte)14);
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1664(T79[] items)
	{
		T51.msgdlg.M1035();
		T97 t = null;
		try
		{
			t = new T97((sbyte)13);
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1665(int playerMapId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)37);
			t.M888().M1135(playerMapId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1666()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)50);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1667()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)39);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1668(int coin, T79[] items)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)38);
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1669(T117 vMob, T117 vChar, int type)
	{
		try
		{
			T97 t = null;
			if (type == 0)
			{
				return;
			}
			if (vMob.M1113() > 0 && vChar.M1113() > 0)
			{
				switch (type)
				{
				case 2:
					t = new T97((sbyte)67);
					break;
				case 1:
					t = new T97((sbyte)(-4));
					break;
				}
				t.M888().M1127(vMob.M1113());
				for (int i = 0; i < vMob.M1113(); i++)
				{
					T101 t2 = (T101)vMob.M1114(i);
					t.M888().M1127(t2.mobId);
				}
				for (int j = 0; j < vChar.M1113(); j++)
				{
					T13 t3 = (T13)vChar.M1114(j);
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
				t = new T97((sbyte)54);
				for (int k = 0; k < vMob.M1113(); k++)
				{
					T101 t4 = (T101)vMob.M1114(k);
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
				t = new T97((sbyte)(-60));
				for (int l = 0; l < vChar.M1113(); l++)
				{
					T13 t5 = (T13)vChar.M1114(l);
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-20));
			t.M888().M1133(itemMapId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1671(int index)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-18));
			t.M888().M1127(index);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1672()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-15));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1673()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-16));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1674(string text)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)44);
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1675()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-87));
			if (T148.M1757().isConnected() && !T148.connecting)
			{
				session = T148.M1757();
			}
			else
			{
				session = T147.M1744();
			}
			session.sendMessage(t);
			session = T147.M1744();
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1676()
	{
		T97 t = null;
		try
		{
			t = M1628(6);
			if (T148.M1757().isConnected() && !T148.connecting)
			{
				session = T148.M1757();
			}
			else
			{
				session = T147.M1744();
			}
			session.sendMessage(t);
			session = T147.M1744();
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1677()
	{
		T97 t = null;
		try
		{
			t = M1628(7);
			if (T148.M1757().isConnected() && !T148.connecting)
			{
				session = T148.M1757();
			}
			else
			{
				session = T147.M1744();
			}
			session.sendMessage(t);
			session = T147.M1744();
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
		T97 t = null;
		try
		{
			t = M1628(8);
			if (T148.M1757().isConnected() && !T148.connecting)
			{
				session = T148.M1757();
			}
			else
			{
				session = T147.M1744();
			}
			session.sendMessage(t);
			session = T147.M1744();
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
		T97 t = null;
		try
		{
			t = M1628(13);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1680(int charId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)36);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1681(string name)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)53);
			t.M888().M1140(name);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1682(int charId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)76);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1683(int charId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)77);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1684(int charId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)59);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1685(int charId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)62);
			t.M888().M1135(charId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1686(string name)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)75);
			t.M888().M1140(name);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1687(sbyte action, sbyte type, int playerId)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-59));
			t.M888().M1126(action);
			t.M888().M1126(type);
			t.M888().M1135(playerId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1688(int maptemplateId)
	{
		T97 t = null;
		try
		{
			t = M1628(10);
			t.M888().M1127(maptemplateId);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1689()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)79);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1690(T117 chars)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)18);
			t.M888().M1127(chars.M1113());
			for (int i = 0; i < chars.M1113(); i++)
			{
				T13 t2 = (T13)chars.M1114(i);
				t.M888().M1135(t2.charID);
			}
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1691(string str)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)16);
			t.M888().M1140(str);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1692(string str)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)17);
			t.M888().M1140(str);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1693(string text, int id)
	{
		T137.M1513("chat player text = " + text);
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-72));
			t.M888().M1135(id);
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1694(string text)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-71));
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1695(string to, string text)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)91);
			t.M888().M1140(to);
			t.M888().M1140(text);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1696(string NAP, string PIN)
	{
		T97 t = null;
		try
		{
			t = M1628(16);
			t.M888().M1140(NAP);
			t.M888().M1140(PIN);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1697(string key, sbyte[] data)
	{
		T97 t = null;
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1698(string key)
	{
		T24.M326("REQUEST RMS");
		T97 t = null;
		try
		{
			t = M1629(61);
			t.M888().M1140(key);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1699()
	{
		T97 t = null;
		try
		{
			t = M1628(17);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1700(string name, int id)
	{
		T97 t = null;
		try
		{
			t = M1628(18);
			t.M888().M1135(id);
			t.M888().M1140(name);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1701(int id)
	{
		T51.M449();
		T97 t = null;
		try
		{
			T137.M1513("REQUEST ICON " + id);
			t = new T97((sbyte)(-67));
			t.M888().M1135(id);
			if (T148.M1757().isConnected() && !T148.connecting)
			{
				session = T148.M1757();
			}
			else
			{
				session = T147.M1744();
			}
			session.sendMessage(t);
			session = T147.M1744();
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1702(int index1, int index2, int index3)
	{
		T97 t = null;
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
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1703(string name)
	{
		T97 t = null;
		try
		{
			t = M1628(34);
			t.M888().M1140(name);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1704(int indexItem, int numSplit)
	{
		T97 t = null;
		try
		{
			t = M1628(40);
			t.M888().M1127(indexItem);
			t.M888().M1135(numSplit);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1705(int pass)
	{
		T97 t = null;
		try
		{
			t = M1628(37);
			t.M888().M1135(pass);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1706(int pass)
	{
		T97 t = null;
		try
		{
			t = M1628(41);
			t.M888().M1135(pass);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1707(int passOld, int passNew)
	{
		T97 t = null;
		try
		{
			t = M1628(38);
			t.M888().M1135(passOld);
			t.M888().M1135(passNew);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1708(int pass2)
	{
		T97 t = null;
		try
		{
			t = M1628(39);
			t.M888().M1135(pass2);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1709(short id)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-32));
			t.M888().M1132(id);
			if (T148.M1757().isConnected() && !T148.connecting)
			{
				session = T148.M1757();
			}
			else
			{
				session = T147.M1744();
			}
			session.sendMessage(t);
			session = T147.M1744();
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1710()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-33));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1711()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-38));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1712()
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-39));
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1713(sbyte action)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-35));
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1714(sbyte ID)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-63));
			t.M888().M1126(ID);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1715(sbyte action)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-36));
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1716(sbyte action)
	{
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-37));
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1717(string user)
	{
		T137.M1513("Login 2");
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-101));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-34));
			t.M888().M1126(action);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1719(int typePotential, int num)
	{
		T97 t = null;
		try
		{
			t = M1629(16);
			t.M888().M1127(typePotential);
			t.M888().M1133(num);
			session.sendMessage(t);
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1720(sbyte action, T117 vResourceIndex)
	{
		T137.M1513("request resource action= " + action);
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-74));
			t.M888().M1126(action);
			if (action == 2 && vResourceIndex != null)
			{
				t.M888().M1133(vResourceIndex.M1113());
				for (int i = 0; i < vResourceIndex.M1113(); i++)
				{
					t.M888().M1132(short.Parse((string)vResourceIndex.M1114(i)));
				}
			}
			if (T148.M1757().isConnected() && !T148.connecting)
			{
				session = T148.M1757();
			}
			else
			{
				reciveFromMainSession = true;
				session = T147.M1744();
			}
			session.sendMessage(t);
			session = T147.M1744();
		}
		catch (Exception ex)
		{
			T24.M326(ex.Message + ex.StackTrace);
		}
		finally
		{
			t.M890();
		}
	}

	public void M1721(int selected)
	{
		T137.M1513("request magic tree");
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-91));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-107));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-96));
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
		T97 t = null;
		T137.M1513("add enemy");
		try
		{
			t = new T97((sbyte)(-99));
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
		T97 t = null;
		try
		{
			T137.M1513("ki gui action= " + action);
			t = new T97((sbyte)(-100));
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
				T137.M1513("currTab= " + moneyType + " page= " + money);
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-103));
			t.M888().M1126(action);
			T137.M1513("------------service--  " + action + "   " + flagType);
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
		T97 t = null;
		try
		{
			T137.M1513("------------setLockInventory:     " + pass);
			t = new T97((sbyte)(-104));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-108));
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
		T97 t = null;
		try
		{
			T137.M1513("------------transportNow  ");
			t = new T97((sbyte)(-105));
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
		T97 t = null;
		try
		{
			T137.M1513("FUNSION");
			t = new T97((sbyte)125);
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

	public void M1731(T117 vID)
	{
		T97 t = null;
		try
		{
			T137.M1513("IMAGE SOURCE size= " + vID.M1113());
			t = new T97((sbyte)(-111));
			t.M888().M1133(vID.M1113());
			if (vID.M1113() > 0)
			{
				for (int i = 0; i < vID.M1113(); i++)
				{
					T137.M1513("gui len str " + ((T205)vID.M1114(i)).id);
					t.M888().M1140(((T205)vID.M1114(i)).id);
				}
			}
			if (T148.M1757().isConnected() && !T148.connecting)
			{
				session = T148.M1757();
			}
			else
			{
				session = T147.M1744();
				reciveFromMainSession = true;
			}
			session.sendMessage(t);
			session = T147.M1744();
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-126));
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
		T97 t = null;
		try
		{
			T137.M1513("SERVER DATA");
			t = new T97((sbyte)(-110));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-113));
			for (int i = 0; i < T54.onScreenSkill.Length; i++)
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-114));
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
		T137.M1513("GUI THACH DAU");
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-118));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-30));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)(-30));
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
		T97 t = null;
		try
		{
			t = new T97((sbyte)66);
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
		T97 t = new T97((sbyte)(-127));
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
		T97 t = new T97(sbyte.MaxValue);
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
		T97 t = new T97((sbyte)24);
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
