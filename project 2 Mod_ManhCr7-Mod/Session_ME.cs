using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class Session_ME : ISession
{
	public class T216
	{
		public List<Message> sendingMessage;

		public T216()
		{
			sendingMessage = new List<Message>();
		}

		public void M2317(Message message)
		{
			sendingMessage.Add(message);
		}

		public void M2318()
		{
			while (connected)
			{
				try
				{
					if (getKeyComplete)
					{
						while (sendingMessage.Count > 0)
						{
							M1747(sendingMessage[0]);
							sendingMessage.RemoveAt(0);
						}
					}
					try
					{
						Thread.Sleep(5);
					}
					catch (Exception ex)
					{
						Cout.M328(ex.ToString());
					}
				}
				catch (Exception)
				{
					Res.M1513("error send message! ");
				}
			}
		}
	}

	private class T217
	{
		public void M2319()
		{
			try
			{
				while (connected)
				{
					Message t = M2322();
					if (t == null)
					{
						break;
					}
					try
					{
						if (t.command == -27)
						{
							M2320(t);
						}
						else
						{
							M1750(t);
						}
					}
					catch (Exception)
					{
						Cout.M326("LOI NHAN  MESS THU 1");
					}
					try
					{
						Thread.Sleep(5);
					}
					catch (Exception)
					{
						Cout.M326("LOI NHAN  MESS THU 2");
					}
				}
			}
			catch (Exception ex3)
			{
				Debug.Log("error read message!");
				Debug.Log(ex3.Message.ToString());
			}
			if (!connected)
			{
				return;
			}
			if (messageHandler != null)
			{
				if (M1753() - timeConnected > 500)
				{
					messageHandler.onDisconnected(isMainSession);
				}
				else
				{
					messageHandler.onConnectionFail(isMainSession);
				}
			}
			if (sc != null)
			{
				M1752();
			}
		}

		private void M2320(Message message)
		{
			try
			{
				sbyte b = message.M887().M1086();
				key = new sbyte[b];
				for (int i = 0; i < b; i++)
				{
					key[i] = message.M887().M1086();
				}
				for (int j = 0; j < key.Length - 1; j++)
				{
					key[j + 1] ^= key[j];
				}
				getKeyComplete = true;
				GameMidlet.IP2 = message.M887().M1100();
				GameMidlet.PORT2 = message.M887().M1094();
				GameMidlet.isConnect2 = ((message.M887().M1088() != 0) ? true : false);
				if (isMainSession && GameMidlet.isConnect2)
				{
					GameCanvas.M450();
				}
			}
			catch (Exception)
			{
			}
		}

		private Message M2321(sbyte cmd)
		{
			int num = M1748(dis.ReadSByte()) + 128;
			sbyte b = M1748(dis.ReadSByte());
			int num2 = ((M1748(dis.ReadSByte()) + 128) * 256 + (b + 128)) * 256 + num;
			Cout.M328("SIZE = " + num2);
			sbyte[] array = new sbyte[num2];
			Buffer.BlockCopy(dis.ReadBytes(num2), 0, array, 0, num2);
			recvByteCount += 5 + num2;
			int num3 = recvByteCount + sendByteCount;
			strRecvByteCount = num3 / 1024 + "." + num3 % 1024 / 102 + "Kb";
			if (getKeyComplete)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = M1748(array[i]);
				}
			}
			return new Message(cmd, array);
		}

		private Message M2322()
		{
			try
			{
				sbyte b = dis.ReadSByte();
				if (getKeyComplete)
				{
					b = M1748(b);
				}
				if (b != -32 && b != -66 && b != 11 && b != -67 && b != -74 && b != -87 && b != 66)
				{
					int num;
					if (getKeyComplete)
					{
						sbyte b2 = dis.ReadSByte();
						sbyte b3 = dis.ReadSByte();
						num = ((M1748(b2) & 0xFF) << 8) | (M1748(b3) & 0xFF);
					}
					else
					{
						num = (dis.ReadSByte() & 0xFF00) | (dis.ReadSByte() & 0xFF);
					}
					sbyte[] array = new sbyte[num];
					Buffer.BlockCopy(dis.ReadBytes(num), 0, array, 0, num);
					recvByteCount += 5 + num;
					int num2 = recvByteCount + sendByteCount;
					strRecvByteCount = num2 / 1024 + "." + num2 % 1024 / 102 + "Kb";
					if (getKeyComplete)
					{
						for (int i = 0; i < array.Length; i++)
						{
							array[i] = M1748(array[i]);
						}
					}
					return new Message(b, array);
				}
				return M2321(b);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.StackTrace.ToString());
			}
			return null;
		}
	}

	protected static Session_ME instance = new Session_ME();

	private static NetworkStream dataStream;

	private static BinaryReader dis;

	private static BinaryWriter dos;

	public static IMessageHandler messageHandler;

	public static bool isMainSession = true;

	private static TcpClient sc;

	public static bool connected;

	public static bool connecting;

	private static T216 sender = new T216();

	public static Thread initThread;

	public static Thread collectorThread;

	public static Thread sendThread;

	public static int sendByteCount;

	public static int recvByteCount;

	private static bool getKeyComplete;

	public static sbyte[] key = null;

	private static sbyte curR;

	private static sbyte curW;

	private static int timeConnected;

	private long lastTimeConn;

	public static string strRecvByteCount = string.Empty;

	public static bool isCancel;

	private string host;

	private int port;

	public static int count;

	public static MyVector recieveMsg = new MyVector();

	public Session_ME()
	{
		Debug.Log("init Session_ME");
	}

	public void M1743()
	{
		sender.sendingMessage.Clear();
	}

	public static Session_ME M1744()
	{
		if (instance == null)
		{
			instance = new Session_ME();
		}
		return instance;
	}

	public bool isConnected()
	{
		return connected;
	}

	public void setHandler(IMessageHandler msgHandler)
	{
		messageHandler = msgHandler;
	}

	public void connect(string host, int port)
	{
		if (!connected && !connecting)
		{
			if (isMainSession)
			{
				ServerListScreen.testConnect = -1;
			}
			this.host = host;
			this.port = port;
			getKeyComplete = false;
			sc = null;
			Debug.Log("connecting...!");
			Debug.Log("host: " + host);
			Debug.Log("port: " + port);
			initThread = new Thread(M1745);
			initThread.Start();
		}
	}

	private void M1745()
	{
		isCancel = false;
		connecting = true;
		Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
		connected = true;
		try
		{
			M1746(host, port);
			messageHandler.onConnectOK(isMainSession);
		}
		catch (Exception)
		{
			if (messageHandler != null)
			{
				close();
				messageHandler.onConnectionFail(isMainSession);
			}
		}
	}

	public void M1746(string host, int port)
	{
		sc = new TcpClient();
		sc.Connect(host, port);
		dataStream = sc.GetStream();
		dis = new BinaryReader(dataStream, new UTF8Encoding());
		dos = new BinaryWriter(dataStream, new UTF8Encoding());
		new Thread(sender.M2318).Start();
		T217 @object = new T217();
		Cout.M328("new -----");
		collectorThread = new Thread(@object.M2319);
		collectorThread.Start();
		timeConnected = M1753();
		connecting = false;
		M1747(new Message(-27));
	}

	public void sendMessage(Message message)
	{
		count++;
		Res.M1513("SEND MSG: " + message.command);
		sender.M2317(message);
	}

	private static void M1747(Message m)
	{
		sbyte[] array = m.M886();
		try
		{
			if (getKeyComplete)
			{
				sbyte value = M1749(m.command);
				dos.Write(value);
			}
			else
			{
				dos.Write(m.command);
			}
			if (array != null)
			{
				int num = array.Length;
				if (getKeyComplete)
				{
					sbyte value2 = M1749((sbyte)(num >> 8));
					dos.Write(value2);
					sbyte value3 = M1749((sbyte)(num & 0xFF));
					dos.Write(value3);
				}
				else
				{
					dos.Write((ushort)num);
				}
				if (getKeyComplete)
				{
					for (int i = 0; i < array.Length; i++)
					{
						sbyte value4 = M1749(array[i]);
						dos.Write(value4);
					}
				}
				sendByteCount += 5 + array.Length;
			}
			else
			{
				if (getKeyComplete)
				{
					sbyte value5 = M1749(0);
					dos.Write(value5);
					sbyte value6 = M1749(0);
					dos.Write(value6);
				}
				else
				{
					dos.Write((ushort)0);
				}
				sendByteCount += 5;
			}
			dos.Flush();
		}
		catch (Exception ex)
		{
			Debug.Log(ex.StackTrace);
		}
	}

	public static sbyte M1748(sbyte b)
	{
		sbyte result = (sbyte)((key[curR++] & 0xFF) ^ (b & 0xFF));
		if (curR >= key.Length)
		{
			curR %= (sbyte)key.Length;
		}
		return result;
	}

	public static sbyte M1749(sbyte b)
	{
		sbyte result = (sbyte)((key[curW++] & 0xFF) ^ (b & 0xFF));
		if (curW >= key.Length)
		{
			curW %= (sbyte)key.Length;
		}
		return result;
	}

	public static void M1750(Message msg)
	{
		if (Thread.CurrentThread.Name == Main.mainThreadName)
		{
			messageHandler.onMessage(msg);
		}
		else
		{
			recieveMsg.M1111(msg);
		}
	}

	public static void M1751()
	{
		while (recieveMsg.M1113() > 0)
		{
			Message t = (Message)recieveMsg.M1114(0);
			if (!Controller.isStopReadMessage)
			{
				if (t != null)
				{
					messageHandler.onMessage(t);
					recieveMsg.M1118(0);
					continue;
				}
				recieveMsg.M1118(0);
				break;
			}
			break;
		}
	}

	public void close()
	{
		M1752();
	}

	private static void M1752()
	{
		key = null;
		curR = 0;
		curW = 0;
		try
		{
			connected = false;
			connecting = false;
			if (sc != null)
			{
				sc.Close();
				sc = null;
			}
			if (dataStream != null)
			{
				dataStream.Close();
				dataStream = null;
			}
			if (dos != null)
			{
				dos.Close();
				dos = null;
			}
			if (dis != null)
			{
				dis.Close();
				dis = null;
			}
			sendThread = null;
			collectorThread = null;
			if (isMainSession)
			{
				ServerListScreen.testConnect = 0;
			}
		}
		catch (Exception)
		{
		}
	}

	public static int M1753()
	{
		return Environment.TickCount;
	}

	public static byte M1754(sbyte var)
	{
		if (var > 0)
		{
			return (byte)var;
		}
		return (byte)(var + 256);
	}

	public static byte[] M1755(sbyte[] var)
	{
		byte[] array = new byte[var.Length];
		for (int i = 0; i < var.Length; i++)
		{
			if (var[i] > 0)
			{
				array[i] = (byte)var[i];
			}
			else
			{
				array[i] = (byte)(var[i] + 256);
			}
		}
		return array;
	}
}
