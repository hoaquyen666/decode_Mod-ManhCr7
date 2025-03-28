using System.Collections.Generic;

namespace Xmap;

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
