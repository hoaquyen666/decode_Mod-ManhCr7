using System;
using System.Collections;
using UnityEngine;

public class T98
{
	public static int LEFT = 0;

	public static int RIGHT = 1;

	public static int CENTER = 2;

	public static int RED = 0;

	public static int YELLOW = 1;

	public static int GREEN = 2;

	public static int FATAL = 3;

	public static int MISS = 4;

	public static int ORANGE = 5;

	public static int ADDMONEY = 6;

	public static int MISS_ME = 7;

	public static int FATAL_ME = 8;

	public static int HP = 9;

	public static int MP = 10;

	private int space;

	private T60 imgFont;

	private string strFont;

	private int[][] fImages;

	public static int yAddFont;

	public static int[] colorJava = new int[31]
	{
		0, 16711680, 6520319, 16777215, 16755200, 5449989, 21285, 52224, 7386228, 16771788,
		0, 65535, 21285, 16776960, 5592405, 16742263, 33023, 8701737, 15723503, 7999781,
		16768815, 14961237, 4124899, 4671303, 16096312, 16711680, 16755200, 52224, 16777215, 6520319,
		16096312
	};

	public static T98 gI;

	public static T98 tahoma_7b_red;

	public static T98 tahoma_7b_blue;

	public static T98 tahoma_7b_white;

	public static T98 tahoma_7b_yellow;

	public static T98 tahoma_7b_yellowSmall;

	public static T98 tahoma_7b_dark;

	public static T98 tahoma_7b_green2;

	public static T98 tahoma_7b_green;

	public static T98 tahoma_7b_focus;

	public static T98 tahoma_7b_unfocus;

	public static T98 tahoma_7;

	public static T98 tahoma_7_blue1;

	public static T98 tahoma_7_blue1Small;

	public static T98 tahoma_7_green2;

	public static T98 tahoma_7_yellow;

	public static T98 tahoma_7_grey;

	public static T98 tahoma_7_red;

	public static T98 tahoma_7_blue;

	public static T98 tahoma_7_green;

	public static T98 tahoma_7_white;

	public static T98 tahoma_8b;

	public static T98 number_yellow;

	public static T98 number_red;

	public static T98 number_green;

	public static T98 number_gray;

	public static T98 number_orange;

	public static T98 bigNumber_red;

	public static T98 bigNumber_While;

	public static T98 bigNumber_yellow;

	public static T98 bigNumber_green;

	public static T98 bigNumber_orange;

	public static T98 bigNumber_blue;

	public static T98 bigNumber_black;

	public static T98 nameFontRed;

	public static T98 nameFontYellow;

	public static T98 nameFontGreen;

	public static T98 tahoma_7_greySmall;

	public static T98 tahoma_7b_yellowSmall2;

	public static T98 tahoma_7b_green2Small;

	public static T98 tahoma_7_whiteSmall;

	public static T98 tahoma_7b_greenSmall;

	public Font myFont;

	private int height;

	private int wO;

	public Color color1 = Color.white;

	public Color color2 = Color.gray;

	public sbyte id;

	public int fstyle;

	public string st1 = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";

	public string st2 = "\u00b8µ¶·¹\u00a8¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô\u00adøõö÷ùýúûüþ®\u00b8µ¶·¹¡¾»¼½Æ¢ÊÇÈÉËÐÌÎÏÑ£ÕÒÓÔÖÝ×ØÜÞãßáâä¤èåæçé¥íêëìîóïñòô¦øõö÷ùýúûüþ§";

	public const string str = " 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW";

	private int yAdd;

	private string pathImage;

	public T98(string strFont, string pathImage, string pathData, int space)
	{
		try
		{
			this.strFont = strFont;
			this.space = space;
			this.pathImage = pathImage;
			T28 t = null;
			M915();
			try
			{
				t = T116.M1110(pathData);
				fImages = new int[t.M353()][];
				for (int i = 0; i < fImages.Length; i++)
				{
					fImages[i] = new int[4];
					fImages[i][0] = t.M353();
					fImages[i][1] = t.M353();
					fImages[i][2] = t.M353();
					fImages[i][3] = t.M353();
					M892(fImages[i][3]);
				}
				t.M357();
			}
			catch (Exception)
			{
				try
				{
					t.M357();
				}
				catch (Exception ex)
				{
					ex.StackTrace.ToString();
				}
			}
		}
		catch (Exception ex3)
		{
			ex3.StackTrace.ToString();
		}
	}

	public T98(sbyte id)
	{
		string text = "chelthm";
		if ((id > 0 && id < 10) || id == 19)
		{
			yAdd = 1;
			text = "barmeneb";
		}
		else if (id >= 10 && id <= 18)
		{
			text = "chelthm";
			yAdd = 2;
		}
		else if (id > 24)
		{
			text = "staccato";
		}
		this.id = id;
		myFont = (Font)Resources.Load("FontSys/x" + T99.zoomLevel + "/" + text);
		if (id < 25)
		{
			color1 = M897(id);
			color2 = M897(id);
		}
		else
		{
			color1 = M894(id);
			color2 = M894(id);
		}
		wO = M910("o");
	}

	public static void M891()
	{
		if (T99.zoomLevel == 1)
		{
			tahoma_7b_red = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_red.png", "/myfont/tahoma_7b", 0);
			tahoma_7b_blue = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_blue.png", "/myfont/tahoma_7b", 0);
			tahoma_7b_white = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_white.png", "/myfont/tahoma_7b", 0);
			tahoma_7b_yellow = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_yellow.png", "/myfont/tahoma_7b", 0);
			tahoma_7b_yellowSmall = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_yellow.png", "/myfont/tahoma_7b", 0);
			tahoma_7b_dark = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_brown.png", "/myfont/tahoma_7b", 0);
			tahoma_7b_green2 = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_green2.png", "/myfont/tahoma_7b", 0);
			tahoma_7b_green = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_green.png", "/myfont/tahoma_7b", 0);
			tahoma_7b_focus = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_focus.png", "/myfont/tahoma_7b", 0);
			tahoma_7b_unfocus = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_unfocus.png", "/myfont/tahoma_7b", 0);
			tahoma_7 = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7.png", "/myfont/tahoma_7", 0);
			tahoma_7_blue1 = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_blue1.png", "/myfont/tahoma_7", 0);
			tahoma_7_green2 = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_green2.png", "/myfont/tahoma_7", 0);
			tahoma_7_yellow = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_yellow.png", "/myfont/tahoma_7", 0);
			tahoma_7_grey = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_grey.png", "/myfont/tahoma_7", 0);
			tahoma_7_red = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_red.png", "/myfont/tahoma_7", 0);
			tahoma_7_blue = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_blue.png", "/myfont/tahoma_7", 0);
			tahoma_7_green = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_green.png", "/myfont/tahoma_7", 0);
			tahoma_7_white = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_white.png", "/myfont/tahoma_7", 0);
			tahoma_8b = new T98(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_8b.png", "/myfont/tahoma_8b", -1);
			number_yellow = new T98(" 0123456789+-", "/myfont/number_yellow.png", "/myfont/number", 0);
			number_red = new T98(" 0123456789+-", "/myfont/number_red.png", "/myfont/number", 0);
			number_green = new T98(" 0123456789+-", "/myfont/number_green.png", "/myfont/number", 0);
			number_gray = new T98(" 0123456789+-", "/myfont/number_gray.png", "/myfont/number", 0);
			number_orange = new T98(" 0123456789+-", "/myfont/number_orange.png", "/myfont/number", 0);
			bigNumber_red = number_red;
			bigNumber_While = tahoma_7b_white;
			bigNumber_yellow = number_yellow;
			bigNumber_green = number_green;
			bigNumber_orange = number_orange;
			bigNumber_blue = tahoma_7_blue1;
			nameFontRed = tahoma_7_red;
			nameFontYellow = tahoma_7_yellow;
			nameFontGreen = tahoma_7_green;
			tahoma_7_greySmall = tahoma_7_grey;
			tahoma_7b_yellowSmall2 = tahoma_7_yellow;
			tahoma_7b_green2Small = tahoma_7b_green2;
			tahoma_7_whiteSmall = tahoma_7_white;
			tahoma_7b_greenSmall = tahoma_7b_green;
			tahoma_7_blue1Small = tahoma_7_blue1;
			return;
		}
		gI = new T98(0);
		tahoma_7b_red = new T98(1);
		tahoma_7b_blue = new T98(2);
		tahoma_7b_white = new T98(3);
		tahoma_7b_yellow = new T98(4);
		tahoma_7b_yellowSmall = new T98(4);
		tahoma_7b_dark = new T98(5);
		tahoma_7b_green2 = new T98(6);
		tahoma_7b_green = new T98(7);
		tahoma_7b_focus = new T98(8);
		tahoma_7b_unfocus = new T98(9);
		tahoma_7 = new T98(10);
		tahoma_7_blue1 = new T98(11);
		tahoma_7_blue1Small = tahoma_7_blue1;
		tahoma_7_green2 = new T98(12);
		tahoma_7_yellow = new T98(13);
		tahoma_7_grey = new T98(14);
		tahoma_7_red = new T98(15);
		tahoma_7_blue = new T98(16);
		tahoma_7_green = new T98(17);
		tahoma_7_white = new T98(18);
		tahoma_8b = new T98(19);
		number_yellow = new T98(20);
		number_red = new T98(21);
		number_green = new T98(22);
		number_gray = new T98(23);
		number_orange = new T98(24);
		bigNumber_red = new T98(25);
		bigNumber_yellow = new T98(26);
		bigNumber_green = new T98(27);
		bigNumber_While = new T98(28);
		bigNumber_blue = new T98(29);
		bigNumber_orange = new T98(30);
		bigNumber_black = new T98(31);
		nameFontRed = tahoma_7b_red;
		nameFontYellow = tahoma_7_yellow;
		nameFontGreen = tahoma_7_green;
		tahoma_7_greySmall = tahoma_7_grey;
		tahoma_7b_yellowSmall2 = tahoma_7_yellow;
		tahoma_7b_green2Small = tahoma_7b_green2;
		tahoma_7_whiteSmall = tahoma_7_white;
		tahoma_7b_greenSmall = tahoma_7b_green;
		yAddFont = 1;
		if (T99.zoomLevel == 1)
		{
			yAddFont = -3;
		}
	}

	public void M892(int height)
	{
		this.height = height;
	}

	public Color M893(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float b = (float)num / 256f;
		float g = (float)num2 / 256f;
		return new Color((float)num3 / 256f, g, b);
	}

	public Color M894(int id)
	{
		return (new Color[7]
		{
			Color.red,
			Color.yellow,
			Color.green,
			Color.white,
			M893(40404),
			Color.red,
			Color.black
		})[id - 25];
	}

	public void M895(int ID)
	{
		color1 = M893(colorJava[ID]);
		color2 = M893(colorJava[ID]);
	}

	public void M896(T99 g, string st, int x, int y, int align, sbyte idFont)
	{
		sbyte iD = id;
		if (idFont > 0)
		{
			iD = idFont;
		}
		x--;
		if (id > 24)
		{
			Color[] array = new Color[6]
			{
				M893(6029312),
				M893(7169025),
				M893(7680),
				M893(0),
				M893(9264),
				M893(6029312)
			};
			color1 = array[id - 25];
			color2 = array[id - 25];
			M913(g, st, x + 1, y, align);
			M913(g, st, x - 1, y, align);
			M913(g, st, x, y - 1, align);
			M913(g, st, x, y + 1, align);
			M913(g, st, x + 1, y + 1, align);
			M913(g, st, x + 1, y - 1, align);
			M913(g, st, x - 1, y - 1, align);
			M913(g, st, x - 1, y + 1, align);
			color1 = M894(id);
			color2 = M894(id);
		}
		else
		{
			M895(iD);
		}
		M913(g, st, x, y - yAdd, align);
	}

	public Color M897(sbyte id)
	{
		return M893(colorJava[id]);
	}

	public void M898(T99 g, string st, int x, int y, int align)
	{
		if (T99.zoomLevel == 1)
		{
			int length = st.Length;
			int num = align switch
			{
				1 => x - M909(st), 
				0 => x, 
				_ => x - (M909(st) >> 1), 
			};
			for (int i = 0; i < length; i++)
			{
				int num2 = strFont.IndexOf(st[i] + string.Empty);
				if (num2 == -1)
				{
					num2 = 0;
				}
				if (num2 > -1)
				{
					int x2 = fImages[num2][0];
					int num3 = fImages[num2][1];
					int w = fImages[num2][2];
					int num4 = fImages[num2][3];
					if (num3 + num4 > imgFont.texture.height)
					{
						num3 -= imgFont.texture.height;
						x2 = imgFont.texture.width / 2;
					}
					g.M940(imgFont, x2, num3, w, num4, 0, num, y, 20);
				}
				num += fImages[num2][2] + space;
			}
		}
		else
		{
			M896(g, st, x, y, align, 0);
		}
	}

	public void M899(T99 g, string st, int x, int y, int align)
	{
		if (T99.zoomLevel == 1)
		{
			M898(g, st, x, y, align);
		}
		else
		{
			M896(g, st, x, y, align, 0);
		}
	}

	public void M900(T99 g, string st, int x, int y, int align, T98 font2)
	{
		if (T99.zoomLevel == 1)
		{
			M902(g, st, x, y, align, font2);
		}
		else
		{
			M901(g, st, x, y, align, font2);
		}
	}

	public void M901(T99 g, string st, int x, int y, int align, T98 font)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M896(g, st, x - 1, y - 1, align, 0);
		M896(g, st, x - 1, y + 1, align, 0);
		M896(g, st, x + 1, y - 1, align, 0);
		M896(g, st, x + 1, y + 1, align, 0);
		M896(g, st, x, y - 1, align, 0);
		M896(g, st, x, y + 1, align, 0);
		M896(g, st, x + 1, y, align, 0);
		M896(g, st, x - 1, y, align, 0);
		M896(g, st, x, y, align, 0);
	}

	public void M902(T99 g, string st, int x, int y, int align, T98 font)
	{
		if (T99.zoomLevel == 1)
		{
			int length = st.Length;
			int num = align switch
			{
				1 => x - M909(st), 
				0 => x, 
				_ => x - (M909(st) >> 1), 
			};
			for (int i = 0; i < length; i++)
			{
				int num2 = strFont.IndexOf(st[i]);
				if (num2 == -1)
				{
					num2 = 0;
				}
				if (num2 > -1)
				{
					int x2 = fImages[num2][0];
					int num3 = fImages[num2][1];
					int w = fImages[num2][2];
					int num4 = fImages[num2][3];
					if (num3 + num4 > imgFont.texture.height)
					{
						num3 -= imgFont.texture.height;
						x2 = imgFont.texture.width / 2;
					}
					if (!T51.lowGraphic && font != null)
					{
						g.M940(font.imgFont, x2, num3, w, num4, 0, num + 1, y, 20);
						g.M940(font.imgFont, x2, num3, w, num4, 0, num, y + 1, 20);
					}
					g.M940(imgFont, x2, num3, w, num4, 0, num, y, 20);
				}
				num += fImages[num2][2] + space;
			}
		}
		else
		{
			M896(g, st, x, y + 1, align, font.id);
			M896(g, st, x, y, align, 0);
		}
	}

	public T117 M903(string src, int lineWidth)
	{
		T117 t = new T117();
		string text = string.Empty;
		for (int i = 0; i < src.Length; i++)
		{
			if (src[i] != '\n' && src[i] != '\b')
			{
				text += src[i];
				if (M909(text) > lineWidth)
				{
					int num = 0;
					num = text.Length - 1;
					while (num >= 0 && text[num] != ' ')
					{
						num--;
					}
					if (num < 0)
					{
						num = text.Length - 1;
					}
					t.M1111(text.Substring(0, num));
					i = i - (text.Length - num) + 1;
					text = string.Empty;
				}
				if (i == src.Length - 1 && !text.Trim().Equals(string.Empty))
				{
					t.M1111(text);
				}
			}
			else
			{
				t.M1111(text);
				text = string.Empty;
			}
		}
		return t;
	}

	public string M904(string str)
	{
		string text = string.Empty;
		bool flag = false;
		for (int i = 0; i < str.Length; i++)
		{
			if (!flag)
			{
				string text2 = str.Substring(i);
				text = ((!M908(text2, " ")) ? (text + text2) : (text + str[i] + "-"));
				flag = true;
			}
			else if (str[i] == ' ')
			{
				flag = false;
			}
		}
		return text;
	}

	public string[] M905(string src, int lineWidth)
	{
		ArrayList arrayList = M906(src, lineWidth);
		string[] array = new string[arrayList.Count];
		for (int i = 0; i < arrayList.Count; i++)
		{
			array[i] = (string)arrayList[i];
		}
		return array;
	}

	public ArrayList M906(string src, int lineWidth)
	{
		ArrayList arrayList = new ArrayList();
		int i = 0;
		int num = 0;
		int length = src.Length;
		if (length < 5)
		{
			arrayList.Add(src);
			return arrayList;
		}
		string text = string.Empty;
		try
		{
			while (true)
			{
				if (M911(text) < lineWidth)
				{
					text += src[num];
					num++;
					if (src[num] != '\n')
					{
						if (num < length - 1)
						{
							continue;
						}
						num = length - 1;
					}
				}
				if (num != length - 1 && src[num + 1] != ' ')
				{
					int num2 = num;
					while (src[num + 1] != '\n' && (src[num + 1] != ' ' || src[num] == ' ') && num != i)
					{
						num--;
					}
					if (num == i)
					{
						num = num2;
					}
				}
				string text2 = src.Substring(i, num + 1 - i);
				if (text2[0] == '\n')
				{
					text2 = text2.Substring(1, text2.Length - 1);
				}
				if (text2[text2.Length - 1] == '\n')
				{
					text2 = text2.Substring(0, text2.Length - 1);
				}
				arrayList.Add(text2);
				if (num == length - 1)
				{
					break;
				}
				for (i = num + 1; i != length - 1 && src[i] == ' '; i++)
				{
				}
				if (i != length - 1)
				{
					num = i;
					text = string.Empty;
					continue;
				}
				return arrayList;
			}
			return arrayList;
		}
		catch (Exception ex)
		{
			T24.M331("EXCEPTION WHEN REAL SPLIT " + src + "\nend=" + num + "\n" + ex.Message + "\n" + ex.StackTrace);
			arrayList.Add(src);
			return arrayList;
		}
	}

	public string[] M907(string src, int lineWidth)
	{
		T117 t = M903(src, lineWidth);
		string[] array = new string[t.M1113()];
		for (int i = 0; i < t.M1113(); i++)
		{
			array[i] = (string)t.M1114(i);
		}
		return array;
	}

	public bool M908(string strSource, string str)
	{
		for (int i = 0; i < strSource.Length; i++)
		{
			if ((string.Empty + strSource[i]).Equals(str))
			{
				return true;
			}
		}
		return false;
	}

	public int M909(string s)
	{
		if (T99.zoomLevel == 1)
		{
			int num = 0;
			for (int i = 0; i < s.Length; i++)
			{
				int num2 = strFont.IndexOf(s[i]);
				if (num2 == -1)
				{
					num2 = 0;
				}
				num += fImages[num2][2] + space;
			}
			return num;
		}
		return M910(s);
	}

	public int M910(string s)
	{
		try
		{
			return (int)new GUIStyle
			{
				font = myFont
			}.CalcSize(new GUIContent(s)).x / T99.zoomLevel;
		}
		catch (Exception ex)
		{
			T24.M328("GET WIDTH OF " + s + " FAIL.\n" + ex.Message + "\n" + ex.StackTrace);
			return M911(s);
		}
	}

	public int M911(string s)
	{
		return s.Length * wO / T99.zoomLevel;
	}

	public int M912()
	{
		if (T99.zoomLevel == 1)
		{
			return height;
		}
		if (height > 0)
		{
			return height / T99.zoomLevel;
		}
		GUIStyle gUIStyle = new GUIStyle();
		gUIStyle.font = myFont;
		try
		{
			height = (int)gUIStyle.CalcSize(new GUIContent("Adg")).y + 2;
		}
		catch (Exception ex)
		{
			T24.M328("FAIL GET HEIGHT " + ex.StackTrace);
			height = 20;
		}
		return height / T99.zoomLevel;
	}

	public void M913(T99 g, string st, int x0, int y0, int align)
	{
		y0 += yAddFont;
		GUIStyle gUIStyle = new GUIStyle(GUI.skin.label);
		gUIStyle.font = myFont;
		float num = 0f;
		float num2 = 0f;
		switch (align)
		{
		case 0:
			num = x0;
			num2 = y0;
			gUIStyle.alignment = TextAnchor.UpperLeft;
			break;
		case 1:
			num = x0 - T51.w;
			num2 = y0;
			gUIStyle.alignment = TextAnchor.UpperRight;
			break;
		case 2:
		case 3:
			num = x0 - T51.w / 2;
			num2 = y0;
			gUIStyle.alignment = TextAnchor.UpperCenter;
			break;
		}
		gUIStyle.normal.textColor = color1;
		g.M936(st, (int)num, (int)num2, gUIStyle);
	}

	public static string[] M914(string _text, string _searchStr)
	{
		int num = 0;
		int length = _searchStr.Length;
		int num2 = _text.IndexOf(_searchStr, 0);
		while (num2 != -1)
		{
			num2 = _text.IndexOf(_searchStr, num2 + length);
			num++;
		}
		string[] array = new string[num + 1];
		int num3 = _text.IndexOf(_searchStr);
		int num4 = 0;
		int num5 = 0;
		while (num3 != -1)
		{
			array[num5] = _text.Substring(num4, num3 - num4);
			num4 = num3 + length;
			num3 = _text.IndexOf(_searchStr, num4);
			num5++;
		}
		array[num5] = _text.Substring(num4, _text.Length - num4);
		return array;
	}

	public void M915()
	{
		if (T99.zoomLevel == 1)
		{
			imgFont = T51.M503(pathImage);
		}
	}

	public void M916()
	{
	}
}
