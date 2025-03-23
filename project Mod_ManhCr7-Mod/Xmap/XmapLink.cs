namespace N0.N1.N2;

public struct XmapLink
{
	public int MapID;

	public XmapLinkType Type;

	public int[] Info;

	public XmapLink(int mapID, XmapLinkType type, int[] info)
	{
		MapID = mapID;
		Type = type;
		Info = info;
	}
}
