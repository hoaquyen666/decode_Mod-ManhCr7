using System.IO;
using System.Text;
using UnityEngine;

public class T118
{
	public sbyte[] buffer = new sbyte[2048];

	private int posWrite;

	private int lenght = 2048;

	public void M1124(sbyte value)
	{
		M1145(0);
		buffer[posWrite++] = value;
	}

	public void M1125(sbyte value)
	{
		buffer[posWrite++] = value;
	}

	public void M1126(sbyte value)
	{
		M1124(value);
	}

	public void M1127(int value)
	{
		M1124((sbyte)value);
	}

	public void M1128(char value)
	{
		M1124(0);
		M1124((sbyte)value);
	}

	public void M1129(byte value)
	{
		M1124((sbyte)value);
	}

	public void M1130(byte[] value)
	{
		M1145(value.Length);
		for (int i = 0; i < value.Length; i++)
		{
			M1125((sbyte)value[i]);
		}
	}

	public void M1131(sbyte[] value)
	{
		M1145(value.Length);
		for (int i = 0; i < value.Length; i++)
		{
			M1125(value[i]);
		}
	}

	public void M1132(short value)
	{
		M1145(2);
		for (int num = 1; num >= 0; num--)
		{
			M1125((sbyte)(value >> num * 8));
		}
	}

	public void M1133(int value)
	{
		M1145(2);
		short num = (short)value;
		for (int num2 = 1; num2 >= 0; num2--)
		{
			M1125((sbyte)(num >> num2 * 8));
		}
	}

	public void M1134(ushort value)
	{
		M1145(2);
		for (int num = 1; num >= 0; num--)
		{
			M1125((sbyte)(value >> num * 8));
		}
	}

	public void M1135(int value)
	{
		M1145(4);
		for (int num = 3; num >= 0; num--)
		{
			M1125((sbyte)(value >> num * 8));
		}
	}

	public void M1136(long value)
	{
		M1145(8);
		for (int num = 7; num >= 0; num--)
		{
			M1125((sbyte)(value >> num * 8));
		}
	}

	public void M1137(bool value)
	{
		M1124((sbyte)(value ? 1 : 0));
	}

	public void M1138(bool value)
	{
		M1124((sbyte)(value ? 1 : 0));
	}

	public void M1139(string value)
	{
		char[] array = value.ToCharArray();
		M1132((short)array.Length);
		M1145(array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			M1125((sbyte)array[i]);
		}
	}

	public void M1140(string value)
	{
		Encoding unicode = Encoding.Unicode;
		byte[] array = Encoding.Convert(unicode, Encoding.GetEncoding(65001), unicode.GetBytes(value));
		M1132((short)array.Length);
		M1145(array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			M1125((sbyte)array[i]);
		}
	}

	public void M1141(sbyte value)
	{
		M1124(value);
	}

	public void M1142(ref sbyte[] data, int arg1, int arg2)
	{
		if (data == null)
		{
			return;
		}
		for (int i = 0; i < arg2; i++)
		{
			M1124(data[i + arg1]);
			if (posWrite > buffer.Length)
			{
				break;
			}
		}
	}

	public void M1143(sbyte[] value)
	{
		M1131(value);
	}

	public sbyte[] M1144()
	{
		if (posWrite <= 0)
		{
			return null;
		}
		sbyte[] array = new sbyte[posWrite];
		for (int i = 0; i < posWrite; i++)
		{
			array[i] = buffer[i];
		}
		return array;
	}

	public void M1145(int ltemp)
	{
		if (posWrite + ltemp > lenght)
		{
			sbyte[] array = new sbyte[lenght + 1024 + ltemp];
			for (int i = 0; i < lenght; i++)
			{
				array[i] = buffer[i];
			}
			buffer = null;
			buffer = array;
			lenght += 1024 + ltemp;
		}
	}

	private static void M1146(string[] args)
	{
		string path = args[0];
		string path2 = args[1];
		using StreamReader input = new StreamReader(path, Encoding.Unicode);
		using StreamWriter output = new StreamWriter(path2, append: false, Encoding.UTF8);
		M1147(input, output);
	}

	private static void M1147(TextReader input, TextWriter output)
	{
		char[] array = new char[8192];
		int count;
		while ((count = input.Read(array, 0, array.Length)) != 0)
		{
			output.Write(array, 0, count);
		}
		output.Flush();
		Debug.Log(output.ToString());
	}

	public byte M1148(sbyte var)
	{
		if (var > 0)
		{
			return (byte)var;
		}
		return (byte)(var + 256);
	}

	public byte[] M1149(sbyte[] var)
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

	public void M1150()
	{
		buffer = null;
	}

	public void M1151()
	{
		buffer = null;
	}
}
