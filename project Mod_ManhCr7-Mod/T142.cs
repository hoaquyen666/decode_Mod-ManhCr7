using System;
using System.Runtime.InteropServices;

internal class T142
{
	private struct T213
	{
		public int type;

		public T214 u;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct T214
	{
		[FieldOffset(0)]
		public T215 ki;
	}

	private struct T215
	{
		public ushort wVk;

		public ushort wScan;

		public uint dwFlags;

		public uint time;

		public IntPtr dwExtraInfo;
	}

	private const int INPUT_KEYBOARD = 1;

	private const ushort VK_F1 = 112;

	private const uint KEYEVENTF_KEYUP = 2u;

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint SendInput(uint nInputs, T213[] pInputs, int cbSize);

	private static void M1570()
	{
		T213[] array = new T213[2]
		{
			new T213
			{
				type = 1,
				u = new T214
				{
					ki = new T215
					{
						wVk = 112
					}
				}
			},
			new T213
			{
				type = 1,
				u = new T214
				{
					ki = new T215
					{
						wVk = 112,
						dwFlags = 2u
					}
				}
			}
		};
		SendInput((uint)array.Length, array, Marshal.SizeOf(typeof(T213)));
	}
}
