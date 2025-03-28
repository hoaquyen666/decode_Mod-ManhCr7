using System;
using Assets.src.e;
using Assets.src.f;
using Assets.src.g;
using UnityEngine;

public class Controller : IMessageHandler
{
	protected static Controller me;

	protected static Controller me2;

	public Message messWait;

	public static bool isLoadingData;

	public static bool isConnectOK;

	public static bool isConnectionFail;

	public static bool isDisconnected;

	public static bool isMain;

	private float demCount;

	private int move;

	private int total;

	public static bool isStopReadMessage;

	public static MyHashTable frameHT_NEWBOSS = new MyHashTable();

	public const sbyte PHUBAN_TYPE_CHIENTRUONGNAMEK = 0;

	public const sbyte PHUBAN_START = 0;

	public const sbyte PHUBAN_UPDATE_POINT = 1;

	public const sbyte PHUBAN_END = 2;

	public const sbyte PHUBAN_LIFE = 4;

	public const sbyte PHUBAN_INFO = 5;

	public static Controller M300()
	{
		if (me == null)
		{
			me = new Controller();
		}
		return me;
	}

	public static Controller M301()
	{
		if (me2 == null)
		{
			me2 = new Controller();
		}
		return me2;
	}

	public void onConnectOK(bool isMain1)
	{
		isMain = isMain1;
		mSystem.M1064();
	}

	public void onConnectionFail(bool isMain1)
	{
		isMain = isMain1;
		mSystem.M1065();
	}

	public void onDisconnected(bool isMain1)
	{
		isMain = isMain1;
		mSystem.M1066();
	}

	public void M302(Message msg)
	{
		try
		{
			byte b = msg.M887().M1091();
			Item t = GameScr.currentCharViewInfo.arrItemBody[b];
			t.saleCoinLock = msg.M887().M1094();
			t.sys = msg.M887().M1088();
			t.options = new MyVector();
			try
			{
				while (true)
				{
					t.options.M1111(new ItemOption(msg.M887().M1091(), msg.M887().M1093()));
				}
			}
			catch (Exception ex)
			{
				Cout.M326("Loi tairequestItemPlayer 1" + ex.ToString());
			}
		}
		catch (Exception ex2)
		{
			Cout.M326("Loi tairequestItemPlayer 2" + ex2.ToString());
		}
	}

	public void onMessage(Message msg)
	{
		GameCanvas.debugSession.M1120();
		GameCanvas.M456("SA1", 2);
		try
		{
			mSystem.M1039(">>>cmd= " + msg.command);
			Char t = null;
			Mob t2 = null;
			MyVector t3 = new MyVector();
			int num = 0;
			Controller2.M2308(msg);
			switch (msg.command)
			{
			case 112:
			{
				sbyte b27 = msg.M887().M1088();
				Res.M1513("spec type= " + b27);
				switch (b27)
				{
				case 1:
				{
					sbyte b28 = msg.M887().M1088();
					Char.M113().infoSpeacialSkill = new string[b28][];
					Char.M113().imgSpeacialSkill = new short[b28][];
					GameCanvas.panel.speacialTabName = new string[b28][];
					for (int num55 = 0; num55 < b28; num55++)
					{
						GameCanvas.panel.speacialTabName[num55] = new string[2];
						string[] array4 = Res.M1531(msg.M887().M1100(), "\n", 0);
						if (array4.Length == 2)
						{
							GameCanvas.panel.speacialTabName[num55] = array4;
						}
						if (array4.Length == 1)
						{
							GameCanvas.panel.speacialTabName[num55][0] = array4[0];
							GameCanvas.panel.speacialTabName[num55][1] = string.Empty;
						}
						int num56 = msg.M887().M1088();
						Char.M113().infoSpeacialSkill[num55] = new string[num56];
						Char.M113().imgSpeacialSkill[num55] = new short[num56];
						for (int num57 = 0; num57 < num56; num57++)
						{
							Char.M113().imgSpeacialSkill[num55][num57] = msg.M887().M1092();
							Char.M113().infoSpeacialSkill[num55][num57] = msg.M887().M1100();
						}
					}
					GameCanvas.panel.tabName[25] = GameCanvas.panel.speacialTabName;
					GameCanvas.panel.M1441();
					GameCanvas.panel.M1285();
					break;
				}
				case 0:
					Panel.spearcialImage = msg.M887().M1092();
					Panel.specialInfo = msg.M887().M1100();
					break;
				}
				break;
			}
			case -112:
			{
				sbyte b26 = msg.M887().M1088();
				if (b26 == 0)
				{
					GameScr.M627(msg.M887().M1088()).M977();
				}
				if (b26 == 1)
				{
					GameScr.M627(msg.M887().M1088()).M976(msg.M887().M1092());
				}
				break;
			}
			case -107:
			{
				sbyte b20 = msg.M887().M1088();
				if (b20 == 0)
				{
					Char.M113().havePet = false;
				}
				if (b20 == 1)
				{
					Char.M113().havePet = true;
				}
				if (b20 != 2)
				{
					break;
				}
				InfoDlg.M753();
				Char.M114().head = msg.M887().M1092();
				Char.M114().M165();
				int num25 = msg.M887().M1091();
				Res.M1513("num body = " + num25);
				Char.M114().arrItemBody = new Item[num25];
				for (int num26 = 0; num26 < num25; num26++)
				{
					short num27 = msg.M887().M1092();
					Res.M1513("template id= " + num27);
					if (num27 == -1)
					{
						continue;
					}
					Res.M1513("1");
					Char.M114().arrItemBody[num26] = new Item();
					Char.M114().arrItemBody[num26].template = ItemTemplates.M834(num27);
					int type = Char.M114().arrItemBody[num26].template.type;
					Char.M114().arrItemBody[num26].quantity = msg.M887().M1094();
					Res.M1513("3");
					Char.M114().arrItemBody[num26].info = msg.M887().M1100();
					Char.M114().arrItemBody[num26].content = msg.M887().M1100();
					int num28 = msg.M887().M1091();
					Res.M1513("option size= " + num28);
					if (num28 != 0)
					{
						Char.M114().arrItemBody[num26].itemOption = new ItemOption[num28];
						for (int num29 = 0; num29 < Char.M114().arrItemBody[num26].itemOption.Length; num29++)
						{
							int optionTemplateId3 = msg.M887().M1091();
							ushort param3 = msg.M887().M1093();
							Char.M114().arrItemBody[num26].itemOption[num29] = new ItemOption(optionTemplateId3, param3);
						}
					}
					switch (type)
					{
					case 1:
						Char.M114().leg = Char.M114().arrItemBody[num26].template.part;
						break;
					case 0:
						Char.M114().body = Char.M114().arrItemBody[num26].template.part;
						break;
					}
				}
				Char.M114().cHP = msg.M889();
				Char.M114().cHPFull = msg.M889();
				Char.M114().cMP = msg.M889();
				Char.M114().cMPFull = msg.M889();
				Char.M114().cDamFull = msg.M889();
				Char.M114().cName = msg.M887().M1100();
				Char.M114().currStrLevel = msg.M887().M1100();
				Char.M114().cPower = msg.M887().M1095();
				Char.M114().cTiemNang = msg.M887().M1095();
				Char.M114().petStatus = msg.M887().M1088();
				Char.M114().cStamina = msg.M887().M1092();
				Char.M114().cMaxStamina = msg.M887().M1092();
				Char.M114().cCriticalFull = msg.M887().M1088();
				Char.M114().cDefull = msg.M887().M1092();
				Char.M114().arrPetSkill = new Skill[msg.M887().M1088()];
				Res.M1513("SKILLENT = " + Char.M114().arrPetSkill);
				for (int num30 = 0; num30 < Char.M114().arrPetSkill.Length; num30++)
				{
					short num31 = msg.M887().M1092();
					if (num31 != -1)
					{
						Char.M114().arrPetSkill[num30] = Skills.M1773(num31);
						continue;
					}
					Char.M114().arrPetSkill[num30] = new Skill();
					Char.M114().arrPetSkill[num30].template = null;
					Char.M114().arrPetSkill[num30].moreInfo = msg.M887().M1100();
				}
				if (GameCanvas.w > 2 * Panel.WIDTH_PANEL)
				{
					GameCanvas.panel2 = new Panel();
					GameCanvas.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
					GameCanvas.panel2.M1253();
					GameCanvas.panel2.M1285();
					GameCanvas.panel.M1274();
					GameCanvas.panel.M1285();
				}
				else
				{
					GameCanvas.panel.tabName[21] = mResources.petMainTab;
					GameCanvas.panel.M1274();
					GameCanvas.panel.M1285();
				}
				break;
			}
			case -99:
				InfoDlg.M753();
				if (msg.M887().M1088() == 0)
				{
					GameCanvas.panel.vEnemy.M1120();
					int num123 = msg.M887().M1091();
					for (int num124 = 0; num124 < num123; num124++)
					{
						Char t42 = new Char();
						t42.charID = msg.M887().M1094();
						t42.head = msg.M887().M1092();
						t42.headICON = msg.M887().M1092();
						t42.body = msg.M887().M1092();
						t42.leg = msg.M887().M1092();
						t42.bag = msg.M887().M1092();
						t42.cName = msg.M887().M1100();
						InfoItem t43 = new InfoItem(msg.M887().M1100());
						bool isOnline2 = msg.M887().M1097();
						t43.charInfo = t42;
						t43.isOnline = isOnline2;
						Res.M1513("isonline = " + isOnline2);
						GameCanvas.panel.vEnemy.M1111(t43);
					}
					GameCanvas.panel.M1261();
					GameCanvas.panel.M1285();
				}
				break;
			case -98:
			{
				sbyte b16 = msg.M887().M1088();
				GameCanvas.menu.showMenu = false;
				if (b16 == 0)
				{
					GameCanvas.M496(msg.M887().M1100(), new Command(mResources.YES, GameCanvas.instance, 888397, msg.M887().M1100()), new Command(mResources.NO, GameCanvas.instance, 888396, null));
				}
				break;
			}
			case -97:
				Char.M113().cNangdong = msg.M887().M1094();
				break;
			case -96:
			{
				sbyte t47 = msg.M887().M1088();
				GameCanvas.panel.vTop.M1120();
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
					TopInfo t48 = new TopInfo();
					t48.rank = rank;
					t48.headID = headID;
					t48.headICON = headICON;
					t48.body = body;
					t48.leg = leg;
					t48.name = name2;
					t48.info = info4;
					t48.info2 = msg.M887().M1100();
					t48.pId = pId;
					GameCanvas.panel.vTop.M1111(t48);
				}
				GameCanvas.panel.topName = topName;
				GameCanvas.panel.M1262(t47);
				GameCanvas.panel.M1285();
				break;
			}
			case -95:
			{
				sbyte b51 = msg.M887().M1088();
				Res.M1513("type= " + b51);
				if (b51 == 0)
				{
					int num134 = msg.M887().M1094();
					short templateId = msg.M887().M1092();
					int num135 = msg.M889();
					SoundMn.M1826().M1844();
					if (num134 == Char.M113().charID)
					{
						Char.M113().mobMe = new Mob(num134, isDisable: false, isDontMove: false, isFire: false, isIce: false, isWind: false, templateId, 1, num135, 0, num135, (short)(Char.M113().cx + ((Char.M113().cdir != 1) ? (-40) : 40)), (short)Char.M113().cy, 4, 0);
						Char.M113().mobMe.isMobMe = true;
						EffectMn.M376(new Effect(18, Char.M113().mobMe.x, Char.M113().mobMe.y, 2, 10, -1));
						Char.M113().tMobMeBorn = 30;
						GameScr.vMob.M1111(Char.M113().mobMe);
					}
					else
					{
						t = GameScr.M626(num134);
						if (t != null)
						{
							Mob t49 = new Mob(num134, isDisable: false, isDontMove: false, isFire: false, isIce: false, isWind: false, templateId, 1, num135, 0, num135, (short)t.cx, (short)t.cy, 4, 0);
							t49.isMobMe = true;
							t.mobMe = t49;
							GameScr.vMob.M1111(t.mobMe);
						}
						else if (GameScr.M628(num134) == null)
						{
							Mob t50 = new Mob(num134, isDisable: false, isDontMove: false, isFire: false, isIce: false, isWind: false, templateId, 1, num135, 0, num135, -100, -100, 4, 0);
							t50.isMobMe = true;
							GameScr.vMob.M1111(t50);
						}
					}
				}
				if (b51 == 1)
				{
					int num136 = msg.M887().M1094();
					int mobId = msg.M887().M1088();
					Res.M1513("mod attack id= " + num136);
					if (num136 == Char.M113().charID)
					{
						if (GameScr.M628(mobId) != null)
						{
							Char.M113().mobMe.M1004(GameScr.M628(mobId));
						}
					}
					else
					{
						t = GameScr.M626(num136);
						if (t != null && GameScr.M628(mobId) != null)
						{
							t.mobMe.M1004(GameScr.M628(mobId));
						}
					}
				}
				if (b51 == 2)
				{
					int num137 = msg.M887().M1094();
					int num138 = msg.M887().M1094();
					int num139 = msg.M889();
					int cHPNew = msg.M889();
					if (num137 == Char.M113().charID)
					{
						Res.M1513("mob dame= " + num139);
						t = GameScr.M626(num138);
						if (t != null)
						{
							t.cHPNew = cHPNew;
							if (Char.M113().mobMe.isBusyAttackSomeOne)
							{
								t.M218(num139, 0, isCrit: false, isMob: true);
							}
							else
							{
								Char.M113().mobMe.dame = num139;
								Char.M113().mobMe.M990(t);
							}
						}
					}
					else
					{
						t2 = GameScr.M628(num137);
						if (t2 != null)
						{
							if (num138 == Char.M113().charID)
							{
								Char.M113().cHPNew = cHPNew;
								if (t2.isBusyAttackSomeOne)
								{
									Char.M113().M218(num139, 0, isCrit: false, isMob: true);
								}
								else
								{
									t2.dame = num139;
									t2.M990(Char.M113());
								}
							}
							else
							{
								t = GameScr.M626(num138);
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
					t = ((Char.M113().charID != num140) ? GameScr.M626(num140) : Char.M113());
					if (t != null)
					{
						t2 = GameScr.M628(mobId2);
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
								GameScr.M643(mResources.miss, t2.x, t2.y - t2.h, 0, -2, mFont.MISS);
							}
							else
							{
								GameScr.M643("-" + num141, t2.x, t2.y - t2.h, 0, -2, mFont.ORANGE);
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
					t = ((num142 != Char.M113().charID) ? GameScr.M626(num142) : Char.M113());
					if (t == null)
					{
						return;
					}
					if ((TileMap.M1957(t.cx, t.cy) & 2) == 2)
					{
						t.M172(GameScr.sks[b52], 0);
					}
					else
					{
						t.M172(GameScr.sks[b52], 1);
					}
					Mob t51 = GameScr.M628(mobId3);
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
					GameCanvas.M456("SA83v2", 2);
					if (num143 == 0)
					{
						t51.x = t51.xFirst;
						t51.y = t51.yFirst;
						GameScr.M643(mResources.miss, t51.x, t51.y - t51.h, 0, -2, mFont.MISS);
					}
					else
					{
						GameScr.M643("-" + num143, t51.x, t51.y - t51.h, 0, -2, mFont.ORANGE);
					}
				}
				if (b51 == 6)
				{
					int num144 = msg.M887().M1094();
					if (num144 == Char.M113().charID)
					{
						Char.M113().mobMe.M1003();
					}
					else
					{
						GameScr.M626(num144)?.mobMe.M1003();
					}
				}
				if (b51 != 7)
				{
					break;
				}
				int num145 = msg.M887().M1094();
				if (num145 == Char.M113().charID)
				{
					Char.M113().mobMe = null;
					for (int num146 = 0; num146 < GameScr.vMob.M1113(); num146++)
					{
						if (((Mob)GameScr.vMob.M1114(num146)).mobId == num145)
						{
							GameScr.vMob.M1118(num146);
						}
					}
					break;
				}
				t = GameScr.M626(num145);
				for (int num147 = 0; num147 < GameScr.vMob.M1113(); num147++)
				{
					if (((Mob)GameScr.vMob.M1114(num147)).mobId == num145)
					{
						GameScr.vMob.M1118(num147);
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
					for (int num46 = 0; num46 < Char.M113().vSkill.M1113(); num46++)
					{
						Skill t18 = (Skill)Char.M113().vSkill.M1114(num46);
						if (t18 != null && t18.skillId == num44)
						{
							if (num45 < t18.coolDown)
							{
								t18.lastTimeUseThisSkill = mSystem.M1054() - (t18.coolDown - num45);
							}
							Res.M1513("1 chieu id= " + t18.template.id + " cooldown= " + num45 + "curr cool down= " + t18.coolDown);
						}
					}
				}
				break;
			case -93:
			{
				short num93 = msg.M887().M1092();
				BgItem.newSmallVersion = new sbyte[num93];
				for (int num94 = 0; num94 < num93; num94++)
				{
					BgItem.newSmallVersion[num94] = msg.M887().M1088();
				}
				break;
			}
			case -92:
				Main.typeClient = msg.M887().M1088();
				Rms.M1547();
				Rms.M1543("clienttype", Main.typeClient);
				Rms.M1543("lastZoomlevel", mGraphics.zoomLevel);
				GameCanvas.M494(mResources.plsRestartGame, 8885, null);
				break;
			case -91:
			{
				sbyte b23 = msg.M887().M1088();
				GameCanvas.panel.mapNames = new string[b23];
				GameCanvas.panel.planetNames = new string[b23];
				for (int num48 = 0; num48 < b23; num48++)
				{
					GameCanvas.panel.mapNames[num48] = msg.M887().M1100();
					GameCanvas.panel.planetNames[num48] = msg.M887().M1100();
				}
				GameCanvas.panel.M1247();
				GameCanvas.panel.M1285();
				break;
			}
			case -90:
			{
				sbyte b33 = msg.M887().M1088();
				Res.M1513("type = " + b33);
				int num68 = msg.M887().M1094();
				if (b33 != -1)
				{
					short num69 = msg.M887().M1092();
					short num70 = msg.M887().M1092();
					short num71 = msg.M887().M1092();
					sbyte isMonkey = msg.M887().M1088();
					Res.M1513("is Monkey = " + isMonkey);
					if (Char.M113().charID == num68)
					{
						Char.M113().isMask = true;
						Char.M113().isMonkey = isMonkey;
						if (Char.M113().isMonkey != 0)
						{
							Char.M113().isWaitMonkey = false;
							Char.M113().isLockMove = false;
						}
					}
					else if (GameScr.M626(num68) != null)
					{
						GameScr.M626(num68).isMask = true;
						GameScr.M626(num68).isMonkey = isMonkey;
					}
					if (num69 != -1)
					{
						if (num68 == Char.M113().charID)
						{
							Char.M113().head = num69;
						}
						else if (GameScr.M626(num68) != null)
						{
							GameScr.M626(num68).head = num69;
						}
					}
					if (num70 != -1)
					{
						if (num68 == Char.M113().charID)
						{
							Char.M113().body = num70;
						}
						else if (GameScr.M626(num68) != null)
						{
							GameScr.M626(num68).body = num70;
						}
					}
					if (num71 != -1)
					{
						if (num68 == Char.M113().charID)
						{
							Char.M113().leg = num71;
						}
						else if (GameScr.M626(num68) != null)
						{
							GameScr.M626(num68).leg = num71;
						}
					}
				}
				if (b33 == -1)
				{
					if (Char.M113().charID == num68)
					{
						Char.M113().isMask = false;
						Char.M113().isMonkey = 0;
					}
					else if (GameScr.M626(num68) != null)
					{
						GameScr.M626(num68).isMask = false;
						GameScr.M626(num68).isMonkey = 0;
					}
				}
				break;
			}
			case -88:
				GameCanvas.M488();
				GameCanvas.serverScreen.switchToMe();
				break;
			case -87:
			{
				Res.M1513("GET UPDATE_DATA " + msg.M887().M1104() + " bytes");
				msg.M887().M1089(100000);
				M306(msg.M887(), isSaveRMS: true);
				msg.M887().M1090();
				sbyte[] data4 = new sbyte[msg.M887().M1104()];
				msg.M887().M1103(ref data4);
				Rms.M1534("NRdataVersion", new sbyte[1] { GameScr.vcData });
				LoginScr.isUpdateData = false;
				if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
				{
					Res.M1513(GameScr.vsData + "," + GameScr.vsMap + "," + GameScr.vsSkill + "," + GameScr.vsItem);
					GameScr.M559().M557();
					GameScr.M559().M555();
					GameScr.M559().M556();
					GameScr.M559().M558();
					Service.M1594().M1679();
					return;
				}
				break;
			}
			case -86:
			{
				sbyte b9 = msg.M887().M1088();
				Res.M1513("server gui ve giao dich action = " + b9);
				if (b9 == 0)
				{
					int playerID = msg.M887().M1094();
					GameScr.M559().M670(playerID);
				}
				if (b9 == 1)
				{
					int num11 = msg.M887().M1094();
					Char t6 = GameScr.M626(num11);
					if (t6 == null)
					{
						return;
					}
					GameCanvas.panel.M1297(t6);
					GameCanvas.panel.M1285();
					Service.M1594().M1610(num11);
				}
				if (b9 == 2)
				{
					sbyte b10 = msg.M887().M1088();
					for (int l = 0; l < GameCanvas.panel.vMyGD.M1113(); l++)
					{
						Item t7 = (Item)GameCanvas.panel.vMyGD.M1114(l);
						if (t7.indexUI == b10)
						{
							GameCanvas.panel.vMyGD.M1119(t7);
							break;
						}
					}
				}
				if (b9 == 6)
				{
					GameCanvas.panel.isFriendLock = true;
					if (GameCanvas.panel2 != null)
					{
						GameCanvas.panel2.isFriendLock = true;
					}
					GameCanvas.panel.vFriendGD.M1120();
					if (GameCanvas.panel2 != null)
					{
						GameCanvas.panel2.vFriendGD.M1120();
					}
					int friendMoneyGD = msg.M887().M1094();
					sbyte b11 = msg.M887().M1088();
					Res.M1513("item size = " + b11);
					for (int m = 0; m < b11; m++)
					{
						Item t8 = new Item();
						t8.template = ItemTemplates.M834(msg.M887().M1092());
						t8.quantity = msg.M887().M1094();
						int num12 = msg.M887().M1091();
						if (num12 != 0)
						{
							t8.itemOption = new ItemOption[num12];
							for (int n = 0; n < t8.itemOption.Length; n++)
							{
								int optionTemplateId = msg.M887().M1091();
								ushort param = msg.M887().M1093();
								t8.itemOption[n] = new ItemOption(optionTemplateId, param);
								t8.compare = GameCanvas.panel.M1365(t8);
							}
						}
						if (GameCanvas.panel2 != null)
						{
							GameCanvas.panel2.vFriendGD.M1111(t8);
						}
						else
						{
							GameCanvas.panel.vFriendGD.M1111(t8);
						}
					}
					if (GameCanvas.panel2 != null)
					{
						GameCanvas.panel2.M1296(isMe: false);
						GameCanvas.panel2.friendMoneyGD = friendMoneyGD;
					}
					else
					{
						GameCanvas.panel.friendMoneyGD = friendMoneyGD;
						if (GameCanvas.panel.currentTabIndex == 2)
						{
							GameCanvas.panel.M1296(isMe: false);
						}
					}
				}
				if (b9 == 7)
				{
					InfoDlg.M753();
					if (GameCanvas.panel.isShow)
					{
						GameCanvas.panel.M1382();
					}
				}
				break;
			}
			case -85:
			{
				Res.M1513("CAP CHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
				sbyte b3 = msg.M887().M1088();
				if (b3 == 0)
				{
					int num3 = msg.M887().M1093();
					Res.M1513("lent =" + num3);
					sbyte[] data = new sbyte[num3];
					msg.M887().M1109(ref data, 0, num3);
					GameScr.imgCapcha = Image.M708(data, 0, num3);
					GameScr.M559().keyInput = "-----";
					GameScr.M559().strCapcha = msg.M887().M1100();
					GameScr.M559().keyCapcha = new int[GameScr.M559().strCapcha.Length];
					GameScr.M559().mobCapcha = new Mob();
					GameScr.M559().right = null;
				}
				if (b3 == 1)
				{
					MobCapcha.isAttack = true;
				}
				if (b3 == 2)
				{
					MobCapcha.explode = true;
					GameScr.M559().right = GameScr.M559().cmdFocus;
				}
				break;
			}
			case -84:
			{
				int index2 = msg.M887().M1091();
				Mob t31 = null;
				try
				{
					t31 = (Mob)GameScr.vMob.M1114(index2);
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
						GameScr.M559().isRongNamek = true;
					}
					else
					{
						GameScr.M559().isRongNamek = false;
					}
					GameScr.M559().xR = xR;
					GameScr.M559().yR = yR;
					Res.M1513("xR= " + xR + " yR= " + yR + " +++++++++++++++++++++++++++++++++++++++");
					if (Char.M113().charID == num110)
					{
						GameCanvas.panel.M1381();
						GameScr.M559().M591(isMe: true);
					}
					else if (TileMap.mapID == num108 && TileMap.zoneID == num109)
					{
						GameScr.M559().M591(isMe: false);
					}
					else if (mGraphics.zoomLevel > 1)
					{
						GameScr.M559().M593();
					}
					GameScr.M559().mapRID = num108;
					GameScr.M559().bgRID = bgRID;
					GameScr.M559().zoneRID = num109;
				}
				if (b42 == 1)
				{
					Res.M1513("map RID = " + GameScr.M559().mapRID + " zone RID= " + GameScr.M559().zoneRID);
					Res.M1513("map ID = " + TileMap.mapID + " zone ID= " + TileMap.zoneID);
					if (TileMap.mapID == GameScr.M559().mapRID && TileMap.zoneID == GameScr.M559().zoneRID)
					{
						GameScr.M559().M592();
					}
					else
					{
						GameScr.M559().isRongThanXuatHien = false;
						if (GameScr.M559().isRongNamek)
						{
							GameScr.M559().isRongNamek = false;
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
				TileMap.tileIndex = new int[b43][][];
				TileMap.tileType = new int[b43][];
				for (int num111 = 0; num111 < b43; num111++)
				{
					sbyte b44 = msg.M887().M1088();
					TileMap.tileType[num111] = new int[b44];
					TileMap.tileIndex[num111] = new int[b44][];
					for (int num112 = 0; num112 < b44; num112++)
					{
						TileMap.tileType[num111][num112] = msg.M887().M1094();
						sbyte b45 = msg.M887().M1088();
						TileMap.tileIndex[num111][num112] = new int[b45];
						for (int num113 = 0; num113 < b45; num113++)
						{
							TileMap.tileIndex[num111][num112][num113] = msg.M887().M1088();
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
					GameCanvas.panel.M1270();
					GameCanvas.panel.combineInfo = mFont.tahoma_7b_blue.M907(src, Panel.WIDTH_PANEL);
					GameCanvas.panel.combineTopInfo = mFont.tahoma_7.M907(src2, Panel.WIDTH_PANEL);
					GameCanvas.panel.M1285();
				}
				if (b35 == 1)
				{
					GameCanvas.panel.vItemCombine.M1120();
					sbyte b36 = msg.M887().M1088();
					for (int num79 = 0; num79 < b36; num79++)
					{
						sbyte b37 = msg.M887().M1088();
						for (int num80 = 0; num80 < Char.M113().arrItemBag.Length; num80++)
						{
							Item t29 = Char.M113().arrItemBag[num80];
							if (t29 != null && t29.indexUI == b37)
							{
								t29.isSelect = true;
								GameCanvas.panel.vItemCombine.M1111(t29);
							}
						}
					}
					if (GameCanvas.panel.isShow)
					{
						GameCanvas.panel.M1271();
					}
				}
				if (b35 == 2)
				{
					GameCanvas.panel.combineSuccess = 0;
					GameCanvas.panel.M1426(0);
				}
				if (b35 == 3)
				{
					GameCanvas.panel.combineSuccess = 1;
					GameCanvas.panel.M1426(0);
				}
				if (b35 == 4)
				{
					short iconID = msg.M887().M1092();
					GameCanvas.panel.iconID3 = iconID;
					GameCanvas.panel.combineSuccess = 0;
					GameCanvas.panel.M1426(1);
				}
				if (b35 == 5)
				{
					short iconID2 = msg.M887().M1092();
					GameCanvas.panel.iconID3 = iconID2;
					GameCanvas.panel.combineSuccess = 0;
					GameCanvas.panel.M1426(2);
				}
				if (b35 == 6)
				{
					short iconID3 = msg.M887().M1092();
					short iconID4 = msg.M887().M1092();
					GameCanvas.panel.combineSuccess = 0;
					GameCanvas.panel.M1426(3);
					GameCanvas.panel.iconID1 = iconID3;
					GameCanvas.panel.iconID3 = iconID4;
				}
				if (b35 == 7)
				{
					short iconID5 = msg.M887().M1092();
					GameCanvas.panel.iconID3 = iconID5;
					GameCanvas.panel.combineSuccess = 0;
					GameCanvas.panel.M1426(4);
				}
				if (b35 == 8)
				{
					GameCanvas.panel.iconID3 = -1;
					GameCanvas.panel.combineSuccess = 1;
					GameCanvas.panel.M1426(4);
				}
				short num81 = 21;
				try
				{
					num81 = msg.M887().M1092();
				}
				catch (Exception)
				{
				}
				for (int num82 = 0; num82 < GameScr.vNpc.M1113(); num82++)
				{
					Npc t30 = (Npc)GameScr.vNpc.M1114(num82);
					if (t30.template.npcTemplateId == num81)
					{
						GameCanvas.panel.xS = t30.cx - GameScr.cmx;
						GameCanvas.panel.yS = t30.cy - GameScr.cmy;
						GameCanvas.panel.idNPC = num81;
						break;
					}
				}
				break;
			}
			case -80:
			{
				sbyte b22 = msg.M887().M1088();
				InfoDlg.M753();
				if (b22 == 0)
				{
					GameCanvas.panel.vFriend.M1120();
					int num38 = msg.M887().M1091();
					for (int num39 = 0; num39 < num38; num39++)
					{
						Char t14 = new Char();
						t14.charID = msg.M887().M1094();
						t14.head = msg.M887().M1092();
						t14.headICON = msg.M887().M1092();
						t14.body = msg.M887().M1092();
						t14.leg = msg.M887().M1092();
						t14.bag = msg.M887().M1091();
						t14.cName = msg.M887().M1100();
						bool isOnline = msg.M887().M1097();
						InfoItem t15 = new InfoItem(mResources.power + ": " + msg.M887().M1100());
						t15.charInfo = t14;
						t15.isOnline = isOnline;
						GameCanvas.panel.vFriend.M1111(t15);
					}
					GameCanvas.panel.M1260();
					GameCanvas.panel.M1285();
				}
				if (b22 == 3)
				{
					MyVector vFriend = GameCanvas.panel.vFriend;
					int num40 = msg.M887().M1094();
					Res.M1513("online offline id=" + num40);
					for (int num41 = 0; num41 < vFriend.M1113(); num41++)
					{
						InfoItem t16 = (InfoItem)vFriend.M1114(num41);
						if (t16.charInfo != null && t16.charInfo.charID == num40)
						{
							Res.M1513("online= " + t16.isOnline);
							t16.isOnline = msg.M887().M1097();
							break;
						}
					}
				}
				if (b22 != 2)
				{
					break;
				}
				MyVector vFriend2 = GameCanvas.panel.vFriend;
				int num42 = msg.M887().M1094();
				for (int num43 = 0; num43 < vFriend2.M1113(); num43++)
				{
					InfoItem t17 = (InfoItem)vFriend2.M1114(num43);
					if (t17.charInfo != null && t17.charInfo.charID == num42)
					{
						vFriend2.M1119(t17);
						break;
					}
				}
				if (GameCanvas.panel.isShow)
				{
					GameCanvas.panel.M1264();
				}
				break;
			}
			case -79:
			{
				InfoDlg.M753();
				msg.M887().M1094();
				Char charMenu = GameCanvas.panel.charMenu;
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
				SmallImage.newSmallVersion = new sbyte[num131];
				SmallImage.maxSmall = num131;
				SmallImage.imgNew = new Small[num131];
				for (int num132 = 0; num132 < num131; num132++)
				{
					SmallImage.newSmallVersion[num132] = msg.M887().M1088();
				}
				break;
			}
			case -76:
				switch (msg.M887().M1088())
				{
				case 1:
				{
					int num149 = msg.M887().M1091();
					if (Char.M113().arrArchive[num149] != null)
					{
						Char.M113().arrArchive[num149].isRecieve = true;
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
					Char.M113().arrArchive = new Archivement[b53];
					for (int num148 = 0; num148 < b53; num148++)
					{
						Char.M113().arrArchive[num148] = new Archivement();
						Char.M113().arrArchive[num148].info1 = num148 + 1 + ". " + msg.M887().M1100();
						Char.M113().arrArchive[num148].info2 = msg.M887().M1100();
						Char.M113().arrArchive[num148].money = msg.M887().M1092();
						Char.M113().arrArchive[num148].isFinish = msg.M887().M1097();
						Char.M113().arrArchive[num148].isRecieve = msg.M887().M1097();
					}
					GameCanvas.panel.M1250();
					GameCanvas.panel.M1285();
					break;
				}
				}
				break;
			case -74:
			{
				if (ServerListScreen.stopDownload)
				{
					return;
				}
				if (!GameCanvas.M501())
				{
					Service.M1594().M1720(3, null);
					SmallImage.M1777();
					SplashScr.imgLogo = null;
					if (Rms.M1536("acc") != null || Rms.M1536("userAo" + ServerListScreen.ipSelect) != null)
					{
						LoginScr.isContinueToLogin = true;
					}
					GameCanvas.loginScr = new LoginScr();
					GameCanvas.loginScr.switchToMe();
					return;
				}
				bool flag = true;
				sbyte b8 = msg.M887().M1088();
				Res.M1513("action = " + b8);
				if (b8 == 0)
				{
					int num7 = msg.M887().M1094();
					string text3 = Rms.M1536("ResVersion");
					int num8 = ((text3 == null || !(text3 != string.Empty)) ? (-1) : int.Parse(text3));
					if (num8 != -1 && num8 == num7)
					{
						Res.M1513("login ngay");
						SmallImage.M1777();
						SplashScr.imgLogo = null;
						ServerListScreen.loadScreen = true;
						if (GameCanvas.currentScreen != GameCanvas.loginScr)
						{
							GameCanvas.serverScreen.switchToMe();
						}
					}
					else
					{
						ServerListScreen.loadScreen = false;
						GameCanvas.serverScreen.M1592();
					}
				}
				if (b8 == 1)
				{
					ServerListScreen.strWait = mResources.downloading_data;
					ServerListScreen.nBig = msg.M887().M1092();
					Service.M1594().M1720(2, null);
				}
				if (b8 == 2)
				{
					try
					{
						isLoadingData = true;
						GameCanvas.M488();
						ServerListScreen.demPercent++;
						ServerListScreen.percent = ServerListScreen.demPercent * 100 / ServerListScreen.nBig;
						string[] array = Res.M1531(msg.M887().M1100(), "/", 0);
						string filename = "x" + mGraphics.zoomLevel + array[array.Length - 1];
						int num9 = msg.M887().M1094();
						sbyte[] data2 = new sbyte[num9];
						msg.M887().M1109(ref data2, 0, num9);
						Rms.M1534(filename, data2);
					}
					catch (Exception)
					{
						GameCanvas.M494(mResources.pls_restart_game_error, 8885, null);
					}
				}
				if (b8 == 3 && flag)
				{
					isLoadingData = false;
					int num10 = msg.M887().M1094();
					Res.M1513("last version= " + num10);
					Rms.M1538("ResVersion", num10 + string.Empty);
					Service.M1594().M1720(3, null);
					GameCanvas.M488();
					SplashScr.imgLogo = null;
					SmallImage.M1777();
					mSystem.M1062();
					ServerListScreen.bigOk = true;
					ServerListScreen.loadScreen = true;
					GameScr.M559().M561();
					if (GameCanvas.currentScreen != GameCanvas.loginScr)
					{
						GameCanvas.serverScreen.switchToMe();
					}
				}
				break;
			}
			case -70:
			{
				Res.M1513("BIG MESSAGE .......................................");
				GameCanvas.M488();
				int avatar = msg.M887().M1092();
				ChatPopup.M268(msg.M887().M1100(), 100000, new Npc(-1, 0, 0, 0, 0, 0)
				{
					avatar = avatar
				});
				sbyte b56 = msg.M887().M1088();
				if (b56 == 0)
				{
					ChatPopup.serverChatPopUp.cmdMsg1 = new Command(mResources.CLOSE, ChatPopup.serverChatPopUp, 1001, null);
					ChatPopup.serverChatPopUp.cmdMsg1.x = GameCanvas.w / 2 - 35;
					ChatPopup.serverChatPopUp.cmdMsg1.y = GameCanvas.h - 35;
				}
				if (b56 == 1)
				{
					string p2 = msg.M887().M1100();
					string caption2 = msg.M887().M1100();
					ChatPopup.serverChatPopUp.cmdMsg1 = new Command(caption2, ChatPopup.serverChatPopUp, 1000, p2);
					ChatPopup.serverChatPopUp.cmdMsg1.x = GameCanvas.w / 2 - 75;
					ChatPopup.serverChatPopUp.cmdMsg1.y = GameCanvas.h - 35;
					ChatPopup.serverChatPopUp.cmdMsg2 = new Command(mResources.CLOSE, ChatPopup.serverChatPopUp, 1001, null);
					ChatPopup.serverChatPopUp.cmdMsg2.x = GameCanvas.w / 2 + 11;
					ChatPopup.serverChatPopUp.cmdMsg2.y = GameCanvas.h - 35;
				}
				break;
			}
			case -69:
				Char.M113().cMaxStamina = msg.M887().M1092();
				break;
			case -68:
				Char.M113().cStamina = msg.M887().M1092();
				break;
			case -67:
			{
				Res.M1513("RECIEVE ICON");
				demCount += 1f;
				int num107 = msg.M887().M1094();
				sbyte[] array10 = null;
				try
				{
					array10 = NinjaUtil.M1185(msg);
					Res.M1513("request hinh icon = " + num107);
					if (num107 == 3896)
					{
						Res.M1513("SIZE CHECK= " + array10.Length);
					}
					SmallImage.imgNew[num107].img = M307(array10);
				}
				catch (Exception)
				{
					array10 = null;
					SmallImage.imgNew[num107].img = Image.M711(new int[1], 1, 1, bl: true);
				}
				if (array10 != null && mGraphics.zoomLevel > 1)
				{
					Rms.M1534(mGraphics.zoomLevel + "Small" + num107, array10);
				}
				break;
			}
			case -66:
			{
				short id3 = msg.M887().M1092();
				sbyte[] data3 = NinjaUtil.M1185(msg);
				EffectData t32 = Effect.M387(id3);
				sbyte b39 = msg.M887().M1086();
				if (b39 == 0)
				{
					t32.M399(data3);
				}
				else
				{
					t32.M400(data3, b39);
				}
				sbyte[] array6 = NinjaUtil.M1185(msg);
				t32.img = Image.M708(array6, 0, array6.Length);
				break;
			}
			case -65:
			{
				Res.M1513("TELEPORT ...................................................");
				InfoDlg.M753();
				int num13 = msg.M887().M1094();
				sbyte b12 = msg.M887().M1088();
				if (b12 == 0)
				{
					break;
				}
				if (Char.M113().charID == num13)
				{
					isStopReadMessage = true;
					GameScr.lockTick = 500;
					GameScr.M559().center = null;
					if (b12 == 0 || b12 == 1 || b12 == 3)
					{
						Teleport.M1894(new Teleport(Char.M113().cx, Char.M113().cy, Char.M113().head, Char.M113().cdir, 0, isMe: true, (b12 != 1) ? b12 : Char.M113().cgender));
					}
					if (b12 == 2)
					{
						GameScr.lockTick = 50;
						Char.M113().M139();
					}
				}
				else
				{
					Char t9 = GameScr.M626(num13);
					if ((b12 == 0 || b12 == 1 || b12 == 3) && t9 != null)
					{
						t9.isUsePlane = true;
						Teleport t10 = new Teleport(t9.cx, t9.cy, t9.head, t9.cdir, 0, isMe: false, (b12 != 1) ? b12 : t9.cgender);
						t10.id = num13;
						Teleport.M1894(t10);
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
				if (num129 == Char.M113().charID)
				{
					Char.M113().bag = bag;
				}
				else if (GameScr.M626(num129) != null)
				{
					GameScr.M626(num129).bag = bag;
				}
				break;
			}
			case -63:
			{
				Res.M1513("GET BAG");
				int iD = msg.M887().M1091();
				sbyte b47 = msg.M887().M1088();
				ClanImage t39 = new ClanImage();
				t39.ID = iD;
				if (b47 > 0)
				{
					t39.idImage = new short[b47];
					for (int num115 = 0; num115 < b47; num115++)
					{
						t39.idImage[num115] = msg.M887().M1092();
						Res.M1513("ID=  " + iD + " frame= " + t39.idImage[num115]);
					}
					ClanImage.idImages.M1078(iD + string.Empty, t39);
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
				ClanImage t41 = ClanImage.M288((sbyte)num121);
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
						SmallImage.vKeys.M1111(t41.idImage[num122] + string.Empty);
					}
				}
				break;
			}
			case -61:
			{
				int num83 = msg.M887().M1094();
				if (num83 != Char.M113().charID)
				{
					if (GameScr.M626(num83) != null)
					{
						GameScr.M626(num83).clanID = msg.M887().M1094();
						if (GameScr.M626(num83).clanID == -2)
						{
							GameScr.M626(num83).isCopy = true;
						}
					}
				}
				else if (Char.M113().clan != null)
				{
					Char.M113().clan.ID = msg.M887().M1094();
				}
				break;
			}
			case -60:
			{
				GameCanvas.M456("SA7666", 2);
				int num14 = msg.M887().M1094();
				int num15 = -1;
				if (num14 != Char.M113().charID)
				{
					Char t11 = GameScr.M626(num14);
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
					Res.M1513("player skill ID= " + num16);
					if ((TileMap.M1957(t11.cx, t11.cy) & 2) == 2)
					{
						t11.M172(GameScr.sks[num16], 0);
					}
					else
					{
						t11.M172(GameScr.sks[num16], 1);
					}
					sbyte b13 = msg.M887().M1088();
					Res.M1513("nAttack = " + b13);
					Char[] array2 = new Char[b13];
					for (num = 0; num < array2.Length; num++)
					{
						num15 = msg.M887().M1094();
						Char t12;
						if (num15 == Char.M113().charID)
						{
							t12 = Char.M113();
							if (!GameScr.isChangeZone && GameScr.isAutoPlay && GameScr.canAutoPlay)
							{
								Service.M1594().M1638(-1, -1);
								GameScr.isChangeZone = true;
							}
						}
						else
						{
							t12 = GameScr.M626(num15);
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
						t11.attChars = new Char[num];
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
					Res.M1513("isRead continue = " + b14);
					if (b14 != 1)
					{
						break;
					}
					sbyte b15 = msg.M887().M1088();
					Res.M1513("type skill = " + b15);
					if (num15 == Char.M113().charID)
					{
						bool flag2 = false;
						t = Char.M113();
						int damHP = msg.M889();
						Res.M1513("dame hit = " + damHP);
						t.isDie = msg.M887().M1097();
						if (t.isDie)
						{
							Char.isLockKey = true;
						}
						Res.M1513("isDie=" + t.isDie + "---------------------------------------");
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
						t = GameScr.M626(num15);
						if (t == null)
						{
							return;
						}
						bool flag3 = false;
						int damHP2 = msg.M889();
						Res.M1513("dame hit= " + damHP2);
						t.isDie = msg.M887().M1097();
						Res.M1513("isDie=" + t.isDie + "---------------------------------------");
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
				GameScr.M559().M669(msg.M887().M1094(), msg.M887().M1094(), msg.M887().M1100(), typePK);
				break;
			}
			case -57:
			{
				string strInvite = msg.M887().M1100();
				int clanID = msg.M887().M1094();
				int code = msg.M887().M1094();
				GameScr.M559().M568(strInvite, clanID, code);
				break;
			}
			case -53:
			{
				Res.M1513("MY CLAN INFO");
				InfoDlg.M753();
				bool flag8 = false;
				int num100 = msg.M887().M1094();
				Res.M1513("clanId= " + num100);
				if (num100 == -1)
				{
					flag8 = true;
					Char.M113().clan = null;
					ClanMessage.vMessage.M1120();
					if (GameCanvas.panel.member != null)
					{
						GameCanvas.panel.member.M1120();
					}
					if (GameCanvas.panel.myMember != null)
					{
						GameCanvas.panel.myMember.M1120();
					}
					if (GameCanvas.currentScreen == GameScr.M559())
					{
						GameCanvas.panel.M1314();
					}
					return;
				}
				GameCanvas.panel.tabIcon = null;
				if (Char.M113().clan == null)
				{
					Char.M113().clan = new Clan();
				}
				Char.M113().clan.ID = num100;
				Char.M113().clan.name = msg.M887().M1100();
				Char.M113().clan.slogan = msg.M887().M1100();
				Char.M113().clan.imgID = msg.M887().M1091();
				Char.M113().clan.powerPoint = msg.M887().M1100();
				Char.M113().clan.leaderName = msg.M887().M1100();
				Char.M113().clan.currMember = msg.M887().M1091();
				Char.M113().clan.maxMember = msg.M887().M1091();
				Char.M113().role = msg.M887().M1088();
				Char.M113().clan.clanPoint = msg.M887().M1094();
				Char.M113().clan.level = msg.M887().M1088();
				GameCanvas.panel.myMember = new MyVector();
				for (int num101 = 0; num101 < Char.M113().clan.currMember; num101++)
				{
					Member t36 = new Member();
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
					t36.joinTime = NinjaUtil.M1189(msg.M887().M1094());
					GameCanvas.panel.myMember.M1111(t36);
				}
				int num102 = msg.M887().M1091();
				for (int num103 = 0; num103 < num102; num103++)
				{
					M309(msg, -1);
				}
				if (GameCanvas.panel.isSearchClan || GameCanvas.panel.isViewMember || GameCanvas.panel.isMessage)
				{
					GameCanvas.panel.M1314();
				}
				if (flag8)
				{
					GameCanvas.panel.M1314();
				}
				break;
			}
			case -52:
			{
				sbyte b30 = msg.M887().M1088();
				if (b30 == 0)
				{
					Member t23 = new Member();
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
					t23.joinTime = NinjaUtil.M1189(msg.M887().M1094());
					Member o2 = t23;
					if (GameCanvas.panel.myMember == null)
					{
						GameCanvas.panel.myMember = new MyVector();
					}
					GameCanvas.panel.myMember.M1111(o2);
					GameCanvas.panel.M1313();
				}
				if (b30 == 1)
				{
					GameCanvas.panel.myMember.M1118(msg.M887().M1088());
					Panel panel = GameCanvas.panel;
					panel.currentListLength--;
					GameCanvas.panel.M1313();
				}
				if (b30 != 2)
				{
					break;
				}
				Member t24 = new Member();
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
				t24.joinTime = NinjaUtil.M1189(msg.M887().M1094());
				for (int num62 = 0; num62 < GameCanvas.panel.myMember.M1113(); num62++)
				{
					Member t25 = (Member)GameCanvas.panel.myMember.M1114(num62);
					if (t25.ID == t24.ID)
					{
						if (Char.M113().charID == t24.ID)
						{
							Char.M113().role = t24.role;
						}
						Member o3 = t24;
						GameCanvas.panel.myMember.M1119(t25);
						GameCanvas.panel.myMember.M1121(o3, num62);
						return;
					}
				}
				break;
			}
			case -51:
				InfoDlg.M753();
				M309(msg, 0);
				if (GameCanvas.panel.isMessage && GameCanvas.panel.type == 5)
				{
					GameCanvas.panel.M1313();
				}
				break;
			case -50:
			{
				InfoDlg.M753();
				GameCanvas.panel.member = new MyVector();
				sbyte b29 = msg.M887().M1088();
				for (int num61 = 0; num61 < b29; num61++)
				{
					Member t22 = new Member();
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
					t22.joinTime = NinjaUtil.M1189(msg.M887().M1094());
					GameCanvas.panel.member.M1111(t22);
				}
				GameCanvas.panel.isViewMember = true;
				GameCanvas.panel.isSearchClan = false;
				GameCanvas.panel.isMessage = false;
				GameCanvas.panel.currentListLength = GameCanvas.panel.member.M1113() + 2;
				GameCanvas.panel.M1313();
				break;
			}
			case -47:
			{
				InfoDlg.M753();
				sbyte b19 = msg.M887().M1088();
				Res.M1513("clan = " + b19);
				if (b19 == 0)
				{
					GameCanvas.panel.clanReport = mResources.cannot_find_clan;
					GameCanvas.panel.clans = null;
				}
				else
				{
					GameCanvas.panel.clans = new Clan[b19];
					Res.M1513("clan search lent= " + GameCanvas.panel.clans.Length);
					for (int num24 = 0; num24 < GameCanvas.panel.clans.Length; num24++)
					{
						GameCanvas.panel.clans[num24] = new Clan();
						GameCanvas.panel.clans[num24].ID = msg.M887().M1094();
						GameCanvas.panel.clans[num24].name = msg.M887().M1100();
						GameCanvas.panel.clans[num24].slogan = msg.M887().M1100();
						GameCanvas.panel.clans[num24].imgID = msg.M887().M1091();
						GameCanvas.panel.clans[num24].powerPoint = msg.M887().M1100();
						GameCanvas.panel.clans[num24].leaderName = msg.M887().M1100();
						GameCanvas.panel.clans[num24].currMember = msg.M887().M1091();
						GameCanvas.panel.clans[num24].maxMember = msg.M887().M1091();
						GameCanvas.panel.clans[num24].date = msg.M887().M1094();
					}
				}
				GameCanvas.panel.isSearchClan = true;
				GameCanvas.panel.isViewMember = false;
				GameCanvas.panel.isMessage = false;
				if (GameCanvas.panel.isSearchClan)
				{
					GameCanvas.panel.M1313();
				}
				break;
			}
			case -46:
			{
				InfoDlg.M753();
				sbyte b2 = msg.M887().M1088();
				if (b2 == 1 || b2 == 3)
				{
					GameCanvas.M488();
					ClanImage.vClanImage.M1120();
					int num2 = msg.M887().M1091();
					for (int i = 0; i < num2; i++)
					{
						ClanImage t5 = new ClanImage();
						t5.ID = msg.M887().M1091();
						t5.name = msg.M887().M1100();
						t5.xu = msg.M887().M1094();
						t5.luong = msg.M887().M1094();
						if (!ClanImage.M289(t5.ID))
						{
							ClanImage.M287(t5);
							continue;
						}
						ClanImage.M288((sbyte)t5.ID).name = t5.name;
						ClanImage.M288((sbyte)t5.ID).xu = t5.xu;
						ClanImage.M288((sbyte)t5.ID).luong = t5.luong;
					}
					if (Char.M113().clan != null)
					{
						GameCanvas.panel.M1408();
					}
				}
				if (b2 == 4)
				{
					Char.M113().clan.imgID = msg.M887().M1091();
					Char.M113().clan.slogan = msg.M887().M1100();
				}
				break;
			}
			case -45:
			{
				sbyte b4 = msg.M887().M1088();
				int num4 = msg.M887().M1094();
				short num5 = msg.M887().M1092();
				Res.M1513("skill type= " + b4 + "   player use= " + num4);
				if (b4 == 0)
				{
					Res.M1513("id use= " + num4);
					if (Char.M113().charID != num4)
					{
						t = GameScr.M626(num4);
						if ((TileMap.M1957(t.cx, t.cy) & 2) == 2)
						{
							t.M172(GameScr.sks[num5], 0);
						}
						else
						{
							t.M172(GameScr.sks[num5], 1);
							t.delayFall = 20;
						}
					}
					else
					{
						Char.M113().M131();
						Res.M1513("LOAD LAST SKILL");
					}
					sbyte b5 = msg.M887().M1088();
					Res.M1513("npc size= " + b5);
					for (int j = 0; j < b5; j++)
					{
						sbyte index = msg.M887().M1088();
						sbyte seconds = msg.M887().M1088();
						Res.M1513("index= " + index);
						if (num5 >= 42 && num5 <= 48)
						{
							((Mob)GameScr.vMob.M1114(index)).isFreez = true;
							((Mob)GameScr.vMob.M1114(index)).seconds = seconds;
							((Mob)GameScr.vMob.M1114(index)).last = (((Mob)GameScr.vMob.M1114(index)).cur = mSystem.M1054());
						}
					}
					sbyte b6 = msg.M887().M1088();
					for (int k = 0; k < b6; k++)
					{
						int num6 = msg.M887().M1094();
						sbyte b7 = msg.M887().M1088();
						Res.M1513("player ID= " + num6 + " my ID= " + Char.M113().charID);
						if (num5 < 42 || num5 > 48)
						{
							continue;
						}
						if (num6 == Char.M113().charID)
						{
							if (!Char.M113().isFlyAndCharge && !Char.M113().isStandAndCharge)
							{
								GameScr.M559().isFreez = true;
								Char.M113().isFreez = true;
								Char.M113().freezSeconds = b7;
								Char.M113().lastFreez = (Char.M113().currFreez = mSystem.M1054());
								Char.M113().isLockMove = true;
							}
						}
						else
						{
							t = GameScr.M626(num6);
							if (t != null && !t.isFlyAndCharge && !t.isStandAndCharge)
							{
								t.isFreez = true;
								t.seconds = b7;
								t.freezSeconds = b7;
								t.lastFreez = (GameScr.M626(num6).currFreez = mSystem.M1054());
							}
						}
					}
				}
				if (b4 == 1 && num4 != Char.M113().charID)
				{
					GameScr.M626(num4).isCharge = true;
				}
				if (b4 == 3)
				{
					if (num4 == Char.M113().charID)
					{
						Char.M113().isCharge = false;
						SoundMn.M1826().M1867();
						Char.M113().M131();
					}
					else
					{
						GameScr.M626(num4).isCharge = false;
					}
				}
				if (b4 == 4)
				{
					if (num4 == Char.M113().charID)
					{
						Char.M113().seconds = msg.M887().M1092() - 1000;
						Char.M113().last = mSystem.M1054();
						Res.M1513("second= " + Char.M113().seconds + " last= " + Char.M113().last);
					}
					else if (GameScr.M626(num4) != null)
					{
						switch (GameScr.M626(num4).cgender)
						{
						case 1:
							GameScr.M626(num4).M176(isGround: true);
							break;
						case 0:
							GameScr.M626(num4).M176(isGround: false);
							break;
						}
						GameScr.M626(num4).skillTemplateId = num5;
						GameScr.M626(num4).isUseSkillAfterCharge = true;
						GameScr.M626(num4).seconds = msg.M887().M1092();
						GameScr.M626(num4).last = mSystem.M1054();
					}
				}
				if (b4 == 5)
				{
					if (num4 == Char.M113().charID)
					{
						Char.M113().M175();
					}
					else if (GameScr.M626(num4) != null)
					{
						GameScr.M626(num4).M175();
					}
				}
				if (b4 == 6)
				{
					if (num4 == Char.M113().charID)
					{
						Char.M113().M177(GameScr.sks[num5], 0);
					}
					else if (GameScr.M626(num4) != null)
					{
						GameScr.M626(num4).M177(GameScr.sks[num5], 0);
						SoundMn.M1826().M1835();
					}
				}
				if (b4 == 7)
				{
					if (num4 == Char.M113().charID)
					{
						Char.M113().seconds = msg.M887().M1092();
						Res.M1513("second = " + Char.M113().seconds);
						Char.M113().last = mSystem.M1054();
					}
					else if (GameScr.M626(num4) != null)
					{
						GameScr.M626(num4).M176(isGround: true);
						GameScr.M626(num4).seconds = msg.M887().M1092();
						GameScr.M626(num4).last = mSystem.M1054();
						SoundMn.M1826().M1835();
					}
				}
				if (b4 == 8 && num4 != Char.M113().charID && GameScr.M626(num4) != null)
				{
					GameScr.M626(num4).M177(GameScr.sks[num5], 0);
				}
				break;
			}
			case -44:
			{
				bool flag7 = false;
				if (GameCanvas.w > 2 * Panel.WIDTH_PANEL)
				{
					flag7 = true;
				}
				sbyte b40 = msg.M887().M1088();
				int num85 = msg.M887().M1091();
				Char.M113().arrItemShop = new Item[num85][];
				GameCanvas.panel.shopTabName = new string[num85 + ((!flag7) ? 1 : 0)][];
				for (int num86 = 0; num86 < GameCanvas.panel.shopTabName.Length; num86++)
				{
					GameCanvas.panel.shopTabName[num86] = new string[2];
				}
				if (b40 == 2)
				{
					GameCanvas.panel.maxPageShop = new int[num85];
					GameCanvas.panel.currPageShop = new int[num85];
				}
				if (!flag7)
				{
					GameCanvas.panel.shopTabName[num85] = mResources.inventory;
				}
				for (int num87 = 0; num87 < num85; num87++)
				{
					string[] array7 = Res.M1531(msg.M887().M1100(), "\n", 0);
					if (b40 == 2)
					{
						GameCanvas.panel.maxPageShop[num87] = msg.M887().M1091();
					}
					if (array7.Length == 2)
					{
						GameCanvas.panel.shopTabName[num87] = array7;
					}
					if (array7.Length == 1)
					{
						GameCanvas.panel.shopTabName[num87][0] = array7[0];
						GameCanvas.panel.shopTabName[num87][1] = string.Empty;
					}
					int num88 = msg.M887().M1091();
					Char.M113().arrItemShop[num87] = new Item[num88];
					Panel.strWantToBuy = mResources.say_wat_do_u_want_to_buy;
					if (b40 == 1)
					{
						Panel.strWantToBuy = mResources.say_wat_do_u_want_to_buy2;
					}
					for (int num89 = 0; num89 < num88; num89++)
					{
						short num90 = msg.M887().M1092();
						if (num90 == -1)
						{
							continue;
						}
						Char.M113().arrItemShop[num87][num89] = new Item();
						Char.M113().arrItemShop[num87][num89].template = ItemTemplates.M834(num90);
						Res.M1513("name " + num87 + " = " + Char.M113().arrItemShop[num87][num89].template.name + " id templat= " + Char.M113().arrItemShop[num87][num89].template.id);
						switch (b40)
						{
						case 0:
							Char.M113().arrItemShop[num87][num89].buyCoin = msg.M887().M1094();
							Char.M113().arrItemShop[num87][num89].buyGold = msg.M887().M1094();
							break;
						case 1:
							Char.M113().arrItemShop[num87][num89].powerRequire = msg.M887().M1095();
							break;
						case 2:
							Char.M113().arrItemShop[num87][num89].itemId = msg.M887().M1092();
							Char.M113().arrItemShop[num87][num89].buyCoin = msg.M887().M1094();
							Char.M113().arrItemShop[num87][num89].buyGold = msg.M887().M1094();
							Char.M113().arrItemShop[num87][num89].buyType = msg.M887().M1088();
							Char.M113().arrItemShop[num87][num89].quantity = msg.M887().M1094();
							Char.M113().arrItemShop[num87][num89].isMe = msg.M887().M1088();
							break;
						case 3:
							Char.M113().arrItemShop[num87][num89].isBuySpec = true;
							Char.M113().arrItemShop[num87][num89].iconSpec = msg.M887().M1092();
							Char.M113().arrItemShop[num87][num89].buySpec = msg.M887().M1094();
							break;
						case 4:
							Char.M113().arrItemShop[num87][num89].reason = msg.M887().M1100();
							break;
						case 8:
							Char.M113().arrItemShop[num87][num89].buyCoin = msg.M887().M1094();
							Char.M113().arrItemShop[num87][num89].buyGold = msg.M887().M1094();
							Char.M113().arrItemShop[num87][num89].quantity = msg.M887().M1094();
							break;
						}
						int num91 = msg.M887().M1091();
						if (num91 != 0)
						{
							Char.M113().arrItemShop[num87][num89].itemOption = new ItemOption[num91];
							for (int num92 = 0; num92 < Char.M113().arrItemShop[num87][num89].itemOption.Length; num92++)
							{
								int optionTemplateId6 = msg.M887().M1091();
								ushort param6 = msg.M887().M1093();
								Char.M113().arrItemShop[num87][num89].itemOption[num92] = new ItemOption(optionTemplateId6, param6);
								Char.M113().arrItemShop[num87][num89].compare = GameCanvas.panel.M1365(Char.M113().arrItemShop[num87][num89]);
							}
						}
						sbyte b41 = msg.M887().M1088();
						Char.M113().arrItemShop[num87][num89].newItem = ((b41 != 0) ? true : false);
						if (msg.M887().M1088() == 1)
						{
							int headTemp = msg.M887().M1092();
							int bodyTemp = msg.M887().M1092();
							int legTemp = msg.M887().M1092();
							short bagTemp = msg.M887().M1092();
							Char.M113().arrItemShop[num87][num89].M817(headTemp, bodyTemp, legTemp, bagTemp);
						}
					}
				}
				if (flag7)
				{
					if (b40 != 2)
					{
						GameCanvas.panel2 = new Panel();
						GameCanvas.panel2.tabName[7] = new string[1][] { new string[1] { string.Empty } };
						GameCanvas.panel2.M1253();
						GameCanvas.panel2.M1285();
					}
					else
					{
						GameCanvas.panel2 = new Panel();
						GameCanvas.panel2.M1251();
						GameCanvas.panel2.M1285();
					}
				}
				GameCanvas.panel.tabName[1] = GameCanvas.panel.shopTabName;
				if (b40 == 2)
				{
					string[][] array8 = GameCanvas.panel.tabName[1];
					if (flag7)
					{
						GameCanvas.panel.tabName[1] = new string[4][]
						{
							array8[0],
							array8[1],
							array8[2],
							array8[3]
						};
					}
					else
					{
						GameCanvas.panel.tabName[1] = new string[5][]
						{
							array8[0],
							array8[1],
							array8[2],
							array8[3],
							array8[4]
						};
					}
				}
				GameCanvas.panel.M1268(b40);
				GameCanvas.panel.M1285();
				break;
			}
			case -43:
			{
				sbyte itemAction = msg.M887().M1088();
				sbyte where = msg.M887().M1088();
				sbyte index3 = msg.M887().M1088();
				string info3 = msg.M887().M1100();
				GameCanvas.panel.M1424(itemAction, info3, where, index3);
				break;
			}
			case -42:
				Char.M113().cHPGoc = msg.M889();
				Char.M113().cMPGoc = msg.M889();
				Char.M113().cDamGoc = msg.M887().M1094();
				Char.M113().cHPFull = msg.M889();
				Char.M113().cMPFull = msg.M889();
				Char.M113().cHP = msg.M889();
				Char.M113().cMP = msg.M889();
				Char.M113().cspeed = msg.M887().M1088();
				Char.M113().hpFrom1000TiemNang = msg.M887().M1088();
				Char.M113().mpFrom1000TiemNang = msg.M887().M1088();
				Char.M113().damFrom1000TiemNang = msg.M887().M1088();
				Char.M113().cDamFull = msg.M887().M1094();
				Char.M113().cDefull = msg.M887().M1094();
				Char.M113().cCriticalFull = msg.M887().M1088();
				Char.M113().cTiemNang = msg.M887().M1095();
				Char.M113().expForOneAdd = msg.M887().M1092();
				Char.M113().cDefGoc = msg.M887().M1092();
				Char.M113().cCriticalGoc = msg.M887().M1088();
				InfoDlg.M753();
				break;
			case -41:
			{
				sbyte b38 = msg.M887().M1088();
				Char.M113().strLevel = new string[b38];
				for (int num84 = 0; num84 < b38; num84++)
				{
					string text5 = msg.M887().M1100();
					Char.M113().strLevel[num84] = text5;
				}
				Res.M1513("---   xong  level caption cmd : " + msg.command);
				break;
			}
			case -37:
			{
				sbyte b34 = msg.M887().M1088();
				Res.M1513("cAction= " + b34);
				if (b34 != 0)
				{
					break;
				}
				Char.M113().head = msg.M887().M1092();
				Char.M113().M165();
				int num74 = msg.M887().M1091();
				Res.M1513("num body = " + num74);
				Char.M113().arrItemBody = new Item[num74];
				for (int num75 = 0; num75 < num74; num75++)
				{
					short num76 = msg.M887().M1092();
					if (num76 == -1)
					{
						continue;
					}
					Char.M113().arrItemBody[num75] = new Item();
					Char.M113().arrItemBody[num75].template = ItemTemplates.M834(num76);
					int type3 = Char.M113().arrItemBody[num75].template.type;
					Char.M113().arrItemBody[num75].quantity = msg.M887().M1094();
					Char.M113().arrItemBody[num75].info = msg.M887().M1100();
					Char.M113().arrItemBody[num75].content = msg.M887().M1100();
					int num77 = msg.M887().M1091();
					if (num77 != 0)
					{
						Char.M113().arrItemBody[num75].itemOption = new ItemOption[num77];
						for (int num78 = 0; num78 < Char.M113().arrItemBody[num75].itemOption.Length; num78++)
						{
							int optionTemplateId5 = msg.M887().M1091();
							ushort param5 = msg.M887().M1093();
							Char.M113().arrItemBody[num75].itemOption[num78] = new ItemOption(optionTemplateId5, param5);
						}
					}
					switch (type3)
					{
					case 1:
						Char.M113().leg = Char.M113().arrItemBody[num75].template.part;
						break;
					case 0:
						Char.M113().body = Char.M113().arrItemBody[num75].template.part;
						break;
					}
				}
				break;
			}
			case -36:
			{
				sbyte b24 = msg.M887().M1088();
				Res.M1513("cAction= " + b24);
				if (b24 == 0)
				{
					int num50 = msg.M887().M1091();
					Char.M113().arrItemBag = new Item[num50];
					GameScr.hpPotion = 0;
					Res.M1513("numC=" + num50);
					for (int num51 = 0; num51 < num50; num51++)
					{
						short num52 = msg.M887().M1092();
						if (num52 == -1)
						{
							continue;
						}
						Char.M113().arrItemBag[num51] = new Item();
						Char.M113().arrItemBag[num51].template = ItemTemplates.M834(num52);
						Char.M113().arrItemBag[num51].quantity = msg.M887().M1094();
						Char.M113().arrItemBag[num51].info = msg.M887().M1100();
						Char.M113().arrItemBag[num51].content = msg.M887().M1100();
						Char.M113().arrItemBag[num51].indexUI = num51;
						int num53 = msg.M887().M1091();
						if (num53 != 0)
						{
							Char.M113().arrItemBag[num51].itemOption = new ItemOption[num53];
							for (int num54 = 0; num54 < Char.M113().arrItemBag[num51].itemOption.Length; num54++)
							{
								int optionTemplateId4 = msg.M887().M1091();
								ushort param4 = msg.M887().M1093();
								Char.M113().arrItemBag[num51].itemOption[num54] = new ItemOption(optionTemplateId4, param4);
							}
							Char.M113().arrItemBag[num51].compare = GameCanvas.panel.M1365(Char.M113().arrItemBag[num51]);
						}
						_ = Char.M113().arrItemBag[num51].template.type;
						if (Char.M113().arrItemBag[num51].template.type == 6)
						{
							GameScr.hpPotion += Char.M113().arrItemBag[num51].quantity;
						}
					}
				}
				if (b24 == 2)
				{
					sbyte b25 = msg.M887().M1088();
					int quantity2 = msg.M887().M1094();
					int quantity3 = Char.M113().arrItemBag[b25].quantity;
					Char.M113().arrItemBag[b25].quantity = quantity2;
					if (Char.M113().arrItemBag[b25].quantity < quantity3 && Char.M113().arrItemBag[b25].template.type == 6)
					{
						GameScr.hpPotion -= quantity3 - Char.M113().arrItemBag[b25].quantity;
					}
					if (Char.M113().arrItemBag[b25].quantity == 0)
					{
						Char.M113().arrItemBag[b25] = null;
					}
				}
				break;
			}
			case -35:
			{
				sbyte b17 = msg.M887().M1088();
				Res.M1513("cAction= " + b17);
				if (b17 == 0)
				{
					int num17 = msg.M887().M1091();
					Char.M113().arrItemBox = new Item[num17];
					GameCanvas.panel.hasUse = 0;
					for (int num18 = 0; num18 < num17; num18++)
					{
						short num19 = msg.M887().M1092();
						if (num19 == -1)
						{
							continue;
						}
						Char.M113().arrItemBox[num18] = new Item();
						Char.M113().arrItemBox[num18].template = ItemTemplates.M834(num19);
						Char.M113().arrItemBox[num18].quantity = msg.M887().M1094();
						Char.M113().arrItemBox[num18].info = msg.M887().M1100();
						Char.M113().arrItemBox[num18].content = msg.M887().M1100();
						int num20 = msg.M887().M1091();
						if (num20 != 0)
						{
							Char.M113().arrItemBox[num18].itemOption = new ItemOption[num20];
							for (int num21 = 0; num21 < Char.M113().arrItemBox[num18].itemOption.Length; num21++)
							{
								int optionTemplateId2 = msg.M887().M1091();
								ushort param2 = msg.M887().M1093();
								Char.M113().arrItemBox[num18].itemOption[num21] = new ItemOption(optionTemplateId2, param2);
							}
						}
						Panel panel = GameCanvas.panel;
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
					GameCanvas.panel.M1269();
					GameCanvas.panel.isBoxClan = isBoxClan;
					GameCanvas.panel.M1285();
				}
				if (b17 == 2)
				{
					sbyte b18 = msg.M887().M1088();
					int quantity = msg.M887().M1094();
					Char.M113().arrItemBox[b18].quantity = quantity;
					if (Char.M113().arrItemBox[b18].quantity == 0)
					{
						Char.M113().arrItemBox[b18] = null;
					}
				}
				break;
			}
			case -34:
			{
				sbyte b54 = msg.M887().M1088();
				Res.M1513("act= " + b54);
				if (b54 == 0 && GameScr.M559().magicTree != null)
				{
					Res.M1513("toi duoc day");
					MagicTree magicTree = GameScr.M559().magicTree;
					magicTree.id = msg.M887().M1092();
					magicTree.name = msg.M887().M1100();
					magicTree.name = Res.M1518(magicTree.name);
					magicTree.x = msg.M887().M1092();
					magicTree.y = msg.M887().M1092();
					magicTree.level = msg.M887().M1088();
					magicTree.currPeas = msg.M887().M1092();
					magicTree.maxPeas = msg.M887().M1092();
					Res.M1513("curr Peas= " + magicTree.currPeas);
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
					magicTree.last = (magicTree.cur = mSystem.M1054());
					GameScr.M559().magicTree.isUpdateTree = true;
				}
				if (b54 == 1)
				{
					t3 = new MyVector();
					try
					{
						while (msg.M887().M1104() > 0)
						{
							t3.M1111(new Command(msg.M887().M1100(), GameCanvas.instance, 888392, null));
						}
					}
					catch (Exception ex20)
					{
						Cout.M326("Loi MAGIC_TREE " + ex20.ToString());
					}
					GameCanvas.menu.M877(t3, 3);
				}
				if (b54 == 2)
				{
					GameScr.M559().magicTree.remainPeas = msg.M887().M1092();
					GameScr.M559().magicTree.seconds = msg.M887().M1094();
					GameScr.M559().magicTree.last = (GameScr.M559().magicTree.cur = mSystem.M1054());
					GameScr.M559().magicTree.isUpdateTree = true;
					GameScr.M559().magicTree.isPeasEffect = true;
				}
				break;
			}
			case -32:
			{
				if (GameCanvas.lowGraphic && TileMap.mapID != 51 && TileMap.mapID != 103)
				{
					return;
				}
				short id4 = msg.M887().M1092();
				int num125 = msg.M887().M1094();
				sbyte[] array14 = null;
				Image t44 = null;
				try
				{
					array14 = new sbyte[num125];
					for (int num126 = 0; num126 < num125; num126++)
					{
						array14[num126] = msg.M887().M1088();
					}
					t44 = Image.M708(array14, 0, num125);
					BgItem.imgNew.M1078(id4 + string.Empty, t44);
				}
				catch (Exception)
				{
					array14 = null;
					BgItem.imgNew.M1078(id4 + string.Empty, Image.M711(new int[1], 1, 1, bl: true));
				}
				if (array14 != null)
				{
					if (mGraphics.zoomLevel > 1)
					{
						Rms.M1534(mGraphics.zoomLevel + "bgItem" + id4, array14);
					}
					BgItemMn.M74(id4, t44);
				}
				break;
			}
			case -31:
			{
				if (GameCanvas.lowGraphic && TileMap.mapID != 51)
				{
					return;
				}
				TileMap.vItemBg.M1120();
				short num118 = msg.M887().M1092();
				Cout.M329("nItem= " + num118);
				for (int num119 = 0; num119 < num118; num119++)
				{
					BgItem t40 = new BgItem();
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
					TileMap.vItemBg.M1111(t40);
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
				ServerListScreen.testConnect = 2;
				GameCanvas.M456("SA2", 2);
				GameCanvas.M489(msg.M887().M1100());
				InfoDlg.M753();
				LoginScr.isContinueToLogin = false;
				Char.isLoadingMap = false;
				if (GameCanvas.currentScreen == GameCanvas.loginScr)
				{
					GameCanvas.serverScreen.switchToMe();
				}
				break;
			case -25:
				GameCanvas.M456("SA3", 2);
				GameScr.info1.M762(msg.M887().M1100(), 0);
				break;
			case -24:
				Char.isLoadingMap = true;
				Cout.M326("GET MAP INFO");
				GameScr.M559().magicTree = null;
				GameCanvas.isLoading = true;
				GameCanvas.M456("SA75", 2);
				GameScr.M538();
				GameCanvas.M488();
				TileMap.vGo.M1120();
				PopUp.vPopups.M1120();
				mSystem.M1062();
				TileMap.mapID = msg.M887().M1091();
				TileMap.planetID = msg.M887().M1088();
				TileMap.tileID = msg.M887().M1088();
				TileMap.bgID = msg.M887().M1088();
				Cout.M326("load planet from server: " + TileMap.planetID + "bgType= " + TileMap.bgType + ".............................");
				TileMap.typeMap = msg.M887().M1088();
				TileMap.mapName = msg.M887().M1100();
				TileMap.zoneID = msg.M887().M1088();
				GameCanvas.M456("SA75x1", 2);
				try
				{
					TileMap.M1954(TileMap.mapID);
				}
				catch (Exception)
				{
					Service.M1594().M1688(TileMap.mapID);
					messWait = msg;
					return;
				}
				M311(msg);
				try
				{
					TileMap.isMapDouble = ((msg.M887().M1088() != 0) ? true : false);
				}
				catch (Exception)
				{
				}
				GameScr.cmx = GameScr.cmtoX;
				GameScr.cmy = GameScr.cmtoY;
				break;
			case -22:
				GameCanvas.M456("SA65", 2);
				Char.isLockKey = true;
				Char.ischangingMap = true;
				GameScr.M559().timeStartMap = 0;
				GameScr.M559().timeLengthMap = 0;
				Char.M113().mobFocus = null;
				Char.M113().npcFocus = null;
				Char.M113().charFocus = null;
				Char.M113().itemFocus = null;
				Char.M113().focus.M1120();
				Char.M113().testCharId = -9999;
				Char.M113().killCharId = -9999;
				GameCanvas.M467();
				GameScr.M559().M574();
				GameScr.M559().center = null;
				break;
			case -21:
			{
				GameCanvas.M456("SA60", 2);
				short num105 = msg.M887().M1092();
				for (int num106 = 0; num106 < GameScr.vItemMap.M1113(); num106++)
				{
					if (((ItemMap)GameScr.vItemMap.M1114(num106)).itemMapID == num105)
					{
						GameScr.vItemMap.M1118(num106);
						break;
					}
				}
				break;
			}
			case -20:
			{
				GameCanvas.M456("SA61", 2);
				Char.M113().itemFocus = null;
				short num98 = msg.M887().M1092();
				for (int num99 = 0; num99 < GameScr.vItemMap.M1113(); num99++)
				{
					ItemMap t34 = (ItemMap)GameScr.vItemMap.M1114(num99);
					if (t34.itemMapID != num98)
					{
						continue;
					}
					t34.M822(Char.M113().cx, Char.M113().cy - 10);
					string text6 = msg.M887().M1100();
					num = 0;
					try
					{
						num = msg.M887().M1092();
						if (t34.template.type == 9)
						{
							num = msg.M887().M1092();
							Char t35 = Char.M113();
							t35.xu += num;
							Char.M113().xuStr = mSystem.M1042(Char.M113().xu);
						}
						else if (t34.template.type == 10)
						{
							num = msg.M887().M1092();
							Char t35 = Char.M113();
							t35.luong += num;
							Char.M113().luongStr = mSystem.M1042(Char.M113().luong);
						}
						else if (t34.template.type == 34)
						{
							num = msg.M887().M1092();
							Char t35 = Char.M113();
							t35.luongKhoa += num;
							Char.M113().luongKhoaStr = mSystem.M1042(Char.M113().luongKhoa);
						}
					}
					catch (Exception)
					{
					}
					if (text6.Equals(string.Empty))
					{
						if (t34.template.type == 9)
						{
							GameScr.M643(((num >= 0) ? "+" : string.Empty) + num, Char.M113().cx, Char.M113().cy - Char.M113().ch, 0, -2, mFont.YELLOW);
							SoundMn.M1826().M1836();
						}
						else if (t34.template.type == 10)
						{
							GameScr.M643(((num >= 0) ? "+" : string.Empty) + num, Char.M113().cx, Char.M113().cy - Char.M113().ch, 0, -2, mFont.GREEN);
							SoundMn.M1826().M1836();
						}
						else if (t34.template.type == 34)
						{
							GameScr.M643(((num >= 0) ? "+" : string.Empty) + num, Char.M113().cx, Char.M113().cy - Char.M113().ch, 0, -2, mFont.RED);
							SoundMn.M1826().M1836();
						}
						else
						{
							GameScr.info1.M762(mResources.you_receive + " " + ((num <= 0) ? string.Empty : (num + " ")) + t34.template.name, 0);
							SoundMn.M1826().M1836();
						}
						if (num > 0 && Char.M113().petFollow != null && Char.M113().petFollow.smallID == 4683)
						{
							ServerEffect.M1571(55, Char.M113().petFollow.cmx, Char.M113().petFollow.cmy, 1);
							ServerEffect.M1571(55, Char.M113().cx, Char.M113().cy, 1);
						}
					}
					else if (text6.Length == 1)
					{
						Cout.M330("strInf.Length =1:  " + text6);
					}
					else
					{
						GameScr.info1.M762(text6, 0);
					}
					break;
				}
				break;
			}
			case -19:
			{
				GameCanvas.M456("SA62", 2);
				short num96 = msg.M887().M1092();
				t = GameScr.M626(msg.M887().M1094());
				for (int num97 = 0; num97 < GameScr.vItemMap.M1113(); num97++)
				{
					ItemMap t33 = (ItemMap)GameScr.vItemMap.M1114(num97);
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
				GameCanvas.M456("SA63", 2);
				int num95 = msg.M887().M1088();
				GameScr.vItemMap.M1111(new ItemMap(msg.M887().M1092(), Char.M113().arrItemBag[num95].template.id, Char.M113().cx, Char.M113().cy, msg.M887().M1092(), msg.M887().M1092()));
				Char.M113().arrItemBag[num95] = null;
				break;
			}
			case -14:
				GameCanvas.M456("SA64", 2);
				t = GameScr.M626(msg.M887().M1094());
				if (t == null)
				{
					return;
				}
				GameScr.vItemMap.M1111(new ItemMap(msg.M887().M1092(), msg.M887().M1092(), t.cx, t.cy, msg.M887().M1092(), msg.M887().M1092()));
				break;
			case -4:
			{
				GameCanvas.M456("SA76", 2);
				t = GameScr.M626(msg.M887().M1094());
				if (t == null)
				{
					return;
				}
				GameCanvas.M456("SA76v1", 2);
				if ((TileMap.M1957(t.cx, t.cy) & 2) == 2)
				{
					t.M172(GameScr.sks[msg.M887().M1091()], 0);
				}
				else
				{
					t.M172(GameScr.sks[msg.M887().M1091()], 1);
				}
				GameCanvas.M456("SA76v2", 2);
				t.attMobs = new Mob[msg.M887().M1088()];
				for (int num72 = 0; num72 < t.attMobs.Length; num72++)
				{
					Mob t27 = (Mob)GameScr.vMob.M1114(msg.M887().M1088());
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
				GameCanvas.M456("SA76v3", 2);
				t.charFocus = null;
				t.mobFocus = t.attMobs[0];
				Char[] array5 = new Char[10];
				num = 0;
				try
				{
					for (num = 0; num < array5.Length; num++)
					{
						int num73 = msg.M887().M1094();
						Char t28 = (array5[num] = ((num73 != Char.M113().charID) ? GameScr.M626(num73) : Char.M113()));
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
					Cout.M326("Loi PLAYER_ATTACK_N_P " + ex8.ToString());
				}
				GameCanvas.M456("SA76v4", 2);
				if (num > 0)
				{
					t.attChars = new Char[num];
					for (num = 0; num < t.attChars.Length; num++)
					{
						t.attChars[num] = array5[num];
					}
					t.charFocus = t.attChars[0];
					t.mobFocus = null;
				}
				GameCanvas.M456("SA76v5", 2);
				break;
			}
			case 1:
			{
				bool flag4 = msg.M887().M1096();
				Res.M1513("isRes= " + flag4);
				if (!flag4)
				{
					GameCanvas.M489(msg.M887().M1100());
					break;
				}
				GameCanvas.loginScr.isLogin2 = false;
				Rms.M1538("userAo" + ServerListScreen.ipSelect, string.Empty);
				GameCanvas.M488();
				GameCanvas.loginScr.M861();
				break;
			}
			case 2:
				Char.isLoadingMap = true;
				LoginScr.isLoggingIn = false;
				if (!GameScr.isLoadAllData)
				{
					GameScr.M559().M532();
				}
				BgItem.M65();
				GameCanvas.M488();
				CreateCharScr.isCreateChar = true;
				CreateCharScr.M344().switchToMe();
				break;
			case 6:
				GameCanvas.M456("SA70", 2);
				Char.M113().xu = msg.M887().M1095();
				Char.M113().luong = msg.M887().M1094();
				Char.M113().luongKhoa = msg.M887().M1094();
				Char.M113().xuStr = mSystem.M1042(Char.M113().xu);
				Char.M113().luongStr = mSystem.M1042(Char.M113().luong);
				Char.M113().luongKhoaStr = mSystem.M1042(Char.M113().luongKhoa);
				GameCanvas.M488();
				break;
			case 7:
			{
				sbyte type2 = msg.M887().M1088();
				short id2 = msg.M887().M1092();
				string info2 = msg.M887().M1100();
				GameCanvas.panel.M1425(type2, info2, id2);
				break;
			}
			case 11:
			{
				GameCanvas.M456("SA9", 2);
				int num35 = msg.M887().M1088();
				sbyte b21 = msg.M887().M1088();
				if (b21 != 0)
				{
					Mob.arrMobTemplate[num35].data.M400(NinjaUtil.M1185(msg), b21);
				}
				else
				{
					Mob.arrMobTemplate[num35].data.M399(NinjaUtil.M1185(msg));
				}
				for (int num36 = 0; num36 < GameScr.vMob.M1113(); num36++)
				{
					t2 = (Mob)GameScr.vMob.M1114(num36);
					if (t2.templateId == num35)
					{
						t2.w = Mob.arrMobTemplate[num35].data.width;
						t2.h = Mob.arrMobTemplate[num35].data.height;
					}
				}
				sbyte[] array3 = NinjaUtil.M1185(msg);
				Image img = Image.M708(array3, 0, array3.Length);
				Mob.arrMobTemplate[num35].data.img = img;
				int num37 = msg.M887().M1088();
				Mob.arrMobTemplate[num35].data.typeData = num37;
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
				t3 = new MyVector();
				msg.M887().M1100();
				int num32 = msg.M887().M1088();
				for (int num33 = 0; num33 < num32; num33++)
				{
					t3.M1111(new Command(msg.M887().M1100(), p: msg.M887().M1092(), actionListener: GameCanvas.instance, action: 88819));
				}
				GameCanvas.menu.M875(t3, 3);
				break;
			}
			case 29:
				GameCanvas.M456("SA58", 2);
				GameScr.M559().M665(msg);
				break;
			case 32:
			{
				GameCanvas.M456("SA68", 2);
				int num151 = msg.M887().M1092();
				for (int num152 = 0; num152 < GameScr.vNpc.M1113(); num152++)
				{
					Npc t52 = (Npc)GameScr.vNpc.M1114(num152);
					if (t52.template.npcTemplateId == num151 && t52.Equals(Char.M113().npcFocus))
					{
						string chat2 = msg.M887().M1100();
						string[] array16 = new string[msg.M887().M1088()];
						for (int num153 = 0; num153 < array16.Length; num153++)
						{
							array16[num153] = msg.M887().M1100();
						}
						GameScr.M559().M553(array16, t52);
						ChatPopup.M271(chat2, 100000, t52);
						return;
					}
				}
				Npc t53 = new Npc(num151, 0, -100, 100, num151, GameScr.info1.charId[Char.M113().cgender][2]);
				Res.M1513((Char.M113().npcFocus == null) ? "null" : "!null");
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
				Res.M1513((Char.M113().npcFocus == null) ? "null" : "!null");
				GameScr.M559().M553(array17, t53);
				ChatPopup.M271(chat3, 100000, t53);
				break;
			}
			case 33:
			{
				GameCanvas.M456("SA51", 2);
				InfoDlg.M753();
				GameCanvas.M484();
				GameCanvas.M483();
				t3 = new MyVector();
				try
				{
					while (true)
					{
						t3.M1111(new Command(msg.M887().M1100(), GameCanvas.instance, 88822, null));
					}
				}
				catch (Exception ex19)
				{
					Cout.M326("Loi OPEN_UI_MENU " + ex19.ToString());
				}
				if (Char.M113().npcFocus == null)
				{
					return;
				}
				for (int num133 = 0; num133 < Char.M113().npcFocus.template.menu.Length; num133++)
				{
					string[] array15 = Char.M113().npcFocus.template.menu[num133];
					t3.M1111(new Command(array15[0], GameCanvas.instance, 88820, array15));
				}
				GameCanvas.menu.M877(t3, 3);
				break;
			}
			case 38:
			{
				GameCanvas.M456("SA67", 2);
				InfoDlg.M753();
				int num127 = msg.M887().M1092();
				Res.M1513("OPEN_UI_SAY ID= " + num127);
				string chat = Res.M1518(msg.M887().M1100());
				for (int num128 = 0; num128 < GameScr.vNpc.M1113(); num128++)
				{
					Npc t45 = (Npc)GameScr.vNpc.M1114(num128);
					Res.M1513("npc id= " + t45.template.npcTemplateId);
					if (t45.template.npcTemplateId == num127)
					{
						ChatPopup.M269(chat, 100000, t45);
						GameCanvas.panel.M1381();
						return;
					}
				}
				Npc t46 = new Npc(num127, 0, 0, 0, num127, GameScr.info1.charId[Char.M113().cgender][2]);
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
				ChatPopup.M269(chat, 100000, t46);
				GameCanvas.panel.M1381();
				break;
			}
			case 39:
				GameCanvas.M456("SA49", 2);
				GameScr.M559().typeTradeOrder = 2;
				if (GameScr.M559().typeTrade >= 2 && GameScr.M559().typeTradeOrder >= 2)
				{
					InfoDlg.M749();
				}
				break;
			case 40:
			{
				GameCanvas.M456("SA52", 2);
				GameCanvas.taskTick = 150;
				short taskId = msg.M887().M1092();
				sbyte index4 = msg.M887().M1088();
				string name = Res.M1518(msg.M887().M1100());
				string detail = Res.M1518(msg.M887().M1100());
				string[] array11 = new string[msg.M887().M1088()];
				string[] array12 = new string[array11.Length];
				GameScr.tasks = new int[array11.Length];
				GameScr.mapTasks = new int[array11.Length];
				short[] array13 = new short[array11.Length];
				short count = -1;
				for (int num116 = 0; num116 < array11.Length; num116++)
				{
					string text7 = Res.M1518(msg.M887().M1100());
					GameScr.tasks[num116] = msg.M887().M1088();
					GameScr.mapTasks[num116] = msg.M887().M1092();
					string text8 = Res.M1518(msg.M887().M1100());
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
					Cout.M326("Loi TASK_GET " + ex16.ToString());
				}
				Char.M113().taskMaint = new Task(taskId, index4, name, detail, array11, array13, count, array12);
				if (Char.M113().npcFocus != null)
				{
					Npc.M1196();
				}
				Char.M106(isNextStep: false);
				break;
			}
			case 41:
			{
				GameCanvas.M456("SA53", 2);
				GameCanvas.taskTick = 100;
				Res.M1513("TASK NEXT");
				Task taskMaint = Char.M113().taskMaint;
				taskMaint.index++;
				Char.M113().taskMaint.count = 0;
				Npc.M1196();
				Char.M106(isNextStep: true);
				break;
			}
			case 43:
				GameCanvas.taskTick = 50;
				GameCanvas.M456("SA55", 2);
				Char.M113().taskMaint.count = msg.M887().M1092();
				if (Char.M113().npcFocus != null)
				{
					Npc.M1196();
				}
				break;
			case 46:
				GameCanvas.M456("SA5", 2);
				Cout.M331("Controler RESET_POINT  " + Char.ischangingMap);
				Char.isLockKey = false;
				Char.M113().M132(msg.M887().M1092(), msg.M887().M1092());
				break;
			case 47:
				GameCanvas.M456("SA4", 2);
				GameScr.M559().M574();
				break;
			case 50:
			{
				sbyte b46 = msg.M887().M1088();
				Panel.vGameInfo.M1120();
				for (int num114 = 0; num114 < b46; num114++)
				{
					GameInfo t38 = new GameInfo();
					t38.id = msg.M887().M1092();
					t38.main = msg.M887().M1100();
					t38.content = msg.M887().M1100();
					Panel.vGameInfo.M1111(t38);
					t38.hasRead = Rms.M1542(t38.id + string.Empty) != -1;
				}
				break;
			}
			case 54:
			{
				t = GameScr.M626(msg.M887().M1094());
				if (t == null)
				{
					return;
				}
				int num104 = msg.M887().M1091();
				if ((TileMap.M1957(t.cx, t.cy) & 2) == 2)
				{
					t.M172(GameScr.sks[num104], 0);
				}
				else
				{
					t.M172(GameScr.sks[num104], 1);
				}
				GameCanvas.M456("SA769991v2", 2);
				Mob[] array9 = new Mob[10];
				num = 0;
				try
				{
					GameCanvas.M456("SA769991v3", 2);
					for (num = 0; num < array9.Length; num++)
					{
						GameCanvas.M456("SA769991v4-num" + num, 2);
						Mob t37 = (array9[num] = (Mob)GameScr.vMob.M1114(msg.M887().M1088()));
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
						GameCanvas.M456("SA769991v5-num" + num, 2);
					}
				}
				catch (Exception ex12)
				{
					Cout.M326("Loi PLAYER_ATTACK_NPC " + ex12.ToString());
				}
				GameCanvas.M456("SA769992", 2);
				if (num > 0)
				{
					t.attMobs = new Mob[num];
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
				GameCanvas.M456("SXX6", 2);
				t = null;
				int num63 = msg.M887().M1094();
				if (num63 == Char.M113().charID)
				{
					bool flag5 = false;
					t = Char.M113();
					t.cHP = msg.M889();
					int num64 = msg.M889();
					Res.M1513("dame hit = " + num64);
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
							Res.M1513("hit eff= " + b31);
							EffectMn.M376(new Effect(b31, t.cx, t.cy, 3, 1, -1));
						}
					}
					catch (Exception)
					{
					}
					num64 += num65;
					if (Char.M113().cTypePk != 4)
					{
						if (num64 == 0)
						{
							GameScr.M643(mResources.miss, t.cx, t.cy - t.ch, 0, -3, mFont.MISS_ME);
						}
						else
						{
							GameScr.M643("-" + num64, t.cx, t.cy - t.ch, 0, -3, flag5 ? mFont.FATAL : mFont.RED);
						}
					}
					break;
				}
				t = GameScr.M626(num63);
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
						Res.M1513("hit eff= " + b32);
						EffectMn.M376(new Effect(b32, t.cx, t.cy, 3, 1, -1));
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
						GameScr.M643(mResources.miss, t.cx, t.cy - t.ch, 0, -3, mFont.MISS);
					}
					else
					{
						GameScr.M643("-" + num66, t.cx, t.cy - t.ch, 0, -3, flag6 ? mFont.FATAL : mFont.ORANGE);
					}
				}
				break;
			}
			case 57:
			{
				GameCanvas.M456("SZ6", 2);
				MyVector t26 = new MyVector();
				t26.M1111(new Command(msg.M887().M1100(), GameCanvas.instance, 88817, null));
				GameCanvas.menu.M877(t26, 3);
				break;
			}
			case 58:
			{
				GameCanvas.M456("SZ7", 2);
				int num58 = msg.M887().M1094();
				Char t20 = ((num58 != Char.M113().charID) ? GameScr.M626(num58) : Char.M113());
				t20.moveFast = new short[3];
				t20.moveFast[0] = 0;
				short num59 = msg.M887().M1092();
				short num60 = msg.M887().M1092();
				t20.moveFast[1] = num59;
				t20.moveFast[2] = num60;
				try
				{
					num58 = msg.M887().M1094();
					Char t21 = ((num58 != Char.M113().charID) ? GameScr.M626(num58) : Char.M113());
					t21.cx = num59;
					t21.cy = num60;
				}
				catch (Exception ex5)
				{
					Cout.M326("Loi MOVE_FAST " + ex5.ToString());
				}
				break;
			}
			case 62:
				GameCanvas.M456("SZ3", 2);
				t = GameScr.M626(msg.M887().M1094());
				if (t != null)
				{
					t.killCharId = Char.M113().charID;
					Char.M113().npcFocus = null;
					Char.M113().mobFocus = null;
					Char.M113().itemFocus = null;
					Char.M113().charFocus = t;
					Char.isManualFocus = true;
					GameScr.info1.M762(t.cName + mResources.CUU_SAT, 0);
				}
				break;
			case 63:
				GameCanvas.M456("SZ4", 2);
				Char.M113().killCharId = msg.M887().M1094();
				Char.M113().npcFocus = null;
				Char.M113().mobFocus = null;
				Char.M113().itemFocus = null;
				Char.M113().charFocus = GameScr.M626(Char.M113().killCharId);
				Char.isManualFocus = true;
				break;
			case 64:
				GameCanvas.M456("SZ5", 2);
				t = Char.M113();
				try
				{
					t = GameScr.M626(msg.M887().M1094());
				}
				catch (Exception ex4)
				{
					Cout.M326("Loi CLEAR_CUU_SAT " + ex4.ToString());
				}
				t.killCharId = -9999;
				break;
			case 65:
			{
				sbyte id = msg.M887().M1086();
				string text4 = msg.M887().M1100();
				short num49 = msg.M887().M1092();
				if (ItemTime.M841(id))
				{
					if (num49 != 0)
					{
						ItemTime.M840(id).M837(id, text4, num49);
					}
					else
					{
						GameScr.textTime.M1119(ItemTime.M840(id));
					}
				}
				else
				{
					ItemTime t19 = new ItemTime();
					t19.M837(id, text4, num49);
					GameScr.textTime.M1111(t19);
				}
				break;
			}
			case 66:
				M318(msg);
				break;
			case 68:
			{
				Res.M1513("ADD ITEM TO MAP --------------------------------------");
				GameCanvas.M456("SA6333", 2);
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
				ItemMap o = new ItemMap(num47, itemMapID, itemTemplateID, x, y, r);
				GameScr.vItemMap.M1111(o);
				break;
			}
			case 81:
				GameCanvas.M456("SXX4", 2);
				((Mob)GameScr.vMob.M1114(msg.M887().M1091())).isDisable = msg.M887().M1096();
				break;
			case 82:
				GameCanvas.M456("SXX5", 2);
				((Mob)GameScr.vMob.M1114(msg.M887().M1091())).isDontMove = msg.M887().M1096();
				break;
			case 83:
			{
				GameCanvas.M456("SXX8", 2);
				int num34 = msg.M887().M1094();
				t = ((num34 != Char.M113().charID) ? GameScr.M626(num34) : Char.M113());
				if (t == null)
				{
					return;
				}
				Mob mobToAttack = (Mob)GameScr.vMob.M1114(msg.M887().M1091());
				if (t.mobMe != null)
				{
					t.mobMe.M1004(mobToAttack);
				}
				break;
			}
			case 84:
			{
				int num23 = msg.M887().M1094();
				if (num23 == Char.M113().charID)
				{
					t = Char.M113();
				}
				else
				{
					t = GameScr.M626(num23);
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
				GameCanvas.M456("SXX5", 2);
				((Mob)GameScr.vMob.M1114(msg.M887().M1091())).isFire = msg.M887().M1096();
				break;
			case 86:
			{
				GameCanvas.M456("SXX5", 2);
				Mob t13 = (Mob)GameScr.vMob.M1114(msg.M887().M1091());
				t13.isIce = msg.M887().M1096();
				if (!t13.isIce)
				{
					ServerEffect.M1571(77, t13.x, t13.y - 9, 1);
				}
				break;
			}
			case 87:
				GameCanvas.M456("SXX5", 2);
				((Mob)GameScr.vMob.M1114(msg.M887().M1091())).isWind = msg.M887().M1096();
				break;
			case 88:
			{
				string info = msg.M887().M1100();
				short num22 = msg.M887().M1092();
				GameCanvas.inputDlg.M777(info, new Command(mResources.ACCEPT, GameCanvas.instance, 88818, num22), TField.INPUT_TYPE_ANY);
				break;
			}
			case 90:
				GameCanvas.M456("SA577", 2);
				M302(msg);
				break;
			case 92:
			{
				if (GameCanvas.currentScreen == GameScr.instance)
				{
					GameCanvas.M488();
				}
				string text = msg.M887().M1100();
				string text2 = Res.M1518(msg.M887().M1100());
				string empty = string.Empty;
				Char t4 = null;
				sbyte b = 0;
				if (!text.Equals(string.Empty))
				{
					t4 = new Char();
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
				InfoDlg.M753();
				if (text.Equals(string.Empty))
				{
					GameScr.info1.M762(empty, 0);
					break;
				}
				GameScr.info2.M761(empty, t4, b == 0);
				if (GameCanvas.panel.isShow && GameCanvas.panel.type == 8)
				{
					GameCanvas.panel.M1315();
				}
				break;
			}
			case 94:
				GameCanvas.M456("SA3", 2);
				GameScr.info1.M762(msg.M887().M1100(), 0);
				break;
			}
			switch (msg.command)
			{
			case -73:
			{
				sbyte b63 = msg.M887().M1088();
				for (int num175 = 0; num175 < GameScr.vNpc.M1113(); num175++)
				{
					Npc t71 = (Npc)GameScr.vNpc.M1114(num175);
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
				Mob t64 = null;
				try
				{
					t64 = (Mob)GameScr.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
				}
				if (t64 != null)
				{
					t64.levelBoss = msg.M887().M1088();
					if (t64.levelBoss > 0)
					{
						t64.typeSuperEff = Res.M1522(0, 3);
					}
				}
				break;
			}
			case 19:
				Char.M113().countKill = msg.M887().M1093();
				Char.M113().countKillMax = msg.M887().M1093();
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
					Char t63 = GameScr.M626(charId);
					if (t63 != null)
					{
						t63.cx = cx;
						t63.cy = cy;
						t63.cHP = (t63.cHPShow = cHPShow);
						t63.lastUpdateTime = mSystem.M1054();
					}
				}
				break;
			}
			case -17:
				GameCanvas.M456("SA88", 2);
				Char.M113().meDead = true;
				Char.M113().cPk = msg.M887().M1088();
				Char.M113().M220(msg.M887().M1092(), msg.M887().M1092());
				try
				{
					Char.M113().cPower = msg.M887().M1095();
					Char.M113().M103();
				}
				catch (Exception)
				{
					Cout.M326("Loi tai ME_DIE " + msg.command);
				}
				Char.M113().countKill = 0;
				break;
			case -16:
				GameCanvas.M456("SA90", 2);
				if (Char.M113().wdx != 0 || Char.M113().wdy != 0)
				{
					Char.M113().cx = Char.M113().wdx;
					Char.M113().cy = Char.M113().wdy;
					Char t59 = Char.M113();
					Char.M113().wdy = 0;
					t59.wdx = 0;
				}
				Char.M113().M222();
				Char.M113().isLockMove = false;
				Char.M113().meDead = false;
				break;
			case -13:
			{
				GameCanvas.M456("SA82", 2);
				int num162 = msg.M887().M1091();
				if (num162 <= GameScr.vMob.M1113() - 1 && num162 >= 0)
				{
					Mob t62 = (Mob)GameScr.vMob.M1114(num162);
					t62.sys = msg.M887().M1088();
					t62.levelBoss = msg.M887().M1088();
					if (t62.levelBoss != 0)
					{
						t62.typeSuperEff = Res.M1522(0, 3);
					}
					t62.x = t62.xFirst;
					t62.y = t62.yFirst;
					t62.status = 5;
					t62.injureThenDie = false;
					t62.hp = msg.M887().M1094();
					t62.maxHp = t62.hp;
					ServerEffect.M1571(60, t62.x, t62.y, 1);
					break;
				}
				return;
			}
			case -12:
			{
				Res.M1513("SERVER SEND MOB DIE");
				GameCanvas.M456("SA85", 2);
				Mob t65 = null;
				try
				{
					t65 = (Mob)GameScr.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
					Cout.M326("LOi tai NPC_DIE cmd " + msg.command);
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
						GameScr.M643("-" + num166, t65.x, t65.y - t65.h, 0, -2, mFont.FATAL);
					}
					else
					{
						GameScr.M643("-" + num166, t65.x, t65.y - t65.h, 0, -2, mFont.ORANGE);
					}
					sbyte b62 = msg.M887().M1088();
					for (int num167 = 0; num167 < b62; num167++)
					{
						ItemMap t66 = new ItemMap(msg.M887().M1092(), msg.M887().M1092(), t65.x, t65.y, msg.M887().M1092(), msg.M887().M1092());
						int num168 = (t66.playerId = msg.M887().M1094());
						Res.M1513("playerid= " + num168 + " my id= " + Char.M113().charID);
						GameScr.vItemMap.M1111(t66);
						if (Res.M1529(t66.y - Char.M113().cy) < 24 && Res.M1529(t66.x - Char.M113().cx) < 24)
						{
							Char.M113().charFocus = null;
						}
					}
				}
				catch (Exception ex30)
				{
					Cout.M326("LOi tai NPC_DIE " + ex30.ToString() + " cmd " + msg.command);
				}
				break;
			}
			case -11:
			{
				GameCanvas.M456("SA86", 2);
				Mob t67 = null;
				try
				{
					byte index5 = msg.M887().M1091();
					t67 = (Mob)GameScr.vMob.M1114(index5);
				}
				catch (Exception)
				{
					Cout.M326("Loi tai NPC_ATTACK_ME " + msg.command);
				}
				if (t67 != null)
				{
					Char.M113().isDie = false;
					Char.isLockKey = false;
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
						Char.M113().M218(num169, num170, isCrit: false, isMob: true);
						break;
					}
					t67.dame = num169;
					t67.dameMp = num170;
					t67.M990(Char.M113());
				}
				break;
			}
			case -10:
			{
				GameCanvas.M456("SA87", 2);
				Mob t60 = null;
				try
				{
					t60 = (Mob)GameScr.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
				}
				GameCanvas.M456("SA87x1", 2);
				if (t60 != null)
				{
					GameCanvas.M456("SA87x2", 2);
					t = GameScr.M626(msg.M887().M1094());
					if (t == null)
					{
						return;
					}
					GameCanvas.M456("SA87x3", 2);
					int num160 = msg.M889();
					t60.dame = t.cHP - num160;
					t.cHPNew = num160;
					GameCanvas.M456("SA87x4", 2);
					try
					{
						t.cMP = msg.M889();
					}
					catch (Exception)
					{
					}
					GameCanvas.M456("SA87x5", 2);
					if (t60.isBusyAttackSomeOne)
					{
						t.M218(t60.dame, 0, isCrit: false, isMob: true);
					}
					else
					{
						t60.M990(t);
					}
					GameCanvas.M456("SA87x6", 2);
				}
				break;
			}
			case -9:
			{
				GameCanvas.M456("SA83", 2);
				Mob t58 = null;
				try
				{
					t58 = (Mob)GameScr.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
				}
				GameCanvas.M456("SA83v1", 2);
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
						EffectMn.M376(new Effect(b58, t58.x, t58.getY(), 3, 1, -1));
					}
					GameCanvas.M456("SA83v2", 2);
					if (flag9)
					{
						GameScr.M643("-" + num158, t58.x, t58.getY() - t58.getH(), 0, -2, mFont.FATAL);
					}
					else if (num158 == 0)
					{
						t58.x = t58.xFirst;
						t58.y = t58.yFirst;
						GameScr.M643(mResources.miss, t58.x, t58.getY() - t58.getH(), 0, -2, mFont.MISS);
					}
					else
					{
						GameScr.M643("-" + num158, t58.x, t58.getY() - t58.getH(), 0, -2, mFont.ORANGE);
					}
				}
				GameCanvas.M456("SA83v3", 2);
				break;
			}
			case -8:
				GameCanvas.M456("SA89", 2);
				t = GameScr.M626(msg.M887().M1094());
				if (t == null)
				{
					return;
				}
				t.cPk = msg.M887().M1088();
				t.M221(msg.M887().M1092(), msg.M887().M1092());
				break;
			case -7:
			{
				GameCanvas.M456("SA80", 2);
				int num173 = msg.M887().M1094();
				Cout.M326("RECEVED MOVE OF " + num173);
				for (int num174 = 0; num174 < GameScr.vCharInMap.M1113(); num174++)
				{
					Char t70 = null;
					try
					{
						t70 = (Char)GameScr.vCharInMap.M1114(num174);
					}
					catch (Exception ex35)
					{
						Cout.M326("Loi PLAYER_MOVE " + ex35.ToString());
					}
					if (t70 != null)
					{
						if (t70.charID == num173)
						{
							GameCanvas.M456("SA8x2y" + num174, 2);
							t70.M202(msg.M887().M1092(), msg.M887().M1092(), 0);
							t70.lastUpdateTime = mSystem.M1054();
							break;
						}
						continue;
					}
					break;
				}
				GameCanvas.M456("SA80x3", 2);
				break;
			}
			case -6:
			{
				GameCanvas.M456("SA81", 2);
				int num171 = msg.M887().M1094();
				for (int num172 = 0; num172 < GameScr.vCharInMap.M1113(); num172++)
				{
					Char t68 = (Char)GameScr.vCharInMap.M1114(num172);
					if (t68 != null && t68.charID == num171)
					{
						if (!t68.isInvisiblez && !t68.isUsePlane)
						{
							ServerEffect.M1571(60, t68.cx, t68.cy, 1);
						}
						if (!t68.isUsePlane)
						{
							GameScr.vCharInMap.M1118(num172);
						}
						return;
					}
				}
				break;
			}
			case -5:
			{
				GameCanvas.M456("SA79", 2);
				int charID = msg.M887().M1094();
				int num155 = msg.M887().M1094();
				Char t56;
				if (num155 != -100)
				{
					t56 = new Char();
					t56.charID = charID;
					t56.clanID = num155;
				}
				else
				{
					t56 = new Mabu();
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
						Res.M1513("nhân vật bay trên trời xuống x= " + t56.cx + " y= " + t56.cy);
						Teleport t10 = new Teleport(t56.cx, t56.cy, t56.head, t56.cdir, 1, isMe: false, (b57 != 1) ? b57 : t56.cgender);
						t10.id = t56.charID;
						Teleport p3 = t10;
						t56.isTeleport = true;
						Teleport.M1894(p3);
					}
					if (b57 == 2)
					{
						t56.M140();
					}
					for (int num156 = 0; num156 < GameScr.vMob.M1113(); num156++)
					{
						Mob t57 = (Mob)GameScr.vMob.M1114(num156);
						if (t57 != null && t57.isMobMe && t57.mobId == t56.charID)
						{
							Res.M1513("co 1 con quai");
							t56.mobMe = t57;
							t56.mobMe.x = t56.cx;
							t56.mobMe.y = t56.cy - 40;
							break;
						}
					}
					if (GameScr.M626(t56.charID) == null)
					{
						GameScr.vCharInMap.M1111(t56);
					}
					t56.isMonkey = msg.M887().M1088();
					short num157 = msg.M887().M1092();
					Res.M1513("mount id= " + num157 + "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
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
							if (num157 >= Char.ID_NEW_MOUNT)
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
				Res.M1513("addplayer:   " + cFlag);
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
				GameScr.M559().M671(t56.charID, t56.cFlag);
				break;
			}
			case -3:
			{
				GameCanvas.M456("SA78", 2);
				sbyte b59 = msg.M887().M1088();
				int num159 = msg.M887().M1094();
				if (b59 == 0)
				{
					Char t35 = Char.M113();
					t35.cPower += num159;
				}
				if (b59 == 1)
				{
					Char t35 = Char.M113();
					t35.cTiemNang += num159;
				}
				if (b59 == 2)
				{
					Char t35 = Char.M113();
					t35.cPower += num159;
					t35 = Char.M113();
					t35.cTiemNang += num159;
				}
				Char.M113().M103();
				if (Char.M113().cTypePk != 3)
				{
					GameScr.M643(((num159 <= 0) ? string.Empty : "+") + num159, Char.M113().cx, Char.M113().cy - Char.M113().ch, 0, -4, mFont.GREEN);
					if (num159 > 0 && Char.M113().petFollow != null && Char.M113().petFollow.smallID == 5002)
					{
						ServerEffect.M1571(55, Char.M113().petFollow.cmx, Char.M113().petFollow.cmy, 1);
						ServerEffect.M1571(55, Char.M113().cx, Char.M113().cy, 1);
					}
				}
				break;
			}
			case -2:
			{
				GameCanvas.M456("SA77", 22);
				int num177 = msg.M887().M1094();
				Char t35 = Char.M113();
				t35.yen += num177;
				GameScr.M643((num177 <= 0) ? (string.Empty + num177) : ("+" + num177), Char.M113().cx, Char.M113().cy - Char.M113().ch - 10, 0, -2, mFont.YELLOW);
				break;
			}
			case -1:
			{
				GameCanvas.M456("SA77", 222);
				int num176 = msg.M887().M1094();
				Char t35 = Char.M113();
				t35.xu += num176;
				Char.M113().xuStr = mSystem.M1042(Char.M113().xu);
				t35 = Char.M113();
				t35.yen -= num176;
				GameScr.M643("+" + num176, Char.M113().cx, Char.M113().cy - Char.M113().ch - 10, 0, -2, mFont.YELLOW);
				break;
			}
			case 45:
			{
				GameCanvas.M456("SA84", 2);
				Mob t69 = null;
				try
				{
					t69 = (Mob)GameScr.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception ex34)
				{
					Cout.M326("Loi tai NPC_MISS  " + ex34.ToString());
				}
				if (t69 != null)
				{
					t69.hp = msg.M887().M1094();
					GameScr.M643(mResources.miss, t69.x, t69.y - t69.h, 0, -2, mFont.MISS);
				}
				break;
			}
			case 44:
			{
				GameCanvas.M456("SA91", 2);
				int num165 = msg.M887().M1094();
				string text9 = msg.M887().M1100();
				Res.M1513("user id= " + num165 + " text= " + text9);
				t = ((Char.M113().charID != num165) ? GameScr.M626(num165) : Char.M113());
				if (t == null)
				{
					return;
				}
				t.M111(text9);
				break;
			}
			case 95:
			{
				GameCanvas.M456("SA77", 22);
				int num163 = msg.M887().M1094();
				Char t35 = Char.M113();
				t35.xu += num163;
				Char.M113().xuStr = mSystem.M1042(Char.M113().xu);
				GameScr.M643((num163 <= 0) ? (string.Empty + num163) : ("+" + num163), Char.M113().cx, Char.M113().cy - Char.M113().ch - 10, 0, -2, mFont.YELLOW);
				break;
			}
			case 96:
				GameCanvas.M456("SA77a", 22);
				Char.M113().taskOrders.M1111(new TaskOrder(msg.M887().M1088(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1100(), msg.M887().M1100(), msg.M887().M1088(), msg.M887().M1088()));
				break;
			case 97:
			{
				sbyte b60 = msg.M887().M1088();
				for (int num161 = 0; num161 < Char.M113().taskOrders.M1113(); num161++)
				{
					TaskOrder t61 = (TaskOrder)Char.M113().taskOrders.M1114(num161);
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
				GameCanvas.M456("SA85", 2);
				Mob t54 = null;
				try
				{
					t54 = (Mob)GameScr.vMob.M1114(msg.M887().M1091());
				}
				catch (Exception)
				{
					Cout.M326("Loi tai NPC CHANGE " + msg.command);
				}
				if (t54 != null && t54.status != 0 && t54.status != 0)
				{
					t54.status = 0;
					ServerEffect.M1571(60, t54.x, t54.y, 1);
					ItemMap t55 = new ItemMap(msg.M887().M1092(), msg.M887().M1092(), t54.x, t54.y, msg.M887().M1092(), msg.M887().M1092());
					GameScr.vItemMap.M1111(t55);
					if (Res.M1529(t55.y - Char.M113().cy) < 24 && Res.M1529(t55.x - Char.M113().cx) < 24)
					{
						Char.M113().charFocus = null;
					}
				}
				break;
			}
			case 66:
				Res.M1513("ME DIE XP DOWN NOT IMPLEMENT YET!!!!!!!!!!!!!!!!!!!!!!!!!!");
				break;
			}
			GameCanvas.M456("SA92", 2);
		}
		catch (Exception)
		{
		}
		finally
		{
			msg?.M890();
		}
	}

	private void M303(myReader d)
	{
		GameScr.vcItem = d.M1088();
		ItemTemplates.itemTemplates.M1075();
		GameScr.M559().iOptionTemplates = new ItemOptionTemplate[d.M1091()];
		for (int i = 0; i < GameScr.M559().iOptionTemplates.Length; i++)
		{
			GameScr.M559().iOptionTemplates[i] = new ItemOptionTemplate();
			GameScr.M559().iOptionTemplates[i].id = i;
			GameScr.M559().iOptionTemplates[i].name = d.M1100();
			GameScr.M559().iOptionTemplates[i].type = d.M1088();
		}
		int num = d.M1092();
		for (int j = 0; j < num; j++)
		{
			ItemTemplates.M833(new ItemTemplate((short)j, d.M1088(), d.M1088(), d.M1100(), d.M1100(), d.M1088(), d.M1094(), d.M1092(), d.M1092(), d.M1096()));
		}
	}

	private void M304(myReader d)
	{
		GameScr.vcSkill = d.M1088();
		GameScr.M559().sOptionTemplates = new SkillOptionTemplate[d.M1088()];
		for (int i = 0; i < GameScr.M559().sOptionTemplates.Length; i++)
		{
			GameScr.M559().sOptionTemplates[i] = new SkillOptionTemplate();
			GameScr.M559().sOptionTemplates[i].id = i;
			GameScr.M559().sOptionTemplates[i].name = d.M1100();
		}
		GameScr.nClasss = new NClass[d.M1088()];
		for (int j = 0; j < GameScr.nClasss.Length; j++)
		{
			GameScr.nClasss[j] = new NClass();
			GameScr.nClasss[j].classId = j;
			GameScr.nClasss[j].name = d.M1100();
			GameScr.nClasss[j].skillTemplates = new SkillTemplate[d.M1088()];
			for (int k = 0; k < GameScr.nClasss[j].skillTemplates.Length; k++)
			{
				GameScr.nClasss[j].skillTemplates[k] = new SkillTemplate();
				GameScr.nClasss[j].skillTemplates[k].id = d.M1088();
				GameScr.nClasss[j].skillTemplates[k].name = d.M1100();
				GameScr.nClasss[j].skillTemplates[k].maxPoint = d.M1088();
				GameScr.nClasss[j].skillTemplates[k].manaUseType = d.M1088();
				GameScr.nClasss[j].skillTemplates[k].type = d.M1088();
				GameScr.nClasss[j].skillTemplates[k].iconId = d.M1092();
				GameScr.nClasss[j].skillTemplates[k].damInfo = d.M1100();
				int lineWidth = 130;
				if (GameCanvas.w == 128 || GameCanvas.h <= 208)
				{
					lineWidth = 100;
				}
				GameScr.nClasss[j].skillTemplates[k].description = mFont.tahoma_7_green2.M907(d.M1100(), lineWidth);
				GameScr.nClasss[j].skillTemplates[k].skills = new Skill[d.M1088()];
				for (int l = 0; l < GameScr.nClasss[j].skillTemplates[k].skills.Length; l++)
				{
					GameScr.nClasss[j].skillTemplates[k].skills[l] = new Skill();
					GameScr.nClasss[j].skillTemplates[k].skills[l].skillId = d.M1092();
					GameScr.nClasss[j].skillTemplates[k].skills[l].template = GameScr.nClasss[j].skillTemplates[k];
					GameScr.nClasss[j].skillTemplates[k].skills[l].point = d.M1088();
					GameScr.nClasss[j].skillTemplates[k].skills[l].powRequire = d.M1095();
					GameScr.nClasss[j].skillTemplates[k].skills[l].manaUse = d.M1092();
					GameScr.nClasss[j].skillTemplates[k].skills[l].coolDown = d.M1094();
					GameScr.nClasss[j].skillTemplates[k].skills[l].dx = d.M1092();
					GameScr.nClasss[j].skillTemplates[k].skills[l].dy = d.M1092();
					GameScr.nClasss[j].skillTemplates[k].skills[l].maxFight = d.M1088();
					GameScr.nClasss[j].skillTemplates[k].skills[l].damage = d.M1092();
					GameScr.nClasss[j].skillTemplates[k].skills[l].price = d.M1092();
					GameScr.nClasss[j].skillTemplates[k].skills[l].moreInfo = d.M1100();
					Skills.M1772(GameScr.nClasss[j].skillTemplates[k].skills[l]);
				}
			}
		}
	}

	private void M305(myReader d)
	{
		GameScr.vcMap = d.M1088();
		TileMap.mapNames = new string[d.M1091()];
		for (int i = 0; i < TileMap.mapNames.Length; i++)
		{
			TileMap.mapNames[i] = d.M1100();
		}
		Npc.arrNpcTemplate = new NpcTemplate[d.M1088()];
		for (sbyte b = 0; b < Npc.arrNpcTemplate.Length; b++)
		{
			Npc.arrNpcTemplate[b] = new NpcTemplate();
			Npc.arrNpcTemplate[b].npcTemplateId = b;
			Npc.arrNpcTemplate[b].name = d.M1100();
			Npc.arrNpcTemplate[b].headId = d.M1092();
			Npc.arrNpcTemplate[b].bodyId = d.M1092();
			Npc.arrNpcTemplate[b].legId = d.M1092();
			Npc.arrNpcTemplate[b].menu = new string[d.M1088()][];
			for (int j = 0; j < Npc.arrNpcTemplate[b].menu.Length; j++)
			{
				Npc.arrNpcTemplate[b].menu[j] = new string[d.M1088()];
				for (int k = 0; k < Npc.arrNpcTemplate[b].menu[j].Length; k++)
				{
					Npc.arrNpcTemplate[b].menu[j][k] = d.M1100();
				}
			}
		}
		Mob.arrMobTemplate = new MobTemplate[d.M1088()];
		for (sbyte b2 = 0; b2 < Mob.arrMobTemplate.Length; b2++)
		{
			Mob.arrMobTemplate[b2] = new MobTemplate();
			Mob.arrMobTemplate[b2].mobTemplateId = b2;
			Mob.arrMobTemplate[b2].type = d.M1088();
			Mob.arrMobTemplate[b2].name = d.M1100();
			Mob.arrMobTemplate[b2].hp = d.M1094();
			Mob.arrMobTemplate[b2].rangeMove = d.M1088();
			Mob.arrMobTemplate[b2].speed = d.M1088();
			Mob.arrMobTemplate[b2].dartType = d.M1088();
		}
	}

	private void M306(myReader d, bool isSaveRMS)
	{
		GameScr.vcData = d.M1088();
		if (isSaveRMS)
		{
			Rms.M1534("NR_dart", NinjaUtil.M1186(d));
			Rms.M1534("NR_arrow", NinjaUtil.M1186(d));
			Rms.M1534("NR_effect", NinjaUtil.M1186(d));
			Rms.M1534("NR_image", NinjaUtil.M1186(d));
			Rms.M1534("NR_part", NinjaUtil.M1186(d));
			Rms.M1534("NR_skill", NinjaUtil.M1186(d));
			Rms.M1548("NRdata");
		}
	}

	private Image M307(sbyte[] arr)
	{
		try
		{
			return Image.M708(arr, 0, arr.Length);
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

	public void M309(Message msg, int index)
	{
		try
		{
			ClanMessage t = new ClanMessage();
			sbyte b = (sbyte)(t.type = msg.M887().M1088());
			t.id = msg.M887().M1094();
			t.playerId = msg.M887().M1094();
			t.playerName = msg.M887().M1100();
			t.role = msg.M887().M1088();
			t.time = msg.M887().M1094() + 1000000000;
			bool upToTop = false;
			GameScr.isNewClanMessage = false;
			switch (b)
			{
			case 0:
			{
				string text = msg.M887().M1100();
				GameScr.isNewClanMessage = true;
				if (mFont.tahoma_7.M909(text) > Panel.WIDTH_PANEL - 60)
				{
					t.chat = mFont.tahoma_7.M907(text, Panel.WIDTH_PANEL - 10);
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
					GameScr.isNewClanMessage = true;
				}
				if (t.playerId != Char.M113().charID)
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
				if (GameCanvas.panel.cp != null)
				{
					GameCanvas.panel.M1422(t.recieve, t.maxCap);
				}
				break;
			case 2:
				if (Char.M113().role == 0)
				{
					GameScr.isNewClanMessage = true;
					t.option = new string[2]
					{
						mResources.CANCEL,
						mResources.receive
					};
				}
				break;
			}
			if (GameCanvas.currentScreen != GameScr.instance)
			{
				GameScr.isNewClanMessage = false;
			}
			else if (GameCanvas.panel.isShow && GameCanvas.panel.type == 0 && GameCanvas.panel.currentTabIndex == 3)
			{
				GameScr.isNewClanMessage = false;
			}
			ClanMessage.M290(t, index, upToTop);
		}
		catch (Exception)
		{
			Cout.M326("LOI TAI CMD -= " + msg.command);
		}
	}

	public void M310(sbyte teleport3)
	{
		Res.M1513("is loading map = " + Char.isLoadingMap);
		GameScr.M559().auto = 0;
		GameScr.isChangeZone = false;
		CreateCharScr.instance = null;
		GameScr.info1.isUpdate = false;
		GameScr.info2.isUpdate = false;
		GameScr.lockTick = 0;
		GameCanvas.panel.isShow = false;
		SoundMn.M1826().M1873();
		if (!GameScr.isLoadAllData && !CreateCharScr.isCreateChar)
		{
			GameScr.M559().M532();
		}
		GameScr.M564(fullmScreen: false, (teleport3 != 1) ? (-1) : Char.M113().cx, (teleport3 == 0) ? (-1) : 0);
		TileMap.M1964();
		TileMap.M1944(TileMap.tileID);
		Res.M1513("LOAD GAMESCR 2");
		Char.M113().cvx = 0;
		Char.M113().statusMe = 4;
		Char.M113().currentMovePoint = null;
		Char.M113().mobFocus = null;
		Char.M113().charFocus = null;
		Char.M113().npcFocus = null;
		Char.M113().itemFocus = null;
		Char.M113().skillPaint = null;
		Char.M113().M183(m: false);
		Char.M113().skillPaintRandomPaint = null;
		GameCanvas.M517();
		if (Char.M113().cy >= TileMap.pxh - 100)
		{
			Char.M113().isFlyUp = true;
			Char.M113().cx += Res.M1529(Res.M1522(0, 80));
			Service.M1594().M1640();
		}
		GameScr.M559().M561();
		GameCanvas.M469(TileMap.bgID);
		Char.isLockKey = false;
		Res.M1513("cy= " + Char.M113().cy + "---------------------------------------------");
		for (int i = 0; i < Char.M113().vEff.M1113(); i++)
		{
			if (((EffectChar)Char.M113().vEff.M1114(i)).template.type == 10)
			{
				Char.isLockKey = true;
				break;
			}
		}
		GameCanvas.M484();
		GameCanvas.M483();
		GameScr.M559().dHP = Char.M113().cHP;
		GameScr.M559().dMP = Char.M113().cMP;
		Char.ischangingMap = false;
		GameScr.M559().switchToMe();
		if (Char.M113().cy <= 10 && teleport3 != 0 && teleport3 != 2)
		{
			Teleport.M1894(new Teleport(Char.M113().cx, Char.M113().cy, Char.M113().head, Char.M113().cdir, 1, isMe: true, (teleport3 != 1) ? teleport3 : Char.M113().cgender));
			Char.M113().isTeleport = true;
		}
		if (teleport3 == 2)
		{
			Char.M113().M140();
		}
		if (GameScr.M559().isRongThanXuatHien)
		{
			if (TileMap.mapID == GameScr.M559().mapRID && TileMap.zoneID == GameScr.M559().zoneRID)
			{
				GameScr.M559().M594(GameScr.M559().xR, GameScr.M559().yR);
			}
			if (mGraphics.zoomLevel > 1)
			{
				GameScr.M559().M593();
			}
		}
		InfoDlg.M753();
		InfoDlg.M748(TileMap.mapName, mResources.zone + " " + TileMap.zoneID, 30);
		GameCanvas.M488();
		GameCanvas.isLoading = false;
		Hint.M696();
		Hint.M694();
		GameCanvas.M456("SA75x9", 2);
	}

	public void M311(Message msg)
	{
		try
		{
			if (mGraphics.zoomLevel == 1)
			{
				SmallImage.M1783();
			}
			Char.M113().cx = (Char.M113().cxSend = (Char.M113().cxFocus = msg.M887().M1092()));
			Char.M113().cy = (Char.M113().cySend = (Char.M113().cyFocus = msg.M887().M1092()));
			Char.M113().xSd = Char.M113().cx;
			Char.M113().ySd = Char.M113().cy;
			Res.M1513("head= " + Char.M113().head + " body= " + Char.M113().body + " left= " + Char.M113().leg + " x= " + Char.M113().cx + " y= " + Char.M113().cy + " chung toc= " + Char.M113().cgender);
			if (Char.M113().cx >= 0 && Char.M113().cx <= 100)
			{
				Char.M113().cdir = 1;
			}
			else if (Char.M113().cx >= TileMap.tmw - 100 && Char.M113().cx <= TileMap.tmw)
			{
				Char.M113().cdir = -1;
			}
			GameCanvas.M456("SA75x4", 2);
			int num = msg.M887().M1088();
			Res.M1513("vGo size= " + num);
			if (!GameScr.info1.isDone)
			{
				GameScr.info1.cmx = Char.M113().cx - GameScr.cmx;
				GameScr.info1.cmy = Char.M113().cy - GameScr.cmy;
			}
			for (int i = 0; i < num; i++)
			{
				Waypoint t = new Waypoint(msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1100());
				if ((TileMap.mapID != 21 && TileMap.mapID != 22 && TileMap.mapID != 23) || t.minX < 0)
				{
				}
			}
			Resources.UnloadUnusedAssets();
			GC.Collect();
			GameCanvas.M456("SA75x5", 2);
			num = msg.M887().M1088();
			Mob.newMob.M1120();
			for (sbyte b = 0; b < num; b++)
			{
				Mob t2 = new Mob(b, msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1097(), msg.M887().M1088(), msg.M887().M1088(), msg.M887().M1094(), msg.M887().M1088(), msg.M887().M1094(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1088(), msg.M887().M1088());
				t2.xSd = t2.x;
				t2.ySd = t2.y;
				t2.isBoss = msg.M887().M1097();
				if (Mob.arrMobTemplate[t2.templateId].type != 0)
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
				BigBoss t3 = null;
				BachTuoc t4 = null;
				BigBoss2 t5 = null;
				NewBoss t6 = null;
				if (t2.templateId == 70)
				{
					t3 = new BigBoss(b, (short)t2.x, (short)t2.y, 70, t2.hp, t2.maxHp, t2.sys);
				}
				if (t2.templateId == 71)
				{
					t4 = new BachTuoc(b, (short)t2.x, (short)t2.y, 71, t2.hp, t2.maxHp, t2.sys);
				}
				if (t2.templateId == 72)
				{
					t5 = new BigBoss2(b, (short)t2.x, (short)t2.y, 72, t2.hp, t2.maxHp, 3);
				}
				if (t2.isBoss)
				{
					t6 = new NewBoss(b, (short)t2.x, (short)t2.y, t2.templateId, t2.hp, t2.maxHp, t2.sys);
				}
				if (t6 != null)
				{
					GameScr.vMob.M1111(t6);
				}
				else if (t3 != null)
				{
					GameScr.vMob.M1111(t3);
				}
				else if (t4 != null)
				{
					GameScr.vMob.M1111(t4);
				}
				else if (t5 != null)
				{
					GameScr.vMob.M1111(t5);
				}
				else
				{
					GameScr.vMob.M1111(t2);
				}
			}
			for (int j = 0; j < Mob.lastMob.M1113(); j++)
			{
				string text = (string)Mob.lastMob.M1114(j);
				if (!Mob.M978(text))
				{
					Mob.arrMobTemplate[int.Parse(text)].data = null;
					Mob.lastMob.M1118(j);
					j--;
				}
			}
			if (Char.M113().mobMe != null && GameScr.M628(Char.M113().mobMe.mobId) == null)
			{
				Char.M113().mobMe.M975();
				Char.M113().mobMe.x = Char.M113().cx;
				Char.M113().mobMe.y = Char.M113().cy - 40;
				GameScr.vMob.M1111(Char.M113().mobMe);
			}
			num = msg.M887().M1088();
			for (byte b2 = 0; b2 < num; b2++)
			{
			}
			GameCanvas.M456("SA75x6", 2);
			num = msg.M887().M1088();
			Res.M1513("NPC size= " + num);
			for (int k = 0; k < num; k++)
			{
				sbyte status = msg.M887().M1088();
				short cx = msg.M887().M1092();
				short num2 = msg.M887().M1092();
				sbyte b3 = msg.M887().M1088();
				short num3 = msg.M887().M1092();
				if (b3 != 6 && ((Char.M113().taskMaint.taskId >= 7 && (Char.M113().taskMaint.taskId != 7 || Char.M113().taskMaint.index > 1)) || (b3 != 7 && b3 != 8 && b3 != 9)) && (Char.M113().taskMaint.taskId >= 6 || b3 != 16))
				{
					if (b3 == 4)
					{
						GameScr.M559().magicTree = new MagicTree(k, status, cx, num2, b3, num3);
						Service.M1594().M1637(2);
						GameScr.vNpc.M1111(GameScr.M559().magicTree);
					}
					else
					{
						Npc o = new Npc(k, status, cx, num2 + 3, b3, num3);
						GameScr.vNpc.M1111(o);
					}
				}
			}
			GameCanvas.M456("SA75x7", 2);
			num = msg.M887().M1088();
			Res.M1513("item size = " + num);
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
				ItemMap t7 = new ItemMap(num4, itemMapID, itemTemplateID, x, y, r);
				bool flag = false;
				for (int m = 0; m < GameScr.vItemMap.M1113(); m++)
				{
					if (((ItemMap)GameScr.vItemMap.M1114(m)).itemMapID == t7.itemMapID)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					GameScr.vItemMap.M1111(t7);
				}
			}
			if (GameCanvas.lowGraphic && (!GameCanvas.lowGraphic || (TileMap.mapID != 51 && TileMap.mapID != 103)))
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
				TileMap.vCurrItem.M1120();
				if (mGraphics.zoomLevel == 1)
				{
					BgItem.M65();
				}
				BgItem.vKeysNew.M1120();
				Res.M1513("nItem= " + num8);
				for (int num9 = 0; num9 < num8; num9++)
				{
					short id = msg.M887().M1092();
					short num10 = msg.M887().M1092();
					short num11 = msg.M887().M1092();
					if (TileMap.M1935(id) == null)
					{
						continue;
					}
					BgItem t8 = TileMap.M1935(id);
					BgItem t9 = new BgItem();
					t9.id = id;
					t9.idImage = t8.idImage;
					t9.dx = t8.dx;
					t9.dy = t8.dy;
					t9.x = num10 * TileMap.size;
					t9.y = num11 * TileMap.size;
					t9.layer = t8.layer;
					if (TileMap.M1941(t9.id))
					{
						t9.trans = ((num9 % 2 != 0) ? 2 : 0);
						if (TileMap.mapID == 45)
						{
							t9.trans = 0;
						}
					}
					Image t10 = null;
					if (!BgItem.imgNew.M1081(t9.idImage + string.Empty))
					{
						if (mGraphics.zoomLevel == 1)
						{
							t10 = GameCanvas.M503("/mapBackGround/" + t9.idImage + ".png");
							if (t10 == null)
							{
								t10 = Image.M711(new int[1], 1, 1, bl: true);
								Service.M1594().M1709(t9.idImage);
							}
							BgItem.imgNew.M1078(t9.idImage + string.Empty, t10);
						}
						else
						{
							bool flag2 = false;
							sbyte[] array = Rms.M1535(mGraphics.zoomLevel + "bgItem" + t9.idImage);
							if (array != null)
							{
								if (BgItem.newSmallVersion != null)
								{
									Res.M1513("Small  last= " + array.Length % 127 + "new Version= " + BgItem.newSmallVersion[t9.idImage]);
									if (array.Length % 127 != BgItem.newSmallVersion[t9.idImage])
									{
										flag2 = true;
									}
								}
								if (!flag2)
								{
									t10 = Image.M708(array, 0, array.Length);
									if (t10 != null)
									{
										BgItem.imgNew.M1078(t9.idImage + string.Empty, t10);
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
								t10 = GameCanvas.M503("/mapBackGround/" + t9.idImage + ".png");
								if (t10 == null)
								{
									t10 = Image.M711(new int[1], 1, 1, bl: true);
									Service.M1594().M1709(t9.idImage);
								}
								BgItem.imgNew.M1078(t9.idImage + string.Empty, t10);
							}
						}
						BgItem.vKeysLast.M1111(t9.idImage + string.Empty);
					}
					if (!BgItem.M66(t9.idImage + string.Empty))
					{
						BgItem.vKeysNew.M1111(t9.idImage + string.Empty);
					}
					t9.M70();
					TileMap.vCurrItem.M1111(t9);
				}
				for (int num12 = 0; num12 < BgItem.vKeysLast.M1113(); num12++)
				{
					string text2 = (string)BgItem.vKeysLast.M1114(num12);
					if (!BgItem.M66(text2))
					{
						BgItem.imgNew.M1079(text2);
						if (BgItem.imgNew.M1081(text2 + "blend" + 1))
						{
							BgItem.imgNew.M1079(text2 + "blend" + 1);
						}
						if (BgItem.imgNew.M1081(text2 + "blend" + 3))
						{
							BgItem.imgNew.M1079(text2 + "blend" + 3);
						}
						BgItem.vKeysLast.M1118(num12);
						num12--;
					}
				}
				BackgroundEffect.isFog = false;
				BackgroundEffect.nCloud = 0;
				EffectMn.vEff.M1120();
				BackgroundEffect.vBgEffect.M1120();
				Effect.newEff.M1120();
				short num13 = msg.M887().M1092();
				for (int num14 = 0; num14 < num13; num14++)
				{
					M312(msg.M887().M1100(), msg.M887().M1100());
				}
				for (int num15 = 0; num15 < Effect.lastEff.M1113(); num15++)
				{
					string text3 = (string)Effect.lastEff.M1114(num15);
					if (!Effect.M388(text3))
					{
						Effect.M385(int.Parse(text3));
						Effect.lastEff.M1118(num15);
						num15--;
					}
				}
			}
			TileMap.bgType = msg.M887().M1088();
			M310(msg.M887().M1088());
			Char.isLoadingMap = false;
			GameCanvas.M456("SA75x8", 2);
			Resources.UnloadUnusedAssets();
			GC.Collect();
			Cout.M328("----------DA CHAY XONG LOAD INFO MAP");
		}
		catch (Exception ex)
		{
			Cout.M328("LOI TAI LOADMAP INFO " + ex.ToString());
		}
	}

	public void M312(string key, string value)
	{
		if (key.Equals("eff"))
		{
			if (Panel.graphics > 0)
			{
				return;
			}
			string[] array = Res.M1531(value, ".", 0);
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
			Effect t = new Effect(id, x, y, layer, loop, loopCount);
			if (array.Length > 6)
			{
				t.typeEff = int.Parse(array[6]);
				if (array.Length > 7)
				{
					t.indexFrom = int.Parse(array[7]);
					t.indexTo = int.Parse(array[8]);
				}
			}
			EffectMn.M376(t);
		}
		else if (key.Equals("beff") && Panel.graphics <= 1)
		{
			BackgroundEffect.M55(int.Parse(value));
		}
	}

	public void M313(Message msg)
	{
		GameCanvas.M456("SA6", 2);
		try
		{
			sbyte b = msg.M887().M1088();
			mSystem.M1039("---messageNotMap : " + b);
			switch (b)
			{
			case 36:
				GameScr.typeActive = msg.M887().M1088();
				Res.M1513("load Me Active: " + GameScr.typeActive);
				break;
			case 35:
				GameCanvas.M488();
				GameScr.M559().M574();
				GameScr.info1.M762(msg.M887().M1100(), 0);
				break;
			case 4:
			{
				GameCanvas.M456("SA8", 2);
				GameCanvas.loginScr.M862();
				GameScr.isAutoPlay = false;
				GameScr.canAutoPlay = false;
				LoginScr.isUpdateAll = true;
				LoginScr.isUpdateData = true;
				LoginScr.isUpdateMap = true;
				LoginScr.isUpdateSkill = true;
				LoginScr.isUpdateItem = true;
				GameScr.vsData = msg.M887().M1088();
				GameScr.vsMap = msg.M887().M1088();
				GameScr.vsSkill = msg.M887().M1088();
				GameScr.vsItem = msg.M887().M1088();
				msg.M887().M1088();
				if (GameCanvas.loginScr.isLogin2)
				{
					Rms.M1538("acc", string.Empty);
					Rms.M1538("pass", string.Empty);
				}
				else
				{
					Rms.M1538("userAo" + ServerListScreen.ipSelect, string.Empty);
				}
				if (GameScr.vsData != GameScr.vcData)
				{
					GameScr.isLoadAllData = false;
					Service.M1594().M1675();
				}
				else
				{
					try
					{
						LoginScr.isUpdateData = false;
					}
					catch (Exception)
					{
						GameScr.vcData = -1;
						Service.M1594().M1675();
					}
				}
				if (GameScr.vsMap != GameScr.vcMap)
				{
					GameScr.isLoadAllData = false;
					Service.M1594().M1676();
				}
				else
				{
					try
					{
						if (!GameScr.isLoadAllData)
						{
							M305(new DataInputStream(Rms.M1535("NRmap")).r);
						}
						LoginScr.isUpdateMap = false;
					}
					catch (Exception)
					{
						GameScr.vcMap = -1;
						Service.M1594().M1676();
					}
				}
				if (GameScr.vsSkill != GameScr.vcSkill)
				{
					GameScr.isLoadAllData = false;
					Service.M1594().M1677();
				}
				else
				{
					try
					{
						if (!GameScr.isLoadAllData)
						{
							M304(new DataInputStream(Rms.M1535("NRskill")).r);
						}
						LoginScr.isUpdateSkill = false;
					}
					catch (Exception)
					{
						GameScr.vcSkill = -1;
						Service.M1594().M1677();
					}
				}
				if (GameScr.vsItem != GameScr.vcItem)
				{
					GameScr.isLoadAllData = false;
					Service.M1594().M1678();
				}
				else
				{
					try
					{
						M320(new DataInputStream(Rms.M1535("NRitem0")).r, 0, isSave: false);
						M320(new DataInputStream(Rms.M1535("NRitem1")).r, 1, isSave: false);
						M320(new DataInputStream(Rms.M1535("NRitem2")).r, 2, isSave: false);
						M320(new DataInputStream(Rms.M1535("NRitem100")).r, 100, isSave: false);
						LoginScr.isUpdateItem = false;
					}
					catch (Exception)
					{
						GameScr.vcItem = -1;
						Service.M1594().M1678();
					}
				}
				if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
				{
					if (!GameScr.isLoadAllData)
					{
						GameScr.M559().M557();
						GameScr.M559().M555();
						GameScr.M559().M556();
						GameScr.M559().M558();
					}
					Service.M1594().M1679();
				}
				sbyte b2 = msg.M887().M1088();
				Res.M1513("CAPTION LENT= " + b2);
				GameScr.exps = new long[b2];
				for (int j = 0; j < GameScr.exps.Length; j++)
				{
					GameScr.exps[j] = msg.M887().M1095();
				}
				break;
			}
			case 6:
			{
				Res.M1513("GET UPDATE_MAP " + msg.M887().M1104() + " bytes");
				msg.M887().M1089(100000);
				M305(msg.M887());
				msg.M887().M1090();
				sbyte[] data2 = new sbyte[msg.M887().M1104()];
				msg.M887().M1103(ref data2);
				Rms.M1534("NRmap", data2);
				Rms.M1534("NRmapVersion", new sbyte[1] { GameScr.vcMap });
				LoginScr.isUpdateMap = false;
				if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
				{
					GameScr.M559().M557();
					GameScr.M559().M555();
					GameScr.M559().M556();
					GameScr.M559().M558();
					Service.M1594().M1679();
				}
				break;
			}
			case 7:
			{
				Res.M1513("GET UPDATE_SKILL " + msg.M887().M1104() + " bytes");
				msg.M887().M1089(100000);
				M304(msg.M887());
				msg.M887().M1090();
				sbyte[] data = new sbyte[msg.M887().M1104()];
				msg.M887().M1103(ref data);
				Rms.M1534("NRskill", data);
				Rms.M1534("NRskillVersion", new sbyte[1] { GameScr.vcSkill });
				LoginScr.isUpdateSkill = false;
				if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
				{
					GameScr.M559().M557();
					GameScr.M559().M555();
					GameScr.M559().M556();
					GameScr.M559().M558();
					Service.M1594().M1679();
				}
				break;
			}
			case 8:
				Res.M1513("GET UPDATE_ITEM " + msg.M887().M1104() + " bytes");
				M319(msg.M887());
				break;
			case 9:
				GameCanvas.M456("SA11", 2);
				break;
			case 10:
				try
				{
					Char.isLoadingMap = true;
					Res.M1513("REQUEST MAP TEMPLATE");
					GameCanvas.isLoading = true;
					TileMap.maps = null;
					TileMap.types = null;
					mSystem.M1062();
					GameCanvas.M456("SA99", 2);
					TileMap.tmw = msg.M887().M1088();
					TileMap.tmh = msg.M887().M1088();
					TileMap.maps = new int[TileMap.tmw * TileMap.tmh];
					Res.M1513("   M apsize= " + TileMap.tmw * TileMap.tmh);
					for (int i = 0; i < TileMap.maps.Length; i++)
					{
						int num2 = msg.M887().M1088();
						if (num2 < 0)
						{
							num2 += 256;
						}
						TileMap.maps[i] = (ushort)num2;
					}
					TileMap.types = new int[TileMap.maps.Length];
					msg = messWait;
					M311(msg);
					try
					{
						TileMap.isMapDouble = ((msg.M887().M1088() != 0) ? true : false);
					}
					catch (Exception)
					{
					}
				}
				catch (Exception ex2)
				{
					Cout.M328("LOI TAI CASE REQUEST_MAPTEMPLATE " + ex2.ToString());
				}
				msg.M890();
				messWait.M890();
				msg = (messWait = null);
				break;
			case 12:
				GameCanvas.M456("SA10", 2);
				break;
			case 16:
				MoneyCharge.M1013().switchToMe();
				break;
			case 17:
				GameCanvas.M456("SYB123", 2);
				Char.M113().M226();
				break;
			case 18:
			{
				GameCanvas.isLoading = false;
				GameCanvas.M488();
				int num = msg.M887().M1094();
				GameCanvas.inputDlg.M777(mResources.changeNameChar, new Command(mResources.OK, GameCanvas.instance, 88829, num), TField.INPUT_TYPE_ANY);
				break;
			}
			case 20:
				Char.M113().cPk = msg.M887().M1088();
				GameScr.info1.M762(mResources.PK_NOW + " " + Char.M113().cPk, 0);
				break;
			}
		}
		catch (Exception)
		{
			Cout.M328("LOI TAI messageNotMap + " + msg.command);
		}
		finally
		{
			msg?.M890();
		}
	}

	public void M314(Message msg)
	{
		try
		{
			sbyte b = msg.M887().M1088();
			mSystem.M1039("---messageNotLogin : " + b);
			if (b != 2)
			{
				return;
			}
			string text = msg.M887().M1100();
			if (mSystem.isTest)
			{
				text = "88:192.168.1.88:20000:0,53:112.213.85.53:20000:0," + text;
			}
			if (mSystem.clientType == 1)
			{
				ServerListScreen.linkDefault = text;
			}
			else
			{
				ServerListScreen.linkDefault = text;
			}
			ServerListScreen.M1581(ServerListScreen.linkDefault);
			try
			{
				Panel.CanNapTien = msg.M887().M1088() == 1;
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

	public void M315(Message msg)
	{
		try
		{
			GameCanvas.M456("SA12", 2);
			sbyte b = msg.M887().M1088();
			mSystem.M1039("---messageSubCommand : " + b);
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
					GameScr.M559().M541(data);
				}
				else if (text.Equals("OSkill"))
				{
					GameScr.M559().M540(data);
				}
				else if (text.Equals("CSkill"))
				{
					GameScr.M559().M542(data);
				}
				break;
			}
			case 62:
			{
				Res.M1513("ME UPDATE SKILL");
				Skill t9 = Skills.M1773(msg.M887().M1092());
				for (int num11 = 0; num11 < Char.M113().vSkill.M1113(); num11++)
				{
					if (((Skill)Char.M113().vSkill.M1114(num11)).template.id == t9.template.id)
					{
						Char.M113().vSkill.M1116(t9, num11);
						break;
					}
				}
				for (int num12 = 0; num12 < Char.M113().vSkillFight.M1113(); num12++)
				{
					if (((Skill)Char.M113().vSkillFight.M1114(num12)).template.id == t9.template.id)
					{
						Char.M113().vSkillFight.M1116(t9, num12);
						break;
					}
				}
				for (int num13 = 0; num13 < GameScr.onScreenSkill.Length; num13++)
				{
					if (GameScr.onScreenSkill[num13] != null && GameScr.onScreenSkill[num13].template.id == t9.template.id)
					{
						GameScr.onScreenSkill[num13] = t9;
						break;
					}
				}
				for (int num14 = 0; num14 < GameScr.keySkill.Length; num14++)
				{
					if (GameScr.keySkill[num14] != null && GameScr.keySkill[num14].template.id == t9.template.id)
					{
						GameScr.keySkill[num14] = t9;
						break;
					}
				}
				if (Char.M113().myskill.template.id == t9.template.id)
				{
					Char.M113().myskill = t9;
				}
				GameScr.info1.M762(mResources.hasJustUpgrade1 + t9.template.name + mResources.hasJustUpgrade2 + t9.point, 0);
				break;
			}
			case 63:
			{
				sbyte b3 = msg.M887().M1088();
				if (b3 > 0)
				{
					InfoDlg.M749();
					MyVector vPlayerMenu = GameCanvas.panel.vPlayerMenu;
					for (int j = 0; j < b3; j++)
					{
						string caption = msg.M887().M1100();
						string caption2 = msg.M887().M1100();
						short menuSelect = msg.M887().M1092();
						Char.M113().charFocus.menuSelect = menuSelect;
						Command t4 = new Command(caption, 11115, Char.M113().charFocus);
						t4.caption2 = caption2;
						vPlayerMenu.M1111(t4);
					}
					InfoDlg.M753();
					GameCanvas.panel.M1256();
				}
				break;
			}
			case 0:
			{
				GameCanvas.M456("SA21", 2);
				RadarScr.list = new MyVector();
				Teleport.vTeleport.M1120();
				GameScr.vCharInMap.M1120();
				GameScr.vItemMap.M1120();
				Char.vItemTime.M1120();
				GameScr.M657();
				GameScr.currentCharViewInfo = Char.M113();
				Char.M113().charID = msg.M887().M1094();
				Char.M113().ctaskId = msg.M887().M1088();
				Char.M113().cgender = msg.M887().M1088();
				Char.M113().head = msg.M887().M1092();
				Char.M113().cName = msg.M887().M1100();
				Char.M113().cPk = msg.M887().M1088();
				Char.M113().cTypePk = msg.M887().M1088();
				Char.M113().cPower = msg.M887().M1095();
				Char.M113().M103();
				Char.M113().eff5BuffHp = msg.M887().M1092();
				Char.M113().eff5BuffMp = msg.M887().M1092();
				Char.M113().nClass = GameScr.nClasss[msg.M887().M1088()];
				Char.M113().vSkill.M1120();
				Char.M113().vSkillFight.M1120();
				GameScr.M559().dHP = Char.M113().cHP;
				GameScr.M559().dMP = Char.M113().cMP;
				sbyte b6 = msg.M887().M1088();
				for (sbyte b7 = 0; b7 < b6; b7++)
				{
					M316(Skills.M1773(msg.M887().M1092()));
				}
				GameScr.M559().M604();
				GameScr.M559().M539();
				Char.M113().xu = msg.M887().M1095();
				Char.M113().luongKhoa = msg.M887().M1094();
				Char.M113().luong = msg.M887().M1094();
				Char.M113().xuStr = mSystem.M1042(Char.M113().xu);
				Char.M113().luongStr = mSystem.M1042(Char.M113().luong);
				Char.M113().luongKhoaStr = mSystem.M1042(Char.M113().luongKhoa);
				Char.M113().arrItemBody = new Item[msg.M887().M1088()];
				try
				{
					Char.M113().M165();
					for (int k = 0; k < Char.M113().arrItemBody.Length; k++)
					{
						short num2 = msg.M887().M1092();
						if (num2 == -1)
						{
							continue;
						}
						ItemTemplate t8 = ItemTemplates.M834(num2);
						int type = t8.type;
						Char.M113().arrItemBody[k] = new Item();
						Char.M113().arrItemBody[k].template = t8;
						Char.M113().arrItemBody[k].quantity = msg.M887().M1094();
						Char.M113().arrItemBody[k].info = msg.M887().M1100();
						Char.M113().arrItemBody[k].content = msg.M887().M1100();
						int num3 = msg.M887().M1091();
						if (num3 != 0)
						{
							Char.M113().arrItemBody[k].itemOption = new ItemOption[num3];
							for (int l = 0; l < Char.M113().arrItemBody[k].itemOption.Length; l++)
							{
								int optionTemplateId = msg.M887().M1091();
								ushort param = msg.M887().M1093();
								Char.M113().arrItemBody[k].itemOption[l] = new ItemOption(optionTemplateId, param);
							}
						}
						switch (type)
						{
						case 1:
							Char.M113().leg = Char.M113().arrItemBody[k].template.part;
							Res.M1513("toi day =======================================" + Char.M113().leg);
							break;
						case 0:
							Res.M1513("toi day =======================================" + Char.M113().body);
							Char.M113().body = Char.M113().arrItemBody[k].template.part;
							break;
						}
					}
				}
				catch (Exception)
				{
				}
				Char.M113().arrItemBag = new Item[msg.M887().M1088()];
				GameScr.hpPotion = 0;
				for (int m = 0; m < Char.M113().arrItemBag.Length; m++)
				{
					short num4 = msg.M887().M1092();
					if (num4 == -1)
					{
						continue;
					}
					Char.M113().arrItemBag[m] = new Item();
					Char.M113().arrItemBag[m].template = ItemTemplates.M834(num4);
					Char.M113().arrItemBag[m].quantity = msg.M887().M1094();
					Char.M113().arrItemBag[m].info = msg.M887().M1100();
					Char.M113().arrItemBag[m].content = msg.M887().M1100();
					Char.M113().arrItemBag[m].indexUI = m;
					sbyte b8 = msg.M887().M1088();
					if (b8 != 0)
					{
						Char.M113().arrItemBag[m].itemOption = new ItemOption[b8];
						for (int n = 0; n < Char.M113().arrItemBag[m].itemOption.Length; n++)
						{
							int optionTemplateId2 = msg.M887().M1091();
							ushort param2 = msg.M887().M1093();
							Char.M113().arrItemBag[m].itemOption[n] = new ItemOption(optionTemplateId2, param2);
							Char.M113().arrItemBag[m].M798();
						}
					}
					if (Char.M113().arrItemBag[m].template.type == 6)
					{
						GameScr.hpPotion += Char.M113().arrItemBag[m].quantity;
					}
				}
				Char.M113().arrItemBox = new Item[msg.M887().M1088()];
				GameCanvas.panel.hasUse = 0;
				for (int num5 = 0; num5 < Char.M113().arrItemBox.Length; num5++)
				{
					short num6 = msg.M887().M1092();
					if (num6 != -1)
					{
						Char.M113().arrItemBox[num5] = new Item();
						Char.M113().arrItemBox[num5].template = ItemTemplates.M834(num6);
						Char.M113().arrItemBox[num5].quantity = msg.M887().M1094();
						Char.M113().arrItemBox[num5].info = msg.M887().M1100();
						Char.M113().arrItemBox[num5].content = msg.M887().M1100();
						Char.M113().arrItemBox[num5].itemOption = new ItemOption[msg.M887().M1088()];
						for (int num7 = 0; num7 < Char.M113().arrItemBox[num5].itemOption.Length; num7++)
						{
							int optionTemplateId3 = msg.M887().M1091();
							ushort param3 = msg.M887().M1093();
							Char.M113().arrItemBox[num5].itemOption[num7] = new ItemOption(optionTemplateId3, param3);
							Char.M113().arrItemBox[num5].M798();
						}
						GameCanvas.panel.hasUse++;
					}
				}
				Char.M113().statusMe = 4;
				if (Rms.M1542(Char.M113().cName + "vci") < 1)
				{
					GameScr.isViewClanInvite = false;
				}
				else
				{
					GameScr.isViewClanInvite = true;
				}
				short num8 = msg.M887().M1092();
				Char.idHead = new short[num8];
				Char.idAvatar = new short[num8];
				for (int num9 = 0; num9 < num8; num9++)
				{
					Char.idHead[num9] = msg.M887().M1092();
					Char.idAvatar[num9] = msg.M887().M1092();
				}
				for (int num10 = 0; num10 < GameScr.info1.charId.Length; num10++)
				{
					GameScr.info1.charId[num10] = new int[3];
				}
				GameScr.info1.charId[Char.M113().cgender][0] = msg.M887().M1092();
				GameScr.info1.charId[Char.M113().cgender][1] = msg.M887().M1092();
				GameScr.info1.charId[Char.M113().cgender][2] = msg.M887().M1092();
				Char.M113().isNhapThe = msg.M887().M1088() == 1;
				Res.M1513("NHAP THE= " + Char.M113().isNhapThe);
				GameScr.deltaTime = mSystem.M1054() - msg.M887().M1094() * 1000L;
				GameScr.isNewMember = msg.M887().M1088();
				Service.M1594().M1624((sbyte)Char.M113().cgender);
				Service.M1594().M1596();
				try
				{
					Char.M113().idAuraEff = msg.M887().M1092();
					Char.M113().idEff_Set_Item = msg.M887().M1086();
					Char.M113().idHat = msg.M887().M1092();
					break;
				}
				catch (Exception)
				{
					break;
				}
			}
			case 1:
				GameCanvas.M456("SA13", 2);
				Char.M113().nClass = GameScr.nClasss[msg.M887().M1088()];
				Char.M113().cTiemNang = msg.M887().M1095();
				Char.M113().vSkill.M1120();
				Char.M113().vSkillFight.M1120();
				Char.M113().myskill = null;
				break;
			case 2:
			{
				GameCanvas.M456("SA14", 2);
				if (Char.M113().statusMe != 14 && Char.M113().statusMe != 5)
				{
					Char.M113().cHP = Char.M113().cHPFull;
					Char.M113().cMP = Char.M113().cMPFull;
					Cout.M329(" ME_LOAD_SKILL");
				}
				Char.M113().vSkill.M1120();
				Char.M113().vSkillFight.M1120();
				sbyte b4 = msg.M887().M1088();
				for (sbyte b5 = 0; b5 < b4; b5++)
				{
					M316(Skills.M1773(msg.M887().M1092()));
				}
				GameScr.M559().M604();
				if (GameScr.isPaintInfoMe)
				{
					GameScr.indexRow = -1;
					GameScr.M559().left = (GameScr.M559().center = null);
				}
				break;
			}
			case 4:
				GameCanvas.M456("SA23", 2);
				Char.M113().xu = msg.M887().M1095();
				Char.M113().luong = msg.M887().M1094();
				Char.M113().cHP = msg.M889();
				Char.M113().cMP = msg.M889();
				Char.M113().luongKhoa = msg.M887().M1094();
				Char.M113().xuStr = mSystem.M1042(Char.M113().xu);
				Char.M113().luongStr = mSystem.M1042(Char.M113().luong);
				Char.M113().luongKhoaStr = mSystem.M1042(Char.M113().luongKhoa);
				break;
			case 5:
			{
				GameCanvas.M456("SA24", 2);
				int cHP = Char.M113().cHP;
				Char.M113().cHP = msg.M889();
				if (Char.M113().cHP > cHP && Char.M113().cTypePk != 4)
				{
					GameScr.M643("+" + (Char.M113().cHP - cHP) + " " + mResources.HP, Char.M113().cx, Char.M113().cy - Char.M113().ch - 20, 0, -1, mFont.HP);
					SoundMn.M1826().M1830();
					if (Char.M113().petFollow != null && Char.M113().petFollow.smallID == 5003)
					{
						MonsterDart.M1017(Char.M113().petFollow.cmx + ((Char.M113().petFollow.dir != 1) ? (-10) : 10), Char.M113().petFollow.cmy + 10, isBoss: true, -1, -1, Char.M113(), 29);
					}
				}
				if (Char.M113().cHP < cHP)
				{
					GameScr.M643("-" + (cHP - Char.M113().cHP) + " " + mResources.HP, Char.M113().cx, Char.M113().cy - Char.M113().ch - 20, 0, -1, mFont.HP);
				}
				GameScr.M559().dHP = Char.M113().cHP;
				if (!GameScr.isPaintInfoMe)
				{
				}
				break;
			}
			case 6:
			{
				GameCanvas.M456("SA25", 2);
				if (Char.M113().statusMe == 14 || Char.M113().statusMe == 5)
				{
					break;
				}
				int cMP = Char.M113().cMP;
				Char.M113().cMP = msg.M889();
				if (Char.M113().cMP > cMP)
				{
					GameScr.M643("+" + (Char.M113().cMP - cMP) + " " + mResources.KI, Char.M113().cx, Char.M113().cy - Char.M113().ch - 23, 0, -2, mFont.MP);
					SoundMn.M1826().M1830();
					if (Char.M113().petFollow != null && Char.M113().petFollow.smallID == 5001)
					{
						MonsterDart.M1017(Char.M113().petFollow.cmx + ((Char.M113().petFollow.dir != 1) ? (-10) : 10), Char.M113().petFollow.cmy + 10, isBoss: true, -1, -1, Char.M113(), 29);
					}
				}
				if (Char.M113().cMP < cMP)
				{
					GameScr.M643("-" + (cMP - Char.M113().cMP) + " " + mResources.KI, Char.M113().cx, Char.M113().cy - Char.M113().ch - 23, 0, -2, mFont.MP);
				}
				Res.M1513("curr MP= " + Char.M113().cMP);
				GameScr.M559().dMP = Char.M113().cMP;
				if (!GameScr.isPaintInfoMe)
				{
				}
				break;
			}
			case 7:
			{
				Char t5 = GameScr.M626(msg.M887().M1094());
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
				GameCanvas.M456("SA26", 2);
				Char t11 = GameScr.M626(msg.M887().M1094());
				if (t11 != null)
				{
					t11.cspeed = msg.M887().M1088();
				}
				break;
			}
			case 9:
			{
				GameCanvas.M456("SA27", 2);
				Char t14 = GameScr.M626(msg.M887().M1094());
				if (t14 != null)
				{
					t14.cHP = msg.M889();
					t14.cHPFull = msg.M889();
				}
				break;
			}
			case 10:
			{
				GameCanvas.M456("SA28", 2);
				Char t12 = GameScr.M626(msg.M887().M1094());
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
				GameCanvas.M456("SA29", 2);
				Char t10 = GameScr.M626(msg.M887().M1094());
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
				GameCanvas.M456("SA30", 2);
				Char t6 = GameScr.M626(msg.M887().M1094());
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
				GameCanvas.M456("SA31", 2);
				Char t7 = GameScr.M626(msg.M887().M1094());
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
				GameCanvas.M456("SA32", 2);
				Char t3 = GameScr.M626(msg.M887().M1094());
				if (t3 != null)
				{
					t3.cHP = msg.M889();
					sbyte b2 = msg.M887().M1088();
					Res.M1513("player load hp type= " + b2);
					if (b2 == 1)
					{
						ServerEffect.M1574(11, t3, 5);
						ServerEffect.M1574(104, t3, 4);
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
				GameCanvas.M456("SA33", 2);
				Char t15 = GameScr.M626(msg.M887().M1094());
				if (t15 != null)
				{
					t15.cHP = msg.M889();
					t15.cHPFull = msg.M889();
					t15.cx = msg.M887().M1092();
					t15.cy = msg.M887().M1092();
					t15.statusMe = 1;
					t15.cp3 = 3;
					ServerEffect.M1574(109, t15, 2);
				}
				break;
			}
			case 19:
				GameCanvas.M456("SA17", 2);
				Char.M113().M117();
				break;
			case 21:
			{
				GameCanvas.M456("SA19", 2);
				int num16 = msg.M887().M1094();
				Char.M113().xuInBox -= num16;
				Char.M113().xu += num16;
				Char.M113().xuStr = mSystem.M1042(Char.M113().xu);
				break;
			}
			case 23:
			{
				short num15 = msg.M887().M1092();
				Skill t13 = Skills.M1773(num15);
				M316(t13);
				if (num15 != 0 && num15 != 14 && num15 != 28)
				{
					GameScr.info1.M762(mResources.LEARN_SKILL + " " + t13.template.name, 0);
				}
				break;
			}
			case 35:
			{
				GameCanvas.M456("SY3", 2);
				int num = msg.M887().M1094();
				Res.M1513("CID = " + num);
				if (TileMap.mapID == 130)
				{
					GameScr.M559().M636();
				}
				if (num == Char.M113().charID)
				{
					Char.M113().cTypePk = msg.M887().M1088();
					if (GameScr.M559().M640() && Char.M113().cTypePk != 0)
					{
						GameScr.M559().M636();
					}
					Res.M1513("type pk= " + Char.M113().cTypePk);
					Char.M113().npcFocus = null;
					if (!GameScr.M559().M571(Char.M113().mobFocus))
					{
						Char.M113().mobFocus = null;
					}
					Char.M113().itemFocus = null;
				}
				else
				{
					Char t = GameScr.M626(num);
					if (t != null)
					{
						Res.M1513("type pk= " + t.cTypePk);
						t.cTypePk = msg.M887().M1088();
						if (t.M209())
						{
							Char.M113().charFocus = t;
						}
					}
				}
				for (int i = 0; i < GameScr.vCharInMap.M1113(); i++)
				{
					Char t2 = GameScr.M626(i);
					if (t2 != null && t2.cTypePk != 0 && t2.cTypePk == Char.M113().cTypePk)
					{
						if (!Char.M113().mobFocus.isMobMe)
						{
							Char.M113().mobFocus = null;
						}
						Char.M113().npcFocus = null;
						Char.M113().itemFocus = null;
						break;
					}
				}
				Res.M1513("update type pk= ");
				break;
			}
			}
		}
		catch (Exception ex5)
		{
			Cout.M326("Loi tai Sub : " + ex5.ToString());
		}
		finally
		{
			msg?.M890();
		}
	}

	private void M316(Skill skill)
	{
		if (Char.M113().myskill == null)
		{
			Char.M113().myskill = skill;
		}
		else if (skill.template.Equals(Char.M113().myskill.template))
		{
			Char.M113().myskill = skill;
		}
		Char.M113().vSkill.M1111(skill);
		if ((skill.template.type == 1 || skill.template.type == 4 || skill.template.type == 2 || skill.template.type == 3) && (skill.template.maxPoint == 0 || (skill.template.maxPoint > 0 && skill.point > 0)))
		{
			if (skill.template.id == Char.M113().skillTemplateId)
			{
				Service.M1594().M1652(Char.M113().skillTemplateId);
			}
			Char.M113().vSkillFight.M1111(skill);
		}
	}

	public bool M317(Char c, Message msg)
	{
		try
		{
			c.clevel = msg.M887().M1088();
			c.isInvisiblez = msg.M887().M1097();
			c.cTypePk = msg.M887().M1088();
			Res.M1513("ADD TYPE PK= " + c.cTypePk + " to player " + c.charID + " @@ " + c.cName);
			c.nClass = GameScr.nClasss[msg.M887().M1088()];
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
			if (c.cy >= TileMap.pxh - 100)
			{
				c.isFlyUp = true;
			}
			c.body = msg.M887().M1092();
			c.leg = msg.M887().M1092();
			c.bag = msg.M887().M1091();
			Res.M1513(" body= " + c.body + " leg= " + c.leg + " bag=" + c.bag + "BAG ==" + c.bag + "*********************************");
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
				EffectChar t = new EffectChar(msg.M887().M1088(), msg.M887().M1094(), msg.M887().M1094(), msg.M887().M1092());
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

	private void M318(Message msg)
	{
		try
		{
			string text = msg.M887().M1100();
			sbyte nFrame = msg.M887().M1088();
			sbyte[] array = null;
			array = NinjaUtil.M1185(msg);
			ImageByName.M735(text, M307(array), nFrame);
			if (array != null)
			{
				ImageByName.M738(text, nFrame, array);
			}
		}
		catch (Exception)
		{
		}
	}

	private void M319(myReader d)
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

	private void M320(myReader d, sbyte type, bool isSave)
	{
		try
		{
			d.M1089(100000);
			GameScr.vcItem = d.M1088();
			type = d.M1088();
			switch (type)
			{
			case 100:
				Char.Arr_Head_2Fr = M322(d);
				if (isSave)
				{
					d.M1090();
					sbyte[] data4 = new sbyte[d.M1104()];
					d.M1103(ref data4);
					Rms.M1534("NRitem100", data4);
				}
				break;
			case 0:
			{
				GameScr.M559().iOptionTemplates = new ItemOptionTemplate[d.M1091()];
				for (int j = 0; j < GameScr.M559().iOptionTemplates.Length; j++)
				{
					GameScr.M559().iOptionTemplates[j] = new ItemOptionTemplate();
					GameScr.M559().iOptionTemplates[j].id = j;
					GameScr.M559().iOptionTemplates[j].name = d.M1100();
					GameScr.M559().iOptionTemplates[j].type = d.M1088();
				}
				if (isSave)
				{
					d.M1090();
					sbyte[] data2 = new sbyte[d.M1104()];
					d.M1103(ref data2);
					Rms.M1534("NRitem0", data2);
				}
				break;
			}
			case 1:
			{
				ItemTemplates.itemTemplates.M1075();
				int num3 = d.M1092();
				for (int k = 0; k < num3; k++)
				{
					ItemTemplates.M833(new ItemTemplate((short)k, d.M1088(), d.M1088(), d.M1100(), d.M1100(), d.M1088(), d.M1094(), d.M1092(), d.M1092(), d.M1097()));
				}
				if (isSave)
				{
					d.M1090();
					sbyte[] data3 = new sbyte[d.M1104()];
					d.M1103(ref data3);
					Rms.M1534("NRitem1", data3);
				}
				break;
			}
			case 2:
			{
				short num = d.M1092();
				int num2 = d.M1092();
				for (int i = num; i < num2; i++)
				{
					ItemTemplates.M833(new ItemTemplate((short)i, d.M1088(), d.M1088(), d.M1100(), d.M1100(), d.M1088(), d.M1094(), d.M1092(), d.M1092(), d.M1097()));
				}
				if (isSave)
				{
					d.M1090();
					sbyte[] data = new sbyte[d.M1104()];
					d.M1103(ref data);
					Rms.M1534("NRitem2", data);
					Rms.M1534("NRitemVersion", new sbyte[1] { GameScr.vcItem });
					LoginScr.isUpdateItem = false;
					if (GameScr.vsData == GameScr.vcData && GameScr.vsMap == GameScr.vcMap && GameScr.vsSkill == GameScr.vcSkill && GameScr.vsItem == GameScr.vcItem)
					{
						GameScr.M559().M557();
						GameScr.M559().M555();
						GameScr.M559().M556();
						GameScr.M559().M558();
						Service.M1594().M1679();
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

	private void M321(Message msg, int mobTemplateId)
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

	private int[][] M322(myReader d)
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

	public void M323(Message msg)
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

	private void M324(Message msg, int type_PB)
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
				GameScr.phuban_Info = new InfoPhuBan(type_PB, idmapPaint, nameTeam, nameTeam2, maxPoint, timeSecond2);
				GameScr.phuban_Info.maxLife = maxLife;
				GameScr.phuban_Info.M765(type_PB, 0, 0);
				break;
			}
			case 1:
			{
				int pointTeam = msg.M887().M1094();
				int pointTeam2 = msg.M887().M1094();
				if (GameScr.phuban_Info != null)
				{
					GameScr.phuban_Info.M764(type_PB, pointTeam, pointTeam2);
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
				GameScr.phuban_Info = null;
				GameScr.M688(type, -1, GameCanvas.hw, GameCanvas.hh, 0, 0);
				break;
			}
			case 4:
			{
				int lifeTeam = msg.M887().M1088();
				int lifeTeam2 = msg.M887().M1088();
				if (GameScr.phuban_Info != null)
				{
					GameScr.phuban_Info.M765(type_PB, lifeTeam, lifeTeam2);
				}
				break;
			}
			case 5:
			{
				short timeSecond = msg.M887().M1092();
				if (GameScr.phuban_Info != null)
				{
					GameScr.phuban_Info.M763(type_PB, timeSecond);
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

	public void M325(Message msg)
	{
		try
		{
			if (msg.M887().M1088() == 0)
			{
				short idHat = msg.M887().M1092();
				Char.M113().idHat = idHat;
				SoundMn.M1826().M1829();
			}
		}
		catch (Exception)
		{
		}
	}
}
