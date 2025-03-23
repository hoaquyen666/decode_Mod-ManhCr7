using System;
using N5.N6.N7;
using N5.N6.N8;
using N5.N6.N9;
using UnityEngine;

public class T23 : T63
{
	protected static T23 me;

	protected static T23 me2;

	public T97 messWait;

	public static bool isLoadingData;

	public static bool isConnectOK;

	public static bool isConnectionFail;

	public static bool isDisconnected;

	public static bool isMain;

	private float demCount;

	private int move;

	private int total;

	public static bool isStopReadMessage;

	public static T112 frameHT_NEWBOSS = new T112();

	public const sbyte PHUBAN_TYPE_CHIENTRUONGNAMEK = 0;

	public const sbyte PHUBAN_START = 0;

	public const sbyte PHUBAN_UPDATE_POINT = 1;

	public const sbyte PHUBAN_END = 2;

	public const sbyte PHUBAN_LIFE = 4;

	public const sbyte PHUBAN_INFO = 5;

	public static T23 M300()
	{
		if (me == null)
		{
			me = new T23();
		}
		return me;
	}

	public static T23 M301()
	{
		if (me2 == null)
		{
			me2 = new T23();
		}
		return me2;
	}

	public void onConnectOK(bool isMain1)
	{
		isMain = isMain1;
		T110.M1064();
	}

	public void onConnectionFail(bool isMain1)
	{
		isMain = isMain1;
		T110.M1065();
	}

	public void onDisconnected(bool isMain1)
	{
		isMain = isMain1;
		T110.M1066();
	}

	public void M302(T97 msg)
	{
		try
		{
			byte b = msg.M887().M1091();
			T79 t = T54.currentCharViewInfo.arrItemBody[b];
			t.saleCoinLock = msg.M887().M1094();
			t.sys = msg.M887().M1088();
			t.options = new T117();
			try
			{
				while (true)
				{
					t.options.M1111(new T82(msg.M887().M1091(), msg.M887().M1093()));
				}
			}
			catch (Exception ex)
			{
				T24.M326("Loi tairequestItemPlayer 1" + ex.ToString());
			}
		}
		catch (Exception ex2)
		{
			T24.M326("Loi tairequestItemPlayer 2" + ex2.ToString());
		}
	}

	public void onMessage(T97 msg)
	{
		T51.debugSession.M1120();
		T51.M456("SA1", 2);
		try
		{
			T110.M1039(">>>cmd= " + msg.command);
			T13 t = null;
			T101 t2 = null;
			T117 t3 = new T117();
			int num = 0;
			T209.M2308(msg);
			switch (msg.command)
			{
			case 112:
			{
				sbyte b27 = msg.M887().M1088();
				T137.M1513("spec type= " + b27);
				switch (b27)
				{
				case 1:
				{
					sbyte b28 = msg.M887().M1088();
					T13.M113().infoSpeacialSkill = new string[b28][];
					T13.M113().imgSpeacialSkill = new short[b28][];
					T51.panel.speacialTabName = new string[b28][];
					for (int num55 = 0; num55 < b28; num55++)
					{
						T51.panel.speacialTabName[num55] = new string[2];
						string[] array4 = T137.M1531(msg.M887().M1100(), "\n", 0);
						if (array4.Length == 2)
						{
							T51.panel.speacialTabName[num55] = array4;
						}
						if (array4.Length == 1)
						{
							T51.panel.speacialTabName[num55][0] = array4[0];
							T51.panel.speacialTabName[num55][1] = string.Empty;
						}
						int num56 = msg.M887().M1088();
						T13.M113().infoSpeacialSkill[num55] = new string[num56];
						T13.M113().imgSpeacialSkill[num55] = new short[num56];
						for (int num57 = 0; num57 < num56; num57++)
						{
							T13.M113().imgSpeacialSkill[num55][num57] = msg.M887().M1092();
							T13.M113().infoSpeacialSkill[num55][num57] = msg.M887().M1100();
						}
					}
					T51.panel.tabName[25] = T51.panel.speacialTabName;
					T51.panel.M1441();
					T51.panel.M1285();
					break;
				}
				case 0:
					T126.spearcialImage = msg.M887().M1092();
					T126.specialInfo = msg.M887().M1100();
					break;
				}
				break;
			}
			case -112:
			{
				sbyte b26 = msg.M887().M1088();
				if (b26 == 0)
				{
					T54.M627(msg.M887().M1088()).M977();
				}
				if (b26 == 1)
				{
					T54.M627(msg.M887().M1088()).M976(msg.M887().M1092());
				}
				break;
			}
			case -107:
			{
				sbyte b20 = msg.M887().M1088();
				if (b20 == 0)
				{
					T13.M113().havePet = false;
				}
				if (b20 == 1)
				{
					T13.M113().havePet = true;
				}
				if (b20 != 2)
				{
					break;
				}
				T66.M753();
				T13.M114().head = msg.M887().M1092();
				T13.M114().M165();
				int num25 = msg.M887().M1091();
				T137.M1513("num body = " + num25);
				T13.M114().arrItemBody = new T79[num25];
				for (int num26 = 0; num26 < num25; num26++)
				{
					short num27 = msg.M887().M1092();
					T137.M1513("template id= " + num27);
					if (num27 == -1)
					{
						continue;
					}
					T137.M1513("1");
					T13.M114().arrItemBody[num26] = new T79();
					T13.M114().arrItemBody[num26].template = T85.M834(num27);
					int type = T13.M114().arrItemBody[num26].template.type;
					T13.M114().arrItemBody[num26].quantity = msg.M887().M1094();
					T137.M1513("3");
					T13.M114().arrItemBody[num26].info = msg.M887().M1100();
					T13.M114().arrItemBody[num26].content = msg.M887().M1100();
					int num28 = msg.M887().M1091();
					T137.M1513("option size= " + num28);
					if (num28 != 0)
					{
						T13.M114().arrItemBody[num26].itemOption = new T82[num28];
						for (int num29 = 0; num29 < T13.M114().arrItemBody[num26].itemOption.Length; num29++)
						{
							int optionTemplateId3 = msg.M887().M1091();
							ushort param3 = msg.M887().M1093();
							T13.M114().arrItemBody[num26].itemOption[num29] = new T82(optionTemplateId3, param3);
						}
					}
					switch (type)
					{
					case 1:
						T13.M114().leg = T13.M114().arrItemBody[num26].template.part;
						break;
					case 0:
						T13.M114().body = T13.M114().arrItemBody[num26].template.part;
						break;
					}
				}
				T13.M114().cHP = msg.M889();
				T13.M114().cHPFull = msg.M889();
				T13.M114().cMP = msg.M889();
				T13.M114().cMPFull = msg.M889();
				T13.M114().cDamFull = msg.M889();
				T13.M114().cName = msg.M887().M1100();
				T13.M114().currStrLevel = msg.M887().M1100();
				T13.M114().cPower = msg.M887().M1095();
				T13.M114().cTiemNang = msg.M887().M1095();
				T13.M114().petStatus = msg.M887().M1088();
				T13.M114().cStamina = msg.M887().M1092();
				T13.M114().cMaxStamina = msg.M887().M1092();
				T13.M114().cCriticalFull = msg.M887().M1088();
				T13.M114().cDefull = msg.M887().M1092();
				T13.M114().arrPetSkill = new T149[msg.M887().M1088()];
				T137.M1513("SKILLENT = " + T13.M114().arrPetSkill);
				for (int num30 = 0; num30 < T13.M114().arrPetSkill.Length; num30++)
				{
					short num31 = msg.M887().M1092();
					if (num31 != -1)
					{
						T13.M114().arrPetSkill[num30] = T154.M1773(num31);
						continue;
					}
					T13.M114().arrPetSkill[num30] = new T149();
					T13.M114().arrPetSkill[num30].template = null;
					T13.M114().arrPetSkill[num30].moreInfo = msg.M887().M1100();
				}
				if (T51.w > 2 * T126.WIDTH_PANEL)
				{
					T51.panel2 = new T126();
					T51.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
					T51.panel2.M1253();
					T51.panel2.M1285();
					T51.panel.M1274();
					T51.panel.M1285();
				}
				else
				{
					T51.panel.tabName[21] = mResources.petMainTab;
					T51.panel.M1274();
					T51.panel.M1285();
				}
				break;
			}
			case -99:
				T66.M753();
				if (msg.M887().M1088() == 0)
				{
					T51.panel.vEnemy.M1120();
					int num123 = msg.M887().M1091();
					for (int num124 = 0; num124 < num123; num124++)
					{
						T13 t42 = new T13();
						t42.charID = msg.M887().M1094();
						t42.head = msg.M887().M1092();
						t42.headICON = msg.M887().M1092();
						t42.body = msg.M887().M1092();
						t42.leg = msg.M887().M1092();
						t42.bag = msg.M887().M1092();
						t42.cName = msg.M887().M1100();
						T67 t43 = new T67(msg.M887().M1100());
						bool isOnline2 = msg.M887().M1097();
						t43.charInfo = t42;
						t43.isOnline = isOnline2;
						T137.M1513("isonline = " + isOnline2);
						T51.panel.vEnemy.M1111(t43);
					}
					T51.panel.M1261();
					T51.panel.M1285();
				}
				break;
			case -98:
			{
				sbyte b16 = msg.M887().M1088();
				T51.menu.showMenu = false;
				if (b16 == 0)
				{
					T51.M496(msg.M887().M1100(), new T22(mResources.YES, T51.instance, 888397, msg.M887().M1100()), new T22(mResources.NO, T51.instance, 888396, null));
				}
				break;
			}
			case -97:
				T13.M113().cNangdong = msg.M887().M1094();
				break;
			case -96:
			{
				sbyte t47 = msg.M887().M1088();
				T51.panel.vTop.M1120();
				string topName = msg.M887().M1100();
				sbyte b50 = msg.M887().M1088();
				for (int num130 = 0; num130 < b50; num130++)
				{
					int rank = msg.M887().M1094();
					int pId = msg.M887().M1094();
					short headID = msg.M887().M1092();
					short headICON = msg.M887().M1092();
					short body = msg.M887().M1092();
					short leg = msg.M887().M1092();
					string name2 = msg.M887().M1100();
					string info4 = msg.M887().M1100();
					T176 t48 = new T176();
					t48.rank = rank;
					t48.headID = headID;
					t48.headICON = headICON;
					t48.body = body;
					t48.leg = leg;
					t48.name = name2;
					t48.info = info4;
					t48.info2 = msg.M887().M1100();
					t48.pId = pId;
					T51.panel.vTop.M1111(t48);
				}
				T51.panel.topName = topName;
				T51.panel.M1262(t47);
				T51.panel.M1285();
				break;
			}
			case -95:
			{
				sbyte b51 = msg.M887().M1088();
				T137.M1513("type= " + b51);
				if (b51 == 0)
				{
					int num134 = msg.M887().M1094();
					short templateId = msg.M887().M1092();
					int num135 = msg.M889();
					T160.M1826().M1844();
					if (num134 == T13.M113().charID)
					{
						T13.M113().mobMe = new T101(num134, isDisable: false, isDontMove: false, isFire: false, isIce: false, isWind: false, templateId, 1, num135, 0, num135, (short)(T13.M113().cx + ((T13.M113().cdir != 1) ? (-40) : 40)), (short)T13.M113().cy, 4, 0);
						T13.M113().mobMe.isMobMe = true;
						T31.M376(new T32(18, T13.M113().mobMe.x, T13.M113().mobMe.y, 2, 10, -1));
						T13.M113().tMobMeBorn = 30;
						T54.vMob.M1111(T13.M113().mobMe);
					}
					else
					{
						t = T54.M626(num134);
						if (t != null)
						{
							T101 t49 = new T101(num134, isDisable: false, isDontMove: false, isFire: false, isIce: false, isWind: false, templateId, 1, num135, 0, num135, (short)t.cx, (short)t.cy, 4, 0);
							t49.isMobMe = true;
							t.mobMe = t49;
							T54.vMob.M1111(t.mobMe);
						}
						else if (T54.M628(num134) == null)
						{
							T101 t50 = new T101(num134, isDisable: false, isDontMove: false, isFire: false, isIce: false, isWind: false, templateId, 1, num135, 0, num135, -100, -100, 4, 0);
							t50.isMobMe = true;
							T54.vMob.M1111(t50);
						}
					}
				}
				if (b51 == 1)
				{
					int num136 = msg.M887().M1094();
					int mobId = msg.M887().M1088();
					T137.M1513("mod attack id= " + num136);
					if (num136 == T13.M113().charID)
					{
						if (T54.M628(mobId) != null)
						{
							T13.M113().mobMe.M1004(T54.M628(mobId));
						}
					}
					else
					{
						t = T54.M626(num136);
						if (t != null && T54.M628(mobId) != null)
						{
							t.mobMe.M1004(T54.M628(mobId));
						}
					}
				}
				if (b51 == 2)
				{
					int num137 = msg.M887().M1094();
					int num138 = msg.M887().M1094();
					int num139 = msg.M889();
					int cHPNew = msg.M889();
					if (num137 == T13.M113().charID)
					{
						T137.M1513("mob dame= " + num139);
						t = T54.M626(num138);
						if (t != null)
						{
							t.cHPNew = cHPNew;
							if (T13.M113().mobMe.isBusyAttackSomeOne)
							{
								t.M218(num139, 0, isCrit: false, isMob: true);
							}
							else
							{
								T13.M113().mobMe.dame = num139;
								T13.M113().mobMe.M990(t);
							}
						}
					}
					else
					{
						t2 = T54.M628(num137);
						if (t2 != null)
						{
							if (num138 == T13.M113().charID)
							{
								T13.M113().cHPNew = cHPNew;
								if (t2.isBusyAttackSomeOne)
								{
									T13.M113().M218(num139, 0, isCrit: false, isMob: true);
								}
								else
								{
									t2.dame = num139;
									t2.M990(T13.M113());
								}
							}
							else
							{
								t = T54.M626(num138);
								if (t != null)
								{
									t.cHPNew = cHPNew;
									if (t2.isBusyAttackSomeOne)
									{
										t.M218(num139, 0, isCrit: false, isMob: true);
									}
									else
									{
										t2.dame = num139;
										t2.M990(t);
									}
								}
							}
						}
					}
				}
				if (b51 == 3)
				{
					int num140 = msg.M887().M1094();
					int mobId2 = msg.M887().M1094();
					int hp = msg.M889();
					int num141 = msg.M889();
					t = null;
					t = ((T13.M113().charID != num140) ? T54.M626(num140) : T13.M113());
					if (t != null)
					{
						t2 = T54.M628(mobId2);
						if (t.mobMe != null)
						{
							t.mobMe.M1004(t2);
						}
						if (t2 != null)
						{
							t2.hp = hp;
							if (num141 == 0)
							{
								t2.x = t2.xFirst;
								t2.y = t2.yFirst;
								T54.M643(mResources.miss, t2.x, t2.y - t2.h, 0, -2, T98.MISS);
							}
							else
							{
								T54.M643("-" + num141, t2.x, t2.y - t2.h, 0, -2, T98.ORANGE);
							}
						}
					}
				}
				if (b51 == 5)
				{
					int num142 = msg.M887().M1094();
					sbyte b52 = msg.M887().M1088();
					int mobId3 = msg.M887().M1094();
					int num143 = msg.M889();
					int hp2 = msg.M889();
					t = null;
					t = ((num142 != T13.M113().charID) ? T54.M626(num142) : T13.M113());
					if (t == null)
					{
						return;
					}
					if ((T174.M1957(t.cx, t.cy) & 2) == 2)
					{
						t.M172(T54.sks[b52], 0);
					}
					else
					{
						t.M172(T54.sks[b52], 1);
					}
					T101 t51 = T54.M628(mobId3);
					if (t.cx <= t51.x)
					{
						t.cdir = 1;
					}
					else
					{
						t.cdir = -1;
					}
					t.mobFocus = t51;
					t51.hp = hp2;
					T51.M456("SA83v2", 2);
					if (num143 == 0)
					{
						t51.x = t51.xFirst;
						t51.y = t51.yFirst;
						T54.M643(mResources.miss, t51.x, t51.y - t51.h, 0, -2, T98.MISS);
					}
					else
					{
						T54.M643("-" + num143, t51.x, t51.y - t51.h, 0, -2, T98.ORANGE);
					}
				}
				if (b51 == 6)
				{
					int num144 = msg.M887().M1094();
					if (num144 == T13.M113().charID)
					{
						T13.M113().mobMe.M1003();
					}
					else
					{
						T54.M626(num144)?.mobMe.M1003();
					}
				}
				if (b51 != 7)
				{
					break;
				}
				int num145 = msg.M887().M1094();
				if (num145 == T13.M113().charID)
				{
					T13.M113().mobMe = null;
					for (int num146 = 0; num146 < T54.vMob.M1113(); num146++)
					{
						if (((T101)T54.vMob.M1114(num146)).mobId == num145)
						{
							T54.vMob.M1118(num146);
						}
					}
					break;
				}
				t = T54.M626(num145);
				for (int num147 = 0; num147 < T54.vMob.M1113(); num147++)
				{
					if (((T101)T54.vMob.M1114(num147)).mobId == num145)
					{
						T54.vMob.M1118(num147);
					}
				}
				if (t != null)
				{
					t.mobMe = null;
				}
				break;
			}
			case -94:
				while (msg.M887().M1104() > 0)
				{
					short num44 = msg.M887().M1092();
					int num45 = msg.M887().M1094();
					for (int num46 = 0; num46 < T13.M113().vSkill.M1113(); num46++)
					{
						T149 t18 = (T149)T13.M113().vSkill.M1114(num46);
						if (t18 != null && t18.skillId == num44)
						{
							if (num45 < t18.coolDown)
							{
								t18.lastTimeUseThisSkill = T110.M1054() - (t18.coolDown - num45);
							}
							T137.M1513("1 chieu id= " + t18.template.id + " cooldown= " + num45 + "curr cool down= " + t18.coolDown);
						}
					}
				}
				break;
			case -93:
			{
				short num93 = msg.M887().M1092();
				T10.newSmallVersion = new sbyte[num93];
				for (int num94 = 0; num94 < num93; num94++)
				{
					T10.newSmallVersion[num94] = msg.M887().M1088();
				}
				break;
			}
			case -92:
				Main.typeClient = msg.M887().M1088();
				T138.M1547();
				T138.M1543("clienttype", Main.typeClient);
				T138.M1543("lastZoomlevel", T99.zoomLevel);
				T51.M494(mResources.plsRestartGame, 8885, null);
				break;
			case -91:
			{
				sbyte b23 = msg.M887().M1088();
				T51.panel.mapNames = new string[b23];
				T51.panel.planetNames = new string[b23];
				for (int num48 = 0; num48 < b23; num48++)
				{
					T51.panel.mapNames[num48] = msg.M887().M1100();
					T51.panel.planetNames[num48] = msg.M887().M1100();
				}
				T51.panel.M1247();
				T51.panel.M1285();
				break;
			}
			case -90:
			{
				sbyte b33 = msg.M887().M1088();
				T137.M1513("type = " + b33);
				int num68 = msg.M887().M1094();
				if (b33 != -1)
				{
					short num69 = msg.M887().M1092();
					short num70 = msg.M887().M1092();
					short num71 = msg.M887().M1092();
					sbyte isMonkey = msg.M887().M1088();
					T137.M1513("is Monkey = " + isMonkey);
					if (T13.M113().charID == num68)
					{
						T13.M113().isMask = true;
						T13.M113().isMonkey = isMonkey;
						if (T13.M113().isMonkey != 0)
						{
							T13.M113().isWaitMonkey = false;
							T13.M113().isLockMove = false;
						}
					}
					else if (T54.M626(num68) != null)
					{
						T54.M626(num68).isMask = true;
						T54.M626(num68).isMonkey = isMonkey;
					}
					if (num69 != -1)
					{
						if (num68 == T13.M113().charID)
						{
							T13.M113().head = num69;
						}
						else if (T54.M626(num68) != null)
						{
							T54.M626(num68).head = num69;
						}
					}
					if (num70 != -1)
					{
						if (num68 == T13.M113().charID)
						{
							T13.M113().body = num70;
						}
						else if (T54.M626(num68) != null)
						{
							T54.M626(num68).body = num70;
						}
					}
					if (num71 != -1)
					{
						if (num68 == T13.M113().charID)
						{
							T13.M113().leg = num71;
						}
						else if (T54.M626(num68) != null)
						{
							T54.M626(num68).leg = num71;
						}
					}
				}
				if (b33 == -1)
				{
					if (T13.M113().charID == num68)
					{
						T13.M113().isMask = false;
						T13.M113().isMonkey = 0;
					}
					else if (T54.M626(num68) != null)
					{
						T54.M626(num68).isMask = false;
						T54.M626(num68).isMonkey = 0;
					}
				}
				break;
			}
			case -88:
				T51.M488();
				T51.serverScreen.switchToMe();
				break;
			case -87:
			{
				T137.M1513("GET UPDATE_DATA " + msg.M887().M1104() + " bytes");
				msg.M887().M1089(100000);
				M306(msg.M887(), isSaveRMS: true);
				msg.M887().M1090();
				sbyte[] data4 = new sbyte[msg.M887().M1104()];
				msg.M887().M1103(ref data4);
				T138.M1534("NRdataVersion", new sbyte[1] { T54.vcData });
				T90.isUpdateData = false;
				if (T54.vsData == T54.vcData && T54.vsMap == T54.vcMap && T54.vsSkill == T54.vcSkill && T54.vsItem == T54.vcItem)
				{
					T137.M1513(T54.vsData + "," + T54.vsMap + "," + T54.vsSkill + "," + T54.vsItem);
					T54.M559().M557();
					T54.M559().M555();
					T54.M559().M556();
					T54.M559().M558();
					T146.M1594().M1679();
					return;
				}
				break;
			}
			case -86:
			{
				sbyte b9 = msg.M887().M1088();
				T137.M1513("server gui ve giao dich action = " + b9);
				if (b9 == 0)
				{
					int playerID = msg.M887().M1094();
					T54.M559().M670(playerID);
				}
				if (b9 == 1)
				{
					int num11 = msg.M887().M1094();
					T13 t6 = T54.M626(num11);
					if (t6 == null)
					{
						return;
					}
					T51.panel.M1297(t6);
					T51.panel.M1285();
					T146.M1594().M1610(num11);
				}
				if (b9 == 2)
				{
					sbyte b10 = msg.M887().M1088();
					for (int l = 0; l < T51.panel.vMyGD.M1113(); l++)
					{
						T79 t7 = (T79)T51.panel.vMyGD.M1114(l);
						if (t7.indexUI == b10)
						{
							T51.panel.vMyGD.M1119(t7);
							break;
						}
					}
				}
				if (b9 == 6)
				{
					T51.panel.isFriendLock = true;
					if (T51.panel2 != null)
					{
						T51.panel2.isFriendLock = true;
					}
					T51.panel.vFriendGD.M1120();
					if (T51.panel2 != null)
					{
						T51.panel2.vFriendGD.M1120();
					}
					int friendMoneyGD = msg.M887().M1094();
					sbyte b11 = msg.M887().M1088();
					T137.M1513("item size = " + b11);
					for (int m = 0; m < b11; m++)
					{
						T79 t8 = new T79();
						t8.template = T85.M834(msg.M887().M1092());
						t8.quantity = msg.M887().M1094();
						int num12 = msg.M887().M1091();
						if (num12 != 0)
						{
							t8.itemOption = new T82[num12];
							for (int n = 0; n < t8.itemOption.Length; n++)
							{
								int optionTemplateId = msg.M887().M1091();
								ushort param = msg.M887().M1093();
								t8.itemOption[n] = new T82(optionTemplateId, param);
								t8.compare = T51.panel.M1365(t8);
							}
						}
						if (T51.panel2 != null)
						{
							T51.panel2.vFriendGD.M1111(t8);
						}
						else
						{
							T51.panel.vFriendGD.M1111(t8);
						}
					}
					if (T51.panel2 != null)
					{
						T51.panel2.M1296(isMe: false);
						T51.panel2.friendMoneyGD = friendMoneyGD;
					}
					else
					{
						T51.panel.friendMoneyGD = friendMoneyGD;
						if (T51.panel.currentTabIndex == 2)
						{
							T51.panel.M1296(isMe: false);
						}
					}
				}
				if (b9 == 7)
				{
					T66.M753();
					if (T51.panel.isShow)
					{
						T51.panel.M1382();
					}
				}
				break;
			}
			case -85:
			{
				T137.M1513("CAP CHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
				sbyte b3 = msg.M887().M1088();
				if (b3 == 0)
				{
					int num3 = msg.M887().M1093();
					T137.M1513("lent =" + num3);
					sbyte[] data = new sbyte[num3];
					msg.M887().M1109(ref data, 0, num3);
					T54.imgCapcha = T60.M708(data, 0, num3);
					T54.M559().keyInput = "-----";
					T54.M559().strCapcha = msg.M887().M1100();
					T54.M559().keyCapcha = new int[T54.M559().strCapcha.Length];
					T54.M559().mobCapcha = new T101();
					T54.M559().right = null;
				}
				if (b3 == 1)
				{
					T102.isAttack = true;
				}
				if (b3 == 2)
				{
					T102.explode = true;
					T54.M559().right = T54.M559().cmdFocus;
				}
				break;
			}
			case -84:
			{
				int index2 = msg.M887().M1091();
				T101 t31 = null;
				try
				{
					t31 = (T101)T54.vMob.M1114(index2);
				}
				catch (Exception)
				{
				}
				if (t31 != null)
				{
					t31.maxHp = msg.M887().M1094();
				}
				break;
			}
			case -83:
			{
				sbyte b42 = msg.M887().M1088();
				if (b42 == 0)
				{
					int num108 = msg.M887().M1092();
					int bgRID = msg.M887().M1092();
					int num109 = msg.M887().M1091();
					int num110 = msg.M887().M1094();
					msg.M887().M1100();
					int xR = msg.M887().M1092();
					int yR = msg.M887().M1092();
					if (msg.M887().M1088() == 1)
					{
						T54.M559().isRongNamek = true;
					}
					else
					{
						T54.M559().isRongNamek = false;
					}
					T54.M559().xR = xR;
					T54.M559().yR = yR;
					T137.M1513("xR= " + xR + " yR= " + yR + " +++++++++++++++++++++++++++++++++++++++");
					if (T13.M113().charID == num110)
					{
						T51.panel.M1381();
						T54.M559().M591(isMe: true);
					}
					else if (T174.mapID == num108 && T174.zoneID == num109)
					{
						T54.M559().M591(isMe: false);
					}
					else if (T99.zoomLevel > 1)
					{
						T54.M559().M593();
					}
					T54.M559().mapRID = num108;
					T54.M559().bgRID = bgRID;
					T54.M559().zoneRID = num109;
				}
				if (b42 == 1)
				{
					T137.M1513("map RID = " + T54.M559().mapRID + " zone RID= " + T54.M559().zoneRID);
					T137.M1513("map ID = " + T174.mapID + " zone ID= " + T174.zoneID);
					if (T174.mapID == T54.M559().mapRID && T174.zoneID == T54.M559().zoneRID)
					{
						T54.M559().M592();
					}
					else
					{
						T54.M559().isRongThanXuatHien = false;
						if (T54.M559().isRongNamek)
						{
							T54.M559().isRongNamek = false;
						}
					}
				}
				if (b42 != 2)
				{
				}
				break;
			}
			case -82:
			{
				sbyte b43 = msg.M887().M1088();
				T174.tileIndex = new int[b43][][];
				T174.tileType = new int[b43][];
				for (int num111 = 0; num111 < b43; num111++)
				{
					sbyte b44 = msg.M887().M1088();
					T174.tileType[num111] = new int[b44];
					T174.tileIndex[num111] = new int[b44][];
					for (int num112 = 0; num112 < b44; num112++)
					{
						T174.tileType[num111][num112] = msg.M887().M1094();
						sbyte b45 = msg.M887().M1088();
						T174.tileIndex[num111][num112] = new int[b45];
						for (int num113 = 0; num113 < b45; num113++)
						{
							T174.tileIndex[num111][num112][num113] = msg.M887().M1088();
						}
					}
				}
				break;
			}
			case -81:
			{
				sbyte b35 = msg.M887().M1088();
				if (b35 == 0)
				{
					string src = msg.M887().M1100();
					string src2 = msg.M887().M1100();
					T51.panel.M1270();
					T51.panel.combineInfo = T98.tahoma_7b_blue.M907(src, T126.WIDTH_PANEL);
					T51.panel.combineTopInfo = T98.tahoma_7.M907(src2, T126.WIDTH_PANEL);
					T51.panel.M1285();
				}
				if (b35 == 1)
				{
					T51.panel.vItemCombine.M1120();
					sbyte b36 = msg.M887().M1088();
					for (int num79 = 0; num79 < b36; num79++)
					{
						sbyte b37 = msg.M887().M1088();
						for (int num80 = 0; num80 < T13.M113().arrItemBag.Length; num80++)
						{
							T79 t29 = T13.M113().arrItemBag[num80];
							if (t29 != null && t29.indexUI == b37)
							{
								t29.isSelect = true;
								T51.panel.vItemCombine.M1111(t29);
							}
						}
					}
					if (T51.panel.isShow)
					{
						T51.panel.M1271();
					}
				}
				if (b35 == 2)
				{
					T51.panel.combineSuccess = 0;
					T51.panel.M1426(0);
				}
				if (b35 == 3)
				{
					T51.panel.combineSuccess = 1;
					T51.panel.M1426(0);
				}
				if (b35 == 4)
				{
					short iconID = msg.M887().M1092();
					T51.panel.iconID3 = iconID;
					T51.panel.combineSuccess = 0;
					T51.panel.M1426(1);
				}
				if (b35 == 5)
				{
					short iconID2 = msg.M887().M1092();
					T51.panel.iconID3 = iconID2;
					T51.panel.combineSuccess = 0;
					T51.panel.M1426(2);
				}
				if (b35 == 6)
				{
					short iconID3 = msg.M887().M1092();
					short iconID4 = msg.M887().M1092();
					T51.panel.combineSuccess = 0;
					T51.panel.M1426(3);
					T51.panel.iconID1 = iconID3;
					T51.panel.iconID3 = iconID4;
				}
				if (b35 == 7)
				{
					short iconID5 = msg.M887().M1092();
					T51.panel.iconID3 = iconID5;
					T51.panel.combineSuccess = 0;
					T51.panel.M1426(4);
				}
				if (b35 == 8)
				{
					T51.panel.iconID3 = -1;
					T51.panel.combineSuccess = 1;
					T51.panel.M1426(4);
				}
				short num81 = 21;
				try
				{
					num81 = msg.M887().M1092();
				}
				catch (Exception)
				{
				}
				for (int num82 = 0; num82 < T54.vNpc.M1113(); num82++)
				{
					T123 t30 = (T123)T54.vNpc.M1114(num82);
					if (t30.template.npcTemplateId == num81)
					{
						T51.panel.xS = t30.cx - T54.cmx;
						T51.panel.yS = t30.cy - T54.cmy;
						T51.panel.idNPC = num81;
						break;
					}
				}
				break;
			}
			case -80:
			{
				sbyte b22 = msg.M887().M1088();
				T66.M753();
				if (b22 == 0)
				{
					T51.panel.vFriend.M1120();
					int num38 = msg.M887().M1091();
					for (int num39 = 0; num39 < num38; num39++)
					{
						T13 t14 = new T13();
						t14.charID = msg.M887().M1094();
						t14.head = msg.M887().M1092();
						t14.headICON = msg.M887().M1092();
						t14.body = msg.M887().M1092();
						t14.leg = msg.M887().M1092();
						t14.bag = msg.M887().M1091();
						t14.cName = msg.M887().M1100();
						bool isOnline = msg.M887().M1097();
						T67 t15 = new T67(mResources.power + ": " + msg.M887().M1100());
						t15.charInfo = t14;
						t15.isOnline = isOnline;
						T51.panel.vFriend.M1111(t15);
					}
					T51.panel.M1260();
					T51.panel.M1285();
				}
				if (b22 == 3)
				{
					T117 vFriend = T51.panel.vFriend;
					int num40 = msg.M887().M1094();
					T137.M1513("online offline id=" + num40);
					for (int num41 = 0; num41 < vFriend.M1113(); num41++)
					{
						T67 t16 = (T67)vFriend.M1114(num41);
						if (t16.charInfo != null && t16.charInfo.charID == num40)
						{
							T137.M1513("online= " + t16.isOnline);
							t16.isOnline = msg.M887().M1097();
							break;
						}
					}
				}
				if (b22 != 2)
				{
					break;
				}
				T117 vFriend2 = T51.panel.vFriend;
				int num42 = msg.M887().M1094();
				for (int num43 = 0; num43 < vFriend2.M1113(); num43++)
				{
					T67 t17 = (T67)vFriend2.M1114(num43);
					if (t17.charInfo != null && t17.charInfo.charID == num42)
					{
						vFriend2.M1119(t17);
						break;
					}
				}
				if (T51.panel.isShow)
				{
					T51.panel.M1264();
				}
				break;
			}
			case -79:
			{
				T66.M753();
				msg.M887().M1094();
				T13 charMenu = T51.panel.charMenu;
				if (charMenu == null)
				{
					return;
				}
				charMenu.cPower = msg.M887().M1095();
				charMenu.currStrLevel = msg.M887().M1100();
				break;
			}
			case -77:
			{
				short num131 = msg.M887().M1092();
				T157.newSmallVersion = new sbyte[num131];
				T157.maxSmall = num131;
				T157.imgNew = new T211[num131];
				for (int num132 = 0; num132 < num131; num132++)
				{
					T157.newSmallVersion[num132] = msg.M887().M1088();
				}
				break;
			}
			case -76:
				switch (msg.M887().M1088())
				{
				case 1:
				{
					int num149 = msg.M887().M1091();
					if (T13.M113().arrArchive[num149] != null)
					{
						T13.M113().arrArchive[num149].isRecieve = true;
					}
					break;
				}
				case 0:
				{
					sbyte b53 = msg.M887().M1088();
					if (b53 <= 0)
					{
						return;
					}
					T13.M113().arrArchive = new T3[b53];
					for (int num148 = 0; num148 < b53; num148++)
					{
						T13.M113().arrArchive[num148] = new T3();
						T13.M113().arrArchive[num148].info1 = num148 + 1 + ". " + msg.M887().M1100();
						T13.M113().arrArchive[num148].info2 = msg.M887().M1100();
						T13.M113().arrArchive[num148].money = msg.M887().M1092();
						T13.M113().arrArchive[num148].isFinish = msg.M887().M1097();
						T13.M113().arrArchive[num148].isRecieve = msg.M887().M1097();
					}
					T51.panel.M1250();
					T51.panel.M1285();
					break;
				}
				}
				break;
			case -74:
			{
				if (T144.stopDownload)
				{
					return;
				}
				if (!T51.M501())
				{
					T146.M1594().M1720(3, null);
					T157.M1777();
					T161.imgLogo = null;
					if (T138.M1536("acc") != null || T138.M1536("userAo" + T144.ipSelect) != null)
					{
						T90.isContinueToLogin = true;
					}
					T51.loginScr = new T90();
					T51.loginScr.switchToMe();
					return;
				}
				bool flag = true;
				sbyte b8 = msg.M887().M1088();
				T137.M1513("action = " + b8);
				if (b8 == 0)
				{
					int num7 = msg.M887().M1094();
					string text3 = T138.M1536("ResVersion");
					int num8 = ((text3 == null || !(text3 != string.Empty)) ? (-1) : int.Parse(text3));
					if (num8 != -1 && num8 == num7)
					{
						T137.M1513("login ngay");
						T157.M1777();
						T161.imgLogo = null;
						T144.loadScreen = true;
						if (T51.currentScreen != T51.loginScr)
						{
							T51.serverScreen.switchToMe();
						}
					}
					else
					{
						T144.loadScreen = false;
						T51.serverScreen.M1592();
					}
				}
				if (b8 == 1)
				{
					T144.strWait = mResources.downloading_data;
					T144.nBig = msg.M887().M1092();
					T146.M1594().M1720(2, null);
				}
				if (b8 == 2)
				{
					try
					{
						isLoadingData = true;
						T51.M488();
						T144.demPercent++;
						T144.percent = T144.demPercent * 100 / T144.nBig;
						string[] array = T137.M1531(msg.M887().M1100(), "/", 0);
						string filename = "x" + T99.zoomLevel + array[array.Length - 1];
						int num9 = msg.M887().M1094();
						sbyte[] data2 = new sbyte[num9];
						msg.M887().M1109(ref data2, 0, num9);
						T138.M1534(filename, data2);
					}
					catch (Exception)
					{
						T51.M494(mResources.pls_restart_game_error, 8885, null);
					}
				}
				if (b8 == 3 && flag)
				{
					isLoadingData = false;
					int num10 = msg.M887().M1094();
					T137.M1513("last version= " + num10);
					T138.M1538("ResVersion", num10 + string.Empty);
					T146.M1594().M1720(3, null);
					T51.M488();
					T161.imgLogo = null;
					T157.M1777();
					T110.M1062();
					T144.bigOk = true;
					T144.loadScreen = true;
					T54.M559().M561();
					if (T51.currentScreen != T51.loginScr)
					{
						T51.serverScreen.switchToMe();
					}
				}
				break;
			}
			case -70:
			{
				T137.M1513("BIG MESSAGE .......................................");
				T51.M488();
				int avatar = msg.M887().M1092();
				T14.M268(msg.M887().M1100(), 100000, new T123(-1, 0, 0, 0, 0, 0)
				{
					avatar = avatar
				});
				sbyte b56 = msg.M887().M1088();
				if (b56 == 0)
				{
					T14.serverChatPopUp.cmdMsg1 = new T22(mResources.CLOSE, T14.serverChatPopUp, 1001, null);
					T14.serverChatPopUp.cmdMsg1.x = T51.w / 2 - 35;
					T14.serverChatPopUp.cmdMsg1.y = T51.h - 35;
				}
				if (b56 == 1)
				{
					string p2 = msg.M887().M1100();
					string caption2 = msg.M887().M1100();
					T14.serverChatPopUp.cmdMsg1 = new T22(caption2, T14.serverChatPopUp, 1000, p2);
					T14.serverChatPopUp.cmdMsg1.x = T51.w / 2 - 75;
					T14.serverChatPopUp.cmdMsg1.y = T51.h - 35;
					T14.serverChatPopUp.cmdMsg2 = new T22(mResources.CLOSE, T14.serverChatPopUp, 1001, null);
					T14.serverChatPopUp.cmdMsg2.x = T51.w / 2 + 11;
					T14.serverChatPopUp.cmdMsg2.y = T51.h - 35;
				}
				break;
			}
			case -69:
				T13.M113().cMaxStamina = msg.M887().M1092();
				break;
			case -68:
				T13.M113().cStamina = msg.M887().M1092();
				break;
			case -67:
			{
				T137.M1513("RECIEVE ICON");
				demCount += 1f;
				int num107 = msg.M887().M1094();
				sbyte[] array10 = null;
				try
				{
					array10 = T122.M1185(msg);
					T137.M1513("request hinh icon = " + num107);
					if (num107 == 3896)
					{
						T137.M1513("SIZE CHECK= " + array10.Length);
					}
					T157.imgNew[num107].img = M307(array10);
				}
				catch (Exception)
				{
					array10 = null;
					T157.imgNew[num107].img = T60.M711(new int[1], 1, 1, bl: true);
				}
				if (array10 != null && T99.zoomLevel > 1)
				{
					T138.M1534(T99.zoomLevel + "Small" + num107, array10);
				}
				break;
			}
			case -66:
			{
				short id3 = msg.M887().M1092();
				sbyte[] data3 = T122.M1185(msg);
				T36 t32 = T32.M387(id3);
				sbyte b39 = msg.M887().M1086();
				if (b39 == 0)
				{
					t32.M399(data3);
				}
				else
				{
					t32.M400(data3, b39);
				}
				sbyte[] array6 = T122.M1185(msg);
				t32.img = T60.M708(array6, 0, array6.Length);
				break;
			}
			case -65:
			{
				T137.M1513("TELEPORT ...................................................");
				T66.M753();
				int num13 = msg.M887().M1094();
				sbyte b12 = msg.M887().M1088();
				if (b12 == 0)
				{
					break;
				}
				if (T13.M113().charID == num13)
				{
					isStopReadMessage = true;
					T54.lockTick = 500;
					T54.M559().center = null;
					if (b12 == 0 || b12 == 1 || b12 == 3)
					{
						T171.M1894(new T171(T13.M113().cx, T13.M113().cy, T13.M113().head, T13.M113().cdir, 0, isMe: true, (b12 != 1) ? b12 : T13.M113().cgender));
					}
					if (b12 == 2)
					{
						T54.lockTick = 50;
						T13.M113().M139();
					}
				}
				else
				{
					T13 t9 = T54.M626(num13);
					if ((b12 == 0 || b12 == 1 || b12 == 3) && t9 != null)
					{
						t9.isUsePlane = true;
						T171 t10 = new T171(t9.cx, t9.cy, t9.head, t9.cdir, 0, isMe: false, (b12 != 1) ? b12 : t9.cgender);
						t10.id = num13;
						T171.M1894(t10);
					}
					if (b12 == 2)
					{
						t9.M139();
					}
				}
				break;
			}
			case -64:
			{
				int num129 = msg.M887().M1094();
				int bag = msg.M887().M1091();
				if (num129 == T13.M113().charID)
				{
					T13.M113().bag = bag;
				}
				else if (T54.M626(num129) != null)
				{
					T54.M626(num129).bag = bag;
				}
				break;
			}
			case -63:
			{
				T137.M1513("GET BAG");
				int iD = msg.M887().M1091();
				sbyte b47 = msg.M887().M1088();
				T17 t39 = new T17();
				t39.ID = iD;
				if (b47 > 0)
				{
					t39.idImage = new short[b47];
					for (int num115 = 0; num115 < b47; num115++)
					{
						t39.idImage[num115] = msg.M887().M1092();
						T137.M1513("ID=  " + iD + " frame= " + t39.idImage[num115]);
					}
					T17.idImages.M1078(iD + string.Empty, t39);
				}
				break;
			}
			case -62:
			{
				int num121 = msg.M887().M1091();
				sbyte b49 = msg.M887().M1088();
				if (b49 <= 0)
				{
					break;
				}
				T17 t41 = T17.M288((sbyte)num121);
				if (t41 == null)
				{
					break;
				}
				t41.idImage = new short[b49];
				for (int num122 = 0; num122 < b49; num122++)
				{
					t41.idImage[num122] = msg.M887().M1092();
					if (t41.idImage[num122] > 0)
					{
						T157.vKeys.M1111(t41.idImage[num122] + string.Empty);
					}
				}
				break;
			}
			case -61:
			{
				int num83 = msg.M887().M1094();
				if (num83 != T13.M113().charID)
				{
					if (T54.M626(num83) != null)
					{
						T54.M626(num83).clanID = msg.M887().M1094();
						if (T54.M626(num83).clanID == -2)
						{
							T54.M626(num83).isCopy = true;
						}
					}
				}
				else if (T13.M113().clan != null)
				{
					T13.M113().clan.ID = msg.M887().M1094();
				}
				break;
			}
			case -60:
			{
				T51.M456("SA7666", 2);
				int num14 = msg.M887().M1094();
				int num15 = -1;
				if (num14 != T13.M113().charID)
				{
					T13 t11 = T54.M626(num14);
					if (t11 == null)
					{
						return;
					}
					if (t11.currentMovePoint != null)
					{
						t11.M182(t11.cx, t11.cy, 10);
						t11.cx = t11.currentMovePoint.xEnd;
						t11.cy = t11.currentMovePoint.yEnd;
					}
					int num16 = msg.M887().M1091();
					T137.M1513("player skill ID= " + num16);
					if ((T174.M1957(t11.cx, t11.cy) & 2) == 2)
					{
						t11.M172(T54.sks[num16], 0);
					}
					else
					{
						t11.M172(T54.sks[num16], 1);
					}
					sbyte b13 = msg.M887().M1088();
					T137.M1513("nAttack = " + b13);
					T13[] array2 = new T13[b13];
					for (num = 0; num < array2.Length; num++)
					{
						num15 = msg.M887().M1094();
						T13 t12;
						if (num15 == T13.M113().charID)
						{
							t12 = T13.M113();
							if (!T54.isChangeZone && T54.isAutoPlay && T54.canAutoPlay)
							{
								T146.M1594().M1638(-1, -1);
								T54.isChangeZone = true;
							}
						}
						else
						{
							t12 = T54.M626(num15);
						}
						array2[num] = t12;
						if (num == 0)
						{
							if (t11.cx <= t12.cx)
							{
								t11.cdir = 1;
							}
							else
							{
								t11.cdir = -1;
							}
						}
					}
					if (num > 0)
					{
						t11.attChars = new T13[num];
						for (num = 0; num < t11.attChars.Length; num++)
						{
							t11.attChars[num] = array2[num];
						}
						t11.mobFocus = null;
						t11.charFocus = t11.attChars[0];
					}
				}
				else
				{
					msg.M887().M1088();
					msg.M887().M1088();
					num15 = msg.M887().M1094();
				}
				try
				{
					sbyte b14 = msg.M887().M1088();
					T137.M1513("isRead continue = " + b14);
					if (b14 != 1)
					{
						break;
					}
					sbyte b15 = msg.M887().M1088();
					T137.M1513("type skill = " + b15);
					if (num15 == T13.M113().charID)
					{
						bool flag2 = false;
						t = T13.M113();
						int damHP = msg.M889();
						T137.M1513("dame hit = " + damHP);
						t.isDie = msg.M887().M1097();
						if (t.isDie)
						{
							T13.isLockKey = true;
						}
						T137.M1513("isDie=" + t.isDie + "---------------------------------------");
						flag2 = (t.isCrit = msg.M887().M1097());
						t.isMob = false;
						damHP = (t.damHP = damHP);
						if (b15 == 0)
						{
							t.M218(damHP, 0, flag2, isMob: false);
						}
					}
					else
					{
						t = T54.M626(num15);
						if (t == null)
						{
							return;
						}
						bool flag3 = false;
						int damHP2 = msg.M889();
						T137.M1513("dame hit= " + damHP2);
						t.isDie = msg.M887().M1097();
						T137.M1513("isDie=" + t.isDie + "---------------------------------------");
						flag3 = (t.isCrit = msg.M887().M1097());
						t.isMob = false;
						damHP2 = (t.damHP = damHP2);
						if (b15 == 0)
						{
							t.M218(damHP2, 0, flag3, isMob: false);
						}
					}
				}
				catch (Exception)
				{
				}
				break;
			}
			case -59:
			{
				sbyte typePK = msg.M887().M1088();
				T54.M559().M669(msg.M887().M1094(), msg.M887().M1094(), msg.M887().M1100(), typePK);
				break;
			}
			case -57:
			{
				string strInvite = msg.M887().M1100();
				int clanID = msg.M887().M1094();
				int code = msg.M887().M1094();
				T54.M559().M568(strInvite, clanID, code);
				break;
			}
			case -53:
			{
				T137.M1513("MY CLAN INFO");
				T66.M753();
				bool flag8 = false;
				int num100 = msg.M887().M1094();
				T137.M1513("clanId= " + num100);
				if (num100 == -1)
				{
					flag8 = true;
					T13.M113().clan = null;
					T19.vMessage.M1120();
					if (T51.panel.member != null)
					{
						T51.panel.member.M1120();
					}
					if (T51.panel.myMember != null)
					{
						T51.panel.myMember.M1120();
					}
					if (T51.currentScreen == T54.M559())
					{
						T51.panel.M1314();
					}
					return;
				}
				T51.panel.tabIcon = null;
				if (T13.M113().clan == null)
				{
					T13.M113().clan = new T16();
				}
				T13.M113().clan.ID = num100;
				T13.M113().clan.name = msg.M887().M1100();
				T13.M113().clan.slogan = msg.M887().M1100();
				T13.M113().clan.imgID = msg.M887().M1091();
				T13.M113().clan.powerPoint = msg.M887().M1100();
				T13.M113().clan.leaderName = msg.M887().M1100();
				T13.M113().clan.currMember = msg.M887().M1091();
				T13.M113().clan.maxMember = msg.M887().M1091();
				T13.M113().role = msg.M887().M1088();
				T13.M113().clan.clanPoint = msg.M887().M1094();
				T13.M113().clan.level = msg.M887().M1088();
				T51.panel.myMember = new T117();
				for (int num101 = 0; num101 < T13.M113().clan.currMember; num101++)
				{
					T95 t36 = new T95();
					t36.ID = msg.M887().M1094();
					t36.head = msg.M887().M1092();
					t36.headICON = msg.M887().M1092();
					t36.leg = msg.M887().M1092();
					t36.body = msg.M887().M1092();
					t36.name = msg.M887().M1100();
					t36.role = msg.M887().M1088();
					t36.powerPoint = msg.M887().M1100();
					t36.donate = msg.M887().M1094();
					t36.receive_donate = msg.M887().M1094();
					t36.clanPoint = msg.M887().M1094();
					t36.curClanPoint = msg.M887().M1094();
					t36.joinTime = T122.M1189(msg.M887().M1094());
					T51.panel.myMember.M1111(t36);
				}
				int num102 = msg.M887().M1091();
				for (int num103 = 0; num103 < num102; num103++)
				{
					M309(msg, -1);
				}
				if (T51.panel.isSearchClan || T51.panel.isViewMember || T51.panel.isMessage)
				{
					T51.panel.M1314();
				}
				if (flag8)
				{
					T51.panel.M1314();
				}
				break;
			}
			case -52:
			{
				sbyte b30 = msg.M887().M1088();
				if (b30 == 0)
				{
					T95 t23 = new T95();
					t23.ID = msg.M887().M1094();
					t23.head = msg.M887().M1092();
					t23.headICON = msg.M887().M1092();
					t23.leg = msg.M887().M1092();
					t23.body = msg.M887().M1092();
					t23.name = msg.M887().M1100();
					t23.role = msg.M887().M1088();
					t23.powerPoint = msg.M887().M1100();
					t23.donate = msg.M887().M1094();
					t23.receive_donate = msg.M887().M1094();
					t23.clanPoint = msg.M887().M1094();
					t23.joinTime = T122.M1189(msg.M887().M1094());
					T95 o2 = t23;
					if (T51.panel.myMember == null)
					{
						T51.panel.myMember = new T117();
					}
					T51.panel.myMember.M1111(o2);
					T51.panel.M1313();
				}
				if (b30 == 1)
				{
					T51.panel.myMember.M1118(msg.M887().M1088());
					T126 panel = T51.panel;
					panel.currentListLength--;
					T51.panel.M1313();
				}
				if (b30 != 2)
				{
					break;
				}
				T95 t24 = new T95();
				t24.ID = msg.M887().M1094();
				t24.head = msg.M887().M1092();
				t24.headICON = msg.M887().M1092();
				t24.leg = msg.M887().M1092();
				t24.body = msg.M887().M1092();
				t24.name = msg.M887().M1100();
				t24.role = msg.M887().M1088();
				t24.powerPoint = msg.M887().M1100();
				t24.donate = msg.M887().M1094();
				t24.receive_donate = msg.M887().M1094();
				t24.clanPoint = msg.M887().M1094();
				t24.joinTime = T122.M1189(msg.M887().M1094());
				for (int num62 = 0; num62 < T51.panel.myMember.M1113(); num62++)
				{
					T95 t25 = (T95)T51.panel.myMember.M1114(num62);
					if (t25.ID == t24.ID)
					{
						if (T13.M113().charID == t24.ID)
						{
							T13.M113().role = t24.role;
						}
						T95 o3 = t24;
						T51.panel.myMember.M1119(t25);
						T51.panel.myMember.M1121(o3, num62);
						return;
					}
				}
				break;
			}
			case -51:
				T66.M753();
				M309(msg, 0);
				if (T51.panel.isMessage && T51.panel.type == 5)
				{
					T51.panel.M1313();
				}
				break;
			case -50:
			{
				T66.M753();
				T51.panel.member = new T117();
				sbyte b29 = msg.M887().M1088();
				for (int num61 = 0; num61 < b29; num61++)
				{
					T95 t22 = new T95();
					t22.ID = msg.M887().M1094();
					t22.head = msg.M887().M1092();
					t22.headICON = msg.M887().M1092();
					t22.leg = msg.M887().M1092();
					t22.body = msg.M887().M1092();
					t22.name = msg.M887().M1100();
					t22.role = msg.M887().M1088();
					t22.powerPoint = msg.M887().M1100();
					t22.donate = msg.M887().M1094();
					t22.receive_donate = msg.M887().M1094();
					t22.clanPoint = msg.M887().M1094();
					t22.joinTime = T122.M1189(msg.M887().M1094());
					T51.panel.member.M1111(t22);
				}
				T51.panel.isViewMember = true;
				T51.panel.isSearchClan = false;
				T51.panel.isMessage = false;
				T51.panel.currentListLength = T51.panel.member.M1113() + 2;
				T51.panel.M1313();
				break;
			}
			case -47:
			{
				T66.M753();
				sbyte b19 = msg.M887().M1088();
				T137.M1513("clan = " + b19);
				if (b19 == 0)
				{
					T51.panel.clanReport = mResources.cannot_find_clan;
					T51.panel.clans = null;
				}
				else
				{
					T51.panel.clans = new T16[b19];
					T137.M1513("clan search lent= " + T51.panel.clans.Length);
					for (int num24 = 0; num24 < T51.panel.clans.Length; num24++)
					{
						T51.panel.clans[num24] = new T16();
						T51.panel.clans[num24].ID = msg.M887().M1094();
						T51.panel.clans[num24].name = msg.M887().M1100();
						T51.panel.clans[num24].slogan = msg.M887().M1100();
						T51.panel.clans[num24].imgID = msg.M887().M1091();
						T51.panel.clans[num24].powerPoint = msg.M887().M1100();
						T51.panel.clans[num24].leaderName = msg.M887().M1100();
						T51.panel.clans[num24].currMember = msg.M887().M1091();
						T51.panel.clans[num24].maxMember = msg.M887().M1091();
						T51.panel.clans[num24].date = msg.M887().M1094();
					}
				}
				T51.panel.isSearchClan = true;
				T51.panel.isViewMember = false;
				T51.panel.isMessage = false;
				if (T51.panel.isSearchClan)
				{
					T51.panel.M1313();
				}
				break;
			}
			case -46:
			{
				T66.M753();
				sbyte b2 = msg.M887().M1088();
				if (b2 == 1 || b2 == 3)
				{
					T51.M488();
					T17.vClanImage.M1120();
					int num2 = msg.M887().M1091();
					for (int i = 0; i < num2; i++)
					{
						T17 t5 = new T17();
						t5.ID = msg.M887().M1091();
						t5.name = msg.M887().M1100();
						t5.xu = msg.M887().M1094();
						t5.luong = msg.M887().M1094();
						if (!T17.M289(t5.ID))
						{
							T17.M287(t5);
							continue;
						}
						T17.M288((sbyte)t5.ID).name = t5.name;
						T17.M288((sbyte)t5.ID).xu = t5.xu;
						T17.M288((sbyte)t5.ID).luong = t5.luong;
					}
					if (T13.M113().clan != null)
					{
						T51.panel.M1408();
					}
				}
				if (b2 == 4)
				{
					T13.M113().clan.imgID = msg.M887().M1091();
					T13.M113().clan.slogan = msg.M887().M1100();
				}
				break;
			}
			case -45:
			{
				sbyte b4 = msg.M887().M1088();
				int num4 = msg.M887().M1094();
				short num5 = msg.M887().M1092();
				T137.M1513("skill type= " + b4 + "   player use= " + num4);
				if (b4 == 0)
				{
					T137.M1513("id use= " + num4);
					if (T13.M113().charID != num4)
					{
						t = T54.M626(num4);
						if ((T174.M1957(t.cx, t.cy) & 2) == 2)
						{
							t.M172(T54.sks[num5], 0);
						}
						else
						{
							t.M172(T54.sks[num5], 1);
							t.delayFall = 20;
						}
					}
					else
					{
						T13.M113().M131();
						T137.M1513("LOAD LAST SKILL");
					}
					sbyte b5 = msg.M887().M1088();
					T137.M1513("npc size= " + b5);
					for (int j = 0; j < b5; j++)
					{
						sbyte index = msg.M887().M1088();
						sbyte seconds = msg.M887().M1088();
						T137.M1513("index= " + index);
						if (num5 >= 42 && num5 <= 48)
						{
							((T101)T54.vMob.M1114(index)).isFreez = true;
							((T101)T54.vMob.M1114(index)).seconds = seconds;
							((T101)T54.vMob.M1114(index)).last = (((T101)T54.vMob.M1114(index)).cur = T110.M1054());
						}
					}
					sbyte b6 = msg.M887().M1088();
					for (int k = 0; k < b6; k++)
					{
						int num6 = msg.M887().M1094();
						sbyte b7 = msg.M887().M1088();
						T137.M1513("player ID= " + num6 + " my ID= " + T13.M113().charID);
						if (num5 < 42 || num5 > 48)
						{
							continue;
						}
						if (num6 == T13.M113().charID)
						{
							if (!T13.M113().isFlyAndCharge && !T13.M113().isStandAndCharge)
							{
								T54.M559().isFreez = true;
								T13.M113().isFreez = true;
								T13.M113().freezSeconds = b7;
								T13.M113().lastFreez = (T13.M113().currFreez = T110.M1054());
								T13.M113().isLockMove = true;
							}
						}
						else
						{
							t = T54.M626(num6);
							if (t != null && !t.isFlyAndCharge && !t.isStandAndCharge)
							{
								t.isFreez = true;
								t.seconds = b7;
								t.freezSeconds = b7;
								t.lastFreez = (T54.M626(num6).currFreez = T110.M1054());
							}
						}
					}
				}
				if (b4 == 1 && num4 != T13.M113().charID)
				{
					T54.M626(num4).isCharge = true;
				}
				if (b4 == 3)
				{
					if (num4 == T13.M113().charID)
					{
						T13.M113().isCharge = false;
						T160.M1826().M1867();
						T13.M113().M131();
					}
					else
					{
						T54.M626(num4).isCharge = false;
					}
				}
				if (b4 == 4)
				{
					if (num4 == T13.M113().charID)
					{
						T13.M113().seconds = msg.M887().M1092() - 1000;
						T13.M113().last = T110.M1054();
						T137.M1513("second= " + T13.M113().seconds + " last= " + T13.M113().last);
					}
					else if (T54.M626(num4) != null)
					{
						switch (T54.M626(num4).cgender)
						{
						case 1:
							T54.M626(num4).M176(isGround: true);
							break;
						case 0:
							T54.M626(num4).M176(isGround: false);
							break;
						}
						T54.M626(num4).skillTemplateId = num5;
						T54.M626(num4).isUseSkillAfterCharge = true;
						T54.M626(num4).seconds = msg.M887().M1092();
						T54.M626(num4).last = T110.M1054();
					}
				}
				if (b4 == 5)
				{
					if (num4 == T13.M113().charID)
					{
						T13.M113().M175();
					}
					else if (T54.M626(num4) != null)
					{
						T54.M626(num4).M175();
					}
				}
				if (b4 == 6)
				{
					if (num4 == T13.M113().charID)
					{
						T13.M113().M177(T54.sks[num5], 0);
					}
					else if (T54.M626(num4) != null)
					{
						T54.M626(num4).M177(T54.sks[num5], 0);
						T160.M1826().M1835();
					}
				}
				if (b4 == 7)
				{
					if (num4 == T13.M113().charID)
					{
						T13.M113().seconds = msg.M887().M1092();
						T137.M1513("second = " + T13.M113().seconds);
						T13.M113().last = T110.M1054();
					}
					else if (T54.M626(num4) != null)
					{
						T54.M626(num4).M176(isGround: true);
						T54.M626(num4).seconds = msg.M887().M1092();
						T54.M626(num4).last = T110.M1054();
						T160.M1826().M1835();
					}
				}
				if (b4 == 8 && num4 != T13.M113().charID && T54.M626(num4) != null)
				{
					T54.M626(num4).M177(T54.sks[num5], 0);
				}
				break;
			}
			case -44:
			{
				bool flag7 = false;
				if (T51.w > 2 * T126.WIDTH_PANEL)
				{
					flag7 = true;
				}
				sbyte b40 = msg.M887().M1088();
				int num85 = msg.M887().M1091();
				T13.M113().arrItemShop = new T79[num85][];
				T51.panel.shopTabName = new string[num85 + ((!flag7) ? 1 : 0)][];
				for (int num86 = 0; num86 < T51.panel.shopTabName.Length; num86++)
				{
					T51.panel.shopTabName[num86] = new string[2];
				}
				if (b40 == 2)
				{
					T51.panel.maxPageShop = new int[num85];
					T51.panel.currPageShop = new int[num85];
				}
				if (!flag7)
				{
					T51.panel.shopTabName[num85] = mResources.inventory;
				}
				for (int num87 = 0; num87 < num85; num87++)
				{
					string[] array7 = T137.M1531(msg.M887().M1100(), "\n", 0);
					if (b40 == 2)
					{
						T51.panel.maxPageShop[num87] = msg.M887().M1091();
					}
					if (array7.Length == 2)
					{
						T51.panel.shopTabName[num87] = array7;
					}
					if (array7.Length == 1)
					{
						T51.panel.shopTabName[num87][0] = array7[0];
						T51.panel.shopTabName[num87][1] = string.Empty;
					}
					int num88 = msg.M887().M1091();
					T13.M113().arrItemShop[num87] = new T79[num88];
					T126.strWantToBuy = mResources.say_wat_do_u_want_to_buy;
					if (b40 == 1)
					{
						T126.strWantToBuy = mResources.say_wat_do_u_want_to_buy2;
					}
					for (int num89 = 0; num89 < num88; num89++)
					{
						short num90 = msg.M887().M1092();
						if (num90 == -1)
						{
							continue;
						}
						T13.M113().arrItemShop[num87][num89] = new T79();
						T13.M113().arrItemShop[num87][num89].template = T85.M834(num90);
						T137.M1513("name " + num87 + " = " + T13.M113().arrItemShop[num87][num89].template.name + " id templat= " + T13.M113().arrItemShop[num87][num89].template.id);
						switch (b40)
						{
						case 0:
							T13.M113().arrItemShop[num87][num89].buyCoin = msg.M887().M1094();
							T13.M113().arrItemShop[num87][num89].buyGold = msg.M887().M1094();
							break;
						case 1:
							T13.M113().arrItemShop[num87][num89].powerRequire = msg.M887().M1095();
							break;
						case 2:
							T13.M113().arrItemShop[num87][num89].itemId = msg.M887().M1092();
							T13.M113().arrItemShop[num87][num89].buyCoin = msg.M887().M1094();
							T13.M113().arrItemShop[num87][num89].buyGold = msg.M887().M1094();
							T13.M113().arrItemShop[num87][num89].buyType = msg.M887().M1088();
							T13.M113().arrItemShop[num87][num89].quantity = msg.M887().M1094();
							T13.M113().arrItemShop[num87][num89].isMe = msg.M887().M1088();
							break;
						case 3:
							T13.M113().arrItemShop[num87][num89].isBuySpec = true;
							T13.M113().arrItemShop[num87][num89].iconSpec = msg.M887().M1092();
							T13.M113().arrItemShop[num87][num89].buySpec = msg.M887().M1094();
							break;
						case 4:
							T13.M113().arrItemShop[num87][num89].reason = msg.M887().M1100();
							break;
						case 8:
							T13.M113().arrItemShop[num87][num89].buyCoin = msg.M887().M1094();
							T13.M113().arrItemShop[num87][num89].buyGold = msg.M887().M1094();
							T13.M113().arrItemShop[num87][num89].quantity = msg.M887().M1094();
							break;
						}
						int num91 = msg.M887().M1091();
						if (num91 != 0)
						{
							T13.M113().arrItemShop[num87][num89].itemOption = new T82[num91];
							for (int num92 = 0; num92 < T13.M113().arrItemShop[num87][num89].itemOption.Length; num92++)
							{
								int optionTemplateId6 = msg.M887().M1091();
								ushort param6 = msg.M887().M1093();
								T13.M113().arrItemShop[num87][num89].itemOption[num92] = new T82(optionTemplateId6, param6);
								T13.M113().arrItemShop[num87][num89].compare = T51.panel.M1365(T13.M113().arrItemShop[num87][num89]);
							}
						}
						sbyte b41 = msg.M887().M1088();
						T13.M113().arrItemShop[num87][num89].newItem = ((b41 != 0) ? true : false);
						if (msg.M887().M1088() == 1)
						{
							int headTemp = msg.M887().M1092();
							int bodyTemp = msg.M887().M1092();
							int legTemp = msg.M887().M1092();
							short bagTemp = msg.M887().M1092();
							T13.M113().arrItemShop[num87][num89].M817(headTemp, bodyTemp, legTemp, bagTemp);
						}
					}
				}
				if (flag7)
				{
					if (b40 != 2)
					{
						T51.panel2 = new T126();
						T51.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
						T51.panel2.M1253();
						T51.panel2.M1285();
					}
					else
					{
						T51.panel2 = new T126();
						T51.panel2.M1251();
						T51.panel2.M1285();
					}
				}
				T51.panel.tabName[1] = T51.panel.shopTabName;
				if (b40 == 2)
				{
					string[][] array8 = T51.panel.tabName[1];
					if (flag7)
					{
						T51.panel.tabName[1] = new string[4][]
						{
							array8[0],
							array8[1],
							array8[2],
							array8[3]
						};
					}
					else
					{
						T51.panel.tabName[1] = new string[5][]
						{
							array8[0],
							array8[1],
							array8[2],
							array8[3],
							array8[4]
						};
					}
				}
				T51.panel.M1268(b40);
				T51.panel.M1285();
				break;
			}
			case -43:
			{
				sbyte itemAction = msg.M887().M1088();
				sbyte where = msg.M887().M1088();
				sbyte index3 = msg.M887().M1088();
				string info3 = msg.M887().M1100();
				T51.panel.M1424(itemAction, info3, where, index3);
				break;
			}
			case -42:
				T13.M113().cHPGoc = msg.M889();
				T13.M113().cMPGoc = msg.M889();
				T13.M113().cDamGoc = msg.M887().M1094();
				T13.M113().cHPFull = msg.M889();
				T13.M113().cMPFull = msg.M889();
				T13.M113().cHP = msg.M889();
				T13.M113().cMP = msg.M889();
				T13.M113().cspeed = msg.M887().M1088();
				T13.M113().hpFrom1000TiemNang = msg.M887().M1088();
				T13.M113().mpFrom1000TiemNang = msg.M887().M1088();
				T13.M113().damFrom1000TiemNang = msg.M887().M1088();
				T13.M113().cDamFull = msg.M887().M1094();
				T13.M113().cDefull = msg.M887().M1094();
				T13.M113().cCriticalFull = msg.M887().M1088();
				T13.M113().cTiemNang = msg.M887().M1095();
				T13.M113().expForOneAdd = msg.M887().M1092();
				T13.M113().cDefGoc = msg.M887().M1092();
				T13.M113().cCriticalGoc = msg.M887().M1088();
				T66.M753();
				break;
			case -41:
			{
				sbyte b38 = msg.M887().M1088();
				T13.M113().strLevel = new string[b38];
				for (int num84 = 0; num84 < b38; num84++)
				{
					string text5 = msg.M887().M1100();
					T13.M113().strLevel[num84] = text5;
				}
				T137.M1513("---   xong  level caption cmd : " + msg.command);
				break;
			}
			case -37:
			{
				sbyte b34 = msg.M887().M1088();
				T137.M1513("cAction= " + b34);
				if (b34 != 0)
				{
					break;
				}
				T13.M113().head = msg.M887().M1092();
				T13.M113().M165();
				int num74 = msg.M887().M1091();
				T137.M1513("num body = " + num74);
				T13.M113().arrItemBody = new T79[num74];
				for (int num75 = 0; num75 < num74; num75++)
				{
					short num76 = msg.M887().M1092();
					if (num76 == -1)
					{
						continue;
					}
					T13.M113().arrItemBody[num75] = new T79();
					T13.M113().arrItemBody[num75].template = T85.M834(num76);
					int type3 = T13.M113().arrItemBody[num75].template.type;
					T13.M113().arrItemBody[num75].quantity = msg.M887().M1094();
					T13.M113().arrItemBody[num75].info = msg.M887().M1100();
					T13.M113().arrItemBody[num75].content = msg.M887().M1100();
					int num77 = msg.M887().M1091();
					if (num77 != 0)
					{
						T13.M113().arrItemBody[num75].itemOption = new T82[num77];
						for (int num78 = 0; num78 < T13.M113().arrItemBody[num75].itemOption.Length; num78++)
						{
							int optionTemplateId5 = msg.M887().M1091();
							ushort param5 = msg.M887().M1093();
							T13.M113().arrItemBody[num75].itemOption[num78] = new T82(optionTemplateId5, param5);
						}
					}
					switch (type3)
					{
					case 1:
						T13.M113().leg = T13.M113().arrItemBody[num75].template.part;
						break;
					case 0:
						T13.M113().body = T13.M113().arrItemBody[num75].template.part;
						break;
					}
				}
				break;
			}
			case -36:
			{
				sbyte b24 = msg.M887().M1088();
				T137.M1513("cAction= " + b24);
				if (b24 == 0)
				{
					int num50 = msg.M887().M1091();
					T13.M113().arrItemBag = new T79[num50];
					T54.hpPotion = 0;
					T137.M1513("numC=" + num50);
					for (int num51 = 0; num51 < num50; num51++)
					{
						short num52 = msg.M887().M1092();
						if (num52 == -1)
						{
							continue;
						}
						T13.M113().arrItemBag[num51] = new T79();
						T13.M113().arrItemBag[num51].template = T85.M834(num52);
						T13.M113().arrItemBag[num51].quantity = msg.M887().M1094();
						T13.M113().arrItemBag[num51].info = msg.M887().M1100();
						T13.M113().arrItemBag[num51].content = msg.M887().M1100();
						T13.M113().arrItemBag[num51].indexUI = num51;
						int num53 = msg.M887().M1091();
						if (num53 != 0)
						{
							T13.M113().arrItemBag[num51].itemOption = new T82[num53];
							for (int num54 = 0; num54 < T13.M113().arrItemBag[num51].itemOption.Length; num54++)
							{
								int optionTemplateId4 = msg.M887().M1091();
								ushort param4 = msg.M887().M1093();
								T13.M113().arrItemBag[num51].itemOption[num54] = new T82(optionTemplateId4, param4);
							}
							T13.M113().arrItemBag[num51].compare = T51.panel.M1365(T13.M113().arrItemBag[num51]);
						}
						_ = T13.M113().arrItemBag[num51].template.type;
						if (T13.M113().arrItemBag[num51].template.type == 6)
						{
							T54.hpPotion += T13.M113().arrItemBag[num51].quantity;
						}
					}
				}
				if (b24 == 2)
				{
					sbyte b25 = msg.M887().M1088();
					int quantity2 = msg.M887().M1094();
					int quantity3 = T13.M113().arrItemBag[b25].quantity;
					T13.M113().arrItemBag[b25].quantity = quantity2;
					if (T13.M113().arrItemBag[b25].quantity < quantity3 && T13.M113().arrItemBag[b25].template.type == 6)
					{
						T54.hpPotion -= quantity3 - T13.M113().arrItemBag[b25].quantity;
					}
					if (T13.M113().arrItemBag[b25].quantity == 0)
					{
						T13.M113().arrItemBag[b25] = null;
					}
				}
				break;
			}
			case -35:
			{
				sbyte b17 = msg.M887().M1088();
				T137.M1513("cAction= " + b17);
				if (b17 == 0)
				{
					int num17 = msg.M887().M1091();
					T13.M113().arrItemBox = new T79[num17];
					T51.panel.hasUse = 0;
					for (int num18 = 0; num18 < num17; num18++)
					{
						short num19 = msg.M887().M1092();
						if (num19 == -1)
						{
							continue;
						}
						T13.M113().arrItemBox[num18] = new T79();
						T13.M113().arrItemBox[num18].template = T85.M834(num19);
						T13.M113().arrItemBox[num18].quantity = msg.M887().M1094();
						T13.M113().arrItemBox[num18].info = msg.M887().M1100();
						T13.M113().arrItemBox[num18].content = msg.M887().M1100();
						int num20 = msg.M887().M1091();
						if (num20 != 0)
						{
							T13.M113().arrItemBox[num18].itemOption = new T82[num20];
							for (int num21 = 0; num21 < T13.M113().arrItemBox[num18].itemOption.Length; num21++)
							{
								int optionTemplateId2 = msg.M887().M1091();
								ushort param2 = msg.M887().M1093();
								T13.M113().arrItemBox[num18].itemOption[num21] = new T82(optionTemplateId2, param2);
							}
						}
						T126 panel = T51.panel;
						panel.hasUse++;
					}
				}
				if (b17 == 1)
				{
					bool isBoxClan = false;
					try
					{
						if (msg.M887().M1088() == 1)
						{
							isBoxClan = true;
						}
					}
					catch (Exception)
					{
					}
					T51.panel.M1269();
					T51.panel.isBoxClan = isBoxClan;
					T51.panel.M1285();
				}
				if (b17 == 2)
				{
					sbyte b18 = msg.M887().M1088();
					int quantity = msg.M887().M1094();
					T13.M113().arrItemBox[b18].quantity = quantity;
					if (T13.M113().arrItemBox[b18].quantity == 0)
					{
						T13.M113().arrItemBox[b18] = null;
					}
				}
				break;
			}
			case -34:
			{
				sbyte b54 = msg.M887().M1088();
				T137.M1513("act= " + b54);
				if (b54 == 0 && T54.M559().magicTree != null)
				{
					T137.M1513("toi duoc day");
					T91 magicTree = T54.M559().magicTree;
					magicTree.id = msg.M887().M1092();
					magicTree.name = msg.M887().M1100();
					magicTree.name = T137.M1518(magicTree.name);
					magicTree.x = msg.M887().M1092();
					magicTree.y = msg.M887().M1092();
					magicTree.level = msg.M887().M1088();
					magicTree.currPeas = msg.M887().M1092();
					magicTree.maxPeas = msg.M887().M1092();
					T137.M1513("curr Peas= " + magicTree.currPeas);
					magicTree.strInfo = msg.M887().M1100();
					magicTree.seconds = msg.M887().M1094();
					magicTree.timeToRecieve = magicTree.seconds;
					sbyte b55 = msg.M887().M1088();
					magicTree.peaPostionX = new int[b55];
					magicTree.peaPostionY = new int[b55];
					for (int num150 = 0; num150 < b55; num150++)
					{
						magicTree.peaPostionX[num150] = msg.M887().M1088();
						magicTree.peaPostionY[num150] = msg.M887().M1088();
					}
					magicTree.isUpdate = msg.M887().M1096();
					magicTree.last = (magicTree.cur = T110.M1054());
					T54.M559().magicTree.isUpdateTree = true;
				}
				if (b54 == 1)
				{
					t3 = new T117();
					try
					{
						while (msg.M887().M1104() > 0)
						{
							t3.M1111(new T22(msg.M887().M1100(), T51.instance, 888392, null));
						}
					}
					catch (Exception ex20)
					{
						T24.M326("Loi MAGIC_TREE " + ex20.ToString());
					}
					T51.menu.M877(t3, 3);
				}
				if (b54 == 2)
				{
					T54.M559().magicTree.remainPeas = msg.M887().M1092();
					T54.M559().magicTree.seconds = msg.M887().M1094();
					T54.M559().magicTree.last = (T54.M559().magicTree.cur = T110.M1054());
					T54.M559().magicTree.isUpdateTree = true;
					T54.M559().magicTree.isPeasEffect = true;
				}
				break;
			}
			case -32:
			{
				if (T51.lowGraphic && T174.mapID != 51 && T174.mapID != 103)
				{
					return;
				}
				short id4 = msg.M887().M1092();
				int num125 = msg.M887().M1094();
				sbyte[] array14 = null;
				T60 t44 = null;
				try
				{
					array14 = new sbyte[num125];
					for (int num126 = 0; num126 < num125; num126++)
					{
						array14[num126] = msg.M887().M1088();
					}
					t44 = T60.M708(array14, 0, num125);
					T10.imgNew.M1078(id4 + string.Empty, t44);
				}
				catch (Exception)
				{
					array14 = null;
					T10.imgNew.M1078(id4 + string.Empty, T60.M711(new int[1], 1, 1, bl: true));
				}
				if (array14 != null)
				{
					if (T99.zoomLevel > 1)
					{
						T138.M1534(T99.zoomLevel + "bgItem" + id4, array14);
					}
					T11.M74(id4, t44);
				}
				break;
			}
			case -31:
			{
				if (T51.lowGraphic && T174.mapID != 51)
				{
					return;
				}
				T174.vItemBg.M1120();
				short num118 = msg.M887().M1092();
				T24.M329("nItem= " + num118);
				for (int num119 = 0; num119 < num118; num119++)
				{
					T10 t40 = new T10();
					t40.id = num119;
					t40.idImage = msg.M887().M1092();
					t40.layer = msg.M887().M1088();
					t40.dx = msg.M887().M1092();
					t40.dy = msg.M887().M1092();
					sbyte b48 = msg.M887().M1088();
					t40.tileX = new int[b48];
					t40.tileY = new int[b48];
					for (int num120 = 0; num120 < b48; num120++)
					{
						t40.tileX[num119] = msg.M887().M1088();
						t40.tileY[num119] = msg.M887().M1088();
					}
					T174.vItemBg.M1111(t40);
				}
				break;
			}
			case -30:
				M315(msg);
				break;
			case -29:
				M314(msg);
				break;
			case -28:
				M313(msg);
				break;
			case -26:
				T144.testConnect = 2;
				T51.M456("SA2", 2);
				T51.M489(msg.M887().M1100());
				T66.M753();
				T90.isContinueToLogin = false;
				T13.isLoadingMap = false;
				if (T51.currentScreen == T51.loginScr)
				{
					T51.serverScreen.switchToMe();
				}
				break;
			case -25:
				T51.M456("SA3", 2);
				T54.info1.M762(msg.M887().M1100(), 0);
				break;
			case -24:
				T13.isLoadingMap = true;
				T24.M326("GET MAP INFO");
				T54.M559().magicTree = null;
				T51.isLoading = true;
				T51.M456("SA75", 2);
				T54.M538();
				T51.M488();
				T174.vGo.M1120();
				T133.vPopups.M1120();
				T110.M1062();
				T174.mapID = msg.M887().M1091();
				T174.planetID = msg.M887().M1088();
				T174.tileID = msg.M887().M1088();
				T174.bgID = msg.M887().M1088();
				T24.M326("load planet from server: " + T174.planetID + "bgType= " + T174.bgType + ".............................");
				T174.typeMap = msg.M887().M1088();
				T174.mapName = msg.M887().M1100();
				T174.zoneID = msg.M887().M1088();
				T51.M456("SA75x1", 2);
				try
				{
					T174.M1954(T174.mapID);
				}
				catch (Exception)
				{
					T146.M1594().M1688(T174.mapID);
					messWait = msg;
					return;
				}
				M311(msg);
				try
				{
					T174.isMapDouble = ((msg.M887().M1088() != 0) ? true : false);
				}
				catch (Exception)
				{
				}
				T54.cmx = T54.cmtoX;
				T54.cmy = T54.cmtoY;
				break;
			case -22:
				T51.M456("SA65", 2);
				T13.isLockKey = true;
				T13.ischangingMap = true;
				T54.M559().timeStartMap = 0;
				T54.M559().timeLengthMap = 0;
				T13.M113().mobFocus = null;
				T13.M113().npcFocus = null;
				T13.M113().charFocus = null;
				T13.M113().itemFocus = null;
				T13.M113().focus.M1120();
				T13.M113().testCharId = -9999;
				T13.M113().killCharId = -9999;
				T51.M467();
				T54.M559().M574();
				T54.M559().center = null;
				break;
			case -21:
			{
				T51.M456("SA60", 2);
				short num105 = msg.M887().M1092();
				for (int num106 = 0; num106 < T54.vItemMap.M1113(); num106++)
				{
					if (((T80)T54.vItemMap.M1114(num106)).itemMapID == num105)
					{
						T54.vItemMap.M1118(num106);
						break;
					}
				}
				break;
			}
			case -20:
			{
				T51.M456("SA61", 2);
				T13.M113().itemFocus = null;
				short num98 = msg.M887().M1092();
				for (int num99 = 0; num99 < T54.vItemMap.M1113(); num99++)
				{
					T80 t34 = (T80)T54.vItemMap.M1114(num99);
					if (t34.itemMapID != num98)
					{
						continue;
					}
					t34.M822(T13.M113().cx, T13.M113().cy - 10);
					string text6 = msg.M887().M1100();
					num = 0;
					try
					{
						num = msg.M887().M1092();
						if (t34.template.type == 9)
						{
							num = msg.M887().M1092();
							T13 t35 = T13.M113();
							t35.xu += num;
							T13.M113().xuStr = T110.M1042(T13.M113().xu);
						}
						else if (t34.template.type == 10)
						{
							num = msg.M887().M1092();
							T13 t35 = T13.M113();
							t35.luong += num;
							T13.M113().luongStr = T110.M1042(T13.M113().luong);
						}
						else if (t34.template.type == 34)
						{
							num = msg.M887().M1092();
							T13 t35 = T13.M113();
							t35.luongKhoa += num;
							T13.M113().luongKhoaStr = T110.M1042(T13.M113().luongKhoa);
						}
					}
					catch (Exception)
					{
					}
					if (text6.Equals(string.Empty))
					{
						if (t34.template.type == 9)
						{
							T54.M643(((num >= 0) ? "+" : string.Empty) + num, T13.M113().cx, T13.M113().cy - T13.M113().ch, 0, -2, T98.YELLOW);
							T160.M1826().M1836();
						}
						else if (t34.template.type == 10)
						{
							T54.M643(((num >= 0) ? "+" : string.Empty) + num, T13.M113().cx, T13.M113().cy - T13.M113().ch, 0, -2, T98.GREEN);
							T160.M1826().M1836();
						}
						else if (t34.template.type == 34)
						{
							T54.M643(((num >= 0) ? "+" : string.Empty) + num, T13.M113().cx, T13.M113().cy - T13.M113().ch, 0, -2, T98.RED);
							T160.M1826().M1836();
						}
						else
						{
							T54.info1.M762(mResources.you_receive + " " + ((num <= 0) ? string.Empty : (num + " ")) + t34.template.name, 0);
							T160.M1826().M1836();
						}
						if (num > 0 && T13.M113().petFollow != null && T13.M113().petFollow.smallID == 4683)
						{
							T143.M1571(55, T13.M113().petFollow.cmx, T13.M113().petFollow.cmy, 1);
							T143.M1571(55, T13.M113().cx, T13.M113().cy, 1);
						}
					}
					else if (text6.Length == 1)
					{
						T24.M330("strInf.Length =1:  " + text6);
					}
					else
					{
						T54.info1.M762(text6, 0);
					}
					break;
				}
				break;
			}
			case -19:
			{
				T51.M456("SA62", 2);
				short num96 = msg.M887().M1092();
				t = T54.M626(msg.M887().M1094());
				for (int num97 = 0; num97 < T54.vItemMap.M1113(); num97++)
				{
					T80 t33 = (T80)T54.vItemMap.M1114(num97);
					if (t33.itemMapID != num96)
					{
						continue;
					}
					if (t == null)
					{
						return;
					}
					t33.M822(t.cx, t.cy - 10);
					if (t33.x < t.cx)
					{
						t.cdir = -1;
					}
					else if (t33.x > t.cx)
					{
						t.cdir = 1;
					}
					break;
				}
				break;
			}
			case -18:
			{
				T51.M456("SA63", 2);
				int num95 = msg.M887().M1088();
				T54.vItemMap.M1111(new T80(msg.M887().M1092(), T13.M113().arrItemBag[num95].template.id, T13.M113().cx, T13.M113().cy, msg.M887().M1092(), msg.M887().M1092()));
				T13.M113().arrItemBag[num95] = null;
				break;
			}
			case -14:
				T51.M456("SA64", 2);
				t = T54.M626(msg.M887().M1094());
				if (t == null)
				{
					return;
				}
				T54.vItemMap.M1111(new T80(msg.M887().M1092(), msg.M887().M1092(), t.cx, t.cy, msg.M887().M1092(), msg.M887().M1092()));
				break;
			case -4:
			{
				T51.M456("SA76", 2);
				t = T54.M626(msg.M887().M1094());
				if (t == null)
				{
					return;
				}
				T51.M456("SA76v1", 2);
				if ((T174.M1957(t.cx, t.cy) & 2) == 2)
				{
					t.M172(T54.sks[msg.M887().M1091()], 0);
				}
				else
				{
					t.M172(T54.sks[msg.M887().M1091()], 1);
				}
				T51.M456("SA76v2", 2);
				t.attMobs = new T101[msg.M887().M1088()];
				for (int num72 = 0; num72 < t.attMobs.Length; num72++)
				{
					T101 t27 = (T101)T54.vMob.M1114(msg.M887().M1088());
					t.attMobs[num72] = t27;
					if (num72 == 0)
					{
						if (t.cx <= t27.x)
						{
							t.cdir = 1;
						}
						else
						{
							t.cdir = -1;
						}
					}
				}
				T51.M456("SA76v3", 2);
				t.charFocus = null;
				t.mobFocus = t.attMobs[0];
				T13[] array5 = new T13[10];
				num = 0;
				try
				{
					for (num = 0; num < array5.Length; num++)
					{
						int num73 = msg.M887().M1094();
						T13 t28 = (array5[num] = ((num73 != T13.M113().charID) ? T54.M626(num73) : T13.M113()));
						if (num == 0)
						{
							if (t.cx <= t28.cx)
							{
								t.cdir = 1;
							}
							else
							{
								t.cdir = -1;
							}
						}
					}
				}
				catch (Exception ex8)
				{
					T24.M326("Loi PLAYER_ATTACK_N_P " + ex8.ToString());
				}
				T51.M456("SA76v4", 2);
				if (num > 0)
				{
					t.attChars = new T13[num];
					for (num = 0; num < t.attChars.Length; num++)
					{
						t.attChars[num] = array5[num];
					}
					t.charFocus = t.attChars[0];
					t.mobFocus = null;
				}
				T51.M456("SA76v5", 2);
				break;
			}
			case 1:
			{
				bool flag4 = msg.M887().M1096();
				T137.M1513("isRes= " + flag4);
				if (!flag4)
				{
					T51.M489(msg.M887().M1100());
					break;
				}
				T51.loginScr.isLogin2 = false;
				T138.M1538("userAo" + T144.ipSelect, string.Empty);
				T51.M488();
				T51.loginScr.M861();
				break;
			}
			case 2:
				T13.isLoadingMap = true;
				T90.isLoggingIn = false;
				if (!T54.isLoadAllData)
				{
					T54.M559().M532();
				}
				T10.M65();
				T51.M488();
				T26.isCreateChar = true;
				T26.M344().switchToMe();
				break;
			case 6:
				T51.M456("SA70", 2);
				T13.M113().xu = msg.M887().M1095();
				T13.M113().luong = msg.M887().M1094();
				T13.M113().luongKhoa = msg.M887().M1094();
				T13.M113().xuStr = T110.M1042(T13.M113().xu);
				T13.M113().luongStr = T110.M1042(T13.M113().luong);
				T13.M113().luongKhoaStr = T110.M1042(T13.M113().luongKhoa);
				T51.M488();
				break;
			case 7:
			{
				sbyte type2 = msg.M887().M1088();
				short id2 = msg.M887().M1092();
				string info2 = msg.M887().M1100();
				T51.panel.M1425(type2, info2, id2);
				break;
			}
			case 11:
			{
				T51.M456("SA9", 2);
				int num35 = msg.M887().M1088();
				sbyte b21 = msg.M887().M1088();
				if (b21 != 0)
				{
					T101.arrMobTemplate[num35].data.M400(T122.M1185(msg), b21);
				}
				else
				{
					T101.arrMobTemplate[num35].data.M399(T122.M1185(msg));
				}
				for (int num36 = 0; num36 < T54.vMob.M1113(); num36++)
				{
					t2 = (T101)T54.vMob.M1114(num36);
					if (t2.templateId == num35)
					{
						t2.w = T101.arrMobTemplate[num35].data.width;
						t2.h = T101.arrMobTemplate[num35].data.height;
					}
				}
				sbyte[] array3 = T122.M1185(msg);
				T60 img = T60.M708(array3, 0, array3.Length);
				T101.arrMobTemplate[num35].data.img = img;
				int num37 = msg.M887().M1088();
				T101.arrMobTemplate[num35].data.typeData = num37;
				if (num37 == 1 || num37 == 2)
				{
					M321(msg, num35);
				}
				break;
			}
			case 20:
				M323(msg);
				break;
			case 24:
				M325(msg);
				break;
			case 27:
			{
				t3 = new T117();
				msg.M887().M1100();
				int num32 = msg.M887().M1088();
				for (int num33 = 0; num33 < num32; num33++)
				{
					t3.M1111(new T22(msg.M887().M1100(), p: msg.M887().M1092(), actionListener: T51.instance, action: 88819));
				}
				T51.menu.M875(t3, 3);
				break;
			}
			case 29:
				T51.M456("SA58", 2);
				T54.M559().M665(msg);
				break;
			case 32:
			{
				T51.M456("SA68", 2);
				int num151 = msg.M887().M1092();
				for (int num152 = 0; num152 < T54.vNpc.M1113(); num152++)
				{
					T123 t52 = (T123)T54.vNpc.M1114(num152);
					if (t52.template.npcTemplateId == num151 && t52.Equals(T13.M113().npcFocus))
					{
						string chat2 = msg.M887().M1100();
						string[] array16 = new string[msg.M887().M1088()];
						for (int num153 = 0; num153 < array16.Length; num153++)
						{
							array16[num153] = msg.M887().M1100();
						}
						T54.M559().M553(array16, t52);
						T14.M271(chat2, 100000, t52);
						return;
					}
				}
				T123 t53 = new T123(num151, 0, -100, 100, num151, T54.info1.charId[T13.M113().cgender][2]);
				T137.M1513((T13.M113().npcFocus == null) ? "null" : "!null");
				string chat3 = msg.M887().M1100();
				string[] array17 = new string[msg.M887().M1088()];
				for (int num154 = 0; num154 < array17.Length; num154++)
				{
					array17[num154] = msg.M887().M1100();
				}
				try
				{
					t53.avatar = msg.M887().M1092();
				}
				catch (Exception)
				{
				}
				T137.M1513((T13.M113().npcFocus == null) ? "null" : "!null");
				T54.M559().M553(array17, t53);
				T14.M271(chat3, 100000, t53);
				break;
			}
			case 33:
			{
				T51.M456("SA51", 2);
				T66.M753();
				T51.M484();
				T51.M483();
				t3 = new T117();
				try
				{
					while (true)
					{
						t3.M1111(new T22(msg.M887().M1100(), T51.instance, 88822, null));
					}
				}
				catch (Exception ex19)
				{
					T24.M326("Loi OPEN_UI_MENU " + ex19.ToString());
				}
				if (T13.M113().npcFocus == null)
				{
					return;
				}
				for (int num133 = 0; num133 < T13.M113().npcFocus.template.menu.Length; num133++)
				{
					string[] array15 = T13.M113().npcFocus.template.menu[num133];
					t3.M1111(new T22(array15[0], T51.instance, 88820, array15));
				}
				T51.menu.M877(t3, 3);
				break;
			}
			case 38:
			{
				T51.M456("SA67", 2);
				T66.M753();
				int num127 = msg.M887().M1092();
				T137.M1513("OPEN_UI_SAY ID= " + num127);
				string chat = T137.M1518(msg.M887().M1100());
				for (int num128 = 0; num128 < T54.vNpc.M1113(); num128++)
				{
					T123 t45 = (T123)T54.vNpc.M1114(num128);
					T137.M1513("npc id= " + t45.template.npcTemplateId);
					if (t45.template.npcTemplateId == num127)
					{
						T14.M269(chat, 100000, t45);
						T51.panel.M1381();
						return;
					}
				}
				T123 t46 = new T123(num127, 0, 0, 0, num127, T54.info1.charId[T13.M113().cgender][2]);
				if (t46.template.npcTemplateId == 5)
				{
					t46.charID = 5;
				}
				try
				{
					t46.avatar = msg.M887().M1092();
				}
				catch (Exception)
				{
				}
				T14.M269(chat, 100000, t46);
				T51.panel.M1381();
				break;
			}
			case 39:
				T51.M456("SA49", 2);
				T54.M559().typeTradeOrder = 2;
				if (T54.M559().typeTrade >= 2 && T54.M559().typeTradeOrder >= 2)
				{
					T66.M749();
				}
				break;
			case 40:
			{
				T51.M456("SA52", 2);
				T51.taskTick = 150;
				short taskId = msg.M887().M1092();
				sbyte index4 = msg.M887().M1088();
				string name = T137.M1518(msg.M887().M1100());
				string detail = T137.M1518(msg.M887().M1100());
				string[] array11 = new string[msg.M887().M1088()];
				string[] array12 = new string[array11.Length];
				T54.tasks = new int[array11.Length];
				T54.mapTasks = new int[array11.Length];
				short[] array13 = new short[array11.Length];
				short count = -1;
				for (int num116 = 0; num116 < array11.Length; num116++)
				{
					string text7 = T137.M1518(msg.M887().M1100());
					T54.tasks[num116] = msg.M887().M1088();
					T54.mapTasks[num116] = msg.M887().M1092();
					string text8 = T137.M1518(msg.M887().M1100());
					array13[num116] = -1;
					if (!text7.Equals(string.Empty))
					{
						array11[num116] = text7;
						array12[num116] = text8;
					}
				}
				try
				{
					count = msg.M887().M1092();
					for (int num117 = 0; num117 < array11.Length; num117++)
					{
						array13[num117] = msg.M887().M1092();
					}
				}
				catch (Exception ex16)
				{
					T24.M326("Loi TASK_GET " + ex16.ToString());
				}
				T13.M113().taskMaint = new T168(taskId, index4, name, detail, array11, array13, count, array12);
				if (T13.M113().npcFocus != null)
				{
					T123.M1196();
				}
				T13.M106(isNextStep: false);
				break;
			}
			case 41:
			{
				T51.M456("SA53", 2);
				T51.taskTick = 100;
				T137.M1513("TASK NEXT");
				T168 taskMaint = T13.M113().taskMaint;
				taskMaint.index++;
				T13.M113().taskMaint.count = 0;
				T123.M1196();
				T13.M106(isNextStep: true);
				break;
			}
			case 43:
				T51.taskTick = 50;
				T51.M456("SA55", 2);
				T13.M113().taskMaint.count = msg.M887().M1092();
				if (T13.M113().npcFocus != null)
				{
					T123.M1196();
				}
				break;
			case 46:
				T51.M456("SA5", 2);
				T24.M331("Controler RESET_POINT  " + T13.ischangingMap);
				T13.isLockKey = false;
				T13.M113().M132(msg.M887().M1092(), msg.M887().M1092());
				break;
			case 47:
				T51.M456("SA4", 2);
				T54.M559().M574();
				break;
			case 50:
			{
				sbyte b46 = msg.M887().M1088();
				T126.vGameInfo.M1120();
				for (int num114 = 0; num114 < b46; num114++)
				{
					T204 t38 = new T204();
					t38.id = msg.M887().M1092();
					t38.main = msg.M887().M1100();
					t38.content = msg.M887().M1100();
					T126.vGameInfo.M1111(t38);
					t38.hasRead = T138.M1542(t38.id + string.Empty) != -1;
				}
				break;
			}
			case 54:
			{
				t = T54.M626(msg.M887().M1094());
				if (t == null)
				{
					return;
				}
				int num104 = msg.M887().M1091();
				if ((T174.M1957(t.cx, t.cy) & 2) == 2)
				{
					t.M172(T54.sks[num104], 0);
				}
				else
				{
					t.M172(T54.sks[num104], 1);
				}
				T51.M456("SA769991v2", 2);
				T101[] array9 = new T101[10];
				num = 0;
				try
				{
					T51.M456("SA769991v3", 2);
					for (num = 0; num < array9.Length; num++)
					{
						T51.M456("SA769991v4-num" + num, 2);
						T101 t37 = (array9[num] = (T101)T54.vMob.M1114(msg.M887().M1088()));
						if (num == 0)
						{
							if (t.cx <= t37.x)
							{
								t.cdir = 1;
							}
							else
							{
								t.cdir = -1;
							}
						}
						T51.M456("SA769991v5-num" + num, 2);
					}
				}
				catch (Exception ex12)
				{
					T24.M326("Loi PLAYER_ATTACK_NPC " + ex12.ToString());
				}
				T51.M456("SA769992", 2);
				if (num > 0)
				{
					t.attMobs = new T101[num];
					for (num = 0; num < t.attMobs.Length; num++)
					{
						t.attMobs[num] = array9[num];
					}
					t.charFocus = null;
					t.mobFocus = t.attMobs[0];
				}
				break;
			}
			case 56:
			{
				T51.M456("SXX6", 2);
				t = null;
				int num63 = msg.M887().M1094();
				if (num63 == T13.M113().charID)
				{
					bool flag5 = false;
					t = T13.M113();
					t.cHP = msg.M889();
					int num64 = msg.M889();
					T137.M1513("dame hit = " + num64);
					if (num64 != 0)
					{
						t.M219();
					}
					int num65 = 0;
					try
					{
						flag5 = msg.M887().M1097();
						sbyte b31 = msg.M887().M1088();
						if (b31 != -1)
						{
							T137.M1513("hit eff= " + b31);
							T31.M376(new T32(b31, t.cx, t.cy, 3, 1, -1));
						}
					}
					catch (Exception)
					{
					}
					num64 += num65;
					if (T13.M113().cTypePk != 4)
					{
						if (num64 == 0)
						{
							T54.M643(mResources.miss, t.cx, t.cy - t.ch, 0, -3, T98.MISS_ME);
						}
						else
						{
							T54.M643("-" + num64, t.cx, t.cy - t.ch, 0, -3, flag5 ? T98.FATAL : T98.RED);
						}
					}
					break;
				}
				t = T54.M626(num63);
				if (t == null)
				{
					return;
				}
				t.cHP = msg.M889();
				bool flag6 = false;
				int num66 = msg.M889();
				if (num66 != 0)
				{
					t.M219();
				}
				int num67 = 0;
				try
				{
					flag6 = msg.M887().M1097();
					sbyte b32 = msg.M887().M1088();
					if (b32 != -1)
					{
						T137.M1513("hit eff= " + b32);
						T31.M376(new T32(b32, t.cx, t.cy, 3, 1, -1));
					}
				}
				catch (Exception)
				{
				}
				num66 += num67;
				if (t.cTypePk != 4)
				{
					if (num66 == 0)
					{
						T54.M643(mResources.miss, t.cx, t.cy - t.ch, 0, -3, T98.MISS);
					}
					else
					{
						T54.M643("-" + num66, t.cx, t.cy - t.ch, 0, -3, flag6 ? T98.FATAL : T98.ORANGE);
					}
				}
				break;
			}
			case 57:
			{
				T51.M456("SZ6", 2);
				T117 t26 = new T117();
				t26.M1111(new T22(msg.M887().M1100(), T51.instance, 88817, null));
				T51.menu.M877(t26, 3);
				break;
			}
			case 58:
			{
				T51.M456("SZ7", 2);
				int num58 = msg.M887().M1094();
				T13 t20 = ((num58 != T13.M113().charID) ? T54.M626(num58) : T13.M113());
				t20.moveFast = new short[3];
				t20.moveFast[0] = 0;
				short num59 = msg.M887().M1092();
				short num60 = msg.M887().M1092();
				t20.moveFast[1] = num59;
				t20.moveFast[2] = num60;
				try
				{
					num58 = msg.M887().M1094();
					T13 t21 = ((num58 != T13.M113().charID) ? T54.M626(num58) : T13.M113());
					t21.cx = num59;
					t21.cy = num60;
				}
				catch (Exception ex5)
				{
					T24.M326("Loi MOVE_FAST " + ex5.ToString());
				}
				break;
			}
			case 62:
				T51.M456("SZ3", 2);
				t = T54.M626(msg.M887().M1094());
				if (t != null)
				{
					t.killCharId = T13.M113().charID;
					T13.M113().npcFocus = null;
					T13.M113().mobFocus = null;
					T13.M113().itemFocus = null;
					T13.M113().charFocus = t;
					T13.isManualFocus = true;
					T54.info1.M762(t.cName + mResources.CUU_SAT, 0);
				}
				break;
			case 63:
				T51.M456("SZ4", 2);
				T13.M113().killCharId = msg.M887().M1094();
				T13.M113().npcFocus = null;
				T13.M113().mobFocus = null;
				T13.M113().itemFocus = null;
				T13.M113().charFocus = T54.M626(T13.M113().killCharId);
				T13.isManualFocus = true;
				break;
			case 64:
				T51.M456("SZ5", 2);
				t = T13.M113();
				try
				{
					t = T54.M626(msg.M887().M1094());
				}
				catch (Exception ex4)
				{
					T24.M326("Loi CLEAR_CUU_SAT " + ex4.ToString());
				}
				t.killCharId = -9999;
				break;
			case 65:
			{
				sbyte id = msg.M887().M1086();
				string text4 = msg.M887().M1100();
				short num49 = msg.M887().M1092();
				if (T86.M841(id))
				{
					if (num49 != 0)
					{
						T86.M840(id).M837(id, text4, num49);
					}
					else
					{
						T54.textTime.M1119(T86.M840(id));
					}
				}
				else
				{
					T86 t19 = new T86();
					t19.M837(id, text4, num49);
					T54.textTime.M1111(t19);
				}
				break;
			}
			case 66:
				M318(msg);
				break;
			case 68:
			{
				T137.M1513("ADD ITEM TO MAP --------------------------------------");
				T51.M456("SA6333", 2);
				short itemMapID = msg.M887().M1092();
				short itemTemplateID = msg.M887().M1092();
				int x = msg.M887().M1092();
				int y = msg.M887().M1092();
				int num47 = msg.M887().M1094();
				short r = 0;
				if (num47 == -2)
				{
					r = msg.M887().M1092();
				}
				T80 o = new T80(num47, itemMapID, itemTemplateID, x, y, r);
				T54.vItemMap.M1111(o);
				break;
			}
			case 81:
				T51.M456("SXX4", 2);
				((T101)T54.vMob.M1114(msg.M887().M1091())).isDisable = msg.M887().M1096();
				break;
			case 82:
				T51.M456("SXX5", 2);
				((T101)T54.vMob.M1114(msg.M887().M1091())).isDontMove = msg.M887().M1096();
				break;
			case 83:
			{
				T51.M456("SXX8", 2);
				int num34 = msg.M887().M1094();
				t = ((num34 != T13.M113().charID) ? T54.M626(num34) : T13.M113());
				if (t == null)
				{
					return;
				}
				T101 mobToAttack = (T101)T54.vMob.M1114(msg.M887().M1091());
				if (t.mobMe != null)
				{
					t.mobMe.M1004(mobToAttack);
				}
				break;
			}
			case 84:
			{
				int num23 = msg.M887().M1094();
				if (num23 == T13.M113().charID)
				{
					t = T13.M113();
				}
				else
				{
					t = T54.M626(num23);
					if (t == null)
					{
						return;
					}
				}
				t.cHP = t.cHPFull;
				t.cMP = t.cMPFull;
				t.cx = msg.M887().M1092();
				t.cy = msg.M887().M1092();
				t.M222();
				break;
			}
			case 85:
				T51.M456("SXX5", 2);
				((T101)T54.vMob.M1114(msg.M887().M1091())).isFire = msg.M887().M1096();
				break;
			case 86:
			{
				T51.M456("SXX5", 2);
				T101 t13 = (T101)T54.vMob.M1114(msg.M887().M1091());
				t13.isIce = msg.M887().M1096();
				if (!t13.isIce)
				{
					T143.M1571(77, t13.x, t13.y - 9, 1);
				}
				break;
			}
			case 87:
				T51.M456("SXX5", 2);
				((T101)T54.vMob.M1114(msg.M887().M1091())).isWind = msg.M887().M1096();
				break;
			case 88:
			{
				string info = msg.M887().M1100();
				short num22 = msg.M887().M1092();
				T51.inputDlg.M777(info, new T22(mResources.ACCEPT, T51.instance, 88818, num22), T173.INPUT_TYPE_ANY);
				break;
			}
			case 90:
				T51.M456("SA577", 2);
				M302(msg);
				break;
			case 92:
			{
				if (T51.currentScreen == T54.instance)
				{
					T51.M488();
				}
				string text = msg.M887().M1100();
				string text2 = T137.M1518(msg.M887().M1100());
				string empty = string.Empty;
				T13 t4 = null;
				sbyte b = 0;
				if (!text.Equals(string.Empty))
				{
					t4 = new T13();
					t4.charID = msg.M887().M1094();
					t4.head = msg.M887().M1092();
					t4.headICON = msg.M887().M1092();
					t4.body = msg.M887().M1092();
					t4.bag = msg.M887().M1092();
					t4.leg = msg.M887().M1092();
					b = msg.M887().M1088();
					t4.cName = text;
				}
				empty += text2;
				T66.M753();
				if (text.Equals(string.Empty))
				{
					T54.info1.M762(empty, 0);
					break;
				}
				T54.info2.M761(empty, t4, b == 0);
				if (T51.panel.isShow && T51.panel.type == 8)
				{
					T51.panel.M1315();
				}
				break;
			}
			case 94:
				T51.M456("SA3", 2);
				T54.info1.M762(msg.M887().M1100(), 0);
				break;
			}
			switch (msg.command)
			{
			case -73:
			{
				sbyte b63 = msg.M887().M1088();
				for (int num175 = 0; num175 < T54.vNpc.M1113(); num175++)
				{
					T123 t71 = (T123)T54.vNpc.M1114(num175);
					if (t71.template.npcTemplateId == b63)
					{
						if (msg.M887().M1088() == 0)
						{
							t71.isHide = true;
						}
						else
						{
							t71.isHide = false;
						}
						break;
					}
				}
				break;
			}
			case -75:
			{
				T101 t64 = null;
				try
				{
					t64 = (T101)T54.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
				}
				if (t64 != null)
				{
					t64.levelBoss = msg.M887().M1088();
					if (t64.levelBoss > 0)
					{
						t64.typeSuperEff = T137.M1522(0, 3);
					}
				}
				break;
			}
			case 19:
				T13.M113().countKill = msg.M887().M1093();
				T13.M113().countKillMax = msg.M887().M1093();
				break;
			case 18:
			{
				sbyte b61 = msg.M887().M1088();
				for (int num164 = 0; num164 < b61; num164++)
				{
					int charId = msg.M887().M1094();
					int cx = msg.M887().M1092();
					int cy = msg.M887().M1092();
					int cHPShow = msg.M889();
					T13 t63 = T54.M626(charId);
					if (t63 != null)
					{
						t63.cx = cx;
						t63.cy = cy;
						t63.cHP = (t63.cHPShow = cHPShow);
						t63.lastUpdateTime = T110.M1054();
					}
				}
				break;
			}
			case -17:
				T51.M456("SA88", 2);
				T13.M113().meDead = true;
				T13.M113().cPk = msg.M887().M1088();
				T13.M113().M220(msg.M887().M1092(), msg.M887().M1092());
				try
				{
					T13.M113().cPower = msg.M887().M1095();
					T13.M113().M103();
				}
				catch (Exception)
				{
					T24.M326("Loi tai ME_DIE " + msg.command);
				}
				T13.M113().countKill = 0;
				break;
			case -16:
				T51.M456("SA90", 2);
				if (T13.M113().wdx != 0 || T13.M113().wdy != 0)
				{
					T13.M113().cx = T13.M113().wdx;
					T13.M113().cy = T13.M113().wdy;
					T13 t59 = T13.M113();
					T13.M113().wdy = 0;
					t59.wdx = 0;
				}
				T13.M113().M222();
				T13.M113().isLockMove = false;
				T13.M113().meDead = false;
				break;
			case -13:
			{
				T51.M456("SA82", 2);
				int num162 = msg.M887().M1091();
				if (num162 <= T54.vMob.M1113() - 1 && num162 >= 0)
				{
					T101 t62 = (T101)T54.vMob.M1114(num162);
					t62.sys = msg.M887().M1088();
					t62.levelBoss = msg.M887().M1088();
					if (t62.levelBoss != 0)
					{
						t62.typeSuperEff = T137.M1522(0, 3);
					}
					t62.x = t62.xFirst;
					t62.y = t62.yFirst;
					t62.status = 5;
					t62.injureThenDie = false;
					t62.hp = msg.M887().M1094();
					t62.maxHp = t62.hp;
					T143.M1571(60, t62.x, t62.y, 1);
					break;
				}
				return;
			}
			case -12:
			{
				T137.M1513("SERVER SEND MOB DIE");
				T51.M456("SA85", 2);
				T101 t65 = null;
				try
				{
					t65 = (T101)T54.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
					T24.M326("LOi tai NPC_DIE cmd " + msg.command);
				}
				if (t65 == null || t65.status == 0 || t65.status == 0)
				{
					break;
				}
				t65.M1003();
				try
				{
					int num166 = msg.M889();
					if (msg.M887().M1096())
					{
						T54.M643("-" + num166, t65.x, t65.y - t65.h, 0, -2, T98.FATAL);
					}
					else
					{
						T54.M643("-" + num166, t65.x, t65.y - t65.h, 0, -2, T98.ORANGE);
					}
					sbyte b62 = msg.M887().M1088();
					for (int num167 = 0; num167 < b62; num167++)
					{
						T80 t66 = new T80(msg.M887().M1092(), msg.M887().M1092(), t65.x, t65.y, msg.M887().M1092(), msg.M887().M1092());
						int num168 = (t66.playerId = msg.M887().M1094());
						T137.M1513("playerid= " + num168 + " my id= " + T13.M113().charID);
						T54.vItemMap.M1111(t66);
						if (T137.M1529(t66.y - T13.M113().cy) < 24 && T137.M1529(t66.x - T13.M113().cx) < 24)
						{
							T13.M113().charFocus = null;
						}
					}
				}
				catch (Exception ex30)
				{
					T24.M326("LOi tai NPC_DIE " + ex30.ToString() + " cmd " + msg.command);
				}
				break;
			}
			case -11:
			{
				T51.M456("SA86", 2);
				T101 t67 = null;
				try
				{
					byte index5 = msg.M887().M1091();
					t67 = (T101)T54.vMob.M1114(index5);
				}
				catch (Exception)
				{
					T24.M326("Loi tai NPC_ATTACK_ME " + msg.command);
				}
				if (t67 != null)
				{
					T13.M113().isDie = false;
					T13.isLockKey = false;
					int num169 = msg.M889();
					int num170;
					try
					{
						num170 = msg.M889();
					}
					catch (Exception)
					{
						num170 = 0;
					}
					if (t67.isBusyAttackSomeOne)
					{
						T13.M113().M218(num169, num170, isCrit: false, isMob: true);
						break;
					}
					t67.dame = num169;
					t67.dameMp = num170;
					t67.M990(T13.M113());
				}
				break;
			}
			case -10:
			{
				T51.M456("SA87", 2);
				T101 t60 = null;
				try
				{
					t60 = (T101)T54.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
				}
				T51.M456("SA87x1", 2);
				if (t60 != null)
				{
					T51.M456("SA87x2", 2);
					t = T54.M626(msg.M887().M1094());
					if (t == null)
					{
						return;
					}
					T51.M456("SA87x3", 2);
					int num160 = msg.M889();
					t60.dame = t.cHP - num160;
					t.cHPNew = num160;
					T51.M456("SA87x4", 2);
					try
					{
						t.cMP = msg.M889();
					}
					catch (Exception)
					{
					}
					T51.M456("SA87x5", 2);
					if (t60.isBusyAttackSomeOne)
					{
						t.M218(t60.dame, 0, isCrit: false, isMob: true);
					}
					else
					{
						t60.M990(t);
					}
					T51.M456("SA87x6", 2);
				}
				break;
			}
			case -9:
			{
				T51.M456("SA83", 2);
				T101 t58 = null;
				try
				{
					t58 = (T101)T54.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
				}
				T51.M456("SA83v1", 2);
				if (t58 != null)
				{
					t58.hp = msg.M889();
					int num158 = msg.M889();
					if (num158 == 1)
					{
						return;
					}
					bool flag9 = false;
					try
					{
						flag9 = msg.M887().M1097();
					}
					catch (Exception)
					{
					}
					sbyte b58 = msg.M887().M1088();
					if (b58 != -1)
					{
						T31.M376(new T32(b58, t58.x, t58.getY(), 3, 1, -1));
					}
					T51.M456("SA83v2", 2);
					if (flag9)
					{
						T54.M643("-" + num158, t58.x, t58.getY() - t58.getH(), 0, -2, T98.FATAL);
					}
					else if (num158 == 0)
					{
						t58.x = t58.xFirst;
						t58.y = t58.yFirst;
						T54.M643(mResources.miss, t58.x, t58.getY() - t58.getH(), 0, -2, T98.MISS);
					}
					else
					{
						T54.M643("-" + num158, t58.x, t58.getY() - t58.getH(), 0, -2, T98.ORANGE);
					}
				}
				T51.M456("SA83v3", 2);
				break;
			}
			case -8:
				T51.M456("SA89", 2);
				t = T54.M626(msg.M887().M1094());
				if (t == null)
				{
					return;
				}
				t.cPk = msg.M887().M1088();
				t.M221(msg.M887().M1092(), msg.M887().M1092());
				break;
			case -7:
			{
				T51.M456("SA80", 2);
				int num173 = msg.M887().M1094();
				T24.M326("RECEVED MOVE OF " + num173);
				for (int num174 = 0; num174 < T54.vCharInMap.M1113(); num174++)
				{
					T13 t70 = null;
					try
					{
						t70 = (T13)T54.vCharInMap.M1114(num174);
					}
					catch (Exception ex35)
					{
						T24.M326("Loi PLAYER_MOVE " + ex35.ToString());
					}
					if (t70 != null)
					{
						if (t70.charID == num173)
						{
							T51.M456("SA8x2y" + num174, 2);
							t70.M202(msg.M887().M1092(), msg.M887().M1092(), 0);
							t70.lastUpdateTime = T110.M1054();
							break;
						}
						continue;
					}
					break;
				}
				T51.M456("SA80x3", 2);
				break;
			}
			case -6:
			{
				T51.M456("SA81", 2);
				int num171 = msg.M887().M1094();
				for (int num172 = 0; num172 < T54.vCharInMap.M1113(); num172++)
				{
					T13 t68 = (T13)T54.vCharInMap.M1114(num172);
					if (t68 != null && t68.charID == num171)
					{
						if (!t68.isInvisiblez && !t68.isUsePlane)
						{
							T143.M1571(60, t68.cx, t68.cy, 1);
						}
						if (!t68.isUsePlane)
						{
							T54.vCharInMap.M1118(num172);
						}
						return;
					}
				}
				break;
			}
			case -5:
			{
				T51.M456("SA79", 2);
				int charID = msg.M887().M1094();
				int num155 = msg.M887().M1094();
				T13 t56;
				if (num155 != -100)
				{
					t56 = new T13();
					t56.charID = charID;
					t56.clanID = num155;
				}
				else
				{
					t56 = new T206();
					t56.charID = charID;
					t56.clanID = num155;
				}
				if (t56.clanID == -2)
				{
					t56.isCopy = true;
				}
				if (M317(t56, msg))
				{
					sbyte b57 = msg.M887().M1088();
					if (t56.cy <= 10 && b57 != 0 && b57 != 2)
					{
						T137.M1513("nhân vật bay trên trời xuống x= " + t56.cx + " y= " + t56.cy);
						T171 t10 = new T171(t56.cx, t56.cy, t56.head, t56.cdir, 1, isMe: false, (b57 != 1) ? b57 : t56.cgender);
						t10.id = t56.charID;
						T171 p3 = t10;
						t56.isTeleport = true;
						T171.M1894(p3);
					}
					if (b57 == 2)
					{
						t56.M140();
					}
					for (int num156 = 0; num156 < T54.vMob.M1113(); num156++)
					{
						T101 t57 = (T101)T54.vMob.M1114(num156);
						if (t57 != null && t57.isMobMe && t57.mobId == t56.charID)
						{
							T137.M1513("co 1 con quai");
							t56.mobMe = t57;
							t56.mobMe.x = t56.cx;
							t56.mobMe.y = t56.cy - 40;
							break;
						}
					}
					if (T54.M626(t56.charID) == null)
					{
						T54.vCharInMap.M1111(t56);
					}
					t56.isMonkey = msg.M887().M1088();
					short num157 = msg.M887().M1092();
					T137.M1513("mount id= " + num157 + "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
					if (num157 != -1)
					{
						t56.isHaveMount = true;
						switch (num157)
						{
						case 349:
						case 350:
						case 351:
							t56.isMountVip = true;
							break;
						case 346:
						case 347:
						case 348:
							t56.isMountVip = false;
							break;
						default:
							if (num157 >= T13.ID_NEW_MOUNT)
							{
								t56.idMount = num157;
							}
							break;
						case 532:
							t56.isSpeacialMount = true;
							break;
						case 396:
							t56.isEventMount = true;
							break;
						}
					}
					else
					{
						t56.isHaveMount = false;
					}
				}
				sbyte cFlag = msg.M887().M1088();
				T137.M1513("addplayer:   " + cFlag);
				t56.cFlag = cFlag;
				t56.isNhapThe = msg.M887().M1088() == 1;
				try
				{
					t56.idAuraEff = msg.M887().M1092();
					t56.idEff_Set_Item = msg.M887().M1086();
					t56.idHat = msg.M887().M1092();
				}
				catch (Exception)
				{
				}
				T54.M559().M671(t56.charID, t56.cFlag);
				break;
			}
			case -3:
			{
				T51.M456("SA78", 2);
				sbyte b59 = msg.M887().M1088();
				int num159 = msg.M887().M1094();
				if (b59 == 0)
				{
					T13 t35 = T13.M113();
					t35.cPower += num159;
				}
				if (b59 == 1)
				{
					T13 t35 = T13.M113();
					t35.cTiemNang += num159;
				}
				if (b59 == 2)
				{
					T13 t35 = T13.M113();
					t35.cPower += num159;
					t35 = T13.M113();
					t35.cTiemNang += num159;
				}
				T13.M113().M103();
				if (T13.M113().cTypePk != 3)
				{
					T54.M643(((num159 <= 0) ? string.Empty : "+") + num159, T13.M113().cx, T13.M113().cy - T13.M113().ch, 0, -4, T98.GREEN);
					if (num159 > 0 && T13.M113().petFollow != null && T13.M113().petFollow.smallID == 5002)
					{
						T143.M1571(55, T13.M113().petFollow.cmx, T13.M113().petFollow.cmy, 1);
						T143.M1571(55, T13.M113().cx, T13.M113().cy, 1);
					}
				}
				break;
			}
			case -2:
			{
				T51.M456("SA77", 22);
				int num177 = msg.M887().M1094();
				T13 t35 = T13.M113();
				t35.yen += num177;
				T54.M643((num177 <= 0) ? (string.Empty + num177) : ("+" + num177), T13.M113().cx, T13.M113().cy - T13.M113().ch - 10, 0, -2, T98.YELLOW);
				break;
			}
			case -1:
			{
				T51.M456("SA77", 222);
				int num176 = msg.M887().M1094();
				T13 t35 = T13.M113();
				t35.xu += num176;
				T13.M113().xuStr = T110.M1042(T13.M113().xu);
				t35 = T13.M113();
				t35.yen -= num176;
				T54.M643("+" + num176, T13.M113().cx, T13.M113().cy - T13.M113().ch - 10, 0, -2, T98.YELLOW);
				break;
			}
			case 45:
			{
				T51.M456("SA84", 2);
				T101 t69 = null;
				try
				{
					t69 = (T101)T54.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception ex34)
				{
					T24.M326("Loi tai NPC_MISS  " + ex34.ToString());
				}
				if (t69 != null)
				{
					t69.hp = msg.M887().M1094();
					T54.M643(mResources.miss, t69.x, t69.y - t69.h, 0, -2, T98.MISS);
				}
				break;
			}
			case 44:
			{
				T51.M456("SA91", 2);
				int num165 = msg.M887().M1094();
				string text9 = msg.M887().M1100();
				T137.M1513("user id= " + num165 + " text= " + text9);
				t = ((T13.M113().charID != num165) ? T54.M626(num165) : T13.M113());
				if (t == null)
				{
					return;
				}
				t.M111(text9);
				break;
			}
			case 95:
			{
				T51.M456("SA77", 22);
				int num163 = msg.M887().M1094();
				T13 t35 = T13.M113();
				t35.xu += num163;
				T13.M113().xuStr = T110.M1042(T13.M113().xu);
				T54.M643((num163 <= 0) ? (string.Empty + num163) : ("+" + num163), T13.M113().cx, T13.M113().cy - T13.M113().ch - 10, 0, -2, T98.YELLOW);
				break;
			}
			case 96:
				T51.M456("SA77a", 22);
				T13.M113().taskOrders.M1111(new T169(msg.M887().M1088(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1100(), msg.M887().M1100(), msg.M887().M1088(), msg.M887().M1088()));
				break;
			case 97:
			{
				sbyte b60 = msg.M887().M1088();
				for (int num161 = 0; num161 < T13.M113().taskOrders.M1113(); num161++)
				{
					T169 t61 = (T169)T13.M113().taskOrders.M1114(num161);
					if (t61.taskId == b60)
					{
						t61.count = msg.M887().M1092();
						break;
					}
				}
				break;
			}
			case 74:
			{
				T51.M456("SA85", 2);
				T101 t54 = null;
				try
				{
					t54 = (T101)T54.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
					T24.M326("Loi tai NPC CHANGE " + msg.command);
				}
				if (t54 != null && t54.status != 0 && t54.status != 0)
				{
					t54.status = 0;
					T143.M1571(60, t54.x, t54.y, 1);
					T80 t55 = new T80(msg.M887().M1092(), msg.M887().M1092(), t54.x, t54.y, msg.M887().M1092(), msg.M887().M1092());
					T54.vItemMap.M1111(t55);
					if (T137.M1529(t55.y - T13.M113().cy) < 24 && T137.M1529(t55.x - T13.M113().cx) < 24)
					{
						T13.M113().charFocus = null;
					}
				}
				break;
			}
			case 66:
				T137.M1513("ME DIE XP DOWN NOT IMPLEMENT YET!!!!!!!!!!!!!!!!!!!!!!!!!!");
				break;
			}
			T51.M456("SA92", 2);
		}
		catch (Exception)
		{
		}
		finally
		{
			msg?.M890();
		}
	}

	private void M303(T115 d)
	{
		T54.vcItem = d.M1088();
		T85.itemTemplates.M1075();
		T54.M559().iOptionTemplates = new T83[d.M1091()];
		for (int i = 0; i < T54.M559().iOptionTemplates.Length; i++)
		{
			T54.M559().iOptionTemplates[i] = new T83();
			T54.M559().iOptionTemplates[i].id = i;
			T54.M559().iOptionTemplates[i].name = d.M1100();
			T54.M559().iOptionTemplates[i].type = d.M1088();
		}
		int num = d.M1092();
		for (int j = 0; j < num; j++)
		{
			T85.M833(new T84((short)j, d.M1088(), d.M1088(), d.M1100(), d.M1100(), d.M1088(), d.M1094(), d.M1092(), d.M1092(), d.M1096()));
		}
	}

	private void M304(T115 d)
	{
		T54.vcSkill = d.M1088();
		T54.M559().sOptionTemplates = new T152[d.M1088()];
		for (int i = 0; i < T54.M559().sOptionTemplates.Length; i++)
		{
			T54.M559().sOptionTemplates[i] = new T152();
			T54.M559().sOptionTemplates[i].id = i;
			T54.M559().sOptionTemplates[i].name = d.M1100();
		}
		T54.nClasss = new T119[d.M1088()];
		for (int j = 0; j < T54.nClasss.Length; j++)
		{
			T54.nClasss[j] = new T119();
			T54.nClasss[j].classId = j;
			T54.nClasss[j].name = d.M1100();
			T54.nClasss[j].skillTemplates = new T155[d.M1088()];
			for (int k = 0; k < T54.nClasss[j].skillTemplates.Length; k++)
			{
				T54.nClasss[j].skillTemplates[k] = new T155();
				T54.nClasss[j].skillTemplates[k].id = d.M1088();
				T54.nClasss[j].skillTemplates[k].name = d.M1100();
				T54.nClasss[j].skillTemplates[k].maxPoint = d.M1088();
				T54.nClasss[j].skillTemplates[k].manaUseType = d.M1088();
				T54.nClasss[j].skillTemplates[k].type = d.M1088();
				T54.nClasss[j].skillTemplates[k].iconId = d.M1092();
				T54.nClasss[j].skillTemplates[k].damInfo = d.M1100();
				int lineWidth = 130;
				if (T51.w == 128 || T51.h <= 208)
				{
					lineWidth = 100;
				}
				T54.nClasss[j].skillTemplates[k].description = T98.tahoma_7_green2.M907(d.M1100(), lineWidth);
				T54.nClasss[j].skillTemplates[k].skills = new T149[d.M1088()];
				for (int l = 0; l < T54.nClasss[j].skillTemplates[k].skills.Length; l++)
				{
					T54.nClasss[j].skillTemplates[k].skills[l] = new T149();
					T54.nClasss[j].skillTemplates[k].skills[l].skillId = d.M1092();
					T54.nClasss[j].skillTemplates[k].skills[l].template = T54.nClasss[j].skillTemplates[k];
					T54.nClasss[j].skillTemplates[k].skills[l].point = d.M1088();
					T54.nClasss[j].skillTemplates[k].skills[l].powRequire = d.M1095();
					T54.nClasss[j].skillTemplates[k].skills[l].manaUse = d.M1092();
					T54.nClasss[j].skillTemplates[k].skills[l].coolDown = d.M1094();
					T54.nClasss[j].skillTemplates[k].skills[l].dx = d.M1092();
					T54.nClasss[j].skillTemplates[k].skills[l].dy = d.M1092();
					T54.nClasss[j].skillTemplates[k].skills[l].maxFight = d.M1088();
					T54.nClasss[j].skillTemplates[k].skills[l].damage = d.M1092();
					T54.nClasss[j].skillTemplates[k].skills[l].price = d.M1092();
					T54.nClasss[j].skillTemplates[k].skills[l].moreInfo = d.M1100();
					T154.M1772(T54.nClasss[j].skillTemplates[k].skills[l]);
				}
			}
		}
	}

	private void M305(T115 d)
	{
		T54.vcMap = d.M1088();
		T174.mapNames = new string[d.M1091()];
		for (int i = 0; i < T174.mapNames.Length; i++)
		{
			T174.mapNames[i] = d.M1100();
		}
		T123.arrNpcTemplate = new T124[d.M1088()];
		for (sbyte b = 0; b < T123.arrNpcTemplate.Length; b++)
		{
			T123.arrNpcTemplate[b] = new T124();
			T123.arrNpcTemplate[b].npcTemplateId = b;
			T123.arrNpcTemplate[b].name = d.M1100();
			T123.arrNpcTemplate[b].headId = d.M1092();
			T123.arrNpcTemplate[b].bodyId = d.M1092();
			T123.arrNpcTemplate[b].legId = d.M1092();
			T123.arrNpcTemplate[b].menu = new string[d.M1088()][];
			for (int j = 0; j < T123.arrNpcTemplate[b].menu.Length; j++)
			{
				T123.arrNpcTemplate[b].menu[j] = new string[d.M1088()];
				for (int k = 0; k < T123.arrNpcTemplate[b].menu[j].Length; k++)
				{
					T123.arrNpcTemplate[b].menu[j][k] = d.M1100();
				}
			}
		}
		T101.arrMobTemplate = new T103[d.M1088()];
		for (sbyte b2 = 0; b2 < T101.arrMobTemplate.Length; b2++)
		{
			T101.arrMobTemplate[b2] = new T103();
			T101.arrMobTemplate[b2].mobTemplateId = b2;
			T101.arrMobTemplate[b2].type = d.M1088();
			T101.arrMobTemplate[b2].name = d.M1100();
			T101.arrMobTemplate[b2].hp = d.M1094();
			T101.arrMobTemplate[b2].rangeMove = d.M1088();
			T101.arrMobTemplate[b2].speed = d.M1088();
			T101.arrMobTemplate[b2].dartType = d.M1088();
		}
	}

	private void M306(T115 d, bool isSaveRMS)
	{
		T54.vcData = d.M1088();
		if (isSaveRMS)
		{
			T138.M1534("NR_dart", T122.M1186(d));
			T138.M1534("NR_arrow", T122.M1186(d));
			T138.M1534("NR_effect", T122.M1186(d));
			T138.M1534("NR_image", T122.M1186(d));
			T138.M1534("NR_part", T122.M1186(d));
			T138.M1534("NR_skill", T122.M1186(d));
			T138.M1548("NRdata");
		}
	}

	private T60 M307(sbyte[] arr)
	{
		try
		{
			return T60.M708(arr, 0, arr.Length);
		}
		catch (Exception)
		{
		}
		return null;
	}

	public int[] M308(sbyte[] b)
	{
		int[] array = new int[b.Length];
		for (int i = 0; i < b.Length; i++)
		{
			int num = b[i];
			if (num < 0)
			{
				num += 256;
			}
			array[i] = num;
		}
		return array;
	}

	public void M309(T97 msg, int index)
	{
		try
		{
			T19 t = new T19();
			sbyte b = (sbyte)(t.type = msg.M887().M1088());
			t.id = msg.M887().M1094();
			t.playerId = msg.M887().M1094();
			t.playerName = msg.M887().M1100();
			t.role = msg.M887().M1088();
			t.time = msg.M887().M1094() + 1000000000;
			bool upToTop = false;
			T54.isNewClanMessage = false;
			switch (b)
			{
			case 0:
			{
				string text = msg.M887().M1100();
				T54.isNewClanMessage = true;
				if (T98.tahoma_7.M909(text) > T126.WIDTH_PANEL - 60)
				{
					t.chat = T98.tahoma_7.M907(text, T126.WIDTH_PANEL - 10);
				}
				else
				{
					t.chat = new string[1];
					t.chat[0] = text;
				}
				t.color = msg.M887().M1088();
				break;
			}
			case 1:
				t.recieve = msg.M887().M1088();
				t.maxCap = msg.M887().M1088();
				if (upToTop = msg.M887().M1088() == 1)
				{
					T54.isNewClanMessage = true;
				}
				if (t.playerId != T13.M113().charID)
				{
					if (t.recieve < t.maxCap)
					{
						t.option = new string[1] { mResources.donate };
					}
					else
					{
						t.option = null;
					}
				}
				if (T51.panel.cp != null)
				{
					T51.panel.M1422(t.recieve, t.maxCap);
				}
				break;
			case 2:
				if (T13.M113().role == 0)
				{
					T54.isNewClanMessage = true;
					t.option = new string[2]
					{
						mResources.CANCEL,
						mResources.receive
					};
				}
				break;
			}
			if (T51.currentScreen != T54.instance)
			{
				T54.isNewClanMessage = false;
			}
			else if (T51.panel.isShow && T51.panel.type == 0 && T51.panel.currentTabIndex == 3)
			{
				T54.isNewClanMessage = false;
			}
			T19.M290(t, index, upToTop);
		}
		catch (Exception)
		{
			T24.M326("LOI TAI CMD -= " + msg.command);
		}
	}

	public void M310(sbyte teleport3)
	{
		T137.M1513("is loading map = " + T13.isLoadingMap);
		T54.M559().auto = 0;
		T54.isChangeZone = false;
		T26.instance = null;
		T54.info1.isUpdate = false;
		T54.info2.isUpdate = false;
		T54.lockTick = 0;
		T51.panel.isShow = false;
		T160.M1826().M1873();
		if (!T54.isLoadAllData && !T26.isCreateChar)
		{
			T54.M559().M532();
		}
		T54.M564(fullmScreen: false, (teleport3 != 1) ? (-1) : T13.M113().cx, (teleport3 == 0) ? (-1) : 0);
		T174.M1964();
		T174.M1944(T174.tileID);
		T137.M1513("LOAD GAMESCR 2");
		T13.M113().cvx = 0;
		T13.M113().statusMe = 4;
		T13.M113().currentMovePoint = null;
		T13.M113().mobFocus = null;
		T13.M113().charFocus = null;
		T13.M113().npcFocus = null;
		T13.M113().itemFocus = null;
		T13.M113().skillPaint = null;
		T13.M113().M183(m: false);
		T13.M113().skillPaintRandomPaint = null;
		T51.M517();
		if (T13.M113().cy >= T174.pxh - 100)
		{
			T13.M113().isFlyUp = true;
			T13.M113().cx += T137.M1529(T137.M1522(0, 80));
			T146.M1594().M1640();
		}
		T54.M559().M561();
		T51.M469(T174.bgID);
		T13.isLockKey = false;
		T137.M1513("cy= " + T13.M113().cy + "---------------------------------------------");
		for (int i = 0; i < T13.M113().vEff.M1113(); i++)
		{
			if (((T34)T13.M113().vEff.M1114(i)).template.type == 10)
			{
				T13.isLockKey = true;
				break;
			}
		}
		T51.M484();
		T51.M483();
		T54.M559().dHP = T13.M113().cHP;
		T54.M559().dMP = T13.M113().cMP;
		T13.ischangingMap = false;
		T54.M559().switchToMe();
		if (T13.M113().cy <= 10 && teleport3 != 0 && teleport3 != 2)
		{
			T171.M1894(new T171(T13.M113().cx, T13.M113().cy, T13.M113().head, T13.M113().cdir, 1, isMe: true, (teleport3 != 1) ? teleport3 : T13.M113().cgender));
			T13.M113().isTeleport = true;
		}
		if (teleport3 == 2)
		{
			T13.M113().M140();
		}
		if (T54.M559().isRongThanXuatHien)
		{
			if (T174.mapID == T54.M559().mapRID && T174.zoneID == T54.M559().zoneRID)
			{
				T54.M559().M594(T54.M559().xR, T54.M559().yR);
			}
			if (T99.zoomLevel > 1)
			{
				T54.M559().M593();
			}
		}
		T66.M753();
		T66.M748(T174.mapName, mResources.zone + " " + T174.zoneID, 30);
		T51.M488();
		T51.isLoading = false;
		T55.M696();
		T55.M694();
		T51.M456("SA75x9", 2);
	}

	public void M311(T97 msg)
	{
		try
		{
			if (T99.zoomLevel == 1)
			{
				T157.M1783();
			}
			T13.M113().cx = (T13.M113().cxSend = (T13.M113().cxFocus = msg.M887().M1092()));
			T13.M113().cy = (T13.M113().cySend = (T13.M113().cyFocus = msg.M887().M1092()));
			T13.M113().xSd = T13.M113().cx;
			T13.M113().ySd = T13.M113().cy;
			T137.M1513("head= " + T13.M113().head + " body= " + T13.M113().body + " left= " + T13.M113().leg + " x= " + T13.M113().cx + " y= " + T13.M113().cy + " chung toc= " + T13.M113().cgender);
			if (T13.M113().cx >= 0 && T13.M113().cx <= 100)
			{
				T13.M113().cdir = 1;
			}
			else if (T13.M113().cx >= T174.tmw - 100 && T13.M113().cx <= T174.tmw)
			{
				T13.M113().cdir = -1;
			}
			T51.M456("SA75x4", 2);
			int num = msg.M887().M1088();
			T137.M1513("vGo size= " + num);
			if (!T54.info1.isDone)
			{
				T54.info1.cmx = T13.M113().cx - T54.cmx;
				T54.info1.cmy = T13.M113().cy - T54.cmy;
			}
			for (int i = 0; i < num; i++)
			{
				T180 t = new T180(msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1100());
				if ((T174.mapID != 21 && T174.mapID != 22 && T174.mapID != 23) || t.minX < 0)
				{
				}
			}
			Resources.UnloadUnusedAssets();
			GC.Collect();
			T51.M456("SA75x5", 2);
			num = msg.M887().M1088();
			T101.newMob.M1120();
			for (sbyte b = 0; b < num; b++)
			{
				T101 t2 = new T101(b, msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1088(), msg.M887().M1088(), msg.M887().M1094(), msg.M887().M1088(), msg.M887().M1094(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1088(), msg.M887().M1088());
				t2.xSd = t2.x;
				t2.ySd = t2.y;
				t2.isBoss = msg.M887().M1097();
				if (T101.arrMobTemplate[t2.templateId].type != 0)
				{
					if (b % 3 == 0)
					{
						t2.dir = -1;
					}
					else
					{
						t2.dir = 1;
					}
					t2.x += 10 - b % 20;
				}
				t2.isMobMe = false;
				T202 t3 = null;
				T7 t4 = null;
				T12 t5 = null;
				T121 t6 = null;
				if (t2.templateId == 70)
				{
					t3 = new T202(b, (short)t2.x, (short)t2.y, 70, t2.hp, t2.maxHp, t2.sys);
				}
				if (t2.templateId == 71)
				{
					t4 = new T7(b, (short)t2.x, (short)t2.y, 71, t2.hp, t2.maxHp, t2.sys);
				}
				if (t2.templateId == 72)
				{
					t5 = new T12(b, (short)t2.x, (short)t2.y, 72, t2.hp, t2.maxHp, 3);
				}
				if (t2.isBoss)
				{
					t6 = new T121(b, (short)t2.x, (short)t2.y, t2.templateId, t2.hp, t2.maxHp, t2.sys);
				}
				if (t6 != null)
				{
					T54.vMob.M1111(t6);
				}
				else if (t3 != null)
				{
					T54.vMob.M1111(t3);
				}
				else if (t4 != null)
				{
					T54.vMob.M1111(t4);
				}
				else if (t5 != null)
				{
					T54.vMob.M1111(t5);
				}
				else
				{
					T54.vMob.M1111(t2);
				}
			}
			for (int j = 0; j < T101.lastMob.M1113(); j++)
			{
				string text = (string)T101.lastMob.M1114(j);
				if (!T101.M978(text))
				{
					T101.arrMobTemplate[int.Parse(text)].data = null;
					T101.lastMob.M1118(j);
					j--;
				}
			}
			if (T13.M113().mobMe != null && T54.M628(T13.M113().mobMe.mobId) == null)
			{
				T13.M113().mobMe.M975();
				T13.M113().mobMe.x = T13.M113().cx;
				T13.M113().mobMe.y = T13.M113().cy - 40;
				T54.vMob.M1111(T13.M113().mobMe);
			}
			num = msg.M887().M1088();
			for (byte b2 = 0; b2 < num; b2++)
			{
			}
			T51.M456("SA75x6", 2);
			num = msg.M887().M1088();
			T137.M1513("NPC size= " + num);
			for (int k = 0; k < num; k++)
			{
				sbyte status = msg.M887().M1088();
				short cx = msg.M887().M1092();
				short num2 = msg.M887().M1092();
				sbyte b3 = msg.M887().M1088();
				short num3 = msg.M887().M1092();
				if (b3 != 6 && ((T13.M113().taskMaint.taskId >= 7 && (T13.M113().taskMaint.taskId != 7 || T13.M113().taskMaint.index > 1)) || (b3 != 7 && b3 != 8 && b3 != 9)) && (T13.M113().taskMaint.taskId >= 6 || b3 != 16))
				{
					if (b3 == 4)
					{
						T54.M559().magicTree = new T91(k, status, cx, num2, b3, num3);
						T146.M1594().M1637(2);
						T54.vNpc.M1111(T54.M559().magicTree);
					}
					else
					{
						T123 o = new T123(k, status, cx, num2 + 3, b3, num3);
						T54.vNpc.M1111(o);
					}
				}
			}
			T51.M456("SA75x7", 2);
			num = msg.M887().M1088();
			T137.M1513("item size = " + num);
			for (int l = 0; l < num; l++)
			{
				short itemMapID = msg.M887().M1092();
				short itemTemplateID = msg.M887().M1092();
				int x = msg.M887().M1092();
				int y = msg.M887().M1092();
				int num4 = msg.M887().M1094();
				short r = 0;
				if (num4 == -2)
				{
					r = msg.M887().M1092();
				}
				T80 t7 = new T80(num4, itemMapID, itemTemplateID, x, y, r);
				bool flag = false;
				for (int m = 0; m < T54.vItemMap.M1113(); m++)
				{
					if (((T80)T54.vItemMap.M1114(m)).itemMapID == t7.itemMapID)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					T54.vItemMap.M1111(t7);
				}
			}
			if (T51.lowGraphic && (!T51.lowGraphic || (T174.mapID != 51 && T174.mapID != 103)))
			{
				short num5 = msg.M887().M1092();
				for (int n = 0; n < num5; n++)
				{
					msg.M887().M1092();
					msg.M887().M1092();
					msg.M887().M1092();
				}
				short num6 = msg.M887().M1092();
				for (int num7 = 0; num7 < num6; num7++)
				{
					msg.M887().M1100();
					msg.M887().M1100();
				}
			}
			else
			{
				short num8 = msg.M887().M1092();
				T174.vCurrItem.M1120();
				if (T99.zoomLevel == 1)
				{
					T10.M65();
				}
				T10.vKeysNew.M1120();
				T137.M1513("nItem= " + num8);
				for (int num9 = 0; num9 < num8; num9++)
				{
					short id = msg.M887().M1092();
					short num10 = msg.M887().M1092();
					short num11 = msg.M887().M1092();
					if (T174.M1935(id) == null)
					{
						continue;
					}
					T10 t8 = T174.M1935(id);
					T10 t9 = new T10();
					t9.id = id;
					t9.idImage = t8.idImage;
					t9.dx = t8.dx;
					t9.dy = t8.dy;
					t9.x = num10 * T174.size;
					t9.y = num11 * T174.size;
					t9.layer = t8.layer;
					if (T174.M1941(t9.id))
					{
						t9.trans = ((num9 % 2 != 0) ? 2 : 0);
						if (T174.mapID == 45)
						{
							t9.trans = 0;
						}
					}
					T60 t10 = null;
					if (!T10.imgNew.M1081(t9.idImage + string.Empty))
					{
						if (T99.zoomLevel == 1)
						{
							t10 = T51.M503("/mapBackGround/" + t9.idImage + ".png");
							if (t10 == null)
							{
								t10 = T60.M711(new int[1], 1, 1, bl: true);
								T146.M1594().M1709(t9.idImage);
							}
							T10.imgNew.M1078(t9.idImage + string.Empty, t10);
						}
						else
						{
							bool flag2 = false;
							sbyte[] array = T138.M1535(T99.zoomLevel + "bgItem" + t9.idImage);
							if (array != null)
							{
								if (T10.newSmallVersion != null)
								{
									T137.M1513("Small  last= " + array.Length % 127 + "new Version= " + T10.newSmallVersion[t9.idImage]);
									if (array.Length % 127 != T10.newSmallVersion[t9.idImage])
									{
										flag2 = true;
									}
								}
								if (!flag2)
								{
									t10 = T60.M708(array, 0, array.Length);
									if (t10 != null)
									{
										T10.imgNew.M1078(t9.idImage + string.Empty, t10);
									}
									else
									{
										flag2 = true;
									}
								}
							}
							else
							{
								flag2 = true;
							}
							if (flag2)
							{
								t10 = T51.M503("/mapBackGround/" + t9.idImage + ".png");
								if (t10 == null)
								{
									t10 = T60.M711(new int[1], 1, 1, bl: true);
									T146.M1594().M1709(t9.idImage);
								}
								T10.imgNew.M1078(t9.idImage + string.Empty, t10);
							}
						}
						T10.vKeysLast.M1111(t9.idImage + string.Empty);
					}
					if (!T10.M66(t9.idImage + string.Empty))
					{
						T10.vKeysNew.M1111(t9.idImage + string.Empty);
					}
					t9.M70();
					T174.vCurrItem.M1111(t9);
				}
				for (int num12 = 0; num12 < T10.vKeysLast.M1113(); num12++)
				{
					string text2 = (string)T10.vKeysLast.M1114(num12);
					if (!T10.M66(text2))
					{
						T10.imgNew.M1079(text2);
						if (T10.imgNew.M1081(text2 + "blend" + 1))
						{
							T10.imgNew.M1079(text2 + "blend" + 1);
						}
						if (T10.imgNew.M1081(text2 + "blend" + 3))
						{
							T10.imgNew.M1079(text2 + "blend" + 3);
						}
						T10.vKeysLast.M1118(num12);
						num12--;
					}
				}
				T8.isFog = false;
				T8.nCloud = 0;
				T31.vEff.M1120();
				T8.vBgEffect.M1120();
				T32.newEff.M1120();
				short num13 = msg.M887().M1092();
				for (int num14 = 0; num14 < num13; num14++)
				{
					M312(msg.M887().M1100(), msg.M887().M1100());
				}
				for (int num15 = 0; num15 < T32.lastEff.M1113(); num15++)
				{
					string text3 = (string)T32.lastEff.M1114(num15);
					if (!T32.M388(text3))
					{
						T32.M385(int.Parse(text3));
						T32.lastEff.M1118(num15);
						num15--;
					}
				}
			}
			T174.bgType = msg.M887().M1088();
			M310(msg.M887().M1088());
			T13.isLoadingMap = false;
			T51.M456("SA75x8", 2);
			Resources.UnloadUnusedAssets();
			GC.Collect();
			T24.M328("----------DA CHAY XONG LOAD INFO MAP");
		}
		catch (Exception ex)
		{
			T24.M328("LOI TAI LOADMAP INFO " + ex.ToString());
		}
	}

	public void M312(string key, string value)
	{
		if (key.Equals("eff"))
		{
			if (T126.graphics > 0)
			{
				return;
			}
			string[] array = T137.M1531(value, ".", 0);
			int id = int.Parse(array[0]);
			int layer = int.Parse(array[1]);
			int x = int.Parse(array[2]);
			int y = int.Parse(array[3]);
			int loop;
			int loopCount;
			if (array.Length <= 4)
			{
				loop = -1;
				loopCount = 1;
			}
			else
			{
				loop = int.Parse(array[4]);
				loopCount = int.Parse(array[5]);
			}
			T32 t = new T32(id, x, y, layer, loop, loopCount);
			if (array.Length > 6)
			{
				t.typeEff = int.Parse(array[6]);
				if (array.Length > 7)
				{
					t.indexFrom = int.Parse(array[7]);
					t.indexTo = int.Parse(array[8]);
				}
			}
			T31.M376(t);
		}
		else if (key.Equals("beff") && T126.graphics <= 1)
		{
			T8.M55(int.Parse(value));
		}
	}

	public void M313(T97 msg)
	{
		T51.M456("SA6", 2);
		try
		{
			sbyte b = msg.M887().M1088();
			T110.M1039("---messageNotMap : " + b);
			switch (b)
			{
			case 36:
				T54.typeActive = msg.M887().M1088();
				T137.M1513("load Me Active: " + T54.typeActive);
				break;
			case 35:
				T51.M488();
				T54.M559().M574();
				T54.info1.M762(msg.M887().M1100(), 0);
				break;
			case 4:
			{
				T51.M456("SA8", 2);
				T51.loginScr.M862();
				T54.isAutoPlay = false;
				T54.canAutoPlay = false;
				T90.isUpdateAll = true;
				T90.isUpdateData = true;
				T90.isUpdateMap = true;
				T90.isUpdateSkill = true;
				T90.isUpdateItem = true;
				T54.vsData = msg.M887().M1088();
				T54.vsMap = msg.M887().M1088();
				T54.vsSkill = msg.M887().M1088();
				T54.vsItem = msg.M887().M1088();
				msg.M887().M1088();
				if (T51.loginScr.isLogin2)
				{
					T138.M1538("acc", string.Empty);
					T138.M1538("pass", string.Empty);
				}
				else
				{
					T138.M1538("userAo" + T144.ipSelect, string.Empty);
				}
				if (T54.vsData != T54.vcData)
				{
					T54.isLoadAllData = false;
					T146.M1594().M1675();
				}
				else
				{
					try
					{
						T90.isUpdateData = false;
					}
					catch (Exception)
					{
						T54.vcData = -1;
						T146.M1594().M1675();
					}
				}
				if (T54.vsMap != T54.vcMap)
				{
					T54.isLoadAllData = false;
					T146.M1594().M1676();
				}
				else
				{
					try
					{
						if (!T54.isLoadAllData)
						{
							M305(new T28(T138.M1535("NRmap")).r);
						}
						T90.isUpdateMap = false;
					}
					catch (Exception)
					{
						T54.vcMap = -1;
						T146.M1594().M1676();
					}
				}
				if (T54.vsSkill != T54.vcSkill)
				{
					T54.isLoadAllData = false;
					T146.M1594().M1677();
				}
				else
				{
					try
					{
						if (!T54.isLoadAllData)
						{
							M304(new T28(T138.M1535("NRskill")).r);
						}
						T90.isUpdateSkill = false;
					}
					catch (Exception)
					{
						T54.vcSkill = -1;
						T146.M1594().M1677();
					}
				}
				if (T54.vsItem != T54.vcItem)
				{
					T54.isLoadAllData = false;
					T146.M1594().M1678();
				}
				else
				{
					try
					{
						M320(new T28(T138.M1535("NRitem0")).r, 0, isSave: false);
						M320(new T28(T138.M1535("NRitem1")).r, 1, isSave: false);
						M320(new T28(T138.M1535("NRitem2")).r, 2, isSave: false);
						M320(new T28(T138.M1535("NRitem100")).r, 100, isSave: false);
						T90.isUpdateItem = false;
					}
					catch (Exception)
					{
						T54.vcItem = -1;
						T146.M1594().M1678();
					}
				}
				if (T54.vsData == T54.vcData && T54.vsMap == T54.vcMap && T54.vsSkill == T54.vcSkill && T54.vsItem == T54.vcItem)
				{
					if (!T54.isLoadAllData)
					{
						T54.M559().M557();
						T54.M559().M555();
						T54.M559().M556();
						T54.M559().M558();
					}
					T146.M1594().M1679();
				}
				sbyte b2 = msg.M887().M1088();
				T137.M1513("CAPTION LENT= " + b2);
				T54.exps = new long[b2];
				for (int j = 0; j < T54.exps.Length; j++)
				{
					T54.exps[j] = msg.M887().M1095();
				}
				break;
			}
			case 6:
			{
				T137.M1513("GET UPDATE_MAP " + msg.M887().M1104() + " bytes");
				msg.M887().M1089(100000);
				M305(msg.M887());
				msg.M887().M1090();
				sbyte[] data2 = new sbyte[msg.M887().M1104()];
				msg.M887().M1103(ref data2);
				T138.M1534("NRmap", data2);
				T138.M1534("NRmapVersion", new sbyte[1] { T54.vcMap });
				T90.isUpdateMap = false;
				if (T54.vsData == T54.vcData && T54.vsMap == T54.vcMap && T54.vsSkill == T54.vcSkill && T54.vsItem == T54.vcItem)
				{
					T54.M559().M557();
					T54.M559().M555();
					T54.M559().M556();
					T54.M559().M558();
					T146.M1594().M1679();
				}
				break;
			}
			case 7:
			{
				T137.M1513("GET UPDATE_SKILL " + msg.M887().M1104() + " bytes");
				msg.M887().M1089(100000);
				M304(msg.M887());
				msg.M887().M1090();
				sbyte[] data = new sbyte[msg.M887().M1104()];
				msg.M887().M1103(ref data);
				T138.M1534("NRskill", data);
				T138.M1534("NRskillVersion", new sbyte[1] { T54.vcSkill });
				T90.isUpdateSkill = false;
				if (T54.vsData == T54.vcData && T54.vsMap == T54.vcMap && T54.vsSkill == T54.vcSkill && T54.vsItem == T54.vcItem)
				{
					T54.M559().M557();
					T54.M559().M555();
					T54.M559().M556();
					T54.M559().M558();
					T146.M1594().M1679();
				}
				break;
			}
			case 8:
				T137.M1513("GET UPDATE_ITEM " + msg.M887().M1104() + " bytes");
				M319(msg.M887());
				break;
			case 9:
				T51.M456("SA11", 2);
				break;
			case 10:
				try
				{
					T13.isLoadingMap = true;
					T137.M1513("REQUEST MAP TEMPLATE");
					T51.isLoading = true;
					T174.maps = null;
					T174.types = null;
					T110.M1062();
					T51.M456("SA99", 2);
					T174.tmw = msg.M887().M1088();
					T174.tmh = msg.M887().M1088();
					T174.maps = new int[T174.tmw * T174.tmh];
					T137.M1513("   M apsize= " + T174.tmw * T174.tmh);
					for (int i = 0; i < T174.maps.Length; i++)
					{
						int num2 = msg.M887().M1088();
						if (num2 < 0)
						{
							num2 += 256;
						}
						T174.maps[i] = (ushort)num2;
					}
					T174.types = new int[T174.maps.Length];
					msg = messWait;
					M311(msg);
					try
					{
						T174.isMapDouble = ((msg.M887().M1088() != 0) ? true : false);
					}
					catch (Exception)
					{
					}
				}
				catch (Exception ex2)
				{
					T24.M328("LOI TAI CASE REQUEST_MAPTEMPLATE " + ex2.ToString());
				}
				msg.M890();
				messWait.M890();
				msg = (messWait = null);
				break;
			case 12:
				T51.M456("SA10", 2);
				break;
			case 16:
				T104.M1013().switchToMe();
				break;
			case 17:
				T51.M456("SYB123", 2);
				T13.M113().M226();
				break;
			case 18:
			{
				T51.isLoading = false;
				T51.M488();
				int num = msg.M887().M1094();
				T51.inputDlg.M777(mResources.changeNameChar, new T22(mResources.OK, T51.instance, 88829, num), T173.INPUT_TYPE_ANY);
				break;
			}
			case 20:
				T13.M113().cPk = msg.M887().M1088();
				T54.info1.M762(mResources.PK_NOW + " " + T13.M113().cPk, 0);
				break;
			}
		}
		catch (Exception)
		{
			T24.M328("LOI TAI messageNotMap + " + msg.command);
		}
		finally
		{
			msg?.M890();
		}
	}

	public void M314(T97 msg)
	{
		try
		{
			sbyte b = msg.M887().M1088();
			T110.M1039("---messageNotLogin : " + b);
			if (b != 2)
			{
				return;
			}
			string text = msg.M887().M1100();
			if (T110.isTest)
			{
				text = "88:192.168.1.88:20000:0,53:112.213.85.53:20000:0," + text;
			}
			if (T110.clientType == 1)
			{
				T144.linkDefault = text;
			}
			else
			{
				T144.linkDefault = text;
			}
			T144.M1581(T144.linkDefault);
			try
			{
				T126.CanNapTien = msg.M887().M1088() == 1;
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			msg?.M890();
		}
	}

	public void M315(T97 msg)
	{
		try
		{
			T51.M456("SA12", 2);
			sbyte b = msg.M887().M1088();
			T110.M1039("---messageSubCommand : " + b);
			switch (b)
			{
			case 61:
			{
				string text = msg.M887().M1100();
				sbyte[] data = new sbyte[msg.M887().M1094()];
				msg.M887().M1102(ref data);
				if (data.Length == 0)
				{
					data = null;
				}
				if (text.Equals("KSkill"))
				{
					T54.M559().M541(data);
				}
				else if (text.Equals("OSkill"))
				{
					T54.M559().M540(data);
				}
				else if (text.Equals("CSkill"))
				{
					T54.M559().M542(data);
				}
				break;
			}
			case 62:
			{
				T137.M1513("ME UPDATE SKILL");
				T149 t9 = T154.M1773(msg.M887().M1092());
				for (int num11 = 0; num11 < T13.M113().vSkill.M1113(); num11++)
				{
					if (((T149)T13.M113().vSkill.M1114(num11)).template.id == t9.template.id)
					{
						T13.M113().vSkill.M1116(t9, num11);
						break;
					}
				}
				for (int num12 = 0; num12 < T13.M113().vSkillFight.M1113(); num12++)
				{
					if (((T149)T13.M113().vSkillFight.M1114(num12)).template.id == t9.template.id)
					{
						T13.M113().vSkillFight.M1116(t9, num12);
						break;
					}
				}
				for (int num13 = 0; num13 < T54.onScreenSkill.Length; num13++)
				{
					if (T54.onScreenSkill[num13] != null && T54.onScreenSkill[num13].template.id == t9.template.id)
					{
						T54.onScreenSkill[num13] = t9;
						break;
					}
				}
				for (int num14 = 0; num14 < T54.keySkill.Length; num14++)
				{
					if (T54.keySkill[num14] != null && T54.keySkill[num14].template.id == t9.template.id)
					{
						T54.keySkill[num14] = t9;
						break;
					}
				}
				if (T13.M113().myskill.template.id == t9.template.id)
				{
					T13.M113().myskill = t9;
				}
				T54.info1.M762(mResources.hasJustUpgrade1 + t9.template.name + mResources.hasJustUpgrade2 + t9.point, 0);
				break;
			}
			case 63:
			{
				sbyte b3 = msg.M887().M1088();
				if (b3 > 0)
				{
					T66.M749();
					T117 vPlayerMenu = T51.panel.vPlayerMenu;
					for (int j = 0; j < b3; j++)
					{
						string caption = msg.M887().M1100();
						string caption2 = msg.M887().M1100();
						short menuSelect = msg.M887().M1092();
						T13.M113().charFocus.menuSelect = menuSelect;
						T22 t4 = new T22(caption, 11115, T13.M113().charFocus);
						t4.caption2 = caption2;
						vPlayerMenu.M1111(t4);
					}
					T66.M753();
					T51.panel.M1256();
				}
				break;
			}
			case 0:
			{
				T51.M456("SA21", 2);
				T136.list = new T117();
				T171.vTeleport.M1120();
				T54.vCharInMap.M1120();
				T54.vItemMap.M1120();
				T13.vItemTime.M1120();
				T54.M657();
				T54.currentCharViewInfo = T13.M113();
				T13.M113().charID = msg.M887().M1094();
				T13.M113().ctaskId = msg.M887().M1088();
				T13.M113().cgender = msg.M887().M1088();
				T13.M113().head = msg.M887().M1092();
				T13.M113().cName = msg.M887().M1100();
				T13.M113().cPk = msg.M887().M1088();
				T13.M113().cTypePk = msg.M887().M1088();
				T13.M113().cPower = msg.M887().M1095();
				T13.M113().M103();
				T13.M113().eff5BuffHp = msg.M887().M1092();
				T13.M113().eff5BuffMp = msg.M887().M1092();
				T13.M113().nClass = T54.nClasss[msg.M887().M1088()];
				T13.M113().vSkill.M1120();
				T13.M113().vSkillFight.M1120();
				T54.M559().dHP = T13.M113().cHP;
				T54.M559().dMP = T13.M113().cMP;
				sbyte b6 = msg.M887().M1088();
				for (sbyte b7 = 0; b7 < b6; b7++)
				{
					M316(T154.M1773(msg.M887().M1092()));
				}
				T54.M559().M604();
				T54.M559().M539();
				T13.M113().xu = msg.M887().M1095();
				T13.M113().luongKhoa = msg.M887().M1094();
				T13.M113().luong = msg.M887().M1094();
				T13.M113().xuStr = T110.M1042(T13.M113().xu);
				T13.M113().luongStr = T110.M1042(T13.M113().luong);
				T13.M113().luongKhoaStr = T110.M1042(T13.M113().luongKhoa);
				T13.M113().arrItemBody = new T79[msg.M887().M1088()];
				try
				{
					T13.M113().M165();
					for (int k = 0; k < T13.M113().arrItemBody.Length; k++)
					{
						short num2 = msg.M887().M1092();
						if (num2 == -1)
						{
							continue;
						}
						T84 t8 = T85.M834(num2);
						int type = t8.type;
						T13.M113().arrItemBody[k] = new T79();
						T13.M113().arrItemBody[k].template = t8;
						T13.M113().arrItemBody[k].quantity = msg.M887().M1094();
						T13.M113().arrItemBody[k].info = msg.M887().M1100();
						T13.M113().arrItemBody[k].content = msg.M887().M1100();
						int num3 = msg.M887().M1091();
						if (num3 != 0)
						{
							T13.M113().arrItemBody[k].itemOption = new T82[num3];
							for (int l = 0; l < T13.M113().arrItemBody[k].itemOption.Length; l++)
							{
								int optionTemplateId = msg.M887().M1091();
								ushort param = msg.M887().M1093();
								T13.M113().arrItemBody[k].itemOption[l] = new T82(optionTemplateId, param);
							}
						}
						switch (type)
						{
						case 1:
							T13.M113().leg = T13.M113().arrItemBody[k].template.part;
							T137.M1513("toi day =======================================" + T13.M113().leg);
							break;
						case 0:
							T137.M1513("toi day =======================================" + T13.M113().body);
							T13.M113().body = T13.M113().arrItemBody[k].template.part;
							break;
						}
					}
				}
				catch (Exception)
				{
				}
				T13.M113().arrItemBag = new T79[msg.M887().M1088()];
				T54.hpPotion = 0;
				for (int m = 0; m < T13.M113().arrItemBag.Length; m++)
				{
					short num4 = msg.M887().M1092();
					if (num4 == -1)
					{
						continue;
					}
					T13.M113().arrItemBag[m] = new T79();
					T13.M113().arrItemBag[m].template = T85.M834(num4);
					T13.M113().arrItemBag[m].quantity = msg.M887().M1094();
					T13.M113().arrItemBag[m].info = msg.M887().M1100();
					T13.M113().arrItemBag[m].content = msg.M887().M1100();
					T13.M113().arrItemBag[m].indexUI = m;
					sbyte b8 = msg.M887().M1088();
					if (b8 != 0)
					{
						T13.M113().arrItemBag[m].itemOption = new T82[b8];
						for (int n = 0; n < T13.M113().arrItemBag[m].itemOption.Length; n++)
						{
							int optionTemplateId2 = msg.M887().M1091();
							ushort param2 = msg.M887().M1093();
							T13.M113().arrItemBag[m].itemOption[n] = new T82(optionTemplateId2, param2);
							T13.M113().arrItemBag[m].M798();
						}
					}
					if (T13.M113().arrItemBag[m].template.type == 6)
					{
						T54.hpPotion += T13.M113().arrItemBag[m].quantity;
					}
				}
				T13.M113().arrItemBox = new T79[msg.M887().M1088()];
				T51.panel.hasUse = 0;
				for (int num5 = 0; num5 < T13.M113().arrItemBox.Length; num5++)
				{
					short num6 = msg.M887().M1092();
					if (num6 != -1)
					{
						T13.M113().arrItemBox[num5] = new T79();
						T13.M113().arrItemBox[num5].template = T85.M834(num6);
						T13.M113().arrItemBox[num5].quantity = msg.M887().M1094();
						T13.M113().arrItemBox[num5].info = msg.M887().M1100();
						T13.M113().arrItemBox[num5].content = msg.M887().M1100();
						T13.M113().arrItemBox[num5].itemOption = new T82[msg.M887().M1088()];
						for (int num7 = 0; num7 < T13.M113().arrItemBox[num5].itemOption.Length; num7++)
						{
							int optionTemplateId3 = msg.M887().M1091();
							ushort param3 = msg.M887().M1093();
							T13.M113().arrItemBox[num5].itemOption[num7] = new T82(optionTemplateId3, param3);
							T13.M113().arrItemBox[num5].M798();
						}
						T51.panel.hasUse++;
					}
				}
				T13.M113().statusMe = 4;
				if (T138.M1542(T13.M113().cName + "vci") < 1)
				{
					T54.isViewClanInvite = false;
				}
				else
				{
					T54.isViewClanInvite = true;
				}
				short num8 = msg.M887().M1092();
				T13.idHead = new short[num8];
				T13.idAvatar = new short[num8];
				for (int num9 = 0; num9 < num8; num9++)
				{
					T13.idHead[num9] = msg.M887().M1092();
					T13.idAvatar[num9] = msg.M887().M1092();
				}
				for (int num10 = 0; num10 < T54.info1.charId.Length; num10++)
				{
					T54.info1.charId[num10] = new int[3];
				}
				T54.info1.charId[T13.M113().cgender][0] = msg.M887().M1092();
				T54.info1.charId[T13.M113().cgender][1] = msg.M887().M1092();
				T54.info1.charId[T13.M113().cgender][2] = msg.M887().M1092();
				T13.M113().isNhapThe = msg.M887().M1088() == 1;
				T137.M1513("NHAP THE= " + T13.M113().isNhapThe);
				T54.deltaTime = T110.M1054() - msg.M887().M1094() * 1000L;
				T54.isNewMember = msg.M887().M1088();
				T146.M1594().M1624((sbyte)T13.M113().cgender);
				T146.M1594().M1596();
				try
				{
					T13.M113().idAuraEff = msg.M887().M1092();
					T13.M113().idEff_Set_Item = msg.M887().M1086();
					T13.M113().idHat = msg.M887().M1092();
					break;
				}
				catch (Exception)
				{
					break;
				}
			}
			case 1:
				T51.M456("SA13", 2);
				T13.M113().nClass = T54.nClasss[msg.M887().M1088()];
				T13.M113().cTiemNang = msg.M887().M1095();
				T13.M113().vSkill.M1120();
				T13.M113().vSkillFight.M1120();
				T13.M113().myskill = null;
				break;
			case 2:
			{
				T51.M456("SA14", 2);
				if (T13.M113().statusMe != 14 && T13.M113().statusMe != 5)
				{
					T13.M113().cHP = T13.M113().cHPFull;
					T13.M113().cMP = T13.M113().cMPFull;
					T24.M329(" ME_LOAD_SKILL");
				}
				T13.M113().vSkill.M1120();
				T13.M113().vSkillFight.M1120();
				sbyte b4 = msg.M887().M1088();
				for (sbyte b5 = 0; b5 < b4; b5++)
				{
					M316(T154.M1773(msg.M887().M1092()));
				}
				T54.M559().M604();
				if (T54.isPaintInfoMe)
				{
					T54.indexRow = -1;
					T54.M559().left = (T54.M559().center = null);
				}
				break;
			}
			case 4:
				T51.M456("SA23", 2);
				T13.M113().xu = msg.M887().M1095();
				T13.M113().luong = msg.M887().M1094();
				T13.M113().cHP = msg.M889();
				T13.M113().cMP = msg.M889();
				T13.M113().luongKhoa = msg.M887().M1094();
				T13.M113().xuStr = T110.M1042(T13.M113().xu);
				T13.M113().luongStr = T110.M1042(T13.M113().luong);
				T13.M113().luongKhoaStr = T110.M1042(T13.M113().luongKhoa);
				break;
			case 5:
			{
				T51.M456("SA24", 2);
				int cHP = T13.M113().cHP;
				T13.M113().cHP = msg.M889();
				if (T13.M113().cHP > cHP && T13.M113().cTypePk != 4)
				{
					T54.M643("+" + (T13.M113().cHP - cHP) + " " + mResources.HP, T13.M113().cx, T13.M113().cy - T13.M113().ch - 20, 0, -1, T98.HP);
					T160.M1826().M1830();
					if (T13.M113().petFollow != null && T13.M113().petFollow.smallID == 5003)
					{
						T105.M1017(T13.M113().petFollow.cmx + ((T13.M113().petFollow.dir != 1) ? (-10) : 10), T13.M113().petFollow.cmy + 10, isBoss: true, -1, -1, T13.M113(), 29);
					}
				}
				if (T13.M113().cHP < cHP)
				{
					T54.M643("-" + (cHP - T13.M113().cHP) + " " + mResources.HP, T13.M113().cx, T13.M113().cy - T13.M113().ch - 20, 0, -1, T98.HP);
				}
				T54.M559().dHP = T13.M113().cHP;
				if (!T54.isPaintInfoMe)
				{
				}
				break;
			}
			case 6:
			{
				T51.M456("SA25", 2);
				if (T13.M113().statusMe == 14 || T13.M113().statusMe == 5)
				{
					break;
				}
				int cMP = T13.M113().cMP;
				T13.M113().cMP = msg.M889();
				if (T13.M113().cMP > cMP)
				{
					T54.M643("+" + (T13.M113().cMP - cMP) + " " + mResources.KI, T13.M113().cx, T13.M113().cy - T13.M113().ch - 23, 0, -2, T98.MP);
					T160.M1826().M1830();
					if (T13.M113().petFollow != null && T13.M113().petFollow.smallID == 5001)
					{
						T105.M1017(T13.M113().petFollow.cmx + ((T13.M113().petFollow.dir != 1) ? (-10) : 10), T13.M113().petFollow.cmy + 10, isBoss: true, -1, -1, T13.M113(), 29);
					}
				}
				if (T13.M113().cMP < cMP)
				{
					T54.M643("-" + (cMP - T13.M113().cMP) + " " + mResources.KI, T13.M113().cx, T13.M113().cy - T13.M113().ch - 23, 0, -2, T98.MP);
				}
				T137.M1513("curr MP= " + T13.M113().cMP);
				T54.M559().dMP = T13.M113().cMP;
				if (!T54.isPaintInfoMe)
				{
				}
				break;
			}
			case 7:
			{
				T13 t5 = T54.M626(msg.M887().M1094());
				if (t5 != null)
				{
					t5.clanID = msg.M887().M1094();
					if (t5.clanID == -2)
					{
						t5.isCopy = true;
					}
					M317(t5, msg);
					try
					{
						t5.idAuraEff = msg.M887().M1092();
						t5.idEff_Set_Item = msg.M887().M1086();
						t5.idHat = msg.M887().M1092();
						break;
					}
					catch (Exception)
					{
						break;
					}
				}
				break;
			}
			case 8:
			{
				T51.M456("SA26", 2);
				T13 t11 = T54.M626(msg.M887().M1094());
				if (t11 != null)
				{
					t11.cspeed = msg.M887().M1088();
				}
				break;
			}
			case 9:
			{
				T51.M456("SA27", 2);
				T13 t14 = T54.M626(msg.M887().M1094());
				if (t14 != null)
				{
					t14.cHP = msg.M889();
					t14.cHPFull = msg.M889();
				}
				break;
			}
			case 10:
			{
				T51.M456("SA28", 2);
				T13 t12 = T54.M626(msg.M887().M1094());
				if (t12 != null)
				{
					t12.cHP = msg.M889();
					t12.cHPFull = msg.M889();
					t12.eff5BuffHp = msg.M887().M1092();
					t12.eff5BuffMp = msg.M887().M1092();
					t12.wp = msg.M887().M1092();
					if (t12.wp == -1)
					{
						t12.M166();
					}
				}
				break;
			}
			case 11:
			{
				T51.M456("SA29", 2);
				T13 t10 = T54.M626(msg.M887().M1094());
				if (t10 != null)
				{
					t10.cHP = msg.M889();
					t10.cHPFull = msg.M889();
					t10.eff5BuffHp = msg.M887().M1092();
					t10.eff5BuffMp = msg.M887().M1092();
					t10.body = msg.M887().M1092();
					if (t10.body == -1)
					{
						t10.M167();
					}
				}
				break;
			}
			case 12:
			{
				T51.M456("SA30", 2);
				T13 t6 = T54.M626(msg.M887().M1094());
				if (t6 != null)
				{
					t6.cHP = msg.M889();
					t6.cHPFull = msg.M889();
					t6.eff5BuffHp = msg.M887().M1092();
					t6.eff5BuffMp = msg.M887().M1092();
					t6.leg = msg.M887().M1092();
					if (t6.leg == -1)
					{
						t6.M168();
					}
				}
				break;
			}
			case 13:
			{
				T51.M456("SA31", 2);
				T13 t7 = T54.M626(msg.M887().M1094());
				if (t7 != null)
				{
					t7.cHP = msg.M889();
					t7.cHPFull = msg.M889();
					t7.eff5BuffHp = msg.M887().M1092();
					t7.eff5BuffMp = msg.M887().M1092();
				}
				break;
			}
			case 14:
			{
				T51.M456("SA32", 2);
				T13 t3 = T54.M626(msg.M887().M1094());
				if (t3 != null)
				{
					t3.cHP = msg.M889();
					sbyte b2 = msg.M887().M1088();
					T137.M1513("player load hp type= " + b2);
					if (b2 == 1)
					{
						T143.M1574(11, t3, 5);
						T143.M1574(104, t3, 4);
					}
					try
					{
						t3.cHPFull = msg.M889();
						break;
					}
					catch (Exception)
					{
						break;
					}
				}
				break;
			}
			case 15:
			{
				T51.M456("SA33", 2);
				T13 t15 = T54.M626(msg.M887().M1094());
				if (t15 != null)
				{
					t15.cHP = msg.M889();
					t15.cHPFull = msg.M889();
					t15.cx = msg.M887().M1092();
					t15.cy = msg.M887().M1092();
					t15.statusMe = 1;
					t15.cp3 = 3;
					T143.M1574(109, t15, 2);
				}
				break;
			}
			case 19:
				T51.M456("SA17", 2);
				T13.M113().M117();
				break;
			case 21:
			{
				T51.M456("SA19", 2);
				int num16 = msg.M887().M1094();
				T13.M113().xuInBox -= num16;
				T13.M113().xu += num16;
				T13.M113().xuStr = T110.M1042(T13.M113().xu);
				break;
			}
			case 23:
			{
				short num15 = msg.M887().M1092();
				T149 t13 = T154.M1773(num15);
				M316(t13);
				if (num15 != 0 && num15 != 14 && num15 != 28)
				{
					T54.info1.M762(mResources.LEARN_SKILL + " " + t13.template.name, 0);
				}
				break;
			}
			case 35:
			{
				T51.M456("SY3", 2);
				int num = msg.M887().M1094();
				T137.M1513("CID = " + num);
				if (T174.mapID == 130)
				{
					T54.M559().M636();
				}
				if (num == T13.M113().charID)
				{
					T13.M113().cTypePk = msg.M887().M1088();
					if (T54.M559().M640() && T13.M113().cTypePk != 0)
					{
						T54.M559().M636();
					}
					T137.M1513("type pk= " + T13.M113().cTypePk);
					T13.M113().npcFocus = null;
					if (!T54.M559().M571(T13.M113().mobFocus))
					{
						T13.M113().mobFocus = null;
					}
					T13.M113().itemFocus = null;
				}
				else
				{
					T13 t = T54.M626(num);
					if (t != null)
					{
						T137.M1513("type pk= " + t.cTypePk);
						t.cTypePk = msg.M887().M1088();
						if (t.M209())
						{
							T13.M113().charFocus = t;
						}
					}
				}
				for (int i = 0; i < T54.vCharInMap.M1113(); i++)
				{
					T13 t2 = T54.M626(i);
					if (t2 != null && t2.cTypePk != 0 && t2.cTypePk == T13.M113().cTypePk)
					{
						if (!T13.M113().mobFocus.isMobMe)
						{
							T13.M113().mobFocus = null;
						}
						T13.M113().npcFocus = null;
						T13.M113().itemFocus = null;
						break;
					}
				}
				T137.M1513("update type pk= ");
				break;
			}
			}
		}
		catch (Exception ex5)
		{
			T24.M326("Loi tai Sub : " + ex5.ToString());
		}
		finally
		{
			msg?.M890();
		}
	}

	private void M316(T149 skill)
	{
		if (T13.M113().myskill == null)
		{
			T13.M113().myskill = skill;
		}
		else if (skill.template.Equals(T13.M113().myskill.template))
		{
			T13.M113().myskill = skill;
		}
		T13.M113().vSkill.M1111(skill);
		if ((skill.template.type == 1 || skill.template.type == 4 || skill.template.type == 2 || skill.template.type == 3) && (skill.template.maxPoint == 0 || (skill.template.maxPoint > 0 && skill.point > 0)))
		{
			if (skill.template.id == T13.M113().skillTemplateId)
			{
				T146.M1594().M1652(T13.M113().skillTemplateId);
			}
			T13.M113().vSkillFight.M1111(skill);
		}
	}

	public bool M317(T13 c, T97 msg)
	{
		try
		{
			c.clevel = msg.M887().M1088();
			c.isInvisiblez = msg.M887().M1097();
			c.cTypePk = msg.M887().M1088();
			T137.M1513("ADD TYPE PK= " + c.cTypePk + " to player " + c.charID + " @@ " + c.cName);
			c.nClass = T54.nClasss[msg.M887().M1088()];
			c.cgender = msg.M887().M1088();
			c.head = msg.M887().M1092();
			c.cName = msg.M887().M1100();
			c.cHP = msg.M889();
			c.dHP = c.cHP;
			if (c.cHP == 0)
			{
				c.statusMe = 14;
			}
			c.cHPFull = msg.M889();
			if (c.cy >= T174.pxh - 100)
			{
				c.isFlyUp = true;
			}
			c.body = msg.M887().M1092();
			c.leg = msg.M887().M1092();
			c.bag = msg.M887().M1091();
			T137.M1513(" body= " + c.body + " leg= " + c.leg + " bag=" + c.bag + "BAG ==" + c.bag + "*********************************");
			c.isShadown = true;
			msg.M887().M1088();
			if (c.wp == -1)
			{
				c.M166();
			}
			if (c.body == -1)
			{
				c.M167();
			}
			if (c.leg == -1)
			{
				c.M168();
			}
			c.cx = msg.M887().M1092();
			c.cy = msg.M887().M1092();
			c.xSd = c.cx;
			c.ySd = c.cy;
			c.eff5BuffHp = msg.M887().M1092();
			c.eff5BuffMp = msg.M887().M1092();
			int num = msg.M887().M1088();
			for (int i = 0; i < num; i++)
			{
				T34 t = new T34(msg.M887().M1088(), msg.M887().M1094(), msg.M887().M1094(), msg.M887().M1092());
				c.vEff.M1111(t);
				if (t.template.type == 12 || t.template.type == 11)
				{
					c.isInvisiblez = true;
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		return false;
	}

	private void M318(T97 msg)
	{
		try
		{
			string text = msg.M887().M1100();
			sbyte nFrame = msg.M887().M1088();
			sbyte[] array = null;
			array = T122.M1185(msg);
			T64.M735(text, M307(array), nFrame);
			if (array != null)
			{
				T64.M738(text, nFrame, array);
			}
		}
		catch (Exception)
		{
		}
	}

	private void M319(T115 d)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			M320(d, -1, isSave: true);
		}
		catch (Exception)
		{
		}
	}

	private void M320(T115 d, sbyte type, bool isSave)
	{
		try
		{
			d.M1089(100000);
			T54.vcItem = d.M1088();
			type = d.M1088();
			switch (type)
			{
			case 100:
				T13.Arr_Head_2Fr = M322(d);
				if (isSave)
				{
					d.M1090();
					sbyte[] data4 = new sbyte[d.M1104()];
					d.M1103(ref data4);
					T138.M1534("NRitem100", data4);
				}
				break;
			case 0:
			{
				T54.M559().iOptionTemplates = new T83[d.M1091()];
				for (int j = 0; j < T54.M559().iOptionTemplates.Length; j++)
				{
					T54.M559().iOptionTemplates[j] = new T83();
					T54.M559().iOptionTemplates[j].id = j;
					T54.M559().iOptionTemplates[j].name = d.M1100();
					T54.M559().iOptionTemplates[j].type = d.M1088();
				}
				if (isSave)
				{
					d.M1090();
					sbyte[] data2 = new sbyte[d.M1104()];
					d.M1103(ref data2);
					T138.M1534("NRitem0", data2);
				}
				break;
			}
			case 1:
			{
				T85.itemTemplates.M1075();
				int num3 = d.M1092();
				for (int k = 0; k < num3; k++)
				{
					T85.M833(new T84((short)k, d.M1088(), d.M1088(), d.M1100(), d.M1100(), d.M1088(), d.M1094(), d.M1092(), d.M1092(), d.M1097()));
				}
				if (isSave)
				{
					d.M1090();
					sbyte[] data3 = new sbyte[d.M1104()];
					d.M1103(ref data3);
					T138.M1534("NRitem1", data3);
				}
				break;
			}
			case 2:
			{
				short num = d.M1092();
				int num2 = d.M1092();
				for (int i = num; i < num2; i++)
				{
					T85.M833(new T84((short)i, d.M1088(), d.M1088(), d.M1100(), d.M1100(), d.M1088(), d.M1094(), d.M1092(), d.M1092(), d.M1097()));
				}
				if (isSave)
				{
					d.M1090();
					sbyte[] data = new sbyte[d.M1104()];
					d.M1103(ref data);
					T138.M1534("NRitem2", data);
					T138.M1534("NRitemVersion", new sbyte[1] { T54.vcItem });
					T90.isUpdateItem = false;
					if (T54.vsData == T54.vcData && T54.vsMap == T54.vcMap && T54.vsSkill == T54.vcSkill && T54.vsItem == T54.vcItem)
					{
						T54.M559().M557();
						T54.M559().M555();
						T54.M559().M556();
						T54.M559().M558();
						T146.M1594().M1679();
					}
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			ex.ToString();
		}
	}

	private void M321(T97 msg, int mobTemplateId)
	{
		try
		{
			int num = msg.M887().M1088();
			int[][] array = new int[num][];
			for (int i = 0; i < num; i++)
			{
				int num2 = msg.M887().M1088();
				array[i] = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					array[i][j] = msg.M887().M1088();
				}
			}
			frameHT_NEWBOSS.M1078(mobTemplateId + string.Empty, array);
		}
		catch (Exception)
		{
		}
	}

	private int[][] M322(T115 d)
	{
		int[][] array = new int[1][] { new int[2] { 542, 543 } };
		try
		{
			array = new int[d.M1092()][];
			for (int i = 0; i < array.Length; i++)
			{
				int num = d.M1088();
				array[i] = new int[num];
				for (int j = 0; j < num; j++)
				{
					array[i][j] = d.M1092();
				}
			}
			return array;
		}
		catch (Exception)
		{
			return array;
		}
	}

	public void M323(T97 msg)
	{
		try
		{
			sbyte b = msg.M887().M1088();
			if (b == 0)
			{
				M324(msg, b);
			}
		}
		catch (Exception)
		{
		}
	}

	private void M324(T97 msg, int type_PB)
	{
		try
		{
			switch (msg.M887().M1088())
			{
			case 0:
			{
				short idmapPaint = msg.M887().M1092();
				string nameTeam = msg.M887().M1100();
				string nameTeam2 = msg.M887().M1100();
				int maxPoint = msg.M887().M1094();
				short timeSecond2 = msg.M887().M1092();
				int maxLife = msg.M887().M1088();
				T54.phuban_Info = new T69(type_PB, idmapPaint, nameTeam, nameTeam2, maxPoint, timeSecond2);
				T54.phuban_Info.maxLife = maxLife;
				T54.phuban_Info.M765(type_PB, 0, 0);
				break;
			}
			case 1:
			{
				int pointTeam = msg.M887().M1094();
				int pointTeam2 = msg.M887().M1094();
				if (T54.phuban_Info != null)
				{
					T54.phuban_Info.M764(type_PB, pointTeam, pointTeam2);
				}
				break;
			}
			case 2:
			{
				sbyte b = msg.M887().M1088();
				short type = 0;
				switch (b)
				{
				case 2:
					type = 2;
					break;
				case 1:
					type = 1;
					break;
				}
				T54.phuban_Info = null;
				T54.M688(type, -1, T51.hw, T51.hh, 0, 0);
				break;
			}
			case 4:
			{
				int lifeTeam = msg.M887().M1088();
				int lifeTeam2 = msg.M887().M1088();
				if (T54.phuban_Info != null)
				{
					T54.phuban_Info.M765(type_PB, lifeTeam, lifeTeam2);
				}
				break;
			}
			case 5:
			{
				short timeSecond = msg.M887().M1092();
				if (T54.phuban_Info != null)
				{
					T54.phuban_Info.M763(type_PB, timeSecond);
				}
				break;
			}
			case 3:
				break;
			}
		}
		catch (Exception)
		{
		}
	}

	public void M325(T97 msg)
	{
		try
		{
			if (msg.M887().M1088() == 0)
			{
				short idHat = msg.M887().M1092();
				T13.M113().idHat = idHat;
				T160.M1826().M1829();
			}
		}
		catch (Exception)
		{
		}
	}
}
