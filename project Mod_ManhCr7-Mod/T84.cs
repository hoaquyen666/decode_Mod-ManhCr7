public class T84
{
	public short id;

	public sbyte type;

	public sbyte gender;

	public string name;

	public string[] subName;

	public string description;

	public sbyte level;

	public short iconID;

	public short part;

	public bool isUpToUp;

	public int w;

	public int h;

	public int strRequire;

	public T84(short templateID, sbyte type, sbyte gender, string name, string description, sbyte level, int strRequire, short iconID, short part, bool isUpToUp)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		id = templateID;
		this.type = type;
		this.gender = gender;
		this.name = name;
		this.name = T137.M1518(this.name);
		this.description = description;
		this.description = T137.M1518(this.description);
		this.level = level;
		this.strRequire = strRequire;
		this.iconID = iconID;
		this.part = part;
		this.isUpToUp = isUpToUp;
	}
}
