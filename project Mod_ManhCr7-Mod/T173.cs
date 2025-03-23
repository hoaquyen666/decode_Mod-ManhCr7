using System;
using System.Threading;

public class T173 : T57
{
	public bool isFocus;

	public int x;

	public int y;

	public int width;

	public int height;

	public bool lockArrow;

	public bool justReturnFromTextBox;

	public bool paintFocus = true;

	public const sbyte KEY_LEFT = 14;

	public const sbyte KEY_RIGHT = 15;

	public const sbyte KEY_CLEAR = 19;

	public static int typeXpeed = 2;

	private static readonly int[] MAX_TIME_TO_CONFIRM_KEY = new int[7] { 30, 14, 11, 9, 6, 4, 2 };

	private static int CARET_HEIGHT = 0;

	private static readonly int CARET_WIDTH = 1;

	private static readonly int CARET_SHOWING_TIME = 5;

	private static readonly int TEXT_GAP_X = 4;

	private static readonly int MAX_SHOW_CARET_COUNER = 10;

	public static readonly int INPUT_TYPE_ANY = 0;

	public static readonly int INPUT_TYPE_NUMERIC = 1;

	public static readonly int INPUT_TYPE_PASSWORD = 2;

	public static readonly int INPUT_ALPHA_NUMBER_ONLY = 3;

	private static string[] print = new string[12]
	{
		" 0", ".,@?!_1\"/$-():*+<=>;%&~#%^&*{}[];'/1", "abc2áàảãạâấầẩẫậăắằẳẵặ2", "def3đéèẻẽẹêếềểễệ3", "ghi4íìỉĩị4", "jkl5", "mno6óòỏõọôốồổỗộơớờởỡợ6", "pqrs7", "tuv8úùủũụưứừửữự8", "wxyz9ýỳỷỹỵ9",
		"*", "#"
	};

	private static string[] printA = new string[12]
	{
		"0", "1", "abc2", "def3", "ghi4", "jkl5", "mno6", "pqrs7", "tuv8", "wxyz9",
		"0", "0"
	};

	private static string[] printBB = new string[17]
	{
		" 0", "er1", "ty2", "ui3", "df4", "gh5", "jk6", "cv7", "bn8", "m9",
		"0", "0", "qw!", "as?", "zx", "op.", "l,"
	};

	private string text = string.Empty;

	private string passwordText = string.Empty;

	private string paintedText = string.Empty;

	private int caretPos;

	private int counter;

	private int maxTextLenght = 500;

	private int offsetX;

	private static int lastKey = -1984;

	private int keyInActiveState;

	private int indexOfActiveChar;

	private int showCaretCounter = MAX_SHOW_CARET_COUNER;

	private int inputType = INPUT_TYPE_ANY;

	public static bool isQwerty = true;

	public static int typingModeAreaWidth;

	public static int mode = 0;

	public static long timeChangeMode;

	public static readonly string[] modeNotify = new string[4] { "abc", "Abc", "ABC", "123" };

	public static readonly int NOKIA = 0;

	public static readonly int MOTO = 1;

	public static readonly int ORTHER = 2;

	public static readonly int BB = 3;

	public static int changeModeKey = 11;

	public static readonly sbyte abc = 0;

	public static readonly sbyte Abc = 1;

	public static readonly sbyte ABC = 2;

	public static readonly sbyte number123 = 3;

	public static T173 currentTField;

	public bool isTfield;

	public bool isPaintMouse = true;

	public string name = string.Empty;

	public string title = string.Empty;

	public string strInfo;

	public T22 cmdClear;

	public T22 cmdDoneAction;

	private T108 parentScr;

	private int timeDelayKyCode;

	private int holdCount;

	public static int changeDau;

	private int indexDau = -1;

	private int indexTemplate;

	private int indexCong;

	private long timeDau;

	private static string printDau = "aáàảãạâấầẩẫậăắằẳẵặeéèẻẽẹêếềểễệiíìỉĩịoóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựyýỳỷỹỵ";

	public static T60 imgTf;

	public int timePutKeyClearAll;

	public int timeClearFirt;

	public bool isPaintCarret;

	public bool showSubTextField = true;

	public static T177 kb;

	public static int[][] BBKEY = new int[17][]
	{
		new int[2] { 32, 48 },
		new int[2] { 49, 69 },
		new int[2] { 50, 84 },
		new int[2] { 51, 85 },
		new int[2] { 52, 68 },
		new int[2] { 53, 71 },
		new int[2] { 54, 74 },
		new int[2] { 55, 67 },
		new int[2] { 56, 66 },
		new int[2] { 57, 77 },
		new int[2] { 42, 128 },
		new int[2] { 35, 137 },
		new int[2] { 33, 113 },
		new int[2] { 63, 97 },
		new int[3] { 64, 121, 122 },
		new int[2] { 46, 111 },
		new int[2] { 44, 108 }
	};

	public T173(T108 parentScr)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		text = string.Empty;
		this.parentScr = parentScr;
		M1903();
	}

	public T173()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		text = string.Empty;
		M1903();
	}

	public T173(int x, int y, int w, int h)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		text = string.Empty;
		M1903();
		this.x = x;
		this.y = y;
		width = w;
		height = h;
	}

	public T173(string text, int maxLen, int inputType)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.text = text;
		maxTextLenght = maxLen;
		this.inputType = inputType;
		M1903();
		isTfield = true;
	}

	public static bool M1900(char ch)
	{
		if ((ch >= '0' && ch <= '9') || (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
		{
			return true;
		}
		return false;
	}

	public void M1901()
	{
	}

	public static void M1902(int mode)
	{
		if (mode == MOTO)
		{
			print[0] = "0";
			print[10] = " *";
			print[11] = "#";
			changeModeKey = 35;
		}
		else if (mode == NOKIA)
		{
			print[0] = " 0";
			print[10] = "*";
			print[11] = "#";
			changeModeKey = 35;
		}
		else if (mode == ORTHER)
		{
			print[0] = "0";
			print[10] = "*";
			print[11] = " #";
			changeModeKey = 42;
		}
	}

	public void M1903()
	{
		CARET_HEIGHT = T108.ITEM_HEIGHT + 1;
		cmdClear = new T22(mResources.DELETE, this, 1000, null);
		if (Main.isPC)
		{
			typeXpeed = 0;
		}
		if (imgTf == null)
		{
			imgTf = T51.M503("/mainImage/myTexture2dtf.png");
		}
	}

	public void M1904(int keyCode)
	{
		if (keyCode == -8 && timeDelayKyCode <= 0)
		{
			if (timeDelayKyCode <= 0)
			{
				timeDelayKyCode = 1;
			}
			M1906();
		}
	}

	public void M1905()
	{
		text = string.Empty;
		if (kb != null)
		{
			kb.text = string.Empty;
		}
		caretPos = 0;
		M1914(0);
		M1919();
	}

	public void M1906()
	{
		if (caretPos > 0 && text.Length > 0)
		{
			text = text.Substring(0, caretPos - 1);
			caretPos--;
			M1914(0);
			M1919();
			if (kb != null)
			{
				kb.text = text;
			}
		}
	}

	public void M1907()
	{
		if (caretPos > 0 && text.Length > 0)
		{
			text = text.Substring(0, text.Length - 1);
			caretPos--;
			M1908();
			M1919();
			M1923(isFocus: true);
			if (kb != null)
			{
				kb.text = string.Empty;
			}
		}
	}

	public void M1908()
	{
		if (paintedText != null && T98.tahoma_8b != null)
		{
			if (inputType == INPUT_TYPE_PASSWORD)
			{
				paintedText = passwordText;
			}
			else
			{
				paintedText = text;
			}
			if (offsetX < 0 && T98.tahoma_8b.M909(paintedText) + offsetX < width - TEXT_GAP_X - 13 - typingModeAreaWidth)
			{
				offsetX = width - 10 - typingModeAreaWidth - T98.tahoma_8b.M909(paintedText);
			}
			if (offsetX + T98.tahoma_8b.M909(paintedText.Substring(0, caretPos)) <= 0)
			{
				offsetX = -T98.tahoma_8b.M909(paintedText.Substring(0, caretPos));
				offsetX += 40;
			}
			else if (offsetX + T98.tahoma_8b.M909(paintedText.Substring(0, caretPos)) >= width - 12 - typingModeAreaWidth)
			{
				offsetX = width - 10 - typingModeAreaWidth - T98.tahoma_8b.M909(paintedText.Substring(0, caretPos)) - 2 * TEXT_GAP_X;
			}
			if (offsetX > 0)
			{
				offsetX = 0;
			}
		}
	}

	private void M1909(int keyCode)
	{
		string[] array = ((inputType == INPUT_TYPE_PASSWORD || inputType == INPUT_ALPHA_NUMBER_ONLY) ? printA : print);
		if (keyCode == lastKey)
		{
			indexOfActiveChar = (indexOfActiveChar + 1) % array[keyCode - 48].Length;
			char c = array[keyCode - 48][indexOfActiveChar];
			object obj = ((mode == 0) ? char.ToLower(c) : ((mode == 1) ? char.ToUpper(c) : ((mode != 2) ? array[keyCode - 48][array[keyCode - 48].Length - 1] : char.ToUpper(c))));
			string text = this.text.Substring(0, caretPos - 1) + obj;
			if (caretPos < this.text.Length)
			{
				text += this.text.Substring(caretPos, this.text.Length);
			}
			this.text = text;
			keyInActiveState = MAX_TIME_TO_CONFIRM_KEY[typeXpeed];
			M1919();
		}
		else if (this.text.Length < maxTextLenght)
		{
			if (mode == 1 && lastKey != -1984)
			{
				mode = 0;
			}
			indexOfActiveChar = 0;
			char c2 = array[keyCode - 48][indexOfActiveChar];
			object obj2 = ((mode == 0) ? char.ToLower(c2) : ((mode == 1) ? char.ToUpper(c2) : ((mode != 2) ? array[keyCode - 48][array[keyCode - 48].Length - 1] : char.ToUpper(c2))));
			string text2 = this.text.Substring(0, caretPos) + obj2;
			if (caretPos < this.text.Length)
			{
				text2 += this.text.Substring(caretPos, this.text.Length);
			}
			this.text = text2;
			keyInActiveState = MAX_TIME_TO_CONFIRM_KEY[typeXpeed];
			caretPos++;
			M1919();
			M1908();
		}
		lastKey = keyCode;
	}

	private void M1910(int keyCode)
	{
		if ((inputType == INPUT_TYPE_PASSWORD || inputType == INPUT_ALPHA_NUMBER_ONLY) && (keyCode < 48 || keyCode > 57) && (keyCode < 65 || keyCode > 90) && (keyCode < 97 || keyCode > 122))
		{
			return;
		}
		if (this.text.Length < maxTextLenght)
		{
			string text = this.text.Substring(0, caretPos) + (char)keyCode;
			if (caretPos < this.text.Length)
			{
				text += this.text.Substring(caretPos, this.text.Length - caretPos);
			}
			this.text = text;
			caretPos++;
			M1919();
			M1914(0);
		}
		if (kb != null)
		{
			kb.text = this.text;
		}
	}

	public static void M1911()
	{
		mode++;
		if (mode > 3)
		{
			mode = 0;
		}
		lastKey = changeModeKey;
		timeChangeMode = Environment.TickCount / 1000;
	}

	private void M1912()
	{
		timeDau = Environment.TickCount / 100;
		if (indexDau == -1)
		{
			for (int num = caretPos; num > 0; num--)
			{
				char c = text[num - 1];
				for (int i = 0; i < printDau.Length; i++)
				{
					if (c == printDau[i])
					{
						indexTemplate = i;
						indexCong = 0;
						indexDau = num - 1;
						return;
					}
				}
			}
			indexDau = -1;
		}
		else
		{
			indexCong++;
			if (indexCong >= 6)
			{
				indexCong = 0;
			}
			text = string.Concat(text.Substring(0, indexDau), str2: text.Substring(indexDau + 1), str1: printDau.Substring(indexTemplate + indexCong, 1));
		}
	}

	public bool M1913(int keyCode)
	{
		if (Main.isPC && keyCode == -8)
		{
			M1904(-8);
			return true;
		}
		if (keyCode != 8 && keyCode != -8 && keyCode != 204)
		{
			if (isQwerty && keyCode >= 32)
			{
				M1910(keyCode);
				return false;
			}
			if (keyCode == changeDau && inputType == INPUT_TYPE_ANY)
			{
				M1912();
				return false;
			}
			if (keyCode == 42)
			{
				keyCode = 58;
			}
			if (keyCode == 35)
			{
				keyCode = 59;
			}
			if (keyCode >= 48 && keyCode <= 59)
			{
				if (inputType != INPUT_TYPE_ANY && inputType != INPUT_TYPE_PASSWORD && inputType != INPUT_ALPHA_NUMBER_ONLY)
				{
					if (inputType == INPUT_TYPE_NUMERIC)
					{
						M1910(keyCode);
						keyInActiveState = 1;
					}
				}
				else
				{
					M1909(keyCode);
				}
			}
			else
			{
				indexOfActiveChar = 0;
				lastKey = -1984;
				if (keyCode == 14 && !lockArrow)
				{
					if (caretPos > 0)
					{
						caretPos--;
						M1914(0);
						showCaretCounter = MAX_SHOW_CARET_COUNER;
						return false;
					}
				}
				else if (keyCode == 15 && !lockArrow)
				{
					if (caretPos < text.Length)
					{
						caretPos++;
						M1914(0);
						showCaretCounter = MAX_SHOW_CARET_COUNER;
						return false;
					}
				}
				else
				{
					if (keyCode == 19)
					{
						M1906();
						return false;
					}
					lastKey = keyCode;
				}
			}
			return true;
		}
		M1906();
		return true;
	}

	public void M1914(int index)
	{
		if (inputType == INPUT_TYPE_PASSWORD)
		{
			paintedText = passwordText;
		}
		else
		{
			paintedText = text;
		}
		int num = T98.tahoma_8b.M909(paintedText.Substring(0, caretPos));
		switch (index)
		{
		default:
			offsetX = -(num - (width - 12));
			break;
		case 1:
			if (num + offsetX > width - 25 && caretPos < paintedText.Length && caretPos > 0)
			{
				offsetX -= T98.tahoma_8b.M909(paintedText.Substring(caretPos - 1, 1));
			}
			break;
		case -1:
			if (num + offsetX < 15 && caretPos > 0 && caretPos < paintedText.Length)
			{
				offsetX += T98.tahoma_8b.M909(paintedText.Substring(caretPos, 1));
			}
			break;
		}
		if (offsetX > 0)
		{
			offsetX = 0;
		}
		else if (offsetX < 0)
		{
			int num2 = T98.tahoma_8b.M909(paintedText) - (width - 12);
			if (offsetX < -num2)
			{
				offsetX = -num2;
			}
		}
	}

	public void M1915(T99 g, bool iss, int x, int y, int w, int h, int xText, int yText, string text, string info)
	{
		g.M933(0);
		if (iss)
		{
			g.M940(imgTf, 0, 81, 29, 27, 0, x, y, 0);
			g.M940(imgTf, 0, 135, 29, 27, 0, x + w - 29, y, 0);
			g.M940(imgTf, 0, 108, 29, 27, 0, x + w - 58, y, 0);
			for (int i = 0; i < (w - 58) / 29; i++)
			{
				g.M940(imgTf, 0, 108, 29, 27, 0, x + 29 + i * 29, y, 0);
			}
		}
		else
		{
			g.M940(imgTf, 0, 0, 29, 27, 0, x, y, 0);
			g.M940(imgTf, 0, 54, 29, 27, 0, x + w - 29, y, 0);
			g.M940(imgTf, 0, 27, 29, 27, 0, x + w - 58, y, 0);
			for (int j = 0; j < (w - 58) / 29; j++)
			{
				g.M940(imgTf, 0, 27, 29, 27, 0, x + 29 + j * 29, y, 0);
			}
		}
		g.M922(x + 3, y + 1, w - 4, h);
		if (text != null && !text.Equals(string.Empty))
		{
			T98.tahoma_8b.M898(g, text, xText, yText, 0);
		}
		else if (info != null)
		{
			if (iss)
			{
				T98.tahoma_7b_focus.M898(g, info, xText, yText, 0);
			}
			else
			{
				T98.tahoma_7b_unfocus.M898(g, info, xText, yText, 0);
			}
		}
	}

	public void M1916(T99 g)
	{
		g.M922(0, 0, T51.w, T51.h);
		bool flag = M1917();
		if (inputType == INPUT_TYPE_PASSWORD)
		{
			paintedText = passwordText;
		}
		else
		{
			paintedText = text;
		}
		M1915(g, flag, x, y - 1, width, height + 5, TEXT_GAP_X + offsetX + x + 1, y + (height - T98.tahoma_8b.M912()) / 2 + 2, paintedText, name);
		g.M922(x + 3, y + 1, width - 4, height - 2);
		g.M933(0);
		if (flag && isPaintMouse && isPaintCarret)
		{
			if (keyInActiveState == 0 && (showCaretCounter > 0 || counter / CARET_SHOWING_TIME % 4 == 0))
			{
				g.M933(7999781);
				g.M932(TEXT_GAP_X + 1 + offsetX + x + T98.tahoma_8b.M909(paintedText.Substring(0, caretPos) + "a") - CARET_WIDTH - T98.tahoma_8b.M909("a"), y + (height - CARET_HEIGHT) / 2 + 5, CARET_WIDTH, CARET_HEIGHT);
			}
			T51.M451(g);
			if (text != null && text.Length > 0 && T51.isTouch)
			{
				g.M948(T51.imgClear, x + width - 13, y + height / 2 + 3, T99.VCENTER | T99.HCENTER);
			}
		}
	}

	private bool M1917()
	{
		return isFocus;
	}

	public string M1918(string str, int index, int indexTo)
	{
		if (index >= 0 && indexTo > str.Length - 1)
		{
			return str.Substring(index);
		}
		if (index >= 0 && index <= str.Length - 1 && indexTo >= 0 && indexTo <= str.Length - 1)
		{
			string text = string.Empty;
			for (int i = index; i < indexTo; i++)
			{
				text += str[i];
			}
			return text;
		}
		return string.Empty;
	}

	private void M1919()
	{
		if (inputType == INPUT_TYPE_PASSWORD)
		{
			passwordText = string.Empty;
			for (int i = 0; i < text.Length; i++)
			{
				passwordText += "*";
			}
			if (keyInActiveState > 0 && caretPos > 0)
			{
				passwordText = passwordText.Substring(0, caretPos - 1) + text[caretPos - 1] + passwordText.Substring(caretPos, passwordText.Length);
			}
		}
	}

	public void M1920()
	{
		isPaintCarret = true;
		if (Main.isPC)
		{
			if (timeDelayKyCode > 0)
			{
				timeDelayKyCode--;
			}
			if (timeDelayKyCode <= 0)
			{
				timeDelayKyCode = 0;
			}
		}
		if (kb != null && currentTField == this)
		{
			if (kb.text.Length < 40 && isFocus)
			{
				M1926(kb.text);
			}
			if (kb.done && cmdDoneAction != null)
			{
				cmdDoneAction.M294();
			}
		}
		counter++;
		if (keyInActiveState > 0)
		{
			keyInActiveState--;
			if (keyInActiveState == 0)
			{
				indexOfActiveChar = 0;
				if (mode == 1 && lastKey != changeModeKey && isFocus)
				{
					mode = 0;
				}
				lastKey = -1984;
				M1919();
			}
		}
		if (showCaretCounter > 0)
		{
			showCaretCounter--;
		}
		if (T51.isPointerJustRelease)
		{
			M1921();
		}
		if (indexDau != -1 && Environment.TickCount / 100 - timeDau > 5L)
		{
			indexDau = -1;
		}
	}

	public void M1921()
	{
		if (T51.M481(x + width - 20, y, 40, height))
		{
			M1905();
			isFocus = true;
		}
		else if (T51.M481(x, y, width - 20, height))
		{
			M1923(isFocus: true);
		}
		else
		{
			M1922(isFocus: false);
		}
	}

	public void M1922(bool isFocus)
	{
		if (this.isFocus != isFocus)
		{
			mode = 0;
		}
		lastKey = -1984;
		timeChangeMode = (int)(DateTime.Now.Ticks / 1000L);
		this.isFocus = isFocus;
		if (isFocus)
		{
			currentTField = this;
			if (kb != null)
			{
				kb.text = currentTField.text;
			}
		}
	}

	public void M1923(bool isFocus)
	{
		if (this.isFocus != isFocus)
		{
			mode = 0;
		}
		lastKey = -1984;
		timeChangeMode = (int)(DateTime.Now.Ticks / 1000L);
		this.isFocus = isFocus;
		if (isFocus)
		{
			currentTField = this;
		}
		else if (currentTField == this)
		{
			currentTField = null;
		}
		if (Thread.CurrentThread.Name == Main.mainThreadName && currentTField != null)
		{
			isFocus = true;
			T177.hideInput = !currentTField.showSubTextField;
			T178 t = T178.ASCIICapable;
			if (inputType == INPUT_TYPE_NUMERIC)
			{
				t = T178.NumberPad;
			}
			bool type = false;
			if (inputType == INPUT_TYPE_PASSWORD)
			{
				type = true;
			}
			kb = T177.M1967(currentTField.text, t, b1: false, b2: false, type, b3: false, currentTField.name);
			if (kb != null)
			{
				kb.text = currentTField.text;
			}
			T24.M331("SHOW KEYBOARD FOR " + currentTField.text);
		}
	}

	public string M1924()
	{
		return text;
	}

	public void M1925()
	{
		if (kb != null)
		{
			kb.text = string.Empty;
		}
	}

	public void M1926(string text)
	{
		if (text != null)
		{
			lastKey = -1984;
			keyInActiveState = 0;
			indexOfActiveChar = 0;
			this.text = text;
			paintedText = text;
			if (text == string.Empty)
			{
				T177.M1968();
			}
			M1919();
			caretPos = text.Length;
			M1908();
		}
	}

	public void M1927(string text)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		this.text = this.text.Substring(0, caretPos) + text + this.text.Substring(caretPos);
		M1919();
		caretPos += text.Length;
		M1908();
	}

	public int M1928()
	{
		return maxTextLenght;
	}

	public void M1929(int maxTextLenght)
	{
		this.maxTextLenght = maxTextLenght;
	}

	public int M1930()
	{
		return inputType;
	}

	public void M1931(int iputType)
	{
		inputType = iputType;
		M1929(500);
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 1000)
		{
			M1906();
		}
	}
}
