using System.Collections.Generic;

namespace N0.N1.N2;

public struct XmapGroup
{
	public string NameGroup;

	public List<int> IdMaps;

	public XmapGroup(string nameGroup, List<int> idMaps)
	{
		NameGroup = nameGroup;
		IdMaps = idMaps;
	}
}
