using System;

public class T116
{
	public static T28 M1110(string path)
	{
		path = Main.res + path;
		try
		{
			return T28.M350(path);
		}
		catch (Exception)
		{
			return null;
		}
	}
}
