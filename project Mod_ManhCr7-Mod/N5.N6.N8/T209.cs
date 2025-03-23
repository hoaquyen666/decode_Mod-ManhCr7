using System;
using N5.N6.N7;

namespace N5.N6.N8;

internal class T209
{
	public static void M2308(T97 msg)
	{
		try
		{
			T137.M1513("cmd=" + msg.command);
			switch (msg.command)
			{
			case 42:
			{
				T51.M488();
				T90.isContinueToLogin = false;
				T13.isLoadingMap = false;
				sbyte haveName = msg.M887().M1088();
				if (T51.registerScr == null)
				{
					T51.registerScr = new T208(haveName);
				}
				T51.registerScr.M2290();
				break;
			}
			case 31:
			{
				int num36 = msg.M887().M1094();
				if (msg.M887().M1088() == 1)
				{
					short smallID = msg.M887().M1092();
					sbyte b26 = -1;
					int[] array11 = null;
					short wimg = 0;
					short himg = 0;
					try
					{
						b26 = msg.M887().M1088();
						if (b26 > 0)
						{
							sbyte b27 = msg.M887().M1088();
							array11 = new int[b27];
							for (int num37 = 0; num37 < b27; num37++)
							{
								array11[num37] = msg.M887().M1088();
							}
							wimg = msg.M887().M1092();
							himg = msg.M887().M1092();
						}
					}
					catch (Exception)
					{
					}
					if (num36 == T13.M113().charID)
					{
						T13.M113().petFollow = new T207();
						T13.M113().petFollow.smallID = smallID;
						if (b26 > 0)
						{
							T13.M113().petFollow.M2285(b26, array11, wimg, himg);
						}
						break;
					}
					T13 t13 = T54.M626(num36);
					t13.petFollow = new T207();
					t13.petFollow.smallID = smallID;
					if (b26 > 0)
					{
						t13.petFollow.M2285(b26, array11, wimg, himg);
					}
				}
				else if (num36 == T13.M113().charID)
				{
					T13.M113().petFollow.M2288();
					T13.M113().petFollow = null;
				}
				else
				{
					T13 t14 = T54.M626(num36);
					t14.petFollow.M2288();
					t14.petFollow = null;
				}
				break;
			}
			case sbyte.MinValue:
				M2311(msg);
				break;
			case -127:
				M2309(msg);
				break;
			case -126:
			{
				sbyte b11 = msg.M887().M1088();
				T137.M1513("type quay= " + b11);
				if (b11 == 1)
				{
					msg.M887().M1088();
					string num7 = msg.M887().M1100();
					string finish = msg.M887().M1100();
					T54.M559().M676(num7, finish);
				}
				if (b11 == 0)
				{
					T54.M559().M681(msg.M887().M1100());
				}
				break;
			}
			case -125:
			{
				T15.M279().isShow = false;
				string text = msg.M887().M1100();
				T137.M1513("titile= " + text);
				sbyte b7 = msg.M887().M1088();
				T203.M2272().M2273(b7, text);
				for (int l = 0; l < b7; l++)
				{
					T203.M2272().tf[l].name = msg.M887().M1100();
					sbyte b8 = msg.M887().M1088();
					if (b8 == 0)
					{
						T203.M2272().tf[l].M1931(T173.INPUT_TYPE_NUMERIC);
					}
					if (b8 == 1)
					{
						T203.M2272().tf[l].M1931(T173.INPUT_TYPE_ANY);
					}
					if (b8 == 2)
					{
						T203.M2272().tf[l].M1931(T173.INPUT_TYPE_PASSWORD);
					}
				}
				break;
			}
			case -124:
			{
				sbyte b18 = msg.M887().M1088();
				sbyte b19 = msg.M887().M1088();
				if (b19 == 0)
				{
					if (b18 == 2)
					{
						int num18 = msg.M887().M1094();
						if (num18 == T13.M113().charID)
						{
							T13.M113().M236();
						}
						else if (T54.M626(num18) != null)
						{
							T54.M626(num18).M236();
						}
					}
					int num19 = msg.M887().M1091();
					int num20 = msg.M887().M1094();
					if (num19 == 32)
					{
						if (b18 == 1)
						{
							int num21 = msg.M887().M1094();
							if (num20 == T13.M113().charID)
							{
								T13.M113().holdEffID = num19;
								T54.M626(num21).M210(T13.M113());
							}
							else if (T54.M626(num20) != null && num21 != T13.M113().charID)
							{
								T54.M626(num20).holdEffID = num19;
								T54.M626(num21).M210(T54.M626(num20));
							}
							else if (T54.M626(num20) != null && num21 == T13.M113().charID)
							{
								T54.M626(num20).holdEffID = num19;
								T13.M113().M210(T54.M626(num20));
							}
						}
						else if (num20 == T13.M113().charID)
						{
							T13.M113().M233();
						}
						else if (T54.M626(num20) != null)
						{
							T54.M626(num20).M233();
						}
					}
					if (num19 == 33)
					{
						if (b18 == 1)
						{
							if (num20 == T13.M113().charID)
							{
								T13.M113().protectEff = true;
							}
							else if (T54.M626(num20) != null)
							{
								T54.M626(num20).protectEff = true;
							}
						}
						else if (num20 == T13.M113().charID)
						{
							T13.M113().M234();
						}
						else if (T54.M626(num20) != null)
						{
							T54.M626(num20).M234();
						}
					}
					if (num19 == 39)
					{
						if (b18 == 1)
						{
							if (num20 == T13.M113().charID)
							{
								T13.M113().huytSao = true;
							}
							else if (T54.M626(num20) != null)
							{
								T54.M626(num20).huytSao = true;
							}
						}
						else if (num20 == T13.M113().charID)
						{
							T13.M113().M238();
						}
						else if (T54.M626(num20) != null)
						{
							T54.M626(num20).M238();
						}
					}
					if (num19 == 40)
					{
						if (b18 == 1)
						{
							if (num20 == T13.M113().charID)
							{
								T13.M113().blindEff = true;
							}
							else if (T54.M626(num20) != null)
							{
								T54.M626(num20).blindEff = true;
							}
						}
						else if (num20 == T13.M113().charID)
						{
							T13.M113().M235();
						}
						else if (T54.M626(num20) != null)
						{
							T54.M626(num20).M235();
						}
					}
					if (num19 == 41)
					{
						if (b18 == 1)
						{
							if (num20 == T13.M113().charID)
							{
								T13.M113().sleepEff = true;
							}
							else if (T54.M626(num20) != null)
							{
								T54.M626(num20).sleepEff = true;
							}
						}
						else if (num20 == T13.M113().charID)
						{
							T13.M113().M241();
						}
						else if (T54.M626(num20) != null)
						{
							T54.M626(num20).M241();
						}
					}
					if (num19 == 42)
					{
						if (b18 == 1)
						{
							if (num20 == T13.M113().charID)
							{
								T13.M113().stone = true;
							}
						}
						else if (num20 == T13.M113().charID)
						{
							T13.M113().stone = false;
						}
					}
				}
				if (b19 != 1)
				{
					break;
				}
				int num22 = msg.M887().M1091();
				sbyte mobIndex = msg.M887().M1088();
				T137.M1513("modbHoldID= " + mobIndex + " skillID= " + num22 + "eff ID= " + b18);
				if (num22 == 32)
				{
					if (b18 == 1)
					{
						int num23 = msg.M887().M1094();
						if (num23 == T13.M113().charID)
						{
							T54.M627(mobIndex).holdEffID = num22;
							T13.M113().M211(T54.M627(mobIndex));
						}
						else if (T54.M626(num23) != null)
						{
							T54.M627(mobIndex).holdEffID = num22;
							T54.M626(num23).M211(T54.M627(mobIndex));
						}
					}
					else
					{
						T54.M627(mobIndex).M1005();
					}
				}
				if (num22 == 40)
				{
					if (b18 == 1)
					{
						T54.M627(mobIndex).blindEff = true;
					}
					else
					{
						T54.M627(mobIndex).M1006();
					}
				}
				if (num22 == 41)
				{
					if (b18 == 1)
					{
						T54.M627(mobIndex).sleepEff = true;
					}
					else
					{
						T54.M627(mobIndex).M1007();
					}
				}
				break;
			}
			case -123:
			{
				int charId = msg.M887().M1094();
				if (T54.M626(charId) != null)
				{
					T54.M626(charId).perCentMp = msg.M887().M1088();
				}
				break;
			}
			case -122:
			{
				T123 t4 = T54.M625(msg.M887().M1092());
				sbyte b9 = msg.M887().M1088();
				t4.duahau = new int[b9];
				T137.M1513("N DUA HAU= " + b9);
				for (int m = 0; m < b9; m++)
				{
					t4.duahau[m] = msg.M887().M1092();
				}
				t4.M1195(msg.M887().M1088(), msg.M887().M1094());
				break;
			}
			case -121:
				T146.logMap = T110.M1054() - T146.curCheckMap;
				T146.M1594().M1633();
				break;
			case -120:
				T146.logController = T110.M1054() - T146.curCheckController;
				T146.M1594().M1632();
				break;
			case -119:
				T13.M113().rank = msg.M887().M1094();
				break;
			case -117:
				T54.M559().tMabuEff = 0;
				T54.M559().percentMabu = msg.M887().M1088();
				if (T54.M559().percentMabu == 100)
				{
					T54.M559().mabuEff = true;
				}
				if (T54.M559().percentMabu == 101)
				{
					T123.mabuEff = true;
				}
				break;
			case -116:
				T54.canAutoPlay = msg.M887().M1088() == 1;
				break;
			case -115:
				T13.M113().M110(msg.M887().M1100(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1092());
				break;
			case -113:
			{
				sbyte[] array10 = new sbyte[10];
				for (int num26 = 0; num26 < 10; num26++)
				{
					array10[num26] = msg.M887().M1088();
					T137.M1513("vlue i= " + array10[num26]);
				}
				T54.M559().M541(array10);
				T54.M559().M540(array10);
				T54.M559().M542(array10);
				break;
			}
			case -111:
			{
				short num5 = msg.M887().M1092();
				T205.vSource = new T117();
				for (int num6 = 0; num6 < num5; num6++)
				{
					string iD = msg.M887().M1100();
					sbyte version = msg.M887().M1088();
					T205.vSource.M1111(new T205(iD, version));
				}
				T205.M2275();
				T205.M2279();
				break;
			}
			case -110:
			{
				sbyte b12 = msg.M887().M1088();
				if (b12 == 1)
				{
					int id2 = msg.M887().M1094();
					sbyte[] array7 = T138.M1535(id2 + string.Empty);
					if (array7 == null)
					{
						T146.M1594().M1733(1, -1, null);
					}
					else
					{
						T146.M1594().M1733(1, id2, array7);
					}
				}
				if (b12 == 0)
				{
					int num8 = msg.M887().M1094();
					short num9 = msg.M887().M1092();
					sbyte[] data = new sbyte[num9];
					msg.M887().M1109(ref data, 0, num9);
					T138.M1534(num8 + string.Empty, data);
				}
				break;
			}
			case -106:
			{
				short num34 = msg.M887().M1092();
				int num35 = msg.M887().M1092();
				if (T86.M839(num34))
				{
					T86.M842(num34).M843(num35);
					break;
				}
				T86 o = new T86(num34, num35);
				T13.vItemTime.M1111(o);
				break;
			}
			case -105:
				T179.M1969().time = 0;
				T179.M1969().maxTime = msg.M887().M1092();
				T179.M1969().last = (T179.M1969().curr = T110.M1054());
				T179.M1969().type = msg.M887().M1088();
				T179.M1969().switchToMe();
				break;
			case -103:
				switch (msg.M887().M1088())
				{
				case 0:
				{
					T51.panel.vFlag.M1120();
					sbyte b23 = msg.M887().M1088();
					for (int num30 = 0; num30 < b23; num30++)
					{
						T79 t12 = new T79();
						short num31 = msg.M887().M1092();
						if (num31 != -1)
						{
							t12.template = T85.M834(num31);
							sbyte b24 = msg.M887().M1088();
							if (b24 != -1)
							{
								t12.itemOption = new T82[b24];
								for (int num32 = 0; num32 < t12.itemOption.Length; num32++)
								{
									int optionTemplateId3 = msg.M887().M1091();
									ushort param3 = msg.M887().M1093();
									t12.itemOption[num32] = new T82(optionTemplateId3, param3);
								}
							}
						}
						T51.panel.vFlag.M1111(t12);
					}
					T51.panel.M1257();
					T51.panel.M1285();
					break;
				}
				case 1:
				{
					int num33 = msg.M887().M1094();
					sbyte b25 = msg.M887().M1088();
					T137.M1513("---------------actionFlag1:  " + num33 + " : " + b25);
					if (num33 == T13.M113().charID)
					{
						T13.M113().cFlag = b25;
					}
					else if (T54.M626(num33) != null)
					{
						T54.M626(num33).cFlag = b25;
					}
					T54.M559().M671(num33, b25);
					break;
				}
				case 2:
				{
					sbyte b22 = msg.M887().M1088();
					int num27 = msg.M887().M1092();
					T129 t9 = new T129();
					t9.cflag = b22;
					t9.IDimageFlag = num27;
					T54.vFlag.M1111(t9);
					for (int num28 = 0; num28 < T54.vFlag.M1113(); num28++)
					{
						T129 t10 = (T129)T54.vFlag.M1114(num28);
						T137.M1513("i: " + num28 + "  cflag: " + t10.cflag + "   IDimageFlag: " + t10.IDimageFlag);
					}
					for (int num29 = 0; num29 < T54.vCharInMap.M1113(); num29++)
					{
						T13 t11 = (T13)T54.vCharInMap.M1114(num29);
						if (t11 != null && t11.cFlag == b22)
						{
							t11.flagImage = num27;
						}
					}
					if (T13.M113().cFlag == b22)
					{
						T13.M113().flagImage = num27;
					}
					break;
				}
				}
				break;
			case -102:
			{
				sbyte b20 = msg.M887().M1088();
				if (b20 != 0 && b20 == 1)
				{
					T51.loginScr.isLogin2 = false;
					T146.M1594().M1634(T138.M1536("acc"), T138.M1536("pass"), T52.VERSION, 0);
					T90.isLoggingIn = true;
				}
				break;
			}
			case -101:
			{
				T51.loginScr.isLogin2 = true;
				T51.M449();
				string text3 = msg.M887().M1100();
				T138.M1538("userAo" + T144.ipSelect, text3);
				T146.M1594().M1630();
				T146.M1594().M1634(text3, string.Empty, T52.VERSION, 1);
				break;
			}
			case -100:
			{
				T66.M753();
				bool flag = false;
				if (T51.w > 2 * T126.WIDTH_PANEL)
				{
					flag = true;
				}
				sbyte b13 = msg.M887().M1088();
				T137.M1513("t Indxe= " + b13);
				T51.panel.maxPageShop[b13] = msg.M887().M1088();
				T51.panel.currPageShop[b13] = msg.M887().M1088();
				T137.M1513("max page= " + T51.panel.maxPageShop[b13] + " curr page= " + T51.panel.currPageShop[b13]);
				int num11 = msg.M887().M1091();
				T13.M113().arrItemShop[b13] = new T79[num11];
				for (int num12 = 0; num12 < num11; num12++)
				{
					short num13 = msg.M887().M1092();
					if (num13 == -1)
					{
						continue;
					}
					T137.M1513("template id= " + num13);
					T13.M113().arrItemShop[b13][num12] = new T79();
					T13.M113().arrItemShop[b13][num12].template = T85.M834(num13);
					T13.M113().arrItemShop[b13][num12].itemId = msg.M887().M1092();
					T13.M113().arrItemShop[b13][num12].buyCoin = msg.M887().M1094();
					T13.M113().arrItemShop[b13][num12].buyGold = msg.M887().M1094();
					T13.M113().arrItemShop[b13][num12].buyType = msg.M887().M1088();
					T13.M113().arrItemShop[b13][num12].quantity = msg.M887().M1094();
					T13.M113().arrItemShop[b13][num12].isMe = msg.M887().M1088();
					T126.strWantToBuy = mResources.say_wat_do_u_want_to_buy;
					sbyte b14 = msg.M887().M1088();
					if (b14 != -1)
					{
						T13.M113().arrItemShop[b13][num12].itemOption = new T82[b14];
						for (int num14 = 0; num14 < T13.M113().arrItemShop[b13][num12].itemOption.Length; num14++)
						{
							int optionTemplateId2 = msg.M887().M1091();
							ushort param2 = msg.M887().M1093();
							T13.M113().arrItemShop[b13][num12].itemOption[num14] = new T82(optionTemplateId2, param2);
							T13.M113().arrItemShop[b13][num12].compare = T51.panel.M1365(T13.M113().arrItemShop[b13][num12]);
						}
					}
					if (msg.M887().M1088() == 1)
					{
						int headTemp = msg.M887().M1092();
						int bodyTemp = msg.M887().M1092();
						int legTemp = msg.M887().M1092();
						short bagTemp = msg.M887().M1092();
						T13.M113().arrItemShop[b13][num12].M817(headTemp, bodyTemp, legTemp, bagTemp);
					}
				}
				if (flag)
				{
					T51.panel2.M1252();
				}
				T51.panel.M1317();
				T126 panel = T51.panel;
				T51.panel.cmtoY = 0;
				panel.cmy = 0;
				break;
			}
			case -89:
				T51.open3Hour = msg.M887().M1088() == 1;
				break;
			case 93:
			{
				string chatVip = T137.M1518(msg.M887().M1100());
				T54.M559().M677(chatVip);
				break;
			}
			case 48:
				T144.ipSelect = msg.M887().M1088();
				T51.instance.M457(T51.serverScreen);
				T147.M1744().close();
				T51.M488();
				T144.waitToLogin = true;
				break;
			case 51:
			{
				T206 t5 = (T206)T54.M626(msg.M887().M1094());
				sbyte id = msg.M887().M1088();
				short x = msg.M887().M1092();
				short y = msg.M887().M1092();
				sbyte b10 = msg.M887().M1088();
				T13[] array5 = new T13[b10];
				int[] array6 = new int[b10];
				for (int n = 0; n < b10; n++)
				{
					int num4 = msg.M887().M1094();
					T137.M1513("char ID=" + num4);
					array5[n] = null;
					if (num4 != T13.M113().charID)
					{
						array5[n] = T54.M626(num4);
					}
					else
					{
						array5[n] = T13.M113();
					}
					array6[n] = msg.M887().M1094();
				}
				t5.M2283(id, x, y, array5, array6);
				break;
			}
			case 52:
			{
				sbyte b21 = msg.M887().M1088();
				if (b21 == 1)
				{
					int num24 = msg.M887().M1094();
					if (num24 == T13.M113().charID)
					{
						T13.M113().M183(m: true);
						T13.M113().cx = msg.M887().M1092();
						T13.M113().cy = msg.M887().M1092();
					}
					else
					{
						T13 t8 = T54.M626(num24);
						if (t8 != null)
						{
							t8.M183(m: true);
							t8.cx = msg.M887().M1092();
							t8.cy = msg.M887().M1092();
						}
					}
				}
				if (b21 == 0)
				{
					int num25 = msg.M887().M1094();
					if (num25 == T13.M113().charID)
					{
						T13.M113().M183(m: false);
					}
					else
					{
						T54.M626(num25)?.M183(m: false);
					}
				}
				if (b21 == 2)
				{
					int charId2 = msg.M887().M1094();
					int id4 = msg.M887().M1094();
					((T206)T54.M626(charId2)).M2280(id4);
				}
				if (b21 == 3)
				{
					T54.mabuPercent = msg.M887().M1088();
				}
				break;
			}
			case 113:
			{
				int loop = msg.M887().M1088();
				int layer = msg.M887().M1088();
				T31.M376(new T32(msg.M887().M1091(), msg.M887().M1092(), msg.M887().M1092(), layer, loop, msg.M887().M1092()));
				break;
			}
			case 114:
				try
				{
					msg.M887().M1100();
					T110.curINAPP = msg.M887().M1088();
					T110.maxINAPP = msg.M887().M1088();
					break;
				}
				catch (Exception)
				{
					break;
				}
			case 121:
				T110.publicID = msg.M887().M1100();
				T110.strAdmob = msg.M887().M1100();
				T137.M1513("SHOW AD public ID= " + T110.publicID);
				T110.M1049();
				break;
			case 122:
			{
				short timeLogin = msg.M887().M1092();
				T137.M1513("second login = " + timeLogin);
				T90.timeLogin = timeLogin;
				T90.currTimeLogin = (T90.lastTimeLogin = T110.M1054());
				T51.M488();
				break;
			}
			case 123:
			{
				T137.M1513("SET POSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSss");
				int num15 = msg.M887().M1094();
				short xPos = msg.M887().M1092();
				short yPos = msg.M887().M1092();
				sbyte b15 = msg.M887().M1088();
				T13 t6 = null;
				if (num15 == T13.M113().charID)
				{
					t6 = T13.M113();
				}
				else if (T54.M626(num15) != null)
				{
					t6 = T54.M626(num15);
				}
				if (t6 != null)
				{
					T143.M1574((b15 != 0) ? 173 : 60, t6, 1);
					t6.M237(xPos, yPos, b15);
				}
				break;
			}
			case 124:
			{
				short id3 = msg.M887().M1092();
				string text2 = msg.M887().M1100();
				T137.M1513("noi chuyen = " + text2 + "npc ID= " + id3);
				T54.M625(id3)?.M111(text2);
				break;
			}
			case 125:
			{
				sbyte fusion = msg.M887().M1088();
				int num10 = msg.M887().M1094();
				if (num10 == T13.M113().charID)
				{
					T13.M113().M240(fusion);
				}
				else if (T54.M626(num10) != null)
				{
					T54.M626(num10).M240(fusion);
				}
				break;
			}
			case sbyte.MaxValue:
				M2310(msg);
				break;
			case 100:
			{
				sbyte b4 = msg.M887().M1088();
				sbyte b5 = msg.M887().M1088();
				T79 t3 = null;
				if (b4 == 0)
				{
					t3 = T13.M113().arrItemBody[b5];
				}
				if (b4 == 1)
				{
					t3 = T13.M113().arrItemBag[b5];
				}
				short num3 = msg.M887().M1092();
				if (num3 == -1)
				{
					break;
				}
				t3.template = T85.M834(num3);
				t3.quantity = msg.M887().M1094();
				t3.info = msg.M887().M1100();
				t3.content = msg.M887().M1100();
				sbyte b6 = msg.M887().M1088();
				if (b6 != 0)
				{
					t3.itemOption = new T82[b6];
					for (int k = 0; k < t3.itemOption.Length; k++)
					{
						int optionTemplateId = msg.M887().M1091();
						T137.M1513("id o= " + optionTemplateId);
						ushort param = msg.M887().M1093();
						t3.itemOption[k] = new T82(optionTemplateId, param);
					}
				}
				break;
			}
			case 101:
			{
				T137.M1513("big boss--------------------------------------------------");
				T202 t7 = T101.M985();
				if (t7 == null)
				{
					break;
				}
				sbyte b16 = msg.M887().M1088();
				if (b16 == 0 || b16 == 1 || b16 == 2 || b16 == 4 || b16 == 3)
				{
					if (b16 == 3)
					{
						t7.xTo = (t7.xFirst = msg.M887().M1092());
						t7.yTo = (t7.yFirst = msg.M887().M1092());
						t7.M2258();
					}
					else
					{
						sbyte b17 = msg.M887().M1088();
						T137.M1513("CHUONG nChar= " + b17);
						T13[] array8 = new T13[b17];
						int[] array9 = new int[b17];
						for (int num16 = 0; num16 < b17; num16++)
						{
							int num17 = msg.M887().M1094();
							T137.M1513("char ID=" + num17);
							array8[num16] = null;
							if (num17 != T13.M113().charID)
							{
								array8[num16] = T54.M626(num17);
							}
							else
							{
								array8[num16] = T13.M113();
							}
							array9[num16] = msg.M887().M1094();
						}
						t7.M2259(array8, array9, b16);
					}
				}
				if (b16 == 5)
				{
					t7.haftBody = true;
					t7.status = 2;
				}
				if (b16 == 6)
				{
					t7.M2242();
					t7.x = msg.M887().M1092();
					t7.y = msg.M887().M1092();
				}
				if (b16 == 7)
				{
					t7.M2259(null, null, b16);
				}
				if (b16 == 8)
				{
					t7.xTo = (t7.xFirst = msg.M887().M1092());
					t7.yTo = (t7.yFirst = msg.M887().M1092());
					t7.status = 2;
				}
				if (b16 == 9)
				{
					t7.yFirst = -1000;
					t7.xFirst = -1000;
					t7.yTo = -1000;
					t7.xTo = -1000;
					t7.y = -1000;
					t7.x = -1000;
				}
				break;
			}
			case 102:
			{
				sbyte b = msg.M887().M1088();
				if (b == 0 || b == 1 || b == 2 || b == 6)
				{
					T12 t = T101.M986();
					if (t == null)
					{
						break;
					}
					if (b == 6)
					{
						t.yFirst = -1000;
						t.xFirst = -1000;
						t.yTo = -1000;
						t.xTo = -1000;
						t.y = -1000;
						t.x = -1000;
						break;
					}
					sbyte b2 = msg.M887().M1088();
					T13[] array = new T13[b2];
					int[] array2 = new int[b2];
					for (int i = 0; i < b2; i++)
					{
						int num = msg.M887().M1094();
						array[i] = null;
						if (num != T13.M113().charID)
						{
							array[i] = T54.M626(num);
						}
						else
						{
							array[i] = T13.M113();
						}
						array2[i] = msg.M887().M1094();
					}
					t.M91(array, array2, b);
				}
				if (b == 3 || b == 4 || b == 5 || b == 7)
				{
					T7 t2 = T101.M987();
					if (t2 == null)
					{
						break;
					}
					switch (b)
					{
					case 7:
						t2.yFirst = -1000;
						t2.xFirst = -1000;
						t2.yTo = -1000;
						t2.xTo = -1000;
						t2.y = -1000;
						t2.x = -1000;
						return;
					case 3:
					case 4:
					{
						sbyte b3 = msg.M887().M1088();
						T13[] array3 = new T13[b3];
						int[] array4 = new int[b3];
						for (int j = 0; j < b3; j++)
						{
							int num2 = msg.M887().M1094();
							array3[j] = null;
							if (num2 != T13.M113().charID)
							{
								array3[j] = T54.M626(num2);
							}
							else
							{
								array3[j] = T13.M113();
							}
							array4[j] = msg.M887().M1094();
						}
						t2.M26(array3, array4, b);
						break;
					}
					}
					if (b == 5)
					{
						t2.M38(msg.M887().M1092());
					}
				}
				if (b > 9 && b < 30)
				{
					M2312(msg, b);
				}
				break;
			}
			}
		}
		catch (Exception)
		{
		}
	}

	private static void M2309(T97 msg)
	{
		try
		{
			switch (msg.M887().M1088())
			{
			case 1:
			{
				sbyte b3 = msg.M887().M1088();
				short[] array2 = new short[b3];
				for (int j = 0; j < b3; j++)
				{
					array2[j] = msg.M887().M1092();
				}
				T25.M332().M340(array2);
				break;
			}
			case 0:
			{
				sbyte b = msg.M887().M1088();
				short[] array = new short[b];
				for (int i = 0; i < b; i++)
				{
					array[i] = msg.M887().M1092();
				}
				sbyte b2 = msg.M887().M1088();
				int price = msg.M887().M1094();
				short idTicket = msg.M887().M1092();
				T25.M332().M333(array, (byte)b2, price, idTicket);
				break;
			}
			}
		}
		catch (Exception)
		{
		}
	}

	private static void M2310(T97 msg)
	{
		try
		{
			switch (msg.M887().M1088())
			{
			case 0:
			{
				T136.M1494();
				T117 t2 = new T117(string.Empty);
				short num2 = msg.M887().M1092();
				int num3 = 0;
				for (int i = 0; i < num2; i++)
				{
					T70 t3 = new T70();
					int id = msg.M887().M1092();
					int no = i + 1;
					int idIcon = msg.M887().M1092();
					sbyte rank = msg.M887().M1088();
					sbyte amount = msg.M887().M1088();
					sbyte max_amount = msg.M887().M1088();
					short templateId = -1;
					T13 charInfo = null;
					sbyte b = msg.M887().M1088();
					if (b == 0)
					{
						templateId = msg.M887().M1092();
					}
					else
					{
						charInfo = T70.M770(msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1092(), msg.M887().M1092());
					}
					string name = msg.M887().M1100();
					string info = msg.M887().M1100();
					sbyte b2 = msg.M887().M1088();
					sbyte isUse = msg.M887().M1088();
					sbyte b3 = msg.M887().M1088();
					T82[] array = null;
					if (b3 != 0)
					{
						array = new T82[b3];
						for (int j = 0; j < array.Length; j++)
						{
							int optionTemplateId = msg.M887().M1091();
							int param = msg.M887().M1093();
							sbyte activeCard = msg.M887().M1088();
							array[j] = new T82(optionTemplateId, param);
							array[j].activeCard = activeCard;
						}
					}
					t3.M766(id, no, idIcon, rank, b, templateId, name, info, charInfo, array);
					t3.M768(b2);
					t3.M769(isUse);
					t3.M767(amount, max_amount);
					t2.M1111(t3);
					if (b2 > 0)
					{
						num3++;
					}
				}
				T136.M1494().M1495(t2, num3, num2);
				T136.M1494().switchToMe();
				break;
			}
			case 1:
			{
				int id3 = msg.M887().M1092();
				sbyte isUse2 = msg.M887().M1088();
				if (T70.M771(T136.list, id3) != null)
				{
					T70.M771(T136.list, id3).M769(isUse2);
				}
				T136.M1497();
				break;
			}
			case 2:
			{
				int num4 = msg.M887().M1092();
				sbyte level = msg.M887().M1088();
				int num5 = 0;
				for (int k = 0; k < T136.list.M1113(); k++)
				{
					T70 t4 = (T70)T136.list.M1114(k);
					if (t4 != null)
					{
						if (t4.id == num4)
						{
							t4.M768(level);
						}
						if (t4.level > 0)
						{
							num5++;
						}
					}
				}
				T136.M1496(num5, T136.list.M1113());
				if (T70.M771(T136.listUse, num4) != null)
				{
					T70.M771(T136.listUse, num4).M768(level);
				}
				break;
			}
			case 3:
			{
				int id2 = msg.M887().M1092();
				sbyte amount2 = msg.M887().M1088();
				sbyte max_amount2 = msg.M887().M1088();
				if (T70.M771(T136.list, id2) != null)
				{
					T70.M771(T136.list, id2).M767(amount2, max_amount2);
				}
				if (T70.M771(T136.listUse, id2) != null)
				{
					T70.M771(T136.listUse, id2).M767(amount2, max_amount2);
				}
				break;
			}
			case 4:
			{
				int num = msg.M887().M1094();
				short idAuraEff = msg.M887().M1092();
				T13 t = null;
				t = ((num != T13.M113().charID) ? T54.M626(num) : T13.M113());
				if (t != null)
				{
					t.idAuraEff = idAuraEff;
				}
				break;
			}
			}
		}
		catch (Exception)
		{
		}
	}

	private static void M2311(T97 msg)
	{
		try
		{
			sbyte b = msg.M887().M1088();
			int num = msg.M887().M1094();
			T13 t = null;
			t = ((num != T13.M113().charID) ? T54.M626(num) : T13.M113());
			switch (b)
			{
			case 0:
			{
				int id = msg.M887().M1092();
				int layer = msg.M887().M1088();
				int loop = msg.M887().M1088();
				short loopCount = msg.M887().M1092();
				sbyte isStand = msg.M887().M1088();
				t?.M246(new T32(id, t, layer, loop, loopCount, isStand));
				break;
			}
			case 1:
			{
				int id2 = msg.M887().M1092();
				t?.M247(0, id2);
				break;
			}
			case 2:
				t?.M247(-1, 0);
				break;
			}
		}
		catch (Exception)
		{
		}
	}

	private static void M2312(T97 msg, int actionBoss)
	{
		try
		{
			T121 t = T101.M988(msg.M887().M1088());
			if (t == null)
			{
				return;
			}
			if (actionBoss == 10)
			{
				t.M1179(msg.M887().M1092(), msg.M887().M1092());
			}
			if (actionBoss >= 11 && actionBoss <= 20)
			{
				sbyte b = msg.M887().M1088();
				T13[] array = new T13[b];
				int[] array2 = new int[b];
				for (int i = 0; i < b; i++)
				{
					int num = msg.M887().M1094();
					array[i] = null;
					if (num != T13.M113().charID)
					{
						array[i] = T54.M626(num);
					}
					else
					{
						array[i] = T13.M113();
					}
					array2[i] = msg.M887().M1094();
				}
				t.M1168(array, array2, (sbyte)(actionBoss - 10), msg.M887().M1088());
			}
			if (actionBoss == 21)
			{
				t.xTo = msg.M887().M1092();
				t.yTo = msg.M887().M1092();
				t.M1167();
			}
			if (actionBoss == 23)
			{
				t.M1181();
			}
		}
		catch (Exception)
		{
		}
	}
}
