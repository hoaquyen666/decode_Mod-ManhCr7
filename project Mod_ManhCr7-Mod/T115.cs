using System;
using System.Text;
using UnityEngine;

public class T115
{
	public sbyte[] buffer;

	private int posRead;

	private int posMark;

	private static string fileName;

	private static int status;

	public T115()
	{
	}

	public T115(sbyte[] data)
	{
		buffer = data;
	}

	public T115(string filename)
	{
		buffer = T110.M1056(((TextAsset)Resources.Load(filename, typeof(TextAsset))).bytes);
	}

	public sbyte M1086()
	{
		if (posRead >= buffer.Length)
		{
			posRead = buffer.Length;
			throw new Exception(" loi doc sbyte eof ");
		}
		return buffer[posRead++];
	}

	public sbyte M1087()
	{
		return M1086();
	}

	public sbyte M1088()
	{
		return M1086();
	}

	public void M1089(int readlimit)
	{
		posMark = posRead;
	}

	public void M1090()
	{
		posRead = posMark;
	}

	public byte M1091()
	{
		return M1105(M1086());
	}

	public short M1092()
	{
		short num = 0;
		for (int i = 0; i < 2; i++)
		{
			num = (short)((short)(num << 8) | (short)(0xFF & buffer[posRead++]));
		}
		return num;
	}

	public ushort M1093()
	{
		ushort num = 0;
		for (int i = 0; i < 2; i++)
		{
			num = (ushort)((ushort)(num << 8) | (ushort)(0xFF & buffer[posRead++]));
		}
		return num;
	}

	public int M1094()
	{
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			num = (num << 8) | (0xFF & buffer[posRead++]);
		}
		return num;
	}

	public long M1095()
	{
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			num = (num << 8) | (0xFF & buffer[posRead++]);
		}
		return num;
	}

	public bool M1096()
	{
		return M1086() > 0;
	}

	public bool M1097()
	{
		return M1086() > 0;
	}

	public string M1098()
	{
		short num = M1092();
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = M1105(M1086());
		}
		return new UTF8Encoding().GetString(array);
	}

	public string M1099()
	{
		short num = M1092();
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = M1105(M1086());
		}
		return new UTF8Encoding().GetString(array);
	}

	public string M1100()
	{
		return M1099();
	}

	public int M1101()
	{
		if (posRead < buffer.Length)
		{
			return M1086();
		}
		return -1;
	}

	public int M1102(ref sbyte[] data)
	{
		if (data == null)
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < data.Length; i++)
		{
			data[i] = M1086();
			if (posRead <= buffer.Length)
			{
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public void M1103(ref sbyte[] data)
	{
		if (data != null && data.Length + posRead <= buffer.Length)
		{
			for (int i = 0; i < data.Length; i++)
			{
				data[i] = M1086();
			}
		}
	}

	public int M1104()
	{
		return buffer.Length - posRead;
	}

	public static byte M1105(sbyte var)
	{
		if (var > 0)
		{
			return (byte)var;
		}
		return (byte)(var + 256);
	}

	public static byte[] M1106(sbyte[] var)
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

	public void M1107()
	{
		buffer = null;
	}

	public void M1108()
	{
		buffer = null;
	}

	public void M1109(ref sbyte[] data, int arg1, int arg2)
	{
		if (data == null)
		{
			return;
		}
		for (int i = 0; i < arg2; i++)
		{
			data[i + arg1] = M1086();
			if (posRead > buffer.Length)
			{
				break;
			}
		}
	}
}
