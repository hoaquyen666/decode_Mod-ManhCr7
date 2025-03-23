using System;
using System.Collections;
using N5.N6.N9;
using UnityEngine;

public class T99
{
	public static int HCENTER = 1;

	public static int VCENTER = 2;

	public static int LEFT = 4;

	public static int RIGHT = 8;

	public static int TOP = 16;

	public static int BOTTOM = 32;

	private float r;

	private float g;

	private float b;

	private float a;

	public int clipX;

	public int clipY;

	public int clipW;

	public int clipH;

	private bool isClip;

	private bool isTranslate = true;

	private int translateX;

	private int translateY;

	private float translateXf;

	private float translateYf;

	public static int zoomLevel = 1;

	public const int BASELINE = 64;

	public const int SOLID = 0;

	public const int DOTTED = 1;

	public const int TRANS_MIRROR = 2;

	public const int TRANS_MIRROR_ROT180 = 1;

	public const int TRANS_MIRROR_ROT270 = 4;

	public const int TRANS_MIRROR_ROT90 = 7;

	public const int TRANS_NONE = 0;

	public const int TRANS_ROT180 = 3;

	public const int TRANS_ROT270 = 6;

	public const int TRANS_ROT90 = 5;

	public static Hashtable cachedTextures = new Hashtable();

	public static int addYWhenOpenKeyBoard;

	private int clipTX;

	private int clipTY;

	private int currentBGColor;

	private Vector2 pos = new Vector2(0f, 0f);

	private Rect rect;

	private Matrix4x4 matrixBackup;

	private Vector2 pivot;

	public Vector2 size = new Vector2(128f, 128f);

	public Vector2 relativePosition = new Vector2(0f, 0f);

	public Color clTrans;

	public static Color transParentColor = new Color(1f, 1f, 1f, 0f);

	private Material lineMaterial;

	private void M917(string key, Texture value)
	{
		if (cachedTextures.Count > 400)
		{
			cachedTextures.Clear();
		}
		if (value.width * value.height < T51.w * T51.h)
		{
			cachedTextures.Add(key, value);
		}
	}

	public void M918(int tx, int ty)
	{
		tx *= zoomLevel;
		ty *= zoomLevel;
		translateX += tx;
		translateY += ty;
		isTranslate = true;
		if (translateX == 0 && translateY == 0)
		{
			isTranslate = false;
		}
	}

	public void M919(float x, float y)
	{
		translateXf += x;
		translateYf += y;
		isTranslate = true;
		if (translateXf == 0f && translateYf == 0f)
		{
			isTranslate = false;
		}
	}

	public int M920()
	{
		return translateX / zoomLevel;
	}

	public int M921()
	{
		return translateY / zoomLevel + addYWhenOpenKeyBoard;
	}

	public void M922(int x, int y, int w, int h)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		x *= zoomLevel;
		y *= zoomLevel;
		w *= zoomLevel;
		h *= zoomLevel;
		clipTX = translateX;
		clipTY = translateY;
		clipX = x;
		clipY = y;
		clipW = w;
		clipH = h;
		isClip = true;
	}

	public int M923()
	{
		return T54.cmx;
	}

	public int M924()
	{
		return T54.cmy;
	}

	public int M925()
	{
		return T54.gW;
	}

	public int M926()
	{
		return T54.gH;
	}

	public void M927(int x, int y, int w, int h, int color, int alpha)
	{
		M937(color, 0.5f);
		M932(x, y, w, h);
	}

	public void M928(int x1, int y1, int x2, int y2)
	{
		x1 *= zoomLevel;
		y1 *= zoomLevel;
		x2 *= zoomLevel;
		y2 *= zoomLevel;
		if (y1 == y2)
		{
			if (x1 > x2)
			{
				int num = x2;
				x2 = x1;
				x1 = num;
			}
			M932(x1, y1, x2 - x1, 1);
			return;
		}
		if (x1 == x2)
		{
			if (y1 > y2)
			{
				int num2 = y2;
				y2 = y1;
				y1 = num2;
			}
			M932(x1, y1, 1, y2 - y1);
			return;
		}
		if (isTranslate)
		{
			x1 += translateX;
			y1 += translateY;
			x2 += translateX;
			y2 += translateY;
		}
		string key = "dl" + r + g + b;
		Texture2D texture2D = (Texture2D)cachedTextures[key];
		if (texture2D == null)
		{
			texture2D = new Texture2D(1, 1);
			texture2D.SetPixel(0, 0, new Color(r, g, b));
			texture2D.Apply();
			M917(key, texture2D);
		}
		Vector2 vector = new Vector2(x1, y1);
		Vector2 vector2 = new Vector2(x2, y2) - vector;
		float num3 = 57.29578f * Mathf.Atan(vector2.y / vector2.x);
		if (vector2.x < 0f)
		{
			num3 += 180f;
		}
		int num4 = (int)Mathf.Ceil(0f);
		GUIUtility.RotateAroundPivot(num3, vector);
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		if (isClip)
		{
			num5 = clipX;
			num6 = clipY;
			num7 = clipW;
			num8 = clipH;
			if (isTranslate)
			{
				num5 += clipTX;
				num6 += clipTY;
			}
		}
		if (isClip)
		{
			GUI.BeginGroup(new Rect(num5, num6, num7, num8));
		}
		Graphics.DrawTexture(new Rect(vector.x - (float)num5, vector.y - (float)num4 - (float)num6, vector2.magnitude, 1f), texture2D);
		if (isClip)
		{
			GUI.EndGroup();
		}
		GUIUtility.RotateAroundPivot(0f - num3, vector);
	}

	public Color M929(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float num4 = (float)num / 256f;
		float num5 = (float)num2 / 256f;
		return new Color((float)num3 / 256f, num5, num4);
	}

	public float[] M930(Color cl)
	{
		float num = 256f * cl.r;
		float num2 = 256f * cl.g;
		float num3 = 256f * cl.b;
		return new float[3] { num, num2, num3 };
	}

	public void M931(int x, int y, int w, int h)
	{
		M932(x, y, w, 1);
		M932(x, y, 1, h);
		M932(x + w, y, 1, h + 1);
		M932(x, y + h, w + 1, 1);
	}

	public void M932(int x, int y, int w, int h)
	{
		x *= zoomLevel;
		y *= zoomLevel;
		w *= zoomLevel;
		h *= zoomLevel;
		if (w < 0 || h < 0)
		{
			return;
		}
		if (isTranslate)
		{
			x += translateX;
			y += translateY;
		}
		int width = 1;
		int height = 1;
		string key = "fr" + 1 + 1 + r + g + b + a;
		Texture2D texture2D = (Texture2D)cachedTextures[key];
		if (texture2D == null)
		{
			texture2D = new Texture2D(width, height);
			texture2D.SetPixel(0, 0, new Color(r, g, b, a));
			texture2D.Apply();
			M917(key, texture2D);
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (isClip)
		{
			num = clipX;
			num2 = clipY;
			num3 = clipW;
			num4 = clipH;
			if (isTranslate)
			{
				num += clipTX;
				num2 += clipTY;
			}
		}
		if (isClip)
		{
			GUI.BeginGroup(new Rect(num, num2, num3, num4));
		}
		GUI.DrawTexture(new Rect(x - num, y - num2, w, h), texture2D);
		if (isClip)
		{
			GUI.EndGroup();
		}
	}

	public void M933(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		b = (float)num / 256f;
		g = (float)num2 / 256f;
		r = (float)num3 / 256f;
		a = 255f;
	}

	public void M934(Color color)
	{
		b = color.b;
		g = color.g;
		r = color.r;
		a = color.a;
	}

	public void M935(int rgb)
	{
		if (rgb != currentBGColor)
		{
			currentBGColor = rgb;
			int num = rgb & 0xFF;
			int num2 = (rgb >> 8) & 0xFF;
			int num3 = (rgb >> 16) & 0xFF;
			b = (float)num / 256f;
			g = (float)num2 / 256f;
			r = (float)num3 / 256f;
			Main.main.GetComponent<Camera>().backgroundColor = new Color(r, g, b);
		}
	}

	public void M936(string s, int x, int y, GUIStyle style)
	{
		x *= zoomLevel;
		y *= zoomLevel;
		if (isTranslate)
		{
			x += translateX;
			y += translateY;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (isClip)
		{
			num = clipX;
			num2 = clipY;
			num3 = clipW;
			num4 = clipH;
			if (isTranslate)
			{
				num += clipTX;
				num2 += clipTY;
			}
		}
		if (isClip)
		{
			GUI.BeginGroup(new Rect(num, num2, num3, num4));
		}
		GUI.Label(new Rect(x - num, y - num2, T139.WIDTH, 100f), s, style);
		if (isClip)
		{
			GUI.EndGroup();
		}
	}

	public void M937(int rgb, float alpha)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		b = (float)num / 256f;
		g = (float)num2 / 256f;
		r = (float)num3 / 256f;
		a = alpha;
	}

	public void M938(string s, int x, int y, GUIStyle style, int w)
	{
		x *= zoomLevel;
		y *= zoomLevel;
		if (isTranslate)
		{
			x += translateX;
			y += translateY;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (isClip)
		{
			num = clipX;
			num2 = clipY;
			num3 = clipW;
			num4 = clipH;
			if (isTranslate)
			{
				num += clipTX;
				num2 += clipTY;
			}
		}
		if (isClip)
		{
			GUI.BeginGroup(new Rect(num, num2, num3, num4));
		}
		GUI.Label(new Rect(x - num, y - num2 - 4, w, 100f), s, style);
		if (isClip)
		{
			GUI.EndGroup();
		}
	}

	private void M939(int anchor)
	{
		Vector2 vector = new Vector2(0f, 0f);
		switch (anchor)
		{
		case 6:
			vector = new Vector2(0f, Screen.height / 2);
			break;
		case 3:
			vector = new Vector2(size.x / 2f, size.y / 2f);
			break;
		case 17:
			vector = new Vector2(Screen.width / 2, 0f);
			break;
		case 10:
			vector = new Vector2(Screen.width, Screen.height / 2);
			break;
		case 24:
			vector = new Vector2(Screen.width, 0f);
			break;
		case 20:
			vector = new Vector2(0f, 0f);
			break;
		case 40:
			vector = new Vector2(Screen.width, Screen.height);
			break;
		case 36:
			vector = new Vector2(0f, Screen.height);
			break;
		case 33:
			vector = new Vector2(Screen.width / 2, Screen.height);
			break;
		}
		pos = vector + relativePosition;
		rect = new Rect(pos.x - size.x * 0.5f, pos.y - size.y * 0.5f, size.x, size.y);
		pivot = new Vector2(rect.xMin + rect.width * 0.5f, rect.yMin + rect.height * 0.5f);
	}

	public void M940(T60 arg0, int x0, int y0, int w0, int h0, int arg5, int x, int y, int arg8)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		x *= zoomLevel;
		y *= zoomLevel;
		x0 *= zoomLevel;
		y0 *= zoomLevel;
		w0 *= zoomLevel;
		h0 *= zoomLevel;
		M944(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
	}

	public void M941(T60 arg0, int x0, int y0, int w0, int h0, int arg5, float x, float y, int arg8)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		x *= (float)zoomLevel;
		y *= (float)zoomLevel;
		x0 *= zoomLevel;
		y0 *= zoomLevel;
		w0 *= zoomLevel;
		h0 *= zoomLevel;
		M943(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
	}

	public void M942(T60 arg0, int x0, int y0, int w0, int h0, int arg5, int x, int y, int arg8, bool isClip)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		M940(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
	}

	public void M943(T60 image, int x0, int y0, int w, int h, int transform, float x, float y, int anchor)
	{
		if (image == null)
		{
			return;
		}
		if (isTranslate)
		{
			x += (float)translateX;
			y += (float)translateY;
		}
		float num = w;
		float num2 = h;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		float num7 = 1f;
		float num8 = 0f;
		int num9 = 1;
		if ((anchor & HCENTER) == HCENTER)
		{
			num5 -= num / 2f;
		}
		if ((anchor & VCENTER) == VCENTER)
		{
			num6 -= num2 / 2f;
		}
		if ((anchor & RIGHT) == RIGHT)
		{
			num5 -= num;
		}
		if ((anchor & BOTTOM) == BOTTOM)
		{
			num6 -= num2;
		}
		x += num5;
		y += num6;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		if (isClip)
		{
			num10 = clipX;
			num11 = clipY;
			num12 = clipW;
			num13 = clipH;
			if (isTranslate)
			{
				num10 += clipTX;
				num11 += clipTY;
			}
			Rect r = new Rect(x, y, w, h);
			Rect rect = M955(r2: new Rect(num10, num11, num12, num13), r1: r);
			if (rect.width <= 0f || !(rect.height > 0f))
			{
				return;
			}
			num = rect.width;
			num2 = rect.height;
			num3 = rect.x - r.x;
			num4 = rect.y - r.y;
		}
		float num14 = 0f;
		float num15 = 0f;
		switch (transform)
		{
		case 1:
			num9 = -1;
			num15 += num2;
			break;
		case 2:
			num14 += num;
			num7 = -1f;
			if (isClip)
			{
				if ((float)num10 > x)
				{
					num8 = 0f - num3;
				}
				else if ((float)(num10 + num12) < x + (float)w)
				{
					num8 = 0f - ((float)(num10 + num12) - x - (float)w);
				}
			}
			break;
		case 3:
			num9 = -1;
			num15 += num2;
			num7 = -1f;
			num14 += num;
			break;
		}
		int num16 = 0;
		int num17 = 0;
		if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
		{
			matrixBackup = GUI.matrix;
			size = new Vector2(w, h);
			relativePosition = new Vector2(x, y);
			M939(3);
			switch (transform)
			{
			case 6:
				M939(3);
				break;
			case 5:
				size = new Vector2(w, h);
				M939(3);
				break;
			}
			switch (transform)
			{
			case 4:
				GUIUtility.RotateAroundPivot(270f, pivot);
				num14 += num;
				num7 = -1f;
				if (isClip)
				{
					if ((float)num10 > x)
					{
						num8 = 0f - num3;
					}
					else if ((float)(num10 + num12) < x + (float)w)
					{
						num8 = 0f - ((float)(num10 + num12) - x - (float)w);
					}
				}
				break;
			case 5:
				GUIUtility.RotateAroundPivot(90f, pivot);
				break;
			case 6:
				GUIUtility.RotateAroundPivot(270f, pivot);
				break;
			case 7:
				GUIUtility.RotateAroundPivot(270f, pivot);
				num9 = -1;
				num15 += num2;
				break;
			}
		}
		Graphics.DrawTexture(new Rect(x + num3 + num14 + (float)num16, y + num4 + (float)num17 + num15, num * num7, num2 * (float)num9), image.texture, new Rect(((float)x0 + num3 + num8) / (float)image.texture.width, ((float)image.texture.height - num2 - ((float)y0 + num4)) / (float)image.texture.height, num / (float)image.texture.width, num2 / (float)image.texture.height), 0, 0, 0, 0);
		if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
		{
			GUI.matrix = matrixBackup;
		}
	}

	public void M944(T60 image, float x0, float y0, int w, int h, int transform, int x, int y, int anchor)
	{
		if (image == null)
		{
			return;
		}
		if (isTranslate)
		{
			x += translateX;
			y += translateY;
		}
		float num = w;
		float num2 = h;
		float num3 = 0f;
		float num4 = 0f;
		float num5 = 0f;
		float num6 = 0f;
		float num7 = 1f;
		float num8 = 0f;
		int num9 = 1;
		if ((anchor & HCENTER) == HCENTER)
		{
			num5 -= num / 2f;
		}
		if ((anchor & VCENTER) == VCENTER)
		{
			num6 -= num2 / 2f;
		}
		if ((anchor & RIGHT) == RIGHT)
		{
			num5 -= num;
		}
		if ((anchor & BOTTOM) == BOTTOM)
		{
			num6 -= num2;
		}
		x += (int)num5;
		y += (int)num6;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		if (isClip)
		{
			num10 = clipX;
			num11 = clipY;
			num12 = clipW;
			num13 = clipH;
			if (isTranslate)
			{
				num10 += clipTX;
				num11 += clipTY;
			}
			Rect r = new Rect(x, y, w, h);
			Rect rect = M955(r2: new Rect(num10, num11, num12, num13), r1: r);
			if (rect.width <= 0f || !(rect.height > 0f))
			{
				return;
			}
			num = rect.width;
			num2 = rect.height;
			num3 = rect.x - r.x;
			num4 = rect.y - r.y;
		}
		float num14 = 0f;
		float num15 = 0f;
		switch (transform)
		{
		case 1:
			num9 = -1;
			num15 += num2;
			break;
		case 2:
			num14 += num;
			num7 = -1f;
			if (isClip)
			{
				if (num10 > x)
				{
					num8 = 0f - num3;
				}
				else if (num10 + num12 < x + w)
				{
					num8 = -(num10 + num12 - x - w);
				}
			}
			break;
		case 3:
			num9 = -1;
			num15 += num2;
			num7 = -1f;
			num14 += num;
			break;
		}
		int num16 = 0;
		int num17 = 0;
		if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
		{
			matrixBackup = GUI.matrix;
			size = new Vector2(w, h);
			relativePosition = new Vector2(x, y);
			M939(3);
			switch (transform)
			{
			case 6:
				M939(3);
				break;
			case 5:
				size = new Vector2(w, h);
				M939(3);
				break;
			}
			switch (transform)
			{
			case 4:
				GUIUtility.RotateAroundPivot(270f, pivot);
				num14 += num;
				num7 = -1f;
				if (isClip)
				{
					if (num10 > x)
					{
						num8 = 0f - num3;
					}
					else if (num10 + num12 < x + w)
					{
						num8 = -(num10 + num12 - x - w);
					}
				}
				break;
			case 5:
				GUIUtility.RotateAroundPivot(90f, pivot);
				break;
			case 6:
				GUIUtility.RotateAroundPivot(270f, pivot);
				break;
			case 7:
				GUIUtility.RotateAroundPivot(270f, pivot);
				num9 = -1;
				num15 += num2;
				break;
			}
		}
		Graphics.DrawTexture(new Rect((float)x + num3 + num14 + (float)num16, (float)y + num4 + (float)num17 + num15, num * num7, num2 * (float)num9), image.texture, new Rect((x0 + num3 + num8) / (float)image.texture.width, ((float)image.texture.height - num2 - (y0 + num4)) / (float)image.texture.height, num / (float)image.texture.width, num2 / (float)image.texture.height), 0, 0, 0, 0);
		if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
		{
			GUI.matrix = matrixBackup;
		}
	}

	public void M945(T60 image, float x0, float y0, int w, int h, int transform, float x, float y, int anchor)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		GUI.color = M929(807956);
		x *= (float)zoomLevel;
		y *= (float)zoomLevel;
		x0 *= (float)zoomLevel;
		y0 *= (float)zoomLevel;
		w *= zoomLevel;
		h *= zoomLevel;
	}

	public void M946(T60 image, float x0, float y0, int w, int h, int transform, int x, int y, int anchor)
	{
		GUI.color = image.colorBlend;
		if (isTranslate)
		{
			x += translateX;
			y += translateY;
		}
		string key = "dg" + x0 + y0 + w + h + transform + image.GetHashCode();
		Texture2D texture2D = (Texture2D)cachedTextures[key];
		if (texture2D == null)
		{
			texture2D = T60.M705(image, (int)x0, (int)y0, w, h, transform).texture;
			M917(key, texture2D);
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		float num5 = w;
		float num6 = h;
		float num7 = 0f;
		float num8 = 0f;
		if ((anchor & HCENTER) == HCENTER)
		{
			num7 -= num5 / 2f;
		}
		if ((anchor & VCENTER) == VCENTER)
		{
			num8 -= num6 / 2f;
		}
		if ((anchor & RIGHT) == RIGHT)
		{
			num7 -= num5;
		}
		if ((anchor & BOTTOM) == BOTTOM)
		{
			num8 -= num6;
		}
		x += (int)num7;
		y += (int)num8;
		if (isClip)
		{
			num = clipX;
			num2 = clipY;
			num3 = clipW;
			num4 = clipH;
			if (isTranslate)
			{
				num += clipTX;
				num2 += clipTY;
			}
		}
		if (isClip)
		{
			GUI.BeginGroup(new Rect(num, num2, num3, num4));
		}
		GUI.DrawTexture(new Rect(x - num, y - num2, w, h), texture2D);
		if (isClip)
		{
			GUI.EndGroup();
		}
		GUI.color = new Color(1f, 1f, 1f, 1f);
	}

	public void M947(T60 image, float x, float y)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		x *= (float)zoomLevel;
		y *= (float)zoomLevel;
		GUI.DrawTexture(new Rect(x + (float)translateX, y + (float)translateY, image.M732(), image.M733()), image.texture);
	}

	public void M948(T60 image, int x, int y, int anchor)
	{
		if (image != null)
		{
			M940(image, 0, 0, M958(image), M959(image), 0, x, y, anchor);
		}
	}

	public void M949(T60 image, int x, int y, int anchor)
	{
		if (image != null)
		{
			M940(image, 0, 0, image.texture.width, image.texture.height, 0, x, y, anchor);
		}
	}

	public void M950(T60 image, int x, int y)
	{
		if (image != null)
		{
			M940(image, 0, 0, M958(image), M959(image), 0, x, y, TOP | LEFT);
		}
	}

	public void M951(T60 image, float x, float y, int anchor)
	{
		if (image != null)
		{
			M941(image, 0, 0, M958(image), M959(image), 0, x, y, anchor);
		}
	}

	public void M952(int x, int y, int w, int h, int arcWidth, int arcHeight)
	{
		M931(x, y, w, h);
	}

	public void M953(int x, int y, int width, int height, int arcWidth, int arcHeight)
	{
		M932(x, y, width, height);
	}

	public void M954()
	{
		isClip = false;
		isTranslate = false;
		translateX = 0;
		translateY = 0;
	}

	public Rect M955(Rect r1, Rect r2)
	{
		float num = r1.x;
		float num2 = r1.y;
		float x = r2.x;
		float y = r2.y;
		float num3 = num + r1.width;
		float num4 = num2 + r1.height;
		float num5 = x + r2.width;
		float num6 = y + r2.height;
		if (num < x)
		{
			num = x;
		}
		if (num2 < y)
		{
			num2 = y;
		}
		if (num3 > num5)
		{
			num3 = num5;
		}
		if (num4 > num6)
		{
			num4 = num6;
		}
		num3 -= num;
		num4 -= num2;
		if (num3 < -30000f)
		{
			num3 = -30000f;
		}
		if (num4 < -30000f)
		{
			num4 = -30000f;
		}
		return new Rect(num, num2, (int)num3, (int)num4);
	}

	public void M956(T60 image, int x, int y, int w, int h, int tranform)
	{
		GUI.color = Color.red;
		x *= zoomLevel;
		y *= zoomLevel;
		w *= zoomLevel;
		h *= zoomLevel;
		if (image != null)
		{
			Graphics.DrawTexture(new Rect(x + translateX, y + translateY, (tranform != 0) ? (-w) : w, h), image.texture);
		}
	}

	public void M957(T60 image, int x, int y)
	{
		x *= zoomLevel;
		y *= zoomLevel;
		if (image != null)
		{
			Graphics.DrawTexture(new Rect(x, y, image.w, image.h), image.texture);
		}
	}

	public static int M958(T60 image)
	{
		return image.M727();
	}

	public static int M959(T60 image)
	{
		return image.M728();
	}

	public static bool M960(Color color)
	{
		if (!(color == Color.clear) && !(color == transParentColor))
		{
			return true;
		}
		return false;
	}

	public static T60 M961(T60 img0, float level, int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float num4 = (float)num / 256f;
		float num5 = (float)num2 / 256f;
		Color color = new Color((float)num3 / 256f, num5, num4);
		Color[] pixels = img0.texture.GetPixels();
		float num6 = color.r;
		float num7 = color.g;
		float num8 = color.b;
		for (int i = 0; i < pixels.Length; i++)
		{
			Color color2 = pixels[i];
			if (M960(color2))
			{
				float num9 = (num6 - color2.r) * level + color2.r;
				float num10 = (num7 - color2.g) * level + color2.g;
				float num11 = (num8 - color2.b) * level + color2.b;
				if (num9 > 255f)
				{
					num9 = 255f;
				}
				if (num9 < 0f)
				{
					num9 = 0f;
				}
				if (num10 > 255f)
				{
					num10 = 255f;
				}
				if (num10 < 0f)
				{
					num10 = 0f;
				}
				if (num11 < 0f)
				{
					num11 = 0f;
				}
				if (num11 > 255f)
				{
					num11 = 255f;
				}
				pixels[i].r = num9;
				pixels[i].g = num10;
				pixels[i].b = num11;
			}
		}
		T60 t = T60.M706(img0.M732(), img0.M733());
		t.texture.SetPixels(pixels);
		T60.M730(t.texture);
		t.texture.Apply();
		T24.M329("BLEND ----------------------------------------------------");
		return t;
	}

	public static Color M962(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float num4 = (float)num / 256f;
		float num5 = (float)num2 / 256f;
		return new Color((float)num3 / 256f, num5, num4);
	}

	public void M963(T60 imgTrans, int x, int y, int w, int h)
	{
		M937(0, 0.5f);
		M932(x * zoomLevel, y * zoomLevel, w * zoomLevel, h * zoomLevel);
	}

	public static int M964(float level, int color, int colorBlend)
	{
		Color color2 = M962(colorBlend);
		float num = color2.r * 255f;
		float num2 = color2.g * 255f;
		float num3 = color2.b * 255f;
		Color color3 = M962(color);
		float num4 = (num + color3.r) * level + color3.r;
		float num5 = (num2 + color3.g) * level + color3.g;
		float num6 = (num3 + color3.b) * level + color3.b;
		if (num4 > 255f)
		{
			num4 = 255f;
		}
		if (num4 < 0f)
		{
			num4 = 0f;
		}
		if (num5 > 255f)
		{
			num5 = 255f;
		}
		if (num5 < 0f)
		{
			num5 = 0f;
		}
		if (num6 < 0f)
		{
			num6 = 0f;
		}
		if (num6 > 255f)
		{
			num6 = 255f;
		}
		return (int)num6 & (255 + ((int)num5 << 8)) & (255 + ((int)num4 << 16)) & 0xFF;
	}

	public static int M965(Color cl)
	{
		float num = cl.r * 255f;
		float num2 = cl.b;
		return (((int)num & 0xFF) << 16) | (((int)(cl.g * 255f) & 0xFF) << 8) | ((int)(num2 * 255f) & 0xFF);
	}

	public static int M966(T60 img)
	{
		return img.w;
	}

	public static int M967(T60 img)
	{
		return img.h;
	}

	public void M968(int i, int j, int k, int l, int m, int n)
	{
		M932(i * zoomLevel, j * zoomLevel, k * zoomLevel, l * zoomLevel);
	}

	public void M969()
	{
		if (!lineMaterial)
		{
			lineMaterial = new Material("Shader \"Lines/Colored Blended\" {SubShader { Pass {  Blend SrcAlpha OneMinusSrcAlpha  ZWrite Off Cull Off Fog { Mode Off }  BindChannels { Bind \"vertex\", vertex Bind \"color\", color }} } }");
			lineMaterial.hideFlags = HideFlags.HideAndDontSave;
			lineMaterial.shader.hideFlags = HideFlags.HideAndDontSave;
		}
	}

	public void M970(T117 totalLine)
	{
		lineMaterial.SetPass(0);
		GL.PushMatrix();
		GL.Begin(1);
		for (int i = 0; i < totalLine.M1113(); i++)
		{
			T100 t = (T100)totalLine.M1114(i);
			GL.Color(new Color(t.r, t.g, t.b, t.a));
			int num = t.x1 * zoomLevel;
			int num2 = t.y1 * zoomLevel;
			int num3 = t.x2 * zoomLevel;
			int num4 = t.y2 * zoomLevel;
			if (isTranslate)
			{
				num += translateX;
				num2 += translateY;
				num3 += translateX;
				num4 += translateY;
			}
			for (int j = 0; j < zoomLevel; j++)
			{
				GL.Vertex(new Vector2(num + j, num2 + j));
				GL.Vertex(new Vector2(num3 + j, num4 + j));
				if (j > 0)
				{
					GL.Vertex(new Vector2(num + j, num2));
					GL.Vertex(new Vector2(num3 + j, num4));
					GL.Vertex(new Vector2(num, num2 + j));
					GL.Vertex(new Vector2(num3, num4 + j));
				}
			}
		}
		GL.End();
		GL.PopMatrix();
		totalLine.M1120();
	}

	public void M971(T99 g, int x, int y, int xTo, int yTo, int nLine, int color)
	{
		T117 t = new T117();
		for (int i = 0; i < nLine; i++)
		{
			t.M1111(new T100(x, y, xTo + i, yTo + i, color));
		}
		g.M970(t);
	}

	internal void M972(T211 img, int p1, int p2, int p3, int p4, int transform, int x, int y, int anchor)
	{
		throw new NotImplementedException();
	}
}
