using System;

public class MyStream
{
	public static DataInputStream M1110(string path)
	{
		path = Main.res + path;
		try
		{
			return DataInputStream.M350(path);
		}
		catch (Exception)
		{
			return null;
		}
	}
}
