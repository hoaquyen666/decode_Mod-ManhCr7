using System.Collections.Generic;
using UnityEngine;

public class ScaleUI
{
	public static bool scaleScreen;

	public static float WIDTH;

	public static float HEIGHT;

	private static List<Matrix4x4> stack = new List<Matrix4x4>();

	public static void M1555()
	{
		Cout.M326("Init Scale GUI: Screen.w=" + Screen.width + " Screen.h=" + Screen.height);
		WIDTH = Screen.width;
		HEIGHT = Screen.height;
		scaleScreen = false;
		_ = Screen.width;
	}

	public static void M1556()
	{
		if (scaleScreen)
		{
			stack.Add(GUI.matrix);
			Matrix4x4 matrix4x = default(Matrix4x4);
			float num = (float)Screen.width / (float)Screen.height;
			float num2 = 1f;
			Vector3 zero = Vector3.zero;
			num2 = ((!(num < WIDTH / HEIGHT)) ? ((float)Screen.height / HEIGHT) : ((float)Screen.width / WIDTH));
			matrix4x.SetTRS(zero, Quaternion.identity, Vector3.one * num2);
			GUI.matrix *= matrix4x;
		}
	}

	public static void M1557()
	{
		if (scaleScreen)
		{
			GUI.matrix = stack[stack.Count - 1];
			stack.RemoveAt(stack.Count - 1);
		}
	}

	public static float M1558(float x)
	{
		if (!scaleScreen)
		{
			return x;
		}
		x = x * WIDTH / (float)Screen.width;
		return x;
	}

	public static float M1559(float y)
	{
		if (!scaleScreen)
		{
			return y;
		}
		y = y * HEIGHT / (float)Screen.height;
		return y;
	}
}
